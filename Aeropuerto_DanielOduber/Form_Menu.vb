Imports System.Runtime.Remoting.Contexts

Public Class Form_Menu


    Private Sub btn_IngresarVentanilla_Click(sender As Object, e As EventArgs) Handles btn_IngresarVentanilla.Click
        Dim registro_Ventanillas As New Form_RegistroVentanillas
        registro_Ventanillas.Show()
        Me.Hide()
    End Sub
End Class
