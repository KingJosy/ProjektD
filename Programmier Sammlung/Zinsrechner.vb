Public Class Zinsrechner
    Dim K As Single
    Dim Z As Single
    Dim P As Single
    Dim T As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Z3.Visible = False
    End Sub

    Private Sub cmd_Zins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Zins.Click

        lbl_Z1.Visible = True
        lbl_Z2.Visible = True
        lbl_Z3.Visible = True
        lbl_Z4.Visible = True
        lbl_Z5.Visible = True
        txt_ZinsKapital.Visible = True
        txt_ZinsZeit.Visible = True
        txt_ZinsZinsessatz.Visible = True

        cmd_berechnenZins.Visible = True
        cmd_Zeit.Visible = False
        cmd_Kapital.Visible = False
        cmd_Zinsessatz.Visible = False
        cmd_neu.Visible = True

        cmd_Zins.Enabled = False

        lbl_1.Text = "Wird berechnet . . ."
        lbl_1.Location = New Point(110, 175)

    End Sub

    Private Sub cmd_Kapital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Kapital.Click

        lbl_K1.Visible = True
        lbl_K2.Visible = True
        lbl_K3.Visible = True
        lbl_K4.Visible = True
        lbl_K5.Visible = True
        txt_KapitalZeit.Visible = True
        txt_KapitalZins.Visible = True
        txt_KapitalZinsessatz.Visible = True

        cmd_berechnenKapital.Visible = True
        cmd_Zeit.Visible = False
        cmd_Zins.Visible = False
        cmd_Zinsessatz.Visible = False
        cmd_neu.Visible = True

        cmd_Kapital.Enabled = False

        lbl_1.Text = "Wird berechnet . . ."
        lbl_1.Location = New Point(110, 175)
        cmd_Kapital.Location = New Point(12, 161)

    End Sub

    Private Sub cmd_Zinsessatz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Zinsessatz.Click

        lbl_P1.Visible = True
        lbl_P2.Visible = True
        lbl_P3.Visible = True
        lbl_P4.Visible = True
        lbl_P5.Visible = True
        txt_ZinsessatzKapital.Visible = True
        txt_ZinsessatzZeit.Visible = True
        txt_ZinsessatzZins.Visible = True

        cmd_berechnenZinsessatz.Visible = True
        cmd_Zeit.Visible = False
        cmd_Kapital.Visible = False
        cmd_Zins.Visible = False
        cmd_neu.Visible = True

        cmd_Zinsessatz.Enabled = False

        lbl_1.Text = "Wird berechnet . . ."
        lbl_1.Location = New Point(110, 175)
        cmd_Zinsessatz.Location = New Point(12, 161)

    End Sub

    Private Sub cmd_Zeit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Zeit.Click

        lbl_T1.Visible = True
        lbl_T2.Visible = True
        lbl_T3.Visible = True
        lbl_T4.Visible = True
        lbl_T5.Visible = True
        txt_ZeitKapital.Visible = True
        txt_ZeitZins.Visible = True
        txt_ZeitZinsessatz.Visible = True

        cmd_berechnenZeit.Visible = True
        cmd_Zins.Visible = False
        cmd_Kapital.Visible = False
        cmd_Zinsessatz.Visible = False
        cmd_neu.Visible = True

        cmd_Zeit.Enabled = False

        lbl_1.Text = "Wird berechnet . . ."
        lbl_1.Location = New Point(110, 175)
        cmd_Zeit.Location = New Point(12, 161)

    End Sub

    Private Sub cmd_berechnenZins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_berechnenZins.Click

        ' Keine leeren Textfelder
        If txt_ZinsKapital.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_ZinsZeit.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_ZinsZinsessatz.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        ' Formel
        K = txt_ZinsKapital.Text
        T = txt_ZinsZeit.Text
        P = txt_ZinsZinsessatz.Text

        Z = K * P * T / 100 * 360
        txt_ErgebnisZins.Text = Z

        txt_ErgebnisZins.Visible = True
        lbl_Z6.Visible = True
        lbl_ergebnis.Visible = True

    End Sub

    Private Sub cmd_berechnenKapital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_berechnenKapital.Click

        ' Keine leeren Textfelder
        If txt_KapitalZins.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_KapitalZeit.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_KapitalZinsessatz.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        ' Formel
        Z = txt_KapitalZins.Text
        T = txt_KapitalZeit.Text
        P = txt_KapitalZinsessatz.Text

        K = Z * 100 * 360 / P * T
        txt_ErgebnisKapital.Text = K

        txt_ErgebnisKapital.Visible = True
        lbl_K6.Visible = True
        lbl_ergebnis.Visible = True

    End Sub

    Private Sub cmd_berechnenZinsessatz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_berechnenZinsessatz.Click

        ' Keine leeren Textfelder
        If txt_ZinsessatzKapital.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_ZinsessatzZeit.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_ZinsessatzZins.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        ' Formel
        Z = txt_ZinsessatzZins.Text
        T = txt_ZinsessatzZeit.Text
        K = txt_ZinsessatzKapital.Text

        P = Z * 100 * 360 / K * T
        txt_ErgebnisZinsessatz.Text = P

        txt_ErgebnisZinsessatz.Visible = True
        lbl_P6.Visible = True
        lbl_ergebnis.Visible = True

    End Sub

    Private Sub cmd_berechnenZeit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_berechnenZeit.Click

        ' Keine leeren Textfelder
        If txt_ZeitKapital.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_ZeitZins.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        If txt_ZeitZinsessatz.Text = "" Then
            MsgBox("Bitte ein Betrag eingeben!")
            Return
        End If

        ' Formel
        Z = txt_ZeitZins.Text
        P = txt_ZeitZinsessatz.Text
        K = txt_ZeitKapital.Text

        T = Z * 100 * 360 / K * P
        txt_ErgebnisZeit.Text = T

        txt_ErgebnisZeit.Visible = True
        lbl_T6.Visible = True
        lbl_ergebnis.Visible = True

    End Sub

    Private Sub cmd_neu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_neu.Click

        lbl_T1.Visible = False
        lbl_T2.Visible = False
        lbl_T3.Visible = False
        lbl_T4.Visible = False
        lbl_T5.Visible = False
        lbl_T6.Visible = False
        txt_ZeitKapital.Visible = False
        txt_ZeitZins.Visible = False
        txt_ZeitZinsessatz.Visible = False
        txt_ErgebnisZeit.Visible = False
        cmd_berechnenZeit.Visible = False
        lbl_ergebnis.Visible = False

        lbl_P1.Visible = False
        lbl_P2.Visible = False
        lbl_P3.Visible = False
        lbl_P4.Visible = False
        lbl_P5.Visible = False
        lbl_P6.Visible = False
        txt_ZinsessatzKapital.Visible = False
        txt_ZinsessatzZeit.Visible = False
        txt_ZinsessatzZins.Visible = False
        txt_ErgebnisZinsessatz.Visible = False
        cmd_berechnenZinsessatz.Visible = False
        lbl_ergebnis.Visible = False

        lbl_K1.Visible = False
        lbl_K2.Visible = False
        lbl_K3.Visible = False
        lbl_K4.Visible = False
        lbl_K5.Visible = False
        lbl_K6.Visible = False
        txt_KapitalZeit.Visible = False
        txt_KapitalZins.Visible = False
        txt_KapitalZinsessatz.Visible = False
        txt_ErgebnisKapital.Visible = False
        cmd_berechnenKapital.Visible = False
        lbl_ergebnis.Visible = False

        lbl_Z1.Visible = False
        lbl_Z2.Visible = False
        lbl_Z3.Visible = False
        lbl_Z4.Visible = False
        lbl_Z5.Visible = False
        lbl_Z6.Visible = False
        txt_ZinsKapital.Visible = False
        txt_ZinsZeit.Visible = False
        txt_ZinsZinsessatz.Visible = False
        txt_ErgebnisZins.Visible = False
        cmd_berechnenZins.Visible = False
        lbl_ergebnis.Visible = False

        cmd_Zins.Visible = True
        cmd_Kapital.Visible = True
        cmd_Zinsessatz.Visible = True
        cmd_Zeit.Visible = True
        cmd_neu.Visible = False

        cmd_Zins.Enabled = True
        cmd_Kapital.Enabled = True
        cmd_Zinsessatz.Enabled = True
        cmd_Zeit.Enabled = True

        lbl_1.Text = "Was soll berechnet werden?"
        lbl_1.Location = New Point(104, 128)

        cmd_Kapital.Location = New Point(107, 161)
        cmd_Zinsessatz.Location = New Point(202, 161)
        cmd_Zeit.Location = New Point(297, 161)

        txt_KapitalZeit.Text = ""
        txt_KapitalZins.Text = ""
        txt_KapitalZinsessatz.Text = ""
        txt_ZeitKapital.Text = ""
        txt_ZeitZins.Text = ""
        txt_ZeitZinsessatz.Text = ""
        txt_ZinsessatzKapital.Text = ""
        txt_ZinsessatzZeit.Text = ""
        txt_ZinsessatzZins.Text = ""
        txt_ZinsKapital.Text = ""
        txt_ZinsZeit.Text = ""
        txt_ZinsZinsessatz.Text = ""


    End Sub

    Private Sub cmd_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_end.Click
        Sammlung.Show()
        Me.Close()
    End Sub

    'Bestimmte Tasten freigegeben! Nur Zahlen!

    Private Sub txt_ZinsZeit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZinsZeit.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_Zinskapital_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZinsKapital.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ZinsZinsessatz_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZinsZinsessatz.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ZeitZins_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZeitZins.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ZeitKapital_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZeitKapital.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ZeitZinsessatz_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZeitZinsessatz.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_KapitalZins_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_KapitalZins.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_KapitalZeit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_KapitalZeit.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_KapitalZinsessatz_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_KapitalZinsessatz.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ZinsessatzZeit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZinsessatzZeit.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ZinsessatzKapital_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZinsessatzKapital.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ZinsessatzZins_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ZinsessatzZins.KeyPress
        If Not "1234567890".Contains(e.KeyChar) And Not Keys.Back = 8 Then
            e.Handled = True
        End If
    End Sub

End Class