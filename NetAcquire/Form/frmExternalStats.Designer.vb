<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExternalStats
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
        s = New DateTimePicker()
        dtTo = New DateTimePicker()
        rToday = New RadioButton()
        rLastweek = New RadioButton()
        rLastmounth = New RadioButton()
        rLast = New RadioButton()
        rLastquarter = New RadioButton()
        rLastfullquarter = New RadioButton()
        rYeartodate = New RadioButton()
        cmdCalculate = New Button()
        GroupBox2 = New GroupBox()
        rClinicians = New RadioButton()
        rWards = New RadioButton()
        rGPs = New RadioButton()
        g = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        grdAnalyte = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        cmdPrint = New Button()
        cmdXL = New Button()
        Button3 = New Button()
        cmdCancel = New Button()
        Label3 = New Label()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        'CType(g, ComponentModel.ISupportInitialize).BeginInit()
        'CType(grdAnalyte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmdCalculate)
        GroupBox1.Controls.Add(rYeartodate)
        GroupBox1.Controls.Add(rLastfullquarter)
        GroupBox1.Controls.Add(rLastquarter)
        GroupBox1.Controls.Add(rLast)
        GroupBox1.Controls.Add(rLastmounth)
        GroupBox1.Controls.Add(rLastweek)
        GroupBox1.Controls.Add(rToday)
        GroupBox1.Controls.Add(dtTo)
        GroupBox1.Controls.Add(s)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(27, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(797, 153)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Between Dates"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(21, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 0
        Label1.Text = "From"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(41, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 20)
        Label2.TabIndex = 1
        Label2.Text = "To"
        ' 
        ' s
        ' 
        s.Format = DateTimePickerFormat.Short
        s.Location = New Point(73, 29)
        s.Name = "s"
        s.Size = New Size(186, 27)
        s.TabIndex = 2
        ' 
        ' dtTo
        ' 
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(73, 62)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(186, 27)
        dtTo.TabIndex = 3
        ' 
        ' rToday
        ' 
        rToday.AutoSize = True
        rToday.Location = New Point(293, 21)
        rToday.Name = "rToday"
        rToday.Size = New Size(70, 24)
        rToday.TabIndex = 4
        rToday.TabStop = True
        rToday.Text = "Today"
        rToday.UseVisualStyleBackColor = True
        ' 
        ' rLastweek
        ' 
        rLastweek.AutoSize = True
        rLastweek.Location = New Point(293, 54)
        rLastweek.Name = "rLastweek"
        rLastweek.Size = New Size(96, 24)
        rLastweek.TabIndex = 5
        rLastweek.TabStop = True
        rLastweek.Text = "Last Week"
        rLastweek.UseVisualStyleBackColor = True
        ' 
        ' rLastmounth
        ' 
        rLastmounth.AutoSize = True
        rLastmounth.Location = New Point(293, 84)
        rLastmounth.Name = "rLastmounth"
        rLastmounth.Size = New Size(103, 24)
        rLastmounth.TabIndex = 6
        rLastmounth.TabStop = True
        rLastmounth.Text = "Last Month"
        rLastmounth.UseVisualStyleBackColor = True
        ' 
        ' rLast
        ' 
        rLast.AutoSize = True
        rLast.Location = New Point(397, 23)
        rLast.Name = "rLast"
        rLast.Size = New Size(130, 24)
        rLast.TabIndex = 7
        rLast.TabStop = True
        rLast.Text = "Last Full Month"
        rLast.UseVisualStyleBackColor = True
        ' 
        ' rLastquarter
        ' 
        rLastquarter.AutoSize = True
        rLastquarter.Location = New Point(397, 54)
        rLastquarter.Name = "rLastquarter"
        rLastquarter.Size = New Size(110, 24)
        rLastquarter.TabIndex = 8
        rLastquarter.TabStop = True
        rLastquarter.Text = "Last Quarter"
        rLastquarter.UseVisualStyleBackColor = True
        ' 
        ' rLastfullquarter
        ' 
        rLastfullquarter.AutoSize = True
        rLastfullquarter.Location = New Point(397, 84)
        rLastfullquarter.Name = "rLastfullquarter"
        rLastfullquarter.Size = New Size(137, 24)
        rLastfullquarter.TabIndex = 9
        rLastfullquarter.TabStop = True
        rLastfullquarter.Text = "Last Full Quarter"
        rLastfullquarter.UseVisualStyleBackColor = True
        ' 
        ' rYeartodate
        ' 
        rYeartodate.AutoSize = True
        rYeartodate.Location = New Point(397, 114)
        rYeartodate.Name = "rYeartodate"
        rYeartodate.Size = New Size(114, 24)
        rYeartodate.TabIndex = 10
        rYeartodate.TabStop = True
        rYeartodate.Text = "Year To Date"
        rYeartodate.UseVisualStyleBackColor = True
        ' 
        ' cmdCalculate
        ' 
        cmdCalculate.Location = New Point(577, 29)
        cmdCalculate.Name = "cmdCalculate"
        cmdCalculate.Size = New Size(96, 87)
        cmdCalculate.TabIndex = 11
        cmdCalculate.Text = "Calculate"
        cmdCalculate.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rGPs)
        GroupBox2.Controls.Add(rWards)
        GroupBox2.Controls.Add(rClinicians)
        GroupBox2.Location = New Point(27, 184)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(302, 64)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Source"
        ' 
        ' rClinicians
        ' 
        rClinicians.AutoSize = True
        rClinicians.Location = New Point(6, 26)
        rClinicians.Name = "rClinicians"
        rClinicians.Size = New Size(92, 24)
        rClinicians.TabIndex = 0
        rClinicians.TabStop = True
        rClinicians.Text = "Clinicians"
        rClinicians.UseVisualStyleBackColor = True
        ' 
        ' rWards
        ' 
        rWards.AutoSize = True
        rWards.Location = New Point(104, 26)
        rWards.Name = "rWards"
        rWards.Size = New Size(71, 24)
        rWards.TabIndex = 1
        rWards.TabStop = True
        rWards.Text = "Wards"
        rWards.UseVisualStyleBackColor = True
        ' 
        ' rGPs
        ' 
        rGPs.AutoSize = True
        rGPs.Location = New Point(202, 26)
        rGPs.Name = "rGPs"
        rGPs.Size = New Size(60, 24)
        rGPs.TabIndex = 2
        rGPs.TabStop = True
        rGPs.Text = "G.P.s"
        rGPs.UseVisualStyleBackColor = True
        ' 
        ' g
        ' 
        g.AllowUserToAddRows = False
        g.AllowUserToDeleteRows = False
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        g.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        g.Location = New Point(12, 254)
        g.Name = "g"
        g.ReadOnly = True
        g.RowHeadersWidth = 51
        g.RowTemplate.Height = 29
        g.Size = New Size(472, 537)
        g.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Source"
        Column1.MinimumWidth = 4
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Samples"
        Column2.MinimumWidth = 3
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Tests"
        Column3.MinimumWidth = 3
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "T/S"
        Column4.MinimumWidth = 2
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' grdAnalyte
        ' 
        grdAnalyte.AllowUserToAddRows = False
        grdAnalyte.AllowUserToDeleteRows = False
        grdAnalyte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdAnalyte.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2})
        grdAnalyte.Location = New Point(490, 254)
        grdAnalyte.Name = "grdAnalyte"
        grdAnalyte.ReadOnly = True
        grdAnalyte.RowHeadersWidth = 51
        grdAnalyte.RowTemplate.Height = 29
        grdAnalyte.Size = New Size(314, 537)
        grdAnalyte.TabIndex = 3
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Analyte"
        DataGridViewTextBoxColumn1.MinimumWidth = 4
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 125
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Total"
        DataGridViewTextBoxColumn2.MinimumWidth = 3
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 125
        ' 
        ' cmdPrint
        ' 
        cmdPrint.Location = New Point(810, 251)
        cmdPrint.Name = "cmdPrint"
        cmdPrint.Size = New Size(130, 90)
        cmdPrint.TabIndex = 4
        cmdPrint.Text = "Print"
        cmdPrint.UseVisualStyleBackColor = True
        ' 
        ' cmdXL
        ' 
        cmdXL.Location = New Point(810, 347)
        cmdXL.Name = "cmdXL"
        cmdXL.Size = New Size(130, 90)
        cmdXL.TabIndex = 5
        cmdXL.Text = "Export Sources to Excel"
        cmdXL.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(810, 443)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 90)
        Button3.TabIndex = 6
        Button3.Text = "Export Analytes  to Excel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(810, 701)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(130, 90)
        cmdCancel.TabIndex = 7
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(820, 536)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 28)
        Label3.TabIndex = 8
        Label3.Text = "Exporting..."
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gold
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(810, 596)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(130, 77)
        TextBox1.TabIndex = 9
        TextBox1.Text = "     Generating Report -Please " & vbCrLf & "          wait"
        ' 
        ' frmExternalStats
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(979, 834)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(cmdCancel)
        Controls.Add(Button3)
        Controls.Add(cmdXL)
        Controls.Add(cmdPrint)
        Controls.Add(grdAnalyte)
        Controls.Add(g)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmExternalStats"
        Text = "NetAcquire - External Tests"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        'CType(g, ComponentModel.ISupportInitialize).EndInit()
        'CType(grdAnalyte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents s As DateTimePicker
    Friend WithEvents rToday As RadioButton
    Friend WithEvents rLastfullquarter As RadioButton
    Friend WithEvents rLastquarter As RadioButton
    Friend WithEvents rLast As RadioButton
    Friend WithEvents rLastmounth As RadioButton
    Friend WithEvents rLastweek As RadioButton
    Friend WithEvents rYeartodate As RadioButton
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rGPs As RadioButton
    Friend WithEvents rWards As RadioButton
    Friend WithEvents rClinicians As RadioButton
    Friend WithEvents g As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents grdAnalyte As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdXL As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
