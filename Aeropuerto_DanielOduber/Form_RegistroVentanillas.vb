Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Text

Public Class Form_RegistroVentanillas
    Public conect As Conexion_BD = New Conexion_BD

    Private Sub Form_RegistroVentanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxPasajero.Enabled = False ' se activara el group box de pasajeros hasta que los datos de ventanilla se guarden correctamente
        BtnConfirmarVentanilla.Enabled = False
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
        If ComboBoxDestino.SelectedIndex = 0 Then
            Dim PaisSeleccionado As String = ComboBoxDestino.SelectedItem.ToString()
            Dim query As String = "SELECT Origen, HoraSalida, HoraLlegada, Escala, Precio FROM TblVuelo WHERE Destino = @pais;"
            Using con As SqlConnection = conect.Conectar()
                Dim cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@pais", PaisSeleccionado)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim listaVuelos As New List(Of Vuelo)()

                While reader.Read()
                    Dim vuelo As New Vuelo()
                    vuelo.Origen = reader("Origen").ToString()
                    vuelo.HoraSalida = (reader("HoraSalida"))
                    vuelo.HoraLlegada = (reader("HoraLlegada"))
                    vuelo.Escala = reader("Escala").ToString()
                    vuelo.Precio = Convert.ToDecimal(reader("Precio"))
                    listaVuelos.Add(vuelo)
                End While

                reader.Close()

                ' Llenar TextBox con información de vuelos
                Dim origen As New StringBuilder()
                Dim HoraSalida As New StringBuilder()
                Dim Horallegada As New StringBuilder()
                Dim Escala As New StringBuilder()
                Dim precio As New StringBuilder()


                For Each vuelo As Vuelo In listaVuelos
                    origen.AppendLine(vuelo.Origen)
                    HoraSalida.AppendLine(vuelo.HoraSalida)
                    Horallegada.AppendLine(vuelo.HoraLlegada)
                    Escala.AppendLine(vuelo.Escala)
                    precio.AppendLine(vuelo.Precio)
                Next

                TextBoxOrigen.Text = origen.ToString()
                TextBoxHoraSalida.Text = HoraSalida.ToString()
                TextBoxHoraLlegada.Text = Horallegada.ToString()
                TextBoxEscala.Text = Escala.ToString()
                TextBoxPrecioTiquete.Text = precio.ToString()



            End Using
        End If
    End Sub

    Private Sub ComboBoxNumeroDeAsiento_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNumeroDeAsiento.TextChanged
        VerificarCampos()
    End Sub

    Private Sub btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles btn_VolverMenu.Click
        Form_Menu.Show()
        Me.Close()
    End Sub

    Private Sub BtnConfirmarCompra_Click(sender As Object, e As EventArgs) Handles BtnConfirmarCompra.Click

    End Sub
    Public Sub limpiarCuadros()
        TextBoxNombrePasajero.Clear()
        TextBoxNacionalidad.Clear()
        TextBoxPrecioTiquete.Clear()
        TextBoxFechaSalida.Clear()
        TextBoxHoraAtencion.Clear()
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
        If Not String.IsNullOrEmpty(TextBoxCedula_Empl.Text) AndAlso Not String.IsNullOrEmpty(TextBoxHoraApertura.Text) AndAlso Not String.IsNullOrEmpty(TextBoxNombre_Emple.Text) AndAlso
        Not String.IsNullOrEmpty(ComboBoxID_Ventanilla.Text) AndAlso Not String.IsNullOrEmpty(ComboBoxLinea_Aereas.Text) Then
            BtnConfirmarVentanilla.Enabled = True
        Else
            BtnConfirmarVentanilla.Enabled = False
        End If
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre_Emple.TextChanged, TextBoxCedula_Empl.TextChanged, TextBoxHoraApertura.TextChanged
        VerificarCamposRellenados()
    End Sub
    Private Sub ComboBoxID_Ventanilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxID_Ventanilla.SelectedIndexChanged
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
    End Sub

    Private Sub BtnConfirmarVentanilla_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        Dim insertar As String = "insert into Ventanillas ( NumeroVentanilla, Nombre_empleado, Cedula_Empleado, Hora_Apertura,Linea_aerea) values (@NumeroVentanilla, @Nombre_empleado, @Cedula_Empleado, @Hora_Apertura,@Linea_aerea)"
        Dim cmd As SqlCommand = New SqlCommand(insertar, conect.Conectar())
        Try
            cmd.Parameters.AddWithValue("@NumeroVentanilla", ComboBoxID_Ventanilla.Text)
            cmd.Parameters.AddWithValue("@Nombre_empleado", TextBoxNombre_Emple.Text)
            cmd.Parameters.AddWithValue("@Cedula_Empleado", TextBoxCedula_Empl.Text)
            cmd.Parameters.AddWithValue("@Hora_Apertura", TextBoxHoraApertura.Text)
            cmd.Parameters.AddWithValue("@Linea_aerea", ComboBoxLinea_Aereas.Text)
            cmd.ExecuteNonQuery()
            conect.Cerrar()
            MessageBox.Show("Los datos de ventanilla fueron agregados exitosamente")
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try


        GroupBoxPasajero.Enabled = True ' activo el group box de pasajero 
        If ComboBoxID_Ventanilla.SelectedItem = 1 Then
            GroupBox1.Enabled = False ' apago el group box de ventanilla para que no se puedan realizar cambios
            BtnConfirmarVentanilla.Enabled = False 'apago el boton de confimar porque si no se podrian guardar los mismos datos una y otra vez
            Dim dt As DataTable = New DataTable
            Dim consulta As String = "select Destino from TblVuelo where NumeroVentanilla = 1"
            Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(dt)
            conect.Cerrar()
            ComboBoxDestino.Items.Clear()

            For Each row As DataRow In dt.Rows
                ComboBoxDestino.Items.Add(row("Destino"))
            Next
            conect.Cerrar()





        ElseIf ComboBoxID_Ventanilla.SelectedItem = 2 Then
            GroupBox1.Enabled = False
            BtnConfirmarVentanilla.Enabled = False
            conect.Conectar()
            Dim dt As DataTable = New DataTable
            Dim consulta As String = "select Destino from TblVuelo where NumeroVentanilla = 1"
            Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(dt)
            conect.Cerrar()
            ComboBoxDestino.Items.Clear()

            For Each row As DataRow In dt.Rows
                ComboBoxDestino.Items.Add(row("Destino"))
            Next
            conect.Cerrar()
        ElseIf ComboBoxID_Ventanilla.SelectedItem = 3 Then
            GroupBox1.Enabled = False
            BtnConfirmarVentanilla.Enabled = False
            conect.Conectar()
            Dim dt As DataTable = New DataTable
            Dim consulta As String = "select Destino from TblVuelo where NumeroVentanilla = 1"
            Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(dt)
            conect.Cerrar()
            ComboBoxDestino.Items.Clear()

            For Each row As DataRow In dt.Rows
                ComboBoxDestino.Items.Add(row("Destino"))
            Next
            conect.Cerrar()
        ElseIf ComboBoxID_Ventanilla.SelectedItem = 4 Then
            GroupBox1.Enabled = False
            BtnConfirmarVentanilla.Enabled = False
            conect.Conectar()
            Dim dt As DataTable = New DataTable
            Dim consulta As String = "select Destino from TblVuelo where NumeroVentanilla = 1"
            Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(dt)
            conect.Cerrar()
            ComboBoxDestino.Items.Clear()

            For Each row As DataRow In dt.Rows
                ComboBoxDestino.Items.Add(row("Destino"))
            Next
            conect.Cerrar()
        End If


        'if comprobacion ventanilla
        'select destino tblvuelo donde ventanilla sea 1 


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class