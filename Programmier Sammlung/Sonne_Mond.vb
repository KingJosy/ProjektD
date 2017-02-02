Public Class Sonne_Mond

    Private Sub cmd_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        Sammlung.Show()
        Me.Close()

    End Sub

    Private Sub cmd_sun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sun.Click
        pb_Sun.Visible = True
        pb_moon.Visible = False
    End Sub

    Private Sub cmd_moon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_moon.Click
        pb_moon.Visible = True
        pb_Sun.Visible = False
    End Sub

    Private Sub Sonne_Mond_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pb_moon.Visible = False
        pb_Sun.Visible = False

    End Sub
End Class