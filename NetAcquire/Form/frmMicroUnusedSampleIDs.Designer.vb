<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMicroUnusedSampleIDs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMicroUnusedSampleIDs))
        btnCancel = New Button()
        btnCalculate = New Button()
        GroupBox1 = New GroupBox()
        rdSIDs = New RadioButton()
        rdDates = New RadioButton()
        txtTo = New TextBox()
        txtFrom = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.TopCenter
        btnCancel.Location = New Point(385, 30)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(70, 73)
        btnCancel.TabIndex = 40
        btnCancel.Text = "&Cancel"
        btnCancel.TextAlign = ContentAlignment.BottomCenter
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.ButtonFace
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.Image = CType(resources.GetObject("btnCalculate.Image"), Image)
        btnCalculate.ImageAlign = ContentAlignment.TopCenter
        btnCalculate.Location = New Point(273, 30)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(84, 73)
        btnCalculate.TabIndex = 38
        btnCalculate.Text = "Calculate"
        btnCalculate.TextAlign = ContentAlignment.BottomCenter
        btnCalculate.TextImageRelation = TextImageRelation.ImageAboveText
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(rdSIDs)
        GroupBox1.Controls.Add(rdDates)
        GroupBox1.Controls.Add(txtTo)
        GroupBox1.Controls.Add(txtFrom)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Location = New Point(11, 19)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(222, 104)
        GroupBox1.TabIndex = 37
        GroupBox1.TabStop = False
        ' 
        ' rdSIDs
        ' 
        rdSIDs.AutoSize = True
        rdSIDs.FlatStyle = FlatStyle.Popup
        rdSIDs.Location = New Point(105, 0)
        rdSIDs.Name = "rdSIDs"
        rdSIDs.Size = New Size(115, 19)
        rdSIDs.TabIndex = 30
        rdSIDs.TabStop = True
        rdSIDs.Text = "Sample Numbers"
        rdSIDs.UseVisualStyleBackColor = True
        ' 
        ' rdDates
        ' 
        rdDates.AutoSize = True
        rdDates.CheckAlign = ContentAlignment.MiddleRight
        rdDates.Checked = True
        rdDates.FlatStyle = FlatStyle.Popup
        rdDates.Location = New Point(0, 0)
        rdDates.Name = "rdDates"
        rdDates.Size = New Size(101, 19)
        rdDates.TabIndex = 29
        rdDates.TabStop = True
        rdDates.Text = "Between Dates"
        rdDates.UseVisualStyleBackColor = True
        ' 
        ' txtTo
        ' 
        txtTo.BorderStyle = BorderStyle.FixedSingle
        txtTo.Location = New Point(56, 54)
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(99, 23)
        txtTo.TabIndex = 3
        ' 
        ' txtFrom
        ' 
        txtFrom.BorderStyle = BorderStyle.FixedSingle
        txtFrom.Location = New Point(56, 25)
        txtFrom.Name = "txtFrom"
        txtFrom.Size = New Size(99, 23)
        txtFrom.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 15)
        Label2.TabIndex = 1
        Label2.Text = "To"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 0
        Label1.Text = "From"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(11, 129)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(444, 368)
        TextBox3.TabIndex = 41
        ' 
        ' frmMicroUnusedSampleIDs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(493, 577)
        Controls.Add(TextBox3)
        Controls.Add(btnCancel)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox1)
        Name = "frmMicroUnusedSampleIDs"
        Text = "frmMicroUnusedSampleIDsvb"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdSIDs As RadioButton
    Friend WithEvents rdDates As RadioButton
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
