<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLibrarian
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.SearchLibrarianTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLibrarianLabel = New System.Windows.Forms.Label()
        Me.LibrarianDataTable = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LibrarianDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LibrarianDataTable, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.07942!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.92058!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(601, 589)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.RefreshButton)
        Me.Panel1.Controls.Add(Me.SearchLibrarianTextBox)
        Me.Panel1.Controls.Add(Me.SearchLibrarianLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 76)
        Me.Panel1.TabIndex = 0
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.SlateBlue
        Me.RefreshButton.FlatAppearance.BorderSize = 0
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RefreshButton.Location = New System.Drawing.Point(193, 33)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(76, 31)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'SearchLibrarianTextBox
        '
        Me.SearchLibrarianTextBox.Location = New System.Drawing.Point(6, 39)
        Me.SearchLibrarianTextBox.Name = "SearchLibrarianTextBox"
        Me.SearchLibrarianTextBox.Size = New System.Drawing.Size(181, 25)
        Me.SearchLibrarianTextBox.TabIndex = 1
        '
        'SearchLibrarianLabel
        '
        Me.SearchLibrarianLabel.AutoSize = True
        Me.SearchLibrarianLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLibrarianLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SearchLibrarianLabel.Location = New System.Drawing.Point(3, 15)
        Me.SearchLibrarianLabel.Name = "SearchLibrarianLabel"
        Me.SearchLibrarianLabel.Size = New System.Drawing.Size(102, 17)
        Me.SearchLibrarianLabel.TabIndex = 0
        Me.SearchLibrarianLabel.Text = "Search Librarian"
        '
        'LibrarianDataTable
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.LibrarianDataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LibrarianDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LibrarianDataTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LibrarianDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LibrarianDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.LibrarianDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LibrarianDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LibrarianDataTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.LibrarianDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibrarianDataTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LibrarianDataTable.Location = New System.Drawing.Point(3, 85)
        Me.LibrarianDataTable.Name = "LibrarianDataTable"
        Me.LibrarianDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.LibrarianDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.LibrarianDataTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.LibrarianDataTable.Size = New System.Drawing.Size(595, 501)
        Me.LibrarianDataTable.TabIndex = 1
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
        'ViewLibrarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(601, 589)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewLibrarian"
        Me.Text = "ViewLibrarian"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LibrarianDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RefreshButton As Button
    Friend WithEvents SearchLibrarianTextBox As TextBox
    Friend WithEvents SearchLibrarianLabel As Label
    Friend WithEvents LibrarianDataTable As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
