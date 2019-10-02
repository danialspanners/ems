'Mainform 

Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Resources
Imports System.Reflection
Imports System.Collections
Imports System.Configuration
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Crownwood.Magic.Common
Imports Crownwood.Magic.Controls
Imports Crownwood.Magic.Menus
Imports Common.CommonConn.Config
Imports Microsoft.Win32
Imports GenericOLEDB



Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private _topMenu As Crownwood.Magic.Menus.MenuControl = Nothing
    Private _filler As Crownwood.Magic.Controls.TabControl
    Public com As New Common.CommonConn.Config
    Public EMSVersion As String
    Public AccessUpdate As String
    Public AccessFolder As String
    Private Provider, UserID, Password, DatabaseName, Mode As String
    Private dbAccess As GenericOLEDBClass



#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Dim DBServerName As String
        Dim DBName As String
        Dim UpdateFolder As String
        Dim Version As String


        Dim Config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        Try
            'Dim Config As Configuration

            DBName = Config.AppSettings.Settings.Item("DBName").Value.ToString
            DBServerName = Config.AppSettings.Settings.Item("DBServer").Value.ToString
            UpdateFolder = Config.AppSettings.Settings.Item("UpdateFolder").Value.ToString
            Version = Config.AppSettings.Settings.Item("Version").Value.ToString
            AccessUpdate = Config.AppSettings.Settings.Item("AccessUpdate").Value.ToString
            AccessFolder = Config.AppSettings.Settings.Item("AccessFolder").Value.ToString

            EMSVersion = Version

            With New Common.CommonConn.Config

                .DBName = DBName
                .DBServer = DBServerName
                .UpdateFolder = UpdateFolder
                .Version = Version
                .ConnString = .ConnectionString
                .SQLConnection = New SqlConnection(.SQLConnectionString)
                .SQLDataAdapter = New SqlDataAdapter("", .SQLConnection)
            End With

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Application.Exit()
            'Finally
            'DBServerName = "local"
            'DBName = "EMS"
        End Try


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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MainTabControl As Crownwood.Magic.Controls.TabControl
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarTimePanel As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SingleInstance1 As rr.Windows.Forms.SingleInstance

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainTabControl = New Crownwood.Magic.Controls.TabControl
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarTimePanel = New System.Windows.Forms.StatusBarPanel
        Me.SingleInstance1 = New rr.Windows.Forms.SingleInstance(Me.components)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarTimePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SingleInstance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainTabControl
        '
        Me.MainTabControl.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.HotTextColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.MainTabControl.HotTrack = True
        Me.MainTabControl.IDEPixelArea = True
        Me.MainTabControl.IDEPixelBorder = False
        Me.MainTabControl.ImageList = Me.ImageList1
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.ShowClose = False
        Me.MainTabControl.Size = New System.Drawing.Size(712, 487)
        Me.MainTabControl.TabIndex = 3
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 487)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarTimePanel})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(712, 22)
        Me.StatusBar1.TabIndex = 6
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Width = 466
        '
        'StatusBarTimePanel
        '
        Me.StatusBarTimePanel.Width = 230
        '
        ' associate component with containing form
        '
        Me.SingleInstance1.Form = Me
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 509)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aises Technology - Enterprise Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarTimePanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SingleInstance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Protected Sub SetupMenus()
        ' Create the MenuControl
        _topMenu = New Crownwood.Magic.Menus.MenuControl

        ' We want the control to handle the MDI pendant
        _topMenu.MdiContainer = Me

        ' Create the top level Menu
        Dim top1 As MenuCommand = New MenuCommand("&File")
        Dim menu_sales As MenuCommand = New MenuCommand("&Sales")
        Dim menu_purchasing As MenuCommand = New MenuCommand("&Purchasing")
        Dim menu_production As MenuCommand = New MenuCommand("P&roduction")
        Dim menu_quality_assurance As MenuCommand = New MenuCommand("&Quality Assurance")
        Dim menu_inventory_management As MenuCommand = New MenuCommand("&Inventory Management")
        Dim menu_finance As MenuCommand = New MenuCommand("F&inance")
        Dim menu_setup As MenuCommand = New MenuCommand("S&etup")
        Dim top9 As MenuCommand = New MenuCommand("A&bout")

        'top1.Enabled = False
        menu_sales.Enabled = False
        menu_purchasing.Enabled = False
        menu_production.Enabled = False
        menu_quality_assurance.Enabled = False
        menu_inventory_management.Enabled = False
        menu_finance.Enabled = False
        menu_setup.Enabled = False
        'top9.Enabled = False

        If com.CheckGroupAccess(com, "sales") Then
            menu_sales.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing") Then
            menu_purchasing.Enabled = True
        End If
        If com.CheckGroupAccess(com, "production") Then
            menu_production.Enabled = True
        End If
        If com.CheckGroupAccess(com, "quality assurance") Then
            menu_quality_assurance.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management") Then
            menu_inventory_management.Enabled = True
        End If
        If com.CheckGroupAccess(com, "finance") Then
            menu_finance.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup") Then
            menu_setup.Enabled = True
        End If

        If com.USERID <> 3 And com.USERID <> 71 And com.USERID <> 58 And _
        com.USERID <> 65 And com.USERID <> 23 And com.USERID <> 67 _
        And com.USERID <> 74 And com.USERID <> 68 And com.USERID <> 77 Then ' temporary
            'menu_sales.Enabled = False
        End If

        _topMenu.MenuCommands.AddRange(New MenuCommand() {top1, menu_sales, menu_purchasing, menu_production, menu_quality_assurance, menu_inventory_management, menu_finance, menu_setup, top9})
        _topMenu.HighlightBackColor = System.Drawing.SystemColors.Highlight
        _topMenu.HighlightInfrequent = False
        _topMenu.AnimateStyle = Animation.SlideCenter
        _topMenu.AnimateTime = 100

        ' Create the submenus
        CreateFileMenu(top1)
        CreateSalesMenu(menu_sales)
        CreatePurchasingMenu(menu_purchasing)
        CreateProductionMenu(menu_production)
        CreateQAMenu(menu_quality_assurance)
        CreateInventoryMenuNew(menu_inventory_management)
        CreateFinanceMenu(menu_finance)
        CreateSetupMenu(menu_setup)
        CreateAboutMenu(top9)
        'CreateToDoMenu(menu_production)
        'CreateAboutMenus(menu_production, menu_finance)

        ' Add to the display
        _topMenu.Dock = DockStyle.Top

        Controls.Add(_topMenu)

    End Sub

    Protected Sub CreateFileMenu(ByVal mc As MenuCommand)
        ' Create menu commands

        'Dim styleLogIn As MenuCommand = New MenuCommand("Log &In", New EventHandler(AddressOf LoginMenuCommand_Click))
        'Dim styleLogOut As MenuCommand = New MenuCommand("Log In/&Out", New EventHandler(AddressOf LogoutMenuCommand_Click))
        'Dim window1 As MenuCommand = New MenuCommand("-")
		Dim styleExit As MenuCommand = New MenuCommand("E&xit", New EventHandler(AddressOf OnExit))
		Dim styleLogout As MenuCommand = New MenuCommand("L&ogout...", New EventHandler(AddressOf OnLogout))

        ' Setup event handlers
        'AddHandler style1.Update, AddressOf OnIDEUpdate

		'mc.MenuCommands.AddRange(New MenuCommand() {styleLogOut, window1, styleExit})
		mc.MenuCommands.AddRange(New MenuCommand() {styleLogout})
		mc.MenuCommands.AddRange(New MenuCommand() {styleExit})


    End Sub
    Protected Sub CreateSalesMenu(ByVal mc As MenuCommand)

        Dim menuSales_Enquiry As MenuCommand = New MenuCommand("&Enquiry", 0)
        'Dim menuSales_NewEnquiry As MenuCommand = New MenuCommand("New Enquiry", AddressOf SalesEnquiryMenuCmd_Click)
        Dim menuSales_EnquiryList As MenuCommand = New MenuCommand("Enquiry List", AddressOf EnquiryListMenuCommand_Click)

        menuSales_Enquiry.Enabled = False
        menuSales_EnquiryList.Enabled = False

        If com.CheckGroupAccess(com, "sales | enquiry") Then
            menuSales_Enquiry.Enabled = True
        End If

        If com.CheckGroupAccess(com, "sales | enquiry | enquiry list") Then
            menuSales_EnquiryList.Enabled = True
        End If


        Dim menuSales_BQ As MenuCommand = New MenuCommand("&BQ", 0)
        'Dim menuSales_NewBQ As MenuCommand = New MenuCommand("New BQ", AddressOf BQMenuCmd_Click)
        Dim menuSales_BQList As MenuCommand = New MenuCommand("BQ List", AddressOf BQListMenuCommand_Click)

        menuSales_BQ.Enabled = False
        menuSales_BQList.Enabled = False

        If com.CheckGroupAccess(com, "sales | bq") Then
            menuSales_BQ.Enabled = True
        End If

        If com.CheckGroupAccess(com, "sales | bq | bq list") Then
            menuSales_BQList.Enabled = True
        End If

        Dim menuSales_Quotation As MenuCommand = New MenuCommand("&Quotation", 0)
        'Dim menuSales_NewQuotation As MenuCommand = New MenuCommand("&New Quotation", New EventHandler(AddressOf QuotationMenuCmd_Click))
        Dim menuSales_NewServiceTradingQuotation As MenuCommand = New MenuCommand("N&ew Service/Trading Quotation", New EventHandler(AddressOf OthQuotationMenuCmd_Click))
        Dim menuSales_QuotationList As MenuCommand = New MenuCommand("Quotation &List", New EventHandler(AddressOf QuotationListMenuCommand_Click))
        Dim menuSales_AlternativeQuotation As MenuCommand = New MenuCommand("&Alternative Quotation", New EventHandler(AddressOf RejoinQuotationMenuCommand_Click))
        Dim menuSales_MergeQuotation As MenuCommand = New MenuCommand("&Merge Quotation", New EventHandler(AddressOf MergeQuotationMenuCommand_Click))
        Dim menuSales_QuotationPendingForApproval As MenuCommand = New MenuCommand("Quotation Pending For &Approval", New EventHandler(AddressOf OutstandingQuotationMenuCommand_Click))

        menuSales_Quotation.Enabled = False
        'menuSales_NewQuotation.Enabled = False
        menuSales_NewServiceTradingQuotation.Enabled = False
        menuSales_QuotationList.Enabled = False
        menuSales_AlternativeQuotation.Enabled = False
        menuSales_MergeQuotation.Enabled = False
        menuSales_QuotationPendingForApproval.Enabled = False


        If com.CheckGroupAccess(com, "sales | Quotation") Then
            menuSales_Quotation.Enabled = True
        End If
        'If com.CheckGroupAccess(com, "sales | quotation | new quotation") Then
        'menuSales_NewQuotation.Enabled = True
        'End If
        If com.CheckGroupAccess(com, "sales | quotation | new service trading quotation") Then
            menuSales_NewServiceTradingQuotation.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | quotation | quotation list") Then
            menuSales_QuotationList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | quotation | alternative quotation") Then
            menuSales_AlternativeQuotation.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | quotation | merge quotation") Then
            menuSales_MergeQuotation.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | quotation | quotation pending for approval") Then
            menuSales_QuotationPendingForApproval.Enabled = True
        End If


        Dim menuSales_OrderConfirmation As MenuCommand = New MenuCommand("&Order Confirmation", 0)
        Dim menuSales_NewOrderConfirmation As MenuCommand = New MenuCommand("&New Order Confirmation (Without Quotation)", New EventHandler(AddressOf OrderConfirmationMenuCmd_Click))
        'Dim menuSales_OrderConfirmation2 As MenuCommand = New MenuCommand("N&ew Order Confirmation Services/Trading (Without Quotation)", New EventHandler(AddressOf OthOrderConfirmationMenuCmd_Click))
        Dim menuSales_OrderConfirmationList As MenuCommand = New MenuCommand("Order Confirmation &List", New EventHandler(AddressOf OrderConfirmListMenuCommand_Click))
        Dim menuSales_OrderConfirmationPendingForApproval As MenuCommand = New MenuCommand("Order Confirmation Pending For &Approval", New EventHandler(AddressOf OutstandingOCMenuCommand_Click))

        menuSales_OrderConfirmation.Enabled = False
        menuSales_NewOrderConfirmation.Enabled = False
        'menuSales_OrderConfirmation2.Enabled = False
        menuSales_OrderConfirmationList.Enabled = False
        menuSales_OrderConfirmationPendingForApproval.Enabled = False

        '''''''''''''''''''''''''''''''''''''''''''''''''
        If com.CheckGroupAccess(com, "sales | order confirmation") Then
            menuSales_OrderConfirmation.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | order confirmation | new order confirmation") Then
            menuSales_NewOrderConfirmation.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | order confirmation | order confirmation list") Then
            menuSales_OrderConfirmationList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | order confirmation | order confirmation pending for approval") Then
            menuSales_OrderConfirmationPendingForApproval.Enabled = True
        End If


        Dim menuSales_WorkOrder As MenuCommand = New MenuCommand("&Work Order", 0)
        Dim menuSales_NewWorkOrder As MenuCommand = New MenuCommand("&New Work Order (For orders without OC)", New EventHandler(AddressOf WorkOrderMenuCmd_Click))
        Dim menuSales_WorkOrderList As MenuCommand = New MenuCommand("Work Order &List", New EventHandler(AddressOf WorkOrderListMenuCmd_Click))
        Dim menuSales_WorkOrderPendingForApproval As MenuCommand = New MenuCommand("Work Order Pending For &Approval", New EventHandler(AddressOf WorkOrderApprovalListMenuCmd_Click))
        Dim menuSales_WorkOrderOnTimeDelivery As MenuCommand = New MenuCommand("Work Order On Time &Delivery", New EventHandler(AddressOf WorkOrderDeliveryMenuCmd_Click))

        menuSales_WorkOrder.Enabled = False
        menuSales_NewWorkOrder.Enabled = False
        menuSales_WorkOrderList.Enabled = False
        menuSales_WorkOrderPendingForApproval.Enabled = False
        menuSales_WorkOrderOnTimeDelivery.Enabled = False

        If com.CheckUserProfileAccess(com, "WONewNoOC") Then
            menuSales_NewWorkOrder.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "WOList") Then
            menuSales_WorkOrderList.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "WOPendingApproval") And com.CheckUserProfileApproval(com, "QuotationPendingApproval") Then
            menuSales_WorkOrderPendingForApproval.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "WOOnTimeDelivery") Then
            menuSales_WorkOrderOnTimeDelivery.Enabled = True
        End If
        menuSales_WorkOrderOnTimeDelivery.Enabled = False 'Temporarily disabled 

        ''''''''''''''''''''''''''''''''''''''''''
        If com.CheckGroupAccess(com, "sales | work order") Then
            menuSales_WorkOrder.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | work order | new work order") Then
            menuSales_NewWorkOrder.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | work order | work order list") Then
            menuSales_WorkOrderList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | work order | work order pending for approval") Then
            menuSales_WorkOrderPendingForApproval.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | work order | work order on time delivery") Then
            menuSales_WorkOrderOnTimeDelivery.Enabled = True
        End If

        Dim menuSales_DeliveryOrder As MenuCommand = New MenuCommand("&Delivery Order", 0)
        'Dim menuSales_DeliveryOrder1 As MenuCommand = New MenuCommand("&Outstanding Delivery Order List", New EventHandler(AddressOf DeliveryOrderListMenuCmd_Click))
        Dim menuSales_NewDeliveryOrder As MenuCommand = New MenuCommand("New Delivery Order", New EventHandler(AddressOf NewDeliveryOrderMenuCmd_Click))
        Dim menuSales_DeliveryOrderList As MenuCommand = New MenuCommand("Delivery Order List", New EventHandler(AddressOf NewDeliveryOrderListMenuCmd_Click))

        menuSales_DeliveryOrder.Enabled = False
        'menuSales_DeliveryOrder1.Enabled = False
        menuSales_NewDeliveryOrder.Enabled = False
        menuSales_DeliveryOrderList.Enabled = False

        If com.CheckUserProfileAccess(com, "DOOutstandingList") Then
            'menuSales_DeliveryOrder1.Enabled = True
        End If
        'menuSales_DeliveryOrder1.Enabled = False '1st deployment

        If com.CheckGroupAccess(com, "sales | delivery order") Then
            menuSales_DeliveryOrder.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | delivery order | new delivery order") Then
            menuSales_NewDeliveryOrder.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | delivery order | delivery order list") Then
            menuSales_DeliveryOrderList.Enabled = True
        End If

        Dim menuSales_StandardBox As MenuCommand = New MenuCommand("&Standard Box", 0)

        Dim menuSales_OGBFilerForSales As MenuCommand = New MenuCommand("&OGB Filer for Sales", New EventHandler(AddressOf NewOGBFilerforSales))
        Dim menuSales_NewOGBContract As MenuCommand = New MenuCommand("&New OGB Contract", New EventHandler(AddressOf NewOGBContract))
        Dim menuSales_OGBList As MenuCommand = New MenuCommand("OGB &List", New EventHandler(AddressOf NewOGBListing))
        Dim menuSales_PrintOGBNotification As MenuCommand = New MenuCommand("&Print OGB Notification", New EventHandler(AddressOf PrintOGBNotification))
        Dim menuSales_OGBRequestForLVForm As MenuCommand = New MenuCommand("OGB - Request for &LV form", New EventHandler(AddressOf PrintOGBForm28))
        Dim menuSales_OGBDeclarationOfWorkCompletion As MenuCommand = New MenuCommand("OGB - &Declaration of Work Completion", New EventHandler(AddressOf PrintOGBDWC))
        Dim menuSales_OGBSurveyOrderList As MenuCommand = New MenuCommand("OGB - Sur&vey Order List", New EventHandler(AddressOf SOListing))

        menuSales_StandardBox.Enabled = False
        menuSales_OGBFilerForSales.Enabled = False
        menuSales_NewOGBContract.Enabled = False
        menuSales_OGBList.Enabled = False
        menuSales_PrintOGBNotification.Enabled = False
        menuSales_OGBRequestForLVForm.Enabled = False
        menuSales_OGBDeclarationOfWorkCompletion.Enabled = False
        menuSales_OGBSurveyOrderList.Enabled = False


        If com.CheckGroupAccess(com, "sales | standard box") Then
            menuSales_StandardBox.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | ogb filer for sales") Then
            menuSales_OGBFilerForSales.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | new ogb contract") Then
            menuSales_NewOGBContract.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | ogb list") Then
            menuSales_OGBList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | print ogb notification") Then
            menuSales_PrintOGBNotification.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | ogb request for lv form") Then
            menuSales_OGBRequestForLVForm.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | ogb declaration of work completion") Then
            menuSales_OGBDeclarationOfWorkCompletion.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | ogb survey order list") Then
            menuSales_OGBSurveyOrderList.Enabled = True
        End If

        Dim window4 As MenuCommand = New MenuCommand("-")
        Dim menuSales_LVBFilerForSales As MenuCommand = New MenuCommand("&LVB Filer for Sales", New EventHandler(AddressOf NewLVBFilerforSales))
        Dim menuSales_NewLVBContract As MenuCommand = New MenuCommand("&New LVB Contract", New EventHandler(AddressOf NewLVBContract))
        Dim menuSales_LVBList As MenuCommand = New MenuCommand("LVB &List", New EventHandler(AddressOf LVBListing))
        Dim menuSales_PrintLVBNotification As MenuCommand = New MenuCommand("&Print LVB Notification", New EventHandler(AddressOf PrintNotification))
        Dim menuSales_RequestForLVForm As MenuCommand = New MenuCommand("LVB - Request For &LV form", New EventHandler(AddressOf PrintLVBForm28))
        Dim menuSales_LVBDeclarationOfWorkCompletion As MenuCommand = New MenuCommand("LVB - &Declaration of Work Completion", New EventHandler(AddressOf PrintLVBDWC))

        menuSales_LVBFilerForSales.Enabled = False
        menuSales_NewLVBContract.Enabled = False
        menuSales_LVBList.Enabled = False
        menuSales_PrintLVBNotification.Enabled = False
        menuSales_RequestForLVForm.Enabled = False
        menuSales_LVBDeclarationOfWorkCompletion.Enabled = False


        '''''''''''''''''''''''
        If com.CheckGroupAccess(com, "sales | standard box | lvb filer for sales") Then
            menuSales_LVBFilerForSales.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | new lvb contract") Then
            menuSales_NewLVBContract.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | lvb list") Then
            menuSales_LVBList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | print lvb notification") Then
            menuSales_PrintLVBNotification.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | request for lv form") Then
            menuSales_RequestForLVForm.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | standard box | lvb declaration of work completion") Then
            menuSales_LVBDeclarationOfWorkCompletion.Enabled = True
        End If

        Dim menuSales_ReportsOGBLVB As MenuCommand = New MenuCommand("&Reports - OGB/LVB", 0)
        Dim menuSales_ReportsOGBNotSurveyed As MenuCommand = New MenuCommand("Reports: OGB-Not Sur&veyed", New EventHandler(AddressOf PrintOGBReportsNotSurveyed))
        Dim menuSales_ReportsOGBInvoicingStatus As MenuCommand = New MenuCommand("Reports: OGB-&Invoicing Status", New EventHandler(AddressOf PrintOGBReportsInvocing))
        Dim menuSales_ReportsOGBPendingTOC As MenuCommand = New MenuCommand("Reports: OGB-Pending &TOC", New EventHandler(AddressOf PrintOGBReportsPendingTOC))
        Dim menuSales_ReportsOGBInstallationAndFeedbackRecord As MenuCommand = New MenuCommand("Reports: OGB Installation and Feedback Record", New EventHandler(AddressOf PrintOGBFeedback))

        menuSales_ReportsOGBLVB.Enabled = False
        menuSales_ReportsOGBNotSurveyed.Enabled = False '82
        menuSales_ReportsOGBInvoicingStatus.Enabled = False '84
        menuSales_ReportsOGBPendingTOC.Enabled = False '85
        menuSales_ReportsOGBInstallationAndFeedbackRecord.Enabled = False

        '''''''''''''''''''''''''''
        If com.CheckGroupAccess(com, "sales | reports ogblvb") Then
            menuSales_ReportsOGBLVB.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | reports ogblvb | reports ogb not surveyed") Then
            menuSales_ReportsOGBNotSurveyed.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | reports ogblvb | reports ogb invoicing status") Then
            menuSales_ReportsOGBInvoicingStatus.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | reports ogblvb | reports ogb pending toc") Then
            menuSales_ReportsOGBPendingTOC.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | reports ogblvb | reports ogb installation and feedback record") Then
            menuSales_ReportsOGBInstallationAndFeedbackRecord.Enabled = True
        End If

        Dim window5 As MenuCommand = New MenuCommand("-")
        Dim menuSales_ReportsLVBInvoicingStatus As MenuCommand = New MenuCommand("Reports: LVB-&Invoicing Status", New EventHandler(AddressOf PrintLVBReportsInvocing))
        Dim menuSales_ReportsLVBPendingTOC As MenuCommand = New MenuCommand("Reports: LVB-Pending &TOC", New EventHandler(AddressOf PrintLVBReportsPendingTOC))
        Dim menuSales_ReportsLVBInstallationAndFeedbackRecord As MenuCommand = New MenuCommand("Reports: LVB Installation and Feedback Record", New EventHandler(AddressOf PrintLVBFeedback))

        menuSales_ReportsLVBInvoicingStatus.Enabled = False '86
        menuSales_ReportsLVBPendingTOC.Enabled = False '87
        menuSales_ReportsLVBInstallationAndFeedbackRecord.Enabled = False

        ''''''''''''''''''''''''''''''''''''''''''''''''
        If com.CheckGroupAccess(com, "sales | reports ogblvb | reports lvb invoicing status") Then
            menuSales_ReportsLVBInvoicingStatus.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | reports ogblvb | reports lvb pending toc") Then
            menuSales_ReportsLVBPendingTOC.Enabled = True
        End If
        If com.CheckGroupAccess(com, "sales | reports ogblvb | reports lvb installation and feedback record") Then
            menuSales_ReportsLVBInstallationAndFeedbackRecord.Enabled = True
        End If

        menuSales_Enquiry.MenuCommands.AddRange(New MenuCommand() {menuSales_EnquiryList})
        menuSales_BQ.MenuCommands.AddRange(New MenuCommand() {menuSales_BQList})

        menuSales_Quotation.MenuCommands.AddRange(New MenuCommand() {menuSales_NewServiceTradingQuotation, menuSales_QuotationList, menuSales_AlternativeQuotation, menuSales_MergeQuotation, menuSales_QuotationPendingForApproval})
        menuSales_OrderConfirmation.MenuCommands.AddRange(New MenuCommand() {menuSales_NewOrderConfirmation, menuSales_OrderConfirmationList, menuSales_OrderConfirmationPendingForApproval})
        menuSales_WorkOrder.MenuCommands.AddRange(New MenuCommand() {menuSales_NewWorkOrder, menuSales_WorkOrderList, menuSales_WorkOrderPendingForApproval})    '{menuSales_NewWorkOrder, menuSales_WorkOrderList, menuSales_WorkOrderPendingForApproval, menuSales_WorkOrderOnTimeDelivery})
        menuSales_DeliveryOrder.MenuCommands.AddRange(New MenuCommand() {menuSales_NewDeliveryOrder, menuSales_DeliveryOrderList})
        menuSales_StandardBox.MenuCommands.AddRange(New MenuCommand() {menuSales_OGBFilerForSales, menuSales_NewOGBContract, menuSales_OGBList, menuSales_PrintOGBNotification, menuSales_OGBRequestForLVForm, menuSales_OGBDeclarationOfWorkCompletion, menuSales_OGBSurveyOrderList, window4, menuSales_LVBFilerForSales, menuSales_NewLVBContract, menuSales_LVBList, menuSales_PrintLVBNotification, menuSales_RequestForLVForm, menuSales_LVBDeclarationOfWorkCompletion})
        menuSales_ReportsOGBLVB.MenuCommands.AddRange(New MenuCommand() {menuSales_ReportsOGBNotSurveyed, menuSales_ReportsOGBInvoicingStatus, menuSales_ReportsOGBPendingTOC, menuSales_ReportsOGBInstallationAndFeedbackRecord, window5, menuSales_ReportsLVBInvoicingStatus, menuSales_ReportsLVBPendingTOC, menuSales_ReportsLVBInstallationAndFeedbackRecord})

        mc.MenuCommands.AddRange(New MenuCommand() {menuSales_Enquiry, menuSales_BQ, menuSales_Quotation, menuSales_OrderConfirmation, menuSales_WorkOrder, menuSales_DeliveryOrder, menuSales_StandardBox, menuSales_ReportsOGBLVB})

        If com.USERID <> 58 And com.USERID <> 3 And com.USERID <> 67 _
