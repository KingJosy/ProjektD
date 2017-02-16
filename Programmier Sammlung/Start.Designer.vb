<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.cmd_ProgrammSammlung = New System.Windows.Forms.Button()
        Me.cmd_Jones = New System.Windows.Forms.Button()
        Me.cmd_Julian = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_ProgrammSammlung
        '
        Me.cmd_ProgrammSammlung.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ProgrammSammlung.Location = New System.Drawing.Point(41, 12)
        Me.cmd_ProgrammSammlung.Name = "cmd_ProgrammSammlung"
        Me.cmd_ProgrammSammlung.Size = New System.Drawing.Size(180, 76)
        Me.cmd_ProgrammSammlung.TabIndex = 0
        Me.cmd_ProgrammSammlung.Text = "Programm Sammlung"
        Me.cmd_ProgrammSammlung.UseVisualStyleBackColor = True
        '
        'cmd_Jones
        '
        Me.cmd_Jones.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Jones.Location = New System.Drawing.Point(41, 94)
        Me.cmd_Jones.Name = "cmd_Jones"
        Me.cmd_Jones.Size = New System.Drawing.Size(180, 76)
        Me.cmd_Jones.TabIndex = 1
        Me.cmd_Jones.Text = "Jones"
        Me.cmd_Jones.UseVisualStyleBackColor = True
        '
        'cmd_Julian
        '
        Me.cmd_Julian.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Julian.Location = New System.Drawing.Point(41, 176)
        Me.cmd_Julian.Name = "cmd_Julian"
        Me.cmd_Julian.Size = New System.Drawing.Size(180, 76)
        Me.cmd_Julian.TabIndex = 2
        Me.cmd_Julian.Text = "Schiefer"
        Me.cmd_Julian.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(41, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "End"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 307)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmd_Julian)
        Me.Controls.Add(Me.cmd_Jones)
        Me.Controls.Add(Me.cmd_ProgrammSammlung)
        Me.Name = "Start"
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_ProgrammSammlung As System.Windows.Forms.Button
    Friend WithEvents cmd_Jones As System.Windows.Forms.Button
    Friend WithEvents cmd_Julian As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
