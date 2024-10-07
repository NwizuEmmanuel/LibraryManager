Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient

Public Class MainMenu
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

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

    Private Sub AddBook()
        Dim bookisbnCode As String = BarcodeTextBox.Text
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
                    BarcodeTextBox.Clear()
                Catch ex As Exception
                    MessageBox.Show("Book not found. " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    'Private Sub BorrowBook(isbn As String)
    '    Dim today As DateTime = DateTime.Now

    '    If String.IsNullOrEmpty(ISBNTextBox.Text) And String.IsNullOrEmpty(DueDateTextBox.Text) And String.IsNullOrEmpty(StudentPhoneNumberTextBox.Text) Then
    '        MessageBox.Show("Enter book ISBN or due date or student phone number.")
    '        Exit Sub
    '    End If

    '    Using connection As New SqlConnection(connectionString)
    '        Using command As New SqlCommand(
    '            "insert into Borrows (BookId,StudentId,BorrowDate,DueDate,LibrarianId)" &
    '            "values ((select BookId from Books where ISBN=@isbn)," &
    '            "(select StudentId from Students where PhoneNumber=@studentPhoneNumber),@todayDate,@dueDate," &
    '            "(select LibrarianId from Librarians where PhoneNumber=@librarianPhoneNumber))",
    '            connection)
    '            Try
    '                connection.Open()
    '                command.Parameters.AddWithValue("@isbn", isbn)
    '                command.Parameters.AddWithValue("@studentPhoneNumber", StudentPhoneNumberTextBox.Text)
    '                command.Parameters.AddWithValue("@todayDate", today)
    '                command.Parameters.AddWithValue("@dueDate", DueDateTextBox.Text)
    '                command.Parameters.AddWithValue("@librarianPhoneNumber", Whoami.PhoneNumber)
    '                command.ExecuteNonQuery()
    '                MessageBox.Show("Book is Borrowed Successfully.")
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message)
    '            End Try
    '        End Using
    '    End Using
    'End Sub

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
                        'LoadDataTable()
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
        BarcodeTextBox.Focus()
        ScannerDataTable.ReadOnly = True
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

End Class