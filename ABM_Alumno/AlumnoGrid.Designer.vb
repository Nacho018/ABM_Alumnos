<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnoGrid
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.nuevo = New System.Windows.Forms.Button
        Me.Modificar = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Salir = New System.Windows.Forms.Button
        Me.AlumnoCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NyaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NyaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.NacimientoDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnoCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(45, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(545, 139)
        Me.DataGridView1.TabIndex = 0
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(101, 212)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(67, 30)
        Me.nuevo.TabIndex = 1
        Me.nuevo.Text = "nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(384, 212)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(159, 32)
        Me.Modificar.TabIndex = 2
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(101, 311)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(122, 25)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(401, 321)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(127, 27)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'AlumnoCollectionBindingSource
        '
        Me.AlumnoCollectionBindingSource.DataSource = GetType(ABM_Alumnos.AlumnoCollection)
        '
        'NyaDataGridViewTextBoxColumn
        '
        Me.NyaDataGridViewTextBoxColumn.DataPropertyName = "nya"
        Me.NyaDataGridViewTextBoxColumn.HeaderText = "nya"
        Me.NyaDataGridViewTextBoxColumn.Name = "NyaDataGridViewTextBoxColumn"
        Me.NyaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NacimientoDataGridViewTextBoxColumn
        '
        Me.NacimientoDataGridViewTextBoxColumn.DataPropertyName = "nacimiento"
        Me.NacimientoDataGridViewTextBoxColumn.HeaderText = "nacimiento"
        Me.NacimientoDataGridViewTextBoxColumn.Name = "NacimientoDataGridViewTextBoxColumn"
        Me.NacimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlumnoGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 440)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AlumnoGrid"
        Me.Text = "AlumnoGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents NyaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlumnoCollectionBindingSource As System.Windows.Forms.BindingSource
End Class
