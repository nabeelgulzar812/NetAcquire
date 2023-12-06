<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MicroUsage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MicroUsage))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        rdSIDs = New RadioButton()
        rdDates = New RadioButton()
        txtTo = New TextBox()
        txtFrom = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        lblExcelInfo = New Label()
        btnCancel = New Button()
        btnExporttoExcel = New Button()
        btnCalculate = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        ProgressBar1 = New ProgressBar()
        GroupBox1.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        GroupBox1.Location = New Point(35, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(222, 104)
        GroupBox1.TabIndex = 28
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
        ' lblExcelInfo
        ' 
        lblExcelInfo.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblExcelInfo.BorderStyle = BorderStyle.FixedSingle
        lblExcelInfo.FlatStyle = FlatStyle.Popup
        lblExcelInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExcelInfo.Location = New Point(617, 43)
        lblExcelInfo.Name = "lblExcelInfo"
        lblExcelInfo.Size = New Size(100, 23)
        lblExcelInfo.TabIndex = 36
        lblExcelInfo.Text = "Exporting ...."
        lblExcelInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(466, 26)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(76, 83)
        btnCancel.TabIndex = 35
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnExporttoExcel
        ' 
        btnExporttoExcel.BackColor = SystemColors.ButtonFace
        btnExporttoExcel.BackgroundImageLayout = ImageLayout.None
        btnExporttoExcel.Image = CType(resources.GetObject("btnExporttoExcel.Image"), Image)
        btnExporttoExcel.ImageAlign = ContentAlignment.TopCenter
        btnExporttoExcel.Location = New Point(540, 26)
        btnExporttoExcel.Name = "btnExporttoExcel"
        btnExporttoExcel.Size = New Size(76, 83)
        btnExporttoExcel.TabIndex = 34
        btnExporttoExcel.Text = "Export to Excel"
        btnExporttoExcel.TextAlign = ContentAlignment.BottomCenter
        btnExporttoExcel.TextImageRelation = TextImageRelation.ImageAboveText
        btnExporttoExcel.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.ButtonFace
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.Image = CType(resources.GetObject("btnCalculate.Image"), Image)
        btnCalculate.ImageAlign = ContentAlignment.TopCenter
        btnCalculate.Location = New Point(281, 26)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(83, 85)
        btnCalculate.TabIndex = 33
        btnCalculate.Text = "Calculate"
        btnCalculate.TextAlign = ContentAlignment.BottomCenter
        btnCalculate.TextImageRelation = TextImageRelation.ImageAboveText
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(34, 141)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(708, 352)
        DataGridView1.TabIndex = 37
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Site"
        Column1.Name = "Column1"
        Column1.Width = 140
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "In"
        Column2.Name = "Column2"
        Column2.Width = 50
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "AE"
        Column3.Name = "Column3"
        Column3.Width = 50
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Out"
        Column4.Name = "Column4"
        Column4.Width = 50
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "GP"
        Column5.Name = "Column5"
        Column5.Width = 50
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "MGH"
        Column6.Name = "Column6"
        Column6.Width = 50
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Total"
        Column7.Name = "Column7"
        Column7.Width = 50
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.GradientActiveCaption
        ProgressBar1.Location = New Point(34, 120)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(709, 19)
        ProgressBar1.TabIndex = 38
        ' 
        ' frm_MicroUsage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(928, 657)
        Controls.Add(ProgressBar1)
        Controls.Add(DataGridView1)
        Controls.Add(lblExcelInfo)
        Controls.Add(btnCancel)
        Controls.Add(btnExporttoExcel)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox1)
        Name = "frm_MicroUsage"
        Text = "frm_MicroUsage"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdSIDs As RadioButton
    Friend WithEvents rdDates As RadioButton
    Friend WithEvents txtTo As TextBox
    Friend WithEvents lblExcelInfo As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExporttoExcel As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
