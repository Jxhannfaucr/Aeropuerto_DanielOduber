Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class Cant_vuelos

    Public conect As Conexion_BD = New Conexion_BD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventanilla_seleccionada As String = List_ventanillas.Text
        Try
            If List_ventanillas.Text = 1 OrElse List_ventanillas.Text = 2 OrElse List_ventanillas.Text = 3 OrElse List_ventanillas.Text = 4 Then
                Dim Busqueda As String = "SELECT COUNT(IDPasajero) AS CantVuelos, Destino " &
                    "FROM TblPasajero " &
                    "INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso " &
                    "WHERE Ventanillas.NumeroVentanilla = @NumeroVentanilla AND Ventanillas.Fecha = @Fecha " &
                    "GROUP BY Destino"

                Dim cmd As SqlCommand = New SqlCommand(Busqueda, conect.Conectar())
                cmd.Parameters.AddWithValue("@NumeroVentanilla", ventanilla_seleccionada)
                cmd.Parameters.AddWithValue("@Fecha", buscar_fecha.Text)

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)

                da.Fill(dt)
                DataGridView1.DataSource = dt

                ' Mostrar el total de vuelos en el TextBox
                Dim cantVuelos As Integer = dt.Rows.Cast(Of DataRow)().Count(Function(row) Convert.ToInt32(row("CantVuelos")))
                Total_de_vuelos.Text = cantVuelos.ToString()

                conect.Cerrar()

            ElseIf ventanilla_seleccionada = 5 Then
                Dim Busqueda As String = "SELECT COUNT(IDPasajero) AS CantVuelos, Destino
                                                FROM TblPasajero
                                                INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso
                                                WHERE Ventanillas.Fecha = @Fecha
                                                GROUP BY Destino
                                                "

                Dim cmd As SqlCommand = New SqlCommand(Busqueda, conect.Conectar())
                cmd.Parameters.AddWithValue("@Fecha", buscar_fecha.Text)

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)

                da.Fill(dt)
                DataGridView1.DataSource = dt

                ' Mostrar el total de vuelos en el TextBox
                Dim totalVuelos As Integer = dt.Rows.Cast(Of DataRow)().Sum(Function(row) Convert.ToInt32(row("CantVuelos")))
                Total_de_vuelos.Text = totalVuelos.ToString()


                conect.Cerrar()
            End If
        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim volver_menu_informes As New Informes()
        volver_menu_informes.Show()
        Me.Close()
    End Sub

    Private Sub List_ventanillas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles List_ventanillas.KeyPress
        e.Handled = True ' Evita que se procese la tecla presionada
    End Sub

    Private Sub Cant_vuelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub List_ventanillas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_ventanillas.SelectedIndexChanged
        Button1.Enabled = True
    End Sub
End Class