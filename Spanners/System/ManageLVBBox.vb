Public Class ManageLVBBoxForm
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BoxNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents BoxList As System.Windows.Forms.ListBox
    Friend WithEvents NewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddBoxDescTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.AddBoxDescTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.DelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.BoxList = New System.Windows.Forms.ListBox
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.BoxNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddBoxDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddBoxDescTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DelBtn)
        Me.GroupBox1.Controls.Add(Me.NewBtn)
        Me.GroupBox1.Controls.Add(Me.BoxList)
        Me.GroupBox1.Controls.Add(Me.CloseBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.BoxNameTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 352)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'AddBoxDescTxt
        '
        Me.AddBoxDescTxt.Location = New System.Drawing.Point(96, 280)
        Me.AddBoxDescTxt.Name = "AddBoxDescTxt"
        Me.AddBoxDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBoxDescTxt.Size = New System.Drawing.Size(192, 21)
        Me.AddBoxDescTxt.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Description :"
        '
        'DelBtn
        '
        Me.DelBtn.AutoSize = False
        Me.DelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.Image = Nothing
        Me.DelBtn.Location = New System.Drawing.Point(160, 312)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(56, 32)
        Me.DelBtn.TabIndex = 89
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.Visible = False
        '
        'NewBtn
        '
        Me.NewBtn.AutoSize = False
        Me.NewBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBtn.Image = Nothing
        Me.NewBtn.Location = New System.Drawing.Point(224, 224)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(64, 24)
        Me.NewBtn.TabIndex = 88
        Me.NewBtn.Text = "New Box"
        Me.NewBtn.Visible = False
        '
        'BoxList
        '
        Me.BoxList.Location = New System.Drawing.Point(8, 16)
        Me.BoxList.Name = "BoxList"
        Me.BoxList.Size = New System.Drawing.Size(280, 199)
        Me.BoxList.TabIndex = 87
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(224, 312)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(96, 312)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(56, 32)
        Me.SaveBtn.TabIndex = 5
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.Visible = False
        '
        'BoxNameTxt
        '
        Me.BoxNameTxt.Location = New System.Drawing.Point(96, 256)
        Me.BoxNameTxt.Name = "BoxNameTxt"
        Me.BoxNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxNameTxt.Size = New System.Drawing.Size(192, 19)
        Me.BoxNameTxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "* Box Name :"
        '
        'ManageLVBBoxForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageLVBBoxForm"
        Me.Text = "LVB Box Type"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AddBoxDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Initialization"

    Public Box_Type_Id As Integer
    Public Box_Name As String
    Private Description As String
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
#End Region
    ' 08.01.2004 YG Start
    Dim FunctionName As String = "MyLVBType"
    ' 08.01.2004 YG End

    'Private Sub ManageLVBBoxForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    LoadLVBBox()
    'End Sub

    'Private Sub ResetForm()
    '    BoxNameTxt.Text = ""
    '    AddBoxDescTxt.Text = ""
    'End Sub

    'Private Sub LoadLVBBox()
    '    Dim ds As DataSet
    '   With New BusinessRules.SystemBusRules.LVBBoxBusLogic
    '      If .GetLVBBox(ds) Then
    '         If Not ds Is Nothing Then
    '            Try
    '               BoxList.DisplayMember = "Box_Name"
    '              BoxList.ValueMember = "Box_Type_Id"

    '             BoxList.DataSource = ds.Tables(0)
    '        Catch exLoad As System.Exception
    '           System.Windows.Forms.MessageBox.Show(exLoad.Message)
    '      End Try
    ' End If
    'End If
    '    End With
    'End Sub

    'Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
    '   If ValidData() Then
    '      If Not BoxNameExist() Then
    '         With New BusinessRules.SystemBusRules.LVBBoxBusLogic
    '            .Box_Name = Box_Name
    '           .UserID = UserID

    '          If Box_Type_Id = 0 Or Box_Type_Id = Nothing Then
    '             If .SaveLVBBox() Then
    '                MessageBox.Show("Box Type saved. ", "Box Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '           End If
    '      Else
    '         .UpdateLVBBox(Box_Type_Id)
    '        MessageBox.Show("Box Type updated. ", "Box Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '   End If
    '  LoadLVBBox()
    ' ResetForm()
    'End With
    'Else
    '   MessageBox.Show("LVB Box already exist !", "Manage LVB Box", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  Exit Sub
    'End If
    'End If
    'End Sub

    'Private Function ValidData() As Boolean
    '    Dim DataOK_Flag As Boolean = True
    '    Dim FieldName As String

    '   Box_Name = BoxNameTxt.Text
    '  If Not Len(Box_Name) > 0 Then
    '     DataOK_Flag = False
    '    FieldName = "Box Name" & Chr(13)
    'End If

    'If Not DataOK_Flag Then
    '   With New Common.CommonError.ErrorMsg
    '      MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    ' End With
    'End If
    'ValidData = DataOK_Flag
    'End Function

    'Private Function BoxNameExist() As Boolean
    '   Dim NameExist_Flag As Boolean = False
    '  Dim dsBox As DataSet
    ' Dim rowCount As Integer
    'Dim i As Integer

    'With New BusinessRules.SystemBusRules.LVBBoxBusLogic
    '   If .GetLVBBox(dsBox) Then
    '      rowCount = dsBox.Tables(0).Rows.Count()
    '     For i = 0 To (rowCount - 1)
    '        If UCase(Box_Name) = UCase(dsBox.Tables(0).Rows(i).Item("Box_Name")) Then
    '           NameExist_Flag = True
    '          Exit For
    '     Else
    '        NameExist_Flag = False
    '   End If
    'Next i
    'End If
    'End With
    'BoxNameExist = NameExist_Flag
    'End Function

    'Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
    '   Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Box Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '  If Result = DialogResult.Yes Then
    '     Box_Type_Id = BoxList.SelectedValue.ToString
    '    With New BusinessRules.SystemBusRules.LVBBoxBusLogic
    '       .Box_Type_Id = Box_Type_Id
    '      If .DeleteLVBBox() Then
    '         MessageBox.Show("Box Type deleted. ", "Box Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        LoadLVBBox()
    '   End If
    'End With
    'End If
    'End Sub

    'Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
    '   Dim a As MainForm = Me.ParentForm
    '  If (a.MainTabControl.TabPages.Count > 0) Then
    '     If Not (a.MainTabControl.SelectedTab Is Nothing) Then
    '        a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
    '   End If
    'End If
    'End Sub

    'Private Sub NewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click
    '    SaveBtn.Text = "Save"

    '   BoxNameTxt.Text = ""
    '  AddBoxDescTxt.Text = ""
    ' Box_Type_Id = Nothing
    'End Sub

    'Private Sub BoxList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxList.SelectedIndexChanged
    '   DelBtn.Enabled = True
    '  Box_Type_Id = BoxList.SelectedValue.ToString
    ' Dim ds As DataSet

    'With New BusinessRules.SystemBusRules.LVBBoxBusLogic
    '   If .GetLVBBox(ds, Box_Type_Id) Then
    '      BoxNameTxt.Text = ds.Tables(0).Rows(0)("Box_Name")
    ' End If
    'End With
    'SaveBtn.Text = "Update"
    'End Sub

