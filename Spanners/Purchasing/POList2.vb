Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class POList2
    Inherits System.Windows.Forms.Form

    Private gsiSummary As GridSummaryItems

    Public UserID As String = Common.CommonConn.Config.USERID
    Public com As New Common.CommonConn.Config

    Public dataGrid As System.Data.DataTable
    Public Transaction_ID As Integer
    Public FormType As String
    Private DocNo As String
    Private Edited As Boolean
    Private LoadPOID As Integer
    Private Supplier_ID As Integer

    Private AddButtonOldState As Boolean
    Private EditButtonOldState As Boolean
    Private DeleteButtonOldState As Boolean
    Private Button4OldState As Boolean
    Private GridControl1OldState As Boolean

    Private Title_TextEdit_Old As String
    Private ShipmentDateEdit_Old As DateTime
    Private DeliverToTxt_Old As String
    Private DiscountTypeLookup_Old As String
    Private DiscountSpin_Old As String
    Private GSTCheck_Old As System.Windows.Forms.CheckState
    Private NotesTxt_Old As String
    Private MemoEdit_Old As String
    
    Private OnLoading As Boolean
    Private FromApprovalForm As Boolean

    Private _SelectedSupplierID As Integer


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        LoadPOID = 0
        _SelectedSupplierID = 0

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        SetYearCombo()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pFormType As String)
        MyBase.New()

        LoadPOID = 0
        FormType = pFormType

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        SetYearCombo()

        'Add any initialization after the InitializeComponent() call
        DisableEntry()

        Edited = False
        OnLoading = False

        Me.InitalUserCombo()

        If FormType = "PO" Then
            Me.SetPOForm()
        End If

        LoadDiscountType()




    End Sub

    Public Sub New(ByVal PO_ID As Integer, Optional ByVal pFromApprovalForm As Boolean = False)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        SetYearCombo()

        'Add any initialization after the InitializeComponent() call
        DisableEntry()

        Edited = False
        OnLoading = False
        FromApprovalForm = pFromApprovalForm

        Me.InitalUserCombo()

        LoadPOID = PO_ID
        LoadPO(LoadPOID)

        LoadDiscountType()

        Button1.Visible = False 'hide new
        Button4.Visible = False 'hide delete

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SRVNoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents AddMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents EditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents NewDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Print2_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Remarks_MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LastUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Print_Button As System.Windows.Forms.Button
    Friend WithEvents Reserve_Button As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Title_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PaymentTermsTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CurrencyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SupplierTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NotesTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DeliverToTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DiscountSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DiscountTypeLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GSTCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridPanel As System.Windows.Forms.Panel
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LookUpEdit_Year As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Printa4_Button As System.Windows.Forms.Button
    Friend WithEvents Shipment_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents SupplierCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TopPanel = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Shipment_DateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Remarks_MemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.NotesTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PaymentTermsTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.CurrencyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.SupplierTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LastUpdate = New System.Windows.Forms.TextBox
        Me.GSTCheck = New DevExpress.XtraEditors.CheckEdit
        Me.Title_TextEdit = New DevExpress.XtraEditors.TextEdit
        Me.DiscountSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.DiscountTypeLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.DeliverToTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.NewDoc = New DevExpress.XtraEditors.TextEdit
        Me.SRVNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.SupplierCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.LookUpEdit_Year = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button6 = New System.Windows.Forms.Button
        Me.EditButton = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Printa4_Button = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Print_Button = New System.Windows.Forms.Button
        Me.Print2_Button = New System.Windows.Forms.Button
        Me.Reserve_Button = New System.Windows.Forms.Button
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.AddMenu = New System.Windows.Forms.MenuItem
        Me.EditMenu = New System.Windows.Forms.MenuItem
        Me.DeleteMenu = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GridPanel = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.TopPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Shipment_DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remarks_MemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PaymentTermsTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSTCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title_TextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountTypeLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverToTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NewDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRVNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.Panel5)
        Me.TopPanel.Controls.Add(Me.Panel1)
        Me.TopPanel.Controls.Add(Me.Panel4)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(806, 278)
        Me.TopPanel.TabIndex = 0
        Me.TopPanel.TabStop = True
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.Shipment_DateEdit)
        Me.Panel5.Controls.Add(Me.Remarks_MemoEdit)
        Me.Panel5.Controls.Add(Me.NotesTxt)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.LastUpdate)
        Me.Panel5.Controls.Add(Me.GSTCheck)
        Me.Panel5.Controls.Add(Me.Title_TextEdit)
        Me.Panel5.Controls.Add(Me.DiscountSpin)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.DiscountTypeLookup)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.DeliverToTxt)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(706, 244)
        Me.Panel5.TabIndex = 84
        '
        'Shipment_DateEdit
        '
        Me.Shipment_DateEdit.DateTime = New Date(CType(0, Long))
        Me.Shipment_DateEdit.Location = New System.Drawing.Point(116, 110)
        Me.Shipment_DateEdit.Name = "Shipment_DateEdit"
        Me.Shipment_DateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Shipment_DateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.Shipment_DateEdit.Properties.MaskData.EditMask = "##/##/####"
        Me.Shipment_DateEdit.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Shipment_DateEdit.Size = New System.Drawing.Size(140, 21)
        Me.Shipment_DateEdit.TabIndex = 83
        '
        'Remarks_MemoEdit
        '
        Me.Remarks_MemoEdit.Location = New System.Drawing.Point(60, 180)
        Me.Remarks_MemoEdit.Name = "Remarks_MemoEdit"
        Me.Remarks_MemoEdit.Size = New System.Drawing.Size(220, 48)
        Me.Remarks_MemoEdit.TabIndex = 8
        '
        'NotesTxt
        '
        Me.NotesTxt.Location = New System.Drawing.Point(358, 180)
        Me.NotesTxt.Name = "NotesTxt"
        Me.NotesTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesTxt.Properties.MaxLength = 200
        Me.NotesTxt.Size = New System.Drawing.Size(204, 48)
        Me.NotesTxt.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label9.Location = New System.Drawing.Point(288, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 40)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Notes - as an internal memo :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PaymentTermsTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CurrencyTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.SupplierTxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 72)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Info"
        '
        'PaymentTermsTxt
        '
        Me.PaymentTermsTxt.Location = New System.Drawing.Point(260, 46)
        Me.PaymentTermsTxt.Name = "PaymentTermsTxt"
        Me.PaymentTermsTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PaymentTermsTxt.Properties.ReadOnly = True
        Me.PaymentTermsTxt.Size = New System.Drawing.Size(146, 21)
        Me.PaymentTermsTxt.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(174, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Payment Terms :"
        '
        'CurrencyTxt
        '
        Me.CurrencyTxt.Location = New System.Drawing.Point(88, 46)
        Me.CurrencyTxt.Name = "CurrencyTxt"
        Me.CurrencyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CurrencyTxt.Properties.ReadOnly = True
        Me.CurrencyTxt.Size = New System.Drawing.Size(76, 21)
        Me.CurrencyTxt.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Currency :"
        '
        'SupplierTxt
        '
        Me.SupplierTxt.Location = New System.Drawing.Point(88, 22)
        Me.SupplierTxt.Name = "SupplierTxt"
        Me.SupplierTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SupplierTxt.Properties.ReadOnly = True
        Me.SupplierTxt.Size = New System.Drawing.Size(318, 21)
        Me.SupplierTxt.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Supplier :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Remarks :"
        '
        'LastUpdate
        '
        Me.LastUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastUpdate.Enabled = False
        Me.LastUpdate.Location = New System.Drawing.Point(452, 32)
        Me.LastUpdate.Name = "LastUpdate"
        Me.LastUpdate.Size = New System.Drawing.Size(100, 20)
        Me.LastUpdate.TabIndex = 41
        '
        'GSTCheck
        '
        Me.GSTCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GSTCheck.Location = New System.Drawing.Point(324, 156)
        Me.GSTCheck.Name = "GSTCheck"
        Me.GSTCheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GSTCheck.Properties.Caption = "GST"
        Me.GSTCheck.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.LeftText
        Me.GSTCheck.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.SystemColors.InactiveBorder, System.Drawing.SystemColors.WindowText)
        Me.GSTCheck.Size = New System.Drawing.Size(48, 15)
        Me.GSTCheck.TabIndex = 82
        '
        'Title_TextEdit
        '
        Me.Title_TextEdit.Location = New System.Drawing.Point(62, 80)
        Me.Title_TextEdit.Name = "Title_TextEdit"
        Me.Title_TextEdit.Size = New System.Drawing.Size(498, 21)
        Me.Title_TextEdit.TabIndex = 5
        '
        'DiscountSpin
        '
        Me.DiscountSpin.Location = New System.Drawing.Point(236, 154)
        Me.DiscountSpin.Name = "DiscountSpin"
        Me.DiscountSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DiscountSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DiscountSpin.Size = New System.Drawing.Size(72, 19)
        Me.DiscountSpin.TabIndex = 67
        Me.DiscountSpin.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Title:"
        '
        'DiscountTypeLookup
        '
        Me.DiscountTypeLookup.Location = New System.Drawing.Point(86, 154)
        Me.DiscountTypeLookup.Name = "DiscountTypeLookup"
        Me.DiscountTypeLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DiscountTypeLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DiscountTypeLookup.Properties.NullString = ""
        Me.DiscountTypeLookup.Properties.PopupWidth = 168
        Me.DiscountTypeLookup.Size = New System.Drawing.Size(144, 19)
        Me.DiscountTypeLookup.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 23)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Discount/Add :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(452, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Last updated"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(22, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Delivery Date :"
        '
        'DeliverToTxt
        '
        Me.DeliverToTxt.Location = New System.Drawing.Point(358, 108)
        Me.DeliverToTxt.Name = "DeliverToTxt"
        Me.DeliverToTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliverToTxt.Properties.MaxLength = 200
        Me.DeliverToTxt.Size = New System.Drawing.Size(204, 40)
        Me.DeliverToTxt.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label10.Location = New System.Drawing.Point(264, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 40)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Deliver To :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.NewDoc)
        Me.Panel1.Controls.Add(Me.SRVNoCmb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SupplierCmb)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LookUpEdit_Year)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 34)
        Me.Panel1.TabIndex = 83
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(696, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 34)
        Me.Panel6.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(328, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Revise"
        '
        'NewDoc
        '
        Me.NewDoc.Location = New System.Drawing.Point(44, 6)
        Me.NewDoc.Name = "NewDoc"
        Me.NewDoc.Size = New System.Drawing.Size(210, 21)
        Me.NewDoc.TabIndex = 0
        Me.NewDoc.Visible = False
        '
        'SRVNoCmb
        '
        Me.SRVNoCmb.Location = New System.Drawing.Point(46, 8)
        Me.SRVNoCmb.Name = "SRVNoCmb"
        Me.SRVNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SRVNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SRVNoCmb.Properties.DropDownRows = 50
        Me.SRVNoCmb.Properties.NullString = ""
        Me.SRVNoCmb.Properties.PopupWidth = 600
        Me.SRVNoCmb.Size = New System.Drawing.Size(208, 19)
        Me.SRVNoCmb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PO #:"
        '
        'SupplierCmb
        '
        Me.SupplierCmb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierCmb.Location = New System.Drawing.Point(448, 8)
        Me.SupplierCmb.Name = "SupplierCmb"
        Me.SupplierCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SupplierCmb.Properties.DropDownRows = 50
        Me.SupplierCmb.Properties.NullString = ""
        Me.SupplierCmb.Properties.PopupWidth = 400
        Me.SupplierCmb.Size = New System.Drawing.Size(238, 19)
        Me.SupplierCmb.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(400, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Filter by:"
        '
        'LookUpEdit_Year
        '
        Me.LookUpEdit_Year.Location = New System.Drawing.Point(394, 6)
        Me.LookUpEdit_Year.Name = "LookUpEdit_Year"
        Me.LookUpEdit_Year.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.LookUpEdit_Year.Size = New System.Drawing.Size(75, 21)
        Me.LookUpEdit_Year.TabIndex = 6
        Me.LookUpEdit_Year.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(706, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 278)
        Me.Panel4.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(14, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 46)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Set Delievery Date"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Reload"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Controls.Add(Me.DeleteButton)
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Print2_Button)
        Me.Panel2.Controls.Add(Me.Reserve_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 416)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 51)
        Me.Panel2.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(312, 36)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Unreserve"
        Me.Button6.Visible = False
        '
        'EditButton
        '
        Me.EditButton.Enabled = False
        Me.EditButton.Location = New System.Drawing.Point(270, 14)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Text = "Edit Price"
        Me.EditButton.Visible = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(100, 14)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Delete"
        '
        'AddButton
        '
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(18, 14)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Printa4_Button)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Print_Button)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(584, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 51)
        Me.Panel3.TabIndex = 3
        '
        'Printa4_Button
        '
        Me.Printa4_Button.Enabled = False
        Me.Printa4_Button.Location = New System.Drawing.Point(28, 14)
        Me.Printa4_Button.Name = "Printa4_Button"
        Me.Printa4_Button.Size = New System.Drawing.Size(58, 23)
        Me.Printa4_Button.TabIndex = 2
        Me.Printa4_Button.Text = "Print A4"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(156, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Close"
        '
        'Print_Button
        '
        Me.Print_Button.Enabled = False
        Me.Print_Button.Location = New System.Drawing.Point(92, 14)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(58, 23)
        Me.Print_Button.TabIndex = 0
        Me.Print_Button.Text = "Print"
        '
        'Print2_Button
        '
        Me.Print2_Button.Location = New System.Drawing.Point(394, 34)
        Me.Print2_Button.Name = "Print2_Button"
        Me.Print2_Button.Size = New System.Drawing.Size(75, 23)
        Me.Print2_Button.TabIndex = 2
        Me.Print2_Button.Text = "Rec. Vou"
        Me.Print2_Button.Visible = False
        '
        'Reserve_Button
        '
        Me.Reserve_Button.Location = New System.Drawing.Point(186, 14)
        Me.Reserve_Button.Name = "Reserve_Button"
        Me.Reserve_Button.Size = New System.Drawing.Size(75, 23)
        Me.Reserve_Button.TabIndex = 4
        Me.Reserve_Button.Text = "Add Ad hoc"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EditorsRepository = Me.PersistentRepository1
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(806, 132)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.Text = "GridControl1"
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
        Me.RepositoryItemTextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.BorderStyle = DevExpress.XtraGrid.Views.Grid.ViewBorderStyle.Border3D
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AddMenu, Me.EditMenu, Me.DeleteMenu})
        '
        'AddMenu
        '
        Me.AddMenu.Index = 0
        Me.AddMenu.Text = "Add"
        '
        'EditMenu
        '
        Me.EditMenu.Index = 1
        Me.EditMenu.Text = "Edit"
        Me.EditMenu.Visible = False
        '
        'DeleteMenu
        '
        Me.DeleteMenu.Index = 2
        Me.DeleteMenu.Text = "Delete"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.GridControl1)
        Me.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPanel.Location = New System.Drawing.Point(0, 284)
        Me.GridPanel.Name = "GridPanel"
        Me.GridPanel.Size = New System.Drawing.Size(806, 132)
        Me.GridPanel.TabIndex = 28
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 278)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(806, 6)
        Me.Splitter1.TabIndex = 29
        Me.Splitter1.TabStop = False
        '
        'POList2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(806, 467)
        Me.Controls.Add(Me.GridPanel)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TopPanel)
        Me.Name = "POList2"
        Me.Text = "PO"
        Me.TopPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Shipment_DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remarks_MemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PaymentTermsTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSTCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title_TextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountTypeLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverToTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.NewDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRVNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_Year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Function SetPOForm()
        FormType = "PO"

        Label1.Text = "PO #:"

        LoadPOList()
        LoadSupplierCmb()

    End Function

    Private Sub LoadPOList()
        Dim ds As DataSet

        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing
        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .LoadList(ds, _SelectedSupplierID) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "PO_NO", "PO #", 250, 0, "c")
                    AddListFieldInfoToLookUp(SRVNoCmb, "Supplier_Name", "Supplier Name", 400, 0, "c")
                    AddListFieldInfoToLookUp(SRVNoCmb, "Shipment_Date", "Delivery Date", 250, 0, "d")

                    SRVNoCmb.Properties.LookUpData.KeyField = "PO_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "PO_NO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

    End Sub
    Private Sub LoadSupplierCmb()

        Dim ds As DataSet
        Dim dr As DataRow

        SupplierCmb.Properties.LookUpData.ListFields.Clear()
        SupplierCmb.Properties.LookUpData.DataSource = Nothing
        SupplierCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            'Add <All Suppliers>'

            'ds.Tables(0).Rows.Add()
            If .LoadList(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SupplierCmb.Properties.LookUpData.ListFields.Clear()

                    AddListFieldInfoToLookUp(SupplierCmb, "Supplier_Name", 200, 0, "")

                    SupplierCmb.Properties.LookUpData.KeyField = "Supplier_ID"
                    SupplierCmb.Properties.LookUpData.DisplayField = "Supplier_Name"
                    SupplierCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                    If Supplier_ID <> Nothing Then
                        SupplierCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Supplier_ID, 0, 0, 0})
                    End If

                End If
            End If
        End With

    End Sub

    Private Sub StockOutSRVForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'LoadPO(LoadPOID)
        'InitItemList()
        'DefaultGridView()

        Me.SRVNoCmb.Focus()

    End Sub

    Private Sub DefaultGridView()

        GridView1.Columns("Product").Width = 150
        GridView1.Columns("Description").Width = 143
        GridView1.Columns("Unit").Width = 50
        GridView1.Columns("Qty Ord.").Width = 50
        GridView1.Columns("Del. Date").Width = 113
        GridView1.Columns("UPrice").Width = 50

    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal caption As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, caption, width, alignment, format)
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Stat As Boolean

        Stat = False

        If Button1.Text = "Revise" Then
            Return
        End If

        If Button1.Text = "Revise" Then

            DocNo = CreateDocNo()
            NewDoc.Properties.ReadOnly = True
            NewDoc.Text = DocNo
            Me.NewDoc.Visible = True
            NewDoc.Focus()
            Button1.Text = "Ok"
            Button4.Text = "Cancel"

            Me.Title_TextEdit.Text = ""
            Me.Remarks_MemoEdit.Text = ""
            Me.NotesTxt.Text = ""
            Me.DeliverToTxt.Text = ""
            Me.Shipment_DateEdit.DateTime = Nothing
            Me.DiscountTypeLookup.Properties.LookUpData.KeyValue = Nothing
            Me.LastUpdate.Text = ""


            Me.GridControl1OldState = GridControl1.Enabled
            Button4OldState = Button4.Enabled
            AddButtonOldState = AddButton.Enabled
            DeleteButtonOldState = DeleteButton.Enabled
            EditButtonOldState = EditButton.Enabled

            Button4.Enabled = True
            GridControl1.Enabled = False
            AddButton.Enabled = False
            DeleteButton.Enabled = False
            Reserve_Button.Enabled = False
            EditButton.Enabled = False
            Print2_Button.Enabled = False

            'Me.Title_TextEdit.Enabled = True
            'Me.Remarks_MemoEdit.Enabled = True
            'Me.ReqByLookup.Enabled = True
            'Me.WO_RadioButton.Enabled = True
            'Me.OC_RadioButton.Enabled = True
            'Me.FT_RadioButton.Enabled = True
            'Me.ST_RadioButton.Enabled = True

            Me.WriteEntry()

        Else
            If Button1.Text = "Update" Then
                Stat = UpdatePO()
                NewDoc.Visible = False
                Button1.Text = "Revise"
                'Button4.Visible = False
                Button4.Text = "Delete"
                GridControl1.Enabled = True
                AddButton.Enabled = True
                AddMenu.Enabled = True

                Me.NewDoc.Visible = False
                Me.NewDoc.Properties.ReadOnly = False
                Me.NewDoc.Text = ""

            Else
                Stat = Me.CreateNewDoc()
                If Stat = True Then
                    LoadPO(LoadPOID)
                    NewDoc.Visible = False
                    Button1.Text = "Revise"
                    'Button4.Visible = False
                    Button4.Text = "Delete"
                    GridControl1.Enabled = True
                    Print_Button.Enabled = True
                    Printa4_Button.Enabled = True
                    AddButton.Enabled = True
                    AddMenu.Enabled = True
                    AddMenu_Click(sender, e)
                End If
            End If
        End If

        'SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewPO()
        'NEW SRV
        Dim LastID As Integer
        With New BusinessRules.POBusRules.POHeaderBusLogic
            .PO_NO = DocNo
            .UserID = UserID
            .Grp = FormType

            .Title = Me.Title_TextEdit.Text

            .Remarks = Me.Remarks_MemoEdit.Text
            .UserID = UserID

            LastID = .Save()

            With New BusinessRules.CommonBusRules.CommonLogic
                If FormType = "PO" Then
                    .UpdateDocumentNextNumber("PO", Year(Now))
                End If
            End With


        End With

        Dim ds As DataSet
        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .LoadList(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "PO_NO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "PO_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "PO_NO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        'SRVNoCmb.Text = SRVNO
        SRVNoCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {LastID, 0, 0, 0})


    End Sub

    Private Function CreateDocNo() As String
        CreateDocNo = ""
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub StockOutSRVForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub SRVNoCmb_ValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles SRVNoCmb.ValueChanging

    End Sub

    Private Sub SRVNoCmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SRVNoCmb.ValueChanged

    End Sub


    Private Sub InitItemList()

        dataGrid = New DataTable("ColumnsTable")
        dataGrid.BeginInit()

        AddColumn(dataGrid, "PO_Line", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Product_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Description", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Unit", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Qty Ord.", System.Type.GetType("System.Double"), True)
        AddColumn(dataGrid, "Del. Date", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "UPrice", System.Type.GetType("System.Double"), True)


        dataGrid.EndInit()

    End Sub

    Private Sub AssignSummaryItemsTo(ByVal fromGsi As GridSummaryItems, ByVal toGsi As GridSummaryItems)
        If toGsi Is Nothing Or fromGsi Is Nothing Then Return
        toGsi.Clear()
        Dim si As GridSummaryItem
        Dim i As Integer
        For i = 0 To fromGsi.Count - 1
            si = fromGsi(i)
            toGsi.Add(si.SummaryType, si.FieldName, si.ShowInColumn)
            toGsi(i).DisplayFormat = si.DisplayFormat
        Next
    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data1.Columns.Add(col)
    End Sub
    Public Sub LoadPOItem()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim oRow As DataRow
        Dim i As Integer = 0
        Dim Status As String

        InitItemList()
        If Not SRVNoCmb.Properties.LookUpData.KeyValue Is Nothing Or LoadPOID <> 0 Then
            Dim POLine As New BusinessRules.POBusRules.POLineBusLogic

            If LoadPOID <> 0 Then
                POLine.LoadList(ds, LoadPOID)
            Else
                POLine.LoadList(ds, SRVNoCmb.Properties.LookUpData.KeyValue)

            End If

            For Each oRow In ds.Tables(0).Rows
                dataGrid.Rows.Add(New Object() { _
                oRow("PO_Line_ID"), _
                oRow("Product_ID"), _
                oRow("ProductName"), _
                oRow("Description"), _
                oRow("UnitName"), _
                oRow("Order_Qty"), _
                oRow("Delivery_Date"), _
                oRow("Unit_Price")})
            Next

            GridControl1.DataSource = dataGrid
            GridControl1.DefaultView.PopulateColumns()

            'GridView1.BestFitColumns()
            Me.DefaultGridView()
            GridView1.Columns.Item(0).VisibleIndex = -1    'hide column
            GridView1.Columns.Item(1).VisibleIndex = -1    'hide column

        End If

        AddButton.Enabled = True
        AddMenu.Enabled = True
        GridControl1.Enabled = True
        Button4.Enabled = True

        Me.Title_TextEdit.Enabled = True
        Me.Remarks_MemoEdit.Enabled = True
        Me.NotesTxt.Enabled = True
        GSTCheck.Enabled = True
        Me.DiscountTypeLookup.Enabled = True
        DiscountSpin.Enabled = True
        DeliverToTxt.Enabled = True
        Shipment_DateEdit.Enabled = True


        GridView1.Columns("Product").SummaryItem.SummaryType = SummaryItemType.Count

        GridView1.ViewOptions = GridView1.ViewOptions Or ViewOptionsFlags.ShowFooter


        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            GridClick()
            DeleteButton.Enabled = True
            Reserve_Button.Enabled = True
            Me.DeleteMenu.Enabled = True
            EditButton.Enabled = True
            Me.EditMenu.Enabled = True
            Print2_Button.Enabled = True
        Else
            EditButton.Enabled = False
            Me.EditMenu.Enabled = False
            DeleteButton.Enabled = False
            Reserve_Button.Enabled = False
            Me.DeleteMenu.Enabled = False
        End If

    End Sub

    Public Sub UpdateDate()
        With New BusinessRules.POBusRules.POHeaderBusLogic

            If .Load(SRVNoCmb.Properties.LookUpData.KeyValue) Then
                Me.LastUpdate.Text = ChangeDateFormat(.Transact_Date)
            End If
        End With

    End Sub

    Public Sub LoadPO(Optional ByVal PO_ID As Integer = 0)
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim LoadPOIDs As String

        OnLoading = True

        InitItemList()
        Me.Title_TextEdit.Text = ""
        Me.Remarks_MemoEdit.Text = ""
        Me.NotesTxt.Text = ""
        Me.DeliverToTxt.Text = ""
        Shipment_DateEdit.DateTime = Nothing
        Me.DiscountTypeLookup.Properties.LookUpData.KeyValue = Nothing
        Me.LastUpdate.Text = ""

        If (Not SRVNoCmb.Properties.LookUpData.KeyValue Is Nothing) Or PO_ID <> 0 Then

            'If .GetStockTransactionSRV(ds, ) Then
            With New BusinessRules.POBusRules.POHeaderBusLogic
                If PO_ID <> 0 Then
                    LoadPOIDs = PO_ID
                Else
                    LoadPOIDs = SRVNoCmb.Properties.LookUpData.KeyValue
                End If
                If .Load(LoadPOIDs) Then

                    If PO_ID <> 0 Then
                        NewDoc.Text = .PO_NO
                        Me.NewDoc.Visible = True
                        Me.NewDoc.Properties.ReadOnly = True
                    End If

                    Me.Title_TextEdit.Text = .Title
                    Supplier_ID = .Supplier_ID
                    SupplierTxt.Text = .SupplierName
                    CurrencyTxt.Text = .SupplierCurrency
                    PaymentTermsTxt.Text = .SupplierPaymentTerms
                    Me.LastUpdate.Text = Me.ChangeDateFormat(.Transact_Date)

                    Me.Remarks_MemoEdit.Text = .Remarks
                    Me.NotesTxt.Text = .Notes

                    Me.DeliverToTxt.Text = .DeliverTo
                    If .Shipment_Date <> "" Then
                        Me.Shipment_DateEdit.DateTime = .Shipment_Date
                    End If

                    DiscountTypeLookup.Properties.LookUpData.KeyValue = .DiscountType
                    DiscountSpin.Text = .Discount

                    If .GST_Flg = 1 Then
                        Me.GSTCheck.CheckState = CheckState.Checked
                    Else
                        Me.GSTCheck.CheckState = CheckState.Unchecked
                    End If

                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    Dim Status As String

                    Dim POLine As New BusinessRules.POBusRules.POLineBusLogic

                    If PO_ID <> 0 Then
                        POLine.LoadList(ds, PO_ID)
                    Else
                        POLine.LoadList(ds, .PO_ID)
                    End If

                    For Each oRow In ds.Tables(0).Rows
                        dataGrid.Rows.Add(New Object() { _
                        oRow("PO_Line_ID"), _
                        oRow("Product_ID"), _
                        oRow("ProductName"), _
                        oRow("Description"), _
                        oRow("UnitName"), _
                        oRow("Order_Qty"), _
                        oRow("Delivery_Date"), _
                        oRow("Unit_Price")})
                    Next

                    GridControl1.DataSource = dataGrid
                    GridControl1.DefaultView.PopulateColumns()

                    'GridView1.BestFitColumns()
                    Me.DefaultGridView()
                    GridView1.Columns.Item(0).VisibleIndex = -1    'hide column
                    GridView1.Columns.Item(1).VisibleIndex = -1    'hide column


                End If

            End With


            AddButton.Enabled = True
            AddMenu.Enabled = True
            GridControl1.Enabled = True
            Button4.Enabled = True
            Me.Print_Button.Enabled = True
            Me.Printa4_Button.Enabled = True

            Me.Title_TextEdit.Enabled = True
            Me.Remarks_MemoEdit.Enabled = True
            Me.NotesTxt.Enabled = True
            GSTCheck.Enabled = True
            Me.DiscountTypeLookup.Enabled = True
            DiscountSpin.Enabled = True
            DeliverToTxt.Enabled = True
            Shipment_DateEdit.Enabled = True


            GridView1.Columns("Product").SummaryItem.SummaryType = SummaryItemType.Count

            GridView1.ViewOptions = GridView1.ViewOptions Or ViewOptionsFlags.ShowFooter


            If GridView1.RowCount() <> 0 Then
                GridView1.MoveFirst()
                GridClick()
                DeleteButton.Enabled = True
                Reserve_Button.Enabled = True
                Me.DeleteMenu.Enabled = True
                EditButton.Enabled = True
                Me.EditMenu.Enabled = True
                Print2_Button.Enabled = True
            Else
                EditButton.Enabled = False
                Me.EditMenu.Enabled = False
                DeleteButton.Enabled = False
                Reserve_Button.Enabled = False
                Me.DeleteMenu.Enabled = False
            End If

            'Me.LoadPOItem()

        Else
            DisableEntry()
        End If

        OnLoading = False
        StoreOld()

    End Sub

    Private Function CheckApprovalAccess() As Boolean
        Return com.CheckUserProfileAccess(com, "PRPendingApproval")
        'Return True
    End Function

    Private Sub DisableEntry()
        AddButton.Enabled = False
        AddMenu.Enabled = False
        DeleteButton.Enabled = False
        Reserve_Button.Enabled = False
        DeleteMenu.Enabled = False
        EditButton.Enabled = False
        EditMenu.Enabled = False
        Me.Print2_Button.Enabled = False
        Button4.Enabled = False
        GridControl1.Enabled = False

        Me.Title_TextEdit.Enabled = False
        Me.Remarks_MemoEdit.Enabled = False
        Me.NotesTxt.Enabled = False
        GSTCheck.Enabled = False
        Me.DiscountTypeLookup.Enabled = False
        DiscountSpin.Enabled = False
        DeliverToTxt.Enabled = False
        Shipment_DateEdit.Enabled = False


    End Sub

    Private Sub ReadOnlyEntry()

        Me.Title_TextEdit.Properties.ReadOnly = True
        Me.Remarks_MemoEdit.Properties.ReadOnly = True


    End Sub

    Private Sub WriteEntry()

        Me.Title_TextEdit.Properties.ReadOnly = False
        Me.Remarks_MemoEdit.Properties.ReadOnly = False

    End Sub

    Private Sub GridClick()
        If GridView1.SelectedRowsCount <> 0 Then

            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then
                Me.Cursor = Cursors.WaitCursor
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                Transaction_ID = items(0)

                Me.Cursor = Cursors.Default

            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_Button.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim PO_Title As String
        Dim PrintTitle As Boolean = False

        Dim page As Crownwood.Magic.Controls.TabPage
        Dim POID As Integer
        If LoadPOID <> 0 Then
            POID = LoadPOID
        Else
            POID = SRVNoCmb.Properties.LookUpData.KeyValue
        End If

        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .Load(POID) Then
                PO_Title = .Title
                If Len(PO_Title) > 0 Then
                    PrintTitle = True
                End If
            End If
        End With

        controlToAdd = New POReportForm(POID, PrintTitle)
        page = New Crownwood.Magic.Controls.TabPage("PO Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GridControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        If SRVNoCmb.Properties.LookUpData.KeyValue Then
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
        End If
    End Sub

    Private Sub AddMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddMenu.Click
        'Dim NewForm As New StockOutLooseForm

        If True Then

            'Dim form As New PrItem3
            'form.Quotation_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            If SRVNoCmb.Properties.LookUpData.KeyValue <> Nothing Then

                Dim form As New PrItem3("PO")
                Form.PO_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                form.Actual_Supplier_ID = Me.Supplier_ID
                form.ShowDialog(Me)

            ElseIf Me.LoadPOID <> 0 Then

                Dim form As New PrItem3("PO")
                form.PO_ID = LoadPOID
                form.Actual_Supplier_ID = Me.Supplier_ID
                form.ShowDialog(Me)

            End If

        End If
        'LoadPO(LoadPOID)
    End Sub

    Private Sub DeleteMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteMenu.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim POLine As Integer = dr(0)
                If POLine > 0 Then
                    Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete PR Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                    If Result = DialogResult.Yes Then
                        DeletePOLine(POLine)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub DeletePOLine(ByVal POLine As Integer)
        Dim p As New BusinessRules.POBusRules.POLineBusLogic
        p.Delete(POLine)
        LoadPO(LoadPOID)
    End Sub

    Private Function CreateNewDoc() As Boolean
        If ValidDocNo() Then
            NewPO()
            Return True
        End If

        Return False
    End Function

    Function ValidDocNo() As Boolean
        ValidDocNo = True

        If NewDoc.Text.Length <= 0 Then
            ValidDocNo = False
            MessageBox.Show("Please enter a new Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewDoc.Focus()
            Exit Function
        End If

        If Duplicate(NewDoc.Text) = False Then
            'NewSRV()
        Else
            MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewDoc.SelectAll()
            NewDoc.Focus()
            ValidDocNo = False
        End If

    End Function


    Function Duplicate(ByVal DocNo As String) As Boolean
        Duplicate = False
        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .RecordExists(DocNo) = True Then
                Return True
            End If
        End With
        Return False
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim CurrStatus As String
        Dim PRID As String

        If Button4.Text = "Cancel" Then

            If Button1.Text = "Update" Then
                Restore()
            End If

            NewDoc.Visible = False
            Button1.Text = "Revise"
            'Button4.Visible = False
            Button4.Text = "Delete"

            AddButton.Enabled = AddMenu.Enabled = AddButtonOldState
            Reserve_Button.Enabled = DeleteButton.Enabled = DeleteMenu.Enabled = DeleteButtonOldState
            EditButton.Enabled = EditMenu.Enabled = EditButtonOldState
            GridControl1.Enabled = GridControl1OldState
            Print2_Button.Enabled = True

            Button4.Enabled = Button4OldState

            Me.NewDoc.Visible = False
            Me.NewDoc.Properties.ReadOnly = False
            Me.NewDoc.Text = ""

            Me.LoadPO(LoadPOID)

        Else
            With New BusinessRules.POBusRules.POHeaderBusLogic
                If LoadPOID <> 0 Then
                    PRID = LoadPOID
                Else
                    PRID = SRVNoCmb.Properties.LookUpData.KeyValue
                End If
                .Load(PRID)
                CurrStatus = .Status
            End With

            If CurrStatus = "30" Then
                MessageBox.Show("This PR has already been submitted for approval. This form will automatically refresh to show the latest data.", "Delete Disallowed")
                LoadPO(LoadPOID)
                Exit Sub
            ElseIf CurrStatus = "40" Then
                MessageBox.Show("This PR has been approved. This form will automatically refresh to show the latest data.", "Delete Disallowed")
                LoadPO(LoadPOID)
                Exit Sub
            End If

            Dim Result As DialogResult = MessageBox.Show("Confirm delete " & SRVNoCmb.Text & "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                Me.OnLoading = True
                DeletePO()
                LoadPO(LoadPOID)
                Me.SRVNoCmb.Focus()

                Me.OnLoading = True

                Button4.Enabled = False
                GridControl1.Enabled = False
                AddButton.Enabled = False
                DeleteButton.Enabled = False
                Reserve_Button.Enabled = False
                EditButton.Enabled = False
                Print2_Button.Enabled = False
                Print_Button.Enabled = False
                Printa4_Button.Enabled = False

                Me.Title_TextEdit.Text = ""
                Me.Remarks_MemoEdit.Text = ""
                Me.NotesTxt.Text = ""
                Me.DeliverToTxt.Text = ""
                Me.Shipment_DateEdit.DateTime = Nothing
                Me.DiscountTypeLookup.Properties.LookUpData.KeyValue = Nothing
                Me.LastUpdate.Text = ""

                Me.Title_TextEdit.Enabled = False
                Me.Remarks_MemoEdit.Enabled = False
                Me.NotesTxt.Enabled = False
                GSTCheck.Enabled = False
                Me.DiscountTypeLookup.Enabled = False
                DiscountSpin.Enabled = False
                DeliverToTxt.Enabled = False
                Shipment_DateEdit.Enabled = False

                OnLoading = False

            End If


        End If

    End Sub

    Private Sub DeletePO()

        Dim dr As DataRow
        Dim i As Integer
        'Dim Result As DialogResult = MessageBox.Show("Confirm delete " & SRVNoCmb.Text & "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'If Result = DialogResult.Yes Then

        If GridView1.RowCount > 0 Then
            For i = GridView1.RowCount - 1 To 0 Step -1
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Dim TransactionID As Integer = dr(0)
                    If TransactionID > 0 Then
                        Try
                            Me.DeletePOLine(TransactionID)
                        Catch ex As Exception

                            MessageBox.Show("Error deleting transaction:" & ex.Message)
                            Exit Sub

                        End Try
                    End If
                End If
            Next
        End If

        With New BusinessRules.POBusRules.POHeaderBusLogic
            .Delete(SRVNoCmb.Properties.LookUpData.KeyValue)
        End With


        'If FormType = "PO" Then
        Me.SetPOForm()
        'End If

        'End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        AddMenu_Click(sender, e)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        DeleteMenu_Click(sender, e)
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        EditMenu_Click(sender, e)
    End Sub

    Private Sub EditMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenu.Click

        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim ID As Integer = dr(0)

                Dim form As New PrItem3(ID, "PO")

                'form.Quotation_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                'form.PR_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                form.PO_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                form.ShowDialog(Me)

            End If
        End If

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        If GridView1.RowCount > 0 Then
            EditMenu_Click(sender, e)
        Else
            AddMenu_Click(sender, e)
        End If
    End Sub


    Private Sub GridControl1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            If GridView1.RowCount > 0 Then
                EditMenu_Click(sender, e)
            Else
                AddMenu_Click(sender, e)
            End If
        End If
    End Sub


    Private Sub SRVNoCmb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SRVNoCmb.KeyDown
        If e.KeyCode = Keys.Down Then
            SRVNoCmb.DoPopup()
        End If
    End Sub

    Private Sub SRVNoCmb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SRVNoCmb.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            LoadPO(LoadPOID)
            GridControl1.Focus()
        End If
    End Sub

    Private Sub SRVNoCmb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SRVNoCmb.LostFocus
        SRVNoCmb.Properties.Style.BackColor = System.Drawing.SystemColors.Window
    End Sub

    Private Sub SRVNoCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles SRVNoCmb.CloseUp
        LoadPO(LoadPOID)
        GridControl1.Focus()
    End Sub

    Private Sub SRVNoCmb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SRVNoCmb.GotFocus
        'OnFocus(sender)
        SRVNoCmb.Properties.Style.BackColor = Color.LightYellow
    End Sub

    Private Sub OnFocus(ByRef sender As Object)
        Dim c As Control
        c = sender
        c.BackColor = Color.LightYellow
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SRVNoCmb.Focus()
    End Sub

    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus

    End Sub

    Private Sub NewDoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewDoc.GotFocus
        NewDoc.Properties.Style.BackColor = Color.LightYellow
    End Sub

    Private Sub NewDoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewDoc.LostFocus
        NewDoc.Properties.Style.BackColor = System.Drawing.SystemColors.Window
    End Sub


    Private Sub NewDoc_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NewDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print2_Button.Click
        Dim str As String
        'str = GridView1.Columns(0).Width & "," & _
        'GridView1.Columns(1).Width & "," & _
        'GridView1.Columns(2).Width & "," & _
        'GridView1.Columns(3).Width & "," & _
        'GridView1.Columns(4).Width & "," & _
        ' GridView1.Columns(5).Width & "," & _
        ' GridView1.Columns(6).Width & "," & _
        ' GridView1.Columns(7).Width

        'MessageBox.Show(str)

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        'Dim ExtProgressForm
        'ExtProgressForm = New TaskProgressForm
        'ExtProgressForm. = Me
        'ExtProgressForm.Show()
        'ExtProgressForm.Refresh()

        If FormType = "SRV" Then
        ElseIf FormType = "PMR" Then
        ElseIf FormType = "RTN" Then
        ElseIf FormType = "DO" Then
        ElseIf FormType = "ST" Then
        ElseIf FormType = "FGW" Then
        ElseIf FormType = "QAR" Then
        ElseIf FormType = "INT" Then
        End If

        str = SRVNoCmb.Text
        Me.Cursor = Cursors.WaitCursor
        Dim formx As StockTransReport
        formx = New StockTransReport(0, "", str, SRVNoCmb.Properties.LookUpData.KeyValue, "", "", "QAR")
        formx.ShowDialog()
        Me.Cursor = Cursors.Arrow
        'ExtProgressForm.Close()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TopPanel.Paint

    End Sub

    Private Sub Remarks_MemoEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Remarks_MemoEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub OnEdit()
        If Me.OnLoading = False Then
            If Button1.Text = "Revise" Then
                Button1.Text = "Update"
                Button4.Text = "Cancel"

                Me.NewDoc.Text = Me.SRVNoCmb.Text
                Me.NewDoc.Visible = True
                Me.NewDoc.Properties.ReadOnly = True

                Me.GridControl1OldState = GridControl1.Enabled
                Button4OldState = Button4.Enabled
                AddButtonOldState = AddButton.Enabled
                DeleteButtonOldState = DeleteButton.Enabled
                EditButtonOldState = EditButton.Enabled

                Edited = True
            End If
        End If
    End Sub

    Private Sub Title_TextEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Title_TextEdit.ValueChanged
        OnEdit()
    End Sub

    Private Function UpdatePO() As Boolean
        Dim Stat As Boolean

        Stat = True
        'GetWindowsValue()
        Dim PRID As String

        If LoadPOID <> 0 Then
            PRID = LoadPOID
        Else
            PRID = SRVNoCmb.Properties.LookUpData.KeyValue
        End If

        If True Then 'ValidData() Then

            With New BusinessRules.POBusRules.POHeaderBusLogic

                .Load(PRID)

                .Title = Me.Title_TextEdit.Text

                .Remarks = Me.Remarks_MemoEdit.Text
                .Shipment_Date = Me.Shipment_DateEdit.DateTime
                .DeliverTo = Me.DeliverToTxt.Text
                .DiscountType = Me.DiscountTypeLookup.Properties.LookUpData.KeyValue
                .Discount = Me.DiscountSpin.Text
                .Notes = Me.NotesTxt.Text

                If Me.GSTCheck.CheckState = CheckState.Checked Then
                    .GST_Flg = 1
                Else
                    .GST_Flg = 0
                End If

                .UserID = UserID

                '.PO_NO = PO_NO
                '.Requester = Requester
                '.Approver = Approver
                '.Status = Status
                '.UserID = UserID

                'A modified record will have product id
                'Modify Current Record
                .Update(PRID)
                StoreOld()

                'MessageBox.Show("PR had been successfully updated", "Modify PR", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'DisbledAll()
            End With

        End If

        UpdatePO = Stat

    End Function



    Private Sub InitalUserCombo()

    End Sub

    Private Sub InitalStatusCombo()

    End Sub

    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())

        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub ReqByLookup_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OnEdit()
    End Sub
    'Change date format

    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then

            If pInputDate.toString <> "" Then
                pDate = Date.Parse(pInputDate)
                tempsDate = pDate.Day & "/" & pDate.Month & "/" & pDate.Year
            End If

        End If

        Return tempsDate

    End Function

    Private Sub Button5_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reserve_Button.Click

        Dim form As New PrItem3("POADHOC")
        form.PO_ID = SRVNoCmb.Properties.LookUpData.KeyValue
        form.Actual_Supplier_ID = Me.Supplier_ID
        form.ShowDialog(Me)

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim POLine As Integer = dr(0)
                If POLine > 0 Then
                    Dim form As New UnReserveStock

                    form.PR_Line = POLine
                    'form.Quotation_NO = Quotation_NO
                    form.ShowDialog()

                    If form.SaveRecord Then
                        Me.LoadPOItem()
                    End If
                End If
            End If
        End If
    End Sub


    Sub StoreOld()

        Me.Title_TextEdit_Old = Me.Title_TextEdit.Text
        ShipmentDateEdit_Old = Shipment_DateEdit.DateTime
        DeliverToTxt_Old = DeliverToTxt.Text
        DiscountTypeLookup_Old = DiscountTypeLookup.Text
        DiscountSpin_Old = Me.DiscountSpin.Text
        GSTCheck_Old = Me.GSTCheck.CheckState
        NotesTxt_Old = Me.NotesTxt.Text
        Me.MemoEdit_Old = Me.Remarks_MemoEdit.Text

    End Sub

    Sub Restore()

        Me.Title_TextEdit.Text = Me.Title_TextEdit_Old
        Shipment_DateEdit.DateTime = Me.ShipmentDateEdit_Old
        DeliverToTxt.Text = DeliverToTxt_Old
        DiscountTypeLookup.Text = DiscountTypeLookup_Old
        Me.DiscountSpin.Text = DiscountSpin_Old
        Me.GSTCheck.CheckState = GSTCheck_Old
        Me.Remarks_MemoEdit.Text = MemoEdit_Old
        NotesTxt.Text = NotesTxt_Old

    End Sub

    Private Sub WO_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OnEdit()
    End Sub

    Private Sub ST_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OnEdit()
    End Sub

    Private Sub OC_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OnEdit()
    End Sub

    Private Sub FT_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OnEdit()
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Result As DialogResult

        If Button1.Text = "Update" Then
            Result = MessageBox.Show("Reload data will cancel any changes made, Are you sure? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                LoadPO(LoadPOID)
            End If
        Else
            LoadPO(LoadPOID)
        End If

    End Sub

    Private Sub PRApprovedByLookUp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OnEdit()
    End Sub

    Private Sub Button5_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim f As SetPurchasingDeliveryDate
        f = New SetPurchasingDeliveryDate
        f.ShowDialog()

        If f.DeliveryDate <> Nothing Then
            With New BusinessRules.POBusRules.POBusLogic

                If LoadPOID <> 0 Then
                    '.UpdateDeliveryDate(LoadPOID, f.DeliveryDate)
                Else
                    '.UpdateDeliveryDate(SRVNoCmb.Properties.LookUpData.KeyValue, f.DeliveryDate)
                End If
            End With
        End If

        Me.LoadPOItem()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If ExpandButton.Text = "+" Then
        'ExpandButton.Text = "-"
        'TopPanel.Height = 38
        'Else
        '    ExpandButton.Text = "+"
        '    TopPanel.Height = 276
        'End If
    End Sub

    Private Sub SetYearCombo()
        Dim i As Integer

        Dim dData(11) As String '= New String() {"All Items", "Active Items only", "Dormant Items only"}
        Dim dID(11) As String '= New String() {"0", "1", "2"}

        Dim currentYr As Integer
        currentYr = Today.Year
        Dim setyr As Integer
        setyr = currentYr
        For i = 0 To 9

            dData(i) = setyr.ToString()
            dID(i) = setyr.ToString()
            setyr = setyr - 1

        Next

        dData(10) = "Show ALL"
        dID(10) = "ALL"

        SetComboValue(dData, Me.LookUpEdit_Year, dID)

        Me.LookUpEdit_Year.Properties.LookUpData.KeyValue = currentYr.ToString() 'default set to current year

    End Sub

    Private Sub ShipmentDateEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OnEdit()
    End Sub

    Private Sub DeliverToTxt_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeliverToTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub DiscountTypeLookup_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscountTypeLookup.ValueChanged
        OnEdit()
    End Sub

    Private Sub DiscountSpin_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscountSpin.ValueChanged
        OnEdit()
    End Sub

    Private Sub GSTCheck_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GSTCheck.ValueChanged
        OnEdit()
    End Sub

    Private Sub NotesTxt_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotesTxt.ValueChanged
        OnEdit()
    End Sub

    Private Sub Splitter1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs)

    End Sub

    Private Sub Splitter1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Splitter1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Splitter1.DoubleClick
        If TopPanel.Height > 100 Then
            TopPanel.Height = 38
        Else
            TopPanel.Height = 320
        End If
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Printa4_Button.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim PO_Title As String
        Dim PrintTitle As Boolean = False

        Dim POID As Integer
        If LoadPOID <> 0 Then
            POID = LoadPOID
        Else
            POID = SRVNoCmb.Properties.LookUpData.KeyValue
        End If

        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .Load(POID) Then
                PO_Title = .Title
                If Len(PO_Title) > 0 Then
                    PrintTitle = True
                End If
            End If
        End With

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New POReportForm(POID, PrintTitle, True)
        page = New Crownwood.Magic.Controls.TabPage("PO Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Splitter1_SplitterMoved1(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles Splitter1.SplitterMoved

    End Sub

    Private Sub LoadDiscountType()
        Dim discountTypeData As String() = New String() {"No Discount", "Discount by Amt", "Discount by Percentage", "Add by Amt", "Add by Percentage"}
        Dim idData As String() = New String() {"0", "1", "2", "3", "4"}

        SetComboValue(discountTypeData, DiscountTypeLookup, idData)
    End Sub

    Private Sub ShipmentDateEdit_ValueChanged1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shipment_DateEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub SupplierCmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SupplierCmb.ValueChanged
        _SelectedSupplierID = SupplierCmb.Properties.LookUpData.KeyValue
        LoadPOList()
    End Sub
End Class
