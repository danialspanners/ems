Public Class OGBRequestF28Form
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pFormType As String, Optional ByVal pBoxType As String = "OGB")
        MyBase.New()

        FormType = pFormType
        BoxType = UCase(pBoxType)

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        If BoxType = "LVB" Then
            Me.Location_GridColumn.FieldName = "LVB_Location"
            Me.GridColumn2.FieldName = "Contract_ID"
            Me.GridColumn1.FieldName = "IO_ID"
        End If

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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AttnTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EditDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents F28Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ContractCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IONOLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PersistentRepository3 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PersistentRepository4 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Location_GridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MRC_GridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Officer_GridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Section_GridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintF28Btn As System.Windows.Forms.Button
    Friend WithEvents PrintNoticeBtn As System.Windows.Forms.Button
    Friend WithEvents SaveNoticeBtn As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OGBRequestF28Form))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.IONOLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.AttnTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.EditDate = New DevExpress.XtraEditors.DateEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.F28Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Location_GridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MRC_GridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Officer_GridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Section_GridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ContractCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.PersistentRepository3 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository4 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SaveNoticeBtn = New System.Windows.Forms.Button
        Me.PrintNoticeBtn = New System.Windows.Forms.Button
        Me.PrintF28Btn = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.IONOLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttnTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F28Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.IONOLookUpEdit, Me.RepositoryItemTextEdit2})
        '
        'IONOLookUpEdit
        '
        Me.IONOLookUpEdit.Name = "IONOLookUpEdit"
        Me.IONOLookUpEdit.Properties.AllowFocused = False
        Me.IONOLookUpEdit.Properties.AutoHeight = False
        Me.IONOLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.IONOLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.IONOLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.IONOLookUpEdit.Properties.NullString = ""
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "* Attn :"
        '
        'AttnTxt
        '
        Me.AttnTxt.Location = New System.Drawing.Point(92, 80)
        Me.AttnTxt.Name = "AttnTxt"
        Me.AttnTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AttnTxt.Size = New System.Drawing.Size(160, 19)
        Me.AttnTxt.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Date :"
        '
        'EditDate
        '
        Me.EditDate.DateTime = New Date(CType(0, Long))
        Me.EditDate.Location = New System.Drawing.Point(92, 8)
        Me.EditDate.Name = "EditDate"
        Me.EditDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EditDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EditDate.Properties.ShowClear = False
        Me.EditDate.Size = New System.Drawing.Size(128, 19)
        Me.EditDate.TabIndex = 59
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'F28Grid
        '
        Me.F28Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F28Grid.EditorsRepository = Me.PersistentRepository2
        Me.F28Grid.Location = New System.Drawing.Point(0, 0)
        Me.F28Grid.MainView = Me.GridView1
        Me.F28Grid.Name = "F28Grid"
        Me.F28Grid.Size = New System.Drawing.Size(840, 315)
        Me.F28Grid.TabIndex = 86
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType(((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.Location_GridColumn, Me.MRC_GridColumn, Me.Officer_GridColumn, Me.Section_GridColumn})
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IO No"
        Me.GridColumn1.ColumnEdit = Me.IONOLookUpEdit
        Me.GridColumn1.FieldName = "OGB_IO_ID"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo1
        Me.GridColumn1.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "Contractor_ID"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo2
        Me.GridColumn2.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn2.Name = "GridColumn2"
        '
        'Location_GridColumn
        '
        Me.Location_GridColumn.Caption = "Location"
        Me.Location_GridColumn.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.Location_GridColumn.FieldName = "OGB_Location"
        Me.Location_GridColumn.FilterInfo = ColumnFilterInfo3
        Me.Location_GridColumn.Name = "Location_GridColumn"
        Me.Location_GridColumn.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Location_GridColumn.VisibleIndex = 1
        Me.Location_GridColumn.Width = 250
        '
        'MRC_GridColumn
        '
        Me.MRC_GridColumn.Caption = "MRC No"
        Me.MRC_GridColumn.FieldName = "MRC_No"
        Me.MRC_GridColumn.FilterInfo = ColumnFilterInfo4
        Me.MRC_GridColumn.Name = "MRC_GridColumn"
        Me.MRC_GridColumn.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.MRC_GridColumn.VisibleIndex = 2
        '
        'Officer_GridColumn
        '
        Me.Officer_GridColumn.Caption = "Officer In-charge"
        Me.Officer_GridColumn.FieldName = "Officer_Name"
        Me.Officer_GridColumn.FilterInfo = ColumnFilterInfo5
        Me.Officer_GridColumn.Name = "Officer_GridColumn"
        Me.Officer_GridColumn.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Officer_GridColumn.VisibleIndex = 3
        Me.Officer_GridColumn.Width = 120
        '
        'Section_GridColumn
        '
        Me.Section_GridColumn.Caption = "Section"
        Me.Section_GridColumn.FieldName = "Section_Code"
        Me.Section_GridColumn.FilterInfo = ColumnFilterInfo6
        Me.Section_GridColumn.Name = "Section_GridColumn"
        Me.Section_GridColumn.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Section_GridColumn.VisibleIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "* To :"
        '
        'ToCmb
        '
        Me.ToCmb.Location = New System.Drawing.Point(92, 56)
        Me.ToCmb.Name = "ToCmb"
        Me.ToCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ToCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ToCmb.Properties.NullString = ""
        Me.ToCmb.Size = New System.Drawing.Size(128, 19)
        Me.ToCmb.TabIndex = 179
        '
        'ContractCmb
        '
        Me.ContractCmb.Location = New System.Drawing.Point(92, 32)
        Me.ContractCmb.Name = "ContractCmb"
        Me.ContractCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContractCmb.Properties.NullString = ""
        Me.ContractCmb.Size = New System.Drawing.Size(128, 19)
        Me.ContractCmb.TabIndex = 181
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "* Contract No :"
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Delete})
        '
        'Delete
        '
        Me.Delete.Index = 0
        Me.Delete.Text = "Delete"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.PrintF28Btn)
        Me.Panel1.Controls.Add(Me.PrintNoticeBtn)
        Me.Panel1.Controls.Add(Me.SaveNoticeBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 57)
        Me.Panel1.TabIndex = 183
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.AttnTxt)
        Me.Panel2.Controls.Add(Me.ContractCmb)
        Me.Panel2.Controls.Add(Me.EditDate)
        Me.Panel2.Controls.Add(Me.ToCmb)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 112)
        Me.Panel2.TabIndex = 184
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.F28Grid)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(844, 319)
        Me.Panel3.TabIndex = 185
        '
        'SaveNoticeBtn
        '
        Me.SaveNoticeBtn.Location = New System.Drawing.Point(12, 13)
        Me.SaveNoticeBtn.Name = "SaveNoticeBtn"
        Me.SaveNoticeBtn.Size = New System.Drawing.Size(109, 31)
        Me.SaveNoticeBtn.TabIndex = 181
        Me.SaveNoticeBtn.Text = "Save Notification"
        Me.SaveNoticeBtn.UseVisualStyleBackColor = True
        '
        'PrintNoticeBtn
        '
        Me.PrintNoticeBtn.Location = New System.Drawing.Point(127, 13)
        Me.PrintNoticeBtn.Name = "PrintNoticeBtn"
        Me.PrintNoticeBtn.Size = New System.Drawing.Size(109, 31)
        Me.PrintNoticeBtn.TabIndex = 182
        Me.PrintNoticeBtn.Text = "Print Notification"
        Me.PrintNoticeBtn.UseVisualStyleBackColor = True
        '
        'PrintF28Btn
        '
        Me.PrintF28Btn.Location = New System.Drawing.Point(242, 13)
        Me.PrintF28Btn.Name = "PrintF28Btn"
        Me.PrintF28Btn.Size = New System.Drawing.Size(88, 31)
        Me.PrintF28Btn.TabIndex = 183
        Me.PrintF28Btn.Text = "Print LV Form"
        Me.PrintF28Btn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(336, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 31)
        Me.Button3.TabIndex = 184
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OGBRequestF28Form
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(844, 488)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "OGBRequestF28Form"
        Me.Text = "Request For LV Form"
        CType(Me.IONOLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttnTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F28Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dataGrid = New DataTable("ColumnsTable")
    Public IO_Id As Integer
    Public Contract_Id As Integer
    Dim Attention_Name As String
    Dim CustomerName As String
    Dim Edit_Date As String
    Public FormType As String
    Public BoxType As String
    Dim OGBds As DataSet

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub OGBRequestF28Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If FormType = "F28" Then
            PrintF28Btn.Visible = True
            PrintF28Btn.Enabled = True
            PrintNoticeBtn.Visible = False
            PrintNoticeBtn.Enabled = False
            SaveNoticeBtn.Text = "Save LV Form"
        Else
            PrintF28Btn.Visible = False
            PrintF28Btn.Enabled = False
            PrintNoticeBtn.Visible = True
            PrintNoticeBtn.Enabled = True
            SaveNoticeBtn.Text = "Save Notification"
        End If
        F28Grid.Enabled = False
        EditDate.DateTime = Date.Today
        'InitList()
        If BoxType = "LVB" Then
            Label4.Visible = False
            ToCmb.Visible = False
            If FormType <> "F28" Then
                AttnTxt.Text = "PRODUCTION DEPARTMENT"
                AttnTxt.Enabled = False
            End If
            LoadLVBContract(1)
            LoadLVBPrintNotificationList(0, EditDate.Text)
        Else
            LoadTo()
            LoadContract(1)
            LoadOGBPrintNotificationList(0, EditDate.Text)
        End If

        'InitList()
        'InitGrid()


    End Sub

    Private Sub F28Grid_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles F28Grid.DoubleClick
        'Dim NewForm As New SelectOGBContractForF28Form
        'NewForm.ShowDialog(Me)
        'IO_Id = NewForm.IO_Id
        'InitGrid()
    End Sub

    Private Sub InitList()
        dataGrid.BeginInit()
        AddColumn(dataGrid, "OGB_IO_Id", System.Type.GetType("System.Int32"), True)
        'AddColumn(dataGrid, "Contract_Id", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "OGB_Location", System.Type.GetType("System.String"), True)
        'AddColumn(dataGrid, "IO No", System.Type.GetType("System.String"), True)
        F28Grid.DataSource = dataGrid
        F28Grid.MainView.PopulateColumns()
    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub

    Private Sub InitGrid()
        If IO_Id <> Nothing And IO_Id <> 0 Then
            Dim ds As DataSet
            With New BusinessRules.OGBBusRules.OGBBusLogic
                If .GetIO(ds, IO_Id) Then
                    If Not ds Is Nothing Then
                        Try
                            Dim oRow As DataRow
                            Dim i As Integer = 0
                            For Each oRow In ds.Tables(0).Rows
                                dataGrid.Rows.Add(New Object() {oRow("OGB_IO_Id"), _
                                                    oRow("OGB_Location"), oRow("IO_No")})
                            Next
                            'AddColumn(dataGrid, "OGB_Location", System.Type.GetType("System.String"), True)
                            F28Grid.DataSource = dataGrid
                            F28Grid.DefaultView.PopulateColumns()
                            GridView1.BestFitColumns()

                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try
                    End If
                End If
            End With
        End If

        GridView1.Columns.Item(0).VisibleIndex = -1
        GridView1.Columns.Item(1).VisibleIndex = -1
    End Sub

    Private Sub PrintF28Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintF28Btn.Click
        Dim i As Integer
        Dim StrIO_ID
        Dim dr As DataRow
        Dim items As Object()

        If FormType = "F28" Then
            If BoxType = "LVB" Then
                SaveLVBF28()
            Else
                SaveF28()
            End If
        Else
            If BoxType = "LVB" Then
                SaveLVBNotification()
            Else
                SaveNotification()
            End If
        End If

        RetrieveFromForm()
        If ValidData() Then

            GridView1.UpdateCurrentRow()
            GridView1.CloseEditor()
            If GridView1.RowCount > 0 Then
                For i = 0 To OGBds.Tables(0).Rows.Count - 1
                    dr = GridView1.GetDataRow(i)
                    items = dr.ItemArray

                    StrIO_ID = StrIO_ID & items(0) & ","
                Next
                Dim slen
                slen = Len(StrIO_ID)
                StrIO_ID = Microsoft.VisualBasic.Left(StrIO_ID, slen - 1)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                If BoxType = "LVB" Then
                    controlToAdd = New LVBF28ReportForm(StrIO_ID, Attention_Name, Edit_Date)
                Else
                    controlToAdd = New OGBF28ReportForm(StrIO_ID, Attention_Name, Edit_Date)
                End If
                page = New Crownwood.Magic.Controls.TabPage("Print Request LV Form", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub PrintNoticeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNoticeBtn.Click
        Dim i As Integer
        Dim StrIO_ID
        Dim dr As DataRow
        Dim items As Object()
        Dim FieldName As String

        If FormType = "F28" Then
            If BoxType = "LVB" Then
                SaveLVBF28()
            Else
                SaveF28()
            End If
        Else
            If BoxType = "LVB" Then
                SaveLVBNotification()
            Else
                SaveNotification()
            End If
        End If

        RetrieveFromForm()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        If ValidData() Then
            'Check for pending TOC
            'If False Then
            If CheckPendingToc() = True Then
                FieldName = "Printing of Notification is not allowed:" & Chr(13)
                FieldName = FieldName & "There are one or more Pending TOC(s) by one or more Officer(s) " & Chr(13)
                MessageBox.Show(FieldName, "Printing disallowed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If GridView1.RowCount > 0 Then
                For i = 0 To OGBds.Tables(0).Rows.Count - 1
                    dr = GridView1.GetDataRow(i)
                    items = dr.ItemArray

                    StrIO_ID = StrIO_ID & items(0) & ","
                Next
                Dim slen
                slen = Len(StrIO_ID)
                If slen <> 0 Then
                    StrIO_ID = Microsoft.VisualBasic.Left(StrIO_ID, slen - 1)

                    Dim a As MainForm = Me.ParentForm
                    Dim controlToAdd As Control = Nothing
                    Me.Cursor = Cursors.WaitCursor

                    Dim page As Crownwood.Magic.Controls.TabPage
                    If BoxType = "LVB" Then
                        controlToAdd = New NotificationLVBInstallRptForm(StrIO_ID, Edit_Date)
                    Else
                        controlToAdd = New NotificationOGBInstallRptForm(StrIO_ID, CustomerName, Edit_Date, Attention_Name)
                    End If
                    page = New Crownwood.Magic.Controls.TabPage("Print Notification", controlToAdd, ImageList1, 0)

                    page.Selected = True
                    a.MainTabControl.TabPages.Add(page)
                    Me.Cursor = Cursors.Default
                Else
                    MessageBox.Show("Please select at least one IO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub RetrieveFromForm()
        Attention_Name = AttnTxt.Text
        Edit_Date = EditDate.Text
        CustomerName = ToCmb.Text
    End Sub

    Private Function ValidData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(Attention_Name) > 0 Then
            DataOK_Flag = False
            FieldName = "Attention Name" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function

    'Returns true if there are Pending TOC 
    Function CheckPendingToc() As Boolean
        If BoxType = "LVB" Then

            With New BusinessRules.LVBBusRules.LVBBusLogic
                If .CheckPendingTOC(Nothing, Contract_Id, EditDate.Text) = True Then
                    Return True
                End If
            End With

        Else

            With New BusinessRules.OGBBusRules.OGBBusLogic
                If .CheckPendingTOC(Nothing, Contract_Id, EditDate.Text) = True Then
                    Return True
                End If
            End With
            

        End If


        Return False
    End Function

    Private Sub OGBRequestF28Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

#Region "Laod Combo Box"
    Private Sub LoadTo()
        Dim ds As DataSet
        With New BusinessRules.CustomerBusRules.CustomerBusLogic '.SupplierBusRules.SupplierBusLogic
            If .LoadList(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ToCmb, "Name", 400, 0, "c")
                        ToCmb.Properties.LookUpData.KeyField = "Customer_ID"
                        ToCmb.Properties.LookUpData.DisplayField = "Name"

                        ToCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ToCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
    Private Sub AddListFieldInfoToRepositoryLookUp(ByVal le As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToRepositoryLookUp(le, field, width, alignment, format)
        End With
    End Sub
    Private Sub LoadIONo(ByVal addflag As Integer, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
        Dim ds As DataSet

        With New BusinessRules.OGBBusRules.OGBBusLogic
            If Len(e.Value) > 0 Then
                .Contract_Id = e.Value
                If .GetIOWContractId(ds) Then
                    If Not ds Is Nothing Then
                        IONOLookUpEdit.Properties.LookUpData.ListFields.Clear()
                        AddListFieldInfoToRepositoryLookUp(IONOLookUpEdit, "IO_No", 400, 0, "c")
                        IONOLookUpEdit.Properties.LookUpData.KeyField = "OGB_IO_Id"
                        IONOLookUpEdit.Properties.LookUpData.DisplayField = "IO_No"
                        IONOLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub LoadLVBIONo(ByVal addflag As Integer, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
        Dim ds As DataSet

        With New BusinessRules.LVBBusRules.LVBBusLogic
            If Len(e.Value) > 0 Then
                .Contract_Id = e.Value
                If .GetIOWContractId(ds) Then
                    If Not ds Is Nothing Then
                        IONOLookUpEdit.Properties.LookUpData.ListFields.Clear()
                        AddListFieldInfoToRepositoryLookUp(IONOLookUpEdit, "IO_No", 400, 0, "c")
                        IONOLookUpEdit.Properties.LookUpData.KeyField = "IO_Id"
                        IONOLookUpEdit.Properties.LookUpData.DisplayField = "IO_No"
                        IONOLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub LoadIONo(ByVal addflag As Integer, ByVal pContract_Id As Integer)
        Dim ds As DataSet

        With New BusinessRules.OGBBusRules.OGBBusLogic
            If Len(pContract_Id) > 0 Then
                .Contract_Id = pContract_Id
                If .GetIOWContractId(ds) Then
                    If Not ds Is Nothing Then
                        IONOLookUpEdit.Properties.LookUpData.ListFields.Clear()
                        AddListFieldInfoToRepositoryLookUp(IONOLookUpEdit, "IO_No", 400, 0, "c")
                        IONOLookUpEdit.Properties.LookUpData.KeyField = "OGB_IO_Id"
                        IONOLookUpEdit.Properties.LookUpData.DisplayField = "IO_No"
                        IONOLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub LoadLVBIONo(ByVal addflag As Integer, ByVal pContract_Id As Integer)
        Dim ds As DataSet

        With New BusinessRules.LVBBusRules.LVBBusLogic
            If Len(pContract_Id) > 0 Then
                .Contract_Id = pContract_Id
                If .GetIOWContractId(ds) Then
                    If Not ds Is Nothing Then
                        IONOLookUpEdit.Properties.LookUpData.ListFields.Clear()
                        AddListFieldInfoToRepositoryLookUp(IONOLookUpEdit, "IO_No", 400, 0, "c")
                        IONOLookUpEdit.Properties.LookUpData.KeyField = "IO_Id"
                        IONOLookUpEdit.Properties.LookUpData.DisplayField = "IO_No"
                        IONOLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    End If
                End If
            End If
        End With
    End Sub
    Private Sub LoadContract(ByVal addflag As Integer)
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            If .GetOGBContract(ds) Then
                If Not ds Is Nothing Then
                    Try
                        If addflag = 1 Then
                            AddListFieldInfoToLookUp(ContractCmb, "OGB_Contract_No", 400, 0, "c")
                        End If
                        ContractCmb.Properties.LookUpData.KeyField = "OGB_Contract_Id"
                        ContractCmb.Properties.LookUpData.DisplayField = "OGB_Contract_No"
                        ContractCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadLVBContract(ByVal addflag As Integer)
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            If .GetLVBContract(ds) Then
                If Not ds Is Nothing Then
                    Try
                        If addflag = 1 Then
                            AddListFieldInfoToLookUp(ContractCmb, "Contract_No", 400, 0, "c")
                        End If
                        ContractCmb.Properties.LookUpData.KeyField = "Contract_Id"
                        ContractCmb.Properties.LookUpData.DisplayField = "Contract_No"
                        ContractCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
#End Region

    Private Sub ToCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles ToCmb.CloseUp
        Dim ds As DataSet
        AttnTxt.Text = "N/A"

        If Len(e.Value) > 0 Then
            With New BusinessRules.SupplierBusRules.SupplierBusLogic
                If .GetSupplier(ds, e.Value) Then
                    If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                        AttnTxt.Text = ds.Tables(0).Rows(0)("Contact_Person").ToString()
                    Else : AttnTxt.Text = "N/A"
                    End If
                End If
            End With
        End If

    End Sub

    Private Sub SaveNoticeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveNoticeBtn.Click
        If FormType = "F28" Then
            If BoxType = "LVB" Then
                SaveLVBF28()
            Else
                SaveF28()
            End If
        Else
            If BoxType = "LVB" Then
                SaveLVBNotification()
            Else
                SaveNotification()
            End If
        End If
    End Sub
    Private Sub OGBDescription()
        Dim i As Integer
        Dim ds As DataSet

        With New BusinessRules.OGBBusRules.OGBBusLogic
            If OGBds.Tables(0).Rows.Count > 0 Then
                For i = 0 To OGBds.Tables(0).Rows.Count - 1
                    If .GetIO(ds, GridView1.GetRowCellValue(i, GridView1.Columns("OGB_IO_ID"))) = True Then
                        'dr("OGB_Location") = "AAA" 'ds.Tables(0).Rows(0)("OGB_Location")
                        'For i = 0 To ds.Tables(0).Rows.Count - 1
                        Me.GridView1.SetRowCellValue(i, GridView1.Columns("OGB_Location"), ds.Tables(0).Rows(0)("OGB_Location"))
                        Me.GridView1.SetRowCellValue(i, GridView1.Columns("MRC_No"), ds.Tables(0).Rows(0)("MRC_No"))
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Officer_Name")) Then
                            Me.GridView1.SetRowCellValue(i, GridView1.Columns("Officer_Name"), ds.Tables(0).Rows(0)("Officer_Name"))
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section_Code")) Then
                            Me.GridView1.SetRowCellValue(i, GridView1.Columns("Section_Code"), ds.Tables(0).Rows(0)("Section_Code"))
                        End If

                        'dr("MRC_no") = ds.Tables(0).Rows(0)("MRC_no")
                        'dr("Officer_In_Charge") = ds.Tables(0).Rows(0)("Officer_Name")
                        'dr("Section") = ds.Tables(0).Rows(0)("Section_Code")
                        'Next
                        ds.Dispose()
                    End If
                Next
            End If
        End With

    End Sub

    Private Sub LVBDescription()
        Dim i As Integer
        Dim ds As DataSet

        With New BusinessRules.LVBBusRules.LVBBusLogic
            If OGBds.Tables(0).Rows.Count > 0 Then
                For i = 0 To OGBds.Tables(0).Rows.Count - 1
                    If .GetIO(ds, GridView1.GetRowCellValue(i, GridView1.Columns("IO_ID"))) = True Then
                        'dr("OGB_Location") = "AAA" 'ds.Tables(0).Rows(0)("OGB_Location")
                        'For i = 0 To ds.Tables(0).Rows.Count - 1
                        Me.GridView1.SetRowCellValue(i, GridView1.Columns("LVB_Location"), ds.Tables(0).Rows(0)("LVB_Location"))
                        Me.GridView1.SetRowCellValue(i, GridView1.Columns("MRC_No"), ds.Tables(0).Rows(0)("MRC_No"))
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Officer_Name")) Then
                            Me.GridView1.SetRowCellValue(i, GridView1.Columns("Officer_Name"), ds.Tables(0).Rows(0)("Officer_Name"))
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section_Code")) Then
                            Me.GridView1.SetRowCellValue(i, GridView1.Columns("Section_Code"), ds.Tables(0).Rows(0)("Section_Code"))
                        End If

                        'dr("MRC_no") = ds.Tables(0).Rows(0)("MRC_no")
                        'dr("Officer_In_Charge") = ds.Tables(0).Rows(0)("Officer_Name")
                        'dr("Section") = ds.Tables(0).Rows(0)("Section_Code")
                        'Next
                        ds.Dispose()
                    End If
                Next
            End If
        End With

    End Sub

    Private Function SaveNotification() As Boolean
        Dim savestatus As Boolean = False
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()

        If GridView1.RowCount > 0 Then
            With New BusinessRules.OGBBusRules.OGBBusLogic

                .Contractor_Id = Contract_Id
                .Transact_Date = EditDate.Text
                .DeleteOGBNotification()

                'Dim dt As DataTable = GridView1.DataSource()
                For i As Integer = 0 To OGBds.Tables(0).Rows.Count - 1
                    Dim dtsavestatus As Boolean = False
                    If OGBds.Tables(0).Rows(i).RowState() = DataRowState.Deleted Then
                        'MessageBox.Show("Helo")
                    Else
                        If Not IsDBNull(OGBds.Tables(0).Rows(i)("OGB_IO_ID")) Then
                            .OGB_IO_Id = OGBds.Tables(0).Rows(i)("OGB_IO_ID")
                            dtsavestatus = True
                        End If
                    End If
                    'If Not IsDBNull(OGBds.Tables(0).Rows(i)("Contractor_ID")) Then
                    '.Contractor_Id = OGBds.Tables(0).Rows(i)("Contractor_ID")
                    '.Contractor_Id = Contract_Id
                    'dtsavestatus = True
                    'End If
                    .Contractor_Id = Contract_Id
                    .Transact_Date = EditDate.Text
                    .UserID = Common.CommonConn.Config.USERID
                    If dtsavestatus = True Then
                        If .SaveOGBNotification() Then
                            'MessageBox.Show("Notification saved", "OGB Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Error saving notification", "OGB Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next

            End With
        End If

        Return savestatus

    End Function

    Private Function SaveLVBNotification() As Boolean
        Dim savestatus As Boolean = False
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()

        If GridView1.RowCount > 0 Then
            With New BusinessRules.LVBBusRules.LVBBusLogic

                .Contract_Id = Contract_Id
                .Transact_Date = EditDate.Text
                .DeleteLVBNotification()

                'Dim dt As DataTable = GridView1.DataSource()
                For i As Integer = 0 To OGBds.Tables(0).Rows.Count - 1
                    Dim dtsavestatus As Boolean = False
                    If OGBds.Tables(0).Rows(i).RowState() = DataRowState.Deleted Then
                        'MessageBox.Show("Helo")
                    Else
                        If Not IsDBNull(OGBds.Tables(0).Rows(i)("IO_ID")) Then
                            .IO_Id = OGBds.Tables(0).Rows(i)("IO_ID")
                            dtsavestatus = True
                        End If
                    End If
                    'If Not IsDBNull(OGBds.Tables(0).Rows(i)("Contractor_ID")) Then
                    '.Contractor_Id = OGBds.Tables(0).Rows(i)("Contractor_ID")
                    '.Contractor_Id = Contract_Id
                    'dtsavestatus = True
                    'End If
                    .Contract_Id = Contract_Id
                    .Transact_Date = EditDate.Text
                    .UserID = Common.CommonConn.Config.USERID
                    If dtsavestatus = True Then
                        If .SaveLVBNotification() Then
                            'MessageBox.Show("Notification saved", "OGB Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Error saving notification", "LVB Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next

            End With
        End If

        Return savestatus

    End Function


    Private Function SaveF28() As Boolean
        Dim savestatus As Boolean = False
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()

        If GridView1.RowCount > 0 Then
            With New BusinessRules.OGBBusRules.OGBBusLogic

                .Contractor_Id = Contract_Id
                .Transact_Date = EditDate.Text
                .DeleteOGBF28()

                'Dim dt As DataTable = GridView1.DataSource()
                For i As Integer = 0 To OGBds.Tables(0).Rows.Count - 1
                    Dim dtsavestatus As Boolean = False
                    If OGBds.Tables(0).Rows(i).RowState() = DataRowState.Deleted Then
                        'MessageBox.Show("Helo")
                    Else
                        If Not IsDBNull(OGBds.Tables(0).Rows(i)("OGB_IO_ID")) Then
                            .OGB_IO_Id = OGBds.Tables(0).Rows(i)("OGB_IO_ID")
                            dtsavestatus = True
                        End If
                    End If
                    'If Not IsDBNull(OGBds.Tables(0).Rows(i)("Contractor_ID")) Then
                    '.Contractor_Id = OGBds.Tables(0).Rows(i)("Contractor_ID")
                    '.Contractor_Id = Contract_Id
                    'dtsavestatus = True
                    'End If
                    .Contractor_Id = Contract_Id
                    .Transact_Date = EditDate.Text
                    .UserID = Common.CommonConn.Config.USERID
                    If dtsavestatus = True Then
                        If .SaveOGBF28() Then
                            'MessageBox.Show("Notification saved", "OGB Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Error saving notification", "OGB Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next

            End With
        End If

        Return savestatus

    End Function

    Private Function SaveLVBF28() As Boolean
        Dim savestatus As Boolean = False
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()

        If GridView1.RowCount > 0 Then
            With New BusinessRules.LVBBusRules.LVBBusLogic

                .Contract_Id = Contract_Id
                .Transact_Date = EditDate.Text
                .AttnLVBF28 = AttnTxt.Text
                .DeleteLVBF28()

                'Dim dt As DataTable = GridView1.DataSource()
                For i As Integer = 0 To OGBds.Tables(0).Rows.Count - 1
                    Dim dtsavestatus As Boolean = False
                    If OGBds.Tables(0).Rows(i).RowState() = DataRowState.Deleted Then
                        'MessageBox.Show("Helo")
                    Else
                        If Not IsDBNull(OGBds.Tables(0).Rows(i)("IO_ID")) Then
                            .IO_Id = OGBds.Tables(0).Rows(i)("IO_ID")
                            dtsavestatus = True
                        End If
                    End If
                    'If Not IsDBNull(OGBds.Tables(0).Rows(i)("Contractor_ID")) Then
                    '.Contractor_Id = OGBds.Tables(0).Rows(i)("Contractor_ID")
                    '.Contractor_Id = Contract_Id
                    'dtsavestatus = True
                    'End If
                    .Contract_Id = Contract_Id
                    .Transact_Date = EditDate.Text
                    .UserID = Common.CommonConn.Config.USERID
                    If dtsavestatus = True Then
                        If .SaveLVBF28() Then
                            'MessageBox.Show("Notification saved", "OGB Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Error saving notification", "LVB Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next

            End With
        End If

        Return savestatus

    End Function

    Private Sub ContractCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles ContractCmb.CloseUp

        If Len(e.Value) > 0 Then
            F28Grid.Enabled = True
            Contract_Id = e.Value
            If BoxType = "LVB" Then
                LoadLVBPrintNotificationList(e.Value, EditDate.Text)
                LoadLVBIONo(1, e)
                LVBDescription()
            Else
                LoadOGBPrintNotificationList(e.Value, EditDate.Text)
                LoadIONo(1, e)
                OGBDescription()
            End If

        Else : F28Grid.Enabled = False
        End If
    End Sub

    Private Sub LoadOGBPrintNotificationList(ByVal pContract_ID As String, ByVal pTransactDate As Date)
        With New BusinessRules.OGBBusRules.OGBBusLogic
            If pContract_ID <> 0 Then
                If FormType = "F28" Then
                    If .GetOGBF28Date(OGBds, pContract_ID, pTransactDate) Then
                        Dim dv As DataView
                        dv = OGBds.Tables(0).DefaultView

                        dv.Table.Columns.Add("OGB_Location", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("MRC_No", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Officer_Name", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Section_Code", System.Type.GetType("System.String"))

                        F28Grid.DataSource = dv
                    End If
                Else
                    If .GetOGBNotificationDate(OGBds, pContract_ID, pTransactDate) Then
                        Dim dv As DataView
                        dv = OGBds.Tables(0).DefaultView

                        dv.Table.Columns.Add("OGB_Location", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("MRC_No", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Officer_Name", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Section_Code", System.Type.GetType("System.String"))

                        F28Grid.DataSource = dv
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub LoadLVBPrintNotificationList(ByVal pContract_ID As String, ByVal pTransactDate As Date)
        With New BusinessRules.LVBBusRules.LVBBusLogic
            If pContract_ID <> 0 Then
                If FormType = "F28" Then
                    If .GetLVBF28Date(OGBds, pContract_ID, pTransactDate) Then
                        Dim dv As DataView
                        dv = OGBds.Tables(0).DefaultView

                        dv.Table.Columns.Add("LVB_Location", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("MRC_No", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Officer_Name", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Section_Code", System.Type.GetType("System.String"))

                        F28Grid.DataSource = dv
                    End If
                Else
                    If .GetLVBNotificationDate(OGBds, pContract_ID, pTransactDate) Then
                        Dim dv As DataView
                        dv = OGBds.Tables(0).DefaultView

                        dv.Table.Columns.Add("LVB_Location", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("MRC_No", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Officer_Name", System.Type.GetType("System.String"))
                        dv.Table.Columns.Add("Section_Code", System.Type.GetType("System.String"))

                        F28Grid.DataSource = dv
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub IONOLookUpEdit_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles IONOLookUpEdit.CloseUp
        Dim ds As DataSet
        'dt = ColorLookUpEdit.Properties.LookUpData.DataSource()
        'MessageBox.Show(dt.Rows(e.Value)("pricerate"))
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then

            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))
            Dim str As String
            str = "aaa"
            If Not IsNothing(e.Value) Then
                If BoxType = "LVB" Then
                    With New BusinessRules.LVBBusRules.LVBBusLogic
                        If .GetIO(ds, e.Value) = True Then
                            'dr("OGB_Location") = "AAA" 'ds.Tables(0).Rows(0)("OGB_Location")
                            Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("LVB_Location"), ds.Tables(0).Rows(0)("LVB_Location"))
                            Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("MRC_No"), ds.Tables(0).Rows(0)("MRC_No"))
                            If Not IsDBNull(ds.Tables(0).Rows(0)("Officer_Name")) Then
                                Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("Officer_Name"), ds.Tables(0).Rows(0)("Officer_Name"))
                            End If
                            If Not IsDBNull(ds.Tables(0).Rows(0)("Section_Code")) Then
                                Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("Section_Code"), ds.Tables(0).Rows(0)("Section_Code"))
                            End If

                            'dr("MRC_no") = ds.Tables(0).Rows(0)("MRC_no")
                            'dr("Officer_In_Charge") = ds.Tables(0).Rows(0)("Officer_Name")
                            'dr("Section") = ds.Tables(0).Rows(0)("Section_Code")
                        End If

                    End With
                Else
                    With New BusinessRules.OGBBusRules.OGBBusLogic
                        If .GetIO(ds, e.Value) = True Then
                            'dr("OGB_Location") = "AAA" 'ds.Tables(0).Rows(0)("OGB_Location")
                            Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("OGB_Location"), ds.Tables(0).Rows(0)("OGB_Location"))
                            Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("MRC_No"), ds.Tables(0).Rows(0)("MRC_No"))
                            If Not IsDBNull(ds.Tables(0).Rows(0)("Officer_Name")) Then
                                Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("Officer_Name"), ds.Tables(0).Rows(0)("Officer_Name"))
                            End If
                            If Not IsDBNull(ds.Tables(0).Rows(0)("Section_Code")) Then
                                Me.GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns("Section_Code"), ds.Tables(0).Rows(0)("Section_Code"))
                            End If

                            'dr("MRC_no") = ds.Tables(0).Rows(0)("MRC_no")
                            'dr("Officer_In_Charge") = ds.Tables(0).Rows(0)("Officer_Name")
                            'dr("Section") = ds.Tables(0).Rows(0)("Section_Code")
                        End If

                    End With
                End If

            End If

        End If
    End Sub

    Private Sub F28Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles F28Grid.MouseUp
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

    Private Sub ComponentContextMenu_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComponentContextMenu.Popup

    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim Row As Integer = GridView1.GetSelectedRows(0)
        GridView1.DeleteRow(Row)
    End Sub

    Private Sub EditDate_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles EditDate.CloseUp
        If Contract_Id <> 0 Then
            F28Grid.Enabled = True
            If BoxType = "LVB" Then
                LoadLVBPrintNotificationList(Me.Contract_Id, e.Value)
                LoadLVBIONo(1, Contract_Id)
                LVBDescription()
            Else
                LoadOGBPrintNotificationList(Me.Contract_Id, e.Value)
                LoadIONo(1, Contract_Id)
                OGBDescription()
            End If

        Else : F28Grid.Enabled = False
        End If
    End Sub

    Private Sub F28Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F28Grid.Click

    End Sub
End Class
