﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeSalida = New System.Windows.Forms.DateTimePicker()
        Me.sdcs = New System.Windows.Forms.Label()
        Me.TextBoxEscala = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxHoraLlegada = New System.Windows.Forms.TextBox()
        Me.TextBoxHoraSalida = New System.Windows.Forms.TextBox()
        Me.TextBoxDestino = New System.Windows.Forms.TextBox()
        Me.ComboBoxorigen = New System.Windows.Forms.ComboBox()
        Me.ComboBoxnumeroventanilla = New System.Windows.Forms.ComboBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBoxid_avion = New System.Windows.Forms.ComboBox()
        Me.GroupBoxOrigen.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxOrigen
        '
        Me.GroupBoxOrigen.Controls.Add(Me.ComboBoxid_avion)
        Me.GroupBoxOrigen.Controls.Add(Me.Label2)
        Me.GroupBoxOrigen.Controls.Add(Me.DateTimeSalida)
        Me.GroupBoxOrigen.Controls.Add(Me.sdcs)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxEscala)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxPrecio)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraLlegada)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraSalida)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxDestino)
        Me.GroupBoxOrigen.Controls.Add(Me.ComboBoxorigen)
        Me.GroupBoxOrigen.Controls.Add(Me.ComboBoxnumeroventanilla)
        Me.GroupBoxOrigen.Controls.Add(Me.BtnAgregar)
        Me.GroupBoxOrigen.Controls.Add(Me.Label1)
        Me.GroupBoxOrigen.Controls.Add(Me.Label14)
        Me.GroupBoxOrigen.Controls.Add(Me.Label15)
        Me.GroupBoxOrigen.Controls.Add(Me.Label16)
        Me.GroupBoxOrigen.Controls.Add(Me.Label17)
        Me.GroupBoxOrigen.Controls.Add(Me.Label18)
        Me.GroupBoxOrigen.Controls.Add(Me.Label19)
        Me.GroupBoxOrigen.Location = New System.Drawing.Point(35, 30)
        Me.GroupBoxOrigen.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxOrigen.Name = "GroupBoxOrigen"
        Me.GroupBoxOrigen.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxOrigen.Size = New System.Drawing.Size(385, 413)
        Me.GroupBoxOrigen.TabIndex = 27
        Me.GroupBoxOrigen.TabStop = False
        Me.GroupBoxOrigen.Text = "Vuelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 294)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Fecha de Salida:"
        '
        'DateTimeSalida
        '
        Me.DateTimeSalida.Location = New System.Drawing.Point(180, 291)
        Me.DateTimeSalida.Name = "DateTimeSalida"
        Me.DateTimeSalida.Size = New System.Drawing.Size(189, 20)
        Me.DateTimeSalida.TabIndex = 42
        '
        'sdcs
        '
        Me.sdcs.AutoSize = True
        Me.sdcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdcs.Location = New System.Drawing.Point(17, 226)
        Me.sdcs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sdcs.Name = "sdcs"
        Me.sdcs.Size = New System.Drawing.Size(71, 17)
        Me.sdcs.TabIndex = 40
        Me.sdcs.Text = "ID_avion"
        '
        'TextBoxEscala
        '
        Me.TextBoxEscala.Location = New System.Drawing.Point(180, 193)
        Me.TextBoxEscala.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEscala.Name = "TextBoxEscala"
        Me.TextBoxEscala.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxEscala.TabIndex = 39
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(180, 257)
        Me.TextBoxPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxPrecio.TabIndex = 38
        '
        'TextBoxHoraLlegada
        '
        Me.TextBoxHoraLlegada.Location = New System.Drawing.Point(180, 132)
        Me.TextBoxHoraLlegada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHoraLlegada.Name = "TextBoxHoraLlegada"
        Me.TextBoxHoraLlegada.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxHoraLlegada.TabIndex = 37
        '
        'TextBoxHoraSalida
        '
        Me.TextBoxHoraSalida.Location = New System.Drawing.Point(180, 96)
        Me.TextBoxHoraSalida.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHoraSalida.Name = "TextBoxHoraSalida"
        Me.TextBoxHoraSalida.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxHoraSalida.TabIndex = 36
        '
        'TextBoxDestino
        '
        Me.TextBoxDestino.Location = New System.Drawing.Point(180, 61)
        Me.TextBoxDestino.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDestino.Name = "TextBoxDestino"
        Me.TextBoxDestino.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxDestino.TabIndex = 35
        '
        'ComboBoxorigen
        '
        Me.ComboBoxorigen.FormattingEnabled = True
        Me.ComboBoxorigen.Items.AddRange(New Object() {"Costa Rica"})
        Me.ComboBoxorigen.Location = New System.Drawing.Point(180, 28)
        Me.ComboBoxorigen.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxorigen.Name = "ComboBoxorigen"
        Me.ComboBoxorigen.Size = New System.Drawing.Size(189, 21)
        Me.ComboBoxorigen.TabIndex = 34
        '
        'ComboBoxnumeroventanilla
        '
        Me.ComboBoxnumeroventanilla.FormattingEnabled = True
        Me.ComboBoxnumeroventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxnumeroventanilla.Location = New System.Drawing.Point(180, 164)
        Me.ComboBoxnumeroventanilla.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxnumeroventanilla.Name = "ComboBoxnumeroventanilla"
        Me.ComboBoxnumeroventanilla.Size = New System.Drawing.Size(189, 21)
        Me.ComboBoxnumeroventanilla.TabIndex = 33
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(85, 351)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(125, 40)
        Me.BtnAgregar.TabIndex = 32
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 257)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Precio:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 61)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 17)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Destino:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 193)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Escala:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(14, 164)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 17)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Numero de ventanilla:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 132)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Hora de llegada:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 96)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 17)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Hora de salida:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 28)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 17)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Origen:"
        '
        'ComboBoxid_avion
        '
        Me.ComboBoxid_avion.FormattingEnabled = True
        Me.ComboBoxid_avion.Items.AddRange(New Object() {"9"})
        Me.ComboBoxid_avion.Location = New System.Drawing.Point(180, 222)
        Me.ComboBoxid_avion.Name = "ComboBoxid_avion"
        Me.ComboBoxid_avion.Size = New System.Drawing.Size(189, 21)
        Me.ComboBoxid_avion.TabIndex = 44
        '
        'FormAgregarVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(468, 530)
        Me.Controls.Add(Me.GroupBoxOrigen)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents ComboBoxnumeroventanilla As ComboBox
    Friend WithEvents ComboBoxorigen As ComboBox
    Friend WithEvents TextBoxEscala As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxHoraLlegada As TextBox
    Friend WithEvents TextBoxHoraSalida As TextBox
    Friend WithEvents TextBoxDestino As TextBox
    Friend WithEvents sdcs As Label
    Friend WithEvents DateTimeSalida As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxid_avion As ComboBox
End Class
