<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.LastnameLabel = New System.Windows.Forms.Label()
        Me.SexLabel = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.EamilLabel = New System.Windows.Forms.Label()
        Me.PhonenumberLabel = New System.Windows.Forms.Label()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OthersRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddressLabel = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(436, 352)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.54813!))
        Me.TableLayoutPanel2.Controls.Add(Me.AddressTextBox, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.PhoneNumberTextBox, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.EmailTextBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.FirstnameLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LastnameLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SexLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DepartmentLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.EamilLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PhonenumberLabel, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.FirstnameTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LastnameTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DepartmentTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.AddressLabel, 0, 6)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(16, 15)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(618, 329)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressTextBox.Location = New System.Drawing.Point(109, 198)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(505, 22)
        Me.AddressTextBox.TabIndex = 13
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(109, 168)
        Me.PhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(505, 22)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailTextBox.Location = New System.Drawing.Point(109, 138)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(505, 22)
        Me.EmailTextBox.TabIndex = 11
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Location = New System.Drawing.Point(4, 0)
        Me.FirstnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(72, 16)
        Me.FirstnameLabel.TabIndex = 0
        Me.FirstnameLabel.Text = "First Name"
        '
        'LastnameLabel
        '
        Me.LastnameLabel.AutoSize = True
        Me.LastnameLabel.Location = New System.Drawing.Point(4, 30)
        Me.LastnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastnameLabel.Name = "LastnameLabel"
        Me.LastnameLabel.Size = New System.Drawing.Size(72, 16)
        Me.LastnameLabel.TabIndex = 1
        Me.LastnameLabel.Text = "Last Name"
        '
        'SexLabel
        '
        Me.SexLabel.AutoSize = True
        Me.SexLabel.Location = New System.Drawing.Point(4, 60)
        Me.SexLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SexLabel.Name = "SexLabel"
        Me.SexLabel.Size = New System.Drawing.Size(30, 16)
        Me.SexLabel.TabIndex = 2
        Me.SexLabel.Text = "Sex"
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Location = New System.Drawing.Point(4, 104)
        Me.DepartmentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(77, 16)
        Me.DepartmentLabel.TabIndex = 3
        Me.DepartmentLabel.Text = "Department"
        '
        'EamilLabel
        '
        Me.EamilLabel.AutoSize = True
        Me.EamilLabel.Location = New System.Drawing.Point(4, 134)
        Me.EamilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EamilLabel.Name = "EamilLabel"
        Me.EamilLabel.Size = New System.Drawing.Size(41, 16)
        Me.EamilLabel.TabIndex = 4
        Me.EamilLabel.Text = "Email"
        '
        'PhonenumberLabel
        '
        Me.PhonenumberLabel.AutoSize = True
        Me.PhonenumberLabel.Location = New System.Drawing.Point(4, 164)
        Me.PhonenumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhonenumberLabel.Name = "PhonenumberLabel"
        Me.PhonenumberLabel.Size = New System.Drawing.Size(97, 16)
        Me.PhonenumberLabel.TabIndex = 5
        Me.PhonenumberLabel.Text = "Phone Number"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstnameTextBox.Location = New System.Drawing.Point(109, 4)
        Me.FirstnameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(505, 22)
        Me.FirstnameTextBox.TabIndex = 6
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastnameTextBox.Location = New System.Drawing.Point(109, 34)
        Me.LastnameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(505, 22)
        Me.LastnameTextBox.TabIndex = 7
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DepartmentTextBox.Location = New System.Drawing.Point(109, 108)
        Me.DepartmentTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(505, 22)
        Me.DepartmentTextBox.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OthersRadioButton)
        Me.Panel1.Controls.Add(Me.FemaleRadioButton)
        Me.Panel1.Controls.Add(Me.MaleRadioButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(109, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 36)
        Me.Panel1.TabIndex = 9
        '
        'OthersRadioButton
        '
        Me.OthersRadioButton.AutoSize = True
        Me.OthersRadioButton.Checked = True
        Me.OthersRadioButton.Location = New System.Drawing.Point(146, 4)
        Me.OthersRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.OthersRadioButton.Name = "OthersRadioButton"
        Me.OthersRadioButton.Size = New System.Drawing.Size(64, 20)
        Me.OthersRadioButton.TabIndex = 2
        Me.OthersRadioButton.TabStop = True
        Me.OthersRadioButton.Text = "Others"
        Me.OthersRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(67, 4)
        Me.FemaleRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(71, 20)
        Me.FemaleRadioButton.TabIndex = 1
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(4, 4)
        Me.MaleRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(55, 20)
        Me.MaleRadioButton.TabIndex = 0
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(4, 194)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(58, 16)
        Me.AddressLabel.TabIndex = 10
        Me.AddressLabel.Text = "Address"
        '
        'AddStudent
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(647, 402)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddStudent"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddStudent"
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
    Friend WithEvents FirstnameLabel As Label
    Friend WithEvents LastnameLabel As Label
    Friend WithEvents SexLabel As Label
    Friend WithEvents DepartmentLabel As Label
    Friend WithEvents EamilLabel As Label
    Friend WithEvents PhonenumberLabel As Label
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents LastnameTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents OthersRadioButton As RadioButton
End Class
