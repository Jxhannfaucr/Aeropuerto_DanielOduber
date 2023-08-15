Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Runtime.Remoting.Contexts

Public Class Informe_cant_personas

    Public conect As Conexion_BD = New Conexion_BD
    Dim tabla_destinos As DataTable = New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim destinoSeleccionado As Integer = ComboSeleccionar_vuelo.SelectedIndex

            If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < tabla_destinos.Rows.Count Then
                Dim filaSeleccionada As DataRow = tabla_destinos.Rows(destinoSeleccionado)
                Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

                ''llena la datagrid
                Dim query As String = "SELECT p.Nombre, p.Pasaporte, p.NumAsiento, p.Destino
                                    FROM TblPasajero p
                                    INNER JOIN TblVuelo v ON p.ID_Vuelo = v.idVuelo
                                    WHERE v.IDVuelo = @IDVuelo"
                Dim cmd As SqlCommand = New SqlCommand(query, conect.Conectar())
                cmd.Parameters.AddWithValue("@IDVuelo", IDVuelo)

                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                conect.Cerrar()

                ''llena el textbox de cantidad de pasajeros''
                Dim query1 As String = "SELECT COUNT(p.Pasaporte)
                                    FROM TblPasajero p
                                    INNER JOIN TblVuelo v ON p.ID_Vuelo = v.idVuelo
                                    WHERE v.IDVuelo = @IDVuelo"
                Dim cmd1 As SqlCommand = New SqlCommand(query1, conect.Conectar())
                cmd1.Parameters.AddWithValue("@IDVuelo", IDVuelo)
                Dim cantidadPasajeros As Integer = CInt(cmd1.ExecuteScalar())
                txtCantidadPasajeros.Text = cantidadPasajeros.ToString()
                conect.Cerrar()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Informe_cant_personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla_destinos.Reset()
        Dim consulta As String = "SELECT * FROM TblVuelo"
        Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
        Dim da As SqlDataAdapter = New SqlDataAdapter(M)
        da.Fill(tabla_destinos)
        conect.Cerrar()

        ComboSeleccionar_vuelo.Items.Clear()

        For Each row As DataRow In tabla_destinos.Rows
            ComboSeleccionar_vuelo.Items.Add(row("Destino"))
        Next
        conect.Cerrar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim volver_Menu_informes As New Informes()
        volver_Menu_informes.Show()
        Me.Close()
    End Sub

    Private Sub ComboSeleccionar_vuelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboSeleccionar_vuelo.KeyPress
        e.Handled = True ' Evita que se procese la tecla presionada
    End Sub

    Private Sub ComboSeleccionar_vuelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSeleccionar_vuelo.SelectedIndexChanged
        Button1.Enabled = True
    End Sub
End Class