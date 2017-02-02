<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sammlung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sammlung))
        Me.cmd_End = New System.Windows.Forms.Button()
        Me.cmd_Sonne = New System.Windows.Forms.Button()
<<<<<<< Updated upstream
        Me.Label1 = New System.Windows.Forms.Label()
=======
>>>>>>> Stashed changes
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_BMI = New System.Windows.Forms.Button()
        Me.cmd_Zinsrechner = New System.Windows.Forms.Button()
        Me.cmd_game1 = New System.Windows.Forms.Button()
<<<<<<< Updated upstream
        Me.Button1 = New System.Windows.Forms.Button()
=======
        Me.cmd_Zahlenraten = New System.Windows.Forms.Button()
        Me.cmd_Taschenrechner = New System.Windows.Forms.Button()
>>>>>>> Stashed changes
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_End
        '
        Me.cmd_End.Location = New System.Drawing.Point(326, 387)
        Me.cmd_End.Name = "cmd_End"
        Me.cmd_End.Size = New System.Drawing.Size(86, 23)
        Me.cmd_End.TabIndex = 0
        Me.cmd_End.Text = "Beenden"
        Me.cmd_End.UseVisualStyleBackColor = True
        '
        'cmd_Sonne
        '
        Me.cmd_Sonne.Location = New System.Drawing.Point(15, 244)
        Me.cmd_Sonne.Name = "cmd_Sonne"
        Me.cmd_Sonne.Size = New System.Drawing.Size(86, 23)
        Me.cmd_Sonne.TabIndex = 1
        Me.cmd_Sonne.Text = "Sonne/Mond"
        Me.cmd_Sonne.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 200)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'cmd_BMI
        '
        Me.cmd_BMI.Location = New System.Drawing.Point(15, 358)
        Me.cmd_BMI.Name = "cmd_BMI"
        Me.cmd_BMI.Size = New System.Drawing.Size(86, 23)
        Me.cmd_BMI.TabIndex = 4
        Me.cmd_BMI.Text = "BMI Rechner"
        Me.cmd_BMI.UseVisualStyleBackColor = True
        '
        'cmd_Zinsrechner
        '
        Me.cmd_Zinsrechner.Location = New System.Drawing.Point(15, 387)
        Me.cmd_Zinsrechner.Name = "cmd_Zinsrechner"
        Me.cmd_Zinsrechner.Size = New System.Drawing.Size(86, 23)
        Me.cmd_Zinsrechner.TabIndex = 5
        Me.cmd_Zinsrechner.Text = "Zinsrechner"
        Me.cmd_Zinsrechner.UseVisualStyleBackColor = True
        '
        'cmd_game1
        '
        Me.cmd_game1.Location = New System.Drawing.Point(234, 244)
        Me.cmd_game1.Name = "cmd_game1"
        Me.cmd_game1.Size = New System.Drawing.Size(86, 23)
        Me.cmd_game1.TabIndex = 6
        Me.cmd_game1.Text = "Spiel"
        Me.cmd_game1.UseVisualStyleBackColor = True
        '
        'cmd_Zahlenraten
        '
        Me.cmd_Zahlenraten.Location = New System.Drawing.Point(326, 244)
        Me.cmd_Zahlenraten.Name = "cmd_Zahlenraten"
        Me.cmd_Zahlenraten.Size = New System.Drawing.Size(86, 23)
        Me.cmd_Zahlenraten.TabIndex = 7
        Me.cmd_Zahlenraten.Text = "Zahlenraten"
        Me.cmd_Zahlenraten.UseVisualStyleBackColor = True
        '
        'cmd_Taschenrechner
        '
        Me.cmd_Taschenrechner.Location = New System.Drawing.Point(15, 329)
        Me.cmd_Taschenrechner.Name = "cmd_Taschenrechner"
        Me.cmd_Taschenrechner.Size = New System.Drawing.Size(86, 23)
        Me.cmd_Taschenrechner.TabIndex = 8
        Me.cmd_Taschenrechner.Text = "Rechner"
        Me.cmd_Taschenrechner.UseVisualStyleBackColor = True
        '
        'Sammlung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 422)
        Me.Controls.Add(Me.cmd_Taschenrechner)
        Me.Controls.Add(Me.cmd_Zahlenraten)
        Me.Controls.Add(Me.cmd_game1)
        Me.Controls.Add(Me.cmd_Zinsrechner)
        Me.Controls.Add(Me.cmd_BMI)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_Sonne)
        Me.Controls.Add(Me.cmd_End)
        Me.Name = "Sammlung"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_End As System.Windows.Forms.Button
    Friend WithEvents cmd_Sonne As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_BMI As System.Windows.Forms.Button
    Friend WithEvents cmd_Zinsrechner As System.Windows.Forms.Button
    Friend WithEvents cmd_game1 As System.Windows.Forms.Button
    Friend WithEvents cmd_Zahlenraten As System.Windows.Forms.Button
    Friend WithEvents cmd_Taschenrechner As System.Windows.Forms.Button

End Class
