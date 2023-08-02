Public Class Menu_Empleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim volver_login As New Login()
        volver_login.Show()
        Me.Close()
    End Sub

    Private Sub btn_ProcesarVentanilla_Click(sender As Object, e As EventArgs) Handles btn_ProcesarVentanilla.Click

    End Sub

    Private Sub Menu_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class