
Partial Class frmGlucoseByName
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
        GroupBox1 = New GroupBox()
        dtFrom = New DateTimePicker()
        dtTo = New DateTimePicker()
        Label1 = New Label()
        txtName = New TextBox()
        cmdbutton = New Button()
        pb = New ProgressBar()
        gName = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtchart = New TextBox()
        txtDob = New TextBox()
        txtAddr1 = New TextBox()
        txtAddr2 = New TextBox()
        txtConsultant = New TextBox()
        txtWard = New TextBox()
        txtGP = New TextBox()
        txtAge = New TextBox()
        txtSex = New TextBox()
        TextBox10 = New TextBox()
        g = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        cmdPrint = New Button()
        cmdGlucose = New Button()
        cmdViewScan = New Button()
        cmdCancel = New Button()
        GroupBox1.SuspendLayout()
        'CType(gName, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        'CType(g, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dtTo)
        GroupBox1.Controls.Add(dtFrom)
        GroupBox1.Location = New Point(24, 18)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(349, 74)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Betweet Dates"
        ' 
        ' dtFrom
        ' 
        dtFrom.Format = DateTimePickerFormat.Short
        dtFrom.Location = New Point(6, 35)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(149, 27)
        dtFrom.TabIndex = 0
        ' 
        ' dtTo
        ' 
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(174, 35)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(149, 27)
        dtTo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(30, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(93, 98)
        txtName.Name = "txtName"
        txtName.Size = New Size(216, 27)
        txtName.TabIndex = 2
        ' 
        ' cmdbutton
        ' 
        cmdbutton.Location = New Point(315, 93)
        cmdbutton.Name = "cmdbutton"
        cmdbutton.Size = New Size(58, 33)
        cmdbutton.TabIndex = 3
        cmdbutton.Text = "S"
        cmdbutton.UseVisualStyleBackColor = True
        ' 
        ' pb
        ' 
        pb.Location = New Point(34, 137)
        pb.Name = "pb"
        pb.Size = New Size(339, 12)
        pb.TabIndex = 4
        ' 
        ' gName
        ' 
        gName.AllowUserToAddRows = False
        gName.AllowUserToDeleteRows = False
        gName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gName.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        gName.Location = New Point(30, 155)
        gName.Name = "gName"
        gName.ReadOnly = True
        gName.RowHeadersWidth = 51
        gName.RowTemplate.Height = 29
        gName.Size = New Size(335, 576)
        gName.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(txtSex)
        GroupBox2.Controls.Add(txtAge)
        GroupBox2.Controls.Add(txtGP)
        GroupBox2.Controls.Add(txtWard)
        GroupBox2.Controls.Add(txtConsultant)
        GroupBox2.Controls.Add(txtAddr2)
        GroupBox2.Controls.Add(txtAddr1)
        GroupBox2.Controls.Add(txtDob)
        GroupBox2.Controls.Add(txtchart)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(379, 18)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(514, 272)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(409, 66)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 20)
        Label10.TabIndex = 33
        Label10.Text = "Sex"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(283, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 20)
        Label9.TabIndex = 32
        Label9.Text = "Age"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(69, 222)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 20)
        Label8.TabIndex = 31
        Label8.Text = "G.P"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(59, 193)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 30
        Label7.Text = "Ward"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(23, 163)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 20)
        Label6.TabIndex = 29
        Label6.Text = "Consultant"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(52, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 28
        Label5.Text = "Addr2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(52, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 27
        Label4.Text = "Addr1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(56, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 26
        Label3.Text = "D.O.B"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(0, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 25
        Label2.Text = "Chart Number"
        ' 
        ' txtchart
        ' 
        txtchart.Location = New Point(108, 37)
        txtchart.Name = "txtchart"
        txtchart.Size = New Size(155, 27)
        txtchart.TabIndex = 34
        ' 
        ' txtDob
        ' 
        txtDob.Location = New Point(109, 66)
        txtDob.Name = "txtDob"
        txtDob.Size = New Size(154, 27)
        txtDob.TabIndex = 35
        ' 
        ' txtAddr1
        ' 
        txtAddr1.Location = New Point(108, 95)
        txtAddr1.Name = "txtAddr1"
        txtAddr1.Size = New Size(400, 27)
        txtAddr1.TabIndex = 36
        ' 
        ' txtAddr2
        ' 
        txtAddr2.Location = New Point(108, 128)
        txtAddr2.Name = "txtAddr2"
        txtAddr2.Size = New Size(400, 27)
        txtAddr2.TabIndex = 37
        ' 
        ' txtConsultant
        ' 
        txtConsultant.Location = New Point(108, 160)
        txtConsultant.Name = "txtConsultant"
        txtConsultant.Size = New Size(400, 27)
        txtConsultant.TabIndex = 38
        ' 
        ' txtWard
        ' 
        txtWard.Location = New Point(108, 186)
        txtWard.Name = "txtWard"
        txtWard.Size = New Size(400, 27)
        txtWard.TabIndex = 39
        ' 
        ' txtGP
        ' 
        txtGP.Location = New Point(108, 219)
        txtGP.Name = "txtGP"
        txtGP.Size = New Size(400, 27)
        txtGP.TabIndex = 40
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(326, 62)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(77, 27)
        txtAge.TabIndex = 41
        ' 
        ' txtSex
        ' 
        txtSex.Location = New Point(442, 63)
        txtSex.Name = "txtSex"
        txtSex.Size = New Size(59, 27)
        txtSex.TabIndex = 42
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(294, 35)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(214, 27)
        TextBox10.TabIndex = 43
        ' 
        ' g
        ' 
        g.AllowUserToAddRows = False
        g.AllowUserToDeleteRows = False
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        g.Columns.AddRange(New DataGridViewColumn() {Column3, Column4, Column5})
        g.Location = New Point(379, 296)
        g.Name = "g"
        g.ReadOnly = True
        g.RowHeadersWidth = 51
        g.RowTemplate.Height = 29
        g.Size = New Size(436, 425)
        g.TabIndex = 7
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Run #"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Time"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Serummmol/L "
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' cmdPrint
        ' 
        cmdPrint.Location = New Point(821, 295)
        cmdPrint.Name = "cmdPrint"
        cmdPrint.Size = New Size(94, 99)
        cmdPrint.TabIndex = 8
        cmdPrint.Text = "Print as GTT Report"
        cmdPrint.UseVisualStyleBackColor = True
        ' 
        ' cmdGlucose
        ' 
        cmdGlucose.Location = New Point(821, 415)
        cmdGlucose.Name = "cmdGlucose"
        cmdGlucose.Size = New Size(94, 99)
        cmdGlucose.TabIndex = 9
        cmdGlucose.Text = "Print as  Glucose Series"
        cmdGlucose.UseVisualStyleBackColor = True
        ' 
        ' cmdViewScan
        ' 
        cmdViewScan.Location = New Point(821, 539)
        cmdViewScan.Name = "cmdViewScan"
        cmdViewScan.Size = New Size(94, 92)
        cmdViewScan.TabIndex = 10
        cmdViewScan.Text = "View Scan"
        cmdViewScan.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(821, 638)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(94, 82)
        cmdCancel.TabIndex = 11
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' frmGlucoseByName
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(939, 743)
        Controls.Add(cmdCancel)
        Controls.Add(cmdViewScan)
        Controls.Add(cmdGlucose)
        Controls.Add(cmdPrint)
        Controls.Add(g)
        Controls.Add(GroupBox2)
        Controls.Add(gName)
        Controls.Add(pb)
        Controls.Add(cmdbutton)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "frmGlucoseByName"
        Text = "NetAcquire - Glucose Tolerance"
        GroupBox1.ResumeLayout(False)
        'CType(gName, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        'CType(g, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdbutton As Button
    Friend WithEvents pb As ProgressBar
    Friend WithEvents gName As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGP As TextBox
    Friend WithEvents txtWard As TextBox
    Friend WithEvents txtConsultant As TextBox
    Friend WithEvents txtAddr2 As TextBox
    Friend WithEvents txtAddr1 As TextBox
    Friend WithEvents txtDob As TextBox
    Friend WithEvents txtchart As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents g As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdGlucose As Button
    Friend WithEvents cmdViewScan As Button
    Friend WithEvents cmdCancel As Button
End Class
