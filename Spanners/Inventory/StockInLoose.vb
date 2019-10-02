Public Class StockInLooseForm
    Inherits System.Windows.Forms.Form

#Region " Declare Public Variables"
    Public UserID As String = Common.CommonConn.Config.USERID
    Public Transaction_Type As String = "Stock In"
    Public StockInType As String = "Loose Item"
    Public OrderType As String
    Public Unit As String
    Public PO_No As String

    Public data As System.Data.DataTable
    Public Transaction_Status As Boolean
    Public EmptyList As Boolean = True

    Public Supplier_ID As Integer = 0
    Public PO_ID As Integer = 0
    Public Old_PO_ID As Integer = 0
    Public PO_Line_ID As Integer = 0
    Public Stock_ID As Integer = 0
    Public Category_ID As Integer = 0
    Public Product_ID As Integer = 0
    Public WH_ID As Integer = 0
    Public WHA_ID As Integer = 0
    Public Location_ID As Integer = 0
    Public UOM_ID As Integer = 0
    Public StockInQty As Integer
    Public OrderQty As Integer
    Public ConfirmQty As Integer
    Public QtyDifference As Integer
    Public NewConfirmQty As Integer
    Public PO_Line_Status As Integer
    Public PO_Header_Status As Integer
    Public AccessCount As Integer = 0
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
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents StockInBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents lblProductList As System.Windows.Forms.Label
    Friend WithEvents lblCategoryList As System.Windows.Forms.Label
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lookupSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lookupLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookupArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookupWarehouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtStockInQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockInDt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCategoryNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRefNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents lblStockInQty As System.Windows.Forms.Label
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents lblStockInDt As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblProductNm As System.Windows.Forms.Label
    Friend WithEvents lblCategoryNm As System.Windows.Forms.Label
    Friend WithEvents lblRefNO As System.Windows.Forms.Label
    Friend WithEvents txtLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.StockInBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CategoryTree = New System.Windows.Forms.TreeView
        Me.lblProductList = New System.Windows.Forms.Label
        Me.lblCategoryList = New System.Windows.Forms.Label
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SearchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLocation = New DevExpress.XtraEditors.TextEdit
        Me.lookupSupplier = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSupplier = New System.Windows.Forms.Label
        Me.lookupLocation = New DevExpress.XtraEditors.LookUpEdit
        Me.lookupArea = New DevExpress.XtraEditors.LookUpEdit
        Me.lookupWarehouse = New DevExpress.XtraEditors.LookUpEdit
        Me.txtStockInQty = New DevExpress.XtraEditors.TextEdit
        Me.txtUOM = New DevExpress.XtraEditors.TextEdit
        Me.txtStockInDt = New DevExpress.XtraEditors.TextEdit
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit
        Me.txtProductNm = New DevExpress.XtraEditors.TextEdit
        Me.txtCategoryNm = New DevExpress.XtraEditors.TextEdit
        Me.txtRefNO = New DevExpress.XtraEditors.TextEdit
        Me.lblLocation = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.lblWarehouse = New System.Windows.Forms.Label
        Me.lblStockInQty = New System.Windows.Forms.Label
        Me.lblUOM = New System.Windows.Forms.Label
        Me.lblStockInDt = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblProductNm = New System.Windows.Forms.Label
        Me.lblCategoryNm = New System.Windows.Forms.Label
        Me.lblRefNO = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockInQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockInDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(600, 328)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(88, 24)
        Me.CloseBtn.TabIndex = 29
        Me.CloseBtn.Text = "Close"
        '
        'StockInBtn
        '
        Me.StockInBtn.AutoSize = False
        Me.StockInBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockInBtn.Image = Nothing
        Me.StockInBtn.Location = New System.Drawing.Point(496, 328)
        Me.StockInBtn.Name = "StockInBtn"
        Me.StockInBtn.Size = New System.Drawing.Size(88, 24)
        Me.StockInBtn.TabIndex = 28
        Me.StockInBtn.Text = "Stock In"
        '
        'CategoryTree
        '
        Me.CategoryTree.ImageIndex = -1
        Me.CategoryTree.Location = New System.Drawing.Point(12, 24)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.SelectedImageIndex = -1
        Me.CategoryTree.Size = New System.Drawing.Size(208, 200)
        Me.CategoryTree.TabIndex = 24
        '
        'lblProductList
        '
        Me.lblProductList.Location = New System.Drawing.Point(12, 232)
        Me.lblProductList.Name = "lblProductList"
        Me.lblProductList.Size = New System.Drawing.Size(104, 16)
        Me.lblProductList.TabIndex = 25
        Me.lblProductList.Text = "Product List"
        '
        'lblCategoryList
        '
        Me.lblCategoryList.Location = New System.Drawing.Point(12, 8)
        Me.lblCategoryList.Name = "lblCategoryList"
        Me.lblCategoryList.Size = New System.Drawing.Size(112, 16)
        Me.lblCategoryList.TabIndex = 23
        Me.lblCategoryList.Text = "Category List"
        '
        'ProductList
        '
        Me.ProductList.Location = New System.Drawing.Point(12, 248)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(208, 199)
        Me.ProductList.TabIndex = 26
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(232, 461)
        Me.Splitter1.TabIndex = 22
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.lookupSupplier)
        Me.GroupBox1.Controls.Add(Me.lblSupplier)
        Me.GroupBox1.Controls.Add(Me.lookupLocation)
        Me.GroupBox1.Controls.Add(Me.lookupArea)
        Me.GroupBox1.Controls.Add(Me.lookupWarehouse)
        Me.GroupBox1.Controls.Add(Me.txtStockInQty)
        Me.GroupBox1.Controls.Add(Me.txtUOM)
        Me.GroupBox1.Controls.Add(Me.txtStockInDt)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtProductNm)
        Me.GroupBox1.Controls.Add(Me.txtCategoryNm)
        Me.GroupBox1.Controls.Add(Me.txtRefNO)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.lblWarehouse)
        Me.GroupBox1.Controls.Add(Me.lblStockInQty)
        Me.GroupBox1.Controls.Add(Me.lblUOM)
        Me.GroupBox1.Controls.Add(Me.lblStockInDt)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblProductNm)
        Me.GroupBox1.Controls.Add(Me.lblCategoryNm)
        Me.GroupBox1.Controls.Add(Me.lblRefNO)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(244, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 302)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SearchBtn)
        Me.GroupBox3.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 56)
        Me.GroupBox3.TabIndex = 181
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
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(112, 264)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Properties.AllowFocused = False
        Me.txtLocation.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.txtLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtLocation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtLocation.Size = New System.Drawing.Size(125, 15)
        Me.txtLocation.TabIndex = 40
        Me.txtLocation.Visible = False
        '
        'lookupSupplier
        '
        Me.lookupSupplier.Location = New System.Drawing.Point(96, 184)
        Me.lookupSupplier.Name = "lookupSupplier"
        Me.lookupSupplier.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupSupplier.Properties.NullString = ""
        Me.lookupSupplier.Properties.PopupWidth = 280
        Me.lookupSupplier.Size = New System.Drawing.Size(264, 21)
        Me.lookupSupplier.TabIndex = 24
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(40, 184)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(56, 16)
        Me.lblSupplier.TabIndex = 23
        Me.lblSupplier.Text = "Supplier :"
        '
        'lookupLocation
        '
        Me.lookupLocation.Location = New System.Drawing.Point(296, 264)
        Me.lookupLocation.Name = "lookupLocation"
        Me.lookupLocation.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupLocation.Properties.NullString = ""
        Me.lookupLocation.Properties.PopupWidth = 152
        Me.lookupLocation.Size = New System.Drawing.Size(152, 21)
        Me.lookupLocation.TabIndex = 19
        Me.lookupLocation.Visible = False
        '
        'lookupArea
        '
        Me.lookupArea.Location = New System.Drawing.Point(296, 232)
        Me.lookupArea.Name = "lookupArea"
        Me.lookupArea.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupArea.Properties.NullString = ""
        Me.lookupArea.Properties.PopupWidth = 152
        Me.lookupArea.Size = New System.Drawing.Size(152, 21)
        Me.lookupArea.TabIndex = 18
        '
        'lookupWarehouse
        '
        Me.lookupWarehouse.Location = New System.Drawing.Point(96, 232)
        Me.lookupWarehouse.Name = "lookupWarehouse"
        Me.lookupWarehouse.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupWarehouse.Properties.NullString = ""
        Me.lookupWarehouse.Properties.PopupWidth = 152
        Me.lookupWarehouse.Size = New System.Drawing.Size(152, 21)
        Me.lookupWarehouse.TabIndex = 17
        '
        'txtStockInQty
        '
        Me.txtStockInQty.Location = New System.Drawing.Point(296, 208)
        Me.txtStockInQty.Name = "txtStockInQty"
        Me.txtStockInQty.Size = New System.Drawing.Size(80, 21)
        Me.txtStockInQty.TabIndex = 16
        '
        'txtUOM
        '
        Me.txtUOM.Location = New System.Drawing.Point(96, 208)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(88, 21)
        Me.txtUOM.TabIndex = 15
        '
        'txtStockInDt
        '
        Me.txtStockInDt.Location = New System.Drawing.Point(96, 88)
        Me.txtStockInDt.Name = "txtStockInDt"
        Me.txtStockInDt.Size = New System.Drawing.Size(104, 21)
        Me.txtStockInDt.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 160)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(352, 21)
        Me.txtDescription.TabIndex = 13
        '
        'txtProductNm
        '
        Me.txtProductNm.Location = New System.Drawing.Point(96, 136)
        Me.txtProductNm.Name = "txtProductNm"
        Me.txtProductNm.Size = New System.Drawing.Size(352, 21)
        Me.txtProductNm.TabIndex = 12
        '
        'txtCategoryNm
        '
        Me.txtCategoryNm.Location = New System.Drawing.Point(96, 112)
        Me.txtCategoryNm.Name = "txtCategoryNm"
        Me.txtCategoryNm.Size = New System.Drawing.Size(152, 21)
        Me.txtCategoryNm.TabIndex = 11
        '
        'txtRefNO
        '
        Me.txtRefNO.Location = New System.Drawing.Point(312, 88)
        Me.txtRefNO.Name = "txtRefNO"
        Me.txtRefNO.Size = New System.Drawing.Size(136, 21)
        Me.txtRefNO.TabIndex = 10
        Me.txtRefNO.Visible = False
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(240, 264)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(56, 16)
        Me.lblLocation.TabIndex = 9
        Me.lblLocation.Text = "Location :"
        Me.lblLocation.Visible = False
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(256, 232)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 8
        Me.lblArea.Text = "Area :"
        '
        'lblWarehouse
        '
        Me.lblWarehouse.Location = New System.Drawing.Point(24, 232)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(72, 16)
        Me.lblWarehouse.TabIndex = 7
        Me.lblWarehouse.Text = "Warehouse :"
        '
        'lblStockInQty
        '
        Me.lblStockInQty.Location = New System.Drawing.Point(216, 208)
        Me.lblStockInQty.Name = "lblStockInQty"
        Me.lblStockInQty.Size = New System.Drawing.Size(76, 16)
        Me.lblStockInQty.TabIndex = 6
        Me.lblStockInQty.Text = "Stock In Qty :"
        '
        'lblUOM
        '
        Me.lblUOM.Location = New System.Drawing.Point(54, 208)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(40, 16)
        Me.lblUOM.TabIndex = 5
        Me.lblUOM.Text = "UOM :"
        '
        'lblStockInDt
        '
        Me.lblStockInDt.Location = New System.Drawing.Point(14, 88)
        Me.lblStockInDt.Name = "lblStockInDt"
        Me.lblStockInDt.Size = New System.Drawing.Size(80, 16)
        Me.lblStockInDt.TabIndex = 4
        Me.lblStockInDt.Text = "Stock In Date :"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(26, 160)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(72, 16)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description :"
        '
        'lblProductNm
        '
        Me.lblProductNm.Location = New System.Drawing.Point(40, 136)
        Me.lblProductNm.Name = "lblProductNm"
        Me.lblProductNm.Size = New System.Drawing.Size(56, 16)
        Me.lblProductNm.TabIndex = 2
        Me.lblProductNm.Text = "Product :"
        '
        'lblCategoryNm
        '
        Me.lblCategoryNm.Location = New System.Drawing.Point(36, 112)
        Me.lblCategoryNm.Name = "lblCategoryNm"
        Me.lblCategoryNm.Size = New System.Drawing.Size(56, 16)
        Me.lblCategoryNm.TabIndex = 1
        Me.lblCategoryNm.Text = "Category :"
        '
        'lblRefNO
        '
        Me.lblRefNO.Location = New System.Drawing.Point(262, 88)
        Me.lblRefNO.Name = "lblRefNO"
        Me.lblRefNO.Size = New System.Drawing.Size(48, 16)
        Me.lblRefNO.TabIndex = 0
        Me.lblRefNO.Text = "PO NO :"
        Me.lblRefNO.Visible = False
        '
        'StockInLooseForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(720, 461)
        Me.Controls.Add(Me.StockInBtn)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.lblProductList)
        Me.Controls.Add(Me.lblCategoryList)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Name = "StockInLooseForm"
        Me.Text = "StockInLoose"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockInQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockInDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Form load"
    Private Sub StockInLooseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        'ChangeComponentProperties()
        DisableFields()
        txtStockInDt.Text = Date.Today

        'lookupSupplier.Visible = True
        'lookupSupplier.Enabled = True

        LoadCategoryList()
        'LoadSupplier()
        LoadWarehouse()
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub ChangeComponentProperties()
    '    Me.lblRefNO.Visible = False
    '    Me.txtRefNO.Visible = False
    '    Me.txtRefNO.Enabled = False
    'End Sub
