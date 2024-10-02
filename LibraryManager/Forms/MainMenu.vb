Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient

Public Class MainMenu
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub MainMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLibrarianToolStripMenuItem.Click
        AddLibrarian.ShowDialog()
    End Sub

    Private Sub NewBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBookToolStripMenuItem.Click
        AddBook.ShowDialog()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        AddStudent.ShowDialog()
    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        ViewStudent.ShowDialog()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        ViewBook.ShowDialog()
    End Sub

    Private Sub LibrarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrarianToolStripMenuItem.Click
        ViewLibrarian.ShowDialog()
    End Sub

    Private Sub ScanTextBox_TextChanged(sender As Object, e As EventArgs) Handles ScanTextBox.TextChanged
        ScanAction()
    End Sub

    Private Sub ScanAction()
        Try
            Dim text = Convert.ToInt64(ScanTextBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim query = "SELECT Books.ISBN,[Books].[Title],Books.Authors,Borrows.BorrowDate,Borrows.DueDate," &
                    "Borrows.ReturnDate,Librarians.FirstName,Librarians.LastName " &
                    "FROM Borrows " &
                    "FULL OUTER JOIN Books ON Borrows.BookId=Books.BookId " &
                    "FULL OUTER JOIN Librarians ON Borrows.LibrarianId=Librarians.LibrarianId " &
                    "WHERE ISBN=@text " &
                    "ORDER BY Books.Title"
        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@text", Text)
                Try
                    conn.Open()
                    table.Clear()
                    adapter.Fill(table)
                    ScannerDataTable.DataSource = table
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BorrowBook(isbn As String)
        Dim today As DateTime = DateTime.Now

        If String.IsNullOrEmpty(ISBNTextBox.Text) And String.IsNullOrEmpty(DueDateTextBox.Text) And String.IsNullOrEmpty(StudentPhoneNumberTextBox.Text) Then
            MessageBox.Show("Enter book ISBN or due date or student phone number.")
            Exit Sub
        End If

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                "insert into Borrows (BookId,StudentId,BorrowDate,DueDate,LibrarianId)" &
                "values ((select BookId from Books where ISBN=@isbn)," &
                "(select StudentId from Students where PhoneNumber=@studentPhoneNumber),@todayDate,@dueDate," &
                "(select LibrarianId from Librarians where PhoneNumber=@librarianPhoneNumber))",
                connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@isbn", isbn)
                    command.Parameters.AddWithValue("@studentPhoneNumber", StudentPhoneNumberTextBox.Text)
                    command.Parameters.AddWithValue("@todayDate", today)
                    command.Parameters.AddWithValue("@dueDate", DueDateTextBox.Text)
                    command.Parameters.AddWithValue("@librarianPhoneNumber", Whoami.PhoneNumber)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Book is Borrowed Successfully.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ReturnBook(isbn As String)
        Dim todayDate = DateTime.Today

        If String.IsNullOrEmpty(isbn) Then
            MessageBox.Show("Enter a ISBN value.")
            Exit Sub
        End If

        Dim result As DialogResult
        result = MessageBox.Show("Are you sure of this return?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(
                    "UPDATE Borrows SET ReturnDate=@today WHERE BookId=" &
                    "(SELECT [BookId] FROM [Books] WHERE ISBN=@isbn)",
                    connection)
                    Try
                        connection.Open()
                        command.Parameters.AddWithValue("@isbn", isbn)
                        command.Parameters.AddWithValue("@today", todayDate)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Book returned.")
                        LoadDataTable()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub
    Private Sub BorrowedBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBookToolStripMenuItem.Click
        ViewBorrow.ShowDialog()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        WelcomeLabel.Text = $"Welcome, {Whoami.Firstname} {Whoami.Lastname}"
    End Sub
End Class