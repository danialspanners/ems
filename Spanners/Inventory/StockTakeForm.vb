Public Class StockTakeForm
    Inherits System.Windows.Forms.Form

    Public UserID As String = Common.CommonConn.Config.USERID
    Public Transaction_Type As String = "Reporting"
    Public dsStock As DataSet
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RecordDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public data As System.Data.DataTable

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitalAreaCombo()

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LookUpEdit_ItemType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Transactdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents lookupArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblArea As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockTakeForm))
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.LookUpEdit_ItemType = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Transactdate = New DevExpress.XtraEditors.DateEdit
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.lookupArea = New DevExpress.XtraEditors.LookUpEdit
        Me.lblArea = New System.Windows.Forms.Label
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.RecordDate = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_ItemType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Select Category to print:"
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(312, 25)
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.ReadOnly = True
        Me.CategoryTxt.Size = New System.Drawing.Size(176, 20)
        Me.CategoryTxt.TabIndex = 86
        Me.CategoryTxt.Text = "Category Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(216, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Category Selected:"
        '
        'CategoryTree
        '
        Me.CategoryTree.Location = New System.Drawing.Point(24, 28)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.Size = New System.Drawing.Size(160, 276)
        Me.CategoryTree.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(208, 211)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(283, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Only include records that balance is greater than zero. "
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(16, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 8)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(208, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Item type:"
        '
        'LookUpEdit_ItemType
        '
        Me.LookUpEdit_ItemType.Location = New System.Drawing.Point(264, 89)
        Me.LookUpEdit_ItemType.Name = "LookUpEdit_ItemType"
        Me.LookUpEdit_ItemType.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton("", False, DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, Nothing, 20, System.Windows.Forms.HorizontalAlignment.Center, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, DevExpress.XtraEditors.Controls.BorderStyles.[Default]))
        Me.LookUpEdit_ItemType.Properties.PopupWidth = 228
        Me.LookUpEdit_ItemType.Size = New System.Drawing.Size(228, 25)
        Me.LookUpEdit_ItemType.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(208, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Transaction criteria:"
        '
        'Transactdate
        '
        Me.Transactdate.DateTime = New Date(CType(0, Long))
        Me.Transactdate.Location = New System.Drawing.Point(316, 127)
        Me.Transactdate.Name = "Transactdate"
        Me.Transactdate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton("", False, DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, Nothing, 20, System.Windows.Forms.HorizontalAlignment.Center, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, DevExpress.XtraEditors.Controls.BorderStyles.[Default]))
        Me.Transactdate.Properties.MaskData.EditMask = "##/##/####"
        Me.Transactdate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Transactdate.Size = New System.Drawing.Size(176, 25)
        Me.Transactdate.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(208, 243)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(251, 17)
        Me.CheckBox2.TabIndex = 92
        Me.CheckBox2.Text = "Only include records that have defined location "
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(208, 272)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox3.TabIndex = 94
        Me.CheckBox3.Text = "Print prices"
        Me.CheckBox3.Visible = False
        '
        'lookupArea
        '
        Me.lookupArea.Location = New System.Drawing.Point(264, 55)
        Me.lookupArea.Name = "lookupArea"
        Me.lookupArea.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton("", False, DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, Nothing, 20, System.Windows.Forms.HorizontalAlignment.Center, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, DevExpress.XtraEditors.Controls.BorderStyles.[Default]))
        Me.lookupArea.Properties.NullString = ""
        Me.lookupArea.Properties.PopupWidth = 228
        Me.lookupArea.Size = New System.Drawing.Size(228, 25)
        Me.lookupArea.TabIndex = 197
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(220, 59)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 198
        Me.lblArea.Text = "Area :"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XtraButton1
        '
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(16, 336)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(92, 19)
        Me.XtraButton1.TabIndex = 199
        Me.XtraButton1.Text = "Print from cache"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 35)
        Me.Button1.TabIndex = 200
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(432, 336)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 35)
        Me.Button3.TabIndex = 201
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RecordDate
        '
        Me.RecordDate.DateTime = New Date(CType(0, Long))
        Me.RecordDate.Location = New System.Drawing.Point(316, 168)
        Me.RecordDate.Name = "RecordDate"
        Me.RecordDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton("", False, DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, Nothing, 20, System.Windows.Forms.HorizontalAlignment.Center, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, DevExpress.XtraEditors.Controls.BorderStyles.[Default]))
        Me.RecordDate.Properties.MaskData.EditMask = "##/##/####"
        Me.RecordDate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.RecordDate.Size = New System.Drawing.Size(176, 25)
        Me.RecordDate.TabIndex = 202
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(208, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 23)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Record Date"
        '
        'StockTakeForm
        '
        Me.ClientSize = New System.Drawing.Size(528, 389)
        Me.Controls.Add(Me.RecordDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.XtraButton1)
        Me.Controls.Add(Me.lookupArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CategoryTxt)
        Me.Controls.Add(Me.grdStock)
        Me.Controls.Add(Me.Transactdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LookUpEdit_ItemType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Name = "StockTakeForm"
        Me.Text = "Stock Take & Assessment Form"
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_ItemType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Codes for Form Load"
    Private Sub StockTakeForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadCategoryList()
        LoadCombo()
        Me.LookUpEdit_ItemType.Properties.LookUpData.KeyValue = "0"
        Me.Transactdate.DateTime = Now
        Me.RecordDate.DateTime = Now
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
    'Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    ''Dim a As MainForm = Me.ParentForm
    ''Dim controlToAdd As Control = Nothing
    'Me.Cursor = Cursors.WaitCursor

    'Dim formx As InventoryReportForm
    'formx = New InventoryReportForm(CategoryTree.SelectedNode.Tag, Me.LookUpEdit_ItemType.Properties.LookUpData.KeyValue, Me.Transactdate.DateTime, Me.CheckBox1.Checked, Me.CheckBox2.Checked)
    'formx.ShowDialog()


    'Dim page As Crownwood.Magic.Controls.TabPage
    'controlToAdd = New InventoryReportForm(CategoryTree.SelectedNode.Tag, Me.LookUpEdit_ItemType.Properties.LookUpData.KeyValue, Me.Transactdate.DateTime, Me.CheckBox1.Checked, Me.CheckBox2.Checked)
    '    page = New Crownwood.Magic.Controls.TabPage("Print Inventory Report", controlToAdd, ImageList1, 0)

    'page.Selected = True
    'a.MainTabControl.TabPages.Add(page)
    'Me.Cursor = Cursors.Default

    'End Sub

    Private Sub StockTakeForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub LoadCombo()
        Dim ItemTypeData As String() = New String() {"All Items", "Active Items only", "Dormant Items only"}
        Dim ItemTypeID As String() = New String() {"0", "1", "2"}
        SetComboValue(ItemTypeData, Me.LookUpEdit_ItemType, ItemTypeID)
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
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        'Me.Cursor = Cursors.WaitCursor
        Dim ExtProgressForm
        ExtProgressForm = New TaskProgressForm
        'ExtProgressForm. = Me

        ExtProgressForm.Show()
        ExtProgressForm.Refresh()

        'Me.Cursor = Cursors.WaitCursor

        'Dim page As Crownwood.Magic.Controls.TabPage
        'controlToAdd = New StockTakingForm(CategoryTree.SelectedNode.Tag, _
        'Me.LookUpEdit_ItemType.Properties.LookUpData.KeyValue, _
        'Me.Transactdate.DateTime, _
        'Me.lookupArea.Properties.LookUpData.KeyValue, _
        'Me.CheckBox1.Checked, Me.CheckBox2.Checked, _
        'Me.CheckBox3.Checked, ExtProgressForm)

        'page = New Crownwood.Magic.Controls.TabPage("Stock Take form print preview", controlToAdd, ImageList1, 0)

        'page.Selected = True
        'a.MainTabControl.TabPages.Add(page)
        'Me.Cursor = Cursors.Default

        Dim formx As StockTakingForm
        formx = New StockTakingForm(CategoryTree.SelectedNode.Tag, _
        Me.LookUpEdit_ItemType.Properties.LookUpData.KeyValue, _
        Me.Transactdate.DateTime, Me.RecordDate.DateTime, _
        Me.lookupArea.Properties.LookUpData.KeyValue, _
        Me.CheckBox1.Checked, Me.CheckBox2.Checked, _
        Me.CheckBox3.Checked, ExtProgressForm, False)

        formx.ShowDialog()
        ExtProgressForm.Close()

    End Sub

    Private Sub InitalAreaCombo()
        Dim dsArea As DataSet

        'Dim statusData As String() = New String() {"All"}
        'Dim statusID As String() = New String() {"0"}
        'SetComboValue(statusData, lookupArea, statusID)

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = 1 'WH_ID
            dsArea = .GetWarehouseArea

            Dim newRow As DataRow
            Dim rc As DataRowCollection

            rc = dsArea.Tables(0).Rows
            newRow = dsArea.Tables(0).NewRow()
            ' Assuming the table has two columns, set their values.
            newRow(0) = 0
            newRow(1) = "All"
            rc.Add(newRow)

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

            lookupArea.Properties.LookUpData.KeyValue = 0D
            lookupArea.SelectedText = "All"

        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub



    Private Sub StockTakeForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt = True And e.Control = True And e.KeyCode = Keys.P Then
            XtraButton1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton1.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        'Me.Cursor = Cursors.WaitCursor
        Dim ExtProgressForm
        ExtProgressForm = New TaskProgressForm
        'ExtProgressForm. = Me
        ExtProgressForm.Show()
        ExtProgressForm.Refresh()
        Dim formx As StockTakingForm
        formx = New StockTakingForm(CategoryTree.SelectedNode.Tag, Me.LookUpEdit_ItemType.Properties.LookUpData.KeyValue, Me.Transactdate.DateTime, Me.lookupArea.Properties.LookUpData.KeyValue, Me.CheckBox1.Checked, Me.CheckBox2.Checked, Me.CheckBox3.Checked, ExtProgressForm, True)
        formx.ShowDialog()
        ExtProgressForm.Close()
    End Sub
End Class
