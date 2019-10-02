Imports System.Data
Imports Crownwood.Magic.Common
Imports Crownwood.Magic.Controls
Imports DevExpress.XtraEditors.Controls

Public Class TradingOrderConfirmationForm
    Inherits System.Windows.Forms.Form

    'Trading OC - Buying n selling.

#Region " QuotationHeader's variable"
    '** QuotationHeader **
    Public Quotation_ID As Integer
    Public Confirm_Quotation_No As String
    Public QuotationNo As String
    Public QuotationDate As String
    Public Customer_ID As Integer
    Public Contact_ID As Integer
    Public Status As String
    Public Project As String
    Public ProjectSub As String
    Public Payment_Term As String
    Public Validity As Integer
    Public Delivery_Term As String
    Public Service_Type As Integer
    Public CP5_Flg As String
    Public Sign_By As String
    Public Total_Cost_Text As String
    Public Total_Cost_Numeric As Integer
    Public PanelType As String
    Public OC_EF As Integer
    Public Incoming As Integer
    Public Panel_Transport As Integer
    Public Installation As Integer
    Public Remarks As String
    Public ClosingNotes As String
    Public RefQuotationID As Integer
    Public RevRefQuotationID As Integer
    Public OtherNotes As String
    Public PriceInclude_ID As Integer
    Public VORefQuotationID As Integer

    Public Customer_PO As String
    Public PO_Date As String
    Public Percent_Discount As Double
    Public Cash_Discount As Double
    Public CollectMode As String
    '****
#End Region

#Region " QuotationLine's variable"
    '** QuotationLine **
    Public Quotation_Line_ID As Integer
    Public ItemNo As Integer
    Public Box As String
    Public varHeight As Integer        'Height is a keyword
    Public varWidth As Integer
    Public Depth As Integer
    Public Raw_Material As String
    Public Material_Cost As Decimal
    Public Type As String
    Public Thickness As Integer
    Public Power_Coat As Decimal
    Public Wiring As Decimal
    Public Accessory As Decimal
    Public Copper As Decimal
    Public Comp_Markup As Integer
    Public Concrete_Base As Decimal
    Public Box_Markup As Integer
    Public Transport As Decimal
    Public Enclosure As Decimal
    Public Qty As Integer
    Public Cost As Decimal             'Total Panel Cost
    Public Overall_Markup As Decimal
    Public Total_Amount As Decimal
    Public Type_Of_Enclosure As Integer
    Public BoxCategory_ID As Integer

    Public LinePercent_Discount As Double
    Public DiscPrice As Decimal
    '****
