Public Class ManageWH
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
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CreateNewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WHListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddWHDescTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddWHTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreateWHAreaBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ManageWH))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CreateWHAreaBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreateNewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.WHListBox = New System.Windows.Forms.ListBox
        Me.AddWHDescTxt = New DevExpress.XtraEditors.TextEdit
        Me.AddWHTxt = New DevExpress.XtraEditors.TextEdit
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddWHDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddWHTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CreateWHAreaBtn)
        Me.GroupBox1.Controls.Add(Me.CloseBtn)
        Me.GroupBox1.Controls.Add(Me.CreateNewBtn)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.WHListBox)
        Me.GroupBox1.Controls.Add(Me.AddWHDescTxt)
        Me.GroupBox1.Controls.Add(Me.AddWHTxt)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 256)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Warehouse"
        '
        'CreateWHAreaBtn
        '
        Me.CreateWHAreaBtn.AutoSize = False
        Me.CreateWHAreaBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreateWHAreaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateWHAreaBtn.Image = Nothing
        Me.CreateWHAreaBtn.Location = New System.Drawing.Point(240, 104)
        Me.CreateWHAreaBtn.Name = "CreateWHAreaBtn"
        Me.CreateWHAreaBtn.Size = New System.Drawing.Size(136, 32)
        Me.CreateWHAreaBtn.TabIndex = 115
        Me.CreateWHAreaBtn.Text = "Create Warehouse Area"
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
        Me.CreateNewBtn.Location = New System.Drawing.Point(96, 104)
        Me.CreateNewBtn.Name = "CreateNewBtn"
        Me.CreateNewBtn.Size = New System.Drawing.Size(136, 32)
        Me.CreateNewBtn.TabIndex = 113
        Me.CreateNewBtn.Text = "Create New Warehouse"
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
        'WHListBox
        '
        Me.WHListBox.Location = New System.Drawing.Point(16, 24)
        Me.WHListBox.Name = "WHListBox"
        Me.WHListBox.Size = New System.Drawing.Size(368, 69)
        Me.WHListBox.TabIndex = 111
        '
        'AddWHDescTxt
        '
        Me.AddWHDescTxt.Location = New System.Drawing.Point(144, 176)
        Me.AddWHDescTxt.Name = "AddWHDescTxt"
        Me.AddWHDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddWHDescTxt.Size = New System.Drawing.Size(240, 21)
        Me.AddWHDescTxt.TabIndex = 110
        '
        'AddWHTxt
        '
        Me.AddWHTxt.Location = New System.Drawing.Point(144, 144)
        Me.AddWHTxt.Name = "AddWHTxt"
        Me.AddWHTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddWHTxt.Size = New System.Drawing.Size(120, 21)
        Me.AddWHTxt.TabIndex = 109
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
        Me.Label1.Text = "Warehouse  name:"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ManageWH
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 269)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageWH"
        Me.Text = "Manage Warehouse"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AddWHDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddWHTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Initialization"

    Private Warehouse_ID As Integer
    Private pWarehouse As String
    Private Description As String
    Private UserID As Integer = Common.CommonConn.Config.USERID

#End Region

    Dim FunctionName As String = "MyWH"
    Dim NextScreen As String = "MyWHArea"

