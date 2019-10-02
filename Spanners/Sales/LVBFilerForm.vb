Public Class LVBFilerForm
    Inherits System.Windows.Forms.Form

#Region " Variable "
    Public IO_Id As Integer
    Public Contract_Id As Integer
    Public IO_No As String
    Public Parent_IO_Id As Integer
    Public Officer_In_Charge_Id As Integer
    Public LVB_Section As Integer
    Public LVB_Location As String
    Public LVB_Substation As String
    Public MRC_No As String
    Public District As String
    Public IO_Recv_Date As String
    Public Commence_Date As String
    Public Completion_Date As String
    Public Extend_Commence_Date As String
    Public Extend_Completion_Date As String
    Public Installation_Date As String
    Public WorkVerification_Date As String
    Public PaymentClaim_Date As String
    Public DWC_Sent_Date As String
    Public TOC_Return_Date As String
    Public Inspection_Date As String
    Public Invoice_No As String
    Public Invoice_Date As String
    Public Subcont_Invoice_No As String
    Public Subcont_Invoice_Date As String
    Public OverTime_Charge As Decimal
    Public Remarks As String
    Public UserID As String = Common.CommonConn.Config.USERID
    Friend WithEvents AddNext_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveXtraButton As System.Windows.Forms.Button
    Friend WithEvents IO_LookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ContractNo_LookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel

