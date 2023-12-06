<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollatedReport
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
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Print = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        'CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(532, 58)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Between Dates"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Location = New Point(550, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(285, 58)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Clinician"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(6, 21)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(273, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(9, 21)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 2
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(265, 20)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(250, 27)
        DateTimePicker2.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 76)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1018, 570)
        DataGridView1.TabIndex = 2
        ' 
        ' Print
        ' 
        Print.Location = New Point(1053, 208)
        Print.Name = "Print"
        Print.Size = New Size(94, 91)
        Print.TabIndex = 3
        Print.Text = "Print"
        Print.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1053, 305)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 91)
        Button2.TabIndex = 4
        Button2.Text = "Export to Excel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1053, 555)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 91)
        Button3.TabIndex = 5
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmCollatedReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1161, 658)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Print)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmCollatedReport"
        Text = "frmCollatedReport"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        'CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Print As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
