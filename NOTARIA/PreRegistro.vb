Imports MySql.Data.MySqlClient


Public Class PreRegistro
    Private connectionMysql As String = My.Settings.connectionDB
    Private query As String


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

        ' usuario (nombre, password,idrol) VALUES(@name, @pass, @idrol)
        query = "INSERT INTO tb_preregistro (nombre, apepat, apemat, nombrepapa, nombremama, nombreapp, nombreamp, nombreamp, nombreamm, nombrepadrino, nombremadrina, dianac, mesnac, annonac, diabau, mesbau, annobau)"
        query = query + "VALUES (" + txtnombre.Text + ", " + txtapepat.Text + ", " + txtapemat.Text + ", " + txtnompapa.Text + " ," + txtnommama.Text + ", " + txtnomapp.Text + " ," + txtnomapm.Text + " ," + txtnomamp.Text + " ," + txtnomamm.Text + " ," + txtnompad.Text + " ," + txtnommad.Text + " ," + cmbdianac.Text + " ," + cmbmesnac.Text + " ," + cmbannonac.Text + " ," + cmbdiabau.Text + " ," + cmbmesbau.Text + " ," + cmbannobau.Text + ")"
        MsgBox(query)

        Dim conn As New MySqlConnection(connectionMysql)

        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
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



        'Me.Close()+
        'LstPreRegistros.Show()
    End Sub

    Private Sub PreRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection(connectionMysql)
        Dim conn2 As New MySqlConnection(connectionMysql)

        'conn.ConnectionString = "server=SQL09.FREEMYSQL.NET; user id=notariasma; password=zaq12wsx; database=notariabd"

        'MsgBox(txtid.Text)

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
            query = "SELECT * FROM test.tb_preregistro WHERE idregistro=" + txtid.Text

            'MsgBox(query)

            'create data adapter
            'Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)

            'MsgBox("0")
            'create data reader
            ' Dim dr As MySqlDataReader = New MySqlDataReader
            Dim myCommand As MySqlCommand

            'MsgBox("1")
            conn2.Open()

            myCommand = New MySqlCommand(query, conn2)

            'executing the command and assigning it to connection 
            Dim dr As MySqlDataReader

            dr = myCommand.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Me.txtnombre.Text = dr(1).ToString
                Me.txtapepat.Text = dr(2).ToString
                Me.txtapemat.Text = dr(3).ToString
                Me.txtnompapa.Text = dr(4).ToString
                Me.txtnommama.Text = dr(5).ToString
                'abuelos paternos
                Me.txtnomapp.Text = dr(6).ToString
                Me.txtnomapm.Text = dr(8).ToString
                'abuelos maternos
                Me.txtnomamp.Text = dr(7).ToString
                Me.txtnomamm.Text = dr(9).ToString
                'padrinos
                Me.txtnompad.Text = dr(10).ToString
                Me.txtnommad.Text = dr(11).ToString
                'dia nac
                Me.cmbdianac.Text = dr(15).ToString
                Me.cmbmesnac.Text = dr(16).ToString
                Me.cmbannonac.Text = dr(17).ToString
                'dia bautizo
                Me.cmbdiabau.Text = dr(12).ToString
                Me.cmbmesbau.Text = dr(13).ToString
                Me.cmbannobau.Text = dr(14).ToString
            End If

            conn2.Close()


        End If

    End Sub

  
End Class