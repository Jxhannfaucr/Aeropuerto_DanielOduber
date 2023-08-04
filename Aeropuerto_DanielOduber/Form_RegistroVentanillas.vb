Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Text

Public Class Form_RegistroVentanillas
    Public conect As Conexion_BD = New Conexion_BD
    Dim datosVuelosPorVentanilla As DataTable = New DataTable

    Private Sub Form_RegistroVentanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxPasajero.Enabled = False ' se activara el group box de pasajeros hasta que los datos de ventanilla se guarden correctamente
        BtnConfirmarVentanilla.Enabled = False
        conect.Conectar()
        LabelConexion.Visible = True
        conect.Cerrar()

    End Sub

    Private Sub VerificarCampos()
        If Not String.IsNullOrEmpty(TextBoxNombrePasajero.Text) AndAlso
       Not String.IsNullOrEmpty(TextBoxNacionalidad.Text) AndAlso
       Not String.IsNullOrEmpty(TextBoxNumeroDePasaporte.Text) AndAlso
       ComboBoxDestino.SelectedIndex >= 0 AndAlso
       Not String.IsNullOrEmpty(ComboBoxNumeroDeAsiento.Text) Then
            ' Todos los campos tienen contenido, habilitar el botón
            BtnConfirmarCompra.Enabled = True
        Else
            ' Al menos un campo está vacío, deshabilitar el botón
            BtnConfirmarCompra.Enabled = False
        End If
    End Sub


    Private Sub TextBoxNombrePasajero_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombrePasajero.TextChanged
        VerificarCampos()
    End Sub

    Private Sub TextBoxNacionalidad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNacionalidad.TextChanged
        VerificarCampos()
    End Sub

    Private Sub TextBoxNumeroDePasaporte_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumeroDePasaporte.TextChanged
        VerificarCampos()
    End Sub
    Public Class Vuelo
        Public Property Origen As String
        Public Property HoraSalida As String
        Public Property HoraLlegada As String
        Public Property Escala As String
        Public Property Precio As SqlMoney
    End Class

    Private Sub ComboBoxDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDestino.SelectedIndexChanged
        VerificarCampos()
        ''guardo el indice del destino
        Dim destinoSeleccionado As Integer = ComboBoxDestino.SelectedIndex

        ''busco los datos de ese destino en la dataTable''
        If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < datosVuelosPorVentanilla.Rows.Count Then
            Dim filaSeleccionada As DataRow = datosVuelosPorVentanilla.Rows(destinoSeleccionado)

            ''Guardo los datos que se necesitan''
            Dim IDVuelo% = Integer.Parse(filaSeleccionada("IDVuelo"))
            Dim origen$ = filaSeleccionada("Origen").ToString()
            Dim Destino$ = filaSeleccionada("Destino").ToString()
            Dim HoraSalida$ = filaSeleccionada("HoraSalida").ToString()
            Dim HoraLlegada$ = filaSeleccionada("HoraLlegada").ToString()
            Dim NumeroVentanilla$ = filaSeleccionada("NumeroVentanilla").ToString()
            Dim Escala$ = filaSeleccionada("Escala").ToString()
            Dim Precio As SqlMoney = filaSeleccionada("Precio").ToString()
            Dim FechaSalida$ = filaSeleccionada("fechaSalida").ToString()

            ''Se muestras los datos''
            TextBoxPrecioTiquete.Text = Precio
            TextBoxFechaSalida.Text = FechaSalida
            ''datos para mostrar en el groupbox de Vuelo
            TextBoxOrigen.Text = origen
            TextBoxDestino.Text = Destino
            TextBoxHoraSalida.Text = HoraSalida
            TextBoxHoraLlegada.Text = HoraLlegada
            TextBoxNumVentanilla.Text = NumeroVentanilla
            TextBoxEscala.Text = Escala
        End If

        ''if para que el usuario baja en escala o no''
        If Not TextBoxEscala.Text.Equals("none") Then
            escalaSi.Checked = False
            escalaNo.Checked = False
            escalaSi.Enabled = True
            escalaNo.Enabled = True

        Else
            escalaSi.Checked = False
            escalaNo.Checked = False
            escalaSi.Enabled = False
            escalaNo.Enabled = False
        End If

    End Sub

    Private Sub ComboBoxNumeroDeAsiento_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNumeroDeAsiento.TextChanged
        VerificarCampos()
    End Sub

    Private Sub btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles btn_VolverMenu.Click
        Form_Menu.Show()
        Me.Close()
    End Sub

    Private Sub BtnConfirmarCompra_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub limpiarCuadros()
        TextBoxNombrePasajero.Clear()
        TextBoxNacionalidad.Clear()
        TextBoxPrecioTiquete.Clear()
        TextBoxFechaSalida.Clear()
        TextBoxNumeroDePasaporte.Clear()
        'falta destino combo box
        'falta escala
        'falta numero de asiento
        TextBoxOrigen.Clear()
        TextBoxDestino.Clear()
        TextBoxHoraSalida.Clear()
        TextBoxHoraLlegada.Clear()
        TextBoxNumVentanilla.Clear()
        TextBoxEscala.Clear()
    End Sub


    'Parte de ventanillas 
    Private Sub VerificarCamposRellenados()
        If Not String.IsNullOrEmpty(TextBoxCedula_Empl.Text) AndAlso Not String.IsNullOrEmpty(TextBoxNombre_Emple.Text) AndAlso
        Not String.IsNullOrEmpty(ComboBoxID_Ventanilla.Text) AndAlso Not String.IsNullOrEmpty(ComboBoxLinea_Aereas.Text) Then
            BtnConfirmarVentanilla.Enabled = True
        Else
            BtnConfirmarVentanilla.Enabled = False
        End If
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre_Emple.TextChanged, TextBoxCedula_Empl.TextChanged
        VerificarCamposRellenados()
    End Sub
    Private Sub ComboBoxID_Ventanilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxID_Ventanilla.SelectedIndexChanged
        Try
            VerificarCamposRellenados()
            If ComboBoxID_Ventanilla.SelectedItem = 1 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 1"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea



            ElseIf ComboBoxID_Ventanilla.SelectedItem = 2 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 2"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea

            ElseIf ComboBoxID_Ventanilla.SelectedItem = 3 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 3"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea


            ElseIf ComboBoxID_Ventanilla.SelectedItem = 4 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 4"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnConfirmarVentanilla_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        Dim ventanilla As Integer = Integer.Parse(ComboBoxID_Ventanilla.SelectedItem.ToString)
        If IsNumeric(ComboBoxID_Ventanilla.SelectedItem) AndAlso
   IsNumeric(TextBoxCedula_Empl.Text) AndAlso
   TextBoxNombre_Emple.Text.All(Function(c) Char.IsLetter(c)) AndAlso
   ComboBoxLinea_Aereas.SelectedItem IsNot Nothing AndAlso
   ComboBoxLinea_Aereas.SelectedItem.ToString().All(Function(c) Char.IsLetter(c)) AndAlso ventanilla < 5 Then

            ''se insertan los datos a ventanilla''
            Try
                ''se guarda la hora del proceso''
                Dim horaActual As DateTime = DateTime.Now
                Dim horaMinutos As String = horaActual.ToString("HH:mm")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''se guardan los demas datos''
                Dim insertar As String = "insert into Ventanillas (NumeroVentanilla, Nombre_empleado, Cedula_Empleado, Hora_Apertura,Linea_aerea) values (@NumeroVentanilla, @Nombre_empleado, @Cedula_Empleado, @Hora_Apertura,@Linea_aerea)"
                Dim cmd As SqlCommand = New SqlCommand(insertar, conect.Conectar())
                cmd.Parameters.AddWithValue("@NumeroVentanilla", ComboBoxID_Ventanilla.Text)
                cmd.Parameters.AddWithValue("@Nombre_empleado", TextBoxNombre_Emple.Text)
                cmd.Parameters.AddWithValue("@Cedula_Empleado", TextBoxCedula_Empl.Text)
                cmd.Parameters.AddWithValue("@Hora_Apertura", horaMinutos)
                cmd.Parameters.AddWithValue("@Linea_aerea", ComboBoxLinea_Aereas.Text)
                cmd.ExecuteNonQuery()
                conect.Cerrar()
                MessageBox.Show("Los datos de ventanilla fueron agregados exitosamente")
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try


            '' en esta parte se habilta el proceso de venta de vuelo''
            ''se llena la datatable con los vuelos disponibles con la ventanilla que se selecciono'''
            GroupBoxPasajero.Enabled = True ' activo el group box de pasajero 
            ''if para saber que ventanilla se eligio, y llenar la datatable''

            ''ventanilla 1''
            If ComboBoxID_Ventanilla.SelectedItem = 1 Then
                datosVuelosPorVentanilla.Reset()
                GroupBox1.Enabled = False ' apago el group box de ventanilla para que no se puedan realizar cambios
                BtnConfirmarVentanilla.Enabled = False 'apago el boton de confimar porque si no se podrian guardar los mismos datos una y otra vez
                Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 1"
                Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                da.Fill(datosVuelosPorVentanilla)
                conect.Cerrar()
                ComboBoxDestino.Items.Clear()

                For Each row As DataRow In datosVuelosPorVentanilla.Rows
                    ComboBoxDestino.Items.Add(row("Destino"))
                Next
                conect.Cerrar()

                ''ventanilla 2''
            ElseIf ComboBoxID_Ventanilla.SelectedItem = 2 Then
                datosVuelosPorVentanilla.Reset()
                GroupBox1.Enabled = False ' apago el group box de ventanilla para que no se puedan realizar cambios
                BtnConfirmarVentanilla.Enabled = False 'apago el boton de confimar porque si no se podrian guardar los mismos datos una y otra vez
                Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 2"
                Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                da.Fill(datosVuelosPorVentanilla)
                conect.Cerrar()
                ComboBoxDestino.Items.Clear()

                For Each row As DataRow In datosVuelosPorVentanilla.Rows
                    ComboBoxDestino.Items.Add(row("Destino"))
                Next
                conect.Cerrar()

                ''ventanilla 3''
            ElseIf ComboBoxID_Ventanilla.SelectedItem = 3 Then
                datosVuelosPorVentanilla.Reset()
                GroupBox1.Enabled = False ' apago el group box de ventanilla para que no se puedan realizar cambios
                BtnConfirmarVentanilla.Enabled = False 'apago el boton de confimar porque si no se podrian guardar los mismos datos una y otra vez
                Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 3"
                Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                da.Fill(datosVuelosPorVentanilla)
                conect.Cerrar()
                ComboBoxDestino.Items.Clear()

                For Each row As DataRow In datosVuelosPorVentanilla.Rows
                    ComboBoxDestino.Items.Add(row("Destino"))
                Next
                conect.Cerrar()

                ''ventanilla 4''
            ElseIf ComboBoxID_Ventanilla.SelectedItem = 4 Then
                datosVuelosPorVentanilla.Reset()
                GroupBox1.Enabled = False ' apago el group box de ventanilla para que no se puedan realizar cambios
                BtnConfirmarVentanilla.Enabled = False 'apago el boton de confimar porque si no se podrian guardar los mismos datos una y otra vez
                Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 4"
                Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                da.Fill(datosVuelosPorVentanilla)
                conect.Cerrar()
                ComboBoxDestino.Items.Clear()

                For Each row As DataRow In datosVuelosPorVentanilla.Rows
                    ComboBoxDestino.Items.Add(row("Destino"))
                Next
                conect.Cerrar()
            End If


            'if comprobacion ventanilla
            'select destino tblvuelo donde ventanilla sea 1 

        Else
            MessageBox.Show("Ha ocurrido un error. Datos Inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

End Class