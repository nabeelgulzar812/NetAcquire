<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreatClearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreatClearance))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        SerumCreatinineToolStripMenuItem = New ToolStripMenuItem()
        UrineCreatinineToolStripMenuItem = New ToolStripMenuItem()
        UrineProtienToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        btnSearch = New Button()
        Label4 = New Label()
        txtVolume = New TextBox()
        Label3 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        dtTo = New DateTimePicker()
        dtFrom = New DateTimePicker()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label5 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        'Me.btnViewScan = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label26 = New Label()
        ' Me.lDob = New Label()
        'Me.lChart = New Label()
        'Me.lname = New Label()
        lblSerumSID = New Label()
        ' Me.lserumdate = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label18 = New Label()
        Panel4 = New Panel()
        Button5 = New Button()
        Label27 = New Label()
        lDob1 = New Label()
        lChart1 = New Label()
        lName1 = New Label()
        lblUrineSID = New Label()
        lurinedate = New Label()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Button8 = New Button()
        'lsc = New Label()
        'lup = New Label()
        ' lupc = New Label()
        'lcc = New Label()
        ' luc = New Label()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, OptionsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1071, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(93, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SerumCreatinineToolStripMenuItem, UrineCreatinineToolStripMenuItem, UrineProtienToolStripMenuItem})
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(61, 20)
        OptionsToolStripMenuItem.Text = "&Options"
        ' 
        ' SerumCreatinineToolStripMenuItem
        ' 
        SerumCreatinineToolStripMenuItem.Name = "SerumCreatinineToolStripMenuItem"
        SerumCreatinineToolStripMenuItem.Size = New Size(165, 22)
        SerumCreatinineToolStripMenuItem.Text = "Serum Creatinine"
        ' 
        ' UrineCreatinineToolStripMenuItem
        ' 
        UrineCreatinineToolStripMenuItem.Name = "UrineCreatinineToolStripMenuItem"
        UrineCreatinineToolStripMenuItem.Size = New Size(165, 22)
        UrineCreatinineToolStripMenuItem.Text = "Urine Creatinine"
        ' 
        ' UrineProtienToolStripMenuItem
        ' 
        UrineProtienToolStripMenuItem.Name = "UrineProtienToolStripMenuItem"
        UrineProtienToolStripMenuItem.Size = New Size(165, 22)
        UrineProtienToolStripMenuItem.Text = "Urine Protien"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtVolume)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dtTo)
        Panel1.Controls.Add(dtFrom)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(56, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(475, 164)
        Panel1.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(345, 39)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 34)
        btnSearch.TabIndex = 8
        btnSearch.Text = "&Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(211, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 15)
        Label4.TabIndex = 7
        Label4.Text = "mL"
        ' 
        ' txtVolume
        ' 
        txtVolume.BorderStyle = BorderStyle.FixedSingle
        txtVolume.Location = New Point(111, 108)
        txtVolume.Name = "txtVolume"
        txtVolume.Size = New Size(96, 23)
        txtVolume.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 5
        Label3.Text = "To Urinary Volume"
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(111, 65)
        txtName.Name = "txtName"
        txtName.Size = New Size(149, 23)
        txtName.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 3
        Label2.Text = "Patient Name"
        ' 
        ' dtTo
        ' 
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(207, 29)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(89, 23)
        dtTo.TabIndex = 2
        ' 
        ' dtFrom
        ' 
        dtFrom.Format = DateTimePickerFormat.Short
        dtFrom.Location = New Point(111, 29)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(89, 23)
        dtFrom.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 15)
        Label1.TabIndex = 0
        Label1.Text = "Run Dates Between"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(56, 248)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(475, 159)
        DataGridView1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ' Panel2.Controls.Add(luc)
        ' Panel2.Controls.Add(lcc)
        ' Panel2.Controls.Add(lupc)
        ' Panel2.Controls.Add(lup)
        ' Panel2.Controls.Add(lsc)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(56, 410)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(475, 208)
        Panel2.TabIndex = 9
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(286, 139)
        Label14.Name = "Label14"
        Label14.Size = New Size(50, 15)
        Label14.TabIndex = 17
        Label14.Text = "mL/min"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(286, 110)
        Label13.Name = "Label13"
        Label13.Size = New Size(44, 15)
        Label13.TabIndex = 16
        Label13.Text = "g/24Hr"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(286, 85)
        Label12.Name = "Label12"
        Label12.Size = New Size(25, 15)
        Label12.TabIndex = 15
        Label12.Text = "g/L"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(286, 64)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 15)
        Label11.TabIndex = 14
        Label11.Text = "umol/L"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(286, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 13
        Label5.Text = "umol/L"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(74, 112)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 15)
        Label10.TabIndex = 9
        Label10.Text = "Urinary Protein"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(62, 138)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 15)
        Label9.TabIndex = 8
        Label9.Text = "Creatinine Clearance"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(74, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 5
        Label6.Text = "Urinary Protein"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(74, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 15)
        Label7.TabIndex = 3
        Label7.Text = "Urine Creatinine"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(72, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 15)
        Label8.TabIndex = 0
        Label8.Text = "Serum Creatinine"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        'Panel3.Controls.Add(Me.btnViewScan)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Label26)
        'Panel3.Controls.Add(Me.lDob)
        ' Panel3.Controls.Add(Me.lChart)
        ' Panel3.Controls.Add(Me.lname)
        'Panel3.Controls.Add(lblSerumSID)
        'Panel3.Controls.Add(Me.lserumdate)
        Panel3.Controls.Add(Label20)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label18)
        Panel3.Location = New Point(557, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(388, 235)
        Panel3.TabIndex = 9
        ' 
        ' btnViewScan
        ' 
        ' Me.btnViewScan.FlatStyle = FlatStyle.System
        ' Me.btnViewScan.Location = New Point(302, 165)
        '  Me.btnViewScan.Name = "btnViewScan"
        ' Me.btnViewScan.Size = New Size(58, 69)
        ' Me.btnViewScan.TabIndex = 33
        ' Me.btnViewScan.Text = " &View Scan"
        ' Me.btnViewScan.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.System
        Button3.Location = New Point(299, 92)
        Button3.Name = "Button3"
        Button3.Size = New Size(58, 57)
        Button3.TabIndex = 32
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.System
        Button2.Location = New Point(235, 92)
        Button2.Name = "Button2"
        Button2.Size = New Size(58, 57)
        Button2.TabIndex = 31
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label26
        ' 
        Label26.BackColor = SystemColors.ButtonFace
        Label26.Location = New Point(94, 152)
        Label26.Name = "Label26"
        Label26.Size = New Size(277, 13)
        Label26.TabIndex = 30
        ' 
        ' lDob
        ' 
        ' Me.lDob.BackColor = SystemColors.ButtonFace
        'Me.lDob.Location = New Point(94, 126)
        ' Me.lDob.Name = "lDob"
        ' Me.lDob.Size = New Size(117, 16)
        ' Me.lDob.TabIndex = 29
        ' 
        ' lChart
        ' 
        ' Me.lChart.BackColor = SystemColors.ButtonFace
        ' Me.lChart.Location = New Point(94, 95)
        '  Me.lChart.Name = "lChart"
        '  Me.lChart.Size = New Size(117, 16)
        ' Me.lChart.TabIndex = 28
        ' 
        ' lname
        ' 
        ' Me.lname.BackColor = SystemColors.ButtonFace
        ' Me.lname.Location = New Point(94, 63)
        ' Me.lname.Name = "lname"
        ' Me.lname.Size = New Size(277, 18)
        'Me.lname.TabIndex = 27
        ' 
        ' lblSerumSID
        ' 
        lblSerumSID.BackColor = SystemColors.ButtonFace
        lblSerumSID.Location = New Point(272, 35)
        lblSerumSID.Name = "lblSerumSID"
        lblSerumSID.Size = New Size(100, 17)
        lblSerumSID.TabIndex = 26
        ' 
        ' lserumdate
        ' 
        ' Me.lserumdate.BackColor = SystemColors.ButtonFace
        ' Me.lserumdate.Location = New Point(94, 35)
        ' Me.lserumdate.Name = "lserumdate"
        ' Me.lserumdate.Size = New Size(100, 16)
        ' Me.lserumdate.TabIndex = 25
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(35, 127)
        Label20.Name = "Label20"
        Label20.Size = New Size(29, 15)
        Label20.TabIndex = 24
        Label20.Text = "DoB"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(32, 96)
        Label19.Name = "Label19"
        Label19.Size = New Size(36, 15)
        Label19.TabIndex = 23
        Label19.Text = "Chart"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(29, 64)
        Label17.Name = "Label17"
        Label17.Size = New Size(39, 15)
        Label17.TabIndex = 21
        Label17.Text = "Name"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(217, 37)
        Label16.Name = "Label16"
        Label16.Size = New Size(24, 15)
        Label16.TabIndex = 19
        Label16.Text = "SID"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(27, 35)
        Label15.Name = "Label15"
        Label15.Size = New Size(55, 15)
        Label15.TabIndex = 1
        Label15.Text = "Run Date"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(27, -1)
        Label18.Name = "Label18"
        Label18.Size = New Size(79, 15)
        Label18.TabIndex = 0
        Label18.Text = "Serum Details"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Silver
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(Label27)
        Panel4.Controls.Add(lDob1)
        Panel4.Controls.Add(lChart1)
        Panel4.Controls.Add(lName1)
        Panel4.Controls.Add(lblUrineSID)
        Panel4.Controls.Add(lurinedate)
        Panel4.Controls.Add(Label33)
        Panel4.Controls.Add(Label34)
        Panel4.Controls.Add(Label35)
        Panel4.Controls.Add(Label36)
        Panel4.Controls.Add(Label37)
        Panel4.Controls.Add(Label38)
        Panel4.Location = New Point(556, 319)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(388, 245)
        Panel4.TabIndex = 34
        ' 
        ' Button5
        ' 
        Button5.FlatStyle = FlatStyle.System
        Button5.Location = New Point(314, 168)
        Button5.Name = "Button5"
        Button5.Size = New Size(58, 69)
        Button5.TabIndex = 34
        Button5.Text = "&View Scan"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label27
        ' 
        Label27.BackColor = SystemColors.ButtonFace
        Label27.Location = New Point(94, 152)
        Label27.Name = "Label27"
        Label27.Size = New Size(277, 13)
        Label27.TabIndex = 30
        ' 
        ' lDob1
        ' 
        lDob1.BackColor = SystemColors.ButtonFace
        lDob1.Location = New Point(94, 126)
        lDob1.Name = "lDob1"
        lDob1.Size = New Size(117, 16)
        lDob1.TabIndex = 29
        ' 
        ' lChart1
        ' 
        lChart1.BackColor = SystemColors.ButtonFace
        lChart1.Location = New Point(94, 95)
        lChart1.Name = "lChart1"
        lChart1.Size = New Size(117, 16)
        lChart1.TabIndex = 28
        ' 
        ' lName1
        ' 
        lName1.BackColor = SystemColors.ButtonFace
        lName1.Location = New Point(94, 63)
        lName1.Name = "lName1"
        lName1.Size = New Size(277, 18)
        lName1.TabIndex = 27
        ' 
        ' lblUrineSID
        ' 
        lblUrineSID.BackColor = SystemColors.ButtonFace
        lblUrineSID.Location = New Point(272, 35)
        lblUrineSID.Name = "lblUrineSID"
        lblUrineSID.Size = New Size(100, 17)
        lblUrineSID.TabIndex = 26
        ' 
        ' lurinedate
        ' 
        lurinedate.BackColor = SystemColors.ButtonFace
        lurinedate.Location = New Point(94, 35)
        lurinedate.Name = "lurinedate"
        lurinedate.Size = New Size(100, 16)
        lurinedate.TabIndex = 25
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(35, 127)
        Label33.Name = "Label33"
        Label33.Size = New Size(29, 15)
        Label33.TabIndex = 24
        Label33.Text = "DoB"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(32, 96)
        Label34.Name = "Label34"
        Label34.Size = New Size(36, 15)
        Label34.TabIndex = 23
        Label34.Text = "Chart"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Location = New Point(29, 64)
        Label35.Name = "Label35"
        Label35.Size = New Size(39, 15)
        Label35.TabIndex = 21
        Label35.Text = "Name"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(217, 37)
        Label36.Name = "Label36"
        Label36.Size = New Size(24, 15)
        Label36.TabIndex = 19
        Label36.Text = "SID"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(27, 35)
        Label37.Name = "Label37"
        Label37.Size = New Size(55, 15)
        Label37.TabIndex = 1
        Label37.Text = "Run Date"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Location = New Point(27, -1)
        Label38.Name = "Label38"
        Label38.Size = New Size(73, 15)
        Label38.TabIndex = 0
        Label38.Text = "Urine Details"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.BackColor = SystemColors.ButtonFace
        Label39.Location = New Point(851, 576)
        Label39.Name = "Label39"
        Label39.Size = New Size(82, 15)
        Label39.TabIndex = 35
        Label39.Text = "Print Urine >>"
        ' 
        ' Button8
        ' 
        Button8.BackColor = SystemColors.ButtonFace
        Button8.BackgroundImageLayout = ImageLayout.None
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.TopCenter
        Button8.Location = New Point(690, 570)
        Button8.Name = "Button8"
        Button8.Size = New Size(123, 72)
        Button8.TabIndex = 36
        Button8.Text = "&Cancel"
        Button8.TextAlign = ContentAlignment.BottomCenter
        Button8.TextImageRelation = TextImageRelation.ImageAboveText
        Button8.UseVisualStyleBackColor = False
        ' 
        ' lsc
        ' 
        'lsc.BackColor = SystemColors.ButtonFace
        'lsc.Location = New Point(196, 36)
        '  lsc.Name = "lsc"
        ' lsc.Size = New Size(64, 16)
        '  lsc.TabIndex = 34
        ' ' 
        ' lup
        ' 
        ' lup.BackColor = SystemColors.ButtonFace
        'lup.Location = New Point(196, 86)
        'lup.Name = "lup"
        ' lup.Size = New Size(64, 16)
        ' lup.TabIndex = 35
        ' 
        ' lupc
        ' 
        'lupc.BackColor = SystemColors.ButtonFace
        'lupc.Location = New Point(196, 111)
        'lupc.Name = "lupc"
        ' lupc.Size = New Size(64, 16)
        ' lupc.TabIndex = 36
        ' 
        ' lcc
        ' 
        ' lcc.BackColor = SystemColors.ButtonFace
        ' lcc.Location = New Point(196, 136)
        'lcc.Name = "lcc"
        ' lcc.Size = New Size(64, 16)
        ' lcc.TabIndex = 37
        ' 
        ' luc
        ' 
        '  luc.BackColor = SystemColors.ButtonFace
        ' luc.Location = New Point(196, 61)
        'luc.Name = "luc"
        'luc.Size = New Size(64, 16)
        ' luc.TabIndex = 39
        ' 
        ' frmCreatClearance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1071, 684)
        Controls.Add(Button8)
        Controls.Add(Label39)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmCreatClearance"
        Text = "frmCreatClearance"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerumCreatinineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UrineCreatinineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UrineProtienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lcc As TextBox
    Friend WithEvents lupc As TextBox
    Friend WithEvents lup As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents luc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lsc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblSerumSID As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents lDob1 As Label
    Friend WithEvents lChart1 As Label
    Friend WithEvents lName1 As Label
    Friend WithEvents lblUrineSID As Label
    Friend WithEvents lurinedate As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Button8 As Button
    ' Friend WithEvents luc As Label
    'Friend WithEvents lcc As Label
    ' Friend WithEvents lupc As Label
    ' Friend WithEvents lup As Label
    ' Friend WithEvents lsc As Label
End Class
