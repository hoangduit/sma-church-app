<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuentas
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
        Me.components = New System.ComponentModel.Container()
        Me.qtbhNavegador = New Qios.DevSuite.Components.QToolBarHost()
        Me.qtBarNavegador = New Qios.DevSuite.Components.QToolBar()
        Me.qtiBack = New Qios.DevSuite.Components.QToolItem(Me.components)
        Me.qtiFwd = New Qios.DevSuite.Components.QToolItem(Me.components)
        Me.qtiHome = New Qios.DevSuite.Components.QToolItem(Me.components)
        CType(Me.qtbhNavegador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.qtbhNavegador.SuspendLayout()
        Me.SuspendLayout()
        '
        'qtbhNavegador
        '
        Me.qtbhNavegador.ColorScheme.CurrentTheme = "LunaOlive"
        Me.qtbhNavegador.ColorScheme.InheritCurrentThemeFromGlobal = False
        Me.qtbhNavegador.ColorScheme.Scope = Qios.DevSuite.Components.QColorSchemeScope.All
        Me.qtbhNavegador.Controls.Add(Me.qtBarNavegador)
        Me.qtbhNavegador.Dock = System.Windows.Forms.DockStyle.Top
        Me.qtbhNavegador.Location = New System.Drawing.Point(0, 0)
        Me.qtbhNavegador.Name = "qtbhNavegador"
        Me.qtbhNavegador.PersistGuid = New System.Guid("9eb74d6e-bd1c-4e03-8bbf-49af58d0eda4")
        Me.qtbhNavegador.Size = New System.Drawing.Size(755, 31)
        Me.qtbhNavegador.TabIndex = 0
        Me.qtbhNavegador.Text = "QToolBarHost1"
        '
        'qtBarNavegador
        '
        Me.qtBarNavegador.ColorScheme.CurrentTheme = "LunaOlive"
        Me.qtBarNavegador.ColorScheme.InheritCurrentThemeFromGlobal = False
        Me.qtBarNavegador.ColorScheme.Scope = Qios.DevSuite.Components.QColorSchemeScope.All
        Me.qtBarNavegador.Location = New System.Drawing.Point(3, 2)
        Me.qtBarNavegador.Name = "qtBarNavegador"
        Me.qtBarNavegador.PersistGuid = New System.Guid("e7328632-e103-4463-9d2f-5c64cb40e4f3")
        Me.qtBarNavegador.RequestedPosition = 3
        Me.qtBarNavegador.RowIndex = 0
        Me.qtBarNavegador.Size = New System.Drawing.Size(94, 27)
        Me.qtBarNavegador.TabIndex = 0
        Me.qtBarNavegador.Text = "Barra"
        Me.qtBarNavegador.ToolBarIndex = 0
        Me.qtBarNavegador.ToolItems.AddRange(New Qios.DevSuite.Components.QMenuItem() {Me.qtiBack, Me.qtiFwd, Me.qtiHome})
        '
        'qtiBack
        '
        Me.qtiBack.Title = "Atras"
        Me.qtiBack.ToolTip = "Atras"
        '
        'qtiHome
        '
        Me.qtiHome.Title = "Inicio"
        Me.qtiHome.ToolTip = "Inicio"
        '
        'Cuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 527)
        Me.Controls.Add(Me.qtbhNavegador)
        Me.IsMdiContainer = True
        Me.Name = "Cuentas"
        Me.Text = "Cuentas"
        CType(Me.qtbhNavegador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.qtbhNavegador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents qtbhNavegador As Qios.DevSuite.Components.QToolBarHost
    Friend WithEvents qtBarNavegador As Qios.DevSuite.Components.QToolBar
    Friend WithEvents qtiBack As Qios.DevSuite.Components.QToolItem
    Friend WithEvents qtiFwd As Qios.DevSuite.Components.QToolItem
    Friend WithEvents qtiHome As Qios.DevSuite.Components.QToolItem
End Class
