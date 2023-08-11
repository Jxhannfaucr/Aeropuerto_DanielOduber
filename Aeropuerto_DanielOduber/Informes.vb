Public Class Informes
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Cantidad_Vuelos As New Cant_vuelos
        Cantidad_Vuelos.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim volver_Menu_empleado As New Menu_Empleado()
        volver_Menu_empleado.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Cantidad_Vuelos As New Informe_cant_personas
        Cantidad_Vuelos.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim Cantidad_Vuelos As New Pasajeros_llegados
        Cantidad_Vuelos.Show()
        Me.Hide()
    End Sub
End Class