<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistroEmpleadoVentanilla
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxLinea_Aereas = New System.Windows.Forms.ComboBox()
        Me.TextBoxHoraApertura = New System.Windows.Forms.TextBox()
        Me.TextBoxCedula_Empl = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre_Emple = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxID_Ventanilla = New System.Windows.Forms.ComboBox()
        Me.BtnConfirmarVentanilla = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxLinea_Aereas)
        Me.GroupBox1.Controls.Add(Me.TextBoxHoraApertura)
        Me.GroupBox1.Controls.Add(Me.TextBoxCedula_Empl)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre_Emple)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxID_Ventanilla)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(446, 488)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de ventanillas"
        '
        'ComboBoxLinea_Aereas
        '
        Me.ComboBoxLinea_Aereas.FormattingEnabled = True
        Me.ComboBoxLinea_Aereas.Location = New System.Drawing.Point(272, 340)
        Me.ComboBoxLinea_Aereas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxLinea_Aereas.Name = "ComboBoxLinea_Aereas"
        Me.ComboBoxLinea_Aereas.Size = New System.Drawing.Size(136, 28)
        Me.ComboBoxLinea_Aereas.TabIndex = 21
        '
        'TextBoxHoraApertura
        '
        Me.TextBoxHoraApertura.Location = New System.Drawing.Point(272, 271)
        Me.TextBoxHoraApertura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxHoraApertura.Name = "TextBoxHoraApertura"
        Me.TextBoxHoraApertura.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxHoraApertura.TabIndex = 20
        '
        'TextBoxCedula_Empl
        '
        Me.TextBoxCedula_Empl.Location = New System.Drawing.Point(272, 205)
        Me.TextBoxCedula_Empl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxCedula_Empl.Name = "TextBoxCedula_Empl"
        Me.TextBoxCedula_Empl.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxCedula_Empl.TabIndex = 19
        '
        'TextBoxNombre_Emple
        '
        Me.TextBoxNombre_Emple.Location = New System.Drawing.Point(272, 136)
        Me.TextBoxNombre_Emple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNombre_Emple.Name = "TextBoxNombre_Emple"
        Me.TextBoxNombre_Emple.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxNombre_Emple.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Linea Aérea:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Hora Apertura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cédula Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese la ventanilla:"
        '
        'ComboBoxID_Ventanilla
        '
        Me.ComboBoxID_Ventanilla.FormattingEnabled = True
        Me.ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxID_Ventanilla.Location = New System.Drawing.Point(272, 59)
        Me.ComboBoxID_Ventanilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        Me.ComboBoxID_Ventanilla.Size = New System.Drawing.Size(136, 28)
        Me.ComboBoxID_Ventanilla.TabIndex = 11
        '
        'BtnConfirmarVentanilla
        '
        Me.BtnConfirmarVentanilla.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnConfirmarVentanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConfirmarVentanilla.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarVentanilla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnConfirmarVentanilla.Location = New System.Drawing.Point(507, 536)
        Me.BtnConfirmarVentanilla.Name = "BtnConfirmarVentanilla"
        Me.BtnConfirmarVentanilla.Size = New System.Drawing.Size(115, 46)
        Me.BtnConfirmarVentanilla.TabIndex = 14
        Me.BtnConfirmarVentanilla.Text = "Cofirmar"
        Me.BtnConfirmarVentanilla.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(507, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 41)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormRegistroEmpleadoVentanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(634, 600)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnConfirmarVentanilla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormRegistroEmpleadoVentanilla"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxLinea_Aereas As ComboBox
    Friend WithEvents TextBoxHoraApertura As TextBox
    Friend WithEvents TextBoxCedula_Empl As TextBox
    Friend WithEvents TextBoxNombre_Emple As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxID_Ventanilla As ComboBox
    Friend WithEvents BtnConfirmarVentanilla As Button
    Friend WithEvents Button1 As Button
End Class
