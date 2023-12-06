<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchives
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSampleID = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sample Number"
        '
        'txtSampleID
        '
        Me.txtSampleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSampleID.Location = New System.Drawing.Point(37, 51)
        Me.txtSampleID.Name = "txtSampleID"
        Me.txtSampleID.Size = New System.Drawing.Size(171, 30)
        Me.txtSampleID.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.Location = New System.Drawing.Point(294, 12)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.cmdCancel.Size = New System.Drawing.Size(141, 79)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(37, 97)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.Size = New System.Drawing.Size(1086, 296)
        Me.txtReport.TabIndex = 3
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1097, 97)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(26, 296)
        Me.VScrollBar1.TabIndex = 4
        '
        'frmArchives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1152, 449)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtSampleID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmArchives"
        Me.Text = "Netacquire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSampleID As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar

End Class
