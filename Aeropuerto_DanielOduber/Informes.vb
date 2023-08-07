Public Class Informes
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Cantidad_Vuelos As New Cant_vuelos
        Cantidad_Vuelos.Show()
        Me.Hide()
    End Sub
End Class