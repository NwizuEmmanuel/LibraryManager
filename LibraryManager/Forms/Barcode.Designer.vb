<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Barcode
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BookFormTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchBookLabel = New System.Windows.Forms.Label()
        Me.BookTableView = New System.Windows.Forms.DataGridView()
        Me.BookFormTableLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BookTableView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BookFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.05556!))
        Me.BookFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.94444!))
        Me.BookFormTableLayoutPanel.Size = New System.Drawing.Size(592, 504)
        Me.BookFormTableLayoutPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.GenerateButton)
        Me.Panel1.Controls.Add(Me.RefreshButton)
        Me.Panel1.Controls.Add(Me.SearchTextBox)
        Me.Panel1.Controls.Add(Me.SearchBookLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 83)
        Me.Panel1.TabIndex = 0
        '
        'GenerateButton
        '
        Me.GenerateButton.BackColor = System.Drawing.Color.SlateBlue
        Me.GenerateButton.FlatAppearance.BorderSize = 0
        Me.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GenerateButton.Location = New System.Drawing.Point(308, 42)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(76, 31)
        Me.GenerateButton.TabIndex = 3
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.SlateBlue
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RefreshButton.Location = New System.Drawing.Point(226, 42)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(76, 31)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(6, 46)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(214, 25)
        Me.SearchTextBox.TabIndex = 1
        '
        'SearchBookLabel
        '
        Me.SearchBookLabel.AutoSize = True
        Me.SearchBookLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBookLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SearchBookLabel.Location = New System.Drawing.Point(4, 19)
        Me.SearchBookLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchBookLabel.Name = "SearchBookLabel"
        Me.SearchBookLabel.Size = New System.Drawing.Size(86, 17)
        Me.SearchBookLabel.TabIndex = 0
        Me.SearchBookLabel.Text = "Search Books"
        '
        'BookTableView
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BookTableView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.BookTableView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BookTableView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookTableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Coral
        Me.BookTableView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.BookTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookTableView.DefaultCellStyle = DataGridViewCellStyle12
        Me.BookTableView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookTableView.GridColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BookTableView.Location = New System.Drawing.Point(4, 95)
        Me.BookTableView.Margin = New System.Windows.Forms.Padding(4)
        Me.BookTableView.Name = "BookTableView"
        Me.BookTableView.ReadOnly = True
        Me.BookTableView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.BookTableView.Size = New System.Drawing.Size(584, 405)
        Me.BookTableView.TabIndex = 1
        '
        'Barcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 504)
        Me.Controls.Add(Me.BookFormTableLayoutPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Barcode"
        Me.Text = "Barcode"
        Me.BookFormTableLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BookTableView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BookFormTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RefreshButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchBookLabel As Label
    Friend WithEvents BookTableView As DataGridView
    Friend WithEvents GenerateButton As Button
End Class
