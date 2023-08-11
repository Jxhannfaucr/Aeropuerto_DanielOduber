<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasajeros_llegados
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
        Me.ComboBoxLlegados = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.texbox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxLlegados
        '
        Me.ComboBoxLlegados.FormattingEnabled = True
        Me.ComboBoxLlegados.Location = New System.Drawing.Point(143, 187)
        Me.ComboBoxLlegados.Name = "ComboBoxLlegados"
        Me.ComboBoxLlegados.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxLlegados.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'texbox
        '
        Me.texbox.Location = New System.Drawing.Point(143, 350)
        Me.texbox.Name = "texbox"
        Me.texbox.Size = New System.Drawing.Size(100, 20)
        Me.texbox.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(473, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(402, 261)
        Me.DataGridView1.TabIndex = 3
        '
        'Pasajeros_llegados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(994, 580)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.texbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxLlegados)
        Me.Name = "Pasajeros_llegados"
        Me.Text = "Pasajeros_llegados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxLlegados As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents texbox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
