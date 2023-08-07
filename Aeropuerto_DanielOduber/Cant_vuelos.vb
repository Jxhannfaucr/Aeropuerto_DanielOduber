Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class Cant_vuelos

    Public conect As Conexion_BD = New Conexion_BD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Busqueda As String = "SELECT count(IDPasajero) AS CantVuelos " &
                        "FROM TblPasajero " &
                        "INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso " &
                        "WHERE Ventanillas.NumeroVentanilla = @NumeroVentanilla AND Ventanillas.Fecha = @Fecha"

        Dim cmd As SqlCommand = New SqlCommand(Busqueda, conect.Conectar())
        cmd.Parameters.AddWithValue("@NumeroVentanilla", List_ventanillas.Text)
        cmd.Parameters.AddWithValue("@Fecha", buscar_fecha.Text) ' Aquí utilizamos buscar_fecha.Value para obtener el valor DateTime.
        Dim cantVuelos As Integer = Convert.ToInt32(cmd.ExecuteScalar()) ' Utilizamos ExecuteScalar para obtener un solo valor (la suma de IDPasajero).



        Dim resultado_cantidad As String = Convert.ToString(cmd.ExecuteScalar()) ' proceso de una consulta
        Total_de_vuelos.Text = resultado_cantidad
        conect.Cerrar()
    End Sub


End Class