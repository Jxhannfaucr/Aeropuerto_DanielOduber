Public Class Menu_Empleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim volver_login As New Login()
        volver_login.Show()
        Me.Close()
    End Sub

    Private Sub btn_ProcesarVentanilla_Click(sender As Object, e As EventArgs) Handles btn_ProcesarVentanilla.Click
        Dim Part_informes As New Informes()
        Part_informes.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_IngresarAvion_Click(sender As Object, e As EventArgs) Handles btn_IngresarAvion.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Part_informes As New FormAgregarVuelo()
        Part_informes.Show()
        Me.Hide()
    End Sub
End Class