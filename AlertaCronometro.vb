Public Class AlertaCronometro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LbMinutos.Text = "00"
        Form1.LbSegndos.Text = "00"
        Form1.GCRONOMETRO.BackColor = Color.YellowGreen
        Cronometro.BackColor = Color.YellowGreen
        Cronometro.LbMinutos.Text = "00"
        Cronometro.LbSegndos.Text = "00"
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.LbMinutos.Text = "00"
        Form1.LbSegndos.Text = "00"
        Form1.GCRONOMETRO.BackColor = Color.Transparent
        Form1.CmdIniciar.BackColor = Color.Transparent
        Form1.CmdIniciar.Text = ">>"
        Cronometro.BackColor = Color.White
        Cronometro.LbMinutos.Text = "00"
        Cronometro.LbSegndos.Text = "00"
        Me.Close()
    End Sub

    Private Sub AlertaCronometro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Nm As Integer = VarGlob.Contador Mod 2
        If (Nm <> 0) Then
            Talerta.Text = "Sr/ Sra " & Form1.CNombreTextBox.Text & " le agradezco por su paciencia, sigo en la gestión del caso. Le pido por favor " & Form1.ProcesarT1(Form1.TextBox2.Text) & " mas"
        Else
            Talerta.Text = "Sr/ Sra " & Form1.CNombreTextBox.Text & " le agradezco por su paciencia, en estos momentos el sistema se encuetra procesando la información por lo tanto le pido " & Form1.ProcesarT1(Form1.TextBox2.Text) & " mas, gracias"
        End If
        VarGlob.Contador = VarGlob.Contador + 1
    End Sub
End Class