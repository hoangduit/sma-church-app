Public Class Rol

  
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtnombre.Text = "" Then
            MsgBox("Por favor ingresa valor en campo nombre")
            Exit Sub
        End If

        Me.Hide()
        LstRoles.Show()

    End Sub
End Class