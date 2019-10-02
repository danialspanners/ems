Public Class StockBalReportForm
    Inherits System.Windows.Forms.Form

    Public UserID As String = Common.CommonConn.Config.USERID
    Public Transaction_Type As String = "Reporting"
    Public dsStock As DataSet
    Public ReportType As String = ""
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TransactionType_Label As System.Windows.Forms.Label
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Sales.DataSet1
    Friend WithEvents TransactionType_LookUpEdit_ItemType As DevExpress.XtraEditors.LookUpEdit
    Public data As System.Data.DataTable

#Region " Windows Form Designer generated code "

    Public Sub New() ' Stock Balance Report
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pReportType As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        ReportType = pReportType 'Default ReportType is Stock Balance Report

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
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecords As System.Windows.Forms.Label
    Friend WithEvents grdStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RefreshBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CategoryTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PartCodeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblCount = New System.Windows.Forms.Label
        Me.lblTotalRecords = New System.Windows.Forms.Label
        Me.grdStock = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.CategoryTxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CategoryTree = New System.Windows.Forms.TreeView
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.StartDate = New DevExpress.XtraEditors.DateEdit
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.EndDate = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PartCodeTxt = New DevExpress.XtraEditors.TextEdit
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TransactionType_Label = New System.Windows.Forms.Label
        Me.DataSet1 = New Sales.DataSet1
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionType_LookUpEdit_ItemType = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionType_LookUpEdit_ItemType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(720, 168)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(64, 16)
        Me.lblCount.TabIndex = 28
        Me.lblCount.Visible = False
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.Location = New System.Drawing.Point(632, 168)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(88, 16)
        Me.lblTotalRecords.TabIndex = 27
        Me.lblTotalRecords.Text = "Total Records :"
        Me.lblTotalRecords.Visible = False
        '
        'grdStock
        '
        Me.grdStock.EditorsRepository = Me.PersistentRepository1
        Me.grdStock.Location = New System.Drawing.Point(672, 24)
        Me.grdStock.MainView = Me.GridView1
        Me.grdStock.Name = "grdStock"
        Me.grdStock.Size = New System.Drawing.Size(96, 120)
        Me.grdStock.TabIndex = 25
        Me.grdStock.Visible = False
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
        Me.GridView1.VertScrollTipFieldName = Nothing
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.Image = Nothing
        Me.RefreshBtn.Location = New System.Drawing.Point(672, 192)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(50, 19)
        Me.RefreshBtn.TabIndex = 29
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Select Category to print:"
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(64, 32)
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.ReadOnly = True
        Me.CategoryTxt.Size = New System.Drawing.Size(120, 20)
        Me.CategoryTxt.TabIndex = 86
        Me.CategoryTxt.Text = "Category Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Category :"
        '
        'CategoryTree
        '
        Me.CategoryTree.Location = New System.Drawing.Point(24, 60)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.Size = New System.Drawing.Size(160, 244)
        Me.CategoryTree.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(211, 222)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(304, 24)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Only include records that balance is greater than zero. "
        Me.CheckBox1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(16, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 8)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(208, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "From :"
        '
        'StartDate
        '
        Me.StartDate.DateTime = New Date(CType(0, Long))
        Me.StartDate.Location = New System.Drawing.Point(246, 98)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StartDate.Properties.MaskData.EditMask = "##/##/####"
        Me.StartDate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.StartDate.Size = New System.Drawing.Size(110, 25)
        Me.StartDate.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(211, 261)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(304, 24)
        Me.CheckBox2.TabIndex = 92
        Me.CheckBox2.Text = "Only include records that have defined location "
        Me.CheckBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(316, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Print"
        '
        'EndDate
        '
        Me.EndDate.DateTime = New Date(CType(0, Long))
        Me.EndDate.Location = New System.Drawing.Point(390, 98)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EndDate.Properties.MaskData.EditMask = "##/##/####"
        Me.EndDate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.EndDate.Size = New System.Drawing.Size(116, 25)
        Me.EndDate.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(362, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 23)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "To :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(208, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Transaction date"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(208, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Part Code:"
        '
        'PartCodeTxt
        '
        Me.PartCodeTxt.Location = New System.Drawing.Point(268, 32)
        Me.PartCodeTxt.Name = "PartCodeTxt"
        Me.PartCodeTxt.Size = New System.Drawing.Size(216, 21)
        Me.PartCodeTxt.TabIndex = 98
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(486, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "..."
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(418, 336)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 32)
        Me.Button3.TabIndex = 100
        Me.Button3.Text = "Close"
        '
        'TransactionType_Label
        '
        Me.TransactionType_Label.Location = New System.Drawing.Point(208, 143)
        Me.TransactionType_Label.Name = "TransactionType_Label"
        Me.TransactionType_Label.Size = New System.Drawing.Size(117, 18)
        Me.TransactionType_Label.TabIndex = 102
        Me.TransactionType_Label.Text = "Transaction type:"
        Me.TransactionType_Label.Visible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'TransactionType_LookUpEdit_ItemType
        '
        Me.TransactionType_LookUpEdit_ItemType.Location = New System.Drawing.Point(302, 140)
        Me.TransactionType_LookUpEdit_ItemType.Name = "TransactionType_LookUpEdit_ItemType"
        Me.TransactionType_LookUpEdit_ItemType.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(23))
        Me.TransactionType_LookUpEdit_ItemType.Properties.PopupWidth = 228
        Me.TransactionType_LookUpEdit_ItemType.Size = New System.Drawing.Size(204, 21)
        Me.TransactionType_LookUpEdit_ItemType.TabIndex = 103
        Me.TransactionType_LookUpEdit_ItemType.Visible = False
        '
        'StockBalReportForm
        '
        Me.ClientSize = New System.Drawing.Size(528, 385)
        Me.Controls.Add(Me.TransactionType_LookUpEdit_ItemType)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PartCodeTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CategoryTxt)
        Me.Controls.Add(Me.grdStock)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Controls.Add(Me.TransactionType_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StockBalReportForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Balance Detail Report"
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionType_LookUpEdit_ItemType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Codes for Form Load"
    Private Sub InventoryListingForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ReportType = "TRANSACTIONBYDATE" Then
            TransactionType_Label.Visible = True
            TransactionType_LookUpEdit_ItemType.Visible = True
            LoadTransactionTypeCombo()
            Me.Text = "Stock transaction by date"
        End If

        Me.Cursor = Cursors.WaitCursor
        LoadCategoryList()
        LoadCombo()
        'Me.LookUpEdit_ItemType.Properties.LookUpData.KeyValue = "0"
        Me.StartDate.DateTime = Now
        Me.EndDate.DateTime = Now
        'PopulateGrid()
        Me.Cursor = Cursors.Default

        Me.CategoryTree.Focus()

    End Sub
#End Region

#Region " Component Grid Functions"
    Public Sub PopulateGrid()
        grdStock.DataSource = Nothing

        With New BusinessRules.BusRules.InventoryBusLogic
            .Transaction_Type = Transaction_Type
            dsStock = .GetInventoryList
            If Not dsStock Is Nothing Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In dsStock.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {i, oRow("Product"), oRow("Description"), oRow("Category"), oRow("Total_Qty"), oRow("UOM")})
                Next

                lblCount.Text = i
                grdStock.DataSource = data
                grdStock.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                'GridView1.Columns.Item(1).VisibleIndex = -1 'hide StockID column
                'GridView1.Columns.Item(2).VisibleIndex = -1 'hide SupplierID column
                'GridView1.Columns.Item(3).VisibleIndex = -1 'hide UOMID column
                'GridView1.Columns.Item(4).VisibleIndex = -1 'hide WarehouseID column
                'GridView1.Columns.Item(5).VisibleIndex = -1 'hide WarehouseAreaID column
                'GridView1.Columns.Item(6).VisibleIndex = -1 'hide LocationID column
                'GridView1.Columns.Item(7).VisibleIndex = -1 'hide Qty column
                'GridView1.Columns.Item(8).VisibleIndex = -1 'hide UOM column
            Else
                GridView1.Columns.Clear()
                lblCount.Text = 0
                'PrintBtn.Enabled = False
                Button1.Enabled = False
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "S/No", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Product ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Product Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Category", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Unit", System.Type.GetType("System.String"), True)
        'AddColumn(data, "WH ID", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "WHA ID", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Location ID", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Product Description", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Warehouse", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Area", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Row", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Column", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Height", System.Type.GetType("System.Int16"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub
