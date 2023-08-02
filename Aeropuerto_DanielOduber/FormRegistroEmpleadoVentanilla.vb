Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormRegistroEmpleadoVentanilla

    Public conect As Conexion_BD = New Conexion_BD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        Dim insertar As String = "insert into Ventanillas ( NumeroVentanilla, Nombre_empleado, Cedula_Empleado, Hora_Apertura,Linea_aerea) values (@NumeroVentanilla, @Nombre_empleado, @Cedula_Empleado, @Hora_Apertura,@Linea_aerea)"
        Dim cmd As SqlCommand = New SqlCommand(insertar, conect.Conectar())
        cmd.Parameters.AddWithValue("@NumeroVentanilla", ComboBoxID_Ventanilla.Text)
        cmd.Parameters.AddWithValue("@Nombre_empleado", TextBoxNombre_Emple.Text)
        cmd.Parameters.AddWithValue("@Cedula_Empleado", TextBoxCedula_Empl.Text)
        cmd.Parameters.AddWithValue("@Hora_Apertura", TextBoxHoraApertura.Text)
        cmd.Parameters.AddWithValue("@Linea_aerea", ComboBoxLinea_Aereas.Text)
        cmd.ExecuteNonQuery()
        conect.Cerrar()
        MessageBox.Show("Los datos fueron agregados exitosamente")


    End Sub

    Private Sub FormRegistroEmpleadoVentanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnConfirmarVentanilla.Enabled = False


    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre_Emple.TextChanged, TextBoxCedula_Empl.TextChanged, TextBoxHoraApertura.TextChanged
        VerificarCamposRellenados()
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxID_Ventanilla.SelectedIndexChanged, ComboBoxLinea_Aereas.SelectedIndexChanged
        VerificarCamposRellenados()
        If ComboBoxID_Ventanilla.SelectedIndex = 1 Then
            ComboBoxLinea_Aereas.Items.Clear()
            Dim consulta As String = "select distinct LineaAerea from TblAvion
                                        inner join TblVuelo on ID_Avion = IDAvion
                                        where NumeroVentanilla = 1"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim lineaAerea As String = Convert.ToString(cmd.ExecuteScalar())
            conect.Cerrar()
            ComboBoxLinea_Aereas.Items.Add(lineaAerea)




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

    Private Sub VerificarCamposRellenados()
        If Not String.IsNullOrEmpty(TextBoxCedula_Empl.Text) AndAlso Not String.IsNullOrEmpty(TextBoxHoraApertura.Text) AndAlso Not String.IsNullOrEmpty(TextBoxNombre_Emple.Text) AndAlso
        Not String.IsNullOrEmpty(ComboBoxID_Ventanilla.Text) AndAlso Not String.IsNullOrEmpty(ComboBoxLinea_Aereas.Text) Then
            BtnConfirmarVentanilla.Enabled = True
        Else
            BtnConfirmarVentanilla.Enabled = False
        End If
    End Sub
End Class