<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zinsrechner
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_T6 = New System.Windows.Forms.Label
        Me.lbl_P6 = New System.Windows.Forms.Label
        Me.lbl_K6 = New System.Windows.Forms.Label
        Me.lbl_Z6 = New System.Windows.Forms.Label
        Me.lbl_ergebnis = New System.Windows.Forms.Label
        Me.txt_ErgebnisZeit = New System.Windows.Forms.TextBox
        Me.txt_ErgebnisZinsessatz = New System.Windows.Forms.TextBox
        Me.txt_ErgebnisKapital = New System.Windows.Forms.TextBox
        Me.txt_ErgebnisZins = New System.Windows.Forms.TextBox
        Me.cmd_berechnenKapital = New System.Windows.Forms.Button
        Me.cmd_berechnenZinsessatz = New System.Windows.Forms.Button
        Me.cmd_berechnenZeit = New System.Windows.Forms.Button
        Me.lbl_T2 = New System.Windows.Forms.Label
        Me.lbl_T5 = New System.Windows.Forms.Label
        Me.lbl_T4 = New System.Windows.Forms.Label
        Me.lbl_T3 = New System.Windows.Forms.Label
        Me.txt_ZeitKapital = New System.Windows.Forms.TextBox
        Me.txt_ZeitZinsessatz = New System.Windows.Forms.TextBox
        Me.txt_ZeitZins = New System.Windows.Forms.TextBox
        Me.lbl_T1 = New System.Windows.Forms.Label
        Me.lbl_P2 = New System.Windows.Forms.Label
        Me.lbl_P5 = New System.Windows.Forms.Label
        Me.lbl_P4 = New System.Windows.Forms.Label
        Me.lbl_P3 = New System.Windows.Forms.Label
        Me.txt_ZinsessatzKapital = New System.Windows.Forms.TextBox
        Me.txt_ZinsessatzZeit = New System.Windows.Forms.TextBox
        Me.txt_ZinsessatzZins = New System.Windows.Forms.TextBox
        Me.lbl_P1 = New System.Windows.Forms.Label
        Me.lbl_K3 = New System.Windows.Forms.Label
        Me.lbl_K5 = New System.Windows.Forms.Label
        Me.lbl_K4 = New System.Windows.Forms.Label
        Me.lbl_K2 = New System.Windows.Forms.Label
        Me.txt_KapitalZinsessatz = New System.Windows.Forms.TextBox
        Me.txt_KapitalZeit = New System.Windows.Forms.TextBox
        Me.txt_KapitalZins = New System.Windows.Forms.TextBox
        Me.lbl_K1 = New System.Windows.Forms.Label
        Me.lbl_Z4 = New System.Windows.Forms.Label
        Me.lbl_Z2 = New System.Windows.Forms.Label
        Me.lbl_Z1 = New System.Windows.Forms.Label
        Me.lbl_Z5 = New System.Windows.Forms.Label
        Me.txt_ZinsZeit = New System.Windows.Forms.TextBox
        Me.txt_ZinsZinsessatz = New System.Windows.Forms.TextBox
        Me.txt_ZinsKapital = New System.Windows.Forms.TextBox
        Me.cmd_Zeit = New System.Windows.Forms.Button
        Me.cmd_Zinsessatz = New System.Windows.Forms.Button
        Me.cmd_Kapital = New System.Windows.Forms.Button
        Me.cmd_Zins = New System.Windows.Forms.Button
        Me.lbl_1 = New System.Windows.Forms.Label
        Me.cmd_end = New System.Windows.Forms.Button
        Me.cmd_neu = New System.Windows.Forms.Button
        Me.cmd_berechnenZins = New System.Windows.Forms.Button
        Me.lbl_Z3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 91)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Allgemeine Formel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "                  Kapital[K] x Zinsessatz[P] x Zeit[T]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zins[Z] = _______________" & _
            "_______________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                       100 x 360"
        '
        'lbl_T6
        '
        Me.lbl_T6.AutoSize = True
        Me.lbl_T6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_T6.Location = New System.Drawing.Point(116, 344)
        Me.lbl_T6.Name = "lbl_T6"
        Me.lbl_T6.Size = New System.Drawing.Size(38, 16)
        Me.lbl_T6.TabIndex = 113
        Me.lbl_T6.Text = "days"
        Me.lbl_T6.Visible = False
        '
        'lbl_P6
        '
        Me.lbl_P6.AutoSize = True
        Me.lbl_P6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_P6.Location = New System.Drawing.Point(116, 343)
        Me.lbl_P6.Name = "lbl_P6"
        Me.lbl_P6.Size = New System.Drawing.Size(20, 16)
        Me.lbl_P6.TabIndex = 112
        Me.lbl_P6.Text = "%"
        Me.lbl_P6.Visible = False
        '
        'lbl_K6
        '
        Me.lbl_K6.AutoSize = True
        Me.lbl_K6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K6.Location = New System.Drawing.Point(121, 342)
        Me.lbl_K6.Name = "lbl_K6"
        Me.lbl_K6.Size = New System.Drawing.Size(15, 16)
        Me.lbl_K6.TabIndex = 111
        Me.lbl_K6.Text = "€"
        Me.lbl_K6.Visible = False
        '
        'lbl_Z6
        '
        Me.lbl_Z6.AutoSize = True
        Me.lbl_Z6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Z6.Location = New System.Drawing.Point(121, 342)
        Me.lbl_Z6.Name = "lbl_Z6"
        Me.lbl_Z6.Size = New System.Drawing.Size(15, 16)
        Me.lbl_Z6.TabIndex = 110
        Me.lbl_Z6.Text = "€"
        Me.lbl_Z6.Visible = False
        '
        'lbl_ergebnis
        '
        Me.lbl_ergebnis.AutoSize = True
        Me.lbl_ergebnis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ergebnis.Location = New System.Drawing.Point(12, 322)
        Me.lbl_ergebnis.Name = "lbl_ergebnis"
        Me.lbl_ergebnis.Size = New System.Drawing.Size(74, 16)
        Me.lbl_ergebnis.TabIndex = 109
        Me.lbl_ergebnis.Text = "Ergebnis:"
        Me.lbl_ergebnis.Visible = False
        '
        'txt_ErgebnisZeit
        '
        Me.txt_ErgebnisZeit.BackColor = System.Drawing.Color.Lime
        Me.txt_ErgebnisZeit.Location = New System.Drawing.Point(15, 343)
        Me.txt_ErgebnisZeit.Name = "txt_ErgebnisZeit"
        Me.txt_ErgebnisZeit.ReadOnly = True
        Me.txt_ErgebnisZeit.Size = New System.Drawing.Size(100, 20)
        Me.txt_ErgebnisZeit.TabIndex = 108
        Me.txt_ErgebnisZeit.Visible = False
        '
        'txt_ErgebnisZinsessatz
        '
        Me.txt_ErgebnisZinsessatz.BackColor = System.Drawing.Color.Lime
        Me.txt_ErgebnisZinsessatz.Location = New System.Drawing.Point(15, 342)
        Me.txt_ErgebnisZinsessatz.Name = "txt_ErgebnisZinsessatz"
        Me.txt_ErgebnisZinsessatz.ReadOnly = True
        Me.txt_ErgebnisZinsessatz.Size = New System.Drawing.Size(100, 20)
        Me.txt_ErgebnisZinsessatz.TabIndex = 107
        Me.txt_ErgebnisZinsessatz.Visible = False
        '
        'txt_ErgebnisKapital
        '
        Me.txt_ErgebnisKapital.BackColor = System.Drawing.Color.Lime
        Me.txt_ErgebnisKapital.Location = New System.Drawing.Point(15, 342)
        Me.txt_ErgebnisKapital.Name = "txt_ErgebnisKapital"
        Me.txt_ErgebnisKapital.ReadOnly = True
        Me.txt_ErgebnisKapital.Size = New System.Drawing.Size(100, 20)
        Me.txt_ErgebnisKapital.TabIndex = 106
        Me.txt_ErgebnisKapital.Visible = False
        '
        'txt_ErgebnisZins
        '
        Me.txt_ErgebnisZins.BackColor = System.Drawing.Color.Lime
        Me.txt_ErgebnisZins.Location = New System.Drawing.Point(15, 341)
        Me.txt_ErgebnisZins.Name = "txt_ErgebnisZins"
        Me.txt_ErgebnisZins.ReadOnly = True
        Me.txt_ErgebnisZins.Size = New System.Drawing.Size(100, 20)
        Me.txt_ErgebnisZins.TabIndex = 105
        Me.txt_ErgebnisZins.Visible = False
        '
        'cmd_berechnenKapital
        '
        Me.cmd_berechnenKapital.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_berechnenKapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_berechnenKapital.Location = New System.Drawing.Point(12, 380)
        Me.cmd_berechnenKapital.Name = "cmd_berechnenKapital"
        Me.cmd_berechnenKapital.Size = New System.Drawing.Size(99, 45)
        Me.cmd_berechnenKapital.TabIndex = 104
        Me.cmd_berechnenKapital.Text = "Berechnen"
        Me.cmd_berechnenKapital.UseVisualStyleBackColor = False
        Me.cmd_berechnenKapital.Visible = False
        '
        'cmd_berechnenZinsessatz
        '
        Me.cmd_berechnenZinsessatz.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_berechnenZinsessatz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_berechnenZinsessatz.Location = New System.Drawing.Point(12, 380)
        Me.cmd_berechnenZinsessatz.Name = "cmd_berechnenZinsessatz"
        Me.cmd_berechnenZinsessatz.Size = New System.Drawing.Size(99, 45)
        Me.cmd_berechnenZinsessatz.TabIndex = 103
        Me.cmd_berechnenZinsessatz.Text = "Berechnen"
        Me.cmd_berechnenZinsessatz.UseVisualStyleBackColor = False
        Me.cmd_berechnenZinsessatz.Visible = False
        '
        'cmd_berechnenZeit
        '
        Me.cmd_berechnenZeit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_berechnenZeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_berechnenZeit.Location = New System.Drawing.Point(12, 380)
        Me.cmd_berechnenZeit.Name = "cmd_berechnenZeit"
        Me.cmd_berechnenZeit.Size = New System.Drawing.Size(99, 45)
        Me.cmd_berechnenZeit.TabIndex = 102
        Me.cmd_berechnenZeit.Text = "Berechnen"
        Me.cmd_berechnenZeit.UseVisualStyleBackColor = False
        Me.cmd_berechnenZeit.Visible = False
        '
        'lbl_T2
        '
        Me.lbl_T2.AutoSize = True
        Me.lbl_T2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_T2.Location = New System.Drawing.Point(200, 248)
        Me.lbl_T2.Name = "lbl_T2"
        Me.lbl_T2.Size = New System.Drawing.Size(237, 16)
        Me.lbl_T2.TabIndex = 101
        Me.lbl_T2.Text = "[Z]                          x 100                         x 360"
        Me.lbl_T2.Visible = False
        '
        'lbl_T5
        '
        Me.lbl_T5.AutoSize = True
        Me.lbl_T5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_T5.Location = New System.Drawing.Point(360, 285)
        Me.lbl_T5.Name = "lbl_T5"
        Me.lbl_T5.Size = New System.Drawing.Size(25, 16)
        Me.lbl_T5.TabIndex = 100
        Me.lbl_T5.Text = "[P]"
        Me.lbl_T5.Visible = False
        '
        'lbl_T4
        '
        Me.lbl_T4.AutoSize = True
        Me.lbl_T4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_T4.Location = New System.Drawing.Point(254, 285)
        Me.lbl_T4.Name = "lbl_T4"
        Me.lbl_T4.Size = New System.Drawing.Size(33, 16)
        Me.lbl_T4.TabIndex = 99
        Me.lbl_T4.Text = "[K] x"
        Me.lbl_T4.Visible = False
        '
        'lbl_T3
        '
        Me.lbl_T3.AutoSize = True
        Me.lbl_T3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_T3.Location = New System.Drawing.Point(126, 265)
        Me.lbl_T3.Name = "lbl_T3"
        Me.lbl_T3.Size = New System.Drawing.Size(309, 16)
        Me.lbl_T3.TabIndex = 98
        Me.lbl_T3.Text = "___________________________________________"
        Me.lbl_T3.Visible = False
        '
        'txt_ZeitKapital
        '
        Me.txt_ZeitKapital.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZeitKapital.Location = New System.Drawing.Point(183, 284)
        Me.txt_ZeitKapital.Name = "txt_ZeitKapital"
        Me.txt_ZeitKapital.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZeitKapital.TabIndex = 97
        Me.txt_ZeitKapital.Visible = False
        '
        'txt_ZeitZinsessatz
        '
        Me.txt_ZeitZinsessatz.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZeitZinsessatz.Location = New System.Drawing.Point(289, 284)
        Me.txt_ZeitZinsessatz.Name = "txt_ZeitZinsessatz"
        Me.txt_ZeitZinsessatz.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZeitZinsessatz.TabIndex = 96
        Me.txt_ZeitZinsessatz.Visible = False
        '
        'txt_ZeitZins
        '
        Me.txt_ZeitZins.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZeitZins.Location = New System.Drawing.Point(129, 247)
        Me.txt_ZeitZins.Name = "txt_ZeitZins"
        Me.txt_ZeitZins.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZeitZins.TabIndex = 95
        Me.txt_ZeitZins.Visible = False
        '
        'lbl_T1
        '
        Me.lbl_T1.AutoSize = True
        Me.lbl_T1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_T1.Location = New System.Drawing.Point(12, 265)
        Me.lbl_T1.Name = "lbl_T1"
        Me.lbl_T1.Size = New System.Drawing.Size(70, 16)
        Me.lbl_T1.TabIndex = 94
        Me.lbl_T1.Text = "Zeit [T] ="
        Me.lbl_T1.Visible = False
        '
        'lbl_P2
        '
        Me.lbl_P2.AutoSize = True
        Me.lbl_P2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_P2.Location = New System.Drawing.Point(200, 248)
        Me.lbl_P2.Name = "lbl_P2"
        Me.lbl_P2.Size = New System.Drawing.Size(237, 16)
        Me.lbl_P2.TabIndex = 93
        Me.lbl_P2.Text = "[Z]                          x 100                         x 360"
        Me.lbl_P2.Visible = False
        '
        'lbl_P5
        '
        Me.lbl_P5.AutoSize = True
        Me.lbl_P5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_P5.Location = New System.Drawing.Point(360, 285)
        Me.lbl_P5.Name = "lbl_P5"
        Me.lbl_P5.Size = New System.Drawing.Size(25, 16)
        Me.lbl_P5.TabIndex = 92
        Me.lbl_P5.Text = "[T]"
        Me.lbl_P5.Visible = False
        '
        'lbl_P4
        '
        Me.lbl_P4.AutoSize = True
        Me.lbl_P4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_P4.Location = New System.Drawing.Point(254, 285)
        Me.lbl_P4.Name = "lbl_P4"
        Me.lbl_P4.Size = New System.Drawing.Size(33, 16)
        Me.lbl_P4.TabIndex = 91
        Me.lbl_P4.Text = "[K] x"
        Me.lbl_P4.Visible = False
        '
        'lbl_P3
        '
        Me.lbl_P3.AutoSize = True
        Me.lbl_P3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_P3.Location = New System.Drawing.Point(126, 265)
        Me.lbl_P3.Name = "lbl_P3"
        Me.lbl_P3.Size = New System.Drawing.Size(309, 16)
        Me.lbl_P3.TabIndex = 90
        Me.lbl_P3.Text = "___________________________________________"
        Me.lbl_P3.Visible = False
        '
        'txt_ZinsessatzKapital
        '
        Me.txt_ZinsessatzKapital.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZinsessatzKapital.Location = New System.Drawing.Point(183, 284)
        Me.txt_ZinsessatzKapital.Name = "txt_ZinsessatzKapital"
        Me.txt_ZinsessatzKapital.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZinsessatzKapital.TabIndex = 89
        Me.txt_ZinsessatzKapital.Visible = False
        '
        'txt_ZinsessatzZeit
        '
        Me.txt_ZinsessatzZeit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZinsessatzZeit.Location = New System.Drawing.Point(289, 284)
        Me.txt_ZinsessatzZeit.Name = "txt_ZinsessatzZeit"
        Me.txt_ZinsessatzZeit.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZinsessatzZeit.TabIndex = 88
        Me.txt_ZinsessatzZeit.Visible = False
        '
        'txt_ZinsessatzZins
        '
        Me.txt_ZinsessatzZins.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZinsessatzZins.Location = New System.Drawing.Point(129, 247)
        Me.txt_ZinsessatzZins.Name = "txt_ZinsessatzZins"
        Me.txt_ZinsessatzZins.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZinsessatzZins.TabIndex = 87
        Me.txt_ZinsessatzZins.Visible = False
        '
        'lbl_P1
        '
        Me.lbl_P1.AutoSize = True
        Me.lbl_P1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_P1.Location = New System.Drawing.Point(12, 265)
        Me.lbl_P1.Name = "lbl_P1"
        Me.lbl_P1.Size = New System.Drawing.Size(118, 16)
        Me.lbl_P1.TabIndex = 86
        Me.lbl_P1.Text = "Zinsessatz [P] ="
        Me.lbl_P1.Visible = False
        '
        'lbl_K3
        '
        Me.lbl_K3.AutoSize = True
        Me.lbl_K3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K3.Location = New System.Drawing.Point(200, 248)
        Me.lbl_K3.Name = "lbl_K3"
        Me.lbl_K3.Size = New System.Drawing.Size(237, 16)
        Me.lbl_K3.TabIndex = 85
        Me.lbl_K3.Text = "[Z]                          x 100                         x 360"
        Me.lbl_K3.Visible = False
        '
        'lbl_K5
        '
        Me.lbl_K5.AutoSize = True
        Me.lbl_K5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K5.Location = New System.Drawing.Point(360, 285)
        Me.lbl_K5.Name = "lbl_K5"
        Me.lbl_K5.Size = New System.Drawing.Size(25, 16)
        Me.lbl_K5.TabIndex = 84
        Me.lbl_K5.Text = "[T]"
        Me.lbl_K5.Visible = False
        '
        'lbl_K4
        '
        Me.lbl_K4.AutoSize = True
        Me.lbl_K4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K4.Location = New System.Drawing.Point(254, 285)
        Me.lbl_K4.Name = "lbl_K4"
        Me.lbl_K4.Size = New System.Drawing.Size(34, 16)
        Me.lbl_K4.TabIndex = 83
        Me.lbl_K4.Text = "[P] x"
        Me.lbl_K4.Visible = False
        '
        'lbl_K2
        '
        Me.lbl_K2.AutoSize = True
        Me.lbl_K2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K2.Location = New System.Drawing.Point(126, 265)
        Me.lbl_K2.Name = "lbl_K2"
        Me.lbl_K2.Size = New System.Drawing.Size(309, 16)
        Me.lbl_K2.TabIndex = 82
        Me.lbl_K2.Text = "___________________________________________"
        Me.lbl_K2.Visible = False
        '
        'txt_KapitalZinsessatz
        '
        Me.txt_KapitalZinsessatz.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_KapitalZinsessatz.Location = New System.Drawing.Point(183, 284)
        Me.txt_KapitalZinsessatz.Name = "txt_KapitalZinsessatz"
        Me.txt_KapitalZinsessatz.Size = New System.Drawing.Size(65, 20)
        Me.txt_KapitalZinsessatz.TabIndex = 81
        Me.txt_KapitalZinsessatz.Visible = False
        '
        'txt_KapitalZeit
        '
        Me.txt_KapitalZeit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_KapitalZeit.Location = New System.Drawing.Point(289, 284)
        Me.txt_KapitalZeit.Name = "txt_KapitalZeit"
        Me.txt_KapitalZeit.Size = New System.Drawing.Size(65, 20)
        Me.txt_KapitalZeit.TabIndex = 80
        Me.txt_KapitalZeit.Visible = False
        '
        'txt_KapitalZins
        '
        Me.txt_KapitalZins.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_KapitalZins.Location = New System.Drawing.Point(129, 247)
        Me.txt_KapitalZins.Name = "txt_KapitalZins"
        Me.txt_KapitalZins.Size = New System.Drawing.Size(65, 20)
        Me.txt_KapitalZins.TabIndex = 79
        Me.txt_KapitalZins.Visible = False
        '
        'lbl_K1
        '
        Me.lbl_K1.AutoSize = True
        Me.lbl_K1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K1.Location = New System.Drawing.Point(12, 265)
        Me.lbl_K1.Name = "lbl_K1"
        Me.lbl_K1.Size = New System.Drawing.Size(91, 16)
        Me.lbl_K1.TabIndex = 78
        Me.lbl_K1.Text = "Kapital [K] ="
        Me.lbl_K1.Visible = False
        '
        'lbl_Z4
        '
        Me.lbl_Z4.AutoSize = True
        Me.lbl_Z4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Z4.Location = New System.Drawing.Point(129, 265)
        Me.lbl_Z4.Name = "lbl_Z4"
        Me.lbl_Z4.Size = New System.Drawing.Size(309, 32)
        Me.lbl_Z4.TabIndex = 77
        Me.lbl_Z4.Text = "___________________________________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                    " & _
            "   100 x 360"
        Me.lbl_Z4.Visible = False
        '
        'lbl_Z2
        '
        Me.lbl_Z2.AutoSize = True
        Me.lbl_Z2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Z2.Location = New System.Drawing.Point(309, 249)
        Me.lbl_Z2.Name = "lbl_Z2"
        Me.lbl_Z2.Size = New System.Drawing.Size(34, 16)
        Me.lbl_Z2.TabIndex = 76
        Me.lbl_Z2.Text = "[P] x"
        Me.lbl_Z2.Visible = False
        '
        'lbl_Z1
        '
        Me.lbl_Z1.AutoSize = True
        Me.lbl_Z1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Z1.Location = New System.Drawing.Point(203, 249)
        Me.lbl_Z1.Name = "lbl_Z1"
        Me.lbl_Z1.Size = New System.Drawing.Size(33, 16)
        Me.lbl_Z1.TabIndex = 75
        Me.lbl_Z1.Text = "[K] x"
        Me.lbl_Z1.Visible = False
        '
        'lbl_Z5
        '
        Me.lbl_Z5.AutoSize = True
        Me.lbl_Z5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Z5.Location = New System.Drawing.Point(12, 265)
        Me.lbl_Z5.Name = "lbl_Z5"
        Me.lbl_Z5.Size = New System.Drawing.Size(72, 16)
        Me.lbl_Z5.TabIndex = 74
        Me.lbl_Z5.Text = "Zins [Z] ="
        Me.lbl_Z5.Visible = False
        '
        'txt_ZinsZeit
        '
        Me.txt_ZinsZeit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZinsZeit.Location = New System.Drawing.Point(344, 246)
        Me.txt_ZinsZeit.Name = "txt_ZinsZeit"
        Me.txt_ZinsZeit.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZinsZeit.TabIndex = 73
        Me.txt_ZinsZeit.Visible = False
        '
        'txt_ZinsZinsessatz
        '
        Me.txt_ZinsZinsessatz.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZinsZinsessatz.Location = New System.Drawing.Point(238, 246)
        Me.txt_ZinsZinsessatz.Name = "txt_ZinsZinsessatz"
        Me.txt_ZinsZinsessatz.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZinsZinsessatz.TabIndex = 72
        Me.txt_ZinsZinsessatz.Visible = False
        '
        'txt_ZinsKapital
        '
        Me.txt_ZinsKapital.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_ZinsKapital.Location = New System.Drawing.Point(132, 246)
        Me.txt_ZinsKapital.Name = "txt_ZinsKapital"
        Me.txt_ZinsKapital.Size = New System.Drawing.Size(65, 20)
        Me.txt_ZinsKapital.TabIndex = 71
        Me.txt_ZinsKapital.Visible = False
        '
        'cmd_Zeit
        '
        Me.cmd_Zeit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_Zeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Zeit.Location = New System.Drawing.Point(297, 161)
        Me.cmd_Zeit.Name = "cmd_Zeit"
        Me.cmd_Zeit.Size = New System.Drawing.Size(89, 45)
        Me.cmd_Zeit.TabIndex = 70
        Me.cmd_Zeit.Text = "Zeit [T]"
        Me.cmd_Zeit.UseVisualStyleBackColor = False
        '
        'cmd_Zinsessatz
        '
        Me.cmd_Zinsessatz.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_Zinsessatz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Zinsessatz.Location = New System.Drawing.Point(202, 161)
        Me.cmd_Zinsessatz.Name = "cmd_Zinsessatz"
        Me.cmd_Zinsessatz.Size = New System.Drawing.Size(89, 45)
        Me.cmd_Zinsessatz.TabIndex = 69
        Me.cmd_Zinsessatz.Text = "Zinsessatz [P]"
        Me.cmd_Zinsessatz.UseVisualStyleBackColor = False
        '
        'cmd_Kapital
        '
        Me.cmd_Kapital.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_Kapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Kapital.Location = New System.Drawing.Point(107, 161)
        Me.cmd_Kapital.Name = "cmd_Kapital"
        Me.cmd_Kapital.Size = New System.Drawing.Size(89, 45)
        Me.cmd_Kapital.TabIndex = 68
        Me.cmd_Kapital.Text = "Kapital [K]"
        Me.cmd_Kapital.UseVisualStyleBackColor = False
        '
        'cmd_Zins
        '
        Me.cmd_Zins.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_Zins.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Zins.Location = New System.Drawing.Point(12, 161)
        Me.cmd_Zins.Name = "cmd_Zins"
        Me.cmd_Zins.Size = New System.Drawing.Size(89, 45)
        Me.cmd_Zins.TabIndex = 67
        Me.cmd_Zins.Text = "Zins [Z]"
        Me.cmd_Zins.UseVisualStyleBackColor = False
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.Location = New System.Drawing.Point(104, 128)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(203, 16)
        Me.lbl_1.TabIndex = 66
        Me.lbl_1.Text = "Was soll berechnet werden?"
        '
        'cmd_end
        '
        Me.cmd_end.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_end.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_end.Location = New System.Drawing.Point(299, 380)
        Me.cmd_end.Name = "cmd_end"
        Me.cmd_end.Size = New System.Drawing.Size(87, 45)
        Me.cmd_end.TabIndex = 65
        Me.cmd_end.Text = "Beenden"
        Me.cmd_end.UseVisualStyleBackColor = False
        '
        'cmd_neu
        '
        Me.cmd_neu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_neu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_neu.Location = New System.Drawing.Point(206, 380)
        Me.cmd_neu.Name = "cmd_neu"
        Me.cmd_neu.Size = New System.Drawing.Size(87, 45)
        Me.cmd_neu.TabIndex = 64
        Me.cmd_neu.Text = "Neu"
        Me.cmd_neu.UseVisualStyleBackColor = False
        Me.cmd_neu.Visible = False
        '
        'cmd_berechnenZins
        '
        Me.cmd_berechnenZins.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_berechnenZins.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_berechnenZins.Location = New System.Drawing.Point(12, 380)
        Me.cmd_berechnenZins.Name = "cmd_berechnenZins"
        Me.cmd_berechnenZins.Size = New System.Drawing.Size(99, 45)
        Me.cmd_berechnenZins.TabIndex = 63
        Me.cmd_berechnenZins.Text = "Berechnen"
        Me.cmd_berechnenZins.UseVisualStyleBackColor = False
        Me.cmd_berechnenZins.Visible = False
        '
        'lbl_Z3
        '
        Me.lbl_Z3.AutoSize = True
        Me.lbl_Z3.Location = New System.Drawing.Point(415, 249)
        Me.lbl_Z3.Name = "lbl_Z3"
        Me.lbl_Z3.Size = New System.Drawing.Size(20, 13)
        Me.lbl_Z3.TabIndex = 115
        Me.lbl_Z3.Text = "[T]"
        '
        'Zinsrechner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 454)
        Me.Controls.Add(Me.lbl_Z3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_T6)
        Me.Controls.Add(Me.lbl_P6)
        Me.Controls.Add(Me.lbl_K6)
        Me.Controls.Add(Me.lbl_Z6)
        Me.Controls.Add(Me.lbl_ergebnis)
        Me.Controls.Add(Me.txt_ErgebnisZeit)
        Me.Controls.Add(Me.txt_ErgebnisZinsessatz)
        Me.Controls.Add(Me.txt_ErgebnisKapital)
        Me.Controls.Add(Me.txt_ErgebnisZins)
        Me.Controls.Add(Me.cmd_berechnenKapital)
        Me.Controls.Add(Me.cmd_berechnenZinsessatz)
        Me.Controls.Add(Me.cmd_berechnenZeit)
        Me.Controls.Add(Me.lbl_T2)
        Me.Controls.Add(Me.lbl_T5)
        Me.Controls.Add(Me.lbl_T4)
        Me.Controls.Add(Me.lbl_T3)
        Me.Controls.Add(Me.txt_ZeitKapital)
        Me.Controls.Add(Me.txt_ZeitZinsessatz)
        Me.Controls.Add(Me.txt_ZeitZins)
        Me.Controls.Add(Me.lbl_T1)
        Me.Controls.Add(Me.lbl_P2)
        Me.Controls.Add(Me.lbl_P5)
        Me.Controls.Add(Me.lbl_P4)
        Me.Controls.Add(Me.lbl_P3)
        Me.Controls.Add(Me.txt_ZinsessatzKapital)
        Me.Controls.Add(Me.txt_ZinsessatzZeit)
        Me.Controls.Add(Me.txt_ZinsessatzZins)
        Me.Controls.Add(Me.lbl_P1)
        Me.Controls.Add(Me.lbl_K3)
        Me.Controls.Add(Me.lbl_K5)
        Me.Controls.Add(Me.lbl_K4)
        Me.Controls.Add(Me.lbl_K2)
        Me.Controls.Add(Me.txt_KapitalZinsessatz)
        Me.Controls.Add(Me.txt_KapitalZeit)
        Me.Controls.Add(Me.txt_KapitalZins)
        Me.Controls.Add(Me.lbl_K1)
        Me.Controls.Add(Me.lbl_Z4)
        Me.Controls.Add(Me.lbl_Z2)
        Me.Controls.Add(Me.lbl_Z1)
        Me.Controls.Add(Me.lbl_Z5)
        Me.Controls.Add(Me.txt_ZinsZeit)
        Me.Controls.Add(Me.txt_ZinsZinsessatz)
        Me.Controls.Add(Me.txt_ZinsKapital)
        Me.Controls.Add(Me.cmd_Zeit)
        Me.Controls.Add(Me.cmd_Zinsessatz)
        Me.Controls.Add(Me.cmd_Kapital)
        Me.Controls.Add(Me.cmd_Zins)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.cmd_end)
        Me.Controls.Add(Me.cmd_neu)
        Me.Controls.Add(Me.cmd_berechnenZins)
        Me.Name = "Zinsrechner"
        Me.Text = "Zinsrechner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_T6 As System.Windows.Forms.Label
    Friend WithEvents lbl_P6 As System.Windows.Forms.Label
    Friend WithEvents lbl_K6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Z6 As System.Windows.Forms.Label
    Friend WithEvents lbl_ergebnis As System.Windows.Forms.Label
    Friend WithEvents txt_ErgebnisZeit As System.Windows.Forms.TextBox
    Friend WithEvents txt_ErgebnisZinsessatz As System.Windows.Forms.TextBox
    Friend WithEvents txt_ErgebnisKapital As System.Windows.Forms.TextBox
    Friend WithEvents txt_ErgebnisZins As System.Windows.Forms.TextBox
    Friend WithEvents cmd_berechnenKapital As System.Windows.Forms.Button
    Friend WithEvents cmd_berechnenZinsessatz As System.Windows.Forms.Button
    Friend WithEvents cmd_berechnenZeit As System.Windows.Forms.Button
    Friend WithEvents lbl_T2 As System.Windows.Forms.Label
    Friend WithEvents lbl_T5 As System.Windows.Forms.Label
    Friend WithEvents lbl_T4 As System.Windows.Forms.Label
    Friend WithEvents lbl_T3 As System.Windows.Forms.Label
    Friend WithEvents txt_ZeitKapital As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZeitZinsessatz As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZeitZins As System.Windows.Forms.TextBox
    Friend WithEvents lbl_T1 As System.Windows.Forms.Label
    Friend WithEvents lbl_P2 As System.Windows.Forms.Label
    Friend WithEvents lbl_P5 As System.Windows.Forms.Label
    Friend WithEvents lbl_P4 As System.Windows.Forms.Label
    Friend WithEvents lbl_P3 As System.Windows.Forms.Label
    Friend WithEvents txt_ZinsessatzKapital As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZinsessatzZeit As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZinsessatzZins As System.Windows.Forms.TextBox
    Friend WithEvents lbl_P1 As System.Windows.Forms.Label
    Friend WithEvents lbl_K3 As System.Windows.Forms.Label
    Friend WithEvents lbl_K5 As System.Windows.Forms.Label
    Friend WithEvents lbl_K4 As System.Windows.Forms.Label
    Friend WithEvents lbl_K2 As System.Windows.Forms.Label
    Friend WithEvents txt_KapitalZinsessatz As System.Windows.Forms.TextBox
    Friend WithEvents txt_KapitalZeit As System.Windows.Forms.TextBox
    Friend WithEvents txt_KapitalZins As System.Windows.Forms.TextBox
    Friend WithEvents lbl_K1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Z4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Z2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Z1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Z5 As System.Windows.Forms.Label
    Friend WithEvents txt_ZinsZeit As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZinsZinsessatz As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZinsKapital As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Zeit As System.Windows.Forms.Button
    Friend WithEvents cmd_Zinsessatz As System.Windows.Forms.Button
    Friend WithEvents cmd_Kapital As System.Windows.Forms.Button
    Friend WithEvents cmd_Zins As System.Windows.Forms.Button
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents cmd_end As System.Windows.Forms.Button
    Friend WithEvents cmd_neu As System.Windows.Forms.Button
    Friend WithEvents cmd_berechnenZins As System.Windows.Forms.Button
    Friend WithEvents lbl_Z3 As System.Windows.Forms.Label
End Class
