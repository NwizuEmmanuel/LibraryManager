<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibraryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BooksTabPage = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DeleteBookButton = New System.Windows.Forms.Button()
        Me.UpdateBookButton = New System.Windows.Forms.Button()
        Me.AddBookButton = New System.Windows.Forms.Button()
        Me.BookDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentsTabPage = New System.Windows.Forms.TabPage()
        Me.UsersTabPage = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DeleteStudentButton = New System.Windows.Forms.Button()
        Me.UpdateStudentButton = New System.Windows.Forms.Button()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        Me.UpdateUserButton = New System.Windows.Forms.Button()
        Me.AddUserButton = New System.Windows.Forms.Button()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.BooksTabPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentsTabPage.SuspendLayout()
        Me.UsersTabPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BooksTabPage)
        Me.TabControl1.Controls.Add(Me.StudentsTabPage)
        Me.TabControl1.Controls.Add(Me.UsersTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(597, 450)
        Me.TabControl1.TabIndex = 0
        '
        'BooksTabPage
        '
        Me.BooksTabPage.Controls.Add(Me.Panel1)
        Me.BooksTabPage.Controls.Add(Me.BookDataGridView)
        Me.BooksTabPage.Location = New System.Drawing.Point(4, 22)
        Me.BooksTabPage.Name = "BooksTabPage"
        Me.BooksTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BooksTabPage.Size = New System.Drawing.Size(589, 424)
        Me.BooksTabPage.TabIndex = 0
        Me.BooksTabPage.Text = "Books"
        Me.BooksTabPage.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DeleteBookButton)
        Me.Panel1.Controls.Add(Me.UpdateBookButton)
        Me.Panel1.Controls.Add(Me.AddBookButton)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 37)
        Me.Panel1.TabIndex = 1
        '
        'DeleteBookButton
        '
        Me.DeleteBookButton.Location = New System.Drawing.Point(165, 11)
        Me.DeleteBookButton.Name = "DeleteBookButton"
        Me.DeleteBookButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBookButton.TabIndex = 2
        Me.DeleteBookButton.Text = "Delete"
        Me.DeleteBookButton.UseVisualStyleBackColor = True
        '
        'UpdateBookButton
        '
        Me.UpdateBookButton.Location = New System.Drawing.Point(84, 11)
        Me.UpdateBookButton.Name = "UpdateBookButton"
        Me.UpdateBookButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBookButton.TabIndex = 1
        Me.UpdateBookButton.Text = "Update"
        Me.UpdateBookButton.UseVisualStyleBackColor = True
        '
        'AddBookButton
        '
        Me.AddBookButton.Location = New System.Drawing.Point(3, 11)
        Me.AddBookButton.Name = "AddBookButton"
        Me.AddBookButton.Size = New System.Drawing.Size(75, 23)
        Me.AddBookButton.TabIndex = 0
        Me.AddBookButton.Text = "Add"
        Me.AddBookButton.UseVisualStyleBackColor = True
        '
        'BookDataGridView
        '
        Me.BookDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookDataGridView.Location = New System.Drawing.Point(6, 49)
        Me.BookDataGridView.Name = "BookDataGridView"
        Me.BookDataGridView.Size = New System.Drawing.Size(575, 367)
        Me.BookDataGridView.TabIndex = 0
        '
        'StudentsTabPage
        '
        Me.StudentsTabPage.Controls.Add(Me.Panel2)
        Me.StudentsTabPage.Controls.Add(Me.StudentDataGridView)
        Me.StudentsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.StudentsTabPage.Name = "StudentsTabPage"
        Me.StudentsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.StudentsTabPage.Size = New System.Drawing.Size(589, 424)
        Me.StudentsTabPage.TabIndex = 1
        Me.StudentsTabPage.Text = "Students"
        Me.StudentsTabPage.UseVisualStyleBackColor = True
        '
        'UsersTabPage
        '
        Me.UsersTabPage.Controls.Add(Me.Panel3)
        Me.UsersTabPage.Controls.Add(Me.UserDataGridView)
        Me.UsersTabPage.Location = New System.Drawing.Point(4, 22)
        Me.UsersTabPage.Name = "UsersTabPage"
        Me.UsersTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.UsersTabPage.Size = New System.Drawing.Size(589, 424)
        Me.UsersTabPage.TabIndex = 2
        Me.UsersTabPage.Text = "Users"
        Me.UsersTabPage.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DeleteStudentButton)
        Me.Panel2.Controls.Add(Me.UpdateStudentButton)
        Me.Panel2.Controls.Add(Me.AddStudentButton)
        Me.Panel2.Location = New System.Drawing.Point(9, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 37)
        Me.Panel2.TabIndex = 3
        '
        'DeleteStudentButton
        '
        Me.DeleteStudentButton.Location = New System.Drawing.Point(165, 11)
        Me.DeleteStudentButton.Name = "DeleteStudentButton"
        Me.DeleteStudentButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteStudentButton.TabIndex = 2
        Me.DeleteStudentButton.Text = "Delete"
        Me.DeleteStudentButton.UseVisualStyleBackColor = True
        '
        'UpdateStudentButton
        '
        Me.UpdateStudentButton.Location = New System.Drawing.Point(84, 11)
        Me.UpdateStudentButton.Name = "UpdateStudentButton"
        Me.UpdateStudentButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateStudentButton.TabIndex = 1
        Me.UpdateStudentButton.Text = "Update"
        Me.UpdateStudentButton.UseVisualStyleBackColor = True
        '
        'AddStudentButton
        '
        Me.AddStudentButton.Location = New System.Drawing.Point(3, 11)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(75, 23)
        Me.AddStudentButton.TabIndex = 0
        Me.AddStudentButton.Text = "Add"
        Me.AddStudentButton.UseVisualStyleBackColor = True
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Location = New System.Drawing.Point(7, 50)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.Size = New System.Drawing.Size(575, 367)
        Me.StudentDataGridView.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.DeleteUserButton)
        Me.Panel3.Controls.Add(Me.UpdateUserButton)
        Me.Panel3.Controls.Add(Me.AddUserButton)
        Me.Panel3.Location = New System.Drawing.Point(9, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(573, 37)
        Me.Panel3.TabIndex = 3
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.Location = New System.Drawing.Point(165, 11)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteUserButton.TabIndex = 2
        Me.DeleteUserButton.Text = "Delete"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'UpdateUserButton
        '
        Me.UpdateUserButton.Location = New System.Drawing.Point(84, 11)
        Me.UpdateUserButton.Name = "UpdateUserButton"
        Me.UpdateUserButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateUserButton.TabIndex = 1
        Me.UpdateUserButton.Text = "Update"
        Me.UpdateUserButton.UseVisualStyleBackColor = True
        '
        'AddUserButton
        '
        Me.AddUserButton.Location = New System.Drawing.Point(3, 11)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(75, 23)
        Me.AddUserButton.TabIndex = 0
        Me.AddUserButton.Text = "Add"
        Me.AddUserButton.UseVisualStyleBackColor = True
        '
        'UserDataGridView
        '
        Me.UserDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Location = New System.Drawing.Point(7, 50)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.Size = New System.Drawing.Size(575, 367)
        Me.UserDataGridView.TabIndex = 2
        '
        'LibraryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "LibraryForm"
        Me.Text = "Library"
        Me.TabControl1.ResumeLayout(False)
        Me.BooksTabPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentsTabPage.ResumeLayout(False)
        Me.UsersTabPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BooksTabPage As TabPage
    Friend WithEvents StudentsTabPage As TabPage
    Friend WithEvents UsersTabPage As TabPage
    Friend WithEvents BookDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DeleteBookButton As Button
    Friend WithEvents UpdateBookButton As Button
    Friend WithEvents AddBookButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DeleteStudentButton As Button
    Friend WithEvents UpdateStudentButton As Button
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents UpdateUserButton As Button
    Friend WithEvents AddUserButton As Button
    Friend WithEvents UserDataGridView As DataGridView
End Class
