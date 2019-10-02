Public Class ManageWHArea
    Inherits System.Windows.Forms.Form

#Region "Warehouse Variables Initialization"
    Public Warehouse_ID As Integer
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Parent As MainForm, ByVal pWarehouse_ID As String)
        MyBase.New()

        ParentObject = Parent
        Warehouse_ID = pWarehouse_ID

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
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CreateNewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WHAreaListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddWHAreaDescTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddWHAreaTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreateNewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.WHAreaListBox = New System.Windows.Forms.ListBox
        Me.AddWHAreaDescTxt = New DevExpress.XtraEditors.TextEdit
        Me.AddWHAreaTxt = New DevExpress.XtraEditors.TextEdit
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddWHAreaDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddWHAreaTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CloseBtn)
        Me.GroupBox1.Controls.Add(Me.CreateNewBtn)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.WHAreaListBox)
        Me.GroupBox1.Controls.Add(Me.AddWHAreaDescTxt)
        Me.GroupBox1.Controls.Add(Me.AddWHAreaTxt)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 256)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Warehouse Area"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(320, 208)
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
        Me.CreateNewBtn.Location = New System.Drawing.Point(224, 104)
        Me.CreateNewBtn.Name = "CreateNewBtn"
        Me.CreateNewBtn.Size = New System.Drawing.Size(160, 32)
        Me.CreateNewBtn.TabIndex = 113
        Me.CreateNewBtn.Text = "Create New Warehouse Area"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(248, 208)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(64, 32)
        Me.DeleteBtn.TabIndex = 112
        Me.DeleteBtn.Text = "&Delete"
        '
        'WHAreaListBox
        '
        Me.WHAreaListBox.Items.AddRange(New Object() {"aaa  |  bbbbbbbbbbbbbb"})
        Me.WHAreaListBox.Location = New System.Drawing.Point(16, 24)
        Me.WHAreaListBox.Name = "WHAreaListBox"
        Me.WHAreaListBox.Size = New System.Drawing.Size(368, 69)
        Me.WHAreaListBox.TabIndex = 111
        '
        'AddWHAreaDescTxt
        '
        Me.AddWHAreaDescTxt.Location = New System.Drawing.Point(144, 176)
        Me.AddWHAreaDescTxt.Name = "AddWHAreaDescTxt"
        Me.AddWHAreaDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddWHAreaDescTxt.Size = New System.Drawing.Size(240, 21)
        Me.AddWHAreaDescTxt.TabIndex = 110
        '
        'AddWHAreaTxt
        '
        Me.AddWHAreaTxt.Location = New System.Drawing.Point(144, 144)
        Me.AddWHAreaTxt.Name = "AddWHAreaTxt"
        Me.AddWHAreaTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddWHAreaTxt.Size = New System.Drawing.Size(120, 21)
        Me.AddWHAreaTxt.TabIndex = 109
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(176, 208)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 107
        Me.SaveBtn.Text = "&Save"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "WH  Area Name:"
        '
        'ManageWHArea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 277)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageWHArea"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage WareHouse Area"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AddWHAreaDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddWHAreaTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Warehouse Area Variables Initialization"

    Private WHArea_ID As Integer
    Private pName As String
    Private Description As String
    Private UserID As Integer = Common.CommonConn.Config.USERID

#End Region

    Dim FunctionName As String = "MyWHArea"
    Dim ParentObject
