Public Class LibraryForm
    Private Sub LoadBookData()
        Using context As New LM()
            Dim books = context.Books.ToList()
            BookDataGridView.DataSource = books
        End Using
    End Sub

    Private Sub LoadStudentData()
        Using context As New LM()
            Dim students = context.Students.ToList()
            StudentDataGridView.DataSource = students
        End Using
    End Sub

    Private Sub LoadUserData()
        Using context As New LM()
            Dim users = context.Users.ToList()
            UserDataGridView.DataSource = users
        End Using
    End Sub
    Private Sub LibraryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadStudentData()
        LoadUserData()
        LoadBookData()
    End Sub

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click

    End Sub
End Class