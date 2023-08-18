Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Runtime.Remoting.Contexts
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Recoleccion_monetaria

    Public conect As Conexion_BD = New Conexion_BD
    Dim datosVuelosPorVentanilla As DataTable = New DataTable


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        GroupBox2.Enabled = True
        Dim ventanilla_seleccionada As String = ComboBoxID_Ventanilla.SelectedItem.ToString
        Try
            If Not ventanilla_seleccionada = "Todas" Then
                ComboBoxDestino.Enabled = True
                ''ventanilla 1''
                If ComboBoxID_Ventanilla.SelectedItem = 1 Then
                    datosVuelosPorVentanilla.Reset()
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

            Else

                ComboBoxDestino.Enabled = False

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim ventanilla_seleccionada As String = ComboBoxID_Ventanilla.SelectedItem.ToString
            If Not ventanilla_seleccionada = "Todas" Then

                Dim destinoSeleccionado As Integer = ComboBoxDestino.SelectedIndex

                If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < datosVuelosPorVentanilla.Rows.Count Then
                    Dim filaSeleccionada As DataRow = datosVuelosPorVentanilla.Rows(destinoSeleccionado)
                    Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

                    Dim queryCantidadRecolectado As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE TblVuelo.IDVuelo = @IDVuelo AND Ventanillas.Fecha = @Fecha"

                    Using cmdCantidad As New SqlCommand(queryCantidadRecolectado, conect.Conectar())
                        cmdCantidad.Parameters.AddWithValue("@IDVuelo", IDVuelo)
                        cmdCantidad.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                        Dim obtenerDato As Decimal = CInt(cmdCantidad.ExecuteScalar())
                        Dim cantidadRecolectado As String = obtenerDato.ToString("C2")
                        TotalRecolectado.Text = cantidadRecolectado.ToString()
                        conect.Cerrar()

                        ' Mostrar la cantidad de pasajeros llegaron en algún lugar
                        ' Por ejemplo: Console.WriteLine("Cantidad de pasajeros llegaron: " & cantidadPasajeros)

                    End Using
                End If

            Else
                Dim queryCantidadRecolectado As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.Fecha = @Fecha"

                Dim cmdCantidad2 As New SqlCommand(queryCantidadRecolectado, conect.Conectar())
                cmdCantidad2.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                Dim obtenerDato As Decimal = CInt(cmdCantidad2.ExecuteScalar())
                Dim cantidadRecolectado As String = obtenerDato.ToString("C2")
                TotalRecolectado.Text = cantidadRecolectado.ToString()
                conect.Cerrar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Recoleccion_monetaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False ' apago el group box de ventanilla para que no se puedan realizar cambios
        BtnConfirmarVentanilla.Enabled = True 'apago el boton de confimar porque si no se podrian guardar los mismos datos una y otra vez

    End Sub

    Private Sub ComboBoxID_Ventanilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxID_Ventanilla.SelectedIndexChanged
        ComboBoxDestino.Text = ""
        GroupBox2.Enabled = False
        TotalRecolectado.Text = ""
    End Sub

    Private Sub ComboBoxID_Ventanilla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxID_Ventanilla.KeyPress
        e.Handled = True ' Evita que se procese la tecla presionada
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim informes As New Informes()
        informes.Show()
        Me.Close()
    End Sub
End Class