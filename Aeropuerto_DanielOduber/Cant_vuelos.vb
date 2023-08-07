Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class Cant_vuelos

    Public conect As Conexion_BD = New Conexion_BD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Busqueda As String = "SELECT COUNT(IDPasajero) AS CantVuelos, Destino " &
                    "FROM TblPasajero " &
                    "INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso " &
                    "WHERE Ventanillas.NumeroVentanilla = @NumeroVentanilla AND Ventanillas.Fecha = @Fecha " &
                    "GROUP BY Destino"

        Dim cmd As SqlCommand = New SqlCommand(Busqueda, conect.Conectar())
        cmd.Parameters.AddWithValue("@NumeroVentanilla", List_ventanillas.Text)
        cmd.Parameters.AddWithValue("@Fecha", buscar_fecha.Text)

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)
        DataGridView1.DataSource = dt

        ' Mostrar el total de vuelos en el TextBox
        Dim cantVuelos As Integer = dt.Rows.Cast(Of DataRow)().Sum(Function(row) Convert.ToInt32(row("CantVuelos")))
        Total_de_vuelos.Text = cantVuelos.ToString()

        conect.Cerrar()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim volver_menu_informes As New Informes()
        volver_menu_informes.Show()
        Me.Close()
    End Sub
End Class