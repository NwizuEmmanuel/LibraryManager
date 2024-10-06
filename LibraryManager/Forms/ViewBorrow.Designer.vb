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
        Me.RefreshLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.BorrowDataTable = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowPanel.SuspendLayout()
        CType(Me.BorrowDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowPanel
        '
        Me.BorrowPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BorrowPanel.Controls.Add(Me.RefreshLabel)
        Me.BorrowPanel.Controls.Add(Me.LinkLabel1)
        Me.BorrowPanel.Controls.Add(Me.SearchTextBox)
        Me.BorrowPanel.Controls.Add(Me.SearchLabel)
        Me.BorrowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowPanel.Location = New System.Drawing.Point(4, 4)
        Me.BorrowPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BorrowPanel.Name = "BorrowPanel"
        Me.BorrowPanel.Size = New System.Drawing.Size(646, 63)
        Me.BorrowPanel.TabIndex = 0
        '
        'RefreshLabel
        '
        Me.RefreshLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshLabel.AutoSize = True
        Me.RefreshLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RefreshLabel.Location = New System.Drawing.Point(306, 34)
        Me.RefreshLabel.Name = "RefreshLabel"
        Me.RefreshLabel.Size = New System.Drawing.Size(45, 15)
        Me.RefreshLabel.TabIndex = 10
        Me.RefreshLabel.TabStop = True
        Me.RefreshLabel.Text = "refresh"
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
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 27)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(288, 22)
        Me.SearchTextBox.TabIndex = 2
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchLabel.Location = New System.Drawing.Point(9, 4)
        Me.SearchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(123, 20)
        Me.SearchLabel.TabIndex = 1
        Me.SearchLabel.Text = "Search ISBN/title"
        '
        'BorrowDataTable
        '
        Me.BorrowDataTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowDataTable.Location = New System.Drawing.Point(3, 74)
        Me.BorrowDataTable.Name = "BorrowDataTable"
        Me.BorrowDataTable.Size = New System.Drawing.Size(648, 477)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(654, 554)
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
        'ViewBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 554)
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
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents BorrowDataTable As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RefreshLabel As LinkLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
