Public Class PRItemForm
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
    Friend WithEvents ListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents DetailGrp As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CompGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents AddBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeliveryDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ProductTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QtyReqSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ActualPriceSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ActualSupplierLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PriceDateTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CurrencyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EnquiryPriceSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ReqQtySpin As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PRItemForm))
        Me.ListGrp = New System.Windows.Forms.GroupBox
        Me.CompGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DetailGrp = New System.Windows.Forms.GroupBox
        Me.PriceDateTxt = New DevExpress.XtraEditors.TextEdit
        Me.CurrencyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.EnquiryPriceSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.ActualPriceSpin = New DevExpress.XtraEditors.SpinEdit
        Me.ActualSupplierLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.SupplierText = New DevExpress.XtraEditors.TextEdit
        Me.ProductTxt = New DevExpress.XtraEditors.TextEdit
        Me.DeliveryDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.QtyReqSpin = New DevExpress.XtraEditors.SpinEdit
        Me.ReqQtySpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ListGrp.SuspendLayout()
        CType(Me.CompGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailGrp.SuspendLayout()
        CType(Me.PriceDateTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryPriceSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualPriceSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualSupplierLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyReqSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReqQtySpin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListGrp
        '
        Me.ListGrp.Controls.Add(Me.CompGrid)
        Me.ListGrp.Location = New System.Drawing.Point(8, 8)
        Me.ListGrp.Name = "ListGrp"
        Me.ListGrp.Size = New System.Drawing.Size(696, 152)
        Me.ListGrp.TabIndex = 0
        Me.ListGrp.TabStop = False
        '
        'CompGrid
        '
        Me.CompGrid.EditorsRepository = Me.PersistentRepository1
        Me.CompGrid.Location = New System.Drawing.Point(16, 16)
        Me.CompGrid.MainView = Me.GridView1
        Me.CompGrid.Name = "CompGrid"
        Me.CompGrid.Size = New System.Drawing.Size(672, 128)
        Me.CompGrid.TabIndex = 0
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
        '
        'DetailGrp
        '
        Me.DetailGrp.Controls.Add(Me.PriceDateTxt)
        Me.DetailGrp.Controls.Add(Me.CurrencyTxt)
        Me.DetailGrp.Controls.Add(Me.Label9)
        Me.DetailGrp.Controls.Add(Me.EnquiryPriceSpin)
        Me.DetailGrp.Controls.Add(Me.Label6)
        Me.DetailGrp.Controls.Add(Me.ActualPriceSpin)
        Me.DetailGrp.Controls.Add(Me.ActualSupplierLookup)
        Me.DetailGrp.Controls.Add(Me.Label11)
        Me.DetailGrp.Controls.Add(Me.SupplierText)
        Me.DetailGrp.Controls.Add(Me.ProductTxt)
        Me.DetailGrp.Controls.Add(Me.DeliveryDateEdit)
        Me.DetailGrp.Controls.Add(Me.Label8)
        Me.DetailGrp.Controls.Add(Me.QtyReqSpin)
        Me.DetailGrp.Controls.Add(Me.ReqQtySpin)
        Me.DetailGrp.Controls.Add(Me.Label5)
        Me.DetailGrp.Controls.Add(Me.Label2)
        Me.DetailGrp.Controls.Add(Me.Label1)
        Me.DetailGrp.Controls.Add(Me.Label3)
        Me.DetailGrp.Location = New System.Drawing.Point(8, 168)
        Me.DetailGrp.Name = "DetailGrp"
        Me.DetailGrp.Size = New System.Drawing.Size(696, 192)
        Me.DetailGrp.TabIndex = 1
        Me.DetailGrp.TabStop = False
        Me.DetailGrp.Text = "Item Details"
        '
        'PriceDateTxt
        '
        Me.PriceDateTxt.Enabled = False
        Me.PriceDateTxt.Location = New System.Drawing.Point(232, 40)
        Me.PriceDateTxt.Name = "PriceDateTxt"
        Me.PriceDateTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PriceDateTxt.Properties.Enabled = False
        Me.PriceDateTxt.Properties.FormatString = "dd/MM/yyyy"
        Me.PriceDateTxt.Properties.ReadOnly = True
        Me.PriceDateTxt.Size = New System.Drawing.Size(88, 19)
        Me.PriceDateTxt.TabIndex = 74
        '
        'CurrencyTxt
        '
        Me.CurrencyTxt.Enabled = False
        Me.CurrencyTxt.Location = New System.Drawing.Point(104, 40)
        Me.CurrencyTxt.Name = "CurrencyTxt"
        Me.CurrencyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrencyTxt.Properties.Enabled = False
        Me.CurrencyTxt.Properties.ReadOnly = True
        Me.CurrencyTxt.Size = New System.Drawing.Size(40, 19)
        Me.CurrencyTxt.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Price :"
        '
        'EnquiryPriceSpin
        '
        Me.EnquiryPriceSpin.Enabled = False
        Me.EnquiryPriceSpin.Location = New System.Drawing.Point(152, 40)
        Me.EnquiryPriceSpin.Name = "EnquiryPriceSpin"
        Me.EnquiryPriceSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnquiryPriceSpin.Properties.Enabled = False
        Me.EnquiryPriceSpin.Properties.ReadOnly = True
        Me.EnquiryPriceSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnquiryPriceSpin.Size = New System.Drawing.Size(72, 19)
        Me.EnquiryPriceSpin.TabIndex = 71
        Me.EnquiryPriceSpin.Text = "0"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(312, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Actual Price :"
        '
        'ActualPriceSpin
        '
        Me.ActualPriceSpin.Location = New System.Drawing.Point(408, 136)
        Me.ActualPriceSpin.Name = "ActualPriceSpin"
        Me.ActualPriceSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActualPriceSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ActualPriceSpin.Size = New System.Drawing.Size(112, 19)
        Me.ActualPriceSpin.TabIndex = 69
        Me.ActualPriceSpin.Text = "0"
        '
        'ActualSupplierLookup
        '
        Me.ActualSupplierLookup.Location = New System.Drawing.Point(104, 136)
        Me.ActualSupplierLookup.Name = "ActualSupplierLookup"
        Me.ActualSupplierLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActualSupplierLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ActualSupplierLookup.Properties.NullString = ""
        Me.ActualSupplierLookup.Size = New System.Drawing.Size(128, 19)
        Me.ActualSupplierLookup.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label11.Location = New System.Drawing.Point(8, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Actual Supplier :"
        '
        'SupplierText
        '
        Me.SupplierText.Enabled = False
        Me.SupplierText.Location = New System.Drawing.Point(104, 64)
        Me.SupplierText.Name = "SupplierText"
        Me.SupplierText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierText.Properties.Enabled = False
        Me.SupplierText.Properties.ReadOnly = True
        Me.SupplierText.Size = New System.Drawing.Size(416, 19)
        Me.SupplierText.TabIndex = 52
        '
        'ProductTxt
        '
        Me.ProductTxt.Enabled = False
        Me.ProductTxt.Location = New System.Drawing.Point(104, 16)
        Me.ProductTxt.Name = "ProductTxt"
        Me.ProductTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProductTxt.Properties.Enabled = False
        Me.ProductTxt.Properties.ReadOnly = True
        Me.ProductTxt.Size = New System.Drawing.Size(416, 19)
        Me.ProductTxt.TabIndex = 51
        '
        'DeliveryDateEdit
        '
        Me.DeliveryDateEdit.DateTime = New Date(CType(0, Long))
        Me.DeliveryDateEdit.Location = New System.Drawing.Point(104, 160)
        Me.DeliveryDateEdit.Name = "DeliveryDateEdit"
        Me.DeliveryDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliveryDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DeliveryDateEdit.Size = New System.Drawing.Size(128, 19)
        Me.DeliveryDateEdit.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Delivery Date :"
        '
        'QtyReqSpin
        '
        Me.QtyReqSpin.Location = New System.Drawing.Point(104, 88)
        Me.QtyReqSpin.Name = "QtyReqSpin"
        Me.QtyReqSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyReqSpin.Properties.Enabled = False
        Me.QtyReqSpin.Properties.ReadOnly = True
        Me.QtyReqSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyReqSpin.Size = New System.Drawing.Size(128, 19)
        Me.QtyReqSpin.TabIndex = 46
        Me.QtyReqSpin.Text = "0"
        '
        'ReqQtySpin
        '
        Me.ReqQtySpin.Location = New System.Drawing.Point(104, 112)
        Me.ReqQtySpin.Name = "ReqQtySpin"
        Me.ReqQtySpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ReqQtySpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ReqQtySpin.Size = New System.Drawing.Size(128, 19)
        Me.ReqQtySpin.TabIndex = 44
        Me.ReqQtySpin.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Request Qty :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Qty Required :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Supplier :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Product :"
        '
        'AddBtn
        '
        Me.AddBtn.AutoSize = False
        Me.AddBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Image = Nothing
        Me.AddBtn.Location = New System.Drawing.Point(544, 368)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(88, 32)
        Me.AddBtn.TabIndex = 2
        Me.AddBtn.Text = "Add Item"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(640, 368)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 64
        Me.CancelBtn.Text = "Close"
        '
        'PRItemForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(712, 405)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DetailGrp)
        Me.Controls.Add(Me.ListGrp)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PRItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Purchase Requisition Item"
        Me.ListGrp.ResumeLayout(False)
        CType(Me.CompGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailGrp.ResumeLayout(False)
        CType(Me.PriceDateTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryPriceSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualPriceSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualSupplierLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyReqSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReqQtySpin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " PRLine - Variables Initialization "

    Public Quotation_ID As Integer

    Public PR_Line As Integer
    Public PR_ID As Integer
    Public Category_ID As Integer
    Public Product_ID As Integer
    Public Product_Name As String
    Public Product_Desc As String
    Public Request_Qty As Integer
    Public Stock_Reserved As Integer
    Public Order_Qty As Integer
    Public Delivery_Date As String
    Public Supplier_ID As Integer
    Public Supplier_Name As String
    Public PO_ID As Integer
    Public PO_Line_ID As Integer
    Public Enquiry_Price As Decimal
    Public Actual_Price As Decimal
    Public Component_ID As Integer
    Public Actual_Supplier_ID As Integer
    Public Actual_Supplier_Name As String

    Public Currency As String
    Public PriceDate As String
    Public UOM As String
    Public QtyRequired As String

    Public UserID As Integer

    Public NewItem As Boolean
    Dim dataGrid = New DataTable("ColumnsTable")

    Public ParentItemGrid As DevExpress.XtraGrid.Views.Grid.GridView
    Public ActualRequest_Qty As Integer

    Public Status As String = "EDIT"

#End Region

#Region " Grid Code "

    Private Sub LoadComponentGrid()
        InitComponentList()
        LoadGrid()
        LoadSupplier()
    End Sub

    Private Sub InitComponentList()
        dataGrid.BeginInit()

        AddColumn(dataGrid, "Component_ID", System.Type.GetType("System.Int32"), True)

        AddColumn(dataGrid, "Category_ID", System.Type.GetType("System.Int32"), True)

        AddColumn(dataGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "ProductDesc", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Product_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "UOM", System.Type.GetType("System.String"), True)

        AddColumn(dataGrid, "Supplier", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Supplier_ID", System.Type.GetType("System.Int32"), True)

        AddColumn(dataGrid, "", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Unit Price", System.Type.GetType("System.Double"), True)
        AddColumn(dataGrid, "Qty", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Price Date", System.Type.GetType("System.String"), True)

        dataGrid.EndInit()

        CompGrid.DataSource = dataGrid
        CompGrid.DefaultView.PopulateColumns()
        GridView1.BestFitColumns()

        GridView1.Columns.Item(0).VisibleIndex = -1
        GridView1.Columns.Item(1).VisibleIndex = -1
        GridView1.Columns.Item(3).VisibleIndex = -1
        GridView1.Columns.Item(4).VisibleIndex = -1
        GridView1.Columns.Item(7).VisibleIndex = -1

        'Unit Price
        GridView1.Columns.Item(9).Width = 75
        'Qty
        GridView1.Columns.Item(10).Width = 45
        'Price Date
        GridView1.Columns.Item(11).Width = 70
    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub

#End Region

#Region " Database Mangement"

    Private Sub LoadGrid()

        If Quotation_ID <> Nothing And Quotation_ID <> 0 Then
            Dim ds As DataSet

            Dim Requester
            Dim Approver
            Dim Category
            Dim Status
            Dim Grp
            Dim PR_Date

            Dim countRequestQty As Integer

            With New BusinessRules.PRBusRules.PRBusLogic
                If .LoadQuotationComponent(ds, Quotation_ID) Then
                    If Not ds Is Nothing Then
                        Try

                            Dim oRow As DataRow
                            Dim i As Integer = 0
                            For Each oRow In ds.Tables(0).Rows
                                i = i + 1
                                countRequestQty = 0

                                ' YG 22.10.2003 Start
                                '                                If Not oRow("Qty") Is System.DBNull.Value And Not oRow("Component_ID") Is System.DBNull.Value Then
                                '                                    countRequestQty = oRow("Qty") - .CountOrderedQty(oRow("Component_ID"), ParentItemGrid)
                                '                                End If
                                If Not oRow("OrderQty") Is System.DBNull.Value And Not oRow("Component_ID") Is System.DBNull.Value Then
                                    countRequestQty = oRow("OrderQty") - .CountOrderedQty(oRow("Component_ID"), ParentItemGrid)
                                End If
                                ' YG 22.10.2003 End

                                'If Request qty is 0 then component is not shown
                                ' 22.10.2003 YG Start
                                '                                If countRequestQty <> 0 Then
                                '                                    dataGrid.Rows.Add(New Object() {oRow("Component_ID"), oRow("Category_ID"), _
                                '                                                        oRow("ProductName"), oRow("ProductDesc"), oRow("Product_ID"), oRow("UOM"), _
                                '                                                        oRow("SupplierName"), oRow("Supplier_ID"), _
                                '                                                        oRow("Currency"), oRow("UnitPrice"), oRow("Qty"), ChangeDateFormat(oRow("PriceDate"))})
                                '                                End If
                                If countRequestQty <> 0 Then
                                    dataGrid.Rows.Add(New Object() {oRow("Component_ID"), oRow("Category_ID"), _
                                                        oRow("ProductName"), oRow("ProductDesc"), oRow("Product_ID"), oRow("UOM"), _
                                                        oRow("SupplierName"), oRow("Supplier_ID"), _
                                                        oRow("Currency"), oRow("UnitPrice"), oRow("OrderQty"), ChangeDateFormat(oRow("PriceDate"))})
                                End If
                                ' 22.10.2003 YG End

                            Next

                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End If
                End If
            End With

        End If


        If GridView1.RowCount = 0 Then
            MessageBox.Show("Quotation is complete", "Quotation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
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

                        AddListFieldInfoToLookUp(ActualSupplierLookup, "Supplier_Name", 200, 0, "")

                        ActualSupplierLookup.Properties.LookUpData.KeyField = "Supplier_ID"
                        ActualSupplierLookup.Properties.LookUpData.DisplayField = "Supplier_Name"
                        ActualSupplierLookup.Properties.LookUpData.DataSource = ds.Tables(0)


                        ActualSupplierLookup.Properties.PopupWidth = 200

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load supplier list
    End Sub
#End Region
#Region " Event"

    'Form Load
    Private Sub PRItemForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        NewItem = False

        LoadComponentGrid()

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
        End If

        LoadComponent()

        Me.Cursor = Cursors.Default
    End Sub

    'Component Grid Click
    Private Sub CompGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompGrid.Click

        Me.Cursor = Cursors.WaitCursor

        LoadComponent()

        Me.Cursor = Cursors.Default
    End Sub

    'Button - Add Item 
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click

        GetWindowsValue()

        If ValidData() Then

            If Actual_Supplier_ID <> 0 And Actual_Supplier_ID <> Nothing Then
                If MessageBox.Show("Do you want to save the latest price", "Update Price", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    CreateNewRec()
                End If
            End If

            NewItem = True

            Dim prf As PRForm
            prf = Me.Owner.ActiveControl
            Dim pDeliveryDate As Date
            Dim tempDeliveryDate As String = ""

            If Delivery_Date <> "" Then
                tempDeliveryDate = ChangeDateFormat(Delivery_Date)
            End If

            prf.dataGrid.Rows.Add(New Object() {PR_Line, Category_ID, Product_ID, _
                                Supplier_ID, Actual_Supplier_ID, Component_ID, _
                                Product_Name, _
                                Request_Qty, 0, Request_Qty, UOM, _
                                tempDeliveryDate, _
                                Currency, _
                                Supplier_Name, Enquiry_Price, _
                                Actual_Supplier_Name, Actual_Price})

            'Close()
        End If

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

#End Region

#Region " Other Code"

    'Load Details
    Private Sub LoadComponent()

        Dim totalQtyOrdered As Integer = 0
        Dim count As Integer = 0

        If GridView1.SelectedRowsCount <> 0 Then

            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then

                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                Component_ID = items(0)
                Category_ID = items(1)
                If Not IsDBNull(items(2)) Then
                Product_Name = items(2)
                Else
                    Product_Name = Nothing
                End If
                If Not IsDBNull(items(3)) Then
                Product_Desc = items(3)
                Else
                    Product_Desc = Nothing
                End If
                Product_ID = items(4)
                If Not IsDBNull(items(5)) Then
                UOM = items(5)
                Else
                    UOM = Nothing
                End If
                If Not IsDBNull(items(6)) Then
                Supplier_Name = items(6)
                Else
                    Supplier_Name = Nothing
                End If
                Supplier_ID = items(7)
                If Not IsDBNull(items(8)) Then
                Currency = items(8)
                Else
                    Currency = Nothing
                End If
                Enquiry_Price = items(9)
                ActualRequest_Qty = items(10)
                If Not IsDBNull(items(11)) Then
                PriceDate = items(11)
                Else
                    PriceDate = Nothing
                End If

                With New BusinessRules.PRBusRules.PRBusLogic
                    count = .CountOrderedQty(Component_ID, ParentItemGrid)
                End With

                QtyRequired = items(10) - count

                If QtyRequired = 0 Then
                    AddBtn.Enabled = False
                Else
                    AddBtn.Enabled = True
                End If

                SetWindowsValue()
            End If
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

    Public Function GetProdSupplierID()

        Dim ProductSupplier_ID As Integer = 0

        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            ProductSupplier_ID = .RecordExists(Product_ID, Actual_Supplier_ID)

        End With

        GetProdSupplierID = ProductSupplier_ID

    End Function

    Public Sub CreateNewRec()
        Dim ProductSupplier_ID As Integer

        ProductSupplier_ID = GetProdSupplierID()

        Dim Catalog_Price
        Dim pEnquiry_Price
        Dim Purchase_Price

        Dim form As New ManageProdSupForm(Me.ParentForm)

        form.Product_ID = Product_ID
        form.FromPR = True
        form.Supplier_ID = Actual_Supplier_ID
        form.Enquiry_Price = Actual_Price

        form.ShowDialog()

        If form.NewItem Then
            Catalog_Price = form.Catalog_Price
            pEnquiry_Price = form.Enquiry_Price
            Purchase_Price = form.Purchase_Price

            With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
                'Update current value's HistoryRecord
                .Product_ID = Product_ID
                '                .Supplier_ID = Supplier_ID
                .Supplier_ID = Actual_Supplier_ID
                .Catalog_Price = Catalog_Price
                .Enquiry_Price = pEnquiry_Price
                .Purchase_Price = Purchase_Price
                .UserID = UserID

                If ProductSupplier_ID <> Nothing And ProductSupplier_ID <> 0 Then
                    .Update(ProductSupplier_ID)
                Else
                    .Save()
                End If

            End With
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

#Region " Code - Set/Get Window Values"

    'Set windows values
    Private Sub SetWindowsValue()

        ProductTxt.Text = Product_Desc 'Product_Name
        SupplierText.Text = Supplier_Name

        QtyReqSpin.Text = QtyRequired

        EnquiryPriceSpin.Text = Enquiry_Price

        ReqQtySpin.Properties.MaxValue = Request_Qty
        ActualPriceSpin.Properties.MaxValue = Enquiry_Price

        If Actual_Supplier_ID <> Nothing And Actual_Supplier_ID <> 0 Then
            ActualSupplierLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Actual_Supplier_ID, 0, 0, 0})
        End If

        ReqQtySpin.Text = Request_Qty

        PriceDateTxt.Text = PriceDate
        CurrencyTxt.Text = Currency

    End Sub

    'Get Window Values
    Private Sub GetWindowsValue()

        Request_Qty = ReqQtySpin.Text
        'Order_Qty = QtyToOrderSpin.Text

        If DeliveryDateEdit.Text <> "" Then
            Delivery_Date = DeliveryDateEdit.DateTime.Day & " " & MonthName(DeliveryDateEdit.DateTime.Month) & " " & DeliveryDateEdit.DateTime.Year
        Else
            Delivery_Date = ""
        End If

        If ActualSupplierLookup.Text <> "" Then
            Actual_Supplier_Name = ActualSupplierLookup.Text
            Actual_Supplier_ID = Integer.Parse(ActualSupplierLookup.Properties.LookUpData.KeyValue().ToString())
        End If

        Enquiry_Price = EnquiryPriceSpin.Text
        Actual_Price = ActualPriceSpin.Text

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If Request_Qty = 0 Then
            ErrorMessage = ErrorMessage & " Request Quantity" & Chr(13)

            MessageBox.Show("Request Quantity must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DataOK_flag = False
        Else
            If Actual_Supplier_ID <> Nothing And Actual_Supplier_ID <> 0 Then
                If Actual_Price = 0 Or Actual_Price = Nothing Then
                    MessageBox.Show("Actual Price cannot be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    DataOK_flag = False
                Else
                    If Actual_Price > Enquiry_Price Then
                        MessageBox.Show("Actual Price must be smaller than Enquiry Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If
            End If

        End If

        If QtyRequired < Request_Qty Then
            MessageBox.Show("Quantity to Order must be smaller than " & QtyRequired, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DataOK_flag = False
        End If

        Return DataOK_flag

    End Function

#End Region


End Class
