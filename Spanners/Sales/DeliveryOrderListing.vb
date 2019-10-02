Public Class DOListingForm
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
    Friend WithEvents WOGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PrintDOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QACompletedGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents lbSelectedRows As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DOListingForm))
        Me.WOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PrintDOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.QACompletedGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lbSelectedRows = New System.Windows.Forms.Label
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QACompletedGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WOGrid
        '
        Me.WOGrid.EditorsRepository = Me.PersistentRepository2
        Me.WOGrid.Location = New System.Drawing.Point(8, 8)
        Me.WOGrid.MainView = Me.GridView1
        Me.WOGrid.Name = "WOGrid"
        Me.WOGrid.Size = New System.Drawing.Size(776, 216)
        Me.WOGrid.TabIndex = 3
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 424)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(96, 24)
        Me.RefreshBtn.TabIndex = 14
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'Timer1
        '
        '
        'PrintDOBtn
        '
        Me.PrintDOBtn.AutoSize = False
        Me.PrintDOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintDOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintDOBtn.Image = Nothing
        Me.PrintDOBtn.Location = New System.Drawing.Point(584, 416)
        Me.PrintDOBtn.Name = "PrintDOBtn"
        Me.PrintDOBtn.Size = New System.Drawing.Size(120, 32)
        Me.PrintDOBtn.TabIndex = 15
        Me.PrintDOBtn.Text = "Print Delivery Order"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(712, 416)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 16
        Me.CloseBtn.Text = "Close"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(504, 416)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QACompletedGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 176)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delivery Order Details (press shift or ctrl to multiselect to print)"
        '
        'QACompletedGrid
        '
        Me.QACompletedGrid.EditorsRepository = Me.PersistentRepository2
        Me.QACompletedGrid.Location = New System.Drawing.Point(8, 16)
        Me.QACompletedGrid.MainView = Me.GridView2
        Me.QACompletedGrid.Name = "QACompletedGrid"
        Me.QACompletedGrid.Size = New System.Drawing.Size(760, 152)
        Me.QACompletedGrid.TabIndex = 131
        Me.QACompletedGrid.Text = "GridControl1"
        '
        'GridView2
        '
        Me.GridView2.BehaviorOptions = CType(((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.MultiSelect) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn3, Me.GridColumn6, Me.GridColumn5})
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        Me.GridView2.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "QA_ID"
        Me.GridColumn1.FieldName = "QA_ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Box"
        Me.GridColumn4.FieldName = "Box"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.FieldName = "Qty"
        Me.GridColumn3.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 45
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Compl'n Date"
        Me.GridColumn6.FieldName = "Compl_Date"
        Me.GridColumn6.FormatString = "d"
        Me.GridColumn6.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.DateTime
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Inspected"
        Me.GridColumn5.FieldName = "Inspected"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.VisibleIndex = 3
        '
        'lbSelectedRows
        '
        Me.lbSelectedRows.BackColor = System.Drawing.SystemColors.Window
        Me.lbSelectedRows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSelectedRows.Enabled = False
        Me.lbSelectedRows.Location = New System.Drawing.Point(112, 416)
        Me.lbSelectedRows.Name = "lbSelectedRows"
        Me.lbSelectedRows.Size = New System.Drawing.Size(284, 30)
        Me.lbSelectedRows.TabIndex = 57
        Me.lbSelectedRows.Visible = False
        '
        'DOListingForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 453)
        Me.Controls.Add(Me.lbSelectedRows)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.PrintDOBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.WOGrid)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "DOListingForm"
        Me.Text = "Outstanding DO Listing"
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.QACompletedGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    Dim DOQAds As DataSet

#Region " Work Order Line Variable "
    Public WO_Line_ID As Integer
#End Region

