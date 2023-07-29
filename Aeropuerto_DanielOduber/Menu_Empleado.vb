Public Class Menu_Empleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim volver_login As New Login()
        volver_login.Show()
        Me.Close()
    End Sub
End Class