Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class LstPreRegistros
    Private connectionMysql As String = My.Settings.connectionDB
    Private query As String
    Dim row As Integer

    Private Sub btnPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrincipal.Click
        Me.Hide()
        Main.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        PreRegistro.Show()
    End Sub

    Private Sub LstPreRegistros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection(connectionMysql)

        'conn.ConnectionString = "server=SQL09.FREEMYSQL.NET; user id=notariasma; password=zaq12wsx; database=notariabd"

        Try
            conn.Open()
            'MessageBox.Show("Connection Opened Successfully")
            query = "SELECT idregistro as ID_Preregistro, nombre as Nombre, apepat as Apellido_Paterno, apemat as Apellido_Materno, nombrepapa as Nombre_Papa, nombremama as Nombre_Mama FROM tb_preregistro"

            'create data adapter
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, conn)

            Dim dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'Dim invId As Object = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        'inventoryIdLabel.Text = Convert.ToString(invId)
        Dim invId As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        inventoryIdLabel.Text = Convert.ToString(invId)
        PreRegistro.txtid.Text = Convert.ToString(invId)
        PreRegistro.Show()
        'Me.Close()

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim conn As New MySqlConnection(connectionMysql)

        'conn.ConnectionString = "server=SQL09.FREEMYSQL.NET; user id=notariasma; password=zaq12wsx; database=notariabd"

        Try
            conn.Open()
            'MessageBox.Show("Connection Opened Successfully")
            query = "SELECT idregistro as ID_Preregistro, nombre as Nombre, apepat as Apellido_Paterno, apemat as Apellido_Materno, nombrepapa as Nombre_Papa, nombremama as Nombre_Mama FROM test.tb_preregistro"

            'create data adapter
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, conn)

            Dim dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        Dim button As DialogResult
        button = MessageBox.Show _
        ("Estas seguro que deseas borrar el registro :  " + DataGridView1.SelectedCells(0).Value.ToString + ".- " + DataGridView1.SelectedCells(1).Value.ToString + " " + DataGridView1.SelectedCells(2).Value.ToString + " " + DataGridView1.SelectedCells(3).Value.ToString + " ?", _
        "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If button = Windows.Forms.DialogResult.Yes Then
            'MsgBox("Borrar registro")
            ' Codigo para borrar registro
            Dim conn As New MySqlConnection(connectionMysql)

            Try
                conn.Open()
                'MessageBox.Show("Connection Opened Successfully")
                query = "DELETE FROM tb_preregistro WHERE idregistro=" + DataGridView1.SelectedCells(0).Value.ToString

                'create data adapter
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, conn)

                Dim dt = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
                conn.Close()

            Catch myerror As MySqlException
                MessageBox.Show("Error Connecting to Database: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try
        End If

    End Sub

    Private Sub btnBorrarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarTodos.Click
        Dim button As DialogResult
        button = MessageBox.Show _
        ("Estas seguro que deseas borrar todos los registros.", _
        "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If button = Windows.Forms.DialogResult.Yes Then
            MsgBox("Borrar registro")
            ' Codigo para borrar registro
            Dim conn As New MySqlConnection(connectionMysql)

            Try
                conn.Open()
                'MessageBox.Show("Connection Opened Successfully")
                query = "DELETE FROM tb_preregistro"

                'create data adapter
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, conn)

                Dim dt = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
                conn.Close()

            Catch myerror As MySqlException
                MessageBox.Show("Error Connecting to Database: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try

        End If
    End Sub

    Private Sub btnCrearBautizo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearBautizo.Click

        Dim invId As Object = DataGridView1.SelectedCells(0).Value.ToString

        frmBautizo.txtPrereg.Text = Convert.ToString(invId)
        frmBautizo.Show()

    End Sub
End Class