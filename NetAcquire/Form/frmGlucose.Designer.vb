
Partial Class frmGlucose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGlucose))
        Panel1 = New Panel()
        Label1 = New Label()
        dtRun = New DateTimePicker()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        Panel3 = New Panel()
        Label18 = New Label()
        Label19 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label14 = New Label()
        lGp = New Label()
        Label13 = New Label()
        lWard = New Label()
        Label11 = New Label()
        lblClinician = New Label()
        Label9 = New Label()
        lAdd2 = New Label()
        Label7 = New Label()
        lAdd1 = New Label()
        Label4 = New Label()
        lDob = New Label()
        Label2 = New Label()
        lChart = New Label()
        Label15 = New Label()
        btnViewScan = New Button()
        btnPrintGTTReport = New Button()
        ProgressBar1 = New ProgressBar()
        btnGlucoseSeries = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        'CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(dtRun)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(25, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 235)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(306, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 2
        Label1.Text = "Run Date"
        ' 
        ' dtRun
        ' 
        dtRun.Format = DateTimePickerFormat.Short
        dtRun.Location = New Point(293, 76)
        dtRun.Name = "dtRun"
        dtRun.Size = New Size(86, 23)
        dtRun.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(22, 18)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 168)
        DataGridView1.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(113, 300)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(336, 192)
        DataGridView2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(lGp)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(lWard)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(lblClinician)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lAdd2)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(lAdd1)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(lDob)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(lChart)
        Panel3.Controls.Add(Label15)
        Panel3.Location = New Point(463, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(388, 235)
        Panel3.TabIndex = 10
        ' 
        ' Label18
        ' 
        Label18.BackColor = SystemColors.ButtonFace
        Label18.BorderStyle = BorderStyle.FixedSingle
        Label18.FlatStyle = FlatStyle.Flat
        Label18.Location = New Point(328, 54)
        Label18.Name = "Label18"
        Label18.Size = New Size(54, 16)
        Label18.TabIndex = 42
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(296, 54)
        Label19.Name = "Label19"
        Label19.Size = New Size(25, 15)
        Label19.TabIndex = 41
        Label19.Text = "Sex"
        ' 
        ' Label16
        ' 
        Label16.BackColor = SystemColors.ButtonFace
        Label16.BorderStyle = BorderStyle.FixedSingle
        Label16.FlatStyle = FlatStyle.Flat
        Label16.Location = New Point(234, 54)
        Label16.Name = "Label16"
        Label16.Size = New Size(54, 16)
        Label16.TabIndex = 40
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(198, 53)
        Label17.Name = "Label17"
        Label17.Size = New Size(28, 15)
        Label17.TabIndex = 39
        Label17.Text = "Age"
        ' 
        ' Label14
        ' 
        Label14.BackColor = SystemColors.ButtonFace
        Label14.BorderStyle = BorderStyle.FixedSingle
        Label14.FlatStyle = FlatStyle.Popup
        Label14.Location = New Point(101, 202)
        Label14.Name = "Label14"
        Label14.Size = New Size(89, 16)
        Label14.TabIndex = 38
        ' 
        ' lGp
        ' 
        lGp.BackColor = SystemColors.ButtonFace
        lGp.BorderStyle = BorderStyle.FixedSingle
        lGp.FlatStyle = FlatStyle.Popup
        lGp.Location = New Point(101, 172)
        lGp.Name = "lGp"
        lGp.Size = New Size(263, 16)
        lGp.TabIndex = 37
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(60, 173)
        Label13.Name = "Label13"
        Label13.Size = New Size(25, 15)
        Label13.TabIndex = 36
        Label13.Text = "G.P"
        ' 
        ' lWard
        ' 
        lWard.BackColor = SystemColors.ButtonFace
        lWard.BorderStyle = BorderStyle.FixedSingle
        lWard.FlatStyle = FlatStyle.Popup
        lWard.Location = New Point(101, 145)
        lWard.Name = "lWard"
        lWard.Size = New Size(263, 16)
        lWard.TabIndex = 35
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(60, 146)
        Label11.Name = "Label11"
        Label11.Size = New Size(35, 15)
        Label11.TabIndex = 34
        Label11.Text = "Ward"
        ' 
        ' lblClinician
        ' 
        lblClinician.BackColor = SystemColors.ButtonFace
        lblClinician.BorderStyle = BorderStyle.FixedSingle
        lblClinician.FlatStyle = FlatStyle.Popup
        lblClinician.Location = New Point(101, 120)
        lblClinician.Name = "lblClinician"
        lblClinician.Size = New Size(263, 16)
        lblClinician.TabIndex = 33
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(34, 118)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 15)
        Label9.TabIndex = 32
        Label9.Text = "Consultant"
        ' 
        ' lAdd2
        ' 
        lAdd2.BackColor = SystemColors.ButtonFace
        lAdd2.BorderStyle = BorderStyle.FixedSingle
        lAdd2.FlatStyle = FlatStyle.Popup
        lAdd2.Location = New Point(101, 93)
        lAdd2.Name = "lAdd2"
        lAdd2.Size = New Size(263, 16)
        lAdd2.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(60, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 30
        Label7.Text = "Addr2"
        ' 
        ' lAdd1
        ' 
        lAdd1.BackColor = SystemColors.ButtonFace
        lAdd1.BorderStyle = BorderStyle.FixedSingle
        lAdd1.FlatStyle = FlatStyle.Popup
        lAdd1.Location = New Point(101, 74)
        lAdd1.Name = "lAdd1"
        lAdd1.Size = New Size(263, 16)
        lAdd1.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(60, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 28
        Label4.Text = "Addr1"
        ' 
        ' lDob
        ' 
        lDob.BackColor = SystemColors.ButtonFace
        lDob.BorderStyle = BorderStyle.FixedSingle
        lDob.FlatStyle = FlatStyle.Flat
        lDob.Location = New Point(101, 54)
        lDob.Name = "lDob"
        lDob.Size = New Size(89, 16)
        lDob.TabIndex = 27
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 26
        Label2.Text = "D.o.B"
        ' 
        ' lChart
        ' 
        lChart.BackColor = SystemColors.ButtonFace
        lChart.BorderStyle = BorderStyle.FixedSingle
        lChart.FlatStyle = FlatStyle.Popup
        lChart.Location = New Point(101, 35)
        lChart.Name = "lChart"
        lChart.Size = New Size(89, 16)
        lChart.TabIndex = 25
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(12, 35)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 15)
        Label15.TabIndex = 1
        Label15.Text = "Chart Number"
        ' 
        ' btnViewScan
        ' 
        btnViewScan.FlatStyle = FlatStyle.Popup
        btnViewScan.Image = CType(resources.GetObject("btnViewScan.Image"), Image)
        btnViewScan.Location = New Point(778, 278)
        btnViewScan.Name = "btnViewScan"
        btnViewScan.Size = New Size(71, 88)
        btnViewScan.TabIndex = 34
        btnViewScan.Text = " &View Scan"
        btnViewScan.TextAlign = ContentAlignment.BottomCenter
        btnViewScan.UseVisualStyleBackColor = True
        ' 
        ' btnPrintGTTReport
        ' 
        btnPrintGTTReport.BackColor = SystemColors.ButtonFace
        btnPrintGTTReport.FlatStyle = FlatStyle.Popup
        btnPrintGTTReport.Image = CType(resources.GetObject("btnPrintGTTReport.Image"), Image)
        btnPrintGTTReport.ImageAlign = ContentAlignment.TopCenter
        btnPrintGTTReport.Location = New Point(523, 316)
        btnPrintGTTReport.Name = "btnPrintGTTReport"
        btnPrintGTTReport.Size = New Size(98, 91)
        btnPrintGTTReport.TabIndex = 35
        btnPrintGTTReport.Text = "&Print as GTT Report"
        btnPrintGTTReport.TextAlign = ContentAlignment.BottomCenter
        btnPrintGTTReport.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(60, 268)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(389, 10)
        ProgressBar1.TabIndex = 38
        ' 
        ' btnGlucoseSeries
        ' 
        btnGlucoseSeries.BackColor = SystemColors.ButtonFace
        btnGlucoseSeries.FlatStyle = FlatStyle.Popup
        btnGlucoseSeries.Image = CType(resources.GetObject("btnGlucoseSeries.Image"), Image)
        btnGlucoseSeries.ImageAlign = ContentAlignment.TopCenter
        btnGlucoseSeries.Location = New Point(523, 413)
        btnGlucoseSeries.Name = "btnGlucoseSeries"
        btnGlucoseSeries.Size = New Size(98, 91)
        btnGlucoseSeries.TabIndex = 39
        btnGlucoseSeries.Text = "&Print as Glucose Series"
        btnGlucoseSeries.TextAlign = ContentAlignment.BottomCenter
        btnGlucoseSeries.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(773, 417)
        Button1.Name = "Button1"
        Button1.Size = New Size(76, 71)
        Button1.TabIndex = 40
        Button1.Text = "&Cancel"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmGlucose
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1094, 552)
        Controls.Add(Button1)
        Controls.Add(btnGlucoseSeries)
        Controls.Add(ProgressBar1)
        Controls.Add(btnPrintGTTReport)
        Controls.Add(btnViewScan)
        Controls.Add(Panel3)
        Controls.Add(DataGridView2)
        Controls.Add(Panel1)
        Name = "frmGlucose"
        Text = "frmGlucose"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        'CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtRun As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lAdd2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lAdd1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lDob As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lChart As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lGp As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lWard As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblClinician As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnViewScan As Button
    Friend WithEvents btnPrintGTTReport As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnGlucoseSeries As Button
    Friend WithEvents Button1 As Button
End Class
