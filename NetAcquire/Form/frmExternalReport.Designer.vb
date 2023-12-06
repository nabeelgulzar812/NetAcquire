<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExternalReport
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
        pB = New ProgressBar()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtName = New TextBox()
        txtDob = New TextBox()
        txtAge = New TextBox()
        txtChart = New TextBox()
        txtSex = New TextBox()
        txtAddr1 = New TextBox()
        txtAddr2 = New TextBox()
        txtAddr3 = New TextBox()
        grdSID = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        cmdPrint = New Button()
        cmdFax = New Button()
        cmdCancel = New Button()
        GroupBox2 = New GroupBox()
        rtb = New RichTextBox()
        GroupBox1.SuspendLayout()
        'CType(grdSID, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pB
        ' 
        pB.Location = New Point(33, 21)
        pB.Name = "pB"
        pB.Size = New Size(833, 10)
        pB.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtAddr3)
        GroupBox1.Controls.Add(txtAddr2)
        GroupBox1.Controls.Add(txtAddr1)
        GroupBox1.Controls.Add(txtSex)
        GroupBox1.Controls.Add(txtChart)
        GroupBox1.Controls.Add(txtDob)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(33, 37)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(833, 175)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(90, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(665, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 20)
        Label3.TabIndex = 2
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(419, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 3
        Label4.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(272, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 20)
        Label5.TabIndex = 4
        Label5.Text = "Sex"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(90, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 20)
        Label6.TabIndex = 5
        Label6.Text = "Chart"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(383, 31)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 20)
        Label7.TabIndex = 6
        Label7.Text = "Date Of Birth"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(144, 28)
        txtName.Name = "txtName"
        txtName.Size = New Size(233, 27)
        txtName.TabIndex = 7
        ' 
        ' txtDob
        ' 
        txtDob.Location = New Point(491, 28)
        txtDob.Name = "txtDob"
        txtDob.Size = New Size(168, 27)
        txtDob.TabIndex = 8
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(741, 64)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(119, 27)
        txtAge.TabIndex = 9
        ' 
        ' txtChart
        ' 
        txtChart.Location = New Point(143, 63)
        txtChart.Name = "txtChart"
        txtChart.Size = New Size(123, 27)
        txtChart.TabIndex = 9
        ' 
        ' txtSex
        ' 
        txtSex.Location = New Point(311, 63)
        txtSex.Name = "txtSex"
        txtSex.Size = New Size(102, 27)
        txtSex.TabIndex = 10
        ' 
        ' txtAddr1
        ' 
        txtAddr1.Location = New Point(491, 60)
        txtAddr1.Name = "txtAddr1"
        txtAddr1.Size = New Size(336, 27)
        txtAddr1.TabIndex = 11
        ' 
        ' txtAddr2
        ' 
        txtAddr2.Location = New Point(90, 93)
        txtAddr2.Name = "txtAddr2"
        txtAddr2.Size = New Size(737, 27)
        txtAddr2.TabIndex = 12
        ' 
        ' txtAddr3
        ' 
        txtAddr3.Location = New Point(90, 126)
        txtAddr3.Name = "txtAddr3"
        txtAddr3.Size = New Size(737, 27)
        txtAddr3.TabIndex = 13
        ' 
        ' grdSID
        ' 
        grdSID.AllowUserToAddRows = False
        grdSID.AllowUserToDeleteRows = False
        grdSID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdSID.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        grdSID.Location = New Point(33, 218)
        grdSID.Name = "grdSID"
        grdSID.ReadOnly = True
        grdSID.RowHeadersWidth = 51
        grdSID.RowTemplate.Height = 29
        grdSID.Size = New Size(551, 242)
        grdSID.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Sample-ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Sample Date"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Request"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Result"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' cmdPrint
        ' 
        cmdPrint.Location = New Point(698, 320)
        cmdPrint.Name = "cmdPrint"
        cmdPrint.Size = New Size(72, 56)
        cmdPrint.TabIndex = 11
        cmdPrint.Text = "Print"
        cmdPrint.UseVisualStyleBackColor = True
        ' 
        ' cmdFax
        ' 
        cmdFax.Location = New Point(609, 317)
        cmdFax.Name = "cmdFax"
        cmdFax.Size = New Size(71, 63)
        cmdFax.TabIndex = 12
        cmdFax.Text = "FAX"
        cmdFax.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(789, 320)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(71, 56)
        cmdCancel.TabIndex = 13
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rtb)
        GroupBox2.Location = New Point(33, 474)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(813, 325)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Report"
        ' 
        ' rtb
        ' 
        rtb.Location = New Point(15, 26)
        rtb.Name = "rtb"
        rtb.Size = New Size(792, 293)
        rtb.TabIndex = 0
        rtb.Text = ""
        ' 
        ' frmExternalReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(947, 852)
        Controls.Add(GroupBox2)
        Controls.Add(cmdCancel)
        Controls.Add(cmdFax)
        Controls.Add(cmdPrint)
        Controls.Add(grdSID)
        Controls.Add(txtAge)
        Controls.Add(GroupBox1)
        Controls.Add(pB)
        Name = "frmExternalReport"
        Text = "NetAcquire - External Tests"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        'CType(grdSID, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pB As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddr3 As TextBox
    Friend WithEvents txtAddr2 As TextBox
    Friend WithEvents txtAddr1 As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtChart As TextBox
    Friend WithEvents txtDob As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents grdSID As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdFax As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rtb As RichTextBox
End Class
