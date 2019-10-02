Public Class POForm
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
    Friend WithEvents GeneratePOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RemoveAllBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AddAllBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PRGrid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RemoveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AddBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PRGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TemplateCtr As Crownwood.Magic.Controls.TabControl
    Friend WithEvents TabPage1 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents SupplierGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents TabPage2 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents PRItemGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RemoveSupBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AddInfoBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusLookUp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PODateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CreaterTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PONo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents POTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GST_CheckBox As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(POForm))
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GeneratePOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RemoveAllBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddAllBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRGrid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RemoveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.POTitle = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.PONo = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CreaterTxt = New DevExpress.XtraEditors.TextEdit
        Me.PODateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.StatusLookUp = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrpLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TemplateCtr = New Crownwood.Magic.Controls.TabControl
        Me.TabPage1 = New Crownwood.Magic.Controls.TabPage
        Me.GST_CheckBox = New System.Windows.Forms.CheckBox
        Me.RemoveSupBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SupplierGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AddInfoBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.TabPage2 = New Crownwood.Magic.Controls.TabPage
        Me.PRItemGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PRGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PONo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreaterTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TemplateCtr.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SupplierGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PRItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit4})
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit3.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        Me.RepositoryItemTextEdit4.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit4.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GeneratePOBtn
        '
        Me.GeneratePOBtn.AutoSize = False
        Me.GeneratePOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.GeneratePOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratePOBtn.Image = Nothing
        Me.GeneratePOBtn.Location = New System.Drawing.Point(16, 440)
        Me.GeneratePOBtn.Name = "GeneratePOBtn"
        Me.GeneratePOBtn.Size = New System.Drawing.Size(88, 32)
        Me.GeneratePOBtn.TabIndex = 26
        Me.GeneratePOBtn.Text = "Generate PO"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(576, 440)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 27
        Me.CloseBtn.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.POTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PONo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CreaterTxt)
        Me.GroupBox1.Controls.Add(Me.PODateEdit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.StatusLookUp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GrpLookup)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TemplateCtr)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 424)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemoveAllBtn)
        Me.GroupBox2.Controls.Add(Me.AddAllBtn)
        Me.GroupBox2.Controls.Add(Me.PRGrid2)
        Me.GroupBox2.Controls.Add(Me.RemoveBtn)
        Me.GroupBox2.Controls.Add(Me.AddBtn)
        Me.GroupBox2.Controls.Add(Me.PRGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 208)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outstanding PR List"
        '
        'RemoveAllBtn
        '
        Me.RemoveAllBtn.AutoSize = False
        Me.RemoveAllBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RemoveAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveAllBtn.Image = Nothing
        Me.RemoveAllBtn.Location = New System.Drawing.Point(264, 64)
        Me.RemoveAllBtn.Name = "RemoveAllBtn"
        Me.RemoveAllBtn.Size = New System.Drawing.Size(88, 32)
        Me.RemoveAllBtn.TabIndex = 47
        Me.RemoveAllBtn.Text = "<< Remove All"
        '
        'AddAllBtn
        '
        Me.AddAllBtn.AutoSize = False
        Me.AddAllBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAllBtn.Image = Nothing
        Me.AddAllBtn.Location = New System.Drawing.Point(264, 24)
        Me.AddAllBtn.Name = "AddAllBtn"
        Me.AddAllBtn.Size = New System.Drawing.Size(88, 32)
        Me.AddAllBtn.TabIndex = 46
        Me.AddAllBtn.Text = "Add All >>"
        '
        'PRGrid2
        '
        Me.PRGrid2.EditorsRepository = Me.PersistentRepository1
        Me.PRGrid2.Location = New System.Drawing.Point(360, 24)
        Me.PRGrid2.MainView = Me.GridView2
        Me.PRGrid2.Name = "PRGrid2"
        Me.PRGrid2.Size = New System.Drawing.Size(256, 176)
        Me.PRGrid2.TabIndex = 42
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'RemoveBtn
        '
        Me.RemoveBtn.AutoSize = False
        Me.RemoveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RemoveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBtn.Image = Nothing
        Me.RemoveBtn.Location = New System.Drawing.Point(264, 144)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(88, 32)
        Me.RemoveBtn.TabIndex = 44
        Me.RemoveBtn.Text = "<< Remove"
        '
        'AddBtn
        '
        Me.AddBtn.AutoSize = False
        Me.AddBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Image = Nothing
        Me.AddBtn.Location = New System.Drawing.Point(264, 104)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(88, 32)
        Me.AddBtn.TabIndex = 43
        Me.AddBtn.Text = "Add >>"
        '
        'PRGrid
        '
        Me.PRGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRGrid.Location = New System.Drawing.Point(8, 24)
        Me.PRGrid.MainView = Me.GridView1
        Me.PRGrid.Name = "PRGrid"
        Me.PRGrid.Size = New System.Drawing.Size(248, 176)
        Me.PRGrid.TabIndex = 41
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit3
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'POTitle
        '
        Me.POTitle.Location = New System.Drawing.Point(120, 144)
        Me.POTitle.Name = "POTitle"
        Me.POTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.POTitle.Properties.ReadOnly = True
        Me.POTitle.Size = New System.Drawing.Size(248, 21)
        Me.POTitle.TabIndex = 86
        Me.POTitle.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Title:"
        Me.Label4.Visible = False
        '
        'PONo
        '
        Me.PONo.Location = New System.Drawing.Point(120, 96)
        Me.PONo.Name = "PONo"
        Me.PONo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PONo.Size = New System.Drawing.Size(120, 21)
        Me.PONo.TabIndex = 84
        Me.PONo.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "PO No:"
        Me.Label3.Visible = False
        '
        'CreaterTxt
        '
        Me.CreaterTxt.Enabled = False
        Me.CreaterTxt.Location = New System.Drawing.Point(464, 64)
        Me.CreaterTxt.Name = "CreaterTxt"
        Me.CreaterTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CreaterTxt.Properties.Enabled = False
        Me.CreaterTxt.Size = New System.Drawing.Size(152, 19)
        Me.CreaterTxt.TabIndex = 82
        '
        'PODateEdit
        '
        Me.PODateEdit.DateTime = New Date(CType(0, Long))
        Me.PODateEdit.Location = New System.Drawing.Point(464, 16)
        Me.PODateEdit.Name = "PODateEdit"
        Me.PODateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PODateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PODateEdit.Properties.Enabled = False
        Me.PODateEdit.Properties.Format = Nothing
        Me.PODateEdit.Properties.FormatString = "dd/MM/yyyy"
        Me.PODateEdit.Size = New System.Drawing.Size(112, 19)
        Me.PODateEdit.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(368, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "PO Date :"
        '
        'StatusLookUp
        '
        Me.StatusLookUp.Location = New System.Drawing.Point(464, 40)
        Me.StatusLookUp.Name = "StatusLookUp"
        Me.StatusLookUp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusLookUp.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusLookUp.Properties.Enabled = False
        Me.StatusLookUp.Properties.NullString = ""
        Me.StatusLookUp.Properties.PopupWidth = 168
        Me.StatusLookUp.Size = New System.Drawing.Size(112, 19)
        Me.StatusLookUp.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(376, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Status :"
        '
        'GrpLookup
        '
        Me.GrpLookup.Location = New System.Drawing.Point(120, 120)
        Me.GrpLookup.Name = "GrpLookup"
        Me.GrpLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GrpLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.GrpLookup.Properties.NullString = ""
        Me.GrpLookup.Properties.PopupWidth = 168
        Me.GrpLookup.Size = New System.Drawing.Size(120, 21)
        Me.GrpLookup.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Group :"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(376, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Recorded By :"
        '
        'TemplateCtr
        '
        Me.TemplateCtr.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.TemplateCtr.IDEPixelArea = True
        Me.TemplateCtr.IDEPixelBorder = False
        Me.TemplateCtr.Location = New System.Drawing.Point(8, 232)
        Me.TemplateCtr.Name = "TemplateCtr"
        Me.TemplateCtr.SelectedIndex = 0
        Me.TemplateCtr.SelectedTab = Me.TabPage1
        Me.TemplateCtr.ShowArrows = False
        Me.TemplateCtr.ShowClose = False
        Me.TemplateCtr.Size = New System.Drawing.Size(624, 184)
        Me.TemplateCtr.TabIndex = 46
        Me.TemplateCtr.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.TabPage1, Me.TabPage2})
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GST_CheckBox)
        Me.TabPage1.Controls.Add(Me.RemoveSupBtn)
        Me.TabPage1.Controls.Add(Me.SupplierGrid)
        Me.TabPage1.Controls.Add(Me.AddInfoBtn)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.TabPage1.Location = New System.Drawing.Point(0, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(624, 159)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Title = "Supplier List"
        '
        'GST_CheckBox
        '
        Me.GST_CheckBox.Checked = True
        Me.GST_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GST_CheckBox.Location = New System.Drawing.Point(512, 8)
        Me.GST_CheckBox.Name = "GST_CheckBox"
        Me.GST_CheckBox.Size = New System.Drawing.Size(56, 24)
        Me.GST_CheckBox.TabIndex = 53
        Me.GST_CheckBox.Text = "GST"
        '
        'RemoveSupBtn
        '
        Me.RemoveSupBtn.AutoSize = False
        Me.RemoveSupBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RemoveSupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSupBtn.Image = Nothing
        Me.RemoveSupBtn.Location = New System.Drawing.Point(512, 120)
        Me.RemoveSupBtn.Name = "RemoveSupBtn"
        Me.RemoveSupBtn.Size = New System.Drawing.Size(96, 32)
        Me.RemoveSupBtn.TabIndex = 51
        Me.RemoveSupBtn.Text = "Remove from list"
        '
        'SupplierGrid
        '
        Me.SupplierGrid.EditorsRepository = Me.PersistentRepository1
        Me.SupplierGrid.Location = New System.Drawing.Point(8, 8)
        Me.SupplierGrid.MainView = Me.GridView3
        Me.SupplierGrid.Name = "SupplierGrid"
        Me.SupplierGrid.Size = New System.Drawing.Size(488, 144)
        Me.SupplierGrid.TabIndex = 49
        '
        'GridView3
        '
        Me.GridView3.DefaultEdit = Me.RepositoryItemTextEdit4
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.PreviewLineCount = 2
        Me.GridView3.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'AddInfoBtn
        '
        Me.AddInfoBtn.AutoSize = False
        Me.AddInfoBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddInfoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddInfoBtn.Image = Nothing
        Me.AddInfoBtn.Location = New System.Drawing.Point(512, 32)
        Me.AddInfoBtn.Name = "AddInfoBtn"
        Me.AddInfoBtn.Size = New System.Drawing.Size(88, 32)
        Me.AddInfoBtn.TabIndex = 52
        Me.AddInfoBtn.Text = "Add PO Info"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PRItemGrid)
        Me.TabPage2.Location = New System.Drawing.Point(0, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Selected = False
        Me.TabPage2.Size = New System.Drawing.Size(624, 159)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Title = "Item List"
        Me.TabPage2.Visible = False
        '
        'PRItemGrid
        '
        Me.PRItemGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRItemGrid.Location = New System.Drawing.Point(8, 8)
        Me.PRItemGrid.MainView = Me.GridView4
        Me.PRItemGrid.Name = "PRItemGrid"
        Me.PRItemGrid.Size = New System.Drawing.Size(608, 128)
        Me.PRItemGrid.TabIndex = 50
        '
        'GridView4
        '
        Me.GridView4.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.PreviewLineCount = 2
        Me.GridView4.VertScrollTipFieldName = Nothing
        Me.GridView4.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'POForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(656, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GeneratePOBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Location = New System.Drawing.Point(80, 80)
        Me.Name = "POForm"
        Me.Text = "Purchase Order"
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PRGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PONo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreaterTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TemplateCtr.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SupplierGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PRItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public PO_ID As Integer
    Public PO_NO As String
    Public Shipment_Date As String
    Public Status As String
    Public Grp As String

    Public UserID As String = Common.CommonConn.Config.USERID
    Public UserName As String
    Public UserGrp As String
    Public UserInitial As String

    Dim dataPRGrid = New DataTable("ColumnsTable")
    Dim dataPRGrid2 = New DataTable("ColumnsTable")
    Dim dataPRItemGrid = New DataTable("ColumnsTable")
    Dim dataSupplierGrid = New DataTable("ColumnsTable")

    Dim poRecords As New ArrayList

    Public FormStatus As String

    Public PRStatus As String = "30"
    Public CheckApproval As Boolean


#End Region

#Region " Events "

    'Load form
    Private Sub POForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow
        GridView2.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow
        GridView3.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        GetUserGrpInitial()
        Me.GetUserInitial()

        LoadGrp()
        LoadStatus()

        InitPRList()
        InitSupplierList()
        InitPRItemList()

        LoadPRFrmDB()
        CheckBtn()

        SetWindowsValue()

    End Sub

    'Add button
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ButtonClick(GridView1, dataPRGrid2, True)

        LoadSupplier()
        'GetPORecord()

        CheckBtn()
    End Sub

    'Remove button
    Private Sub RemoveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBtn.Click
        ButtonClick(GridView2, dataPRGrid, False)

        LoadSupplier()

        RemovePORecord()

        'GetPORecord()
        CheckBtn()
    End Sub

    'Add All PR button
    Private Sub AddAllBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAllBtn.Click
        Dim i

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
        End If

        For i = 0 To GridView1.RowCount - 1
            ButtonClick(GridView1, dataPRGrid2, True)
        Next

        LoadSupplier()

        'GetPORecord()
        CheckBtn()
    End Sub

    'Remove All PR button
    Private Sub RemoveAllBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAllBtn.Click
        Dim i

        If GridView2.RowCount() <> 0 Then
            GridView2.MoveFirst()
        End If

        For i = 0 To GridView2.RowCount - 1
            ButtonClick(GridView2, dataPRGrid, True)
        Next

        ClearGrid(GridView3)
        ClearGrid(GridView4)

        poRecords.Clear()
        'GetPORecord()
        CheckBtn()

    End Sub

    'Remove Supplier button
    Private Sub RemoveSupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSupBtn.Click

        If GridView3.SelectedRowsCount <> 0 Then

            If GridView3.RowCount > 1 Then
                Dim index As Integer
                Dim dr As DataRow
                Dim SupplierID As Integer

                index = GridView3.GetSelectedRows(0)
                dr = GridView3.GetDataRow(index)

                Dim items As Object() = dr.ItemArray

                SupplierID = items(0)

                RemovePRLine(, SupplierID)

                GridView3.DeleteRow(index)

                Dim found As Boolean

                index = GetRecordIndex(SupplierID, found)
                If found Then
                    poRecords.RemoveAt(index)
                End If

            End If

        End If

        'GetPORecord()
    End Sub

    'Generate PO button
    Private Sub GeneratePOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePOBtn.Click

        Dim PONOAssigned As String
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to generate PO?", "PO", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)

        If Result = DialogResult.No Then
            Exit Sub
        End If

        'SavePO(Supplier_ID)
        GetWindowsValue()

        If ValidData() Then

            Dim Supplier_ID As Integer
            Dim i As Integer
            Dim dr As DataRow
            Dim item As Object
            Dim msg As String

            ' 24.10.2003 YG Start
            '            If GridView3.RowCount <> 0 Then
            '                For i = 0 To GridView3.RowCount - 1
            '                    dr = GridView3.GetDataRow(i)
            '
            '                    item = dr.ItemArray
            '                    Supplier_ID = item(0)
            '
            '                    SavePO(Supplier_ID)
            '
            '                    msg = msg & Chr(13) & "     " & PO_NO
            '                Next
            '        End If

            If GridView3.RowCount <> 0 Then
                If GridView3.SelectedRowsCount > 0 Then
                    Dim Row As Integer = GridView3.GetSelectedRows(0)
                    dr = GridView3.GetDataRow(Row)
                    item = dr.ItemArray
                    Supplier_ID = item(0)

                    PONOAssigned = GetPONO(Supplier_ID) ' temp manual PONO assignment

                    SavePO(Supplier_ID, PONOAssigned)
                    msg = msg & Chr(13) & "     " & PO_NO
                    MessageBox.Show("Following POs had been generate : " & msg, "PO Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowPOViewForm(PO_ID)
                Else
                    MessageBox.Show("Please select the Suppliers to generate the PO for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            LoadSupplier()

            If GridView3.RowCount = 0 Then
                ClearGrid(GridView2)
                ClearGrid(GridView4)
                DisabledAll()
            End If
            If GridView1.RowCount = 0 And GridView2.RowCount = 0 And GridView3.RowCount = 0 And GridView4.RowCount = 0 Then
                LoadPRFrmDB()

                If GridView1.RowCount <> 0 Then
                    CheckBtn()
                    SetWindowsValue()
                Else
                    DisabledAll()
                End If
            End If
            ' 24.10.2003 YG end


            ' 24.10.2003 YG Comment Out
            '            DisabledAll()
        End If
    End Sub

    Function GetPONO(ByVal pSupplierID) As String
        Dim f As EnterPO_No
        f = New EnterPO_No(pSupplierID)
        f.ShowDialog()
        GetPONO = f.PO_NO
    End Function

    Private Sub ShowPOViewForm(ByVal pPO_ID As Integer)

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        'controlToAdd = New POViewForm("VIEW", pPO_ID)
        controlToAdd = New POList2(pPO_ID)
        page = New Crownwood.Magic.Controls.TabPage("View PO", controlToAdd, ImageList1, 0)

        page.Selected = True

        a.MainTabControl.TabPages.Add(page)

        Me.Cursor = Cursors.Default
    End Sub
    'Close PO button
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    'Add PO info click
    Private Sub AddInfoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddInfoBtn.Click
        If GridView3.SelectedRowsCount <> 0 Then
            If GridView3.RowCount >= 1 Then
                Dim index As Integer
                Dim dr As DataRow
                Dim SupplierID As Integer

                index = GridView3.GetSelectedRows(0)
                dr = GridView3.GetDataRow(index)

                Dim items As Object() = dr.ItemArray

                SupplierID = items(0)

                Dim form As New PODetailForm
                Dim found As Boolean

                form.Supplier_ID = SupplierID
                form.records = poRecords.Item(GetRecordIndex(SupplierID, found))
                form.ShowDialog()

                If form.SaveItem Then
                    'Display Delivery Date
                    GridView3.BeginInit()
                    GridView3.Columns.Item(2).ColumnEditProperties.ReadOnly = False
                    GridView3.EndInit()
                    GridView3.GetDataRow(index).Item(2) = form.DeliveryDate

                    GridView3.BeginInit()
                    GridView3.Columns.Item(2).ColumnEditProperties.ReadOnly = True
                    GridView3.EndInit()

                    'Display Discount
                    GridView3.BeginInit()
                    GridView3.Columns.Item(3).ColumnEditProperties.ReadOnly = False
                    GridView3.EndInit()
                    GridView3.GetDataRow(index).Item(3) = GetDiscount(form.DiscountType, form.Discount)

                    GridView3.BeginInit()
                    GridView3.Columns.Item(3).ColumnEditProperties.ReadOnly = True
                    GridView3.EndInit()
                End If

                'GetPORecord()
            End If
        End If
    End Sub

#End Region

#Region " Initial Grid "

    'Initalize PR Columns
    Private Sub InitPRList()

        dataPRGrid.BeginInit()
        AddColumn(dataPRGrid, "PR_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRGrid, "PR No.", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "PR_Date", System.Type.GetType("System.String"), True)

        dataPRGrid.EndInit()

        PRGrid.DataSource = dataPRGrid
        PRGrid.DefaultView.PopulateColumns()
        GridView1.BestFitColumns()
        GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column

        dataPRGrid2.BeginInit()
        AddColumn(dataPRGrid2, "PR_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRGrid2, "PR No.", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid2, "PR_Date", System.Type.GetType("System.String"), True)

        dataPRGrid2.EndInit()

        PRGrid2.DataSource = dataPRGrid2
        PRGrid2.DefaultView.PopulateColumns()
        GridView2.BestFitColumns()
        GridView2.Columns.Item(0).VisibleIndex = -1 'hide 1st column

    End Sub

    Private Sub InitSupplierList()

        dataSupplierGrid.BeginInit()
        AddColumn(dataSupplierGrid, "Supplier_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataSupplierGrid, "Supplier Name", System.Type.GetType("System.String"), True)
        AddColumn(dataSupplierGrid, "Delivery Date", System.Type.GetType("System.String"), False)
        AddColumn(dataSupplierGrid, "Discount", System.Type.GetType("System.String"), False)

        dataSupplierGrid.EndInit()

        SupplierGrid.DataSource = dataSupplierGrid
        SupplierGrid.DefaultView.PopulateColumns()
        GridView3.BestFitColumns()
        GridView3.Columns.Item(0).VisibleIndex = -1 'hide 1st column
        'GridView3.Columns.Item(2).VisibleIndex = -1
        GridView3.Columns.Item(3).VisibleIndex = -1



        GridView3.BeginInit()
        GridView3.Columns.Item(2).ColumnEditProperties.ReadOnly = True
        GridView3.Columns.Item(3).ColumnEditProperties.ReadOnly = True
        GridView3.EndInit()

    End Sub

    Private Sub InitPRItemList()
        dataPRItemGrid.BeginInit()
        AddColumn(dataPRItemGrid, "PR_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRItemGrid, "PR_Line", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRItemGrid, "Supplier_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRItemGrid, "Product_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRItemGrid, "Category_ID", System.Type.GetType("System.Int32"), True)

        AddColumn(dataPRItemGrid, "PR No", System.Type.GetType("System.String"), True)
        AddColumn(dataPRItemGrid, "Supplier", System.Type.GetType("System.String"), True)
        AddColumn(dataPRItemGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataPRItemGrid, "Qty", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPRItemGrid, "UOM", System.Type.GetType("System.String"), True)
        AddColumn(dataPRItemGrid, "Price", System.Type.GetType("System.Double"), True)
        AddColumn(dataPRItemGrid, "WO No", System.Type.GetType("System.String"), True)
        AddColumn(dataPRItemGrid, "Delivery Date", System.Type.GetType("System.String"), True)

        dataPRItemGrid.EndInit()

        PRItemGrid.DataSource = dataPRItemGrid
        PRItemGrid.MainView.PopulateColumns()

        GridView4.BestFitColumns()
        GridView4.Columns.Item(0).VisibleIndex = -1
        GridView4.Columns.Item(1).VisibleIndex = -1
        GridView4.Columns.Item(2).VisibleIndex = -1
        GridView4.Columns.Item(3).VisibleIndex = -1
        GridView4.Columns.Item(4).VisibleIndex = -1

        'Qty
        GridView4.Columns.Item(8).Width = 45
        'UOM
        GridView4.Columns.Item(9).Width = 80
        'Price
        GridView4.Columns.Item(10).Width = 75
        'Work No
        GridView4.Columns.Item(11).Width = 60
    End Sub

#End Region

#Region " Other Code "

    Private Sub CheckBtn()

        If GridView1.RowCount = 0 Then
            AddAllBtn.Enabled = False
            AddBtn.Enabled = False
        Else
            AddAllBtn.Enabled = True
            AddBtn.Enabled = True
        End If

        If GridView2.RowCount = 0 Then
            RemoveAllBtn.Enabled = False
            RemoveBtn.Enabled = False
        Else
            RemoveAllBtn.Enabled = True
            RemoveBtn.Enabled = True
        End If
    End Sub
    Private Function CreatePONo() As String
        Dim DocumentNo As String
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("PO")
        End With
        'CreatePONo = "SI-P" & DocumentNo & "/" & Year(Now) & UserInitial
        CreatePONo = DocumentNo & "/" & Year(Now) & UserInitial

    End Function

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

    Private Sub ButtonClick(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal dataTB As DataTable, ByVal typeButton As Boolean)

        If gridView.SelectedRowsCount <> 0 Then
            If gridView.IsGroupRow(gridView.GetSelectedRows(0)) = False Then

                Dim PR_ID As Integer
                Dim PR_No As String
                Dim PR_Date As String

                Me.Cursor = Cursors.WaitCursor
                Dim dr As DataRow
                dr = gridView.GetDataRow(gridView.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                PR_ID = items(0)
                PR_No = items(1)
                PR_Date = items(2)

                dataTB.Rows.Add(New Object() {PR_ID, PR_No, PR_Date})

                gridView.DeleteRow(gridView.GetSelectedRows(0))

                If typeButton Then
                    'Add
                    LoadPRItem(PR_ID, PR_No)
                Else
                    'Remove
                    RemovePRLine(PR_ID)
                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub GetPRItem()

        ClearGrid(GridView4)

        Dim PR_ID As Integer
        Dim PR_No As String
        Dim Supplier_ID As Integer

        Dim dr As DataRow
        Dim dr2 As DataRow

        Dim i As Integer
        Dim j As Integer

        Dim items As Object
        Dim items2 As Object

        'Loop PR list

        For i = 0 To GridView2.RowCount - 1
            dr = GridView2.GetDataRow(i)

            items = dr.ItemArray

            PR_ID = items(0)
            PR_No = items(1)
            If GridView3.RowCount <> 0 Then
                For j = 0 To GridView3.RowCount - 1
                    dr2 = GridView3.GetDataRow(j)

                    items2 = dr2.ItemArray
                    Supplier_ID = items2(0)
                    'LoadPRItem(PR_ID, PR_No, Supplier_ID)
                Next
            End If
        Next

    End Sub

    'Called when PR or Supplier is removed
    Private Sub RemovePRLine(Optional ByVal pPR_ID As Integer = 0, Optional ByVal pSupplier_ID As Integer = 0)

        Dim i
        Dim dr As DataRow
        Dim items As Object()

        If pPR_ID <> 0 And pPR_ID <> Nothing Then
            'Remove item base on PR_ID
            For i = 0 To GridView4.RowCount - 1

                If GridView4.RowCount = i Then
                    Exit For
                End If
                dr = GridView4.GetDataRow(i)
                items = dr.ItemArray
                If items(0) = pPR_ID Then
                    GridView4.DeleteRow(i)
                    If i = 0 Then
                        i = -1
                    Else
                        i = i - 1
                    End If

                End If
            Next

        Else
            'Remove Item base on Supplier_ID
            For i = 0 To GridView4.RowCount - 1

                If GridView4.RowCount = i Then
                    Exit For
                End If
                dr = GridView4.GetDataRow(i)
                items = dr.ItemArray
                If items(2) = pSupplier_ID Then
                    GridView4.DeleteRow(i)
                    If i = 0 Then
                        i = -1
                    Else
                        i = i - 1
                    End If

                End If
            Next
        End If
    End Sub

    'Close Tab Page
    Private Sub CloseTabPage()
        'Me.Close()
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    'Disable all buttons (called after saving PO)
    Private Sub DisabledAll()

        'Buttons
        AddAllBtn.Enabled = False
        RemoveAllBtn.Enabled = False
        AddBtn.Enabled = False
        RemoveBtn.Enabled = False
        GeneratePOBtn.Enabled = False
        RemoveSupBtn.Enabled = False
        AddInfoBtn.Enabled = False

    End Sub

    Private Function GetDiscount(ByVal DiscountType As String, ByVal Discount As Integer) As String
        Dim discountTemp As String = ""

        If DiscountType = "0" Then
            discountTemp = "No Discount"
        ElseIf DiscountType = "1" Then
            discountTemp = "$ " + Discount.ToString()
        ElseIf DiscountType = "2" Then
            discountTemp = Discount.ToString() + " %"
        End If

        GetDiscount = discountTemp
    End Function

    Private Sub GetUserGrpInitial()
        Dim ds As DataSet

        UserName = ""
        UserGrp = ""

        If UserID <> 0 And UserID <> Nothing Then
            With New BusinessRules.PRBusRules.PRBusLogic
                If .GetUser(ds, UserID) Then
                    If Not ds Is Nothing Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)
                        UserName = row("Name").ToString()
                        CreaterTxt.Text = UserName

                        If Not row.IsNull("Department_ID") Then
                            If .LoadUserGrpList(ds, row("Department_ID").ToString()) Then
                                row = ds.Tables(0).Rows(0)
                                If Not row.IsNull("Name") Then
                                    UserGrp = (row("Name").ToString()).Substring(0, 1)
                                End If
                            End If
                        End If
                    End If
                End If

            End With
        End If

    End Sub

    Private Sub GetUserInitial()

        If UserID <> 0 And UserID <> Nothing Then
            With New BusinessRules.PRBusRules.PRBusLogic
                UserInitial = .GetUserInitials(UserID)
            End With
        End If

    End Sub

#End Region

#Region "Database Management - Loading"

    'Load Grp Combo
    Private Sub LoadGrp()
        Dim grpData As String() = New String() {"Admin", "ISO"}
        Dim idData As String() = New String() {"1", "0"}

        SetComboValue(grpData, GrpLookup, idData)
    End Sub

    'Load Status Combo
    Private Sub LoadStatus()
        Dim statusData As String() = New String() {"Preparing"}
        Dim idData As String() = New String() {"20"}

        SetComboValue(statusData, StatusLookUp, idData)
    End Sub

    'Load outstanding PR
    Private Sub LoadPRFrmDB()

        Dim ds As DataSet

        Dim Requester
        Dim Approver
        Dim Category
        Dim Status
        Dim Grp
        Dim PR_Date

        With New BusinessRules.POBusRules.POBusLogic
            If .LoadPRList(ds, , PRStatus) Then
                If Not ds Is Nothing Then
                    Try
                        Dim oRow As DataRow
                        Dim i As Integer = 0
                        Dim tempPR_Date As String = ""

                        For Each oRow In ds.Tables(0).Rows
                            i = i + 1


                            tempPR_Date = ChangeDateFormat(oRow("Submit_Date"))
                            dataPRGrid.Rows.Add(New Object() {oRow("PR_ID"), oRow("PR_No"), tempPR_Date})
                        Next

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try

                End If
            End If
        End With
    End Sub

    'Load Supplier
    Private Sub LoadSupplier()

        ClearGrid(GridView3)
        'poRecords.Clear()

        Dim SQLStr
        SQLStr = GetPR_IDSQL()

        If SQLStr <> "" Then
            Dim ds As DataSet

            Dim Requester
            Dim Approver
            Dim Category
            Dim Status
            Dim Grp
            Dim PR_Date
            Dim check As Boolean

            If GrpLookup.Properties.LookUpData.KeyValue().ToString() = "0" Then
                CheckApproval = True
            Else
                CheckApproval = False
            End If

            With New BusinessRules.POBusRules.POBusLogic
                If .LoadPRSupplierList(ds, PRStatus, SQLStr, CheckApproval) Then
                    If Not ds Is Nothing Then
                        Try
                            Dim oRow As DataRow
                            Dim i = 0
                            Dim index As Integer
                            Dim GST_flag As Integer

                            Dim records As BusinessRules.POBusRules.PORecord

                            For Each oRow In ds.Tables(0).Rows
                                index = GetRecordIndex(oRow("Supplier_ID"), check)
                                GST_flag = oRow("GST_Flg")
                                dataSupplierGrid.Rows.Add(New Object() {oRow("Supplier_ID"), oRow("Supplier_Name"), "", ""})

                                If check = False Then
                                    records = New BusinessRules.POBusRules.PORecord(oRow("Supplier_ID"), GST_flag, "", "Our Premises", "0", 0, "", "", "")

                                    poRecords.Add(records)

                                    GridView3.BeginInit()
                                    GridView3.Columns.Item(3).ColumnEditProperties.ReadOnly = False
                                    GridView3.EndInit()
                                    GridView3.GetDataRow(i).Item(3) = GetDiscount("0", 0)

                                    GridView3.BeginInit()
                                    GridView3.Columns.Item(3).ColumnEditProperties.ReadOnly = True
                                    GridView3.EndInit()
                                Else

                                    records = poRecords.Item(index)

                                    GridView3.BeginInit()
                                    GridView3.Columns.Item(2).ColumnEditProperties.ReadOnly = False
                                    GridView3.EndInit()

                                    GridView3.GetDataRow(i).Item(2) = records.DeliveryDate

                                    GridView3.BeginInit()
                                    GridView3.Columns.Item(2).ColumnEditProperties.ReadOnly = True
                                    GridView3.EndInit()


                                    GridView3.BeginInit()
                                    GridView3.Columns.Item(3).ColumnEditProperties.ReadOnly = False
                                    GridView3.EndInit()
                                    GridView3.GetDataRow(i).Item(3) = GetDiscount(records.DiscountType, records.Discount)

                                    GridView3.BeginInit()
                                    GridView3.Columns.Item(3).ColumnEditProperties.ReadOnly = True
                                    GridView3.EndInit()
                                End If

                                i = i + 1

                            Next

                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End If
                End If
            End With

        End If

    End Sub

    'SQL Statement for loading supplier
    Private Function GetPR_IDSQL() As String

        Dim SQLStr As String
        Dim PR_ID As Integer
        Dim i
        Dim dr As DataRow
        Dim items As Object()

        SQLStr = ""

        For i = 0 To GridView2.RowCount - 1
            dr = GridView2.GetDataRow(i)
            items = dr.ItemArray

            PR_ID = items(0)

            If PR_ID <> 0 Then
                If SQLStr <> "" Then
                    SQLStr = SQLStr & " OR PR.PR_ID = " & PR_ID
                Else
                    SQLStr = " ( PR.PR_ID = " & PR_ID
                End If
            End If
        Next

        If SQLStr <> "" Then
            SQLStr = "AND " & SQLStr & ")"
        End If

        GetPR_IDSQL = SQLStr
    End Function

    'Load PR Item when PR is added PR
    Private Sub LoadPRItem(ByVal pPR_ID As Integer, ByVal pPR_No As String)

        If pPR_ID <> Nothing And pPR_ID <> 0 Then
            Dim ds As DataSet

            Dim Requester
            Dim Approver
            Dim Category
            Dim Status
            Dim Grp
            Dim PR_Date

            Dim WO_No
            Dim Delivery_Date

            If GrpLookup.Properties.LookUpData.KeyValue().ToString() = "0" Then
                CheckApproval = True
            Else
                CheckApproval = False
            End If

            With New BusinessRules.POBusRules.POBusLogic
                If .LoadPRLineList(ds, pPR_ID, , CheckApproval) Then
                    If Not ds Is Nothing Then
                        Try
                            Dim oRow As DataRow
                            Dim i As Integer = 0
                            Dim tempDeliveryDate As String = ""
                            For Each oRow In ds.Tables(0).Rows

                                If Not oRow.IsNull("WO_No") Then
                                    WO_No = oRow("WO_No").ToString()
                                Else
                                    WO_No = ""
                                End If

                                If Not oRow.IsNull("Delivery_Date") Then
                                    Delivery_Date = ChangeDateFormat(oRow("Delivery_Date").ToString())
                                Else
                                    Delivery_Date = ""
                                End If


                                dataPRItemGrid.Rows.Add(New Object() {pPR_ID, _
                                                                        oRow("PR_Line"), _
                                                                        oRow("Supplier_ID"), _
                                                                        oRow("Product_ID"), _
                                                                        oRow("Category_ID"), _
                                                                        pPR_No, _
                                                                        oRow("Supplier_Name"), _
                                                                        oRow("ProductName"), _
                                                                        oRow("Order_Qty"), _
                                                                        oRow("UOM"), _
                                                                        oRow("Price"), _
                                                                        WO_No, Delivery_Date})

                                i = i + 1
                            Next

                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End If
                End If
            End With
        End If


    End Sub

#End Region

#Region "Database Management"

    Private Sub SavePO(ByVal pSupplier_ID As String, Optional ByVal pPO_NO As String = "")
        Dim index As Integer
        Dim check As Boolean

        index = GetRecordIndex(pSupplier_ID, check)

        With New BusinessRules.POBusRules.POHeaderBusLogic
            If pPO_NO <> "" Then
                PO_NO = pPO_NO
            Else
                PO_NO = CreatePONo()
            End If

            'PO_NO = PONo.Text

            .PO_NO = PO_NO
            '.PO_Title = POTitle.Text
            .Grp = Grp
            .Supplier_ID = pSupplier_ID
            .Status = Status
            .Shipment_Date = Shipment_Date
            .UserID = UserID

            'Get other info from PORecord
            If check Then
                Dim records As BusinessRules.POBusRules.PORecord

                records = poRecords.Item(index)
                .PO_Title = records.Title
                .Shipment_Date = records.DeliveryDate
                .DeliverTo = records.DeliverTo
                .DiscountType = records.DiscountType
                .Discount = records.Discount
                .Remarks = records.Remarks
                .Notes = records.Notes

                If Me.GST_CheckBox.Checked Then
                    .GST_Flg = 1
                Else
                    .GST_Flg = 0
                End If

                poRecords.RemoveAt(index)

            End If

            'New Record
            PO_ID = .Save()
            SaveItem(PO_ID, pSupplier_ID)
        End With

    End Sub

    Private Sub SaveItem(ByVal pPO_ID As Integer, ByVal pSupplier_ID As Integer)

        Dim PO_Line_ID As Integer

        Dim Category_ID As Integer
        Dim Product_ID As Integer
        Dim Order_Qty As Integer

        Dim PR_ID As Integer
        Dim PR_Line As Integer
        Dim Price As Double

        Dim WO_No As String
        Dim Delivery_Date As String

        Dim i
        Dim dr As DataRow
        Dim items As Object()
        Dim ds As DataSet

        For i = 0 To GridView4.RowCount - 1
            If GridView4.IsGroupRow(i) = False Then

                dr = GridView4.GetDataRow(i)
                items = dr.ItemArray

                If items(2) = pSupplier_ID Then
                    PR_ID = items(0)
                    PR_Line = items(1)
                    Product_ID = items(3)
                    Category_ID = items(4)
                    Order_Qty = items(8)
                    Price = items(10)
                    WO_No = items(11)
                    Delivery_Date = items(12)

                    With New BusinessRules.POBusRules.POLineBusLogic

                        .PO_ID = pPO_ID
                        .Category_ID = Category_ID
                        .Product_ID = Product_ID
                        .Order_Qty = Order_Qty
                        .Confirm_Qty = 0
                        .PR_ID = PR_ID
                        .PR_Line = PR_Line
                        .Unit_Price = Price
                        ' YG 18.10.2003 add status
                        .Status = Status
                        .WO_No = WO_No
                        .Delivery_Date = Delivery_Date

                        .UserID = UserID 'Common.CommonConn.Config.USERID

                        'Creates a new record
                        PO_Line_ID = .Save()
                    End With

                    With New BusinessRules.PRBusRules.PRLineBusLogic
                        .PO_ID = pPO_ID
                        .PO_Line_ID = PO_Line_ID
                        .UpdatePOID(PR_Line)
                    End With

                End If
            End If
        Next

    End Sub

#End Region

#Region " PO Records"

    Private Sub GetPORecord()
        Dim countRec As Integer
        Dim i
        Dim records As BusinessRules.POBusRules.PORecord

        countRec = poRecords.Count

        Debug.WriteLine("")
        Debug.WriteLine("countRec : " + countRec.ToString)

        For i = 0 To countRec - 1

            records = poRecords.Item(i)

            Debug.WriteLine("SupplierID :" + (records.SupplierID).ToString)
            Debug.WriteLine("DeliveryDate :" + records.DeliveryDate)
            Debug.WriteLine("DeliverTo :" + records.DeliverTo)
            Debug.WriteLine("Discount :" + (records.Discount).ToString)
            Debug.WriteLine("DiscountType :" + records.DiscountType)
            Debug.WriteLine("Remarks :" + records.Remarks)
            Debug.WriteLine("Notes :" + records.Notes)
            'i = i + 1
        Next
    End Sub


    Private Function GetRecordIndex(ByVal pSupplierID As Integer, ByRef RecordExist As Boolean) As Integer
        Dim countRec As Integer
        Dim i
        Dim index As Integer
        Dim found As Boolean

        found = False

        index = Nothing

        Dim records As BusinessRules.POBusRules.PORecord
        countRec = poRecords.Count

        For i = 0 To countRec - 1

            records = poRecords.Item(i)

            If records.SupplierID = pSupplierID Then
                index = i
                found = True
                Exit For
            End If
        Next

        RecordExist = found
        GetRecordIndex = index
    End Function

    Private Sub RemovePORecord()
        Dim Supplier_ID As Integer
        Dim j As Integer
        Dim dr As DataRow
        Dim item As Object

        Dim countRec As Integer
        Dim i
        Dim found As Boolean
        found = False

        Dim records As BusinessRules.POBusRules.PORecord

        For i = 0 To poRecords.Count - 1

            If poRecords.Count = i Then
                Exit For
            End If

            records = poRecords.Item(i)

            found = False
            If GridView3.RowCount <> 0 Then
                For j = 0 To GridView3.RowCount - 1
                    dr = GridView3.GetDataRow(j)
                    item = dr.ItemArray
                    Supplier_ID = item(0)

                    If records.SupplierID = Supplier_ID Then
                        found = True
                        Exit For
                    End If
                Next

            End If

            If found = False Then
                poRecords.RemoveAt(i)
                If i = 0 Then
                    i = -1
                Else
                    i = i - 1
                End If
            End If

        Next


    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        'If Len(PONo.Text) = 0 Then
        'MessageBox.Show("Please enter a PO No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'DataOK_flag = False

        If GridView2.RowCount = 0 Then
            MessageBox.Show("Please select at least 1 PR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DataOK_flag = False

        ElseIf GridView3.RowCount = 0 Then
            MessageBox.Show("Please select at least 1 supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DataOK_flag = False
        End If

        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .RecordExists(PONo.Text) Then
                MessageBox.Show("PO No already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DataOK_flag = False
            End If
        End With


        Return DataOK_flag

    End Function

#End Region

#Region " Code - Set/Get Window Values"

    'Set Window Values
    Private Sub SetWindowsValue()

        If Grp <> "" Then
            GrpLookup.Properties.LookUpData.KeyValue = Grp
        Else
            GrpLookup.Properties.LookUpData.KeyValue = "1" 'New Decimal(New Integer() {0, 0, 0, 0})
        End If

        StatusLookUp.Properties.LookUpData.KeyValue = "20"
        PODateEdit.DateTime = Date.Parse(Now).Date
    End Sub

    Private Sub GetWindowsValue()

        If GrpLookup.Properties.LookUpData.KeyValue() <> Nothing Then
            Grp = GrpLookup.Properties.LookUpData.KeyValue().ToString()
        Else
            Grp = ""
        End If

        If StatusLookUp.Properties.LookUpData.KeyValue() <> Nothing Then
            Status = StatusLookUp.Properties.LookUpData.KeyValue().ToString()
        Else
            Status = ""
        End If

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

#Region " Code - Common Bus Logic"

    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())

        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)

        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

#End Region



    Private Sub TemplateCtr_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplateCtr.SelectionChanged

    End Sub
    Private Sub POForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PO?", "PO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If Result = DialogResult.Yes Then
        CloseTabPage()
        'Else
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub SupplierGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SupplierGrid.Click
        Dim dr As DataRow
        Dim item As Object
        Dim Supplier_ID As Integer

        Dim Row As Integer = GridView3.GetSelectedRows(0)

        dr = GridView3.GetDataRow(Row)
        item = dr.ItemArray
        Supplier_ID = item(0)

        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .Load(Supplier_ID) Then
                If .GST_Flg = "1" Then
                    Me.GST_CheckBox.CheckState = CheckState.Checked
                ElseIf .GST_Flg = "0" Then
                    Me.GST_CheckBox.CheckState = CheckState.Unchecked
                End If
            End If
        End With


    End Sub
End Class
