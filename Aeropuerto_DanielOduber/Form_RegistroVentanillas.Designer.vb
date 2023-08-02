<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_RegistroVentanillas
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
        Me.btn_VolverMenu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxFechaSalida = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxNumeroDePasaporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNacionalidad = New System.Windows.Forms.TextBox()
        Me.ComboBoxDestino = New System.Windows.Forms.ComboBox()
        Me.ComboBoxNumeroDeAsiento = New System.Windows.Forms.ComboBox()
        Me.TextBoxHoraAtencion = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecioTiquete = New System.Windows.Forms.TextBox()
        Me.TextBoxNombrePasajero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxHoraSalida = New System.Windows.Forms.TextBox()
        Me.TextBoxDestino = New System.Windows.Forms.TextBox()
        Me.TextBoxNumVentanilla = New System.Windows.Forms.TextBox()
        Me.TextBoxEscala = New System.Windows.Forms.TextBox()
        Me.TextBoxHoraLlegada = New System.Windows.Forms.TextBox()
        Me.TextBoxOrigen = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnConfirmarCompra = New System.Windows.Forms.Button()
        Me.BtnConfirmarVentanilla = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxLinea_Aereas = New System.Windows.Forms.ComboBox()
        Me.TextBoxHoraApertura = New System.Windows.Forms.TextBox()
        Me.TextBoxCedula_Empl = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre_Emple = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxID_Ventanilla = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_VolverMenu
        '
        Me.btn_VolverMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_VolverMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VolverMenu.Location = New System.Drawing.Point(1415, 9)
        Me.btn_VolverMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_VolverMenu.Name = "btn_VolverMenu"
        Me.btn_VolverMenu.Size = New System.Drawing.Size(135, 38)
        Me.btn_VolverMenu.TabIndex = 9
        Me.btn_VolverMenu.Text = "Menu"
        Me.btn_VolverMenu.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxFechaSalida)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.TextBoxNumeroDePasaporte)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxNacionalidad)
        Me.GroupBox2.Controls.Add(Me.ComboBoxDestino)
        Me.GroupBox2.Controls.Add(Me.ComboBoxNumeroDeAsiento)
        Me.GroupBox2.Controls.Add(Me.TextBoxHoraAtencion)
        Me.GroupBox2.Controls.Add(Me.TextBoxPrecioTiquete)
        Me.GroupBox2.Controls.Add(Me.TextBoxNombrePasajero)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 45)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(446, 488)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pasajero"
        '
        'TextBoxFechaSalida
        '
        Me.TextBoxFechaSalida.Location = New System.Drawing.Point(242, 252)
        Me.TextBoxFechaSalida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxFechaSalida.Name = "TextBoxFechaSalida"
        Me.TextBoxFechaSalida.Size = New System.Drawing.Size(182, 26)
        Me.TextBoxFechaSalida.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 430)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(217, 25)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Numero de asiento:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 392)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 25)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Escala:"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(182, 393)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 24)
        Me.CheckBox2.TabIndex = 27
        Me.CheckBox2.Text = "NO"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(116, 393)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 24)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "SI"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBoxNumeroDePasaporte
        '
        Me.TextBoxNumeroDePasaporte.Location = New System.Drawing.Point(272, 342)
        Me.TextBoxNumeroDePasaporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNumeroDePasaporte.Name = "TextBoxNumeroDePasaporte"
        Me.TextBoxNumeroDePasaporte.Size = New System.Drawing.Size(152, 26)
        Me.TextBoxNumeroDePasaporte.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Numero de pasaporte:"
        '
        'TextBoxNacionalidad
        '
        Me.TextBoxNacionalidad.Location = New System.Drawing.Point(182, 96)
        Me.TextBoxNacionalidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        Me.TextBoxNacionalidad.Size = New System.Drawing.Size(242, 26)
        Me.TextBoxNacionalidad.TabIndex = 23
        '
        'ComboBoxDestino
        '
        Me.ComboBoxDestino.FormattingEnabled = True
        Me.ComboBoxDestino.Location = New System.Drawing.Point(146, 145)
        Me.ComboBoxDestino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxDestino.Name = "ComboBoxDestino"
        Me.ComboBoxDestino.Size = New System.Drawing.Size(136, 28)
        Me.ComboBoxDestino.TabIndex = 22
        '
        'ComboBoxNumeroDeAsiento
        '
        Me.ComboBoxNumeroDeAsiento.FormattingEnabled = True
        Me.ComboBoxNumeroDeAsiento.Location = New System.Drawing.Point(244, 427)
        Me.ComboBoxNumeroDeAsiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxNumeroDeAsiento.Name = "ComboBoxNumeroDeAsiento"
        Me.ComboBoxNumeroDeAsiento.Size = New System.Drawing.Size(136, 28)
        Me.ComboBoxNumeroDeAsiento.TabIndex = 21
        '
        'TextBoxHoraAtencion
        '
        Me.TextBoxHoraAtencion.Location = New System.Drawing.Point(242, 298)
        Me.TextBoxHoraAtencion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxHoraAtencion.Name = "TextBoxHoraAtencion"
        Me.TextBoxHoraAtencion.Size = New System.Drawing.Size(182, 26)
        Me.TextBoxHoraAtencion.TabIndex = 20
        '
        'TextBoxPrecioTiquete
        '
        Me.TextBoxPrecioTiquete.Enabled = False
        Me.TextBoxPrecioTiquete.Location = New System.Drawing.Point(242, 203)
        Me.TextBoxPrecioTiquete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxPrecioTiquete.Name = "TextBoxPrecioTiquete"
        Me.TextBoxPrecioTiquete.Size = New System.Drawing.Size(182, 26)
        Me.TextBoxPrecioTiquete.TabIndex = 19
        '
        'TextBoxNombrePasajero
        '
        Me.TextBoxNombrePasajero.Location = New System.Drawing.Point(126, 44)
        Me.TextBoxNombrePasajero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNombrePasajero.Name = "TextBoxNombrePasajero"
        Me.TextBoxNombrePasajero.Size = New System.Drawing.Size(278, 26)
        Me.TextBoxNombrePasajero.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Destino:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Hora de atencion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Fecha de salida:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(198, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Precio de tiquete:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 25)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Nacionalidad:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 25)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Nombre:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxHoraSalida)
        Me.GroupBox3.Controls.Add(Me.TextBoxDestino)
        Me.GroupBox3.Controls.Add(Me.TextBoxNumVentanilla)
        Me.GroupBox3.Controls.Add(Me.TextBoxEscala)
        Me.GroupBox3.Controls.Add(Me.TextBoxHoraLlegada)
        Me.GroupBox3.Controls.Add(Me.TextBoxOrigen)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(1009, 48)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(446, 365)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vuelo"
        '
        'TextBoxHoraSalida
        '
        Me.TextBoxHoraSalida.Enabled = False
        Me.TextBoxHoraSalida.Location = New System.Drawing.Point(209, 149)
        Me.TextBoxHoraSalida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxHoraSalida.Name = "TextBoxHoraSalida"
        Me.TextBoxHoraSalida.Size = New System.Drawing.Size(182, 26)
        Me.TextBoxHoraSalida.TabIndex = 29
        '
        'TextBoxDestino
        '
        Me.TextBoxDestino.Enabled = False
        Me.TextBoxDestino.Location = New System.Drawing.Point(135, 93)
        Me.TextBoxDestino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDestino.Name = "TextBoxDestino"
        Me.TextBoxDestino.Size = New System.Drawing.Size(256, 26)
        Me.TextBoxDestino.TabIndex = 28
        '
        'TextBoxNumVentanilla
        '
        Me.TextBoxNumVentanilla.Enabled = False
        Me.TextBoxNumVentanilla.Location = New System.Drawing.Point(269, 254)
        Me.TextBoxNumVentanilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNumVentanilla.Name = "TextBoxNumVentanilla"
        Me.TextBoxNumVentanilla.Size = New System.Drawing.Size(133, 26)
        Me.TextBoxNumVentanilla.TabIndex = 27
        '
        'TextBoxEscala
        '
        Me.TextBoxEscala.Enabled = False
        Me.TextBoxEscala.Location = New System.Drawing.Point(116, 298)
        Me.TextBoxEscala.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxEscala.Name = "TextBoxEscala"
        Me.TextBoxEscala.Size = New System.Drawing.Size(286, 26)
        Me.TextBoxEscala.TabIndex = 20
        '
        'TextBoxHoraLlegada
        '
        Me.TextBoxHoraLlegada.Enabled = False
        Me.TextBoxHoraLlegada.Location = New System.Drawing.Point(209, 203)
        Me.TextBoxHoraLlegada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxHoraLlegada.Name = "TextBoxHoraLlegada"
        Me.TextBoxHoraLlegada.Size = New System.Drawing.Size(182, 26)
        Me.TextBoxHoraLlegada.TabIndex = 19
        '
        'TextBoxOrigen
        '
        Me.TextBoxOrigen.Enabled = False
        Me.TextBoxOrigen.Location = New System.Drawing.Point(146, 44)
        Me.TextBoxOrigen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxOrigen.Name = "TextBoxOrigen"
        Me.TextBoxOrigen.Size = New System.Drawing.Size(256, 26)
        Me.TextBoxOrigen.TabIndex = 18
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
        Me.Label15.Location = New System.Drawing.Point(20, 297)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Escala:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 253)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(242, 25)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Numero de ventanilla:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(186, 25)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Hora de llegada:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(20, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(172, 25)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Hora de salida:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 25)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Origen:"
        '
        'BtnConfirmarCompra
        '
        Me.BtnConfirmarCompra.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarCompra.Location = New System.Drawing.Point(1009, 453)
        Me.BtnConfirmarCompra.Name = "BtnConfirmarCompra"
        Me.BtnConfirmarCompra.Size = New System.Drawing.Size(201, 67)
        Me.BtnConfirmarCompra.TabIndex = 27
        Me.BtnConfirmarCompra.Text = "Confirmar compra"
        Me.BtnConfirmarCompra.UseVisualStyleBackColor = True
        '
        'BtnConfirmarVentanilla
        '
        Me.BtnConfirmarVentanilla.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnConfirmarVentanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConfirmarVentanilla.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarVentanilla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnConfirmarVentanilla.Location = New System.Drawing.Point(56, 558)
        Me.BtnConfirmarVentanilla.Name = "BtnConfirmarVentanilla"
        Me.BtnConfirmarVentanilla.Size = New System.Drawing.Size(115, 46)
        Me.BtnConfirmarVentanilla.TabIndex = 29
        Me.BtnConfirmarVentanilla.Text = "Cofirmar"
        Me.BtnConfirmarVentanilla.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxLinea_Aereas)
        Me.GroupBox1.Controls.Add(Me.TextBoxHoraApertura)
        Me.GroupBox1.Controls.Add(Me.TextBoxCedula_Empl)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre_Emple)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxID_Ventanilla)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 45)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(446, 488)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de ventanillas"
        '
        'ComboBoxLinea_Aereas
        '
        Me.ComboBoxLinea_Aereas.FormattingEnabled = True
        Me.ComboBoxLinea_Aereas.Location = New System.Drawing.Point(272, 340)
        Me.ComboBoxLinea_Aereas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxLinea_Aereas.Name = "ComboBoxLinea_Aereas"
        Me.ComboBoxLinea_Aereas.Size = New System.Drawing.Size(136, 28)
        Me.ComboBoxLinea_Aereas.TabIndex = 21
        '
        'TextBoxHoraApertura
        '
        Me.TextBoxHoraApertura.Location = New System.Drawing.Point(272, 271)
        Me.TextBoxHoraApertura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxHoraApertura.Name = "TextBoxHoraApertura"
        Me.TextBoxHoraApertura.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxHoraApertura.TabIndex = 20
        '
        'TextBoxCedula_Empl
        '
        Me.TextBoxCedula_Empl.Location = New System.Drawing.Point(272, 205)
        Me.TextBoxCedula_Empl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxCedula_Empl.Name = "TextBoxCedula_Empl"
        Me.TextBoxCedula_Empl.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxCedula_Empl.TabIndex = 19
        '
        'TextBoxNombre_Emple
        '
        Me.TextBoxNombre_Emple.Location = New System.Drawing.Point(272, 136)
        Me.TextBoxNombre_Emple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNombre_Emple.Name = "TextBoxNombre_Emple"
        Me.TextBoxNombre_Emple.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxNombre_Emple.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Linea Aérea:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Hora Apertura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cédula Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese la ventanilla:"
        '
        'ComboBoxID_Ventanilla
        '
        Me.ComboBoxID_Ventanilla.FormattingEnabled = True
        Me.ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxID_Ventanilla.Location = New System.Drawing.Point(272, 59)
        Me.ComboBoxID_Ventanilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        Me.ComboBoxID_Ventanilla.Size = New System.Drawing.Size(136, 28)
        Me.ComboBoxID_Ventanilla.TabIndex = 11
        '
        'Form_RegistroVentanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1555, 654)
        Me.Controls.Add(Me.BtnConfirmarVentanilla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnConfirmarCompra)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_VolverMenu)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form_RegistroVentanillas"
        Me.Text = "Registro de ventanillas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_VolverMenu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents ComboBoxDestino As ComboBox
    Friend WithEvents ComboBoxNumeroDeAsiento As ComboBox
    Friend WithEvents TextBoxHoraAtencion As TextBox
    Friend WithEvents TextBoxPrecioTiquete As TextBox
    Friend WithEvents TextBoxNombrePasajero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBoxNumeroDePasaporte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxNumVentanilla As TextBox
    Friend WithEvents TextBoxEscala As TextBox
    Friend WithEvents TextBoxHoraLlegada As TextBox
    Friend WithEvents TextBoxOrigen As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnConfirmarCompra As Button
    Friend WithEvents TextBoxFechaSalida As TextBox
    Friend WithEvents TextBoxHoraSalida As TextBox
    Friend WithEvents TextBoxDestino As TextBox
    Friend WithEvents BtnConfirmarVentanilla As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxLinea_Aereas As ComboBox
    Friend WithEvents TextBoxHoraApertura As TextBox
    Friend WithEvents TextBoxCedula_Empl As TextBox
    Friend WithEvents TextBoxNombre_Emple As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxID_Ventanilla As ComboBox
End Class
