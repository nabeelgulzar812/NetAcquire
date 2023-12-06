<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchOccult
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        grdOccult = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        DataGridView2 = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        DataGridView3 = New DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        cmdSave = New Button()
        cmdCancel = New Button()
        'CType(grdOccult, ComponentModel.ISupportInitialize).BeginInit()
        'CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        'CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(83, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(776, 65)
        Button1.TabIndex = 0
        Button1.Text = "S e t    1,  2,  a n d  3    A l l    N e g a t i v e"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(83, 99)
        Button2.Name = "Button2"
        Button2.Size = New Size(241, 48)
        Button2.TabIndex = 1
        Button2.Text = "Set All Negative"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(350, 99)
        Button3.Name = "Button3"
        Button3.Size = New Size(243, 48)
        Button3.TabIndex = 2
        Button3.Text = "Set All Negative"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(616, 99)
        Button4.Name = "Button4"
        Button4.Size = New Size(243, 48)
        Button4.TabIndex = 3
        Button4.Text = "Set All Negative"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' grdOccult
        ' 
        grdOccult.AllowUserToAddRows = False
        grdOccult.AllowUserToDeleteRows = False
        grdOccult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdOccult.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        grdOccult.Location = New Point(83, 153)
        grdOccult.Name = "grdOccult"
        grdOccult.ReadOnly = True
        grdOccult.RowHeadersWidth = 51
        grdOccult.RowTemplate.Height = 29
        grdOccult.Size = New Size(241, 475)
        grdOccult.TabIndex = 4
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
        Column2.HeaderText = "Result"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column3, Column4})
        DataGridView2.Location = New Point(352, 153)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(241, 475)
        DataGridView2.TabIndex = 5
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Sample ID"
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
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {Column5, Column6})
        DataGridView3.Location = New Point(618, 153)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.RowTemplate.Height = 29
        DataGridView3.Size = New Size(241, 475)
        DataGridView3.TabIndex = 6
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Sample ID"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Result"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(879, 165)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(101, 96)
        cmdSave.TabIndex = 7
        cmdSave.Text = "Save Changes"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(879, 292)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(101, 96)
        cmdCancel.TabIndex = 8
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' frmBatchOccult
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1019, 655)
        Controls.Add(cmdCancel)
        Controls.Add(cmdSave)
        Controls.Add(DataGridView3)
        Controls.Add(DataGridView2)
        Controls.Add(grdOccult)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "frmBatchOccult"
        Text = "frmBatchOccult"
        'CType(grdOccult, ComponentModel.ISupportInitialize).EndInit()
        'CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        'CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents grdOccult As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
End Class
