<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jones
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
        Me.cmd_Würfel = New System.Windows.Forms.Button()
        Me.cmd_Hauptmenü = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_Würfel
        '
        Me.cmd_Würfel.Location = New System.Drawing.Point(12, 76)
        Me.cmd_Würfel.Name = "cmd_Würfel"
        Me.cmd_Würfel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Würfel.TabIndex = 0
        Me.cmd_Würfel.Text = "Würfel"
        Me.cmd_Würfel.UseVisualStyleBackColor = True
        '
        'cmd_Hauptmenü
        '
        Me.cmd_Hauptmenü.Location = New System.Drawing.Point(197, 12)
        Me.cmd_Hauptmenü.Name = "cmd_Hauptmenü"
        Me.cmd_Hauptmenü.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Hauptmenü.TabIndex = 1
        Me.cmd_Hauptmenü.Text = "Hauptmenü"
        Me.cmd_Hauptmenü.UseVisualStyleBackColor = True
        '
        'Jones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmd_Hauptmenü)
        Me.Controls.Add(Me.cmd_Würfel)
        Me.Name = "Jones"
        Me.Text = "Jones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_Würfel As System.Windows.Forms.Button
    Friend WithEvents cmd_Hauptmenü As System.Windows.Forms.Button
End Class
