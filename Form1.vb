Imports System.Drawing.Color
Imports System.Net.Mail

Public Class Form1
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
        Public Shared Saludo As String = "Buenos Dias "
        Public Shared contador As Integer = 0
        Public Shared Tcall As Integer = 1
    End Class

    Private Sub Saludo()
        Dim NLlamada As String = "....."
        If (CNombreTextBox.Text <> "") Then
            NLlamada = CNombreTextBox.Text
        End If
        Cronometro.Text = Momento(TimeOfDay.Hour) & " | " & NLlamada
        TGUIONES.Text = Momento(TimeOfDay.Hour) & " habla con " & Environment.UserName & " Asesor de Soporte Tecnico de TigoUne, ¿Con quien tengo el gusto de Hablar? ... " & vbNewLine & "*****[identificado] se comunican de la familia........." & vbNewLine & "*****[sin identificar] me confirma por favor la cédula del titular?" & vbNewLine & "*****Nota: Si no hay respuesta en 20 seg. " & "debes para finalizar con el siguiente guión: - Por falta de respuesta voy a colgar esta llamada" & vbNewLine & "*****CLIENTE SE QUEJA; respondemos:- Lamento mucho escuchar eso, Señor(a) " & NLlamada & ", le ofrezco disculpas en nombre de TigoUne por no solucionar a tiempo su requerimiento, me apersonaré de su caso para darle una solución efectiva"
    End Sub

    Private Sub IdllamadaT_GotFocus(sender As Object, e As EventArgs) Handles IdllamadaT.GotFocus
        Saludo()
    End Sub

    Private Sub IdllamadaT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdllamadaT.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub IdllamadaT_LostFocus(sender As Object, e As EventArgs) Handles IdllamadaT.LostFocus
        If (IdllamadaT.TextLength > 15 And IdllamadaT.TextLength <= 21) Then
            Timer1.Start()
            Label6.Text = CInt(Label6.Text) + 15
            Button11.Text = "LIMPIAR"
            IdllamadaT.Enabled = False
        End If
    End Sub
    Private Sub ComboBox40_LostFocus(sender As Object, e As EventArgs) Handles ComboBox40.LostFocus
        If (ComboBox40.Text <> "NO") Then
            CCContactoT.Text = CCvisible.Text
        End If
    End Sub
    Private Sub ComboBox40_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox40.SelectedIndexChanged
        If (ComboBox40.Text <> "SI") Then
            CCContactoT.Enabled = True
            CCContactoT.Text = ""
            CCContactoT.Focus()
            GVariables.MMM = "  NO SE COMUNICA TITULAR; SE VALIDAN NS/MAC DEL EQUIPO "
        Else
            GVariables.MMM = "  SE COMUNICA TITULAR "
        End If
        If (ComboBox40.Text <> "NO") Then
            CCContactoT.Text = CCvisible.Text
        End If
    End Sub

    Private Sub CCTitularTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CCTitularTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CCTitularTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles CCTitularTextBox.KeyUp
        If (CCTitularTextBox.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(CCTitularTextBox.Text, importe)
            CCTitularTextBox.Text = String.Format("{0:N0}", importe)
            CCTitularTextBox.SelectionStart = CCTitularTextBox.TextLength
        End If
    End Sub

    Private Sub CCTitularTextBox_LostFocus(sender As Object, e As EventArgs) Handles CCTitularTextBox.LostFocus
        AGuardar()
    End Sub
    Private Sub AGuardar()
        If (IdllamadaT.Text <> "" And CCTitularTextBox.Text <> "") Then
            BtSPC.Enabled = True
        End If
    End Sub
    Private Sub CCTitularTextBox_TextChanged(sender As Object, e As EventArgs) Handles CCTitularTextBox.TextChanged
        If (CCTitularTextBox.Text <> "") Then
            CCContactoT.Text = Replace(CCTitularTextBox.Text, ".", "")
            CCvisible.Text = Replace(CCTitularTextBox.Text, ".", "")
            CCContactoT.Text = Replace(CCTitularTextBox.Text, ",", "")
            CCvisible.Text = Replace(CCTitularTextBox.Text, ",", "")
            CCContactoT.Enabled = False
        End If
    End Sub
    Private Sub CiudadT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CiudadT.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub CiudadT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CiudadT.SelectedIndexChanged, CiudadT.LostFocus, DptoT.TabIndexChanged
        If (CiudadT.Text <> "") Then
            If (CiudadT.Text = "MONTERIA" Or CiudadT.Text = "SANTA MARTA" Or CiudadT.Text = "SINCELEJO") Then
                AreaTextBox.Text = "EDATEL/SIEBEL"
            ElseIf (CiudadT.Text = "ARMENIA" Or CiudadT.Text = "BUGA" Or CiudadT.Text = "MANIZALES" Or CiudadT.Text = "EJE CAFETERO") Then
                AreaTextBox.Text = "ELITE"
                TSElite()
                DptoT.Text = "Eje Cafetero"
            Else
                Dim Edatel() As String = {"ABEJORRAL", "ABRIAQUI", "AGUACHICA", "AGUSTIN CODAZZI", "ALEJANDRIA", "AMAGA", "AMALFI", "ANDES", "ANGELOPOLIS", "ANGOSTURA", "ANORI", "ANTIOQUIA", "ANZA", "APARTADO", "ARBOLETES", "ARGELIA", "ARMENIA", "AYAPEL", "BELMIRA", "BETANIA", "BETULIA", "BOSCONIA", "BRICEÑO", "BUENAVISTA", "BURITICA", "CACERES", "CAICEDO", "CAIMITO", "CAMPAMENTO", "CANALETE", "CAÑASGORDAS", "CARACOLI", "CARAMANTA", "CAREPA", "CAROLINA", "CAUCASIA", "CERETE", "CHALAN", "CHIGORODO", "CHIMA", "CHINU", "CIENAGA DE ORO", "CISNEROS", "CIUDAD BOLIVAR", "BOLIVAR", "COCORNA", "COLOSO", "CONCEPCION", "CONCORDIA", "COROZAL", "COTORRA", "COVEÑAS", "DABEIBA", "DON MATIAS", "EBEJICO", "EL BAGRE", "BAGRE", "ENTRERRIOS", "FREDONIA", "FRONTINO", "GIRALDO", "GOMEZ PLATA", "GRANADA", "GUADALUPE", "GUARANDA", "GUATAPE", "HELICONIA", "HISPANIA", "ITUANGO", "JARDIN", "JERICO", "LA APARTADA", "LA PINTADA", "LIBORINA", "LORICA", "LOS CORDOBAS", "LOS PALMITOS", "MACEO", "MAGANGUE", "MOMIL", "MONTEBELLO", "MOÑITOS", "MORROA", "MOTELIBANO", "MURINDO", "MUTATA", "NARIÑO", "NECHI", "NECOCLI", "OLAYA", "PALMITO", "PEÑOL", "PEQUE", "PLANETA RICA", "PUEBLO NUEVO", "PUEBLORRICO", "PUERTO BERRIO", "PUERTO BOYACÁ", "PUERTO ESCONDIDO", "PUERTO NARE", "PUERTO TRIUNFO", "PURISIMA", "REMEDIOS", "SABANALARGA", "SAHAGUN", "SALGAR", "SAMPUES", "SAN ANDRES DE CUERQUIA", "SAN ANDRES SOTAVENTO", "SAN ANTERO", "SAN BERNARDO DEL VIENTO", "SAN CARLOS", "SAN CARLOS", "SAN FRANCISCO", "SAN JERONIMO", "SAN JOSE DE LA MONTAÑA", "SAN JOSE DE URE", "SAN JUAN DE BETULIA", "SAN JUAN DE URABA", "SAN LUIS", "SAN LUIS DE SINCE", "SAN MARCOS", "SAN ONOFRE", "SAN PEDRO", "SAN PEDRO", "SAN PEDRO DE URABA", "SAN PELAYO", "SAN ROQUE", "SAN VICENTE", "SANTA BARBARA", "SANTA ROSA DE OSOS", "SANTAFE DE ANTIOQUIA", "SANTA FE DE ANTIOQUIA", "SANTO DOMINGO", "SANTOA DE TOLU", "SEGOVIA", "SONSON", "SOPETRAN", "SUCRE", "TAMESIS", "TARAZA", "TARSO", "TIERRA ALTA", "TITIRIBI", "TOLEDO", "TUCHIN", "TURBO", "URAMITA", "URRAO", "VALDIVIA", "VALENCIA", "VALLEDUPAR", "VALPARAISO", "VEGACHI", "VENECIA", "VIGIA DEL FUERTE", "YALI", "YARUMAL", "YOLOMBO", "YONDO", "ZARAGOZA"}
                Dim ETP() As String = {"CARTAGO", "DOSQUEBRADAS", "IBAGUE", "LA TEBAIDA", "LA VIRGINIA", "MONTENEGRO", "PEREIRA", "QUIMBAYA", "SANTA ROSA DE CABAL"}
                Dim CBUSQUEDA As Integer
                Dim CBUSQUEDA2 As Integer
                CBUSQUEDA = (Array.IndexOf(Edatel, CiudadT.Text))
                CBUSQUEDA2 = (Array.IndexOf(ETP, CiudadT.Text))
                If (CBUSQUEDA >= 0) Then
                    AreaTextBox.Text = "EDATEL"
                Else
                    If (CBUSQUEDA2 >= 0) Then
                        AreaTextBox.Text = "ETP"
                    Else
                        AreaTextBox.Text = "SIEBEL"
                        Tinteracion.Text = "OTROS"
                        txtProceso.Text = ""
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub TTBX_GotFocus(sender As Object, e As EventArgs) Handles TTBX.GotFocus
        If (TTBX.Text = "TT") Then
            TTBX.Text = ""
        End If
    End Sub

    Private Sub TTBX_LostFocus(sender As Object, e As EventArgs) Handles TTBX.LostFocus
        If (TTBX.Text <> "TT") Then
            txtProceso.Text = "Id-LLamada: " & IdllamadaT.Text & " NOMBRE: " & CNombreTextBox.Text & " CC: " & _
                            CCContactoT.Text & " TT : " & TTBX.Text
        End If
        TGUIONES.Text = "Señor(a) " & CNombreTextBox.Text & ",  se presenta una falla a nivel general con el servicio en el servicio reportado, le ofrezco disculpas en nombre de TigoUne. Nuestro personal técnico está trabajando en dar una pronta solución."
    End Sub

    Private Sub LIMPIAR()
        IdllamadaT.Text = ""
        CNombreTextBox.Text = ""
        CCTitularTextBox.Text = ""
        IdServicioT.Text = ""
        PIntegralT.Text = ""
        PIndividualT.Text = ""
        ComboBox40.Text = "SI"
        CCContactoT.Text = ""
        MovilT.Text = "3338888888"
        FijoT.Text = "8888888"
        CorreoT.Text = "cliente@sincorreo.com"
        TextBox1.Text = "cliente"
        ComboBox2.Text = "@sincorreo.com"
        TextBox2.Text = "3"
        DptoT.Text = "ANTIOQUIA"
        CiudadT.Text = "MEDELLIN"
        AreaTextBox.Text = "SIEBEL"
        txtProceso.Text = ""
        TTBX.Text = "TT"
        txtProceso.Text = "Aquí se generará la Plantilla"
        TxDireccion.Text = ""
        CSerial.Text = ""
        ValSMNET.Enabled = True
        Tcausa.text = Nothing
        GVariables.contador = 0
        VarGlob.Plantilla = ""
        VarGlob.Vobo = False
        VarGlob.Checklist = ""
        MovilT.BackColor = White
        FijoT.BackColor = White
        TGUIONES.BackColor = LightSteelBlue
        txtProceso.BackColor = LightSteelBlue
        Cronometro.TAlerta.BackColor = LightSteelBlue
        VarGlob.SAvanzado = ""
        VarGlob.Diagnostico = ""
        VarGlob.codarea = 4
        VarGlob.CodDig = 10
        VarGlob.CDig = 10
        VarGlob.ObGraficas = ""
        Cronometro.TAlerta.Text = ""
        Me.Text = "Prototype Developed by ASHER - [ Asistente Para Nuevos Agentes - ANA ] >> Diadema en OIDO " & VarGlob.OIDO
        If (VarGlob.OIDO = "DERECHO") Then
            Cronometro.Toido.BackColor = Green
            Cronometro.Liz.BackColor = Transparent
            Cronometro.Toido.Text = ">>"
        Else
            Cronometro.Toido.BackColor = Transparent
            Cronometro.Liz.BackColor = Red
            Cronometro.Liz.Text = "<<"
        End If
        Me.BackColor = LightSteelBlue
        btActualizarP.BackColor = LightSteelBlue
        IdllamadaT.Enabled = True
        TGUIONES.Text = ""
        Tinteracion.Text = "OTROS"
        CheckBox1.Checked = False
        LbMinutos.Text = "00"
        LbSegndos.Text = "00"
        'promediar AHT
        If (CInt(Label6.Text) > 0) Then
            VarGlob.VTotalCall = VarGlob.VTotalCall + CInt(Label6.Text) + 40
            VarGlob.VPromedio = VarGlob.VTotalCall / GVariables.Tcall
        End If
        Cronometro.Duracion.Text = VarGlob.VPromedio
        Cronometro.GBLlamada.BackColor = Transparent
        Cronometro.BackColor = White
        Label6.Text = "0"
        Cronometro.LbMinutos.Text = "00"
        Cronometro.LbSegndos.Text = "00"
        ComboBox1.Text = Nothing
        CmdIniciar.Text = ">>"
        btActualizarP.Text = "Total LLamadas: " & GVariables.Tcall & vbNewLine & _
        "SPC: " & GVariables.SPC & vbNewLine & _
        "TERRENO:  " & GVariables.TERRENO & vbNewLine & _
        "TRASFERENCIA:  " & GVariables.TRASFERENCIA & vbNewLine & _
        "OTRO:  " & GVariables.OTRO & vbNewLine & _
        "AHT: " & VarGlob.VPromedio
        Button11.Enabled = False
        VarGlob.Guardado = False
        BtSPC.Text = "Guardar Registro"
        IAna.BackColor = Transparent
        Tayuda.BackColor = LightSteelBlue
        BtSPC.Enabled = False
    End Sub

    Private Sub BT()
        Me.Text = CNombreTextBox.Text & " [ Asistente Para Nuevos Agentes - ANA ] >> Diadema en OIDO " & VarGlob.OIDO & "  - Prototype  Developed by ASHER "
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (Button11.Text = "Activar Cronometro") Then
            Button11.Text = "LIMPIAR"
            Timer1.Start()
            DPlantilla.Enabled = True
            Dubicacion.Enabled = True
            DBasicos.Enabled = True
            ValSMNET.Enabled = True
            DContacto.Enabled = True
            CmdIniciar.Text = ">>"
            GCRONOMETRO.BackColor = Transparent
            IdllamadaT.Enabled = False
            IdllamadaT.Focus()
        Else
            LIMPIAR()
            GCRONOMETRO.BackColor = Transparent
            If (VarGlob.Guardado = True) Then
                Tinteracion.Focus()
            Else
                IdllamadaT.Focus()
            End If
        End If
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        IdllamadaT.Focus()
    End Sub

    Private Sub Form1_MenuComplete(sender As Object, e As EventArgs) Handles Me.MenuComplete
        IdllamadaT.Focus()
    End Sub

    Private Sub CNombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CNombreTextBox.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then
            If (TextBox2.Text = "") Then
                TextBox2.Text = "3"
            ElseIf (TextBox2.Text >= 8) Then
                MsgBox("No se permite un tiempo mayor a 5", MsgBoxStyle.Critical, "Timer en tiempo no permitido")
                TextBox2.Text = "5"
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CopiarPlantilla()
    End Sub
    Private Sub CopiarPlantilla()
        If (Not String.IsNullOrEmpty(txtProceso.Text)) Then
            txtProceso.SelectionStart = 0
            txtProceso.SelectionLength = txtProceso.Text.Length
            txtProceso.Copy()
            TGUIONES.Text = "Tenemos lista la plantilla, solo preciona pegar donde la necesites" & vbNewLine & vbNewLine & TGUIONES.Text
        End If
    End Sub
    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        If (Not String.IsNullOrEmpty(IdServicioT.Text)) Then
            IdServicioT.SelectionStart = 0
            IdServicioT.SelectionLength = IdServicioT.Text.Length
            IdServicioT.Copy()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If (Not String.IsNullOrEmpty(PIntegralT.Text)) Then
            PIntegralT.SelectionStart = 0
            PIntegralT.SelectionLength = PIntegralT.Text.Length
            PIntegralT.Copy()
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (Not String.IsNullOrEmpty(PIndividualT.Text)) Then
            PIndividualT.SelectionStart = 0
            PIndividualT.SelectionLength = PIndividualT.Text.Length
            PIndividualT.Copy()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (Not String.IsNullOrEmpty(IdllamadaT.Text)) Then
            IdllamadaT.SelectionStart = 0
            IdllamadaT.SelectionLength = IdllamadaT.Text.Length
            IdllamadaT.Copy()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (Not String.IsNullOrEmpty(CNombreTextBox.Text)) Then
            CNombreTextBox.SelectionStart = 0
            CNombreTextBox.SelectionLength = CNombreTextBox.Text.Length
            CNombreTextBox.Copy()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (Not String.IsNullOrEmpty(CCvisible.Text)) Then
            CCvisible.SelectionStart = 0
            CCvisible.SelectionLength = CCvisible.Text.Length
            CCvisible.Copy()
        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (Not String.IsNullOrEmpty(CCContactoT.Text)) Then
            CCContactoT.SelectionStart = 0
            CCContactoT.SelectionLength = CCContactoT.Text.Length
            CCContactoT.Copy()
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If (Not String.IsNullOrEmpty(MovilT.Text)) Then
            MovilT.SelectionStart = 0
            MovilT.SelectionLength = MovilT.Text.Length
            MovilT.Copy()
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If (Not String.IsNullOrEmpty(FijoT.Text)) Then
            FijoT.SelectionStart = 0
            FijoT.SelectionLength = FijoT.Text.Length
            FijoT.Copy()
        End If
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        CorreoT.Text = TextBox1.Text & ComboBox2.Text
        If (Not String.IsNullOrEmpty(CorreoT.Text)) Then
            CorreoT.SelectionStart = 0
            CorreoT.SelectionLength = CorreoT.Text.Length
            CorreoT.Copy()
        End If
    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If (Not String.IsNullOrEmpty(TTBX.Text)) Then
            TTBX.SelectionStart = 0
            TTBX.SelectionLength = TTBX.Text.Length
            TTBX.Copy()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (Not String.IsNullOrEmpty(TxDireccion.Text)) Then
            TxDireccion.SelectionStart = 0
            TxDireccion.SelectionLength = TxDireccion.Text.Length
            TxDireccion.Copy()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Not String.IsNullOrEmpty(TCausa.Text)) Then
            TCausa.SelectionStart = 0
            TCausa.SelectionLength = TCausa.Text.Length
            TCausa.Copy()
        End If
    End Sub
    '*************************************** CRONOMETRO
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerA(TextBox2.Text)
        Dim MP As String = " un momento"
        Timer1.Interval = 1000
        Label9.Text = CInt(Label9.Text) + 1 'segundero
        If (CInt(Label9.Text) = 60) Then
            Label4.Text = CInt(Label4.Text) + 1 'minutero
            Label9.Text = "0"
        End If
        If (IdllamadaT.Text <> "") Then
            Label6.Text = CInt(Label6.Text) + 1 ' duracion llamda
            Cronometro.Duracion.Text = Label6.Text
        End If
        'Colores de ANA
        If (CInt(Label6.Text) > 0) Then
            Select Case CInt(Label6.Text)
                Case Is < 300
                    TGUIONES.BackColor = LightSteelBlue
                    Me.BackColor = LightSteelBlue
                    btActualizarP.BackColor = LightSteelBlue
                    txtProceso.BackColor = LightSteelBlue
                    Cronometro.GBLlamada.BackColor = LightSteelBlue
                    Cronometro.TAlerta.BackColor = LightSteelBlue
                    If (CheckBox2.Checked = False) Then
                        Tayuda.BackColor = White
                        Tayuda.BorderStyle = BorderStyle.FixedSingle
                    Else
                        Tayuda.BackColor = LightSteelBlue
                        Tayuda.BorderStyle = BorderStyle.None
                    End If
                Case Is < 500
                    Me.BackColor = PaleGreen
                    btActualizarP.BackColor = PaleGreen
                    If (CheckBox2.Checked = False) Then
                        Tayuda.BackColor = White
                        Tayuda.BorderStyle = BorderStyle.FixedSingle
                    Else
                        Tayuda.BackColor = PaleGreen
                        Tayuda.BorderStyle = BorderStyle.None
                    End If
                    TGUIONES.BackColor = PaleGreen
                    txtProceso.BackColor = PaleGreen
                    Cronometro.GBLlamada.BackColor = PaleGreen
                    Cronometro.TAlerta.BackColor = PaleGreen
                Case Is <= 640
                    Me.BackColor = LightBlue
                    btActualizarP.BackColor = LightBlue
                    If (CheckBox2.Checked = False) Then
                        Tayuda.BackColor = White
                        Tayuda.BorderStyle = BorderStyle.FixedSingle
                    Else
                        Tayuda.BackColor = LightBlue
                        Tayuda.BorderStyle = BorderStyle.None
                    End If
                    TGUIONES.BackColor = LightBlue
                    txtProceso.BackColor = LightBlue
                    Cronometro.GBLlamada.BackColor = LightBlue
                    Cronometro.TAlerta.BackColor = LightBlue
                Case Is > 640
                    Me.BackColor = Silver
                    btActualizarP.BackColor = Silver
                    If (CheckBox2.Checked = False) Then
                        Tayuda.BackColor = White
                        Tayuda.BorderStyle = BorderStyle.FixedSingle
                    Else
                        Tayuda.BackColor = Silver
                        Tayuda.BorderStyle = BorderStyle.None
                    End If
                    TGUIONES.BackColor = Silver
                    txtProceso.BackColor = Silver
                    Cronometro.GBLlamada.BackColor = Silver
                    Cronometro.TAlerta.BackColor = Silver
            End Select
        End If

        'Mensajes de Ana
        If (CInt(Label6.Text) > 0) Then
            Select Case CInt(Label6.Text)
                Case Is = 90
                    Select Case IdServicioT.Text
                        Case ""
                            TGUIONES.Text = "Veo que no tienes identificado el Activo: Intente la siguiente: !!" & vbNewLine & "* Valida los datos con el cliente, factura, si no estás seguro, por ejemplo la dirección, que se comunique nuevamente: -NO REALICES NINGUN PROCESO SI NO TE CONFIRMA" & vbNewLine & "* Verifica en CMI y FENIX,  puede ser Pymes, - No olvides agregar [ http://netvm-pcmi01/cmi_pymes/web/defingresos ] a la dirección de CMI en el WTS 150; no olvides login/login; luego actualiza el Activo en SIEBEL" & vbNewLine & "* Valida con la MAC / NS según corresponda" & vbNewLine & "* NO ENCUETRAS SERVICIO: Busca con el codigo de Familia; [Direccion - SIEBEL] " & vbNewLine & "* si es un TELEFONO; de ser TOIP, has la consulta en ambas plataformas, antesede ( + indicativo +) al numero de telefono -Bogotá; " & vbNewLine & "* Si es INTERNET en Consulta/LDAP -> Contrato, este es el activo" & vbNewLine & " - No olvides que te puedes apoyar con los patinadores y los lideres o hacer una llamada consultda (Y)" & vbNewLine & vbNewLine & TGUIONES.Text
                            IAna.BackColor = Red
                        Case Else
                            Select Case Tinteracion.Text
                                Case "OTROS"
                                    TGUIONES.Text = "Excelente!!!! vamos Bn! " & vbNewLine & vbNewLine & TGUIONES.Text
                                    IAna.BackColor = Transparent
                            End Select
                            IAna.BackColor = Transparent
                    End Select
                Case Is = 300
                    Select Case PIntegralT.Text
                        Case ""
                            TGUIONES.Text = "En Este momento deberías estar resolviendo, Veo que no has identificado el Activo, intenta lo siguiente: " & vbNewLine & "Enfocaque en el diagnostico y has las preguntas que confirmen lo que piensas, se claro y habla al nivel del cliente" & vbNewLine & "* Trata de Ubicar, el numero de la linea, el serial del equipo; - Puedes decir: al Caja del Internet, Caja de la Television, El Cotrol de UNE." & vbNewLine & "* ..En la parte inferior de ... se encuentra una etiqueta, en ella podrá ver un codigo de barras, ubique donde dice C-M MAC / SN..." & vbNewLine & "- No olvides que te puedes apoyar con los patinadores y los lideres o hacer una llamada consultda (Y)" & vbNewLine & vbNewLine & TGUIONES.Text
                            IAna.BackColor = Red
                        Case Else
                            Select Case Tinteracion.Text
                                Case "OTROS"
                                    TGUIONES.Text = "Excelente!!!! vamos Bn! " & vbNewLine & vbNewLine & TGUIONES.Text
                                    IAna.BackColor = Transparent
                            End Select
                            IAna.BackColor = Transparent
                    End Select
                Case Is = 640
                    Select Case VarGlob.Guardado
                        Case Is = False
                            TGUIONES.Text = "Debes estar Agendando; Procura indicir al cliente a que axija una visita tecnica" & vbNewLine & "* ¿Cómo? hasle tres pregunas positivas, luego suguiere que el exige una visita en pro de la dificultad de resolver el problema como solución definitiva y al finalizar la propuesta indicale que en afirmación; comprendo que usted está de acuerdo, debe responder si, trata de ser lo mas breve." & vbNewLine & vbNewLine & "- No olvides que te puedes apoyar con los patinadores y los lideres o hacer una llamada consultda (Y)" & vbNewLine & vbNewLine & TGUIONES.Text
                            IAna.BackColor = Red
                        Case Else
                            IAna.BackColor = Orange
                            TGUIONES.Text = "Ya Terminastes el Soporte, pero debes gestionar inducir al cliente a finalizar, respuestas claras y limite de funciones, Apoyate con los Patinadore y Supervisores." & vbNewLine & vbNewLine & TGUIONES.Text
                    End Select
            End Select
        End If
        ''cronometro
        '*****************
        If (CmdIniciar.Text = "||") Then
            LbSegndos.Text = CInt(LbSegndos.Text) + 1
            Cronometro.LbSegndos.Text = LbSegndos.Text
            Dim Alerta As Integer = (TimerA(TextBox2.Text) - 1)
            If CInt(LbSegndos.Text) < 10 Then
                LbSegndos.Text = Trim("0" & CInt(LbSegndos.Text))
                Cronometro.LbSegndos.Text = LbSegndos.Text
            End If
            If (CInt(LbSegndos.Text) = 60) Then
                LbSegndos.Text = "00"
                Cronometro.LbSegndos.Text = LbSegndos.Text
                LbMinutos.Text = CInt(LbMinutos.Text) + 1
                Cronometro.LbMinutos.Text = LbMinutos.Text
                If CInt(LbMinutos.Text) < 60 Then
                    LbMinutos.Text = Trim("0" & CInt(LbMinutos.Text))
                    Cronometro.LbMinutos.Text = LbMinutos.Text
                End If
            End If
            'LLAMAR ALERTA
            If (CInt(LbMinutos.Text = TimerA(TextBox2.Text) - 1) And CInt(LbSegndos.Text = "50")) Then
                Select Case TimerA(TextBox2.Text)
                    Case Is < 1
                        MP = " un momento"
                    Case Is > 1
                        MP = " de " & Alerta & " a " & TimerA(TextBox2.Text) & " minutos"
                End Select
                Beep()
                AlertaT.Show()
            End If
            Select Case CInt(LbMinutos.Text)
                Case Is < (TimerA(TextBox2.Text) - 1)
                    GCRONOMETRO.BackColor = YellowGreen
                    CmdIniciar.BackColor = YellowGreen
                    Cronometro.BackColor = YellowGreen
                    Cronometro.GBLlamada.BackColor = Me.BackColor
                Case Is = (TimerA(TextBox2.Text) - 1)
                    GCRONOMETRO.BackColor = Orange
                    CmdIniciar.BackColor = Orange
                    Cronometro.BackColor = Orange
                    Cronometro.GBLlamada.BackColor = Me.BackColor
                Case Is >= TimerA(TextBox2.Text)
                    GCRONOMETRO.BackColor = Salmon
                    CmdIniciar.BackColor = Salmon
                    Cronometro.BackColor = Salmon
                    Cronometro.GBLlamada.BackColor = Me.BackColor
            End Select
            '****************/
        Else

            LbMinutos.Text = "00"
            LbSegndos.Text = "00"

        End If
        If (CInt(Label4.Text) = VarGlob.TDIADEMA) Then
            Label4.Text = "0"
            If (VarGlob.OIDO = "DERECHO") Then
                VarGlob.OIDO = "IZQUIERDO"
                Cronometro.Toido.BackColor = Transparent
                Cronometro.Liz.BackColor = Red
                Cronometro.Liz.Text = "<<"
                Cronometro.Toido.Text = ""
                TGUIONES.Text = "!!! Debes cambiar la diadema a tu oido Izquierdo !!!  Tu Salud es importante ..." & vbNewLine & vbNewLine & TGUIONES.Text
                Cronometro.TAlerta.Text = "¡¡Cambia: Diadema a oido Izquierdo !!"
            Else
                VarGlob.OIDO = "DERECHO"
                Cronometro.Toido.BackColor = Green
                Cronometro.Liz.BackColor = Transparent
                Cronometro.Toido.Text = ">>"
                Cronometro.Liz.Text = ""
                TGUIONES.Text = "!!! Debes cambiar la diadema a tu oido Derecho !!!  Tu Salud es importante ..." & vbNewLine & vbNewLine & TGUIONES.Text
                Cronometro.TAlerta.Text = "¡¡Cambia: Diadema a oido Derecho !!"
            End If
            BT()
            Beep()
        End If
    End Sub

    Public Function TimerA(ByVal Tiempo As String) As Integer
        Dim A As Integer
        If (Tiempo <> "") Then
            A = CInt(Tiempo)
        Else
            A = 3
        End If
        Return A
    End Function
    Private Sub CNombreTextBox_LostFocus(sender As Object, e As EventArgs) Handles CNombreTextBox.LostFocus
        If (CNombreTextBox.Text <> "") Then
            BT()
            If (VarGlob.OIDO = "DERECHO") Then
                Cronometro.Toido.BackColor = Green
                Cronometro.Liz.BackColor = Transparent
                Cronometro.Toido.Text = ">>"
            Else
                Cronometro.Toido.BackColor = Transparent
                Cronometro.Liz.BackColor = Red
                Cronometro.Liz.Text = "<<"
            End If
        End If
        Saludo()
    End Sub
    Private Sub MovilT_GotFocus(sender As Object, e As EventArgs) Handles MovilT.GotFocus
        If (MovilT.Text = "333888888") Then
            MovilT.Text = ""
        Else
            If (MovilT.TextLength > 3) Then
                Dim Vmovil As String = MovilT.Text
                Dim RMovil As String = Vmovil.Substring(0, 3)
                If (RMovil = "333") Then
                    MovilT.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub MovilT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MovilT.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub MovilT_LostFocus(sender As Object, e As EventArgs) Handles MovilT.LostFocus
        If (MovilT.Text = "") Then
            MovilT.Text = "333" & FijoT.Text
        Else
            Dim Vmovil As String = MovilT.Text
            Dim RMovil As String = Vmovil.Substring(0, 3)
            If (RMovil = "333") Then
                If (FijoT.Text <> "") Then
                    MovilT.Text = "333" & FijoT.Text
                    MovilT.BackColor = White
                End If
            End If
        End If
        'CORRECION CANTIDAD DE DIGITOS
        If (MovilT.TextLength > 10) Then
            Dim CMOVIL As String = MovilT.Text
            MovilT.Text = CMOVIL.Substring(CMOVIL.Length - 10, 10)
            MovilT.BackColor = GreenYellow
        Else
            MovilT.BackColor = White
        End If
    End Sub
    Private Sub FijoT_GotFocus(sender As Object, e As EventArgs) Handles FijoT.GotFocus
        If (FijoT.Text = "8888888") Then
            FijoT.Text = ""
            MovilT.BackColor = White
        End If
    End Sub

    Private Sub FijoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FijoT.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CorreoT_GotFocus(sender As Object, e As EventArgs) Handles CorreoT.GotFocus
        If (CorreoT.Text = "cliente@sincorreo.com" Or CorreoT.Text = "CLIENTE@SINCORREO.COM") Then
            CorreoT.Text = ""
        End If
    End Sub

    Private Sub CorreoT_LostFocus(sender As Object, e As EventArgs) Handles CorreoT.LostFocus
        If (CorreoT.Text = "") Then
            CorreoT.Text = "cliente@sincorreo.com"
        End If
    End Sub

    '+++++++++++++++++
    Public Function ProcesarT1(ByVal A As Integer) As String
        Dim MP As String
        MP = "un momento"
        If (A <= 1) Then
            MP = " un momento"
        Else
            MP = "de " & A - 1 & " a " & A & " minutos"
        End If
        Return MP
    End Function
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If (MovilT.TextLength = 10 And MovilT.Text <> "3338888888") Then
            GVariables.rMovil = MovilT.Text
            Tnumero.Text = 990203 & GVariables.rMovil & 150348
            If (Not String.IsNullOrEmpty(Tnumero.Text)) Then
                Tnumero.SelectionStart = 0
                Tnumero.SelectionLength = Tnumero.Text.Length
                Tnumero.Copy()
                TGUIONES.Text = "Tenemos listo el numero " & Tnumero.Text & "  para marcar, solo presiona pegar donde lo necesites!!!" & vbNewLine & vbNewLine & TGUIONES.Text
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (FijoT.TextLength = 7 And FijoT.Text <> "8888888") Then
            GVariables.rFijo = FijoT.Text
            If (CiudadT.Text = "BOGOTA" Or CiudadT.Text = "CUNDINAMARCA") Then
                Tnumero.Text = 9902051 & GVariables.rFijo & 150348
                VarGlob.codarea = 1
            ElseIf (CiudadT.Text = "CALI" Or CiudadT.Text = "PALMIRA" Or CiudadT.Text = "BUGA" Or CiudadT.Text = "CARTAGO" Or DptoT.Text = "VALLE") Then
                Tnumero.Text = 9902052 & GVariables.rFijo & 150348
                VarGlob.codarea = 2
            ElseIf (CiudadT.Text = "MEDELLIN" Or CiudadT.Text = "MONTERIA" Or DptoT.Text = "ANTIOQUIA") Then
                Tnumero.Text = 9902 & GVariables.rFijo & 150348
                VarGlob.codarea = 4
            ElseIf (CiudadT.Text = "MANIZALES" Or CiudadT.Text = "ARMENIA" Or DptoT.Text = "EJE CAFETERO" Or CiudadT.Text = "EJECAFETERO") Then
                Tnumero.Text = 9902056 & GVariables.rFijo & 150348
                VarGlob.codarea = 6
            ElseIf (CiudadT.Text = "BARRANQUILLA" Or CiudadT.Text = "CARTAGENA" Or CiudadT.Text = "VALLEDUPAR" Or CiudadT.Text = "SINCELEJO" Or DptoT.Text = "COSTA") Then
                Tnumero.Text = 9902055 & GVariables.rFijo & 150348
                VarGlob.codarea = 5
            ElseIf (CiudadT.Text = "VILLAVICENCIO") Then
                Tnumero.Text = 9902058 & GVariables.rFijo & 150348
                VarGlob.codarea = 8
            ElseIf (CiudadT.Text = "BUCARAMANGA" Or CiudadT.Text = "CUCUTA" Or CiudadT.Text = "GIRON" Or CiudadT.Text = "BARANCABERMEJA" Or CiudadT.Text = "PIEDECUESTA" Or CiudadT.Text = "SANTANDER" Or CiudadT.Text = "SANTANDERES") Then
                Tnumero.Text = 9902057 & GVariables.rFijo & 150348
                VarGlob.codarea = 7
            End If
            If (Not String.IsNullOrEmpty(Tnumero.Text)) Then
                Tnumero.SelectionStart = 0
                Tnumero.SelectionLength = Tnumero.Text.Length
                Tnumero.Copy()
                TGUIONES.Text = "Tenemos listo el numero " & Tnumero.Text & "  para marcar, solo presiona pegar donde lo necesites!!!" & vbNewLine & vbNewLine & TGUIONES.Text
            End If
            'Else
            ' FijoT.Text = GVariables.rFijo
        End If
    End Sub

    Public Shared Function Momento(ByVal Hora As Integer) As String
        Dim Saludo As String = "Buenos Dias "
        If (Hora >= 0 And Hora < 12) Then
            Saludo = "Buenos Días "
        ElseIf (Hora >= 12 And Hora < 19) Then
            Saludo = "Buenas Tardes "
        ElseIf (Hora >= 19 Or Hora < 24) Then
            Saludo = "Buenas Noches "
        End If
        Return Saludo
    End Function
    Public Shared Function Momento2(ByVal Hora As Integer) As String
        Dim Saludo As String = "Buenos Dias "
        If (Hora >= 0 And Hora < 12) Then
            Saludo = " un Feliz día"
        ElseIf (Hora >= 12 And Hora < 19) Then
            Saludo = " una Feliz Tarde "
        ElseIf (Hora >= 19 Or Hora < 24) Then
            Saludo = " una Feliz Noche "
        End If
        Return Saludo
    End Function

    Public Shared Function NAgente(ByVal Nombre As String) As String
        Dim NombreAgente As String = "...."
        If (String.IsNullOrEmpty(VarGlob.NAgente) = False) Then
            NombreAgente = VarGlob.NAgente
        Else
            IGENERAL.Show()
        End If
        Return NombreAgente
    End Function

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Notas.Show()
        Notas.BringToFront()
        Notas.TextBox1.Focus()
        If CheckBox2.Checked = False Then
            If (Tayuda.Text <> Nothing) Then
                VarGlob.Notas = Tayuda.Text
            End If
        End If
    End Sub

    Private Sub BtTransferencia_Click(sender As Object, e As EventArgs)
        VPlantillaC()
        If (Tcausa.text <> "") Then
            txtProceso.Text = CNombreTextBox.Text & " CC: " & CCContactoT.Text & " || " & Tcausa.text & " - " & TxDireccion.Text
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*****************************guiones
        GEstadisticas.Text = "Estadisticas para " & Environment.UserName
        Tinteracion.Text = "OTROS"
        TextBox2.Text = "3"
        TGuion.Items.Add("Cliente se Queja")
        TGuion.Items.Add("Cliente Solita Espera")
        TGuion.Items.Add("Cliente Trasferido")
        TGuion.Items.Add("Habeas Data")
        TGuion.Items.Add("Confronta Aceptado")
        TGuion.Items.Add("Confronta Rechazado")
        TGuion.Items.Add("Centrales de Riesgo")
        TGuion.Items.Add("Tercero no existe")
        TGuion.Items.Add("Anulado por saldos pendientes")
        TGuion.Items.Add("Alcance del servicio de Banda Ancha")
        TGuion.Items.Add("Migracion servicio existente")
        TGuion.Items.Add("Factura Electronica")
        TGuion.Items.Add("Autorización para atender la instalación")
        TGuion.Items.Add("Alcance del servicio de WIFI")
        TGuion.Items.Add("Despedida venta")
        TGuion.Items.Add("Restauracion de Fabrica")
        Saludo() 'saludo
        DptoT.Items.Add("ANTIOQUIA")
        DptoT.Items.Add("COSTA")
        DptoT.Items.Add("EJE CAFETERO")
        DptoT.Items.Add("TOLIMA")
        DptoT.Items.Add("VALLE")
        DptoT.Items.Add("QUINDIO")
        DptoT.Items.Add("RISARALDA")
        DptoT.DropDownStyle = ComboBoxStyle.DropDownList

        DptoT.Text = "ANTIOQUIA"
        CiudadT.Text = "MEDELLIN"
        AreaTextBox.Text = "SIEBEL"

        Button11.Text = "LIMPIAR"
        Timer1.Start()
        CmdIniciar.Text = ">>"
        LIMPIAR()
        GCRONOMETRO.BackColor = Transparent
        IdllamadaT.Focus()

        Tayuda.Text = "AYUDA ANA" & vbNewLine & "Cliente Critico = Ctrl + A" & vbNewLine & "Traferencia avaya = Ctrl + K" & vbNewLine & "Llamada Muda = Ctrl + P" & vbNewLine & "Plantilla = Ctrl + S" & vbNewLine & "LIMPIAR = Escape" & vbNewLine & vbNewLine & "Ctrl + 1: Cronometro 1 m" & vbNewLine & "Ctrl + 2: Cronometro 2 m" & vbNewLine & "Ctrl + 3: Cronometro 3 m" & vbNewLine & vbNewLine & "Ctrl + L: Trasferir Plantilla a  Notas" & vbNewLine & vbNewLine & "Alt + 1: WTS Elite" & vbNewLine & "Alt + 2: WTS 140" & vbNewLine & "Alt + 3: WTS 150" & vbNewLine & "Alt + 4: WTS 167"

        Cronometro.Toido.BackColor = Green

        Me.KeyPreview = True
    End Sub
    Private Sub TGuion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TGuion.SelectedIndexChanged
        Select Case TGuion.Text
            Case "Cliente Solita Espera"
                TGUIONES.Text = "Nota: Esperamos 90 segundos:" & vbNewLine & "Sr/sra " & CNombreTextBox.Text & " me escucha? Sr/sra por falta de respuesta voy colgar está llamada."
            Case "Cliente se Queja"
                TGUIONES.Text = "Lamento mucho escuchar eso, Señor(a)" & CNombreTextBox.Text & ", le ofrezco disculpas en nombre de TigoUne por no solucionar a tiempo su requerimiento, me apersonaré de su caso para darle una solución efectiva"
            Case "Cliente Trasferido"
                TGUIONES.Text = "Sr/sra " & CNombreTextBox.Text & " veo que fue trasferido, permitame valido la informacion en nuestro sistema."
            Case "Alcance del servicio de WIFI"
                TGUIONES.Text = "Sr/Sra " & CNombreTextBox.Text & " para nosotros es muy importante que usted pueda disfrutar de forma optima nuestro servicio de internet fijo por tanto tenga presente que hay factores que pueden afectar la velocidad y sobre los cuales usted tiene control como: La cantidad de usuarios conectados según la velocidad contratada, " & _
                    "ubicación de modem en zonas cubiertas que pueden interferir en la señal del wifi, fenómenos naturales, mantenimiento de sus equipos de cómputo, entre otros. Adicionalmente, para poder experimentar la velocidad de su plan, recomendamos una conexión directa con el cable modem, la red wifi es una facilidad que se ve afectada por los factores" & _
                    "señalados. Señor@ " & CNombreTextBox.Text & " para nosotros es muy importante que usted pueda disfrutar de forma optima de sus servicios, por eso nos tomamos el tiempo para darle claridad y transparencia de nuestra oferta, en todo caso podrá encontrar más información en www.tigo.com.co"
            Case "Restauracion de Fabrica"
                TGUIONES.Text = "Señor(a) " & CNombreTextBox.Text & ",  en este caso vamos a dar Reset de fabrica para regresar su equipo a la configuración inicial, va a quedar con esta configuración temporalmente y vamos a registrar una queja de servicio para que revisemos que problema tiene su equipo para poder auto gestionarse"
            Case "Migracion servicio existente"
                TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & " de acuerdo al cambio que acabamos de hacer en su plan, los cobros de estos nuevos valores que le acabo de informar se verán reflejados en su factura dentro de (2 ó 3) meses aproximadamente, esto debido a que los planes anteriores deben terminar su consumo completo, recibirá el cobro de sus servicios nuevos (migrados, upgrade) empezará a recibirlos en la siguiente periodo: ____________"
            Case "Factura Electronica"
                TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & ", ¿desea recibir su factura en su correo electrónico? En caso de aceptar recibirla por correo electrónico, es muy fácil pagarla sin tener que imprimir su factura, lo puede hacer solo informando su número de contrato en Baloto, Bancolombia o GANA o a través del portal www.une.com.co con tarjeta crédito o débito ¿Está de acuerdo? SI/NO"
            Case "Autorización para atender la instalación"
                TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & " le informamos que debe estar presente un mayor de edad (En algunas regiones debe ser el titular*) en el sitio de instalación el día y la hora que a continuación acordemos. Está de acuerdo? SI/NO" & _
                "Si la respuesta es NO: (donde debe estar el titular) Ya que usted no puede estar presente el día de la instalación, deberá autorizar por escrito, adjuntando copia de su documento de identidad y del de la persona mayor de edad que lo representará. Dicha autorización" & _
                " deberá abarcar la firma de documentos correspondientes a la instalación de los servicios. (Que sonequipos que les entregan en dicho momento para que quede constancia)"
            Case "Habeas Data"
                TGUIONES.Text = "Sr/Sra " & CNombreTextBox.Text & ", ¿Autoriza a Colombia Móvil S.A. E.S.P, UNE EPM Telecomunicaciones S.A, EDATEL S.A. en adelante Las Compañías, para que recolecte, almacene, suministre, procese, utilice y transfiera a terceros información relativa" & _
                    "a usted para fines del servicio y comerciales, entre ellos, publicidad relacionada con los servicios así como con otros bienes y servicios propios y de terceros impresa o a través de medios electrónicos, la prevención y control de fraudes y consultar listas internacionales" & _
                    " expedidas por el Consejo de Seguridad de las Naciones Unidas y las demás que tengan carácter vinculante para Colombia?? Señor Usuario(a) autoriza SI/ NO De acuerdo a la Ley 1581 de 2012, como titular de información usted tiene derecho a conocer, actualizar, rectificar sus datos " & _
                    "personales, solicitar prueba de la autorización otorgada, ser informado sobre el uso dado a los mismos, presentar quejas ante la SIC por infracción a la ley, revocar la autorización y/o solicitar la supresión de sus datos cuando sea procedente y acceder en forma gratuita a los mismos. " & _
                    "La política de tratamiento de los datos así como el aviso de privacidad los podrá encontrar en nuestra página web www.tigo.com.co"
            Case "Centrales de Riesgo"
                TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & ", ¿Da su consentimiento expreso a UNE, su grupo empresarial y aliados para: Consultar a centrales de riesgo la información de su desempeño como deudor y su capacidad de pago, reportar datos sobre su cumplimiento o incumplimiento " & _
                    " de las obligaciones que adquiera con UNE; solicitar y suministrar información y centrales de información de datos de sus solicitudes de crédito, relaciones comerciales, financieras y socioeconómicas que no haya entregado o no consten en registros públicos; conservar y procesar en UNE, " & _
                    "en la entidad que sea acreedora y en las centrales de riesgo, la información indicada anteriormente?"
            Case "Resultado Tercero no existe"
                TGUIONES.Text = "<< se habilita el botón de prospección >> Se le informa el requisito para continuar la venta y se habilita el botón de prospección para ingresar los datos del usuario."
            Case "Anulado por saldos pendientes"
                TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & ", como lo hablamos anteriormente, uno de los requisitos para tomar nuestros servicios es que se encuentre al día con nuestra compañía, ahora bien luego de realizar la validación en nuestros sistemas encontramos que hay un sado pendiente a su nombre." & _
                    " Le cuento que nosotros queremos que usted se vincule con nuestra empresa, por tanto es necesario que usted este al día con nosotros, le recomiendo que se comunique con nuestra área de factura para que le informen de su deuda y poder solicitar nuestros servicios."
            Case "Confronta Aceptado"
                TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & ", ¿Da su consentimiento expreso a UNE, su grupo empresarial y aliados para: Consultar a centrales de riesgo la información de su desempeño como deudor y su capacidad de pago, reportar datos sobre su cumplimiento o incumplimiento de las " & _
                    "obligaciones que adquiera con UNE; solicitar y suministrar información y centrales de información de datos de sus solicitudes de crédito, relaciones comerciales, financieras y socioeconómicas que no haya entregado o no consten en registros públicos; conservar y procesar en UNE, en la entidad " & _
                    " que sea acreedora y en las centrales de riesgo, la información indicada anteriormente?"
            Case "Confronta Rechazado"
                TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & ", le indicamos que la validación de su información, luego de las respuestas que usted nos suministró en las dos oportunidades, nos arroja un resultado negativo, por tanto, no es posible continuar en este momento con el proceso de obtención de su " & _
                    " información crediticia. Debemos esperar hasta mañana para volver a ejecutar el mismo proceso. Nos comunicaremos con usted en las próximas 24 horas. ¿Esta bien?"
            Case "Despedida venta"
                TGUIONES.Text = "Bienvenido a la familia TIGOUNE: Sr/Sra. " & CNombreTextBox.Text & ", bienvenid@ a nuestra compañía, recuerde que el prestador de los servicios es UNE EPM telecomunicaciones y espero que en el menor tiempo posible usted y los miembros de su familia puedan empezar a disfrutar de todos " & _
                    " estos servicios. Recuerde: Su número de pedido es xxxx, el detalle de la permanencia mínima, al igual que el número de contrato le serán informados en su factura"
        End Select
    End Sub
    Private Sub VPlantillaC()
        Try
            Dim Proceso As String = txtProceso.Text
            Dim Iproceso As String = Proceso.Substring(0, 4)
            Dim nombre As String = CNombreTextBox.Text
            Dim Inombre As String = nombre.Substring(0, 4)
            If (Iproceso = "UCID") Then
                VarGlob.Plantilla = txtProceso.Text
            End If
        Catch ex As Exception
            ' MsgBox("Error, no se guadro el contenido")
        End Try
    End Sub
    Function VSMNET(ByVal Servicio As String, ByVal Integral As String) As Boolean
        If (Servicio <> Nothing And Integral <> Nothing) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub BtSPC_Click(sender As Object, e As EventArgs) Handles BtSPC.Click
        If (VarGlob.Guardado = False) Then
            Select Case Tinteracion.Text
                Case "SPC"
                    If (VSMNET(IdServicioT.Text, PIntegralT.Text) = True) Then
                        GVariables.SPC = GVariables.SPC + 1
                        txtProceso.Text = txtProceso.Text & " - SPC"
                        AgregarRegistro()

                        TGUIONES.Text = "El clinente tiene menos de 10@ en un plan viejo? - es decir No es NE; Recuerda puedes ofrecer gota de 5@ o 10@, " & vbNewLine & vbNewLine & TGUIONES.Text
                    Else
                        MsgBox("Se requiere registrar al menos el Id-Servicio y la prueba SMNET integral")
                        Exit Sub
                    End If
                Case "ASESORIA"
                    If (VSMNET(IdServicioT.Text, PIntegralT.Text) = True) Then
                        GVariables.OTRO = GVariables.OTRO + 1
                        AgregarRegistro()
                    Else
                        MsgBox("Se requiere registrar al menos el Id-Servicio y la prueba SMNET integral")
                        Exit Sub
                    End If
                Case "TERRENO"
                    If (VSMNET(IdServicioT.Text, PIntegralT.Text) = True) Then
                        GVariables.TERRENO = GVariables.TERRENO + 1
                        AgregarRegistro()
                    Else
                        MsgBox("Se requiere registrar al menos el Id-Servicio y la prueba SMNET integral")
                        Exit Sub
                    End If

                Case "TRASFERENCIA"

                    If (Tcausa.text <> "SinMotivo") Then
                        txtProceso.Text = CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & " - " & TxDireccion.Text & " || " & Tcausa.text
                        GVariables.TRASFERENCIA = GVariables.TRASFERENCIA + 1
                        AgregarRegistro()
                    Else
                        MsgBox("Debes indicar el Motivo")
                        txtProceso.Focus()
                    End If
                Case "FALLA SIEBEL/SMNET - TERRENO"
                    AgregarRegistro()
                    GVariables.TERRENO = GVariables.TERRENO + 1
                Case "FALLA SIEBEL/SMNET - OTRO"
                    AgregarRegistro()
                    GVariables.OTRO = GVariables.OTRO + 1
                Case Else
                    GVariables.OTRO = GVariables.OTRO + 1
                    AgregarRegistro()
            End Select
            GVariables.Tcall = GVariables.TERRENO + GVariables.SPC + GVariables.OTRO + GVariables.TRASFERENCIA
            btActualizarP.Text = "Total LLamadas: " & GVariables.Tcall & vbNewLine & _
                    "SPC: " & GVariables.SPC & vbNewLine & _
                    "TERRENO:  " & GVariables.TERRENO & vbNewLine & _
                    "TRASFERENCIA:  " & GVariables.TRASFERENCIA & vbNewLine & _
                    "OTRO:  " & GVariables.OTRO & vbNewLine & _
                    "AHT: " & VarGlob.VPromedio
            VarGlob.Guardado = True
            TGUIONES.Text = "Estamos Terminado; Manejo del cliente para terminar rápido recuerda que puedes ofertar para cumplir la meta" & vbNewLine & vbNewLine & TGUIONES.Text
            Button11.Enabled = True
            If (Tinteracion.Text = "CROSS" Or Tinteracion.Text = "UPS") Then
                BtSPC.Text = "Detener Timer"
                Tcausa.text = "Venta"
            Else
                BtSPC.Text = "Plantilla Avaya"
            End If
            IdllamadaT.Enabled = False
        Else
            Select Case BtSPC.Text
                Case "Plantilla Avaya"
                    Tavaya()
                Case "Guardar Registro"
                    AgregarRegistro()
                    BtSPC.Text = "Plantilla Avaya"
                Case "Detener Timer"
                    Timer1.Stop()
                    BtSPC.Text = "Reinciar Timer"
                    TGUIONES.Text = "El Cronometro se ha detenido" & vbNewLine & vbNewLine & TGUIONES.Text
                Case "Reinciar Timer"
                    BtSPC.Text = "Detener Timer"
                    Timer1.Start()
                    TGUIONES.Text = "El Cronometro esta activado nuevamente" & vbNewLine & vbNewLine & TGUIONES.Text
                Case "Registrar Plantilla"
                    AgregarRegistro()
                    BtSPC.Text = "Detener Timer"
                    TGUIONES.Text = "Se ha agregado la Plantilla al historico" & vbNewLine & vbNewLine & TGUIONES.Text
            End Select
            IdllamadaT.Enabled = False
            Button11.Enabled = True
        End If
        VarGlob.Guardado = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles IDiadema.Click
        Diadema.Show()
    End Sub

    Private Sub DptoT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DptoT.SelectedIndexChanged
        If (DptoT.Text = "ANTIOQUIA") Then
            CiudadT.Text = "MEDELLIN"
            AreaTextBox.Text = "SIEBEL"
            CiudadT.Items.Clear()
            CiudadT.Items.Add("MEDELLIN")
            CiudadT.Items.Add("ABEJORRAL")
            CiudadT.Items.Add("ABRIAQUI")
            CiudadT.Items.Add("ALEJANDRIA")
            CiudadT.Items.Add("AMALFI")
            CiudadT.Items.Add("ANDES")
            CiudadT.Items.Add("ANGELOPOLIS")
            CiudadT.Items.Add("ANORI")
            CiudadT.Items.Add("ANGOSTURA")
            CiudadT.Items.Add("ANTIOQUIA")
            CiudadT.Items.Add("ANZA")
            CiudadT.Items.Add("APARTADO")
            CiudadT.Items.Add("ARBOLETES")
            CiudadT.Items.Add("ARGELIA")
            CiudadT.Items.Add("ARMENIA")
            CiudadT.Items.Add("BELMIRA")
            CiudadT.Items.Add("BETANIA")
            CiudadT.Items.Add("BETULIA")
            CiudadT.Items.Add("BRICEÑO")
            CiudadT.Items.Add("BURITICA")
            CiudadT.Items.Add("CACERES")
            CiudadT.Items.Add("CAICEDO")
            CiudadT.Items.Add("CAMPAMENTO")
            CiudadT.Items.Add("CAÑASGORDAS")
            CiudadT.Items.Add("CARACOLI")
            CiudadT.Items.Add("CARAMANTA")
            CiudadT.Items.Add("CAREPA")
            CiudadT.Items.Add("CAROLINA")
            CiudadT.Items.Add("CAUCASIA")
            CiudadT.Items.Add("CHIGORODO")
            CiudadT.Items.Add("CISNEROS")
            CiudadT.Items.Add("CIUDAD BOLIVAR")
            CiudadT.Items.Add("COCORNA")
            CiudadT.Items.Add("CONCEPCION")
            CiudadT.Items.Add("CONCORDIA")
            CiudadT.Items.Add("DABEIBA")
            CiudadT.Items.Add("DON MATIAS")
            CiudadT.Items.Add("EBEJICO")
            CiudadT.Items.Add("EL BAGRE")
            CiudadT.Items.Add("ENTRERRIOS")
            CiudadT.Items.Add("FREDONIA")
            CiudadT.Items.Add("FRONTINO")
            CiudadT.Items.Add("GIRALDO")
            CiudadT.Items.Add("GOMEZ PLATA")
            CiudadT.Items.Add("GRANADA")
            CiudadT.Items.Add("GUADALUPE")
            CiudadT.Items.Add("GUATAPE")
            CiudadT.Items.Add("GUARNE")
            CiudadT.Items.Add("HELICONIA")
            CiudadT.Items.Add("HISPANIA")
            CiudadT.Items.Add("ITUANGO")
            CiudadT.Items.Add("JARDIN")
            CiudadT.Items.Add("LA PINTADA")
            CiudadT.Items.Add("LIBORINA")
            CiudadT.Items.Add("MACEO")
            CiudadT.Items.Add("MONTEBELLO")
            CiudadT.Items.Add("MURINDO")
            CiudadT.Items.Add("MUTATA")
            CiudadT.Items.Add("NARIÑO")
            CiudadT.Items.Add("NECHI")
            CiudadT.Items.Add("NECOCLI")
            CiudadT.Items.Add("OLAYA")
            CiudadT.Items.Add("PEÑOL")
            CiudadT.Items.Add("PEQUE")
            CiudadT.Items.Add("PUEBLORRICO")
            CiudadT.Items.Add("PUERTO BERRIO")
            CiudadT.Items.Add("PUERTO BOYACA")
            CiudadT.Items.Add("PUERTO NARE")
            CiudadT.Items.Add("PUERTO TRIUNFO")
            CiudadT.Items.Add("REMEDIOS")
            CiudadT.Items.Add("SABANALARGA")
            CiudadT.Items.Add("SALGAR")
            CiudadT.Items.Add("SAN ANDRES DE CUERQUIA")
            CiudadT.Items.Add("SAN CARLOS")
            CiudadT.Items.Add("SAN FRANCISCO")
            CiudadT.Items.Add("SAN JERONIMO")
            CiudadT.Items.Add("SAN JOSE DE LA MONTAÑA")
            CiudadT.Items.Add("SAN JUAN DE URABA")
            CiudadT.Items.Add("SAN LUIS")
            CiudadT.Items.Add("SAN PEDRO")
            CiudadT.Items.Add("SAN PEDRO DE URABA")
            CiudadT.Items.Add("SAN ROQUE")
            CiudadT.Items.Add("SAN VICENTE")
            CiudadT.Items.Add("SANTA BARBARA")
            CiudadT.Items.Add("SANTA ROSA DE OSOS")
            CiudadT.Items.Add("SANTAFE DE ANTIOQUIA")
            CiudadT.Items.Add("SANTO DOMINGO")
            CiudadT.Items.Add("SEGOVIA")
            CiudadT.Items.Add("SONSON")
            CiudadT.Items.Add("SOPETRAN")
            CiudadT.Items.Add("TAMESIS")
            CiudadT.Items.Add("TARAZA")
            CiudadT.Items.Add("TARSO")
            CiudadT.Items.Add("TITIRIBI")
            CiudadT.Items.Add("TOLEDO")
            CiudadT.Items.Add("TURBO")
            CiudadT.Items.Add("URAMITA")
            CiudadT.Items.Add("URRAO")
            CiudadT.Items.Add("VALDIVIA")
            CiudadT.Items.Add("VALPARAISO")
            CiudadT.Items.Add("VEGACHI")
            CiudadT.Items.Add("VENECIA")
            CiudadT.Items.Add("VIGIA DEL FUERTE")
            CiudadT.Items.Add("YALI")
            CiudadT.Items.Add("YARUMAL")
            CiudadT.Items.Add("YOLOMBO")
            CiudadT.Items.Add("YONDO")
            CiudadT.Items.Add("ZARAGOZA")
        ElseIf (DptoT.Text = "COSTA") Then
            CiudadT.Text = "BARRANQUILLA"
            AreaTextBox.Text = "SIEBEL"
            CiudadT.Items.Clear()
            CiudadT.Items.Add("AGUACHICA")
            CiudadT.Items.Add("AGUSTIN CODAZZI")
            CiudadT.Items.Add("AYAPEL")
            CiudadT.Items.Add("BOSCONIA")
            CiudadT.Items.Add("BUENAVISTA")
            CiudadT.Items.Add("CAIMITO")
            CiudadT.Items.Add("CANALETE")
            CiudadT.Items.Add("CERETE")
            CiudadT.Items.Add("CHALAN")
            CiudadT.Items.Add("CHIMA")
            CiudadT.Items.Add("CHINU")
            CiudadT.Items.Add("CIENAGA DE ORO")
            CiudadT.Items.Add("COLOSO")
            CiudadT.Items.Add("COROZAL")
            CiudadT.Items.Add("COTORRA")
            CiudadT.Items.Add("COVEÑAS")
            CiudadT.Items.Add("GUARANDA")
            CiudadT.Items.Add("LA APARTADA")
            CiudadT.Items.Add("LORICA")
            CiudadT.Items.Add("LOS CORDOBAS")
            CiudadT.Items.Add("LOS PALMITOS")
            CiudadT.Items.Add("MAGANGUE")
            CiudadT.Items.Add("MOMIL")
            CiudadT.Items.Add("MONTERIA")
            CiudadT.Items.Add("MOÑITOS")
            CiudadT.Items.Add("MORROA")
            CiudadT.Items.Add("MOTELIBANO")
            CiudadT.Items.Add("PALMITO")
            CiudadT.Items.Add("PLANETA RICA")
            CiudadT.Items.Add("PUEBLO NUEVO")
            CiudadT.Items.Add("PUERTO ESCONDIDO")
            CiudadT.Items.Add("PURISIMA")
            CiudadT.Items.Add("SAHAGUN")
            CiudadT.Items.Add("SAMPUES")
            CiudadT.Items.Add("SAN ANDRES SOTAVENTO")
            CiudadT.Items.Add("SAN ANTERO")
            CiudadT.Items.Add("SAN BERNARDO DEL VIENTO")
            CiudadT.Items.Add("SAN CARLOS")
            CiudadT.Items.Add("SAN JOSE DE URE")
            CiudadT.Items.Add("SAN JUAN DE BETULIA")
            CiudadT.Items.Add("SAN LUIS DE SINCE")
            CiudadT.Items.Add("SAN MARCOS")
            CiudadT.Items.Add("SAN ONOFRE")
            CiudadT.Items.Add("SAN PEDRO")
            CiudadT.Items.Add("SAN PELAYO")
            CiudadT.Items.Add("SANTOA DE TOLU")
            CiudadT.Items.Add("SINCELEJO")
            CiudadT.Items.Add("SUCRE")
            CiudadT.Items.Add("TIERRA ALTA")
            CiudadT.Items.Add("TUCHIN")
            CiudadT.Items.Add("VALENCIA")
            CiudadT.Items.Add("VALLEDUPAR")
        ElseIf (DptoT.Text = "EJE CAFETERO") Then
            CiudadT.Text = "MANIZALES"
            AreaTextBox.Text = "ELITE"
            TSElite()
            CiudadT.Items.Clear()
            CiudadT.Items.Add("ARMENIA")
            CiudadT.Items.Add("BUGA")
            CiudadT.Items.Add("MANIZALES")
            AreaTextBox.Text = "ELITE"
        ElseIf (DptoT.Text = "TOLIMA") Then
            CiudadT.Text = "IBAGUE"
            AreaTextBox.Text = "ETP"
            CiudadT.Items.Clear()
            CiudadT.Items.Add("IBAGUE")
        ElseIf (DptoT.Text = "VALLE") Then
            CiudadT.Items.Clear()
            AreaTextBox.Text = "ETP"
            CiudadT.Text = "CARTAGO"
            CiudadT.Items.Add("CARTAGO")
        ElseIf (DptoT.Text = "QUINDIO") Then
            CiudadT.Text = "LA TEBAIDA"
            AreaTextBox.Text = "ETP"
            CiudadT.Items.Clear()
            CiudadT.Items.Add("LA TEBAIDA")
        ElseIf (DptoT.Text = "RISARALDA") Then
            CiudadT.Text = "PEREIRA"
            AreaTextBox.Text = "ETP"
            CiudadT.Items.Clear()
            CiudadT.Items.Add("PEREIRA")
            CiudadT.Items.Add("DOSQUEBRADAS")
            CiudadT.Items.Add("SANTA ROSA DE CABAL")
            CiudadT.Items.Add("LA VIRGINIA")
        End If
    End Sub

    Private Sub CausaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ayuda_Ventas.Show()
    End Sub
    Private Sub AgregarRegistro()
        Registros.Show()
        Dim Activo As String = "N/A"
        Dim CC As String = "N/A"
        Dim Check As String = "OK"
        Dim Diagnostico As String = "NA"
        VContacto(MovilT.Text, FijoT.Text)
        '***********************
        If (IdServicioT.Text <> "") Then
            Activo = IdServicioT.Text
        End If
        '**********************
        If (CCvisible.Text <> CCContactoT.Text) Then
            CC = CCvisible.Text + " / " + CCContactoT.Text
        Else
            CC = CCvisible.Text
        End If
        '************************
        If (Tinteracion.Text = "UPS" Or Tinteracion.Text = "CROSS") Then
            Check = Tinteracion.Text
        Else
            If (CheckBox1.Checked = True) Then
                Check = "PENDIENTE"
            Else
                Check = "OK"
            End If
        End If
        If VarGlob.Vobo = True Then
            Diagnostico = VarGlob.SDiagnostico
        End If
        Registros.Llamadas.Rows.Add(Check, IdllamadaT.Text, CNombreTextBox.Text, CC, Activo, PIntegralT.Text, VContacto(MovilT.Text, FijoT.Text), txtProceso.Text, TxDireccion.Text, Diagnostico, Label6.Text)
        VarGlob.Guardado = True
        Registros.Hide()
    End Sub

    Private Sub FallaAplicativoGralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FallaAplicativoGralToolStripMenuItem.Click
        If (String.IsNullOrEmpty(VarGlob.TEspecial) = False) Then
            txtProceso.Text = txtProceso.Text & " || " & VarGlob.TEspecial
        Else
            MsgBox("No se ha definido")
        End If
    End Sub
    Private Sub ComboBox2_GotFocus(sender As Object, e As EventArgs) Handles ComboBox2.GotFocus

        If (TextBox1.Text = "cliente") Then
            ComboBox2.Text = "@sincorreo.com"
        Else
            ComboBox2.Text = "@"
            ComboBox2.SelectionStart = ComboBox2.Text.Length
        End If
    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then
            IdServicioT.Focus()
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.KeyChar = Char.ToLower(e.KeyChar)
    End Sub

    Private Sub ComboBox2_LostFocus(sender As Object, e As EventArgs) Handles ComboBox2.LostFocus
        If (ComboBox2.Text.Length >5) Then
            Dim dcorreo As String = ComboBox2.Text
            Dim vcorreo As String = dcorreo.Substring(0, 1)

            If (vcorreo <> "@") Then
                ComboBox2.Text = "@" & dcorreo
            End If
        Else
            MsgBox("Debes determinar el dominio, el @, se agrega automaticamente, no necesitas escribirlo")
            ComboBox2.Text = "@sincorreo.com"
            TextBox1.Focus()
        End If

        If (ComboBox2.Text <> "@sincorreo.com") Then
            ComboBox2.BackColor = White
        Else
            ComboBox2.BackColor = GreenYellow
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        CorreoT.Text = TextBox1.Text & ComboBox2.Text
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If (TextBox1.Text = "cliente") Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.KeyChar = Char.ToLower(e.KeyChar)
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        CorreoT.Text = TextBox1.Text & ComboBox2.Text
        If (TextBox1.Text = "") Then
            TextBox1.Text = "cliente"
        End If
        If (TextBox1.Text <> "cliente") Then
            TextBox1.BackColor = White

            'dividir correo
            VarGlob.Partir = TextBox1.Text
            Dim Parroba As Integer = VarGlob.Partir.IndexOf("@", 0)
            If (Parroba > 0) Then
                TextBox1.Text = VarGlob.Partir.Substring(0, Parroba)
                TGUIONES.Text = "Recuerda el Dominio comienza @" & VarGlob.Partir.Substring(Parroba + 1, 4) & "..." & vbNewLine & vbNewLine & TGUIONES.Text
            End If

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Cronometro.Close()
        Application.Exit()
    End Sub

    Private Sub MODEMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODEMSToolStripMenuItem.Click
        Modems.Show()
        Modems.BringToFront()
    End Sub

    Private Sub DiademaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiademaToolStripMenuItem.Click
        Diadema.Show()
        Diadema.BringToFront()
    End Sub

    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        Notas.Show()
        Notas.BringToFront()
    End Sub

    Private Sub EliteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliteToolStripMenuItem.Click
        System.Diagnostics.Process.Start("cmd.exe", "/C echo Iniciando WTS.. &title WTS & mstsc /v:172.20.2.10")
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        System.Diagnostics.Process.Start("cmd.exe", "/C echo WTS Nacional - 167 -  &title - 172.20.2.167 - WTS & mstsc /v:172.20.2.167")
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        System.Diagnostics.Process.Start("cmd.exe", "/C echo WTS Nacional - 140 -  &title WTS - 172.20.2.140 -  mstsc /v:172.20.2.140")
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        System.Diagnostics.Process.Start("cmd.exe", "/C echo WTS Nacional - 150 -  &title WTS - 172.20.2.150 - & mstsc /v:172.20.2.150")
    End Sub

    Private Sub SMNETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMNETToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://smnet.une.net.co:8080/smnet/")
    End Sub
    Private Sub SiebelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SiebelToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("iexplore.exe", "http://unecrm/ecommunications_esn/")
    End Sub

    Private Sub CorreoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CorreoToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://correo.emtelco.com.co")
    End Sub

    Private Sub ContingenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContingenciaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://10.1.1.11/")
    End Sub
    Private Sub WFOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WFOToolStripMenuItem.Click
        System.Diagnostics.Process.Start("iexplore.exe", "http://emt-wfowfm01:7001/wfo/control/dashboard_view")
    End Sub
    Private Sub GDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GDIToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://10.5.105.27:8080/gdi/gdi.php")
    End Sub
    Private Sub MaestroDeContenidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeContenidosToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto.une.com.co/forms/Hogares/MaestroContenidos/login.php")
    End Sub
    Private Sub VisitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitasToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://10.65.73.86/VisitasTerreno/Consultalist.php?")
    End Sub
    Private Sub ChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChatToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://10.5.105.27:8080/Agendamiento_gace2E/login.php")
    End Sub

    Private Sub TR69ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TR69ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://10.158.108.218/live/AXSupportPortal/portal/")
    End Sub

    Private Sub ConfrontaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfrontaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://cifin.asobancaria.com/cifin/index.jsp")
    End Sub

    Private Sub ANSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ANSToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://10.65.73.86/VisitasTerreno/ConsultarVsitaslist.php")
    End Sub

    Private Sub GuionesSTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuionesSTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/index.php/nuac-on?id=406 ")
    End Sub

    Private Sub ContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratoToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://10.65.73.86/CambiosPortafolio/")
    End Sub

    Private Sub TarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifasToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/images/Base_Datos_Hogares/PRY_TARIFAS_7.0/index.htm")
    End Sub

    Private Sub QuizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuizToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://web.emtelco.co/emensual/tigoune/login.php")
    End Sub

    Private Sub NovedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovedadesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://biblioteca/nomina_emtelco/index.php?exit=true")
    End Sub

    Private Sub MonitoreosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoreosToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://olimpo/emtelco/monitoreo/DesempeñoMisNotas.aspx")
    End Sub

    Private Sub AutogestionWTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutogestionWTSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://icu.epmtelco.com.co/index.php?r=selfmanagement/PassManagement/")
    End Sub

    Private Sub SrUNEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SrUNEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto.une.com.co/SRUNE/login.php")
    End Sub

    Private Sub RadarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadarToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://radarplus.computec.com.co/acceso/UI/Login")
    End Sub
    Private Sub PYMESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PYMESToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/index.php/nuac-on?id=405")
    End Sub

    Private Sub GISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GISToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://sigweb/cartografiacol/")
    End Sub
    Private Sub SiebelToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SiebelToolStripMenuItem.Click
        System.Diagnostics.Process.Start("iexplore.exe", "http://unecrm/ecommunications_esn/")
    End Sub
    Private Sub Siebel2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Siebel2ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("iexplore.exe", "http://unecrm2/ecommunications_esn/")
    End Sub
    Private Sub GuionesVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuionesVentasToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto.une.com.co/forms/Hogares/MaestroContenidos/login.php")
    End Sub
    Private Sub SiebelPrivadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SiebelPrivadoToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("iexplore.exe", " -private http://unecrm/ecommunications_esn/")
    End Sub

    Private Sub ForviToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ForviToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://biblioteca/tigoune/formacionvirtual/forvi/login/index.php")
    End Sub

    Private Sub MaestroDeContenidosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PuntosMenu.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/")
    End Sub

    Private Sub WEBMAILToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WEBMAILToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://webmail.une.net.co")
    End Sub
    Private Sub SoporteADSLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteADSLToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/index.php/st-nuac-nacional/st-tecnologia-redco")
    End Sub

    Private Sub SoporteHFCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteHFCToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/index.php/st-nuac-nacional/st-tecnologia-hfc")
    End Sub
    Private Sub DataCreditoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataCreditoToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://www.datacredito.com.co/")
    End Sub
    Private Sub FijoT_LostFocus(sender As Object, e As EventArgs) Handles FijoT.LostFocus
        If (FijoT.Text = "") Then
            FijoT.Text = "8888888"
        End If
        If (FijoT.TextLength <> 7) Then
            If (FijoT.TextLength > 7) Then
                Dim Fijo1 As String = FijoT.Text
                FijoT.Text = Fijo1.Substring(FijoT.TextLength - 7, 7)
                FijoT.BackColor = YellowGreen
            Else
                MsgBox("Minimo 7 caracteres")
                FijoT.Focus()
                FijoT.BackColor = YellowGreen
            End If
        Else
            FijoT.BackColor = White
        End If

    End Sub
    Private Sub Tinteracion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tinteracion.SelectedIndexChanged, BtActualizar.Click, IAna.Click
        If (IdllamadaT.Text <> "" And CCTitularTextBox.Text <> "") Then
            Select Case Tinteracion.Text
                Case "SPC", "ASESORIA"
                    If (Tinteracion.Text = "ASESORIA") Then
                        Label1.Text = "Observaciones: User solicita "
                    Else
                        Label1.Text = "Observaciones: User manifiesta que:"
                    End If
                    VPlantillaC()
                    If (VarGlob.Plantilla <> Nothing) Then
                        txtProceso.Text = VarGlob.Plantilla
                    End If
                    ValSMNET.Enabled = True
                    Asesoria()
                    Gok()
                    VContacto(MovilT.Text, FijoT.Text)
                Case "TERRENO"
                    Label1.text = "Observaciones: User manifiesta que:"
                    VPlantillaC()
                    If (VarGlob.Plantilla <> Nothing) Then
                        txtProceso.Text = VarGlob.Plantilla
                    End If
                    ValSMNET.Enabled = True
                    Asesoria()
                    TGUIONES.ForeColor = Black
                    TGUIONES.Text = "Sr/ Sra " & CNombreTextBox.Text & " su visita queda para (fecha acordada), en el transcurso de la (franja acordada).  Puede llamarnos a este mismo numero para consultar o modificar la fecha de la visita, tambien para validar los datos del tecnico asignado." & _
                        " Sr/sra " & CNombreTextBox.Text & " Le invitamos a responder nuestra encuensta de servicio, recuerde, si le gusto como le atendí califiqueme con 5." & _
                             " gracias por haberse comunicado con nosotros, En TigoUne estamos para usted, le deseamos " & Momento2(TimeOfDay.Hour)
                    VContacto(MovilT.Text, FijoT.Text)
                Case "FALLA SIEBEL/SMNET - TERRENO", "FALLA SIEBEL/SMNET - OTRO"
                    VPlantillaC()
                    If (VarGlob.Plantilla <> Nothing) Then
                        txtProceso.Text = VarGlob.Plantilla
                    End If
                    txtProceso.Text = "Id-LLamada: " & IdllamadaT.Text & VPSMNET(PIntegralT.Text, PIndividualT.Text) & "Falla en Aplicativos no se puede realizar validaciones, se realizan descartes físicos  >> Contacto: " & CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & " " & VContacto(MovilT.Text, FijoT.Text)
                    If (TCausa.Text <> Nothing) Then
                        txtProceso.Text = txtProceso.Text & " **" & TCausa.Text
                    End If
                    If (String.IsNullOrEmpty(VarGlob.TEspecial) = False) Then
                        txtProceso.Text = txtProceso.Text & " || " & VarGlob.TEspecial
                    End If
                    TGUIONES.ForeColor = Black
                    TGUIONES.Text = "Sr/sra " & CNombreTextBox.Text & " En estos momento nuestros sistemas de Información se encuentra en Actualización por lo que no puedo gestionar su solcitud de forma imnediata, por favor permitame tomar unos datos para generar un reporta, una vez finalizado el proceso, nos estaremos comunicando con Usted para gestionar la solución"
                    VContacto(MovilT.Text, FijoT.Text)
                Case "OTROS"
                    VPlantillaC()
                    ValSMNET.Enabled = True
                    Gok()
                Case "TRASFERENCIA"
                    Tavaya()
                    Gtrasferencia()
                Case "UPS"
                    VPlantillaC()
                    UPS()
                    TGUIONES.ForeColor = Black
                    TGUIONES.Text = "Señor (a) " & CNombreTextBox.Text & " de acuerdo al cambio que acabamos de hacer en su plan, los cobros de estos nuevos valores que le acabo de informar se verán reflejados en su factura dentro de (2 ó 3) meses aproximadamente, esto debido a que los planes anteriores deben terminar su consumo completo, recibirá el cobro de sus servicios nuevos (migrados, upgrade) empezará a recibirlos en la siguiente periodo: ____________"
                    VContacto(MovilT.Text, FijoT.Text)
                    If (VarGlob.Guardado = False) Then
                        BtSPC.Text = "Guardar Plantilla"
                    Else
                        BtSPC.Text = "Registrar Plantilla"
                    End If
                Case "CROSS"
                    VPlantillaC()
                    CROX()
                    TGUIONES.ForeColor = Black
                    TGuion.Text = "Despedida venta"
                    TGUIONES.Text = "Bienvenido a la familia TIGOUNE: Sr/Sra. " & CNombreTextBox.Text & ", bienvenid@ a nuestra compañía, recuerde que el prestador de los servicios es UNE EPM telecomunicaciones y espero que en el menor tiempo posible usted y los miembros de su familia puedan empezar a disfrutar de todos " & _
                        " estos servicios. Recuerde: Su número de pedido es xxxx, el detalle de la permanencia mínima, al igual que el número de contrato le serán informados en su factura"
                    VContacto(MovilT.Text, FijoT.Text)
                    If (VarGlob.Guardado = False) Then
                        BtSPC.Text = "Guardar Plantilla"
                    Else
                        BtSPC.Text = "Registrar Plantilla"
                    End If
            End Select
        End If
    End Sub
    Private Sub Gok()
        TGUIONES.ForeColor = Black
        TGUIONES.Text = "La Plantilla está copiada, solo preciona pegar (Ctrl + V) donde la necesites" & vbNewLine & vbNewLine & "Sr/sra " & CNombreTextBox.Text & vbNewLine & "1 >> ¿Ya conoce como puede mejorar sus servicios con el plan que TigoUne tiene para su hogar?. << UPS >>" & vbNewLine & "2 >> Sabias que con TigoUNE no te pierdes tus partidos favoritos porque los puedes ver desde cualquier lugar usando nuestra aplicacion UneTV? << TV >>" & vbNewLine & "3 >>  ¿Que le parece llamar desde su teléfono fijo a celulares gratis todos los meses? << TELEFONIA >> " & vbNewLine & "4 >> Sabe que con nuestros planes puedes descargar ilimitadamente todo los contenidos de internet en su hogar << INTERNET >> ..." & vbNewLine & "¿En que mas le puedo Servir? ....Sr/sra " & CNombreTextBox.Text & " Le invitamos a responder nuestra encuensta de servicio, recuerde, si le gusto como le atendí califiqueme con 5." & " gracias por haberse comunicado con nosotros, En TigoUne estamos para usted, le deseamos " & Momento2(TimeOfDay.Hour)
    End Sub
    Private Sub TransferenciaMenu_Click(sender As Object, e As EventArgs) Handles TransferenciaMenu.Click
        Tavaya()
    End Sub
    Private Sub ServiciosSupMenu_Click(sender As Object, e As EventArgs) Handles ServiciosSupMenu.Click
        Tinteracion.Text = "OTROS"
        Tcausa.text = " Servicios Suspendidos"
        Tinteracion.Text = "TRASFERENCIA"
    End Sub

    Private Sub TramitesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TramitesToolStripMenuItem.Click
        Dim Dir As String = CiudadT.Text
        If (TxDireccion.Text <> Nothing) Then
            Dir = TxDireccion.Text & " - " & CiudadT.Text
        End If
        Tinteracion.Text = "OTROS"
        Tcausa.text = " Tramite Pendiente"
        Tinteracion.Text = "TRASFERENCIA"
    End Sub

    Private Sub CCvisible_KeyUp(sender As Object, e As KeyEventArgs) Handles CCvisible.KeyUp
        If (CCTitularTextBox.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(CCTitularTextBox.Text, importe)
            CCTitularTextBox.Text = String.Format("{0:N0}", importe)
            CCTitularTextBox.SelectionStart = CCTitularTextBox.TextLength
        End If
    End Sub

    Private Sub LlamadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlamadasToolStripMenuItem.Click
        Registros.Show()
    End Sub
    Private Sub TSElite()
        If (AreaTextBox.Text = "ELITE") Then
            If (IdServicioT.Text = "") Then
                IdServicioT.Text = "-"
            End If
            If (PIntegralT.Text = "") Then
                PIntegralT.Text = "-"
            End If
            If (PIndividualT.Text = "") Then
                PIndividualT.Text = "-"
            End If
        End If
    End Sub

    Private Sub TSSiebel()
        If (AreaTextBox.Text = "SIEBEL") Then
            If (IdServicioT.Text = "-") Then
                IdServicioT.Text = ""
            End If
            If (PIntegralT.Text = "-") Then
                PIntegralT.Text = ""
            End If
            If (PIndividualT.Text = "-") Then
                PIndividualT.Text = ""
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (AreaTextBox.Text <> "ELITE") Then
            If (IdServicioT.Text <> Nothing And PIntegralT.Text <> Nothing) Then
                TSSiebel()
                Checklist.Show()
                Checklist.BringToFront()
            Else
                MsgBox("Es necesario inidcar el servicio, las pruebas SMNET para generar la Plantilla")
                IdServicioT.Focus()
                TGUIONES.Text = "¡¡ Para realizar el Checklist, necesitas haber hecho el diagnostico en SMNET, por lo que debes indicar el servicio y las pruebas, para que la plantilla se genere correctamente !!" & TGUIONES.Text
            End If
        Else
            TSElite()
            Checklist.Show()
            Checklist.BringToFront()
        End If
    End Sub
    Private Sub EliteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliteToolStripMenuItem1.Click
        VPlantillaC()
        If (AreaTextBox.Text = "ELITE") Then
            If (Tcausa.text <> Nothing) Then
                txtProceso.Text = "Id-LLamada: " & IdllamadaT.Text & " - " & CiudadT.Text & " || " & TCausa.Text
                TSElite()

            Else
                MsgBox("Indicar: Diagnostico")
            End If
        Else
            MsgBox("Zona debe ser Elite")
        End If
    End Sub

    Private Sub LlamadaMudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlamadaMudaToolStripMenuItem.Click
        LlMuda()
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoToolStripMenuItem.Click
        EReport()
    End Sub

    Private Sub CerrarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarReporteToolStripMenuItem.Click
        SOK()
    End Sub

    Private Sub FallaDeComunicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FallaDeComunicacionToolStripMenuItem.Click
        FComunicacion()
    End Sub

    Private Sub CronometroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CronometroToolStripMenuItem.Click
        Cronometro.Show()
        Cronometro.BringToFront()
    End Sub
    'PLANTILLA UPS
    Private Sub UPS()
        Dim Canal As Integer = 924
        If (AreaTextBox.Text = "SIEBEL" Or AreaTextBox.Text = "EDATEL/SIEBEL") Then
            Canal = 179400
        End If
        txtProceso.Text = "Usuario De Red : " & Environment.UserName & vbNewLine & "Código Asesor Venta: " & vbNewLine & "Código de Canal Venta: " & Canal & vbNewLine & "Departamento: " & DptoT.Text & vbNewLine & "Ciudad : " & CiudadT.Text & vbNewLine & "Dirección: " & TxDireccion.Text & vbNewLine & "Codigo Familiar: " & vbNewLine & "Titular: Nombres y Apellidos: " & CNombreTextBox.Text & vbNewLine & "Cédula: " & CCvisible.Text & vbNewLine & "Fijo: " & FijoT.Text & vbNewLine & "Movil: " & MovilT.Text & vbNewLine & "Correo Electrónico: " & CorreoT.Text & vbNewLine & "Estrato: " & vbNewLine & "Id de Llamada:" & IdllamadaT.Text & vbNewLine & vbNewLine & "Promoción: " & vbNewLine & "VALOR:" & vbNewLine & vbNewLine & "Autoriza el envió Factura web:" & vbNewLine & "Qué tipo de contrato desea recibir?   Resumido / Completo" & vbNewLine & "Mensajes al celular?:  Si /No" & vbNewLine & "Por qué medio desea recibir el contrato?: Físico / Mail " & vbNewLine & "Hábeas Data ...Sr/Sra. " & CNombreTextBox.Text & " ¿Autoriza a Une, Su grupo empresarial y aliados para el uso de sus datos con fines comerciales y la adecuada prestación del servicio? Que medios autoriza (Correo electrónico (Mail), Mensajes de Texto (SMS), Tele mercadeo, Correo Físico.)" & vbNewLine & " Autoriza Datos Personales:   Si  / No  " & vbNewLine & "Tipo de Autorización: Grupo:  Empr y Aliados  / Une  /  Une y Aliados /  N/a  " & vbNewLine & "Métodos Autorizados: E-mail , C. Físico,  SMS,  Tele mercadeo  o Todos"
    End Sub

    'PLANTILLA CROX
    Private Sub CROX()
        Dim Canal As Integer = 924
        Dim DCiudad As String = "Ciudad: " & CiudadT.Text
        If (AreaTextBox.Text = "SIEBEL" Or AreaTextBox.Text = "EDATEL/SIEBEL") Then
            Canal = 179400
        End If
        If (CiudadT.Text = "CARTAGENA") Then
            DCiudad = "Ciudad: CARTAGENA" & vbNewLine & "Punto de Referencia: "
        End If
        txtProceso.Text = "Usuario De Red : " & Environment.UserName & vbNewLine & "Código Asesor Venta: " & vbNewLine & "Código de Canal Venta: " & Canal & vbNewLine & "No. Documento: " & CCvisible.Text & vbNewLine & "Nombres y Apellidos: " & CNombreTextBox.Text & vbNewLine & "Fecha de Expedición: " & vbNewLine & "Departamento de Expedición: " & vbNewLine & "Ciudad de Expedición: " & vbNewLine & " Fijo: " & FijoT.Text & vbNewLine & "Movil: " & MovilT.Text & vbNewLine & "Correo Electrónico: " & CorreoT.Text & vbNewLine & "Genero: Masculino / Femenino" & vbNewLine & "Aficiones: (Cine / Teatro / Música)" & vbNewLine & "Departamento: " & DptoT.Text & vbNewLine & DCiudad & vbNewLine & "Dirección: " & TxDireccion.Text & vbNewLine & "Barrio: " & vbNewLine & "Estrato: " & vbNewLine & "Tipo Predio: Casa  /  Apartamento" & vbNewLine & "Tipo Propiedad: Conjunto residencial  / Edificio  / Ninguno  " & vbNewLine & "Nombre Conjunto o edificio:" & vbNewLine & "Indicar servicios solicitado :" & vbNewLine & "Promoción:" & vbNewLine & "Valor" & vbNewLine & "Cambio de tecnología: Si / NO" & vbNewLine & "Hábeas Data ...Sr/Sra. " & CNombreTextBox.Text & " ¿Autoriza a Une, Su grupo empresarial y aliados para el uso de sus datos con fines comerciales y la adecuada prestación del servicio? Que medios autoriza (Correo electrónico (Mail), Mensajes de Texto (SMS), Tele mercadeo, Correo Físico.)" & vbNewLine & " Autoriza Datos Personales:   Si  / No  " & vbNewLine & "Tipo de Autorización: Grupo:  Empr y Aliados  / Une  /  Une y Aliados /  N/a" & vbNewLine & "Métodos Autorizados: E-mail , C. Físico,  SMS,  Tele mercadeo  o Todos" & vbNewLine & "Id de Llamada:" & IdllamadaT.Text & vbNewLine & "Evidente / Confronta: " & vbNewLine & "Agendiamiento Fecha Tentativa: (DD/MM/AAAA) Jornada: AM / PM" & vbNewLine & "Autoriza el envió Factura web:" & vbNewLine & "Qué tipo de contrato desea recibir?   Resumido / Completo" & vbNewLine & "Mensajes al celular?:  Si /No" & vbNewLine & "Por qué medio desea recibir el contrato?: Físico / Mail " & vbNewLine & "Sr/Sra. " & CNombreTextBox.Text & ", Autoriza a Une para el uso de sus datos personales con el fin de consultar su historial crediticio y reporta Información ante entidades crediticias ¿ Nos autoriza para realizar la consulta ?  R//  Si / No" & vbNewLine & vbNewLine & "Ref. familiar" & vbNewLine & "Nombre: " & vbNewLine & "Tel:" & vbNewLine & vbNewLine & "Ref. Personal" & vbNewLine & "Nombre: " & vbNewLine & "Tel:"
    End Sub


    Private Sub RegistroDeLlamadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeLlamadasToolStripMenuItem.Click
        Registros.Show()
        Registros.BringToFront()
    End Sub

    Private Sub CmdIniciar_Click(sender As Object, e As EventArgs) Handles CmdIniciar.Click
        If (CmdIniciar.Text = ">>") Then
            CmdIniciar.Text = "||"
            LbMinutos.Text = "00"
            LbSegndos.Text = "00"
            Cronometro.LbMinutos.Text = "00"
            Cronometro.LbSegndos.Text = "00"
            If (GVariables.contador = 0) Then
                MsgBox("Sr/ Sra " & CNombreTextBox.Text & " teniendo en cuenta toda la información que me brindó, voy a realizar una revisión y análisis completo de su caso. Le pido " & ProcesarT1(TextBox2.Text) & " para gestionar")
            Else
                Dim Nm As Integer = VarGlob.Contador Mod 2
                If (Nm <> 0) Then
                    MsgBox("Sr/ Sra " & CNombreTextBox.Text & " le agradezco por su paciencia, sigo en la gestión del caso. Le pido por favor " & ProcesarT1(TextBox2.Text) & " mas")
                Else
                    MsgBox("Sr/ Sra " & CNombreTextBox.Text & " le agradezco por su paciencia, en estos momentos el sistema se encuetra procesando la información por lo tanto le pido " & ProcesarT1(TextBox2.Text) & " mas, gracias")
                End If
            End If
            GVariables.contador = GVariables.contador + 1
        Else
            CmdIniciar.Text = ">>"
            CmdIniciar.BackColor = Transparent
            GCRONOMETRO.BackColor = Transparent
            Cronometro.BackColor = White
        End If
    End Sub
    Public Sub ICronometro()
        CmdIniciar.Text = "||"
        LbMinutos.Text = "00"
        LbSegndos.Text = "00"
        Cronometro.LbMinutos.Text = "00"
        Cronometro.LbSegndos.Text = "00"
        CmdIniciar.BackColor = Transparent
        GCRONOMETRO.BackColor = Transparent
        Cronometro.BackColor = White
        txtProceso.Focus()
        If (GVariables.contador = 0) Then
            MsgBox("Sr/ Sra " & CNombreTextBox.Text & " teniendo en cuenta toda la información que me brindó, voy a realizar una revisión y análisis completo de su caso. Le pido " & ProcesarT1(TextBox2.Text) & " para gestionar")
        Else
            Dim Nm As Integer = VarGlob.Contador Mod 2
            If (Nm <> 0) Then
                MsgBox("Sr/ Sra " & CNombreTextBox.Text & " le agradezco por su paciencia, sigo en la gestión del caso. Le pido por favor " & ProcesarT1(TextBox2.Text) & " mas")
            Else
                MsgBox("Sr/ Sra " & CNombreTextBox.Text & " le agradezco por su paciencia, en estos momentos el sistema se encuetra procesando la información por lo tanto le pido " & ProcesarT1(TextBox2.Text) & " mas, gracias")
            End If
        End If
        GVariables.contador = GVariables.contador + 1
    End Sub
    Private Sub SimuladorVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimuladorVentasToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://simuladorventas.epmtelco.com.co/")
    End Sub

    Private Sub GrillaDeCanalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrillaDeCanalesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/images/Base_Datos_Hogares/Grilla_Canales_UNE/index.html")
    End Sub

    Private Sub BaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseDeDatosToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/index.php/bases-de-datos-st")
    End Sub

    Private Sub EliteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EliteToolStripMenuItem2.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://puntosdecontacto/index.php/aplicativos-st")
    End Sub

    Private Sub IdServicioT_GotFocus(sender As Object, e As EventArgs) Handles IdServicioT.GotFocus, PIndividualT.GotFocus, Button5.Click
        If (VarGlob.A < 1) Then
            VContacto(MovilT.Text, FijoT.Text)
            VarGlob.A = VarGlob.A + 1
        End If
        AGuardar()
    End Sub

    Private Sub PlantillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlantillaToolStripMenuItem.Click
        Asesoria()
    End Sub

    Private Sub BackSSOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackSSOToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://backsso.une.net.co/index.php")
    End Sub

    Private Sub BackSISAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackSISAToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://backsisac.une.com.co/")
    End Sub

    Private Sub txtProceso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProceso.KeyDown, TCausa.KeyDown
        If e.KeyData = Keys.Control + Keys.S Then
            Asesoria()
        ElseIf e.KeyData = Keys.Control + Keys.E Then
            EReport()
        ElseIf e.KeyData = Keys.Control + Keys.O Then
            SOK()
        ElseIf e.KeyData = Keys.Control + Keys.F Then
            FComunicacion()
        ElseIf e.KeyData = Keys.Control + Keys.K Then
            Tavaya()
        ElseIf e.KeyData = Keys.Control + Keys.P Then
            LlMuda()
        ElseIf e.KeyData = Keys.Escape Then
            If Button11.Enabled = True Then
                LIMPIAR()
                GCRONOMETRO.BackColor = Transparent
                If (VarGlob.Guardado = True) Then
                    Tinteracion.Focus()
                Else
                    IdllamadaT.Focus()
                End If
            Else
                MsgBox("Después de guardar, puedes limpiar")
            End If
        End If

    End Sub

    Function VContacto(ByRef M1 As String, T2 As String) As String
        Dim Tcontaco As String = ""
        If (MovilT.Text <> "3338888888" And FijoT.Text = "8888888") Then
            Tcontaco = "Cel: " & MovilT.Text
            TGUIONES.Text = "!! No has Actualizado numero fijo !!" & vbNewLine & vbNewLine & TGUIONES.Text
            Cronometro.TAlerta.Text = "!! No has Actualizado numero fijo !!"
            FijoT.BackColor = GreenYellow
        ElseIf (MovilT.Text = "3338888888" And FijoT.Text <> "8888888") Then
            Tcontaco = "Fijo: " & FijoT.Text
            TGUIONES.Text = "!! No has Actualizado numero Movil !!" & vbNewLine & vbNewLine & TGUIONES.Text
            MovilT.BackColor = GreenYellow
            Cronometro.TAlerta.Text = Cronometro.TAlerta.Text & " !! No has Actualizado numero Movil !!"
        ElseIf (MovilT.Text = "3338888888" And FijoT.Text = "8888888") Then
            Tcontaco = ""
            TGUIONES.Text = "!! No has Actualizado los numeros de contacto !!" & vbNewLine & vbNewLine & TGUIONES.Text
            Cronometro.TAlerta.Text = "!! No has Actualizado los contactos !!"
            MovilT.BackColor = GreenYellow
            FijoT.BackColor = GreenYellow
        ElseIf (MovilT.Text <> "3338888888" And FijoT.Text <> "8888888") Then
            Tcontaco = "Cel: " & MovilT.Text & "  Fijo: " & FijoT.Text
            TGUIONES.Text = "!!Excelente, los contactos estaban actualizado !!" & vbNewLine & vbNewLine & TGUIONES.Text
            Cronometro.TAlerta.Text = " !! Contactos actualizados !!"
        End If
        If (TextBox1.Text = "cliente") Then
            TGUIONES.Text = "¡¡ Recuerda Validar el correo !!" & vbNewLine & vbNewLine & TGUIONES.Text
            TextBox1.BackColor = GreenYellow
            Cronometro.TAlerta.Text = Cronometro.TAlerta.Text & " -- ¡¡ Recuerda Validar el correo !!"
            ComboBox2.BackColor = GreenYellow
        End If
        Return Tcontaco
    End Function

    Function VID(ByVal A As String, B As String) As String
        Dim ID As String = " CC: " & CCvisible.Text
        If (ComboBox1.Text <> "") Then
            ID = " NIT: " & Trim(CCvisible.Text & Trim(ComboBox1.Text))
        End If
        Return ID
    End Function

    Function VPSMNET(ByVal E As String, F As String) As String
        Dim Prueba As String = ""
        If (PIntegralT.Text <> "" And PIndividualT.Text = "") Then
            Prueba = vbNewLine & "Id-Servicio: " & IdServicioT.Text & vbNewLine & "Prueba Integral: " & PIntegralT.Text & vbNewLine
        ElseIf (PIntegralT.Text = "" And PIndividualT.Text <> "") Then
            Prueba = vbNewLine & "Id-Servicio: " & IdServicioT.Text & vbNewLine & "Prueba Individual: " & PIndividualT.Text & vbNewLine
        ElseIf (PIntegralT.Text = "" And PIndividualT.Text = "") Then
            If (IdServicioT.Text <> Nothing) Then
                Prueba = vbNewLine & "Id-Servicio: " & IdServicioT.Text & vbNewLine
            Else
                If (VarGlob.TEspecial <> Nothing) Then
                    Prueba = VarGlob.TEspecial & vbNewLine
                Else
                    Prueba = ""
                End If
            End If
        ElseIf (PIntegralT.Text <> "" And PIndividualT.Text <> "") Then
            Prueba = vbNewLine & "Id-Servicio: " & IdServicioT.Text & vbNewLine & "Prueba Integral: " & PIntegralT.Text & vbNewLine & "Prueba Individual: " & PIndividualT.Text & vbNewLine
        End If
        Return Prueba
    End Function

    Private Sub Asesoria()
        '***********************
        Dim TCausa1 As String = ""
        If (TCausa.Text <> "") Then
            If (Tinteracion.Text = "ASESORIA") Then
                TCausa1 = "User solicita " & TCausa.Text
            Else
                TCausa1 = "User manifiesta: " & TCausa.Text
            End If
        Else
            TCausa1 = ""
        End If

        If (AreaTextBox.Text <> "ELITE") Then
            If (Tinteracion.Text = "SPC" Or Tinteracion.Text = "TERRENO" Or Tinteracion.Text = "ASESORIA") Then
                If (VSMNET(IdServicioT.Text, PIntegralT.Text) = True) Then
                    VPlantillaC()
                    If (VarGlob.Checklist = "") Then
                        txtProceso.Text = "UCID: " & IdllamadaT.Text & VPSMNET(PIntegralT.Text, PIndividualT.Text) & TCausa1 & VarGlob.SAvanzado & " ::  Contacto: " & CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & " " & VContacto(MovilT.Text, FijoT.Text)
                        CopiarPlantilla()
                    Else
                        txtProceso.Text = "UCID: " & IdllamadaT.Text & VPSMNET(PIntegralT.Text, PIndividualT.Text) & TCausa1 & VarGlob.Checklist & VarGlob.SAvanzado & " :: Contacto: " & CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & " " & VContacto(MovilT.Text, FijoT.Text)
                        CopiarPlantilla()
                    End If
                Else
                    MsgBox("Se requiere registrar al menos el Id-Servicio y la prueba SMNET integral")
                    If (IdServicioT.TextLength = 0) Then
                        IdServicioT.Focus()
                    Else
                        PIntegralT.Focus()
                    End If
                    Exit Sub
                End If
            Else
                VPlantillaC()
                If (TCausa.Text = Nothing) Then
                    MsgBox("No has indicado el Proceso")
                    txtProceso.Focus()
                    Exit Sub
                Else
                    txtProceso.Text = "UCID: " & IdllamadaT.Text & " Proceso: " & TCausa.Text & " :: " & " >> Contacto: " & CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & " " & VContacto(MovilT.Text, FijoT.Text)
                    CopiarPlantilla()
                End If
            End If
        Else
            VPlantillaC()
            If (TCausa.Text = "") Then
                MsgBox("No has indicado el Proceso")
                txtProceso.Focus()
                Exit Sub
            Else
                Notas.TextBox1.Text = "UCID: " & IdllamadaT.Text & " :: " & TCausa.Text & " - " & CiudadT.Text & _
                  vbNewLine & vbNewLine & "Contacto: " & vbNewLine & CNombreTextBox.Text & vbNewLine & VID(CCvisible.Text, ComboBox1.Text) & vbNewLine & vbNewLine & VContacto(MovilT.Text, FijoT.Text)
                txtProceso.Text = "UCID: " & IdllamadaT.Text & " :: " & TCausa.Text & " - " & CiudadT.Text
                Notas.Show()
                Notas.TextBox1.Focus()
                Tinteracion.Text = "ASESORIA"
                TSElite()

            End If
        End If
    End Sub
    Private Sub Cplantilla()
        txtProceso.SelectionStart = 0
        txtProceso.SelectionLength = txtProceso.Text.Length
        txtProceso.Copy()
        TGUIONES.Text = "Tenemos lista la plantilla, solo preciona pegar donde la necesites" & vbNewLine & vbNewLine & TGUIONES.Text
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.NumPad1 Then
            If (FAbierto(Cronometro) = False) Then
                Me.KeyPreview = False
                TextBox2.Text = "1"
                ICronometro()
                Cronometro.Show()
                Cronometro.BringToFront()
                txtProceso.Focus()
            Else
                Me.KeyPreview = False
                TextBox2.Text = "1"
                ICronometro()
                txtProceso.Focus()
            End If
        ElseIf e.Control And e.KeyCode = Keys.NumPad2 Then
            If (FAbierto(Cronometro) = False) Then
                Me.KeyPreview = False
                TextBox2.Text = "2"
                ICronometro()
                Cronometro.Show()
                Cronometro.BringToFront()
            Else
                Me.KeyPreview = False
                TextBox2.Text = "2"
                ICronometro()
                txtProceso.Focus()
            End If
        ElseIf e.Control And e.KeyCode = Keys.NumPad3 Then
            If (FAbierto(Cronometro) = False) Then
                Me.KeyPreview = False
                TextBox2.Text = "3"
                ICronometro()
                Cronometro.Show()
                Cronometro.BringToFront()
            Else
                Me.KeyPreview = False
                TextBox2.Text = "3"
                ICronometro()
                txtProceso.Focus()
            End If
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
            TNotas()
            Notas.Show()
        ElseIf e.KeyData = Keys.Control + Keys.A Then
            Me.KeyPreview = False
            SoporteAvanzado.BringToFront()
            SoporteAvanzado.Show()
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

    Public Function FAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function
    Private Sub Gtrasferencia()
        TGUIONES.Text = "La Plantilla está copiada, solo preciona pegar (Ctrl + V) donde la necesites" & vbNewLine & vbNewLine & "Sr/sra " & CNombreTextBox.Text & " le comunicaré con mis Compañeros del área especializada, recuerde, En TigoUne estamos para usted, le deseamos " & Momento2(TimeOfDay.Hour)
    End Sub
    Private Sub Tavaya()

        Tinteracion.Text = "TRASFERENCIA"
        Dim vDIR As String = ""
        If (TxDireccion.Text <> Nothing) Then
            vDIR = " :: " & TxDireccion.Text
        End If

        VPlantillaC()

        If (TCausa.Text = "") Then
            MsgBox("No has indicado el motivo")
            TCausa.Focus()
            AreaTextBox.Text = "SIEBEL"
        Else
            If (CCTitularTextBox.Text <> Nothing) Then
                txtProceso.Text = CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & vDIR & " || " & TCausa.Text
            Else
                BtSPC.Enabled = True
                txtProceso.Text = CNombreTextBox.Text & " Movil: " & MovilT.Text & " || " & TCausa.Text
            End If
            Gtrasferencia()
        End If
        CopiarPlantilla()
    End Sub

    Private Sub FComunicacion()
        VPlantillaC()
        txtProceso.Text = "Id-LLamada: " & IdllamadaT.Text & " NOMBRE: " & CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & " || Durante el prceso de Soporte la LLamada se Cae / User finaliza la llamda"
        TGUIONES.Text = "Por falta de comunición con el Usuario, procedo a finalizar la llamada"
        If (TCausa.Text <> "") Then
            txtProceso.Text = txtProceso.Text & " **" & TCausa.Text
        End If
        CopiarPlantilla()
        Tinteracion.Text = "OTROS"
    End Sub

    Private Sub EReport()
        VPlantillaC()
        txtProceso.Text = "Id-LLamada: " & IdllamadaT.Text & " NOMBRE: " & CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & " || Se confirma estado del reporte"
        Gok()
        If (TCausa.Text <> "") Then
            txtProceso.Text = txtProceso.Text & " **" & TCausa.Text
        End If
        CopiarPlantilla()
        Tinteracion.Text = "OTROS"
    End Sub
    Private Sub SOK()
        VPlantillaC()
        txtProceso.Text = "Id-LLamada: " & IdllamadaT.Text & " || User llama para confirmar Servicios OK, se realizan Prueba Integral: " & PIntegralT.Text & " e Individual: " & PIndividualT.Text & " al identificador " & IdServicioT.Text & " CONFIRMA: " & CNombreTextBox.Text & VID(CCvisible.Text, ComboBox1.Text) & VContacto(MovilT.Text, FijoT.Text)
        Gok()
        If (TCausa.Text <> Nothing) Then
            txtProceso.Text = txtProceso.Text & " **El usuario tambien Manifiesta que: " & TCausa.Text
        End If
        CopiarPlantilla()
        Tinteracion.Text = "OTROS"
    End Sub

    Private Sub LlMuda()
        TGUIONES.Text = "Nota: Repetir el saludo por 20 segundos; finalizar:" & vbNewLine & "- Por falta de respuesta voy a colgar esta llamada"
        txtProceso.Text = "Id-LLamada: " & IdllamadaT.Text & " || Llamda muda, se esperan 20 seg, Saludado con Guion, User no responde"
        Tinteracion.Text = "OTROS"
        '*****************
        If (CCvisible.Text = "") Then
            CCvisible.Text = "00000000"
            CCTitularTextBox.Text = "00000000"
        ElseIf (CNombreTextBox.Text = "") Then
            CNombreTextBox.Text = "NA"
        ElseIf (TxDireccion.Text = "") Then
            TxDireccion.Text = "NA"
        End If
        CopiarPlantilla()
        BtSPC.Enabled = True
        CheckBox1.Checked = True
    End Sub

    Private Sub InformacionGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionGeneralToolStripMenuItem.Click
        IGENERAL.Show()
        IGENERAL.CausaTextBox.Focus()
    End Sub

    Public Sub TNotas()
        VPlantillaC()
        Dim Dir As String = CiudadT.Text
        If (TxDireccion.Text <> Nothing) Then
            Dir = TxDireccion.Text & " - " & CiudadT.Text
        End If
        VarGlob.CTNotas = "************* PLANTILLA ***********" & vbNewLine & "Id-Llamada: " & IdllamadaT.Text & vbNewLine & "Nombre: " & CNombreTextBox.Text & vbNewLine & VID(CCvisible.Text, ComboBox1.Text) & vbNewLine & VContacto(MovilT.Text, FijoT.Text) & vbNewLine & "Dirección: " & Dir & vbNewLine & VPSMNET(PIntegralT.Text, PIndividualT.Text) & vbNewLine
        If (TCausa.Text <> Nothing) Then
            If (AreaTextBox.Text = "ELITE") Then
                VarGlob.CTNotas = VarGlob.CTNotas & "** " & IdllamadaT.Text & " :: " & TCausa.Text & " - " & CiudadT.Text & vbNewLine
                TSElite()
            Else
                VarGlob.CTNotas = VarGlob.CTNotas & "** " & TCausa.Text
            End If

        End If
        Notas.Show()
        Notas.BringToFront()
        Notas.TextBox1.Text = VarGlob.CTNotas & vbNewLine & Notas.TextBox1.Text
    End Sub

    Private Sub TrasferirANotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrasferirANotasToolStripMenuItem.Click
        TNotas()
    End Sub

    Private Sub ZonaEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZonaEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://www.emtelco.com.co/ZonaE/")
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Esta Seguro de Cerrar la Aplicación", "Cerrar ANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.Exit()
            Cronometro.Close()
        End If
    End Sub

    Private Sub CSerial_GotFocus(sender As Object, e As EventArgs) Handles CSerial.GotFocus
        TGUIONES.Text = "Ingresa la mac o serie o parte de esta segun el caso, preciona enter y se generar la clave de acceso; es decir los ultimos 6 caracteres, sin puntos anteponiendo CPE#" & vbNewLine & vbNewLine & TGUIONES.Text
    End Sub

    Private Sub CSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles CSerial.KeyDown
        If e.KeyData = Keys.Enter Then
            Gpass()
        End If
    End Sub

    Private Sub Gpass()
        If (CSerial.TextLength >= 6) Then
            SSP = Replace(CSerial.Text, ":", "")
            SSP = Trim(SSP)
            If (SSP.Length >= 6) Then
                SSP = SSP.Substring(SSP.Length - 6, 6)
                If (ChTec.Checked = False) Then
                    CSerial.Text = "CPE#" & SSP
                Else
                    CSerial.Text = "ONT#" & SSP
                End If
                CSerial.SelectionStart = 0
                CSerial.SelectionLength = CSerial.Text.Length
                CSerial.Copy()
                TGUIONES.Text = "Tenemos listo el serial, solo preciona pegar donde lo necesites" & vbNewLine & vbNewLine & TGUIONES.Text
            Else
                MsgBox("Se necesitan al menos 6 caracteres del CMMAC")
                SSP = ""
            End If
            CSerial.Focus()
        Else
            MsgBox("Se necesitan al menos 6 caracteres del CMMAC")
            SSP = ""
            CSerial.Focus()
        End If
        SSP = ""

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            Tayuda.BackColor = White
            Tayuda.BorderStyle = BorderStyle.FixedSingle
            If (VarGlob.Notas <> "") Then
                Tayuda.Text = VarGlob.Notas
                Tayuda.Select(Tayuda.Text.Length, 0)
            Else
                Tayuda.Text = ""
            End If
            Tayuda.Focus()
        Else
            If (Tayuda.Text <> Nothing) Then
                VarGlob.Notas = Tayuda.Text
            End If
            Tayuda.Text = "AYUDA ANA" & vbNewLine & "Cliente Critico = Ctrl + A" & vbNewLine & "Traferencia avaya = Ctrl + K" & vbNewLine & "Llamada Muda = Ctrl + P" & vbNewLine & "Plantilla = Ctrl + S" & vbNewLine & "LIMPIAR = Escape" & vbNewLine & vbNewLine & "Ctrl + 1: Cronometro 1 m" & vbNewLine & "Ctrl + 2: Cronometro 2 m" & vbNewLine & "Ctrl + 3: Cronometro 3 m" & vbNewLine & vbNewLine & "Ctrl + L: Trasferir Plantilla a  Notas" & vbNewLine & vbNewLine & "Alt + 1: WTS Elite" & vbNewLine & "Alt + 2: WTS 140" & vbNewLine & "Alt + 3: WTS 150" & vbNewLine & "Alt + 4: WTS 167"
            Tayuda.BackColor = Me.BackColor
            Tayuda.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub AreaTextBox_TextChanged(sender As Object, e As EventArgs) Handles AreaTextBox.TextChanged
        If (AreaTextBox.Text = "SIEBEL" Or AreaTextBox.Text = "ELITE") Then
            Tinteracion.Text = "OTROS"
            txtProceso.Text = "Aquí se generará la Plantilla"
            TSSiebel()
        Else
            Tinteracion.Text = "TRASFERENCIA"
        End If
    End Sub


    Private Sub IdllamadaT_TextChanged(sender As Object, e As EventArgs) Handles IdllamadaT.TextChanged

    End Sub


End Class