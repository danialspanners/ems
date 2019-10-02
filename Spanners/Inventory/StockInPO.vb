Imports System.Data
'Imports Crownwood.Magic.Common
'Imports Crownwood.Magic.Controls
Imports DevExpress.XtraEditors.Controls

Public Class StockInPOForm
    Inherits System.Windows.Forms.Form

#Region " Declare Public Variables"
    Public UserID As String = Common.CommonConn.Config.USERID

    Public Supplier_ID As Integer = 0
    Public PO_ID As Integer
    Public Old_PO_ID As Integer
    Public PO_Line_ID As Integer
    Public Stock_ID As Integer
    Public Category_ID As Integer
    Public Product_ID As Integer
    Public WH_ID As Integer = 0
    Public WHA_ID As Integer = 0
    Public Location_ID As Integer = 0
    Public UOM_ID As Integer
    Public NewConfirmQty As Integer
    Public PO_Line_Status As Integer
    Public PO_Header_Status As Integer
    Public StockInQty As Integer
    Public OrderQty As Integer
    Public ConfirmQty As Integer
    Public QtyDifference As Integer
    Public AccessCount As Integer = 0

    Public Unit As String
    Public Transaction_Type As String = "Stock In"
    Public OrderType As String
    Public StockInType As String = "By PO"
    Public PO_No As String
    'Public UserID As String = "1"

    Public Transaction_Status As Boolean
    Public data As System.Data.DataTable
#End Region

