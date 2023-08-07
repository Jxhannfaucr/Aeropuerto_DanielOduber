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
        Me.components = New System.ComponentModel.Container()
        Me.btn_VolverMenu = New System.Windows.Forms.Button()
        Me.GroupBoxPasajero = New System.Windows.Forms.GroupBox()
        Me.ComboBoxNumeroDeAsiento = New System.Windows.Forms.NumericUpDown()
        Me.BtnConfirmarCompra = New System.Windows.Forms.Button()
        Me.escalaNo = New System.Windows.Forms.RadioButton()
        Me.escalaSi = New System.Windows.Forms.RadioButton()
        Me.TextBoxFechaSalida = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxNumeroDePasaporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNacionalidad = New System.Windows.Forms.TextBox()
        Me.ComboBoxDestino = New System.Windows.Forms.ComboBox()
        Me.TextBoxPrecioTiquete = New System.Windows.Forms.TextBox()
        Me.TextBoxNombrePasajero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBoxOrigen = New System.Windows.Forms.GroupBox()
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
        Me.BtnConfirmarVentanilla = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimeVentanilla = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxLinea_Aereas = New System.Windows.Forms.ComboBox()
        Me.TextBoxCedula_Empl = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre_Emple = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxID_Ventanilla = New System.Windows.Forms.ComboBox()
        Me.LabelConexion = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxPasajero.SuspendLayout()
        CType(Me.ComboBoxNumeroDeAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOrigen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_VolverMenu
        '
        Me.btn_VolverMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_VolverMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VolverMenu.Location = New System.Drawing.Point(880, 20)
        Me.btn_VolverMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_VolverMenu.Name = "btn_VolverMenu"
        Me.btn_VolverMenu.Size = New System.Drawing.Size(90, 24)
        Me.btn_VolverMenu.TabIndex = 9
        Me.btn_VolverMenu.Text = "Menu"
        Me.btn_VolverMenu.UseVisualStyleBackColor = False
        '
        'GroupBoxPasajero
        '
        Me.GroupBoxPasajero.Controls.Add(Me.ComboBoxNumeroDeAsiento)
        Me.GroupBoxPasajero.Controls.Add(Me.BtnConfirmarCompra)
        Me.GroupBoxPasajero.Controls.Add(Me.escalaNo)
        Me.GroupBoxPasajero.Controls.Add(Me.escalaSi)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxFechaSalida)
        Me.GroupBoxPasajero.Controls.Add(Me.Label21)
        Me.GroupBoxPasajero.Controls.Add(Me.Label20)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxNumeroDePasaporte)
        Me.GroupBoxPasajero.Controls.Add(Me.Label6)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxNacionalidad)
        Me.GroupBoxPasajero.Controls.Add(Me.ComboBoxDestino)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxPrecioTiquete)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxNombrePasajero)
        Me.GroupBoxPasajero.Controls.Add(Me.Label7)
        Me.GroupBoxPasajero.Controls.Add(Me.Label9)
        Me.GroupBoxPasajero.Controls.Add(Me.Label10)
        Me.GroupBoxPasajero.Controls.Add(Me.Label11)
        Me.GroupBoxPasajero.Controls.Add(Me.Label12)
        Me.GroupBoxPasajero.Location = New System.Drawing.Point(352, 47)
        Me.GroupBoxPasajero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxPasajero.Name = "GroupBoxPasajero"
        Me.GroupBoxPasajero.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxPasajero.Size = New System.Drawing.Size(297, 352)
        Me.GroupBoxPasajero.TabIndex = 23
        Me.GroupBoxPasajero.TabStop = False
        Me.GroupBoxPasajero.Text = "Pasajero"
        '
        'ComboBoxNumeroDeAsiento
        '
        Me.ComboBoxNumeroDeAsiento.Location = New System.Drawing.Point(187, 263)
        Me.ComboBoxNumeroDeAsiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxNumeroDeAsiento.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.ComboBoxNumeroDeAsiento.Name = "ComboBoxNumeroDeAsiento"
        Me.ComboBoxNumeroDeAsiento.Size = New System.Drawing.Size(90, 20)
        Me.ComboBoxNumeroDeAsiento.TabIndex = 33
        Me.ComboBoxNumeroDeAsiento.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnConfirmarCompra
        '
        Me.BtnConfirmarCompra.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnConfirmarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConfirmarCompra.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnConfirmarCompra.Location = New System.Drawing.Point(88, 310)
        Me.BtnConfirmarCompra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnConfirmarCompra.Name = "BtnConfirmarCompra"
        Me.BtnConfirmarCompra.Size = New System.Drawing.Size(125, 30)
        Me.BtnConfirmarCompra.TabIndex = 31
        Me.BtnConfirmarCompra.Text = "Confirmar vuelo"
        Me.BtnConfirmarCompra.UseVisualStyleBackColor = False
        '
        'escalaNo
        '
        Me.escalaNo.AutoSize = True
        Me.escalaNo.Enabled = False
        Me.escalaNo.Location = New System.Drawing.Point(208, 238)
        Me.escalaNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.escalaNo.Name = "escalaNo"
        Me.escalaNo.Size = New System.Drawing.Size(41, 17)
        Me.escalaNo.TabIndex = 32
        Me.escalaNo.Text = "NO"
        Me.ToolTip1.SetToolTip(Me.escalaNo, "NO se baja en la escala")
        Me.escalaNo.UseVisualStyleBackColor = True
        '
        'escalaSi
        '
        Me.escalaSi.AutoSize = True
        Me.escalaSi.Enabled = False
        Me.escalaSi.Location = New System.Drawing.Point(162, 238)
        Me.escalaSi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.escalaSi.Name = "escalaSi"
        Me.escalaSi.Size = New System.Drawing.Size(35, 17)
        Me.escalaSi.TabIndex = 31
        Me.escalaSi.Text = "SI"
        Me.ToolTip1.SetToolTip(Me.escalaSi, "SI se baja en la escala")
        Me.escalaSi.UseVisualStyleBackColor = True
        '
        'TextBoxFechaSalida
        '
        Me.TextBoxFechaSalida.Location = New System.Drawing.Point(150, 164)
        Me.TextBoxFechaSalida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxFechaSalida.Name = "TextBoxFechaSalida"
        Me.TextBoxFechaSalida.ReadOnly = True
        Me.TextBoxFechaSalida.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxFechaSalida.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(14, 262)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(150, 17)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Numero de asiento:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 238)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 17)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Escala:"
        '
        'TextBoxNumeroDePasaporte
        '
        Me.TextBoxNumeroDePasaporte.Location = New System.Drawing.Point(187, 206)
        Me.TextBoxNumeroDePasaporte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxNumeroDePasaporte.Name = "TextBoxNumeroDePasaporte"
        Me.TextBoxNumeroDePasaporte.Size = New System.Drawing.Size(97, 20)
        Me.TextBoxNumeroDePasaporte.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 206)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Numero de pasaporte:"
        '
        'TextBoxNacionalidad
        '
        Me.TextBoxNacionalidad.Location = New System.Drawing.Point(150, 63)
        Me.TextBoxNacionalidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        Me.TextBoxNacionalidad.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxNacionalidad.TabIndex = 23
        '
        'ComboBoxDestino
        '
        Me.ComboBoxDestino.FormattingEnabled = True
        Me.ComboBoxDestino.Location = New System.Drawing.Point(150, 93)
        Me.ComboBoxDestino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxDestino.Name = "ComboBoxDestino"
        Me.ComboBoxDestino.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxDestino.TabIndex = 22
        '
        'TextBoxPrecioTiquete
        '
        Me.TextBoxPrecioTiquete.Location = New System.Drawing.Point(150, 132)
        Me.TextBoxPrecioTiquete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxPrecioTiquete.Name = "TextBoxPrecioTiquete"
        Me.TextBoxPrecioTiquete.ReadOnly = True
        Me.TextBoxPrecioTiquete.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxPrecioTiquete.TabIndex = 19
        '
        'TextBoxNombrePasajero
        '
        Me.TextBoxNombrePasajero.Location = New System.Drawing.Point(150, 27)
        Me.TextBoxNombrePasajero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxNombrePasajero.Name = "TextBoxNombrePasajero"
        Me.TextBoxNombrePasajero.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxNombrePasajero.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Destino:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 164)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Fecha de salida:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 132)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Precio de tiquete:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 63)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Nacionalidad:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 28)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Nombre:"
        '
        'GroupBoxOrigen
        '
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraSalida)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxDestino)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxNumVentanilla)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxEscala)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraLlegada)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxOrigen)
        Me.GroupBoxOrigen.Controls.Add(Me.Label14)
        Me.GroupBoxOrigen.Controls.Add(Me.Label15)
        Me.GroupBoxOrigen.Controls.Add(Me.Label16)
        Me.GroupBoxOrigen.Controls.Add(Me.Label17)
        Me.GroupBoxOrigen.Controls.Add(Me.Label18)
        Me.GroupBoxOrigen.Controls.Add(Me.Label19)
        Me.GroupBoxOrigen.Location = New System.Drawing.Point(673, 49)
        Me.GroupBoxOrigen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxOrigen.Name = "GroupBoxOrigen"
        Me.GroupBoxOrigen.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxOrigen.Size = New System.Drawing.Size(297, 237)
        Me.GroupBoxOrigen.TabIndex = 26
        Me.GroupBoxOrigen.TabStop = False
        Me.GroupBoxOrigen.Text = "Vuelo"
        '
        'TextBoxHoraSalida
        '
        Me.TextBoxHoraSalida.Location = New System.Drawing.Point(147, 96)
        Me.TextBoxHoraSalida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxHoraSalida.Name = "TextBoxHoraSalida"
        Me.TextBoxHoraSalida.ReadOnly = True
        Me.TextBoxHoraSalida.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxHoraSalida.TabIndex = 29
        '
        'TextBoxDestino
        '
        Me.TextBoxDestino.Location = New System.Drawing.Point(98, 60)
        Me.TextBoxDestino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxDestino.Name = "TextBoxDestino"
        Me.TextBoxDestino.ReadOnly = True
        Me.TextBoxDestino.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxDestino.TabIndex = 28
        '
        'TextBoxNumVentanilla
        '
        Me.TextBoxNumVentanilla.Location = New System.Drawing.Point(179, 165)
        Me.TextBoxNumVentanilla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxNumVentanilla.Name = "TextBoxNumVentanilla"
        Me.TextBoxNumVentanilla.ReadOnly = True
        Me.TextBoxNumVentanilla.Size = New System.Drawing.Size(90, 20)
        Me.TextBoxNumVentanilla.TabIndex = 27
        '
        'TextBoxEscala
        '
        Me.TextBoxEscala.Location = New System.Drawing.Point(77, 193)
        Me.TextBoxEscala.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxEscala.Name = "TextBoxEscala"
        Me.TextBoxEscala.ReadOnly = True
        Me.TextBoxEscala.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxEscala.TabIndex = 20
        '
        'TextBoxHoraLlegada
        '
        Me.TextBoxHoraLlegada.Location = New System.Drawing.Point(147, 132)
        Me.TextBoxHoraLlegada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxHoraLlegada.Name = "TextBoxHoraLlegada"
        Me.TextBoxHoraLlegada.ReadOnly = True
        Me.TextBoxHoraLlegada.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxHoraLlegada.TabIndex = 19
        '
        'TextBoxOrigen
        '
        Me.TextBoxOrigen.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxOrigen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxOrigen.Name = "TextBoxOrigen"
        Me.TextBoxOrigen.ReadOnly = True
        Me.TextBoxOrigen.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxOrigen.TabIndex = 18
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
        'BtnConfirmarVentanilla
        '
        Me.BtnConfirmarVentanilla.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnConfirmarVentanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConfirmarVentanilla.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarVentanilla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnConfirmarVentanilla.Location = New System.Drawing.Point(110, 287)
        Me.BtnConfirmarVentanilla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnConfirmarVentanilla.Name = "BtnConfirmarVentanilla"
        Me.BtnConfirmarVentanilla.Size = New System.Drawing.Size(82, 30)
        Me.BtnConfirmarVentanilla.TabIndex = 29
        Me.BtnConfirmarVentanilla.Text = "Confirmar"
        Me.BtnConfirmarVentanilla.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimeVentanilla)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxLinea_Aereas)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmarVentanilla)
        Me.GroupBox1.Controls.Add(Me.TextBoxCedula_Empl)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre_Emple)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxID_Ventanilla)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 340)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de ventanillas"
        '
        'DateTimeVentanilla
        '
        Me.DateTimeVentanilla.Location = New System.Drawing.Point(122, 221)
        Me.DateTimeVentanilla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimeVentanilla.Name = "DateTimeVentanilla"
        Me.DateTimeVentanilla.Size = New System.Drawing.Size(151, 20)
        Me.DateTimeVentanilla.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Fecha:"
        '
        'ComboBoxLinea_Aereas
        '
        Me.ComboBoxLinea_Aereas.FormattingEnabled = True
        Me.ComboBoxLinea_Aereas.Location = New System.Drawing.Point(182, 179)
        Me.ComboBoxLinea_Aereas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxLinea_Aereas.Name = "ComboBoxLinea_Aereas"
        Me.ComboBoxLinea_Aereas.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxLinea_Aereas.TabIndex = 21
        '
        'TextBoxCedula_Empl
        '
        Me.TextBoxCedula_Empl.Location = New System.Drawing.Point(182, 133)
        Me.TextBoxCedula_Empl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxCedula_Empl.Name = "TextBoxCedula_Empl"
        Me.TextBoxCedula_Empl.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxCedula_Empl.TabIndex = 19
        '
        'TextBoxNombre_Emple
        '
        Me.TextBoxNombre_Emple.Location = New System.Drawing.Point(182, 89)
        Me.TextBoxNombre_Emple.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxNombre_Emple.Name = "TextBoxNombre_Emple"
        Me.TextBoxNombre_Emple.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxNombre_Emple.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 182)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Linea Aérea:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cédula Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese la ventanilla:"
        '
        'ComboBoxID_Ventanilla
        '
        Me.ComboBoxID_Ventanilla.FormattingEnabled = True
        Me.ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxID_Ventanilla.Location = New System.Drawing.Point(182, 38)
        Me.ComboBoxID_Ventanilla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        Me.ComboBoxID_Ventanilla.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxID_Ventanilla.TabIndex = 11
        '
        'LabelConexion
        '
        Me.LabelConexion.AutoSize = True
        Me.LabelConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConexion.Location = New System.Drawing.Point(35, 401)
        Me.LabelConexion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConexion.Name = "LabelConexion"
        Me.LabelConexion.Size = New System.Drawing.Size(214, 13)
        Me.LabelConexion.TabIndex = 30
        Me.LabelConexion.Text = "Conexion realizada con el servidor..."
        Me.LabelConexion.Visible = False
        '
        'Form_RegistroVentanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(994, 431)
        Me.Controls.Add(Me.LabelConexion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxOrigen)
        Me.Controls.Add(Me.GroupBoxPasajero)
        Me.Controls.Add(Me.btn_VolverMenu)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_RegistroVentanillas"
        Me.Text = "Registro de ventanillas"
        Me.GroupBoxPasajero.ResumeLayout(False)
        Me.GroupBoxPasajero.PerformLayout()
        CType(Me.ComboBoxNumeroDeAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOrigen.ResumeLayout(False)
        Me.GroupBoxOrigen.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_VolverMenu As Button
    Friend WithEvents GroupBoxPasajero As GroupBox
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents ComboBoxDestino As ComboBox
    Friend WithEvents TextBoxPrecioTiquete As TextBox
    Friend WithEvents TextBoxNombrePasajero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxNumeroDePasaporte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBoxOrigen As GroupBox
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
    Friend WithEvents TextBoxFechaSalida As TextBox
    Friend WithEvents TextBoxHoraSalida As TextBox
    Friend WithEvents TextBoxDestino As TextBox
    Friend WithEvents BtnConfirmarVentanilla As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxLinea_Aereas As ComboBox
    Friend WithEvents TextBoxCedula_Empl As TextBox
    Friend WithEvents TextBoxNombre_Emple As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxID_Ventanilla As ComboBox
    Friend WithEvents LabelConexion As Label
    Friend WithEvents escalaNo As RadioButton
    Friend WithEvents escalaSi As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnConfirmarCompra As Button
    Friend WithEvents ComboBoxNumeroDeAsiento As NumericUpDown
    Friend WithEvents DateTimeVentanilla As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
