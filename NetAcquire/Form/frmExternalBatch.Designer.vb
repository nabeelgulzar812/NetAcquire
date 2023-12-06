<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExternalBatch
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
        g = New DataGridView()
        cmdExport = New Button()
        cmdCancel = New Button()
        cmdRefrash = New Button()
        cmdSave = New Button()
        cmdInsert = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtRecived = New TextBox()
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
        TextBox1 = New TextBox()
        Label3 = New Label()
        dt = New DateTimePicker()
        'CType(g, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' g
        ' 
        g.AllowUserToAddRows = False
        g.AllowUserToDeleteRows = False
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        g.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11})
        g.Location = New Point(12, 12)
        g.Name = "g"
        g.ReadOnly = True
        g.RowHeadersWidth = 51
        g.RowTemplate.Height = 29
        g.Size = New Size(1356, 820)
        g.TabIndex = 0
        ' 
        ' cmdExport
        ' 
        cmdExport.Location = New Point(1383, 17)
        cmdExport.Name = "cmdExport"
        cmdExport.Size = New Size(121, 90)
        cmdExport.TabIndex = 1
        cmdExport.Text = "Export To Excel"
        cmdExport.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(1383, 738)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(121, 90)
        cmdCancel.TabIndex = 2
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' cmdRefrash
        ' 
        cmdRefrash.Location = New Point(1383, 642)
        cmdRefrash.Name = "cmdRefrash"
        cmdRefrash.Size = New Size(121, 90)
        cmdRefrash.TabIndex = 3
        cmdRefrash.Text = "Refrash"
        cmdRefrash.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(1383, 546)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(121, 90)
        cmdSave.TabIndex = 4
        cmdSave.Text = "Save Changes"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' cmdInsert
        ' 
        cmdInsert.Location = New Point(1383, 271)
        cmdInsert.Name = "cmdInsert"
        cmdInsert.Size = New Size(121, 90)
        cmdInsert.TabIndex = 5
        cmdInsert.Text = "Insert Result"
        cmdInsert.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(1383, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 23)
        Label1.TabIndex = 6
        Label1.Text = "Exporting..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(1383, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 7
        Label2.Text = "Result"
        ' 
        ' txtRecived
        ' 
        txtRecived.Location = New Point(1383, 239)
        txtRecived.Name = "txtRecived"
        txtRecived.Size = New Size(120, 27)
        txtRecived.TabIndex = 8
        txtRecived.Text = "Recived"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Sample ID"
        Column1.MinimumWidth = 4
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Sample Date"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Patient Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "DOB"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Chart"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Analyte"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Result"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Ext.Lab"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Ward"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 125
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Clinician"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "G.P"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 125
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Yellow
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(433, 80)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(222, 53)
        TextBox1.TabIndex = 9
        TextBox1.Text = "                 ... Sorting ...." & vbCrLf & "                  Please wait"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(1383, 414)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 40)
        Label3.TabIndex = 10
        Label3.Text = "Earliest Sample" & vbCrLf & "        Date"
        ' 
        ' dt
        ' 
        dt.Format = DateTimePickerFormat.Short
        dt.Location = New Point(1383, 472)
        dt.Name = "dt"
        dt.Size = New Size(120, 27)
        dt.TabIndex = 11
        ' 
        ' frmExternalBatch
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1538, 827)
        Controls.Add(dt)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(txtRecived)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmdInsert)
        Controls.Add(cmdSave)
        Controls.Add(cmdRefrash)
        Controls.Add(cmdCancel)
        Controls.Add(cmdExport)
        Controls.Add(g)
        Name = "frmExternalBatch"
        Text = "NetAcquire - External Batches"
        'CType(g, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents g As DataGridView
    Friend WithEvents cmdExport As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdRefrash As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdInsert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRecived As TextBox
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dt As DateTimePicker
End Class
