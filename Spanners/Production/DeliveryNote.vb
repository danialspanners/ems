Public Class DeliveryNoteForm
    Inherits System.Windows.Forms.Form

#Region " DeliveryNoteHeader's variable"
    Public DN_ID As Integer
    Public Status As Integer
    Public DN_No As String
    Public WO_ID As Integer
    Public Supplier_ID As Integer
    Public Completion_Date As String
    Public Remark As String
    Public Process_Type As String
    Public RevRefDNID As Integer
    Public Create_Date As String
    Public Transact_Date As String
#End Region

#Region " DeliveryNoteLine's variable"
    Public DN_Line_ID As Integer
    Public LnDN_ID As Integer
    Public LnPartCode_ID As Integer
    Public LnQty As String
    Public LnCategory_ID As Integer
    Public LnProduct_ID As Integer
    Public LnWIP As String
    Public LnInstruction As String
    Public LnColor_ID As Integer
    Public LnDimension As String
    Public LnCreate_Date As String
    Public LnTransact_Date As String
    Public LnUserID As Integer
#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public FormStatus As String
    Public Old_DN_ID As Integer
    Public DNds As DataSet

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pDN_ID As Integer = 0, Optional ByVal pOld_DN_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus

        If Not pDN_ID = 0 Then
            DN_ID = pDN_ID
        End If

        If Not pOld_DN_ID = 0 Then
            Old_DN_ID = pOld_DN_ID
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
    Friend WithEvents StatusCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents StatusLbl As System.Windows.Forms.Label
    Friend WithEvents DNNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierNameLbl As System.Windows.Forms.Label
    Friend WithEvents DNNoLbl As System.Windows.Forms.Label
    Friend WithEvents WONoLbl As System.Windows.Forms.Label
    Friend WithEvents DNComDateLbl As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Rdbtn3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Rdbtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdBtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DispatchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DNCompleteDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DNLineGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents Project As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Line_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Product As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WOCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DelDNLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents EditDNLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NewDNLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SupplierCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RemarkTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents WIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIPCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Instruction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Dimension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIPChkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PartCodeLookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ColorLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ProductLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Rdbtn3 = New System.Windows.Forms.RadioButton
        Me.Label43 = New System.Windows.Forms.Label
        Me.Rdbtn2 = New System.Windows.Forms.RadioButton
        Me.RdBtn1 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.RemarkTxt = New DevExpress.XtraEditors.MemoEdit
        Me.DNComDateLbl = New System.Windows.Forms.Label
        Me.DNCompleteDate = New DevExpress.XtraEditors.DateEdit
        Me.WONoLbl = New System.Windows.Forms.Label
        Me.WOCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.DNNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.StatusCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.SupplierCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.StatusLbl = New System.Windows.Forms.Label
        Me.SupplierNameLbl = New System.Windows.Forms.Label
        Me.DNNoLbl = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DNLineGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.WIPCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.WIPChkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PartCodeLookupEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ColorLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ProductLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Line_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Project = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Category = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Product = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Instruction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Color = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Dimension = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DispatchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DelDNLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EditDNLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewDNLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.GroupBox1.SuspendLayout()
        CType(Me.RemarkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNCompleteDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WOCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNLineGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIPCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIPChkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeLookupEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rdbtn3)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Rdbtn2)
        Me.GroupBox1.Controls.Add(Me.RdBtn1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.RemarkTxt)
        Me.GroupBox1.Controls.Add(Me.DNComDateLbl)
        Me.GroupBox1.Controls.Add(Me.DNCompleteDate)
        Me.GroupBox1.Controls.Add(Me.WONoLbl)
        Me.GroupBox1.Controls.Add(Me.WOCmb)
        Me.GroupBox1.Controls.Add(Me.DNNoTxt)
        Me.GroupBox1.Controls.Add(Me.StatusCmb)
        Me.GroupBox1.Controls.Add(Me.SupplierCmb)
        Me.GroupBox1.Controls.Add(Me.StatusLbl)
        Me.GroupBox1.Controls.Add(Me.SupplierNameLbl)
        Me.GroupBox1.Controls.Add(Me.DNNoLbl)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 152)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Rdbtn3
        '
        Me.Rdbtn3.Location = New System.Drawing.Point(376, 112)
        Me.Rdbtn3.Name = "Rdbtn3"
        Me.Rdbtn3.Size = New System.Drawing.Size(208, 16)
        Me.Rdbtn3.TabIndex = 60
        Me.Rdbtn3.Text = "One-to-one (Powder Coating/Repair)"
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(400, 64)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(120, 16)
        Me.Label43.TabIndex = 59
        Me.Label43.Text = "Assembly/Fabrication"
        Me.Label43.Visible = False
        '
        'Rdbtn2
        '
        Me.Rdbtn2.Location = New System.Drawing.Point(384, 64)
        Me.Rdbtn2.Name = "Rdbtn2"
        Me.Rdbtn2.Size = New System.Drawing.Size(16, 16)
        Me.Rdbtn2.TabIndex = 58
        Me.Rdbtn2.Visible = False
        '
        'RdBtn1
        '
        Me.RdBtn1.Location = New System.Drawing.Point(376, 96)
        Me.RdBtn1.Name = "RdBtn1"
        Me.RdBtn1.Size = New System.Drawing.Size(16, 16)
        Me.RdBtn1.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(392, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Cutting/Break Down"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(16, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "Remarks :"
        '
        'RemarkTxt
        '
        Me.RemarkTxt.Location = New System.Drawing.Point(104, 88)
        Me.RemarkTxt.Name = "RemarkTxt"
        Me.RemarkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RemarkTxt.Size = New System.Drawing.Size(248, 48)
        Me.RemarkTxt.TabIndex = 45
        '
        'DNComDateLbl
        '
        Me.DNComDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNComDateLbl.Location = New System.Drawing.Point(256, 40)
        Me.DNComDateLbl.Name = "DNComDateLbl"
        Me.DNComDateLbl.Size = New System.Drawing.Size(104, 16)
        Me.DNComDateLbl.TabIndex = 44
        Me.DNComDateLbl.Text = "* Completion Date :"
        '
        'DNCompleteDate
        '
        Me.DNCompleteDate.DateTime = New Date(CType(0, Long))
        Me.DNCompleteDate.Location = New System.Drawing.Point(368, 40)
        Me.DNCompleteDate.Name = "DNCompleteDate"
        Me.DNCompleteDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DNCompleteDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DNCompleteDate.Size = New System.Drawing.Size(104, 19)
        Me.DNCompleteDate.TabIndex = 43
        '
        'WONoLbl
        '
        Me.WONoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WONoLbl.Location = New System.Drawing.Point(8, 40)
        Me.WONoLbl.Name = "WONoLbl"
        Me.WONoLbl.Size = New System.Drawing.Size(96, 16)
        Me.WONoLbl.TabIndex = 42
        Me.WONoLbl.Text = "* Work Order No :"
        '
        'WOCmb
        '
        Me.WOCmb.Location = New System.Drawing.Point(104, 40)
        Me.WOCmb.Name = "WOCmb"
        Me.WOCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WOCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WOCmb.Properties.NullString = ""
        Me.WOCmb.Size = New System.Drawing.Size(128, 19)
        Me.WOCmb.TabIndex = 41
        '
        'DNNoTxt
        '
        Me.DNNoTxt.Location = New System.Drawing.Point(104, 16)
        Me.DNNoTxt.Name = "DNNoTxt"
        Me.DNNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DNNoTxt.Properties.ReadOnly = True
        Me.DNNoTxt.Size = New System.Drawing.Size(128, 19)
        Me.DNNoTxt.TabIndex = 33
        '
        'StatusCmb
        '
        Me.StatusCmb.Enabled = False
        Me.StatusCmb.Location = New System.Drawing.Point(368, 16)
        Me.StatusCmb.Name = "StatusCmb"
        Me.StatusCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusCmb.Properties.Enabled = False
        Me.StatusCmb.Properties.NullString = ""
        Me.StatusCmb.Size = New System.Drawing.Size(104, 19)
        Me.StatusCmb.TabIndex = 4
        '
        'SupplierCmb
        '
        Me.SupplierCmb.Location = New System.Drawing.Point(104, 64)
        Me.SupplierCmb.Name = "SupplierCmb"
        Me.SupplierCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SupplierCmb.Properties.NullString = ""
        Me.SupplierCmb.Properties.PopupWidth = 304
        Me.SupplierCmb.Size = New System.Drawing.Size(128, 19)
        Me.SupplierCmb.TabIndex = 3
        '
        'StatusLbl
        '
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(256, 24)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(56, 16)
        Me.StatusLbl.TabIndex = 16
        Me.StatusLbl.Text = "Status :"
        '
        'SupplierNameLbl
        '
        Me.SupplierNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierNameLbl.Location = New System.Drawing.Point(8, 64)
        Me.SupplierNameLbl.Name = "SupplierNameLbl"
        Me.SupplierNameLbl.Size = New System.Drawing.Size(104, 16)
        Me.SupplierNameLbl.TabIndex = 10
        Me.SupplierNameLbl.Text = "* Sub-Contractor :"
        '
        'DNNoLbl
        '
        Me.DNNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNNoLbl.Location = New System.Drawing.Point(8, 20)
        Me.DNNoLbl.Name = "DNNoLbl"
        Me.DNNoLbl.Size = New System.Drawing.Size(96, 16)
        Me.DNNoLbl.TabIndex = 11
        Me.DNNoLbl.Text = "* Delivery Note :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(360, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 64)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'DNLineGrid
        '
        Me.DNLineGrid.EditorsRepository = Me.PersistentRepository1
        Me.DNLineGrid.Location = New System.Drawing.Point(16, 168)
        Me.DNLineGrid.MainView = Me.GridView1
        Me.DNLineGrid.Name = "DNLineGrid"
        Me.DNLineGrid.Size = New System.Drawing.Size(600, 224)
        Me.DNLineGrid.TabIndex = 86
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.WIPCheckEdit, Me.WIPChkEdit, Me.PartCodeLookupEdit, Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoExEdit1, Me.ColorLookUpEdit, Me.ProductLookUpEdit})
        '
        'WIPCheckEdit
        '
        Me.WIPCheckEdit.Name = "WIPCheckEdit"
        Me.WIPCheckEdit.Properties.AllowFocused = False
        Me.WIPCheckEdit.Properties.AutoHeight = False
        Me.WIPCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'WIPChkEdit
        '
        Me.WIPChkEdit.Name = "WIPChkEdit"
        Me.WIPChkEdit.Properties.AllowFocused = False
        Me.WIPChkEdit.Properties.AutoHeight = False
        Me.WIPChkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WIPChkEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.WIPChkEdit.Properties.ValueChecked = "1"
        Me.WIPChkEdit.Properties.ValueUnchecked = "0"
        '
        'PartCodeLookupEdit
        '
        Me.PartCodeLookupEdit.Name = "PartCodeLookupEdit"
        Me.PartCodeLookupEdit.Properties.AllowFocused = False
        Me.PartCodeLookupEdit.Properties.AutoHeight = False
        Me.PartCodeLookupEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PartCodeLookupEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PartCodeLookupEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PartCodeLookupEdit.Properties.NullString = ""
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.Properties.AllowFocused = False
        Me.RepositoryItemMemoExEdit1.Properties.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoExEdit1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemMemoExEdit1.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        '
        'ColorLookUpEdit
        '
        Me.ColorLookUpEdit.Name = "ColorLookUpEdit"
        Me.ColorLookUpEdit.Properties.AllowFocused = False
        Me.ColorLookUpEdit.Properties.AutoHeight = False
        Me.ColorLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ColorLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ColorLookUpEdit.Properties.NullString = ""
        '
        'ProductLookUpEdit
        '
        Me.ProductLookUpEdit.Name = "ProductLookUpEdit"
        Me.ProductLookUpEdit.Properties.AllowFocused = False
        Me.ProductLookUpEdit.Properties.AutoHeight = False
        Me.ProductLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ProductLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProductLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ProductLookUpEdit.Properties.NullString = ""
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType(((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Line_ID, Me.Project, Me.Qty, Me.Category, Me.Product, Me.WIP, Me.Instruction, Me.Color, Me.Dimension})
        Me.GridView1.DefaultEdit = Me.WIPCheckEdit
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType(((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'Line_ID
        '
        Me.Line_ID.Caption = "Line ID"
        Me.Line_ID.FieldName = "DN_Line_ID"
        Me.Line_ID.Name = "Line_ID"
        '
        'Project
        '
        Me.Project.Caption = "Part Code"
        Me.Project.ColumnEdit = Me.PartCodeLookupEdit
        Me.Project.FieldName = "PartCode_ID"
        Me.Project.Name = "Project"
        Me.Project.VisibleIndex = 0
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.Qty.Name = "Qty"
        Me.Qty.VisibleIndex = 1
        '
        'Category
        '
        Me.Category.Caption = "Category"
        Me.Category.FieldName = "Category_Name"
        Me.Category.Name = "Category"
        '
        'Product
        '
        Me.Product.Caption = "Product"
        Me.Product.ColumnEdit = Me.ProductLookUpEdit
        Me.Product.FieldName = "Product_ID"
        Me.Product.Name = "Product"
        '
        'WIP
        '
        Me.WIP.Caption = "WIP"
        Me.WIP.ColumnEdit = Me.WIPChkEdit
        Me.WIP.FieldName = "WIP"
        Me.WIP.Name = "WIP"
        Me.WIP.VisibleIndex = 2
        '
        'Instruction
        '
        Me.Instruction.Caption = "Instructions"
        Me.Instruction.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Instruction.FieldName = "Instruction"
        Me.Instruction.Name = "Instruction"
        Me.Instruction.VisibleIndex = 3
        '
        'Color
        '
        Me.Color.Caption = "Color"
        Me.Color.ColumnEdit = Me.ColorLookUpEdit
        Me.Color.FieldName = "Color_ID"
        Me.Color.Name = "Color"
        Me.Color.VisibleIndex = 4
        '
        'Dimension
        '
        Me.Dimension.Caption = "Dimension"
        Me.Dimension.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Dimension.FieldName = "Dimension"
        Me.Dimension.Name = "Dimension"
        Me.Dimension.VisibleIndex = 5
        '
        'DispatchBtn
        '
        Me.DispatchBtn.AutoSize = False
        Me.DispatchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DispatchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DispatchBtn.Image = Nothing
        Me.DispatchBtn.Location = New System.Drawing.Point(472, 400)
        Me.DispatchBtn.Name = "DispatchBtn"
        Me.DispatchBtn.Size = New System.Drawing.Size(64, 32)
        Me.DispatchBtn.TabIndex = 89
        Me.DispatchBtn.Text = "Dispatch"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(552, 400)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 88
        Me.CloseBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(392, 400)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 87
        Me.SaveBtn.Text = "Save"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(224, 400)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 134
        Me.btnRefresh.Text = "Refresh"
        '
        'DelDNLineBtn
        '
        Me.DelDNLineBtn.AutoSize = False
        Me.DelDNLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelDNLineBtn.Enabled = False
        Me.DelDNLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelDNLineBtn.Image = Nothing
        Me.DelDNLineBtn.Location = New System.Drawing.Point(312, 400)
        Me.DelDNLineBtn.Name = "DelDNLineBtn"
        Me.DelDNLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.DelDNLineBtn.TabIndex = 137
        Me.DelDNLineBtn.Text = "Delete"
        '
        'EditDNLineBtn
        '
        Me.EditDNLineBtn.AutoSize = False
        Me.EditDNLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditDNLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditDNLineBtn.Image = Nothing
        Me.EditDNLineBtn.Location = New System.Drawing.Point(88, 168)
        Me.EditDNLineBtn.Name = "EditDNLineBtn"
        Me.EditDNLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.EditDNLineBtn.TabIndex = 136
        Me.EditDNLineBtn.Text = "Edit"
        Me.EditDNLineBtn.Visible = False
        '
        'NewDNLineBtn
        '
        Me.NewDNLineBtn.AutoSize = False
        Me.NewDNLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewDNLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewDNLineBtn.Image = Nothing
        Me.NewDNLineBtn.Location = New System.Drawing.Point(16, 168)
        Me.NewDNLineBtn.Name = "NewDNLineBtn"
        Me.NewDNLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.NewDNLineBtn.TabIndex = 135
        Me.NewDNLineBtn.Text = "Add"
        Me.NewDNLineBtn.Visible = False
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.WIPCheckEdit})
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Delete})
        '
        'Delete
        '
        Me.Delete.Index = 0
        Me.Delete.Text = "Delete"
        '
        'DeliveryNoteForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 437)
        Me.Controls.Add(Me.DNLineGrid)
        Me.Controls.Add(Me.DelDNLineBtn)
        Me.Controls.Add(Me.EditDNLineBtn)
        Me.Controls.Add(Me.NewDNLineBtn)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DispatchBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DeliveryNoteForm"
        Me.Text = "Delivery Note"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.RemarkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNCompleteDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WOCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNLineGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIPCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIPChkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeLookupEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Other Events"
    Private Sub DNLineGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)
            End If
        End If
    End Sub
