<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCantidadVuelos = New System.Windows.Forms.Label()
        Me.lblDestinosAtendidos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(511, 368)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCantidadVuelos
        '
        Me.lblCantidadVuelos.AutoSize = True
        Me.lblCantidadVuelos.Location = New System.Drawing.Point(154, 328)
        Me.lblCantidadVuelos.Name = "lblCantidadVuelos"
        Me.lblCantidadVuelos.Size = New System.Drawing.Size(39, 13)
        Me.lblCantidadVuelos.TabIndex = 1
        Me.lblCantidadVuelos.Text = "Label1"
        '
        'lblDestinosAtendidos
        '
        Me.lblDestinosAtendidos.AutoSize = True
        Me.lblDestinosAtendidos.Location = New System.Drawing.Point(154, 384)
        Me.lblDestinosAtendidos.Name = "lblDestinosAtendidos"
        Me.lblDestinosAtendidos.Size = New System.Drawing.Size(39, 13)
        Me.lblDestinosAtendidos.TabIndex = 2
        Me.lblDestinosAtendidos.Text = "Label2"
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 500)
        Me.Controls.Add(Me.lblDestinosAtendidos)
        Me.Controls.Add(Me.lblCantidadVuelos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "Informes"
        Me.Text = "Informes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCantidadVuelos As Label
    Friend WithEvents lblDestinosAtendidos As Label
End Class
