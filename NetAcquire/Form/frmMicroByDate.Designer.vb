
Partial Class frmMicroByDate
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMicroByDate))
        ProgressBar1 = New ProgressBar()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        lblExcelInfo = New Label()
        btnCancel = New Button()
        btnExporttoCancel = New Button()
        btnCalculate = New Button()
        GroupBox1 = New GroupBox()
        rdSIDs = New RadioButton()
        rdDates = New RadioButton()
        txtTo = New TextBox()
        txtFrom = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.GradientActiveCaption
        ProgressBar1.Location = New Point(12, 123)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(709, 19)
        ProgressBar1.TabIndex = 45
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DataGridView1.Location = New Point(12, 144)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(708, 352)
        DataGridView1.TabIndex = 44
        ' 
        ' Column1
        ' 
        Column1.HeaderText = ""
        Column1.Name = "Column1"
        Column1.Width = 140
        ' 
        ' Column2
        ' 
        Column2.HeaderText = ""
        Column2.Name = "Column2"
        Column2.Width = 50
        ' 
        ' lblExcelInfo
        ' 
        lblExcelInfo.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblExcelInfo.BorderStyle = BorderStyle.FixedSingle
        lblExcelInfo.FlatStyle = FlatStyle.Popup
        lblExcelInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExcelInfo.Location = New Point(595, 46)
        lblExcelInfo.Name = "lblExcelInfo"
        lblExcelInfo.Size = New Size(100, 23)
        lblExcelInfo.TabIndex = 43
        lblExcelInfo.Text = "Exporting ...."
        lblExcelInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(444, 29)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(76, 83)
        btnCancel.TabIndex = 42
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnExporttoCancel
        ' 
        btnExporttoCancel.BackColor = SystemColors.ButtonFace
        btnExporttoCancel.BackgroundImageLayout = ImageLayout.None
        btnExporttoCancel.Image = CType(resources.GetObject("btnExporttoCancel.Image"), Image)
        btnExporttoCancel.ImageAlign = ContentAlignment.TopCenter
        btnExporttoCancel.Location = New Point(518, 29)
        btnExporttoCancel.Name = "btnExporttoCancel"
        btnExporttoCancel.Size = New Size(76, 83)
        btnExporttoCancel.TabIndex = 41
        btnExporttoCancel.Text = "Export to Excel"
        btnExporttoCancel.TextAlign = ContentAlignment.BottomCenter
        btnExporttoCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnExporttoCancel.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.ButtonFace
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.Image = CType(resources.GetObject("btnCalculate.Image"), Image)
        btnCalculate.ImageAlign = ContentAlignment.TopCenter
        btnCalculate.Location = New Point(259, 29)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(93, 85)
        btnCalculate.TabIndex = 40
        btnCalculate.Text = "Calculate"
        btnCalculate.TextAlign = ContentAlignment.BottomCenter
        btnCalculate.TextImageRelation = TextImageRelation.ImageAboveText
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(rdSIDs)
        GroupBox1.Controls.Add(rdDates)
        GroupBox1.Controls.Add(txtTo)
        GroupBox1.Controls.Add(txtFrom)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(13, 18)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(222, 104)
        GroupBox1.TabIndex = 39
        GroupBox1.TabStop = False
        ' 
        ' rdSIDs
        ' 
        rdSIDs.AutoSize = True
        rdSIDs.FlatStyle = FlatStyle.Popup
        rdSIDs.Location = New Point(105, 0)
        rdSIDs.Name = "rdSIDs"
        rdSIDs.Size = New Size(115, 19)
        rdSIDs.TabIndex = 30
        rdSIDs.TabStop = True
        rdSIDs.Text = "Sample Numbers"
        rdSIDs.UseVisualStyleBackColor = True
        ' 
        ' rdDates
        ' 
        rdDates.AutoSize = True
        rdDates.CheckAlign = ContentAlignment.MiddleRight
        rdDates.FlatStyle = FlatStyle.Popup
        rdDates.Location = New Point(0, 0)
        rdDates.Name = "rdDates"
        rdDates.Size = New Size(101, 19)
        rdDates.TabIndex = 29
        rdDates.TabStop = True
        rdDates.Text = "Between Dates"
        rdDates.UseVisualStyleBackColor = True
        ' 
        ' txtTo
        ' 
        txtTo.BorderStyle = BorderStyle.FixedSingle
        txtTo.Location = New Point(56, 54)
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(99, 23)
        txtTo.TabIndex = 3
        ' 
        ' txtFrom
        ' 
        txtFrom.BorderStyle = BorderStyle.FixedSingle
        txtFrom.Location = New Point(56, 25)
        txtFrom.Name = "txtFrom"
        txtFrom.Size = New Size(99, 23)
        txtFrom.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 15)
        Label2.TabIndex = 1
        Label2.Text = "To"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 0
        Label1.Text = "From"
        ' 
        ' frmMicroByDate
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(750, 545)
        Controls.Add(ProgressBar1)
        Controls.Add(DataGridView1)
        Controls.Add(lblExcelInfo)
        Controls.Add(btnCancel)
        Controls.Add(btnExporttoCancel)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox1)
        Name = "frmMicroByDate"
        Text = "frmMicroByDate"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents lblExcelInfo As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExporttoCancel As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdSIDs As RadioButton
    Friend WithEvents rdDates As RadioButton
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
