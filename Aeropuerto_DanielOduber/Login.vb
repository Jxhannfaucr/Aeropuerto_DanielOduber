Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButtonAdmin.Checked = True
        Me.StartPosition = FormStartPosition.Manual ' Se establece la posición manualmente

        ' Se establece la posición inicial del formulario en las coordenadas deseadas
        Me.Location = New Point(650, 170) ' Aqui pusimos lo que fue la posicion inicial de la ventana login

        ComboBox1.Clear()
        contraseñalogin.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuario As String = ComboBox1.Text
        Dim contrasena As String = contraseñalogin.Text
        If RadioButtonAdmin.Checked Then
            If usuario.Equals("admin") AndAlso contrasena.Equals("admin123") Then

                Dim pasar_Al_Menu_admin As New Menu_Empleado()

                pasar_Al_Menu_admin.StartPosition = FormStartPosition.Manual ' Se establece la posición manualmente
                ' Se establece la posición inicial del formulario en las coordenadas deseadas
                pasar_Al_Menu_admin.Location = New Point(200, 170) ' Aqui pusimos lo que fue la posicion inicial de la ventana login
                pasar_Al_Menu_admin.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo nuevamente.")
            End If

        ElseIf RadioButtonEmpleado.Checked Then
            If usuario.Equals("empleado1") AndAlso contrasena.Equals("user123") Then
                Dim pasar_Al_Menu_usuario As New Form_Ventanilla1
                pasar_Al_Menu_usuario.Show()
                Me.Hide()

            ElseIf usuario.Equals("empleado2") AndAlso contrasena.Equals("user123") Then
                Dim pasar_Al_Menu_usuario As New Form_Ventanilla2
                pasar_Al_Menu_usuario.Show()
                Me.Hide()

            ElseIf usuario.Equals("empleado3") AndAlso contrasena.Equals("user123") Then
                Dim pasar_Al_Menu_usuario As New Form_Ventanilla3
                pasar_Al_Menu_usuario.Show()
                Me.Hide()

            ElseIf usuario.Equals("empleado4") AndAlso contrasena.Equals("user123") Then
                Dim pasar_Al_Menu_usuario As New Form_Ventanilla4
                pasar_Al_Menu_usuario.Show()
                Me.Hide()

            Else
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo nuevamente.")

            End If

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class