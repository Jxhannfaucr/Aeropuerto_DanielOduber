<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.contraseñalogin = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButtonAdmin = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEmpleado = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 304)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 371)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'contraseñalogin
        '
        Me.contraseñalogin.Location = New System.Drawing.Point(81, 409)
        Me.contraseñalogin.Margin = New System.Windows.Forms.Padding(4)
        Me.contraseñalogin.Name = "contraseñalogin"
        Me.contraseñalogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseñalogin.Size = New System.Drawing.Size(176, 22)
        Me.contraseñalogin.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(93, 459)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RadioButtonAdmin
        '
        Me.RadioButtonAdmin.AutoSize = True
        Me.RadioButtonAdmin.Location = New System.Drawing.Point(43, 257)
        Me.RadioButtonAdmin.Name = "RadioButtonAdmin"
        Me.RadioButtonAdmin.Size = New System.Drawing.Size(71, 20)
        Me.RadioButtonAdmin.TabIndex = 8
        Me.RadioButtonAdmin.TabStop = True
        Me.RadioButtonAdmin.Text = "ADMIN"
        Me.RadioButtonAdmin.UseVisualStyleBackColor = True
        '
        'RadioButtonEmpleado
        '
        Me.RadioButtonEmpleado.AutoSize = True
        Me.RadioButtonEmpleado.Location = New System.Drawing.Point(195, 257)
        Me.RadioButtonEmpleado.Name = "RadioButtonEmpleado"
        Me.RadioButtonEmpleado.Size = New System.Drawing.Size(102, 20)
        Me.RadioButtonEmpleado.TabIndex = 9
        Me.RadioButtonEmpleado.TabStop = True
        Me.RadioButtonEmpleado.Text = "EMPLEADO"
        Me.RadioButtonEmpleado.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(81, 345)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 22)
        Me.ComboBox1.TabIndex = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(350, 574)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButtonEmpleado)
        Me.Controls.Add(Me.RadioButtonAdmin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.contraseñalogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents contraseñalogin As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButtonAdmin As RadioButton
    Friend WithEvents RadioButtonEmpleado As RadioButton
    Friend WithEvents ComboBox1 As TextBox
End Class
