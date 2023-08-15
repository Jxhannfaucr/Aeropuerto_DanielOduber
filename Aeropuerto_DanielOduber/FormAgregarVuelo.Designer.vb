<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarVuelo
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
        Me.GroupBoxOrigen = New System.Windows.Forms.GroupBox()
        Me.TextBoxEscala = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxHoraLlegada = New System.Windows.Forms.TextBox()
        Me.TextBoxHoraSalida = New System.Windows.Forms.TextBox()
        Me.TextBoxDestino = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBoxOrigen.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxOrigen
        '
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxEscala)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxPrecio)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraLlegada)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraSalida)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxDestino)
        Me.GroupBoxOrigen.Controls.Add(Me.ComboBox2)
        Me.GroupBoxOrigen.Controls.Add(Me.ComboBox1)
        Me.GroupBoxOrigen.Controls.Add(Me.BtnAgregar)
        Me.GroupBoxOrigen.Controls.Add(Me.Label1)
        Me.GroupBoxOrigen.Controls.Add(Me.Label14)
        Me.GroupBoxOrigen.Controls.Add(Me.Label15)
        Me.GroupBoxOrigen.Controls.Add(Me.Label16)
        Me.GroupBoxOrigen.Controls.Add(Me.Label17)
        Me.GroupBoxOrigen.Controls.Add(Me.Label18)
        Me.GroupBoxOrigen.Controls.Add(Me.Label19)
        Me.GroupBoxOrigen.Location = New System.Drawing.Point(53, 46)
        Me.GroupBoxOrigen.Name = "GroupBoxOrigen"
        Me.GroupBoxOrigen.Size = New System.Drawing.Size(446, 488)
        Me.GroupBoxOrigen.TabIndex = 27
        Me.GroupBoxOrigen.TabStop = False
        Me.GroupBoxOrigen.Text = "Vuelo"
        '
        'TextBoxEscala
        '
        Me.TextBoxEscala.Location = New System.Drawing.Point(127, 297)
        Me.TextBoxEscala.Name = "TextBoxEscala"
        Me.TextBoxEscala.Size = New System.Drawing.Size(201, 26)
        Me.TextBoxEscala.TabIndex = 39
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(123, 352)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(201, 26)
        Me.TextBoxPrecio.TabIndex = 38
        '
        'TextBoxHoraLlegada
        '
        Me.TextBoxHoraLlegada.Location = New System.Drawing.Point(207, 203)
        Me.TextBoxHoraLlegada.Name = "TextBoxHoraLlegada"
        Me.TextBoxHoraLlegada.Size = New System.Drawing.Size(201, 26)
        Me.TextBoxHoraLlegada.TabIndex = 37
        '
        'TextBoxHoraSalida
        '
        Me.TextBoxHoraSalida.Location = New System.Drawing.Point(207, 149)
        Me.TextBoxHoraSalida.Name = "TextBoxHoraSalida"
        Me.TextBoxHoraSalida.Size = New System.Drawing.Size(201, 26)
        Me.TextBoxHoraSalida.TabIndex = 36
        '
        'TextBoxDestino
        '
        Me.TextBoxDestino.Location = New System.Drawing.Point(139, 93)
        Me.TextBoxDestino.Name = "TextBoxDestino"
        Me.TextBoxDestino.Size = New System.Drawing.Size(252, 26)
        Me.TextBoxDestino.TabIndex = 35
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Costa Rica"})
        Me.ComboBox2.Location = New System.Drawing.Point(127, 44)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(281, 28)
        Me.ComboBox2.TabIndex = 34
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox1.Location = New System.Drawing.Point(270, 252)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 33
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(137, 406)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(187, 61)
        Me.BtnAgregar.TabIndex = 32
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Precio:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 25)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Destino:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 297)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Escala:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 252)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(242, 25)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Numero de ventanilla:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 203)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(186, 25)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Hora de llegada:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(21, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(172, 25)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Hora de salida:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 25)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Origen:"
        '
        'FormAgregarVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(581, 645)
        Me.Controls.Add(Me.GroupBoxOrigen)
        Me.Name = "FormAgregarVuelo"
        Me.Text = "FormAgregarVuelo"
        Me.GroupBoxOrigen.ResumeLayout(False)
        Me.GroupBoxOrigen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxOrigen As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBoxEscala As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxHoraLlegada As TextBox
    Friend WithEvents TextBoxHoraSalida As TextBox
    Friend WithEvents TextBoxDestino As TextBox
End Class
