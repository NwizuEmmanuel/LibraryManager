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
        BorrowDataTable.ReadOnly = True
        BorrowDataTable.Columns("BorrowDate").ReadOnly = False
        BorrowDataTable.Columns("DueDate").ReadOnly = False
        BorrowDataTable.Columns("ReturnDate").ReadOnly = False
    End Sub
    Private Sub LoadDataTable()
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(
                    "SELECT Borrows.BorrowId,Books.ISBN,[Books].[Title],Books.Authors,Borrows.BorrowDate,Borrows.DueDate," &
                    "Borrows.ReturnDate,Librarians.FirstName as LibrarianFirstname,Librarians.LastName as LibrarianLastname " &
                    ",Students.FirstName as StudentFirstame,Students.LastName as StudentLastName " &
                    "FROM Borrows " &
                    "INNER JOIN Books ON Borrows.BookId=Books.BookId " &
                    "INNER JOIN Librarians ON Borrows.LibrarianId=Librarians.LibrarianId " &
                    "INNER JOIN Students ON Borrows.StudentId=Students.StudentId " &
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
            BorrowBook(isbnText)
            LoadDataTable()
        End If
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

    Private Sub ReturnBookOption_CheckedChanged(sender As Object, e As EventArgs) Handles ReturnBookOption.CheckedChanged
        If ReturnBookOption.Checked() Then
            StudentPhoneNumberTextBox.Enabled = False
            EnterStudentLabel.Enabled = False
            DueDateTextBox.Enabled = False
        Else
            StudentPhoneNumberTextBox.Enabled = True
            EnterStudentLabel.Enabled = True
            DueDateTextBox.Enabled = True
        End If
    End Sub

    Private Sub BorrowDataTable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowDataTable.CellEndEdit
        Dim editedCellValue As Object = BorrowDataTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim primaryKey As Integer = CInt(BorrowDataTable.Rows(e.RowIndex).Cells("BorrowId").Value.ToString())
        Dim columnName = BorrowDataTable.Columns(e.ColumnIndex).Name

        UpdateDatabase(id:=primaryKey, editedValue:=editedCellValue, columnName:=columnName)
    End Sub

    Private Sub UpdateDatabase(id As Integer, editedValue As Object, columnName As String)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                $"UPDATE Borrows SET {columnName}=@editedValue WHERE BorrowId=@id",
                connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@editedValue", editedValue)
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If BorrowDataTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = BorrowDataTable.SelectedRows(0)
            Dim id = Convert.ToInt32(selectedRow.Cells("BorrowId").Value)
            BorrowDataTable.Rows.Remove(selectedRow)
            DeleteFromDatabase(id)
        End If
    End Sub

    Private Sub DeleteFromDatabase(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                    "DELETE FROM [Borrows] WHERE BorrowId=@id",
                    connection
                )
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Borrow transaction Deleted.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BorrowDataTable_MouseDown(sender As Object, e As MouseEventArgs) Handles BorrowDataTable.MouseDown
        ' Check if right mouse button was clicked
        If e.Button = MouseButtons.Right Then
            ' Get the row index from the mouse position
            Dim hitTestInfo As DataGridView.HitTestInfo = BorrowDataTable.HitTest(e.X, e.Y)

            ' Ensure the user clicked on a valid row and not the column headers
            If hitTestInfo.Type = DataGridViewHitTestType.Cell Then
                ' Select the row where the right-click happened
                BorrowDataTable.ClearSelection()
                BorrowDataTable.Rows(hitTestInfo.RowIndex).Selected = True

                ' Show the context menu at the mouse position
                ContextMenuStrip1.Show(BorrowDataTable, New Point(e.X, e.Y))
            End If
        End If
    End Sub
End Class
