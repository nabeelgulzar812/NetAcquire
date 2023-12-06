<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBioTodayQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBioTodayQC))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        rdSampleType = New RadioButton()
        rdSampleType2 = New RadioButton()
        dt = New DateTimePicker()
        lstControl = New ListBox()
        btnRefresh = New Button()
        DataGridView1 = New DataGridView()
        Chart = New DataGridViewTextBoxColumn()
        Name = New DataGridViewTextBoxColumn()
        DateofBirth = New DataGridViewTextBoxColumn()
        Sex = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Ward = New DataGridViewTextBoxColumn()
        Clinician = New DataGridViewTextBoxColumn()
        clmCode = New DataGridViewTextBoxColumn()
        btnCancel = New Button()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(0, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 35)
        Label1.TabIndex = 0
        Label1.Text = "Click on Parameter to Delete"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' rdSampleType
        ' 
        rdSampleType.AutoSize = True
        rdSampleType.CheckAlign = ContentAlignment.MiddleRight
        rdSampleType.Location = New Point(152, 15)
        rdSampleType.Name = "rdSampleType"
        rdSampleType.Size = New Size(59, 19)
        rdSampleType.TabIndex = 2
        rdSampleType.Text = "Serum"
        rdSampleType.UseVisualStyleBackColor = True
        ' 
        ' rdSampleType2
        ' 
        rdSampleType2.AutoSize = True
        rdSampleType2.CheckAlign = ContentAlignment.MiddleRight
        rdSampleType2.Location = New Point(158, 32)
        rdSampleType2.Name = "rdSampleType2"
        rdSampleType2.Size = New Size(53, 19)
        rdSampleType2.TabIndex = 3
        rdSampleType2.TabStop = True
        rdSampleType2.Text = "Urine"
        rdSampleType2.UseVisualStyleBackColor = True
        ' 
        ' dt
        ' 
        dt.Format = DateTimePickerFormat.Short
        dt.Location = New Point(254, 9)
        dt.Name = "dt"
        dt.Size = New Size(89, 23)
        dt.TabIndex = 4
        ' 
        ' lstControl
        ' 
        lstControl.BackColor = SystemColors.Window
        lstControl.ForeColor = SystemColors.WindowText
        lstControl.FormattingEnabled = True
        lstControl.ItemHeight = 15
        lstControl.Location = New Point(253, 37)
        lstControl.Name = "lstControl"
        lstControl.Size = New Size(221, 34)
        lstControl.TabIndex = 5
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonFace
        btnRefresh.BackgroundImageLayout = ImageLayout.None
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.Location = New Point(503, 9)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(76, 72)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "&Refresh"
        btnRefresh.TextAlign = ContentAlignment.BottomCenter
        btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Black
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Chart, Name, DateofBirth, Sex, Address, Column1, Ward, Clinician, clmCode})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Info
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ButtonFace
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.GridColor = SystemColors.InactiveCaptionText
        DataGridView1.Location = New Point(0, 90)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView1.Size = New Size(686, 493)
        DataGridView1.TabIndex = 9
        ' 
        ' Chart
        ' 
        Chart.HeaderText = "Parameter"
        Chart.Name = "Chart"
        Chart.Width = 110
        ' 
        ' Name
        ' 
        Name.HeaderText = "Run Time"
        Name.Name = "Name"
        Name.Width = 70
        ' 
        ' DateofBirth
        ' 
        DateofBirth.HeaderText = "Value"
        DateofBirth.Name = "DateofBirth"
        DateofBirth.Width = 70
        ' 
        ' Sex
        ' 
        Sex.HeaderText = ""
        Sex.Name = "Sex"
        Sex.Width = 140
        ' 
        ' Address
        ' 
        Address.HeaderText = "Mean"
        Address.Name = "Address"
        Address.Width = 50
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Low"
        Column1.Name = "Column1"
        Column1.Width = 50
        ' 
        ' Ward
        ' 
        Ward.HeaderText = "High"
        Ward.Name = "Ward"
        Ward.Width = 50
        ' 
        ' Clinician
        ' 
        Clinician.HeaderText = "2 SD"
        Clinician.Name = "Clinician"
        Clinician.Width = 60
        ' 
        ' clmCode
        ' 
        clmCode.HeaderText = "Code"
        clmCode.Name = "clmCode"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(608, 9)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(76, 72)
        btnCancel.TabIndex = 7
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmBioTodayQC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(919, 701)
        Controls.Add(DataGridView1)
        Controls.Add(btnCancel)
        Controls.Add(btnRefresh)
        Controls.Add(lstControl)
        Controls.Add(dt)
        Controls.Add(rdSampleType2)
        Controls.Add(rdSampleType)
        Controls.Add(Label1)
        'Name = "frmBioTodayQC"
        Text = "Form2"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdSampleType As RadioButton
    Friend WithEvents rdSampleType2 As RadioButton
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents lstControl As ListBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Chart As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents DateofBirth As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Ward As DataGridViewTextBoxColumn
    Friend WithEvents Clinician As DataGridViewTextBoxColumn
    Friend WithEvents clmCode As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
End Class
