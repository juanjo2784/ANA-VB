Module VarGlob
    Public NAgente As String
    Public TEspecial As String
    Public Notas As String
    Public OIDO As String = "DERECHO"
    Public TDIADEMA As Integer = "30"
    Public Contador As Integer = 0
    Public correo As String = "cliente@sincorreo.com"
    Public Guardado As Boolean = False
    Public Vobo As Boolean = False
    Public TxPlus As String = ""
    Public Plantilla As String = ""
    Public Contacto As String
    Public VTotalCall As Integer = 10
    Public VPromedio As Integer = 0
    Public SSP As String = ""
    Public Rserial As String = ""
    Public CProceso As String = ""
    Public PWTS As String = ""
    Public PRED As String = ""
    Public PSIEBEL As String = ""
    Public PCC As String = ""
    Public CTNotas As String = ""
    Public SDiagnostico As String = "NA"
    Public Promociones As String = "NO"
    Public SAvanzado As String = "NA"
    Public Diagnostico As String = "NA"
    Public codarea As Integer = 4
    Public CodDig As Integer = 10
    Public CDig As Integer = 10
    Public Checklist As String = ""
    Public A As Integer = 0
    Public ObGraficas As String = ""
    Public Partir As String = ""


    Public DEsencial As String = "ESENCIAL: 89 SD  + 17 HD + 50 Audio >> Total 156 Canales Incluye 2 Decos HD +  TO 50"
    Public DEsenciaPlus As String = "ESENCIAL PLUS: 125 SD + 24 HD + 50 Audio  >> Total 199 Canales Incluye 2 Decos DTA +  TO 50"
    Public DIDeal As String = "IDEAL: 126 SD + 49 HD  + 50 Audio  >> Total 225 Canales Incluye 2 Decos HD +  TO 50"
    Public DIDealPlus As String = "IDEAL PLUS 126 SD + 65 HD  + 50 Audio  >> Total 241 Canales Incluye 2 Decos HD +  TO 50"
    Public DOne As String = "1. Busqueda, Sugerencias de programas" & vbNewLine & "2. Aplicaciones: YouTube::Fox y Crackle->servicio" & _
         vbNewLine & "3. App Movil:  TigoOne TV para IOS y AndroID " & vbNewLine & "*** 1 Zapper + 1 DTA +  TO 50" & _
         vbNewLine & "Canales 125 SD + 35 HD + 50 Audio >> Total 210 Canales"
    Public DOnePlus As String = "Caracteristicas:" & vbNewLine & "1. Busqueda, Sugerencias de programas" & vbNewLine & "2. Aplicaciones: YouTube::Fox y Crackle->servicio" & _
         vbNewLine & "3. App Movil:  TigoOne TV para IOS y AndroID " & vbNewLine & "*** 1 Zapper + 1 DTA +  TO 50" & _
         vbNewLine & "Canales 125 SD + 65 HD + 50 Audio >> Total 240 Canales"
    Public DElite As String = "Caracteristicas:" & vbNewLine & "1. Busqueda, Sugerencias de programas" & vbNewLine & "2. Aplicaciones: YouTube::Fox y Crackle->servicio" & _
         vbNewLine & "3. App Movil:  TigoOne TV para IOS y AndroID " & vbNewLine & "4. Tienda VOD >> Graba, Pausa, Adelanta y Retrocede" & vbNewLine & "*** 1 GateWay + 1 Mini +  TO 50" & _
         vbNewLine & "Para 20@:  125 SD + 65 HD + 50 Audio >> Total 240 Canales" & _
         vbNewLine & "Para 50@:  135 SD + 72 HD + 50 Audio >> Total 257 Canales :: incluye HBO Max"
    Public D1Esencial As String = "ESENCIAL: 89 SD  + 17 HD + 50 Audio >> Total 156 Canales Incluye 1 DTA"
    Public D1EsenciaPlus As String = "ESENCIAL PLUS: 125 SD + 24 HD + 50 Audio  >> Total 199 Canales Incluye 2 Decos DTA"
    Public D1IDeal As String = "IDEAL: 126 SD + 49 HD  + 50 Audio  >> Total 225 Canales Incluye 2 Decos HD"
    Public D1IDealPlus As String = "IDEAL PLUS: 126 SD + 65 HD  + 50 Audio  >> Total 241 Canales Incluye 2 Decos HD"
    Public D1Elite20 As String = "ONE ELITE + 20 M 125 SD + 64 HD + 50 Audio >> Total 239 Canales; 1 GateWay + 1 Mini"
    Public D1Elite50 As String = "ONE ELITE + 50 M 135 SD + 71 HD + 50 Audio >> Total 239 Canales :: incluye HBO Max"
    Public SnInformacion As String = "N/A"
    Public One As String = " 125 SD + 35 HD + 50 Audio >> Total 210 Canales; 1 Lite Zaper + 1 DTA"
    Public OnePlus As String = " 125 SD + 64 HD + 50 Audio >> Total 239 Canales; 1 Lite Zaper + 1 DTA"
    Public DTV1 As String = "ESENCIAL: Canales 88 SD  + 17 HD + 50 Audio >> Total 155 Canales Incluye 1 Decos HD +  TO 50"

    'PROMOCIONES PUNTUALES
    Public Esencial2 As String = " + HBO MAX y Fox Premium 25% x 12 Meses"
    Public EsencialPlus2 As String = " + HBO MAX y Fox Premium 25% x 12 Meses"
    Public IDeal2 As String = " HBO MAX y Fox Premium 25% x 12 Meses"
    Public IDealPlus2 As String = " HBO MAX y Fox Premium 25% x 12 Meses"
    Public One2 As String = "+ TIGOUNE CAST + 1 mes de FOX PREMIUM, HBO MAX Y  CRACKLE"
    Public OnePlus2 As String = "+ Cámara  + 1 mes de FOX PREMIUM, HBO MAX Y  CRACKLE"
    Public Elite2 As String = "+ Cámara  + 1 mes de FOX PREMIUM, HBO MAX Y  CRACKLE"

    Public P1 As String = " + Smart Promo "
    Public P2 As String = " + Smart Promo + 2 meses x 50% Off "
    Public PUps As String = vbNewLine & "PARA CLIENTES TIGO-UNE" & vbNewLine & vbNewLine & "* 50% Hot Pack 2 Meses " & vbNewLine & vbNewLine & _
     "* 2da Banda Ancha 5@::1-3 $21900; 4-6: $26.061" & vbNewLine & vbNewLine & _
     "* 5@ por $5.000 para estratos 1-3 y para 4-6 $ 5.950 " & vbNewLine & vbNewLine & _
     "* 10@ por $10.000 para estratos 1-3 y 11.900 para 4-6 " & vbNewLine & vbNewLine & _
     "* 5@ por $5.000 para estratos 1-3" & vbNewLine & vbNewLine & _
     "* 50% off  x 2 meses por cada Servicio Nuevo, que completen DUO o TRIO  " & vbNewLine & vbNewLine & _
     "* 1 Mes Gratis de TV para clientes que completen DUO o TRIO o Migren a TV-Digital"


    'COSTOS PUNTUALES
    Public Esencial1 As String = "Internet 5@" & vbNewLine & "1-2: 104.039; 3-4: 109.515 (Deco FIDeliza +1000  E3-4)"
    Public EsencialPlus1 As String = "Internet 10@ (Gota 5@) " & vbNewLine & "1-4: 130.375" & vbNewLine & "5-6: 151.235" & _
      vbNewLine & "Internet 20@" & vbNewLine & "1-4: 151.235" & vbNewLine & "5-6: 172.095"
    Public IDeal1 As String = "SIN INFORMACION"
    Public IDealPlus1 As String = "SIN INFORMACION"
    Public One1 As String = "Internet 10@" & vbNewLine & "3-4: 151.232 " & vbNewLine & "5-6: 172.095" & vbNewLine & _
    "Internet 20@" & vbNewLine & "3-4: 172.095" & vbNewLine & "5-6: 192.955" & vbNewLine & _
   "Internet 50@" & vbNewLine & "3-4: 260.750" & vbNewLine & "5-6: 281.610"
    Public OnePlus1 As String = "Internet 10@" & vbNewLine & "3-4: 192.955" & vbNewLine & "5-6: 213.815" & vbNewLine & _
    "Internet 20@" & vbNewLine & "3-4:203.385" & vbNewLine & "5-6: 224.245" & vbNewLine & "Internet 50@" & vbNewLine & "3-4: 302.470 " & vbNewLine & "5-6: 323.330"
    Public Elite1 As String = "Internet 20@" & vbNewLine & "3-4: 239.890" & vbNewLine & "5-6: 260.750" & vbNewLine & _
   "Internet 50@" & vbNewLine & "3-4: 339.975" & vbNewLine & "5-6: 359.835"

    Public DBT5 As String = "1-4: 72.697(18%)" & vbNewLine & "5-6: 109.515"
    Public DBT10 As String = "1-4: 99.085" & vbNewLine & "5-6: 119.945"
    Public DBT20 As String = "3-4: 109.515" & vbNewLine & "5-6: 130.375"
    Public DBT50 As String = "3-4: 208.600" & vbNewLine & "5-6: 229.460"
    Public DTVEsencial As String = "1-4: 78.225(18%)"
    Public DTVEsencialPlus As String = "1-4: 99.085"
    Public DTVIDeal As String = "3-4: 140.805" & vbNewLine & "5-6: 161.665"

End Module
