Imports System.Data.SqlClient

Public Class Informes
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Obtenemos la hora ingresada por el administrador.
        Dim horaBusqueda As DateTime
        If DateTime.TryParse(txtHoraX.Text, horaBusqueda) Then
            Try
                Using connection As SqlConnection = New SqlConnection("connectionString")
                    connection.Open()

                    ' Consulta SQL para obtener los vuelos y destinos atendidos hasta la hora de búsqueda.
                    Dim query As String = "SELECT COUNT(*) AS CantidadVuelos, Destino FROM TablaVuelos WHERE Hora <= @HoraBusqueda GROUP BY Destino"

                    Using command As SqlCommand = New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@HoraBusqueda", horaBusqueda)
                        Dim reader As SqlDataReader = command.ExecuteReader()

                        ' Variables para almacenar la información.
                        Dim cantidadVuelos As Integer = 0
                        Dim destinos As List(Of String) = New List(Of String)()

                        ' Leer los resultados de la consulta.
                        While reader.Read()
                            cantidadVuelos += Convert.ToInt32(reader("CantidadVuelos"))
                            destinos.Add(reader("Destino").ToString())
                        End While

                        ' Cerrar el lector y mostrar los resultados en las etiquetas.
                        reader.Close()
                        lblCantidadVuelos.Text = "Cantidad de vuelos atendidos: " & cantidadVuelos.ToString()
                        lblDestinosAtendidos.Text = "Destinos atendidos hasta " & horaBusqueda.ToString("HH:mm") & ": " & String.Join(", ", destinos)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor, ingresa una hora válida en formato HH:mm.")
        End If
    End Sub
End Class
