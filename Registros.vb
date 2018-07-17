Imports System.Data
Imports System.Data.OleDb
Public Class Registros

    Private Sub Registros_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim Tregistros As Integer = Llamadas.Rows.Count
        If (Tregistros > 0) Then
            If (Guardado = False) Then
                Label1.Text = Tregistros & " Registros"
            Else
                Label1.Text = Tregistros - 1 & " Registros"
            End If
        Else
            Label1.Text = "Sin Registros"
        End If
    End Sub

    Private Sub Registros_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.F4 Then
            Me.KeyPreview = False
            Me.Close()
        End If
    End Sub

    Private Sub Guion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.HIDe()
    End Sub
End Class