#Region " Form Load "
    Private Sub DOListingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDOList()
        'Timer1.Interval = 60000
        'Timer1.Start()
    End Sub

    Private Sub LoadDOList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If .GetDOListing(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentConfirmQuotationNo As String
                Dim ProjectTitle As String

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1

                        Select Case (oRow("Status"))
                            Case "10" : Status = "Preparing"
                            Case "20" : Status = "Pending"
                            Case "30" : Status = "Confirmed"
                            Case "40" : Status = "Revised"
                            Case "50" : Status = "Cancel"
                            Case "60" : Status = "Lost"
                        End Select

                        With New BusinessRules.SystemBusRules.ProjectBusLogic
                            If .GetProject(dsProject, oRow("Project")) Then
                                If Not dsProject Is Nothing Then
                                    ProjectTitle = oRow("ProjectSub") & " " & dsProject.Tables(0).Rows(0)("Project_Name")
                                End If
                            End If
                        End With
                        data.Rows.Add(New Object() {oRow("WO_ID"), i, oRow("WO_No"), ChangeDateFormat(oRow("WO_Date")), ProjectTitle, oRow("CustomerName"), oRow("Inspected"), oRow("Qty"), oRow("WO_Line_ID")})
                        'data.Rows.Add(New Object() {oRow("WO_ID"), i, oRow("WO_No"), ChangeDateFormat(oRow("WO_Date")), oRow("Status"), Status, ProjectTitle, oRow("CustomerName"), oRow("Inspected")})
                    Next
                    WOGrid.DataSource = data
                    WOGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    GridView1.Columns.Item(8).VisibleIndex = -1 'hide 4th. Status
                    WO_Line_ID = ds.Tables(0).Rows(0)("WO_Line_ID").ToString()
                    SetButtonsControl(True)
                    LoadQACompletedGrid()
                Else
                    GridView1.Columns.Clear()
                    SetButtonsControl(False)
                End If
                ds.Dispose()
            End If
        End With
    End Sub

    Private Sub LoadQACompletedGrid()
        'Dim ds As DataSet

        With New BusinessRules.QABusRules.QABusLogic
            .WO_Line_ID = WO_Line_ID
            If .GetQA(DOQAds, 1) Then
                QACompletedGrid.DataSource = DOQAds.Tables(0).DefaultView
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "WOID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Work Order No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Date", System.Type.GetType("System.String"), True)
        'AddColumn(data, "StatusCode", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Status", System.Type.GetType("System.String"), True)
        AddColumn(data, "Project", System.Type.GetType("System.String"), True)
        AddColumn(data, "Customer Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Inspected Status", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "WOLineID", System.Type.GetType("System.Int16"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub
#End Region

#Region " Timer"
    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        'If RefreshBtn.Checked = True Then
        'Timer1.Interval = 60000
        'Timer1.Start()
        'Else
        '    Timer1.Stop()
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadDOList()
    End Sub
#End Region

#Region " Other Code "
    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then
            pDate = Date.Parse(pInputDate)
            tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
        End If

        Return tempsDate
    End Function

    Private Sub SetButtonsControl(ByVal State As Boolean)
        PrintDOBtn.Enabled = State
    End Sub
#End Region

    Private Sub PrintDOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDOBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New DeliveryOrderForm(WO_ID)
            page = New Crownwood.Magic.Controls.TabPage("Delivery Order", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub DOListingForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadDOList()
        End If
    End Sub

    Private Sub WOGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WOGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadDOList()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadDOList()
    End Sub

    Private Sub GridView2_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.SelectionChangedEventArgs) Handles GridView2.SelectionChanged
        lbSelectedRows.Text = ArrayToString(GridView2.GetSelectedRows())
        lbSelectedRows.Text = DataRowsToString(GridView2.GetSelectedRows())
    End Sub

    Public Function DataRowsToString(ByVal arr As Int32()) As String
        Dim s As String = ""
        Dim i As Integer
        If (arr Is Nothing) Then
            s = "Empty..."
        Else
            For Each i In arr
                s += IIf(s = "", "", ";") + DOQAds.Tables(0).Rows(i)("QA_ID").ToString() 'i.ToString()
            Next
            s += "."
        End If
        Return s
    End Function
    Public Function ArrayToString(ByVal arr As Int32()) As String
        Dim s As String = ""
        Dim i As Integer
        If (arr Is Nothing) Then
            s = "Empty..."
        Else
            For Each i In arr
                s += IIf(s = "", "", ";") + i.ToString()
            Next
            s += "."
        End If
        Return s
    End Function

    Private Sub WOGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WOGrid.Click
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)

                If dr("WOLineID").ToString() <> "" Then
                    DOQAds = Nothing
                    WO_Line_ID = dr("WOLineID")
                    LoadQACompletedGrid()
                End If
            End If
        End If
    End Sub

    Private Sub DOListingForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
