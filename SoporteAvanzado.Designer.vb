<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoporteAvanzado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoporteAvanzado))
        Me.CbTags = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CBPUP = New System.Windows.Forms.ComboBox()
        Me.CBPDW = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TObGraficas = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbTags
        '
        Me.CbTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTags.FormattingEnabled = True
        Me.CbTags.Location = New System.Drawing.Point(16, 19)
        Me.CbTags.Name = "CbTags"
        Me.CbTags.Size = New System.Drawing.Size(178, 21)
        Me.CbTags.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CbTags)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(207, 53)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TAGS"
        '
        'CBPUP
        '
        Me.CBPUP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPUP.FormattingEnabled = True
        Me.CBPUP.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CBPUP.Location = New System.Drawing.Point(47, 61)
        Me.CBPUP.Name = "CBPUP"
        Me.CBPUP.Size = New System.Drawing.Size(40, 21)
        Me.CBPUP.TabIndex = 7
        '
        'CBPDW
        '
        Me.CBPDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPDW.FormattingEnabled = True
        Me.CBPDW.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.CBPDW.Location = New System.Drawing.Point(47, 37)
        Me.CBPDW.Name = "CBPDW"
        Me.CBPDW.Size = New System.Drawing.Size(40, 21)
        Me.CBPDW.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DW"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(52, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "3.0"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(40, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "2.0"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.TObGraficas)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(207, 198)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Analisis de Graficas - Patrones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Observaciones Adicionales"
        '
        'TObGraficas
        '
        Me.TObGraficas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TObGraficas.Location = New System.Drawing.Point(4, 108)
        Me.TObGraficas.Multiline = True
        Me.TObGraficas.Name = "TObGraficas"
        Me.TObGraficas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TObGraficas.Size = New System.Drawing.Size(195, 84)
        Me.TObGraficas.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Location = New System.Drawing.Point(103, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(85, 65)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UPStream"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(6, 38)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox5.TabIndex = 6
        Me.CheckBox5.Text = "Power"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "SNR"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(89, 65)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DownStream"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 38)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Power"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "SNR"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox9)
        Me.GroupBox6.Controls.Add(Me.GroupBox3)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 257)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(207, 182)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Verificacion de Parametros"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.CheckBox14)
        Me.GroupBox9.Controls.Add(Me.CheckBox10)
        Me.GroupBox9.Controls.Add(Me.CheckBox11)
        Me.GroupBox9.Location = New System.Drawing.Point(4, 85)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(97, 86)
        Me.GroupBox9.TabIndex = 18
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Potencia"
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = True
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.Text = "Perdida < 1%"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Location = New System.Drawing.Point(6, 38)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox10.TabIndex = 11
        Me.CheckBox10.Text = "INS: < 5"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Location = New System.Drawing.Point(6, 57)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox11.TabIndex = 12
        Me.CheckBox11.Text = "MISS: < 5"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CBPUP)
        Me.GroupBox3.Controls.Add(Me.CBPDW)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(101, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(97, 89)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DOCSIS"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CheckBox16)
        Me.GroupBox8.Controls.Add(Me.CheckBox4)
        Me.GroupBox8.Controls.Add(Me.CheckBox7)
        Me.GroupBox8.Controls.Add(Me.CheckBox8)
        Me.GroupBox8.Location = New System.Drawing.Point(104, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(96, 64)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "UpStream"
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Checked = True
        Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox16.Location = New System.Drawing.Point(6, 38)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox16.TabIndex = 8
        Me.CheckBox16.Text = "PL: [38 50)"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Text = "SNR: [27 60)"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Location = New System.Drawing.Point(6, 57)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox7.TabIndex = 8
        Me.CheckBox7.Text = "PNC: < 1%"
        Me.CheckBox7.UseVisualStyleBackColor = True
        Me.CheckBox7.UseWaitCursor = True
        Me.CheckBox7.Visible = False
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Location = New System.Drawing.Point(6, 75)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox8.TabIndex = 9
        Me.CheckBox8.Text = "PC: < 20%"
        Me.CheckBox8.UseVisualStyleBackColor = True
        Me.CheckBox8.UseWaitCursor = True
        Me.CheckBox8.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CheckBox15)
        Me.GroupBox7.Controls.Add(Me.CheckBox13)
        Me.GroupBox7.Controls.Add(Me.CheckBox12)
        Me.GroupBox7.Controls.Add(Me.CheckBox9)
        Me.GroupBox7.Location = New System.Drawing.Point(1, 15)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(94, 63)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DownStream"
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Checked = True
        Me.CheckBox15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox15.Location = New System.Drawing.Point(5, 38)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox15.TabIndex = 0
        Me.CheckBox15.Text = "PL: [-10 10)"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Checked = True
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox13.TabIndex = 7
        Me.CheckBox13.Text = "SNR: [35 60)"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = True
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Location = New System.Drawing.Point(6, 57)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox12.TabIndex = 6
        Me.CheckBox12.Text = "PNC: < 1%"
        Me.CheckBox12.UseVisualStyleBackColor = True
        Me.CheckBox12.UseWaitCursor = True
        Me.CheckBox12.Visible = False
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Location = New System.Drawing.Point(6, 77)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox9.TabIndex = 10
        Me.CheckBox9.Text = "PC: < 20%"
        Me.CheckBox9.UseVisualStyleBackColor = True
        Me.CheckBox9.UseWaitCursor = True
        Me.CheckBox9.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Terminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SoporteAvanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 469)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 60)
        Me.Name = "SoporteAvanzado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cliente Critico"
        Me.TopMost = True
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CbTags As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBPUP As System.Windows.Forms.ComboBox
    Friend WithEvents CBPDW As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TObGraficas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
End Class
