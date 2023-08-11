Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Runtime.Remoting.Contexts

Public Class pasajeros_bajados

    Public conect As Conexion_BD = New Conexion_BD
    Dim tabla_escala As DataTable = New DataTable
    Private Sub Btn_Ver_Click(sender As Object, e As EventArgs) Handles Btn_Ver.Click
        ''guardo el indice del destino
        Dim destinoSeleccionado As Integer = Box_con_escala.SelectedIndex

        ''busco los datos de ese destino en la dataTable''
        If destinoSeleccionado >= 0 AndAlso destinoSeleccionado < tabla_escala.Rows.Count Then
            Dim filaSeleccionada As DataRow = tabla_escala.Rows(destinoSeleccionado)

            ''Guardo los datos que se necesitan''

            Dim IDVuelo% = Integer.Parse(filaSeleccionada("IDVuelo"))
            ' Realiza una consulta para obtener los detalles de los pasajeros basados en el IDVuelo

            Dim pasajeros_bajados = filaSeleccionada("Destino").ToString()



            Dim query As String = "SELECT COUNT(*) AS cantidad_pasajeros_bajaron
                FROM TblPasajero p
                INNER JOIN TblVuelo v ON p.ID_Vuelo = v.idVuelo
                WHERE p.escala = 1 and v.IDVuelo = @IDVuelo"
            Dim cmd As SqlCommand = New SqlCommand(query, conect.Conectar())
            cmd.Parameters.AddWithValue("@IDVuelo", IDVuelo)
            cmd.ExecuteNonQuery()
            conect.Cerrar()

            'creo y hago el select de los pasajeros que bajan 
            Dim dt As DataTable = New DataTable()
            Dim consulta As String = "SELECT p.Nombre, p.Pasaporte, p.NumAsiento, p.Destino
                                                                                            FROM TblPasajero p
                                                                                            INNER JOIN TblVuelo v ON p.ID_Vuelo = v.idVuelo
                                                                                            WHERE p.escala = 1 and v.IDVuelo = @IDVuelo"
            Dim cmd1 As SqlCommand = New SqlCommand(consulta, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd1)
            cmd1.Parameters.AddWithValue("@IDVuelo", IDVuelo)
            cmd1.ExecuteNonQuery()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conect.Cerrar()

        End If

    End Sub

    'aqui realizo lo que es la seleccion de los destinos que tienen escala 
    Private Sub pasajeros_bajados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tabla_escala.Reset()
        Dim consulta As String = "SELECT * FROM TblVuelo WHERE Escala <> 'none';"
        Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
        Dim da As SqlDataAdapter = New SqlDataAdapter(M)
        da.Fill(tabla_escala)
        conect.Cerrar()

        Box_con_escala.Items.Clear()

        For Each row As DataRow In tabla_escala.Rows
            Box_con_escala.Items.Add(row("Destino"))
        Next
        conect.Cerrar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim volver_Menu_informes As New Informes()
        volver_Menu_informes.Show()
        Me.Close()
    End Sub
End Class