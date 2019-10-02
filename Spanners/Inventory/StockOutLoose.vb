Public Class StockOutLooseForm
    Inherits System.Windows.Forms.Form

#Region " Declare Public Variables"
    Public UserID As String = Common.CommonConn.Config.USERID

    Public WO_No As String
    Public Order_Type As String
    Public Order_NO As String
    Public Remarks As String

    Public data As System.Data.DataTable
    Public EmptyList As Boolean = True

    Public Supplier_ID As Integer = 0
    Public WO_ID As Integer = 0
    Public Stock_ID As Integer = 0
    Public WH_ID As Integer = 0
    Public WHA_ID As Integer = 0
    Public Location_ID As Integer = 0

    Public Category_ID As Integer = 0
    Public UOM_ID As Integer = 0
    Public Product_ID As Integer = 0
    Public InStoreQty As Integer
    Public StockOutQty As Integer
    Public Transaction_Type As String = "Stock Out"
    Public StockOutType As String = "Loose Item"
	Public SRV_ID As Integer = 0
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
    Friend WithEvents lblProductList As System.Windows.Forms.Label
    Friend WithEvents lblCategoryList As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWarehouse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtColumn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtStockOutDt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStockOutDt As System.Windows.Forms.Label
    Friend WithEvents txtstockqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtProductNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCategoryNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStockOutQty As System.Windows.Forms.Label
    Friend WithEvents lblProductNm As System.Windows.Forms.Label
    Friend WithEvents lblCategoryNm As System.Windows.Forms.Label
    Friend WithEvents txtUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents grdItem As DevExpress.XtraGrid.GridControl
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents StockOutBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents lblRefNO As System.Windows.Forms.Label
    Friend WithEvents lookupWOH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents refno_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ReqByLookup As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.StockOutBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.lblProductList = New System.Windows.Forms.Label
        Me.lblCategoryList = New System.Windows.Forms.Label
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.CategoryTree = New System.Windows.Forms.TreeView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.refno_TextBox = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SearchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblRefNO = New System.Windows.Forms.Label
        Me.lookupWOH = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit
        Me.lblSupplier = New System.Windows.Forms.Label
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtUOM = New DevExpress.XtraEditors.TextEdit
        Me.lblUOM = New System.Windows.Forms.Label
        Me.txtArea = New DevExpress.XtraEditors.TextEdit
        Me.txtWarehouse = New DevExpress.XtraEditors.TextEdit
        Me.txtHeight = New DevExpress.XtraEditors.TextEdit
        Me.txtColumn = New DevExpress.XtraEditors.TextEdit
        Me.txtRow = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblWarehouse = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtStockOutDt = New DevExpress.XtraEditors.TextEdit
        Me.lblStockOutDt = New System.Windows.Forms.Label
        Me.txtstockqty = New DevExpress.XtraEditors.TextEdit
        Me.grdItem = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtProductNm = New DevExpress.XtraEditors.TextEdit
        Me.txtCategoryNm = New DevExpress.XtraEditors.TextEdit
        Me.lblStockOutQty = New System.Windows.Forms.Label
        Me.lblProductNm = New System.Windows.Forms.Label
        Me.lblCategoryNm = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.ReqByLookup = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupWOH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockOutDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstockqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(712, 480)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(70, 30)
        Me.CloseBtn.TabIndex = 60
        Me.CloseBtn.Text = "Close"
        '
        'StockOutBtn
        '
        Me.StockOutBtn.AutoSize = False
        Me.StockOutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockOutBtn.Image = Nothing
        Me.StockOutBtn.Location = New System.Drawing.Point(632, 480)
        Me.StockOutBtn.Name = "StockOutBtn"
        Me.StockOutBtn.Size = New System.Drawing.Size(70, 30)
        Me.StockOutBtn.TabIndex = 59
        Me.StockOutBtn.Text = "Stock Out"
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
        'lblProductList
        '
        Me.lblProductList.Location = New System.Drawing.Point(8, 240)
        Me.lblProductList.Name = "lblProductList"
        Me.lblProductList.Size = New System.Drawing.Size(100, 16)
        Me.lblProductList.TabIndex = 55
        Me.lblProductList.Text = "Product List"
        '
        'lblCategoryList
        '
        Me.lblCategoryList.Location = New System.Drawing.Point(8, 8)
        Me.lblCategoryList.Name = "lblCategoryList"
        Me.lblCategoryList.Size = New System.Drawing.Size(100, 16)
        Me.lblCategoryList.TabIndex = 54
        Me.lblCategoryList.Text = "Category List"
        '
        'ProductList
        '
        Me.ProductList.Location = New System.Drawing.Point(8, 256)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(176, 251)
        Me.ProductList.TabIndex = 53
        '
        'CategoryTree
        '
        Me.CategoryTree.ImageIndex = -1
        Me.CategoryTree.Location = New System.Drawing.Point(8, 24)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.SelectedImageIndex = -1
        Me.CategoryTree.Size = New System.Drawing.Size(176, 208)
        Me.CategoryTree.TabIndex = 52
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(192, 517)
        Me.Splitter1.TabIndex = 51
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReqByLookup)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MemoEdit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.refno_TextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lblRefNO)
        Me.GroupBox1.Controls.Add(Me.lookupWOH)
        Me.GroupBox1.Controls.Add(Me.txtSupplier)
        Me.GroupBox1.Controls.Add(Me.lblSupplier)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.txtUOM)
        Me.GroupBox1.Controls.Add(Me.lblUOM)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.txtWarehouse)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.txtColumn)
        Me.GroupBox1.Controls.Add(Me.txtRow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblWarehouse)
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.txtStockOutDt)
        Me.GroupBox1.Controls.Add(Me.lblStockOutDt)
        Me.GroupBox1.Controls.Add(Me.txtstockqty)
        Me.GroupBox1.Controls.Add(Me.grdItem)
        Me.GroupBox1.Controls.Add(Me.txtProductNm)
        Me.GroupBox1.Controls.Add(Me.txtCategoryNm)
        Me.GroupBox1.Controls.Add(Me.lblStockOutQty)
        Me.GroupBox1.Controls.Add(Me.lblProductNm)
        Me.GroupBox1.Controls.Add(Me.lblCategoryNm)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 456)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        '
        'refno_TextBox
        '
        Me.refno_TextBox.Location = New System.Drawing.Point(272, 240)
        Me.refno_TextBox.Name = "refno_TextBox"
        Me.refno_TextBox.Size = New System.Drawing.Size(168, 20)
        Me.refno_TextBox.TabIndex = 182
        Me.refno_TextBox.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SearchBtn)
        Me.GroupBox3.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 168)
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
        Me.ProductSearchTxt.Location = New System.Drawing.Point(88, 28)
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
        'lblRefNO
        '
        Me.lblRefNO.BackColor = System.Drawing.SystemColors.Control
        Me.lblRefNO.Location = New System.Drawing.Point(216, 240)
        Me.lblRefNO.Name = "lblRefNO"
        Me.lblRefNO.Size = New System.Drawing.Size(52, 16)
        Me.lblRefNO.TabIndex = 110
        Me.lblRefNO.Text = "Ref NO :"
        '
        'lookupWOH
        '
        Me.lookupWOH.Location = New System.Drawing.Point(272, 240)
        Me.lookupWOH.Name = "lookupWOH"
        Me.lookupWOH.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupWOH.Properties.NullString = ""
        Me.lookupWOH.Properties.PopupWidth = 200
        Me.lookupWOH.Size = New System.Drawing.Size(144, 21)
        Me.lookupWOH.TabIndex = 109
        Me.lookupWOH.Visible = False
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(96, 312)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtSupplier.Size = New System.Drawing.Size(280, 21)
        Me.txtSupplier.TabIndex = 108
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(48, 312)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(56, 16)
        Me.lblSupplier.TabIndex = 107
        Me.lblSupplier.Text = "Supplier :"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 288)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtDescription.Size = New System.Drawing.Size(456, 21)
        Me.txtDescription.TabIndex = 106
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(32, 288)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(72, 16)
        Me.lblDescription.TabIndex = 105
        Me.lblDescription.Text = "Description :"
        '
        'txtUOM
        '
        Me.txtUOM.Location = New System.Drawing.Point(472, 264)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtUOM.Size = New System.Drawing.Size(80, 21)
        Me.txtUOM.TabIndex = 104
        '
        'lblUOM
        '
        Me.lblUOM.Location = New System.Drawing.Point(432, 264)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(40, 16)
        Me.lblUOM.TabIndex = 103
        Me.lblUOM.Text = "UOM :"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(240, 336)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtArea.Size = New System.Drawing.Size(104, 21)
        Me.txtArea.TabIndex = 102
        '
        'txtWarehouse
        '
        Me.txtWarehouse.Location = New System.Drawing.Point(96, 336)
        Me.txtWarehouse.Name = "txtWarehouse"
        Me.txtWarehouse.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtWarehouse.Size = New System.Drawing.Size(104, 21)
        Me.txtWarehouse.TabIndex = 101
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(504, 200)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(32, 21)
        Me.txtHeight.TabIndex = 100
        Me.txtHeight.Visible = False
        '
        'txtColumn
        '
        Me.txtColumn.Location = New System.Drawing.Point(464, 200)
        Me.txtColumn.Name = "txtColumn"
        Me.txtColumn.Size = New System.Drawing.Size(32, 21)
        Me.txtColumn.TabIndex = 99
        Me.txtColumn.Visible = False
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(424, 200)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(32, 21)
        Me.txtRow.TabIndex = 98
        Me.txtRow.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(504, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Height"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(464, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Col"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(424, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Row"
        Me.Label1.Visible = False
        '
        'lblWarehouse
        '
        Me.lblWarehouse.Location = New System.Drawing.Point(24, 336)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(72, 16)
        Me.lblWarehouse.TabIndex = 93
        Me.lblWarehouse.Text = "Warehouse :"
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(208, 336)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 94
        Me.lblArea.Text = "Area :"
        '
        'txtStockOutDt
        '
        Me.txtStockOutDt.Location = New System.Drawing.Point(96, 240)
        Me.txtStockOutDt.Name = "txtStockOutDt"
        Me.txtStockOutDt.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtStockOutDt.Size = New System.Drawing.Size(104, 21)
        Me.txtStockOutDt.TabIndex = 92
        '
        'lblStockOutDt
        '
        Me.lblStockOutDt.Location = New System.Drawing.Point(8, 240)
        Me.lblStockOutDt.Name = "lblStockOutDt"
        Me.lblStockOutDt.Size = New System.Drawing.Size(88, 16)
        Me.lblStockOutDt.TabIndex = 91
        Me.lblStockOutDt.Text = "Stock Out Date :"
        '
        'txtstockqty
        '
        Me.txtstockqty.Location = New System.Drawing.Point(472, 312)
        Me.txtstockqty.Name = "txtstockqty"
        Me.txtstockqty.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtstockqty.Size = New System.Drawing.Size(80, 21)
        Me.txtstockqty.TabIndex = 87
        '
        'grdItem
        '
        Me.grdItem.EditorsRepository = Me.PersistentRepository1
        Me.grdItem.Location = New System.Drawing.Point(8, 14)
        Me.grdItem.MainView = Me.GridView1
        Me.grdItem.Name = "grdItem"
        Me.grdItem.Size = New System.Drawing.Size(568, 146)
        Me.grdItem.TabIndex = 90
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        '
        'txtProductNm
        '
        Me.txtProductNm.Location = New System.Drawing.Point(272, 264)
        Me.txtProductNm.Name = "txtProductNm"
        Me.txtProductNm.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtProductNm.Size = New System.Drawing.Size(144, 21)
        Me.txtProductNm.TabIndex = 85
        '
        'txtCategoryNm
        '
        Me.txtCategoryNm.Location = New System.Drawing.Point(96, 264)
        Me.txtCategoryNm.Name = "txtCategoryNm"
        Me.txtCategoryNm.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
            Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
            Or DevExpress.Utils.StyleOptions.UseFont) _
            Or DevExpress.Utils.StyleOptions.UseForeColor) _
            Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
            Or DevExpress.Utils.StyleOptions.UseImage) _
            Or DevExpress.Utils.StyleOptions.UseWordWrap) _
            Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
        Me.txtCategoryNm.Size = New System.Drawing.Size(104, 21)
        Me.txtCategoryNm.TabIndex = 84
        '
        'lblStockOutQty
        '
        Me.lblStockOutQty.Location = New System.Drawing.Point(392, 312)
        Me.lblStockOutQty.Name = "lblStockOutQty"
        Me.lblStockOutQty.Size = New System.Drawing.Size(88, 16)
        Me.lblStockOutQty.TabIndex = 82
        Me.lblStockOutQty.Text = "Stock Out Qty :"
        '
        'lblProductNm
        '
        Me.lblProductNm.Location = New System.Drawing.Point(216, 264)
        Me.lblProductNm.Name = "lblProductNm"
        Me.lblProductNm.Size = New System.Drawing.Size(56, 16)
        Me.lblProductNm.TabIndex = 80
        Me.lblProductNm.Text = "Product :"
        '
        'lblCategoryNm
        '
        Me.lblCategoryNm.Location = New System.Drawing.Point(40, 264)
        Me.lblCategoryNm.Name = "lblCategoryNm"
        Me.lblCategoryNm.Size = New System.Drawing.Size(64, 16)
        Me.lblCategoryNm.TabIndex = 79
        Me.lblCategoryNm.Text = "Category  :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "Remarks :"
        '
        'MemoEdit
        '
        Me.MemoEdit.Location = New System.Drawing.Point(96, 368)
        Me.MemoEdit.Name = "MemoEdit"
        Me.MemoEdit.Size = New System.Drawing.Size(456, 72)
        Me.MemoEdit.TabIndex = 184
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(360, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "Requestor:"
        '
        'ReqByLookup
        '
        Me.ReqByLookup.Location = New System.Drawing.Point(440, 340)
        Me.ReqByLookup.Name = "ReqByLookup"
        Me.ReqByLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ReqByLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ReqByLookup.Properties.NullString = ""
        Me.ReqByLookup.Size = New System.Drawing.Size(112, 19)
        Me.ReqByLookup.TabIndex = 186
        '
        'StockOutLooseForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 517)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.StockOutBtn)
        Me.Controls.Add(Me.lblProductList)
        Me.Controls.Add(Me.lblCategoryList)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "StockOutLooseForm"
        Me.Text = "Stock Out (Loose Item)"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupWOH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockOutDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstockqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load"
    Private Sub StockOutLooseForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        DisableFields()
        txtStockOutDt.Text = Date.Today
        LoadCategoryList()
        LoadWOH()
        InitalUserCombo()
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region " Functions for Form Fields"
    'Set All Fields to Default Values
    Private Sub ClearFields()
        txtProductNm.Text = ""
        txtUOM.Text = ""
        txtDescription.Text = ""
        txtSupplier.Text = ""
        txtstockqty.Text = ""
        'txtCategoryNm.Text = ""
        txtWarehouse.Text = ""
        txtArea.Text = ""
        txtRow.Text = ""
        txtColumn.Text = ""
        txtHeight.Text = ""
        Me.MemoEdit.Text = ""
    End Sub

    Private Sub DisableFields()
        txtStockOutDt.Enabled = False
        'txtCategoryNm.Enabled = False
        txtCategoryNm.Properties.ReadOnly = True
        'txtProductNm.Enabled = False
        txtProductNm.Properties.ReadOnly = True
        'txtUOM.Enabled = False
        txtUOM.Properties.ReadOnly = True
        'txtDescription.Enabled = False
        txtDescription.Properties.ReadOnly = True
        'txtSupplier.Enabled = False
        txtSupplier.Properties.ReadOnly = True
        'txtWarehouse.Enabled = False
        txtWarehouse.Properties.ReadOnly = True
        'txtArea.Enabled = False
        txtArea.Properties.ReadOnly = True
        'txtRow.Enabled = False
        txtRow.Properties.ReadOnly = True
        'txtColumn.Enabled = False
        txtColumn.Properties.ReadOnly = True
        'txtHeight.Enabled = False
        txtHeight.Properties.ReadOnly = True

        txtstockqty.Enabled = False
        Me.ReqByLookup.Enabled = False
        Me.MemoEdit.Enabled = False
        lookupWOH.Enabled = False
        StockOutBtn.Enabled = False
    End Sub
#End Region

#Region " Load Work Order Header Combo and Action Functions"
    'Load list of Work Order Header to combo
    Private Sub LoadWOH()
        Dim dsWOH As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            dsWOH = .GetWOHeader
            If Not dsWOH Is Nothing Then
                Try
                    lookupWOH.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(lookupWOH, "WO_No", 200, 0, "")
                    lookupWOH.Properties.LookUpData.KeyField = "WO_ID"
                    lookupWOH.Properties.LookUpData.DisplayField = "WO_No"
                    lookupWOH.Properties.LookUpData.DataSource = dsWOH.Tables(0)
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub lookupWOH_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupWOH.CloseUp
        WO_ID = CInt(lookupWOH.Properties.LookUpData.KeyValue)
        WO_No = lookupWOH.Text
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

#Region " Load Category Tree List"
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

        grdItem.DataSource = Nothing
        GridView1.Columns.Clear()

        If CurrentTag <> Nothing Then
            txtCategoryNm.Text = CurrentText
            Category_ID = CurrentTag
            RefreshProductList(Category_ID)
        Else
            txtCategoryNm.Text = ""
        End If
        StockOutBtn.Enabled = False
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

                        'Check if there is list of product
                        If ds.Tables(0).Rows.Count > 0 Then
                            EmptyList = False
                        Else
                            EmptyList = True
                        End If
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
    End Sub

    Private Sub ProductList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.Click
        'LoadProductList()
    End Sub

    Private Sub LoadProductList()
        'Dim UOM_ID As Integer
        Dim dsUOM As DataSet
        Dim dsSupplier As DataSet

        If Category_ID = 0 Then
            'Exit Sub
        End If

        If Not EmptyList Then
            ClearFields()
            Product_ID = CInt(ProductList.SelectedItem("Product_ID"))
            'Supplier_ID = CInt(ProductList.SelectedItem("Supplier_ID"))
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

                '.Supplier_ID = Supplier_ID
                '.Transaction_Type = Transaction_Type
                'dsSupplier = .GetSupplier
                'If Not dsSupplier Is Nothing Then
                'Try
                'If dsSupplier.Tables(0).Rows.Count > 0 Then
                'txtSupplier.Text = dsSupplier.Tables(0).Rows(0).Item("Supplier_Name")
                'Else
                '    txtSupplier.Text = ""
                'End If
                'Catch exLoad As Exception
                'System.Windows.Forms.MessageBox.Show(exLoad.Message)
                'End Try
                'End If
            End With
            StockOutBtn.Enabled = False
            PopulateGrid()
        End If
    End Sub
    'Private Sub ProductList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
    '    Dim UOM_ID As Integer
    '
    '       txtProductNm.Text = ProductList.SelectedItem("Name")
    '      txtDescription.Text = ProductList.SelectedItem("Description")
    '     UOM_ID = ProductList.SelectedItem("UOM_ID")
    '
    '       With New BusinessRules.ManUOMBusRules.ManUOMBusLogic
    '          If .Load(UOM_ID) Then
    '             txtUOM.Text = .Name()
    '        End If
    '    End With
    'End Sub
#End Region

#Region " Component Grid Function "
    Public Sub PopulateGrid()
        Dim ds As DataSet

        grdItem.DataSource = Nothing

        'AccessCount = AccessCount + 1
        With New BusinessRules.BusRules.InventoryBusLogic
            .Product_ID = Product_ID
            ds = .GetStock()

            If Not ds Is Nothing Then
                InitGrid()

                Dim oRow As DataRow
                Dim i As Integer = 0
                'Dim CompTotal As Double

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {i, oRow("Stock_ID"), oRow("Category_ID"), oRow("Product_ID"), oRow("Supplier_ID"), oRow("Warehouse_ID"), oRow("Warehouse_Area_ID"), oRow("Category"), oRow("Product"), oRow("Description"), oRow("Supplier_Name"), oRow("UOM"), oRow("Qty"), oRow("Warehouse"), oRow("Warehouse_Area"), oRow("Location_ID")})
                Next

                grdItem.DataSource = data
                grdItem.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide StockID column
                GridView1.Columns.Item(2).VisibleIndex = -1 'hide CategoryID column
                GridView1.Columns.Item(3).VisibleIndex = -1 'hide ProductID column
                GridView1.Columns.Item(4).VisibleIndex = -1 'hide SupplierID column
                GridView1.Columns.Item(5).VisibleIndex = -1 'hide WarehouseID column
                GridView1.Columns.Item(6).VisibleIndex = -1 'hide AreaID column
                'GridView1.Columns.Item(10).VisibleIndex = -1 'hide Qty column
                GridView1.Columns.Item(13).VisibleIndex = -1 'hide Warehouse column
                GridView1.Columns.Item(14).VisibleIndex = -1 'hide Area column
                GridView1.Columns.Item(15).VisibleIndex = -1 'hide LocationID column
                'GridView1.Columns.Item(15).VisibleIndex = -1 'hide Row column
                'GridView1.Columns.Item(16).VisibleIndex = -1 'hide Col column
                'GridView1.Columns.Item(17).VisibleIndex = -1 'hide Height column
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
        AddColumn(data, "Category ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Product ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Supplier ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Warehouse ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Area ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Category Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Product Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Supplier", System.Type.GetType("System.String"), True)
        AddColumn(data, "Unit", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Warehouse", System.Type.GetType("System.String"), True)
        AddColumn(data, "Area", System.Type.GetType("System.String"), True)
        AddColumn(data, "Location ID", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Row", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Col", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Height", System.Type.GetType("System.Int16"), True)

        'AddColumn(data, "Confirm Qty", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Stock In Qty", System.Type.GetType("System.Int16"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Sub grdItem_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdItem.MouseUp
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
                    'ComponentContextMenu.Show(sender, mouseDownLocation)
                Case MouseButtons.None
                    eventString = Nothing
            End Select
        End If
    End Sub

    Private Sub PopulateToForm(ByVal drow As DataRow)
        txtCategoryNm.Text = drow.Item("Category Name")
        txtProductNm.Text = drow.Item("Product Name")
        txtDescription.Text = drow.Item("Description")
        txtSupplier.Text = drow.Item("Supplier")
        txtUOM.Text = drow.Item("Unit")
        txtstockqty.Text = 0
        Stock_ID = CInt(drow.Item("Stock ID"))
        Category_ID = CInt(drow.Item("Category ID"))
        Product_ID = CInt(drow.Item("Product ID"))
        Supplier_ID = CInt(drow.Item("Supplier ID"))
        WH_ID = CInt(drow.Item("Warehouse ID"))
        WHA_ID = CInt(drow.Item("Area ID"))
        Location_ID = CInt(drow.Item("Location ID"))
        InStoreQty = CInt(drow.Item("Qty"))
        txtWarehouse.Text = drow.Item("Warehouse")
        txtArea.Text = drow.Item("Area")
        'txtRow.Text = drow.Item("Row")
        'txtColumn.Text = drow.Item("Col")
        'txtHeight.Text = drow.Item("Height")
        lookupWOH.Enabled = True
        txtstockqty.Enabled = True
        Me.ReqByLookup.Enabled = True
        Me.MemoEdit.Enabled = True
        StockOutBtn.Enabled = True
    End Sub
#End Region

#Region " Save Transaction"
    Private Function SaveDataProcess() As Boolean
        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Stock_Out_Type = StockOutType
            .In_Store_Qty = InStoreQty
            .StockOutQty = StockOutQty

            If Not .ValidQty Then
                MessageBox.Show("Stock out quantity cannot be < 0 or = 0 or > in store quantity !", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SaveDataProcess = False
                Exit Function
            End If

            .WO_ID = WO_ID
            .UserID = UserID
            .Stock_ID = Stock_ID
            .Category_ID = Category_ID
            .Product_ID = Product_ID
            .WH_ID = WH_ID
            .WHA_ID = WHA_ID
            '.Location_ID = Location_ID

            If Not .EmptyWorkOrder Then
                Order_Type = "WO"
                Order_NO = WO_No
                .Order_Type = Order_Type
                .Order_NO = Order_NO
            End If

            Order_NO = refno_TextBox.Text
            .WO_ID = 1
            .Order_Type = "WO"
            .Order_NO = Order_NO
            .RequestedBy = ReqByLookup.Properties.LookUpData.KeyValue
            .SRV_ID = SRV_ID
            .Remarks = Me.MemoEdit.Text

            If .UpdateSelectedStock Then
                If .SaveStockTransaction Then
                    MessageBox.Show("Stock out successfully. ", "Stock Out (Loose Item)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If SRV_ID <> 0 Then
                        Me.Close()
                    End If
                    SaveDataProcess = True
                Else
                    MessageBox.Show("Encounter error while stocking out ! ", "Stock Out (Loose Item)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveDataProcess = False
                    Exit Function
                End If
            Else
                MessageBox.Show("Encounter error while stocking out ! ", "Stock Out (Loose Item)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SaveDataProcess = False
                Exit Function
            End If
        End With
    End Function
#End Region

#Region " Codes for Buttons"
    Private Sub StockOutBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StockOutBtn.Click
        StockOutQty = CInt(txtstockqty.Text)
        SaveDataProcess()
        ClearFields()
        DisableFields()
        PopulateGrid()
        StockOutBtn.Enabled = False
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

                        'Check if there is list of product
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
#End Region


    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow = GridView1.GetDataRow(Row)
                PopulateToForm(dr)
            End If
        End If
    End Sub

    Private Sub ProductList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
        'ProductList_Click(sender, e)
        LoadProductList()
    End Sub
    Private Sub StockOutLooseForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If SRV_ID = 0 Then
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit stock out screen?", "Stock In", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
        End If

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

End Class
