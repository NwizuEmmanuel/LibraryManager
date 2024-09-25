Public Class LibraryForm
    Private Sub AddUserDeleteButton()
        Dim deleteUserButton As New DataGridViewButtonColumn With {
            .HeaderText = "Action",
            .Name = "UserDeleteBtn",
            .Text = "Delete",
            .UseColumnTextForButtonValue = True
        }
        UserDataGridView.Columns.Add(deleteUserButton)
    End Sub

    Private Sub AddStudentDeleteButton()
        Dim deleteStudentButton As New DataGridViewButtonColumn With {
            .HeaderText = "Action",
            .Name = "StudentDeleteBtn",
            .Text = "Delete",
            .UseColumnTextForButtonValue = True
        }
        StudentDataGridView.Columns.Add(deleteStudentButton)
    End Sub

    Private Sub AddBookDeleteButton()
        Dim deleteBookButton As New DataGridViewButtonColumn With {
            .HeaderText = "Action",
            .Name = "BookDeleteBtn",
            .Text = "Delete",
            .UseColumnTextForButtonValue = True
        }
        BookDataGridView.Columns.Add(deleteBookButton)
    End Sub

    Private Sub LoadBookData()
        Using context As New LM()
            Dim books = context.Books.ToList()
            BookDataGridView.DataSource = books
        End Using
        AddBookDeleteButton()
    End Sub

    Private Sub LoadStudentData()
        Using context As New LM()
            Dim students = context.Students.ToList()
            StudentDataGridView.DataSource = students
        End Using
        AddStudentDeleteButton()
    End Sub

    Private Sub LoadUserData()
        Using context As New LM()
            Dim users = context.Users.ToList()
            UserDataGridView.DataSource = users
        End Using
        AddUserDeleteButton()
    End Sub
    Private Sub LibraryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadStudentData()
        LoadUserData()
        LoadBookData()
    End Sub

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click

    End Sub

    Private Sub BookDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookDataGridView.CellContentClick
        If e.ColumnIndex = BookDataGridView.Columns("BookDeleteBtn").Index AndAlso e.RowIndex >= 0 Then
            Dim bookId As Integer = CInt(BookDataGridView.Rows(e.RowIndex).Cells("Id").Value)

            Using context As New LM()
                Dim bookToDelete = context.Books.Find(bookId)
                If bookToDelete IsNot Nothing Then
                    context.Books.Remove(bookToDelete)
                    context.SaveChanges()
                    MessageBox.Show("Delete successful.")
                End If
            End Using
            BookDataGridView.DataSource = Nothing
            BookDataGridView.Columns().Clear()
            LoadBookData()
        End If
    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        If e.ColumnIndex = StudentDataGridView.Columns("StudentDeleteBtn").Index AndAlso e.RowIndex >= 0 Then
            Dim studentId As Integer = CInt(StudentDataGridView.Rows(e.RowIndex).Cells("Id").Value)

            Using context As New LM()
                Dim studentToDelete = context.Students.Find(studentId)
                If studentToDelete IsNot Nothing Then
                    context.Students.Remove(studentToDelete)
                    context.SaveChanges()
                    MessageBox.Show("Delete successful.")
                End If
            End Using
            StudentDataGridView.DataSource = Nothing
            StudentDataGridView.Columns().Clear()
            LoadStudentData()
        End If
    End Sub

    Private Sub UserDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellContentClick
        If e.ColumnIndex = UserDataGridView.Columns("UserDeleteBtn").Index AndAlso e.RowIndex >= 0 Then
            Dim userId As Integer = CInt(UserDataGridView.Rows(e.RowIndex).Cells("Id").Value)

            Using context As New LM()
                Dim userToDelete = context.Users.Find(userId)
                If userToDelete IsNot Nothing Then
                    context.Users.Remove(userToDelete)
                    context.SaveChanges()
                    MessageBox.Show("Delete successful.")
                End If
            End Using
            UserDataGridView.DataSource = Nothing
            UserDataGridView.Columns().Clear()
            LoadUserData()
        End If
    End Sub
End Class