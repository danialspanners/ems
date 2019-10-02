Public Class ReserveStock
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public ReserveDate As String

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
    Friend WithEvents ItemInfoGrp As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents QtyToReserveSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CurrentAvailSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SupplierTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReservedStockBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CategoryTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ActualPriceSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EnquiryPriceSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents QtyReqSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeliveryDateTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActualQtyToOrderSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents QtyToOrderSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Product As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WarehouseArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Reserved_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StockLineGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents Stock_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReservedQtySpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Location_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UpdateBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridSupplier_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ReserveDateEdit As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReserveStock))
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ReservedQtySpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.ItemInfoGrp = New System.Windows.Forms.GroupBox
        Me.QtyToOrderSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.QtyReqSpin = New DevExpress.XtraEditors.SpinEdit
        Me.DeliveryDateTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ActualPriceSpin = New DevExpress.XtraEditors.SpinEdit
        Me.EnquiryPriceSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.CategoryTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.CurrentAvailSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.QtyToReserveSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.SupplierTxt = New DevExpress.XtraEditors.TextEdit
        Me.ActualQtyToOrderSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProductTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.ReservedStockBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.StockLineGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Stock_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Location_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Warehouse = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WarehouseArea = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Category = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Product = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Reserved_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridSupplier_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UpdateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.ReserveDateEdit = New DevExpress.XtraEditors.DateEdit
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservedQtySpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemInfoGrp.SuspendLayout()
        CType(Me.QtyToOrderSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyReqSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDateTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualPriceSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryPriceSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentAvailSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyToReserveSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualQtyToOrderSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockLineGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReserveDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.ReservedQtySpinEdit, Me.RepositoryItemSpinEdit1})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'ReservedQtySpinEdit
        '
        Me.ReservedQtySpinEdit.Name = "ReservedQtySpinEdit"
        Me.ReservedQtySpinEdit.Properties.AllowFocused = False
        Me.ReservedQtySpinEdit.Properties.AutoHeight = False
        Me.ReservedQtySpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ReservedQtySpinEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton)
        Me.ReservedQtySpinEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ReservedQtySpinEdit.Properties.UseCtrlIncrement = True
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.Properties.AllowFocused = False
        Me.RepositoryItemSpinEdit1.Properties.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemSpinEdit1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton)
        Me.RepositoryItemSpinEdit1.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemSpinEdit1.Properties.UseCtrlIncrement = True
        '
        'ItemInfoGrp
        '
        Me.ItemInfoGrp.Controls.Add(Me.ReserveDateEdit)
        Me.ItemInfoGrp.Controls.Add(Me.Label12)
        Me.ItemInfoGrp.Controls.Add(Me.QtyToOrderSpin)
        Me.ItemInfoGrp.Controls.Add(Me.Label10)
        Me.ItemInfoGrp.Controls.Add(Me.QtyReqSpin)
        Me.ItemInfoGrp.Controls.Add(Me.DeliveryDateTxt)
        Me.ItemInfoGrp.Controls.Add(Me.Label8)
        Me.ItemInfoGrp.Controls.Add(Me.Label7)
        Me.ItemInfoGrp.Controls.Add(Me.Label9)
        Me.ItemInfoGrp.Controls.Add(Me.ActualPriceSpin)
        Me.ItemInfoGrp.Controls.Add(Me.EnquiryPriceSpin)
        Me.ItemInfoGrp.Controls.Add(Me.Label11)
        Me.ItemInfoGrp.Controls.Add(Me.CategoryTxt)
        Me.ItemInfoGrp.Controls.Add(Me.Label6)
        Me.ItemInfoGrp.Controls.Add(Me.CurrentAvailSpin)
        Me.ItemInfoGrp.Controls.Add(Me.Label4)
        Me.ItemInfoGrp.Controls.Add(Me.QtyToReserveSpin)
        Me.ItemInfoGrp.Controls.Add(Me.Label2)
        Me.ItemInfoGrp.Controls.Add(Me.SupplierTxt)
        Me.ItemInfoGrp.Controls.Add(Me.ActualQtyToOrderSpin)
        Me.ItemInfoGrp.Controls.Add(Me.Label5)
        Me.ItemInfoGrp.Controls.Add(Me.Label1)
        Me.ItemInfoGrp.Controls.Add(Me.ProductTxt)
        Me.ItemInfoGrp.Controls.Add(Me.Label3)
        Me.ItemInfoGrp.Location = New System.Drawing.Point(8, 8)
        Me.ItemInfoGrp.Name = "ItemInfoGrp"
        Me.ItemInfoGrp.Size = New System.Drawing.Size(560, 200)
        Me.ItemInfoGrp.TabIndex = 23
        Me.ItemInfoGrp.TabStop = False
        Me.ItemInfoGrp.Text = "Details"
        '
        'QtyToOrderSpin
        '
        Me.QtyToOrderSpin.Enabled = False
        Me.QtyToOrderSpin.Location = New System.Drawing.Point(128, 144)
        Me.QtyToOrderSpin.Name = "QtyToOrderSpin"
        Me.QtyToOrderSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyToOrderSpin.Properties.Enabled = False
        Me.QtyToOrderSpin.Properties.ReadOnly = True
        Me.QtyToOrderSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyToOrderSpin.Size = New System.Drawing.Size(104, 19)
        Me.QtyToOrderSpin.TabIndex = 76
        Me.QtyToOrderSpin.Text = "0"
        Me.QtyToOrderSpin.Visible = False
        '
        'Label10
        '
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(16, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 32)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Qty to Order Before Stock Reserve:"
        Me.Label10.Visible = False
        '
        'QtyReqSpin
        '
        Me.QtyReqSpin.Enabled = False
        Me.QtyReqSpin.Location = New System.Drawing.Point(128, 120)
        Me.QtyReqSpin.Name = "QtyReqSpin"
        Me.QtyReqSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyReqSpin.Properties.Enabled = False
        Me.QtyReqSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyReqSpin.Size = New System.Drawing.Size(104, 19)
        Me.QtyReqSpin.TabIndex = 74
        Me.QtyReqSpin.Text = "0"
        '
        'DeliveryDateTxt
        '
        Me.DeliveryDateTxt.Location = New System.Drawing.Point(128, 72)
        Me.DeliveryDateTxt.Name = "DeliveryDateTxt"
        Me.DeliveryDateTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliveryDateTxt.Properties.Enabled = False
        Me.DeliveryDateTxt.Properties.MaxLength = 100
        Me.DeliveryDateTxt.Properties.ReadOnly = True
        Me.DeliveryDateTxt.Size = New System.Drawing.Size(104, 19)
        Me.DeliveryDateTxt.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Delivery Date :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(296, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Actual Price :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Enquiry Price :"
        '
        'ActualPriceSpin
        '
        Me.ActualPriceSpin.Location = New System.Drawing.Point(400, 48)
        Me.ActualPriceSpin.Name = "ActualPriceSpin"
        Me.ActualPriceSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActualPriceSpin.Properties.Enabled = False
        Me.ActualPriceSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ActualPriceSpin.Size = New System.Drawing.Size(104, 19)
        Me.ActualPriceSpin.TabIndex = 66
        Me.ActualPriceSpin.Text = "0"
        '
        'EnquiryPriceSpin
        '
        Me.EnquiryPriceSpin.Enabled = False
        Me.EnquiryPriceSpin.Location = New System.Drawing.Point(128, 96)
        Me.EnquiryPriceSpin.Name = "EnquiryPriceSpin"
        Me.EnquiryPriceSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnquiryPriceSpin.Properties.Enabled = False
        Me.EnquiryPriceSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnquiryPriceSpin.Size = New System.Drawing.Size(104, 19)
        Me.EnquiryPriceSpin.TabIndex = 65
        Me.EnquiryPriceSpin.Text = "0"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Qty Required :"
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(128, 48)
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CategoryTxt.Properties.Enabled = False
        Me.CategoryTxt.Properties.MaxLength = 100
        Me.CategoryTxt.Properties.ReadOnly = True
        Me.CategoryTxt.Size = New System.Drawing.Size(144, 19)
        Me.CategoryTxt.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Category :"
        '
        'CurrentAvailSpin
        '
        Me.CurrentAvailSpin.Location = New System.Drawing.Point(400, 72)
        Me.CurrentAvailSpin.Name = "CurrentAvailSpin"
        Me.CurrentAvailSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrentAvailSpin.Properties.Enabled = False
        Me.CurrentAvailSpin.Properties.ReadOnly = True
        Me.CurrentAvailSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CurrentAvailSpin.Size = New System.Drawing.Size(104, 19)
        Me.CurrentAvailSpin.TabIndex = 60
        Me.CurrentAvailSpin.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(296, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Available Stock to Reserve :"
        '
        'QtyToReserveSpin
        '
        Me.QtyToReserveSpin.Location = New System.Drawing.Point(400, 144)
        Me.QtyToReserveSpin.Name = "QtyToReserveSpin"
        Me.QtyToReserveSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyToReserveSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyToReserveSpin.Size = New System.Drawing.Size(104, 19)
        Me.QtyToReserveSpin.TabIndex = 58
        Me.QtyToReserveSpin.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(294, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Qty to Reserve :"
        '
        'SupplierTxt
        '
        Me.SupplierTxt.Location = New System.Drawing.Point(400, 24)
        Me.SupplierTxt.Name = "SupplierTxt"
        Me.SupplierTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierTxt.Properties.Enabled = False
        Me.SupplierTxt.Properties.MaxLength = 100
        Me.SupplierTxt.Properties.ReadOnly = True
        Me.SupplierTxt.Size = New System.Drawing.Size(144, 19)
        Me.SupplierTxt.TabIndex = 56
        '
        'ActualQtyToOrderSpin
        '
        Me.ActualQtyToOrderSpin.Location = New System.Drawing.Point(128, 176)
        Me.ActualQtyToOrderSpin.Name = "ActualQtyToOrderSpin"
        Me.ActualQtyToOrderSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActualQtyToOrderSpin.Properties.Enabled = False
        Me.ActualQtyToOrderSpin.Properties.ReadOnly = True
        Me.ActualQtyToOrderSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ActualQtyToOrderSpin.Size = New System.Drawing.Size(104, 19)
        Me.ActualQtyToOrderSpin.TabIndex = 55
        Me.ActualQtyToOrderSpin.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Actual Qty to Order :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label1.Location = New System.Drawing.Point(296, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Supplier :"
        '
        'ProductTxt
        '
        Me.ProductTxt.Location = New System.Drawing.Point(128, 24)
        Me.ProductTxt.Name = "ProductTxt"
        Me.ProductTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProductTxt.Properties.Enabled = False
        Me.ProductTxt.Properties.MaxLength = 100
        Me.ProductTxt.Properties.ReadOnly = True
        Me.ProductTxt.Size = New System.Drawing.Size(144, 19)
        Me.ProductTxt.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Product :"
        '
        'ReservedStockBtn
        '
        Me.ReservedStockBtn.AutoSize = False
        Me.ReservedStockBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ReservedStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservedStockBtn.Image = Nothing
        Me.ReservedStockBtn.Location = New System.Drawing.Point(384, 248)
        Me.ReservedStockBtn.Name = "ReservedStockBtn"
        Me.ReservedStockBtn.Size = New System.Drawing.Size(96, 32)
        Me.ReservedStockBtn.TabIndex = 62
        Me.ReservedStockBtn.Text = "Reserve Stock"
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
        Me.CancelBtn.Location = New System.Drawing.Point(488, 248)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 63
        Me.CancelBtn.Text = "Close"
        '
        'StockLineGrid
        '
        Me.StockLineGrid.EditorsRepository = Me.PersistentRepository1
        Me.StockLineGrid.Location = New System.Drawing.Point(24, 208)
        Me.StockLineGrid.MainView = Me.GridView1
        Me.StockLineGrid.Name = "StockLineGrid"
        Me.StockLineGrid.Size = New System.Drawing.Size(528, 32)
        Me.StockLineGrid.TabIndex = 87
        Me.StockLineGrid.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Stock_ID, Me.Location_ID, Me.Warehouse, Me.WarehouseArea, Me.Category, Me.Product, Me.Qty, Me.UOM, Me.Reserved_Qty, Me.Supplier, Me.GridSupplier_ID})
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
        'Stock_ID
        '
        Me.Stock_ID.Caption = "Stock ID"
        Me.Stock_ID.FieldName = "Stock_id"
        Me.Stock_ID.Name = "Stock_ID"
        Me.Stock_ID.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        '
        'Location_ID
        '
        Me.Location_ID.Caption = "Location ID"
        Me.Location_ID.FieldName = "Location_ID"
        Me.Location_ID.Name = "Location_ID"
        Me.Location_ID.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        '
        'Warehouse
        '
        Me.Warehouse.Caption = "Warehouse"
        Me.Warehouse.FieldName = "Warehouse"
        Me.Warehouse.Name = "Warehouse"
        Me.Warehouse.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Warehouse.VisibleIndex = 0
        '
        'WarehouseArea
        '
        Me.WarehouseArea.Caption = "Area"
        Me.WarehouseArea.FieldName = "Warehouse_Area"
        Me.WarehouseArea.Name = "WarehouseArea"
        Me.WarehouseArea.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.WarehouseArea.VisibleIndex = 1
        '
        'Category
        '
        Me.Category.Caption = "Category"
        Me.Category.FieldName = "Category_Name"
        Me.Category.Name = "Category"
        Me.Category.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        '
        'Product
        '
        Me.Product.Caption = "Product"
        Me.Product.FieldName = "Product_Name"
        Me.Product.Name = "Product"
        Me.Product.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Product.VisibleIndex = 2
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Qty.VisibleIndex = 3
        '
        'UOM
        '
        Me.UOM.Caption = "UOM"
        Me.UOM.FieldName = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.UOM.VisibleIndex = 4
        '
        'Reserved_Qty
        '
        Me.Reserved_Qty.Caption = "Reserved Qty"
        Me.Reserved_Qty.FieldName = "Reserved_Qty"
        Me.Reserved_Qty.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.Reserved_Qty.Name = "Reserved_Qty"
        Me.Reserved_Qty.VisibleIndex = 5
        '
        'Supplier
        '
        Me.Supplier.Caption = "Supplier"
        Me.Supplier.FieldName = "Supplier"
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Supplier.VisibleIndex = 6
        '
        'GridSupplier_ID
        '
        Me.GridSupplier_ID.Caption = "Supplier_ID"
        Me.GridSupplier_ID.FieldName = "Supplier_ID"
        Me.GridSupplier_ID.Name = "GridSupplier_ID"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.AutoSize = False
        Me.UpdateBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Image = Nothing
        Me.UpdateBtn.Location = New System.Drawing.Point(24, 248)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(96, 32)
        Me.UpdateBtn.TabIndex = 88
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(294, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Reserve Date"
        '
        'ReserveDateEdit
        '
        Me.ReserveDateEdit.DateTime = New Date(CType(0, Long))
        Me.ReserveDateEdit.Location = New System.Drawing.Point(400, 172)
        Me.ReserveDateEdit.Name = "ReserveDateEdit"
        Me.ReserveDateEdit.Properties.MaskData.EditMask = "##/##/####"
        Me.ReserveDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ReserveDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ReserveDateEdit.Size = New System.Drawing.Size(128, 21)
        Me.ReserveDateEdit.TabIndex = 78
        '
        'ReserveStock
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(576, 293)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.StockLineGrid)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ReservedStockBtn)
        Me.Controls.Add(Me.ItemInfoGrp)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReserveStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserve Stock for PR"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservedQtySpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemInfoGrp.ResumeLayout(False)
        CType(Me.QtyToOrderSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyReqSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDateTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualPriceSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryPriceSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentAvailSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyToReserveSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualQtyToOrderSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockLineGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReserveDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " PRLine Variable Initialization"

    Public PR_ID As Integer
    Public PR_Line As Integer
    Public Quotation_NO As String

    Public Category_ID As Integer
    Public Category_Name As String
    Public Product_ID As Integer
    Public Product_Name As String
    Public Supplier_ID As Integer
    Public Supplier_Name As String

    Public Request_Qty As Integer
    Public Stock_Reserved As Integer
    Public Order_Qty As Integer

    Public Delivery_Date As String
    Public Enquiry_Price As Decimal
    Public Actual_Price As Decimal

    Public Component_ID As Integer
    Public UserID As String = Common.CommonConn.Config.USERID

    Private CurrentAvailStock As Integer
    Private ActualStockToOrder As Integer
    Private OriginalStock_Reserved As Integer

    Public SaveRecord As Boolean
    Public Stockds As DataSet

    '  13.11.2003 YG Start
    Dim tmpReserve_Qty As Integer
    Dim tmpStock_ID As Integer
    Dim tmpOrder_Qty As Integer


#End Region

#Region " Event "

    'Load Form
    Private Sub ReserveStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        LoadFrmDB()
        LoadStockList(Product_ID)

        SaveRecord = False

        Me.Cursor = Cursors.Default
    End Sub

    'Qty To Reserve Key up
    Private Sub QtyToReserveSpin_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QtyToReserveSpin.KeyUp


    End Sub

    Private Sub ReservedStockBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservedStockBtn.Click
        GetWindowsValue()

        'If Stock_Reserved <> OriginalStock_Reserved Then
        If ValidData() Then
            'Save reserve stock
            '                SaveReserveStock()
            'update PRLine

            UpdatePRLine()

            SaveRecord = True
            MessageBox.Show("Stock reserved successfully")
            Close()
        End If
        '        Else
        '            Close()
        'End If

    End Sub

#End Region

#Region "Database Management"

    Private Sub LoadFrmDB()

        If PR_Line <> Nothing And PR_Line <> 0 Then
            With New BusinessRules.PRBusRules.PRLineBusLogic
                If .Load(PR_Line) Then
                    PR_ID = .PR_ID
                    Category_ID = .Category_ID
                    Product_ID = .Product_ID
                    Supplier_ID = .Supplier_ID

                    Request_Qty = .Request_Qty
                    Order_Qty = .Order_Qty
                    Stock_Reserved = .Stock_Reserved
                    ReserveDate = .ReserveDate

                    Delivery_Date = ChangeDateFormat(.Delivery_Date)

                    Enquiry_Price = .Enquiry_Price
                    Actual_Price = .Actual_Price

                    Component_ID = .Component_ID

                    Category_Name = .Category_Name
                    Product_Name = .Product_Name
                    Supplier_Name = .Supplier_Name

                    UserID = .UserID

                    ActualStockToOrder = Order_Qty + Stock_Reserved
                    OriginalStock_Reserved = Stock_Reserved

                End If
            End With

            CurrentAvailStock = CountAvailStock()

            SetWindowsValue()
        End If
    End Sub

    Private Sub LoadStockList(ByVal pProduct_ID As String)
        With New BusinessRules.BusRules.InventoryBusLogic
            .Product_ID = Product_ID
            If .GetStockLine_Display(Stockds, Product_ID) Then
                StockLineGrid.DataSource = Stockds.Tables(0).DefaultView
                If Stockds.Tables(0).Rows.Count() = 0 Then
                    ReservedStockBtn.Enabled = False
                End If
                If Stockds.Tables(0).Rows.Count() > 0 Then
                    ReservedStockBtn.Enabled = True
                End If
            End If
        End With

    End Sub

    Private Sub SaveReserveStock(ByVal pQty As String)

        'Save ReservedStock
        With New BusinessRules.ReservedStockRules.ReservedStockLogic

            .Category_ID = Category_ID
            .Product_ID = Product_ID
            .Supplier_ID = Supplier_ID
            .Qty = pQty
            .ReserveDate = ReserveDate
            .PR_Line = PR_Line
            .Component_ID = Component_ID
            .Order_Confirmation_NO = Quotation_NO
            .UserID = UserID

            .SaveReservedStock()

        End With

        'With New BusinessRules.StockRules.StockLogic
        ' 15.11.2003 YG Start
        '.Stock_ID = tmpStock_ID
        '.UpdateStock(pQty)
        'End With

    End Sub


    '    Private Sub SaveReserveStock()

    '        'Save ReservedStock
    '        With New BusinessRules.ReservedStockRules.ReservedStockLogic

    '            .DeletePRLine(PR_Line)
    '
    '            .Category_ID = Category_ID
    '            .Product_ID = Product_ID
    '            .Supplier_ID = Supplier_ID
    '            .Qty = Stock_Reserved
    '            .PR_Line = PR_Line
    '            .Component_ID = Component_ID
    '            .Order_Confirmation_NO = Quotation_NO
    '            .UserID = UserID
    '
    '            If Stock_Reserved <> 0 Then
    '            .Save()
    '            End If

    '        End With
    '        'Update PRLine
    '    End Sub

    Private Sub UpdatePRLine()

        'Save ReservedStock
        With New BusinessRules.PRBusRules.PRLineBusLogic
            ' 17.11.2003 YG Start
            '            .Order_Qty = Order_Qty
            '.Order_Qty = QtyToReserveSpin.Text - tmpReserve_Qty

            tmpReserve_Qty = Me.Stock_Reserved
            .Order_Qty = Me.ActualStockToOrder - tmpReserve_Qty
            .Stock_Reserved = tmpReserve_Qty
            .ReserveDate = ReserveDate
            .UpdateReserveStock(PR_Line)

        End With
        'Update PRLine
    End Sub

#End Region

#Region " Other Code "

    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then
            If pInputDate.ToString <> "" Then
                pDate = Date.Parse(pInputDate)
                tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
            End If
        End If

        Return tempsDate

    End Function

    Private Function CountAvailStock()
        Dim avail As Integer = 0

        With New BusinessRules.ReservedStockRules.ReservedStockLogic
            avail = .ComputeAvailStock(Category_ID, Product_ID)
        End With

        Return avail

    End Function

#End Region

#Region " Code - Set/Get Window Values"

    'Set windows values
    Private Sub SetWindowsValue()

        ProductTxt.Text = Product_Name

        CategoryTxt.Text = Category_Name

        SupplierTxt.Text = Supplier_Name

        'Delivery Date
        DeliveryDateTxt.Text = Delivery_Date

        'Enquiry Price
        EnquiryPriceSpin.Text = Enquiry_Price

        'Actual Price
        ActualPriceSpin.Text = Actual_Price

        'Qty Required
        QtyReqSpin.Text = Request_Qty

        'Qty to order before stock reserve
        QtyToOrderSpin.Text = ActualStockToOrder

        'Actual Qty To Order
        ActualQtyToOrderSpin.Text = Order_Qty

        'Qty To Reserve
        QtyToReserveSpin.Text = OriginalStock_Reserved

        If ReserveDate = "" Then
            Me.ReserveDateEdit.DateTime = Nothing
        Else
            Me.ReserveDateEdit.DateTime = ReserveDate
        End If

        'Available Stock to Reserve
        CurrentAvailSpin.Text = CurrentAvailStock

        QtyToReserveSpin.Properties.MaxValue = ActualStockToOrder
    End Sub

    'Get Window Values
    Private Sub GetWindowsValue()

        
        If QtyToReserveSpin.Text = "" Then
            Stock_Reserved = 0
            Order_Qty = ActualStockToOrder

            QtyToReserveSpin.Text = Stock_Reserved

            ActualQtyToOrderSpin.Text = Order_Qty
        Else
            Stock_Reserved = QtyToReserveSpin.Text

            Order_Qty = ActualQtyToOrderSpin.Text
        End If


        If Me.ReserveDateEdit.Text <> "" And Stock_Reserved <> 0 Then
            ReserveDate = ReserveDateEdit.DateTime.Day & " " & MonthName(ReserveDateEdit.DateTime.Month) & " " & ReserveDateEdit.DateTime.Year
        Else
            ReserveDate = ""
        End If

    End Sub

#End Region


#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean

        DataOK_flag = True

        'ActualStockToOrder = Order_Qty + Stock_Reserved
        'OriginalStock_Reserved = Stock_Reserved

        If ActualStockToOrder < Stock_Reserved Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show("Stock reserve cannot be greater than " & ActualStockToOrder, "Error - Exceed Order Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
            DataOK_flag = False
        End If

        Return DataOK_flag

    End Function

#End Region

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        GetWindowsValue()

        If ValidReservedStockdata() Then
            If tmpReserve_Qty > 0 Then
                'Save reserve stock
                GridView1.CloseEditor()
                GridView1.UpdateCurrentRow()
                For i As Integer = 0 To Stockds.Tables(0).Rows.Count - 1
                    If Char.IsNumber(Stockds.Tables(0).Rows(i)("Reserved_Qty").ToString()) And Stockds.Tables(0).Rows(i)("Reserved_Qty") > 0 Then
                        'Supplier_ID = Stockds.Tables(0).Rows(i)("Supplier_ID")
                        tmpStock_ID = Stockds.Tables(0).Rows(i)("Stock_ID")
                        SaveReserveStock(Stockds.Tables(0).Rows(i)("Reserved_Qty").ToString())
                    Else
                        GridView1.CancelUpdateCurrentRow()
                    End If
                Next

                'update PRLine
                UpdatePRLine()

                SaveRecord = True
                MessageBox.Show("Stock reserved successfully")
                Close()
            End If
        Else
            Close()
        End If
    End Sub

    Private Function ValidReservedStockdata() As Boolean
        Dim ErrorMessage As String
        Dim ReservedQtyOK_Flag As Boolean = True

        tmpReserve_Qty = 0
        ErrorMessage = ""
        tmpOrder_Qty = ActualQtyToOrderSpin.Text
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()
        With New BusinessRules.BusRules.InventoryBusLogic
            For i As Integer = 0 To Stockds.Tables(0).Rows.Count - 1
                If Char.IsNumber(Stockds.Tables(0).Rows(i)("Reserved_Qty").ToString()) And Stockds.Tables(0).Rows(i)("Reserved_Qty") > 0 Then
                    If Stockds.Tables(0).Rows(i)("Reserved_Qty") > Stockds.Tables(0).Rows(i)("Qty") Then
                        ErrorMessage = ErrorMessage & "Reserved Qty at Row " & i + 1 & " greater than Available Qty" & Chr(13)
                        ReservedQtyOK_Flag = False
                    Else
                        tmpReserve_Qty = tmpReserve_Qty + Stockds.Tables(0).Rows(i)("Reserved_Qty")
                    End If
                Else
                    GridView1.CancelUpdateCurrentRow()
                End If
            Next
            If Not ReservedQtyOK_Flag Then
                With New Common.CommonError.ErrorMsg
                    MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End With
            Else
                If tmpReserve_Qty > tmpOrder_Qty Then
                    With New Common.CommonError.ErrorMsg
                        ReservedQtyOK_Flag = False
                        ErrorMessage = "Reserved Quantity too high" & Chr(13)
                        MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End With
                End If
            End If
        End With
        Return ReservedQtyOK_Flag
    End Function


    Private Sub QtyToReserveSpin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyToReserveSpin.LostFocus
        If QtyToReserveSpin.Text <> "" Then
            If QtyToReserveSpin.Text < 0 Then
                QtyToReserveSpin.Text = 0
            End If

            'ActualStockToOrder = Order_Qty + Stock_Reserved
            'OriginalStock_Reserved = Stock_Reserved

            'Stock reserve cannot be greater than available stock + original stock reserve
            ' Temp not using
            'If QtyToReserveSpin.Text > (CurrentAvailStock + OriginalStock_Reserved) Then
            'QtyToReserveSpin.Text = OriginalStock_Reserved
            'End If

        'Stock reserved cannot be greater than order quantity
        If ActualStockToOrder < QtyToReserveSpin.Text Then
            QtyToReserveSpin.Text = Order_Qty
        End If

        'Aft checking, compute the actual qty to order
        ActualQtyToOrderSpin.Text = ActualStockToOrder - QtyToReserveSpin.Text

        End If
    End Sub
End Class
