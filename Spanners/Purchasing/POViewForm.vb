Imports DevExpress.XtraEditors.Controls
Imports System.Collections

Public Class POViewForm
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pPO_ID As String = "0")
        MyBase.New()
        FormStatus = pStatus

        If pPO_ID <> "0" Then
            PO_ID = pPO_ID
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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents TabControl1 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents POItemTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PRGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GSTCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PaymentTermsTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CurrencyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SupplierTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NotesTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RemarksTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PRTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PO_NoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DeliveryDateTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GrpTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PODateTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreaterTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StatusTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeliverToTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DiscountTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents POItemGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents POTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XtraButton2 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents XtraButton3 As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(POViewForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.POTitle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.DeliverToTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.StatusTxt = New DevExpress.XtraEditors.TextEdit
        Me.CreaterTxt = New DevExpress.XtraEditors.TextEdit
        Me.PODateTxt = New DevExpress.XtraEditors.TextEdit
        Me.GrpTxt = New DevExpress.XtraEditors.TextEdit
        Me.DeliveryDateTxt = New DevExpress.XtraEditors.TextEdit
        Me.DiscountTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PO_NoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.NotesTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.RemarksTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GSTCheck = New DevExpress.XtraEditors.CheckEdit
        Me.PaymentTermsTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.CurrencyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.SupplierTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabControl1 = New Crownwood.Magic.Controls.TabControl
        Me.POItemTab = New Crownwood.Magic.Controls.TabPage
        Me.POItemGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PRTab = New Crownwood.Magic.Controls.TabPage
        Me.PRGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.XtraButton2 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.XtraButton3 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.POTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverToTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreaterTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODateTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDateTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PO_NoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GSTCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentTermsTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.POItemTab.SuspendLayout()
        CType(Me.POItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRTab.SuspendLayout()
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 552)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.POTitle)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DeliverToTxt)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.StatusTxt)
        Me.GroupBox3.Controls.Add(Me.CreaterTxt)
        Me.GroupBox3.Controls.Add(Me.PODateTxt)
        Me.GroupBox3.Controls.Add(Me.GrpTxt)
        Me.GroupBox3.Controls.Add(Me.DeliveryDateTxt)
        Me.GroupBox3.Controls.Add(Me.DiscountTxt)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.PO_NoTxt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.NotesTxt)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.RemarksTxt)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 192)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'POTitle
        '
        Me.POTitle.Location = New System.Drawing.Point(96, 160)
        Me.POTitle.Name = "POTitle"
        Me.POTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.POTitle.Properties.ReadOnly = True
        Me.POTitle.Size = New System.Drawing.Size(200, 21)
        Me.POTitle.TabIndex = 90
        Me.POTitle.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Title:"
        Me.Label6.Visible = False
        '
        'DeliverToTxt
        '
        Me.DeliverToTxt.Enabled = False
        Me.DeliverToTxt.Location = New System.Drawing.Point(96, 112)
        Me.DeliverToTxt.Name = "DeliverToTxt"
        Me.DeliverToTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliverToTxt.Properties.MaxLength = 200
        Me.DeliverToTxt.Properties.ReadOnly = True
        Me.DeliverToTxt.Size = New System.Drawing.Size(200, 40)
        Me.DeliverToTxt.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label2.Location = New System.Drawing.Point(8, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 40)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Deliver To :"
        '
        'StatusTxt
        '
        Me.StatusTxt.Enabled = False
        Me.StatusTxt.Location = New System.Drawing.Point(400, 16)
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusTxt.Properties.ReadOnly = True
        Me.StatusTxt.Size = New System.Drawing.Size(136, 19)
        Me.StatusTxt.TabIndex = 82
        '
        'CreaterTxt
        '
        Me.CreaterTxt.Enabled = False
        Me.CreaterTxt.Location = New System.Drawing.Point(400, 40)
        Me.CreaterTxt.Name = "CreaterTxt"
        Me.CreaterTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CreaterTxt.Properties.ReadOnly = True
        Me.CreaterTxt.Size = New System.Drawing.Size(136, 19)
        Me.CreaterTxt.TabIndex = 81
        '
        'PODateTxt
        '
        Me.PODateTxt.Enabled = False
        Me.PODateTxt.Location = New System.Drawing.Point(96, 40)
        Me.PODateTxt.Name = "PODateTxt"
        Me.PODateTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PODateTxt.Size = New System.Drawing.Size(136, 19)
        Me.PODateTxt.TabIndex = 80
        '
        'GrpTxt
        '
        Me.GrpTxt.Enabled = False
        Me.GrpTxt.Location = New System.Drawing.Point(96, 64)
        Me.GrpTxt.Name = "GrpTxt"
        Me.GrpTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GrpTxt.Size = New System.Drawing.Size(136, 19)
        Me.GrpTxt.TabIndex = 79
        '
        'DeliveryDateTxt
        '
        Me.DeliveryDateTxt.Location = New System.Drawing.Point(96, 88)
        Me.DeliveryDateTxt.Name = "DeliveryDateTxt"
        Me.DeliveryDateTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliveryDateTxt.Properties.ReadOnly = True
        Me.DeliveryDateTxt.Size = New System.Drawing.Size(136, 19)
        Me.DeliveryDateTxt.TabIndex = 78
        '
        'DiscountTxt
        '
        Me.DiscountTxt.Location = New System.Drawing.Point(400, 64)
        Me.DiscountTxt.Name = "DiscountTxt"
        Me.DiscountTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DiscountTxt.Properties.ReadOnly = True
        Me.DiscountTxt.Size = New System.Drawing.Size(136, 19)
        Me.DiscountTxt.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(312, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Status :"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Group :"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(312, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Recorded By :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "PO Date :"
        '
        'PO_NoTxt
        '
        Me.PO_NoTxt.Location = New System.Drawing.Point(96, 16)
        Me.PO_NoTxt.Name = "PO_NoTxt"
        Me.PO_NoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PO_NoTxt.Properties.MaxLength = 10
        Me.PO_NoTxt.Properties.ReadOnly = True
        Me.PO_NoTxt.Size = New System.Drawing.Size(136, 21)
        Me.PO_NoTxt.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "PO No. :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Delivery Date :"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(312, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Discount :"
        '
        'NotesTxt
        '
        Me.NotesTxt.Location = New System.Drawing.Point(400, 136)
        Me.NotesTxt.Name = "NotesTxt"
        Me.NotesTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesTxt.Properties.MaxLength = 200
        Me.NotesTxt.Properties.ReadOnly = True
        Me.NotesTxt.Size = New System.Drawing.Size(208, 48)
        Me.NotesTxt.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label14.Location = New System.Drawing.Point(320, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 40)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Notes - as an internal memo :"
        '
        'RemarksTxt
        '
        Me.RemarksTxt.Location = New System.Drawing.Point(400, 88)
        Me.RemarksTxt.Name = "RemarksTxt"
        Me.RemarksTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RemarksTxt.Properties.MaxLength = 200
        Me.RemarksTxt.Properties.ReadOnly = True
        Me.RemarksTxt.Size = New System.Drawing.Size(208, 40)
        Me.RemarksTxt.TabIndex = 48
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label15.Location = New System.Drawing.Point(312, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 40)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Remarks - To appear on document :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GSTCheck)
        Me.GroupBox2.Controls.Add(Me.PaymentTermsTxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CurrencyTxt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.SupplierTxt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 96)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'GSTCheck
        '
        Me.GSTCheck.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.GSTCheck.Location = New System.Drawing.Point(312, 40)
        Me.GSTCheck.Name = "GSTCheck"
        Me.GSTCheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GSTCheck.Properties.Caption = "GST"
        Me.GSTCheck.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.InactiveBorder, System.Drawing.SystemColors.WindowText)
        Me.GSTCheck.Size = New System.Drawing.Size(48, 15)
        Me.GSTCheck.TabIndex = 81
        '
        'PaymentTermsTxt
        '
        Me.PaymentTermsTxt.Enabled = False
        Me.PaymentTermsTxt.Location = New System.Drawing.Point(104, 64)
        Me.PaymentTermsTxt.Name = "PaymentTermsTxt"
        Me.PaymentTermsTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PaymentTermsTxt.Properties.Enabled = False
        Me.PaymentTermsTxt.Size = New System.Drawing.Size(176, 19)
        Me.PaymentTermsTxt.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Payment Terms :"
        '
        'CurrencyTxt
        '
        Me.CurrencyTxt.Enabled = False
        Me.CurrencyTxt.Location = New System.Drawing.Point(104, 40)
        Me.CurrencyTxt.Name = "CurrencyTxt"
        Me.CurrencyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrencyTxt.Properties.Enabled = False
        Me.CurrencyTxt.Size = New System.Drawing.Size(176, 19)
        Me.CurrencyTxt.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Currency :"
        '
        'SupplierTxt
        '
        Me.SupplierTxt.Enabled = False
        Me.SupplierTxt.Location = New System.Drawing.Point(104, 16)
        Me.SupplierTxt.Name = "SupplierTxt"
        Me.SupplierTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierTxt.Properties.Enabled = False
        Me.SupplierTxt.Size = New System.Drawing.Size(496, 19)
        Me.SupplierTxt.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Supplier :"
        '
        'TabControl1
        '
        Me.TabControl1.AutoScroll = True
        Me.TabControl1.IDEPixelArea = True
        Me.TabControl1.Location = New System.Drawing.Point(8, 306)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SelectedTab = Me.POItemTab
        Me.TabControl1.Size = New System.Drawing.Size(616, 232)
        Me.TabControl1.TabIndex = 29
        Me.TabControl1.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.POItemTab, Me.PRTab})
        '
        'POItemTab
        '
        Me.POItemTab.AutoScroll = True
        Me.POItemTab.Controls.Add(Me.POItemGrid)
        Me.POItemTab.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.POItemTab.Location = New System.Drawing.Point(0, 0)
        Me.POItemTab.Name = "POItemTab"
        Me.POItemTab.Size = New System.Drawing.Size(616, 207)
        Me.POItemTab.TabIndex = 0
        Me.POItemTab.Title = "View PO Items"
        '
        'POItemGrid
        '
        Me.POItemGrid.EditorsRepository = Me.PersistentRepository1
        Me.POItemGrid.Location = New System.Drawing.Point(8, 8)
        Me.POItemGrid.MainView = Me.GridView1
        Me.POItemGrid.Name = "POItemGrid"
        Me.POItemGrid.Size = New System.Drawing.Size(600, 192)
        Me.POItemGrid.TabIndex = 21
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3})
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit3.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.PreviewLineCount = 2
        Me.GridView1.VertScrollTipFieldName = Nothing
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'PRTab
        '
        Me.PRTab.Controls.Add(Me.PRGrid)
        Me.PRTab.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.PRTab.Location = New System.Drawing.Point(0, 0)
        Me.PRTab.Name = "PRTab"
        Me.PRTab.Selected = False
        Me.PRTab.Size = New System.Drawing.Size(616, 207)
        Me.PRTab.TabIndex = 1
        Me.PRTab.Title = "View PR List"
        Me.PRTab.Visible = False
        '
        'PRGrid
        '
        Me.PRGrid.EditorsRepository = Me.PersistentRepository1
        Me.PRGrid.Location = New System.Drawing.Point(8, 8)
        Me.PRGrid.MainView = Me.GridView2
        Me.PRGrid.Name = "PRGrid"
        Me.PRGrid.Size = New System.Drawing.Size(600, 192)
        Me.PRGrid.TabIndex = 20
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit3
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
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
        Me.CloseBtn.Location = New System.Drawing.Point(568, 568)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 24
        Me.CloseBtn.Text = "&Close"
        '
        'PrintPOBtn
        '
        Me.PrintPOBtn.AutoSize = False
        Me.PrintPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPOBtn.Image = Nothing
        Me.PrintPOBtn.Location = New System.Drawing.Point(16, 568)
        Me.PrintPOBtn.Name = "PrintPOBtn"
        Me.PrintPOBtn.Size = New System.Drawing.Size(72, 32)
        Me.PrintPOBtn.TabIndex = 25
        Me.PrintPOBtn.Text = "Print PO"
        '
        'XtraButton1
        '
        Me.XtraButton1.AutoSize = False
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(96, 568)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(88, 32)
        Me.XtraButton1.TabIndex = 26
        Me.XtraButton1.Text = "Print PO (A4)"
        '
        'XtraButton2
        '
        Me.XtraButton2.AutoSize = False
        Me.XtraButton2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton2.Image = Nothing
        Me.XtraButton2.Location = New System.Drawing.Point(480, 568)
        Me.XtraButton2.Name = "XtraButton2"
        Me.XtraButton2.Size = New System.Drawing.Size(72, 32)
        Me.XtraButton2.TabIndex = 27
        Me.XtraButton2.Text = "Delete"
        '
        'XtraButton3
        '
        Me.XtraButton3.AutoSize = False
        Me.XtraButton3.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton3.Image = Nothing
        Me.XtraButton3.Location = New System.Drawing.Point(376, 568)
        Me.XtraButton3.Name = "XtraButton3"
        Me.XtraButton3.Size = New System.Drawing.Size(88, 32)
        Me.XtraButton3.TabIndex = 28
        Me.XtraButton3.Text = "Revise PO"
        '
        'POViewForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(648, 613)
        Me.Controls.Add(Me.XtraButton3)
        Me.Controls.Add(Me.XtraButton2)
        Me.Controls.Add(Me.XtraButton1)
        Me.Controls.Add(Me.PrintPOBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(80, 80)
        Me.Name = "POViewForm"
        Me.Text = "Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.POTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverToTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreaterTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODateTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDateTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PO_NoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GSTCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentTermsTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.POItemTab.ResumeLayout(False)
        CType(Me.POItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRTab.ResumeLayout(False)
        CType(Me.PRGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"
    Public PO_ID As Integer
    Public PO_No As String
    Public RevNo As Integer
    Public PO_Title As String
    Public PO_Date As String
    Public Shipment_Date As String
    Public Supplier_ID As Integer

    Public Status As String
    Public StatusName As String

    Public Grp As String

    Public DiscountType As String
    Public Discount As Integer

    Public Remarks As String
    Public Notes As String
    Public DeliverTo As String

    Public UserID As Integer
    Public UserName As String

    Dim dataPRGrid = New DataTable("ColumnsTable")
    Dim dataPOItemGrid = New DataTable("ColumnsTable")

    Public FormStatus As String

    'Supplier Info
    Public Supplier_Name As String
    Public Currency As String
    Public Payment_Term As String
    Public GST_Flg As String


#End Region

#Region " Events "

    'Load form
    Private Sub POForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow
        TabControl1.TabPages.RemoveAt(1)
        LoadPOFrmDB()
        GetUser()
        LoadSupplier()

        InitPOItemList()
        LoadPOItem()

        SetWindowsValue()

    End Sub

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
        GridView2.BestFitColumns()
        GridView2.Columns.Item(0).VisibleIndex = -1 'hide 1st column


    End Sub

    Private Sub InitPOItemList()
        dataPOItemGrid.BeginInit()
        AddColumn(dataPOItemGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataPOItemGrid, "Qty", System.Type.GetType("System.Int32"), True)
        AddColumn(dataPOItemGrid, "UOM", System.Type.GetType("System.String"), True)
        AddColumn(dataPOItemGrid, "Price", System.Type.GetType("System.Double"), True)
        AddColumn(dataPOItemGrid, "WO No", System.Type.GetType("System.String"), True)
        AddColumn(dataPOItemGrid, "Delivery", System.Type.GetType("System.String"), True)
        AddColumn(dataPOItemGrid, "Status", System.Type.GetType("System.String"), True)

        dataPOItemGrid.EndInit()

        POItemGrid.DataSource = dataPOItemGrid
        POItemGrid.MainView.PopulateColumns()

        GridView1.BestFitColumns()

        'Qty
        GridView1.Columns.Item(1).Width = 45
        'UOM
        GridView1.Columns.Item(2).Width = 80
        'Price
        GridView1.Columns.Item(3).Width = 55
        'Work No
        GridView1.Columns.Item(4).Width = 60
        'Delivery
        GridView1.Columns.Item(5).Width = 70
        'Status
        GridView1.Columns.Item(6).Width = 60
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

    Private Sub CloseTabPage()
        'Me.Close()
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

#End Region

#Region " Database Management"
    Private Sub LoadPOFrmDB()
        Dim ds As DataSet
        Dim dsParent As DataSet
        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .Load(PO_ID) Then
                PO_No = .PO_NO
                RevNo = .RevNo
                If Not IsDBNull(RevNo) Then
                    If RevNo > 0 Then
                        PO_No = .PO_NO & "/R" & RevNo
                    End If
                End If
                PO_Title = .PO_Title
                Shipment_Date = ChangeDateFormat(.Shipment_Date)
                Supplier_ID = .Supplier_ID
                Status = .Status
                Grp = .Grp
                DiscountType = .DiscountType
                Discount = .Discount
                Remarks = .Remarks
                Notes = .Notes
                DeliverTo = .DeliverTo
                UserID = .UserID
                PO_Date = ChangeDateFormat(.Transact_Date)
            End If
        End With
    End Sub

    'Load Supplier Info
    Private Sub LoadSupplier()

        Dim Currency_ID As Integer
        'Load supplier
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .Load(Supplier_ID) Then
                Supplier_Name = .Supplier_Name
                GST_Flg = .GST_Flg
                Payment_Term = .Payment_Term

                If .Currency_ID <> 0 And .Currency_ID <> Nothing Then
                    Currency_ID = .Currency_ID
                    With New BusinessRules.CurrencyBusRules.CurrencyBusLogic
                        If .Load(Currency_ID) Then
                            Currency = .CurrencyName
                        End If
                    End With
                End If

            End If
        End With

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

    Private Sub GetUser()
        Dim ds As DataSet
        Dim userGrp As Integer

        With New BusinessRules.PRBusRules.PRBusLogic
            If .GetUser(ds, UserID) Then
                If Not ds Is Nothing Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)
                    UserName = row("Name").ToString()

                    If Not row.IsNull("Department_ID") Then
                        If .LoadUserGrpList(ds, row("Department_ID")) Then
                            row = ds.Tables(0).Rows(0)
                            If Not row.IsNull("Name") Then
                                Grp = row("Name").ToString()
                            End If
                        Else
                            Grp = ""
                        End If
                    End If
                End If
            End If

        End With
    End Sub

    Private Sub LoadPOItem()

        If PO_ID <> Nothing And PO_ID <> 0 Then
            Dim ds As DataSet

            Dim Requester
            Dim Approver
            Dim Category
            Dim Status
            Dim Grp
            Dim PR_Date

            With New BusinessRules.POBusRules.POLineBusLogic
                If .LoadPOItemList(ds, PO_ID) Then
                    If Not ds Is Nothing Then
                        Try

                            Dim oRow As DataRow
                            Dim i As Integer = 0
                            Dim tempDeliveryDate As String = ""
                            For Each oRow In ds.Tables(0).Rows
                                i = i + 1

                                Select Case (oRow("Status"))
                                    Case "10" : Status = "Preparing"
                                    Case "20" : Status = "Approved"
                                    Case "30" : Status = "Confirmed"
                                    Case "40" : Status = "Revised"
                                    Case "50" : Status = "Cancel"
                                    Case "60" : Status = "Lost"
                                    Case "90" : Status = "Delivered"
                                End Select

                                dataPOItemGrid.Rows.Add(New Object() {oRow("ProductName"), _
                                                                        oRow("Order_Qty"), _
                                                                        oRow("UOM"), _
                                                                        oRow("Price"), _
                                                                        oRow("WO_No"), _
                                                                        oRow("Delivery_Date"), _
                                                                        Status})
                            Next

                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End If
                End If
            End With
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

        With New BusinessRules.POBusRules.POBusLogic
            If .LoadPRList(ds, Supplier_ID, "40") Then
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

#End Region

#Region " Grid Code "

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub


#End Region

#Region " Code - Set/Get Window Values"

    'Set windows values
    Private Sub SetWindowsValue()

        StatusName = "Pending"

        PO_NoTxt.Text = Me.PO_No
        StatusTxt.Text = Me.StatusName
        PODateTxt.Text = Me.PO_Date
        DeliveryDateTxt.Text = Me.Shipment_Date
        GrpTxt.Text = Me.Grp
        CreaterTxt.Text = Me.UserName
        DeliverToTxt.Text = Me.DeliverTo
        POTitle.Text = Me.PO_Title
        DiscountTxt.Text = GetDiscount(Me.DiscountType, Me.Discount)
        RemarksTxt.Text = Me.Remarks
        NotesTxt.Text = Me.Notes

        'Supplier Info
        SupplierTxt.Text = Supplier_Name
        CurrencyTxt.Text = Currency

        GSTCheck.CheckState = CheckState.Indeterminate

        If GST_Flg = "1" Then
            GSTCheck.CheckState = CheckState.Checked
        ElseIf GST_Flg = "0" Then
            GSTCheck.CheckState = CheckState.Unchecked
        End If
        PaymentTermsTxt.Text = Payment_Term

        TabControl1.IDEPixelBorder = True

    End Sub

#End Region

    Private Sub POViewForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PO?", "PO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If Result = DialogResult.Yes Then
        CloseTabPage()
        'Else
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub PrintPOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPOBtn.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim PrintTitle As Boolean = False

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New POReportForm(PO_ID, PrintTitle)
        page = New Crownwood.Magic.Controls.TabPage("PO Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton1.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New POReportForm(PO_ID, True)
        page = New Crownwood.Magic.Controls.TabPage("PO Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub XtraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton2.Click

        Dim Result As DialogResult = MessageBox.Show("Confirm delete " & PO_NoTxt.Text & "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If Result = DialogResult.Yes Then
            With New BusinessRules.POBusRules.POHeaderBusLogic
                .Delete(Me.PO_ID)
            End With
            Me.Close()
        End If
    End Sub

    Private Sub XtraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton3.Click
        Dim PONOAssigned As String
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to revise this PO?", "PO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If Result = DialogResult.No Then
            Exit Sub
        End If

        
        With New BusinessRules.POBusRules.POHeaderBusLogic
            
            PONOAssigned = Me.PO_No & "/R" & .GetPOLastRevNo(PO_No) + 1

            'PO_NO = PONo.Text

            .PO_NO = PONOAssigned
            .RevNo = Me.RevNo + 1
            '.PO_Title = POTitle.Text
            .Grp = Grp
            .Supplier_ID = Supplier_ID
            .Status = Status
            .Shipment_Date = Shipment_Date
            .UserID = UserID

            .PO_Title = Me.PO_Title
            .DeliverTo = DeliverTo
            .DiscountType = DiscountType
            .Discount = Discount
            .Remarks = Remarks
            .Notes = Notes

            If Me.GSTCheck.CheckState.Checked Then
                .GST_Flg = 1
            Else
                .GST_Flg = 0
            End If

            'New Record
            PO_ID = .Save()
            SaveItem(PO_ID)
        End With

    End Sub

    Private Sub SaveItem(ByVal pPO_ID As Integer)

    End Sub


End Class