#End Region

#Region " Load Category Tree List and Functions"
    'For Category Portion
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
        'dr(4) - column 4 is Category Name
        Node = New TreeNode(dr(4).ToString(), 0, 0)
        Node.Tag = dr(0)

        Dim Row As DataRow
        For Each Row In dr.GetChildRows(rel)
            Dim newNode As TreeNode = New TreeNode
            doCatePopulate(newNode, Row, rel)
            Node.Nodes.Add(newNode)
        Next
    End Sub

    'Event for Category List
    Private Sub CategoryTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles CategoryTree.AfterSelect
        Dim CurrentTag
        Dim CurrentText

        CurrentTag = CategoryTree.SelectedNode.Tag
        CurrentText = CategoryTree.SelectedNode.Text()

        ClearFields()
        DisableFields()
        If CurrentTag <> Nothing Then
            'TemplateCtr.Enabled = True
            'SupplierGrp.Enabled = True
            'AddBut.Enabled = True
            'SaveBtn.Enabled = True

            txtCategoryNm.Text = CurrentText
            Category_ID = CurrentTag

            RefreshProductList(Category_ID)
        Else
            txtCategoryNm.Text = ""
            '    TemplateCtr.Enabled = False
            '    SupplierGrp.Enabled = False
            '    AddBut.Enabled = False
            '    SaveBtn.Enabled = False
        End If
        StockInBtn.Enabled = False
    End Sub
