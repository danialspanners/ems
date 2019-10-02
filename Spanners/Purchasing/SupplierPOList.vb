Public Class SupplierPOList
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
    Friend WithEvents POLineToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents POLineFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents POListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents SubConRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SupplierSubRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SupplierRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SupplierTypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AllSupplierRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SupplierStatusGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AllSupplierStatusRadio As System.Windows.Forms.RadioButton
    Friend WithEvents FromSupplierCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NotApprovedSupplierRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ApprovedSupplierRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToSupplierCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents POListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.POLineToDate = New DevExpress.XtraEditors.DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.POLineFromDate = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.POListGrp = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToSupplierCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.SupplierStatusGroupBox = New System.Windows.Forms.GroupBox
        Me.AllSupplierStatusRadio = New System.Windows.Forms.RadioButton
        Me.NotApprovedSupplierRadio = New System.Windows.Forms.RadioButton
        Me.ApprovedSupplierRadio = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.FromSupplierCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.SupplierTypeGroupBox = New System.Windows.Forms.GroupBox
        Me.AllSupplierRadio = New System.Windows.Forms.RadioButton
        Me.SubConRadio = New System.Windows.Forms.RadioButton
        Me.SupplierSubRadio = New System.Windows.Forms.RadioButton
        Me.SupplierRadio = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.POListGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SupplierListGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POLineToDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POLineFromDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POListGrp.SuspendLayout()
        CType(Me.ToSupplierCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierStatusGroupBox.SuspendLayout()
        CType(Me.FromSupplierCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierTypeGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.POListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        '
        'POLineToDate
        '
        Me.POLineToDate.DateTime = New Date(CType(0, Long))
        Me.POLineToDate.Location = New System.Drawing.Point(136, 96)
        Me.POLineToDate.Name = "POLineToDate"
        Me.POLineToDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.POLineToDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.POLineToDate.Size = New System.Drawing.Size(104, 19)
        Me.POLineToDate.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "To :"
        '
        'POLineFromDate
        '
        Me.POLineFromDate.DateTime = New Date(CType(0, Long))
        Me.POLineFromDate.Location = New System.Drawing.Point(136, 72)
        Me.POLineFromDate.Name = "POLineFromDate"
        Me.POLineFromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.POLineFromDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.POLineFromDate.Size = New System.Drawing.Size(104, 19)
        Me.POLineFromDate.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Order From :"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(16, 136)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Search"
        '
        'PrintPOBtn
        '
        Me.PrintPOBtn.AutoSize = False
        Me.PrintPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPOBtn.Image = Nothing
        Me.PrintPOBtn.Location = New System.Drawing.Point(96, 136)
        Me.PrintPOBtn.Name = "PrintPOBtn"
        Me.PrintPOBtn.Size = New System.Drawing.Size(64, 32)
        Me.PrintPOBtn.TabIndex = 24
        Me.PrintPOBtn.Text = "Print"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(168, 136)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'POListGrp
        '
        Me.POListGrp.Controls.Add(Me.Label4)
        Me.POListGrp.Controls.Add(Me.ToSupplierCmb)
        Me.POListGrp.Controls.Add(Me.SupplierStatusGroupBox)
        Me.POListGrp.Controls.Add(Me.Label2)
        Me.POListGrp.Controls.Add(Me.FromSupplierCmb)
        Me.POListGrp.Controls.Add(Me.SupplierTypeGroupBox)
        Me.POListGrp.Controls.Add(Me.btnRefresh)
        Me.POListGrp.Controls.Add(Me.PrintPOBtn)
        Me.POListGrp.Controls.Add(Me.CloseBtn)
        Me.POListGrp.Controls.Add(Me.POLineToDate)
        Me.POListGrp.Controls.Add(Me.Label1)
        Me.POListGrp.Controls.Add(Me.POLineFromDate)
        Me.POListGrp.Controls.Add(Me.Label3)
        Me.POListGrp.Location = New System.Drawing.Point(8, 8)
        Me.POListGrp.Name = "POListGrp"
        Me.POListGrp.Size = New System.Drawing.Size(656, 176)
        Me.POListGrp.TabIndex = 3
        Me.POListGrp.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "To :"
        '
        'ToSupplierCmb
        '
        Me.ToSupplierCmb.Location = New System.Drawing.Point(136, 48)
        Me.ToSupplierCmb.Name = "ToSupplierCmb"
        Me.ToSupplierCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ToSupplierCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ToSupplierCmb.Properties.NullString = ""
        Me.ToSupplierCmb.Properties.PopupWidth = 208
        Me.ToSupplierCmb.Size = New System.Drawing.Size(200, 19)
        Me.ToSupplierCmb.TabIndex = 183
        '
        'SupplierStatusGroupBox
        '
        Me.SupplierStatusGroupBox.Controls.Add(Me.AllSupplierStatusRadio)
        Me.SupplierStatusGroupBox.Controls.Add(Me.NotApprovedSupplierRadio)
        Me.SupplierStatusGroupBox.Controls.Add(Me.ApprovedSupplierRadio)
        Me.SupplierStatusGroupBox.Location = New System.Drawing.Point(360, 24)
        Me.SupplierStatusGroupBox.Name = "SupplierStatusGroupBox"
        Me.SupplierStatusGroupBox.Size = New System.Drawing.Size(104, 96)
        Me.SupplierStatusGroupBox.TabIndex = 182
        Me.SupplierStatusGroupBox.TabStop = False
        Me.SupplierStatusGroupBox.Text = "Status"
        '
        'AllSupplierStatusRadio
        '
        Me.AllSupplierStatusRadio.Location = New System.Drawing.Point(8, 16)
        Me.AllSupplierStatusRadio.Name = "AllSupplierStatusRadio"
        Me.AllSupplierStatusRadio.Size = New System.Drawing.Size(80, 24)
        Me.AllSupplierStatusRadio.TabIndex = 97
        Me.AllSupplierStatusRadio.Text = "All"
        '
        'NotApprovedSupplierRadio
        '
        Me.NotApprovedSupplierRadio.Location = New System.Drawing.Point(8, 64)
        Me.NotApprovedSupplierRadio.Name = "NotApprovedSupplierRadio"
        Me.NotApprovedSupplierRadio.Size = New System.Drawing.Size(80, 24)
        Me.NotApprovedSupplierRadio.TabIndex = 95
        Me.NotApprovedSupplierRadio.Text = "Rejected"
        '
        'ApprovedSupplierRadio
        '
        Me.ApprovedSupplierRadio.Location = New System.Drawing.Point(8, 40)
        Me.ApprovedSupplierRadio.Name = "ApprovedSupplierRadio"
        Me.ApprovedSupplierRadio.Size = New System.Drawing.Size(80, 24)
        Me.ApprovedSupplierRadio.TabIndex = 94
        Me.ApprovedSupplierRadio.Text = "Approved"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Supplier From :"
        '
        'FromSupplierCmb
        '
        Me.FromSupplierCmb.Location = New System.Drawing.Point(136, 24)
        Me.FromSupplierCmb.Name = "FromSupplierCmb"
        Me.FromSupplierCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.FromSupplierCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.FromSupplierCmb.Properties.NullString = ""
        Me.FromSupplierCmb.Properties.PopupWidth = 200
        Me.FromSupplierCmb.Size = New System.Drawing.Size(200, 19)
        Me.FromSupplierCmb.TabIndex = 180
        '
        'SupplierTypeGroupBox
        '
        Me.SupplierTypeGroupBox.Controls.Add(Me.AllSupplierRadio)
        Me.SupplierTypeGroupBox.Controls.Add(Me.SubConRadio)
        Me.SupplierTypeGroupBox.Controls.Add(Me.SupplierSubRadio)
        Me.SupplierTypeGroupBox.Controls.Add(Me.SupplierRadio)
        Me.SupplierTypeGroupBox.Location = New System.Drawing.Point(480, 16)
        Me.SupplierTypeGroupBox.Name = "SupplierTypeGroupBox"
        Me.SupplierTypeGroupBox.Size = New System.Drawing.Size(168, 120)
        Me.SupplierTypeGroupBox.TabIndex = 167
        Me.SupplierTypeGroupBox.TabStop = False
        Me.SupplierTypeGroupBox.Text = "Supplier Type"
        '
        'AllSupplierRadio
        '
        Me.AllSupplierRadio.Location = New System.Drawing.Point(8, 16)
        Me.AllSupplierRadio.Name = "AllSupplierRadio"
        Me.AllSupplierRadio.Size = New System.Drawing.Size(152, 24)
        Me.AllSupplierRadio.TabIndex = 97
        Me.AllSupplierRadio.Text = "All"
        '
        'SubConRadio
        '
        Me.SubConRadio.Location = New System.Drawing.Point(8, 64)
        Me.SubConRadio.Name = "SubConRadio"
        Me.SubConRadio.TabIndex = 95
        Me.SubConRadio.Text = "Sub Contractor"
        '
        'SupplierSubRadio
        '
        Me.SupplierSubRadio.Location = New System.Drawing.Point(8, 88)
        Me.SupplierSubRadio.Name = "SupplierSubRadio"
        Me.SupplierSubRadio.Size = New System.Drawing.Size(152, 24)
        Me.SupplierSubRadio.TabIndex = 96
        Me.SupplierSubRadio.Text = "Supplier / Sub Contractor"
        '
        'SupplierRadio
        '
        Me.SupplierRadio.Location = New System.Drawing.Point(8, 40)
        Me.SupplierRadio.Name = "SupplierRadio"
        Me.SupplierRadio.TabIndex = 94
        Me.SupplierRadio.Text = "Supplier"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.POListGrid)
        Me.GroupBox1.Controls.Add(Me.SupplierListGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 240)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(240, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 192
        Me.Label6.Text = "Order History"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 191
        Me.Label5.Text = "Supplier List"
        '
        'POListGrid
        '
        Me.POListGrid.EditorsRepository = Me.PersistentRepository1
        Me.POListGrid.Location = New System.Drawing.Point(240, 32)
        Me.POListGrid.MainView = Me.GridView2
        Me.POListGrid.Name = "POListGrid"
        Me.POListGrid.Size = New System.Drawing.Size(408, 200)
        Me.POListGrid.TabIndex = 190
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        Me.GridView2.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'SupplierListGrid
        '
        Me.SupplierListGrid.EditorsRepository = Me.PersistentRepository1
        Me.SupplierListGrid.Location = New System.Drawing.Point(8, 32)
        Me.SupplierListGrid.MainView = Me.GridView1
        Me.SupplierListGrid.Name = "SupplierListGrid"
        Me.SupplierListGrid.Size = New System.Drawing.Size(224, 200)
        Me.SupplierListGrid.TabIndex = 189
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'SupplierPOList
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(672, 445)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.POListGrp)
        Me.Name = "SupplierPOList"
        Me.Text = "Supplier PO Report"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POLineToDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POLineFromDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POListGrp.ResumeLayout(False)
        CType(Me.ToSupplierCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierStatusGroupBox.ResumeLayout(False)
        CType(Me.FromSupplierCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierTypeGroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.POListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public Supplier_ID As Integer
    Public POLine_Date_From As String
    Public POLine_Date_To As String
    Public Supplier_From As String
    Public Supplier_To As String
    Public SupplierID_From As Integer
    Public SupplierID_To As Integer
    Public Supplier_Status As String
    Public Supplier_Type As String
    Public dataSupplierGrid As System.Data.DataTable
    Public dataPOGrid As System.Data.DataTable

#End Region

#Region " Event "

    Private Sub POList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        LoadSupplierFrom()
        LoadSupplierTo()
        AllSupplierStatusRadio.Checked = True
        AllSupplierRadio.Checked = True

        LoadSupplierPOFrmDB()
        Timer1.Interval = 60000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadSupplierPOFrmDB()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub PrintPOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPOBtn.Click

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        GetWindowsValue()
        controlToAdd = New SupplierListReportForm(Supplier_From, Supplier_To, Supplier_Type, Supplier_Status, POLine_Date_From, POLine_Date_To)
        page = New Crownwood.Magic.Controls.TabPage("Print Supplier PO List Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadSupplierPOFrmDB()
    End Sub

#End Region

#Region " Grid Code "

    Private Sub LoadSupplierPOFrmDB()

        GetWindowsValue()
        LoadSupplierFrmDB()

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            SupplierClick()
        End If
    End Sub

    Private Sub LoadSupplierFrmDB()
        Dim ds As DataSet
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .LoadSupplierList(ds, Supplier_From, Supplier_To, Supplier_Type, Supplier_Status) Then
                InitSupplierList()

                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In ds.Tables(0).Rows
                    dataSupplierGrid.Rows.Add(New Object() {oRow("Supplier_ID"), _
                                                        oRow("Supplier_Name")})
                Next

                SupplierListGrid.DataSource = dataSupplierGrid
                SupplierListGrid.DefaultView.PopulateColumns()

                GridView1.BestFitColumns()
                GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Supplier_ID
            End If
        End With

    End Sub

    Private Sub SupplierClick()
        If GridView1.SelectedRowsCount <> 0 Then

            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then

                Me.Cursor = Cursors.WaitCursor
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                Supplier_ID = items(0)

                ClearGrid(GridView2)
                LoadPOList()

                Me.Cursor = Cursors.Default
            Else
                Supplier_ID = Nothing
                ClearGrid(GridView2)
            End If
        Else
            Supplier_ID = Nothing
            ClearGrid(GridView2)
        End If
    End Sub

    Private Sub LoadPOList()
        If Supplier_ID <> Nothing And Supplier_ID <> 0 Then
            LoadPOFrmDB()

            If GridView2.RowCount() <> 0 Then
                GridView2.MoveFirst()
            End If

        End If
    End Sub

    Private Sub LoadPOFrmDB()
        Dim ds As DataSet
        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .LoadPOList(ds, Supplier_ID, ChangeDateFormat(POLineFromDate.Text), ChangeDateFormat(POLineToDate.Text)) Then
                InitPOList()

                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In ds.Tables(0).Rows
                    dataPOGrid.Rows.Add(New Object() {oRow("PO_No"), _
                                                      oRow("Create_Date")})
                Next

                POListGrid.DataSource = dataPOGrid
                POListGrid.DefaultView.PopulateColumns()

                GridView1.BestFitColumns()
            End If
        End With

    End Sub

    Private Sub InitSupplierList()

        dataSupplierGrid = New DataTable("ColumnsTable")
        dataSupplierGrid.BeginInit()

        AddColumn(dataSupplierGrid, "Supplier ID", System.Type.GetType("System.String"), True)
        AddColumn(dataSupplierGrid, "Supplier Name", System.Type.GetType("System.String"), True)

        dataSupplierGrid.EndInit()

    End Sub

    Private Sub InitPOList()

        dataPOGrid = New DataTable("ColumnsTable")
        dataPOGrid.BeginInit()

        AddColumn(dataPOGrid, "PO No", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "Order Date", System.Type.GetType("System.String"), True)

        dataPOGrid.EndInit()

    End Sub

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
                If GridView1.IsGroupRow(i) = False Then

                    GridView.DeleteRow(GridView.GetSelectedRows(0))
                    If GridView.RowCount() <> 0 Then
                        GridView.FocusedRowHandle = 0
                    End If

                End If
            Next
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        SupplierClick()
    End Sub

#End Region

#Region " Other Codes "

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

    Private Sub LoadSupplierFrom()
        Dim ds As DataSet
        'Load supplier list
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .LoadList(ds) Then
                If Not ds Is Nothing Then
                    Try
                        FromSupplierCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(FromSupplierCmb, "Supplier_Name", 200, 0, "")

                        FromSupplierCmb.Properties.LookUpData.KeyField = "Supplier_ID"
                        FromSupplierCmb.Properties.LookUpData.DisplayField = "Supplier_Name"
                        FromSupplierCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load supplier list
    End Sub

    Private Sub LoadSupplierTo()
        Dim ds As DataSet
        'Load supplier list
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .LoadList(ds) Then
                If Not ds Is Nothing Then
                    Try
                        ToSupplierCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(ToSupplierCmb, "Supplier_Name", 200, 0, "")

                        ToSupplierCmb.Properties.LookUpData.KeyField = "Supplier_ID"
                        ToSupplierCmb.Properties.LookUpData.DisplayField = "Supplier_Name"
                        ToSupplierCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load supplier list
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)

        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

#End Region

#Region " Code - Get Window Values"

    Private Sub GetWindowsValue()
        Dim dsSupplier As DataSet

        If Not FromSupplierCmb.Properties.LookUpData.KeyValue = Nothing Then
            SupplierID_From = FromSupplierCmb.Properties.LookUpData.KeyValue
        End If
        If SupplierID_From > 0 Then
            With New BusinessRules.SupplierBusRules.SupplierBusLogic
                If .GetSupplierHeader(dsSupplier, SupplierID_From) Then
                    If Not dsSupplier Is Nothing Then
                        Supplier_From = dsSupplier.Tables(0).Rows(0)("Supplier_Name")
                    End If
                End If
            End With
            dsSupplier.Dispose()
        End If

        If Not ToSupplierCmb.Properties.LookUpData.KeyValue = Nothing Then
            SupplierID_To = ToSupplierCmb.Properties.LookUpData.KeyValue
        End If
        If SupplierID_To > 0 Then
            With New BusinessRules.SupplierBusRules.SupplierBusLogic
                If .GetSupplierHeader(dsSupplier, SupplierID_To) Then
                    If Not dsSupplier Is Nothing Then
                        Supplier_To = dsSupplier.Tables(0).Rows(0)("Supplier_Name")
                    End If
                End If
            End With
            dsSupplier.Dispose()
        End If

        POLine_Date_From = ChangeDateFormat(POLineFromDate.Text)
        POLine_Date_To = ChangeDateFormat(POLineToDate.Text)

        If AllSupplierRadio.Checked = True Then
            Supplier_Type = Nothing
        End If
        If SupplierRadio.Checked = True Then
            Supplier_Type = "1"
        End If
        If SubConRadio.Checked = True Then
            Supplier_Type = "2"
        End If
        If SupplierSubRadio.Checked = True Then
            Supplier_Type = "3"
        End If

        If AllSupplierStatusRadio.Checked = True Then
            Supplier_Status = Nothing
        End If
        If ApprovedSupplierRadio.Checked = True Then
            Supplier_Status = "1"
        End If
        If NotApprovedSupplierRadio.Checked = True Then
            Supplier_Status = "0"
        End If

    End Sub

#End Region

    Private Sub SupplierPOList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
