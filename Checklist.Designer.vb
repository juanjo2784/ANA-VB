<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checklist
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
        Dim DiagnosticoLabel As System.Windows.Forms.Label
        Dim ServicoLabel As System.Windows.Forms.Label
        Dim TecnologiaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checklist))
        Me.GDiagnostico = New System.Windows.Forms.GroupBox()
        Me.CDiagnostico = New System.Windows.Forms.ComboBox()
        Me.CTecnologia = New System.Windows.Forms.ComboBox()
        Me.CServicio = New System.Windows.Forms.ComboBox()
        Me.Vfisicas = New System.Windows.Forms.GroupBox()
        Me.BtVfisicas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        DiagnosticoLabel = New System.Windows.Forms.Label()
        ServicoLabel = New System.Windows.Forms.Label()
        TecnologiaLabel = New System.Windows.Forms.Label()
        Me.GDiagnostico.SuspendLayout()
        Me.SuspendLayout()
        '
        'DiagnosticoLabel
        '
        DiagnosticoLabel.AutoSize = True
        DiagnosticoLabel.Location = New System.Drawing.Point(195, 19)
        DiagnosticoLabel.Name = "DiagnosticoLabel"
        DiagnosticoLabel.Size = New System.Drawing.Size(66, 13)
        DiagnosticoLabel.TabIndex = 106
        DiagnosticoLabel.Text = "Diagnostico:"
        '
        'ServicoLabel
        '
        ServicoLabel.AutoSize = True
        ServicoLabel.Location = New System.Drawing.Point(6, 19)
        ServicoLabel.Name = "ServicoLabel"
        ServicoLabel.Size = New System.Drawing.Size(46, 13)
        ServicoLabel.TabIndex = 32
        ServicoLabel.Text = "Servico:"
        '
        'TecnologiaLabel
        '
        TecnologiaLabel.AutoSize = True
        TecnologiaLabel.Location = New System.Drawing.Point(132, 19)
        TecnologiaLabel.Name = "TecnologiaLabel"
        TecnologiaLabel.Size = New System.Drawing.Size(63, 13)
        TecnologiaLabel.TabIndex = 34
        TecnologiaLabel.Text = "Tecnologia:"
        '
        'GDiagnostico
        '
        Me.GDiagnostico.Controls.Add(Me.CDiagnostico)
        Me.GDiagnostico.Controls.Add(DiagnosticoLabel)
        Me.GDiagnostico.Controls.Add(Me.CTecnologia)
        Me.GDiagnostico.Controls.Add(Me.CServicio)
        Me.GDiagnostico.Controls.Add(ServicoLabel)
        Me.GDiagnostico.Controls.Add(TecnologiaLabel)
        Me.GDiagnostico.Location = New System.Drawing.Point(6, 0)
        Me.GDiagnostico.Name = "GDiagnostico"
        Me.GDiagnostico.Size = New System.Drawing.Size(367, 71)
        Me.GDiagnostico.TabIndex = 3
        Me.GDiagnostico.TabStop = False
        Me.GDiagnostico.Text = "IDentifiacion Falla"
        '
        'CDiagnostico
        '
        Me.CDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDiagnostico.FormattingEnabled = True
        Me.CDiagnostico.Location = New System.Drawing.Point(198, 37)
        Me.CDiagnostico.Name = "CDiagnostico"
        Me.CDiagnostico.Size = New System.Drawing.Size(163, 21)
        Me.CDiagnostico.TabIndex = 1
        Me.CDiagnostico.TabStop = False
        Me.CDiagnostico.Text = "-----Seleccione -----"
        '
        'CTecnologia
        '
        Me.CTecnologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTecnologia.FormattingEnabled = True
        Me.CTecnologia.Items.AddRange(New Object() {"HFC", "ADSL", "GPON", "OTRO"})
        Me.CTecnologia.Location = New System.Drawing.Point(137, 37)
        Me.CTecnologia.Name = "CTecnologia"
        Me.CTecnologia.Size = New System.Drawing.Size(63, 21)
        Me.CTecnologia.TabIndex = 2
        Me.CTecnologia.TabStop = False
        Me.CTecnologia.Text = "HFC"
        '
        'CServicio
        '
        Me.CServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CServicio.FormattingEnabled = True
        Me.CServicio.Location = New System.Drawing.Point(6, 37)
        Me.CServicio.Name = "CServicio"
        Me.CServicio.Size = New System.Drawing.Size(132, 21)
        Me.CServicio.TabIndex = 0
        Me.CServicio.TabStop = False
        Me.CServicio.Text = "INTERNET"
        '
        'Vfisicas
        '
        Me.Vfisicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vfisicas.Location = New System.Drawing.Point(6, 68)
        Me.Vfisicas.Name = "Vfisicas"
        Me.Vfisicas.Size = New System.Drawing.Size(366, 205)
        Me.Vfisicas.TabIndex = 131
        Me.Vfisicas.TabStop = False
        '
        'BtVfisicas
        '
        Me.BtVfisicas.Location = New System.Drawing.Point(175, 294)
        Me.BtVfisicas.Name = "BtVfisicas"
        Me.BtVfisicas.Size = New System.Drawing.Size(198, 26)
        Me.BtVfisicas.TabIndex = 147
        Me.BtVfisicas.Text = "Finalizar Validaciones"
        Me.BtVfisicas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 26)
        Me.Button1.TabIndex = 148
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(331, 277)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(36, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "SI"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "¿EL CASO SE RESOLVIÓ?"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(62, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 25)
        Me.Button2.TabIndex = 150
        Me.Button2.Text = "Cliente Critico"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Checklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtVfisicas)
        Me.Controls.Add(Me.Vfisicas)
        Me.Controls.Add(Me.GDiagnostico)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(292, 10)
        Me.Name = "Checklist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Checklist - Prototipo Desarrollado por JUAN CHARRY"
        Me.TopMost = True
        Me.GDiagnostico.ResumeLayout(False)
        Me.GDiagnostico.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GDiagnostico As System.Windows.Forms.GroupBox
    Friend WithEvents CDiagnostico As System.Windows.Forms.ComboBox
    Friend WithEvents CTecnologia As System.Windows.Forms.ComboBox
    Friend WithEvents CServicio As System.Windows.Forms.ComboBox
    Friend WithEvents Vfisicas As System.Windows.Forms.GroupBox
    Friend WithEvents BtVfisicas As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