#End Region

#Region " Codes for Buttons"
    Private Sub RefreshBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RefreshBtn.Click
        PopulateGrid()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
#End Region


#Region " Code - Category tree list"
    'For Category Portion

    Private Sub LoadCategoryList()
        Dim node As TreeNode
        Dim Root As TreeNode = New TreeNode("All Categories")

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
        Root.Expand()
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

#End Region

    Private Sub InventoryListingForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim a As MainForm = Me.ParentForm
        'If (a.MainTabControl.TabPages.Count > 0) Then
        'If Not (a.MainTabControl.SelectedTab Is Nothing) Then
        'a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
        'End If
        'End If
    End Sub

    Private Sub LoadTransactionTypeCombo()
        Dim ItemTypeData As String() = _
        New String() {"All", _
        "Stock in (DO)", _
        "Return-in (RTN)", _
        "Withdraw (SRV)", _
        "Withdraw (PMR)", _
        "Goods Withdraw (FGW)", _
        "Goods Withdraw (DO)", _
        "Goods Withdraw (NOI)", _
        "QA - Inspection Report (QAR)", _
        "Goods Internal (INT)"}

        Dim ItemTypeID As String() = New String() {"ALL", "DO", "RTN", "SRV", "PMR", "FGW", "FGWDO", "FGWNOI", "QAR", "INT"}

        SetComboValue(ItemTypeData, TransactionType_LookUpEdit_ItemType, ItemTypeID)

        TransactionType_LookUpEdit_ItemType.Properties.LookUpData.KeyValue = "ALL"

    End Sub

    Private Sub LoadCombo()
        Dim ItemTypeData As String() = New String() {"All Items", "Active Items only", "Dormant Items only"}
        Dim ItemTypeID As String() = New String() {"0", "1", "2"}
        'SetComboValue(ItemTypeData, Me.LookUpEdit_ItemType, ItemTypeID)
    End Sub

    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())
        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub CategoryTree_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles CategoryTree.AfterSelect
        Dim CurrentTag
        Dim CurrentText

        CurrentTag = CategoryTree.SelectedNode.Tag
        CurrentText = CategoryTree.SelectedNode.Text()
        Me.CategoryTxt.Text = CurrentText
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckValidDateSelection() = False Then
            Exit Sub
        End If

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        'Me.Cursor = Cursors.WaitCursor
        Dim ExtProgressForm
        ExtProgressForm = New TaskProgressForm
        'ExtProgressForm. = Me
        ExtProgressForm.Show()
        ExtProgressForm.Refresh()

        If ReportType = "TRANSACTIONBYDATE" Then
            Dim formx As StockTransReport
            formx = New StockTransReport(CategoryTree.SelectedNode.Tag, Me.PartCodeTxt.Text, Me.TransactionType_LookUpEdit_ItemType.Properties.LookUpData.KeyValue, "Stock transaction by date - " & Me.TransactionType_LookUpEdit_ItemType.Properties.LookUpData.KeyField, 0, Me.StartDate.DateTime, Me.EndDate.DateTime, ReportType)
            formx.ShowDialog()
        Else 'Stock Balance Report
            Dim formx As StockBalDetReportForm
            formx = New StockBalDetReportForm(CategoryTree.SelectedNode.Tag, Me.PartCodeTxt.Text, Me.StartDate.DateTime, Me.EndDate.DateTime, Me.CheckBox1.Checked, Me.CheckBox2.Checked, ExtProgressForm)
            formx.ShowDialog()
        End If

        ExtProgressForm.Close()
    End Sub

    Private Sub StartDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartDate.LostFocus
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim searchform As SearchProduct
        searchform = New SearchProduct("product")
        searchform.ShowDialog()
        If searchform.DialogResult = DialogResult.OK Then
            PartCodeTxt.Text = searchform.ReturnString
        End If

        PartCodeTxt.Focus()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub StartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDate.ValueChanged
        If EndDate.DateTime < StartDate.DateTime Then
            EndDate.DateTime = StartDate.DateTime
        End If
    End Sub

    Private Sub EndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndDate.ValueChanged
        CheckValidDateSelection()

    End Sub

    Private Function CheckValidDateSelection() As Boolean
        If EndDate.Text <> "" And StartDate.Text <> "" Then
            If EndDate.DateTime.Date < StartDate.DateTime.Date Then
                MessageBox.Show("The end date cannot be eariler than the start date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If


        Return True

    End Function
End Class
