<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        'components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtName = New TextBox()
        cmbMemberoff = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        txtCode = New TextBox()
        txtAutologoff = New TextBox()
        cmdAdd = New Button()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        chkAlpha = New CheckBox()
        chkUpper = New CheckBox()
        chkNumaric = New CheckBox()
        chkShow = New CheckBox()
        Label6 = New Label()
        Label7 = New Label()
        DomainUpDown2 = New DomainUpDown()
        Label8 = New Label()
        Label9 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        g = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        cmdChangePassword = New Button()
        cmdCancel = New Button()
        cmdSave = New Button()
        NumericUpDown1 = New NumericUpDown()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        'CType(g, ComponentModel.ISupportInitialize).BeginInit()
        'CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(cmdAdd)
        GroupBox1.Controls.Add(txtAutologoff)
        GroupBox1.Controls.Add(txtCode)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(cmbMemberoff)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(317, 259)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add New User"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(21, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(21, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 23)
        Label2.TabIndex = 1
        Label2.Text = "Member Of"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(21, 58)
        txtName.Name = "txtName"
        txtName.Size = New Size(188, 27)
        txtName.TabIndex = 2
        ' 
        ' cmbMemberoff
        ' 
        cmbMemberoff.FormattingEnabled = True
        cmbMemberoff.Location = New Point(21, 133)
        cmbMemberoff.Name = "cmbMemberoff"
        cmbMemberoff.Size = New Size(188, 28)
        cmbMemberoff.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(27, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 23)
        Label3.TabIndex = 4
        Label3.Text = "Code"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(133, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 23)
        Label4.TabIndex = 5
        Label4.Text = "Auto Log Off"
        ' 
        ' txtCode
        ' 
        txtCode.Location = New Point(21, 205)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(75, 27)
        txtCode.TabIndex = 6
        ' 
        ' txtAutologoff
        ' 
        txtAutologoff.Location = New Point(133, 210)
        txtAutologoff.Name = "txtAutologoff"
        txtAutologoff.Size = New Size(51, 27)
        txtAutologoff.TabIndex = 7
        ' 
        ' cmdAdd
        ' 
        cmdAdd.Location = New Point(225, 85)
        cmdAdd.Name = "cmdAdd"
        cmdAdd.Size = New Size(81, 80)
        cmdAdd.TabIndex = 9
        cmdAdd.Text = "Add"
        cmdAdd.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(232, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 10
        Label5.Text = "Minutes"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(346, 38)
        Button1.Name = "Button1"
        Button1.Size = New Size(223, 43)
        Button1.TabIndex = 2
        Button1.Text = "System Roles"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(575, 38)
        Button2.Name = "Button2"
        Button2.Size = New Size(223, 43)
        Button2.TabIndex = 3
        Button2.Text = "System Rights"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(804, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(215, 28)
        ComboBox1.TabIndex = 4
        ComboBox1.Text = "System Rights"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(DomainUpDown2)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(chkShow)
        GroupBox2.Controls.Add(chkNumaric)
        GroupBox2.Controls.Add(chkUpper)
        GroupBox2.Controls.Add(chkAlpha)
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Location = New Point(348, 87)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(671, 198)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Local Policy"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton4)
        GroupBox3.Controls.Add(RadioButton3)
        GroupBox3.Controls.Add(RadioButton2)
        GroupBox3.Controls.Add(RadioButton1)
        GroupBox3.Location = New Point(359, 10)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(234, 107)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Passwords Expire after"
        ' 
        ' chkAlpha
        ' 
        chkAlpha.AutoSize = True
        chkAlpha.Location = New Point(6, 36)
        chkAlpha.Name = "chkAlpha"
        chkAlpha.Size = New Size(193, 24)
        chkAlpha.TabIndex = 1
        chkAlpha.Text = "Include Alpha characters"
        chkAlpha.UseVisualStyleBackColor = True
        ' 
        ' chkUpper
        ' 
        chkUpper.AutoSize = True
        chkUpper.Location = New Point(6, 63)
        chkUpper.Name = "chkUpper"
        chkUpper.Size = New Size(179, 24)
        chkUpper.TabIndex = 2
        chkUpper.Text = "Upper/Lower case mix"
        chkUpper.UseVisualStyleBackColor = True
        ' 
        ' chkNumaric
        ' 
        chkNumaric.AutoSize = True
        chkNumaric.Location = New Point(6, 93)
        chkNumaric.Name = "chkNumaric"
        chkNumaric.Size = New Size(207, 24)
        chkNumaric.TabIndex = 3
        chkNumaric.Text = "Include numeric characters"
        chkNumaric.UseVisualStyleBackColor = True
        ' 
        ' chkShow
        ' 
        chkShow.AutoSize = True
        chkShow.Location = New Point(6, 123)
        chkShow.Name = "chkShow"
        chkShow.Size = New Size(144, 24)
        chkShow.TabIndex = 4
        chkShow.Text = "Show User Name"
        chkShow.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(186, 20)
        Label6.TabIndex = 5
        Label6.Text = "Minimum Password Length"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(198, 156)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 23)
        Label7.TabIndex = 6
        Label7.Text = "6"
        ' 
        ' DomainUpDown2
        ' 
        DomainUpDown2.Location = New Point(224, 154)
        DomainUpDown2.Name = "DomainUpDown2"
        DomainUpDown2.Size = New Size(46, 27)
        DomainUpDown2.TabIndex = 7
        DomainUpDown2.Text = "DomainUpDown2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(359, 157)
        Label8.Name = "Label8"
        Label8.Size = New Size(188, 20)
        Label8.TabIndex = 8
        Label8.Text = "Password can be Re-Used"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(553, 151)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 28)
        Label9.TabIndex = 9
        Label9.Text = "No"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(15, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(82, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "60 Days"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(15, 64)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(82, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "90 Days"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(113, 26)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(90, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "180 Days"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(113, 64)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(69, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "Never"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' g
        ' 
        g.AllowUserToAddRows = False
        g.AllowUserToDeleteRows = False
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        g.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        g.Location = New Point(12, 302)
        g.Name = "g"
        g.ReadOnly = True
        g.RowHeadersWidth = 51
        g.RowTemplate.Height = 29
        g.Size = New Size(801, 542)
        g.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "InUse"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Operator Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Code"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Member Of"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Log Of Delay"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Password"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' cmdChangePassword
        ' 
        cmdChangePassword.Location = New Point(831, 302)
        cmdChangePassword.Name = "cmdChangePassword"
        cmdChangePassword.Size = New Size(139, 106)
        cmdChangePassword.TabIndex = 7
        cmdChangePassword.Text = "Change Administrator Password"
        cmdChangePassword.UseVisualStyleBackColor = True
        ' 
        ' cmdCancel
        ' 
        cmdCancel.Location = New Point(831, 722)
        cmdCancel.Name = "cmdCancel"
        cmdCancel.Size = New Size(110, 106)
        cmdCancel.TabIndex = 8
        cmdCancel.Text = "Log Off Administrator"
        cmdCancel.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(831, 610)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(110, 106)
        cmdSave.TabIndex = 9
        cmdSave.Text = "Save"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(190, 211)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(40, 27)
        NumericUpDown1.TabIndex = 11
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(831, 439)
        Button3.Name = "Button3"
        Button3.Size = New Size(58, 66)
        Button3.TabIndex = 10
        Button3.Text = "MoveUp"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(831, 511)
        Button4.Name = "Button4"
        Button4.Size = New Size(58, 77)
        Button4.TabIndex = 11
        Button4.Text = "MoveDown"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1028, 849)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(cmdSave)
        Controls.Add(cmdCancel)
        Controls.Add(cmdChangePassword)
        Controls.Add(g)
        Controls.Add(GroupBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Name = "frmAdmin"
        Text = "frmAdmin"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        'CType(g, ComponentModel.ISupportInitialize).EndInit()
        'CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMemberoff As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtAutologoff As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents chkNumaric As CheckBox
    Friend WithEvents chkUpper As CheckBox
    Friend WithEvents chkAlpha As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DomainUpDown2 As DomainUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents g As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents cmdChangePassword As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
