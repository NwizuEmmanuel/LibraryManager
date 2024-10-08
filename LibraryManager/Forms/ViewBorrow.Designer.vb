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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BorrowPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.BorrowDataTable = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BorrowPanel.SuspendLayout()
        CType(Me.BorrowDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowPanel
        '
        Me.BorrowPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BorrowPanel.Controls.Add(Me.Button1)
        Me.BorrowPanel.Controls.Add(Me.LinkLabel1)
        Me.BorrowPanel.Controls.Add(Me.SearchTextBox)
        Me.BorrowPanel.Controls.Add(Me.SearchLabel)
        Me.BorrowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BorrowPanel.Location = New System.Drawing.Point(4, 4)
        Me.BorrowPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BorrowPanel.Name = "BorrowPanel"
        Me.BorrowPanel.Size = New System.Drawing.Size(564, 67)
        Me.BorrowPanel.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 257)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(85, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh table"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(10, 29)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(252, 25)
        Me.SearchTextBox.TabIndex = 2
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SearchLabel.Location = New System.Drawing.Point(8, 4)
        Me.SearchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(104, 17)
        Me.SearchLabel.TabIndex = 1
        Me.SearchLabel.Text = "Search ISBN/title"
        '
        'BorrowDataTable
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.BorrowDataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BorrowDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BorrowDataTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BorrowDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.BorrowDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BorrowDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BorrowDataTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.BorrowDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowDataTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BorrowDataTable.Location = New System.Drawing.Point(3, 78)
        Me.BorrowDataTable.Name = "BorrowDataTable"
        Me.BorrowDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.BorrowDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.BorrowDataTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.BorrowDataTable.Size = New System.Drawing.Size(566, 508)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(572, 589)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(268, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ViewBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 589)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents BorrowDataTable As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
