Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Runtime.Remoting.Contexts

Public Class Agregar_Avion
    Public conect As Conexion_BD = New Conexion_BD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim insertar As String = "insert into TblAvion (Marca, LineaAerea, Capacidad, NombrePiloto) values
                                                                  (@Marca, @LineaAerea, @Capacidad, @NombrePiloto)"
            Dim cmdInsert As SqlCommand = New SqlCommand(insertar, conect.Conectar())
            cmdInsert.Parameters.AddWithValue("@Marca", TextBoxmarca.Text)
            cmdInsert.Parameters.AddWithValue("@LineaAerea", TextBoxlinea.SelectedItem)
            cmdInsert.Parameters.AddWithValue("@Capacidad", TextBoxcapacidad.Text)
            cmdInsert.Parameters.AddWithValue("@NombrePiloto", TextBoxnombre_piloto.Text)
            cmdInsert.ExecuteNonQuery()
            conect.Cerrar()
            MessageBox.Show("Datos guardados exitosamente")
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al manejar la entrada de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBoxlinea_KeyPress(sender As Object, e As KeyPressEventArgs) 
        ' Verificar si el carácter ingresado es una letra, un espacio o una tecla de control (por ejemplo, retroceso)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            ' Si no es una letra, un espacio ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxmarca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxmarca.TextChanged
        Dim text As String = TextBoxmarca.Text

        ' Verificar si el texto contiene caracteres no permitidos
        For Each c As Char In text
            If Not Char.IsLetterOrDigit(c) AndAlso Not Char.IsWhiteSpace(c) Then
                ' Eliminar el carácter no permitido del TextBox
                TextBoxmarca.Text = TextBoxmarca.Text.Replace(c, "")
                TextBoxmarca.SelectionStart = TextBoxmarca.Text.Length ' Colocar el cursor al final del texto
            End If
        Next
    End Sub

    Private Sub TextBoxcapacidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxcapacidad.KeyPress
        ' Verificar si el carácter ingresado es un dígito numérico o una tecla de control (por ejemplo, retroceso)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un dígito numérico ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxnombre_piloto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxnombre_piloto.KeyPress
        ' Verificar si el carácter ingresado es una letra, un espacio o una tecla de control (por ejemplo, retroceso)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            ' Si no es una letra, un espacio ni una tecla de control, se cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim volver_login As New Menu_Empleado()
        volver_login.Show()
        Me.Close()
    End Sub

End Class