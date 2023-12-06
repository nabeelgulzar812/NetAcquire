<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMicroListDemographics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMicroListDemographics))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ProgressBar1 = New ProgressBar()
        lblExcelInfo = New Label()
        btnCancel = New Button()
        btnExporttoExcel = New Button()
        btnCalculate = New Button()
        GroupBox1 = New GroupBox()
        rdSIDs = New RadioButton()
        rdDates = New RadioButton()
        txtTo = New TextBox()
        txtFrom = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.GradientActiveCaption
        ProgressBar1.Location = New Point(12, 121)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(709, 19)
        ProgressBar1.TabIndex = 52
        ' 
        ' lblExcelInfo
        ' 
        lblExcelInfo.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblExcelInfo.BorderStyle = BorderStyle.FixedSingle
        lblExcelInfo.FlatStyle = FlatStyle.Popup
        lblExcelInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExcelInfo.Location = New Point(595, 46)
        lblExcelInfo.Name = "lblExcelInfo"
        lblExcelInfo.Size = New Size(100, 23)
        lblExcelInfo.TabIndex = 50
        lblExcelInfo.Text = "Exporting ...."
        lblExcelInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(444, 19)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(76, 83)
        btnCancel.TabIndex = 49
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
        btnExporttoExcel.Location = New Point(518, 19)
        btnExporttoExcel.Name = "btnExporttoExcel"
        btnExporttoExcel.Size = New Size(76, 83)
        btnExporttoExcel.TabIndex = 48
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
        btnCalculate.Location = New Point(259, 19)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(93, 85)
        btnCalculate.TabIndex = 47
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
        GroupBox1.Location = New Point(13, 16)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(222, 104)
        GroupBox1.TabIndex = 46
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
        rdSIDs.Text = "Sample Numbers"
        rdSIDs.UseVisualStyleBackColor = True
        ' 
        ' rdDates
        ' 
        rdDates.AutoSize = True
        rdDates.CheckAlign = ContentAlignment.MiddleRight
        rdDates.Checked = True
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
        ' DataGridView1
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11})
        DataGridView1.Location = New Point(12, 142)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(709, 352)
        DataGridView1.TabIndex = 53
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Patient Name"
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Chart"
        Column2.Name = "Column2"
        Column2.Width = 60
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Date of Birth"
        Column3.Name = "Column3"
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Sex"
        Column4.Name = "Column4"
        Column4.Width = 40
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Address"
        Column5.Name = "Column5"
        Column5.Width = 60
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Ward"
        Column6.Name = "Column6"
        Column6.Width = 50
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Clinician"
        Column7.Name = "Column7"
        Column7.Width = 50
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "GP"
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Sample ID"
        Column9.Name = "Column9"
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Site"
        Column10.Name = "Column10"
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Site Details"
        Column11.Name = "Column11"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Lime
        Label4.Location = New Point(259, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(368, 14)
        Label4.TabIndex = 54
        ' 
        ' frmMicroListDemographics
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(957, 653)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(ProgressBar1)
        Controls.Add(lblExcelInfo)
        Controls.Add(btnCancel)
        Controls.Add(btnExporttoExcel)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox1)
        Name = "frmMicroListDemographics"
        Text = "frmMicroListDemographics"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblExcelInfo As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExporttoExcel As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdSIDs As RadioButton
    Friend WithEvents rdDates As RadioButton
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
End Class
