Public Class Alertas

    Private Sub TAlerta_TextChanged(sender As Object, e As EventArgs) Handles TAlerta.TextChanged

    End Sub

    Private Sub Alertas_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Alertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (CInt(Label1.Text) > (CInt(Label2.Text) + 3)) Then
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If (Label1.Text = Label2.Text) Then
            Me.Close()
        End If
    End Sub
End Class