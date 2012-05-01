Public Class Admin

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click
        Me.Hide()
        LstUsuarios.Show()
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnconf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconf.Click
        Me.Hide()
        Configuracion.Show()
    End Sub

    Private Sub btnroles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnroles.Click
        Me.Hide()
        LstRoles.Show()
    End Sub
End Class