#End Region

    Private Edited As Boolean
    Private OnLoading As Boolean
    Friend WithEvents InspectionDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents WorkVerification_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents PaymentClaim_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Public Status As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pContract_Id As Integer, ByVal pStatus As String, _
                    Optional ByVal pIO_Id As Integer = 0)
        MyBase.New()

        Edited = False
        OnLoading = True
        Contract_Id = pContract_Id
        Status = pStatus

        If Not pIO_Id = 0 Then
            IO_Id = pIO_Id
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContractTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ExtCompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ExtCommenceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CommenceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RecDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TOCRecvDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents InstallDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DWCSentDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RemarksMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents InvoiceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents InvoiceNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents SubConInvDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MRCNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DistrictCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ParentIOcmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents OfficerCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SubContInvoicetxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BoxGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Edit As System.Windows.Forms.MenuItem
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents OTChargesTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SectionTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LocMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IONumberTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Substation_txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Substation_txt = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.IONumberTxt = New DevExpress.XtraEditors.TextEdit
        Me.LocMemo = New DevExpress.XtraEditors.MemoEdit
        Me.SectionTxt = New DevExpress.XtraEditors.TextEdit
        Me.OfficerCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ParentIOcmb = New DevExpress.XtraEditors.LookUpEdit
        Me.DistrictCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.MRCNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ContractTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PaymentClaim_DateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label48 = New System.Windows.Forms.Label
        Me.WorkVerification_DateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label49 = New System.Windows.Forms.Label
        Me.InspectionDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.DWCSentDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.TOCRecvDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.InstallDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.ExtCompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.ExtCommenceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.CompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CommenceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.RecDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.OTChargesTxt = New DevExpress.XtraEditors.SpinEdit
        Me.SubConInvDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.InvoiceNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.RemarksMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.SubContInvoicetxt = New DevExpress.XtraEditors.TextEdit
        Me.InvoiceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.BoxGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Edit = New System.Windows.Forms.MenuItem
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.Label6 = New System.Windows.Forms.Label
        Me.AddNext_CheckBox = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.SaveXtraButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.IO_LookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.ContractNo_LookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.Label47 = New System.Windows.Forms.Label
        Me.NewButton = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        CType(Me.Substation_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IONumberTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParentIOcmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRCNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PaymentClaim_DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkVerification_DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InspectionDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DWCSentDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOCRecvDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtCompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtCommenceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommenceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.OTChargesTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubConInvDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubContInvoicetxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IO_LookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractNo_LookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Substation_txt)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.IONumberTxt)
        Me.GroupBox1.Controls.Add(Me.LocMemo)
        Me.GroupBox1.Controls.Add(Me.SectionTxt)
        Me.GroupBox1.Controls.Add(Me.OfficerCmb)
        Me.GroupBox1.Controls.Add(Me.ParentIOcmb)
        Me.GroupBox1.Controls.Add(Me.DistrictCmb)
        Me.GroupBox1.Controls.Add(Me.MRCNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ContractTxt)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 144)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Substation_txt
        '
        Me.Substation_txt.Location = New System.Drawing.Point(112, 64)
        Me.Substation_txt.Name = "Substation_txt"
        Me.Substation_txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Substation_txt.Properties.MaxLength = 50
        Me.Substation_txt.Size = New System.Drawing.Size(272, 19)
        Me.Substation_txt.TabIndex = 155
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(16, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 154
        Me.Label16.Text = "Substation :"
        '
        'IONumberTxt
        '
        Me.IONumberTxt.Location = New System.Drawing.Point(112, 16)
        Me.IONumberTxt.Name = "IONumberTxt"
        Me.IONumberTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IONumberTxt.Properties.MaxLength = 8
        Me.IONumberTxt.Size = New System.Drawing.Size(88, 19)
        Me.IONumberTxt.TabIndex = 153
        '
        'LocMemo
        '
        Me.LocMemo.Location = New System.Drawing.Point(112, 88)
        Me.LocMemo.Name = "LocMemo"
        Me.LocMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LocMemo.Size = New System.Drawing.Size(272, 48)
        Me.LocMemo.TabIndex = 152
        '
        'SectionTxt
        '
        Me.SectionTxt.Enabled = False
        Me.SectionTxt.Location = New System.Drawing.Point(464, 40)
        Me.SectionTxt.Name = "SectionTxt"
        Me.SectionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SectionTxt.Properties.Enabled = False
        Me.SectionTxt.Size = New System.Drawing.Size(104, 19)
        Me.SectionTxt.TabIndex = 151
        '
        'OfficerCmb
        '
        Me.OfficerCmb.Location = New System.Drawing.Point(112, 39)
        Me.OfficerCmb.Name = "OfficerCmb"
        Me.OfficerCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OfficerCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.OfficerCmb.Properties.NullString = ""
        Me.OfficerCmb.Properties.PopupWidth = 272
        Me.OfficerCmb.Size = New System.Drawing.Size(272, 23)
        Me.OfficerCmb.TabIndex = 89
        '
        'ParentIOcmb
        '
        Me.ParentIOcmb.Location = New System.Drawing.Point(280, 16)
        Me.ParentIOcmb.Name = "ParentIOcmb"
        Me.ParentIOcmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ParentIOcmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ParentIOcmb.Properties.NullString = ""
        Me.ParentIOcmb.Size = New System.Drawing.Size(104, 23)
        Me.ParentIOcmb.TabIndex = 88
        '
        'DistrictCmb
        '
        Me.DistrictCmb.Location = New System.Drawing.Point(464, 88)
        Me.DistrictCmb.Name = "DistrictCmb"
        Me.DistrictCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DistrictCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DistrictCmb.Properties.NullString = ""
        Me.DistrictCmb.Size = New System.Drawing.Size(104, 23)
        Me.DistrictCmb.TabIndex = 87
        '
        'MRCNoTxt
        '
        Me.MRCNoTxt.Location = New System.Drawing.Point(464, 64)
        Me.MRCNoTxt.Name = "MRCNoTxt"
        Me.MRCNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MRCNoTxt.Properties.MaxLength = 14
        Me.MRCNoTxt.Size = New System.Drawing.Size(104, 19)
        Me.MRCNoTxt.TabIndex = 86
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(400, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "MRC No :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "District :"
        '
        'ContractTxt
        '
        Me.ContractTxt.Enabled = False
        Me.ContractTxt.Location = New System.Drawing.Point(464, 16)
        Me.ContractTxt.Name = "ContractTxt"
        Me.ContractTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractTxt.Size = New System.Drawing.Size(104, 19)
        Me.ContractTxt.TabIndex = 79
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(400, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 16)
        Me.Label42.TabIndex = 78
        Me.Label42.Text = "Contract :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Previous I/O :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "* Location :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Section :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "* Officer in Charge :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "* I/O No :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PaymentClaim_DateEdit)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.WorkVerification_DateEdit)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.InspectionDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.DWCSentDateEdit)
        Me.GroupBox2.Controls.Add(Me.TOCRecvDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.InstallDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ExtCompleteDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ExtCommenceDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CompleteDateEdit)
        Me.GroupBox2.Controls.Add(Me.CommenceDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.RecDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 172)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        '
        'PaymentClaim_DateEdit
        '
        Me.PaymentClaim_DateEdit.DateTime = New Date(CType(0, Long))
        Me.PaymentClaim_DateEdit.Location = New System.Drawing.Point(464, 118)
        Me.PaymentClaim_DateEdit.Name = "PaymentClaim_DateEdit"
        Me.PaymentClaim_DateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PaymentClaim_DateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PaymentClaim_DateEdit.Size = New System.Drawing.Size(108, 23)
        Me.PaymentClaim_DateEdit.TabIndex = 162
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(320, 122)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(136, 16)
        Me.Label48.TabIndex = 161
        Me.Label48.Text = "Payment Claim Date:"
        '
        'WorkVerification_DateEdit
        '
        Me.WorkVerification_DateEdit.DateTime = New Date(CType(0, Long))
        Me.WorkVerification_DateEdit.Location = New System.Drawing.Point(144, 119)
        Me.WorkVerification_DateEdit.Name = "WorkVerification_DateEdit"
        Me.WorkVerification_DateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WorkVerification_DateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WorkVerification_DateEdit.Size = New System.Drawing.Size(130, 23)
        Me.WorkVerification_DateEdit.TabIndex = 160
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(10, 125)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(128, 16)
        Me.Label49.TabIndex = 159
        Me.Label49.Text = "Work verification Date :"
        '
        'InspectionDateEdit
        '
        Me.InspectionDateEdit.DateTime = New Date(CType(0, Long))
        Me.InspectionDateEdit.Location = New System.Drawing.Point(464, 89)
        Me.InspectionDateEdit.Name = "InspectionDateEdit"
        Me.InspectionDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InspectionDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.InspectionDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.InspectionDateEdit.TabIndex = 135
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(320, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 16)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Inspection Date:"
        '
        'DWCSentDateEdit
        '
        Me.DWCSentDateEdit.DateTime = New Date(CType(0, Long))
        Me.DWCSentDateEdit.Location = New System.Drawing.Point(144, 70)
        Me.DWCSentDateEdit.Name = "DWCSentDateEdit"
        Me.DWCSentDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DWCSentDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DWCSentDateEdit.Size = New System.Drawing.Size(130, 23)
        Me.DWCSentDateEdit.TabIndex = 133
        '
        'TOCRecvDateEdit
        '
        Me.TOCRecvDateEdit.DateTime = New Date(CType(0, Long))
        Me.TOCRecvDateEdit.Location = New System.Drawing.Point(144, 90)
        Me.TOCRecvDateEdit.Name = "TOCRecvDateEdit"
        Me.TOCRecvDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TOCRecvDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TOCRecvDateEdit.Size = New System.Drawing.Size(130, 23)
        Me.TOCRecvDateEdit.TabIndex = 132
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(18, 95)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 16)
        Me.Label29.TabIndex = 131
        Me.Label29.Text = "TOC Return Date :"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 76)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 16)
        Me.Label28.TabIndex = 130
        Me.Label28.Text = "DWC Sent Date :"
        '
        'InstallDateEdit
        '
        Me.InstallDateEdit.DateTime = New Date(CType(0, Long))
        Me.InstallDateEdit.Location = New System.Drawing.Point(464, 64)
        Me.InstallDateEdit.Name = "InstallDateEdit"
        Me.InstallDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstallDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.InstallDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.InstallDateEdit.TabIndex = 129
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(320, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Installation Date :"
        '
        'ExtCompleteDateEdit
        '
        Me.ExtCompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExtCompleteDateEdit.Location = New System.Drawing.Point(464, 44)
        Me.ExtCompleteDateEdit.Name = "ExtCompleteDateEdit"
        Me.ExtCompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtCompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExtCompleteDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.ExtCompleteDateEdit.TabIndex = 91
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 16)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Extend Completion Date :"
        '
        'ExtCommenceDateEdit
        '
        Me.ExtCommenceDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExtCommenceDateEdit.Location = New System.Drawing.Point(464, 23)
        Me.ExtCommenceDateEdit.Name = "ExtCommenceDateEdit"
        Me.ExtCommenceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtCommenceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExtCommenceDateEdit.Size = New System.Drawing.Size(108, 23)
        Me.ExtCommenceDateEdit.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 26)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Extend / Revised Commence Date :"
        '
        'CompleteDateEdit
        '
        Me.CompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.CompleteDateEdit.Location = New System.Drawing.Point(144, 50)
        Me.CompleteDateEdit.Name = "CompleteDateEdit"
        Me.CompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CompleteDateEdit.Size = New System.Drawing.Size(130, 23)
        Me.CompleteDateEdit.TabIndex = 87
        '
        'CommenceDateEdit
        '
        Me.CommenceDateEdit.DateTime = New Date(CType(0, Long))
        Me.CommenceDateEdit.Location = New System.Drawing.Point(144, 30)
        Me.CommenceDateEdit.Name = "CommenceDateEdit"
        Me.CommenceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CommenceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CommenceDateEdit.Size = New System.Drawing.Size(130, 23)
        Me.CommenceDateEdit.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "* Completion Date :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "* Commence Date :"
        '
        'RecDateEdit
        '
        Me.RecDateEdit.DateTime = New Date(CType(0, Long))
        Me.RecDateEdit.Location = New System.Drawing.Point(144, 10)
        Me.RecDateEdit.Name = "RecDateEdit"
        Me.RecDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RecDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RecDateEdit.Size = New System.Drawing.Size(130, 23)
        Me.RecDateEdit.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "* IO Receive Date :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OTChargesTxt)
        Me.GroupBox4.Controls.Add(Me.SubConInvDateEdit)
        Me.GroupBox4.Controls.Add(Me.InvoiceNoTxt)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.RemarksMemo)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.SubContInvoicetxt)
        Me.GroupBox4.Controls.Add(Me.InvoiceDateEdit)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 323)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(616, 128)
        Me.GroupBox4.TabIndex = 114
        Me.GroupBox4.TabStop = False
        '
        'OTChargesTxt
        '
        Me.OTChargesTxt.Location = New System.Drawing.Point(144, 64)
        Me.OTChargesTxt.Name = "OTChargesTxt"
        Me.OTChargesTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OTChargesTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OTChargesTxt.Size = New System.Drawing.Size(64, 19)
        Me.OTChargesTxt.TabIndex = 148
        Me.OTChargesTxt.Text = "0"
        '
        'SubConInvDateEdit
        '
        Me.SubConInvDateEdit.DateTime = New Date(CType(0, Long))
        Me.SubConInvDateEdit.Location = New System.Drawing.Point(464, 40)
        Me.SubConInvDateEdit.Name = "SubConInvDateEdit"
        Me.SubConInvDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SubConInvDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SubConInvDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.SubConInvDateEdit.TabIndex = 147
        '
        'InvoiceNoTxt
        '
        Me.InvoiceNoTxt.Location = New System.Drawing.Point(144, 16)
        Me.InvoiceNoTxt.Name = "InvoiceNoTxt"
        Me.InvoiceNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InvoiceNoTxt.Size = New System.Drawing.Size(104, 19)
        Me.InvoiceNoTxt.TabIndex = 145
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 16)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "Invoice No :"
        '
        'RemarksMemo
        '
        Me.RemarksMemo.Location = New System.Drawing.Point(144, 88)
        Me.RemarksMemo.Name = "RemarksMemo"
        Me.RemarksMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RemarksMemo.Size = New System.Drawing.Size(424, 32)
        Me.RemarksMemo.TabIndex = 128
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(16, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "Remarks :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "Over Time Charges :"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(320, 43)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 16)
        Me.Label27.TabIndex = 116
        Me.Label27.Text = "Sub-Con Invoice Date:"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 16)
        Me.Label26.TabIndex = 115
        Me.Label26.Text = "Sub-Con's Invoice No :"
        '
        'SubContInvoicetxt
        '
        Me.SubContInvoicetxt.Location = New System.Drawing.Point(144, 40)
        Me.SubContInvoicetxt.Name = "SubContInvoicetxt"
        Me.SubContInvoicetxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SubContInvoicetxt.Size = New System.Drawing.Size(104, 19)
        Me.SubContInvoicetxt.TabIndex = 114
        '
        'InvoiceDateEdit
        '
        Me.InvoiceDateEdit.DateTime = New Date(CType(0, Long))
        Me.InvoiceDateEdit.Location = New System.Drawing.Point(464, 15)
        Me.InvoiceDateEdit.Name = "InvoiceDateEdit"
        Me.InvoiceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InvoiceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.InvoiceDateEdit.Size = New System.Drawing.Size(104, 23)
        Me.InvoiceDateEdit.TabIndex = 113
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(320, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 16)
        Me.Label25.TabIndex = 112
        Me.Label25.Text = "Invoice Date :"
        '
        'BoxGrid
        '
        Me.BoxGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxGrid.EditorsRepository = Me.PersistentRepository1
        Me.BoxGrid.Enabled = False
        Me.BoxGrid.Location = New System.Drawing.Point(688, 30)
        Me.BoxGrid.MainView = Me.GridView1
        Me.BoxGrid.Name = "BoxGrid"
        Me.BoxGrid.Size = New System.Drawing.Size(286, 559)
        Me.BoxGrid.TabIndex = 86
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Edit, Me.Delete})
        '
        'Edit
        '
        Me.Edit.Index = 0
        Me.Edit.Text = "Edit"
        '
        'Delete
        '
        Me.Delete.Index = 1
        Me.Delete.Text = "Delete"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(686, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 16)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "* Note: Double click on the grid below to enter Box information"
        '
        'AddNext_CheckBox
        '
        Me.AddNext_CheckBox.Location = New System.Drawing.Point(215, 19)
        Me.AddNext_CheckBox.Name = "AddNext_CheckBox"
        Me.AddNext_CheckBox.Size = New System.Drawing.Size(194, 24)
        Me.AddNext_CheckBox.TabIndex = 120
        Me.AddNext_CheckBox.Text = "Continue create after saving"
        Me.AddNext_CheckBox.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.AddNext_CheckBox)
        Me.Panel3.Controls.Add(Me.SaveXtraButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 648)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(990, 59)
        Me.Panel3.TabIndex = 123
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
        'SaveXtraButton
        '
        Me.SaveXtraButton.Location = New System.Drawing.Point(12, 12)
        Me.SaveXtraButton.Name = "SaveXtraButton"
        Me.SaveXtraButton.Size = New System.Drawing.Size(72, 37)
        Me.SaveXtraButton.TabIndex = 0
        Me.SaveXtraButton.Text = "Save"
        Me.SaveXtraButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 461)
        Me.Panel1.TabIndex = 124
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
        Me.Panel2.Size = New System.Drawing.Size(990, 48)
        Me.Panel2.TabIndex = 125
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
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(187, 15)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 18)
        Me.Label44.TabIndex = 79
        Me.Label44.Text = "IO :"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.BoxGrid)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(986, 596)
        Me.Panel4.TabIndex = 127
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.MinimumSize = New System.Drawing.Size(648, 532)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(680, 596)
        Me.Panel5.TabIndex = 128
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 48)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(990, 600)
        Me.Panel6.TabIndex = 129
        '
        'LVBFilerForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(990, 707)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "LVBFilerForm"
        Me.Text = "LVB Filer"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Substation_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IONumberTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParentIOcmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRCNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PaymentClaim_DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkVerification_DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InspectionDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DWCSentDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOCRecvDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtCompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtCommenceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommenceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.OTChargesTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubConInvDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubContInvoicetxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.IO_LookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractNo_LookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public data As System.Data.DataTable
    Public Contract_No As String
    Dim Navds As DataSet
    Dim ParentIO_Selected As Boolean

