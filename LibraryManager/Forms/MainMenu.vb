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
        SearchAction()
    End Sub

    Private Sub SearchAction()
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

    Private Sub BorrowedBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBookToolStripMenuItem.Click
        ViewBorrow.ShowDialog()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        WelcomeLabel.Text = $"Welcome, {Whoami.Firstname} {Whoami.Lastname}"
    End Sub
End Class