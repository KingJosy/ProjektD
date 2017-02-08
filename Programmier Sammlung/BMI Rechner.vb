Public Class BMI_Rechner
    Dim Eingabe1 As Single
    Dim Eingabe2 As Single
    Dim Ergebnis As Integer
    Dim Ergebnis2 As Single

    Private Sub BMI_Rechner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Ergebnis.ReadOnly = True
        txt_Klass.ReadOnly = True

        Label3.Visible = False
        Label4.Visible = False
        txt_Ergebnis.Visible = False
        txt_Klass.Visible = False
    End Sub

    Private Sub cmd_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_End.Click
        Programm_Sammlung.Show()
        Me.Close()
    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_Eingabe1.Clear()
        txt_Eingabe2.Clear()
        txt_Ergebnis.Clear()
        txt_Klass.Clear()
        chk_M.Visible = True
        chk_W.Visible = True
        chk_M.Checked = False
        chk_W.Checked = False

        Label3.Visible = False
        Label4.Visible = False
        txt_Ergebnis.Visible = False
        txt_Klass.Visible = False
    End Sub

    Private Sub cmd_Berechnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Berechnen.Click
        Eingabe1 = txt_Eingabe1.Text()
        Eingabe2 = txt_Eingabe2.Text
        Ergebnis = Eingabe1 / ((Eingabe2 / 100) * (Eingabe2 / 100))
        txt_Ergebnis.Text = Ergebnis

        If chk_M.Checked = True Then

            chk_W.Visible = False
            Select Case Ergebnis

                Case 0 To 19
                    txt_Klass.Text = "Untergewicht"

                Case 20 To 24
                    txt_Klass.Text = "Normalgewicht"

                Case 25 To 29
                    txt_Klass.Text = "Übergewicht"

                Case 30 To 39
                    txt_Klass.Text = "Adipositas"

                Case 40 To 100
                    txt_Klass.Text = "massive Adipositas"
            End Select

        Else

            chk_M.Visible = False
            Select Case Ergebnis

                Case 0 To 18
                    txt_Klass.Text = "Untergewicht"

                Case 19 To 23
                    txt_Klass.Text = "Normalgewicht"

                Case 24 To 29
                    txt_Klass.Text = "Übergewicht"

                Case 30 To 39
                    txt_Klass.Text = "Adipositas"

                Case 40 To 100
                    txt_Klass.Text = "massive Adipositas"
            End Select

        End If
        Label3.Visible = True
        Label4.Visible = True
        txt_Ergebnis.Visible = True
        txt_Klass.Visible = True
    End Sub
End Class