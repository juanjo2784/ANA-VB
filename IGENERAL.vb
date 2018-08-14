Public Class IGENERAL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VarGlob.PRED = Trim(TPRED.Text)
        VarGlob.PWTS = Trim(TPWTS.Text)
        VarGlob.PSIEBEL = Trim(TPSIEBEL.Text)
        VarGlob.PCC = Trim(TPCC.Text)
        If (TPWTS.Text <> Nothing And TPRED.Text <> Nothing) Then
            Form1.Show()
            Cronometro.Show()
            Cronometro.BringToFront()
            Me.Close()
        Else
            If (TPWTS.Text = Nothing) Then
                MsgBox("Digita Tu Clave WTS")
                TPWTS.Focus()
            Else
                If (TPRED.Text = Nothing) Then
                    MsgBox("Digita Tu Clave de RED")
                    TPRED.Focus()
                ElseIf (TPSIEBEL.Text = Nothing) Then
                    MsgBox("Digita Tu Clave de Siebel")
                    TPSIEBEL.Focus()
                ElseIf (TPCC.Text = Nothing) Then
                    MsgBox("Digita Tu Clave de CC")
                    TPCC.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub IGENERAL_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TPWTS.Focus()
    End Sub

    Private Sub IGENERAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TPWTS.Focus()
        Label3.Text = " Hola " & Environment.UserName

        If (String.IsNullOrEmpty(VarGlob.PWTS) = False) Then
            TPWTS.Text = VarGlob.PWTS
        End If

        If (String.IsNullOrEmpty(VarGlob.PRED) = False) Then
            TPRED.Text = VarGlob.PRED
        End If

        If (String.IsNullOrEmpty(VarGlob.PSIEBEL) = False) Then
            TPSIEBEL.Text = VarGlob.PSIEBEL
        End If

        If (String.IsNullOrEmpty(VarGlob.PCC) = False) Then
            TPCC.Text = VarGlob.PCC
        End If
        If (String.IsNullOrEmpty(VarGlob.PWTS) Or String.IsNullOrEmpty(VarGlob.PRED) Or String.IsNullOrEmpty(VarGlob.PCC) Or String.IsNullOrEmpty(VarGlob.PSIEBEL)) Then
            Button2.Text = "Salir"
        Else
            Button2.Text = "Cerrar"
            Button3.Visible = False
        End If
        'Prueba()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (String.IsNullOrEmpty(VarGlob.PWTS) Or String.IsNullOrEmpty(VarGlob.PRED) Or String.IsNullOrEmpty(VarGlob.PCC) Or String.IsNullOrEmpty(VarGlob.PSIEBEL)) Then
            End
        Else
            Me.Close()
        End If

    End Sub


    Private Sub TPCC_TextChanged(sender As Object, e As EventArgs) Handles TPCC.TextChanged
        If (TPWTS.Text <> "" And TPCC.Text <> "" And TPRED.Text <> "" And TPSIEBEL.Text <> "") Then
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VarGlob.PRED = Trim(TPRED.Text)
        VarGlob.PWTS = Trim(TPWTS.Text)
        VarGlob.PSIEBEL = Trim(TPSIEBEL.Text)
        VarGlob.PCC = Trim(TPCC.Text)
        Form1.Show()
        Cronometro.Show()
        Cronometro.BringToFront()
        OpenPage("http://smnet.une.net.co:8080/smnet/", "j_username", "j_password", VarGlob.PWTS, "nextbutton")
        OpenIE("http://unecrm/ecommunications_esn/", "SWEUserName", "SWEPassword", VarGlob.PSIEBEL, "s_swepi_22")
        OpenIE("http://emt-wfowfm01:7001/wfo/control/dashboard_view", "username", "password", VarGlob.PRED, "loginToolbar")
        Me.Close()
    End Sub
End Class