<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListsGeneric
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.g = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdMoveup = New System.Windows.Forms.Button()
        Me.cmdMovedown = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.g, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.txtText)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Generic"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Text"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(0, 39)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(232, 22)
        Me.txtCode.TabIndex = 2
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(248, 39)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(232, 22)
        Me.txtText.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(499, 18)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(73, 61)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'g
        '
        Me.g.AllowUserToAddRows = False
        Me.g.AllowUserToDeleteRows = False
        Me.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.g.Location = New System.Drawing.Point(22, 102)
        Me.g.Name = "g"
        Me.g.ReadOnly = True
        Me.g.RowHeadersWidth = 51
        Me.g.RowTemplate.Height = 24
        Me.g.Size = New System.Drawing.Size(592, 626)
        Me.g.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Text"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(635, 416)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(98, 73)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(635, 495)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(98, 73)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(635, 574)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 73)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(635, 653)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 73)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdMoveup
        '
        Me.cmdMoveup.Location = New System.Drawing.Point(620, 138)
        Me.cmdMoveup.Name = "cmdMoveup"
        Me.cmdMoveup.Size = New System.Drawing.Size(49, 73)
        Me.cmdMoveup.TabIndex = 6
        Me.cmdMoveup.Text = "Moveup"
        Me.cmdMoveup.UseVisualStyleBackColor = True
        '
        'cmdMovedown
        '
        Me.cmdMovedown.Location = New System.Drawing.Point(620, 217)
        Me.cmdMovedown.Name = "cmdMovedown"
        Me.cmdMovedown.Size = New System.Drawing.Size(49, 73)
        Me.cmdMovedown.TabIndex = 7
        Me.cmdMovedown.Text = "Move Down"
        Me.cmdMovedown.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(620, 23)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(113, 73)
        Me.cmdExport.TabIndex = 8
        Me.cmdExport.Text = "Export To Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(620, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(113, 27)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Exporting..."
        '
        'frmListsGeneric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 740)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdMovedown)
        Me.Controls.Add(Me.cmdMoveup)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmListsGeneric"
        Me.Text = "Netacquire frmListsGeneric"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.g, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents g As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdMoveup As Button
    Friend WithEvents cmdMovedown As Button
    Friend WithEvents cmdExport As Button
    Friend WithEvents TextBox3 As TextBox
End Class
