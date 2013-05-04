Imports MySql.Data.MySqlClient

Public Class frmBautizo

    Private connectionMysql As String = My.Settings.connectionDB
    Private query As String

    Private Sub frmBautizo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conn As New MySqlConnection(connectionMysql)
        Dim conn2 As New MySqlConnection(connectionMysql)

        Try
            conn.Open()
            'MessageBox.Show("Connection Opened Successfully")
            query = "SELECT * FROM tb_admin"

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
            Dim aux As String
            Dim aryTextFile() As String

            For Each row In dt.Rows
                aux = row("lstannos")
            Next

            aryTextFile = aux.Split(",")
            cmbannobau.Items.AddRange(aryTextFile)
            cmbannonac.Items.AddRange(aryTextFile)

            conn.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub
End Class