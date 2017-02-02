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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_walk = New System.Windows.Forms.Button()
        Me.cmd_würfel = New System.Windows.Forms.Button()
        CType(Me.pb_gamepad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(763, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        'Mensch_ärgere_dich_nicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 629)
        Me.Controls.Add(Me.cmd_würfel)
        Me.Controls.Add(Me.cmd_walk)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pb_gamepad)
        Me.Controls.Add(Me.cmd_back)
        Me.Name = "Mensch_ärgere_dich_nicht"
        Me.Text = "Mensch_ärgere_dich_nicht"
        CType(Me.pb_gamepad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_back As System.Windows.Forms.Button
    Friend WithEvents pb_gamepad As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_walk As System.Windows.Forms.Button
    Friend WithEvents cmd_würfel As System.Windows.Forms.Button
End Class
