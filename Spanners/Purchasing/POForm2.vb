Public Class POForm2
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
    Friend WithEvents ShipmentDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(POForm2))
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GeneratePOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TemplateCtr = New Crownwood.Magic.Controls.TabControl
        Me.TabPage1 = New Crownwood.Magic.Controls.TabPage
        Me.RemoveSupBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SupplierGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TabPage2 = New Crownwood.Magic.Controls.TabPage
        Me.PRItemGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RemoveAllBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddAllBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRGrid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RemoveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ShipmentDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TemplateCtr.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SupplierGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PRItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PRGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GeneratePOBtn.Location = New System.Drawing.Point(8, 552)
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
        Me.CloseBtn.Location = New System.Drawing.Point(104, 552)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 27
        Me.CloseBtn.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TemplateCtr)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ShipmentDateEdit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 536)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'TemplateCtr
        '
        Me.TemplateCtr.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.TemplateCtr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TemplateCtr.IDEPixelArea = True
        Me.TemplateCtr.IDEPixelBorder = False
        Me.TemplateCtr.Location = New System.Drawing.Point(16, 288)
        Me.TemplateCtr.Name = "TemplateCtr"
        Me.TemplateCtr.SelectedIndex = 0
        Me.TemplateCtr.SelectedTab = Me.TabPage1
        Me.TemplateCtr.ShowArrows = False
        Me.TemplateCtr.ShowClose = False
        Me.TemplateCtr.Size = New System.Drawing.Size(600, 232)
        Me.TemplateCtr.TabIndex = 46
        Me.TemplateCtr.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.TabPage1, Me.TabPage2})
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RemoveSupBtn)
        Me.TabPage1.Controls.Add(Me.SupplierGrid)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.TabPage1.Location = New System.Drawing.Point(0, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(600, 207)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Title = "Supplier List"
        '
        'RemoveSupBtn
        '
        Me.RemoveSupBtn.AutoSize = False
        Me.RemoveSupBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RemoveSupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSupBtn.Image = Nothing
        Me.RemoveSupBtn.Location = New System.Drawing.Point(8, 168)
        Me.RemoveSupBtn.Name = "RemoveSupBtn"
        Me.RemoveSupBtn.Size = New System.Drawing.Size(104, 32)
        Me.RemoveSupBtn.TabIndex = 51
        Me.RemoveSupBtn.Text = "Remove from list"
        '
        'SupplierGrid
        '
        Me.SupplierGrid.EditorsRepository = Me.PersistentRepository1
        Me.SupplierGrid.Location = New System.Drawing.Point(8, 16)
        Me.SupplierGrid.MainView = Me.GridView3
        Me.SupplierGrid.Name = "SupplierGrid"
        Me.SupplierGrid.Size = New System.Drawing.Size(576, 144)
        Me.SupplierGrid.TabIndex = 49
        '
        'GridView3
        '
        Me.GridView3.DefaultEdit = Me.RepositoryItemTextEdit4
        Me.GridView3.Name = "GridView3"
        Me.GridView3.PreviewLineCount = 2
        Me.GridView3.VertScrollTipFieldName = Nothing
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PRItemGrid)
        Me.TabPage2.Location = New System.Drawing.Point(0, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Selected = False
        Me.TabPage2.Size = New System.Drawing.Size(600, 207)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Title = "Item List"
        Me.TabPage2.Visible = False
        '
        'PRItemGrid
        '
        Me.PRItemGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRItemGrid.Location = New System.Drawing.Point(8, 16)
        Me.PRItemGrid.MainView = Me.GridView4
        Me.PRItemGrid.Name = "PRItemGrid"
        Me.PRItemGrid.Size = New System.Drawing.Size(576, 176)
        Me.PRItemGrid.TabIndex = 50
        '
        'GridView4
        '
        Me.GridView4.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.PreviewLineCount = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemoveAllBtn)
        Me.GroupBox2.Controls.Add(Me.AddAllBtn)
        Me.GroupBox2.Controls.Add(Me.PRGrid2)
        Me.GroupBox2.Controls.Add(Me.RemoveBtn)
        Me.GroupBox2.Controls.Add(Me.AddBtn)
        Me.GroupBox2.Controls.Add(Me.PRGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 232)
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
        Me.RemoveAllBtn.Location = New System.Drawing.Point(256, 80)
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
        Me.AddAllBtn.Location = New System.Drawing.Point(256, 40)
        Me.AddAllBtn.Name = "AddAllBtn"
        Me.AddAllBtn.Size = New System.Drawing.Size(88, 32)
        Me.AddAllBtn.TabIndex = 46
        Me.AddAllBtn.Text = "Add All >>"
        '
        'PRGrid2
        '
        Me.PRGrid2.EditorsRepository = Me.PersistentRepository1
        Me.PRGrid2.Location = New System.Drawing.Point(352, 24)
        Me.PRGrid2.MainView = Me.GridView2
        Me.PRGrid2.Name = "PRGrid2"
        Me.PRGrid2.Size = New System.Drawing.Size(232, 192)
        Me.PRGrid2.TabIndex = 42
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        '
        'RemoveBtn
        '
        Me.RemoveBtn.AutoSize = False
        Me.RemoveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RemoveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBtn.Image = Nothing
        Me.RemoveBtn.Location = New System.Drawing.Point(256, 184)
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
        Me.AddBtn.Location = New System.Drawing.Point(256, 144)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(88, 32)
        Me.AddBtn.TabIndex = 43
        Me.AddBtn.Text = "Add >>"
        '
        'PRGrid
        '
        Me.PRGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRGrid.Location = New System.Drawing.Point(16, 24)
        Me.PRGrid.MainView = Me.GridView1
        Me.PRGrid.Name = "PRGrid"
        Me.PRGrid.Size = New System.Drawing.Size(232, 192)
        Me.PRGrid.TabIndex = 41
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit3
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        '
        'ShipmentDateEdit
        '
        Me.ShipmentDateEdit.DateTime = New Date(CType(0, Long))
        Me.ShipmentDateEdit.Location = New System.Drawing.Point(120, 16)
        Me.ShipmentDateEdit.Name = "ShipmentDateEdit"
        Me.ShipmentDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ShipmentDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ShipmentDateEdit.Size = New System.Drawing.Size(112, 19)
        Me.ShipmentDateEdit.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Shipment Date :"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'POForm2
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(656, 589)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GeneratePOBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Name = "POForm2"
        Me.Text = "Purchase Order"
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TemplateCtr.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SupplierGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PRItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PRGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public PO_ID As Integer
    Public PO_NO As String
    Public Shipment_Date As String
    Public Status As String
    Public UserID As String = Common.CommonConn.Config.USERID

    Dim dataPRGrid = New DataTable("ColumnsTable")
    Dim dataPRGrid2 = New DataTable("ColumnsTable")
    Dim dataPRItemGrid = New DataTable("ColumnsTable")
    Dim dataSupplierGrid = New DataTable("ColumnsTable")

    Public FormStatus As String

