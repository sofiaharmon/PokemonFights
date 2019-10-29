<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbChar1 = New System.Windows.Forms.ComboBox()
        Me.cmbChar2 = New System.Windows.Forms.ComboBox()
        Me.lblChar1 = New System.Windows.Forms.Label()
        Me.lblChar2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dlgLoad = New System.Windows.Forms.OpenFileDialog()
        Me.pbxChar1 = New System.Windows.Forms.PictureBox()
        Me.pbxChar2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxChar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxChar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChar, Me.mnuFight, Me.mnuSave})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(279, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuChar
        '
        Me.mnuChar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoad, Me.mnuClear})
        Me.mnuChar.Name = "mnuChar"
        Me.mnuChar.Size = New System.Drawing.Size(70, 22)
        Me.mnuChar.Text = "Pokemon"
        '
        'mnuLoad
        '
        Me.mnuLoad.Name = "mnuLoad"
        Me.mnuLoad.Size = New System.Drawing.Size(180, 22)
        Me.mnuLoad.Text = "Load"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuFight
        '
        Me.mnuFight.Name = "mnuFight"
        Me.mnuFight.Size = New System.Drawing.Size(46, 22)
        Me.mnuFight.Text = "Fight"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(83, 22)
        Me.mnuSave.Text = "Save Results"
        '
        'cmbChar1
        '
        Me.cmbChar1.FormattingEnabled = True
        Me.cmbChar1.Location = New System.Drawing.Point(32, 55)
        Me.cmbChar1.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbChar1.Name = "cmbChar1"
        Me.cmbChar1.Size = New System.Drawing.Size(90, 21)
        Me.cmbChar1.TabIndex = 1
        '
        'cmbChar2
        '
        Me.cmbChar2.FormattingEnabled = True
        Me.cmbChar2.Location = New System.Drawing.Point(154, 55)
        Me.cmbChar2.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbChar2.Name = "cmbChar2"
        Me.cmbChar2.Size = New System.Drawing.Size(90, 21)
        Me.cmbChar2.TabIndex = 2
        '
        'lblChar1
        '
        Me.lblChar1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblChar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChar1.Location = New System.Drawing.Point(32, 171)
        Me.lblChar1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblChar1.Name = "lblChar1"
        Me.lblChar1.Size = New System.Drawing.Size(90, 74)
        Me.lblChar1.TabIndex = 3
        Me.lblChar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChar2
        '
        Me.lblChar2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblChar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChar2.Location = New System.Drawing.Point(154, 171)
        Me.lblChar2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblChar2.Name = "lblChar2"
        Me.lblChar2.Size = New System.Drawing.Size(90, 74)
        Me.lblChar2.TabIndex = 4
        Me.lblChar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Character 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Character 2:"
        '
        'pbxChar1
        '
        Me.pbxChar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxChar1.Location = New System.Drawing.Point(32, 87)
        Me.pbxChar1.Name = "pbxChar1"
        Me.pbxChar1.Size = New System.Drawing.Size(90, 69)
        Me.pbxChar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxChar1.TabIndex = 7
        Me.pbxChar1.TabStop = False
        '
        'pbxChar2
        '
        Me.pbxChar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxChar2.Location = New System.Drawing.Point(154, 87)
        Me.pbxChar2.Name = "pbxChar2"
        Me.pbxChar2.Size = New System.Drawing.Size(90, 69)
        Me.pbxChar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxChar2.TabIndex = 8
        Me.pbxChar2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 263)
        Me.Controls.Add(Me.pbxChar2)
        Me.Controls.Add(Me.pbxChar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblChar2)
        Me.Controls.Add(Me.lblChar1)
        Me.Controls.Add(Me.cmbChar2)
        Me.Controls.Add(Me.cmbChar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "Form1"
        Me.Text = "Pokemon Fights"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxChar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxChar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuChar As ToolStripMenuItem
    Friend WithEvents mnuFight As ToolStripMenuItem
    Friend WithEvents cmbChar1 As ComboBox
    Friend WithEvents cmbChar2 As ComboBox
    Friend WithEvents lblChar1 As Label
    Friend WithEvents lblChar2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dlgLoad As OpenFileDialog
    Friend WithEvents mnuLoad As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents pbxChar1 As PictureBox
    Friend WithEvents pbxChar2 As PictureBox
End Class
