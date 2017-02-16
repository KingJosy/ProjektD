<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programm_Sammlung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programm_Sammlung))
        Me.cmd_End = New System.Windows.Forms.Button()
        Me.cmd_sonne_mond = New System.Windows.Forms.Button()
        Me.cmd_BMI = New System.Windows.Forms.Button()
        Me.cmd_Zahlenraten = New System.Windows.Forms.Button()
        Me.cmd_zinsrechner = New System.Windows.Forms.Button()
        Me.cmd_rechner = New System.Windows.Forms.Button()
        Me.cmd_Mensch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_ÖhmischerRechner = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_End
        '
        Me.cmd_End.Location = New System.Drawing.Point(340, 371)
        Me.cmd_End.Name = "cmd_End"
        Me.cmd_End.Size = New System.Drawing.Size(75, 23)
        Me.cmd_End.TabIndex = 0
        Me.cmd_End.Text = "End"
        Me.cmd_End.UseVisualStyleBackColor = True
        '
        'cmd_sonne_mond
        '
        Me.cmd_sonne_mond.Location = New System.Drawing.Point(14, 235)
        Me.cmd_sonne_mond.Name = "cmd_sonne_mond"
        Me.cmd_sonne_mond.Size = New System.Drawing.Size(97, 23)
        Me.cmd_sonne_mond.TabIndex = 1
        Me.cmd_sonne_mond.Text = "Sonne Mond"
        Me.cmd_sonne_mond.UseVisualStyleBackColor = True
        '
        'cmd_BMI
        '
        Me.cmd_BMI.Location = New System.Drawing.Point(117, 371)
        Me.cmd_BMI.Name = "cmd_BMI"
        Me.cmd_BMI.Size = New System.Drawing.Size(99, 23)
        Me.cmd_BMI.TabIndex = 2
        Me.cmd_BMI.Text = "BMI"
        Me.cmd_BMI.UseVisualStyleBackColor = True
        '
        'cmd_Zahlenraten
        '
        Me.cmd_Zahlenraten.Location = New System.Drawing.Point(318, 235)
        Me.cmd_Zahlenraten.Name = "cmd_Zahlenraten"
        Me.cmd_Zahlenraten.Size = New System.Drawing.Size(97, 23)
        Me.cmd_Zahlenraten.TabIndex = 3
        Me.cmd_Zahlenraten.Text = "Zahlenraten"
        Me.cmd_Zahlenraten.UseVisualStyleBackColor = True
        '
        'cmd_zinsrechner
        '
        Me.cmd_zinsrechner.Location = New System.Drawing.Point(12, 371)
        Me.cmd_zinsrechner.Name = "cmd_zinsrechner"
        Me.cmd_zinsrechner.Size = New System.Drawing.Size(99, 23)
        Me.cmd_zinsrechner.TabIndex = 4
        Me.cmd_zinsrechner.Text = "Zinsrechner"
        Me.cmd_zinsrechner.UseVisualStyleBackColor = True
        '
        'cmd_rechner
        '
        Me.cmd_rechner.Location = New System.Drawing.Point(12, 342)
        Me.cmd_rechner.Name = "cmd_rechner"
        Me.cmd_rechner.Size = New System.Drawing.Size(99, 23)
        Me.cmd_rechner.TabIndex = 5
        Me.cmd_rechner.Text = "Rechner"
        Me.cmd_rechner.UseVisualStyleBackColor = True
        '
        'cmd_Mensch
        '
        Me.cmd_Mensch.Location = New System.Drawing.Point(318, 264)
        Me.cmd_Mensch.Name = "cmd_Mensch"
        Me.cmd_Mensch.Size = New System.Drawing.Size(97, 23)
        Me.cmd_Mensch.TabIndex = 6
        Me.cmd_Mensch.Text = "Mensch"
        Me.cmd_Mensch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 201)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'cmd_ÖhmischerRechner
        '
        Me.cmd_ÖhmischerRechner.Location = New System.Drawing.Point(117, 342)
        Me.cmd_ÖhmischerRechner.Name = "cmd_ÖhmischerRechner"
        Me.cmd_ÖhmischerRechner.Size = New System.Drawing.Size(99, 23)
        Me.cmd_ÖhmischerRechner.TabIndex = 8
        Me.cmd_ÖhmischerRechner.Text = "Ohm Rechner"
        Me.cmd_ÖhmischerRechner.UseVisualStyleBackColor = True
        '
        'Programm_Sammlung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 406)
        Me.Controls.Add(Me.cmd_ÖhmischerRechner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_Mensch)
        Me.Controls.Add(Me.cmd_rechner)
        Me.Controls.Add(Me.cmd_zinsrechner)
        Me.Controls.Add(Me.cmd_Zahlenraten)
        Me.Controls.Add(Me.cmd_BMI)
        Me.Controls.Add(Me.cmd_sonne_mond)
        Me.Controls.Add(Me.cmd_End)
        Me.Name = "Programm_Sammlung"
        Me.Text = "Programm_Sammlung"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_End As Button
    Friend WithEvents cmd_sonne_mond As Button
    Friend WithEvents cmd_BMI As Button
    Friend WithEvents cmd_Zahlenraten As Button
    Friend WithEvents cmd_zinsrechner As Button
    Friend WithEvents cmd_rechner As Button
    Friend WithEvents cmd_Mensch As Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_ÖhmischerRechner As System.Windows.Forms.Button
End Class
