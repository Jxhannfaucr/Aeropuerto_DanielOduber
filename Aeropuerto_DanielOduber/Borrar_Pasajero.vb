Imports System.Security.Cryptography

Public Class Borrar_Pasajero

    Private _tablaVuelos As DataTable
    Public Property TablaVuelos() As DataTable
        Get
            Return _tablaVuelos
        End Get
        Set(ByVal value As DataTable)
            _tablaVuelos = value
        End Set
    End Property
    Private Sub Borrar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each row As DataRow In _tablaVuelos.Rows
            ComboBoxDestino.Items.Add(row("Destino"))
        Next
    End Sub
End Class