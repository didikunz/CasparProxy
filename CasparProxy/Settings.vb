Imports System.IO
Imports System.Xml.Serialization

<Serializable>
Public Class Settings

   Private _ServerMappings As List(Of ServerMapping) = New List(Of ServerMapping)

   Public ReadOnly Property ServerMappings As List(Of ServerMapping)
      Get
         Return _ServerMappings
      End Get
   End Property

   Public Property Minimize2Tray As Boolean = True

   Public Property MainLocation() As System.Drawing.Point = New System.Drawing.Point(0, 0)
   Public Property MainSize() As System.Drawing.Size = New System.Drawing.Size(660, 480)
   Public Property MainWindowstate() As System.Windows.Forms.FormWindowState = FormWindowState.Normal

   Public Sub SetWindowPos(Wnd As Form)
      Wnd.Location = Me.MainLocation
      Wnd.Size = Me.MainSize
      Wnd.WindowState = Me.MainWindowstate
   End Sub

   Public Sub ReadWindowPos(Wnd As Form)
      If Wnd.WindowState = FormWindowState.Normal Then
         Me.MainLocation = Wnd.Location
         Me.MainSize = Wnd.Size
         Me.MainWindowstate = FormWindowState.Normal
      ElseIf Wnd.WindowState = FormWindowState.Maximized Then
         Me.MainWindowstate = FormWindowState.Maximized
      End If
   End Sub


   Public Sub Save(ByVal XMLFile As String)

      Dim wr As StreamWriter = Nothing

      Try
         Dim ser As XmlSerializer = New XmlSerializer(GetType(Settings))
         wr = New StreamWriter(XMLFile)
         ser.Serialize(wr, Me)
      Catch ex As Exception
         Throw (New Exception("WriteToXML: " + ex.Message, ex))
      Finally
         wr.Close()
      End Try

   End Sub

   Private Function ReadFromXML(ByVal XMLFile As String) As Object

      Dim fs As FileStream = Nothing
      Dim obj As Object

      Try
         Dim ser As XmlSerializer = New XmlSerializer(GetType(Settings))
         fs = New FileStream(XMLFile, FileMode.Open)
         obj = ser.Deserialize(fs)
      Catch ex As Exception
         Throw (New Exception("ReadFromXML: " + ex.Message, ex))
      Finally
         fs.Close()
      End Try

      Return obj

   End Function

   Public Sub New()

   End Sub

   Sub New(ByVal XMLFile As String)

      Dim sets As Settings = ReadFromXML(XMLFile)

      _ServerMappings = sets.ServerMappings

      Minimize2Tray = sets.Minimize2Tray

      MainLocation = sets.MainLocation
      MainSize = sets.MainSize
      MainWindowstate = sets.MainWindowstate

   End Sub

End Class