#Region " Windows Form Designer generated code "
    Public Sub New(Optional ByVal pPO_No As String = "", _
                    Optional ByVal pPO_ID As Integer = 0)
        MyBase.New()

        If Not pPO_No = "" Or Not pPO_ID = 0 Then
            PO_No = pPO_No
            PO_ID = pPO_ID
        End If

        'If Not pOld_PO_ID = 0 Then
        'Old_PO_ID = pOld_PO_ID
        'End If

        'If Not pPO_ID = 0 Then
        'PO_ID = pPO_ID
        'End If

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblStockInDt As System.Windows.Forms.Label
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents lblStockInQty As System.Windows.Forms.Label
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockInDt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockInQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRefNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRefNO As System.Windows.Forms.Label
    Friend WithEvents lookupWarehouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookupArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookupLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grdLine As DevExpress.XtraGrid.GridControl
    Friend WithEvents StockInBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents txtUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents txtProductNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCategoryNm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProductNm As System.Windows.Forms.Label
    Friend WithEvents lblCategoryNm As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit
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
        Me.grdLine = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.StockInBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.grdLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSupplier)
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
        Me.GroupBox1.Controls.Add(Me.grdLine)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 416)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(96, 320)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(264, 21)
        Me.txtSupplier.TabIndex = 25
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(38, 320)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(56, 16)
        Me.lblSupplier.TabIndex = 23
        Me.lblSupplier.Text = "Supplier :"
        '
        'lookupLocation
        '
        Me.lookupLocation.Location = New System.Drawing.Point(536, 344)
        Me.lookupLocation.Name = "lookupLocation"
        Me.lookupLocation.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupLocation.Properties.NullString = ""
        Me.lookupLocation.Properties.PopupWidth = 184
        Me.lookupLocation.Size = New System.Drawing.Size(152, 21)
        Me.lookupLocation.TabIndex = 19
        Me.lookupLocation.Visible = False
        '
        'lookupArea
        '
        Me.lookupArea.Location = New System.Drawing.Point(304, 344)
        Me.lookupArea.Name = "lookupArea"
        Me.lookupArea.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupArea.Properties.NullString = ""
        Me.lookupArea.Properties.PopupWidth = 152
        Me.lookupArea.Size = New System.Drawing.Size(152, 21)
        Me.lookupArea.TabIndex = 18
        '
        'lookupWarehouse
        '
        Me.lookupWarehouse.Location = New System.Drawing.Point(96, 344)
        Me.lookupWarehouse.Name = "lookupWarehouse"
        Me.lookupWarehouse.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupWarehouse.Properties.NullString = ""
        Me.lookupWarehouse.Properties.PopupWidth = 152
        Me.lookupWarehouse.Size = New System.Drawing.Size(152, 21)
        Me.lookupWarehouse.TabIndex = 17
        '
        'txtStockInQty
        '
        Me.txtStockInQty.Location = New System.Drawing.Point(608, 320)
        Me.txtStockInQty.Name = "txtStockInQty"
        Me.txtStockInQty.Size = New System.Drawing.Size(80, 21)
        Me.txtStockInQty.TabIndex = 16
        '
        'txtUOM
        '
        Me.txtUOM.Location = New System.Drawing.Point(432, 320)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(80, 21)
        Me.txtUOM.TabIndex = 15
        '
        'txtStockInDt
        '
        Me.txtStockInDt.Location = New System.Drawing.Point(96, 248)
        Me.txtStockInDt.Name = "txtStockInDt"
        Me.txtStockInDt.Size = New System.Drawing.Size(104, 21)
        Me.txtStockInDt.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 296)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(592, 21)
        Me.txtDescription.TabIndex = 13
        '
        'txtProductNm
        '
        Me.txtProductNm.Location = New System.Drawing.Point(320, 272)
        Me.txtProductNm.Name = "txtProductNm"
        Me.txtProductNm.Size = New System.Drawing.Size(368, 21)
        Me.txtProductNm.TabIndex = 12
        '
        'txtCategoryNm
        '
        Me.txtCategoryNm.Location = New System.Drawing.Point(96, 272)
        Me.txtCategoryNm.Name = "txtCategoryNm"
        Me.txtCategoryNm.Size = New System.Drawing.Size(152, 21)
        Me.txtCategoryNm.TabIndex = 11
        '
        'txtRefNO
        '
        Me.txtRefNO.Location = New System.Drawing.Point(320, 248)
        Me.txtRefNO.Name = "txtRefNO"
        Me.txtRefNO.Size = New System.Drawing.Size(104, 21)
        Me.txtRefNO.TabIndex = 10
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(480, 344)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(56, 16)
        Me.lblLocation.TabIndex = 9
        Me.lblLocation.Text = "Location :"
        Me.lblLocation.Visible = False
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(264, 344)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 8
        Me.lblArea.Text = "Area :"
        '
        'lblWarehouse
        '
        Me.lblWarehouse.Location = New System.Drawing.Point(22, 344)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(72, 16)
        Me.lblWarehouse.TabIndex = 7
        Me.lblWarehouse.Text = "Warehouse :"
        '
        'lblStockInQty
        '
        Me.lblStockInQty.Location = New System.Drawing.Point(532, 320)
        Me.lblStockInQty.Name = "lblStockInQty"
        Me.lblStockInQty.Size = New System.Drawing.Size(76, 16)
        Me.lblStockInQty.TabIndex = 6
        Me.lblStockInQty.Text = "Stock In Qty :"
        '
        'lblUOM
        '
        Me.lblUOM.Location = New System.Drawing.Point(390, 320)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(40, 16)
        Me.lblUOM.TabIndex = 5
        Me.lblUOM.Text = "UOM :"
        '
        'lblStockInDt
        '
        Me.lblStockInDt.Location = New System.Drawing.Point(12, 248)
        Me.lblStockInDt.Name = "lblStockInDt"
        Me.lblStockInDt.Size = New System.Drawing.Size(80, 16)
        Me.lblStockInDt.TabIndex = 4
        Me.lblStockInDt.Text = "Stock In Date :"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(24, 296)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(72, 16)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description :"
        '
        'lblProductNm
        '
        Me.lblProductNm.Location = New System.Drawing.Point(268, 272)
        Me.lblProductNm.Name = "lblProductNm"
        Me.lblProductNm.Size = New System.Drawing.Size(56, 16)
        Me.lblProductNm.TabIndex = 2
        Me.lblProductNm.Text = "Product :"
        '
        'lblCategoryNm
        '
        Me.lblCategoryNm.Location = New System.Drawing.Point(34, 272)
        Me.lblCategoryNm.Name = "lblCategoryNm"
        Me.lblCategoryNm.Size = New System.Drawing.Size(56, 16)
        Me.lblCategoryNm.TabIndex = 1
        Me.lblCategoryNm.Text = "Category :"
        '
        'lblRefNO
        '
        Me.lblRefNO.Location = New System.Drawing.Point(270, 248)
        Me.lblRefNO.Name = "lblRefNO"
        Me.lblRefNO.Size = New System.Drawing.Size(48, 16)
        Me.lblRefNO.TabIndex = 0
        Me.lblRefNO.Text = "PO NO :"
        '
        'grdLine
        '
        Me.grdLine.EditorsRepository = Me.PersistentRepository1
        Me.grdLine.Location = New System.Drawing.Point(8, 14)
        Me.grdLine.MainView = Me.GridView1
        Me.grdLine.Name = "grdLine"
        Me.grdLine.Size = New System.Drawing.Size(680, 216)
        Me.grdLine.TabIndex = 6
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
        'StockInBtn
        '
        Me.StockInBtn.AutoSize = False
        Me.StockInBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockInBtn.Image = Nothing
        Me.StockInBtn.Location = New System.Drawing.Point(512, 464)
        Me.StockInBtn.Name = "StockInBtn"
        Me.StockInBtn.Size = New System.Drawing.Size(88, 24)
        Me.StockInBtn.TabIndex = 20
        Me.StockInBtn.Text = "Stock In"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(616, 464)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(88, 24)
        Me.CloseBtn.TabIndex = 21
        Me.CloseBtn.Text = "Close"
        '
        'StockInPOForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(714, 502)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StockInBtn)
        Me.Name = "StockInPOForm"
        Me.Text = "Stock In (Based on PO)"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.grdLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

