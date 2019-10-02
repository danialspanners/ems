Public Class StockAdjustmentForm
    Inherits System.Windows.Forms.Form

#Region " Declare Public Variables"
    Public UserID As String = Common.CommonConn.Config.USERID
    Public Transaction_Type As String = "Adjustment"

    Public data As System.Data.DataTable
    Public EmptyList As Boolean = True
    Public dsExist As DataSet
    Public dsStock As DataSet

    Public Category_ID As Integer = 0
    Public Product_ID As Integer = 0
    Public Supplier_ID As Integer = 0
    Public Stock_ID As Integer = 0
    Public Dst_Stock_ID As Integer = 0
    Public WH_ID As Integer = 0
    Public WHA_ID As Integer = 0
    Public Location_ID As Integer = 0
    Public UOM_ID As Integer = 0
    Public In_Store_Qty As Integer
    Public Adjusted_Qty As Integer
#End Region

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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents txtLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWarehouse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lookupSrcLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookupSrcArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookupSrcWarehouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSrcLocation As System.Windows.Forms.Label
    Friend WithEvents lblSrcArea As System.Windows.Forms.Label
    Friend WithEvents lblSrcWarehouse As System.Windows.Forms.Label
    Friend WithEvents txtConfirmQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOrderQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCategoryNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRefNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents lblRelocationDt As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblProductNm As System.Windows.Forms.Label
    Friend WithEvents lblCategoryNm As System.Windows.Forms.Label
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents lblCategoryList As System.Windows.Forms.Label
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents lblProductList As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents txtCurrentQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCurrentQty As System.Windows.Forms.Label
    Friend WithEvents txtAdjustedQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAdjustedQty As System.Windows.Forms.Label
    Friend WithEvents txtAdjustmentDt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdjustmentBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SearchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.grdStock = New DevExpress.XtraGrid.GridControl
        Me.txtLocation = New DevExpress.XtraEditors.TextEdit
        Me.txtArea = New DevExpress.XtraEditors.TextEdit
        Me.txtWarehouse = New DevExpress.XtraEditors.TextEdit
        Me.lookupSrcLocation = New DevExpress.XtraEditors.LookUpEdit
        Me.lookupSrcArea = New DevExpress.XtraEditors.LookUpEdit
        Me.lookupSrcWarehouse = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSrcLocation = New System.Windows.Forms.Label
        Me.lblSrcArea = New System.Windows.Forms.Label
        Me.lblSrcWarehouse = New System.Windows.Forms.Label
        Me.txtCurrentQty = New DevExpress.XtraEditors.TextEdit
        Me.lblCurrentQty = New System.Windows.Forms.Label
        Me.txtConfirmQty = New DevExpress.XtraEditors.TextEdit
        Me.txtOrderQty = New DevExpress.XtraEditors.TextEdit
        Me.txtAdjustedQty = New DevExpress.XtraEditors.TextEdit
        Me.txtUOM = New DevExpress.XtraEditors.TextEdit
        Me.txtAdjustmentDt = New DevExpress.XtraEditors.TextEdit
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit
        Me.txtProductNm = New DevExpress.XtraEditors.TextEdit
        Me.txtCategoryNm = New DevExpress.XtraEditors.TextEdit
        Me.txtRefNO = New DevExpress.XtraEditors.TextEdit
        Me.lblAdjustedQty = New System.Windows.Forms.Label
        Me.lblUOM = New System.Windows.Forms.Label
        Me.lblRelocationDt = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblProductNm = New System.Windows.Forms.Label
        Me.lblCategoryNm = New System.Windows.Forms.Label
        Me.CategoryTree = New System.Windows.Forms.TreeView
        Me.lblCategoryList = New System.Windows.Forms.Label
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.lblProductList = New System.Windows.Forms.Label
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AdjustmentBtn = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSrcLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSrcArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSrcWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdjustedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdjustmentDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.grdStock)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.txtWarehouse)
        Me.GroupBox1.Controls.Add(Me.lookupSrcLocation)
        Me.GroupBox1.Controls.Add(Me.lookupSrcArea)
        Me.GroupBox1.Controls.Add(Me.lookupSrcWarehouse)
        Me.GroupBox1.Controls.Add(Me.lblSrcLocation)
        Me.GroupBox1.Controls.Add(Me.lblSrcArea)
        Me.GroupBox1.Controls.Add(Me.lblSrcWarehouse)
        Me.GroupBox1.Controls.Add(Me.txtCurrentQty)
        Me.GroupBox1.Controls.Add(Me.lblCurrentQty)
        Me.GroupBox1.Controls.Add(Me.txtConfirmQty)
        Me.GroupBox1.Controls.Add(Me.txtOrderQty)
        Me.GroupBox1.Controls.Add(Me.txtAdjustedQty)
        Me.GroupBox1.Controls.Add(Me.txtUOM)
        Me.GroupBox1.Controls.Add(Me.txtAdjustmentDt)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtProductNm)
        Me.GroupBox1.Controls.Add(Me.txtCategoryNm)
        Me.GroupBox1.Controls.Add(Me.txtRefNO)
        Me.GroupBox1.Controls.Add(Me.lblAdjustedQty)
        Me.GroupBox1.Controls.Add(Me.lblUOM)
        Me.GroupBox1.Controls.Add(Me.lblRelocationDt)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblProductNm)
        Me.GroupBox1.Controls.Add(Me.lblCategoryNm)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(240, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 404)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SearchBtn)
        Me.GroupBox3.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 56)
        Me.GroupBox3.TabIndex = 182
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Search"
        '
        'SearchBtn
        '
        Me.SearchBtn.AutoSize = False
        Me.SearchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Image = Nothing
        Me.SearchBtn.Location = New System.Drawing.Point(272, 16)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(64, 32)
        Me.SearchBtn.TabIndex = 73
        Me.SearchBtn.Text = "Search"
        '
        'ProductSearchTxt
        '
        Me.ProductSearchTxt.Location = New System.Drawing.Point(96, 28)
        Me.ProductSearchTxt.Name = "ProductSearchTxt"
        Me.ProductSearchTxt.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.ProductSearchTxt.Size = New System.Drawing.Size(168, 17)
        Me.ProductSearchTxt.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(10, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 28)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Type Product ID/Code :"
        '
        'grdStock
        '
        Me.grdStock.EditorsRepository = Me.PersistentRepository1
        Me.grdStock.Location = New System.Drawing.Point(8, 12)
        Me.grdStock.MainView = Me.GridView1
        Me.grdStock.Name = "grdStock"
        Me.grdStock.Size = New System.Drawing.Size(520, 180)
        Me.grdStock.TabIndex = 36
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(438, 344)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(90, 21)
        Me.txtLocation.TabIndex = 35
        Me.txtLocation.Visible = False
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(256, 344)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(108, 21)
        Me.txtArea.TabIndex = 34
        '
        'txtWarehouse
        '
        Me.txtWarehouse.Location = New System.Drawing.Point(88, 344)
        Me.txtWarehouse.Name = "txtWarehouse"
        Me.txtWarehouse.Size = New System.Drawing.Size(108, 21)
        Me.txtWarehouse.TabIndex = 33
        '
        'lookupSrcLocation
        '
        Me.lookupSrcLocation.Location = New System.Drawing.Point(256, 488)
        Me.lookupSrcLocation.Name = "lookupSrcLocation"
        Me.lookupSrcLocation.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupSrcLocation.Properties.NullString = ""
        Me.lookupSrcLocation.Size = New System.Drawing.Size(104, 21)
        Me.lookupSrcLocation.TabIndex = 30
        '
        'lookupSrcArea
        '
        Me.lookupSrcArea.Location = New System.Drawing.Point(144, 488)
        Me.lookupSrcArea.Name = "lookupSrcArea"
        Me.lookupSrcArea.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupSrcArea.Properties.NullString = ""
        Me.lookupSrcArea.Size = New System.Drawing.Size(96, 21)
        Me.lookupSrcArea.TabIndex = 29
        '
        'lookupSrcWarehouse
        '
        Me.lookupSrcWarehouse.Location = New System.Drawing.Point(32, 488)
        Me.lookupSrcWarehouse.Name = "lookupSrcWarehouse"
        Me.lookupSrcWarehouse.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupSrcWarehouse.Properties.NullString = ""
        Me.lookupSrcWarehouse.Size = New System.Drawing.Size(104, 21)
        Me.lookupSrcWarehouse.TabIndex = 28
        '
        'lblSrcLocation
        '
        Me.lblSrcLocation.Location = New System.Drawing.Point(380, 344)
        Me.lblSrcLocation.Name = "lblSrcLocation"
        Me.lblSrcLocation.Size = New System.Drawing.Size(56, 16)
        Me.lblSrcLocation.TabIndex = 27
        Me.lblSrcLocation.Text = "Location :"
        Me.lblSrcLocation.Visible = False
        '
        'lblSrcArea
        '
        Me.lblSrcArea.Location = New System.Drawing.Point(218, 344)
        Me.lblSrcArea.Name = "lblSrcArea"
        Me.lblSrcArea.Size = New System.Drawing.Size(40, 16)
        Me.lblSrcArea.TabIndex = 26
        Me.lblSrcArea.Text = "Area :"
        '
        'lblSrcWarehouse
        '
        Me.lblSrcWarehouse.Location = New System.Drawing.Point(17, 344)
        Me.lblSrcWarehouse.Name = "lblSrcWarehouse"
        Me.lblSrcWarehouse.Size = New System.Drawing.Size(72, 16)
        Me.lblSrcWarehouse.TabIndex = 25
        Me.lblSrcWarehouse.Text = "Warehouse :"
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(256, 368)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(88, 21)
        Me.txtCurrentQty.TabIndex = 24
        '
        'lblCurrentQty
        '
        Me.lblCurrentQty.Location = New System.Drawing.Point(184, 368)
        Me.lblCurrentQty.Name = "lblCurrentQty"
        Me.lblCurrentQty.Size = New System.Drawing.Size(70, 16)
        Me.lblCurrentQty.TabIndex = 23
        Me.lblCurrentQty.Text = "Current Qty :"
        '
        'txtConfirmQty
        '
        Me.txtConfirmQty.Location = New System.Drawing.Point(256, 520)
        Me.txtConfirmQty.Name = "txtConfirmQty"
        Me.txtConfirmQty.Size = New System.Drawing.Size(96, 21)
        Me.txtConfirmQty.TabIndex = 22
        '
        'txtOrderQty
        '
        Me.txtOrderQty.Location = New System.Drawing.Point(144, 520)
        Me.txtOrderQty.Name = "txtOrderQty"
        Me.txtOrderQty.Size = New System.Drawing.Size(104, 21)
        Me.txtOrderQty.TabIndex = 21
        '
        'txtAdjustedQty
        '
        Me.txtAdjustedQty.Location = New System.Drawing.Point(438, 368)
        Me.txtAdjustedQty.Name = "txtAdjustedQty"
        Me.txtAdjustedQty.Size = New System.Drawing.Size(90, 21)
        Me.txtAdjustedQty.TabIndex = 16
        '
        'txtUOM
        '
        Me.txtUOM.Location = New System.Drawing.Point(88, 368)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(88, 21)
        Me.txtUOM.TabIndex = 15
        '
        'txtAdjustmentDt
        '
        Me.txtAdjustmentDt.Location = New System.Drawing.Point(104, 272)
        Me.txtAdjustmentDt.Name = "txtAdjustmentDt"
        Me.txtAdjustmentDt.Size = New System.Drawing.Size(88, 21)
        Me.txtAdjustmentDt.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(88, 320)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(440, 21)
        Me.txtDescription.TabIndex = 13
        '
        'txtProductNm
        '
        Me.txtProductNm.Location = New System.Drawing.Point(256, 296)
        Me.txtProductNm.Name = "txtProductNm"
        Me.txtProductNm.Size = New System.Drawing.Size(272, 21)
        Me.txtProductNm.TabIndex = 12
        '
        'txtCategoryNm
        '
        Me.txtCategoryNm.Location = New System.Drawing.Point(88, 296)
        Me.txtCategoryNm.Name = "txtCategoryNm"
        Me.txtCategoryNm.Size = New System.Drawing.Size(104, 21)
        Me.txtCategoryNm.TabIndex = 11
        '
        'txtRefNO
        '
        Me.txtRefNO.Location = New System.Drawing.Point(32, 520)
        Me.txtRefNO.Name = "txtRefNO"
        Me.txtRefNO.Size = New System.Drawing.Size(104, 21)
        Me.txtRefNO.TabIndex = 10
        '
        'lblAdjustedQty
        '
        Me.lblAdjustedQty.Location = New System.Drawing.Point(358, 368)
        Me.lblAdjustedQty.Name = "lblAdjustedQty"
        Me.lblAdjustedQty.Size = New System.Drawing.Size(76, 16)
        Me.lblAdjustedQty.TabIndex = 6
        Me.lblAdjustedQty.Text = "Adjusted Qty :"
        '
        'lblUOM
        '
        Me.lblUOM.Location = New System.Drawing.Point(48, 368)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(40, 16)
        Me.lblUOM.TabIndex = 5
        Me.lblUOM.Text = "UOM :"
        '
        'lblRelocationDt
        '
        Me.lblRelocationDt.Location = New System.Drawing.Point(8, 272)
        Me.lblRelocationDt.Name = "lblRelocationDt"
        Me.lblRelocationDt.Size = New System.Drawing.Size(96, 16)
        Me.lblRelocationDt.TabIndex = 4
        Me.lblRelocationDt.Text = "Adjustment Date :"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(19, 320)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(72, 16)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description :"
        '
        'lblProductNm
        '
        Me.lblProductNm.Location = New System.Drawing.Point(204, 296)
        Me.lblProductNm.Name = "lblProductNm"
        Me.lblProductNm.Size = New System.Drawing.Size(56, 16)
        Me.lblProductNm.TabIndex = 2
        Me.lblProductNm.Text = "Product :"
        '
        'lblCategoryNm
        '
        Me.lblCategoryNm.Location = New System.Drawing.Point(28, 296)
        Me.lblCategoryNm.Name = "lblCategoryNm"
        Me.lblCategoryNm.Size = New System.Drawing.Size(56, 16)
        Me.lblCategoryNm.TabIndex = 1
        Me.lblCategoryNm.Text = "Category :"
        '
        'CategoryTree
        '
        Me.CategoryTree.ImageIndex = -1
        Me.CategoryTree.Location = New System.Drawing.Point(8, 24)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.SelectedImageIndex = -1
        Me.CategoryTree.Size = New System.Drawing.Size(208, 208)
        Me.CategoryTree.TabIndex = 25
        '
        'lblCategoryList
        '
        Me.lblCategoryList.Location = New System.Drawing.Point(8, 8)
        Me.lblCategoryList.Name = "lblCategoryList"
        Me.lblCategoryList.Size = New System.Drawing.Size(112, 16)
        Me.lblCategoryList.TabIndex = 24
        Me.lblCategoryList.Text = "Category List"
        '
        'ProductList
        '
        Me.ProductList.Location = New System.Drawing.Point(8, 240)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(208, 212)
        Me.ProductList.TabIndex = 27
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(226, 461)
        Me.Splitter1.TabIndex = 23
        Me.Splitter1.TabStop = False
        '
        'lblProductList
        '
        Me.lblProductList.Location = New System.Drawing.Point(8, 280)
        Me.lblProductList.Name = "lblProductList"
        Me.lblProductList.Size = New System.Drawing.Size(104, 16)
        Me.lblProductList.TabIndex = 26
        Me.lblProductList.Text = "Product List"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(688, 432)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(88, 24)
        Me.CloseBtn.TabIndex = 30
        Me.CloseBtn.Text = "Close"
        '
        'AdjustmentBtn
        '
        Me.AdjustmentBtn.AutoSize = False
        Me.AdjustmentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdjustmentBtn.Image = Nothing
        Me.AdjustmentBtn.Location = New System.Drawing.Point(592, 432)
        Me.AdjustmentBtn.Name = "AdjustmentBtn"
        Me.AdjustmentBtn.Size = New System.Drawing.Size(88, 24)
        Me.AdjustmentBtn.TabIndex = 29
        Me.AdjustmentBtn.Text = "Adjust"
        '
        'StockAdjustmentForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.lblCategoryList)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.lblProductList)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.AdjustmentBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "StockAdjustmentForm"
        Me.Text = "StockAdjustment"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSrcLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSrcArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSrcWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdjustedQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdjustmentDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load Form"
    Private Sub StockRAdjustmentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadCategoryList()
        txtAdjustmentDt.Text = Date.Today
        DisableFields()
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region " Code - Category tree list"
    Private Sub LoadCategoryList()
        Dim node As TreeNode
        Dim Root As TreeNode = New TreeNode("Category")

        Root.Nodes.Clear()
        CategoryTree.Nodes.Clear()
        CategoryTree.Nodes.Add(Root)
        With New BusinessRules.CategoryBusRules.CategoryBusLogic
            Dim dsCategory As DataSet
            If .GetCategory(dsCategory) Then
                If (dsCategory.Tables(0).Rows.Count > 0) Then
                    Dim pk, fk As DataColumn
                    pk = dsCategory.Tables(0).Columns(0)
                    fk = dsCategory.Tables(0).Columns(2)

                    dsCategory.Relations.Add(New DataRelation("ParentCategoryRelation", pk, fk, False))
                    Dim dr As DataRow = dsCategory.Tables(0).Rows(0)

                    Dim oRow2 As DataRow
                    For Each oRow2 In dsCategory.Tables(0).Rows
                        If oRow2("Thread_Level") = 1 Then
                            doCatePopulate(node, oRow2, dsCategory.Relations(0))
                            Root.Nodes.Add(node)
                        End If
                    Next
                End If
            End If
        End With
        CategoryTree.CollapseAll()
        CategoryTree.SelectedNode = Root
        'CategoryTree.ExpandAll()
    End Sub

    Private Sub doCatePopulate(ByRef Node As TreeNode, ByVal dr As DataRow, ByVal rel As DataRelation)
        Dim Row As DataRow

        Node = New TreeNode(dr(4).ToString(), 0, 0)
        Node.Tag = dr(0)
        For Each Row In dr.GetChildRows(rel)
            Dim newNode As TreeNode = New TreeNode
            doCatePopulate(newNode, Row, rel)
            Node.Nodes.Add(newNode)
        Next
    End Sub

    'Event for Category List
    Private Sub CategoryTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles CategoryTree.AfterSelect
        Dim CurrentTag As Integer
        Dim CurrentText As String

        CurrentTag = CInt(CategoryTree.SelectedNode.Tag)
        CurrentText = CategoryTree.SelectedNode.Text()

        If CurrentTag <> Nothing Then
            txtCategoryNm.Text = CurrentText
            Category_ID = CurrentTag
            RefreshProductList(Category_ID)
        Else
            txtCategoryNm.Text = ""
        End If
        grdStock.DataSource = Nothing
        GridView1.Columns.Clear()
        ClearFields()
        AdjustmentBtn.Enabled = False
    End Sub
