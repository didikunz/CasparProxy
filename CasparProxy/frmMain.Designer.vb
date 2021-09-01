<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.niTaskbarIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cntmnuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cntmnuTrayShowUserInterface = New System.Windows.Forms.ToolStripMenuItem()
        Me.cntmnuTraySep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cntmnuTrayExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.cntmnuTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(800, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "mnuMain"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSettings, Me.mnuFileSep1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileSettings
        '
        Me.mnuFileSettings.Name = "mnuFileSettings"
        Me.mnuFileSettings.Size = New System.Drawing.Size(135, 22)
        Me.mnuFileSettings.Text = "Settings..."
        '
        'mnuFileSep1
        '
        Me.mnuFileSep1.Name = "mnuFileSep1"
        Me.mnuFileSep1.Size = New System.Drawing.Size(132, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(135, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'rtbLog
        '
        Me.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbLog.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLog.Location = New System.Drawing.Point(0, 24)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(800, 426)
        Me.rtbLog.TabIndex = 2
        Me.rtbLog.Text = ""
        Me.rtbLog.WordWrap = False
        '
        'niTaskbarIcon
        '
        Me.niTaskbarIcon.BalloonTipTitle = "CasparCG Font Smoothing"
        Me.niTaskbarIcon.ContextMenuStrip = Me.cntmnuTray
        Me.niTaskbarIcon.Icon = CType(resources.GetObject("niTaskbarIcon.Icon"), System.Drawing.Icon)
        '
        'cntmnuTray
        '
        Me.cntmnuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cntmnuTrayShowUserInterface, Me.cntmnuTraySep1, Me.cntmnuTrayExit})
        Me.cntmnuTray.Name = "cntmnuTray"
        Me.cntmnuTray.Size = New System.Drawing.Size(187, 54)
        '
        'cntmnuTrayShowUserInterface
        '
        Me.cntmnuTrayShowUserInterface.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cntmnuTrayShowUserInterface.Name = "cntmnuTrayShowUserInterface"
        Me.cntmnuTrayShowUserInterface.Size = New System.Drawing.Size(186, 22)
        Me.cntmnuTrayShowUserInterface.Text = "Show user interface"
        '
        'cntmnuTraySep1
        '
        Me.cntmnuTraySep1.Name = "cntmnuTraySep1"
        Me.cntmnuTraySep1.Size = New System.Drawing.Size(183, 6)
        '
        'cntmnuTrayExit
        '
        Me.cntmnuTrayExit.Name = "cntmnuTrayExit"
        Me.cntmnuTrayExit.Size = New System.Drawing.Size(186, 22)
        Me.cntmnuTrayExit.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rtbLog)
        Me.Controls.Add(Me.msMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "CaspaarCG Proxy"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.cntmnuTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileSettings As ToolStripMenuItem
    Friend WithEvents mnuFileSep1 As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents niTaskbarIcon As NotifyIcon
    Friend WithEvents cntmnuTray As ContextMenuStrip
    Friend WithEvents cntmnuTrayShowUserInterface As ToolStripMenuItem
    Friend WithEvents cntmnuTraySep1 As ToolStripSeparator
    Friend WithEvents cntmnuTrayExit As ToolStripMenuItem
End Class
