
Partial Class frmEditAll
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
        Me.btnScan = New System.Windows.Forms.GroupBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSampleID = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearchDob = New System.Windows.Forms.Button()
        Me.btnDob = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChart = New System.Windows.Forms.TextBox()
        Me.lblChart = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrevDetail = New System.Windows.Forms.Label()
        Me.btnPatientNotePad = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnViewScan = New System.Windows.Forms.Button()
        Me.cMRU = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbOtherSamples = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgLast = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSampleIDIncre = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnUnlockDemo = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSaveAndHold = New System.Windows.Forms.Button()
        Me.btnVal = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.flxQuestion = New System.Windows.Forms.DataGridView()
        Me.btnOrderExtTest = New System.Windows.Forms.Button()
        Me.btnOrderTests = New System.Windows.Forms.Button()
        Me.btnTag = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkFast = New System.Windows.Forms.CheckBox()
        Me.chkUrgent = New System.Windows.Forms.CheckBox()
        Me.rdOHours = New System.Windows.Forms.RadioButton()
        Me.rdRoutine = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblDateError = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.timeRun = New System.Windows.Forms.TextBox()
        Me.dtRun = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.timeRec = New System.Windows.Forms.TextBox()
        Me.dtReceived = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.sampleTime = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtSample = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkExt = New System.Windows.Forms.CheckBox()
        Me.chkHaem = New System.Windows.Forms.CheckBox()
        Me.chkCoag = New System.Windows.Forms.CheckBox()
        Me.lblReqID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncc = New System.Windows.Forms.Button()
        Me.txtadd4 = New System.Windows.Forms.TextBox()
        Me.txtadd3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbCLdetails = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDemogComm = New System.Windows.Forms.TextBox()
        Me.cmbDemogComm = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbGP = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbClins = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmdWards = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbHospitals = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.TextBox()
        Me.lblMRN = New System.Windows.Forms.TextBox()
        Me.LBL = New System.Windows.Forms.Label()
        Me.txtExtSampleID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRA = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt48 = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtCD8P = New System.Windows.Forms.TextBox()
        Me.txtCD8A = New System.Windows.Forms.TextBox()
        Me.CD8 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtCD4P = New System.Windows.Forms.TextBox()
        Me.txtCD4A = New System.Windows.Forms.TextBox()
        Me.CD4 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtCD3P = New System.Windows.Forms.TextBox()
        Me.TXTCD3A = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.btnOrderHaem = New System.Windows.Forms.Button()
        Me.btnValHaem = New System.Windows.Forms.Button()
        Me.btnHaemSave = New System.Windows.Forms.Button()
        Me.btnRepeat = New System.Windows.Forms.Button()
        Me.btnHaemGrap = New System.Windows.Forms.Button()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtSpecComm = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtFilCom = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.cmbHaemComm = New System.Windows.Forms.ComboBox()
        Me.cmbFilmCom = New System.Windows.Forms.ComboBox()
        Me.chkFilm = New System.Windows.Forms.CheckBox()
        Me.btnManDiff = New System.Windows.Forms.Button()
        Me.gOutstandingHaem = New System.Windows.Forms.DataGridView()
        Me.Outstanding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSick = New System.Windows.Forms.Button()
        Me.btnMalria = New System.Windows.Forms.Button()
        Me.btnInfect = New System.Windows.Forms.Button()
        Me.btnESRPrint = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.chkRA = New System.Windows.Forms.CheckBox()
        Me.txtSick = New System.Windows.Forms.TextBox()
        Me.chkSick = New System.Windows.Forms.CheckBox()
        Me.txtMal = New System.Windows.Forms.TextBox()
        Me.chkMal = New System.Windows.Forms.CheckBox()
        Me.txtInfect = New System.Windows.Forms.TextBox()
        Me.ckfInfec = New System.Windows.Forms.CheckBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtRetP = New System.Windows.Forms.TextBox()
        Me.txtRetA = New System.Windows.Forms.TextBox()
        Me.chkRetics = New System.Windows.Forms.CheckBox()
        Me.txtESR = New System.Windows.Forms.TextBox()
        Me.chkESR = New System.Windows.Forms.CheckBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtMpv = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.txtPlt = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.btnHgb = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtnRBCp = New System.Windows.Forms.TextBox()
        Me.txtRDWSD = New System.Windows.Forms.TextBox()
        Me.txtRDWCV = New System.Windows.Forms.TextBox()
        Me.txtMCHC = New System.Windows.Forms.TextBox()
        Me.txtIRF = New System.Windows.Forms.TextBox()
        Me.txtnRBCA = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtMCV = New System.Windows.Forms.TextBox()
        Me.txtHct = New System.Windows.Forms.TextBox()
        Me.txtHgb = New System.Windows.Forms.TextBox()
        Me.txtRbc = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtWVF = New System.Windows.Forms.TextBox()
        Me.txtWOC = New System.Windows.Forms.TextBox()
        Me.txtBasP = New System.Windows.Forms.TextBox()
        Me.txtEosP = New System.Windows.Forms.TextBox()
        Me.txtMonoP = New System.Windows.Forms.TextBox()
        Me.txtLymphP = New System.Windows.Forms.TextBox()
        Me.txtNeutP = New System.Windows.Forms.TextBox()
        Me.btnClearDiff = New System.Windows.Forms.Button()
        Me.txtWIC = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtBasA = New System.Windows.Forms.TextBox()
        Me.txtEosA = New System.Windows.Forms.TextBox()
        Me.txtMonoA = New System.Windows.Forms.TextBox()
        Me.txtLymphA = New System.Windows.Forms.TextBox()
        Me.txtNeutA = New System.Windows.Forms.TextBox()
        Me.txtWBC = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbAdd = New System.Windows.Forms.TabPage()
        Me.btnViewBioRepeat = New System.Windows.Forms.Button()
        Me.btnValBio = New System.Windows.Forms.Button()
        Me.btnBioSave = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.txtBioAutoCom = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cmbBioComment2 = New System.Windows.Forms.ComboBox()
        Me.txtBioComment = New System.Windows.Forms.TextBox()
        Me.cmbBioComment = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkLip = New System.Windows.Forms.CheckBox()
        Me.chkIcteric = New System.Windows.Forms.CheckBox()
        Me.chkHaemo = New System.Windows.Forms.CheckBox()
        Me.chkOldSam = New System.Windows.Forms.CheckBox()
        Me.btnAddBioRes = New System.Windows.Forms.Button()
        Me.cmbSampleType = New System.Windows.Forms.ComboBox()
        Me.cmbUnits = New System.Windows.Forms.ComboBox()
        Me.cmbNewBioRes = New System.Windows.Forms.ComboBox()
        Me.cmbAddBio = New System.Windows.Forms.ComboBox()
        Me.split6 = New System.Windows.Forms.Label()
        Me.split5 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.split3 = New System.Windows.Forms.Label()
        Me.split2 = New System.Windows.Forms.Label()
        Me.lblSplit1 = New System.Windows.Forms.Label()
        Me.lblAll = New System.Windows.Forms.Label()
        Me.gBioOutstand = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gBio = New System.Windows.Forms.DataGridView()
        Me.Tname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ranges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Units = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Analyser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnBioPrintTrue = New System.Windows.Forms.Button()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.lblRandomS = New System.Windows.Forms.Label()
        Me.lblViewAll = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnCoagVali = New System.Windows.Forms.Button()
        Me.btnCoagSave = New System.Windows.Forms.Button()
        Me.btnPrintAll = New System.Windows.Forms.Button()
        Me.btnCoagAddRes = New System.Windows.Forms.Button()
        Me.txtDeltaCheck = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtAutoComm = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtCoagRes = New System.Windows.Forms.TextBox()
        Me.cmbParameter = New System.Windows.Forms.ComboBox()
        Me.cmbCoagComment = New System.Windows.Forms.ComboBox()
        Me.txtSpecCoag = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.btnOrderCoag = New System.Windows.Forms.Button()
        Me.btnCoagRep = New System.Windows.Forms.Button()
        Me.txtCoagAnal = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtWarfa = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.coagParam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coagRes2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.gCoag = New System.Windows.Forms.DataGridView()
        Me.Parameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultCoag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsCoag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flagCoag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VPCoag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCoag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkCoagPrintFalse = New System.Windows.Forms.Button()
        Me.chkCoagPrintTrue = New System.Windows.Forms.Button()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.etc1 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.etc4 = New System.Windows.Forms.TextBox()
        Me.etc3 = New System.Windows.Forms.TextBox()
        Me.etc2 = New System.Windows.Forms.TextBox()
        Me.btnSaveExt = New System.Windows.Forms.Button()
        Me.btnPrintDoc = New System.Windows.Forms.Button()
        Me.btnOrderExt = New System.Windows.Forms.Button()
        Me.btnDeleteExt = New System.Windows.Forms.Button()
        Me.btnViewMed = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.testnameExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NrExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SendTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.btnTransfus = New System.Windows.Forms.Button()
        Me.btnChoosePrin = New System.Windows.Forms.Button()
        Me.btnPrintHold = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnFax = New System.Windows.Forms.Button()
        Me.btnPhone = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnScan.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgLast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.flxQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.txtRA.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gOutstandingHaem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.cmbAdd.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.gBioOutstand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gBio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gCoag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnScan
        '
        Me.btnScan.Controls.Add(Me.PictureBox11)
        Me.btnScan.Controls.Add(Me.PictureBox1)
        Me.btnScan.Controls.Add(Me.txtSampleID)
        Me.btnScan.Controls.Add(Me.TextBox2)
        Me.btnScan.Controls.Add(Me.Label11)
        Me.btnScan.Controls.Add(Me.txtAge)
        Me.btnScan.Controls.Add(Me.Label10)
        Me.btnScan.Controls.Add(Me.txtDOB)
        Me.btnScan.Controls.Add(Me.Label9)
        Me.btnScan.Controls.Add(Me.btnSearchDob)
        Me.btnScan.Controls.Add(Me.btnDob)
        Me.btnScan.Controls.Add(Me.GroupBox1)
        Me.btnScan.Controls.Add(Me.btnPatientNotePad)
        Me.btnScan.Controls.Add(Me.Button2)
        Me.btnScan.Controls.Add(Me.btnViewScan)
        Me.btnScan.Controls.Add(Me.cMRU)
        Me.btnScan.Controls.Add(Me.Label3)
        Me.btnScan.Controls.Add(Me.cmbOtherSamples)
        Me.btnScan.Controls.Add(Me.Label2)
        Me.btnScan.Controls.Add(Me.imgLast)
        Me.btnScan.Controls.Add(Me.Button1)
        Me.btnScan.Controls.Add(Me.btnSampleIDIncre)
        Me.btnScan.Controls.Add(Me.Label1)
        Me.btnScan.Location = New System.Drawing.Point(0, 0)
        Me.btnScan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Padding = New System.Windows.Forms.Padding(2)
        Me.btnScan.Size = New System.Drawing.Size(1348, 124)
        Me.btnScan.TabIndex = 0
        Me.btnScan.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Location = New System.Drawing.Point(109, 0)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox11.TabIndex = 30
        Me.PictureBox11.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 29)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'txtSampleID
        '
        Me.txtSampleID.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtSampleID.Location = New System.Drawing.Point(9, 29)
        Me.txtSampleID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSampleID.Multiline = True
        Me.txtSampleID.Name = "txtSampleID"
        Me.txtSampleID.Size = New System.Drawing.Size(135, 36)
        Me.txtSampleID.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1077, 79)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 22)
        Me.TextBox2.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1046, 78)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Sex"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(1077, 56)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(75, 22)
        Me.txtAge.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1044, 56)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Age"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(1077, 34)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(75, 22)
        Me.txtDOB.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1041, 35)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "D.o.b"
        '
        'btnSearchDob
        '
        Me.btnSearchDob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearchDob.Location = New System.Drawing.Point(1077, 14)
        Me.btnSearchDob.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchDob.Name = "btnSearchDob"
        Me.btnSearchDob.Size = New System.Drawing.Size(74, 20)
        Me.btnSearchDob.TabIndex = 11
        Me.btnSearchDob.Text = "Search"
        Me.btnSearchDob.UseVisualStyleBackColor = True
        '
        'btnDob
        '
        Me.btnDob.Location = New System.Drawing.Point(1049, 14)
        Me.btnDob.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDob.Name = "btnDob"
        Me.btnDob.Size = New System.Drawing.Size(28, 20)
        Me.btnDob.TabIndex = 10
        Me.btnDob.Text = "..."
        Me.btnDob.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtChart)
        Me.GroupBox1.Controls.Add(Me.lblChart)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblPrevDetail)
        Me.GroupBox1.Location = New System.Drawing.Point(416, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(623, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(434, 2)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(84, 22)
        Me.TextBox3.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(11, 93)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(32, 0, 553, 0)
        Me.Label12.Size = New System.Drawing.Size(587, 18)
        Me.Label12.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.Location = New System.Drawing.Point(528, 6)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 20)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.TextBox1.Location = New System.Drawing.Point(354, 50)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 36)
        Me.TextBox1.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(354, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(0, 0, 172, 0)
        Me.Label8.Size = New System.Drawing.Size(246, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ForeName"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSName
        '
        Me.txtSName.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtSName.Location = New System.Drawing.Point(129, 50)
        Me.txtSName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSName.Multiline = True
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(223, 36)
        Me.txtSName.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(131, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 0, 154, 0)
        Me.Label7.Size = New System.Drawing.Size(220, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "SurName"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtChart
        '
        Me.txtChart.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtChart.Location = New System.Drawing.Point(11, 50)
        Me.txtChart.Margin = New System.Windows.Forms.Padding(2)
        Me.txtChart.Multiline = True
        Me.txtChart.Name = "txtChart"
        Me.txtChart.Size = New System.Drawing.Size(114, 36)
        Me.txtChart.TabIndex = 4
        '
        'lblChart
        '
        Me.lblChart.AutoSize = True
        Me.lblChart.BackColor = System.Drawing.Color.Silver
        Me.lblChart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChart.Location = New System.Drawing.Point(11, 28)
        Me.lblChart.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChart.Name = "lblChart"
        Me.lblChart.Padding = New System.Windows.Forms.Padding(32, 0, 32, 0)
        Me.lblChart.Size = New System.Drawing.Size(114, 18)
        Me.lblChart.TabIndex = 3
        Me.lblChart.Text = "Chart #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "SampleDate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(180, 2)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 30, 2, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.Label5.Size = New System.Drawing.Size(143, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Urgent"
        '
        'lblPrevDetail
        '
        Me.lblPrevDetail.AutoSize = True
        Me.lblPrevDetail.BackColor = System.Drawing.Color.Red
        Me.lblPrevDetail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblPrevDetail.ForeColor = System.Drawing.Color.Yellow
        Me.lblPrevDetail.Location = New System.Drawing.Point(11, 2)
        Me.lblPrevDetail.Margin = New System.Windows.Forms.Padding(2, 30, 2, 30)
        Me.lblPrevDetail.Name = "lblPrevDetail"
        Me.lblPrevDetail.Size = New System.Drawing.Size(182, 28)
        Me.lblPrevDetail.TabIndex = 0
        Me.lblPrevDetail.Text = "No Previous Details"
        '
        'btnPatientNotePad
        '
        Me.btnPatientNotePad.Location = New System.Drawing.Point(346, 21)
        Me.btnPatientNotePad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPatientNotePad.Name = "btnPatientNotePad"
        Me.btnPatientNotePad.Size = New System.Drawing.Size(46, 34)
        Me.btnPatientNotePad.TabIndex = 8
        Me.btnPatientNotePad.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(270, 8)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Scan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnViewScan
        '
        Me.btnViewScan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnViewScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewScan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewScan.Location = New System.Drawing.Point(194, 8)
        Me.btnViewScan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewScan.Name = "btnViewScan"
        Me.btnViewScan.Size = New System.Drawing.Size(72, 56)
        Me.btnViewScan.TabIndex = 1
        Me.btnViewScan.Text = "View Scan"
        Me.btnViewScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewScan.UseVisualStyleBackColor = False
        '
        'cMRU
        '
        Me.cMRU.FormattingEnabled = True
        Me.cMRU.Location = New System.Drawing.Point(46, 98)
        Me.cMRU.Margin = New System.Windows.Forms.Padding(2)
        Me.cMRU.Name = "cMRU"
        Me.cMRU.Size = New System.Drawing.Size(128, 24)
        Me.cMRU.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MRU"
        '
        'cmbOtherSamples
        '
        Me.cmbOtherSamples.FormattingEnabled = True
        Me.cmbOtherSamples.Location = New System.Drawing.Point(5, 76)
        Me.cmbOtherSamples.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbOtherSamples.Name = "cmbOtherSamples"
        Me.cmbOtherSamples.Size = New System.Drawing.Size(401, 24)
        Me.cmbOtherSamples.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Other Samples"
        '
        'imgLast
        '
        Me.imgLast.Location = New System.Drawing.Point(150, 0)
        Me.imgLast.Margin = New System.Windows.Forms.Padding(2)
        Me.imgLast.Name = "imgLast"
        Me.imgLast.Size = New System.Drawing.Size(39, 32)
        Me.imgLast.TabIndex = 1
        Me.imgLast.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 45)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSampleIDIncre
        '
        Me.btnSampleIDIncre.Location = New System.Drawing.Point(147, 28)
        Me.btnSampleIDIncre.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSampleIDIncre.Name = "btnSampleIDIncre"
        Me.btnSampleIDIncre.Size = New System.Drawing.Size(28, 20)
        Me.btnSampleIDIncre.TabIndex = 2
        Me.btnSampleIDIncre.Text = "+"
        Me.btnSampleIDIncre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSampleIDIncre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SampleID"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(7, 0)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(271, 60)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(7, 6)
        Me.ToolStripContainer1.TabIndex = 19
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabPage1)
        Me.Tabs.Controls.Add(Me.txtRA)
        Me.Tabs.Controls.Add(Me.cmbAdd)
        Me.Tabs.Controls.Add(Me.TabPage4)
        Me.Tabs.Controls.Add(Me.TabPage5)
        Me.Tabs.Controls.Add(Me.TabPage6)
        Me.Tabs.Controls.Add(Me.TabPage7)
        Me.Tabs.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tabs.Location = New System.Drawing.Point(5, 128)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(2)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.Padding = New System.Drawing.Point(44, 3)
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1057, 506)
        Me.Tabs.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.txtNote)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.btnUnlockDemo)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnSaveAndHold)
        Me.TabPage1.Controls.Add(Me.btnVal)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.flxQuestion)
        Me.TabPage1.Controls.Add(Me.btnOrderExtTest)
        Me.TabPage1.Controls.Add(Me.btnOrderTests)
        Me.TabPage1.Controls.Add(Me.btnTag)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.lblReqID)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1049, 469)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Demographics"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(514, 376)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(324, 74)
        Me.txtNote.TabIndex = 51
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(949, 324)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 91)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Unlock Demographics"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnUnlockDemo
        '
        Me.btnUnlockDemo.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUnlockDemo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUnlockDemo.Location = New System.Drawing.Point(842, 324)
        Me.btnUnlockDemo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUnlockDemo.Name = "btnUnlockDemo"
        Me.btnUnlockDemo.Size = New System.Drawing.Size(102, 91)
        Me.btnUnlockDemo.TabIndex = 49
        Me.btnUnlockDemo.Text = "Unlock Demographics"
        Me.btnUnlockDemo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUnlockDemo.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(744, 326)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 46)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSaveAndHold
        '
        Me.btnSaveAndHold.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveAndHold.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveAndHold.Location = New System.Drawing.Point(636, 326)
        Me.btnSaveAndHold.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveAndHold.Name = "btnSaveAndHold"
        Me.btnSaveAndHold.Size = New System.Drawing.Size(93, 46)
        Me.btnSaveAndHold.TabIndex = 47
        Me.btnSaveAndHold.Text = "Save &&  &Hold"
        Me.btnSaveAndHold.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveAndHold.UseVisualStyleBackColor = True
        '
        'btnVal
        '
        Me.btnVal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVal.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVal.Location = New System.Drawing.Point(514, 351)
        Me.btnVal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVal.Name = "btnVal"
        Me.btnVal.Size = New System.Drawing.Size(107, 20)
        Me.btnVal.TabIndex = 46
        Me.btnVal.Text = "Un-Validate"
        Me.btnVal.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(514, 324)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(134, 38)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "Demographics Not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Valid "
        '
        'flxQuestion
        '
        Me.flxQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.flxQuestion.Location = New System.Drawing.Point(514, 220)
        Me.flxQuestion.Margin = New System.Windows.Forms.Padding(2)
        Me.flxQuestion.Name = "flxQuestion"
        Me.flxQuestion.RowHeadersWidth = 62
        Me.flxQuestion.RowTemplate.Height = 33
        Me.flxQuestion.Size = New System.Drawing.Size(528, 101)
        Me.flxQuestion.TabIndex = 44
        '
        'btnOrderExtTest
        '
        Me.btnOrderExtTest.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderExtTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrderExtTest.Location = New System.Drawing.Point(976, 135)
        Me.btnOrderExtTest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderExtTest.Name = "btnOrderExtTest"
        Me.btnOrderExtTest.Size = New System.Drawing.Size(66, 82)
        Me.btnOrderExtTest.TabIndex = 43
        Me.btnOrderExtTest.Text = "Order External Tests"
        Me.btnOrderExtTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrderExtTest.UseVisualStyleBackColor = True
        '
        'btnOrderTests
        '
        Me.btnOrderTests.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderTests.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrderTests.Location = New System.Drawing.Point(906, 135)
        Me.btnOrderTests.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderTests.Name = "btnOrderTests"
        Me.btnOrderTests.Size = New System.Drawing.Size(65, 82)
        Me.btnOrderTests.TabIndex = 42
        Me.btnOrderTests.Text = "Order Tests"
        Me.btnOrderTests.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrderTests.UseVisualStyleBackColor = True
        '
        'btnTag
        '
        Me.btnTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTag.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTag.Location = New System.Drawing.Point(949, 7)
        Me.btnTag.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTag.Name = "btnTag"
        Me.btnTag.Size = New System.Drawing.Size(74, 20)
        Me.btnTag.TabIndex = 41
        Me.btnTag.Text = "Tag"
        Me.btnTag.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkFast)
        Me.GroupBox7.Controls.Add(Me.chkUrgent)
        Me.GroupBox7.Controls.Add(Me.rdOHours)
        Me.GroupBox7.Controls.Add(Me.rdRoutine)
        Me.GroupBox7.Location = New System.Drawing.Point(916, 37)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(125, 94)
        Me.GroupBox7.TabIndex = 40
        Me.GroupBox7.TabStop = False
        '
        'chkFast
        '
        Me.chkFast.AutoSize = True
        Me.chkFast.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chkFast.Location = New System.Drawing.Point(24, 70)
        Me.chkFast.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFast.Name = "chkFast"
        Me.chkFast.Size = New System.Drawing.Size(78, 23)
        Me.chkFast.TabIndex = 3
        Me.chkFast.Text = "Fasting"
        Me.chkFast.UseVisualStyleBackColor = True
        '
        'chkUrgent
        '
        Me.chkUrgent.AutoSize = True
        Me.chkUrgent.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chkUrgent.Location = New System.Drawing.Point(24, 52)
        Me.chkUrgent.Margin = New System.Windows.Forms.Padding(2)
        Me.chkUrgent.Name = "chkUrgent"
        Me.chkUrgent.Size = New System.Drawing.Size(76, 23)
        Me.chkUrgent.TabIndex = 2
        Me.chkUrgent.Text = "Urgent"
        Me.chkUrgent.UseVisualStyleBackColor = True
        '
        'rdOHours
        '
        Me.rdOHours.AutoSize = True
        Me.rdOHours.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rdOHours.Location = New System.Drawing.Point(24, 34)
        Me.rdOHours.Margin = New System.Windows.Forms.Padding(2)
        Me.rdOHours.Name = "rdOHours"
        Me.rdOHours.Size = New System.Drawing.Size(116, 23)
        Me.rdOHours.TabIndex = 1
        Me.rdOHours.TabStop = True
        Me.rdOHours.Text = "Out Of Hours"
        Me.rdOHours.UseVisualStyleBackColor = True
        '
        'rdRoutine
        '
        Me.rdRoutine.AutoSize = True
        Me.rdRoutine.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rdRoutine.Location = New System.Drawing.Point(24, 16)
        Me.rdRoutine.Margin = New System.Windows.Forms.Padding(2)
        Me.rdRoutine.Name = "rdRoutine"
        Me.rdRoutine.Size = New System.Drawing.Size(81, 23)
        Me.rdRoutine.TabIndex = 0
        Me.rdRoutine.TabStop = True
        Me.rdRoutine.Text = "Routine"
        Me.rdRoutine.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.lblDateError)
        Me.GroupBox4.Controls.Add(Me.PictureBox10)
        Me.GroupBox4.Controls.Add(Me.PictureBox9)
        Me.GroupBox4.Controls.Add(Me.PictureBox8)
        Me.GroupBox4.Controls.Add(Me.timeRun)
        Me.GroupBox4.Controls.Add(Me.dtRun)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.PictureBox7)
        Me.GroupBox4.Controls.Add(Me.PictureBox6)
        Me.GroupBox4.Controls.Add(Me.PictureBox5)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Controls.Add(Me.timeRec)
        Me.GroupBox4.Controls.Add(Me.dtReceived)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.sampleTime)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.dtSample)
        Me.GroupBox4.Controls.Add(Me.ToolStripContainer1)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(514, 26)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(388, 152)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Date"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Location = New System.Drawing.Point(411, 10)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(121, 112)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(2, 16)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(84, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Routine"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(2, 16)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(123, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblDateError
        '
        Me.lblDateError.AutoSize = True
        Me.lblDateError.BackColor = System.Drawing.Color.Red
        Me.lblDateError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDateError.ForeColor = System.Drawing.Color.Yellow
        Me.lblDateError.Location = New System.Drawing.Point(260, 134)
        Me.lblDateError.Margin = New System.Windows.Forms.Padding(2, 30, 2, 30)
        Me.lblDateError.Name = "lblDateError"
        Me.lblDateError.Size = New System.Drawing.Size(145, 20)
        Me.lblDateError.TabIndex = 38
        Me.lblDateError.Text = "Date Sequence Error"
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(213, 123)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox10.TabIndex = 37
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(169, 123)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox9.TabIndex = 36
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(122, 123)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox8.TabIndex = 35
        Me.PictureBox8.TabStop = False
        '
        'timeRun
        '
        Me.timeRun.Location = New System.Drawing.Point(255, 104)
        Me.timeRun.Margin = New System.Windows.Forms.Padding(2)
        Me.timeRun.Name = "timeRun"
        Me.timeRun.Size = New System.Drawing.Size(42, 27)
        Me.timeRun.TabIndex = 34
        '
        'dtRun
        '
        Me.dtRun.CustomFormat = "dd/MM/yyyy"
        Me.dtRun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRun.Location = New System.Drawing.Point(122, 104)
        Me.dtRun.Margin = New System.Windows.Forms.Padding(2)
        Me.dtRun.Name = "dtRun"
        Me.dtRun.Size = New System.Drawing.Size(127, 27)
        Me.dtRun.TabIndex = 33
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(85, 106)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 20)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Run"
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(208, 60)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox7.TabIndex = 31
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(252, 60)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox6.TabIndex = 30
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(297, 60)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(14, 59)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(103, 59)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(59, 59)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'timeRec
        '
        Me.timeRec.Location = New System.Drawing.Point(340, 38)
        Me.timeRec.Margin = New System.Windows.Forms.Padding(2)
        Me.timeRec.Name = "timeRec"
        Me.timeRec.Size = New System.Drawing.Size(42, 27)
        Me.timeRec.TabIndex = 25
        '
        'dtReceived
        '
        Me.dtReceived.CustomFormat = "dd/MM/yyyy"
        Me.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReceived.Location = New System.Drawing.Point(209, 38)
        Me.dtReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.dtReceived.Name = "dtReceived"
        Me.dtReceived.Size = New System.Drawing.Size(127, 27)
        Me.dtReceived.TabIndex = 24
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(209, 21)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 20)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Received"
        '
        'sampleTime
        '
        Me.sampleTime.Location = New System.Drawing.Point(145, 38)
        Me.sampleTime.Margin = New System.Windows.Forms.Padding(2)
        Me.sampleTime.Name = "sampleTime"
        Me.sampleTime.Size = New System.Drawing.Size(42, 27)
        Me.sampleTime.TabIndex = 22
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 21)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 20)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Sample"
        '
        'dtSample
        '
        Me.dtSample.CustomFormat = "dd/MM/yyyy"
        Me.dtSample.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSample.Location = New System.Drawing.Point(16, 38)
        Me.dtSample.Margin = New System.Windows.Forms.Padding(2)
        Me.dtSample.Name = "dtSample"
        Me.dtSample.Size = New System.Drawing.Size(127, 27)
        Me.dtSample.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Silver
        Me.Label24.Location = New System.Drawing.Point(514, 7)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(379, 26)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Copy all details from SampleID # 1234567"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkExt)
        Me.GroupBox3.Controls.Add(Me.chkHaem)
        Me.GroupBox3.Controls.Add(Me.chkCoag)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(-1, 370)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(504, 74)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reject Sample"
        '
        'chkExt
        '
        Me.chkExt.AutoSize = True
        Me.chkExt.Location = New System.Drawing.Point(19, 46)
        Me.chkExt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkExt.Name = "chkExt"
        Me.chkExt.Size = New System.Drawing.Size(189, 24)
        Me.chkExt.TabIndex = 2
        Me.chkExt.Text = "Reject External Sample"
        Me.chkExt.UseVisualStyleBackColor = True
        '
        'chkHaem
        '
        Me.chkHaem.AutoSize = True
        Me.chkHaem.Location = New System.Drawing.Point(278, 26)
        Me.chkHaem.Margin = New System.Windows.Forms.Padding(2)
        Me.chkHaem.Name = "chkHaem"
        Me.chkHaem.Size = New System.Drawing.Size(227, 24)
        Me.chkHaem.TabIndex = 1
        Me.chkHaem.Text = "Reject Haemotology Sample"
        Me.chkHaem.UseVisualStyleBackColor = True
        '
        'chkCoag
        '
        Me.chkCoag.AutoSize = True
        Me.chkCoag.Location = New System.Drawing.Point(19, 26)
        Me.chkCoag.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCoag.Name = "chkCoag"
        Me.chkCoag.Size = New System.Drawing.Size(216, 24)
        Me.chkCoag.TabIndex = 0
        Me.chkCoag.Text = "Reject Coagulation Sample"
        Me.chkCoag.UseVisualStyleBackColor = True
        '
        'lblReqID
        '
        Me.lblReqID.AutoSize = True
        Me.lblReqID.Location = New System.Drawing.Point(27, 4)
        Me.lblReqID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReqID.Name = "lblReqID"
        Me.lblReqID.Size = New System.Drawing.Size(247, 26)
        Me.lblReqID.TabIndex = 1
        Me.lblReqID.Text = "Request ID:                           "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btncc)
        Me.GroupBox2.Controls.Add(Me.txtadd4)
        Me.GroupBox2.Controls.Add(Me.txtadd3)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.cmbCLdetails)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtDemogComm)
        Me.GroupBox2.Controls.Add(Me.cmbDemogComm)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmbGP)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmbClins)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cmdWards)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cmbHospitals)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtAdd2)
        Me.GroupBox2.Controls.Add(Me.txtAdd1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblAge)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblDOB)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.lblMRN)
        Me.GroupBox2.Controls.Add(Me.LBL)
        Me.GroupBox2.Controls.Add(Me.txtExtSampleID)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(503, 355)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btncc
        '
        Me.btncc.BackColor = System.Drawing.Color.Gray
        Me.btncc.Location = New System.Drawing.Point(466, 153)
        Me.btncc.Margin = New System.Windows.Forms.Padding(2)
        Me.btncc.Name = "btncc"
        Me.btncc.Size = New System.Drawing.Size(28, 80)
        Me.btncc.TabIndex = 34
        Me.btncc.Text = "++ cc ++"
        Me.btncc.UseVisualStyleBackColor = False
        '
        'txtadd4
        '
        Me.txtadd4.Location = New System.Drawing.Point(80, 330)
        Me.txtadd4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtadd4.Name = "txtadd4"
        Me.txtadd4.Size = New System.Drawing.Size(383, 27)
        Me.txtadd4.TabIndex = 33
        '
        'txtadd3
        '
        Me.txtadd3.Location = New System.Drawing.Point(80, 310)
        Me.txtadd3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtadd3.Name = "txtadd3"
        Me.txtadd3.Size = New System.Drawing.Size(383, 27)
        Me.txtadd3.TabIndex = 32
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(466, 289)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 17)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbCLdetails
        '
        Me.cmbCLdetails.FormattingEnabled = True
        Me.cmbCLdetails.Location = New System.Drawing.Point(80, 289)
        Me.cmbCLdetails.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCLdetails.Name = "cmbCLdetails"
        Me.cmbCLdetails.Size = New System.Drawing.Size(383, 28)
        Me.cmbCLdetails.TabIndex = 30
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 292)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 20)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "CL Details"
        '
        'txtDemogComm
        '
        Me.txtDemogComm.Location = New System.Drawing.Point(80, 225)
        Me.txtDemogComm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDemogComm.Multiline = True
        Me.txtDemogComm.Name = "txtDemogComm"
        Me.txtDemogComm.Size = New System.Drawing.Size(383, 62)
        Me.txtDemogComm.TabIndex = 28
        '
        'cmbDemogComm
        '
        Me.cmbDemogComm.FormattingEnabled = True
        Me.cmbDemogComm.Location = New System.Drawing.Point(80, 203)
        Me.cmbDemogComm.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDemogComm.Name = "cmbDemogComm"
        Me.cmbDemogComm.Size = New System.Drawing.Size(383, 28)
        Me.cmbDemogComm.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(-1, 206)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 20)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Comments"
        '
        'cmbGP
        '
        Me.cmbGP.FormattingEnabled = True
        Me.cmbGP.Location = New System.Drawing.Point(80, 183)
        Me.cmbGP.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbGP.Name = "cmbGP"
        Me.cmbGP.Size = New System.Drawing.Size(383, 28)
        Me.cmbGP.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(46, 185)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 20)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "GP"
        '
        'cmbClins
        '
        Me.cmbClins.FormattingEnabled = True
        Me.cmbClins.Location = New System.Drawing.Point(80, 162)
        Me.cmbClins.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbClins.Name = "cmbClins"
        Me.cmbClins.Size = New System.Drawing.Size(383, 28)
        Me.cmbClins.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 165)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 20)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Clinician"
        '
        'cmdWards
        '
        Me.cmdWards.FormattingEnabled = True
        Me.cmdWards.Location = New System.Drawing.Point(80, 142)
        Me.cmdWards.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdWards.Name = "cmdWards"
        Me.cmdWards.Size = New System.Drawing.Size(383, 28)
        Me.cmdWards.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 146)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 20)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Ward"
        '
        'cmbHospitals
        '
        Me.cmbHospitals.FormattingEnabled = True
        Me.cmbHospitals.Location = New System.Drawing.Point(80, 121)
        Me.cmbHospitals.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbHospitals.Name = "cmbHospitals"
        Me.cmbHospitals.Size = New System.Drawing.Size(383, 28)
        Me.cmbHospitals.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 124)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 20)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Hospital"
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(80, 100)
        Me.txtAdd2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(383, 27)
        Me.txtAdd2.TabIndex = 18
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(80, 80)
        Me.txtAdd1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(383, 27)
        Me.txtAdd1.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 80)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Address"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox4.Location = New System.Drawing.Point(353, 58)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(110, 27)
        Me.TextBox4.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(320, 60)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 20)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Sex"
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAge.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblAge.Location = New System.Drawing.Point(256, 57)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(2)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.ReadOnly = True
        Me.lblAge.Size = New System.Drawing.Size(61, 27)
        Me.lblAge.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(228, 60)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Age"
        '
        'lblDOB
        '
        Me.lblDOB.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDOB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblDOB.Location = New System.Drawing.Point(80, 56)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.ReadOnly = True
        Me.lblDOB.Size = New System.Drawing.Size(148, 27)
        Me.lblDOB.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "D.o.B"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(80, 37)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2)
        Me.lblName.Name = "lblName"
        Me.lblName.ReadOnly = True
        Me.lblName.Size = New System.Drawing.Size(383, 27)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "fsdfsdf"
        '
        'lblMRN
        '
        Me.lblMRN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMRN.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMRN.Location = New System.Drawing.Point(80, 16)
        Me.lblMRN.Margin = New System.Windows.Forms.Padding(2)
        Me.lblMRN.Name = "lblMRN"
        Me.lblMRN.ReadOnly = True
        Me.lblMRN.Size = New System.Drawing.Size(118, 27)
        Me.lblMRN.TabIndex = 8
        '
        'LBL
        '
        Me.LBL.AutoSize = True
        Me.LBL.Location = New System.Drawing.Point(27, 39)
        Me.LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL.Name = "LBL"
        Me.LBL.Size = New System.Drawing.Size(51, 20)
        Me.LBL.TabIndex = 6
        Me.LBL.Text = "Name"
        '
        'txtExtSampleID
        '
        Me.txtExtSampleID.Location = New System.Drawing.Point(302, 16)
        Me.txtExtSampleID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExtSampleID.Name = "txtExtSampleID"
        Me.txtExtSampleID.Size = New System.Drawing.Size(161, 27)
        Me.txtExtSampleID.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(200, 19)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Ext. SampleID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 19)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Chart #"
        '
        'txtRA
        '
        Me.txtRA.BackColor = System.Drawing.Color.Transparent
        Me.txtRA.Controls.Add(Me.Panel5)
        Me.txtRA.Controls.Add(Me.Label69)
        Me.txtRA.Controls.Add(Me.btnOrderHaem)
        Me.txtRA.Controls.Add(Me.btnValHaem)
        Me.txtRA.Controls.Add(Me.btnHaemSave)
        Me.txtRA.Controls.Add(Me.btnRepeat)
        Me.txtRA.Controls.Add(Me.btnHaemGrap)
        Me.txtRA.Controls.Add(Me.PictureBox12)
        Me.txtRA.Controls.Add(Me.Label68)
        Me.txtRA.Controls.Add(Me.txtSpecComm)
        Me.txtRA.Controls.Add(Me.Label67)
        Me.txtRA.Controls.Add(Me.txtFilCom)
        Me.txtRA.Controls.Add(Me.Label66)
        Me.txtRA.Controls.Add(Me.cmbHaemComm)
        Me.txtRA.Controls.Add(Me.cmbFilmCom)
        Me.txtRA.Controls.Add(Me.chkFilm)
        Me.txtRA.Controls.Add(Me.btnManDiff)
        Me.txtRA.Controls.Add(Me.gOutstandingHaem)
        Me.txtRA.Controls.Add(Me.Panel4)
        Me.txtRA.Controls.Add(Me.Label65)
        Me.txtRA.Controls.Add(Me.Panel3)
        Me.txtRA.Controls.Add(Me.Panel2)
        Me.txtRA.Controls.Add(Me.Panel1)
        Me.txtRA.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.txtRA.Location = New System.Drawing.Point(4, 33)
        Me.txtRA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRA.Name = "txtRA"
        Me.txtRA.Padding = New System.Windows.Forms.Padding(2)
        Me.txtRA.Size = New System.Drawing.Size(1049, 469)
        Me.txtRA.TabIndex = 1
        Me.txtRA.Text = "Haemaology"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.txt48)
        Me.Panel5.Controls.Add(Me.Label74)
        Me.Panel5.Controls.Add(Me.Label73)
        Me.Panel5.Controls.Add(Me.txtCD8P)
        Me.Panel5.Controls.Add(Me.txtCD8A)
        Me.Panel5.Controls.Add(Me.CD8)
        Me.Panel5.Controls.Add(Me.Label72)
        Me.Panel5.Controls.Add(Me.txtCD4P)
        Me.Panel5.Controls.Add(Me.txtCD4A)
        Me.Panel5.Controls.Add(Me.CD4)
        Me.Panel5.Controls.Add(Me.Label71)
        Me.Panel5.Controls.Add(Me.txtCD3P)
        Me.Panel5.Controls.Add(Me.TXTCD3A)
        Me.Panel5.Controls.Add(Me.Label70)
        Me.Panel5.Location = New System.Drawing.Point(945, 310)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(100, 146)
        Me.Panel5.TabIndex = 63
        '
        'txt48
        '
        Me.txt48.Location = New System.Drawing.Point(38, 124)
        Me.txt48.Margin = New System.Windows.Forms.Padding(2)
        Me.txt48.Name = "txt48"
        Me.txt48.Size = New System.Drawing.Size(38, 27)
        Me.txt48.TabIndex = 39
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label74.Location = New System.Drawing.Point(2, 113)
        Me.Label74.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(31, 20)
        Me.Label74.TabIndex = 38
        Me.Label74.Text = "4/8"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label73.Location = New System.Drawing.Point(74, 94)
        Me.Label73.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(21, 20)
        Me.Label73.TabIndex = 37
        Me.Label73.Text = "%"
        '
        'txtCD8P
        '
        Me.txtCD8P.Location = New System.Drawing.Point(38, 92)
        Me.txtCD8P.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCD8P.Name = "txtCD8P"
        Me.txtCD8P.Size = New System.Drawing.Size(38, 27)
        Me.txtCD8P.TabIndex = 36
        '
        'txtCD8A
        '
        Me.txtCD8A.Location = New System.Drawing.Point(2, 92)
        Me.txtCD8A.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCD8A.Name = "txtCD8A"
        Me.txtCD8A.Size = New System.Drawing.Size(38, 27)
        Me.txtCD8A.TabIndex = 35
        '
        'CD8
        '
        Me.CD8.AutoSize = True
        Me.CD8.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.CD8.Location = New System.Drawing.Point(4, 77)
        Me.CD8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CD8.Name = "CD8"
        Me.CD8.Size = New System.Drawing.Size(38, 20)
        Me.CD8.TabIndex = 34
        Me.CD8.Text = "CD8"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label72.Location = New System.Drawing.Point(74, 58)
        Me.Label72.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(21, 20)
        Me.Label72.TabIndex = 33
        Me.Label72.Text = "%"
        '
        'txtCD4P
        '
        Me.txtCD4P.Location = New System.Drawing.Point(38, 56)
        Me.txtCD4P.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCD4P.Name = "txtCD4P"
        Me.txtCD4P.Size = New System.Drawing.Size(38, 27)
        Me.txtCD4P.TabIndex = 32
        '
        'txtCD4A
        '
        Me.txtCD4A.Location = New System.Drawing.Point(1, 56)
        Me.txtCD4A.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCD4A.Name = "txtCD4A"
        Me.txtCD4A.Size = New System.Drawing.Size(38, 27)
        Me.txtCD4A.TabIndex = 31
        '
        'CD4
        '
        Me.CD4.AutoSize = True
        Me.CD4.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.CD4.Location = New System.Drawing.Point(4, 41)
        Me.CD4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CD4.Name = "CD4"
        Me.CD4.Size = New System.Drawing.Size(38, 20)
        Me.CD4.TabIndex = 30
        Me.CD4.Text = "CD4"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label71.Location = New System.Drawing.Point(75, 22)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(21, 20)
        Me.Label71.TabIndex = 29
        Me.Label71.Text = "%"
        '
        'txtCD3P
        '
        Me.txtCD3P.Location = New System.Drawing.Point(38, 20)
        Me.txtCD3P.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCD3P.Name = "txtCD3P"
        Me.txtCD3P.Size = New System.Drawing.Size(38, 27)
        Me.txtCD3P.TabIndex = 28
        '
        'TXTCD3A
        '
        Me.TXTCD3A.Location = New System.Drawing.Point(1, 20)
        Me.TXTCD3A.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTCD3A.Name = "TXTCD3A"
        Me.TXTCD3A.Size = New System.Drawing.Size(38, 27)
        Me.TXTCD3A.TabIndex = 27
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label70.Location = New System.Drawing.Point(4, 3)
        Me.Label70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(38, 20)
        Me.Label70.TabIndex = 26
        Me.Label70.Text = "CD3"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label69.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!)
        Me.Label69.ForeColor = System.Drawing.Color.IndianRed
        Me.Label69.Location = New System.Drawing.Point(949, 290)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(107, 24)
        Me.Label69.TabIndex = 62
        Me.Label69.Text = "Sapphire - A"
        '
        'btnOrderHaem
        '
        Me.btnOrderHaem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOrderHaem.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderHaem.Location = New System.Drawing.Point(758, 383)
        Me.btnOrderHaem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderHaem.Name = "btnOrderHaem"
        Me.btnOrderHaem.Size = New System.Drawing.Size(85, 42)
        Me.btnOrderHaem.TabIndex = 61
        Me.btnOrderHaem.Text = "Order Tests"
        Me.btnOrderHaem.UseVisualStyleBackColor = True
        '
        'btnValHaem
        '
        Me.btnValHaem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValHaem.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnValHaem.Location = New System.Drawing.Point(856, 337)
        Me.btnValHaem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValHaem.Name = "btnValHaem"
        Me.btnValHaem.Size = New System.Drawing.Size(85, 38)
        Me.btnValHaem.TabIndex = 60
        Me.btnValHaem.Text = "Validate"
        Me.btnValHaem.UseVisualStyleBackColor = True
        '
        'btnHaemSave
        '
        Me.btnHaemSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHaemSave.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHaemSave.Location = New System.Drawing.Point(758, 336)
        Me.btnHaemSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHaemSave.Name = "btnHaemSave"
        Me.btnHaemSave.Size = New System.Drawing.Size(85, 38)
        Me.btnHaemSave.TabIndex = 59
        Me.btnHaemSave.Text = "Save"
        Me.btnHaemSave.UseVisualStyleBackColor = True
        '
        'btnRepeat
        '
        Me.btnRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRepeat.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRepeat.Location = New System.Drawing.Point(856, 292)
        Me.btnRepeat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRepeat.Name = "btnRepeat"
        Me.btnRepeat.Size = New System.Drawing.Size(85, 38)
        Me.btnRepeat.TabIndex = 58
        Me.btnRepeat.Text = "View Repeat"
        Me.btnRepeat.UseVisualStyleBackColor = True
        '
        'btnHaemGrap
        '
        Me.btnHaemGrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHaemGrap.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHaemGrap.Location = New System.Drawing.Point(758, 292)
        Me.btnHaemGrap.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHaemGrap.Name = "btnHaemGrap"
        Me.btnHaemGrap.Size = New System.Drawing.Size(85, 38)
        Me.btnHaemGrap.TabIndex = 57
        Me.btnHaemGrap.Text = "Haem Graph"
        Me.btnHaemGrap.UseVisualStyleBackColor = True
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(54, 381)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(688, 74)
        Me.PictureBox12.TabIndex = 56
        Me.PictureBox12.TabStop = False
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Segoe UI Variable Display", 8.0!)
        Me.Label68.Location = New System.Drawing.Point(10, 330)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(71, 38)
        Me.Label68.TabIndex = 55
        Me.Label68.Text = "Film" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtSpecComm
        '
        Me.txtSpecComm.AcceptsReturn = True
        Me.txtSpecComm.Location = New System.Drawing.Point(76, 321)
        Me.txtSpecComm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSpecComm.Multiline = True
        Me.txtSpecComm.Name = "txtSpecComm"
        Me.txtSpecComm.Size = New System.Drawing.Size(667, 57)
        Me.txtSpecComm.TabIndex = 54
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Segoe UI Variable Display", 8.0!)
        Me.Label67.Location = New System.Drawing.Point(10, 277)
        Me.Label67.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(71, 38)
        Me.Label67.TabIndex = 53
        Me.Label67.Text = "Film" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtFilCom
        '
        Me.txtFilCom.Location = New System.Drawing.Point(76, 262)
        Me.txtFilCom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFilCom.Multiline = True
        Me.txtFilCom.Name = "txtFilCom"
        Me.txtFilCom.Size = New System.Drawing.Size(667, 57)
        Me.txtFilCom.TabIndex = 52
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Segoe UI Variable Display", 8.0!)
        Me.Label66.Location = New System.Drawing.Point(397, 241)
        Me.Label66.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(134, 19)
        Me.Label66.TabIndex = 33
        Me.Label66.Text = "Specimen Comment"
        '
        'cmbHaemComm
        '
        Me.cmbHaemComm.FormattingEnabled = True
        Me.cmbHaemComm.Location = New System.Drawing.Point(517, 236)
        Me.cmbHaemComm.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbHaemComm.Name = "cmbHaemComm"
        Me.cmbHaemComm.Size = New System.Drawing.Size(226, 28)
        Me.cmbHaemComm.TabIndex = 32
        Me.cmbHaemComm.Text = "cmbHaemComment"
        '
        'cmbFilmCom
        '
        Me.cmbFilmCom.FormattingEnabled = True
        Me.cmbFilmCom.Location = New System.Drawing.Point(172, 236)
        Me.cmbFilmCom.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFilmCom.Name = "cmbFilmCom"
        Me.cmbFilmCom.Size = New System.Drawing.Size(226, 28)
        Me.cmbFilmCom.TabIndex = 31
        Me.cmbFilmCom.Text = "cmbFilmComment"
        '
        'chkFilm
        '
        Me.chkFilm.AutoSize = True
        Me.chkFilm.Location = New System.Drawing.Point(117, 238)
        Me.chkFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkFilm.Name = "chkFilm"
        Me.chkFilm.Size = New System.Drawing.Size(57, 24)
        Me.chkFilm.TabIndex = 30
        Me.chkFilm.Text = "Film"
        Me.chkFilm.UseVisualStyleBackColor = True
        '
        'btnManDiff
        '
        Me.btnManDiff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnManDiff.Location = New System.Drawing.Point(34, 236)
        Me.btnManDiff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManDiff.Name = "btnManDiff"
        Me.btnManDiff.Size = New System.Drawing.Size(79, 20)
        Me.btnManDiff.TabIndex = 10
        Me.btnManDiff.Text = "Man. Diff"
        Me.btnManDiff.UseVisualStyleBackColor = True
        '
        'gOutstandingHaem
        '
        Me.gOutstandingHaem.ColumnHeadersHeight = 25
        Me.gOutstandingHaem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Outstanding})
        Me.gOutstandingHaem.Location = New System.Drawing.Point(962, 14)
        Me.gOutstandingHaem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gOutstandingHaem.Name = "gOutstandingHaem"
        Me.gOutstandingHaem.RowHeadersVisible = False
        Me.gOutstandingHaem.RowHeadersWidth = 51
        Me.gOutstandingHaem.RowTemplate.Height = 29
        Me.gOutstandingHaem.Size = New System.Drawing.Size(84, 260)
        Me.gOutstandingHaem.TabIndex = 5
        '
        'Outstanding
        '
        Me.Outstanding.HeaderText = "Outstanding"
        Me.Outstanding.MinimumWidth = 6
        Me.Outstanding.Name = "Outstanding"
        Me.Outstanding.Width = 125
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btnSick)
        Me.Panel4.Controls.Add(Me.btnMalria)
        Me.Panel4.Controls.Add(Me.btnInfect)
        Me.Panel4.Controls.Add(Me.btnESRPrint)
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Controls.Add(Me.chkRA)
        Me.Panel4.Controls.Add(Me.txtSick)
        Me.Panel4.Controls.Add(Me.chkSick)
        Me.Panel4.Controls.Add(Me.txtMal)
        Me.Panel4.Controls.Add(Me.chkMal)
        Me.Panel4.Controls.Add(Me.txtInfect)
        Me.Panel4.Controls.Add(Me.ckfInfec)
        Me.Panel4.Controls.Add(Me.Label56)
        Me.Panel4.Controls.Add(Me.txtRetP)
        Me.Panel4.Controls.Add(Me.txtRetA)
        Me.Panel4.Controls.Add(Me.chkRetics)
        Me.Panel4.Controls.Add(Me.txtESR)
        Me.Panel4.Controls.Add(Me.chkESR)
        Me.Panel4.Location = New System.Drawing.Point(786, 14)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(171, 263)
        Me.Panel4.TabIndex = 4
        '
        'btnSick
        '
        Me.btnSick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSick.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.btnSick.Location = New System.Drawing.Point(115, 201)
        Me.btnSick.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSick.Name = "btnSick"
        Me.btnSick.Size = New System.Drawing.Size(38, 26)
        Me.btnSick.TabIndex = 36
        Me.btnSick.Text = "Print"
        Me.btnSick.UseVisualStyleBackColor = True
        '
        'btnMalria
        '
        Me.btnMalria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMalria.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.btnMalria.Location = New System.Drawing.Point(115, 158)
        Me.btnMalria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMalria.Name = "btnMalria"
        Me.btnMalria.Size = New System.Drawing.Size(38, 26)
        Me.btnMalria.TabIndex = 35
        Me.btnMalria.Text = "Print"
        Me.btnMalria.UseVisualStyleBackColor = True
        '
        'btnInfect
        '
        Me.btnInfect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfect.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.btnInfect.Location = New System.Drawing.Point(115, 110)
        Me.btnInfect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInfect.Name = "btnInfect"
        Me.btnInfect.Size = New System.Drawing.Size(38, 26)
        Me.btnInfect.TabIndex = 34
        Me.btnInfect.Text = "Print"
        Me.btnInfect.UseVisualStyleBackColor = True
        '
        'btnESRPrint
        '
        Me.btnESRPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnESRPrint.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.btnESRPrint.Location = New System.Drawing.Point(115, 22)
        Me.btnESRPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnESRPrint.Name = "btnESRPrint"
        Me.btnESRPrint.Size = New System.Drawing.Size(38, 26)
        Me.btnESRPrint.TabIndex = 33
        Me.btnESRPrint.Text = "Print"
        Me.btnESRPrint.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(18, 238)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(84, 27)
        Me.TextBox6.TabIndex = 32
        '
        'chkRA
        '
        Me.chkRA.AutoSize = True
        Me.chkRA.Location = New System.Drawing.Point(18, 220)
        Me.chkRA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkRA.Name = "chkRA"
        Me.chkRA.Size = New System.Drawing.Size(50, 24)
        Me.chkRA.TabIndex = 31
        Me.chkRA.Text = "RA"
        Me.chkRA.UseVisualStyleBackColor = True
        '
        'txtSick
        '
        Me.txtSick.Location = New System.Drawing.Point(18, 197)
        Me.txtSick.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSick.Name = "txtSick"
        Me.txtSick.Size = New System.Drawing.Size(84, 27)
        Me.txtSick.TabIndex = 30
        '
        'chkSick
        '
        Me.chkSick.AutoSize = True
        Me.chkSick.Location = New System.Drawing.Point(18, 179)
        Me.chkSick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSick.Name = "chkSick"
        Me.chkSick.Size = New System.Drawing.Size(141, 24)
        Me.chkSick.TabIndex = 29
        Me.chkSick.Text = "Sickledex Screen"
        Me.chkSick.UseVisualStyleBackColor = True
        '
        'txtMal
        '
        Me.txtMal.Location = New System.Drawing.Point(18, 158)
        Me.txtMal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMal.Name = "txtMal"
        Me.txtMal.Size = New System.Drawing.Size(84, 27)
        Me.txtMal.TabIndex = 28
        '
        'chkMal
        '
        Me.chkMal.AutoSize = True
        Me.chkMal.Location = New System.Drawing.Point(18, 140)
        Me.chkMal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMal.Name = "chkMal"
        Me.chkMal.Size = New System.Drawing.Size(125, 24)
        Me.chkMal.TabIndex = 27
        Me.chkMal.Text = "Malaria Screen"
        Me.chkMal.UseVisualStyleBackColor = True
        '
        'txtInfect
        '
        Me.txtInfect.Location = New System.Drawing.Point(18, 118)
        Me.txtInfect.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInfect.Name = "txtInfect"
        Me.txtInfect.Size = New System.Drawing.Size(84, 27)
        Me.txtInfect.TabIndex = 26
        '
        'ckfInfec
        '
        Me.ckfInfec.AutoSize = True
        Me.ckfInfec.Location = New System.Drawing.Point(18, 86)
        Me.ckfInfec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckfInfec.Name = "ckfInfec"
        Me.ckfInfec.Size = New System.Drawing.Size(116, 44)
        Me.ckfInfec.TabIndex = 25
        Me.ckfInfec.Text = "Infectious" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mano screen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ckfInfec.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label56.Location = New System.Drawing.Point(105, 75)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(21, 20)
        Me.Label56.TabIndex = 24
        Me.Label56.Text = "%"
        '
        'txtRetP
        '
        Me.txtRetP.Location = New System.Drawing.Point(59, 69)
        Me.txtRetP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRetP.Name = "txtRetP"
        Me.txtRetP.Size = New System.Drawing.Size(43, 27)
        Me.txtRetP.TabIndex = 19
        '
        'txtRetA
        '
        Me.txtRetA.Location = New System.Drawing.Point(18, 69)
        Me.txtRetA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRetA.Name = "txtRetA"
        Me.txtRetA.Size = New System.Drawing.Size(38, 27)
        Me.txtRetA.TabIndex = 18
        '
        'chkRetics
        '
        Me.chkRetics.AutoSize = True
        Me.chkRetics.Location = New System.Drawing.Point(18, 52)
        Me.chkRetics.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkRetics.Name = "chkRetics"
        Me.chkRetics.Size = New System.Drawing.Size(71, 24)
        Me.chkRetics.TabIndex = 17
        Me.chkRetics.Text = "Retics"
        Me.chkRetics.UseVisualStyleBackColor = True
        '
        'txtESR
        '
        Me.txtESR.Location = New System.Drawing.Point(18, 29)
        Me.txtESR.Margin = New System.Windows.Forms.Padding(2)
        Me.txtESR.Name = "txtESR"
        Me.txtESR.Size = New System.Drawing.Size(84, 27)
        Me.txtESR.TabIndex = 16
        '
        'chkESR
        '
        Me.chkESR.AutoSize = True
        Me.chkESR.Location = New System.Drawing.Point(18, 11)
        Me.chkESR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkESR.Name = "chkESR"
        Me.chkESR.Size = New System.Drawing.Size(55, 24)
        Me.chkESR.TabIndex = 0
        Me.chkESR.Text = "ESR"
        Me.chkESR.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Yellow
        Me.Label65.Font = New System.Drawing.Font("Segoe UI Variable Display", 14.0!)
        Me.Label65.ForeColor = System.Drawing.Color.Red
        Me.Label65.Location = New System.Drawing.Point(753, 14)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(31, 160)
        Me.Label65.TabIndex = 3
        Me.Label65.Text = "F" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtMpv)
        Me.Panel3.Controls.Add(Me.Label64)
        Me.Panel3.Controls.Add(Me.Label46)
        Me.Panel3.Controls.Add(Me.Label47)
        Me.Panel3.Controls.Add(Me.Label49)
        Me.Panel3.Controls.Add(Me.Label57)
        Me.Panel3.Controls.Add(Me.Label58)
        Me.Panel3.Controls.Add(Me.Label59)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.TextBox7)
        Me.Panel3.Controls.Add(Me.TextBox13)
        Me.Panel3.Controls.Add(Me.TextBox14)
        Me.Panel3.Controls.Add(Me.TextBox19)
        Me.Panel3.Controls.Add(Me.Label60)
        Me.Panel3.Controls.Add(Me.TextBox20)
        Me.Panel3.Controls.Add(Me.TextBox21)
        Me.Panel3.Controls.Add(Me.txtPlt)
        Me.Panel3.Controls.Add(Me.Label61)
        Me.Panel3.Controls.Add(Me.Label62)
        Me.Panel3.Controls.Add(Me.Label63)
        Me.Panel3.Location = New System.Drawing.Point(403, 178)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 56)
        Me.Panel3.TabIndex = 2
        '
        'txtMpv
        '
        Me.txtMpv.Location = New System.Drawing.Point(229, 27)
        Me.txtMpv.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMpv.Name = "txtMpv"
        Me.txtMpv.Size = New System.Drawing.Size(84, 27)
        Me.txtMpv.TabIndex = 38
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label64.Location = New System.Drawing.Point(192, 29)
        Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(39, 20)
        Me.Label64.TabIndex = 37
        Me.Label64.Text = "MPV"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(180, 126)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(60, 20)
        Me.Label46.TabIndex = 36
        Me.Label46.Text = "RDWSD"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(180, 102)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(62, 20)
        Me.Label47.TabIndex = 35
        Me.Label47.Text = "RDWCV"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label49.ForeColor = System.Drawing.Color.Red
        Me.Label49.Location = New System.Drawing.Point(186, 80)
        Me.Label49.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(55, 20)
        Me.Label49.TabIndex = 34
        Me.Label49.Text = "MCHC"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label57.ForeColor = System.Drawing.Color.Red
        Me.Label57.Location = New System.Drawing.Point(32, 100)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(42, 20)
        Me.Label57.TabIndex = 32
        Me.Label57.Text = "MCV"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label58.ForeColor = System.Drawing.Color.Red
        Me.Label58.Location = New System.Drawing.Point(36, 76)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(33, 20)
        Me.Label58.TabIndex = 31
        Me.Label58.Text = "Hct"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label59.Location = New System.Drawing.Point(260, 147)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(21, 20)
        Me.Label59.TabIndex = 23
        Me.Label59.Text = "%"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(169, 145)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(84, 27)
        Me.TextBox5.TabIndex = 20
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(243, 122)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(84, 27)
        Me.TextBox7.TabIndex = 18
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(243, 99)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(84, 27)
        Me.TextBox13.TabIndex = 17
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(243, 76)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(84, 27)
        Me.TextBox14.TabIndex = 16
        '
        'TextBox19
        '
        Me.TextBox19.Enabled = False
        Me.TextBox19.Location = New System.Drawing.Point(75, 145)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(84, 27)
        Me.TextBox19.TabIndex = 13
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(32, 149)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(45, 20)
        Me.Label60.TabIndex = 12
        Me.Label60.Text = "nRBC"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(76, 99)
        Me.TextBox20.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(84, 27)
        Me.TextBox20.TabIndex = 9
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(76, 76)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(84, 27)
        Me.TextBox21.TabIndex = 8
        '
        'txtPlt
        '
        Me.txtPlt.Location = New System.Drawing.Point(76, 28)
        Me.txtPlt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlt.Name = "txtPlt"
        Me.txtPlt.Size = New System.Drawing.Size(84, 27)
        Me.txtPlt.TabIndex = 6
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label61.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label61.Location = New System.Drawing.Point(249, 5)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(73, 20)
        Me.Label61.TabIndex = 5
        Me.Label61.Text = "Abnormal"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label62.Location = New System.Drawing.Point(36, 32)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(25, 20)
        Me.Label62.TabIndex = 4
        Me.Label62.Text = "Plt"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label63.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label63.Location = New System.Drawing.Point(14, 7)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(62, 20)
        Me.Label63.TabIndex = 2
        Me.Label63.Text = "Suspect"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label45)
        Me.Panel2.Controls.Add(Me.Label44)
        Me.Panel2.Controls.Add(Me.Label43)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.Label55)
        Me.Panel2.Controls.Add(Me.Label54)
        Me.Panel2.Controls.Add(Me.btnHgb)
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Controls.Add(Me.txtnRBCp)
        Me.Panel2.Controls.Add(Me.txtRDWSD)
        Me.Panel2.Controls.Add(Me.txtRDWCV)
        Me.Panel2.Controls.Add(Me.txtMCHC)
        Me.Panel2.Controls.Add(Me.txtIRF)
        Me.Panel2.Controls.Add(Me.txtnRBCA)
        Me.Panel2.Controls.Add(Me.Label50)
        Me.Panel2.Controls.Add(Me.txtMCV)
        Me.Panel2.Controls.Add(Me.txtHct)
        Me.Panel2.Controls.Add(Me.txtHgb)
        Me.Panel2.Controls.Add(Me.txtRbc)
        Me.Panel2.Controls.Add(Me.Label51)
        Me.Panel2.Controls.Add(Me.Label52)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Location = New System.Drawing.Point(402, 14)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 161)
        Me.Panel2.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label45.ForeColor = System.Drawing.Color.Red
        Me.Label45.Location = New System.Drawing.Point(178, 107)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(60, 20)
        Me.Label45.TabIndex = 36
        Me.Label45.Text = "RDWSD"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(178, 85)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(62, 20)
        Me.Label44.TabIndex = 35
        Me.Label44.Text = "RDWCV"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label43.ForeColor = System.Drawing.Color.Red
        Me.Label43.Location = New System.Drawing.Point(186, 58)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(55, 20)
        Me.Label43.TabIndex = 34
        Me.Label43.Text = "MCHC"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(207, 34)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(29, 20)
        Me.Label42.TabIndex = 33
        Me.Label42.Text = "IRF"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label55.ForeColor = System.Drawing.Color.Red
        Me.Label55.Location = New System.Drawing.Point(32, 100)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(42, 20)
        Me.Label55.TabIndex = 32
        Me.Label55.Text = "MCV"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label54.ForeColor = System.Drawing.Color.Red
        Me.Label54.Location = New System.Drawing.Point(36, 76)
        Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 20)
        Me.Label54.TabIndex = 31
        Me.Label54.Text = "Hct"
        '
        'btnHgb
        '
        Me.btnHgb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHgb.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.btnHgb.Location = New System.Drawing.Point(14, 50)
        Me.btnHgb.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHgb.Name = "btnHgb"
        Me.btnHgb.Size = New System.Drawing.Size(54, 20)
        Me.btnHgb.TabIndex = 30
        Me.btnHgb.Text = "Hgb"
        Me.btnHgb.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label48.Location = New System.Drawing.Point(260, 135)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(21, 20)
        Me.Label48.TabIndex = 23
        Me.Label48.Text = "%"
        '
        'txtnRBCp
        '
        Me.txtnRBCp.Location = New System.Drawing.Point(164, 132)
        Me.txtnRBCp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnRBCp.Name = "txtnRBCp"
        Me.txtnRBCp.Size = New System.Drawing.Size(84, 27)
        Me.txtnRBCp.TabIndex = 20
        '
        'txtRDWSD
        '
        Me.txtRDWSD.Location = New System.Drawing.Point(243, 107)
        Me.txtRDWSD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRDWSD.Name = "txtRDWSD"
        Me.txtRDWSD.Size = New System.Drawing.Size(84, 27)
        Me.txtRDWSD.TabIndex = 18
        '
        'txtRDWCV
        '
        Me.txtRDWCV.Location = New System.Drawing.Point(243, 83)
        Me.txtRDWCV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRDWCV.Name = "txtRDWCV"
        Me.txtRDWCV.Size = New System.Drawing.Size(84, 27)
        Me.txtRDWCV.TabIndex = 17
        '
        'txtMCHC
        '
        Me.txtMCHC.Location = New System.Drawing.Point(243, 58)
        Me.txtMCHC.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMCHC.Name = "txtMCHC"
        Me.txtMCHC.Size = New System.Drawing.Size(84, 27)
        Me.txtMCHC.TabIndex = 16
        '
        'txtIRF
        '
        Me.txtIRF.Location = New System.Drawing.Point(243, 34)
        Me.txtIRF.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIRF.Name = "txtIRF"
        Me.txtIRF.Size = New System.Drawing.Size(84, 27)
        Me.txtIRF.TabIndex = 15
        '
        'txtnRBCA
        '
        Me.txtnRBCA.Enabled = False
        Me.txtnRBCA.Location = New System.Drawing.Point(76, 132)
        Me.txtnRBCA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnRBCA.Name = "txtnRBCA"
        Me.txtnRBCA.Size = New System.Drawing.Size(84, 27)
        Me.txtnRBCA.TabIndex = 13
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(29, 135)
        Me.Label50.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(45, 20)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "nRBC"
        '
        'txtMCV
        '
        Me.txtMCV.Location = New System.Drawing.Point(76, 99)
        Me.txtMCV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMCV.Name = "txtMCV"
        Me.txtMCV.Size = New System.Drawing.Size(84, 27)
        Me.txtMCV.TabIndex = 9
        '
        'txtHct
        '
        Me.txtHct.Location = New System.Drawing.Point(76, 76)
        Me.txtHct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHct.Name = "txtHct"
        Me.txtHct.Size = New System.Drawing.Size(84, 27)
        Me.txtHct.TabIndex = 8
        '
        'txtHgb
        '
        Me.txtHgb.Location = New System.Drawing.Point(76, 54)
        Me.txtHgb.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHgb.Name = "txtHgb"
        Me.txtHgb.Size = New System.Drawing.Size(84, 27)
        Me.txtHgb.TabIndex = 7
        '
        'txtRbc
        '
        Me.txtRbc.Location = New System.Drawing.Point(76, 32)
        Me.txtRbc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRbc.Name = "txtRbc"
        Me.txtRbc.Size = New System.Drawing.Size(84, 27)
        Me.txtRbc.TabIndex = 6
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label51.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label51.Location = New System.Drawing.Point(260, 11)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(73, 20)
        Me.Label51.TabIndex = 5
        Me.Label51.Text = "Abnormal"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label52.ForeColor = System.Drawing.Color.Red
        Me.Label52.Location = New System.Drawing.Point(36, 33)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(37, 20)
        Me.Label52.TabIndex = 4
        Me.Label52.Text = "RBC"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label53.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label53.Location = New System.Drawing.Point(14, 10)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(62, 20)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Suspect"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.txtWVF)
        Me.Panel1.Controls.Add(Me.txtWOC)
        Me.Panel1.Controls.Add(Me.txtBasP)
        Me.Panel1.Controls.Add(Me.txtEosP)
        Me.Panel1.Controls.Add(Me.txtMonoP)
        Me.Panel1.Controls.Add(Me.txtLymphP)
        Me.Panel1.Controls.Add(Me.txtNeutP)
        Me.Panel1.Controls.Add(Me.btnClearDiff)
        Me.Panel1.Controls.Add(Me.txtWIC)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.txtBasA)
        Me.Panel1.Controls.Add(Me.txtEosA)
        Me.Panel1.Controls.Add(Me.txtMonoA)
        Me.Panel1.Controls.Add(Me.txtLymphA)
        Me.Panel1.Controls.Add(Me.txtNeutA)
        Me.Panel1.Controls.Add(Me.txtWBC)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Location = New System.Drawing.Point(38, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 219)
        Me.Panel1.TabIndex = 0
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label41.Location = New System.Drawing.Point(200, 188)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(39, 20)
        Me.Label41.TabIndex = 29
        Me.Label41.Text = "WVF"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label40.Location = New System.Drawing.Point(194, 166)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(45, 20)
        Me.Label40.TabIndex = 28
        Me.Label40.Text = "WOC"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label39.Location = New System.Drawing.Point(206, 145)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(31, 20)
        Me.Label39.TabIndex = 27
        Me.Label39.Text = "Bas"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label38.Location = New System.Drawing.Point(206, 122)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(32, 20)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "Eos"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label37.Location = New System.Drawing.Point(192, 102)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 20)
        Me.Label37.TabIndex = 25
        Me.Label37.Text = "Mono"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label36.Location = New System.Drawing.Point(187, 80)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 20)
        Me.Label36.TabIndex = 24
        Me.Label36.Text = "Lymph"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(331, 58)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(21, 20)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "%"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label34.Location = New System.Drawing.Point(198, 58)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 20)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = "Neut"
        '
        'txtWVF
        '
        Me.txtWVF.Location = New System.Drawing.Point(243, 188)
        Me.txtWVF.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWVF.Name = "txtWVF"
        Me.txtWVF.Size = New System.Drawing.Size(84, 27)
        Me.txtWVF.TabIndex = 21
        '
        'txtWOC
        '
        Me.txtWOC.Location = New System.Drawing.Point(243, 166)
        Me.txtWOC.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWOC.Name = "txtWOC"
        Me.txtWOC.Size = New System.Drawing.Size(84, 27)
        Me.txtWOC.TabIndex = 20
        '
        'txtBasP
        '
        Me.txtBasP.Location = New System.Drawing.Point(243, 144)
        Me.txtBasP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBasP.Name = "txtBasP"
        Me.txtBasP.Size = New System.Drawing.Size(84, 27)
        Me.txtBasP.TabIndex = 19
        '
        'txtEosP
        '
        Me.txtEosP.Location = New System.Drawing.Point(243, 122)
        Me.txtEosP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEosP.Name = "txtEosP"
        Me.txtEosP.Size = New System.Drawing.Size(84, 27)
        Me.txtEosP.TabIndex = 18
        '
        'txtMonoP
        '
        Me.txtMonoP.Location = New System.Drawing.Point(243, 99)
        Me.txtMonoP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonoP.Name = "txtMonoP"
        Me.txtMonoP.Size = New System.Drawing.Size(84, 27)
        Me.txtMonoP.TabIndex = 17
        '
        'txtLymphP
        '
        Me.txtLymphP.Location = New System.Drawing.Point(243, 76)
        Me.txtLymphP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLymphP.Name = "txtLymphP"
        Me.txtLymphP.Size = New System.Drawing.Size(84, 27)
        Me.txtLymphP.TabIndex = 16
        '
        'txtNeutP
        '
        Me.txtNeutP.Location = New System.Drawing.Point(243, 54)
        Me.txtNeutP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNeutP.Name = "txtNeutP"
        Me.txtNeutP.Size = New System.Drawing.Size(84, 27)
        Me.txtNeutP.TabIndex = 15
        '
        'btnClearDiff
        '
        Me.btnClearDiff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClearDiff.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.btnClearDiff.Location = New System.Drawing.Point(243, 28)
        Me.btnClearDiff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearDiff.Name = "btnClearDiff"
        Me.btnClearDiff.Size = New System.Drawing.Size(84, 20)
        Me.btnClearDiff.TabIndex = 14
        Me.btnClearDiff.Text = "Clear Diff"
        Me.btnClearDiff.UseVisualStyleBackColor = True
        '
        'txtWIC
        '
        Me.txtWIC.Enabled = False
        Me.txtWIC.Location = New System.Drawing.Point(76, 166)
        Me.txtWIC.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWIC.Name = "txtWIC"
        Me.txtWIC.Size = New System.Drawing.Size(84, 27)
        Me.txtWIC.TabIndex = 13
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label32.Location = New System.Drawing.Point(39, 169)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(38, 20)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "WIC"
        '
        'txtBasA
        '
        Me.txtBasA.Location = New System.Drawing.Point(76, 144)
        Me.txtBasA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBasA.Name = "txtBasA"
        Me.txtBasA.Size = New System.Drawing.Size(84, 27)
        Me.txtBasA.TabIndex = 11
        '
        'txtEosA
        '
        Me.txtEosA.Location = New System.Drawing.Point(76, 122)
        Me.txtEosA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEosA.Name = "txtEosA"
        Me.txtEosA.Size = New System.Drawing.Size(84, 27)
        Me.txtEosA.TabIndex = 10
        '
        'txtMonoA
        '
        Me.txtMonoA.Location = New System.Drawing.Point(76, 99)
        Me.txtMonoA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonoA.Name = "txtMonoA"
        Me.txtMonoA.Size = New System.Drawing.Size(84, 27)
        Me.txtMonoA.TabIndex = 9
        '
        'txtLymphA
        '
        Me.txtLymphA.Location = New System.Drawing.Point(76, 76)
        Me.txtLymphA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLymphA.Name = "txtLymphA"
        Me.txtLymphA.Size = New System.Drawing.Size(84, 27)
        Me.txtLymphA.TabIndex = 8
        '
        'txtNeutA
        '
        Me.txtNeutA.Location = New System.Drawing.Point(76, 54)
        Me.txtNeutA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNeutA.Name = "txtNeutA"
        Me.txtNeutA.Size = New System.Drawing.Size(84, 27)
        Me.txtNeutA.TabIndex = 7
        '
        'txtWBC
        '
        Me.txtWBC.Location = New System.Drawing.Point(76, 32)
        Me.txtWBC.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWBC.Name = "txtWBC"
        Me.txtWBC.Size = New System.Drawing.Size(84, 27)
        Me.txtWBC.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label29.Location = New System.Drawing.Point(258, 7)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 20)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Abnormal"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label33.Location = New System.Drawing.Point(36, 33)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 20)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "WBC"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!)
        Me.Label31.Location = New System.Drawing.Point(14, 10)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(87, 20)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "SampleDate"
        '
        'cmbAdd
        '
        Me.cmbAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmbAdd.Controls.Add(Me.btnViewBioRepeat)
        Me.cmbAdd.Controls.Add(Me.btnValBio)
        Me.cmbAdd.Controls.Add(Me.btnBioSave)
        Me.cmbAdd.Controls.Add(Me.Button6)
        Me.cmbAdd.Controls.Add(Me.Label78)
        Me.cmbAdd.Controls.Add(Me.TextBox9)
        Me.cmbAdd.Controls.Add(Me.txtBioAutoCom)
        Me.cmbAdd.Controls.Add(Me.GroupBox9)
        Me.cmbAdd.Controls.Add(Me.Label77)
        Me.cmbAdd.Controls.Add(Me.GroupBox8)
        Me.cmbAdd.Controls.Add(Me.btnAddBioRes)
        Me.cmbAdd.Controls.Add(Me.cmbSampleType)
        Me.cmbAdd.Controls.Add(Me.cmbUnits)
        Me.cmbAdd.Controls.Add(Me.cmbNewBioRes)
        Me.cmbAdd.Controls.Add(Me.cmbAddBio)
        Me.cmbAdd.Controls.Add(Me.split6)
        Me.cmbAdd.Controls.Add(Me.split5)
        Me.cmbAdd.Controls.Add(Me.Label76)
        Me.cmbAdd.Controls.Add(Me.split3)
        Me.cmbAdd.Controls.Add(Me.split2)
        Me.cmbAdd.Controls.Add(Me.lblSplit1)
        Me.cmbAdd.Controls.Add(Me.lblAll)
        Me.cmbAdd.Controls.Add(Me.gBioOutstand)
        Me.cmbAdd.Controls.Add(Me.gBio)
        Me.cmbAdd.Controls.Add(Me.GroupBox6)
        Me.cmbAdd.Controls.Add(Me.lblRandomS)
        Me.cmbAdd.Controls.Add(Me.lblViewAll)
        Me.cmbAdd.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbAdd.Location = New System.Drawing.Point(4, 33)
        Me.cmbAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAdd.Name = "cmbAdd"
        Me.cmbAdd.Padding = New System.Windows.Forms.Padding(2)
        Me.cmbAdd.Size = New System.Drawing.Size(1049, 469)
        Me.cmbAdd.TabIndex = 2
        Me.cmbAdd.Text = "Biochemistry"
        '
        'btnViewBioRepeat
        '
        Me.btnViewBioRepeat.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewBioRepeat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewBioRepeat.Location = New System.Drawing.Point(978, 374)
        Me.btnViewBioRepeat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewBioRepeat.Name = "btnViewBioRepeat"
        Me.btnViewBioRepeat.Size = New System.Drawing.Size(57, 82)
        Me.btnViewBioRepeat.TabIndex = 51
        Me.btnViewBioRepeat.Text = "View Repeat"
        Me.btnViewBioRepeat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewBioRepeat.UseVisualStyleBackColor = True
        '
        'btnValBio
        '
        Me.btnValBio.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnValBio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnValBio.Location = New System.Drawing.Point(918, 374)
        Me.btnValBio.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValBio.Name = "btnValBio"
        Me.btnValBio.Size = New System.Drawing.Size(57, 82)
        Me.btnValBio.TabIndex = 50
        Me.btnValBio.Text = "Validate"
        Me.btnValBio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnValBio.UseVisualStyleBackColor = True
        '
        'btnBioSave
        '
        Me.btnBioSave.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBioSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBioSave.Location = New System.Drawing.Point(860, 374)
        Me.btnBioSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBioSave.Name = "btnBioSave"
        Me.btnBioSave.Size = New System.Drawing.Size(57, 82)
        Me.btnBioSave.TabIndex = 49
        Me.btnBioSave.Text = "Save"
        Me.btnBioSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBioSave.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(797, 374)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(61, 82)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Order Tests"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Blue
        Me.Label78.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label78.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label78.Location = New System.Drawing.Point(810, 356)
        Me.Label78.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(262, 19)
        Me.Label78.TabIndex = 22
        Me.Label78.Text = " Ensure all xx Test Results are reviewed"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Gray
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(422, 404)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(374, 53)
        Me.TextBox9.TabIndex = 21
        '
        'txtBioAutoCom
        '
        Me.txtBioAutoCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBioAutoCom.Enabled = False
        Me.txtBioAutoCom.Location = New System.Drawing.Point(421, 354)
        Me.txtBioAutoCom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBioAutoCom.Multiline = True
        Me.txtBioAutoCom.Name = "txtBioAutoCom"
        Me.txtBioAutoCom.Size = New System.Drawing.Size(374, 46)
        Me.txtBioAutoCom.TabIndex = 20
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cmbBioComment2)
        Me.GroupBox9.Controls.Add(Me.txtBioComment)
        Me.GroupBox9.Controls.Add(Me.cmbBioComment)
        Me.GroupBox9.Location = New System.Drawing.Point(7, 342)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(412, 113)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Specimen Comments"
        '
        'cmbBioComment2
        '
        Me.cmbBioComment2.Enabled = False
        Me.cmbBioComment2.FormattingEnabled = True
        Me.cmbBioComment2.Location = New System.Drawing.Point(9, 88)
        Me.cmbBioComment2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBioComment2.Name = "cmbBioComment2"
        Me.cmbBioComment2.Size = New System.Drawing.Size(395, 28)
        Me.cmbBioComment2.TabIndex = 17
        '
        'txtBioComment
        '
        Me.txtBioComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBioComment.Location = New System.Drawing.Point(9, 44)
        Me.txtBioComment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBioComment.Multiline = True
        Me.txtBioComment.Name = "txtBioComment"
        Me.txtBioComment.Size = New System.Drawing.Size(395, 38)
        Me.txtBioComment.TabIndex = 16
        '
        'cmbBioComment
        '
        Me.cmbBioComment.FormattingEnabled = True
        Me.cmbBioComment.Location = New System.Drawing.Point(8, 19)
        Me.cmbBioComment.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBioComment.Name = "cmbBioComment"
        Me.cmbBioComment.Size = New System.Drawing.Size(396, 28)
        Me.cmbBioComment.TabIndex = 15
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label77.Location = New System.Drawing.Point(844, 298)
        Me.Label77.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(177, 60)
        Me.Label77.TabIndex = 19
        Me.Label77.Text = "   Associated Glucose 1   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkLip)
        Me.GroupBox8.Controls.Add(Me.chkIcteric)
        Me.GroupBox8.Controls.Add(Me.chkHaemo)
        Me.GroupBox8.Controls.Add(Me.chkOldSam)
        Me.GroupBox8.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(566, 292)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(262, 58)
        Me.GroupBox8.TabIndex = 18
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Specimen Condtion"
        '
        'chkLip
        '
        Me.chkLip.AutoSize = True
        Me.chkLip.Location = New System.Drawing.Point(136, 36)
        Me.chkLip.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkLip.Name = "chkLip"
        Me.chkLip.Size = New System.Drawing.Size(91, 23)
        Me.chkLip.TabIndex = 4
        Me.chkLip.Text = "Lipaemic"
        Me.chkLip.UseVisualStyleBackColor = True
        '
        'chkIcteric
        '
        Me.chkIcteric.AutoSize = True
        Me.chkIcteric.Location = New System.Drawing.Point(136, 18)
        Me.chkIcteric.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIcteric.Name = "chkIcteric"
        Me.chkIcteric.Size = New System.Drawing.Size(71, 23)
        Me.chkIcteric.TabIndex = 3
        Me.chkIcteric.Text = "Icteric"
        Me.chkIcteric.UseVisualStyleBackColor = True
        '
        'chkHaemo
        '
        Me.chkHaemo.AutoSize = True
        Me.chkHaemo.Location = New System.Drawing.Point(21, 37)
        Me.chkHaemo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkHaemo.Name = "chkHaemo"
        Me.chkHaemo.Size = New System.Drawing.Size(113, 23)
        Me.chkHaemo.TabIndex = 2
        Me.chkHaemo.Text = "Haemolysed"
        Me.chkHaemo.UseVisualStyleBackColor = True
        '
        'chkOldSam
        '
        Me.chkOldSam.AutoSize = True
        Me.chkOldSam.Location = New System.Drawing.Point(21, 18)
        Me.chkOldSam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkOldSam.Name = "chkOldSam"
        Me.chkOldSam.Size = New System.Drawing.Size(109, 23)
        Me.chkOldSam.TabIndex = 1
        Me.chkOldSam.Text = "Old Sample"
        Me.chkOldSam.UseVisualStyleBackColor = True
        '
        'btnAddBioRes
        '
        Me.btnAddBioRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddBioRes.Location = New System.Drawing.Point(458, 314)
        Me.btnAddBioRes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddBioRes.Name = "btnAddBioRes"
        Me.btnAddBioRes.Size = New System.Drawing.Size(82, 36)
        Me.btnAddBioRes.TabIndex = 11
        Me.btnAddBioRes.Text = "Add " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Result" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAddBioRes.UseVisualStyleBackColor = True
        '
        'cmbSampleType
        '
        Me.cmbSampleType.FormattingEnabled = True
        Me.cmbSampleType.Location = New System.Drawing.Point(368, 320)
        Me.cmbSampleType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSampleType.Name = "cmbSampleType"
        Me.cmbSampleType.Size = New System.Drawing.Size(87, 28)
        Me.cmbSampleType.TabIndex = 17
        '
        'cmbUnits
        '
        Me.cmbUnits.FormattingEnabled = True
        Me.cmbUnits.Location = New System.Drawing.Point(277, 320)
        Me.cmbUnits.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbUnits.Name = "cmbUnits"
        Me.cmbUnits.Size = New System.Drawing.Size(87, 28)
        Me.cmbUnits.TabIndex = 16
        '
        'cmbNewBioRes
        '
        Me.cmbNewBioRes.FormattingEnabled = True
        Me.cmbNewBioRes.Location = New System.Drawing.Point(146, 320)
        Me.cmbNewBioRes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbNewBioRes.Name = "cmbNewBioRes"
        Me.cmbNewBioRes.Size = New System.Drawing.Size(128, 28)
        Me.cmbNewBioRes.TabIndex = 15
        '
        'cmbAddBio
        '
        Me.cmbAddBio.FormattingEnabled = True
        Me.cmbAddBio.Location = New System.Drawing.Point(15, 320)
        Me.cmbAddBio.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAddBio.Name = "cmbAddBio"
        Me.cmbAddBio.Size = New System.Drawing.Size(128, 28)
        Me.cmbAddBio.TabIndex = 14
        '
        'split6
        '
        Me.split6.AutoSize = True
        Me.split6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.split6.Location = New System.Drawing.Point(454, 292)
        Me.split6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.split6.Name = "split6"
        Me.split6.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.split6.Size = New System.Drawing.Size(81, 22)
        Me.split6.TabIndex = 13
        Me.split6.Text = "Split 6"
        '
        'split5
        '
        Me.split5.AutoSize = True
        Me.split5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.split5.Location = New System.Drawing.Point(377, 292)
        Me.split5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.split5.Name = "split5"
        Me.split5.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.split5.Size = New System.Drawing.Size(80, 22)
        Me.split5.TabIndex = 12
        Me.split5.Text = "Split 5"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label76.Location = New System.Drawing.Point(299, 292)
        Me.Label76.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.Label76.Size = New System.Drawing.Size(81, 22)
        Me.Label76.TabIndex = 11
        Me.Label76.Text = "Split 4"
        '
        'split3
        '
        Me.split3.AutoSize = True
        Me.split3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.split3.Location = New System.Drawing.Point(222, 292)
        Me.split3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.split3.Name = "split3"
        Me.split3.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.split3.Size = New System.Drawing.Size(80, 22)
        Me.split3.TabIndex = 10
        Me.split3.Text = "Split 3"
        '
        'split2
        '
        Me.split2.AutoSize = True
        Me.split2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.split2.Location = New System.Drawing.Point(145, 292)
        Me.split2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.split2.Name = "split2"
        Me.split2.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.split2.Size = New System.Drawing.Size(80, 22)
        Me.split2.TabIndex = 9
        Me.split2.Text = "Split 2"
        '
        'lblSplit1
        '
        Me.lblSplit1.AutoSize = True
        Me.lblSplit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSplit1.Location = New System.Drawing.Point(70, 292)
        Me.lblSplit1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSplit1.Name = "lblSplit1"
        Me.lblSplit1.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.lblSplit1.Size = New System.Drawing.Size(78, 22)
        Me.lblSplit1.TabIndex = 8
        Me.lblSplit1.Text = "Split 1"
        '
        'lblAll
        '
        Me.lblAll.AutoSize = True
        Me.lblAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAll.Location = New System.Drawing.Point(15, 292)
        Me.lblAll.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.lblAll.Size = New System.Drawing.Size(55, 22)
        Me.lblAll.TabIndex = 7
        Me.lblAll.Text = "All"
        '
        'gBioOutstand
        '
        Me.gBioOutstand.ColumnHeadersHeight = 25
        Me.gBioOutstand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.gBioOutstand.Location = New System.Drawing.Point(925, 42)
        Me.gBioOutstand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBioOutstand.Name = "gBioOutstand"
        Me.gBioOutstand.RowHeadersVisible = False
        Me.gBioOutstand.RowHeadersWidth = 51
        Me.gBioOutstand.RowTemplate.Height = 29
        Me.gBioOutstand.Size = New System.Drawing.Size(97, 248)
        Me.gBioOutstand.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Outstanding"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'gBio
        '
        Me.gBio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gBio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tname, Me.Result, Me.Ranges, Me.Units, Me.Flags, Me.Analyser, Me.VP, Me.Cmt, Me.P, Me.Code})
        Me.gBio.Location = New System.Drawing.Point(15, 42)
        Me.gBio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBio.Name = "gBio"
        Me.gBio.RowHeadersVisible = False
        Me.gBio.RowHeadersWidth = 51
        Me.gBio.RowTemplate.Height = 29
        Me.gBio.Size = New System.Drawing.Size(888, 248)
        Me.gBio.TabIndex = 5
        '
        'Tname
        '
        Me.Tname.HeaderText = "Test Name"
        Me.Tname.MinimumWidth = 6
        Me.Tname.Name = "Tname"
        Me.Tname.Width = 125
        '
        'Result
        '
        Me.Result.HeaderText = "Result"
        Me.Result.MinimumWidth = 6
        Me.Result.Name = "Result"
        Me.Result.Width = 175
        '
        'Ranges
        '
        Me.Ranges.HeaderText = "Ranges"
        Me.Ranges.MinimumWidth = 6
        Me.Ranges.Name = "Ranges"
        Me.Ranges.Width = 105
        '
        'Units
        '
        Me.Units.HeaderText = "Units"
        Me.Units.MinimumWidth = 6
        Me.Units.Name = "Units"
        Me.Units.Width = 105
        '
        'Flags
        '
        Me.Flags.HeaderText = "Flags"
        Me.Flags.MinimumWidth = 6
        Me.Flags.Name = "Flags"
        Me.Flags.Width = 105
        '
        'Analyser
        '
        Me.Analyser.HeaderText = "Analyser"
        Me.Analyser.MinimumWidth = 6
        Me.Analyser.Name = "Analyser"
        Me.Analyser.Width = 115
        '
        'VP
        '
        Me.VP.HeaderText = "VP"
        Me.VP.MinimumWidth = 6
        Me.VP.Name = "VP"
        Me.VP.Width = 75
        '
        'Cmt
        '
        Me.Cmt.HeaderText = "Cmt"
        Me.Cmt.MinimumWidth = 6
        Me.Cmt.Name = "Cmt"
        Me.Cmt.Width = 90
        '
        'P
        '
        Me.P.HeaderText = "P"
        Me.P.MinimumWidth = 6
        Me.P.Name = "P"
        Me.P.Width = 50
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.MinimumWidth = 6
        Me.Code.Name = "Code"
        Me.Code.Width = 60
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Controls.Add(Me.btnBioPrintTrue)
        Me.GroupBox6.Controls.Add(Me.Label75)
        Me.GroupBox6.Location = New System.Drawing.Point(650, 4)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(219, 38)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(129, 13)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 20)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnBioPrintTrue
        '
        Me.btnBioPrintTrue.Location = New System.Drawing.Point(163, 13)
        Me.btnBioPrintTrue.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBioPrintTrue.Name = "btnBioPrintTrue"
        Me.btnBioPrintTrue.Size = New System.Drawing.Size(28, 20)
        Me.btnBioPrintTrue.TabIndex = 12
        Me.btnBioPrintTrue.Text = "✓"
        Me.btnBioPrintTrue.UseVisualStyleBackColor = True
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(4, 15)
        Me.Label75.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(134, 20)
        Me.Label75.TabIndex = 2
        Me.Label75.Text = "Select for Printing"
        '
        'lblRandomS
        '
        Me.lblRandomS.AutoSize = True
        Me.lblRandomS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRandomS.Location = New System.Drawing.Point(154, 14)
        Me.lblRandomS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRandomS.Name = "lblRandomS"
        Me.lblRandomS.Padding = New System.Windows.Forms.Padding(29, 0, 29, 0)
        Me.lblRandomS.Size = New System.Drawing.Size(182, 22)
        Me.lblRandomS.TabIndex = 3
        Me.lblRandomS.Text = "Random Sample"
        '
        'lblViewAll
        '
        Me.lblViewAll.AutoSize = True
        Me.lblViewAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblViewAll.Location = New System.Drawing.Point(15, 14)
        Me.lblViewAll.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblViewAll.Name = "lblViewAll"
        Me.lblViewAll.Padding = New System.Windows.Forms.Padding(29, 0, 29, 0)
        Me.lblViewAll.Size = New System.Drawing.Size(147, 22)
        Me.lblViewAll.TabIndex = 2
        Me.lblViewAll.Text = "Viewing All"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage4.Controls.Add(Me.btnCoagVali)
        Me.TabPage4.Controls.Add(Me.btnCoagSave)
        Me.TabPage4.Controls.Add(Me.btnPrintAll)
        Me.TabPage4.Controls.Add(Me.btnCoagAddRes)
        Me.TabPage4.Controls.Add(Me.txtDeltaCheck)
        Me.TabPage4.Controls.Add(Me.Label84)
        Me.TabPage4.Controls.Add(Me.txtAutoComm)
        Me.TabPage4.Controls.Add(Me.Label83)
        Me.TabPage4.Controls.Add(Me.txtCoagRes)
        Me.TabPage4.Controls.Add(Me.cmbParameter)
        Me.TabPage4.Controls.Add(Me.cmbCoagComment)
        Me.TabPage4.Controls.Add(Me.txtSpecCoag)
        Me.TabPage4.Controls.Add(Me.Label82)
        Me.TabPage4.Controls.Add(Me.btnOrderCoag)
        Me.TabPage4.Controls.Add(Me.btnCoagRep)
        Me.TabPage4.Controls.Add(Me.txtCoagAnal)
        Me.TabPage4.Controls.Add(Me.Label81)
        Me.TabPage4.Controls.Add(Me.GroupBox11)
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Controls.Add(Me.Label80)
        Me.TabPage4.Controls.Add(Me.gCoag)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Controls.Add(Me.GroupBox10)
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(1049, 469)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Coagulation"
        '
        'btnCoagVali
        '
        Me.btnCoagVali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCoagVali.Location = New System.Drawing.Point(812, 389)
        Me.btnCoagVali.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoagVali.Name = "btnCoagVali"
        Me.btnCoagVali.Size = New System.Drawing.Size(69, 53)
        Me.btnCoagVali.TabIndex = 28
        Me.btnCoagVali.Text = "Validate"
        Me.btnCoagVali.UseVisualStyleBackColor = True
        '
        'btnCoagSave
        '
        Me.btnCoagSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCoagSave.Location = New System.Drawing.Point(722, 389)
        Me.btnCoagSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoagSave.Name = "btnCoagSave"
        Me.btnCoagSave.Size = New System.Drawing.Size(69, 53)
        Me.btnCoagSave.TabIndex = 27
        Me.btnCoagSave.Text = "Save"
        Me.btnCoagSave.UseVisualStyleBackColor = True
        '
        'btnPrintAll
        '
        Me.btnPrintAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrintAll.Location = New System.Drawing.Point(636, 389)
        Me.btnPrintAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.Size = New System.Drawing.Size(69, 53)
        Me.btnPrintAll.TabIndex = 26
        Me.btnPrintAll.Text = "Print All"
        Me.btnPrintAll.UseVisualStyleBackColor = True
        '
        'btnCoagAddRes
        '
        Me.btnCoagAddRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCoagAddRes.Location = New System.Drawing.Point(554, 389)
        Me.btnCoagAddRes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoagAddRes.Name = "btnCoagAddRes"
        Me.btnCoagAddRes.Size = New System.Drawing.Size(69, 53)
        Me.btnCoagAddRes.TabIndex = 25
        Me.btnCoagAddRes.Text = "Add Result"
        Me.btnCoagAddRes.UseVisualStyleBackColor = True
        '
        'txtDeltaCheck
        '
        Me.txtDeltaCheck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDeltaCheck.Location = New System.Drawing.Point(545, 320)
        Me.txtDeltaCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDeltaCheck.Multiline = True
        Me.txtDeltaCheck.Name = "txtDeltaCheck"
        Me.txtDeltaCheck.Size = New System.Drawing.Size(425, 65)
        Me.txtDeltaCheck.TabIndex = 24
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label84.Location = New System.Drawing.Point(538, 302)
        Me.Label84.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(92, 20)
        Me.Label84.TabIndex = 23
        Me.Label84.Text = "Delta Check"
        '
        'txtAutoComm
        '
        Me.txtAutoComm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAutoComm.Location = New System.Drawing.Point(16, 354)
        Me.txtAutoComm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAutoComm.Multiline = True
        Me.txtAutoComm.Name = "txtAutoComm"
        Me.txtAutoComm.Size = New System.Drawing.Size(525, 95)
        Me.txtAutoComm.TabIndex = 22
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label83.Location = New System.Drawing.Point(16, 336)
        Me.Label83.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(194, 20)
        Me.Label83.TabIndex = 21
        Me.Label83.Text = "Auto Generated Comment"
        '
        'txtCoagRes
        '
        Me.txtCoagRes.Location = New System.Drawing.Point(281, 306)
        Me.txtCoagRes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCoagRes.Name = "txtCoagRes"
        Me.txtCoagRes.Size = New System.Drawing.Size(84, 32)
        Me.txtCoagRes.TabIndex = 20
        '
        'cmbParameter
        '
        Me.cmbParameter.FormattingEnabled = True
        Me.cmbParameter.Location = New System.Drawing.Point(138, 306)
        Me.cmbParameter.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbParameter.Name = "cmbParameter"
        Me.cmbParameter.Size = New System.Drawing.Size(128, 32)
        Me.cmbParameter.TabIndex = 19
        '
        'cmbCoagComment
        '
        Me.cmbCoagComment.FormattingEnabled = True
        Me.cmbCoagComment.Location = New System.Drawing.Point(445, 274)
        Me.cmbCoagComment.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCoagComment.Name = "cmbCoagComment"
        Me.cmbCoagComment.Size = New System.Drawing.Size(525, 32)
        Me.cmbCoagComment.TabIndex = 18
        '
        'txtSpecCoag
        '
        Me.txtSpecCoag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSpecCoag.Location = New System.Drawing.Point(445, 234)
        Me.txtSpecCoag.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSpecCoag.Multiline = True
        Me.txtSpecCoag.Name = "txtSpecCoag"
        Me.txtSpecCoag.Size = New System.Drawing.Size(525, 36)
        Me.txtSpecCoag.TabIndex = 17
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label82.Location = New System.Drawing.Point(445, 217)
        Me.Label82.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(157, 20)
        Me.Label82.TabIndex = 16
        Me.Label82.Text = "Specimen Comments"
        '
        'btnOrderCoag
        '
        Me.btnOrderCoag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOrderCoag.Location = New System.Drawing.Point(901, 163)
        Me.btnOrderCoag.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderCoag.Name = "btnOrderCoag"
        Me.btnOrderCoag.Size = New System.Drawing.Size(69, 53)
        Me.btnOrderCoag.TabIndex = 15
        Me.btnOrderCoag.Text = "Order Tests"
        Me.btnOrderCoag.UseVisualStyleBackColor = True
        '
        'btnCoagRep
        '
        Me.btnCoagRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCoagRep.Location = New System.Drawing.Point(770, 163)
        Me.btnCoagRep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoagRep.Name = "btnCoagRep"
        Me.btnCoagRep.Size = New System.Drawing.Size(69, 53)
        Me.btnCoagRep.TabIndex = 14
        Me.btnCoagRep.Text = "View Repeat"
        Me.btnCoagRep.UseVisualStyleBackColor = True
        '
        'txtCoagAnal
        '
        Me.txtCoagAnal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCoagAnal.Location = New System.Drawing.Point(841, 135)
        Me.txtCoagAnal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCoagAnal.Multiline = True
        Me.txtCoagAnal.Name = "txtCoagAnal"
        Me.txtCoagAnal.Size = New System.Drawing.Size(129, 24)
        Me.txtCoagAnal.TabIndex = 13
        Me.txtCoagAnal.Text = "          A"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label81.Location = New System.Drawing.Point(775, 141)
        Me.Label81.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(69, 20)
        Me.Label81.TabIndex = 12
        Me.Label81.Text = "Analyser"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button7)
        Me.GroupBox11.Controls.Add(Me.txtWarfa)
        Me.GroupBox11.Location = New System.Drawing.Point(770, 72)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(200, 61)
        Me.GroupBox11.TabIndex = 11
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Warfarin"
        '
        'Button7
        '
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Location = New System.Drawing.Point(109, 23)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 27)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Print INR"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtWarfa
        '
        Me.txtWarfa.Location = New System.Drawing.Point(5, 25)
        Me.txtWarfa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWarfa.Name = "txtWarfa"
        Me.txtWarfa.Size = New System.Drawing.Size(91, 32)
        Me.txtWarfa.TabIndex = 3
        '
        'DataGridView2
        '
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coagParam, Me.coagRes2})
        Me.DataGridView2.Location = New System.Drawing.Point(445, 72)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(319, 144)
        Me.DataGridView2.TabIndex = 10
        '
        'coagParam
        '
        Me.coagParam.HeaderText = "Parameter"
        Me.coagParam.MinimumWidth = 6
        Me.coagParam.Name = "coagParam"
        Me.coagParam.Width = 125
        '
        'coagRes2
        '
        Me.coagRes2.HeaderText = "Result"
        Me.coagRes2.MinimumWidth = 6
        Me.coagRes2.Name = "coagRes2"
        Me.coagRes2.Width = 125
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(444, 54)
        Me.Label80.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(283, 26)
        Me.Label80.TabIndex = 9
        Me.Label80.Text = "No Chart # for Previous Details"
        '
        'gCoag
        '
        Me.gCoag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gCoag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gCoag.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parameter, Me.ResultCoag, Me.UnitsCoag, Me.flagCoag, Me.VPCoag, Me.PCoag})
        Me.gCoag.Location = New System.Drawing.Point(120, 54)
        Me.gCoag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gCoag.Name = "gCoag"
        Me.gCoag.RowHeadersVisible = False
        Me.gCoag.RowHeadersWidth = 51
        Me.gCoag.RowTemplate.Height = 29
        Me.gCoag.Size = New System.Drawing.Size(319, 248)
        Me.gCoag.TabIndex = 8
        '
        'Parameter
        '
        Me.Parameter.HeaderText = "Parameter"
        Me.Parameter.MinimumWidth = 6
        Me.Parameter.Name = "Parameter"
        Me.Parameter.Width = 125
        '
        'ResultCoag
        '
        Me.ResultCoag.HeaderText = "Result"
        Me.ResultCoag.MinimumWidth = 6
        Me.ResultCoag.Name = "ResultCoag"
        Me.ResultCoag.Width = 80
        '
        'UnitsCoag
        '
        Me.UnitsCoag.HeaderText = "Units"
        Me.UnitsCoag.MinimumWidth = 6
        Me.UnitsCoag.Name = "UnitsCoag"
        Me.UnitsCoag.Width = 80
        '
        'flagCoag
        '
        Me.flagCoag.HeaderText = "Flags"
        Me.flagCoag.MinimumWidth = 6
        Me.flagCoag.Name = "flagCoag"
        Me.flagCoag.Width = 60
        '
        'VPCoag
        '
        Me.VPCoag.HeaderText = "VP"
        Me.VPCoag.MinimumWidth = 6
        Me.VPCoag.Name = "VPCoag"
        Me.VPCoag.Width = 60
        '
        'PCoag
        '
        Me.PCoag.HeaderText = "P"
        Me.PCoag.MinimumWidth = 6
        Me.PCoag.Name = "PCoag"
        Me.PCoag.Width = 60
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 54)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(97, 248)
        Me.DataGridView1.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Outstanding"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chkCoagPrintFalse)
        Me.GroupBox10.Controls.Add(Me.chkCoagPrintTrue)
        Me.GroupBox10.Controls.Add(Me.Label79)
        Me.GroupBox10.Location = New System.Drawing.Point(248, 14)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox10.Size = New System.Drawing.Size(219, 38)
        Me.GroupBox10.TabIndex = 5
        Me.GroupBox10.TabStop = False
        '
        'chkCoagPrintFalse
        '
        Me.chkCoagPrintFalse.Location = New System.Drawing.Point(129, 13)
        Me.chkCoagPrintFalse.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCoagPrintFalse.Name = "chkCoagPrintFalse"
        Me.chkCoagPrintFalse.Size = New System.Drawing.Size(28, 20)
        Me.chkCoagPrintFalse.TabIndex = 13
        Me.chkCoagPrintFalse.Text = "X"
        Me.chkCoagPrintFalse.UseVisualStyleBackColor = True
        '
        'chkCoagPrintTrue
        '
        Me.chkCoagPrintTrue.Location = New System.Drawing.Point(163, 13)
        Me.chkCoagPrintTrue.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCoagPrintTrue.Name = "chkCoagPrintTrue"
        Me.chkCoagPrintTrue.Size = New System.Drawing.Size(28, 20)
        Me.chkCoagPrintTrue.TabIndex = 12
        Me.chkCoagPrintTrue.Text = "✓"
        Me.chkCoagPrintTrue.UseVisualStyleBackColor = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(4, 15)
        Me.Label79.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(169, 26)
        Me.Label79.TabIndex = 2
        Me.Label79.Text = "Select for Printing"
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 33)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(1049, 469)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Immunology"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 33)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Size = New System.Drawing.Size(1049, 469)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Blood Gas"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage7.Controls.Add(Me.etc1)
        Me.TabPage7.Controls.Add(Me.TextBox18)
        Me.TabPage7.Controls.Add(Me.TextBox17)
        Me.TabPage7.Controls.Add(Me.TextBox16)
        Me.TabPage7.Controls.Add(Me.TextBox15)
        Me.TabPage7.Controls.Add(Me.TextBox12)
        Me.TabPage7.Controls.Add(Me.etc4)
        Me.TabPage7.Controls.Add(Me.etc3)
        Me.TabPage7.Controls.Add(Me.etc2)
        Me.TabPage7.Controls.Add(Me.btnSaveExt)
        Me.TabPage7.Controls.Add(Me.btnPrintDoc)
        Me.TabPage7.Controls.Add(Me.btnOrderExt)
        Me.TabPage7.Controls.Add(Me.btnDeleteExt)
        Me.TabPage7.Controls.Add(Me.btnViewMed)
        Me.TabPage7.Controls.Add(Me.DataGridView3)
        Me.TabPage7.Location = New System.Drawing.Point(4, 33)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Size = New System.Drawing.Size(1049, 469)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "External"
        '
        'etc1
        '
        Me.etc1.Location = New System.Drawing.Point(13, 210)
        Me.etc1.Name = "etc1"
        Me.etc1.Size = New System.Drawing.Size(914, 32)
        Me.etc1.TabIndex = 63
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(11, 408)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(914, 32)
        Me.TextBox18.TabIndex = 62
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(11, 386)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(914, 32)
        Me.TextBox17.TabIndex = 61
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(11, 361)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(914, 32)
        Me.TextBox16.TabIndex = 60
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(11, 337)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(914, 32)
        Me.TextBox15.TabIndex = 59
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(11, 311)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(914, 32)
        Me.TextBox12.TabIndex = 58
        '
        'etc4
        '
        Me.etc4.Location = New System.Drawing.Point(11, 285)
        Me.etc4.Name = "etc4"
        Me.etc4.Size = New System.Drawing.Size(914, 32)
        Me.etc4.TabIndex = 57
        '
        'etc3
        '
        Me.etc3.Location = New System.Drawing.Point(11, 260)
        Me.etc3.Name = "etc3"
        Me.etc3.Size = New System.Drawing.Size(914, 32)
        Me.etc3.TabIndex = 56
        '
        'etc2
        '
        Me.etc2.Location = New System.Drawing.Point(11, 235)
        Me.etc2.Name = "etc2"
        Me.etc2.Size = New System.Drawing.Size(914, 32)
        Me.etc2.TabIndex = 55
        '
        'btnSaveExt
        '
        Me.btnSaveExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSaveExt.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveExt.Location = New System.Drawing.Point(935, 294)
        Me.btnSaveExt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveExt.Name = "btnSaveExt"
        Me.btnSaveExt.Size = New System.Drawing.Size(85, 46)
        Me.btnSaveExt.TabIndex = 54
        Me.btnSaveExt.Text = "Save"
        Me.btnSaveExt.UseVisualStyleBackColor = True
        '
        'btnPrintDoc
        '
        Me.btnPrintDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrintDoc.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintDoc.Location = New System.Drawing.Point(935, 233)
        Me.btnPrintDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintDoc.Name = "btnPrintDoc"
        Me.btnPrintDoc.Size = New System.Drawing.Size(85, 46)
        Me.btnPrintDoc.TabIndex = 53
        Me.btnPrintDoc.Text = "Print Document"
        Me.btnPrintDoc.UseVisualStyleBackColor = True
        '
        'btnOrderExt
        '
        Me.btnOrderExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOrderExt.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderExt.Location = New System.Drawing.Point(935, 174)
        Me.btnOrderExt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderExt.Name = "btnOrderExt"
        Me.btnOrderExt.Size = New System.Drawing.Size(85, 46)
        Me.btnOrderExt.TabIndex = 52
        Me.btnOrderExt.Text = "Order External Tests"
        Me.btnOrderExt.UseVisualStyleBackColor = True
        '
        'btnDeleteExt
        '
        Me.btnDeleteExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeleteExt.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteExt.Location = New System.Drawing.Point(935, 113)
        Me.btnDeleteExt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteExt.Name = "btnDeleteExt"
        Me.btnDeleteExt.Size = New System.Drawing.Size(85, 46)
        Me.btnDeleteExt.TabIndex = 51
        Me.btnDeleteExt.Text = "Delete"
        Me.btnDeleteExt.UseVisualStyleBackColor = True
        '
        'btnViewMed
        '
        Me.btnViewMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnViewMed.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewMed.Location = New System.Drawing.Point(935, 34)
        Me.btnViewMed.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewMed.Name = "btnViewMed"
        Me.btnViewMed.Size = New System.Drawing.Size(85, 46)
        Me.btnViewMed.TabIndex = 50
        Me.btnViewMed.Text = "View Medibridge"
        Me.btnViewMed.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.testnameExt, Me.resExt, Me.NrExt, Me.UnitsExt, Me.SendTo, Me.DateExt})
        Me.DataGridView3.Location = New System.Drawing.Point(11, 10)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 25
        Me.DataGridView3.Size = New System.Drawing.Size(914, 196)
        Me.DataGridView3.TabIndex = 0
        '
        'testnameExt
        '
        Me.testnameExt.HeaderText = "Test Name"
        Me.testnameExt.MinimumWidth = 6
        Me.testnameExt.Name = "testnameExt"
        Me.testnameExt.Width = 125
        '
        'resExt
        '
        Me.resExt.HeaderText = "Result"
        Me.resExt.MinimumWidth = 6
        Me.resExt.Name = "resExt"
        Me.resExt.Width = 150
        '
        'NrExt
        '
        Me.NrExt.HeaderText = "Normal Range"
        Me.NrExt.MinimumWidth = 6
        Me.NrExt.Name = "NrExt"
        Me.NrExt.Width = 125
        '
        'UnitsExt
        '
        Me.UnitsExt.HeaderText = "Units"
        Me.UnitsExt.MinimumWidth = 6
        Me.UnitsExt.Name = "UnitsExt"
        Me.UnitsExt.Width = 125
        '
        'SendTo
        '
        Me.SendTo.HeaderText = "Send To"
        Me.SendTo.MinimumWidth = 6
        Me.SendTo.Name = "SendTo"
        Me.SendTo.Width = 150
        '
        'DateExt
        '
        Me.DateExt.HeaderText = "Date"
        Me.DateExt.MinimumWidth = 6
        Me.DateExt.Name = "DateExt"
        Me.DateExt.Width = 125
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 604)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1167, 26)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 20)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 20)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 20)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 20)
        '
        'btnViewReport
        '
        Me.btnViewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnViewReport.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewReport.Location = New System.Drawing.Point(1066, 130)
        Me.btnViewReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(85, 36)
        Me.btnViewReport.TabIndex = 42
        Me.btnViewReport.Text = "View Reports"
        Me.btnViewReport.UseVisualStyleBackColor = True
        '
        'btnTransfus
        '
        Me.btnTransfus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTransfus.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTransfus.Location = New System.Drawing.Point(1066, 167)
        Me.btnTransfus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransfus.Name = "btnTransfus"
        Me.btnTransfus.Size = New System.Drawing.Size(85, 38)
        Me.btnTransfus.TabIndex = 43
        Me.btnTransfus.Text = "Transfusion Details"
        Me.btnTransfus.UseVisualStyleBackColor = True
        '
        'btnChoosePrin
        '
        Me.btnChoosePrin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnChoosePrin.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnChoosePrin.Location = New System.Drawing.Point(1066, 207)
        Me.btnChoosePrin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChoosePrin.Name = "btnChoosePrin"
        Me.btnChoosePrin.Size = New System.Drawing.Size(85, 40)
        Me.btnChoosePrin.TabIndex = 44
        Me.btnChoosePrin.Text = "Choose Printer"
        Me.btnChoosePrin.UseVisualStyleBackColor = True
        '
        'btnPrintHold
        '
        Me.btnPrintHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrintHold.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintHold.Location = New System.Drawing.Point(1066, 252)
        Me.btnPrintHold.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintHold.Name = "btnPrintHold"
        Me.btnPrintHold.Size = New System.Drawing.Size(85, 38)
        Me.btnPrintHold.TabIndex = 45
        Me.btnPrintHold.Text = "Print && &Hold"
        Me.btnPrintHold.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Location = New System.Drawing.Point(1066, 292)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(85, 34)
        Me.btnPrint.TabIndex = 46
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnFax
        '
        Me.btnFax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFax.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFax.Location = New System.Drawing.Point(1066, 331)
        Me.btnFax.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFax.Name = "btnFax"
        Me.btnFax.Size = New System.Drawing.Size(85, 32)
        Me.btnFax.TabIndex = 47
        Me.btnFax.Text = "Fax Results"
        Me.btnFax.UseVisualStyleBackColor = True
        '
        'btnPhone
        '
        Me.btnPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPhone.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPhone.Location = New System.Drawing.Point(1066, 367)
        Me.btnPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPhone.Name = "btnPhone"
        Me.btnPhone.Size = New System.Drawing.Size(85, 37)
        Me.btnPhone.TabIndex = 48
        Me.btnPhone.Text = "Phone Results"
        Me.btnPhone.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHistory.Location = New System.Drawing.Point(1066, 476)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(85, 46)
        Me.btnHistory.TabIndex = 49
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(1066, 532)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 46)
        Me.btnCancel.TabIndex = 50
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Red
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label30.ForeColor = System.Drawing.Color.Yellow
        Me.Label30.Location = New System.Drawing.Point(1069, 406)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 30, 2, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 80)
        Me.Label30.TabIndex = 51
        Me.Label30.Text = "Sample Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "88/88/8888" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RunDate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "88/88/8888" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmEditAll
        '
        Me.ClientSize = New System.Drawing.Size(1167, 630)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPhone)
        Me.Controls.Add(Me.btnFax)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPrintHold)
        Me.Controls.Add(Me.btnChoosePrin)
        Me.Controls.Add(Me.btnTransfus)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.btnScan)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmEditAll"
        Me.Text = "NetAcquire"
        Me.btnScan.ResumeLayout(False)
        Me.btnScan.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgLast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.Tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.flxQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.txtRA.ResumeLayout(False)
        Me.txtRA.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gOutstandingHaem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.cmbAdd.ResumeLayout(False)
        Me.cmbAdd.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.gBioOutstand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gBio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gCoag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnScan As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSampleIDIncre As Button
    Friend WithEvents imgLast As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbOtherSamples As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnViewScan As Button
    Friend WithEvents cMRU As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPatientNotePad As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSearchDob As Button
    Friend WithEvents btnDob As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtChart As TextBox
    Friend WithEvents lblChart As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrevDetail As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtRA As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbAdd As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents txtSampleID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblReqID As Label
    Friend WithEvents txtExtSampleID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LBL As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblMRN As TextBox
    Friend WithEvents lblName As TextBox
    Friend WithEvents lblDOB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblAge As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbHospitals As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmdWards As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbClins As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbGP As ComboBox
    Friend WithEvents cmbDemogComm As ComboBox
    Friend WithEvents txtDemogComm As TextBox
    Friend WithEvents txtadd4 As TextBox
    Friend WithEvents txtadd3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbCLdetails As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkCoag As CheckBox
    Friend WithEvents chkHaem As CheckBox
    Friend WithEvents chkExt As CheckBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents btncc As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtSample As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents sampleTime As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents dtReceived As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents timeRec As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents timeRun As TextBox
    Friend WithEvents dtRun As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblDateError As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents rdOHours As RadioButton
    Friend WithEvents rdRoutine As RadioButton
    Friend WithEvents chkUrgent As CheckBox
    Friend WithEvents chkFast As CheckBox
    Friend WithEvents btnTag As Button
    Friend WithEvents btnOrderTests As Button
    Friend WithEvents flxQuestion As DataGridView
    Friend WithEvents btnOrderExtTest As Button
    Friend WithEvents btnVal As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents btnSaveAndHold As Button
    Friend WithEvents btnUnlockDemo As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtNote As TextBox
    Friend WithEvents btnViewReport As Button
    Friend WithEvents btnTransfus As Button
    Friend WithEvents btnChoosePrin As Button
    Friend WithEvents btnPrintHold As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnFax As Button
    Friend WithEvents btnPhone As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents btnClearDiff As Button
    Friend WithEvents txtWIC As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtBasA As TextBox
    Friend WithEvents txtEosA As TextBox
    Friend WithEvents txtMonoA As TextBox
    Friend WithEvents txtLymphA As TextBox
    Friend WithEvents txtNeutA As TextBox
    Friend WithEvents txtWBC As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtLymphP As TextBox
    Friend WithEvents txtNeutP As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtWVF As TextBox
    Friend WithEvents txtWOC As TextBox
    Friend WithEvents txtBasP As TextBox
    Friend WithEvents txtEosP As TextBox
    Friend WithEvents txtMonoP As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label48 As Label
    Friend WithEvents txtnRBCp As TextBox
    Friend WithEvents txtRDWSD As TextBox
    Friend WithEvents txtRDWCV As TextBox
    Friend WithEvents txtMCHC As TextBox
    Friend WithEvents txtIRF As TextBox
    Friend WithEvents txtnRBCA As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txtMCV As TextBox
    Friend WithEvents txtHct As TextBox
    Friend WithEvents txtHgb As TextBox
    Friend WithEvents txtRbc As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents btnHgb As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMpv As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents txtPlt As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtInfect As TextBox
    Friend WithEvents ckfInfec As CheckBox
    Friend WithEvents Label56 As Label
    Friend WithEvents txtRetP As TextBox
    Friend WithEvents txtRetA As TextBox
    Friend WithEvents chkRetics As CheckBox
    Friend WithEvents txtESR As TextBox
    Friend WithEvents chkESR As CheckBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents chkRA As CheckBox
    Friend WithEvents txtSick As TextBox
    Friend WithEvents chkSick As CheckBox
    Friend WithEvents txtMal As TextBox
    Friend WithEvents chkMal As CheckBox
    Friend WithEvents gOutstandingHaem As DataGridView
    Friend WithEvents btnSick As Button
    Friend WithEvents btnMalria As Button
    Friend WithEvents btnInfect As Button
    Friend WithEvents btnESRPrint As Button
    Friend WithEvents Label66 As Label
    Friend WithEvents cmbHaemComm As ComboBox
    Friend WithEvents cmbFilmCom As ComboBox
    Friend WithEvents chkFilm As CheckBox
    Friend WithEvents btnManDiff As Button
    Friend WithEvents Outstanding As DataGridViewTextBoxColumn
    Friend WithEvents btnRepeat As Button
    Friend WithEvents btnHaemGrap As Button
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label68 As Label
    Friend WithEvents txtSpecComm As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txtFilCom As TextBox
    Friend WithEvents btnHaemSave As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label69 As Label
    Friend WithEvents btnOrderHaem As Button
    Friend WithEvents btnValHaem As Button
    Friend WithEvents txtCD3P As TextBox
    Friend WithEvents TXTCD3A As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents txtCD4A As TextBox
    Friend WithEvents CD4 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents CD8 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents txtCD4P As TextBox
    Friend WithEvents txtCD8P As TextBox
    Friend WithEvents txtCD8A As TextBox
    Friend WithEvents txt48 As TextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents lblRandomS As Label
    Friend WithEvents lblViewAll As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnBioPrintTrue As Button
    Friend WithEvents Label75 As Label
    Friend WithEvents gBio As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents gBioOutstand As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Tname As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewTextBoxColumn
    Friend WithEvents Ranges As DataGridViewTextBoxColumn
    Friend WithEvents Units As DataGridViewTextBoxColumn
    Friend WithEvents Flags As DataGridViewTextBoxColumn
    Friend WithEvents Analyser As DataGridViewTextBoxColumn
    Friend WithEvents VP As DataGridViewTextBoxColumn
    Friend WithEvents Cmt As DataGridViewTextBoxColumn
    Friend WithEvents P As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents split2 As Label
    Friend WithEvents lblSplit1 As Label
    Friend WithEvents lblAll As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents split3 As Label
    Friend WithEvents split6 As Label
    Friend WithEvents split5 As Label
    Friend WithEvents cmbAddBio As ComboBox
    Friend WithEvents btnAddBioRes As Button
    Friend WithEvents cmbSampleType As ComboBox
    Friend WithEvents cmbUnits As ComboBox
    Friend WithEvents cmbNewBioRes As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents chkIcteric As CheckBox
    Friend WithEvents chkHaemo As CheckBox
    Friend WithEvents chkOldSam As CheckBox
    Friend WithEvents chkLip As CheckBox
    Friend WithEvents Label77 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtBioComment As TextBox
    Friend WithEvents cmbBioComment As ComboBox
    Friend WithEvents cmbBioComment2 As ComboBox
    Friend WithEvents txtBioAutoCom As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents btnBioSave As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnViewBioRepeat As Button
    Friend WithEvents btnValBio As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents chkCoagPrintFalse As Button
    Friend WithEvents chkCoagPrintTrue As Button
    Friend WithEvents Label79 As Label
    Friend WithEvents gCoag As DataGridView
    Friend WithEvents Parameter As DataGridViewTextBoxColumn
    Friend WithEvents ResultCoag As DataGridViewTextBoxColumn
    Friend WithEvents UnitsCoag As DataGridViewTextBoxColumn
    Friend WithEvents flagCoag As DataGridViewTextBoxColumn
    Friend WithEvents VPCoag As DataGridViewTextBoxColumn
    Friend WithEvents PCoag As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents coagParam As DataGridViewTextBoxColumn
    Friend WithEvents coagRes2 As DataGridViewTextBoxColumn
    Friend WithEvents Label80 As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents txtWarfa As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents btnOrderCoag As Button
    Friend WithEvents btnCoagRep As Button
    Friend WithEvents txtCoagAnal As TextBox
    Friend WithEvents txtCoagRes As TextBox
    Friend WithEvents cmbParameter As ComboBox
    Friend WithEvents cmbCoagComment As ComboBox
    Friend WithEvents txtSpecCoag As TextBox
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents txtDeltaCheck As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents txtAutoComm As TextBox
    Friend WithEvents btnCoagVali As Button
    Friend WithEvents btnCoagSave As Button
    Friend WithEvents btnPrintAll As Button
    Friend WithEvents btnCoagAddRes As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents testnameExt As DataGridViewTextBoxColumn
    Friend WithEvents resExt As DataGridViewTextBoxColumn
    Friend WithEvents NrExt As DataGridViewTextBoxColumn
    Friend WithEvents UnitsExt As DataGridViewTextBoxColumn
    Friend WithEvents SendTo As DataGridViewTextBoxColumn
    Friend WithEvents DateExt As DataGridViewTextBoxColumn
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents etc4 As TextBox
    Friend WithEvents etc3 As TextBox
    Friend WithEvents etc2 As TextBox
    Friend WithEvents btnSaveExt As Button
    Friend WithEvents btnPrintDoc As Button
    Friend WithEvents btnOrderExt As Button
    Friend WithEvents btnDeleteExt As Button
    Friend WithEvents btnViewMed As Button
    Friend WithEvents etc1 As TextBox
    Friend WithEvents TextBox18 As TextBox
End Class
