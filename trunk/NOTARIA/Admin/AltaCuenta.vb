Imports MySql.Data.MySqlClient

Public Class AltaCuenta

    Private connectionMysql As String = My.Settings.connectionDB

    Private Sub AltaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection(connectionMysql)
        Dim da As New MySqlDataAdapter(My.Resources.selectRoltipo, connection)
        Dim ds As New DataSet

        Try
            'Para llenar el select con la info de la tabla
            connection.Open()
            If da.Fill(ds) Then
                qcbPerfil.DataSource = ds.Tables(0)
                qcbPerfil.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally

            connection.Close()

        End Try
    End Sub

    Private Sub qcbSigAltaCuenta_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbSigAltaCuenta.ItemActivated
        Dim connection As New MySqlConnection(connectionMysql)
        Dim query = My.Resources.selectUser & " WHERE nombre = " & Chr(39) & qcibUser.InputBox.Text & Chr(39)
        Dim da As New MySqlDataAdapter(query, connection)
        Dim dt As DataTable = New DataTable
        Dim cmdSelect, cmdInsert As MySqlCommand
        Dim reader As MySqlDataReader
        Dim idRol As Integer = 0


        Try

            connection.Open()

            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                qctNotification.Title = "Usuario ya existe, introduzca otro"


            Else
                'select id perfil
  
                cmdSelect = New MySqlCommand(My.Resources.selectRolByTipoRol, connection)

                cmdSelect.Parameters.AddWithValue("@tipoRol", qcbPerfil.Text)

                reader = cmdSelect.ExecuteReader

                While reader.Read
                    idRol = Val(reader.GetString(0))
  
                End While

                reader.Close()



                'insert into en tabla Usuario
                cmdInsert = New MySqlCommand(My.Resources.insertUser, connection)

                cmdInsert.Parameters.AddWithValue("@name", qcibUser.InputBox.Text)

                cmdInsert.Parameters.AddWithValue("@pass", qcibPass.InputBox.Text)

                cmdInsert.Parameters.AddWithValue("@idrol", idRol)

                cmdInsert.ExecuteNonQuery()



            End If

        Catch ex As Exception

            Console.WriteLine(ex.Message)

            qctNotification.Title = "hay un error"

        Finally

            connection.Close()

            NOTARIA.MainNotaria.qcbNuevoAdmin.Enabled = True

            Me.Close()

        End Try




    End Sub


    Private Sub qcibUser_InputBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qcibUser.InputBox.TextChanged

        qctNotification.Title = ""

    End Sub


  
    Private Sub qcbCanAltaCuenta_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbCanAltaCuenta.ItemActivated

        NOTARIA.MainNotaria.qcbNuevoAdmin.Enabled = True

        Me.Close()

    End Sub

    Private Sub resetComponent()

        qcibUser.InputBox.Text = ""
        qcibPass.InputBox.Text = ""



    End Sub

    Private Sub qccAltaCuenta_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qccAltaCuenta.ItemActivated

    End Sub
End Class