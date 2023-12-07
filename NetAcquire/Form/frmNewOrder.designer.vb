<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtSampleID = New TextBox()
        tinput = New TextBox()
        chkAddOn = New CheckBox()
        oFasting = New RadioButton()
        oRandom = New RadioButton()
        chkUrgent = New CheckBox()
        cmdSave = New Button()
        cmdClear = New Button()
        cmdExit = New Button()
        GroupBox1 = New GroupBox()
        optShort = New RadioButton()
        optLong = New RadioButton()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        lstSerumPanel = New ListBox()
        TextBox7 = New TextBox()
        lstSerumTests = New ListBox()
        lstBloodTests = New ListBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        lstUrinePanel = New ListBox()
        TextBox10 = New TextBox()
        lstUrineTests = New ListBox()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        TextBox15 = New TextBox()
        TextBox16 = New TextBox()
        lstCSFTests = New ListBox()
        lstimmunoTests = New ListBox()
        lstImmnoCodes = New ListBox()
        TextBox17 = New TextBox()
        TextBox18 = New TextBox()
        ListBox1 = New ListBox()
        LstHaePanel = New ListBox()
        TextBox19 = New TextBox()
        TextBox20 = New TextBox()
        TextBox21 = New TextBox()
        TextBox22 = New TextBox()
        TextBox23 = New TextBox()
        lstSweatTests = New ListBox()
        lstCoagTests = New ListBox()
        lstCoag = New ListBox()
        lstHaeTests = New ListBox()
        Button4 = New Button()
        lstExistingBio = New ListBox()
        lstSerumCodes = New ListBox()
        lstBloodCodes = New ListBox()
        lstUrineCodes = New ListBox()
        lstCSFCodes = New ListBox()
        lstSweatCodes = New ListBox()
        Button5 = New Button()
        pBar = New ProgressBar()
        GroupBox2 = New GroupBox()
        Button6 = New Button()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 23)
        Label1.TabIndex = 0
        Label1.Text = "Sample Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(244, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 23)
        Label2.TabIndex = 1
        Label2.Text = "Test Order"
        ' 
        ' txtSampleID
        ' 
        txtSampleID.Location = New Point(50, 38)
        txtSampleID.Name = "txtSampleID"
        txtSampleID.Size = New Size(174, 27)
        txtSampleID.TabIndex = 2
        ' 
        ' tinput
        ' 
        tinput.Location = New Point(244, 38)
        tinput.Name = "tinput"
        tinput.Size = New Size(137, 27)
        tinput.TabIndex = 3
        ' 
        ' chkAddOn
        ' 
        chkAddOn.AutoSize = True
        chkAddOn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        chkAddOn.Location = New Point(420, 38)
        chkAddOn.Name = "chkAddOn"
        chkAddOn.Size = New Size(173, 29)
        chkAddOn.TabIndex = 4
        chkAddOn.Text = "Add On Request"
        chkAddOn.UseVisualStyleBackColor = True
        ' 
        ' oFasting
        ' 
        oFasting.AutoSize = True
        oFasting.Location = New Point(145, 82)
        oFasting.Name = "oFasting"
        oFasting.Size = New Size(76, 24)
        oFasting.TabIndex = 5
        oFasting.TabStop = True
        oFasting.Text = "Fasting"
        oFasting.UseVisualStyleBackColor = True
        ' 
        ' oRandom
        ' 
        oRandom.AutoSize = True
        oRandom.Location = New Point(53, 82)
        oRandom.Name = "oRandom"
        oRandom.Size = New Size(86, 24)
        oRandom.TabIndex = 6
        oRandom.TabStop = True
        oRandom.Text = "Random"
        oRandom.UseVisualStyleBackColor = True
        ' 
        ' chkUrgent
        ' 
        chkUrgent.AutoSize = True
        chkUrgent.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        chkUrgent.Location = New Point(145, 115)
        chkUrgent.Name = "chkUrgent"
        chkUrgent.Size = New Size(88, 27)
        chkUrgent.TabIndex = 7
        chkUrgent.Text = "Urgent"
        chkUrgent.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.ImageAlign = ContentAlignment.BottomCenter
        cmdSave.Location = New Point(608, 38)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(101, 83)
        cmdSave.TabIndex = 9
        cmdSave.Text = "&Save Requests"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' cmdClear
        ' 
        cmdClear.Location = New Point(726, 38)
        cmdClear.Name = "cmdClear"
        cmdClear.Size = New Size(108, 83)
        cmdClear.TabIndex = 10
        cmdClear.Text = "Clear"
        cmdClear.UseVisualStyleBackColor = True
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(843, 38)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(113, 83)
        cmdExit.TabIndex = 11
        cmdExit.Text = "Exit"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(optShort)
        GroupBox1.Controls.Add(optLong)
        GroupBox1.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(986, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(91, 97)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Test Name"
        ' 
        ' optShort
        ' 
        optShort.AutoSize = True
        optShort.Location = New Point(6, 59)
        optShort.Name = "optShort"
        optShort.Size = New Size(60, 21)
        optShort.TabIndex = 1
        optShort.TabStop = True
        optShort.Text = "Short"
        optShort.UseVisualStyleBackColor = True
        ' 
        ' optLong
        ' 
        optLong.AutoSize = True
        optLong.Location = New Point(6, 32)
        optLong.Name = "optLong"
        optLong.Size = New Size(58, 21)
        optLong.TabIndex = 0
        optLong.TabStop = True
        optLong.Text = "Long"
        optLong.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(264, 108)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(327, 41)
        TextBox3.TabIndex = 13
        TextBox3.Text = "Glucose bottle is in use"
        TextBox3.Visible = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(41, 159)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(399, 35)
        TextBox4.TabIndex = 14
        TextBox4.Text = "                          Serum"
        TextBox4.Visible = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(446, 159)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(145, 35)
        TextBox5.TabIndex = 15
        TextBox5.Text = "Blood"
        TextBox5.Visible = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(43, 200)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(127, 35)
        TextBox6.TabIndex = 16
        TextBox6.Text = "Panels"
        TextBox6.Visible = False
        ' 
        ' lstSerumPanel
        ' 
        lstSerumPanel.FormattingEnabled = True
        lstSerumPanel.ItemHeight = 20
        lstSerumPanel.Location = New Point(43, 241)
        lstSerumPanel.Name = "lstSerumPanel"
        lstSerumPanel.Size = New Size(125, 524)
        lstSerumPanel.TabIndex = 17
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(176, 200)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(417, 35)
        TextBox7.TabIndex = 18
        TextBox7.Text = "                          Tests"
        TextBox7.Visible = False
        ' 
        ' lstSerumTests
        ' 
        lstSerumTests.FormattingEnabled = True
        lstSerumTests.ItemHeight = 20
        lstSerumTests.Location = New Point(182, 241)
        lstSerumTests.Name = "lstSerumTests"
        lstSerumTests.Size = New Size(269, 524)
        lstSerumTests.TabIndex = 19
        ' 
        ' lstBloodTests
        ' 
        lstBloodTests.FormattingEnabled = True
        lstBloodTests.ItemHeight = 20
        lstBloodTests.Location = New Point(457, 241)
        lstBloodTests.Name = "lstBloodTests"
        lstBloodTests.Size = New Size(136, 524)
        lstBloodTests.TabIndex = 20
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(604, 157)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(125, 35)
        TextBox8.TabIndex = 21
        TextBox8.Text = "Urine"
        TextBox8.Visible = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox9.Location = New Point(604, 198)
        TextBox9.Multiline = True
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(125, 35)
        TextBox9.TabIndex = 22
        TextBox9.Text = "Panels"
        TextBox9.Visible = False
        ' 
        ' lstUrinePanel
        ' 
        lstUrinePanel.FormattingEnabled = True
        lstUrinePanel.ItemHeight = 20
        lstUrinePanel.Location = New Point(604, 239)
        lstUrinePanel.Name = "lstUrinePanel"
        lstUrinePanel.Size = New Size(125, 84)
        lstUrinePanel.TabIndex = 23
        ' 
        ' TextBox10
        ' 
        TextBox10.Enabled = False
        TextBox10.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox10.Location = New Point(604, 329)
        TextBox10.Multiline = True
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(125, 35)
        TextBox10.TabIndex = 24
        TextBox10.Text = "Tests"
        TextBox10.Visible = False
        ' 
        ' lstUrineTests
        ' 
        lstUrineTests.FormattingEnabled = True
        lstUrineTests.ItemHeight = 20
        lstUrineTests.Location = New Point(604, 370)
        lstUrineTests.Name = "lstUrineTests"
        lstUrineTests.Size = New Size(125, 384)
        lstUrineTests.TabIndex = 25
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox12.Location = New Point(735, 157)
        TextBox12.Multiline = True
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(112, 35)
        TextBox12.TabIndex = 26
        TextBox12.Text = "   CSF"
        TextBox12.Visible = False
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox11.Location = New Point(735, 198)
        TextBox11.Multiline = True
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(112, 35)
        TextBox11.TabIndex = 27
        TextBox11.Text = "   Tests"
        TextBox11.Visible = False
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox13.Location = New Point(853, 198)
        TextBox13.Multiline = True
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(119, 35)
        TextBox13.TabIndex = 28
        TextBox13.Text = "Tests"
        TextBox13.Visible = False
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox14.Location = New Point(853, 157)
        TextBox14.Multiline = True
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(119, 35)
        TextBox14.TabIndex = 29
        TextBox14.Text = "Immuno"
        TextBox14.Visible = False
        ' 
        ' TextBox15
        ' 
        TextBox15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox15.Location = New Point(978, 200)
        TextBox15.Multiline = True
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(115, 35)
        TextBox15.TabIndex = 30
        TextBox15.Text = "Sapphire"
        TextBox15.Visible = False
        ' 
        ' TextBox16
        ' 
        TextBox16.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox16.Location = New Point(978, 159)
        TextBox16.Multiline = True
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(115, 35)
        TextBox16.TabIndex = 31
        TextBox16.Text = "Haematology"
        TextBox16.Visible = False
        ' 
        ' lstCSFTests
        ' 
        lstCSFTests.FormattingEnabled = True
        lstCSFTests.ItemHeight = 20
        lstCSFTests.Location = New Point(735, 239)
        lstCSFTests.Name = "lstCSFTests"
        lstCSFTests.Size = New Size(112, 304)
        lstCSFTests.TabIndex = 32
        ' 
        ' lstimmunoTests
        ' 
        lstimmunoTests.FormattingEnabled = True
        lstimmunoTests.ItemHeight = 20
        lstimmunoTests.Location = New Point(853, 239)
        lstimmunoTests.Name = "lstimmunoTests"
        lstimmunoTests.Size = New Size(119, 264)
        lstimmunoTests.TabIndex = 33
        ' 
        ' lstImmnoCodes
        ' 
        lstImmnoCodes.FormattingEnabled = True
        lstImmnoCodes.ItemHeight = 20
        lstImmnoCodes.Location = New Point(853, 479)
        lstImmnoCodes.Name = "lstImmnoCodes"
        lstImmnoCodes.Size = New Size(104, 24)
        lstImmnoCodes.TabIndex = 34
        ' 
        ' TextBox17
        ' 
        TextBox17.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox17.Location = New Point(1099, 159)
        TextBox17.Multiline = True
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(136, 35)
        TextBox17.TabIndex = 36
        TextBox17.Text = "Haematology"
        TextBox17.Visible = False
        ' 
        ' TextBox18
        ' 
        TextBox18.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox18.Location = New Point(1099, 200)
        TextBox18.Multiline = True
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(136, 35)
        TextBox18.TabIndex = 35
        TextBox18.Text = "Extended IPU"
        TextBox18.Visible = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(978, 241)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(119, 264)
        ListBox1.TabIndex = 37
        ' 
        ' LstHaePanel
        ' 
        LstHaePanel.FormattingEnabled = True
        LstHaePanel.ItemHeight = 20
        LstHaePanel.Location = New Point(1103, 241)
        LstHaePanel.Name = "LstHaePanel"
        LstHaePanel.Size = New Size(132, 264)
        LstHaePanel.TabIndex = 38
        ' 
        ' TextBox19
        ' 
        TextBox19.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox19.Location = New Point(853, 509)
        TextBox19.Multiline = True
        TextBox19.Name = "TextBox19"
        TextBox19.Size = New Size(244, 35)
        TextBox19.TabIndex = 39
        TextBox19.Text = "         Coagulation"
        TextBox19.Visible = False
        ' 
        ' TextBox20
        ' 
        TextBox20.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox20.Location = New Point(993, 552)
        TextBox20.Multiline = True
        TextBox20.Name = "TextBox20"
        TextBox20.Size = New Size(115, 35)
        TextBox20.TabIndex = 42
        TextBox20.Text = "Tests"
        TextBox20.Visible = False
        ' 
        ' TextBox21
        ' 
        TextBox21.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox21.Location = New Point(866, 552)
        TextBox21.Multiline = True
        TextBox21.Name = "TextBox21"
        TextBox21.Size = New Size(121, 35)
        TextBox21.TabIndex = 41
        TextBox21.Text = "Panels"
        TextBox21.Visible = False
        ' 
        ' TextBox22
        ' 
        TextBox22.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox22.Location = New Point(735, 552)
        TextBox22.Multiline = True
        TextBox22.Name = "TextBox22"
        TextBox22.Size = New Size(125, 35)
        TextBox22.TabIndex = 40
        TextBox22.Text = "   Sweat"
        TextBox22.Visible = False
        ' 
        ' TextBox23
        ' 
        TextBox23.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox23.Location = New Point(1120, 514)
        TextBox23.Multiline = True
        TextBox23.Name = "TextBox23"
        TextBox23.Size = New Size(115, 35)
        TextBox23.TabIndex = 43
        TextBox23.Text = "Tests"
        TextBox23.Visible = False
        ' 
        ' lstSweatTests
        ' 
        lstSweatTests.FormattingEnabled = True
        lstSweatTests.ItemHeight = 20
        lstSweatTests.Location = New Point(735, 591)
        lstSweatTests.Name = "lstSweatTests"
        lstSweatTests.Size = New Size(125, 164)
        lstSweatTests.TabIndex = 44
        ' 
        ' lstCoagTests
        ' 
        lstCoagTests.FormattingEnabled = True
        lstCoagTests.ItemHeight = 20
        lstCoagTests.Location = New Point(866, 591)
        lstCoagTests.Name = "lstCoagTests"
        lstCoagTests.Size = New Size(121, 164)
        lstCoagTests.TabIndex = 45
        ' 
        ' lstCoag
        ' 
        lstCoag.FormattingEnabled = True
        lstCoag.ItemHeight = 20
        lstCoag.Location = New Point(993, 593)
        lstCoag.Name = "lstCoag"
        lstCoag.Size = New Size(125, 164)
        lstCoag.TabIndex = 46
        ' 
        ' lstHaeTests
        ' 
        lstHaeTests.FormattingEnabled = True
        lstHaeTests.ItemHeight = 20
        lstHaeTests.Location = New Point(1124, 555)
        lstHaeTests.Name = "lstHaeTests"
        lstHaeTests.Size = New Size(111, 64)
        lstHaeTests.TabIndex = 47
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1143, 656)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 101)
        Button4.TabIndex = 48
        Button4.Text = "View Questions"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' lstExistingBio
        ' 
        lstExistingBio.FormattingEnabled = True
        lstExistingBio.ItemHeight = 20
        lstExistingBio.Location = New Point(50, 433)
        lstExistingBio.Name = "lstExistingBio"
        lstExistingBio.Size = New Size(118, 184)
        lstExistingBio.TabIndex = 49
        ' 
        ' lstSerumCodes
        ' 
        lstSerumCodes.FormattingEnabled = True
        lstSerumCodes.ItemHeight = 20
        lstSerumCodes.Location = New Point(182, 771)
        lstSerumCodes.Name = "lstSerumCodes"
        lstSerumCodes.Size = New Size(125, 24)
        lstSerumCodes.TabIndex = 50
        ' 
        ' lstBloodCodes
        ' 
        lstBloodCodes.FormattingEnabled = True
        lstBloodCodes.ItemHeight = 20
        lstBloodCodes.Location = New Point(457, 771)
        lstBloodCodes.Name = "lstBloodCodes"
        lstBloodCodes.Size = New Size(125, 24)
        lstBloodCodes.TabIndex = 51
        ' 
        ' lstUrineCodes
        ' 
        lstUrineCodes.FormattingEnabled = True
        lstUrineCodes.ItemHeight = 20
        lstUrineCodes.Location = New Point(604, 771)
        lstUrineCodes.Name = "lstUrineCodes"
        lstUrineCodes.Size = New Size(121, 24)
        lstUrineCodes.TabIndex = 52
        ' 
        ' lstCSFCodes
        ' 
        lstCSFCodes.FormattingEnabled = True
        lstCSFCodes.ItemHeight = 20
        lstCSFCodes.Location = New Point(735, 771)
        lstCSFCodes.Name = "lstCSFCodes"
        lstCSFCodes.Size = New Size(121, 24)
        lstCSFCodes.TabIndex = 53
        ' 
        ' lstSweatCodes
        ' 
        lstSweatCodes.FormattingEnabled = True
        lstSweatCodes.ItemHeight = 20
        lstSweatCodes.Location = New Point(866, 771)
        lstSweatCodes.Name = "lstSweatCodes"
        lstSweatCodes.Size = New Size(121, 24)
        lstSweatCodes.TabIndex = 54
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(313, 771)
        Button5.Name = "Button5"
        Button5.Size = New Size(138, 46)
        Button5.TabIndex = 55
        Button5.Text = "Cancel AMS" + vbCrLf + "     Order"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' pBar
        ' 
        pBar.Location = New Point(53, 824)
        pBar.Name = "pBar"
        pBar.Size = New Size(1179, 12)
        pBar.TabIndex = 56
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Location = New Point(176, 479)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1057, 329)
        GroupBox2.TabIndex = 57
        GroupBox2.TabStop = False
        GroupBox2.Text = " Questions"
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(858, 289)
        Button6.Name = "Button6"
        Button6.Size = New Size(170, 34)
        Button6.TabIndex = 1
        Button6.Text = "    Hide"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(49, 46)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(979, 222)
        DataGridView1.TabIndex = 0
        ' 
        ' frmNewOrder
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1272, 966)
        Controls.Add(GroupBox2)
        Controls.Add(pBar)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(lstSweatCodes)
        Controls.Add(lstCSFCodes)
        Controls.Add(lstUrineCodes)
        Controls.Add(lstBloodCodes)
        Controls.Add(lstSerumCodes)
        Controls.Add(lstExistingBio)
        Controls.Add(lstHaeTests)
        Controls.Add(lstCoag)
        Controls.Add(lstCoagTests)
        Controls.Add(lstSweatTests)
        Controls.Add(TextBox23)
        Controls.Add(TextBox20)
        Controls.Add(TextBox21)
        Controls.Add(TextBox22)
        Controls.Add(TextBox19)
        Controls.Add(LstHaePanel)
        Controls.Add(ListBox1)
        Controls.Add(TextBox17)
        Controls.Add(TextBox18)
        Controls.Add(lstImmnoCodes)
        Controls.Add(lstimmunoTests)
        Controls.Add(lstCSFTests)
        Controls.Add(TextBox16)
        Controls.Add(TextBox15)
        Controls.Add(TextBox14)
        Controls.Add(TextBox13)
        Controls.Add(TextBox11)
        Controls.Add(TextBox12)
        Controls.Add(lstUrineTests)
        Controls.Add(TextBox10)
        Controls.Add(lstUrinePanel)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(lstBloodTests)
        Controls.Add(lstSerumTests)
        Controls.Add(TextBox7)
        Controls.Add(lstSerumPanel)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(GroupBox1)
        Controls.Add(cmdExit)
        Controls.Add(cmdClear)
        Controls.Add(cmdSave)
        Controls.Add(chkUrgent)
        Controls.Add(oRandom)
        Controls.Add(oFasting)
        Controls.Add(chkAddOn)
        Controls.Add(tinput)
        Controls.Add(txtSampleID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmNewOrder"
        Text = "Netacquire_Test_order"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSampleID As TextBox
    Friend WithEvents tinput As TextBox
    Friend WithEvents chkAddOn As CheckBox
    Friend WithEvents oFasting As RadioButton
    Friend WithEvents oRandom As RadioButton
    Friend WithEvents chkUrgent As CheckBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optShort As RadioButton
    Friend WithEvents optLong As RadioButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lstSerumPanel As ListBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents lstSerumTests As ListBox
    Friend WithEvents lstBloodTests As ListBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents lstUrinePanel As ListBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents lstUrineTests As ListBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents lstCSFTests As ListBox
    Friend WithEvents lstimmunoTests As ListBox
    Friend WithEvents lstImmnoCodes As ListBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LstHaePanel As ListBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents lstSweatTests As ListBox
    Friend WithEvents lstCoagTests As ListBox
    Friend WithEvents lstCoag As ListBox
    Friend WithEvents lstHaeTests As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents lstExistingBio As ListBox
    Friend WithEvents lstSerumCodes As ListBox
    Friend WithEvents lstBloodCodes As ListBox
    Friend WithEvents lstUrineCodes As ListBox
    Friend WithEvents lstCSFCodes As ListBox
    Friend WithEvents lstSweatCodes As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents pBar As ProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
End Class
