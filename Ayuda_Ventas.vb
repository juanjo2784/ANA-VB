Imports System.Data.OleDb
Public Class Ayuda_Ventas

    Private Sub Ayuda_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tplan.Items.Add("Esencial Trio")
        Tplan.Items.Add("Esencial Plus Trio")
        Tplan.Items.Add("Ideal Trio  - GPON")
        Tplan.Items.Add("Ideal Plus Trio - GPON")
        Tplan.Items.Add("ONE TRIO")
        Tplan.Items.Add("ONE PLUS TRIO")
        Tplan.Items.Add("ONE ELITE TRIO")
        Tplan.Items.Add("Duo BA-TO")
        Tplan.Items.Add("Duo TV-TO")
        Tplan.Items.Add("Duo TV-BA")
        Tplan.Items.Add("Duo TV ONE - BA")
        Tplan.Items.Add("Individual")
        Tplan.Text = "Esencial Trio"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Function Serv(ByRef A As String) As String
        Dim R As String = VarGlob.P1
        If (A <> "Existente") Then
            R = VarGlob.P2
        End If
        Return R
    End Function
    Private Sub Tplan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tplan.SelectedIndexChanged
        Select Case Tplan.Text
            Case "Esencial Trio"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DEsencial, VarGlob.Esencial1)
                TxPromociones.Text = Serv(CTPlan.Text) & VarGlob.Esencial2 + vbNewLine + VarGlob.PUps
            Case "Esencial Plus Trio"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DEsenciaPlus, VarGlob.EsencialPlus1)
                TxPromociones.Text = Serv(CTPlan.Text) & VarGlob.EsencialPlus2 + vbNewLine + VarGlob.PUps
            Case "Ideal Trio  - GPON"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DIDeal, VarGlob.IDeal1)
                TxPromociones.Text = Serv(CTPlan.Text) & VarGlob.IDeal2 + vbNewLine + VarGlob.PUps
            Case "Ideal Plus Trio - GPON"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DIDealPlus, VarGlob.IDealPlus1)
                TxPromociones.Text = Serv(CTPlan.Text) & VarGlob.IDealPlus2 + vbNewLine + VarGlob.PUps
            Case "ONE TRIO"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DOne, VarGlob.One1)
                TxPromociones.Text = Serv(CTPlan.Text) & VarGlob.One2 + vbNewLine + VarGlob.PUps
            Case "ONE PLUS TRIO"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DOnePlus, VarGlob.OnePlus1)
                TxPromociones.Text = Serv(CTPlan.Text) & VarGlob.OnePlus2 + vbNewLine + VarGlob.PUps
            Case "ONE ELITE TRIO"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DElite, VarGlob.Elite1)
                TxPromociones.Text = Serv(CTPlan.Text) & VarGlob.Elite2 + vbNewLine + VarGlob.PUps
            Case "Duo TV-TO"
                Planes.Rows.Clear()
                Planes.Rows.Add(VarGlob.DTV1, VarGlob.DTVEsencial)
                Planes.Rows.Add(VarGlob.DEsenciaPlus, VarGlob.DTVEsencialPlus)
                Planes.Rows.Add(VarGlob.DIDealPlus, VarGlob.DTVIDeal)
                TxPromociones.Text = Serv(CTPlan.Text) & vbNewLine & VarGlob.PUps
            Case "Duo BA-TO"
                Planes.Rows.Clear()
                Planes.Rows.Add("Banda Ancha de 5@ + TO 50", VarGlob.DBT5)
                Planes.Rows.Add("Banda Ancha de 10@ + TO 50", VarGlob.DBT10)
                Planes.Rows.Add("Banda Ancha de 20@ + TO 50", VarGlob.DBT20)
                Planes.Rows.Add("Banda Ancha de 50@ + TO 50", VarGlob.DBT50)
                TxPromociones.Text = Serv(CTPlan.Text) & vbNewLine & VarGlob.PUps
            Case "Duo TV-BA"
                Planes.Rows.Clear()
                Planes.Rows.Add("Retadores - 5@  " & VarGlob.D1Esencial, "1-2: 94.131(5%)   3-4: 99.085")
                Planes.Rows.Add("Incumbentes 5@ " & VarGlob.D1Esencial, "1-2: 94.131(5%)   3-4: 109.085")
                Planes.Rows.Add("10@ " & VarGlob.D1EsenciaPlus, "1-4: 119.945   5-6: 140.805")
                Planes.Rows.Add("20@ " & VarGlob.D1EsenciaPlus, "1-4: 140.805   5-6: 161.665")
                TxPromociones.Text = Serv(CTPlan.Text) & vbNewLine & VarGlob.PUps
            Case "Duo TV ONE - BA"
                Planes.Rows.Clear()
                Planes.Rows.Add("ONE + 10 M " & VarGlob.One, "3-4: 140.805   5-6: 161.665")
                Planes.Rows.Add("ONE + 20 M " & VarGlob.One, "3-4: 161.665   5-6: 182.525")
                Planes.Rows.Add("ONE + 50 M " & VarGlob.One, "3-4: 250.320   5-6: 271.180")
                Planes.Rows.Add("ONE PLUS + 10 M" & VarGlob.OnePlus, "3-4: 182.525   5-6: 203.385")
                Planes.Rows.Add("ONE PLUS + 20 M" & VarGlob.OnePlus, "3-4: 192.955   5-6: 213.815")
                Planes.Rows.Add("ONE PLUS + 50 M" & VarGlob.OnePlus, "3-4: 292.040   5-6: 312.900")
                Planes.Rows.Add(VarGlob.D1Elite20, "3-4: 229.460   5-6: 250.320")
                Planes.Rows.Add(VarGlob.D1Elite50, "3-4: 328.545   5-6: 349.405")
                TxPromociones.Text = Serv(CTPlan.Text) & vbNewLine & VarGlob.PUps
            Case "Individual"
                Planes.Rows.Clear()
                Planes.Rows.Add("5 M", "1-4: 73.010   5-6: 83.400")
                Planes.Rows.Add("10 M", "1-4: 83.440   5-6: 93.870")
                Planes.Rows.Add("20 M", "1-4: 104.300   5-6: 114.730")
                Planes.Rows.Add("50 M", "1-4: 198.170   5-6: 219.030")
                Planes.Rows.Add("TO 50", "1-4: 41.720   5-6: 52.150")
                Planes.Rows.Add("Esencial: " & VarGlob.D1Esencial, "1-4: 57.365   5-6: 78.228")
                Planes.Rows.Add("Esencial Plus: " & VarGlob.D1EsenciaPlus, "1-4: 78.225   5-6: 99.085")
                Planes.Rows.Add("IDeal " & VarGlob.D1IDeal, "1-4: 99.085   5-6: 119.945")
                Planes.Rows.Add("IDeal Plus " & VarGlob.D1IDealPlus, "1-4: 119.945   5-6: 140.805")
                TxPromociones.Text = Serv(CTPlan.Text)
            Case Else
                Planes.Rows.Clear()
                Planes.Rows.Add("Sin Informacion")
        End Select
        Me.Planes.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Me.Planes.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        Planes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub

    Private Sub PromocionesVigentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesVigentesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/images/Portafolio_Hogares/BD_Ventas/Matriz_Ofertas_y_Promociones/Matriz_Ofertas_y_Promociones.htm")
    End Sub

    Private Sub DistanciasADSLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistanciasADSLToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/images/Base_Datos_Hogares/COBERTURA_ADSL/Tabla_Politicas_Asig.htm")
    End Sub

    Private Sub GuionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuionesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/index.php/venta-st/guiones")
    End Sub

    Private Sub TigoUNETrainersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TigoUNETrainersToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://www.tigounetrainers.com​")
    End Sub

    Private Sub GrillaDeCanalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrillaDeCanalesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/images/Base_Datos_Hogares/Grilla_Canales_UNE/index.html")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TAV.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TAV.Text = ComboBox2.Text
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        TAV.Text = ComboBox3.Text
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        TAV.Text = ComboBox4.Text
    End Sub
End Class