#Region " Event"

    Private Sub ManageLVBBoxForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 08.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewBtn.Enabled = True
        Else
            NewBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DelBtn.Enabled = True
        Else
            DelBtn.Enabled = False
        End If
        ' 08.01.2004 YG End
        LoadBoxList()
    End Sub

    Private Sub BoxList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxList.SelectedIndexChanged
        BoxClick()
        SaveBtn.Text = "Update"
    End Sub

    Private Sub CreateNewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click

        SaveBtn.Text = "Save"

        BoxNameTxt.Text = ""
        AddBoxDescTxt.Text = ""
        Box_Type_Id = Nothing

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveBox()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If Box_Type_Id <> Nothing And Box_Type_Id <> 0 Then
            Dim Result As DialogResult = MessageBox.Show("Are you sure you delete this LVB Box Type?", "Delete LVB Box Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.SystemBusRules.LVBBoxBusLogic
                    .Delete(Box_Type_Id)
                    LoadBoxList()
                End With
            End If
        End If

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        'Me.Close()
        Me.Close()
    End Sub

#End Region

#Region " Database Management"

    Private Sub LoadBoxInfo(ByVal pBox_Type_Id As String)
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.LVBBoxBusLogic
            If .Load(pBox_Type_Id) Then

                Box_Name = .Box_Name
                Description = .Description
                UserID = .UserID
            End If
        End With
        'End load unit of measurement details
    End Sub

    Private Sub SaveBox()

        GetWindowsValue()

        If ValidData() Then

            With New BusinessRules.SystemBusRules.LVBBoxBusLogic

                .Box_Name = Box_Name
                .Description = Description
                .UserID = UserID

                If Box_Type_Id = Nothing Or Box_Type_Id = 0 Then
                    Box_Type_Id = .Save()
                    MessageBox.Show("LVB Box Type Saved!", "Manage LVB Box Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .Update(Box_Type_Id)
                    MessageBox.Show("LVB Box Type Updated!", "Manage LVB Box Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                LoadBoxList()
            End With
        End If
    End Sub

#End Region

#Region " Other Code"

    Private Sub BoxClick()
        If BoxList.Items.Count > 0 Then
            Box_Type_Id = BoxList.SelectedValue.ToString
            LoadBoxInfo(Box_Type_Id)
            SetWindowsValue()
        End If
    End Sub

    Private Sub LoadBoxList()
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.LVBBoxBusLogic
            If .LoadList2(ds) Then
                If Not ds Is Nothing Then
                    Try
                        BoxList.DisplayMember = "Box_Name"
                        BoxList.ValueMember = "Box_Type_ID"

                        BoxList.DataSource = ds.Tables(0)

                        'Check if there is list of product
                        If ds.Tables(0).Rows.Count > 0 Then
                            BoxClick()
                        End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load uom list
    End Sub

#End Region

#Region " Code - Set/Get Window Values"

    'For getting or setting windows values
    Private Sub SetWindowsValue()

        BoxNameTxt.Text = Box_Name
        AddBoxDescTxt.Text = Description

    End Sub

    Private Sub GetWindowsValue()

        Box_Name = BoxNameTxt.Text
        Description = AddBoxDescTxt.Text

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If Box_Name = "" Then
            ErrorMessage = ErrorMessage & " Box_Name" & Chr(13)
            DataOK_flag = False
        End If

        If Description = "" Then
            ErrorMessage = ErrorMessage & " Description" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.SystemBusRules.LVBBoxBusLogic
                If Box_Type_Id <> Nothing And Box_Type_Id <> 0 Then
                    If .RecordExists(Box_Name, Box_Type_Id) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Box Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(Box_Name, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Box Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function

#End Region

    Private Sub ManageLVBBoxForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