#End Region

#Region " Events "

    'Load form
    Private Sub POForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow
        GridView2.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow
        GridView3.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        InitPRList()
        InitSupplierList()
        InitPRItemList()

        LoadPRFrmDB()

    End Sub

    'Add button
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ButtonClick(GridView1, dataPRGrid2, True)
    End Sub

    'Remove button
    Private Sub RemoveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBtn.Click
        ButtonClick(GridView2, dataPRGrid, False)
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
            End If

        End If

    End Sub

    'Generate PO button
    Private Sub GeneratePOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePOBtn.Click
        'SavePO(Supplier_ID)
        GetWindowsValue()

        If ValidData() Then

            Dim Supplier_ID As Integer
            Dim i As Integer
            Dim dr As DataRow
            Dim item As Object
            Dim msg As String

            If GridView3.RowCount <> 0 Then
                For i = 0 To GridView3.RowCount - 1
                    dr = GridView3.GetDataRow(i)

                    item = dr.ItemArray
                    Supplier_ID = item(0)

                    SavePO(Supplier_ID)

                    msg = msg & Chr(13) & "     " & PO_NO
                    'LoadPRItem(PR_ID, PR_No, Supplier_ID)
                Next
            End If

            MessageBox.Show("Following POs had been generate : " & msg, "PO Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DisabledAll()
        End If
    End Sub

    'Close PO button
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
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
        AddColumn(dataSupplierGrid, "Tel", System.Type.GetType("System.String"), True)
        AddColumn(dataSupplierGrid, "Contact Person", System.Type.GetType("System.String"), True)

        dataSupplierGrid.EndInit()

        SupplierGrid.DataSource = dataSupplierGrid
        SupplierGrid.DefaultView.PopulateColumns()
        GridView3.BestFitColumns()
        GridView3.Columns.Item(0).VisibleIndex = -1 'hide 1st column

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
        AddColumn(dataPRItemGrid, "Qty to Order", System.Type.GetType("System.Int32"), True)

        dataPRItemGrid.EndInit()

        PRItemGrid.DataSource = dataPRItemGrid
        PRItemGrid.MainView.PopulateColumns()

        GridView4.BestFitColumns()
        GridView4.Columns.Item(0).VisibleIndex = -1
        GridView4.Columns.Item(1).VisibleIndex = -1
        GridView4.Columns.Item(2).VisibleIndex = -1
        GridView4.Columns.Item(3).VisibleIndex = -1
        GridView4.Columns.Item(4).VisibleIndex = -1
    End Sub

#End Region

#Region " Other Code "

    Private Function CreatePONo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("PO")
        End With
        CreatePONo = "PO" & Year(Now) & DocumentNo
    End Function

    'Change date format
    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then
            pDate = Date.Parse(pInputDate)
            tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
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

                LoadSupplier()

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
        ShipmentDateEdit.Enabled = False

        'Buttons
        AddAllBtn.Enabled = False
        RemoveAllBtn.Enabled = False
        AddBtn.Enabled = False
        RemoveBtn.Enabled = False
        GeneratePOBtn.Enabled = False
        RemoveSupBtn.Enabled = False

    End Sub
#End Region

#Region "Database Management - Loading"

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
            If .LoadPRList(ds, , "40") Then
                If Not ds Is Nothing Then
                    Try
                        Dim oRow As DataRow
                        Dim i As Integer = 0
                        Dim tempPR_Date As String = ""

                        For Each oRow In ds.Tables(0).Rows
                            i = i + 1

                            tempPR_Date = ChangeDateFormat(oRow("PR_Date"))
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

            With New BusinessRules.POBusRules.POBusLogic
                If .LoadPRSupplierList(ds, "40", SQLStr) Then
                    If Not ds Is Nothing Then
                        Try
                            Dim oRow As DataRow
                            Dim i = 0
                            For Each oRow In ds.Tables(0).Rows
                                i = i + 1

                                dataSupplierGrid.Rows.Add(New Object() {oRow("Supplier_ID"), oRow("Supplier_Name"), oRow("Tel"), oRow("Contact_Person")})
                            Next

                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End If
                End If
            End With

        End If

    End Sub

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

            With New BusinessRules.POBusRules.POBusLogic
                If .LoadPRLineList(ds, pPR_ID) Then
                    If Not ds Is Nothing Then
                        Try

                            Dim oRow As DataRow
                            Dim i As Integer = 0
                            Dim tempDeliveryDate As String = ""
                            For Each oRow In ds.Tables(0).Rows
                                i = i + 1

                                dataPRItemGrid.Rows.Add(New Object() {pPR_ID, oRow("PR_Line"), oRow("Supplier_ID"), oRow("Product_ID"), _
                                                    oRow("Category_ID"), pPR_No, oRow("Supplier_Name"), oRow("ProductName"), oRow("Order_Qty")})
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

    Private Sub SavePO(ByVal pSupplier_ID As String)

        With New BusinessRules.POBusRules.POHeaderBusLogic
            PO_NO = CreatePONo()
            Status = "20"
            .PO_NO = PO_NO
            .Supplier_ID = pSupplier_ID
            .Status = Status
            .Shipment_Date = Shipment_Date
            .UserID = UserID


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

        Dim i
        Dim dr As DataRow
        Dim items As Object()
        Dim ds As DataSet

        For i = 0 To GridView4.RowCount - 1

            dr = GridView4.GetDataRow(i)
            items = dr.ItemArray

            If items(2) = pSupplier_ID Then
                PR_ID = items(0)
                PR_Line = items(1)
                Product_ID = items(3)
                Category_ID = items(4)
                Order_Qty = items(8)

                With New BusinessRules.POBusRules.POLineBusLogic

                    .PO_ID = pPO_ID
                    .Category_ID = Category_ID
                    .Product_ID = Product_ID
                    .Order_Qty = Order_Qty
                    .Confirm_Qty = 0
                    .PR_ID = PR_ID
                    .PR_Line = PR_Line

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

        Next

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

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If Shipment_Date = Nothing Or Shipment_Date = "" Then
            ErrorMessage = ErrorMessage & " Shipment Date" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With

        ElseIf GridView2.RowCount = 0 Then
            MessageBox.Show("Please select at least 1 PR", "Error - No PR selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DataOK_flag = False

        ElseIf GridView3.RowCount = 0 Then
            MessageBox.Show("Please select at least 1 supplier", "Error - No PR selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DataOK_flag = False
        End If

        Return DataOK_flag

    End Function

#End Region

#Region " Code - Set/Get Window Values"

    'Get Window Values
    Private Sub GetWindowsValue()


        If ShipmentDateEdit.Text <> "" Then
            Shipment_Date = ShipmentDateEdit.DateTime.Day & " " & MonthName(ShipmentDateEdit.DateTime.Month) & " " & ShipmentDateEdit.DateTime.Year
        Else
            Shipment_Date = ""
        End If


    End Sub

#End Region

    Private Sub POForm2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PO?", "PO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            CloseTabPage()
        Else
            e.Cancel = True
        End If
    End Sub
End Class
