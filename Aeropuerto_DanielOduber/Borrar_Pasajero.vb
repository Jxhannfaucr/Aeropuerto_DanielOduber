Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts
Imports System.Security.Cryptography

Public Class Borrar_Pasajero

    Private _tablaVuelos As DataTable
    Public conect As Conexion_BD = New Conexion_BD
    Public Property TablaVuelos() As DataTable
        Get
            Return _tablaVuelos
        End Get
        Set(ByVal value As DataTable)
            _tablaVuelos = value
        End Set
    End Property
    Private Sub Borrar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each row As DataRow In _tablaVuelos.Rows
            ComboBoxDestino.Items.Add(row("Destino"))
        Next
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Try
            Dim destinoSeleccionado As Integer = ComboBoxDestino.SelectedIndex

            If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < _tablaVuelos.Rows.Count Then
                Dim filaSeleccionada As DataRow = _tablaVuelos.Rows(destinoSeleccionado)
                Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

                ''llena la datagrid
                Dim query As String = "select p.IDPasajero, p.Nombre, p.Pasaporte, p.NumAsiento from TblPasajero as p
                                        inner join TblVuelo as v
                                        on v.IDVuelo = p.ID_Vuelo
                                        inner join Ventanillas as vn
                                        on vn.Id_Proceso = p.ID_Ventanilla
                                        where v.IDVuelo = @IDVuelo and vn.Fecha = @Fecha"
                Dim cmd As SqlCommand = New SqlCommand(query, conect.Conectar())
                cmd.Parameters.AddWithValue("@IDVuelo", IDVuelo)
                cmd.Parameters.AddWithValue("@Fecha", DateTimeBuscar.Text)

                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                conect.Cerrar()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("¿Estás seguro de realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                Dim codigoPasajero = DataGridView1.CurrentRow.Cells(0).Value.ToString()

                Dim Eliminar As String = "delete from TblPasajero where IDPasajero = @Codigo"
                Dim cmd As SqlCommand = New SqlCommand(Eliminar, conect.Conectar())
                cmd.Parameters.AddWithValue("@Codigo", codigoPasajero)
                cmd.ExecuteNonQuery()
                conect.Cerrar()
                MessageBox.Show("El pasajero fue eliminado exitosamente.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf respuesta = DialogResult.No Then

            MessageBox.Show("Has cancelado la acción.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



        Try
            Dim destinoSeleccionado As Integer = ComboBoxDestino.SelectedIndex

            If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < _tablaVuelos.Rows.Count Then
                Dim filaSeleccionada As DataRow = _tablaVuelos.Rows(destinoSeleccionado)
                Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

                ''llena la datagrid
                Dim query As String = "select p.IDPasajero, p.Nombre, p.Pasaporte, p.NumAsiento from TblPasajero as p
                                        inner join TblVuelo as v
                                        on v.IDVuelo = p.ID_Vuelo
                                        inner join Ventanillas as vn
                                        on vn.Id_Proceso = p.ID_Ventanilla
                                        where v.IDVuelo = @IDVuelo and vn.Fecha = @Fecha"
                Dim cmd As SqlCommand = New SqlCommand(query, conect.Conectar())
                cmd.Parameters.AddWithValue("@IDVuelo", IDVuelo)
                cmd.Parameters.AddWithValue("@Fecha", DateTimeBuscar.Text)

                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                conect.Cerrar()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class