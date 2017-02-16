<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Würfel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Würfel))
        Me.pb_6 = New System.Windows.Forms.PictureBox()
        Me.pb_5 = New System.Windows.Forms.PictureBox()
        Me.pb_4 = New System.Windows.Forms.PictureBox()
        Me.pb_3 = New System.Windows.Forms.PictureBox()
        Me.pb_2 = New System.Windows.Forms.PictureBox()
        Me.pb_1 = New System.Windows.Forms.PictureBox()
        Me.txt_Punkte = New System.Windows.Forms.TextBox()
        Me.txt_Gewürfelt = New System.Windows.Forms.TextBox()
        Me.lbl_Punkte = New System.Windows.Forms.Label()
        Me.lbl_Gewürfelt = New System.Windows.Forms.Label()
        Me.cmd_End = New System.Windows.Forms.Button()
        Me.cmd_Neu = New System.Windows.Forms.Button()
        Me.cmd_Würfeln = New System.Windows.Forms.Button()
        Me.lbl_Zähler = New System.Windows.Forms.Label()
        Me.txt_Würfe = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_6
        '
        Me.pb_6.Image = CType(resources.GetObject("pb_6.Image"), System.Drawing.Image)
        Me.pb_6.Location = New System.Drawing.Point(533, 253)
        Me.pb_6.Name = "pb_6"
        Me.pb_6.Size = New System.Drawing.Size(92, 92)
        Me.pb_6.TabIndex = 25
        Me.pb_6.TabStop = False
        Me.pb_6.Visible = False
        '
        'pb_5
        '
        Me.pb_5.Image = CType(resources.GetObject("pb_5.Image"), System.Drawing.Image)
        Me.pb_5.Location = New System.Drawing.Point(427, 253)
        Me.pb_5.Name = "pb_5"
        Me.pb_5.Size = New System.Drawing.Size(92, 92)
        Me.pb_5.TabIndex = 24
        Me.pb_5.TabStop = False
        Me.pb_5.Visible = False
        '
        'pb_4
        '
        Me.pb_4.Image = CType(resources.GetObject("pb_4.Image"), System.Drawing.Image)
        Me.pb_4.Location = New System.Drawing.Point(321, 253)
        Me.pb_4.Name = "pb_4"
        Me.pb_4.Size = New System.Drawing.Size(92, 92)
        Me.pb_4.TabIndex = 23
        Me.pb_4.TabStop = False
        Me.pb_4.Visible = False
        '
        'pb_3
        '
        Me.pb_3.Image = CType(resources.GetObject("pb_3.Image"), System.Drawing.Image)
        Me.pb_3.Location = New System.Drawing.Point(215, 252)
        Me.pb_3.Name = "pb_3"
        Me.pb_3.Size = New System.Drawing.Size(92, 92)
        Me.pb_3.TabIndex = 22
        Me.pb_3.TabStop = False
        Me.pb_3.Visible = False
        '
        'pb_2
        '
        Me.pb_2.Image = CType(resources.GetObject("pb_2.Image"), System.Drawing.Image)
        Me.pb_2.Location = New System.Drawing.Point(109, 253)
        Me.pb_2.Name = "pb_2"
        Me.pb_2.Size = New System.Drawing.Size(92, 92)
        Me.pb_2.TabIndex = 21
        Me.pb_2.TabStop = False
        Me.pb_2.Visible = False
        '
        'pb_1
        '
        Me.pb_1.Image = CType(resources.GetObject("pb_1.Image"), System.Drawing.Image)
        Me.pb_1.Location = New System.Drawing.Point(3, 252)
        Me.pb_1.Name = "pb_1"
        Me.pb_1.Size = New System.Drawing.Size(92, 92)
        Me.pb_1.TabIndex = 20
        Me.pb_1.TabStop = False
        Me.pb_1.Visible = False
        '
        'txt_Punkte
        '
        Me.txt_Punkte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Punkte.Location = New System.Drawing.Point(100, 40)
        Me.txt_Punkte.Name = "txt_Punkte"
        Me.txt_Punkte.Size = New System.Drawing.Size(100, 22)
        Me.txt_Punkte.TabIndex = 19
        '
        'txt_Gewürfelt
        '
        Me.txt_Gewürfelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Gewürfelt.Location = New System.Drawing.Point(100, 12)
        Me.txt_Gewürfelt.Name = "txt_Gewürfelt"
        Me.txt_Gewürfelt.Size = New System.Drawing.Size(422, 22)
        Me.txt_Gewürfelt.TabIndex = 18
        '
        'lbl_Punkte
        '
        Me.lbl_Punkte.AutoSize = True
        Me.lbl_Punkte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Punkte.Location = New System.Drawing.Point(18, 44)
        Me.lbl_Punkte.Name = "lbl_Punkte"
        Me.lbl_Punkte.Size = New System.Drawing.Size(49, 16)
        Me.lbl_Punkte.TabIndex = 17
        Me.lbl_Punkte.Text = "Punkte"
        '
        'lbl_Gewürfelt
        '
        Me.lbl_Gewürfelt.AutoSize = True
        Me.lbl_Gewürfelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gewürfelt.Location = New System.Drawing.Point(18, 15)
        Me.lbl_Gewürfelt.Name = "lbl_Gewürfelt"
        Me.lbl_Gewürfelt.Size = New System.Drawing.Size(63, 16)
        Me.lbl_Gewürfelt.TabIndex = 16
        Me.lbl_Gewürfelt.Text = "Gewürfelt"
        '
        'cmd_End
        '
        Me.cmd_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_End.Location = New System.Drawing.Point(447, 172)
        Me.cmd_End.Name = "cmd_End"
        Me.cmd_End.Size = New System.Drawing.Size(75, 23)
        Me.cmd_End.TabIndex = 15
        Me.cmd_End.Text = "Beenden"
        Me.cmd_End.UseVisualStyleBackColor = True
        '
        'cmd_Neu
        '
        Me.cmd_Neu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Neu.Location = New System.Drawing.Point(447, 143)
        Me.cmd_Neu.Name = "cmd_Neu"
        Me.cmd_Neu.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Neu.TabIndex = 14
        Me.cmd_Neu.Text = "Neu"
        Me.cmd_Neu.UseVisualStyleBackColor = True
        '
        'cmd_Würfeln
        '
        Me.cmd_Würfeln.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Würfeln.Location = New System.Drawing.Point(447, 114)
        Me.cmd_Würfeln.Name = "cmd_Würfeln"
        Me.cmd_Würfeln.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Würfeln.TabIndex = 13
        Me.cmd_Würfeln.Text = "Würfeln"
        Me.cmd_Würfeln.UseVisualStyleBackColor = True
        '
        'lbl_Zähler
        '
        Me.lbl_Zähler.AutoSize = True
        Me.lbl_Zähler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Zähler.Location = New System.Drawing.Point(18, 71)
        Me.lbl_Zähler.Name = "lbl_Zähler"
        Me.lbl_Zähler.Size = New System.Drawing.Size(43, 16)
        Me.lbl_Zähler.TabIndex = 26
        Me.lbl_Zähler.Text = "Würfe"
        '
        'txt_Würfe
        '
        Me.txt_Würfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Würfe.Location = New System.Drawing.Point(100, 68)
        Me.txt_Würfe.Name = "txt_Würfe"
        Me.txt_Würfe.Size = New System.Drawing.Size(100, 22)
        Me.txt_Würfe.TabIndex = 27
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Würfel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 417)
        Me.Controls.Add(Me.txt_Würfe)
        Me.Controls.Add(Me.lbl_Zähler)
        Me.Controls.Add(Me.pb_6)
        Me.Controls.Add(Me.pb_5)
        Me.Controls.Add(Me.pb_4)
        Me.Controls.Add(Me.pb_3)
        Me.Controls.Add(Me.pb_2)
        Me.Controls.Add(Me.pb_1)
        Me.Controls.Add(Me.txt_Punkte)
        Me.Controls.Add(Me.txt_Gewürfelt)
        Me.Controls.Add(Me.lbl_Punkte)
        Me.Controls.Add(Me.lbl_Gewürfelt)
        Me.Controls.Add(Me.cmd_End)
        Me.Controls.Add(Me.cmd_Neu)
        Me.Controls.Add(Me.cmd_Würfeln)
        Me.Name = "Würfel"
        Me.Text = "Würfel"
        CType(Me.pb_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_6 As System.Windows.Forms.PictureBox
    Friend WithEvents pb_5 As System.Windows.Forms.PictureBox
    Friend WithEvents pb_4 As System.Windows.Forms.PictureBox
    Friend WithEvents pb_3 As System.Windows.Forms.PictureBox
    Friend WithEvents pb_2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb_1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_Punkte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gewürfelt As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Punkte As System.Windows.Forms.Label
    Friend WithEvents lbl_Gewürfelt As System.Windows.Forms.Label
    Friend WithEvents cmd_End As System.Windows.Forms.Button
    Friend WithEvents cmd_Neu As System.Windows.Forms.Button
    Friend WithEvents cmd_Würfeln As System.Windows.Forms.Button
    Friend WithEvents lbl_Zähler As System.Windows.Forms.Label
    Friend WithEvents txt_Würfe As System.Windows.Forms.TextBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
End Class
