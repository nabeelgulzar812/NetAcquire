<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActivityLog
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
        Label1 = New Label()
        cmbFind = New Button()
        cmdAdvanceFind = New Button()
        cmbClear = New Button()
        TextBox1 = New TextBox()
        Grid = New DataGridView()
        Panel1 = New Panel()
        Label13 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        ComboBox7 = New ComboBox()
        ComboBox8 = New ComboBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        Button1 = New Button()
        Button2 = New Button()
        'CType(Grid, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 0
        Label1.Text = "Find Log"
        ' 
        ' cmbFind
        ' 
        cmbFind.Location = New Point(462, 21)
        cmbFind.Name = "cmbFind"
        cmbFind.Size = New Size(120, 29)
        cmbFind.TabIndex = 1
        cmbFind.Text = "Find"
        cmbFind.UseVisualStyleBackColor = True
        ' 
        ' cmdAdvanceFind
        ' 
        cmdAdvanceFind.Location = New Point(714, 21)
        cmdAdvanceFind.Name = "cmdAdvanceFind"
        cmdAdvanceFind.Size = New Size(120, 29)
        cmdAdvanceFind.TabIndex = 2
        cmdAdvanceFind.Text = "Advance Find"
        cmdAdvanceFind.UseVisualStyleBackColor = True
        ' 
        ' cmbClear
        ' 
        cmbClear.Location = New Point(588, 21)
        cmbClear.Name = "cmbClear"
        cmbClear.Size = New Size(120, 29)
        cmbClear.TabIndex = 3
        cmbClear.Text = "Clear"
        cmbClear.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(84, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(372, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Grid
        ' 
        Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Grid.Location = New Point(17, 58)
        Grid.Name = "Grid"
        Grid.RowHeadersWidth = 51
        Grid.RowTemplate.Height = 29
        Grid.Size = New Size(1242, 613)
        Grid.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(ComboBox7)
        Panel1.Controls.Add(ComboBox8)
        Panel1.Controls.Add(ComboBox6)
        Panel1.Controls.Add(ComboBox5)
        Panel1.Controls.Add(ComboBox4)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label)
        Panel1.Location = New Point(449, 133)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(447, 463)
        Panel1.TabIndex = 6
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(13, 391)
        Label13.Name = "Label13"
        Label13.Size = New Size(92, 20)
        Label13.TabIndex = 12
        Label13.Text = "App. Version"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(13, 357)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 20)
        Label9.TabIndex = 11
        Label9.Text = "Machine"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(39, 323)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 20)
        Label10.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(39, 290)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 20)
        Label11.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 20)
        Label5.TabIndex = 7
        Label5.Text = "User Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 20)
        Label6.TabIndex = 6
        Label6.Text = "Notes"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 187)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 20)
        Label7.TabIndex = 5
        Label7.Text = "Reason"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(13, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 20)
        Label8.TabIndex = 4
        Label8.Text = "Action"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 3
        Label4.Text = "Action Type"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 2
        Label3.Text = "Patient ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 1
        Label2.Text = "Submission ID"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(13, 13)
        Label.Name = "Label"
        Label.Size = New Size(78, 20)
        Label.TabIndex = 0
        Label.Text = "Sample ID"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(128, 11)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(136, 27)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(127, 48)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(136, 27)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(128, 82)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(136, 27)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(127, 218)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(295, 27)
        TextBox7.TabIndex = 19
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(126, 185)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(295, 27)
        TextBox8.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(127, 116)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(294, 28)
        ComboBox2.TabIndex = 20
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(126, 150)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(294, 28)
        ComboBox3.TabIndex = 21
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(126, 252)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(294, 28)
        ComboBox4.TabIndex = 22
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(126, 286)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(112, 28)
        ComboBox5.TabIndex = 23
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(126, 320)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(112, 28)
        ComboBox6.TabIndex = 24
        ' 
        ' ComboBox7
        ' 
        ComboBox7.FormattingEnabled = True
        ComboBox7.Location = New Point(125, 388)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(294, 28)
        ComboBox7.TabIndex = 26
        ' 
        ' ComboBox8
        ' 
        ComboBox8.FormattingEnabled = True
        ComboBox8.Location = New Point(126, 354)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New Size(294, 28)
        ComboBox8.TabIndex = 25
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 286)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(88, 24)
        CheckBox1.TabIndex = 27
        CheckBox1.Text = "For Date"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(13, 319)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(83, 24)
        CheckBox2.TabIndex = 28
        CheckBox2.Text = "To Date"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(243, 424)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 29)
        Button1.TabIndex = 7
        Button1.Text = "Find"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(335, 424)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 29)
        Button2.TabIndex = 29
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1278, 680)
        Controls.Add(Panel1)
        Controls.Add(Grid)
        Controls.Add(TextBox1)
        Controls.Add(cmbClear)
        Controls.Add(cmdAdvanceFind)
        Controls.Add(cmbFind)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Activity Log Viewer"
        'CType(Grid, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFind As Button
    Friend WithEvents cmdAdvanceFind As Button
    Friend WithEvents cmbClear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Grid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
