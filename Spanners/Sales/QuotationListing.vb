Public Class QuotationListForm
    Inherits System.Windows.Forms.Form

    Public UserID As String = Common.CommonConn.Config.USERID
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintQuotationDlg As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents DelBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents RevisedBtn As System.Windows.Forms.Button
    Friend WithEvents CreateOCBtn As System.Windows.Forms.Button
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents EditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
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
    Friend WithEvents QuotationGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintBtn1 As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuotationListForm))
        Me.QuotationGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintBtn1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CloseBtn = New System.Windows.Forms.Button
        Me.DelBtn = New System.Windows.Forms.Button
        Me.EditBtn = New System.Windows.Forms.Button
        Me.RevisedBtn = New System.Windows.Forms.Button
        Me.CreateOCBtn = New System.Windows.Forms.Button
        Me.PrintQuotationDlg = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.EditMenu = New System.Windows.Forms.MenuItem
        Me.DeleteMenu = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.QuotationGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuotationGrid
        '
        Me.QuotationGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuotationGrid.EditorsRepository = Me.PersistentRepository1
        Me.QuotationGrid.Location = New System.Drawing.Point(0, 0)
        Me.QuotationGrid.MainView = Me.GridView1
        Me.QuotationGrid.Name = "QuotationGrid"
        Me.QuotationGrid.Size = New System.Drawing.Size(792, 358)
        Me.QuotationGrid.TabIndex = 0
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
        Me.RefreshBtn.Location = New System.Drawing.Point(16, 14)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(72, 24)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'PrintBtn
        '
        Me.PrintBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Image = Nothing
        Me.PrintBtn.Location = New System.Drawing.Point(16, 44)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(84, 17)
        Me.PrintBtn.TabIndex = 7
        Me.PrintBtn.Text = "Print Quotation"
        Me.PrintBtn.Visible = False
        '
        'PrintBtn1
        '
        Me.PrintBtn1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn1.Image = Nothing
        Me.PrintBtn1.Location = New System.Drawing.Point(16, 30)
        Me.PrintBtn1.Name = "PrintBtn1"
        Me.PrintBtn1.Size = New System.Drawing.Size(102, 17)
        Me.PrintBtn1.TabIndex = 9
        Me.PrintBtn1.Text = "Print Quotation (B)"
        Me.PrintBtn1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.DelBtn)
        Me.Panel1.Controls.Add(Me.EditBtn)
        Me.Panel1.Controls.Add(Me.RevisedBtn)
        Me.Panel1.Controls.Add(Me.CreateOCBtn)
        Me.Panel1.Controls.Add(Me.PrintQuotationDlg)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.PrintBtn)
        Me.Panel1.Controls.Add(Me.PrintBtn1)
        Me.Panel1.Controls.Add(Me.RefreshBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 358)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 65)
        Me.Panel1.TabIndex = 11
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(680, 14)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 38)
        Me.CloseBtn.TabIndex = 17
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(608, 14)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(64, 38)
        Me.DelBtn.TabIndex = 16
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(528, 14)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(72, 38)
        Me.EditBtn.TabIndex = 15
        Me.EditBtn.Text = "Open"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'RevisedBtn
        '
        Me.RevisedBtn.Location = New System.Drawing.Point(392, 14)
        Me.RevisedBtn.Name = "RevisedBtn"
        Me.RevisedBtn.Size = New System.Drawing.Size(128, 38)
        Me.RevisedBtn.TabIndex = 14
        Me.RevisedBtn.Text = "Create Revised Quote"
        Me.RevisedBtn.UseVisualStyleBackColor = True
        '
        'CreateOCBtn
        '
        Me.CreateOCBtn.Location = New System.Drawing.Point(240, 14)
        Me.CreateOCBtn.Name = "CreateOCBtn"
        Me.CreateOCBtn.Size = New System.Drawing.Size(144, 38)
        Me.CreateOCBtn.TabIndex = 13
        Me.CreateOCBtn.Text = "Create Order Confirmation"
        Me.CreateOCBtn.UseVisualStyleBackColor = True
        '
        'PrintQuotationDlg
        '
        Me.PrintQuotationDlg.Location = New System.Drawing.Point(144, 14)
        Me.PrintQuotationDlg.Name = "PrintQuotationDlg"
        Me.PrintQuotationDlg.Size = New System.Drawing.Size(88, 38)
        Me.PrintQuotationDlg.TabIndex = 12
        Me.PrintQuotationDlg.Text = "Print Quotation"
        Me.PrintQuotationDlg.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(80, 14)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(56, 38)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.EditMenu, Me.DeleteMenu, Me.MenuItem4, Me.MenuItem1, Me.MenuItem3, Me.MenuItem5, Me.MenuItem2})
        '
        'EditMenu
        '
        Me.EditMenu.Index = 0
        Me.EditMenu.Text = "Open"
        '
        'DeleteMenu
        '
        Me.DeleteMenu.Index = 1
        Me.DeleteMenu.Text = "Delete"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "Create Order Confirmation"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Text = "Create Revised Quote"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Text = "Print..."
        '
        'QuotationListForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 423)
        Me.Controls.Add(Me.QuotationGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "QuotationListForm"
        Me.Text = "Quotation Listing"
        CType(Me.QuotationGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load n Grid "
    Private Sub QuotationListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadQuotationList()
        'Timer1.Interval = 60000
        'Timer1.Start()
        QuotationGrid_Click(sender, e)
    End Sub

    Public Sub LoadQuotationList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeader(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentQuotationNo As String
                Dim ProjectTitle As String

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1

                        Select Case (oRow("Status"))
                            Case "80" : Status = "Incomplete"
                            Case "10" : Status = "Preparing"
                            Case "20" : Status = "Pending"
                            Case "30" : Status = "Confirmed"
                            Case "40" : Status = "Revised"
                            Case "50" : Status = "Cancel"
                            Case "60" : Status = "Lost"
                            Case "70" : Status = "Merged"
                        End Select

                        If Not IsDBNull(oRow("RefQuotationID")) Then
                            If .GetQuotationHeader(dsParent, oRow("RefQuotationID")) Then
                                If dsParent.Tables(0).Rows.Count > 0 Then
                                    ParentQuotationNo = dsParent.Tables(0).Rows(0)("Quotation_NO")
                                Else
                                    ParentQuotationNo = ""
                                End If
                            End If
                        End If

                        With New BusinessRules.SystemBusRules.ProjectBusLogic
                            If Not IsDBNull(oRow("Project")) Then
                                If .GetProject(dsProject, oRow("Project")) Then
                                    If Not dsProject Is Nothing Then
                                        ProjectTitle = oRow("ProjectSub") & " " & dsProject.Tables(0).Rows(0)("Project_Name")
                                    End If
                                Else
                                    ProjectTitle = ""
                                End If
                            Else
                                ProjectTitle = ""
                            End If
                        End With

                        ' 29.10.2003 YG Start
                        '                        data.Rows.Add(New Object() {oRow("Quotation_ID"), i, oRow("Quotation_No"), ChangeDateFormat(oRow("QuotationDate")), oRow("Status"), Status, ProjectTitle, oRow("CustomerName"), oRow("Initial"), ParentQuotationNo})
                        data.Rows.Add(New Object() {oRow("Quotation_ID"), i, oRow("Quotation_No"), ChangeDateFormat(oRow("QuotationDate")), oRow("Status"), oRow("Order_Type"), Status, ProjectTitle, oRow("CustomerName"), oRow("Initial"), oRow("Login_Id")}) ', ParentQuotationNo})
                        ' 29.10.2003 YG End
                    Next
                    QuotationGrid.DataSource = data
                    QuotationGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(1).VisibleIndex = -1 'hide index no. totally useless!
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    GridView1.Columns.Item(4).VisibleIndex = -1 'hide 4th. Status
                    ' 29.10.2003 YG Start
                    GridView1.Columns.Item(5).VisibleIndex = -1 'hide 5th. OrderType
                    ' 29.10.2003 YG End
                    GridView1.Columns.Item(2).Width = 100
                    GridView1.Columns.Item(3).Width = 50
                    GridView1.Columns.Item(5).Width = 50
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
        AddColumn(data, "QID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Quotation No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "StatusCode", System.Type.GetType("System.String"), True)
        ' 29.10.2003 YG Start
        AddColumn(data, "OrderType", System.Type.GetType("System.String"), True)
        ' m29.10.2003 YG End
        AddColumn(data, "Status", System.Type.GetType("System.String"), True)
        AddColumn(data, "Project", System.Type.GetType("System.String"), True)
        AddColumn(data, "Customer Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Code", System.Type.GetType("System.String"), True)
        AddColumn(data, "Updated by", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Public Sub QuotationGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuotationGrid.Click

        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)
                Dim Status As Integer = dr("StatusCode")
                ' 9.11.2003 YG
                Dim tmpQuotation_NO As String = dr(2)

                Select Case (Status)
                    Case "30"
                        With New BusinessRules.SaleBusRules.SaleBusLogic
                            If .IsOrderConfirmationCreated(tmpQuotation_NO) Then
                                CreateOCBtn.Enabled = False
                                RevisedBtn.Enabled = False
                            Else
                                CreateOCBtn.Enabled = True
                                RevisedBtn.Enabled = True
                            End If
                        End With
                        EditBtn.Text = "View"
                        DelBtn.Enabled = False
                    Case "10", "20", "50", "60"
                        CreateOCBtn.Enabled = False
                        RevisedBtn.Enabled = False
                        DelBtn.Enabled = True
                        EditBtn.Text = "Edit"
                    Case "40"
                        CreateOCBtn.Enabled = False
                        RevisedBtn.Enabled = False
                        DelBtn.Enabled = True
                        EditBtn.Text = "View"
                    Case "70" 'Merged
                        CreateOCBtn.Enabled = False
                        RevisedBtn.Enabled = False
                        DelBtn.Enabled = True
                        EditBtn.Text = "View"
                End Select
            End If
        End If
    End Sub
#End Region

#Region " Buttons Event "
    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenu.Click, EditBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)
            Dim Status As String = dr(4)
            ' 29.10.2003 YG Start
            Dim OrderType As String = dr(5)
            ' 29.10.2003 YG End

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            If Status = "30" Or Status = "40" Then     '30 - Pending , 40 - Confirmed. View only
                ' 29.10.2003 YG Start
                'controlToAdd = New QuotationForm("VIEW", , Quotation_ID)
                controlToAdd = New QuotationForm("VIEW", Quotation_ID, OrderType)
                ' 29.10.2003 YG End
                page = New Crownwood.Magic.Controls.TabPage("View Quotation", controlToAdd, ImageList1, 0)
            Else
                ' 29.10.2003 YG Start
                '                controlToAdd = New QuotationForm("EDIT", , Quotation_ID)
                controlToAdd = New QuotationForm("EDIT", Quotation_ID, OrderType)
                ' 29.10.2003 YG End
                page = New Crownwood.Magic.Controls.TabPage("Edit Quotation", controlToAdd, ImageList1, 0)
            End If
            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteMenu.Click, DelBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this quotation?", "Quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    .Quotation_ID = Quotation_ID
                    .UserID = UserID
                    If .DeleteOneQuotation() Then
                        MessageBox.Show("Quotation Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            Me.LoadQuotationList()
        End If
    End Sub

    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        'If RefreshBtn.Checked = True Then
        'Timer1.Interval = 60000
        'Timer1.Start()
        'Else
        '    Timer1.Stop()
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadQuotationList()
        QuotationGrid_Click(sender, e)
    End Sub

    Private Sub RevisedBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click, RevisedBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)
            '29.10.2003 YG Start
            Dim OrderType As String = dr(5)
            '29.10.2003 YG End
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to create a revised quotation?", "Quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                '29.10.2003 YG Start
                '                controlToAdd = New QuotationForm("REVISED", Quotation_ID)
                'controlToAdd = New QuotationForm("REVISED", Quotation_ID, , OrderType)
                '29.10.2003 YG End
                page = New Crownwood.Magic.Controls.TabPage("Revised Quotation", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub CreateOCBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click, CreateOCBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr("QID")
            '1.11.2003 YG Start
            Dim OrderType As String = dr(5)
            '1.11.2003 YG End
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to create a Order Confirmation?", "Quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New OrderConfirmationForm("FROMQUO", , Quotation_ID, , OrderType)
                page = New Crownwood.Magic.Controls.TabPage("Order Confirmation", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New QuotationReportForm(Quotation_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Quotation", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub PrintBtn1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn1.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New QuotationReportBriefForm(Quotation_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Quotation", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PrintBtn2_Click_2()
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New QuotationComponentDetailsReport(Quotation_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Quotation Component Details", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
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
        CreateOCBtn.Enabled = State
        RevisedBtn.Enabled = State
        PrintBtn.Enabled = State
        EditBtn.Enabled = State
        DelBtn.Enabled = State
    End Sub

    Private Sub QuotationListForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadQuotationList()
        End If
    End Sub
#End Region

    Private Sub QuotationGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QuotationGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadQuotationList()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadQuotationList()
        QuotationGrid_Click(sender, e)
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        QuotationGrid_Click(sender, e)
    End Sub

    Private Sub PrintQuotationDlg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click, PrintQuotationDlg.Click

        If CheckIncomplete() = False Then
            Dim PrintQuotationDlg As PrintQuotationDialog = New PrintQuotationDialog
            PrintQuotationDlg.ShowDialog()
            If PrintQuotationDlg.PrintQuotationSelection = 1 Then
                PrintBtn_Click(sender, e)
            ElseIf PrintQuotationDlg.PrintQuotationSelection = 2 Then
                PrintBtn1_Click_1(sender, e)
            ElseIf PrintQuotationDlg.PrintQuotationSelection = 3 Then
                PrintBtn2_Click_2()
            End If
        Else
            MessageBox.Show("Quotation is incomplete for printing.", "Incomplete quotation", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Function CheckIncomplete() As Boolean
        CheckIncomplete = False
        Dim dr As DataRow
        Dim Row As Integer = GridView1.GetSelectedRows(0)
        dr = GridView1.GetDataRow(Row)
        Dim Quotation_ID As Integer = dr(0)
        With New BusinessRules.SaleBusRules.SaleBusLogic
            Dim dsHeaderLoad As DataSet
            If .GetQuotationHeader(dsHeaderLoad, Quotation_ID) Then
                If dsHeaderLoad.Tables(0).Rows(0)("Status") = "80" Then
                    CheckIncomplete = True
                End If
            End If
        End With
    End Function

    Private Sub QuotationListForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                'Timer1.Stop()
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub QuotationGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotationGrid.DoubleClick
        If GridView1.RowCount > 0 Then
            EditBtn_Click(sender, e)
        End If
    End Sub

    Private Sub QuotationGrid_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles QuotationGrid.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        Dim eventString As String = Nothing
        Select Case e.Button
            Case MouseButtons.Left
                eventString = "L"
            Case MouseButtons.Right
                eventString = "R"
                ComponentContextMenu.Show(sender, mouseDownLocation)
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub


End Class
