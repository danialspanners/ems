Imports DevExpress.XtraEditors.Controls

Public Class SelectProductForm
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
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents UnitPriceTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PurchasePriceChk As System.Windows.Forms.RadioButton
    Friend WithEvents CatalogPriceChk As System.Windows.Forms.RadioButton
    Friend WithEvents EnquiryPriceChk As System.Windows.Forms.RadioButton
    Friend WithEvents EnquiryPriceTxt As System.Windows.Forms.Label
    Friend WithEvents PurchasePriceTxt As System.Windows.Forms.Label
    Friend WithEvents CatalogPriceTxt As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SupLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SupplierRd2 As System.Windows.Forms.RadioButton
    Friend WithEvents SupplierRd1 As System.Windows.Forms.RadioButton
    Friend WithEvents Transact_DateTxt As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label28 = New System.Windows.Forms.Label
        Me.CategoryTree = New System.Windows.Forms.TreeView
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.UnitPriceTxt = New DevExpress.XtraEditors.SpinEdit
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Transact_DateTxt = New System.Windows.Forms.Label
        Me.PurchasePriceChk = New System.Windows.Forms.RadioButton
        Me.CatalogPriceChk = New System.Windows.Forms.RadioButton
        Me.EnquiryPriceChk = New System.Windows.Forms.RadioButton
        Me.EnquiryPriceTxt = New System.Windows.Forms.Label
        Me.PurchasePriceTxt = New System.Windows.Forms.Label
        Me.CatalogPriceTxt = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SupLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.SupplierRd2 = New System.Windows.Forms.RadioButton
        Me.SupplierRd1 = New System.Windows.Forms.RadioButton
        Me.lblDescription = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
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
        CType(Me.UnitPriceTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SupLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(8, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Category List"
        '
        'CategoryTree
        '
        Me.CategoryTree.ImageIndex = -1
        Me.CategoryTree.Location = New System.Drawing.Point(8, 32)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.SelectedImageIndex = -1
        Me.CategoryTree.Size = New System.Drawing.Size(160, 416)
        Me.CategoryTree.TabIndex = 38
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(184, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Product List"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(296, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Qty :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(184, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Unit Price :"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(176, 471)
        Me.Splitter1.TabIndex = 34
        Me.Splitter1.TabStop = False
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(376, 416)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(72, 32)
        Me.SelectBtn.TabIndex = 48
        Me.SelectBtn.Text = "Add"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(456, 416)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 50
        Me.CloseBtn.Text = "&Close"
        '
        'ProductList
        '
        Me.ProductList.DisplayMember = "Name"
        Me.ProductList.HorizontalExtent = 50
        Me.ProductList.HorizontalScrollbar = True
        Me.ProductList.Location = New System.Drawing.Point(184, 88)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(496, 95)
        Me.ProductList.TabIndex = 56
        Me.ProductList.ValueMember = "Product_Id"
        '
        'UnitPriceTxt
        '
        Me.UnitPriceTxt.Enabled = False
        Me.UnitPriceTxt.Location = New System.Drawing.Point(184, 426)
        Me.UnitPriceTxt.Name = "UnitPriceTxt"
        Me.UnitPriceTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.UnitPriceTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UnitPriceTxt.Size = New System.Drawing.Size(104, 19)
        Me.UnitPriceTxt.TabIndex = 64
        Me.UnitPriceTxt.Text = "0"
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(296, 426)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(72, 19)
        Me.QtyTxt.TabIndex = 65
        Me.QtyTxt.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Transact_DateTxt)
        Me.GroupBox1.Controls.Add(Me.PurchasePriceChk)
        Me.GroupBox1.Controls.Add(Me.CatalogPriceChk)
        Me.GroupBox1.Controls.Add(Me.EnquiryPriceChk)
        Me.GroupBox1.Controls.Add(Me.EnquiryPriceTxt)
        Me.GroupBox1.Controls.Add(Me.PurchasePriceTxt)
        Me.GroupBox1.Controls.Add(Me.CatalogPriceTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 80)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Pricing"
        '
        'Transact_DateTxt
        '
        Me.Transact_DateTxt.Location = New System.Drawing.Point(216, 24)
        Me.Transact_DateTxt.Name = "Transact_DateTxt"
        Me.Transact_DateTxt.Size = New System.Drawing.Size(120, 16)
        Me.Transact_DateTxt.TabIndex = 78
        '
        'PurchasePriceChk
        '
        Me.PurchasePriceChk.Location = New System.Drawing.Point(16, 56)
        Me.PurchasePriceChk.Name = "PurchasePriceChk"
        Me.PurchasePriceChk.Size = New System.Drawing.Size(16, 16)
        Me.PurchasePriceChk.TabIndex = 77
        '
        'CatalogPriceChk
        '
        Me.CatalogPriceChk.Location = New System.Drawing.Point(16, 40)
        Me.CatalogPriceChk.Name = "CatalogPriceChk"
        Me.CatalogPriceChk.Size = New System.Drawing.Size(16, 16)
        Me.CatalogPriceChk.TabIndex = 76
        '
        'EnquiryPriceChk
        '
        Me.EnquiryPriceChk.Checked = True
        Me.EnquiryPriceChk.Location = New System.Drawing.Point(16, 24)
        Me.EnquiryPriceChk.Name = "EnquiryPriceChk"
        Me.EnquiryPriceChk.Size = New System.Drawing.Size(16, 16)
        Me.EnquiryPriceChk.TabIndex = 75
        Me.EnquiryPriceChk.TabStop = True
        '
        'EnquiryPriceTxt
        '
        Me.EnquiryPriceTxt.Location = New System.Drawing.Point(40, 24)
        Me.EnquiryPriceTxt.Name = "EnquiryPriceTxt"
        Me.EnquiryPriceTxt.Size = New System.Drawing.Size(152, 16)
        Me.EnquiryPriceTxt.TabIndex = 73
        '
        'PurchasePriceTxt
        '
        Me.PurchasePriceTxt.Location = New System.Drawing.Point(40, 56)
        Me.PurchasePriceTxt.Name = "PurchasePriceTxt"
        Me.PurchasePriceTxt.Size = New System.Drawing.Size(152, 16)
        Me.PurchasePriceTxt.TabIndex = 72
        '
        'CatalogPriceTxt
        '
        Me.CatalogPriceTxt.Location = New System.Drawing.Point(40, 40)
        Me.CatalogPriceTxt.Name = "CatalogPriceTxt"
        Me.CatalogPriceTxt.Size = New System.Drawing.Size(144, 16)
        Me.CatalogPriceTxt.TabIndex = 71
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SupLookup)
        Me.GroupBox2.Controls.Add(Me.SupplierRd2)
        Me.GroupBox2.Controls.Add(Me.SupplierRd1)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 90)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Supplier"
        '
        'SupLookup
        '
        Me.SupLookup.Enabled = False
        Me.SupLookup.Location = New System.Drawing.Point(32, 64)
        Me.SupLookup.Name = "SupLookup"
        Me.SupLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SupLookup.Properties.Enabled = False
        Me.SupLookup.Properties.NullString = ""
        Me.SupLookup.Properties.PopupWidth = 304
        Me.SupLookup.Size = New System.Drawing.Size(304, 19)
        Me.SupLookup.TabIndex = 69
        '
        'SupplierRd2
        '
        Me.SupplierRd2.Location = New System.Drawing.Point(16, 40)
        Me.SupplierRd2.Name = "SupplierRd2"
        Me.SupplierRd2.Size = New System.Drawing.Size(176, 24)
        Me.SupplierRd2.TabIndex = 68
        Me.SupplierRd2.Text = "Select from existing Supplier"
        '
        'SupplierRd1
        '
        Me.SupplierRd1.Checked = True
        Me.SupplierRd1.Location = New System.Drawing.Point(16, 16)
        Me.SupplierRd1.Name = "SupplierRd1"
        Me.SupplierRd1.Size = New System.Drawing.Size(312, 24)
        Me.SupplierRd1.TabIndex = 67
        Me.SupplierRd1.TabStop = True
        Me.SupplierRd1.Text = "Default Supplier"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(184, 192)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(344, 32)
        Me.lblDescription.TabIndex = 72
        '
        'GroupBox3
        '
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
        Me.GroupBox3.Location = New System.Drawing.Point(184, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 64)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Search"
        '
        'ModelSearch
        '
        Me.ModelSearch.Location = New System.Drawing.Point(256, 40)
        Me.ModelSearch.Name = "ModelSearch"
        Me.ModelSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ModelSearch.Size = New System.Drawing.Size(184, 19)
        Me.ModelSearch.TabIndex = 87
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(216, 35)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 86
        Me.Label36.Text = "Model:"
        '
        'DescSearch2
        '
        Me.DescSearch2.Location = New System.Drawing.Point(360, 16)
        Me.DescSearch2.Name = "DescSearch2"
        Me.DescSearch2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch2.Size = New System.Drawing.Size(80, 19)
        Me.DescSearch2.TabIndex = 85
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(328, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 16)
        Me.Label35.TabIndex = 84
        Me.Label35.Text = "and"
        '
        'DescSearch
        '
        Me.DescSearch.Location = New System.Drawing.Point(256, 16)
        Me.DescSearch.Name = "DescSearch"
        Me.DescSearch.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.DescSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch.Size = New System.Drawing.Size(72, 17)
        Me.DescSearch.TabIndex = 83
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(216, 16)
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
        Me.BrandSearchTxt.Size = New System.Drawing.Size(72, 19)
        Me.BrandSearchTxt.TabIndex = 75
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
        Me.SearchBtn.AutoSize = False
        Me.SearchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Image = Nothing
        Me.SearchBtn.Location = New System.Drawing.Point(448, 22)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(48, 32)
        Me.SearchBtn.TabIndex = 73
        Me.SearchBtn.Text = "Search"
        '
        'ProductSearchTxt
        '
        Me.ProductSearchTxt.Location = New System.Drawing.Point(136, 18)
        Me.ProductSearchTxt.Name = "ProductSearchTxt"
        Me.ProductSearchTxt.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.ProductSearchTxt.Size = New System.Drawing.Size(72, 17)
        Me.ProductSearchTxt.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Type Product ID/Code :"
        '
        'SelectProductForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(706, 471)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.QtyTxt)
        Me.Controls.Add(Me.UnitPriceTxt)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectProductForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        CType(Me.UnitPriceTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SupLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable "
    Public Component_ID As Integer
    Public Quotation_Line_ID As Integer
    Public Quotation_ID As Integer
    Public Category_ID As Integer
    Public Product_ID As Integer
    Public varName As String
    Public Supplier_ID As Integer
    Public SelectedSupplier_ID As Integer
    Public DefaultSupplier_ID As Integer
    Public Description As String
    Public Qty As Integer
    Public UnitPrice As Decimal
    Public DefaultUnitPrice As Decimal
    Public SelectedUnitPrice As Decimal
    Public Lead_Time As String
    Public Purchase_Price As Decimal
    Public Catalog_Price As Decimal
    Public UserID As String = Common.CommonConn.Config.USERID

    Public Status As String = "EDIT"
#End Region

    Public WO_Line_ID As Integer
    Public WO_ID As Integer
    Public WO_Component_ID As Integer
    Public DefaultPurchase_Price As Decimal
    Public DefaultCatalog_Price As Decimal
    Public SelectedPurchase_Price As Decimal
    Public SelectedCatalog_Price As Decimal
    Public DefaultTransact_Date As String
    Public SelectedTransact_Date As String

#Region " Code - Form load , Category tree list"
    'For Category Portion

    Private Sub SelectProductForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCategoryList()
        Select Case UCase(Status)
            Case "ADDFROMWO", "EDITFROMWO"
                CategoryTree.Select()
                UnitPriceTxt.Visible = False
                'QtyTxt.Visible = False
                Label1.Visible = False
                'Label2.Visible = False
            Case "EDIT"
                Dim ds As DataSet
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    .Component_ID = Component_ID
                    If .GetQuotationLineComp(ds) Then
                        CategoryTree.SelectedNode.Tag = ds.Tables(0).Rows(0)("Category_ID").ToString
                        RefreshProductList(ds.Tables(0).Rows(0)("Category_ID"))
                        LoadSupplierInfo(ds.Tables(0).Rows(0)("Product_ID"))
                        UnitPriceTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("UnitPrice"))
                        QtyTxt.Text = ds.Tables(0).Rows(0)("Qty")
                        SelectBtn.Text = "Update"
                        SupplierRd1.Enabled = False
                        SupplierRd2.Enabled = False
                        ProductList.Enabled = False
                        CategoryTree.Enabled = False
                        'CategoryTree.Select = False
                    End If
                End With
        End Select
    End Sub

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
        CategoryTree.Select()

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

