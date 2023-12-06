<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTests
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
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton7 = New RadioButton()
        GroupBox1 = New GroupBox()
        Button7 = New Button()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Label10 = New Label()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(158, 45)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(121, 27)
        DateTimePicker2.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(19, 45)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(117, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(440, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(494, 435)
        DataGridView1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 7
        Label1.Text = "From"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(158, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 20)
        Label2.TabIndex = 8
        Label2.Text = "To"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(33, 78)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(64, 21)
        RadioButton1.TabIndex = 9
        RadioButton1.TabStop = True
        RadioButton1.Text = "Today"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(33, 101)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(87, 21)
        RadioButton2.TabIndex = 10
        RadioButton2.TabStop = True
        RadioButton2.Text = "Last Week"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(33, 124)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(94, 21)
        RadioButton3.TabIndex = 11
        RadioButton3.TabStop = True
        RadioButton3.Text = "Last Month"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton4.Location = New Point(33, 147)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(117, 21)
        RadioButton4.TabIndex = 12
        RadioButton4.TabStop = True
        RadioButton4.Text = "Last Full Month"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton5.Location = New Point(158, 124)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(103, 21)
        RadioButton5.TabIndex = 15
        RadioButton5.TabStop = True
        RadioButton5.Text = "Year To Date"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton6.Location = New Point(158, 101)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(124, 21)
        RadioButton6.TabIndex = 14
        RadioButton6.TabStop = True
        RadioButton6.Text = "Last Full Quarter"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton7.Location = New Point(158, 78)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(101, 21)
        RadioButton7.TabIndex = 13
        RadioButton7.TabStop = True
        RadioButton7.Text = "Last Quarter"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button7)
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton6)
        GroupBox1.Controls.Add(RadioButton7)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Location = New Point(15, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(405, 178)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        ' 
        ' Button7
        ' 
        'Button7.BackgroundImage = My.Resources.Resources.icons8_calculator_64
        Button7.BackgroundImageLayout = ImageLayout.Center
        Button7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.Location = New Point(314, 64)
        Button7.Name = "Button7"
        Button7.Size = New Size(64, 81)
        Button7.TabIndex = 33
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(295, 357)
        Button10.Name = "Button10"
        Button10.Size = New Size(125, 43)
        Button10.TabIndex = 40
        Button10.Text = "Export to Excel"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(156, 357)
        Button9.Name = "Button9"
        Button9.Size = New Size(125, 43)
        Button9.TabIndex = 39
        Button9.Text = "Cancel"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(17, 357)
        Button8.Name = "Button8"
        Button8.Size = New Size(125, 43)
        Button8.TabIndex = 38
        Button8.Text = "Print List"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.HotTrack
        Label10.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(318, 403)
        Label10.Name = "Label10"
        Label10.Padding = New Padding(2)
        Label10.Size = New Size(86, 21)
        Label10.TabIndex = 41
        Label10.Text = "Exporting......"
        ' 
        ' frmTests
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(946, 457)
        Controls.Add(Label10)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Name = "frmTests"
        Text = "frmTests"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label10 As Label
End Class
