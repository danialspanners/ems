Imports DevExpress.XtraEditors.Controls
Imports System.Collections

Public Class PRForm
    Inherits System.Windows.Forms.Form

#Region " Variable Initialization"

    Public PR_Line As Integer
    Public PR_ID As Integer
    Public PR_No As String
    Public Requester As Integer
    Public Approver As Integer
    Public Quotation_ID As Integer
    Public Category As String
    Public Status As String
    Public Grp As Integer
    Public Submit_Date As String
    Public PR_Date As String
    Public UserID As String = Common.CommonConn.Config.USERID

    Public Quotation_NO As String

    Public dataGrid = New DataTable("ColumnsTable")

    Public FormStatus As String
    Public Department_ID As Integer
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pPR_ID As String = "0", Optional ByVal pQuotation_ID As String = "0", Optional ByVal pQuotationNo As String = "", Optional ByVal pDepartment_ID As String = "")
        MyBase.New()
        FormStatus = pStatus

        If pPR_ID <> "0" Then
            PR_ID = pPR_ID
        End If

        If pQuotation_ID <> "0" Then
            Quotation_ID = pQuotation_ID
        End If

        If pQuotationNo <> "0" Then
            Quotation_NO = pQuotationNo
        End If

        If Len(pDepartment_ID) > 0 Then
            Department_ID = pDepartment_ID
        Else
            Department_ID = 0
        End If

        If Department_ID = 0 Then
            Department_ID = GetUserGroup()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QuotationNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConfirmBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ItemGrp As System.Windows.Forms.GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AddItemBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteItemBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PR_NoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PRDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ReqByLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ApprovedByLookUp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GrpLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PRLineGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ReserveStockBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CreaterLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SubmitDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UnReserveStockBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PRForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SubmitDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.CreaterLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.GrpLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.ApprovedByLookUp = New DevExpress.XtraEditors.LookUpEdit
        Me.ReqByLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PRDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.PR_NoTxt = New DevExpress.XtraEditors.TextEdit
        Me.StatusLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.QuotationNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ConfirmBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ItemGrp = New System.Windows.Forms.GroupBox
        Me.UnReserveStockBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteItemBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRLineGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ReserveStockBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddItemBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.GroupBox1.SuspendLayout()
        CType(Me.SubmitDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreaterLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedByLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PR_NoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemGrp.SuspendLayout()
        CType(Me.PRLineGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SubmitDateEdit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CreaterLookup)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GrpLookup)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ApprovedByLookUp)
        Me.GroupBox1.Controls.Add(Me.ReqByLookup)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PRDateEdit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PR_NoTxt)
        Me.GroupBox1.Controls.Add(Me.StatusLookup)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.QuotationNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 144)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'SubmitDateEdit
        '
        Me.SubmitDateEdit.DateTime = New Date(CType(0, Long))
        Me.SubmitDateEdit.Location = New System.Drawing.Point(336, 88)
        Me.SubmitDateEdit.Name = "SubmitDateEdit"
        Me.SubmitDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SubmitDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SubmitDateEdit.Properties.Format = Nothing
        Me.SubmitDateEdit.Properties.FormatString = "dd/MM/yyyy"
        Me.SubmitDateEdit.Size = New System.Drawing.Size(112, 19)
        Me.SubmitDateEdit.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(256, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Submit Date :"
        '
        'CreaterLookup
        '
        Me.CreaterLookup.Location = New System.Drawing.Point(96, 112)
        Me.CreaterLookup.Name = "CreaterLookup"
        Me.CreaterLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CreaterLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CreaterLookup.Properties.NullString = ""
        Me.CreaterLookup.Properties.ReadOnly = True
        Me.CreaterLookup.Size = New System.Drawing.Size(112, 19)
        Me.CreaterLookup.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Recorded By :"
        '
        'GrpLookup
        '
        Me.GrpLookup.Location = New System.Drawing.Point(96, 64)
        Me.GrpLookup.Name = "GrpLookup"
        Me.GrpLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GrpLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.GrpLookup.Properties.NullString = ""
        Me.GrpLookup.Properties.ReadOnly = True
        Me.GrpLookup.Size = New System.Drawing.Size(112, 19)
        Me.GrpLookup.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Group :"
        '
        'ApprovedByLookUp
        '
        Me.ApprovedByLookUp.Location = New System.Drawing.Point(576, 112)
        Me.ApprovedByLookUp.Name = "ApprovedByLookUp"
        Me.ApprovedByLookUp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ApprovedByLookUp.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ApprovedByLookUp.Properties.NullString = ""
        Me.ApprovedByLookUp.Size = New System.Drawing.Size(112, 19)
        Me.ApprovedByLookUp.TabIndex = 35
        '
        'ReqByLookup
        '
        Me.ReqByLookup.Location = New System.Drawing.Point(336, 112)
        Me.ReqByLookup.Name = "ReqByLookup"
        Me.ReqByLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ReqByLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ReqByLookup.Properties.NullString = ""
        Me.ReqByLookup.Size = New System.Drawing.Size(112, 19)
        Me.ReqByLookup.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(496, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Approved By :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Requested By :"
        '
        'PRDateEdit
        '
        Me.PRDateEdit.DateTime = New Date(CType(0, Long))
        Me.PRDateEdit.Location = New System.Drawing.Point(96, 88)
        Me.PRDateEdit.Name = "PRDateEdit"
        Me.PRDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PRDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PRDateEdit.Properties.Format = Nothing
        Me.PRDateEdit.Properties.FormatString = "dd/MM/yyyy"
        Me.PRDateEdit.Properties.ReadOnly = True
        Me.PRDateEdit.Size = New System.Drawing.Size(112, 19)
        Me.PRDateEdit.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "PR Date :"
        '
        'PR_NoTxt
        '
        Me.PR_NoTxt.Location = New System.Drawing.Point(96, 40)
        Me.PR_NoTxt.Name = "PR_NoTxt"
        Me.PR_NoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PR_NoTxt.Properties.Enabled = False
        Me.PR_NoTxt.Properties.MaxLength = 10
        Me.PR_NoTxt.Properties.ReadOnly = True
        Me.PR_NoTxt.Size = New System.Drawing.Size(112, 19)
        Me.PR_NoTxt.TabIndex = 27
        '
        'StatusLookup
        '
        Me.StatusLookup.Location = New System.Drawing.Point(336, 64)
        Me.StatusLookup.Name = "StatusLookup"
        Me.StatusLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusLookup.Properties.NullString = ""
        Me.StatusLookup.Properties.ReadOnly = True
        Me.StatusLookup.Size = New System.Drawing.Size(112, 19)
        Me.StatusLookup.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Status :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "PR No. :"
        '
        'QuotationNoTxt
        '
        Me.QuotationNoTxt.Location = New System.Drawing.Point(96, 16)
        Me.QuotationNoTxt.Name = "QuotationNoTxt"
        Me.QuotationNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuotationNoTxt.Properties.Enabled = False
        Me.QuotationNoTxt.Properties.ReadOnly = True
        Me.QuotationNoTxt.Size = New System.Drawing.Size(112, 19)
        Me.QuotationNoTxt.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "OC No. :"
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.AutoSize = False
        Me.ConfirmBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ConfirmBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmBtn.Image = Nothing
        Me.ConfirmBtn.Location = New System.Drawing.Point(16, 408)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(88, 32)
        Me.ConfirmBtn.TabIndex = 20
        Me.ConfirmBtn.Text = "Generate PR"
        '
        'ItemGrp
        '
        Me.ItemGrp.Controls.Add(Me.UnReserveStockBtn)
        Me.ItemGrp.Controls.Add(Me.DeleteItemBtn)
        Me.ItemGrp.Controls.Add(Me.PRLineGrid)
        Me.ItemGrp.Controls.Add(Me.ReserveStockBtn)
        Me.ItemGrp.Controls.Add(Me.AddItemBtn)
        Me.ItemGrp.Location = New System.Drawing.Point(8, 160)
        Me.ItemGrp.Name = "ItemGrp"
        Me.ItemGrp.Size = New System.Drawing.Size(824, 240)
        Me.ItemGrp.TabIndex = 21
        Me.ItemGrp.TabStop = False
        Me.ItemGrp.Text = "Item Details"
        '
        'UnReserveStockBtn
        '
        Me.UnReserveStockBtn.AutoSize = False
        Me.UnReserveStockBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UnReserveStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnReserveStockBtn.Image = Nothing
        Me.UnReserveStockBtn.Location = New System.Drawing.Point(448, 200)
        Me.UnReserveStockBtn.Name = "UnReserveStockBtn"
        Me.UnReserveStockBtn.Size = New System.Drawing.Size(96, 32)
        Me.UnReserveStockBtn.TabIndex = 26
        Me.UnReserveStockBtn.Text = "Unreserve Stock"
        '
        'DeleteItemBtn
        '
        Me.DeleteItemBtn.AutoSize = False
        Me.DeleteItemBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteItemBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteItemBtn.Image = Nothing
        Me.DeleteItemBtn.Location = New System.Drawing.Point(112, 200)
        Me.DeleteItemBtn.Name = "DeleteItemBtn"
        Me.DeleteItemBtn.Size = New System.Drawing.Size(80, 32)
        Me.DeleteItemBtn.TabIndex = 23
        Me.DeleteItemBtn.Text = "Delete Item"
        '
        'PRLineGrid
        '
        Me.PRLineGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRLineGrid.Location = New System.Drawing.Point(8, 16)
        Me.PRLineGrid.MainView = Me.GridView1
        Me.PRLineGrid.Name = "PRLineGrid"
        Me.PRLineGrid.Size = New System.Drawing.Size(808, 176)
        Me.PRLineGrid.TabIndex = 20
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.PreviewLineCount = 2
        '
        'ReserveStockBtn
        '
        Me.ReserveStockBtn.AutoSize = False
        Me.ReserveStockBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ReserveStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveStockBtn.Image = Nothing
        Me.ReserveStockBtn.Location = New System.Drawing.Point(344, 200)
        Me.ReserveStockBtn.Name = "ReserveStockBtn"
        Me.ReserveStockBtn.Size = New System.Drawing.Size(96, 32)
        Me.ReserveStockBtn.TabIndex = 25
        Me.ReserveStockBtn.Text = "Reserve Stock"
        '
        'AddItemBtn
        '
        Me.AddItemBtn.AutoSize = False
        Me.AddItemBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddItemBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemBtn.Image = Nothing
        Me.AddItemBtn.Location = New System.Drawing.Point(8, 200)
        Me.AddItemBtn.Name = "AddItemBtn"
        Me.AddItemBtn.Size = New System.Drawing.Size(80, 32)
        Me.AddItemBtn.TabIndex = 21
        Me.AddItemBtn.Text = "Add Item"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(112, 408)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 22
        Me.CloseBtn.Text = "&Close"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Edit"
        '
        'PRForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(840, 445)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.ItemGrp)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(80, 80)
        Me.Name = "PRForm"
        Me.Text = "Purchase Requisition"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SubmitDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreaterLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedByLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PR_NoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemGrp.ResumeLayout(False)
        CType(Me.PRLineGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Combo Box Values"
    'Category
    Dim categoryData As String() = New String() {"", "Samples", "Admin Use", "Factory Use", "Store Use"}

    'Status
    '10 - Preparing, 20 - Revised, 30 - Pending approval, 31-Pending stock, 40 - Approved
    Dim statusData As String() = New String() {"", "Preparing", "Revised", "Pending", "Submitted"}
    Dim statusID As String() = New String() {"", "10", "20", "30", "40"}

    'Grp
    'Dim grpData As String() = New String() {"", "Production", "Admin", "Sales", "Factory", "Store"}

#End Region

#Region "Event"

    'Load form
    Private Sub PRForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        'Quotation No 
        If Quotation_NO <> "" Then
            QuotationNoTxt.Text = Quotation_NO
        Else
            QuotationNoTxt.Text = "N.A."
        End If

        'Initalize Grid and Combo
        InitItemGrid()
        InitalCombo()

        'Load Record frm db
        LoadFrmDB()
        LoadItems()

        Select Case UCase(FormStatus)
            Case "NEW", "MODIFY"
                ReserveStockBtn.Visible = False
                ' 22.11.2003 YG Start
                UnReserveStockBtn.Visible = False

                ConfirmBtn.Text = "Save PR"

                If UCase(FormStatus) = "NEW" Then
                    Me.Text = "Generate New PR"
                Else
                    Me.Text = "Modify PR"
                End If

            Case "APPROVEPR"
                SetApprovalForm()
                ConfirmBtn.Text = "Approve PR"
                Me.Text = "Approve PR"

            Case "VIEW"
                SetApprovalForm()
                ConfirmBtn.Enabled = False
                ConfirmBtn.Visible = False
                ReserveStockBtn.Visible = False
                ' 22.11.2003 YG Start
                UnReserveStockBtn.Visible = False
                ApprovedByLookUp.Properties.Enabled = False
                Me.Text = "View PR"

            Case "RESERVESTOCK"
                SetApprovalForm()
                ConfirmBtn.Enabled = False
                Me.Text = "Modify Reserved Stock"
        End Select

        Me.Cursor = Cursors.Default

    End Sub

    'PRLine Grid Click
    Private Sub PRLineGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PRLineGrid.Click
        GridClick()
    End Sub

    Private Sub GridClick()

        If GridView1.SelectedRowsCount > 0 Then
            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then
                Dim dr As DataRow
                Dim items As Object()

                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))
                items = dr.ItemArray
                PR_Line = Integer.Parse(items(0).ToString)

                If UCase(FormStatus) = "RESERVESTOCK" Then
                    If items(18) = 0 Then
                        If items(8) < items(7) Then ' Reserved Qty less then Request Qty
                            If items(19) > 0 Then   ' Availble Qty greater than 0
                        ReserveStockBtn.Enabled = True
                    Else
                        ReserveStockBtn.Enabled = False
                            End If
                        Else
                            ReserveStockBtn.Enabled = False
                        End If
                        ' 22.11.2003 YG Start
                        If items(8) > 0 Then
                            UnReserveStockBtn.Enabled = True
                        Else
                            UnReserveStockBtn.Enabled = False
                        End If
                    Else
                        ReserveStockBtn.Enabled = False
                        ' 22.11.2003 YG Start
                        UnReserveStockBtn.Enabled = False
                    End If
                End If
            Else
                PR_Line = Nothing
            End If
        Else
            PR_Line = Nothing
        End If

    End Sub

#End Region

#Region "Button Click Event"

    'Approval Form - Reserve Stock
    Private Sub ReserveStockBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReserveStockBtn.Click
        Dim form As New ReserveStock

        form.PR_Line = PR_Line
        form.Quotation_NO = Quotation_NO
        form.ShowDialog()

        If form.SaveRecord Then
            ClearGrid(GridView1)
            LoadItems()
        End If
    End Sub

    ' 22.11.2003 YG Start
    'Approval Form - Reserve Stock
    Private Sub UnReserveStockBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnReserveStockBtn.Click
        Dim form As New UnReserveStock

        form.PR_Line = PR_Line
        form.Quotation_NO = Quotation_NO
        form.ShowDialog()

        If form.SaveRecord Then
            ClearGrid(GridView1)
            LoadItems()
        End If
    End Sub

    'Add Item
    Private Sub AddItemBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemBtn.Click

        If Quotation_ID <> 0 And Quotation_ID <> Nothing Then
            'PR from OC

            'Check if anymore items to add (if quotation is already complete)
            If CheckQuotationComplete(Quotation_ID) Then
                MessageBox.Show("No more items need to be purchase for this quotation", "Quotation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Dim form As New PRItemForm

                form.Quotation_ID = Quotation_ID

                If PR_ID <> Nothing And PR_ID <> 0 Then
                    form.PR_ID = PR_ID
                End If

                form.ParentItemGrid = GridView1

                form.ShowDialog(Me)


            End If
        Else

            'PR without OC

            'Dim form As New PRItem2

            'If PR_ID <> Nothing And PR_ID <> 0 Then
            'form.PR_ID = PR_ID
            'End If

            'form.ShowDialog(Me)

        End If

    End Sub

    'Delete Item
    Private Sub DeleteItemBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItemBtn.Click
        If GridView1.SelectedRowsCount > 0 Then

            If MessageBox.Show("Are you sure you want to remove item from PR?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DeleteItems()
            End If

        End If
    End Sub

    'Confirm PR
    Private Sub ConfirmBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmBtn.Click

        Select Case UCase(FormStatus)
            Case "NEW", "MODIFY"
                SavePRHeader()
            Case "APPROVEPR"
                ApprovePR()
        End Select

    End Sub

    'Close form
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click

        Me.Close()

    End Sub

#End Region

#Region "Approval Form"

    Private Sub SetApprovalForm()
        PR_NoTxt.Properties.Enabled = False
        StatusLookup.Properties.Enabled = False
        GrpLookup.Properties.Enabled = False
        PRDateEdit.Properties.Enabled = False
        ReqByLookup.Properties.Enabled = False

        AddItemBtn.Visible = False
        DeleteItemBtn.Visible = False
        ReserveStockBtn.Visible = True
        ' 22.11.2003 YG Start
        UnReserveStockBtn.Visible = True
    End Sub

    Private Sub ApprovePR()
        If PR_ID <> Nothing And PR_ID <> 0 Then
            If ApprovedByLookUp.Properties.LookUpData.KeyValue() <> Nothing Then
                Approver = Integer.Parse(ApprovedByLookUp.Properties.LookUpData.KeyValue().ToString())
            Else
                Approver = Nothing
            End If

            If Approver = Nothing Or Approver = 0 Then
                With New Common.CommonError.ErrorMsg
                    MessageBox.Show(.EMPTY_FIELD_MSG & " Approver", "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End With
            Else

                With New BusinessRules.PRBusRules.PRHeaderBusLogic
                    .Approver = Approver
                    .ApprovePR(PR_ID)
                End With

                MessageBox.Show("PR is approved", "Approve PR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DisbledAll()

                'CloseTabPage()
            End If
        End If
    End Sub

#End Region

#Region "Combo Box"

    Private Sub InitalCombo()

        SetComboValue(statusData, StatusLookup, statusID)
        'SetComboValue(grpData, GrpLookup, Nothing)

        InitalUserCombo()

        InitalGrpCombo()
    End Sub

    Private Sub InitalUserCombo()
        Dim ds As DataSet

        With New BusinessRules.PRBusRules.PRBusLogic
            If .GetUser(ds) Then
                If Not ds Is Nothing Then
                    ReqByLookup.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(ReqByLookup, "Name", 400, 0, "c")
                    ReqByLookup.Properties.LookUpData.KeyField = "User_ID"
                    ReqByLookup.Properties.LookUpData.DisplayField = "Name"

                    ReqByLookup.Properties.LookUpData.DataSource = ds.Tables(0)

                    ApprovedByLookUp.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(ApprovedByLookUp, "Name", 400, 0, "c")
                    ApprovedByLookUp.Properties.LookUpData.KeyField = "User_ID"
                    ApprovedByLookUp.Properties.LookUpData.DisplayField = "Name"

                    ApprovedByLookUp.Properties.LookUpData.DataSource = ds.Tables(0)

                    CreaterLookup.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(CreaterLookup, "Name", 400, 0, "c")
                    CreaterLookup.Properties.LookUpData.KeyField = "User_ID"
                    CreaterLookup.Properties.LookUpData.DisplayField = "Name"

                    CreaterLookup.Properties.LookUpData.DataSource = ds.Tables(0)

                End If
            End If

        End With
    End Sub

    Private Sub InitalGrpCombo()
        Dim ds As DataSet

        With New BusinessRules.PRBusRules.PRBusLogic
            If .LoadUserGrpList(ds) Then
                If Not ds Is Nothing Then
                    GrpLookup.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(GrpLookup, "Name", 400, 0, "c")
                    GrpLookup.Properties.LookUpData.KeyField = "Department_ID"
                    GrpLookup.Properties.LookUpData.DisplayField = "Name"

                    GrpLookup.Properties.LookUpData.DataSource = ds.Tables(0)

                End If
            End If

        End With
    End Sub
    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())

        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)

        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

#End Region

#Region "Database Management"

    Private Sub LoadFrmDB()

        If PR_ID <> Nothing And PR_ID <> 0 Then

            Dim ds As DataSet
            'Load unit of measurement details.
            With New BusinessRules.PRBusRules.PRHeaderBusLogic
                If .Load(PR_ID) Then
                    PR_No = .PR_No
                    Requester = .Requester
                    Approver = .Approver
                    Quotation_ID = .Quotation_ID
                    Category = .Category
                    Status = .Status
                    Grp = .Grp
                    Submit_Date = .Submit_Date
                    PR_Date = .Create_Date

                End If
            End With

            SetWindowsValue()
        Else
            If Department_ID = 0 Then
            Grp = GetUserGroup()

            If Grp <> Nothing And Grp <> 0 Then
                GrpLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Grp, 0, 0, 0})
                End If
            Else
                GrpLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Department_ID, 0, 0, 0})
            End If

            PR_NoTxt.Text = CreatePRNo()
            StatusLookup.Properties.LookUpData.KeyValue = "10"
            PRDateEdit.DateTime = Date.Today

            If UserID <> Nothing And UserID <> 0 Then
                CreaterLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {UserID, 0, 0, 0})
            End If

        End If

    End Sub

    Private Sub SavePRHeader()
        GetWindowsValue()

        If ValidData() Then

            With New BusinessRules.PRBusRules.PRHeaderBusLogic

                .PR_No = PR_No
                .Requester = Requester
                .Approver = Approver
                .Quotation_ID = Quotation_ID
                .Category = Category
                .Status = Status
                If Grp <> Nothing And Grp <> 0 Then
                    .Grp = Grp.ToString
                End If
                .UserID = UserID

                'A modified record will have product id
                If PR_ID = Nothing Or PR_ID = 0 Then

                    'New Record
                    PR_ID = .Save()
                    SaveItem()

                    MessageBox.Show("PR had been successfully created", "Generate PR", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Else
                    'Modify Current Record
                    .Update(PR_ID)
                    SaveItem()

                    MessageBox.Show("PR had been successfully updated", "Modify PR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                'DisbledAll()
            End With

        End If


    End Sub

    Private Sub LoadItems()

        If PR_ID <> Nothing And PR_ID <> 0 Then

            Dim ds As DataSet

            With New BusinessRules.PRBusRules.PRLineBusLogic
                If .LoadList(ds, PR_ID, "") Then
                    If Not ds Is Nothing Then
                        Try

                            Dim oRow As DataRow
                            Dim i As Integer = 0
                            Dim tempDeliveryDate As String = ""
                            Dim tmpAvailQty As Integer = 0
                            For Each oRow In ds.Tables(0).Rows
                                i = i + 1

                                tempDeliveryDate = ChangeDateFormat(oRow("Delivery_Date"))
                                With New BusinessRules.ReservedStockRules.ReservedStockLogic
                                    tmpAvailQty = .ComputeAvailStock(oRow("Category_ID"), oRow("Product_ID"))
                                End With

                                dataGrid.Rows.Add(New Object() {oRow("PR_Line"), oRow("Category_ID"), oRow("Product_ID"), _
                                                    oRow("Supplier_ID"), oRow("Actual_Supplier_ID"), oRow("Component_ID"), _
                                                    oRow("ProductName"), _
                                                    oRow("Request_Qty"), oRow("Stock_Reserved"), oRow("Order_Qty"), oRow("UOM"), _
                                                    tempDeliveryDate, _
                                                    oRow("Currency"), _
                                                    oRow("SupplierName"), oRow("Enquiry_Price"), _
                                                    oRow("Actual_Supplier_Name"), oRow("Actual_Price"), _
                                                    oRow("WO_No"), _
                                                    oRow("PO_Line_ID"), tmpAvailQty})
                            Next

                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End If
                End If
            End With
        End If

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            GridClick()
        End If

    End Sub

    Private Sub DeleteItems()
        If PR_Line <> Nothing And PR_Line <> 0 Then
            With New BusinessRules.PRBusRules.PRLineBusLogic
                .Delete(PR_Line)
            End With

            ClearGrid(GridView1)
            LoadItems()
        Else
            GridView1.DeleteRow(GridView1.GetSelectedRows(0))
        End If

    End Sub

    Private Sub SaveItem()

        Dim PR_Line As Integer
        Dim Category_ID As Integer
        Dim Product_ID As Integer

        Dim Request_Qty As Integer
        Dim Order_Qty As Integer

        Dim Delivery_Date As String

        Dim Supplier_ID As Integer
        Dim Enquiry_Price As Decimal

        Dim Component_ID As Integer

        Dim Actual_Supplier_ID As Integer
        Dim Actual_Price As Decimal

        Dim WO_No As String

        Dim i
        Dim dr As DataRow
        Dim items As Object()
        Dim ds As DataSet

        Dim countOrderedQty As Integer
        Dim errorQtyExceed As Boolean

        errorQtyExceed = False


        If Quotation_NO <> "" Then
            WO_No = GetWONO()
        End If

        For i = 0 To GridView1.RowCount - 1
            dr = GridView1.GetDataRow(i)
            items = dr.ItemArray

            PR_Line = items(0)
            Category_ID = items(1)
            Product_ID = items(2)
            Supplier_ID = items(3)
            Actual_Supplier_ID = items(4)
            Component_ID = items(5)

            Request_Qty = items(7)
            Order_Qty = items(9)

            Delivery_Date = items(11)

            Enquiry_Price = items(14)
            Actual_Price = items(16)

            If Quotation_NO = "" Then
                If Not items(17) Is System.DBNull.Value Then
                    WO_No = items(17)
                Else
                    WO_No = ""
                End If
            End If

            If PR_Line = Nothing Or PR_Line = 0 Then

                If Component_ID <> Nothing And Component_ID <> 0 Then
                    With New BusinessRules.PRBusRules.PRBusLogic
                        countOrderedQty = .CountTotalOrderQty(Component_ID)
                        countOrderedQty = .GetQty(Component_ID) - countOrderedQty
                    End With

                    If Request_Qty > countOrderedQty Then
                        errorQtyExceed = True
                    End If
                Else
                    'Not frm BQ


                End If

                If errorQtyExceed = False Then

                    With New BusinessRules.PRBusRules.PRLineBusLogic

                        .PR_ID = PR_ID
                        .Category_ID = Category_ID
                        .Product_ID = Product_ID
                        .Request_Qty = Request_Qty
                        .Order_Qty = Request_Qty
                        .Delivery_Date = Delivery_Date

                        .Supplier_ID = Supplier_ID
                        .Enquiry_Price = Enquiry_Price
                        .Actual_Price = Actual_Price
                        .Component_ID = Component_ID

                        .Actual_Supplier_ID = Actual_Supplier_ID

                        .WO_No = WO_No

                        .UserID = UserID 'Common.CommonConn.Config.USERID

                        'Creates a new record
                        .Save()
                    End With
                End If
            End If


        Next

        If errorQtyExceed = True Then
            MessageBox.Show("Quantity to order had exceed request quantity", "Error - Quantity Exceed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Function GetWONO()
        Dim ds As DataSet
        Dim WO_No As String

        With New BusinessRules.PRBusRules.PRBusLogic

            WO_No = .GetWONo(Quotation_NO)

        End With
        GetWONO = WO_No

    End Function
#End Region

#Region " Init Item Grid Code "

    Private Sub InitItemGrid()

        dataGrid.BeginInit()

        AddColumn(dataGrid, "PR_Line", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Category_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Product_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Supplier_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Actual_Supplier_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Component_ID", System.Type.GetType("System.Int32"), True)

        AddColumn(dataGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Qty", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Qty Reserved", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Order Qty", System.Type.GetType("System.Int32"), True)

        AddColumn(dataGrid, "UOM", System.Type.GetType("System.String"), True)

        AddColumn(dataGrid, "Delivery", System.Type.GetType("System.String"), True)

        'Currency
        AddColumn(dataGrid, "", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Supplier", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Enq Price", System.Type.GetType("System.Double"), True)


        AddColumn(dataGrid, "Actual Supplier", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Actual Price", System.Type.GetType("System.Double"), True)

        AddColumn(dataGrid, "WO No", System.Type.GetType("System.String"), True)

        AddColumn(dataGrid, "PO_Line_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Available Qty", System.Type.GetType("System.Int32"), True)

        dataGrid.EndInit()

        PRLineGrid.DataSource = dataGrid
        PRLineGrid.MainView.PopulateColumns()
        GridView1.BehaviorOptions = GridView1.BehaviorOptions Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowRowSizing
        GridView1.ViewOptions = GridView1.ViewOptions Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth
        GridView1.Columns.Item(0).VisibleIndex = -1
        GridView1.Columns.Item(1).VisibleIndex = -1
        GridView1.Columns.Item(2).VisibleIndex = -1
        GridView1.Columns.Item(3).VisibleIndex = -1
        GridView1.Columns.Item(4).VisibleIndex = -1
        GridView1.Columns.Item(5).VisibleIndex = -1
        GridView1.Columns.Item(18).VisibleIndex = -1

        'Qty
        GridView1.Columns.Item(7).Width = 45
        'UOM
        GridView1.Columns.Item(10).Width = 80
        'Delivery
        GridView1.Columns.Item(11).Width = 70
        'Currency
        GridView1.Columns.Item(12).Width = 30
        'Enq Price
        GridView1.Columns.Item(14).Width = 75
        'Actual Price
        GridView1.Columns.Item(16).Width = 80
        'Work No
        GridView1.Columns.Item(17).Width = 60

        If Quotation_ID <> 0 And Quotation_ID <> Nothing Then
            GridView1.Columns.Item(17).VisibleIndex = -1
        End If

        If UCase(FormStatus) = "APPROVEPR" Or UCase(FormStatus) = "RESERVESTOCK" Then
            GridView1.Columns.Item(10).VisibleIndex = -1
        Else
            GridView1.Columns.Item(8).VisibleIndex = -1
            GridView1.Columns.Item(9).VisibleIndex = -1
        End If
    End Sub

#End Region


#Region " Other Code"

    Private Sub CloseTabPage()

        'Me.Close()
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If

    End Sub

    Private Function CreatePRNo() As String
        Dim DocumentNo As Integer
        Dim grpIntial As String = ""

        If GrpLookup.Text <> "" Then
            grpIntial = (GrpLookup.Text).Substring(0, 1)
            If GrpLookup.Text.ToUpper = "STORE" Then
                grpIntial = "I"
            End If
        End If

        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("PR")
        End With
        CreatePRNo = "PR" & Year(Now) & DocumentNo & grpIntial
    End Function

    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then

            If pInputDate.ToString <> "" Then
                pDate = Date.Parse(pInputDate)
                tempsDate = pDate.Day & "/" & pDate.Month & "/" & pDate.Year
            End If

        End If

        Return tempsDate

    End Function

    Private Sub ClearAll()

        PR_NoTxt.Text = ""

        StatusLookup.Properties.LookUpData.KeyValue = ""
        GrpLookup.Properties.LookUpData.KeyValue = ""
        ReqByLookup.Properties.LookUpData.KeyValue = ""
        ApprovedByLookUp.Properties.LookUpData.KeyValue = ""

        ClearGrid(GridView1)

    End Sub

    Private Sub DisbledAll()

        StatusLookup.Enabled = False
        GrpLookup.Enabled = False
        ReqByLookup.Enabled = False
        ApprovedByLookUp.Enabled = False
        PRDateEdit.Enabled = False

        ReserveStockBtn.Enabled = False
        ' 22.11.2003 YG Start
        UnReserveStockBtn.Visible = False
        AddItemBtn.Enabled = False
        DeleteItemBtn.Enabled = False
        ConfirmBtn.Enabled = False
    End Sub

    Private Function GetUserGroup() As Integer
        Dim ds As DataSet
        Dim userGrp As Integer

        With New BusinessRules.PRBusRules.PRBusLogic
            If .GetUser(ds, UserID) Then
                If Not ds Is Nothing Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Department_ID") Then
                        userGrp = row("Department_ID").ToString()
                    Else
                        userGrp = 0

                    End If
                End If
            End If

        End With

        GetUserGroup = userGrp
    End Function

#End Region

#Region " Code- Check if quotation complete"

    Private Function CheckQuotationComplete(ByVal pQuotation_ID As Integer) As Boolean
        Dim check As Boolean
        check = True

        If pQuotation_ID <> Nothing And pQuotation_ID <> 0 Then
            Dim ds As DataSet
            Dim countRequestQty As Integer

            With New BusinessRules.PRBusRules.PRBusLogic
                If .LoadQuotationComponent(ds, pQuotation_ID) Then
                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1
                        countRequestQty = 0

                        ' YG 22.10.2003 Start
                        '                        If Not oRow("Qty") Is System.DBNull.Value And Not oRow("Component_ID") Is System.DBNull.Value Then
                        '                            countRequestQty = oRow("Qty") - .CountOrderedQty(oRow("Component_ID"), GridView1)
                        '                        End If
                        If Not oRow("OrderQty") Is System.DBNull.Value And Not oRow("Component_ID") Is System.DBNull.Value Then
                            countRequestQty = oRow("OrderQty") - .CountOrderedQty(oRow("Component_ID"), GridView1)
                        End If
                        ' YG 22.10.2003 End

                        If countRequestQty <> 0 Then
                            check = False
                            Exit For
                        End If
                    Next
                End If
            End With
        End If

        Return check
    End Function

#End Region

#Region " Code - Set/Get Window Values"

    'Set windows values
    Private Sub SetWindowsValue()

        'PR No
        PR_NoTxt.Text = PR_No

        'Status
        If Status <> "" Then
            StatusLookup.Properties.LookUpData.KeyValue = Trim(Status)
        End If

        'Group
        If Grp <> Nothing And Grp <> 0 Then
            GrpLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Grp, 0, 0, 0})
        End If

        'PR Date
        If PR_Date <> "" Then
            PRDateEdit.DateTime = Date.Parse(PR_Date).Date
        End If

        If Requester <> Nothing And Requester <> 0 Then
            ReqByLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Requester, 0, 0, 0})
        End If

        If Approver <> Nothing And Approver <> 0 Then
            ApprovedByLookUp.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Approver, 0, 0, 0})
        End If

        If UserID <> Nothing And UserID <> 0 Then
            CreaterLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {UserID, 0, 0, 0})
        End If

        If Submit_Date <> "" Then
            SubmitDateEdit.DateTime = Date.Parse(Submit_Date).Date
        End If
    End Sub

    'Get Window Values
    Private Sub GetWindowsValue()

        'PR No
        PR_No = PR_NoTxt.Text

        'Status
        If StatusLookup.Properties.LookUpData.KeyValue() <> "" Then
            Status = StatusLookup.Properties.LookUpData.KeyValue().ToString()
        Else
            Status = ""
        End If

        'Group
        If GrpLookup.Properties.LookUpData.KeyValue() <> Nothing Then
            Grp = Integer.Parse(GrpLookup.Properties.LookUpData.KeyValue().ToString())
        Else
            Grp = 0
        End If

        'PR Date
        If PRDateEdit.Text <> "" Then
            PR_Date = PRDateEdit.DateTime.Day & " " & MonthName(PRDateEdit.DateTime.Month) & " " & PRDateEdit.DateTime.Year
        Else
            PR_Date = ""
        End If

        'Requested By
        If ReqByLookup.Properties.LookUpData.KeyValue() <> Nothing Then
            Requester = Integer.Parse(ReqByLookup.Properties.LookUpData.KeyValue().ToString())
        Else
            Requester = Nothing
        End If

        'Approved By
        If ApprovedByLookUp.Properties.LookUpData.KeyValue() <> Nothing Then
            Approver = Integer.Parse(ApprovedByLookUp.Properties.LookUpData.KeyValue().ToString())
        Else
            Approver = Nothing
        End If

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If PR_No = "" Then
            ErrorMessage = ErrorMessage & " PR No." & Chr(13)
            DataOK_flag = False
        End If

        'If Category = "" Then
        'ErrorMessage = ErrorMessage & " Category" & Chr(13)
        'DataOK_flag = False
        'End If

        If Status = "" Then
            ErrorMessage = ErrorMessage & " Status" & Chr(13)
            DataOK_flag = False
        End If

        If Grp = Nothing Or Grp = 0 Then
            ErrorMessage = ErrorMessage & " Grp" & Chr(13)
            DataOK_flag = False
        End If

        If PR_Date = "" Then
            ErrorMessage = ErrorMessage & " PR Date" & Chr(13)
            DataOK_flag = False
        End If

        If Requester = Nothing Or Requester = 0 Then
            ErrorMessage = ErrorMessage & " Requester" & Chr(13)
            DataOK_flag = False
        End If

        If GridView1.RowCount = 0 Then
            ErrorMessage = ErrorMessage & " PR Item" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.PRBusRules.PRHeaderBusLogic
                If PR_ID <> Nothing And PR_ID <> 0 Then
                    If .RecordExists(PR_No, PR_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "PR No", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(PR_No, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "PR No", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function

#End Region

#Region " Grid Code "

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub

    Private Sub ClearGrid(ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim i

        If GridView.RowCount() <> 0 Then
            GridView.FocusedRowHandle = 0
            For i = 0 To GridView.RowCount() - 1
                GridView.DeleteRow(GridView.GetSelectedRows(0))
                If GridView.RowCount() <> 0 Then
                    GridView.FocusedRowHandle = 0
                End If
            Next
        End If
    End Sub

#End Region

    Private Sub PRForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PR?", "Close PR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            CloseTabPage()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub PRLineGrid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PRLineGrid.MouseUp
        Dim eventString As String = Nothing

        Dim mouseDownLocation As New Point(e.X, e.Y)

        Select Case e.Button
            Case MouseButtons.Left
                eventString = "L"
            Case MouseButtons.Right
                eventString = "R"
                'ContextMenu1.Show(sender, mouseDownLocation)
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub


    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim Component_ID As Integer = dr(1)

                If Component_ID > 0 Then
                    If Quotation_ID <> 0 And Quotation_ID <> Nothing Then
                        Dim NewForm As New PRItemForm
                        NewForm.Component_ID = Component_ID
                        NewForm.Status = "EDIT"
                        NewForm.ShowDialog(Me)
                    Else
                        'Dim NewForm As New PRItem2
                        'NewForm.Component_ID = Component_ID
                        'NewForm.Status = "EDIT"
                        'NewForm.ShowDialog(Me)
                    End If

                    'RefreshComponentGrid()
                End If
                End If
        End If
    End Sub
End Class
