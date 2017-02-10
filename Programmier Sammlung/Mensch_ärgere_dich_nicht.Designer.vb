<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensch_ärgere_dich_nicht
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mensch_ärgere_dich_nicht))
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.pb_gamepad = New System.Windows.Forms.PictureBox()
        Me.pb_rot1 = New System.Windows.Forms.PictureBox()
        Me.cmd_walk = New System.Windows.Forms.Button()
        Me.cmd_würfel = New System.Windows.Forms.Button()
        Me.lbl_würfel = New System.Windows.Forms.Label()
        Me.rb_rot1 = New System.Windows.Forms.RadioButton()
        Me.rb_rot2 = New System.Windows.Forms.RadioButton()
        Me.pb_rot2 = New System.Windows.Forms.PictureBox()
        Me.pb_rot3 = New System.Windows.Forms.PictureBox()
        Me.pb_rot4 = New System.Windows.Forms.PictureBox()
        Me.rb_rot3 = New System.Windows.Forms.RadioButton()
        Me.rb_rot4 = New System.Windows.Forms.RadioButton()
        Me.pb_blau1 = New System.Windows.Forms.PictureBox()
        Me.pb_blau2 = New System.Windows.Forms.PictureBox()
        Me.pb_blau3 = New System.Windows.Forms.PictureBox()
        Me.pb_blau4 = New System.Windows.Forms.PictureBox()
        Me.rb_blau1 = New System.Windows.Forms.RadioButton()
        Me.rb_blau2 = New System.Windows.Forms.RadioButton()
        Me.rb_blau3 = New System.Windows.Forms.RadioButton()
        Me.rb_blau4 = New System.Windows.Forms.RadioButton()
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.pb_gelb1 = New System.Windows.Forms.PictureBox()
        Me.pb_gelb2 = New System.Windows.Forms.PictureBox()
        Me.pb_gelb3 = New System.Windows.Forms.PictureBox()
        Me.pb_gelb4 = New System.Windows.Forms.PictureBox()
        Me.rb_gelb1 = New System.Windows.Forms.RadioButton()
        Me.rb_gelb2 = New System.Windows.Forms.RadioButton()
        Me.rb_gelb3 = New System.Windows.Forms.RadioButton()
        Me.rb_gelb4 = New System.Windows.Forms.RadioButton()
        Me.rb_grün4 = New System.Windows.Forms.RadioButton()
        Me.rb_grün3 = New System.Windows.Forms.RadioButton()
        Me.rb_grün2 = New System.Windows.Forms.RadioButton()
        Me.rb_grün1 = New System.Windows.Forms.RadioButton()
        Me.pb_grün1 = New System.Windows.Forms.PictureBox()
        Me.pb_grün2 = New System.Windows.Forms.PictureBox()
        Me.pb_grün3 = New System.Windows.Forms.PictureBox()
        Me.pb_grün4 = New System.Windows.Forms.PictureBox()
        Me.gb_spielfiguren = New System.Windows.Forms.GroupBox()
        Me.rb_2player = New System.Windows.Forms.RadioButton()
        Me.rb_3player = New System.Windows.Forms.RadioButton()
        Me.rb_4player = New System.Windows.Forms.RadioButton()
        Me.cmd_restart = New System.Windows.Forms.Button()
        CType(Me.pb_gamepad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_blau1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_blau2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_blau3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_blau4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_gelb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_gelb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_gelb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_gelb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_grün1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_grün2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_grün3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_grün4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_spielfiguren.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_back
        '
        Me.cmd_back.Location = New System.Drawing.Point(12, 581)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(75, 23)
        Me.cmd_back.TabIndex = 0
        Me.cmd_back.Text = "Zurück"
        Me.cmd_back.UseVisualStyleBackColor = True
        '
        'pb_gamepad
        '
        Me.pb_gamepad.Image = CType(resources.GetObject("pb_gamepad.Image"), System.Drawing.Image)
        Me.pb_gamepad.Location = New System.Drawing.Point(435, 12)
        Me.pb_gamepad.Name = "pb_gamepad"
        Me.pb_gamepad.Size = New System.Drawing.Size(603, 592)
        Me.pb_gamepad.TabIndex = 1
        Me.pb_gamepad.TabStop = False
        '
        'pb_rot1
        '
        Me.pb_rot1.Image = CType(resources.GetObject("pb_rot1.Image"), System.Drawing.Image)
        Me.pb_rot1.Location = New System.Drawing.Point(939, 26)
        Me.pb_rot1.Name = "pb_rot1"
        Me.pb_rot1.Size = New System.Drawing.Size(34, 34)
        Me.pb_rot1.TabIndex = 2
        Me.pb_rot1.TabStop = False
        '
        'cmd_walk
        '
        Me.cmd_walk.Location = New System.Drawing.Point(244, 325)
        Me.cmd_walk.Name = "cmd_walk"
        Me.cmd_walk.Size = New System.Drawing.Size(75, 23)
        Me.cmd_walk.TabIndex = 3
        Me.cmd_walk.Text = "Laufen"
        Me.cmd_walk.UseVisualStyleBackColor = True
        '
        'cmd_würfel
        '
        Me.cmd_würfel.Location = New System.Drawing.Point(30, 138)
        Me.cmd_würfel.Name = "cmd_würfel"
        Me.cmd_würfel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_würfel.TabIndex = 4
        Me.cmd_würfel.Text = "Würfeln"
        Me.cmd_würfel.UseVisualStyleBackColor = True
        '
        'lbl_würfel
        '
        Me.lbl_würfel.AutoSize = True
        Me.lbl_würfel.Location = New System.Drawing.Point(36, 122)
        Me.lbl_würfel.Name = "lbl_würfel"
        Me.lbl_würfel.Size = New System.Drawing.Size(69, 13)
        Me.lbl_würfel.TabIndex = 5
        Me.lbl_würfel.Text = "Würfelanzahl"
        '
        'rb_rot1
        '
        Me.rb_rot1.AutoSize = True
        Me.rb_rot1.Location = New System.Drawing.Point(43, 24)
        Me.rb_rot1.Name = "rb_rot1"
        Me.rb_rot1.Size = New System.Drawing.Size(51, 17)
        Me.rb_rot1.TabIndex = 6
        Me.rb_rot1.TabStop = True
        Me.rb_rot1.Text = "Rot 1"
        Me.rb_rot1.UseVisualStyleBackColor = True
        '
        'rb_rot2
        '
        Me.rb_rot2.AutoSize = True
        Me.rb_rot2.Location = New System.Drawing.Point(43, 47)
        Me.rb_rot2.Name = "rb_rot2"
        Me.rb_rot2.Size = New System.Drawing.Size(51, 17)
        Me.rb_rot2.TabIndex = 7
        Me.rb_rot2.TabStop = True
        Me.rb_rot2.Text = "Rot 2"
        Me.rb_rot2.UseVisualStyleBackColor = True
        '
        'pb_rot2
        '
        Me.pb_rot2.Image = CType(resources.GetObject("pb_rot2.Image"), System.Drawing.Image)
        Me.pb_rot2.Location = New System.Drawing.Point(979, 26)
        Me.pb_rot2.Name = "pb_rot2"
        Me.pb_rot2.Size = New System.Drawing.Size(34, 34)
        Me.pb_rot2.TabIndex = 8
        Me.pb_rot2.TabStop = False
        '
        'pb_rot3
        '
        Me.pb_rot3.Image = CType(resources.GetObject("pb_rot3.Image"), System.Drawing.Image)
        Me.pb_rot3.Location = New System.Drawing.Point(939, 75)
        Me.pb_rot3.Name = "pb_rot3"
        Me.pb_rot3.Size = New System.Drawing.Size(34, 34)
        Me.pb_rot3.TabIndex = 9
        Me.pb_rot3.TabStop = False
        '
        'pb_rot4
        '
        Me.pb_rot4.Image = CType(resources.GetObject("pb_rot4.Image"), System.Drawing.Image)
        Me.pb_rot4.Location = New System.Drawing.Point(979, 75)
        Me.pb_rot4.Name = "pb_rot4"
        Me.pb_rot4.Size = New System.Drawing.Size(34, 34)
        Me.pb_rot4.TabIndex = 10
        Me.pb_rot4.TabStop = False
        '
        'rb_rot3
        '
        Me.rb_rot3.AutoSize = True
        Me.rb_rot3.Location = New System.Drawing.Point(43, 70)
        Me.rb_rot3.Name = "rb_rot3"
        Me.rb_rot3.Size = New System.Drawing.Size(51, 17)
        Me.rb_rot3.TabIndex = 11
        Me.rb_rot3.TabStop = True
        Me.rb_rot3.Text = "Rot 3"
        Me.rb_rot3.UseVisualStyleBackColor = True
        '
        'rb_rot4
        '
        Me.rb_rot4.AutoSize = True
        Me.rb_rot4.Location = New System.Drawing.Point(43, 93)
        Me.rb_rot4.Name = "rb_rot4"
        Me.rb_rot4.Size = New System.Drawing.Size(51, 17)
        Me.rb_rot4.TabIndex = 12
        Me.rb_rot4.TabStop = True
        Me.rb_rot4.Text = "Rot 4"
        Me.rb_rot4.UseVisualStyleBackColor = True
        '
        'pb_blau1
        '
        Me.pb_blau1.Image = CType(resources.GetObject("pb_blau1.Image"), System.Drawing.Image)
        Me.pb_blau1.Location = New System.Drawing.Point(939, 510)
        Me.pb_blau1.Name = "pb_blau1"
        Me.pb_blau1.Size = New System.Drawing.Size(34, 34)
        Me.pb_blau1.TabIndex = 13
        Me.pb_blau1.TabStop = False
        '
        'pb_blau2
        '
        Me.pb_blau2.Image = CType(resources.GetObject("pb_blau2.Image"), System.Drawing.Image)
        Me.pb_blau2.Location = New System.Drawing.Point(979, 510)
        Me.pb_blau2.Name = "pb_blau2"
        Me.pb_blau2.Size = New System.Drawing.Size(34, 34)
        Me.pb_blau2.TabIndex = 14
        Me.pb_blau2.TabStop = False
        '
        'pb_blau3
        '
        Me.pb_blau3.Image = CType(resources.GetObject("pb_blau3.Image"), System.Drawing.Image)
        Me.pb_blau3.Location = New System.Drawing.Point(939, 554)
        Me.pb_blau3.Name = "pb_blau3"
        Me.pb_blau3.Size = New System.Drawing.Size(34, 34)
        Me.pb_blau3.TabIndex = 15
        Me.pb_blau3.TabStop = False
        '
        'pb_blau4
        '
        Me.pb_blau4.Image = CType(resources.GetObject("pb_blau4.Image"), System.Drawing.Image)
        Me.pb_blau4.Location = New System.Drawing.Point(979, 554)
        Me.pb_blau4.Name = "pb_blau4"
        Me.pb_blau4.Size = New System.Drawing.Size(34, 34)
        Me.pb_blau4.TabIndex = 16
        Me.pb_blau4.TabStop = False
        '
        'rb_blau1
        '
        Me.rb_blau1.AutoSize = True
        Me.rb_blau1.Location = New System.Drawing.Point(43, 150)
        Me.rb_blau1.Name = "rb_blau1"
        Me.rb_blau1.Size = New System.Drawing.Size(52, 17)
        Me.rb_blau1.TabIndex = 17
        Me.rb_blau1.TabStop = True
        Me.rb_blau1.Text = "Blau1"
        Me.rb_blau1.UseVisualStyleBackColor = True
        '
        'rb_blau2
        '
        Me.rb_blau2.AutoSize = True
        Me.rb_blau2.Location = New System.Drawing.Point(43, 173)
        Me.rb_blau2.Name = "rb_blau2"
        Me.rb_blau2.Size = New System.Drawing.Size(55, 17)
        Me.rb_blau2.TabIndex = 18
        Me.rb_blau2.TabStop = True
        Me.rb_blau2.Text = "Blau 2"
        Me.rb_blau2.UseVisualStyleBackColor = True
        '
        'rb_blau3
        '
        Me.rb_blau3.AutoSize = True
        Me.rb_blau3.Location = New System.Drawing.Point(43, 196)
        Me.rb_blau3.Name = "rb_blau3"
        Me.rb_blau3.Size = New System.Drawing.Size(55, 17)
        Me.rb_blau3.TabIndex = 19
        Me.rb_blau3.TabStop = True
        Me.rb_blau3.Text = "Blau 3"
        Me.rb_blau3.UseVisualStyleBackColor = True
        '
        'rb_blau4
        '
        Me.rb_blau4.AutoSize = True
        Me.rb_blau4.Location = New System.Drawing.Point(43, 219)
        Me.rb_blau4.Name = "rb_blau4"
        Me.rb_blau4.Size = New System.Drawing.Size(55, 17)
        Me.rb_blau4.TabIndex = 20
        Me.rb_blau4.TabStop = True
        Me.rb_blau4.Text = "Blau 4"
        Me.rb_blau4.UseVisualStyleBackColor = True
        '
        'cmd_start
        '
        Me.cmd_start.Location = New System.Drawing.Point(12, 480)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(75, 23)
        Me.cmd_start.TabIndex = 21
        Me.cmd_start.Text = "Start"
        Me.cmd_start.UseVisualStyleBackColor = True
        '
        'pb_gelb1
        '
        Me.pb_gelb1.Image = CType(resources.GetObject("pb_gelb1.Image"), System.Drawing.Image)
        Me.pb_gelb1.Location = New System.Drawing.Point(454, 510)
        Me.pb_gelb1.Name = "pb_gelb1"
        Me.pb_gelb1.Size = New System.Drawing.Size(34, 34)
        Me.pb_gelb1.TabIndex = 22
        Me.pb_gelb1.TabStop = False
        '
        'pb_gelb2
        '
        Me.pb_gelb2.Image = CType(resources.GetObject("pb_gelb2.Image"), System.Drawing.Image)
        Me.pb_gelb2.Location = New System.Drawing.Point(494, 510)
        Me.pb_gelb2.Name = "pb_gelb2"
        Me.pb_gelb2.Size = New System.Drawing.Size(34, 34)
        Me.pb_gelb2.TabIndex = 23
        Me.pb_gelb2.TabStop = False
        '
        'pb_gelb3
        '
        Me.pb_gelb3.Image = CType(resources.GetObject("pb_gelb3.Image"), System.Drawing.Image)
        Me.pb_gelb3.Location = New System.Drawing.Point(454, 554)
        Me.pb_gelb3.Name = "pb_gelb3"
        Me.pb_gelb3.Size = New System.Drawing.Size(34, 34)
        Me.pb_gelb3.TabIndex = 24
        Me.pb_gelb3.TabStop = False
        '
        'pb_gelb4
        '
        Me.pb_gelb4.Image = CType(resources.GetObject("pb_gelb4.Image"), System.Drawing.Image)
        Me.pb_gelb4.Location = New System.Drawing.Point(494, 554)
        Me.pb_gelb4.Name = "pb_gelb4"
        Me.pb_gelb4.Size = New System.Drawing.Size(34, 34)
        Me.pb_gelb4.TabIndex = 25
        Me.pb_gelb4.TabStop = False
        '
        'rb_gelb1
        '
        Me.rb_gelb1.AutoSize = True
        Me.rb_gelb1.Location = New System.Drawing.Point(169, 24)
        Me.rb_gelb1.Name = "rb_gelb1"
        Me.rb_gelb1.Size = New System.Drawing.Size(56, 17)
        Me.rb_gelb1.TabIndex = 26
        Me.rb_gelb1.TabStop = True
        Me.rb_gelb1.Text = "Gelb 1"
        Me.rb_gelb1.UseVisualStyleBackColor = True
        '
        'rb_gelb2
        '
        Me.rb_gelb2.AutoSize = True
        Me.rb_gelb2.Location = New System.Drawing.Point(169, 47)
        Me.rb_gelb2.Name = "rb_gelb2"
        Me.rb_gelb2.Size = New System.Drawing.Size(56, 17)
        Me.rb_gelb2.TabIndex = 27
        Me.rb_gelb2.TabStop = True
        Me.rb_gelb2.Text = "Gelb 2"
        Me.rb_gelb2.UseVisualStyleBackColor = True
        '
        'rb_gelb3
        '
        Me.rb_gelb3.AutoSize = True
        Me.rb_gelb3.Location = New System.Drawing.Point(169, 70)
        Me.rb_gelb3.Name = "rb_gelb3"
        Me.rb_gelb3.Size = New System.Drawing.Size(56, 17)
        Me.rb_gelb3.TabIndex = 28
        Me.rb_gelb3.TabStop = True
        Me.rb_gelb3.Text = "Gelb 3"
        Me.rb_gelb3.UseVisualStyleBackColor = True
        '
        'rb_gelb4
        '
        Me.rb_gelb4.AutoSize = True
        Me.rb_gelb4.Location = New System.Drawing.Point(169, 93)
        Me.rb_gelb4.Name = "rb_gelb4"
        Me.rb_gelb4.Size = New System.Drawing.Size(56, 17)
        Me.rb_gelb4.TabIndex = 29
        Me.rb_gelb4.TabStop = True
        Me.rb_gelb4.Text = "Gelb 4"
        Me.rb_gelb4.UseVisualStyleBackColor = True
        '
        'rb_grün4
        '
        Me.rb_grün4.AutoSize = True
        Me.rb_grün4.Location = New System.Drawing.Point(169, 219)
        Me.rb_grün4.Name = "rb_grün4"
        Me.rb_grün4.Size = New System.Drawing.Size(57, 17)
        Me.rb_grün4.TabIndex = 33
        Me.rb_grün4.TabStop = True
        Me.rb_grün4.Text = "Grün 4"
        Me.rb_grün4.UseVisualStyleBackColor = True
        '
        'rb_grün3
        '
        Me.rb_grün3.AutoSize = True
        Me.rb_grün3.Location = New System.Drawing.Point(169, 196)
        Me.rb_grün3.Name = "rb_grün3"
        Me.rb_grün3.Size = New System.Drawing.Size(57, 17)
        Me.rb_grün3.TabIndex = 32
        Me.rb_grün3.TabStop = True
        Me.rb_grün3.Text = "Grün 3"
        Me.rb_grün3.UseVisualStyleBackColor = True
        '
        'rb_grün2
        '
        Me.rb_grün2.AutoSize = True
        Me.rb_grün2.Location = New System.Drawing.Point(169, 173)
        Me.rb_grün2.Name = "rb_grün2"
        Me.rb_grün2.Size = New System.Drawing.Size(57, 17)
        Me.rb_grün2.TabIndex = 31
        Me.rb_grün2.TabStop = True
        Me.rb_grün2.Text = "Grün 2"
        Me.rb_grün2.UseVisualStyleBackColor = True
        '
        'rb_grün1
        '
        Me.rb_grün1.AutoSize = True
        Me.rb_grün1.Location = New System.Drawing.Point(169, 150)
        Me.rb_grün1.Name = "rb_grün1"
        Me.rb_grün1.Size = New System.Drawing.Size(57, 17)
        Me.rb_grün1.TabIndex = 30
        Me.rb_grün1.TabStop = True
        Me.rb_grün1.Text = "Grün 1"
        Me.rb_grün1.UseVisualStyleBackColor = True
        '
        'pb_grün1
        '
        Me.pb_grün1.Image = CType(resources.GetObject("pb_grün1.Image"), System.Drawing.Image)
        Me.pb_grün1.Location = New System.Drawing.Point(454, 26)
        Me.pb_grün1.Name = "pb_grün1"
        Me.pb_grün1.Size = New System.Drawing.Size(34, 34)
        Me.pb_grün1.TabIndex = 34
        Me.pb_grün1.TabStop = False
        '
        'pb_grün2
        '
        Me.pb_grün2.Image = CType(resources.GetObject("pb_grün2.Image"), System.Drawing.Image)
        Me.pb_grün2.Location = New System.Drawing.Point(494, 26)
        Me.pb_grün2.Name = "pb_grün2"
        Me.pb_grün2.Size = New System.Drawing.Size(34, 34)
        Me.pb_grün2.TabIndex = 35
        Me.pb_grün2.TabStop = False
        '
        'pb_grün3
        '
        Me.pb_grün3.Image = CType(resources.GetObject("pb_grün3.Image"), System.Drawing.Image)
        Me.pb_grün3.Location = New System.Drawing.Point(454, 75)
        Me.pb_grün3.Name = "pb_grün3"
        Me.pb_grün3.Size = New System.Drawing.Size(34, 34)
        Me.pb_grün3.TabIndex = 36
        Me.pb_grün3.TabStop = False
        '
        'pb_grün4
        '
        Me.pb_grün4.Image = CType(resources.GetObject("pb_grün4.Image"), System.Drawing.Image)
        Me.pb_grün4.Location = New System.Drawing.Point(494, 75)
        Me.pb_grün4.Name = "pb_grün4"
        Me.pb_grün4.Size = New System.Drawing.Size(34, 34)
        Me.pb_grün4.TabIndex = 37
        Me.pb_grün4.TabStop = False
        '
        'gb_spielfiguren
        '
        Me.gb_spielfiguren.Controls.Add(Me.rb_grün4)
        Me.gb_spielfiguren.Controls.Add(Me.rb_grün3)
        Me.gb_spielfiguren.Controls.Add(Me.rb_grün2)
        Me.gb_spielfiguren.Controls.Add(Me.rb_grün1)
        Me.gb_spielfiguren.Controls.Add(Me.rb_gelb4)
        Me.gb_spielfiguren.Controls.Add(Me.rb_gelb3)
        Me.gb_spielfiguren.Controls.Add(Me.rb_gelb2)
        Me.gb_spielfiguren.Controls.Add(Me.rb_gelb1)
        Me.gb_spielfiguren.Controls.Add(Me.rb_blau4)
        Me.gb_spielfiguren.Controls.Add(Me.rb_blau3)
        Me.gb_spielfiguren.Controls.Add(Me.rb_blau2)
        Me.gb_spielfiguren.Controls.Add(Me.rb_blau1)
        Me.gb_spielfiguren.Controls.Add(Me.rb_rot4)
        Me.gb_spielfiguren.Controls.Add(Me.rb_rot3)
        Me.gb_spielfiguren.Controls.Add(Me.rb_rot2)
        Me.gb_spielfiguren.Controls.Add(Me.rb_rot1)
        Me.gb_spielfiguren.Location = New System.Drawing.Point(151, 51)
        Me.gb_spielfiguren.Name = "gb_spielfiguren"
        Me.gb_spielfiguren.Size = New System.Drawing.Size(262, 268)
        Me.gb_spielfiguren.TabIndex = 38
        Me.gb_spielfiguren.TabStop = False
        Me.gb_spielfiguren.Text = "Spielfiguren"
        '
        'rb_2player
        '
        Me.rb_2player.AutoSize = True
        Me.rb_2player.Location = New System.Drawing.Point(120, 480)
        Me.rb_2player.Name = "rb_2player"
        Me.rb_2player.Size = New System.Drawing.Size(66, 17)
        Me.rb_2player.TabIndex = 39
        Me.rb_2player.TabStop = True
        Me.rb_2player.Text = "2 Spieler"
        Me.rb_2player.UseVisualStyleBackColor = True
        '
        'rb_3player
        '
        Me.rb_3player.AutoSize = True
        Me.rb_3player.Location = New System.Drawing.Point(216, 480)
        Me.rb_3player.Name = "rb_3player"
        Me.rb_3player.Size = New System.Drawing.Size(66, 17)
        Me.rb_3player.TabIndex = 40
        Me.rb_3player.TabStop = True
        Me.rb_3player.Text = "3 Spieler"
        Me.rb_3player.UseVisualStyleBackColor = True
        '
        'rb_4player
        '
        Me.rb_4player.AutoSize = True
        Me.rb_4player.Location = New System.Drawing.Point(312, 480)
        Me.rb_4player.Name = "rb_4player"
        Me.rb_4player.Size = New System.Drawing.Size(66, 17)
        Me.rb_4player.TabIndex = 41
        Me.rb_4player.TabStop = True
        Me.rb_4player.Text = "4 Spieler"
        Me.rb_4player.UseVisualStyleBackColor = True
        '
        'cmd_restart
        '
        Me.cmd_restart.Location = New System.Drawing.Point(12, 509)
        Me.cmd_restart.Name = "cmd_restart"
        Me.cmd_restart.Size = New System.Drawing.Size(75, 23)
        Me.cmd_restart.TabIndex = 42
        Me.cmd_restart.Text = "Neustart"
        Me.cmd_restart.UseVisualStyleBackColor = True
        '
        'Mensch_ärgere_dich_nicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 629)
        Me.Controls.Add(Me.cmd_restart)
        Me.Controls.Add(Me.rb_4player)
        Me.Controls.Add(Me.rb_3player)
        Me.Controls.Add(Me.rb_2player)
        Me.Controls.Add(Me.gb_spielfiguren)
        Me.Controls.Add(Me.pb_grün4)
        Me.Controls.Add(Me.pb_grün3)
        Me.Controls.Add(Me.pb_grün2)
        Me.Controls.Add(Me.pb_grün1)
        Me.Controls.Add(Me.pb_gelb4)
        Me.Controls.Add(Me.pb_gelb3)
        Me.Controls.Add(Me.pb_gelb2)
        Me.Controls.Add(Me.pb_gelb1)
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.pb_blau4)
        Me.Controls.Add(Me.pb_blau3)
        Me.Controls.Add(Me.pb_blau2)
        Me.Controls.Add(Me.pb_blau1)
        Me.Controls.Add(Me.pb_rot4)
        Me.Controls.Add(Me.pb_rot3)
        Me.Controls.Add(Me.pb_rot2)
        Me.Controls.Add(Me.lbl_würfel)
        Me.Controls.Add(Me.cmd_würfel)
        Me.Controls.Add(Me.cmd_walk)
        Me.Controls.Add(Me.pb_rot1)
        Me.Controls.Add(Me.pb_gamepad)
        Me.Controls.Add(Me.cmd_back)
        Me.Name = "Mensch_ärgere_dich_nicht"
        Me.Text = "Mensch_ärgere_dich_nicht"
        CType(Me.pb_gamepad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_rot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_rot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_rot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_rot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_blau1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_blau2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_blau3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_blau4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_gelb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_gelb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_gelb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_gelb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_grün1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_grün2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_grün3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_grün4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_spielfiguren.ResumeLayout(False)
        Me.gb_spielfiguren.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_back As System.Windows.Forms.Button
    Friend WithEvents pb_gamepad As System.Windows.Forms.PictureBox
    Friend WithEvents pb_rot1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_walk As System.Windows.Forms.Button
    Friend WithEvents cmd_würfel As System.Windows.Forms.Button
    Friend WithEvents lbl_würfel As System.Windows.Forms.Label
    Friend WithEvents rb_rot1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_rot2 As System.Windows.Forms.RadioButton
    Friend WithEvents pb_rot2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb_rot3 As PictureBox
    Friend WithEvents pb_rot4 As PictureBox
    Friend WithEvents rb_rot3 As RadioButton
    Friend WithEvents rb_rot4 As RadioButton
    Friend WithEvents pb_blau1 As PictureBox
    Friend WithEvents pb_blau2 As PictureBox
    Friend WithEvents pb_blau3 As PictureBox
    Friend WithEvents pb_blau4 As PictureBox
    Friend WithEvents rb_blau1 As RadioButton
    Friend WithEvents rb_blau2 As RadioButton
    Friend WithEvents rb_blau3 As RadioButton
    Friend WithEvents rb_blau4 As RadioButton
    Friend WithEvents cmd_start As Button
    Friend WithEvents pb_gelb1 As PictureBox
    Friend WithEvents pb_gelb2 As PictureBox
    Friend WithEvents pb_gelb3 As PictureBox
    Friend WithEvents pb_gelb4 As PictureBox
    Friend WithEvents rb_gelb1 As RadioButton
    Friend WithEvents rb_gelb2 As RadioButton
    Friend WithEvents rb_gelb3 As RadioButton
    Friend WithEvents rb_gelb4 As RadioButton
    Friend WithEvents rb_grün4 As RadioButton
    Friend WithEvents rb_grün3 As RadioButton
    Friend WithEvents rb_grün2 As RadioButton
    Friend WithEvents rb_grün1 As RadioButton
    Friend WithEvents pb_grün1 As PictureBox
    Friend WithEvents pb_grün2 As PictureBox
    Friend WithEvents pb_grün3 As PictureBox
    Friend WithEvents pb_grün4 As PictureBox
    Friend WithEvents gb_spielfiguren As GroupBox
    Friend WithEvents rb_2player As RadioButton
    Friend WithEvents rb_3player As RadioButton
    Friend WithEvents rb_4player As RadioButton
    Friend WithEvents cmd_restart As Button
End Class
