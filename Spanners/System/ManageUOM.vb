Public Class UOMForm
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
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UOMListBox As System.Windows.Forms.ListBox
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AddUOMDescTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddUOMTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreateNewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreateNewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.UOMListBox = New System.Windows.Forms.ListBox
        Me.AddUOMDescTxt = New DevExpress.XtraEditors.TextEdit
        Me.AddUOMTxt = New DevExpress.XtraEditors.TextEdit
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddUOMDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddUOMTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CloseBtn)
        Me.GroupBox1.Controls.Add(Me.CreateNewBtn)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.UOMListBox)
        Me.GroupBox1.Controls.Add(Me.AddUOMDescTxt)
        Me.GroupBox1.Controls.Add(Me.AddUOMTxt)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 344)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unit Of Measurement"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(256, 304)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 114
        Me.CloseBtn.Text = "&Close"
        '
        'CreateNewBtn
        '
        Me.CreateNewBtn.AutoSize = False
        Me.CreateNewBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreateNewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateNewBtn.Image = Nothing
        Me.CreateNewBtn.Location = New System.Drawing.Point(224, 208)
        Me.CreateNewBtn.Name = "CreateNewBtn"
        Me.CreateNewBtn.Size = New System.Drawing.Size(97, 32)
        Me.CreateNewBtn.TabIndex = 113
        Me.CreateNewBtn.Text = "Create New UOM"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(184, 304)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(64, 32)
        Me.DeleteBtn.TabIndex = 112
        Me.DeleteBtn.Text = "&Delete"
        '
        'UOMListBox
        '
        Me.UOMListBox.Items.AddRange(New Object() {"aaa  |  bbbbbbbbbbbbbb"})
        Me.UOMListBox.Location = New System.Drawing.Point(16, 24)
        Me.UOMListBox.Name = "UOMListBox"
        Me.UOMListBox.Size = New System.Drawing.Size(304, 173)
        Me.UOMListBox.TabIndex = 111
        '
        'AddUOMDescTxt
        '
        Me.AddUOMDescTxt.Location = New System.Drawing.Point(112, 272)
        Me.AddUOMDescTxt.Name = "AddUOMDescTxt"
        Me.AddUOMDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddUOMDescTxt.Size = New System.Drawing.Size(208, 21)
        Me.AddUOMDescTxt.TabIndex = 110
        '
        'AddUOMTxt
        '
        Me.AddUOMTxt.Location = New System.Drawing.Point(112, 248)
        Me.AddUOMTxt.Name = "AddUOMTxt"
        Me.AddUOMTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddUOMTxt.Size = New System.Drawing.Size(208, 21)
        Me.AddUOMTxt.TabIndex = 109
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(112, 304)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 107
        Me.SaveBtn.Text = "&Save"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Add New UOM :"
        '
        'UOMForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UOMForm"
        Me.Text = "Manage Unit of Measurement"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AddUOMDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddUOMTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Initialization"

    Private UOM_ID As Integer
    Private pName As String
    Private Description As String
    Private UserID As Integer = Common.CommonConn.Config.USERID

#End Region

    ' 05.01.2004 YG Start
    Dim FunctionName As String = "MyUOM"
    ' 05.01.2004 YG End

#Region " Event"

    Private Sub UOMForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 10.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            CreateNewBtn.Enabled = True
        Else
            CreateNewBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DeleteBtn.Enabled = True
        Else
            DeleteBtn.Enabled = False
        End If
        ' 10.01.2004 YG End

        LoadUOMList()
    End Sub

    Private Sub UOMListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UOMListBox.SelectedIndexChanged
        UOMClick()
        SaveBtn.Text = "Update"
    End Sub

    Private Sub CreateNewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewBtn.Click

        SaveBtn.Text = "Save"

        AddUOMTxt.Text = ""
        AddUOMDescTxt.Text = ""
        UOM_ID = Nothing

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveUOM()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If UOM_ID <> Nothing And UOM_ID <> 0 Then
            Dim Result As DialogResult = MessageBox.Show("Are you sure you delete this UOM?", "Delete UOM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.ManUOMBusRules.ManUOMBusLogic
                    .Delete(UOM_ID)
                    LoadUOMList()
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

    Private Sub LoadUOMInfo(ByVal pUOM_ID As String)
        Dim ds As DataSet
        'Load unit of measurement details.
        With New BusinessRules.ManUOMBusRules.ManUOMBusLogic
            If .Load(pUOM_ID) Then

                pName = .Name
                Description = .Description
                UserID = .UserID
            End If
        End With
        'End load unit of measurement details
    End Sub

    Private Sub SaveUOM()

        GetWindowsValue()

        If ValidData() Then

            With New BusinessRules.ManUOMBusRules.ManUOMBusLogic

                .Name = pName
                .Description = Description
                .UserID = UserID

                If UOM_ID = Nothing Or UOM_ID = 0 Then
                    UOM_ID = .Save()
                    MessageBox.Show("UOM Saved!", "Manage UOM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .Update(UOM_ID)
                    MessageBox.Show("UOM Updated!", "Manage UOM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                LoadUOMList()
            End With
        End If
    End Sub

#End Region

#Region " Other Code"

    Private Sub UOMClick()
        If UOMListBox.Items.Count > 0 Then
            UOM_ID = UOMListBox.SelectedValue.ToString
            LoadUOMInfo(UOM_ID)
            SetWindowsValue()
        End If
    End Sub

    Private Sub LoadUOMList()
        Dim ds As DataSet
        'Load uom list
        With New BusinessRules.ManUOMBusRules.ManUOMBusLogic
            If .LoadList2(ds) Then
                If Not ds Is Nothing Then
                    Try
                        UOMListBox.DisplayMember = "Name"
                        UOMListBox.ValueMember = "UOM_ID"

                        UOMListBox.DataSource = ds.Tables(0)

                        'Check if there is list of product
                        If ds.Tables(0).Rows.Count > 0 Then
                            UOMClick()
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

        AddUOMTxt.Text = pName
        AddUOMDescTxt.Text = Description

    End Sub

    Private Sub GetWindowsValue()

        pName = AddUOMTxt.Text
        Description = AddUOMDescTxt.Text

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If pName = "" Then
            ErrorMessage = ErrorMessage & " Name" & Chr(13)
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
            With New BusinessRules.ManUOMBusRules.ManUOMBusLogic
                If UOM_ID <> Nothing And UOM_ID <> 0 Then
                    If .RecordExists(pName, UOM_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(pName, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function

#End Region

    Private Sub UOMForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
