Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Runtime.Remoting.Contexts

Public Class Informe_cant_personas

    Public conect As Conexion_BD = New Conexion_BD
    Dim tabla_destinos As DataTable = New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim destinoSeleccionado As Integer = ComboSeleccionar_vuelo.SelectedIndex

        If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < tabla_destinos.Rows.Count Then
            Dim filaSeleccionada As DataRow = tabla_destinos.Rows(destinoSeleccionado)
            Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

            Dim query As String = "SELECT p.Nombre, p.Pasaporte, p.NumAsiento, p.Destino
                                    FROM TblPasajero p
                                    INNER JOIN TblVuelo v ON p.ID_Vuelo = v.idVuelo
                                    WHERE p.escala = 0 AND v.IDVuelo = @IDVuelo" ' Cambio en la condición para escala = 0
            Dim cmd As SqlCommand = New SqlCommand(query, conect.Conectar())
            cmd.Parameters.AddWithValue("@IDVuelo", IDVuelo)

            Dim dt As DataTable = New DataTable()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conect.Cerrar()
        End If
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


End Class