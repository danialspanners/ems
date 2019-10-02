Public Class StockOutWOForm
    Inherits System.Windows.Forms.Form

#Region " Declare Public Variables"
    Public data As System.Data.DataTable

    Public WO_ID As Integer = 0
    Public WO_Component_ID As Integer = 0
    Public Stock_ID As Integer = 0
    Public ReservedStock_ID As Integer = 0
    Public Supplier_ID As Integer = 0
    Public Category_ID As Integer = 0
    Public Product_ID As Integer = 0
    Public UOM_ID As Integer = 0
    Public WH_ID As Integer = 0
    Public WHA_ID As Integer = 0
    Public Location_ID As Integer = 0
    Public CmbWH_ID As Integer = 0
    Public CmbWHA_ID As Integer = 0
    Public CmbLocation_ID As Integer = 0
    Public AllowedQty As Integer = 0
    Public WOLCQty As Integer = 0
    Public BalanceQty As Integer = 0
    Public StockOutQty As Integer = 0
    Public ReservedQty As Integer = 0
    Public OrigReservedQty As Integer = 0
    Public InStoreQty As Integer = 0
    Public LooseQty As Integer = 0
    Public AccessCount As Integer = 0
    Public SaveCount As Integer = 0

    Public WO_No As String
    Public Confirm_Quotation_No As String
    Public UserID As String = Common.CommonConn.Config.USERID
    Public Transaction_Type As String = "Stock Out"
    Public StockOutType As String = "By WO"
    Public Order_Type As String = "WO"

    Public ValidationStatus As Boolean = False
    Public SaveProcessCompleted As Boolean = False
#End Region

