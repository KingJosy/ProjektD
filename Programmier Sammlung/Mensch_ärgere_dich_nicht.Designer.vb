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
        CType(Me.pb_gamepad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rot2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pb_rot1.Location = New System.Drawing.Point(763, 70)
        Me.pb_rot1.Name = "pb_rot1"
        Me.pb_rot1.Size = New System.Drawing.Size(34, 34)
        Me.pb_rot1.TabIndex = 2
        Me.pb_rot1.TabStop = False
        '
        'cmd_walk
        '
        Me.cmd_walk.Location = New System.Drawing.Point(109, 565)
        Me.cmd_walk.Name = "cmd_walk"
        Me.cmd_walk.Size = New System.Drawing.Size(75, 23)
        Me.cmd_walk.TabIndex = 3
        Me.cmd_walk.Text = "Laufen"
        Me.cmd_walk.UseVisualStyleBackColor = True
        '
        'cmd_würfel
        '
        Me.cmd_würfel.Location = New System.Drawing.Point(109, 594)
        Me.cmd_würfel.Name = "cmd_würfel"
        Me.cmd_würfel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_würfel.TabIndex = 4
        Me.cmd_würfel.Text = "Würfeln"
        Me.cmd_würfel.UseVisualStyleBackColor = True
        '
        'lbl_würfel
        '
        Me.lbl_würfel.AutoSize = True
        Me.lbl_würfel.Location = New System.Drawing.Point(128, 549)
        Me.lbl_würfel.Name = "lbl_würfel"
        Me.lbl_würfel.Size = New System.Drawing.Size(39, 13)
        Me.lbl_würfel.TabIndex = 5
        Me.lbl_würfel.Text = "Label1"
        '
        'rb_rot1
        '
        Me.rb_rot1.AutoSize = True
        Me.rb_rot1.Location = New System.Drawing.Point(234, 217)
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
        Me.rb_rot2.Location = New System.Drawing.Point(234, 240)
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
        Me.pb_rot2.Location = New System.Drawing.Point(940, 70)
        Me.pb_rot2.Name = "pb_rot2"
        Me.pb_rot2.Size = New System.Drawing.Size(34, 34)
        Me.pb_rot2.TabIndex = 8
        Me.pb_rot2.TabStop = False
        '
        'Mensch_ärgere_dich_nicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 629)
        Me.Controls.Add(Me.pb_rot2)
        Me.Controls.Add(Me.rb_rot2)
        Me.Controls.Add(Me.rb_rot1)
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
End Class
