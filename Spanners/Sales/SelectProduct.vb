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
    Friend WithEvents TabPage1 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage2 As Crownwood.Magic.Controls.TabPage
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
    Friend WithEvents SelectPricing_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Transact_DateTxt As System.Windows.Forms.Label
    Friend WithEvents PurchasePriceChk As System.Windows.Forms.RadioButton
    Friend WithEvents CatalogPriceChk As System.Windows.Forms.RadioButton
    Friend WithEvents EnquiryPriceChk As System.Windows.Forms.RadioButton
    Friend WithEvents EnquiryPriceTxt As System.Windows.Forms.Label
    Friend WithEvents PurchasePriceTxt As System.Windows.Forms.Label
    Friend WithEvents CatalogPriceTxt As System.Windows.Forms.Label
    Friend WithEvents SelectSupplier_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SupLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SupplierRd2 As System.Windows.Forms.RadioButton
    Friend WithEvents SupplierRd1 As System.Windows.Forms.RadioButton
    Friend WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UnitPriceTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Catergory_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Main_Panel As System.Windows.Forms.Panel
    Friend WithEvents Search_Panel As System.Windows.Forms.Panel
    Friend WithEvents Info_Panel As System.Windows.Forms.Panel
    Friend WithEvents Grid_Panel As System.Windows.Forms.Panel
    Friend WithEvents Comp_TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Components_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents Adhoc_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents AdhocDescTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Add_Button As System.Windows.Forms.Button
    Friend WithEvents lblDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SupLookup2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label28 = New System.Windows.Forms.Label
        Me.CategoryTree = New System.Windows.Forms.TreeView
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
        Me.SelectPricing_GroupBox = New System.Windows.Forms.GroupBox
        Me.PurchasePriceChk = New System.Windows.Forms.RadioButton
        Me.CatalogPriceChk = New System.Windows.Forms.RadioButton
        Me.EnquiryPriceChk = New System.Windows.Forms.RadioButton
        Me.EnquiryPriceTxt = New System.Windows.Forms.Label
        Me.PurchasePriceTxt = New System.Windows.Forms.Label
        Me.CatalogPriceTxt = New System.Windows.Forms.Label
        Me.Transact_DateTxt = New System.Windows.Forms.Label
        Me.SelectSupplier_GroupBox = New System.Windows.Forms.GroupBox
        Me.SupLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.SupplierRd2 = New System.Windows.Forms.RadioButton
        Me.SupplierRd1 = New System.Windows.Forms.RadioButton
        Me.SupLookup2 = New DevExpress.XtraEditors.LookUpEdit
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.UnitPriceTxt = New DevExpress.XtraEditors.SpinEdit
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.AdhocDescTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Catergory_Panel = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Main_Panel = New System.Windows.Forms.Panel
        Me.Grid_Panel = New System.Windows.Forms.Panel
        Me.Info_Panel = New System.Windows.Forms.Panel
        Me.lblDescription = New DevExpress.XtraEditors.MemoEdit
        Me.Search_Panel = New System.Windows.Forms.Panel
        Me.Comp_TabControl = New System.Windows.Forms.TabControl
        Me.Components_TabPage = New System.Windows.Forms.TabPage
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Adhoc_TabPage = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Add_Button = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox3.SuspendLayout()
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectPricing_GroupBox.SuspendLayout()
        Me.SelectSupplier_GroupBox.SuspendLayout()
        CType(Me.SupLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupLookup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AdhocDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Catergory_Panel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Main_Panel.SuspendLayout()
        Me.Grid_Panel.SuspendLayout()
        Me.Info_Panel.SuspendLayout()
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search_Panel.SuspendLayout()
        Me.Comp_TabControl.SuspendLayout()
        Me.Components_TabPage.SuspendLayout()
        Me.Adhoc_TabPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(3, 5)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 76
        Me.Label28.Text = "Category List"
        '
        'CategoryTree
        '
        Me.CategoryTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryTree.Location = New System.Drawing.Point(5, 33)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.Size = New System.Drawing.Size(144, 261)
        Me.CategoryTree.TabIndex = 75
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 64)
        Me.GroupBox3.TabIndex = 88
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
        Me.Label36.Location = New System.Drawing.Point(216, 40)
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
        Me.SearchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Image = Nothing
        Me.SearchBtn.Location = New System.Drawing.Point(448, 22)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(46, 19)
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
        'SelectPricing_GroupBox
        '
        Me.SelectPricing_GroupBox.Controls.Add(Me.PurchasePriceChk)
        Me.SelectPricing_GroupBox.Controls.Add(Me.CatalogPriceChk)
        Me.SelectPricing_GroupBox.Controls.Add(Me.EnquiryPriceChk)
        Me.SelectPricing_GroupBox.Controls.Add(Me.EnquiryPriceTxt)
        Me.SelectPricing_GroupBox.Controls.Add(Me.PurchasePriceTxt)
        Me.SelectPricing_GroupBox.Controls.Add(Me.CatalogPriceTxt)
        Me.SelectPricing_GroupBox.Location = New System.Drawing.Point(18, 102)
        Me.SelectPricing_GroupBox.Name = "SelectPricing_GroupBox"
        Me.SelectPricing_GroupBox.Size = New System.Drawing.Size(338, 80)
        Me.SelectPricing_GroupBox.TabIndex = 85
        Me.SelectPricing_GroupBox.TabStop = False
        Me.SelectPricing_GroupBox.Text = "Select Pricing"
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
        Me.EnquiryPriceTxt.Location = New System.Drawing.Point(38, 24)
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
        'Transact_DateTxt
        '
        Me.Transact_DateTxt.Location = New System.Drawing.Point(377, 22)
        Me.Transact_DateTxt.Name = "Transact_DateTxt"
        Me.Transact_DateTxt.Size = New System.Drawing.Size(120, 16)
        Me.Transact_DateTxt.TabIndex = 78
        '
        'SelectSupplier_GroupBox
        '
        Me.SelectSupplier_GroupBox.Controls.Add(Me.SupLookup)
        Me.SelectSupplier_GroupBox.Controls.Add(Me.SupplierRd2)
        Me.SelectSupplier_GroupBox.Controls.Add(Me.SupplierRd1)
        Me.SelectSupplier_GroupBox.Controls.Add(Me.SupLookup2)
        Me.SelectSupplier_GroupBox.Location = New System.Drawing.Point(12, 6)
        Me.SelectSupplier_GroupBox.Name = "SelectSupplier_GroupBox"
        Me.SelectSupplier_GroupBox.Size = New System.Drawing.Size(344, 90)
        Me.SelectSupplier_GroupBox.TabIndex = 86
        Me.SelectSupplier_GroupBox.TabStop = False
        Me.SelectSupplier_GroupBox.Text = "Select Supplier"
        '
        'SupLookup
        '
        Me.SupLookup.Enabled = False
        Me.SupLookup.Location = New System.Drawing.Point(32, 64)
        Me.SupLookup.Name = "SupLookup"
        Me.SupLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
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
        'SupLookup2
        '
        Me.SupLookup2.Enabled = False
        Me.SupLookup2.Location = New System.Drawing.Point(32, 64)
        Me.SupLookup2.Name = "SupLookup2"
        Me.SupLookup2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupLookup2.Properties.Enabled = False
        Me.SupLookup2.Properties.NullString = ""
        Me.SupLookup2.Properties.PopupWidth = 304
        Me.SupLookup2.Size = New System.Drawing.Size(304, 19)
        Me.SupLookup2.TabIndex = 87
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(605, 162)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(72, 21)
        Me.QtyTxt.TabIndex = 84
        Me.QtyTxt.Text = "0"
        '
        'UnitPriceTxt
        '
        Me.UnitPriceTxt.Location = New System.Drawing.Point(493, 162)
        Me.UnitPriceTxt.Name = "UnitPriceTxt"
        Me.UnitPriceTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UnitPriceTxt.Size = New System.Drawing.Size(104, 21)
        Me.UnitPriceTxt.TabIndex = 83
        Me.UnitPriceTxt.Text = "0"
        '
        'ProductList
        '
        Me.ProductList.DisplayMember = "Name"
        Me.ProductList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductList.HorizontalExtent = 50
        Me.ProductList.HorizontalScrollbar = True
        Me.ProductList.Location = New System.Drawing.Point(10, 10)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(502, 108)
        Me.ProductList.TabIndex = 82
        Me.ProductList.ValueMember = "Product_Id"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(605, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Qty :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(493, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Unit Price :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AdhocDescTxt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 293)
        Me.Panel1.TabIndex = 0
        '
        'AdhocDescTxt
        '
        Me.AdhocDescTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AdhocDescTxt.Location = New System.Drawing.Point(22, 39)
        Me.AdhocDescTxt.Name = "AdhocDescTxt"
        Me.AdhocDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AdhocDescTxt.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AdhocDescTxt.Properties.WordWrap = False
        Me.AdhocDescTxt.Size = New System.Drawing.Size(638, 229)
        Me.AdhocDescTxt.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(414, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Qty :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(302, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Unit Price :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Item description :"
        '
        'Catergory_Panel
        '
        Me.Catergory_Panel.Controls.Add(Me.CategoryTree)
        Me.Catergory_Panel.Controls.Add(Me.Panel3)
        Me.Catergory_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Catergory_Panel.Location = New System.Drawing.Point(3, 3)
        Me.Catergory_Panel.Name = "Catergory_Panel"
        Me.Catergory_Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.Catergory_Panel.Size = New System.Drawing.Size(154, 299)
        Me.Catergory_Panel.TabIndex = 89
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(144, 28)
        Me.Panel3.TabIndex = 0
        '
        'Main_Panel
        '
        Me.Main_Panel.Controls.Add(Me.Grid_Panel)
        Me.Main_Panel.Controls.Add(Me.Info_Panel)
        Me.Main_Panel.Controls.Add(Me.Search_Panel)
        Me.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main_Panel.Location = New System.Drawing.Point(167, 3)
        Me.Main_Panel.Name = "Main_Panel"
        Me.Main_Panel.Size = New System.Drawing.Size(524, 299)
        Me.Main_Panel.TabIndex = 90
        '
        'Grid_Panel
        '
        Me.Grid_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Grid_Panel.Controls.Add(Me.ProductList)
        Me.Grid_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Panel.Location = New System.Drawing.Point(0, 84)
        Me.Grid_Panel.Name = "Grid_Panel"
        Me.Grid_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Grid_Panel.Size = New System.Drawing.Size(524, 133)
        Me.Grid_Panel.TabIndex = 91
        '
        'Info_Panel
        '
        Me.Info_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Info_Panel.Controls.Add(Me.lblDescription)
        Me.Info_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Info_Panel.Location = New System.Drawing.Point(0, 217)
        Me.Info_Panel.Name = "Info_Panel"
        Me.Info_Panel.Size = New System.Drawing.Size(524, 82)
        Me.Info_Panel.TabIndex = 90
        '
        'lblDescription
        '
        Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescription.Location = New System.Drawing.Point(0, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.lblDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lblDescription.Properties.WordWrap = False
        Me.lblDescription.Size = New System.Drawing.Size(522, 80)
        Me.lblDescription.TabIndex = 103
        '
        'Search_Panel
        '
        Me.Search_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Search_Panel.Controls.Add(Me.GroupBox3)
        Me.Search_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Search_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Search_Panel.Name = "Search_Panel"
        Me.Search_Panel.Size = New System.Drawing.Size(524, 84)
        Me.Search_Panel.TabIndex = 89
        '
        'Comp_TabControl
        '
        Me.Comp_TabControl.Controls.Add(Me.Components_TabPage)
        Me.Comp_TabControl.Controls.Add(Me.Adhoc_TabPage)
        Me.Comp_TabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Comp_TabControl.Location = New System.Drawing.Point(0, 0)
        Me.Comp_TabControl.Name = "Comp_TabControl"
        Me.Comp_TabControl.SelectedIndex = 0
        Me.Comp_TabControl.Size = New System.Drawing.Size(702, 331)
        Me.Comp_TabControl.TabIndex = 1
        '
        'Components_TabPage
        '
        Me.Components_TabPage.Controls.Add(Me.Main_Panel)
        Me.Components_TabPage.Controls.Add(Me.Splitter1)
        Me.Components_TabPage.Controls.Add(Me.Catergory_Panel)
        Me.Components_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.Components_TabPage.Name = "Components_TabPage"
        Me.Components_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Components_TabPage.Size = New System.Drawing.Size(694, 305)
        Me.Components_TabPage.TabIndex = 0
        Me.Components_TabPage.Text = "Components"
        Me.Components_TabPage.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Location = New System.Drawing.Point(157, 3)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 299)
        Me.Splitter1.TabIndex = 92
        Me.Splitter1.TabStop = False
        '
        'Adhoc_TabPage
        '
        Me.Adhoc_TabPage.Controls.Add(Me.Panel1)
        Me.Adhoc_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.Adhoc_TabPage.Name = "Adhoc_TabPage"
        Me.Adhoc_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Adhoc_TabPage.Size = New System.Drawing.Size(694, 305)
        Me.Adhoc_TabPage.TabIndex = 1
        Me.Adhoc_TabPage.Text = "Ad Hoc Items"
        Me.Adhoc_TabPage.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Add_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 544)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 54)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(603, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 32)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Add_Button
        '
        Me.Add_Button.Location = New System.Drawing.Point(515, 10)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(77, 32)
        Me.Add_Button.TabIndex = 88
        Me.Add_Button.Text = "Add"
        Me.Add_Button.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Transact_DateTxt)
        Me.Panel4.Controls.Add(Me.SelectSupplier_GroupBox)
        Me.Panel4.Controls.Add(Me.SelectPricing_GroupBox)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.UnitPriceTxt)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.QtyTxt)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 333)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(702, 211)
        Me.Panel4.TabIndex = 3
        '
        'SelectProductForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(702, 598)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Comp_TabControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectProductForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectPricing_GroupBox.ResumeLayout(False)
        Me.SelectSupplier_GroupBox.ResumeLayout(False)
        CType(Me.SupLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupLookup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.AdhocDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Catergory_Panel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Main_Panel.ResumeLayout(False)
        Me.Grid_Panel.ResumeLayout(False)
        Me.Info_Panel.ResumeLayout(False)
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search_Panel.ResumeLayout(False)
        Me.Comp_TabControl.ResumeLayout(False)
        Me.Components_TabPage.ResumeLayout(False)
        Me.Adhoc_TabPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
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
    Public CurrentProductForm_TabIndex As Integer
    Public FormType As String


#Region " Code - Form load , Category tree list"
    'For Category Portion

    Private Sub SelectProductForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet

        LoadCategoryList()
        LoadAdHocSupplierInfo()
        Select Case UCase(Status)
            Case "ADDFROMWO", "EDITFROMWO"
                Comp_TabControl.TabIndex = CurrentProductForm_TabIndex
                CategoryTree.Select()
                UnitPriceTxt.Visible = False
                'QtyTxt.Visible = False
                Label1.Visible = False
                'Label2.Visible = False
            Case "EDIT"
                If FormType = "ENQUIRY" Then


                ElseIf FormType = "BQ" Then
                    With New BusinessRules.BQBusRules.BQBusLogic
                        .Component_ID = Component_ID
                        If .GetBQLineComp(ds) Then
                            'CategoryTree.SelectedNode.Tag = ds.Tables(0).Rows(0)("Category_ID").ToString
                            RefreshProductList(ds.Tables(0).Rows(0)("Category_ID"))
                            LoadSupplierInfo(ds.Tables(0).Rows(0)("Product_ID"))
                            UnitPriceTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("UnitPrice"))
                            QtyTxt.Text = ds.Tables(0).Rows(0)("Qty")
                            Add_Button.Text = "Update"
                            SupplierRd1.Enabled = False
                            SupplierRd2.Enabled = False
                            ProductList.Enabled = False
                            CategoryTree.Enabled = False
                            'CategoryTree.Select = False
                        End If
                    End With

                Else
                    With New BusinessRules.SaleBusRules.SaleBusLogic
                        .Component_ID = Component_ID
                        If .GetQuotationLineComp(ds) Then
                            'CategoryTree.SelectedNode.Tag = ds.Tables(0).Rows(0)("Category_ID").ToString
                            RefreshProductList(ds.Tables(0).Rows(0)("Category_ID"))
                            LoadSupplierInfo(ds.Tables(0).Rows(0)("Product_ID"))
                            UnitPriceTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("UnitPrice"))
                            QtyTxt.Text = ds.Tables(0).Rows(0)("Qty")

                            If ds.Tables(0).Rows(0)("Adhoc_item") = 1 Then
                                Comp_TabControl.SelectTab("Adhoc_TabPage")
                                Comp_TabControl.TabPages.RemoveAt(0)
                                Components_TabPage.Hide()
                                AdhocDescTxt.Text = ds.Tables(0).Rows(0)("Adhoc_Description")
                                QtyTxt.Text = ds.Tables(0).Rows(0)("Qty")
                                UnitPriceTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("UnitPrice"))
                            Else
                                lblDescription.Text = ds.Tables(0).Rows(0)("ProductName")
                                lblDescription.Properties.ReadOnly = True
                                Catergory_Panel.Visible = False
                                Search_Panel.Visible = False
                                Grid_Panel.Visible = False
                                Splitter1.Visible = False
                                Comp_TabControl.Height = 125
                                Me.Height = 445
                                Comp_TabControl.TabPages.RemoveAt(1)
                            End If

                            Add_Button.Text = "Update"
                            SupplierRd1.Enabled = False
                            SupplierRd2.Enabled = False
                            ProductList.Enabled = False
                            CategoryTree.Enabled = False
                            'CategoryTree.Select = False
                        End If
                    End With
                End If



        End Select

        'Remove Ad Hoc Items entry for now..
        'Comp_TabControl.TabPages.RemoveAt(1)

    End Sub

    Private Sub LoadAdHocSupplierInfo()
        Dim ds As DataSet
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .LoadList(ds) Then
                If Not ds Is Nothing Then
                    SupLooKup2.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SupLooKup2, "Supplier_Name", 400, 0, "c")
                    SupLooKup2.Properties.LookUpData.KeyField = "Supplier_ID"
                    SupLooKup2.Properties.LookUpData.DisplayField = "Supplier_Name"

                    SupLooKup2.Properties.LookUpData.DataSource = ds.Tables(0)
                    SupLooKup2.EditValue = "0"

                End If
            End If
        End With
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
            If .Load(ds, ProductID, BrandText, Desc, Desc2, Model, 0) Then
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
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Button.Click
        If RetrieveFromForm() Then
            Select Case UCase(Status)
                Case "ADD"
                    If Me.Comp_TabControl.SelectedTab.Name = "Adhoc_TabPage" Then
                        SaveAdHocQuotationLineComponent()
                    Else
                        SaveQuotationLineComponent()
                    End If
                Case "EDIT"
                    If Me.Comp_TabControl.SelectedTab.Name = "Adhoc_TabPage" Then
                        UpdateAdHocQuotationLineComponent()
                    Else
                        UpdateQuotationLineComponent()
                    End If

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
        If FormType = "ENQUIRY" Then

        ElseIf FormType = "BQ" Then
            SaveBQLine()
        Else 'Quotation
            SaveQuotationLine()
        End If

       
    End Sub

    Private Sub SaveBQLine()
        With New BusinessRules.BQBusRules.BQBusLogic
            If ValidData() Then

                .BQ_ID = Quotation_ID
                .BQ_Line_ID = Quotation_Line_ID
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
                        If .SaveBQLineComponent() Then
                            'Me.Close()
                            qf.RefreshComponentGrid()
                            'qf.UpdateBtn_Click(Me, Nothing)
                        End If
                    End If

                Else
                    Dim qf As OrderConfirmationForm
                    qf = Me.Owner.ActiveControl

                    If qf.CheckDuplicateComponents(Product_ID) = False Then
                        If .SaveBQLineComponent() Then
                            'Me.Close()
                            qf.RefreshComponentGrid()
                            'qf.UpdateBtn_Click(Me, Nothing)
                        End If
                    End If
                End If

            End If
        End With
    End Sub

    Private Sub SaveQuotationLine()
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

    Private Sub UpdateAdHocQuotationLineComponent()
        With New BusinessRules.SaleBusRules.SaleBusLogic

            If ValidData() Then
                .Component_ID = Component_ID
                .UnitPrice = UnitPrice
                .UserID = UserID
                .Adhoc_item = 1
                .Adhoc_Description = Me.AdhocDescTxt.Text
                '.Adhoc_Supplier = Me.OtherSuppTxt.Text
                .CompQty = Me.QtyTxt.Text

                If .UpdateQuotationLineComponent() Then
                    Me.Close()
                End If
            End If
        End With
    End Sub

    Private Sub UpdateQuotationLineComponent()
        If FormType = "BQ" Then
            With New BusinessRules.BQBusRules.BQBusLogic
                If ValidData() Then
                    .Component_ID = Component_ID
                    .UnitPrice = UnitPrice
                    .CompQty = Qty
                    .UserID = UserID

                    If .UpdateBQLineComponent() Then
                        Me.Close()
                    End If
                End If
            End With
        Else 'Quotation
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
        End If

        
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

            If Me.Comp_TabControl.SelectedTab.Name = "Adhoc_TabPage" Then
                If Len(QtyTxt.Text) > 0 Then
                    Qty = Integer.Parse(QtyTxt.Text)
                End If
                UnitPrice = UnitPriceTxt.Text
                RetrieveFromForm = OKFlag

            Else

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

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        'ClearProductInfo()
        RefreshProductListByProductID(ProductSearchTxt.Text, BrandSearchTxt.Text, DescSearch.Text, DescSearch2.Text, ModelSearch.Text)
        RefreshProductInfo()
    End Sub

    Private Sub ProductSearchTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProductSearchTxt.KeyUp
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

    Private Sub BrandSearchTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BrandSearchTxt.KeyUp
        If e.KeyValue = 13 Then
            e.Handled = True
            SearchBtn_Click(sender, e)
        End If
    End Sub

    Private Sub TabControl1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub XtraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        SaveAdHocQuotationLineComponent()

        If Me.Owner.ActiveControl.Name = "QuotationForm" Then
            Dim qf As QuotationForm
            qf = Me.Owner.ActiveControl
            qf.CurrentProductForm_TabIndex = Comp_TabControl.TabIndex
        End If

    End Sub


    Private Sub SaveAdHocQuotationLineComponent()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If ValidAdhocData() Then

                .Quotation_ID = Quotation_ID
                .Quotation_Line_ID = Quotation_Line_ID
                .Supplier_ID = Supplier_ID
                .UnitPrice = Me.UnitPriceTxt.Text
                .Adhoc_item = 1
                .Adhoc_Description = Me.AdhocDescTxt.Text
                '.Adhoc_Supplier = Me.OtherSuppTxt.Text
                .CompQty = Me.QtyTxt.Text
                .UserID = UserID

                If Me.Owner.ActiveControl.Name = "QuotationForm" Then
                    Dim qf As QuotationForm
                    qf = Me.Owner.ActiveControl

                    If True Then 'qf.CheckDuplicateComponents(Product_ID) = False Then
                        If .SaveQuotationLineComponent() Then
                            'Me.Close()
                            qf.RefreshComponentGrid()
                            'qf.UpdateBtn_Click(Me, Nothing)
                        End If
                    End If
                Else
                    Dim qf As OrderConfirmationForm
                    qf = Me.Owner.ActiveControl

                    If True Then 'CheckDuplicateComponents(Product_ID) = False Then
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

    Private Function ValidAdhocData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String
        Dim UnitPrice

        UnitPrice = Decimal.Parse(Me.UnitPriceTxt.Text)

        If Me.QtyTxt.Text = 0 Then
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

        ValidAdhocData = DataOK_Flag
    End Function



End Class


