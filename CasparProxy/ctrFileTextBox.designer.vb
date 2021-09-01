<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrFileTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.btnFileOpen = New System.Windows.Forms.Button()
      Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
      Me.btnClear = New System.Windows.Forms.Button()
      Me.dlgSaveFile = New System.Windows.Forms.SaveFileDialog()
      Me.txtFileName = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'btnFileOpen
      '
      Me.btnFileOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnFileOpen.Location = New System.Drawing.Point(346, 0)
      Me.btnFileOpen.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
      Me.btnFileOpen.Name = "btnFileOpen"
      Me.btnFileOpen.Size = New System.Drawing.Size(22, 20)
      Me.btnFileOpen.TabIndex = 9
      Me.btnFileOpen.Text = "…"
      Me.btnFileOpen.UseVisualStyleBackColor = True
      '
      'btnClear
      '
      Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClear.Location = New System.Drawing.Point(321, 0)
      Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
      Me.btnClear.Name = "btnClear"
      Me.btnClear.Size = New System.Drawing.Size(22, 20)
      Me.btnClear.TabIndex = 10
      Me.btnClear.Text = "X"
      Me.btnClear.UseVisualStyleBackColor = True
      '
      'txtFileName
      '
      Me.txtFileName.BackColor = System.Drawing.SystemColors.Window
      Me.txtFileName.Location = New System.Drawing.Point(0, 0)
      Me.txtFileName.Margin = New System.Windows.Forms.Padding(0)
      Me.txtFileName.Name = "txtFileName"
      Me.txtFileName.ReadOnly = True
      Me.txtFileName.Size = New System.Drawing.Size(318, 20)
      Me.txtFileName.TabIndex = 8
      '
      'ctrFileTextBox
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Transparent
      Me.Controls.Add(Me.btnFileOpen)
      Me.Controls.Add(Me.txtFileName)
      Me.Controls.Add(Me.btnClear)
      Me.Margin = New System.Windows.Forms.Padding(0)
      Me.MaximumSize = New System.Drawing.Size(30000, 20)
      Me.MinimumSize = New System.Drawing.Size(75, 20)
      Me.Name = "ctrFileTextBox"
      Me.Size = New System.Drawing.Size(369, 20)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtName As System.Windows.Forms.TextBox
   Friend WithEvents btnFileOpen As System.Windows.Forms.Button
   Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
   Friend WithEvents dlgSaveFile As System.Windows.Forms.SaveFileDialog
   Friend WithEvents btnClear As System.Windows.Forms.Button
   Friend WithEvents txtFileName As System.Windows.Forms.TextBox

End Class