#Region " Windows Form Designer generated code "
    Public Sub New(Optional ByVal pWO_No As String = "", _
                    Optional ByVal pWO_ID As Integer = 0, _
                    Optional ByVal pConfirm_Quotation_No As String = "")
        MyBase.New()

        If Not pWO_No = "" Or Not pWO_ID = 0 Or Not pConfirm_Quotation_No = "" Then
            WO_No = pWO_No
            WO_ID = pWO_ID
            Confirm_Quotation_No = pConfirm_Quotation_No
        End If

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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtProductNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCategoryNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStockOutQty As System.Windows.Forms.Label
    Friend WithEvents lblProductNm As System.Windows.Forms.Label
    Friend WithEvents lblCategoryNm As System.Windows.Forms.Label
    Friend WithEvents lblRefNO As System.Windows.Forms.Label
    Friend WithEvents txtUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtRefNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdLine As DevExpress.XtraGrid.GridControl
    Friend WithEvents StockOutBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents lookupArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookupWarehouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents txtReservedQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalStockOutQty As System.Windows.Forms.Label
    Friend WithEvents txtTotalStockOutQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLooseQty As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.StockOutBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblTotalStockOutQty = New System.Windows.Forms.Label
        Me.txtTotalStockOutQty = New DevExpress.XtraEditors.TextEdit
        Me.txtLooseQty = New DevExpress.XtraEditors.TextEdit
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lookupArea = New DevExpress.XtraEditors.LookUpEdit
        Me.lookupWarehouse = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtUOM = New DevExpress.XtraEditors.TextEdit
        Me.lblUOM = New System.Windows.Forms.Label
        Me.txtArea = New DevExpress.XtraEditors.TextEdit
        Me.txtWarehouse = New DevExpress.XtraEditors.TextEdit
        Me.lblWarehouse = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtStockOutDt = New DevExpress.XtraEditors.TextEdit
        Me.lblStockOutDt = New System.Windows.Forms.Label
        Me.txtReservedQty = New DevExpress.XtraEditors.TextEdit
        Me.grdLine = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtProductNm = New DevExpress.XtraEditors.TextEdit
        Me.txtCategoryNm = New DevExpress.XtraEditors.TextEdit
        Me.txtRefNO = New DevExpress.XtraEditors.TextEdit
        Me.lblStockOutQty = New System.Windows.Forms.Label
        Me.lblProductNm = New System.Windows.Forms.Label
        Me.lblCategoryNm = New System.Windows.Forms.Label
        Me.lblRefNO = New System.Windows.Forms.Label
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit
        Me.lblSupplier = New System.Windows.Forms.Label
        Me.txtHeight = New DevExpress.XtraEditors.TextEdit
        Me.txtColumn = New DevExpress.XtraEditors.TextEdit
        Me.txtRow = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTotalStockOutQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLooseQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockOutDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReservedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(496, 496)
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
        Me.StockOutBtn.Location = New System.Drawing.Point(416, 496)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalStockOutQty)
        Me.GroupBox1.Controls.Add(Me.txtTotalStockOutQty)
        Me.GroupBox1.Controls.Add(Me.txtLooseQty)
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Controls.Add(Me.lookupArea)
        Me.GroupBox1.Controls.Add(Me.lookupWarehouse)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.txtUOM)
        Me.GroupBox1.Controls.Add(Me.lblUOM)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.txtWarehouse)
        Me.GroupBox1.Controls.Add(Me.lblWarehouse)
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.txtStockOutDt)
        Me.GroupBox1.Controls.Add(Me.lblStockOutDt)
        Me.GroupBox1.Controls.Add(Me.txtReservedQty)
        Me.GroupBox1.Controls.Add(Me.grdLine)
        Me.GroupBox1.Controls.Add(Me.txtProductNm)
        Me.GroupBox1.Controls.Add(Me.txtCategoryNm)
        Me.GroupBox1.Controls.Add(Me.txtRefNO)
        Me.GroupBox1.Controls.Add(Me.lblStockOutQty)
        Me.GroupBox1.Controls.Add(Me.lblProductNm)
        Me.GroupBox1.Controls.Add(Me.lblCategoryNm)
        Me.GroupBox1.Controls.Add(Me.lblRefNO)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 464)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        '
        'lblTotalStockOutQty
        '
        Me.lblTotalStockOutQty.Location = New System.Drawing.Point(352, 368)
        Me.lblTotalStockOutQty.Name = "lblTotalStockOutQty"
        Me.lblTotalStockOutQty.Size = New System.Drawing.Size(112, 16)
        Me.lblTotalStockOutQty.TabIndex = 114
        Me.lblTotalStockOutQty.Text = "Total Stock Out Qty :"
        '
        'txtTotalStockOutQty
        '
        Me.txtTotalStockOutQty.Location = New System.Drawing.Point(464, 368)
        Me.txtTotalStockOutQty.Name = "txtTotalStockOutQty"
        Me.txtTotalStockOutQty.Size = New System.Drawing.Size(80, 21)
        Me.txtTotalStockOutQty.TabIndex = 113
        '
        'txtLooseQty
        '
        Me.txtLooseQty.Location = New System.Drawing.Point(464, 344)
        Me.txtLooseQty.Name = "txtLooseQty"
        Me.txtLooseQty.Size = New System.Drawing.Size(80, 21)
        Me.txtLooseQty.TabIndex = 112
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(16, 408)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(520, 40)
        Me.lblInfo.TabIndex = 111
        Me.lblInfo.UseMnemonic = False
        '
        'lookupArea
        '
        Me.lookupArea.Location = New System.Drawing.Point(264, 344)
        Me.lookupArea.Name = "lookupArea"
        Me.lookupArea.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupArea.Properties.NullString = ""
        Me.lookupArea.Properties.PopupWidth = 152
        Me.lookupArea.Size = New System.Drawing.Size(104, 21)
        Me.lookupArea.TabIndex = 110
        '
        'lookupWarehouse
        '
        Me.lookupWarehouse.Location = New System.Drawing.Point(96, 344)
        Me.lookupWarehouse.Name = "lookupWarehouse"
        Me.lookupWarehouse.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupWarehouse.Properties.NullString = ""
        Me.lookupWarehouse.Properties.PopupWidth = 152
        Me.lookupWarehouse.Size = New System.Drawing.Size(104, 21)
        Me.lookupWarehouse.TabIndex = 109
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 296)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(448, 21)
        Me.txtDescription.TabIndex = 106
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(28, 296)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(72, 16)
        Me.lblDescription.TabIndex = 105
        Me.lblDescription.Text = "Description :"
        '
        'txtUOM
        '
        Me.txtUOM.Location = New System.Drawing.Point(464, 272)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(80, 21)
        Me.txtUOM.TabIndex = 104
        '
        'lblUOM
        '
        Me.lblUOM.Location = New System.Drawing.Point(424, 272)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(40, 16)
        Me.lblUOM.TabIndex = 103
        Me.lblUOM.Text = "UOM :"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(264, 320)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(104, 21)
        Me.txtArea.TabIndex = 102
        '
        'txtWarehouse
        '
        Me.txtWarehouse.Location = New System.Drawing.Point(96, 320)
        Me.txtWarehouse.Name = "txtWarehouse"
        Me.txtWarehouse.Size = New System.Drawing.Size(104, 21)
        Me.txtWarehouse.TabIndex = 101
        '
        'lblWarehouse
        '
        Me.lblWarehouse.Location = New System.Drawing.Point(26, 336)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(72, 16)
        Me.lblWarehouse.TabIndex = 93
        Me.lblWarehouse.Text = "Warehouse :"
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(226, 336)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 94
        Me.lblArea.Text = "Area :"
        '
        'txtStockOutDt
        '
        Me.txtStockOutDt.Location = New System.Drawing.Point(96, 248)
        Me.txtStockOutDt.Name = "txtStockOutDt"
        Me.txtStockOutDt.Size = New System.Drawing.Size(104, 21)
        Me.txtStockOutDt.TabIndex = 92
        '
        'lblStockOutDt
        '
        Me.lblStockOutDt.Location = New System.Drawing.Point(8, 248)
        Me.lblStockOutDt.Name = "lblStockOutDt"
        Me.lblStockOutDt.Size = New System.Drawing.Size(88, 16)
        Me.lblStockOutDt.TabIndex = 91
        Me.lblStockOutDt.Text = "Stock Out Date :"
        '
        'txtReservedQty
        '
        Me.txtReservedQty.Location = New System.Drawing.Point(464, 320)
        Me.txtReservedQty.Name = "txtReservedQty"
        Me.txtReservedQty.Size = New System.Drawing.Size(80, 21)
        Me.txtReservedQty.TabIndex = 87
        '
        'grdLine
        '
        Me.grdLine.EditorsRepository = Me.PersistentRepository1
        Me.grdLine.Location = New System.Drawing.Point(8, 14)
        Me.grdLine.MainView = Me.GridView1
        Me.grdLine.Name = "grdLine"
        Me.grdLine.Size = New System.Drawing.Size(535, 216)
        Me.grdLine.TabIndex = 90
        Me.grdLine.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        '
        'txtProductNm
        '
        Me.txtProductNm.Location = New System.Drawing.Point(264, 272)
        Me.txtProductNm.Name = "txtProductNm"
        Me.txtProductNm.Size = New System.Drawing.Size(144, 21)
        Me.txtProductNm.TabIndex = 85
        '
        'txtCategoryNm
        '
        Me.txtCategoryNm.Location = New System.Drawing.Point(96, 272)
        Me.txtCategoryNm.Name = "txtCategoryNm"
        Me.txtCategoryNm.Size = New System.Drawing.Size(104, 21)
        Me.txtCategoryNm.TabIndex = 84
        '
        'txtRefNO
        '
        Me.txtRefNO.Location = New System.Drawing.Point(264, 248)
        Me.txtRefNO.Name = "txtRefNO"
        Me.txtRefNO.Size = New System.Drawing.Size(104, 21)
        Me.txtRefNO.TabIndex = 83
        '
        'lblStockOutQty
        '
        Me.lblStockOutQty.Location = New System.Drawing.Point(380, 336)
        Me.lblStockOutQty.Name = "lblStockOutQty"
        Me.lblStockOutQty.Size = New System.Drawing.Size(88, 16)
        Me.lblStockOutQty.TabIndex = 82
        Me.lblStockOutQty.Text = "Stock Out Qty :"
        '
        'lblProductNm
        '
        Me.lblProductNm.Location = New System.Drawing.Point(212, 272)
        Me.lblProductNm.Name = "lblProductNm"
        Me.lblProductNm.Size = New System.Drawing.Size(56, 16)
        Me.lblProductNm.TabIndex = 80
        Me.lblProductNm.Text = "Product :"
        '
        'lblCategoryNm
        '
        Me.lblCategoryNm.Location = New System.Drawing.Point(34, 272)
        Me.lblCategoryNm.Name = "lblCategoryNm"
        Me.lblCategoryNm.Size = New System.Drawing.Size(64, 16)
        Me.lblCategoryNm.TabIndex = 79
        Me.lblCategoryNm.Text = "Category  :"
        '
        'lblRefNO
        '
        Me.lblRefNO.Location = New System.Drawing.Point(212, 248)
        Me.lblRefNO.Name = "lblRefNO"
        Me.lblRefNO.Size = New System.Drawing.Size(56, 16)
        Me.lblRefNO.TabIndex = 78
        Me.lblRefNO.Text = "WO NO :"
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(640, 400)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(192, 21)
        Me.txtSupplier.TabIndex = 108
        Me.txtSupplier.Visible = False
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(584, 400)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(56, 16)
        Me.lblSupplier.TabIndex = 107
        Me.lblSupplier.Text = "Supplier :"
        Me.lblSupplier.Visible = False
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(688, 344)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(32, 21)
        Me.txtHeight.TabIndex = 100
        Me.txtHeight.Visible = False
        '
        'txtColumn
        '
        Me.txtColumn.Location = New System.Drawing.Point(648, 344)
        Me.txtColumn.Name = "txtColumn"
        Me.txtColumn.Size = New System.Drawing.Size(32, 21)
        Me.txtColumn.TabIndex = 99
        Me.txtColumn.Visible = False
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(608, 344)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(32, 21)
        Me.txtRow.TabIndex = 98
        Me.txtRow.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(688, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Height"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(648, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Col"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(608, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Row"
        Me.Label1.Visible = False
        '
        'StockOutWOForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(760, 526)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.StockOutBtn)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtColumn)
        Me.Name = "StockOutWOForm"
        Me.Text = "Stock Out (Based on WO)"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtTotalStockOutQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLooseQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockOutDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReservedQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Form load"
    Private Sub StockOutWOForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        DisableFields()
        PopulateGrid()
        txtStockOutDt.Text = Date.Today
        txtRefNO.Text = WO_No

        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region " Functions for Form Fields"
    'Set All Fields to Default Values
    Private Sub ClearFields()
        txtCategoryNm.Text = ""
        txtProductNm.Text = ""
        txtUOM.Text = ""
        txtDescription.Text = ""
        txtSupplier.Text = ""
        txtReservedQty.Text = ""
        txtLooseQty.Text = ""
        txtTotalStockOutQty.Text = ""
        txtWarehouse.Text = ""
        txtArea.Text = ""
        txtRow.Text = ""
        txtColumn.Text = ""
        txtHeight.Text = ""
        lblInfo.Text = ""
        lookupWarehouse.Properties.LookUpData.DataSource = Nothing
        lookupArea.Properties.LookUpData.DataSource = Nothing
        CmbWH_ID = 0
        CmbWHA_ID = 0
        CmbLocation_ID = 0
    End Sub

    Private Sub DisableFields()
        txtStockOutDt.Enabled = False
        txtRefNO.Enabled = False
        txtCategoryNm.Enabled = False
        txtProductNm.Enabled = False
        txtUOM.Enabled = False
        txtDescription.Enabled = False
        txtSupplier.Enabled = False
        txtWarehouse.Enabled = False
        txtArea.Enabled = False
        txtRow.Enabled = False
        txtColumn.Enabled = False
        txtHeight.Enabled = False
        txtReservedQty.Enabled = False
        lookupWarehouse.Enabled = False
        lookupArea.Enabled = False
        txtLooseQty.Enabled = False
        txtTotalStockOutQty.Enabled = False
        StockOutBtn.Enabled = False
    End Sub
#End Region

#Region " Component Grid Function "
    Public Sub PopulateGrid()
        Dim ds As DataSet

        grdLine.DataSource = Nothing

        AccessCount = AccessCount + 1
        With New BusinessRules.BusRules.InventoryBusLogic
            .WO_ID = WO_ID
            ds = .GetWOC()

            If Not ds Is Nothing Then
                InitGrid()

                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {i, oRow("WO_Component_ID"), oRow("Category_ID"), oRow("Product_ID"), oRow("Supplier_ID"), oRow("UOM_ID"), oRow("Category"), oRow("Product"), oRow("Des"), oRow("Supplier_Name"), oRow("Qty"), oRow("BalanceQty")})
                Next

                grdLine.DataSource = Data
                grdLine.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide ComponentID column
                GridView1.Columns.Item(2).VisibleIndex = -1 'hide CategoryID column
                GridView1.Columns.Item(3).VisibleIndex = -1 'hide ProductID column
                GridView1.Columns.Item(4).VisibleIndex = -1 'hide SupplierID column
                GridView1.Columns.Item(5).VisibleIndex = -1 'hide UOMID column
                GridView1.Columns.Item(10).VisibleIndex = -1 'hide Qty column
                'GridView1.Columns.Item(7).VisibleIndex = -1 'hide Supplier column
                'GridView1.Columns.Item(8).VisibleIndex = -1 'hide OrderQty column
                'GridView1.Columns.Item(9).VisibleIndex = -1 'hide ConfirmQty column
            Else
                GridView1.Columns.Clear()
            End If
        End With
    End Sub

    Private Sub InitGrid()
        Data = New DataTable("ColumnsTable")
        Data.BeginInit()
        AddColumn(Data, "S/No", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Component ID", System.Type.GetType("System.Int16"), True)
        AddColumn(Data, "Category ID", System.Type.GetType("System.Int16"), True)
        AddColumn(Data, "Product ID", System.Type.GetType("System.Int16"), True)
        AddColumn(Data, "Supplier ID", System.Type.GetType("System.Int16"), True)
        AddColumn(Data, "UOM ID", System.Type.GetType("System.Int16"), True)
        AddColumn(Data, "Category Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Product Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(Data, "Supplier Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "WOLC Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Balance Qty", System.Type.GetType("System.Int16"), True)
        Data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Sub grdLine_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdLine.MouseUp
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
        Dim SelectedIndex As Integer
        Dim dsUOM As DataSet
        Dim ds As DataSet

        txtCategoryNm.Text = drow.Item("Category Name")
        txtProductNm.Text = drow.Item("Product Name")
        txtDescription.Text = drow.Item("Description")
        txtReservedQty.Text = 0
        txtLooseQty.Text = 0
        txtTotalStockOutQty.Text = 0
        txtSupplier.Text = drow.Item("Supplier Name")
        WO_Component_ID = CInt(drow.Item("Component ID"))
        UOM_ID = CInt(drow.Item("UOM ID"))
        Supplier_ID = CInt(drow.Item("Supplier ID"))
        Category_ID = CInt(drow.Item("Category ID"))
        Product_ID = CInt(drow.Item("Product ID"))
        WOLCQty = CInt(drow.Item("WOLC Qty"))
        BalanceQty = CInt(drow.Item("Balance Qty"))
        txtTotalStockOutQty.Enabled = True
        'txtLooseQty.Enabled = True
        StockOutBtn.Enabled = True
        AllowedQty = BalanceQty
        lookupWarehouse.Properties.LookUpData.DataSource = Nothing
        lookupArea.Properties.LookUpData.DataSource = Nothing

        With New BusinessRules.BusRules.InventoryBusLogic
            .UOM_ID = UOM_ID
            dsUOM = .GetUOM
            If Not dsUOM Is Nothing Then
                txtUOM.Text = dsUOM.Tables(0).Rows(0).Item("Unit")
            Else
                txtUOM.Text = ""
            End If

            .Product_ID = Product_ID
            .Supplier_ID = Supplier_ID
            .Confirm_Quotation_No = Confirm_Quotation_No
            '.WO_No = WO_No
            ds = .GetReservedStockLoc
            If Not ds Is Nothing Then
                lblInfo.Text = ""
                WH_ID = CInt(ds.Tables(0).Rows(0).Item("Warehouse_ID"))
                WHA_ID = CInt(ds.Tables(0).Rows(0).Item("Warehouse_Area_ID"))
                Location_ID = CInt(ds.Tables(0).Rows(0).Item("Location_ID"))
                ReservedStock_ID = CInt(ds.Tables(0).Rows(0).Item("ReservedStock_ID"))
                OrigReservedQty = CInt(ds.Tables(0).Rows(0).Item("Qty"))
                ReservedQty = OrigReservedQty
                txtWarehouse.Text = ds.Tables(0).Rows(0).Item("Warehouse")
                txtArea.Text = ds.Tables(0).Rows(0).Item("Warehouse_Area")
                txtReservedQty.Text = ReservedQty
                txtTotalStockOutQty.Text = txtReservedQty.Text
            Else
                lblInfo.Text = "No stock is reserved for the selected item for this Work Order."
                lblInfo.Text = lblInfo.Text & " Please select warehouse and area to stock out from."
                txtWarehouse.Text = ""
                txtArea.Text = ""
                WH_ID = 0
                WHA_ID = 0
                Location_ID = 0
                ReservedStock_ID = 0
                OrigReservedQty = 0
                ReservedQty = 0
                StockOutQty = 0
            End If
            If OrigReservedQty = AllowedQty Then
                CmbWH_ID = 0
                CmbWHA_ID = 0
                CmbLocation_ID = 0
                lookupWarehouse.Enabled = False
                lookupArea.Enabled = False
                'txtLooseQty.Enabled = False
            Else
                LoadWarehouse()
                CmbWH_ID = 0
                CmbWHA_ID = 0
                CmbLocation_ID = 0
                lookupWarehouse.Enabled = True
                lookupArea.Enabled = True
                'txtLooseQty.Enabled = True
            End If
        End With
    End Sub
#End Region

#Region " Load Warehouse, Area and Location Combo"
    'Load list of warehouse to combo
    Private Sub LoadWarehouse()
        Dim dsWarehouse As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Product_ID = Product_ID
            .WOLCQty = WOLCQty
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
            .Transaction_Type = Transaction_Type
            .Product_ID = Product_ID
            .WH_ID = CmbWH_ID
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

    Private Sub ObtainLocation()
        Dim dsLocation As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = CmbWH_ID
            .WHA_ID = CmbWHA_ID
            dsLocation = .GetWarehouseLocation
            If Not dsLocation Is Nothing Then
                If dsLocation.Tables(0).Rows.Count > 0 Then
                    CmbLocation_ID = CInt(dsLocation.Tables(0).Rows(0).Item("Location_ID"))
                Else
                    CmbLocation_ID = 0
                End If
            Else
                CmbLocation_ID = 0
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
        CmbWH_ID = lookupWarehouse.Properties.LookUpData.KeyValue
        LoadWarehouseArea()
    End Sub

    Private Sub lookupArea_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupArea.CloseUp
        CmbWHA_ID = lookupArea.Properties.LookUpData.KeyValue
        ObtainLocation()
    End Sub
#End Region

#Region " Codes for Buttons"
    Private Sub StockOutBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StockOutBtn.Click
        SaveProcessCompleted = False
        ReservedQty = CInt(txtReservedQty.Text)
        LooseQty = CInt(txtLooseQty.Text)
        StockOutQty = CInt(txtTotalStockOutQty.Text)
        LooseQty = CInt(txtLooseQty.Text)
        ValidateData()
        If ValidationStatus = True Then
            SaveDataProcess()
        End If
        If SaveProcessCompleted = True Then
            ClearFields()
            DisableFields()
            PopulateGrid()
            StockOutBtn.Enabled = False
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
#End Region

#Region " Data Validation"
    Private Sub ValidateData()
        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Stock_Out_Type = StockOutType
            .StockOutQty = StockOutQty
            .AllowedQty = AllowedQty

            If Not .ValidQty Then
                MessageBox.Show("Stock out quantity cannot be < 0 or = 0 or > Work Order quantity !", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ValidationStatus = False
                Exit Sub
            End If
        End With

        If ReservedQty = 0 And StockOutQty = 0 Then
            MessageBox.Show("Total stock out quantity must not be 0 !", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ValidationStatus = False
            Exit Sub
        End If

        If ReservedQty = 0 And StockOutQty > 0 Then
            If CmbWH_ID = 0 Or CmbWHA_ID = 0 Then
                MessageBox.Show("Please select a warehouse and area to stock out from !", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ValidationStatus = False
                Exit Sub
            Else
                GetInStoreQty()
            End If
        End If

        If ReservedQty > 0 And StockOutQty > ReservedQty Then
            If CmbWH_ID = 0 Or CmbWHA_ID = 0 Then
                lblInfo.Text = "Reserved stock is less than the requested qty, please select a warehouse and area to stock out the remaining qty from !"
                ValidationStatus = False
                Exit Sub
            Else
                GetInStoreQty()
                If LooseQty > InStoreQty Then
                    MessageBox.Show("Insufficient stock at the selected location, please select another .", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ValidationStatus = False
                    Exit Sub
                End If
            End If
        End If
        ValidationStatus = True
    End Sub
#End Region

#Region " Get in store qty for the selected item"
    Private Sub GetInStoreQty()
        Dim ds As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Stock_Out_Type = StockOutType
            .Product_ID = Product_ID
            .CmbWH_ID = CmbWH_ID
            .CmbWHA_ID = CmbWHA_ID
            .CmbLocation_ID = CmbLocation_ID

            ds = .GetStock
            If Not ds Is Nothing Then
                Stock_ID = CInt(ds.Tables(0).Rows(0).Item("Stock_ID"))
                InStoreQty = CInt(ds.Tables(0).Rows(0).Item("Qty"))
            Else
                Stock_ID = 0
                InStoreQty = 0
            End If
        End With
    End Sub
#End Region

#Region " Save Transaction"
    Private Sub SaveDataProcess()
        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            .Stock_Out_Type = StockOutType
            .Order_Type = Order_Type
            .Order_NO = WO_No
            .WO_ID = WO_ID
            .UserID = UserID
            .Stock_ID = Stock_ID
            .WO_Component_ID = WO_Component_ID
            .ReservedStock_ID = ReservedStock_ID
            .Category_ID = Category_ID
            .Product_ID = Product_ID
            .BalanceQty = BalanceQty
            .AllowedQty = AllowedQty
            .ReservedQty = ReservedQty
            .StockOutQty = StockOutQty

            If ReservedQty = 0 Then
                .WH_ID = CmbWH_ID
                .WHA_ID = CmbWHA_ID
                .Location_ID = CmbLocation_ID
                If .SaveStockTransaction Then
                    If .UpdateSelectedStock Then
                        If .UpdateWOLC Then
                            MessageBox.Show("Stock out successfully. ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            SaveProcessCompleted = True
                        Else
                            MessageBox.Show("Encounter error while updating work order line component ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            SaveProcessCompleted = False
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Encounter error while updating selected stock ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveProcessCompleted = False
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Encounter error while updating stock transaction ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveProcessCompleted = False
                    Exit Sub
                End If
            ElseIf ReservedQty > 0 And StockOutQty < OrigReservedQty Then
                .WH_ID = WH_ID
                .WHA_ID = WHA_ID
                .Location_ID = Location_ID
                If .SaveStockTransaction Then
                    .QtyDifference = (OrigReservedQty - StockOutQty)
                    If .UpdateReservedStock Then
                        If .UpdateWOLC Then
                            MessageBox.Show("Stock out successfully. ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            SaveProcessCompleted = True
                        Else
                            MessageBox.Show("Encounter error while updating work order line component ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            SaveProcessCompleted = False
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Encounter error while updating reserved stock ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveProcessCompleted = False
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Encounter error while updating stock transaction ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveProcessCompleted = False
                    Exit Sub
                End If
            ElseIf ReservedQty > 0 And StockOutQty = OrigReservedQty Then
                .WH_ID = WH_ID
                .WHA_ID = WHA_ID
                .Location_ID = Location_ID
                If .SaveStockTransaction Then
                    If .UpdateWOLC Then
                        If .DeleteReservedStock Then
                            MessageBox.Show("Stock out successfully. ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            SaveProcessCompleted = True
                        Else
                            MessageBox.Show("Encounter error while updating reserved stock ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            SaveProcessCompleted = False
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Encounter error while updating work order line component ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveProcessCompleted = False
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Encounter error while updating stock transaction ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveProcessCompleted = False
                    Exit Sub
                End If
            ElseIf ReservedQty > 0 And StockOutQty > OrigReservedQty Then
                .WH_ID = CmbWH_ID
                .WHA_ID = CmbWHA_ID
                .Location_ID = CmbLocation_ID
                .StockOutQty = LooseQty
                If .SaveStockTransaction Then
                    If .UpdateSelectedStock Then
                        SaveProcessCompleted = True
                    Else
                        MessageBox.Show("Encounter error while updating selected stock ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveProcessCompleted = False
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Encounter error while updating stock transaction ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveProcessCompleted = False
                    Exit Sub
                End If

                Stock_ID = 0
                .Stock_ID = Stock_ID
                .WH_ID = WH_ID
                .WHA_ID = WHA_ID
                .Location_ID = Location_ID
                .StockOutQty = ReservedQty
                If .SaveStockTransaction Then
                    .StockOutQty = StockOutQty
                    If .UpdateWOLC Then
                        If .DeleteReservedStock Then
                            MessageBox.Show("Stock out successfully. ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            SaveProcessCompleted = True
                        Else
                            MessageBox.Show("Encounter error while updating reserved stock ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            SaveProcessCompleted = False
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Encounter error while updating work order line component ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SaveProcessCompleted = False
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Encounter error while updating stock transaction ! ", "Stock Out (By WO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveProcessCompleted = False
                    Exit Sub
                End If
            End If
        End With
    End Sub
#End Region

#Region " Textbox Action"
    'Private Sub txtLooseQty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLooseQty.TextChanged
    '    lblInfo.Text = ""
    '    If txtLooseQty.Text = "" Then
    '        lblInfo.Text = "Stock out quantity must not be empty !"
    '        txtLooseQty.SelectAll()
    '        Exit Sub
    '    End If
    '    If Trim(txtLooseQty.Text).StartsWith("-") Then
    '        lblInfo.Text = "No negative value is allowed for quantity !"
    '        txtLooseQty.SelectAll()
    '        StockOutBtn.Enabled = False
    '        Exit Sub
    '    Else
    '        LooseQty = CInt(txtLooseQty.Text)
    '        StockOutQty = ReservedQty + LooseQty
    '        txtTotalStockOutQty.Text = StockOutQty
    '    End If
    '    StockOutBtn.Enabled = True
    'End Sub

    Private Sub txtTotalStockOutQty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalStockOutQty.TextChanged
        lblInfo.Text = ""
        If txtTotalStockOutQty.Text = "" Or txtTotalStockOutQty.Text.StartsWith("0") Then
            lblInfo.Text = "Total stock out quantity must not be empty or 0 !"
            txtTotalStockOutQty.SelectAll()
            StockOutBtn.Enabled = False
            Exit Sub
        End If
        If Trim(txtTotalStockOutQty.Text).StartsWith("-") Then
            lblInfo.Text = "No negative value is allowed for quantity !"
            txtTotalStockOutQty.SelectAll()
            StockOutBtn.Enabled = False
            Exit Sub
        End If
        StockOutQty = CInt(txtTotalStockOutQty.Text)
        If StockOutQty > AllowedQty Then
            lblInfo.Text = "You cannot stock out more than the required quantity !"
            txtTotalStockOutQty.SelectAll()
            StockOutBtn.Enabled = False
            Exit Sub
        End If
        If StockOutQty <= OrigReservedQty Then
            txtReservedQty.Text = txtTotalStockOutQty.Text
            txtLooseQty.Text = 0
        Else
            txtReservedQty.Text = OrigReservedQty
            txtLooseQty.Text = StockOutQty - OrigReservedQty
        End If
        ReservedQty = CInt(txtReservedQty.Text)
        LooseQty = CInt(txtLooseQty.Text)
        StockOutQty = ReservedQty + LooseQty
        StockOutBtn.Enabled = True
    End Sub
#End Region

    
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow = GridView1.GetDataRow(Row)
                'dr = GridView1.GetDataRow(Row)
                PopulateToForm(dr)
            End If
        End If

    End Sub
    Private Sub StockOutWOForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit stock out screen?", "Stock Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
