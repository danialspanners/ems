Public Class StockViewerForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
    Dim searchbypartcode As Boolean
    Dim searchbylocation As Boolean

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.InitalAreaCombo()
        'PopulateGrid()

        Me.searchbylocation = False
        Me.searchbypartcode = False

        Transactdate.DateTime = Date.Today

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
    Friend WithEvents StockGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Partcode_txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_ByPartCode As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ByLocation As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lookupArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Transactdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.StockGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage_ByPartCode = New System.Windows.Forms.TabPage
        Me.Button5 = New System.Windows.Forms.Button
        Me.Partcode_txt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.TabPage_ByLocation = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.lookupArea = New DevExpress.XtraEditors.LookUpEdit
        Me.lblArea = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Transactdate = New DevExpress.XtraEditors.DateEdit
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.StockGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_ByPartCode.SuspendLayout()
        CType(Me.Partcode_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_ByLocation.SuspendLayout()
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StockGrid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 379)
        Me.Panel1.TabIndex = 0
        '
        'StockGrid
        '
        Me.StockGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockGrid.EditorsRepository = Me.PersistentRepository1
        Me.StockGrid.Location = New System.Drawing.Point(0, 0)
        Me.StockGrid.MainView = Me.GridView1
        Me.StockGrid.Name = "StockGrid"
        Me.StockGrid.Size = New System.Drawing.Size(760, 379)
        Me.StockGrid.TabIndex = 0
        Me.StockGrid.Text = "stockgrid"
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
        Me.GridView1.BehaviorOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.BorderStyle = DevExpress.XtraGrid.Views.Grid.ViewBorderStyle.Border3D
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 72)
        Me.Panel2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_ByPartCode)
        Me.TabControl1.Controls.Add(Me.TabPage_ByLocation)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(540, 72)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage_ByPartCode
        '
        Me.TabPage_ByPartCode.Controls.Add(Me.Button5)
        Me.TabPage_ByPartCode.Controls.Add(Me.Partcode_txt)
        Me.TabPage_ByPartCode.Controls.Add(Me.Label1)
        Me.TabPage_ByPartCode.Controls.Add(Me.Button3)
        Me.TabPage_ByPartCode.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ByPartCode.Name = "TabPage_ByPartCode"
        Me.TabPage_ByPartCode.Size = New System.Drawing.Size(532, 46)
        Me.TabPage_ByPartCode.TabIndex = 0
        Me.TabPage_ByPartCode.Text = "By Part Code"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(388, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(22, 22)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "..."
        '
        'Partcode_txt
        '
        Me.Partcode_txt.Location = New System.Drawing.Point(68, 14)
        Me.Partcode_txt.Name = "Partcode_txt"
        Me.Partcode_txt.Size = New System.Drawing.Size(318, 21)
        Me.Partcode_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Part code:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(418, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "OK"
        '
        'TabPage_ByLocation
        '
        Me.TabPage_ByLocation.Controls.Add(Me.Button4)
        Me.TabPage_ByLocation.Controls.Add(Me.lookupArea)
        Me.TabPage_ByLocation.Controls.Add(Me.lblArea)
        Me.TabPage_ByLocation.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ByLocation.Name = "TabPage_ByLocation"
        Me.TabPage_ByLocation.Size = New System.Drawing.Size(532, 46)
        Me.TabPage_ByLocation.TabIndex = 1
        Me.TabPage_ByLocation.Text = "By Location"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(282, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "OK"
        '
        'lookupArea
        '
        Me.lookupArea.Location = New System.Drawing.Point(64, 14)
        Me.lookupArea.Name = "lookupArea"
        Me.lookupArea.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupArea.Properties.NullString = ""
        Me.lookupArea.Properties.PopupWidth = 216
        Me.lookupArea.Size = New System.Drawing.Size(206, 21)
        Me.lookupArea.TabIndex = 0
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(20, 16)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 198
        Me.lblArea.Text = "Area :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Transactdate)
        Me.Panel4.Controls.Add(Me.CheckBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(540, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 72)
        Me.Panel4.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Balance date:"
        '
        'Transactdate
        '
        Me.Transactdate.DateTime = New Date(CType(0, Long))
        Me.Transactdate.Location = New System.Drawing.Point(14, 28)
        Me.Transactdate.Name = "Transactdate"
        Me.Transactdate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.Transactdate.Properties.MaskData.EditMask = "##/##/####"
        Me.Transactdate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Transactdate.Size = New System.Drawing.Size(136, 21)
        Me.Transactdate.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(16, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 24)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Only show Qty > 0"
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Location = New System.Drawing.Point(700, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 72)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Refresh"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 451)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(760, 44)
        Me.Panel3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(670, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        '
        'StockViewerForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 495)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "StockViewerForm"
        Me.Text = "Stock Viewer"
        Me.Panel1.ResumeLayout(False)
        CType(Me.StockGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_ByPartCode.ResumeLayout(False)
        CType(Me.Partcode_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_ByLocation.ResumeLayout(False)
        CType(Me.lookupArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public dataGrid As System.Data.DataTable
    Public data As System.Data.DataTable

    Private Sub InitStockGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()

        AddColumn(data, "Stock ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Warehouse ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Area ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Product ID", System.Type.GetType("System.Decimal"), True)

        AddColumn(data, "Part Code", System.Type.GetType("System.String"), True)
        AddColumn(data, "Warehouse", System.Type.GetType("System.String"), True)
        AddColumn(data, "Area", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int32"), True)
        AddColumn(data, "Category", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Alt Description", System.Type.GetType("System.String"), True)

        data.EndInit()
    End Sub

    Private Sub InitStockGridArea()
        data = New DataTable("ColumnsTable")
        data.BeginInit()

        AddColumn(data, "Stock ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Warehouse ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Area ID", System.Type.GetType("System.Decimal"), True)
        AddColumn(data, "Product ID", System.Type.GetType("System.Decimal"), True)

        AddColumn(data, "Part Code", System.Type.GetType("System.String"), True)
        AddColumn(data, "Warehouse", System.Type.GetType("System.String"), True)
        AddColumn(data, "Area", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int32"), True)
        AddColumn(data, "Category", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Alt Description", System.Type.GetType("System.String"), True)

        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data1.Columns.Add(col)
    End Sub

    Public Sub PopulateGrid(Optional ByVal recal As Boolean = False)
        Dim ds As DataSet

        StockGrid.DataSource = Nothing

        'AccessCount = AccessCount + 1
        With New BusinessRules.BusRules.InventoryBusLogic
            '.Product_ID = 0
            .SearchProductName = Me.Partcode_txt.Text & "%"
            If Transactdate.DateTime <> Date.Today Or recal = True Then
                If Me.CheckBox1.Checked = True Then
                    ds = .GetStock(Transactdate.DateTime, True)
                Else
                    ds = .GetStock(Transactdate.DateTime, False)
                End If
            Else
                If Me.CheckBox1.Checked = True Then
                    ds = .GetStockNonZero()
                Else
                    ds = .GetStock()
                End If
            End If

            If Not ds Is Nothing Then
                InitStockGrid()

                Dim oRow As DataRow
                Dim i As Integer = 0
                'Dim CompTotal As Double

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() { _
                    oRow("Stock_ID"), _
                    oRow("Warehouse_ID"), _
                    oRow("Warehouse_Area_ID"), _
                    oRow("Product_Id"), _
                    oRow("Product"), _
                    oRow("Warehouse"), _
                    oRow("Warehouse_Area"), _
                    oRow("Qty"), _
                    oRow("Category"), _
                    oRow("Description"), _
                    oRow("Alt_Description")})
                Next

                StockGrid.DataSource = data
                StockGrid.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item("Stock ID").VisibleIndex = -1 'hide StockID column
                GridView1.Columns.Item("Warehouse ID").VisibleIndex = -1 'hide CategoryID column
                GridView1.Columns.Item("Area ID").VisibleIndex = -1 'hide ProductID column
                GridView1.Columns.Item("Product ID").VisibleIndex = -1 'hide ProductID column

                GridView1.Columns("Part Code").Width = 200
                GridView1.Columns("Area").Width = 150
                GridView1.Columns("Qty").Width = 100

            Else
                GridView1.Columns.Clear()
            End If
        End With
    End Sub

    Public Sub PopulateGridArea()
        Dim ds As DataSet

        StockGrid.DataSource = Nothing

        'AccessCount = AccessCount + 1
        With New BusinessRules.BusRules.InventoryBusLogic
            '.Product_ID = 0
            .SearchByAreaId = Me.lookupArea.Properties.LookUpData.KeyValue
            If Transactdate.DateTime <> Date.Today Then
                If Me.CheckBox1.Checked = True Then
                    ds = .GetStock(Transactdate.DateTime, True)
                Else
                    ds = .GetStock(Transactdate.DateTime, False)
                End If
            Else
                If Me.CheckBox1.Checked = True Then
                    ds = .GetStockNonZero()
                Else
                    ds = .GetStock()
                End If
            End If

            If Not ds Is Nothing Then
                InitStockGridArea()

                Dim oRow As DataRow
                Dim i As Integer = 0
                'Dim CompTotal As Double

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() { _
                    oRow("Stock_ID"), _
                    oRow("Warehouse_ID"), _
                    oRow("Warehouse_Area_ID"), _
                    oRow("Product_Id"), _
                    oRow("Product"), _
                    oRow("Warehouse"), _
                    oRow("Warehouse_Area"), _
                    oRow("Qty"), _
                    oRow("Category"), _
                    oRow("Description"), _
                    oRow("Alt_Description")})
                Next

                StockGrid.DataSource = data
                StockGrid.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item("Stock ID").VisibleIndex = -1 'hide StockID column
                GridView1.Columns.Item("Warehouse ID").VisibleIndex = -1 'hide CategoryID column
                GridView1.Columns.Item("Area ID").VisibleIndex = -1 'hide ProductID column
                GridView1.Columns.Item("Product ID").VisibleIndex = -1 'hide ProductID column
                GridView1.Columns.Item("Warehouse").VisibleIndex = -1
                GridView1.Columns.Item("Area").VisibleIndex = -1

                GridView1.Columns("Part Code").Width = 200
                GridView1.Columns("Area").Width = 150
                GridView1.Columns("Qty").Width = 100

            Else
                GridView1.Columns.Clear()
            End If
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.searchbylocation = True Then
            Me.PopulateGridArea()
        Else
            Me.PopulateGrid(1)
        End If

        Me.StockGrid.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Len(Me.Partcode_txt.Text) > 0 Then
            Me.PopulateGrid()
            Me.StockGrid.Focus()
            Me.searchbypartcode = True
            Me.searchbylocation = False
        End If
    End Sub

    Private Sub Partcode_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Partcode_txt.KeyPress

    End Sub

    Private Sub Partcode_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Partcode_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub StockViewerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Partcode_txt.Focus()
    End Sub

    Private Sub StockViewerForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub InitalAreaCombo()
        Dim dsArea As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            .WH_ID = 1 'WH_ID
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

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Len(Me.lookupArea.Text) > 0 Then
            Me.PopulateGridArea()
            Me.StockGrid.Focus()
            Me.searchbypartcode = False
            Me.searchbylocation = True
        End If
    End Sub

    Private Sub TabPage_ByLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage_ByLocation.Click

    End Sub

    Private Sub lookupArea_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lookupArea.CloseUp

    End Sub

    Private Sub lookupArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lookupArea.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Button4_Click(sender, e)
        End If
    End Sub

    Private Sub lookupArea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lookupArea.KeyDown
        If e.KeyCode = Keys.Down Then
            lookupArea.DoPopup()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim searchform As SearchProduct
        searchform = New SearchProduct("product")
        searchform.ShowDialog()
        If searchform.DialogResult = DialogResult.OK Then
            Partcode_txt.Text = searchform.ReturnString
        End If

        Partcode_txt.Focus()
    End Sub
End Class
