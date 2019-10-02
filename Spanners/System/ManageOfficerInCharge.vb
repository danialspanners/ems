Public Class ManageOfficerForm
    Inherits System.Windows.Forms.Form

#Region "Officer Form Variables Initialization"
    Public Officer_ID As Integer
    Public FormStatus As String
    Public Officer_Name As String
    Public Account_No As String
    Public Tel As String
    Public Officer_Section As Integer
    Public Officer_Location As String
    Public Title As String
    Public Sex As String
    Public Handphone1 As String
    Public Handphone2 As String
    Public E_Mail As String
    Public Active_Flg As Integer
    Public Position As String
    Public Remarks As String
    Private UserID As Integer = Common.CommonConn.Config.USERID
    Dim dsOfficer As DataSet
#End Region

    ' 10.01.2004 YG Start
    Dim FunctionName As String = "OfficerProfile"
    ' 10.01.2004 YG End

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pOfficer_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus
        If Not pOfficer_ID = 0 Then
            Officer_ID = pOfficer_ID
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ConNameLbl As System.Windows.Forms.Label
    Friend WithEvents OfficerNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OfficerIDTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OfficerTelTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OfficerAccountTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OfficerLocationTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OfficerSectionCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Handphone2Txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EmailTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PositionTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TitleTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActiveChk As System.Windows.Forms.CheckBox
    Friend WithEvents SexTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HandPhone1Txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemarksMemo As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RemarksMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.PositionTxt = New DevExpress.XtraEditors.TextEdit
        Me.ActiveChk = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.EmailTxt = New DevExpress.XtraEditors.TextEdit
        Me.SexTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Handphone2Txt = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.HandPhone1Txt = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.TitleTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.OfficerSectionCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ConNameLbl = New System.Windows.Forms.Label
        Me.OfficerTelTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.OfficerNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.OfficerIDTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.OfficerLocationTxt = New DevExpress.XtraEditors.TextEdit
        Me.OfficerAccountTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.RemarksMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Handphone2Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HandPhone1Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerSectionCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerTelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerIDTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerLocationTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerAccountTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(160, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Customer :"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(344, 320)
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
        Me.SaveBtn.Location = New System.Drawing.Point(272, 320)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 99
        Me.SaveBtn.Text = "&Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.RemarksMemo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.PositionTxt)
        Me.GroupBox1.Controls.Add(Me.ActiveChk)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.EmailTxt)
        Me.GroupBox1.Controls.Add(Me.SexTxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Handphone2Txt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.HandPhone1Txt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TitleTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.OfficerSectionCmb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ConNameLbl)
        Me.GroupBox1.Controls.Add(Me.OfficerTelTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.OfficerNameTxt)
        Me.GroupBox1.Controls.Add(Me.OfficerIDTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.OfficerLocationTxt)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 360)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'RemarksMemo
        '
        Me.RemarksMemo.Location = New System.Drawing.Point(88, 264)
        Me.RemarksMemo.Name = "RemarksMemo"
        Me.RemarksMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RemarksMemo.Size = New System.Drawing.Size(320, 40)
        Me.RemarksMemo.TabIndex = 182
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Position :"
        '
        'PositionTxt
        '
        Me.PositionTxt.Location = New System.Drawing.Point(88, 112)
        Me.PositionTxt.Name = "PositionTxt"
        Me.PositionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PositionTxt.Size = New System.Drawing.Size(112, 21)
        Me.PositionTxt.TabIndex = 180
        '
        'ActiveChk
        '
        Me.ActiveChk.Location = New System.Drawing.Point(88, 240)
        Me.ActiveChk.Name = "ActiveChk"
        Me.ActiveChk.Size = New System.Drawing.Size(16, 16)
        Me.ActiveChk.TabIndex = 179
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 178
        Me.Label10.Text = "Active :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "E-Mail :"
        '
        'EmailTxt
        '
        Me.EmailTxt.Location = New System.Drawing.Point(88, 208)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EmailTxt.Size = New System.Drawing.Size(320, 21)
        Me.EmailTxt.TabIndex = 113
        '
        'SexTxt
        '
        Me.SexTxt.Location = New System.Drawing.Point(216, 48)
        Me.SexTxt.Name = "SexTxt"
        Me.SexTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SexTxt.Size = New System.Drawing.Size(64, 21)
        Me.SexTxt.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(152, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Sex :"
        '
        'Handphone2Txt
        '
        Me.Handphone2Txt.Location = New System.Drawing.Point(296, 176)
        Me.Handphone2Txt.Name = "Handphone2Txt"
        Me.Handphone2Txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.Handphone2Txt.Size = New System.Drawing.Size(112, 21)
        Me.Handphone2Txt.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Handphone 2 :"
        '
        'HandPhone1Txt
        '
        Me.HandPhone1Txt.Location = New System.Drawing.Point(88, 176)
        Me.HandPhone1Txt.Name = "HandPhone1Txt"
        Me.HandPhone1Txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.HandPhone1Txt.Size = New System.Drawing.Size(112, 21)
        Me.HandPhone1Txt.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Handphone 1 :"
        '
        'TitleTxt
        '
        Me.TitleTxt.Location = New System.Drawing.Point(88, 48)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TitleTxt.Size = New System.Drawing.Size(56, 21)
        Me.TitleTxt.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Salute :"
        '
        'OfficerSectionCmb
        '
        Me.OfficerSectionCmb.Location = New System.Drawing.Point(296, 112)
        Me.OfficerSectionCmb.Name = "OfficerSectionCmb"
        Me.OfficerSectionCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OfficerSectionCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.OfficerSectionCmb.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Section_Code", 15, "Section Code"))
        Me.OfficerSectionCmb.Properties.NullString = ""
        Me.OfficerSectionCmb.Properties.PopupWidth = 304
        Me.OfficerSectionCmb.Size = New System.Drawing.Size(112, 19)
        Me.OfficerSectionCmb.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Name :"
        '
        'ConNameLbl
        '
        Me.ConNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConNameLbl.Location = New System.Drawing.Point(8, 16)
        Me.ConNameLbl.Name = "ConNameLbl"
        Me.ConNameLbl.Size = New System.Drawing.Size(64, 16)
        Me.ConNameLbl.TabIndex = 77
        Me.ConNameLbl.Text = "Officer ID :"
        '
        'OfficerTelTxt
        '
        Me.OfficerTelTxt.Location = New System.Drawing.Point(88, 144)
        Me.OfficerTelTxt.Name = "OfficerTelTxt"
        Me.OfficerTelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.OfficerTelTxt.Size = New System.Drawing.Size(112, 21)
        Me.OfficerTelTxt.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Tel No.  :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Section :"
        '
        'OfficerNameTxt
        '
        Me.OfficerNameTxt.Location = New System.Drawing.Point(88, 80)
        Me.OfficerNameTxt.Name = "OfficerNameTxt"
        Me.OfficerNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.OfficerNameTxt.Size = New System.Drawing.Size(320, 21)
        Me.OfficerNameTxt.TabIndex = 65
        '
        'OfficerIDTxt
        '
        Me.OfficerIDTxt.Enabled = False
        Me.OfficerIDTxt.Location = New System.Drawing.Point(88, 16)
        Me.OfficerIDTxt.Name = "OfficerIDTxt"
        Me.OfficerIDTxt.Properties.Enabled = False
        Me.OfficerIDTxt.Size = New System.Drawing.Size(56, 21)
        Me.OfficerIDTxt.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Remarks :"
        '
        'OfficerLocationTxt
        '
        Me.OfficerLocationTxt.Location = New System.Drawing.Point(296, 48)
        Me.OfficerLocationTxt.Name = "OfficerLocationTxt"
        Me.OfficerLocationTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.OfficerLocationTxt.Size = New System.Drawing.Size(112, 21)
        Me.OfficerLocationTxt.TabIndex = 103
        Me.OfficerLocationTxt.Visible = False
        '
        'OfficerAccountTxt
        '
        Me.OfficerAccountTxt.Location = New System.Drawing.Point(224, 24)
        Me.OfficerAccountTxt.Name = "OfficerAccountTxt"
        Me.OfficerAccountTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.OfficerAccountTxt.Size = New System.Drawing.Size(64, 21)
        Me.OfficerAccountTxt.TabIndex = 104
        '
        'ManageOfficerForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 373)
        Me.Controls.Add(Me.OfficerAccountTxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageOfficerForm"
        Me.Text = "Manage Officer"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.RemarksMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Handphone2Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HandPhone1Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerSectionCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerTelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerIDTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerLocationTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerAccountTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load "
    Private Sub ManageOfficer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 10.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm


        If a.com.CheckGroupAccess(a.com, "setup | contacts | officers") Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If a.com.CheckGroupAccess(a.com, "setup | contacts | officers") Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 10.01.2004 YG End

        Me.Cursor = Cursors.WaitCursor

        LoadOfficer_Section()

        Select Case UCase(FormStatus)
            Case "NEW"
                InitializeForm()

            Case "EDIT"
                Me.Text = "Edit Officer"
                With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
                    If .GetOfficerInCharge(dsOfficer, Officer_ID) Then
                        SetWindowValue(dsOfficer)
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
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
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

#Region "Button Event"
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveOfficer()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()

    End Sub

#End Region

#Region "Database Management"
    Private Sub SaveOfficer()

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic

                .Officer_Name = Officer_Name
                .Account_No = Account_No
                .Tel = Tel
                .Officer_Section = Officer_Section
                .Officer_Location = Officer_Location
                .Title = Title
                .Sex = Sex
                .Handphone1 = Handphone1
                .Handphone2 = Handphone2
                .E_Mail = E_Mail
                .Active_Flg = Active_Flg
                .Position = Position
                .Remarks = Remarks
                .UserID = UserID

                If Officer_ID = Nothing Or Officer_ID = 0 Then
                    Officer_ID = .SaveOfficerInCharge()
                    MessageBox.Show("Officer Saved!", "Manage Officer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .UpdateOfficerInCharge(Officer_ID)
                    MessageBox.Show("Officer Updated!", "Manage Officer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        End If
    End Sub

#End Region

#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        Dim varActive_Flg

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Officer_In_Charge_ID")) Then
            OfficerIDTxt.Text = dsLoad.Tables(0).Rows(0)("Officer_In_Charge_ID")
        Else
            OfficerIDTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Officer_Name")) Then
            OfficerNameTxt.Text = dsLoad.Tables(0).Rows(0)("Officer_Name")
        Else
            OfficerNameTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Account_No")) Then
            OfficerAccountTxt.Text = dsLoad.Tables(0).Rows(0)("Account_No")
        Else
            OfficerAccountTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Tel")) Then
            OfficerTelTxt.Text = dsLoad.Tables(0).Rows(0)("Tel")
        Else
            OfficerTelTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Section_ID")) Then
            OfficerSectionCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Section_ID")
        Else
            OfficerSectionCmb.Properties.LookUpData.KeyValue = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Contact_Location")) Then
            OfficerLocationTxt.Text = dsLoad.Tables(0).Rows(0)("Contact_Location")
        Else
            OfficerLocationTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Title")) Then
            TitleTxt.Text = dsLoad.Tables(0).Rows(0)("Title")
        Else
            TitleTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Sex")) Then
            SexTxt.Text = dsLoad.Tables(0).Rows(0)("Sex")
        Else
            SexTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Handphone1")) Then
            HandPhone1Txt.Text = dsLoad.Tables(0).Rows(0)("Handphone1")
        Else
            HandPhone1Txt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Handphone2")) Then
            Handphone2Txt.Text = dsLoad.Tables(0).Rows(0)("Handphone2")
        Else
            Handphone2Txt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("E_Mail")) Then
            EmailTxt.Text = dsLoad.Tables(0).Rows(0)("Handphone2")
        Else
            EmailTxt.Text = Nothing
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Active_Flg")) Then
            varActive_Flg = dsLoad.Tables(0).Rows(0)("Active_Flg")
        Else
            varActive_Flg = Nothing
        End If
        If varActive_Flg = 1 Then
            ActiveChk.Checked = True
        Else
            ActiveChk.Checked = False
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remarks")) Then
            RemarksMemo.Text = dsLoad.Tables(0).Rows(0)("Remarks")
        Else
            RemarksMemo.Text = Nothing
        End If
    End Sub

    Private Sub GetWindowsValue()

        Officer_Name = OfficerNameTxt.Text
        Account_No = OfficerAccountTxt.Text
        Tel = OfficerTelTxt.Text
        Officer_Section = OfficerSectionCmb.Properties.LookUpData.KeyValue
        Officer_Location = OfficerLocationTxt.Text
        Title = TitleTxt.Text
        Sex = SexTxt.Text
        Handphone1 = HandPhone1Txt.Text
        Handphone2 = Handphone2Txt.Text
        E_Mail = EmailTxt.Text
        If ActiveChk.Checked = True Then
            Active_Flg = 1
        Else
            Active_Flg = 0
        End If
        Position = PositionTxt.Text
        Remarks = RemarksMemo.Text()
    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If Officer_Name = "" Then
            ErrorMessage = ErrorMessage & " Officer Name" & Chr(13)
            DataOK_flag = False
        End If

        'If Account_No = "" Then
        'ErrorMessage = ErrorMessage & " Account No" & Chr(13)
        'DataOK_flag = False
        'End If

        'If Tel = "" Then
        'ErrorMessage = ErrorMessage & " Telephone " & Chr(13)
        'DataOK_flag = False
        'End If

        'If Officer_Section = 0 Or Officer_Section = Nothing Then
        'ErrorMessage = ErrorMessage & " Officer_Section" & Chr(13)
        'DataOK_flag = False
        'End If

        'If Officer_Location = "" Then
        'ErrorMessage = ErrorMessage & " Officer_Location" & Chr(13)
        'DataOK_flag = False
        'End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
                If Officer_ID <> Nothing And Officer_ID <> 0 Then
                    If .RecordExists(Officer_Name, Officer_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(Officer_Name, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function
#End Region

#Region "Laod Combo Box"
    Private Sub LoadOfficer_Section()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
            If .GetOfficerSection(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        'AddListFieldInfoToLookUp(OfficerSectionCmb, "Section_Code", 400, 0, "c")
                        OfficerSectionCmb.Properties.LookUpData.KeyField = "Section_Id"
                        OfficerSectionCmb.Properties.LookUpData.DisplayField = "Section_Code"
                        OfficerSectionCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        'OfficerSectionCmb.EditValue = "0"

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

    Private Sub OfficerSectionCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles OfficerSectionCmb.CloseUp
        'OfficerSectionCmb.Properties.LookUpData.KeyValue = 2
        'MsgBox(OfficerSectionCmb.Properties.LookUpData.KeyValue)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ManageOfficerForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit", "Officer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

