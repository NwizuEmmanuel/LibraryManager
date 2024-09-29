Imports System.Configuration
Imports System.Data.SqlClient

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username = EmailTextBox.Text
        Dim password = PasswordTextBox.Text
        Dim connString = ConfigurationManager.ConnectionStrings("LibraryDB").ConnectionString

        Using connection As New SqlConnection(connString)
            Dim query = "
                SELECT [LibrarianId] FROM [Librarians] WHERE [Email]=@email AND
                [Password]=@pass
"
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()

                    command.Parameters.AddWithValue("@email", EmailTextBox.Text)
                    command.Parameters.AddWithValue("@pass", PasswordTextBox.Text)

                    Dim userCount As Integer = CInt(command.ExecuteScalar())

                    If userCount > 0 Then
                        ' Go to next form
                        Me.Hide()
                        MainMenu.Show()
                    Else
                        MessageBox.Show("User does not exists.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
