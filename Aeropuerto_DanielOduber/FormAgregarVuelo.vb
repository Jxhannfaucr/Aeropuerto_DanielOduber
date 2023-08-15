Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Runtime.Remoting.Contexts

Public Class FormAgregarVuelo
    Public conect As Conexion_BD = New Conexion_BD
    Dim Id_aviones As DataTable = New DataTable
    Private Sub ActivarBtnAgregar()

    End Sub

    Private Sub TextBoxOrigen_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub

    Private Sub TextBoxDestino_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub

    Private Sub TextBoxHoraSalida_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub

    Private Sub TextBoxHoraLlegada_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxnumeroventanilla.SelectedIndexChanged
        ActivarBtnAgregar()
    End Sub

    Private Sub TextBoxEscala_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub

    Private Sub TextBoxPrecio_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxorigen.SelectedIndexChanged
        ActivarBtnAgregar()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Try
            Dim insertar As String = "insert into TblVuelo (Origen, Destino, HoraSalida, HoraLlegada, NumeroVentanilla, Escala, ID_Avion, Precio, fechaSalida) values
                                                                  (@Origen, @Destino, @HoraSalida, @HoraLlegada, @NumeroVentanilla, @Escala, @ID_Avion,  @Precio, @fechaSalida)"
            Dim cmdInsert As SqlCommand = New SqlCommand(insertar, conect.Conectar())
            cmdInsert.Parameters.AddWithValue("@Origen", ComboBoxorigen.SelectedItem.ToString)
            cmdInsert.Parameters.AddWithValue("@Destino", TextBoxDestino.Text)
            cmdInsert.Parameters.AddWithValue("@HoraSalida", TextBoxHoraSalida.Text)
            cmdInsert.Parameters.AddWithValue("@HoraLlegada", TextBoxHoraLlegada.Text)
            cmdInsert.Parameters.AddWithValue("@NumeroVentanilla", ComboBoxnumeroventanilla.SelectedItem)
            cmdInsert.Parameters.AddWithValue("@Escala", TextBoxEscala.Text)
            cmdInsert.Parameters.AddWithValue("@ID_Avion", ComboBoxid_avion.Text)
            cmdInsert.Parameters.AddWithValue("@Precio", SqlMoney.Parse(TextBoxPrecio.Text))
            cmdInsert.Parameters.AddWithValue("@fechaSalida", DateTimeSalida.Text)
            cmdInsert.ExecuteNonQuery()
            conect.Cerrar()
            MessageBox.Show("Datos guardados exitosamente")
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al manejar la entrada del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FormAgregarVuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Id_aviones.Reset()
        Dim consulta As String = "SELECT * FROM TblAvion"
        Dim M As SqlCommand = New SqlCommand(consulta, conect.Conectar())
        Dim da As SqlDataAdapter = New SqlDataAdapter(M)
        da.Fill(Id_aviones)
        conect.Cerrar()

        ComboBoxid_avion.Items.Clear()

        For Each row As DataRow In Id_aviones.Rows
            ComboBoxid_avion.Items.Add(row("IDAvion"))
        Next
        conect.Cerrar()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeSalida.ValueChanged
        ActivarBtnAgregar()
    End Sub



    '---------------------------------------------------
    ' En esta parte creamos lo que son las validaciones
    '---------------------------------------------------

    Private Sub ComboBoxorigen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxorigen.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            ' Si no es una letra, un espacio ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDestino.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            ' Si no es una letra, un espacio ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHoraSalida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHoraSalida.KeyPress
        ' Verificar si el carácter ingresado es un dígito numérico, el carácter ":" o una tecla de control (por ejemplo, retroceso)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ":" AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un dígito numérico, el carácter ":" ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHoraLlegada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHoraLlegada.KeyPress
        ' Verificar si el carácter ingresado es un dígito numérico, el carácter ":" o una tecla de control (por ejemplo, retroceso)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ":" AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un dígito numérico, el carácter ":" ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxnumeroventanilla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxnumeroventanilla.KeyPress
        ' Cancelar el evento KeyPress para evitar cualquier entrada de teclado
        e.Handled = True
    End Sub

    Private Sub TextBoxEscala_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEscala.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            ' Si no es una letra, un espacio ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxid_avion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxid_avion.KeyPress
        ' Cancelar el evento KeyPress para evitar cualquier entrada de teclado
        e.Handled = True
    End Sub

    Private Sub TextBoxPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrecio.KeyPress
        ' Verificar si el carácter ingresado es un dígito numérico, el carácter ":" o una tecla de control (por ejemplo, retroceso)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ":" AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un dígito numérico, el carácter ":" ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimeSalida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimeSalida.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim volver_menu As New Menu_Empleado()
        volver_menu.Show()
        Me.Close()
    End Sub
End Class