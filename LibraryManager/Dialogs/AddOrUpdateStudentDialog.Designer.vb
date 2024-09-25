<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrUpdateStudentDialog
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
        Me.SexLabel = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CourseLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TelephoneLabel = New System.Windows.Forms.Label()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LastnameLabel = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OthersRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MiddleNameLabel = New System.Windows.Forms.Label()
        Me.MiddlenameTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(313, 256)
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
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.MiddlenameTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MiddleNameLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SexLabel, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox5, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.CourseLabel, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.EmailLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox3, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TelephoneLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.FirstnameLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LastnameLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox4, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 6)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(444, 203)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'SexLabel
        '
        Me.SexLabel.AutoSize = True
        Me.SexLabel.Location = New System.Drawing.Point(3, 156)
        Me.SexLabel.Name = "SexLabel"
        Me.SexLabel.Size = New System.Drawing.Size(25, 13)
        Me.SexLabel.TabIndex = 10
        Me.SexLabel.Text = "Sex"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(78, 133)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(356, 20)
        Me.TextBox5.TabIndex = 9
        '
        'CourseLabel
        '
        Me.CourseLabel.AutoSize = True
        Me.CourseLabel.Location = New System.Drawing.Point(3, 130)
        Me.CourseLabel.Name = "CourseLabel"
        Me.CourseLabel.Size = New System.Drawing.Size(40, 13)
        Me.CourseLabel.TabIndex = 8
        Me.CourseLabel.Text = "Course"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(3, 104)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 7
        Me.EmailLabel.Text = "Email"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(78, 81)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(356, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TelephoneLabel
        '
        Me.TelephoneLabel.AutoSize = True
        Me.TelephoneLabel.Location = New System.Drawing.Point(3, 78)
        Me.TelephoneLabel.Name = "TelephoneLabel"
        Me.TelephoneLabel.Size = New System.Drawing.Size(58, 13)
        Me.TelephoneLabel.TabIndex = 4
        Me.TelephoneLabel.Text = "Telephone"
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Location = New System.Drawing.Point(3, 0)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstnameLabel.TabIndex = 0
        Me.FirstnameLabel.Text = "First Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 20)
        Me.TextBox1.TabIndex = 1
        '
        'LastnameLabel
        '
        Me.LastnameLabel.AutoSize = True
        Me.LastnameLabel.Location = New System.Drawing.Point(3, 52)
        Me.LastnameLabel.Name = "LastnameLabel"
        Me.LastnameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastnameLabel.TabIndex = 2
        Me.LastnameLabel.Text = "Last Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(78, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(356, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(78, 107)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(356, 20)
        Me.TextBox4.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OthersRadioButton)
        Me.Panel1.Controls.Add(Me.FemaleRadioButton)
        Me.Panel1.Controls.Add(Me.MaleRadioButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(78, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 41)
        Me.Panel1.TabIndex = 11
        '
        'OthersRadioButton
        '
        Me.OthersRadioButton.AutoSize = True
        Me.OthersRadioButton.Location = New System.Drawing.Point(123, 4)
        Me.OthersRadioButton.Name = "OthersRadioButton"
        Me.OthersRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.OthersRadioButton.TabIndex = 2
        Me.OthersRadioButton.TabStop = True
        Me.OthersRadioButton.Text = "Others"
        Me.OthersRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(58, 4)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadioButton.TabIndex = 1
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(4, 4)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadioButton.TabIndex = 0
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'MiddleNameLabel
        '
        Me.MiddleNameLabel.AutoSize = True
        Me.MiddleNameLabel.Location = New System.Drawing.Point(3, 26)
        Me.MiddleNameLabel.Name = "MiddleNameLabel"
        Me.MiddleNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MiddleNameLabel.Size = New System.Drawing.Size(69, 13)
        Me.MiddleNameLabel.TabIndex = 12
        Me.MiddleNameLabel.Text = "Middle Name"
        '
        'MiddlenameTextBox
        '
        Me.MiddlenameTextBox.Location = New System.Drawing.Point(78, 29)
        Me.MiddlenameTextBox.Name = "MiddlenameTextBox"
        Me.MiddlenameTextBox.Size = New System.Drawing.Size(356, 20)
        Me.MiddlenameTextBox.TabIndex = 13
        '
        'AddStudentDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(471, 297)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddStudentDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddStudentDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SexLabel As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CourseLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TelephoneLabel As Label
    Friend WithEvents FirstnameLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LastnameLabel As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OthersRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents MiddlenameTextBox As TextBox
    Friend WithEvents MiddleNameLabel As Label
End Class
