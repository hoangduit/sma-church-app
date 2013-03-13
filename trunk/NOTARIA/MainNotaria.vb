Public Class MainNotaria
    Dim MDIFormListPreRegistro As New LstPreRegistros

   
    Private Sub QCompositeButton1_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbNuevoPre.ItemActivated
        'Dim MDIFormPreRegistro As New PreRegistro
        'MDIFormPreRegistro.MdiParent = Me
        'MDIFormPreRegistro.WindowState = 2
        'MDIFormPreRegistro.Show()
        Dim MDIFormListPreRegistro As New LstPreRegistros
        MDIFormListPreRegistro.MdiParent = Me
        MDIFormListPreRegistro.WindowState = 2
        MDIFormListPreRegistro.Show()

    End Sub

    Private Sub QCompositeButton4_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbNuevoAdmin.ItemActivated
        Dim MDIFormAlta As New AltaCuenta
        MDIFormAlta.MdiParent = Me
        MDIFormAlta.WindowState = 2
        MDIFormAlta.Show()
        qcbNuevoAdmin.Enabled = False

    End Sub

    Private Sub QCompositeLargeMenuItem1_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qclmiRole.ItemActivated
        Dim MDIFormPerfilCuenta As New PerfilCuenta
        MDIFormPerfilCuenta.MdiParent = Me
        MDIFormPerfilCuenta.WindowState = 2
        MDIFormPerfilCuenta.Show()
        qclmiRole.Enabled = False
    End Sub

    Private Sub qcbEditUser_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbEditUser.ItemActivated
        Dim MDIFormEditUser As New EditUser
        MDIFormEditUser.MdiParent = Me
        MDIFormEditUser.WindowState = 2
        MDIFormEditUser.Show()
        qcbEditUser.Enabled = False
    End Sub




    Private Sub QRibbonPage2_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRibbonPage2.Activated
        MDIFormListPreRegistro.Close()
        Dim MDIPreRegistro As New PreRegistro
        MDIPreRegistro.MdiParent = Me
        MDIPreRegistro.WindowState = 2
        MDIPreRegistro.Show()
    End Sub

    Private Sub QRibbonPage1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRibbonPage1.Activated

    End Sub

    Private Sub MainNotaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
          MDIFormListPreRegistro.MdiParent = Me
        MDIFormListPreRegistro.WindowState = 2
        MDIFormListPreRegistro.Show()

    End Sub

    Private Sub QRibbonPage1_Deactivated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRibbonPage1.Deactivated


    End Sub
End Class