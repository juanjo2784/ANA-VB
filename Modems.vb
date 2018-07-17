Public Class Modems


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Text = "TECHNICOLOR") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "CPE#XXXXXX")
            MODEMSData.Rows.Add("admin-UNE", "CM4CC3SS")
            MODEMSData.Rows.Add("", "admin")
            MODEMSData.Rows.Add("admin", "4CC3S0R3M0T0")
            MODEMSData.Rows.Add("admin", "ACCES0R3M0T0")
            MODEMSData.Rows.Add("4CC3S0UN3", "3NU4CC3S0CM")
            MODEMSData.Rows.Add("admin", "d3c0ntr0l")
            '*********************
        ElseIf (ComboBox1.Text = "Huawei HG552D" Or ComboBox1.Text = "Huawei HG530" Or ComboBox1.Text = "Thomson 510, 546, 780(Wifi), 585(Wifi), 580(Wifi)" Or ComboBox1.Text = "CPEsD-Link (DSL500B, DSL522B)") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "CPE#(6últimos#deNS)")
            MODEMSData.Rows.Add("admin", "admin")
            MODEMSData.Rows.Add("admin", "ACP-xxxx")
            MODEMSData.Rows.Add("admin", "Contrato de fenix")
            MODEMSData.Rows.Add("admin", "Cpe04Epm")
            '*********************
        ElseIf (ComboBox1.Text = "ZyXEL VGM 1312" Or ComboBox1.Text = "HITRON CDW-31235") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "CPE#(6últimos#deNS/MAC)")
            '*********************
        ElseIf (ComboBox1.Text = "CPEs Allied Telesyn AT-AR236E") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "ACP-xxxx")
            MODEMSData.Rows.Add("manager", "Friend")
            '*******************
        ElseIf (ComboBox1.Text = "CPEs Siemens Gigaset SX762 WLAN") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("", "CPE#XXXXXX")
            MODEMSData.Rows.Add("", "ACP-xxxx")
            MODEMSData.Rows.Add("", "d3c0ntr0l")
            '*********************
        ElseIf (ComboBox1.Text = "CPEs AMBIT U10C019 Wi-Fi") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "cableroot")
            '*******************
        ElseIf (ComboBox1.Text = "Thomson DCW725 WiFi") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("", "admin")
            MODEMSData.Rows.Add("admin", "4CC3S0R3M0T0")
            MODEMSData.Rows.Add("admin", "ACCES0R3M0T0")
            MODEMSData.Rows.Add("4CC3S0UN3", "3NU4CC3S0CM")
            MODEMSData.Rows.Add("admin", "d3c0ntr0l")
            MODEMSData.Rows.Add("admin-UN3", "CM4CC3SS")
            '*********************
        ElseIf (ComboBox1.Text = "Scientific Atlanta DPR2325 WiFi") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "W2402")
            '+++++++++++++++++++++++++++++++
        ElseIf (ComboBox1.Text = "Cisco") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "W2402")
            MODEMSData.Rows.Add("admin", "4CC3S0CL1")
            MODEMSData.Rows.Add("admin", "g3sti0nr3m0t4")
            MODEMSData.Rows.Add("gestionune", "g3sti0nr3m0t4")
            '+++++++++++++++++++++++++++++++
        ElseIf (ComboBox1.Text = "Thomsom DWG849") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "d3c0ntr0l")
            MODEMSData.Rows.Add("admin", "4CC3S0CL1")
            MODEMSData.Rows.Add("admin", "d3c0ntr0l")
            MODEMSData.Rows.Add("admin", "g3sti0nr3m0t4")
            MODEMSData.Rows.Add("", "admin")
            '+++++++++++++++++++++++++++++++
        ElseIf (ComboBox1.Text = "Cisco DPC3825") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "d3c0ntr0l")
            MODEMSData.Rows.Add("gestionune", "g3sti0nr3m0t4")
            '+++++++++++++++++++++++++++++++
        ElseIf (ComboBox1.Text = "Ingreso a los Modem opcion advanced") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("gestionune", "g3sti0nr3m0t4")
            '+++++++++++++++++++++++++++++++
        ElseIf (ComboBox1.Text = "Thomsom DWG849") Then
            MODEMSData.Rows.Clear()
            MODEMSData.Rows.Add("admin", "4CC3S0CL1")
        End If
    End Sub

    Private Sub Modems_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.F4 Then
            Me.KeyPreview = False
            Me.Close()
        End If
    End Sub

    Private Sub Modems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Mascara de Subred: 255.255.255.0" & vbNewLine & "Puerta de Enlace: 192.168.1.254" & _
            vbNewLine & "DNS Primario: 200.13.249.101" & vbNewLine & "DNS Secundario: 200.13.224.254" & vbNewLine & vbNewLine & _
            "DNS PARA CONSOLAS DE VIDEO JUEGOS " & vbNewLine & "DNS Primario: 208.122.23.23" & vbNewLine & "DNS Secundario: 208.122.23.22"
        ComboBox1.Items.Add("TECHNICOLOR")
        ComboBox1.Items.Add("HITRON CDW-31235")
        ComboBox1.Items.Add("Huawei HG552D")
        ComboBox1.Items.Add("Huawei HG530")
        ComboBox1.Items.Add("Cisco")
        ComboBox1.Items.Add("Cisco DPC3825")
        ComboBox1.Items.Add("Thomson 510, 546, 780(Wifi), 585(Wifi), 580(Wifi)")
        ComboBox1.Items.Add("Thomsom DWG849")
        ComboBox1.Items.Add("Thomson DCW725 WiFi")
        ComboBox1.Items.Add("Thomsom DWG849")
        ComboBox1.Items.Add("CPEsD-Link (DSL500B, DSL522B)")
        ComboBox1.Items.Add("CPEs Allied Telesyn AT-AR236E")
        ComboBox1.Items.Add("CPEs Siemens Gigaset SX762 WLAN ")
        ComboBox1.Items.Add("ZyXEL VGM 1312")
        ComboBox1.Items.Add("CPEs AMBIT U10C019 Wi-Fi")
        ComboBox1.Items.Add("Scientific Atlanta DPR2325 WiFi")
        ComboBox1.Items.Add("Ingreso a los Modem opcion advanced")
        Me.KeyPreview = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://puntosdecontacto/images/Soporte_Tecnico_Hogares/NUAC_ON/HTML/ClavesCPEYCMY4G.html")
    End Sub
End Class