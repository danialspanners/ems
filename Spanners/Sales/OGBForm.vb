Public Class OGBForm
    Inherits System.Windows.Forms.Form

#Region " Variable "
    Public OGB_IO_Id As Integer
    Public Contract_Id As Integer
    Public PContract_Id As Integer
    Public IO_No As String
    Public ParentIO As String
    Public Officer_In_Charge_Id As Integer
    Public Counter_Sign_Officer_Id As Integer
    Public OGB_Section As Integer
    Public OGB_Location As String
    Public OGB_Substation As String
    Public IO_Recv_Date As String
    Public Commence_Date As String
    Public Completion_Date As String
    Public Extend_Commence_Date As String
    Public Extend_Completion_Date As String
    Public Installation_Date As String
    Public WorkVerification_Date As String
    Public PaymentClaim_Date As String
    Public Serial_No As String
    Public OGB_Plus_Minus As String
    Public Tested_Passed_Date As String
    Public OGB_Installed As Integer
    Public OGB_Surveyed As Integer
    Public OGB_OT As Integer
    Public OGB_Labelled As Integer
    Public OGB_630ADin As Integer
    Public FeederLabelled As Integer
    Public MRC_No As String
    Public Redo_Flg As String
    Public Redo_Text As String
    Public OGB1_X As String
    Public OGB2_X As String
    Public OGB1_Y As String
    Public OGB2_Y As String
    Public Issues_Flag As String
    Public Issues_Detail As String
    Public Invoice_No As String
    Public Invoice_Date As String
    Public LD_Amount As Decimal
    Public Notification_Index As String
    Public DWC_Sent_Date As String
    Public TOC_Return_Date As String
    Public F0028_Recv_Date As String
    Public Collect_Doc_Date As String
    Public Remarks As String
    Public Original_IO As String
    Public Legend_Invoice_No As String
    Public Delay_Reason As String
    Public A4_Qty As Integer
    Public MRC_Qty As Integer
    Public LU_Qty As Integer
    Public Date_Completed As String
    Public Index_No As String
    Public UserID As String = Common.CommonConn.Config.USERID
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SaveXtraButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContractNo_LookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Dim Navds As DataSet

    Private Edited As Boolean
    Friend WithEvents IO_LookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PaymentClaim_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents WorkVerification_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Issues_Detail_MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Issues_Flag_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents OGB630DinTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Private OnLoading As Boolean

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pContract_Id As Integer, ByVal pStatus As String, _
                    Optional ByVal pOGB_IO_Id As Integer = 0)
        MyBase.New()

        Edited = False
        OnLoading = True
        Contract_Id = pContract_Id
        Status = pStatus

        If Not pOGB_IO_Id = 0 Then
            OGB_IO_Id = pOGB_IO_Id
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        If pContract_Id = 0 Then
            SaveXtraButton.Enabled = False
        End If

        OnLoading = False

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl1 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents TabPage1 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage2 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage3 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CompletedDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents ReasonMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents LegendInvoiceTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents RemarksMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents CollectDocDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents F28RecvDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents NoticeIndexTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DWCDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TOCRecvDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents InvoiceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents InvoiceNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PassDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents MRCTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGB2YTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGB1YTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGB2XTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGB1XTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ExtCompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ExtCommenceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CommenceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RecDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents InstallDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SerialTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents OfficerCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SignOfficerCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ContractNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGBPlusMinusTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OriginalIOTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LDAmttxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents A4Txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MRCLTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LUTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RedoChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ParentIOTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SectionTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ParentIOcmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents OGBSurveyedTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OGBInstalledTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OGBLabelledTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FeederLabelledTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LocMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents RedoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IONumberTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddNext_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents OGBOTTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ContractNoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Substation_txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label46 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New Crownwood.Magic.Controls.TabControl
        Me.TabPage1 = New Crownwood.Magic.Controls.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PaymentClaim_DateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label48 = New System.Windows.Forms.Label
        Me.WorkVerification_DateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label49 = New System.Windows.Forms.Label
        Me.OGBOTTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.OGBSurveyedTxt = New DevExpress.XtraEditors.SpinEdit
        Me.OGBInstalledTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.SerialTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.InstallDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.ExtCompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.ExtCommenceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.CompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CommenceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.RecDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Substation_txt = New DevExpress.XtraEditors.TextEdit
        Me.Label46 = New System.Windows.Forms.Label
        Me.ContractNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label45 = New System.Windows.Forms.Label
        Me.LocMemo = New DevExpress.XtraEditors.MemoEdit
        Me.IONumberTxt = New DevExpress.XtraEditors.TextEdit
        Me.ParentIOcmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label41 = New System.Windows.Forms.Label
        Me.SectionTxt = New DevExpress.XtraEditors.TextEdit
        Me.SignOfficerCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.OfficerCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ContractNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.TabPage2 = New Crownwood.Magic.Controls.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.RedoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.RedoChk = New System.Windows.Forms.CheckBox
        Me.OGBPlusMinusTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.PassDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.MRCTxt = New DevExpress.XtraEditors.TextEdit
        Me.OGB2YTxt = New DevExpress.XtraEditors.TextEdit
        Me.OGB1YTxt = New DevExpress.XtraEditors.TextEdit
        Me.OGB2XTxt = New DevExpress.XtraEditors.TextEdit
        Me.OGB1XTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabPage3 = New Crownwood.Magic.Controls.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.OGBLabelledTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.FeederLabelledTxt = New DevExpress.XtraEditors.SpinEdit
        Me.ParentIOTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.LUTxt = New DevExpress.XtraEditors.SpinEdit
        Me.MRCLTxt = New DevExpress.XtraEditors.SpinEdit
        Me.A4Txt = New DevExpress.XtraEditors.SpinEdit
        Me.LDAmttxt = New DevExpress.XtraEditors.SpinEdit
        Me.OriginalIOTxt = New DevExpress.XtraEditors.TextEdit
        Me.InvoiceNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.CompletedDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.ReasonMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label35 = New System.Windows.Forms.Label
        Me.LegendInvoiceTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.RemarksMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.CollectDocDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.F28RecvDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.NoticeIndexTxt = New DevExpress.XtraEditors.TextEdit
        Me.DWCDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.TOCRecvDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.InvoiceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.AddNext_CheckBox = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Issues_Detail_MemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Issues_Flag_CheckBox = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.IO_LookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.ContractNo_LookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.Label47 = New System.Windows.Forms.Label
        Me.NewButton = New System.Windows.Forms.Button
        Me.SaveXtraButton = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.OGB630DinTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label52 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PaymentClaim_DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkVerification_DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGBOTTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGBSurveyedTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGBInstalledTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtCompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtCommenceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommenceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Substation_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IONumberTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParentIOcmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignOfficerCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RedoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGBPlusMinusTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRCTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGB2YTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGB1YTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGB2XTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGB1XTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.OGBLabelledTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeederLabelledTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParentIOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRCLTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A4Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDAmttxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OriginalIOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReasonMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegendInvoiceTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectDocDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F28RecvDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoticeIndexTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DWCDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOCRecvDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Issues_Detail_MemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IO_LookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractNo_LookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.OGB630DinTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AutoScroll = True
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl1.IDEPixelArea = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.PositionTop = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SelectedTab = Me.TabPage1
        Me.TabControl1.Size = New System.Drawing.Size(592, 468)
        Me.TabControl1.TabIndex = 114
        Me.TabControl1.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.TabPage1, Me.TabPage2, Me.TabPage3})
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(0, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(592, 443)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Title = "OGB"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OGB630DinTxt)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.PaymentClaim_DateEdit)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.WorkVerification_DateEdit)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.OGBOTTxt)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.OGBSurveyedTxt)
        Me.GroupBox2.Controls.Add(Me.OGBInstalledTxt)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.SerialTxt)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.InstallDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ExtCompleteDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ExtCommenceDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CompleteDateEdit)
        Me.GroupBox2.Controls.Add(Me.CommenceDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.RecDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 252)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        '
        'PaymentClaim_DateEdit
        '
        Me.PaymentClaim_DateEdit.DateTime = New Date(CType(0, Long))
        Me.PaymentClaim_DateEdit.Location = New System.Drawing.Point(432, 109)
        Me.PaymentClaim_DateEdit.Name = "PaymentClaim_DateEdit"
        Me.PaymentClaim_DateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PaymentClaim_DateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PaymentClaim_DateEdit.Size = New System.Drawing.Size(108, 23)
        Me.PaymentClaim_DateEdit.TabIndex = 160
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(288, 113)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(136, 16)
        Me.Label48.TabIndex = 159
        Me.Label48.Text = "Payment Claim Date:"
        '
        'WorkVerification_DateEdit
        '
        Me.WorkVerification_DateEdit.DateTime = New Date(CType(0, Long))
        Me.WorkVerification_DateEdit.Location = New System.Drawing.Point(146, 107)
        Me.WorkVerification_DateEdit.Name = "WorkVerification_DateEdit"
        Me.WorkVerification_DateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WorkVerification_DateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WorkVerification_DateEdit.Size = New System.Drawing.Size(108, 23)
        Me.WorkVerification_DateEdit.TabIndex = 158
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(12, 113)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(128, 16)
        Me.Label49.TabIndex = 157
        Me.Label49.Text = "Work verification Date :"
        '
        'OGBOTTxt
        '
        Me.OGBOTTxt.Location = New System.Drawing.Point(462, 197)
        Me.OGBOTTxt.Name = "OGBOTTxt"
        Me.OGBOTTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGBOTTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OGBOTTxt.Size = New System.Drawing.Size(74, 19)
        Me.OGBOTTxt.TabIndex = 156
        Me.OGBOTTxt.Text = "0"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(288, 197)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(120, 16)
        Me.Label42.TabIndex = 155
        Me.Label42.Text = "No of OGB OT :"
        '
        'OGBSurveyedTxt
        '
        Me.OGBSurveyedTxt.Location = New System.Drawing.Point(462, 173)
        Me.OGBSurveyedTxt.Name = "OGBSurveyedTxt"
        Me.OGBSurveyedTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGBSurveyedTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OGBSurveyedTxt.Size = New System.Drawing.Size(74, 19)
        Me.OGBSurveyedTxt.TabIndex = 154
        Me.OGBSurveyedTxt.Text = "0"
        '
        'OGBInstalledTxt
        '
        Me.OGBInstalledTxt.Location = New System.Drawing.Point(146, 197)
        Me.OGBInstalledTxt.Name = "OGBInstalledTxt"
        Me.OGBInstalledTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGBInstalledTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OGBInstalledTxt.Size = New System.Drawing.Size(64, 19)
        Me.OGBInstalledTxt.TabIndex = 153
        Me.OGBInstalledTxt.Text = "0"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(288, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "No of OGB Surveyed :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "No of OGB Installed :"
        '
        'SerialTxt
        '
        Me.SerialTxt.Location = New System.Drawing.Point(146, 171)
        Me.SerialTxt.Name = "SerialTxt"
        Me.SerialTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SerialTxt.Size = New System.Drawing.Size(108, 19)
        Me.SerialTxt.TabIndex = 135
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 134
        Me.Label21.Text = "Serial No :"
        '
        'InstallDateEdit
        '
        Me.InstallDateEdit.DateTime = New Date(CType(0, Long))
        Me.InstallDateEdit.Location = New System.Drawing.Point(432, 80)
        Me.InstallDateEdit.Name = "InstallDateEdit"
        Me.InstallDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstallDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.InstallDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.InstallDateEdit.TabIndex = 130
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(288, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Installation Date :"
        '
        'ExtCompleteDateEdit
        '
        Me.ExtCompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExtCompleteDateEdit.Location = New System.Drawing.Point(432, 50)
        Me.ExtCompleteDateEdit.Name = "ExtCompleteDateEdit"
        Me.ExtCompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtCompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExtCompleteDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.ExtCompleteDateEdit.TabIndex = 91
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 14)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Extend Completion Date :"
        '
        'ExtCommenceDateEdit
        '
        Me.ExtCommenceDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExtCommenceDateEdit.Location = New System.Drawing.Point(432, 21)
        Me.ExtCommenceDateEdit.Name = "ExtCommenceDateEdit"
        Me.ExtCommenceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtCommenceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExtCommenceDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.ExtCommenceDateEdit.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(288, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Extend / Revised Commence Date :"
        '
        'CompleteDateEdit
        '
        Me.CompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.CompleteDateEdit.Location = New System.Drawing.Point(146, 78)
        Me.CompleteDateEdit.Name = "CompleteDateEdit"
        Me.CompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CompleteDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.CompleteDateEdit.TabIndex = 87
        '
        'CommenceDateEdit
        '
        Me.CommenceDateEdit.DateTime = New Date(CType(0, Long))
        Me.CommenceDateEdit.Location = New System.Drawing.Point(146, 50)
        Me.CommenceDateEdit.Name = "CommenceDateEdit"
        Me.CommenceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CommenceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CommenceDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.CommenceDateEdit.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "*Completion Date :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "*Commence Date :"
        '
        'RecDateEdit
        '
        Me.RecDateEdit.DateTime = New Date(CType(0, Long))
        Me.RecDateEdit.Location = New System.Drawing.Point(146, 21)
        Me.RecDateEdit.Name = "RecDateEdit"
        Me.RecDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RecDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RecDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.RecDateEdit.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "*IO Receive Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Substation_txt)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.ContractNoCmb)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.LocMemo)
        Me.GroupBox1.Controls.Add(Me.IONumberTxt)
        Me.GroupBox1.Controls.Add(Me.ParentIOcmb)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.SectionTxt)
        Me.GroupBox1.Controls.Add(Me.SignOfficerCmb)
        Me.GroupBox1.Controls.Add(Me.OfficerCmb)
        Me.GroupBox1.Controls.Add(Me.ContractNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Substation_txt
        '
        Me.Substation_txt.Location = New System.Drawing.Point(144, 88)
        Me.Substation_txt.Name = "Substation_txt"
        Me.Substation_txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Substation_txt.Properties.MaxLength = 50
        Me.Substation_txt.Size = New System.Drawing.Size(400, 19)
        Me.Substation_txt.TabIndex = 158
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(16, 90)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(96, 18)
        Me.Label46.TabIndex = 157
        Me.Label46.Text = "Substation :"
        '
        'ContractNoCmb
        '
        Me.ContractNoCmb.Location = New System.Drawing.Point(440, 16)
        Me.ContractNoCmb.Name = "ContractNoCmb"
        Me.ContractNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContractNoCmb.Properties.NullString = ""
        Me.ContractNoCmb.Properties.PopupWidth = 184
        Me.ContractNoCmb.Size = New System.Drawing.Size(104, 23)
        Me.ContractNoCmb.TabIndex = 156
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(362, 20)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(72, 16)
        Me.Label45.TabIndex = 155
        Me.Label45.Text = "Contract No :"
        '
        'LocMemo
        '
        Me.LocMemo.Location = New System.Drawing.Point(144, 112)
        Me.LocMemo.Name = "LocMemo"
        Me.LocMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LocMemo.Size = New System.Drawing.Size(400, 48)
        Me.LocMemo.TabIndex = 139
        '
        'IONumberTxt
        '
        Me.IONumberTxt.Location = New System.Drawing.Point(230, 15)
        Me.IONumberTxt.Name = "IONumberTxt"
        Me.IONumberTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IONumberTxt.Properties.MaxLength = 8
        Me.IONumberTxt.Size = New System.Drawing.Size(122, 19)
        Me.IONumberTxt.TabIndex = 154
        '
        'ParentIOcmb
        '
        Me.ParentIOcmb.Location = New System.Drawing.Point(440, 40)
        Me.ParentIOcmb.Name = "ParentIOcmb"
        Me.ParentIOcmb.Properties.AutoHeight = False
        Me.ParentIOcmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ParentIOcmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ParentIOcmb.Properties.DropDownRows = 25
        Me.ParentIOcmb.Properties.NullString = ""
        Me.ParentIOcmb.Properties.PopupWidth = 170
        Me.ParentIOcmb.Properties.ShowHeader = False
        Me.ParentIOcmb.Size = New System.Drawing.Size(104, 19)
        Me.ParentIOcmb.TabIndex = 138
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(360, 40)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 16)
        Me.Label41.TabIndex = 137
        Me.Label41.Text = "Previous I/O :"
        '
        'SectionTxt
        '
        Me.SectionTxt.Enabled = False
        Me.SectionTxt.Location = New System.Drawing.Point(440, 64)
        Me.SectionTxt.Name = "SectionTxt"
        Me.SectionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SectionTxt.Properties.Enabled = False
        Me.SectionTxt.Size = New System.Drawing.Size(104, 19)
        Me.SectionTxt.TabIndex = 136
        '
        'SignOfficerCmb
        '
        Me.SignOfficerCmb.Location = New System.Drawing.Point(144, 40)
        Me.SignOfficerCmb.Name = "SignOfficerCmb"
        Me.SignOfficerCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SignOfficerCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SignOfficerCmb.Properties.NullString = ""
        Me.SignOfficerCmb.Properties.PopupWidth = 272
        Me.SignOfficerCmb.Size = New System.Drawing.Size(208, 23)
        Me.SignOfficerCmb.TabIndex = 92
        '
        'OfficerCmb
        '
        Me.OfficerCmb.Location = New System.Drawing.Point(144, 64)
        Me.OfficerCmb.Name = "OfficerCmb"
        Me.OfficerCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OfficerCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.OfficerCmb.Properties.NullString = ""
        Me.OfficerCmb.Properties.PopupWidth = 272
        Me.OfficerCmb.Size = New System.Drawing.Size(208, 23)
        Me.OfficerCmb.TabIndex = 91
        '
        'ContractNoTxt
        '
        Me.ContractNoTxt.Enabled = False
        Me.ContractNoTxt.Location = New System.Drawing.Point(144, 16)
        Me.ContractNoTxt.Name = "ContractNoTxt"
        Me.ContractNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNoTxt.Properties.Enabled = False
        Me.ContractNoTxt.Size = New System.Drawing.Size(80, 19)
        Me.ContractNoTxt.TabIndex = 82
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(16, 20)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(56, 18)
        Me.Label43.TabIndex = 78
        Me.Label43.Text = "Contract :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Location :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Section :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "* Officer in Charge :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(16, 40)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(128, 16)
        Me.CustNameLbl.TabIndex = 26
        Me.CustNameLbl.Text = "Counter Signing Officer :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(0, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Selected = False
        Me.TabPage2.Size = New System.Drawing.Size(592, 443)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Title = "Survey"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.RedoCmb)
        Me.GroupBox3.Controls.Add(Me.RedoChk)
        Me.GroupBox3.Controls.Add(Me.OGBPlusMinusTxt)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.PassDateEdit)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.MRCTxt)
        Me.GroupBox3.Controls.Add(Me.OGB2YTxt)
        Me.GroupBox3.Controls.Add(Me.OGB1YTxt)
        Me.GroupBox3.Controls.Add(Me.OGB2XTxt)
        Me.GroupBox3.Controls.Add(Me.OGB1XTxt)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 344)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(276, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Redo :"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 16)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "OGB1 X Coordinates :"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 16)
        Me.Label17.TabIndex = 119
        Me.Label17.Text = "OGB2 X Coordinates :"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(276, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "OGB1 Y Coordinates :"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(276, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 16)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "OGB2 Y Coordinates :"
        '
        'RedoCmb
        '
        Me.RedoCmb.Location = New System.Drawing.Point(399, 24)
        Me.RedoCmb.Name = "RedoCmb"
        Me.RedoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RedoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RedoCmb.Properties.NullString = ""
        Me.RedoCmb.Size = New System.Drawing.Size(112, 23)
        Me.RedoCmb.TabIndex = 155
        '
        'RedoChk
        '
        Me.RedoChk.Location = New System.Drawing.Point(322, 19)
        Me.RedoChk.Name = "RedoChk"
        Me.RedoChk.Size = New System.Drawing.Size(16, 24)
        Me.RedoChk.TabIndex = 154
        '
        'OGBPlusMinusTxt
        '
        Me.OGBPlusMinusTxt.Location = New System.Drawing.Point(136, 120)
        Me.OGBPlusMinusTxt.Name = "OGBPlusMinusTxt"
        Me.OGBPlusMinusTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGBPlusMinusTxt.Size = New System.Drawing.Size(108, 19)
        Me.OGBPlusMinusTxt.TabIndex = 134
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 132
        Me.Label22.Text = "OGB +/- :"
        '
        'PassDateEdit
        '
        Me.PassDateEdit.DateTime = New Date(CType(0, Long))
        Me.PassDateEdit.Location = New System.Drawing.Point(399, 120)
        Me.PassDateEdit.Name = "PassDateEdit"
        Me.PassDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PassDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PassDateEdit.Size = New System.Drawing.Size(112, 23)
        Me.PassDateEdit.TabIndex = 129
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(276, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 16)
        Me.Label20.TabIndex = 127
        Me.Label20.Text = "Tested & Passed Date :"
        '
        'MRCTxt
        '
        Me.MRCTxt.Location = New System.Drawing.Point(136, 24)
        Me.MRCTxt.Name = "MRCTxt"
        Me.MRCTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MRCTxt.Properties.MaxLength = 14
        Me.MRCTxt.Size = New System.Drawing.Size(104, 19)
        Me.MRCTxt.TabIndex = 126
        '
        'OGB2YTxt
        '
        Me.OGB2YTxt.Location = New System.Drawing.Point(399, 88)
        Me.OGB2YTxt.Name = "OGB2YTxt"
        Me.OGB2YTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB2YTxt.Size = New System.Drawing.Size(112, 19)
        Me.OGB2YTxt.TabIndex = 125
        '
        'OGB1YTxt
        '
        Me.OGB1YTxt.Location = New System.Drawing.Point(399, 56)
        Me.OGB1YTxt.Name = "OGB1YTxt"
        Me.OGB1YTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB1YTxt.Size = New System.Drawing.Size(112, 19)
        Me.OGB1YTxt.TabIndex = 124
        '
        'OGB2XTxt
        '
        Me.OGB2XTxt.Location = New System.Drawing.Point(136, 88)
        Me.OGB2XTxt.Name = "OGB2XTxt"
        Me.OGB2XTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB2XTxt.Size = New System.Drawing.Size(104, 19)
        Me.OGB2XTxt.TabIndex = 123
        '
        'OGB1XTxt
        '
        Me.OGB1XTxt.Location = New System.Drawing.Point(136, 56)
        Me.OGB1XTxt.Name = "OGB1XTxt"
        Me.OGB1XTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB1XTxt.Size = New System.Drawing.Size(104, 19)
        Me.OGB1XTxt.TabIndex = 122
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "MRC No :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(0, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Selected = False
        Me.TabPage3.Size = New System.Drawing.Size(592, 443)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Title = "Labeling"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OGBLabelledTxt)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.FeederLabelledTxt)
        Me.GroupBox4.Controls.Add(Me.ParentIOTxt)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.LUTxt)
        Me.GroupBox4.Controls.Add(Me.MRCLTxt)
        Me.GroupBox4.Controls.Add(Me.A4Txt)
        Me.GroupBox4.Controls.Add(Me.LDAmttxt)
        Me.GroupBox4.Controls.Add(Me.OriginalIOTxt)
        Me.GroupBox4.Controls.Add(Me.InvoiceNoTxt)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.CompletedDateEdit)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.ReasonMemo)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.LegendInvoiceTxt)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.RemarksMemo)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.CollectDocDateEdit)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.F28RecvDateEdit)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.NoticeIndexTxt)
        Me.GroupBox4.Controls.Add(Me.DWCDateEdit)
        Me.GroupBox4.Controls.Add(Me.TOCRecvDateEdit)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.InvoiceDateEdit)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(568, 344)
        Me.GroupBox4.TabIndex = 114
        Me.GroupBox4.TabStop = False
        '
        'OGBLabelledTxt
        '
        Me.OGBLabelledTxt.Location = New System.Drawing.Point(120, 40)
        Me.OGBLabelledTxt.Name = "OGBLabelledTxt"
        Me.OGBLabelledTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGBLabelledTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OGBLabelledTxt.Size = New System.Drawing.Size(104, 19)
        Me.OGBLabelledTxt.TabIndex = 160
        Me.OGBLabelledTxt.Text = "0"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(248, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 24)
        Me.Label23.TabIndex = 159
        Me.Label23.Text = "No of Feeder Unit Labelled :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "No of OGB Labelled :"
        '
        'FeederLabelledTxt
        '
        Me.FeederLabelledTxt.Location = New System.Drawing.Point(400, 40)
        Me.FeederLabelledTxt.Name = "FeederLabelledTxt"
        Me.FeederLabelledTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.FeederLabelledTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FeederLabelledTxt.Size = New System.Drawing.Size(104, 19)
        Me.FeederLabelledTxt.TabIndex = 161
        Me.FeederLabelledTxt.Text = "0"
        '
        'ParentIOTxt
        '
        Me.ParentIOTxt.Enabled = False
        Me.ParentIOTxt.Location = New System.Drawing.Point(120, 16)
        Me.ParentIOTxt.Name = "ParentIOTxt"
        Me.ParentIOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ParentIOTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ParentIOTxt.Size = New System.Drawing.Size(104, 21)
        Me.ParentIOTxt.TabIndex = 157
        Me.ParentIOTxt.Text = "0"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "1st IO :"
        '
        'LUTxt
        '
        Me.LUTxt.Location = New System.Drawing.Point(272, 312)
        Me.LUTxt.Name = "LUTxt"
        Me.LUTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LUTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LUTxt.Size = New System.Drawing.Size(40, 19)
        Me.LUTxt.TabIndex = 155
        Me.LUTxt.Text = "0"
        '
        'MRCLTxt
        '
        Me.MRCLTxt.Location = New System.Drawing.Point(200, 312)
        Me.MRCLTxt.Name = "MRCLTxt"
        Me.MRCLTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MRCLTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MRCLTxt.Size = New System.Drawing.Size(40, 19)
        Me.MRCLTxt.TabIndex = 154
        Me.MRCLTxt.Text = "0"
        '
        'A4Txt
        '
        Me.A4Txt.Location = New System.Drawing.Point(120, 312)
        Me.A4Txt.Name = "A4Txt"
        Me.A4Txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.A4Txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.A4Txt.Size = New System.Drawing.Size(48, 19)
        Me.A4Txt.TabIndex = 153
        Me.A4Txt.Text = "0"
        '
        'LDAmttxt
        '
        Me.LDAmttxt.Location = New System.Drawing.Point(120, 88)
        Me.LDAmttxt.Name = "LDAmttxt"
        Me.LDAmttxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LDAmttxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LDAmttxt.Size = New System.Drawing.Size(104, 19)
        Me.LDAmttxt.TabIndex = 152
        Me.LDAmttxt.Text = "0"
        '
        'OriginalIOTxt
        '
        Me.OriginalIOTxt.Location = New System.Drawing.Point(120, 232)
        Me.OriginalIOTxt.Name = "OriginalIOTxt"
        Me.OriginalIOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OriginalIOTxt.Size = New System.Drawing.Size(104, 19)
        Me.OriginalIOTxt.TabIndex = 146
        '
        'InvoiceNoTxt
        '
        Me.InvoiceNoTxt.Location = New System.Drawing.Point(120, 64)
        Me.InvoiceNoTxt.Name = "InvoiceNoTxt"
        Me.InvoiceNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InvoiceNoTxt.Size = New System.Drawing.Size(104, 19)
        Me.InvoiceNoTxt.TabIndex = 145
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 16)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "Invoice No :"
        '
        'CompletedDateEdit
        '
        Me.CompletedDateEdit.DateTime = New Date(CType(0, Long))
        Me.CompletedDateEdit.Location = New System.Drawing.Point(400, 312)
        Me.CompletedDateEdit.Name = "CompletedDateEdit"
        Me.CompletedDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompletedDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CompletedDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.CompletedDateEdit.TabIndex = 143
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(320, 312)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(64, 24)
        Me.Label40.TabIndex = 140
        Me.Label40.Text = "Date Completed :"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(248, 312)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(32, 16)
        Me.Label39.TabIndex = 139
        Me.Label39.Text = "LU :"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(168, 312)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 16)
        Me.Label38.TabIndex = 138
        Me.Label38.Text = "MRC :"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(96, 312)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(24, 16)
        Me.Label37.TabIndex = 137
        Me.Label37.Text = "A4 :"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 312)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 16)
        Me.Label36.TabIndex = 135
        Me.Label36.Text = "Qty for Label :"
        '
        'ReasonMemo
        '
        Me.ReasonMemo.Location = New System.Drawing.Point(120, 256)
        Me.ReasonMemo.Name = "ReasonMemo"
        Me.ReasonMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ReasonMemo.Size = New System.Drawing.Size(384, 48)
        Me.ReasonMemo.TabIndex = 134
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(8, 256)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 32)
        Me.Label35.TabIndex = 133
        Me.Label35.Text = "Reason for Delay in OGB Installation :"
        '
        'LegendInvoiceTxt
        '
        Me.LegendInvoiceTxt.Location = New System.Drawing.Point(400, 232)
        Me.LegendInvoiceTxt.Name = "LegendInvoiceTxt"
        Me.LegendInvoiceTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LegendInvoiceTxt.Size = New System.Drawing.Size(104, 19)
        Me.LegendInvoiceTxt.TabIndex = 132
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(248, 232)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(112, 16)
        Me.Label34.TabIndex = 131
        Me.Label34.Text = "Legend Invoice No :"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 232)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 16)
        Me.Label33.TabIndex = 129
        Me.Label33.Text = "Original IO Received :"
        '
        'RemarksMemo
        '
        Me.RemarksMemo.Location = New System.Drawing.Point(120, 168)
        Me.RemarksMemo.Name = "RemarksMemo"
        Me.RemarksMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RemarksMemo.Size = New System.Drawing.Size(384, 56)
        Me.RemarksMemo.TabIndex = 128
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 168)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 16)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "Remarks :"
        '
        'CollectDocDateEdit
        '
        Me.CollectDocDateEdit.DateTime = New Date(CType(0, Long))
        Me.CollectDocDateEdit.Location = New System.Drawing.Point(400, 136)
        Me.CollectDocDateEdit.Name = "CollectDocDateEdit"
        Me.CollectDocDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CollectDocDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CollectDocDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.CollectDocDateEdit.TabIndex = 126
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(248, 136)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(128, 32)
        Me.Label31.TabIndex = 125
        Me.Label31.Text = "Collect Document from Survey Date :"
        '
        'F28RecvDateEdit
        '
        Me.F28RecvDateEdit.DateTime = New Date(CType(0, Long))
        Me.F28RecvDateEdit.Location = New System.Drawing.Point(120, 136)
        Me.F28RecvDateEdit.Name = "F28RecvDateEdit"
        Me.F28RecvDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.F28RecvDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.F28RecvDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.F28RecvDateEdit.TabIndex = 124
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 136)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 16)
        Me.Label30.TabIndex = 123
        Me.Label30.Text = "F0028 Receive Date :"
        '
        'NoticeIndexTxt
        '
        Me.NoticeIndexTxt.Location = New System.Drawing.Point(400, 88)
        Me.NoticeIndexTxt.Name = "NoticeIndexTxt"
        Me.NoticeIndexTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NoticeIndexTxt.Size = New System.Drawing.Size(104, 19)
        Me.NoticeIndexTxt.TabIndex = 122
        '
        'DWCDateEdit
        '
        Me.DWCDateEdit.DateTime = New Date(CType(0, Long))
        Me.DWCDateEdit.Location = New System.Drawing.Point(120, 112)
        Me.DWCDateEdit.Name = "DWCDateEdit"
        Me.DWCDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DWCDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DWCDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.DWCDateEdit.TabIndex = 121
        '
        'TOCRecvDateEdit
        '
        Me.TOCRecvDateEdit.DateTime = New Date(CType(0, Long))
        Me.TOCRecvDateEdit.Location = New System.Drawing.Point(400, 112)
        Me.TOCRecvDateEdit.Name = "TOCRecvDateEdit"
        Me.TOCRecvDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TOCRecvDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TOCRecvDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.TOCRecvDateEdit.TabIndex = 120
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(248, 112)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 16)
        Me.Label29.TabIndex = 119
        Me.Label29.Text = "TOC Return Date :"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 112)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 16)
        Me.Label28.TabIndex = 118
        Me.Label28.Text = "DWC Sent Date :"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(248, 88)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 16)
        Me.Label27.TabIndex = 116
        Me.Label27.Text = "Notification Index :"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 16)
        Me.Label26.TabIndex = 115
        Me.Label26.Text = "LD Amount :"
        '
        'InvoiceDateEdit
        '
        Me.InvoiceDateEdit.DateTime = New Date(CType(0, Long))
        Me.InvoiceDateEdit.Location = New System.Drawing.Point(400, 64)
        Me.InvoiceDateEdit.Name = "InvoiceDateEdit"
        Me.InvoiceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InvoiceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.InvoiceDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.InvoiceDateEdit.TabIndex = 113
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(248, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 16)
        Me.Label25.TabIndex = 112
        Me.Label25.Text = "Invoice Date :"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(187, 15)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 18)
        Me.Label44.TabIndex = 79
        Me.Label44.Text = "IO :"
        '
        'AddNext_CheckBox
        '
        Me.AddNext_CheckBox.Location = New System.Drawing.Point(519, 22)
        Me.AddNext_CheckBox.Name = "AddNext_CheckBox"
        Me.AddNext_CheckBox.Size = New System.Drawing.Size(198, 18)
        Me.AddNext_CheckBox.TabIndex = 119
        Me.AddNext_CheckBox.Text = "Continue create after saving"
        Me.AddNext_CheckBox.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TabControl2)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 472)
        Me.Panel1.TabIndex = 120
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(592, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(329, 468)
        Me.TabControl2.TabIndex = 115
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.Label51)
        Me.TabPage4.Controls.Add(Me.Label50)
        Me.TabPage4.Controls.Add(Me.Issues_Detail_MemoEdit)
        Me.TabPage4.Controls.Add(Me.Issues_Flag_CheckBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(321, 442)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Issues"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(12, 26)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(116, 16)
        Me.Label51.TabIndex = 158
        Me.Label51.Text = "Issues Encountered ?"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(12, 51)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 16)
        Me.Label50.TabIndex = 157
        Me.Label50.Text = "Issue Details"
        '
        'Issues_Detail_MemoEdit
        '
        Me.Issues_Detail_MemoEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Issues_Detail_MemoEdit.Location = New System.Drawing.Point(15, 75)
        Me.Issues_Detail_MemoEdit.Name = "Issues_Detail_MemoEdit"
        Me.Issues_Detail_MemoEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Issues_Detail_MemoEdit.Size = New System.Drawing.Size(288, 347)
        Me.Issues_Detail_MemoEdit.TabIndex = 156
        '
        'Issues_Flag_CheckBox
        '
        Me.Issues_Flag_CheckBox.Location = New System.Drawing.Point(134, 21)
        Me.Issues_Flag_CheckBox.Name = "Issues_Flag_CheckBox"
        Me.Issues_Flag_CheckBox.Size = New System.Drawing.Size(16, 24)
        Me.Issues_Flag_CheckBox.TabIndex = 155
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.IO_LookUpEdit)
        Me.Panel2.Controls.Add(Me.ContractNo_LookUpEdit)
        Me.Panel2.Controls.Add(Me.Label47)
        Me.Panel2.Controls.Add(Me.NewButton)
        Me.Panel2.Controls.Add(Me.Label44)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(925, 48)
        Me.Panel2.TabIndex = 121
        '
        'IO_LookUpEdit
        '
        Me.IO_LookUpEdit.Location = New System.Drawing.Point(215, 12)
        Me.IO_LookUpEdit.Name = "IO_LookUpEdit"
        Me.IO_LookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IO_LookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.IO_LookUpEdit.Properties.DropDownRows = 25
        Me.IO_LookUpEdit.Properties.NullString = ""
        Me.IO_LookUpEdit.Properties.PopupWidth = 170
        Me.IO_LookUpEdit.Size = New System.Drawing.Size(163, 23)
        Me.IO_LookUpEdit.TabIndex = 159
        '
        'ContractNo_LookUpEdit
        '
        Me.ContractNo_LookUpEdit.Location = New System.Drawing.Point(78, 12)
        Me.ContractNo_LookUpEdit.Name = "ContractNo_LookUpEdit"
        Me.ContractNo_LookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNo_LookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContractNo_LookUpEdit.Properties.NullString = ""
        Me.ContractNo_LookUpEdit.Properties.PopupWidth = 184
        Me.ContractNo_LookUpEdit.Size = New System.Drawing.Size(104, 23)
        Me.ContractNo_LookUpEdit.TabIndex = 158
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(9, 15)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(72, 16)
        Me.Label47.TabIndex = 157
        Me.Label47.Text = "Contract No :"
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(392, 10)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(75, 23)
        Me.NewButton.TabIndex = 4
        Me.NewButton.Text = "New"
        '
        'SaveXtraButton
        '
        Me.SaveXtraButton.Location = New System.Drawing.Point(12, 12)
        Me.SaveXtraButton.Name = "SaveXtraButton"
        Me.SaveXtraButton.Size = New System.Drawing.Size(72, 37)
        Me.SaveXtraButton.TabIndex = 0
        Me.SaveXtraButton.Text = "Save"
        Me.SaveXtraButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.SaveXtraButton)
        Me.Panel3.Controls.Add(Me.AddNext_CheckBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 520)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(925, 59)
        Me.Panel3.TabIndex = 122
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(90, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OGB630DinTxt
        '
        Me.OGB630DinTxt.Location = New System.Drawing.Point(462, 222)
        Me.OGB630DinTxt.Name = "OGB630DinTxt"
        Me.OGB630DinTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB630DinTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OGB630DinTxt.Size = New System.Drawing.Size(74, 19)
        Me.OGB630DinTxt.TabIndex = 162
        Me.OGB630DinTxt.Text = "0"
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(288, 222)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(152, 16)
        Me.Label52.TabIndex = 161
        Me.Label52.Text = "630A Din Replaced"
        '
        'OGBForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(925, 579)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "OGBForm"
        Me.Text = "OGB Filer for Sales"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PaymentClaim_DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkVerification_DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGBOTTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGBSurveyedTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGBInstalledTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtCompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtCommenceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommenceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Substation_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IONumberTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParentIOcmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignOfficerCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.RedoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGBPlusMinusTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRCTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGB2YTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGB1YTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGB2XTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGB1XTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.OGBLabelledTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeederLabelledTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParentIOTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRCLTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A4Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDAmttxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OriginalIOTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReasonMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegendInvoiceTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectDocDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F28RecvDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoticeIndexTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DWCDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOCRecvDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Issues_Detail_MemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.IO_LookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractNo_LookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.OGB630DinTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public data As System.Data.DataTable
    Public Contract_No As String
    Public Status As String

    Private Sub OGBForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OnLoading = True

        LoadOfficerCmb()
        LoadSigningOfficerCmb()
        LoadParentIOCmb()
        LoadContractCmb()
        Me.LoadContractNo_LookUpEdit()
        LoadCombo()

        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            Dim ds As DataSet
            If .GetOGBContract(ds, Contract_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Contract_No = ds.Tables(0).Rows(0)("OGB_Contract_No")
                    ContractNoTxt.Text = Contract_No
                End If
            End If
        End With

        Select Case (Status)
            Case "ADD"
                RedoCmb.Properties.LookUpData.KeyValue = "5 WAY"
                AddNext_CheckBox.Visible = True
                'InitializeForm()
            Case "EDIT"
                AddNext_CheckBox.Visible = False
                'Dim ds As DataSet
                ParentIOcmb.Enabled = False
                With New BusinessRules.OGBBusRules.OGBBusLogic
                    If .GetIO(Navds, OGB_IO_Id) Then
                        SetWindowValue(Navds)

                    End If
                End With
                'ds.Dispose()
        End Select
        TabControl1.IDEPixelBorder = True

        OnLoading = False

    End Sub

#Region " Set Window Value "
    Private Sub SetWindowValue(ByVal ds As DataSet, Optional ByVal pSetType As String = "")
        Dim tmpDS As DataSet

        OnLoading = True

        If pSetType <> "RE" Then

            InitForm()

            Me.IONumberTxt.Text = ds.Tables(0).Rows(0)("IO_No")

            If Not IsDBNull(ds.Tables(0).Rows(0)("Parent_IO_Id")) Then
                With New BusinessRules.OGBBusRules.OGBBusLogic
                    If .GetIO(tmpDS, ds.Tables(0).Rows(0)("Parent_IO_Id")) Then
                        If tmpDS.Tables(0).Rows.Count > 0 Then
                            Me.ParentIOTxt.Text = tmpDS.Tables(0).Rows(0)("IO_No")
                        End If
                    End If
                End With
                tmpDS.Dispose()
                If ds.Tables(0).Rows(0)("Parent_IO_Id") > 0 Then
                    Me.ParentIOcmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Parent_IO_Id")
                    OnLoading = True
                End If
            End If
        Else
            Me.ParentIOTxt.Text = ds.Tables(0).Rows(0)("IO_No")
        End If

        Me.OfficerCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Officer_In_Charge_Id")
        Me.SignOfficerCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Counter_Sign_Officer_Id")

        '        If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Section")) Then
        '        OGB_Section = ds.Tables(0).Rows(0)("OGB_Section")
        '        With New BusinessRules.SystemBusRules.SectionBusLogic
        '        Dim dsSection As DataSet
        '        If .GetSection(dsSection, OGB_Section) Then
        '        If dsSection.Tables(0).Rows.Count > 0 Then
        '        If Not IsDBNull(dsSection.Tables(0).Rows(0)("Section_Code")) Then
        '        SectionTxt.Text = dsSection.Tables(0).Rows(0)("Section_Code")
        '        End If
        '        End If
        '        End If
        '        dsSection.Dispose()
        '        End With
        '        End If

        If Not IsDBNull(ds.Tables(0).Rows(0)("Officer_In_Charge_Id")) Then
            Me.OfficerCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Officer_In_Charge_Id")
            Officer_In_Charge_Id = ds.Tables(0).Rows(0)("Officer_In_Charge_Id")
            With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
                Dim dsOfficer As DataSet
                If .GetOfficerInCharge(dsOfficer, Officer_In_Charge_Id) Then
                    If dsOfficer.Tables(0).Rows.Count > 0 Then

                        If Not IsDBNull(dsOfficer.Tables(0).Rows(0)("Section_ID")) Then
                            OGB_Section = dsOfficer.Tables(0).Rows(0)("Section_ID")
                            With New BusinessRules.SystemBusRules.SectionBusLogic
                                Dim dsSection As DataSet
                                If .GetSection(dsSection, OGB_Section) Then
                                    If dsSection.Tables(0).Rows.Count > 0 Then
                                        If Not IsDBNull(dsSection.Tables(0).Rows(0)("Section_Code")) Then
                                            SectionTxt.Text = dsSection.Tables(0).Rows(0)("Section_Code")
                                        End If
                                    End If
                                End If
                                dsSection.Dispose()
                            End With
                        End If

                        '                        If Not IsDBNull(dsOfficer.Tables(0).Rows(0)("Contact_Location")) Then
                        '                            Me.LocMemo.Text = dsOfficer.Tables(0).Rows(0)("Contact_Location")
                        '                    End If
                    End If
                End If
                dsOfficer.Dispose()
            End With
        End If
        Me.LocMemo.Text = ds.Tables(0).Rows(0)("OGB_Location")
        If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Substation")) Then
            Me.Substation_txt.Text = ds.Tables(0).Rows(0)("OGB_Substation")
        End If

        If Not IsDBNull(ds.Tables(0).Rows(0)("MRC_No")) Then
            Me.MRCTxt.Text = ds.Tables(0).Rows(0)("MRC_No")
        End If

        If pSetType <> "RE" Then
            If Not IsDBNull(ds.Tables(0).Rows(0)("IO_Recv_Date")) Then
                Me.RecDateEdit.DateTime = ds.Tables(0).Rows(0)("IO_Recv_Date")
            Else
                Me.RecDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Commence_Date")) Then
                Me.CommenceDateEdit.DateTime = ds.Tables(0).Rows(0)("Commence_Date")
            Else
                Me.CommenceDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Completion_Date")) Then
                Me.CompleteDateEdit.DateTime = ds.Tables(0).Rows(0)("Completion_Date")
            Else
                Me.CompleteDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Extend_Commence_Date")) Then
                Me.ExtCommenceDateEdit.DateTime = ds.Tables(0).Rows(0)("Extend_Commence_Date")
            Else
                Me.ExtCommenceDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Extend_Completion_Date")) Then
                Me.ExtCompleteDateEdit.DateTime = ds.Tables(0).Rows(0)("Extend_Completion_Date")
            Else
                Me.ExtCompleteDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Installation_Date")) Then
                Me.InstallDateEdit.DateTime = ds.Tables(0).Rows(0)("Installation_Date")
            Else
                Me.InstallDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("WorkVerification_Date")) Then
                Me.WorkVerification_DateEdit.DateTime = ds.Tables(0).Rows(0)("WorkVerification_Date")
            Else
                Me.WorkVerification_DateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("PaymentClaim_Date")) Then
                Me.PaymentClaim_DateEdit.DateTime = ds.Tables(0).Rows(0)("PaymentClaim_Date")
            Else
                Me.PaymentClaim_DateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Serial_No")) Then
                Me.SerialTxt.Text = ds.Tables(0).Rows(0)("Serial_No")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Installed")) Then
                Me.OGBInstalledTxt.Text = ds.Tables(0).Rows(0)("OGB_Installed")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Surveyed")) Then
                Me.OGBSurveyedTxt.Text = ds.Tables(0).Rows(0)("OGB_Surveyed")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_OT")) Then
                Me.OGBOTTxt.Text = ds.Tables(0).Rows(0)("OGB_OT")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Labelled")) Then
                Me.OGBLabelledTxt.Text = ds.Tables(0).Rows(0)("OGB_Labelled")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_630ADin")) Then
                Me.OGB630DinTxt.Text = ds.Tables(0).Rows(0)("OGB_630ADin")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("FeederLabelled")) Then
                Me.FeederLabelledTxt.Text = ds.Tables(0).Rows(0)("FeederLabelled")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Redo_Flg")) Then
                If ds.Tables(0).Rows(0)("Redo_Flg") = "1" Then
                    Me.RedoChk.Checked = True
                Else
                    Me.RedoChk.Checked = False
                End If
            Else
                Me.RedoChk.Checked = False
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Issues_Flag")) Then
                If ds.Tables(0).Rows(0)("Issues_Flag") = "1" Then
                    Me.Issues_Flag_CheckBox.Checked = True
                Else
                    Me.Issues_Flag_CheckBox.Checked = False
                End If
            Else
                Me.Issues_Flag_CheckBox.Checked = False
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Redo_Text")) Then
                RedoCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Redo_Text")
                '            Me.RedoTxt.Text = ds.Tables(0).Rows(0)("Redo_Text")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB1_X")) Then
                Me.OGB1XTxt.Text = ds.Tables(0).Rows(0)("OGB1_X")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB2_X")) Then
                Me.OGB2XTxt.Text = ds.Tables(0).Rows(0)("OGB2_X")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB1_Y")) Then
                Me.OGB1YTxt.Text = ds.Tables(0).Rows(0)("OGB1_Y")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB2_Y")) Then
                Me.OGB2YTxt.Text = ds.Tables(0).Rows(0)("OGB2_Y")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Plus_Minus")) Then
                Me.OGBPlusMinusTxt.Text = ds.Tables(0).Rows(0)("OGB_Plus_Minus")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Tested_Passed_Date")) Then
                Me.PassDateEdit.DateTime = ds.Tables(0).Rows(0)("Tested_Passed_Date")
            Else
                Me.PassDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Invoice_No")) Then
                Me.InvoiceNoTxt.Text = ds.Tables(0).Rows(0)("Invoice_No")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Invoice_Date")) Then
                Me.InvoiceDateEdit.DateTime = ds.Tables(0).Rows(0)("Invoice_Date")
            Else
                Me.InvoiceDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("LD_Amount")) Then
                Me.LDAmttxt.Text = ds.Tables(0).Rows(0)("LD_Amount")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Notification_Index")) Then
                Me.NoticeIndexTxt.Text = ds.Tables(0).Rows(0)("Notification_Index")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("DWC_Sent_Date")) Then
                Me.DWCDateEdit.DateTime = ds.Tables(0).Rows(0)("DWC_Sent_Date")
            Else
                Me.DWCDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("TOC_Return_Date")) Then
                Me.TOCRecvDateEdit.DateTime = ds.Tables(0).Rows(0)("TOC_Return_Date")
            Else
                Me.TOCRecvDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("F0028_Recv_Date")) Then
                Me.F28RecvDateEdit.DateTime = ds.Tables(0).Rows(0)("F0028_Recv_Date")
            Else
                Me.F28RecvDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Collect_Doc_Date")) Then
                Me.CollectDocDateEdit.DateTime = ds.Tables(0).Rows(0)("Collect_Doc_Date")
            Else
                Me.CollectDocDateEdit.DateTime = New Date(CType(0, Long))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Remarks")) Then
                Me.RemarksMemo.Text = ds.Tables(0).Rows(0)("Remarks")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Issues_Detail")) Then
                Me.Issues_Detail_MemoEdit.Text = ds.Tables(0).Rows(0)("Issues_Detail")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Original_IO")) Then
                Me.OriginalIOTxt.Text = ds.Tables(0).Rows(0)("Original_IO")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Legend_Invoice_No")) Then
                Me.LegendInvoiceTxt.Text = ds.Tables(0).Rows(0)("Legend_Invoice_No")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Delay_Reason")) Then
                Me.ReasonMemo.Text = ds.Tables(0).Rows(0)("Delay_Reason")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("A4_Qty")) Then
                Me.A4Txt.Text = ds.Tables(0).Rows(0)("A4_Qty")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("MRC_Qty")) Then
                Me.MRCLTxt.Text = ds.Tables(0).Rows(0)("MRC_Qty")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("LU_Qty")) Then
                Me.LUTxt.Text = ds.Tables(0).Rows(0)("LU_Qty")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Date_Completed")) Then
                Me.CompletedDateEdit.DateTime = ds.Tables(0).Rows(0)("Date_Completed")
            Else
                Me.CompletedDateEdit.DateTime = New Date(CType(0, Long))
            End If
        End If

        OnLoading = False

    End Sub
