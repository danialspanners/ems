Public Class ManageConsultantForm
    Inherits System.Windows.Forms.Form

#Region "Consultant Form Variables Initialization"
    Public Consultant_ID As Integer
    Public FormStatus As String

    Public Consultant_Name As String
    Public Account_No As String
    Public Address As String
    Public Country As String
    Public Tel As String
    Public Fax As String
    Public Remark As String
    Private UserID As Integer = Common.CommonConn.Config.USERID

#End Region

    Dim FunctionName As String = "ConsultantProfile"
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pConsultant_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus
        If Not pConsultant_ID = 0 Then
            Consultant_ID = pConsultant_ID
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ConNameLbl As System.Windows.Forms.Label
    Friend WithEvents ConsultantNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConsultantIDTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConsultantTelTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConsultantCountryTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConsultantAddressTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ConsultantFaxTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConsultantAccountTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConsultantRemarkTxt As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ConNameLbl = New System.Windows.Forms.Label
        Me.ConsultantTelTxt = New DevExpress.XtraEditors.TextEdit
        Me.ConsultantCountryTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ConsultantAddressTxt = New DevExpress.XtraEditors.MemoEdit
        Me.ConsultantNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.ConsultantIDTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.ConsultantFaxTxt = New DevExpress.XtraEditors.TextEdit
        Me.ConsultantRemarkTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.ConsultantAccountTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.ConsultantTelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantCountryTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantAddressTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantIDTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantFaxTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantRemarkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantAccountTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Account No. :"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(304, 328)
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
        Me.SaveBtn.Location = New System.Drawing.Point(232, 328)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 99
        Me.SaveBtn.Text = "&Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ConNameLbl)
        Me.GroupBox1.Controls.Add(Me.ConsultantTelTxt)
        Me.GroupBox1.Controls.Add(Me.ConsultantCountryTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ConsultantAddressTxt)
        Me.GroupBox1.Controls.Add(Me.ConsultantNameTxt)
        Me.GroupBox1.Controls.Add(Me.ConsultantIDTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ConsultantFaxTxt)
        Me.GroupBox1.Controls.Add(Me.ConsultantRemarkTxt)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 360)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Address :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Name :"
        '
        'ConNameLbl
        '
        Me.ConNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConNameLbl.Location = New System.Drawing.Point(8, 16)
        Me.ConNameLbl.Name = "ConNameLbl"
        Me.ConNameLbl.Size = New System.Drawing.Size(96, 16)
        Me.ConNameLbl.TabIndex = 77
        Me.ConNameLbl.Text = "Consultant ID :"
        '
        'ConsultantTelTxt
        '
        Me.ConsultantTelTxt.Location = New System.Drawing.Point(104, 168)
        Me.ConsultantTelTxt.Name = "ConsultantTelTxt"
        Me.ConsultantTelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConsultantTelTxt.Size = New System.Drawing.Size(112, 21)
        Me.ConsultantTelTxt.TabIndex = 74
        '
        'ConsultantCountryTxt
        '
        Me.ConsultantCountryTxt.Location = New System.Drawing.Point(104, 136)
        Me.ConsultantCountryTxt.Name = "ConsultantCountryTxt"
        Me.ConsultantCountryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConsultantCountryTxt.Size = New System.Drawing.Size(112, 21)
        Me.ConsultantCountryTxt.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Tel No.  :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Country :"
        '
        'ConsultantAddressTxt
        '
        Me.ConsultantAddressTxt.Location = New System.Drawing.Point(104, 80)
        Me.ConsultantAddressTxt.Name = "ConsultantAddressTxt"
        Me.ConsultantAddressTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConsultantAddressTxt.Size = New System.Drawing.Size(272, 48)
        Me.ConsultantAddressTxt.TabIndex = 66
        '
        'ConsultantNameTxt
        '
        Me.ConsultantNameTxt.Location = New System.Drawing.Point(104, 48)
        Me.ConsultantNameTxt.Name = "ConsultantNameTxt"
        Me.ConsultantNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConsultantNameTxt.Size = New System.Drawing.Size(272, 21)
        Me.ConsultantNameTxt.TabIndex = 65
        '
        'ConsultantIDTxt
        '
        Me.ConsultantIDTxt.Enabled = False
        Me.ConsultantIDTxt.Location = New System.Drawing.Point(104, 16)
        Me.ConsultantIDTxt.Name = "ConsultantIDTxt"
        Me.ConsultantIDTxt.Properties.Enabled = False
        Me.ConsultantIDTxt.Size = New System.Drawing.Size(56, 21)
        Me.ConsultantIDTxt.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Fax No. :"
        '
        'ConsultantFaxTxt
        '
        Me.ConsultantFaxTxt.Location = New System.Drawing.Point(104, 200)
        Me.ConsultantFaxTxt.Name = "ConsultantFaxTxt"
        Me.ConsultantFaxTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConsultantFaxTxt.Size = New System.Drawing.Size(112, 21)
        Me.ConsultantFaxTxt.TabIndex = 103
        '
        'ConsultantRemarkTxt
        '
        Me.ConsultantRemarkTxt.Location = New System.Drawing.Point(104, 264)
        Me.ConsultantRemarkTxt.Name = "ConsultantRemarkTxt"
        Me.ConsultantRemarkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConsultantRemarkTxt.Size = New System.Drawing.Size(272, 32)
        Me.ConsultantRemarkTxt.TabIndex = 107
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 32)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Remark"
        '
        'ConsultantAccountTxt
        '
        Me.ConsultantAccountTxt.Location = New System.Drawing.Point(112, 240)
        Me.ConsultantAccountTxt.Name = "ConsultantAccountTxt"
        Me.ConsultantAccountTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConsultantAccountTxt.Size = New System.Drawing.Size(184, 21)
        Me.ConsultantAccountTxt.TabIndex = 104
        '
        'ManageConsultantForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 389)
        Me.Controls.Add(Me.ConsultantAccountTxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageConsultantForm"
        Me.Text = "Manage Consultant"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ConsultantTelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantCountryTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantAddressTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantIDTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantFaxTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantRemarkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantAccountTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load "
    Private Sub ManageConsultant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Me.Cursor = Cursors.WaitCursor

        Select Case UCase(FormStatus)
            Case "NEW"
                InitializeForm()

            Case "EDIT"
                Me.Text = "Edit Consultant"
                With New BusinessRules.ConsultantBusRules.ConsultantBusLogic
                    Dim dsConsultant As DataSet
                    If .GetConsultant(dsConsultant, Consultant_ID) Then
                        SetWindowValue(dsConsultant)
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
        With New BusinessRules.ConsultantBusRules.ConsultantBusLogic
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
        SaveConsultant()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()

    End Sub

#End Region

#Region "Database Management"
    Private Sub SaveConsultant()

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.ConsultantBusRules.ConsultantBusLogic

                .Consultant_Name = Consultant_Name
                .Account_No = Account_No
                .Address = Address
                .Country = Country
                .Tel = Tel
                .Fax = Fax
                .Remark = Remark
                .UserID = UserID

                If Consultant_ID = Nothing Or Consultant_ID = 0 Then
                    Consultant_ID = .SaveConsultant()
                    MessageBox.Show("Consultant Saved!", "Manage Consultant", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .UpdateConsultant(Consultant_ID)
                    MessageBox.Show("Consultant Updated!", "Manage Consultant", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        End If
    End Sub

#End Region

#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
            ConsultantIDTxt.Text = dsLoad.Tables(0).Rows(0)("Consultant_ID")
        Else
            ConsultantIDTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_Name")) Then
            ConsultantNameTxt.Text = dsLoad.Tables(0).Rows(0)("Consultant_Name")
        Else
            ConsultantNameTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Address")) Then
            ConsultantAddressTxt.Text = dsLoad.Tables(0).Rows(0)("Address")
        Else
            ConsultantAddressTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Country")) Then
            ConsultantCountryTxt.Text = dsLoad.Tables(0).Rows(0)("Country")
        Else
            ConsultantCountryTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Tel")) Then
            ConsultantTelTxt.Text = dsLoad.Tables(0).Rows(0)("Tel")
        Else
            ConsultantTelTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Fax")) Then
            ConsultantFaxTxt.Text = dsLoad.Tables(0).Rows(0)("Fax")
        Else
            ConsultantFaxTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Account_No")) Then
            ConsultantAccountTxt.Text = dsLoad.Tables(0).Rows(0)("Account_No")
        Else
            ConsultantAccountTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remark")) Then
            ConsultantRemarkTxt.Text = dsLoad.Tables(0).Rows(0)("Remark")
        Else
            ConsultantRemarkTxt.Text = Nothing
        End If
    End Sub

    Private Sub GetWindowsValue()

        'Supplier_ID = SupplierIDTxt.Text
        Consultant_Name = ConsultantNameTxt.Text
        Address = ConsultantAddressTxt.Text
        Country = ConsultantCountryTxt.Text
        Tel = ConsultantTelTxt.Text
        Fax = ConsultantFaxTxt.Text
        Account_No = ConsultantAccountTxt.Text
        Remark = ConsultantRemarkTxt.Text

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If Consultant_Name = "" Then
            ErrorMessage = ErrorMessage & " Consultant Name" & Chr(13)
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

        If Tel = "" Then
            ErrorMessage = ErrorMessage & " Telephone " & Chr(13)
            DataOK_flag = False
        End If

        If Fax = "" Then
            ErrorMessage = ErrorMessage & " Fax" & Chr(13)
            DataOK_flag = False
        End If

        If Account_No = "" Then
            ErrorMessage = ErrorMessage & " Account No" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.ConsultantBusRules.ConsultantBusLogic
                If Consultant_ID <> Nothing And Consultant_ID <> 0 Then
                    If .RecordExists(Consultant_Name, Consultant_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(Consultant_Name, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function
#End Region

    Private Sub ManageConsultantForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit", "Consultant", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
