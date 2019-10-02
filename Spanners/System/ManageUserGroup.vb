Public Class ManageUserGroup
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
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CreateNewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents UserGroupListBox As System.Windows.Forms.ListBox
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents UserGroupdescriptionTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserGroupNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserGroupFuncGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ApprovalItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents UpdateItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents InsertItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DeleteItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ScreenNameItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ScreenName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Insert As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Approval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccessRight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccessRightItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ModuleTree As System.Windows.Forms.TreeView
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Modify As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UserGroupBox = New System.Windows.Forms.GroupBox
        Me.UserGroupListBox = New System.Windows.Forms.ListBox
        Me.UserGroupdescriptionTxt = New DevExpress.XtraEditors.TextEdit
        Me.UserGroupNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UserGroupFuncGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ApprovalItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.UpdateItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.InsertItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.DeleteItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ScreenNameItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.AccessRightItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreateNewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ModuleTree = New System.Windows.Forms.TreeView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.UserGroupBox.SuspendLayout()
        CType(Me.UserGroupdescriptionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGroupNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGroupFuncGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovalItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsertItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeleteItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreenNameItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessRightItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserGroupBox
        '
        Me.UserGroupBox.Controls.Add(Me.UserGroupListBox)
        Me.UserGroupBox.Controls.Add(Me.UserGroupdescriptionTxt)
        Me.UserGroupBox.Controls.Add(Me.UserGroupNameTxt)
        Me.UserGroupBox.Controls.Add(Me.Label2)
        Me.UserGroupBox.Controls.Add(Me.Label1)
        Me.UserGroupBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.UserGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.UserGroupBox.Name = "UserGroupBox"
        Me.UserGroupBox.Size = New System.Drawing.Size(339, 370)
        Me.UserGroupBox.TabIndex = 107
        Me.UserGroupBox.TabStop = False
        Me.UserGroupBox.Text = "User Groups & Functions"
        '
        'UserGroupListBox
        '
        Me.UserGroupListBox.Items.AddRange(New Object() {"aaa  |  bbbbbbbbbbbbbb"})
        Me.UserGroupListBox.Location = New System.Drawing.Point(8, 20)
        Me.UserGroupListBox.Name = "UserGroupListBox"
        Me.UserGroupListBox.Size = New System.Drawing.Size(264, 199)
        Me.UserGroupListBox.TabIndex = 111
        '
        'UserGroupdescriptionTxt
        '
        Me.UserGroupdescriptionTxt.Location = New System.Drawing.Point(8, 302)
        Me.UserGroupdescriptionTxt.Name = "UserGroupdescriptionTxt"
        Me.UserGroupdescriptionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UserGroupdescriptionTxt.Size = New System.Drawing.Size(264, 21)
        Me.UserGroupdescriptionTxt.TabIndex = 110
        '
        'UserGroupNameTxt
        '
        Me.UserGroupNameTxt.Location = New System.Drawing.Point(8, 246)
        Me.UserGroupNameTxt.Name = "UserGroupNameTxt"
        Me.UserGroupNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UserGroupNameTxt.Size = New System.Drawing.Size(264, 21)
        Me.UserGroupNameTxt.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "* User Group Description :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "* User Group Name :"
        '
        'UserGroupFuncGrid
        '
        Me.UserGroupFuncGrid.EditorsRepository = Me.PersistentRepository1
        Me.UserGroupFuncGrid.Location = New System.Drawing.Point(371, 306)
        Me.UserGroupFuncGrid.MainView = Me.GridView2
        Me.UserGroupFuncGrid.Name = "UserGroupFuncGrid"
        Me.UserGroupFuncGrid.Size = New System.Drawing.Size(104, 58)
        Me.UserGroupFuncGrid.TabIndex = 115
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ApprovalItemCheckEdit1, Me.UpdateItemCheckEdit2, Me.InsertItemCheckEdit3, Me.DeleteItemCheckEdit4, Me.ScreenNameItemTextEdit, Me.AccessRightItemCheckEdit, Me.RepositoryItemTextEdit2})
        '
        'ApprovalItemCheckEdit1
        '
        Me.ApprovalItemCheckEdit1.Name = "ApprovalItemCheckEdit1"
        Me.ApprovalItemCheckEdit1.Properties.AllowFocused = False
        Me.ApprovalItemCheckEdit1.Properties.AutoHeight = False
        Me.ApprovalItemCheckEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ApprovalItemCheckEdit1.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.ApprovalItemCheckEdit1.Properties.ValueChecked = "1"
        Me.ApprovalItemCheckEdit1.Properties.ValueUnchecked = "0"
        '
        'UpdateItemCheckEdit2
        '
        Me.UpdateItemCheckEdit2.Name = "UpdateItemCheckEdit2"
        Me.UpdateItemCheckEdit2.Properties.AllowFocused = False
        Me.UpdateItemCheckEdit2.Properties.AutoHeight = False
        Me.UpdateItemCheckEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.UpdateItemCheckEdit2.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.UpdateItemCheckEdit2.Properties.ValueChecked = "1"
        Me.UpdateItemCheckEdit2.Properties.ValueUnchecked = "0"
        '
        'InsertItemCheckEdit3
        '
        Me.InsertItemCheckEdit3.Name = "InsertItemCheckEdit3"
        Me.InsertItemCheckEdit3.Properties.AllowFocused = False
        Me.InsertItemCheckEdit3.Properties.AutoHeight = False
        Me.InsertItemCheckEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InsertItemCheckEdit3.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.InsertItemCheckEdit3.Properties.ValueChecked = "1"
        Me.InsertItemCheckEdit3.Properties.ValueUnchecked = "0"
        '
        'DeleteItemCheckEdit4
        '
        Me.DeleteItemCheckEdit4.Name = "DeleteItemCheckEdit4"
        Me.DeleteItemCheckEdit4.Properties.AllowFocused = False
        Me.DeleteItemCheckEdit4.Properties.AutoHeight = False
        Me.DeleteItemCheckEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeleteItemCheckEdit4.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.DeleteItemCheckEdit4.Properties.ValueChecked = "1"
        Me.DeleteItemCheckEdit4.Properties.ValueUnchecked = "0"
        '
        'ScreenNameItemTextEdit
        '
        Me.ScreenNameItemTextEdit.Name = "ScreenNameItemTextEdit"
        Me.ScreenNameItemTextEdit.Properties.AllowFocused = False
        Me.ScreenNameItemTextEdit.Properties.AutoHeight = False
        Me.ScreenNameItemTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'AccessRightItemCheckEdit
        '
        Me.AccessRightItemCheckEdit.Name = "AccessRightItemCheckEdit"
        Me.AccessRightItemCheckEdit.Properties.AllowFocused = False
        Me.AccessRightItemCheckEdit.Properties.AutoHeight = False
        Me.AccessRightItemCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AccessRightItemCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.AccessRightItemCheckEdit.Properties.ValueChecked = "1"
        Me.AccessRightItemCheckEdit.Properties.ValueUnchecked = "0"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView2.Name = "GridView2"
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(20, 25)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(39, 19)
        Me.CloseBtn.TabIndex = 114
        Me.CloseBtn.Text = "&Close"
        '
        'CreateNewBtn
        '
        Me.CreateNewBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreateNewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateNewBtn.Image = Nothing
        Me.CreateNewBtn.Location = New System.Drawing.Point(28, 25)
        Me.CreateNewBtn.Name = "CreateNewBtn"
        Me.CreateNewBtn.Size = New System.Drawing.Size(67, 19)
        Me.CreateNewBtn.TabIndex = 113
        Me.CreateNewBtn.Text = "New Group"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(175, 25)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(43, 19)
        Me.DeleteBtn.TabIndex = 112
        Me.DeleteBtn.Text = "&Delete"
        '
        'SaveBtn
        '
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(116, 25)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(36, 19)
        Me.SaveBtn.TabIndex = 107
        Me.SaveBtn.Text = "&Save"
        '
        'ModuleTree
        '
        Me.ModuleTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModuleTree.Location = New System.Drawing.Point(339, 0)
        Me.ModuleTree.Name = "ModuleTree"
        Me.ModuleTree.Size = New System.Drawing.Size(845, 370)
        Me.ModuleTree.TabIndex = 108
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.CreateNewBtn)
        Me.Panel1.Controls.Add(Me.DeleteBtn)
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 370)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 67)
        Me.Panel1.TabIndex = 116
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CloseBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1077, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(107, 67)
        Me.Panel2.TabIndex = 117
        '
        'ManageUserGroup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1184, 437)
        Me.Controls.Add(Me.ModuleTree)
        Me.Controls.Add(Me.UserGroupBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserGroupFuncGrid)
        Me.Name = "ManageUserGroup"
        Me.Text = "ManageUserGroup"
        Me.UserGroupBox.ResumeLayout(False)
        CType(Me.UserGroupdescriptionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGroupNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGroupFuncGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovalItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsertItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeleteItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreenNameItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessRightItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Local Variables Initialization"

    Public UserID As String = Common.CommonConn.Config.USERID
    Private UserGroup_ID As Long
    Private UserGroup_Name As String
    Private UserGroup_Description As String

    Dim UserGroupDS As DataSet

#End Region

    Private Sub ManageUserGroup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadModuleTree()
        LoadUserGroupList()

    End Sub

    Private Sub LoadModuleTree()

        Me.ModuleTree.Nodes.Clear()
        ModuleTree.CheckBoxes = True

        Dim mainmenu() As TreeNode
        ReDim mainmenu(6)
        mainmenu(0) = New TreeNode
        mainmenu(0).Name = "sales"
        mainmenu(0).Text = "Sales"

        Dim salesmenu() As TreeNode
        ReDim salesmenu(7)

        salesmenu(0) = New TreeNode
        salesmenu(0).Name = "sales | enquiry"
        salesmenu(0).Text = "Enquiry"

        Dim enquirymenu() As TreeNode
        ReDim enquirymenu(0)
        'enquirymenu(0) = New TreeNode
        'enquirymenu(0).Name = "sales | enquiry | new enquiry"
        'enquirymenu(0).Text = "New Enquiry"

        enquirymenu(0) = New TreeNode
        enquirymenu(0).Name = "sales | enquiry | enquiry list"
        enquirymenu(0).Text = "Enquiry List"

        salesmenu(0).Nodes.AddRange(enquirymenu)

        salesmenu(1) = New TreeNode
        salesmenu(1).Name = "sales | bq"
        salesmenu(1).Text = "BQ"

        Dim bqmenu() As TreeNode
        ReDim bqmenu(0)

        bqmenu(0) = New TreeNode
        bqmenu(0).Name = "sales | bq | bq list"
        bqmenu(0).Text = "BQ List"

        salesmenu(1).Nodes.AddRange(bqmenu)

        salesmenu(2) = New TreeNode
        salesmenu(2).Name = "sales | quotation"
        salesmenu(2).Text = "Quotation"

        Dim quotationmenu() As TreeNode
        ReDim quotationmenu(4)
        'quotationmenu(0) = New TreeNode
        'quotationmenu(0).Name = "sales | quotation | new quotation"
        'quotationmenu(0).Text = "New Quotation"

        quotationmenu(0) = New TreeNode
        quotationmenu(0).Name = "sales | quotation | new service trading quotation"
        quotationmenu(0).Text = "New Service/Trading Quotation"

        quotationmenu(1) = New TreeNode
        quotationmenu(1).Name = "sales | quotation | quotation list"
        quotationmenu(1).Text = "Quotation List"

        quotationmenu(2) = New TreeNode
        quotationmenu(2).Name = "sales | quotation | alternative quotation"
        quotationmenu(2).Text = "Alternative Quotation"

        quotationmenu(3) = New TreeNode
        quotationmenu(3).Name = "sales | quotation | merge quotation"
        quotationmenu(3).Text = "Merge Quotation"

        quotationmenu(4) = New TreeNode
        quotationmenu(4).Name = "sales | quotation | quotaion pending for approval"
        quotationmenu(4).Text = "Quotation Pending for Approval"

        salesmenu(2).Nodes.AddRange(quotationmenu)

        salesmenu(3) = New TreeNode
        salesmenu(3).Name = "sales | order confirmation"
        salesmenu(3).Text = "Order Confirmation"

        Dim ocmenu() As TreeNode
        ReDim ocmenu(2)
        ocmenu(0) = New TreeNode
        ocmenu(0).Name = "sales | order confirmation | new order confirmation"
        ocmenu(0).Text = "New Order Confirmation (Without Quotation)"

        ocmenu(1) = New TreeNode
        ocmenu(1).Name = "sales | order confirmation | order confirmation list"
        ocmenu(1).Text = "Order Confirmation List"

        ocmenu(2) = New TreeNode
        ocmenu(2).Name = "sales | order confirmation | order confirmation pending for approval"
        ocmenu(2).Text = "Order Confirmation Pending For Approval"

        salesmenu(3).Nodes.AddRange(ocmenu)

        salesmenu(4) = New TreeNode
        salesmenu(4).Name = "sales | work order"
        salesmenu(4).Text = "Work Order"

        Dim workordermenu() As TreeNode
        ReDim workordermenu(3)
        workordermenu(0) = New TreeNode
        workordermenu(0).Name = "sales | work order | new work order"
        workordermenu(0).Text = "New Work Order (For orders without OC)"

        workordermenu(1) = New TreeNode
        workordermenu(1).Name = "sales | work order | work order list"
        workordermenu(1).Text = "Work Order List"

        workordermenu(2) = New TreeNode
        workordermenu(2).Name = "sales | work order | work order pending for approval"
        workordermenu(2).Text = "Work Order Pending For Approval"

        workordermenu(3) = New TreeNode
        workordermenu(3).Name = "sales | work order | work order on time delivery"
        workordermenu(3).Text = "Work Order On Time Delivery"

        salesmenu(4).Nodes.AddRange(workordermenu)

        salesmenu(5) = New TreeNode
        salesmenu(5).Name = "sales | delivery order"
        salesmenu(5).Text = "Delivery Order"

        Dim deliveryordermenu() As TreeNode
        ReDim deliveryordermenu(1)
        deliveryordermenu(0) = New TreeNode
        deliveryordermenu(0).Name = "sales | delivery order | new delivery order"
        deliveryordermenu(0).Text = "New Delivery Order"

        deliveryordermenu(1) = New TreeNode
        deliveryordermenu(1).Name = "sales | delivery order | delivery order list"
        deliveryordermenu(1).Text = "Delivery Order List"

        salesmenu(5).Nodes.AddRange(deliveryordermenu)

        salesmenu(6) = New TreeNode
        salesmenu(6).Name = "sales | standard box"
        salesmenu(6).Text = "Standard Box"

        Dim standardboxmenu() As TreeNode
        ReDim standardboxmenu(12)
        standardboxmenu(0) = New TreeNode
        standardboxmenu(0).Name = "sales | standard box | ogb filer for sales"
        standardboxmenu(0).Text = "OGB Fileer for Sales"

        standardboxmenu(1) = New TreeNode
        standardboxmenu(1).Name = "sales | standard box | new ogb contract"
        standardboxmenu(1).Text = "New OGB Contract"

        standardboxmenu(2) = New TreeNode
        standardboxmenu(2).Name = "sales | standard box | ogb list"
        standardboxmenu(2).Text = "OGB List"

        standardboxmenu(3) = New TreeNode
        standardboxmenu(3).Name = "sales | standard box | print ogb notification"
        standardboxmenu(3).Text = "Print OGB Notification"

        standardboxmenu(4) = New TreeNode
        standardboxmenu(4).Name = "sales | standard box | ogb request for lv form"
        standardboxmenu(4).Text = "OGB - Request for LV form"

        standardboxmenu(5) = New TreeNode
        standardboxmenu(5).Name = "sales | standard box | ogb declaration of work completion"
        standardboxmenu(5).Text = "OGB - Declaration of Work Completion"

        standardboxmenu(6) = New TreeNode
        standardboxmenu(6).Name = "sales | standard box | ogb survey order list"
        standardboxmenu(6).Text = "OGB - Survey Order List"

        standardboxmenu(7) = New TreeNode
        standardboxmenu(7).Name = "sales | standard box | lvb filer for sales"
        standardboxmenu(7).Text = "LVB Filer for Sales"

        standardboxmenu(8) = New TreeNode
        standardboxmenu(8).Name = "sales | standard box | new lvb contract"
        standardboxmenu(8).Text = "New LVB Contract"

        standardboxmenu(9) = New TreeNode
        standardboxmenu(9).Name = "sales | standard box | lvb list"
        standardboxmenu(9).Text = "LVB List"

        standardboxmenu(10) = New TreeNode
        standardboxmenu(10).Name = "sales | standard box | print lvb notification"
        standardboxmenu(10).Text = "Print LVB Notification"

        standardboxmenu(11) = New TreeNode
        standardboxmenu(11).Name = "sales | standard box | request for lv form"
        standardboxmenu(11).Text = "LVB - Request For LV form"

        standardboxmenu(12) = New TreeNode
        standardboxmenu(12).Name = "sales | standard box | lvb declaration of work completion"
        standardboxmenu(12).Text = "LVB - Declaration of Work Completion"


        salesmenu(6).Nodes.AddRange(standardboxmenu)


        salesmenu(7) = New TreeNode
        salesmenu(7).Name = "sales | reports ogblvb"
        salesmenu(7).Text = "Reports - OGB/LVB"

        Dim ogblvbreportmenu() As TreeNode
        ReDim ogblvbreportmenu(3)
        ogblvbreportmenu(0) = New TreeNode
        ogblvbreportmenu(0).Name = "sales | reports ogblvb | reports ogb not surveyed"
        ogblvbreportmenu(0).Text = "Reports: OGB-Not Surveyed"

        ogblvbreportmenu(1) = New TreeNode
        ogblvbreportmenu(1).Name = "sales | reports ogblvb | reports ogb invoicing status"
        ogblvbreportmenu(1).Text = "Reports: OGB-&Invoicing Status"

        ogblvbreportmenu(2) = New TreeNode
        ogblvbreportmenu(2).Name = "sales | reports ogblvb | reports ogb pending toc"
        ogblvbreportmenu(2).Text = "Reports: OGB-Pending &TOC"

        ogblvbreportmenu(3) = New TreeNode
        ogblvbreportmenu(3).Name = "sales | reports ogblvb | reports ogb installation and feedback record"
        ogblvbreportmenu(3).Text = "Reports: OGB Installation and Feedback Record"

        salesmenu(7).Nodes.AddRange(ogblvbreportmenu)

        mainmenu(0).Nodes.AddRange(salesmenu)

        mainmenu(1) = New TreeNode
        mainmenu(1).Name = "purchasing"
        mainmenu(1).Text = "Purchasing"

        Dim purchasingmenu() As TreeNode
        ReDim purchasingmenu(2)
        purchasingmenu(0) = New TreeNode
        purchasingmenu(0).Name = "purchasing | pr"
        purchasingmenu(0).Text = "Purchasing Requisition"

        Dim prmenu() As TreeNode
        ReDim prmenu(6)
        prmenu(0) = New TreeNode
        prmenu(0).Name = "purchasing | pr | store pr"
        prmenu(0).Text = "Store PR"

        prmenu(1) = New TreeNode
        prmenu(1).Name = "purchasing | pr | sales pr"
        prmenu(1).Text = "Sales PR"

        prmenu(2) = New TreeNode
        prmenu(2).Name = "purchasing | pr | factory pr"
        prmenu(2).Text = "Factory PR"

        prmenu(3) = New TreeNode
        prmenu(3).Name = "purchasing | pr | project pr"
        prmenu(3).Text = "Project PR"

        prmenu(4) = New TreeNode
        prmenu(4).Name = "purchasing | pr | pr pending for approval"
        prmenu(4).Text = "PR Pending For Approval"

        prmenu(5) = New TreeNode
        prmenu(5).Name = "purchasing | pr | pr pending for purchasing"
        prmenu(5).Text = "PR Pending For Purchasing"

        prmenu(6) = New TreeNode
        prmenu(6).Name = "purchasing | pr | pr list"
        prmenu(6).Text = "PR List"

        purchasingmenu(0).Nodes.AddRange(prmenu)

        purchasingmenu(1) = New TreeNode
        purchasingmenu(1).Name = "purchasing | po"
        purchasingmenu(1).Text = "Purchase Order"

        Dim pomenu() As TreeNode
        ReDim pomenu(1)
        pomenu(0) = New TreeNode
        pomenu(0).Name = "purchasing | po | po list"
        pomenu(0).Text = "PO List"

        pomenu(1) = New TreeNode
        pomenu(1).Name = "purchasing | po | generate po"
        pomenu(1).Text = "Generate PO"

        purchasingmenu(1).Nodes.AddRange(pomenu)

        purchasingmenu(2) = New TreeNode
        purchasingmenu(2).Name = "purchasing | reports"
        purchasingmenu(2).Text = "Reports"

        Dim purchasingreports() As TreeNode
        ReDim purchasingreports(3)
        purchasingreports(0) = New TreeNode
        purchasingreports(0).Name = "purchasing | reports | outstanding po report"
        purchasingreports(0).Text = "Outstanding PO Report"

        purchasingreports(1) = New TreeNode
        purchasingreports(1).Name = "purchasing | reports | supplier on time delivery report"
        purchasingreports(1).Text = "Supplier On-Time Delivery Report"

        purchasingreports(2) = New TreeNode
        purchasingreports(2).Name = "purchasing | reports | outstanding item list"
        purchasingreports(2).Text = "Outstanding Item List"

        purchasingreports(3) = New TreeNode
        purchasingreports(3).Name = "purchasing | reports | work order po report"
        purchasingreports(3).Text = "Work Order PO Report"

        purchasingmenu(2).Nodes.AddRange(purchasingreports)

        mainmenu(1).Nodes.AddRange(purchasingmenu)


        mainmenu(2) = New TreeNode
        mainmenu(2).Name = "production"
        mainmenu(2).Text = "Production"

        Dim productionmenu(2) As TreeNode
        productionmenu(0) = New TreeNode
        productionmenu(0).Name = "production | outstanding work orders"
        productionmenu(0).Text = "Work Order"

        productionmenu(1) = New TreeNode
        productionmenu(1).Name = "production | work plan list"
        productionmenu(1).Text = "Work Plan"

        productionmenu(2) = New TreeNode
        productionmenu(2).Name = "production | delivery note list"
        productionmenu(2).Text = "Delivery Note List"

        mainmenu(2).Nodes.AddRange(productionmenu)

        mainmenu(3) = New TreeNode
        mainmenu(3).Name = "quality assurance"
        mainmenu(3).Text = "Quality Assurance"

        Dim qamenu(1) As TreeNode
        qamenu(0) = New TreeNode
        qamenu(0).Name = "quality assurance  | product pending for inspection"
        qamenu(0).Text = "Product Pending For &Inspection"

        qamenu(1) = New TreeNode
        qamenu(1).Name = "quality assurance  | qa inspection report"
        qamenu(1).Text = "QA Inspection Report"

        mainmenu(3).Nodes.AddRange(qamenu)

        mainmenu(4) = New TreeNode
        mainmenu(4).Name = "inventory management"
        mainmenu(4).Text = "Inventory Management"

        Dim inventorymenu(3) As TreeNode
        inventorymenu(0) = New TreeNode
        inventorymenu(0).Name = "inventory management | stock transations"
        inventorymenu(0).Text = "Stock Transactions"

        Dim stocktranmenu(5) As TreeNode
        stocktranmenu(0) = New TreeNode
        stocktranmenu(0).Name = "inventory management | stock transactions | stock in do"
        stocktranmenu(0).Text = "Stock in (DO)"

        stocktranmenu(1) = New TreeNode
        stocktranmenu(1).Name = "inventory management | stock transactions | withdraw srv"
        stocktranmenu(1).Text = "Withdraw (SRV)"

        stocktranmenu(2) = New TreeNode
        stocktranmenu(2).Name = "inventory management | stock transactions | withdraw pmr"
        stocktranmenu(2).Text = "Withdraw (PMR)"

        stocktranmenu(3) = New TreeNode
        stocktranmenu(3).Name = "inventory management | stock transactions | return in"
        stocktranmenu(3).Text = "Return-in (RTN)"

        stocktranmenu(4) = New TreeNode
        stocktranmenu(4).Name = "inventory management | stock transactions | stock transfer"
        stocktranmenu(4).Text = "Stock Transfer(ST)"

        stocktranmenu(5) = New TreeNode
        stocktranmenu(5).Name = "inventory management | stock transactions | stock adjust"
        stocktranmenu(5).Text = "Stock Adjustment(SA)"

        inventorymenu(0).Nodes.AddRange(stocktranmenu)


        inventorymenu(1) = New TreeNode
        inventorymenu(1).Name = "inventory management | finished good transactions"
        inventorymenu(1).Text = "Finished Goods Transactions"

        Dim finishedgoodsmenu(4) As TreeNode
        finishedgoodsmenu(0) = New TreeNode
        finishedgoodsmenu(0).Name = "inventory management | finished good transactions | goods withdraw fgw"
        finishedgoodsmenu(0).Text = "Goods Withdraw (FGW)"

        finishedgoodsmenu(1) = New TreeNode
        finishedgoodsmenu(1).Name = "inventory management | finished good transactions | goods withdraw do"
        finishedgoodsmenu(1).Text = "Goods Withdraw (DO)"

        finishedgoodsmenu(2) = New TreeNode
        finishedgoodsmenu(2).Name = "inventory management | finished good transactions | goods withdraw noi"
        finishedgoodsmenu(2).Text = "Goods Withdraw (NOI)"

        finishedgoodsmenu(3) = New TreeNode
        finishedgoodsmenu(3).Name = "inventory management | finished good transactions | goods recieved qar"
        finishedgoodsmenu(3).Text = "QA - Inspection report"

        finishedgoodsmenu(4) = New TreeNode
        finishedgoodsmenu(4).Name = "inventory management | finished good transactions | goods internal int"
        finishedgoodsmenu(4).Text = "Goods Internal (Int)"

        inventorymenu(1).Nodes.AddRange(finishedgoodsmenu)

        inventorymenu(2) = New TreeNode
        inventorymenu(2).Name = "inventory management | stock viewer"
        inventorymenu(2).Text = "Stock Viewer"

        inventorymenu(3) = New TreeNode
        inventorymenu(3).Name = "inventory management | reports"
        inventorymenu(3).Text = "Reports"

        Dim inventoryreportmenu(3) As TreeNode
        inventoryreportmenu(0) = New TreeNode
        inventoryreportmenu(0).Name = "inventory management | reports | stock inventory report"
        inventoryreportmenu(0).Text = "Stock Inventory Report"

        inventoryreportmenu(1) = New TreeNode
        inventoryreportmenu(1).Name = "inventory management | reports | stock transaction report"
        inventoryreportmenu(1).Text = "Stock Transaction Report"

        inventoryreportmenu(2) = New TreeNode
        inventoryreportmenu(2).Name = "inventory management | reports | stock balance detail report"
        inventoryreportmenu(2).Text = "Stock Balance Details Report"

        inventoryreportmenu(3) = New TreeNode
        inventoryreportmenu(3).Name = "inventory management | reports | stock taking and assessment form"
        inventoryreportmenu(3).Text = "Stock &Taking and Assessment Form"

        inventorymenu(3).Nodes.AddRange(inventoryreportmenu)

        mainmenu(4).Nodes.AddRange(inventorymenu)

        mainmenu(5) = New TreeNode
        mainmenu(5).Name = "finance"
        mainmenu(5).Text = "Finance"

        Dim financemenu(0) As TreeNode
        financemenu(0) = New TreeNode
        financemenu(0).Name = "finance | delivery order invoicing"
        financemenu(0).Text = "Delivery Order - Invoicing"

        mainmenu(5).Nodes.AddRange(financemenu)

        mainmenu(6) = New TreeNode
        mainmenu(6).Name = "setup"
        mainmenu(6).Text = "Setup"

        Dim setupmenu(5) As TreeNode
        setupmenu(0) = New TreeNode
        setupmenu(0).Name = "setup | admin"
        setupmenu(0).Text = "Admin"

        Dim adminmenu(0) As TreeNode
        adminmenu(0) = New TreeNode
        adminmenu(0).Name = "setup | admin | security setup"
        adminmenu(0).Text = "Security Setup"

        Dim securitymenu(1) As TreeNode
        securitymenu(0) = New TreeNode
        securitymenu(0).Name = "setup | admin | security setup | user group"
        securitymenu(0).Text = "User Group"

        securitymenu(1) = New TreeNode
        securitymenu(1).Name = "setup | admin | security setup | user profile"
        securitymenu(1).Text = "User Profile"

        adminmenu(0).Nodes.AddRange(securitymenu)

        setupmenu(0).Nodes.AddRange(adminmenu)


        setupmenu(1) = New TreeNode
        setupmenu(1).Name = "setup | contacts"
        setupmenu(1).Text = "Contacts"

        Dim contactsmenu(3) As TreeNode
        contactsmenu(0) = New TreeNode
        contactsmenu(0).Name = "setup | contacts | consultants"
        contactsmenu(0).Text = "My Consultants"

        contactsmenu(1) = New TreeNode
        contactsmenu(1).Name = "setup | contacts | customers"
        contactsmenu(1).Text = "My Customers"

        contactsmenu(2) = New TreeNode
        contactsmenu(2).Name = "setup | contacts | suppliers"
        contactsmenu(2).Text = "My Suppliers"

        contactsmenu(3) = New TreeNode
        contactsmenu(3).Name = "setup | contacts | officers"
        contactsmenu(3).Text = "My Officer"

        setupmenu(1).Nodes.AddRange(contactsmenu)


        setupmenu(2) = New TreeNode
        setupmenu(2).Name = "setup | parts products"
        setupmenu(2).Text = "Parts / Products"

        Dim partsproductsmenu(3) As TreeNode
        partsproductsmenu(0) = New TreeNode
        partsproductsmenu(0).Name = "setup | parts products | category"
        partsproductsmenu(0).Text = "My Parts / Product Category"

        partsproductsmenu(1) = New TreeNode
        partsproductsmenu(1).Name = "setup | parts products | parts products"
        partsproductsmenu(1).Text = "My Parts / Product"

        partsproductsmenu(2) = New TreeNode
        partsproductsmenu(2).Name = "setup | parts products | uom"
        partsproductsmenu(2).Text = "My UOM"

        partsproductsmenu(3) = New TreeNode
        partsproductsmenu(3).Name = "setup | parts products | uom"
        partsproductsmenu(3).Text = "My Part Code"

        setupmenu(2).Nodes.AddRange(partsproductsmenu)

        setupmenu(3) = New TreeNode
        setupmenu(3).Name = "setup | system"
        setupmenu(3).Text = "System"

        Dim systemmenu(2) As TreeNode
        systemmenu(0) = New TreeNode
        systemmenu(0).Name = "setup | system | currency"
        systemmenu(0).Text = "My Currency"

        systemmenu(1) = New TreeNode
        systemmenu(1).Name = "setup | system | manage document number"
        systemmenu(1).Text = "Manage Document Number"

        systemmenu(2) = New TreeNode
        systemmenu(2).Name = "setup | system | manage drawing number"
        systemmenu(2).Text = "Manage Drawing Number"

        setupmenu(3).Nodes.AddRange(systemmenu)

        setupmenu(4) = New TreeNode
        setupmenu(4).Name = "setup | quotation form"
        setupmenu(4).Text = "Quotation Form"

        Dim quotationformmenu(11) As TreeNode
        quotationformmenu(0) = New TreeNode
        quotationformmenu(0).Name = "setup | quotation form | box category"
        quotationformmenu(0).Text = "My Box Category"

        quotationformmenu(1) = New TreeNode
        quotationformmenu(1).Name = "setup | quotation form | brand"
        quotationformmenu(1).Text = "My Brand"

        quotationformmenu(2) = New TreeNode
        quotationformmenu(2).Name = "setup | quotation form | color"
        quotationformmenu(2).Text = "My Color"

        quotationformmenu(3) = New TreeNode
        quotationformmenu(3).Name = "setup | quotation form | delivery terms"
        quotationformmenu(3).Text = "My Delivery Terms"

        quotationformmenu(4) = New TreeNode
        quotationformmenu(4).Name = "setup | quotation form | enclosure type"
        quotationformmenu(4).Text = "My Enclosure Type"

        quotationformmenu(5) = New TreeNode
        quotationformmenu(5).Name = "setup | quotation form | key"
        quotationformmenu(5).Text = "My Key"

        quotationformmenu(6) = New TreeNode
        quotationformmenu(6).Name = "setup | quotation form | material"
        quotationformmenu(6).Text = "My Material"

        quotationformmenu(7) = New TreeNode
        quotationformmenu(7).Name = "setup | quotation form | price include till"
        quotationformmenu(7).Text = "My Price Include Till"

        quotationformmenu(8) = New TreeNode
        quotationformmenu(8).Name = "setup | quotation form | price details"
        quotationformmenu(8).Text = "My Price Details"

        quotationformmenu(9) = New TreeNode
        quotationformmenu(9).Name = "setup | quotation form | project"
        quotationformmenu(9).Text = "My Project"

        quotationformmenu(10) = New TreeNode
        quotationformmenu(10).Name = "setup | quotation form | special format"
        quotationformmenu(10).Text = "My Special Format"

        quotationformmenu(11) = New TreeNode
        quotationformmenu(11).Name = "setup | quotation form | lv box type"
        quotationformmenu(11).Text = "My LVB Box Type"

        setupmenu(4).Nodes.AddRange(quotationformmenu)

        setupmenu(5) = New TreeNode
        setupmenu(5).Name = "setup | warehouse"
        setupmenu(5).Text = "Warehouse"

        Dim warehousemenu(0) As TreeNode
        warehousemenu(0) = New TreeNode
        warehousemenu(0).Name = "setup | warehouse | warehouse"
        warehousemenu(0).Text = "My Warehouse"

        setupmenu(5).Nodes.AddRange(warehousemenu)

        mainmenu(6).Nodes.AddRange(setupmenu)

        ModuleTree.Nodes.AddRange(mainmenu)
        ModuleTree.ExpandAll()

        'Me.ModuleTree.Nodes.Add(
    End Sub

    Private Sub LoadUserGroupList()
        Dim ds As DataSet
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            .LoadUserGroupList(ds)
            If Not ds Is Nothing Then
                Try
                    UserGroupListBox.DisplayMember = "Name"
                    UserGroupListBox.ValueMember = "Group_ID"
                    UserGroupListBox.DataSource = ds.Tables(0)

                    'Check if there is list of product
                    If ds.Tables(0).Rows.Count > 0 Then
                        UserGroupClick()
                    End If

                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub UserGroupClick()
        If UserGroupListBox.Items.Count > 0 Then
            UserGroup_ID = UserGroupListBox.SelectedValue.ToString
            'Me.Text = UserGroup_ID
            LoadUserGroupInfo(UserGroup_ID)
            LoadGroupAccess()
            SetWindowsValue()
        End If
    End Sub

    Private Sub LoadUserGroupInfo(ByVal UserGroupID As Long)

        'Load unit of measurement details.
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            If .LoadUserGroup(UserGroupID) Then
                UserGroup_Name = .UserGroup_Name
                UserGroup_Description = .UserGroup_Description

                'Load User Group Functions OBSLETE
                'If .LoadUserGroupFunctions(UserGroupDS, UserGroupID) Then
                'UserGroupFuncGrid.DataSource = UserGroupDS.Tables(0).DefaultView
                'If UserGroupDS.Tables(0).Rows.Count > 0 Then
                'UserGroupFuncGrid()
                'End If
                'End If
                'Else
                'UserGroupFuncGrid.DataSource = New DataSet
            End If
        End With
        'End load unit of measurement details
    End Sub

    Private Sub SetWindowsValue()
        UserGroupNameTxt.Text = UserGroup_Name
        UserGroupdescriptionTxt.Text = UserGroup_Description
    End Sub

    Private Sub GetWindowsValue()

        UserGroup_Name = UserGroupNameTxt.Text
        UserGroup_Description = UserGroupdescriptionTxt.Text

    End Sub

    Private Sub UserGroupListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserGroupListBox.SelectedIndexChanged
        UserGroupClick()
    End Sub

    Private Sub CreateNewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewBtn.Click
        UserGroupNameTxt.Text = ""
        UserGroupdescriptionTxt.Text = ""
        UserGroup_ID = 0 'Create New User Group
        LoadUserGroupInfo(UserGroup_ID)
        UserGroupNameTxt.Focus()
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Me.Cursor = Cursors.WaitCursor
        SaveUserGroup()
        Me.Cursor = Cursors.Default
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If UserGroup_Name = "" Then
            ErrorMessage = ErrorMessage & " User Group Name" & Chr(13)
            DataOK_flag = False
        End If

        If UserGroup_Description = "" Then
            ErrorMessage = ErrorMessage & " User Group Description" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        End If

        Return DataOK_flag

    End Function

    Private Sub SaveUserGroup()

        GetWindowsValue()

        If ValidData() Then
            'GridView1.CloseEditor()
            'GridView1.UpdateCurrentRow()
            With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
                Dim funcds As DataSet
                .UserGroup_Name = UserGroup_Name
                .UserGroup_Description = UserGroup_Description
                If .UserGroupRecordExists(UserGroup_ID, Nothing) Then
                    Dim i As Integer
                    'Update Existing User Group
                    .UserGroup_ID = UserGroup_ID
                    .UpdateUserGroup(UserID)

                Else 'Create New User Group
                    Dim tmpGroupID As Long
                    tmpGroupID = .CreateUserGroup(UserID)
                    If tmpGroupID <> 0 Or tmpGroupID <> Nothing Then

                        .UserGroup_ID = tmpGroupID

                    End If

                End If
                'LoadUserGroupList()
            End With
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If UserGroup_ID <> Nothing And UserGroup_ID <> 0 Then
            Dim Result As DialogResult = MessageBox.Show("Are you sure you delete this User Group?", "Delete User Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
                    .UserGroup_ID = UserGroup_ID
                    .DeleteUserGroup(UserID)
                End With
                LoadUserGroupList()
            End If
        End If
    End Sub


    Private Sub ManageUserGroup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ModuleTree_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles ModuleTree.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                CheckAllChildNodes(e.Node, e.Node.Checked)
            Else
                SetGroupAccess(e.Node.Name, e.Node.Checked)
                If e.Node.Checked = True Then
                    e.Node.Parent.Checked = True
                    SetGroupAccess(e.Node.Parent.Name, True)
                End If
            End If

        End If
    End Sub

    Private Sub CheckAllChildNodes(ByVal tr As TreeNode, ByVal CheckVal As Boolean)

        SetGroupAccess(tr.Name, CheckVal)
        If CheckVal = True Then
            If Not tr.Parent Is Nothing Then
                tr.Parent.Checked = True
                SetGroupAccess(tr.Parent.Name, True)
            End If
        End If

        tr.Checked = CheckVal
        If tr.Nodes.Count > 0 Then
            For Each node As TreeNode In tr.Nodes
                CheckAllChildNodes(node, CheckVal)
            Next
        End If
    End Sub

    Private Sub SetGroupAccess(ByVal ModuleName As String, ByVal Access As Boolean)
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            .UpdateGroupAccess(Me.UserGroup_ID, ModuleName, Access)
        End With
    End Sub

    Private Function GetGroupAccess(ByVal ModuleName As String, Optional ByVal Rights As String = "access") As Boolean
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            Return .CheckGroupAccess(Me.UserGroup_ID, ModuleName, Rights)
        End With
    End Function


    Private Sub LoadGroupAccess()
        If ModuleTree.Nodes.Count > 0 Then
            For Each mt As TreeNode In ModuleTree.Nodes
                If GetGroupAccess(mt.Name) = True Then
                    mt.Checked = True
                Else
                    mt.Checked = False
                End If
                CheckAllModuleTree(mt)
            Next

            'scroll to top
            ModuleTree.Nodes(0).EnsureVisible()
        End If

       
        
    End Sub

    Private Sub CheckAllModuleTree(ByVal pModuleTree As TreeNode)
        If pModuleTree.Nodes.Count > 0 Then
            For Each mt As TreeNode In pModuleTree.Nodes
                If GetGroupAccess(mt.Name) = True Then
                    mt.Checked = True
                Else
                    mt.Checked = False
                End If
                CheckAllModuleTree(mt)
            Next
        End If
    End Sub

    

End Class
