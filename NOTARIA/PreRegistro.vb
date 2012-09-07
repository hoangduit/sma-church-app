Imports MySql.Data.MySqlClient


Public Class PreRegistro


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If txtnombre.Text = "" Then
            MsgBox("Por favor ingresar valor en el campo nombre")
            txtnombre.Focus()
            Exit Sub
        ElseIf txtapepat.Text = "" Then
            MsgBox("Por favor ingresa valor en el campo apellido paterno")
            txtapepat.Focus()
            Exit Sub
        ElseIf txtapemat.Text = "" Then
            MsgBox("Por favor ingresa valor en el campo apellido materno")
            txtapemat.Focus()
            Exit Sub
            'ElseIf cmbdianac.SelectedText = "" Then
        ElseIf cmbdianac.SelectedIndex.Equals(-1) Then
            MsgBox("Por favor selecciona el dia de nacimiento")
            cmbdianac.Focus()
            Exit Sub
        ElseIf cmbmesnac.SelectedIndex.Equals(-1) Then
            MsgBox("Por favor selecciona el mes de nacimiento")
            cmbmesnac.Focus()
            Exit Sub
        ElseIf cmbannonac.SelectedIndex.Equals(-1) Then
            MsgBox("Por favor selecciona el año de nacimiento")
            cmbannonac.Focus()
            Exit Sub
        ElseIf cmbdiabau.SelectedIndex.Equals(-1) Then
            MsgBox("Por favor selecciona el dia de bautizo")
            cmbdiabau.Focus()
            Exit Sub
        ElseIf cmbmesbau.SelectedIndex.Equals(-1) Then
            MsgBox("Por favor selecciona el mes de bautizo")
            cmbmesbau.Focus()
            Exit Sub
        ElseIf cmbannobau.SelectedIndex.Equals(-1) Then
            MsgBox("Por favor selecciona el año de bautizo")
            cmbmesbau.Focus()
            Exit Sub
        ElseIf txtnompapa.Text = "" Then
            MsgBox("Por favor ingresa el nombre del papa")
            txtnompapa.Focus()
            Exit Sub
        ElseIf txtnommama.Text = "" Then
            MsgBox("Por favor ingresa el nombre de la mama")
            txtnommama.Focus()
            Exit Sub
        ElseIf txtnomapp.Text = "" Then
            MsgBox("Por favor ingresa el nombre del abuelo paterno")
            txtnomapp.Focus()
            Exit Sub
        ElseIf txtnomapm.Text = "" Then
            MsgBox("Por favor ingresa el nombre de la abuela paterna")
            txtnomapm.Focus()
            Exit Sub
        ElseIf txtnomamp.Text = "" Then
            MsgBox("Por favor ingresa el nombre del abuelo materno")
            txtnomamp.Focus()
            Exit Sub
        ElseIf txtnomamm.Text = "" Then
            MsgBox("Por favor ingresa el nombre de la abuela materna")
            txtnomamm.Focus()
            Exit Sub
        ElseIf txtnompad.Text = "" Then
            MsgBox("Por favor ingresa el nombre del padrino")
            txtnompad.Focus()
            Exit Sub
        ElseIf txtnommad.Text = "" Then
            MsgBox("Por favor ingresa el nombre de la madrina")
            txtnommad.Focus()
            Exit Sub
        End If

        MsgBox("Guardar")

        'Me.Close()+
        'LstPreRegistros.Show()
    End Sub

    Private Sub PreRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn, conn2 As MySqlConnection
        Dim sql As String

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost; user id=root; password=nota2012; database=test"
        'conn.ConnectionString = "server=SQL09.FREEMYSQL.NET; user id=notariasma; password=zaq12wsx; database=notariabd"

        'MsgBox(txtid.Text)

        Try
            conn.Open()
            'MessageBox.Show("Connection Opened Successfully")
            sql = "SELECT * FROM test.tb_admin"

            'create data adapter
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)

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



        If txtid.Text = "" Then
            ' New Record
        Else
            ' Existing Record
            sql = "SELECT * FROM test.tb_preregistro WHERE idregistro=" + txtid.Text

            MsgBox(sql)

            'create data adapter
            'Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)

            conn2 = New MySqlConnection()
            conn2.ConnectionString = "server=localhost; user id=root; password=nota2012; database=test"
            MsgBox("0")
            'create data reader
            ' Dim dr As MySqlDataReader = New MySqlDataReader
            Dim myCommand As MySqlCommand

            MsgBox("1")


            myCommand = New MySqlCommand(sql, conn2)
            MsgBox("12")

            'executing the command and assigning it to connection 
            'dr = myCommand.ExecuteReader()
            'Me.txtnombre.Text = dr(1).ToString
            ' MsgBox(dr(1).ToString)


        End If

    End Sub

  
End Class