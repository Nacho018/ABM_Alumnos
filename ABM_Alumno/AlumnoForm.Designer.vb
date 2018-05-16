<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnoForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Apeliidonombre = New System.Windows.Forms.Label
        Me.Fechaydireccion = New System.Windows.Forms.Label
        Me.DNI = New System.Windows.Forms.Label
        Me.Edad = New System.Windows.Forms.Label
        Me.Mail = New System.Windows.Forms.Label
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(151, 145)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(151, 69)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(151, 213)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(140, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(151, 285)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(142, 20)
        Me.TextBox5.TabIndex = 4
        '
        'Apeliidonombre
        '
        Me.Apeliidonombre.AutoSize = True
        Me.Apeliidonombre.Location = New System.Drawing.Point(55, 35)
        Me.Apeliidonombre.Name = "Apeliidonombre"
        Me.Apeliidonombre.Size = New System.Drawing.Size(90, 13)
        Me.Apeliidonombre.TabIndex = 5
        Me.Apeliidonombre.Text = "Apeliido y nombre"
        '
        'Fechaydireccion
        '
        Me.Fechaydireccion.AutoSize = True
        Me.Fechaydireccion.Location = New System.Drawing.Point(52, 148)
        Me.Fechaydireccion.Name = "Fechaydireccion"
        Me.Fechaydireccion.Size = New System.Drawing.Size(85, 13)
        Me.Fechaydireccion.TabIndex = 6
        Me.Fechaydireccion.Text = "Fechaydireccion"
        '
        'DNI
        '
        Me.DNI.AutoSize = True
        Me.DNI.Location = New System.Drawing.Point(66, 76)
        Me.DNI.Name = "DNI"
        Me.DNI.Size = New System.Drawing.Size(26, 13)
        Me.DNI.TabIndex = 7
        Me.DNI.Text = "DNI"
        '
        'Edad
        '
        Me.Edad.AutoSize = True
        Me.Edad.Location = New System.Drawing.Point(81, 215)
        Me.Edad.Name = "Edad"
        Me.Edad.Size = New System.Drawing.Size(32, 13)
        Me.Edad.TabIndex = 8
        Me.Edad.Text = "Edad"
        '
        'Mail
        '
        Me.Mail.AutoSize = True
        Me.Mail.Location = New System.Drawing.Point(79, 285)
        Me.Mail.Name = "Mail"
        Me.Mail.Size = New System.Drawing.Size(26, 13)
        Me.Mail.TabIndex = 9
        Me.Mail.Text = "Mail"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(135, 348)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(87, 39)
        Me.Aceptar.TabIndex = 10
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(252, 348)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(87, 38)
        Me.Cancelar.TabIndex = 11
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'AlumnoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 411)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Mail)
        Me.Controls.Add(Me.Edad)
        Me.Controls.Add(Me.DNI)
        Me.Controls.Add(Me.Fechaydireccion)
        Me.Controls.Add(Me.Apeliidonombre)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "AlumnoForm"
        Me.Text = "AlumnoForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Apeliidonombre As System.Windows.Forms.Label
    Friend WithEvents Fechaydireccion As System.Windows.Forms.Label
    Friend WithEvents DNI As System.Windows.Forms.Label
    Friend WithEvents Edad As System.Windows.Forms.Label
    Friend WithEvents Mail As System.Windows.Forms.Label
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
End Class
