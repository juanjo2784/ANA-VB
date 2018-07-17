Module Conexion
    Public cnx As New OleDb.OleDbConnection("ProvIDer=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\AnaBD.accdb;Persist Security Info=False;")

    Public Sub coneccion()

        Try

            cnx.Open()

            MsgBox("Coneccion Exitosa")

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

End Module
