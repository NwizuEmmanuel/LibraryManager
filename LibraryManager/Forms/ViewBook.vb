Imports System.Configuration
Imports System.Data.SqlClient

Public Class ViewBook
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub ViewBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBookData()
        BookTableView.AllowUserToAddRows = False
        BookTableView.Columns("BookId").ReadOnly = True
    End Sub

    Private Sub LoadBookData()
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter("SELECT * FROM [Books]", connection)
                adapter.Fill(table)
                BookTableView.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadBookData()
    End Sub

    Private Sub BookTableView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles BookTableView.CellEndEdit

    End Sub
End Class