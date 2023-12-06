
Partial Class frmASOT
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
        viewAll = New RadioButton()
        viewIncomplete = New RadioButton()
        viewTagged = New RadioButton()
        dt = New DateTimePicker()
        TextBox1 = New TextBox()
        TextBox6 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox7 = New TextBox()
        grd = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        cmdPrint = New Button()
        cmdSave = New Button()
        cmdCancel = New Button()
        GroupBox1.SuspendLayout()
        'CType(grd, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(viewTagged)
        GroupBox1.Controls.Add(viewIncomplete)
        GroupBox1.Controls.Add(viewAll)
        GroupBox1.Location = New Point(20, 19)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(142, 120)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Show"
        ' 
        ' viewAll
        ' 
        viewAll.AutoSize = True
        viewAll.Location = New Point(20, 26)
        viewAll.Name = "viewAll"
        viewAll.Size = New Size(48, 24)
        viewAll.TabIndex = 0
        viewAll.TabStop = True
        viewAll.Text = "All"
        viewAll.UseVisualStyleBackColor = True
        ' 
        ' viewIncomplete
        ' 
        viewIncomplete.AutoSize = True
        viewIncomplete.Location = New Point(20, 56)
        viewIncomplete.Name = "viewIncomplete"
        viewIncomplete.Size = New Size(105, 24)
        viewIncomplete.TabIndex = 1
        viewIncomplete.TabStop = True
        viewIncomplete.Text = "Incomplete"
        viewIncomplete.UseVisualStyleBackColor = True
        ' 
        ' viewTagged
        ' 
        viewTagged.AutoSize = True
        viewTagged.Location = New Point(20, 86)
        viewTagged.Name = "viewTagged"
        viewTagged.Size = New Size(79, 24)
        viewTagged.TabIndex = 2
        viewTagged.TabStop = True
        viewTagged.Text = "Tagged"
        viewTagged.UseVisualStyleBackColor = True
        ' 
        ' dt
        ' 
        dt.Format = DateTimePickerFormat.Short
        dt.Location = New Point(187, 105)
        dt.Name = "dt"
        dt.Size = New Size(178, 27)
        dt.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(652, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(333, 27)
        TextBox1.TabIndex = 2
        TextBox1.Text = "               Card Lot Number/Expiry"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(652, 90)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(104, 27)
        TextBox6.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(652, 120)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(104, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(755, 90)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(112, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(755, 119)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(112, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(863, 90)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(122, 27)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(866, 120)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(119, 27)
        TextBox7.TabIndex = 12
        ' 
        ' grd
        ' 
        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False
        grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grd.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        grd.Location = New Point(23, 153)
        grd.Name = "grd"
        grd.ReadOnly = True
        grd.RowHeadersWidth = 51
        grd.RowTemplate.Height = 29
        grd.Size = New Size(1124, 503)
        grd.TabIndex = 13
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Spaciman"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Chart#"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "ESR"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Retic"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Monospot "
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Malaria Screen"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Sickledex "
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "RA  "
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 125
        ' 
        ' cmdPrint
        ' 
        cmdPrint.Location = New Point(1173, 354)
        cmdPrint.Name = "cmdPrint"
        cmdPrint.Size = New Size(80, 94)
        cmdPrint.TabIndex = 14
        cmdPrint.Text = "Print"
        cmdPrint.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(1173, 454)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(80, 94)
        cmdSave.TabIndex = 15
        cmdSave.Text = "Save"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(1173, 554)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(80, 94)
        cmdCancel.TabIndex = 16
        cmdCancel.Text = "Cancel"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' frmASOT
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1265, 668)
        Controls.Add(cmdCancel)
        Controls.Add(cmdSave)
        Controls.Add(cmdPrint)
        Controls.Add(grd)
        Controls.Add(TextBox7)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox6)
        Controls.Add(TextBox1)
        Controls.Add(dt)
        Controls.Add(GroupBox1)
        Name = "frmASOT"
        Text = "frmAddResult"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        'CType(grd, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents viewTagged As RadioButton
    Friend WithEvents viewIncomplete As RadioButton
    Friend WithEvents viewAll As RadioButton
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents grd As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
End Class
