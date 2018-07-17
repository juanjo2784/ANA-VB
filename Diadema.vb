Public Class Diadema

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxTimeD.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Diadema_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.F4 Then
            Me.KeyPreview = False
            Me.Close()
        End If
    End Sub

    Private Sub Diadema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (VarGlob.OIDO = "DERECHO") Then
            ComboBox1.Text = "IZQUIERDO"
        Else
            ComboBox1.Text = "DERECHO"
        End If
        TxTimeD.Text = VarGlob.TDIADEMA
        Me.KeyPreview = True
    End Sub

    Private Sub TxTimeD_LostFocus(sender As Object, e As EventArgs) Handles TxTimeD.LostFocus
        If (TxTimeD.Text <> Nothing) Then
            Dim TimeD As Integer = CInt(TxTimeD.Text)
            If (TimeD > 31) Then
                MsgBox("Es un valor muy alto, Máximo permitIDo 30")
                TxTimeD.Text = "30"
            End If
            VarGlob.TDIADEMA = 20
        Else
            MsgBox("Valor por defecto: se ha establecIDo 20 Minutos para cambio de oIDo en la diadema")
            VarGlob.TDIADEMA = CInt(TxTimeD.Text)
        End If

    End Sub

    Private Sub BtAplicar_Click(sender As Object, e As EventArgs) Handles BtAplicar.Click
        Try
            If (ComboBox1.Text <> Nothing And TxTimeD.Text <> Nothing) Then
                VarGlob.OIDO = ComboBox1.Text
                VarGlob.TDIADEMA = CInt(TxTimeD.Text)
            End If
            Form1.Text = Form1.CNombreTextBox.Text & " - [Prototipo Desarrollado por Juan Charry || Asistente Para Nuevos Agentes - ANA ] >> Diadema en OIDO " & VarGlob.OIDO
            Form1.Label4.Text = "00"
            Form1.Label9.Text = "00"
            If (VarGlob.OIDO = "DERECHO") Then
                Cronometro.Toido.BackColor = Color.Green
                Cronometro.Liz.BackColor = Color.Transparent
                Cronometro.Toido.Text = ">>"
                Cronometro.Liz.Text = ""
            Else
                Cronometro.Liz.BackColor = Color.Red
                Cronometro.Toido.BackColor = Color.Transparent
                Cronometro.Liz.Text = "<<"
                Cronometro.Toido.Text = ""
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("Error en la Aplicacion de las variables OIDo y Tiempo")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Timer1.Stop()
        Form1.Text = "Cronometro Detenido"
        Form1.Button11.Enabled = True
        Form1.Button11.Text = "Activar Cronometro"
        Form1.DPlantilla.Enabled = False
        Form1.Dubicacion.Enabled = False
        Form1.DBasicos.Enabled = False
        Form1.ValSMNET.Enabled = False
        Form1.DContacto.Enabled = False
        Form1.CmdIniciar.Text = "Desactivado"
        Me.Close()
    End Sub
End Class