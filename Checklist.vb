Imports System.Drawing.Color
Imports System.Net.Mail
Public Class Checklist

    Friend WithEvents Tdeco As System.Windows.Forms.ComboBox
    Friend WithEvents Ttv As System.Windows.Forms.ComboBox
    Friend WithEvents LAPC1 As System.Windows.Forms.LinkLabel
    'Controls
    Private Rbutton1 As New RadioButton()
    Private Rbutton2 As New RadioButton()
    Private chkBox1 As New CheckBox()
    Private chkBox2 As New CheckBox()
    Private chkBox3 As New CheckBox()
    Private chkBox4 As New CheckBox()
    Private chkBox5 As New CheckBox()
    Private chkBox6 As New CheckBox()
    Private Combo1 As New ComboBox()
    Private Combo2 As New ComboBox()
    Private Boton As New Button()
    Private TextA As New TextBox()
    Public Class GVariables
        Public Shared MMM As String
        Public Shared LPC As String
        Public Shared NLIK As String
        Public Shared LPC2 As String
        Public Shared SPC As Integer = 0
        Public Shared TERRENO As Integer = 0
        Public Shared TRASFERENCIA As Integer = 0
        Public Shared OTRO As Integer = 0
        Public Shared TLLAMADAS As Integer = 0
        Public Shared rMovil As String
        Public Shared rFijo As String
        Public Shared rCiudad As String
        Public Shared OIDO As String = "DERECHO"
        Public Shared Saludo As String = "Buenos Dias "
    End Class
    Private Sub Checklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CServicio.Items.Add("INTERNET")
        CServicio.Items.Add("TV")
        CServicio.Items.Add("TELEFONO")
        CServicio.Items.Add("NETFLIX")
        CServicio.Items.Add("CORREO")
        CServicio.Items.Add("DTH")
        CServicio.Items.Add("BUZON")
        CServicio.Items.Add("BA-TV-TOIP/TO")
        CDiagnostico.Text = "FALLAS WIFI"
        FWIFI()

        CDiagnostico.Items.Add("PARAMETROS ALARMADOS")
        CDiagnostico.Items.Add("NO NAVEGA")
        CDiagnostico.Items.Add("MODEM NO SINCRONIZA")
        CDiagnostico.Items.Add("EQUIPO NO ENCIENDE")
        CDiagnostico.Items.Add("FALLA EQUIPO")
        CDiagnostico.Items.Add("EQUIPO SIN GESTION")
        CDiagnostico.Items.Add("FALLAS WIFI")
        CDiagnostico.Items.Add("CONF. WIFI/MODEM")
        CDiagnostico.Items.Add("INTERMITENCIA")
        CDiagnostico.Items.Add("LENTITUD")
        CDiagnostico.Items.Add("SIN IP")
        CDiagnostico.Items.Add("IP BASURA")
        CDiagnostico.Items.Add("CNX LIMITADA")
        CDiagnostico.Items.Add("PAGINAS ESPECIFICAS")
        CDiagnostico.Items.Add("CM DESENGANCHADO")
        VarGlob.Checklist = ""
        Form1.Tinteracion.Text = "OTROS"
    End Sub
    Private Sub CServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CServicio.SelectedIndexChanged
        If (CServicio.Text = "INTERNET") Then
            CDiagnostico.Items.Clear()
            CDiagnostico.Text = "FALLAS WIFI"
            FWIFI()
            CDiagnostico.Items.Add("PARAMETROS ALARMADOS")
            CDiagnostico.Items.Add("NO NAVEGA")
            CDiagnostico.Items.Add("MODEM NO SINCRONIZA")
            CDiagnostico.Items.Add("EQUIPO NO ENCIENDE")
            CDiagnostico.Items.Add("FALLA EQUIPO")
            CDiagnostico.Items.Add("EQUIPO SIN GESTION")
            CDiagnostico.Items.Add("FALLAS WIFI")
            CDiagnostico.Items.Add("CONF. WIFI/MODEM")
            CDiagnostico.Items.Add("INTERMITENCIA")
            CDiagnostico.Items.Add("LENTITUD")
            CDiagnostico.Items.Add("SIN IP")
            CDiagnostico.Items.Add("IP BASURA")
            CDiagnostico.Items.Add("CNX LIMITADA")
            If (CTecnologia.Text = "HFC") Then
                CDiagnostico.Items.Add("CM DESENGANCHADO")
            Else
                CDiagnostico.Items.Remove("CM DESENGANCHADO")
            End If
        ElseIf (CServicio.Text = "TV") Then
            CDiagnostico.Items.Clear()
            CDiagnostico.Text = "SIN PAQUETES / SN SEÑAL"
            VTV()
            CDiagnostico.Items.Add("PARAMETROS ALARMADOS")
            CDiagnostico.Items.Add("EQUIPO NO ENCIENDE")
            CDiagnostico.Items.Add("FALLA EQUIPO/CABLE")
            CDiagnostico.Items.Add("FALLA CONTROL")
            CDiagnostico.Items.Add("SIN PAQUETES / SN SEÑAL")
            CDiagnostico.Items.Add("MALA CALIDAD DE IMAGEN")
            If (CTecnologia.Text = "ADSL") Then
                CDiagnostico.Items.Add("FALLA IPTV")
            Else
                CDiagnostico.Items.Remove("FALLA IPTV")
            End If
            CDiagnostico.Items.Add("TV ANALOGA")
        ElseIf (CServicio.Text = "TELEFONO") Then
            CDiagnostico.Items.Clear()
            CDiagnostico.Text = "SIN TONO"
            SIN_TONO()
            CDiagnostico.Items.Add("PARAMETROS ALARMADOS")
            CDiagnostico.Items.Add("SIN TONO")
            CDiagnostico.Items.Add("SERVICIOS ESPECIALES")
            CDiagnostico.Items.Add("NO FUNCIONA TOIP")
            CDiagnostico.Items.Add("RUIDO EN LINEA")
            CDiagnostico.Items.Add("INTERMITENCIA VOZ")
        ElseIf (CServicio.Text = "DTH") Then
            CDiagnostico.Items.Clear()
            CDiagnostico.Text = "SIN PAQUETES / SN SEÑAL"
            VTV()
            CDiagnostico.Items.Add("EQUIPO NO ENCIENDE")
            CDiagnostico.Items.Add("FALLA CONTROL")
            CDiagnostico.Items.Add("SIN PAQUETES / SN SEÑAL")
            CDiagnostico.Items.Add("MALA CALIDAD DE IMAGEN")
        End If
        'VarlIDar pruebas
        If (CServicio.Text = "INTERNET") Then
            If (Form1.PIndividualT.Text = "") Then
                MsgBox("Se requiere una Prueba Individual, por favor ingresa el numero para que se genere la plantilla correctamente")
                Form1.PIndividualT.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CTecnologia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CTecnologia.SelectedIndexChanged
        If (CTecnologia.Text = "HFC" And CServicio.Text = "INTERNET") Then
            CDiagnostico.Items.Add("CM DESENGANCHADO")
        ElseIf (CTecnologia.Text = "ADSL" And CServicio.Text = "INTERNET") Then
            CDiagnostico.Items.Remove("CM DESENGANCHADO")
        ElseIf (CTecnologia.Text = "ADSL" Or CTecnologia.Text = "GPON" And CServicio.Text = "TV") Then
            CDiagnostico.Items.Add("FALLA IPTV")
        ElseIf (CTecnologia.Text <> "ADSL" Or CTecnologia.Text = "GPON" And CServicio.Text = "TV") Then
            CDiagnostico.Items.Remove("FALLA IPTV")
        End If
    End Sub
    Private Sub CDiagnostico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CDiagnostico.SelectedIndexChanged
        If (CServicio.Text = "INTERNET") Then
            If (Form1.PIndividualT.Text = "") Then
                MsgBox("Se requiere una Prueba Individual, por favor ingresa el numero para que se genere la plantilla correctamente")
                Form1.PIndividualT.Focus()
                Exit Sub
            End If
        End If
        Select Case CDiagnostico.Text
            Case "PARAMETROS ALARMADOS"
                Me.Vfisicas.Controls.Clear()
                PARAMENTROS()
            Case "EQUIPO NO ENCIENDE", "FALLA EQUIPO"
                EQUIPO_NO_ENCIENDE()
            Case "NO NAVEGA"
                NoNavega()
            Case "SIN TONO", "RUIDO EN LINEA", "INTERMITENCIA VOZ"
                SIN_TONO()
            Case "FALLA EQUIPO/CABLE"
                EQUIPO_CABLE()
            Case "NO FUNCIONA TOIP"
                FTOIP()
                GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=1938" 'LINK
                GVariables.NLIK = "TOIP SIN REGISTRO"
                PCLINK()
            Case "FALLA CONTROL"
                CONTROL()
            Case "CONF. WIFI/MODEM"
                WIFI()
            Case "MODEM NO SINCRONIZA", "EQUIPO SIN GESTION"
                SNGESTION()
            Case "SIN IP", "IP BASURA"
                SIP()
            Case "INTERMITENCIA"
                INTERMITENCIA()
            Case "LENTITUD"
                LENTITUD()
            Case "SERVICIOS ESPECIALES"
                SESPECIALES()
            Case "FALLA IPTV"
                CTecnologia.Text = "ADSL"
                IPTV()
            Case "MALA CALIDAD DE IMAGEN", "SIN PAQUETES / SN SEÑAL"
                VTV()
            Case "TV ANALOGA"
                VTV()
            Case "CONECTA NO NAVEGA"
                CNX()
            Case "FALLAS WIFI"
                FWIFI()
            Case "CNX LIMITADA"
                CNX()
            Case "CM DESENGANCHADO"
                CMDesenganchadoHFC()
            Case "FALLA FISICA"
                FFISICO()
            Case "PAGINAS ESPECIFICAS"
                NNPaginas()
            Case Else
                FFISICO()
        End Select
    End Sub
    Private Sub EQUIPO_NO_ENCIENDE()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Conexiones OK"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Llama de otro lugar"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
    End Sub
    Private Sub EQUIPO_CABLE()
        Me.Vfisicas.Controls.Clear()
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Conexiones ok"
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        With Me.chkBox2
            .Text = "Se invierten Puntas"
            .Location = New System.Drawing.Point(6, 35)
            .Size = New System.Drawing.Size(344, 50)
        End With
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.chkBox2.AutoSize = False
    End Sub
    Private Sub SIN_TONO()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Conexiones OK"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Equipo OK"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
    End Sub
    Private Sub CONTROL()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Baterias ok"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Led ok"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(160, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "Reconfiguración control"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(160, 25)
        End With
        Tdeco = New System.Windows.Forms.ComboBox
        Tdeco.Text = "SELECIONA DECO"
        Tdeco.Items.Add("CISCO")
        Tdeco.Items.Add("OTRO")
        Tdeco.Items.Add("KAON")
        Tdeco.Items.Add("ADSL")
        Tdeco.Location = New System.Drawing.Point(10, 95)
        Tdeco.Size = New System.Drawing.Size(160, 30)
        AddHandler Tdeco.SelectedValueChanged, AddressOf validarCodigo
        Ttv = New System.Windows.Forms.ComboBox
        Ttv.Text = "SELECIONA TV"
        Ttv.Items.Add("SANSUNG")
        Ttv.Items.Add("LG")
        Ttv.Items.Add("SONY")
        Ttv.Items.Add("HYUNDAY")
        Ttv.Location = New System.Drawing.Point(10, 125)
        Ttv.Size = New System.Drawing.Size(160, 30)
        Ttv.Visible = False
        AddHandler Ttv.SelectedValueChanged, AddressOf validarMarca
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Me.chkBox3.AutoSize = False
        Me.Vfisicas.Controls.Add(Tdeco)
        Me.Vfisicas.Controls.Add(Ttv)
        'OBS DTH
        If (CServicio.Text = "DTH") Then
            FDTH()
        Else
            Form1.TGUIONES.Text = "validar Tramites, Seriales de los equipos." & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
    End Sub

    Private Sub validarCodigo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Tdeco.Text = "CISCO") Then
            Form1.TGUIONES.Text = "Codigo:  006" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
            Ttv.Visible = False
        ElseIf (Tdeco.Text = "OTRO") Then
            Form1.TGUIONES.Text = "Codigo:  005" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
            Ttv.Visible = False
        ElseIf (Tdeco.Text = "ADSL") Then
            Form1.TGUIONES.Text = "Codigo:  008" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
            Ttv.Visible = False
        ElseIf (Tdeco.Text = "KAON") Then
            Ttv.Visible = True
        End If
    End Sub
    Private Sub validarMarca(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Ttv.Text = "SONY") Then
            Form1.TGUIONES.Text = "10810	10010	10011	10036	10074	10157	10505	11385	11625	11825" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "LG") Then
            Form1.TGUIONES.Text = "11423	11447	12358	12731	12424	10178	10017	10030	10037	10039	10056	10032	10556	10698	10019	12182	10002	10001" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "SANSUNG") Then
            Form1.TGUIONES.Text = "12051	11312	10702	11249	10650	10178	10060	10030	10587	10556	10482	10329	10264	10217	10163	10056	10039	10037	10032	10019	10009" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "HYUNDAY") Then
            Form1.TGUIONES.Text = "10865	10876	11814	11899" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "OTRO") Then
            Form1.TGUIONES.Text = "Codigos OTRO" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
        With Me.TextA
            .Size = New System.Drawing.Size(170, 150)
            .Location = New System.Drawing.Point(184, 24)
            .Multiline = True
            .ScrollBars = ScrollBars.Vertical
            .Text = "Activación Control Deco Kaon" & vbNewLine & "1.   TV POWER + OK  X 30 Seg." & _
                vbNewLine & "2 ingrese el codigo:  incorrecto:parpadera varias veces; ingrese otro codigo; si es correcto: papadea  1 vez; verifique con Vol" & _
                vbNewLine & "si no funciona: -->>reset contol:: ok + pwr ​"
        End With
        Me.Vfisicas.Controls.Add(TextA)
    End Sub

    Private Sub WIFI()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Conf. WIFI"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Cambio de Canal y/o BW"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "DMZ / PORT FORWARDING"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
    End Sub
    Private Sub SNGESTION()
        Me.Vfisicas.Controls.Clear()
        If (CTecnologia.Text = "HFC") Then
            'CREO EL PRIMER ITEM
            With Me.chkBox1
                .Checked = False
                .Location = New System.Drawing.Point(6, 25)
                .Text = "Conexiones ok"
            End With
            'CREO EL SEGUNDO ITEM
            With Me.chkBox2
                .Checked = False
                .Text = "Reincio"
                .Location = New System.Drawing.Point(6, 45)
                .Size = New System.Drawing.Size(344, 25)
            End With
            'CREO EL TERCER ITEM
            With Me.chkBox3
                .Checked = False
                .Text = "Forzar Modem"
                .Location = New System.Drawing.Point(6, 70)
                .Size = New System.Drawing.Size(344, 25)
            End With
            Me.Vfisicas.Controls.Add(chkBox1)
            Me.Vfisicas.Controls.Add(chkBox2)
            Me.Vfisicas.Controls.Add(chkBox3)
            GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=587" 'LINK
            GVariables.NLIK = "CM - SIN GESTION"
            PCLINK()
        Else
            With Me.chkBox1
                .Checked = False
                .Location = New System.Drawing.Point(6, 25)
                .Text = "Reiniciamos CPE"
            End With
            Me.Vfisicas.Controls.Add(chkBox1)
            Form1.TGUIONES.Text = "Terreno (Siebel 8.1 - PREMISAS DEL CLIENTE / Elite - DIAGNOSTICO DATOS (Según Ciudad) / Bogotá - CITAS)" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
            GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=587" 'LINK
            GVariables.NLIK = "CPE - SIN ENLACE"
            PCLINK()
        End If

    End Sub
    Private Sub SIP()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Perfil ok"
            .Size = New System.Drawing.Size(344, 25)
        End With
        If (CTecnologia.Text = "HFC") Then
            'CREO EL SEGUNDO ITEM
            With Me.chkBox2
                .Checked = False
                .Text = "IP NAT"
                .Location = New System.Drawing.Point(6, 50)
                .Size = New System.Drawing.Size(344, 25)
            End With
            'CREO EL TERCER ITEM
            With Me.chkBox3
                .Checked = False
                .Text = "Hard Reset"
                .Location = New System.Drawing.Point(6, 70)
                .Size = New System.Drawing.Size(344, 25)
            End With
            GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=5251" 'LINK
            GVariables.NLIK = "IP NAT"
            PCLINK()
        Else
            'CREO EL SEGUNDO ITEM
            With Me.chkBox2
                .Checked = False
                .Text = "Secion Radius"
                .Location = New System.Drawing.Point(6, 50)
                .Size = New System.Drawing.Size(344, 25)
            End With
            'CREO EL TERCER ITEM
            With Me.chkBox3
                .Checked = False
                .Text = "Hard Reset"
                .Location = New System.Drawing.Point(6, 70)
                .Size = New System.Drawing.Size(344, 25)
            End With
            GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=1979​" 'LINK
            GVariables.NLIK = "IP Invalida ADSL"
            PCLINK()
        End If
        'CREO EL cuarto ITEM
        With Me.chkBox4
            .Checked = False
            .Text = "Consulta Lideres"
            .Location = New System.Drawing.Point(6, 95)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Me.Vfisicas.Controls.Add(chkBox4)
    End Sub
    Private Sub LENTITUD()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Perfil ok"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Upstream/DownStram ok"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "Borrar en CMTS, Reinciar y Forzar"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL CUARTO ITEM
        With Me.chkBox4
            .Checked = False
            .Text = "Consulta Lideres"
            .Location = New System.Drawing.Point(6, 95)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Me.Vfisicas.Controls.Add(chkBox4)
        Form1.TGUIONES.Text = "validar Parametros, descartar con Ping sostenido ping www.google.com -n 40, y CCC" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
    End Sub
    Private Sub SESPECIALES()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(344, 25)
            .Text = "Servicio Activo"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Marcación: OK"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        If (CTecnologia.Text = "HFC") Then
            Form1.TGUIONES.Text = "Para los Discado Nacional/Movil: HFC  (# 05 * + código secreto + 2 + #) Y con (*05*...#) bloquea" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        Else
            Form1.TGUIONES.Text = "para ADSL (# 04 + código secreto + #)  *04# para bloquear" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
    End Sub
    Private Sub IPTV()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(344, 50)
            .Text = "Conexiones ok -Logo de UNE"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "El deco Sincroniza / MAC"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "Reinicio en Cascada"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
    End Sub
    Private Sub TVD()
        '170 SIZE 'CAUSE IN DECO KAON IT GOING TO SHOW THE TEXTA WHIT INFORMATION ABOUT CONFIGURE THE KAON
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(170, 25)
            .Text = "Conexiones ok"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Paquetes / Refresh"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(170, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "Restauracion de Fabrica"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(170, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        If (CServicio.Text = "DTH") Then
            FDTH()
        Else
            Form1.TGUIONES.Text = "validar Tramites, Seriales de los equipos." & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
    End Sub
    Private Sub INTERMITENCIA()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(344, 25)
            .Text = "validar CNX LAN"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Ping Sostendio"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Form1.TGUIONES.Text = "Comando Ping en cmd: ping www.google.com -n 40; si perdida es mayor o igual al 20% escalar; si la cnx es por WIFI validar Soporte Falla WIFI." & vbNewLine & vbNewLine & Form1.TGUIONES.Text
    End Sub

    Private Sub CMDesenganchadoHFC()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.Rbutton1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(344, 25)
            .Text = "CM hábilitado en LDAP"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.Rbutton2
            .Checked = False
            .Text = "CM - NO - hábilitado en LDAP"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Form1.TGUIONES.Text = "Visualizamos un Cable Módem Consultando en LDAP " & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        'CREO EL TERCER ITEM
        With Me.Boton
            .Location = New System.Drawing.Point(6, 65)
            .Text = "Continuar"
            AddHandler Boton.Click, AddressOf SgtCMD
        End With
        Me.Vfisicas.Controls.Add(Rbutton1)
        Me.Vfisicas.Controls.Add(Rbutton2)
        Me.Vfisicas.Controls.Add(Boton)
        GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=587" 'LINK
        GVariables.NLIK = "CM - Desenganchado"
        PCLINK()
    End Sub
    Private Sub SgtCMD(sender As Object, e As EventArgs)
        If (Rbutton1.Checked = True) Then
            Me.Vfisicas.Controls.Clear()
            'CREO EL PRIMER ITEM
            With Me.Rbutton1
                .Checked = False
                .Location = New System.Drawing.Point(6, 25)
                .Size = New System.Drawing.Size(344, 25)
                .Text = "Reinciar CM"
            End With
            Me.Vfisicas.Controls.Add(Rbutton1)
        Else
            Me.Vfisicas.Controls.Clear()
            With Me.Rbutton1
                .Checked = False
                .Location = New System.Drawing.Point(6, 25)
                .Size = New System.Drawing.Size(344, 25)
                .Text = "Corregir Serivicio"
            End With
            Me.Vfisicas.Controls.Add(Rbutton1)
            Form1.TGUIONES.Text = "Acciones / LDAP / Actualizar // Agregar CableModem, y llenar plantilla en GDI - Acciones Individuales SMNET" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
        GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=587" 'LINK
        GVariables.NLIK = "CM - Desenganchado"
        PCLINK()
    End Sub
    Private Sub NoNavega()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "IP correcta"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.Rbutton1
            .Checked = False
            .Text = "Perfil Correcto"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.Rbutton2
            .Checked = False
            .Text = "Lideres"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(Rbutton1)
        Me.Vfisicas.Controls.Add(Rbutton2)
    End Sub
    Private Sub PARAMENTROS()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(344, 25)
            .Text = "Lentitud / Intermitencia"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Moden no Sincroniza"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "Sin Señal / mala Calidad de Imagen"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL CUARTO ITEM
        With Me.chkBox4
            .Checked = False
            .Text = "Falla en Telefonia"
            .Location = New System.Drawing.Point(6, 95)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Me.Vfisicas.Controls.Add(chkBox4)
    End Sub

    Private Sub VTV()
        If (Form1.AreaTextBox.Text <> "ELITE") Then
            TVD()
        Else
            GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=2362" 'LINK
            GVariables.NLIK = "CAMBIO VIRTUAL"
            PCLINK()
            Form1.TGUIONES.Text = "Para Elite debes realizar un Cambio Virtual, apoyate en link Puntos de Contacto" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
    End Sub
    Private Sub CLink(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LAPC1.LinkClicked

        Try
            System.Diagnostics.Process.Start("chrome.exe", GVariables.LPC2)
        Catch ex As Exception
            MessageBox.Show("SIN DEFINIR")
        End Try
    End Sub
    Private Sub FWIFI()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(344, 25)
            .Text = "Configuracion WIFI (SSID y PWD)"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Conf. Avanzada (Canal / BW ...)"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "ipconfig/flushdns -Mto Navegador"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL Cuarto ITEM
        With Me.chkBox4
            .Checked = False
            .Text = "Factort Reset (solo SI parametros OK)"
            .Location = New System.Drawing.Point(6, 95)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Me.Vfisicas.Controls.Add(chkBox4)
        Form1.TGUIONES.Text = "Validar Configuación avanzada: Protocolo WPA/WPÄ2; Encriptación: TKIP/AES; Activar WMM - para mejorar servicios multimedia." & vbNewLine & "Para ver saturacion de canales con WifiAnalyzer (open-sourse)   o el comando cmd: netsh wlan show networks mode=bssid; Para ver los equipos conectactos puesde usar la aplicacion Fing o en cmd net view" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
    End Sub
    Private Sub FFISICO()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Size = New System.Drawing.Size(344, 25)
            .Text = "MODEM NO SINCRONIZA"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "FALLA EN TODOS LOS TV"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "LINEA SIN TONO"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Form1.TGUIONES.Text = "validar CCC e Indicar la posibilIDad de la Misma, revisar reporte existente y enviar dato a Fallas" & vbNewLine & "Solo servicios en la misma tecnologia" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
    End Sub
    Private Sub CNX() ' cxn limitada
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Cambio IP"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Mto al navegador / ping google"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "Conf. NIC/Tipo de Red/Firewall/Antivirus"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        With Me.chkBox4
            .Checked = False
            .Text = "Navegacion otros Dispositivos"
            .Location = New System.Drawing.Point(6, 90)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Me.Vfisicas.Controls.Add(chkBox4)
        Form1.TGUIONES.Text = "Problema Lógico, puede ser del pc-cliente, validar el pto donde esta conectado el equipo; si navegan otros equipos realizar un cmd  netsh int ip reset" & vbNewLine & "validar Ping, Tracert, Direccionamiento de La NIC, validar Firewall y Antivirus, usar otro Equipo como Descarte." & vbNewLine & vbNewLine & Form1.TGUIONES.Text
    End Sub
    Private Sub NNPaginas()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = False
            .Location = New System.Drawing.Point(6, 25)
            .Text = "Cambio IP"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Mto al navegador / ping google"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=5251" 'LINK
        GVariables.NLIK = "IP NAT"
        PCLINK()
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Form1.TGUIONES.Text = "Problema Lógico, validar SI ES IP NAT (100...) afecta aplicaciones, paginas y camaras, también puede ser del pc-cliente." & vbNewLine & "validar Ping, Tracert, validar Firewall y Antivirus, usar otro Equipo como Descarte." & vbNewLine & vbNewLine & Form1.TGUIONES.Text
    End Sub
    Private Sub FTOIP()
        Me.Vfisicas.Controls.Clear()
        'CREO EL PRIMER ITEM
        With Me.chkBox1
            .Checked = True
            .Location = New System.Drawing.Point(6, 25)
            .Text = "LDAP/Configuracion TOIP"
        End With
        'CREO EL SEGUNDO ITEM
        With Me.chkBox2
            .Checked = False
            .Text = "Reaproviciona"
            .Location = New System.Drawing.Point(6, 45)
            .Size = New System.Drawing.Size(344, 25)
        End With
        'CREO EL TERCER ITEM
        With Me.chkBox3
            .Checked = False
            .Text = "Lideres"
            .Location = New System.Drawing.Point(6, 70)
            .Size = New System.Drawing.Size(344, 25)
        End With
        Me.Vfisicas.Controls.Add(chkBox1)
        Me.Vfisicas.Controls.Add(chkBox2)
        Me.Vfisicas.Controls.Add(chkBox3)
        Form1.TGUIONES.Text = "Antes de Reaprovionar servicio: 1) revisa que el perfil en LDAP sea CM-EMTA y que en Siebel tenga el servicio activo; de lo contrario envía a lideres para corregir el servicio." & vbNewLine & "2)Tambíen debes validar el Archivo de configuración en PRUEBAS/CNR / ARCHIVO DE CONFIGURACION..., en SMNET; y si no carga escala a lideres Indicando que el archivo de configurcion de TOIP no está creado." & vbNewLine & vbNewLine & Form1.TGUIONES.Text
    End Sub

    Private Sub COMPLEMENTO()
        VarGlob.Checklist = " >> Servicio Afectado: " & CServicio.Text & " Tecnologia: " & CTecnologia.Text &
" Diagnostico: " & CDiagnostico.Text & " validaciones: Sevicio Activo, "
    End Sub
    Private Sub COMPLEMENTO2()
        VarGlob.Checklist = vbNewLine & "Diagnostico: " & CDiagnostico.Text & " Se realiza procedimiento solicitado por el Cliente: "
    End Sub

    Private Sub RDTH()
        If (CServicio.Text = "DTH" And CheckBox1.Checked = False) Then
            VarGlob.Checklist = VarGlob.Checklist & "Modelo del Deco: " & vbNewLine & "NS: " & vbNewLine _
             & "Potencia: " & vbNewLine & "Nivel de Señal:" & vbNewLine & "Canales Afectados: " & vbNewLine
        End If
    End Sub

    Private Sub COMPLEMENTO5()
        varglob.checklist = varglob.checklist & "Tecnologia: " & CTecnologia.Text & " Diagnostico: " & CDiagnostico.Text & " validaciones: Sevicio Activo, Sin CCC Asociada al Servicio"
    End Sub
    Private Sub Elite()
        varglob.checklist = "UCID: " & Form1.IDllamadaT.Text & " Diagnostico: " & CDiagnostico.Text & " -" & CServicio.Text & " - " & Form1.CiudadT.Text
    End Sub
    Private Sub CDiagnostico_LostFocus(sender As Object, e As EventArgs) Handles CDiagnostico.LostFocus
        If (CDiagnostico.Text = "FALLA IPTV") Then
            CTecnologia.Text = "ADSL"
        ElseIf (CDiagnostico.Text = "DTH") Then
            CTecnologia.Text = "DTH"
        End If
    End Sub

    Private Sub CServicio_SelectedValueChanged(sender As Object, e As EventArgs) Handles CServicio.SelectedValueChanged
        If (CServicio.Text = "NETFLIX") Then
            Me.Vfisicas.Controls.Clear()
            CDiagnostico.Text = "FALLAS PLATAFORMA"
            GVariables.LPC2 = "http://puntosdecontacto/index.php/st-otros-productos" 'LINK
            GVariables.NLIK = "SOPORTE PLATAFORMA"
            Form1.TGUIONES.Text = "Soporte Otros Productos Revisar el  LINK de PUNTOS DE CONTACTO" & vbNewLine & " validar: Servicio Activo, Codigo de Hogar OK, Cuentas configuradas" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
            PCLINK()
        ElseIf (CServicio.Text = "CORREO") Then
            Me.Vfisicas.Controls.Clear()
            GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=1434" 'LINK
            GVariables.NLIK = "CORREO"
            PCLINK()
        ElseIf (CServicio.Text = "VENTAS/CROSS") Then
            CTecnologia.Text = "NA"
            CDiagnostico.Text = "VENTA"
        ElseIf (CServicio.Text = "DTH") Then
            FDTH()
        ElseIf (CServicio.Text = "BA-TV-TOIP/TO") Then
            CDiagnostico.Text = "POSIBLE FALLA EXTERNA"
            FFISICO()
        ElseIf (CServicio.Text = "BUZON") Then
            Me.BtVfisicas.Controls.Clear()
            CTecnologia.Text = "NA"
            CDiagnostico.Text = "CONFIGURACION BUZON"
            COMPLEMENTO()
            Dim clave As String = Form1.IdServicioT.Text
            clave = clave.Substring(clave.Length - 4, 4)
            varglob.checklist = varglob.checklist & " Se valida servicio y se indica al user procedimiento para reconfigurar el servicio de Buzón."
            Form1.TGUIONES.Text = "1- Marcar la línea 2831000" & vbNewLine & "2- Agregar el código de área + la línea del tele buzón; Es decir para su linea " & Form1.IdServicioT.Text & " de " & Form1.CiudadT.Text & ": Para acceder al servicio se hace con: codigo de area " & VarGlob.codarea & " - " & Form1.IdServicioT.Text & vbNewLine & "3- Ingresar la clave de acceso, la cual por defecto son los 4 últimos dígitos de la línea del tele buzón" & vbNewLine & ", la clave sería: " & clave & vbNewLine & "Luego de esto el deberá cambiar su contraseña que es la opción 4, y personalizar su tele buzón." & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
    End Sub
    Private Sub PCLINK()
        LAPC1 = New System.Windows.Forms.LinkLabel
        LAPC1.Location = New System.Drawing.Point(6, 170)
        LAPC1.Size = New System.Drawing.Size(170, 25)
        LAPC1.Text = GVariables.NLIK
        AddHandler LAPC1.LinkClicked, AddressOf CLink
        Me.Vfisicas.Controls.Add(LAPC1)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs)
        If (Ttv.Text = "SONY") Then
            Form1.TGUIONES.Text = "Codigos para " & Ttv.Text & vbNewLine & "10810	10010	10011	10036	10074	10157	10505	11385	11625	11825" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "LG") Then
            Form1.TGUIONES.Text = "Codigos para " & Ttv.Text & vbNewLine & "11423	11447	12358	12731	12424	10178	10017	10030	10037	10039	10056	10032	10556	10698	10019	12182	10002	10001" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "SANSUNG") Then
            Form1.TGUIONES.Text = "Codigos para " & Ttv.Text & vbNewLine & "12051	11312	10702	11249	10650	10178	10060	10030	10587	10556	10482	10329	10264	10217	10163	10056	10039	10037	10032	10019	10009" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "HYUNDAY") Then
            Form1.TGUIONES.Text = "Codigos para " & Ttv.Text & vbNewLine & "10865	10876	11814	11899" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        ElseIf (Ttv.Text = "OTRO") Then
            Form1.TGUIONES.Text = "Codigos para " & Ttv.Text & vbNewLine & "Codigos OTRO" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        End If
    End Sub
    Private Sub BtVfisicas_Click(sender As Object, e As EventArgs) Handles BtVfisicas.Click
        'VarlIDar pruebas
        If (Form1.Tinteracion.Text <> "FALLA SIEBEL/SMNET") Then
            If (CServicio.Text = "INTERNET") Then
                If (Form1.PIndividualT.Text = "") Then
                    MsgBox("Se requiere una Prueba Individual, por favor ingresa el numero para que se genere la plantilla correctamente")
                    Form1.PIndividualT.Focus()
                    Exit Sub
                End If
            End If
        End If
        If (Form1.AreaTextBox.Text = "ELITE") Then
            varglob.checklist = ""
            Elite()
        Else
            Select Case CDiagnostico.Text
                'FALLAS ASOCIADAS A TV
                'FALLA EQUIPO CABLE
                Case "FALLA EQUIPO/CABLE"
                    COMPLEMENTO()
                    RDTH()
                    If (chkBox1.Checked = True) Then
                        varglob.checklist = varglob.checklist & ", Se validan conexiones"
                    Else
                        varglob.checklist = varglob.checklist & ", No es posible validar CNX, llama de otro lugar"
                    End If
                    If (chkBox2.Checked = True) Then
                        varglob.checklist = varglob.checklist & ", Se invierten puntas"
                    Else
                        varglob.checklist = varglob.checklist & ", Usuario Manifesta fallas en el equipo"
                    End If
                    'FALLA CONTROL
                Case "FALLA CONTROL"
                    COMPLEMENTO()
                    RDTH()
                    If (chkBox1.Checked = True) Then
                        varglob.checklist = varglob.checklist & ", Se validan Baterias, función ok"
                    End If
                    If (chkBox2.Checked = True) Then
                        varglob.checklist = varglob.checklist & ", Al presionar se Observa que el Led Enciende"
                    Else
                        varglob.checklist = varglob.checklist & ", Al presionar se Observa que el NO Enciende el LED"
                    End If
                    If (chkBox3.Checked = True) Then
                        varglob.checklist = varglob.checklist & ", Se reconfigura Control"
                    End If
                    SITIO3C()
                    'EQUIPO NO ENCIENDE
                Case "EQUIPO NO ENCIENDE", "FALLA EQUIPO"
                    COMPLEMENTO()
                    RDTH()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se validan conexiones, se prueba en otra toma"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", llama desde otro lugar, No se puede validar cnx."
                    End If
                    SITIO2C()
                    'SIN SEÑAL/MALA CALIDAD DE IMAGEN
                Case "MALA CALIDAD DE IMAGEN", "SIN PAQUETES / SN SEÑAL", "TV ANALOGA"
                    COMPLEMENTO()
                    RDTH()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Conexiones ok"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se reistalan paquetes/Refresh"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se Reinicia de fabrica"
                    End If
                    SITIO3C()
                    'SIN TONO
                Case "SIN TONO", "INTERMITENCIA", "RUIDO EN LINEA"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se validan conexiones"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & ", No es posible validar CNX, llama de otro lugar"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Equipo OK"
                    End If
                    'PARAMETROS ALARMADOS
                Case "PARAMETROS ALARMADOS"
                    COMPLEMENTO()
                    VarGlob.Checklist = VarGlob.Checklist & "User manifiesta que"
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Internet presenta Lentitud y/o Intermitencia"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", el Modem no sincroniza"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", TV presenta fallas (Mala calidad y/o Sin señal)"
                    End If
                    If (chkBox4.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", La Telefonia Presenta Fallas"
                    End If
                    SITIO4C()
                    'MODEM NO SINCRONIZA Y EQUIPO SIN GESTION
                Case "EQUIPO SIN GESTION", "MODEM NO SINCRONIZA"
                    COMPLEMENTO()
                    If (CTecnologia.Text = "HFC") Then
                        If (chkBox1.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", Se validan conexiones: ok"
                        Else
                            VarGlob.Checklist = VarGlob.Checklist & ", No es posible validar CNX, llama de otro lugar"
                        End If
                        If (chkBox2.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", Se Reinicia Modem"
                        End If
                        If (chkBox3.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", Se fuerza el Equipo"
                        End If
                    Else
                        If (chkBox1.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", Se Reinicia Modem"
                        Else
                            VarGlob.Checklist = VarGlob.Checklist & ", No es posible Reinicia Modem, Usuario llama de otro lugar"
                        End If
                    End If
                    'SIN IP
                Case "SIN IP", "IP BASURA"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Perfil: ok"
                    End If
                    If (CTecnologia.Text = "HFC") Then
                        If (chkBox2.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", Se Identifica IP NAT, se realiza proceso de cambio tipo de IP"
                        End If

                        If (chkBox3.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", se realiza Hard Reset"
                        End If
                    Else
                        If (chkBox2.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", se Libera secion en Radius"
                        End If
                        If (chkBox3.Checked = True) Then
                            VarGlob.Checklist = VarGlob.Checklist & ", se realiza Hard Reset y se reaproviciona servicio"
                        End If
                    End If
                    If (chkBox4.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", sin solucion, Se gestiona con Lideres"
                    End If
                    SITIO4C()
                    'SERVICIOS ESPECIALES
                Case "SERVICIOS ESPECIALES"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Servicio Activo"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & ", Se valida el servicio, se realiza activacion, se indica ANS al usuario"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", se valida Marcación, correcta"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & ", se indica al usuario como realizar la marcación"
                    End If
                    SITIO2C()
                    'FALLA IPTV
                Case "FALLA IPTV"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Conexiones ok"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & ", No es posible validar CNX, llama de otro lugar"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Deco Sincroniza"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Reinicio en Cascada"
                    End If
                    'CONECTA NO NAVEGA
                Case "CONECTA NO NAVEGA"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Fecha Equipo: ok"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se puede Acceder a la Pagina"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se direcciona la Tarjeta y se Realiza Factory Reset"
                    End If
                    SITIO3C()
                    'FALLAS WIFI
                Case "FALLAS WIFI"
                    COMPLEMENTO()
                    If (Form1.ComboBox40.Text = "SI") Then
                        VarGlob.Checklist = VarGlob.Checklist & " >> Se comunica Titular"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & " << NO se comunica Titular; se realizan las validaciones del equipo"
                    End If
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ",  Se Reconfigura SSID y Pasword"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", se gestiona el modem y se valida configuracion para Seguidad: WPA/WPA2, encriptación: TKIP/AES y se activa WMM, se realiza escaneo de canales, seleccionando la mejor configuración para el servicio."
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", se realiza ipconfig/flushdns -Mto Navegador"
                    End If
                    If (chkBox4.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se realiza Hard Reset"
                    End If
                    SITIO4C()
                    'CONFIGURACIONES WIFI
                Case "CONF. WIFI/MODEM"
                    COMPLEMENTO2()
                    If (Form1.ComboBox40.Text = "SI") Then
                        VarGlob.Checklist = VarGlob.Checklist & " >> Se comunica Titular"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & " << NO se comunica Titular; se realizan las validaciones del equipo"
                    End If
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se Reconfigura SSID y/o Pasword"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se optimiza configuracion Wifi, se ingresa a la gestion del moden, se realiza un escaneo de canales y se configura ancho de Banda"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se configura DMZ/Port Forwarding"
                    End If
                    SITIO3C()
                    'CNX LIMITADA O NULA
                Case "CNX LIMITADA"
                    COMPLEMENTO2()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se cambia la IP"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se vacia cache y se realiza mto al navegador, ping a Google-"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se descarta tipo de Red, Firewall y Antivirus, se Configura NIC,"
                    End If
                    If (chkBox4.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", se valida navegacion en los otros dispocitivos"
                    End If
                    SITIO4C()
                    'FALLA GENERAL
                Case "POSIBLE FALLA EXTERNA"
                    If (CTecnologia.Text = "ADSL") Then
                        CServicio.Text = "BA-TV-TO"
                    Else
                        CServicio.Text = "BA-TV-TOIP"
                    End If
                    COMPLEMENTO5()
                    VarGlob.Checklist = VarGlob.Checklist & " User reporta:"
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Falla en Internet, Modem NO sincroniza"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Falla en todos los TV"
                    End If
                    If (chkBox3.Checked = True) Then
                        If (CTecnologia.Text = "ADSL") Then
                            VarGlob.Checklist = VarGlob.Checklist & ", Falla TO, sin tono"
                        Else
                            VarGlob.Checklist = VarGlob.Checklist & ", Falla en TOIP, sin tono"
                        End If
                    End If
                    SITIO3C()
                    'CM DESENGANCHADO
                Case "CM DESENGANCHADO"
                    CTecnologia.Text = "HFC"
                    COMPLEMENTO()
                    If (Me.Rbutton1.Text = "Reinciar CM") Then
                        VarGlob.Checklist = VarGlob.Checklist & ", CM hábilitado en LDAP; se Reinicia CM"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & ", CM NO hábilitado en LDAP; agrega CM"
                    End If
                    'NO NAVEGA
                Case "NO NAVEGA"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Equipo, toma IP, Correcta"
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & ", al validar la IP no es correcta "
                        If (CTecnologia.Text = "ADSL") Then
                            VarGlob.Checklist = VarGlob.Checklist & ", Se realiza el reingreso de cnx y pwd, se reaproviciona servicio "
                        Else
                            VarGlob.Checklist = VarGlob.Checklist & ", se restaura de fabrica, "
                        End If
                    End If
                    If (Rbutton1.Checked) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", El perfil y los seriales son correctos y coherentes en los diferente servidores, "
                    End If
                    If (Rbutton2.Checked) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", al hallarse incosistencias en los servidores se realiza consulta con Lideres, "
                    End If
                    'NO FUNCIONA TOIP
                Case "NO FUNCIONA TOIP"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se valida perfil en LDAP: ok, el archivo de configuracion asociado a la MAC: ok"
                        chkBox2.Enabled = True
                        chkBox3.Enabled = True
                    Else
                        VarGlob.Checklist = VarGlob.Checklist & ", se encuentra incosistnecias en LDAP y/o Archivo de configuracion TOIP, se escala  a Lideres"
                        chkBox2.Enabled = False
                        chkBox3.Enabled = False
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se reaprovicionar el servicio"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se encuentra inconsistencias en plataforma"
                    End If
                    If (chkBox1.Checked = True And chkBox2.Checked = False And chkBox3.Checked = False) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", User llama desde otro lugar"
                    End If
                    'NO NAVEGA PAGINAS ESPECIFICAS
                Case "PAGINAS ESPECIFICAS"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se realiza Cambio de IP"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se realiza PING sostenIDo a Google"
                    End If
                    SITIO2C()
                    'LENTITUD
                Case "LENTITUD"
                    COMPLEMENTO()
                    If (chkBox1.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", Se Perfil OK; Upstream/DownStram ok"
                    End If
                    If (chkBox2.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", se Borra CM en CMTS, se Reinicia y Fuerza el equipo"
                    End If
                    If (chkBox3.Checked = True) Then
                        VarGlob.Checklist = VarGlob.Checklist & ", se hace necesario gestionar con Lideres"
                    End If
            End Select

            'varglob.checklist = varglob.checklist & VarGlob.SAvanzado
        End If
        VarGlob.Vobo = True
        VarGlob.SDiagnostico = Trim(CServicio.Text & "-" & CTecnologia.Text & "-" & CDiagnostico.Text)
        If (CheckBox1.Checked = False) Then
            Form1.Tinteracion.Text = "TERRENO"
            Form1.TGUIONES.Text = "Sr/ Sra " & Form1.CNombreTextBox.Text & " su visita queda para (fecha acordada), en el transcurso de la (franja acordada).  Puede llamarnos a este mismo numero para consultar o modificar la fecha de la visita, tambien para validar los datos del tecnico asignado. Sr/sra " & Form1.CNombreTextBox.Text & " Le invitamos a responder nuestra encuensta de servicio, recuerde, si le gusto como le atendí califiqueme con 5. gracias por haberse comunicado con nosotros, En TigoUne estamos para usted, le deseamos " & Form1.Momento2(TimeOfDay.Hour)
        Else
            Form1.Tinteracion.Text = "SPC"
        End If
        Me.Close()
    End Sub

    Private Sub SITIO4C()
        If (chkBox1.Checked = False And chkBox2.Checked = False And chkBox3.Checked = False And chkBox4.Checked = False) Then
            VarGlob.Checklist = VarGlob.Checklist & ", No se encuentra en el Sitio "
        End If
    End Sub
    Private Sub SITIO3C()
        If (chkBox1.Checked = False And chkBox2.Checked = False And chkBox3.Checked = False) Then
            varglob.checklist = varglob.checklist & ", No se encuentra en el Sitio "
        End If
    End Sub
    Private Sub SITIO2C()
        If (chkBox1.Checked = False And chkBox2.Checked = False And chkBox3.Checked = False) Then
            varglob.checklist = varglob.checklist & ", No se encuentra en el Sitio "
        End If
    End Sub
    Private Sub FDTH()
        CTecnologia.Text = "SATELITAL"
        Form1.TGUIONES.Text = "Revisar el  LINK de PUNTOS DE CONTACTO" & vbNewLine & "  - para mas Informacion" & vbNewLine & vbNewLine & Form1.TGUIONES.Text
        GVariables.LPC2 = "http://puntosdecontacto/index.php/nuac-on?ID=4114​​​" 'LINK
        GVariables.NLIK = "DTH"
        PCLINK()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SoporteAvanzado.BringToFront()
        SoporteAvanzado.Show()
    End Sub

End Class