#Region " Codes for Form load"
    Private Sub StockInForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        DisableFields()
        txtStockInDt.Text = Date.Today

        txtSupplier.Visible = True
        PopulateGrid()
        txtRefNO.Text = Trim(PO_No)

        LoadWarehouse()
        'Go to 1 rec of the grid by default
        grdLine_Click(sender, e)
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region " Component Grid Function "
    Public Sub PopulateGrid()
        Dim ds As DataSet

        grdLine.DataSource = Nothing

        AccessCount = AccessCount + 1
        With New BusinessRules.BusRules.InventoryBusLogic
            .PO_ID = PO_ID
            ds = .GetPOLine()

            If Not ds Is Nothing Then
                InitGrid()

                Dim oRow As DataRow
                Dim i As Integer = 0
                'Dim CompTotal As Double

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {i, oRow("POLID"), oRow("CatID"), oRow("ProdID"), oRow("Supplier_ID"), oRow("UOM_ID"), oRow("Category"), oRow("Supplier_Name"), oRow("OrdQty"), oRow("ConQty"), oRow("Product"), oRow("Description"), oRow("Unit")})
                Next

                grdLine.DataSource = data
                grdLine.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide LineID column
                GridView1.Columns.Item(2).VisibleIndex = -1 'hide CategoryID column
                GridView1.Columns.Item(3).VisibleIndex = -1 'hide ProductID column
                GridView1.Columns.Item(4).VisibleIndex = -1 'hide SupplierID column
                GridView1.Columns.Item(5).VisibleIndex = -1 'hide UOMID column
                GridView1.Columns.Item(6).VisibleIndex = -1 'hide Category column
                GridView1.Columns.Item(7).VisibleIndex = -1 'hide Supplier column
                'GridView1.Columns.Item(8).VisibleIndex = -1 'hide OrderQty column
                GridView1.Columns.Item(9).VisibleIndex = -1 'hide ConfirmQty column
            Else
                If AccessCount > 1 Then
                    PO_Header_Status = 90
                    .PO_Header_Status = PO_Header_Status
                    .UserID = UserID
                    .UpdatePOHeader()
                    GridView1.Columns.Clear()
                End If
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "S/No", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Line ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Category ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Product ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Supplier ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "UOM ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Category Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Supplier Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Order Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Confirm Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Product Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Unit", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Stock In Qty", System.Type.GetType("System.Int16"), True)
        data.EndInit()
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
                    'ComponentContextMenu.Show(sender, mouseDownLocation)
                Case MouseButtons.None
                    eventString = Nothing
            End Select
        End If
    End Sub

    Private Sub PopulateToForm(ByVal drow As DataRow)
        'Dim SelectedIndex As Integer

        txtCategoryNm.Text = drow.Item("Category Name")
        txtProductNm.Text = drow.Item("Product Name")
        txtDescription.Text = drow.Item("Description")
        UOM_ID = CInt(drow.Item("UOM ID"))
        txtUOM.Text = drow.Item("Unit")
        txtStockInQty.Text = 0
        PO_Line_ID = CInt(drow.Item("Line ID"))
        OrderQty = drow.Item("Order Qty")
        ConfirmQty = drow.Item("Confirm Qty")
        Supplier_ID = CInt(drow.Item("Supplier ID"))
        txtSupplier.Text = drow.Item("Supplier Name")
        txtStockInQty.Text = OrderQty - ConfirmQty
        Category_ID = CInt(drow.Item("Category ID"))
        Product_ID = CInt(drow.Item("Product ID"))
        StockInBtn.Enabled = True
    End Sub

    'Protected Overrides Sub OnCreateControl()
    '   MyBase.OnCreateControl()
    '  RefreshComponentGrid()
    'End Sub