#End Region

#Region " Load Product Lists and Functions"
    'After category click, load product list
    Private Sub RefreshProductList(ByVal pCategoryID As Integer)
        Dim ds As DataSet
        'Load product list
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
                        'Check if there is list of product
                        'If ds.Tables(0).Rows.Count > 0 Then
                        'TemplateCtr.Enabled = True
                        'ModifyProduct()
                        'Else
                        '    ClearAll()
                        '    TemplateCtr.Enabled = False
                        'End If
                        LoadProductList()
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load product list
    End Sub

    Private Sub ProductList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.Click
        LoadProductList()
    End Sub

    Private Sub LoadProductList()
        Dim dsUOM As DataSet

        If Not EmptyList Then
            ClearFields()
            Product_ID = CInt(ProductList.SelectedItem("Product_ID"))
            UOM_ID = CInt(ProductList.SelectedItem("UOM_ID"))
            txtProductNm.Text = ProductList.SelectedItem("Name")
            txtDescription.Text = ProductList.SelectedItem("Description")

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
            LoadSupplier()
            txtRefNO.Enabled = True
            txtStockInQty.Enabled = True
            lookupSupplier.Enabled = True
            lookupWarehouse.Enabled = True
            lookupArea.Enabled = True
            StockInBtn.Enabled = True
        End If
    End Sub
