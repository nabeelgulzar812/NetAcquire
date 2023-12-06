
Partial Class frmExternalTestsList
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtAnalyteName = New TextBox()
        txtMBCode = New TextBox()
        txtBiomnisCode = New TextBox()
        txtUnits = New TextBox()
        txtComments = New TextBox()
        cmbSampleType = New ComboBox()
        cmbDepartment = New ComboBox()
        GroupBox2 = New GroupBox()
        cmbAddress = New ComboBox()
        cmdAddress = New Button()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtMaleHigh = New TextBox()
        txtMalelow = New TextBox()
        txtfemaleHigh = New TextBox()
        txtFemalelow = New TextBox()
        cmdadd = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        cmdXL = New Button()
        cmdCancel = New Button()
        cmdSave = New Button()
        Label12 = New Label()
        pB = New ProgressBar()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmdadd)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(cmbDepartment)
        GroupBox1.Controls.Add(cmbSampleType)
        GroupBox1.Controls.Add(txtComments)
        GroupBox1.Controls.Add(txtUnits)
        GroupBox1.Controls.Add(txtBiomnisCode)
        GroupBox1.Controls.Add(txtMBCode)
        GroupBox1.Controls.Add(txtAnalyteName)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(26, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1029, 249)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 0
        Label1.Text = "Analyte Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 20)
        Label2.TabIndex = 1
        Label2.Text = "Medibridge Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 20)
        Label3.TabIndex = 2
        Label3.Text = "Sample Type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(116, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 3
        Label4.Text = "Units"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(84, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 4
        Label5.Text = "Comment"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(355, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 20)
        Label6.TabIndex = 5
        Label6.Text = "Biomnis Code"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(367, 103)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 20)
        Label7.TabIndex = 6
        Label7.Text = "Department"
        ' 
        ' txtAnalyteName
        ' 
        txtAnalyteName.Location = New Point(169, 40)
        txtAnalyteName.Name = "txtAnalyteName"
        txtAnalyteName.Size = New Size(469, 27)
        txtAnalyteName.TabIndex = 7
        ' 
        ' txtMBCode
        ' 
        txtMBCode.Location = New Point(169, 73)
        txtMBCode.Name = "txtMBCode"
        txtMBCode.Size = New Size(180, 27)
        txtMBCode.TabIndex = 8
        ' 
        ' txtBiomnisCode
        ' 
        txtBiomnisCode.Location = New Point(462, 73)
        txtBiomnisCode.Name = "txtBiomnisCode"
        txtBiomnisCode.Size = New Size(176, 27)
        txtBiomnisCode.TabIndex = 9
        ' 
        ' txtUnits
        ' 
        txtUnits.Location = New Point(164, 134)
        txtUnits.Name = "txtUnits"
        txtUnits.Size = New Size(185, 27)
        txtUnits.TabIndex = 10
        ' 
        ' txtComments
        ' 
        txtComments.Location = New Point(164, 165)
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(474, 27)
        txtComments.TabIndex = 11
        ' 
        ' cmbSampleType
        ' 
        cmbSampleType.FormattingEnabled = True
        cmbSampleType.Location = New Point(163, 100)
        cmbSampleType.Name = "cmbSampleType"
        cmbSampleType.Size = New Size(186, 28)
        cmbSampleType.TabIndex = 12
        cmbSampleType.Text = "cmbSampleType"
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(462, 103)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(176, 28)
        cmbDepartment.TabIndex = 13
        cmbDepartment.Text = "cmbDepartment"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cmdAddress)
        GroupBox2.Controls.Add(cmbAddress)
        GroupBox2.Location = New Point(642, 26)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(381, 87)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Send To Address"
        ' 
        ' cmbAddress
        ' 
        cmbAddress.FormattingEnabled = True
        cmbAddress.Location = New Point(6, 26)
        cmbAddress.Name = "cmbAddress"
        cmbAddress.Size = New Size(240, 28)
        cmbAddress.TabIndex = 0
        cmbAddress.Text = "cmbAddress"
        ' 
        ' cmdAddress
        ' 
        cmdAddress.Location = New Point(267, 14)
        cmdAddress.Name = "cmdAddress"
        cmdAddress.Size = New Size(108, 67)
        cmdAddress.TabIndex = 1
        cmdAddress.Text = "Add to Addresses"
        cmdAddress.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtFemalelow)
        GroupBox3.Controls.Add(txtfemaleHigh)
        GroupBox3.Controls.Add(txtMalelow)
        GroupBox3.Controls.Add(txtMaleHigh)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Location = New Point(644, 122)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(223, 117)
        GroupBox3.TabIndex = 15
        GroupBox3.TabStop = False
        GroupBox3.Text = "Normal Ranges"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(17, 46)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 20)
        Label8.TabIndex = 0
        Label8.Text = "High"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Blue
        Label9.Location = New Point(17, 79)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 20)
        Label9.TabIndex = 1
        Label9.Text = "Low"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label10.Location = New Point(76, 23)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 20)
        Label10.TabIndex = 2
        Label10.Text = "Male"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label11.Location = New Point(145, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 20)
        Label11.TabIndex = 3
        Label11.Text = "Female"
        ' 
        ' txtMaleHigh
        ' 
        txtMaleHigh.Location = New Point(59, 46)
        txtMaleHigh.Name = "txtMaleHigh"
        txtMaleHigh.Size = New Size(79, 27)
        txtMaleHigh.TabIndex = 4
        ' 
        ' txtMalelow
        ' 
        txtMalelow.Location = New Point(59, 79)
        txtMalelow.Name = "txtMalelow"
        txtMalelow.Size = New Size(79, 27)
        txtMalelow.TabIndex = 5
        ' 
        ' txtfemaleHigh
        ' 
        txtfemaleHigh.Location = New Point(145, 46)
        txtfemaleHigh.Name = "txtfemaleHigh"
        txtfemaleHigh.Size = New Size(72, 27)
        txtfemaleHigh.TabIndex = 6
        ' 
        ' txtFemalelow
        ' 
        txtFemalelow.Location = New Point(145, 79)
        txtFemalelow.Name = "txtFemalelow"
        txtFemalelow.Size = New Size(72, 27)
        txtFemalelow.TabIndex = 7
        ' 
        ' cmdadd
        ' 
        cmdadd.Location = New Point(909, 127)
        cmdadd.Name = "cmdadd"
        cmdadd.Size = New Size(98, 112)
        cmdadd.TabIndex = 16
        cmdadd.Text = "Add to List"
        cmdadd.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        DataGridView1.Location = New Point(26, 291)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1029, 469)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Analyte Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Male High"
        Column2.MinimumWidth = 3
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Male Low"
        Column3.MinimumWidth = 3
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Fem High"
        Column4.MinimumWidth = 3
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Fem Low"
        Column5.MinimumWidth = 3
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Units"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Address Send To"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Sample Type"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "MB Code"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 125
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Biomnis "
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Department"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 125
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Comments"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 125
        ' 
        ' cmdXL
        ' 
        cmdXL.Location = New Point(1077, 299)
        cmdXL.Name = "cmdXL"
        cmdXL.Size = New Size(117, 99)
        cmdXL.TabIndex = 2
        cmdXL.Text = "Export to Excel"
        cmdXL.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(1077, 657)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(117, 99)
        cmdCancel.TabIndex = 3
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(1077, 502)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(117, 99)
        cmdSave.TabIndex = 4
        cmdSave.Text = "Save"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(1077, 401)
        Label12.Name = "Label12"
        Label12.Size = New Size(104, 23)
        Label12.TabIndex = 5
        Label12.Text = "Exporting..."
        ' 
        ' pB
        ' 
        pB.Location = New Point(1077, 607)
        pB.Name = "pB"
        pB.Size = New Size(117, 20)
        pB.TabIndex = 6
        ' 
        ' frmExternalTestsList
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1223, 796)
        Controls.Add(pB)
        Controls.Add(Label12)
        Controls.Add(cmdSave)
        Controls.Add(cmdCancel)
        Controls.Add(cmdXL)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "frmExternalTestsList"
        Text = "NetAcquire - Test List"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMBCode As TextBox
    Friend WithEvents txtAnalyteName As TextBox
    Friend WithEvents txtBiomnisCode As TextBox
    Friend WithEvents txtComments As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents cmbSampleType As ComboBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbAddress As ComboBox
    Friend WithEvents cmdAddress As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFemalelow As TextBox
    Friend WithEvents txtfemaleHigh As TextBox
    Friend WithEvents txtMalelow As TextBox
    Friend WithEvents txtMaleHigh As TextBox
    Friend WithEvents cmdadd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents cmdXL As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents pB As ProgressBar
End Class
