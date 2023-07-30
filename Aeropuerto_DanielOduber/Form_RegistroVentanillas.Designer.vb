<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_RegistroVentanillas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_VolverMenu = New System.Windows.Forms.Button()
        Me.lb_conexion = New System.Windows.Forms.Label()
        Me.ComboBoxID_Ventanilla = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxDestinos = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLinea_Aereas = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxCedula_Empl = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre_Emple = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_VolverMenu
        '
        Me.btn_VolverMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_VolverMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VolverMenu.Location = New System.Drawing.Point(1170, 26)
        Me.btn_VolverMenu.Name = "btn_VolverMenu"
        Me.btn_VolverMenu.Size = New System.Drawing.Size(120, 30)
        Me.btn_VolverMenu.TabIndex = 9
        Me.btn_VolverMenu.Text = "Menu"
        Me.btn_VolverMenu.UseVisualStyleBackColor = False
        '
        'lb_conexion
        '
        Me.lb_conexion.AutoSize = True
        Me.lb_conexion.Location = New System.Drawing.Point(12, 445)
        Me.lb_conexion.Name = "lb_conexion"
        Me.lb_conexion.Size = New System.Drawing.Size(269, 16)
        Me.lb_conexion.TabIndex = 10
        Me.lb_conexion.Text = "Conexion establecida con la base de datos."
        Me.lb_conexion.Visible = False
        '
        'ComboBoxID_Ventanilla
        '
        Me.ComboBoxID_Ventanilla.FormattingEnabled = True
        Me.ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxID_Ventanilla.Location = New System.Drawing.Point(242, 47)
        Me.ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        Me.ComboBoxID_Ventanilla.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxID_Ventanilla.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxDestinos)
        Me.GroupBox1.Controls.Add(Me.ComboBoxLinea_Aereas)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBoxCedula_Empl)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre_Emple)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxID_Ventanilla)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 390)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de ventanillas"
        '
        'ComboBoxDestinos
        '
        Me.ComboBoxDestinos.FormattingEnabled = True
        Me.ComboBoxDestinos.Location = New System.Drawing.Point(242, 326)
        Me.ComboBoxDestinos.Name = "ComboBoxDestinos"
        Me.ComboBoxDestinos.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxDestinos.TabIndex = 22
        '
        'ComboBoxLinea_Aereas
        '
        Me.ComboBoxLinea_Aereas.FormattingEnabled = True
        Me.ComboBoxLinea_Aereas.Location = New System.Drawing.Point(242, 272)
        Me.ComboBoxLinea_Aereas.Name = "ComboBoxLinea_Aereas"
        Me.ComboBoxLinea_Aereas.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxLinea_Aereas.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(242, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 22)
        Me.TextBox1.TabIndex = 20
        '
        'TextBoxCedula_Empl
        '
        Me.TextBoxCedula_Empl.Location = New System.Drawing.Point(242, 164)
        Me.TextBoxCedula_Empl.Name = "TextBoxCedula_Empl"
        Me.TextBoxCedula_Empl.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxCedula_Empl.TabIndex = 19
        '
        'TextBoxNombre_Emple
        '
        Me.TextBoxNombre_Emple.Location = New System.Drawing.Point(242, 109)
        Me.TextBoxNombre_Emple.Name = "TextBoxNombre_Emple"
        Me.TextBoxNombre_Emple.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxNombre_Emple.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Destino:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Linea Aérea:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Hora Apertura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cédula Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese la ventanilla:"
        '
        'Form_RegistroVentanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(993, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lb_conexion)
        Me.Controls.Add(Me.btn_VolverMenu)
        Me.Name = "Form_RegistroVentanillas"
        Me.Text = "Registro de ventanillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_VolverMenu As Button
    Friend WithEvents lb_conexion As Label
    Friend WithEvents ComboBoxID_Ventanilla As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCedula_Empl As TextBox
    Friend WithEvents TextBoxNombre_Emple As TextBox
    Friend WithEvents ComboBoxDestinos As ComboBox
    Friend WithEvents ComboBoxLinea_Aereas As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
