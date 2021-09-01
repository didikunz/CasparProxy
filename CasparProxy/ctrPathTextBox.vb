Imports System.ComponentModel

<DefaultBindingProperty("Path"), _
DefaultProperty("Path"), _
DefaultEvent("PathChanged")> _
Public Class ctrPathTextBox

#Region "Public Declares"

   Public Event PathChanged As EventHandler

#End Region

#Region "Private Vars"

   Private _ToolTipControl As ToolTip = Nothing
   Private _ShowClearButton As Boolean = True

#End Region

#Region "Accessor Properties"

   Public Property ShowClearButton() As Boolean
      Get
         Return _ShowClearButton
      End Get
      Set(ByVal value As Boolean)
         _ShowClearButton = value
         ctrPathTextBox_Resize(Me, System.EventArgs.Empty)
      End Set
   End Property

   Public Property Path() As String
      Get
         Return txtPath.Text
      End Get
      Set(ByVal Value As String)
         txtPath.Text = Value
         RaiseEvent PathChanged(Me, EventArgs.Empty)
      End Set
   End Property

   Public Property ToolTipControl() As ToolTip
      Get
         Return _ToolTipControl
      End Get
      Set(ByVal value As ToolTip)
         _ToolTipControl = value
         If _ToolTipControl IsNot Nothing Then
            If _ToolTipControl.GetToolTip(Me) IsNot Nothing Then
               _ToolTipControl.SetToolTip(txtPath, _ToolTipControl.GetToolTip(Me))
               _ToolTipControl.SetToolTip(btnClear, _ToolTipControl.GetToolTip(Me))
               _ToolTipControl.SetToolTip(btnPath, _ToolTipControl.GetToolTip(Me))
            End If
         End If
      End Set
   End Property

   Public Property RootFolder As System.Environment.SpecialFolder
      Get
         Return fbdPath.RootFolder
      End Get
      Set(value As System.Environment.SpecialFolder)
         fbdPath.RootFolder = value
      End Set
   End Property

#End Region

#Region "Private Functions"

#End Region

#Region "Methods"

#End Region

#Region "Form/UserControl Stuff"

   Private Sub btnPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPath.Click
      fbdPath.SelectedPath = txtPath.Text
      fbdPath.Description = "Pfad auswählen"
      If fbdPath.ShowDialog = DialogResult.OK Then
         txtPath.Text = fbdPath.SelectedPath
         RaiseEvent PathChanged(Me, EventArgs.Empty)
      End If
   End Sub

   Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
      Me.Path = ""
   End Sub

   Private Sub ctrPathTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

      btnPath.Left = Me.ClientRectangle.Width - btnPath.Width
      btnClear.Left = btnPath.Left - btnClear.Width - 3
      If _ShowClearButton Then
         btnClear.Visible = True
         txtPath.Width = btnClear.Left - 3
      Else
         btnClear.Visible = False
         txtPath.Width = btnPath.Left - 3
      End If

   End Sub

#End Region

#Region "Constructors"

#End Region

End Class
