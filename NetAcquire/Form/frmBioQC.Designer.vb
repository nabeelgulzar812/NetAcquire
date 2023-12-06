<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBioQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBioQC))
        rdUrine = New RadioButton()
        rdSerum = New RadioButton()
        ListBox1 = New ListBox()
        Label1 = New Label()
        lbControl = New ListBox()
        Panel1 = New Panel()
        nudPrevious = New NumericUpDown()
        dtTo = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        lbCode = New ListBox()
        Label4 = New Label()
        txtHigh = New TextBox()
        txtLow = New TextBox()
        Label5 = New Label()
        txtMean = New TextBox()
        Label6 = New Label()
        txt2SD = New TextBox()
        Label7 = New Label()
        btnCancel = New Button()
        GroupBox1 = New GroupBox()
        rdShowDM = New RadioButton()
        rdShowMean = New RadioButton()
        rdShowAll = New RadioButton()
        Label8 = New Label()
        lblDeleteParameter = New Label()
        lblDeleteTime = New Label()
        lblDeleteValue = New Label()
        Panel1.SuspendLayout()
        'CType(nudPrevious, ComponentModel.ISupportInitialize).BeginInit()
        'CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        'CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' rdUrine
        ' 
        rdUrine.AutoSize = True
        rdUrine.BackColor = SystemColors.ButtonFace
        rdUrine.CheckAlign = ContentAlignment.MiddleRight
        rdUrine.Location = New Point(66, 19)
        rdUrine.Name = "rdUrine"
        rdUrine.Size = New Size(53, 19)
        rdUrine.TabIndex = 5
        rdUrine.Text = "Urine"
        rdUrine.UseVisualStyleBackColor = False
        ' 
        ' rdSerum
        ' 
        rdSerum.AutoSize = True
        rdSerum.BackColor = SystemColors.ButtonFace
        rdSerum.CheckAlign = ContentAlignment.MiddleRight
        rdSerum.Checked = True
        rdSerum.FlatStyle = FlatStyle.Flat
        rdSerum.Location = New Point(7, 19)
        rdSerum.Name = "rdSerum"
        rdSerum.Size = New Size(58, 19)
        rdSerum.TabIndex = 4
        rdSerum.TabStop = True
        rdSerum.Text = "Serum"
        rdSerum.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(6, 60)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 484)
        ListBox1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Location = New Point(154, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 7
        Label1.Text = "Control"
        ' 
        ' lbControl
        ' 
        lbControl.FormattingEnabled = True
        lbControl.ItemHeight = 15
        lbControl.Location = New Point(154, 80)
        lbControl.Name = "lbControl"
        lbControl.Size = New Size(154, 19)
        lbControl.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(nudPrevious)
        Panel1.Controls.Add(dtTo)
        Panel1.Location = New Point(448, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(279, 33)
        Panel1.TabIndex = 9
        ' 
        ' nudPrevious
        ' 
        nudPrevious.Increment = New Decimal(New Integer() {30, 0, 0, 0})
        nudPrevious.Location = New Point(187, 5)
        nudPrevious.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        nudPrevious.Name = "nudPrevious"
        nudPrevious.Size = New Size(42, 23)
        nudPrevious.TabIndex = 1
        nudPrevious.TextAlign = HorizontalAlignment.Center
        nudPrevious.Value = New Decimal(New Integer() {30, 0, 0, 0})
        ' 
        ' dtTo
        ' 
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(14, 4)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(88, 23)
        dtTo.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(555, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 10
        Label2.Text = "and Previous"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(687, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 11
        Label3.Text = "days"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonFace
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(154, 117)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(573, 315)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonFace
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(154, 432)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(573, 51)
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' lbCode
        ' 
        lbCode.FormattingEnabled = True
        lbCode.ItemHeight = 15
        lbCode.Location = New Point(139, 189)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(47, 154)
        lbCode.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonFace
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(755, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 15
        Label4.Text = "High"
        ' 
        ' txtHigh
        ' 
        txtHigh.BorderStyle = BorderStyle.FixedSingle
        txtHigh.Font = New Font("Segoe UI", 8.25F)
        txtHigh.Location = New Point(734, 137)
        txtHigh.Name = "txtHigh"
        txtHigh.Size = New Size(70, 22)
        txtHigh.TabIndex = 16
        ' 
        ' txtLow
        ' 
        txtLow.BorderStyle = BorderStyle.FixedSingle
        txtLow.Font = New Font("Segoe UI", 8.25F)
        txtLow.Location = New Point(734, 405)
        txtLow.Name = "txtLow"
        txtLow.Size = New Size(70, 22)
        txtLow.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonFace
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(755, 386)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 17
        Label5.Text = "Low"
        ' 
        ' txtMean
        ' 
        txtMean.BorderStyle = BorderStyle.FixedSingle
        txtMean.Font = New Font("Segoe UI", 8.25F)
        txtMean.Location = New Point(734, 260)
        txtMean.Name = "txtMean"
        txtMean.Size = New Size(70, 22)
        txtMean.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonFace
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(755, 241)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 15)
        Label6.TabIndex = 19
        Label6.Text = "Mean"
        ' 
        ' txt2SD
        ' 
        txt2SD.BorderStyle = BorderStyle.FixedSingle
        txt2SD.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt2SD.Location = New Point(734, 460)
        txt2SD.Name = "txt2SD"
        txt2SD.Size = New Size(70, 22)
        txt2SD.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ButtonFace
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(755, 441)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 15)
        Label7.TabIndex = 21
        Label7.Text = "2 SD"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(734, 494)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 72)
        btnCancel.TabIndex = 23
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(rdShowDM)
        GroupBox1.Controls.Add(rdShowMean)
        GroupBox1.Controls.Add(rdShowAll)
        GroupBox1.Location = New Point(154, 494)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(197, 44)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Plot"
        ' 
        ' rdShowDM
        ' 
        rdShowDM.AutoSize = True
        rdShowDM.BackColor = Color.Transparent
        rdShowDM.Location = New Point(56, 17)
        rdShowDM.Name = "rdShowDM"
        rdShowDM.Size = New Size(84, 19)
        rdShowDM.TabIndex = 28
        rdShowDM.Text = "Daily Mean"
        rdShowDM.UseVisualStyleBackColor = False
        ' 
        ' rdShowMean
        ' 
        rdShowMean.AutoSize = True
        rdShowMean.BackColor = Color.Transparent
        rdShowMean.Location = New Point(144, 17)
        rdShowMean.Name = "rdShowMean"
        rdShowMean.Size = New Size(50, 19)
        rdShowMean.TabIndex = 27
        rdShowMean.Text = "Both"
        rdShowMean.UseVisualStyleBackColor = False
        ' 
        ' rdShowAll
        ' 
        rdShowAll.AutoSize = True
        rdShowAll.BackColor = Color.Transparent
        rdShowAll.Location = New Point(15, 17)
        rdShowAll.Name = "rdShowAll"
        rdShowAll.Size = New Size(39, 19)
        rdShowAll.TabIndex = 26
        rdShowAll.Text = "All"
        rdShowAll.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Cyan
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(372, 498)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 53)
        Label8.TabIndex = 26
        Label8.Text = "'<ALT>D' to delete"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDeleteParameter
        ' 
        lblDeleteParameter.BackColor = Color.Cyan
        lblDeleteParameter.BorderStyle = BorderStyle.FixedSingle
        lblDeleteParameter.Location = New Point(465, 511)
        lblDeleteParameter.Name = "lblDeleteParameter"
        lblDeleteParameter.Size = New Size(107, 17)
        lblDeleteParameter.TabIndex = 27
        lblDeleteParameter.Text = "lblDeleteParameter"
        lblDeleteParameter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDeleteTime
        ' 
        lblDeleteTime.BackColor = Color.Cyan
        lblDeleteTime.BorderStyle = BorderStyle.FixedSingle
        lblDeleteTime.Location = New Point(465, 529)
        lblDeleteTime.Name = "lblDeleteTime"
        lblDeleteTime.Size = New Size(107, 17)
        lblDeleteTime.TabIndex = 28
        lblDeleteTime.Text = "lblDeleteTime"
        lblDeleteTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDeleteValue
        ' 
        lblDeleteValue.BackColor = Color.Cyan
        lblDeleteValue.BorderStyle = BorderStyle.FixedSingle
        lblDeleteValue.Location = New Point(578, 511)
        lblDeleteValue.Name = "lblDeleteValue"
        lblDeleteValue.Size = New Size(107, 17)
        lblDeleteValue.TabIndex = 29
        lblDeleteValue.Text = "lblDeleteValue"
        lblDeleteValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' frmBioQC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(888, 578)
        Controls.Add(lblDeleteValue)
        Controls.Add(lblDeleteTime)
        Controls.Add(lblDeleteParameter)
        Controls.Add(Label8)
        Controls.Add(GroupBox1)
        Controls.Add(btnCancel)
        Controls.Add(txt2SD)
        Controls.Add(Label7)
        Controls.Add(txtMean)
        Controls.Add(Label6)
        Controls.Add(txtLow)
        Controls.Add(Label5)
        Controls.Add(txtHigh)
        Controls.Add(Label4)
        Controls.Add(lbCode)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(lbControl)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Controls.Add(rdUrine)
        Controls.Add(rdSerum)
        Name = "frmBioQC"
        Text = "frmBioQC"
        Panel1.ResumeLayout(False)
        'CType(nudPrevious, ComponentModel.ISupportInitialize).EndInit()
        'CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        'CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rdUrine As RadioButton
    Friend WithEvents rdSerum As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbControl As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents nudPrevious As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbCode As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHigh As TextBox
    Friend WithEvents txtLow As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMean As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt2SD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdShowDM As RadioButton
    Friend WithEvents rdShowMean As RadioButton
    Friend WithEvents rdShowAll As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDeleteParameter As Label
    Friend WithEvents lblDeleteTime As Label
    Friend WithEvents lblDeleteValue As Label
End Class
