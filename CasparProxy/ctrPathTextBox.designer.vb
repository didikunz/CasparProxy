<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrPathTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.txtPath = New System.Windows.Forms.TextBox()
      Me.btnPath = New System.Windows.Forms.Button()
      Me.btnClear = New System.Windows.Forms.Button()
      Me.fbdPath = New System.Windows.Forms.FolderBrowserDialog()
      Me.SuspendLayout()
      '
      'txtPath
      '
      Me.txtPath.Location = New System.Drawing.Point(0, 0)
      Me.txtPath.Margin = New System.Windows.Forms.Padding(0)
      Me.txtPath.Name = "txtPath"
      Me.txtPath.Size = New System.Drawing.Size(333, 20)
      Me.txtPath.TabIndex = 1
      '
      'btnPath
      '
      Me.btnPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnPath.Location = New System.Drawing.Point(362, 0)
      Me.btnPath.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
      Me.btnPath.Name = "btnPath"
      Me.btnPath.Size = New System.Drawing.Size(23, 20)
      Me.btnPath.TabIndex = 1
      Me.btnPath.Text = "…"
      Me.btnPath.UseVisualStyleBackColor = True
      '
      'btnClear
      '
      Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClear.Location = New System.Drawing.Point(336, 0)
      Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
      Me.btnClear.Name = "btnClear"
      Me.btnClear.Size = New System.Drawing.Size(23, 20)
      Me.btnClear.TabIndex = 2
      Me.btnClear.Text = "X"
      Me.btnClear.UseVisualStyleBackColor = True
      '
      'ctrPathTextBox
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Transparent
      Me.Controls.Add(Me.txtPath)
      Me.Controls.Add(Me.btnPath)
      Me.Controls.Add(Me.btnClear)
      Me.MaximumSize = New System.Drawing.Size(30000, 20)
      Me.Name = "ctrPathTextBox"
      Me.Size = New System.Drawing.Size(385, 20)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnPath As System.Windows.Forms.Button
   Friend WithEvents txtPath As System.Windows.Forms.TextBox
   Friend WithEvents fbdPath As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
