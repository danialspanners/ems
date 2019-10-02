Public Class DrawingNoListForm
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents DelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DrawingNoGrid As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DrawingNoGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.DelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EditBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.DrawingNoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawingNoGrid
        '
        Me.DrawingNoGrid.EditorsRepository = Me.PersistentRepository1
        Me.DrawingNoGrid.Location = New System.Drawing.Point(0, 16)
        Me.DrawingNoGrid.MainView = Me.GridView1
        Me.DrawingNoGrid.Name = "DrawingNoGrid"
        Me.DrawingNoGrid.Size = New System.Drawing.Size(712, 296)
        Me.DrawingNoGrid.TabIndex = 2
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
        Me.RefreshBtn.Checked = True
        Me.RefreshBtn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RefreshBtn.Location = New System.Drawing.Point(16, 328)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.TabIndex = 13
        Me.RefreshBtn.Text = "Auto Refresh"
        '
        'DelBtn
        '
        Me.DelBtn.AutoSize = False
        Me.DelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.Image = Nothing
        Me.DelBtn.Location = New System.Drawing.Point(560, 320)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(72, 32)
        Me.DelBtn.TabIndex = 12
        Me.DelBtn.Text = "&Delete"
        '
        'EditBtn
        '
        Me.EditBtn.AutoSize = False
        Me.EditBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Image = Nothing
        Me.EditBtn.Location = New System.Drawing.Point(192, 320)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(72, 32)
        Me.EditBtn.TabIndex = 11
        Me.EditBtn.Text = "&Edit"
        Me.EditBtn.Visible = False
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(640, 320)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 15
        Me.CloseBtn.Text = "Close"
        '
        'PrintBtn
        '
        Me.PrintBtn.AutoSize = False
        Me.PrintBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Image = Nothing
        Me.PrintBtn.Location = New System.Drawing.Point(352, 320)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(120, 32)
        Me.PrintBtn.TabIndex = 16
        Me.PrintBtn.Text = "Print Drawing List"
        '
        'NewBtn
        '
        Me.NewBtn.AutoSize = False
        Me.NewBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBtn.Image = Nothing
        Me.NewBtn.Location = New System.Drawing.Point(480, 320)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(72, 32)
        Me.NewBtn.TabIndex = 17
        Me.NewBtn.Text = "&New"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(272, 320)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "Refresh"
        '
        'DrawingNoListForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 365)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.NewBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.DrawingNoGrid)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "DrawingNoListForm"
        Me.Text = "Drawing No. Listing"
        CType(Me.DrawingNoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    ' 05.01.2004 YG Start
    Dim FunctionName As String = "MyDrawingNo"
    ' 05.01.2004 YG End

#Region " Form Load "
    Private Sub DrawingNoListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 05.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewBtn.Enabled = True
        Else
            NewBtn.Enabled = False
        End If

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DelBtn.Enabled = True
        Else
            DelBtn.Enabled = False
        End If
        ' 05.01.2004 YG End

        LoadDrawingList()
        Timer1.Interval = 60000
        Timer1.Start()
        DrawingGrid_Click(sender, e)
    End Sub

    Private Sub LoadDrawingList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.DrawingBusRules.DrawingBusLogic
            If .GetDrawing(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1
                        data.Rows.Add(New Object() {oRow("Drawing_ID"), oRow("Drawing_No"), oRow("Drawing_Type"), UCase(oRow("DrawnBy")), UCase(oRow("IssueTo")), oRow("Issue_Date"), oRow("Customer")})
                    Next
                    DrawingNoGrid.DataSource = data
                    DrawingNoGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    'GridView1.Columns.Item(4).VisibleIndex = -1 'hide 4th. Status
                    ' 05.01.2004 YG Start
                    '                    SetButtonsControl(True)
                    PrintBtn.Enabled = True
                    EditBtn.Enabled = True
                    ' 05.01.2004 YG End
                Else
                    GridView1.Columns.Clear()
                    ' 05.01.2004 YG Start
                    '                    SetButtonsControl(False)
                    PrintBtn.Enabled = False
                    EditBtn.Enabled = False
                    DelBtn.Enabled = False
                    ' 05.01.2004 YG End
                End If
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Drawing No.", System.Type.GetType("System.String"), True)
        AddColumn(data, "Drawing Type", System.Type.GetType("System.String"), True)
        AddColumn(data, "Drawn By", System.Type.GetType("System.String"), True)
        AddColumn(data, "Issue To", System.Type.GetType("System.String"), True)
        AddColumn(data, "Issue Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "Customer", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub
#End Region

    Private Sub DrawingGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrawingNoGrid.Click
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
            End If
        End If
    End Sub

#Region " Button Event"

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub DrawingNoListForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadDrawingList()
        End If
    End Sub

    Private Sub DrawingGrid_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DrawingNoGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadDrawingList()
        End If
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Drawing_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New DrawingNoReportForm(Drawing_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Drawing List", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Drawing_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this Drawing?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.DrawingBusRules.DrawingBusLogic
                    If .DeleteDrawing(Drawing_ID) Then
                        MessageBox.Show("Drawing Deleted.", "Manage Drawing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            Me.LoadDrawingList()
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Drawing_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            controlToAdd = New ManageDrawingNoForm("EDIT", Drawing_ID)
            page = New Crownwood.Magic.Controls.TabPage("Edit Drawing", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub NewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage

        controlToAdd = New ManageDrawingNoForm("NEW")
        page = New Crownwood.Magic.Controls.TabPage("New Drawing", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadDrawingList()
    End Sub
#End Region

#Region " Timer"
    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        If RefreshBtn.Checked = True Then
            Timer1.Interval = 60000
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadDrawingList()
        DrawingGrid_Click(sender, e)
    End Sub
#End Region

#Region " Other Code "
    Private Sub SetButtonsControl(ByVal State As Boolean)
        PrintBtn.Enabled = State
        NewBtn.Enabled = True
        EditBtn.Enabled = State
        DelBtn.Enabled = State
    End Sub
#End Region

    Private Sub DrawingNoListForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
