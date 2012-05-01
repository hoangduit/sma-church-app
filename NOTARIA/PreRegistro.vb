Public Class PreRegistro


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtnombre.Text = "" Then
            MsgBox("Por favor ingresa valor en campo nombre")
            Exit Sub
        ElseIf txtapepat.Text = "" Then
            MsgBox("Por favor ingresa valor en campo apellido paterno")
            Exit Sub
        ElseIf txtapemat.Text = "" Then
            MsgBox("Por favor ingresa valor en campo apellido materno")
            Exit Sub
        End If
        MsgBox("Guardar")

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Hide()
        LstPreRegistros.Show()
    End Sub

  
End Class