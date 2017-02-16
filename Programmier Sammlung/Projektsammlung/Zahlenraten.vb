Public Class Zahlenraten
    Dim Eingabe As Integer
    Dim Gesucht As Integer
    Dim Zahl As Integer
    Dim Zähler As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Zahl = Int((100 - 0 + 1) * Rnd() + 0)
        lbl_Zähler.Text = Zähler
        Zähler = 0
        cmd_Neu.Visible = False
        'Label1.Text = Zahl
    End Sub

    Private Sub cmd_prüfen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_prüfen.Click
        Eingabe = txt_Eingabe.Text
        lbl_Überprüfung.Text = ""
        Zähler = Zähler + 1
        lbl_Zähler.Text = Zähler

        Select Case Eingabe
            Case Is < Zahl
                lbl_Überprüfung.Text = "Zahl ist zu Klein"
            Case Is > Zahl
                lbl_Überprüfung.Text = "Zahl ist zu Groß"
            Case Is = Zahl
                lbl_Überprüfung.Text = "Sie haben Gewonnen"
                cmd_Neu.Visible = True
                cmd_prüfen.Visible = False
        End Select
    End Sub

    Private Sub cmd_Neu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Neu.Click
        Zähler = 0
        lbl_Zähler.Text = ""
        lbl_Überprüfung.Text = ""
        cmd_Neu.Visible = False
        cmd_prüfen.Visible = True

        Randomize()
        Zahl = Int((100 - 0 + 1) * Rnd() + 0)
        lbl_Zähler.Text = Zähler
        Zähler = 0
        'Label1.Text = Zahl

    End Sub

    Private Sub cmd_Ende_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Ende.Click
        Programm_Sammlung.Show()
        Me.Close()
    End Sub
End Class