Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Runtime.Remoting.Contexts

Public Class FormAgregarVuelo
    Public conect As Conexion_BD = New Conexion_BD
    Dim Id_aviones As DataTable = New DataTable


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Try
            Dim avion_seleccionado As Integer = ComboBoxid_avion.SelectedIndex

            If avion_seleccionado >= 0 AndAlso avion_seleccionado < Id_aviones.Rows.Count Then
                Dim filaSeleccionada As DataRow = Id_aviones.Rows(avion_seleccionado)
                Dim IDAvion As Integer = Integer.Parse(filaSeleccionada("IDAvion"))
                Dim insertar As String = "insert into TblVuelo (Origen, Destino, HoraSalida, HoraLlegada, NumeroVentanilla, Escala, ID_Avion, Precio, fechaSalida) values
                                                                  (@Origen, @Destino, @HoraSalida, @HoraLlegada, @NumeroVentanilla, @Escala, @ID_Avion,  @Precio, @fechaSalida)"
                Dim cmdInsert As SqlCommand = New SqlCommand(insertar, conect.Conectar())
                cmdInsert.Parameters.AddWithValue("@Origen", ComboBoxorigen.SelectedItem.ToString)
                cmdInsert.Parameters.AddWithValue("@Destino", TextBoxDestino.Text)
                cmdInsert.Parameters.AddWithValue("@HoraSalida", TextBoxHoraSalida.Text)
                cmdInsert.Parameters.AddWithValue("@HoraLlegada", TextBoxHoraLlegada.Text)
                cmdInsert.Parameters.AddWithValue("@NumeroVentanilla", ComboBoxnumeroventanilla.SelectedItem)
                cmdInsert.Parameters.AddWithValue("@Escala", ComboBoxescala.SelectedItem)
                cmdInsert.Parameters.AddWithValue("@ID_Avion", IDAvion)
                cmdInsert.Parameters.AddWithValue("@Precio", SqlMoney.Parse(TextBoxPrecio.Text))
                cmdInsert.Parameters.AddWithValue("@fechaSalida", DateTimeSalida.Text)
                cmdInsert.ExecuteNonQuery()
                conect.Cerrar()
                MessageBox.Show("Datos guardados exitosamente")
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al manejar la entrada del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

    Private Sub TextBoxEscala_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub ComboBoxescala_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxescala.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            ' Si no es una letra, un espacio ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxnumeroventanilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxnumeroventanilla.SelectedIndexChanged
        verificar()
        ComboBoxnumeroventanilla.Text = ""
        If ComboBoxnumeroventanilla.SelectedItem = 1 Then

            Dim querys As String = "select IDAvion, Marca from TblAvion
                                    where LineaAerea = 'American Airlines'"

            Id_aviones.Reset()
            Dim M As SqlCommand = New SqlCommand(querys, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(Id_aviones)
            conect.Cerrar()

            ComboBoxid_avion.Items.Clear()

            For Each row As DataRow In Id_aviones.Rows
                ComboBoxid_avion.Items.Add(row("Marca"))
            Next
            conect.Cerrar()

        ElseIf ComboBoxnumeroventanilla.SelectedItem = 2 Then

            Dim querys As String = "select IDAvion, Marca from TblAvion
                                    where LineaAerea = 'British Airways'"

            Id_aviones.Reset()
            Dim M As SqlCommand = New SqlCommand(querys, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(Id_aviones)
            conect.Cerrar()

            ComboBoxid_avion.Items.Clear()

            For Each row As DataRow In Id_aviones.Rows
                ComboBoxid_avion.Items.Add(row("Marca"))
            Next
            conect.Cerrar()

        ElseIf ComboBoxnumeroventanilla.SelectedItem = 3 Then

            Dim querys As String = "select IDAvion, Marca from TblAvion
                                    where LineaAerea = 'Emirates'"

            Id_aviones.Reset()
            Dim M As SqlCommand = New SqlCommand(querys, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(Id_aviones)
            conect.Cerrar()

            ComboBoxid_avion.Items.Clear()

            For Each row As DataRow In Id_aviones.Rows
                ComboBoxid_avion.Items.Add(row("Marca"))
            Next
            conect.Cerrar()

        ElseIf ComboBoxnumeroventanilla.SelectedItem = 4 Then

            Dim querys As String = "select IDAvion, Marca from TblAvion
                                    where LineaAerea = 'Delta Air Lines'"

            Id_aviones.Reset()
            Dim M As SqlCommand = New SqlCommand(querys, conect.Conectar())
            Dim da As SqlDataAdapter = New SqlDataAdapter(M)
            da.Fill(Id_aviones)
            conect.Cerrar()

            ComboBoxid_avion.Items.Clear()

            For Each row As DataRow In Id_aviones.Rows
                ComboBoxid_avion.Items.Add(row("Marca"))
            Next
            conect.Cerrar()

        End If
    End Sub

    Private Sub GroupBoxOrigen_Enter(sender As Object, e As EventArgs) Handles GroupBoxOrigen.Enter
        BtnAgregar.Enabled = False
    End Sub

    Private Sub verificar()
        If Not String.IsNullOrEmpty(ComboBoxorigen.Text) AndAlso Not String.IsNullOrEmpty(TextBoxDestino.Text) AndAlso Not String.IsNullOrEmpty(TextBoxHoraSalida.Text.ToString) AndAlso Not String.IsNullOrEmpty(TextBoxHoraSalida.Text) AndAlso Not String.IsNullOrEmpty(TextBoxHoraLlegada.Text) AndAlso Not String.IsNullOrEmpty(ComboBoxnumeroventanilla.Text) AndAlso Not String.IsNullOrEmpty(ComboBoxescala.Text) AndAlso Not String.IsNullOrEmpty(ComboBoxid_avion.Text) AndAlso Not String.IsNullOrEmpty(TextBoxPrecio.Text) Then

            BtnAgregar.Enabled = True
        Else
            BtnAgregar.Enabled = False
        End If
    End Sub
    Private Sub ComboBoxorigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxorigen.SelectedIndexChanged
        verificar()
    End Sub

    Private Sub TextBoxDestino_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDestino.TextChanged

        verificar()
    End Sub

    Private Sub TextBoxHoraSalida_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHoraSalida.TextChanged
        verificar()
    End Sub

    Private Sub TextBoxHoraLlegada_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHoraLlegada.TextChanged
        verificar()
    End Sub

    Private Sub ComboBoxescala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxescala.SelectedIndexChanged
        verificar()
    End Sub

    Private Sub ComboBoxid_avion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxid_avion.SelectedIndexChanged
        verificar()
    End Sub

    Private Sub TextBoxPrecio_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecio.TextChanged
        verificar()
    End Sub
End Class