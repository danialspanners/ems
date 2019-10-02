Public Class ManageUserProfile
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

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
    Friend WithEvents UserProfileGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CreateNewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UserProfileListBox As System.Windows.Forms.ListBox
    Friend WithEvents UserNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LoginIDTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserGroupLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DepartmentLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents LoginPasswordTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents emailtxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UserProfileGroupBox = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LoginPasswordTxt = New DevExpress.XtraEditors.TextEdit
        Me.DepartmentLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.UserGroupLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreateNewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.UserProfileListBox = New System.Windows.Forms.ListBox
        Me.UserNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.LoginIDTxt = New DevExpress.XtraEditors.TextEdit
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.Label6 = New System.Windows.Forms.Label
        Me.emailtxt = New DevExpress.XtraEditors.TextEdit
        Me.UserProfileGroupBox.SuspendLayout()
        CType(Me.LoginPasswordTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGroupLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginIDTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailtxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserProfileGroupBox
        '
        Me.UserProfileGroupBox.Controls.Add(Me.Label6)
        Me.UserProfileGroupBox.Controls.Add(Me.emailtxt)
        Me.UserProfileGroupBox.Controls.Add(Me.Label5)
        Me.UserProfileGroupBox.Controls.Add(Me.LoginPasswordTxt)
        Me.UserProfileGroupBox.Controls.Add(Me.DepartmentLookUpEdit)
        Me.UserProfileGroupBox.Controls.Add(Me.UserGroupLookUpEdit)
        Me.UserProfileGroupBox.Controls.Add(Me.Label4)
        Me.UserProfileGroupBox.Controls.Add(Me.Label3)
        Me.UserProfileGroupBox.Controls.Add(Me.CloseBtn)
        Me.UserProfileGroupBox.Controls.Add(Me.CreateNewBtn)
        Me.UserProfileGroupBox.Controls.Add(Me.DeleteBtn)
        Me.UserProfileGroupBox.Controls.Add(Me.UserProfileListBox)
        Me.UserProfileGroupBox.Controls.Add(Me.UserNameTxt)
        Me.UserProfileGroupBox.Controls.Add(Me.LoginIDTxt)
        Me.UserProfileGroupBox.Controls.Add(Me.SaveBtn)
        Me.UserProfileGroupBox.Controls.Add(Me.Label2)
        Me.UserProfileGroupBox.Controls.Add(Me.Label1)
        Me.UserProfileGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.UserProfileGroupBox.Name = "UserProfileGroupBox"
        Me.UserProfileGroupBox.Size = New System.Drawing.Size(344, 392)
        Me.UserProfileGroupBox.TabIndex = 106
        Me.UserProfileGroupBox.TabStop = False
        Me.UserProfileGroupBox.Text = "User Profile"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Login Password :"
        '
        'LoginPasswordTxt
        '
        Me.LoginPasswordTxt.Location = New System.Drawing.Point(120, 248)
        Me.LoginPasswordTxt.Name = "LoginPasswordTxt"
        Me.LoginPasswordTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LoginPasswordTxt.Properties.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.LoginPasswordTxt.Size = New System.Drawing.Size(208, 21)
        Me.LoginPasswordTxt.TabIndex = 119
        '
        'DepartmentLookUpEdit
        '
        Me.DepartmentLookUpEdit.Location = New System.Drawing.Point(120, 296)
        Me.DepartmentLookUpEdit.Name = "DepartmentLookUpEdit"
        Me.DepartmentLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DepartmentLookUpEdit.Properties.NullString = ""
        Me.DepartmentLookUpEdit.Properties.PopupWidth = 208
        Me.DepartmentLookUpEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.DepartmentLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DepartmentLookUpEdit.Size = New System.Drawing.Size(208, 21)
        Me.DepartmentLookUpEdit.TabIndex = 118
        '
        'UserGroupLookUpEdit
        '
        Me.UserGroupLookUpEdit.Location = New System.Drawing.Point(120, 272)
        Me.UserGroupLookUpEdit.Name = "UserGroupLookUpEdit"
        Me.UserGroupLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.UserGroupLookUpEdit.Properties.NullString = ""
        Me.UserGroupLookUpEdit.Properties.PopupWidth = 208
        Me.UserGroupLookUpEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.UserGroupLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGroupLookUpEdit.Size = New System.Drawing.Size(208, 21)
        Me.UserGroupLookUpEdit.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Department :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "User Group :"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(256, 352)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 28)
        Me.CloseBtn.TabIndex = 114
        Me.CloseBtn.Text = "&Close"
        '
        'CreateNewBtn
        '
        Me.CreateNewBtn.AutoSize = False
        Me.CreateNewBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreateNewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateNewBtn.Image = Nothing
        Me.CreateNewBtn.Location = New System.Drawing.Point(16, 352)
        Me.CreateNewBtn.Name = "CreateNewBtn"
        Me.CreateNewBtn.Size = New System.Drawing.Size(72, 28)
        Me.CreateNewBtn.TabIndex = 113
        Me.CreateNewBtn.Text = "New Profile"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(176, 352)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(72, 28)
        Me.DeleteBtn.TabIndex = 112
        Me.DeleteBtn.Text = "&Delete"
        '
        'UserProfileListBox
        '
        Me.UserProfileListBox.Items.AddRange(New Object() {"aaa  |  bbbbbbbbbbbbbb"})
        Me.UserProfileListBox.Location = New System.Drawing.Point(8, 24)
        Me.UserProfileListBox.Name = "UserProfileListBox"
        Me.UserProfileListBox.Size = New System.Drawing.Size(328, 160)
        Me.UserProfileListBox.TabIndex = 111
        '
        'UserNameTxt
        '
        Me.UserNameTxt.Location = New System.Drawing.Point(120, 224)
        Me.UserNameTxt.Name = "UserNameTxt"
        Me.UserNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UserNameTxt.Size = New System.Drawing.Size(208, 21)
        Me.UserNameTxt.TabIndex = 110
        '
        'LoginIDTxt
        '
        Me.LoginIDTxt.Enabled = False
        Me.LoginIDTxt.Location = New System.Drawing.Point(120, 200)
        Me.LoginIDTxt.Name = "LoginIDTxt"
        Me.LoginIDTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LoginIDTxt.Size = New System.Drawing.Size(208, 21)
        Me.LoginIDTxt.TabIndex = 109
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(96, 352)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(72, 28)
        Me.SaveBtn.TabIndex = 107
        Me.SaveBtn.Text = "&Save"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "User Name :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Login ID :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Email :"
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(120, 320)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.emailtxt.Size = New System.Drawing.Size(208, 21)
        Me.emailtxt.TabIndex = 121
        '
        'ManageUserProfile
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 413)
        Me.Controls.Add(Me.UserProfileGroupBox)
        Me.Name = "ManageUserProfile"
        Me.Text = "Manage User Profile"
        Me.UserProfileGroupBox.ResumeLayout(False)
        CType(Me.LoginPasswordTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGroupLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginIDTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailtxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Initialization"

    Public UserID As String = Common.CommonConn.Config.USERID
    Private LoginID As String
    Private UserName As String
    Private LoginPassword As String
    Private Email As String
    Private UserGroup As Integer
    Private Department As Integer
    Dim Navds As DataSet

#End Region

#Region " Event"

    Private Sub UserProfileForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUserGroup()
        LoadDepartment()
        LoadUserProfile()
        LoadUserProfileList()

    End Sub

    Private Sub UserProfileListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserProfileListBox.SelectedIndexChanged
        UserProfileClick()
        SaveBtn.Text = "Update"
    End Sub

    Private Sub CreateNewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewBtn.Click

        SaveBtn.Text = "Save"

        LoginIDTxt.Enabled = True
        LoginIDTxt.Text = ""
        UserNameTxt.Text = ""
        LoginPasswordTxt.Text = ""
        'UserGroupLookUpEdit.Properties.LookUpData.KeyValue = ""
        'DepartmentLookUpEdit.Properties.LookUpData.KeyValue = ""
        UserGroupLookUpEdit.Properties.LookUpData.KeyValue = Integer.Parse(UserGroupLookUpEdit.Properties.LookUpData.KeyValue())
        DepartmentLookUpEdit.Properties.LookUpData.KeyValue = Integer.Parse(DepartmentLookUpEdit.Properties.LookUpData.KeyValue())

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveUserProfile()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If Len(LoginID) > 0 Then
            Dim Result As DialogResult = MessageBox.Show("Confirm to delete this User Profile?", "Delete User Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic '.Delete(UOM_ID)
                    Try
                        .Delete(LoginID)
                        MessageBox.Show("UserProfile Deleted!")
                    Catch ex As Exception
                        MessageBox.Show("Error. Cannot delete UserProfile!")
                    End Try
                End With
                LoadUserProfile()
            End If
        End If

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        'Me.Close()
        Me.Close()
    End Sub

#End Region

#Region " Database Management"

    Private Sub LoadUserProfileInfo(ByVal pUserProfile_ID As String)
        Dim ds As DataSet
        'Load unit of measurement details.
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            If .Load(pUserProfile_ID) Then
                LoginID = .LoginID
                UserName = .Name
                LoginPassword = .LoginPassword
                Email = .Email
                Department = .Department
                UserGroup = .UserGroup
            End If
        End With
        'End load unit of measurement details
    End Sub

    Private Sub SaveUserProfile()

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
                .LoginID = LoginID
                .Name = UserName
                .LoginPassword = LoginPassword
                .UserGroup = UserGroup
                .Department = Department
                .UserID = UserID
                .Email = Email

                If .RecordExists(LoginID, "") = False Then
                    Try
                        .Save(UserID)
                        MessageBox.Show("User Profile had been successfully saved!")
                    Catch ex As Exception
                        MessageBox.Show("Error. Cannot Create User Profile!")
                    End Try
                Else
                    .Update(LoginID)
                End If

                LoadUserProfile()
                'LoadUOMList()
            End With
        End If
    End Sub

#End Region

#Region " Other Code"

    Private Sub LoadUserGroup()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.UserGroup
            .GetUserGroup(ds, 0)
            If Not ds Is Nothing Then
                Try
                    UserGroupLookUpEdit.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(UserGroupLookUpEdit, "Name", 400, 0, "")
                    UserGroupLookUpEdit.Properties.LookUpData.KeyField = "Group_ID"
                    UserGroupLookUpEdit.Properties.LookUpData.DisplayField = "Name"
                    UserGroupLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    'UserGroupLookUpEdit.EditValue = "0"
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub LoadDepartment()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.Department
            .GetDepartment(ds, 0)
            If Not ds Is Nothing Then

                DepartmentLookUpEdit.Properties.LookUpData.ListFields.Clear()
                AddListFieldInfoToLookUp(DepartmentLookUpEdit, "Name", 400, 0, "")
                DepartmentLookUpEdit.Properties.LookUpData.KeyField = "Department_ID"
                DepartmentLookUpEdit.Properties.LookUpData.DisplayField = "Name"
                DepartmentLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                'DepartmentLookUpEdit.EditValue = "0"
            End If
        End With
    End Sub

    Private Sub UserProfileClick()
        If UserProfileListBox.Items.Count > 0 Then
            LoginIDTxt.Enabled = False
            LoginID = UserProfileListBox.SelectedValue.ToString
            LoadUserProfileInfo(LoginID)
            SetWindowsValue()
        End If
    End Sub
    Private Sub LoadUserProfile()
        Dim ds As DataSet
        'Load userprofile list
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            If .LoadList2(ds) Then
                If Not ds Is Nothing Then
                    Try
                        UserProfileListBox.DisplayMember = "Name"
                        UserProfileListBox.ValueMember = "Login_ID"
                        UserProfileListBox.DataSource = ds.Tables(0)

                        'Check if there is list of product
                        If ds.Tables(0).Rows.Count > 0 Then
                            UserProfileClick()
                        End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load uom list
    End Sub

    Private Sub LoadUserProfileList()
        'Dim ds As DataSet
        'Load userprofile list
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            If .LoadList2(Navds) Then
                If Not Navds Is Nothing Then
                    Try
                        LoginIDTxt.DataBindings.Add("EditValue", Navds.Tables(0).DefaultView, "Login_ID")
                        UserNameTxt.DataBindings.Add("EditValue", Navds.Tables(0).DefaultView, "Name")
                        UserGroupLookUpEdit.DataBindings.Add("EditValue", Navds.Tables(0).DefaultView, "Group_ID")
                        DepartmentLookUpEdit.DataBindings.Add("EditValue", Navds.Tables(0).DefaultView, "Department_ID")
                        'TestCmb.DataBindings.Add("EditValue", Navds.Tables(0).DefaultView, "Department_ID")
                        'UserProfileListBox.DataBindings.Add("EditValue", Navds.Tables(0).DefaultView, "Login_ID")
                        'Check if there is list of product
                        If Navds.Tables(0).Rows.Count > 0 Then
                            UserProfileClick()
                        End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load uom list
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

#End Region

#Region " Code - Set/Get Window Values"

    'For getting or setting windows values
    Private Sub SetWindowsValue()
        LoginIDTxt.Text = LoginID
        UserNameTxt.Text = UserName
        LoginPasswordTxt.Text = LoginPassword
        Me.emailtxt.Text = Email
        UserGroupLookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {UserGroup, 0, 0, 0})
        DepartmentLookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Department, 0, 0, 0})

        
    End Sub

    Private Sub GetWindowsValue()

        'pName = AddUOMTxt.Text
        'Description = AddUOMDescTxt.Text
        LoginID = LoginIDTxt.Text
        UserName = UserNameTxt.Text
        LoginPassword = LoginPasswordTxt.Text
        Email = Me.emailtxt.Text

        If UserGroupLookUpEdit.Text <> "" Or UserGroupLookUpEdit.Text = Nothing Then
            UserGroup = Integer.Parse(UserGroupLookUpEdit.Properties.LookUpData.KeyValue().ToString())
        Else
            UserGroup = -1
        End If
        If DepartmentLookUpEdit.Text <> "" Or DepartmentLookUpEdit.Text = Nothing Then
            Department = Integer.Parse(DepartmentLookUpEdit.Properties.LookUpData.KeyValue().ToString())
        Else
            Department = -1
        End If

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If UserName = "" Then
            ErrorMessage = ErrorMessage & " UserName" & Chr(13)
            DataOK_flag = False
        End If

        If LoginID = "" Then
            ErrorMessage = ErrorMessage & " LoginID" & Chr(13)
            DataOK_flag = False
        End If

        If UserGroup = Nothing Or UserGroup = 0 Then
            ErrorMessage = ErrorMessage & " User Group" & Chr(13)
            DataOK_flag = False
        End If

        If Department = Nothing Or Department = 0 Then
            ErrorMessage = ErrorMessage & " Department" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            'With New BusinessRules.ManUOMBusRules.ManUOMBusLogic
            'If LoginID <> Nothing And LoginID <> 0 Then
            'If .RecordExists(UserName, LoginID) Then
            'MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'DataOK_flag = False
            'End If
            'Else
            'If .RecordExists(UserName, Nothing) Then
            'MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'DataOK_flag = False
            'End If
            'End If
            'End With
        End If

        Return DataOK_flag

    End Function

#End Region


    Private Sub UserGroupLookUpEdit_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles UserGroupLookUpEdit.CloseUp
        UserGroup = Integer.Parse(UserGroupLookUpEdit.Properties.LookUpData.KeyValue().ToString())
        'MsgBox(UserGroup)
    End Sub

    Private Sub DepartmentLookUpEdit_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles DepartmentLookUpEdit.CloseUp
        Department = Integer.Parse(DepartmentLookUpEdit.Properties.LookUpData.KeyValue().ToString())
    End Sub

    Private Sub ManageUserProfile_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