#Region " Form Load "
    Private Sub LVBFilerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OnLoading = True

        ParentIO_Selected = False
        LoadOfficerCmb()
        LoadParentIOCmb()
        Me.LoadContractNo_LookUpEdit()
        'LoadSectionCmb()

        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            Dim ds As DataSet
            If .GetLVBContract(ds, Contract_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Contract_No = ds.Tables(0).Rows(0)("Contract_No")
                    ContractTxt.Text = Contract_No
                End If
            End If
        End With

        Select Case (Status)
            Case "ADD"
                '## Edited by Andrew
                'InitializeForm()
                '## End

                If AddNext_CheckBox.Checked = True Then
                    Me.InitForm()
                    Status = "ADD"
                End If

                BoxGrid.Enabled = False
            Case "EDIT"
                ParentIOcmb.Enabled = False

                With New BusinessRules.LVBBusRules.LVBBusLogic
                    If .GetIO(Navds, IO_Id) Then
                        SetWindowValue(Navds)
                    End If
                End With
                Navds.Dispose()

                BoxGrid.Enabled = True
                RefreshBoxGrid()
        End Select

        OnLoading = False

    End Sub

    Private Sub InitForm()

        'OnLoading = True
        'IO_Id = 0
        ParentIOcmb.Properties.LookUpData.KeyValue = Nothing
        OnLoading = True
        OfficerCmb.Properties.LookUpData.KeyValue = Nothing
        DistrictCmb.Properties.LookUpData.KeyValue = Nothing

        IONumberTxt.Text = ""
        ParentIOcmb.Text = ""
        ContractTxt.Text = Contract_No
        OfficerCmb.Text = ""
        Substation_txt.Text = ""
        LocMemo.Text = ""
        MRCNoTxt.Text = ""
        DistrictCmb.Text = ""
        RecDateEdit.DateTime = New Date(CType(0, Long))
        CommenceDateEdit.DateTime = New Date(CType(0, Long))
        CompleteDateEdit.DateTime = New Date(CType(0, Long))
        DWCSentDateEdit.DateTime = New Date(CType(0, Long))
        ExtCommenceDateEdit.DateTime = New Date(CType(0, Long))
        ExtCompleteDateEdit.DateTime = New Date(CType(0, Long))
        InstallDateEdit.DateTime = New Date(CType(0, Long))
        WorkVerification_DateEdit.DateTime = New Date(CType(0, Long))
        PaymentClaim_DateEdit.DateTime = New Date(CType(0, Long))
        TOCRecvDateEdit.DateTime = New Date(CType(0, Long))
        InspectionDateEdit.DateTime = New Date(CType(0, Long))
        InvoiceDateEdit.DateTime = New Date(CType(0, Long))
        SubConInvDateEdit.DateTime = New Date(CType(0, Long))
        InvoiceNoTxt.Text = ""
        SubContInvoicetxt.Text = ""
        OTChargesTxt.Text = 0
        RemarksMemo.Text = ""

        'RefreshBoxGrid()
        InitGrid()
        BoxGrid.DataSource = data
        BoxGrid.DefaultView.PopulateColumns()

        'OnLoading = False

    End Sub

    '## Edited by Andrew
    'Private Sub InitializeForm()
    '    Dim ds As DataSet
    '    With New BusinessRules.LVBBusRules.LVBBusLogic
    '        .UserID = UserID
    '        .Contract_Id = Contract_Id
    '        If .SaveIOForFirstTime() Then
    '            IO_Id = .IO_Id        'Store IO ID
    '        Else
    '            MessageBox.Show("Error creating LVB", "LVB", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End With
    'End Sub
    '## End
#End Region

#Region " Set Window Value "
    Private Sub SetWindowValue(ByVal ds As DataSet, Optional ByVal pSetType As String = "")


        OnLoading = True

        If pSetType <> "RE" Then
            InitForm()
            Me.IONumberTxt.Text = ds.Tables(0).Rows(0)("IO_No")
        End If

        If Not IsDBNull(ds.Tables(0).Rows(0)("Parent_IO_Id")) Then
            If ds.Tables(0).Rows(0)("Parent_IO_Id") > 0 Then
                Me.ParentIOcmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Parent_IO_Id")
                OnLoading = True
            End If
        End If

        Me.OfficerCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Officer_In_Charge_Id")
        If Not IsDBNull(ds.Tables(0).Rows(0)("Officer_In_Charge_Id")) Then
            Me.OfficerCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Officer_In_Charge_Id")
            Officer_In_Charge_Id = ds.Tables(0).Rows(0)("Officer_In_Charge_Id")
            With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
                Dim dsOfficer As DataSet
                If .GetOfficerInCharge(dsOfficer, Officer_In_Charge_Id) Then
                    If dsOfficer.Tables(0).Rows.Count > 0 Then

                        If Not IsDBNull(dsOfficer.Tables(0).Rows(0)("Section_ID")) Then
                            LVB_Section = dsOfficer.Tables(0).Rows(0)("Section_ID")
                            With New BusinessRules.SystemBusRules.SectionBusLogic
                                Dim dsSection As DataSet
                                If .GetSection(dsSection, LVB_Section) Then
                                    If dsSection.Tables(0).Rows.Count > 0 Then
                                        If Not IsDBNull(dsSection.Tables(0).Rows(0)("Section_Code")) Then
                                            SectionTxt.Text = dsSection.Tables(0).Rows(0)("Section_Code")
                                        End If
                                    End If
                                End If
                                dsSection.Dispose()
                            End With
                        End If

                        'If Not IsDBNull(dsOfficer.Tables(0).Rows(0)("Contact_Location")) Then
                        'Me.LocMemo.Text = dsOfficer.Tables(0).Rows(0)("Contact_Location")
                        'End If
                    End If
                End If
                dsOfficer.Dispose()
            End With
        End If

        'If Not IsDBNull(ds.Tables(0).Rows(0)("LVB_Section")) Then
        'Me.SectionCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("LVB_Section")
        'End If

        If Not IsDBNull(ds.Tables(0).Rows(0)("LVB_Location")) Then
            Me.LocMemo.Text = ds.Tables(0).Rows(0)("LVB_Location")
        End If
        If Not IsDBNull(ds.Tables(0).Rows(0)("LVB_Substation")) Then
            Me.Substation_txt.Text = ds.Tables(0).Rows(0)("LVB_Substation")
        End If
        If Not IsDBNull(ds.Tables(0).Rows(0)("MRC_No")) Then
            Me.MRCNoTxt.Text = ds.Tables(0).Rows(0)("MRC_No")
        End If

        If Not IsDBNull(ds.Tables(0).Rows(0)("District")) Then
            Me.DistrictCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("District")
        End If

        If pSetType <> "RE" Then

            If Not IsDBNull(ds.Tables(0).Rows(0)("IO_Recv_Date")) Then
                Me.RecDateEdit.DateTime = ds.Tables(0).Rows(0)("IO_Recv_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Commence_Date")) Then
                Me.CommenceDateEdit.DateTime = ds.Tables(0).Rows(0)("Commence_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Completion_Date")) Then
                Me.CompleteDateEdit.DateTime = ds.Tables(0).Rows(0)("Completion_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Extend_Commence_Date")) Then
                Me.ExtCommenceDateEdit.DateTime = ds.Tables(0).Rows(0)("Extend_Commence_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Extend_Completion_Date")) Then
                Me.ExtCompleteDateEdit.DateTime = ds.Tables(0).Rows(0)("Extend_Completion_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Installation_Date")) Then
                Me.InstallDateEdit.DateTime = ds.Tables(0).Rows(0)("Installation_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("WorkVerification_Date")) Then
                Me.WorkVerification_DateEdit.DateTime = ds.Tables(0).Rows(0)("WorkVerification_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("PaymentClaim_Date")) Then
                Me.PaymentClaim_DateEdit.DateTime = ds.Tables(0).Rows(0)("PaymentClaim_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("DWC_Sent_Date")) Then
                Me.DWCSentDateEdit.DateTime = ds.Tables(0).Rows(0)("DWC_Sent_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("TOC_Return_Date")) Then
                Me.TOCRecvDateEdit.DateTime = ds.Tables(0).Rows(0)("TOC_Return_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Inspection_Date")) Then
                Me.InspectionDateEdit.DateTime = ds.Tables(0).Rows(0)("Inspection_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Invoice_No")) Then
                Me.InvoiceNoTxt.Text = ds.Tables(0).Rows(0)("Invoice_No")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Invoice_Date")) Then
                Me.InvoiceDateEdit.DateTime = ds.Tables(0).Rows(0)("Invoice_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Subcont_Invoice_No")) Then
                Me.SubContInvoicetxt.Text = ds.Tables(0).Rows(0)("Subcont_Invoice_No")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("Subcont_Invoice_Date")) Then
                Me.SubConInvDateEdit.DateTime = ds.Tables(0).Rows(0)("Subcont_Invoice_Date")
            End If

            If Not IsDBNull(ds.Tables(0).Rows(0)("OverTime_Charge")) Then
                Me.OTChargesTxt.Text = ds.Tables(0).Rows(0)("OverTime_Charge")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0)("Remarks")) Then
                Me.RemarksMemo.Text = ds.Tables(0).Rows(0)("Remarks")
            End If
        End If

        OnLoading = False

    End Sub
