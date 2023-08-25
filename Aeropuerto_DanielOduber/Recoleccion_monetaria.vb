Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Runtime.Remoting.Contexts
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Recoleccion_monetaria

    Public conect As Conexion_BD = New Conexion_BD

    Dim dt1 As DataTable = New DataTable()
    Dim dt2 As DataTable = New DataTable()
    Dim dt3 As DataTable = New DataTable()
    Dim dt4 As DataTable = New DataTable()

    Dim totalV1 = 0
    Dim totalV2 = 0
    Dim totalV3 = 0
    Dim totalV4 = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        Try
            If Not CheckBox5.Checked Then
                GroupBox2.Enabled = True
                ComboBoxDestino1.Enabled = True
                ComboBoxDestino2.Enabled = True
                ComboBoxDestino3.Enabled = True
                ComboBoxDestino4.Enabled = True
                ButtonTodas.Enabled = True



                If CheckBox1.Checked Then
                    dt1.Reset()
                    Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 1"
                    Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                    Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                    da.Fill(dt1)
                    conect.Cerrar()
                    ComboBoxDestino1.Items.Clear()

                    For Each row As DataRow In dt1.Rows
                        ComboBoxDestino1.Items.Add(row("Destino"))
                    Next
                    conect.Cerrar()
                Else
                    ComboBoxDestino1.Enabled = False
                End If

                If CheckBox2.Checked Then
                    dt2.Reset()
                    Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 2"
                    Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                    Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                    da.Fill(dt2)
                    conect.Cerrar()
                    ComboBoxDestino2.Items.Clear()

                    For Each row As DataRow In dt2.Rows
                        ComboBoxDestino2.Items.Add(row("Destino"))
                    Next
                    conect.Cerrar()
                Else
                    ComboBoxDestino2.Enabled = False
                End If

                If CheckBox3.Checked Then
                    dt3.Reset()
                    Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 3"
                    Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                    Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                    da.Fill(dt3)
                    conect.Cerrar()
                    ComboBoxDestino3.Items.Clear()

                    For Each row As DataRow In dt3.Rows
                        ComboBoxDestino3.Items.Add(row("Destino"))
                    Next
                    conect.Cerrar()
                Else
                    ComboBoxDestino3.Enabled = False
                End If

                If CheckBox4.Checked Then
                    dt4.Reset()
                    Dim consulta As String = "select * from TblVuelo where NumeroVentanilla = 4"
                    Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
                    Dim da As SqlDataAdapter = New SqlDataAdapter(M)
                    da.Fill(dt4)
                    conect.Cerrar()
                    ComboBoxDestino4.Items.Clear()

                    For Each row As DataRow In dt4.Rows
                        ComboBoxDestino4.Items.Add(row("Destino"))
                    Next
                    conect.Cerrar()
                Else
                    ComboBoxDestino4.Enabled = False
                End If

            ElseIf Not CheckBox1.Checked And Not CheckBox2.Checked And Not CheckBox3.Checked And Not CheckBox4.Checked And Not CheckBox5.Checked Then
                MessageBox.Show("Campo vacio")

            ElseIf CheckBox5.Checked Then
                GroupBox2.Enabled = True
                ComboBoxDestino1.Enabled = True
                ComboBoxDestino2.Enabled = True
                ComboBoxDestino3.Enabled = True
                ComboBoxDestino4.Enabled = True
                ButtonTodas.Enabled = True

                ''Ventanilla 1''
                dt1.Reset()
                Dim consulta1 As String = "select * from TblVuelo where NumeroVentanilla = 1"
                Dim M1 As SqlCommand = New SqlCommand(consulta1, conect.Conectar())
                Dim da1 As SqlDataAdapter = New SqlDataAdapter(M1)
                da1.Fill(dt1)
                conect.Cerrar()
                ComboBoxDestino1.Items.Clear()

                For Each row As DataRow In dt1.Rows
                    ComboBoxDestino1.Items.Add(row("Destino"))
                Next
                conect.Cerrar()

                ''Ventanilla 2''
                dt2.Reset()
                Dim consulta2 As String = "select * from TblVuelo where NumeroVentanilla = 2"
                Dim M2 As SqlCommand = New SqlCommand(consulta2, conect.Conectar())
                Dim da2 As SqlDataAdapter = New SqlDataAdapter(M2)
                da2.Fill(dt2)
                conect.Cerrar()
                ComboBoxDestino2.Items.Clear()

                For Each row As DataRow In dt2.Rows
                    ComboBoxDestino2.Items.Add(row("Destino"))
                Next
                conect.Cerrar()

                ''Ventanilla 3''
                dt3.Reset()
                Dim consulta3 As String = "select * from TblVuelo where NumeroVentanilla = 3"
                Dim M3 As SqlCommand = New SqlCommand(consulta3, conect.Conectar())
                Dim da3 As SqlDataAdapter = New SqlDataAdapter(M3)
                da3.Fill(dt3)
                conect.Cerrar()
                ComboBoxDestino3.Items.Clear()

                For Each row As DataRow In dt3.Rows
                    ComboBoxDestino3.Items.Add(row("Destino"))
                Next
                conect.Cerrar()

                ''Ventanilla 4''
                dt4.Reset()
                Dim consulta4 As String = "select * from TblVuelo where NumeroVentanilla = 4"
                Dim M4 As SqlCommand = New SqlCommand(consulta4, conect.Conectar())
                Dim da4 As SqlDataAdapter = New SqlDataAdapter(M4)
                da4.Fill(dt4)
                conect.Cerrar()
                ComboBoxDestino4.Items.Clear()

                For Each row As DataRow In dt4.Rows
                    ComboBoxDestino4.Items.Add(row("Destino"))
                Next
                conect.Cerrar()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TotalRecolectado1.Text = ""
        TotalRecolectado2.Text = ""
        TotalRecolectado3.Text = ""
        TotalRecolectado4.Text = ""

        Dim colon As New CultureInfo("es-CR")
        colon.NumberFormat.CurrencySymbol = "₡"
        Try
            If Not CheckBox5.Checked Then

                If CheckBox1.Checked Then
                    Dim destinoSeleccionado1 As Integer = ComboBoxDestino1.SelectedIndex
                    If destinoSeleccionado1 >= 0 AndAlso destinoSeleccionado1 < dt1.Rows.Count Then
                        Dim filaSeleccionada As DataRow = dt1.Rows(destinoSeleccionado1)
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
                            Dim cantidadRecolectado As String = obtenerDato.ToString("C2", colon)
                            TotalRecolectado1.Text = cantidadRecolectado.ToString()
                            conect.Cerrar()
                            totalV1 = obtenerDato

                        End Using

                    End If


                End If

                If CheckBox2.Checked Then
                    Dim destinoSeleccionado2 As Integer = ComboBoxDestino2.SelectedIndex
                    If destinoSeleccionado2 >= 0 AndAlso destinoSeleccionado2 < dt2.Rows.Count Then
                        Dim filaSeleccionada As DataRow = dt2.Rows(destinoSeleccionado2)
                        Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

                        Dim queryCantidadRecolectado As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE TblVuelo.IDVuelo = @IDVuelo AND Ventanillas.Fecha = @Fecha"

                        Using cmdCantidad As New SqlCommand(queryCantidadRecolectado, conect.Conectar())
                            cmdCantidad.Parameters.AddWithValue("@IDVuelo", IDVuelo)
                            cmdCantidad.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                            Dim obtenerDato2 As Decimal = CInt(cmdCantidad.ExecuteScalar())
                            Dim cantidadRecolectado As String = obtenerDato2.ToString("C2", colon)
                            TotalRecolectado2.Text = cantidadRecolectado.ToString()
                            conect.Cerrar()
                            totalV2 = obtenerDato2
                        End Using


                    End If

                End If

                If CheckBox3.Checked Then
                    Dim destinoSeleccionado3 As Integer = ComboBoxDestino3.SelectedIndex
                    If destinoSeleccionado3 >= 0 AndAlso destinoSeleccionado3 < dt3.Rows.Count Then
                        Dim filaSeleccionada As DataRow = dt3.Rows(destinoSeleccionado3)
                        Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

                        Dim queryCantidadRecolectado As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE TblVuelo.IDVuelo = @IDVuelo AND Ventanillas.Fecha = @Fecha"

                        Using cmdCantidad As New SqlCommand(queryCantidadRecolectado, conect.Conectar())
                            cmdCantidad.Parameters.AddWithValue("@IDVuelo", IDVuelo)
                            cmdCantidad.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                            Dim obtenerDato3 As Decimal = CInt(cmdCantidad.ExecuteScalar())
                            Dim cantidadRecolectado As String = obtenerDato3.ToString("C2", colon)
                            TotalRecolectado3.Text = cantidadRecolectado.ToString()
                            conect.Cerrar()
                            totalV3 = obtenerDato3
                        End Using


                    End If
                End If

                If CheckBox4.Checked Then
                    Dim destinoSeleccionado4 As Integer = ComboBoxDestino4.SelectedIndex
                    If destinoSeleccionado4 >= 0 AndAlso destinoSeleccionado4 < dt4.Rows.Count Then
                        Dim filaSeleccionada As DataRow = dt4.Rows(destinoSeleccionado4)
                        Dim IDVuelo As Integer = Integer.Parse(filaSeleccionada("IDVuelo"))

                        Dim queryCantidadRecolectado As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE TblVuelo.IDVuelo = @IDVuelo AND Ventanillas.Fecha = @Fecha"

                        Using cmdCantidad As New SqlCommand(queryCantidadRecolectado, conect.Conectar())
                            cmdCantidad.Parameters.AddWithValue("@IDVuelo", IDVuelo)
                            cmdCantidad.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                            Dim obtenerDato4 As Decimal = CInt(cmdCantidad.ExecuteScalar())
                            Dim cantidadRecolectado As String = obtenerDato4.ToString("C2", colon)
                            TotalRecolectado4.Text = cantidadRecolectado.ToString()
                            conect.Cerrar()
                            totalV4 = obtenerDato4
                        End Using


                    End If

                End If

                'Dim total = totalV1 + totalV2 + totalV3 + totalV4
                'TextBoxTotal.Text = total.ToString
                Dim totalGeneral As Decimal = totalV1 + totalV2 + totalV3 + totalV4

                TextBoxTotal.Text = totalGeneral.ToString("C2", colon)

                ''TODOS''
            ElseIf CheckBox5.Checked Then
                ''si es todas, hace una suma de todos los vuelos hechos por las ventanillas ese dia''

                Dim destinoSeleccionado1 As Integer = ComboBoxDestino1.SelectedIndex
                If destinoSeleccionado1 >= 0 AndAlso destinoSeleccionado1 < dt1.Rows.Count Then
                    Dim filaSeleccionada As DataRow = dt1.Rows(destinoSeleccionado1)
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
                        Dim cantidadRecolectado As String = obtenerDato.ToString("C2", colon)
                        TotalRecolectado1.Text = cantidadRecolectado.ToString()
                        conect.Cerrar()
                        totalV1 = obtenerDato
                    End Using

                End If



                Dim destinoSeleccionado2 As Integer = ComboBoxDestino2.SelectedIndex
                If destinoSeleccionado2 >= 0 AndAlso destinoSeleccionado2 < dt2.Rows.Count Then
                    Dim filaSeleccionada As DataRow = dt2.Rows(destinoSeleccionado2)
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
                        Dim cantidadRecolectado As String = obtenerDato.ToString("C2", colon)
                        TotalRecolectado2.Text = cantidadRecolectado.ToString()
                        conect.Cerrar()
                        totalV2 = obtenerDato
                    End Using


                End If

                Dim destinoSeleccionado3 As Integer = ComboBoxDestino3.SelectedIndex
                If destinoSeleccionado3 >= 0 AndAlso destinoSeleccionado3 < dt3.Rows.Count Then
                    Dim filaSeleccionada As DataRow = dt3.Rows(destinoSeleccionado3)
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
                        Dim cantidadRecolectado As String = obtenerDato.ToString("C2", colon)
                        TotalRecolectado3.Text = cantidadRecolectado.ToString()
                        conect.Cerrar()
                        totalV3 = obtenerDato
                    End Using


                End If

                Dim destinoSeleccionado4 As Integer = ComboBoxDestino4.SelectedIndex
                If destinoSeleccionado4 >= 0 AndAlso destinoSeleccionado4 < dt4.Rows.Count Then
                    Dim filaSeleccionada As DataRow = dt4.Rows(destinoSeleccionado4)
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
                        Dim cantidadRecolectado As String = obtenerDato.ToString("C2", colon)
                        TotalRecolectado4.Text = cantidadRecolectado.ToString()
                        conect.Cerrar()
                        totalV4 = obtenerDato
                    End Using


                End If

                Dim totalGeneral As Decimal = totalV1 + totalV2 + totalV3 + totalV4


                TextBoxTotal.Text = totalGeneral.ToString("C2", colon)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Recoleccion_monetaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False ' apago el group box de ventanilla para que no se puedan realizar cambios
        BtnConfirmarVentanilla.Enabled = True 'apago el boton de confimar porque si no se podrian guardar los mismos datos una y otra vez

    End Sub

    Private Sub ComboBoxID_Ventanilla_SelectedIndexChanged(sender As Object, e As EventArgs)
        ComboBoxDestino1.Text = ""
        GroupBox2.Enabled = False
        TotalRecolectado1.Text = ""
    End Sub

    Private Sub ComboBoxID_Ventanilla_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True ' Evita que se procese la tecla presionada
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim informes As New Informes()
        informes.Show()
        Me.Close()
    End Sub

    Private Sub ButtonTodas_Click(sender As Object, e As EventArgs) Handles ButtonTodas.Click
        TotalRecolectado1.Text = ""
        TotalRecolectado2.Text = ""
        TotalRecolectado3.Text = ""
        TotalRecolectado4.Text = ""

        Dim colon As New CultureInfo("es-CR")
        colon.NumberFormat.CurrencySymbol = "₡"
        Try
            If CheckBox5.Checked Then
                ComboBoxDestino1.Text = "TODOS"
                ComboBoxDestino2.Text = "TODOS"
                ComboBoxDestino3.Text = "TODOS"
                ComboBoxDestino4.Text = "TODOS"
                ''VENTANILLA 1''
                Dim queryCantidadRecolectado1 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 1 AND Ventanillas.Fecha = @Fecha"

                Dim cmdCantidad1 As New SqlCommand(queryCantidadRecolectado1, conect.Conectar())
                cmdCantidad1.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                Dim obtenerDato As Decimal = CInt(cmdCantidad1.ExecuteScalar())
                Dim cantidadRecolectado As String = obtenerDato.ToString("C2", colon)
                TotalRecolectado1.Text = cantidadRecolectado.ToString()
                conect.Cerrar()
                totalV1 = obtenerDato
                ''VENTANILLA 2''
                Dim queryCantidadRecolectado2 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 2 AND Ventanillas.Fecha = @Fecha"

                Dim cmdCantidad2 As New SqlCommand(queryCantidadRecolectado2, conect.Conectar())
                cmdCantidad2.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                Dim obtenerDato2 As Decimal = CInt(cmdCantidad2.ExecuteScalar())
                Dim cantidadRecolectado2 As String = obtenerDato2.ToString("C2", colon)
                TotalRecolectado2.Text = cantidadRecolectado2.ToString()
                conect.Cerrar()
                totalV2 = obtenerDato2
                ''VENTANILLA 3''
                Dim queryCantidadRecolectado3 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 3 AND Ventanillas.Fecha = @Fecha"

                Dim cmdCantidad3 As New SqlCommand(queryCantidadRecolectado3, conect.Conectar())
                cmdCantidad3.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                Dim obtenerDato3 As Decimal = CInt(cmdCantidad3.ExecuteScalar())
                Dim cantidadRecolectado3 As String = obtenerDato3.ToString("C2", colon)
                TotalRecolectado3.Text = cantidadRecolectado3.ToString()
                conect.Cerrar()
                totalV3 = obtenerDato3
                ''VENTANILLA 4''
                Dim queryCantidadRecolectado4 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 4 AND Ventanillas.Fecha = @Fecha"

                Dim cmdCantidad4 As New SqlCommand(queryCantidadRecolectado4, conect.Conectar())
                cmdCantidad4.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                Dim obtenerDato4 As Decimal = CInt(cmdCantidad4.ExecuteScalar())
                Dim cantidadRecolectado4 As String = obtenerDato4.ToString("C2", colon)
                TotalRecolectado4.Text = cantidadRecolectado4.ToString()
                conect.Cerrar()
                totalV4 = obtenerDato4


                Dim totalGeneral As Decimal = totalV1 + totalV2 + totalV3 + totalV4

                TextBoxTotal.Text = totalGeneral.ToString("C2", colon)

            ElseIf Not CheckBox5.Checked Then

                If CheckBox1.Checked Then
                    ComboBoxDestino1.Text = "TODOS"
                    Dim queryCantidadRecolectado1 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 1 AND Ventanillas.Fecha = @Fecha"

                    Dim cmdCantidad1 As New SqlCommand(queryCantidadRecolectado1, conect.Conectar())
                    cmdCantidad1.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                    Dim obtenerDato As Decimal = CInt(cmdCantidad1.ExecuteScalar())
                    Dim cantidadRecolectado As String = obtenerDato.ToString("C2", colon)
                    TotalRecolectado1.Text = cantidadRecolectado.ToString()
                    conect.Cerrar()
                    totalV1 = obtenerDato
                End If

                If CheckBox2.Checked Then
                    ComboBoxDestino2.Text = "TODOS"
                    Dim queryCantidadRecolectado2 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 2 AND Ventanillas.Fecha = @Fecha"

                    Dim cmdCantidad2 As New SqlCommand(queryCantidadRecolectado2, conect.Conectar())
                    cmdCantidad2.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                    Dim obtenerDato2 As Decimal = CInt(cmdCantidad2.ExecuteScalar())
                    Dim cantidadRecolectado2 As String = obtenerDato2.ToString("C2", colon)
                    TotalRecolectado2.Text = cantidadRecolectado2.ToString()
                    conect.Cerrar()
                    totalV2 = obtenerDato2
                End If

                If CheckBox3.Checked Then
                    ComboBoxDestino3.Text = "TODOS"
                    Dim queryCantidadRecolectado3 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 3 AND Ventanillas.Fecha = @Fecha"

                    Dim cmdCantidad3 As New SqlCommand(queryCantidadRecolectado3, conect.Conectar())
                    cmdCantidad3.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                    Dim obtenerDato3 As Decimal = CInt(cmdCantidad3.ExecuteScalar())
                    Dim cantidadRecolectado3 As String = obtenerDato3.ToString("C2", colon)
                    TotalRecolectado3.Text = cantidadRecolectado3.ToString()
                    conect.Cerrar()
                    totalV3 = obtenerDato3
                End If

                If CheckBox4.Checked Then
                    ComboBoxDestino4.Text = "TODOS"
                    Dim queryCantidadRecolectado4 As String = "SELECT SUM(p.precio)
                                        FROM TblPasajero as p
                                        INNER JOIN Ventanillas ON p.ID_Ventanilla = Ventanillas.Id_Proceso
                                        INNER JOIN TblVuelo ON p.ID_Vuelo = TblVuelo.IDVuelo
                                        WHERE Ventanillas.NumeroVentanilla = 4 AND Ventanillas.Fecha = @Fecha"

                    Dim cmdCantidad4 As New SqlCommand(queryCantidadRecolectado4, conect.Conectar())
                    cmdCantidad4.Parameters.AddWithValue("@Fecha", DateTimeVentanilla.Text)

                    Dim obtenerDato4 As Decimal = CInt(cmdCantidad4.ExecuteScalar())
                    Dim cantidadRecolectado4 As String = obtenerDato4.ToString("C2", colon)
                    TotalRecolectado4.Text = cantidadRecolectado4.ToString()
                    conect.Cerrar()
                    totalV4 = obtenerDato4
                End If

                Dim totalGeneral As Decimal = totalV1 + totalV2 + totalV3 + totalV4

                TextBoxTotal.Text = totalGeneral.ToString("C2", colon)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

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

        GroupBox2.Enabled = False
        ComboBoxDestino1.Items.Clear()
        ComboBoxDestino2.Items.Clear()
        ComboBoxDestino3.Items.Clear()
        ComboBoxDestino4.Items.Clear()

        ComboBoxDestino1.Text = ""
        ComboBoxDestino2.Text = ""
        ComboBoxDestino3.Text = ""
        ComboBoxDestino4.Text = ""

        TotalRecolectado1.Text = ""
        TotalRecolectado2.Text = ""
        TotalRecolectado3.Text = ""
        TotalRecolectado4.Text = ""

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        GroupBox2.Enabled = False
        ComboBoxDestino1.Items.Clear()
        ComboBoxDestino2.Items.Clear()
        ComboBoxDestino3.Items.Clear()
        ComboBoxDestino4.Items.Clear()

        ComboBoxDestino1.Text = ""
        ComboBoxDestino2.Text = ""
        ComboBoxDestino3.Text = ""
        ComboBoxDestino4.Text = ""

        TotalRecolectado1.Text = ""
        TotalRecolectado2.Text = ""
        TotalRecolectado3.Text = ""
        TotalRecolectado4.Text = ""
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        GroupBox2.Enabled = False
        ComboBoxDestino1.Items.Clear()
        ComboBoxDestino2.Items.Clear()
        ComboBoxDestino3.Items.Clear()
        ComboBoxDestino4.Items.Clear()

        ComboBoxDestino1.Text = ""
        ComboBoxDestino2.Text = ""
        ComboBoxDestino3.Text = ""
        ComboBoxDestino4.Text = ""

        TotalRecolectado1.Text = ""
        TotalRecolectado2.Text = ""
        TotalRecolectado3.Text = ""
        TotalRecolectado4.Text = ""
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        GroupBox2.Enabled = False
        ComboBoxDestino1.Items.Clear()
        ComboBoxDestino2.Items.Clear()
        ComboBoxDestino3.Items.Clear()
        ComboBoxDestino4.Items.Clear()

        ComboBoxDestino1.Text = ""
        ComboBoxDestino2.Text = ""
        ComboBoxDestino3.Text = ""
        ComboBoxDestino4.Text = ""

        TotalRecolectado1.Text = ""
        TotalRecolectado2.Text = ""
        TotalRecolectado3.Text = ""
        TotalRecolectado4.Text = ""
        'p
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        GroupBox2.Enabled = False
        ComboBoxDestino1.Items.Clear()
        ComboBoxDestino2.Items.Clear()
        ComboBoxDestino3.Items.Clear()
        ComboBoxDestino4.Items.Clear()

        ComboBoxDestino1.Text = ""
        ComboBoxDestino2.Text = ""
        ComboBoxDestino3.Text = ""
        ComboBoxDestino4.Text = ""

        TotalRecolectado1.Text = ""
        TotalRecolectado2.Text = ""
        TotalRecolectado3.Text = ""
        TotalRecolectado4.Text = ""
    End Sub
End Class