Public Class LowStockAlertForm
    Inherits System.Windows.Forms.Form

    Public UserID As String = Common.CommonConn.Config.USERID
    Public dsStock As DataSet
    Public data As System.Data.DataTable

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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblTotalRecords As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents grdStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents RefreshBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LowStockAlertForm))
        Me.grdStock = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.lblTotalRecords = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.RefreshBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintBtn = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdStock
        '
        Me.grdStock.EditorsRepository = Me.PersistentRepository1
        Me.grdStock.Location = New System.Drawing.Point(8, 8)
        Me.grdStock.MainView = Me.GridView1
        Me.grdStock.Name = "grdStock"
        Me.grdStock.Size = New System.Drawing.Size(776, 368)
        Me.grdStock.TabIndex = 9
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
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(696, 384)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(88, 32)
        Me.CloseBtn.TabIndex = 22
        Me.CloseBtn.Text = "Close"
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.Location = New System.Drawing.Point(16, 384)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(88, 16)
        Me.lblTotalRecords.TabIndex = 23
        Me.lblTotalRecords.Text = "Total Records :"
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(104, 384)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(64, 16)
        Me.lblCount.TabIndex = 24
        '
        'RefreshBtn
        '
        Me.RefreshBtn.AutoSize = False
        Me.RefreshBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.Image = Nothing
        Me.RefreshBtn.Location = New System.Drawing.Point(504, 384)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(88, 32)
        Me.RefreshBtn.TabIndex = 30
        Me.RefreshBtn.Text = "Refresh"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PrintBtn
        '
        Me.PrintBtn.AutoSize = False
        Me.PrintBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Image = Nothing
        Me.PrintBtn.Location = New System.Drawing.Point(600, 384)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(88, 32)
        Me.PrintBtn.TabIndex = 32
        Me.PrintBtn.Text = "Print"
        '
        'LowStockAlertForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 423)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.grdStock)
        Me.Name = "LowStockAlertForm"
        Me.Text = "Low Stock Alert"
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Form Load"
    Private Sub LowStockAlertForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        PopulateGrid()
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region " Component Grid Functions"
    Public Sub PopulateGrid()
        grdStock.DataSource = Nothing

        With New BusinessRules.BusRules.InventoryBusLogic
            dsStock = .GetLowStock()
            If Not dsStock Is Nothing Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In dsStock.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {i, oRow("Product"), oRow("Description"), oRow("Category"), oRow("Min_Qty"), oRow("Total_Qty"), oRow("UOM")})
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
                PrintBtn.Enabled = False
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "S/No", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Product Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Category", System.Type.GetType("System.String"), True)
        AddColumn(data, "Min Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Total Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Unit", System.Type.GetType("System.String"), True)
        'AddColumn(data, "WH ID", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "WHA ID", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Location ID", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        'AddColumn(data, "UOM", System.Type.GetType("System.String"), True)
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

    Private Sub CloseBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Stock_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New MinInventoryReportForm(Stock_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Low Stock Alert Report", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

    Private Sub LowStockAlertForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
