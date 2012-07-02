<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerfilCuenta
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
        Me.qccMainPerfil = New Qios.DevSuite.Components.QCompositeControl()
        Me.qcgHeader = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctTitle = New Qios.DevSuite.Components.QCompositeText()
        Me.QCompositeSeparator1 = New Qios.DevSuite.Components.QCompositeSeparator()
        Me.qcgForm = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcgPerfil = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctPerfil = New Qios.DevSuite.Components.QCompositeText()
        Me.qcibPerfil = New Qios.DevSuite.Components.QCompositeItemInputBox()
        Me.qcgActions = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcbGuardar = New Qios.DevSuite.Components.QCompositeButton()
        Me.qcbCancelar = New Qios.DevSuite.Components.QCompositeButton()
        Me.dgvApplication = New System.Windows.Forms.DataGridView()
        Me.QCompositeSeparator2 = New Qios.DevSuite.Components.QCompositeSeparator()
        CType(Me.qccMainPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'qccMainPerfil
        '
        Me.qccMainPerfil.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.qccMainPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.qccMainPerfil.Items.Add(Me.qcgHeader)
        Me.qccMainPerfil.Items.Add(Me.QCompositeSeparator1)
        Me.qccMainPerfil.Items.Add(Me.qcgForm)
        Me.qccMainPerfil.Items.Add(Me.QCompositeSeparator2)
        Me.qccMainPerfil.Items.Add(Me.qcgActions)
        Me.qccMainPerfil.Location = New System.Drawing.Point(0, 0)
        Me.qccMainPerfil.Name = "qccMainPerfil"
        Me.qccMainPerfil.Size = New System.Drawing.Size(631, 383)
        Me.qccMainPerfil.TabIndex = 0
        Me.qccMainPerfil.Text = "QCompositeControl1"
        '
        'qcgHeader
        '
        Me.qcgHeader.Items.Add(Me.qctTitle)
        '
        'qctTitle
        '
        Me.qctTitle.Configuration.FontDefinition = New Qios.DevSuite.Components.QFontDefinition("Gill Sans", True, False, False, False, 14.0!)
        Me.qctTitle.Title = "Accesos de la Aplicacion"
        '
        'qcgForm
        '
        Me.qcgForm.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.qcgForm.Configuration.MinimumSize = New System.Drawing.Size(0, 250)
        Me.qcgForm.Configuration.StretchHorizontal = True
        Me.qcgForm.Items.Add(Me.qcgPerfil)
        '
        'qcgPerfil
        '
        Me.qcgPerfil.Configuration.StretchHorizontal = True
        Me.qcgPerfil.Items.Add(Me.qctPerfil)
        Me.qcgPerfil.Items.Add(Me.qcibPerfil)
        '
        'qctPerfil
        '
        Me.qctPerfil.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered
        Me.qctPerfil.Configuration.Margin = New Qios.DevSuite.Components.QMargin(0, 0, 0, 10)
        Me.qctPerfil.Title = "Perfil"
        '
        'qcibPerfil
        '
        Me.qcibPerfil.ControlSize = New System.Drawing.Size(250, 20)
        '
        '
        '
        Me.qcibPerfil.InputBox.CueText = "Introduzca el perfil"
        Me.qcibPerfil.InputBox.Location = New System.Drawing.Point(44, 35)
        Me.qcibPerfil.InputBox.Name = ""
        Me.qcibPerfil.InputBox.Size = New System.Drawing.Size(250, 19)
        Me.qcibPerfil.InputBox.TabIndex = 0
        '
        'qcgActions
        '
        Me.qcgActions.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcgActions.Configuration.StretchHorizontal = True
        Me.qcgActions.Items.Add(Me.qcbGuardar)
        Me.qcgActions.Items.Add(Me.qcbCancelar)
        '
        'qcbGuardar
        '
        Me.qcbGuardar.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcbGuardar.Title = "Guardar"
        '
        'qcbCancelar
        '
        Me.qcbCancelar.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcbCancelar.Title = "Cancelar"
        '
        'dgvApplication
        '
        Me.dgvApplication.AllowUserToAddRows = False
        Me.dgvApplication.AllowUserToDeleteRows = False
        Me.dgvApplication.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvApplication.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvApplication.Location = New System.Drawing.Point(12, 71)
        Me.dgvApplication.Name = "dgvApplication"
        Me.dgvApplication.Size = New System.Drawing.Size(360, 202)
        Me.dgvApplication.TabIndex = 1
        '
        'PerfilCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 383)
        Me.Controls.Add(Me.dgvApplication)
        Me.Controls.Add(Me.qccMainPerfil)
        Me.Name = "PerfilCuenta"
        Me.Text = "PerfilCuenta"
        CType(Me.qccMainPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvApplication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents qccMainPerfil As Qios.DevSuite.Components.QCompositeControl
    Friend WithEvents qcgHeader As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctTitle As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents QCompositeSeparator1 As Qios.DevSuite.Components.QCompositeSeparator
    Friend WithEvents qcgForm As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcgPerfil As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctPerfil As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents qcibPerfil As Qios.DevSuite.Components.QCompositeItemInputBox
    Friend WithEvents dgvApplication As System.Windows.Forms.DataGridView
    Friend WithEvents qcgActions As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcbGuardar As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents qcbCancelar As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents QCompositeSeparator2 As Qios.DevSuite.Components.QCompositeSeparator
End Class
