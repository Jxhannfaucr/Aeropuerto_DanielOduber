﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Text

Public Class Form_Ventanilla1
    Public conect As Conexion_BD = New Conexion_BD
    Dim datosVuelosPorVentanilla As DataTable = New DataTable

    Private Sub Form_RegistroVentanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxPasajero.Enabled = False ' se activara el group box de pasajeros hasta que los datos de ventanilla se guarden correctamente
        BtnConfirmarVentanilla.Enabled = False
        conect.Conectar()
        LabelConexion.Visible = True
        conect.Cerrar()
        BtnConfirmarCompra.Enabled = False

        'Cargar aerolineas'
        Try
            VerificarCamposRellenadosVentanilla()
            If ComboBoxID_Ventanilla.Text = 1 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 1"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea
                PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\UACA\5 cuatrimestre\Progra 3\Proyecto final\Aeropuerto_DanielOduber\Aeropuerto_DanielOduber\Logos Aerolineas\THUMB-aa_aa__ahz_4cp_grd_pos-(1).png")


            ElseIf ComboBoxID_Ventanilla.Text = 2 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 2"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea
                PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\UACA\5 cuatrimestre\Progra 3\Proyecto final\Aeropuerto_DanielOduber\Aeropuerto_DanielOduber\Logos Aerolineas\British-Airways-Logo.png")
            ElseIf ComboBoxID_Ventanilla.Text = 3 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 3"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea
                PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\UACA\5 cuatrimestre\Progra 3\Proyecto final\Aeropuerto_DanielOduber\Aeropuerto_DanielOduber\Logos Aerolineas\Emirates-Logo.png")

            ElseIf ComboBoxID_Ventanilla.Text = 4 Then
                ComboBoxLinea_Aereas.Items.Clear()
                Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 4"
                Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
                conect.Cerrar()
                ComboBoxLinea_Aereas.Items.Add(lineaAerea)
                ComboBoxLinea_Aereas.SelectedItem = lineaAerea
                PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\UACA\5 cuatrimestre\Progra 3\Proyecto final\Aeropuerto_DanielOduber\Aeropuerto_DanielOduber\Logos Aerolineas\61586b0b258f1e000415490d.png")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub ComboBoxDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDestino.SelectedIndexChanged
        ListBoxNumeroDeAsiento.Items.Clear()
        ''guardo el indice del destino
        Dim destinoSeleccionado As Integer = ComboBoxDestino.SelectedIndex
        Dim IDVuelo%
        ''busco los datos de ese destino en la dataTable''
        If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < datosVuelosPorVentanilla.Rows.Count Then
            Dim filaSeleccionada As DataRow = datosVuelosPorVentanilla.Rows(destinoSeleccionado)

            ''Guardo los datos que se necesitan''
            IDVuelo = Integer.Parse(filaSeleccionada("IDVuelo"))
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
            escalaNo.Checked = True
            escalaSi.Enabled = True
            escalaNo.Enabled = True

        Else
            escalaSi.Checked = False
            escalaNo.Checked = False
            escalaSi.Enabled = False
            escalaNo.Enabled = False
        End If

        ''CONSULTA LA LISTA DE NUMEROS DE ASIENTOS''
        Dim asientosDisponibles As New List(Of Integer)()
        Dim consulta As String = "select NumAsiento from TblPasajero
                                    where ID_Vuelo = @CodigoVuelo
                                    order by NumAsiento asc"
        Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
        cmd.Parameters.AddWithValue("@CodigoVuelo", IDVuelo)
        Dim disponible As Integer
        disponible = CInt(cmd.ExecuteScalar())
        ''LOS AGREGA A UNA LISTA''
        Try
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim numAsiento As Integer = CInt(reader("NumAsiento"))
                ''AGREGA A LISTA''
                asientosDisponibles.Add(numAsiento)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conect.Cerrar()
        End Try

        ''RECORRE LA LISTA PARA AGREGAR AL COMBOBOX LOS ASIENTOS DISPONIBLES''
        For i As Integer = 1 To 200
            ''SI EL NUMERO NO ESTA EN LA LISTA, LO AGREGA''
            If Not asientosDisponibles.Contains(i) Then
                ListBoxNumeroDeAsiento.Items.Add(i)
            End If
        Next

    End Sub

    Private Sub btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles btn_VolverMenu.Click
        Dim confirmar As DialogResult = MessageBox.Show("¿Desea cerrar la ventanilla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmar = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub BtnConfirmarCompra_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub limpiarCuadros()
        TextBoxNombrePasajero.Clear()
        TextBoxNacionalidad.Clear()
        TextBoxPrecioTiquete.Clear()
        TextBoxFechaSalida.Clear()
        TextBoxNumeroDePasaporte.Clear()
        ComboBoxDestino.Text = ""
        'falta escala
        'falta numero de asiento
        TextBoxOrigen.Clear()
        TextBoxDestino.Clear()
        TextBoxHoraSalida.Clear()
        TextBoxHoraLlegada.Clear()
        TextBoxNumVentanilla.Clear()
        TextBoxEscala.Clear()
        ListBoxNumeroDeAsiento.Items.Clear()
        ListBoxNumeroDeAsiento.Text = ""
    End Sub

    Private Sub verificarCompra()
        If Not String.IsNullOrEmpty(TextBoxNombrePasajero.Text) AndAlso Not String.IsNullOrEmpty(TextBoxNacionalidad.Text) AndAlso
            Not String.IsNullOrEmpty(TextBoxNumeroDePasaporte.Text) AndAlso
            Not String.IsNullOrEmpty(ListBoxNumeroDeAsiento.Text) Then
            BtnConfirmarCompra.Enabled = True
        Else
            BtnConfirmarCompra.Enabled = False
        End If
    End Sub
    'Parte de ventanillas 
    Private Sub VerificarCamposRellenadosVentanilla()
        If Not String.IsNullOrEmpty(TextBoxCedula_Empl.Text) AndAlso Not String.IsNullOrEmpty(TextBoxNombre_Emple.Text) AndAlso
        Not String.IsNullOrEmpty(ComboBoxID_Ventanilla.Text) AndAlso Not String.IsNullOrEmpty(ComboBoxLinea_Aereas.Text) Then
            BtnConfirmarVentanilla.Enabled = True
        Else
            BtnConfirmarVentanilla.Enabled = True
        End If
    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre_Emple.TextChanged, TextBoxCedula_Empl.TextChanged
        VerificarCamposRellenadosVentanilla()
    End Sub

    Private Sub BtnConfirmarVentanilla_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        Dim ventanilla As Integer = Integer.Parse(ComboBoxID_Ventanilla.Text)
        If Not TextBoxNombre_Emple.Text = "" AndAlso Not TextBoxCedula_Empl.Text = "" AndAlso
            Not ComboBoxID_Ventanilla.Text = "" AndAlso Not ComboBoxLinea_Aereas.SelectedItem = "" Then

            ''se insertan los datos a ventanilla''
            Try
                ''se guarda la hora del proceso''
                Dim horaActual As DateTime = DateTime.Now
                Dim horaMinutos As String = horaActual.ToString("HH:mm")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'se guardan los demas datos''
                Dim insertar As String = "insert into Ventanillas (NumeroVentanilla, Nombre_empleado, Cedula_Empleado, Hora_Apertura, Linea_aerea, Fecha) values (@NumeroVentanilla, @Nombre_empleado, @Cedula_Empleado, @Hora_Apertura,@Linea_aerea, @Fecha)"
                Dim cmd As SqlCommand = New SqlCommand(insertar, conect.Conectar())
                cmd.Parameters.AddWithValue("@NumeroVentanilla", ComboBoxID_Ventanilla.Text)
                cmd.Parameters.AddWithValue("@Nombre_empleado", TextBoxNombre_Emple.Text)
                cmd.Parameters.AddWithValue("@Cedula_Empleado", TextBoxCedula_Empl.Text)
                cmd.Parameters.AddWithValue("@Hora_Apertura", horaMinutos)
                cmd.Parameters.AddWithValue("@Linea_aerea", ComboBoxLinea_Aereas.Text)
                cmd.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)
                cmd.ExecuteNonQuery()
                conect.Cerrar()
                MessageBox.Show("Los datos de ventanilla fueron agregados exitosamente")
                'BtnNuevaVentanilla.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error al manejar la entrada del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            '' en esta parte se habilta el proceso de venta de vuelo''
            ''se llena la datatable con los vuelos disponibles con la ventanilla que se selecciono'''
            GroupBoxPasajero.Enabled = True ' activo el group box de pasajero 
            ''if para saber que ventanilla se eligio, y llenar la datatable''

            ''ventanilla 1''
            If ComboBoxID_Ventanilla.Text = 1 Then
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
            ElseIf ComboBoxID_Ventanilla.Text = 2 Then
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
            ElseIf ComboBoxID_Ventanilla.Text = 3 Then
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
            ElseIf ComboBoxID_Ventanilla.Text = 4 Then
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

            ButtonBorrarP.Enabled = True

        Else
            MessageBox.Show("Ha ocurrido un error. Datos Inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub




    Private Sub BtnConfirmarCompra_Click_1(sender As Object, e As EventArgs) Handles BtnConfirmarCompra.Click
        If Not TextBoxNombrePasajero.Text = "" AndAlso Not TextBoxNacionalidad.Text = "" AndAlso
           Not ComboBoxDestino.SelectedItem = "" AndAlso Not TextBoxNumeroDePasaporte.Text = "" AndAlso Not ListBoxNumeroDeAsiento.Text = "" Then
            If ListBoxNumeroDeAsiento.Text <= 200 AndAlso ListBoxNumeroDeAsiento.Text > 0 Then
                Dim confirmar As DialogResult = MessageBox.Show("¿Está seguro de que desea el asiento " & ListBoxNumeroDeAsiento.Text.ToString() & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmar = DialogResult.Yes Then
                    ''controlador para saber si se baja en escala o no
                    Dim pasajeroEscala As Integer = 0

                    ''verificar el numero de asientoo'''
                    Dim numeroAsientoSolicitado$
                    numeroAsientoSolicitado = ListBoxNumeroDeAsiento.Text
                    ''se hace la consulta a la base de datos si esta disponible''
                    ''solicito el codigo del destino''
                    Dim destinoSeleccionado As Integer = ComboBoxDestino.SelectedIndex
                    Dim IDVuelo%
                    If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < datosVuelosPorVentanilla.Rows.Count Then
                        Dim filaSeleccionada As DataRow = datosVuelosPorVentanilla.Rows(destinoSeleccionado)
                        ''Guardo el codigo del vuelo''
                        IDVuelo = Integer.Parse(filaSeleccionada("IDVuelo"))
                    End If

                    ''CONSULTA SI ESTA DISPONIBLE EL ASIENTO''
                    Dim consulta As String = "SELECT COUNT(*) AS ocupado FROM TblPasajero WHERE ID_Vuelo = @CodigoVuelo AND NumAsiento = @NumeroAsiento"
                    Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                    cmd.Parameters.AddWithValue("@CodigoVuelo", IDVuelo)
                    cmd.Parameters.AddWithValue("@NumeroAsiento", numeroAsientoSolicitado)
                    ''me devuelve un 0 si esta disponible o un 1 si esta ocupado
                    Dim disponible As Integer
                    disponible = CInt(cmd.ExecuteScalar())
                    conect.Cerrar()

                    ''CONSULTA DEL ULTIMO PROCESO REALIDADO''
                    Dim consulta2 As String = "select top 1 Id_Proceso from Ventanillas where NumeroVentanilla = @Ventanilla order by Id_Proceso desc"
                    Dim cmd2 As SqlCommand = New SqlCommand(consulta2, conect.Conectar())
                    cmd2.Parameters.AddWithValue("@Ventanilla", ComboBoxID_Ventanilla.Text)
                    Dim idProceso As Integer
                    idProceso = CInt(cmd2.ExecuteScalar())
                    conect.Cerrar()

                    ''verifico lo de la escala''
                    If escalaNo.Enabled = False AndAlso escalaSi.Enabled = False Then
                        pasajeroEscala = 0

                    ElseIf escalaSi.Checked = True Then
                        pasajeroEscala = 1

                    ElseIf escalaNo.Checked = True Then
                        pasajeroEscala = 0
                    End If


                    If disponible = 0 Then
                        ''se insertan los datos de pasajaero''
                        Try
                            ''se guarda la hora del proceso''
                            Dim horaActual As DateTime = DateTime.Now
                            Dim horaMinutos As String = horaActual.ToString("HH:mm")
                            '''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            ''se guardan los demas datos''
                            Dim destinoViaje As String = ComboBoxDestino.SelectedItem.ToString
                            Dim insertar As String = "insert into TblPasajero (Nombre, Nacionalidad, Destino, Precio, HoraAtencion, FechaSalida, NumAsiento, Escala, Pasaporte, ID_Ventanilla, ID_Vuelo) values
                                                                  (@Nombre, @Nacionalidad, @Destino, @Precio, @HoraAtencion, @FechaSalida, @NumAsiento, @Escala, @Pasaporte, @ID_Ventanilla, @ID_Vuelo)"

                            Dim cmdInsert As SqlCommand = New SqlCommand(insertar, conect.Conectar())
                            cmdInsert.Parameters.AddWithValue("@Nombre", TextBoxNombrePasajero.Text)
                            cmdInsert.Parameters.AddWithValue("@Nacionalidad", TextBoxNacionalidad.Text)
                            cmdInsert.Parameters.AddWithValue("@Destino", ComboBoxDestino.SelectedItem.ToString)
                            cmdInsert.Parameters.AddWithValue("@Precio", SqlMoney.Parse(TextBoxPrecioTiquete.Text))
                            cmdInsert.Parameters.AddWithValue("@HoraAtencion", horaMinutos)
                            cmdInsert.Parameters.AddWithValue("@FechaSalida", TextBoxFechaSalida.Text)
                            cmdInsert.Parameters.AddWithValue("@NumAsiento", numeroAsientoSolicitado)
                            cmdInsert.Parameters.AddWithValue("@Escala", pasajeroEscala)
                            cmdInsert.Parameters.AddWithValue("@Pasaporte", TextBoxNumeroDePasaporte.Text)
                            cmdInsert.Parameters.AddWithValue("@ID_Ventanilla", idProceso)
                            cmdInsert.Parameters.AddWithValue("@ID_Vuelo", IDVuelo)
                            cmdInsert.ExecuteNonQuery()
                            conect.Cerrar()
                            MessageBox.Show("La compra ha sido exitosa")
                            limpiarCuadros()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try

                    Else
                        MessageBox.Show("Numero de asiento vendido, ingrese otro")
                    End If
                ElseIf confirmar = DialogResult.No Then


                End If



            Else
                MessageBox.Show("Numero de asiento tiene que ser menor a 200", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else
            MessageBox.Show("Ha ocurrido un error. Datos Inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub VerificarCamposRellenadosPasajeros(sender As Object, e As EventArgs) Handles TextBoxPrecioTiquete.TextChanged

    End Sub

    Private Sub TextBoxCedula_Empl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCedula_Empl.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub ComboBoxID_Ventanilla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxID_Ventanilla.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub TextBoxNombre_Emple_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNombre_Emple.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub ComboBoxLinea_Aereas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxLinea_Aereas.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub TextBoxNombrePasajero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNombrePasajero.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub TextBoxNacionalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNacionalidad.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub TextBoxNumeroDePasaporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumeroDePasaporte.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub ComboBoxNumeroDeAsiento_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub


    Private Sub TextBoxNombrePasajero_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombrePasajero.TextChanged
        verificarCompra()
    End Sub

    Private Sub TextBoxNacionalidad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNacionalidad.TextChanged
        verificarCompra()
    End Sub

    Private Sub TextBoxNumeroDePasaporte_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumeroDePasaporte.TextChanged
        verificarCompra()
    End Sub

    Private Sub ComboBoxLinea_Aereas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLinea_Aereas.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonBorrarP.Click
        Dim borrarP As New Borrar_Pasajero()
        borrarP.TablaVuelos = datosVuelosPorVentanilla
        borrarP.Show()
    End Sub

    Private Sub ListBoxNumeroDeAsiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBoxNumeroDeAsiento.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Cancelar la entrada de caracteres no válidos.
        End If
    End Sub

    Private Sub ListBoxNumeroDeAsiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNumeroDeAsiento.SelectedIndexChanged
        verificarCompra()
    End Sub
End Class