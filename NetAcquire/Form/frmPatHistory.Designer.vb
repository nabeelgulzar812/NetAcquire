
Partial Class frmPatHistory
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
        'components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatHistory))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        rdboth = New RadioButton()
        rdHistoric = New RadioButton()
        rdDownLoad = New RadioButton()
        chkShort = New CheckBox()
        lblDept = New Label()
        Panel1 = New Panel()
        chkRemote = New CheckBox()
        txtName = New TextBox()
        lblNoPrevious = New Label()
        btnSearch = New Button()
        btnCancel = New Button()
        btnCopy = New Button()
        DataGridView1 = New DataGridView()
        Chart = New DataGridViewTextBoxColumn()
        Name = New DataGridViewTextBoxColumn()
        DateofBirth = New DataGridViewTextBoxColumn()
        Sex = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Ward = New DataGridViewTextBoxColumn()
        Clinician = New DataGridViewTextBoxColumn()
        Hospital = New DataGridViewTextBoxColumn()
        LabNo = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        txtDoB = New TextBox()
        GroupBox2 = New GroupBox()
        chkSoundex = New CheckBox()
        rdNameDob = New RadioButton()
        rdDob = New RadioButton()
        rdChart = New RadioButton()
        rdName = New RadioButton()
        GroupBox3 = New GroupBox()
        rdAllc = New RadioButton()
        rdTc = New RadioButton()
        rdLc = New RadioButton()
        rdExact = New RadioButton()
        GroupBox4 = New GroupBox()
        nudRecords = New NumericUpDown()
        Timer1 = New Timer(components)
        pBar = New ProgressBar()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        'CType(nudRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(rdboth)
        GroupBox1.Controls.Add(rdHistoric)
        GroupBox1.Controls.Add(rdDownLoad)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(108, 84)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search"
        ' 
        ' rdboth
        ' 
        rdboth.CheckAlign = ContentAlignment.MiddleRight
        rdboth.FlatStyle = FlatStyle.Popup
        rdboth.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdboth.Location = New Point(3, 52)
        rdboth.Name = "rdboth"
        rdboth.Size = New Size(79, 19)
        rdboth.TabIndex = 2
        rdboth.TabStop = True
        rdboth.Text = "Both"
        rdboth.UseVisualStyleBackColor = True
        ' 
        ' rdHistoric
        ' 
        rdHistoric.CheckAlign = ContentAlignment.MiddleRight
        rdHistoric.FlatStyle = FlatStyle.Popup
        rdHistoric.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdHistoric.Location = New Point(3, 36)
        rdHistoric.Name = "rdHistoric"
        rdHistoric.Size = New Size(79, 19)
        rdHistoric.TabIndex = 1
        rdHistoric.TabStop = True
        rdHistoric.Text = "Historic"
        rdHistoric.UseVisualStyleBackColor = True
        ' 
        ' rdDownLoad
        ' 
        rdDownLoad.CheckAlign = ContentAlignment.MiddleRight
        rdDownLoad.FlatStyle = FlatStyle.Popup
        rdDownLoad.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdDownLoad.Location = New Point(3, 19)
        rdDownLoad.Name = "rdDownLoad"
        rdDownLoad.Size = New Size(79, 19)
        rdDownLoad.TabIndex = 0
        rdDownLoad.TabStop = True
        rdDownLoad.Text = "Download"
        rdDownLoad.UseVisualStyleBackColor = True
        ' 
        ' chkShort
        ' 
        chkShort.BackColor = SystemColors.ButtonFace
        chkShort.FlatStyle = FlatStyle.Popup
        chkShort.ImageAlign = ContentAlignment.MiddleLeft
        chkShort.Location = New Point(19, 102)
        chkShort.Name = "chkShort"
        chkShort.Size = New Size(127, 18)
        chkShort.TabIndex = 1
        chkShort.UseVisualStyleBackColor = False
        ' 
        ' lblDept
        ' 
        lblDept.BackColor = SystemColors.ButtonFace
        lblDept.Location = New Point(116, 26)
        lblDept.Name = "lblDept"
        lblDept.Size = New Size(79, 24)
        lblDept.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(chkRemote)
        Panel1.Controls.Add(txtName)
        Panel1.Location = New Point(196, 18)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(376, 38)
        Panel1.TabIndex = 3
        ' 
        ' chkRemote
        ' 
        chkRemote.AutoSize = True
        chkRemote.FlatStyle = FlatStyle.Popup
        chkRemote.ImageAlign = ContentAlignment.BottomRight
        chkRemote.Location = New Point(236, 11)
        chkRemote.Name = "chkRemote"
        chkRemote.Size = New Size(132, 19)
        chkRemote.TabIndex = 4
        chkRemote.Text = " Also Search Remote"
        chkRemote.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(3, 7)
        txtName.Name = "txtName"
        txtName.Size = New Size(224, 23)
        txtName.TabIndex = 4
        ' 
        ' lblNoPrevious
        ' 
        lblNoPrevious.BackColor = Color.Yellow
        lblNoPrevious.ForeColor = Color.Red
        lblNoPrevious.Location = New Point(468, 86)
        lblNoPrevious.Name = "lblNoPrevious"
        lblNoPrevious.Size = New Size(104, 34)
        lblNoPrevious.TabIndex = 4
        lblNoPrevious.Text = " No Previous Details"
        lblNoPrevious.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.ButtonFace
        btnSearch.BackgroundImageLayout = ImageLayout.None
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.Location = New Point(196, 57)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 71)
        btnSearch.TabIndex = 5
        btnSearch.Text = "&Search"
        btnSearch.TextAlign = ContentAlignment.BottomCenter
        btnSearch.TextImageRelation = TextImageRelation.ImageAboveText
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.Location = New Point(277, 57)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 71)
        btnCancel.TabIndex = 6
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnCopy
        ' 
        btnCopy.BackColor = SystemColors.ButtonFace
        btnCopy.BackgroundImageLayout = ImageLayout.None
        btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), Image)
        btnCopy.Location = New Point(358, 57)
        btnCopy.Name = "btnCopy"
        btnCopy.Size = New Size(84, 71)
        btnCopy.TabIndex = 7
        btnCopy.Text = " Copy to &Edit"
        btnCopy.TextAlign = ContentAlignment.BottomCenter
        btnCopy.TextImageRelation = TextImageRelation.ImageAboveText
        btnCopy.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Black
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle4.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Chart, Name, DateofBirth, Sex, Address, Column1, Ward, Clinician, Hospital, LabNo, Column2, Column3, Column4, Column5, Column6})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Info
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ButtonFace
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.GridColor = SystemColors.InactiveCaptionText
        DataGridView1.Location = New Point(-11, 140)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView1.Size = New Size(1100, 605)
        DataGridView1.TabIndex = 8
        ' 
        ' Chart
        ' 
        Chart.HeaderText = "Chart"
        Chart.Name = "Chart"
        ' 
        ' Name
        ' 
        Name.HeaderText = "Name"
        Name.Name = "Name"
        ' 
        ' DateofBirth
        ' 
        DateofBirth.HeaderText = "Date of Birth"
        DateofBirth.Name = "DateofBirth"
        ' 
        ' Sex
        ' 
        Sex.HeaderText = "Sex"
        Sex.Name = "Sex"
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.Name = "Address"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = ""
        Column1.Name = "Column1"
        ' 
        ' Ward
        ' 
        Ward.HeaderText = "Ward"
        Ward.Name = "Ward"
        ' 
        ' Clinician
        ' 
        Clinician.HeaderText = "Clinician"
        Clinician.Name = "Clinician"
        ' 
        ' Hospital
        ' 
        Hospital.HeaderText = "Hospital"
        Hospital.Name = "Hospital"
        ' 
        ' LabNo
        ' 
        LabNo.HeaderText = "Lab No"
        LabNo.Name = "LabNo"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = ""
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = ""
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = ""
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = ""
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = ""
        Column6.Name = "Column6"
        ' 
        ' txtDoB
        ' 
        txtDoB.BackColor = Color.Cyan
        txtDoB.ForeColor = Color.Red
        txtDoB.Location = New Point(243, 124)
        txtDoB.Name = "txtDoB"
        txtDoB.Size = New Size(81, 23)
        txtDoB.TabIndex = 5
        txtDoB.Text = "Date of Birth"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(chkSoundex)
        GroupBox2.Controls.Add(rdNameDob)
        GroupBox2.Controls.Add(rdDob)
        GroupBox2.Controls.Add(rdChart)
        GroupBox2.Controls.Add(rdName)
        GroupBox2.Location = New Point(601, 13)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(189, 107)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search For"
        ' 
        ' chkSoundex
        ' 
        chkSoundex.FlatStyle = FlatStyle.Popup
        chkSoundex.ImageAlign = ContentAlignment.MiddleLeft
        chkSoundex.Location = New Point(86, 25)
        chkSoundex.Name = "chkSoundex"
        chkSoundex.Size = New Size(94, 18)
        chkSoundex.TabIndex = 10
        chkSoundex.Text = "Use Soundex"
        chkSoundex.UseVisualStyleBackColor = True
        ' 
        ' rdNameDob
        ' 
        rdNameDob.FlatStyle = FlatStyle.Popup
        rdNameDob.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdNameDob.Location = New Point(86, 46)
        rdNameDob.Name = "rdNameDob"
        rdNameDob.Size = New Size(84, 19)
        rdNameDob.TabIndex = 6
        rdNameDob.TabStop = True
        rdNameDob.Text = "Name+DoB"
        rdNameDob.UseVisualStyleBackColor = True
        ' 
        ' rdDob
        ' 
        rdDob.CheckAlign = ContentAlignment.MiddleRight
        rdDob.FlatStyle = FlatStyle.Popup
        rdDob.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdDob.Location = New Point(6, 69)
        rdDob.Name = "rdDob"
        rdDob.Size = New Size(66, 19)
        rdDob.TabIndex = 5
        rdDob.TabStop = True
        rdDob.Text = " D. o . B"
        rdDob.UseVisualStyleBackColor = True
        ' 
        ' rdChart
        ' 
        rdChart.CheckAlign = ContentAlignment.MiddleRight
        rdChart.FlatStyle = FlatStyle.Popup
        rdChart.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdChart.Location = New Point(6, 46)
        rdChart.Name = "rdChart"
        rdChart.Size = New Size(66, 19)
        rdChart.TabIndex = 4
        rdChart.TabStop = True
        rdChart.Text = "Chart"
        rdChart.UseVisualStyleBackColor = True
        ' 
        ' rdName
        ' 
        rdName.CheckAlign = ContentAlignment.MiddleRight
        rdName.FlatStyle = FlatStyle.Popup
        rdName.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdName.Location = New Point(6, 21)
        rdName.Name = "rdName"
        rdName.Size = New Size(66, 19)
        rdName.TabIndex = 3
        rdName.TabStop = True
        rdName.Text = "Name"
        rdName.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ButtonFace
        GroupBox3.Controls.Add(rdAllc)
        GroupBox3.Controls.Add(rdTc)
        GroupBox3.Controls.Add(rdLc)
        GroupBox3.Controls.Add(rdExact)
        GroupBox3.Location = New Point(795, 13)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(189, 107)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        GroupBox3.Text = "How to Search"
        ' 
        ' rdAllc
        ' 
        rdAllc.FlatStyle = FlatStyle.Popup
        rdAllc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdAllc.Location = New Point(6, 76)
        rdAllc.Name = "rdAllc"
        rdAllc.Size = New Size(177, 19)
        rdAllc.TabIndex = 6
        rdAllc.TabStop = True
        rdAllc.Text = "All Characters   (Slow Search)"
        rdAllc.UseVisualStyleBackColor = True
        ' 
        ' rdTc
        ' 
        rdTc.FlatStyle = FlatStyle.Popup
        rdTc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdTc.Location = New Point(6, 56)
        rdTc.Name = "rdTc"
        rdTc.Size = New Size(123, 19)
        rdTc.TabIndex = 5
        rdTc.TabStop = True
        rdTc.Text = "Trailing Characters"
        rdTc.UseVisualStyleBackColor = True
        ' 
        ' rdLc
        ' 
        rdLc.FlatStyle = FlatStyle.Popup
        rdLc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdLc.Location = New Point(6, 40)
        rdLc.Name = "rdLc"
        rdLc.Size = New Size(123, 19)
        rdLc.TabIndex = 4
        rdLc.TabStop = True
        rdLc.Text = "Leading Characters"
        rdLc.UseVisualStyleBackColor = True
        ' 
        ' rdExact
        ' 
        rdExact.FlatStyle = FlatStyle.Popup
        rdExact.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdExact.Location = New Point(6, 21)
        rdExact.Name = "rdExact"
        rdExact.Size = New Size(87, 19)
        rdExact.TabIndex = 3
        rdExact.TabStop = True
        rdExact.Text = "Exact Match"
        rdExact.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.ButtonFace
        GroupBox4.Controls.Add(nudRecords)
        GroupBox4.Location = New Point(989, 15)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(94, 75)
        GroupBox4.TabIndex = 12
        GroupBox4.TabStop = False
        GroupBox4.Text = "Records"
        ' 
        ' nudRecords
        ' 
        nudRecords.Location = New Point(21, 22)
        nudRecords.Name = "nudRecords"
        nudRecords.Size = New Size(53, 23)
        nudRecords.TabIndex = 6
        nudRecords.TextAlign = HorizontalAlignment.Center
        nudRecords.Value = New Decimal(New Integer() {25, 0, 0, 0})
        ' 
        ' pBar
        ' 
        pBar.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        pBar.ForeColor = Color.Blue
        pBar.Location = New Point(550, 123)
        pBar.Maximum = 600
        pBar.Name = "pBar"
        pBar.Size = New Size(488, 15)
        pBar.TabIndex = 13
        ' 
        ' frmPatHistory
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1269, 816)
        Controls.Add(pBar)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(txtDoB)
        Controls.Add(DataGridView1)
        Controls.Add(btnCopy)
        Controls.Add(btnCancel)
        Controls.Add(btnSearch)
        Controls.Add(lblNoPrevious)
        Controls.Add(Panel1)
        Controls.Add(lblDept)
        Controls.Add(chkShort)
        Controls.Add(GroupBox1)
        'Name = "frmPatHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NetAcquire - Patient Search"
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        'CType(nudRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdDownLoad As RadioButton
    Friend WithEvents rdboth As RadioButton
    Friend WithEvents rdHistoric As RadioButton
    Friend WithEvents chkShort As CheckBox
    Friend WithEvents lblDept As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents chkRemote As CheckBox
    Friend WithEvents lblNoPrevious As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkSoundex As CheckBox
    Friend WithEvents rdNameDob As RadioButton
    Friend WithEvents rdDob As RadioButton
    Friend WithEvents rdChart As RadioButton
    Friend WithEvents rdName As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdAllc As RadioButton
    Friend WithEvents rdTc As RadioButton
    Friend WithEvents rdLc As RadioButton
    Friend WithEvents rdExact As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents nudRecords As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pBar As ProgressBar
    Friend WithEvents Chart As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents DateofBirth As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Ward As DataGridViewTextBoxColumn
    Friend WithEvents Clinician As DataGridViewTextBoxColumn
    Friend WithEvents Hospital As DataGridViewTextBoxColumn
    Friend WithEvents LabNo As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn

End Class
