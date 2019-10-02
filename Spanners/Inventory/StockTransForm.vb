Public Class StockTransForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitProductList()
        InitalUserCombo()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pFormType As String, ByVal pTransactDate As DateTime)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FormType = pFormType
        If FormType = "DO" Or FormType = "PMR" Or FormType = "SA" Then
            Label2.Visible = True
            PO_NOtxt.Visible = True
            Me.lookupArea.Visible = True
            Me.txtArea.Visible = False
            Me.MemoEdit.Location = New System.Drawing.Point(98, 156)
            Me.MemoEdit.Size = New System.Drawing.Size(444, 48)
            Me.Label1.Location = New System.Drawing.Point(30, 156)
        ElseIf FormType = "ST" Then
            Me.lblWarehouse.Visible = False
            Me.txtWarehouse.Visible = False
            Me.Label6.Visible = True
            Me.LookUpArea2.Visible = True
            Me.lblArea.Text = "To:"
            Me.Transactdate.DateTime = Date.Today
        End If
        InitProductList()
        InitalUserCombo()

        If FormType = "PMR" Or FormType = "SRV" Or FormType = "FGW" Or FormType = "INT" Then
            InitalStockAreaCombo()
        ElseIf FormType = "ST" Then
            InitialFromToAreaCombo()
        Else
            InitalAreaCombo()
        End If

        Me.lookupArea.Visible = True
        Transactdate.DateTime = Date.Today


        If FormType = "QAR" Or FormType = "FGW" Or FormType = "INT" Then
            If pTransactDate <> Nothing Then
                Me.Transactdate.DateTime = pTransactDate
                Me.Transactdate.Properties.ReadOnly = True
            End If
        End If
        'Add any initialization after the InitializeComponent() call

    End Sub


    Public Sub New(ByVal pFormType As String, ByVal pTransactionID As Integer, ByVal pTransactDate As DateTime, ByVal pTransactionType As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FormType = pFormType

        Panel1.Visible = False
        Me.Grid_Panel.Visible = False
        Splitter1.Visible = False
        Me.Height = Me.Height - 200

        Me.lookupArea.Visible = True

        If FormType = "DO" Or FormType = "PMR" Then
            Label2.Visible = True
            PO_NOtxt.Visible = True
            Me.txtArea.Visible = False '
            Me.MemoEdit.Location = New System.Drawing.Point(98, 156)
            Me.MemoEdit.Size = New System.Drawing.Size(444, 48)
            Me.Label1.Location = New System.Drawing.Point(30, 156)
            Me.Transactdate.DateTime = Date.Today
        ElseIf FormType = "ST" Then
            Me.lblWarehouse.Visible = False
            Me.txtWarehouse.Visible = False
            Me.Label6.Visible = True
            Me.LookUpArea2.Visible = True
            Me.lblArea.Text = "To:"
            Me.MemoEdit.Location = New System.Drawing.Point(98, 156)
            Me.MemoEdit.Size = New System.Drawing.Size(444, 48)
            Me.Label1.Location = New System.Drawing.Point(30, 156)
            Me.Transactdate.DateTime = Date.Today
        End If
        'InitProductList()
        InitalUserCombo()

        TransactionId = pTransactionID
        Me.Transaction_Type = pTransactionType
        LoadTransaction(pTransactionID)
        Me.PopulateGrid()
        'InitalStockAreaCombo()

        If FormType = "PMR" Or FormType = "SRV" Or FormType = "FGW" Or FormType = "INT" Then
            InitalStockAreaCombo()
            lookupArea.Properties.LookUpData.KeyValue = Me.OldAreaId
        ElseIf FormType = "ST" Then
            InitialFromToAreaCombo()
            LookUpArea2.Properties.LookUpData.KeyValue = Me.OldSrc_AreaId
            lookupArea.Properties.LookUpData.KeyValue = Me.OldDst_AreaId
        Else
            InitalAreaCombo()
            lookupArea.Properties.LookUpData.KeyValue = Me.OldAreaId
        End If

        Me.Transactdate.Enabled = True
        Me.PO_NOtxt.Enabled = True
        Me.txtstockqty.Enabled = True
        Me.refno_TextBox.Enabled = True
        Me.ReqByLookup.Enabled = True
        Me.lookupArea.Enabled = True
        Me.MemoEdit.Enabled = True
        Me.SaveButton.Enabled = True

        If FormType = "QAR" Or FormType = "FGW" Or FormType = "INT" Then
            If pTransactDate <> Nothing Then
                Me.Transactdate.DateTime = pTransactDate
                Me.Transactdate.Properties.ReadOnly = True
            End If
        End If

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ModelSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents DescSearch2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents DescSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents BrandSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SearchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Grid_Panel As System.Windows.Forms.Panel
    Friend WithEvents PartGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents LocGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ReqByLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents refno_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblRefNO As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWarehouse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtStockOutDt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStockOutDt As System.Windows.Forms.Label
    Friend WithEvents txtstockqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCategoryNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStockOutQty As System.Windows.Forms.Label
    Friend WithEvents lblProductNm As System.Windows.Forms.Label
    Friend WithEvents lblCategoryNm As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents inStore_label As System.Windows.Forms.Label
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Stockoutdate As System.Windows.Forms.Panel
    Friend WithEvents PO_NOtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lookupArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Transactdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LookUpArea2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockTransForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ModelSearch = New DevExpress.XtraEditors.TextEdit
        Me.Label36 = New System.Windows.Forms.Label
        Me.DescSearch2 = New DevExpress.XtraEditors.TextEdit
        Me.Label35 = New System.Windows.Forms.Label
        Me.DescSearch = New DevExpress.XtraEditors.TextEdit
        Me.Label34 = New System.Windows.Forms.Label
        Me.BrandSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.SearchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Grid_Panel = New System.Windows.Forms.Panel
        Me.PartGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LocGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Stockoutdate = New System.Windows.Forms.Panel
        Me.LookUpArea2 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit
        Me.Transactdate = New DevExpress.XtraEditors.DateEdit
        Me.lookupArea = New DevExpress.XtraEditors.LookUpEdit
        Me.PO_NOtxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.inStore_label = New System.Windows.Forms.Label
        Me.ReqByLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.MemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.refno_TextBox = New System.Windows.Forms.TextBox
        Me.lblRefNO = New System.Windows.Forms.Label
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit
        Me.lblSupplier = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtUOM = New DevExpress.XtraEditors.TextEdit
        Me.lblUOM = New System.Windows.Forms.Label
        Me.txtArea = New DevExpress.XtraEditors.TextEdit
        Me.txtWarehouse = New DevExpress.XtraEditors.TextEdit
        Me.lblWarehouse = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtStockOutDt = New DevExpress.XtraEditors.TextEdit
        Me.lblStockOutDt = New System.Windows.Forms.Label
        Me.txtstockqty = New DevExpress.XtraEditors.TextEdit
        Me.txtProductNm = New DevExpress.XtraEditors.TextEdit
        Me.txtCategoryNm = New DevExpress.XtraEditors.TextEdit
        Me.lblStockOutQty = New System.Windows.Forms.Label
        Me.lblProductNm = New System.Windows.Forms.Label
        Me.lblCategoryNm = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grid_Panel.SuspendLayout()
        CType(Me.PartGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LocGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Stockoutdate.SuspendLayout()
        CType(Me.LookUpArea2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockOutDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstockqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 90)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.XtraButton1)
        Me.GroupBox3.Controls.Add(Me.ModelSearch)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.DescSearch2)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.DescSearch)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.BrandSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.SearchBtn)
        Me.GroupBox3.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(726, 70)
        Me.GroupBox3.TabIndex = 89
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parts Search"
        '
        'XtraButton1
        '
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(668, 12)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(37, 19)
        Me.XtraButton1.TabIndex = 6
        Me.XtraButton1.Text = "Clear"
        '
        'ModelSearch
        '
        Me.ModelSearch.Location = New System.Drawing.Point(278, 40)
        Me.ModelSearch.Name = "ModelSearch"
        Me.ModelSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ModelSearch.Size = New System.Drawing.Size(106, 19)
        Me.ModelSearch.TabIndex = 4
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(238, 42)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 16)
        Me.Label36.TabIndex = 86
        Me.Label36.Text = "Model:"
        '
        'DescSearch2
        '
        Me.DescSearch2.Location = New System.Drawing.Point(526, 16)
        Me.DescSearch2.Name = "DescSearch2"
        Me.DescSearch2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch2.Size = New System.Drawing.Size(80, 19)
        Me.DescSearch2.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(494, 18)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 16)
        Me.Label35.TabIndex = 84
        Me.Label35.Text = "and"
        '
        'DescSearch
        '
        Me.DescSearch.Location = New System.Drawing.Point(422, 16)
        Me.DescSearch.Name = "DescSearch"
        Me.DescSearch.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.DescSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch.Size = New System.Drawing.Size(72, 17)
        Me.DescSearch.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(382, 18)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 82
        Me.Label34.Text = "Desc:"
        '
        'BrandSearchTxt
        '
        Me.BrandSearchTxt.Location = New System.Drawing.Point(136, 40)
        Me.BrandSearchTxt.Name = "BrandSearchTxt"
        Me.BrandSearchTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BrandSearchTxt.Size = New System.Drawing.Size(96, 19)
        Me.BrandSearchTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Brand :"
        '
        'SearchBtn
        '
        Me.SearchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Image = Nothing
        Me.SearchBtn.Location = New System.Drawing.Point(616, 12)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(46, 19)
        Me.SearchBtn.TabIndex = 5
        Me.SearchBtn.Text = "Search"
        '
        'ProductSearchTxt
        '
        Me.ProductSearchTxt.Location = New System.Drawing.Point(136, 18)
        Me.ProductSearchTxt.Name = "ProductSearchTxt"
        Me.ProductSearchTxt.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.ProductSearchTxt.Size = New System.Drawing.Size(234, 17)
        Me.ProductSearchTxt.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Type Product ID/Code :"
        '
        'Grid_Panel
        '
        Me.Grid_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grid_Panel.Controls.Add(Me.PartGrid)
        Me.Grid_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grid_Panel.Location = New System.Drawing.Point(0, 90)
        Me.Grid_Panel.Name = "Grid_Panel"
        Me.Grid_Panel.Size = New System.Drawing.Size(750, 74)
        Me.Grid_Panel.TabIndex = 1
        Me.Grid_Panel.TabStop = True
        '
        'PartGrid
        '
        Me.PartGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PartGrid.EditorsRepository = Me.PersistentRepository1
        Me.PartGrid.Location = New System.Drawing.Point(0, 0)
        Me.PartGrid.MainView = Me.GridView1
        Me.PartGrid.Name = "PartGrid"
        Me.PartGrid.Size = New System.Drawing.Size(746, 70)
        Me.PartGrid.TabIndex = 0
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
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 164)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(750, 8)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LocGrid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 304)
        Me.Panel2.TabIndex = 4
        '
        'LocGrid
        '
        Me.LocGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocGrid.EditorsRepository = Me.PersistentRepository2
        Me.LocGrid.Location = New System.Drawing.Point(0, 0)
        Me.LocGrid.MainView = Me.GridView2
        Me.LocGrid.Name = "LocGrid"
        Me.LocGrid.Size = New System.Drawing.Size(162, 304)
        Me.LocGrid.TabIndex = 0
        Me.LocGrid.TabStop = False
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
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
        Me.GridView2.BehaviorOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        Me.GridView2.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'Splitter2
        '
        Me.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter2.Location = New System.Drawing.Point(162, 172)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(8, 304)
        Me.Splitter2.TabIndex = 5
        Me.Splitter2.TabStop = False
        '
        'Stockoutdate
        '
        Me.Stockoutdate.AutoScroll = True
        Me.Stockoutdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Stockoutdate.Controls.Add(Me.LookUpArea2)
        Me.Stockoutdate.Controls.Add(Me.Label6)
        Me.Stockoutdate.Controls.Add(Me.txtDescription)
        Me.Stockoutdate.Controls.Add(Me.Transactdate)
        Me.Stockoutdate.Controls.Add(Me.lookupArea)
        Me.Stockoutdate.Controls.Add(Me.PO_NOtxt)
        Me.Stockoutdate.Controls.Add(Me.Label2)
        Me.Stockoutdate.Controls.Add(Me.inStore_label)
        Me.Stockoutdate.Controls.Add(Me.ReqByLookup)
        Me.Stockoutdate.Controls.Add(Me.Label5)
        Me.Stockoutdate.Controls.Add(Me.MemoEdit)
        Me.Stockoutdate.Controls.Add(Me.Label1)
        Me.Stockoutdate.Controls.Add(Me.refno_TextBox)
        Me.Stockoutdate.Controls.Add(Me.lblRefNO)
        Me.Stockoutdate.Controls.Add(Me.txtSupplier)
        Me.Stockoutdate.Controls.Add(Me.lblSupplier)
        Me.Stockoutdate.Controls.Add(Me.lblDescription)
        Me.Stockoutdate.Controls.Add(Me.txtUOM)
        Me.Stockoutdate.Controls.Add(Me.lblUOM)
        Me.Stockoutdate.Controls.Add(Me.txtArea)
        Me.Stockoutdate.Controls.Add(Me.txtWarehouse)
        Me.Stockoutdate.Controls.Add(Me.lblWarehouse)
        Me.Stockoutdate.Controls.Add(Me.lblArea)
        Me.Stockoutdate.Controls.Add(Me.txtStockOutDt)
        Me.Stockoutdate.Controls.Add(Me.lblStockOutDt)
        Me.Stockoutdate.Controls.Add(Me.txtstockqty)
        Me.Stockoutdate.Controls.Add(Me.txtProductNm)
        Me.Stockoutdate.Controls.Add(Me.txtCategoryNm)
        Me.Stockoutdate.Controls.Add(Me.lblStockOutQty)
        Me.Stockoutdate.Controls.Add(Me.lblProductNm)
        Me.Stockoutdate.Controls.Add(Me.lblCategoryNm)
        Me.Stockoutdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stockoutdate.Location = New System.Drawing.Point(170, 172)
        Me.Stockoutdate.Name = "Stockoutdate"
        Me.Stockoutdate.Size = New System.Drawing.Size(580, 250)
        Me.Stockoutdate.TabIndex = 2
        Me.Stockoutdate.TabStop = True
        '
        'LookUpArea2
        '
        Me.LookUpArea2.Enabled = False
        Me.LookUpArea2.Location = New System.Drawing.Point(98, 76)
        Me.LookUpArea2.Name = "LookUpArea2"
        Me.LookUpArea2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.LookUpArea2.Properties.Enabled = False
        Me.LookUpArea2.Properties.NullString = ""
        Me.LookUpArea2.Properties.PopupWidth = 152
        Me.LookUpArea2.Size = New System.Drawing.Size(106, 25)
        Me.LookUpArea2.TabIndex = 214
        Me.LookUpArea2.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(54, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "From :"
        Me.Label6.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 48)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(444, 23)
        Me.txtDescription.TabIndex = 213
        '
        'Transactdate
        '
        Me.Transactdate.DateTime = New Date(CType(0, Long))
        Me.Transactdate.Enabled = False
        Me.Transactdate.Location = New System.Drawing.Point(400, 22)
        Me.Transactdate.Name = "Transactdate"
        Me.Transactdate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.Transactdate.Properties.MaskData.EditMask = "##/##/####"
        Me.Transactdate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Transactdate.Size = New System.Drawing.Size(140, 25)
        Me.Transactdate.TabIndex = 0
        '
        'lookupArea
        '
        Me.lookupArea.Enabled = False
        Me.lookupArea.Location = New System.Drawing.Point(232, 76)
        Me.lookupArea.Name = "lookupArea"
        Me.lookupArea.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupArea.Properties.NullString = ""
        Me.lookupArea.Properties.PopupWidth = 152
        Me.lookupArea.Size = New System.Drawing.Size(106, 25)
        Me.lookupArea.TabIndex = 1
        Me.lookupArea.Visible = False
        '
        'PO_NOtxt
        '
        Me.PO_NOtxt.Enabled = False
        Me.PO_NOtxt.Location = New System.Drawing.Point(96, 128)
        Me.PO_NOtxt.Name = "PO_NOtxt"
        Me.PO_NOtxt.Size = New System.Drawing.Size(168, 20)
        Me.PO_NOtxt.TabIndex = 4
        Me.PO_NOtxt.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(40, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 212
        Me.Label2.Text = "PO # :"
        Me.Label2.Visible = False
        '
        'inStore_label
        '
        Me.inStore_label.AutoSize = True
        Me.inStore_label.Location = New System.Drawing.Point(506, 78)
        Me.inStore_label.Name = "inStore_label"
        Me.inStore_label.Size = New System.Drawing.Size(0, 13)
        Me.inStore_label.TabIndex = 210
        '
        'ReqByLookup
        '
        Me.ReqByLookup.Enabled = False
        Me.ReqByLookup.Location = New System.Drawing.Point(352, 102)
        Me.ReqByLookup.Name = "ReqByLookup"
        Me.ReqByLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ReqByLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ReqByLookup.Properties.NullString = ""
        Me.ReqByLookup.Properties.PopupWidth = 192
        Me.ReqByLookup.Size = New System.Drawing.Size(184, 23)
        Me.ReqByLookup.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(276, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "Requestor:"
        '
        'MemoEdit
        '
        Me.MemoEdit.Enabled = False
        Me.MemoEdit.Location = New System.Drawing.Point(98, 132)
        Me.MemoEdit.Name = "MemoEdit"
        Me.MemoEdit.Size = New System.Drawing.Size(444, 102)
        Me.MemoEdit.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Remarks :"
        '
        'refno_TextBox
        '
        Me.refno_TextBox.Enabled = False
        Me.refno_TextBox.Location = New System.Drawing.Point(96, 102)
        Me.refno_TextBox.Name = "refno_TextBox"
        Me.refno_TextBox.Size = New System.Drawing.Size(168, 20)
        Me.refno_TextBox.TabIndex = 3
        '
        'lblRefNO
        '
        Me.lblRefNO.BackColor = System.Drawing.SystemColors.Control
        Me.lblRefNO.Location = New System.Drawing.Point(40, 104)
        Me.lblRefNO.Name = "lblRefNO"
        Me.lblRefNO.Size = New System.Drawing.Size(52, 16)
        Me.lblRefNO.TabIndex = 1
        Me.lblRefNO.Text = "Ref NO :"
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(230, 216)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtSupplier.Size = New System.Drawing.Size(122, 21)
        Me.txtSupplier.TabIndex = 204
        Me.txtSupplier.Visible = False
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(182, 216)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(56, 16)
        Me.lblSupplier.TabIndex = 203
        Me.lblSupplier.Text = "Supplier :"
        Me.lblSupplier.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(24, 50)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(72, 16)
        Me.lblDescription.TabIndex = 201
        Me.lblDescription.Text = "Description :"
        '
        'txtUOM
        '
        Me.txtUOM.Location = New System.Drawing.Point(288, 22)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Properties.ReadOnly = True
        Me.txtUOM.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtUOM.Size = New System.Drawing.Size(60, 21)
        Me.txtUOM.TabIndex = 200
        Me.txtUOM.TabStop = False
        '
        'lblUOM
        '
        Me.lblUOM.Location = New System.Drawing.Point(248, 24)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(40, 16)
        Me.lblUOM.TabIndex = 199
        Me.lblUOM.Text = "UOM :"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(232, 76)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.ReadOnly = True
        Me.txtArea.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtArea.Size = New System.Drawing.Size(104, 21)
        Me.txtArea.TabIndex = 198
        Me.txtArea.TabStop = False
        '
        'txtWarehouse
        '
        Me.txtWarehouse.Enabled = False
        Me.txtWarehouse.Location = New System.Drawing.Point(96, 76)
        Me.txtWarehouse.Name = "txtWarehouse"
        Me.txtWarehouse.Properties.ReadOnly = True
        Me.txtWarehouse.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtWarehouse.Size = New System.Drawing.Size(82, 21)
        Me.txtWarehouse.TabIndex = 197
        Me.txtWarehouse.TabStop = False
        '
        'lblWarehouse
        '
        Me.lblWarehouse.Location = New System.Drawing.Point(24, 76)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(72, 16)
        Me.lblWarehouse.TabIndex = 195
        Me.lblWarehouse.Text = "Warehouse :"
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(188, 78)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 196
        Me.lblArea.Text = "Area :"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtStockOutDt
        '
        Me.txtStockOutDt.Location = New System.Drawing.Point(447, 4)
        Me.txtStockOutDt.Name = "txtStockOutDt"
        Me.txtStockOutDt.Properties.ReadOnly = True
        Me.txtStockOutDt.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtStockOutDt.Size = New System.Drawing.Size(106, 21)
        Me.txtStockOutDt.TabIndex = 0
        Me.txtStockOutDt.TabStop = False
        Me.txtStockOutDt.Visible = False
        '
        'lblStockOutDt
        '
        Me.lblStockOutDt.Location = New System.Drawing.Point(358, 26)
        Me.lblStockOutDt.Name = "lblStockOutDt"
        Me.lblStockOutDt.Size = New System.Drawing.Size(50, 16)
        Me.lblStockOutDt.TabIndex = 193
        Me.lblStockOutDt.Text = "Date :"
        '
        'txtstockqty
        '
        Me.txtstockqty.Enabled = False
        Me.txtstockqty.Location = New System.Drawing.Point(438, 74)
        Me.txtstockqty.Name = "txtstockqty"
        Me.txtstockqty.Properties.Format = CType(resources.GetObject("resource.Format"), System.IFormatProvider)
        Me.txtstockqty.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtstockqty.Size = New System.Drawing.Size(60, 21)
        Me.txtstockqty.TabIndex = 2
        '
        'txtProductNm
        '
        Me.txtProductNm.Location = New System.Drawing.Point(96, 22)
        Me.txtProductNm.Name = "txtProductNm"
        Me.txtProductNm.Properties.ReadOnly = True
        Me.txtProductNm.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtProductNm.Size = New System.Drawing.Size(144, 21)
        Me.txtProductNm.TabIndex = 191
        Me.txtProductNm.TabStop = False
        '
        'txtCategoryNm
        '
        Me.txtCategoryNm.Location = New System.Drawing.Point(72, 218)
        Me.txtCategoryNm.Name = "txtCategoryNm"
        Me.txtCategoryNm.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtCategoryNm.Size = New System.Drawing.Size(104, 21)
        Me.txtCategoryNm.TabIndex = 190
        Me.txtCategoryNm.Visible = False
        '
        'lblStockOutQty
        '
        Me.lblStockOutQty.Location = New System.Drawing.Point(346, 76)
        Me.lblStockOutQty.Name = "lblStockOutQty"
        Me.lblStockOutQty.Size = New System.Drawing.Size(84, 16)
        Me.lblStockOutQty.TabIndex = 189
        '
        'lblProductNm
        '
        Me.lblProductNm.Location = New System.Drawing.Point(40, 24)
        Me.lblProductNm.Name = "lblProductNm"
        Me.lblProductNm.Size = New System.Drawing.Size(56, 16)
        Me.lblProductNm.TabIndex = 188
        Me.lblProductNm.Text = "Product :"
        '
        'lblCategoryNm
        '
        Me.lblCategoryNm.Location = New System.Drawing.Point(16, 218)
        Me.lblCategoryNm.Name = "lblCategoryNm"
        Me.lblCategoryNm.Size = New System.Drawing.Size(64, 16)
        Me.lblCategoryNm.TabIndex = 187
        Me.lblCategoryNm.Text = "Category  :"
        Me.lblCategoryNm.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.SaveButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(170, 422)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(580, 54)
        Me.Panel4.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(480, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Enabled = False
        Me.SaveButton.Location = New System.Drawing.Point(394, 18)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Save"
        '
        'StockTransForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(750, 476)
        Me.Controls.Add(Me.Stockoutdate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Grid_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StockTransForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grid_Panel.ResumeLayout(False)
        CType(Me.PartGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.LocGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Stockoutdate.ResumeLayout(False)
        Me.Stockoutdate.PerformLayout()
        CType(Me.LookUpArea2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockOutDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstockqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public dataGrid As System.Data.DataTable
    Public data As System.Data.DataTable

    Public FormType As String
    Public Transaction_Type As String = "Stock Out"
    Public StockOutType As String = "Loose Item"
    Public StockInType As String = "Loose Item"
    Public SRV_ID As Integer = 0
    Public UOM_ID As Integer = 0
    Public Product_ID As Integer = 0
    Public InStoreQty As Integer
    Public StockOutQty As Integer

    Private OldStockId As Integer = 0
    Private OldAreaId As Decimal = 0
    Private OldSrc_StockId As Integer = 0
    Private OldSrc_AreaId As Decimal = 0
    Private OldDst_StockId As Integer = 0
    Private OldDst_AreaId As Decimal = 0
    Private OldQty As Integer
    Private OldTransaction_Type As String

    Public UserID As String = Common.CommonConn.Config.USERID
    Public Category_ID As Integer = 0

    Public Supplier_ID As Integer = 0
    Public WO_ID As Integer = 0
    Public Stock_ID As Integer = 0
    Public Dst_Stock_ID As Integer = 0
    Public WH_ID As Decimal = 0
    Public WHA_ID As Decimal = 0
    Public Dst_WH_ID As Decimal = 0
    Public Dst_WHA_ID As Decimal = 0
    Public Src_WH_ID As Decimal = 0
    Public Src_WHA_ID As Decimal = 0
    Public Location_ID As Integer = 0
    Public TransactionId As Integer = 0

    Public WO_No As String
    Public Order_Type As String
    Public Order_NO As String
    Public Remarks As String

    Public Property OrderType() As String
        Get
            Return Order_Type
        End Get
        Set(ByVal Value As String)
            Order_Type = Value
            'Me.refno_TextBox.Text = Order_Type & " #:"
            Me.lblRefNO.Text = Order_Type & " #:"
        End Set
    End Property


    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click

        ClearProductList()
        Me.InitalAreaCombo()
        RefreshProductListByProductID(ProductSearchTxt.Text, BrandSearchTxt.Text, DescSearch.Text, DescSearch2.Text, ModelSearch.Text)
        RefreshProductInfo()
        PartGrid.Focus()

    End Sub

    Private Sub RefreshProductListByProductID(ByVal ProductID As String, ByVal BrandText As String, ByVal Desc As String, ByVal Desc2 As String, ByVal Model As String)
        Dim ds As DataSet
        'Load product list
        Dim ret As Boolean
        Me.InitProductList()

        With New BusinessRules.ManProdBusRules.ManProdBusLogic

            If Me.FormType = "QAR" Or FormType = "FGW" Or FormType = "INT" Then
                ret = .Load(ds, ProductID, BrandText, Desc, Desc2, Model, 27)
            Else
                ret = .Load(ds, ProductID, BrandText, Desc, Desc2, Model, 0)
            End If

            If ret Then
                If Not ds Is Nothing Then
                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    Dim Status As String

                    For Each oRow In ds.Tables(0).Rows
                        dataGrid.Rows.Add(New Object() { _
                        oRow("Product_ID"), _
                        oRow("UOM_ID"), _
                        oRow("Name"), _
                         oRow("Description"), _
                         oRow("Alt_Description"), _
                         oRow("Brand_Name"), _
                        oRow("Model"), _
                         oRow("MaterialCode"), _
                          oRow("Color_Name"), _
                        oRow("Category")})
                    Next

                    PartGrid.DataSource = dataGrid
                    PartGrid.DefaultView.PopulateColumns()

                    GridView1.Columns.Item(0).VisibleIndex = -1
                    GridView1.Columns.Item("UOM_ID").VisibleIndex = -1

                    'GridView1.BestFitColumns()
                    Me.DefaultGridView()
                End If
            End If
        End With
    End Sub

    Private Sub RefreshProductInfo()
        Dim dsUOM As DataSet

        ClearFields()

        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then

                Product_ID = CInt(dr("Product_ID"))
                'Supplier_ID = CInt(ProductList.SelectedItem("Supplier_ID"))
                UOM_ID = CInt(dr("UOM_ID"))
                txtProductNm.Text = dr("Product")
                txtDescription.Text = dr("Desc")

                With New BusinessRules.BusRules.InventoryBusLogic
                    .UOM_ID = UOM_ID
                    dsUOM = .GetUOM
                    If Not dsUOM Is Nothing Then
                        Try
                            If dsUOM.Tables(0).Rows.Count > 0 Then
                                txtUOM.Text = dsUOM.Tables(0).Rows(0).Item("Unit")
                            Else
                                txtUOM.Text = ""
                            End If
                        Catch exLoad As Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try
                    End If
                End With

                'StockOutBtn.Enabled = False
                PopulateGrid()
                If FormType = "DO" Or FormType = "RTN" Or FormType = "QAR" Or FormType = "SA" Then
                    SetDOEntry()
                Else
                    SetEntry()
                End If

                If FormType = "PMR" Or FormType = "SRV" Or FormType = "FGW" Or FormType = "INT" Then
                    InitalStockAreaCombo()
                ElseIf FormType = "ST" Then
                    Me.InitialFromToAreaCombo()
                End If

            End If
        End If

    End Sub

    Private Sub ClearFields()
        txtProductNm.Text = ""
        txtUOM.Text = ""
        txtDescription.Text = ""
        txtSupplier.Text = ""
        'txtCategoryNm.Text = ""
        txtWarehouse.Text = ""
        txtArea.Text = ""
        txtstockqty.Text = ""
        'Me.refno_TextBox.Text = ""
        Me.MemoEdit.Text = ""
    End Sub

    Public Sub PopulateGrid()
        Dim ds As DataSet

        LocGrid.DataSource = Nothing

        'AccessCount = AccessCount + 1
        With New BusinessRules.BusRules.InventoryBusLogic
            .Product_ID = Product_ID
            ds = .GetStock()

            If Not ds Is Nothing Then
                InitLocGrid()

                Dim oRow As DataRow
                Dim i As Integer = 0
                'Dim CompTotal As Double

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {oRow("Stock_ID"), oRow("Warehouse_ID"), oRow("Warehouse_Area_ID"), oRow("Warehouse"), oRow("Warehouse_Area"), oRow("Qty")})
                Next

                LocGrid.DataSource = data
                LocGrid.DefaultView.PopulateColumns()
                GridView2.BestFitColumns()
                GridView2.Columns.Item("Stock ID").VisibleIndex = -1 'hide StockID column
                GridView2.Columns.Item("Warehouse ID").VisibleIndex = -1 'hide CategoryID column
                GridView2.Columns.Item("Area ID").VisibleIndex = -1 'hide ProductID column
                GridView2.Columns.Item("Warehouse").VisibleIndex = -1

            Else
                GridView2.Columns.Clear()
            End If
        End With
    End Sub

    Private Sub InitLocGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()

        AddColumn(data, "Stock ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Warehouse ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Area ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Warehouse", System.Type.GetType("System.String"), True)
        AddColumn(data, "Area", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int32"), True)

        data.EndInit()
    End Sub

    Private Sub InitProductList()

        dataGrid = New DataTable("ColumnsTable")
        dataGrid.BeginInit()

        AddColumn(dataGrid, "Product_ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(dataGrid, "UOM_ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(dataGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Desc", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Alt Desc", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Brand", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Model", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Material", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Color", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Category", System.Type.GetType("System.String"), True)

        dataGrid.EndInit()

    End Sub

    Private Sub DefaultGridView()

        GridView1.Columns("Product").Width = 103
        GridView1.Columns("Desc").Width = 150
        GridView1.Columns("Alt Desc").Width = 100
        GridView1.Columns("Brand").Width = 50
        GridView1.Columns("Model").Width = 83
        GridView1.Columns("Material").Width = 89
        GridView1.Columns("Color").Width = 89
        GridView1.Columns("Category").Width = 89

    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data1.Columns.Add(col)
    End Sub

    Private Sub ClearProductList()

    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        RefreshProductInfo()
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
                End If
            End If

        End With
    End Sub

    Private Sub InitalAreaCombo()
        Dim dsArea As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = 1 'WH_ID
            dsArea = .GetWarehouseArea
            If Not dsArea Is Nothing Then
                Try
                    lookupArea.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(lookupArea, "Warehouse_Area", 200, 0, "")
                    lookupArea.Properties.LookUpData.KeyField = "Warehouse_Area_ID"
                    lookupArea.Properties.LookUpData.DisplayField = "Warehouse_Area"
                    lookupArea.Properties.LookUpData.DataSource = dsArea.Tables(0)
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With
    End Sub


    Private Sub InitalStockAreaCombo()
        Dim dsArea As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = 1 'WH_ID
            .Product_ID = Product_ID
            dsArea = .GetStock
            If Not dsArea Is Nothing Then
                Try
                    lookupArea.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(lookupArea, "Warehouse_Area", 200, 0, "")
                    lookupArea.Properties.LookUpData.KeyField = "Warehouse_Area_ID"
                    lookupArea.Properties.LookUpData.DisplayField = "Warehouse_Area"
                    lookupArea.Properties.LookUpData.DataSource = dsArea.Tables(0)
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With

    End Sub

    Private Sub InitialFromToAreaCombo()
        Dim dsArea As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = 1 'WH_ID
            .Product_ID = Product_ID
            dsArea = .GetStock
            If Not dsArea Is Nothing Then
                Try
                    LookUpArea2.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(LookUpArea2, "Warehouse_Area", 200, 0, "")
                    LookUpArea2.Properties.LookUpData.KeyField = "Warehouse_Area_ID"
                    LookUpArea2.Properties.LookUpData.DisplayField = "Warehouse_Area"
                    LookUpArea2.Properties.LookUpData.DataSource = dsArea.Tables(0)
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With

        Me.InitalAreaCombo()

    End Sub


    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub GridView2_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.SelectionChangedEventArgs) Handles GridView2.SelectionChanged

    End Sub

    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.SelectionChangedEventArgs) Handles GridView1.SelectionChanged

    End Sub

    Private Sub SetEntry()

        If Me.GridView2.RowCount > 0 Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)

            txtStockOutDt.Text = Date.Today
            Me.InStoreQty = dr("Qty")
            Me.txtWarehouse.Text = dr("Warehouse")
            Me.txtArea.Text = dr("Area")
            Me.WH_ID = dr("Warehouse ID")
            Me.WHA_ID = dr("Area ID")
            If FormType = "ST" Then
                Me.LookUpArea2.Properties.LookUpData.KeyValue = Me.WHA_ID
            Else
                Me.lookupArea.Properties.LookUpData.KeyValue = Me.WHA_ID
            End If

            txtstockqty.Focus()
            txtstockqty.SelectAll()

            Me.Stock_ID = dr("Stock ID")
            InitalUserCombo()
            If Transaction_Type = "Stock Out" Then
                If TransactionId > 0 Then
                    If WHA_ID = Me.OldAreaId Then
                        InStoreQty = InStoreQty + Me.OldQty
                    End If
                End If
                Me.inStore_label.Text = "(Max:" & InStoreQty & ")"
            ElseIf Transaction_Type = "Stock Transfer" Then
                If TransactionId > 0 Then
                    If WHA_ID = Me.OldAreaId Then
                        InStoreQty = InStoreQty + Me.OldQty
                    End If
                End If
                Me.inStore_label.Text = "(Max:" & InStoreQty & ")"
            Else 'Stock In
                Me.inStore_label.Text = ""
            End If

            Me.Transactdate.Enabled = True
            Me.txtstockqty.Enabled = True
            Me.refno_TextBox.Enabled = True
            Me.ReqByLookup.Enabled = True
            Me.lookupArea.Enabled = True
            Me.LookUpArea2.Enabled = True
            Me.MemoEdit.Enabled = True
            Me.SaveButton.Enabled = True
        Else
                ResetEntry()
            End If
    End Sub

    Private Sub SetDOEntry()

        If Me.GridView1.RowCount > 0 Then

            txtStockOutDt.Text = Date.Today
            InitalUserCombo()
            If Transaction_Type = "Stock Out" Then
                Me.inStore_label.Text = "(Max:" & InStoreQty & ")"
            Else 'Stock In
                Me.inStore_label.Text = ""
            End If
            Me.Transactdate.Enabled = True
            Me.PO_NOtxt.Enabled = True
            Me.txtstockqty.Enabled = True
            Me.refno_TextBox.Enabled = True
            Me.ReqByLookup.Enabled = True
            Me.lookupArea.Enabled = True
            Me.MemoEdit.Enabled = True
            Me.SaveButton.Enabled = True
        Else
            ResetEntry()
        End If
    End Sub

    Private Sub ResetEntry()

        'LocGrid.DataSource = Nothing
        'PartGrid.DataSource = Nothing

        Me.txtWarehouse.Text = ""
        Me.txtArea.Text = ""
        Me.inStore_label.Text = ""
        Me.txtstockqty.Enabled = False
        Me.refno_TextBox.Enabled = False
        Me.ReqByLookup.Enabled = False
        Me.lookupArea.Enabled = False
        Me.LookUpArea2.Enabled = False
        Me.MemoEdit.Enabled = False
        Me.SaveButton.Enabled = False
        Me.PO_NOtxt.Enabled = False
        Me.Transactdate.Enabled = False
        Me.ReqByLookup.Properties.LookUpData.DataSource = Nothing
        Me.lookupArea.Properties.LookUpData.DataSource = Nothing

        'Me.ReqByLookup.Properties.LookUpData.L()

        'ClearSearchEntry()

    End Sub

    Private Sub ClearSearchEntry()

        ProductSearchTxt.Text = ""
        DescSearch.Text = ""
        DescSearch2.Text = ""
        BrandSearchTxt.Text = ""
        ModelSearch.Text = ""

        ProductSearchTxt.Focus()

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If IsNumeric(txtstockqty.Text) = False Then
            MessageBox.Show("Please enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtstockqty.Focus()
            Exit Sub
        End If

        If Transactdate.DateTime > DateTime.Today Then
            MessageBox.Show("Date must not be greater than today!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Transactdate.Focus()
            Exit Sub
        End If

        StockOutQty = CInt(txtstockqty.Text)
        If Me.Owner.ActiveControl.Name = "StockOutSRVForm" Then
            Dim qf As StockOutSRVForm
            qf = Me.Owner.ActiveControl
            If SaveDataProcess() Then
                'Me.Close()
                qf.LoadStockTransSRV()
                PartGrid.DataSource = Nothing
                LocGrid.DataSource = Nothing

                LocGrid.Refresh()
                PartGrid.Refresh()

                'Me.ProductSearchTxt.Text = ""

                Me.ProductSearchTxt.Focus()
                Me.ProductSearchTxt.SelectAll()

                If TransactionId <> 0 Then
                    Me.Close()
                End If

                If True Then 'FormType = "DO" Or FormType = "PMR" Then
                    ResetEntry()
                End If
                'qf.UpdateBtn_Click(Me, Nothing)
            End If
        End If


    End Sub

    Private Function SaveDataProcess() As Boolean

        Dim dsExist As DataSet
        Dim dsDstExist As DataSet
        Dim RetStat

        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Stock_Out_Type = StockOutType
            .Stock_In_Type = Me.StockInType
            .In_Store_Qty = InStoreQty
            If Transaction_Type = "Stock In" Then
                .StockInQty = StockOutQty
                If Not .ValidQty Then
                    MessageBox.Show("Stock in quantity cannot be < 0 or = 0!", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveDataProcess = False
                    txtstockqty.Focus()

                    Exit Function
                End If
            ElseIf Transaction_Type = "Stock Adjustment" Then
                If StockOutQty > 0 Then
                    .Transaction_Type = "Stock In"
                    .StockInQty = Math.Abs(StockOutQty)
                ElseIf StockOutQty < 0 Then
                    .Transaction_Type = "Stock Out"
                    .StockOutQty = Math.Abs(StockOutQty)
                Else
                    MessageBox.Show("Stock quantity cannot be 0!", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveDataProcess = False
                    txtstockqty.Focus()
                    Exit Function
                End If
            ElseIf Transaction_Type = "Stock Transfer" Then
                If lookupArea.Properties.LookUpData.KeyValue = Nothing Then
                    MessageBox.Show("Please select the destination area.", "Stock Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveDataProcess = False
                    lookupArea.Focus()
                    Exit Function
                End If
                .Relocate_Qty = StockOutQty
                If Not .ValidQty Then
                    MessageBox.Show("Stock in quantity cannot be < 0 or = 0!", "Stock Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveDataProcess = False
                    txtstockqty.Focus()
                    Exit Function
                End If
            Else
                .StockOutQty = StockOutQty
                If True Then 'Me.TransactionId = 0 Then
                    If False Then 'Not .ValidQty Then
                        MessageBox.Show("Stock out quantity cannot be < 0 or = 0 or > in store quantity !", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveDataProcess = False
                        txtstockqty.Focus()

                        Exit Function
                    End If
                End If
            End If

            .WO_ID = WO_ID
            .UserID = UserID
            .Stock_ID = Stock_ID
            .Category_ID = Category_ID
            .Product_ID = Product_ID
            .WH_ID = WH_ID
            WHA_ID = lookupArea.Properties.LookUpData.KeyValue
            .WHA_ID = WHA_ID

            Src_WHA_ID = LookUpArea2.Properties.LookUpData.KeyValue
            Dst_WHA_ID = lookupArea.Properties.LookUpData.KeyValue
            .Src_WHA_ID = Src_WHA_ID
            .Dst_WHA_ID = Dst_WHA_ID

            If True Then 'FormType = "DO" Or FormType = "PMR" Then
                .WH_ID = 1
                .Src_WH_ID = 1
                .Dst_WH_ID = 1
                .WHA_ID = lookupArea.Properties.LookUpData.KeyValue
            End If
            '.Location_ID = Location_ID

            If Not .EmptyWorkOrder Then
                Order_Type = "WO"
                Order_NO = WO_No
                .Order_Type = Order_Type
                .Order_NO = Order_NO
            End If

            Order_NO = refno_TextBox.Text
            .PO_NO = PO_NOtxt.Text
            .WO_ID = 1
            .Order_Type = Order_Type
            .Order_NO = Order_NO
            .RequestedBy = ReqByLookup.Properties.LookUpData.KeyValue
            .SRV_ID = SRV_ID
            .Remarks = Me.MemoEdit.Text
            .Transact_Date = Transactdate.Text

            If TransactionId > 0 Then
                RetStat = Me.UpdateStock() 'restore stock to previous value before updating new qty.
                If RetStat = False Then
                    SaveDataProcess = False
                    Exit Function
                End If
            End If

            If Transaction_Type = "Stock Transfer" Then

                dsExist = .RecordExist(Product_ID, WH_ID, Src_WHA_ID) 'stock exist?
                dsDstExist = .RecordExist(Product_ID, WH_ID, Dst_WHA_ID)

                If dsDstExist Is Nothing Then
                    If .SaveNewStock Then

                    Else
                        MessageBox.Show("Destination Stock Encounter error! ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveDataProcess = False
                        Exit Function
                    End If
                Else
                    Dst_Stock_ID = dsDstExist.Tables(0).Rows(0).Item("Stock_ID")
                    .Dst_Stock_ID = Dst_Stock_ID
                End If
            Else
                dsExist = .RecordExist(Product_ID, WH_ID, WHA_ID) 'stock exist?
            End If

            If Not dsExist Is Nothing Then

                Stock_ID = dsExist.Tables(0).Rows(0).Item("Stock_ID")
                .Stock_ID = Stock_ID

                If TransactionId > 0 Then
                    'RetStat = Me.UpdateStock()
                    If WHA_ID <> OldAreaId Then
                        RetStat = .UpdateSelectedStock
                    End If
                Else
                    RetStat = .UpdateSelectedStock
                    If Transaction_Type = "Stock Transfer" Then
                        If .UpdateDestinationStock() Then
                        Else
                            MessageBox.Show("Update Destination Encounter error! ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            SaveDataProcess = False
                            Exit Function
                        End If
                    End If
                End If

                If RetStat Then

                    If TransactionId > 0 Then
                        RetStat = .UpdateStockTransaction(TransactionId)
                    Else
                        If Transaction_Type = "Stock Transfer" Then
                            RetStat = .SaveStockTransferTransaction()
                        Else
                            RetStat = .SaveStockTransaction()
                        End If
                    End If

                    If RetStat Then
                        'MessageBox.Show(Transaction_Type & " successfully. ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'If SRV_ID <> 0 Then
                        'Me.Close()
                        'End If
                        SaveDataProcess = True
                    Else
                        MessageBox.Show("Encounter error! ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveDataProcess = False
                        Exit Function
                    End If
                Else
                    MessageBox.Show("Encounter error! ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveDataProcess = False
                    Exit Function
                End If
            Else
                If .SaveNewStock Then

                    If TransactionId > 0 Then
                        RetStat = .UpdateStockTransaction(TransactionId)
                    Else
                        RetStat = .SaveStockTransaction()
                    End If

                    If RetStat Then
                        'MessageBox.Show(Transaction_Type & " successfully. ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'If SRV_ID <> 0 Then
                        'Me.Close()
                        'End If
                        SaveDataProcess = True
                    Else
                        MessageBox.Show("Encounter error! ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveDataProcess = False
                        Exit Function
                    End If
                Else
                    MessageBox.Show("Encounter error! ", Transaction_Type, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveDataProcess = False
                    Exit Function
                End If
            End If
        End With
    End Function

    Private Function UpdateStock() As Boolean
        Dim OffsetStock
        With New BusinessRules.BusRules.InventoryBusLogic
            If WHA_ID <> OldAreaId Then
                If FormType = "DO" Or FormType = "RTN" Or FormType = "QAR" Then
                    OffsetStock = (0 - Me.OldQty)
                ElseIf FormType = "SRV" Or FormType = "PMR" Or FormType = "FGWDO" Or FormType = "FGWNOI" Or FormType = "INT" Then
                    OffsetStock = Me.OldQty
                ElseIf FormType = "SA" Then
                    If OldTransaction_Type = "Stock Out" Then
                        OffsetStock = Me.OldQty
                    ElseIf OldTransaction_Type = "Stock In" Then
                        OffsetStock = (0 - Me.OldQty)
                    End If
                Else
                    Exit Function
                End If
            Else 'No changes to area
                If FormType = "DO" Or FormType = "RTN" Or FormType = "QAR" Then
                    OffsetStock = (Me.StockOutQty - Me.OldQty)
                ElseIf FormType = "SRV" Or FormType = "PMR" Or FormType = "FGWDO" Or FormType = "FGWNOI" Or FormType = "INT" Then
                    OffsetStock = (Me.OldQty - Me.StockOutQty)
                ElseIf FormType = "SA" Then
                    If OldTransaction_Type = "Stock Out" Then
                        OffsetStock = (Me.OldQty - Me.StockOutQty)
                    ElseIf OldTransaction_Type = "Stock In" Then
                        OffsetStock = (Me.StockOutQty - Me.OldQty)
                    End If
                Else
                    Exit Function
                End If
            End If

            Dim CurrentQty
            Dim tmp

            If OffsetStock > 0 Then
                .Transaction_Type = "Stock In"
                .StockInQty = OffsetStock
            ElseIf OffsetStock < 0 Then
                .Transaction_Type = "Stock Out"
                tmp = System.Math.Abs(OffsetStock)
                .StockOutQty = tmp

                CurrentQty = .GetStockQty(Me.Product_ID, 1, Me.OldAreaId)
                If tmp > CurrentQty Then
                    MessageBox.Show("Unable to save transaction, edited qty cannot cause the stock qty to fall below ZERO! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UpdateStock = False
                    Exit Function
                End If
            End If

            .WHA_ID = Me.OldAreaId

            .Stock_ID = Me.OldStockId 'Stock_Id
            .UserID = UserID
            UpdateStock = .UpdateSelectedStock()
        End With
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        'SetEntry()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            dr = GridView2.GetDataRow(Row)
            If Not dr Is Nothing Then
                If FormType = "ST" Then
                    Me.LookUpArea2.Properties.LookUpData.KeyValue = dr("area id")
                Else
                    Me.lookupArea.Properties.LookUpData.KeyValue = dr("area id")
                End If
                SetEntry()
            End If
        End If
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton1.Click
        Me.ClearSearchEntry()
    End Sub

    Private Sub ProductSearchTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProductSearchTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(Me, e)
        End If
    End Sub

    Private Sub DescSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DescSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(Me, e)
        End If
    End Sub

    Private Sub DescSearch2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DescSearch2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(Me, e)
            PartGrid.Focus()
        End If
    End Sub

    Private Sub BrandSearchTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BrandSearchTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(Me, e)

        End If
    End Sub

    Private Sub ModelSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ModelSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(Me, e)
        End If
    End Sub

    Private Sub PartGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PartGrid.KeyDown

    End Sub

    Private Sub LocGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LocGrid.KeyDown

    End Sub

    Private Sub StockTransForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblStockOutQty.Text = Transaction_Type & " Qty :"

        If TransactionId > 0 Then
            Me.Transactdate.Focus()
        End If

    End Sub

    Private Sub LookUpEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadTransaction(ByVal pTransactionId As Integer)
        Dim ds As DataSet
        Dim ds2 As DataSet
        Dim dr As DataRow

        With New BusinessRules.BusRules.InventoryBusLogic
            If Transaction_Type = "Stock Transfer" Then
                .GetStockTransferTransaction(ds, pTransactionId)
            Else
                .GetStockTransaction(ds, pTransactionId)
            End If

            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)

                Me.Product_ID = dr("Product_id")

                OldQty = dr("Qty")
                OldTransaction_Type = dr("Transaction_type")

                OldStockId = dr("Stock_id")
                If Transaction_Type = "Stock Transfer" Then
                    OldSrc_AreaId = dr("Src_warehouse_area_id")
                    OldDst_AreaId = dr("Dst_warehouse_area_id")
                    'Me.txtWarehouse.Text = dr("Warehouse")
                    'Me.txtArea.Text = dr("warehouse_Area")
                    Me.LookUpArea2.Properties.LookUpData.KeyValue = dr("src_warehouse_area_id")
                    Me.lookupArea.Properties.LookUpData.KeyValue = dr("dst_warehouse_area_id")
                Else
                    OldAreaId = dr("warehouse_area_id")
                    Me.txtWarehouse.Text = dr("Warehouse")
                    Me.txtArea.Text = dr("warehouse_Area")
                    Me.lookupArea.Properties.LookUpData.KeyValue = dr("warehouse_area_id")
                End If

                txtProductNm.Text = dr("Product_Name")
                If dr("UOM") Is DBNull.Value Then
                    txtUOM.Text = ""
                Else
                    txtUOM.Text = dr("UOM")
                End If

                Me.txtDescription.Text = dr("Description")
                Me.Transactdate.DateTime = dr("Transact_Date")
                Me.txtstockqty.Text = dr("Qty")

                If dr("Order_No") Is DBNull.Value Then
                    Me.refno_TextBox.Text = ""
                Else
                    Me.refno_TextBox.Text = dr("Order_No")
                End If
                If dr("Remarks") Is DBNull.Value Then
                    Me.MemoEdit.Text = ""
                Else
                    Me.MemoEdit.Text = dr("Remarks")
                End If
                If dr("PO_NO") Is DBNull.Value Then
                    Me.PO_NOtxt.Text = ""
                Else
                    Me.PO_NOtxt.Text = dr("PO_NO")
                End If
                If dr("requestor") Is DBNull.Value Then
                Else
                    Me.ReqByLookup.Text = dr("requestor")
                End If
            End If

                .WH_ID = dr("Warehouse_id")
                .WHA_ID = dr("warehouse_area_id")
                Me.WH_ID = dr("Warehouse_ID")
                Me.WHA_ID = dr("warehouse_Area_ID")
                Me.Stock_ID = dr("Stock_ID")
                .Product_ID = dr("Product_id")
                ds2 = .GetStockLocation()
                If Not ds2 Is Nothing Then
                    If ds2.Tables(0).Rows.Count > 0 Then
                        .In_Store_Qty = dr("Qty")
                    End If
                End If


        End With
    End Sub


    Private Sub PartGrid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PartGrid.KeyPress
        'MessageBox.Show("HELLO")
        Transactdate.Focus()
    End Sub

    Private Sub LocGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocGrid.DoubleClick

    End Sub

    Private Sub lookupArea_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookupArea.ValueChanged
        If Transaction_Type = "Stock Transfer" Then
            Exit Sub
        End If
        Dim Row As Integer
        Dim dr As DataRow
        If GridView2.RowCount > 0 Then
            Dim selectrow = GridView2.GetSelectedRows(0)
            'GridView2.UnselectRow(selectrow)
            Dim ds As DataSet
            If GridView2.RowCount > 0 Then
                For Row = 0 To GridView2.RowCount - 1
                    dr = GridView2.GetDataRow(Row)
                    If dr("area id") = Me.lookupArea.Properties.LookUpData.KeyValue Then
                        GridView2.MoveBy(Row - selectrow)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProductSearchTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductSearchTxt.Click
        'ProductSearchTxt.SelectAll()
    End Sub

    Private Sub txtstockqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstockqty.KeyPress
       
    End Sub

    Private Sub txtstockqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstockqty.KeyDown

        If e.KeyCode = Keys.Enter Then
            SaveButton_Click(sender, Nothing)
        End If

    End Sub

    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.Click

    End Sub

    Private Sub GridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView2.Click
        txtstockqty.Focus()
        txtstockqty.SelectAll()
    End Sub

    Private Sub ProductSearchTxt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductSearchTxt.Enter
        ProductSearchTxt.SelectAll()
    End Sub
End Class
