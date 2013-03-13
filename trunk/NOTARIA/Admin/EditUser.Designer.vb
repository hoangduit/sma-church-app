<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Me.QCompositeControl1 = New Qios.DevSuite.Components.QCompositeControl()
        Me.QCompositeGroup1 = New Qios.DevSuite.Components.QCompositeGroup()
        Me.QCompositeText1 = New Qios.DevSuite.Components.QCompositeText()
        Me.QCompositeGroup2 = New Qios.DevSuite.Components.QCompositeGroup()
        Me.QCompositeSeparator1 = New Qios.DevSuite.Components.QCompositeSeparator()
        Me.QCompositeGroup3 = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcbGuardar = New Qios.DevSuite.Components.QCompositeButton()
        Me.qcbDelete = New Qios.DevSuite.Components.QCompositeButton()
        Me.qcbCancelar = New Qios.DevSuite.Components.QCompositeButton()
        Me.qtbUser = New Qios.DevSuite.Components.QTextBox()
        Me.qtbPass = New Qios.DevSuite.Components.QTextBox()
        Me.qcbRol = New Qios.DevSuite.Components.QComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbUsuarios = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.QCompositeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QCompositeControl1
        '
        Me.QCompositeControl1.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.QCompositeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QCompositeControl1.Items.Add(Me.QCompositeGroup1)
        Me.QCompositeControl1.Items.Add(Me.QCompositeGroup2)
        Me.QCompositeControl1.Location = New System.Drawing.Point(0, 0)
        Me.QCompositeControl1.Name = "QCompositeControl1"
        Me.QCompositeControl1.Size = New System.Drawing.Size(577, 500)
        Me.QCompositeControl1.TabIndex = 0
        Me.QCompositeControl1.Text = "QCompositeControl1"
        '
        'QCompositeGroup1
        '
        Me.QCompositeGroup1.Configuration.StretchHorizontal = True
        Me.QCompositeGroup1.Items.Add(Me.QCompositeText1)
        '
        'QCompositeText1
        '
        Me.QCompositeText1.Configuration.FontDefinition = New Qios.DevSuite.Components.QFontDefinition("Gill Sans", True, False, False, False, 14.0!)
        Me.QCompositeText1.Title = "Cambiar un Usuario..."
        '
        'QCompositeGroup2
        '
        Me.QCompositeGroup2.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.QCompositeGroup2.Configuration.Margin = New Qios.DevSuite.Components.QMargin(0, 350, 0, 0)
        Me.QCompositeGroup2.Configuration.StretchHorizontal = True
        Me.QCompositeGroup2.Items.Add(Me.QCompositeSeparator1)
        Me.QCompositeGroup2.Items.Add(Me.QCompositeGroup3)
        '
        'QCompositeGroup3
        '
        Me.QCompositeGroup3.Configuration.StretchHorizontal = True
        Me.QCompositeGroup3.Items.Add(Me.qcbGuardar)
        Me.QCompositeGroup3.Items.Add(Me.qcbDelete)
        Me.QCompositeGroup3.Items.Add(Me.qcbCancelar)
        '
        'qcbGuardar
        '
        Me.qcbGuardar.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcbGuardar.Title = "Guardar"
        '
        'qcbDelete
        '
        Me.qcbDelete.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcbDelete.Title = "Eliminar"
        '
        'qcbCancelar
        '
        Me.qcbCancelar.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcbCancelar.Title = "Cancelar"
        '
        'qtbUser
        '
        Me.qtbUser.Location = New System.Drawing.Point(100, 45)
        Me.qtbUser.Name = "qtbUser"
        Me.qtbUser.Size = New System.Drawing.Size(194, 19)
        Me.qtbUser.TabIndex = 2
        '
        'qtbPass
        '
        Me.qtbPass.CueText = ""
        Me.qtbPass.Location = New System.Drawing.Point(100, 87)
        Me.qtbPass.Name = "qtbPass"
        Me.qtbPass.Size = New System.Drawing.Size(194, 19)
        Me.qtbPass.TabIndex = 3
        '
        'qcbRol
        '
        Me.qcbRol.CueText = "Selecciona un Rol"
        Me.qcbRol.Location = New System.Drawing.Point(100, 128)
        Me.qcbRol.Name = "qcbRol"
        Me.qcbRol.Size = New System.Drawing.Size(171, 19)
        Me.qcbRol.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(20, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(20, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(20, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rol:"
        '
        'lbUsuarios
        '
        Me.lbUsuarios.FormattingEnabled = True
        Me.lbUsuarios.Location = New System.Drawing.Point(29, 84)
        Me.lbUsuarios.Name = "lbUsuarios"
        Me.lbUsuarios.Size = New System.Drawing.Size(163, 264)
        Me.lbUsuarios.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.qtbUser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.qtbPass)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.qcbRol)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 264)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbUsuarios)
        Me.Controls.Add(Me.QCompositeControl1)
        Me.Name = "EditUser"
        Me.ShowIcon = False
        Me.Text = "Editar Usuarios"
        CType(Me.QCompositeControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QCompositeControl1 As Qios.DevSuite.Components.QCompositeControl
    Friend WithEvents QCompositeGroup1 As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents QCompositeText1 As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents qtbUser As Qios.DevSuite.Components.QTextBox
    Friend WithEvents qtbPass As Qios.DevSuite.Components.QTextBox
    Friend WithEvents qcbRol As Qios.DevSuite.Components.QComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents QCompositeGroup2 As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents QCompositeSeparator1 As Qios.DevSuite.Components.QCompositeSeparator
    Friend WithEvents QCompositeGroup3 As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcbGuardar As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents qcbCancelar As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents lbUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents qcbDelete As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
