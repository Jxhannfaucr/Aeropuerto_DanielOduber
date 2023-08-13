<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pasajeros_bajados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Ver = New System.Windows.Forms.Button()
        Me.Box_con_escala = New System.Windows.Forms.ComboBox()
        Me.textMostrar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Ver
        '
        Me.Btn_Ver.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ver.Location = New System.Drawing.Point(64, 172)
        Me.Btn_Ver.Name = "Btn_Ver"
        Me.Btn_Ver.Size = New System.Drawing.Size(75, 27)
        Me.Btn_Ver.TabIndex = 0
        Me.Btn_Ver.Text = "Ver"
        Me.Btn_Ver.UseVisualStyleBackColor = True
        '
        'Box_con_escala
        '
        Me.Box_con_escala.FormattingEnabled = True
        Me.Box_con_escala.Location = New System.Drawing.Point(64, 134)
        Me.Box_con_escala.Name = "Box_con_escala"
        Me.Box_con_escala.Size = New System.Drawing.Size(121, 21)
        Me.Box_con_escala.TabIndex = 1
        '
        'textMostrar
        '
        Me.textMostrar.Location = New System.Drawing.Point(64, 243)
        Me.textMostrar.Name = "textMostrar"
        Me.textMostrar.Size = New System.Drawing.Size(100, 20)
        Me.textMostrar.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(263, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(525, 232)
        Me.DataGridView1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione de los destino que tienen escalas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID del vuelo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Saber cuales cuales y cuantos pasajeros se bajaron "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(705, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pasajeros_bajados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.textMostrar)
        Me.Controls.Add(Me.Box_con_escala)
        Me.Controls.Add(Me.Btn_Ver)
        Me.Name = "pasajeros_bajados"
        Me.Text = "pasajeros_bajados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Ver As Button
    Friend WithEvents Box_con_escala As ComboBox
    Friend WithEvents textMostrar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
