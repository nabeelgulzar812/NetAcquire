<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScan1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScan1))
        btnExit = New Button()
        btnSave = New Button()
        btnBrowse = New Button()
        btnScan = New Button()
        TextBox2 = New TextBox()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label3 = New Label()
        cmbResolution = New ComboBox()
        Label2 = New Label()
        txtSampleID = New TextBox()
        Label1 = New Label()
        txtSampleID1 = New TextBox()
        Label4 = New Label()
        GroupBox2.SuspendLayout()
        'CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ButtonFace
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(590, 478)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(85, 81)
        btnExit.TabIndex = 17
        btnExit.Text = "&Exit"
        btnExit.TextAlign = ContentAlignment.BottomCenter
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.ButtonFace
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.Location = New Point(590, 296)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(85, 81)
        btnSave.TabIndex = 16
        btnSave.Text = "&Save"
        btnSave.TextAlign = ContentAlignment.BottomCenter
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.ButtonFace
        btnBrowse.FlatStyle = FlatStyle.Popup
        btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), Image)
        btnBrowse.Location = New Point(590, 209)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(85, 81)
        btnBrowse.TabIndex = 15
        btnBrowse.Text = "&Browse"
        btnBrowse.TextAlign = ContentAlignment.BottomCenter
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnScan
        ' 
        btnScan.BackColor = SystemColors.ButtonFace
        btnScan.FlatStyle = FlatStyle.Popup
        btnScan.Image = CType(resources.GetObject("btnScan.Image"), Image)
        btnScan.Location = New Point(590, 88)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(85, 81)
        btnScan.TabIndex = 14
        btnScan.Text = "&Scan"
        btnScan.TextAlign = ContentAlignment.BottomCenter
        btnScan.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(18, 538)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(523, 23)
        TextBox2.TabIndex = 13
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Location = New Point(18, 168)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(523, 370)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "From a File"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(6, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(511, 345)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(cmbResolution)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(15, 60)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(526, 100)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "From Scanner"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.FlatStyle = FlatStyle.Popup
        RadioButton4.Location = New Point(390, 80)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(60, 19)
        RadioButton4.TabIndex = 9
        RadioButton4.Text = "Colour"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Checked = True
        RadioButton3.FlatStyle = FlatStyle.Popup
        RadioButton3.Location = New Point(307, 80)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(48, 19)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Grey"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.FlatStyle = FlatStyle.Popup
        RadioButton1.Location = New Point(230, 80)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(47, 19)
        RadioButton1.TabIndex = 6
        RadioButton1.Text = "B/W"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonFace
        Label3.Location = New Point(230, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 5
        Label3.Text = "Pixel Type"
        ' 
        ' cmbResolution
        ' 
        cmbResolution.FormattingEnabled = True
        cmbResolution.Location = New Point(8, 69)
        cmbResolution.Name = "cmbResolution"
        cmbResolution.Size = New Size(195, 23)
        cmbResolution.TabIndex = 4
        cmbResolution.Text = "cmbResolution"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Location = New Point(7, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 3
        Label2.Text = "Resolution"
        ' 
        ' txtSampleID
        ' 
        txtSampleID.BorderStyle = BorderStyle.FixedSingle
        txtSampleID.Location = New Point(245, -40)
        txtSampleID.Name = "txtSampleID"
        txtSampleID.Size = New Size(137, 23)
        txtSampleID.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Location = New Point(161, -36)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 9
        Label1.Text = "Sample ID"
        ' 
        ' txtSampleID1
        ' 
        txtSampleID1.BorderStyle = BorderStyle.FixedSingle
        txtSampleID1.Location = New Point(233, 24)
        txtSampleID1.Name = "txtSampleID1"
        txtSampleID1.Size = New Size(137, 23)
        txtSampleID1.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonFace
        Label4.Location = New Point(158, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 18
        Label4.Text = "Sample ID"
        ' 
        ' frmScan1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(971, 707)
        Controls.Add(txtSampleID1)
        Controls.Add(Label4)
        Controls.Add(btnExit)
        Controls.Add(btnSave)
        Controls.Add(btnBrowse)
        Controls.Add(btnScan)
        Controls.Add(TextBox2)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtSampleID)
        Controls.Add(Label1)
        ForeColor = Color.Black
        Name = "frmScan1"
        Text = "frmScan1"
        GroupBox2.ResumeLayout(False)
        'CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbResolution As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSampleID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSampleID1 As TextBox
    Friend WithEvents Label4 As Label
End Class
