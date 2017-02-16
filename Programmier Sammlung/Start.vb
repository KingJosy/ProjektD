Public Class Start

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_ProgrammSammlung_Click(sender As Object, e As EventArgs) Handles cmd_ProgrammSammlung.Click
        Programm_Sammlung.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Jones_Click(sender As Object, e As EventArgs) Handles cmd_Jones.Click
        Jones.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Julian_Click(sender As Object, e As EventArgs) Handles cmd_Julian.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class