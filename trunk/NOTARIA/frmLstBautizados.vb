Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmLstBautizados
    Private connectionMysql As String = My.Settings.connectionDB
    Private query As String
    Dim row As Integer

    Private Sub frmLstBautizados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection(connectionMysql)

        'conn.ConnectionString = "server=SQL09.FREEMYSQL.NET; user id=notariasma; password=zaq12wsx; database=notariabd"

        Try
            conn.Open()
            'MessageBox.Show("Connection Opened Successfully")
            query = "SELECT idregistrobau as ID_Bautizo, nombre as Nombre, apepat as Apellido_Paterno, apemat as Apellido_Materno, nombrepapa as Nombre_Papa, nombremama as Nombre_Mama FROM test.tb_registro_bautizo WHERE status='Nuevo'"

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
        frmBautizo.txtid.Text = Convert.ToString(invId)
        frmBautizo.Show()
        'Me.Close()

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim conn As New MySqlConnection(connectionMysql)

        Try
            conn.Open()
            'MessageBox.Show("Connection Opened Successfully")
            query = "SELECT idregistrobau as ID_Preregistro, nombre as Nombre, apepat as Apellido_Paterno, apemat as Apellido_Materno, nombrepapa as Nombre_Papa, nombremama as Nombre_Mama FROM tb_registro_bautizo"

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
End Class