#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    Public NavdsBox As DataSet              'FOR NAV
    Dim CurrentRow As Integer               'FOR NAVIGATION
    Public CompTotal As Double
    Public GrandTotal As Double
    Public FormStatus As String             'TO DIFFERENTIATE BETWEEN ADD,EDIT..
    Public Old_Quotation_ID As Integer
    Public EditFlag As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pCustomer_ID As Integer = 0, _
                Optional ByVal pOld_Quotation_ID As Integer = 0, Optional ByVal pQuotation_ID As Integer = 0)

        MyBase.New()
        FormStatus = pStatus
        If Not pCustomer_ID = 0 Then
            Customer_ID = pCustomer_ID
        End If

        If Not pOld_Quotation_ID = 0 Then
            Old_Quotation_ID = pOld_Quotation_ID
        End If

        If Not pQuotation_ID = 0 Then
            Quotation_ID = pQuotation_ID
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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents SaveQuoBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DispatchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Edit As System.Windows.Forms.MenuItem
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents TabControl3 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents TabPage1 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UpdateAllBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CompGrid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents UpdateBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CompCostTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblNavLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NavLastBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NavFirstBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NavNextBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NavPrevBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AddBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DelProdBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ItemTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents DiscPriceTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PercentOffLineTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents CompMarkTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CopyFmBxCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TotalAmtTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BoxDescTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OverallMarkTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TotAmtLbl As System.Windows.Forms.Label
    Friend WithEvents QtyLbl As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanelCostTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EnclosureTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TypeEnclosureCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Typetxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ThicknessTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MaterialCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EnclosureTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MatCostTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PowerCoatTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DepthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WidthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HeightTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents CostLbl As System.Windows.Forms.Label
    Friend WithEvents DepthLbl As System.Windows.Forms.Label
    Friend WithEvents WidthLbl As System.Windows.Forms.Label
    Friend WithEvents OthersTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents InstallTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PanelTransportTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IncomingTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OCEFTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents OCEFlbl As System.Windows.Forms.Label
    Friend WithEvents CopperTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TransportTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AccessoryTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ConcreteBaseTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WiringTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalCostTexttxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RdBtn4 As System.Windows.Forms.RadioButton
    Friend WithEvents CashOfftxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Rdbtn3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Rdbtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdBtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents CP5Chk As System.Windows.Forms.CheckBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents CP5Lbl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CustPOTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PercentOffTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WONoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Addresstxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OCNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProjectCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents StatusCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ContLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProjectLbl As System.Windows.Forms.Label
    Friend WithEvents AddressLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusLbl As System.Windows.Forms.Label
    Friend WithEvents DateLbl As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CollectModeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents ClosingTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SignByCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ServiceTypeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PriceTillCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ValidityTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OtherNotesMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NotesMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DelTermsMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PayDetailsMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TabControl1 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents GrandTotalTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents ProjectTitleCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BoxCategoryCmb As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.SaveQuoBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DispatchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Edit = New System.Windows.Forms.MenuItem
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.TabControl3 = New Crownwood.Magic.Controls.TabControl
        Me.TabPage1 = New Crownwood.Magic.Controls.TabPage
        Me.GrandTotalTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label40 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UpdateAllBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CompGrid1 = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.UpdateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CompCostTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblNavLocation = New DevExpress.XtraEditors.TextEdit
        Me.NavLastBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavFirstBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavNextBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavPrevBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DelProdBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.TabControl1 = New Crownwood.Magic.Controls.TabControl
        Me.ItemTab = New Crownwood.Magic.Controls.TabPage
        Me.BoxCategoryCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label45 = New System.Windows.Forms.Label
        Me.DiscPriceTxt = New DevExpress.XtraEditors.SpinEdit
        Me.PercentOffLineTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.CompMarkTxt = New DevExpress.XtraEditors.SpinEdit
        Me.CopyFmBxCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TotalAmtTxt = New DevExpress.XtraEditors.TextEdit
        Me.BoxDescTxt = New DevExpress.XtraEditors.TextEdit
        Me.ItemNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.OverallMarkTxt = New DevExpress.XtraEditors.SpinEdit
        Me.TotAmtLbl = New System.Windows.Forms.Label
        Me.QtyLbl = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelCostTxt = New DevExpress.XtraEditors.SpinEdit
        Me.EnclosureTab = New Crownwood.Magic.Controls.TabPage
        Me.TypeEnclosureCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Typetxt = New DevExpress.XtraEditors.TextEdit
        Me.ThicknessTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.MaterialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.EnclosureTxt = New DevExpress.XtraEditors.SpinEdit
        Me.MatCostTxt = New DevExpress.XtraEditors.SpinEdit
        Me.PowerCoatTxt = New DevExpress.XtraEditors.SpinEdit
        Me.DepthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WidthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.HeightTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.CostLbl = New System.Windows.Forms.Label
        Me.DepthLbl = New System.Windows.Forms.Label
        Me.WidthLbl = New System.Windows.Forms.Label
        Me.OthersTab = New Crownwood.Magic.Controls.TabPage
        Me.InstallTxt = New DevExpress.XtraEditors.SpinEdit
        Me.PanelTransportTxt = New DevExpress.XtraEditors.SpinEdit
        Me.IncomingTxt = New DevExpress.XtraEditors.SpinEdit
        Me.OCEFTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.OCEFlbl = New System.Windows.Forms.Label
        Me.CopperTxt = New DevExpress.XtraEditors.SpinEdit
        Me.TransportTxt = New DevExpress.XtraEditors.SpinEdit
        Me.AccessoryTxt = New DevExpress.XtraEditors.SpinEdit
        Me.ConcreteBaseTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WiringTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProjectTitleCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.TotalCostTexttxt = New DevExpress.XtraEditors.TextEdit
        Me.RdBtn4 = New System.Windows.Forms.RadioButton
        Me.CashOfftxt = New DevExpress.XtraEditors.SpinEdit
        Me.Rdbtn3 = New System.Windows.Forms.RadioButton
        Me.Label43 = New System.Windows.Forms.Label
        Me.Rdbtn2 = New System.Windows.Forms.RadioButton
        Me.RdBtn1 = New System.Windows.Forms.RadioButton
        Me.CP5Chk = New System.Windows.Forms.CheckBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.CP5Lbl = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PODate = New DevExpress.XtraEditors.DateEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.CustPOTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.PercentOffTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.WONoTxt = New DevExpress.XtraEditors.TextEdit
        Me.QuoNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Addresstxt = New DevExpress.XtraEditors.TextEdit
        Me.QuoDate = New DevExpress.XtraEditors.DateEdit
        Me.OCNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.ProjectCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.StatusCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ContLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.CustLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.ProjectLbl = New System.Windows.Forms.Label
        Me.AddressLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.StatusLbl = New System.Windows.Forms.Label
        Me.DateLbl = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.Lbl = New System.Windows.Forms.Label
        Me.TabPage2 = New Crownwood.Magic.Controls.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CollectModeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.ClosingTxt = New DevExpress.XtraEditors.TextEdit
        Me.SignByCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ServiceTypeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.PriceTillCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ValidityTxt = New DevExpress.XtraEditors.TextEdit
        Me.OtherNotesMemo = New DevExpress.XtraEditors.MemoEdit
        Me.NotesMemo = New DevExpress.XtraEditors.MemoEdit
        Me.DelTermsMemo = New DevExpress.XtraEditors.MemoEdit
        Me.PayDetailsMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.TabControl3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GrandTotalTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompCostTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNavLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ItemTab.SuspendLayout()
        CType(Me.BoxCategoryCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscPriceTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentOffLineTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompMarkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopyFmBxCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OverallMarkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCostTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnclosureTab.SuspendLayout()
        CType(Me.TypeEnclosureCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typetxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThicknessTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnclosureTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatCostTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerCoatTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OthersTab.SuspendLayout()
        CType(Me.InstallTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTransportTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomingTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCEFTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopperTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoryTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConcreteBaseTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WiringTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostTexttxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashOfftxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustPOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentOffTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WONoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CollectModeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosingTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignByCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceTypeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceTillCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherNotesMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelTermsMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayDetailsMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveQuoBtn
        '
        Me.SaveQuoBtn.AutoSize = False
        Me.SaveQuoBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveQuoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveQuoBtn.Image = Nothing
        Me.SaveQuoBtn.Location = New System.Drawing.Point(8, 528)
        Me.SaveQuoBtn.Name = "SaveQuoBtn"
        Me.SaveQuoBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveQuoBtn.TabIndex = 16
        Me.SaveQuoBtn.Text = "Save"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(168, 528)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 17
        Me.CloseBtn.Text = "&Close"
        '
        'DispatchBtn
        '
        Me.DispatchBtn.AutoSize = False
        Me.DispatchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DispatchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DispatchBtn.Image = Nothing
        Me.DispatchBtn.Location = New System.Drawing.Point(88, 528)
        Me.DispatchBtn.Name = "DispatchBtn"
        Me.DispatchBtn.Size = New System.Drawing.Size(64, 32)
        Me.DispatchBtn.TabIndex = 18
        Me.DispatchBtn.Text = "Dispatch"
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Edit, Me.Delete})
        '
        'Edit
        '
        Me.Edit.Index = 0
        Me.Edit.Text = "Edit"
        '
        'Delete
        '
        Me.Delete.Index = 1
        Me.Delete.Text = "Delete"
        '
        'TabControl3
        '
        Me.TabControl3.IDEPixelArea = True
        Me.TabControl3.Location = New System.Drawing.Point(8, 6)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.SelectedTab = Me.TabPage1
        Me.TabControl3.Size = New System.Drawing.Size(696, 512)
        Me.TabControl3.TabIndex = 19
        Me.TabControl3.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.TabPage1, Me.TabPage2})
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GrandTotalTxt)
        Me.TabPage1.Controls.Add(Me.Label40)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(696, 487)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Title = "OC Details"
        '
        'GrandTotalTxt
        '
        Me.GrandTotalTxt.Enabled = False
        Me.GrandTotalTxt.Location = New System.Drawing.Point(568, 464)
        Me.GrandTotalTxt.Name = "GrandTotalTxt"
        Me.GrandTotalTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GrandTotalTxt.Properties.Enabled = False
        Me.GrandTotalTxt.Properties.ReadOnly = True
        Me.GrandTotalTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrandTotalTxt.Size = New System.Drawing.Size(88, 19)
        Me.GrandTotalTxt.TabIndex = 39
        Me.GrandTotalTxt.Text = "0"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(480, 468)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(80, 16)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "Grand Total :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UpdateAllBtn)
        Me.GroupBox2.Controls.Add(Me.CompGrid1)
        Me.GroupBox2.Controls.Add(Me.UpdateBtn)
        Me.GroupBox2.Controls.Add(Me.CompCostTxt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblNavLocation)
        Me.GroupBox2.Controls.Add(Me.NavLastBtn)
        Me.GroupBox2.Controls.Add(Me.NavFirstBtn)
        Me.GroupBox2.Controls.Add(Me.NavNextBtn)
        Me.GroupBox2.Controls.Add(Me.NavPrevBtn)
        Me.GroupBox2.Controls.Add(Me.AddBtn)
        Me.GroupBox2.Controls.Add(Me.DelProdBtn)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 296)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'UpdateAllBtn
        '
        Me.UpdateAllBtn.AutoSize = False
        Me.UpdateAllBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UpdateAllBtn.Enabled = False
        Me.UpdateAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAllBtn.Image = Nothing
        Me.UpdateAllBtn.Location = New System.Drawing.Point(248, 10)
        Me.UpdateAllBtn.Name = "UpdateAllBtn"
        Me.UpdateAllBtn.Size = New System.Drawing.Size(112, 24)
        Me.UpdateAllBtn.TabIndex = 86
        Me.UpdateAllBtn.Text = "Update All Pricing"
        '
        'CompGrid1
        '
        Me.CompGrid1.EditorsRepository = Me.PersistentRepository2
        Me.CompGrid1.Enabled = False
        Me.CompGrid1.Location = New System.Drawing.Point(8, 160)
        Me.CompGrid1.MainView = Me.GridView1
        Me.CompGrid1.Name = "CompGrid1"
        Me.CompGrid1.Size = New System.Drawing.Size(664, 112)
        Me.CompGrid1.TabIndex = 85
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
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
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'UpdateBtn
        '
        Me.UpdateBtn.AutoSize = False
        Me.UpdateBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UpdateBtn.Enabled = False
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Image = Nothing
        Me.UpdateBtn.Location = New System.Drawing.Point(168, 10)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(72, 24)
        Me.UpdateBtn.TabIndex = 84
        Me.UpdateBtn.Text = "Update"
        '
        'CompCostTxt
        '
        Me.CompCostTxt.Enabled = False
        Me.CompCostTxt.Location = New System.Drawing.Point(560, 274)
        Me.CompCostTxt.Name = "CompCostTxt"
        Me.CompCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompCostTxt.Properties.Enabled = False
        Me.CompCostTxt.Properties.ReadOnly = True
        Me.CompCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CompCostTxt.Size = New System.Drawing.Size(104, 19)
        Me.CompCostTxt.TabIndex = 81
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(376, 278)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 16)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Total Comp. Cost after Markup :"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.Location = New System.Drawing.Point(440, 10)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.lblNavLocation.Size = New System.Drawing.Size(70, 19)
        Me.lblNavLocation.TabIndex = 41
        '
        'NavLastBtn
        '
        Me.NavLastBtn.AutoSize = False
        Me.NavLastBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavLastBtn.Image = Nothing
        Me.NavLastBtn.Location = New System.Drawing.Point(536, 10)
        Me.NavLastBtn.Name = "NavLastBtn"
        Me.NavLastBtn.Size = New System.Drawing.Size(32, 24)
        Me.NavLastBtn.TabIndex = 40
        Me.NavLastBtn.Text = " >>"
        '
        'NavFirstBtn
        '
        Me.NavFirstBtn.AutoSize = False
        Me.NavFirstBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavFirstBtn.Image = Nothing
        Me.NavFirstBtn.Location = New System.Drawing.Point(384, 10)
        Me.NavFirstBtn.Name = "NavFirstBtn"
        Me.NavFirstBtn.Size = New System.Drawing.Size(32, 24)
        Me.NavFirstBtn.TabIndex = 39
        Me.NavFirstBtn.Text = " <<"
        '
        'NavNextBtn
        '
        Me.NavNextBtn.AutoSize = False
        Me.NavNextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavNextBtn.Image = Nothing
        Me.NavNextBtn.Location = New System.Drawing.Point(512, 10)
        Me.NavNextBtn.Name = "NavNextBtn"
        Me.NavNextBtn.Size = New System.Drawing.Size(24, 24)
        Me.NavNextBtn.TabIndex = 38
        Me.NavNextBtn.Text = " >"
        '
        'NavPrevBtn
        '
        Me.NavPrevBtn.AutoSize = False
        Me.NavPrevBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavPrevBtn.Image = Nothing
        Me.NavPrevBtn.Location = New System.Drawing.Point(416, 10)
        Me.NavPrevBtn.Name = "NavPrevBtn"
        Me.NavPrevBtn.Size = New System.Drawing.Size(24, 24)
        Me.NavPrevBtn.TabIndex = 37
        Me.NavPrevBtn.Text = " <"
        '
        'AddBtn
        '
        Me.AddBtn.AutoSize = False
        Me.AddBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Image = Nothing
        Me.AddBtn.Location = New System.Drawing.Point(8, 10)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(72, 24)
        Me.AddBtn.TabIndex = 34
        Me.AddBtn.Text = "&Add"
        '
        'DelProdBtn
        '
        Me.DelProdBtn.AutoSize = False
        Me.DelProdBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelProdBtn.Enabled = False
        Me.DelProdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelProdBtn.Image = Nothing
        Me.DelProdBtn.Location = New System.Drawing.Point(88, 10)
        Me.DelProdBtn.Name = "DelProdBtn"
        Me.DelProdBtn.Size = New System.Drawing.Size(72, 24)
        Me.DelProdBtn.TabIndex = 35
        Me.DelProdBtn.Text = "&Delete"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.TabControl1.Enabled = False
        Me.TabControl1.IDEPixelArea = True
        Me.TabControl1.IDEPixelBorder = False
        Me.TabControl1.Location = New System.Drawing.Point(8, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SelectedTab = Me.ItemTab
        Me.TabControl1.ShowArrows = False
        Me.TabControl1.ShowClose = False
        Me.TabControl1.Size = New System.Drawing.Size(664, 112)
        Me.TabControl1.TabIndex = 28
        Me.TabControl1.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.ItemTab, Me.EnclosureTab, Me.OthersTab})
        '
        'ItemTab
        '
        Me.ItemTab.Controls.Add(Me.BoxCategoryCmb)
        Me.ItemTab.Controls.Add(Me.Label45)
        Me.ItemTab.Controls.Add(Me.DiscPriceTxt)
        Me.ItemTab.Controls.Add(Me.PercentOffLineTxt)
        Me.ItemTab.Controls.Add(Me.Label30)
        Me.ItemTab.Controls.Add(Me.CompMarkTxt)
        Me.ItemTab.Controls.Add(Me.CopyFmBxCmb)
        Me.ItemTab.Controls.Add(Me.Label17)
        Me.ItemTab.Controls.Add(Me.Label12)
        Me.ItemTab.Controls.Add(Me.TotalAmtTxt)
        Me.ItemTab.Controls.Add(Me.BoxDescTxt)
        Me.ItemTab.Controls.Add(Me.ItemNoTxt)
        Me.ItemTab.Controls.Add(Me.QtyTxt)
        Me.ItemTab.Controls.Add(Me.OverallMarkTxt)
        Me.ItemTab.Controls.Add(Me.TotAmtLbl)
        Me.ItemTab.Controls.Add(Me.QtyLbl)
        Me.ItemTab.Controls.Add(Me.Label10)
        Me.ItemTab.Controls.Add(Me.Label9)
        Me.ItemTab.Controls.Add(Me.Label11)
        Me.ItemTab.Controls.Add(Me.Label8)
        Me.ItemTab.Controls.Add(Me.PanelCostTxt)
        Me.ItemTab.Location = New System.Drawing.Point(0, 25)
        Me.ItemTab.Name = "ItemTab"
        Me.ItemTab.Size = New System.Drawing.Size(664, 87)
        Me.ItemTab.TabIndex = 3
        Me.ItemTab.Title = "Box"
        '
        'BoxCategoryCmb
        '
        Me.BoxCategoryCmb.Location = New System.Drawing.Point(168, 8)
        Me.BoxCategoryCmb.Name = "BoxCategoryCmb"
        Me.BoxCategoryCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxCategoryCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.BoxCategoryCmb.Properties.NullString = ""
        Me.BoxCategoryCmb.Size = New System.Drawing.Size(120, 19)
        Me.BoxCategoryCmb.TabIndex = 88
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(472, 64)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 16)
        Me.Label45.TabIndex = 87
        Me.Label45.Text = "Disc Price :"
        '
        'DiscPriceTxt
        '
        Me.DiscPriceTxt.Enabled = False
        Me.DiscPriceTxt.Location = New System.Drawing.Point(552, 56)
        Me.DiscPriceTxt.Name = "DiscPriceTxt"
        Me.DiscPriceTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DiscPriceTxt.Properties.Enabled = False
        Me.DiscPriceTxt.Properties.ReadOnly = True
        Me.DiscPriceTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DiscPriceTxt.Size = New System.Drawing.Size(72, 19)
        Me.DiscPriceTxt.TabIndex = 86
        Me.DiscPriceTxt.Text = "0"
        '
        'PercentOffLineTxt
        '
        Me.PercentOffLineTxt.Location = New System.Drawing.Point(416, 56)
        Me.PercentOffLineTxt.Name = "PercentOffLineTxt"
        Me.PercentOffLineTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PercentOffLineTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PercentOffLineTxt.Size = New System.Drawing.Size(40, 19)
        Me.PercentOffLineTxt.TabIndex = 84
        Me.PercentOffLineTxt.Text = "0"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(376, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 16)
        Me.Label30.TabIndex = 83
        Me.Label30.Text = "% off :"
        '
        'CompMarkTxt
        '
        Me.CompMarkTxt.Location = New System.Drawing.Point(296, 56)
        Me.CompMarkTxt.Name = "CompMarkTxt"
        Me.CompMarkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompMarkTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CompMarkTxt.Size = New System.Drawing.Size(56, 19)
        Me.CompMarkTxt.TabIndex = 80
        Me.CompMarkTxt.Text = "0"
        '
        'CopyFmBxCmb
        '
        Me.CopyFmBxCmb.Location = New System.Drawing.Point(88, 56)
        Me.CopyFmBxCmb.Name = "CopyFmBxCmb"
        Me.CopyFmBxCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CopyFmBxCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CopyFmBxCmb.Properties.NullString = ""
        Me.CopyFmBxCmb.Size = New System.Drawing.Size(96, 19)
        Me.CopyFmBxCmb.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Copy from box :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(200, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Comp Markup % :"
        '
        'TotalAmtTxt
        '
        Me.TotalAmtTxt.Enabled = False
        Me.TotalAmtTxt.Location = New System.Drawing.Point(552, 32)
        Me.TotalAmtTxt.Name = "TotalAmtTxt"
        Me.TotalAmtTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TotalAmtTxt.Properties.Enabled = False
        Me.TotalAmtTxt.Properties.ReadOnly = True
        Me.TotalAmtTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TotalAmtTxt.Size = New System.Drawing.Size(72, 19)
        Me.TotalAmtTxt.TabIndex = 56
        '
        'BoxDescTxt
        '
        Me.BoxDescTxt.Location = New System.Drawing.Point(296, 8)
        Me.BoxDescTxt.Name = "BoxDescTxt"
        Me.BoxDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxDescTxt.Size = New System.Drawing.Size(328, 19)
        Me.BoxDescTxt.TabIndex = 55
        '
        'ItemNoTxt
        '
        Me.ItemNoTxt.Location = New System.Drawing.Point(56, 8)
        Me.ItemNoTxt.Name = "ItemNoTxt"
        Me.ItemNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ItemNoTxt.Properties.ReadOnly = True
        Me.ItemNoTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ItemNoTxt.Size = New System.Drawing.Size(32, 19)
        Me.ItemNoTxt.TabIndex = 54
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(416, 32)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(40, 19)
        Me.QtyTxt.TabIndex = 15
        Me.QtyTxt.Text = "0"
        '
        'OverallMarkTxt
        '
        Me.OverallMarkTxt.Location = New System.Drawing.Point(296, 32)
        Me.OverallMarkTxt.Name = "OverallMarkTxt"
        Me.OverallMarkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OverallMarkTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OverallMarkTxt.Size = New System.Drawing.Size(56, 19)
        Me.OverallMarkTxt.TabIndex = 14
        Me.OverallMarkTxt.Text = "0"
        '
        'TotAmtLbl
        '
        Me.TotAmtLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotAmtLbl.Location = New System.Drawing.Point(472, 40)
        Me.TotAmtLbl.Name = "TotAmtLbl"
        Me.TotAmtLbl.Size = New System.Drawing.Size(80, 16)
        Me.TotAmtLbl.TabIndex = 53
        Me.TotAmtLbl.Text = "Total Amount :"
        '
        'QtyLbl
        '
        Me.QtyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.Location = New System.Drawing.Point(376, 40)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(40, 16)
        Me.QtyLbl.TabIndex = 51
        Me.QtyLbl.Text = "* Qty :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(200, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Overall Markup % :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "* Total Panel Cost :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Item No :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "* Box Desc :"
        '
        'PanelCostTxt
        '
        Me.PanelCostTxt.Enabled = False
        Me.PanelCostTxt.Location = New System.Drawing.Point(112, 32)
        Me.PanelCostTxt.Name = "PanelCostTxt"
        Me.PanelCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelCostTxt.Properties.Enabled = False
        Me.PanelCostTxt.Properties.ReadOnly = True
        Me.PanelCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelCostTxt.Size = New System.Drawing.Size(72, 19)
        Me.PanelCostTxt.TabIndex = 13
        Me.PanelCostTxt.Text = "0"
        '
        'EnclosureTab
        '
        Me.EnclosureTab.Controls.Add(Me.TypeEnclosureCmb)
        Me.EnclosureTab.Controls.Add(Me.Label14)
        Me.EnclosureTab.Controls.Add(Me.Typetxt)
        Me.EnclosureTab.Controls.Add(Me.ThicknessTxt)
        Me.EnclosureTab.Controls.Add(Me.Label20)
        Me.EnclosureTab.Controls.Add(Me.Label19)
        Me.EnclosureTab.Controls.Add(Me.Label15)
        Me.EnclosureTab.Controls.Add(Me.MaterialCmb)
        Me.EnclosureTab.Controls.Add(Me.EnclosureTxt)
        Me.EnclosureTab.Controls.Add(Me.MatCostTxt)
        Me.EnclosureTab.Controls.Add(Me.PowerCoatTxt)
        Me.EnclosureTab.Controls.Add(Me.DepthTxt)
        Me.EnclosureTab.Controls.Add(Me.WidthTxt)
        Me.EnclosureTab.Controls.Add(Me.HeightTxt)
        Me.EnclosureTab.Controls.Add(Me.Label18)
        Me.EnclosureTab.Controls.Add(Me.Label16)
        Me.EnclosureTab.Controls.Add(Me.Label22)
        Me.EnclosureTab.Controls.Add(Me.Label44)
        Me.EnclosureTab.Controls.Add(Me.CostLbl)
        Me.EnclosureTab.Controls.Add(Me.DepthLbl)
        Me.EnclosureTab.Controls.Add(Me.WidthLbl)
        Me.EnclosureTab.Location = New System.Drawing.Point(0, 25)
        Me.EnclosureTab.Name = "EnclosureTab"
        Me.EnclosureTab.Selected = False
        Me.EnclosureTab.Size = New System.Drawing.Size(664, 87)
        Me.EnclosureTab.TabIndex = 4
        Me.EnclosureTab.Title = "Enclosure"
        Me.EnclosureTab.Visible = False
        '
        'TypeEnclosureCmb
        '
        Me.TypeEnclosureCmb.Location = New System.Drawing.Point(120, 61)
        Me.TypeEnclosureCmb.Name = "TypeEnclosureCmb"
        Me.TypeEnclosureCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TypeEnclosureCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TypeEnclosureCmb.Properties.NullString = ""
        Me.TypeEnclosureCmb.Size = New System.Drawing.Size(96, 19)
        Me.TypeEnclosureCmb.TabIndex = 133
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "* Type of Enclosure :"
        '
        'Typetxt
        '
        Me.Typetxt.Location = New System.Drawing.Point(120, 42)
        Me.Typetxt.Name = "Typetxt"
        Me.Typetxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Typetxt.Size = New System.Drawing.Size(72, 19)
        Me.Typetxt.TabIndex = 131
        '
        'ThicknessTxt
        '
        Me.ThicknessTxt.Location = New System.Drawing.Point(344, 37)
        Me.ThicknessTxt.Name = "ThicknessTxt"
        Me.ThicknessTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ThicknessTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ThicknessTxt.Size = New System.Drawing.Size(48, 19)
        Me.ThicknessTxt.TabIndex = 130
        Me.ThicknessTxt.Text = "0"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(240, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 129
        Me.Label20.Text = "Thickness :"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(16, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 18)
        Me.Label19.TabIndex = 128
        Me.Label19.Text = "Type : "
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(432, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 16)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "(eg. 1200mm x 2440mm)"
        '
        'MaterialCmb
        '
        Me.MaterialCmb.Location = New System.Drawing.Point(120, 24)
        Me.MaterialCmb.Name = "MaterialCmb"
        Me.MaterialCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MaterialCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialCmb.Properties.NullString = ""
        Me.MaterialCmb.Size = New System.Drawing.Size(88, 19)
        Me.MaterialCmb.TabIndex = 116
        '
        'EnclosureTxt
        '
        Me.EnclosureTxt.Enabled = False
        Me.EnclosureTxt.Location = New System.Drawing.Point(528, 61)
        Me.EnclosureTxt.Name = "EnclosureTxt"
        Me.EnclosureTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnclosureTxt.Properties.Enabled = False
        Me.EnclosureTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnclosureTxt.Size = New System.Drawing.Size(80, 19)
        Me.EnclosureTxt.TabIndex = 119
        Me.EnclosureTxt.Text = "0"
        '
        'MatCostTxt
        '
        Me.MatCostTxt.Location = New System.Drawing.Point(528, 24)
        Me.MatCostTxt.Name = "MatCostTxt"
        Me.MatCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MatCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MatCostTxt.Size = New System.Drawing.Size(48, 19)
        Me.MatCostTxt.TabIndex = 118
        Me.MatCostTxt.Text = "0"
        '
        'PowerCoatTxt
        '
        Me.PowerCoatTxt.Location = New System.Drawing.Point(344, 21)
        Me.PowerCoatTxt.Name = "PowerCoatTxt"
        Me.PowerCoatTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PowerCoatTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PowerCoatTxt.Size = New System.Drawing.Size(48, 19)
        Me.PowerCoatTxt.TabIndex = 117
        Me.PowerCoatTxt.Text = "0"
        '
        'DepthTxt
        '
        Me.DepthTxt.Location = New System.Drawing.Point(528, 5)
        Me.DepthTxt.Name = "DepthTxt"
        Me.DepthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DepthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DepthTxt.Size = New System.Drawing.Size(48, 19)
        Me.DepthTxt.TabIndex = 115
        Me.DepthTxt.Text = "0"
        '
        'WidthTxt
        '
        Me.WidthTxt.Location = New System.Drawing.Point(344, 5)
        Me.WidthTxt.Name = "WidthTxt"
        Me.WidthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WidthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WidthTxt.Size = New System.Drawing.Size(48, 19)
        Me.WidthTxt.TabIndex = 114
        Me.WidthTxt.Text = "0"
        '
        'HeightTxt
        '
        Me.HeightTxt.Location = New System.Drawing.Point(120, 5)
        Me.HeightTxt.Name = "HeightTxt"
        Me.HeightTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.HeightTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HeightTxt.Size = New System.Drawing.Size(48, 19)
        Me.HeightTxt.TabIndex = 113
        Me.HeightTxt.Text = "0"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(424, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "* Material Cost ($) :"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 14)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Material :"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 16)
        Me.Label22.TabIndex = 124
        Me.Label22.Text = "* Height (mm) :"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(432, 65)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 123
        Me.Label44.Text = "Enclosure Total :"
        '
        'CostLbl
        '
        Me.CostLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostLbl.Location = New System.Drawing.Point(232, 27)
        Me.CostLbl.Name = "CostLbl"
        Me.CostLbl.Size = New System.Drawing.Size(112, 16)
        Me.CostLbl.TabIndex = 122
        Me.CostLbl.Text = "* Power Coat ($/m) :"
        '
        'DepthLbl
        '
        Me.DepthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepthLbl.Location = New System.Drawing.Point(424, 11)
        Me.DepthLbl.Name = "DepthLbl"
        Me.DepthLbl.Size = New System.Drawing.Size(80, 14)
        Me.DepthLbl.TabIndex = 121
        Me.DepthLbl.Text = "* Depth (mm) :"
        '
        'WidthLbl
        '
        Me.WidthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthLbl.Location = New System.Drawing.Point(232, 11)
        Me.WidthLbl.Name = "WidthLbl"
        Me.WidthLbl.Size = New System.Drawing.Size(88, 14)
        Me.WidthLbl.TabIndex = 120
        Me.WidthLbl.Text = "* Length (mm) :"
        '
        'OthersTab
        '
        Me.OthersTab.Controls.Add(Me.InstallTxt)
        Me.OthersTab.Controls.Add(Me.PanelTransportTxt)
        Me.OthersTab.Controls.Add(Me.IncomingTxt)
        Me.OthersTab.Controls.Add(Me.OCEFTxt)
        Me.OthersTab.Controls.Add(Me.Label21)
        Me.OthersTab.Controls.Add(Me.Label23)
        Me.OthersTab.Controls.Add(Me.Label24)
        Me.OthersTab.Controls.Add(Me.OCEFlbl)
        Me.OthersTab.Controls.Add(Me.CopperTxt)
        Me.OthersTab.Controls.Add(Me.TransportTxt)
        Me.OthersTab.Controls.Add(Me.AccessoryTxt)
        Me.OthersTab.Controls.Add(Me.ConcreteBaseTxt)
        Me.OthersTab.Controls.Add(Me.WiringTxt)
        Me.OthersTab.Controls.Add(Me.Label25)
        Me.OthersTab.Controls.Add(Me.Label26)
        Me.OthersTab.Controls.Add(Me.Label27)
        Me.OthersTab.Controls.Add(Me.Label28)
        Me.OthersTab.Controls.Add(Me.Label29)
        Me.OthersTab.Location = New System.Drawing.Point(0, 25)
        Me.OthersTab.Name = "OthersTab"
        Me.OthersTab.Selected = False
        Me.OthersTab.Size = New System.Drawing.Size(664, 87)
        Me.OthersTab.TabIndex = 5
        Me.OthersTab.Title = "Others"
        Me.OthersTab.Visible = False
        '
        'InstallTxt
        '
        Me.InstallTxt.Location = New System.Drawing.Point(504, 56)
        Me.InstallTxt.Name = "InstallTxt"
        Me.InstallTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstallTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.InstallTxt.Size = New System.Drawing.Size(64, 19)
        Me.InstallTxt.TabIndex = 42
        Me.InstallTxt.Text = "0"
        '
        'PanelTransportTxt
        '
        Me.PanelTransportTxt.Location = New System.Drawing.Point(360, 56)
        Me.PanelTransportTxt.Name = "PanelTransportTxt"
        Me.PanelTransportTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelTransportTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelTransportTxt.Size = New System.Drawing.Size(64, 19)
        Me.PanelTransportTxt.TabIndex = 41
        Me.PanelTransportTxt.Text = "0"
        '
        'IncomingTxt
        '
        Me.IncomingTxt.Location = New System.Drawing.Point(200, 56)
        Me.IncomingTxt.Name = "IncomingTxt"
        Me.IncomingTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IncomingTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.IncomingTxt.Size = New System.Drawing.Size(64, 19)
        Me.IncomingTxt.TabIndex = 40
        Me.IncomingTxt.Text = "0"
        '
        'OCEFTxt
        '
        Me.OCEFTxt.Location = New System.Drawing.Point(64, 56)
        Me.OCEFTxt.Name = "OCEFTxt"
        Me.OCEFTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OCEFTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OCEFTxt.Size = New System.Drawing.Size(64, 19)
        Me.OCEFTxt.TabIndex = 39
        Me.OCEFTxt.Text = "0"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(440, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 16)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Installation :"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(272, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 16)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Panel Transport :"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(144, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Incoming :"
        '
        'OCEFlbl
        '
        Me.OCEFlbl.Location = New System.Drawing.Point(16, 64)
        Me.OCEFlbl.Name = "OCEFlbl"
        Me.OCEFlbl.Size = New System.Drawing.Size(48, 16)
        Me.OCEFlbl.TabIndex = 35
        Me.OCEFlbl.Text = "OC/EF :"
        '
        'CopperTxt
        '
        Me.CopperTxt.Location = New System.Drawing.Point(480, 8)
        Me.CopperTxt.Name = "CopperTxt"
        Me.CopperTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CopperTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CopperTxt.Size = New System.Drawing.Size(80, 19)
        Me.CopperTxt.TabIndex = 34
        Me.CopperTxt.Text = "0"
        '
        'TransportTxt
        '
        Me.TransportTxt.Location = New System.Drawing.Point(312, 24)
        Me.TransportTxt.Name = "TransportTxt"
        Me.TransportTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TransportTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TransportTxt.Size = New System.Drawing.Size(80, 19)
        Me.TransportTxt.TabIndex = 32
        Me.TransportTxt.Text = "0"
        '
        'AccessoryTxt
        '
        Me.AccessoryTxt.Location = New System.Drawing.Point(312, 8)
        Me.AccessoryTxt.Name = "AccessoryTxt"
        Me.AccessoryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AccessoryTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AccessoryTxt.Size = New System.Drawing.Size(80, 19)
        Me.AccessoryTxt.TabIndex = 30
        Me.AccessoryTxt.Text = "0"
        '
        'ConcreteBaseTxt
        '
        Me.ConcreteBaseTxt.Location = New System.Drawing.Point(112, 24)
        Me.ConcreteBaseTxt.Name = "ConcreteBaseTxt"
        Me.ConcreteBaseTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ConcreteBaseTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ConcreteBaseTxt.Size = New System.Drawing.Size(80, 19)
        Me.ConcreteBaseTxt.TabIndex = 31
        Me.ConcreteBaseTxt.Text = "0"
        '
        'WiringTxt
        '
        Me.WiringTxt.Location = New System.Drawing.Point(112, 8)
        Me.WiringTxt.Name = "WiringTxt"
        Me.WiringTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WiringTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WiringTxt.Size = New System.Drawing.Size(80, 19)
        Me.WiringTxt.TabIndex = 29
        Me.WiringTxt.Text = "0"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label25.Location = New System.Drawing.Point(240, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 16)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "Transport :"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label26.Location = New System.Drawing.Point(16, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 16)
        Me.Label26.TabIndex = 26
        Me.Label26.Text = "Concrete Base :"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label27.Location = New System.Drawing.Point(424, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 16)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Copper :"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label28.Location = New System.Drawing.Point(240, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 16)
        Me.Label28.TabIndex = 22
        Me.Label28.Text = "Accessory :"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label29.Location = New System.Drawing.Point(16, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "Wiring :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProjectTitleCmb)
        Me.GroupBox1.Controls.Add(Me.TotalCostTexttxt)
        Me.GroupBox1.Controls.Add(Me.RdBtn4)
        Me.GroupBox1.Controls.Add(Me.CashOfftxt)
        Me.GroupBox1.Controls.Add(Me.Rdbtn3)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Rdbtn2)
        Me.GroupBox1.Controls.Add(Me.RdBtn1)
        Me.GroupBox1.Controls.Add(Me.CP5Chk)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.CP5Lbl)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PODate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CustPOTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PercentOffTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.WONoTxt)
        Me.GroupBox1.Controls.Add(Me.QuoNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Addresstxt)
        Me.GroupBox1.Controls.Add(Me.QuoDate)
        Me.GroupBox1.Controls.Add(Me.OCNoTxt)
        Me.GroupBox1.Controls.Add(Me.ProjectCmb)
        Me.GroupBox1.Controls.Add(Me.StatusCmb)
        Me.GroupBox1.Controls.Add(Me.ContLookup)
        Me.GroupBox1.Controls.Add(Me.CustLookup)
        Me.GroupBox1.Controls.Add(Me.ProjectLbl)
        Me.GroupBox1.Controls.Add(Me.AddressLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.StatusLbl)
        Me.GroupBox1.Controls.Add(Me.DateLbl)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Controls.Add(Me.Lbl)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 160)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'ProjectTitleCmb
        '
        Me.ProjectTitleCmb.Location = New System.Drawing.Point(200, 96)
        Me.ProjectTitleCmb.Name = "ProjectTitleCmb"
        Me.ProjectTitleCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectTitleCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectTitleCmb.Properties.NullString = ""
        Me.ProjectTitleCmb.Properties.PopupWidth = 376
        Me.ProjectTitleCmb.Size = New System.Drawing.Size(360, 19)
        Me.ProjectTitleCmb.TabIndex = 60
        '
        'TotalCostTexttxt
        '
        Me.TotalCostTexttxt.Location = New System.Drawing.Point(112, 136)
        Me.TotalCostTexttxt.Name = "TotalCostTexttxt"
        Me.TotalCostTexttxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TotalCostTexttxt.Size = New System.Drawing.Size(448, 19)
        Me.TotalCostTexttxt.TabIndex = 59
        '
        'RdBtn4
        '
        Me.RdBtn4.Checked = True
        Me.RdBtn4.Location = New System.Drawing.Point(568, 136)
        Me.RdBtn4.Name = "RdBtn4"
        Me.RdBtn4.Size = New System.Drawing.Size(104, 16)
        Me.RdBtn4.TabIndex = 58
        Me.RdBtn4.TabStop = True
        Me.RdBtn4.Text = "No Discount"
        '
        'CashOfftxt
        '
        Me.CashOfftxt.Location = New System.Drawing.Point(624, 96)
        Me.CashOfftxt.Name = "CashOfftxt"
        Me.CashOfftxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CashOfftxt.Properties.ReadOnly = True
        Me.CashOfftxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CashOfftxt.Size = New System.Drawing.Size(40, 19)
        Me.CashOfftxt.TabIndex = 57
        Me.CashOfftxt.Text = "0"
        '
        'Rdbtn3
        '
        Me.Rdbtn3.Location = New System.Drawing.Point(568, 120)
        Me.Rdbtn3.Name = "Rdbtn3"
        Me.Rdbtn3.Size = New System.Drawing.Size(96, 16)
        Me.Rdbtn3.TabIndex = 55
        Me.Rdbtn3.Text = "% off @ line"
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(584, 104)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(40, 16)
        Me.Label43.TabIndex = 54
        Me.Label43.Text = "$ off :"
        '
        'Rdbtn2
        '
        Me.Rdbtn2.Location = New System.Drawing.Point(568, 104)
        Me.Rdbtn2.Name = "Rdbtn2"
        Me.Rdbtn2.Size = New System.Drawing.Size(16, 16)
        Me.Rdbtn2.TabIndex = 53
        '
        'RdBtn1
        '
        Me.RdBtn1.Location = New System.Drawing.Point(568, 88)
        Me.RdBtn1.Name = "RdBtn1"
        Me.RdBtn1.Size = New System.Drawing.Size(16, 16)
        Me.RdBtn1.TabIndex = 52
        '
        'CP5Chk
        '
        Me.CP5Chk.Location = New System.Drawing.Point(240, 120)
        Me.CP5Chk.Name = "CP5Chk"
        Me.CP5Chk.Size = New System.Drawing.Size(16, 16)
        Me.CP5Chk.TabIndex = 49
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(208, 120)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(32, 16)
        Me.Label39.TabIndex = 51
        Me.Label39.Text = "CP5"
        '
        'CP5Lbl
        '
        Me.CP5Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP5Lbl.Location = New System.Drawing.Point(8, 120)
        Me.CP5Lbl.Name = "CP5Lbl"
        Me.CP5Lbl.Size = New System.Drawing.Size(216, 16)
        Me.CP5Lbl.TabIndex = 50
        Me.CP5Lbl.Text = "Statutory And Regulatory Requirement :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Total Amount :"
        '
        'PODate
        '
        Me.PODate.DateTime = New Date(CType(0, Long))
        Me.PODate.Location = New System.Drawing.Point(560, 36)
        Me.PODate.Name = "PODate"
        Me.PODate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PODate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PODate.Size = New System.Drawing.Size(104, 19)
        Me.PODate.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(488, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "PO Date :"
        '
        'CustPOTxt
        '
        Me.CustPOTxt.Location = New System.Drawing.Point(336, 36)
        Me.CustPOTxt.Name = "CustPOTxt"
        Me.CustPOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustPOTxt.Size = New System.Drawing.Size(104, 19)
        Me.CustPOTxt.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(264, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 12)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Cust PO :"
        '
        'PercentOffTxt
        '
        Me.PercentOffTxt.Location = New System.Drawing.Point(624, 80)
        Me.PercentOffTxt.Name = "PercentOffTxt"
        Me.PercentOffTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PercentOffTxt.Properties.ReadOnly = True
        Me.PercentOffTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PercentOffTxt.Size = New System.Drawing.Size(40, 19)
        Me.PercentOffTxt.TabIndex = 42
        Me.PercentOffTxt.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(584, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "% off :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Work Order :"
        '
        'WONoTxt
        '
        Me.WONoTxt.Location = New System.Drawing.Point(112, 36)
        Me.WONoTxt.Name = "WONoTxt"
        Me.WONoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WONoTxt.Size = New System.Drawing.Size(112, 19)
        Me.WONoTxt.TabIndex = 39
        '
        'QuoNoTxt
        '
        Me.QuoNoTxt.Location = New System.Drawing.Point(336, 16)
        Me.QuoNoTxt.Name = "QuoNoTxt"
        Me.QuoNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuoNoTxt.Size = New System.Drawing.Size(104, 19)
        Me.QuoNoTxt.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(264, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Quot. No :"
        '
        'Addresstxt
        '
        Me.Addresstxt.Location = New System.Drawing.Point(360, 76)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Addresstxt.Size = New System.Drawing.Size(200, 19)
        Me.Addresstxt.TabIndex = 35
        '
        'QuoDate
        '
        Me.QuoDate.DateTime = New Date(CType(0, Long))
        Me.QuoDate.Location = New System.Drawing.Point(560, 16)
        Me.QuoDate.Name = "QuoDate"
        Me.QuoDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuoDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.QuoDate.Size = New System.Drawing.Size(104, 19)
        Me.QuoDate.TabIndex = 34
        '
        'OCNoTxt
        '
        Me.OCNoTxt.Location = New System.Drawing.Point(112, 16)
        Me.OCNoTxt.Name = "OCNoTxt"
        Me.OCNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OCNoTxt.Properties.ReadOnly = True
        Me.OCNoTxt.Size = New System.Drawing.Size(112, 19)
        Me.OCNoTxt.TabIndex = 33
        '
        'ProjectCmb
        '
        Me.ProjectCmb.Location = New System.Drawing.Point(112, 96)
        Me.ProjectCmb.Name = "ProjectCmb"
        Me.ProjectCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectCmb.Properties.NullString = ""
        Me.ProjectCmb.Size = New System.Drawing.Size(80, 19)
        Me.ProjectCmb.TabIndex = 7
        '
        'StatusCmb
        '
        Me.StatusCmb.Enabled = False
        Me.StatusCmb.Location = New System.Drawing.Point(560, 56)
        Me.StatusCmb.Name = "StatusCmb"
        Me.StatusCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusCmb.Properties.Enabled = False
        Me.StatusCmb.Properties.NullString = ""
        Me.StatusCmb.Size = New System.Drawing.Size(104, 19)
        Me.StatusCmb.TabIndex = 4
        '
        'ContLookup
        '
        Me.ContLookup.Location = New System.Drawing.Point(112, 76)
        Me.ContLookup.Name = "ContLookup"
        Me.ContLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContLookup.Properties.NullString = ""
        Me.ContLookup.Properties.PopupWidth = 184
        Me.ContLookup.Size = New System.Drawing.Size(184, 19)
        Me.ContLookup.TabIndex = 5
        '
        'CustLookup
        '
        Me.CustLookup.Location = New System.Drawing.Point(112, 56)
        Me.CustLookup.Name = "CustLookup"
        Me.CustLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustLookup.Properties.NullString = ""
        Me.CustLookup.Properties.PopupWidth = 368
        Me.CustLookup.Size = New System.Drawing.Size(368, 19)
        Me.CustLookup.TabIndex = 3
        '
        'ProjectLbl
        '
        Me.ProjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectLbl.Location = New System.Drawing.Point(8, 100)
        Me.ProjectLbl.Name = "ProjectLbl"
        Me.ProjectLbl.Size = New System.Drawing.Size(56, 16)
        Me.ProjectLbl.TabIndex = 27
        Me.ProjectLbl.Text = "* Project :"
        '
        'AddressLbl
        '
        Me.AddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLbl.Location = New System.Drawing.Point(304, 82)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(56, 16)
        Me.AddressLbl.TabIndex = 20
        Me.AddressLbl.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "* Contact Person :"
        '
        'StatusLbl
        '
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(496, 62)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(56, 16)
        Me.StatusLbl.TabIndex = 16
        Me.StatusLbl.Text = "* Status :"
        '
        'DateLbl
        '
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(488, 24)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(48, 16)
        Me.DateLbl.TabIndex = 13
        Me.DateLbl.Text = "* Date :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(8, 62)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(104, 16)
        Me.CustNameLbl.TabIndex = 10
        Me.CustNameLbl.Text = "* Customer Name :"
        '
        'Lbl
        '
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(8, 24)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(104, 16)
        Me.Lbl.TabIndex = 11
        Me.Lbl.Text = "Order Confirm No :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Selected = False
        Me.TabPage2.Size = New System.Drawing.Size(696, 487)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Title = "Payment Details"
        Me.TabPage2.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CollectModeCmb)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.ClosingTxt)
        Me.GroupBox4.Controls.Add(Me.SignByCmb)
        Me.GroupBox4.Controls.Add(Me.ServiceTypeCmb)
        Me.GroupBox4.Controls.Add(Me.PriceTillCmb)
        Me.GroupBox4.Controls.Add(Me.ValidityTxt)
        Me.GroupBox4.Controls.Add(Me.OtherNotesMemo)
        Me.GroupBox4.Controls.Add(Me.NotesMemo)
        Me.GroupBox4.Controls.Add(Me.DelTermsMemo)
        Me.GroupBox4.Controls.Add(Me.PayDetailsMemo)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(680, 480)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'CollectModeCmb
        '
        Me.CollectModeCmb.Location = New System.Drawing.Point(256, 16)
        Me.CollectModeCmb.Name = "CollectModeCmb"
        Me.CollectModeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CollectModeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CollectModeCmb.Properties.NullString = ""
        Me.CollectModeCmb.Size = New System.Drawing.Size(144, 19)
        Me.CollectModeCmb.TabIndex = 43
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(176, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(80, 16)
        Me.Label42.TabIndex = 42
        Me.Label42.Text = "Collect Mode :"
        '
        'ClosingTxt
        '
        Me.ClosingTxt.Location = New System.Drawing.Point(64, 152)
        Me.ClosingTxt.Name = "ClosingTxt"
        Me.ClosingTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ClosingTxt.Size = New System.Drawing.Size(432, 19)
        Me.ClosingTxt.TabIndex = 41
        '
        'SignByCmb
        '
        Me.SignByCmb.Location = New System.Drawing.Point(544, 76)
        Me.SignByCmb.Name = "SignByCmb"
        Me.SignByCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SignByCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SignByCmb.Properties.NullString = ""
        Me.SignByCmb.Size = New System.Drawing.Size(112, 19)
        Me.SignByCmb.TabIndex = 40
        '
        'ServiceTypeCmb
        '
        Me.ServiceTypeCmb.Location = New System.Drawing.Point(544, 56)
        Me.ServiceTypeCmb.Name = "ServiceTypeCmb"
        Me.ServiceTypeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ServiceTypeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ServiceTypeCmb.Properties.NullString = ""
        Me.ServiceTypeCmb.Size = New System.Drawing.Size(112, 19)
        Me.ServiceTypeCmb.TabIndex = 39
        '
        'PriceTillCmb
        '
        Me.PriceTillCmb.Location = New System.Drawing.Point(544, 36)
        Me.PriceTillCmb.Name = "PriceTillCmb"
        Me.PriceTillCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PriceTillCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PriceTillCmb.Properties.NullString = ""
        Me.PriceTillCmb.Size = New System.Drawing.Size(112, 19)
        Me.PriceTillCmb.TabIndex = 38
        '
        'ValidityTxt
        '
        Me.ValidityTxt.Location = New System.Drawing.Point(64, 16)
        Me.ValidityTxt.Name = "ValidityTxt"
        Me.ValidityTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ValidityTxt.Size = New System.Drawing.Size(48, 19)
        Me.ValidityTxt.TabIndex = 35
        '
        'OtherNotesMemo
        '
        Me.OtherNotesMemo.Location = New System.Drawing.Point(64, 176)
        Me.OtherNotesMemo.Name = "OtherNotesMemo"
        Me.OtherNotesMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OtherNotesMemo.Size = New System.Drawing.Size(432, 32)
        Me.OtherNotesMemo.TabIndex = 33
        '
        'NotesMemo
        '
        Me.NotesMemo.Location = New System.Drawing.Point(64, 100)
        Me.NotesMemo.Name = "NotesMemo"
        Me.NotesMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesMemo.Size = New System.Drawing.Size(336, 40)
        Me.NotesMemo.TabIndex = 32
        '
        'DelTermsMemo
        '
        Me.DelTermsMemo.Location = New System.Drawing.Point(64, 60)
        Me.DelTermsMemo.Name = "DelTermsMemo"
        Me.DelTermsMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DelTermsMemo.Size = New System.Drawing.Size(336, 40)
        Me.DelTermsMemo.TabIndex = 31
        '
        'PayDetailsMemo
        '
        Me.PayDetailsMemo.Location = New System.Drawing.Point(64, 36)
        Me.PayDetailsMemo.Name = "PayDetailsMemo"
        Me.PayDetailsMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PayDetailsMemo.Size = New System.Drawing.Size(336, 24)
        Me.PayDetailsMemo.TabIndex = 30
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 160)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 16)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "Closing :"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 176)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 24)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Typical Notes 1 :"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 104)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Notes :"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(456, 80)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 16)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Signed by :"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(456, 62)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Service Type :"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(456, 44)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 16)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Price include till :"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(8, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 16)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "Validity :"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 38)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 32)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Payment Term :"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(8, 68)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 32)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "Delivery Terms :"
        '
        'TradingOrderConfirmationForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(712, 573)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.DispatchBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveQuoBtn)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "TradingOrderConfirmationForm"
        Me.Text = "Trading Order Confirmation"
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GrandTotalTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompCostTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNavLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ItemTab.ResumeLayout(False)
        CType(Me.BoxCategoryCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscPriceTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentOffLineTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompMarkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopyFmBxCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OverallMarkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCostTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnclosureTab.ResumeLayout(False)
        CType(Me.TypeEnclosureCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typetxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThicknessTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnclosureTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatCostTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerCoatTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OthersTab.ResumeLayout(False)
        CType(Me.InstallTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelTransportTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomingTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCEFTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopperTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoryTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConcreteBaseTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WiringTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostTexttxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashOfftxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustPOTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentOffTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WONoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.CollectModeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosingTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignByCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceTypeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceTillCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherNotesMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelTermsMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayDetailsMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load "
    Private Sub OrderConfirmationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Top = (MainForm.ActiveForm.Height - Me.Height) / 3
        'Me.Left = (MainForm.ActiveForm.Width - Me.Width) / 2

        Me.Cursor = Cursors.WaitCursor

        LoadCustomerDetails()
        LoadEnclosureType()
        LoadProjectTitle()
        LoadPriceIncludeTill()

        LoadCombo()
        SetTabColors()
        LoadBoxCategory()

        TabControl3.IDEPixelBorder = True

        Select Case UCase(FormStatus)
            Case "NEW"
                ItemNo = 0
                InitializeForm()
                DisableNavBtn()
            Case "FROMQUO"
                DuplicateQuotationHeader()
                DuplicateQuotationLine()
                RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                Me.NavdsBox_PositionChanged()
            Case "EDIT"
                Me.Text = "Edit Order Confirmation"
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetOrderConfirmHeader(dsHeaderLoad, Quotation_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                CompGrid1.Enabled = True
                SaveQuoBtn.Enabled = True
                RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
            Case "REVISED"
                Me.Text = "Revise Order Confirmation"
                RevisedQuotationHeader()
                RevisedQuotationLine()
                SetOldOrderConfirmationStatus()
                RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
            Case "VIEW"
                Me.Text = "View Order Confirmation"
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetOrderConfirmHeader(dsHeaderLoad, Quotation_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                RefreshNavBtn()
                GroupBox1.Enabled = False
                DisableGroupBox2()
                GroupBox4.Enabled = False
                SaveQuoBtn.Enabled = False
                DispatchBtn.Enabled = False
                NavFirstBtn.Enabled = True
                NavLastBtn.Enabled = True
                NavNextBtn.Enabled = True
                NavPrevBtn.Enabled = True
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
            Case "OCVO"
                Me.Text = "Variation "
                VOQuotationHeader()
                'RevisedQuotationLine()
                'SetOldOrderConfirmationStatus()
                'RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                'If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                'Me.NavdsBox_PositionChanged()
                'End If
        End Select

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DisableGroupBox2()
        AddBtn.Enabled = False
        DelProdBtn.Enabled = False
        UpdateBtn.Enabled = False
        UpdateAllBtn.Enabled = False
        BoxDescTxt.Enabled = False
        BoxCategoryCmb.Enabled = False
        OverallMarkTxt.Enabled = False
        CompMarkTxt.Enabled = False
        QtyTxt.Enabled = False
        CopyFmBxCmb.Enabled = False
        PercentOffLineTxt.Enabled = False
        HeightTxt.Enabled = False
        WidthTxt.Enabled = False
        DepthTxt.Enabled = False
        MaterialCmb.Enabled = False
        PowerCoatTxt.Enabled = False
        MatCostTxt.Enabled = False
        Typetxt.Enabled = False
        ThicknessTxt.Enabled = False
        TypeEnclosureCmb.Enabled = False
        WiringTxt.Enabled = False
        AccessoryTxt.Enabled = False
        CopperTxt.Enabled = False
        TransportTxt.Enabled = False
        ConcreteBaseTxt.Enabled = False
        OCEFTxt.Enabled = False
        IncomingTxt.Enabled = False
        PanelTransportTxt.Enabled = False
        InstallTxt.Enabled = False
        CompGrid1.Enabled = False
    End Sub

    Private Sub SetTabColors()
        '** Tab Control Appearance **
        TabControl1.BackColor = Color.DarkSlateBlue
        TabControl1.ForeColor = Color.White
        TabControl1.ButtonActiveColor = Color.White
        TabControl1.ButtonInactiveColor = Color.SlateBlue
        TabControl1.TextInactiveColor = Color.White
        TabControl1.HotTextColor = Color.Cyan
        '***
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

        StatusCmb.Properties.LookUpData.KeyValue = "10"
        ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        SignByCmb.Properties.LookUpData.KeyValue = "Thomas Yeo"
        ServiceTypeCmb.Properties.LookUpData.KeyValue = "1"
        ItemNoTxt.Text = ItemNo.ToString
        QuoDate.DateTime = Date.Today

        ClosingTxt.Text = "We hope that our quotation is acceptable and looking forward to hear from you soon."
        OtherNotesMemo.Text = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."

        With New BusinessRules.SaleBusRules.SaleBusLogic
            'GET CUSTOMER INITIAL
            Dim dstmp As DataSet
            Dim CustInitial
            If .GetCustomerDetails(dstmp, Customer_ID) Then
                If dstmp.Tables(0).Rows.Count > 0 Then
                    CustInitial = dstmp.Tables(0).Rows(0)("Initial")
                    CustLookup.Properties.LookUpData.KeyValue = dstmp.Tables(0).Rows(0)("Customer_ID")
                End If
            End If
            dstmp.Dispose()
            LoadContactPerson(Customer_ID)
            CustLookup.Properties.ReadOnly = True

            Confirm_Quotation_No = GetOrderConfirmationNo(CustInitial)
            OCNoTxt.Text = Confirm_Quotation_No

            .Confirm_Quotation_No = Confirm_Quotation_No
            .UserID = UserID
            .Status = StatusCmb.Properties.LookUpData.KeyValue

            If .SaveOrderConfirmationNo() Then
                Quotation_ID = .Quotation_ID        'Store Quotation ID
            Else
                MessageBox.Show("Error creating Order Confirmation", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub
#End Region

#Region " Variation OC "
    Private Sub VOQuotationHeader()
        Dim dsLoad As DataSet
        Dim VONo As Integer
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetOrderConfirmHeader(dsLoad, Old_Quotation_ID) Then
                'Check if its created from revised quotation or based quotation
                .Quotation_ID = Old_Quotation_ID
                If .IsVOQuote(dsBasedQuotation) Then        'if its vo oc, then load based Oc no
                    BasedQuotationID = dsBasedQuotation.Tables(0).Rows(0)("Quotation_ID")
                    Confirm_Quotation_No = dsBasedQuotation.Tables(0).Rows(0)("Confirm_Quotation_NO")
                    'COUNT THE NO OF REVISED COPY
                    .VORefQuotationID = BasedQuotationID
                    VONo = .CountNoOfVOQuote()
                    '****
                    VORefQuotationID = BasedQuotationID        'Reference to the based ID
                Else
                    Confirm_Quotation_No = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")  'Get the Existing Quotation No.
                    'COUNT THE NO OF REVISED COPY
                    .VORefQuotationID = Old_Quotation_ID
                    VONo = .CountNoOfVOQuote()
                    '****
                    VORefQuotationID = Old_Quotation_ID        'Reference
                End If
                '****

                'CHECKING
                .Confirm_Quotation_No = Confirm_Quotation_No & "-VO" & VONo          'Appending R...
                If .CheckExistingOrderConfirmationNo() Then         'Record exist
                    VONo = VONo + 1
                    .Confirm_Quotation_No = Confirm_Quotation_No & "-VO" & VONo
                    While .CheckExistingOrderConfirmationNo()
                        VONo = VONo + 1
                        .Confirm_Quotation_No = Confirm_Quotation_No & "-VO" & VONo
                    End While
                End If
                '***

                If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Quotation_NO")) Then
                    .Quotation_No = dsLoad.Tables(0).Rows(0)("Quotation_NO")
                End If
                .Status = "10"
                .UserID = UserID
                If .SaveOrderConfirmationNo() Then
                    Quotation_ID = .Quotation_ID    'Get the new quotation_ID
                    'saving
                    .Quotation_ID = Quotation_ID
                    .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("QuotationDate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("QuotationDate"))) & Year(dsLoad.Tables(0).Rows(0)("QuotationDate"))
                    .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                    .Project = dsLoad.Tables(0).Rows(0)("Project")
                    .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")
                    .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
                        .Consultant_ID = dsLoad.Tables(0).Rows(0)("Consultant_ID")
                    End If

                    .Customer_PO = dsLoad.Tables(0).Rows(0)("Customer_PO")
                    .PODate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("PODate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("PODate"))) & Year(dsLoad.Tables(0).Rows(0)("PODate"))
                    .Percent_Discount = dsLoad.Tables(0).Rows(0)("Percent_Discount")
                    .Cash_Discount = dsLoad.Tables(0).Rows(0)("Cash_Discount")

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Total_Cost_Text")) Then
                        .Total_Cost_Text = dsLoad.Tables(0).Rows(0)("Total_Cost_Text")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
                        .Payment_Term = dsLoad.Tables(0).Rows(0)("Payment_Term")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Validity")) Then
                        .Validity = dsLoad.Tables(0).Rows(0)("Validity")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
                        .Delivery_Term = dsLoad.Tables(0).Rows(0)("Delivery_Term")
                    End If
                    If Len(dsLoad.Tables(0).Rows(0)("Service_Type")) > 0 Then
                        .Service_Type = dsLoad.Tables(0).Rows(0)("Service_Type")
                    End If
                    .CP5_Flg = dsLoad.Tables(0).Rows(0)("CP5_Flg")
                    .Sign_By = dsLoad.Tables(0).Rows(0)("Sign_By")
                    .Total_Cost_Numeric = Double.Parse(dsLoad.Tables(0).Rows(0)("Total_Cost_Numeric"))

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("CollectMode")) Then
                        .CollectMode = dsLoad.Tables(0).Rows(0)("CollectMode")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remarks")) Then
                        .Remarks = dsLoad.Tables(0).Rows(0)("Remarks")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ClosingNotes")) Then
                        .ClosingNotes = dsLoad.Tables(0).Rows(0)("ClosingNotes")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("OtherNotes")) Then
                        .OtherNotes = dsLoad.Tables(0).Rows(0)("OtherNotes")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PriceInclude_ID")) Then
                        .PriceInclude_ID = dsLoad.Tables(0).Rows(0)("PriceInclude_ID")
                    End If
                    If .UpdateQuotationHeader() Then
                        Dim dsNew As DataSet
                        If .GetOrderConfirmHeader(dsNew, Quotation_ID) Then
                            SetWindowValue(dsNew)
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With
    End Sub
#End Region

#Region " Revised Order Confirmation "
    Private Sub RevisedQuotationHeader()
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetOrderConfirmHeader(dsLoad, Old_Quotation_ID) Then
                'Check if its created from revised quotation or based quotation
                .Quotation_ID = Old_Quotation_ID
                If .IsRevisedQuote(dsBasedQuotation) Then        'if its revised quotation, then load based Quotation no
                    BasedQuotationID = dsBasedQuotation.Tables(0).Rows(0)("Quotation_ID")
                    Confirm_Quotation_No = dsBasedQuotation.Tables(0).Rows(0)("Confirm_Quotation_NO")
                    'COUNT THE NO OF REVISED COPY
                    .RevRefQuotationID = BasedQuotationID
                    RevisedNo = .CountNoOfRevisedQuote()
                    '****
                    RevRefQuotationID = BasedQuotationID        'Reference to the based ID
                Else
                    Confirm_Quotation_No = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")  'Get the Existing Quotation No.
                    'COUNT THE NO OF REVISED COPY
                    .RevRefQuotationID = Old_Quotation_ID
                    RevisedNo = .CountNoOfRevisedQuote()
                    '****
                    RevRefQuotationID = Old_Quotation_ID        'Reference
                End If
                '****

                'CHECKING
                .Confirm_Quotation_No = Confirm_Quotation_No & "R" & RevisedNo          'Appending R...
                If .CheckExistingOrderConfirmationNo() Then         'Record exist
                    RevisedNo = RevisedNo + 1
                    .Confirm_Quotation_No = Confirm_Quotation_No & "R" & RevisedNo
                    While .CheckExistingOrderConfirmationNo()
                        RevisedNo = RevisedNo + 1
                        .Confirm_Quotation_No = Confirm_Quotation_No & "R" & RevisedNo
                    End While
                End If
                '***

                If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Quotation_NO")) Then
                    .Quotation_No = dsLoad.Tables(0).Rows(0)("Quotation_NO")
                End If
                .Status = "10"
                .UserID = UserID
                If .SaveOrderConfirmationNo() Then
                    Quotation_ID = .Quotation_ID    'Get the new quotation_ID
                    'saving
                    .Quotation_ID = Quotation_ID
                    .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("QuotationDate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("QuotationDate"))) & Year(dsLoad.Tables(0).Rows(0)("QuotationDate"))
                    '.Status = dsLoad.Tables(0).Rows(0)("Status")
                    .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                    .Project = dsLoad.Tables(0).Rows(0)("Project")
                    .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")
                    .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
                        .Consultant_ID = dsLoad.Tables(0).Rows(0)("Consultant_ID")
                    End If

                    .Customer_PO = dsLoad.Tables(0).Rows(0)("Customer_PO")
                    .PODate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("PODate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("PODate"))) & Year(dsLoad.Tables(0).Rows(0)("PODate"))
                    .Percent_Discount = dsLoad.Tables(0).Rows(0)("Percent_Discount")
                    .Cash_Discount = dsLoad.Tables(0).Rows(0)("Cash_Discount")

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Total_Cost_Text")) Then
                        .Total_Cost_Text = dsLoad.Tables(0).Rows(0)("Total_Cost_Text")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
                        .Payment_Term = dsLoad.Tables(0).Rows(0)("Payment_Term")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Validity")) Then
                        .Validity = dsLoad.Tables(0).Rows(0)("Validity")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
                        .Delivery_Term = dsLoad.Tables(0).Rows(0)("Delivery_Term")
                    End If
                    If Len(dsLoad.Tables(0).Rows(0)("Service_Type")) > 0 Then
                        .Service_Type = dsLoad.Tables(0).Rows(0)("Service_Type")
                    End If
                    .CP5_Flg = dsLoad.Tables(0).Rows(0)("CP5_Flg")
                    .Sign_By = dsLoad.Tables(0).Rows(0)("Sign_By")
                    .Total_Cost_Numeric = Double.Parse(dsLoad.Tables(0).Rows(0)("Total_Cost_Numeric"))

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("CollectMode")) Then
                        .CollectMode = dsLoad.Tables(0).Rows(0)("CollectMode")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remarks")) Then
                        .Remarks = dsLoad.Tables(0).Rows(0)("Remarks")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ClosingNotes")) Then
                        .ClosingNotes = dsLoad.Tables(0).Rows(0)("ClosingNotes")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("OtherNotes")) Then
                        .OtherNotes = dsLoad.Tables(0).Rows(0)("OtherNotes")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PriceInclude_ID")) Then
                        .PriceInclude_ID = dsLoad.Tables(0).Rows(0)("PriceInclude_ID")
                    End If

                    'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RevRefQuotationID")) Then
                    '.RevRefQuotationID = RevRefQuotationID
                    'End If

                    If .UpdateQuotationHeader() Then
                        Dim dsNew As DataSet
                        If .GetOrderConfirmHeader(dsNew, Quotation_ID) Then
                            SetWindowValue(dsNew)
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With
    End Sub

    Private Sub RevisedQuotationLine()
        Dim dsLine As DataSet
        Dim Old_Quotation_Line_ID As Integer

        ItemNo = 0
        With New BusinessRules.SaleBusRules.SaleBusLogic
            'Get the old quotation line item
            .Quotation_ID = Old_Quotation_ID
            If .GetQuotationLine(dsLine) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    'Save the itemno first
                    ItemNo = ItemNo + 1
                    .ItemNo = ItemNo
                    .Quotation_ID = Quotation_ID
                    .UserID = UserID
                    If .SaveQuotationLineFirstTime() Then
                        Quotation_Line_ID = .Quotation_Line_ID
                    End If
                    '***
                    Old_Quotation_Line_ID = dsLine.Tables(0).Rows(x)("Quotation_Line_ID")
                    .Box = dsLine.Tables(0).Rows(x)("Box")
                    .BoxCategory_ID = dsLine.Tables(0).Rows(x)("BoxCategory_ID")
                    .varHeight = dsLine.Tables(0).Rows(x)("Height")
                    .varWidth = dsLine.Tables(0).Rows(x)("Width")
                    .Depth = dsLine.Tables(0).Rows(x)("Depth")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Raw_Material")) Then
                        .Raw_Material = dsLine.Tables(0).Rows(x)("Raw_Material")
                    End If

                    .LinePercent_Discount = dsLine.Tables(0).Rows(x)("LinePercent_Discount")

                    .Material_Cost = dsLine.Tables(0).Rows(x)("Material_Cost")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Type")) Then
                        .Type = dsLine.Tables(0).Rows(x)("Type")
                    End If

                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Thickness")) Then
                        .Thickness = dsLine.Tables(0).Rows(x)("Thickness")
                    End If
                    .Power_Coat = dsLine.Tables(0).Rows(x)("Power_Coat")
                    .Wiring = dsLine.Tables(0).Rows(x)("Wiring")
                    .Accessory = dsLine.Tables(0).Rows(x)("Accessory")
                    .Copper = dsLine.Tables(0).Rows(x)("Copper")
                    .Comp_Markup = dsLine.Tables(0).Rows(x)("Comp_Markup")
                    .Concrete_Base = dsLine.Tables(0).Rows(x)("Concrete_Base")
                    .Transport = dsLine.Tables(0).Rows(x)("Transport")
                    .Enclosure = dsLine.Tables(0).Rows(x)("Enclosure")
                    .Qty = dsLine.Tables(0).Rows(x)("Qty")
                    .Cost = dsLine.Tables(0).Rows(x)("Cost")
                    .Overall_Markup = dsLine.Tables(0).Rows(x)("Overall_Markup")
                    .Total_Amount = dsLine.Tables(0).Rows(x)("Total_Amount")
                    .OC_EF = dsLine.Tables(0).Rows(x)("OC_EF")
                    .Incoming = dsLine.Tables(0).Rows(x)("Incoming")
                    .Panel_Transport = dsLine.Tables(0).Rows(x)("Panel_Transport")
                    .Installation = dsLine.Tables(0).Rows(x)("Installation")
                    .Type_Of_Enclosure = dsLine.Tables(0).Rows(x)("Type_Of_Enclosure")
                    .Quotation_Line_ID = Quotation_Line_ID
                    .UserID = UserID

                    If .UpdateQuotationLine() Then
                        Dim dsComp As DataSet
                        .Quotation_Line_ID = Old_Quotation_Line_ID
                        If .GetQuotationLineCompOnLineID(dsComp) Then
                            Dim i As Integer
                            For i = 0 To dsComp.Tables(0).Rows.Count - 1
                                .Quotation_ID = Quotation_ID
                                .Quotation_Line_ID = Quotation_Line_ID
                                .Category_ID = dsComp.Tables(0).Rows(i)("Category_ID")
                                .Product_ID = dsComp.Tables(0).Rows(i)("Product_ID")
                                .Supplier_ID = dsComp.Tables(0).Rows(i)("Supplier_ID")
                                .UnitPrice = dsComp.Tables(0).Rows(i)("UnitPrice")
                                .Lead_Time = dsComp.Tables(0).Rows(i)("Lead_Time")
                                .CompQty = dsComp.Tables(0).Rows(i)("Qty")
                                .UserID = UserID
                                If .SaveQuotationLineComponent() Then

                                End If
                            Next
                        End If
                        dsComp.Dispose()
                    End If
                Next
                dsLine.Dispose()
            End If
        End With
    End Sub

    Private Sub SetOldOrderConfirmationStatus()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Old_Quotation_ID
            .Status = "40"
            If .UpdateQuotationHeaderStatus() Then

            End If
        End With
    End Sub
#End Region

#Region " Duplicate Quotation to Order Confirmation "
    Private Sub DuplicateQuotationHeader()
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer
        Dim CustInitial As String

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeader(dsLoad, Old_Quotation_ID) Then
                .Quotation_No = dsLoad.Tables(0).Rows(0)("Quotation_No")  'Get the Existing Quotation No.
                .Status = "10"
                .UserID = UserID
                If .SaveQuotationNo() Then
                    Quotation_ID = .Quotation_ID    'Get the new quotation_ID
                    'saving
                    .Quotation_ID = Quotation_ID
                    .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("QuotationDate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("QuotationDate"))) & Year(dsLoad.Tables(0).Rows(0)("QuotationDate"))
                    .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                    .Project = dsLoad.Tables(0).Rows(0)("Project")
                    .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")

                    'GET CUSTOMER INITIAL
                    Dim dstmp As DataSet
                    If .GetCustomerDetails(dstmp, dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
                        If dstmp.Tables(0).Rows.Count > 0 Then
                            CustInitial = dstmp.Tables(0).Rows(0)("Initial")
                        End If
                    End If
                    dstmp.Dispose()

                    Confirm_Quotation_No = GetOrderConfirmationNo(CustInitial)
                    .Confirm_Quotation_No = Confirm_Quotation_No
                    '***

                    .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
                        .Payment_Term = dsLoad.Tables(0).Rows(0)("Payment_Term")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Validity")) Then
                        .Validity = dsLoad.Tables(0).Rows(0)("Validity")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
                        .Delivery_Term = dsLoad.Tables(0).Rows(0)("Delivery_Term")
                    End If
                    If Len(dsLoad.Tables(0).Rows(0)("Service_Type")) > 0 Then
                        .Service_Type = dsLoad.Tables(0).Rows(0)("Service_Type")
                    End If
                    .CP5_Flg = dsLoad.Tables(0).Rows(0)("CP5_Flg")
                    .Sign_By = dsLoad.Tables(0).Rows(0)("Sign_By")
                    .Total_Cost_Numeric = Double.Parse(dsLoad.Tables(0).Rows(0)("Total_Cost_Numeric"))

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remarks")) Then
                        .Remarks = dsLoad.Tables(0).Rows(0)("Remarks")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ClosingNotes")) Then
                        .ClosingNotes = dsLoad.Tables(0).Rows(0)("ClosingNotes")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("OtherNotes")) Then
                        .OtherNotes = dsLoad.Tables(0).Rows(0)("OtherNotes")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PriceInclude_ID")) Then
                        .PriceInclude_ID = dsLoad.Tables(0).Rows(0)("PriceInclude_ID")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RevRefQuotationID")) Then
                        .RevRefQuotationID = RevRefQuotationID
                    End If

                    If .UpdateQuotationHeader() Then
                        Dim dsNew As DataSet
                        If .GetOrderConfirmHeader(dsNew, Quotation_ID) Then
                            SetWindowValue(dsNew)
                        End If
                        dsNew.Dispose()
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With
    End Sub

    Private Sub DuplicateQuotationLine()
        Dim dsLine As DataSet
        Dim Old_Quotation_Line_ID As Integer

        ItemNo = 0
        With New BusinessRules.SaleBusRules.SaleBusLogic
            'Get the old quotation line item
            .Quotation_ID = Old_Quotation_ID
            If .GetQuotationLine(dsLine) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    'Save the itemno first
                    ItemNo = ItemNo + 1
                    .ItemNo = ItemNo
                    .Quotation_ID = Quotation_ID
                    .UserID = UserID
                    If .SaveQuotationLineFirstTime() Then
                        Quotation_Line_ID = .Quotation_Line_ID
                    End If
                    '***
                    Old_Quotation_Line_ID = dsLine.Tables(0).Rows(x)("Quotation_Line_ID")
                    .Box = dsLine.Tables(0).Rows(x)("Box")
                    .varHeight = dsLine.Tables(0).Rows(x)("Height")
                    .varWidth = dsLine.Tables(0).Rows(x)("Width")
                    .Depth = dsLine.Tables(0).Rows(x)("Depth")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Raw_Material")) Then
                        .Raw_Material = dsLine.Tables(0).Rows(x)("Raw_Material")
                    End If

                    .Material_Cost = dsLine.Tables(0).Rows(x)("Material_Cost")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Type")) Then
                        .Type = dsLine.Tables(0).Rows(x)("Type")
                    End If

                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Thickness")) Then
                        .Thickness = dsLine.Tables(0).Rows(x)("Thickness")
                    End If
                    .Power_Coat = dsLine.Tables(0).Rows(x)("Power_Coat")
                    .Wiring = dsLine.Tables(0).Rows(x)("Wiring")
                    .Accessory = dsLine.Tables(0).Rows(x)("Accessory")
                    .Copper = dsLine.Tables(0).Rows(x)("Copper")
                    .Comp_Markup = dsLine.Tables(0).Rows(x)("Comp_Markup")
                    .Concrete_Base = dsLine.Tables(0).Rows(x)("Concrete_Base")
                    .Transport = dsLine.Tables(0).Rows(x)("Transport")
                    .Enclosure = dsLine.Tables(0).Rows(x)("Enclosure")
                    .Qty = dsLine.Tables(0).Rows(x)("Qty")
                    .Cost = dsLine.Tables(0).Rows(x)("Cost")
                    .Overall_Markup = dsLine.Tables(0).Rows(x)("Overall_Markup")
                    .Total_Amount = dsLine.Tables(0).Rows(x)("Total_Amount")
                    .OC_EF = dsLine.Tables(0).Rows(x)("OC_EF")
                    .Incoming = dsLine.Tables(0).Rows(x)("Incoming")
                    .Panel_Transport = dsLine.Tables(0).Rows(x)("Panel_Transport")
                    .Installation = dsLine.Tables(0).Rows(x)("Installation")
                    .Type_Of_Enclosure = dsLine.Tables(0).Rows(x)("Type_Of_Enclosure")
                    .Quotation_Line_ID = Quotation_Line_ID
                    .UserID = UserID

                    If .UpdateQuotationLine() Then
                        Dim dsComp As DataSet
                        .Quotation_Line_ID = Old_Quotation_Line_ID
                        If .GetQuotationLineCompOnLineID(dsComp) Then
                            Dim i As Integer
                            For i = 0 To dsComp.Tables(0).Rows.Count - 1
                                .Quotation_ID = Quotation_ID
                                .Quotation_Line_ID = Quotation_Line_ID
                                .Category_ID = dsComp.Tables(0).Rows(i)("Category_ID")
                                .Product_ID = dsComp.Tables(0).Rows(i)("Product_ID")
                                .Supplier_ID = dsComp.Tables(0).Rows(i)("Supplier_ID")
                                .UnitPrice = dsComp.Tables(0).Rows(i)("UnitPrice")
                                .Lead_Time = dsComp.Tables(0).Rows(i)("Lead_Time")
                                .CompQty = dsComp.Tables(0).Rows(i)("Qty")
                                .UserID = UserID
                                If .SaveQuotationLineComponent() Then

                                End If
                            Next
                        End If
                        dsComp.Dispose()
                    End If
                Next
                dsLine.Dispose()
            End If
        End With
    End Sub
#End Region

#Region " Generate Order Confirmation No "
    Private Function GetOrderConfirmationNo(ByVal pCustInitial As String) As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("TOC")
        End With
        GetOrderConfirmationNo = Year(Now) & DocumentNo & pCustInitial
    End Function
#End Region


#Region " Set window value "
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        OCNoTxt.Text = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Quotation_NO")) Then
            QuoNoTxt.Text = dsLoad.Tables(0).Rows(0)("Quotation_NO")
        End If

        CustLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Customer_ID")
        StatusCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Status")
        ProjectCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("ProjectSub")
        ProjectTitleCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Project")
        QuoDate.DateTime = dsLoad.Tables(0).Rows(0)("QuotationDate")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PODate")) Then
            PODate.DateTime = dsLoad.Tables(0).Rows(0)("PODate")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_PO")) Then
            CustPOTxt.Text = dsLoad.Tables(0).Rows(0)("Customer_PO")
        End If

        LoadContactPerson(dsLoad.Tables(0).Rows(0)("Customer_ID"))
        ContLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Contact_ID")
        If dsLoad.Tables(0).Rows(0)("CP5_Flg") = 0 Then
            CP5Chk.Checked = False
        Else
            CP5Chk.Checked = True
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Percent_Discount")) Then
            If Not dsLoad.Tables(0).Rows(0)("Percent_Discount") = 0 Then
                RdBtn1.Checked = True
                PercentOffTxt.Text = Double.Parse(dsLoad.Tables(0).Rows(0)("Percent_Discount"))
                CashOfftxt.Properties.ReadOnly = True
                PercentOffLineTxt.Properties.ReadOnly = True
            Else
                PercentOffTxt.Properties.ReadOnly = True
            End If
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Cash_Discount")) Then
            If Not dsLoad.Tables(0).Rows(0)("Cash_Discount") = 0 Then
                Rdbtn2.Checked = True
                CashOfftxt.Text = Decimal.Round(dsLoad.Tables(0).Rows(0)("Cash_Discount"), 2)
                PercentOffLineTxt.Properties.ReadOnly = True
                PercentOffTxt.Properties.ReadOnly = True
            Else
                CashOfftxt.Properties.ReadOnly = True
            End If
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Total_Cost_Text")) Then
            TotalCostTexttxt.Text = dsLoad.Tables(0).Rows(0)("Total_Cost_Text")
        End If

        If Len(dsLoad.Tables(0).Rows(0)("Validity")) > 0 Then
            ValidityTxt.Text = dsLoad.Tables(0).Rows(0)("Validity")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
            PayDetailsMemo.Text = dsLoad.Tables(0).Rows(0)("Payment_Term")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
            DelTermsMemo.Text = dsLoad.Tables(0).Rows(0)("Delivery_Term")
        End If
        If Len(dsLoad.Tables(0).Rows(0)("Service_Type")) > 0 Then
            ServiceTypeCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Service_Type").ToString
        End If
        SignByCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Sign_By")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remarks")) Then
            NotesMemo.Text = dsLoad.Tables(0).Rows(0)("Remarks")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ClosingNotes")) Then
            ClosingTxt.Text = dsLoad.Tables(0).Rows(0)("ClosingNotes")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("OtherNotes")) Then
            OtherNotesMemo.Text = dsLoad.Tables(0).Rows(0)("OtherNotes")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PriceInclude_ID")) Then
            PriceTillCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("PriceInclude_ID")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("CollectMode")) Then
            CollectModeCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("CollectMode")
        End If
    End Sub
#End Region

#Region " Combo Box - Box Category n Price Till n Consultant n Project Title n Enclosure n Customer n Contact Person  "
    Private Sub LoadBoxCategory()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.BoxCategoryBusLogic
            If .GetBoxCategory(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(BoxCategoryCmb, "BoxCategory_Name", 400, 0, "c")
                        BoxCategoryCmb.Properties.LookUpData.KeyField = "BoxCategory_ID"
                        BoxCategoryCmb.Properties.LookUpData.DisplayField = "BoxCategory_Name"

                        BoxCategoryCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        BoxCategoryCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadPriceIncludeTill()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.PriceIncludeBusLogic
            If .GetPriceInclude(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(PriceTillCmb, "PriceInclude_Name", 400, 0, "c")
                        PriceTillCmb.Properties.LookUpData.KeyField = "PriceInclude_ID"
                        PriceTillCmb.Properties.LookUpData.DisplayField = "PriceInclude_Name"

                        PriceTillCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        PriceTillCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadProjectTitle()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ProjectBusLogic
            If .GetProject(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ProjectTitleCmb, "Project_Name", 400, 0, "c")
                        ProjectTitleCmb.Properties.LookUpData.KeyField = "Project_ID"
                        ProjectTitleCmb.Properties.LookUpData.DisplayField = "Project_Name"

                        ProjectTitleCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ProjectTitleCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadEnclosureType()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.EnclosureBusLogic
            If .GetEnclosureType(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(TypeEnclosureCmb, "Enclosure_Type", 400, 0, "c")
                        TypeEnclosureCmb.Properties.LookUpData.KeyField = "Enclosure_Id"
                        TypeEnclosureCmb.Properties.LookUpData.DisplayField = "Enclosure_Type"

                        TypeEnclosureCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        TypeEnclosureCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadCustomerDetails()
        Dim ds As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetCustomerDetails(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(CustLookup, "Name", 400, 0, "c")
                        CustLookup.Properties.LookUpData.KeyField = "Customer_ID"
                        CustLookup.Properties.LookUpData.DisplayField = "Name"

                        CustLookup.Properties.LookUpData.DataSource = ds.Tables(0)
                        CustLookup.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadContactPerson(ByVal pCustomer_ID)
        Dim dsContPerson As DataSet
        Dim dsAddress As DataSet

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetContactPerson(dsContPerson, pCustomer_ID) Then
                If Not dsContPerson Is Nothing Then
                    ContLookup.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(ContLookup, "Name", 400, 0, "c")
                    ContLookup.Properties.LookUpData.KeyField = "Contact_ID"
                    ContLookup.Properties.LookUpData.DisplayField = "Name"

                    ContLookup.Properties.LookUpData.DataSource = dsContPerson.Tables(0)
                    ContLookup.EditValue = "0"
                End If
            End If

            If .GetCustomerDetails(dsAddress, pCustomer_ID) Then
                If Not dsAddress Is Nothing Then
                    Addresstxt.Text = dsAddress.Tables(0).Rows(0)("Address").ToString
                End If
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region


#Region " Hardcoded Combo Box , Status, ProjectSub, Signby "
    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())
        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub LoadCombo()
        Dim StatusData As String() = New String() {"Preparing", "Pending", "Confirmed", "Revised", "Cancel", "Lost"}
        Dim StatusID As String() = New String() {"10", "20", "30", "40", "50", "60"}
        SetComboValue(StatusData, StatusCmb, StatusID)

        Dim ProjectData As String() = New String() {"RE:", "Project:"}
        Dim ProjectID As String() = New String() {"RE:", "Project:"}
        SetComboValue(ProjectData, ProjectCmb, ProjectID)

        Dim ServiceTypeData As String() = New String() {"Provide Box Only", "Provide Box and Installation"}
        Dim ServiceTypeID As String() = New String() {"1", "2"}
        SetComboValue(ServiceTypeData, ServiceTypeCmb, ServiceTypeID)

        Dim SignByData As String() = New String() {"Thomas Yeo", "Cheryl Lim"}
        Dim SignByID As String() = New String() {"Thomas Yeo", "Cheryl Lim"}
        SetComboValue(SignByData, SignByCmb, SignByID)

        Dim CollectModeData As String() = New String() {"", "Deliver", "Self-Collect"}
        Dim CollectModeID As String() = New String() {"", "Deliver", "Self-Collect"}
        SetComboValue(CollectModeData, CollectModeCmb, CollectModeID)

        Dim MaterialData As String() = New String() {"", "AL", "Steel"}
        Dim MaterialID As String() = New String() {"", "AL", "Steel"}
        SetComboValue(MaterialData, MaterialCmb, MaterialID)
    End Sub
#End Region

#Region " Navigation "
    Private Sub DisableNavBtn()
        Me.NavFirstBtn.Enabled = False
        Me.NavLastBtn.Enabled = False
        Me.NavNextBtn.Enabled = False
        Me.NavPrevBtn.Enabled = False
    End Sub

    Private Sub EnableNavBtn()
        Me.NavFirstBtn.Enabled = True
        Me.NavLastBtn.Enabled = True
        Me.NavNextBtn.Enabled = True
        Me.NavPrevBtn.Enabled = True
    End Sub

    Private Sub RefreshNavBtn()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Quotation_ID
            If .GetQuotationLine(NavdsBox) Then
                If Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    DisableNavBtn()
                    ItemNo = 0
                Else
                    EnableNavBtn()
                    If CurrentRow = 0 Then
                        Me.lblNavLocation.Text = ("1 of " _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    Else
                        Me.lblNavLocation.Text = (((CurrentRow).ToString + " of ") _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    End If
                End If

                GrandTotal = 0

                For i As Integer = 0 To NavdsBox.Tables(0).Rows.Count - 1
                    If Not IsDBNull(NavdsBox.Tables(0).Rows(i)("Total_Amount")) Then
                        If Not IsDBNull(NavdsBox.Tables(0).Rows(i)("LinePercent_Discount")) Then
                            If Not NavdsBox.Tables(0).Rows(i)("LinePercent_Discount") = 0 Then
                                Dim tmpTotal_Amount = NavdsBox.Tables(0).Rows(i)("Total_Amount")
                                Dim tmpDiscPercent = NavdsBox.Tables(0).Rows(i)("LinePercent_Discount")
                                Dim tmpDiscPrice = tmpTotal_Amount * (tmpDiscPercent / 100)
                                GrandTotal = GrandTotal + Decimal.Round((NavdsBox.Tables(0).Rows(i)("Total_Amount") - tmpDiscPrice), 2)
                            Else
                                GrandTotal = GrandTotal + NavdsBox.Tables(0).Rows(i)("Total_Amount")
                            End If
                        End If
                    End If

                    If Not IsDBNull(NavdsBox.Tables(0).Rows(i)("LinePercent_Discount")) Then
                        If Not NavdsBox.Tables(0).Rows(i)("LinePercent_Discount") = 0 Then
                            If RdBtn1.Checked = False And Rdbtn2.Checked = False Then
                                Rdbtn3.Checked = True
                            End If
                        End If
                    End If
                Next
                GrandTotalTxt.Text = Decimal.Round(GrandTotal, 2)
            End If
        End With
    End Sub

    Private Sub NavdsBox_PositionChanged()
        Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of ") _
                    + Me.NavdsBox.Tables(0).Rows.Count.ToString)
        Quotation_Line_ID = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Quotation_Line_ID")
        Me.BoxDescTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Box").ToString
        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")) Then
            Me.BoxCategoryCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")
        End If
        Me.ItemNoTxt.Text = CurrentRow + 1
        Me.PanelCostTxt.Text = Decimal.Round(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Cost"), 2)
        Me.OverallMarkTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Overall_Markup"))
        Me.QtyTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty").ToString
        Me.TotalAmtTxt.Text = Decimal.Round(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Total_Amount"), 2)
        Me.CompMarkTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Comp_Markup").ToString

        Me.HeightTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Height"))
        Me.WidthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Width"))
        Me.DepthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Depth"))
        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Raw_Material")) Then
            Me.MaterialCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Raw_Material")
        Else
            Me.MaterialCmb.Properties.LookUpData.KeyValue = Nothing
        End If
        Me.MatCostTxt.Text = Decimal.Round(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Material_Cost"), 2)

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Type")) Then
            Me.Typetxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Type").ToString
        End If

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Thickness")) Then
            Me.ThicknessTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Thickness"))
        End If

        Me.PowerCoatTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Power_Coat"))
        Me.WiringTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Wiring"))
        Me.AccessoryTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Accessory"))
        Me.CopperTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Copper"))
        Me.ConcreteBaseTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Concrete_Base"))
        Me.TransportTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Transport"))
        Me.EnclosureTxt.Text = Decimal.Round(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Enclosure"), 2)
        Me.OCEFTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("OC_EF"))
        Me.IncomingTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Incoming"))
        Me.PanelTransportTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Panel_Transport"))
        Me.InstallTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Installation"))

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("LinePercent_Discount")) Then
            If Not Me.NavdsBox.Tables(0).Rows(CurrentRow)("LinePercent_Discount") = 0 Then
                Me.PercentOffLineTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("LinePercent_Discount"))
            Else
                Me.PercentOffLineTxt.Text = 0
            End If
        End If

        Me.TypeEnclosureCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Type_Of_Enclosure")

        Dim DiscVal
        If RdBtn1.Checked Then
            Percent_Discount = PercentOffTxt.Text
            PercentOffLineTxt.Text = Percent_Discount
            DiscVal = TotalAmtTxt.Text * (Percent_Discount / 100)
            DiscPriceTxt.Text = Decimal.Round((TotalAmtTxt.Text - DiscVal), 2)
            LinePercent_Discount = PercentOffLineTxt.Text
        ElseIf Rdbtn2.Checked Then
            Dim DiscPercent
            Cash_Discount = CashOfftxt.Text
            DiscPercent = 1 - (Cash_Discount / TotalAmtTxt.Text)
            PercentOffLineTxt.Text = Double.Parse(DiscPercent)
            DiscVal = TotalAmtTxt.Text * (DiscPercent / 100)
            DiscPriceTxt.Text = Decimal.Round((TotalAmtTxt.Text - DiscVal), 2)
            LinePercent_Discount = PercentOffLineTxt.Text
        ElseIf Rdbtn3.Checked Then
            LinePercent_Discount = PercentOffLineTxt.Text
            DiscVal = TotalAmtTxt.Text * (LinePercent_Discount / 100)
            DiscPriceTxt.Text = Decimal.Round((TotalAmtTxt.Text - DiscVal), 2)
        ElseIf RdBtn4.Checked Then
            DiscPriceTxt.Text = TotalAmtTxt.Text
        End If
        RefreshComponentGrid()
    End Sub
    Private Sub NavFirstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavFirstBtn.Click
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            CurrentRow = 0
            Me.BindingContext(NavdsBox).Position = 0
            Me.NavdsBox_PositionChanged()
        End If
    End Sub

    Private Sub NavPrevBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavPrevBtn.Click
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            If CurrentRow > 0 Then CurrentRow = CurrentRow - 1
            Me.BindingContext(NavdsBox).Position = (Me.BindingContext(NavdsBox).Position - 1)
            Me.NavdsBox_PositionChanged()
        End If
    End Sub

    Private Sub NavNextBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavNextBtn.Click
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            If CurrentRow < Me.NavdsBox.Tables(0).Rows.Count - 1 Then
                CurrentRow = CurrentRow + 1
            End If
            Me.BindingContext(NavdsBox).Position = (Me.BindingContext(NavdsBox).Position + 1)
            Me.NavdsBox_PositionChanged()
        End If
    End Sub

    Private Sub NavLastBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavLastBtn.Click
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            CurrentRow = (Me.NavdsBox.Tables(0).Rows.Count - 1)
            Me.BindingContext(NavdsBox).Position = (Me.NavdsBox.Tables(0).Rows.Count - 1)
            Me.NavdsBox_PositionChanged()
        End If
    End Sub
#End Region

#Region " Component Grid Function & Double Click Event & Mouse Right Click "
    Public Sub RefreshComponentGrid()
        Dim ds As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_Line_ID = Quotation_Line_ID
            If .GetQuotationLineCompOnLineID(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim TotalCost As Double
                CompTotal = 0

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    TotalCost = oRow("UnitPrice") * oRow("Qty")
                    CompTotal = CompTotal + TotalCost
                    data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand"), oRow("Description"), oRow("Lead_Time"), oRow("Qty")})
                Next
                CompGrid1.DataSource = data
                CompGrid1.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column
                CompCostTxt.Text = Decimal.Round(CompTotal, 2)
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "QID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Id", System.Type.GetType("System.String"), True)
        AddColumn(data, "Brand/Model", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        AddColumn(data, "Lead Time", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        RefreshComponentGrid()
    End Sub


    Private Sub CompGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CompGrid1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Component_ID As Integer = dr(1)
            Dim Component_Name As String = dr(2)

            Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Component_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                DeleteQuotationLineComponent(Component_ID)
            End If
        End If
    End Sub

    Private Sub DeleteQuotationLineComponent(ByVal pComponent_ID As Integer)
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Component_ID = pComponent_ID
            If .DeleteQuotationLineComponent Then
                RefreshComponentGrid()
                MessageBox.Show("Component Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub CompGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompGrid1.DoubleClick
        Dim NewForm As New SelectProductForm
        NewForm.Quotation_Line_ID = Quotation_Line_ID
        NewForm.Quotation_ID = Quotation_ID
        NewForm.Status = "ADD"
        NewForm.ShowDialog(Me)
        RefreshComponentGrid()
    End Sub

    Private Sub CompGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CompGrid1.MouseUp
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

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        Dim Row As Integer = GridView1.GetSelectedRows(0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(Row)
        Dim Component_ID As Integer = dr(1)

        Dim NewForm As New SelectProductForm
        NewForm.Component_ID = Component_ID
        NewForm.Status = "EDIT"
        NewForm.ShowDialog(Me)
        RefreshComponentGrid()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim Row As Integer = GridView1.GetSelectedRows(0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(Row)
        Dim Component_ID As Integer = dr(1)
        Dim Component_Name As String = dr(2)

        Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Component_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            DeleteQuotationLineComponent(Component_ID)
        End If
    End Sub
#End Region


#Region " Event - Code for combo box on close up "
    Private Sub CustLookup_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles CustLookup.CloseUp
        Dim dsContPerson As DataSet
        Dim dsAddress As DataSet

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If Len(e.Value) > 0 Then
                If .GetContactPerson(dsContPerson, e.Value.ToString) Then
                    If Not dsContPerson Is Nothing Then
                        ContLookup.Properties.LookUpData.ListFields.Clear()
                        AddListFieldInfoToLookUp(ContLookup, "Name", 400, 0, "c")
                        ContLookup.Properties.LookUpData.KeyField = "Contact_ID"
                        ContLookup.Properties.LookUpData.DisplayField = "Name"

                        ContLookup.Properties.LookUpData.DataSource = dsContPerson.Tables(0)
                        ContLookup.EditValue = "0"
                    End If
                End If

                If .GetCustomerDetails(dsAddress, e.Value.ToString) Then
                    If Not dsAddress Is Nothing Then
                        Addresstxt.Text = dsAddress.Tables(0).Rows(0)("Address").ToString
                    End If
                End If
            End If
        End With
    End Sub
#End Region

#Region " Event Buttons - Component, Box "
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ResetQuotationLine()
        ItemNo = ItemNo + 1
        ItemNoTxt.Text = ItemNo
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Quotation_ID
            .ItemNo = ItemNo
            .UserID = UserID
            If .SaveQuotationLineFirstTime() Then
                Quotation_Line_ID = .Quotation_Line_ID
                CompGrid1.Enabled = True
                SaveQuoBtn.Enabled = True
                RefreshNavBtn()
                EnableButtons()
                AddBtn.Enabled = False
                NavFirstBtn.Enabled = False
                NavNextBtn.Enabled = False
                NavLastBtn.Enabled = False
                NavPrevBtn.Enabled = False
                UpdateAllBtn.Enabled = False
            End If
        End With
        EditFlag = True
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        RetrieveFromLineForm()
        SaveQuotationLineProcess()
        RefreshNavBtn()
        AddBtn.Enabled = True
        NavFirstBtn.Enabled = True
        NavNextBtn.Enabled = True
        NavLastBtn.Enabled = True
        NavPrevBtn.Enabled = True
        EditFlag = False
    End Sub

    Private Sub DelProdBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelProdBtn.Click
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            'MessageBox.Show(Quotation_Line_ID)
            Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    .Quotation_Line_ID = Quotation_Line_ID
                    If .DeleteQuotationLine() Then
                        MessageBox.Show("Box Deleted.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
                RefreshNavBtn()
                CurrentRow = 0

                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                Else
                    ResetQuotationLine()
                    RefreshComponentGrid()
                End If
            End If
        End If
    End Sub

    Private Sub EnableButtons()
        DelProdBtn.Enabled = True
        TabControl1.Enabled = True
        'EditCompBtn.Enabled = True
        'DelCompBtn.Enabled = True
        UpdateBtn.Enabled = True
    End Sub

    Private Sub ResetQuotationLine()
        '** Box Tab **
        BoxDescTxt.Text = ""
        PanelCostTxt.Text = ""
        OverallMarkTxt.Text = ""
        CompMarkTxt.Text = ""
        QtyTxt.Text = ""
        TotalAmtTxt.Text = ""
        PercentOffLineTxt.Text = ""
        DiscPriceTxt.Text = ""
        '****

        '** Enclosure Tab **
        HeightTxt.Text = ""
        WidthTxt.Text = ""
        DepthTxt.Text = ""
        MaterialCmb.Properties.LookUpData.KeyValue = Nothing
        PowerCoatTxt.Text = ""
        MatCostTxt.Text = ""
        Typetxt.Text = ""
        ThicknessTxt.Text = ""
        EnclosureTxt.Text = ""
        TypeEnclosureCmb.Properties.LookUpData.KeyValue = Nothing
        '****

        '** Others Tab **
        WiringTxt.Text = ""
        AccessoryTxt.Text = ""
        CopperTxt.Text = ""
        ConcreteBaseTxt.Text = ""
        TransportTxt.Text = ""
        OCEFTxt.Text = ""
        IncomingTxt.Text = ""
        PanelTransportTxt.Text = ""
        InstallTxt.Text = ""
        '****

        Quotation_Line_ID = 0
        RefreshComponentGrid()
    End Sub

    Private Sub UpdateAllBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAllBtn.Click
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To NavdsBox.Tables(0).Rows.Count - 1
                Total_Amount = NavdsBox.Tables(0).Rows(i)("Total_Amount")
                Quotation_Line_ID = NavdsBox.Tables(0).Rows(i)("Quotation_Line_ID")
                '** Calculate discount value
                Dim DiscVal

                If RdBtn1.Checked Then
                    Percent_Discount = PercentOffTxt.Text
                    PercentOffLineTxt.Text = Percent_Discount
                    DiscVal = Total_Amount * (Percent_Discount / 100)
                    DiscPrice = Total_Amount - DiscVal
                    LinePercent_Discount = Percent_Discount
                    If i = CurrentRow Then
                        DiscPriceTxt.Text = Decimal.Round((Total_Amount - DiscVal), 2)
                    End If
                ElseIf Rdbtn2.Checked Then
                    Dim DiscPercent
                    Cash_Discount = CashOfftxt.Text
                    DiscPercent = 1 - (Cash_Discount / Total_Amount)
                    PercentOffLineTxt.Text = Double.Parse(DiscPercent)
                    DiscVal = Total_Amount * (DiscPercent / 100)
                    If i = CurrentRow Then
                        DiscPriceTxt.Text = Decimal.Round((Total_Amount - DiscVal), 2)
                    End If
                    DiscPrice = Decimal.Round((Total_Amount - DiscVal), 2)
                    LinePercent_Discount = DiscPercent
                ElseIf RdBtn4.Checked Then
                    LinePercent_Discount = 0
                End If
                '***

                With New BusinessRules.SaleBusRules.SaleBusLogic
                    .Quotation_Line_ID = Quotation_Line_ID
                    .LinePercent_Discount = LinePercent_Discount
                    .UserID = UserID
                    If .UpdateDiscountValue() Then

                    End If
                End With
            Next
            MessageBox.Show("All pricing updated", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.RefreshNavBtn()
        End If
    End Sub
#End Region

#Region " Event Radio Button "
    Private Sub RdBtn4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtn4.CheckedChanged
        If RdBtn4.Checked Then
            PercentOffTxt.Text = ""
            PercentOffTxt.Properties.ReadOnly = True
            CashOfftxt.Text = ""
            CashOfftxt.Properties.ReadOnly = True
            PercentOffLineTxt.Text = ""
            PercentOffLineTxt.Properties.ReadOnly = True
            'UpdateAllBtn.Enabled = False
        End If
    End Sub

    Private Sub Rdbtn3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdbtn3.CheckedChanged
        If Rdbtn3.Checked Then
            PercentOffTxt.Text = ""
            PercentOffTxt.Properties.ReadOnly = True
            CashOfftxt.Text = ""
            CashOfftxt.Properties.ReadOnly = True
            PercentOffLineTxt.Properties.ReadOnly = False
            UpdateAllBtn.Enabled = False
        ElseIf RdBtn4.Checked Then
            UpdateAllBtn.Enabled = True
        End If
    End Sub

    Private Sub Rdbtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdbtn2.CheckedChanged
        If Rdbtn2.Checked Then
            CashOfftxt.Properties.ReadOnly = False
            PercentOffTxt.Text = ""
            PercentOffTxt.Properties.ReadOnly = True
            PercentOffLineTxt.Text = ""
            PercentOffLineTxt.Properties.ReadOnly = True
            UpdateAllBtn.Enabled = True
        ElseIf RdBtn4.Checked Then
            UpdateAllBtn.Enabled = True
        End If
    End Sub

    Private Sub RdBtn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtn1.CheckedChanged
        If RdBtn1.Checked Then
            PercentOffTxt.Properties.ReadOnly = False
            CashOfftxt.Text = ""
            CashOfftxt.Properties.ReadOnly = True
            PercentOffLineTxt.Text = ""
            PercentOffLineTxt.Properties.ReadOnly = True
            UpdateAllBtn.Enabled = True
        ElseIf RdBtn4.Checked Then
            UpdateAllBtn.Enabled = True
        End If
    End Sub
#End Region


#Region " Save, Del, Retrieve from form function for Quotation Line."
    Private Sub RetrieveFromLineForm()
        '** Box Tab **
        ItemNo = ItemNoTxt.Text
        Box = BoxDescTxt.Text
        BoxCategory_ID = BoxCategoryCmb.Properties.LookUpData.KeyValue
        Overall_Markup = OverallMarkTxt.Text
        Qty = QtyTxt.Text
        Comp_Markup = CompMarkTxt.Text
        '****

        '** Enclosure Tab **
        varHeight = HeightTxt.Text
        varWidth = WidthTxt.Text
        Depth = DepthTxt.Text
        Raw_Material = MaterialCmb.Properties.LookUpData.KeyValue
        Material_Cost = MatCostTxt.Text
        Type = Typetxt.Text
        Thickness = ThicknessTxt.Text
        Power_Coat = PowerCoatTxt.Text
        Enclosure = EnclosureTxt.Text
        Type_Of_Enclosure = TypeEnclosureCmb.Properties.LookUpData.KeyValue
        '****

        '** Calculate M/M
        Dim MM As Double = Material_Cost / 2.8

        '** Convert mm to metre
        Dim Hm = varHeight / 1000
        Dim Wm = varWidth / 1000
        Dim Dm = Depth / 1000

        '** Calculate Surface Area
        Dim SA
        SA = ((Hm * Wm) + (Wm * Dm) + (Dm * Hm)) * 2

        '** Calculate Surface Area Material Cost
        Dim SAMC
        SAMC = MM * SA

        '** Calculate Labour Cost
        Dim LC
        LC = 1.5 * SAMC

        '** Calculate Power Coat Cost
        Dim PC
        PC = Power_Coat * (2 * SA)

        '** Calculate Accessories Cost
        Dim Acc
        Acc = 0.5 * SAMC

        '** Get All 4 cost Total
        Dim CCost
        CCost = SAMC + LC + PC + Acc

        '** Get Markup Factor %
        Dim MUFactor As Double
        With New BusinessRules.SystemBusRules.EnclosureBusLogic
            If .GetMarkupFactor(Type_Of_Enclosure) Then
                MUFactor = .Markup_Factor
            End If
        End With

        '** Calculate Total Markup 
        Dim totalMarkupPercent = (100 + MUFactor) / 100
        Enclosure = Decimal.Round((totalMarkupPercent * CCost), 2)

        EnclosureTxt.Text = Enclosure
        '***

        'GrandTotal = GrandTotal + Enclosure

        '** Calculate Comp after Markup
        Comp_Markup = CompMarkTxt.Text
        If Comp_Markup <> 0 Then
            Dim tmp = (100 + Comp_Markup) / 100
            Dim CompMarkupTotal = Decimal.Round((CompTotal * tmp), 2)

            '** Component Cost
            CompCostTxt.Text = CompMarkupTotal
        Else
            CompCostTxt.Text = CompTotal
        End If

        '** Calculate Total Panel Cost
        Cost = CompTotal + Enclosure
        PanelCostTxt.Text = Cost

        '** Calculate Total Amount
        Total_Amount = Qty * Cost

        '** Calculate Overall Markup
        Overall_Markup = OverallMarkTxt.Text

        If Overall_Markup <> 0 Then
            Dim tmpTotal = (100 + Overall_Markup) / 100
            Total_Amount = Decimal.Round((Total_Amount * tmpTotal), 2)
        End If

        '** After Markup value on total amt
        TotalAmtTxt.Text = Total_Amount

        '** Calculate discount value
        Dim TotalDiscVal

        If RdBtn1.Checked Then
            Percent_Discount = PercentOffTxt.Text
            PercentOffLineTxt.Text = Percent_Discount
            TotalDiscVal = (100 - Percent_Discount) / 100
            DiscPriceTxt.Text = Decimal.Round((Total_Amount * TotalDiscVal), 2)
            LinePercent_Discount = PercentOffLineTxt.Text
        ElseIf Rdbtn2.Checked Then
            Dim DiscPercent
            Cash_Discount = CashOfftxt.Text
            DiscPercent = 1 - (Cash_Discount / Total_Amount)
            PercentOffLineTxt.Text = Double.Parse(DiscPercent)
            TotalDiscVal = (100 - DiscPercent) / 100
            DiscPriceTxt.Text = Decimal.Round((Total_Amount * TotalDiscVal), 2)
            LinePercent_Discount = PercentOffLineTxt.Text
        ElseIf Rdbtn3.Checked Then
            LinePercent_Discount = PercentOffLineTxt.Text
            TotalDiscVal = (100 - LinePercent_Discount) / 100
            DiscPriceTxt.Text = Decimal.Round((Total_Amount * TotalDiscVal), 2)
        End If

        DiscPrice = DiscPriceTxt.Text
        '***

        GrandTotal = GrandTotal + DiscPrice

        '** Others Tab **
        Wiring = WiringTxt.Text
        GrandTotal = GrandTotal + Wiring

        Accessory = AccessoryTxt.Text
        GrandTotal = GrandTotal + Accessory

        Copper = CopperTxt.Text
        GrandTotal = GrandTotal + Copper

        Concrete_Base = ConcreteBaseTxt.Text
        GrandTotal = GrandTotal + Concrete_Base

        Transport = TransportTxt.Text
        GrandTotal = GrandTotal + Transport

        OC_EF = OCEFTxt.Text
        GrandTotal = GrandTotal + OC_EF

        Incoming = IncomingTxt.Text
        GrandTotal = GrandTotal + Incoming

        Panel_Transport = PanelTransportTxt.Text
        GrandTotal = GrandTotal + Panel_Transport

        Installation = InstallTxt.Text
        GrandTotal = GrandTotal + Installation

        GrandTotalTxt.Text = GrandTotal
        '****
    End Sub

    Private Sub SaveQuotationLineProcess()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If ValidDataForLine() Then
                .Quotation_Line_ID = Quotation_Line_ID
                .ItemNo = ItemNo
                .Box = Box
                .varHeight = varHeight
                .varWidth = varWidth
                .Depth = Depth
                .Raw_Material = Raw_Material
                .Material_Cost = Material_Cost
                .Type = Type
                .Thickness = Thickness
                .Power_Coat = Power_Coat
                .Wiring = Wiring
                .Accessory = Accessory
                .Copper = Copper
                .Comp_Markup = Comp_Markup
                .Concrete_Base = Concrete_Base
                .Transport = Transport
                .Enclosure = Enclosure
                .Qty = Qty
                .Cost = Cost
                .Overall_Markup = Overall_Markup
                .Total_Amount = Total_Amount
                .OC_EF = OC_EF
                .Incoming = Incoming
                .Panel_Transport = Panel_Transport
                .Installation = Installation
                .LinePercent_Discount = LinePercent_Discount
                .Type_Of_Enclosure = Type_Of_Enclosure
                .BoxCategory_ID = BoxCategory_ID

                .UserID = UserID
                If .UpdateQuotationLine() Then
                    Quotation_Line_ID = .Quotation_Line_ID
                    MessageBox.Show("Data saved. ", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub

    Private Function ValidDataForLine()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(Box) > 0 Then
            DataOK_Flag = False
            FieldName = "Box" & Chr(13)
        End If

        If Not Len(BoxCategory_ID) > 0 Or BoxCategory_ID = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Box Category" & Chr(13)
        End If

        If Qty = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Qty" & Chr(13)
        End If

        If varHeight = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Height" & Chr(13)
        End If

        If varWidth = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Width" & Chr(13)
        End If

        If Depth = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Depth" & Chr(13)
        End If

        If Material_Cost = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Material Cost" & Chr(13)
        End If

        If Power_Coat = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Power Coat" & Chr(13)
        End If

        If Not Len(Type_Of_Enclosure) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Type Of Enclosure" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidDataForLine = DataOK_Flag
    End Function
#End Region

#Region " Main Quotation Saving Btn, Close, Save Function, Retrieve from form "
    Private Sub SaveQuoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveQuoBtn.Click
        RetrieveFromMainForm()
        SaveMainFormProcess()
    End Sub

    Private Sub RetrieveFromMainForm()
        Customer_ID = CustLookup.Properties.LookUpData.KeyValue
        Contact_ID = ContLookup.Properties.LookUpData.KeyValue
        QuotationDate = QuoDate.Text
        Status = StatusCmb.Properties.LookUpData.KeyValue
        Project = ProjectTitleCmb.Properties.LookUpData.KeyValue
        ProjectSub = ProjectCmb.Properties.LookUpData.KeyValue
        If CP5Chk.Checked = True Then
            CP5_Flg = "1"
        Else
            CP5_Flg = "0"
        End If
        Customer_PO = CustPOTxt.Text
        PO_Date = PODate.Text

        Percent_Discount = PercentOffTxt.Text
        Cash_Discount = CashOfftxt.Text

        '** Payment **
        If Len(ValidityTxt.Text) > 0 Then
            Validity = ValidityTxt.Text
        End If

        If Len(PayDetailsMemo.Text) > 0 Then
            Payment_Term = PayDetailsMemo.Text
        End If

        If Len(DelTermsMemo.Text) > 0 Then
            Delivery_Term = DelTermsMemo.Text
        End If
        Service_Type = ServiceTypeCmb.Properties.LookUpData.KeyValue
        Sign_By = SignByCmb.Properties.LookUpData.KeyValue
        Total_Cost_Numeric = GrandTotalTxt.Text

        CollectMode = CollectModeCmb.Properties.LookUpData.KeyValue
        If Len(NotesMemo.Text) > 0 Then
            Remarks = NotesMemo.Text
        End If

        If Len(ClosingTxt.Text) > 0 Then
            ClosingNotes = ClosingTxt.Text
        End If

        If Len(OtherNotesMemo.Text) > 0 Then
            OtherNotes = OtherNotesMemo.Text
        End If

        PriceInclude_ID = PriceTillCmb.Properties.LookUpData.KeyValue
        Total_Cost_Text = TotalCostTexttxt.Text

        RefQuotationID = RefQuotationID
        'PriceTillCmb
    End Sub

    Private Sub SaveMainFormProcess()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If ValidDataHeader() Then
                .Quotation_ID = Quotation_ID
                .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(QuotationDate) & "/" & Month(QuotationDate) & "/" & Year(QuotationDate)
                .Status = Status
                .ProjectSub = ProjectSub
                .Project = Project
                .Customer_ID = Customer_ID
                .Contact_ID = Contact_ID
                .Percent_Discount = Percent_Discount
                .Cash_Discount = Cash_Discount
                .Customer_PO = Customer_PO
                .PODate = Microsoft.VisualBasic.DateAndTime.Day(PO_Date) & "/" & Month(PO_Date) & "/" & Year(PO_Date)

                .Payment_Term = Payment_Term
                .Validity = Validity
                .Delivery_Term = Delivery_Term
                .Service_Type = Service_Type
                .CP5_Flg = CP5_Flg
                .Sign_By = Sign_By
                .Remarks = Remarks
                .ClosingNotes = ClosingNotes
                .OtherNotes = OtherNotes
                .CollectMode = CollectMode
                .PriceInclude_ID = PriceInclude_ID
                .UserID = UserID
                .RefQuotationID = RefQuotationID
                .Total_Cost_Numeric = Total_Cost_Numeric
                If .UpdateQuotationHeader() Then
                    MessageBox.Show("Order Confirmation Saved.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub

    Private Function ValidDataHeader()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(QuotationDate) > 0 Then
            DataOK_Flag = False
            FieldName = "Date" & Chr(13)
        End If

        If Not Len(Customer_ID) > 0 Then
            DataOK_Flag = False
            FieldName = "Customer Name" & Chr(13)
        End If

        If Not Len(Contact_ID) > 0 Then
            DataOK_Flag = False
            FieldName = "Contact Person" & Chr(13)
        End If

        If Not Len(Project) > 0 Then
            DataOK_Flag = False
            FieldName = "Project" & Chr(13)
        End If

        'If Not Len(PO_Date) > 0 Then
        'DataOK_Flag = False
        'FieldName = "PO Date" & Chr(13)
        'End If

        'If Not Len(Customer_PO) > 0 Then
        'DataOK_Flag = False
        'FieldName = "Customer PO" & Chr(13)
        'End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidDataHeader = DataOK_Flag
    End Function

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        If EditFlag = True Then
            MessageBox.Show("Please Update the changes first.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this order confirmation?", "Quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim a As MainForm = Me.ParentForm
                If (a.MainTabControl.TabPages.Count > 0) Then
                    If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                        a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DispatchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchBtn.Click
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Quotation_ID
            .Status = "20"      'Pending status
            If .UpdateQuotationHeaderStatus() Then
                MessageBox.Show("Status updated.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                StatusCmb.Properties.LookUpData.KeyValue = "20"
            End If
        End With
    End Sub
#End Region

#Region " Key up Event "
    Private Sub BoxDescTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BoxDescTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub QtyTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QtyTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub OverallMarkTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OverallMarkTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub CompMarkTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CompMarkTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub PercentOffLineTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PercentOffLineTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub HeightTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HeightTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub WidthTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WidthTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub DepthTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DepthTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub MaterialCmb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaterialCmb.KeyUp
        EditFlag = True
    End Sub

    Private Sub PowerCoatTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PowerCoatTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub MatCostTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MatCostTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub Typetxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Typetxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub TypeEnclosureCmb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TypeEnclosureCmb.KeyUp
        EditFlag = True
    End Sub

    Private Sub WiringTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WiringTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub AccessoryTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AccessoryTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub CopperTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CopperTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub ConcreteBaseTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ConcreteBaseTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub TransportTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TransportTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub OCEFTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OCEFTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub IncomingTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IncomingTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub PanelTransportTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PanelTransportTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub InstallTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InstallTxt.KeyUp
        EditFlag = True
    End Sub

    Private Sub BoxCategoryCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles BoxCategoryCmb.CloseUp
        EditFlag = True
    End Sub
#End Region

End Class
