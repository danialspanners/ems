Public Class WOApprovalListForm
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
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ApproveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WOApprovalGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ApproveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.WOApprovalGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.WOApprovalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(448, 280)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(656, 280)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 14
        Me.CloseBtn.Text = "Close"
        '
        'ApproveBtn
        '
        Me.ApproveBtn.AutoSize = False
        Me.ApproveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ApproveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApproveBtn.Image = Nothing
        Me.ApproveBtn.Location = New System.Drawing.Point(528, 280)
        Me.ApproveBtn.Name = "ApproveBtn"
        Me.ApproveBtn.Size = New System.Drawing.Size(120, 32)
        Me.ApproveBtn.TabIndex = 13
        Me.ApproveBtn.Text = "Approve"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 280)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(96, 24)
        Me.RefreshBtn.TabIndex = 12
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'WOApprovalGrid
        '
        Me.WOApprovalGrid.EditorsRepository = Me.PersistentRepository1
        Me.WOApprovalGrid.Location = New System.Drawing.Point(8, 8)
        Me.WOApprovalGrid.MainView = Me.GridView1
        Me.WOApprovalGrid.Name = "WOApprovalGrid"
        Me.WOApprovalGrid.Size = New System.Drawing.Size(720, 264)
        Me.WOApprovalGrid.TabIndex = 11
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
        'Timer1
        '
        '
        'WOApprovalListForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 317)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.ApproveBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.WOApprovalGrid)
        Me.Name = "WOApprovalListForm"
        Me.Text = "Work Order Approval Listing"
        CType(Me.WOApprovalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

#Region " Form Load "
    Private Sub WOApprovalListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadWOApprovalList()
        'Timer1.Interval = 60000
        'Timer1.Start()
        'WOGrid_Click(sender, e)
    End Sub

    Private Sub LoadWOApprovalList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If .GetWOHeader(ds, 0, "20") Then
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
                            If Not IsDBNull(oRow("Project")) Then
                                .GetProject(dsProject, 0)
                            Else
                                If .GetProject(dsProject, oRow("Project")) Then
                                    If Not dsProject Is Nothing Then
                                        ProjectTitle = oRow("ProjectSub") & " " & dsProject.Tables(0).Rows(0)("Project_Name")
                                    End If
                                End If
                            End If
                        End With

                        data.Rows.Add(New Object() {oRow("WO_ID"), i, oRow("WO_No"), ChangeDateFormat(oRow("WO_Date")), oRow("Status"), Status, ProjectTitle, oRow("CustomerName"), oRow("Initial")})
                    Next
                    WOApprovalGrid.DataSource = data
                    WOApprovalGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    GridView1.Columns.Item(4).VisibleIndex = -1 'hide 4th. Status
                    SetButtonsControl(True)
                Else
                    GridView1.Columns.Clear()
                    SetButtonsControl(False)
                End If
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
        AddColumn(data, "StatusCode", System.Type.GetType("System.String"), True)
        AddColumn(data, "Status", System.Type.GetType("System.String"), True)
        AddColumn(data, "Project", System.Type.GetType("System.String"), True)
        AddColumn(data, "Customer Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Code", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
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
        'btnRefresh.Enabled = State
        ApproveBtn.Enabled = State
        'CloseBtn.Enabled = State
    End Sub
#End Region

    Private Sub WOApprovalGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WOApprovalGrid.Click

    End Sub

#Region " Timer"
    Private Sub RefreshBtn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        If RefreshBtn.Checked = True Then
            Timer1.Interval = 60000
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadWOApprovalList()
        WOApprovalGrid_Click(sender, e)
    End Sub
#End Region

    Private Sub ApproveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApproveBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)

            With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                .WO_ID = WO_ID
                .UserID = UserID
                .Status = "30"      'Confirm status
                If .UpdateWOHeaderStatus() Then
                    MessageBox.Show("Status approve.", "Work Order Approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
            LoadWOApprovalList()
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub WOApprovalListForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
