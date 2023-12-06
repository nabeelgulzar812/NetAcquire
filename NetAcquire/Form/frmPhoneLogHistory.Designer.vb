
Partial Class frmPhoneLogHistory
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        cmbFind = New Button()
        DataGridView1 = New DataGridView()
        Button9 = New Button()
        PictureBox1 = New PictureBox()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        'CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(253, 17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(214, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 20)
        Label1.TabIndex = 6
        Label1.Text = "Phone Log History for Sample ID"
        ' 
        ' cmbFind
        ' 
        cmbFind.Location = New Point(473, 16)
        cmbFind.Name = "cmbFind"
        cmbFind.Size = New Size(120, 29)
        cmbFind.TabIndex = 7
        cmbFind.Text = "Find"
        cmbFind.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 51)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1074, 348)
        DataGridView1.TabIndex = 8
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(970, 405)
        Button9.Name = "Button9"
        Button9.Size = New Size(125, 43)
        Button9.TabIndex = 40
        Button9.Text = "Cancel"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        'PictureBox1.Image = My.Resources.Resources.icons8_tick_24
        PictureBox1.Location = New Point(716, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 25)
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' frmPhoneLogHistory
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1107, 457)
        Controls.Add(PictureBox1)
        Controls.Add(Button9)
        Controls.Add(DataGridView1)
        Controls.Add(cmbFind)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "frmPhoneLogHistory"
        Text = "frmPhoneLogHistory"
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        'CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFind As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
