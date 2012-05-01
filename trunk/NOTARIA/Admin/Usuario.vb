Public Class Usuario



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtnombre.Text = "" Then
            MsgBox("Por favor ingresa valor en campo nombre")
            Exit Sub
        ElseIf txtusuario.Text = "" Then
            MsgBox("Por favor ingresa valor en campo usuario")
            Exit Sub
        ElseIf txtpass.Text = "" Then
            MsgBox("Por favor ingresa valor en campo contraseña")
            Exit Sub
        ElseIf cmbRol.Text = "" Then
            MsgBox("Por favor selecciona el rol")
            Exit Sub
        End If

        MsgBox("Guardar Datos")

        Me.Hide()
        LstUsuarios.Show()

    End Sub
End Class