<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstPreRegistros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrincipal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.inventoryIdLabel = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBorrarTodos = New System.Windows.Forms.Button()
        Me.btnCrearBautizo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pre-Registros"
        '
        'btnPrincipal
        '
        Me.btnPrincipal.Location = New System.Drawing.Point(117, 8)
        Me.btnPrincipal.Name = "btnPrincipal"
        Me.btnPrincipal.Size = New System.Drawing.Size(75, 23)
        Me.btnPrincipal.TabIndex = 5
        Me.btnPrincipal.Text = "Principal"
        Me.btnPrincipal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "&Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(966, 437)
        Me.DataGridView1.TabIndex = 32
        '
        'inventoryIdLabel
        '
        Me.inventoryIdLabel.Location = New System.Drawing.Point(717, 6)
        Me.inventoryIdLabel.Name = "inventoryIdLabel"
        Me.inventoryIdLabel.Size = New System.Drawing.Size(159, 20)
        Me.inventoryIdLabel.TabIndex = 33
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(295, 8)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 34
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(517, 8)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 35
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBorrarTodos
        '
        Me.btnBorrarTodos.Location = New System.Drawing.Point(598, 8)
        Me.btnBorrarTodos.Name = "btnBorrarTodos"
        Me.btnBorrarTodos.Size = New System.Drawing.Size(113, 23)
        Me.btnBorrarTodos.TabIndex = 36
        Me.btnBorrarTodos.Text = "Borrar &Todos"
        Me.btnBorrarTodos.UseVisualStyleBackColor = True
        '
        'btnCrearBautizo
        '
        Me.btnCrearBautizo.Location = New System.Drawing.Point(376, 8)
        Me.btnCrearBautizo.Name = "btnCrearBautizo"
        Me.btnCrearBautizo.Size = New System.Drawing.Size(109, 23)
        Me.btnCrearBautizo.TabIndex = 37
        Me.btnCrearBautizo.Text = "&Crear Bautizo"
        Me.btnCrearBautizo.UseVisualStyleBackColor = True
        '
        'LstPreRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 572)
        Me.Controls.Add(Me.btnCrearBautizo)
        Me.Controls.Add(Me.btnBorrarTodos)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.inventoryIdLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LstPreRegistros"
        Me.Text = "PreRegistro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrincipal As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents inventoryIdLabel As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnBorrarTodos As System.Windows.Forms.Button
    Friend WithEvents btnCrearBautizo As System.Windows.Forms.Button
End Class