#End Region

#Region " Load Product List and Functions"
    'After category click, load product list
    Private Sub RefreshProductList(ByVal pCategoryID As Integer)
        Dim ds As DataSet

        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .LoadList(ds, pCategoryID) Then
                If Not ds Is Nothing Then
                    Try
                        ProductList.DisplayMember = "Name"
                        ProductList.ValueMember = "Product_ID"
                        ProductList.DataSource = ds.Tables(0)

                        If ds.Tables(0).Rows.Count > 0 Then
                            EmptyList = False
                        Else
                            EmptyList = True
                        End If
                        LoadProductList()
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub ProductList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.Click
        LoadProductList()
    End Sub

    Private Sub LoadProductList()
        Dim UOM_ID As Integer
        Dim dsStock As DataSet

        If Category_ID = 0 Then
            Exit Sub
        End If

        If Not EmptyList Then
            ClearFields()
            Product_ID = CInt(ProductList.SelectedItem("Product_ID"))
            txtProductNm.Text = ProductList.SelectedItem("Name")
            AdjustmentBtn.Enabled = False
            PopulateGrid()
        End If
    End Sub
#End Region

#Region " Component Grid Functions"
    Public Sub PopulateGrid()
        grdStock.DataSource = Nothing

        With New BusinessRules.BusRules.InventoryBusLogic
            .Product_ID = Product_ID
            .Transaction_Type = Transaction_Type

            dsStock = .GetStock()
            If Not dsStock Is Nothing Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In dsStock.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {i, oRow("Stock_ID"), oRow("Supplier_ID"), oRow("UOM_ID"), oRow("Warehouse_ID"), oRow("Warehouse_Area_ID"), oRow("Location_ID"), oRow("Qty"), oRow("UOM"), oRow("Description"), oRow("Warehouse"), oRow("Warehouse_Area")})
                Next

                grdStock.DataSource = data
                grdStock.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide StockID column
                GridView1.Columns.Item(2).VisibleIndex = -1 'hide SupplierID column
                GridView1.Columns.Item(3).VisibleIndex = -1 'hide UOMID column
                GridView1.Columns.Item(4).VisibleIndex = -1 'hide WarehouseID column
                GridView1.Columns.Item(5).VisibleIndex = -1 'hide WarehouseAreaID column
                GridView1.Columns.Item(6).VisibleIndex = -1 'hide LocationID column
                GridView1.Columns.Item(7).VisibleIndex = -1 'hide Qty column
                GridView1.Columns.Item(8).VisibleIndex = -1 'hide UOM column
            Else
                GridView1.Columns.Clear()
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "S/No", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Stock ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Supplier ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "UOM ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "WH ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "WHA ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Location ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "UOM", System.Type.GetType("System.String"), True)
        AddColumn(data, "Product Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Warehouse", System.Type.GetType("System.String"), True)
        AddColumn(data, "Area", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Row", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Column", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Height", System.Type.GetType("System.Int16"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Sub grdStock_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdStock.MouseUp
        If GridView1.RowCount > 0 Then
            Dim mouseDownLocation As New Point(e.X, e.Y)
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            Dim eventString As String = Nothing

            dr = GridView1.GetDataRow(Row)
            Select Case e.Button
                Case MouseButtons.Left
                    eventString = "L"
                    PopulateToForm(dr)
                Case MouseButtons.Right
                    eventString = "R"
                Case MouseButtons.None
                    eventString = Nothing
            End Select
        End If
    End Sub

    Private Sub PopulateToForm(ByVal drow As DataRow)
        AdjustmentBtn.Enabled = True
        txtDescription.Text = drow.Item("Product Description")
        Stock_ID = CInt(drow.Item("Stock ID"))
        Supplier_ID = CInt(drow.Item("Supplier ID"))
        txtUOM.Tag = drow.Item("UOM ID")
        txtUOM.Text = drow.Item("UOM")
        txtCurrentQty.Text = drow.Item("Qty")
        txtAdjustedQty.Text = ""
        txtWarehouse.Tag = drow.Item("WH ID")
        txtWarehouse.Text = drow.Item("Warehouse")
        txtArea.Tag = drow.Item("WHA ID")
        txtArea.Text = drow.Item("Area")
        txtLocation.Tag = drow.Item("Location ID")
        'txtLocation.Text = drow.Item("Row") & ", " & drow.Item("Column") & ", " & drow.Item("Height")
    End Sub
#End Region

#Region " Codes for Adjustment, Search and Close Buttons"
    'Action for Relocate Button
    Private Sub AdjustmentBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdjustmentBtn.Click
        If txtAdjustedQty.Text = "" Then
            Adjusted_Qty = 0
        Else
            Adjusted_Qty = CInt(txtAdjustedQty.Text)
        End If

        'Adjusted_Qty = CInt(txtAdjustedQty.Text)
        In_Store_Qty = CInt(txtCurrentQty.Text)
        WH_ID = CInt(txtWarehouse.Tag)
        WHA_ID = CInt(txtArea.Tag)
        Location_ID = CInt(txtLocation.Tag)
        UOM_ID = CInt(txtUOM.Tag)

        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Adjusted_Qty = Adjusted_Qty
            .In_Store_Qty = In_Store_Qty

            If Not .ValidQty Then
                MessageBox.Show("Adjusted quantity cannot be empty, 0 or < 0 !", "Stock Relocation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            .Stock_ID = Stock_ID
            .Category_ID = Category_ID
            .Product_ID = Product_ID
            .Supplier_ID = Supplier_ID
            .WH_ID = WH_ID
            .WHA_ID = WHA_ID
            .Location_ID = Location_ID
            .UOM_ID = UOM_ID
            .UserID = UserID

            If .UpdateSelectedStock And .SaveStockTransaction Then
                MessageBox.Show("Stock adjusted successfully. ", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Encounter error while adjusting stock ! ", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ClearFields()
            PopulateGrid()
            AdjustmentBtn.Enabled = False
        End With
    End Sub

    'Action for Close Button
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        RefreshProductListByProductID(ProductSearchTxt.Text)
    End Sub

    Private Sub RefreshProductListByProductID(ByVal ProductID As String)
        Dim ds As DataSet
        'Load product list
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .Load(ds, ProductID) Then
                If Not ds Is Nothing Then
                    Try
                        ProductList.DisplayMember = "Name"
                        ProductList.ValueMember = "Product_ID"

                        ProductList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
#End Region

#Region " Functions for Form Fields"
    'Set Text Boxes Blank
    Private Sub ClearFields()
        txtDescription.Text = ""
        txtUOM.Text = ""
        txtCurrentQty.Text = ""
        txtAdjustedQty.Text = ""
        txtWarehouse.Text = ""
        txtArea.Text = ""
        txtLocation.Text = ""
    End Sub

    'Disable Non-Editable Fields
    Private Sub DisableFields()
        txtCategoryNm.Enabled = False
        txtProductNm.Enabled = False
        txtDescription.Enabled = False
        txtAdjustmentDt.Enabled = False
        txtUOM.Enabled = False
        txtCurrentQty.Enabled = False
        txtWarehouse.Enabled = False
        txtArea.Enabled = False
        txtLocation.Enabled = False
        AdjustmentBtn.Enabled = False
    End Sub
#End Region


    Private Sub ProductList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
        ProductList_Click(sender, e)
    End Sub
    Private Sub StockAdjustmentForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit stock adjustment screen?", "Stock Relocation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
End Class
