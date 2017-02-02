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
        Me.cmd_back = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmd_back
        '
        Me.cmd_back.Location = New System.Drawing.Point(12, 741)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(75, 23)
        Me.cmd_back.TabIndex = 0
        Me.cmd_back.Text = "Zurück"
        Me.cmd_back.UseVisualStyleBackColor = True
        '
        'Mensch_ärgere_dich_nicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 776)
        Me.Controls.Add(Me.cmd_back)
        Me.Name = "Mensch_ärgere_dich_nicht"
        Me.Text = "Mensch_ärgere_dich_nicht"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_back As System.Windows.Forms.Button
End Class
