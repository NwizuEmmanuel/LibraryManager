<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewBorrow
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
        Me.components = New System.ComponentModel.Container()
        Me.BorrowPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentPhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EnterStudentLabel = New System.Windows.Forms.Label()
        Me.RefreshLabel = New System.Windows.Forms.LinkLabel()
        Me.Borrow_ReturnButton = New System.Windows.Forms.Button()
        Me.ReturnBookOption = New System.Windows.Forms.RadioButton()
        Me.BorrowBookOption = New System.Windows.Forms.RadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BorrowDataTable = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaysTextBox = New System.Windows.Forms.ComboBox()
        Me.BorrowPanel.SuspendLayout()
        CType(Me.BorrowDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowPanel
        '
        Me.BorrowPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BorrowPanel.Controls.Add(Me.DaysTextBox)
        Me.BorrowPanel.Controls.Add(Me.Label2)
        Me.BorrowPanel.Controls.Add(Me.StudentPhoneNumberTextBox)
        Me.BorrowPanel.Controls.Add(Me.EnterStudentLabel)
        Me.BorrowPanel.Controls.Add(Me.RefreshLabel)
        Me.BorrowPanel.Controls.Add(Me.Borrow_ReturnButton)
        Me.BorrowPanel.Controls.Add(Me.ReturnBookOption)
        Me.BorrowPanel.Controls.Add(Me.BorrowBookOption)
        Me.BorrowPanel.Controls.Add(Me.LinkLabel1)
        Me.BorrowPanel.Controls.Add(Me.ISBNTextBox)
        Me.BorrowPanel.Controls.Add(Me.Label1)
        Me.BorrowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowPanel.Location = New System.Drawing.Point(4, 4)
        Me.BorrowPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BorrowPanel.Name = "BorrowPanel"
        Me.BorrowPanel.Size = New System.Drawing.Size(661, 143)
        Me.BorrowPanel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(45, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Days"
        '
        'StudentPhoneNumberTextBox
        '
        Me.StudentPhoneNumberTextBox.Location = New System.Drawing.Point(346, 37)
        Me.StudentPhoneNumberTextBox.Name = "StudentPhoneNumberTextBox"
        Me.StudentPhoneNumberTextBox.Size = New System.Drawing.Size(262, 22)
        Me.StudentPhoneNumberTextBox.TabIndex = 12
        '
        'EnterStudentLabel
        '
        Me.EnterStudentLabel.AutoSize = True
        Me.EnterStudentLabel.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterStudentLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EnterStudentLabel.Location = New System.Drawing.Point(343, 14)
        Me.EnterStudentLabel.Name = "EnterStudentLabel"
        Me.EnterStudentLabel.Size = New System.Drawing.Size(209, 20)
        Me.EnterStudentLabel.TabIndex = 11
        Me.EnterStudentLabel.Text = "Enter Student Phone Number"
        '
        'RefreshLabel
        '
        Me.RefreshLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshLabel.AutoSize = True
        Me.RefreshLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RefreshLabel.Location = New System.Drawing.Point(563, 124)
        Me.RefreshLabel.Name = "RefreshLabel"
        Me.RefreshLabel.Size = New System.Drawing.Size(45, 15)
        Me.RefreshLabel.TabIndex = 10
        Me.RefreshLabel.TabStop = True
        Me.RefreshLabel.Text = "refresh"
        '
        'Borrow_ReturnButton
        '
        Me.Borrow_ReturnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Borrow_ReturnButton.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_ReturnButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Borrow_ReturnButton.Location = New System.Drawing.Point(494, 89)
        Me.Borrow_ReturnButton.Name = "Borrow_ReturnButton"
        Me.Borrow_ReturnButton.Size = New System.Drawing.Size(114, 31)
        Me.Borrow_ReturnButton.TabIndex = 9
        Me.Borrow_ReturnButton.Text = "Borrow/Return"
        Me.Borrow_ReturnButton.UseVisualStyleBackColor = False
        '
        'ReturnBookOption
        '
        Me.ReturnBookOption.AutoSize = True
        Me.ReturnBookOption.Checked = True
        Me.ReturnBookOption.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnBookOption.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReturnBookOption.Location = New System.Drawing.Point(455, 62)
        Me.ReturnBookOption.Name = "ReturnBookOption"
        Me.ReturnBookOption.Size = New System.Drawing.Size(111, 24)
        Me.ReturnBookOption.TabIndex = 8
        Me.ReturnBookOption.TabStop = True
        Me.ReturnBookOption.Text = "Return Book"
        Me.ReturnBookOption.UseVisualStyleBackColor = True
        '
        'BorrowBookOption
        '
        Me.BorrowBookOption.AutoSize = True
        Me.BorrowBookOption.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowBookOption.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowBookOption.Location = New System.Drawing.Point(346, 62)
        Me.BorrowBookOption.Name = "BorrowBookOption"
        Me.BorrowBookOption.Size = New System.Drawing.Size(114, 24)
        Me.BorrowBookOption.TabIndex = 7
        Me.BorrowBookOption.TabStop = True
        Me.BorrowBookOption.Text = "Borrow Book"
        Me.BorrowBookOption.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 242)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 16)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh table"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Location = New System.Drawing.Point(48, 37)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(288, 22)
        Me.ISBNTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(45, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter ISBN"
        '
        'BorrowDataTable
        '
        Me.BorrowDataTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowDataTable.Location = New System.Drawing.Point(3, 154)
        Me.BorrowDataTable.Name = "BorrowDataTable"
        Me.BorrowDataTable.Size = New System.Drawing.Size(663, 397)
        Me.BorrowDataTable.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BorrowPanel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BorrowDataTable, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(669, 554)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DaysTextBox
        '
        Me.DaysTextBox.FormattingEnabled = True
        Me.DaysTextBox.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30"})
        Me.DaysTextBox.Location = New System.Drawing.Point(49, 93)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(287, 24)
        Me.DaysTextBox.TabIndex = 15
        '
        'ViewBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 554)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewBorrow"
        Me.Text = "ViewBorrow"
        Me.BorrowPanel.ResumeLayout(False)
        Me.BorrowPanel.PerformLayout()
        CType(Me.BorrowDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BorrowPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents BorrowDataTable As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Borrow_ReturnButton As Button
    Friend WithEvents ReturnBookOption As RadioButton
    Friend WithEvents BorrowBookOption As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RefreshLabel As LinkLabel
    Friend WithEvents StudentPhoneNumberTextBox As TextBox
    Friend WithEvents EnterStudentLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaysTextBox As ComboBox
End Class
