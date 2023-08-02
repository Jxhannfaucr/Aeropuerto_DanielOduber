Imports System.Data
Imports System.Data.SqlClient
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

    Private Sub ComboBoxDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDestino.SelectedIndexChanged
        VerificarCampos()

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
        If ComboBoxID_Ventanilla.SelectedIndex = 1 Then
            'ComboBoxLinea_Aereas.Items.Clear()
            Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 1"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
            conect.Cerrar()
            ComboBoxLinea_Aereas.Items.Add(lineaAerea)
            ComboBoxLinea_Aereas.SelectedItem = lineaAerea



        ElseIf ComboBoxID_Ventanilla.SelectedIndex = 2 Then
            ComboBoxLinea_Aereas.Items.Clear()
            Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 2"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
            conect.Cerrar()
            ComboBoxLinea_Aereas.Items.Add(lineaAerea)
            ComboBoxLinea_Aereas.SelectedItem = lineaAerea

        ElseIf ComboBoxID_Ventanilla.SelectedIndex = 3 Then
            ComboBoxLinea_Aereas.Items.Clear()
            Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 3"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
            conect.Cerrar()
            ComboBoxLinea_Aereas.Items.Add(lineaAerea)
            ComboBoxLinea_Aereas.SelectedItem = lineaAerea


        ElseIf ComboBoxID_Ventanilla.SelectedIndex = 4 Then
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
        cmd.Parameters.AddWithValue("@NumeroVentanilla", ComboBoxID_Ventanilla.Text)
        cmd.Parameters.AddWithValue("@Nombre_empleado", TextBoxNombre_Emple.Text)
        cmd.Parameters.AddWithValue("@Cedula_Empleado", TextBoxCedula_Empl.Text)
        cmd.Parameters.AddWithValue("@Hora_Apertura", TextBoxHoraApertura.Text)
        cmd.Parameters.AddWithValue("@Linea_aerea", ComboBoxLinea_Aereas.Text)
        cmd.ExecuteNonQuery()
        conect.Cerrar()
        MessageBox.Show("Los datos de ventanilla fueron agregados exitosamente")
        'if comprobacion ventanilla
        'select destino tblvuelo donde ventanilla sea 1 


    End Sub
End Class