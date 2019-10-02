Public Class ManageSupplierForm
    Inherits System.Windows.Forms.Form

#Region "Supplier Form Variables Initialization"
    Public Supplier_ID As Integer
    Public FormStatus As String
    Public Supplier_Name As String
    Public Account_No As String
    Public Address As String
    Public Country As String
    Public Postal As String
    Public Tel1 As String
    Public Tel2 As String
    Public Fax As String
    Public Contact_Person As String
    Public GST As String
    Public GST_Flg As Integer
	Public Remark As String
    Public Payment_Term As String
    Public Approved As Integer
    Public Supplier_Type As String 'was Integer
    Public Payment_Mode As String'was Integer
	'Public Remark As String
    Public Currency_ID As Integer
    Private UserID As Integer = Common.CommonConn.Config.USERID
    Private varApprove_Flg

#End Region

    ' 10.01.2004 YG Start
    Dim FunctionName As String = "SupplierProfile"
    ' 10.01.2004 YG End

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pSupplier_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus
        If Not pSupplier_ID = 0 Then
            Supplier_ID = pSupplier_ID
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SupplierRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SubConRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SupplierSubRadio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CreditRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CashRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SupplyInitTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SupplierIDTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierAddMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SupplierTel2Txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierTel1Txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierPostalTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierCountryTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierFaxTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierContactTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierProdMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GSTNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PaymentTermTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CurrencyCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GSTChk As System.Windows.Forms.CheckBox
    Friend WithEvents ApproveSupplierChk As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.SupplierRadio = New System.Windows.Forms.RadioButton
        Me.SubConRadio = New System.Windows.Forms.RadioButton
        Me.SupplierSubRadio = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CashRadio = New System.Windows.Forms.RadioButton
        Me.CreditRadio = New System.Windows.Forms.RadioButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ApproveSupplierChk = New System.Windows.Forms.CheckBox
        Me.GSTChk = New System.Windows.Forms.CheckBox
        Me.CurrencyCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.PaymentTermTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.SupplierTel2Txt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierTel1Txt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierPostalTxt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierCountryTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SupplierAddMemo = New DevExpress.XtraEditors.MemoEdit
        Me.SupplierNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierIDTxt = New DevExpress.XtraEditors.TextEdit
        Me.SupplyInitTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.SupplierFaxTxt = New DevExpress.XtraEditors.TextEdit
        Me.GSTNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierContactTxt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierProdMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CurrencyCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentTermTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTel2Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTel1Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierPostalTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierCountryTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierAddMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIDTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyInitTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierFaxTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSTNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierContactTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierProdMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(240, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Approved Supplier :"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "* Contact Person :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(240, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "GST :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 304)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 32)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "* Products / Services offered :"
        '
        'SupplierRadio
        '
        Me.SupplierRadio.Location = New System.Drawing.Point(8, 16)
        Me.SupplierRadio.Name = "SupplierRadio"
        Me.SupplierRadio.TabIndex = 94
        Me.SupplierRadio.Text = "Supplier"
        '
        'SubConRadio
        '
        Me.SubConRadio.Location = New System.Drawing.Point(8, 40)
        Me.SubConRadio.Name = "SubConRadio"
        Me.SubConRadio.TabIndex = 95
        Me.SubConRadio.Text = "Sub Contractor"
        '
        'SupplierSubRadio
        '
        Me.SupplierSubRadio.Location = New System.Drawing.Point(8, 64)
        Me.SupplierSubRadio.Name = "SupplierSubRadio"
        Me.SupplierSubRadio.Size = New System.Drawing.Size(152, 24)
        Me.SupplierSubRadio.TabIndex = 96
        Me.SupplierSubRadio.Text = "Supplier / Sub Contractor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SubConRadio)
        Me.GroupBox2.Controls.Add(Me.SupplierSubRadio)
        Me.GroupBox2.Controls.Add(Me.SupplierRadio)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 96)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier Type"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CashRadio)
        Me.GroupBox3.Controls.Add(Me.CreditRadio)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 408)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 96)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mode of Payment"
        '
        'CashRadio
        '
        Me.CashRadio.Location = New System.Drawing.Point(8, 40)
        Me.CashRadio.Name = "CashRadio"
        Me.CashRadio.Size = New System.Drawing.Size(96, 24)
        Me.CashRadio.TabIndex = 96
        Me.CashRadio.Text = "Cash Payment"
        '
        'CreditRadio
        '
        Me.CreditRadio.Location = New System.Drawing.Point(8, 16)
        Me.CreditRadio.Name = "CreditRadio"
        Me.CreditRadio.TabIndex = 95
        Me.CreditRadio.Text = "Credit Payment"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(320, 528)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 100
        Me.CancelBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(248, 528)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 99
        Me.SaveBtn.Text = "&Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ApproveSupplierChk)
        Me.GroupBox1.Controls.Add(Me.GSTChk)
        Me.GroupBox1.Controls.Add(Me.CurrencyCmb)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.PaymentTermTxt)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Controls.Add(Me.SupplierTel2Txt)
        Me.GroupBox1.Controls.Add(Me.SupplierTel1Txt)
        Me.GroupBox1.Controls.Add(Me.SupplierPostalTxt)
        Me.GroupBox1.Controls.Add(Me.SupplierCountryTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.SupplierAddMemo)
        Me.GroupBox1.Controls.Add(Me.SupplierNameTxt)
        Me.GroupBox1.Controls.Add(Me.SupplierIDTxt)
        Me.GroupBox1.Controls.Add(Me.SupplyInitTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.SupplierFaxTxt)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GSTNoTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 552)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'ApproveSupplierChk
        '
        Me.ApproveSupplierChk.Location = New System.Drawing.Point(344, 344)
        Me.ApproveSupplierChk.Name = "ApproveSupplierChk"
        Me.ApproveSupplierChk.Size = New System.Drawing.Size(16, 16)
        Me.ApproveSupplierChk.TabIndex = 177
        '
        'GSTChk
        '
        Me.GSTChk.Location = New System.Drawing.Point(280, 264)
        Me.GSTChk.Name = "GSTChk"
        Me.GSTChk.Size = New System.Drawing.Size(16, 16)
        Me.GSTChk.TabIndex = 174
        '
        'CurrencyCmb
        '
        Me.CurrencyCmb.Location = New System.Drawing.Point(104, 376)
        Me.CurrencyCmb.Name = "CurrencyCmb"
        Me.CurrencyCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrencyCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CurrencyCmb.Properties.NullString = ""
        Me.CurrencyCmb.Size = New System.Drawing.Size(112, 19)
        Me.CurrencyCmb.TabIndex = 178
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 376)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 24)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "* Payment Currency :"
        '
        'PaymentTermTxt
        '
        Me.PaymentTermTxt.Location = New System.Drawing.Point(104, 344)
        Me.PaymentTermTxt.Name = "PaymentTermTxt"
        Me.PaymentTermTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PaymentTermTxt.Size = New System.Drawing.Size(112, 21)
        Me.PaymentTermTxt.TabIndex = 176
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 344)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 24)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "* Payment Terms :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "* Supplier Initial :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "* Address :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "* Supplier Name :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(8, 16)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(96, 16)
        Me.CustNameLbl.TabIndex = 77
        Me.CustNameLbl.Text = "Supplier ID :"
        '
        'SupplierTel2Txt
        '
        Me.SupplierTel2Txt.Location = New System.Drawing.Point(288, 168)
        Me.SupplierTel2Txt.Name = "SupplierTel2Txt"
        Me.SupplierTel2Txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierTel2Txt.Size = New System.Drawing.Size(88, 21)
        Me.SupplierTel2Txt.TabIndex = 75
        '
        'SupplierTel1Txt
        '
        Me.SupplierTel1Txt.Location = New System.Drawing.Point(104, 168)
        Me.SupplierTel1Txt.Name = "SupplierTel1Txt"
        Me.SupplierTel1Txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierTel1Txt.Size = New System.Drawing.Size(112, 21)
        Me.SupplierTel1Txt.TabIndex = 74
        '
        'SupplierPostalTxt
        '
        Me.SupplierPostalTxt.Location = New System.Drawing.Point(288, 136)
        Me.SupplierPostalTxt.Name = "SupplierPostalTxt"
        Me.SupplierPostalTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierPostalTxt.Size = New System.Drawing.Size(88, 21)
        Me.SupplierPostalTxt.TabIndex = 73
        '
        'SupplierCountryTxt
        '
        Me.SupplierCountryTxt.Location = New System.Drawing.Point(104, 136)
        Me.SupplierCountryTxt.Name = "SupplierCountryTxt"
        Me.SupplierCountryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierCountryTxt.Size = New System.Drawing.Size(112, 21)
        Me.SupplierCountryTxt.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Tel No.2 :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "* Tel No. 1 :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "* Postal :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "* Country :"
        '
        'SupplierAddMemo
        '
        Me.SupplierAddMemo.Location = New System.Drawing.Point(104, 80)
        Me.SupplierAddMemo.Name = "SupplierAddMemo"
        Me.SupplierAddMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierAddMemo.Size = New System.Drawing.Size(272, 48)
        Me.SupplierAddMemo.TabIndex = 66
        '
        'SupplierNameTxt
        '
        Me.SupplierNameTxt.Location = New System.Drawing.Point(104, 48)
        Me.SupplierNameTxt.Name = "SupplierNameTxt"
        Me.SupplierNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierNameTxt.Size = New System.Drawing.Size(272, 21)
        Me.SupplierNameTxt.TabIndex = 65
        '
        'SupplierIDTxt
        '
        Me.SupplierIDTxt.Enabled = False
        Me.SupplierIDTxt.Location = New System.Drawing.Point(104, 16)
        Me.SupplierIDTxt.Name = "SupplierIDTxt"
        Me.SupplierIDTxt.Properties.Enabled = False
        Me.SupplierIDTxt.Size = New System.Drawing.Size(56, 21)
        Me.SupplierIDTxt.TabIndex = 63
        '
        'SupplyInitTxt
        '
        Me.SupplyInitTxt.Location = New System.Drawing.Point(288, 16)
        Me.SupplyInitTxt.Name = "SupplyInitTxt"
        Me.SupplyInitTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplyInitTxt.Size = New System.Drawing.Size(88, 21)
        Me.SupplyInitTxt.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "* Fax No. :"
        '
        'SupplierFaxTxt
        '
        Me.SupplierFaxTxt.Location = New System.Drawing.Point(104, 200)
        Me.SupplierFaxTxt.Name = "SupplierFaxTxt"
        Me.SupplierFaxTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierFaxTxt.Size = New System.Drawing.Size(112, 21)
        Me.SupplierFaxTxt.TabIndex = 103
        '
        'GSTNoTxt
        '
        Me.GSTNoTxt.Location = New System.Drawing.Point(104, 264)
        Me.GSTNoTxt.Name = "GSTNoTxt"
        Me.GSTNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.GSTNoTxt.Size = New System.Drawing.Size(112, 21)
        Me.GSTNoTxt.TabIndex = 105
        '
        'SupplierContactTxt
        '
        Me.SupplierContactTxt.Location = New System.Drawing.Point(112, 240)
        Me.SupplierContactTxt.Name = "SupplierContactTxt"
        Me.SupplierContactTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierContactTxt.Size = New System.Drawing.Size(272, 21)
        Me.SupplierContactTxt.TabIndex = 104
        '
        'SupplierProdMemo
        '
        Me.SupplierProdMemo.Location = New System.Drawing.Point(112, 304)
        Me.SupplierProdMemo.Name = "SupplierProdMemo"
        Me.SupplierProdMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierProdMemo.Size = New System.Drawing.Size(272, 32)
        Me.SupplierProdMemo.TabIndex = 175
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "GST Number :"
        '
        'ManageSupplierForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(408, 565)
        Me.Controls.Add(Me.SupplierProdMemo)
        Me.Controls.Add(Me.SupplierContactTxt)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageSupplierForm"
        Me.Text = "Manage Supplier"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CurrencyCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentTermTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTel2Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTel1Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierPostalTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierCountryTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierAddMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIDTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyInitTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierFaxTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSTNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierContactTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierProdMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load "
    Private Sub ManageSupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 10.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 10.01.2004 YG End

        Me.Cursor = Cursors.WaitCursor
        LoadCurrency()
        Select Case UCase(FormStatus)
            Case "NEW"
                InitializeForm()

            Case "EDIT"
                Me.Text = "Edit Supplier"
                With New BusinessRules.SupplierBusRules.SupplierBusLogic
                    Dim dsSupplier As DataSet
                    If .GetSupplier(dsSupplier, Supplier_ID) Then
                        SetWindowValue(dsSupplier)
                    End If
                End With
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

        '      StatusCmb.Properties.LookUpData.KeyValue = "10"
        '     ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        '    ItemNoTxt.Text = WO_ItemNo.ToString
        '   WODate.DateTime = Date.Today
        With New BusinessRules.SaleBusRules.SaleBusLogic
            'GET CUSTOMER INITIAL
            Dim dstmp As DataSet
            Dim CustInitial
            '      If .GetCustomerDetails(dstmp, Customer_ID) Then
            '     If dstmp.Tables(0).Rows.Count > 0 Then
            '    CustInitial = dstmp.Tables(0).Rows(0)("Initial")
            '   CustLookup.Properties.LookUpData.KeyValue = dstmp.Tables(0).Rows(0)("Customer_ID")
            '  End If
            ' End If
            'dstmp.Dispose()
            'LoadContactPerson(Customer_ID)
            'CustLookup.Properties.ReadOnly = True

            'With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            'WO_NO = GetWorkOrderNo(CustInitial)
            'WONoTxt.Text = WO_NO

            '.WO_No = WO_NO
            '.UserID = UserID
            '.Status = StatusCmb.Properties.LookUpData.KeyValue

            'If .SaveWONo() Then
            'WO_ID = .WO_ID        'Store WO ID
            'Else
            '    MessageBox.Show("Error creating Work Order", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'End With
        End With
    End Sub
