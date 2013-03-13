Imports MySql.Data.MySqlClient

Public Class EditUser

    Private oldName As String = ""

    Private Sub EditUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'poblar el usuario
        fillUsers()

        'poblar el perfil
        fillPerfil()


    End Sub


    Private Sub lbUsuarios_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbUsuarios.SelectedValueChanged
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.selectUserByNombre, connection)
        Dim reader As MySqlDataReader
        Dim idRol As Integer = 0


        Try

            connection.Open()

            cmd.Parameters.AddWithValue("@name", lbUsuarios.Text)

            reader = cmd.ExecuteReader

            While reader.Read

                qtbUser.Text = CStr(reader.GetString(2))

                'OldName
                oldName = qtbUser.Text

                qtbPass.Text = CStr(reader.GetString(3))

                idRol = Val(reader.GetString(1))

                qcbRol.Text = getNamefromUser(idRol)


            End While



        Catch ex As Exception

        Finally

            connection.Close()

        End Try

    End Sub


    Private Sub fillUsers()
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(My.Resources.selectUserNombre, connection)
        Dim ds As New DataSet

        Try
            connection.Open()

            If da.Fill(ds) Then

                lbUsuarios.DataSource = ds.Tables(0)

                lbUsuarios.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
            End If

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        Finally

            connection.Close()

        End Try

    End Sub

    Private Sub fillPerfil()
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(My.Resources.selectRoltipo, connection)
        Dim ds As DataSet = New DataSet

        Try

            connection.Open()

            If da.Fill(ds) Then

                qcbRol.DataSource = ds.Tables(0)

                qcbRol.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString

            End If

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        Finally

            connection.Close()

        End Try



    End Sub




    Function getNamefromUser(ByVal idRol As Integer) As String
        Dim connect As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.selectRolTipoRolByIdRol, connect)
        Dim user As String = ""
        Dim reader As MySqlDataReader

        Try
            connect.Open()

            cmd.Parameters.AddWithValue("@idRol", idRol)

            reader = cmd.ExecuteReader

            While reader.Read

                user = reader.GetString(0)

            End While


        Catch ex As Exception

            Console.WriteLine(ex.Message)

        Finally

            connect.Close()

        End Try

        Return user

    End Function


    Private Sub qcbDelete_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbDelete.ItemActivated
        Dim connect As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.deleteUserByName, connect)
        Dim answer As DialogResult = MessageBox.Show("¿Está seguro de eliminar al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If answer = Windows.Forms.DialogResult.Yes Then
            Try

                connect.Open()

                cmd.Parameters.AddWithValue("@name", qtbUser.Text)

                cmd.ExecuteNonQuery()

            Catch ex As Exception

                Console.WriteLine(ex.Message)

            Finally

                connect.Close()

                lbUsuarios.Text = ""

                fillUsers()

            End Try

        End If




    End Sub


    Private Sub qcbGuardar_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbGuardar.ItemActivated
        Dim connect As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.updateUserByName, connect)
        Dim answer As DialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Cambios pendientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If answer = Windows.Forms.DialogResult.Yes Then
            Try
                'UPDATE usuario SET nombre = , password = , idrol =  WHERE nombre = 
                connect.Open()

                cmd.Parameters.AddWithValue("@newName", qtbUser.Text)

                cmd.Parameters.AddWithValue("@pass", qtbPass.Text)

                cmd.Parameters.AddWithValue("@idRol", getIdRol(qcbRol.Text))

                cmd.Parameters.AddWithValue("@oldName", oldName)

                cmd.ExecuteNonQuery()




            Catch ex As Exception

                Console.WriteLine(ex.Message)

            Finally

                connect.Close()

            End Try

        End If

    End Sub

    Function getIdRol(ByVal name As String) As Integer
        Dim idRol As Integer = 0
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.selectRolByTipoRol, connection)

        Try
            connection.Open()

            cmd.Parameters.AddWithValue("@tipoRol", name)

            reader = cmd.ExecuteReader

            While reader.Read

                idRol = Val(reader.GetString(0))

            End While

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        Finally

            connection.Close()

        End Try

        Return idRol

    End Function


    Private Sub qcbCancelar_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbCancelar.ItemActivated

        NOTARIA.MainNotaria.qcbEditUser.Enabled = True

        Me.Close()


    End Sub

    
End Class