#End Region

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

    Private Sub LoadParentIOCmb()
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBBusLogic
            If .GetParentIO(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ParentIOcmb, "IO_No", 400, 0, "c")
                        ParentIOcmb.Properties.LookUpData.KeyField = "IO_Id"
                        ParentIOcmb.Properties.LookUpData.DisplayField = "IO_No"

                        ParentIOcmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ParentIOcmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
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
        With New BusinessRules.LVBBusRules.LVBBusLogic
            If .GetParentIOByContract(ds, Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue.ToString) Then
                If Not ds Is Nothing Then
                    Try
                        ''SimpleBinding LookUp adjustment start

                        AddListFieldInfoToLookUp(IO_LookUpEdit, "IO_No", 400, 0, "c")
                        IO_LookUpEdit.Properties.LookUpData.KeyField = "IO_Id"
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

    Private Sub LoadContractNo_LookUpEdit()
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            If .GetLVBContract(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(ContractNo_LookUpEdit, "Contract_No", 400, 0, "c")
                    ContractNo_LookUpEdit.Properties.LookUpData.KeyField = "Contract_Id"
                    ContractNo_LookUpEdit.Properties.LookUpData.DisplayField = "Contract_No"
                    ContractNo_LookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    ContractNo_LookUpEdit.EditValue = "0"
                    ContractNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Contract_Id, 0, 0, 0})
                End If
            End If
        End With
    End Sub


    'Private Sub LoadSectionCmb()
    '   Dim ds As DataSet
    '  With New BusinessRules.SystemBusRules.SectionBusLogic
    'If .GetSection(ds) Then
    'If Not ds Is Nothing Then
    '  Try
    '       'SimpleBinding LookUp adjustment start
    '        AddListFieldInfoToLookUp(SectionCmb, "Section_Code", 400, 0, "c")
    '         SectionCmb.Properties.LookUpData.KeyField = "Section_Id"
    '          SectionCmb.Properties.LookUpData.DisplayField = "Section_Code"

    '           SectionCmb.Properties.LookUpData.DataSource = ds.Tables(0)
    '            SectionCmb.EditValue = "0"
    '             'SimpleBinding LookUp adjustment end
    '          Catch exLoad As System.Exception
    '               System.Windows.Forms.MessageBox.Show(exLoad.Message)
    '            End Try
    '         End If
    '      End If
    '   End With
    'End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

