Public Class ManageCustomerForm
    Inherits System.Windows.Forms.Form

#Region "Customer Form Variables Initialization"
    Public Customer_ID As Integer
    Public FormStatus As String
    Public FormType As Integer

    Public Customer_Name As String
    Public Address As String
    Public Country As String
    Public Postal_Code As String
    Public Tel As String
    Public Fax As String
    Public Status As String
    Public Initial As String
    Public Create_Date As String
    Public Transact_Date As String
    Private UserID As Integer = Common.CommonConn.Config.USERID

#End Region

    Dim FunctionName As String = "CustomerProfile" ' 29.12.2003 YG Added
    Dim NextScreen As String = "MyCustomerContact" ' 29.12.2003 YG Added
#Region "Customer Contact Variables Initialization"
    Public Contact_ID As Integer

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pCustomer_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus

        If pCustomer_ID = 0 Then
            FormStatus = "NEW"
        End If

        If Not pCustomer_ID = 0 Then
            Customer_ID = pCustomer_ID
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pFormType As Integer, Optional ByVal pCustomer_ID As Integer = 0)

        MyBase.New()

        FormType = pFormType

        If pCustomer_ID = 0 Then
            FormStatus = "NEW"
        End If

        If Not pCustomer_ID = 0 Then
            Customer_ID = pCustomer_ID
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
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomerIDTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerFaxTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTelTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerPostalCodeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerCountryTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerAddressTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CustomerNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerInitialTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerCreateDateTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerModifyDateTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerModifyByTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ActiveChk As System.Windows.Forms.CheckBox
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DelContactBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents EditContactBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NewContactBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CustomerContactGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ManageCustomerForm))
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DelContactBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EditContactBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewContactBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CustomerContactGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActiveChk = New System.Windows.Forms.CheckBox
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CustomerFaxTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerTelTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerPostalCodeTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerCountryTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CustomerAddressTxt = New DevExpress.XtraEditors.MemoEdit
        Me.CustomerNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerIDTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerInitialTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerModifyDateTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerModifyByTxt = New DevExpress.XtraEditors.TextEdit
        Me.CustomerCreateDateTxt = New DevExpress.XtraEditors.TextEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustomerContactGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerFaxTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerPostalCodeTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerCountryTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerAddressTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerIDTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerInitialTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerModifyDateTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerModifyByTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerCreateDateTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(16, 26)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(80, 16)
        Me.CustNameLbl.TabIndex = 25
        Me.CustNameLbl.Text = "Customer ID :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Customer Name :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Address :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(376, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Active? :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(184, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Customer Initial :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(376, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Created on :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(376, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Last Modify on :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(376, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Modify By :"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(320, 376)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(70, 32)
        Me.CancelBtn.TabIndex = 60
        Me.CancelBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(244, 376)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(70, 32)
        Me.SaveBtn.TabIndex = 59
        Me.SaveBtn.Text = "&Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ActiveChk)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.CustomerFaxTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerTelTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerPostalCodeTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerCountryTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CustomerAddressTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerNameTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerIDTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerInitialTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerModifyDateTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerModifyByTxt)
        Me.GroupBox1.Controls.Add(Me.CustomerCreateDateTxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 416)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DelContactBtn)
        Me.GroupBox2.Controls.Add(Me.EditContactBtn)
        Me.GroupBox2.Controls.Add(Me.NewContactBtn)
        Me.GroupBox2.Controls.Add(Me.CustomerContactGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 192)
        Me.GroupBox2.TabIndex = 176
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Custmer Contacts"
        '
        'DelContactBtn
        '
        Me.DelContactBtn.AutoSize = False
        Me.DelContactBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelContactBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelContactBtn.Image = Nothing
        Me.DelContactBtn.Location = New System.Drawing.Point(152, 16)
        Me.DelContactBtn.Name = "DelContactBtn"
        Me.DelContactBtn.Size = New System.Drawing.Size(64, 32)
        Me.DelContactBtn.TabIndex = 141
        Me.DelContactBtn.Text = "Delete"
        '
        'EditContactBtn
        '
        Me.EditContactBtn.AutoSize = False
        Me.EditContactBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditContactBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditContactBtn.Image = Nothing
        Me.EditContactBtn.Location = New System.Drawing.Point(80, 16)
        Me.EditContactBtn.Name = "EditContactBtn"
        Me.EditContactBtn.Size = New System.Drawing.Size(64, 32)
        Me.EditContactBtn.TabIndex = 140
        Me.EditContactBtn.Text = "Edit"
        '
        'NewContactBtn
        '
        Me.NewContactBtn.AutoSize = False
        Me.NewContactBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewContactBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewContactBtn.Image = Nothing
        Me.NewContactBtn.Location = New System.Drawing.Point(8, 16)
        Me.NewContactBtn.Name = "NewContactBtn"
        Me.NewContactBtn.Size = New System.Drawing.Size(64, 32)
        Me.NewContactBtn.TabIndex = 139
        Me.NewContactBtn.Text = "Add"
        '
        'CustomerContactGrid
        '
        Me.CustomerContactGrid.BackColor = System.Drawing.Color.White
        Me.CustomerContactGrid.EditorsRepository = Me.PersistentRepository1
        Me.CustomerContactGrid.Location = New System.Drawing.Point(8, 56)
        Me.CustomerContactGrid.MainView = Me.GridView2
        Me.CustomerContactGrid.Name = "CustomerContactGrid"
        Me.CustomerContactGrid.Size = New System.Drawing.Size(520, 128)
        Me.CustomerContactGrid.TabIndex = 138
        Me.CustomerContactGrid.Text = "GridControl1"
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView2
        '
        Me.GridView2.BehaviorOptions = CType((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn7, Me.GridColumn8, Me.GridColumn1, Me.GridColumn6, Me.GridColumn2, Me.GridColumn3})
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit1
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
        Me.GridColumn4.Caption = "Title"
        Me.GridColumn4.FieldName = "Title"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 70
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Name"
        Me.GridColumn7.FieldName = "Name"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 100
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tel"
        Me.GridColumn8.FieldName = "Tel"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 65
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ext"
        Me.GridColumn1.FieldName = "Ext"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "HandPhone"
        Me.GridColumn6.FieldName = "HandPhone"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Contact_ID"
        Me.GridColumn2.MinWidth = 10
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.Width = 10
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Email"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn3.FieldName = "ContactEmail"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 100
        '
        'ActiveChk
        '
        Me.ActiveChk.Location = New System.Drawing.Point(464, 96)
        Me.ActiveChk.Name = "ActiveChk"
        Me.ActiveChk.Size = New System.Drawing.Size(16, 16)
        Me.ActiveChk.TabIndex = 175
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(168, 376)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 32)
        Me.btnRefresh.TabIndex = 138
        Me.btnRefresh.Text = "Refresh"
        '
        'CustomerFaxTxt
        '
        Me.CustomerFaxTxt.Location = New System.Drawing.Point(272, 152)
        Me.CustomerFaxTxt.Name = "CustomerFaxTxt"
        Me.CustomerFaxTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CustomerFaxTxt.Size = New System.Drawing.Size(88, 21)
        Me.CustomerFaxTxt.TabIndex = 75
        '
        'CustomerTelTxt
        '
        Me.CustomerTelTxt.Location = New System.Drawing.Point(104, 152)
        Me.CustomerTelTxt.Name = "CustomerTelTxt"
        Me.CustomerTelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CustomerTelTxt.Size = New System.Drawing.Size(104, 21)
        Me.CustomerTelTxt.TabIndex = 74
        '
        'CustomerPostalCodeTxt
        '
        Me.CustomerPostalCodeTxt.Location = New System.Drawing.Point(272, 124)
        Me.CustomerPostalCodeTxt.Name = "CustomerPostalCodeTxt"
        Me.CustomerPostalCodeTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CustomerPostalCodeTxt.Size = New System.Drawing.Size(88, 21)
        Me.CustomerPostalCodeTxt.TabIndex = 73
        '
        'CustomerCountryTxt
        '
        Me.CustomerCountryTxt.Location = New System.Drawing.Point(104, 124)
        Me.CustomerCountryTxt.Name = "CustomerCountryTxt"
        Me.CustomerCountryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CustomerCountryTxt.Size = New System.Drawing.Size(104, 21)
        Me.CustomerCountryTxt.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(224, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Fax No. :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Tel No. :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Postal :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Country :"
        '
        'CustomerAddressTxt
        '
        Me.CustomerAddressTxt.Location = New System.Drawing.Point(104, 70)
        Me.CustomerAddressTxt.Name = "CustomerAddressTxt"
        Me.CustomerAddressTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CustomerAddressTxt.Size = New System.Drawing.Size(256, 48)
        Me.CustomerAddressTxt.TabIndex = 66
        '
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.Location = New System.Drawing.Point(104, 42)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CustomerNameTxt.Size = New System.Drawing.Size(256, 21)
        Me.CustomerNameTxt.TabIndex = 65
        '
        'CustomerIDTxt
        '
        Me.CustomerIDTxt.Enabled = False
        Me.CustomerIDTxt.Location = New System.Drawing.Point(104, 16)
        Me.CustomerIDTxt.Name = "CustomerIDTxt"
        Me.CustomerIDTxt.Properties.Enabled = False
        Me.CustomerIDTxt.Size = New System.Drawing.Size(56, 21)
        Me.CustomerIDTxt.TabIndex = 63
        '
        'CustomerInitialTxt
        '
        Me.CustomerInitialTxt.Location = New System.Drawing.Point(272, 16)
        Me.CustomerInitialTxt.Name = "CustomerInitialTxt"
        Me.CustomerInitialTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CustomerInitialTxt.Properties.MaxLength = 3
        Me.CustomerInitialTxt.Size = New System.Drawing.Size(88, 21)
        Me.CustomerInitialTxt.TabIndex = 64
        '
        'CustomerModifyDateTxt
        '
        Me.CustomerModifyDateTxt.Enabled = False
        Me.CustomerModifyDateTxt.Location = New System.Drawing.Point(464, 56)
        Me.CustomerModifyDateTxt.Name = "CustomerModifyDateTxt"
        Me.CustomerModifyDateTxt.Properties.Enabled = False
        Me.CustomerModifyDateTxt.Size = New System.Drawing.Size(80, 21)
        Me.CustomerModifyDateTxt.TabIndex = 79
        '
        'CustomerModifyByTxt
        '
        Me.CustomerModifyByTxt.Enabled = False
        Me.CustomerModifyByTxt.Location = New System.Drawing.Point(464, 120)
        Me.CustomerModifyByTxt.Name = "CustomerModifyByTxt"
        Me.CustomerModifyByTxt.Properties.Enabled = False
        Me.CustomerModifyByTxt.Size = New System.Drawing.Size(80, 21)
        Me.CustomerModifyByTxt.TabIndex = 80
        '
        'CustomerCreateDateTxt
        '
        Me.CustomerCreateDateTxt.Enabled = False
        Me.CustomerCreateDateTxt.Location = New System.Drawing.Point(464, 24)
        Me.CustomerCreateDateTxt.Name = "CustomerCreateDateTxt"
        Me.CustomerCreateDateTxt.Properties.Enabled = False
        Me.CustomerCreateDateTxt.Size = New System.Drawing.Size(80, 21)
        Me.CustomerCreateDateTxt.TabIndex = 78
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ManageCustomerForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(568, 429)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustNameLbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageCustomerForm"
        Me.Text = "Manage Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CustomerContactGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerFaxTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerPostalCodeTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerCountryTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerAddressTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerIDTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerInitialTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerModifyDateTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerModifyByTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerCreateDateTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load "
    Private Sub ManageCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a As MainForm = Me.ParentForm

        Me.Cursor = Cursors.WaitCursor

        Select Case UCase(FormStatus)
            Case "NEW"
                InitializeForm()

            Case "EDIT"
                Me.Text = "Edit Customer"
                With New BusinessRules.CustomerBusRules.CustomerBusLogic
                    Dim dsCustomer As DataSet
                    If .GetCustomer(dsCustomer, Customer_ID) Then
                        SetWindowValue(dsCustomer)
                    End If
                End With
                LoadCustomerContactList(Customer_ID)
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

        '      StatusCmb.Properties.LookUpData.KeyValue = "10"
        '     ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        '    ItemNoTxt.Text = WO_ItemNo.ToString
        '   WODate.DateTime = Date.Today
        With New BusinessRules.CustomerBusRules.CustomerBusLogic
            'GET CUSTOMER INITIAL
            Dim dstmp As DataSet
            Dim CustInitial
            '      If .GetCustomerDetails(dstmp, Customer_ID) Then
            '     If dstmp.Tables(0).Rows.Count > 0 Then
            '    CustInitial = dstmp.Tables(0).Rows(0)("Initial")
            '   CustLookup.Properties.LookUpData.KeyValue = dstmp.Tables(0).Rows(0)("Customer_ID")
            '  End If
            ' End If
            'dstmp.Dispose()
            'LoadContactPerson(Customer_ID)
            'CustLookup.Properties.ReadOnly = True

            'With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            'WO_NO = GetWorkOrderNo(CustInitial)
            'WONoTxt.Text = WO_NO

            '.WO_No = WO_NO
            '.UserID = UserID
            '.Status = StatusCmb.Properties.LookUpData.KeyValue

            'If .SaveWONo() Then
            'WO_ID = .WO_ID        'Store WO ID
            'Else
            '    MessageBox.Show("Error creating Work Order", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'End With
        End With
    End Sub

    Private Sub LoadCustomerContactList(ByVal pCustomer_ID As String)
        Dim Contactds As DataSet

        With New BusinessRules.CustomerBusRules.CustomerBusLogic
            .Customer_ID = Customer_ID
            If .GetCustomerContact_Display(Contactds, Customer_ID) Then
                CustomerContactGrid.DataSource = Contactds.Tables(0)
            End If
        End With

    End Sub

#End Region

#Region "Button Event"

    Public Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadCustomerContactList(Customer_ID)
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim tempID As Integer

        If SaveCustomer() = True Then

            If FormType = 1 Then
                Close()
            End If
        End If

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()

    End Sub

#End Region

#Region "Database Management"
    Private Function SaveCustomer() As Boolean

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.CustomerBusRules.CustomerBusLogic

                .Name = Customer_Name
                .Address = Address
                .Country = Country
                .Postal_Code = Postal_Code
                .Tel1 = Tel
                .Fax = Fax
                .Status = Status
                .Initial = Initial
                .Credit_Limit = 0
                .Payment_Detail = 0
                .Create_Date = Create_Date
                .Transact_Date = Transact_Date
                .UserID = UserID

                If Customer_ID = Nothing Or Customer_ID = 0 Then
                    Customer_ID = .SaveCustomer()
                    'CancelBtn_Click(Me, Nothing)
                Else
                    .UpdateCustomer(Customer_ID)
                    CancelBtn_Click(Me, Nothing)
                End If
            End With
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        Dim varActive_Flg

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Initial")) Then
            CustomerInitialTxt.Text = dsLoad.Tables(0).Rows(0)("Initial")
        Else
            CustomerInitialTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
            CustomerIDTxt.Text = dsLoad.Tables(0).Rows(0)("Customer_ID")
        Else
            CustomerIDTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Name")) Then
            CustomerNameTxt.Text = dsLoad.Tables(0).Rows(0)("Name")
        Else
            CustomerNameTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Address")) Then
            CustomerAddressTxt.Text = dsLoad.Tables(0).Rows(0)("Address")
        Else
            CustomerAddressTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Country")) Then
            CustomerCountryTxt.Text = dsLoad.Tables(0).Rows(0)("Country")
        Else
            CustomerCountryTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Tel1")) Then
            CustomerTelTxt.Text = dsLoad.Tables(0).Rows(0)("Tel1")
        Else
            CustomerTelTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Fax")) Then
            CustomerFaxTxt.Text = dsLoad.Tables(0).Rows(0)("Fax")
        Else
            CustomerFaxTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Postal_Code")) Then
            CustomerPostalCodeTxt.Text = dsLoad.Tables(0).Rows(0)("Postal_Code")
        Else
            CustomerPostalCodeTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Create_Date")) Then
            CustomerCreateDateTxt.Text = dsLoad.Tables(0).Rows(0)("Create_Date")
        Else
            CustomerCreateDateTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Transact_Date")) Then
            CustomerModifyDateTxt.Text = dsLoad.Tables(0).Rows(0)("Transact_Date")
        Else
            CustomerModifyDateTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("UserID")) Then
            CustomerModifyByTxt.Text = dsLoad.Tables(0).Rows(0)("UserID")
        Else
            CustomerModifyByTxt.Text = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Status")) Then
            varActive_Flg = dsLoad.Tables(0).Rows(0)("Status")
        Else
            varActive_Flg = Nothing
        End If
        If varActive_Flg = 1 Then
            ActiveChk.Checked = True
        Else
            ActiveChk.Checked = False
        End If

    End Sub

    Private Sub GetWindowsValue()

        Customer_Name = CustomerNameTxt.Text
        Address = CustomerAddressTxt.Text
        Country = CustomerCountryTxt.Text
        Tel = CustomerTelTxt.Text
        Fax = CustomerFaxTxt.Text
        Postal_Code = CustomerPostalCodeTxt.Text
        Fax = CustomerFaxTxt.Text
        Initial = CustomerInitialTxt.Text
        If ActiveChk.Checked = True Then
            Status = 1
        Else
            Status = 0
        End If

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If Customer_Name = "" Then
            ErrorMessage = ErrorMessage & " Customer Name" & Chr(13)
            DataOK_flag = False
        End If

        If Address = "" Then
            ErrorMessage = ErrorMessage & " Address" & Chr(13)
            DataOK_flag = False
        End If

        If Country = "" Then
            ErrorMessage = ErrorMessage & " Country" & Chr(13)
            DataOK_flag = False
        End If

        If Tel = "" Then
            ErrorMessage = ErrorMessage & " Telephone " & Chr(13)
            DataOK_flag = False
        End If

        If Fax = "" Then
            ErrorMessage = ErrorMessage & " Fax" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.ConsultantBusRules.ConsultantBusLogic
                If Customer_ID <> Nothing And Customer_ID <> 0 Then
                    If .RecordExists(Customer_Name, Customer_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(Customer_Name, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function
#End Region

    Private Sub NewContactBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewContactBtn.Click
        With New BusinessRules.CustomerBusRules.CustomerBusLogic
            If .RecordExists(CustomerNameTxt.Text, Customer_ID) = False Then
                If SaveCustomer() = False Then
                    Exit Sub
                End If
            End If
        End With

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New CustomerContactForm("NEW", Customer_ID, )
        page = New Crownwood.Magic.Controls.TabPage("New Customer Contact", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub EditContactBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditContactBtn.Click
        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)
            Dim Contact_ID As Integer = dr("Contact_ID")

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            controlToAdd = New CustomerContactForm("EDIT", Customer_ID, Contact_ID)
            page = New Crownwood.Magic.Controls.TabPage("Edit Customer Contact", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DelContactBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelContactBtn.Click
        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)
            Dim Contact_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this Contact?", "Customer Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.CustomerBusRules.CustomerBusLogic
                    If .DeleteCustomerContact(Contact_ID) Then
                        MessageBox.Show("Customer Contact Deleted.", "Cuatomer Contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            LoadCustomerContactList(Contact_ID)
        End If
    End Sub


    Private Sub ManageCustomerForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim Result As DialogResult

        If Me.Modal = False Then

            Result = MessageBox.Show("Close Now?", "Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
        End If
    End Sub
End Class