#End Region

#Region " Buttons "
    Private Sub SaveXtraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveXtraButton.Click
        Dim tmpParentIO As String
        Dim tmpDS As DataSet

        RetrieveFromForm()
        If ValidData() Then
            Select Case UCase(Status)
                Case "ADD"
                    If SaveData() = True Then
                        Edited = False

                        tmpParentIO = Me.ParentIOcmb.Properties.LookUpData.KeyValue
                        If Len(tmpParentIO) > 0 Then
                            With New BusinessRules.OGBBusRules.OGBBusLogic
                                If .GetIO(tmpDS, tmpParentIO) Then
                                    If tmpDS.Tables(0).Rows.Count > 0 Then
                                        Me.ParentIOTxt.Text = tmpDS.Tables(0).Rows(0)("IO_No")
                                    End If
                                End If
                            End With
                            tmpDS.Dispose()
                        End If

                        'ReLoad IO_LookUpEdit
                        LoadIO_LookUpEdit()

                        If AddNext_CheckBox.Checked = True Then
                            OnLoading = True
                            Me.InitForm()
                            OnLoading = False
                            Status = "ADD"
                        Else

                            If OGB_IO_Id <> 0 Then
                                Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {OGB_IO_Id, 0, 0, 0})
                            End If
                            LoadIO()
                            Status = "EDIT"

                        End If
                    End If

                Case "EDIT"
                    UpdateData()
                    Edited = False
            End Select
        End If
    End Sub

    Function SaveData() As Boolean
        With New BusinessRules.OGBBusRules.OGBBusLogic
            Me.SaveXtraButton.Focus()
            If .IONoExist(IO_No, Contract_Id) Then
                .Contract_Id = Contract_Id
                .IO_No = IO_No
                .ParentIO = ParentIO
                .Officer_In_Charge_Id = Officer_In_Charge_Id
                .Counter_Sign_Officer_Id = Counter_Sign_Officer_Id
                '                .OGB_Section = OGB_Section
                .OGB_Location = OGB_Location
                .OGB_Substation = OGB_Substation
                .IO_Recv_Date = Microsoft.VisualBasic.DateAndTime.Day(IO_Recv_Date) & "/" & MonthName(Month(IO_Recv_Date)) & "/" & Year(IO_Recv_Date)
                .Commence_Date = Microsoft.VisualBasic.DateAndTime.Day(Commence_Date) & "/" & MonthName(Month(Commence_Date)) & "/" & Year(Commence_Date)
                .Completion_Date = Microsoft.VisualBasic.DateAndTime.Day(Completion_Date) & "/" & MonthName(Month(Completion_Date)) & "/" & Year(Completion_Date)
                If Len(Extend_Commence_Date) > 0 Then
                    .Extend_Commence_Date = Microsoft.VisualBasic.DateAndTime.Day(Extend_Commence_Date) & "/" & MonthName(Month(Extend_Commence_Date)) & "/" & Year(Extend_Commence_Date)
                Else
                    .Extend_Commence_Date = Nothing
                End If
                If Len(Extend_Completion_Date) > 0 Then
                    .Extend_Completion_Date = Microsoft.VisualBasic.DateAndTime.Day(Extend_Completion_Date) & "/" & MonthName(Month(Extend_Completion_Date)) & "/" & Year(Extend_Completion_Date)
                Else
                    .Extend_Completion_Date = Nothing
                End If

                If Len(Installation_Date) > 0 Then
                    .Installation_Date = Microsoft.VisualBasic.DateAndTime.Day(Installation_Date) & "/" & MonthName(Month(Installation_Date)) & "/" & Year(Installation_Date)
                Else
                    .Installation_Date = Nothing
                End If

                If Len(WorkVerification_Date) > 0 Then
                    .WorkVerification_Date = Microsoft.VisualBasic.DateAndTime.Day(WorkVerification_Date) & "/" & MonthName(Month(WorkVerification_Date)) & "/" & Year(WorkVerification_Date)
                Else
                    .WorkVerification_Date = Nothing
                End If

                If Len(PaymentClaim_Date) > 0 Then
                    .PaymentClaim_Date = Microsoft.VisualBasic.DateAndTime.Day(PaymentClaim_Date) & "/" & MonthName(Month(PaymentClaim_Date)) & "/" & Year(PaymentClaim_Date)
                Else
                    .PaymentClaim_Date = Nothing
                End If

                If Len(Serial_No) > 0 Then
                    .Serial_No = Serial_No
                End If

                If Len(OGB_Plus_Minus) > 0 Then
                    .OGB_Plus_Minus = OGB_Plus_Minus
                End If

                If Len(Tested_Passed_Date) > 0 Then
                    .Tested_Passed_Date = Microsoft.VisualBasic.DateAndTime.Day(Tested_Passed_Date) & "/" & MonthName(Month(Tested_Passed_Date)) & "/" & Year(Tested_Passed_Date)
                Else
                    .Tested_Passed_Date = Tested_Passed_Date
                End If

                .OGB_Installed = OGB_Installed
                .OGB_Surveyed = OGB_Surveyed
                .OGB_OT = OGB_OT
                .OGB_Labelled = OGB_Labelled
                .OGB_630ADin = OGB_630ADin
                .FeederLabelled = FeederLabelled

                If Len(MRC_No) > 0 Then
                    .MRC_No = MRC_No
                End If

                .Redo_Flg = Redo_Flg
                If Len(Redo_Text) > 0 Then
                    .Redo_Text = Redo_Text
                End If

                .Issues_Flag = Issues_Flag

                If Len(OGB1_X) > 0 Then
                    .OGB1_X = OGB1_X
                End If

                If Len(OGB2_X) > 0 Then
                    .OGB2_X = OGB2_X
                End If

                If Len(OGB1_Y) > 0 Then
                    .OGB1_Y = OGB1_Y
                End If

                If Len(OGB2_Y) > 0 Then
                    .OGB2_Y = OGB2_Y
                End If

                .Invoice_No = Invoice_No

                If Len(Invoice_Date) > 0 Then
                    .Invoice_Date = Microsoft.VisualBasic.DateAndTime.Day(Invoice_Date) & "/" & MonthName(Month(Invoice_Date)) & "/" & Year(Invoice_Date)
                Else
                    .Invoice_Date = Invoice_Date
                End If

                If Len(LD_Amount) > 0 Then
                    .LD_Amount = LD_Amount
                End If

                If Len(DWC_Sent_Date) > 0 Then
                    .DWC_Sent_Date = Microsoft.VisualBasic.DateAndTime.Day(DWC_Sent_Date) & "/" & MonthName(Month(DWC_Sent_Date)) & "/" & Year(DWC_Sent_Date)
                Else
                    .DWC_Sent_Date = DWC_Sent_Date
                End If

                If Len(TOC_Return_Date) > 0 Then
                    .TOC_Return_Date = Microsoft.VisualBasic.DateAndTime.Day(TOC_Return_Date) & "/" & MonthName(Month(TOC_Return_Date)) & "/" & Year(TOC_Return_Date)
                Else
                    .TOC_Return_Date = TOC_Return_Date
                End If

                If Len(F0028_Recv_Date) > 0 Then
                    .F0028_Recv_Date = Microsoft.VisualBasic.DateAndTime.Day(F0028_Recv_Date) & "/" & MonthName(Month(F0028_Recv_Date)) & "/" & Year(F0028_Recv_Date)
                Else
                    .F0028_Recv_Date = F0028_Recv_Date
                End If

                If Len(Collect_Doc_Date) > 0 Then
                    .Collect_Doc_Date = Microsoft.VisualBasic.DateAndTime.Day(Collect_Doc_Date) & "/" & MonthName(Month(Collect_Doc_Date)) & "/" & Year(Collect_Doc_Date)
                Else
                    .Collect_Doc_Date = Collect_Doc_Date
                End If

                .Remarks = Remarks

                .Issues_Detail = Issues_Detail

                If Len(Original_IO) > 0 Then
                    .Original_IO = Original_IO
                End If

                If Len(Legend_Invoice_No) > 0 Then
                    .Legend_Invoice_No = Legend_Invoice_No
                End If

                If Len(Delay_Reason) > 0 Then
                    .Delay_Reason = Delay_Reason
                End If

                .A4_Qty = A4_Qty
                .MRC_Qty = MRC_Qty
                .LU_Qty = LU_Qty

                If Len(Date_Completed) > 0 Then
                    .Date_Completed = Microsoft.VisualBasic.DateAndTime.Day(Date_Completed) & "/" & MonthName(Month(Date_Completed)) & "/" & Year(Date_Completed)
                Else
                    .Date_Completed = Date_Completed
                End If

                .UserID = UserID
                '.OGB_IO_Id = OGB_IO_Id
                If .SaveIO(OGB_IO_Id) Then
                    Status = "EDIT"
                    MessageBox.Show("I/O saved. ", "OGB Filer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                End If
            Else
                MessageBox.Show("This I/O No already exists. ", "OGB Filer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With

        Return False
    End Function

    Private Sub UpdateData()
        With New BusinessRules.OGBBusRules.OGBBusLogic
            .IO_No = IO_No
            .ParentIO = ParentIO
            .Officer_In_Charge_Id = Officer_In_Charge_Id
            .Counter_Sign_Officer_Id = Counter_Sign_Officer_Id
            '            .OGB_Section = OGB_Section
            .OGB_Location = OGB_Location
            .OGB_Substation = OGB_Substation
            .IO_Recv_Date = Microsoft.VisualBasic.DateAndTime.Day(IO_Recv_Date) & "/" & MonthName(Month(IO_Recv_Date)) & "/" & Year(IO_Recv_Date)
            .Commence_Date = Microsoft.VisualBasic.DateAndTime.Day(Commence_Date) & "/" & MonthName(Month(Commence_Date)) & "/" & Year(Commence_Date)
            .Completion_Date = Microsoft.VisualBasic.DateAndTime.Day(Completion_Date) & "/" & MonthName(Month(Completion_Date)) & "/" & Year(Completion_Date)
            If Len(Extend_Commence_Date) > 0 Then
                .Extend_Commence_Date = Microsoft.VisualBasic.DateAndTime.Day(Extend_Commence_Date) & "/" & MonthName(Month(Extend_Commence_Date)) & "/" & Year(Extend_Commence_Date)
            Else
                .Extend_Commence_Date = Extend_Commence_Date
            End If
            If Len(Extend_Completion_Date) > 0 Then
                .Extend_Completion_Date = Microsoft.VisualBasic.DateAndTime.Day(Extend_Completion_Date) & "/" & MonthName(Month(Extend_Completion_Date)) & "/" & Year(Extend_Completion_Date)
            Else
                .Extend_Completion_Date = Extend_Completion_Date
            End If

            If Len(Installation_Date) > 0 Then
                .Installation_Date = Microsoft.VisualBasic.DateAndTime.Day(Installation_Date) & "/" & MonthName(Month(Installation_Date)) & "/" & Year(Installation_Date)
            Else
                .Installation_Date = Nothing
            End If


            If Len(WorkVerification_Date) > 0 Then
                .WorkVerification_Date = Microsoft.VisualBasic.DateAndTime.Day(WorkVerification_Date) & "/" & MonthName(Month(WorkVerification_Date)) & "/" & Year(WorkVerification_Date)
            Else
                .WorkVerification_Date = Nothing
            End If

            If Len(PaymentClaim_Date) > 0 Then
                .PaymentClaim_Date = Microsoft.VisualBasic.DateAndTime.Day(PaymentClaim_Date) & "/" & MonthName(Month(PaymentClaim_Date)) & "/" & Year(PaymentClaim_Date)
            Else
                .PaymentClaim_Date = Nothing
            End If

            If Len(Serial_No) > 0 Then
                .Serial_No = Serial_No
            End If

            If Len(OGB_Plus_Minus) > 0 Then
                .OGB_Plus_Minus = OGB_Plus_Minus
            End If

            If Len(Tested_Passed_Date) > 0 Then
                .Tested_Passed_Date = Microsoft.VisualBasic.DateAndTime.Day(Tested_Passed_Date) & "/" & MonthName(Month(Tested_Passed_Date)) & "/" & Year(Tested_Passed_Date)
            Else
                .Tested_Passed_Date = Tested_Passed_Date
            End If

            .OGB_Installed = OGB_Installed
            .OGB_Surveyed = OGB_Surveyed
            .OGB_OT = OGB_OT
            .OGB_630ADin = OGB_630ADin
            .OGB_Labelled = OGB_Labelled
            .FeederLabelled = FeederLabelled

            If Len(MRC_No) > 0 Then
                .MRC_No = MRC_No
            End If

            .Redo_Flg = Redo_Flg
            If Len(Redo_Text) > 0 Then
                .Redo_Text = Redo_Text
            End If

            .Issues_Flag = Issues_Flag

            If Len(OGB1_X) > 0 Then
                .OGB1_X = OGB1_X
            End If

            If Len(OGB2_X) > 0 Then
                .OGB2_X = OGB2_X
            End If

            If Len(OGB1_Y) > 0 Then
                .OGB1_Y = OGB1_Y
            End If

            If Len(OGB2_Y) > 0 Then
                .OGB2_Y = OGB2_Y
            End If

            .Invoice_No = Invoice_No

            If Len(Invoice_Date) > 0 Then
                .Invoice_Date = Microsoft.VisualBasic.DateAndTime.Day(Invoice_Date) & "/" & MonthName(Month(Invoice_Date)) & "/" & Year(Invoice_Date)
            Else
                .Invoice_Date = Invoice_Date
            End If

            If Len(LD_Amount) > 0 Then
                .LD_Amount = LD_Amount
            End If

            If Len(DWC_Sent_Date) > 0 Then
                .DWC_Sent_Date = Microsoft.VisualBasic.DateAndTime.Day(DWC_Sent_Date) & "/" & MonthName(Month(DWC_Sent_Date)) & "/" & Year(DWC_Sent_Date)
            Else
                .DWC_Sent_Date = DWC_Sent_Date
            End If

            If Len(TOC_Return_Date) > 0 Then
                .TOC_Return_Date = Microsoft.VisualBasic.DateAndTime.Day(TOC_Return_Date) & "/" & MonthName(Month(TOC_Return_Date)) & "/" & Year(TOC_Return_Date)
            Else
                .TOC_Return_Date = TOC_Return_Date
            End If

            If Len(F0028_Recv_Date) > 0 Then
                .F0028_Recv_Date = Microsoft.VisualBasic.DateAndTime.Day(F0028_Recv_Date) & "/" & MonthName(Month(F0028_Recv_Date)) & "/" & Year(F0028_Recv_Date)
            Else
                .F0028_Recv_Date = F0028_Recv_Date
            End If

            If Len(Collect_Doc_Date) > 0 Then
                .Collect_Doc_Date = Microsoft.VisualBasic.DateAndTime.Day(Collect_Doc_Date) & "/" & MonthName(Month(Collect_Doc_Date)) & "/" & Year(Collect_Doc_Date)
            Else
                .Collect_Doc_Date = Collect_Doc_Date
            End If

            .Remarks = Remarks

            .Issues_Detail = Issues_Detail

            If Len(Original_IO) > 0 Then
                .Original_IO = Original_IO
            End If

            If Len(Legend_Invoice_No) > 0 Then
                .Legend_Invoice_No = Legend_Invoice_No
            End If

            If Len(Delay_Reason) > 0 Then
                .Delay_Reason = Delay_Reason
            End If

            .A4_Qty = A4_Qty
            .MRC_Qty = MRC_Qty
            .LU_Qty = LU_Qty

            If Len(NoticeIndexTxt.Text) > 0 Then
                .Notification_Index = NoticeIndexTxt.Text
            End If

            If Len(Date_Completed) > 0 Then
                .Date_Completed = Microsoft.VisualBasic.DateAndTime.Day(Date_Completed) & "/" & MonthName(Month(Date_Completed)) & "/" & Year(Date_Completed)
            Else
                .Date_Completed = Date_Completed
            End If

            .UserID = UserID
            .OGB_IO_Id = OGB_IO_Id
            If .UpdateOGBIO() Then
                MessageBox.Show("I/O Updated. ", "OGB Filer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub
#End Region

#Region " Retrieve Data n ValidData "
    Private Sub RetrieveFromForm()
        Me.SaveXtraButton.Focus()
        IO_No = Me.IONumberTxt.Text
        'ParentIO = Me.IONumberTxt.Text
        ParentIO = Me.ParentIOcmb.Properties.LookUpData.KeyValue
        Officer_In_Charge_Id = Me.OfficerCmb.Properties.LookUpData.KeyValue
        If Not IsDBNull(SignOfficerCmb.Properties.LookUpData.KeyValue) Then
            Counter_Sign_Officer_Id = Me.SignOfficerCmb.Properties.LookUpData.KeyValue
        End If
        '        OGB_Section = Me.SectionTxt.Text
        OGB_Location = Me.LocMemo.Text
        OGB_Substation = Me.Substation_txt.Text

        IO_Recv_Date = Me.RecDateEdit.Text
        Commence_Date = Me.CommenceDateEdit.Text
        Completion_Date = Me.CompleteDateEdit.Text
        Extend_Commence_Date = Me.ExtCommenceDateEdit.Text
        Extend_Completion_Date = Me.ExtCompleteDateEdit.Text
        Installation_Date = Me.InstallDateEdit.Text
        WorkVerification_Date = Me.WorkVerification_DateEdit.Text
        PaymentClaim_Date = Me.PaymentClaim_DateEdit.Text

        Serial_No = Me.SerialTxt.Text
        OGB_Plus_Minus = Me.OGBPlusMinusTxt.Text
        Tested_Passed_Date = Me.PassDateEdit.Text
        OGB_Installed = Me.OGBInstalledTxt.Text
        OGB_Surveyed = Me.OGBSurveyedTxt.Text
        OGB_OT = Me.OGBOTTxt.Text
        OGB_Labelled = Me.OGBLabelledTxt.Text
        OGB_630ADin = Me.OGB630DinTxt.Text
        FeederLabelled = Me.FeederLabelledTxt.Text
        MRC_No = Me.MRCTxt.Text
        If Me.RedoChk.Checked Then
            Redo_Flg = "1"
        Else
            Redo_Flg = "0"
        End If

        Redo_Text = RedoCmb.Properties.LookUpData.KeyValue
        '        Redo_Text = Me.RedoTxt.Text

        If Me.Issues_Flag_CheckBox.Checked Then
            Issues_Flag = "1"
        Else
            Issues_Flag = "0"
        End If
        Issues_Detail = Me.Issues_Detail_MemoEdit.Text

        OGB1_X = Me.OGB1XTxt.Text
        OGB2_X = Me.OGB2XTxt.Text
        OGB1_Y = Me.OGB1YTxt.Text
        OGB2_Y = Me.OGB2YTxt.Text
        Invoice_No = Me.InvoiceNoTxt.Text
        Invoice_Date = Me.InvoiceDateEdit.Text
        LD_Amount = Me.LDAmttxt.Text
        Notification_Index = Me.NoticeIndexTxt.Text

        DWC_Sent_Date = Me.DWCDateEdit.Text
        TOC_Return_Date = Me.TOCRecvDateEdit.Text
        F0028_Recv_Date = Me.F28RecvDateEdit.Text
        Collect_Doc_Date = Me.CollectDocDateEdit.Text
        Remarks = Me.RemarksMemo.Text
        Issues_Detail = Me.Issues_Detail_MemoEdit.Text

        Original_IO = Me.OriginalIOTxt.Text
        Legend_Invoice_No = Me.LegendInvoiceTxt.Text

        Legend_Invoice_No = Me.LegendInvoiceTxt.Text
        Delay_Reason = Me.ReasonMemo.Text

        A4_Qty = Me.A4Txt.Text
        MRC_Qty = Me.MRCLTxt.Text
        LU_Qty = Me.LUTxt.Text
        Date_Completed = Me.CompletedDateEdit.Text
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(IO_No) > 0 Then
            DataOK_Flag = False
            FieldName = "I/O No" & Chr(13)
        End If

        If Officer_In_Charge_Id = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Officer in Charge" & Chr(13)
        End If

        'If Not Len(Officer_In_Charge_Id) > 0 Then
        'DataOK_Flag = False
        'FieldName = FieldName & "Officer in Charge" & Chr(13)
        'End If

        ' YG Counter siging officer not mandatory
        '        If Not Len(Counter_Sign_Officer_Id) > 0 Then
        '            DataOK_Flag = False
        '            FieldName = FieldName & "Counter Sign Officer" & Chr(13)
        '        End If

        'If Not Len(OGB_Location) > 0 Then
        'DataOK_Flag = False
        'FieldName = FieldName & "Location" & Chr(13)
        'End If

        If Not Len(IO_Recv_Date) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "I/O Recv Date" & Chr(13)
        End If

        If Not Len(Commence_Date) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Commence Date" & Chr(13)
        End If

        If Not Len(Completion_Date) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Completion Date" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function
#End Region

    Private Sub CloseXtraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

#Region " Load Combo "
    Private Sub LoadOfficerCmb()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
            If .GetOfficerInCharge(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(OfficerCmb, "Officer_Name", 400, 0, "c")
                        OfficerCmb.Properties.LookUpData.KeyField = "Officer_In_Charge_Id"
                        OfficerCmb.Properties.LookUpData.DisplayField = "Officer_Name"

                        OfficerCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        OfficerCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadSigningOfficerCmb()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
            If .GetOfficerInCharge(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(SignOfficerCmb, "Officer_Name", 400, 0, "c")
                        SignOfficerCmb.Properties.LookUpData.KeyField = "Officer_In_Charge_Id"
                        SignOfficerCmb.Properties.LookUpData.DisplayField = "Officer_Name"

                        SignOfficerCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        SignOfficerCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadParentIOCmb()
        Dim ds As DataSet
        ParentIOcmb.Properties.LookUpData.ListFields.Clear()
        With New BusinessRules.OGBBusRules.OGBBusLogic
            If .GetParentIOByContract(ds, PContract_Id) Then
                If Not ds Is Nothing Then
                    Try
                        ''SimpleBinding LookUp adjustment start

                        AddListFieldInfoToLookUp(ParentIOcmb, "IO_No", 400, 0, "c")
                        ParentIOcmb.Properties.LookUpData.KeyField = "OGB_IO_Id"
                        ParentIOcmb.Properties.LookUpData.DisplayField = "IO_No"

                        ParentIOcmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ParentIOcmb.EditValue = "0"
                        ''SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub


    Private Sub LoadIO_LookUpEdit()
        Dim ds As DataSet
        IO_LookUpEdit.Properties.LookUpData.ListFields.Clear()
        With New BusinessRules.OGBBusRules.OGBBusLogic
            If .GetParentIOByContract(ds, Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue.ToString) Then
                If Not ds Is Nothing Then
                    Try
                        ''SimpleBinding LookUp adjustment start

                        AddListFieldInfoToLookUp(IO_LookUpEdit, "IO_No", 400, 0, "c")
                        IO_LookUpEdit.Properties.LookUpData.KeyField = "OGB_IO_Id"
                        IO_LookUpEdit.Properties.LookUpData.DisplayField = "IO_No"

                        IO_LookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                        IO_LookUpEdit.EditValue = "0"
                        ''SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadContractCmb()
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            If .GetOGBContract(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(ContractNoCmb, "OGB_Contract_No", 400, 0, "c")
                    ContractNoCmb.Properties.LookUpData.KeyField = "OGB_Contract_Id"
                    ContractNoCmb.Properties.LookUpData.DisplayField = "OGB_Contract_No"
                    ContractNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    ContractNoCmb.EditValue = "0"
                    ContractNoCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Contract_Id, 0, 0, 0})
                End If
            End If
        End With
    End Sub

    Private Sub LoadContractNo_LookUpEdit()
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            If .GetOGBContract(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(ContractNo_LookUpEdit, "OGB_Contract_No", 400, 0, "c")
                    ContractNo_LookUpEdit.Properties.LookUpData.KeyField = "OGB_Contract_Id"
                    ContractNo_LookUpEdit.Properties.LookUpData.DisplayField = "OGB_Contract_No"
                    ContractNo_LookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    ContractNo_LookUpEdit.EditValue = "0"
                    ContractNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Contract_Id, 0, 0, 0})
                End If
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

    Private Sub OfficerCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles OfficerCmb.CloseUp
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
            Dim ds As DataSet
            Officer_In_Charge_Id = Me.OfficerCmb.Properties.LookUpData.KeyValue
            If .GetOfficerInCharge(ds, Officer_In_Charge_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SectionTxt.Text = ""
                    '                    LocMemo.Text = ""
                    If Not IsDBNull(ds.Tables(0).Rows(0)("Section_ID")) Then
                        OGB_Section = ds.Tables(0).Rows(0)("Section_ID")
                        With New BusinessRules.SystemBusRules.SectionBusLogic
                            Dim dsSection As DataSet
                            If .GetSection(dsSection, OGB_Section) Then

                                If dsSection.Tables(0).Rows.Count > 0 Then
                                    If Not IsDBNull(dsSection.Tables(0).Rows(0)("Section_Code")) Then
                                        SectionTxt.Text = dsSection.Tables(0).Rows(0)("Section_Code")
                                    End If
                                End If
                            End If
                            dsSection.Dispose()
                        End With
                        '                        If Not IsDBNull(ds.Tables(0).Rows(0)("Contact_Location")) Then
                        '                            LocMemo.Text = ds.Tables(0).Rows(0)("Contact_Location")
                        '                    End If
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub ParentIOcmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles ParentIOcmb.CloseUp

    End Sub


#Region " Hardcoded Combo Box Redo"
    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())
        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub LoadCombo()

        Dim RedoData As String() = New String() {"3 WAY", "5 WAY", "3 WAY (Used)"}
        Dim RedoID As String() = New String() {"3 WAY", "5 WAY", "3 WAY (Used)"}
        SetComboValue(RedoData, RedoCmb, RedoID)

    End Sub
#End Region


    Private Sub OGBForm_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub InitForm()

        'OnLoading = True

        IONumberTxt.Text = ""
        ParentIOcmb.Text = ""

        ContractNoCmb.Properties.LookUpData.KeyValue = Nothing
        ParentIOcmb.Properties.LookUpData.KeyValue = Nothing
        OnLoading = True

        SignOfficerCmb.Properties.LookUpData.KeyValue = Nothing
        OfficerCmb.Properties.LookUpData.KeyValue = Nothing
        SignOfficerCmb.Text = ""
        OfficerCmb.Text = ""

        Me.Substation_txt.Text = ""
        LocMemo.Text = ""
        RecDateEdit.DateTime = New Date(CType(0, Long))
        CommenceDateEdit.DateTime = New Date(CType(0, Long))
        CompleteDateEdit.DateTime = New Date(CType(0, Long))
        SerialTxt.Text = ""
        OGBInstalledTxt.Text = "0"
        ExtCommenceDateEdit.DateTime = New Date(CType(0, Long))
        ExtCompleteDateEdit.DateTime = New Date(CType(0, Long))
        InstallDateEdit.DateTime = New Date(CType(0, Long))
        WorkVerification_DateEdit.DateTime = New Date(CType(0, Long))
        PaymentClaim_DateEdit.DateTime = New Date(CType(0, Long))
        OGBSurveyedTxt.Text = "0"
        OGBOTTxt.Text = "0"
        OGB630DinTxt.Text = "0"
        MRCTxt.Text = ""
        OGB1XTxt.Text = ""
        OGB2XTxt.Text = ""
        OGB1YTxt.Text = ""
        OGB2YTxt.Text = ""
        OGBPlusMinusTxt.Text = ""
        RedoCmb.Text = ""
        PassDateEdit.DateTime = New Date(CType(0, Long))
        ParentIOTxt.Text = "0"
        OGBLabelledTxt.Text = "0"
        InvoiceNoTxt.Text = ""
        LDAmttxt.Text = "0"
        DWCDateEdit.DateTime = New Date(CType(0, Long))
        F28RecvDateEdit.DateTime = New Date(CType(0, Long))
        FeederLabelledTxt.Text = "0"
        InvoiceDateEdit.DateTime = New Date(CType(0, Long))
        NoticeIndexTxt.Text = ""
        TOCRecvDateEdit.DateTime = New Date(CType(0, Long))
        CollectDocDateEdit.DateTime = New Date(CType(0, Long))
        RemarksMemo.Text = ""
        OriginalIOTxt.Text = ""
        LegendInvoiceTxt.Text = ""
        ReasonMemo.Text = ""
        A4Txt.Text = "0"
        MRCLTxt.Text = "0"
        LUTxt.Text = "0"
        CompletedDateEdit.DateTime = New Date(CType(0, Long))
        RedoChk.Checked = False
        TabPage1.Selected = True
        Issues_Detail_MemoEdit.Text = ""
        Issues_Flag_CheckBox.Checked = False
        'OGB_IO_Id = 0
        ContractNoTxt.Text = Contract_No

        'OnLoading = False

    End Sub

    Private Sub TabControl1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectionChanged

    End Sub

    Private Sub SpinEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBOTTxt.Click

    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ContractNoCmb_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContractNoCmb.TextChanged

    End Sub

    Private Sub ContractNoCmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContractNoCmb.ValueChanged
        PContract_Id = ContractNoCmb.Properties.LookUpData.KeyValue()
        LoadParentIOCmb()
    End Sub

    Private Sub ParentIOcmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParentIOcmb.ValueChanged
        Dim tmpParentIO As String

        tmpParentIO = Me.ParentIOcmb.Properties.LookUpData.KeyValue
        With New BusinessRules.OGBBusRules.OGBBusLogic
            If .GetIO(Navds, tmpParentIO) Then
                If OnLoading = False Then
                    SetWindowValue(Navds, "RE")
                End If
            End If
        End With
        Navds.Dispose()
    End Sub

    Private Sub AddNext_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNext_CheckBox.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        Dim Result As DialogResult

        If Edited = True Then

            Result = MessageBox.Show("You have made changes or have edited data without saving, Are you sure you want to exit and create a New IO? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then

                Exit Sub
            End If

        End If

        If Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue = Nothing Then
            MessageBox.Show("You must select a Contract NO. to create the IO", "Error")
            Exit Sub
        End If

        Contract_Id = Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            Dim ds As DataSet
            If .GetOGBContract(ds, Contract_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Contract_No = ds.Tables(0).Rows(0)("OGB_Contract_No")
                    ContractNoTxt.Text = Contract_No
                End If
            End If
        End With

        Edited = False
        Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = Nothing
        OnLoading = True
        Me.InitForm()
        OnLoading = False
        Status = "ADD"

        IONumberTxt.Focus()

        SaveXtraButton.Enabled = True

    End Sub

    Private Sub SignOfficerCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOfficerCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub OfficerCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficerCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub Substation_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Substation_txt.Click

    End Sub

    Private Sub Substation_txt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Substation_txt.ValueChanged
        OnEdit()
    End Sub

    Private Sub LocMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocMemo.Click

    End Sub

    Private Sub LocMemo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocMemo.ValueChanged
        OnEdit()
    End Sub

    Private Sub RecDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub CommenceDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommenceDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub CompleteDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub SerialTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerialTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGBInstalledTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBInstalledTxt.Click

    End Sub

    Private Sub OGBInstalledTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBInstalledTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub ExtCommenceDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtCommenceDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub ExtCompleteDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtCompleteDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub InstallDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGBSurveyedTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBSurveyedTxt.Click
        OnEdit()
    End Sub

    Private Sub OGBOTTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBOTTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub MRCTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRCTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGB1XTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGB1XTxt.Click

    End Sub

    Private Sub OGB1XTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGB1XTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGB2XTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGB2XTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGBPlusMinusTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBPlusMinusTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub RedoChk_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoChk.CheckStateChanged

    End Sub

    Private Sub RedoChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoChk.CheckedChanged
        OnEdit()
    End Sub

    Private Sub RedoCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGB1YTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGB1YTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGB2YTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGB2YTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub PassDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub ParentIOTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParentIOTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub OGBLabelledTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBLabelledTxt.Click

    End Sub

    Private Sub OGBLabelledTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OGBLabelledTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub InvoiceNoTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNoTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub LDAmttxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDAmttxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub DWCDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DWCDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub F28RecvDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F28RecvDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub FeederLabelledTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeederLabelledTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub InvoiceDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub NoticeIndexTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoticeIndexTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub InvoiceNoTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNoTxt.Click

    End Sub

    Private Sub TOCRecvDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOCRecvDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub CollectDocDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectDocDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub RemarksMemo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksMemo.ValueChanged
        OnEdit()
    End Sub

    Private Sub OriginalIOTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginalIOTxt.Click

    End Sub

    Private Sub OriginalIOTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginalIOTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub LegendInvoiceTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LegendInvoiceTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub ReasonMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReasonMemo.Click

    End Sub

    Private Sub ReasonMemo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReasonMemo.ValueChanged
        OnEdit()
    End Sub

    Private Sub A4Txt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4Txt.ValueChanged
        OnEdit()
    End Sub

    Private Sub MRCLTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRCLTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub LUTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LUTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub CompletedDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompletedDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub OnEdit()
        If OnLoading = False Then
            Edited = True
        End If
    End Sub

    Private Sub OGBForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Result As DialogResult

        If Edited = True Then

            Result = MessageBox.Show("You have made changes or have edited data without saving, Are you sure you want to close? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                e.Cancel = True
            Else
                Dim a As MainForm = Me.ParentForm
                If (a.MainTabControl.TabPages.Count > 0) Then
                    If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                        a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                    End If
                End If
            End If
        Else
            Dim a As MainForm = Me.ParentForm
            If (a.MainTabControl.TabPages.Count > 0) Then
                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                End If
            End If
        End If

    End Sub

    Private Sub ContractNo_LookUpEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContractNo_LookUpEdit.ValueChanged
        Me.LoadIO_LookUpEdit()
    End Sub

    Private Sub IO_LookUpEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IO_LookUpEdit.ValueChanged

    End Sub

    Private Sub IO_LookUpEdit_CloseUp(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles IO_LookUpEdit.CloseUp
        LoadIO()
    End Sub

    Private Sub IO_LookUpEdit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IO_LookUpEdit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            LoadIO()
        End If
    End Sub

    Private Sub LoadIO()
        Dim Result As DialogResult

        If OGB_IO_Id = Me.IO_LookUpEdit.Properties.LookUpData.KeyValue Then
            Exit Sub
        End If

        If Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = Nothing Then
            Exit Sub
        End If

        If Edited = True Then

            Result = MessageBox.Show("You have made changes or have edited data without saving, Are you sure you want to exit and load the selected IO? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                'e.Cancel = True
                If OGB_IO_Id = 0 And Status = "ADD" Then
                    Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = Nothing
                End If
                Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {OGB_IO_Id, 0, 0, 0})
                Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Contract_Id, 0, 0, 0})
                Exit Sub

            End If

        End If

        OGB_IO_Id = Me.IO_LookUpEdit.Properties.LookUpData.KeyValue

        OnLoading = True

        Contract_Id = Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            Dim ds As DataSet
            If .GetOGBContract(ds, Contract_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Contract_No = ds.Tables(0).Rows(0)("OGB_Contract_No")
                    ContractNoTxt.Text = Contract_No
                End If
            End If
        End With

        Edited = False

        Status = "EDIT"
        TabPage1.Selected = True
        ParentIOcmb.Enabled = True
        With New BusinessRules.OGBBusRules.OGBBusLogic
            If .GetIO(Navds, OGB_IO_Id) Then
                SetWindowValue(Navds)
            End If
        End With

        SaveXtraButton.Enabled = True

        OnLoading = False
    End Sub

    Private Sub IONumberTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IONumberTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub WorkVerification_DateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkVerification_DateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub PaymentClaim_DateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentClaim_DateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub Issues_Flag_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Issues_Flag_CheckBox.CheckedChanged
        OnEdit()
    End Sub

    Private Sub Issues_Detail_MemoEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Issues_Detail_MemoEdit.Click

    End Sub

    Private Sub Issues_Detail_MemoEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Issues_Detail_MemoEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click

    End Sub
End Class
