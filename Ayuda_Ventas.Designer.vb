<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ayuda_Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected OverrIDes Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'RequerIDo por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ayuda_Ventas))
        Me.GLinks = New System.Windows.Forms.GroupBox()
        Me.TAV = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CTPlan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tplan = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Planes = New System.Windows.Forms.DataGridView()
        Me.Caracteristicas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxPromociones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MVentas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PromocionesVigentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistanciasADSLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TigoUNETrainersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrillaDeCanalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GLinks.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Planes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MVentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GLinks
        '
        Me.GLinks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GLinks.Controls.Add(Me.TAV)
        Me.GLinks.Controls.Add(Me.ComboBox4)
        Me.GLinks.Controls.Add(Me.ComboBox3)
        Me.GLinks.Controls.Add(Me.ComboBox2)
        Me.GLinks.Controls.Add(Me.ComboBox1)
        Me.GLinks.Controls.Add(Me.Label6)
        Me.GLinks.Controls.Add(Me.Label2)
        Me.GLinks.Controls.Add(Me.Label1)
        Me.GLinks.Controls.Add(Me.Label5)
        Me.GLinks.Location = New System.Drawing.Point(722, 2)
        Me.GLinks.Name = "GLinks"
        Me.GLinks.Size = New System.Drawing.Size(243, 414)
        Me.GLinks.TabIndex = 1
        Me.GLinks.TabStop = False
        '
        'TAV
        '
        Me.TAV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAV.ForeColor = System.Drawing.Color.ForestGreen
        Me.TAV.Location = New System.Drawing.Point(9, 219)
        Me.TAV.Multiline = True
        Me.TAV.Name = "TAV"
        Me.TAV.Size = New System.Drawing.Size(229, 189)
        Me.TAV.TabIndex = 13
        Me.TAV.Text = "Con TigoUne su vida será mas feliz!! Quiere saber como? permitame le cuento..."
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"No le puedo garantizar que esa promoción esté disponible mañana", "¿Por que no se merece llegar a su casa y disfrutar de la mejor TV /  Internet  / " & _
                "Telefonia?", "¿Por que no disfrutar de sus series favoritas, ver peliculas en casa y descargar " & _
                "el contenido que desee?"})
        Me.ComboBox4.Location = New System.Drawing.Point(10, 187)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(228, 26)
        Me.ComboBox4.TabIndex = 12
        Me.ComboBox4.Text = "-"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Cual es el principal motivo por el cual no adquiere los servicios con nuestra com" & _
                "pañia? saber esto nos ayudara a mejorar día a día nuestro servicio.", "¿El único motivo por el que usted no adquiere nuestros beneficios es por xxx? eso" & _
                " quiere decir que si le demuestro que este tiene un valor justo adquirimos el se" & _
                "rvicio?", "Le queremos demostrar por que somos la mejor opción"})
        Me.ComboBox3.Location = New System.Drawing.Point(10, 138)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(228, 26)
        Me.ComboBox3.TabIndex = 11
        Me.ComboBox3.Text = "-"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Costo", "Mal Servicio", "Incumplimiento de los Técnicos", "No me bajan la Factura"})
        Me.ComboBox2.Location = New System.Drawing.Point(10, 89)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(228, 26)
        Me.ComboBox2.TabIndex = 10
        Me.ComboBox2.Text = "-"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Con TigoUne su vida será mas feliz!! Quiere saber como? permitame le cuento...", "¿Ya conoce como puede mejorar sus servicios con el plan que TigoUne tiene para su" & _
                " hogar?", "¿Que le parece llamar desde su teléfono fijo a celulares gratis todos los meses? " & _
                "Hasta 50 minutos", "Sabe que con nuestros planes puedes descargar ilimitadamente todo los contenidos " & _
                "de internet en su hogar ", "Sabias que con TigoUNE no te pierdes tus partidos favoritos porque los puedes ver" & _
                " desde cualquier lugar usando nuestra aplicacion UneTV?", "¿Cuál es el servicio que más consume en su hogar? Y por que?", " ¿Qué tipo de programas disfruta viendo en televisión?", "¿Normalmente que uso le da a internet en su casa?", "¿En cuántos televisores disfrutará de la mejor señal en HD o Digital (SD)?", "¿Cuántos dispositivos inalámbricos conectará al WiFi?", "Le queremos demostrar por que somos la mejor opción", "¿Le Interesaria Conocer el Mejor Internet de Colombia? - One Elite, Permitame le " & _
                "explico"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 26)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "Con TigoUne su vida será mas feliz!! Quiere saber como? permitame le cuento..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(7, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Manejo de Objeción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(7, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cierre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Objeción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(6, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Preguntas Poderosas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CTPlan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Tplan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 66)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'CTPlan
        '
        Me.CTPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTPlan.FormattingEnabled = True
        Me.CTPlan.Items.AddRange(New Object() {"Nuevo", "Existente"})
        Me.CTPlan.Location = New System.Drawing.Point(6, 34)
        Me.CTPlan.Name = "CTPlan"
        Me.CTPlan.Size = New System.Drawing.Size(151, 26)
        Me.CTPlan.TabIndex = 6
        Me.CTPlan.Text = "Existente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Plan"
        '
        'Tplan
        '
        Me.Tplan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tplan.FormattingEnabled = True
        Me.Tplan.Location = New System.Drawing.Point(159, 34)
        Me.Tplan.Name = "Tplan"
        Me.Tplan.Size = New System.Drawing.Size(271, 26)
        Me.Tplan.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(722, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Planes
        '
        Me.Planes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Planes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Planes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Caracteristicas, Me.Costo})
        Me.Planes.Location = New System.Drawing.Point(12, 77)
        Me.Planes.Name = "Planes"
        Me.Planes.RowHeadersVisible = False
        Me.Planes.Size = New System.Drawing.Size(444, 372)
        Me.Planes.TabIndex = 5
        '
        'Caracteristicas
        '
        Me.Caracteristicas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Caracteristicas.HeaderText = "Caracteristicas"
        Me.Caracteristicas.Name = "Caracteristicas"
        Me.Caracteristicas.Width = 300
        '
        'Costo
        '
        Me.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.Width = 140
        '
        'TxPromociones
        '
        Me.TxPromociones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxPromociones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPromociones.Location = New System.Drawing.Point(462, 29)
        Me.TxPromociones.Multiline = True
        Me.TxPromociones.Name = "TxPromociones"
        Me.TxPromociones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxPromociones.Size = New System.Drawing.Size(254, 420)
        Me.TxPromociones.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(462, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PROMOCIONES VIGENTES"
        '
        'MVentas
        '
        Me.MVentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PromocionesVigentesToolStripMenuItem, Me.DistanciasADSLToolStripMenuItem, Me.GuionesToolStripMenuItem, Me.TigoUNETrainersToolStripMenuItem, Me.GrillaDeCanalesToolStripMenuItem})
        Me.MVentas.Name = "MVentas"
        Me.MVentas.Size = New System.Drawing.Size(193, 114)
        '
        'PromocionesVigentesToolStripMenuItem
        '
        Me.PromocionesVigentesToolStripMenuItem.Name = "PromocionesVigentesToolStripMenuItem"
        Me.PromocionesVigentesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PromocionesVigentesToolStripMenuItem.Text = "Promociones Vigentes"
        '
        'DistanciasADSLToolStripMenuItem
        '
        Me.DistanciasADSLToolStripMenuItem.Name = "DistanciasADSLToolStripMenuItem"
        Me.DistanciasADSLToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DistanciasADSLToolStripMenuItem.Text = "Distancias ADSL"
        '
        'GuionesToolStripMenuItem
        '
        Me.GuionesToolStripMenuItem.Name = "GuionesToolStripMenuItem"
        Me.GuionesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GuionesToolStripMenuItem.Text = "Guiones"
        '
        'TigoUNETrainersToolStripMenuItem
        '
        Me.TigoUNETrainersToolStripMenuItem.Name = "TigoUNETrainersToolStripMenuItem"
        Me.TigoUNETrainersToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.TigoUNETrainersToolStripMenuItem.Text = "Tigo UNE Trainers"
        '
        'GrillaDeCanalesToolStripMenuItem
        '
        Me.GrillaDeCanalesToolStripMenuItem.Name = "GrillaDeCanalesToolStripMenuItem"
        Me.GrillaDeCanalesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GrillaDeCanalesToolStripMenuItem.Text = "Grilla de Canales"
        '
        'Ayuda_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(977, 465)
        Me.ContextMenuStrip = Me.MVentas
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxPromociones)
        Me.Controls.Add(Me.Planes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GLinks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ayuda_Ventas"
        Me.Text = "Ayuda_Ventas"
        Me.GLinks.ResumeLayout(False)
        Me.GLinks.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Planes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MVentas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GLinks As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tplan As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Planes As System.Windows.Forms.DataGrIDView
    Friend WithEvents TxPromociones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Caracteristicas As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents CTPlan As System.Windows.Forms.ComboBox
    Friend WithEvents MVentas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PromocionesVigentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DistanciasADSLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TigoUNETrainersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrillaDeCanalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TAV As System.Windows.Forms.TextBox
End Class
