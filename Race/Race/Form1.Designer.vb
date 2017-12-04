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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picChick = New System.Windows.Forms.PictureBox()
        Me.picPuppy = New System.Windows.Forms.PictureBox()
        Me.picGoat = New System.Windows.Forms.PictureBox()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblChick = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPuppy = New System.Windows.Forms.Label()
        Me.lblGoat = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lable2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picChick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuppy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChick
        '
        Me.picChick.Image = CType(resources.GetObject("picChick.Image"), System.Drawing.Image)
        Me.picChick.Location = New System.Drawing.Point(43, 12)
        Me.picChick.Name = "picChick"
        Me.picChick.Size = New System.Drawing.Size(160, 143)
        Me.picChick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChick.TabIndex = 0
        Me.picChick.TabStop = False
        '
        'picPuppy
        '
        Me.picPuppy.Image = CType(resources.GetObject("picPuppy.Image"), System.Drawing.Image)
        Me.picPuppy.Location = New System.Drawing.Point(43, 161)
        Me.picPuppy.Name = "picPuppy"
        Me.picPuppy.Size = New System.Drawing.Size(160, 142)
        Me.picPuppy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPuppy.TabIndex = 1
        Me.picPuppy.TabStop = False
        '
        'picGoat
        '
        Me.picGoat.Image = CType(resources.GetObject("picGoat.Image"), System.Drawing.Image)
        Me.picGoat.Location = New System.Drawing.Point(43, 309)
        Me.picGoat.Name = "picGoat"
        Me.picGoat.Size = New System.Drawing.Size(164, 136)
        Me.picGoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGoat.TabIndex = 2
        Me.picGoat.TabStop = False
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(84, 481)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 3
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(520, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblChick
        '
        Me.lblChick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChick.Location = New System.Drawing.Point(71, 568)
        Me.lblChick.Name = "lblChick"
        Me.lblChick.Size = New System.Drawing.Size(100, 30)
        Me.lblChick.TabIndex = 5
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(316, 481)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPuppy
        '
        Me.lblPuppy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPuppy.Location = New System.Drawing.Point(316, 568)
        Me.lblPuppy.Name = "lblPuppy"
        Me.lblPuppy.Size = New System.Drawing.Size(100, 30)
        Me.lblPuppy.TabIndex = 7
        '
        'lblGoat
        '
        Me.lblGoat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGoat.Location = New System.Drawing.Point(540, 568)
        Me.lblGoat.Name = "lblGoat"
        Me.lblGoat.Size = New System.Drawing.Size(100, 30)
        Me.lblGoat.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 529)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Goat Score:"
        '
        'Lable2
        '
        Me.Lable2.AutoSize = True
        Me.Lable2.Location = New System.Drawing.Point(320, 529)
        Me.Lable2.Name = "Lable2"
        Me.Lable2.Size = New System.Drawing.Size(71, 13)
        Me.Lable2.TabIndex = 10
        Me.Lable2.Text = "Puppy Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 529)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Chick Score:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(772, 630)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lable2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGoat)
        Me.Controls.Add(Me.lblPuppy)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblChick)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.picGoat)
        Me.Controls.Add(Me.picPuppy)
        Me.Controls.Add(Me.picChick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picChick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuppy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picChick As System.Windows.Forms.PictureBox
    Friend WithEvents picPuppy As System.Windows.Forms.PictureBox
    Friend WithEvents picGoat As System.Windows.Forms.PictureBox
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblChick As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblPuppy As System.Windows.Forms.Label
    Friend WithEvents lblGoat As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lable2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
