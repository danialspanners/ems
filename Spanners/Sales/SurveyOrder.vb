Public Class SurveyOrderForm
    Inherits System.Windows.Forms.Form

#Region "SurveyOrderHeader's variable"
    Public SO_ID As Integer
    Public SO_No As String
    Public PrevSO_ID As String
    Public Project_ID As String
    Public SO_Date As String
    Public Create_Date As String
    Public Transact_Date As String
#End Region

#Region "SurveyOrderLine's variable"
    Public SOLine_ID As Integer
    Public LnSO_ID As Integer
    Public LnItem_No As Integer
    Public LnContract_ID As Integer
    Public LnOGB_IO_ID As Integer
    Public LnDescription As String
    Public LnQty As String
    Public LnExpected_Completion_Date As String
    Public LnExpected_Date As String
    Public LnRemark As String
    Public LnCreate_Date As String
    Public LnTransact_Date As String
#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public FormStatus As String
    Public Contract_ID As Integer
    Public SOds As DataSet

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pSO_ID As Integer = 0, Optional ByVal pContract_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus

        If Not pSO_ID = 0 Then
            SO_ID = pSO_ID
        End If

        If Not pContract_ID = 0 Then
            Contract_ID = pContract_ID
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents WIPCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents WIPChkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DNComDateLbl As System.Windows.Forms.Label
    Friend WithEvents WONoLbl As System.Windows.Forms.Label
    Friend WithEvents SONoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DNNoLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContractNOTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SOLineGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridItem_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridIO_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridExpected_Complete_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridCompletion_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DelSOLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents EditSOLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NewSOLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SO_Line_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OGB_IO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrevSOTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProjectTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.SOLineGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.WIPCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.WIPChkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SO_Line_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridItem_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridIO_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridExpected_Complete_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridCompletion_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OGB_IO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DelSOLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EditSOLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewSOLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DNComDateLbl = New System.Windows.Forms.Label
        Me.SODate = New DevExpress.XtraEditors.DateEdit
        Me.WONoLbl = New System.Windows.Forms.Label
        Me.SONoTxt = New DevExpress.XtraEditors.TextEdit
        Me.DNNoLbl = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProjectTxt = New DevExpress.XtraEditors.TextEdit
        Me.PrevSOTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.ContractNOTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.SOLineGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIPCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIPChkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SONoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProjectTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrevSOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractNOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SOLineGrid
        '
        Me.SOLineGrid.EditorsRepository = Me.PersistentRepository1
        Me.SOLineGrid.Location = New System.Drawing.Point(16, 176)
        Me.SOLineGrid.MainView = Me.GridView1
        Me.SOLineGrid.Name = "SOLineGrid"
        Me.SOLineGrid.Size = New System.Drawing.Size(600, 184)
        Me.SOLineGrid.TabIndex = 86
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.WIPCheckEdit, Me.WIPChkEdit})
        '
        'WIPCheckEdit
        '
        Me.WIPCheckEdit.Name = "WIPCheckEdit"
        Me.WIPCheckEdit.Properties.AllowFocused = False
        Me.WIPCheckEdit.Properties.AutoHeight = False
        Me.WIPCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'WIPChkEdit
        '
        Me.WIPChkEdit.Name = "WIPChkEdit"
        Me.WIPChkEdit.Properties.AllowFocused = False
        Me.WIPChkEdit.Properties.AutoHeight = False
        Me.WIPChkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WIPChkEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.WIPChkEdit.Properties.ValueChecked = "1"
        Me.WIPChkEdit.Properties.ValueUnchecked = "0"
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SO_Line_ID, Me.GridItem_No, Me.GridIO_No, Me.GridDesc, Me.GridQty, Me.GridExpected_Complete_Date, Me.GridCompletion_Date, Me.GridRemark, Me.OGB_IO_ID})
        Me.GridView1.DefaultEdit = Me.WIPCheckEdit
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'SO_Line_ID
        '
        Me.SO_Line_ID.Caption = "Line_ID"
        Me.SO_Line_ID.FieldName = "SOLine_ID"
        Me.SO_Line_ID.Name = "SO_Line_ID"
        '
        'GridItem_No
        '
        Me.GridItem_No.Caption = "Item No"
        Me.GridItem_No.FieldName = "Item_No"
        Me.GridItem_No.Name = "GridItem_No"
        Me.GridItem_No.VisibleIndex = 0
        '
        'GridIO_No
        '
        Me.GridIO_No.Caption = "IO No"
        Me.GridIO_No.FieldName = "IO_No"
        Me.GridIO_No.Name = "GridIO_No"
        Me.GridIO_No.VisibleIndex = 1
        '
        'GridDesc
        '
        Me.GridDesc.Caption = "Description"
        Me.GridDesc.FieldName = "Description"
        Me.GridDesc.Name = "GridDesc"
        Me.GridDesc.VisibleIndex = 2
        '
        'GridQty
        '
        Me.GridQty.Caption = "Qty"
        Me.GridQty.FieldName = "Qty"
        Me.GridQty.Name = "GridQty"
        Me.GridQty.VisibleIndex = 3
        '
        'GridExpected_Complete_Date
        '
        Me.GridExpected_Complete_Date.Caption = "Expected_Complete_Date"
        Me.GridExpected_Complete_Date.FieldName = "Expected_Complete_Date"
        Me.GridExpected_Complete_Date.Name = "GridExpected_Complete_Date"
        Me.GridExpected_Complete_Date.VisibleIndex = 4
        '
        'GridCompletion_Date
        '
        Me.GridCompletion_Date.Caption = "Completion_Date"
        Me.GridCompletion_Date.FieldName = "Completion_Date"
        Me.GridCompletion_Date.Name = "GridCompletion_Date"
        Me.GridCompletion_Date.VisibleIndex = 5
        '
        'GridRemark
        '
        Me.GridRemark.Caption = "Remark"
        Me.GridRemark.FieldName = "Remarks"
        Me.GridRemark.Name = "GridRemark"
        Me.GridRemark.VisibleIndex = 6
        '
        'OGB_IO_ID
        '
        Me.OGB_IO_ID.Caption = "OGB_IO_ID"
        Me.OGB_IO_ID.FieldName = "OGB_IO_ID"
        Me.OGB_IO_ID.Name = "OGB_IO_ID"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(552, 368)
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
        Me.SaveBtn.Location = New System.Drawing.Point(480, 368)
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
        Me.btnRefresh.Location = New System.Drawing.Point(400, 368)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 134
        Me.btnRefresh.Text = "Refresh"
        '
        'DelSOLineBtn
        '
        Me.DelSOLineBtn.AutoSize = False
        Me.DelSOLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelSOLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelSOLineBtn.Image = Nothing
        Me.DelSOLineBtn.Location = New System.Drawing.Point(160, 136)
        Me.DelSOLineBtn.Name = "DelSOLineBtn"
        Me.DelSOLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.DelSOLineBtn.TabIndex = 137
        Me.DelSOLineBtn.Text = "Delete"
        '
        'EditSOLineBtn
        '
        Me.EditSOLineBtn.AutoSize = False
        Me.EditSOLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditSOLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSOLineBtn.Image = Nothing
        Me.EditSOLineBtn.Location = New System.Drawing.Point(88, 136)
        Me.EditSOLineBtn.Name = "EditSOLineBtn"
        Me.EditSOLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.EditSOLineBtn.TabIndex = 136
        Me.EditSOLineBtn.Text = "Edit"
        '
        'NewSOLineBtn
        '
        Me.NewSOLineBtn.AutoSize = False
        Me.NewSOLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewSOLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSOLineBtn.Image = Nothing
        Me.NewSOLineBtn.Location = New System.Drawing.Point(16, 136)
        Me.NewSOLineBtn.Name = "NewSOLineBtn"
        Me.NewSOLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.NewSOLineBtn.TabIndex = 135
        Me.NewSOLineBtn.Text = "Add"
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.WIPCheckEdit})
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DNComDateLbl
        '
        Me.DNComDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNComDateLbl.Location = New System.Drawing.Point(8, 64)
        Me.DNComDateLbl.Name = "DNComDateLbl"
        Me.DNComDateLbl.Size = New System.Drawing.Size(120, 16)
        Me.DNComDateLbl.TabIndex = 44
        Me.DNComDateLbl.Text = "* Survey Order Date :"
        '
        'SODate
        '
        Me.SODate.DateTime = New Date(CType(0, Long))
        Me.SODate.Location = New System.Drawing.Point(144, 64)
        Me.SODate.Name = "SODate"
        Me.SODate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SODate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SODate.Size = New System.Drawing.Size(104, 19)
        Me.SODate.TabIndex = 43
        '
        'WONoLbl
        '
        Me.WONoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WONoLbl.Location = New System.Drawing.Point(304, 16)
        Me.WONoLbl.Name = "WONoLbl"
        Me.WONoLbl.Size = New System.Drawing.Size(152, 16)
        Me.WONoLbl.TabIndex = 42
        Me.WONoLbl.Text = "Previous Survey Order No :"
        '
        'SONoTxt
        '
        Me.SONoTxt.Location = New System.Drawing.Point(144, 16)
        Me.SONoTxt.Name = "SONoTxt"
        Me.SONoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SONoTxt.Properties.ReadOnly = True
        Me.SONoTxt.Size = New System.Drawing.Size(128, 19)
        Me.SONoTxt.TabIndex = 33
        '
        'DNNoLbl
        '
        Me.DNNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNNoLbl.Location = New System.Drawing.Point(8, 20)
        Me.DNNoLbl.Name = "DNNoLbl"
        Me.DNNoLbl.Size = New System.Drawing.Size(120, 16)
        Me.DNNoLbl.TabIndex = 11
        Me.DNNoLbl.Text = "* Survey Order No :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProjectTxt)
        Me.GroupBox1.Controls.Add(Me.PrevSOTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ContractNOTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DNComDateLbl)
        Me.GroupBox1.Controls.Add(Me.SODate)
        Me.GroupBox1.Controls.Add(Me.WONoLbl)
        Me.GroupBox1.Controls.Add(Me.SONoTxt)
        Me.GroupBox1.Controls.Add(Me.DNNoLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 120)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'ProjectTxt
        '
        Me.ProjectTxt.Location = New System.Drawing.Point(144, 88)
        Me.ProjectTxt.Name = "ProjectTxt"
        Me.ProjectTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectTxt.Properties.MaxLength = 14
        Me.ProjectTxt.Size = New System.Drawing.Size(424, 19)
        Me.ProjectTxt.TabIndex = 128
        '
        'PrevSOTxt
        '
        Me.PrevSOTxt.Location = New System.Drawing.Point(464, 16)
        Me.PrevSOTxt.Name = "PrevSOTxt"
        Me.PrevSOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PrevSOTxt.Properties.MaxLength = 14
        Me.PrevSOTxt.Size = New System.Drawing.Size(104, 19)
        Me.PrevSOTxt.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Project :"
        '
        'ContractNOTxt
        '
        Me.ContractNOTxt.Enabled = False
        Me.ContractNOTxt.Location = New System.Drawing.Point(144, 40)
        Me.ContractNOTxt.Name = "ContractNOTxt"
        Me.ContractNOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNOTxt.Properties.ReadOnly = True
        Me.ContractNOTxt.Size = New System.Drawing.Size(128, 19)
        Me.ContractNOTxt.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "* Contract No :"
        '
        'SurveyOrderForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(624, 413)
        Me.Controls.Add(Me.DelSOLineBtn)
        Me.Controls.Add(Me.EditSOLineBtn)
        Me.Controls.Add(Me.NewSOLineBtn)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.SOLineGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SurveyOrderForm"
        Me.Text = "Survey Order"
        CType(Me.SOLineGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIPCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIPChkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SONoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ProjectTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrevSOTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractNOTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Other Events"
    Private Sub SOLineGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)
            End If
            EditSOLineBtn.Enabled = True
            DelSOLineBtn.Enabled = True
        Else
            EditSOLineBtn.Enabled = False
            DelSOLineBtn.Enabled = False
        End If
    End Sub
