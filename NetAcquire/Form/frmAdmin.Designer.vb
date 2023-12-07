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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtAutologoff = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMemberoff = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DomainUpDown2 = New System.Windows.Forms.DomainUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.chkNumaric = New System.Windows.Forms.CheckBox()
        Me.chkUpper = New System.Windows.Forms.CheckBox()
        Me.chkAlpha = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.g = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdChangePassword = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.g, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.txtAutologoff)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbMemberoff)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(317, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New User"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(190, 169)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 22)
        Me.NumericUpDown1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(232, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Minutes"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(225, 68)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(81, 64)
        Me.cmdAdd.TabIndex = 9
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtAutologoff
        '
        Me.txtAutologoff.Location = New System.Drawing.Point(133, 168)
        Me.txtAutologoff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAutologoff.Name = "txtAutologoff"
        Me.txtAutologoff.Size = New System.Drawing.Size(51, 22)
        Me.txtAutologoff.TabIndex = 7
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(21, 164)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(75, 22)
        Me.txtCode.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(133, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Auto Log Off"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(27, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Code"
        '
        'cmbMemberoff
        '
        Me.cmbMemberoff.FormattingEnabled = True
        Me.cmbMemberoff.Location = New System.Drawing.Point(21, 106)
        Me.cmbMemberoff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMemberoff.Name = "cmbMemberoff"
        Me.cmbMemberoff.Size = New System.Drawing.Size(188, 24)
        Me.cmbMemberoff.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(21, 46)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(188, 22)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Member Of"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 30)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "System Roles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(575, 30)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(223, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "System Rights"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(804, 37)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 24)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "System Rights"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DomainUpDown2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chkShow)
        Me.GroupBox2.Controls.Add(Me.chkNumaric)
        Me.GroupBox2.Controls.Add(Me.chkUpper)
        Me.GroupBox2.Controls.Add(Me.chkAlpha)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 70)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(671, 158)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Local Policy"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(553, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 28)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(359, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Password can be Re-Used"
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.Location = New System.Drawing.Point(224, 123)
        Me.DomainUpDown2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(46, 22)
        Me.DomainUpDown2.TabIndex = 7
        Me.DomainUpDown2.Text = "DomainUpDown2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(198, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Minimum Password Length"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(6, 98)
        Me.chkShow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(134, 20)
        Me.chkShow.TabIndex = 4
        Me.chkShow.Text = "Show User Name"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'chkNumaric
        '
        Me.chkNumaric.AutoSize = True
        Me.chkNumaric.Location = New System.Drawing.Point(6, 74)
        Me.chkNumaric.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNumaric.Name = "chkNumaric"
        Me.chkNumaric.Size = New System.Drawing.Size(188, 20)
        Me.chkNumaric.TabIndex = 3
        Me.chkNumaric.Text = "Include numeric characters"
        Me.chkNumaric.UseVisualStyleBackColor = True
        '
        'chkUpper
        '
        Me.chkUpper.AutoSize = True
        Me.chkUpper.Location = New System.Drawing.Point(6, 50)
        Me.chkUpper.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkUpper.Name = "chkUpper"
        Me.chkUpper.Size = New System.Drawing.Size(163, 20)
        Me.chkUpper.TabIndex = 2
        Me.chkUpper.Text = "Upper/Lower case mix"
        Me.chkUpper.UseVisualStyleBackColor = True
        '
        'chkAlpha
        '
        Me.chkAlpha.AutoSize = True
        Me.chkAlpha.Location = New System.Drawing.Point(6, 29)
        Me.chkAlpha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAlpha.Name = "chkAlpha"
        Me.chkAlpha.Size = New System.Drawing.Size(176, 20)
        Me.chkAlpha.TabIndex = 1
        Me.chkAlpha.Text = "Include Alpha characters"
        Me.chkAlpha.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(359, 8)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(234, 86)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Passwords Expire after"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(113, 51)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(65, 20)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Never"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(113, 21)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(84, 20)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "180 Days"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 51)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 20)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "90 Days"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 21)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(77, 20)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "60 Days"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'g
        '
        Me.g.AllowUserToAddRows = False
        Me.g.AllowUserToDeleteRows = False
        Me.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.g.Location = New System.Drawing.Point(12, 242)
        Me.g.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.g.Name = "g"
        Me.g.ReadOnly = True
        Me.g.RowHeadersWidth = 51
        Me.g.RowTemplate.Height = 29
        Me.g.Size = New System.Drawing.Size(801, 434)
        Me.g.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "InUse"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Operator Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Code"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Member Of"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Log Of Delay"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Password"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'cmdChangePassword
        '
        Me.cmdChangePassword.Location = New System.Drawing.Point(831, 242)
        Me.cmdChangePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdChangePassword.Name = "cmdChangePassword"
        Me.cmdChangePassword.Size = New System.Drawing.Size(139, 85)
        Me.cmdChangePassword.TabIndex = 7
        Me.cmdChangePassword.Text = "Change Administrator Password"
        Me.cmdChangePassword.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(831, 578)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(110, 85)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Log Off Administrator"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(831, 488)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(110, 85)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(831, 351)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(58, 53)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "MoveUp"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(831, 409)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(58, 62)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "MoveDown"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 719)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdChangePassword)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAdmin"
        Me.Text = "frmAdmin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.g, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
