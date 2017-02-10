Public Class Mensch_ärgere_dich_nicht
    Dim LäuferRot1 As Integer
    Dim LäuferRot2 As Integer
    Dim LäuferRot3 As Integer
    Dim LäuferRot4 As Integer
    Dim LäuferBlau1 As Integer
    Dim LäuferBlau2 As Integer
    Dim LäuferBlau3 As Integer
    Dim LäuferBlau4 As Integer
    Dim LäuferGelb1 As Integer
    Dim LäuferGelb2 As Integer
    Dim LäuferGelb3 As Integer
    Dim LäuferGelb4 As Integer
    Dim LäuferGrün1 As Integer
    Dim LäuferGrün2 As Integer
    Dim LäuferGrün3 As Integer
    Dim LäuferGrün4 As Integer
    Dim Würfelanzahl As Integer

    Private Sub cmd_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        Programm_Sammlung.Show()
        Me.Close()
    End Sub

    Private Sub Mensch_ärgere_dich_nicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'MsgBox("Mensch ärgere dich nicht!

        'Ziel des Spiels

        'Ziel des Spiels besteht darin, alle 4 Figuren als Erster ins Zielfeld zu bringen.

        'Rot Beginnt danach kommt Blau dann Gelb dann Grün.

        '")

        cmd_walk.Visible = False
        cmd_würfel.Visible = False
        lbl_würfel.Visible = False
        gb_spielfiguren.Visible = False
        cmd_restart.Visible = False

        rb_blau1.Visible = False
        rb_blau2.Visible = False
        rb_blau3.Visible = False
        rb_blau4.Visible = False
        rb_rot1.Visible = False
        rb_rot2.Visible = False
        rb_rot3.Visible = False
        rb_rot4.Visible = False
        rb_gelb1.Visible = False
        rb_gelb2.Visible = False
        rb_gelb3.Visible = False
        rb_gelb4.Visible = False
        rb_grün1.Visible = False
        rb_grün2.Visible = False
        rb_grün3.Visible = False
        rb_grün4.Visible = False


        rb_blau1.Visible = False
        rb_blau2.Visible = False
        rb_blau3.Visible = False
        rb_blau4.Visible = False
        rb_rot1.Visible = False
        rb_rot2.Visible = False
        rb_rot3.Visible = False
        rb_rot4.Visible = False
        rb_gelb1.Visible = False
        rb_gelb2.Visible = False
        rb_gelb3.Visible = False
        rb_gelb4.Visible = False
        rb_grün1.Visible = False
        rb_grün2.Visible = False
        rb_grün3.Visible = False
        rb_grün4.Visible = False

        pb_rot1.Visible = False
        pb_rot2.Visible = False
        pb_rot3.Visible = False
        pb_rot4.Visible = False

        pb_blau1.Visible = False
        pb_blau2.Visible = False
        pb_blau3.Visible = False
        pb_blau4.Visible = False

        pb_gelb1.Visible = False
        pb_gelb2.Visible = False
        pb_gelb3.Visible = False
        pb_gelb4.Visible = False

        pb_grün1.Visible = False
        pb_grün2.Visible = False
        pb_grün3.Visible = False
        pb_grün4.Visible = False

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
        Dim F10 As New Point(939, 335)  'blauer Startpunkt
        Dim F11 As New Point(895, 335)
        Dim F12 As New Point(851, 335)
        Dim F13 As New Point(807, 335)
        Dim F14 As New Point(763, 335)
        Dim F15 As New Point(763, 378)
        Dim F16 As New Point(763, 421)
        Dim F17 As New Point(763, 465)
        Dim F18 As New Point(763, 510)
        Dim F19 As New Point(719, 510)
        Dim F20 As New Point(674, 510)  'Gelber Startpunkt
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



        'Anzahl der Läufe der einzelnen Spielfiguren

        Würfelanzahl = lbl_würfel.Text

        If rb_rot1.Checked = True Then

            LäuferRot1 = LäuferRot1 + Würfelanzahl

        ElseIf rb_rot2.Checked = True Then

            LäuferRot2 = LäuferRot2 + Würfelanzahl

        ElseIf rb_rot3.Checked = True Then

            LäuferRot3 = LäuferRot3 + Würfelanzahl

        ElseIf rb_rot4.Checked = True Then

            LäuferRot4 = LäuferRot4 + Würfelanzahl

        ElseIf rb_blau1.Checked = True Then

            LäuferBlau1 = LäuferBlau1 + Würfelanzahl

        ElseIf rb_blau2.Checked = True Then

            LäuferBlau1 = LäuferBlau1 + Würfelanzahl

        ElseIf rb_blau3.Checked = True Then

            LäuferBlau3 = LäuferBlau3 + Würfelanzahl

        ElseIf rb_blau4.Checked = True Then

            LäuferBlau4 = LäuferBlau4 + Würfelanzahl

        ElseIf rb_gelb1.Checked = True Then

            LäuferGelb1 = LäuferGelb1 + Würfelanzahl

        ElseIf rb_gelb2.Checked = True Then

            LäuferGelb2 = LäuferGelb2 + Würfelanzahl

        ElseIf rb_gelb3.Checked = True Then

            LäuferGelb3 = LäuferGelb3 + Würfelanzahl

        ElseIf rb_gelb4.Checked = True Then

            LäuferGelb4 = LäuferGelb4 + Würfelanzahl

        ElseIf rb_grün1.Checked = True Then

            LäuferGrün1 = LäuferGrün1 + Würfelanzahl

        ElseIf rb_grün2.Checked = True Then

            LäuferGrün2 = LäuferGrün2 + Würfelanzahl

        ElseIf rb_grün3.Checked = True Then

            LäuferGrün3 = LäuferGrün3 + Würfelanzahl

        ElseIf rb_grün4.Checked = True Then

            LäuferGrün4 = LäuferGrün4 + Würfelanzahl

        End If


        'Abfrage auf Welchem Feld sich die Figur Befinden Sollte

        'ROT

        If LäuferRot1 = 1 Then
            pb_rot1.Location = F40
        ElseIf LäuferRot1 = 2 Then
            pb_rot1.Location = F1
        ElseIf LäuferRot1 = 3 Then
            pb_rot1.Location = F2
        ElseIf LäuferRot1 = 4 Then
            pb_rot1.Location = F3
        ElseIf LäuferRot1 = 5 Then
            pb_rot1.Location = F4
        ElseIf LäuferRot1 = 6 Then
            pb_rot1.Location = F5
        ElseIf LäuferRot1 = 7 Then
            pb_rot1.Location = F6
        ElseIf LäuferRot1 = 8 Then
            pb_rot1.Location = F7
        ElseIf LäuferRot1 = 9 Then
            pb_rot1.Location = F8
        ElseIf LäuferRot1 = 10 Then
            pb_rot1.Location = F9
        ElseIf LäuferRot1 = 11 Then
            pb_rot1.Location = F10
        ElseIf LäuferRot1 = 12 Then
            pb_rot1.Location = F11
        ElseIf LäuferRot1 = 13 Then
            pb_rot1.Location = F12
        ElseIf LäuferRot1 = 14 Then
            pb_rot1.Location = F13
        ElseIf LäuferRot1 = 15 Then
            pb_rot1.Location = F14
        ElseIf LäuferRot1 = 16 Then
            pb_rot1.Location = F15
        ElseIf LäuferRot1 = 17 Then
            pb_rot1.Location = F16
        ElseIf LäuferRot1 = 18 Then
            pb_rot1.Location = F17
        ElseIf LäuferRot1 = 19 Then
            pb_rot1.Location = F18
        ElseIf LäuferRot1 = 20 Then
            pb_rot1.Location = F19
        ElseIf LäuferRot1 = 21 Then
            pb_rot1.Location = F20
        ElseIf LäuferRot1 = 22 Then
            pb_rot1.Location = F21
        ElseIf LäuferRot1 = 23 Then
            pb_rot1.Location = F22
        ElseIf LäuferRot1 = 24 Then
            pb_rot1.Location = F23
        ElseIf LäuferRot1 = 25 Then
            pb_rot1.Location = F24
        ElseIf LäuferRot1 = 26 Then
            pb_rot1.Location = F25
        ElseIf LäuferRot1 = 27 Then
            pb_rot1.Location = F26
        ElseIf LäuferRot1 = 28 Then
            pb_rot1.Location = F27
        ElseIf LäuferRot1 = 29 Then
            pb_rot1.Location = F28
        ElseIf LäuferRot1 = 30 Then
            pb_rot1.Location = F29
        ElseIf LäuferRot1 = 31 Then
            pb_rot1.Location = F30
        ElseIf LäuferRot1 = 32 Then
            pb_rot1.Location = F31
        ElseIf LäuferRot1 = 33 Then
            pb_rot1.Location = F32
        ElseIf LäuferRot1 = 34 Then
            pb_rot1.Location = F33
        ElseIf LäuferRot1 = 35 Then
            pb_rot1.Location = F34
        ElseIf LäuferRot1 = 36 Then
            pb_rot1.Location = F35
        ElseIf LäuferRot1 = 37 Then
            pb_rot1.Location = F36
        ElseIf LäuferRot1 = 38 Then
            pb_rot1.Location = F37
        ElseIf LäuferRot1 = 39 Then
            pb_rot1.Location = F38
        ElseIf LäuferRot1 = 40 Then
            pb_rot1.Location = F39
            'Jetzt kommt die Base
        ElseIf LäuferRot1 = 41 Then
            pb_rot1.Location = RZ1
            rb_rot1.Enabled = False
        ElseIf LäuferRot1 = 42 Then
            pb_rot1.Location = RZ2
            rb_rot1.Enabled = False
        ElseIf LäuferRot1 = 43 Then
            pb_rot1.Location = RZ3
            rb_rot1.Enabled = False
        ElseIf LäuferRot1 = 44 Then
            pb_rot1.Location = RZ4
            rb_rot1.Enabled = False
            Return
        End If

        If LäuferRot2 = 1 Then
            pb_rot2.Location = F40
        ElseIf LäuferRot2 = 2 Then
            pb_rot2.Location = F1
        ElseIf LäuferRot2 = 3 Then
            pb_rot2.Location = F2
        ElseIf LäuferRot2 = 4 Then
            pb_rot2.Location = F3
        ElseIf LäuferRot2 = 5 Then
            pb_rot2.Location = F4
        ElseIf LäuferRot2 = 6 Then
            pb_rot2.Location = F5
        ElseIf LäuferRot2 = 7 Then
            pb_rot2.Location = F6
        ElseIf LäuferRot2 = 8 Then
            pb_rot2.Location = F7
        ElseIf LäuferRot2 = 9 Then
            pb_rot2.Location = F8
        ElseIf LäuferRot2 = 10 Then
            pb_rot2.Location = F9
        ElseIf LäuferRot2 = 11 Then
            pb_rot2.Location = F10
        ElseIf LäuferRot2 = 12 Then
            pb_rot2.Location = F11
        ElseIf LäuferRot2 = 13 Then
            pb_rot2.Location = F12
        ElseIf LäuferRot2 = 14 Then
            pb_rot2.Location = F13
        ElseIf LäuferRot2 = 15 Then
            pb_rot2.Location = F14
        ElseIf LäuferRot2 = 16 Then
            pb_rot2.Location = F15
        ElseIf LäuferRot2 = 17 Then
            pb_rot2.Location = F16
        ElseIf LäuferRot2 = 18 Then
            pb_rot2.Location = F17
        ElseIf LäuferRot2 = 19 Then
            pb_rot2.Location = F18
        ElseIf LäuferRot2 = 20 Then
            pb_rot2.Location = F19
        ElseIf LäuferRot2 = 21 Then
            pb_rot2.Location = F20
        ElseIf LäuferRot2 = 22 Then
            pb_rot2.Location = F21
        ElseIf LäuferRot2 = 23 Then
            pb_rot2.Location = F22
        ElseIf LäuferRot2 = 24 Then
            pb_rot2.Location = F23
        ElseIf LäuferRot2 = 25 Then
            pb_rot2.Location = F24
        ElseIf LäuferRot2 = 26 Then
            pb_rot2.Location = F25
        ElseIf LäuferRot2 = 27 Then
            pb_rot2.Location = F26
        ElseIf LäuferRot2 = 28 Then
            pb_rot2.Location = F27
        ElseIf LäuferRot2 = 29 Then
            pb_rot2.Location = F28
        ElseIf LäuferRot2 = 30 Then
            pb_rot2.Location = F29
        ElseIf LäuferRot2 = 31 Then
            pb_rot2.Location = F30
        ElseIf LäuferRot2 = 32 Then
            pb_rot2.Location = F31
        ElseIf LäuferRot2 = 33 Then
            pb_rot2.Location = F32
        ElseIf LäuferRot2 = 34 Then
            pb_rot2.Location = F33
        ElseIf LäuferRot2 = 35 Then
            pb_rot2.Location = F34
        ElseIf LäuferRot2 = 36 Then
            pb_rot2.Location = F35
        ElseIf LäuferRot2 = 37 Then
            pb_rot2.Location = F36
        ElseIf LäuferRot2 = 38 Then
            pb_rot2.Location = F37
        ElseIf LäuferRot2 = 39 Then
            pb_rot2.Location = F38
        ElseIf LäuferRot2 = 40 Then
            pb_rot2.Location = F39
            'Jetzt kommt die Base
        ElseIf LäuferRot2 = 41 Then
            pb_rot2.Location = RZ1
            rb_rot2.Enabled = False
        ElseIf LäuferRot2 = 42 Then
            pb_rot2.Location = RZ2
            rb_rot2.Enabled = False
        ElseIf LäuferRot2 = 43 Then
            pb_rot2.Location = RZ3
            rb_rot2.Enabled = False
        ElseIf LäuferRot2 = 44 Then
            pb_rot2.Location = RZ4
            rb_rot2.Enabled = False
            Return
        End If

        If LäuferRot3 = 1 Then
            pb_rot3.Location = F40
        ElseIf LäuferRot3 = 2 Then
            pb_rot3.Location = F1
        ElseIf LäuferRot3 = 3 Then
            pb_rot3.Location = F2
        ElseIf LäuferRot3 = 4 Then
            pb_rot3.Location = F3
        ElseIf LäuferRot3 = 5 Then
            pb_rot3.Location = F4
        ElseIf LäuferRot3 = 6 Then
            pb_rot3.Location = F5
        ElseIf LäuferRot3 = 7 Then
            pb_rot3.Location = F6
        ElseIf LäuferRot3 = 8 Then
            pb_rot3.Location = F7
        ElseIf LäuferRot3 = 9 Then
            pb_rot3.Location = F8
        ElseIf LäuferRot3 = 10 Then
            pb_rot3.Location = F9
        ElseIf LäuferRot3 = 11 Then
            pb_rot3.Location = F10
        ElseIf LäuferRot3 = 12 Then
            pb_rot3.Location = F11
        ElseIf LäuferRot3 = 13 Then
            pb_rot3.Location = F12
        ElseIf LäuferRot3 = 14 Then
            pb_rot3.Location = F13
        ElseIf LäuferRot3 = 15 Then
            pb_rot3.Location = F14
        ElseIf LäuferRot3 = 16 Then
            pb_rot3.Location = F15
        ElseIf LäuferRot3 = 17 Then
            pb_rot3.Location = F16
        ElseIf LäuferRot3 = 18 Then
            pb_rot3.Location = F17
        ElseIf LäuferRot3 = 19 Then
            pb_rot3.Location = F18
        ElseIf LäuferRot3 = 20 Then
            pb_rot3.Location = F19
        ElseIf LäuferRot3 = 21 Then
            pb_rot3.Location = F20
        ElseIf LäuferRot3 = 22 Then
            pb_rot3.Location = F21
        ElseIf LäuferRot3 = 23 Then
            pb_rot3.Location = F22
        ElseIf LäuferRot3 = 24 Then
            pb_rot3.Location = F23
        ElseIf LäuferRot3 = 25 Then
            pb_rot3.Location = F24
        ElseIf LäuferRot3 = 26 Then
            pb_rot3.Location = F25
        ElseIf LäuferRot3 = 27 Then
            pb_rot3.Location = F26
        ElseIf LäuferRot3 = 28 Then
            pb_rot3.Location = F27
        ElseIf LäuferRot3 = 29 Then
            pb_rot3.Location = F28
        ElseIf LäuferRot3 = 30 Then
            pb_rot3.Location = F29
        ElseIf LäuferRot3 = 31 Then
            pb_rot3.Location = F30
        ElseIf LäuferRot3 = 32 Then
            pb_rot3.Location = F31
        ElseIf LäuferRot3 = 33 Then
            pb_rot3.Location = F32
        ElseIf LäuferRot3 = 34 Then
            pb_rot3.Location = F33
        ElseIf LäuferRot3 = 35 Then
            pb_rot3.Location = F34
        ElseIf LäuferRot3 = 36 Then
            pb_rot3.Location = F35
        ElseIf LäuferRot3 = 37 Then
            pb_rot3.Location = F36
        ElseIf LäuferRot3 = 38 Then
            pb_rot3.Location = F37
        ElseIf LäuferRot3 = 39 Then
            pb_rot3.Location = F38
        ElseIf LäuferRot3 = 40 Then
            pb_rot3.Location = F39
            'Jetzt kommt die Base
        ElseIf LäuferRot3 = 41 Then
            pb_rot3.Location = RZ1
            rb_rot3.Enabled = False
        ElseIf LäuferRot3 = 42 Then
            pb_rot3.Location = RZ2
            rb_rot3.Enabled = False
        ElseIf LäuferRot3 = 43 Then
            pb_rot3.Location = RZ3
            rb_rot3.Enabled = False
        ElseIf LäuferRot3 = 44 Then
            pb_rot3.Location = RZ4
            rb_rot3.Enabled = False
            Return
        End If

        If LäuferRot4 = 1 Then
            pb_rot4.Location = F40
        ElseIf LäuferRot4 = 2 Then
            pb_rot4.Location = F1
        ElseIf LäuferRot4 = 3 Then
            pb_rot4.Location = F2
        ElseIf LäuferRot4 = 4 Then
            pb_rot4.Location = F3
        ElseIf LäuferRot4 = 5 Then
            pb_rot4.Location = F4
        ElseIf LäuferRot4 = 6 Then
            pb_rot4.Location = F5
        ElseIf LäuferRot4 = 7 Then
            pb_rot4.Location = F6
        ElseIf LäuferRot4 = 8 Then
            pb_rot4.Location = F7
        ElseIf LäuferRot4 = 9 Then
            pb_rot4.Location = F8
        ElseIf LäuferRot4 = 10 Then
            pb_rot4.Location = F9
        ElseIf LäuferRot4 = 11 Then
            pb_rot4.Location = F10
        ElseIf LäuferRot4 = 12 Then
            pb_rot4.Location = F11
        ElseIf LäuferRot4 = 13 Then
            pb_rot4.Location = F12
        ElseIf LäuferRot4 = 14 Then
            pb_rot4.Location = F13
        ElseIf LäuferRot4 = 15 Then
            pb_rot4.Location = F14
        ElseIf LäuferRot4 = 16 Then
            pb_rot4.Location = F15
        ElseIf LäuferRot4 = 17 Then
            pb_rot4.Location = F16
        ElseIf LäuferRot4 = 18 Then
            pb_rot4.Location = F17
        ElseIf LäuferRot4 = 19 Then
            pb_rot4.Location = F18
        ElseIf LäuferRot4 = 20 Then
            pb_rot4.Location = F19
        ElseIf LäuferRot4 = 21 Then
            pb_rot4.Location = F20
        ElseIf LäuferRot4 = 22 Then
            pb_rot4.Location = F21
        ElseIf LäuferRot4 = 23 Then
            pb_rot4.Location = F22
        ElseIf LäuferRot4 = 24 Then
            pb_rot4.Location = F23
        ElseIf LäuferRot4 = 25 Then
            pb_rot4.Location = F24
        ElseIf LäuferRot4 = 26 Then
            pb_rot4.Location = F25
        ElseIf LäuferRot4 = 27 Then
            pb_rot4.Location = F26
        ElseIf LäuferRot4 = 28 Then
            pb_rot4.Location = F27
        ElseIf LäuferRot4 = 29 Then
            pb_rot4.Location = F28
        ElseIf LäuferRot4 = 30 Then
            pb_rot4.Location = F29
        ElseIf LäuferRot4 = 31 Then
            pb_rot4.Location = F30
        ElseIf LäuferRot4 = 32 Then
            pb_rot4.Location = F31
        ElseIf LäuferRot4 = 33 Then
            pb_rot4.Location = F32
        ElseIf LäuferRot4 = 34 Then
            pb_rot4.Location = F33
        ElseIf LäuferRot4 = 35 Then
            pb_rot4.Location = F34
        ElseIf LäuferRot4 = 36 Then
            pb_rot4.Location = F35
        ElseIf LäuferRot4 = 37 Then
            pb_rot4.Location = F36
        ElseIf LäuferRot4 = 38 Then
            pb_rot4.Location = F37
        ElseIf LäuferRot4 = 39 Then
            pb_rot4.Location = F38
        ElseIf LäuferRot4 = 40 Then
            pb_rot4.Location = F39
            'Jetzt kommt die Base
        ElseIf LäuferRot3 = 41 Then
            pb_rot3.Location = RZ1
            rb_rot3.Enabled = False
        ElseIf LäuferRot3 = 42 Then
            pb_rot3.Location = RZ2
            rb_rot3.Enabled = False
        ElseIf LäuferRot3 = 43 Then
            pb_rot3.Location = RZ3
            rb_rot3.Enabled = False
        ElseIf LäuferRot3 = 44 Then
            pb_rot3.Location = RZ4
            rb_rot3.Enabled = False
            Return
        End If

        'BLAU

        If LäuferBlau1 = 1 Then
            pb_blau1.Location = F10
        ElseIf LäuferBlau1 = 2 Then
            pb_blau1.Location = F11
        ElseIf LäuferBlau1 = 3 Then
            pb_blau1.Location = F12
        ElseIf LäuferBlau1 = 4 Then
            pb_blau1.Location = F13
        ElseIf LäuferBlau1 = 5 Then
            pb_blau1.Location = F14
        ElseIf LäuferBlau1 = 6 Then
            pb_blau1.Location = F15
        ElseIf LäuferBlau1 = 7 Then
            pb_blau1.Location = F16
        ElseIf LäuferBlau1 = 8 Then
            pb_blau1.Location = F17
        ElseIf LäuferBlau1 = 9 Then
            pb_blau1.Location = F18
        ElseIf LäuferBlau1 = 10 Then
            pb_blau1.Location = F19
        ElseIf LäuferBlau1 = 11 Then
            pb_blau1.Location = F20
        ElseIf LäuferBlau1 = 12 Then
            pb_blau1.Location = F21
        ElseIf LäuferBlau1 = 13 Then
            pb_blau1.Location = F22
        ElseIf LäuferBlau1 = 14 Then
            pb_blau1.Location = F23
        ElseIf LäuferBlau1 = 15 Then
            pb_blau1.Location = F24
        ElseIf LäuferBlau1 = 16 Then
            pb_blau1.Location = F25
        ElseIf LäuferBlau1 = 17 Then
            pb_blau1.Location = F26
        ElseIf LäuferBlau1 = 18 Then
            pb_blau1.Location = F27
        ElseIf LäuferBlau1 = 19 Then
            pb_blau1.Location = F28
        ElseIf LäuferBlau1 = 20 Then
            pb_blau1.Location = F29
        ElseIf LäuferBlau1 = 21 Then
            pb_blau1.Location = F30
        ElseIf LäuferBlau1 = 22 Then
            pb_blau1.Location = F31
        ElseIf LäuferBlau1 = 23 Then
            pb_blau1.Location = F32
        ElseIf LäuferBlau1 = 24 Then
            pb_blau1.Location = F33
        ElseIf LäuferBlau1 = 25 Then
            pb_blau1.Location = F34
        ElseIf LäuferBlau1 = 26 Then
            pb_blau1.Location = F35
        ElseIf LäuferBlau1 = 27 Then
            pb_blau1.Location = F36
        ElseIf LäuferBlau1 = 28 Then
            pb_blau1.Location = F37
        ElseIf LäuferBlau1 = 29 Then
            pb_blau1.Location = F38
        ElseIf LäuferBlau1 = 30 Then
            pb_blau1.Location = F39
        ElseIf LäuferBlau1 = 31 Then
            pb_blau1.Location = F40
        ElseIf LäuferBlau1 = 32 Then
            pb_blau1.Location = F1
        ElseIf LäuferBlau1 = 33 Then
            pb_blau1.Location = F2
        ElseIf LäuferBlau1 = 34 Then
            pb_blau1.Location = F3
        ElseIf LäuferBlau1 = 35 Then
            pb_blau1.Location = F4
        ElseIf LäuferBlau1 = 36 Then
            pb_blau1.Location = F5
        ElseIf LäuferBlau1 = 37 Then
            pb_blau1.Location = F6
        ElseIf LäuferBlau1 = 38 Then
            pb_blau1.Location = F7
        ElseIf LäuferBlau1 = 39 Then
            pb_blau1.Location = F8
        ElseIf LäuferBlau1 = 40 Then
            pb_blau1.Location = F9
            'Jetzt kommt das Ziel
        ElseIf LäuferBlau1 = 41 Then
            pb_blau1.Location = BZ1
            rb_blau1.Enabled = False
        ElseIf LäuferBlau1 = 42 Then
            pb_blau1.Location = BZ2
            rb_blau1.Enabled = False
        ElseIf LäuferBlau1 = 43 Then
            pb_blau1.Location = BZ3
            rb_blau1.Enabled = False
        ElseIf LäuferBlau1 = 44 Then
            pb_blau1.Location = BZ4
            rb_blau1.Enabled = False
            Return
        End If

        If LäuferBlau2 = 1 Then
            pb_blau2.Location = F10
        ElseIf LäuferBlau2 = 2 Then
            pb_blau2.Location = F11
        ElseIf LäuferBlau2 = 3 Then
            pb_blau2.Location = F12
        ElseIf LäuferBlau2 = 4 Then
            pb_blau2.Location = F13
        ElseIf LäuferBlau2 = 5 Then
            pb_blau2.Location = F14
        ElseIf LäuferBlau2 = 6 Then
            pb_blau2.Location = F15
        ElseIf LäuferBlau2 = 7 Then
            pb_blau2.Location = F16
        ElseIf LäuferBlau2 = 8 Then
            pb_blau2.Location = F17
        ElseIf LäuferBlau2 = 9 Then
            pb_blau2.Location = F18
        ElseIf LäuferBlau2 = 10 Then
            pb_blau2.Location = F19
        ElseIf LäuferBlau2 = 11 Then
            pb_blau2.Location = F20
        ElseIf LäuferBlau2 = 12 Then
            pb_blau2.Location = F21
        ElseIf LäuferBlau2 = 13 Then
            pb_blau2.Location = F22
        ElseIf LäuferBlau2 = 14 Then
            pb_blau2.Location = F23
        ElseIf LäuferBlau2 = 15 Then
            pb_blau2.Location = F24
        ElseIf LäuferBlau2 = 16 Then
            pb_blau2.Location = F25
        ElseIf LäuferBlau2 = 17 Then
            pb_blau2.Location = F26
        ElseIf LäuferBlau2 = 18 Then
            pb_blau2.Location = F27
        ElseIf LäuferBlau2 = 19 Then
            pb_blau2.Location = F28
        ElseIf LäuferBlau2 = 20 Then
            pb_blau2.Location = F29
        ElseIf LäuferBlau2 = 21 Then
            pb_blau2.Location = F30
        ElseIf LäuferBlau2 = 22 Then
            pb_blau2.Location = F31
        ElseIf LäuferBlau2 = 23 Then
            pb_blau2.Location = F32
        ElseIf LäuferBlau2 = 24 Then
            pb_blau2.Location = F33
        ElseIf LäuferBlau2 = 25 Then
            pb_blau2.Location = F34
        ElseIf LäuferBlau2 = 26 Then
            pb_blau2.Location = F35
        ElseIf LäuferBlau2 = 27 Then
            pb_blau2.Location = F36
        ElseIf LäuferBlau2 = 28 Then
            pb_blau2.Location = F37
        ElseIf LäuferBlau2 = 29 Then
            pb_blau2.Location = F38
        ElseIf LäuferBlau2 = 30 Then
            pb_blau2.Location = F39
        ElseIf LäuferBlau2 = 31 Then
            pb_blau2.Location = F40
        ElseIf LäuferBlau2 = 32 Then
            pb_blau2.Location = F1
        ElseIf LäuferBlau2 = 33 Then
            pb_blau2.Location = F2
        ElseIf LäuferBlau2 = 34 Then
            pb_blau2.Location = F3
        ElseIf LäuferBlau2 = 35 Then
            pb_blau2.Location = F4
        ElseIf LäuferBlau2 = 36 Then
            pb_blau2.Location = F5
        ElseIf LäuferBlau2 = 37 Then
            pb_blau2.Location = F6
        ElseIf LäuferBlau2 = 38 Then
            pb_blau2.Location = F7
        ElseIf LäuferBlau2 = 39 Then
            pb_blau2.Location = F8
        ElseIf LäuferBlau2 = 40 Then
            pb_blau2.Location = F9
        ElseIf LäuferBlau2 = 41 Then
            pb_blau2.Location = BZ1
            rb_blau2.Enabled = False
        ElseIf LäuferBlau2 = 42 Then
            pb_blau2.Location = BZ2
            rb_blau2.Enabled = False
        ElseIf LäuferBlau2 = 43 Then
            pb_blau2.Location = BZ3
            rb_blau2.Enabled = False
        ElseIf LäuferBlau2 = 44 Then
            pb_blau2.Location = BZ4
            rb_blau2.Enabled = False
            Return
        End If

        If LäuferBlau3 = 1 Then
            pb_blau3.Location = F10
        ElseIf LäuferBlau3 = 2 Then
            pb_blau3.Location = F11
        ElseIf LäuferBlau3 = 3 Then
            pb_blau3.Location = F12
        ElseIf LäuferBlau3 = 4 Then
            pb_blau3.Location = F13
        ElseIf LäuferBlau3 = 5 Then
            pb_blau3.Location = F14
        ElseIf LäuferBlau3 = 6 Then
            pb_blau3.Location = F15
        ElseIf LäuferBlau3 = 7 Then
            pb_blau3.Location = F16
        ElseIf LäuferBlau3 = 8 Then
            pb_blau3.Location = F17
        ElseIf LäuferBlau3 = 9 Then
            pb_blau3.Location = F18
        ElseIf LäuferBlau3 = 10 Then
            pb_blau3.Location = F19
        ElseIf LäuferBlau3 = 11 Then
            pb_blau3.Location = F20
        ElseIf LäuferBlau3 = 12 Then
            pb_blau3.Location = F21
        ElseIf LäuferBlau3 = 13 Then
            pb_blau3.Location = F22
        ElseIf LäuferBlau3 = 14 Then
            pb_blau3.Location = F23
        ElseIf LäuferBlau3 = 15 Then
            pb_blau3.Location = F24
        ElseIf LäuferBlau3 = 16 Then
            pb_blau3.Location = F25
        ElseIf LäuferBlau3 = 17 Then
            pb_blau3.Location = F26
        ElseIf LäuferBlau3 = 18 Then
            pb_blau3.Location = F27
        ElseIf LäuferBlau3 = 19 Then
            pb_blau3.Location = F28
        ElseIf LäuferBlau3 = 20 Then
            pb_blau3.Location = F29
        ElseIf LäuferBlau3 = 21 Then
            pb_blau3.Location = F30
        ElseIf LäuferBlau3 = 22 Then
            pb_blau3.Location = F31
        ElseIf LäuferBlau3 = 23 Then
            pb_blau3.Location = F32
        ElseIf LäuferBlau3 = 24 Then
            pb_blau3.Location = F33
        ElseIf LäuferBlau3 = 25 Then
            pb_blau3.Location = F34
        ElseIf LäuferBlau3 = 26 Then
            pb_blau3.Location = F35
        ElseIf LäuferBlau3 = 27 Then
            pb_blau3.Location = F36
        ElseIf LäuferBlau3 = 28 Then
            pb_blau3.Location = F37
        ElseIf LäuferBlau3 = 29 Then
            pb_blau3.Location = F38
        ElseIf LäuferBlau3 = 30 Then
            pb_blau3.Location = F39
        ElseIf LäuferBlau3 = 31 Then
            pb_blau3.Location = F40
        ElseIf LäuferBlau3 = 32 Then
            pb_blau3.Location = F1
        ElseIf LäuferBlau3 = 33 Then
            pb_blau3.Location = F2
        ElseIf LäuferBlau3 = 34 Then
            pb_blau3.Location = F3
        ElseIf LäuferBlau3 = 35 Then
            pb_blau3.Location = F4
        ElseIf LäuferBlau3 = 36 Then
            pb_blau3.Location = F5
        ElseIf LäuferBlau3 = 37 Then
            pb_blau3.Location = F6
        ElseIf LäuferBlau3 = 38 Then
            pb_blau3.Location = F7
        ElseIf LäuferBlau3 = 39 Then
            pb_blau3.Location = F8
        ElseIf LäuferBlau3 = 40 Then
            pb_blau3.Location = F9
        ElseIf LäuferBlau3 = 41 Then
            pb_blau3.Location = BZ1
            rb_blau3.Enabled = False
        ElseIf LäuferBlau3 = 42 Then
            pb_blau3.Location = BZ2
            rb_blau3.Enabled = False
        ElseIf LäuferBlau3 = 43 Then
            pb_blau3.Location = BZ3
            rb_blau3.Enabled = False
        ElseIf LäuferBlau3 = 44 Then
            pb_blau3.Location = BZ4
            rb_blau3.Enabled = False
            Return
        End If

        If LäuferBlau4 = 1 Then
            pb_blau4.Location = F10
        ElseIf LäuferBlau4 = 2 Then
            pb_blau4.Location = F11
        ElseIf LäuferBlau4 = 3 Then
            pb_blau4.Location = F12
        ElseIf LäuferBlau4 = 4 Then
            pb_blau4.Location = F13
        ElseIf LäuferBlau4 = 5 Then
            pb_blau4.Location = F14
        ElseIf LäuferBlau4 = 6 Then
            pb_blau4.Location = F15
        ElseIf LäuferBlau4 = 7 Then
            pb_blau4.Location = F16
        ElseIf LäuferBlau4 = 8 Then
            pb_blau4.Location = F17
        ElseIf LäuferBlau4 = 9 Then
            pb_blau4.Location = F18
        ElseIf LäuferBlau4 = 10 Then
            pb_blau4.Location = F19
        ElseIf LäuferBlau4 = 11 Then
            pb_blau4.Location = F20
        ElseIf LäuferBlau4 = 12 Then
            pb_blau4.Location = F21
        ElseIf LäuferBlau4 = 13 Then
            pb_blau4.Location = F22
        ElseIf LäuferBlau4 = 14 Then
            pb_blau4.Location = F23
        ElseIf LäuferBlau4 = 15 Then
            pb_blau4.Location = F24
        ElseIf LäuferBlau4 = 16 Then
            pb_blau4.Location = F25
        ElseIf LäuferBlau4 = 17 Then
            pb_blau4.Location = F26
        ElseIf LäuferBlau4 = 18 Then
            pb_blau4.Location = F27
        ElseIf LäuferBlau4 = 19 Then
            pb_blau4.Location = F28
        ElseIf LäuferBlau4 = 20 Then
            pb_blau4.Location = F29
        ElseIf LäuferBlau4 = 21 Then
            pb_blau4.Location = F30
        ElseIf LäuferBlau4 = 22 Then
            pb_blau4.Location = F31
        ElseIf LäuferBlau4 = 23 Then
            pb_blau4.Location = F32
        ElseIf LäuferBlau4 = 24 Then
            pb_blau4.Location = F33
        ElseIf LäuferBlau4 = 25 Then
            pb_blau4.Location = F34
        ElseIf LäuferBlau4 = 26 Then
            pb_blau4.Location = F35
        ElseIf LäuferBlau4 = 27 Then
            pb_blau4.Location = F36
        ElseIf LäuferBlau4 = 28 Then
            pb_blau4.Location = F37
        ElseIf LäuferBlau4 = 29 Then
            pb_blau4.Location = F38
        ElseIf LäuferBlau4 = 30 Then
            pb_blau4.Location = F39
        ElseIf LäuferBlau4 = 31 Then
            pb_blau4.Location = F40
        ElseIf LäuferBlau4 = 32 Then
            pb_blau4.Location = F1
        ElseIf LäuferBlau4 = 33 Then
            pb_blau4.Location = F2
        ElseIf LäuferBlau4 = 34 Then
            pb_blau4.Location = F3
        ElseIf LäuferBlau4 = 35 Then
            pb_blau4.Location = F4
        ElseIf LäuferBlau4 = 36 Then
            pb_blau4.Location = F5
        ElseIf LäuferBlau4 = 37 Then
            pb_blau4.Location = F6
        ElseIf LäuferBlau4 = 38 Then
            pb_blau4.Location = F7
        ElseIf LäuferBlau4 = 39 Then
            pb_blau4.Location = F8
        ElseIf LäuferBlau4 = 40 Then
            pb_blau4.Location = F9
        ElseIf LäuferBlau4 = 41 Then
            pb_blau4.Location = BZ1
            rb_blau4.Enabled = False
        ElseIf LäuferBlau4 = 42 Then
            pb_blau4.Location = BZ2
            rb_blau4.Enabled = False
        ElseIf LäuferBlau4 = 43 Then
            pb_blau4.Location = BZ3
            rb_blau4.Enabled = False
        ElseIf LäuferBlau4 = 44 Then
            pb_blau4.Location = BZ4
            rb_blau4.Enabled = False
            Return
        End If

        'GELB

        If LäuferGelb1 = 1 Then
            pb_gelb1.Location = F20
        ElseIf LäuferGelb1 = 2 Then
            pb_gelb1.Location = F21
        ElseIf LäuferGelb1 = 3 Then
            pb_gelb1.Location = F22
        ElseIf LäuferGelb1 = 4 Then
            pb_gelb1.Location = F23
        ElseIf LäuferGelb1 = 5 Then
            pb_gelb1.Location = F24
        ElseIf LäuferGelb1 = 6 Then
            pb_gelb1.Location = F25
        ElseIf LäuferGelb1 = 7 Then
            pb_gelb1.Location = F26
        ElseIf LäuferGelb1 = 8 Then
            pb_gelb1.Location = F27
        ElseIf LäuferGelb1 = 9 Then
            pb_gelb1.Location = F28
        ElseIf LäuferGelb1 = 10 Then
            pb_gelb1.Location = F29
        ElseIf LäuferGelb1 = 11 Then
            pb_gelb1.Location = F30
        ElseIf LäuferGelb1 = 12 Then
            pb_gelb1.Location = F31
        ElseIf LäuferGelb1 = 13 Then
            pb_gelb1.Location = F32
        ElseIf LäuferGelb1 = 14 Then
            pb_gelb1.Location = F33
        ElseIf LäuferGelb1 = 15 Then
            pb_gelb1.Location = F34
        ElseIf LäuferGelb1 = 16 Then
            pb_gelb1.Location = F35
        ElseIf LäuferGelb1 = 17 Then
            pb_gelb1.Location = F36
        ElseIf LäuferGelb1 = 18 Then
            pb_gelb1.Location = F37
        ElseIf LäuferGelb1 = 19 Then
            pb_gelb1.Location = F38
        ElseIf LäuferGelb1 = 20 Then
            pb_gelb1.Location = F39
        ElseIf LäuferGelb1 = 21 Then
            pb_gelb1.Location = F40
        ElseIf LäuferGelb1 = 22 Then
            pb_gelb1.Location = F1
        ElseIf LäuferGelb1 = 23 Then
            pb_gelb1.Location = F2
        ElseIf LäuferGelb1 = 24 Then
            pb_gelb1.Location = F3
        ElseIf LäuferGelb1 = 25 Then
            pb_gelb1.Location = F4
        ElseIf LäuferGelb1 = 26 Then
            pb_gelb1.Location = F5
        ElseIf LäuferGelb1 = 27 Then
            pb_gelb1.Location = F6
        ElseIf LäuferGelb1 = 28 Then
            pb_gelb1.Location = F7
        ElseIf LäuferGelb1 = 29 Then
            pb_gelb1.Location = F8
        ElseIf LäuferGelb1 = 30 Then
            pb_gelb1.Location = F9
        ElseIf LäuferGelb1 = 31 Then
            pb_gelb1.Location = F10
        ElseIf LäuferGelb1 = 32 Then
            pb_gelb1.Location = F11
        ElseIf LäuferGelb1 = 33 Then
            pb_gelb1.Location = F12
        ElseIf LäuferGelb1 = 34 Then
            pb_gelb1.Location = F13
        ElseIf LäuferGelb1 = 35 Then
            pb_gelb1.Location = F14
        ElseIf LäuferGelb1 = 36 Then
            pb_gelb1.Location = F15
        ElseIf LäuferGelb1 = 37 Then
            pb_gelb1.Location = F16
        ElseIf LäuferGelb1 = 38 Then
            pb_gelb1.Location = F17
        ElseIf LäuferGelb1 = 39 Then
            pb_gelb1.Location = F18
        ElseIf LäuferGelb1 = 40 Then
            pb_gelb1.Location = F19
        ElseIf LäuferGelb1 = 41 Then
            pb_gelb1.Location = YZ1
            rb_gelb1.Enabled = False
        ElseIf LäuferGelb1 = 42 Then
            pb_gelb1.Location = YZ2
            rb_gelb1.Enabled = False
        ElseIf LäuferGelb1 = 43 Then
            pb_gelb1.Location = YZ3
            rb_gelb1.Enabled = False
        ElseIf LäuferGelb1 = 44 Then
            pb_gelb1.Location = YZ4
            rb_gelb1.Enabled = False
            Return
        End If

        If LäuferGelb2 = 1 Then
            pb_gelb2.Location = F20
        ElseIf LäuferGelb2 = 2 Then
            pb_gelb2.Location = F21
        ElseIf LäuferGelb2 = 3 Then
            pb_gelb2.Location = F22
        ElseIf LäuferGelb2 = 4 Then
            pb_gelb2.Location = F23
        ElseIf LäuferGelb2 = 5 Then
            pb_gelb2.Location = F24
        ElseIf LäuferGelb2 = 6 Then
            pb_gelb2.Location = F25
        ElseIf LäuferGelb2 = 7 Then
            pb_gelb2.Location = F26
        ElseIf LäuferGelb2 = 8 Then
            pb_gelb2.Location = F27
        ElseIf LäuferGelb2 = 9 Then
            pb_gelb2.Location = F28
        ElseIf LäuferGelb2 = 10 Then
            pb_gelb2.Location = F29
        ElseIf LäuferGelb2 = 11 Then
            pb_gelb2.Location = F30
        ElseIf LäuferGelb2 = 12 Then
            pb_gelb2.Location = F31
        ElseIf LäuferGelb2 = 13 Then
            pb_gelb2.Location = F32
        ElseIf LäuferGelb2 = 14 Then
            pb_gelb2.Location = F33
        ElseIf LäuferGelb2 = 15 Then
            pb_gelb2.Location = F34
        ElseIf LäuferGelb2 = 16 Then
            pb_gelb2.Location = F35
        ElseIf LäuferGelb2 = 17 Then
            pb_gelb2.Location = F36
        ElseIf LäuferGelb2 = 18 Then
            pb_gelb2.Location = F37
        ElseIf LäuferGelb2 = 19 Then
            pb_gelb2.Location = F38
        ElseIf LäuferGelb2 = 20 Then
            pb_gelb2.Location = F39
        ElseIf LäuferGelb2 = 21 Then
            pb_gelb2.Location = F40
        ElseIf LäuferGelb2 = 22 Then
            pb_gelb2.Location = F1
        ElseIf LäuferGelb2 = 23 Then
            pb_gelb2.Location = F2
        ElseIf LäuferGelb2 = 24 Then
            pb_gelb2.Location = F3
        ElseIf LäuferGelb2 = 25 Then
            pb_gelb2.Location = F4
        ElseIf LäuferGelb2 = 26 Then
            pb_gelb2.Location = F5
        ElseIf LäuferGelb2 = 27 Then
            pb_gelb2.Location = F6
        ElseIf LäuferGelb2 = 28 Then
            pb_gelb2.Location = F7
        ElseIf LäuferGelb2 = 29 Then
            pb_gelb2.Location = F8
        ElseIf LäuferGelb2 = 30 Then
            pb_gelb2.Location = F9
        ElseIf LäuferGelb2 = 31 Then
            pb_gelb2.Location = F10
        ElseIf LäuferGelb2 = 32 Then
            pb_gelb2.Location = F11
        ElseIf LäuferGelb2 = 33 Then
            pb_gelb2.Location = F12
        ElseIf LäuferGelb2 = 34 Then
            pb_gelb2.Location = F13
        ElseIf LäuferGelb2 = 35 Then
            pb_gelb2.Location = F14
        ElseIf LäuferGelb2 = 36 Then
            pb_gelb2.Location = F15
        ElseIf LäuferGelb2 = 37 Then
            pb_gelb2.Location = F16
        ElseIf LäuferGelb2 = 38 Then
            pb_gelb2.Location = F17
        ElseIf LäuferGelb2 = 39 Then
            pb_gelb2.Location = F18
        ElseIf LäuferGelb2 = 40 Then
            pb_gelb2.Location = F19
        ElseIf LäuferGelb2 = 41 Then
            pb_gelb2.Location = YZ1
            rb_gelb2.Enabled = False
        ElseIf LäuferGelb2 = 42 Then
            pb_gelb2.Location = YZ2
            rb_gelb2.Enabled = False
        ElseIf LäuferGelb2 = 43 Then
            pb_gelb2.Location = YZ3
            rb_gelb2.Enabled = False
        ElseIf LäuferGelb2 = 44 Then
            pb_gelb2.Location = YZ4
            rb_gelb2.Enabled = False
            Return
        End If

        If LäuferGelb3 = 1 Then
            pb_gelb3.Location = F20
        ElseIf LäuferGelb3 = 2 Then
            pb_gelb3.Location = F21
        ElseIf LäuferGelb3 = 3 Then
            pb_gelb3.Location = F22
        ElseIf LäuferGelb3 = 4 Then
            pb_gelb3.Location = F23
        ElseIf LäuferGelb3 = 5 Then
            pb_gelb3.Location = F24
        ElseIf LäuferGelb3 = 6 Then
            pb_gelb3.Location = F25
        ElseIf LäuferGelb3 = 7 Then
            pb_gelb3.Location = F26
        ElseIf LäuferGelb3 = 8 Then
            pb_gelb3.Location = F27
        ElseIf LäuferGelb3 = 9 Then
            pb_gelb3.Location = F28
        ElseIf LäuferGelb3 = 10 Then
            pb_gelb3.Location = F29
        ElseIf LäuferGelb3 = 11 Then
            pb_gelb3.Location = F30
        ElseIf LäuferGelb3 = 12 Then
            pb_gelb3.Location = F31
        ElseIf LäuferGelb3 = 13 Then
            pb_gelb3.Location = F32
        ElseIf LäuferGelb3 = 14 Then
            pb_gelb3.Location = F33
        ElseIf LäuferGelb3 = 15 Then
            pb_gelb3.Location = F34
        ElseIf LäuferGelb3 = 16 Then
            pb_gelb3.Location = F35
        ElseIf LäuferGelb3 = 17 Then
            pb_gelb3.Location = F36
        ElseIf LäuferGelb3 = 18 Then
            pb_gelb3.Location = F37
        ElseIf LäuferGelb3 = 19 Then
            pb_gelb3.Location = F38
        ElseIf LäuferGelb3 = 20 Then
            pb_gelb3.Location = F39
        ElseIf LäuferGelb3 = 21 Then
            pb_gelb3.Location = F40
        ElseIf LäuferGelb3 = 22 Then
            pb_gelb3.Location = F1
        ElseIf LäuferGelb3 = 23 Then
            pb_gelb3.Location = F2
        ElseIf LäuferGelb3 = 24 Then
            pb_gelb3.Location = F3
        ElseIf LäuferGelb3 = 25 Then
            pb_gelb3.Location = F4
        ElseIf LäuferGelb3 = 26 Then
            pb_gelb3.Location = F5
        ElseIf LäuferGelb3 = 27 Then
            pb_gelb3.Location = F6
        ElseIf LäuferGelb3 = 28 Then
            pb_gelb3.Location = F7
        ElseIf LäuferGelb3 = 29 Then
            pb_gelb3.Location = F8
        ElseIf LäuferGelb3 = 30 Then
            pb_gelb3.Location = F9
        ElseIf LäuferGelb3 = 31 Then
            pb_gelb3.Location = F10
        ElseIf LäuferGelb3 = 32 Then
            pb_gelb3.Location = F11
        ElseIf LäuferGelb3 = 33 Then
            pb_gelb3.Location = F12
        ElseIf LäuferGelb3 = 34 Then
            pb_gelb3.Location = F13
        ElseIf LäuferGelb3 = 35 Then
            pb_gelb3.Location = F14
        ElseIf LäuferGelb3 = 36 Then
            pb_gelb3.Location = F15
        ElseIf LäuferGelb3 = 37 Then
            pb_gelb3.Location = F16
        ElseIf LäuferGelb3 = 38 Then
            pb_gelb3.Location = F17
        ElseIf LäuferGelb3 = 39 Then
            pb_gelb3.Location = F18
        ElseIf LäuferGelb3 = 40 Then
            pb_gelb3.Location = F19
        ElseIf LäuferGelb3 = 41 Then
            pb_gelb3.Location = YZ1
            rb_gelb3.Enabled = False
        ElseIf LäuferGelb3 = 42 Then
            pb_gelb3.Location = YZ2
            rb_gelb3.Enabled = False
        ElseIf LäuferGelb3 = 43 Then
            pb_gelb3.Location = YZ3
            rb_gelb3.Enabled = False
        ElseIf LäuferGelb3 = 44 Then
            pb_gelb3.Location = YZ4
            rb_gelb3.Enabled = False
            Return
        End If

        If LäuferGelb4 = 1 Then
            pb_gelb4.Location = F20
        ElseIf LäuferGelb4 = 2 Then
            pb_gelb4.Location = F21
        ElseIf LäuferGelb4 = 3 Then
            pb_gelb4.Location = F22
        ElseIf LäuferGelb4 = 4 Then
            pb_gelb4.Location = F23
        ElseIf LäuferGelb4 = 5 Then
            pb_gelb4.Location = F24
        ElseIf LäuferGelb4 = 6 Then
            pb_gelb4.Location = F25
        ElseIf LäuferGelb4 = 7 Then
            pb_gelb4.Location = F26
        ElseIf LäuferGelb4 = 8 Then
            pb_gelb4.Location = F27
        ElseIf LäuferGelb4 = 9 Then
            pb_gelb4.Location = F28
        ElseIf LäuferGelb4 = 10 Then
            pb_gelb4.Location = F29
        ElseIf LäuferGelb4 = 11 Then
            pb_gelb4.Location = F30
        ElseIf LäuferGelb4 = 12 Then
            pb_gelb4.Location = F31
        ElseIf LäuferGelb4 = 13 Then
            pb_gelb4.Location = F32
        ElseIf LäuferGelb4 = 14 Then
            pb_gelb4.Location = F33
        ElseIf LäuferGelb4 = 15 Then
            pb_gelb4.Location = F34
        ElseIf LäuferGelb4 = 16 Then
            pb_gelb4.Location = F35
        ElseIf LäuferGelb4 = 17 Then
            pb_gelb4.Location = F36
        ElseIf LäuferGelb4 = 18 Then
            pb_gelb4.Location = F37
        ElseIf LäuferGelb4 = 19 Then
            pb_gelb4.Location = F38
        ElseIf LäuferGelb4 = 20 Then
            pb_gelb4.Location = F39
        ElseIf LäuferGelb4 = 21 Then
            pb_gelb4.Location = F40
        ElseIf LäuferGelb4 = 22 Then
            pb_gelb4.Location = F1
        ElseIf LäuferGelb4 = 23 Then
            pb_gelb4.Location = F2
        ElseIf LäuferGelb4 = 24 Then
            pb_gelb4.Location = F3
        ElseIf LäuferGelb4 = 25 Then
            pb_gelb4.Location = F4
        ElseIf LäuferGelb4 = 26 Then
            pb_gelb4.Location = F5
        ElseIf LäuferGelb4 = 27 Then
            pb_gelb4.Location = F6
        ElseIf LäuferGelb4 = 28 Then
            pb_gelb4.Location = F7
        ElseIf LäuferGelb4 = 29 Then
            pb_gelb4.Location = F8
        ElseIf LäuferGelb4 = 30 Then
            pb_gelb4.Location = F9
        ElseIf LäuferGelb4 = 31 Then
            pb_gelb4.Location = F10
        ElseIf LäuferGelb4 = 32 Then
            pb_gelb4.Location = F11
        ElseIf LäuferGelb4 = 33 Then
            pb_gelb4.Location = F12
        ElseIf LäuferGelb4 = 34 Then
            pb_gelb4.Location = F13
        ElseIf LäuferGelb4 = 35 Then
            pb_gelb4.Location = F14
        ElseIf LäuferGelb4 = 36 Then
            pb_gelb4.Location = F15
        ElseIf LäuferGelb4 = 37 Then
            pb_gelb4.Location = F16
        ElseIf LäuferGelb4 = 38 Then
            pb_gelb4.Location = F17
        ElseIf LäuferGelb4 = 39 Then
            pb_gelb4.Location = F18
        ElseIf LäuferGelb4 = 40 Then
            pb_gelb4.Location = F19
        ElseIf LäuferGelb4 = 41 Then
            pb_gelb4.Location = YZ1
            rb_gelb4.Enabled = False
        ElseIf LäuferGelb4 = 42 Then
            pb_gelb4.Location = YZ2
            rb_gelb4.Enabled = False
        ElseIf LäuferGelb4 = 43 Then
            pb_gelb4.Location = YZ3
            rb_gelb4.Enabled = False
        ElseIf LäuferGelb4 = 44 Then
            pb_gelb4.Location = YZ4
            rb_gelb4.Enabled = False
            Return
        End If

        'GRÜN

        If LäuferGrün1 = 1 Then
            pb_grün1.Location = F30
        ElseIf LäuferGrün1 = 2 Then
            pb_grün1.Location = F31
        ElseIf LäuferGrün1 = 3 Then
            pb_grün1.Location = F32
        ElseIf LäuferGrün1 = 4 Then
            pb_grün1.Location = F33
        ElseIf LäuferGrün1 = 5 Then
            pb_grün1.Location = F34
        ElseIf LäuferGrün1 = 6 Then
            pb_grün1.Location = F35
        ElseIf LäuferGrün1 = 7 Then
            pb_grün1.Location = F36
        ElseIf LäuferGrün1 = 8 Then
            pb_grün1.Location = F37
        ElseIf LäuferGrün1 = 9 Then
            pb_grün1.Location = F38
        ElseIf LäuferGrün1 = 10 Then
            pb_grün1.Location = F39
        ElseIf LäuferGrün1 = 11 Then
            pb_grün1.Location = F40
        ElseIf LäuferGrün1 = 12 Then
            pb_grün1.Location = F1
        ElseIf LäuferGrün1 = 13 Then
            pb_grün1.Location = F2
        ElseIf LäuferGrün1 = 14 Then
            pb_grün1.Location = F3
        ElseIf LäuferGrün1 = 15 Then
            pb_grün1.Location = F4
        ElseIf LäuferGrün1 = 16 Then
            pb_grün1.Location = F5
        ElseIf LäuferGrün1 = 17 Then
            pb_grün1.Location = F6
        ElseIf LäuferGrün1 = 18 Then
            pb_grün1.Location = F7
        ElseIf LäuferGrün1 = 19 Then
            pb_grün1.Location = F8
        ElseIf LäuferGrün1 = 20 Then
            pb_grün1.Location = F9
        ElseIf LäuferGrün1 = 21 Then
            pb_grün1.Location = F10
        ElseIf LäuferGrün1 = 22 Then
            pb_grün1.Location = F11
        ElseIf LäuferGrün1 = 23 Then
            pb_grün1.Location = F12
        ElseIf LäuferGrün1 = 24 Then
            pb_grün1.Location = F13
        ElseIf LäuferGrün1 = 25 Then
            pb_grün1.Location = F14
        ElseIf LäuferGrün1 = 26 Then
            pb_grün1.Location = F15
        ElseIf LäuferGrün1 = 27 Then
            pb_grün1.Location = F16
        ElseIf LäuferGrün1 = 28 Then
            pb_grün1.Location = F17
        ElseIf LäuferGrün1 = 29 Then
            pb_grün1.Location = F18
        ElseIf LäuferGrün1 = 30 Then
            pb_grün1.Location = F19
        ElseIf LäuferGrün1 = 31 Then
            pb_grün1.Location = F20
        ElseIf LäuferGrün1 = 32 Then
            pb_grün1.Location = F21
        ElseIf LäuferGrün1 = 33 Then
            pb_grün1.Location = F22
        ElseIf LäuferGrün1 = 34 Then
            pb_grün1.Location = F23
        ElseIf LäuferGrün1 = 35 Then
            pb_grün1.Location = F24
        ElseIf LäuferGrün1 = 36 Then
            pb_grün1.Location = F25
        ElseIf LäuferGrün1 = 37 Then
            pb_grün1.Location = F26
        ElseIf LäuferGrün1 = 38 Then
            pb_grün1.Location = F27
        ElseIf LäuferGrün1 = 39 Then
            pb_grün1.Location = F28
        ElseIf LäuferGrün1 = 40 Then
            pb_grün1.Location = F29
        ElseIf LäuferGrün1 = 41 Then
            pb_grün1.Location = GZ1
            rb_grün1.Enabled = False
        ElseIf LäuferGrün1 = 42 Then
            pb_grün1.Location = GZ2
            rb_grün1.Enabled = False
        ElseIf LäuferGrün1 = 43 Then
            pb_grün1.Location = GZ3
            rb_grün1.Enabled = False
        ElseIf LäuferGrün1 = 44 Then
            pb_grün1.Location = GZ4
            rb_grün1.Enabled = False
            Return
        End If

        If LäuferGrün2 = 1 Then
            pb_grün2.Location = F30
        ElseIf LäuferGrün2 = 2 Then
            pb_grün2.Location = F31
        ElseIf LäuferGrün2 = 3 Then
            pb_grün2.Location = F32
        ElseIf LäuferGrün2 = 4 Then
            pb_grün2.Location = F33
        ElseIf LäuferGrün2 = 5 Then
            pb_grün2.Location = F34
        ElseIf LäuferGrün2 = 6 Then
            pb_grün2.Location = F35
        ElseIf LäuferGrün2 = 7 Then
            pb_grün2.Location = F36
        ElseIf LäuferGrün2 = 8 Then
            pb_grün2.Location = F37
        ElseIf LäuferGrün2 = 9 Then
            pb_grün2.Location = F38
        ElseIf LäuferGrün2 = 10 Then
            pb_grün2.Location = F39
        ElseIf LäuferGrün2 = 11 Then
            pb_grün2.Location = F40
        ElseIf LäuferGrün2 = 12 Then
            pb_grün2.Location = F1
        ElseIf LäuferGrün2 = 13 Then
            pb_grün2.Location = F2
        ElseIf LäuferGrün2 = 14 Then
            pb_grün2.Location = F3
        ElseIf LäuferGrün2 = 15 Then
            pb_grün2.Location = F4
        ElseIf LäuferGrün2 = 16 Then
            pb_grün2.Location = F5
        ElseIf LäuferGrün2 = 17 Then
            pb_grün2.Location = F6
        ElseIf LäuferGrün2 = 18 Then
            pb_grün2.Location = F7
        ElseIf LäuferGrün2 = 19 Then
            pb_grün2.Location = F8
        ElseIf LäuferGrün2 = 20 Then
            pb_grün2.Location = F9
        ElseIf LäuferGrün2 = 21 Then
            pb_grün2.Location = F10
        ElseIf LäuferGrün2 = 22 Then
            pb_grün2.Location = F11
        ElseIf LäuferGrün2 = 23 Then
            pb_grün2.Location = F12
        ElseIf LäuferGrün2 = 24 Then
            pb_grün2.Location = F13
        ElseIf LäuferGrün2 = 25 Then
            pb_grün2.Location = F14
        ElseIf LäuferGrün2 = 26 Then
            pb_grün2.Location = F15
        ElseIf LäuferGrün2 = 27 Then
            pb_grün2.Location = F16
        ElseIf LäuferGrün2 = 28 Then
            pb_grün2.Location = F17
        ElseIf LäuferGrün2 = 29 Then
            pb_grün2.Location = F18
        ElseIf LäuferGrün2 = 30 Then
            pb_grün2.Location = F19
        ElseIf LäuferGrün2 = 31 Then
            pb_grün2.Location = F20
        ElseIf LäuferGrün2 = 32 Then
            pb_grün2.Location = F21
        ElseIf LäuferGrün2 = 33 Then
            pb_grün2.Location = F22
        ElseIf LäuferGrün2 = 34 Then
            pb_grün2.Location = F23
        ElseIf LäuferGrün2 = 35 Then
            pb_grün2.Location = F24
        ElseIf LäuferGrün2 = 36 Then
            pb_grün2.Location = F25
        ElseIf LäuferGrün2 = 37 Then
            pb_grün2.Location = F26
        ElseIf LäuferGrün2 = 38 Then
            pb_grün2.Location = F27
        ElseIf LäuferGrün2 = 39 Then
            pb_grün2.Location = F28
        ElseIf LäuferGrün2 = 40 Then
            pb_grün2.Location = F29
        ElseIf LäuferGrün2 = 41 Then
            pb_grün2.Location = GZ1
            rb_grün2.Enabled = False
        ElseIf LäuferGrün2 = 42 Then
            pb_grün2.Location = GZ2
            rb_grün2.Enabled = False
        ElseIf LäuferGrün2 = 43 Then
            pb_grün2.Location = GZ3
            rb_grün2.Enabled = False
        ElseIf LäuferGrün2 = 44 Then
            pb_grün2.Location = GZ4
            rb_grün2.Enabled = False
            Return
        End If

        If LäuferGrün3 = 1 Then
            pb_grün3.Location = F30
        ElseIf LäuferGrün3 = 2 Then
            pb_grün3.Location = F31
        ElseIf LäuferGrün3 = 3 Then
            pb_grün3.Location = F32
        ElseIf LäuferGrün3 = 4 Then
            pb_grün3.Location = F33
        ElseIf LäuferGrün3 = 5 Then
            pb_grün3.Location = F34
        ElseIf LäuferGrün3 = 6 Then
            pb_grün3.Location = F35
        ElseIf LäuferGrün3 = 7 Then
            pb_grün3.Location = F36
        ElseIf LäuferGrün3 = 8 Then
            pb_grün3.Location = F37
        ElseIf LäuferGrün3 = 9 Then
            pb_grün3.Location = F38
        ElseIf LäuferGrün3 = 10 Then
            pb_grün3.Location = F39
        ElseIf LäuferGrün3 = 11 Then
            pb_grün3.Location = F40
        ElseIf LäuferGrün3 = 12 Then
            pb_grün3.Location = F1
        ElseIf LäuferGrün3 = 13 Then
            pb_grün3.Location = F2
        ElseIf LäuferGrün3 = 14 Then
            pb_grün3.Location = F3
        ElseIf LäuferGrün3 = 15 Then
            pb_grün3.Location = F4
        ElseIf LäuferGrün3 = 16 Then
            pb_grün3.Location = F5
        ElseIf LäuferGrün3 = 17 Then
            pb_grün3.Location = F6
        ElseIf LäuferGrün3 = 18 Then
            pb_grün3.Location = F7
        ElseIf LäuferGrün3 = 19 Then
            pb_grün3.Location = F8
        ElseIf LäuferGrün3 = 20 Then
            pb_grün3.Location = F9
        ElseIf LäuferGrün3 = 21 Then
            pb_grün3.Location = F10
        ElseIf LäuferGrün3 = 22 Then
            pb_grün3.Location = F11
        ElseIf LäuferGrün3 = 23 Then
            pb_grün3.Location = F12
        ElseIf LäuferGrün3 = 24 Then
            pb_grün3.Location = F13
        ElseIf LäuferGrün3 = 25 Then
            pb_grün3.Location = F14
        ElseIf LäuferGrün3 = 26 Then
            pb_grün3.Location = F15
        ElseIf LäuferGrün3 = 27 Then
            pb_grün3.Location = F16
        ElseIf LäuferGrün3 = 28 Then
            pb_grün3.Location = F17
        ElseIf LäuferGrün3 = 29 Then
            pb_grün3.Location = F18
        ElseIf LäuferGrün3 = 30 Then
            pb_grün3.Location = F19
        ElseIf LäuferGrün3 = 31 Then
            pb_grün3.Location = F20
        ElseIf LäuferGrün3 = 32 Then
            pb_grün3.Location = F21
        ElseIf LäuferGrün3 = 33 Then
            pb_grün3.Location = F22
        ElseIf LäuferGrün3 = 34 Then
            pb_grün3.Location = F23
        ElseIf LäuferGrün3 = 35 Then
            pb_grün3.Location = F24
        ElseIf LäuferGrün3 = 36 Then
            pb_grün3.Location = F25
        ElseIf LäuferGrün3 = 37 Then
            pb_grün3.Location = F26
        ElseIf LäuferGrün3 = 38 Then
            pb_grün3.Location = F27
        ElseIf LäuferGrün3 = 39 Then
            pb_grün3.Location = F28
        ElseIf LäuferGrün3 = 40 Then
            pb_grün3.Location = F29
        ElseIf LäuferGrün3 = 41 Then
            pb_grün3.Location = GZ1
            rb_grün3.Enabled = False
        ElseIf LäuferGrün3 = 42 Then
            pb_grün3.Location = GZ2
            rb_grün3.Enabled = False
        ElseIf LäuferGrün3 = 43 Then
            pb_grün3.Location = GZ3
            rb_grün3.Enabled = False
        ElseIf LäuferGrün3 = 44 Then
            pb_grün3.Location = GZ4
            rb_grün3.Enabled = False
            Return
        End If

        If LäuferGrün4 = 1 Then
            pb_grün4.Location = F30
        ElseIf LäuferGrün4 = 2 Then
            pb_grün4.Location = F31
        ElseIf LäuferGrün4 = 3 Then
            pb_grün4.Location = F32
        ElseIf LäuferGrün4 = 4 Then
            pb_grün4.Location = F33
        ElseIf LäuferGrün4 = 5 Then
            pb_grün4.Location = F34
        ElseIf LäuferGrün4 = 6 Then
            pb_grün4.Location = F35
        ElseIf LäuferGrün4 = 7 Then
            pb_grün4.Location = F36
        ElseIf LäuferGrün4 = 8 Then
            pb_grün4.Location = F37
        ElseIf LäuferGrün4 = 9 Then
            pb_grün4.Location = F38
        ElseIf LäuferGrün4 = 10 Then
            pb_grün4.Location = F39
        ElseIf LäuferGrün4 = 11 Then
            pb_grün4.Location = F40
        ElseIf LäuferGrün4 = 12 Then
            pb_grün4.Location = F1
        ElseIf LäuferGrün4 = 13 Then
            pb_grün4.Location = F2
        ElseIf LäuferGrün4 = 14 Then
            pb_grün4.Location = F3
        ElseIf LäuferGrün4 = 15 Then
            pb_grün4.Location = F4
        ElseIf LäuferGrün4 = 16 Then
            pb_grün4.Location = F5
        ElseIf LäuferGrün4 = 17 Then
            pb_grün4.Location = F6
        ElseIf LäuferGrün4 = 18 Then
            pb_grün4.Location = F7
        ElseIf LäuferGrün4 = 19 Then
            pb_grün4.Location = F8
        ElseIf LäuferGrün4 = 20 Then
            pb_grün4.Location = F9
        ElseIf LäuferGrün4 = 21 Then
            pb_grün4.Location = F10
        ElseIf LäuferGrün4 = 22 Then
            pb_grün4.Location = F11
        ElseIf LäuferGrün4 = 23 Then
            pb_grün4.Location = F12
        ElseIf LäuferGrün4 = 24 Then
            pb_grün4.Location = F13
        ElseIf LäuferGrün4 = 25 Then
            pb_grün4.Location = F14
        ElseIf LäuferGrün4 = 26 Then
            pb_grün4.Location = F15
        ElseIf LäuferGrün4 = 27 Then
            pb_grün4.Location = F16
        ElseIf LäuferGrün4 = 28 Then
            pb_grün4.Location = F17
        ElseIf LäuferGrün4 = 29 Then
            pb_grün4.Location = F18
        ElseIf LäuferGrün4 = 30 Then
            pb_grün4.Location = F19
        ElseIf LäuferGrün4 = 31 Then
            pb_grün4.Location = F20
        ElseIf LäuferGrün4 = 32 Then
            pb_grün4.Location = F21
        ElseIf LäuferGrün4 = 33 Then
            pb_grün4.Location = F22
        ElseIf LäuferGrün4 = 34 Then
            pb_grün4.Location = F23
        ElseIf LäuferGrün4 = 35 Then
            pb_grün4.Location = F24
        ElseIf LäuferGrün4 = 36 Then
            pb_grün4.Location = F25
        ElseIf LäuferGrün4 = 37 Then
            pb_grün4.Location = F26
        ElseIf LäuferGrün4 = 38 Then
            pb_grün4.Location = F27
        ElseIf LäuferGrün4 = 39 Then
            pb_grün4.Location = F28
        ElseIf LäuferGrün4 = 40 Then
            pb_grün4.Location = F29
        ElseIf LäuferGrün4 = 41 Then
            pb_grün4.Location = GZ1
            rb_grün4.Enabled = False
        ElseIf LäuferGrün4 = 42 Then
            pb_grün4.Location = GZ2
            rb_grün4.Enabled = False
        ElseIf LäuferGrün4 = 43 Then
            pb_grün4.Location = GZ3
            rb_grün4.Enabled = False
        ElseIf LäuferGrün4 = 44 Then
            pb_grün4.Location = GZ4
            rb_grün4.Enabled = False
            Return
        End If

        'Rauswerfen der Spielfiguren

        If pb_rot1.Location = F1 And pb_blau1.Location = F1 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F2 And pb_blau1.Location = F2 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F3 And pb_blau1.Location = F3 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F4 And pb_blau1.Location = F4 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F5 And pb_blau1.Location = F5 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F6 And pb_blau1.Location = F6 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F7 And pb_blau1.Location = F7 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F8 And pb_blau1.Location = F8 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F9 And pb_blau1.Location = F9 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F10 And pb_blau1.Location = F10 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F11 And pb_blau1.Location = F11 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F12 And pb_blau1.Location = F12 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F13 And pb_blau1.Location = F13 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F14 And pb_blau1.Location = F14 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F15 And pb_blau1.Location = F15 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F16 And pb_blau1.Location = F16 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F17 And pb_blau1.Location = F17 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F18 And pb_blau1.Location = F18 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F19 And pb_blau1.Location = F19 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F20 And pb_blau1.Location = F20 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F21 And pb_blau1.Location = F21 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F22 And pb_blau1.Location = F22 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F23 And pb_blau1.Location = F23 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F24 And pb_blau1.Location = F24 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F25 And pb_blau1.Location = F25 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F26 And pb_blau1.Location = F26 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F27 And pb_blau1.Location = F27 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F28 And pb_blau1.Location = F28 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F29 And pb_blau1.Location = F29 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F30 And pb_blau1.Location = F30 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F31 And pb_blau1.Location = F31 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F32 And pb_blau1.Location = F32 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F33 And pb_blau1.Location = F33 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F34 And pb_blau1.Location = F34 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F35 And pb_blau1.Location = F35 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F36 And pb_blau1.Location = F36 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F37 And pb_blau1.Location = F37 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F38 And pb_blau1.Location = F38 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F39 And pb_blau1.Location = F39 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot1.Location = F40 And pb_blau1.Location = F40 And rb_rot1.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        End If

        If pb_rot1.Location = F1 And pb_blau2.Location = F1 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F2 And pb_blau2.Location = F2 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F3 And pb_blau2.Location = F3 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F4 And pb_blau2.Location = F4 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F5 And pb_blau2.Location = F5 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F6 And pb_blau2.Location = F6 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F7 And pb_blau2.Location = F7 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F8 And pb_blau2.Location = F8 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F9 And pb_blau2.Location = F9 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F10 And pb_blau2.Location = F10 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F11 And pb_blau2.Location = F11 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F12 And pb_blau2.Location = F12 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F13 And pb_blau2.Location = F13 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F14 And pb_blau2.Location = F14 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F15 And pb_blau2.Location = F15 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F16 And pb_blau2.Location = F16 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F17 And pb_blau2.Location = F17 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F18 And pb_blau2.Location = F18 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F19 And pb_blau2.Location = F19 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F20 And pb_blau2.Location = F20 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F21 And pb_blau2.Location = F21 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F22 And pb_blau2.Location = F22 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F23 And pb_blau2.Location = F23 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F24 And pb_blau2.Location = F24 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F25 And pb_blau2.Location = F25 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F26 And pb_blau2.Location = F26 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F27 And pb_blau2.Location = F27 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F28 And pb_blau2.Location = F28 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F29 And pb_blau2.Location = F29 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F30 And pb_blau2.Location = F30 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F31 And pb_blau2.Location = F31 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F32 And pb_blau2.Location = F32 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F33 And pb_blau2.Location = F33 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F34 And pb_blau2.Location = F34 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F35 And pb_blau2.Location = F35 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F36 And pb_blau2.Location = F36 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F37 And pb_blau2.Location = F37 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F38 And pb_blau2.Location = F38 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F39 And pb_blau2.Location = F39 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot1.Location = F40 And pb_blau2.Location = F40 And rb_rot1.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        End If

        If pb_rot1.Location = F1 And pb_blau3.Location = F1 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F2 And pb_blau3.Location = F2 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F3 And pb_blau3.Location = F3 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F4 And pb_blau3.Location = F4 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F5 And pb_blau3.Location = F5 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F6 And pb_blau3.Location = F6 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F7 And pb_blau3.Location = F7 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F8 And pb_blau3.Location = F8 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F9 And pb_blau3.Location = F9 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F10 And pb_blau3.Location = F10 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F11 And pb_blau3.Location = F11 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F12 And pb_blau3.Location = F12 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F13 And pb_blau3.Location = F13 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F14 And pb_blau3.Location = F14 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F15 And pb_blau3.Location = F15 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F16 And pb_blau3.Location = F16 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F17 And pb_blau3.Location = F17 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F18 And pb_blau3.Location = F18 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F19 And pb_blau3.Location = F19 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F20 And pb_blau3.Location = F20 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F21 And pb_blau3.Location = F21 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F22 And pb_blau3.Location = F22 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F23 And pb_blau3.Location = F23 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F24 And pb_blau3.Location = F24 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F25 And pb_blau3.Location = F25 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F26 And pb_blau3.Location = F26 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F27 And pb_blau3.Location = F27 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F28 And pb_blau3.Location = F28 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F29 And pb_blau3.Location = F29 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F30 And pb_blau3.Location = F30 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F31 And pb_blau3.Location = F31 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F32 And pb_blau3.Location = F32 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F33 And pb_blau3.Location = F33 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F34 And pb_blau3.Location = F34 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F35 And pb_blau3.Location = F35 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F36 And pb_blau3.Location = F36 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F37 And pb_blau3.Location = F37 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F38 And pb_blau3.Location = F38 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F39 And pb_blau3.Location = F39 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot1.Location = F40 And pb_blau3.Location = F40 And rb_rot1.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        End If

        If pb_rot1.Location = F1 And pb_blau4.Location = F1 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F2 And pb_blau4.Location = F2 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F3 And pb_blau4.Location = F3 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F4 And pb_blau4.Location = F4 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F5 And pb_blau4.Location = F5 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F6 And pb_blau4.Location = F6 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F7 And pb_blau4.Location = F7 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F8 And pb_blau4.Location = F8 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F9 And pb_blau4.Location = F9 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F10 And pb_blau4.Location = F10 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F11 And pb_blau4.Location = F11 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F12 And pb_blau4.Location = F12 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F13 And pb_blau4.Location = F13 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F14 And pb_blau4.Location = F14 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F15 And pb_blau4.Location = F15 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F16 And pb_blau4.Location = F16 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F17 And pb_blau4.Location = F17 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F18 And pb_blau4.Location = F18 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F19 And pb_blau4.Location = F19 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F20 And pb_blau4.Location = F20 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F21 And pb_blau4.Location = F21 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F22 And pb_blau4.Location = F22 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F23 And pb_blau4.Location = F23 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F24 And pb_blau4.Location = F24 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F25 And pb_blau4.Location = F25 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F26 And pb_blau4.Location = F26 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F27 And pb_blau4.Location = F27 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F28 And pb_blau4.Location = F28 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F29 And pb_blau4.Location = F29 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F30 And pb_blau4.Location = F30 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F31 And pb_blau4.Location = F31 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F32 And pb_blau4.Location = F32 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F33 And pb_blau4.Location = F33 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F34 And pb_blau4.Location = F34 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F35 And pb_blau4.Location = F35 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F36 And pb_blau4.Location = F36 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F37 And pb_blau4.Location = F37 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F38 And pb_blau4.Location = F38 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F39 And pb_blau4.Location = F39 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot1.Location = F40 And pb_blau4.Location = F40 And rb_rot1.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        End If

        If pb_rot2.Location = F1 And pb_blau1.Location = F1 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F2 And pb_blau1.Location = F2 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F3 And pb_blau1.Location = F3 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F4 And pb_blau1.Location = F4 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F5 And pb_blau1.Location = F5 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F6 And pb_blau1.Location = F6 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F7 And pb_blau1.Location = F7 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F8 And pb_blau1.Location = F8 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F9 And pb_blau1.Location = F9 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F10 And pb_blau1.Location = F10 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F11 And pb_blau1.Location = F11 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F12 And pb_blau1.Location = F12 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F13 And pb_blau1.Location = F13 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F14 And pb_blau1.Location = F14 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F15 And pb_blau1.Location = F15 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F16 And pb_blau1.Location = F16 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F17 And pb_blau1.Location = F17 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F18 And pb_blau1.Location = F18 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F19 And pb_blau1.Location = F19 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F20 And pb_blau1.Location = F20 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F21 And pb_blau1.Location = F21 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F22 And pb_blau1.Location = F22 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F23 And pb_blau1.Location = F23 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F24 And pb_blau1.Location = F24 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F25 And pb_blau1.Location = F25 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F26 And pb_blau1.Location = F26 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F27 And pb_blau1.Location = F27 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F28 And pb_blau1.Location = F28 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F29 And pb_blau1.Location = F29 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F30 And pb_blau1.Location = F30 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F31 And pb_blau1.Location = F31 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F32 And pb_blau1.Location = F32 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F33 And pb_blau1.Location = F33 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F34 And pb_blau1.Location = F34 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F35 And pb_blau1.Location = F35 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F36 And pb_blau1.Location = F36 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F37 And pb_blau1.Location = F37 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F38 And pb_blau1.Location = F38 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F39 And pb_blau1.Location = F39 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot2.Location = F40 And pb_blau1.Location = F40 And rb_rot2.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        End If

        If pb_rot2.Location = F1 And pb_blau2.Location = F1 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F2 And pb_blau2.Location = F2 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F3 And pb_blau2.Location = F3 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F4 And pb_blau2.Location = F4 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F5 And pb_blau2.Location = F5 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F6 And pb_blau2.Location = F6 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F7 And pb_blau2.Location = F7 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F8 And pb_blau2.Location = F8 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F9 And pb_blau2.Location = F9 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F10 And pb_blau2.Location = F10 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F11 And pb_blau2.Location = F11 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F12 And pb_blau2.Location = F12 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F13 And pb_blau2.Location = F13 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F14 And pb_blau2.Location = F14 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F15 And pb_blau2.Location = F15 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F16 And pb_blau2.Location = F16 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F17 And pb_blau2.Location = F17 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F18 And pb_blau2.Location = F18 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F19 And pb_blau2.Location = F19 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F20 And pb_blau2.Location = F20 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F21 And pb_blau2.Location = F21 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F22 And pb_blau2.Location = F22 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F23 And pb_blau2.Location = F23 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F24 And pb_blau2.Location = F24 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F25 And pb_blau2.Location = F25 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F26 And pb_blau2.Location = F26 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F27 And pb_blau2.Location = F27 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F28 And pb_blau2.Location = F28 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F29 And pb_blau2.Location = F29 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F30 And pb_blau2.Location = F30 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F31 And pb_blau2.Location = F31 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F32 And pb_blau2.Location = F32 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F33 And pb_blau2.Location = F33 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F34 And pb_blau2.Location = F34 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F35 And pb_blau2.Location = F35 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F36 And pb_blau2.Location = F36 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F37 And pb_blau2.Location = F37 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F38 And pb_blau2.Location = F38 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F39 And pb_blau2.Location = F39 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot2.Location = F40 And pb_blau2.Location = F40 And rb_rot2.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        End If

        If pb_rot2.Location = F1 And pb_blau3.Location = F1 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F2 And pb_blau3.Location = F2 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F3 And pb_blau3.Location = F3 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F4 And pb_blau3.Location = F4 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F5 And pb_blau3.Location = F5 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F6 And pb_blau3.Location = F6 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F7 And pb_blau3.Location = F7 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F8 And pb_blau3.Location = F8 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F9 And pb_blau3.Location = F9 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F10 And pb_blau3.Location = F10 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F11 And pb_blau3.Location = F11 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F12 And pb_blau3.Location = F12 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F13 And pb_blau3.Location = F13 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F14 And pb_blau3.Location = F14 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F15 And pb_blau3.Location = F15 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F16 And pb_blau3.Location = F16 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F17 And pb_blau3.Location = F17 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F18 And pb_blau3.Location = F18 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F19 And pb_blau3.Location = F19 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F20 And pb_blau3.Location = F20 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F21 And pb_blau3.Location = F21 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F22 And pb_blau3.Location = F22 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F23 And pb_blau3.Location = F23 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F24 And pb_blau3.Location = F24 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F25 And pb_blau3.Location = F25 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F26 And pb_blau3.Location = F26 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F27 And pb_blau3.Location = F27 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F28 And pb_blau3.Location = F28 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F29 And pb_blau3.Location = F29 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F30 And pb_blau3.Location = F30 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F31 And pb_blau3.Location = F31 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F32 And pb_blau3.Location = F32 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F33 And pb_blau3.Location = F33 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F34 And pb_blau3.Location = F34 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F35 And pb_blau3.Location = F35 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F36 And pb_blau3.Location = F36 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F37 And pb_blau3.Location = F37 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F38 And pb_blau3.Location = F38 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F39 And pb_blau3.Location = F39 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot2.Location = F40 And pb_blau3.Location = F40 And rb_rot2.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        End If

        If pb_rot2.Location = F1 And pb_blau4.Location = F1 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F2 And pb_blau4.Location = F2 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F3 And pb_blau4.Location = F3 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F4 And pb_blau4.Location = F4 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F5 And pb_blau4.Location = F5 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F6 And pb_blau4.Location = F6 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F7 And pb_blau4.Location = F7 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F8 And pb_blau4.Location = F8 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F9 And pb_blau4.Location = F9 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F10 And pb_blau4.Location = F10 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F11 And pb_blau4.Location = F11 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F12 And pb_blau4.Location = F12 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F13 And pb_blau4.Location = F13 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F14 And pb_blau4.Location = F14 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F15 And pb_blau4.Location = F15 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F16 And pb_blau4.Location = F16 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F17 And pb_blau4.Location = F17 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F18 And pb_blau4.Location = F18 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F19 And pb_blau4.Location = F19 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F20 And pb_blau4.Location = F20 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F21 And pb_blau4.Location = F21 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F22 And pb_blau4.Location = F22 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F23 And pb_blau4.Location = F23 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F24 And pb_blau4.Location = F24 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F25 And pb_blau4.Location = F25 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F26 And pb_blau4.Location = F26 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F27 And pb_blau4.Location = F27 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F28 And pb_blau4.Location = F28 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F29 And pb_blau4.Location = F29 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F30 And pb_blau4.Location = F30 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F31 And pb_blau4.Location = F31 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F32 And pb_blau4.Location = F32 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F33 And pb_blau4.Location = F33 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F34 And pb_blau4.Location = F34 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F35 And pb_blau4.Location = F35 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F36 And pb_blau4.Location = F36 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F37 And pb_blau4.Location = F37 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F38 And pb_blau4.Location = F38 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F39 And pb_blau4.Location = F39 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot2.Location = F40 And pb_blau4.Location = F40 And rb_rot2.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        End If

        If pb_rot3.Location = F1 And pb_blau1.Location = F1 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F2 And pb_blau1.Location = F2 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F3 And pb_blau1.Location = F3 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F4 And pb_blau1.Location = F4 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F5 And pb_blau1.Location = F5 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F6 And pb_blau1.Location = F6 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F7 And pb_blau1.Location = F7 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F8 And pb_blau1.Location = F8 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F9 And pb_blau1.Location = F9 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F10 And pb_blau1.Location = F10 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F11 And pb_blau1.Location = F11 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F12 And pb_blau1.Location = F12 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F13 And pb_blau1.Location = F13 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F14 And pb_blau1.Location = F14 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F15 And pb_blau1.Location = F15 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F16 And pb_blau1.Location = F16 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F17 And pb_blau1.Location = F17 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F18 And pb_blau1.Location = F18 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F19 And pb_blau1.Location = F19 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F20 And pb_blau1.Location = F20 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F21 And pb_blau1.Location = F21 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F22 And pb_blau1.Location = F22 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F23 And pb_blau1.Location = F23 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F24 And pb_blau1.Location = F24 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F25 And pb_blau1.Location = F25 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F26 And pb_blau1.Location = F26 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F27 And pb_blau1.Location = F27 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F28 And pb_blau1.Location = F28 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F29 And pb_blau1.Location = F29 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F30 And pb_blau1.Location = F30 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F31 And pb_blau1.Location = F31 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F32 And pb_blau1.Location = F32 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F33 And pb_blau1.Location = F33 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F34 And pb_blau1.Location = F34 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F35 And pb_blau1.Location = F35 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F36 And pb_blau1.Location = F36 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F37 And pb_blau1.Location = F37 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F38 And pb_blau1.Location = F38 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F39 And pb_blau1.Location = F39 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot3.Location = F40 And pb_blau1.Location = F40 And rb_rot3.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        End If

        If pb_rot3.Location = F1 And pb_blau2.Location = F1 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F2 And pb_blau2.Location = F2 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F3 And pb_blau2.Location = F3 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F4 And pb_blau2.Location = F4 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F5 And pb_blau2.Location = F5 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F6 And pb_blau2.Location = F6 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F7 And pb_blau2.Location = F7 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F8 And pb_blau2.Location = F8 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F9 And pb_blau2.Location = F9 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F10 And pb_blau2.Location = F10 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F11 And pb_blau2.Location = F11 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F12 And pb_blau2.Location = F12 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F13 And pb_blau2.Location = F13 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F14 And pb_blau2.Location = F14 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F15 And pb_blau2.Location = F15 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F16 And pb_blau2.Location = F16 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F17 And pb_blau2.Location = F17 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F18 And pb_blau2.Location = F18 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F19 And pb_blau2.Location = F19 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F20 And pb_blau2.Location = F20 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F21 And pb_blau2.Location = F21 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F22 And pb_blau2.Location = F22 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F23 And pb_blau2.Location = F23 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F24 And pb_blau2.Location = F24 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F25 And pb_blau2.Location = F25 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F26 And pb_blau2.Location = F26 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F27 And pb_blau2.Location = F27 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F28 And pb_blau2.Location = F28 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F29 And pb_blau2.Location = F29 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F30 And pb_blau2.Location = F30 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F31 And pb_blau2.Location = F31 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F32 And pb_blau2.Location = F32 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F33 And pb_blau2.Location = F33 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F34 And pb_blau2.Location = F34 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F35 And pb_blau2.Location = F35 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F36 And pb_blau2.Location = F36 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F37 And pb_blau2.Location = F37 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F38 And pb_blau2.Location = F38 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F39 And pb_blau2.Location = F39 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot3.Location = F40 And pb_blau2.Location = F40 And rb_rot3.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        End If

        If pb_rot3.Location = F1 And pb_blau3.Location = F1 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F2 And pb_blau3.Location = F2 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F3 And pb_blau3.Location = F3 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F4 And pb_blau3.Location = F4 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F5 And pb_blau3.Location = F5 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F6 And pb_blau3.Location = F6 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F7 And pb_blau3.Location = F7 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F8 And pb_blau3.Location = F8 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F9 And pb_blau3.Location = F9 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F10 And pb_blau3.Location = F10 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F11 And pb_blau3.Location = F11 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F12 And pb_blau3.Location = F12 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F13 And pb_blau3.Location = F13 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F14 And pb_blau3.Location = F14 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F15 And pb_blau3.Location = F15 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F16 And pb_blau3.Location = F16 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F17 And pb_blau3.Location = F17 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F18 And pb_blau3.Location = F18 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F19 And pb_blau3.Location = F19 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F20 And pb_blau3.Location = F20 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F21 And pb_blau3.Location = F21 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F22 And pb_blau3.Location = F22 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F23 And pb_blau3.Location = F23 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F24 And pb_blau3.Location = F24 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F25 And pb_blau3.Location = F25 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F26 And pb_blau3.Location = F26 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F27 And pb_blau3.Location = F27 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F28 And pb_blau3.Location = F28 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F29 And pb_blau3.Location = F29 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F30 And pb_blau3.Location = F30 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F31 And pb_blau3.Location = F31 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F32 And pb_blau3.Location = F32 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F33 And pb_blau3.Location = F33 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F34 And pb_blau3.Location = F34 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F35 And pb_blau3.Location = F35 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F36 And pb_blau3.Location = F36 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F37 And pb_blau3.Location = F37 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F38 And pb_blau3.Location = F38 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F39 And pb_blau3.Location = F39 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot3.Location = F40 And pb_blau3.Location = F40 And rb_rot3.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        End If

        If pb_rot3.Location = F1 And pb_blau4.Location = F1 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F2 And pb_blau4.Location = F2 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F3 And pb_blau4.Location = F3 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F4 And pb_blau4.Location = F4 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F5 And pb_blau4.Location = F5 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F6 And pb_blau4.Location = F6 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F7 And pb_blau4.Location = F7 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F8 And pb_blau4.Location = F8 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F9 And pb_blau4.Location = F9 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F10 And pb_blau4.Location = F10 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F11 And pb_blau4.Location = F11 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F12 And pb_blau4.Location = F12 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F13 And pb_blau4.Location = F13 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F14 And pb_blau4.Location = F14 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F15 And pb_blau4.Location = F15 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F16 And pb_blau4.Location = F16 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F17 And pb_blau4.Location = F17 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F18 And pb_blau4.Location = F18 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F19 And pb_blau4.Location = F19 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F20 And pb_blau4.Location = F20 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F21 And pb_blau4.Location = F21 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F22 And pb_blau4.Location = F22 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F23 And pb_blau4.Location = F23 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F24 And pb_blau4.Location = F24 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F25 And pb_blau4.Location = F25 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F26 And pb_blau4.Location = F26 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F27 And pb_blau4.Location = F27 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F28 And pb_blau4.Location = F28 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F29 And pb_blau4.Location = F29 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F30 And pb_blau4.Location = F30 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F31 And pb_blau4.Location = F31 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F32 And pb_blau4.Location = F32 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F33 And pb_blau4.Location = F33 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F34 And pb_blau4.Location = F34 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F35 And pb_blau4.Location = F35 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F36 And pb_blau4.Location = F36 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F37 And pb_blau4.Location = F37 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F38 And pb_blau4.Location = F38 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F39 And pb_blau4.Location = F39 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot3.Location = F40 And pb_blau4.Location = F40 And rb_rot3.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        End If

        If pb_rot4.Location = F1 And pb_blau1.Location = F1 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F2 And pb_blau1.Location = F2 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F3 And pb_blau1.Location = F3 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F4 And pb_blau1.Location = F4 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F5 And pb_blau1.Location = F5 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F6 And pb_blau1.Location = F6 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F7 And pb_blau1.Location = F7 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F8 And pb_blau1.Location = F8 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F9 And pb_blau1.Location = F9 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F10 And pb_blau1.Location = F10 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F11 And pb_blau1.Location = F11 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F12 And pb_blau1.Location = F12 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F13 And pb_blau1.Location = F13 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F14 And pb_blau1.Location = F14 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F15 And pb_blau1.Location = F15 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F16 And pb_blau1.Location = F16 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F17 And pb_blau1.Location = F17 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F18 And pb_blau1.Location = F18 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F19 And pb_blau1.Location = F19 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F20 And pb_blau1.Location = F20 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F21 And pb_blau1.Location = F21 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F22 And pb_blau1.Location = F22 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F23 And pb_blau1.Location = F23 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F24 And pb_blau1.Location = F24 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F25 And pb_blau1.Location = F25 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F26 And pb_blau1.Location = F26 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F27 And pb_blau1.Location = F27 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F28 And pb_blau1.Location = F28 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F29 And pb_blau1.Location = F29 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F30 And pb_blau1.Location = F30 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F31 And pb_blau1.Location = F31 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F32 And pb_blau1.Location = F32 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F33 And pb_blau1.Location = F33 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F34 And pb_blau1.Location = F34 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F35 And pb_blau1.Location = F35 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F36 And pb_blau1.Location = F36 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F37 And pb_blau1.Location = F37 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F38 And pb_blau1.Location = F38 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F39 And pb_blau1.Location = F39 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        ElseIf pb_rot4.Location = F40 And pb_blau1.Location = F40 And rb_rot4.Checked = True Then
            pb_blau1.Location = BB1
            LäuferBlau1 = 0
        End If

        If pb_rot4.Location = F1 And pb_blau2.Location = F1 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F2 And pb_blau2.Location = F2 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F3 And pb_blau2.Location = F3 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F4 And pb_blau2.Location = F4 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F5 And pb_blau2.Location = F5 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F6 And pb_blau2.Location = F6 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F7 And pb_blau2.Location = F7 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F8 And pb_blau2.Location = F8 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F9 And pb_blau2.Location = F9 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F10 And pb_blau2.Location = F10 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F11 And pb_blau2.Location = F11 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F12 And pb_blau2.Location = F12 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F13 And pb_blau2.Location = F13 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F14 And pb_blau2.Location = F14 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F15 And pb_blau2.Location = F15 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F16 And pb_blau2.Location = F16 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F17 And pb_blau2.Location = F17 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F18 And pb_blau2.Location = F18 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F19 And pb_blau2.Location = F19 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F20 And pb_blau2.Location = F20 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F21 And pb_blau2.Location = F21 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F22 And pb_blau2.Location = F22 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F23 And pb_blau2.Location = F23 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F24 And pb_blau2.Location = F24 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F25 And pb_blau2.Location = F25 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F26 And pb_blau2.Location = F26 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F27 And pb_blau2.Location = F27 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F28 And pb_blau2.Location = F28 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F29 And pb_blau2.Location = F29 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F30 And pb_blau2.Location = F30 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F31 And pb_blau2.Location = F31 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F32 And pb_blau2.Location = F32 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F33 And pb_blau2.Location = F33 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F34 And pb_blau2.Location = F34 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F35 And pb_blau2.Location = F35 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F36 And pb_blau2.Location = F36 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F37 And pb_blau2.Location = F37 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F38 And pb_blau2.Location = F38 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F39 And pb_blau2.Location = F39 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        ElseIf pb_rot4.Location = F40 And pb_blau2.Location = F40 And rb_rot4.Checked = True Then
            pb_blau2.Location = BB1
            LäuferBlau2 = 0
        End If

        If pb_rot4.Location = F1 And pb_blau3.Location = F1 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F2 And pb_blau3.Location = F2 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F3 And pb_blau3.Location = F3 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F4 And pb_blau3.Location = F4 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F5 And pb_blau3.Location = F5 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F6 And pb_blau3.Location = F6 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F7 And pb_blau3.Location = F7 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F8 And pb_blau3.Location = F8 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F9 And pb_blau3.Location = F9 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F10 And pb_blau3.Location = F10 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F11 And pb_blau3.Location = F11 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F12 And pb_blau3.Location = F12 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F13 And pb_blau3.Location = F13 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F14 And pb_blau3.Location = F14 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F15 And pb_blau3.Location = F15 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F16 And pb_blau3.Location = F16 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F17 And pb_blau3.Location = F17 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F18 And pb_blau3.Location = F18 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F19 And pb_blau3.Location = F19 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F20 And pb_blau3.Location = F20 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F21 And pb_blau3.Location = F21 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F22 And pb_blau3.Location = F22 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F23 And pb_blau3.Location = F23 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F24 And pb_blau3.Location = F24 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F25 And pb_blau3.Location = F25 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F26 And pb_blau3.Location = F26 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F27 And pb_blau3.Location = F27 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F28 And pb_blau3.Location = F28 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F29 And pb_blau3.Location = F29 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F30 And pb_blau3.Location = F30 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F31 And pb_blau3.Location = F31 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F32 And pb_blau3.Location = F32 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F33 And pb_blau3.Location = F33 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F34 And pb_blau3.Location = F34 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F35 And pb_blau3.Location = F35 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F36 And pb_blau3.Location = F36 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F37 And pb_blau3.Location = F37 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F38 And pb_blau3.Location = F38 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F39 And pb_blau3.Location = F39 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        ElseIf pb_rot4.Location = F40 And pb_blau3.Location = F40 And rb_rot4.Checked = True Then
            pb_blau3.Location = BB1
            LäuferBlau3 = 0
        End If

        If pb_rot4.Location = F1 And pb_blau4.Location = F1 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F2 And pb_blau4.Location = F2 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F3 And pb_blau4.Location = F3 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F4 And pb_blau4.Location = F4 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F5 And pb_blau4.Location = F5 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F6 And pb_blau4.Location = F6 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F7 And pb_blau4.Location = F7 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F8 And pb_blau4.Location = F8 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F9 And pb_blau4.Location = F9 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F10 And pb_blau4.Location = F10 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F11 And pb_blau4.Location = F11 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F12 And pb_blau4.Location = F12 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F13 And pb_blau4.Location = F13 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F14 And pb_blau4.Location = F14 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F15 And pb_blau4.Location = F15 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F16 And pb_blau4.Location = F16 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F17 And pb_blau4.Location = F17 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F18 And pb_blau4.Location = F18 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F19 And pb_blau4.Location = F19 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F20 And pb_blau4.Location = F20 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F21 And pb_blau4.Location = F21 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F22 And pb_blau4.Location = F22 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F23 And pb_blau4.Location = F23 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F24 And pb_blau4.Location = F24 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F25 And pb_blau4.Location = F25 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F26 And pb_blau4.Location = F26 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F27 And pb_blau4.Location = F27 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F28 And pb_blau4.Location = F28 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F29 And pb_blau4.Location = F29 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F30 And pb_blau4.Location = F30 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F31 And pb_blau4.Location = F31 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F32 And pb_blau4.Location = F32 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F33 And pb_blau4.Location = F33 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F34 And pb_blau4.Location = F34 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F35 And pb_blau4.Location = F35 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F36 And pb_blau4.Location = F36 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F37 And pb_blau4.Location = F37 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F38 And pb_blau4.Location = F38 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F39 And pb_blau4.Location = F39 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        ElseIf pb_rot4.Location = F40 And pb_blau4.Location = F40 And rb_rot4.Checked = True Then
            pb_blau4.Location = BB1
            LäuferBlau4 = 0
        End If

        'Bis hierhinn alles gemacht

        If pb_blau1.Location = F1 And pb_rot1.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F2 And pb_rot1.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F3 And pb_rot1.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F4 And pb_rot1.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F5 And pb_rot1.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F6 And pb_rot1.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F7 And pb_rot1.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F8 And pb_rot1.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F9 And pb_rot1.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F10 And pb_rot1.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F11 And pb_rot1.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F12 And pb_rot1.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F13 And pb_rot1.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F14 And pb_rot1.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F15 And pb_rot1.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F16 And pb_rot1.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F17 And pb_rot1.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F18 And pb_rot1.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F19 And pb_rot1.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F20 And pb_rot1.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F21 And pb_rot1.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F22 And pb_rot1.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F23 And pb_rot1.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F24 And pb_rot1.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F25 And pb_rot1.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F26 And pb_rot1.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F27 And pb_rot1.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F28 And pb_rot1.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F29 And pb_rot1.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F30 And pb_rot1.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F31 And pb_rot1.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F32 And pb_rot1.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F33 And pb_rot1.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F34 And pb_rot1.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F35 And pb_rot1.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F36 And pb_rot1.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F37 And pb_rot1.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F38 And pb_rot1.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F39 And pb_rot1.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F40 And pb_rot1.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If

        If pb_blau1.Location = F1 And pb_rot2.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F2 And pb_rot2.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F3 And pb_rot2.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F4 And pb_rot2.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F5 And pb_rot2.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F6 And pb_rot2.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F7 And pb_rot2.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F8 And pb_rot2.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F9 And pb_rot2.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F10 And pb_rot2.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F11 And pb_rot2.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F12 And pb_rot2.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F13 And pb_rot2.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F14 And pb_rot2.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F15 And pb_rot2.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F16 And pb_rot2.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F17 And pb_rot2.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F18 And pb_rot2.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F19 And pb_rot2.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F20 And pb_rot2.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F21 And pb_rot2.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F22 And pb_rot2.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F23 And pb_rot2.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F24 And pb_rot2.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F25 And pb_rot2.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F26 And pb_rot2.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F27 And pb_rot2.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F28 And pb_rot2.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F29 And pb_rot2.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F30 And pb_rot2.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F31 And pb_rot2.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F32 And pb_rot2.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F33 And pb_rot2.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F34 And pb_rot2.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F35 And pb_rot2.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F36 And pb_rot2.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F37 And pb_rot2.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F38 And pb_rot2.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F39 And pb_rot2.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F40 And pb_rot2.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If

        If pb_blau1.Location = F1 And pb_rot3.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F2 And pb_rot3.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F3 And pb_rot3.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F4 And pb_rot3.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F5 And pb_rot3.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F6 And pb_rot3.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F7 And pb_rot3.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F8 And pb_rot3.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F9 And pb_rot3.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F10 And pb_rot3.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F11 And pb_rot3.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F12 And pb_rot3.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F13 And pb_rot3.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F14 And pb_rot3.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F15 And pb_rot3.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F16 And pb_rot3.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F17 And pb_rot3.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F18 And pb_rot3.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F19 And pb_rot3.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F20 And pb_rot3.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F21 And pb_rot3.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F22 And pb_rot3.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F23 And pb_rot3.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F24 And pb_rot3.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F25 And pb_rot3.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F26 And pb_rot3.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F27 And pb_rot3.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F28 And pb_rot3.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F29 And pb_rot3.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F30 And pb_rot3.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F31 And pb_rot3.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F32 And pb_rot3.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F33 And pb_rot3.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F34 And pb_rot3.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F35 And pb_rot3.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F36 And pb_rot3.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F37 And pb_rot3.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F38 And pb_rot3.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F39 And pb_rot3.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F40 And pb_rot3.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If

        If pb_blau1.Location = F1 And pb_rot4.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F2 And pb_rot4.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F3 And pb_rot4.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F4 And pb_rot4.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F5 And pb_rot4.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F6 And pb_rot4.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F7 And pb_rot4.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F8 And pb_rot4.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F9 And pb_rot4.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F10 And pb_rot4.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F11 And pb_rot4.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F12 And pb_rot4.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F13 And pb_rot4.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F14 And pb_rot4.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F15 And pb_rot4.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F16 And pb_rot4.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F17 And pb_rot4.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F18 And pb_rot4.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F19 And pb_rot4.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F20 And pb_rot4.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F21 And pb_rot4.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F22 And pb_rot4.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F23 And pb_rot4.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F24 And pb_rot4.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F25 And pb_rot4.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F26 And pb_rot4.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F27 And pb_rot4.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F28 And pb_rot4.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F29 And pb_rot4.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F30 And pb_rot4.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F31 And pb_rot4.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F32 And pb_rot4.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F33 And pb_rot4.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F34 And pb_rot4.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F35 And pb_rot4.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F36 And pb_rot4.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F37 And pb_rot4.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F38 And pb_rot4.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F39 And pb_rot4.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau1.Location = F40 And pb_rot4.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If

        If pb_blau2.Location = F1 And pb_rot1.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F2 And pb_rot1.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F3 And pb_rot1.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F4 And pb_rot1.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F5 And pb_rot1.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F6 And pb_rot1.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F7 And pb_rot1.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F8 And pb_rot1.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F9 And pb_rot1.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F10 And pb_rot1.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F11 And pb_rot1.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F12 And pb_rot1.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F13 And pb_rot1.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F14 And pb_rot1.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F15 And pb_rot1.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F16 And pb_rot1.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F17 And pb_rot1.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F18 And pb_rot1.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F19 And pb_rot1.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F20 And pb_rot1.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F21 And pb_rot1.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F22 And pb_rot1.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F23 And pb_rot1.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F24 And pb_rot1.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F25 And pb_rot1.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F26 And pb_rot1.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F27 And pb_rot1.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F28 And pb_rot1.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F29 And pb_rot1.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F30 And pb_rot1.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F31 And pb_rot1.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F32 And pb_rot1.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F33 And pb_rot1.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F34 And pb_rot1.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F35 And pb_rot1.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F36 And pb_rot1.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F37 And pb_rot1.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F38 And pb_rot1.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F39 And pb_rot1.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F40 And pb_rot1.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If

        If pb_blau2.Location = F1 And pb_rot2.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F2 And pb_rot2.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F3 And pb_rot2.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F4 And pb_rot2.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F5 And pb_rot2.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F6 And pb_rot2.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F7 And pb_rot2.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F8 And pb_rot2.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F9 And pb_rot2.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F10 And pb_rot2.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F11 And pb_rot2.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F12 And pb_rot2.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F13 And pb_rot2.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F14 And pb_rot2.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F15 And pb_rot2.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F16 And pb_rot2.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F17 And pb_rot2.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F18 And pb_rot2.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F19 And pb_rot2.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F20 And pb_rot2.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F21 And pb_rot2.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F22 And pb_rot2.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F23 And pb_rot2.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F24 And pb_rot2.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F25 And pb_rot2.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F26 And pb_rot2.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F27 And pb_rot2.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F28 And pb_rot2.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F29 And pb_rot2.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F30 And pb_rot2.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F31 And pb_rot2.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F32 And pb_rot2.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F33 And pb_rot2.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F34 And pb_rot2.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F35 And pb_rot2.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F36 And pb_rot2.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F37 And pb_rot2.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F38 And pb_rot2.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F39 And pb_rot2.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F40 And pb_rot2.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If

        If pb_blau2.Location = F1 And pb_rot3.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F2 And pb_rot3.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F3 And pb_rot3.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F4 And pb_rot3.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F5 And pb_rot3.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F6 And pb_rot3.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F7 And pb_rot3.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F8 And pb_rot3.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F9 And pb_rot3.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F10 And pb_rot3.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F11 And pb_rot3.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F12 And pb_rot3.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F13 And pb_rot3.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F14 And pb_rot3.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F15 And pb_rot3.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F16 And pb_rot3.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F17 And pb_rot3.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F18 And pb_rot3.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F19 And pb_rot3.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F20 And pb_rot3.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F21 And pb_rot3.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F22 And pb_rot3.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F23 And pb_rot3.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F24 And pb_rot3.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F25 And pb_rot3.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F26 And pb_rot3.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F27 And pb_rot3.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F28 And pb_rot3.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F29 And pb_rot3.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F30 And pb_rot3.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F31 And pb_rot3.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F32 And pb_rot3.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F33 And pb_rot3.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F34 And pb_rot3.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F35 And pb_rot3.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F36 And pb_rot3.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F37 And pb_rot3.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F38 And pb_rot3.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F39 And pb_rot3.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F40 And pb_rot3.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If

        If pb_blau2.Location = F1 And pb_rot4.Location = F1 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F2 And pb_rot4.Location = F2 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F3 And pb_rot4.Location = F3 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F4 And pb_rot4.Location = F4 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F5 And pb_rot4.Location = F5 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F6 And pb_rot4.Location = F6 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F7 And pb_rot4.Location = F7 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F8 And pb_rot4.Location = F8 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F9 And pb_rot4.Location = F9 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F10 And pb_rot4.Location = F10 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F11 And pb_rot4.Location = F11 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F12 And pb_rot4.Location = F12 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F13 And pb_rot4.Location = F13 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F14 And pb_rot4.Location = F14 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F15 And pb_rot4.Location = F15 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F16 And pb_rot4.Location = F16 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F17 And pb_rot4.Location = F17 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F18 And pb_rot4.Location = F18 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F19 And pb_rot4.Location = F19 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F20 And pb_rot4.Location = F20 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F21 And pb_rot4.Location = F21 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F22 And pb_rot4.Location = F22 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F23 And pb_rot4.Location = F23 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F24 And pb_rot4.Location = F24 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F25 And pb_rot4.Location = F25 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F26 And pb_rot4.Location = F26 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F27 And pb_rot4.Location = F27 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F28 And pb_rot4.Location = F28 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F29 And pb_rot4.Location = F29 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F30 And pb_rot4.Location = F30 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F31 And pb_rot4.Location = F31 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F32 And pb_rot4.Location = F32 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F33 And pb_rot4.Location = F33 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F34 And pb_rot4.Location = F34 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F35 And pb_rot4.Location = F35 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F36 And pb_rot4.Location = F36 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F37 And pb_rot4.Location = F37 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F38 And pb_rot4.Location = F38 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F39 And pb_rot4.Location = F39 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        ElseIf pb_blau2.Location = F40 And pb_rot4.Location = F40 And rb_blau1.Checked = True Then
            pb_rot1.Location = RB1
            LäuferRot1 = 0
        End If







    End Sub

    Private Sub cmd_würfel_Click(sender As Object, e As EventArgs) Handles cmd_würfel.Click
        Dim rng As New Random()
        lbl_würfel.Text = rng.Next(1, 7).ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_start.Click



        'Anzahl der Spieler Bestimmen

        If rb_2player.Checked = True Then

            Dim RB1 As New Point(939, 27)   'Punkte der Roten Base
            Dim RB2 As New Point(983, 27)
            Dim RB3 As New Point(939, 71)
            Dim RB4 As New Point(983, 71)

            Dim BB1 As New Point(939, 510)  'Punkte der Blauen Base
            Dim BB2 As New Point(983, 510)
            Dim BB3 As New Point(939, 554)
            Dim BB4 As New Point(983, 554)

            cmd_walk.Visible = True
            cmd_würfel.Visible = True
            lbl_würfel.Visible = True
            gb_spielfiguren.Visible = True
            cmd_restart.Visible = True

            lbl_würfel.Text = "Würfelanzahl"

            cmd_start.Visible = False
            rb_2player.Visible = False
            rb_3player.Visible = False
            rb_4player.Visible = False

            rb_blau1.Visible = True
            rb_blau2.Visible = True
            rb_blau3.Visible = True
            rb_blau4.Visible = True
            rb_rot1.Visible = True
            rb_rot2.Visible = True
            rb_rot3.Visible = True
            rb_rot4.Visible = True

            pb_rot1.Visible = True
            pb_rot2.Visible = True
            pb_rot3.Visible = True
            pb_rot4.Visible = True

            pb_blau1.Visible = True
            pb_blau2.Visible = True
            pb_blau3.Visible = True
            pb_blau4.Visible = True

            pb_blau1.Location = BB1
            pb_blau2.Location = BB2
            pb_blau3.Location = BB3
            pb_blau4.Location = BB4

            pb_rot1.Location = RB1
            pb_rot2.Location = RB2
            pb_rot3.Location = RB3
            pb_rot4.Location = RB4

        ElseIf rb_3player.Checked = True Then

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

            cmd_walk.Visible = True
            cmd_würfel.Visible = True
            lbl_würfel.Visible = True
            gb_spielfiguren.Visible = True
            cmd_restart.Visible = True

            lbl_würfel.Text = "Würfelanzahl"

            cmd_start.Visible = False
            rb_2player.Visible = False
            rb_3player.Visible = False
            rb_4player.Visible = False

            rb_blau1.Visible = True
            rb_blau2.Visible = True
            rb_blau3.Visible = True
            rb_blau4.Visible = True
            rb_rot1.Visible = True
            rb_rot2.Visible = True
            rb_rot3.Visible = True
            rb_rot4.Visible = True
            rb_gelb1.Visible = True
            rb_gelb2.Visible = True
            rb_gelb3.Visible = True
            rb_gelb4.Visible = True

            pb_rot1.Visible = True
            pb_rot2.Visible = True
            pb_rot3.Visible = True
            pb_rot4.Visible = True

            pb_blau1.Visible = True
            pb_blau2.Visible = True
            pb_blau3.Visible = True
            pb_blau4.Visible = True

            pb_gelb1.Visible = True
            pb_gelb2.Visible = True
            pb_gelb3.Visible = True
            pb_gelb4.Visible = True

            pb_blau1.Location = BB1
            pb_blau2.Location = BB2
            pb_blau3.Location = BB3
            pb_blau4.Location = BB4

            pb_rot1.Location = RB1
            pb_rot2.Location = RB2
            pb_rot3.Location = RB3
            pb_rot4.Location = RB4

            pb_gelb1.Location = YB1
            pb_gelb2.Location = YB2
            pb_gelb3.Location = YB3
            pb_gelb4.Location = YB4

        ElseIf rb_4player.Checked = True Then

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

            cmd_walk.Visible = True
            cmd_würfel.Visible = True
            lbl_würfel.Visible = True
            gb_spielfiguren.Visible = True
            cmd_restart.Visible = True

            lbl_würfel.Text = "Würfelanzahl"

            cmd_start.Visible = False
            rb_2player.Visible = False
            rb_3player.Visible = False
            rb_4player.Visible = False

            rb_blau1.Visible = True
            rb_blau2.Visible = True
            rb_blau3.Visible = True
            rb_blau4.Visible = True
            rb_rot1.Visible = True
            rb_rot2.Visible = True
            rb_rot3.Visible = True
            rb_rot4.Visible = True
            rb_gelb1.Visible = True
            rb_gelb2.Visible = True
            rb_gelb3.Visible = True
            rb_gelb4.Visible = True
            rb_grün1.Visible = True
            rb_grün2.Visible = True
            rb_grün3.Visible = True
            rb_grün4.Visible = True

            pb_rot1.Visible = True
            pb_rot2.Visible = True
            pb_rot3.Visible = True
            pb_rot4.Visible = True

            pb_blau1.Visible = True
            pb_blau2.Visible = True
            pb_blau3.Visible = True
            pb_blau4.Visible = True

            pb_gelb1.Visible = True
            pb_gelb2.Visible = True
            pb_gelb3.Visible = True
            pb_gelb4.Visible = True

            pb_grün1.Visible = True
            pb_grün2.Visible = True
            pb_grün3.Visible = True
            pb_grün4.Visible = True

            pb_blau1.Location = BB1
            pb_blau2.Location = BB2
            pb_blau3.Location = BB3
            pb_blau4.Location = BB4

            pb_rot1.Location = RB1
            pb_rot2.Location = RB2
            pb_rot3.Location = RB3
            pb_rot4.Location = RB4

            pb_gelb1.Location = YB1
            pb_gelb2.Location = YB2
            pb_gelb3.Location = YB3
            pb_gelb4.Location = YB4

            pb_grün1.Location = GB1
            pb_grün2.Location = GB2
            pb_grün3.Location = GB3
            pb_grün4.Location = GB4

        End If

    End Sub

    Private Sub cmd_restart_Click(sender As Object, e As EventArgs) Handles cmd_restart.Click

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

        cmd_walk.Visible = False
        cmd_würfel.Visible = False
        lbl_würfel.Visible = False
        gb_spielfiguren.Visible = False
        cmd_restart.Visible = False

        cmd_start.Visible = True
        rb_2player.Visible = True
        rb_3player.Visible = True
        rb_4player.Visible = True

        rb_blau1.Visible = False
        rb_blau2.Visible = False
        rb_blau3.Visible = False
        rb_blau4.Visible = False
        rb_rot1.Visible = False
        rb_rot2.Visible = False
        rb_rot3.Visible = False
        rb_rot4.Visible = False
        rb_gelb1.Visible = False
        rb_gelb2.Visible = False
        rb_gelb3.Visible = False
        rb_gelb4.Visible = False
        rb_grün1.Visible = False
        rb_grün2.Visible = False
        rb_grün3.Visible = False
        rb_grün4.Visible = False

        pb_rot1.Visible = False
        pb_rot2.Visible = False
        pb_rot3.Visible = False
        pb_rot4.Visible = False

        pb_blau1.Visible = False
        pb_blau2.Visible = False
        pb_blau3.Visible = False
        pb_blau4.Visible = False

        pb_gelb1.Visible = False
        pb_gelb2.Visible = False
        pb_gelb3.Visible = False
        pb_gelb4.Visible = False

        pb_grün1.Visible = False
        pb_grün2.Visible = False
        pb_grün3.Visible = False
        pb_grün4.Visible = False

        pb_blau1.Location = BB1
        pb_blau2.Location = BB2
        pb_blau3.Location = BB3
        pb_blau4.Location = BB4

        pb_rot1.Location = RB1
        pb_rot2.Location = RB2
        pb_rot3.Location = RB3
        pb_rot4.Location = RB4

        pb_gelb1.Location = YB1
        pb_gelb2.Location = YB2
        pb_gelb3.Location = YB3
        pb_gelb4.Location = YB4

        pb_grün1.Location = GB1
        pb_grün2.Location = GB2
        pb_grün3.Location = GB3
        pb_grün4.Location = GB4

        LäuferRot1 = 0
        LäuferRot2 = 0
        LäuferRot3 = 0
        LäuferRot4 = 0

        LäuferBlau1 = 0
        LäuferBlau2 = 0
        LäuferBlau3 = 0
        LäuferBlau4 = 0

        LäuferGelb1 = 0
        LäuferGelb2 = 0
        LäuferGelb3 = 0
        LäuferGelb4 = 0

        LäuferGrün1 = 0
        LäuferGrün2 = 0
        LäuferGrün3 = 0
        LäuferGrün4 = 0

    End Sub
End Class