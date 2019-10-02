Public Class QAListingForm
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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents EditBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents WOGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UpdateBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents QABoxGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents InspectedCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BoxTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents QtyTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ComplDateDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarksItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RemarksItemMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents InspectedTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BalQtyTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(QAListingForm))
        Me.WOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.InspectedCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.BoxTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.QtyTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ComplDateDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RemarksItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RemarksItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.InspectedTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.BalQtyTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.EditBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.QABoxGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UpdateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InspectedCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplDateDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksItemMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InspectedTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalQtyTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QABoxGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WOGrid
        '
        Me.WOGrid.EditorsRepository = Me.PersistentRepository2
        Me.WOGrid.Location = New System.Drawing.Point(8, 8)
        Me.WOGrid.MainView = Me.GridView1
        Me.WOGrid.Name = "WOGrid"
        Me.WOGrid.Size = New System.Drawing.Size(664, 192)
        Me.WOGrid.TabIndex = 3
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.InspectedCheckEdit, Me.BoxTextEdit, Me.QtyTextEdit, Me.ComplDateDateEdit, Me.RemarksItemTextEdit, Me.RemarksItemMemoExEdit, Me.InspectedTextEdit, Me.BalQtyTextEdit})
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
        'InspectedCheckEdit
        '
        Me.InspectedCheckEdit.Name = "InspectedCheckEdit"
        Me.InspectedCheckEdit.Properties.AllowFocused = False
        Me.InspectedCheckEdit.Properties.AutoHeight = False
        Me.InspectedCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.InspectedCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.InspectedCheckEdit.Properties.ValueChecked = "1"
        Me.InspectedCheckEdit.Properties.ValueUnchecked = "0"
        '
        'BoxTextEdit
        '
        Me.BoxTextEdit.Name = "BoxTextEdit"
        Me.BoxTextEdit.Properties.AllowFocused = False
        Me.BoxTextEdit.Properties.AutoHeight = False
        Me.BoxTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BoxTextEdit.Properties.Enabled = False
        '
        'QtyTextEdit
        '
        Me.QtyTextEdit.Name = "QtyTextEdit"
        Me.QtyTextEdit.Properties.AllowFocused = False
        Me.QtyTextEdit.Properties.AutoHeight = False
        Me.QtyTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.QtyTextEdit.Properties.Enabled = False
        '
        'ComplDateDateEdit
        '
        Me.ComplDateDateEdit.Name = "ComplDateDateEdit"
        Me.ComplDateDateEdit.Properties.AllowFocused = False
        Me.ComplDateDateEdit.Properties.AutoHeight = False
        Me.ComplDateDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ComplDateDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ComplDateDateEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ComplDateDateEdit.Properties.Enabled = False
        '
        'RemarksItemTextEdit
        '
        Me.RemarksItemTextEdit.Name = "RemarksItemTextEdit"
        Me.RemarksItemTextEdit.Properties.AllowFocused = False
        Me.RemarksItemTextEdit.Properties.AutoHeight = False
        Me.RemarksItemTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RemarksItemMemoExEdit
        '
        Me.RemarksItemMemoExEdit.Name = "RemarksItemMemoExEdit"
        Me.RemarksItemMemoExEdit.Properties.AllowFocused = False
        Me.RemarksItemMemoExEdit.Properties.AutoHeight = False
        Me.RemarksItemMemoExEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RemarksItemMemoExEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RemarksItemMemoExEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        '
        'InspectedTextEdit
        '
        Me.InspectedTextEdit.Name = "InspectedTextEdit"
        Me.InspectedTextEdit.Properties.AllowFocused = False
        Me.InspectedTextEdit.Properties.AutoHeight = False
        Me.InspectedTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.InspectedTextEdit.Properties.Format = CType(resources.GetObject("InspectedTextEdit.Properties.Format"), System.IFormatProvider)
        '
        'BalQtyTextEdit
        '
        Me.BalQtyTextEdit.Name = "BalQtyTextEdit"
        Me.BalQtyTextEdit.Properties.AllowFocused = False
        Me.BalQtyTextEdit.Properties.AutoHeight = False
        Me.BalQtyTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BalQtyTextEdit.Properties.Enabled = False
        Me.BalQtyTextEdit.Properties.Format = CType(resources.GetObject("BalQtyTextEdit.Properties.Format"), System.IFormatProvider)
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType(((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowRowSizing), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'EditBtn
        '
        Me.EditBtn.AutoSize = False
        Me.EditBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Image = Nothing
        Me.EditBtn.Location = New System.Drawing.Point(352, 392)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(80, 32)
        Me.EditBtn.TabIndex = 15
        Me.EditBtn.Text = "View"
        Me.EditBtn.Visible = False
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
        Me.CloseBtn.Location = New System.Drawing.Point(600, 392)
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
        Me.btnRefresh.Location = New System.Drawing.Point(440, 392)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "Refresh"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QABoxGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 176)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work Order Inspection Details"
        '
        'QABoxGrid
        '
        Me.QABoxGrid.EditorsRepository = Me.PersistentRepository2
        Me.QABoxGrid.Location = New System.Drawing.Point(8, 16)
        Me.QABoxGrid.MainView = Me.GridView2
        Me.QABoxGrid.Name = "QABoxGrid"
        Me.QABoxGrid.Size = New System.Drawing.Size(648, 152)
        Me.QABoxGrid.TabIndex = 131
        Me.QABoxGrid.Text = "GridControl1"
        '
        'GridView2
        '
        Me.GridView2.BehaviorOptions = CType(((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn3, Me.GridColumn2, Me.GridColumn6, Me.GridColumn5, Me.GridColumn1, Me.GridColumn7})
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        Me.GridView2.ViewOptions = CType((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Box"
        Me.GridColumn4.ColumnEdit = Me.BoxTextEdit
        Me.GridColumn4.FieldName = "Box"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 167
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.ColumnEdit = Me.QtyTextEdit
        Me.GridColumn3.FieldName = "Qty"
        Me.GridColumn3.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 45
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Bal Qty"
        Me.GridColumn2.ColumnEdit = Me.BalQtyTextEdit
        Me.GridColumn2.FieldName = "BalQty"
        Me.GridColumn2.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 64
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Compl'n Date"
        Me.GridColumn6.ColumnEdit = Me.ComplDateDateEdit
        Me.GridColumn6.FieldName = "Compl_Date"
        Me.GridColumn6.FormatString = "d"
        Me.GridColumn6.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.DateTime
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 101
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Inspected"
        Me.GridColumn5.ColumnEdit = Me.InspectedTextEdit
        Me.GridColumn5.FieldName = "Inspected"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 76
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Remarks"
        Me.GridColumn1.ColumnEdit = Me.RemarksItemMemoExEdit
        Me.GridColumn1.FieldName = "Remarks"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 117
        '
        'UpdateBtn
        '
        Me.UpdateBtn.AutoSize = False
        Me.UpdateBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Image = Nothing
        Me.UpdateBtn.Location = New System.Drawing.Point(520, 392)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(72, 32)
        Me.UpdateBtn.TabIndex = 56
        Me.UpdateBtn.Text = "Update"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Inspected By"
        Me.GridColumn7.FieldName = "Name"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 100
        '
        'QAListingForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 429)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.WOGrid)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "QAListingForm"
        Me.Text = "Quality Assurance"
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InspectedCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplDateDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksItemMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InspectedTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalQtyTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.QABoxGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    Dim WOQAds As DataSet

#Region " Work Order Line Variable "
    Public WO_Line_ID As Integer
#End Region

    Private Sub QAListingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadWorkOrderList()
    End Sub

#Region " Grid Component"
    Private Sub LoadWorkOrderList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If .GetQAHeader(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentConfirmQuotationNo As String
                Dim ProjectTitle As String

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

                    data.Rows.Add(New Object() {oRow("WO_ID"), i, oRow("WO_No"), ChangeDateFormat(oRow("WO_Date")), oRow("Status"), Status, ProjectTitle, oRow("CustomerName"), oRow("Initial"), oRow("WO_Line_ID")})
                Next
                WOGrid.DataSource = data
                WOGrid.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                GridView1.Columns.Item(4).VisibleIndex = -1 'hide 5th. Status
                GridView1.Columns.Item(9).VisibleIndex = -1 'hide 10th. Status
                If ds.Tables(0).Rows.Count > 0 Then
                    WO_Line_ID = ds.Tables(0).Rows(0)("WO_Line_ID").ToString()
                    LoadQABoxGrid()
                End If
                ds.Dispose()
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
        AddColumn(data, "WOLineID", System.Type.GetType("System.Int16"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Sub LoadQABoxGrid()
        'Dim ds As DataSet

        With New BusinessRules.QABusRules.QABusLogic
            .WO_Line_ID = WO_Line_ID
            If .GetQA(WOQAds) Then
                QABoxGrid.DataSource = WOQAds.Tables(0).DefaultView
            End If
        End With
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
#End Region

#Region " Buttons "
    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)
            Dim Status As String = dr(4)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New QAForm("VIEW", WO_ID)
            page = New Crownwood.Magic.Controls.TabPage("QA", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
#End Region

    Private Sub WOListingForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadWorkOrderList()
        End If
    End Sub

    Private Sub WOGrid_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WOGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadWorkOrderList()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadWorkOrderList()
    End Sub

    Private Sub WOGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WOGrid.Click
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)

                If dr("WOLineID").ToString() <> "" Then
                    WOQAds = Nothing
                    WO_Line_ID = dr("WOLineID")
                    LoadQABoxGrid()
                End If
            End If
        End If
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        GridView2.CloseEditor()
        GridView2.UpdateCurrentRow()
        With New BusinessRules.QABusRules.QABusLogic
            If Not WOQAds Is Nothing Then
                For i As Integer = 0 To WOQAds.Tables(0).Rows.Count - 1
                    .QA_ID = Convert.ToInt32(WOQAds.Tables(0).Rows(i)("QA_ID"))
                    .Inspected = Convert.ToInt32(WOQAds.Tables(0).Rows(i)("Inspected"))
                    .InspectedQty = Convert.ToInt32(WOQAds.Tables(0).Rows(i)("InspectedQty"))
                    If IsDBNull(WOQAds.Tables(0).Rows(i)("BalQty")) Then
                        .BalQty = 0
                    Else
                        .BalQty = Convert.ToInt32(WOQAds.Tables(0).Rows(i)("BalQty"))
                    End If
                    If .Inspected > 0 And .BalQty >= .Inspected Then 'And WOQAds.Tables(0).Rows(i)("BalQty") > 0 Then
                        'Create Rec in QALine InspectedQty = Inspected
                        .QA_Line_ID = WOQAds.Tables(0).Rows(i)("QA_Line_ID")
                        Dim insqty As Long
                        insqty = .InspectedQty
                        Dim insp As Long
                        insp = .Inspected
                        .InspectedQty = insqty + insp
                        .UserID = Common.CommonConn.Config.USERID
                        .UpdateQALine()
                        '.CreateQALine()    
                    End If
                    .Remarks = WOQAds.Tables(0).Rows(i)("Remarks").ToString()
                    .UserID = Common.CommonConn.Config.USERID
                    .WO_Line_ID = Convert.ToInt32(WOQAds.Tables(0).Rows(i)("WO_Line_ID"))
                    .UpdateQA()
                Next
            End If
        End With
        GridView2.CancelUpdateCurrentRow()
        LoadQABoxGrid()
    End Sub

    Private Sub QAListingForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
