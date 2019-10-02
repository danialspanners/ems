Public Class SearchProduct
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitProductList()
        ReturnType = "product"

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pReturnType As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitProductList()
        ReturnType = pReturnType
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
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
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 150)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 26)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Double click on the part code/product to select or click <OK> button to select. P" & _
        "ress Esc or click <CANCEL> to close."
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
        Me.GroupBox3.Size = New System.Drawing.Size(438, 98)
        Me.GroupBox3.TabIndex = 89
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parts Search"
        '
        'XtraButton1
        '
        Me.XtraButton1.AutoSize = False
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(378, 56)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(48, 32)
        Me.XtraButton1.TabIndex = 6
        Me.XtraButton1.Text = "Clear"
        '
        'ModelSearch
        '
        Me.ModelSearch.Location = New System.Drawing.Point(236, 68)
        Me.ModelSearch.Name = "ModelSearch"
        Me.ModelSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ModelSearch.Size = New System.Drawing.Size(136, 19)
        Me.ModelSearch.TabIndex = 4
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(190, 68)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 16)
        Me.Label36.TabIndex = 86
        Me.Label36.Text = "Model:"
        '
        'DescSearch2
        '
        Me.DescSearch2.Location = New System.Drawing.Point(212, 42)
        Me.DescSearch2.Name = "DescSearch2"
        Me.DescSearch2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch2.Size = New System.Drawing.Size(158, 19)
        Me.DescSearch2.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(180, 42)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 16)
        Me.Label35.TabIndex = 84
        Me.Label35.Text = "and"
        '
        'DescSearch
        '
        Me.DescSearch.Location = New System.Drawing.Point(52, 42)
        Me.DescSearch.Name = "DescSearch"
        Me.DescSearch.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.DescSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch.Size = New System.Drawing.Size(124, 17)
        Me.DescSearch.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(12, 44)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 82
        Me.Label34.Text = "Desc:"
        '
        'BrandSearchTxt
        '
        Me.BrandSearchTxt.Location = New System.Drawing.Point(56, 66)
        Me.BrandSearchTxt.Name = "BrandSearchTxt"
        Me.BrandSearchTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BrandSearchTxt.Size = New System.Drawing.Size(130, 19)
        Me.BrandSearchTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 68)
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
        Me.SearchBtn.Location = New System.Drawing.Point(378, 18)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(48, 32)
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
        Me.Grid_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Panel.Location = New System.Drawing.Point(0, 150)
        Me.Grid_Panel.Name = "Grid_Panel"
        Me.Grid_Panel.Size = New System.Drawing.Size(468, 135)
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
        Me.PartGrid.Size = New System.Drawing.Size(464, 131)
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
        Me.GridView1.PrintOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.ExpandAllGroups) _
                    Or DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.PrintFooter) _
                    Or DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.PrintGroupFooter) _
                    Or DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.PrintHeader) _
                    Or DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.PrintHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.PrintPreview) _
                    Or DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags.PrintVertLines), DevExpress.XtraGrid.Views.Grid.PrintOptionsFlags)
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.SaveButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 285)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(468, 54)
        Me.Panel4.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(376, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SaveButton.Location = New System.Drawing.Point(290, 18)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "OK"
        '
        'SearchProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(468, 339)
        Me.Controls.Add(Me.Grid_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "SearchProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Part Code/Product"
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

    Public ReturnType As String
    Public ReturnString As String

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click

        ClearProductList()
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

            If Me.FormType = "FGR" Or FormType = "FGW" Or FormType = "INT" Then
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
                ReturnString = dr(ReturnType)
            End If
        End If

    End Sub

    Private Sub ClearFields()
        
    End Sub

    Function ReturnStr() As String
        Return ReturnString
    End Function

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

        GridView1.Columns("Product").Width = 150
        GridView1.Columns("Desc").Width = 200
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
        'RefreshProductInfo()
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub GridView2_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.SelectionChangedEventArgs)

    End Sub

    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.SelectionChangedEventArgs) Handles GridView1.SelectionChanged

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
        RefreshProductInfo()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub LocGrid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub SearchProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub LookUpEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub PartGrid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PartGrid.KeyPress

    End Sub

    Private Sub LocGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Grid_Panel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_Panel.DoubleClick

    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        SaveButton_Click(sender, e)
        Me.DialogResult = DialogResult.OK
    End Sub
End Class
