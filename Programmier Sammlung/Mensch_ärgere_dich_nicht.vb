Public Class Mensch_ärgere_dich_nicht

    Private Sub cmd_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        Sammlung.Show()
        Me.Close()
    End Sub

    Private Sub Mensch_ärgere_dich_nicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb_gamepad.Click

    End Sub

    Private Sub cmd_walk_Click(sender As Object, e As EventArgs) Handles cmd_walk.Click

        'Die einzelnen Positionen Deklarieren

        'Startpunkte der einzelnen Farben
        Dim S1R As New Point(763, 30)
        Dim S2B As New Point(939, 335)
        Dim S3G As New Point(675, 509)  'G = Gelb
        Dim S4G As New Point(498, 246)  'G = Grün



        Dim RB1 As New Point(939, 27)   'Punkte der Roten Base
        Dim RB2 As New Point(983, 27)
        Dim RB3 As New Point(939, 71)
        Dim RB4 As New Point(983, 71)

        Dim BB1 As New Point(939, 510)  'Punkte der Blauen Base
        Dim BB2 As New Point(983, 510)
        Dim BB3 As New Point(939, 554)
        Dim BB4 As New Point(983, 554)

        Dim YB1 As New Point(454, 510)  'Punkte der Gelben Base
        Dim YB2 As New Point(498, 510)
        Dim YB3 As New Point(454, 554)
        Dim YB4 As New Point(498, 554)

        Dim GB1 As New Point(454, 27)   'Punkte der Grünen Base
        Dim GB2 As New Point(498, 27)
        Dim GB3 As New Point(454, 71)
        Dim GB4 As New Point(498, 71)

        'Ziele der Farben
        Dim RZ1 As New Point(719, 114)
        Dim RZ2 As New Point(719, 158)
        Dim RZ3 As New Point(719, 203)
        Dim RZ4 As New Point(719, 245)

        Dim BZ1 As New Point(895, 291)
        Dim BZ2 As New Point(851, 291)
        Dim BZ3 As New Point(807, 291)
        Dim BZ4 As New Point(763, 291)

        Dim YZ1 As New Point(720, 466)
        Dim YZ2 As New Point(720, 422)
        Dim YZ3 As New Point(720, 378)
        Dim YZ4 As New Point(720, 335)

        Dim GZ1 As New Point(543, 292)
        Dim GZ2 As New Point(587, 292)
        Dim GZ3 As New Point(631, 292)
        Dim GZ4 As New Point(675, 292)

        'Spielfelder deklarieren

        Dim F1 As New Point(763, 114)
        Dim F2 As New Point(763, 158)
        Dim F3 As New Point(763, 202)
        Dim F4 As New Point(763, 246)
        Dim F5 As New Point(807, 246)
        Dim F6 As New Point(851, 246)
        Dim F7 As New Point(895, 246)
        Dim F8 As New Point(939, 246)
        Dim F9 As New Point(939, 292)
        Dim F10 As New Point(939, 335)
        Dim F11 As New Point(895, 335)
        Dim F12 As New Point(851, 335)
        Dim F13 As New Point(807, 335)
        Dim F14 As New Point(763, 335)
        Dim F15 As New Point(763, 378)
        Dim F16 As New Point(763, 421)
        Dim F17 As New Point(763, 465)
        Dim F18 As New Point(763, 510)
        Dim F19 As New Point(719, 510)
        Dim F20 As New Point(674, 510)
        Dim F21 As New Point(674, 466)
        Dim F22 As New Point(674, 422)
        Dim F23 As New Point(674, 378)
        Dim F24 As New Point(674, 336)
        Dim F25 As New Point(631, 336)
        Dim F26 As New Point(586, 336)
        Dim F27 As New Point(542, 336)
        Dim F28 As New Point(498, 336)
        Dim F29 As New Point(498, 291)
        Dim F30 As New Point(498, 246)  'Grüner Startpunkt
        Dim F31 As New Point(542, 246)
        Dim F32 As New Point(586, 246)
        Dim F33 As New Point(631, 246)
        Dim F34 As New Point(675, 246)
        Dim F35 As New Point(675, 202)
        Dim F36 As New Point(675, 158)
        Dim F37 As New Point(675, 114)
        Dim F38 As New Point(675, 70)
        Dim F39 As New Point(720, 70)
        Dim F40 As New Point(763, 70) ' Roter Startpunkt




    End Sub
End Class