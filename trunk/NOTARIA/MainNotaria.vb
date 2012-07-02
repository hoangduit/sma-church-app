Public Class MainNotaria

   
    Private Sub QCompositeButton1_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbNuevoPre.ItemActivated
        Dim MDIFormPreRegistro As New PreRegistro
        MDIFormPreRegistro.MdiParent = Me
        MDIFormPreRegistro.WindowState = 2
        MDIFormPreRegistro.Show()



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
End Class