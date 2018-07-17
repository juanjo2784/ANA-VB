Public Class IGENERAL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VarGlob.TEspecial = CausaTextBox.Text
        VarGlob.PWTS = Trim(TPWTS.Text)
        If (TPWTS.Text <> Nothing) Then
            Form1.Show()
            Cronometro.Show()
            Cronometro.BringToFront()
            Me.Close()
        Else
            MsgBox("Digita Tu Clave WTS")
            TPWTS.Focus()
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
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

End Class