#End Region

#Region " Code - Windows Events (Supplier Lookup, Product ListBox, Category Tree"
    'Event for Category List
    Private Sub CategoryTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles CategoryTree.AfterSelect
        Dim CurrentTag
        Dim CurrentText

        CurrentTag = CategoryTree.SelectedNode.Tag
        CurrentText = CategoryTree.SelectedNode.Text()

        lblDescription.Text = ""

        If CurrentTag <> Nothing Then
            Category_ID = CurrentTag
            RefreshProductList(Category_ID)
        Else
            Category_ID = 0
        End If
    End Sub

    Private Sub RefreshProductList(ByVal pCategoryID As Integer)
        Dim ds As DataSet
        'Load product list
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .LoadList(ds, pCategoryID) Then
                If Not ds Is Nothing Then
                    Try
                        'ProductList.DisplayMember = "Name"
                        'ProductList.ValueMember = "Product_ID"

                        ProductList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub RefreshProductListByProductID(ByVal ProductID As String, ByVal BrandText As String, ByVal Desc As String, ByVal Desc2 As String, ByVal Model As String)
        Dim ds As DataSet
        'Load product list
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .Load(ds, ProductID, BrandText, Desc, Desc2, Model, Category_ID) Then
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
    Private Sub LoadSupplierInfo(ByVal pProductID As String)
        Dim ds As DataSet
        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            If .LoadList(ds, pProductID, "0") Then
                If Not ds Is Nothing Then
                    SupLookup.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SupLookup, "Supplier_Name", 400, 0, "c")
                    AddListFieldInfoToLookUp(SupLookup, "Catalog_Price", 400, 0, "c")
                    AddListFieldInfoToLookUp(SupLookup, "Enquiry_Price", 400, 0, "c")
                    AddListFieldInfoToLookUp(SupLookup, "Purchase_Price", 400, 0, "c")
                    SupLookup.Properties.LookUpData.KeyField = "ProductSupplier_ID"
                    SupLookup.Properties.LookUpData.DisplayField = "Supplier_Name"

                    SupLookup.Properties.LookUpData.DataSource = ds.Tables(0)
                    SupLookup.EditValue = "0"
                End If
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        Dim luColumnInfo = New LookUpColumnInfo(field, width)
        If format = "c" Then
            luColumnInfo.FormatType = LookUpFormatType.Numeric
            luColumnInfo.FormatString = format
        End If
        luColumnInfo.Alignment = CType(alignment, StringAlignment)
        le.Properties.LookUpData.ListFields.Add(luColumnInfo)
    End Sub

    Private Sub SupLookup_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles SupLookup.CloseUp
        Dim ProductSupplier_ID As Integer
        ProductSupplier_ID = e.Value

        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            If .GetSupplierPrice(ProductSupplier_ID) Then
                SelectedUnitPrice = .Enquiry_Price
                SelectedCatalog_Price = .Catalog_Price
                SelectedPurchase_Price = .Purchase_Price

                UnitPrice = SelectedUnitPrice
                SelectedSupplier_ID = .Supplier_ID
                SelectedTransact_Date = Microsoft.VisualBasic.Day(.Transact_Date) & " " & MonthName(Month(.Transact_Date)) & " " & Year(.Transact_Date)
                Transact_DateTxt.Text = SelectedTransact_Date

                If Not IsDBNull(UnitPrice) Then
                    Text = "Enquiry Price : $" & Decimal.Round(UnitPrice, 2)
                    EnquiryPriceTxt.Text = Text
                Else
                    Text = "Enquiry Price : -"
                End If
                If Not IsDBNull(Catalog_Price) Then
                    Text = "Catalog Price : $" & Decimal.Round(SelectedCatalog_Price, 2)
                    CatalogPriceTxt.Text = Text
                Else
                    Text = "Catalog Price : -"
                End If
                If Not IsDBNull(Purchase_Price) Then
                    Text = "Purchase Price : $" & Decimal.Round(SelectedPurchase_Price, 2)
                    PurchasePriceTxt.Text = Text
                Else
                    Text = "Purchase Price : -"
                End If
                UnitPriceTxt.Text = Double.Parse(UnitPrice)
            Else
                UnitPriceTxt.Text = ""
            End If
        End With
    End Sub

    Private Sub ProductList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
        RefreshProductInfo()
    End Sub

    Private Sub RefreshProductInfo()
        Dim text As String
        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            If ProductList.Items.Count > 0 Then
                lblDescription.Text = ""
                lblDescription.Text = ProductList.Items.Item(ProductList.SelectedIndex)("Description").ToString()
                'lblDescription.Text =  'ds.Tables(0).Rows(0)("Descriptin")
                Product_ID = ProductList.SelectedValue.ToString
                .Product_ID = Product_ID
                If .GetSupplierPrice() Then
                    DefaultSupplier_ID = .Supplier_ID

                    DefaultCatalog_Price = .Catalog_Price
                    DefaultPurchase_Price = .Purchase_Price
                    DefaultUnitPrice = .Enquiry_Price
                    DefaultTransact_Date = Microsoft.VisualBasic.Day(.Transact_Date) & " " & MonthName(Month(.Transact_Date)) & " " & Year(.Transact_Date)
                    Transact_DateTxt.Text = DefaultTransact_Date

                    UnitPrice = DefaultUnitPrice
                    SupplierRd1.Text = .Supplier_Name
                    If Not IsDBNull(UnitPrice) Then
                        text = "Enquiry Price : $" & Decimal.Round(UnitPrice, 2)
                        EnquiryPriceTxt.Text = text
                    Else
                        text = "Enquiry Price : -"
                    End If
                    If Not IsDBNull(DefaultCatalog_Price) Then
                        text = "Catalog Price : $" & Decimal.Round(DefaultCatalog_Price, 2)
                        CatalogPriceTxt.Text = text
                    Else
                        text = "Catalog Price : -"
                    End If
                    If Not IsDBNull(DefaultPurchase_Price) Then
                        text = "Purchase Price : $" & Decimal.Round(DefaultPurchase_Price, 2)
                        PurchasePriceTxt.Text = text
                    Else
                        text = "Purchase Price : -"
                    End If
                    UnitPriceTxt.Text = Decimal.Round(UnitPrice, 2)
                Else
                    CatalogPriceTxt.Text = ""
                    PurchasePriceTxt.Text = ""
                    SupplierRd1.Text = ""
                    UnitPriceTxt.Text = ""
                    EnquiryPriceTxt.Text = ""
                End If
                LoadSupplierInfo(Product_ID)
            Else
                SupplierRd1.Text = "Default Supplier "

                text = "Enquiry Price : $0"
                EnquiryPriceTxt.Text = text

                Transact_DateTxt.Text = ""

                text = "Catalog Price : $0"
                CatalogPriceTxt.Text = text

                text = "Purchase Price : $0"
                PurchasePriceTxt.Text = text

                UnitPriceTxt.Text = ""
            End If
        End With
    End Sub

