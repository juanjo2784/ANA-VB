Public Class Fallas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VarGlob.TEspecial = CausaTextBox.Text
        Me.Close()
    End Sub

    Private Sub Fallas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (VarGlob.TEspecial <> Nothing) Then
            CausaTextBox.Text = VarGlob.TEspecial
        End If
    End Sub
End Class