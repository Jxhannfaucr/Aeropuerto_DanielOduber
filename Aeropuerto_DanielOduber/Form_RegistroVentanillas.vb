Imports System.Data
Imports System.Data.SqlClient
Public Class Form_RegistroVentanillas
    Public conect As Conexion_BD = New Conexion_BD

    Private Sub Form_RegistroVentanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Conexion con la base de datos''
        conect.Conectar()
        lb_conexion.Visible = True
        conect.Cerrar()
    End Sub


    Private Sub btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles btn_VolverMenu.Click
        Form_Menu.Show()
        Me.Close()
    End Sub
End Class