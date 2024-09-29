<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBook
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
        Me.BookFormTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchBookLabel = New System.Windows.Forms.Label()
        Me.BookTableView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookFormTableLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BookTableView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookFormTableLayoutPanel
        '
        Me.BookFormTableLayoutPanel.ColumnCount = 1
        Me.BookFormTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BookFormTableLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.BookFormTableLayoutPanel.Controls.Add(Me.BookTableView, 0, 1)
        Me.BookFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookFormTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.BookFormTableLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BookFormTableLayoutPanel.Name = "BookFormTableLayoutPanel"
        Me.BookFormTableLayoutPanel.RowCount = 2
        Me.BookFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.88889!))
        Me.BookFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.11111!))
        Me.BookFormTableLayoutPanel.Size = New System.Drawing.Size(697, 554)
        Me.BookFormTableLayoutPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RefreshButton)
        Me.Panel1.Controls.Add(Me.SearchTextBox)
        Me.Panel1.Controls.Add(Me.SearchBookLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 74)
        Me.Panel1.TabIndex = 0
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(606, 24)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(7, 24)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(244, 22)
        Me.SearchTextBox.TabIndex = 1
        '
        'SearchBookLabel
        '
        Me.SearchBookLabel.AutoSize = True
        Me.SearchBookLabel.Location = New System.Drawing.Point(4, 5)
        Me.SearchBookLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchBookLabel.Name = "SearchBookLabel"
        Me.SearchBookLabel.Size = New System.Drawing.Size(92, 16)
        Me.SearchBookLabel.TabIndex = 0
        Me.SearchBookLabel.Text = "Search Books"
        '
        'BookTableView
        '
        Me.BookTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookTableView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookTableView.Location = New System.Drawing.Point(4, 86)
        Me.BookTableView.Margin = New System.Windows.Forms.Padding(4)
        Me.BookTableView.Name = "BookTableView"
        Me.BookTableView.Size = New System.Drawing.Size(689, 464)
        Me.BookTableView.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ViewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 554)
        Me.Controls.Add(Me.BookFormTableLayoutPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewBook"
        Me.Text = "ViewBook"
        Me.BookFormTableLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BookTableView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BookFormTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BookTableView As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchBookLabel As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
