Public Class LstPreRegistros

    Private Sub btnPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrincipal.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.Hide()
        PreRegistro.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        PreRegistro2.show()
    End Sub
End Class