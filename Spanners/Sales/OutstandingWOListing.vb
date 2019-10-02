Public Class OutstandingWOListing
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
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents WOGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents DispatchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DepthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WidthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HeightTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DepthLbl As System.Windows.Forms.Label
    Friend WithEvents WidthLbl As System.Windows.Forms.Label
    Friend WithEvents MaterialCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ColorCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents KeyCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NoteTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WOBoxGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DrawingNoCmb As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DrawingNoLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyToCompTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrawingNoListBox As System.Windows.Forms.ListBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.WOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DispatchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DrawingNoListBox = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.WOBoxGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.DrawingNoCmb = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.DrawingNoLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.QtyToCompTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NoteTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.DepthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WidthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.HeightTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.DepthLbl = New System.Windows.Forms.Label
        Me.WidthLbl = New System.Windows.Forms.Label
        Me.MaterialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ColorCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.KeyCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.UpdateBtn = New System.Windows.Forms.Button
        Me.PrintBtn = New System.Windows.Forms.Button
        Me.CloseBtn = New System.Windows.Forms.Button
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WOBoxGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingNoLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyToCompTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoteTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 504)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(64, 24)
        Me.RefreshBtn.TabIndex = 17
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'WOGrid
        '
        Me.WOGrid.EditorsRepository = Me.PersistentRepository1
        Me.WOGrid.Location = New System.Drawing.Point(8, 8)
        Me.WOGrid.MainView = Me.GridView1
        Me.WOGrid.Name = "WOGrid"
        Me.WOGrid.Size = New System.Drawing.Size(712, 200)
        Me.WOGrid.TabIndex = 16
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
        'DispatchBtn
        '
        Me.DispatchBtn.AutoSize = False
        Me.DispatchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DispatchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DispatchBtn.Image = Nothing
        Me.DispatchBtn.Location = New System.Drawing.Point(328, 496)
        Me.DispatchBtn.Name = "DispatchBtn"
        Me.DispatchBtn.Size = New System.Drawing.Size(72, 32)
        Me.DispatchBtn.TabIndex = 22
        Me.DispatchBtn.Text = "Dispatch"
        Me.DispatchBtn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DrawingNoListBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.WOBoxGrid)
        Me.GroupBox1.Controls.Add(Me.NoteTxt)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.DepthTxt)
        Me.GroupBox1.Controls.Add(Me.WidthTxt)
        Me.GroupBox1.Controls.Add(Me.HeightTxt)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DepthLbl)
        Me.GroupBox1.Controls.Add(Me.WidthLbl)
        Me.GroupBox1.Controls.Add(Me.MaterialCmb)
        Me.GroupBox1.Controls.Add(Me.ColorCmb)
        Me.GroupBox1.Controls.Add(Me.KeyCmb)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 272)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work Order Details"
        '
        'DrawingNoListBox
        '
        Me.DrawingNoListBox.Enabled = False
        Me.DrawingNoListBox.Location = New System.Drawing.Point(484, 156)
        Me.DrawingNoListBox.Name = "DrawingNoListBox"
        Me.DrawingNoListBox.Size = New System.Drawing.Size(216, 108)
        Me.DrawingNoListBox.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Drawing No :"
        '
        'WOBoxGrid
        '
        Me.WOBoxGrid.EditorsRepository = Me.PersistentRepository2
        Me.WOBoxGrid.Location = New System.Drawing.Point(8, 16)
        Me.WOBoxGrid.MainView = Me.GridView2
        Me.WOBoxGrid.Name = "WOBoxGrid"
        Me.WOBoxGrid.Size = New System.Drawing.Size(694, 136)
        Me.WOBoxGrid.TabIndex = 131
        Me.WOBoxGrid.Text = "GridControl1"
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit2, Me.DrawingNoCmb, Me.DrawingNoLookUpEdit, Me.RepositoryItemTextEdit3, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.QtyToCompTextEdit})
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.Properties.AllowFocused = False
        Me.RepositoryItemDateEdit1.Properties.AutoHeight = False
        Me.RepositoryItemDateEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemDateEdit1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemDateEdit1.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemDateEdit1.Properties.Enabled = False
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.Properties.AllowFocused = False
        Me.RepositoryItemDateEdit2.Properties.AutoHeight = False
        Me.RepositoryItemDateEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemDateEdit2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemDateEdit2.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemDateEdit2.Properties.Enabled = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.Properties.AllowFocused = False
        Me.RepositoryItemCheckEdit1.Properties.AllowGrayed = True
        Me.RepositoryItemCheckEdit1.Properties.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Properties.Border3D = True
        Me.RepositoryItemCheckEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemCheckEdit1.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.RepositoryItemCheckEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.Properties.ValueChecked = "1"
        Me.RepositoryItemCheckEdit1.Properties.ValueUnchecked = "0"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'DrawingNoCmb
        '
        Me.DrawingNoCmb.Name = "DrawingNoCmb"
        Me.DrawingNoCmb.Properties.AllowFocused = False
        Me.DrawingNoCmb.Properties.AutoHeight = False
        Me.DrawingNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DrawingNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DrawingNoCmb.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DrawingNoCmb.Properties.UseCtrlScroll = True
        '
        'DrawingNoLookUpEdit
        '
        Me.DrawingNoLookUpEdit.Name = "DrawingNoLookUpEdit"
        Me.DrawingNoLookUpEdit.Properties.AllowFocused = False
        Me.DrawingNoLookUpEdit.Properties.AutoHeight = False
        Me.DrawingNoLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DrawingNoLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DrawingNoLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DrawingNoLookUpEdit.Properties.Enabled = False
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit3.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.Properties.AllowFocused = False
        Me.RepositoryItemMemoExEdit1.Properties.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoExEdit1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemMemoExEdit1.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        Me.RepositoryItemTextEdit4.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit4.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit4.Properties.Enabled = False
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        Me.RepositoryItemTextEdit5.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit5.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit5.Properties.Enabled = False
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        Me.RepositoryItemTextEdit6.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit6.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit6.Properties.Enabled = False
        '
        'QtyToCompTextEdit
        '
        Me.QtyToCompTextEdit.Name = "QtyToCompTextEdit"
        Me.QtyToCompTextEdit.Properties.AllowFocused = False
        Me.QtyToCompTextEdit.Properties.AutoHeight = False
        Me.QtyToCompTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.QtyToCompTextEdit.Properties.Enabled = False
        '
        'GridView2
        '
        Me.GridView2.BehaviorOptions = CType((((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowRowSizing), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn7, Me.GridColumn8, Me.GridColumn10, Me.GridColumn3, Me.GridColumn1, Me.GridColumn6, Me.GridColumn5, Me.GridColumn9})
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
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GridColumn4.FieldName = "Box"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 150
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Qty Bal"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GridColumn7.FieldName = "Compl_Qty_Bal"
        Me.GridColumn7.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 65
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Qty Compl"
        Me.GridColumn8.FieldName = "Qty_Compl"
        Me.GridColumn8.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 80
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Qty To Complete"
        Me.GridColumn10.ColumnEdit = Me.QtyToCompTextEdit
        Me.GridColumn10.FieldName = "Compl_Qty"
        Me.GridColumn10.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 110
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GridColumn3.FieldName = "Qty"
        Me.GridColumn3.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 45
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Exp. Compl Date"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn1.FieldName = "Exp_Compl_Date"
        Me.GridColumn1.FormatString = "dd-MM-yyyy"
        Me.GridColumn1.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.DateTime
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 110
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Compl'n Date"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn6.FieldName = "Compl_Date"
        Me.GridColumn6.FormatString = "dd-MM-yyyy"
        Me.GridColumn6.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.DateTime
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Work Done"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn5.FieldName = "WorkStatus"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Note"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn9.FieldName = "Compl_Note"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.VisibleIndex = 7
        '
        'NoteTxt
        '
        Me.NoteTxt.Enabled = False
        Me.NoteTxt.Location = New System.Drawing.Point(80, 220)
        Me.NoteTxt.Name = "NoteTxt"
        Me.NoteTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NoteTxt.Size = New System.Drawing.Size(304, 46)
        Me.NoteTxt.TabIndex = 128
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(16, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Note :"
        '
        'DepthTxt
        '
        Me.DepthTxt.Enabled = False
        Me.DepthTxt.Location = New System.Drawing.Point(312, 196)
        Me.DepthTxt.Name = "DepthTxt"
        Me.DepthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DepthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DepthTxt.Size = New System.Drawing.Size(72, 19)
        Me.DepthTxt.TabIndex = 116
        Me.DepthTxt.Text = "0"
        '
        'WidthTxt
        '
        Me.WidthTxt.Enabled = False
        Me.WidthTxt.Location = New System.Drawing.Point(312, 176)
        Me.WidthTxt.Name = "WidthTxt"
        Me.WidthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WidthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WidthTxt.Size = New System.Drawing.Size(72, 19)
        Me.WidthTxt.TabIndex = 115
        Me.WidthTxt.Text = "0"
        '
        'HeightTxt
        '
        Me.HeightTxt.Enabled = False
        Me.HeightTxt.Location = New System.Drawing.Point(312, 156)
        Me.HeightTxt.Name = "HeightTxt"
        Me.HeightTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.HeightTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HeightTxt.Size = New System.Drawing.Size(72, 19)
        Me.HeightTxt.TabIndex = 114
        Me.HeightTxt.Text = "0"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(248, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "Height :"
        '
        'DepthLbl
        '
        Me.DepthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepthLbl.Location = New System.Drawing.Point(248, 200)
        Me.DepthLbl.Name = "DepthLbl"
        Me.DepthLbl.Size = New System.Drawing.Size(48, 16)
        Me.DepthLbl.TabIndex = 118
        Me.DepthLbl.Text = "Depth :"
        '
        'WidthLbl
        '
        Me.WidthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthLbl.Location = New System.Drawing.Point(248, 178)
        Me.WidthLbl.Name = "WidthLbl"
        Me.WidthLbl.Size = New System.Drawing.Size(48, 16)
        Me.WidthLbl.TabIndex = 117
        Me.WidthLbl.Text = "Width :"
        '
        'MaterialCmb
        '
        Me.MaterialCmb.Enabled = False
        Me.MaterialCmb.Location = New System.Drawing.Point(80, 196)
        Me.MaterialCmb.Name = "MaterialCmb"
        Me.MaterialCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MaterialCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialCmb.Properties.NullString = ""
        Me.MaterialCmb.Size = New System.Drawing.Size(120, 19)
        Me.MaterialCmb.TabIndex = 112
        '
        'ColorCmb
        '
        Me.ColorCmb.Enabled = False
        Me.ColorCmb.Location = New System.Drawing.Point(80, 156)
        Me.ColorCmb.Name = "ColorCmb"
        Me.ColorCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ColorCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ColorCmb.Properties.NullString = ""
        Me.ColorCmb.Size = New System.Drawing.Size(120, 19)
        Me.ColorCmb.TabIndex = 111
        '
        'KeyCmb
        '
        Me.KeyCmb.Enabled = False
        Me.KeyCmb.Location = New System.Drawing.Point(80, 176)
        Me.KeyCmb.Name = "KeyCmb"
        Me.KeyCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.KeyCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.KeyCmb.Properties.NullString = ""
        Me.KeyCmb.Size = New System.Drawing.Size(120, 19)
        Me.KeyCmb.TabIndex = 110
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Material :"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Color :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Key :"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(408, 496)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.BtnRefresh.TabIndex = 55
        Me.BtnRefresh.Text = "&Refresh"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(488, 496)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(72, 32)
        Me.UpdateBtn.TabIndex = 56
        Me.UpdateBtn.Text = "&Update"
        '
        'PrintBtn
        '
        Me.PrintBtn.Location = New System.Drawing.Point(568, 496)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(72, 32)
        Me.PrintBtn.TabIndex = 57
        Me.PrintBtn.Text = "&Print"
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(648, 496)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 58
        Me.CloseBtn.Text = "&Close"
        '
        'OutstandingWOListing
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(728, 533)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DispatchBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.WOGrid)
        Me.Name = "OutstandingWOListing"
        Me.Text = "Outstanding Work Order Listing"
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.WOBoxGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingNoLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyToCompTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoteTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

#Region " Work Order Header Variable "
    Public WO_ID As Integer
    Public WO_NO As String
    Public Confirm_Quotation_No As String
    Public Status As String
    Public WO_Date As String
    Public Cust_PO As String
    Public PO_Date As String
    Public Collect_Mode As String
    Public Customer_ID As Integer
    Public Contact_ID As Integer
    Public ProjectSub As String
    Public Project As String
    Public Notes As String
    Public RevRefWOID As Integer

#End Region

#Region " Work Order Line Variable "
    Public WO_Line_ID As Integer
    Public WO_ItemNo As Integer
    Public Box As String
    Public varHeight As Integer
    Public varWidth As Integer
    Public Depth As Integer
    Public Key_Type As String
    Public Color As String
    Public Material As String
    Public Draw_No As String
    Public Qty As Integer
    Public Note As String
    Public Compl_Date As String
    Public Expected_Compl_Date As String
    Public Qty_Compl As Integer
    Public Qty_Bal As Integer
    Public WorkStatus As String
#End Region

    Public NavdsBox As DataSet              'FOR NAV
    Dim CurrentRow As Integer               'FOR NAVIGATION
    Dim WOds As DataSet 'For Work order dataset
    Dim WOLineds As DataSet

#Region " Form Load "
    Private Sub OutstandingWOListing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadKey()
        LoadColor()
        LoadMaterial()
        LoadOutstandingWOList()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadKey()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.KeyBusLogic
            If .GetKey(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(KeyCmb, "Key_Name", 400, 0, "c")
                        KeyCmb.Properties.LookUpData.KeyField = "Key_ID"
                        KeyCmb.Properties.LookUpData.DisplayField = "Key_Name"

                        KeyCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        KeyCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadColor()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ColorCmb, "Color_Name", 400, 0, "c")
                        ColorCmb.Properties.LookUpData.KeyField = "Color_ID"
                        ColorCmb.Properties.LookUpData.DisplayField = "Color_Name"

                        ColorCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ColorCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadMaterial()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.MaterialBusLogic
            If .GetMaterial(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(MaterialCmb, "Material_Name", 400, 0, "c")
                        MaterialCmb.Properties.LookUpData.KeyField = "Material_ID"
                        MaterialCmb.Properties.LookUpData.DisplayField = "Material_Name"

                        MaterialCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        MaterialCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadOutstandingWOList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            'If .GetWOLineComplDateHeader(ds, 0, "30") And ds.Tables(0).Rows.Count > 0 Then
            If .GetWOHeader(ds, 0, "30") And ds.Tables(0).Rows.Count > 0 Then
                .WO_ID = ds.Tables(0).Rows(0)("WO_ID")
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

                        data.Rows.Add(New Object() {oRow("WO_ID"), i, oRow("WO_No"), ChangeDateFormat(oRow("WO_Date")), Status, oRow("Collect_Mode")}) 'oRow("Status"), ProjectTitle, oRow("CustomerName"), oRow("Initial")})
                    Next
                    WOGrid.DataSource = data
                    WOGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    'GridView1.Columns.Item(4).VisibleIndex = -1 'hide 4th. Status
                    SetButtonsControl(True)
                    WO_ID = .WO_ID  'oRow("WO_ID")

                    'Load WO LIne into Grid
                    LoadWOBoxGrid()
                    LoadWODrawingNoListBox()
                    'RefreshNavBtn()
                    'Else
                    'GridView1.Columns.Clear()
                    'SetButtonsControl(False)
                End If
            Else
                GridView1.Columns.Clear()
                SetButtonsControl(False)
            End If
        End With
    End Sub

    Private Sub LoadWOBoxGrid()
        'Dim ds As DataSet

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .WO_ID = WO_ID
            ClearWOLinesDetails()
            'If .GetWOLine(WOds) Then
            If .GetWOLineCompletionDate(WOds) Then
                WOBoxGrid.DataSource = WOds.Tables(0).DefaultView
                WO_Line_ID = 0
                If WOds.Tables(0).Rows.Count > 0 Then
                    'txtColor.Text = WOds.Tables(0).Rows(0)("Color").ToString()
                    .WO_Line_ID = WOds.Tables(0).Rows(0)("WO_Line_ID")
                    .GetWOLine_ByWOLineID(WOLineds)
                    WOLineGrid_PositionChanged()
                End If
                'WOBoxGrid.MainView.PopulateColumns()
                'WOBoxGrid.DefaultView.PopulateColumns()
                'GridView2.BestFitColumns()
                'GridView2.Columns.Item(0).VisibleIndex = -1
            End If
        End With
    End Sub

    Private Sub LoadWODrawingNoListBox()
        Dim ds As DataSet
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            DrawingNoListBox.DataSource = Nothing
            .DrawingNo_WO_Line_ID = WO_Line_ID
            .GetWOLineDrawingNo(ds)
            If Not ds Is Nothing Then
                Try
                    DrawingNoListBox.DisplayMember = "drawing_no"
                    DrawingNoListBox.ValueMember = "WOLineDrawID"
                    DrawingNoListBox.DataSource = ds.Tables(0).DefaultView

                Catch ex As Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                'DrawingNoListBox.DataSource = ds.Tables(0).DefaultView                
            End If

        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "WO_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Work Order No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Date", System.Type.GetType("System.String"), True)
        'AddColumn(data, "StatusCode", System.Type.GetType("System.String"), True)
        AddColumn(data, "Status", System.Type.GetType("System.String"), True)
        AddColumn(data, "Collect Mode", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Customer Name", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Code", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Public Sub OutstandingWOListGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WOGrid.Click
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)
                'Dim Status As Integer = dr("WO_ID")

                WOds = Nothing
                WOLineds = Nothing
                WO_ID = dr("WO_ID")
                LoadWOBoxGrid()
                LoadWODrawingNoListBox()
            End If
        End If
    End Sub

    Private Sub ClearWOLinesDetails()

        Me.HeightTxt.Text = 0
        Me.WidthTxt.Text = 0
        Me.DepthTxt.Text = 0

        Me.KeyCmb.Properties.LookUpData.KeyValue = ""
        Me.ColorCmb.Properties.LookUpData.KeyValue = ""
        Me.MaterialCmb.Properties.LookUpData.KeyValue = ""
        'Me.DrawNoCmb.Properties.LookUpData.KeyValue = ""

        'Me.WorkStatusChk.Checked = False

        'Me.QtyComplTxt.Text = 0
        'Me.QtyBalTxt.Text = 0

        Me.NoteTxt.Text = ""
    End Sub

    Private Sub WOLineGrid_PositionChanged()

        If WOLineds.Tables(0).Rows.Count > 0 Then
            WO_Line_ID = Me.WOLineds.Tables(0).Rows(0)("WO_Line_ID")
            Me.HeightTxt.Text = Integer.Parse(Me.WOLineds.Tables(0).Rows(0)("Height"))
            Me.WidthTxt.Text = Integer.Parse(Me.WOLineds.Tables(0).Rows(0)("Width"))
            Me.DepthTxt.Text = Integer.Parse(Me.WOLineds.Tables(0).Rows(0)("Depth"))

            Me.KeyCmb.Properties.LookUpData.KeyValue = Me.WOLineds.Tables(0).Rows(0)("Key_Type")
            Me.ColorCmb.Properties.LookUpData.KeyValue = Me.WOLineds.Tables(0).Rows(0)("Color")
            Me.MaterialCmb.Properties.LookUpData.KeyValue = Me.WOLineds.Tables(0).Rows(0)("Material")
            'Me.DrawNoCmb.Properties.LookUpData.KeyValue = Me.WOLineds.Tables(0).Rows(0)("Draw_No")

            If Not IsDBNull(Me.WOLineds.Tables(0).Rows(0)("WorkStatus")) Then
                If Me.WOLineds.Tables(0).Rows(0)("WorkStatus") = "1" Then
                    'Me.WorkStatusChk.Checked = True
                    GridColumn5.ColumnEdit.Properties.Enabled = False
                    GridColumn5.ColumnEdit.Properties.ReadOnly = True
                Else
                    'Me.WorkStatusChk.Checked = False
                    GridColumn5.ColumnEdit.Properties.Enabled = True
                    GridColumn5.ColumnEdit.Properties.ReadOnly = False
                End If
            Else
                'Me.WorkStatusChk.Checked = False
                GridColumn5.ColumnEdit.Properties.Enabled = True
                GridColumn5.ColumnEdit.Properties.ReadOnly = False
            End If

            'If Not IsDBNull(Me.WOLineds.Tables(0).Rows(0)("Compl_Date")) Then
            'Me.ComplDate.DateTime = Me.WOLineds.Tables(0).Rows(0)("Compl_Date")
            'Else
            'Me.ComplDate.DateTime = Nothing
            'End If

            'If Not IsDBNull(Me.WOLineds.Tables(0).Rows(0)("Expected_Compl_Date")) Then
            'Me.ExComplDate.DateTime = Me.WOLineds.Tables(0).Rows(0)("Expected_Compl_Date")
            'Else
            'Me.ExComplDate.DateTime = Nothing
            'End If

            'If Not IsDBNull(Me.WOLineds.Tables(0).Rows(0)("Qty_Compl")) Then
            'Me.QtyComplTxt.Text = Integer.Parse(Me.WOLineds.Tables(0).Rows(0)("Qty_Compl"))
            'End If

            'If Not IsDBNull(Me.WOLineds.Tables(0).Rows(0)("Qty_Bal")) Then
            'Me.QtyBalTxt.Text = Integer.Parse(Me.WOLineds.Tables(0).Rows(0)("Qty_Bal"))
            'End If

            If Not IsDBNull(Me.WOLineds.Tables(0).Rows(0)("Note")) Then
                Me.NoteTxt.Text = Me.WOLineds.Tables(0).Rows(0)("Note")
            Else
                Me.NoteTxt.Text = ""
            End If
        Else
            WO_Line_ID = 0
            Me.HeightTxt.Text = 0
            Me.WidthTxt.Text = 0
            Me.DepthTxt.Text = 0

            Me.KeyCmb.Properties.LookUpData.KeyValue = ""
            Me.ColorCmb.Properties.LookUpData.KeyValue = ""
            Me.MaterialCmb.Properties.LookUpData.KeyValue = ""
            'Me.DrawNoCmb.Properties.LookUpData.KeyValue = ""

            'Me.WorkStatusChk.Checked = False

            'Me.ComplDate.DateTime = Nothing
            'Me.ExComplDate.DateTime = Nothing

            'Me.QtyComplTxt.Text = 0
            'Me.QtyBalTxt.Text = 0

            Me.NoteTxt.Text = ""

        End If
    End Sub
#End Region


#Region " Navigation "
    Private Sub DisableNavBtn()
        'Me.NavFirstBtn.Enabled = False
        'Me.NavLastBtn.Enabled = False
        'Me.NavNextBtn.Enabled = False
        'Me.NavPrevBtn.Enabled = False
    End Sub

    Private Sub EnableNavBtn()
        'Me.NavFirstBtn.Enabled = True
        'Me.NavLastBtn.Enabled = True
        'Me.NavNextBtn.Enabled = True
        'Me.NavPrevBtn.Enabled = True
    End Sub

    Private Sub NavdsBox_PositionChanged()
        'Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of  ") _
        '            + Me.NavdsBox.Tables(0).Rows.Count.ToString)
        WO_Line_ID = Me.NavdsBox.Tables(0).Rows(CurrentRow)("WO_Line_ID")
        Me.HeightTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Height"))
        Me.WidthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Width"))
        Me.DepthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Depth"))

        Me.KeyCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Key_Type")
        Me.ColorCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Color")
        Me.MaterialCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Material")
        'Me.DrawNoCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Draw_No")

        'If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("WorkStatus")) Then
        'If Me.NavdsBox.Tables(0).Rows(CurrentRow)("WorkStatus") = "1" Then
        'Me.WorkStatusChk.Checked = True
        'Else
        'Me.WorkStatusChk.Checked = False
        'End If
        'Else
        'Me.WorkStatusChk.Checked = False
        'End If

        'If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Compl_Date")) Then
        'Me.ComplDate.DateTime = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Compl_Date")
        'Else
        'Me.ComplDate.DateTime = Nothing
        'End If

        'If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Expected_Compl_Date")) Then
        'Me.ExComplDate.DateTime = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Expected_Compl_Date")
        'Else
        'Me.ExComplDate.DateTime = Nothing
        'End If

        'If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Compl")) Then
        'Me.QtyComplTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Compl"))
        'End If

        'If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Bal")) Then
        'Me.QtyBalTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Bal"))
        'End If

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Note")) Then
            Me.NoteTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Note")
        End If

        'RefreshComponentGrid()
    End Sub

    Private Sub NavFirstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            CurrentRow = 0
            Me.BindingContext(NavdsBox).Position = 0
            Me.NavdsBox_PositionChanged()
        End If
    End Sub

    Private Sub NavPrevBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            If CurrentRow > 0 Then CurrentRow = CurrentRow - 1
            Me.BindingContext(NavdsBox).Position = (Me.BindingContext(NavdsBox).Position - 1)
            Me.NavdsBox_PositionChanged()
        End If
    End Sub

    Private Sub NavNextBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            If CurrentRow < Me.NavdsBox.Tables(0).Rows.Count - 1 Then
                CurrentRow = CurrentRow + 1
            End If
            Me.BindingContext(NavdsBox).Position = (Me.BindingContext(NavdsBox).Position + 1)
            Me.NavdsBox_PositionChanged()
        End If
    End Sub

    Private Sub NavLastBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            CurrentRow = (Me.NavdsBox.Tables(0).Rows.Count - 1)
            Me.BindingContext(NavdsBox).Position = (Me.NavdsBox.Tables(0).Rows.Count - 1)
            Me.NavdsBox_PositionChanged()
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
        'btnRefresh.Enabled = State
        'ApproveBtn.Enabled = State
        'CloseBtn.Enabled = State
    End Sub
#End Region

#Region " Combo Box - Drawing No n Loading Customer n Contact Person Cmb "
    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
    'Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
    '    With New BusinessRules.CommonBusRules.CommonLogic
    '        .AddListFieldInfoToRepositoryLookUp(le, field, width, alignment, format)
    '    End With
    'End Sub

#End Region

    

    Private Sub WorkStatusChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        OutstandingWOListGrid_Click(sender, e)
    End Sub

    Public Sub RefreshComponentGrid()
        Dim ds As DataSet
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            '.WO_Line_ID = WO_Line_ID
            GridView1.Columns.Clear()
            .WO_ID = WO_ID
            If .GetWOHeader(ds) Then '  .GetWOLineCompOnLineID(ds) Then
                'InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    'data.Rows.Add(New Object() {i, oRow("WO_No"), oRow("Box"), oRow("Qty"), oRow("Height"), oRow("Width"), oRow("Depth")})
                    data.Rows.Add(New Object() {oRow("WO_ID"), i, oRow("WO_No"), ChangeDateFormat(oRow("WO_Date")), Status, oRow("Collect_Mode")})
                Next
                WOGrid.DataSource = data
                WOGrid.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column
            End If
        End With
    End Sub

    Private Sub GridView2_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                WO_Line_ID = dr("WO_LINE_ID")
                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    .WO_Line_ID = WO_Line_ID
                    .GetWOLine_ByWOLineID(WOLineds)
                    WOLineGrid_PositionChanged()
                End With
            End If
        End If

    End Sub

    Private Sub OutstandingWOListing_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged

    End Sub

    Private Sub DispatchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchBtn.Click

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        LoadOutstandingWOList()
    End Sub


    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click

        Dim QAds As DataSet

        GridView2.CloseEditor()
        GridView2.UpdateCurrentRow()
        Dim WO As New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
        For i As Integer = 0 To WOds.Tables(0).Rows.Count - 1
            WO.WO_Line_ID = WOds.Tables(0).Rows(i)("WO_Line_ID")
            WO.Box = WOds.Tables(0).Rows(i)("Box").ToString
            WO.UserID = UserID
            '.varHeight = Integer.Parse(WOds.Tables(0).Rows(i)("Height"))
            '.varWidth = Integer.Parse(WOds.Tables(0).Rows(i)("Width"))
            '.Depth = Integer.Parse(WOds.Tables(0).Rows(i)("Depth"))
            '.Key_Type = WOds.Tables(0).Rows(i)("Key_Type").ToString
            '.Color = WOds.Tables(0).Rows(i)("Color").ToString
            '.Material = WOds.Tables(0).Rows(i)("Material").ToString
            '.Draw_No = WOds.Tables(0).Rows(i)("Draw_No").ToString
            If IsDBNull(WOds.Tables(0).Rows(i)("WorkStatus")) Then
                WO.WorkStatus = "0"
            Else
                WO.WorkStatus = WOds.Tables(0).Rows(i)("WorkStatus").ToString
            End If
            WO.Compl_Date = WOds.Tables(0).Rows(i)("Compl_Date").ToString
            WO.Expected_Compl_Date = WOds.Tables(0).Rows(i)("Expected_Compl_Date").ToString
            WO.Qty = WOds.Tables(0).Rows(i)("Qty")
            WO.Note = WOds.Tables(0).Rows(i)("Note").ToString

            Dim QA As New BusinessRules.QABusRules.QABusLogic
            QA.WO_Line_ID = WOds.Tables(0).Rows(i)("WO_Line_ID")
            QA.ExpComplDateWO_Line_ID = WOds.Tables(0).Rows(i)("WOLineComplDateID")
            ' CHECK EXISTING OF WORK ORDER LINE
            Dim QAQty = QA.GetQA(QAds)
            If WO.WorkStatus = "0" And QA.GetQA(QAds) And QAds.Tables(0).Rows.Count > 0 Then
                Dim qty As Long
                Dim tqty As Long = QA.GetQAQty()

                'Dim TmpQty As Long
                ' TOTAL QUANTITY COMPLETED  
                'If .WorkStatus = "1" Then
                'TmpQty = .Qty - tqty   ' TO GET BALANCE QUANTITY NEED TO COMPLETE
                'WOds.Tables(0).Rows(i)("Qty_Compl") = TmpQty
                'End If

                If Char.IsNumber(WOds.Tables(0).Rows(i)("Qty_Compl").ToString()) And WOds.Tables(0).Rows(i)("Qty_Compl") > 0 Then
                    'Got number n not zero based value
                    qty = tqty + WOds.Tables(0).Rows(i)("Qty_Compl") '+ WOds.Tables(0).Rows(i)("Compl_Qty_Bal")  ' TO GET TOTAL COMPLETED 
                    If qty <= WOds.Tables(0).Rows(i)("Compl_Qty") And WOds.Tables(0).Rows(i)("Qty_Compl") <> 0 Then
                        'more qty to be done...
                        QA.Qty = WOds.Tables(0).Rows(i)("Qty_Compl")
                        QA.WO_Line_ID = WOds.Tables(0).Rows(i)("WO_Line_ID")
                        QA.UserID = Common.CommonConn.Config.USERID
                        QA.CreateQA()

                        QA.Inspected = 0
                        QA.BalQty = 0
                        QA.UserID = Common.CommonConn.Config.USERID
                        QA.CreateQALine()

                        ' RESET QTY COMPLETE
                        WO.Qty_Compl = 0 'WOds.Tables(0).Rows(i)("Qty_Compl")
                        '.Qty_Bal = WOds.Tables(0).Rows(i)("Qty") - WOds.Tables(0).Rows(i)("Qty_Compl") - tqty
                        WO.ExpComplDate_Compl_Qty_Bal = WOds.Tables(0).Rows(i)("Compl_Qty") - WOds.Tables(0).Rows(i)("Qty_Compl") - tqty
                        If WO.ExpComplDate_Compl_Qty_Bal <= 0 Then
                            WO.ExpComplDate_Compl_Status = "1"
                            'WO.WorkStatus = "1"
                            WO.Compl_Date = Now()
                        Else
                            WO.ExpComplDate_Compl_Status = "0"
                            WO.WorkStatus = "0"
                            WO.Compl_Date = ""
                        End If
                        WO.Compl_Date = Now()  ' ASSIGN DATE TO ANY COMPLETED OF ITEM
                        WO.ExpComplDate_WO_Line_ID = WOds.Tables(0).Rows(i)("WOLineComplDateID")
                        WO.UpdateWOLine()
                        WO.UpdateWOLineComplDate()
                        WO.UpdateWorkStatus()
                    Else
                        If (WOds.Tables(0).Rows(i)("Compl_Qty") - WOds.Tables(0).Rows(i)("Qty_Compl") - tqty) <= 0 Then
                            WO.ExpComplDate_Compl_Qty_Bal = 0
                            WO.ExpComplDate_Compl_Status = "1"
                            'WO.WorkStatus = "1"
                            WO.Compl_Date = Now()
                        Else
                            WO.ExpComplDate_Compl_Qty_Bal = WOds.Tables(0).Rows(i)("Compl_Qty") - WOds.Tables(0).Rows(i)("Qty_Compl") - tqty
                            WO.ExpComplDate_Compl_Status = "0"
                            WO.WorkStatus = "0"
                            WO.Compl_Date = ""
                        End If
                        '.Qty_Bal = WOds.Tables(0).Rows(i)("Qty") - WOds.Tables(0).Rows(i)("Qty_Compl") '- tqty
                        WO.ExpComplDate_WO_Line_ID = WOds.Tables(0).Rows(i)("WOLineComplDateID")
                        WO.UpdateWOLine()
                        WO.UpdateWOLineComplDate()
                        WO.UpdateWorkStatus()
                        GridView2.CancelUpdateCurrentRow()
                    End If
                Else
                    GridView2.CancelUpdateCurrentRow()
                End If

            ElseIf WO.WorkStatus = "0" Then
                QA.Qty = WOds.Tables(0).Rows(i)("Qty_Compl")
                QA.UserID = Common.CommonConn.Config.USERID
                QA.CreateQA()
                QA.Inspected = 0
                QA.BalQty = 0
                QA.UserID = Common.CommonConn.Config.USERID
                QA.CreateQALine()
                WO.Qty_Compl = 0 'WOds.Tables(0).Rows(i)("Qty_Compl")
                '.Qty_Bal = WOds.Tables(0).Rows(i)("Qty") - WOds.Tables(0).Rows(i)("Qty_Compl")
                WO.ExpComplDate_Compl_Qty_Bal = WOds.Tables(0).Rows(i)("Compl_Qty") - WOds.Tables(0).Rows(i)("Qty_Compl")
                If WO.ExpComplDate_Compl_Qty_Bal <= 0 Then
                    WO.ExpComplDate_Compl_Status = "1"
                    'WO.WorkStatus = "1"
                    WO.Compl_Date = Now()
                Else
                    WO.ExpComplDate_Compl_Status = "0"
                    WO.WorkStatus = "0"
                    WO.Compl_Date = ""
                End If
                '.Compl_Date = Now() 'DateTime.Parse(WOds.Tables(0).Rows(i)("Compl_Date")).ToShortDateString() 'Now()  ' ASSIGN DATE TO ANY COMPLETED OF ITEM
                WO.ExpComplDate_WO_Line_ID = WOds.Tables(0).Rows(i)("WOLineComplDateID")
                WO.UpdateWOLine()
                WO.UpdateWOLineComplDate()
                WO.UpdateWorkStatus()
            End If

        Next
        'End With
        LoadOutstandingWOList()
        'WOds.Tables(0).Rows(0).AcceptChanges() '.GetChanges.AcceptChanges() ' .Rows(0).AcceptChanges()
        'GridView2.update()
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New WorkOrderReportForm(WO_ID)
        page = New Crownwood.Magic.Controls.TabPage("Print Work Order", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
End Class
