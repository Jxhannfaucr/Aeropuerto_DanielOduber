<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recoleccion_monetaria
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
        Me.BtnConfirmarVentanilla = New System.Windows.Forms.Button()
        Me.ComboBoxID_Ventanilla = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimeVentanilla = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxDestino = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TotalRecolectado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnConfirmarVentanilla
        '
        Me.BtnConfirmarVentanilla.Location = New System.Drawing.Point(162, 263)
        Me.BtnConfirmarVentanilla.Name = "BtnConfirmarVentanilla"
        Me.BtnConfirmarVentanilla.Size = New System.Drawing.Size(75, 23)
        Me.BtnConfirmarVentanilla.TabIndex = 0
        Me.BtnConfirmarVentanilla.Text = "Confimar"
        Me.BtnConfirmarVentanilla.UseVisualStyleBackColor = True
        '
        'ComboBoxID_Ventanilla
        '
        Me.ComboBoxID_Ventanilla.FormattingEnabled = True
        Me.ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxID_Ventanilla.Location = New System.Drawing.Point(128, 46)
        Me.ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        Me.ComboBoxID_Ventanilla.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxID_Ventanilla.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxID_Ventanilla)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmarVentanilla)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 316)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese la ventanilla"
        '
        'DateTimeVentanilla
        '
        Me.DateTimeVentanilla.Location = New System.Drawing.Point(124, 149)
        Me.DateTimeVentanilla.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimeVentanilla.Name = "DateTimeVentanilla"
        Me.DateTimeVentanilla.Size = New System.Drawing.Size(151, 20)
        Me.DateTimeVentanilla.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBoxDestino)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DateTimeVentanilla)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 316)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Seleccione la fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Seleccione el vuelo"
        '
        'ComboBoxDestino
        '
        Me.ComboBoxDestino.FormattingEnabled = True
        Me.ComboBoxDestino.Location = New System.Drawing.Point(153, 74)
        Me.ComboBoxDestino.Name = "ComboBoxDestino"
        Me.ComboBoxDestino.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDestino.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TotalRecolectado
        '
        Me.TotalRecolectado.Location = New System.Drawing.Point(620, 420)
        Me.TotalRecolectado.Name = "TotalRecolectado"
        Me.TotalRecolectado.Size = New System.Drawing.Size(100, 20)
        Me.TotalRecolectado.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(509, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Total recolectado"
        '
        'Recoleccion_monetaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(935, 646)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TotalRecolectado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Recoleccion_monetaria"
        Me.Text = "Recoleccion_monetaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConfirmarVentanilla As Button
    Friend WithEvents ComboBoxID_Ventanilla As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimeVentanilla As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxDestino As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TotalRecolectado As TextBox
    Friend WithEvents Label4 As Label
End Class
