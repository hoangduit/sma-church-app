<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaCuenta
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
        Me.qccAltaCuenta = New Qios.DevSuite.Components.QCompositeControl()
        Me.qcgHeader = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctTitle = New Qios.DevSuite.Components.QCompositeText()
        Me.QCompositeSeparator1 = New Qios.DevSuite.Components.QCompositeSeparator()
        Me.qcgForm = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcgUser = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctUser = New Qios.DevSuite.Components.QCompositeText()
        Me.qcibUser = New Qios.DevSuite.Components.QCompositeItemInputBox()
        Me.qcgPass = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctPassword = New Qios.DevSuite.Components.QCompositeText()
        Me.qcibPass = New Qios.DevSuite.Components.QCompositeItemInputBox()
        Me.qcgPerfil = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctPerfil = New Qios.DevSuite.Components.QCompositeText()
        Me.QCompositeSeparator2 = New Qios.DevSuite.Components.QCompositeSeparator()
        Me.qcgNav = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcbSigAltaCuenta = New Qios.DevSuite.Components.QCompositeButton()
        Me.qcbCanAltaCuenta = New Qios.DevSuite.Components.QCompositeButton()
        Me.qcgNotification = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctNotification = New Qios.DevSuite.Components.QCompositeText()
        Me.qcbPerfil = New Qios.DevSuite.Components.QComboBox()
        CType(Me.qccAltaCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'qccAltaCuenta
        '
        Me.qccAltaCuenta.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.qccAltaCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.qccAltaCuenta.Items.Add(Me.qcgHeader)
        Me.qccAltaCuenta.Items.Add(Me.QCompositeSeparator1)
        Me.qccAltaCuenta.Items.Add(Me.qcgForm)
        Me.qccAltaCuenta.Items.Add(Me.QCompositeSeparator2)
        Me.qccAltaCuenta.Items.Add(Me.qcgNav)
        Me.qccAltaCuenta.Items.Add(Me.qcgNotification)
        Me.qccAltaCuenta.Location = New System.Drawing.Point(0, 0)
        Me.qccAltaCuenta.Name = "qccAltaCuenta"
        Me.qccAltaCuenta.Size = New System.Drawing.Size(721, 532)
        Me.qccAltaCuenta.TabIndex = 0
        Me.qccAltaCuenta.Text = "QCompositeControl1"
        '
        'qcgHeader
        '
        Me.qcgHeader.Items.Add(Me.qctTitle)
        '
        'qctTitle
        '
        Me.qctTitle.Configuration.FontDefinition = New Qios.DevSuite.Components.QFontDefinition("Gill Sans", True, False, False, False, 14.0!)
        Me.qctTitle.Title = "Agregar Usuario"
        '
        'qcgForm
        '
        Me.qcgForm.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.qcgForm.Configuration.Margin = New Qios.DevSuite.Components.QMargin(0, 30, 0, 0)
        Me.qcgForm.Configuration.StretchHorizontal = True
        Me.qcgForm.Items.Add(Me.qcgUser)
        Me.qcgForm.Items.Add(Me.qcgPass)
        Me.qcgForm.Items.Add(Me.qcgPerfil)
        '
        'qcgUser
        '
        Me.qcgUser.Configuration.StretchHorizontal = True
        Me.qcgUser.Items.Add(Me.qctUser)
        Me.qcgUser.Items.Add(Me.qcibUser)
        '
        'qctUser
        '
        Me.qctUser.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered
        Me.qctUser.Configuration.Margin = New Qios.DevSuite.Components.QMargin(0, 0, 0, 27)
        Me.qctUser.Title = "Usuario"
        '
        'qcibUser
        '
        Me.qcibUser.ControlSize = New System.Drawing.Size(250, 20)
        '
        '
        '
        Me.qcibUser.InputBox.CueText = "Introduzca el Usuario"
        Me.qcibUser.InputBox.Location = New System.Drawing.Point(74, 65)
        Me.qcibUser.InputBox.Name = ""
        Me.qcibUser.InputBox.Size = New System.Drawing.Size(250, 19)
        Me.qcibUser.InputBox.TabIndex = 0
        '
        'qcgPass
        '
        Me.qcgPass.Configuration.StretchHorizontal = True
        Me.qcgPass.Items.Add(Me.qctPassword)
        Me.qcgPass.Items.Add(Me.qcibPass)
        '
        'qctPassword
        '
        Me.qctPassword.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered
        Me.qctPassword.Configuration.Margin = New Qios.DevSuite.Components.QMargin(0, 0, 0, 7)
        Me.qctPassword.Title = "Contraseña"
        '
        'qcibPass
        '
        Me.qcibPass.ControlSize = New System.Drawing.Size(250, 20)
        '
        '
        '
        Me.qcibPass.InputBox.CueText = "Introduca  Contraseña"
        Me.qcibPass.InputBox.Location = New System.Drawing.Point(73, 89)
        Me.qcibPass.InputBox.Name = ""
        Me.qcibPass.InputBox.Size = New System.Drawing.Size(250, 19)
        Me.qcibPass.InputBox.TabIndex = 1
        '
        'qcgPerfil
        '
        Me.qcgPerfil.Items.Add(Me.qctPerfil)
        '
        'qctPerfil
        '
        Me.qctPerfil.Configuration.Margin = New Qios.DevSuite.Components.QMargin(0, 0, 0, 40)
        Me.qctPerfil.Title = "Perfil"
        '
        'QCompositeSeparator2
        '
        Me.QCompositeSeparator2.Configuration.Margin = New Qios.DevSuite.Components.QMargin(1, 10, 1, 1)
        '
        'qcgNav
        '
        Me.qcgNav.Configuration.StretchHorizontal = True
        Me.qcgNav.Items.Add(Me.qcbSigAltaCuenta)
        Me.qcgNav.Items.Add(Me.qcbCanAltaCuenta)
        '
        'qcbSigAltaCuenta
        '
        Me.qcbSigAltaCuenta.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcbSigAltaCuenta.Title = "Guardar"
        '
        'qcbCanAltaCuenta
        '
        Me.qcbCanAltaCuenta.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcbCanAltaCuenta.Title = "Cancelar"
        '
        'qcgNotification
        '
        Me.qcgNotification.Configuration.Margin = New Qios.DevSuite.Components.QMargin(0, 250, 0, 0)
        Me.qcgNotification.Configuration.StretchHorizontal = True
        Me.qcgNotification.Items.Add(Me.qctNotification)
        '
        'qctNotification
        '
        Me.qctNotification.Configuration.FontDefinition = New Qios.DevSuite.Components.QFontDefinition(Nothing, True, False, False, False, -1.0!)
        Me.qctNotification.Title = ""
        '
        'qcbPerfil
        '
        Me.qcbPerfil.CueText = "Seleccione un Perfil"
        Me.qcbPerfil.Location = New System.Drawing.Point(74, 111)
        Me.qcbPerfil.Name = "qcbPerfil"
        Me.qcbPerfil.Size = New System.Drawing.Size(150, 19)
        Me.qcbPerfil.TabIndex = 1
        '
        'AltaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 532)
        Me.Controls.Add(Me.qcbPerfil)
        Me.Controls.Add(Me.qccAltaCuenta)
        Me.Name = "AltaCuenta"
        Me.ShowIcon = False
        Me.Text = "Alta"
        CType(Me.qccAltaCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents qccAltaCuenta As Qios.DevSuite.Components.QCompositeControl
    Friend WithEvents qcgHeader As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctTitle As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents QCompositeSeparator1 As Qios.DevSuite.Components.QCompositeSeparator
    Friend WithEvents qcgForm As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcgUser As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctUser As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents qcibUser As Qios.DevSuite.Components.QCompositeItemInputBox
    Friend WithEvents qcgPass As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctPassword As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents qcibPass As Qios.DevSuite.Components.QCompositeItemInputBox
    Friend WithEvents qcgPerfil As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctPerfil As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents qcbPerfil As Qios.DevSuite.Components.QComboBox
    Friend WithEvents QCompositeSeparator2 As Qios.DevSuite.Components.QCompositeSeparator
    Friend WithEvents qcgNav As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcbSigAltaCuenta As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents qcbCanAltaCuenta As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents qcgNotification As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctNotification As Qios.DevSuite.Components.QCompositeText
End Class
