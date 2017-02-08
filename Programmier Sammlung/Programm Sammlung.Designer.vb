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
        Me.SuspendLayout()
        '
        'Sammlung
        '
        Me.ClientSize = New System.Drawing.Size(365, 330)
        Me.Name = "Sammlung"
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
