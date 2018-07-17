<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diadema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Diadema))
        Me.BtAplicar = New System.Windows.Forms.Button()
        Me.OIDO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxTimeD = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtAplicar
        '
        Me.BtAplicar.Location = New System.Drawing.Point(221, 81)
        Me.BtAplicar.Name = "BtAplicar"
        Me.BtAplicar.Size = New System.Drawing.Size(86, 23)
        Me.BtAplicar.TabIndex = 0
        Me.BtAplicar.Text = "Aplicar"
        Me.BtAplicar.UseVisualStyleBackColor = True
        '
        'OIDO
        '
        Me.OIDO.AutoSize = True
        Me.OIDO.Location = New System.Drawing.Point(6, 20)
        Me.OIDO.Name = "OIDO"
        Me.OIDO.Size = New System.Drawing.Size(34, 13)
        Me.OIDO.TabIndex = 1
        Me.OIDO.Text = "OIDO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TIEMPO"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DERECHO", "IZQUIERDO"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxTimeD)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OIDO)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 72)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TxTimeD
        '
        Me.TxTimeD.Location = New System.Drawing.Point(222, 37)
        Me.TxTimeD.MaxLength = 2
        Me.TxTimeD.Name = "TxTimeD"
        Me.TxTimeD.Size = New System.Drawing.Size(75, 20)
        Me.TxTimeD.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Detener Cronometro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Diadema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 112)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtAplicar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Diadema"
        Me.Text = "Diadema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtAplicar As System.Windows.Forms.Button
    Friend WithEvents OIDO As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxTimeD As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
