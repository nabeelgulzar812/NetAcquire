<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaily
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dt = New DateTimePicker()
        btnPrint = New Button()
        btnCancel = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dt
        ' 
        dt.CalendarTitleBackColor = SystemColors.ButtonFace
        dt.Format = DateTimePickerFormat.Short
        dt.Location = New Point(40, 56)
        dt.Name = "dt"
        dt.Size = New Size(88, 23)
        dt.TabIndex = 5
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = SystemColors.ButtonFace
        btnPrint.BackgroundImageLayout = ImageLayout.None
        btnPrint.ImageAlign = ContentAlignment.TopCenter
        btnPrint.Location = New Point(357, 50)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(103, 45)
        btnPrint.TabIndex = 39
        btnPrint.Text = "&Print"
        btnPrint.TextImageRelation = TextImageRelation.ImageAboveText
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(642, 50)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(103, 45)
        btnCancel.TabIndex = 40
        btnCancel.Text = "&Cancel"
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column5, Column2, Column3, Column4})
        DataGridView1.Location = New Point(40, 114)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(741, 480)
        DataGridView1.TabIndex = 41
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Sample ID"
        Column1.Name = "Column1"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Name"
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Chart"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "G.P."
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Ward"
        Column4.Name = "Column4"
        ' 
        ' frmDaily
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(897, 706)
        Controls.Add(DataGridView1)
        Controls.Add(btnCancel)
        Controls.Add(btnPrint)
        Controls.Add(dt)
        ForeColor = SystemColors.ControlText
        Name = "frmDaily"
        Text = "frmDaily"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dt As DateTimePicker
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