#End Region

#Region " Codes for Form load"
    Private Sub DeliveryFormForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        LoadWorkOrderNo()
        LoadSupplier()
        LoadCombo()
        LoadProjectCombo()
        LoadColorCombo()
        LoadProductCombo()

        Select Case UCase(FormStatus)
            Case "NEW"
                Me.Text = "New Work Plan"
                InitializeForm()
                SaveBtn.Enabled = True
                NewDNLineBtn.Enabled = True
                EditDNLineBtn.Enabled = True
                'DelDNLineBtn.Enabled = True
                DispatchBtn.Enabled = False
            Case "EDIT"
                Me.Text = "Edit Work Plan"
                With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetDeliveryNoteHeader(dsHeaderLoad, DN_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                LoadDNLineList(DN_ID)
                SaveBtn.Enabled = True
                NewDNLineBtn.Enabled = True
                'EditDNLineBtn.Enabled = True
                'DelDNLineBtn.Enabled = True
                DispatchBtn.Enabled = True
            Case "VIEW"
                LoadDNLineList(DN_ID)
                Me.Text = "View Delivery Note"
                With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetDeliveryNoteHeader(dsHeaderLoad, DN_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                NewDNLineBtn.Enabled = False
                EditDNLineBtn.Enabled = True
                EditDNLineBtn.Text = "View"
                DelDNLineBtn.Enabled = False
                SaveBtn.Enabled = False
                DispatchBtn.Enabled = False
            Case "REVISED"
                Me.Text = "Revise Quotation"
                RevisedDNHeader()
                RevisedDNLine()
                SetOldDNStatus()
                DispatchBtn.Enabled = True
                SaveBtn.Enabled = True
                NewDNLineBtn.Enabled = True
                EditDNLineBtn.Enabled = True
                DelDNLineBtn.Enabled = True
                DispatchBtn.Enabled = True
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()

        StatusCmb.Properties.LookUpData.KeyValue = "10"
        DNNoTxt.Text = CreateDNNo()
        RemarkTxt.Text = ""
        DNCompleteDate.DateTime = Date.Today
        RdBtn1.Checked = True
        Rdbtn2.Checked = False
        Rdbtn3.Checked = False

    End Sub

    Private Function CreateDNNo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("DN")
        End With
        CreateDNNo = "DN" & Year(Now) & DocumentNo
    End Function

    Private Sub LoadDNLineList(ByVal pDN_ID As String)
        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
            .DN_ID = pDN_ID
            If .GetDNLine_Display(DNds, pDN_ID) Then
                DNLineGrid.DataSource = DNds.Tables(0).DefaultView
                If DNds.Tables(0).Rows.Count() = 0 Then
                    DelDNLineBtn.Enabled = False
                    EditDNLineBtn.Enabled = False
                End If
                If DNds.Tables(0).Rows.Count() > 0 Then
                    DelDNLineBtn.Enabled = True
                    EditDNLineBtn.Enabled = True
                End If
            End If
        End With

    End Sub

#End Region

#Region " Codes for Revised WorkPlan"
    Private Sub SetOldDNStatus()
        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
            .DN_ID = Old_DN_ID
            .Status = "40"
            If .UpdateDeliveryNoteHeaderStatus() Then

            End If
        End With
    End Sub

    Private Sub RevisedDNHeader()
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedDN As DataSet
        Dim BasedDN_ID As Integer

        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
            If .GetDeliveryNoteHeader(dsLoad, Old_DN_ID) Then
                'Check if its created from revised quotation or based quotation
                .DN_ID = Old_DN_ID
                If .IsRevisedDN(dsBasedDN) Then        'if its revised Delivery Note, then load based Delivery Note
                    BasedDN_ID = dsBasedDN.Tables(0).Rows(0)("DN_ID")
                    DN_No = dsBasedDN.Tables(0).Rows(0)("DN_NO")
                    'COUNT THE NO OF REVISED COPY
                    .RevRefDNID = BasedDN_ID
                    RevisedNo = .CountNoOfRevisedDN()
                    '****
                    RevRefDNID = BasedDN_ID        'Reference to the based ID
                Else
                    DN_No = dsLoad.Tables(0).Rows(0)("DN_NO")  'Get the Existing Delivery Note No.
                    'COUNT THE NO OF REVISED COPY
                    .RevRefDNID = Old_DN_ID
                    RevisedNo = .CountNoOfRevisedDN()
                    '****
                    RevRefDNID = Old_DN_ID        'Reference
                End If
                '****

                'CHECKING
                .DN_No = DN_No & "R" & RevisedNo          'Appending R...
                If .CheckExistingDNNo() Then              'Record exist
                    RevisedNo = RevisedNo + 1
                    .DN_No = DN_No & "R" & RevisedNo
                    While .CheckExistingDNNo
                        RevisedNo = RevisedNo + 1
                        .DN_No = DN_No & "R" & RevisedNo
                    End While
                End If
                '***

                .Status = "10"
                .UserID = UserID
                If .SaveDNNo() Then
                    DN_ID = .DN_ID    'Get the new Delivery Note ID
                    'saving
                    .DN_ID = DN_ID
                    .DN_No = dsLoad.Tables(0).Rows(0)("DN_No")

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("WO_ID")) Then
                        .WO_ID = dsLoad.Tables(0).Rows(0)("WO_ID")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Supplier_ID")) Then
                        .Supplier_ID = dsLoad.Tables(0).Rows(0)("Supplier_ID")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Completion_Date")) Then
                        .Completion_Date = dsLoad.Tables(0).Rows(0)("Completion_Date")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remark")) Then
                        .Remark = dsLoad.Tables(0).Rows(0)("Remark")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Process_Type")) Then
                        .Process_Type = dsLoad.Tables(0).Rows(0)("Process_Type")
                    End If

                    If .UpdateDeliveryNoteHeader(DN_ID) Then
                        Dim dsNew As DataSet
                        If .GetDNHeader(dsNew, DN_ID) Then
                            SetWindowValue(dsNew)
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With
    End Sub

    Private Sub RevisedDNLine()
        Dim dsLine As DataSet
        Dim Old_DNLine_ID As Integer

        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
            'Get the old Delivery Note line item
            .DN_ID = Old_DN_ID
            If .GetDNLine(dsLine) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    .DN_ID = DN_ID
                    .UserID = UserID
                    If .SaveDNLineFirstTime() Then
                        DN_Line_ID = .DN_Line_ID
                    End If
                    '***
                    Old_DNLine_ID = dsLine.Tables(0).Rows(x)("DN_Line_ID")
                    .LnDN_ID = dsLine.Tables(0).Rows(x)("DN_ID")
                    .LnPartCode_ID = dsLine.Tables(0).Rows(x)("PartCode_ID")
                    .LnQty = dsLine.Tables(0).Rows(x)("LnQty")
                    .LnCategory_ID = dsLine.Tables(0).Rows(x)("Category_ID")
                    .LnProduct_ID = dsLine.Tables(0).Rows(x)("Product_ID")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("WIP")) Then
                        .LnWIP = dsLine.Tables(0).Rows(x)("WIP")
                    End If
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Instruction")) Then
                        .LnInstruction = dsLine.Tables(0).Rows(x)("Instruction")
                    End If
                    .LnColor_ID = dsLine.Tables(0).Rows(x)("Color_ID")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Dimension")) Then
                        .LnDimension = dsLine.Tables(0).Rows(x)("Dimension")
                    End If
                    .UserID = UserID

                    .UpdateDNLine(DN_Line_ID)
                Next
                dsLine.Dispose()
            End If
        End With
    End Sub

