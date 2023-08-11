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

End Class