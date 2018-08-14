<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cronometro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cronometro))
        Me.GBLlamada = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.IDiadema = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Liz = New System.Windows.Forms.Label()
        Me.Duracion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Toido = New System.Windows.Forms.Label()
        Me.LbMinutos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbSegndos = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GBLlamada.SuspendLayout()
        CType(Me.IDiadema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBLlamada
        '
        Me.GBLlamada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBLlamada.Controls.Add(Me.IDiadema)
        Me.GBLlamada.Controls.Add(Me.Liz)
        Me.GBLlamada.Controls.Add(Me.Duracion)
        Me.GBLlamada.Controls.Add(Me.PictureBox1)
        Me.GBLlamada.Controls.Add(Me.Toido)
        Me.GBLlamada.Location = New System.Drawing.Point(102, -4)
        Me.GBLlamada.Name = "GBLlamada"
        Me.GBLlamada.Size = New System.Drawing.Size(81, 49)
        Me.GBLlamada.TabIndex = 163
        Me.GBLlamada.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(214, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 20)
        Me.Button3.TabIndex = 170
        Me.Button3.Text = "R"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'IDiadema
        '
        Me.IDiadema.Image = CType(resources.GetObject("IDiadema.Image"), System.Drawing.Image)
        Me.IDiadema.Location = New System.Drawing.Point(27, 8)
        Me.IDiadema.Name = "IDiadema"
        Me.IDiadema.Size = New System.Drawing.Size(15, 18)
        Me.IDiadema.TabIndex = 162
        Me.IDiadema.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(214, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 20)
        Me.Button4.TabIndex = 169
        Me.Button4.Text = "3"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Liz
        '
        Me.Liz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Liz.ForeColor = System.Drawing.Color.White
        Me.Liz.Location = New System.Drawing.Point(5, 8)
        Me.Liz.Name = "Liz"
        Me.Liz.Padding = New System.Windows.Forms.Padding(1)
        Me.Liz.Size = New System.Drawing.Size(25, 17)
        Me.Liz.TabIndex = 166
        Me.Liz.Text = "<<"
        '
        'Duracion
        '
        Me.Duracion.AutoSize = True
        Me.Duracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Duracion.Location = New System.Drawing.Point(27, 26)
        Me.Duracion.Name = "Duracion"
        Me.Duracion.Size = New System.Drawing.Size(23, 15)
        Me.Duracion.TabIndex = 165
        Me.Duracion.Text = "00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 18)
        Me.PictureBox1.TabIndex = 162
        Me.PictureBox1.TabStop = False
        '
        'Toido
        '
        Me.Toido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Toido.ForeColor = System.Drawing.Color.White
        Me.Toido.Location = New System.Drawing.Point(45, 7)
        Me.Toido.Name = "Toido"
        Me.Toido.Padding = New System.Windows.Forms.Padding(1)
        Me.Toido.Size = New System.Drawing.Size(25, 17)
        Me.Toido.TabIndex = 164
        Me.Toido.Text = ">>"
        '
        'LbMinutos
        '
        Me.LbMinutos.AutoSize = True
        Me.LbMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMinutos.Location = New System.Drawing.Point(0, 3)
        Me.LbMinutos.Name = "LbMinutos"
        Me.LbMinutos.Size = New System.Drawing.Size(49, 36)
        Me.LbMinutos.TabIndex = 164
        Me.LbMinutos.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 36)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = ":"
        '
        'LbSegndos
        '
        Me.LbSegndos.AutoSize = True
        Me.LbSegndos.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSegndos.Location = New System.Drawing.Point(52, 3)
        Me.LbSegndos.Name = "LbSegndos"
        Me.LbSegndos.Size = New System.Drawing.Size(49, 36)
        Me.LbSegndos.TabIndex = 165
        Me.LbSegndos.Text = "00"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(189, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 20)
        Me.Button1.TabIndex = 167
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(189, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 20)
        Me.Button2.TabIndex = 168
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Cronometro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 46)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LbSegndos)
        Me.Controls.Add(Me.LbMinutos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GBLlamada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(1120, 565)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 85)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(134, 80)
        Me.Name = "Cronometro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cronometro"
        Me.TopMost = True
        Me.GBLlamada.ResumeLayout(False)
        Me.GBLlamada.PerformLayout()
        CType(Me.IDiadema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBLlamada As System.Windows.Forms.GroupBox
    Friend WithEvents Toido As System.Windows.Forms.Label
    Friend WithEvents IDiadema As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbMinutos As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbSegndos As System.Windows.Forms.Label
    Friend WithEvents Duracion As System.Windows.Forms.Label
    Friend WithEvents Liz As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
