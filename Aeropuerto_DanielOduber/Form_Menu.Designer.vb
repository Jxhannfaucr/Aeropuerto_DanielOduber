﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btn_IngresarAvion = New System.Windows.Forms.Button()
        Me.btn_IngresarPasajero = New System.Windows.Forms.Button()
        Me.btn_ProcesarVentanilla = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aeropuerto Internacional"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dr: Daniel Oduber"
        '
        'btn_IngresarVentanilla
        '
        Me.btn_IngresarVentanilla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_IngresarVentanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IngresarVentanilla.Location = New System.Drawing.Point(86, 308)
        Me.btn_IngresarVentanilla.Name = "btn_IngresarVentanilla"
        Me.btn_IngresarVentanilla.Size = New System.Drawing.Size(151, 58)
        Me.btn_IngresarVentanilla.TabIndex = 2
        Me.btn_IngresarVentanilla.Text = "Ventanillas"
        Me.btn_IngresarVentanilla.UseVisualStyleBackColor = False
        '
        'btn_IngresarAvion
        '
        Me.btn_IngresarAvion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_IngresarAvion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IngresarAvion.Location = New System.Drawing.Point(300, 308)
        Me.btn_IngresarAvion.Name = "btn_IngresarAvion"
        Me.btn_IngresarAvion.Size = New System.Drawing.Size(151, 58)
        Me.btn_IngresarAvion.TabIndex = 4
        Me.btn_IngresarAvion.Text = "Avion"
        Me.btn_IngresarAvion.UseVisualStyleBackColor = False
        '
        'btn_IngresarPasajero
        '
        Me.btn_IngresarPasajero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_IngresarPasajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IngresarPasajero.Location = New System.Drawing.Point(515, 308)
        Me.btn_IngresarPasajero.Name = "btn_IngresarPasajero"
        Me.btn_IngresarPasajero.Size = New System.Drawing.Size(151, 58)
        Me.btn_IngresarPasajero.TabIndex = 6
        Me.btn_IngresarPasajero.Text = "Pasajero"
        Me.btn_IngresarPasajero.UseVisualStyleBackColor = False
        '
        'btn_ProcesarVentanilla
        '
        Me.btn_ProcesarVentanilla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_ProcesarVentanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProcesarVentanilla.Location = New System.Drawing.Point(726, 308)
        Me.btn_ProcesarVentanilla.Name = "btn_ProcesarVentanilla"
        Me.btn_ProcesarVentanilla.Size = New System.Drawing.Size(151, 58)
        Me.btn_ProcesarVentanilla.TabIndex = 8
        Me.btn_ProcesarVentanilla.Text = "Procesar Ventanilla"
        Me.btn_ProcesarVentanilla.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(430, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ingresar:"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Aeropuerto_DanielOduber.My.Resources.Resources.WhatsApp_Image_2023_07_26_at_15_52_43_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(75, 41)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(162, 116)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Aeropuerto_DanielOduber.My.Resources.Resources.procesamiento_de_datos
        Me.PictureBox4.Location = New System.Drawing.Point(752, 252)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Aeropuerto_DanielOduber.My.Resources.Resources.turista
        Me.PictureBox3.Location = New System.Drawing.Point(541, 252)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aeropuerto_DanielOduber.My.Resources.Resources.avion_de_linea
        Me.PictureBox2.Location = New System.Drawing.Point(326, 252)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aeropuerto_DanielOduber.My.Resources.Resources.taquilla
        Me.PictureBox1.Location = New System.Drawing.Point(112, 252)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(965, 470)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btn_ProcesarVentanilla)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_IngresarPasajero)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_IngresarAvion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_IngresarVentanilla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Menu"
        Me.Text = "Aeropuerto Daniel Oduber"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_IngresarVentanilla As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_IngresarAvion As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_IngresarPasajero As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_ProcesarVentanilla As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
