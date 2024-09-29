Imports System.Configuration
Imports System.Data.SqlClient

Public Class ViewBorrow
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub ViewBorrow_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataTable()
        'BorrowDataTable.Columns("BorrowId").ReadOnly = True
        BorrowDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        BorrowDataTable.AllowUserToAddRows = False
        BorrowDataTable.AllowUserToDeleteRows = False
        BorrowDataTable.ReadOnly = True
    End Sub
    Private Sub LoadDataTable()
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(
                    "SELECT Books.ISBN,[Books].[Title],Books.Authors,Borrows.BorrowDate,Borrows.DueDate," &
                    "Borrows.ReturnDate,Librarians.FirstName,Librarians.LastName " &
                    "FROM Borrows " &
                    "FULL OUTER JOIN Books ON Borrows.BookId=Books.BookId " &
                    "FULL OUTER JOIN Librarians ON Borrows.LibrarianId=Librarians.LibrarianId " &
                    "ORDER BY Books.Title",
                    connection
                )
                table.Clear()
                adapter.Fill(table)
                BorrowDataTable.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadDataTable()
    End Sub

    Private Sub SearchAction()
        Try
            Dim text = Convert.ToInt64(SearchBorrowsTextBox.Text)
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
                adapter.SelectCommand.Parameters.AddWithValue("@text", text)
                Try
                    conn.Open()
                    table.Clear()
                    adapter.Fill(table)
                    BorrowDataTable.DataSource = table
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub SearchBorrowsTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBorrowsTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchAction()
        End If
    End Sub
End Class