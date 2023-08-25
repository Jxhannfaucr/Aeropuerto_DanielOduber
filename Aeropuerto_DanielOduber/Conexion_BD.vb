Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion_BD

    Private cn As New SqlConnection("Data Source=MSI;Initial Catalog=DBAeropuertoDanielOduber;Integrated Security=True")

    Public Function Conectar()
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cn
    End Function

    Public Sub Cerrar()
        Try
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
