
Partial Class frm_unfinished
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_unfinished))
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        dt = New DateTimePicker()
        GroupBox1 = New GroupBox()
        rdDept10 = New RadioButton()
        rdDept9 = New RadioButton()
        rdDept8 = New RadioButton()
        rdDept6 = New RadioButton()
        rdDept5 = New RadioButton()
        rdDept4 = New RadioButton()
        rdDept3 = New RadioButton()
        rdDept1 = New RadioButton()
        rdDept2 = New RadioButton()
        rdDept = New RadioButton()
        btnExit = New Button()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        'CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(12, 41)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(600, 618)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Sample of Numbers"
        Column1.Name = "Column1"
        Column1.Width = 130
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Outstanding"
        Column2.Name = "Column2"
        Column2.Width = 140
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Date"
        Column3.Name = "Column3"
        Column3.Width = 130
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonFace
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(616, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 35)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ButtonFace
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Location = New Point(664, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 45)
        Label1.TabIndex = 2
        Label1.Text = "Click Heading to Sort"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ButtonFace
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(639, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 45)
        Label2.TabIndex = 3
        Label2.Text = "View Samples dated later than"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dt
        ' 
        dt.CalendarTitleBackColor = SystemColors.ButtonFace
        dt.Format = DateTimePickerFormat.Short
        dt.Location = New Point(639, 154)
        dt.Name = "dt"
        dt.Size = New Size(115, 23)
        dt.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(rdDept10)
        GroupBox1.Controls.Add(rdDept9)
        GroupBox1.Controls.Add(rdDept8)
        GroupBox1.Controls.Add(rdDept6)
        GroupBox1.Controls.Add(rdDept5)
        GroupBox1.Controls.Add(rdDept4)
        GroupBox1.Controls.Add(rdDept3)
        GroupBox1.Controls.Add(rdDept1)
        GroupBox1.Controls.Add(rdDept2)
        GroupBox1.Controls.Add(rdDept)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Location = New Point(639, 183)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(115, 274)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        GroupBox1.Text = "Department"
        ' 
        ' rdDept10
        ' 
        rdDept10.AutoSize = True
        rdDept10.BackColor = SystemColors.ButtonFace
        rdDept10.FlatStyle = FlatStyle.Popup
        rdDept10.Location = New Point(18, 247)
        rdDept10.Name = "rdDept10"
        rdDept10.Size = New Size(67, 19)
        rdDept10.TabIndex = 35
        rdDept10.Text = "Red Sub"
        rdDept10.UseVisualStyleBackColor = False
        ' 
        ' rdDept9
        ' 
        rdDept9.AutoSize = True
        rdDept9.BackColor = SystemColors.ButtonFace
        rdDept9.FlatStyle = FlatStyle.Popup
        rdDept9.Location = New Point(18, 223)
        rdDept9.Name = "rdDept9"
        rdDept9.Size = New Size(54, 19)
        rdDept9.TabIndex = 34
        rdDept9.Text = "C && S"
        rdDept9.UseVisualStyleBackColor = False
        ' 
        ' rdDept8
        ' 
        rdDept8.AutoSize = True
        rdDept8.BackColor = SystemColors.ButtonFace
        rdDept8.FlatStyle = FlatStyle.Popup
        rdDept8.Location = New Point(18, 199)
        rdDept8.Name = "rdDept8"
        rdDept8.Size = New Size(96, 19)
        rdDept8.TabIndex = 33
        rdDept8.Text = "Ova/Parasites"
        rdDept8.UseVisualStyleBackColor = False
        ' 
        ' rdDept6
        ' 
        rdDept6.AutoSize = True
        rdDept6.BackColor = SystemColors.ButtonFace
        rdDept6.FlatStyle = FlatStyle.Popup
        rdDept6.Location = New Point(18, 175)
        rdDept6.Name = "rdDept6"
        rdDept6.Size = New Size(44, 19)
        rdDept6.TabIndex = 32
        rdDept6.Text = "CSF"
        rdDept6.UseVisualStyleBackColor = False
        ' 
        ' rdDept5
        ' 
        rdDept5.AutoSize = True
        rdDept5.BackColor = SystemColors.ButtonFace
        rdDept5.FlatStyle = FlatStyle.Popup
        rdDept5.Location = New Point(18, 151)
        rdDept5.Name = "rdDept5"
        rdDept5.Size = New Size(88, 19)
        rdDept5.TabIndex = 31
        rdDept5.Text = "Rota/Adeno"
        rdDept5.UseVisualStyleBackColor = False
        ' 
        ' rdDept4
        ' 
        rdDept4.AutoSize = True
        rdDept4.BackColor = SystemColors.ButtonFace
        rdDept4.FlatStyle = FlatStyle.Popup
        rdDept4.Location = New Point(18, 127)
        rdDept4.Name = "rdDept4"
        rdDept4.Size = New Size(52, 19)
        rdDept4.TabIndex = 30
        rdDept4.Text = "Urine"
        rdDept4.UseVisualStyleBackColor = False
        ' 
        ' rdDept3
        ' 
        rdDept3.AutoSize = True
        rdDept3.BackColor = SystemColors.ButtonFace
        rdDept3.FlatStyle = FlatStyle.Popup
        rdDept3.Location = New Point(18, 103)
        rdDept3.Name = "rdDept3"
        rdDept3.Size = New Size(59, 19)
        rdDept3.TabIndex = 29
        rdDept3.Text = "Faeces"
        rdDept3.UseVisualStyleBackColor = False
        ' 
        ' rdDept1
        ' 
        rdDept1.AutoSize = True
        rdDept1.BackColor = SystemColors.ButtonFace
        rdDept1.FlatStyle = FlatStyle.Popup
        rdDept1.Location = New Point(18, 55)
        rdDept1.Name = "rdDept1"
        rdDept1.Size = New Size(69, 19)
        rdDept1.TabIndex = 28
        rdDept1.Text = "H. Pylori"
        rdDept1.UseVisualStyleBackColor = False
        ' 
        ' rdDept2
        ' 
        rdDept2.AutoSize = True
        rdDept2.BackColor = SystemColors.ButtonFace
        rdDept2.FlatStyle = FlatStyle.Popup
        rdDept2.Location = New Point(18, 79)
        rdDept2.Name = "rdDept2"
        rdDept2.Size = New Size(55, 19)
        rdDept2.TabIndex = 27
        rdDept2.Text = "c. Diff"
        rdDept2.UseVisualStyleBackColor = False
        ' 
        ' rdDept
        ' 
        rdDept.AutoSize = True
        rdDept.BackColor = SystemColors.ButtonFace
        rdDept.Checked = True
        rdDept.FlatStyle = FlatStyle.Popup
        rdDept.Location = New Point(18, 31)
        rdDept.Name = "rdDept"
        rdDept.Size = New Size(38, 19)
        rdDept.TabIndex = 26
        rdDept.TabStop = True
        rdDept.Text = "All"
        rdDept.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ButtonFace
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(650, 559)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(76, 72)
        btnExit.TabIndex = 27
        btnExit.Text = "Exit"
        btnExit.TextAlign = ContentAlignment.BottomCenter
        btnExit.TextImageRelation = TextImageRelation.ImageAboveText
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frm_unfinished
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(768, 785)
        Controls.Add(btnExit)
        Controls.Add(GroupBox1)
        Controls.Add(dt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        ForeColor = SystemColors.ControlText
        Name = "frm_unfinished"
        Text = "frm_unfinished"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        'CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdDept1 As RadioButton
    Friend WithEvents rdDept2 As RadioButton
    Friend WithEvents rdDept As RadioButton
    Friend WithEvents rdDept10 As RadioButton
    Friend WithEvents rdDept9 As RadioButton
    Friend WithEvents rdDept8 As RadioButton
    Friend WithEvents rdDept6 As RadioButton
    Friend WithEvents rdDept5 As RadioButton
    Friend WithEvents rdDept4 As RadioButton
    Friend WithEvents rdDept3 As RadioButton
    Friend WithEvents btnExit As Button
End Class
