<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cant_vuelos
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
        Me.buscar_fecha = New System.Windows.Forms.DateTimePicker()
        Me.List_ventanillas = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Total_de_vuelos = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buscar_fecha
        '
        Me.buscar_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar_fecha.Location = New System.Drawing.Point(9, 63)
        Me.buscar_fecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.buscar_fecha.Name = "buscar_fecha"
        Me.buscar_fecha.Size = New System.Drawing.Size(480, 35)
        Me.buscar_fecha.TabIndex = 0
        '
        'List_ventanillas
        '
        Me.List_ventanillas.FormattingEnabled = True
        Me.List_ventanillas.Items.AddRange(New Object() {"1", "2", "3", "4", "TODO"})
        Me.List_ventanillas.Location = New System.Drawing.Point(9, 129)
        Me.List_ventanillas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.List_ventanillas.Name = "List_ventanillas"
        Me.List_ventanillas.Size = New System.Drawing.Size(180, 28)
        Me.List_ventanillas.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 211)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 294)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cantidad de vuelos:"
        '
        'Total_de_vuelos
        '
        Me.Total_de_vuelos.Location = New System.Drawing.Point(170, 294)
        Me.Total_de_vuelos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Total_de_vuelos.Name = "Total_de_vuelos"
        Me.Total_de_vuelos.Size = New System.Drawing.Size(148, 26)
        Me.Total_de_vuelos.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1070, 43)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.buscar_fecha)
        Me.GroupBox1.Controls.Add(Me.List_ventanillas)
        Me.GroupBox1.Controls.Add(Me.Total_de_vuelos)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(370, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(497, 571)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 363)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(364, 171)
        Me.DataGridView1.TabIndex = 7
        '
        'Cant_vuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Cant_vuelos"
        Me.Text = "Cant_vuelos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buscar_fecha As DateTimePicker
    Friend WithEvents List_ventanillas As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Total_de_vuelos As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
