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
        ElseIf cmbdianac.SelectedText = "" Then
            MsgBox("Por favor selecciona el dia de nacimiento")
            cmbdianac.Focus()
            Exit Sub
        ElseIf cmbmesnac.SelectedText = "" Then
            MsgBox("Por favor selecciona el mes de nacimiento")
            cmbmesnac.Focus()
            Exit Sub
        ElseIf cmbannonac.SelectedText = "" Then
            MsgBox("Por favor selecciona el año de nacimiento")
            cmbannonac.Focus()
            Exit Sub
        ElseIf cmbdiabau.SelectedText = "" Then
            MsgBox("Por favor selecciona el dia de bautizo")
            cmbdiabau.Focus()
            Exit Sub
        ElseIf cmbmesbau.SelectedText = "" Then
            MsgBox("Por favor selecciona el mes de bautizo")
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

        MsgBox("Gudardar")

        'Me.Close()
        'LstPreRegistros.Show()
    End Sub

    Private Sub PreRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection
        Dim sql As String


        If txtid.Text = "" Then
            'Nuevo Registro
            conn = New MySqlConnection()
            conn.ConnectionString = "server=localhost; user id=root; password=nota2012; database=test"

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

                For Each row In dt.Rows
                    aux = row("lstannos")
                Next

                aux.Split(",")
                For Each elemento In aux
                    cmbannobau(renglon).Text = aux(renglon)

                Next



                conn.Close()

            Catch myerror As MySqlException
                MessageBox.Show("Error Connecting to Database: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try


        Else
            'Registro existente

        End If
    End Sub
End Class