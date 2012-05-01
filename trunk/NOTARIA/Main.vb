Public Class Main


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        Me.Hide()
        LstPreRegistros.Show()
    End Sub

End Class