#End Region

#Region "Load ComboBox"
    '#### ALAN
    Private Sub LoadCurrency()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.CurrencyBusLogic
            If .GetCurrency(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(CurrencyCmb, "CurrencyName", 400, 0, "c")
                        CurrencyCmb.Properties.LookUpData.KeyField = "Currency_ID"
                        CurrencyCmb.Properties.LookUpData.DisplayField = "CurrencyName"

                        CurrencyCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        CurrencyCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
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

#Region "Button Event"
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveSupplier()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()

    End Sub

#End Region

#Region "Database Management"
    Private Sub SaveSupplier()

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.SupplierBusRules.SupplierBusLogic

                'Supplier_Name = Supplier_Name.Replace("'", "''")
                .Supplier_Name = Supplier_Name
                .Account_NO = Account_No
                .Address = Address
                .Country = Country
                .Postal = Postal
                .Tel1 = Tel1
                .Tel2 = Tel2
                .Fax = Fax
                .Contact_Person = Contact_Person
                .GST = GST
                .GST_Flg = GST_Flg
				.Remark = Remark
                .Payment_Term = Payment_Term
                .Approved = Approved
                .Supplier_Type = Supplier_Type
                .Payment_Mode = Payment_Mode
                '.Remark = Remark
                .Currency_ID = Currency_ID
                .UserID = UserID

                If Supplier_ID = Nothing Or Supplier_ID = 0 Then
                    ' 10.12.2003 YG Start
                    '                    Supplier_ID = .SaveSupplier()
                    If .SaveSupplier() Then
                        Supplier_ID = .Supplier_ID
                    End If
                    ' 10.12.2003 YG End
                    MessageBox.Show("Supplier Saved!", "Manage Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .UpdateSupplier(Supplier_ID)
                    MessageBox.Show("Supplier Updated!", "Manage Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                ' 10.12.2003 YG Start
                If Approved = 1 And Approved <> varApprove_Flg Then
                    .UpdateSupplierApproveDate(Supplier_ID)
                End If
                If Approved = 0 And Approved <> varApprove_Flg Then
                    .ClearSupplierApproveDate(Supplier_ID)
                End If
            End With
        End If
    End Sub

#End Region

#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        Dim varGST_Flg
        ' 10.12.2003 YG Comment out
        '        Dim varApprove_Flg
        Dim varSupplier_Type
        Dim varPayment_Mode

        'remove by alan SupplierIDTxt.Text = dsLoad.Tables(0).Rows(0)("Supplier_ID")
        SupplierNameTxt.Text = IIf(IsDBNull(dsLoad.Tables(0).Rows(0)("Supplier_Name")), "", dsLoad.Tables(0).Rows(0)("Supplier_Name"))
        'SupplierNameTxt.Text = SupplierNameTxt.Text.Replace("''", "'")

        SupplyInitTxt.Text = IIf(IsDBNull(dsLoad.Tables(0).Rows(0)("Account_No")), "", dsLoad.Tables(0).Rows(0)("Account_No"))
        SupplierAddMemo.Text = IIf(IsDBNull(dsLoad.Tables(0).Rows(0)("Address")), "", dsLoad.Tables(0).Rows(0)("Address"))
        SupplierCountryTxt.Text = IIf(IsDBNull(dsLoad.Tables(0).Rows(0)("Country")), "", dsLoad.Tables(0).Rows(0)("Country"))

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Postal")) Then
            SupplierPostalTxt.Text = dsLoad.Tables(0).Rows(0)("Postal")
        Else
            SupplierPostalTxt.Text = Nothing
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Tel1")) Then
            SupplierTel1Txt.Text = dsLoad.Tables(0).Rows(0)("Tel1")
        Else
            SupplierTel1Txt.Text = Nothing
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Tel2")) Then
            SupplierTel2Txt.Text = dsLoad.Tables(0).Rows(0)("Tel2")
        Else
            SupplierTel2Txt.Text = Nothing
        End If

        SupplierFaxTxt.Text = dsLoad.Tables(0).Rows(0)("Fax")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Contact_Person")) Then
            SupplierContactTxt.Text = dsLoad.Tables(0).Rows(0)("Contact_Person")
        Else
            SupplierContactTxt.Text = Nothing
        End If

        GSTNoTxt.Text = IIf(IsDBNull(dsLoad.Tables(0).Rows(0)("GST")), "", dsLoad.Tables(0).Rows(0)("GST"))

        varGST_Flg = dsLoad.Tables(0).Rows(0)("GST_Flg")
        If varGST_Flg = 1 Then
            GSTChk.Checked = True
        Else
            GSTChk.Checked = False
        End If

		If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remark")) Then
			SupplierProdMemo.Text = dsLoad.Tables(0).Rows(0)("Remark")
		Else
			SupplierProdMemo.Text = Nothing
		End If

		'add by alan
		If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
			PaymentTermTxt.Text = dsLoad.Tables(0).Rows(0)("Payment_Term")
		Else
			PaymentTermTxt.Text = Nothing
		End If
		'end by alan

		If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Approved")) Then
			varApprove_Flg = dsLoad.Tables(0).Rows(0)("Approved")
		Else
			varApprove_Flg = Nothing
		End If
		If varApprove_Flg = 1 Then
			ApproveSupplierChk.Checked = True
		Else
			ApproveSupplierChk.Checked = False
		End If
		If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Supplier_Type")) Then
			varSupplier_Type = dsLoad.Tables(0).Rows(0)("Supplier_Type")
		Else
			varSupplier_Type = Nothing
		End If
		If varSupplier_Type = 1 Then
			SupplierRadio.Checked = True
		End If
		If varSupplier_Type = 2 Then
			SubConRadio.Checked = True
		End If
		If varSupplier_Type = 3 Then
			SupplierSubRadio.Checked = True
		End If
		If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Mode")) Then
			varPayment_Mode = dsLoad.Tables(0).Rows(0)("Payment_Mode")
		Else
			varPayment_Mode = Nothing
		End If
		If varPayment_Mode = 1 Then
			CreditRadio.Checked = True
		End If
		If varPayment_Mode = 2 Then
			CashRadio.Checked = True
		End If
		If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Currency_ID")) Then
			CurrencyCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Currency_ID")
		Else
			CurrencyCmb.Properties.LookUpData.KeyValue = Nothing
		End If
    End Sub

    Private Sub GetWindowsValue()

        'Supplier_ID = SupplierIDTxt.Text
        Supplier_Name = SupplierNameTxt.Text
        Account_No = SupplyInitTxt.Text
        Address = SupplierAddMemo.Text
        Country = SupplierCountryTxt.Text
        Postal = SupplierPostalTxt.Text
        Tel1 = SupplierTel1Txt.Text
        Tel2 = SupplierTel2Txt.Text
        Fax = SupplierFaxTxt.Text
        Contact_Person = SupplierContactTxt.Text
        GST = GSTNoTxt.Text
        Currency_ID = CurrencyCmb.Properties.LookUpData.KeyValue

        If GSTChk.Checked = True Then
            GST_Flg = 1
        Else
            GST_Flg = 0
        End If

		Remark = SupplierProdMemo.Text
        Payment_Term = PaymentTermTxt.Text

        If ApproveSupplierChk.Checked = True Then
            Approved = 1
        Else
            Approved = 0
        End If

        If SupplierRadio.Checked = True Then
            Supplier_Type = 1
        End If
        If SubConRadio.Checked = True Then
            Supplier_Type = 2
        End If
        If SupplierSubRadio.Checked = True Then
            Supplier_Type = 3
        End If

        If CreditRadio.Checked = True Then
            Payment_Mode = 1
        End If
        If CashRadio.Checked = True Then
            Payment_Mode = 2
        End If

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        'Supplier_Name = Supplier_Name.Replace("'", "''")

        If Supplier_Name = "" Then
            ErrorMessage = ErrorMessage & " Supplier Name" & Chr(13)
            DataOK_flag = False
        End If

        If Account_No = "" Then
            ErrorMessage = ErrorMessage & " Supplier Initial" & Chr(13)
            DataOK_flag = False
        End If

        If Address = "" Then
            ErrorMessage = ErrorMessage & " Address" & Chr(13)
            DataOK_flag = False
        End If

        If Country = "" Then
            ErrorMessage = ErrorMessage & " Country" & Chr(13)
            DataOK_flag = False
        End If

        If Postal = "" Then
            ErrorMessage = ErrorMessage & " Postal" & Chr(13)
            DataOK_flag = False
        End If

        If Tel1 = "" Then
            ErrorMessage = ErrorMessage & " Telephone 1" & Chr(13)
            DataOK_flag = False
        End If

        If Fax = "" Then
            ErrorMessage = ErrorMessage & " Fax" & Chr(13)
            DataOK_flag = False
        End If

        If Contact_Person = "" Then
            ErrorMessage = ErrorMessage & " Contact Person" & Chr(13)
            DataOK_flag = False
        End If
        ' If GST = Nothing Then
        ' ErrorMessage = ErrorMessage & " GST No" & Chr(13)
        'DataOK_flag = False
        'End If

		If Remark = "" Then
			ErrorMessage = ErrorMessage & " Product/Service offer" & Chr(13)
			DataOK_flag = False
		End If

		If Payment_Term = Nothing Then
			ErrorMessage = ErrorMessage & " Payment Term" & Chr(13)
			DataOK_flag = False
		End If

		If Supplier_Type <> 1 And Supplier_Type <> 2 And Supplier_Type <> 3 Then
			ErrorMessage = ErrorMessage & " Supplier Type" & Chr(13)
			DataOK_flag = False
		End If

		If Payment_Mode <> 1 And Payment_Mode <> 2 Then
			ErrorMessage = ErrorMessage & " Payment Mode" & Chr(13)
			DataOK_flag = False
		End If

		If Currency_ID = 0 Then
			ErrorMessage = ErrorMessage & " Currency" & Chr(13)
			DataOK_flag = False
		End If

		If DataOK_flag = False Then

			With New Common.CommonError.ErrorMsg
				MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			End With
		Else
			With New BusinessRules.SupplierBusRules.SupplierBusLogic
				If Supplier_ID <> Nothing And Supplier_ID <> 0 Then
					If .RecordExists(Supplier_Name, Supplier_ID) Then
						MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
						DataOK_flag = False
					End If
				Else
					If .RecordExists(Supplier_Name, Nothing) Then
						MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
						DataOK_flag = False
					End If
				End If

			End With
		End If

		Return DataOK_flag

    End Function
#End Region

    Private Sub ManageSupplierForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Manage Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Dim a As MainForm = Me.ParentForm
            If (a.MainTabControl.TabPages.Count > 0) Then
                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub
End Class
