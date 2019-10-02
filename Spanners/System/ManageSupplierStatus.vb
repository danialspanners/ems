Public Class ManageSupplierStatusForm
    Inherits System.Windows.Forms.Form

#Region "SupplierApprovalHistory's variable"
    Public SupplierApprovalHistory_ID As Integer
    Public Supplier_ID As Integer
    Public VendorEvent As String
    Public WO_ID As Integer
    Public Requester_ID As Integer
    Public Request_Date As String
    Public Status As String
    Public Approver_ID As Integer
    Public Approve_Date As String
    Public Create_Date As String
    Public Transact_Date As String
#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public msgStatusApproved = "Approved as AV"
    Public msgStatusRejected = "Rejected as AV"
    Public SupplierHistoryDS As DataSet
    Dim FunctionName As String = "SupplierApprovalHistory"

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pSupplier_ID As Integer)
        MyBase.New()

        If Not pSupplier_ID = 0 Then
            Supplier_ID = pSupplier_ID
        End If

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusLbl As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SupplierTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierLbl As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridEvent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryEventComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryRequestDateTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridRequester As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryRequesterTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryStatusChkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridApproveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryApproveDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridApprover As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryApproverTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents StatusTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridSupplierApprovalHistory_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierHistoryGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.StatusTxt = New DevExpress.XtraEditors.TextEdit
        Me.SupplierTxt = New DevExpress.XtraEditors.TextEdit
        Me.StatusLbl = New System.Windows.Forms.Label
        Me.SupplierLbl = New System.Windows.Forms.Label
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryEventComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryRequestDateTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryRequesterTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryStatusChkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryApproveDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryApproverTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SupplierHistoryGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridSupplierApprovalHistory_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridEvent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridRequestDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridRequester = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridApproveDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridApprover = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PrintBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.StatusTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryEventComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryRequestDateTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryRequesterTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryStatusChkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryApproveDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryApproverTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierHistoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatusTxt)
        Me.GroupBox1.Controls.Add(Me.SupplierTxt)
        Me.GroupBox1.Controls.Add(Me.StatusLbl)
        Me.GroupBox1.Controls.Add(Me.SupplierLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 72)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'StatusTxt
        '
        Me.StatusTxt.Enabled = False
        Me.StatusTxt.Location = New System.Drawing.Point(104, 40)
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusTxt.Properties.Enabled = False
        Me.StatusTxt.Properties.ReadOnly = True
        Me.StatusTxt.Size = New System.Drawing.Size(200, 19)
        Me.StatusTxt.TabIndex = 34
        '
        'SupplierTxt
        '
        Me.SupplierTxt.Enabled = False
        Me.SupplierTxt.Location = New System.Drawing.Point(104, 16)
        Me.SupplierTxt.Name = "SupplierTxt"
        Me.SupplierTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierTxt.Properties.ReadOnly = True
        Me.SupplierTxt.Size = New System.Drawing.Size(280, 19)
        Me.SupplierTxt.TabIndex = 33
        '
        'StatusLbl
        '
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(8, 48)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(88, 16)
        Me.StatusLbl.TabIndex = 16
        Me.StatusLbl.Text = "Current Status :"
        '
        'SupplierLbl
        '
        Me.SupplierLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierLbl.Location = New System.Drawing.Point(8, 20)
        Me.SupplierLbl.Name = "SupplierLbl"
        Me.SupplierLbl.Size = New System.Drawing.Size(96, 16)
        Me.SupplierLbl.TabIndex = 11
        Me.SupplierLbl.Text = "Supplier :"
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryEventComboBox, Me.RepositoryRequestDateTextEdit, Me.RepositoryRequesterTextEdit, Me.RepositoryStatusChkEdit, Me.RepositoryApproveDateEdit, Me.RepositoryApproverTextEdit, Me.RepositoryItemTextEdit1})
        '
        'RepositoryEventComboBox
        '
        Me.RepositoryEventComboBox.Name = "RepositoryEventComboBox"
        Me.RepositoryEventComboBox.Properties.AllowFocused = False
        Me.RepositoryEventComboBox.Properties.AutoHeight = False
        Me.RepositoryEventComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryEventComboBox.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryEventComboBox.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryEventComboBox.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ComboBoxItem("Request as approved vendor"))
        Me.RepositoryEventComboBox.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ComboBoxItem("Request to remove from AVL"))
        Me.RepositoryEventComboBox.Properties.UseCtrlScroll = True
        '
        'RepositoryRequestDateTextEdit
        '
        Me.RepositoryRequestDateTextEdit.Name = "RepositoryRequestDateTextEdit"
        Me.RepositoryRequestDateTextEdit.Properties.AllowFocused = False
        Me.RepositoryRequestDateTextEdit.Properties.AutoHeight = False
        Me.RepositoryRequestDateTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryRequestDateTextEdit.Properties.ReadOnly = True
        '
        'RepositoryRequesterTextEdit
        '
        Me.RepositoryRequesterTextEdit.Name = "RepositoryRequesterTextEdit"
        Me.RepositoryRequesterTextEdit.Properties.AllowFocused = False
        Me.RepositoryRequesterTextEdit.Properties.AutoHeight = False
        Me.RepositoryRequesterTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryRequesterTextEdit.Properties.ReadOnly = True
        '
        'RepositoryStatusChkEdit
        '
        Me.RepositoryStatusChkEdit.Name = "RepositoryStatusChkEdit"
        Me.RepositoryStatusChkEdit.Properties.AllowFocused = False
        Me.RepositoryStatusChkEdit.Properties.AutoHeight = False
        Me.RepositoryStatusChkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryStatusChkEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.RepositoryStatusChkEdit.Properties.ValueChecked = "1"
        '
        'RepositoryApproveDateEdit
        '
        Me.RepositoryApproveDateEdit.Name = "RepositoryApproveDateEdit"
        Me.RepositoryApproveDateEdit.Properties.AllowFocused = False
        Me.RepositoryApproveDateEdit.Properties.AutoHeight = False
        Me.RepositoryApproveDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryApproveDateEdit.Properties.ReadOnly = True
        '
        'RepositoryApproverTextEdit
        '
        Me.RepositoryApproverTextEdit.Name = "RepositoryApproverTextEdit"
        Me.RepositoryApproverTextEdit.Properties.AllowFocused = False
        Me.RepositoryApproverTextEdit.Properties.AutoHeight = False
        Me.RepositoryApproverTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryApproverTextEdit.Properties.ReadOnly = True
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(592, 232)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 88
        Me.CloseBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(520, 232)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 87
        Me.SaveBtn.Text = "Save"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(440, 232)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 134
        Me.btnRefresh.Text = "Refresh"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'SupplierHistoryGrid
        '
        Me.SupplierHistoryGrid.EditorsRepository = Me.PersistentRepository1
        Me.SupplierHistoryGrid.Location = New System.Drawing.Point(16, 88)
        Me.SupplierHistoryGrid.MainView = Me.GridView1
        Me.SupplierHistoryGrid.Name = "SupplierHistoryGrid"
        Me.SupplierHistoryGrid.Size = New System.Drawing.Size(640, 136)
        Me.SupplierHistoryGrid.TabIndex = 135
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType(((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.BorderStyle = DevExpress.XtraGrid.Views.Grid.ViewBorderStyle.Flat
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridSupplierApprovalHistory_ID, Me.GridEvent, Me.GridRequestDate, Me.GridRequester, Me.GridStatus, Me.GridApproveDate, Me.GridApprover})
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GridSupplierApprovalHistory_ID
        '
        Me.GridSupplierApprovalHistory_ID.Caption = "SupplierApprovalHistory_ID"
        Me.GridSupplierApprovalHistory_ID.FieldName = "SupplierApprovalHistory_ID"
        Me.GridSupplierApprovalHistory_ID.Name = "GridSupplierApprovalHistory_ID"
        '
        'GridEvent
        '
        Me.GridEvent.Caption = "Event"
        Me.GridEvent.ColumnEdit = Me.RepositoryEventComboBox
        Me.GridEvent.FieldName = "VendorEvent"
        Me.GridEvent.Name = "GridEvent"
        Me.GridEvent.VisibleIndex = 0
        Me.GridEvent.Width = 170
        '
        'GridRequestDate
        '
        Me.GridRequestDate.Caption = "Request Date"
        Me.GridRequestDate.ColumnEdit = Me.RepositoryRequestDateTextEdit
        Me.GridRequestDate.FieldName = "Request_Date"
        Me.GridRequestDate.Name = "GridRequestDate"
        Me.GridRequestDate.VisibleIndex = 1
        Me.GridRequestDate.Width = 80
        '
        'GridRequester
        '
        Me.GridRequester.Caption = "Requester"
        Me.GridRequester.ColumnEdit = Me.RepositoryRequesterTextEdit
        Me.GridRequester.FieldName = "Requester"
        Me.GridRequester.Name = "GridRequester"
        Me.GridRequester.VisibleIndex = 2
        Me.GridRequester.Width = 70
        '
        'GridStatus
        '
        Me.GridStatus.Caption = "Approved?"
        Me.GridStatus.ColumnEdit = Me.RepositoryStatusChkEdit
        Me.GridStatus.FieldName = "Status"
        Me.GridStatus.Name = "GridStatus"
        Me.GridStatus.VisibleIndex = 3
        Me.GridStatus.Width = 65
        '
        'GridApproveDate
        '
        Me.GridApproveDate.Caption = "Approval/Reject Date"
        Me.GridApproveDate.ColumnEdit = Me.RepositoryApproveDateEdit
        Me.GridApproveDate.FieldName = "Approve_Date"
        Me.GridApproveDate.Name = "GridApproveDate"
        Me.GridApproveDate.VisibleIndex = 4
        Me.GridApproveDate.Width = 115
        '
        'GridApprover
        '
        Me.GridApprover.Caption = "Approved/Rejected By"
        Me.GridApprover.ColumnEdit = Me.RepositoryApproverTextEdit
        Me.GridApprover.FieldName = "Approver"
        Me.GridApprover.Name = "GridApprover"
        Me.GridApprover.VisibleIndex = 5
        Me.GridApprover.Width = 120
        '
        'PrintBtn
        '
        Me.PrintBtn.AutoSize = False
        Me.PrintBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Image = Nothing
        Me.PrintBtn.Location = New System.Drawing.Point(304, 232)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(128, 32)
        Me.PrintBtn.TabIndex = 136
        Me.PrintBtn.Text = "Print Evaluation Form"
        '
        'ManageSupplierStatusForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 269)
        Me.Controls.Add(Me.SupplierHistoryGrid)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PrintBtn)
        Me.Name = "ManageSupplierStatusForm"
        Me.Text = "Delivery Note"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.StatusTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryEventComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryRequestDateTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryRequesterTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryStatusChkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryApproveDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryApproverTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierHistoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Form load"
    Private Sub ManageSupplierStatusForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        LoadSupplier(Supplier_ID)
        LoadSupplierHistoryGrid(Supplier_ID) 'Load data into Grid

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadSupplierHistoryGrid(ByVal pSupplier_ID As String)
        With New BusinessRules.SupplierBusRules.SupplierHistoryBusLogic
            If .GetSupplierApprovalHistory(SupplierHistoryDS, Supplier_ID) Then
                SupplierHistoryGrid.DataSource = SupplierHistoryDS.Tables(0).DefaultView
            End If
        End With

    End Sub

    Private Sub LoadSupplier(ByVal pSupplier_ID)
        Dim dsSupplier As DataSet

        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .GetSupplierHeader(dsSupplier, pSupplier_ID) Then
                If Not dsSupplier Is Nothing Then
                    SetWindowValue(dsSupplier)
                End If
            End If
        End With
    End Sub

