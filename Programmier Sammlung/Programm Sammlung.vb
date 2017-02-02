Public Class Sammlung

    Private Sub cmd_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_End.Click
        End
    End Sub

    Private Sub cmd_Sonne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Sonne.Click
        Me.Hide()
        Sonne_Mond.Show()
    End Sub

    Private Sub cmd_BMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BMI.Click
        Me.Hide()
        BMI_Rechner.Show()
    End Sub

    Private Sub cmd_Zinsrechner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Zinsrechner.Click
        Me.Hide()
        Zinsrechner.Show()
    End Sub

    Private Sub cmd_game1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_game1.Click
        Me.Hide()
        Mensch_ärgere_dich_nicht.Show()
    End Sub

<<<<<<< Updated upstream
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

=======
    Private Sub cmd_Zahlenraten_Click(sender As Object, e As EventArgs) Handles cmd_Zahlenraten.Click
        Me.Hide()
        Zahlenraten.Show()
    End Sub

    Private Sub cmd_Taschenrechner_Click(sender As Object, e As EventArgs) Handles cmd_Taschenrechner.Click
        Me.Hide()
        Rechner.Show()
>>>>>>> Stashed changes
    End Sub
End Class
