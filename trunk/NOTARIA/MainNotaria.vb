﻿Imports MySql.Data.MySqlClient
Public Class MainNotaria
    Public currentPerfil As Integer
    Private Sub AccessControl()
        Dim listModule As New List(Of String)
        Dim connectionMysql As String = My.Settings.connectionDB
        Dim connect As MySqlConnection = New MySqlConnection(connectionMysql)
        Dim command As MySqlCommand = New MySqlCommand(My.Resources.selectModuleByIdRol, connect)
        Dim reader As MySqlDataReader
        Dim modulo As String = ""
        Dim query As String = ""

        Try
            connect.Open()

            command.Parameters.AddWithValue("@tipoRol", currentPerfil)

            reader = command.ExecuteReader

            While reader.Read
                modulo = reader.GetString(0)
                listModule.Add(modulo.Trim)
                'MessageBox.Show("Modulo " + modulo)

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            connect.Close()

        End Try

        listModule.Sort()

        If listModule.Count > 0 Then

            For Each page As Qios.DevSuite.Components.Ribbon.QRibbonPage In QRibbon1.Controls

                If listModule.IndexOf(page.Text.Trim) >= 0 Then
                    page.Enabled = True


                Else
                    page.Enabled = False

                End If
            Next

        End If

    End Sub
    'Oculta los modulos
    Private Sub desactiveAllPage()

        For Each page As Qios.DevSuite.Components.Ribbon.QRibbonPage In QRibbon1.Controls

            page.Ribbon.Visible = False

        Next

    End Sub

    Private Function hasObject(ByVal modulo As String, ByVal name As String) As Boolean
        Return (modulo.Equals(name))
    End Function

    Private Sub QCompositeButton1_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbNuevoPre.ItemActivated
        Dim MDIFormListPreRegistro As New LstPreRegistros
        CloseAllMDIChild()
        MDIFormListPreRegistro.MdiParent = Me
        MDIFormListPreRegistro.WindowState = 2
        MDIFormListPreRegistro.Show()

      
    End Sub

    Private Sub QCompositeButton4_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbNuevoAdmin.ItemActivated
        Dim MDIFormAlta As New AltaCuenta
        CloseAllMDIChild()
        MDIFormAlta.MdiParent = Me
        MDIFormAlta.WindowState = 2
        MDIFormAlta.Show()

    End Sub

    Private Sub QCompositeLargeMenuItem1_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qclmiRole.ItemActivated
        Dim MDIFormPerfilCuenta As New PerfilCuenta
        CloseAllMDIChild()
        MDIFormPerfilCuenta.MdiParent = Me
        MDIFormPerfilCuenta.WindowState = 2
        MDIFormPerfilCuenta.Show()
    End Sub


    Private Sub QRibbonPage2_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qrPageBautizos.Activated
        'Ejemplo para llamar el formulario hijo
        '=====================================
        'Dim MDIPreRegistro As New PreRegistro
        'CloseAllMDIChild()
        'MDIPreRegistro.MdiParent = Me
        'MDIPreRegistro.WindowState = 2
        'MDIPreRegistro.Show()
        '=====================================
        'Aqui va el formulario de Bautizos

    End Sub


    Private Sub MainNotaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MDIWelcomeApp As New Welcome
        'CloseAllMDIChild()
        MDIWelcomeApp.MdiParent = Me
        MDIWelcomeApp.WindowState = 2
        MDIWelcomeApp.Show()
        'desactiveAllPage()
        AccessControl()



    End Sub

    'Con este metodo se cierran todos los forms hijos en la aplicacion
    Private Sub CloseAllMDIChild()

        Dim len = Me.MdiChildren.Length - 1
        If Me.MdiChildren.Length > 0 Then
            For i = 0 To len
                Me.MdiChildren(i).Close()
            Next
        End If

    End Sub

    Private Sub qrPagePreRegistro_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qrPagePreRegistro.Activated
        CloseAllMDIChild()
        'Pendiente encontrar como cargar la lista de preregistros

    End Sub

    Private Sub qrPageAdmin_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qrPageAdmin.Activated
        Dim MDIFormAlta As New AltaCuenta
        CloseAllMDIChild()
        MDIFormAlta.MdiParent = Me
        MDIFormAlta.WindowState = 2
        MDIFormAlta.Show()
    End Sub

    Private Sub qcbEditUser_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbEditUser.ItemActivated
        Dim MDIFormEditUser As New EditUser
        CloseAllMDIChild()
        MDIFormEditUser.MdiParent = Me
        MDIFormEditUser.WindowState = 2
        MDIFormEditUser.Show()

    End Sub

    Private Sub qcbEditRole_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbEditRole.ItemActivated
        Dim MDIFormEditRole As New EditRole
        CloseAllMDIChild()
        MDIFormEditRole.MdiParent = Me
        MDIFormEditRole.WindowState = 2
        MDIFormEditRole.Show()
    End Sub



    Private Sub MainNotaria_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub QCompositeButton1_ItemActivated_1(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles QCompositeButton1.ItemActivated
        Dim MDIPreRegistros As New PreRegistro
        CloseAllMDIChild()
        MDIPreRegistros.MdiParent = Me
        MDIPreRegistros.WindowState = 2
        MDIPreRegistros.Show()
    End Sub


    Private Sub QCompositeButton6_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles QCompositeButton6.ItemActivated
        Dim MDIBautizo As New frmBautizo
        CloseAllMDIChild()
        MDIBautizo.MdiParent = Me
        MDIBautizo.WindowState = 2
        MDIBautizo.Show()
    End Sub

    Private Sub QCompositeButton2_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles QCompositeButton2.ItemActivated
        Dim MDILstBautizo As New frmLstBautizados
        CloseAllMDIChild()
        MDILstBautizo.MdiParent = Me
        MDILstBautizo.WindowState = 2
        MDILstBautizo.Show()
    End Sub

    Private Sub QCompositeButton7_ItemActivated(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles qcbConfiguration.ItemActivated

    End Sub

    Private Sub QCompositeButton4_ItemActivated_1(ByVal sender As System.Object, ByVal e As Qios.DevSuite.Components.QCompositeEventArgs) Handles QCompositeButton4.ItemActivated
        Dim button As DialogResult
        Dim query As String
        button = MessageBox.Show _
        ("Estas seguro que deseas borrar el registro :  " + LstPreRegistros.DataGridView1.SelectedCells(0).Value.ToString + ".- " + LstPreRegistros.DataGridView1.SelectedCells(1).Value.ToString + " " + LstPreRegistros.DataGridView1.SelectedCells(2).Value.ToString + " " + LstPreRegistros.DataGridView1.SelectedCells(3).Value.ToString + " ?", _
        "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If button = Windows.Forms.DialogResult.Yes Then
            'MsgBox("Borrar registro")
            ' Codigo para borrar registro
            'Dim conn2 As New MySqlConnection(ConnectionState)

            Try
                'conn2.Open()
                'MessageBox.Show("Connection Opened Successfully")
                query = "DELETE FROM tb_preregistro WHERE idregistro=" + LstPreRegistros.DataGridView1.SelectedCells(0).Value.ToString

                'create data adapter
                'Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, conn2)

                'Dim dt = New DataTable
                'da.Fill(dt)
                'LstPreRegistros.DataGridView1.DataSource = dt
                'conn2.Close()

            Catch myerror As MySqlException
                MessageBox.Show("Error Connecting to Database: " & myerror.Message)
            Finally
                'conn2.Dispose()
            End Try
        End If
    End Sub
End Class