#End Region

#Region " Btn event "
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        If RetrieveFromForm() Then
            Select Case UCase(Status)
                Case "ADD"
                    SaveQuotationLineComponent()
                Case "EDIT"
                    UpdateQuotationLineComponent()
                Case "ADDFROMWO"
                    SaveWOLineComponent()
                Case "EDITFROMWO"
                    UpdateWOComponent()
            End Select
        End If
    End Sub
#End Region

#Region " Database Mgmt "
    Private Sub SaveQuotationLineComponent()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If ValidData() Then

                .Quotation_ID = Quotation_ID
                .Quotation_Line_ID = Quotation_Line_ID
                .Category_ID = Category_ID
                .Product_ID = Product_ID
                .Supplier_ID = Supplier_ID
                .UnitPrice = UnitPrice
                .CompQty = Qty
                .UserID = UserID
                .Lead_Time = Lead_Time

                If Me.Owner.ActiveControl.Name = "QuotationForm" Then
                    Dim qf As QuotationForm
                    qf = Me.Owner.ActiveControl

                    If qf.CheckDuplicateComponents(Product_ID) = False Then
                        If .SaveQuotationLineComponent() Then
                            'Me.Close()
                            qf.RefreshComponentGrid()
                            'qf.UpdateBtn_Click(Me, Nothing)
                        End If
                    End If
                Else
                    Dim qf As OrderConfirmationForm
                    qf = Me.Owner.ActiveControl

                    If qf.CheckDuplicateComponents(Product_ID) = False Then
                        If .SaveQuotationLineComponent() Then
                            'Me.Close()
                            qf.RefreshComponentGrid()
                            'qf.UpdateBtn_Click(Me, Nothing)
                        End If
                    End If
                End If



            End If
        End With
    End Sub

    Private Sub UpdateQuotationLineComponent()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If ValidData() Then
                .Component_ID = Component_ID
                .UnitPrice = UnitPrice
                .CompQty = Qty
                .UserID = UserID

                If .UpdateQuotationLineComponent() Then
                    Me.Close()
                End If
            End If
        End With
    End Sub

    Private Sub SaveWOLineComponent()
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If ValidData() Then
                .WO_ID = WO_ID
                .WO_Line_ID = WO_Line_ID
                .Category_ID = Category_ID
                .Product_ID = Product_ID
                .Supplier_ID = Supplier_ID
                .UnitPrice = UnitPrice
                .CompQty = Qty
                .BalanceQty = Qty
                .UserID = UserID
                .Lead_Time = Lead_Time
                If .SaveWOLineComponent() Then
                    Me.Close()
                End If
            End If
        End With
    End Sub

    Private Sub UpdateWOComponent()
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If ValidData() Then
                .WO_Component_ID = WO_Component_ID
                .UnitPrice = UnitPrice
                .CompQty = Qty
                .UserID = UserID

                If .UpdateWOComponent() Then
                    Me.Close()
                End If
            End If
        End With
    End Sub

    Private Function ValidData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        Qty = QtyTxt.Text
        UnitPrice = Decimal.Parse(UnitPriceTxt.Text)

        If Qty = 0 Then
            DataOK_Flag = False
            FieldName = "Qty" & Chr(13)
        End If

        If UCase(Trim(Status)) <> "ADDFROMWO" And UCase(Status) <> "EDITFROMWO" Then
            If False Then 'UnitPrice = 0 Then
                DataOK_Flag = False
                FieldName = "Unit Price" & Chr(13)
            End If
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If

        ValidData = DataOK_Flag
    End Function

    Private Function RetrieveFromForm() As Boolean
        Dim OKFlag = True

        If UCase(Status) = "ADD" Or UCase(Status) = "ADDFROMWO" Then
            Category_ID = CategoryTree.SelectedNode.Tag
            If ProductList.SelectedValue Then
                Product_ID = ProductList.SelectedValue.ToString

                With New BusinessRules.ManProdBusRules.ManProdBusLogic
                    If .Load(Product_ID) Then
                        Lead_Time = .Lead_Time
                    End If
                End With

                If SupplierRd2.Checked = True Then
                    Supplier_ID = SelectedSupplier_ID
                Else
                    Supplier_ID = DefaultSupplier_ID
                End If
                If Len(QtyTxt.Text) > 0 Then
                    Qty = Integer.Parse(QtyTxt.Text)
                End If
                UnitPrice = UnitPriceTxt.Text
            Else
                OKFlag = False
                MessageBox.Show("Pls select a Category/Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        RetrieveFromForm = OKFlag
    End Function
#End Region

#Region " Radio btn event"
    Private Sub SupplierRd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierRd1.CheckedChanged
        If SupplierRd1.Checked = True Then
            If Not IsDBNull(DefaultUnitPrice) Then
                Text = "Enquiry Price : $" & Decimal.Round(DefaultUnitPrice, 2)
                EnquiryPriceTxt.Text = Text
            Else
                Text = "Enquiry Price : -"
            End If
            If Not IsDBNull(DefaultCatalog_Price) Then
                Text = "Catalog Price : $" & Decimal.Round(DefaultCatalog_Price, 2)
                CatalogPriceTxt.Text = Text
            Else
                Text = "Catalog Price : -"
            End If
            If Not IsDBNull(DefaultPurchase_Price) Then
                Text = "Purchase Price : $" & Decimal.Round(DefaultPurchase_Price, 2)
                PurchasePriceTxt.Text = Text
            Else
                Text = "Purchase Price : -"
            End If
            UnitPrice = DefaultUnitPrice
            UnitPriceTxt.Text = Double.Parse(UnitPrice)
        End If
    End Sub

    Private Sub SupplierRd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierRd2.CheckedChanged
        If SupplierRd2.Checked = True Then
            SupLookup.Enabled = True
            'UnitPrice = SelectedUnitPrice
            'UnitPriceTxt.Text = Double.Parse(UnitPrice)
        Else
            SupLookup.Enabled = False
        End If
    End Sub
#End Region


    Private Sub EnquiryPriceChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnquiryPriceChk.CheckedChanged
        If EnquiryPriceChk.Checked = True Then
            If SupplierRd1.Checked = True Then
                UnitPrice = DefaultUnitPrice
            Else
                UnitPrice = SelectedUnitPrice
            End If
            UnitPriceTxt.Text = Decimal.Round(UnitPrice, 2)
        End If
    End Sub

    Private Sub CatalogPriceChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogPriceChk.CheckedChanged
        If CatalogPriceChk.Checked = True Then
            If SupplierRd1.Checked = True Then
                UnitPrice = DefaultCatalog_Price
            Else
                UnitPrice = SelectedCatalog_Price
            End If
            UnitPriceTxt.Text = Decimal.Round(UnitPrice, 2)
        End If
    End Sub

    Private Sub PurchasePriceChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchasePriceChk.CheckedChanged
        If PurchasePriceChk.Checked = True Then
            If SupplierRd1.Checked = True Then
                UnitPrice = DefaultPurchase_Price
            Else
                UnitPrice = SelectedPurchase_Price
            End If
            UnitPriceTxt.Text = Decimal.Round(UnitPrice, 2)
        End If
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ClearProductInfo()
        RefreshProductListByProductID(ProductSearchTxt.Text, BrandSearchTxt.Text, DescSearch.Text, DescSearch2.Text, ModelSearch.Text)
        RefreshProductInfo()
    End Sub

    Private Sub ProductSearchTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            e.Handled = True
            SearchBtn_Click(sender, e)
        End If
    End Sub

    Private Sub ClearProductInfo()
        SupplierRd1.Text = "Default Supplier "
        'EnquiryPriceTxt.Text = ""
        'CatalogPriceTxt.Text = ""
        'PurchasePriceTxt.Text = ""
        UnitPriceTxt.Text = ""
        'RefreshProductInfo()
    End Sub

    Private Sub BrandSearchTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            e.Handled = True
            SearchBtn_Click(sender, e)
        End If
    End Sub
End Class


