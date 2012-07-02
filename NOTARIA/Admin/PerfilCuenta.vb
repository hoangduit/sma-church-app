Imports MySql.Data.MySqlClient

Public Class PerfilCuenta

     Private Sub PerfilCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection(My.Settings.connectionDB)

        Try
            Dim da As New MySqlDataAdapter(My.Resources.selectApplication, connection)
            Dim ds As New DataSet

            connection.Open()

            If da.Fill(ds) Then

                dgvApplication.DataSource = ds.Tables(0)

            End If

            dgvApplication.Columns(1).HeaderText = "Modulo"

            dgvApplication.Columns(2).HeaderText = "Activado"

            dgvApplication.Columns(0).Visible = False


        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()

        End Try

    End Sub

    Private Sub qcbGuardar_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbGuardar.ItemActivated
        Dim idRol As Integer = 0

        'Insert Rol
        insertRol(My.Resources.insertRol, qcibPerfil.InputBox.Text)

        For Each row As DataGridViewRow In dgvApplication.Rows
            'Console.WriteLine(row.Cells(0).FormattedValue & " | " & row.Cells(1).FormattedValue)
            If Convert.ToBoolean(row.Cells(2).FormattedValue) Then
                Try

                    'Select rol
                    idRol = getIdRol(My.Resources.selectRolByTipoRol, qcibPerfil.InputBox.Text)

                    'InsertRolApplication
                    insertRolApplication(My.Resources.insertAplicationRol, idRol, Val(row.Cells(0).FormattedValue))


                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            End If

        Next row

        NOTARIA.MainNotaria.qclmiRole.Enabled = True

        Me.Close()




    End Sub



    Function insertRol(ByVal query As String, ByVal param As String) As Integer
        Dim connectDB As New MySqlConnection(My.Settings.connectionDB)
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.insertRol, connectDB)
        Dim rowEffect As Integer = 0

        Try
            connectDB.Open()

            cmd.Parameters.AddWithValue("@tipoRol", qcibPerfil.InputBox.Text)

            rowEffect = cmd.ExecuteNonQuery()


        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally

            connectDB.Close()

        End Try

        Return rowEffect

    End Function


    Function getIdRol(ByVal query As String, ByVal rol As String) As Integer
        Dim connectDB As New MySqlConnection(My.Settings.connectionDB)
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.selectRolByTipoRol, connectDB)
        Dim reader As MySqlDataReader
        Dim idRol As Integer = 0

        Try
            connectDB.Open()

            cmd.Parameters.AddWithValue("@tipoRol", rol)

            reader = cmd.ExecuteReader

            While reader.Read

                idRol = Val(reader.GetString(0))

            End While

            reader.Close()

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        Finally

            connectDB.Close()

        End Try

        Return idRol

    End Function


    Function insertRolApplication(ByVal query As String, ByVal idRol As Integer, ByVal idApp As Integer)
        Dim connectDB As New MySqlConnection(My.Settings.connectionDB)
        Dim cmd As MySqlCommand = New MySqlCommand(My.Resources.insertAplicationRol, connectDB)
        Dim rowEffect As Integer = 0

        Try
            connectDB.Open()

            cmd.Parameters.AddWithValue("@idRol", idRol)

            cmd.Parameters.AddWithValue("@idAplication", idApp)

            rowEffect = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return rowEffect

    End Function

    Private Sub qcbCancelar_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbCancelar.ItemActivated

        NOTARIA.MainNotaria.qclmiRole.Enabled = True

        Me.Close()

    End Sub
End Class

