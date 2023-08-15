Public Class FormAgregarVuelo
    Private Sub FormAgregarVuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnAgregar.Enabled = False
    End Sub
    Private Sub ActivarBtnAgregar()
        If Not String.IsNullOrEmpty(ComboBox2.Text) AndAlso Not String.IsNullOrEmpty(TextBoxDestino.Text) AndAlso Not String.IsNullOrEmpty(TextBoxHoraLlegada.Text) AndAlso Not String.IsNullOrEmpty(TextBoxHoraSalida.Text) AndAlso Not String.IsNullOrEmpty(ComboBox1.Text) AndAlso Not String.IsNullOrEmpty(TextBoxEscala.Text) AndAlso String.IsNullOrEmpty(TextBoxPrecio.Text) Then
            BtnAgregar.Enabled = True
        Else
            BtnAgregar.Enabled = False
        End If
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ActivarBtnAgregar()
    End Sub

    Private Sub TextBoxEscala_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub

    Private Sub TextBoxPrecio_TextChanged(sender As Object, e As EventArgs)
        ActivarBtnAgregar()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ActivarBtnAgregar()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

    End Sub
End Class