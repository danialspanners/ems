Public Class CustomerContactForm
    Inherits System.Windows.Forms.Form

#Region "Customer Contact Form Variables Initialization"
    Public Customer_ID As Integer
    Public Contact_ID As Integer
    Public FormStatus As String
    Public FormType As Integer

    Public Title As String
    Public Contact_Name As String
    Public Tel As String
    Public Ext As String
    Public Pager As String
    Public HandPhone As String
    Public Email As String
    Private UserID As Integer = Common.CommonConn.Config.USERID
    Dim FunctionName As String = "MyCustomerContact" ' 29.12.2003 YG Added

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pCustomer_ID As Integer = 0, Optional ByVal pContact_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus
        If Not pCustomer_ID = 0 Then
            Customer_ID = pCustomer_ID
        End If
        If Not pContact_ID = 0 Then
            Contact_ID = pContact_ID
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pFormType As Integer, Optional ByVal pCustomer_ID As Integer = 0, Optional ByVal pContact_ID As Integer = 0)
        MyBase.New()

        FormType = pFormType
        If Not pCustomer_ID = 0 Then
            Customer_ID = pCustomer_ID
        Else

        End If

        If Not pContact_ID = 0 Then
            Contact_ID = pContact_ID
        Else
            FormStatus = "NEW"
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
    Friend WithEvents ContactExtTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactTelTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactPagerTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactHandPhoneTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactTitleTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContactEmailTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ContactEmailTxt = New DevExpress.XtraEditors.TextEdit
        Me.ContactTitleTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ConNameLbl = New System.Windows.Forms.Label
        Me.ContactExtTxt = New DevExpress.XtraEditors.TextEdit
        Me.ContactTelTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ContactNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.ContactPagerTxt = New DevExpress.XtraEditors.TextEdit
        Me.ContactHandPhoneTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.ContactEmailTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactTitleTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactExtTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactTelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactPagerTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactHandPhoneTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "HandPhone :"
        '
        'CancelBtn
        '
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(304, 240)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 7
        Me.CancelBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(232, 240)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 6
        Me.SaveBtn.Text = "&Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ContactEmailTxt)
        Me.GroupBox1.Controls.Add(Me.ContactTitleTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ConNameLbl)
        Me.GroupBox1.Controls.Add(Me.ContactExtTxt)
        Me.GroupBox1.Controls.Add(Me.ContactTelTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ContactNameTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ContactPagerTxt)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 280)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Email :"
        '
        'ContactEmailTxt
        '
        Me.ContactEmailTxt.Location = New System.Drawing.Point(96, 208)
        Me.ContactEmailTxt.Name = "ContactEmailTxt"
        Me.ContactEmailTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContactEmailTxt.Size = New System.Drawing.Size(272, 21)
        Me.ContactEmailTxt.TabIndex = 5
        '
        'ContactTitleTxt
        '
        Me.ContactTitleTxt.Location = New System.Drawing.Point(96, 16)
        Me.ContactTitleTxt.Name = "ContactTitleTxt"
        Me.ContactTitleTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContactTitleTxt.Size = New System.Drawing.Size(112, 21)
        Me.ContactTitleTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "*Name :"
        '
        'ConNameLbl
        '
        Me.ConNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConNameLbl.Location = New System.Drawing.Point(8, 16)
        Me.ConNameLbl.Name = "ConNameLbl"
        Me.ConNameLbl.Size = New System.Drawing.Size(96, 16)
        Me.ConNameLbl.TabIndex = 77
        Me.ConNameLbl.Text = "*Title :"
        '
        'ContactExtTxt
        '
        Me.ContactExtTxt.Location = New System.Drawing.Point(96, 112)
        Me.ContactExtTxt.Name = "ContactExtTxt"
        Me.ContactExtTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContactExtTxt.Size = New System.Drawing.Size(112, 21)
        Me.ContactExtTxt.TabIndex = 3
        '
        'ContactTelTxt
        '
        Me.ContactTelTxt.Location = New System.Drawing.Point(96, 80)
        Me.ContactTelTxt.Name = "ContactTelTxt"
        Me.ContactTelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContactTelTxt.Size = New System.Drawing.Size(112, 21)
        Me.ContactTelTxt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Ext.  :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Tel :"
        '
        'ContactNameTxt
        '
        Me.ContactNameTxt.Location = New System.Drawing.Point(96, 48)
        Me.ContactNameTxt.Name = "ContactNameTxt"
        Me.ContactNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContactNameTxt.Size = New System.Drawing.Size(272, 21)
        Me.ContactNameTxt.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Pager  :"
        '
        'ContactPagerTxt
        '
        Me.ContactPagerTxt.Location = New System.Drawing.Point(96, 176)
        Me.ContactPagerTxt.Name = "ContactPagerTxt"
        Me.ContactPagerTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContactPagerTxt.Size = New System.Drawing.Size(112, 21)
        Me.ContactPagerTxt.TabIndex = 4
        '
        'ContactHandPhoneTxt
        '
        Me.ContactHandPhoneTxt.Location = New System.Drawing.Point(104, 152)
        Me.ContactHandPhoneTxt.Name = "ContactHandPhoneTxt"
        Me.ContactHandPhoneTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContactHandPhoneTxt.Size = New System.Drawing.Size(112, 21)
        Me.ContactHandPhoneTxt.TabIndex = 0
        '
        'CustomerContactForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 293)
        Me.Controls.Add(Me.ContactHandPhoneTxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CustomerContactForm"
        Me.Text = "Manage Customer Contact"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ContactEmailTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactTitleTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactExtTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactTelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactPagerTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactHandPhoneTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load "
    Private Sub ManageCustomerContact_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        Select Case UCase(FormStatus)
            Case "NEW"
                InitializeForm()

            Case "EDIT"
                Me.Text = "Edit Customer Contact"
                With New BusinessRules.CustomerBusRules.CustomerBusLogic
                    Dim dsCustomerContact As DataSet
                    If .GetCustomerContact(dsCustomerContact, Contact_ID) Then
                        SetWindowValue(dsCustomerContact)
                    End If
                End With
        End Select
        ContactTitleTxt.Select()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

    End Sub
#End Region

#Region "Button Event"
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click

        If SaveContact() = True Then
            If FormType = 1 Then
                Close()
            End If
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()

    End Sub

#End Region

#Region "Database Management"
    Private Function SaveContact() As Boolean

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.CustomerBusRules.CustomerBusLogic

                .Title = Title
                .Contact_Name = Contact_Name
                .Tel = Tel
                .Ext = Ext
                .Pager = Pager
                .HandPhone = HandPhone
                .Email = Email
                .Customer_ID = Customer_ID
                .UserID = UserID

                If Contact_ID = Nothing Or Contact_ID = 0 Then
                    Contact_ID = .SaveCustomerContact()
                    'MessageBox.Show("Customer Contact Saved!", "Manage Customer Contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CancelBtn_Click(Me, Nothing)
                Else
                    .UpdateCustomerContact(Contact_ID)
                    'MessageBox.Show("Customer Contact Updated!", "Update Customer Contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CancelBtn_Click(Me, Nothing)
                End If
            End With
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Title")) Then
            ContactTitleTxt.Text = dsLoad.Tables(0).Rows(0)("Title")
        Else
            ContactTitleTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Name")) Then
            ContactNameTxt.Text = dsLoad.Tables(0).Rows(0)("Name")
        Else
            ContactNameTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Tel")) Then
            ContactTelTxt.Text = dsLoad.Tables(0).Rows(0)("Tel")
        Else
            ContactTelTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Ext")) Then
            ContactExtTxt.Text = dsLoad.Tables(0).Rows(0)("Ext")
        Else
            ContactExtTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("HandPhone")) Then
            ContactHandPhoneTxt.Text = dsLoad.Tables(0).Rows(0)("HandPhone")
        Else
            ContactHandPhoneTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Pager")) Then
            ContactPagerTxt.Text = dsLoad.Tables(0).Rows(0)("Pager")
        Else
            ContactPagerTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ContactEmail")) Then
            ContactEmailTxt.Text = dsLoad.Tables(0).Rows(0)("ContactEmail")
        Else
            ContactEmailTxt.Text = Nothing
        End If
    End Sub

    Private Sub GetWindowsValue()

        Title = ContactTitleTxt.Text
        Contact_Name = ContactNameTxt.Text
        Tel = ContactTelTxt.Text
        Ext = ContactExtTxt.Text
        Pager = ContactPagerTxt.Text
        HandPhone = ContactHandPhoneTxt.Text
        Email = ContactEmailTxt.Text

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If Title = "" Then
            ErrorMessage = ErrorMessage & " Title" & Chr(13)
            DataOK_flag = False
        End If

        If Contact_Name = "" Then
            ErrorMessage = ErrorMessage & " Name" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.CustomerBusRules.CustomerBusLogic
                If Contact_ID <> Nothing And Contact_ID <> 0 Then
                    If .ContactRecordExists(Contact_Name, Customer_ID, Contact_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .ContactRecordExists(Contact_Name, Customer_ID, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function
#End Region

    Private Sub CustomerContactForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult
        If Me.Modal = False Then

            Result = MessageBox.Show("Customer Contact Saved! Close Now?", "Customer Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
        End If

    End Sub
End Class
