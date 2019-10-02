Public Class PRQuotationList
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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents PRWithOCTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents PRWO_OCTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CreatePRQuotationBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PRListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents ViewPRBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ApproveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SendAprrovalBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ModifyPRBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PRListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents QuotationListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents QuotationListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CreatePRBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DeleteBtn2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ModifyPRBtn2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SendAprrovalBtn2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ViewPRBtn2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ApproveBtn2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PRListGrid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents RefreshBtn2 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PrintPR2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintPRBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ReserveStockBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ReserveStockBtn2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh1 As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PRQuotationList))
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New Crownwood.Magic.Controls.TabControl
        Me.PRWithOCTab = New Crownwood.Magic.Controls.TabPage
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EditBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreatePRQuotationBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRListGrp = New System.Windows.Forms.GroupBox
        Me.ReserveStockBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPRBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ViewPRBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SendAprrovalBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ModifyPRBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRListGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.ApproveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.QuotationListGrp = New System.Windows.Forms.GroupBox
        Me.QuotationListGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PRWO_OCTab = New Crownwood.Magic.Controls.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ReserveStockBtn2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPR2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ViewPRBtn2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SendAprrovalBtn2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ModifyPRBtn2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRListGrid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RefreshBtn2 = New System.Windows.Forms.CheckBox
        Me.CreatePRBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ApproveBtn2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.PRWithOCTab.SuspendLayout()
        Me.PRListGrp.SuspendLayout()
        CType(Me.PRListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuotationListGrp.SuspendLayout()
        CType(Me.QuotationListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRWO_OCTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PRListGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
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
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.TabControl1.AutoScroll = True
        Me.TabControl1.IDEPixelArea = True
        Me.TabControl1.IDEPixelBorder = False
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.PositionTop = False
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SelectedTab = Me.PRWithOCTab
        Me.TabControl1.ShowArrows = False
        Me.TabControl1.ShowClose = False
        Me.TabControl1.Size = New System.Drawing.Size(784, 480)
        Me.TabControl1.TabIndex = 30
        Me.TabControl1.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.PRWithOCTab, Me.PRWO_OCTab})
        '
        'PRWithOCTab
        '
        Me.PRWithOCTab.Controls.Add(Me.btnRefresh)
        Me.PRWithOCTab.Controls.Add(Me.EditBtn)
        Me.PRWithOCTab.Controls.Add(Me.CreatePRQuotationBtn)
        Me.PRWithOCTab.Controls.Add(Me.PRListGrp)
        Me.PRWithOCTab.Controls.Add(Me.QuotationListGrp)
        Me.PRWithOCTab.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.PRWithOCTab.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PRWithOCTab.Location = New System.Drawing.Point(0, 0)
        Me.PRWithOCTab.Name = "PRWithOCTab"
        Me.PRWithOCTab.Size = New System.Drawing.Size(784, 455)
        Me.PRWithOCTab.TabIndex = 3
        Me.PRWithOCTab.Title = "PR With OC"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(16, 192)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 24)
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.Text = "Refresh"
        '
        'EditBtn
        '
        Me.EditBtn.AutoSize = False
        Me.EditBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Image = Nothing
        Me.EditBtn.Location = New System.Drawing.Point(240, 192)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(64, 24)
        Me.EditBtn.TabIndex = 15
        Me.EditBtn.Text = "&View OC"
        '
        'CreatePRQuotationBtn
        '
        Me.CreatePRQuotationBtn.AutoSize = False
        Me.CreatePRQuotationBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreatePRQuotationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatePRQuotationBtn.Image = Nothing
        Me.CreatePRQuotationBtn.Location = New System.Drawing.Point(96, 192)
        Me.CreatePRQuotationBtn.Name = "CreatePRQuotationBtn"
        Me.CreatePRQuotationBtn.Size = New System.Drawing.Size(136, 24)
        Me.CreatePRQuotationBtn.TabIndex = 14
        Me.CreatePRQuotationBtn.Text = "Create New PR From OC"
        '
        'PRListGrp
        '
        Me.PRListGrp.Controls.Add(Me.ReserveStockBtn)
        Me.PRListGrp.Controls.Add(Me.CloseBtn)
        Me.PRListGrp.Controls.Add(Me.PrintPRBtn)
        Me.PRListGrp.Controls.Add(Me.ViewPRBtn)
        Me.PRListGrp.Controls.Add(Me.SendAprrovalBtn)
        Me.PRListGrp.Controls.Add(Me.DeleteBtn)
        Me.PRListGrp.Controls.Add(Me.ModifyPRBtn)
        Me.PRListGrp.Controls.Add(Me.PRListGrid)
        Me.PRListGrp.Controls.Add(Me.RefreshBtn)
        Me.PRListGrp.Controls.Add(Me.ApproveBtn)
        Me.PRListGrp.Location = New System.Drawing.Point(8, 224)
        Me.PRListGrp.Name = "PRListGrp"
        Me.PRListGrp.Size = New System.Drawing.Size(768, 216)
        Me.PRListGrp.TabIndex = 13
        Me.PRListGrp.TabStop = False
        Me.PRListGrp.Text = "Purchase Requistion attached to OC"
        '
        'ReserveStockBtn
        '
        Me.ReserveStockBtn.AutoSize = False
        Me.ReserveStockBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ReserveStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveStockBtn.Image = Nothing
        Me.ReserveStockBtn.Location = New System.Drawing.Point(424, 184)
        Me.ReserveStockBtn.Name = "ReserveStockBtn"
        Me.ReserveStockBtn.Size = New System.Drawing.Size(88, 24)
        Me.ReserveStockBtn.TabIndex = 24
        Me.ReserveStockBtn.Text = "Reserve Stock "
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(680, 184)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(76, 24)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'PrintPRBtn
        '
        Me.PrintPRBtn.AutoSize = False
        Me.PrintPRBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPRBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPRBtn.Image = Nothing
        Me.PrintPRBtn.Location = New System.Drawing.Point(520, 184)
        Me.PrintPRBtn.Name = "PrintPRBtn"
        Me.PrintPRBtn.Size = New System.Drawing.Size(72, 24)
        Me.PrintPRBtn.TabIndex = 16
        Me.PrintPRBtn.Text = "Print PR"
        '
        'ViewPRBtn
        '
        Me.ViewPRBtn.AutoSize = False
        Me.ViewPRBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ViewPRBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPRBtn.Image = Nothing
        Me.ViewPRBtn.Location = New System.Drawing.Point(600, 184)
        Me.ViewPRBtn.Name = "ViewPRBtn"
        Me.ViewPRBtn.Size = New System.Drawing.Size(72, 24)
        Me.ViewPRBtn.TabIndex = 8
        Me.ViewPRBtn.Text = "View PR"
        '
        'SendAprrovalBtn
        '
        Me.SendAprrovalBtn.AutoSize = False
        Me.SendAprrovalBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SendAprrovalBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendAprrovalBtn.Image = Nothing
        Me.SendAprrovalBtn.Location = New System.Drawing.Point(336, 184)
        Me.SendAprrovalBtn.Name = "SendAprrovalBtn"
        Me.SendAprrovalBtn.Size = New System.Drawing.Size(80, 24)
        Me.SendAprrovalBtn.TabIndex = 6
        Me.SendAprrovalBtn.Text = "Dispatch"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(248, 184)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(80, 24)
        Me.DeleteBtn.TabIndex = 5
        Me.DeleteBtn.Text = "Delete PR"
        '
        'ModifyPRBtn
        '
        Me.ModifyPRBtn.AutoSize = False
        Me.ModifyPRBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ModifyPRBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyPRBtn.Image = Nothing
        Me.ModifyPRBtn.Location = New System.Drawing.Point(160, 184)
        Me.ModifyPRBtn.Name = "ModifyPRBtn"
        Me.ModifyPRBtn.Size = New System.Drawing.Size(80, 24)
        Me.ModifyPRBtn.TabIndex = 3
        Me.ModifyPRBtn.Text = "Edit PR"
        '
        'PRListGrid
        '
        Me.PRListGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRListGrid.Location = New System.Drawing.Point(8, 20)
        Me.PRListGrid.MainView = Me.GridView2
        Me.PRListGrid.Name = "PRListGrid"
        Me.PRListGrid.Size = New System.Drawing.Size(752, 156)
        Me.PRListGrid.TabIndex = 2
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView2.Name = "GridView2"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 184)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(88, 24)
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
        Me.ApproveBtn.Location = New System.Drawing.Point(72, 184)
        Me.ApproveBtn.Name = "ApproveBtn"
        Me.ApproveBtn.Size = New System.Drawing.Size(80, 24)
        Me.ApproveBtn.TabIndex = 7
        Me.ApproveBtn.Text = "Approve PR"
        Me.ApproveBtn.Visible = False
        '
        'QuotationListGrp
        '
        Me.QuotationListGrp.Controls.Add(Me.QuotationListGrid)
        Me.QuotationListGrp.Location = New System.Drawing.Point(8, 3)
        Me.QuotationListGrp.Name = "QuotationListGrp"
        Me.QuotationListGrp.Size = New System.Drawing.Size(768, 181)
        Me.QuotationListGrp.TabIndex = 12
        Me.QuotationListGrp.TabStop = False
        Me.QuotationListGrp.Text = "Order Confirmation"
        '
        'QuotationListGrid
        '
        Me.QuotationListGrid.EditorsRepository = Me.PersistentRepository1
        Me.QuotationListGrid.Location = New System.Drawing.Point(8, 16)
        Me.QuotationListGrid.MainView = Me.GridView1
        Me.QuotationListGrid.Name = "QuotationListGrid"
        Me.QuotationListGrid.Size = New System.Drawing.Size(752, 160)
        Me.QuotationListGrid.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        '
        'PRWO_OCTab
        '
        Me.PRWO_OCTab.Controls.Add(Me.GroupBox1)
        Me.PRWO_OCTab.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.PRWO_OCTab.Location = New System.Drawing.Point(0, 0)
        Me.PRWO_OCTab.Name = "PRWO_OCTab"
        Me.PRWO_OCTab.Selected = False
        Me.PRWO_OCTab.Size = New System.Drawing.Size(784, 455)
        Me.PRWO_OCTab.TabIndex = 4
        Me.PRWO_OCTab.Title = "PR Without OC"
        Me.PRWO_OCTab.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReserveStockBtn2)
        Me.GroupBox1.Controls.Add(Me.CloseBtn2)
        Me.GroupBox1.Controls.Add(Me.PrintPR2)
        Me.GroupBox1.Controls.Add(Me.ViewPRBtn2)
        Me.GroupBox1.Controls.Add(Me.SendAprrovalBtn2)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn2)
        Me.GroupBox1.Controls.Add(Me.ModifyPRBtn2)
        Me.GroupBox1.Controls.Add(Me.PRListGrid2)
        Me.GroupBox1.Controls.Add(Me.RefreshBtn2)
        Me.GroupBox1.Controls.Add(Me.CreatePRBtn)
        Me.GroupBox1.Controls.Add(Me.btnRefresh1)
        Me.GroupBox1.Controls.Add(Me.ApproveBtn2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 437)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Requistion Without OC"
        '
        'ReserveStockBtn2
        '
        Me.ReserveStockBtn2.AutoSize = False
        Me.ReserveStockBtn2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ReserveStockBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveStockBtn2.Image = Nothing
        Me.ReserveStockBtn2.Location = New System.Drawing.Point(448, 392)
        Me.ReserveStockBtn2.Name = "ReserveStockBtn2"
        Me.ReserveStockBtn2.Size = New System.Drawing.Size(88, 32)
        Me.ReserveStockBtn2.TabIndex = 25
        Me.ReserveStockBtn2.Text = "Reserve Stock"
        '
        'CloseBtn2
        '
        Me.CloseBtn2.AutoSize = False
        Me.CloseBtn2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn2.Image = Nothing
        Me.CloseBtn2.Location = New System.Drawing.Point(688, 392)
        Me.CloseBtn2.Name = "CloseBtn2"
        Me.CloseBtn2.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn2.TabIndex = 23
        Me.CloseBtn2.Text = "&Close"
        '
        'PrintPR2
        '
        Me.PrintPR2.AutoSize = False
        Me.PrintPR2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPR2.Image = Nothing
        Me.PrintPR2.Location = New System.Drawing.Point(544, 392)
        Me.PrintPR2.Name = "PrintPR2"
        Me.PrintPR2.Size = New System.Drawing.Size(64, 32)
        Me.PrintPR2.TabIndex = 18
        Me.PrintPR2.Text = "Print PR"
        '
        'ViewPRBtn2
        '
        Me.ViewPRBtn2.AutoSize = False
        Me.ViewPRBtn2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ViewPRBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPRBtn2.Image = Nothing
        Me.ViewPRBtn2.Location = New System.Drawing.Point(616, 392)
        Me.ViewPRBtn2.Name = "ViewPRBtn2"
        Me.ViewPRBtn2.Size = New System.Drawing.Size(64, 32)
        Me.ViewPRBtn2.TabIndex = 8
        Me.ViewPRBtn2.Text = "View PR"
        '
        'SendAprrovalBtn2
        '
        Me.SendAprrovalBtn2.AutoSize = False
        Me.SendAprrovalBtn2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SendAprrovalBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendAprrovalBtn2.Image = Nothing
        Me.SendAprrovalBtn2.Location = New System.Drawing.Point(376, 392)
        Me.SendAprrovalBtn2.Name = "SendAprrovalBtn2"
        Me.SendAprrovalBtn2.Size = New System.Drawing.Size(64, 32)
        Me.SendAprrovalBtn2.TabIndex = 6
        Me.SendAprrovalBtn2.Text = "Dispatch"
        '
        'DeleteBtn2
        '
        Me.DeleteBtn2.AutoSize = False
        Me.DeleteBtn2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn2.Image = Nothing
        Me.DeleteBtn2.Location = New System.Drawing.Point(304, 392)
        Me.DeleteBtn2.Name = "DeleteBtn2"
        Me.DeleteBtn2.Size = New System.Drawing.Size(64, 32)
        Me.DeleteBtn2.TabIndex = 5
        Me.DeleteBtn2.Text = "Delete PR"
        '
        'ModifyPRBtn2
        '
        Me.ModifyPRBtn2.AutoSize = False
        Me.ModifyPRBtn2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ModifyPRBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyPRBtn2.Image = Nothing
        Me.ModifyPRBtn2.Location = New System.Drawing.Point(224, 392)
        Me.ModifyPRBtn2.Name = "ModifyPRBtn2"
        Me.ModifyPRBtn2.Size = New System.Drawing.Size(72, 32)
        Me.ModifyPRBtn2.TabIndex = 3
        Me.ModifyPRBtn2.Text = "Edit PR"
        '
        'PRListGrid2
        '
        Me.PRListGrid2.EditorsRepository = Me.PersistentRepository1
        Me.PRListGrid2.Location = New System.Drawing.Point(8, 24)
        Me.PRListGrid2.MainView = Me.GridView3
        Me.PRListGrid2.Name = "PRListGrid2"
        Me.PRListGrid2.Size = New System.Drawing.Size(744, 344)
        Me.PRListGrid2.TabIndex = 2
        '
        'GridView3
        '
        Me.GridView3.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.VertScrollTipFieldName = Nothing
        '
        'RefreshBtn2
        '
        Me.RefreshBtn2.Location = New System.Drawing.Point(8, 368)
        Me.RefreshBtn2.Name = "RefreshBtn2"
        Me.RefreshBtn2.Size = New System.Drawing.Size(88, 24)
        Me.RefreshBtn2.TabIndex = 4
        Me.RefreshBtn2.Text = "Auto Refresh"
        Me.RefreshBtn2.Visible = False
        '
        'CreatePRBtn
        '
        Me.CreatePRBtn.AutoSize = False
        Me.CreatePRBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreatePRBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatePRBtn.Image = Nothing
        Me.CreatePRBtn.Location = New System.Drawing.Point(128, 392)
        Me.CreatePRBtn.Name = "CreatePRBtn"
        Me.CreatePRBtn.Size = New System.Drawing.Size(88, 32)
        Me.CreatePRBtn.TabIndex = 16
        Me.CreatePRBtn.Text = "Create New PR"
        '
        'btnRefresh1
        '
        Me.btnRefresh1.AutoSize = False
        Me.btnRefresh1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh1.Image = Nothing
        Me.btnRefresh1.Location = New System.Drawing.Point(48, 392)
        Me.btnRefresh1.Name = "btnRefresh1"
        Me.btnRefresh1.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh1.TabIndex = 27
        Me.btnRefresh1.Text = "Refresh"
        '
        'ApproveBtn2
        '
        Me.ApproveBtn2.AutoSize = False
        Me.ApproveBtn2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ApproveBtn2.Enabled = False
        Me.ApproveBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApproveBtn2.Image = Nothing
        Me.ApproveBtn2.Location = New System.Drawing.Point(328, 368)
        Me.ApproveBtn2.Name = "ApproveBtn2"
        Me.ApproveBtn2.Size = New System.Drawing.Size(72, 32)
        Me.ApproveBtn2.TabIndex = 7
        Me.ApproveBtn2.Text = "Approve PR"
        Me.ApproveBtn2.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 60000
        '
        'PRQuotationList
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 493)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(80, 80)
        Me.Name = "PRQuotationList"
        Me.Text = "Order Confirmation List"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.PRWithOCTab.ResumeLayout(False)
        Me.PRListGrp.ResumeLayout(False)
        CType(Me.PRListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuotationListGrp.ResumeLayout(False)
        CType(Me.QuotationListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRWO_OCTab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PRListGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region " Variable Initialization"

    Public PR_ID As Integer
    Public Quotation_ID As Integer
    Public QuotationNo As String
    Public dataQuotationGrid As System.Data.DataTable
    Public dataPRGrid As System.Data.DataTable
    Public dataPRGrid2 As System.Data.DataTable

    Public Status As Boolean

    Public TIMERINTERVAL As Integer = 60000

    Public CONFIRMEDSTATUS As Integer = 30
#End Region


#Region " Quotation List - PR with OC"

    'Call once form load, Initalize Quotation Columns
    Private Sub InitQuotationList()
        dataQuotationGrid = New DataTable("ColumnsTable")
        dataQuotationGrid.BeginInit()
        AddColumn(dataQuotationGrid, "QID", System.Type.GetType("System.Int16"), True)
        AddColumn(dataQuotationGrid, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(dataQuotationGrid, "Order Confirmation No", System.Type.GetType("System.String"), True)
        AddColumn(dataQuotationGrid, "Date", System.Type.GetType("System.String"), True)
        AddColumn(dataQuotationGrid, "StatusCode", System.Type.GetType("System.String"), True)
        AddColumn(dataQuotationGrid, "Status", System.Type.GetType("System.String"), True)
        AddColumn(dataQuotationGrid, "Project", System.Type.GetType("System.String"), True)
        AddColumn(dataQuotationGrid, "Customer Name", System.Type.GetType("System.String"), True)
        dataQuotationGrid.EndInit()
    End Sub

    'Call once form load
    Private Sub LoadQuotationList()

        InitQuotationList()
        LoadQuotationFrmDB()

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            QuotationClick()
        Else
            CreatePRQuotationBtn.Enabled = False
        End If
    End Sub

    'Call from LoadQuotationList
    Private Sub LoadQuotationFrmDB()
        Dim ds As DataSet
        Dim dsParent As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetOrderConfirmHeader(ds, , CONFIRMEDSTATUS) Then
                InitQuotationList()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentConfirmQuotationNo As String

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

                    dataQuotationGrid.Rows.Add(New Object() {oRow("Quotation_ID"), i, oRow("Confirm_Quotation_No"), ChangeDateFormat(oRow("QuotationDate")), oRow("Status"), Status, oRow("ProjectName"), oRow("CustomerName")})
                Next
                QuotationListGrid.DataSource = dataQuotationGrid
                QuotationListGrid.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                GridView1.Columns.Item(4).VisibleIndex = -1 'hide 4th. Status
            End If
        End With
    End Sub

#End Region

#Region " PR List - PR with OC"

    'Called when quotation grid is click, retrieve related PR list
    Private Sub LoadPR()
        If GridView1.SelectedRowsCount <> 0 Then

            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

            Dim items As Object() = dr.ItemArray

            Quotation_ID = items(0)

            ClearGrid(GridView2)
            LoadPRList()
        End If
    End Sub

    'Start to load PR list
    Private Sub LoadPRList()
        If Quotation_ID <> Nothing And Quotation_ID <> 0 Then
            LoadPRFrmDB()

            If GridView2.RowCount() <> 0 Then
                GridView2.MoveFirst()
                PRClick()
                PrintPRBtn.Enabled = True
            Else
                ModifyPRBtn.Enabled = False
                DeleteBtn.Enabled = False
                SendAprrovalBtn.Enabled = False
                ApproveBtn.Enabled = False
                PrintPRBtn.Enabled = False
                ViewPRBtn.Enabled = False
            End If

        End If
    End Sub

    'Add record from db to grid
    Private Sub LoadPRFrmDB()

        Dim ds As DataSet

        Dim Requester
        Dim Approver
        Dim Category
        Dim Status
        Dim Grp
        Dim PR_Date

        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, , Quotation_ID) Then
                InitPRList()
                If Not ds Is Nothing Then
                    Try
                        'QuotationListGrid.DataSource = ds
                        'QuotationListGrid.DataMember = ds.Tables.Item(0).ToString

                        'QuotationListGrid.DefaultView.PopulateColumns()
                        'GridView1.BestFitColumns()

                        'GridView1.Columns.Item(0).VisibleIndex = -1


                        Dim oRow As DataRow
                        Dim i As Integer = 0
                        Dim tempPR_Date As String = ""

                        For Each oRow In ds.Tables(0).Rows
                            i = i + 1

                            tempPR_Date = ChangeDateFormat(oRow("Create_Date"))
                            dataPRGrid.Rows.Add(New Object() {oRow("PR_ID"), oRow("PR_No"), oRow("RequesterName"), oRow("ApproverName"), oRow("CategoryName"), oRow("Status"), oRow("StatusName"), oRow("GrpName"), tempPR_Date})
                        Next

                        PRListGrid.DataSource = dataPRGrid
                        PRListGrid.DefaultView.PopulateColumns()
                        GridView2.BestFitColumns()
                        GridView2.Columns.Item(0).VisibleIndex = -1 'hide 1st column
                        GridView2.Columns.Item(4).VisibleIndex = -1 'hide 1st column
                        GridView2.Columns.Item(5).VisibleIndex = -1 'hide 1st column

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try

                End If
            End If
        End With
    End Sub

    'Initalize PR Columns
    Private Sub InitPRList()

        dataPRGrid = New DataTable("ColumnsTable")

        dataPRGrid.BeginInit()
        AddColumn(dataPRGrid, "PR_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRGrid, "PR No.", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Requester", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Approver", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Category", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "StatusID", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Status", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Grp", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "PR Date", System.Type.GetType("System.String"), True)

        dataPRGrid.EndInit()

    End Sub

#End Region

#Region " Event  - PR with OC"

    'Form Load
    Private Sub PRQuotationList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        Status = True

        Tab1Click()
        TabControl1.IDEPixelBorder = True
    End Sub

    Private Sub QuotationListGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QuotationListGrid.KeyUp
        QuotationClick()
    End Sub

    Private Sub QuotationListGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuotationListGrid.Click
        QuotationClick()
    End Sub

    Private Sub PRListGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PRListGrid.KeyUp
        PRClick()
    End Sub

    Private Sub PRListGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PRListGrid.Click
        PRClick()
    End Sub

    Private Sub CreatePRQuotationBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePRQuotationBtn.Click
        If GridView1.SelectedRowsCount <> 0 Then

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor
            Dim page As Crownwood.Magic.Controls.TabPage

            controlToAdd = New PRForm("NEW", , Quotation_ID, QuotationNo)
            page = New Crownwood.Magic.Controls.TabPage("Generate PR", controlToAdd, ImageList1, 0)

            page.Selected = True

            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default


            'Dim form As New PRForm("NEW", , Quotation_ID, QuotationNo)

            'form.ShowDialog()
            'form.Dispose()

            'Reload PR list
            'ClearGrid(GridView2)
            'LoadPRList()

        End If
    End Sub

    Private Sub CreatePRBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePRBtn.Click
        'If GridView1.SelectedRowsCount <> 0 Then

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        Dim Department_ID As Integer

        Dim form As New SelectDepartmentForm
        If form.ShowDialog(Me) = DialogResult.OK Then
            Department_ID = form.Department_ID

            controlToAdd = New PRForm("NEW", , , , Department_ID)
            page = New Crownwood.Magic.Controls.TabPage("Generate PR", controlToAdd, ImageList1, 0)

            page.Selected = True

            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default


            'Dim form As New PRForm("NEW", , Quotation_ID, QuotationNo)

            'form.ShowDialog()
            'form.Dispose()

            'Reload PR list
            'ClearGrid(GridView2)
            'LoadPRList()

            'End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    'Modify PR button
    Private Sub ModifyPRBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyPRBtn.Click

        If GridView2.SelectedRowsCount <> 0 Then
            ModifyPR()
        End If

    End Sub

    'Delete PR button
    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click

        If GridView2.SelectedRowsCount > 0 Then
            DeletePR()
        End If

    End Sub

    Private Sub SendAprrovalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendAprrovalBtn.Click
        If GridView2.SelectedRowsCount > 0 Then
            SendApproval()
        End If
    End Sub

    Private Sub ApproveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApproveBtn.Click
        If GridView2.SelectedRowsCount <> 0 Then
            ApprovePR()
        End If
    End Sub

    Private Sub ViewPRBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPRBtn.Click
        If GridView2.SelectedRowsCount <> 0 Then
            ViewPR()
        End If
    End Sub

    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        If RefreshBtn.Checked = True Then
            'Timer1.Interval = TIMERINTERVAL
            'Timer1.Start()
        Else
            'Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadQuotationList()
    End Sub

    Private Sub TabControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
        If TabControl1.SelectedIndex = 1 Then
            Tab2Click()
        Else
            Tab1Click()
        End If
    End Sub

#End Region

#Region " Other Code "
    'Change date format
    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then

            If pInputDate.ToString <> "" Then
                pDate = Date.Parse(pInputDate)
                tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
            End If

        End If

        Return tempsDate

    End Function

    'Called when quotation grid is click - Initalize PR Grid
    Private Sub QuotationClick()
        If GridView1.SelectedRowsCount <> 0 Then

            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then

                Me.Cursor = Cursors.WaitCursor
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                Quotation_ID = items(0)
                QuotationNo = items(2)

                ClearGrid(GridView2)
                LoadPRList()

                If CheckQuotationComplete(Quotation_ID) Then
                    CreatePRQuotationBtn.Enabled = False
                Else
                    CreatePRQuotationBtn.Enabled = True
                End If

                Me.Cursor = Cursors.Default
            Else
                Quotation_ID = Nothing
                ClearGrid(GridView2)
            End If
        Else
            Quotation_ID = Nothing
            ClearGrid(GridView2)
        End If
    End Sub

    'Called when PR grid is click - Check status to display required buttons
    Private Sub PRClick()
        DisableAllBtn()

        If GridView2.SelectedRowsCount > 0 Then
            Dim dr As DataRow
            Dim items As Object()
            Dim Status

            If GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) = False Then
                dr = GridView2.GetDataRow(GridView2.GetSelectedRows(0))

                items = dr.ItemArray
                Status = items(5).ToString
                PR_ID = items(0)

                If Status = "10" Then
                    ModifyPRBtn.Enabled = True
                    DeleteBtn.Enabled = True
                    SendAprrovalBtn.Enabled = True
                ElseIf Status = "30" Then
                    ApproveBtn.Enabled = True
                ElseIf Status = "40" Then
                    ReserveStockBtn.Enabled = True
                End If

                PrintPRBtn.Enabled = True
                ViewPRBtn.Enabled = True
            Else
                PrintPRBtn.Enabled = False
                PR_ID = Nothing
            End If
        Else
            PrintPRBtn.Enabled = False
            PR_ID = Nothing
        End If
    End Sub


    Private Sub DisableAllBtn()
        ModifyPRBtn.Enabled = False
        DeleteBtn.Enabled = False
        SendAprrovalBtn.Enabled = False
        ApproveBtn.Enabled = False
        ReserveStockBtn.Enabled = False
        PrintPRBtn.Enabled = False
        ViewPRBtn.Enabled = False
    End Sub

    'Called when delete PR
    Private Sub DeletePR()
        If MessageBox.Show("Are you sure you want to remove PR?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If PR_ID <> Nothing And PR_ID <> 0 Then
                With New BusinessRules.PRBusRules.PRHeaderBusLogic
                    .Delete(PR_ID)
                End With

            End If

            'ClearGrid(GridView1)
            If Status Then
                LoadQuotationList()
            Else
                LoadPRList2()
            End If
        End If
    End Sub

    'Called when send PR for approval
    Private Sub SendApproval()
        If MessageBox.Show("Are you sure you want to send PR for approval?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If PR_ID <> Nothing And PR_ID <> 0 Then
                With New BusinessRules.PRBusRules.PRHeaderBusLogic
                    .SendPRForApproval(PR_ID)
                End With

                If Status Then
                    QuotationClick()
                Else
                    LoadPRList2()
                End If
            End If
        End If
    End Sub

    'Check if current quotation is complete, if yes disable "Create New PR" button
    Private Function CheckQuotationComplete(ByVal pQuotation_ID As Integer) As Boolean
        Dim check As Boolean
        check = True

        If pQuotation_ID <> Nothing And pQuotation_ID <> 0 Then
            Dim ds As DataSet
            Dim countRequestQty As Integer

            With New BusinessRules.PRBusRules.PRBusLogic
                If .LoadQuotationComponent(ds, pQuotation_ID) Then
                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1
                        countRequestQty = 0

                        ' 22.10.2003 YG Start
                        '                        If Not oRow("Qty") Is System.DBNull.Value And Not oRow("Component_ID") Is System.DBNull.Value Then
                        '                            countRequestQty = oRow("Qty") - .CountTotalOrderQty(oRow("Component_ID"))
                        '                        End If
                        ' 22.10.2003 YG End
                        If Not oRow("OrderQty") Is System.DBNull.Value And Not oRow("Component_ID") Is System.DBNull.Value Then
                            countRequestQty = oRow("OrderQty") - .CountTotalOrderQty(oRow("Component_ID"))
                        End If

                        If countRequestQty <> 0 Then
                            check = False
                            Exit For
                        End If
                    Next
                End If
            End With
        End If

        Return check
    End Function

    Private Sub ModifyPR()

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        controlToAdd = New PRForm("MODIFY", PR_ID, Quotation_ID, QuotationNo)
        page = New Crownwood.Magic.Controls.TabPage("Generate PR", controlToAdd, ImageList1, 0)

        page.Selected = True

        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

        'Dim form As New PRForm("MODIFY", PR_ID, Quotation_ID, QuotationNo)

        'form.ShowDialog()

        'Reload Quotation list
        'ClearGrid(GridView1)
        'LoadQuotationList()

    End Sub

    Private Sub ApprovePR()
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        controlToAdd = New PRForm("APPROVEPR", PR_ID, Quotation_ID, QuotationNo)
        page = New Crownwood.Magic.Controls.TabPage("Approve PR", controlToAdd, ImageList1, 0)

        page.Selected = True

        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

        'Dim form As New PRForm("APPROVEPR", PR_ID, Quotation_ID, QuotationNo)


        'form.ShowDialog()

        'Reload PR list
        'ClearGrid(GridView2)
        'LoadPRList()
    End Sub

    Private Sub ReserveStock()
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        controlToAdd = New PRForm("RESERVESTOCK", PR_ID, Quotation_ID, QuotationNo)
        page = New Crownwood.Magic.Controls.TabPage("Modify Reserved Stock", controlToAdd, ImageList1, 0)

        page.Selected = True

        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintPR()
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New PRReportForm(PR_ID)
        page = New Crownwood.Magic.Controls.TabPage("PR Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ViewPR()

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        controlToAdd = New PRForm("VIEW", PR_ID, Quotation_ID, QuotationNo)
        page = New Crownwood.Magic.Controls.TabPage("View PR", controlToAdd, ImageList1, 0)

        page.Selected = True

        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

        'Dim form As New PRForm("VIEW")

        'form.PR_ID = PR_ID
        'form.Quotation_ID = Quotation_ID
        'form.Quotation_NO = QuotationNo
        'form.ShowDialog()

    End Sub

    Private Sub ClosePR()

        'Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PR?", "Close PR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If Result = DialogResult.Yes Then
        'Me.Close()
        Me.Close()
        'End If
    End Sub

    Private Sub Tab1Click()

        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GridView1)
        LoadQuotationList()

        RefreshBtn.Checked = True

        'Timer1.Interval = TIMERINTERVAL
        'Timer1.Start()

        'Timer2.Stop()

        Me.Cursor = Cursors.Default

        Status = True

    End Sub

    Private Sub Tab2Click()

        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GridView3)
        RefreshBtn2.Checked = True
        LoadPRList2()
        'Timer2.Interval = TIMERINTERVAL
        'Timer2.Start()
        'Timer1.Stop()

        Me.Cursor = Cursors.Default

        Status = False

    End Sub
#End Region

#Region " Grid Code "

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub

    Private Sub ClearGrid(ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim i

        If GridView.RowCount() <> 0 Then
            GridView.FocusedRowHandle = 0
            For i = 0 To GridView.RowCount() - 1
                GridView.DeleteRow(GridView.GetSelectedRows(0))
                If GridView.RowCount() <> 0 Then
                    GridView.FocusedRowHandle = 0
                End If
            Next
        End If
    End Sub

#End Region


#Region " PR Without OC - 2nd tab page"

    'Start to load PR list
    Private Sub LoadPRList2()

        ClearGrid(GridView3)
        LoadPRFrmDB2()

        If GridView3.RowCount() <> 0 Then
            GridView3.MoveFirst()
            PRClick2()
            PrintPR2.Enabled = True
        Else
            ModifyPRBtn2.Enabled = False
            DeleteBtn2.Enabled = False
            SendAprrovalBtn2.Enabled = False
            ApproveBtn2.Enabled = False
            ReserveStockBtn2.Enabled = False
            PrintPR2.Enabled = False
            ViewPRBtn2.Enabled = False
        End If

    End Sub

    'Add record from db to grid
    Private Sub LoadPRFrmDB2()

        Dim ds As DataSet

        Dim Requester
        Dim Approver
        Dim Category
        Dim Status
        Dim Grp
        Dim PR_Date

        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, , , , True) Then
                InitPRList2()
                If Not ds Is Nothing Then
                    Try
                        'QuotationListGrid.DataSource = ds
                        'QuotationListGrid.DataMember = ds.Tables.Item(0).ToString

                        'QuotationListGrid.DefaultView.PopulateColumns()
                        'GridView1.BestFitColumns()

                        'GridView1.Columns.Item(0).VisibleIndex = -1


                        Dim oRow As DataRow
                        Dim i As Integer = 0
                        Dim tempPR_Date As String = ""

                        For Each oRow In ds.Tables(0).Rows
                            i = i + 1

                            tempPR_Date = ChangeDateFormat(oRow("Create_Date"))
                            dataPRGrid2.Rows.Add(New Object() {oRow("PR_ID"), oRow("PR_No"), oRow("RequesterName"), oRow("ApproverName"), oRow("CategoryName"), oRow("Status"), oRow("StatusName"), oRow("GrpName"), tempPR_Date})
                        Next

                        PRListGrid2.DataSource = dataPRGrid2
                        PRListGrid2.DefaultView.PopulateColumns()
                        GridView3.BestFitColumns()
                        GridView3.Columns.Item(0).VisibleIndex = -1 'hide 1st column
                        GridView3.Columns.Item(4).VisibleIndex = -1 'hide 1st column
                        GridView3.Columns.Item(5).VisibleIndex = -1 'hide 1st column

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try

                End If
            End If
        End With
    End Sub

    'Initalize PR Columns
    Private Sub InitPRList2()

        dataPRGrid2 = New DataTable("ColumnsTable")

        dataPRGrid2.BeginInit()
        AddColumn(dataPRGrid2, "PR_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRGrid2, "PR No.", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "Requester", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "Approver", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "Category", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "StatusID", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "Status", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "Grp", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "PR_Date", System.Type.GetType("System.String"), True)

        dataPRGrid2.EndInit()

    End Sub

    'Called when PR grid is click - Check status to display required buttons
    Private Sub PRClick2()
        DisableAllBtn2()

        If GridView3.SelectedRowsCount > 0 Then
            Dim dr As DataRow
            Dim items As Object()
            Dim Status

            If GridView3.IsGroupRow(GridView3.GetSelectedRows(0)) = False Then
                dr = GridView3.GetDataRow(GridView3.GetSelectedRows(0))

                items = dr.ItemArray
                Status = items(5).ToString
                PR_ID = items(0)

                If Status = "10" Then
                    ModifyPRBtn2.Enabled = True
                    DeleteBtn2.Enabled = True
                    SendAprrovalBtn2.Enabled = True
                ElseIf Status = "30" Then
                    ApproveBtn2.Enabled = True
                ElseIf Status = "40" Then
                    ReserveStockBtn2.Enabled = True
                End If

                ' 08.11.2003 YG
                PrintPR2.Enabled = True
                ViewPRBtn2.Enabled = True

                Quotation_ID = Nothing
                QuotationNo = ""
            Else
                ' 08.11.2003 YG
                PrintPR2.Enabled = False
                PR_ID = Nothing
            End If
        Else
            ' 08.11.2003 YG
            PrintPR2.Enabled = False
            PR_ID = Nothing
        End If
    End Sub

    Private Sub DisableAllBtn2()
        ModifyPRBtn2.Enabled = False
        DeleteBtn2.Enabled = False
        SendAprrovalBtn2.Enabled = False
        ApproveBtn2.Enabled = False
        ReserveStockBtn2.Enabled = False
        PrintPR2.Enabled = False
        ViewPRBtn2.Enabled = False
    End Sub

#Region " Event "

    Private Sub PRListGrid2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRListGrid2.Click
        PRClick2()
    End Sub

    Private Sub PRListGrid2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PRListGrid2.KeyUp
        PRClick2()
    End Sub

    Private Sub ModifyPRBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyPRBtn2.Click

        If GridView3.SelectedRowsCount <> 0 Then
            ModifyPR()
        End If

    End Sub

    Private Sub DeleteBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn2.Click

        If GridView3.SelectedRowsCount > 0 Then
            DeletePR()
        End If

    End Sub

    Private Sub SendAprrovalBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendAprrovalBtn2.Click

        If GridView3.SelectedRowsCount > 0 Then
            SendApproval()
        End If

    End Sub

    Private Sub ApproveBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApproveBtn2.Click

        If GridView3.SelectedRowsCount <> 0 Then
            ApprovePR()
        End If

    End Sub

    Private Sub ViewPRBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPRBtn2.Click

        If GridView3.SelectedRowsCount <> 0 Then
            ViewPR()
        End If

    End Sub

    Private Sub RefreshBtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn2.CheckedChanged
        If RefreshBtn2.Checked = True Then
            'Timer2.Interval = TIMERINTERVAL
            'Timer2.Start()
        Else
            'Timer2.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        LoadPRList2()
    End Sub

#End Region

#End Region


    Private Sub PrintDOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPRBtn.Click
        PrintPR()
    End Sub

    Private Sub PrintPR2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPR2.Click
        PrintPR()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        ClosePR()
    End Sub

    Private Sub CloseBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn2.Click
        ClosePR()
    End Sub

    Private Sub ReserveStockBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReserveStockBtn.Click
        If GridView2.SelectedRowsCount <> 0 Then
            ReserveStock()
        End If
    End Sub

    Private Sub ReserveStockBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReserveStockBtn2.Click
        If GridView3.SelectedRowsCount <> 0 Then
            ReserveStock()
        End If
    End Sub
    'added by alan on 21 Oct 
    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Quotation_ID As Integer = dr(0)
            Dim Status As String = dr(4)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            If Status = "30" Then       'COnfirmed. View only
                controlToAdd = New OrderConfirmationForm("VIEW", , , Quotation_ID)
                page = New Crownwood.Magic.Controls.TabPage("View Order Confirmation", controlToAdd, ImageList1, 0)
            Else
                controlToAdd = New OrderConfirmationForm("EDIT", , , Quotation_ID)
                page = New Crownwood.Magic.Controls.TabPage("Edit Order Confirmation", controlToAdd, ImageList1, 0)
            End If
            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadQuotationList()
    End Sub

    Private Sub btnRefresh1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh1.Click
        LoadPRList2()
    End Sub

    Private Sub PRQuotationList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectionChanged

    End Sub
End Class

