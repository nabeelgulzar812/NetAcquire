<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewViewWards
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
        cmdCancel = New Button()
        GroupBox1 = New GroupBox()
        cmdRefresh = New Button()
        ChkPrinting = New CheckBox()
        ChkLog = New CheckBox()
        ChkCoag = New CheckBox()
        ChkBio = New CheckBox()
        ChkHeam = New CheckBox()
        dtTo = New DateTimePicker()
        dtFrom = New DateTimePicker()
        G = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(G, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdCancel
        ' 
        cmdCancel.BackColor = SystemColors.Control
        cmdCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmdCancel.ForeColor = SystemColors.ControlText
        cmdCancel.ImageAlign = ContentAlignment.TopCenter
        cmdCancel.Location = New Point(901, 539)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(112, 118)
        cmdCancel.TabIndex = 11
        cmdCancel.Text = "Cancel"
        cmdCancel.TextAlign = ContentAlignment.BottomCenter
        cmdCancel.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLight
        GroupBox1.Controls.Add(cmdRefresh)
        GroupBox1.Controls.Add(ChkPrinting)
        GroupBox1.Controls.Add(ChkLog)
        GroupBox1.Controls.Add(ChkCoag)
        GroupBox1.Controls.Add(ChkBio)
        GroupBox1.Controls.Add(ChkHeam)
        GroupBox1.Controls.Add(dtTo)
        GroupBox1.Controls.Add(dtFrom)
        GroupBox1.Location = New Point(850, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(203, 430)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Between Dates"
        ' 
        ' cmdRefresh
        ' 
        cmdRefresh.BackColor = SystemColors.Control
        cmdRefresh.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmdRefresh.ForeColor = SystemColors.ActiveCaptionText
        cmdRefresh.ImageAlign = ContentAlignment.TopCenter
        cmdRefresh.Location = New Point(51, 296)
        cmdRefresh.Name = "cmdRefresh"
        cmdRefresh.Size = New Size(112, 119)
        cmdRefresh.TabIndex = 7
        cmdRefresh.Text = "Refresh"
        cmdRefresh.TextAlign = ContentAlignment.BottomCenter
        cmdRefresh.UseVisualStyleBackColor = False
        ' 
        ' ChkPrinting
        ' 
        ChkPrinting.AutoSize = True
        ChkPrinting.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ChkPrinting.Location = New Point(8, 239)
        ChkPrinting.Name = "ChkPrinting"
        ChkPrinting.Size = New Size(97, 27)
        ChkPrinting.TabIndex = 4
        ChkPrinting.Text = "Printing"
        ChkPrinting.UseVisualStyleBackColor = True
        ' 
        ' ChkLog
        ' 
        ChkLog.AutoSize = True
        ChkLog.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ChkLog.Location = New Point(7, 208)
        ChkLog.Name = "ChkLog"
        ChkLog.Size = New Size(120, 27)
        ChkLog.TabIndex = 3
        ChkLog.Text = "Log In/Out"
        ChkLog.UseVisualStyleBackColor = True
        ' 
        ' ChkCoag
        ' 
        ChkCoag.AutoSize = True
        ChkCoag.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ChkCoag.Location = New Point(6, 178)
        ChkCoag.Name = "ChkCoag"
        ChkCoag.Size = New Size(73, 27)
        ChkCoag.TabIndex = 2
        ChkCoag.Text = "Coag"
        ChkCoag.UseVisualStyleBackColor = True
        ' 
        ' ChkBio
        ' 
        ChkBio.AutoSize = True
        ChkBio.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ChkBio.Location = New Point(6, 148)
        ChkBio.Name = "ChkBio"
        ChkBio.Size = New Size(58, 27)
        ChkBio.TabIndex = 1
        ChkBio.Text = "Bio"
        ChkBio.UseVisualStyleBackColor = True
        ' 
        ' ChkHeam
        ' 
        ChkHeam.AutoSize = True
        ChkHeam.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ChkHeam.Location = New Point(7, 118)
        ChkHeam.Name = "ChkHeam"
        ChkHeam.Size = New Size(79, 27)
        ChkHeam.TabIndex = 0
        ChkHeam.Text = "Heam"
        ChkHeam.UseVisualStyleBackColor = True
        ' 
        ' dtTo
        ' 
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(7, 71)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(180, 27)
        dtTo.TabIndex = 1
        dtTo.Value = New Date(2003, 2, 27, 0, 0, 0, 0)
        ' 
        ' dtFrom
        ' 
        dtFrom.Format = DateTimePickerFormat.Short
        dtFrom.Location = New Point(7, 27)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(180, 27)
        dtFrom.TabIndex = 0
        dtFrom.Value = New Date(2003, 2, 27, 0, 0, 0, 0)
        ' 
        ' G
        ' 
        G.AllowUserToDeleteRows = False
        G.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        G.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        G.Location = New Point(27, 38)
        G.Name = "G"
        G.ReadOnly = True
        G.RowHeadersWidth = 51
        G.RowTemplate.Height = 29
        G.Size = New Size(804, 619)
        G.TabIndex = 9
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Chart #"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Date/Time"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "SampleID"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Op. Code"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Operator"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Details"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' FrmNewViewWards
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 694)
        Controls.Add(cmdCancel)
        Controls.Add(GroupBox1)
        Controls.Add(G)
        Name = "FrmNewViewWards"
        Text = "FrmNewViewWards"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(G, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents ChkPrinting As CheckBox
    Friend WithEvents ChkLog As CheckBox
    Friend WithEvents ChkCoag As CheckBox
    Friend WithEvents ChkBio As CheckBox
    Friend WithEvents ChkHeam As CheckBox
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents G As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
