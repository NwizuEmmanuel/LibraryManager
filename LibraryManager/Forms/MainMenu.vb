Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient

Public Class MainMenu
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        WelcomeLabel.Text = $"Welcome, {Whoami.Firstname} {Whoami.Lastname}"
        BarcodeTextBox.Focus()
        ScannerDataTable.ReadOnly = True
        ScannerDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

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
        AddBookDialog.ShowDialog()
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

    Private Function IsDuplicateInGridView(ByVal columnName As String, ByVal valueToCheck As String) As Boolean
        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In ScannerDataTable.Rows
            ' Skip the new row if it's a new row being added (to avoid errors)
            If Not row.IsNewRow Then
                ' Check if the value in the specified column matches the value to check
                If row.Cells(columnName).Value IsNot Nothing AndAlso row.Cells(columnName).Value.ToString() = valueToCheck Then
                    Return True ' Duplicate found
                End If
            End If
        Next
        Return False ' No duplicate found
    End Function


    Private Sub AddBook()
        Dim bookisbnCode As String = BarcodeTextBox.Text

        ' Check if the ISBN already exists in the DataGridView
        If IsDuplicateInGridView("ISBN", bookisbnCode) Then
            MessageBox.Show("This book with ISBN already exists in the list.")
            Exit Sub ' Stop further execution
        End If

        Dim newTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                "SELECT Title,ISBN,Authors,Category FROM Books WHERE ISBN=@isbnValue",
                connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@isbnValue", bookisbnCode)
                    Dim adapter As New SqlDataAdapter(command)

                    adapter.Fill(newTable)

                    Dim currentDataTable As DataTable = TryCast(ScannerDataTable.DataSource, DataTable)

                    If currentDataTable Is Nothing Then
                        ScannerDataTable.DataSource = newTable
                    Else
                        For Each row As DataRow In newTable.Rows
                            currentDataTable.ImportRow(row)
                        Next
                    End If
                    If Not ManualModeCheckBox.Checked Then
                        BarcodeTextBox.Clear()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Book not found. " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BorrowedBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBookToolStripMenuItem.Click
        ViewBorrow.ShowDialog()
    End Sub

    Private Sub BarcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles BarcodeTextBox.TextChanged
        If Not ManualModeCheckBox.Checked Then
            AddBook()
        End If
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter And ManualModeCheckBox.Checked Then
            AddBook()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteSelectedRow()
    End Sub

    Private Sub DeleteSelectedRow()
        ' Check if any row is selected
        If ScannerDataTable.SelectedRows.Count > 0 Then
            ' Get the selected row's index
            Dim rowIndex As Integer = ScannerDataTable.SelectedRows(0).Index

            ' Get the current DataTable bound to the DataGridView
            Dim currentTable As DataTable = TryCast(ScannerDataTable.DataSource, DataTable)

            If currentTable IsNot Nothing AndAlso rowIndex >= 0 Then
                ' Get the ISBN or another unique key value for the selected row
                Dim isbnCode As String = ScannerDataTable.Rows(rowIndex).Cells("ISBN").Value.ToString()

                ' Remove the row from the DataTable
                currentTable.Rows(rowIndex).Delete()

                ' Update the DataGridView
                ScannerDataTable.DataSource = currentTable
                ScannerDataTable.Refresh()
            Else
                MessageBox.Show("No valid row selected.")
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub BorrowBook(isbnValue As String, studentId As Integer, borrowDate As Date, dueDate As Date, librarianId As Integer)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
            "INSERT INTO Borrows (BookId, StudentId, BorrowDate, DueDate, LibrarianId) " &
            "VALUES ((SELECT BookId FROM Books WHERE ISBN=@isbn), @StudentId, @BorrowDate, @DueDate, @LibrarianId);", connection)

                ' Set parameters
                command.Parameters.AddWithValue("@isbn", isbnValue)
                command.Parameters.AddWithValue("@StudentId", studentId)
                command.Parameters.AddWithValue("@BorrowDate", borrowDate)
                command.Parameters.AddWithValue("@DueDate", dueDate)
                command.Parameters.AddWithValue("@LibrarianId", librarianId)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Book borrowed successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error while borrowing the book: " & ex.Message)
                End Try
            End Using
            Using command As New SqlCommand("UPDATE Books SET Quantity=Quantity - 1 WHERE ISBN=@isbn", connection)
                Try
                    command.Parameters.AddWithValue("@isbn", isbnValue)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error while borrowing the book: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BorrowBookButton_Click(sender As Object, e As EventArgs) Handles BorrowBookButton.Click
        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In ScannerDataTable.Rows
            ' Skip the new row if it's a new row being added
            If Not row.IsNewRow Then
                ' Access the value in the specified column
                Dim isbnValue As String = row.Cells("ISBN").Value.ToString()

                Dim bookISBN = isbnValue
                Dim studentId As Integer = Integer.Parse(StudentIDTextbox.Text)
                Dim borrowDate As Date = DateTime.Now
                Dim dueDate As Date = borrowDate.AddDays(DueDateComboBox.Text)
                Dim librarianId As Integer = Integer.Parse(Whoami.ID)

                BorrowBook(bookISBN, studentId, borrowDate, dueDate, librarianId)
            End If
        Next

    End Sub
End Class