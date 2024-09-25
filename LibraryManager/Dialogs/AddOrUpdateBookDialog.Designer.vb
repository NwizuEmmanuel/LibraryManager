<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrUpdateBookDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PublishYearTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorsTextBox = New System.Windows.Forms.TextBox()
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorsLabel = New System.Windows.Forms.Label()
        Me.PublisherLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(353, 205)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PublishYearTextBox, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.PublisherTextBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.AuthorsTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BookTitleTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TitleLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ISBNLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ISBNTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AuthorsLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PublisherLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(481, 174)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PublishYearTextBox
        '
        Me.PublishYearTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublishYearTextBox.Location = New System.Drawing.Point(84, 120)
        Me.PublishYearTextBox.Name = "PublishYearTextBox"
        Me.PublishYearTextBox.Size = New System.Drawing.Size(394, 20)
        Me.PublishYearTextBox.TabIndex = 9
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublisherTextBox.Location = New System.Drawing.Point(84, 94)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(394, 20)
        Me.PublisherTextBox.TabIndex = 8
        '
        'AuthorsTextBox
        '
        Me.AuthorsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorsTextBox.Location = New System.Drawing.Point(84, 55)
        Me.AuthorsTextBox.Name = "AuthorsTextBox"
        Me.AuthorsTextBox.Size = New System.Drawing.Size(394, 20)
        Me.AuthorsTextBox.TabIndex = 7
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookTitleTextBox.Location = New System.Drawing.Point(84, 29)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(394, 20)
        Me.BookTitleTextBox.TabIndex = 6
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(3, 26)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(55, 13)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Book Title"
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Location = New System.Drawing.Point(3, 0)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(60, 13)
        Me.ISBNLabel.TabIndex = 0
        Me.ISBNLabel.Text = "Book ISBN"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ISBNTextBox.Location = New System.Drawing.Point(84, 3)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(394, 20)
        Me.ISBNTextBox.TabIndex = 1
        '
        'AuthorsLabel
        '
        Me.AuthorsLabel.AutoSize = True
        Me.AuthorsLabel.Location = New System.Drawing.Point(3, 52)
        Me.AuthorsLabel.Name = "AuthorsLabel"
        Me.AuthorsLabel.Size = New System.Drawing.Size(43, 13)
        Me.AuthorsLabel.TabIndex = 3
        Me.AuthorsLabel.Text = "Authors"
        '
        'PublisherLabel
        '
        Me.PublisherLabel.AutoSize = True
        Me.PublisherLabel.Location = New System.Drawing.Point(3, 91)
        Me.PublisherLabel.Name = "PublisherLabel"
        Me.PublisherLabel.Size = New System.Drawing.Size(50, 13)
        Me.PublisherLabel.TabIndex = 4
        Me.PublisherLabel.Text = "Publisher"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Publisher Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "use "";"" to separate two or more authors"
        '
        'AddBookDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(511, 246)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddBookDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddBookDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PublishYearTextBox As TextBox
    Friend WithEvents PublisherTextBox As TextBox
    Friend WithEvents AuthorsTextBox As TextBox
    Friend WithEvents BookTitleTextBox As TextBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents AuthorsLabel As Label
    Friend WithEvents PublisherLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
