<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockControl
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
        Dim TreeNode1 As TreeNode = New TreeNode("Sample Node")
        Dim TreeNode2 As TreeNode = New TreeNode("Sample Node", New TreeNode() {TreeNode1})
        Dim TreeNode3 As TreeNode = New TreeNode("Sample Node", New TreeNode() {TreeNode2})
        Dim TreeNode4 As TreeNode = New TreeNode("Sample Node")
        btnAdd = New Button()
        ListBox1 = New ListBox()
        chkMonitor = New CheckBox()
        Label1 = New Label()
        txtCurrentStock = New TextBox()
        txtEachAssay = New TextBox()
        Label2 = New Label()
        txtAlarmAssays = New TextBox()
        Label3 = New Label()
        TreeView1 = New TreeView()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ButtonFace
        btnAdd.Location = New Point(90, 12)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 27)
        btnAdd.TabIndex = 0
        btnAdd.Text = "&Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(15, 39)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 304)
        ListBox1.TabIndex = 1
        ' 
        ' chkMonitor
        ' 
        chkMonitor.AutoSize = True
        chkMonitor.BackColor = SystemColors.ButtonFace
        chkMonitor.CheckAlign = ContentAlignment.MiddleRight
        chkMonitor.FlatStyle = FlatStyle.Popup
        chkMonitor.Location = New Point(17, 345)
        chkMonitor.Name = "chkMonitor"
        chkMonitor.Size = New Size(148, 19)
        chkMonitor.TabIndex = 2
        chkMonitor.Text = "Monitor Reagent Usage"
        chkMonitor.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Location = New Point(18, 367)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 3
        Label1.Text = "Current Stock"
        ' 
        ' txtCurrentStock
        ' 
        txtCurrentStock.BorderStyle = BorderStyle.None
        txtCurrentStock.Location = New Point(106, 365)
        txtCurrentStock.Multiline = True
        txtCurrentStock.Name = "txtCurrentStock"
        txtCurrentStock.Size = New Size(59, 18)
        txtCurrentStock.TabIndex = 4
        ' 
        ' txtEachAssay
        ' 
        txtEachAssay.BorderStyle = BorderStyle.None
        txtEachAssay.Location = New Point(353, 344)
        txtEachAssay.Multiline = True
        txtEachAssay.Name = "txtEachAssay"
        txtEachAssay.Size = New Size(59, 18)
        txtEachAssay.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Location = New Point(256, 346)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 5
        Label2.Text = "Each Assay uses"
        ' 
        ' txtAlarmAssays
        ' 
        txtAlarmAssays.BorderStyle = BorderStyle.None
        txtAlarmAssays.Location = New Point(353, 364)
        txtAlarmAssays.Multiline = True
        txtAlarmAssays.Name = "txtAlarmAssays"
        txtAlarmAssays.Size = New Size(59, 18)
        txtAlarmAssays.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonFace
        Label3.Location = New Point(197, 364)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 15)
        Label3.TabIndex = 7
        Label3.Text = "Alarm when stock less than"
        ' 
        ' TreeView1
        ' 
        TreeView1.BorderStyle = BorderStyle.FixedSingle
        TreeView1.Location = New Point(214, 12)
        TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "Sample Node"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "Sample Node"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "Sample Node"
        TreeNode4.Name = "Node3"
        TreeNode4.Text = "Sample Node"
        TreeView1.Nodes.AddRange(New TreeNode() {TreeNode3, TreeNode4})
        TreeView1.Size = New Size(234, 331)
        TreeView1.TabIndex = 9
        ' 
        ' frmStockControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(482, 394)
        Controls.Add(TreeView1)
        Controls.Add(txtAlarmAssays)
        Controls.Add(Label3)
        Controls.Add(txtEachAssay)
        Controls.Add(Label2)
        Controls.Add(txtCurrentStock)
        Controls.Add(Label1)
        Controls.Add(chkMonitor)
        Controls.Add(ListBox1)
        Controls.Add(btnAdd)
        Name = "frmStockControl"
        Text = "frmStockControl"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents chkMonitor As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentStock As TextBox
    Friend WithEvents txtEachAssay As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAlarmAssays As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TreeView1 As TreeView
End Class
