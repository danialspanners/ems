Public Class PrItem3
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "


#Region " PRLine - Variables Initialization "

    Public PR_Line As Integer
    Public PR_ID As Integer

    Public POPR_Line As Integer
    Public POPR_ID As Integer

    Public FormType As String

    Public PO_Line As Integer
    Public PO_ID As Integer

    Public Category_ID As Integer
    Public Product_ID As Integer
    Public Supplier_ID As Integer
    Public Currency As Integer
    Public Actual_Supplier_ID As Integer

    Public Product_Name As String
    Public Product_Desc As String

    Public Request_Qty As Decimal
    Public UOM As String
    Public CurrencySymbol As String

    Public Enquiry_Price As Decimal

    Public Supplier_Name As String

    Public Actual_Supplier_Name As String

    Public Actual_Price As Decimal

    Public Delivery_Date As String

    Public WO_No As String

    Public Order_Qty As Decimal
    Public Component_ID As Integer
    Public UserID As String = Common.CommonConn.Config.USERID

    Public NewItem As Boolean
    Public ModifyItem As Boolean

    Public dataProductGrid As System.Data.DataTable

    Public Status As String = "EDIT"
#End Region

    Public Sub New(Optional ByVal pFormType As String = "PR")
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.FormType = pFormType
        If FormType = "PO" Then
            Price_Label.Text = "Unit Price:"
            Me.RequestQty_Label.Visible = False
            Me.ReqQtySpin.Visible = False
            Me.UnitLabel1.Visible = False
            Me.QtyCopy_Button.Visible = False
            Me.Label11.Visible = False
            Me.ActualSupplierLookup.Enabled = False

        ElseIf FormType = "POADHOC" Then

            ProductName_Text.Enabled = True
            ProductName_Text.Properties.ReadOnly = False

            ProductTxt.Visible = False
            Label5.Visible = False
            Label9.Visible = False
            CurrencyTxt.Visible = False
            EnquiryPriceSpin.Visible = False
            PriceDateTxt.Visible = False
            Label11.Visible = False
            ActualSupplierLookup.Visible = False
            Me.RequestQty_Label.Visible = False
            Me.ReqQtySpin.Visible = False
            Me.UnitLabel1.Visible = False
            Me.QtyCopy_Button.Visible = False


        End If

        LoadCategoryList()
        ' 25.10.2003 YG End
        InitProductList()
        LoadSupplier()
        LoadWorkOrderFrmDB()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pID As Integer, Optional ByVal pFormType As String = "PR")

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ProductGrid.Location = New Point(4, 8)
        CategoryTree.Enabled = False
        ProductList.Enabled = False
        PriceDateTxt.Visible = False


        Dim dsPRLine As DataSet
        Dim dsProduct As DataSet

        Me.PR_Line = pID
        Me.FormType = pFormType

        If FormType = "PO" Then
            Price_Label.Text = "Unit Price:"
            Me.RequestQty_Label.Visible = False
            Me.ReqQtySpin.Visible = False
            Me.UnitLabel1.Visible = False
            Me.QtyCopy_Button.Visible = False
            Me.Label11.Visible = False
            Me.ActualSupplierLookup.Enabled = False

        ElseIf FormType = "POADHOC" Then

            ProductName_Text.Enabled = True
            ProductName_Text.Properties.ReadOnly = False

            ProductTxt.Visible = False
            SupplierTxt.Visible = False
            Label5.Visible = False
            Label9.Visible = False
            CurrencyTxt.Visible = False
            EnquiryPriceSpin.Visible = False
            PriceDateTxt.Visible = False
            Label11.Visible = False
            ActualSupplierLookup.Visible = False
            Me.RequestQty_Label.Visible = False
            Me.ReqQtySpin.Visible = False
            Me.UnitLabel1.Visible = False
            Me.QtyCopy_Button.Visible = False

        End If

        If pID > 0 Then
            If GetLine(dsPRLine, pID) Then

                If Not IsDBNull(dsPRLine.Tables(0).Rows(0)("Product_ID")) Then
                    Product_ID = dsPRLine.Tables(0).Rows(0)("Product_ID")
                Else
                    Product_ID = 0
                End If

                InitProductList()
                LoadProdSupFrmDB()
                GridView1.SelectRow(-1)
                LoadSupplier()

                If Product_ID <> 0 Then
                    If GetProduct(dsProduct, Product_ID) Then
                        UnitLabel1.Text = dsProduct.Tables(0).Rows(0)("UnitName")
                        UnitLabel2.Text = dsProduct.Tables(0).Rows(0)("UnitName")
                    End If

                    With New BusinessRules.ManProdBusRules.ManProdBusLogic
                        .Load(Product_ID)
                        Me.ProductTxt.Text = .Description
                        Me.ProductName_Text.Text = .Name
                    End With

                Else
                    FormType = "POADHOC"
                    ProductName_Text.Enabled = True
                    ProductName_Text.Properties.ReadOnly = False

                    ProductTxt.Visible = False
                    SupplierTxt.Visible = False

                    Label5.Visible = False
                    Label9.Visible = False
                    CurrencyTxt.Visible = False
                    EnquiryPriceSpin.Visible = False
                    PriceDateTxt.Visible = False
                    Label11.Visible = False
                    ActualSupplierLookup.Visible = False
                    Me.RequestQty_Label.Visible = False
                    Me.ReqQtySpin.Visible = False
                    Me.UnitLabel1.Visible = False
                    Me.QtyCopy_Button.Visible = False
                End If

                If FormType = "PO" Then
                    ActualPriceSpin.Text = dsPRLine.Tables(0).Rows(0)("Unit_Price")

                    If Not IsDBNull(dsPRLine.Tables(0).Rows(0)("PR_Line")) Then
                        POPR_Line = dsPRLine.Tables(0).Rows(0)("PR_Line")
                    Else
                        POPR_Line = 0
                    End If

                    If Not IsDBNull(dsPRLine.Tables(0).Rows(0)("PR_ID")) Then
                        POPR_ID = dsPRLine.Tables(0).Rows(0)("PR_ID")
                    Else
                        POPR_ID = 0
                    End If
                ElseIf FormType = "POADHOC" Then
                    ProductName_Text.Text = dsPRLine.Tables(0).Rows(0)("AdhocItemDesc")
                    ActualPriceSpin.Text = dsPRLine.Tables(0).Rows(0)("Unit_Price")
                Else
                    ActualPriceSpin.Text = dsPRLine.Tables(0).Rows(0)("Actual_Price")
                    EnquiryPriceSpin.Text = dsPRLine.Tables(0).Rows(0)("Enquiry_Price")
                    Me.ReqQtySpin.Text = dsPRLine.Tables(0).Rows(0)("Request_Qty")
                    Actual_Supplier_ID = dsPRLine.Tables(0).Rows(0)("Actual_Supplier_ID")
                    Supplier_ID = dsPRLine.Tables(0).Rows(0)("Supplier_ID")
                End If

                If Not IsDBNull(dsPRLine.Tables(0).Rows(0)("Delivery_Date")) Then
                    Me.Delivery_Date = dsPRLine.Tables(0).Rows(0)("Delivery_Date")
                    DeliveryDateEdit.DateTime = Me.Delivery_Date
                End If

                Me.OrderQtySpin.Text = dsPRLine.Tables(0).Rows(0)("Order_Qty")


                If Not IsDBNull(dsPRLine.Tables(0).Rows(0)("Currency")) Then
                    With New BusinessRules.CurrencyBusRules.CurrencyBusLogic
                        .Load(dsPRLine.Tables(0).Rows(0)("Currency"))
                        CurrencySymbol = .CurrencySymbol
                    End With
                End If

                CurrencyTxt.Text = CurrencySymbol

                With New BusinessRules.SupplierBusRules.SupplierBusLogic
                    .Load(Supplier_ID)
                    Supplier_Name = .Supplier_Name
                End With
                SupplierTxt.Text = Supplier_Name

                Me.AddBtn.Text = "Save"

            End If
        Else
            LoadCategoryList()
            ' 25.10.2003 YG End
            InitProductList()
            LoadSupplier()
            LoadWorkOrderFrmDB()
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents DetailGrp As System.Windows.Forms.GroupBox
    Friend WithEvents DeliveryDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EnquiryPriceSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AddBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ReqQtySpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ActualPriceSpin As DevExpress.XtraEditors.SpinEdit

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PriceDateTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SupplierTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActualSupplierLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WOLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ModelSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents DescSearch2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents DescSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents BrandSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProductName_Text As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderQtySpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UnitLabel1 As System.Windows.Forms.Label
    Friend WithEvents UnitLabel2 As System.Windows.Forms.Label
    Friend WithEvents Price_Label As System.Windows.Forms.Label
    Friend WithEvents RequestQty_Label As System.Windows.Forms.Label
    Friend WithEvents QtyCopy_Button As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PrItem3))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.DetailGrp = New System.Windows.Forms.GroupBox
        Me.ProductGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.DeliveryDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.ReqQtySpin = New DevExpress.XtraEditors.SpinEdit
        Me.EnquiryPriceSpin = New DevExpress.XtraEditors.SpinEdit
        Me.RequestQty_Label = New System.Windows.Forms.Label
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.QtyCopy_Button = New System.Windows.Forms.Button
        Me.UnitLabel2 = New System.Windows.Forms.Label
        Me.UnitLabel1 = New System.Windows.Forms.Label
        Me.OrderQtySpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.ProductName_Text = New DevExpress.XtraEditors.TextEdit
        Me.ActualPriceSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.WOLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.ProductTxt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.PriceDateTxt = New DevExpress.XtraEditors.TextEdit
        Me.CurrencyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Price_Label = New System.Windows.Forms.Label
        Me.ActualSupplierLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.CategoryTree = New System.Windows.Forms.TreeView
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailGrp.SuspendLayout()
        CType(Me.ProductGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReqQtySpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryPriceSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.OrderQtySpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductName_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualPriceSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WOLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceDateTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualSupplierLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
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
        'DetailGrp
        '
        Me.DetailGrp.Controls.Add(Me.ProductGrid)
        Me.DetailGrp.Controls.Add(Me.GroupBox1)
        Me.DetailGrp.Location = New System.Drawing.Point(224, 0)
        Me.DetailGrp.Name = "DetailGrp"
        Me.DetailGrp.Size = New System.Drawing.Size(472, 234)
        Me.DetailGrp.TabIndex = 4
        Me.DetailGrp.TabStop = False
        '
        'ProductGrid
        '
        Me.ProductGrid.EditorsRepository = Me.PersistentRepository1
        Me.ProductGrid.Location = New System.Drawing.Point(10, 94)
        Me.ProductGrid.MainView = Me.GridView1
        Me.ProductGrid.Name = "ProductGrid"
        Me.ProductGrid.Size = New System.Drawing.Size(454, 134)
        Me.ProductGrid.TabIndex = 2
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ModelSearch)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.DescSearch2)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.DescSearch)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.BrandSearchTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 80)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Search"
        '
        'ModelSearch
        '
        Me.ModelSearch.Location = New System.Drawing.Point(236, 51)
        Me.ModelSearch.Name = "ModelSearch"
        Me.ModelSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ModelSearch.Size = New System.Drawing.Size(142, 19)
        Me.ModelSearch.TabIndex = 95
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(178, 52)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 94
        Me.Label36.Text = "Model:"
        '
        'DescSearch2
        '
        Me.DescSearch2.Location = New System.Drawing.Point(332, 27)
        Me.DescSearch2.Name = "DescSearch2"
        Me.DescSearch2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch2.Size = New System.Drawing.Size(112, 19)
        Me.DescSearch2.TabIndex = 93
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(300, 27)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 16)
        Me.Label35.TabIndex = 92
        Me.Label35.Text = "and"
        '
        'DescSearch
        '
        Me.DescSearch.Location = New System.Drawing.Point(228, 27)
        Me.DescSearch.Name = "DescSearch"
        Me.DescSearch.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.DescSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch.Size = New System.Drawing.Size(72, 17)
        Me.DescSearch.TabIndex = 91
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(188, 27)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 90
        Me.Label34.Text = "Desc:"
        '
        'BrandSearchTxt
        '
        Me.BrandSearchTxt.Location = New System.Drawing.Point(96, 51)
        Me.BrandSearchTxt.Name = "BrandSearchTxt"
        Me.BrandSearchTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BrandSearchTxt.Size = New System.Drawing.Size(72, 19)
        Me.BrandSearchTxt.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Brand :"
        '
        'SearchBtn
        '
        Me.SearchBtn.AutoSize = False
        Me.SearchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Image = Nothing
        Me.SearchBtn.Location = New System.Drawing.Point(384, 52)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(66, 20)
        Me.SearchBtn.TabIndex = 73
        Me.SearchBtn.Text = "Search"
        '
        'ProductSearchTxt
        '
        Me.ProductSearchTxt.Location = New System.Drawing.Point(96, 28)
        Me.ProductSearchTxt.Name = "ProductSearchTxt"
        Me.ProductSearchTxt.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.ProductSearchTxt.Size = New System.Drawing.Size(88, 17)
        Me.ProductSearchTxt.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 28)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Type Product ID/Code :"
        '
        'ProductList
        '
        Me.ProductList.Location = New System.Drawing.Point(8, 288)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(208, 199)
        Me.ProductList.TabIndex = 58
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 264)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 57
        Me.Label27.Text = "Product List"
        '
        'DeliveryDateEdit
        '
        Me.DeliveryDateEdit.DateTime = New Date(CType(0, Long))
        Me.DeliveryDateEdit.Location = New System.Drawing.Point(320, 176)
        Me.DeliveryDateEdit.Name = "DeliveryDateEdit"
        Me.DeliveryDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DeliveryDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DeliveryDateEdit.Properties.MaskData.EditMask = "##/##/####"
        Me.DeliveryDateEdit.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.DeliveryDateEdit.Size = New System.Drawing.Size(128, 21)
        Me.DeliveryDateEdit.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(244, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Delivery Date :"
        '
        'ReqQtySpin
        '
        Me.ReqQtySpin.Location = New System.Drawing.Point(104, 148)
        Me.ReqQtySpin.Name = "ReqQtySpin"
        Me.ReqQtySpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ReqQtySpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ReqQtySpin.Size = New System.Drawing.Size(72, 21)
        Me.ReqQtySpin.TabIndex = 44
        Me.ReqQtySpin.Text = "0"
        '
        'EnquiryPriceSpin
        '
        Me.EnquiryPriceSpin.Location = New System.Drawing.Point(152, 92)
        Me.EnquiryPriceSpin.Name = "EnquiryPriceSpin"
        Me.EnquiryPriceSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnquiryPriceSpin.Properties.ReadOnly = True
        Me.EnquiryPriceSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnquiryPriceSpin.Size = New System.Drawing.Size(120, 19)
        Me.EnquiryPriceSpin.TabIndex = 39
        Me.EnquiryPriceSpin.Text = "0"
        '
        'RequestQty_Label
        '
        Me.RequestQty_Label.Location = New System.Drawing.Point(8, 148)
        Me.RequestQty_Label.Name = "RequestQty_Label"
        Me.RequestQty_Label.Size = New System.Drawing.Size(80, 16)
        Me.RequestQty_Label.TabIndex = 32
        Me.RequestQty_Label.Text = "Request Qty :"
        '
        'AddBtn
        '
        Me.AddBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddBtn.AutoSize = False
        Me.AddBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Image = Nothing
        Me.AddBtn.Location = New System.Drawing.Point(526, 460)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(88, 32)
        Me.AddBtn.TabIndex = 5
        Me.AddBtn.Text = "Add Item"
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(620, 460)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 65
        Me.CancelBtn.Text = "Close"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.QtyCopy_Button)
        Me.GroupBox3.Controls.Add(Me.UnitLabel2)
        Me.GroupBox3.Controls.Add(Me.UnitLabel1)
        Me.GroupBox3.Controls.Add(Me.OrderQtySpin)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ProductName_Text)
        Me.GroupBox3.Controls.Add(Me.ActualPriceSpin)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.WOLookup)
        Me.GroupBox3.Controls.Add(Me.ProductTxt)
        Me.GroupBox3.Controls.Add(Me.SupplierTxt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.PriceDateTxt)
        Me.GroupBox3.Controls.Add(Me.CurrencyTxt)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Price_Label)
        Me.GroupBox3.Controls.Add(Me.ActualSupplierLookup)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.EnquiryPriceSpin)
        Me.GroupBox3.Controls.Add(Me.ReqQtySpin)
        Me.GroupBox3.Controls.Add(Me.RequestQty_Label)
        Me.GroupBox3.Controls.Add(Me.DeliveryDateEdit)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 208)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selected Item"
        '
        'QtyCopy_Button
        '
        Me.QtyCopy_Button.BackColor = System.Drawing.Color.Lime
        Me.QtyCopy_Button.Location = New System.Drawing.Point(108, 168)
        Me.QtyCopy_Button.Name = "QtyCopy_Button"
        Me.QtyCopy_Button.Size = New System.Drawing.Size(64, 8)
        Me.QtyCopy_Button.TabIndex = 81
        '
        'UnitLabel2
        '
        Me.UnitLabel2.Location = New System.Drawing.Point(184, 176)
        Me.UnitLabel2.Name = "UnitLabel2"
        Me.UnitLabel2.Size = New System.Drawing.Size(52, 23)
        Me.UnitLabel2.TabIndex = 80
        '
        'UnitLabel1
        '
        Me.UnitLabel1.Location = New System.Drawing.Point(184, 152)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(52, 23)
        Me.UnitLabel1.TabIndex = 79
        '
        'OrderQtySpin
        '
        Me.OrderQtySpin.Location = New System.Drawing.Point(104, 176)
        Me.OrderQtySpin.Name = "OrderQtySpin"
        Me.OrderQtySpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.OrderQtySpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OrderQtySpin.Size = New System.Drawing.Size(72, 21)
        Me.OrderQtySpin.TabIndex = 78
        Me.OrderQtySpin.Text = "0"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Order Qty :"
        '
        'ProductName_Text
        '
        Me.ProductName_Text.Location = New System.Drawing.Point(104, 16)
        Me.ProductName_Text.Name = "ProductName_Text"
        Me.ProductName_Text.Properties.AutoHeight = False
        Me.ProductName_Text.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProductName_Text.Properties.ReadOnly = True
        Me.ProductName_Text.Size = New System.Drawing.Size(344, 19)
        Me.ProductName_Text.TabIndex = 76
        '
        'ActualPriceSpin
        '
        Me.ActualPriceSpin.Location = New System.Drawing.Point(316, 144)
        Me.ActualPriceSpin.Name = "ActualPriceSpin"
        Me.ActualPriceSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ActualPriceSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ActualPriceSpin.Size = New System.Drawing.Size(132, 21)
        Me.ActualPriceSpin.TabIndex = 65
        Me.ActualPriceSpin.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Wo No. :"
        Me.Label7.Visible = False
        '
        'WOLookup
        '
        Me.WOLookup.Location = New System.Drawing.Point(80, 204)
        Me.WOLookup.Name = "WOLookup"
        Me.WOLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.WOLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WOLookup.Properties.NullString = ""
        Me.WOLookup.Size = New System.Drawing.Size(128, 21)
        Me.WOLookup.TabIndex = 74
        Me.WOLookup.Visible = False
        '
        'ProductTxt
        '
        Me.ProductTxt.Location = New System.Drawing.Point(104, 40)
        Me.ProductTxt.Name = "ProductTxt"
        Me.ProductTxt.Properties.AutoHeight = False
        Me.ProductTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProductTxt.Properties.ReadOnly = True
        Me.ProductTxt.Size = New System.Drawing.Size(344, 19)
        Me.ProductTxt.TabIndex = 73
        '
        'SupplierTxt
        '
        Me.SupplierTxt.Location = New System.Drawing.Point(104, 68)
        Me.SupplierTxt.Name = "SupplierTxt"
        Me.SupplierTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierTxt.Properties.ReadOnly = True
        Me.SupplierTxt.Size = New System.Drawing.Size(344, 19)
        Me.SupplierTxt.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Supplier :"
        '
        'PriceDateTxt
        '
        Me.PriceDateTxt.Location = New System.Drawing.Point(280, 92)
        Me.PriceDateTxt.Name = "PriceDateTxt"
        Me.PriceDateTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PriceDateTxt.Properties.FormatString = "dd/MM/yyyy"
        Me.PriceDateTxt.Properties.ReadOnly = True
        Me.PriceDateTxt.Size = New System.Drawing.Size(88, 19)
        Me.PriceDateTxt.TabIndex = 70
        '
        'CurrencyTxt
        '
        Me.CurrencyTxt.Location = New System.Drawing.Point(104, 92)
        Me.CurrencyTxt.Name = "CurrencyTxt"
        Me.CurrencyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrencyTxt.Properties.ReadOnly = True
        Me.CurrencyTxt.Size = New System.Drawing.Size(40, 19)
        Me.CurrencyTxt.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Product :"
        '
        'Price_Label
        '
        Me.Price_Label.Location = New System.Drawing.Point(244, 148)
        Me.Price_Label.Name = "Price_Label"
        Me.Price_Label.Size = New System.Drawing.Size(72, 23)
        Me.Price_Label.TabIndex = 66
        Me.Price_Label.Text = "Actual Price :"
        '
        'ActualSupplierLookup
        '
        Me.ActualSupplierLookup.Location = New System.Drawing.Point(104, 116)
        Me.ActualSupplierLookup.Name = "ActualSupplierLookup"
        Me.ActualSupplierLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ActualSupplierLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ActualSupplierLookup.Properties.NullString = ""
        Me.ActualSupplierLookup.Properties.PopupWidth = 348
        Me.ActualSupplierLookup.Size = New System.Drawing.Size(344, 21)
        Me.ActualSupplierLookup.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Actual Supplier :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Price :"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(8, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "Category List"
        '
        'CategoryTree
        '
        Me.CategoryTree.ImageIndex = -1
        Me.CategoryTree.Location = New System.Drawing.Point(8, 24)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.SelectedImageIndex = -1
        Me.CategoryTree.Size = New System.Drawing.Size(208, 232)
        Me.CategoryTree.TabIndex = 69
        '
        'PrItem3
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(696, 499)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DetailGrp)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.Label27)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrItem3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Purchase Requisition Item"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailGrp.ResumeLayout(False)
        CType(Me.ProductGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReqQtySpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryPriceSpin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.OrderQtySpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductName_Text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualPriceSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WOLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceDateTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualSupplierLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Event"

    Private Sub PrItem3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        NewItem = False

        'Load list of category frm db at the start of form
        ' 25.10.2003 YG Start
        '        LoadCategoryFrmDB()
        
        If Me.Actual_Supplier_ID <> Nothing Then
            'Me.ActualSupplierLookup.Properties.LookUpData.KeyValue = Actual_Supplier_ID
            ActualSupplierLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Actual_Supplier_ID, 0, 0, 0})
        End If

        Me.ProductSearchTxt.Focus()

        'Select Case UCase(Status)

        'Case "EDIT"
        'Dim ds As DataSet
        'With New BusinessRules.PRBusRules.PRLineBusLogic
        '.PR_Line = PR_Line
        'If .GetLine(ds) Then
        'CategoryTree.SelectedNode.Tag = ds.Tables(0).Rows(0)("Category_ID").ToString
        'RefreshProductList(ds.Tables(0).Rows(0)("Category_ID"))
        'LoadSupplierInfo(ds.Tables(0).Rows(0)("Product_ID"))
        'UnitPriceTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("UnitPrice"))
        'ReqQtySpin.Text = ds.Tables(0).Rows(0)("Qty")
        'AddBtn.Text = "Update"
        'SupplierRd1.Enabled = False
        'SupplierRd2.Enabled = False
        'ProductList.Enabled = False
        'CategoryTree.Enabled = False
        'CategoryTree.Select = False
        'End If
        'End With
        'End Select

    End Sub

    ' 25.10.2003 YG Start
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

        If CurrentTag <> Nothing Then
            Category_ID = CurrentTag
            RefreshProductList(Category_ID)
        End If
    End Sub

    Private Sub RefreshProductList(ByVal pCategoryID As Integer)
        Dim ds As DataSet

        Product_ID = 0
        LoadProdSupFrmDB()
        'Load product list
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .LoadList(ds, pCategoryID) Then
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

    Private Sub ProductList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
        Dim text As String
        Dim dsProduct As DataSet

        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            If ProductList.Items.Count > 0 Then
                Product_ID = ProductList.SelectedValue.ToString

                If Product_ID > 0 Then
                    If GetProduct(dsProduct, Product_ID) Then
                        Product_Name = dsProduct.Tables(0).Rows(0)("Name")
                        ProductName_Text.Text = Product_Name
                        ProductTxt.Text = dsProduct.Tables(0).Rows(0)("Description")
                        UnitLabel1.Text = dsProduct.Tables(0).Rows(0)("UnitName")
                        UnitLabel2.Text = dsProduct.Tables(0).Rows(0)("UnitName")
                    End If
                End If

                .Product_ID = Product_ID
                ActualPriceSpin.Text = 0
                EnquiryPriceSpin.Text = 0
                Me.ReqQtySpin.Text = 0
                If FormType <> "PO" Then
                    Me.Actual_Supplier_ID = 0
                End If
                Me.Delivery_Date = ""
                'Me.DeliveryDateEdit.Text = ""
                Me.WO_No = ""
                LoadSupplier()
                LoadWorkOrderFrmDB()
                LoadProdSupFrmDB()
            End If
        End With
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        Dim OldCursor = Me.Cursor.Current
        Me.Cursor = Cursors.WaitCursor
        RefreshProductListByProductID(ProductSearchTxt.Text, BrandSearchTxt.Text, DescSearch.Text, DescSearch2.Text, ModelSearch.Text)
        Me.Cursor = OldCursor
        'RefreshProductInfo()
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

    ' 25.10.2003 YG End

    Private Sub ProductGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductGrid.Click
        ProductSupplierClick()
    End Sub

    'Add Item
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click

        Me.AddBtn.Focus()

        GetWindowsValue()

        If ValidData() Then

            If FormType <> "POADHOC" Then
                If Me.ActualPriceSpin.Text <> Nothing And IsNumeric(ActualPriceSpin.Text) Then
                    If True Then 'Convert.ToDouble(Me.ActualPriceSpin.Text) <> Convert.ToDouble(EnquiryPriceSpin.Text) Then
                        If MessageBox.Show("Do you want to update the latest price?", "Update Price", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            CreateNewRec()
                        End If
                    End If
                End If
            End If

            NewItem = True

            'Dim prf As PRList
            'prf = Me.Owner.ActiveControl
            Dim pDeliveryDate As Date
            Dim tempDeliveryDate As String = ""

            If Delivery_Date <> "" Then
                tempDeliveryDate = ChangeDateFormat(Delivery_Date)
            End If

            'prf.dataGrid.Rows.Add(New Object() {PR_Line, Category_ID, Product_ID, _
            '                      Supplier_ID, Actual_Supplier_ID, Component_ID, _
            '                       Product_Name, _
            '                       Request_Qty, 0, Request_Qty, UOM, _
            '                       tempDeliveryDate, _
            '                       Currency, _
            '                       Supplier_Name, Enquiry_Price, _
            '                       Actual_Supplier_Name, Actual_Price, _
            '                       WO_No})

            If Me.Owner.ActiveControl.Name = "PRList" Or Me.Owner.ActiveControl.Name = "POList2" Then
                Dim qf As PRList
                Dim qf2 As POList2

                If FormType = "PO" Or FormType = "POADHOC" Then
                    qf2 = Me.Owner.ActiveControl
                Else
                    qf = Me.Owner.ActiveControl
                End If

                If SaveDataProcess() Then
                    'Me.Close()

                    If FormType = "PO" Or FormType = "POADHOC" Then
                        qf2.LoadPOItem()
                        qf2.UpdateDate()
                    Else
                        qf.LoadPRItem()
                        qf.UpdateDate()
                    End If

                    With New BusinessRules.PRBusRules.PRHeaderBusLogic
                        .Load(PR_ID)
                        .Transact_Date = Me.ChangeDateFormat(Today())
                        .Update(PR_ID)
                    End With

                    'PartGrid.DataSource = Nothing
                    'LocGrid.DataSource = Nothing

                    'LocGrid.Refresh()
                    'PartGrid.Refresh()

                    If True Then 'FormType = "DO" Or FormType = "PMR" Then
                        ResetEntry()
                    End If
                    'qf.UpdateBtn_Click(Me, Nothing)
                End If
            End If

            If Me.PR_Line <> 0 And Me.PR_Line <> Nothing Then
                Close()
            End If


        End If

    End Sub

    Private Function SavePODataProcess() As Boolean

        Dim i
        Dim dr As DataRow
        Dim ds As DataSet

        SavePODataProcess = False

        'dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

        
        If PR_Line = Nothing Or PR_Line = 0 Then

            With New BusinessRules.POBusRules.POLineBusLogic

                .PO_ID = PO_ID
                .Category_ID = Me.Category_ID
                .Product_ID = Product_ID
                .Order_Qty = Order_Qty
                .Delivery_Date = Delivery_Date
                .Unit_Price = Actual_Price
                .Status = 20

                .WO_No = WO_No

                .UserID = UserID 'Common.CommonConn.Config.USERID

                'Creates a new record
                .Save()
                SavePODataProcess = True
            End With
        Else

            With New BusinessRules.POBusRules.POLineBusLogic

                .PO_ID = PO_ID
                .PR_ID = POPR_ID
                .PR_Line = POPR_Line
                .Category_ID = Category_ID
                .Product_ID = Product_ID
                .Order_Qty = Order_Qty
                .Delivery_Date = Delivery_Date
                .Unit_Price = Actual_Price
                
                .WO_No = WO_No

                .UserID = UserID 'Common.CommonConn.Config.USERID

                'Creates a new record
                .Update(PR_Line)
                SavePODataProcess = True
            End With

        End If

        
    End Function
    Private Function SavePOADHOCProcess() As Boolean

        Dim i
        Dim dr As DataRow
        Dim ds As DataSet

        SavePOADHOCProcess = False

        'dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))


        If PR_Line = Nothing Or PR_Line = 0 Then

            With New BusinessRules.POBusRules.POLineBusLogic

                .PO_ID = PO_ID
                .Product_ID = 0
                .AdHocItemDesc = ProductName_Text.Text
                .Order_Qty = Order_Qty
                .Delivery_Date = Delivery_Date
                .Unit_Price = Actual_Price
                .Status = 20

                .WO_No = WO_No

                .UserID = UserID 'Common.CommonConn.Config.USERID

                'Creates a new record
                .Save()
                SavePOADHOCProcess = True
            End With
        Else

            With New BusinessRules.POBusRules.POLineBusLogic

                .PO_ID = PO_ID
                .AdHocItemDesc = ProductName_Text.Text
                .Order_Qty = Order_Qty
                .Delivery_Date = Delivery_Date
                .Unit_Price = Actual_Price
                .Status = 20

                .WO_No = WO_No

                .UserID = UserID 'Common.CommonConn.Config.USERID

                'Creates a new record
                .Update(PR_Line)
                SavePOADHOCProcess = True
            End With

        End If


    End Function
    Private Function SavePRDataProcess() As Boolean

        Dim i
        Dim dr As DataRow
        Dim ds As DataSet

        Dim countOrderedQty As Integer
        Dim errorQtyExceed As Boolean

        errorQtyExceed = False
        SavePRDataProcess = False

        'dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

        'Dim items As Object() = dr.ItemArray

        'Currency = items(1)

        'PR_Line = items(0)
        'Category_ID = items(1)
        'Product_ID = items(2)
        'Supplier_ID = items(3)
        'Actual_Supplier_ID = items(4)
        'Component_ID = items(5)

        'Request_Qty = items(7)
        'Order_Qty = items(9)

        'Delivery_Date = items(11)

        'Enquiry_Price = items(14)
        'Actual_Price = items(16)

        'If Quotation_NO = "" Then
        'If Not items(17) Is System.DBNull.Value Then
        'WO_No = items(17)
        'Else
        '    WO_No = ""
        'End If
        'End If

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
                    '.Category_ID = Category_ID
                    .Product_ID = Product_ID
                    .Currency = Me.Currency
                    .ActualPriceCurrency = Me.Currency
                    .Request_Qty = Request_Qty
                    .Order_Qty = Order_Qty
                    .Delivery_Date = Delivery_Date
                    If (Me.Actual_Supplier_ID <> Nothing And Me.Actual_Supplier_ID <> 0) Then
                        .Supplier_ID = Me.Actual_Supplier_ID
                    ElseIf Me.Supplier_ID <> 0 Then
                        .Supplier_ID = Supplier_ID
                    End If
                    .Enquiry_Price = Enquiry_Price
                    .Actual_Price = Actual_Price
                    .Component_ID = Component_ID

                    If (Actual_Supplier_ID <> Nothing And Me.Actual_Supplier_ID <> 0) Then
                        .Actual_Supplier_ID = Actual_Supplier_ID
                    End If

                    .WO_No = WO_No

                    .UserID = UserID 'Common.CommonConn.Config.USERID

                    'Creates a new record
                    .Save()
                    SavePRDataProcess = True
                End With
            End If
        Else

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
                    '.Category_ID = Category_ID
                    .Product_ID = Product_ID
                    .Currency = Me.Currency
                    .ActualPriceCurrency = Me.Currency
                    .Request_Qty = Request_Qty
                    .Order_Qty = Order_Qty
                    .Delivery_Date = Delivery_Date
                    If (Me.Actual_Supplier_ID <> Nothing And Me.Actual_Supplier_ID <> 0) Then
                        .Supplier_ID = Me.Actual_Supplier_ID
                    ElseIf Me.Supplier_ID <> 0 Then
                        .Supplier_ID = Supplier_ID
                    End If
                    .Enquiry_Price = Enquiry_Price
                    .Actual_Price = Actual_Price
                    .Component_ID = Component_ID

                    If (Actual_Supplier_ID <> Nothing And Me.Actual_Supplier_ID <> 0) Then
                        .Actual_Supplier_ID = Actual_Supplier_ID
                    End If

                    .WO_No = WO_No

                    .UserID = UserID 'Common.CommonConn.Config.USERID

                    'Creates a new record
                    .Update(PR_Line)
                    SavePRDataProcess = True
                End With
            End If

        End If

        If errorQtyExceed = True Then
            MessageBox.Show("Quantity to order had exceed request quantity", "Error - Quantity Exceed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SavePRDataProcess = False
        End If

    End Function

    Public Function SaveDataProcess() As Boolean

        If FormType = "PO" Then
            SaveDataProcess = SavePODataProcess()
        ElseIf FormType = "POADHOC" Then
            SaveDataProcess = SavePOADHOCProcess()
        Else
            SaveDataProcess = SavePRDataProcess()
        End If

    End Function

    Private Sub ResetEntry()

        Me.ProductSearchTxt.Text = ""
        Me.ProductSearchTxt.SelectAll()
        Me.ProductSearchTxt.Focus()

        'RefreshProductList(0)

    End Sub

    'Cancel
    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

#End Region

#Region "Product Grid"

    'Call once form load, Initalize Quotation Columns
    Private Sub InitProductList()

        dataProductGrid = New DataTable("ColumnsTable")
        dataProductGrid.BeginInit()

        AddColumn(dataProductGrid, "Supplier_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(dataProductGrid, "Currency", System.Type.GetType("System.Int16"), True)
        AddColumn(dataProductGrid, "Supplier", System.Type.GetType("System.String"), True)
        AddColumn(dataProductGrid, "CurrencySymbol", System.Type.GetType("System.String"), True)
        AddColumn(dataProductGrid, "Price", System.Type.GetType("System.Double"), True)
        AddColumn(dataProductGrid, "Price Date", System.Type.GetType("System.String"), True)
        AddColumn(dataProductGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataProductGrid, "UOM", System.Type.GetType("System.String"), True)


        dataProductGrid.EndInit()

        ProductGrid.DataSource = dataProductGrid
        ProductGrid.DefaultView.PopulateColumns()

        'GridView1.BestFitColumns()

        GridView1.Columns.Item(2).Width = 300
        'Currency
        GridView1.Columns.Item(3).Width = 30
        'Enq Price
        GridView1.Columns.Item(4).Width = 75
        'Price Date
        GridView1.Columns.Item(5).Width = 70
        'UOM
        GridView1.Columns.Item(7).Width = 80

        GridView1.Columns.Item(0).VisibleIndex = -1
        GridView1.Columns.Item(1).VisibleIndex = -1
        'GridView1.Columns.Item(2).VisibleIndex = -1
        GridView1.Columns.Item(6).VisibleIndex = -1
        GridView1.Columns.Item(7).VisibleIndex = -1
    End Sub

#End Region

#Region "Database Management"


    'Load list of product suppliers into grid
    Private Sub LoadProdSupFrmDB()
        ClearGrid(GridView1)

        Dim ds As DataSet
        Dim dsParent As DataSet
        With New BusinessRules.PRBusRules.PRBusLogic

            If .ProdSupLoadList(ds, Product_ID, "0") Then
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentQuotationNo As String

                For Each oRow In ds.Tables(0).Rows

                    dataProductGrid.Rows.Add(New Object() {oRow("Supplier_ID"), oRow("Currency"), oRow("Supplier"), _
                                                 oRow("CurrencySymbol"), oRow("Price"), _
                                                 ChangeDateFormat(oRow("Transact_Date")), _
                                                 oRow("Product"), oRow("UOM")})

                Next
            End If
        End With


        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            ProductSupplierClick()
        Else
            'ProductTxt.Text = ""
            CurrencyTxt.Text = ""
            EnquiryPriceSpin.Text = ""
            PriceDateTxt.Text = ""
            SupplierTxt.Text = ""
            Me.ReqQtySpin.Text = "0"
            DeliveryDateEdit.DateTime = Nothing
            ActualSupplierLookup.LookUpBoxText = ""
            LoadSupplier()

        End If
    End Sub


    'Load list of supplier to combo
    Private Sub LoadSupplier()
        Dim ds As DataSet
        'Load supplier list
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .LoadList(ds) Then
                If Not ds Is Nothing Then
                    Try
                        ActualSupplierLookup.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(ActualSupplierLookup, "Supplier_Name", 400, 0, "")

                        ActualSupplierLookup.Properties.LookUpData.KeyField = "Supplier_ID"
                        ActualSupplierLookup.Properties.LookUpData.DisplayField = "Supplier_Name"
                        ActualSupplierLookup.Properties.LookUpData.DataSource = ds.Tables(0)

                        If Actual_Supplier_ID <> Nothing And Actual_Supplier_ID <> 0 Then
                            ActualSupplierLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Actual_Supplier_ID, 0, 0, 0})
                        Else
                            ActualSupplierLookup.Properties.LookUpData.KeyValue = Nothing
                        End If

                        ActualSupplierLookup.Properties.PopupWidth = 400

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load supplier list


    End Sub

    'Load list of work order to combo
    Private Sub LoadWorkOrderFrmDB()
        Dim ds As DataSet
        'Load supplier list
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If .GetWOHeader(ds) Then
                If Not ds Is Nothing Then
                    Try
                        WOLookup.Properties.LookUpData.ListFields.Clear()
                        WOLookup.Properties.LookUpData.KeyValue = Nothing

                        AddListFieldInfoToLookUp(WOLookup, "WO_No", 20, 0, "")

                        WOLookup.Properties.PopupWidth = 200
                        WOLookup.Properties.LookUpData.KeyField = "WO_ID"
                        WOLookup.Properties.LookUpData.DisplayField = "WO_No"
                        WOLookup.Properties.LookUpData.DataSource = ds.Tables(0)

                        If WO_No <> "" Then
                            WOLookup.Text = WO_No
                        End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load supplier list
    End Sub
#End Region


#Region "Other Codes"

    Public Function GetProdSupplierID()

        Dim ProductSupplier_ID As Integer = 0
        Dim tmpSuppID As Integer

        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            If Actual_Supplier_ID = 0 Then
                tmpSuppID = Supplier_ID
            Else
                tmpSuppID = Actual_Supplier_ID
            End If
            ProductSupplier_ID = .RecordExists(Product_ID, tmpSuppID)

        End With

        GetProdSupplierID = ProductSupplier_ID

    End Function

    Public Sub CreateNewRec()
        Dim ProductSupplier_ID As Integer

        ProductSupplier_ID = GetProdSupplierID()

        Dim Catalog_Price
        Dim Currency
        Dim pEnquiry_Price
        Dim Purchase_Price
        Dim Transact_Date

        Dim form As New ManageProdSupForm(Me.Owner)

        form.Product_ID = Product_ID
        form.FromPR = True
        If Actual_Supplier_ID = 0 Then
            form.Supplier_ID = Supplier_ID
        Else
            form.Supplier_ID = Actual_Supplier_ID
        End If

        form.Purchase_Price = Actual_Price

        form.ShowDialog()

        If form.NewItem Then
            Catalog_Price = form.Catalog_Price
            Currency = form.Currency
            pEnquiry_Price = form.Enquiry_Price
            Purchase_Price = form.Purchase_Price
            Transact_Date = form.Transact_Date



            With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
                'Update current value's HistoryRecord
                .Product_ID = Product_ID
                '                .Supplier_ID = Supplier_ID
                If Actual_Supplier_ID = 0 Then
                    .Supplier_ID = Supplier_ID
                Else
                    .Supplier_ID = Actual_Supplier_ID

                End If
                .Currency = Currency
                .Catalog_Price = Catalog_Price
                .Enquiry_Price = pEnquiry_Price
                .Purchase_Price = Purchase_Price
                .Transact_Date = Transact_Date
                .UserID = UserID

                If ProductSupplier_ID <> Nothing And ProductSupplier_ID <> 0 Then
                    '.Update(ProductSupplier_ID)
                    .Save()
                Else
                    .Save()
                End If

            End With

            ActualPriceSpin.Text = 0
            EnquiryPriceSpin.Text = 0
            Me.ReqQtySpin.Text = 0
            LoadSupplier()
            LoadWorkOrderFrmDB()
            LoadProdSupFrmDB()

        End If
    End Sub

    'Change date format
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

    'Called when product supplier grid is clicked, requires to show selected item's details
    Private Sub ProductSupplierClick()

        If GridView1.SelectedRowsCount <> 0 Then
            Dim dr As DataRow
            Dim pPriceDate

            dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

            Dim items As Object() = dr.ItemArray

            Supplier_ID = items(0)
            Currency = items(1)
            Supplier_Name = items(2)
            If Not IsDBNull(items(3)) Then
                CurrencySymbol = items(3)
            End If
            Enquiry_Price = items(4)
            pPriceDate = items(5)
            Product_Desc = items(6)
            UOM = items(7)

            'ProductTxt.Text = Product_Desc
            CurrencyTxt.Text = CurrencySymbol
            EnquiryPriceSpin.Text = Enquiry_Price
            Me.ActualPriceSpin.Text = Enquiry_Price
            PriceDateTxt.Text = pPriceDate
            SupplierTxt.Text = Supplier_Name

        End If
    End Sub

#End Region

#Region "Combo Box"

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

#Region " Other Code "

    Public Function GetProduct(ByRef ds As DataSet, ByVal pProduct_Id As String) As Boolean
        With New DataAccess.DAccess.Access
            Dim SQLStr As String

            GetProduct = False

            SQLStr = "SELECT *,UM.DESCRIPTION as UnitName FROM Product P "
            SQLStr = SQLStr & " LEFT JOIN UnitMeasurement UM on UM.UOM_ID=P.UOM_ID "
            SQLStr = SQLStr & " where Product_ID = " & Integer.Parse(pProduct_Id)

            If .GetDataSet(ds, SQLStr) Then
                GetProduct = True
            End If
            'ds.Dispose()
        End With
    End Function


    Public Function GetLine(ByRef ds As DataSet, ByVal pPRLine As String) As Boolean
        With New DataAccess.DAccess.Access
            Dim SQLStr As String

            If FormType = "PO" Then
                SQLStr = "SELECT * FROM POLine where PO_Line_ID = " & Integer.Parse(pPRLine)
            Else
                SQLStr = "SELECT * FROM PRLine where PR_Line = " & Integer.Parse(pPRLine)
            End If

            If .GetDataSet(ds, SQLStr) Then
                Return True
            End If
            ds.Dispose()
        End With
    End Function

#End Region


#Region " Code - Set/Get Window Values"
    'Get Window Values
    Private Sub GetWindowsValue()

        Request_Qty = ReqQtySpin.Text
        Order_Qty = OrderQtySpin.Text

        If DeliveryDateEdit.Text <> "" Then
            Delivery_Date = DeliveryDateEdit.DateTime.Day & " " & MonthName(DeliveryDateEdit.DateTime.Month) & " " & DeliveryDateEdit.DateTime.Year
        Else
            Delivery_Date = ""
        End If

        Actual_Price = ActualPriceSpin.Text
        Enquiry_Price = EnquiryPriceSpin.Text

        If ActualSupplierLookup.Text <> "" Then
            Actual_Supplier_Name = ActualSupplierLookup.Text
            Actual_Supplier_ID = Integer.Parse(ActualSupplierLookup.Properties.LookUpData.KeyValue().ToString())
        End If

        WO_No = WOLookup.Text

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If FormType = "POADHOC" Then
            Return True
        End If

        'If Category_ID = Nothing Then
        'ErrorMessage = ErrorMessage & " Category" & Chr(13)
        'DataOK_flag = False
        'End If

        If Product_ID = Nothing Then
            ErrorMessage = ErrorMessage & " Product" & Chr(13)
            DataOK_flag = False
        End If

        'If Supplier_ID = Nothing Then
        'ErrorMessage = ErrorMessage & " Supplier" & Chr(13)
        'DataOK_flag = False
        'End If


        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else

            If Request_Qty = 0 And FormType <> "PO" Then
                ErrorMessage = ErrorMessage & " Request Quantity" & Chr(13)

                MessageBox.Show("Request Quantity must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DataOK_flag = False
            Else
                If False Then 'Actual_Price > Enquiry_Price Then
                    MessageBox.Show("Actual Price must be smaller than Enquiry Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    DataOK_flag = False
                End If
            End If
        End If

        If DataOK_flag Then
            If Actual_Supplier_ID <> Nothing And Actual_Supplier_ID <> 0 Then
                If Actual_Price = 0 Or Actual_Price = Nothing Then
                    MessageBox.Show("Actual Price cannot be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    DataOK_flag = False
                Else
                    If False Then 'Actual_Price > Enquiry_Price Then
                        MessageBox.Show("Actual Price must be smaller than Enquiry Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If
            End If
        End If

        Return DataOK_flag

    End Function

#End Region


    Private Sub WOLookup_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WOLookup.KeyUp

    End Sub

    Private Sub WOLookup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WOLookup.KeyDown
        If e.KeyCode = Keys.Delete Then
            'WOLookup.Text = "" '.Properties.LookUpData.KeyValue = DBNull
            'LoadWorkOrderFrmDB()
            WOLookup.Properties.LookUpData.KeyValue = Nothing

        End If
    End Sub

    Private Sub ProductSearchTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProductSearchTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(Me, e)
        End If
    End Sub

    Private Sub ModelSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ModelSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(Me, e)
        End If
    End Sub

    Private Sub BrandSearchTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BrandSearchTxt.KeyDown
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
        End If
    End Sub

    Private Sub ReqQtySpin_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReqQtySpin.Enter
        ReqQtySpin.SelectAll()
    End Sub

    Private Sub ProductList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductList.Click

    End Sub

    Private Sub ReqQtySpin_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReqQtySpin.ValueChanged
        If Me.Status = "10" Then
            Me.OrderQtySpin.Text = ReqQtySpin.Text
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QtyCopy_Button.Click
        Me.OrderQtySpin.Text = Me.ReqQtySpin.Text
    End Sub
End Class