#End Region

#Region "Button Events"

    Private Sub NewDNLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDNLineBtn.Click

        If SaveDeliveryNote(1) Then
            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New DeliveryNoteLineForm("NEW", DN_ID, )
            page = New Crownwood.Magic.Controls.TabPage("New Delivery Note Line", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub EditDNLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDNLineBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim DNLine_ID As Integer = dr("DN_Line_ID")

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            If UCase(FormStatus) = "VIEW" Then       'Confirmed. View only
                controlToAdd = New DeliveryNoteLineForm("VIEW", DN_ID, DNLine_ID)
                page = New Crownwood.Magic.Controls.TabPage("View Delivery Note Line", controlToAdd, ImageList1, 0)
            Else
                controlToAdd = New DeliveryNoteLineForm("EDIT", DN_ID, DNLine_ID)
                page = New Crownwood.Magic.Controls.TabPage("Edit Delivery Note Line", controlToAdd, ImageList1, 0)
            End If

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub


    Private Sub DelDNLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelDNLineBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim DNLine_ID As Integer = dr("DN_Line_ID")
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this Delivery Note Line?", "Delivery Note Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                    If .DeleteDeliveryNoteLine(DNLine_ID) Then
                        MessageBox.Show("Delivery Note Line Deleted.", "Delivery Note Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            LoadDNLineList(DN_ID)
        End If
    End Sub

    Private Sub DispatchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchBtn.Click
        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
            .DN_ID = DN_ID
            .Status = "50"      'Confirm status
            If .UpdateDeliveryNoteHeaderStatus() Then
                MessageBox.Show("Status updated.", "WDelivery Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                StatusCmb.Properties.LookUpData.KeyValue = "50"
            End If
            Dim b As MainForm = Me.ParentForm ' page.Control.Name()
            For i As Integer = 0 To b.MainTabControl.TabPages.Count - 1
                If b.MainTabControl.TabPages.Item(i).Control.Name() = "DeliveryNoteListForm" Then
                    Dim c As DeliveryNoteListForm = b.MainTabControl.TabPages.Item(i).Control
                    c.LoadDeliveryNoteList()
                    Exit For
                End If
            Next
        End With
    End Sub


    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveDeliveryNote()
        SaveDeliveryNoteLine()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadDNLineList(DN_ID)
    End Sub


#End Region

#Region "Save"
    Private Function SaveDeliveryNote(Optional ByVal bktype As Integer = 0) As Boolean
        Dim bkFlag As Boolean = False

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                .DN_No = DN_No
                .WO_ID = WO_ID
                .Status = Status
                .Supplier_ID = Supplier_ID
                .Remark = Remark
                .Completion_Date = Completion_Date
                .Process_Type = Process_Type
                If UCase(FormStatus) = "REVISED" Then
                    .RevRefDNID = RevRefDNID
                End If
                .UserID = UserID

                If DN_ID = Nothing Or DN_ID = 0 Then
                    DN_ID = .SaveDeliveryNoteHeader()
                    DN_ID = .DN_ID
                    If bktype <> 1 Then
                        MessageBox.Show("Delivery Note saved!", "Save Delivery Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bkFlag = True
                    LoadDNLineList(DN_ID)
                Else
                    .UpdateDeliveryNoteHeader(DN_ID)
                    If bktype <> 1 Then
                        MessageBox.Show("Delivery Note updated!", "Updates Delivery Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bkFlag = True
                End If
            End With
        End If
        Return bkFlag
    End Function

    Private Sub SaveDeliveryNoteLine()

        Dim ErrorMessage
        Dim DataOk_flag = True

        Me.GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()
        If Not Me.DNds Is Nothing Then
            If DNds.Tables(0).Rows.Count > 0 Then
                With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic

                    For i As Integer = 0 To DNds.Tables(0).Rows.Count - 1
                        If IsDBNull(DNds.Tables(0).Rows(i)("color_ID")) Then
                            .LnColor_ID = 0
                            ErrorMessage = ErrorMessage & " Color name" & Chr(13)
                            DataOk_flag = False
                        End If
                    Next
                    If DataOk_flag = False Then
                        With New Common.CommonError.ErrorMsg
                            MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End With
                    Else
                        For i As Integer = 0 To DNds.Tables(0).Rows.Count - 1
                            .DN_ID = DN_ID
                            If Not IsDBNull(DNds.Tables(0).Rows(i)("DN_Line_ID")) Then
                                DN_Line_ID = DNds.Tables(0).Rows(i)("DN_Line_ID")
                            End If
                            .LnCategory_ID = 0
                            .LnProduct_ID = 0
                            If IsDBNull(DNds.Tables(0).Rows(i)("PartCode_ID")) Then
                                .LnPartCode_ID = 0
                                ErrorMessage = ErrorMessage & " Part Code" & Chr(13)
                                DataOk_flag = False

                            Else
                                .LnPartCode_ID = DNds.Tables(0).Rows(i)("PartCode_ID").ToString()
                            End If
                            If IsDBNull(DNds.Tables(0).Rows(i)("Qty")) Then
                                .LnQty = 0
                            Else
                                .LnQty = DNds.Tables(0).Rows(i)("qty").ToString()
                            End If
                            If IsDBNull(DNds.Tables(0).Rows(i)("color_ID")) Then
                                .LnColor_ID = 0
                                ErrorMessage = ErrorMessage & " Color name" & Chr(13)
                                DataOk_flag = False

                            Else
                                .LnColor_ID = DNds.Tables(0).Rows(i)("color_ID").ToString()
                            End If

                            If IsDBNull(DNds.Tables(0).Rows(i)("WIP")) Then
                                .LnWIP = 0
                            Else
                                .LnWIP = DNds.Tables(0).Rows(i)("WIP").ToString()
                            End If
                            If IsDBNull(DNds.Tables(0).Rows(i)("Instruction")) Then
                                .LnInstruction = ""
                            Else
                                .LnInstruction = Replace(DNds.Tables(0).Rows(i)("Instruction").ToString(), "'", "''")
                            End If
                            If IsDBNull(DNds.Tables(0).Rows(i)("Dimension")) Then
                                .LnDimension = ""
                            Else
                                .LnDimension = Replace(DNds.Tables(0).Rows(i)("Dimension").ToString(), "'", "''")
                            End If

                            .UserID = Common.CommonConn.Config.USERID

                            If IsDBNull(DNds.Tables(0).Rows(i)("DN_Line_ID")) Then
                                .SaveDNLine()
                            Else
                                .UpdateDNLine(DN_Line_ID)
                            End If
                        Next
                    End If
                    'LoadWorkOrderNo()
                    'LoadSupplier()
                    'LoadCombo()
                    'LoadProjectCombo()
                    'LoadColorCombo()
                    'LoadProductCombo()

                End With

                If DataOk_flag Then
                    LoadDNLineList(DN_ID)
                End If
            End If
        End If
    End Sub

#End Region

#Region "Load Combo Box"
    Private Sub LoadWorkOrderNo(Optional ByVal pWO_ID As Integer = 0)
        Dim ds As DataSet
        If GetWOHeader(ds, pWO_ID) Then
            If Not ds Is Nothing Then
                Try
                    'SimpleBinding LookUp adjustment start
                    AddListFieldInfoToLookUp(WOCmb, "WO_No", 400, 0, "c")
                    WOCmb.Properties.LookUpData.KeyField = "WO_ID"
                    WOCmb.Properties.LookUpData.DisplayField = "WO_No"

                    WOCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    WOCmb.EditValue = "0"
                    'SimpleBinding LookUp adjustment end
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub LoadSupplier()
        Dim ds As DataSet

        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .GetSupplierHeader(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(SupplierCmb, "Supplier_Name", 400, 0, "c")
                        SupplierCmb.Properties.LookUpData.KeyField = "Supplier_ID"
                        SupplierCmb.Properties.LookUpData.DisplayField = "Supplier_Name"

                        SupplierCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        SupplierCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadCombo()
        Dim StatusData As String() = New String() {"Preparing", "Revised", "Confirmed"}
        Dim StatusID As String() = New String() {"10", "40", "50"}
        SetComboValue(StatusData, StatusCmb, StatusID)
    End Sub

    Private Sub LoadProjectCombo()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.PartCodeBusLogic '.ProjectBusLogic
            If .GetPartCode(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToRepositoryLookUp(PartCodeLookupEdit, "PartCodeName", 400, 0, "c")
                        PartCodeLookupEdit.Properties.LookUpData.KeyField = "PartCode_ID"
                        PartCodeLookupEdit.Properties.LookUpData.DisplayField = "PartCodeName"
                        PartCodeLookupEdit.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With

    End Sub

    Private Sub LoadColorCombo()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToRepositoryLookUp(ColorLookUpEdit, "Color_Name", 400, 0, "c")
                        ColorLookUpEdit.Properties.LookUpData.KeyField = "Color_ID"
                        ColorLookUpEdit.Properties.LookUpData.DisplayField = "Color_Name"

                        ColorLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)

                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadProductCombo()

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
    Private Sub AddListFieldInfoToRepositoryLookUp(ByVal le As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToRepositoryLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

#Region "Get/Set Window Value"

    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        Dim ProcessType As Integer

        DNNoTxt.Text = dsLoad.Tables(0).Rows(0)("DN_NO")
        StatusCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Status")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("WO_ID")) Then
            WOCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("WO_ID")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Completion_Date")) Then
            DNCompleteDate.DateTime = dsLoad.Tables(0).Rows(0)("Completion_Date")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Supplier_ID")) Then
            SupplierCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Supplier_ID")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remark")) Then
            RemarkTxt.Text = dsLoad.Tables(0).Rows(0)("Remark")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Process_Type")) Then
            ProcessType = dsLoad.Tables(0).Rows(0)("Process_Type")
            If ProcessType = 1 Then
                RdBtn1.Checked = True
                Rdbtn2.Checked = False
                Rdbtn3.Checked = False
            ElseIf ProcessType = 2 Then
                Rdbtn2.Checked = True
                RdBtn1.Checked = False
                Rdbtn3.Checked = False
            Else
                Rdbtn3.Checked = True
                RdBtn1.Checked = False
                Rdbtn2.Checked = False
            End If
        End If

    End Sub

    Private Sub GetWindowsValue()

        DN_No = DNNoTxt.Text
        Status = StatusCmb.Properties.LookUpData.KeyValue
        WO_ID = WOCmb.Properties.LookUpData.KeyValue
        Supplier_ID = SupplierCmb.Properties.LookUpData.KeyValue
        Remark = RemarkTxt.Text
        Completion_Date = DNCompleteDate.Text
        If RdBtn1.Checked = True Then
            Process_Type = 1
        ElseIf Rdbtn2.Checked = True Then
            Process_Type = 2
        Else
            Process_Type = 3
        End If
    End Sub

#End Region

#Region "Utilities"
    ' May be should put the following functions in the common
    Private Function GetWOHeader(ByRef ds As DataSet, Optional ByVal pWO_ID As Integer = 0) As Boolean
        With New DataAccess.DAccess.Access
            Dim SQLStr As String

            If pWO_ID > 0 Then
                SQLStr = "SELECT * FROM WorkOrderHeader where WO_ID = " & Integer.Parse(pWO_ID)
            Else
                SQLStr = "SELECT * FROM WorkOrderHeader "
            End If

            If .GetDataSet(ds, SQLStr) Then
                Return True
            End If
        End With
    End Function

#End Region

#Region "Validation"
    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If DN_No = "" Then
            ErrorMessage = ErrorMessage & " Work Plan No" & Chr(13)
            DataOK_flag = False
        End If

        If WO_ID = 0 Then
            ErrorMessage = ErrorMessage & " Work Order Number" & Chr(13)
            DataOK_flag = False
        End If

        If Supplier_ID = 0 Then
            ErrorMessage = ErrorMessage & " Supplier" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                If DN_ID <> Nothing And DN_ID <> 0 Then
                    If .RecordExists(DN_No, DN_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(DN_No, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function
#End Region


    Private Sub DeliveryNoteForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Delivery Note?", "Delivery Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

    Private Sub DNLineGrid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DNLineGrid.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        Dim eventString As String = Nothing
        Select Case e.Button
            Case MouseButtons.Left
                eventString = "L"
            Case MouseButtons.Right
                eventString = "R"
                ComponentContextMenu.Show(sender, mouseDownLocation)
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub

    Private Sub Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Delete.Click
        DelDNLineBtn_Click(Me, e)
    End Sub
End Class
