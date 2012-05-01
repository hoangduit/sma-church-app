Public Class PreRegistro


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtnombre.Text = "" Then
            MsgBox("Por favor ingresar el nombre")

        End If
    End Sub
End Class