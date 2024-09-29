Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AddBook
    Dim connString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

    Private Function AuthorDataCleaner(data As String)
        Dim result As String = Nothing

        Dim strings As String() = data.Trim.Split(";")
        For Each item In strings
            result += item.Trim & ";"
        Next

        Return result
    End Function

    Private Function AddNewBook()
        Dim noError = True
        Try
            Using connection As New SqlConnection(connString)
                Using command As New SqlCommand(
                    "insert into Books (ISBN,Title,Category,Publisher,PublishedDate,Authors) values (@isbn,@title,@category,@publisher,@publishedDate,@authors)",
                    connection
                    )
                    connection.Open()
                    command.Parameters.AddWithValue("@isbn", ISBNTextBox.Text)
                    command.Parameters.AddWithValue("@title", BookTitleTextBox.Text)
                    command.Parameters.AddWithValue("@category", CategoryComboBox.Text)
                    command.Parameters.AddWithValue("@publisher", PublisherComboBox.Text)
                    Dim pubDate As DateTime = DateTime.Parse(PubDateMonthCalendar.SelectionStart.ToLongDateString)
                    command.Parameters.AddWithValue("@publishedDate", pubDate)
                    command.Parameters.AddWithValue("@authors", AuthorDataCleaner(AuthorTextBox.Text))
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            noError = False
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return noError
    End Function

    Private Sub LoadCategory()
        Using conn As New SqlConnection(connString)
            Using command As New SqlCommand("select distinct [Category] from [dbo].[Books]", conn)
                conn.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                CategoryComboBox.Items.Clear()
                While reader.Read()
                    CategoryComboBox.Items.Add(reader("Category").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub LoadPublisher()
        Using conn As New SqlConnection(connString)
            Using command As New SqlCommand("select distinct [Publisher] from [dbo].[Books]", conn)
                conn.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                PublisherComboBox.Items.Clear()
                While reader.Read()
                    PublisherComboBox.Items.Add(reader("Publisher").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If AddNewBook() <> False Then
            MessageBox.Show("Book Added")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCategory()
        LoadPublisher()
    End Sub
End Class
