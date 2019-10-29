<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblChar1 = New System.Windows.Forms.Label()
        Me.lblChar2 = New System.Windows.Forms.Label()
        Me.btnBattle = New System.Windows.Forms.Button()
        Me.lvwChar1 = New System.Windows.Forms.ListView()
        Me.moveName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.movePower = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.moveEnergy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwChar2 = New System.Windows.Forms.ListView()
        Me.nameMove = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.power = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.energy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dlgSave = New System.Windows.Forms.OpenFileDialog()
        Me.prbHealth1 = New System.Windows.Forms.ProgressBar()
        Me.prbEnergy1 = New System.Windows.Forms.ProgressBar()
        Me.prbHealth2 = New System.Windows.Forms.ProgressBar()
        Me.prbEnergy2 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblChar1
        '
        Me.lblChar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChar1.Location = New System.Drawing.Point(49, 29)
        Me.lblChar1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblChar1.Name = "lblChar1"
        Me.lblChar1.Size = New System.Drawing.Size(114, 21)
        Me.lblChar1.TabIndex = 0
        Me.lblChar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChar2
        '
        Me.lblChar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChar2.Location = New System.Drawing.Point(248, 29)
        Me.lblChar2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblChar2.Name = "lblChar2"
        Me.lblChar2.Size = New System.Drawing.Size(114, 21)
        Me.lblChar2.TabIndex = 1
        Me.lblChar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBattle
        '
        Me.btnBattle.Location = New System.Drawing.Point(137, 257)
        Me.btnBattle.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBattle.Name = "btnBattle"
        Me.btnBattle.Size = New System.Drawing.Size(148, 35)
        Me.btnBattle.TabIndex = 4
        Me.btnBattle.Text = "Battle"
        Me.btnBattle.UseVisualStyleBackColor = True
        '
        'lvwChar1
        '
        Me.lvwChar1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.moveName, Me.movePower, Me.moveEnergy})
        Me.lvwChar1.FullRowSelect = True
        Me.lvwChar1.HideSelection = False
        Me.lvwChar1.Location = New System.Drawing.Point(26, 64)
        Me.lvwChar1.Margin = New System.Windows.Forms.Padding(1)
        Me.lvwChar1.Name = "lvwChar1"
        Me.lvwChar1.Size = New System.Drawing.Size(174, 110)
        Me.lvwChar1.TabIndex = 5
        Me.lvwChar1.UseCompatibleStateImageBehavior = False
        Me.lvwChar1.View = System.Windows.Forms.View.Details
        '
        'moveName
        '
        Me.moveName.Text = "Name"
        Me.moveName.Width = 80
        '
        'movePower
        '
        Me.movePower.Text = "Power"
        Me.movePower.Width = 45
        '
        'moveEnergy
        '
        Me.moveEnergy.Text = "Energy"
        Me.moveEnergy.Width = 45
        '
        'lvwChar2
        '
        Me.lvwChar2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nameMove, Me.power, Me.energy})
        Me.lvwChar2.FullRowSelect = True
        Me.lvwChar2.HideSelection = False
        Me.lvwChar2.Location = New System.Drawing.Point(220, 64)
        Me.lvwChar2.Margin = New System.Windows.Forms.Padding(1)
        Me.lvwChar2.Name = "lvwChar2"
        Me.lvwChar2.Size = New System.Drawing.Size(174, 110)
        Me.lvwChar2.TabIndex = 6
        Me.lvwChar2.UseCompatibleStateImageBehavior = False
        Me.lvwChar2.View = System.Windows.Forms.View.Details
        '
        'nameMove
        '
        Me.nameMove.Text = "Name"
        Me.nameMove.Width = 80
        '
        'power
        '
        Me.power.Text = "Power"
        Me.power.Width = 45
        '
        'energy
        '
        Me.energy.Text = "Energy"
        Me.energy.Width = 45
        '
        'dlgSave
        '
        Me.dlgSave.FileName = "OpenFileDialog1"
        '
        'prbHealth1
        '
        Me.prbHealth1.ForeColor = System.Drawing.Color.LimeGreen
        Me.prbHealth1.Location = New System.Drawing.Point(85, 189)
        Me.prbHealth1.Name = "prbHealth1"
        Me.prbHealth1.Size = New System.Drawing.Size(115, 23)
        Me.prbHealth1.Step = 1
        Me.prbHealth1.TabIndex = 8
        '
        'prbEnergy1
        '
        Me.prbEnergy1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.prbEnergy1.Location = New System.Drawing.Point(85, 218)
        Me.prbEnergy1.Maximum = 10
        Me.prbEnergy1.Name = "prbEnergy1"
        Me.prbEnergy1.Size = New System.Drawing.Size(115, 23)
        Me.prbEnergy1.Step = 1
        Me.prbEnergy1.TabIndex = 9
        '
        'prbHealth2
        '
        Me.prbHealth2.ForeColor = System.Drawing.Color.LimeGreen
        Me.prbHealth2.Location = New System.Drawing.Point(279, 189)
        Me.prbHealth2.Name = "prbHealth2"
        Me.prbHealth2.Size = New System.Drawing.Size(115, 23)
        Me.prbHealth2.Step = 1
        Me.prbHealth2.TabIndex = 10
        '
        'prbEnergy2
        '
        Me.prbEnergy2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.prbEnergy2.Location = New System.Drawing.Point(279, 218)
        Me.prbEnergy2.Maximum = 10
        Me.prbEnergy2.Name = "prbEnergy2"
        Me.prbEnergy2.Size = New System.Drawing.Size(115, 23)
        Me.prbEnergy2.Step = 1
        Me.prbEnergy2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Health: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Energy:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Health: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Energy:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 311)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prbEnergy2)
        Me.Controls.Add(Me.prbHealth2)
        Me.Controls.Add(Me.prbEnergy1)
        Me.Controls.Add(Me.prbHealth1)
        Me.Controls.Add(Me.lvwChar2)
        Me.Controls.Add(Me.lvwChar1)
        Me.Controls.Add(Me.btnBattle)
        Me.Controls.Add(Me.lblChar2)
        Me.Controls.Add(Me.lblChar1)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "Form2"
        Me.Text = "Fight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChar1 As Label
    Friend WithEvents lblChar2 As Label
    Friend WithEvents btnBattle As Button
    Friend WithEvents lvwChar1 As ListView
    Friend WithEvents moveName As ColumnHeader
    Friend WithEvents movePower As ColumnHeader
    Friend WithEvents moveEnergy As ColumnHeader
    Friend WithEvents lvwChar2 As ListView
    Friend WithEvents nameMove As ColumnHeader
    Friend WithEvents power As ColumnHeader
    Friend WithEvents energy As ColumnHeader
    Friend WithEvents dlgSave As OpenFileDialog
    Friend WithEvents prbHealth1 As ProgressBar
    Friend WithEvents prbEnergy1 As ProgressBar
    Friend WithEvents prbHealth2 As ProgressBar
    Friend WithEvents prbEnergy2 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
