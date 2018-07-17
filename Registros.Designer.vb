<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros
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
        Me.Llamadas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValIDar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UCID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INTEGRAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOVIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLANTILLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Llamadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Llamadas
        '
        Me.Llamadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Llamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Llamadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ValIDar, Me.UCID, Me.USUARIO, Me.CC, Me.ACTIVO, Me.INTEGRAL, Me.MOVIL, Me.PLANTILLA, Me.Direccion, Me.Dgt, Me.time})
        Me.Llamadas.EnableHeadersVisualStyles = False
        Me.Llamadas.Location = New System.Drawing.Point(0, 0)
        Me.Llamadas.Name = "Llamadas"
        Me.Llamadas.RowHeadersVisible = False
        Me.Llamadas.Size = New System.Drawing.Size(928, 304)
        Me.Llamadas.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(775, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'ValIDar
        '
        Me.ValIDar.HeaderText = ""
        Me.ValIDar.Name = "ValIDar"
        Me.ValIDar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ValIDar.Width = 50
        '
        'UCID
        '
        Me.UCID.HeaderText = "UCID"
        Me.UCID.Name = "UCID"
        '
        'USUARIO
        '
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        '
        'CC
        '
        Me.CC.HeaderText = "CC"
        Me.CC.Name = "CC"
        '
        'ACTIVO
        '
        Me.ACTIVO.HeaderText = "ACTIVO"
        Me.ACTIVO.Name = "ACTIVO"
        '
        'INTEGRAL
        '
        Me.INTEGRAL.HeaderText = "INTEGRAL"
        Me.INTEGRAL.Name = "INTEGRAL"
        '
        'MOVIL
        '
        Me.MOVIL.HeaderText = "MOVIL"
        Me.MOVIL.Name = "MOVIL"
        '
        'PLANTILLA
        '
        Me.PLANTILLA.HeaderText = "PLANTILLA"
        Me.PLANTILLA.Name = "PLANTILLA"
        Me.PLANTILLA.Width = 300
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'Dgt
        '
        Me.Dgt.HeaderText = "Diagnostico"
        Me.Dgt.Name = "Dgt"
        '
        'time
        '
        Me.time.HeaderText = "Duracion"
        Me.time.Name = "time"
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Llamadas)
        Me.Name = "Registros"
        Me.Text = "Plantilla  -   Prototipo Desarrollado por JUAN CHARRY"
        Me.TopMost = True
        CType(Me.Llamadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Llamadas As System.Windows.Forms.DataGrIDView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ValIDar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UCID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INTEGRAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOVIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLANTILLA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
