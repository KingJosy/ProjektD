Public Class Programm_Sammlung

    Private Sub Programm_Sammlung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_End_Click(sender As Object, e As EventArgs) Handles cmd_End.Click
        End
    End Sub

    Private Sub cmd_sonne_mond_Click(sender As Object, e As EventArgs) Handles cmd_sonne_mond.Click
        Me.Hide()
        Sonne_Mond.Show()
    End Sub

    Private Sub cmd_BMI_Click(sender As Object, e As EventArgs) Handles cmd_BMI.Click
        Me.Hide()
        BMI_Rechner.Show()
    End Sub

    Private Sub cmd_Zahlenraten_Click(sender As Object, e As EventArgs) Handles cmd_Zahlenraten.Click
        Me.Hide()
        Zahlenraten.Show()
    End Sub

    Private Sub cmd_zinsrechner_Click(sender As Object, e As EventArgs) Handles cmd_zinsrechner.Click
        Me.Hide()
        Zinsrechner.Show()
    End Sub

    Private Sub cmd_rechner_Click(sender As Object, e As EventArgs) Handles cmd_rechner.Click
        Me.Hide()
        Rechner.Show()
    End Sub

    Private Sub cmd_Mensch_Click(sender As Object, e As EventArgs) Handles cmd_Mensch.Click
        Me.Hide()
        Mensch_ärgere_dich_nicht.Show()
    End Sub

    Private Sub cmd_ÖhmischerRechner_Click(sender As Object, e As EventArgs) Handles cmd_ÖhmischerRechner.Click
        Me.Hide()
        ÖhmischerRechner.Show()
    End Sub
End Class