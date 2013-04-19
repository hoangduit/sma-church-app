Imports MySql.Data.MySqlClient
Public Class LoginNotaria
    Dim connectionMysql As String = My.Settings.connectionDB
    Dim idrol As Integer 'id del perfil 
    
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If isUserValido() Then
            Dim main As New MainNotaria
            main.currentPerfil = idrol
            main.Show()
            Me.Visible = False
     
        Else
            MessageBox.Show("Usuario Invalido")

        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Function isUserValido() As Boolean
        Dim isUser As Boolean = False
        Dim connection As MySqlConnection = New MySqlConnection(connectionMysql)
        Dim query As MySqlCommand = New MySqlCommand(My.Resources.selectUserByNamePass, connection)
        Dim reader As MySqlDataReader
        Dim user As String = UsernameTextBox.Text
        Dim pass As String = PasswordTextBox.Text

        Try
            connection.Open()

            query.Parameters.AddWithValue("@name", user)

            query.Parameters.AddWithValue("@pass", pass)

            reader = query.ExecuteReader

            If reader.HasRows Then
                isUser = True
            End If

            While reader.Read
                idrol = Val(reader.GetString(1))
            End While


        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()

        End Try

        Return isUser

    End Function

End Class
