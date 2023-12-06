<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReagentLotNumberReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReagentLotNumberReport))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        dtFrom = New DateTimePicker()
        dtTo = New DateTimePicker()
        GroupBox2 = New GroupBox()
        rdAnalyte2 = New RadioButton()
        rdAnalyte1 = New RadioButton()
        rdAnalyte = New RadioButton()
        btnCalculate = New Button()
        btnExporttoExcel = New Button()
        btnCancel = New Button()
        lblExcelInfo = New Label()
        DataGridView1 = New DataGridView()
        dtEntry = New DataGridViewTextBoxColumn()
        SampleID = New DataGridViewTextBoxColumn()
        LtNumber = New DataGridViewTextBoxColumn()
        Exp = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(dtFrom)
        GroupBox1.Controls.Add(dtTo)
        GroupBox1.Location = New Point(33, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(146, 104)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "Between Dates"
        ' 
        ' dtFrom
        ' 
        dtFrom.CalendarFont = New Font("Segoe UI", 9F, FontStyle.Bold)
        dtFrom.Format = DateTimePickerFormat.Short
        dtFrom.Location = New Point(16, 58)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(93, 23)
        dtFrom.TabIndex = 1
        ' 
        ' dtTo
        ' 
        dtTo.CalendarFont = New Font("Segoe UI", 9F, FontStyle.Bold)
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(16, 22)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(93, 23)
        dtTo.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(rdAnalyte2)
        GroupBox2.Controls.Add(rdAnalyte1)
        GroupBox2.Controls.Add(rdAnalyte)
        GroupBox2.Location = New Point(195, 23)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(132, 104)
        GroupBox2.TabIndex = 28
        GroupBox2.TabStop = False
        GroupBox2.Text = "Parameters"
        ' 
        ' rdAnalyte2
        ' 
        rdAnalyte2.AutoSize = True
        rdAnalyte2.BackColor = Color.Transparent
        rdAnalyte2.FlatStyle = FlatStyle.Popup
        rdAnalyte2.Location = New Point(24, 62)
        rdAnalyte2.Name = "rdAnalyte2"
        rdAnalyte2.Size = New Size(73, 19)
        rdAnalyte2.TabIndex = 29
        rdAnalyte2.Text = "Sickledex"
        rdAnalyte2.UseVisualStyleBackColor = False
        ' 
        ' rdAnalyte1
        ' 
        rdAnalyte1.AutoSize = True
        rdAnalyte1.BackColor = Color.Transparent
        rdAnalyte1.FlatStyle = FlatStyle.Popup
        rdAnalyte1.Location = New Point(24, 42)
        rdAnalyte1.Name = "rdAnalyte1"
        rdAnalyte1.Size = New Size(63, 19)
        rdAnalyte1.TabIndex = 28
        rdAnalyte1.Text = "Malaria"
        rdAnalyte1.UseVisualStyleBackColor = False
        ' 
        ' rdAnalyte
        ' 
        rdAnalyte.AutoSize = True
        rdAnalyte.BackColor = Color.Transparent
        rdAnalyte.Checked = True
        rdAnalyte.FlatStyle = FlatStyle.Popup
        rdAnalyte.Location = New Point(24, 22)
        rdAnalyte.Name = "rdAnalyte"
        rdAnalyte.Size = New Size(79, 19)
        rdAnalyte.TabIndex = 27
        rdAnalyte.TabStop = True
        rdAnalyte.Text = "Monospot"
        rdAnalyte.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.ButtonFace
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.Image = CType(resources.GetObject("btnCalculate.Image"), Image)
        btnCalculate.ImageAlign = ContentAlignment.TopCenter
        btnCalculate.Location = New Point(349, 32)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(71, 85)
        btnCalculate.TabIndex = 29
        btnCalculate.Text = "Calculate"
        btnCalculate.TextAlign = ContentAlignment.BottomCenter
        btnCalculate.TextImageRelation = TextImageRelation.ImageAboveText
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnExporttoExcel
        ' 
        btnExporttoExcel.BackColor = SystemColors.ButtonFace
        btnExporttoExcel.BackgroundImageLayout = ImageLayout.None
        btnExporttoExcel.Image = CType(resources.GetObject("btnExporttoExcel.Image"), Image)
        btnExporttoExcel.ImageAlign = ContentAlignment.TopCenter
        btnExporttoExcel.Location = New Point(445, 32)
        btnExporttoExcel.Name = "btnExporttoExcel"
        btnExporttoExcel.Size = New Size(76, 85)
        btnExporttoExcel.TabIndex = 30
        btnExporttoExcel.Text = "Export to Excel"
        btnExporttoExcel.TextAlign = ContentAlignment.BottomCenter
        btnExporttoExcel.TextImageRelation = TextImageRelation.ImageAboveText
        btnExporttoExcel.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(547, 34)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(76, 83)
        btnCancel.TabIndex = 31
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblExcelInfo
        ' 
        lblExcelInfo.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblExcelInfo.BorderStyle = BorderStyle.FixedSingle
        lblExcelInfo.FlatStyle = FlatStyle.Popup
        lblExcelInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExcelInfo.Location = New Point(433, 129)
        lblExcelInfo.Name = "lblExcelInfo"
        lblExcelInfo.Size = New Size(100, 23)
        lblExcelInfo.TabIndex = 32
        lblExcelInfo.Text = "Exporting ...."
        lblExcelInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {dtEntry, SampleID, LtNumber, Exp})
        DataGridView1.Location = New Point(33, 160)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(607, 328)
        DataGridView1.TabIndex = 33
        ' 
        ' dtEntry
        ' 
        dtEntry.HeaderText = "Date/Time of Entry"
        dtEntry.Name = "dtEntry"
        dtEntry.Width = 170
        ' 
        ' SampleID
        ' 
        SampleID.HeaderText = "Sample ID"
        SampleID.Name = "SampleID"
        SampleID.Width = 120
        ' 
        ' LtNumber
        ' 
        LtNumber.HeaderText = "Lot Number"
        LtNumber.Name = "LtNumber"
        LtNumber.Width = 120
        ' 
        ' Exp
        ' 
        Exp.HeaderText = "Expiry"
        Exp.Name = "Exp"
        ' 
        ' frmReagentLotNumberReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(800, 558)
        Controls.Add(DataGridView1)
        Controls.Add(lblExcelInfo)
        Controls.Add(btnCancel)
        Controls.Add(btnExporttoExcel)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmReagentLotNumberReport"
        Text = "frmReagentLotNumberReport"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdAnalyte2 As RadioButton
    Friend WithEvents rdAnalyte1 As RadioButton
    Friend WithEvents rdAnalyte As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExporttoExcel As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblExcelInfo As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtEntry As DataGridViewTextBoxColumn
    Friend WithEvents SampleID As DataGridViewTextBoxColumn
    Friend WithEvents LtNumber As DataGridViewTextBoxColumn
    Friend WithEvents Exp As DataGridViewTextBoxColumn
End Class
