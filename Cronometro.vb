Public Class Cronometro

    Private Sub Cronometro_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.NumPad1 Then
            Me.KeyPreview = False
            Form1.TextBox2.Text = "1"
            Form1.ICronometro()
        ElseIf e.Control And e.KeyCode = Keys.NumPad2 Then
            Me.KeyPreview = False
            Form1.TextBox2.Text = "2"
            Form1.ICronometro()
        ElseIf e.Control And e.KeyCode = Keys.NumPad3 Then
            Me.KeyPreview = False
            Form1.TextBox2.Text = "3"
            Form1.ICronometro()
        ElseIf e.KeyData = Keys.Control + Keys.M Then
            Me.KeyPreview = False
            Modems.Show()
        ElseIf e.KeyData = Keys.Control + Keys.H Then
            Me.KeyPreview = False
            Registros.Show()
            Registros.BringToFront()
        ElseIf e.KeyData = Keys.Control + Keys.W Then
            Me.KeyPreview = False
            Ayuda_Ventas.Show()
        ElseIf e.KeyData = Keys.Control + Keys.Y Then
            Me.KeyPreview = False
            Notas.Show()
            Notas.TextBox1.Focus()
        ElseIf e.KeyData = Keys.Control + Keys.I Then
            Me.KeyPreview = False
            Notas.Show()
            Notas.BringToFront()
        ElseIf e.KeyData = Keys.Control + Keys.D Then
            Me.KeyPreview = False
            Diadema.Show()
        ElseIf e.KeyData = Keys.Control + Keys.L Then
            Me.KeyPreview = False
            Form1.TNotas()
            Notas.Show()
        ElseIf e.Alt And e.KeyCode = Keys.NumPad1 Then
            Me.KeyPreview = False
            System.Diagnostics.Process.Start("cmd.exe", "/C echo WTS Elite - 10 -  &title WTS - Elite - & cmdkey /generic: TERMSRV/172.20.2.10 /user:EPMTELCO\" + Environment.UserName + " /pass:" + VarGlob.PWTS + " & mstsc /v:172.20.2.10")
        ElseIf e.Alt And e.KeyCode = Keys.NumPad2 Then
            Me.KeyPreview = False
            System.Diagnostics.Process.Start("cmd.exe", "/C echo WTS Nacional - 140 -  &title WTS - 172.20.2.140 - & cmdkey /generic: TERMSRV/172.20.2.140 /user:EPMTELCO\" + Environment.UserName + " /pass:" + VarGlob.PWTS + " &  mstsc /v:172.20.2.140")
        ElseIf e.Alt And e.KeyCode = Keys.NumPad3 Then
            Me.KeyPreview = False
            System.Diagnostics.Process.Start("cmd.exe", "/C echo WTS Nacional - 150 -  &title WTS - 172.20.2.150 - &  cmdkey /generic: TERMSRV/172.20.2.150 /user:EPMTELCO\" + Environment.UserName + " /pass:" + VarGlob.PWTS + " & mstsc /v:172.20.2.150")
        ElseIf e.Alt And e.KeyCode = Keys.NumPad4 Then
            Me.KeyPreview = False
            System.Diagnostics.Process.Start("cmd.exe", "/C echo WTS Nacional - 167 -  &title - 172.20.2.167 - WTS & cmdkey /generic: TERMSRV/172.20.2.167 /user:EPMTELCO\" + Environment.UserName + " /pass:" + VarGlob.PWTS + " & mstsc /v:172.20.2.167")
        End If
        Me.KeyPreview = True
    End Sub

    Private Sub Cronometro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NLlamada As String = "....."
        If (Form1.CNombreTextBox.Text <> "") Then
            NLlamada = Form1.CNombreTextBox.Text
        End If
        GBLlamada.BackColor = Form1.BackColor
        Me.Text = Form1.Momento(TimeOfDay.Hour) & " | " & NLlamada
        Toido.Text = VarGlob.OIDO
        If (VarGlob.OIDO = "DERECHO") Then
            Toido.BackColor = Color.Green
            Liz.BackColor = Color.Transparent
            Toido.Text = ">>"
            Liz.Text = ""
        Else
            Liz.BackColor = Color.Red
            Toido.BackColor = Color.Transparent
            Liz.Text = "<<"
            Toido.Text = ""
        End If
        Form1.txtProceso.Focus()

        Me.KeyPreview = True

    End Sub

    Private Sub Cronometro_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick, LbMinutos.Click, Label3.Click, LbSegndos.Click, GBLlamada.Click, Button3.Click
        If (Form1.CmdIniciar.Text = ">>") Then
            Form1.CmdIniciar.Text = "||"
            Form1.LbMinutos.Text = "00"
            Form1.LbSegndos.Text = "00"
            LbSegndos.Text = "00"
            LbMinutos.Text = "00"
            If (Form1.GVariables.contador = 0) Then
                MsgBox("Sr/ Sra " & Form1.CNombreTextBox.Text & " teniendo en cuenta toda la información que me brindó, voy a realizar una revisión y análisis completo de su caso. Le pido " & Form1.ProcesarT1(Form1.TextBox2.Text) & " para gestionar")
            Else
                Dim Nm As Integer = VarGlob.Contador Mod 2
                If (Nm <> 0) Then
                    MsgBox("Sr/ Sra " & Form1.CNombreTextBox.Text & " le agradezco por su paciencia, sigo en la gestión del caso. Le pido por favor " & Form1.ProcesarT1(Form1.TextBox2.Text) & " mas")
                Else
                    MsgBox("Sr/ Sra " & Form1.CNombreTextBox.Text & " le agradezco por su paciencia, en estos momentos el sistema se encuetra procesando la información por lo tanto le pido " & Form1.ProcesarT1(Form1.TextBox2.Text) & " mas, gracias")
                End If
            End If
            Form1.GVariables.contador = Form1.GVariables.contador + 1
        Else
            Form1.CmdIniciar.Text = ">>"
            Form1.CmdIniciar.BackColor = Color.White
            Form1.GCRONOMETRO.BackColor = Color.Transparent
            LbSegndos.Text = "00"
            LbMinutos.Text = "00"
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.TextBox2.Text = "1"
        Form1.ICronometro()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.TextBox2.Text = "2"
        Form1.ICronometro()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.TextBox2.Text = "3"
        Form1.ICronometro()
    End Sub

End Class