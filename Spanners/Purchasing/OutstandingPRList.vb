Public Class OutstandingPRForm
    Inherits System.Windows.Forms.Form


    Private FormType As Integer

#Region " Windows Form Designer generated code "


    Public Sub New(Optional ByVal pformtype As Integer = 0)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        FormType = pformtype

        If pformtype = 1 Then 'pending list

        End If

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
    Friend WithEvents ApproveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PRGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OutstandingPRForm))
        Me.PRGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.ApproveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRGrid
        '
        Me.PRGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRGrid.Location = New System.Drawing.Point(8, 8)
        Me.PRGrid.MainView = Me.GridView1
        Me.PRGrid.Name = "PRGrid"
        Me.PRGrid.Size = New System.Drawing.Size(776, 360)
        Me.PRGrid.TabIndex = 1
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
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 384)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.TabIndex = 4
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'ApproveBtn
        '
        Me.ApproveBtn.AutoSize = False
        Me.ApproveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ApproveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApproveBtn.Image = Nothing
        Me.ApproveBtn.Location = New System.Drawing.Point(584, 376)
        Me.ApproveBtn.Name = "ApproveBtn"
        Me.ApproveBtn.Size = New System.Drawing.Size(120, 32)
        Me.ApproveBtn.TabIndex = 8
        Me.ApproveBtn.Text = "View"
        '
        'Timer1
        '
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(712, 376)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 9
        Me.CloseBtn.Text = "Close"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(504, 376)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'OutstandingPRForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 423)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.ApproveBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.PRGrid)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "OutstandingPRForm"
        Me.Text = "Outstanding PR Listing"
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

    Private Sub OutstandingPRListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPRList()
    End Sub

    Private Sub LoadPRList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet
        Dim Rstatus As Boolean

        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If FormType = 0 Then 'pending for approval
                Rstatus = .GetPRHeader(ds, , "30")
            ElseIf FormType = 1 Then 'pending for purchasing
                Rstatus = .GetPRHeaderPendingPurchase(ds)
            End If

            If Rstatus Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1

                        Select Case (oRow("Status"))
                            Case "10" : Status = "Preparing"
                            Case "30" : Status = "Pending"
                            Case "40" : Status = "Approved"
                        End Select

                        data.Rows.Add(New Object() {oRow("PR_ID"), i, Status, oRow("PR_No"), oRow("Confirm_Quotation_No"), ChangeDateFormat(oRow("Submit_Date")), oRow("Requester_Name"), oRow("Approver_Name")})
                    Next
                    PRGrid.DataSource = data
                    PRGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    '## by alan
                    SetButtonsControl(True)
                Else
                    GridView1.Columns.Clear()
                    SetButtonsControl(False)
                End If
                '## end
            End If
        End With
    End Sub
    '## By Alan
    Private Sub SetButtonsControl(ByVal State As Boolean)
        ApproveBtn.Enabled = State
        '## End
    End Sub
    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "PR ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Status", System.Type.GetType("System.String"), True)
        AddColumn(data, "PR No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Order Confirmation No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Submit Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "Requester", System.Type.GetType("System.String"), True)
        AddColumn(data, "Approver", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
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
        LoadPRList()
    End Sub

    Private Sub ApproveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApproveBtn.Click

        PRGrid_DoubleClick(sender, e)
        Exit Sub


        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim PR_ID As Integer = dr(0)

            With New BusinessRules.PRBusRules.PRHeaderBusLogic
                .PR_ID = PR_ID
                .Status = "40"      'Confirm status
                '## By alan
                SetButtonsControl(True)
                '## End
                If .UpdatePRHeaderStatus() Then
                    MessageBox.Show("Status approve.", "Outstanding Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
            '## Added by Alan
            SetButtonsControl(False)
            '## End
            LoadPRList()
        End If
    End Sub

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
#End Region

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub OutstandingPRForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadPRList()
        End If
    End Sub

    Private Sub PRGrid_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PRGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadPRList()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadPRList()
    End Sub
    Private Sub OutstandingPRForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub PRGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PRGrid.DoubleClick
        Dim newform As PRList
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim PRID As Integer = dr(0)
                If PRID > 0 Then
                    Dim a As MainForm = Me.ParentForm
                    Dim controlToAdd As Control = Nothing
                    Me.Cursor = Cursors.WaitCursor

                    Me.Cursor = Cursors.WaitCursor

                    Dim page As Crownwood.Magic.Controls.TabPage
                    controlToAdd = New PRList(PRID, True)
                    page = New Crownwood.Magic.Controls.TabPage("PR for Approval", controlToAdd, ImageList1, 0)

                    page.Selected = True
                    a.MainTabControl.TabPages.Add(page)

                    Me.Cursor = Cursors.Arrow
                    'LoadPRList()
                End If
            End If
        End If

    End Sub

    Private Sub PRGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRGrid.Click

    End Sub

    Private Sub OutstandingPRForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub OutstandingPRForm_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        LoadPRList() ' Refresh everytime this form is active
    End Sub
End Class