#End Region

#Region " Codes for Buttons"
    Private Sub StockInBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockInBtn.Click
        StockInQty = CInt(txtStockInQty.Text)
        SaveDataProcess()
        If Transaction_Status = True Then
            ClearFields()
            PopulateGrid()
            StockInBtn.Enabled = False
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
#End Region

#Region " Save Transaction"
    Private Sub SaveDataProcess()
        Dim dsExist As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            NewConfirmQty = ConfirmQty + StockInQty
            QtyDifference = OrderQty - ConfirmQty

            .Transaction_Type = Transaction_Type
            .Stock_In_Type = StockInType
            .StockInQty = StockInQty
            .QtyDifference = QtyDifference

            If Not .ValidQty Then
                MessageBox.Show("Stock in quantity cannot be < 0 or = 0 or > order quantity!", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Transaction_Status = False
                Exit Sub
            Else
                QtyDifference = OrderQty - NewConfirmQty
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

            .OrderQty = OrderQty
            .ConfirmQty = ConfirmQty
            .NewConfirmQty = NewConfirmQty
            .PO_Line_ID = PO_Line_ID
            .Category_ID = Category_ID
            .Product_ID = Product_ID
            .Supplier_ID = Supplier_ID
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
                If .UpdateSelectedStock And .UpdatePOLine And .SaveStockTransaction Then
                    MessageBox.Show("Stock in successfully. ", "Stock In (Based on PO)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Encounter error while stocking in ! ", "Stock In (Based on PO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                If .SaveNewStock And .UpdatePOLine And .SaveStockTransaction Then
                    MessageBox.Show("Stock in successfully. ", "Stock In (Based on PO)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Encounter error while stocking in ! ", "Stock In (Based on PO)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End With
        Transaction_Status = True
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
        WH_ID = lookupWarehouse.Properties.LookUpData.KeyValue
        LoadWarehouseArea()
    End Sub

    Private Sub lookupArea_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupArea.CloseUp
        WHA_ID = lookupArea.Properties.LookUpData.KeyValue
        ObtainLocation()
        'LoadWarehouseLocation()
    End Sub

    'Private Sub lookupLocation_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupLocation.CloseUp
    '    Location_ID = lookupLocation.Properties.LookUpData.KeyValue
    'End Sub
#End Region

#Region " Functions for Form Fields"
    'Set All Fields to Default Values
    Private Sub ClearFields()
        txtProductNm.Text = ""
        txtDescription.Text = ""
        txtUOM.Text = ""
        txtStockInQty.Text = 0
        txtSupplier.Text = ""
        txtCategoryNm.Text = ""
    End Sub

    'Disable Non-Editable Fields
    Private Sub DisableFields()
        txtRefNO.Enabled = False
        txtCategoryNm.Enabled = False
        txtProductNm.Enabled = False
        txtDescription.Enabled = False
        txtStockInDt.Enabled = False
        txtUOM.Enabled = False
        txtSupplier.Enabled = False
        StockInBtn.Enabled = False
    End Sub
#End Region

    Private Sub grdLine_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLine.Click
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)
                PopulateToForm(dr)
            End If
        End If
    End Sub
    Private Sub StockInPOForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
