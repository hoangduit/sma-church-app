Public Class MainNotaria


   
    Private Sub QCompositeButton1_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbNuevoPre.ItemActivated
        Dim MDIFormListPreRegistro As New LstPreRegistros
        MDIFormListPreRegistro.MdiParent = Me
        MDIFormListPreRegistro.WindowState = 2
        MDIFormListPreRegistro.Show()
    End Sub

    Private Sub QCompositeButton4_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbNuevoAdmin.ItemActivated
        Dim MDIFormAlta As New AltaCuenta
        CloseAllMDIChild()
        MDIFormAlta.MdiParent = Me
        MDIFormAlta.WindowState = 2
        MDIFormAlta.Show()

    End Sub

    Private Sub QCompositeLargeMenuItem1_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qclmiRole.ItemActivated
        Dim MDIFormPerfilCuenta As New PerfilCuenta
        CloseAllMDIChild()
        MDIFormPerfilCuenta.MdiParent = Me
        MDIFormPerfilCuenta.WindowState = 2
        MDIFormPerfilCuenta.Show()
    End Sub


    Private Sub QRibbonPage2_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qrPageBautizos.Activated
        'Ejemplo para llamar el formulario hijo
        '=====================================
        'Dim MDIPreRegistro As New PreRegistro
        'CloseAllMDIChild()
        'MDIPreRegistro.MdiParent = Me
        'MDIPreRegistro.WindowState = 2
        'MDIPreRegistro.Show()
        '=====================================
        'Aqui va el formulario de Bautizos

    End Sub


    Private Sub MainNotaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MDIFormListaPreRegistro As New LstPreRegistros
        CloseAllMDIChild()
        MDIFormListaPreRegistro.MdiParent = Me
        MDIFormListaPreRegistro.WindowState = 2
        MDIFormListaPreRegistro.Show()
    End Sub

    'Con este metodo se cierran todos los forms hijos en la aplicacion
    Private Sub CloseAllMDIChild()
        'MsgBox(Me.MdiChildren.Length)
        If Me.MdiChildren.Length > 0 Then
            For i = 0 To Me.MdiChildren.Length - 1
                Me.MdiChildren(i).Close()
            Next
        End If

    End Sub
 
    Private Sub qrPagePreRegistro_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qrPagePreRegistro.Activated
        CloseAllMDIChild()
        'Pendiente encontrar como cargar la lista de preregistros

    End Sub

    Private Sub qrPageAdmin_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qrPageAdmin.Activated
        Dim MDIFormAlta As New AltaCuenta
        CloseAllMDIChild()
        MDIFormAlta.MdiParent = Me
        MDIFormAlta.WindowState = 2
        MDIFormAlta.Show()
    End Sub

    Private Sub qcbEditUser_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbEditUser.ItemActivated
        Dim MDIFormEditUser As New EditUser
        CloseAllMDIChild()
        MDIFormEditUser.MdiParent = Me
        MDIFormEditUser.WindowState = 2
        MDIFormEditUser.Show()

    End Sub
End Class