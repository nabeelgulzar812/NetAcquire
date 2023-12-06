<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReagentLotNumberReportMalaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReagentLotNumberReportMalaria))
        DataGridView1 = New DataGridView()
        dtEntry = New DataGridViewTextBoxColumn()
        SampleID = New DataGridViewTextBoxColumn()
        LtNumber = New DataGridViewTextBoxColumn()
        Exp = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Button3 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox2 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox1 = New GroupBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
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
        DataGridView1.Location = New Point(46, 162)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(607, 328)
        DataGridView1.TabIndex = 40
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
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(446, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 39
        Label1.Text = "Exporting ...."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonFace
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.TopCenter
        Button3.Location = New Point(560, 41)
        Button3.Name = "Button3"
        Button3.Size = New Size(76, 83)
        Button3.TabIndex = 38
        Button3.Text = "&Cancel"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(458, 39)
        Button1.Name = "Button1"
        Button1.Size = New Size(76, 85)
        Button1.TabIndex = 37
        Button1.Text = "Export to Excel"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.TopCenter
        Button2.Location = New Point(362, 39)
        Button2.Name = "Button2"
        Button2.Size = New Size(71, 85)
        Button2.TabIndex = 36
        Button2.Text = "Calculate"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Location = New Point(208, 30)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(132, 104)
        GroupBox2.TabIndex = 35
        GroupBox2.TabStop = False
        GroupBox2.Text = "Parameters"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.FlatStyle = FlatStyle.Popup
        RadioButton2.Location = New Point(24, 62)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(73, 19)
        RadioButton2.TabIndex = 29
        RadioButton2.Text = "Sickledex"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Checked = True
        RadioButton1.FlatStyle = FlatStyle.Popup
        RadioButton1.Location = New Point(24, 42)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(63, 19)
        RadioButton1.TabIndex = 28
        RadioButton1.TabStop = True
        RadioButton1.Text = "Malaria"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackColor = Color.Transparent
        RadioButton3.FlatStyle = FlatStyle.Popup
        RadioButton3.Location = New Point(24, 22)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(79, 19)
        RadioButton3.TabIndex = 27
        RadioButton3.Text = "Monospot"
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Location = New Point(46, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(146, 104)
        GroupBox1.TabIndex = 34
        GroupBox1.TabStop = False
        GroupBox1.Text = "Between Dates"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Segoe UI", 9F, FontStyle.Bold)
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(16, 58)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(93, 23)
        DateTimePicker2.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 9F, FontStyle.Bold)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(16, 22)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(93, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' frmReagentLotNumberReportMalaria
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 574)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmReagentLotNumberReportMalaria"
        Text = "frmReagentLotNumberReportMalaria"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtEntry As DataGridViewTextBoxColumn
    Friend WithEvents SampleID As DataGridViewTextBoxColumn
    Friend WithEvents LtNumber As DataGridViewTextBoxColumn
    Friend WithEvents Exp As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
