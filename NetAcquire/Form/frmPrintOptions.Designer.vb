<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintOptions))
        dt = New DateTimePicker()
        RadioButton5 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox1 = New GroupBox()
        nudTo = New NumericUpDown()
        nudFrom = New NumericUpDown()
        GroupBox2 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton2 = New RadioButton()
        btnCancel = New Button()
        btnCancel1 = New Button()
        btnStopPrint = New Button()
        GroupBox1.SuspendLayout()
        'CType(nudTo, ComponentModel.ISupportInitialize).BeginInit()
        'CType(nudFrom, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dt
        ' 
        dt.Format = DateTimePickerFormat.Short
        dt.Location = New Point(62, 53)
        dt.Name = "dt"
        dt.Size = New Size(92, 23)
        dt.TabIndex = 1
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.BackColor = SystemColors.ButtonFace
        RadioButton5.Checked = True
        RadioButton5.FlatStyle = FlatStyle.Popup
        RadioButton5.Location = New Point(296, 57)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(89, 19)
        RadioButton5.TabIndex = 30
        RadioButton5.TabStop = True
        RadioButton5.Text = "Biochemisty"
        RadioButton5.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackColor = SystemColors.ButtonFace
        RadioButton3.CheckAlign = ContentAlignment.MiddleRight
        RadioButton3.FlatStyle = FlatStyle.Popup
        RadioButton3.Location = New Point(193, 57)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(96, 19)
        RadioButton3.TabIndex = 29
        RadioButton3.Text = "Haematology"
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(nudTo)
        GroupBox1.Controls.Add(nudFrom)
        GroupBox1.Location = New Point(67, 128)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(222, 129)
        GroupBox1.TabIndex = 40
        GroupBox1.TabStop = False
        GroupBox1.Text = "Between Numbers"
        ' 
        ' nudTo
        ' 
        nudTo.BorderStyle = BorderStyle.FixedSingle
        nudTo.Location = New Point(56, 62)
        nudTo.Name = "nudTo"
        nudTo.Size = New Size(99, 23)
        nudTo.TabIndex = 1
        ' 
        ' nudFrom
        ' 
        nudFrom.BorderStyle = BorderStyle.FixedSingle
        nudFrom.Location = New Point(56, 33)
        nudFrom.Name = "nudFrom"
        nudFrom.Size = New Size(99, 23)
        nudFrom.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.FlatStyle = FlatStyle.Popup
        GroupBox2.Location = New Point(296, 128)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(193, 129)
        GroupBox2.TabIndex = 41
        GroupBox2.TabStop = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.FlatStyle = FlatStyle.Popup
        RadioButton1.Location = New Point(32, 43)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(77, 19)
        RadioButton1.TabIndex = 28
        RadioButton1.Text = "Only Valid"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.BackColor = Color.Transparent
        RadioButton4.FlatStyle = FlatStyle.Popup
        RadioButton4.Location = New Point(32, 66)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(38, 19)
        RadioButton4.TabIndex = 27
        RadioButton4.Text = "All"
        RadioButton4.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Checked = True
        RadioButton2.FlatStyle = FlatStyle.Popup
        RadioButton2.Location = New Point(32, 22)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(114, 19)
        RadioButton2.TabIndex = 26
        RadioButton2.TabStop = True
        RadioButton2.Text = "Valid, not Printed"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(112, 287)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(76, 73)
        btnCancel.TabIndex = 42
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnCancel1
        ' 
        btnCancel1.BackColor = SystemColors.ButtonFace
        btnCancel1.BackgroundImageLayout = ImageLayout.None
        btnCancel1.ImageAlign = ContentAlignment.TopCenter
        btnCancel1.Location = New Point(213, 287)
        btnCancel1.Name = "btnCancel1"
        btnCancel1.Size = New Size(76, 73)
        btnCancel1.TabIndex = 43
        btnCancel1.Text = "&Print"
        btnCancel1.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel1.UseVisualStyleBackColor = False
        ' 
        ' btnStopPrint
        ' 
        btnStopPrint.BackColor = SystemColors.ButtonFace
        btnStopPrint.BackgroundImageLayout = ImageLayout.None
        btnStopPrint.ImageAlign = ContentAlignment.TopCenter
        btnStopPrint.Location = New Point(319, 287)
        btnStopPrint.Name = "btnStopPrint"
        btnStopPrint.Size = New Size(76, 73)
        btnStopPrint.TabIndex = 44
        btnStopPrint.Text = "&Stop Print"
        btnStopPrint.TextImageRelation = TextImageRelation.ImageAboveText
        btnStopPrint.UseVisualStyleBackColor = False
        ' 
        ' frmPrintOptions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(506, 371)
        Controls.Add(btnStopPrint)
        Controls.Add(btnCancel1)
        Controls.Add(btnCancel)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton3)
        Controls.Add(dt)
        Name = "frmPrintOptions"
        Text = "frmPrintOptions"
        GroupBox1.ResumeLayout(False)
        'CType(nudTo, ComponentModel.ISupportInitialize).EndInit()
        'CType(nudFrom, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dt As DateTimePicker
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCancel1 As Button
    Friend WithEvents btnStopPrint As Button
End Class
