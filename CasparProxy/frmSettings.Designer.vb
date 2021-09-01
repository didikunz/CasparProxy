<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
      Me.btnOk = New NiceButton()
      Me.btnCancel = New NiceButton()
      Me.btnAdd = New NiceButton()
      Me.tabTab = New System.Windows.Forms.TabControl()
        Me.tabPresets = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
      Me.CtrFileTextBox1 = New ctrFileTextBox()
      Me.bsMappings = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMappings = New System.Windows.Forms.ListBox()
      Me.btnRemove = New NiceButton()
      Me.tabTab.SuspendLayout()
        Me.tabPresets.SuspendLayout()
        CType(Me.bsMappings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(337, 331)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(101, 38)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Tag = "[highlite]"
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(444, 331)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 38)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Tag = "[highlite]"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.CasparProxy.My.Resources.Resources.Plus_W
        Me.btnAdd.Location = New System.Drawing.Point(6, 251)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 30)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Tag = "[highlite]"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'tabTab
        '
        Me.tabTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTab.Controls.Add(Me.tabPresets)
        Me.tabTab.Location = New System.Drawing.Point(12, 12)
        Me.tabTab.Name = "tabTab"
        Me.tabTab.SelectedIndex = 0
        Me.tabTab.Size = New System.Drawing.Size(533, 313)
        Me.tabTab.TabIndex = 3
        '
        'tabPresets
        '
        Me.tabPresets.Controls.Add(Me.Label3)
        Me.tabPresets.Controls.Add(Me.CtrFileTextBox1)
        Me.tabPresets.Controls.Add(Me.TextBox1)
        Me.tabPresets.Controls.Add(Me.Label2)
        Me.tabPresets.Controls.Add(Me.txtPort)
        Me.tabPresets.Controls.Add(Me.txtAddress)
        Me.tabPresets.Controls.Add(Me.lblPort)
        Me.tabPresets.Controls.Add(Me.lblAddress)
        Me.tabPresets.Controls.Add(Me.txtName)
        Me.tabPresets.Controls.Add(Me.Label1)
        Me.tabPresets.Controls.Add(Me.lbMappings)
        Me.tabPresets.Controls.Add(Me.btnRemove)
        Me.tabPresets.Controls.Add(Me.btnAdd)
        Me.tabPresets.Location = New System.Drawing.Point(4, 22)
        Me.tabPresets.Name = "tabPresets"
        Me.tabPresets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPresets.Size = New System.Drawing.Size(525, 287)
        Me.tabPresets.TabIndex = 0
        Me.tabPresets.Text = "Server Presets"
        Me.tabPresets.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "CasparCG Programm File:"
        '
        'CtrFileTextBox1
        '
        Me.CtrFileTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrFileTextBox1.CheckIfFileExists = False
        Me.CtrFileTextBox1.CustomDialogFilter = "CasparCG Exe-File (casparcg*.exe)|casparcg*.exe|Exe-Files (*.exe)|*.exe||"
        Me.CtrFileTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Filename", Me.bsMappings, "CasparExePath", True))
      Me.CtrFileTextBox1.DialogFilter = ctrFileTextBox.DialogFilterType.dtfCustom
      Me.CtrFileTextBox1.DialogType = ctrFileTextBox.enumDialogType.OpenDialog
      Me.CtrFileTextBox1.ErrorColor = System.Drawing.Color.Red
        Me.CtrFileTextBox1.Filename = ""
        Me.CtrFileTextBox1.IntialDirectory = ""
        Me.CtrFileTextBox1.Location = New System.Drawing.Point(149, 152)
        Me.CtrFileTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrFileTextBox1.MaximumSize = New System.Drawing.Size(30000, 20)
        Me.CtrFileTextBox1.MinimumSize = New System.Drawing.Size(75, 20)
        Me.CtrFileTextBox1.Name = "CtrFileTextBox1"
        Me.CtrFileTextBox1.OverwritePrompt = True
        Me.CtrFileTextBox1.ShowClearButton = True
        Me.CtrFileTextBox1.Size = New System.Drawing.Size(366, 20)
        Me.CtrFileTextBox1.TabIndex = 24
        Me.CtrFileTextBox1.ToolTipControl = Nothing
        '
        'bsMappings
        '
        Me.bsMappings.DataSource = GetType(CasparProxy.ServerMapping)
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMappings, "Channels", True))
        Me.TextBox1.Location = New System.Drawing.Point(149, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(366, 20)
        Me.TextBox1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Mapping (Channels sepaarated by spaces, empty=all):"
        '
        'txtPort
        '
        Me.txtPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMappings, "Port", True))
        Me.txtPort.Location = New System.Drawing.Point(428, 108)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(87, 20)
        Me.txtPort.TabIndex = 21
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMappings, "ServerAdress", True))
        Me.txtAddress.Location = New System.Drawing.Point(149, 108)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(273, 20)
        Me.txtAddress.TabIndex = 20
        '
        'lblPort
        '
        Me.lblPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(425, 92)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 19
        Me.lblPort.Text = "Port:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(146, 92)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 18
        Me.lblAddress.Text = "Address:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMappings, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(149, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(366, 20)
        Me.txtName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name:"
        '
        'lbMappings
        '
        Me.lbMappings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbMappings.DataSource = Me.bsMappings
        Me.lbMappings.DisplayMember = "Name"
        Me.lbMappings.FormattingEnabled = True
        Me.lbMappings.Location = New System.Drawing.Point(6, 6)
        Me.lbMappings.Name = "lbMappings"
        Me.lbMappings.Size = New System.Drawing.Size(134, 238)
        Me.lbMappings.TabIndex = 4
        Me.lbMappings.ValueMember = "Name"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Image = Global.CasparProxy.My.Resources.Resources.Minus_W
        Me.btnRemove.Location = New System.Drawing.Point(76, 251)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(64, 30)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Tag = "[highlite]"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(557, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabTab)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.tabTab.ResumeLayout(False)
        Me.tabPresets.ResumeLayout(False)
        Me.tabPresets.PerformLayout()
        CType(Me.bsMappings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

   Friend WithEvents btnOk As NiceButton
   Friend WithEvents btnCancel As NiceButton
   Friend WithEvents btnAdd As NiceButton
   Friend WithEvents tabTab As TabControl
    Friend WithEvents tabPresets As TabPage
   Friend WithEvents btnRemove As NiceButton
   Friend WithEvents bsMappings As BindingSource
    Friend WithEvents lbMappings As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
   Friend WithEvents CtrFileTextBox1 As ctrFileTextBox
End Class
