<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmASOT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.viewTagged = New System.Windows.Forms.RadioButton()
        Me.viewIncomplete = New System.Windows.Forms.RadioButton()
        Me.viewAll = New System.Windows.Forms.RadioButton()
        Me.dTime = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.grd = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.viewTagged)
        Me.GroupBox1.Controls.Add(Me.viewIncomplete)
        Me.GroupBox1.Controls.Add(Me.viewAll)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(142, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Show"
        '
        'viewTagged
        '
        Me.viewTagged.AutoSize = True
        Me.viewTagged.Location = New System.Drawing.Point(20, 69)
        Me.viewTagged.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.viewTagged.Name = "viewTagged"
        Me.viewTagged.Size = New System.Drawing.Size(77, 20)
        Me.viewTagged.TabIndex = 2
        Me.viewTagged.TabStop = True
        Me.viewTagged.Text = "Tagged"
        Me.viewTagged.UseVisualStyleBackColor = True
        '
        'viewIncomplete
        '
        Me.viewIncomplete.AutoSize = True
        Me.viewIncomplete.Location = New System.Drawing.Point(20, 45)
        Me.viewIncomplete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.viewIncomplete.Name = "viewIncomplete"
        Me.viewIncomplete.Size = New System.Drawing.Size(94, 20)
        Me.viewIncomplete.TabIndex = 1
        Me.viewIncomplete.TabStop = True
        Me.viewIncomplete.Text = "Incomplete"
        Me.viewIncomplete.UseVisualStyleBackColor = True
        '
        'viewAll
        '
        Me.viewAll.AutoSize = True
        Me.viewAll.Location = New System.Drawing.Point(20, 21)
        Me.viewAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.viewAll.Name = "viewAll"
        Me.viewAll.Size = New System.Drawing.Size(43, 20)
        Me.viewAll.TabIndex = 0
        Me.viewAll.TabStop = True
        Me.viewAll.Text = "All"
        Me.viewAll.UseVisualStyleBackColor = True
        '
        'dTime
        '
        Me.dTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTime.Location = New System.Drawing.Point(168, 89)
        Me.dTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dTime.Name = "dTime"
        Me.dTime.Size = New System.Drawing.Size(178, 22)
        Me.dTime.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(737, 48)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 22)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "                         Card Lot Number/Expiry"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(737, 72)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(104, 22)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(737, 96)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 22)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(840, 72)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 22)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(840, 95)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 22)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(948, 72)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(122, 22)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(951, 96)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(119, 22)
        Me.TextBox7.TabIndex = 12
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(1177, 305)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(80, 75)
        Me.cmdPrint.TabIndex = 14
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(1179, 401)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 75)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(1179, 480)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 75)
        Me.cmdCancel.TabIndex = 16
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.grd.Location = New System.Drawing.Point(26, 123)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersWidth = 51
        Me.grd.RowTemplate.Height = 24
        Me.grd.Size = New System.Drawing.Size(1147, 432)
        Me.grd.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "Specimen"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Chart"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "ESR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Retic"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Monospot"
        Me.Column6.Items.AddRange(New Object() {"Positive", "Negative"})
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Malaria Screen"
        Me.Column7.Items.AddRange(New Object() {"Positive", "Negative"})
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "SickLedex"
        Me.Column8.Items.AddRange(New Object() {"Positive", "Negative"})
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "RA"
        Me.Column9.Items.AddRange(New Object() {"Positive", "Negative"})
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Width = 125
        '
        'frmASOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 580)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmASOT"
        Me.Text = "frmAddResult"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents viewTagged As RadioButton
    Friend WithEvents viewIncomplete As RadioButton
    Friend WithEvents viewAll As RadioButton
    Friend WithEvents dTime As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents grd As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewComboBoxColumn
    Friend WithEvents Column7 As DataGridViewComboBoxColumn
    Friend WithEvents Column8 As DataGridViewComboBoxColumn
    Friend WithEvents Column9 As DataGridViewComboBoxColumn
End Class
