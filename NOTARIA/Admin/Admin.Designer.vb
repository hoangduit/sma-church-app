<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnconf = New System.Windows.Forms.Button()
        Me.btnroles = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 21)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(95, 23)
        Me.btnUsuarios.TabIndex = 2
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 118)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(95, 23)
        Me.btnInicio.TabIndex = 3
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnconf
        '
        Me.btnconf.Location = New System.Drawing.Point(12, 89)
        Me.btnconf.Name = "btnconf"
        Me.btnconf.Size = New System.Drawing.Size(95, 23)
        Me.btnconf.TabIndex = 4
        Me.btnconf.Text = "Configuración"
        Me.btnconf.UseVisualStyleBackColor = True
        '
        'btnroles
        '
        Me.btnroles.Location = New System.Drawing.Point(12, 50)
        Me.btnroles.Name = "btnroles"
        Me.btnroles.Size = New System.Drawing.Size(95, 23)
        Me.btnroles.TabIndex = 5
        Me.btnroles.Text = "Roles"
        Me.btnroles.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 262)
        Me.Controls.Add(Me.btnroles)
        Me.Controls.Add(Me.btnconf)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnconf As System.Windows.Forms.Button
    Friend WithEvents btnroles As System.Windows.Forms.Button
End Class
