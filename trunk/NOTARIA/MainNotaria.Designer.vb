<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainNotaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainNotaria))
        Me.QRibbonCaption1 = New Qios.DevSuite.Components.Ribbon.QRibbonCaption()
        Me.QRibbonApplicationButton1 = New Qios.DevSuite.Components.Ribbon.QRibbonApplicationButton()
        Me.QRibbonLaunchBar1 = New Qios.DevSuite.Components.Ribbon.QRibbonLaunchBar()
        Me.QRibbon1 = New Qios.DevSuite.Components.Ribbon.QRibbon()
        Me.QRibbonPage1 = New Qios.DevSuite.Components.Ribbon.QRibbonPage()
        Me.QRibbonPanel4 = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.qcbNuevoPre = New Qios.DevSuite.Components.QCompositeButton()
        Me.QRibbonPanel5 = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.QRibbonItemGroup2 = New Qios.DevSuite.Components.Ribbon.QRibbonItemGroup()
        Me.QRibbonInputBoxItem2 = New Qios.DevSuite.Components.Ribbon.QRibbonInputBoxItem()
        Me.QCompositeButton3 = New Qios.DevSuite.Components.QCompositeButton()
        Me.QRibbonPage2 = New Qios.DevSuite.Components.Ribbon.QRibbonPage()
        Me.QRibbonPanel1 = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.QCompositeButton2 = New Qios.DevSuite.Components.QCompositeButton()
        Me.QRibbonPanel2 = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.QRibbonPanel3 = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.QRibbonPage3 = New Qios.DevSuite.Components.Ribbon.QRibbonPage()
        Me.QRPanelAltaAdmin = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.qcbNuevoAdmin = New Qios.DevSuite.Components.QCompositeButton()
        Me.QRibbonItemGroup4 = New Qios.DevSuite.Components.Ribbon.QRibbonItemGroup()
        Me.qclmiRole = New Qios.DevSuite.Components.QCompositeLargeMenuItem()
        Me.QRibbonPanel8 = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.QRibbonItemGroup6 = New Qios.DevSuite.Components.Ribbon.QRibbonItemGroup()
        Me.qcbEditUser = New Qios.DevSuite.Components.QCompositeButton()
        Me.QRibbonItemGroup3 = New Qios.DevSuite.Components.Ribbon.QRibbonItemGroup()
        Me.QRibbonPage4 = New Qios.DevSuite.Components.Ribbon.QRibbonPage()
        Me.QRibbonPanel7 = New Qios.DevSuite.Components.Ribbon.QRibbonPanel()
        Me.QRibbonInputBoxItem1 = New Qios.DevSuite.Components.Ribbon.QRibbonInputBoxItem()
        Me.QRibbonItemGroup1 = New Qios.DevSuite.Components.Ribbon.QRibbonItemGroup()
        CType(Me.QRibbonCaption1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRibbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QRibbon1.SuspendLayout()
        CType(Me.QRibbonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRibbonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRibbonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRibbonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QRibbonCaption1
        '
        Me.QRibbonCaption1.ApplicationButton = Me.QRibbonApplicationButton1
        Me.QRibbonCaption1.LaunchBar = Me.QRibbonLaunchBar1
        Me.QRibbonCaption1.Location = New System.Drawing.Point(0, 0)
        Me.QRibbonCaption1.Name = "QRibbonCaption1"
        Me.QRibbonCaption1.Size = New System.Drawing.Size(1080, 36)
        Me.QRibbonCaption1.TabIndex = 1
        Me.QRibbonCaption1.Text = "Notaria 2012 V1.1"
        '
        'QRibbonApplicationButton1
        '
        Me.QRibbonApplicationButton1.BackgroundImage = CType(resources.GetObject("QRibbonApplicationButton1.BackgroundImage"), System.Drawing.Image)
        Me.QRibbonApplicationButton1.BackgroundImageHot = CType(resources.GetObject("QRibbonApplicationButton1.BackgroundImageHot"), System.Drawing.Image)
        Me.QRibbonApplicationButton1.BackgroundImagePressed = CType(resources.GetObject("QRibbonApplicationButton1.BackgroundImagePressed"), System.Drawing.Image)
        Me.QRibbonApplicationButton1.Configuration.ButtonStyle = Qios.DevSuite.Components.Ribbon.QRibbonApplicationButtonStyle.Image
        Me.QRibbonApplicationButton1.Configuration.CustomPaintSize = New System.Drawing.Size(50, 50)
        Me.QRibbonApplicationButton1.Configuration.Margin = New Qios.DevSuite.Components.QMargin(15, 0, 0, 0)
        Me.QRibbonApplicationButton1.Configuration.Visible = Qios.DevSuite.Components.QTristateBool.[True]
        '
        'QRibbon1
        '
        Me.QRibbon1.ActiveTabPage = Me.QRibbonPage1
        Me.QRibbon1.Controls.Add(Me.QRibbonPage1)
        Me.QRibbon1.Controls.Add(Me.QRibbonPage2)
        Me.QRibbon1.Controls.Add(Me.QRibbonPage3)
        Me.QRibbon1.Controls.Add(Me.QRibbonPage4)
        Me.QRibbon1.Cursor = System.Windows.Forms.Cursors.Default
        Me.QRibbon1.Dock = System.Windows.Forms.DockStyle.Top
        Me.QRibbon1.Location = New System.Drawing.Point(0, 36)
        Me.QRibbon1.Name = "QRibbon1"
        Me.QRibbon1.PersistGuid = New System.Guid("89d7575c-2de8-499b-885b-d75578dd8b0b")
        Me.QRibbon1.Size = New System.Drawing.Size(1080, 134)
        Me.QRibbon1.TabIndex = 2
        Me.QRibbon1.Text = "QRibbon1"
        '
        'QRibbonPage1
        '
        Me.QRibbonPage1.ButtonConfiguration.Spacing = New Qios.DevSuite.Components.QSpacing(40, 0)
        Me.QRibbonPage1.ButtonOrder = 0
        Me.QRibbonPage1.Items.Add(Me.QRibbonPanel4)
        Me.QRibbonPage1.Items.Add(Me.QRibbonPanel5)
        Me.QRibbonPage1.Location = New System.Drawing.Point(2, 28)
        Me.QRibbonPage1.Name = "QRibbonPage1"
        Me.QRibbonPage1.PersistGuid = New System.Guid("f021ac2d-110a-475b-9900-812d424cc631")
        Me.QRibbonPage1.Size = New System.Drawing.Size(1074, 102)
        Me.QRibbonPage1.Text = "Pre -Registro"
        '
        'QRibbonPanel4
        '
        Me.QRibbonPanel4.Items.Add(Me.qcbNuevoPre)
        Me.QRibbonPanel4.Title = "Alta"
        '
        'qcbNuevoPre
        '
        Me.qcbNuevoPre.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.qcbNuevoPre.Configuration.IconConfiguration.IconSize = New System.Drawing.Size(32, 32)
        Me.qcbNuevoPre.Configuration.MinimumSize = New System.Drawing.Size(60, 22)
        Me.qcbNuevoPre.Configuration.StretchVertical = True
        Me.qcbNuevoPre.Icon = CType(resources.GetObject("qcbNuevoPre.Icon"), System.Drawing.Icon)
        Me.qcbNuevoPre.Title = "Nuevo"
        '
        'QRibbonPanel5
        '
        Me.QRibbonPanel5.Items.Add(Me.QRibbonItemGroup2)
        Me.QRibbonPanel5.Title = "Edición"
        '
        'QRibbonItemGroup2
        '
        Me.QRibbonItemGroup2.Items.Add(Me.QRibbonInputBoxItem2)
        Me.QRibbonItemGroup2.Items.Add(Me.QCompositeButton3)
        '
        'QRibbonInputBoxItem2
        '
        Me.QRibbonInputBoxItem2.ControlSize = New System.Drawing.Size(100, 19)
        '
        '
        '
        Me.QRibbonInputBoxItem2.InputBox.Location = New System.Drawing.Point(80, 9)
        Me.QRibbonInputBoxItem2.InputBox.Name = ""
        Me.QRibbonInputBoxItem2.InputBox.Size = New System.Drawing.Size(100, 19)
        Me.QRibbonInputBoxItem2.InputBox.TabIndex = 0
        '
        'QCompositeButton3
        '
        Me.QCompositeButton3.Icon = CType(resources.GetObject("QCompositeButton3.Icon"), System.Drawing.Icon)
        '
        'QRibbonPage2
        '
        Me.QRibbonPage2.ButtonOrder = 1
        Me.QRibbonPage2.Items.Add(Me.QRibbonPanel1)
        Me.QRibbonPage2.Items.Add(Me.QRibbonPanel2)
        Me.QRibbonPage2.Items.Add(Me.QRibbonPanel3)
        Me.QRibbonPage2.Location = New System.Drawing.Point(2, 28)
        Me.QRibbonPage2.Name = "QRibbonPage2"
        Me.QRibbonPage2.PersistGuid = New System.Guid("02df447e-ffa0-42ae-9849-6f68ee5e6a52")
        Me.QRibbonPage2.Size = New System.Drawing.Size(796, 102)
        Me.QRibbonPage2.Text = "Bautizos"
        '
        'QRibbonPanel1
        '
        Me.QRibbonPanel1.Items.Add(Me.QCompositeButton2)
        Me.QRibbonPanel1.Title = "Alta"
        '
        'QCompositeButton2
        '
        Me.QCompositeButton2.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.QCompositeButton2.Configuration.IconConfiguration.IconSize = New System.Drawing.Size(32, 32)
        Me.QCompositeButton2.Configuration.MinimumSize = New System.Drawing.Size(50, 22)
        Me.QCompositeButton2.Configuration.StretchVertical = True
        Me.QCompositeButton2.Icon = CType(resources.GetObject("QCompositeButton2.Icon"), System.Drawing.Icon)
        Me.QCompositeButton2.Title = " Nuevo"
        '
        'QRibbonPanel2
        '
        Me.QRibbonPanel2.Title = "QRibbonPanel2"
        '
        'QRibbonPanel3
        '
        Me.QRibbonPanel3.Title = "QRibbonPanel3"
        '
        'QRibbonPage3
        '
        Me.QRibbonPage3.ButtonOrder = 2
        Me.QRibbonPage3.Items.Add(Me.QRPanelAltaAdmin)
        Me.QRibbonPage3.Items.Add(Me.QRibbonPanel8)
        Me.QRibbonPage3.Location = New System.Drawing.Point(2, 28)
        Me.QRibbonPage3.Name = "QRibbonPage3"
        Me.QRibbonPage3.PersistGuid = New System.Guid("46f88814-8cf8-45f3-a129-d4fb4e9189a3")
        Me.QRibbonPage3.Size = New System.Drawing.Size(796, 102)
        Me.QRibbonPage3.Text = "Administracion"
        '
        'QRPanelAltaAdmin
        '
        Me.QRPanelAltaAdmin.Configuration.MinimumSize = New System.Drawing.Size(120, 0)
        Me.QRPanelAltaAdmin.Items.Add(Me.qcbNuevoAdmin)
        Me.QRPanelAltaAdmin.Items.Add(Me.QRibbonItemGroup4)
        Me.QRPanelAltaAdmin.Title = "Altas"
        '
        'qcbNuevoAdmin
        '
        Me.qcbNuevoAdmin.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.qcbNuevoAdmin.Configuration.IconConfiguration.IconSize = New System.Drawing.Size(32, 32)
        Me.qcbNuevoAdmin.Configuration.MinimumSize = New System.Drawing.Size(50, 22)
        Me.qcbNuevoAdmin.Configuration.StretchVertical = True
        Me.qcbNuevoAdmin.Icon = CType(resources.GetObject("qcbNuevoAdmin.Icon"), System.Drawing.Icon)
        Me.qcbNuevoAdmin.Title = "Nuevo"
        '
        'QRibbonItemGroup4
        '
        Me.QRibbonItemGroup4.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Centered
        Me.QRibbonItemGroup4.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered
        Me.QRibbonItemGroup4.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.QRibbonItemGroup4.Items.Add(Me.qclmiRole)
        '
        'qclmiRole
        '
        Me.qclmiRole.Configuration.IconConfiguration.IconSize = New System.Drawing.Size(24, 24)
        Me.qclmiRole.Icon = CType(resources.GetObject("qclmiRole.Icon"), System.Drawing.Icon)
        Me.qclmiRole.Title = "Role"
        '
        'QRibbonPanel8
        '
        Me.QRibbonPanel8.Items.Add(Me.QRibbonItemGroup6)
        Me.QRibbonPanel8.Items.Add(Me.QRibbonItemGroup3)
        Me.QRibbonPanel8.Title = "Editar Usuario - Rol"
        '
        'QRibbonItemGroup6
        '
        Me.QRibbonItemGroup6.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.QRibbonItemGroup6.Configuration.StretchVertical = True
        Me.QRibbonItemGroup6.Items.Add(Me.qcbEditUser)
        '
        'qcbEditUser
        '
        Me.qcbEditUser.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.qcbEditUser.Configuration.IconConfiguration.IconSize = New System.Drawing.Size(40, 40)
        Me.qcbEditUser.Configuration.IconConfiguration.StretchVertical = True
        Me.qcbEditUser.Configuration.StretchVertical = True
        Me.qcbEditUser.Icon = CType(resources.GetObject("qcbEditUser.Icon"), System.Drawing.Icon)
        Me.qcbEditUser.Title = "Actualizar"
        '
        'QRibbonPage4
        '
        Me.QRibbonPage4.ButtonOrder = 3
        Me.QRibbonPage4.Items.Add(Me.QRibbonPanel7)
        Me.QRibbonPage4.Location = New System.Drawing.Point(2, 28)
        Me.QRibbonPage4.Name = "QRibbonPage4"
        Me.QRibbonPage4.PersistGuid = New System.Guid("e7e0e9af-4309-4c5c-baba-d9caf74d13ff")
        Me.QRibbonPage4.Size = New System.Drawing.Size(796, 102)
        Me.QRibbonPage4.Text = "Configuracion"
        '
        'QRibbonPanel7
        '
        Me.QRibbonPanel7.Title = "Alta"
        '
        'QRibbonInputBoxItem1
        '
        Me.QRibbonInputBoxItem1.ControlSize = New System.Drawing.Size(100, 19)
        '
        '
        '
        Me.QRibbonInputBoxItem1.InputBox.Location = New System.Drawing.Point(80, 9)
        Me.QRibbonInputBoxItem1.InputBox.Name = ""
        Me.QRibbonInputBoxItem1.InputBox.Size = New System.Drawing.Size(100, 19)
        Me.QRibbonInputBoxItem1.InputBox.TabIndex = 0
        Me.QRibbonInputBoxItem1.Title = "QRibbonInputBoxItem1"
        '
        'MainNotaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 700)
        Me.Controls.Add(Me.QRibbon1)
        Me.Controls.Add(Me.QRibbonCaption1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainNotaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notaria 2012 V1.1"
        CType(Me.QRibbonCaption1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRibbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QRibbon1.ResumeLayout(False)
        CType(Me.QRibbonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRibbonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRibbonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRibbonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QRibbonCaption1 As Qios.DevSuite.Components.Ribbon.QRibbonCaption
    Friend WithEvents QRibbonApplicationButton1 As Qios.DevSuite.Components.Ribbon.QRibbonApplicationButton
    Friend WithEvents QRibbonLaunchBar1 As Qios.DevSuite.Components.Ribbon.QRibbonLaunchBar
    Friend WithEvents QRibbon1 As Qios.DevSuite.Components.Ribbon.QRibbon
    Friend WithEvents QRibbonPage1 As Qios.DevSuite.Components.Ribbon.QRibbonPage
    Friend WithEvents QRibbonPanel4 As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents QRibbonPanel5 As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents QRibbonPage2 As Qios.DevSuite.Components.Ribbon.QRibbonPage
    Friend WithEvents QRibbonPanel1 As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents QRibbonPanel2 As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents QRibbonPanel3 As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents QRibbonPage3 As Qios.DevSuite.Components.Ribbon.QRibbonPage
    Friend WithEvents qcbNuevoPre As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents QCompositeButton2 As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents QRibbonInputBoxItem1 As Qios.DevSuite.Components.Ribbon.QRibbonInputBoxItem
    Friend WithEvents QRibbonItemGroup1 As Qios.DevSuite.Components.Ribbon.QRibbonItemGroup
    Friend WithEvents QRibbonItemGroup2 As Qios.DevSuite.Components.Ribbon.QRibbonItemGroup
    Friend WithEvents QRibbonInputBoxItem2 As Qios.DevSuite.Components.Ribbon.QRibbonInputBoxItem
    Friend WithEvents QCompositeButton3 As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents QRPanelAltaAdmin As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents QRibbonPage4 As Qios.DevSuite.Components.Ribbon.QRibbonPage
    Friend WithEvents QRibbonPanel7 As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents qcbNuevoAdmin As Qios.DevSuite.Components.QCompositeButton
    Friend WithEvents QRibbonPanel8 As Qios.DevSuite.Components.Ribbon.QRibbonPanel
    Friend WithEvents QRibbonItemGroup3 As Qios.DevSuite.Components.Ribbon.QRibbonItemGroup
    Friend WithEvents QRibbonItemGroup4 As Qios.DevSuite.Components.Ribbon.QRibbonItemGroup
    Friend WithEvents qclmiRole As Qios.DevSuite.Components.QCompositeLargeMenuItem
    Friend WithEvents QRibbonItemGroup6 As Qios.DevSuite.Components.Ribbon.QRibbonItemGroup
    Friend WithEvents qcbEditUser As Qios.DevSuite.Components.QCompositeButton
End Class
