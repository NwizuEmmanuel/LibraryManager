<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBorrow
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
        Me.BorrowPanel = New System.Windows.Forms.Panel()
        Me.SearchBorrowsTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.BorrowDataTable = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.BorrowPanel.SuspendLayout()
        CType(Me.BorrowDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BorrowPanel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BorrowDataTable, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.07942!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.92058!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(746, 554)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BorrowPanel
        '
        Me.BorrowPanel.Controls.Add(Me.SearchBorrowsTextBox)
        Me.BorrowPanel.Controls.Add(Me.Label1)
        Me.BorrowPanel.Controls.Add(Me.RefreshButton)
        Me.BorrowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowPanel.Location = New System.Drawing.Point(4, 4)
        Me.BorrowPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BorrowPanel.Name = "BorrowPanel"
        Me.BorrowPanel.Size = New System.Drawing.Size(738, 70)
        Me.BorrowPanel.TabIndex = 0
        '
        'SearchBorrowsTextBox
        '
        Me.SearchBorrowsTextBox.Location = New System.Drawing.Point(12, 24)
        Me.SearchBorrowsTextBox.Name = "SearchBorrowsTextBox"
        Me.SearchBorrowsTextBox.Size = New System.Drawing.Size(288, 22)
        Me.SearchBorrowsTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Borrows"
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Location = New System.Drawing.Point(610, 21)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(124, 28)
        Me.RefreshButton.TabIndex = 0
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'BorrowDataTable
        '
        Me.BorrowDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowDataTable.Location = New System.Drawing.Point(3, 81)
        Me.BorrowDataTable.Name = "BorrowDataTable"
        Me.BorrowDataTable.Size = New System.Drawing.Size(740, 470)
        Me.BorrowDataTable.TabIndex = 1
        '
        'ViewBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 554)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewBorrow"
        Me.Text = "ViewBorrow"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.BorrowPanel.ResumeLayout(False)
        Me.BorrowPanel.PerformLayout()
        CType(Me.BorrowDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BorrowPanel As Panel
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBorrowsTextBox As TextBox
    Friend WithEvents BorrowDataTable As DataGridView
End Class
