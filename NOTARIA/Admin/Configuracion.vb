Imports MySql.Data.MySqlClient


Public Class Configuracion
    Private connectionMysql As String = My.Settings.connectionDB
    Private query As String

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim conn As New MySqlConnection(connectionMysql)


        Try
            conn.Open()
            query = "UPDATE test.tb_admin SET lstannos = '" + txtannos.Text + "'"

            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            'MsgBox(sql)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                'MsgBox("Record is Successfully Updated")
                Me.Hide()
                'Admin.Show()
            Else
                MsgBox("Record is not Updated")
            End If

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub Configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection(connectionMysql)

        Try
            conn.Open()
            'MessageBox.Show("Connection Opened Successfully")
            query = "SELECT * FROM test.tb_admin"

            'create data adapter
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, conn)

            'create dataset
            Dim ds As DataSet = New DataSet

            'fill dataset
            da.Fill(ds, "tb_admin")

            'get data table
            Dim dt As DataTable = ds.Tables("tb_admin")

            'display data
            Dim row As DataRow

            For Each row In dt.Rows
                txtannos.Text = row("lstannos")
            Next

            conn.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub

    Private Sub MySqlDataAdapter()
        Throw New NotImplementedException
    End Sub

End Class