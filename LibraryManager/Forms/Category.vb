Imports System.Configuration
Imports System.Data.SqlClient

Public Class Category
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
        CategoryDataGridView.AllowUserToAddRows = False
        CategoryDataGridView.Columns("ID").ReadOnly = True
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        SearchAction(SearchTextBox.Text)
    End Sub

    Private Sub CategoryDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellEndEdit

    End Sub

    Private Sub UpdateDatabase(id As Integer, columnName As String, newValue As String)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("UPDATE [Categories] SET @columnName=@newValue WHERE [ID]=@id", connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@columnName", columnName)
                    command.Parameters.AddWithValue("@newValue", newValue)
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Something went wrong. " & vbCrLf & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub SearchAction(text As String)
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter("SELECT * FROM Categories WHERE LIKE @text", connection)
                adapter.SelectCommand.Parameters.AddWithValue("@text", text & "%")
                table.Clear()
                adapter.Fill(table)
                CategoryDataGridView.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub LoadDataGridView()
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter("SELECT * FROM Categories", connection)
                table.Clear()
                adapter.Fill(table)
                CategoryDataGridView.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim selectedRow = CategoryDataGridView.SelectedRows(0)
        Dim selectCategoryId = Convert.ToInt32(selectedRow.Cells("ID").Value)

        DeleteFromDatabase(selectCategoryId)
        LoadDataGridView()
    End Sub

    Private Sub DeleteFromDatabase(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("DELETE FROM [Categories] WHERE [ID]=@id", connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Category Delete.")
                Catch ex As Exception
                    MessageBox.Show("Something went wrong when deleting. " & vbCrLf & ex.Message)
                End Try

            End Using
        End Using
    End Sub

End Class