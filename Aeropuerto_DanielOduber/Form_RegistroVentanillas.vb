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

    Private Sub ComboBoxID_Ventanilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxID_Ventanilla.SelectedIndexChanged
        Dim seleccionado = ComboBoxID_Ventanilla.SelectedItem.ToString

        If seleccionado = 1 Then
            ''Limpia el comboBox
            ComboBoxLinea_Aereas.Items.Clear()
            ComboBoxDestinos.Items.Clear()
            ''Agrega las aerolineas dependiendo de la ventanilla que se ingreso
            ComboBoxLinea_Aereas.Items.Add("American Airlines")
            ComboBoxLinea_Aereas.Items.Add("Qantas")
            ''Agrega los destinos dependiendo de la ventanilla que se ingreso
            ComboBoxDestinos.Items.Add("Guatemala")
            ComboBoxDestinos.Items.Add("Estados Unidos")
            ComboBoxDestinos.Items.Add("Canadá")

        ElseIf seleccionado = 2 Then
            ''Agrega las aerolineas dependiendo de la ventanilla que se ingreso
            ComboBoxLinea_Aereas.Items.Clear()
            ComboBoxLinea_Aereas.Items.Add("British Airways")
            ComboBoxLinea_Aereas.Items.Add("Air France")
            ''Agrega los destinos dependiendo de la ventanilla que se ingreso
            ComboBoxDestinos.Items.Clear()
            ComboBoxDestinos.Items.Add("Argentina")
            ComboBoxDestinos.Items.Add("Colombia")
            ComboBoxDestinos.Items.Add("Japón")

        ElseIf seleccionado = 3 Then
            ''Agrega las aerolineas dependiendo de la ventanilla que se ingreso
            ComboBoxLinea_Aereas.Items.Clear()
            ComboBoxLinea_Aereas.Items.Add("Emirates")
            ComboBoxLinea_Aereas.Items.Add("Singapore Airlines")
            ''Agrega los destinos dependiendo de la ventanilla que se ingreso
            ComboBoxDestinos.Items.Clear()
            ComboBoxDestinos.Items.Add("España")
            ComboBoxDestinos.Items.Add("Venezuela")
            ComboBoxDestinos.Items.Add("Suecia")


        ElseIf seleccionado = 4 Then
            ''Agrega las aerolineas dependiendo de la ventanilla que se ingreso
            ComboBoxLinea_Aereas.Items.Clear()
            ComboBoxLinea_Aereas.Items.Add("Lufthansa")
            ComboBoxLinea_Aereas.Items.Add("Delta Air Lines")
            ''Agrega los destinos dependiendo de la ventanilla que se ingreso
            ComboBoxDestinos.Items.Clear()
            ComboBoxDestinos.Items.Add("Rusia")
            ComboBoxDestinos.Items.Add("Ucrania")
            ComboBoxDestinos.Items.Add("Brasil")
        End If

    End Sub
End Class