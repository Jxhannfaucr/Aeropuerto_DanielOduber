Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual ' Se establece la posición manualmente

        ' Se establece la posición inicial del formulario en las coordenadas deseadas
        Me.Location = New Point(650, 170) ' Aqui pusimos lo que fue la posicion inicial de la ventana login
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuario As String = UsuarioIngreso.Text
        Dim contrasena As String = contraseñalogin.Text

        If usuario.Equals("admin") AndAlso contrasena.Equals("johan_gay") Then

            Dim pasar_Al_Menu_admin As New Menu_Empleado()

            pasar_Al_Menu_admin.StartPosition = FormStartPosition.Manual ' Se establece la posición manualmente
            ' Se establece la posición inicial del formulario en las coordenadas deseadas
            pasar_Al_Menu_admin.Location = New Point(200, 170) ' Aqui pusimos lo que fue la posicion inicial de la ventana login
            pasar_Al_Menu_admin.Show()
            Me.Hide()

        ElseIf usuario.Equals("usuario") AndAlso contrasena.Equals("yosiney_Guapo") Then
            Dim pasar_Al_Menu_usuario As New Form_Menu()

            pasar_Al_Menu_usuario.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo nuevamente.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class