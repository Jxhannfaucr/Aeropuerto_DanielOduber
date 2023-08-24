Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class Cant_vuelos

    Public conect As Conexion_BD = New Conexion_BD


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim cantV1 As Integer = 0
        Dim cantV2 As Integer = 0
        Dim cantV3 As Integer = 0
        Dim cantV4 As Integer = 0

        Try


            If Not CheckBox5.Checked Then
                If CheckBox1.Checked Then
                    Dim Busqueda1 As String = "SELECT COUNT(IDPasajero) AS CantVuelos, Destino " &
                   "FROM TblPasajero " &
                   "INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso " &
                   "WHERE Ventanillas.NumeroVentanilla = 1 AND Ventanillas.Fecha = @Fecha " &
                   "GROUP BY Destino"

                    Dim cmd1 As SqlCommand = New SqlCommand(Busqueda1, conect.Conectar())
                    cmd1.Parameters.AddWithValue("@Fecha", buscar_fecha.Text)

                    Dim dt1 As New DataTable()
                    Dim da1 As New SqlDataAdapter(cmd1)

                    da1.Fill(dt1)
                    DataGridView1.DataSource = dt1

                    ' Mostrar el total de vuelos en el TextBox
                    cantV1 = dt1.Rows.Cast(Of DataRow)().Sum(Function(row) Convert.ToInt32(row("CantVuelos")))

                    conect.Cerrar()
                Else
                    Dim dt1 As New DataTable()
                    DataGridView1.DataSource = dt1
                End If

                If CheckBox2.Checked Then
                    Dim Busqueda2 As String = "SELECT COUNT(IDPasajero) AS CantVuelos, Destino " &
                   "FROM TblPasajero " &
                   "INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso " &
                   "WHERE Ventanillas.NumeroVentanilla = 2 AND Ventanillas.Fecha = @Fecha " &
                   "GROUP BY Destino"

                    Dim cmd2 As SqlCommand = New SqlCommand(Busqueda2, conect.Conectar())
                    cmd2.Parameters.AddWithValue("@Fecha", buscar_fecha.Text)

                    Dim dt2 As New DataTable()
                    Dim da2 As New SqlDataAdapter(cmd2)

                    da2.Fill(dt2)
                    DataGridView2.DataSource = dt2

                    ' Mostrar el total de vuelos en el TextBox
                    cantV2 = dt2.Rows.Cast(Of DataRow)().Sum(Function(row) Convert.ToInt32(row("CantVuelos")))

                    conect.Cerrar()
                Else
                    Dim dt2 As New DataTable()
                    DataGridView2.DataSource = dt2
                End If

                If CheckBox3.Checked Then
                    Dim Busqueda3 As String = "SELECT COUNT(IDPasajero) AS CantVuelos, Destino " &
                   "FROM TblPasajero " &
                   "INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso " &
                   "WHERE Ventanillas.NumeroVentanilla = 3 AND Ventanillas.Fecha = @Fecha " &
                   "GROUP BY Destino"

                    Dim cmd3 As SqlCommand = New SqlCommand(Busqueda3, conect.Conectar())
                    cmd3.Parameters.AddWithValue("@Fecha", buscar_fecha.Text)

                    Dim dt3 As New DataTable()
                    Dim da3 As New SqlDataAdapter(cmd3)

                    da3.Fill(dt3)
                    DataGridView3.DataSource = dt3

                    ' Mostrar el total de vuelos en el TextBox
                    cantV3 = dt3.Rows.Cast(Of DataRow)().Sum(Function(row) Convert.ToInt32(row("CantVuelos")))

                    conect.Cerrar()
                Else
                    Dim dt3 As New DataTable()
                    DataGridView3.DataSource = dt3
                End If

                If CheckBox4.Checked Then
                    Dim Busqueda4 As String = "SELECT COUNT(IDPasajero) AS CantVuelos, Destino " &
                   "FROM TblPasajero " &
                   "INNER JOIN Ventanillas ON TblPasajero.ID_Ventanilla = Ventanillas.Id_Proceso " &
                   "WHERE Ventanillas.NumeroVentanilla = 4 AND Ventanillas.Fecha = @Fecha " &
                   "GROUP BY Destino"

                    Dim cmd4 As SqlCommand = New SqlCommand(Busqueda4, conect.Conectar())
                    cmd4.Parameters.AddWithValue("@Fecha", buscar_fecha.Text)

                    Dim dt4 As New DataTable()
                    Dim da4 As New SqlDataAdapter(cmd4)

                    da4.Fill(dt4)
                    DataGridView4.DataSource = dt4

                    ' Mostrar el total de vuelos en el TextBox
                    cantV4 = dt4.Rows.Cast(Of DataRow)().Sum(Function(row) Convert.ToInt32(row("CantVuelos")))

                    conect.Cerrar()
                Else
                    Dim dt4 As New DataTable()
                    DataGridView4.DataSource = dt4
                End If

                Dim sumatotalventanillas As Integer = cantV1 + cantV2 + cantV3 + cantV4
                Total_de_vuelos.Text = sumatotalventanillas

            ElseIf CheckBox5.Checked Then

                Dim dt1 As New DataTable()
                DataGridView1.DataSource = dt1
                Dim dt2 As New DataTable()
                DataGridView2.DataSource = dt2
                Dim dt3 As New DataTable()
                DataGridView3.DataSource = dt3
                Dim dt4 As New DataTable()
                DataGridView4.DataSource = dt4

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



    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False

        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub
End Class