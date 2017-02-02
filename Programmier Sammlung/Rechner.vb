Public Class Rechner

    Private Sub Rechner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_Eingabe.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_Eingabe.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_Eingabe.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_Eingabe.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt_Eingabe.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_Eingabe.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt_Eingabe.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt_Eingabe.Text += "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        txt_Eingabe.Text += "0"
    End Sub

    Private Sub Komma_Click(sender As Object, e As EventArgs) Handles Komma.Click
        txt_Eingabe.Text += ","
    End Sub

    Private Sub cmd_Plus_Click(sender As Object, e As EventArgs) Handles cmd_Plus.Click
        txt_Eingabe.Text += "+"
    End Sub

    Private Sub cmd_Minus_Click(sender As Object, e As EventArgs) Handles cmd_Minus.Click
        txt_Eingabe.Text += "-"
    End Sub

    Private Sub cmd_Teilen_Click(sender As Object, e As EventArgs) Handles cmd_Teilen.Click
        txt_Eingabe.Text += "/"
    End Sub

    Private Sub cmd_Mal_Click(sender As Object, e As EventArgs) Handles cmd_Mal.Click
        txt_Eingabe.Text += "*"
    End Sub
End Class