And com.USERID <> 23 And com.USERID <> 74 And com.USERID <> 68 And com.USERID <> 77 Then
            'menuSales_StandardBox.Enabled = False
            'menuSales_ReportsOGBLVB.Enabled = False
        End If


    End Sub
    Protected Sub CreatePurchasingMenu(ByVal mc As MenuCommand)

        'created by alan
        Dim stylePR As MenuCommand = New MenuCommand("&Purchase Requisition", 0)
        'Dim menuPR_StorePR As MenuCommand = New MenuCommand("&New PR", 0) 'New EventHandler(AddressOf PRMenuCmd_Click))
        Dim window5 As MenuCommand = New MenuCommand("-")

        Dim menuPR_StorePR As MenuCommand = New MenuCommand("Store PR", New EventHandler(AddressOf StorePRMenuCmd_Click))
        Dim menuPR_SalesPR As MenuCommand = New MenuCommand("Sales PR", New EventHandler(AddressOf SalesPRMenuCmd_Click))
        Dim menuPR_FactoryPR As MenuCommand = New MenuCommand("Factory PR", New EventHandler(AddressOf FactoryPRMenuCmd_Click))
        Dim menuPR_ProjectPR As MenuCommand = New MenuCommand("Project PR", New EventHandler(AddressOf ProjectPRMenuCmd_Click))

        menuPR_StorePR.Enabled = False
        menuPR_SalesPR.Enabled = False
        menuPR_FactoryPR.Enabled = False
        menuPR_ProjectPR.Enabled = False

        If com.CheckGroupAccess(com, "purchasing | pr") Then
            stylePR.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | pr | store pr") Then
            menuPR_StorePR.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | pr | sales pr") Then
            menuPR_SalesPR.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | pr | factory pr") Then
            menuPR_FactoryPR.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | pr | project pr") Then
            menuPR_ProjectPR.Enabled = True
        End If

        Dim menuPR_PRList As MenuCommand = New MenuCommand("PR &List", New EventHandler(AddressOf PRMenuCmd_Click))
        Dim menuPR_PRPendingForApproval As MenuCommand = New MenuCommand("PR Pending For &Approval", New EventHandler(AddressOf PRApproveListMenuCmd_Click))
        Dim menuPR_PRPendingForPurchasing As MenuCommand = New MenuCommand("PR Pending For Purchasing", New EventHandler(AddressOf PRPendingListMenuCmd_Click))

        menuPR_PRList.Enabled = False
        menuPR_PRPendingForApproval.Enabled = False
        menuPR_PRPendingForPurchasing.Enabled = False

        If com.CheckGroupAccess(com, "purchasing | pr | pr pending for approval") Then
            menuPR_PRPendingForApproval.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | pr | pr pending for purchasing") Then
            menuPR_PRPendingForPurchasing.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | pr | pr list") Then
            menuPR_PRList.Enabled = True
        End If

        Dim menuPO As MenuCommand = New MenuCommand("Purchase &Order", 0)
        Dim menuPO_NewPO As MenuCommand = New MenuCommand("&New PO", 0) 'New EventHandler(AddressOf POMenuCmd_Click))
        Dim menuPO_POList As MenuCommand = New MenuCommand("PO &List", New EventHandler(AddressOf POMenuCmd_Click))
        Dim menuPO_GeneratePO As MenuCommand = New MenuCommand("Generate PO", New EventHandler(AddressOf POGenerate_Click))
        'Dim menuPO_GeneratePO As MenuCommand = New MenuCommand("PO Pending For &Approval", 0) 'New EventHandler(AddressOf POMenuCmd_Click))

        menuPO.Enabled = False
        menuPO_NewPO.Enabled = False
        menuPO_POList.Enabled = False
        menuPO_GeneratePO.Enabled = False

        If com.CheckGroupAccess(com, "purchasing | po") Then
            menuPO.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | po | new po") Then
            menuPO_NewPO.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | po | po list") Then
            menuPO_POList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | po | generate po") Then
            menuPO_GeneratePO.Enabled = True
        End If

        Dim menuPO_Reports As MenuCommand = New MenuCommand("&Reports", 0)
        Dim menuPO_OutstandingPOReport As MenuCommand = New MenuCommand("&Outstanding PO Report", New EventHandler(AddressOf OutstandingPOMenuCmd_Click))
        Dim menuPO_SupplierOnTimeDeliveryReport As MenuCommand = New MenuCommand("Supplier &On-Time Delivery Report", New EventHandler(AddressOf OnTimeDeliveryMenuCmd_Click))
        Dim menuPO_OustandingItemList As MenuCommand = New MenuCommand("Outstanding &Item List", New EventHandler(AddressOf OutstandingItemMenuCmd_Click))
        Dim menuPO_WorkOrderPOReport As MenuCommand = New MenuCommand("&Work Order PO Report", New EventHandler(AddressOf WorkOrderPOReportMenuCmd_Click))

        menuPO_Reports.Enabled = False
        menuPO_OutstandingPOReport.Enabled = False
        menuPO_SupplierOnTimeDeliveryReport.Enabled = False
        menuPO_OustandingItemList.Enabled = False
        menuPO_WorkOrderPOReport.Enabled = False

        If com.CheckGroupAccess(com, "purchasing | reports") Then
            menuPO_Reports.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | reports | outstanding po report") Then
            menuPO_OutstandingPOReport.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | reports | supplier on time delivery report") Then
            menuPO_SupplierOnTimeDeliveryReport.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | reports | outstanding item list") Then
            menuPO_OustandingItemList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "purchasing | reports | work order po report") Then
            menuPO_WorkOrderPOReport.Enabled = True
        End If


        'Dim menuSales_ReportsLVBPendingTOC As MenuCommand = New MenuCommand("&Supplier Query & Report", New EventHandler(AddressOf SupplierListReportMenuCmd_Click))
        stylePR.MenuCommands.AddRange(New MenuCommand() {menuPR_StorePR, menuPR_SalesPR, menuPR_FactoryPR, menuPR_ProjectPR, window5, menuPR_PRPendingForApproval, menuPR_PRPendingForPurchasing, menuPR_PRList})
        menuPO.MenuCommands.AddRange(New MenuCommand() {menuPO_POList, menuPO_GeneratePO})
        menuPO_Reports.MenuCommands.AddRange(New MenuCommand() {menuPO_OutstandingPOReport, menuPO_SupplierOnTimeDeliveryReport, menuPO_OustandingItemList, menuPO_WorkOrderPOReport})
        '        menuSales_ReportsOGBInvoicingStatus.Visible = False 'deployment 3 - temporarily hide. function not done.

        mc.MenuCommands.AddRange(New MenuCommand() {stylePR, menuPO, menuPO_Reports})


    End Sub
    Protected Sub CreateProductionMenu(ByVal mc As MenuCommand)

        'created by alan
        Dim menuWO As MenuCommand = New MenuCommand("Work &Order", 0)
        Dim menuWO_OutstandingWorkOrder As MenuCommand = New MenuCommand("&Outstanding Work Orders", New EventHandler(AddressOf OutstandingWOMenuCmd_Click))

        Dim menuWorkPlan As MenuCommand = New MenuCommand("Work &Plan", 0)
        Dim menuWorkPlan_WorkPlanList As MenuCommand = New MenuCommand("Work Plan &List", New EventHandler(AddressOf WorkPlanListMenuCmd_Click))

        Dim menuDO As MenuCommand = New MenuCommand("&Delivery Note", 0)
        'Dim styleProductionDN1 As MenuCommand = New MenuCommand("&New Delivery Note", 0)
        'Dim styleProductionDN2 As MenuCommand = New MenuCommand("Delivery Note &List", 0)
        Dim menuDO_DeliveryNoteList As MenuCommand = New MenuCommand("Delivery Note &List", New EventHandler(AddressOf DeliveryNoteListMenuCmd_Click))

        'Dim styleProductionWR As MenuCommand = New MenuCommand("&Withdrawal Request", 0)
        menuWO.Enabled = False
        menuWO_OutstandingWorkOrder.Enabled = False
        menuWorkPlan.Enabled = False
        menuWorkPlan_WorkPlanList.Enabled = False
        menuDO.Enabled = False
        menuDO_DeliveryNoteList.Enabled = False

        menuWO.MenuCommands.AddRange(New MenuCommand() {menuWO_OutstandingWorkOrder})
        menuWorkPlan.MenuCommands.AddRange(New MenuCommand() {menuWorkPlan_WorkPlanList})
        menuDO.MenuCommands.AddRange(New MenuCommand() {menuDO_DeliveryNoteList})

        mc.MenuCommands.AddRange(New MenuCommand() {menuWO_OutstandingWorkOrder, menuWorkPlan_WorkPlanList, menuDO_DeliveryNoteList})


        
        If com.CheckGroupAccess(com, "production | outstanding work orders") Then
            menuWO_OutstandingWorkOrder.Enabled = True
        End If
        If com.CheckGroupAccess(com, "production | work plan list") Then
            menuWorkPlan_WorkPlanList.Enabled = True
        End If
        If com.CheckGroupAccess(com, "production | delivery note list") Then
            menuDO_DeliveryNoteList.Enabled = True
        End If


    End Sub
    Protected Sub CreateQAMenu(ByVal mc As MenuCommand)

        'created by alan
        'Dim styleQA As MenuCommand = New MenuCommand("&QA", 0)
        Dim menuQA_ProductPendingForInspection As MenuCommand = New MenuCommand("Product Pending For &Inspection", New EventHandler(AddressOf QAListMenuCommand_Click))
        Dim menuQA_QAInspectionReport As MenuCommand = New MenuCommand("QA Inspection Report", New EventHandler(AddressOf QAInspectionListMenuCommand_Click))
        menuQA_ProductPendingForInspection.Enabled = True
        menuQA_QAInspectionReport.Enabled = True

        'styleQA.MenuCommands.AddRange(New MenuCommand() {styleQA})
        mc.MenuCommands.AddRange(New MenuCommand() {menuQA_ProductPendingForInspection, menuQA_QAInspectionReport})

        menuQA_ProductPendingForInspection.Enabled = False
        menuQA_QAInspectionReport.Enabled = False

        If com.CheckGroupAccess(com, "quality assurance  | product pending for inspection") Then
            menuQA_ProductPendingForInspection.Enabled = True
        End If

        If com.CheckGroupAccess(com, "quality assurance  | qa inspection report") Then
            menuQA_QAInspectionReport.Enabled = True
        End If

    End Sub
    Protected Sub CreateInventoryMenu(ByVal mc As MenuCommand)

        'created by alan
        Dim styleStockIn As MenuCommand = New MenuCommand("Stock &In", 0)
        Dim styleStockIn1 As MenuCommand = New MenuCommand("Stock In (&Based on PO)", New EventHandler(AddressOf StockInPOMenuCmd_Click))
        Dim styleStockIn2 As MenuCommand = New MenuCommand("Stock In (&Loose Items)", New EventHandler(AddressOf StockInLooseMenuCmd_Click))
        Dim styleStockIn3 As MenuCommand = New MenuCommand("Stock In (DO)", New EventHandler(AddressOf StockOutSRVMenuCmd_Click))
        Dim styleStockIn4 As MenuCommand = New MenuCommand("Return In (RTN)", New EventHandler(AddressOf StockOutSRVMenuCmd_Click))


        Dim styleStockOut As MenuCommand = New MenuCommand("Stock &Out", 0)
        Dim styleStockOut1 As MenuCommand = New MenuCommand("Stock Out (&Based on WO)", New EventHandler(AddressOf StockOutWOMenuCmd_Click))
		Dim styleStockOut2 As MenuCommand = New MenuCommand("Stock Out (&Loose Item)", New EventHandler(AddressOf StockOutLooseMenuCmd_Click))
        Dim styleStockOut3 As MenuCommand = New MenuCommand("Withdraw (SRV)", New EventHandler(AddressOf StockOutSRVMenuCmd_Click))
        
        Dim styleStockMgt As MenuCommand = New MenuCommand("Stock &Management", 0)
        Dim styleStockMgt1 As MenuCommand = New MenuCommand("Stock &Relocation", New EventHandler(AddressOf StockRelocateMenuCmd_Click))
        Dim styleStockMgt2 As MenuCommand = New MenuCommand("Stock &Adjustment", New EventHandler(AddressOf StockAdjustmentMenuCmd_Click))

        Dim styleStockReport As MenuCommand = New MenuCommand("&Reports", 0)
        Dim styleStockReport1 As MenuCommand = New MenuCommand("&Inventory Report", New EventHandler(AddressOf InventoryListingMenuCmd_Click))
        Dim styleStockReport2 As MenuCommand = New MenuCommand("&Low Stock Alert", New EventHandler(AddressOf LowStockAlertMenuCmd_Click))
        Dim styleStockReport3 As MenuCommand = New MenuCommand("&Over Stock Alert", New EventHandler(AddressOf OverStockAlertMenuCmd_Click))

        styleStockIn.MenuCommands.AddRange(New MenuCommand() {styleStockIn1, styleStockIn2, styleStockIn3, styleStockIn4})
        styleStockOut.MenuCommands.AddRange(New MenuCommand() {styleStockOut1, styleStockOut2, styleStockOut3})
        styleStockMgt.MenuCommands.AddRange(New MenuCommand() {styleStockMgt1, styleStockMgt2})
        styleStockReport.MenuCommands.AddRange(New MenuCommand() {styleStockReport1, styleStockReport2, styleStockReport3})

        mc.MenuCommands.AddRange(New MenuCommand() {styleStockIn, styleStockOut, styleStockMgt, styleStockReport})

        styleStockIn1.Enabled = False
        styleStockIn2.Enabled = False
        styleStockOut1.Enabled = False
        styleStockOut2.Enabled = False
        styleStockMgt1.Enabled = False
        styleStockMgt2.Enabled = False
        styleStockReport1.Enabled = False
        styleStockReport2.Enabled = False
        styleStockReport3.Enabled = False

        If com.CheckUserProfileAccess(com, "StockInPO") Then
            styleStockIn1.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockInLoose") Then
            styleStockIn2.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockOutWO") Then
            styleStockOut1.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockOutLoose") Then
            styleStockOut2.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockRelocate") Then
            styleStockMgt1.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockAdjust") Then
            styleStockMgt2.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockInventoryReport") Then
            styleStockReport1.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockLowReport") Then
            styleStockReport2.Enabled = True
        End If
        If com.CheckUserProfileAccess(com, "StockOverReport") Then
            styleStockReport3.Enabled = True
        End If
        'Dim styleInventory As MenuCommand = New MenuCommand("&Inventory", 0)
        'Dim styleInventory1 As MenuCommand = New MenuCommand("Stock In (Based on PO)", New EventHandler(AddressOf StockInPOMenuCmd_Click))
        'Dim styleInventory2 As MenuCommand = New MenuCommand("Stock In (Loose Items)", New EventHandler(AddressOf StockInLooseMenuCmd_Click))
        'Dim styleInventory3 As MenuCommand = New MenuCommand("Stock Relocation", New EventHandler(AddressOf StockRelocateMenuCmd_Click))
        'Dim styleInventory4 As MenuCommand = New MenuCommand("Stock Adjustment", New EventHandler(AddressOf StockAdjustmentMenuCmd_Click))
        'styleInventory.MenuCommands.AddRange(New MenuCommand() {styleInventory1, styleInventory2, styleInventory3, styleInventory4})

    End Sub

    Protected Sub CreateInventoryMenuNew(ByVal mc As MenuCommand) 'Danial

        Dim styleStockTrans As MenuCommand = New MenuCommand("Stock Transactions", 0)
        Dim styleStockInDO As MenuCommand = New MenuCommand("Stock in (DO)", New EventHandler(AddressOf StockInDOMenuCmd_Click))
        Dim styleWithdrawSRV As MenuCommand = New MenuCommand("Withdraw (SRV)", New EventHandler(AddressOf WithdrawSRVMenuCmd_Click))
        Dim styleWithdrawPMR As MenuCommand = New MenuCommand("Withdraw (PMR)", New EventHandler(AddressOf WithdrawPMRMenuCmd_Click))
        Dim styleReturnIn As MenuCommand = New MenuCommand("Return-in (RTN)", New EventHandler(AddressOf ReturnInMenuCmd_Click))
        Dim styleStockTransfer As MenuCommand = New MenuCommand("Stock Transfer(ST)", New EventHandler(AddressOf StockTransferMenuCmd_Click))
        Dim styleStockAdjust As MenuCommand = New MenuCommand("Stock Adjustment(SA)", New EventHandler(AddressOf StockAdjustMenuCmd_Click))

        styleStockTrans.Enabled = False
        styleStockInDO.Enabled = False
        styleWithdrawSRV.Enabled = False
        styleWithdrawPMR.Enabled = False
        styleReturnIn.Enabled = False
        styleStockTransfer.Enabled = False
        styleStockAdjust.Enabled = False

        If com.CheckGroupAccess(com, "inventory management | stock transations") Then
            styleStockTrans.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | stock transactions | stock in do") Then
            styleStockInDO.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | stock transactions | withdraw srv") Then
            styleWithdrawSRV.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | stock transactions | withdraw pmr") Then
            styleWithdrawPMR.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | stock transactions | return in") Then
            styleReturnIn.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | stock transactions | stock transfer") Then
            styleStockTransfer.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | stock transactions | stock adjust") Then
            styleStockAdjust.Enabled = True
        End If
       
        Dim styleStockViewer As MenuCommand = New MenuCommand("Stock viewer", New EventHandler(AddressOf StockViewerMenuCmd_Click))
        Dim styleStockReport As MenuCommand = New MenuCommand("&Reports", 0)
        Dim styleStockInventoryReport As MenuCommand = New MenuCommand("Stock &Inventory Report", New EventHandler(AddressOf InventoryListingMenuCmd_Click))
        Dim styleStockTransactionReport As MenuCommand = New MenuCommand("Stock Transaction Report", New EventHandler(AddressOf StockTransactionReportMenuCmd_Click))
        Dim styleStockBalDetReport As MenuCommand = New MenuCommand("Stock &Balance Details Report", New EventHandler(AddressOf StockBalDetReportMenuCmd_Click))
        Dim styleStockTakeForm As MenuCommand = New MenuCommand("Stock &Taking and Assessment Form", New EventHandler(AddressOf StockTakeFormMenuCmd_Click))

        styleStockViewer.Enabled = False
        styleStockReport.Enabled = False
        styleStockInventoryReport.Enabled = False
        styleStockTransactionReport.Enabled = False
        styleStockBalDetReport.Enabled = False
        styleStockTakeForm.Enabled = False

        If com.CheckGroupAccess(com, "inventory management | stock viewer") Then
            styleStockViewer.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | reports") Then
            styleStockReport.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | reports | stock inventory report") Then
            styleStockInventoryReport.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | reports | stock transaction report") Then
            styleStockTransactionReport.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | reports | stock balance detail report") Then
            styleStockBalDetReport.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | reports | stock taking and assessment form") Then
            styleStockTakeForm.Enabled = True
        End If

        'Dim styleStockReport2 As MenuCommand = New MenuCommand("&Low Stock Alert", New EventHandler(AddressOf LowStockAlertMenuCmd_Click))
        'Dim styleStockReport3 As MenuCommand = New MenuCommand("&Over Stock Alert", New EventHandler(AddressOf OverStockAlertMenuCmd_Click))

        Dim styleFGTrans As MenuCommand = New MenuCommand("Finished Goods Transactions", 0)
        Dim styleFWG As MenuCommand = New MenuCommand("Goods Withdraw (FGW)", New EventHandler(AddressOf FGWMenuCmd_Click))
        Dim styleFWGDO As MenuCommand = New MenuCommand("Goods Withdraw (DO)", New EventHandler(AddressOf FGWDOMenuCmd_Click))
        Dim styleFWGNOI As MenuCommand = New MenuCommand("Goods Withdraw (NOI)", New EventHandler(AddressOf FGWNOIMenuCmd_Click))

        Dim styleQAR As MenuCommand = New MenuCommand("QA - Inspection Report (QAR)", New EventHandler(AddressOf QARMenuCmd_Click)) 'QAR becomes QAR
        Dim styleINT As MenuCommand = New MenuCommand("Goods Internal (Int)", New EventHandler(AddressOf INTMenuCmd_Click))

        styleFGTrans.Enabled = False
        styleFWG.Enabled = False
        styleFWGDO.Enabled = False
        styleFWGNOI.Enabled = False
        styleQAR.Enabled = False
        styleINT.Enabled = False

        If com.CheckGroupAccess(com, "inventory management | finished good transactions") Then
            styleFGTrans.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | finished good transactions | goods withdraw fgw") Then
            styleFWG.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | finished good transactions | goods withdraw do") Then
            styleFWGDO.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | finished good transactions | goods withdraw noi") Then
            styleFWGNOI.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | finished good transactions | goods recieved qar") Then
            styleQAR.Enabled = True
        End If
        If com.CheckGroupAccess(com, "inventory management | finished good transactions | goods internal int") Then
            styleINT.Enabled = True
        End If


        styleStockTrans.MenuCommands.AddRange(New MenuCommand() {styleStockInDO, styleReturnIn, styleWithdrawSRV, styleWithdrawPMR, styleStockTransfer, styleStockAdjust})
        styleStockReport.MenuCommands.AddRange(New MenuCommand() {styleStockInventoryReport, styleStockTransactionReport, styleStockBalDetReport, styleStockTakeForm})
        styleFGTrans.MenuCommands.AddRange(New MenuCommand() {styleFWG, styleFWGDO, styleFWGNOI, styleQAR, styleINT})

        mc.MenuCommands.AddRange(New MenuCommand() {styleStockTrans, styleFGTrans, styleStockViewer, styleStockReport})


    End Sub

    Protected Sub CreateFinanceMenu(ByVal mc As MenuCommand)

        'created by alan
        Dim styleFinance As MenuCommand = New MenuCommand("&Delivery Order - Invoicing", 0) 'New EventHandler(AddressOf QAListMenuCommand_Click))
        styleFinance.Enabled = False '2nd Deployment
        'styleFinance.MenuCommands.AddRange(New MenuCommand() {styleFinance})

        mc.MenuCommands.AddRange(New MenuCommand() {styleFinance})
        styleFinance.Enabled = False

        If com.CheckGroupAccess(com, "finance | delivery order invoicing") Then
            styleFinance.Enabled = True
        End If

    End Sub
    Protected Sub CreateSetupMenu(ByVal mc As MenuCommand)

        ' Create menu commands
        ' Create Admin Menu - Company, Security, etc...
        Dim styleAdminSetup As MenuCommand = New MenuCommand("&Admin", 0)
        'Dim styleMyCompanySetup As MenuCommand = New MenuCommand("My &Company Profile", 0)
        Dim styleMyPasswordSetup As MenuCommand = New MenuCommand("My &Password", New EventHandler(AddressOf MyPasswordMenuCmd_Click))
        Dim styleSecuritySetup As MenuCommand = New MenuCommand("&Security Setup", 0)
        Dim styleSecurityUserGroup As MenuCommand = New MenuCommand("User Group", New EventHandler(AddressOf UserGroupMenuCmd_Click))
        Dim styleSecurityUserProfile As MenuCommand = New MenuCommand("User Profile", New EventHandler(AddressOf UserProfileMenuCmd_Click))
        styleSecuritySetup.MenuCommands.AddRange(New MenuCommand() {styleSecurityUserGroup, styleSecurityUserProfile})

        'styleMyCompanySetup.Enabled = False
        styleAdminSetup.Enabled = False
        styleMyPasswordSetup.Enabled = False
        styleSecuritySetup.Enabled = False
        styleSecurityUserGroup.Enabled = False
        styleSecurityUserProfile.Enabled = False
        'If com.CheckUserProfileAccess(com, "MyCompany") Then
        'styleMyCompanySetup.Enabled = True
        'End If

        If com.CheckGroupAccess(com, "setup | admin") Then
            styleAdminSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | admin | security setup") Then
            styleSecuritySetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | admin | security setup | user group") Then
            styleSecurityUserGroup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | admin | security setup | user profile") Then
            styleSecurityUserProfile.Enabled = True
        End If

        'Dim styleMyGeneralProfileSetup As MenuCommand = New MenuCommand("My General &Profile", 0)
        'styleAdminSetup.MenuCommands.AddRange(New MenuCommand() {styleMyCompanySetup, styleMyPasswordSetup, styleSecuritySetup, styleMyGeneralProfileSetup})
        styleAdminSetup.MenuCommands.AddRange(New MenuCommand() {styleMyPasswordSetup, styleSecuritySetup})
        'styleMyGeneralProfileSetup.Enabled = False
        'If com.CheckUserProfileAccess(com, "") Then
        'styleMyGeneralProfileSetup.Enabled = True
        'End If
        ' Create Contacts Menu
        Dim styleContactsSetup As MenuCommand = New MenuCommand("&Contacts", 0)
        Dim styleMyConsultantSetup As MenuCommand = New MenuCommand("My C&onsultants", New EventHandler(AddressOf ConsultantListMenuCommand_Click))
        Dim styleMyCustomerSetup As MenuCommand = New MenuCommand("My &Customers", New EventHandler(AddressOf CustomerListMenuCommand_Click))
        Dim styleMySupplierSetup As MenuCommand = New MenuCommand("My &Suppliers", New EventHandler(AddressOf SupplierListMenuCommand_Click))
        Dim styleMyOfficerSetup As MenuCommand = New MenuCommand("My &Officer", New EventHandler(AddressOf OfficerListMenuCommand_Click))
        styleContactsSetup.MenuCommands.AddRange(New MenuCommand() {styleMyConsultantSetup, styleMyCustomerSetup, styleMySupplierSetup, styleMyOfficerSetup})

        styleContactsSetup.Enabled = False
        styleMyConsultantSetup.Enabled = False
        styleMyCustomerSetup.Enabled = False
        styleMySupplierSetup.Enabled = False
        styleMyOfficerSetup.Enabled = False

        If com.CheckGroupAccess(com, "setup | contacts") Then
            styleContactsSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | contacts | consultants") Then
            styleMyConsultantSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | contacts | customers") Then
            styleMyCustomerSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | contacts | suppliers") Then
            styleMySupplierSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | contacts | officers") Then
            styleMyOfficerSetup.Enabled = True
        End If

        ' Create Products Menu
        Dim styleProductsSetup As MenuCommand = New MenuCommand("&Parts / Products", 0)
        Dim styleProduct1 As MenuCommand = New MenuCommand("My Parts / Product &Category", New EventHandler(AddressOf CategoryMenuCmd_Click))
        Dim styleProduct2 As MenuCommand = New MenuCommand("My &Parts / Product", New EventHandler(AddressOf ManagePartsMenuCommand_Click))
        Dim styleUOMSetup As MenuCommand = New MenuCommand("My &UOM", New EventHandler(AddressOf ManageUOMMenuCommand_Click))
        Dim stylePartCodeSetup As MenuCommand = New MenuCommand("My Part&Code", New EventHandler(AddressOf ManagePartCodeMenuCommand_Click))

        styleProductsSetup.MenuCommands.AddRange(New MenuCommand() {styleProduct1, styleProduct2, styleUOMSetup, stylePartCodeSetup})

        styleProductsSetup.Enabled = False
        styleProduct1.Enabled = False
        styleProduct2.Enabled = False
        styleUOMSetup.Enabled = False
        stylePartCodeSetup.Enabled = False

        If com.CheckGroupAccess(com, "setup | parts products") Then
            styleProductsSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | parts products | category") Then
            styleProduct1.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | parts products | parts products") Then
            styleProduct2.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | parts products | uom") Then
            styleUOMSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | parts products | part code") Then
            stylePartCodeSetup.Enabled = True
        End If


        ' Create Warehouse Menu
        Dim styleWarehouseSetup As MenuCommand = New MenuCommand("&Warehouse", 0)
        Dim styleWarehouse1 As MenuCommand = New MenuCommand("My &Warehouse", New EventHandler(AddressOf WareHouseMenuCmd_Click))
        'Dim styleWarehouse2 As MenuCommand = New MenuCommand("My Warehouse &Area", 0)
        'Dim styleWarehouse3 As MenuCommand = New MenuCommand("My Warehouse &Location", 0)
        styleWarehouseSetup.MenuCommands.AddRange(New MenuCommand() {styleWarehouse1})

        styleWarehouseSetup.Enabled = False
        styleWarehouse1.Enabled = False

        If com.CheckGroupAccess(com, "setup | warehouse") Then
            styleWarehouseSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | warehouse | warehouse") Then
            styleWarehouse1.Enabled = True
        End If


        ' Create System Menu 
        Dim styleSystemSetup As MenuCommand = New MenuCommand("S&ystem", 0)
        Dim styleMyCurrencySetup As MenuCommand = New MenuCommand("My Cu&rrency", New EventHandler(AddressOf CurrencyListMenuCommand_Click))
        Dim styleMyDocNoSetup As MenuCommand = New MenuCommand("Manage &Document Number", New EventHandler(AddressOf ManageDocNoMenuCommand_Click))
        Dim styleMyDrawingNoSetup As MenuCommand = New MenuCommand("Manage D&rawing Number", New EventHandler(AddressOf ManageDrawNoMenuCommand_Click))
        styleSystemSetup.MenuCommands.AddRange(New MenuCommand() {styleMyCurrencySetup, styleMyDocNoSetup, styleMyDrawingNoSetup})

        styleSystemSetup.Enabled = False
        styleMyCurrencySetup.Enabled = False
        styleMyDocNoSetup.Enabled = False
        styleMyDrawingNoSetup.Enabled = False

        If com.CheckGroupAccess(com, "setup | system") Then
            styleSystemSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | system | currency") Then
            styleMyCurrencySetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | system | manage document number") Then
            styleMyDocNoSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | system | manage drawing number") Then
            styleMyDrawingNoSetup.Enabled = True
        End If

        Dim styleQuoteFormSetup As MenuCommand = New MenuCommand("&Quotation Form", 0)
        Dim styleBoxCategorySetup As MenuCommand = New MenuCommand("My &Box Category", New EventHandler(AddressOf ManageBoxCategoryMenuCommand_Click))
        Dim styleBrandSetup As MenuCommand = New MenuCommand("My B&rand", New EventHandler(AddressOf ManageBrandMenuCommand_Click))
        Dim styleColorSetup As MenuCommand = New MenuCommand("My &Color", New EventHandler(AddressOf ManageColorMenuCommand_Click))
        Dim styleDeliveryTermsSetup As MenuCommand = New MenuCommand("My &Delivery Terms", New EventHandler(AddressOf ManageDeliveryTermsMenuCommand_Click))
        Dim styleEnclosureSetup As MenuCommand = New MenuCommand("My &Enclosure Type", New EventHandler(AddressOf ManageEnclosureMenuCommand_Click))
        Dim styleKeySetup As MenuCommand = New MenuCommand("My &Key", New EventHandler(AddressOf ManageKeyMenuCommand_Click))
        Dim styleMaterialSetup As MenuCommand = New MenuCommand("My &Material", New EventHandler(AddressOf ManageMaterialMenuCommand_Click))
        Dim stylePriceIncludeSetup As MenuCommand = New MenuCommand("My Price &Include Till", New EventHandler(AddressOf ManagePriceIncludeMenuCommand_Click))
        Dim stylePaymentDetailsSetup As MenuCommand = New MenuCommand("My Price De&tails", New EventHandler(AddressOf ManagePaymentDetailsMenuCommand_Click))
        Dim styleProjectSetup As MenuCommand = New MenuCommand("My &Project", New EventHandler(AddressOf ManageProjectMenuCommand_Click))
        Dim styleSpecialSetup As MenuCommand = New MenuCommand("My Special &Format", New EventHandler(AddressOf ManageSpecialMenuCommand_Click))
        Dim styleLVBBoxSetup As MenuCommand = New MenuCommand("My &LVB Box Type", New EventHandler(AddressOf ManageLVBBoxMenuCommand_Click))

        styleQuoteFormSetup.MenuCommands.AddRange(New MenuCommand() {styleBoxCategorySetup, styleBrandSetup, styleColorSetup, styleDeliveryTermsSetup, styleEnclosureSetup, styleMaterialSetup, styleKeySetup, stylePriceIncludeSetup, stylePaymentDetailsSetup, styleProjectSetup, styleSpecialSetup, styleLVBBoxSetup})

        styleQuoteFormSetup.Enabled = False
        styleBoxCategorySetup.Enabled = False
        styleBrandSetup.Enabled = False
        styleColorSetup.Enabled = False
        styleDeliveryTermsSetup.Enabled = False
        styleEnclosureSetup.Enabled = False
        styleKeySetup.Enabled = False
        styleMaterialSetup.Enabled = False
        stylePriceIncludeSetup.Enabled = False
        stylePaymentDetailsSetup.Enabled = False
        styleProjectSetup.Enabled = False
        styleSpecialSetup.Enabled = False
        styleLVBBoxSetup.Enabled = False

        If com.CheckGroupAccess(com, "setup | quotation form") Then
            styleQuoteFormSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | box category") Then
            styleBoxCategorySetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | brand") Then
            styleBrandSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | color") Then
            styleColorSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | delivery terms") Then
            styleDeliveryTermsSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | enclosure type") Then
            styleEnclosureSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | key") Then
            styleKeySetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | material") Then
            styleMaterialSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | price include till") Then
            stylePriceIncludeSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | price details") Then
            stylePaymentDetailsSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | project") Then
            styleProjectSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | special format") Then
            styleSpecialSetup.Enabled = True
        End If
        If com.CheckGroupAccess(com, "setup | quotation form | lv box type") Then
            styleLVBBoxSetup.Enabled = True
        End If

        ' Setup event handlers
        'AddHandler style1.Update, AddressOf OnIDEUpdate

        mc.MenuCommands.AddRange(New MenuCommand() {styleAdminSetup, styleContactsSetup, styleProductsSetup, styleQuoteFormSetup, styleSystemSetup, styleWarehouseSetup})
    End Sub
    Protected Sub CreateAboutMenu(ByVal mc As MenuCommand)

        'created by alan
        Dim styleAbout As MenuCommand = New MenuCommand("About Aises Enterprise Management System...", New EventHandler(AddressOf AboutEMSMenuCommand_Click))

        'styleAbout.MenuCommands.AddRange(New MenuCommand() {styleAbout})

        mc.MenuCommands.AddRange(New MenuCommand() {styleAbout})

    End Sub
    Private Sub PRMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New PRQuotationList
        'controlToAdd = New OutstandingPRForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&PR List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub StorePRMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New PRList("STORE")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Store PR", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub SalesPRMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New PRList("SALES")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Sales PR", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ProjectPRMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New PRList("PROJ")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Project PR", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub FactoryPRMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New PRList("FT")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Factory PR", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub POMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New POList2("PO")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&PO List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub POGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        controlToAdd = New POForm
        page = New Crownwood.Magic.Controls.TabPage("Generate PO", controlToAdd, ImageList1, 0)

        page.Selected = True

        MainTabControl.TabPages.Add(page)

        Me.Cursor = Cursors.Default
    End Sub

    Protected Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub
    Protected Sub OnLogout(ByVal sender As Object, ByVal e As EventArgs)
        CloseAllWindows()

        com.USERID = 0

        _topMenu.Dispose()

        Dim form As New LoginForm
        form.lblerror.Visible = False
        form.ShowDialog(Me)

        If com.USERID = 0 Then
            Application.Exit()
        End If

        'Login Success
        'Retrieve UserProfile and access rights
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            If .Load(form.LoginNameTxt.Text) Then
                .LoadUserGroupFunctions(com.UserProfileDS, .UserGroup)

                Dim UserProfileStructure As New UserProfileStruct
                Dim UserProfileStructureModuleName(com.UserProfileDS.Tables(0).Rows.Count) As String
                Dim UserProfileStructureAccessFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                Dim UserProfileStructureApprovalFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                Dim UserProfileStructureDeleteFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                Dim UserProfileStructureInsertFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                Dim UserProfileStructureUpdateFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                Dim i
                UserProfileStructure.modulename = UserProfileStructureModuleName
                UserProfileStructure.accessflag = UserProfileStructureAccessFlag
                UserProfileStructure.approvalflag = UserProfileStructureApprovalFlag
                UserProfileStructure.deleteflag = UserProfileStructureDeleteFlag
                UserProfileStructure.insertflag = UserProfileStructureInsertFlag
                UserProfileStructure.updateflag = UserProfileStructureUpdateFlag
                com.UserProfile = UserProfileStructure

                For i = 0 To (com.UserProfileDS.Tables(0).Rows.Count - 1)
                    com.UserProfile.modulename(i) = com.UserProfileDS.Tables(0).Rows(i)("Name")
                    com.UserProfile.accessflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Access_Flg")
                    com.UserProfile.approvalflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Approval_Flg")
                    com.UserProfile.deleteflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Delete_Flg")
                    com.UserProfile.insertflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Insert_Flg")
                    com.UserProfile.updateflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Update_Flg")
                Next
            End If
        End With

        SetupMenus()

    End Sub

    Private Sub SalesEnquiryMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Dim QuotationMDIChild As New QuotationForm
        'Set the Parent Form of the Child window.
        'QuotationMDIChild.MdiParent = Me

        'Display the new form.
        'QuotationMDIChild.Show()
        'QuotationMDIChild.StartPosition = FormStartPosition.CenterParent
        'SalesMenuCmd.Checked = True
        'Me.Cursor = Cursors.Default

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New QuotationForm("NEW_ENQUIRY")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New Sales &Enquiry", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BQMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Dim QuotationMDIChild As New QuotationForm
        'Set the Parent Form of the Child window.
        'QuotationMDIChild.MdiParent = Me

        'Display the new form.
        'QuotationMDIChild.Show()
        'QuotationMDIChild.StartPosition = FormStartPosition.CenterParent
        'SalesMenuCmd.Checked = True
        'Me.Cursor = Cursors.Default

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New QuotationForm("NEW_BQ")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New &Bill of Quotation", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub QuotationMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Dim QuotationMDIChild As New QuotationForm
        'Set the Parent Form of the Child window.
        'QuotationMDIChild.MdiParent = Me

        'Display the new form.
        'QuotationMDIChild.Show()
        'QuotationMDIChild.StartPosition = FormStartPosition.CenterParent
        'SalesMenuCmd.Checked = True
        'Me.Cursor = Cursors.Default

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New QuotationForm("NEW")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New &Quotation", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OthQuotationMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing
        Dim OrderType As String
        OrderType = "1"    ' Quotation for Services and Trading

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New QuotationForm("NEW", , OrderType)

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New &Service/Trading Quotation", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CategoryMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageCategoryForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Manage Category", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RejoinQuotationMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim tmpOld_Quotation_ID As Integer

        Dim form As New SelectQuotationForm
        form.ShowDialog(Me)
        tmpOld_Quotation_ID = form.Quotation_ID

        If Not tmpOld_Quotation_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New QuotationForm("REJOIN", tmpOld_Quotation_ID)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("Rejoin Quotation", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MergeQuotationMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New MergeQuotationForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Merge Quotation", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub QuotationListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor

        'controlToAdd = New QuotationListForm
        controlToAdd = New QuotationForm("LIST")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Quotation List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub EnquiryListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor

        'controlToAdd = New QuotationListForm
        controlToAdd = New QuotationForm("LIST_ENQUIRY")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Enquiry List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BQListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor

        'controlToAdd = New QuotationListForm
        controlToAdd = New QuotationForm("LIST_BQ")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&BQ List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OutstandingWOMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OutstandingWOListing

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Outstanding Work Order Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub OutstandingQuotationMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OutstandingQuotationListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Outstanding Quotation List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub OrderConfirmListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OrderConfirmListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Order Confirmation List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OrderConfirmationMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim tmpCustomer_ID As Integer
        '30.10.2003 YG Start
        Dim OrderType As String
        '30.10.2003 YG End

        Dim Form As New SelectCustomerForm
        Form.ShowDialog()
        tmpCustomer_ID = Form.Customer_ID
        OrderType = "0"    'Not Service/Trading Order Confirmation

        If tmpCustomer_ID = 0 Then
        Else
            Me.Cursor = Cursors.WaitCursor
            '30.10.2003 YG Start
            '            controlToAdd = New OrderConfirmationForm("NEW", tmpCustomer_ID)
            controlToAdd = New OrderConfirmationForm("NEW", tmpCustomer_ID, , , OrderType)
            '30.10.2003 YG End

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("&Order Confirmation", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    '30.10.2003 YG Start
    Private Sub OthOrderConfirmationMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim tmpCustomer_ID As Integer
        Dim OrderType As String

        Dim Form As New SelectCustomerForm
        Form.ShowDialog()
        tmpCustomer_ID = Form.Customer_ID
        OrderType = "1"    'Service/Trading Order Confirmation

        If tmpCustomer_ID = 0 Then
        Else
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New OrderConfirmationForm("NEW", tmpCustomer_ID, , , OrderType)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("&Order Confirmation", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    '30.10.2003 YG End
    Private Sub OutstandingOCMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OutstandingOCForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Outstanding Order Confirmation List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub TradingOCMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim controlToAdd As Control = Nothing

    '    Me.Cursor = Cursors.WaitCursor
    '    controlToAdd = New TradingOrderConfirmationForm("NEW")

    '    Dim page As Crownwood.Magic.Controls.TabPage

    ' Create a new page with the appropriate control for display, title text and image
    '    page = New Crownwood.Magic.Controls.TabPage("&Trading Order Confirmation", controlToAdd, ImageList1, 0)

    ' Make this page become selected when added
    '    page.Selected = True

    '    MainTabControl.TabPages.Add(page)
    '    Me.Cursor = Cursors.Default
    'End Sub

    Private Sub WorkOrderListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New WorkOrderListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Work Order List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub WorkOrderApprovalListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New WOApprovalListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Work Order Approval Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub WorkOrderDeliveryMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New WOOnTimeReportForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Work Order On Time Report", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub


    Private Sub WorkOrderMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim tmpCustomer_ID As Integer

        Dim Form As New SelectCustomerForm
        Form.ShowDialog()
        tmpCustomer_ID = Form.Customer_ID

        If tmpCustomer_ID = 0 Then
        Else
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New WorkOrderForm("NEW", tmpCustomer_ID)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("Work Order", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MainTabControl_ClosePressed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (MainTabControl.TabPages.Count > 0) Then
            If Not (MainTabControl.SelectedTab Is Nothing) Then
                MainTabControl.TabPages.Remove(MainTabControl.SelectedTab)    '(MainTabControl.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub NewWorkOrderMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New WorkOrderForm("NEW")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New Work Order", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ManagePartsMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageProductForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Manage Product", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManagePartCodeMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManagePartCode

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Manage PartCode", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageUOMMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New UOMForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Manage UOM", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageEnclosureMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageEnclosureForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Enclosure Type", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ManageKeyMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageKeyForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Key", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageMaterialMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageMaterialForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Material", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ManageBrandMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageBrandForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Brand", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageColorMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageColorForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Color", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ManagePriceIncludeMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManagePriceInclude

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Price Include Till", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageBoxCategoryMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageBoxCategoryForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Box Category", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageProjectMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageProjectForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Project", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageSpecialMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageSpecialFormatForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Special Format", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageLVBBoxMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageLVBBoxForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage LVB Box Type", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub QAInspectionListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New QAInspectionReport

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&QA Inspection Report", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub QAListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New QAListingForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&QA Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DeliveryOrderListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New DOListingForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Outstanding Delivery Order Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub NewDeliveryOrderListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        'controlToAdd = New NewDOListingForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Delivery Order Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub NewDeliveryOrderMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New NewDeliveryOrderForm("NEW")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New Delivery Order", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub NewOGBFilerforSales(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing
        Dim Contract_ID As Integer

        'Dim form As New SelectOGBContractForm
        'form.ShowDialog(Me)
        'Contract_ID = form.Contract_Id
        Contract_ID = 0

        If True Then 'Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New OGBForm(Contract_ID, "ADD")

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("OGB Filer", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub NewOGBContract(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OGBContractForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New OGB Contract", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub NewOGBListing(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OGBListingForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("OGB Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintOGBNotification(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OGBRequestF28Form("")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Print OGB Notification", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

        '        Dim controlToAdd As Control = Nothing
        '
        '        Dim Contract_ID As Integer
        '
        '        Dim form As New SelectOGBContractToPrintForm
        '        form.ShowDialog(Me)
        '        Contract_ID = form.Contract_Id

        '        If Not Contract_ID = 0 Then
        '            Me.Cursor = Cursors.WaitCursor
        '            controlToAdd = New OGBNotificationSubcontForm(Contract_ID)
        '
        '            Dim page As Crownwood.Magic.Controls.TabPage
        '
        '            ' Create a new page with the appropriate control for display, title text and image
        '            page = New Crownwood.Magic.Controls.TabPage("Notification to Subcontractor", controlToAdd, ImageList1, 0)
        '
        '            ' Make this page become selected when added
        '            page.Selected = True
        '
        '            MainTabControl.TabPages.Add(page)
        '            Me.Cursor = Cursors.Default
        '        End If
    End Sub

    Private Sub PrintOGBForm28(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OGBRequestF28Form("F28")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("OGB Request For LV Form", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintOGBDWC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer
        Dim Section_ID As Integer

        Dim form As New SelectOGBContractToPrintForm
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id
        Section_ID = form.Section_Id

        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New OGBDeclarationWorkCompletionForm(Contract_ID)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("Declaration of Work Completion", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PrintOGBReportsNotSurveyed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer
        Dim Section_ID As Integer

        Dim form As New SelectOGBContractToPrintForm
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id
        Section_ID = form.Section_Id

        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New OGBReportsNotSurveyedForm(Contract_ID)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("OGB Installed But Not Surveyed", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PrintOGBReportsPendingTOC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer
        Dim Section_ID As Integer
        Dim StatusTxt As String
        Dim Filename As String
        Dim Filters As String


        Dim form As New SelectOGBTOCpendingform
        form.Advance_Panel.Visible = True
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id
        Section_ID = form.Section_Id
        StatusTxt = form.StatusTxt
        Filename = form.Filename
        Filters = form.Filters

        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor

            If StatusTxt = "SendExcelMail" Then
                Dim ds As DataSet

                With New BusinessRules.OGBBusRules.OGBBusLogic
                    If .GetPendingTOCReport(ds, Contract_ID, form.Sortby_ComboBox.SelectedIndex, Filters) Then

                    End If
                End With

            Else


                'controlToAdd = New OGBReportsPendingTOCForm(Contract_ID, form.Sortby_ComboBox.SelectedIndex())

                Dim page As Crownwood.Magic.Controls.TabPage

                ' Create a new page with the appropriate control for display, title text and image
                'page = New Crownwood.Magic.Controls.TabPage("OGB Pending TOC", controlToAdd, ImageList1, 0)
                ' Make this page become selected when added
                'page.Selected = True

                controlToAdd = New OGBReportsPendingTOCRptForm(Contract_ID, form.SeparateByOfficers_CheckBox.Checked, form.Sortby_ComboBox.SelectedIndex, Filters)
                page = New Crownwood.Magic.Controls.TabPage("Print Pending TOC With Officer", controlToAdd, ImageList1, 0)

                page.Selected = True

                MainTabControl.TabPages.Add(page)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PrintOGBReportsInvocing(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer
        Dim Section_ID As Integer
        Dim StatusTxt As String
        Dim Filename As String
        Dim Filters As String

        Dim form As New SelectOGBContractToPrintForm
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id
        Section_ID = form.Section_Id
        StatusTxt = form.StatusTxt
        Filename = form.Filename
        Filters = form.Filters

        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor

            If StatusTxt = "SendExcelMail" Then
                Dim ds As DataSet

                With New BusinessRules.OGBBusRules.OGBBusLogic
                    If .GetOGBInvoiceStatusReport(ds, Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, form.ShowTOC_Null_CheckBox.Checked, Filters) Then
                        With New ExcelTools

                            ds.Tables(0).Columns("OGB_Contract_No").Caption = "Contract No"
                            ds.Tables(0).Columns("Officer_Name").Caption = "Officer-in-charge"
                            ds.Tables(0).Columns("Section_Code").Caption = "Section"
                            ds.Tables(0).Columns("IO_No").Caption = "I/O No."
                            ds.Tables(0).Columns("OGB_Location").Caption = "Location"
                            ds.Tables(0).Columns("Serial_no").Caption = "Serial no."
                            ds.Tables(0).Columns("installation_date").Caption = "Install Date"
                            ds.Tables(0).Columns("DWC_Sent_date").Caption = "DWC Date"
                            ds.Tables(0).Columns("TOC_Return_date").Caption = "TOC Recv"
                            ds.Tables(0).Columns("Invoice_no").Caption = "Invoice no."
                            ds.Tables(0).Columns("Invoice_date").Caption = "Invoice Date"

                            ds.Tables(0).Columns.Remove("OGB_Substation")
                            ds.Tables(0).Columns.Remove("Redo_Text")

                            If .Export(ds, Filename) = True Then
                                Dim result As DialogResult = MessageBox.Show("Successfully exported to " & Filename & ". " & vbNewLine & _
                                                                             "Do you want to open the file?", "Exported to excel file successful", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                If result = DialogResult.Yes Then
                                    Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
                                    excel.Workbooks.Open(Filename)
                                    excel.Visible = True
                                End If
                            End If
                        End With
                    End If
                End With

            Else


                controlToAdd = New OGBReportsInvoiceStatusForm(Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, form.ShowTOC_Null_CheckBox.Checked, Filters, StatusTxt)

                Dim page As Crownwood.Magic.Controls.TabPage

                ' Create a new page with the appropriate control for display, title text and image
                page = New Crownwood.Magic.Controls.TabPage("OGB Install & Feedback Record", controlToAdd, ImageList1, 0)

                ' Make this page become selected when added
                page.Selected = True

                MainTabControl.TabPages.Add(page)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PrintOGBFeedback(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer
        Dim Section_ID As Integer
        Dim StatusTxt As String
        Dim Filename As String
        Dim Filters As String
        Dim StartDate As String
        Dim EndDate As String

        Dim form As New SelectFeedBackToPrintForm("OGB")
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id
        Section_ID = form.Section_Id
        StatusTxt = form.StatusTxt
        Filename = form.Filename
        Filters = form.Filters
        StartDate = form.StartDate
        EndDate = form.EndDate

        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor

            If StatusTxt = "SendExcelMail" Then
                Dim ds As DataSet

                With New BusinessRules.OGBBusRules.OGBBusLogic
                    If .GetOGBInvoiceStatusReport(ds, Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, form.ShowTOC_Null_CheckBox.Checked, Filters) Then
                        With New ExcelTools

                            ds.Tables(0).Columns("OGB_Contract_No").Caption = "Contract No"
                            ds.Tables(0).Columns("Officer_Name").Caption = "Officer-in-charge"
                            ds.Tables(0).Columns("Section_Code").Caption = "Section"
                            ds.Tables(0).Columns("IO_No").Caption = "I/O No."
                            ds.Tables(0).Columns("OGB_Location").Caption = "Location"
                            ds.Tables(0).Columns("Serial_no").Caption = "Serial no."
                            ds.Tables(0).Columns("installation_date").Caption = "Install Date"
                            ds.Tables(0).Columns("DWC_Sent_date").Caption = "DWC Date"
                            ds.Tables(0).Columns("TOC_Return_date").Caption = "TOC Recv"
                            ds.Tables(0).Columns("Invoice_no").Caption = "Invoice no."
                            ds.Tables(0).Columns("Invoice_date").Caption = "Invoice Date"

                            ds.Tables(0).Columns.Remove("OGB_Substation")
                            ds.Tables(0).Columns.Remove("Redo_Text")

                            If .Export(ds, Filename) = True Then
                                Dim result As DialogResult = MessageBox.Show("Successfully exported to " & Filename & ". " & vbNewLine & _
                                                                             "Do you want to open the file?", "Exported to excel file successful", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                If result = DialogResult.Yes Then
                                    Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
                                    excel.Workbooks.Open(Filename)
                                    excel.Visible = True
                                End If
                            End If
                        End With
                    End If
                End With

            Else


                controlToAdd = New OGBInstallFeedbackForm(Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, StartDate, EndDate, form.ShowTOC_Null_CheckBox.Checked, Filters, StatusTxt)

                Dim page As Crownwood.Magic.Controls.TabPage

                ' Create a new page with the appropriate control for display, title text and image
                page = New Crownwood.Magic.Controls.TabPage("OGB Installation and Feedback Record", controlToAdd, ImageList1, 0)

                ' Make this page become selected when added
                page.Selected = True

                MainTabControl.TabPages.Add(page)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub NewLVBContract(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New LVBContractForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("New LVB Contract", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub NewLVBFilerforSales(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer

        'Dim form As New SelectContractForm
        'form.ShowDialog(Me)
        'Contract_ID = form.Contract_Id

        Contract_ID = 0

        If True Then 'Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New LVBFilerForm(Contract_ID, "ADD")

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("LVB Filer", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub LVBListing(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New LVBListingForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("LVB Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintNotification(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OGBRequestF28Form("NOTICE", "LVB")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Print LVB Notification", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
        '        Dim controlToAdd As Control = Nothing
        '
        '        Dim Contract_ID As Integer
        '
        '        Dim form As New SelectLVBContractToPrintForm
        '        form.ShowDialog(Me)
        '        Contract_ID = form.Contract_Id
        '
        '        If Not Contract_ID = 0 Then
        '            Me.Cursor = Cursors.WaitCursor
        '            controlToAdd = New LVBNotificationSubcontForm(Contract_ID)
        '
        '            Dim page As Crownwood.Magic.Controls.TabPage
        '
        '            ' Create a new page with the appropriate control for display, title text and image
        '            page = New Crownwood.Magic.Controls.TabPage("Notification to Subcontractor", controlToAdd, ImageList1, 0)
        '
        '            ' Make this page become selected when added
        '            page.Selected = True
        '
        '            MainTabControl.TabPages.Add(page)
        '            Me.Cursor = Cursors.Default
        '        End If
    End Sub

    Private Sub PrintLVBForm28(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OGBRequestF28Form("F28", "LVB")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("LVB Request For LV Form", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintLVBDWC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer

        Dim form As New SelectLVBContractToPrintForm
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id

        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New LVBDeclarationWorkCompletionForm(Contract_ID)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("Declaration of Work Completion", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub PrintLVBReportsInvocing(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer
        Dim Section_ID As Integer
        Dim StatusTxt As String
        Dim Filename As String
        Dim Filters As String


        Dim form As New SelectLVBContractToPrintForm
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id
        Section_ID = form.Section_Id
        StatusTxt = form.StatusTxt
        Filename = form.Filename
        Filters = form.Filters


        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor

            If StatusTxt = "SendExcelMail" Then
                Dim ds As DataSet

                With New BusinessRules.LVBBusRules.LVBBusLogic
                    If .GetLVBInvoiceStatusReport(ds, Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, form.ShowTOC_Null_CheckBox.Checked, Filters) Then
                        With New ExcelTools

                            ds.Tables(0).Columns("Contract_No").Caption = "Contract No"
                            ds.Tables(0).Columns("Officer_Name").Caption = "Officer-in-charge"
                            ds.Tables(0).Columns("Section_Code").Caption = "Section"
                            ds.Tables(0).Columns("IO_No").Caption = "I/O No."
                            ds.Tables(0).Columns("LVB_Location").Caption = "Location"
                            ds.Tables(0).Columns("Serial_no").Caption = "Serial no."
                            ds.Tables(0).Columns("installation_date").Caption = "Install Date"
                            ds.Tables(0).Columns("DWC_Sent_date").Caption = "DWC Date"
                            ds.Tables(0).Columns("TOC_Return_date").Caption = "TOC Recv"
                            ds.Tables(0).Columns("Invoice_no").Caption = "Invoice no."
                            ds.Tables(0).Columns("Invoice_date").Caption = "Invoice Date"

                            ds.Tables(0).Columns.Remove("LVB_Substation")

                            If .Export(ds, Filename) = True Then
                                Dim result As DialogResult = MessageBox.Show("Successfully exported to " & Filename & ". " & vbNewLine & _
                                                                             "Do you want to open the file?", "Exported to excel file successful", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                If result = DialogResult.Yes Then
                                    Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
                                    excel.Workbooks.Open(Filename)
                                    excel.Visible = True
                                End If
                            End If
                        End With
                    End If
                End With

            Else

                controlToAdd = New LVBReportsInvoiceStatusForm(Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, form.ShowTOC_Null_CheckBox.Checked, Filters, StatusTxt)

                Dim page As Crownwood.Magic.Controls.TabPage

                ' Create a new page with the appropriate control for display, title text and image
                page = New Crownwood.Magic.Controls.TabPage("LV Box IOs Invoiced/Not Invoiced", controlToAdd, ImageList1, 0)

                ' Make this page become selected when added
                page.Selected = True

                MainTabControl.TabPages.Add(page)

            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub PrintLVBFeedback(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer
        Dim Section_ID As Integer
        Dim StatusTxt As String
        Dim Filename As String
        Dim Filters As String
        Dim StartDate As String
        Dim EndDate As String


        Dim form As New SelectFeedBackToPrintForm("LVB")
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id
        Section_ID = form.Section_Id
        StatusTxt = form.StatusTxt
        Filename = form.Filename
        Filters = form.Filters
        StartDate = form.StartDate
        EndDate = form.EndDate


        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor

            If StatusTxt = "SendExcelMail" Then
                Dim ds As DataSet

                With New BusinessRules.LVBBusRules.LVBBusLogic
                    If .GetLVBInstallFeedbackReport(ds, Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, form.ShowTOC_Null_CheckBox.Checked, Filters) Then
                        With New ExcelTools

                            ds.Tables(0).Columns("Contract_No").Caption = "Contract No"
                            ds.Tables(0).Columns("Officer_Name").Caption = "Officer-in-charge"
                            ds.Tables(0).Columns("Section_Code").Caption = "Section"
                            ds.Tables(0).Columns("IO_No").Caption = "I/O No."
                            ds.Tables(0).Columns("LVB_Location").Caption = "Location"
                            ds.Tables(0).Columns("Serial_no").Caption = "Serial no."
                            ds.Tables(0).Columns("installation_date").Caption = "Install Date"
                            ds.Tables(0).Columns("DWC_Sent_date").Caption = "DWC Date"
                            ds.Tables(0).Columns("TOC_Return_date").Caption = "TOC Recv"
                            ds.Tables(0).Columns("Invoice_no").Caption = "Invoice no."
                            ds.Tables(0).Columns("Invoice_date").Caption = "Invoice Date"

                            ds.Tables(0).Columns.Remove("LVB_Substation")

                            If .Export(ds, Filename) = True Then
                                Dim result As DialogResult = MessageBox.Show("Successfully exported to " & Filename & ". " & vbNewLine & _
                                                                             "Do you want to open the file?", "Exported to excel file successful", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                If result = DialogResult.Yes Then
                                    Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
                                    excel.Workbooks.Open(Filename)
                                    excel.Visible = True
                                End If
                            End If
                        End With
                    End If
                End With

            Else

                controlToAdd = New LVBInstallFeedbackForm(Contract_ID, Section_ID, form.Sortby_ComboBox.SelectedIndex, StartDate, EndDate, form.ShowTOC_Null_CheckBox.Checked, Filters, StatusTxt)

                Dim page As Crownwood.Magic.Controls.TabPage

                ' Create a new page with the appropriate control for display, title text and image
                page = New Crownwood.Magic.Controls.TabPage("LVB Installation and Feedback Record", controlToAdd, ImageList1, 0)

                ' Make this page become selected when added
                page.Selected = True

                MainTabControl.TabPages.Add(page)

            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub PrintLVBReportsPendingTOC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim Contract_ID As Integer

        Dim form As New SelectLVBTOCpendingform
        form.ShowDialog(Me)
        Contract_ID = form.Contract_Id

        If Not Contract_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            'controlToAdd = New LVBReportsPendingTOCForm(Contract_ID, form.Sortby_ComboBox.SelectedIndex)

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New LVBReportsPendingTOCRptForm(Contract_ID, form.SeparateByOfficers_CheckBox.Checked, form.Sortby_ComboBox.SelectedIndex)

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("TOC (LVB) Pending with Officers", controlToAdd, ImageList1, 0)
            ' Make this page become selected when added

            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SupplierListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New SupplierListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("My Supplier List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub OfficerListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OfficerListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("My Officer List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CustomerListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New CustomerListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        'Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("My Customer List", controlToAdd, ImageList1, 0)

        'Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ConsultantListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ConsultantListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        'Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("My Consultant List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ManageDocNoMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New DocumentNoForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Documents Number", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CurrencyListMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageCurrency

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Currency", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LogoutMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Me.Cursor = Cursors.WaitCursor
        'Dim com As New Common.CommonConn.Config
        com.USERID = 0

        'reinitialize all menus & tabpages controls
        'If Not MainTabControl Is Nothing Then
        'Dim i
        'If MainTabControl.TabPages.Count > 0 Then
        'MainTabControl.TabPages.Clear()
        'End If
        'End If

        If Not _topMenu Is Nothing Then
            _topMenu.Dispose()
        End If

        Dim controlToAdd As Control = Nothing
        controlToAdd = New Test

        Dim page As Crownwood.Magic.Controls.TabPage
        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&Start Page", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        'Dim form1 As New testForm
        'form1.ShowDialog(Me)


        Dim form As New LoginForm
        form.lblerror.Visible = False
        form.ShowDialog(Me)

        If com.USERID = 0 Then
            Application.Exit()
        Else

            'Login Success
            'Retrieve UserProfile and access rights
            With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
                If .Load(form.LoginNameTxt.Text) Then
                    .LoadUserGroupFunctions(com.UserProfileDS, .UserGroup)

                    Dim UserProfileStructure As New UserProfileStruct
                    Dim UserProfileStructureModuleName(com.UserProfileDS.Tables(0).Rows.Count) As String
                    Dim UserProfileStructureAccessFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                    Dim UserProfileStructureApprovalFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                    Dim UserProfileStructureDeleteFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                    Dim UserProfileStructureInsertFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                    Dim UserProfileStructureUpdateFlag(com.UserProfileDS.Tables(0).Rows.Count) As String
                    Dim i
                    UserProfileStructure.modulename = UserProfileStructureModuleName
                    UserProfileStructure.accessflag = UserProfileStructureAccessFlag
                    UserProfileStructure.approvalflag = UserProfileStructureApprovalFlag
                    UserProfileStructure.deleteflag = UserProfileStructureDeleteFlag
                    UserProfileStructure.insertflag = UserProfileStructureInsertFlag
                    UserProfileStructure.updateflag = UserProfileStructureUpdateFlag
                    com.UserProfile = UserProfileStructure

                    For i = 0 To (com.UserProfileDS.Tables(0).Rows.Count - 1)
                        com.UserProfile.modulename(i) = com.UserProfileDS.Tables(0).Rows(i)("Name")
                        com.UserProfile.accessflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Access_Flg")
                        com.UserProfile.approvalflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Approval_Flg")
                        com.UserProfile.deleteflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Delete_Flg")
                        com.UserProfile.insertflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Insert_Flg")
                        com.UserProfile.updateflag(i) = com.UserProfileDS.Tables(0).Rows(i)("Update_Flg")
                    Next
                End If
            End With


            SetupMenus()


            '
            'MainTabControl
            '
            'Me.MainTabControl 
            'Me.MainTabControl.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
            'Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            'Me.MainTabControl.HotTextColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
            'Me.MainTabControl.HotTrack = True
            'Me.MainTabControl.IDEPixelArea = True
            'Me.MainTabControl.IDEPixelBorder = False
            'Me.MainTabControl.ImageList = Me.ImageList1
            'Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
            'Me.MainTabControl.Name = "MainTabControl"
            'Me.MainTabControl.ShowClose = False
            'Me.MainTabControl.Size = New System.Drawing.Size(688, 509)
            'Me.MainTabControl.TabIndex = 3
            'Me.Controls.Add(Me.MainTabControl)

            '_filler = New Crownwood.Magic.Controls.TabControl
            '_filler.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
            '_filler.Dock = System.Windows.Forms.DockStyle.Fill
            '_filler.HotTextColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
            '_filler.HotTrack = True
            '_filler.IDEPixelArea = True
            '_filler.IDEPixelBorder = False
            '_filler.ImageList = Me.ImageList1
            '_filler.Location = New System.Drawing.Point(0, 0)
            '_filler.Name = "MainTabControl"
            '_filler.ShowClose = False
            '_filler.Size = New System.Drawing.Size(688, 509)
            '_filler.TabIndex = 3

            '_filler.TabPages.Add(New Crownwood.Magic.Controls.TabPage("First"))
            '_filler.TabPages.Add(New Crownwood.Magic.Controls.TabPage("Second"))
            '_filler.TabPages.Add(New Crownwood.Magic.Controls.TabPage("Third"))
            '_filler.Dock = DockStyle.Fill
            '_filler.Style = VisualStyle.IDE

            'Controls.Add(_filler)

            MainTabControl.TabPages.Add(page)
            '_filler.TabPages.Add(page)

        End If

        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub UserProfileMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageUserProfile

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&My User Profile", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub UserGroupMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageUserGroup

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&My User Group", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub MyPasswordMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New PWUpdateForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&My Password", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub WareHouseMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageWH

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("&My Warehouse", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub AboutEMSMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor

        Dim form As New AboutEMS
        form.ShowDialog(Me)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub WorkPlanListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New WorkPlanListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Work Plan Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    'Private Sub WorkPlanMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim controlToAdd As Control = Nothing

    'Me.Cursor = Cursors.WaitCursor
    'controlToAdd = New WorkPlanForm

    'Dim page As Crownwood.Magic.Controls.TabPage

    ' Create a new page with the appropriate control for display, title text and image
    'page = New Crownwood.Magic.Controls.TabPage("Work Plan", controlToAdd, ImageList1, 0)

    ' Make this page become selected when added
    'page.Selected = True

    'MainTabControl.TabPages.Add(page)
    'Me.Cursor = Cursors.Default

    'End Sub

    Private Sub ManageDrawNoMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New DrawingNoListForm
        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Drawing Number Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub DeliveryNoteListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New DeliveryNoteListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' 'Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Delivery Note Listing", controlToAdd, ImageList1, 0)

        '' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBarTimePanel.Text = System.DateTime.Now().ToLongDateString + "  " + System.DateTime.Now().ToLongTimeString()
    End Sub
#Region " Inventory Stock In Functions For Menu Selection"
    Private Sub StockInPOMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim tmpPO_ID As Integer
        Dim tmpPO_No As String

        Dim form As New SelectPOForm
        form.ShowDialog(Me)
        tmpPO_ID = form.PO_ID
        tmpPO_No = form.PO_No

        If Not tmpPO_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New StockInPOForm(tmpPO_No, tmpPO_ID)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("Stock In (Based on PO)", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub StockInLooseMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        'Dim tmpPO_ID As Integer
        'Dim tmpPO_No As String

        'tmpPO_ID = 0
        'tmpPO_No = ""

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockInLooseForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock In (for Loose Items)", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StockOutWOMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Dim tmpWO_ID As Integer
        Dim tmpWO_No As String
        Dim tmpConfirm_Quotation_No As String

        Dim form As New SelectWOForm
        form.ShowDialog(Me)
        tmpWO_ID = form.WO_ID
        tmpWO_No = form.WO_No
        tmpConfirm_Quotation_No = form.Confirm_Quotation_No

        If Not tmpWO_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New StockOutWOForm(tmpWO_No, tmpWO_ID, tmpConfirm_Quotation_No)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("Stock Out (Based on WO)", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub StockOutLooseMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutLooseForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock Out (Loose Items)", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StockOutSRVMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("SRV Stock Out", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LowStockAlertMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New LowStockAlertForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Low Stock Alert", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OverStockAlertMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OverStockAlertForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Over Stock Alert", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InventoryListingMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New InventoryListingForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Inventory Report", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StockTransactionReportMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        'Me.Cursor = Cursors.WaitCursor
        Dim f As StockBalReportForm
        f = New StockBalReportForm("TRANSACTIONBYDATE")
        f.ShowDialog()

    End Sub

    Private Sub StockBalDetReportMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        'Me.Cursor = Cursors.WaitCursor
        Dim f As StockBalReportForm
        f = New StockBalReportForm
        f.ShowDialog()

    End Sub

    Private Sub StockTakeFormMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        'Me.Cursor = Cursors.WaitCursor

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockTakeForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock Take Form", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub StockRelocateMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        'Dim tmpPO_ID As Integer
        'Dim tmpPO_No As String

        'tmpPO_ID = 0
        'tmpPO_No = ""

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockRelocateForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock Relocation", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub StockAdjustmentMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        'Dim tmpPO_ID As Integer
        'Dim tmpPO_No As String

        'tmpPO_ID = 0
        'tmpPO_No = ""

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockAdjustmentForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock Adjustment", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    'Added by Danial
    Private Sub StockInDOMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("DO")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock In - DO", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub


    'Added by Danial
    Private Sub StockViewerMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockViewerForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock Viewer", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub WithdrawSRVMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("SRV")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Withdraw - SRV", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub WithdrawPMRMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("PMR")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Withdraw - PMR", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub ReturnInMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("RTN")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Return-In - RTN", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub StockTransferMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("ST")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock Transfer - ST", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub StockAdjustMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("SA")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Stock Adjustment - SA", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub
    'Added by Danial
    Private Sub FGWMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("FGW")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Finished Goods Withdraw - FGW", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub

    'Added by Danial
    Private Sub FGWDOMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("FGWDO")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Finished Goods Withdraw - DO", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub

    'Added by Danial
    Private Sub FGWNOIMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("FGWNOI")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Finished Goods Withdraw - NOI", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub

    'Added by Danial
    Private Sub QARMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("QAR")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Finished Goods Received - QAR", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub

    'Added by Danial
    Private Sub INTMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New StockOutSRVForm("INT")

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Finished Goods Internal - INT", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default


    End Sub

#End Region

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        CheckForUpdate()
        Me.Text = Me.Text + " Version " + EMSVersion + " - " + Directory.GetCurrentDirectory()

        'Login First
        LogoutMenuCommand_Click(sender, e)

        'SetupMenus()
        'Dim controlToAdd As Control = Nothing
        'controlToAdd = New Test

        'Dim page As Crownwood.Magic.Controls.TabPage
        ' Create a new page with the appropriate control for display, title text and image
        'page = New Crownwood.Magic.Controls.TabPage("&Start Page", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        'page.Selected = True
        'MainTabControl.TabPages.Add(page)

    End Sub

    Public Sub CheckForUpdate()

        'Check for existing update folder
        Dim VersionValue As Integer
        Dim UpdateVersionValue As Integer
        Dim CurrentVersion As String
        Dim UpdateVersion As String
        Dim UpdateFolder As String

        Dim EMSPath As String
        Dim ReportPath As String

        Dim proc As New System.Diagnostics.Process


        EMSPath = Application.StartupPath()
        ReportPath = ""
        Dim i As Integer = EMSPath.IndexOf("\bin")
        If i > -1 Then EMSPath = EMSPath.Substring(0, i)

        Dim Config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        'update EMS Application Path and Report Path
        Config.AppSettings.Settings.Item("AppFolder").Value = EMSPath
        Config.Save(ConfigurationSaveMode.Full)
        ConfigurationManager.RefreshSection("appSettings")

        CurrentVersion = Config.AppSettings.Settings("Version").Value.ToString
        UpdateFolder = Config.AppSettings.Settings("UpdateFolder").Value.ToString

        CurrentVersion = Replace(CurrentVersion, ".", "")
        VersionValue = Integer.Parse(CurrentVersion)

        'Dim flds() As FileInfo
        Dim di As DirectoryInfo
        di = New DirectoryInfo(UpdateFolder)
        'flds = Directory.GetFiles(UpdateFoder).OrderByDescending(Function(x) x.CreationTime)

        Try

        
            Dim flds() As DirectoryInfo = di.GetDirectories.OrderByDescending(Function(x) x.CreationTime).ToArray

            If flds.Length > 0 Then
                UpdateVersion = flds(0).Name
                UpdateVersionValue = Integer.Parse(Replace(UpdateVersion, ".", ""))

                If UpdateVersionValue > VersionValue Then
                    'Proceed to update
                    Dim UpdateMsg = "There are new updates. EMS will now close and updating will ensue."
                    MsgBox(UpdateMsg, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Checking Update")
                    proc = Process.Start(EMSPath + "\EMSupdater.exe", "")
                    Application.Exit()
                End If
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Updates are not found", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        'Dim di As DirectoryInfo
        'Dim flds() As FileSystemInfo
        'di = New DirectoryInfo(UpdateFolder)
        'flds = di.GetFileSystemInfos()
        'flds.OrderBy(


    End Sub

    Private Sub ManagePaymentDetailsMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManagePaymentDetailsForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Payment Details", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ManageDeliveryTermsMenuCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New ManageDeliveryTermsForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Manage Delivery Terms Details", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub PRApproveListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OutstandingPRForm

        Dim page As Crownwood.Magic.Controls.TabPage

        '   ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("PR Approval Listing", controlToAdd, ImageList1, 0)

        '    ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PRPendingListMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OutstandingPRForm(1) '1 - indicate pending list

        Dim page As Crownwood.Magic.Controls.TabPage

        '   ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("PR Pending for PO", controlToAdd, ImageList1, 0)

        '    ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub OutstandingPOMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OutstandingPOReportList

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Outstanding PO Report", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub OnTimeDeliveryMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New SupplierOnTimeReportForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Supplier On Time Report", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub SOListing(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New SurveyOrderListForm

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Survey Order Listing", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OutstandingItemMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New OutstandingItemList

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Outstanding Item List", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub WorkOrderPOReportMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim controlToAdd As Control = Nothing

        Me.Cursor = Cursors.WaitCursor
        controlToAdd = New WorkOrderPOList

        Dim page As Crownwood.Magic.Controls.TabPage

        ' Create a new page with the appropriate control for display, title text and image
        page = New Crownwood.Magic.Controls.TabPage("Work Order PO Report", controlToAdd, ImageList1, 0)

        ' Make this page become selected when added
        page.Selected = True

        MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub
    'Private Sub SupplierListReportMenuCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   Dim controlToAdd As Control = Nothing

    '  Me.Cursor = Cursors.WaitCursor
    ' controlToAdd = New SupplierListReportForm

    'Dim page As Crownwood.Magic.Controls.TabPage

    'page = New Crownwood.Magic.Controls.TabPage("Supplier List Report", controlToAdd, ImageList1, 0)

    'page.Selected = True

    'MainTabControl.TabPages.Add(page)
    'Me.Cursor = Cursors.Default

    'End Sub

    Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim i
        i = Me.MdiChildren()
        Dim f As Form
        Dim TotalForm, x
        TotalForm = Me.MainTabControl.TabPages.Count
        While TotalForm
            f = Me.MainTabControl.TabPages.Item(TotalForm - 1).Control
            f.Close()
            If f.Visible = True Then
                e.Cancel = True
                Exit While
            End If

            If Me.MainTabControl.TabPages.Count = TotalForm Then
                Me.MainTabControl.TabPages.RemoveAt(TotalForm - 1)
            End If

            TotalForm = Me.MainTabControl.TabPages.Count
        End While

    End Sub

    Private Sub MainForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

    Public Function CloseAllWindows() As Boolean
        Dim boolCancel
        Dim i
        boolCancel = False
        i = Me.MdiChildren()
        Dim f As Form
        Dim TotalForm, x
        TotalForm = Me.MainTabControl.TabPages.Count
        While TotalForm
            If TotalForm = 1 Then
                Exit While
            End If
            f = Me.MainTabControl.TabPages.Item(TotalForm - 1).Control
            f.Close()
            If f.Visible = True Then
                boolCancel = True
                Exit While
            End If

            If Me.MainTabControl.TabPages.Count = TotalForm Then
                Me.MainTabControl.TabPages.RemoveAt(TotalForm - 1)
            End If

            TotalForm = Me.MainTabControl.TabPages.Count
        End While

        CloseAllWindows = boolCancel

    End Function



End Class
