Imports MySql.Data.MySqlClient
Public Class EditRole

    Private connectionMysql As String = My.Settings.connectionDB
    Private idPerfil As Integer = 0
    Private typePerfil As String = ""
    Dim idAplicationRoleList As New List(Of Integer)
    Dim idAplicationRoleListInsert As New List(Of Integer)


    Private Sub desactiveAllModules()
        For index As Integer = 0 To dgvApplication.Rows.Count - 1
            dgvApplication.Rows(index).Cells(2).Value = False
        Next
    End Sub


    Private Sub FillRol()
        Dim connection As MySqlConnection = New MySqlConnection(connectionMysql)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(My.Resources.selectRoltipo, connection)
        Dim ds As New DataSet

        Try
            'Para llenar el combo desde la tabla rol
            connection.Open()
            If da.Fill(ds) Then
                qcbPerfil.DataSource = ds.Tables(0)
                qcbPerfil.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
            End If
            qcbPerfil.Text = "Seleccione un Perfil"

        Catch ex As Exception
            Console.WriteLine("Error:  " + ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Function getIdsApplicationRole(ByVal typeRol As Integer) As List(Of Integer)
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim command As MySqlCommand = New MySqlCommand(My.Resources.selectApplicationRole, connection)
        Dim reader As MySqlDataReader
        idAplicationRoleList = New List(Of Integer)
        Dim id As New Integer

        Try
            connection.Open()

            command.Parameters.AddWithValue("@tipoRol", idPerfil)

            reader = command.ExecuteReader()


            While reader.Read
                id = Val(reader.GetString(0))
                idAplicationRoleList.Add(id)
            End While
        Catch ex As Exception
            Console.WriteLine("Error:  " + ex.Message)
        Finally
            connection.Close()

        End Try
        Return idAplicationRoleList
    End Function

    Private Sub FillModule()
        Dim connection As New MySqlConnection(connectionMysql)
        Dim da As New MySqlDataAdapter(My.Resources.selectApplication, connection)
        Dim ds As New DataSet

        Try
            connection.Open()

            If da.Fill(ds) Then

                dgvApplication.DataSource = ds.Tables(0)

            End If
            dgvApplication.Columns(1).HeaderText = "Modulo"
            dgvApplication.Columns(2).HeaderText = "Activado"
            dgvApplication.Columns(0).Visible = False
            dgvApplication.AutoGenerateColumns = False
            'dgvApplication.Rows(2).Cells(2).Value = True para activar una casilla

        Catch ex As Exception
            Console.WriteLine("Error:  " + ex.Message)
        Finally
            connection.Close()

        End Try

    End Sub


    Private Sub EditRole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        qcbPerfil.CueText = "Seleccione un Perfil"

        dgvApplication.Focus()


        'Poblar combobox Rol
        FillRol()

        'Poblar tabla
        FillModule()

    End Sub

    'Para activar los checkbox
    Private Sub qcbPerfil_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qcbPerfil.SelectedValueChanged
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim command As MySqlCommand = New MySqlCommand(My.Resources.selectRolByTipoRol, connection)
        Dim reader As MySqlDataReader

        desactiveAllModules()


        typePerfil = qcbPerfil.Text

        Try
            connection.Open()

            command.Parameters.AddWithValue("@tipoRol", typePerfil)

            reader = command.ExecuteReader()


            While reader.Read
                idPerfil = Val(reader.GetString(0))
            End While
        Catch ex As Exception
            Console.WriteLine("Error:  " + ex.Message)
        Finally
            connection.Close()

        End Try

        For Each index As Integer In getIdsApplicationRole(idPerfil)
            dgvApplication.Rows(index - 1).Cells(2).Value = True
        Next

    End Sub

    Private Sub insertApplicationRol(ByVal idApp As Integer)
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim command As MySqlCommand = New MySqlCommand(My.Resources.insertAplicationRol, connection)

        Try
            connection.Open()

            command.Parameters.AddWithValue("@idRol", idPerfil)

                command.Parameters.AddWithValue("@idAplication", idApp)

                command.ExecuteNonQuery()

        Catch ex As Exception

            Console.WriteLine("Error Insert:  " + ex.Message)

        Finally

            connection.Close()

        End Try

    End Sub


    Private Sub deleteApplicationRole(ByVal idApp As Integer)
        Dim connection As MySqlConnection = New MySqlConnection(My.Settings.connectionDB)
        Dim command As MySqlCommand = New MySqlCommand(My.Resources.deleteApplicationRolebyIdApp, connection)

        Try
            connection.Open()
 
            command.Parameters.AddWithValue("@tipoRol", idPerfil)

            command.Parameters.AddWithValue("@idApp", idApp)

            command.ExecuteNonQuery()

        Catch ex As Exception

            Console.WriteLine("Error deleteOne:  " + ex.Message)

        Finally

            connection.Close()

        End Try

    End Sub
    'Metodo para que guarde automaticamente el datagrid sin necesidad que pierda el focus
    Private Sub dgvApplication_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvApplication.CurrentCellDirtyStateChanged

        If dgvApplication.IsCurrentCellDirty Then

            dgvApplication.CommitEdit(DataGridViewDataErrorContexts.Commit)

        End If

    End Sub

    'Para controlar el checkbox en la grilla
    Private Sub dgvApplication_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvApplication.CellContentClick
        Dim isChecked As Boolean = dgvApplication.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim idApp As Integer = dgvApplication.Rows(e.RowIndex).Cells(0).FormattedValue

        If isChecked = False Then

            deleteApplicationRole(idApp)

        Else

            insertApplicationRol(idApp)

        End If
    End Sub

    Private Sub qcBtnCancelar_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcBtnCancelar.ItemActivated
        Me.Close()
    End Sub
End Class