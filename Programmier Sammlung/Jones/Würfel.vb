Public Class Würfel
    Dim Wurf As Integer
    Dim Zähler As Integer
    Dim Punkte As Integer

    Private Sub Würfel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_Würfeln_Click(sender As Object, e As EventArgs) Handles cmd_Würfeln.Click
        Timer.Start()
    End Sub

    Private Sub cmd_Neu_Click(sender As Object, e As EventArgs) Handles cmd_Neu.Click

    End Sub

    Private Sub cmd_End_Click(sender As Object, e As EventArgs) Handles cmd_End.Click
        Jones.Show()
        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Zähler = 0
        Punkte = 0

        txt_Punkte.Clear()
        txt_Würfe.Clear()

        txt_Gewürfelt.Text = Wurf
        txt_Würfe.Text = Zähler
        txt_Punkte.Text = Punkte

        Do
            Wurf = Int(6 * Rnd() + 1)
            txt_Gewürfelt.Text = txt_Gewürfelt.Text & " " & Wurf
            Punkte = Punkte + Wurf
            Zähler = Zähler + 1

            If Wurf = 1 Then
                pb_1.Show()
                pb_2.Hide()
                pb_3.Hide()
                pb_4.Hide()
                pb_5.Hide()
                pb_6.Hide()
            End If

            If Wurf = 2 Then
                pb_1.Hide()
                pb_2.Show()
                pb_3.Hide()
                pb_4.Hide()
                pb_5.Hide()
                pb_6.Hide()
            End If

            If Wurf = 3 Then
                pb_1.Hide()
                pb_2.Hide()
                pb_3.Show()
                pb_4.Hide()
                pb_5.Hide()
                pb_6.Hide()
            End If

            If Wurf = 4 Then
                pb_1.Hide()
                pb_2.Hide()
                pb_3.Hide()
                pb_4.Show()
                pb_5.Hide()
                pb_6.Hide()
            End If

            If Wurf = 5 Then
                pb_1.Hide()
                pb_2.Hide()
                pb_3.Hide()
                pb_4.Hide()
                pb_5.Show()
                pb_6.Hide()
            End If

            If Wurf = 6 Then
                pb_1.Hide()
                pb_2.Hide()
                pb_3.Hide()
                pb_4.Hide()
                pb_5.Hide()
                pb_6.Show()
            End If

        Loop Until Wurf = 6

    End Sub
End Class