#Region " Event"

    Private Sub ManageWH_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As MainForm = Me.ParentForm
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

        If a.com.CheckUserProfileAccess(a.com, NextScreen) Then
            CreateWHAreaBtn.Enabled = True
        Else
            CreateWHAreaBtn.Enabled = False
        End If

        LoadWHList()
    End Sub

    Private Sub WHListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WHListBox.SelectedIndexChanged
        WHClick()
        SaveBtn.Text = "Update"
    End Sub

    Private Sub CreateNewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewBtn.Click
        SaveBtn.Text = "Save"

        AddWHTxt.Text = ""
        AddWHDescTxt.Text = ""
        Warehouse_ID = Nothing

    End Sub

    Private Sub CreateWHAreaBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateWHAreaBtn.Click
        'Call WH Area Form to create Warehouse Area
        Warehouse_ID = WHListBox.SelectedValue.ToString

        If (Warehouse_ID > 0) Then
            Dim form As New ManageWHArea(Me.ParentForm, Warehouse_ID)
            form.ShowDialog(Me)

            'Dim a As MainForm = Me.ParentForm
            'Dim controlToAdd As Control = Nothing
            'controlToAdd = New ManageWHArea(Warehouse_ID)
            'Me.Cursor = Cursors.WaitCursor

            'Dim page As Crownwood.Magic.Controls.TabPage
            'page = New Crownwood.Magic.Controls.TabPage("Create Warehouse Area", controlToAdd, ImageList1, 0)
            'page.Selected = True
            'a.MainTabControl.TabPages.Add(page)
            'Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveWH()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If Warehouse_ID <> Nothing And Warehouse_ID <> 0 Then
            Dim Result As DialogResult = MessageBox.Show("Are you sure you delete this Warehouse?", "Delete Warehouse", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.WHBusRules.WHBusLogic
                    .DeleteWarehouse(Warehouse_ID)
                    LoadWHList()
                End With
            End If
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
        
    End Sub

#End Region


#Region " Database Management"

    Private Sub LoadWHInfo(ByVal pWH_ID As String)
        Dim ds As DataSet
        'Load unit of measurement details.
        With New BusinessRules.WHBusRules.WHBusLogic
            If .Load(pWH_ID) Then
                pWarehouse = .Warehouse
                    Description = .Description
                    UserID = .UserID
            End If
        End With
        'End load unit of measurement details
    End Sub

    Private Sub SaveWH()

        GetWindowsValue()

        If ValidData() Then

            With New BusinessRules.WHBusRules.WHBusLogic

                .Warehouse = pWarehouse
                .Description = Description
                .UserID = UserID

                If Warehouse_ID = Nothing Or Warehouse_ID = 0 Then
                    Warehouse_ID = .SaveWarehouse()
                    MessageBox.Show("Warehouse Saved!", "Manage Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .UpdateWarehouse(Warehouse_ID)
                    MessageBox.Show("Warehouse Updated!", "Manage Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                LoadWHList()
            End With
        End If
    End Sub

#End Region


#Region " Other Code"
    Private Sub WHClick()
        If WHListBox.Items.Count > 0 Then
            Warehouse_ID = WHListBox.SelectedValue.ToString
            LoadWHInfo(Warehouse_ID)
            SetWindowsValue()
        End If
    End Sub

    Private Sub LoadWHList()
        Dim ds As DataSet
        'Load WH list
        With New BusinessRules.WHBusRules.WHBusLogic
            If .LoadList2(ds) Then '.GetWarehouse(ds, 0) Then
                If Not ds Is Nothing Then
                    Try
                        WHListBox.DisplayMember = "Warehouse"
                        WHListBox.ValueMember = "Warehouse_ID"

                        WHListBox.DataSource = ds.Tables(0)

                        'Check if there is list of product
                        If ds.Tables(0).Rows.Count > 0 Then
                            WHClick()
                        End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load WH list
    End Sub

#End Region

#Region " Code - Set/Get Window Values"

    'For getting or setting windows values
    Private Sub SetWindowsValue()

        AddWHTxt.Text = pWarehouse
        AddWHDescTxt.Text = Description

    End Sub

    Private Sub GetWindowsValue()

        pWarehouse = AddWHTxt.Text
        Description = AddWHDescTxt.Text

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If pWarehouse = "" Then
            ErrorMessage = ErrorMessage & " Warehouse" & Chr(13)
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
            With New BusinessRules.WHBusRules.WHBusLogic
                If Warehouse_ID <> Nothing And Warehouse_ID <> 0 Then
                    If .RecordExists(pWarehouse, Warehouse_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(pWarehouse, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function

#End Region

    Private Sub ManageWH_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
