<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modems))
        Me.USUARIO = New System.Windows.Forms.DataGrIDViewTextBoxColumn()
        Me.PWD = New System.Windows.Forms.DataGrIDViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODEMSData = New System.Windows.Forms.DataGrIDView()
        Me.USER = New System.Windows.Forms.DataGrIDViewTextBoxColumn()
        Me.PASS = New System.Windows.Forms.DataGrIDViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.MODEMSData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USUARIO
        '
        Me.USUARIO.HeaderText = "USUARI0"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.WIDth = 200
        '
        'PWD
        '
        Me.PWD.HeaderText = "CONTRASEÑA"
        Me.PWD.Name = "PWD"
        Me.PWD.WIDth = 200
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(442, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'MODEMSData
        '
        Me.MODEMSData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGrIDViewColumnHeadersHeightSizeMode.AutoSize
        Me.MODEMSData.Columns.AddRange(New System.Windows.Forms.DataGrIDViewColumn() {Me.USER, Me.PASS})
        Me.MODEMSData.Location = New System.Drawing.Point(12, 52)
        Me.MODEMSData.Name = "MODEMSData"
        Me.MODEMSData.Size = New System.Drawing.Size(439, 155)
        Me.MODEMSData.TabIndex = 30
        '
        'USER
        '
        Me.USER.HeaderText = "USUARIO"
        Me.USER.Name = "USER"
        Me.USER.WIDth = 180
        '
        'PASS
        '
        Me.PASS.HeaderText = "CONTRASEÑA"
        Me.PASS.Name = "PASS"
        Me.PASS.WIDth = 200
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 213)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(439, 126)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Text = "Mascara de Subred: 255.255.255.0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 4)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(73, 18)
        Me.LinkLabel1.TabIndex = 33
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Modems"
        '
        'Modems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 344)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODEMSData)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Modems"
        Me.Text = "Prototipo Desarrollado por JUAN CHARRY - Modems"
        CType(Me.MODEMSData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MODEMSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGrIDViewTextBoxColumn5 As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents DataGrIDViewTextBoxColumn6 As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents USUARIO As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents PWD As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents MODEMSData As System.Windows.Forms.DataGrIDView
    Friend WithEvents USER As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents PASS As System.Windows.Forms.DataGrIDViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
