<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RegistroVentanillas
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
        Me.btn_VolverMenu = New System.Windows.Forms.Button()
        Me.lb_conexion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_VolverMenu
        '
        Me.btn_VolverMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_VolverMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VolverMenu.Location = New System.Drawing.Point(726, 60)
        Me.btn_VolverMenu.Name = "btn_VolverMenu"
        Me.btn_VolverMenu.Size = New System.Drawing.Size(151, 58)
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
        'Form_RegistroVentanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(965, 470)
        Me.Controls.Add(Me.lb_conexion)
        Me.Controls.Add(Me.btn_VolverMenu)
        Me.Name = "Form_RegistroVentanillas"
        Me.Text = "Registro de ventanillas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_VolverMenu As Button
    Friend WithEvents lb_conexion As Label
End Class
