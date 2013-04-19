<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditRole
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.QCompositeControl1 = New Qios.DevSuite.Components.QCompositeControl()
        Me.QCompositeGroup1 = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcgHeader = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcTxtTitle = New Qios.DevSuite.Components.QCompositeText()
        Me.QCompositeSeparator1 = New Qios.DevSuite.Components.QCompositeSeparator()
        Me.QCompositeGroup2 = New Qios.DevSuite.Components.QCompositeGroup()
        Me.QCompositeGroup3 = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qctPerfil = New Qios.DevSuite.Components.QCompositeText()
        Me.QCompositeSeparator2 = New Qios.DevSuite.Components.QCompositeSeparator()
        Me.QCompositeGroup4 = New Qios.DevSuite.Components.QCompositeGroup()
        Me.qcBtnCancelar = New Qios.DevSuite.Components.QCompositeButton()
        Me.qcbPerfil = New Qios.DevSuite.Components.QComboBox()
        Me.dgvApplication = New System.Windows.Forms.DataGridView()
        CType(Me.QCompositeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QCompositeControl1
        '
        Me.QCompositeControl1.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical
        Me.QCompositeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QCompositeControl1.Items.Add(Me.QCompositeGroup1)
        Me.QCompositeControl1.Items.Add(Me.QCompositeSeparator1)
        Me.QCompositeControl1.Items.Add(Me.QCompositeGroup2)
        Me.QCompositeControl1.Items.Add(Me.QCompositeSeparator2)
        Me.QCompositeControl1.Items.Add(Me.QCompositeGroup4)
        Me.QCompositeControl1.Location = New System.Drawing.Point(0, 0)
        Me.QCompositeControl1.Name = "QCompositeControl1"
        Me.QCompositeControl1.Size = New System.Drawing.Size(589, 502)
        Me.QCompositeControl1.TabIndex = 0
        Me.QCompositeControl1.Text = "QCompositeControl1"
        '
        'QCompositeGroup1
        '
        Me.QCompositeGroup1.Items.Add(Me.qcgHeader)
        '
        'qcgHeader
        '
        Me.qcgHeader.Items.Add(Me.qcTxtTitle)
        '
        'qcTxtTitle
        '
        Me.qcTxtTitle.Configuration.FontDefinition = New Qios.DevSuite.Components.QFontDefinition("Gill Sans", True, False, False, False, 14.0!)
        Me.qcTxtTitle.Title = "Editar el Acceso por Perfil"
        '
        'QCompositeGroup2
        '
        Me.QCompositeGroup2.Configuration.MinimumSize = New System.Drawing.Size(0, 250)
        Me.QCompositeGroup2.Configuration.StretchHorizontal = True
        Me.QCompositeGroup2.Items.Add(Me.QCompositeGroup3)
        '
        'QCompositeGroup3
        '
        Me.QCompositeGroup3.Configuration.MinimumSize = New System.Drawing.Size(0, 30)
        Me.QCompositeGroup3.Configuration.StretchHorizontal = True
        Me.QCompositeGroup3.Items.Add(Me.qctPerfil)
        '
        'qctPerfil
        '
        Me.qctPerfil.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered
        Me.qctPerfil.Title = "Perfil"
        '
        'QCompositeGroup4
        '
        Me.QCompositeGroup4.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.QCompositeGroup4.Configuration.StretchHorizontal = True
        Me.QCompositeGroup4.Items.Add(Me.qcBtnCancelar)
        '
        'qcBtnCancelar
        '
        Me.qcBtnCancelar.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far
        Me.qcBtnCancelar.Title = "Cancelar"
        '
        'qcbPerfil
        '
        Me.qcbPerfil.CueText = "Seleccione un Perfil"
        Me.qcbPerfil.Location = New System.Drawing.Point(43, 39)
        Me.qcbPerfil.Name = "qcbPerfil"
        Me.qcbPerfil.Size = New System.Drawing.Size(141, 19)
        Me.qcbPerfil.TabIndex = 1
        '
        'dgvApplication
        '
        Me.dgvApplication.AllowUserToAddRows = False
        Me.dgvApplication.AllowUserToDeleteRows = False
        Me.dgvApplication.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvApplication.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvApplication.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvApplication.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvApplication.Location = New System.Drawing.Point(12, 88)
        Me.dgvApplication.Name = "dgvApplication"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvApplication.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvApplication.Size = New System.Drawing.Size(302, 181)
        Me.dgvApplication.TabIndex = 2
        '
        'EditRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 502)
        Me.Controls.Add(Me.dgvApplication)
        Me.Controls.Add(Me.qcbPerfil)
        Me.Controls.Add(Me.QCompositeControl1)
        Me.Name = "EditRole"
        Me.Text = "EditRole"
        CType(Me.QCompositeControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvApplication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QCompositeControl1 As Qios.DevSuite.Components.QCompositeControl
    Friend WithEvents QCompositeGroup1 As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcgHeader As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcTxtTitle As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents QCompositeGroup2 As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents QCompositeSeparator1 As Qios.DevSuite.Components.QCompositeSeparator
    Friend WithEvents QCompositeGroup3 As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qctPerfil As Qios.DevSuite.Components.QCompositeText
    Friend WithEvents qcbPerfil As Qios.DevSuite.Components.QComboBox
    Friend WithEvents dgvApplication As System.Windows.Forms.DataGridView
    Friend WithEvents QCompositeSeparator2 As Qios.DevSuite.Components.QCompositeSeparator
    Friend WithEvents QCompositeGroup4 As Qios.DevSuite.Components.QCompositeGroup
    Friend WithEvents qcBtnCancelar As Qios.DevSuite.Components.QCompositeButton
End Class