#End Region

#Region " Codes for Buttons"
    Private Sub StockInBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockInBtn.Click
        StockInQty = CInt(txtStockInQty.Text)
        SaveDataProcess()
        If Transaction_Status = True Then
            ClearFields()
            DisableFields()
            'StockInBtn.Enabled = False
        End If
    End Sub

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

#Region " Save Transaction"
    Private Sub SaveDataProcess()
        Dim dsExist As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .Supplier_ID = Supplier_ID

            If .EmptySupplier Then
                MessageBox.Show("You did not select a supplier !", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Transaction_Status = False
                Exit Sub
            End If

            .Transaction_Type = Transaction_Type
            .Stock_In_Type = StockInType
            .StockInQty = StockInQty

            If Not .ValidQty Then
                MessageBox.Show("Stock in quantity cannot be < 0 or = 0 !", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Transaction_Status = False
                Exit Sub
            End If

            'If .EmptyWarehouse Then
            'MessageBox.Show("You did not select a warehouse !", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Transaction_Status = False
            'Exit Sub
            'End If

            'If .EmptyArea Then
            'MessageBox.Show("You did not select a warehouse area !", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Transaction_Status = False
            'Exit Sub
            'End If

            'If .EmptyLocation Then
            'MessageBox.Show("You did not select a warehouse location !", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Transaction_Status = False
            'Exit Sub
            'End If

            .WH_ID = WH_ID
            .WHA_ID = WHA_ID
            .Location_ID = Location_ID

            If .EmptyLocation Then
                MessageBox.Show("Warehouse location cannot be empty !", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Transaction_Status = False
                Exit Sub
            End If

            .Category_ID = Category_ID
            .Product_ID = Product_ID
            .UOM_ID = UOM_ID
            .UserID = UserID

            If QtyDifference = 0 Then
                PO_Line_Status = 90
                .PO_Line_Status = PO_Line_Status
            End If

            dsExist = .RecordExist
            If Not dsExist Is Nothing Then
                Stock_ID = dsExist.Tables(0).Rows(0).Item("Stock_ID")
                .Stock_ID = Stock_ID
                If .UpdateSelectedStock And .SaveStockTransaction Then
                    MessageBox.Show("Stock in successfully. ", "Stock In (Loose Item)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Encounter error while stocking in ! ", "Stock In (Loose Item)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                If .SaveNewStock And .SaveStockTransaction Then
                    MessageBox.Show("Stock in successfully. ", "Stock In (Loose Item)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Encounter error while stocking in ! ", "Stock In (Loose Item)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End With
        Transaction_Status = True
    End Sub
#End Region

#Region " Load Supplier Combo and Action Functions"
    'Load list of suppliers to combo
    Private Sub LoadSupplier()
        Dim dsSupplier As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Product_ID = Product_ID
            dsSupplier = .GetSupplier
            If Not dsSupplier Is Nothing Then
                Try
                    lookupSupplier.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(lookupSupplier, "Supplier_Name", 200, 0, "")
                    lookupSupplier.Properties.LookUpData.KeyField = "Supplier_ID"
                    lookupSupplier.Properties.LookUpData.DisplayField = "Supplier_Name"
                    lookupSupplier.Properties.LookUpData.DataSource = dsSupplier.Tables(0)
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub lookupSupplier_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupSupplier.CloseUp
        Supplier_ID = lookupSupplier.Properties.LookUpData.KeyValue
    End Sub
#End Region

#Region " Load Warehouse, Area and Location Combo"
    'Load list of warehouse to combo
    Private Sub LoadWarehouse()
        Dim dsWarehouse As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            dsWarehouse = .GetWarehouse
            If Not dsWarehouse Is Nothing Then
                Try
                    lookupWarehouse.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(lookupWarehouse, "Warehouse", 200, 0, "")
                    lookupWarehouse.Properties.LookUpData.KeyField = "Warehouse_ID"
                    lookupWarehouse.Properties.LookUpData.DisplayField = "Warehouse"
                    lookupWarehouse.Properties.LookUpData.DataSource = dsWarehouse.Tables(0)
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With
    End Sub

    'Load list of warehouse area to combo
    Private Sub LoadWarehouseArea()
        Dim dsArea As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = WH_ID
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

    'Load list of warehouse location to combo
    'Private Sub LoadWarehouseLocation()
    '    Dim dsLocation As DataSet
    '
    '    With New BusinessRules.BusRules.InventoryBusLogic
    '        .WH_ID = WH_ID
    '        .WHA_ID = WHA_ID
    '        dsLocation = .GetWarehouseLocation
    '        If Not dsLocation Is Nothing Then
    '            Try
    '                lookupLocation.Properties.LookUpData.ListFields.Clear()
    '                AddListFieldInfoToLookUp(lookupLocation, "Row", 200, 0, "")
    '                AddListFieldInfoToLookUp(lookupLocation, "Col", 200, 0, "")
    '                AddListFieldInfoToLookUp(lookupLocation, "Height", 200, 0, "")
    '                lookupLocation.Properties.LookUpData.KeyField = "Location_ID"
    '                lookupLocation.Properties.LookUpData.DisplayField = "Row"
    '                lookupLocation.Properties.LookUpData.DataSource = dsLocation.Tables(0)
    '            Catch exLoad As System.Exception
    '                System.Windows.Forms.MessageBox.Show(exLoad.Message)
    '            End Try
    '        End If
    '    End With
    'End Sub

    Private Sub ObtainLocation()
        Dim dsLocation As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = WH_ID
            .WHA_ID = WHA_ID
            dsLocation = .GetWarehouseLocation
            If Not dsLocation Is Nothing Then
                If dsLocation.Tables(0).Rows.Count > 0 Then
                    Location_ID = CInt(dsLocation.Tables(0).Rows(0).Item("Location_ID"))
                Else
                    Location_ID = 0
                End If
            Else
                Location_ID = 0
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

#Region " Combo Actions"
    Private Sub lookupWarehouse_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupWarehouse.CloseUp
        'WHA_ID = 0
        'Location_ID = 0
        WH_ID = lookupWarehouse.Properties.LookUpData.KeyValue
        LoadWarehouseArea()
    End Sub

    Private Sub lookupArea_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupArea.CloseUp
        'Location_ID = 0
        WHA_ID = lookupArea.Properties.LookUpData.KeyValue
        'txtLocation.Text = ""
        ObtainLocation()
        'LoadWarehouseLocation()
    End Sub

    'Private Sub lookupLocation_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupLocation.CloseUp
    '    Dim ds As DataSet
    '
    '    Location_ID = lookupLocation.Properties.LookUpData.KeyValue
    '    With New BusinessRules.BusRules.InventoryBusLogic
    '        .Location_ID = Location_ID
    '        ds = .GetRowColHeight
    '        If Not ds Is Nothing Then
    '            txtLocation.Text = ds.Tables(0).Rows(0).Item("Row") & ", " & ds.Tables(0).Rows(0).Item("Col") & ", " & ds.Tables(0).Rows(0).Item("Row")
    '            txtLocation.Visible = True
    '        Else
    '            txtLocation.Text = ""
    '        End If
    '    End With
    'End Sub
#End Region

#Region " Functions for Form Fields"
    'Set All Fields to Default Values
    Private Sub ClearFields()
        txtRefNO.Text = ""
        txtProductNm.Text = ""
        txtDescription.Text = ""
        txtUOM.Text = ""
        txtStockInQty.Text = 0
    End Sub

    'Disable Non-Editable Fields
    Private Sub DisableFields()
        txtRefNO.Enabled = False
        txtCategoryNm.Enabled = False
        txtProductNm.Enabled = False
        txtDescription.Enabled = False
        txtStockInDt.Enabled = False
        txtUOM.Enabled = False
        txtStockInQty.Enabled = False
        txtLocation.Visible = False
        lookupSupplier.Enabled = False
        lookupWarehouse.Enabled = False
        lookupArea.Enabled = False
        StockInBtn.Enabled = False
    End Sub
#End Region

    Private Sub ProductList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
        ProductList_Click(sender, e)
    End Sub
    Private Sub StockInLooseForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit stock in screen?", "Stock In", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            'Me.Close()
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
