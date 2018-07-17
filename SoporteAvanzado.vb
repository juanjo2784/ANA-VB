Public Class SoporteAvanzado

    Private Sub SoporteAvanzado_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If (Form1.Tinteracion.Text = "TERRENO") Then
            Form1.Tinteracion.Text = "OTROS"
        End If
    End Sub

    Private Sub SoporteAvanzado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbTags.Items.Add("@SU@")
        CbTags.Items.Add("@SD@")
        CbTags.Items.Add("@UT@")
        CbTags.Items.Add("GGR")
        CbTags.Items.Add("@PNC@")
        CbTags.Items.Add("PNC")
        CbTags.Items.Add("@PC@")
        CbTags.Items.Add("PC")
        CbTags.Items.Add("@IW@")
        CbTags.Items.Add("@ED@")
        CbTags.Items.Add("OK")
        CbTags.Text = "OK"
        VarGlob.CodDig = 10
        VarGlob.CDig = 10
        CbTags.Text = "OK"
        CBPDW.Text = "8"
        CBPUP.Text = "4"

        If (VarGlob.ObGraficas <> "") Then
            TObGraficas.Text = VarGlob.ObGraficas
        End If

    End Sub
    Private Sub CbTags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTags.SelectedIndexChanged
        Select Case CbTags.Text
            Case "@SU@"
                VarGlob.Diagnostico = " Saturación UPStream Escalar a Ingenieria de Acceso"
            Case "@SD@"
                VarGlob.Diagnostico = " Saturación DownStream Escalar a Ingenieria de Acceso"
            Case "@UT@"
                VarGlob.Diagnostico = " Escalara a Ingenieria de Acceso"
            Case "GGR"
                VarGlob.Diagnostico = " Escalara a Soporte Especializado"
            Case "@PNC@", "PNC"
                VarGlob.Diagnostico = " Escalara a Soporte Especializado"
            Case "@PC@", "PC"
                VarGlob.Diagnostico = " Escalara a Soporte Especializado"
            Case "@IW@"
                VarGlob.Diagnostico = " Interferencia Escalara a Premisas"
            Case "@ED@"
                VarGlob.Diagnostico = " Deficiencias, Escalara a Premisas"
            Case Else
                VarGlob.SAvanzado = VarGlob.SAvanzado & " TAGS: OK "
        End Select

        If (CbTags.Text <> "OK") Then
            VarGlob.SAvanzado = " Diagnostico: PARAMERTROS ALARMADOS - HFC:: Se realiza Análisis detallado en SMNET encontrato TAG: " & CbTags.Text & " :: " & VarGlob.Diagnostico & " - Diagnostico de SMNET"
            Form1.Tinteracion.Text = "TERRENO"
            Me.Close()
        End If

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If (RadioButton1.Checked = True) Then
            CBPDW.Items.Clear()
            CBPDW.Items.Add("1")
            CBPDW.Items.Add("2")
            CBPDW.Items.Add("3")
            CBPDW.Items.Add("4")
            CBPUP.Items.Clear()
            CBPUP.Items.Add("1")
            CBPUP.Items.Add("2")
            CBPDW.Text = 4
            CBPUP.Text = 2
        Else
            CBPDW.Items.Clear()
            CBPDW.Items.Add("1")
            CBPDW.Items.Add("2")
            CBPDW.Items.Add("3")
            CBPDW.Items.Add("4")
            CBPDW.Items.Add("5")
            CBPDW.Items.Add("6")
            CBPDW.Items.Add("7")
            CBPDW.Items.Add("8")
            CBPUP.Items.Clear()
            CBPUP.Items.Add("1")
            CBPUP.Items.Add("2")
            CBPUP.Items.Add("3")
            CBPUP.Items.Add("4")
            CBPDW.Text = 8
            CBPUP.Text = 4
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VarGlob.SAvanzado = " >> Se realiza Soporte Cliente Critico, encontrando: "
        Dim Docsis, PDw, PUp As Integer
        PDw = CBPDW.Text
        PUp = CBPUP.Text
        If (RadioButton1.Checked = True) Then
            Docsis = "2"
            VarGlob.SAvanzado = VarGlob.SAvanzado & " Docsis:2  Cant. Portadoras: Dw: " & PDw & ": UP: " & PUp
        Else
            Docsis = "3"
            VarGlob.SAvanzado = VarGlob.SAvanzado & " Docsis: 3 Cant .Portadoras: Dw: " & PDw & ": UP: " & PUp
        End If
        Select Case Docsis
            Case Is = "2"
                If (PDw >= 2 And PUp >= 1) Then
                    VarGlob.SAvanzado = VarGlob.SAvanzado & " :: OK"
                Else
                    If (PDw = 2) Then
                        VarGlob.SAvanzado = VarGlob.SAvanzado & ", Portadoras Dw al limite"
                    ElseIf (PDw < 2) Then
                        VarGlob.SAvanzado = VarGlob.SAvanzado & ", Portadoras en Dw: Deficientes"
                    End If
                    If (PUp <= 1) Then
                        VarGlob.SAvanzado = VarGlob.SAvanzado & ", Portadoras en UP: Deficientes"
                    End If
                    VarGlob.Diagnostico = VarGlob.Diagnostico & ", Diagnostico: Falla Modem"
                    Diagnosticar(3)
                End If
            Case Else
                If (PDw > 4 And PUp > 2) Then
                    VarGlob.SAvanzado = VarGlob.SAvanzado & " :: OK"
                Else
                    If (PDw = 4) Then
                        VarGlob.SAvanzado = VarGlob.SAvanzado & " Portadoras Dw al limite"
                    ElseIf (PDw < 4) Then
                        VarGlob.SAvanzado = VarGlob.SAvanzado & " Portadoras en Dw: Deficientes"
                    End If
                    If (PUp <= 2) Then
                        VarGlob.SAvanzado = VarGlob.SAvanzado & " Portadoras en UP: Deficientes"
                    End If
                    Diagnosticar(3)
                End If
        End Select
        If (PDw = 2 And PUp = 1) Then
            VarGlob.SAvanzado = VarGlob.SAvanzado & " :: Modo parcial"
        End If
        If (PDw = 1 And PUp = 1) Then
            VarGlob.SAvanzado = VarGlob.SAvanzado & " :: Modo Legancy"
        End If

        Graficas(CheckBox1.Checked, CheckBox2.Checked, CheckBox5.Checked, CheckBox6.Checked)

        Vparametros()

            Select Case VarGlob.CodDig
                Case Is = 0
                    VarGlob.Diagnostico = " Validar: Vista Conjunta; falla externa e Interna"
                Case Is = 1
                    VarGlob.Diagnostico = " Validar: Infraestructura"
                Case Is = 2
                    VarGlob.Diagnostico = " Validar: Soporte Especializado"
                Case Is = 3
                    VarGlob.Diagnostico = " Validar: Premisas  - Falla en Modem"
                Case Is = 4
                    VarGlob.Diagnostico = " Validar: Premisas"
                Case Else
                    VarGlob.Diagnostico = " Diagnostico SMNET: Sin Falla"
            End Select

            If (VarGlob.CodDig <> 10) Then
                If (Form1.TCausa.Text = "") Then
                    Form1.TCausa.Text = " Falla en Servicios; Tecnologia HFC"
                End If
            End If

            If (VarGlob.Diagnostico <> Nothing) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & " :: " & VarGlob.Diagnostico
            End If
            Form1.Tinteracion.Text = "TERRENO"
            Me.Close()
    End Sub
    Function Graficas(ByVal A As Boolean, B As Boolean, C As Boolean, D As Boolean) As String
        A = CheckBox1.Checked
        B = CheckBox2.Checked
        C = CheckBox5.Checked
        D = CheckBox6.Checked

        If (A = False And B = False And C = False And D = False) Then
            VarGlob.SAvanzado = VarGlob.SAvanzado & " || Analisis de Gráficas: OK"
        Else
            VarGlob.SAvanzado = VarGlob.SAvanzado & " || Analisis de Gráficas: Se observa patrones alarmados en: "
            If (D = True) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & " POWER UpStrean,"
                Diagnosticar(1)
            End If
            If (B = True) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & " POWER DownStream,"
                Diagnosticar(1)
            End If
            If (C = True) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & " SNR UpStream,"
                Diagnosticar(4)
            End If
            If (A = True) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & " SNR DownStream,"
                Diagnosticar(4)
            End If
        End If

        If (TObGraficas.Text <> "") Then
            VarGlob.ObGraficas = TObGraficas.Text
            VarGlob.SAvanzado = VarGlob.SAvanzado & " Además se observa: " & VarGlob.ObGraficas
        End If

        Return VarGlob.SAvanzado
    End Function
    Function Diagnosticar(ByRef D As Integer) As Integer
        If (D = 1) Then
            Select Case VarGlob.CodDig
                Case Is = 10
                    VarGlob.CodDig = 1
                Case Else
                    VarGlob.CodDig = 0
            End Select
        Else
            If (VarGlob.CodDig <= D) Then
                VarGlob.CodDig = VarGlob.CodDig
            Else
                VarGlob.CodDig = D
            End If
        End If
        Return VarGlob.CodDig
    End Function

    Private Sub VParametros()
        'VERIFICACION DE PARAMETROS
        If (CheckBox13.Checked = True And CheckBox12.Checked = True And CheckBox9.Checked = True And CheckBox4.Checked = True And CheckBox7.Checked = True And CheckBox8.Checked = True And CheckBox10.Checked = True And CheckBox11.Checked = True And CheckBox14.Checked = True And CheckBox15.Checked = True And CheckBox16.Checked = True) Then
            VarGlob.SAvanzado = VarGlob.SAvanzado & " || Parametros: OK"
        Else
            Diagnosticar(4)
            VarGlob.SAvanzado = VarGlob.SAvanzado & " || Parametros: Alarmados ("
            If (CheckBox13.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & " SNR DW"
            End If
            If (CheckBox12.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ",PNC DW"
            End If
            If (CheckBox9.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ", PC DW"
            End If
            If (CheckBox4.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ", SNR UP"
            End If
            If (CheckBox7.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ", PNC UP"
            End If
            If (CheckBox8.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ", PC UP"
            End If
            If (CheckBox10.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ", INS"
            End If
            If (CheckBox13.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ", MISS"
            End If
            If (CheckBox14.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & ", PERDIDA/CORRECIÓN DE PAQUETES"
            End If
            VarGlob.SAvanzado = VarGlob.SAvanzado & ")"

            If (CheckBox15.Checked = False) Then
                VarGlob.SAvanzado = VarGlob.SAvanzado & " Potencia DW: ALARMADO"
                Diagnosticar(2)
                If (CheckBox16.Checked = False) Then
                    VarGlob.SAvanzado = VarGlob.SAvanzado & ", Potencia UP: ALARMADO"
                    Diagnosticar(2)
                End If
            End If

        End If
    End Sub

End Class