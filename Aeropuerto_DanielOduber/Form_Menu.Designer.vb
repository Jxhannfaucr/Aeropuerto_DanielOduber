<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_IngresarVentanilla = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aeropuerto Internacional"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dr: Daniel Oduber"
        '
        'btn_IngresarVentanilla
        '
        Me.btn_IngresarVentanilla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_IngresarVentanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IngresarVentanilla.Location = New System.Drawing.Point(382, 400)
        Me.btn_IngresarVentanilla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_IngresarVentanilla.Name = "btn_IngresarVentanilla"
        Me.btn_IngresarVentanilla.Size = New System.Drawing.Size(170, 72)
        Me.btn_IngresarVentanilla.TabIndex = 2
        Me.btn_IngresarVentanilla.Text = "Ventanillas"
        Me.btn_IngresarVentanilla.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(412, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 38)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ingresar:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(800, 49)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Aeropuerto_DanielOduber.My.Resources.Resources.WhatsApp_Image_2023_07_26_at_15_52_43_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(45, 51)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(183, 145)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aeropuerto_DanielOduber.My.Resources.Resources.taquilla
        Me.PictureBox1.Location = New System.Drawing.Point(413, 330)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1000, 588)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_IngresarVentanilla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_Menu"
        Me.Text = "Aeropuerto Daniel Oduber"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_IngresarVentanilla As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button2 As Button
End Class