#End Region

#Region " Codes for Form load"
    Private Sub SurveyOrderFormForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        '        LoadPreviousSO()
        '        LoadProject()

        Select Case UCase(FormStatus)
            Case "NEW"
                Me.Text = "New Survey Order"
                InitializeForm()
                SaveBtn.Enabled = True
                NewSOLineBtn.Enabled = True
                EditSOLineBtn.Enabled = True
                DelSOLineBtn.Enabled = True
            Case "EDIT"
                Me.Text = "Edit Survey Order"
                With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetSurveyOrderHeader(dsHeaderLoad, SO_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                LoadSOLineList(SO_ID)
                SaveBtn.Enabled = True
                NewSOLineBtn.Enabled = True
            Case "VIEW"
                LoadSOLineList(SO_ID)
                Me.Text = "View Survey Order"
                With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetSurveyOrderHeader(dsHeaderLoad, SO_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                NewSOLineBtn.Enabled = False
                EditSOLineBtn.Enabled = True
                EditSOLineBtn.Text = "View"
                DelSOLineBtn.Enabled = False
                SaveBtn.Enabled = False
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()
        DisplayContractNo(Contract_ID)
        SONoTxt.Text = CreateSONo()
        SODate.DateTime = Date.Today
    End Sub

    Private Function CreateSONo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("SO")
        End With
        CreateSONo = "SOPG" & ContractNOTxt.Text & "/" & DocumentNo
    End Function

    Private Sub LoadSOLineList(ByVal pDN_ID As String)
        With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
            .SO_ID = SO_ID
            If .GetSOLine_Display(SOds, SO_ID) Then
                SOLineGrid.DataSource = SOds.Tables(0).DefaultView
                If SOds.Tables(0).Rows.Count() = 0 Then
                    DelSOLineBtn.Enabled = False
                    EditSOLineBtn.Enabled = False
                End If
                If SOds.Tables(0).Rows.Count() > 0 Then
                    DelSOLineBtn.Enabled = True
                    EditSOLineBtn.Enabled = True
                End If
            End If
        End With

    End Sub

#End Region

#Region "Button Events"

    Private Sub NewSOLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSOLineBtn.Click

        If SaveSurveyOrder(1) Then
            Dim form As New SurveyOrderLineForm("NEW", SO_ID, , Contract_ID)
            form.ShowDialog(Me)
        End If
    End Sub

    Private Sub EditSOLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSOLineBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim SOLine_ID As Integer = dr("SOLine_ID")

            Dim form As New SurveyOrderLineForm("EDIT", SO_ID, SOLine_ID, Contract_ID)
            form.ShowDialog(Me)
        End If
    End Sub

    Private Sub DelSOLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelSOLineBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim SOLine_ID As Integer = dr("SOLine_ID")
            Dim IO_ID As Integer = dr("OGB_IO_ID")
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this Survey Order Line?", "Survey Order Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
                    .UserID = UserID
                    If .DeleteSurveyOrderLine(SOLine_ID, IO_ID) Then
                        MessageBox.Show("Survey Order Line Deleted.", "Survey Order Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            LoadSOLineList(SO_ID)
        End If
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveSurveyOrder()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadSOLineList(SO_ID)
    End Sub


#End Region

#Region "Save"
    Private Function SaveSurveyOrder(Optional ByVal bktype As Integer = 0) As Boolean
        Dim bkFlag As Boolean = False

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
                .SO_No = SO_No
                .Contract_ID = Contract_ID
                .PrevSO_ID = PrevSO_ID
                .Project_ID = Project_ID
                .SO_Date = SO_Date
                .UserID = UserID

                If SO_ID = Nothing Or SO_ID = 0 Then
                    SO_ID = .SaveSurveyOrderHeader()
                    SO_ID = .SO_ID
                    If bktype <> 1 Then
                        MessageBox.Show("Survey Order saved!", "Save Survey Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bkFlag = True
                Else
                    .UpdateSurveyOrderHeader(SO_ID)
                    If bktype <> 1 Then
                        MessageBox.Show("Survey Order updated!", "Updates Survey Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bkFlag = True
                End If
            End With
        End If
        Return bkFlag
    End Function
#End Region

#Region "Load Combo Box"
    '        Private Sub LoadProject()
        '        Dim ds As DataSet
        '        With New BusinessRules.SystemBusRules.ProjectBusLogic
        '            If .GetProject(ds) Then
        '                If Not ds Is Nothing Then
        '                    Try
        '                        'SimpleBinding LookUp adjustment start
        '                        AddListFieldInfoToLookUp(ProjectCmb, "Project_Name", 400, 0, "c")
        '                        ProjectCmb.Properties.LookUpData.KeyField = "Project_ID"
        '                        ProjectCmb.Properties.LookUpData.DisplayField = "Project_Name"
        '
        '                        ProjectCmb.Properties.LookUpData.DataSource = ds.Tables(0)
        '                        ProjectCmb.EditValue = "0"
        '                        'SimpleBinding LookUp adjustment end
        '                    Catch exLoad As System.Exception
        '                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
        '                    End Try
        '                End If
        '            End If
        '        End With
        '    End Sub

    '    Private Sub LoadPreviousSO()
        '        Dim ds As DataSet
        '
        '        With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
        '            If .GetSOHeader(ds) Then
        '                If Not ds Is Nothing Then
        '                    Try
        '                        'SimpleBinding LookUp adjustment start
        '                        AddListFieldInfoToLookUp(PrevSOCmb, "SO_No", 400, 0, "c")
        '                        PrevSOCmb.Properties.LookUpData.KeyField = "SO_ID"
        '                        PrevSOCmb.Properties.LookUpData.DisplayField = "SO_No"
        '
        '                        PrevSOCmb.Properties.LookUpData.DataSource = ds.Tables(0)
        '                        PrevSOCmb.EditValue = "0"
        '                        'SimpleBinding LookUp adjustment end
        '                    Catch exLoad As System.Exception
        '                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
        '                    End Try
        '                End If
        '            End If
        '        End With
    '    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

#End Region

#Region "Get/Set Window Value"

    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        SONoTxt.Text = dsLoad.Tables(0).Rows(0)("SO_NO")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Contract_ID")) Then
            Contract_ID = dsLoad.Tables(0).Rows(0)("Contract_ID")
            DisplayContractNo(Contract_ID)
        End If
        ' 30.12.2003 YG Start
        '        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PrevSO_ID")) Then
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PrevSO")) Then
            '            PrevSOCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("PrevSO_ID")
            PrevSOTxt.Text = dsLoad.Tables(0).Rows(0)("PrevSO")
        End If
        '        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Project_ID")) Then
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Project")) Then
            '            ProjectCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Project_ID")
            ProjectTxt.Text = dsLoad.Tables(0).Rows(0)("Project")
            ' 30.12.2003 YG End
        End If
        SODate.DateTime = dsLoad.Tables(0).Rows(0)("SO_Date")
    End Sub

    Private Sub GetWindowsValue()
        SO_No = SONoTxt.Text
        ' 30.12.2003 YG Start
        '        PrevSO_ID = PrevSOCmb.Properties.LookUpData.KeyValue
        PrevSO_ID = PrevSOTxt.Text
        '        Project_ID = ProjectCmb.Properties.LookUpData.KeyValue
        Project_ID = ProjectTxt.Text
        ' 30.12.2003 YG End
        SO_Date = SODate.Text
    End Sub

#End Region

#Region "Utilities"
    ' May be should put the following functions in the common
    Private Function DisplayContractNo(ByVal pContract_ID As String) As Boolean
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            If .GetOGBContract(ds, pContract_ID) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    ContractNOTxt.Text = ds.Tables(0).Rows(0)("OGB_Contract_No")
                End If
            End If
        End With
    End Function

#End Region

#Region "Validation"
    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If SO_No = "" Then
            ErrorMessage = ErrorMessage & " Survey Order No" & Chr(13)
            DataOK_flag = False
        End If

        If SO_Date = "" Then
            ErrorMessage = ErrorMessage & " Survey Order Date" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                If SO_ID <> Nothing And SO_ID <> 0 Then
                    If .RecordExists(SO_No, SO_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(SO_No, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function
#End Region


    Private Sub SurveyOrderForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Survey Order?", "Survey Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
