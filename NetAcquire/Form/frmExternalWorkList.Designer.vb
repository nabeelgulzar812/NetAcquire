<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExternalWorkList
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
        dt = New DateTimePicker()
        dtTime = New DateTimePicker()
        Label3 = New Label()
        cmbSendTo = New ComboBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        cmdXL = New Button()
        cmdPrint = New Button()
        cmdCancel = New Button()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dt)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(34, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(430, 92)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Between Date/Times"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 23)
        Label1.TabIndex = 0
        Label1.Text = "04/01/2007 16:30"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(153, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 23)
        Label2.TabIndex = 1
        Label2.Text = "and"
        ' 
        ' dt
        ' 
        dt.Format = DateTimePickerFormat.Short
        dt.Location = New Point(198, 44)
        dt.Name = "dt"
        dt.Size = New Size(140, 27)
        dt.TabIndex = 2
        ' 
        ' dtTime
        ' 
        dtTime.Format = DateTimePickerFormat.Time
        dtTime.Location = New Point(378, 68)
        dtTime.Name = "dtTime"
        dtTime.Size = New Size(80, 27)
        dtTime.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(511, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 4
        Label3.Text = "ExternalSite"
        ' 
        ' cmbSendTo
        ' 
        cmbSendTo.FormattingEnabled = True
        cmbSendTo.Location = New Point(511, 68)
        cmbSendTo.Name = "cmbSendTo"
        cmbSendTo.Size = New Size(199, 28)
        cmbSendTo.TabIndex = 5
        cmbSendTo.Text = "cmbSendTo"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(37, 122)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(679, 484)
        DataGridView1.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Sample ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Patient Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Chart"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "D.O.B"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Location"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Requests"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' cmdXL
        ' 
        cmdXL.Location = New Point(722, 122)
        cmdXL.Name = "cmdXL"
        cmdXL.Size = New Size(113, 71)
        cmdXL.TabIndex = 7
        cmdXL.Text = "Export to Excel"
        cmdXL.UseVisualStyleBackColor = True
        ' 
        ' cmdPrint
        ' 
        cmdPrint.Location = New Point(722, 241)
        cmdPrint.Name = "cmdPrint"
        cmdPrint.Size = New Size(113, 71)
        cmdPrint.TabIndex = 8
        cmdPrint.Text = "Print"
        cmdPrint.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(722, 535)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(113, 71)
        cmdCancel.TabIndex = 9
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(722, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 28)
        Label4.TabIndex = 10
        Label4.Text = "Exporting..."
        ' 
        ' frmExternalWorkList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 618)
        Controls.Add(Label4)
        Controls.Add(cmdCancel)
        Controls.Add(cmdPrint)
        Controls.Add(cmdXL)
        Controls.Add(DataGridView1)
        Controls.Add(cmbSendTo)
        Controls.Add(Label3)
        Controls.Add(dtTime)
        Controls.Add(GroupBox1)
        Name = "frmExternalWorkList"
        Text = "NetAcquire - External Worklist"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents dtTime As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSendTo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents cmdXL As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label4 As Label
End Class