#Region " Buttons "
    Private Sub DeleteBox(ByVal pLVB_Line_Id As Integer)
        With New BusinessRules.LVBBusRules.LVBLineBusLogic
            .LVB_Line_Id = pLVB_Line_Id
            If .DeleteLVBLine Then
                RefreshBoxGrid()
                MessageBox.Show("Box Deleted.", "LVB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveXtraButton.Click
        RetrieveFromForm()
        If ValidData() Then
            Select Case UCase(Status)
                Case "ADD"
                    'YG 21.09.2003 Check no duplicated IO Number
                    '                    If Not Len(IO_No) > 0 Then
                    '                        With New BusinessRules.LVBBusRules.LVBBusLogic

                    '                        End With
                    '                   Else
                    If SaveData() = True Then
                        Edited = False
                        BoxGrid.Enabled = True
                        ' 24.10..23003 YG Added
                        RefreshBoxGrid()

                        'ReLoad IO_LookUpEdit
                        LoadIO_LookUpEdit()

                        If AddNext_CheckBox.Checked = True Then
                            OnLoading = True
                            Me.InitForm()
                            OnLoading = False
                            Status = "ADD"
                        Else

                            If IO_Id <> 0 Then
                                Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {IO_Id, 0, 0, 0})
                            End If
                            LoadIO()
                            Status = "EDIT"

                        End If

                    End If
                    '                    End If
                Case "EDIT"
                    UpdateData()
                    Edited = False
            End Select
        End If
    End Sub

    Private Function SaveData() As Boolean
        With New BusinessRules.LVBBusRules.LVBBusLogic
            Me.SaveXtraButton.Focus()
            If .IONoExist(IO_No, Contract_Id) Then
                .Contract_Id = Contract_Id
                .IO_No = IO_No
                .Parent_IO_Id = Parent_IO_Id
                .Officer_In_Charge_Id = Officer_In_Charge_Id
                '.LVB_Section = LVB_Section
                .LVB_Location = LVB_Location
                .LVB_Substation = LVB_Substation
                .MRC_No = MRC_No
                .District = District
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
                    .Installation_Date = Installation_Date
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

                If Len(Inspection_Date) > 0 Then
                    .Inspection_Date = Microsoft.VisualBasic.DateAndTime.Day(Inspection_Date) & "/" & MonthName(Month(Inspection_Date)) & "/" & Year(Inspection_Date)
                Else
                    .Inspection_Date = Inspection_Date
                End If

                .Invoice_No = Invoice_No

                If Len(Invoice_Date) > 0 Then
                    .Invoice_Date = Microsoft.VisualBasic.DateAndTime.Day(Invoice_Date) & "/" & MonthName(Month(Invoice_Date)) & "/" & Year(Invoice_Date)
                Else
                    .Invoice_Date = Invoice_Date
                End If
                .Subcont_Invoice_No = Subcont_Invoice_No

                If Len(Subcont_Invoice_Date) > 0 Then
                    .Subcont_Invoice_Date = Microsoft.VisualBasic.DateAndTime.Day(Subcont_Invoice_Date) & "/" & MonthName(Month(Subcont_Invoice_Date)) & "/" & Year(Subcont_Invoice_Date)
                Else
                    .Subcont_Invoice_Date = Subcont_Invoice_Date
                End If
                .OverTime_Charge = OverTime_Charge
                .Remarks = Remarks
                .UserID = UserID
                '.IO_Id = IO_Id
                If .SaveIO(IO_Id) Then
                    Dim LVBLineds As DataSet

                    With New BusinessRules.LVBBusRules.LVBLineBusLogic
                        If .GetLVBLineOnIO(LVBLineds, Me.ParentIOcmb.Properties.LookUpData.KeyValue) Then
                            Dim x As Integer
                            For x = 0 To LVBLineds.Tables(0).Rows.Count - 1
                                With New BusinessRules.LVBBusRules.LVBLineBusLogic
                                    .IO_Id = IO_Id
                                    .Box_Type_Id = LVBLineds.Tables(0).Rows(x)("Box_Type_Id")
                                    '.Serial_No = LVBLineds.Tables(0).Rows(x)("Serial_No")
                                    If Not IsDBNull(LVBLineds.Tables(0).Rows(x)("Install")) Then
                                        .Install = LVBLineds.Tables(0).Rows(x)("Install")
                                    Else
                                        .Install = 0
                                    End If

                                    If Not IsDBNull(LVBLineds.Tables(0).Rows(x)("Serial_No")) Then
                                        .Serial_No = LVBLineds.Tables(0).Rows(x)("Serial_No")
                                    Else
                                        .Serial_No = ""
                                    End If

                                    If Not IsDBNull(LVBLineds.Tables(0).Rows(x)("Offshore")) Then
                                        .Offshore = LVBLineds.Tables(0).Rows(x)("Offshore")
                                    Else
                                        .Offshore = 0
                                    End If

                                    '.Offshore = LVBLineds.Tables(0).Rows(x)("Offshore")
                                    .LTB_Label = LVBLineds.Tables(0).Rows(x)("LTB_Label")
                                    .Strip_Label = LVBLineds.Tables(0).Rows(x)("Strip_Label")
                                    .Bus_Section = LVBLineds.Tables(0).Rows(x)("Bus_Section")
                                    .OT = LVBLineds.Tables(0).Rows(x)("OT")
                                    .OutLink100 = LVBLineds.Tables(0).Rows(x)("OutLink100")
                                    .OutLink500 = LVBLineds.Tables(0).Rows(x)("OutLink500")
                                    .SupInsOutLink1000 = LVBLineds.Tables(0).Rows(x)("SupInsOutLink1000")
                                    .SynConn() = LVBLineds.Tables(0).Rows(x)("SynConn")
                                    '.Schedule_Deliver = LVBLineds.Tables(0).Rows(x)("Schedule_Deliver")
                                    '.Delivery_Date = LVBLineds.Tables(0).Rows(x)("Delivery_Date")
                                    '.OutLink_Ref_Date = LVBLineds.Tables(0).Rows(x)("OutLink_Ref_Date")
                                    If Not IsDBNull(LVBLineds.Tables(0).Rows(x)("Schedule_Deliver")) Then
                                        .Schedule_Deliver = Microsoft.VisualBasic.DateAndTime.Day(LVBLineds.Tables(0).Rows(x)("Schedule_Deliver")) & "/" & MonthName(Month(LVBLineds.Tables(0).Rows(x)("Schedule_Deliver"))) & "/" & Year(LVBLineds.Tables(0).Rows(x)("Schedule_Deliver"))
                                    End If
                                    If Not IsDBNull(LVBLineds.Tables(0).Rows(x)("Delivery_Date")) Then
                                        .Delivery_Date = Microsoft.VisualBasic.DateAndTime.Day(LVBLineds.Tables(0).Rows(x)("Delivery_Date")) & "/" & MonthName(Month(LVBLineds.Tables(0).Rows(x)("Delivery_Date"))) & "/" & Year(LVBLineds.Tables(0).Rows(x)("Delivery_Date"))
                                    End If
                                    If Not IsDBNull(LVBLineds.Tables(0).Rows(x)("OutLink_Ref_Date")) Then
                                        .OutLink_Ref_Date = Microsoft.VisualBasic.DateAndTime.Day(LVBLineds.Tables(0).Rows(x)("OutLink_Ref_Date")) & "/" & MonthName(Month(LVBLineds.Tables(0).Rows(x)("OutLink_Ref_Date"))) & "/" & Year(LVBLineds.Tables(0).Rows(x)("OutLink_Ref_Date"))
                                    End If
                                    .UserID = UserID
                                    .SaveLVBLine()
                                End With
                            Next
                        End If
                    End With
                    SaveData = True
                    Status = "EDIT"
                    MessageBox.Show("I/O saved. ", "LVB Filer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("This I/O No Exists. ", "LVB Filer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SaveData = False
            End If
        End With
    End Function

    Private Sub UpdateData()
        With New BusinessRules.LVBBusRules.LVBBusLogic
            .IO_No = IO_No
            .Parent_IO_Id = Parent_IO_Id
            .Officer_In_Charge_Id = Officer_In_Charge_Id
            '.LVB_Section = LVB_Section
            .LVB_Location = LVB_Location
            .LVB_Substation = LVB_Substation
            .MRC_No = MRC_No
            .District = District
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
                .Installation_Date = Installation_Date
            End If

            If Len(WorkVerification_Date) > 0 Then
                .WorkVerification_Date = Microsoft.VisualBasic.DateAndTime.Day(WorkVerification_Date) & "/" & MonthName(Month(WorkVerification_Date)) & "/" & Year(WorkVerification_Date)
            Else
                .WorkVerification_Date = WorkVerification_Date
            End If

            If Len(PaymentClaim_Date) > 0 Then
                .PaymentClaim_Date = Microsoft.VisualBasic.DateAndTime.Day(PaymentClaim_Date) & "/" & MonthName(Month(PaymentClaim_Date)) & "/" & Year(PaymentClaim_Date)
            Else
                .PaymentClaim_Date = PaymentClaim_Date
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

            If Len(Inspection_Date) > 0 Then
                .Inspection_Date = Microsoft.VisualBasic.DateAndTime.Day(Inspection_Date) & "/" & MonthName(Month(Inspection_Date)) & "/" & Year(Inspection_Date)
            Else
                .Inspection_Date = Inspection_Date
            End If

            .Invoice_No = Invoice_No

            If Len(Invoice_Date) > 0 Then
                .Invoice_Date = Microsoft.VisualBasic.DateAndTime.Day(Invoice_Date) & "/" & MonthName(Month(Invoice_Date)) & "/" & Year(Invoice_Date)
            Else
                .Invoice_Date = Invoice_Date
            End If
            .Subcont_Invoice_No = Subcont_Invoice_No

            If Len(Subcont_Invoice_Date) > 0 Then
                .Subcont_Invoice_Date = Microsoft.VisualBasic.DateAndTime.Day(Subcont_Invoice_Date) & "/" & MonthName(Month(Subcont_Invoice_Date)) & "/" & Year(Subcont_Invoice_Date)
            Else
                .Subcont_Invoice_Date = Subcont_Invoice_Date
            End If
            .OverTime_Charge = OverTime_Charge
            .Remarks = Remarks
            .UserID = UserID
            .IO_Id = IO_Id
            If .UpdateLVBIO() Then
                MessageBox.Show("I/O Updated. ", "LVB Filer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub
#End Region

#Region " Retrieve Data n ValidData "
    Private Sub RetrieveFromForm()
        Me.SaveXtraButton.Focus()
        IO_No = Me.IONumberTxt.Text
        Parent_IO_Id = Me.ParentIOcmb.Properties.LookUpData.KeyValue
        If Not IsDBNull(Me.OfficerCmb.Properties.LookUpData.KeyValue) Then
            Officer_In_Charge_Id = Me.OfficerCmb.Properties.LookUpData.KeyValue
        End If
        'LVB_Section = Me.SectionCmb.Properties.LookUpData.KeyValue
        LVB_Location = Me.LocMemo.Text
        LVB_Substation = Me.Substation_txt.Text
        MRC_No = Me.MRCNoTxt.Text
        District = Me.DistrictCmb.Properties.LookUpData.KeyValue
        IO_Recv_Date = Me.RecDateEdit.Text
        Commence_Date = Me.CommenceDateEdit.Text
        Completion_Date = Me.CompleteDateEdit.Text
        Extend_Commence_Date = Me.ExtCommenceDateEdit.Text
        Extend_Completion_Date = Me.ExtCompleteDateEdit.Text
        Installation_Date = Me.InstallDateEdit.Text
        WorkVerification_Date = Me.WorkVerification_DateEdit.Text
        PaymentClaim_Date = Me.PaymentClaim_DateEdit.Text
        DWC_Sent_Date = Me.DWCSentDateEdit.Text
        TOC_Return_Date = Me.TOCRecvDateEdit.Text
        Inspection_Date = Me.InspectionDateEdit.Text
        Invoice_No = Me.InvoiceNoTxt.Text
        Invoice_Date = Me.InvoiceDateEdit.Text
        Subcont_Invoice_No = Me.SubContInvoicetxt.Text
        Subcont_Invoice_Date = Me.SubConInvDateEdit.Text
        OverTime_Charge = Me.OTChargesTxt.Text
        Remarks = Me.RemarksMemo.Text
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

        If Not Len(LVB_Location) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Location" & Chr(13)
        End If
        If Not Len(LVB_Substation) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Substation" & Chr(13)
        End If
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

#Region " Grid "
    Public Sub RefreshBoxGrid(Optional ByVal pParentIO As String = "")
        Dim ds As DataSet
        Dim tmpIO As String

        If Len(pParentIO) > 0 Then
            tmpIO = pParentIO
        Else
            tmpIO = IO_Id
        End If

        With New BusinessRules.LVBBusRules.LVBLineBusLogic
            If .GetLVBLineOnIO(ds, tmpIO) Then
                InitGrid()
                Dim oRow As DataRow

                For Each oRow In ds.Tables(0).Rows
                    Dim Box_Name = GetBoxName(oRow("Box_Type_Id"))
                    Dim a, b, c

                    If IsDBNull(oRow("Schedule_Deliver")) Then
                        a = ""
                    Else
                        a = Microsoft.VisualBasic.DateAndTime.Day(oRow("Schedule_Deliver")) & "/" & MonthName(Month(oRow("Schedule_Deliver"))) & "/" & Year(oRow("Schedule_Deliver"))
                    End If

                    If IsDBNull(oRow("Delivery_Date")) Then
                        b = ""
                    Else
                        b = Microsoft.VisualBasic.DateAndTime.Day(oRow("Delivery_Date")) & "/" & MonthName(Month(oRow("Delivery_Date"))) & "/" & Year(oRow("Delivery_Date"))
                    End If

                    If IsDBNull(oRow("OutLink_Ref_Date")) Then
                        c = ""
                    Else
                        c = Microsoft.VisualBasic.DateAndTime.Day(oRow("OutLink_Ref_Date")) & "/" & MonthName(Month(oRow("OutLink_Ref_Date"))) & "/" & Year(oRow("OutLink_Ref_Date"))
                    End If
                    data.Rows.Add(New Object() {oRow("LVB_Line_Id"), oRow("Serial_No"), Box_Name, oRow("Install"), oRow("Offshore"), oRow("LTB_Label"), oRow("Strip_Label"), oRow("Bus_Section"), oRow("OT"), oRow("OutLink500"), oRow("OutLink100"), oRow("SupInsOutLink1000"), oRow("SynConn"), oRow("CableLug1Hole"), oRow("CableLug2Hole"), a, b, c})
                Next

                BoxGrid.DataSource = data
                BoxGrid.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column
                GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "S/N", System.Type.GetType("System.String"), True)
        AddColumn(data, "Type", System.Type.GetType("System.String"), True)
        AddColumn(data, "Install", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Off/s", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "LTB Lbl", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Strip Lbl", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Bus Sect", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "O.T.", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "O/L 500", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "O/L 1000", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "SUP & INS", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Sync. Conn.", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Cable Lug 1-Hole", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Cable Lug 2-Holes", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Sched Del", System.Type.GetType("System.String"), True)
        AddColumn(data, "Del Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "O/L Ref Date", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Function GetBoxName(ByVal pBox_Type_Id) As String
        With New BusinessRules.SystemBusRules.LVBBoxBusLogic
            Dim ds As DataSet
            If .GetLVBBox(ds, pBox_Type_Id) Then
                If Not ds.Tables(0).Rows.Count = 0 Then
                    GetBoxName = ds.Tables(0).Rows(0)("Box_Name")
                End If
            End If
            ds.Dispose()
        End With
    End Function

    Private Sub BoxGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BoxGrid.DoubleClick
        Dim NewForm As New SelectBoxForm
        NewForm.IO_Id = IO_Id
        NewForm.Status = "ADD"
        NewForm.ShowDialog(Me)
        RefreshBoxGrid()
    End Sub

    Private Sub BoxGrid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BoxGrid.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        Dim eventString As String = Nothing
        Select Case e.Button
            Case MouseButtons.Left
                eventString = "L"
            Case MouseButtons.Right
                eventString = "R"
                ComponentContextMenu.Show(sender, mouseDownLocation)
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim LVB_Line_Id As Integer = dr(0)
            Dim NewForm As New SelectBoxForm
            NewForm.LVB_Line_Id = LVB_Line_Id
            NewForm.Status = "EDIT"
            NewForm.ShowDialog(Me)
            RefreshBoxGrid()
        End If

    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            'If dr.Table.Rows.Count > 0 Then
            Dim LVB_Line_Id As Integer = dr(0)
            Dim Box_Name As String = dr(2)

            Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Box_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                DeleteBox(LVB_Line_Id)
            End If
        End If

    End Sub
#End Region

    Private Sub OfficerCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles OfficerCmb.CloseUp
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
            Dim ds As DataSet
            Officer_In_Charge_Id = Me.OfficerCmb.Properties.LookUpData.KeyValue
            If .GetOfficerInCharge(ds, Officer_In_Charge_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SectionTxt.Text = ""
                    'LocMemo.Text = ""
                    If Not IsDBNull(ds.Tables(0).Rows(0)("Section_ID")) Then
                        LVB_Section = ds.Tables(0).Rows(0)("Section_ID")
                        With New BusinessRules.SystemBusRules.SectionBusLogic
                            Dim dsSection As DataSet
                            If .GetSection(dsSection, LVB_Section) Then

                                If dsSection.Tables(0).Rows.Count > 0 Then
                                    If Not IsDBNull(dsSection.Tables(0).Rows(0)("Section_Code")) Then
                                        SectionTxt.Text = dsSection.Tables(0).Rows(0)("Section_Code")
                                    End If
                                End If
                            End If
                            dsSection.Dispose()
                        End With
                    End If
                    'If Not IsDBNull(ds.Tables(0).Rows(0)("Contact_Location")) Then
                    'LocMemo.Text = ds.Tables(0).Rows(0)("Contact_Location")
                    'End If
                End If
            End If
        End With
    End Sub

    Private Sub ParentIOcmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles ParentIOcmb.CloseUp
        Dim tmpParentIO As String

        tmpParentIO = Me.ParentIOcmb.Properties.LookUpData.KeyValue
        With New BusinessRules.LVBBusRules.LVBBusLogic
            If .GetIO(Navds, tmpParentIO) Then
                SetWindowValue(Navds, "RE")
                ParentIO_Selected = True
            End If
        End With
        Navds.Dispose()
        'RefreshBoxGrid(tmpParentIO)
    End Sub
    Private Sub Panel6_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.SizeChanged

    End Sub

    Private Sub IONumberTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IONumberTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub ParentIOcmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParentIOcmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub OfficerCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficerCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub Substation_txt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Substation_txt.ValueChanged
        OnEdit()
    End Sub

    Private Sub LocMemo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocMemo.ValueChanged
        OnEdit()
    End Sub

    Private Sub MRCNoTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRCNoTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub DistrictCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictCmb.ValueChanged
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

    Private Sub DWCSentDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DWCSentDateEdit.ValueChanged
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

    Private Sub TOCRecvDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOCRecvDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub InvoiceNoTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNoTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub SubContInvoicetxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubContInvoicetxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub OTChargesTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OTChargesTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub RemarksMemo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksMemo.ValueChanged
        OnEdit()
    End Sub

    Private Sub InvoiceDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub SubConInvDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubConInvDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub OnEdit()
        If OnLoading = False Then
            Edited = True
        End If
    End Sub

    Private Sub LVBFilerForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

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
        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            Dim ds As DataSet
            If .GetLVBContract(ds, Contract_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Contract_No = ds.Tables(0).Rows(0)("Contract_No")
                    ContractTxt.Text = Contract_No
                End If
            End If
        End With

        Edited = False
        Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = Nothing
        OnLoading = True
        Me.InitForm()
        OnLoading = False

        Status = "ADD"
        BoxGrid.Enabled = False

        IONumberTxt.Focus()

        SaveXtraButton.Enabled = True

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

        If IO_Id = Me.IO_LookUpEdit.Properties.LookUpData.KeyValue Then
            Exit Sub
        End If

        If Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = Nothing Then
            Exit Sub
        End If

        If Edited = True Then

            Result = MessageBox.Show("You have made changes or have edited data without saving, Are you sure you want to exit and load the selected IO? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                'e.Cancel = True
                If IO_Id = 0 And Status = "ADD" Then
                    Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = Nothing
                End If
                Me.IO_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {IO_Id, 0, 0, 0})
                Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Contract_Id, 0, 0, 0})
                Exit Sub
            End If

        End If

        IO_Id = Me.IO_LookUpEdit.Properties.LookUpData.KeyValue

        OnLoading = True

        Contract_Id = Me.ContractNo_LookUpEdit.Properties.LookUpData.KeyValue
        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            Dim ds As DataSet
            If .GetLVBContract(ds, Contract_Id) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Contract_No = ds.Tables(0).Rows(0)("Contract_No")
                    ContractTxt.Text = Contract_No
                End If
            End If
        End With

        Edited = False

        Status = "EDIT"

        BoxGrid.Enabled = True

        ParentIOcmb.Enabled = True
        With New BusinessRules.LVBBusRules.LVBBusLogic
            If .GetIO(Navds, IO_Id) Then
                SetWindowValue(Navds)
            End If
        End With

        RefreshBoxGrid()

        SaveXtraButton.Enabled = True

        OnLoading = False
    End Sub

    Private Sub InspectionDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspectionDateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub BoxGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxGrid.Click

    End Sub
End Class
