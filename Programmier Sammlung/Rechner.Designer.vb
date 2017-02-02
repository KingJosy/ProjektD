<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rechner
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.cmd_End = New System.Windows.Forms.Button()
        Me.cmd_Plus = New System.Windows.Forms.Button()
        Me.cmd_Minus = New System.Windows.Forms.Button()
        Me.cmd_Teilen = New System.Windows.Forms.Button()
        Me.cmd_Mal = New System.Windows.Forms.Button()
        Me.cmd_Berechnen = New System.Windows.Forms.Button()
        Me.cmd_Delete = New System.Windows.Forms.Button()
        Me.cmd_Neu = New System.Windows.Forms.Button()
        Me.lbl_Ergebnis = New System.Windows.Forms.Label()
        Me.Komma = New System.Windows.Forms.Button()
        Me.rtb_Eingabe1 = New System.Windows.Forms.RichTextBox()
        Me.rtb_Eingabe2 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(187, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(226, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(265, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(187, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(33, 30)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(226, 219)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(33, 30)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(265, 219)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(33, 30)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(187, 255)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(33, 30)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(226, 255)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(33, 30)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(265, 255)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(33, 30)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(226, 291)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(33, 30)
        Me.Button0.TabIndex = 9
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'cmd_End
        '
        Me.cmd_End.Location = New System.Drawing.Point(302, 413)
        Me.cmd_End.Name = "cmd_End"
        Me.cmd_End.Size = New System.Drawing.Size(75, 23)
        Me.cmd_End.TabIndex = 10
        Me.cmd_End.Text = "Beenden"
        Me.cmd_End.UseVisualStyleBackColor = True
        '
        'cmd_Plus
        '
        Me.cmd_Plus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Plus.Location = New System.Drawing.Point(344, 183)
        Me.cmd_Plus.Name = "cmd_Plus"
        Me.cmd_Plus.Size = New System.Drawing.Size(33, 30)
        Me.cmd_Plus.TabIndex = 11
        Me.cmd_Plus.Text = "+"
        Me.cmd_Plus.UseVisualStyleBackColor = True
        '
        'cmd_Minus
        '
        Me.cmd_Minus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Minus.Location = New System.Drawing.Point(344, 219)
        Me.cmd_Minus.Name = "cmd_Minus"
        Me.cmd_Minus.Size = New System.Drawing.Size(33, 30)
        Me.cmd_Minus.TabIndex = 12
        Me.cmd_Minus.Text = "-"
        Me.cmd_Minus.UseVisualStyleBackColor = True
        '
        'cmd_Teilen
        '
        Me.cmd_Teilen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Teilen.Location = New System.Drawing.Point(344, 255)
        Me.cmd_Teilen.Name = "cmd_Teilen"
        Me.cmd_Teilen.Size = New System.Drawing.Size(33, 30)
        Me.cmd_Teilen.TabIndex = 13
        Me.cmd_Teilen.Text = ":"
        Me.cmd_Teilen.UseVisualStyleBackColor = True
        '
        'cmd_Mal
        '
        Me.cmd_Mal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Mal.Location = New System.Drawing.Point(344, 291)
        Me.cmd_Mal.Name = "cmd_Mal"
        Me.cmd_Mal.Size = New System.Drawing.Size(33, 30)
        Me.cmd_Mal.TabIndex = 14
        Me.cmd_Mal.Text = "*"
        Me.cmd_Mal.UseVisualStyleBackColor = True
        '
        'cmd_Berechnen
        '
        Me.cmd_Berechnen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Berechnen.Location = New System.Drawing.Point(265, 291)
        Me.cmd_Berechnen.Name = "cmd_Berechnen"
        Me.cmd_Berechnen.Size = New System.Drawing.Size(33, 30)
        Me.cmd_Berechnen.TabIndex = 16
        Me.cmd_Berechnen.Text = "="
        Me.cmd_Berechnen.UseVisualStyleBackColor = True
        '
        'cmd_Delete
        '
        Me.cmd_Delete.Location = New System.Drawing.Point(187, 384)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Delete.TabIndex = 17
        Me.cmd_Delete.Text = "Löschen"
        Me.cmd_Delete.UseVisualStyleBackColor = True
        '
        'cmd_Neu
        '
        Me.cmd_Neu.Location = New System.Drawing.Point(187, 413)
        Me.cmd_Neu.Name = "cmd_Neu"
        Me.cmd_Neu.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Neu.TabIndex = 18
        Me.cmd_Neu.Text = "Neu"
        Me.cmd_Neu.UseVisualStyleBackColor = True
        '
        'lbl_Ergebnis
        '
        Me.lbl_Ergebnis.AutoSize = True
        Me.lbl_Ergebnis.Location = New System.Drawing.Point(325, 146)
        Me.lbl_Ergebnis.Name = "lbl_Ergebnis"
        Me.lbl_Ergebnis.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Ergebnis.TabIndex = 19
        Me.lbl_Ergebnis.Text = "Label1"
        '
        'Komma
        '
        Me.Komma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Komma.Location = New System.Drawing.Point(187, 291)
        Me.Komma.Name = "Komma"
        Me.Komma.Size = New System.Drawing.Size(33, 30)
        Me.Komma.TabIndex = 20
        Me.Komma.Text = ","
        Me.Komma.UseVisualStyleBackColor = True
        '
        'rtb_Eingabe1
        '
        Me.rtb_Eingabe1.Location = New System.Drawing.Point(187, 114)
        Me.rtb_Eingabe1.Name = "rtb_Eingabe1"
        Me.rtb_Eingabe1.Size = New System.Drawing.Size(96, 26)
        Me.rtb_Eingabe1.TabIndex = 21
        Me.rtb_Eingabe1.Text = ""
        '
        'rtb_Eingabe2
        '
        Me.rtb_Eingabe2.Location = New System.Drawing.Point(187, 146)
        Me.rtb_Eingabe2.Name = "rtb_Eingabe2"
        Me.rtb_Eingabe2.Size = New System.Drawing.Size(96, 26)
        Me.rtb_Eingabe2.TabIndex = 22
        Me.rtb_Eingabe2.Text = ""
        '
        'Rechner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 461)
        Me.Controls.Add(Me.rtb_Eingabe2)
        Me.Controls.Add(Me.rtb_Eingabe1)
        Me.Controls.Add(Me.Komma)
        Me.Controls.Add(Me.lbl_Ergebnis)
        Me.Controls.Add(Me.cmd_Neu)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_Berechnen)
        Me.Controls.Add(Me.cmd_Mal)
        Me.Controls.Add(Me.cmd_Teilen)
        Me.Controls.Add(Me.cmd_Minus)
        Me.Controls.Add(Me.cmd_Plus)
        Me.Controls.Add(Me.cmd_End)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Rechner"
        Me.Text = "Rechner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents cmd_End As System.Windows.Forms.Button
    Friend WithEvents cmd_Plus As System.Windows.Forms.Button
    Friend WithEvents cmd_Minus As System.Windows.Forms.Button
    Friend WithEvents cmd_Teilen As System.Windows.Forms.Button
    Friend WithEvents cmd_Mal As System.Windows.Forms.Button
    Friend WithEvents cmd_Berechnen As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_Neu As System.Windows.Forms.Button
    Friend WithEvents lbl_Ergebnis As System.Windows.Forms.Label
    Friend WithEvents Komma As System.Windows.Forms.Button
    Friend WithEvents rtb_Eingabe1 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtb_Eingabe2 As System.Windows.Forms.RichTextBox
End Class
