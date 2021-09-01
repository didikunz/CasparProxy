Imports System.Windows.Forms

Public Class NiceButton
   Inherits System.Windows.Forms.Button

   Public Shadows Event Click As EventHandler
   Public Event ControlClick As EventHandler
   Public Event ShiftClick As EventHandler
   Public Event AltClick As EventHandler
   Public Shadows Event MouseUp As MouseEventHandler

   Public Sub New()
      Me.BackColor = Drawing.Color.FromArgb(204, 26, 27)
      Me.ForeColor = Drawing.Color.White
      Me.Font = New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, Drawing.FontStyle.Bold)
   End Sub

   Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
      If mevent.Button = MouseButtons.Left And Control.ModifierKeys = Keys.None Then
         RaiseEvent Click(Me, New System.EventArgs)
      ElseIf mevent.Button = MouseButtons.Left And Control.ModifierKeys = Keys.Control Then
         RaiseEvent ControlClick(Me, New System.EventArgs)
      ElseIf mevent.Button = MouseButtons.Left And Control.ModifierKeys = Keys.Shift Then
         RaiseEvent ShiftClick(Me, New System.EventArgs)
      ElseIf mevent.Button = MouseButtons.Left And Control.ModifierKeys = Keys.Alt Then
         RaiseEvent AltClick(Me, New System.EventArgs)
      Else
         RaiseEvent MouseUp(Me, mevent)
      End If
   End Sub

End Class
