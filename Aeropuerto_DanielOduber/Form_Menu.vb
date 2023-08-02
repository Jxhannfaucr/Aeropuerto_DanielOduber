Imports System.Runtime.Remoting.Contexts

Public Class Form_Menu


    Private Sub btn_IngresarVentanilla_Click(sender As Object, e As EventArgs) Handles btn_IngresarVentanilla.Click
        Dim registroEmpeladoVentanillas As New FormRegistroEmpleadoVentanilla
        registroEmpeladoVentanillas.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim volver_login As New Login()
        volver_login.Show()
        Me.Close()
    End Sub


End Class
