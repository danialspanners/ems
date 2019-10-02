Public Class OutstandingItemList
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
    Friend WithEvents POListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ViewPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents POListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents POLineFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents POLineToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.POListGrp = New System.Windows.Forms.GroupBox
        Me.POLineToDate = New DevExpress.XtraEditors.DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.POLineFromDate = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.ViewPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.POListGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.POListGrp.SuspendLayout()
        CType(Me.POLineToDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POLineFromDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POListGrp
        '
        Me.POListGrp.Controls.Add(Me.POLineToDate)
        Me.POListGrp.Controls.Add(Me.Label1)
        Me.POListGrp.Controls.Add(Me.POLineFromDate)
        Me.POListGrp.Controls.Add(Me.Label3)
        Me.POListGrp.Controls.Add(Me.btnRefresh)
        Me.POListGrp.Controls.Add(Me.PrintPOBtn)
        Me.POListGrp.Controls.Add(Me.CloseBtn)
        Me.POListGrp.Controls.Add(Me.RefreshBtn)
        Me.POListGrp.Controls.Add(Me.ViewPOBtn)
        Me.POListGrp.Controls.Add(Me.POListGrid)
        Me.POListGrp.Location = New System.Drawing.Point(8, 8)
        Me.POListGrp.Name = "POListGrp"
        Me.POListGrp.Size = New System.Drawing.Size(776, 408)
        Me.POListGrp.TabIndex = 3
        Me.POListGrp.TabStop = False
        Me.POListGrp.Text = "Item List"
        '
        'POLineToDate
        '
        Me.POLineToDate.DateTime = New Date(CType(0, Long))
        Me.POLineToDate.Location = New System.Drawing.Point(320, 24)
        Me.POLineToDate.Name = "POLineToDate"
        Me.POLineToDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.POLineToDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.POLineToDate.Size = New System.Drawing.Size(104, 19)
        Me.POLineToDate.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "To :"
        '
        'POLineFromDate
        '
        Me.POLineFromDate.DateTime = New Date(CType(0, Long))
        Me.POLineFromDate.Location = New System.Drawing.Point(88, 24)
        Me.POLineFromDate.Name = "POLineFromDate"
        Me.POLineFromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.POLineFromDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.POLineFromDate.Size = New System.Drawing.Size(104, 19)
        Me.POLineFromDate.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "From :"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(120, 368)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Refresh"
        '
        'PrintPOBtn
        '
        Me.PrintPOBtn.AutoSize = False
        Me.PrintPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPOBtn.Image = Nothing
        Me.PrintPOBtn.Location = New System.Drawing.Point(200, 368)
        Me.PrintPOBtn.Name = "PrintPOBtn"
        Me.PrintPOBtn.Size = New System.Drawing.Size(64, 32)
        Me.PrintPOBtn.TabIndex = 24
        Me.PrintPOBtn.Text = "Print"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(272, 368)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 368)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.TabIndex = 6
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'ViewPOBtn
        '
        Me.ViewPOBtn.AutoSize = False
        Me.ViewPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ViewPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPOBtn.Image = Nothing
        Me.ViewPOBtn.Location = New System.Drawing.Point(440, 368)
        Me.ViewPOBtn.Name = "ViewPOBtn"
        Me.ViewPOBtn.Size = New System.Drawing.Size(64, 32)
        Me.ViewPOBtn.TabIndex = 5
        Me.ViewPOBtn.Text = "View PO"
        Me.ViewPOBtn.Visible = False
        '
        'POListGrid
        '
        Me.POListGrid.EditorsRepository = Me.PersistentRepository1
        Me.POListGrid.Location = New System.Drawing.Point(8, 64)
        Me.POListGrid.MainView = Me.GridView1
        Me.POListGrid.Name = "POListGrid"
        Me.POListGrid.Size = New System.Drawing.Size(760, 288)
        Me.POListGrid.TabIndex = 2
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
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        '
        'OutstandingItemList
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 423)
        Me.Controls.Add(Me.POListGrp)
        Me.Name = "OutstandingItemList"
        Me.Text = "Outstanding PO Item Report"
        Me.POListGrp.ResumeLayout(False)
        CType(Me.POLineToDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POLineFromDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public POLine_Date_From As String
    Public POLine_Date_To As String
    Public dataPOGrid As System.Data.DataTable

#End Region

#Region " Event "

    Private Sub POList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        LoadPOFrmDB()
        'Timer1.Interval = 60000
        'Timer1.Start()
    End Sub

    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        If RefreshBtn.Checked = True Then
            Timer1.Interval = 60000
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadPOFrmDB()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub PrintPOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPOBtn.Click

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New OutstandingItemListReportForm(ChangeDateFormat(POLineFromDate.Text), ChangeDateFormat(POLineToDate.Text))
        page = New Crownwood.Magic.Controls.TabPage("Print Outstanding PO Item Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region " Grid Code "

    'Call once form load, Initalize PO Columns
    Private Sub InitPOList()

        dataPOGrid = New DataTable("ColumnsTable")
        dataPOGrid.BeginInit()

        AddColumn(dataPOGrid, "PO NO", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "PO Date", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "Delivery", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "Ord Qty", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "Rec Qty", System.Type.GetType("System.String"), True)

        dataPOGrid.EndInit()

    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub

    Private Sub ClearGrid(ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim i

        If GridView.RowCount() <> 0 Then
            GridView.FocusedRowHandle = 0
            For i = 0 To GridView.RowCount() - 1
                If GridView1.IsGroupRow(i) = False Then

                    GridView.DeleteRow(GridView.GetSelectedRows(0))
                    If GridView.RowCount() <> 0 Then
                        GridView.FocusedRowHandle = 0
                    End If

                End If
            Next
        End If
    End Sub

#End Region

#Region " Other Codes "

    'Change date format
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

    Private Sub LoadPOFrmDB()
        Dim ds As DataSet
        With New BusinessRules.POBusRules.POLineBusLogic
            If .LoadOutstandingPOItemReportList(ds, ChangeDateFormat(POLineFromDate.Text), ChangeDateFormat(POLineToDate.Text)) Then

                InitPOList()

                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In ds.Tables(0).Rows
                    dataPOGrid.Rows.Add(New Object() {oRow("PO_No"), _
                                                        oRow("Create_Date"), _
                                                        oRow("Name"), _
                                                        oRow("Delivery_Date"), _
                                                        oRow("Order_Qty"), _
                                                        oRow("Confirm_Qty")})
                Next

                POListGrid.DataSource = dataPOGrid
                POListGrid.DefaultView.PopulateColumns()

                GridView1.BestFitColumns()
            End If
        End With

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
        End If
    End Sub


#End Region

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadPOFrmDB()
    End Sub
    Private Sub OutstandingItemList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
