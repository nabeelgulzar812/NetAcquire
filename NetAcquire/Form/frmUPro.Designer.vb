
Partial Class frmUPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUPro))
        Label1 = New Label()
        dtFrom = New DateTimePicker()
        dtTo = New DateTimePicker()
        Label2 = New Label()
        txtName = New TextBox()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        btnPrint11 = New Button()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label5 = New Label()
        Label10 = New Label()
        'Me.txtVolume = New TextBox()
        Label6 = New Label()
        txtHours = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        btnCancel = New Button()
        btnSearch = New Button()
        Panel3 = New Panel()
        Label26 = New Label()
        lblDob = New Label()
        lblChart = New Label()
        lblName = New Label()
        lblSID = New Label()
        lblRunDate = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label18 = New Label()
        btnViewScan = New Button()
        lblUPro = New Label()
        lblUPro24 = New Label()
        Panel1.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
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
        ' dtFrom
        ' 
        dtFrom.Format = DateTimePickerFormat.Short
        dtFrom.Location = New Point(126, 29)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(89, 23)
        dtFrom.TabIndex = 1
        ' 
        ' dtTo
        ' 
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(222, 29)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(89, 23)
        dtTo.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 3
        Label2.Text = "Patient Name"
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(125, 65)
        txtName.Name = "txtName"
        txtName.Size = New Size(185, 23)
        txtName.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dtTo)
        Panel1.Controls.Add(dtFrom)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(396, 113)
        Panel1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(15, 149)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(393, 159)
        DataGridView1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonFace
        Panel2.Controls.Add(lblUPro24)
        Panel2.Controls.Add(lblUPro)
        Panel2.Controls.Add(btnPrint11)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label10)
        ' Panel2.Controls.Add(Me.txtVolume)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txtHours)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(15, 320)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(393, 157)
        Panel2.TabIndex = 10
        ' 
        ' btnPrint11
        ' 
        btnPrint11.BackColor = SystemColors.ButtonFace
        btnPrint11.BackgroundImageLayout = ImageLayout.None
        btnPrint11.ImageAlign = ContentAlignment.TopCenter
        btnPrint11.Location = New Point(289, 37)
        btnPrint11.Name = "btnPrint11"
        btnPrint11.Size = New Size(76, 83)
        btnPrint11.TabIndex = 38
        btnPrint11.Text = "&Print"
        btnPrint11.TextImageRelation = TextImageRelation.ImageAboveText
        btnPrint11.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(213, 125)
        Label13.Name = "Label13"
        Label13.Size = New Size(44, 15)
        Label13.TabIndex = 16
        Label13.Text = "g/24Hr"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(213, 97)
        Label12.Name = "Label12"
        Label12.Size = New Size(25, 15)
        Label12.TabIndex = 15
        Label12.Text = "g/L"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(213, 64)
        Label11.Name = "Label11"
        Label11.Size = New Size(24, 15)
        Label11.TabIndex = 14
        Label11.Text = "mL"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(213, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 13
        Label5.Text = "Hours"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(14, 127)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 15)
        Label10.TabIndex = 9
        Label10.Text = "Urinary Protein"
        ' 
        ' txtVolume
        ' 
        ' Me.txtVolume.BackColor = SystemColors.Window
        ' Me.txtVolume.BorderStyle = BorderStyle.FixedSingle
        ' Me.txtVolume.Location = New Point(126, 62)
        ' Me.txtVolume.Name = "txtVolume"
        ' Me.txtVolume.Size = New Size(71, 23)
        ' Me.txtVolume.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 5
        Label6.Text = "Urinary Protein"
        ' 
        ' txtHours
        ' 
        txtHours.BackColor = SystemColors.Window
        txtHours.BorderStyle = BorderStyle.FixedSingle
        txtHours.Location = New Point(126, 34)
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(71, 23)
        txtHours.TabIndex = 4
        txtHours.Text = "24"
        txtHours.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 15)
        Label7.TabIndex = 3
        Label7.Text = "Total Urinary Volume"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 15)
        Label8.TabIndex = 0
        Label8.Text = "Collection Period"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(547, 394)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(105, 77)
        btnCancel.TabIndex = 36
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.ButtonFace
        btnSearch.BackgroundImageLayout = ImageLayout.None
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.Location = New Point(593, 43)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(105, 71)
        btnSearch.TabIndex = 37
        btnSearch.Text = "&Search"
        btnSearch.TextAlign = ContentAlignment.BottomCenter
        btnSearch.TextImageRelation = TextImageRelation.ImageAboveText
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ScrollBar
        Panel3.Controls.Add(Label26)
        Panel3.Controls.Add(lblDob)
        Panel3.Controls.Add(lblChart)
        Panel3.Controls.Add(lblName)
        Panel3.Controls.Add(lblSID)
        Panel3.Controls.Add(lblRunDate)
        Panel3.Controls.Add(Label20)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label18)
        Panel3.Location = New Point(441, 149)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(388, 179)
        Panel3.TabIndex = 38
        ' 
        ' Label26
        ' 
        Label26.BackColor = SystemColors.ButtonFace
        Label26.Location = New Point(94, 146)
        Label26.Name = "Label26"
        Label26.Size = New Size(277, 13)
        Label26.TabIndex = 30
        ' 
        ' lblDob
        ' 
        lblDob.BackColor = SystemColors.ButtonFace
        lblDob.Location = New Point(94, 126)
        lblDob.Name = "lblDob"
        lblDob.Size = New Size(117, 16)
        lblDob.TabIndex = 29
        ' 
        ' lblChart
        ' 
        lblChart.BackColor = SystemColors.ButtonFace
        lblChart.Location = New Point(94, 95)
        lblChart.Name = "lblChart"
        lblChart.Size = New Size(117, 16)
        lblChart.TabIndex = 28
        ' 
        ' lblName
        ' 
        lblName.BackColor = SystemColors.ButtonFace
        lblName.Location = New Point(94, 63)
        lblName.Name = "lblName"
        lblName.Size = New Size(277, 18)
        lblName.TabIndex = 27
        ' 
        ' lblSID
        ' 
        lblSID.BackColor = SystemColors.ButtonFace
        lblSID.Location = New Point(272, 35)
        lblSID.Name = "lblSID"
        lblSID.Size = New Size(100, 17)
        lblSID.TabIndex = 26
        ' 
        ' lblRunDate
        ' 
        lblRunDate.BackColor = SystemColors.ButtonFace
        lblRunDate.Location = New Point(94, 35)
        lblRunDate.Name = "lblRunDate"
        lblRunDate.Size = New Size(100, 16)
        lblRunDate.TabIndex = 25
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
        Label18.Location = New Point(27, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(117, 15)
        Label18.TabIndex = 0
        Label18.Text = "Demographic Details"
        ' 
        ' btnViewScan
        ' 
        btnViewScan.FlatStyle = FlatStyle.System
        btnViewScan.Location = New Point(762, 346)
        btnViewScan.Name = "btnViewScan"
        btnViewScan.Size = New Size(67, 86)
        btnViewScan.TabIndex = 33
        btnViewScan.Text = " &View Scan"
        btnViewScan.UseVisualStyleBackColor = True
        ' 
        ' lblUPro
        ' 
        lblUPro.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblUPro.Location = New Point(126, 97)
        lblUPro.Name = "lblUPro"
        lblUPro.Size = New Size(71, 21)
        lblUPro.TabIndex = 31
        ' 
        ' lblUPro24
        ' 
        lblUPro24.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblUPro24.Location = New Point(123, 125)
        lblUPro24.Name = "lblUPro24"
        lblUPro24.Size = New Size(74, 21)
        lblUPro24.TabIndex = 39
        ' 
        ' frmUPro
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(961, 610)
        Controls.Add(btnViewScan)
        Controls.Add(Panel3)
        Controls.Add(btnSearch)
        Controls.Add(btnCancel)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "frmUPro"
        Text = "frmUPro"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint11 As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblDob As Label
    Friend WithEvents lblChart As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSID As Label
    Friend WithEvents lblRunDate As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnViewScan As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents lblUPro24 As Label
    Friend WithEvents lblUPro As Label
End Class
