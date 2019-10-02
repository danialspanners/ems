Imports System.Data
Imports Crownwood.Magic.Common
Imports Crownwood.Magic.Controls
Imports DevExpress.XtraEditors.Controls

Public Class QuotationForm
    Inherits System.Windows.Forms.Form

#Region " QuotationHeader's variable"
    '** QuotationHeader **
    Public Quotation_ID As Integer
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
    Public Consultant_ID As Integer
    Public PriceInclude_ID As Integer
    '****
#End Region

#Region " QuotationLine variable"
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
    '****
#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    Public NavdsBox As DataSet              'FOR NAV
    Dim CurrentRow As Integer               'FOR NAVIGATION
    Public CompTotal As Double
    Public GrandTotal As Double
    Public FormStatus As String             'TO DIFFERENTIATE BETWEEN ADD,EDIT..
    Public Old_Quotation_ID As Integer      'FOR REJOIN QUOTATION
    Public EditFlag As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pOld_Quotation_ID As Integer = 0, _
                    Optional ByVal pQuotation_ID As Integer = 0)
        MyBase.New()
        FormStatus = pStatus
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
    Friend WithEvents Component As Crownwood.Magic.Controls.TabPage
    Friend WithEvents SaveQuoBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DispatchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Edit As System.Windows.Forms.MenuItem
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
    Friend WithEvents CompMarkTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CopyFmBxCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
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
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Typetxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ThicknessTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MaterialCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EnclosureTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MatCostTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PowerCoatTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DepthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WidthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HeightTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CostLbl As System.Windows.Forms.Label
    Friend WithEvents DepthLbl As System.Windows.Forms.Label
    Friend WithEvents WidthLbl As System.Windows.Forms.Label
    Friend WithEvents OthersTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents OCEFlbl As System.Windows.Forms.Label
    Friend WithEvents InstallTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PanelTransportTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IncomingTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OCEFTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CopperTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TransportTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AccessoryTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ConcreteBaseTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WiringTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RefQuoNoTxt As System.Windows.Forms.Label
    Friend WithEvents Addresstxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents QuoNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProjectCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents StatusCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ContLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CP5Chk As System.Windows.Forms.CheckBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents CP5Lbl As System.Windows.Forms.Label
    Friend WithEvents ProjectLbl As System.Windows.Forms.Label
    Friend WithEvents AddressLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusLbl As System.Windows.Forms.Label
    Friend WithEvents DateLbl As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents QuoNoLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GrandTotalTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TabControl3 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents TabControl1 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents DetailsTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents PaymentTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ProjectTitleCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ConsultantCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BoxCategoryCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpecialBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.Component = New Crownwood.Magic.Controls.TabPage
        Me.SaveQuoBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DispatchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Edit = New System.Windows.Forms.MenuItem
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.TabControl3 = New Crownwood.Magic.Controls.TabControl
        Me.DetailsTab = New Crownwood.Magic.Controls.TabPage
        Me.GrandTotalTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label40 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
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
        Me.CompMarkTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.CopyFmBxCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label17 = New System.Windows.Forms.Label
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
        Me.Label21 = New System.Windows.Forms.Label
        Me.Typetxt = New DevExpress.XtraEditors.TextEdit
        Me.ThicknessTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.MaterialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.EnclosureTxt = New DevExpress.XtraEditors.SpinEdit
        Me.MatCostTxt = New DevExpress.XtraEditors.SpinEdit
        Me.PowerCoatTxt = New DevExpress.XtraEditors.SpinEdit
        Me.DepthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WidthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.HeightTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.CostLbl = New System.Windows.Forms.Label
        Me.DepthLbl = New System.Windows.Forms.Label
        Me.WidthLbl = New System.Windows.Forms.Label
        Me.OthersTab = New Crownwood.Magic.Controls.TabPage
        Me.OCEFlbl = New System.Windows.Forms.Label
        Me.InstallTxt = New DevExpress.XtraEditors.SpinEdit
        Me.PanelTransportTxt = New DevExpress.XtraEditors.SpinEdit
        Me.IncomingTxt = New DevExpress.XtraEditors.SpinEdit
        Me.OCEFTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CopperTxt = New DevExpress.XtraEditors.SpinEdit
        Me.TransportTxt = New DevExpress.XtraEditors.SpinEdit
        Me.AccessoryTxt = New DevExpress.XtraEditors.SpinEdit
        Me.ConcreteBaseTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WiringTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ConsultantCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.ProjectTitleCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.RefQuoNoTxt = New System.Windows.Forms.Label
        Me.Addresstxt = New DevExpress.XtraEditors.TextEdit
        Me.QuoDate = New DevExpress.XtraEditors.DateEdit
        Me.QuoNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.ProjectCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.StatusCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ContLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.CustLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.CP5Chk = New System.Windows.Forms.CheckBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.CP5Lbl = New System.Windows.Forms.Label
        Me.ProjectLbl = New System.Windows.Forms.Label
        Me.AddressLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.StatusLbl = New System.Windows.Forms.Label
        Me.DateLbl = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.QuoNoLbl = New System.Windows.Forms.Label
        Me.PaymentTab = New Crownwood.Magic.Controls.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
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
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.SpecialBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.TabControl3.SuspendLayout()
        Me.DetailsTab.SuspendLayout()
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
        CType(Me.ConsultantCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentTab.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'Component
        '
        Me.Component.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Component.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Component.Location = New System.Drawing.Point(0, 25)
        Me.Component.Name = "Component"
        Me.Component.Selected = False
        Me.Component.Size = New System.Drawing.Size(312, 159)
        Me.Component.TabIndex = 3
        '
        'SaveQuoBtn
        '
        Me.SaveQuoBtn.AutoSize = False
        Me.SaveQuoBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveQuoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveQuoBtn.Image = Nothing
        Me.SaveQuoBtn.Location = New System.Drawing.Point(8, 512)
        Me.SaveQuoBtn.Name = "SaveQuoBtn"
        Me.SaveQuoBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveQuoBtn.TabIndex = 15
        Me.SaveQuoBtn.Text = "Save"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(224, 512)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 16
        Me.CloseBtn.Text = "&Close"
        '
        'DispatchBtn
        '
        Me.DispatchBtn.AutoSize = False
        Me.DispatchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DispatchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DispatchBtn.Image = Nothing
        Me.DispatchBtn.Location = New System.Drawing.Point(80, 512)
        Me.DispatchBtn.Name = "DispatchBtn"
        Me.DispatchBtn.Size = New System.Drawing.Size(64, 32)
        Me.DispatchBtn.TabIndex = 17
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
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.SelectedTab = Me.DetailsTab
        Me.TabControl3.Size = New System.Drawing.Size(616, 488)
        Me.TabControl3.TabIndex = 18
        Me.TabControl3.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.DetailsTab, Me.PaymentTab})
        '
        'DetailsTab
        '
        Me.DetailsTab.Controls.Add(Me.GrandTotalTxt)
        Me.DetailsTab.Controls.Add(Me.Label40)
        Me.DetailsTab.Controls.Add(Me.GroupBox2)
        Me.DetailsTab.Controls.Add(Me.GroupBox1)
        Me.DetailsTab.Location = New System.Drawing.Point(0, 0)
        Me.DetailsTab.Name = "DetailsTab"
        Me.DetailsTab.Size = New System.Drawing.Size(616, 463)
        Me.DetailsTab.TabIndex = 3
        Me.DetailsTab.Title = "Quotation Details"
        '
        'GrandTotalTxt
        '
        Me.GrandTotalTxt.Enabled = False
        Me.GrandTotalTxt.Location = New System.Drawing.Point(512, 432)
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
        Me.Label40.Location = New System.Drawing.Point(424, 438)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(80, 16)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "Grand Total :"
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 300)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'CompGrid1
        '
        Me.CompGrid1.EditorsRepository = Me.PersistentRepository2
        Me.CompGrid1.Enabled = False
        Me.CompGrid1.Location = New System.Drawing.Point(8, 158)
        Me.CompGrid1.MainView = Me.GridView1
        Me.CompGrid1.Name = "CompGrid1"
        Me.CompGrid1.Size = New System.Drawing.Size(584, 112)
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
        Me.CompCostTxt.Location = New System.Drawing.Point(504, 274)
        Me.CompCostTxt.Name = "CompCostTxt"
        Me.CompCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompCostTxt.Properties.ReadOnly = True
        Me.CompCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CompCostTxt.Size = New System.Drawing.Size(88, 19)
        Me.CompCostTxt.TabIndex = 81
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(328, 276)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 16)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Total Comp. Cost after Markup :"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.Location = New System.Drawing.Point(344, 10)
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
        Me.NavLastBtn.Location = New System.Drawing.Point(440, 10)
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
        Me.NavFirstBtn.Location = New System.Drawing.Point(288, 10)
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
        Me.NavNextBtn.Location = New System.Drawing.Point(416, 10)
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
        Me.NavPrevBtn.Location = New System.Drawing.Point(320, 10)
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
        Me.TabControl1.Size = New System.Drawing.Size(584, 112)
        Me.TabControl1.TabIndex = 28
        Me.TabControl1.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.ItemTab, Me.EnclosureTab, Me.OthersTab})
        '
        'ItemTab
        '
        Me.ItemTab.Controls.Add(Me.BoxCategoryCmb)
        Me.ItemTab.Controls.Add(Me.CompMarkTxt)
        Me.ItemTab.Controls.Add(Me.Label12)
        Me.ItemTab.Controls.Add(Me.CopyFmBxCmb)
        Me.ItemTab.Controls.Add(Me.Label17)
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
        Me.ItemTab.Size = New System.Drawing.Size(584, 87)
        Me.ItemTab.TabIndex = 3
        Me.ItemTab.Title = "Box"
        '
        'BoxCategoryCmb
        '
        Me.BoxCategoryCmb.Location = New System.Drawing.Point(176, 8)
        Me.BoxCategoryCmb.Name = "BoxCategoryCmb"
        Me.BoxCategoryCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxCategoryCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.BoxCategoryCmb.Properties.NullString = ""
        Me.BoxCategoryCmb.Size = New System.Drawing.Size(112, 19)
        Me.BoxCategoryCmb.TabIndex = 83
        '
        'CompMarkTxt
        '
        Me.CompMarkTxt.Location = New System.Drawing.Point(512, 56)
        Me.CompMarkTxt.Name = "CompMarkTxt"
        Me.CompMarkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompMarkTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CompMarkTxt.Size = New System.Drawing.Size(56, 19)
        Me.CompMarkTxt.TabIndex = 82
        Me.CompMarkTxt.Text = "0"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(416, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Comp Markup % :"
        '
        'CopyFmBxCmb
        '
        Me.CopyFmBxCmb.Enabled = False
        Me.CopyFmBxCmb.Location = New System.Drawing.Point(120, 56)
        Me.CopyFmBxCmb.Name = "CopyFmBxCmb"
        Me.CopyFmBxCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CopyFmBxCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CopyFmBxCmb.Properties.Enabled = False
        Me.CopyFmBxCmb.Properties.NullString = ""
        Me.CopyFmBxCmb.Size = New System.Drawing.Size(96, 19)
        Me.CopyFmBxCmb.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Copy from box :"
        '
        'TotalAmtTxt
        '
        Me.TotalAmtTxt.Enabled = False
        Me.TotalAmtTxt.Location = New System.Drawing.Point(336, 56)
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
        Me.BoxDescTxt.Size = New System.Drawing.Size(272, 19)
        Me.BoxDescTxt.TabIndex = 55
        '
        'ItemNoTxt
        '
        Me.ItemNoTxt.Enabled = False
        Me.ItemNoTxt.Location = New System.Drawing.Point(56, 8)
        Me.ItemNoTxt.Name = "ItemNoTxt"
        Me.ItemNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ItemNoTxt.Properties.Enabled = False
        Me.ItemNoTxt.Properties.ReadOnly = True
        Me.ItemNoTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ItemNoTxt.Size = New System.Drawing.Size(32, 19)
        Me.ItemNoTxt.TabIndex = 54
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(336, 32)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(48, 19)
        Me.QtyTxt.TabIndex = 15
        Me.QtyTxt.Text = "0"
        '
        'OverallMarkTxt
        '
        Me.OverallMarkTxt.Location = New System.Drawing.Point(512, 32)
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
        Me.TotAmtLbl.Location = New System.Drawing.Point(256, 62)
        Me.TotAmtLbl.Name = "TotAmtLbl"
        Me.TotAmtLbl.Size = New System.Drawing.Size(88, 16)
        Me.TotAmtLbl.TabIndex = 53
        Me.TotAmtLbl.Text = "Total Amount :"
        '
        'QtyLbl
        '
        Me.QtyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.Location = New System.Drawing.Point(288, 34)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(40, 16)
        Me.QtyLbl.TabIndex = 51
        Me.QtyLbl.Text = "* Qty :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(416, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Overall Markup % :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "* Total Panel Cost :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Item No :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "* Box Desc :"
        '
        'PanelCostTxt
        '
        Me.PanelCostTxt.Enabled = False
        Me.PanelCostTxt.Location = New System.Drawing.Point(120, 32)
        Me.PanelCostTxt.Name = "PanelCostTxt"
        Me.PanelCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelCostTxt.Properties.Enabled = False
        Me.PanelCostTxt.Properties.ReadOnly = True
        Me.PanelCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelCostTxt.Size = New System.Drawing.Size(56, 19)
        Me.PanelCostTxt.TabIndex = 13
        Me.PanelCostTxt.Text = "0"
        '
        'EnclosureTab
        '
        Me.EnclosureTab.Controls.Add(Me.TypeEnclosureCmb)
        Me.EnclosureTab.Controls.Add(Me.Label21)
        Me.EnclosureTab.Controls.Add(Me.Typetxt)
        Me.EnclosureTab.Controls.Add(Me.ThicknessTxt)
        Me.EnclosureTab.Controls.Add(Me.Label20)
        Me.EnclosureTab.Controls.Add(Me.Label19)
        Me.EnclosureTab.Controls.Add(Me.Label7)
        Me.EnclosureTab.Controls.Add(Me.MaterialCmb)
        Me.EnclosureTab.Controls.Add(Me.EnclosureTxt)
        Me.EnclosureTab.Controls.Add(Me.MatCostTxt)
        Me.EnclosureTab.Controls.Add(Me.PowerCoatTxt)
        Me.EnclosureTab.Controls.Add(Me.DepthTxt)
        Me.EnclosureTab.Controls.Add(Me.WidthTxt)
        Me.EnclosureTab.Controls.Add(Me.HeightTxt)
        Me.EnclosureTab.Controls.Add(Me.Label18)
        Me.EnclosureTab.Controls.Add(Me.Label6)
        Me.EnclosureTab.Controls.Add(Me.Label5)
        Me.EnclosureTab.Controls.Add(Me.Label22)
        Me.EnclosureTab.Controls.Add(Me.CostLbl)
        Me.EnclosureTab.Controls.Add(Me.DepthLbl)
        Me.EnclosureTab.Controls.Add(Me.WidthLbl)
        Me.EnclosureTab.Location = New System.Drawing.Point(0, 25)
        Me.EnclosureTab.Name = "EnclosureTab"
        Me.EnclosureTab.Selected = False
        Me.EnclosureTab.Size = New System.Drawing.Size(584, 87)
        Me.EnclosureTab.TabIndex = 4
        Me.EnclosureTab.Title = "Enclosure"
        Me.EnclosureTab.Visible = False
        '
        'TypeEnclosureCmb
        '
        Me.TypeEnclosureCmb.Location = New System.Drawing.Point(128, 63)
        Me.TypeEnclosureCmb.Name = "TypeEnclosureCmb"
        Me.TypeEnclosureCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TypeEnclosureCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TypeEnclosureCmb.Properties.NullString = ""
        Me.TypeEnclosureCmb.Size = New System.Drawing.Size(88, 19)
        Me.TypeEnclosureCmb.TabIndex = 133
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 14)
        Me.Label21.TabIndex = 132
        Me.Label21.Text = "* Type of Enclosure :"
        '
        'Typetxt
        '
        Me.Typetxt.Location = New System.Drawing.Point(128, 43)
        Me.Typetxt.Name = "Typetxt"
        Me.Typetxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Typetxt.Size = New System.Drawing.Size(72, 19)
        Me.Typetxt.TabIndex = 131
        '
        'ThicknessTxt
        '
        Me.ThicknessTxt.Location = New System.Drawing.Point(320, 43)
        Me.ThicknessTxt.Name = "ThicknessTxt"
        Me.ThicknessTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ThicknessTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ThicknessTxt.Size = New System.Drawing.Size(48, 19)
        Me.ThicknessTxt.TabIndex = 130
        Me.ThicknessTxt.Text = "0"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(216, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 14)
        Me.Label20.TabIndex = 129
        Me.Label20.Text = "Thickness :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 14)
        Me.Label19.TabIndex = 128
        Me.Label19.Text = "Type :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(392, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "(eg. 1200mm x 2440mm)"
        '
        'MaterialCmb
        '
        Me.MaterialCmb.Location = New System.Drawing.Point(128, 23)
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
        Me.EnclosureTxt.Location = New System.Drawing.Point(488, 63)
        Me.EnclosureTxt.Name = "EnclosureTxt"
        Me.EnclosureTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnclosureTxt.Properties.Enabled = False
        Me.EnclosureTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnclosureTxt.Size = New System.Drawing.Size(64, 19)
        Me.EnclosureTxt.TabIndex = 119
        Me.EnclosureTxt.Text = "0"
        '
        'MatCostTxt
        '
        Me.MatCostTxt.Location = New System.Drawing.Point(488, 23)
        Me.MatCostTxt.Name = "MatCostTxt"
        Me.MatCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MatCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MatCostTxt.Size = New System.Drawing.Size(64, 19)
        Me.MatCostTxt.TabIndex = 118
        Me.MatCostTxt.Text = "0"
        '
        'PowerCoatTxt
        '
        Me.PowerCoatTxt.Location = New System.Drawing.Point(320, 23)
        Me.PowerCoatTxt.Name = "PowerCoatTxt"
        Me.PowerCoatTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PowerCoatTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PowerCoatTxt.Size = New System.Drawing.Size(48, 19)
        Me.PowerCoatTxt.TabIndex = 117
        Me.PowerCoatTxt.Text = "0"
        '
        'DepthTxt
        '
        Me.DepthTxt.Location = New System.Drawing.Point(488, 3)
        Me.DepthTxt.Name = "DepthTxt"
        Me.DepthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DepthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DepthTxt.Size = New System.Drawing.Size(64, 19)
        Me.DepthTxt.TabIndex = 115
        Me.DepthTxt.Text = "0"
        '
        'WidthTxt
        '
        Me.WidthTxt.Location = New System.Drawing.Point(320, 3)
        Me.WidthTxt.Name = "WidthTxt"
        Me.WidthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WidthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WidthTxt.Size = New System.Drawing.Size(48, 19)
        Me.WidthTxt.TabIndex = 114
        Me.WidthTxt.Text = "0"
        '
        'HeightTxt
        '
        Me.HeightTxt.Location = New System.Drawing.Point(128, 3)
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
        Me.Label18.Location = New System.Drawing.Point(384, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "* Material Cost ($) :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 14)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Material :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 14)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "* Height (mm) :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(392, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "Enclosure Total :"
        '
        'CostLbl
        '
        Me.CostLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostLbl.Location = New System.Drawing.Point(216, 25)
        Me.CostLbl.Name = "CostLbl"
        Me.CostLbl.Size = New System.Drawing.Size(112, 14)
        Me.CostLbl.TabIndex = 122
        Me.CostLbl.Text = "* Power Coat ($/m) :"
        Me.CostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DepthLbl
        '
        Me.DepthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepthLbl.Location = New System.Drawing.Point(384, 5)
        Me.DepthLbl.Name = "DepthLbl"
        Me.DepthLbl.Size = New System.Drawing.Size(80, 14)
        Me.DepthLbl.TabIndex = 121
        Me.DepthLbl.Text = "* Depth (mm) :"
        '
        'WidthLbl
        '
        Me.WidthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthLbl.Location = New System.Drawing.Point(216, 5)
        Me.WidthLbl.Name = "WidthLbl"
        Me.WidthLbl.Size = New System.Drawing.Size(112, 14)
        Me.WidthLbl.TabIndex = 120
        Me.WidthLbl.Text = "* Length (mm) :"
        Me.WidthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OthersTab
        '
        Me.OthersTab.Controls.Add(Me.OCEFlbl)
        Me.OthersTab.Controls.Add(Me.InstallTxt)
        Me.OthersTab.Controls.Add(Me.PanelTransportTxt)
        Me.OthersTab.Controls.Add(Me.IncomingTxt)
        Me.OthersTab.Controls.Add(Me.OCEFTxt)
        Me.OthersTab.Controls.Add(Me.Label4)
        Me.OthersTab.Controls.Add(Me.Label2)
        Me.OthersTab.Controls.Add(Me.Label1)
        Me.OthersTab.Controls.Add(Me.CopperTxt)
        Me.OthersTab.Controls.Add(Me.TransportTxt)
        Me.OthersTab.Controls.Add(Me.AccessoryTxt)
        Me.OthersTab.Controls.Add(Me.ConcreteBaseTxt)
        Me.OthersTab.Controls.Add(Me.WiringTxt)
        Me.OthersTab.Controls.Add(Me.Label24)
        Me.OthersTab.Controls.Add(Me.Label23)
        Me.OthersTab.Controls.Add(Me.Label16)
        Me.OthersTab.Controls.Add(Me.Label15)
        Me.OthersTab.Controls.Add(Me.Label14)
        Me.OthersTab.Location = New System.Drawing.Point(0, 25)
        Me.OthersTab.Name = "OthersTab"
        Me.OthersTab.Selected = False
        Me.OthersTab.Size = New System.Drawing.Size(584, 87)
        Me.OthersTab.TabIndex = 5
        Me.OthersTab.Title = "Others"
        Me.OthersTab.Visible = False
        '
        'OCEFlbl
        '
        Me.OCEFlbl.Location = New System.Drawing.Point(16, 63)
        Me.OCEFlbl.Name = "OCEFlbl"
        Me.OCEFlbl.Size = New System.Drawing.Size(48, 16)
        Me.OCEFlbl.TabIndex = 60
        Me.OCEFlbl.Text = "OC/EF :"
        '
        'InstallTxt
        '
        Me.InstallTxt.Location = New System.Drawing.Point(508, 59)
        Me.InstallTxt.Name = "InstallTxt"
        Me.InstallTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstallTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.InstallTxt.Size = New System.Drawing.Size(64, 19)
        Me.InstallTxt.TabIndex = 59
        Me.InstallTxt.Text = "0"
        '
        'PanelTransportTxt
        '
        Me.PanelTransportTxt.Location = New System.Drawing.Point(364, 59)
        Me.PanelTransportTxt.Name = "PanelTransportTxt"
        Me.PanelTransportTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelTransportTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelTransportTxt.Size = New System.Drawing.Size(64, 19)
        Me.PanelTransportTxt.TabIndex = 58
        Me.PanelTransportTxt.Text = "0"
        '
        'IncomingTxt
        '
        Me.IncomingTxt.Location = New System.Drawing.Point(204, 59)
        Me.IncomingTxt.Name = "IncomingTxt"
        Me.IncomingTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IncomingTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.IncomingTxt.Size = New System.Drawing.Size(64, 19)
        Me.IncomingTxt.TabIndex = 57
        Me.IncomingTxt.Text = "0"
        '
        'OCEFTxt
        '
        Me.OCEFTxt.Location = New System.Drawing.Point(68, 59)
        Me.OCEFTxt.Name = "OCEFTxt"
        Me.OCEFTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OCEFTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OCEFTxt.Size = New System.Drawing.Size(64, 19)
        Me.OCEFTxt.TabIndex = 56
        Me.OCEFTxt.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(444, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Installation :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(276, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Panel Transport :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(148, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Incoming :"
        '
        'CopperTxt
        '
        Me.CopperTxt.Location = New System.Drawing.Point(452, 7)
        Me.CopperTxt.Name = "CopperTxt"
        Me.CopperTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CopperTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CopperTxt.Size = New System.Drawing.Size(80, 19)
        Me.CopperTxt.TabIndex = 52
        Me.CopperTxt.Text = "0"
        '
        'TransportTxt
        '
        Me.TransportTxt.Location = New System.Drawing.Point(292, 27)
        Me.TransportTxt.Name = "TransportTxt"
        Me.TransportTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TransportTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TransportTxt.Size = New System.Drawing.Size(80, 19)
        Me.TransportTxt.TabIndex = 51
        Me.TransportTxt.Text = "0"
        '
        'AccessoryTxt
        '
        Me.AccessoryTxt.Location = New System.Drawing.Point(292, 7)
        Me.AccessoryTxt.Name = "AccessoryTxt"
        Me.AccessoryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AccessoryTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AccessoryTxt.Size = New System.Drawing.Size(80, 19)
        Me.AccessoryTxt.TabIndex = 49
        Me.AccessoryTxt.Text = "0"
        '
        'ConcreteBaseTxt
        '
        Me.ConcreteBaseTxt.Location = New System.Drawing.Point(116, 27)
        Me.ConcreteBaseTxt.Name = "ConcreteBaseTxt"
        Me.ConcreteBaseTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ConcreteBaseTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ConcreteBaseTxt.Size = New System.Drawing.Size(64, 19)
        Me.ConcreteBaseTxt.TabIndex = 50
        Me.ConcreteBaseTxt.Text = "0"
        '
        'WiringTxt
        '
        Me.WiringTxt.Location = New System.Drawing.Point(116, 7)
        Me.WiringTxt.Name = "WiringTxt"
        Me.WiringTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WiringTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WiringTxt.Size = New System.Drawing.Size(64, 19)
        Me.WiringTxt.TabIndex = 48
        Me.WiringTxt.Text = "0"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label24.Location = New System.Drawing.Point(220, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "Transport :"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 16)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Concrete Base :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label16.Location = New System.Drawing.Point(396, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Copper :"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label15.Location = New System.Drawing.Point(220, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Accessory :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Wiring :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ConsultantCmb)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.ProjectTitleCmb)
        Me.GroupBox1.Controls.Add(Me.RefQuoNoTxt)
        Me.GroupBox1.Controls.Add(Me.Addresstxt)
        Me.GroupBox1.Controls.Add(Me.QuoDate)
        Me.GroupBox1.Controls.Add(Me.QuoNoTxt)
        Me.GroupBox1.Controls.Add(Me.ProjectCmb)
        Me.GroupBox1.Controls.Add(Me.StatusCmb)
        Me.GroupBox1.Controls.Add(Me.ContLookup)
        Me.GroupBox1.Controls.Add(Me.CustLookup)
        Me.GroupBox1.Controls.Add(Me.CP5Chk)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.CP5Lbl)
        Me.GroupBox1.Controls.Add(Me.ProjectLbl)
        Me.GroupBox1.Controls.Add(Me.AddressLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.StatusLbl)
        Me.GroupBox1.Controls.Add(Me.DateLbl)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Controls.Add(Me.QuoNoLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 124)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'ConsultantCmb
        '
        Me.ConsultantCmb.Location = New System.Drawing.Point(368, 98)
        Me.ConsultantCmb.Name = "ConsultantCmb"
        Me.ConsultantCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ConsultantCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ConsultantCmb.Properties.NullString = ""
        Me.ConsultantCmb.Properties.PopupWidth = 208
        Me.ConsultantCmb.Size = New System.Drawing.Size(208, 19)
        Me.ConsultantCmb.TabIndex = 40
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(296, 104)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Consultant :"
        '
        'ProjectTitleCmb
        '
        Me.ProjectTitleCmb.Location = New System.Drawing.Point(200, 76)
        Me.ProjectTitleCmb.Name = "ProjectTitleCmb"
        Me.ProjectTitleCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectTitleCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectTitleCmb.Properties.NullString = ""
        Me.ProjectTitleCmb.Properties.PopupWidth = 376
        Me.ProjectTitleCmb.Size = New System.Drawing.Size(376, 19)
        Me.ProjectTitleCmb.TabIndex = 38
        '
        'RefQuoNoTxt
        '
        Me.RefQuoNoTxt.Location = New System.Drawing.Point(256, 16)
        Me.RefQuoNoTxt.Name = "RefQuoNoTxt"
        Me.RefQuoNoTxt.Size = New System.Drawing.Size(144, 16)
        Me.RefQuoNoTxt.TabIndex = 37
        Me.RefQuoNoTxt.Visible = False
        '
        'Addresstxt
        '
        Me.Addresstxt.Location = New System.Drawing.Point(304, 56)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Addresstxt.Size = New System.Drawing.Size(272, 19)
        Me.Addresstxt.TabIndex = 35
        '
        'QuoDate
        '
        Me.QuoDate.DateTime = New Date(CType(0, Long))
        Me.QuoDate.Location = New System.Drawing.Point(472, 36)
        Me.QuoDate.Name = "QuoDate"
        Me.QuoDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuoDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.QuoDate.Size = New System.Drawing.Size(104, 19)
        Me.QuoDate.TabIndex = 34
        '
        'QuoNoTxt
        '
        Me.QuoNoTxt.Location = New System.Drawing.Point(112, 16)
        Me.QuoNoTxt.Name = "QuoNoTxt"
        Me.QuoNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuoNoTxt.Properties.ReadOnly = True
        Me.QuoNoTxt.Size = New System.Drawing.Size(128, 19)
        Me.QuoNoTxt.TabIndex = 33
        '
        'ProjectCmb
        '
        Me.ProjectCmb.Location = New System.Drawing.Point(112, 76)
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
        Me.StatusCmb.Location = New System.Drawing.Point(304, 36)
        Me.StatusCmb.Name = "StatusCmb"
        Me.StatusCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusCmb.Properties.NullString = ""
        Me.StatusCmb.Size = New System.Drawing.Size(104, 19)
        Me.StatusCmb.TabIndex = 4
        '
        'ContLookup
        '
        Me.ContLookup.Location = New System.Drawing.Point(112, 56)
        Me.ContLookup.Name = "ContLookup"
        Me.ContLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContLookup.Properties.NullString = ""
        Me.ContLookup.Properties.PopupWidth = 152
        Me.ContLookup.Size = New System.Drawing.Size(128, 19)
        Me.ContLookup.TabIndex = 5
        '
        'CustLookup
        '
        Me.CustLookup.Location = New System.Drawing.Point(112, 36)
        Me.CustLookup.Name = "CustLookup"
        Me.CustLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustLookup.Properties.NullString = ""
        Me.CustLookup.Properties.PopupWidth = 304
        Me.CustLookup.Size = New System.Drawing.Size(128, 19)
        Me.CustLookup.TabIndex = 3
        '
        'CP5Chk
        '
        Me.CP5Chk.Location = New System.Drawing.Point(256, 104)
        Me.CP5Chk.Name = "CP5Chk"
        Me.CP5Chk.Size = New System.Drawing.Size(16, 16)
        Me.CP5Chk.TabIndex = 9
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(224, 104)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(32, 16)
        Me.Label39.TabIndex = 32
        Me.Label39.Text = "CP5"
        '
        'CP5Lbl
        '
        Me.CP5Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP5Lbl.Location = New System.Drawing.Point(8, 104)
        Me.CP5Lbl.Name = "CP5Lbl"
        Me.CP5Lbl.Size = New System.Drawing.Size(216, 16)
        Me.CP5Lbl.TabIndex = 31
        Me.CP5Lbl.Text = "Statutory And Regulatory Requirement :"
        '
        'ProjectLbl
        '
        Me.ProjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectLbl.Location = New System.Drawing.Point(8, 82)
        Me.ProjectLbl.Name = "ProjectLbl"
        Me.ProjectLbl.Size = New System.Drawing.Size(56, 16)
        Me.ProjectLbl.TabIndex = 27
        Me.ProjectLbl.Text = "* Project :"
        '
        'AddressLbl
        '
        Me.AddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLbl.Location = New System.Drawing.Point(248, 62)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(56, 16)
        Me.AddressLbl.TabIndex = 20
        Me.AddressLbl.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "* Contact Person :"
        '
        'StatusLbl
        '
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(248, 42)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(56, 16)
        Me.StatusLbl.TabIndex = 16
        Me.StatusLbl.Text = "* Status :"
        '
        'DateLbl
        '
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(416, 42)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(48, 16)
        Me.DateLbl.TabIndex = 13
        Me.DateLbl.Text = "* Date :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(8, 42)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(104, 16)
        Me.CustNameLbl.TabIndex = 10
        Me.CustNameLbl.Text = "* Customer Name :"
        '
        'QuoNoLbl
        '
        Me.QuoNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuoNoLbl.Location = New System.Drawing.Point(8, 22)
        Me.QuoNoLbl.Name = "QuoNoLbl"
        Me.QuoNoLbl.Size = New System.Drawing.Size(88, 16)
        Me.QuoNoLbl.TabIndex = 11
        Me.QuoNoLbl.Text = "Quotation No :"
        '
        'PaymentTab
        '
        Me.PaymentTab.Controls.Add(Me.GroupBox4)
        Me.PaymentTab.Location = New System.Drawing.Point(0, 0)
        Me.PaymentTab.Name = "PaymentTab"
        Me.PaymentTab.Selected = False
        Me.PaymentTab.Size = New System.Drawing.Size(616, 463)
        Me.PaymentTab.TabIndex = 4
        Me.PaymentTab.Title = "Payment Details"
        Me.PaymentTab.Visible = False
        '
        'GroupBox4
        '
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
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(600, 420)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'ClosingTxt
        '
        Me.ClosingTxt.Location = New System.Drawing.Point(64, 144)
        Me.ClosingTxt.Name = "ClosingTxt"
        Me.ClosingTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ClosingTxt.Size = New System.Drawing.Size(432, 19)
        Me.ClosingTxt.TabIndex = 41
        '
        'SignByCmb
        '
        Me.SignByCmb.Location = New System.Drawing.Point(480, 88)
        Me.SignByCmb.Name = "SignByCmb"
        Me.SignByCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SignByCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SignByCmb.Properties.NullString = ""
        Me.SignByCmb.Size = New System.Drawing.Size(112, 19)
        Me.SignByCmb.TabIndex = 40
        '
        'ServiceTypeCmb
        '
        Me.ServiceTypeCmb.Location = New System.Drawing.Point(480, 64)
        Me.ServiceTypeCmb.Name = "ServiceTypeCmb"
        Me.ServiceTypeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ServiceTypeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ServiceTypeCmb.Properties.NullString = ""
        Me.ServiceTypeCmb.Size = New System.Drawing.Size(112, 19)
        Me.ServiceTypeCmb.TabIndex = 39
        '
        'PriceTillCmb
        '
        Me.PriceTillCmb.Location = New System.Drawing.Point(480, 40)
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
        Me.OtherNotesMemo.Location = New System.Drawing.Point(64, 160)
        Me.OtherNotesMemo.Name = "OtherNotesMemo"
        Me.OtherNotesMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OtherNotesMemo.Size = New System.Drawing.Size(432, 40)
        Me.OtherNotesMemo.TabIndex = 33
        '
        'NotesMemo
        '
        Me.NotesMemo.Location = New System.Drawing.Point(64, 104)
        Me.NotesMemo.Name = "NotesMemo"
        Me.NotesMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesMemo.Size = New System.Drawing.Size(312, 40)
        Me.NotesMemo.TabIndex = 32
        '
        'DelTermsMemo
        '
        Me.DelTermsMemo.Location = New System.Drawing.Point(64, 64)
        Me.DelTermsMemo.Name = "DelTermsMemo"
        Me.DelTermsMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DelTermsMemo.Size = New System.Drawing.Size(312, 40)
        Me.DelTermsMemo.TabIndex = 31
        '
        'PayDetailsMemo
        '
        Me.PayDetailsMemo.Location = New System.Drawing.Point(64, 40)
        Me.PayDetailsMemo.Name = "PayDetailsMemo"
        Me.PayDetailsMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PayDetailsMemo.Size = New System.Drawing.Size(312, 23)
        Me.PayDetailsMemo.TabIndex = 30
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 144)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 16)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "Closing :"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 168)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 24)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Typical Notes 1 :"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 112)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Notes :"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(392, 96)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 16)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Signed by :"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(392, 72)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Service Type :"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(392, 48)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 16)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Price include till :"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 16)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Validity :"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 32)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Payment Term :"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 32)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Delivery Terms :"
        '
        'SpecialBtn
        '
        Me.SpecialBtn.AutoSize = False
        Me.SpecialBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SpecialBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialBtn.Image = Nothing
        Me.SpecialBtn.Location = New System.Drawing.Point(152, 512)
        Me.SpecialBtn.Name = "SpecialBtn"
        Me.SpecialBtn.Size = New System.Drawing.Size(64, 32)
        Me.SpecialBtn.TabIndex = 19
        Me.SpecialBtn.Text = "Special"
        '
        'QuotationForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(624, 549)
        Me.Controls.Add(Me.SpecialBtn)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.DispatchBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveQuoBtn)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuotationForm"
        Me.Text = "New Quotation"
        Me.TabControl3.ResumeLayout(False)
        Me.DetailsTab.ResumeLayout(False)
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
        CType(Me.ConsultantCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentTab.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
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

#Region " Codes for Form load"
    Private Sub QuotationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Top = (MainForm.ActiveForm.Height - Me.Height) / 3
        'Me.Left = (MainForm.ActiveForm.Width - Me.Width) / 2

        Me.Cursor = Cursors.WaitCursor

        LoadCustomerDetails()
        LoadEnclosureType()
        LoadProjectTitle()
        LoadConsultant()
        LoadPriceIncludeTill()

        LoadCombo()
        SetTabColors()
        LoadCopyFromBox()
        LoadBoxCategory()

        TabControl3.IDEPixelBorder = True

        Select Case UCase(FormStatus)
            Case "NEW"
                ItemNo = 0
                InitializeForm()
                DisableNavBtn()
            Case "REJOIN"
                Me.Text = "Rejoin Quotation"
                DuplicateExistingQuotation()
                SetFormStatus()
                DispatchBtn.Enabled = False
            Case "EDIT"
                Me.Text = "Edit Quotation"
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetQuotationHeader(dsHeaderLoad, Quotation_ID) Then
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
            Case "VIEW"
                Me.Text = "View Quotation"
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetQuotationHeader(dsHeaderLoad, Quotation_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                CompGrid1.Enabled = True
                SaveQuoBtn.Enabled = True
                RefreshNavBtn()
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
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
            Case "REVISED"
                Me.Text = "Revise Quotation"
                RevisedQuotationHeader()
                RevisedQuotationLine()
                SetOldQuotationStatus()
                RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

        QuoNoTxt.Text = CreateQuotationNo()
        StatusCmb.Properties.LookUpData.KeyValue = "10"
        QuoDate.DateTime = Date.Today
        ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        SignByCmb.Properties.LookUpData.KeyValue = "Thomas Yeo"
        ServiceTypeCmb.Properties.LookUpData.KeyValue = "1"
        ItemNoTxt.Text = ItemNo.ToString
        QuotationNo = QuoNoTxt.Text     'to store quotation no

        ClosingTxt.Text = "We hope that our quotation is acceptable and looking forward to hear from you soon."
        OtherNotesMemo.Text = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."

        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_No = QuotationNo
            .UserID = UserID
            .Status = StatusCmb.Properties.LookUpData.KeyValue

            If .SaveQuotationNo() Then
                Quotation_ID = .Quotation_ID        'Store Quotation ID
            Else
                MessageBox.Show("Error creating Quotation", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Private Sub EnableButtons()
        DelProdBtn.Enabled = True
        TabControl1.Enabled = True
        'EditCompBtn.Enabled = True
        'DelCompBtn.Enabled = True
        UpdateBtn.Enabled = True
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

    Private Function CreateQuotationNo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("QU")
        End With
        CreateQuotationNo = "QU" & Year(Now) & DocumentNo
    End Function
#End Region

#Region " Codes for Rejoin Quotation "
    Private Sub SetFormStatus()
        CustLookup.Properties.ReadOnly = True
        StatusCmb.Properties.ReadOnly = True
        QuoDate.Properties.ReadOnly = True
        ContLookup.Properties.ReadOnly = True
        Addresstxt.Properties.ReadOnly = True
        ProjectCmb.Properties.ReadOnly = True
        'ProjectTxt.Properties.ReadOnly = True
        ProjectTitleCmb.Properties.ReadOnly = True
        CP5Chk.Enabled = False

        ValidityTxt.Properties.ReadOnly = True
        PayDetailsMemo.Properties.ReadOnly = True
        DelTermsMemo.Properties.ReadOnly = True
        NotesMemo.Properties.ReadOnly = True
        ClosingTxt.Properties.ReadOnly = True
        OtherNotesMemo.Properties.ReadOnly = True
        ServiceTypeCmb.Properties.ReadOnly = True
        SignByCmb.Properties.ReadOnly = True
        PriceTillCmb.Properties.ReadOnly = True
        RefQuoNoTxt.Visible = True
    End Sub

    Private Sub DuplicateExistingQuotation()
        Dim dsLoad As DataSet
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer
        Dim RejoinedNo As Integer

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeader(dsLoad, Old_Quotation_ID) Then
                'Check if its created from rejoined quotation or based quotation
                .Quotation_ID = Old_Quotation_ID
                If .IsRejoinedQuote(dsBasedQuotation) Then        'if its rejoined quotation, then load based Quotation no
                    BasedQuotationID = dsBasedQuotation.Tables(0).Rows(0)("Quotation_ID")
                    QuotationNo = dsBasedQuotation.Tables(0).Rows(0)("Quotation_NO")
                    'COUNT THE NO OF rejoined COPY
                    .RefQuotationID = BasedQuotationID
                    RejoinedNo = .CountNoOfRejoinedQuote()
                    '****
                    RefQuotationID = BasedQuotationID        'Reference to the based ID
                Else
                    QuotationNo = dsLoad.Tables(0).Rows(0)("Quotation_NO")  'Get the Existing Quotation No.
                    'COUNT THE NO OF REVISED COPY
                    .RefQuotationID = Old_Quotation_ID
                    RejoinedNo = .CountNoOfRejoinedQuote()
                    '****
                    RefQuotationID = Old_Quotation_ID        'Reference
                End If
                '****

                'CHECKING
                .Quotation_No = QuotationNo & "-A" & RejoinedNo          'Appending R...
                If .CheckExistingQuotationNo() Then         'Record exist
                    RejoinedNo = RejoinedNo + 1
                    .Quotation_No = QuotationNo & "-A" & RejoinedNo
                    While .CheckExistingQuotationNo
                        RejoinedNo = RejoinedNo + 1
                        .Quotation_No = QuotationNo & "-A" & RejoinedNo
                    End While
                End If
                '***

                .Status = "10"
                .UserID = UserID
                If .SaveQuotationNo() Then
                    Quotation_ID = .Quotation_ID

                    'After saving initial data, save the rest of the data.
                    .Quotation_ID = Quotation_ID
                    .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("QuotationDate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("QuotationDate"))) & Year(dsLoad.Tables(0).Rows(0)("QuotationDate"))
                    .Status = dsLoad.Tables(0).Rows(0)("Status")
                    .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                    .Project = dsLoad.Tables(0).Rows(0)("Project")
                    .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")
                    .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
                        .Consultant_ID = dsLoad.Tables(0).Rows(0)("Consultant_ID")
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
                    .RefQuotationID = RefQuotationID

                    If .UpdateQuotationHeader() Then
                        Dim dsNew As DataSet
                        If .GetQuotationHeader(dsNew, Quotation_ID) Then
                            SetWindowValue(dsNew)
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With
    End Sub
#End Region

#Region " Codes for Revised Quotation"
    Private Sub SetOldQuotationStatus()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Old_Quotation_ID
            .Status = "40"
            If .UpdateQuotationHeaderStatus() Then

            End If
        End With
    End Sub

    Private Sub RevisedQuotationHeader()
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeader(dsLoad, Old_Quotation_ID) Then
                'Check if its created from revised quotation or based quotation
                .Quotation_ID = Old_Quotation_ID
                If .IsRevisedQuote(dsBasedQuotation) Then        'if its revised quotation, then load based Quotation no
                    BasedQuotationID = dsBasedQuotation.Tables(0).Rows(0)("Quotation_ID")
                    QuotationNo = dsBasedQuotation.Tables(0).Rows(0)("Quotation_NO")
                    'COUNT THE NO OF REVISED COPY
                    .RevRefQuotationID = BasedQuotationID
                    RevisedNo = .CountNoOfRevisedQuote()
                    '****
                    RevRefQuotationID = BasedQuotationID        'Reference to the based ID
                Else
                    QuotationNo = dsLoad.Tables(0).Rows(0)("Quotation_NO")  'Get the Existing Quotation No.
                    'COUNT THE NO OF REVISED COPY
                    .RevRefQuotationID = Old_Quotation_ID
                    RevisedNo = .CountNoOfRevisedQuote()
                    '****
                    RevRefQuotationID = Old_Quotation_ID        'Reference
                End If
                '****

                'CHECKING
                .Quotation_No = QuotationNo & "R" & RevisedNo          'Appending R...
                If .CheckExistingQuotationNo() Then         'Record exist
                    RevisedNo = RevisedNo + 1
                    .Quotation_No = QuotationNo & "R" & RevisedNo
                    While .CheckExistingQuotationNo
                        RevisedNo = RevisedNo + 1
                        .Quotation_No = QuotationNo & "R" & RevisedNo
                    End While
                End If
                '***

                .Status = "10"
                .UserID = UserID
                If .SaveQuotationNo() Then
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

                    'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RevRefQuotationID")) Then
                    '.RevRefQuotationID = RevRefQuotationID
                    'End If

                If .UpdateQuotationHeader() Then
                    Dim dsNew As DataSet
                    If .GetQuotationHeader(dsNew, Quotation_ID) Then
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
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("LinePercent_Discount")) Then
                        .LinePercent_Discount = dsLine.Tables(0).Rows(x)("LinePercent_Discount")
                    End If
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

#Region " Set window value"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        QuoNoTxt.Text = dsLoad.Tables(0).Rows(0)("Quotation_NO")
        CustLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Customer_ID")
        StatusCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Status")
        ProjectCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("ProjectSub")
        ProjectTitleCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Project")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
            ConsultantCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Consultant_ID")
        End If
        QuoDate.DateTime = dsLoad.Tables(0).Rows(0)("QuotationDate")
        LoadContactPerson(dsLoad.Tables(0).Rows(0)("Customer_ID"))
        ContLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Contact_ID")
        If dsLoad.Tables(0).Rows(0)("CP5_Flg") = 0 Then
            CP5Chk.Checked = False
        Else
            CP5Chk.Checked = True
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

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PriceInclude_ID")) Then
            PriceTillCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("PriceInclude_ID")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ClosingNotes")) Then
            ClosingTxt.Text = dsLoad.Tables(0).Rows(0)("ClosingNotes")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("OtherNotes")) Then
            OtherNotesMemo.Text = dsLoad.Tables(0).Rows(0)("OtherNotes")
        End If

        RefQuotationID = dsLoad.Tables(0).Rows(0)("RefQuotationID")
        If Not RefQuotationID = 0 Then
            With New BusinessRules.SaleBusRules.SaleBusLogic
                Dim dsTmp As DataSet
                If .GetQuotationHeader(dsTmp, RefQuotationID) Then
                    RefQuoNoTxt.Text = dsTmp.Tables(0).Rows(0)("Quotation_NO")
                End If
                dsTmp.Dispose()
            End With
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

    Private Sub LoadConsultant()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ConsultantBusLogic
            If .GetConsultant(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ConsultantCmb, "Consultant_Name", 400, 0, "c")
                        ConsultantCmb.Properties.LookUpData.KeyField = "Consultant_ID"
                        ConsultantCmb.Properties.LookUpData.DisplayField = "Consultant_Name"

                        ConsultantCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ConsultantCmb.EditValue = "0"
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

    Private Sub LoadCopyFromBox()
        Dim dsB As DataSet

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetAllQuotationLine(dsB) Then
                If Not dsB Is Nothing Then
                    CopyFmBxCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(CopyFmBxCmb, "Box", 400, 0, "c")
                    CopyFmBxCmb.Properties.LookUpData.KeyField = "Quotation_Line_ID"
                    CopyFmBxCmb.Properties.LookUpData.DisplayField = "Box"

                    CopyFmBxCmb.Properties.LookUpData.DataSource = dsB.Tables(0)
                    CopyFmBxCmb.EditValue = "0"
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

#Region " Hardcoded Combo Box , Status, ProjectSub, Signby"
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

        Dim MaterialData As String() = New String() {"", "AL", "Steel"}
        Dim MaterialID As String() = New String() {"", "AL", "Steel"}
        SetComboValue(MaterialData, MaterialCmb, MaterialID)
    End Sub
#End Region

#Region " Code for combo box on close up"
    Private Sub CustLookup_CloseUp1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles CustLookup.CloseUp
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

    Private Sub CopyFmBxCmb_CloseUp1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles CopyFmBxCmb.CloseUp
        Dim ds As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If Len(e.Value) > 0 Then
                If .GetAllQuotationLine(ds, e.Value) Then
                    If Not ds Is Nothing Then
                        CopyBoxDetails(ds)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub CopyBoxDetails(ByVal ds As DataSet)
        BoxDescTxt.Text = ds.Tables(0).Rows(0)("Box").ToString
        PanelCostTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Cost"))
        OverallMarkTxt.Text = Integer.Parse(ds.Tables(0).Rows(0)("Overall_Markup"))
        QtyTxt.Text = ds.Tables(0).Rows(0)("Qty").ToString
        TotalAmtTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Total_Amount"))
        CompMarkTxt.Text = ds.Tables(0).Rows(0)("Comp_Markup").ToString

        HeightTxt.Text = Integer.Parse(ds.Tables(0).Rows(0)("Height"))
        WidthTxt.Text = Integer.Parse(ds.Tables(0).Rows(0)("Width"))
        DepthTxt.Text = Integer.Parse(ds.Tables(0).Rows(0)("Depth"))

        If Not IsDBNull(ds.Tables(0).Rows(0)("Raw_Material")) Then
            MaterialCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows()("Raw_Material")
        Else
            MaterialCmb.Properties.LookUpData.KeyValue = Nothing
        End If

        MatCostTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Material_Cost"))

        If Not IsDBNull(ds.Tables(0).Rows(0)("Type")) Then
            Typetxt.Text = ds.Tables(0).Rows(0)("Type").ToString
        End If

        If Not IsDBNull(ds.Tables(0).Rows(0)("Thickness")) Then
            ThicknessTxt.Text = Integer.Parse(ds.Tables(0).Rows(0)("Thickness"))
        End If

        PowerCoatTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Power_Coat"))
        WiringTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Wiring"))
        AccessoryTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Accessory"))
        CopperTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Copper"))
        ConcreteBaseTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Concrete_Base"))
        TransportTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Transport"))
        EnclosureTxt.Text = Decimal.Round(ds.Tables(0).Rows(0)("Enclosure"), 2)
        OCEFTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("OC_EF"))
        IncomingTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Incoming"))
        PanelTransportTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Panel_Transport"))
        InstallTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Installation"))
        TypeEnclosureCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Type_Of_Enclosure")
    End Sub
#End Region

#Region " Component Grid Function & Double Click Event & Mouse Right Click"
    Public Sub RefreshComponentGrid()
        Dim ds As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_Line_ID = Quotation_Line_ID
            If .GetQuotationLineCompOnLineID(ds) Then
                'If ds.Tables(0).Rows.Count > 0 Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                'Dim CompTotal As Double
                Dim TotalCost As Double
                CompTotal = 0

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    TotalCost = oRow("UnitPrice") * oRow("Qty")
                    CompTotal = CompTotal + TotalCost
                    data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand"), oRow("Description"), oRow("Lead_Time"), oRow("Qty"), oRow("UnitPrice"), TotalCost})
                Next
                CompGrid1.DataSource = data
                CompGrid1.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column
                CompCostTxt.Text = CompTotal
                'End If
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
        AddColumn(data, "Unit Price", System.Type.GetType("System.Double"), True)
        AddColumn(data, "Total", System.Type.GetType("System.Double"), True)
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
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Component_ID As Integer = dr(1)

            If Len(Component_ID) > 0 Or Not Component_ID = 0 Then
                Dim NewForm As New SelectProductForm
                NewForm.Component_ID = Component_ID
                NewForm.Status = "EDIT"
                NewForm.ShowDialog(Me)
                RefreshComponentGrid()
            End If
        End If
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim Component_ID As Integer = dr(1)
            Dim Component_Name As String = dr(2)

            If Len(Component_ID) > 0 Or Not Component_ID = 0 Then
                Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Component_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = DialogResult.Yes Then
                    DeleteQuotationLineComponent(Component_ID)
                End If
            End If
        End If
    End Sub
#End Region


#Region " Buttons - Component, Box "

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
                CopyFmBxCmb.Enabled = True
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
        CopyFmBxCmb.Enabled = False
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
                        MessageBox.Show("Box Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub DispatchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchBtn.Click
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Quotation_ID
            .Status = "20"      'Pending status
            If .UpdateQuotationHeaderStatus() Then
                MessageBox.Show("Status updated.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                StatusCmb.Properties.LookUpData.KeyValue = "20"
            End If
        End With
    End Sub

    Private Sub ResetQuotationLine()
        '** Box Tab **
        'ItemNo = ItemNo + 1
        'ItemNoTxt.Text = ItemNo
        BoxDescTxt.Text = ""
        PanelCostTxt.Text = ""
        OverallMarkTxt.Text = ""
        CompMarkTxt.Text = ""
        QtyTxt.Text = ""
        TotalAmtTxt.Text = ""
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

        GrandTotal = GrandTotal + Total_Amount

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
        '***

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
                .Type_Of_Enclosure = Type_Of_Enclosure
                .BoxCategory_ID = BoxCategory_ID

                .UserID = UserID
                If .UpdateQuotationLine() Then
                    Quotation_Line_ID = .Quotation_Line_ID
                    MessageBox.Show("Data saved. ", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If Not Len(Qty) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Qty" & Chr(13)
        End If

        If varHeight = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Height" & Chr(13)
        End If

        If varWidth = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Length" & Chr(13)
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

        If Not Len(Type_Of_Enclosure) > 0 Or Type_Of_Enclosure = 0 Then
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

    Private Sub DeleteQuotationLineComponent(ByVal pComponent_ID As Integer)
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Component_ID = pComponent_ID
            If .DeleteQuotationLineComponent Then
                RefreshComponentGrid()
                MessageBox.Show("Component Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub
#End Region

#Region " Main Quotation Saving Btn, Close, Save Function, Retrieve from form"
    Private Sub SaveQuoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveQuoBtn.Click
        RetrieveFromMainForm()
        SaveMainFormProcess()
    End Sub

    Private Sub RetrieveFromMainForm()
        Customer_ID = CustLookup.Properties.LookUpData.KeyValue
        Contact_ID = ContLookup.Properties.LookUpData.KeyValue
        QuotationDate = QuoDate.Text
        Status = StatusCmb.Properties.LookUpData.KeyValue
        'Project = ProjectTxt.Text
        Project = ProjectTitleCmb.Properties.LookUpData.KeyValue
        ProjectSub = ProjectCmb.Properties.LookUpData.KeyValue
        If CP5Chk.Checked = True Then
            CP5_Flg = "1"
        Else
            CP5_Flg = "0"
        End If

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
        If Len(NotesMemo.Text) > 0 Then
            Remarks = NotesMemo.Text
        End If

        If Len(ClosingTxt.Text) > 0 Then
            ClosingNotes = ClosingTxt.Text
        End If

        If Len(OtherNotesMemo.Text) > 0 Then
            OtherNotes = OtherNotesMemo.Text
        End If
        Consultant_ID = ConsultantCmb.Properties.LookUpData.KeyValue
        PriceInclude_ID = PriceTillCmb.Properties.LookUpData.KeyValue

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
                .Payment_Term = Payment_Term
                .Validity = Validity
                .Delivery_Term = Delivery_Term
                .Service_Type = Service_Type
                .CP5_Flg = CP5_Flg
                .Sign_By = Sign_By
                .Remarks = Remarks
                .ClosingNotes = ClosingNotes
                .OtherNotes = OtherNotes
                .Consultant_ID = Consultant_ID
                .UserID = UserID
                .RefQuotationID = RefQuotationID
                .PriceInclude_ID = PriceInclude_ID
                .Total_Cost_Numeric = Total_Cost_Numeric
                If .UpdateQuotationHeader() Then
                    MessageBox.Show("Quotation Saved.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this quotation?", "Quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

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
                        GrandTotal = GrandTotal + NavdsBox.Tables(0).Rows(i)("Total_Amount")
                    End If
                Next
                GrandTotalTxt.Text = GrandTotal
            End If
        End With
    End Sub

    Private Sub NavdsBox_PositionChanged()
        Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of ") _
                    + Me.NavdsBox.Tables(0).Rows.Count.ToString)

        Me.Quotation_Line_ID = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Quotation_Line_ID")
        Me.BoxDescTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Box").ToString
        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")) Then
            Me.BoxCategoryCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")
        End If
        Me.ItemNoTxt.Text = CurrentRow + 1
        Me.PanelCostTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Cost"))
        Me.OverallMarkTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Overall_Markup"))
        Me.QtyTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty").ToString
        Me.TotalAmtTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Total_Amount"))
        Me.CompMarkTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Comp_Markup").ToString

        Me.HeightTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Height"))
        Me.WidthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Width"))
        Me.DepthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Depth"))

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Raw_Material")) Then
            Me.MaterialCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Raw_Material")
        Else
            Me.MaterialCmb.Properties.LookUpData.KeyValue = Nothing
        End If

        Me.MatCostTxt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Material_Cost"))

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
        Me.TypeEnclosureCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Type_Of_Enclosure")

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

#Region " Key Up Event "
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

    Private Sub ThicknessTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ThicknessTxt.KeyUp
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
    End Sub

    Private Sub BoxCategoryCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles BoxCategoryCmb.CloseUp
        EditFlag = True
    End Sub
#End Region

    Private Sub SpecialBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialBtn.Click
        Dim NewForm As New SelectSpecialForm
        NewForm.Quotation_ID = Quotation_ID
        NewForm.ShowDialog()
    End Sub
End Class



