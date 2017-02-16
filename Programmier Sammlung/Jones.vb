Public Class Jones

    Private Sub cmd_Würfel_Click(sender As Object, e As EventArgs) Handles cmd_Würfel.Click
        Würfel.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Hauptmenü_Click(sender As Object, e As EventArgs) Handles cmd_Hauptmenü.Click
        Start.Show()
        Me.Close()
    End Sub
End Class