#End Region

#Region "Button Events"

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New SupplierEvaluationReportForm(Supplier_ID)
        page = New Crownwood.Magic.Controls.TabPage("Print Supplier Evaluation Form", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadSupplier(Supplier_ID)
        LoadSupplierHistoryGrid(Supplier_ID) 'Load data into Grid
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveSupplerApprovalHistoryProcess()
        LoadSupplier(Supplier_ID)
        LoadSupplierHistoryGrid(Supplier_ID) 'Load data into Grid
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()

    End Sub

    Private Sub SaveSupplerApprovalHistoryProcess()
        Dim i As Integer
        Dim LastRecord As DataSet

        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()
        With New BusinessRules.SupplierBusRules.SupplierHistoryBusLogic
            i = SupplierHistoryDS.Tables(0).Rows.Count - 1
            'MsgBox(DrawingNoDS.Tables(0).Rows(i)("WOLineDrawID").ToString())
            If Not IsDBNull(SupplierHistoryDS.Tables(0).Rows(i)("SupplierApprovalHistory_ID")) Then
                If .GetLastSupplierApprovalRecord(LastRecord, SupplierHistoryDS.Tables(0).Rows(i)("SupplierApprovalHistory_ID")) Then
                    If Not LastRecord.Tables(0).Rows(0)("Status") = SupplierHistoryDS.Tables(0).Rows(i)("Status") Then
                        ' update records
                        .VendorEvent = SupplierHistoryDS.Tables(0).Rows(i)("Status")
                        .Approver_ID = UserID
                        .Status = SupplierHistoryDS.Tables(0).Rows(i)("Status")
                        .UserID = UserID
                        If .UpdateSupplierApprovalRecord(SupplierHistoryDS.Tables(0).Rows(i)("SupplierApprovalHistory_ID")) Then
                            MessageBox.Show("Supplier Approval Record updated!", "Manage Supplier Approval History", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        ' update approval flag in supplier table
                        If SupplierHistoryDS.Tables(0).Rows(i)("VendorEvent") = "Request as approved vendor" Then
                            ' Request as approved vendor
                            If Not LastRecord.Tables(0).Rows(0)("Status") = "1" And SupplierHistoryDS.Tables(0).Rows(i)("Status") = "1" Then
                                With New BusinessRules.SupplierBusRules.SupplierBusLogic
                                    .Approved = "1"
                                    .UserID = UserID
                                    .UpdateSupplierApprovalStatus(Supplier_ID)
                                End With
                            End If
                        Else
                            ' Request to remove from AVL
                            If Not LastRecord.Tables(0).Rows(0)("Status") = "1" And SupplierHistoryDS.Tables(0).Rows(i)("Status") = "1" Then
                                With New BusinessRules.SupplierBusRules.SupplierBusLogic
                                    .Approved = "0"
                                    .UserID = UserID
                                    .UpdateSupplierApprovalStatus(Supplier_ID)
                                End With
                            End If
                        End If
                    End If
                End If
            Else
                ' insert record
                .Supplier_ID = Supplier_ID
                .Requester_ID = UserID
                .UserID = UserID
                If Not IsDBNull(SupplierHistoryDS.Tables(0).Rows(i)("VendorEvent")) Then
                    .VendorEvent = SupplierHistoryDS.Tables(0).Rows(i)("VendorEvent")
                End If
                If .SaveSupplierApprovalRecord() Then
                    MessageBox.Show("Supplier Approval Record saved!", "Manage Supplier Approval History", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SupplierApprovalHistory_ID = .SupplierApprovalHistory_ID
                    ' update records
                    .VendorEvent = SupplierHistoryDS.Tables(0).Rows(i)("VendorEvent")
                    If Not IsDBNull(SupplierHistoryDS.Tables(0).Rows(i)("Status")) Then
                        .Status = SupplierHistoryDS.Tables(0).Rows(i)("Status")
                        .Approver_ID = UserID
                    Else
                        .Status = 0
                        .Approver_ID = 0
                    End If
                    .UserID = UserID
                    .UpdateSupplierApprovalRecord(SupplierApprovalHistory_ID)
                    ' update approval flag in supplier table
                    If SupplierHistoryDS.Tables(0).Rows(i)("VendorEvent") = "Request as approved vendor" Then
                        ' Request as approved vendor
                        If Not IsDBNull(SupplierHistoryDS.Tables(0).Rows(i)("Status")) Then
                            If SupplierHistoryDS.Tables(0).Rows(i)("Status") = "1" Then
                                With New BusinessRules.SupplierBusRules.SupplierBusLogic
                                    .Approved = "1"
                                    .UserID = UserID
                                    .UpdateSupplierApprovalStatus(Supplier_ID)
                                End With
                            End If
                        End If
                    Else
                        ' Request to remove from AVL
                        If Not IsDBNull(SupplierHistoryDS.Tables(0).Rows(i)("Status")) Then
                            If SupplierHistoryDS.Tables(0).Rows(i)("Status") = "1" Then
                                With New BusinessRules.SupplierBusRules.SupplierBusLogic
                                    .Approved = "0"
                                    .UserID = UserID
                                    .UpdateSupplierApprovalStatus(Supplier_ID)
                                End With
                            End If
                        End If
                    End If
                End If
            End If
        End With
    End Sub

#End Region

#Region "Get/Set Window Value"

    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        SupplierTxt.Text = dsLoad.Tables(0).Rows(0)("Supplier_Name")
        If dsLoad.Tables(0).Rows(0)("Approved") = "1" Then
            StatusTxt.Text = msgStatusApproved
        Else
            StatusTxt.Text = msgStatusRejected
        End If

    End Sub

#End Region

    Private Sub ManageSupplierStatusForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Supplier Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Dim a As MainForm = Me.ParentForm
            If (a.MainTabControl.TabPages.Count > 0) Then
                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub
End Class
