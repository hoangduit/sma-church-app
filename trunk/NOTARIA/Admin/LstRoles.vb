Public Class LstRoles


    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.Hide()
        Rol.Show()
    End Sub
End Class