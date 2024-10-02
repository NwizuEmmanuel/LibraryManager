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
                    "SELECT Borrows.BorrowId,Books.ISBN,[Books].[Title],Books.Authors,Borrows.BorrowDate,Borrows.DueDate," &
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

    Private Sub SearchAction()
        Try
            Dim text = ISBNTextBox.Text & "%"
        Catch ex As Exception
            'Error logic
        End Try
        Dim query = "SELECT Borrows.BorrowId,Books.ISBN,[Books].[Title],Books.Authors,Borrows.BorrowDate,Borrows.DueDate," &
                    "Borrows.ReturnDate,Librarians.FirstName,Librarians.LastName " &
                    "FROM Borrows " &
                    "FULL OUTER JOIN Books ON Borrows.BookId=Books.BookId " &
                    "FULL OUTER JOIN Librarians ON Borrows.LibrarianId=Librarians.LibrarianId " &
                    "WHERE ISBN LIKE @text " &
                    "ORDER BY Books.Title"
        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@text", Text)
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

    Private Sub ReturnBookBtn_Click(sender As Object, e As EventArgs)
        Try
            Dim selectedRow As DataGridViewRow = BorrowDataTable.SelectedRows(0)
            Dim id = selectedRow.Cells("BorrowId").Value
            Dim dateValue As DateTime = DateTime.Today.ToString()
            ReturnBookAction(id:=id, value:=dateValue)
        Catch ex As Exception
            MessageBox.Show("Select a row. " & ex.Message)
        End Try
    End Sub

    Private Sub ReturnBookAction(id As Integer, value As DateTime)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("UPDATE Borrows SET ReturnDate=@date WHERE BorrowId=@id", connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@date", value)
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Book is returned.")
                    LoadDataTable()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub RefreshLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RefreshLabel.LinkClicked
        LoadDataTable()
    End Sub

    Private Sub Borrow_ReturnButton_Click(sender As Object, e As EventArgs) Handles Borrow_ReturnButton.Click
        Dim isbnText = ISBNTextBox.Text
        If ReturnBookOption.Checked Then
            'logic here
            ReturnBook(isbnText)
        ElseIf BorrowBookOption.Checked Then
            'logiv here
        End If
    End Sub

    Private Sub BorrowBook(isbn As String)
        If String.IsNullOrEmpty(ISBNTextBox.Text) Then
            MessageBox.Show("Enter book ISBN.")
            Exit Sub
        End If

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

    Private Sub ReturnBookOption_CheckedChanged(sender As Object, e As EventArgs) Handles ReturnBookOption.CheckedChanged
        If ReturnBookOption.Checked() Then
            StudentNameTextBox.Enabled = False
            EnterStudentLabel.Enabled = False
        Else
            StudentNameTextBox.Enabled = True
            EnterStudentLabel.Enabled = True
        End If
    End Sub
End Class