#Region " Event"

    Private Sub WHAreaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As MainForm = ParentObject 'Me.ParentForm
        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            CreateNewBtn.Enabled = True
            SaveBtn.Enabled = True
        Else
            CreateNewBtn.Enabled = False
            SaveBtn.Enabled = False
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

        LoadWHAreaList(Warehouse_ID)
    End Sub

    Private Sub WHAreaListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WHAreaListBox.SelectedIndexChanged
        WHAreaClick()
        SaveBtn.Text = "Update"
    End Sub

    Private Sub CreateNewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewBtn.Click

        SaveBtn.Text = "Save"

        AddWHAreaTxt.Text = ""
        AddWHAreaDescTxt.Text = ""
        WHArea_ID = Nothing

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveWHArea()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If WHArea_ID <> Nothing And WHArea_ID <> 0 Then
            Dim Result As DialogResult = MessageBox.Show("Are you sure you delete this Warehouse Area?", "Delete Warehouse Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.WHAreaBusRules.WHAreaClss
                    .DeleteWarehouseArea(WHArea_ID)
                    LoadWHAreaList(Warehouse_ID)
                End With
            End If
        End If

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
        'Dim a As MainForm = Me.ParentForm
        'If (a.MainTabControl.TabPages.Count > 0) Then
        'If Not (a.MainTabControl.SelectedTab Is Nothing) Then
        'a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
        'End If
        'End If
    End Sub

#End Region

#Region " Database Management"

    Private Sub LoadWHAreaInfo(ByVal pWHArea_ID As String)
        Dim ds As DataSet
        'Load Warehouse Area details.
        With New BusinessRules.WHAreaBusRules.WHAreaClss
            If .Load(pWHArea_ID) Then

                pName = .Warehouse_Area
                Description = .Description
                UserID = .UserID
            End If
        End With
        'End load Warehouse Area details
    End Sub

    Private Sub SaveWHArea()

        GetWindowsValue()

        If ValidData() Then

            With New BusinessRules.WHAreaBusRules.WHAreaClss

                .Warehouse_Area = pName
                .Description = Description
                .UserID = UserID

                If WHArea_ID = Nothing Or WHArea_ID = 0 Then
                    .SaveWarehouseArea(Warehouse_ID)
                    WHArea_ID = .Warehouse_Area_ID

                    With New BusinessRules.WHLocationBusRules.WHLocationClss
                        .SaveWarehouseLOcation(Warehouse_ID, WHArea_ID)
                    End With
                Else
                    .UpdateWarehouseArea(WHArea_ID)
                End If

                LoadWHAreaList(Warehouse_ID)
            End With
        End If
    End Sub

#End Region

#Region " Other Code"

    Private Sub WHAreaClick()
        If WHAreaListBox.Items.Count > 0 Then
            'WHAreaListBox.SelectedIndex = 0
            WHArea_ID = WHAreaListBox.SelectedValue.ToString
            'WHArea_ID = 1
            LoadWHAreaInfo(WHArea_ID)
            SetWindowsValue()
        End If
    End Sub

    Private Sub LoadWHAreaList(ByVal pWarehouse_ID As String)
        Dim ds As DataSet
        'Load Warehouse Area list
        With New BusinessRules.WHAreaBusRules.WHAreaClss
            If .LoadList2(ds, pWarehouse_ID) Then  ' .GetWarehouseArea(ds, pWarehouse_ID) Then
                If Not ds Is Nothing Then
                    Try
                        WHAreaListBox.DisplayMember = "Warehouse_Area"
                        WHAreaListBox.ValueMember = "Warehouse_Area_ID"

                        WHAreaListBox.DataSource = ds.Tables(0)

                        'Check if there is list of Warehouse Area
                        If ds.Tables(0).Rows.Count > 0 Then
                            'WHAreaClick()
                        End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load Warehouse Area list
    End Sub

#End Region

#Region " Code - Set/Get Window Values"

    'For getting or setting windows values
    Private Sub SetWindowsValue()

        AddWHAreaTxt.Text = pName
        AddWHAreaDescTxt.Text = Description

    End Sub

    Private Sub GetWindowsValue()

        pName = AddWHAreaTxt.Text
        Description = AddWHAreaDescTxt.Text

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
            With New BusinessRules.WHAreaBusRules.WHAreaClss
                If WHArea_ID <> Nothing And WHArea_ID <> 0 Then
                    If .RecordExists(pName, Warehouse_ID, WHArea_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(pName, Warehouse_ID, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function

#End Region

End Class
