Imports System.Net
Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Threading
Imports CasparObjects

Public Class frmMain

   Private _Settings As Settings
   Private _SettingsFName As String

   Private Shared ReadOnly _Caspars As List(Of CasparCG) = New List(Of CasparCG)

   Private Shared _uiContext As SynchronizationContext
   Private Shared _postback As SendOrPostCallback

   Private Shared ReadOnly _listener As HttpListener = New HttpListener
   Private Shared _mainLoop As Task

   Shared ReadOnly _client As HttpClient = New HttpClient()

   Private _closeProgram As Boolean = False
   Private WithEvents _timAfterStartup As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()

   Public Shared Sub StartWebServer()
      If _mainLoop Is Nothing Then
         _mainLoop = MainLoop()
      End If
   End Sub

   Public Shared Sub StopWebServer()
      SyncLock _listener
         _listener.[Stop]()
      End SyncLock
   End Sub

   Private Shared Async Function MainLoop() As Task

      _listener.Prefixes.Add("http://127.0.0.1:9731/amcp/")
      _listener.Prefixes.Add("http://127.0.0.1:9731/file/")
      _listener.Start()

      Do
         Try
            Dim context = Await _listener.GetContextAsync()

            SyncLock _listener
               ProcessRequest(context)
            End SyncLock

         Catch e As Exception
            Debug.Print(e.Message)
            If TypeOf e Is HttpListenerException Then Exit Do
         End Try

      Loop

   End Function

   Public Sub UpdateUI(state As Object)

      Dim txt As String = CType(state, String)

      If rtbLog.Lines.Length > 300 Then
         For c As Integer = 0 To 200
            rtbLog.Text = String.Format("[{0:HH:mm:ss.ff}] LOG CLEARED{1}", Date.Now, vbNewLine)
         Next
      End If

      rtbLog.AppendText(String.Format("[{0:HH:mm:ss.ff}] {1}{2}", Date.Now, txt, vbNewLine))

      rtbLog.SelectionStart = rtbLog.TextLength
      rtbLog.ScrollToCaret()

   End Sub


   Private Shared Sub ProcessRequest(ByVal context As HttpListenerContext)

      Using response As HttpListenerResponse = context.Response


         Try

            Using body As Stream = context.Request.InputStream

               Using reader As StreamReader = New StreamReader(body, context.Request.ContentEncoding)

                  If context.Request.RawUrl.Contains("amcp") Then

                     Dim cmd As String = reader.ReadToEnd

                     Dim lines() As String = cmd.Split(vbCr)
                     For Each s As String In lines

                        For Each cas As CasparCG In _Caspars
                           cas.ExecuteFiltered(s.Replace(vbLf, ""))
                           _uiContext.Post(_postback, s.Replace(vbLf, ""))
                        Next

                     Next

                     response.StatusCode = 202

                  ElseIf context.Request.RawUrl.Contains("file") Then

                     Dim filename As String = reader.ReadToEnd
                     filename = filename.Replace("/", "\")

                     If File.Exists(filename) Then

                        Dim txt As String = File.ReadAllText(filename)
                        Dim buffer As Byte() = Encoding.UTF8.GetBytes(txt)

                        response.ContentType = "text"
                        response.ContentLength64 = buffer.Length

                        Dim out As Stream = response.OutputStream
                        out.Write(buffer, 0, buffer.Length)
                        out.Close()

                        _uiContext.Post(_postback, String.Format("Sent file '{0}'", filename))
                        response.StatusCode = 200

                     Else
                        response.StatusCode = 404
                     End If

                  End If

               End Using

            End Using

         Catch e As Exception
            _uiContext.Post(_postback, "ERROR: " + e.Message)
         End Try


      End Using

   End Sub

   Private Function GetServerStartErrorText(result As CasparCG.enumConnectResult, cas As CasparCG) As String

      Dim ret As String

      Select Case result
         Case CasparCG.enumConnectResult.crMachineNotAvailable
            ret = String.Format("Machine at [{0}] is not running.", cas.ServerAdress)
         Case CasparCG.enumConnectResult.crCasparCGNotStarted
            ret = String.Format("CasparCG Server at [{0}:{1}] is not started.", cas.ServerAdress, cas.Port)
         Case CasparCG.enumConnectResult.crLocalCasparCGCouldNotBeStarted
            ret = String.Format("Path to CasparCG Server seems wrong: '{0}'.", cas.CasparExePath)
         Case CasparCG.enumConnectResult.crIsNotLocal
            ret = "CasparCG Server could not be started."
         Case Else
            ret = ""
      End Select

      Return ret

   End Function

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      Loader.Load(Me, Loader.CreateDarkTheme)

      _uiContext = SynchronizationContext.Current
      _postback = New SendOrPostCallback(AddressOf UpdateUI)

      Dim cap As CommonApplicationData = Nothing
      Try

         cap = New CommonApplicationData("MediaSupport", My.Application.Info.Title, True)
         _SettingsFName = IO.Path.Combine(cap.ApplicationFolderPath, "Settings.xml")

         If IO.File.Exists(_SettingsFName) Then
            _Settings = New Settings(_SettingsFName)
         Else
            _Settings = New Settings()
         End If

         _Settings.SetWindowPos(Me)

         Dim conRes As CasparCG.enumConnectResult
         If _Settings.ServerMappings.Count = 0 Then

            Dim cas As CasparCG = New CasparCG()
            conRes = cas.Connect()
            If conRes = CasparCG.enumConnectResult.crSuccessfull Then
               _Caspars.Add(cas)
            Else
               MsgBox(GetServerStartErrorText(conRes, cas), MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Server Problems")
            End If

         Else

            Dim errText As String = ""

            For Each map As ServerMapping In _Settings.ServerMappings
               Dim cas As CasparCG = New CasparCG()
               cas.ChannelFilterList = map.Channels
               cas.ServerAdress = map.ServerAdress
               cas.Port = map.Port
               cas.CasparExePath = map.CasparExePath
               cas.Retries = 20
               conRes = cas.Connect()
               If conRes = CasparCG.enumConnectResult.crSuccessfull Then
                  _Caspars.Add(cas)
               Else
                  errText += GetServerStartErrorText(conRes, cas) + vbNewLine
               End If
            Next

            If errText <> "" Then
               MsgBox(errText, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Server Problems")
            End If

         End If


      Catch ex As Exception

         _Settings = New Settings()
         MsgBox("Something went wrong with the settings. Please check them, before you start to use the system.")
         mnuFileSettings_Click(Me, EventArgs.Empty)

      End Try

      StartWebServer()

      If _Settings.Minimize2Tray Then
         _timAfterStartup.Interval = 50
         _timAfterStartup.Start()
      End If

   End Sub

   Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
      If WindowState = FormWindowState.Minimized Then
         Hide()
         niTaskbarIcon.Visible = True
      End If
   End Sub

   Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

      If Not (e.CloseReason = CloseReason.WindowsShutDown Or _closeProgram) Then

         e.Cancel = True
         Hide()

      Else

         If _Settings IsNot Nothing Then

            _Settings.Minimize2Tray = Not Visible
            _Settings.ReadWindowPos(Me)
            _Settings.Save(_SettingsFName)

         End If

         StopWebServer()

         For Each cas As CasparCG In _Caspars
            If cas.Connected Then
               cas.Disconnect()
               cas.Shutdown(False)
            End If
         Next

      End If

   End Sub

   Private Sub mnuFileSettings_Click(sender As Object, e As EventArgs) Handles mnuFileSettings.Click

      Dim fs As frmSettings = New frmSettings
      fs.Settings = _Settings

      fs.ShowDialog(Me)

   End Sub

   Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
      _closeProgram = True
      Close()
   End Sub

   Private Sub cntmnuTrayShowUserInterface_Click(sender As Object, e As EventArgs) Handles cntmnuTrayShowUserInterface.Click
      Show()
      WindowState = FormWindowState.Normal
   End Sub

   Private Sub cntmnuTrayExit_Click(sender As Object, e As EventArgs) Handles cntmnuTrayExit.Click
      _closeProgram = True
      Close()
   End Sub

   Private Sub _timAfterStartup_Tick(sender As Object, e As EventArgs) Handles _timAfterStartup.Tick
      _timAfterStartup.Stop()
      WindowState = FormWindowState.Minimized
   End Sub

End Class
