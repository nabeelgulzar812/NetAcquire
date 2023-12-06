<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBioAbnormals
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
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        ProgressBar1 = New ProgressBar()
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label2 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        Label7 = New Label()
        Button7 = New Button()
        TextBox15 = New TextBox()
        TextBox16 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        GroupBox3 = New GroupBox()
        Label10 = New Label()
        Label11 = New Label()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(441, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(476, 625)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(400, 58)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(258, 21)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(121, 27)
        DateTimePicker2.TabIndex = 3
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(128, 21)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(121, 27)
        DateTimePicker1.TabIndex = 2
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 81)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(404, 13)
        ProgressBar1.TabIndex = 2
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TextBox13)
        GroupBox2.Controls.Add(TextBox14)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(TextBox11)
        GroupBox2.Controls.Add(TextBox12)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Location = New Point(13, 104)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(405, 344)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Analyte"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(20, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 17)
        Label5.TabIndex = 28
        Label5.Text = "Low"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(16, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 17)
        Label6.TabIndex = 27
        Label6.Text = "High"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(20, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 17)
        Label4.TabIndex = 26
        Label4.Text = "Low"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(16, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 17)
        Label3.TabIndex = 25
        Label3.Text = "High"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(197, 297)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(64, 27)
        TextBox7.TabIndex = 24
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(129, 297)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(64, 27)
        TextBox8.TabIndex = 23
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(61, 297)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(64, 27)
        TextBox9.TabIndex = 22
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(197, 267)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(64, 27)
        TextBox10.TabIndex = 21
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(129, 267)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(64, 27)
        TextBox11.TabIndex = 20
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(61, 267)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(64, 27)
        TextBox12.TabIndex = 19
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(197, 233)
        Button4.Name = "Button4"
        Button4.Size = New Size(64, 29)
        Button4.TabIndex = 18
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(129, 234)
        Button5.Name = "Button5"
        Button5.Size = New Size(64, 29)
        Button5.TabIndex = 17
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(61, 234)
        Button6.Name = "Button6"
        Button6.Size = New Size(64, 29)
        Button6.TabIndex = 16
        Button6.Text = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 15
        Label2.Text = "Flag Ranges"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(197, 156)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(64, 27)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(129, 156)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(64, 27)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(61, 156)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(64, 27)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(197, 126)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(64, 27)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(129, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(64, 27)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(61, 126)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(64, 27)
        TextBox1.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(197, 92)
        Button3.Name = "Button3"
        Button3.Size = New Size(64, 29)
        Button3.TabIndex = 8
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(129, 93)
        Button2.Name = "Button2"
        Button2.Size = New Size(64, 29)
        Button2.TabIndex = 7
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(61, 93)
        Button1.Name = "Button1"
        Button1.Size = New Size(64, 29)
        Button1.TabIndex = 6
        Button1.Text = "Male"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(103, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 20)
        Label1.TabIndex = 5
        Label1.Text = "Normal Ranges"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(56, 35)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(210, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(306, 156)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(63, 27)
        TextBox13.TabIndex = 30
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(306, 126)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(63, 27)
        TextBox14.TabIndex = 29
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(279, 103)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 20)
        Label7.TabIndex = 31
        Label7.Text = "De-Select Range"
        ' 
        ' Button7
        ' 
        'Button7.BackgroundImage = My.Resources.Resources.icons8_calculator_64
        Button7.BackgroundImageLayout = ImageLayout.Center
        Button7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.Location = New Point(305, 243)
        Button7.Name = "Button7"
        Button7.Size = New Size(64, 81)
        Button7.TabIndex = 32
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(124, 20)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(76, 27)
        TextBox15.TabIndex = 33
        ' 
        ' TextBox16
        ' 
        TextBox16.Location = New Point(289, 20)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(75, 27)
        TextBox16.TabIndex = 34
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(33, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 17)
        Label8.TabIndex = 33
        Label8.Text = "Under Range"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(206, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 17)
        Label9.TabIndex = 35
        Label9.Text = "Over Range"
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(13, 556)
        Button8.Name = "Button8"
        Button8.Size = New Size(125, 43)
        Button8.TabIndex = 33
        Button8.Text = "Print List"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(152, 556)
        Button9.Name = "Button9"
        Button9.Size = New Size(125, 43)
        Button9.TabIndex = 36
        Button9.Text = "Cancel"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(291, 556)
        Button10.Name = "Button10"
        Button10.Size = New Size(125, 43)
        Button10.TabIndex = 37
        Button10.Text = "Export to Excel"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(TextBox16)
        GroupBox3.Controls.Add(TextBox15)
        GroupBox3.Location = New Point(15, 471)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(399, 59)
        GroupBox3.TabIndex = 38
        GroupBox3.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.HotTrack
        Label10.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(310, 603)
        Label10.Name = "Label10"
        Label10.Padding = New Padding(2)
        Label10.Size = New Size(86, 21)
        Label10.TabIndex = 36
        Label10.Text = "Exporting......"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(8, 24)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 20)
        Label11.TabIndex = 33
        Label11.Text = "Between Dates"
        ' 
        ' frmBioAbnormals
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(910, 649)
        Controls.Add(Label10)
        Controls.Add(GroupBox3)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(GroupBox2)
        Controls.Add(ProgressBar1)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Name = "frmBioAbnormals"
        Text = "frmBioAbnormals"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
