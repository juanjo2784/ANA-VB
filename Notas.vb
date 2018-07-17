Public Class Notas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Notas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox1.Select(TextBox1.Text.Length, 0)
        TextBox1.Focus()
    End Sub

    Private Sub Notas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        VarGlob.Notas = TextBox1.Text
    End Sub

    Private Sub Notas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.F4 Then
            Me.KeyPreview = False
            Me.Close()
        End If
    End Sub

    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (VarGlob.Notas <> "") Then
            TextBox1.Text = VarGlob.Notas
        End If
        TextBox1.Select(TextBox1.Text.Length, 0)
        TextBox1.Focus()
        Me.KeyPreview = True
    End Sub
    Private Sub CSerial_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

End Class