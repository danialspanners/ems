Public Class OrderConfirmListForm
    Inherits System.Windows.Forms.Form

    Public UserID As String = Common.CommonConn.Config.USERID
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VOBtn As System.Windows.Forms.Button
    Friend WithEvents PrintOCBtn As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents DelBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents RevisedBtn As System.Windows.Forms.Button
    Friend WithEvents CreateOCBtn As System.Windows.Forms.Button
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
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OCGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PrintBtn1 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderConfirmListForm))
        Me.OCGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintBtn1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.PrintOCBtn = New System.Windows.Forms.Button
        Me.VOBtn = New System.Windows.Forms.Button
        Me.CreateOCBtn = New System.Windows.Forms.Button
        Me.RevisedBtn = New System.Windows.Forms.Button
        Me.EditBtn = New System.Windows.Forms.Button
        Me.DelBtn = New System.Windows.Forms.Button
        Me.CloseBtn = New System.Windows.Forms.Button
        CType(Me.OCGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OCGrid
        '
        Me.OCGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OCGrid.EditorsRepository = Me.PersistentRepository1
        Me.OCGrid.Location = New System.Drawing.Point(0, 0)
        Me.OCGrid.MainView = Me.GridView1
        Me.OCGrid.Name = "OCGrid"
        Me.OCGrid.Size = New System.Drawing.Size(849, 651)
        Me.OCGrid.TabIndex = 1
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
        Me.RefreshBtn.Location = New System.Drawing.Point(12, 17)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(104, 16)
        Me.RefreshBtn.TabIndex = 8
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
        'PrintBtn1
        '
        Me.PrintBtn1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn1.Image = Nothing
        Me.PrintBtn1.Location = New System.Drawing.Point(218, 0)
        Me.PrintBtn1.Name = "PrintBtn1"
        Me.PrintBtn1.Size = New System.Drawing.Size(104, 16)
        Me.PrintBtn1.TabIndex = 15
        Me.PrintBtn1.Text = "Print Quotation (B)"
        Me.PrintBtn1.Visible = False
        '
        'PrintBtn
        '
        Me.PrintBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Image = Nothing
        Me.PrintBtn.Location = New System.Drawing.Point(328, 0)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(88, 16)
        Me.PrintBtn.TabIndex = 16
        Me.PrintBtn.Text = "Print Quotation"
        Me.PrintBtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.DelBtn)
        Me.Panel1.Controls.Add(Me.EditBtn)
        Me.Panel1.Controls.Add(Me.RevisedBtn)
        Me.Panel1.Controls.Add(Me.CreateOCBtn)
        Me.Panel1.Controls.Add(Me.VOBtn)
        Me.Panel1.Controls.Add(Me.PrintOCBtn)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.PrintBtn)
        Me.Panel1.Controls.Add(Me.PrintBtn1)
        Me.Panel1.Controls.Add(Me.RefreshBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 651)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 65)
        Me.Panel1.TabIndex = 18
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(38, 17)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(56, 34)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PrintOCBtn
        '
        Me.PrintOCBtn.Location = New System.Drawing.Point(102, 17)
        Me.PrintOCBtn.Name = "PrintOCBtn"
        Me.PrintOCBtn.Size = New System.Drawing.Size(56, 34)
        Me.PrintOCBtn.TabIndex = 19
        Me.PrintOCBtn.Text = "Print OC"
        Me.PrintOCBtn.UseVisualStyleBackColor = True
        '
        'VOBtn
        '
        Me.VOBtn.Location = New System.Drawing.Point(166, 17)
        Me.VOBtn.Name = "VOBtn"
        Me.VOBtn.Size = New System.Drawing.Size(114, 34)
        Me.VOBtn.TabIndex = 20
        Me.VOBtn.Text = "Create OC Variation"
        Me.VOBtn.UseVisualStyleBackColor = True
        '
        'CreateOCBtn
        '
        Me.CreateOCBtn.Location = New System.Drawing.Point(286, 17)
        Me.CreateOCBtn.Name = "CreateOCBtn"
        Me.CreateOCBtn.Size = New System.Drawing.Size(112, 34)
        Me.CreateOCBtn.TabIndex = 21
        Me.CreateOCBtn.Text = "Create Work Order"
        Me.CreateOCBtn.UseVisualStyleBackColor = True
        '
        'RevisedBtn
        '
        Me.RevisedBtn.Location = New System.Drawing.Point(406, 17)
        Me.RevisedBtn.Name = "RevisedBtn"
        Me.RevisedBtn.Size = New System.Drawing.Size(192, 34)
        Me.RevisedBtn.TabIndex = 22
        Me.RevisedBtn.Text = "Create Revised Order Confirmation"
        Me.RevisedBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(606, 17)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(56, 34)
        Me.EditBtn.TabIndex = 23
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(670, 17)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(56, 34)
        Me.DelBtn.TabIndex = 24
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(734, 17)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(56, 34)
        Me.CloseBtn.TabIndex = 25
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'OrderConfirmListForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(849, 716)
        Me.Controls.Add(Me.OCGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "OrderConfirmListForm"
        Me.Text = "Order Confirmation Listing"
        CType(Me.OCGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form load "
    Private Sub OrderConfirmListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfirmationList()
        'Timer1.Interval = 60000
        'Timer1.Start()
        OCGrid_Click(sender, e)
    End Sub

    Private Sub LoadConfirmationList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetOrderConfirmHeader(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentConfirmQuotationNo As String
                Dim ProjectTitle As String
                Dim QNo, QConfirmNo, Project As String

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
                        Project = ""
                        If Not IsDBNull(oRow("Project")) Then
                            Project = oRow("Project")
                        End If
                        With New BusinessRules.SystemBusRules.ProjectBusLogic
                            If .GetProject(dsProject, Project) Then
                                If Not dsProject Is Nothing Then
                                    If Not IsDBNull(oRow("ProjectSub")) Then
                                        ProjectTitle = Trim(oRow("ProjectSub")) & " " & dsProject.Tables(0).Rows(0)("Project_Name")
                                    Else
                                        ProjectTitle = dsProject.Tables(0).Rows(0)("Project_Name")
                                    End If
                                End If
                            End If
                        End With
                        QNo = "NA"
                        QConfirmNo = "NA"
                        If Not IsDBNull(oRow("Quotation_NO")) Then
                            QNo = oRow("Quotation_NO")
                        End If
                        If Not IsDBNull(oRow("Confirm_Quotation_No")) Then
                            QConfirmNo = oRow("Confirm_Quotation_No")
                        End If
                        data.Rows.Add(New Object() {oRow("Quotation_ID"), i, QNo, QConfirmNo, ChangeDateFormat(oRow("QuotationDate")), oRow("Status"), Status, oRow("Order_Type"), ProjectTitle, oRow("CustomerName"), oRow("Initial"), oRow("Login_Id")})
                    Next
                    OCGrid.DataSource = data
                    OCGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    GridView1.Columns.Item(5).VisibleIndex = -1 'hide 6th. Status
                    ' 1.11.2003 YG Start
                    GridView1.Columns.Item(7).VisibleIndex = -1 'hide 7. Order Type
                    ' 1.11.2003 YG End
                    SetButtonsControl(True)
                Else
                    GridView1.Columns.Clear()
                    SetButtonsControl(False)
                End If
            End If
            If Not ds Is Nothing Then
                ds.Dispose()
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "QID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Quotation No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Order Confirmation No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "StatusCode", System.Type.GetType("System.String"), True)
        AddColumn(data, "Status", System.Type.GetType("System.String"), True)
        ' 1.11.2003 YG Start
        AddColumn(data, "Order_Type", System.Type.GetType("System.String"), True)
        ' 1.11.2003 YG End
        AddColumn(data, "Project", System.Type.GetType("System.String"), True)
        AddColumn(data, "Customer Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Code", System.Type.GetType("System.String"), True)
        AddColumn(data, "Updated by", Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub
#End Region

#Region " Buttons Event "
    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)
            Dim Status As String = dr(5)
            Dim OrderType As String = dr(7)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            If Status = "30" Then       'COnfirmed. View only
                controlToAdd = New OrderConfirmationForm("VIEW", , , Quotation_ID, OrderType)
                page = New Crownwood.Magic.Controls.TabPage("View Order Confirmation", controlToAdd, ImageList1, 0)
            Else
                controlToAdd = New OrderConfirmationForm("EDIT", , , Quotation_ID, OrderType)
                page = New Crownwood.Magic.Controls.TabPage("Edit Order Confirmation", controlToAdd, ImageList1, 0)
            End If
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
            Dim Quotation_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this Order Confirmation?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    .Quotation_ID = Quotation_ID
                    .UserID = UserID
                    If .DeleteOneQuotation() Then
                        MessageBox.Show("Order Confirmation Deleted.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            Me.LoadConfirmationList()
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
        LoadConfirmationList()
        OCGrid_Click(sender, e)
    End Sub

    Private Sub RevisedBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevisedBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)
            Dim OrderType As String = dr(7)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to create a revised order confirmation?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New OrderConfirmationForm("REVISED", , Quotation_ID, , OrderType)
                page = New Crownwood.Magic.Controls.TabPage("Revised Order Confirmation", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub CreateOCBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateOCBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to create a Work Order?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New WorkOrderForm("FROMOC", , Quotation_ID)
                page = New Crownwood.Magic.Controls.TabPage("Work Order", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
#End Region

    Private Sub OCGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCGrid.Click
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)
                Dim Status As Integer = dr(5)
                Dim tmpConfirm_Quotation_NO As String = dr(3)

                Select Case (Status)
                    Case "30"
                        '09.11.2003 YG Start
                        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                            If .IsWorkOrderCreated(tmpConfirm_Quotation_NO) Then
                                CreateOCBtn.Enabled = False
                                RevisedBtn.Enabled = False
                            Else
                                CreateOCBtn.Enabled = True
                                RevisedBtn.Enabled = True
                            End If
                        End With
                        VOBtn.Enabled = True
                        EditBtn.Text = "View"
                        CloseBtn.Enabled = False
                    Case "10", "20", "40", "50", "60"
                        VOBtn.Enabled = False
                        CreateOCBtn.Enabled = False
                        RevisedBtn.Enabled = False
                        CloseBtn.Enabled = True
                        EditBtn.Text = "Edit"
                End Select
            End If
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

    Private Sub SetButtonsControl(ByVal State As Boolean)
        VOBtn.Enabled = State
        CreateOCBtn.Enabled = State
        RevisedBtn.Enabled = State
        PrintBtn.Enabled = State
        EditBtn.Enabled = State
        CloseBtn.Enabled = State
    End Sub
#End Region

    Private Sub OrderConfirmListForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadConfirmationList()
        End If
    End Sub

    Private Sub OCGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OCGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadConfirmationList()
        End If
    End Sub

    Private Sub VOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim OrderType As String = dr(7)
            Dim Quotation_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to create a VO?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New OrderConfirmationForm("OCVO", , Quotation_ID, , OrderType)
                page = New Crownwood.Magic.Controls.TabPage("Variation", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New OrderConfirmationReportForm(Quotation_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Order Confirmation", controlToAdd, ImageList1, 0)

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
            controlToAdd = New OrderConfirmationReportBriefForm(Quotation_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Order Confirmation", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadConfirmationList()
        OCGrid_Click(sender, e)
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        OCGrid_Click(sender, e)
    End Sub

    Private Sub PrintOCBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOCBtn.Click
        Dim PrintOCDlg As PrintOrderConfirmationDialog = New PrintOrderConfirmationDialog
        PrintOCDlg.ShowDialog()
        If PrintOCDlg.PrintOrderConfirmationSelection = 1 Then
            PrintBtn_Click(sender, e)
        ElseIf PrintOCDlg.PrintOrderConfirmationSelection = 2 Then
            PrintBtn1_Click_1(sender, e)
        End If
    End Sub

    Private Sub OrderConfirmListForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub OCGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCGrid.DoubleClick
        If GridView1.RowCount > 0 Then
            EditBtn_Click(sender, e)
        End If
    End Sub
End Class
