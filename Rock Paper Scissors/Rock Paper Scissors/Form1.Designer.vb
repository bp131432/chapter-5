<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPS))
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.rockRadioButton = New System.Windows.Forms.RadioButton()
        Me.paperRadioButton = New System.Windows.Forms.RadioButton()
        Me.scissorsRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRock
        '
        Me.picRock.Image = CType(resources.GetObject("picRock.Image"), System.Drawing.Image)
        Me.picRock.Location = New System.Drawing.Point(52, 71)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(141, 127)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRock.TabIndex = 0
        Me.picRock.TabStop = False
        '
        'picPaper
        '
        Me.picPaper.Image = CType(resources.GetObject("picPaper.Image"), System.Drawing.Image)
        Me.picPaper.Location = New System.Drawing.Point(199, 71)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(144, 127)
        Me.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPaper.TabIndex = 1
        Me.picPaper.TabStop = False
        '
        'picScissors
        '
        Me.picScissors.Image = CType(resources.GetObject("picScissors.Image"), System.Drawing.Image)
        Me.picScissors.Location = New System.Drawing.Point(349, 71)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(140, 127)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScissors.TabIndex = 2
        Me.picScissors.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(349, 215)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(101, 41)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.Location = New System.Drawing.Point(137, 329)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(225, 48)
        Me.resultLabel.TabIndex = 5
        '
        'rockRadioButton
        '
        Me.rockRadioButton.AutoSize = True
        Me.rockRadioButton.Location = New System.Drawing.Point(77, 254)
        Me.rockRadioButton.Name = "rockRadioButton"
        Me.rockRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.rockRadioButton.TabIndex = 6
        Me.rockRadioButton.TabStop = True
        Me.rockRadioButton.Text = "Rock"
        Me.rockRadioButton.UseVisualStyleBackColor = True
        '
        'paperRadioButton
        '
        Me.paperRadioButton.AutoSize = True
        Me.paperRadioButton.Location = New System.Drawing.Point(77, 277)
        Me.paperRadioButton.Name = "paperRadioButton"
        Me.paperRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.paperRadioButton.TabIndex = 7
        Me.paperRadioButton.TabStop = True
        Me.paperRadioButton.Text = "Paper"
        Me.paperRadioButton.UseVisualStyleBackColor = True
        '
        'scissorsRadioButton
        '
        Me.scissorsRadioButton.AutoSize = True
        Me.scissorsRadioButton.Location = New System.Drawing.Point(77, 300)
        Me.scissorsRadioButton.Name = "scissorsRadioButton"
        Me.scissorsRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.scissorsRadioButton.TabIndex = 8
        Me.scissorsRadioButton.TabStop = True
        Me.scissorsRadioButton.Text = "Scissors"
        Me.scissorsRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Pick one:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "My score: "
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore.Location = New System.Drawing.Point(105, 408)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(100, 30)
        Me.lblScore.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Computer score:"
        '
        'lblComputer
        '
        Me.lblComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputer.Location = New System.Drawing.Point(371, 409)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(100, 30)
        Me.lblComputer.TabIndex = 13
        '
        'RPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 490)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scissorsRadioButton)
        Me.Controls.Add(Me.paperRadioButton)
        Me.Controls.Add(Me.rockRadioButton)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picRock)
        Me.Name = "RPS"
        Me.Text = "RPS"
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRock As System.Windows.Forms.PictureBox
    Friend WithEvents picPaper As System.Windows.Forms.PictureBox
    Friend WithEvents picScissors As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents rockRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents paperRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents scissorsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblComputer As System.Windows.Forms.Label

End Class
