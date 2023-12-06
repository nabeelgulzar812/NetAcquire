<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotals
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
        Me.Disciplines = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.Biochemistry = New System.Windows.Forms.Label()
        Me.Endocrinology = New System.Windows.Forms.Label()
        Me.Immunology = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Last_Week = New System.Windows.Forms.RadioButton()
        Me.Last_Month = New System.Windows.Forms.RadioButton()
        Me.Last_Quarter = New System.Windows.Forms.RadioButton()
        Me.Last_Full_Quarter = New System.Windows.Forms.RadioButton()
        Me.Last_Full_Month = New System.Windows.Forms.RadioButton()
        Me.Year_To_Date = New System.Windows.Forms.RadioButton()
        Me.Today = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Between_Dates = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GPs = New System.Windows.Forms.RadioButton()
        Me.Clinicians = New System.Windows.Forms.RadioButton()
        Me.Wards = New System.Windows.Forms.RadioButton()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdXL = New System.Windows.Forms.Button()
        Me.Source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Samples = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tests = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Samples1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tests1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Samples2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESTS3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TS3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Between_Dates.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Disciplines
        '
        Me.Disciplines.AutoSize = True
        Me.Disciplines.Location = New System.Drawing.Point(12, 9)
        Me.Disciplines.Name = "Disciplines"
        Me.Disciplines.Size = New System.Drawing.Size(84, 20)
        Me.Disciplines.TabIndex = 0
        Me.Disciplines.Text = "Disciplines"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(16, 32)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(893, 17)
        Me.pb.TabIndex = 1
        Me.pb.TabStop = False
        '
        'Biochemistry
        '
        Me.Biochemistry.AutoSize = True
        Me.Biochemistry.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Biochemistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Biochemistry.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Biochemistry.Location = New System.Drawing.Point(205, 52)
        Me.Biochemistry.Name = "Biochemistry"
        Me.Biochemistry.Size = New System.Drawing.Size(151, 29)
        Me.Biochemistry.TabIndex = 2
        Me.Biochemistry.Text = "Biochemistry"
        '
        'Endocrinology
        '
        Me.Endocrinology.AutoSize = True
        Me.Endocrinology.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Endocrinology.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endocrinology.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Endocrinology.Location = New System.Drawing.Point(512, 52)
        Me.Endocrinology.Name = "Endocrinology"
        Me.Endocrinology.Size = New System.Drawing.Size(168, 29)
        Me.Endocrinology.TabIndex = 3
        Me.Endocrinology.Text = "Endocrinology"
        '
        'Immunology
        '
        Me.Immunology.AutoSize = True
        Me.Immunology.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Immunology.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Immunology.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Immunology.Location = New System.Drawing.Point(362, 52)
        Me.Immunology.Name = "Immunology"
        Me.Immunology.Size = New System.Drawing.Size(144, 29)
        Me.Immunology.TabIndex = 4
        Me.Immunology.Text = "Immunology"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Source, Me.Samples, Me.Tests, Me.TS, Me.Samples1, Me.Tests1, Me.TS1, Me.Samples2, Me.TESTS3, Me.TS3})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(895, 603)
        Me.DataGridView1.TabIndex = 5
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(209, 106)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(112, 82)
        Me.BtnCalculate.TabIndex = 21
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'Last_Week
        '
        Me.Last_Week.AutoSize = True
        Me.Last_Week.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Last_Week.Location = New System.Drawing.Point(37, 104)
        Me.Last_Week.Name = "Last_Week"
        Me.Last_Week.Size = New System.Drawing.Size(110, 24)
        Me.Last_Week.TabIndex = 20
        Me.Last_Week.TabStop = True
        Me.Last_Week.Text = "Last Week"
        Me.Last_Week.UseVisualStyleBackColor = False
        '
        'Last_Month
        '
        Me.Last_Month.AutoSize = True
        Me.Last_Month.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Last_Month.Location = New System.Drawing.Point(37, 134)
        Me.Last_Month.Name = "Last_Month"
        Me.Last_Month.Size = New System.Drawing.Size(114, 24)
        Me.Last_Month.TabIndex = 19
        Me.Last_Month.TabStop = True
        Me.Last_Month.Text = "Last Month"
        Me.Last_Month.UseVisualStyleBackColor = False
        '
        'Last_Quarter
        '
        Me.Last_Quarter.AutoSize = True
        Me.Last_Quarter.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Last_Quarter.Location = New System.Drawing.Point(37, 194)
        Me.Last_Quarter.Name = "Last_Quarter"
        Me.Last_Quarter.Size = New System.Drawing.Size(123, 24)
        Me.Last_Quarter.TabIndex = 18
        Me.Last_Quarter.TabStop = True
        Me.Last_Quarter.Text = "Last Quarter"
        Me.Last_Quarter.UseVisualStyleBackColor = False
        '
        'Last_Full_Quarter
        '
        Me.Last_Full_Quarter.AutoSize = True
        Me.Last_Full_Quarter.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Last_Full_Quarter.Location = New System.Drawing.Point(37, 224)
        Me.Last_Full_Quarter.Name = "Last_Full_Quarter"
        Me.Last_Full_Quarter.Size = New System.Drawing.Size(152, 24)
        Me.Last_Full_Quarter.TabIndex = 17
        Me.Last_Full_Quarter.TabStop = True
        Me.Last_Full_Quarter.Text = "Last Full Quarter"
        Me.Last_Full_Quarter.UseVisualStyleBackColor = False
        '
        'Last_Full_Month
        '
        Me.Last_Full_Month.AutoSize = True
        Me.Last_Full_Month.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Last_Full_Month.Location = New System.Drawing.Point(37, 164)
        Me.Last_Full_Month.Name = "Last_Full_Month"
        Me.Last_Full_Month.Size = New System.Drawing.Size(143, 24)
        Me.Last_Full_Month.TabIndex = 16
        Me.Last_Full_Month.TabStop = True
        Me.Last_Full_Month.Text = "Last Full Month"
        Me.Last_Full_Month.UseVisualStyleBackColor = False
        '
        'Year_To_Date
        '
        Me.Year_To_Date.AutoSize = True
        Me.Year_To_Date.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Year_To_Date.Location = New System.Drawing.Point(37, 254)
        Me.Year_To_Date.Name = "Year_To_Date"
        Me.Year_To_Date.Size = New System.Drawing.Size(129, 24)
        Me.Year_To_Date.TabIndex = 15
        Me.Year_To_Date.TabStop = True
        Me.Year_To_Date.Text = "Year To Date"
        Me.Year_To_Date.UseVisualStyleBackColor = False
        '
        'Today
        '
        Me.Today.AutoSize = True
        Me.Today.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Today.Location = New System.Drawing.Point(37, 74)
        Me.Today.Name = "Today"
        Me.Today.Size = New System.Drawing.Size(77, 24)
        Me.Today.TabIndex = 14
        Me.Today.TabStop = True
        Me.Today.Text = "Today"
        Me.Today.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(182, 24)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(139, 26)
        Me.DateTimePicker2.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(17, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(139, 26)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Between_Dates
        '
        Me.Between_Dates.Controls.Add(Me.BtnCalculate)
        Me.Between_Dates.Controls.Add(Me.Last_Week)
        Me.Between_Dates.Controls.Add(Me.Last_Month)
        Me.Between_Dates.Controls.Add(Me.Last_Quarter)
        Me.Between_Dates.Controls.Add(Me.Last_Full_Quarter)
        Me.Between_Dates.Controls.Add(Me.Last_Full_Month)
        Me.Between_Dates.Controls.Add(Me.Year_To_Date)
        Me.Between_Dates.Controls.Add(Me.Today)
        Me.Between_Dates.Controls.Add(Me.DateTimePicker2)
        Me.Between_Dates.Controls.Add(Me.DateTimePicker1)
        Me.Between_Dates.Location = New System.Drawing.Point(924, 92)
        Me.Between_Dates.Name = "Between_Dates"
        Me.Between_Dates.Size = New System.Drawing.Size(349, 290)
        Me.Between_Dates.TabIndex = 22
        Me.Between_Dates.TabStop = False
        Me.Between_Dates.Text = "Between Dates"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GPs)
        Me.GroupBox1.Controls.Add(Me.Clinicians)
        Me.GroupBox1.Controls.Add(Me.Wards)
        Me.GroupBox1.Location = New System.Drawing.Point(924, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 60)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source"
        '
        'GPs
        '
        Me.GPs.AutoSize = True
        Me.GPs.Location = New System.Drawing.Point(248, 25)
        Me.GPs.Name = "GPs"
        Me.GPs.Size = New System.Drawing.Size(73, 24)
        Me.GPs.TabIndex = 1
        Me.GPs.TabStop = True
        Me.GPs.Text = "G.P.s"
        Me.GPs.UseVisualStyleBackColor = True
        '
        'Clinicians
        '
        Me.Clinicians.AutoSize = True
        Me.Clinicians.Location = New System.Drawing.Point(17, 25)
        Me.Clinicians.Name = "Clinicians"
        Me.Clinicians.Size = New System.Drawing.Size(100, 24)
        Me.Clinicians.TabIndex = 0
        Me.Clinicians.TabStop = True
        Me.Clinicians.Text = "Clinicians"
        Me.Clinicians.UseVisualStyleBackColor = True
        '
        'Wards
        '
        Me.Wards.AutoSize = True
        Me.Wards.Location = New System.Drawing.Point(139, 25)
        Me.Wards.Name = "Wards"
        Me.Wards.Size = New System.Drawing.Size(80, 24)
        Me.Wards.TabIndex = 2
        Me.Wards.TabStop = True
        Me.Wards.Text = "Wards"
        Me.Wards.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(941, 472)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(130, 74)
        Me.cmdPrint.TabIndex = 24
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(1146, 472)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(127, 74)
        Me.cmdCancel.TabIndex = 25
        Me.cmdCancel.Text = "Export to Excel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1173, 549)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Exporting..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(915, 580)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Your Report is being generated.   Please wait."
        '
        'cmdXL
        '
        Me.cmdXL.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdXL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXL.Location = New System.Drawing.Point(941, 621)
        Me.cmdXL.Name = "cmdXL"
        Me.cmdXL.Size = New System.Drawing.Size(130, 74)
        Me.cmdXL.TabIndex = 28
        Me.cmdXL.Text = "&Cancel"
        Me.cmdXL.UseVisualStyleBackColor = False
        '
        'Source
        '
        Me.Source.HeaderText = "Source"
        Me.Source.Name = "Source"
        Me.Source.Width = 150
        '
        'Samples
        '
        Me.Samples.HeaderText = "Samples"
        Me.Samples.Name = "Samples"
        Me.Samples.Width = 80
        '
        'Tests
        '
        Me.Tests.HeaderText = "Tests"
        Me.Tests.Name = "Tests"
        Me.Tests.Width = 65
        '
        'TS
        '
        Me.TS.HeaderText = "T/S"
        Me.TS.Name = "TS"
        Me.TS.Width = 65
        '
        'Samples1
        '
        Me.Samples1.HeaderText = "Samples"
        Me.Samples1.Name = "Samples1"
        Me.Samples1.Width = 80
        '
        'Tests1
        '
        Me.Tests1.HeaderText = "Tests"
        Me.Tests1.Name = "Tests1"
        Me.Tests1.Width = 65
        '
        'TS1
        '
        Me.TS1.HeaderText = "T/S"
        Me.TS1.Name = "TS1"
        Me.TS1.Width = 65
        '
        'Samples2
        '
        Me.Samples2.HeaderText = "Samples"
        Me.Samples2.Name = "Samples2"
        Me.Samples2.Width = 80
        '
        'TESTS3
        '
        Me.TESTS3.HeaderText = "Tests"
        Me.TESTS3.Name = "TESTS3"
        Me.TESTS3.Width = 65
        '
        'TS3
        '
        Me.TS3.HeaderText = "T/S"
        Me.TS3.Name = "TS3"
        Me.TS3.Width = 65
        '
        'frmTotals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 707)
        Me.Controls.Add(Me.cmdXL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Between_Dates)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Immunology)
        Me.Controls.Add(Me.Endocrinology)
        Me.Controls.Add(Me.Biochemistry)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Disciplines)
        Me.Name = "frmTotals"
        Me.Text = "frmTotals"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Between_Dates.ResumeLayout(False)
        Me.Between_Dates.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Disciplines As System.Windows.Forms.Label
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents Biochemistry As System.Windows.Forms.Label
    Friend WithEvents Endocrinology As System.Windows.Forms.Label
    Friend WithEvents Immunology As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents Last_Week As System.Windows.Forms.RadioButton
    Friend WithEvents Last_Month As System.Windows.Forms.RadioButton
    Friend WithEvents Last_Quarter As System.Windows.Forms.RadioButton
    Friend WithEvents Last_Full_Quarter As System.Windows.Forms.RadioButton
    Friend WithEvents Last_Full_Month As System.Windows.Forms.RadioButton
    Friend WithEvents Year_To_Date As System.Windows.Forms.RadioButton
    Friend WithEvents Today As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Between_Dates As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GPs As System.Windows.Forms.RadioButton
    Friend WithEvents Clinicians As System.Windows.Forms.RadioButton
    Friend WithEvents Wards As System.Windows.Forms.RadioButton
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdXL As System.Windows.Forms.Button
    Friend WithEvents Source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Samples As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tests As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Samples1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tests1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Samples2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TESTS3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TS3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
