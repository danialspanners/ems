Imports System.Data
Imports System.Math
Imports VB = Microsoft.VisualBasic
Imports Crownwood.Magic.Common
Imports Crownwood.Magic.Controls
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Data.OleDb
Imports GenericOLEDB


Public Class QuotationForm
    Inherits System.Windows.Forms.Form

    Private ExpandablePanel_Changing As Boolean
    Private Items_PanelChanging As Boolean
    Private Payment_ExpandablePanelChanging As Boolean
    Private Details_PanelChanging As Boolean
    Private PreviousFocusedHandle As Int32
    Public CurrentProductForm_TabIndex As Integer


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
    Public Validity As String
    Public Delivery_Term As String
    Public Service_Type As Integer
    Public CP5_Flg As String
    Public Sign_By As String
    Public Total_Cost_Text As String
    Public Total_Cost_Numeric As Double
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
    ' 27.10.2003 YG Start
    Public OrderType As String
    ' 27.10.2003 YG End
    '****
    Public NextNo As Decimal
#End Region

#Region " QuotationLine variable"
    '** QuotationLine **
    Public Quotation_Line_ID As Integer

    Public BQ_Line_ID As Integer
    Public ItemNo As String
    Public LineNo As Integer
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
    Public UnitPrice As Decimal
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
    Public LineRemarks As String
    Public Product_ID As Integer
    '****
#End Region

    Public Structure GridCol
        Public width As Integer
    End Structure

    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    Public itemdata As System.Data.DataTable
    Public itemdata_col() As GridCol
    Public InititemGrid_flag As Boolean = False
    Public NavdsBox As DataSet              'FOR NAV
    Dim CurrentRow As Integer               'FOR NAVIGATION
    Public CompTotal As Decimal
    Public GrandTotal As Decimal
    Public FormStatus As String             'TO DIFFERENTIATE BETWEEN ADD,EDIT..
    Public FormType As String
    'Public Old_Quotation_ID As Integer      'FOR REJOIN QUOTATION
    Public New_Quotation_ID As Integer
    Public EditFlag As Boolean = False
    Friend WithEvents bottom_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Details_Panel As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Items_Panel As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ValidityTxt As DevExpress.XtraEditors.TextEdit
    Private WithEvents DelTermsCmb As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents PayDetailsCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ClosingTxt As DevExpress.XtraEditors.TextEdit
    Private WithEvents SignByCmb As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents ServiceTypeCmb As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents PriceTillCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents OtherNotesMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NotesMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Payment_ExpandablePanel As DevComponents.DotNetBar.ExpandablePanel
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
    Friend WithEvents UnitPrice_label As System.Windows.Forms.Label
    Private WithEvents BoxCategoryCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemNoTxt As DevExpress.XtraEditors.TextEdit
    Private WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents QtyLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents PanelCostTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents EnclosureTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CopyButton As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompCost_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents itemedit_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents OthersTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents item_TabControl As Crownwood.Magic.Controls.TabControl
    Friend WithEvents ItemTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents BoxGroup As System.Windows.Forms.GroupBox
    Friend WithEvents BoxDescTxt As DevExpress.XtraEditors.MemoEdit
    Private WithEvents CompMarkTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Comp_Markup_Label As System.Windows.Forms.Label
    Private WithEvents CopyFmBxCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents OverallMarkTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Overall_Markup_Label As System.Windows.Forms.Label
    Friend WithEvents EnclosureTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents EnclosureGroup As System.Windows.Forms.GroupBox
    Private WithEvents TypeEnclosureCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Typetxt As DevExpress.XtraEditors.TextEdit
    Private WithEvents ThicknessTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents MaterialCmb As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents MatCostTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents PowerCoatTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents DepthTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents WidthTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents HeightTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CostLbl As System.Windows.Forms.Label
    Friend WithEvents DepthLbl As System.Windows.Forms.Label
    Friend WithEvents WidthLbl As System.Windows.Forms.Label
    Friend WithEvents OthersTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents OthersGroup As System.Windows.Forms.GroupBox
    Friend WithEvents OCEFlbl As System.Windows.Forms.Label
    Private WithEvents PanelTransportTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents InstallTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents IncomingTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents OCEFTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents CopperTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents TransportTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents AccessoryTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents ConcreteBaseTxt As DevExpress.XtraEditors.SpinEdit
    Private WithEvents WiringTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents UnitPrice_Txt As DevExpress.XtraEditors.SpinEdit

    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Addresstxt As DevExpress.XtraEditors.MemoEdit
    Private WithEvents QuoNo_LookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents CreateOCBtn As System.Windows.Forms.Button
    Friend WithEvents Box_Label As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BoxDescTxt_TextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents itemEntry_Panel As System.Windows.Forms.Panel
    Friend WithEvents itemEntry2_Panel As System.Windows.Forms.Panel
    Friend WithEvents Box_Panel As System.Windows.Forms.Panel
    Friend WithEvents Component_Splitter As System.Windows.Forms.Splitter
    Friend WithEvents Item_GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Product_Label As System.Windows.Forms.Label
    Private WithEvents Product_cmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents project_XtraButton As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents consult_XtraButton As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents contact_XtraButton As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents cust_XtraButton As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents New_Button As System.Windows.Forms.Button
    Friend WithEvents Button_Panel As System.Windows.Forms.Panel
    Public MsgBoxFlag As Boolean = True

    Private Edited As Boolean
    Private LineEdited As Boolean
    Friend WithEvents RemarksTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Remarks_MemoEdit As DevExpress.XtraEditors.MemoEdit
    Private OnLoading As Boolean
    Friend WithEvents Revise_Button As System.Windows.Forms.Button
    Friend WithEvents Quotation_ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuotationCopy_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotationDelete_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Option_Button As System.Windows.Forms.CheckBox
    Friend WithEvents item_ContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Paste_MenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents item_controlpanel As System.Windows.Forms.Panel
    Friend WithEvents item_Panel As System.Windows.Forms.Panel
    Friend WithEvents item_moveup_Button As System.Windows.Forms.Button
    Friend WithEvents item_multiselect_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents item_movedown_Button As System.Windows.Forms.Button
    Friend WithEvents Copy_MenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents item_bottom_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrandTotalTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GrandTotal_Label As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents XtraButton2 As DevExpress.XtraEditors.Controls.XtraButton


    Private OnLineLoading As Boolean


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, _
                    Optional ByVal pQuotation_ID As Integer = 0, Optional ByVal pOrder_Type As String = Nothing)
        MyBase.New()

        Edited = False
        LineEdited = False
        CurrentProductForm_TabIndex = 0

        FormStatus = pStatus
        'If Not pOld_Quotation_ID = 0 Then
        ' Old_Quotation_ID = pOld_Quotation_ID
        'End If

        If Not pQuotation_ID = 0 Then
            Quotation_ID = pQuotation_ID
        End If
        If pOrder_Type = Nothing Then
            OrderType = "0"
        Else
            OrderType = pOrder_Type
        End If

        'This call is required by the Windows Form Designer.


        Payment_ExpandablePanelChanging = False
        Details_PanelChanging = False
        Items_PanelChanging = False

        ExpandablePanel_Changing = True
        InitializeComponent()

        Edited = False
        LineEdited = False

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
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Edit As System.Windows.Forms.MenuItem
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RefQuoNoTxt As System.Windows.Forms.Label
    Private WithEvents QuoDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents QuoNoTxt As DevExpress.XtraEditors.TextEdit
    Private WithEvents ProjectCmb As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents StatusCmb As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents ContLookup As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents CustLookup As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents ProjectTitleCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents ConsultantCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SaveQuoBtn As System.Windows.Forms.Button
    Friend WithEvents DispatchBtn As System.Windows.Forms.Button
    Friend WithEvents SpecialBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Component = New Crownwood.Magic.Controls.TabPage
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Edit = New System.Windows.Forms.MenuItem
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cust_XtraButton = New DevExpress.XtraEditors.Controls.XtraButton
        Me.contact_XtraButton = New DevExpress.XtraEditors.Controls.XtraButton
        Me.consult_XtraButton = New DevExpress.XtraEditors.Controls.XtraButton
        Me.project_XtraButton = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Addresstxt = New DevExpress.XtraEditors.MemoEdit
        Me.ConsultantCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.ProjectTitleCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.StatusCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.StatusLbl = New System.Windows.Forms.Label
        Me.QuoDate = New DevExpress.XtraEditors.DateEdit
        Me.ProjectCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ContLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.CustLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.CP5Chk = New System.Windows.Forms.CheckBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.CP5Lbl = New System.Windows.Forms.Label
        Me.ProjectLbl = New System.Windows.Forms.Label
        Me.AddressLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateLbl = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.RefQuoNoTxt = New System.Windows.Forms.Label
        Me.QuoNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.QuoNoLbl = New System.Windows.Forms.Label
        Me.SaveQuoBtn = New System.Windows.Forms.Button
        Me.DispatchBtn = New System.Windows.Forms.Button
        Me.SpecialBtn = New System.Windows.Forms.Button
        Me.CloseBtn = New System.Windows.Forms.Button
        Me.bottom_Panel = New System.Windows.Forms.Panel
        Me.Button_Panel = New System.Windows.Forms.Panel
        Me.CreateOCBtn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Option_Button = New System.Windows.Forms.CheckBox
        Me.Revise_Button = New System.Windows.Forms.Button
        Me.New_Button = New System.Windows.Forms.Button
        Me.QuoNo_LookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.Details_Panel = New DevComponents.DotNetBar.ExpandablePanel
        Me.Items_Panel = New DevComponents.DotNetBar.ExpandablePanel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.itemedit_Panel = New System.Windows.Forms.Panel
        Me.item_Panel = New System.Windows.Forms.Panel
        Me.Item_GridControl = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.item_controlpanel = New System.Windows.Forms.Panel
        Me.item_movedown_Button = New System.Windows.Forms.Button
        Me.item_moveup_Button = New System.Windows.Forms.Button
        Me.item_multiselect_CheckBox = New System.Windows.Forms.CheckBox
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Box_Panel = New System.Windows.Forms.Panel
        Me.CompGrid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Component_Splitter = New System.Windows.Forms.Splitter
        Me.item_TabControl = New Crownwood.Magic.Controls.TabControl
        Me.ItemTab = New Crownwood.Magic.Controls.TabPage
        Me.BoxGroup = New System.Windows.Forms.GroupBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.BoxDescTxt = New DevExpress.XtraEditors.MemoEdit
        Me.CompMarkTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Comp_Markup_Label = New System.Windows.Forms.Label
        Me.CopyFmBxCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.OverallMarkTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Overall_Markup_Label = New System.Windows.Forms.Label
        Me.EnclosureTab = New Crownwood.Magic.Controls.TabPage
        Me.EnclosureGroup = New System.Windows.Forms.GroupBox
        Me.TypeEnclosureCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Typetxt = New DevExpress.XtraEditors.TextEdit
        Me.ThicknessTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.MaterialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.MatCostTxt = New DevExpress.XtraEditors.SpinEdit
        Me.PowerCoatTxt = New DevExpress.XtraEditors.SpinEdit
        Me.DepthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WidthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.HeightTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CostLbl = New System.Windows.Forms.Label
        Me.DepthLbl = New System.Windows.Forms.Label
        Me.WidthLbl = New System.Windows.Forms.Label
        Me.OthersTab = New Crownwood.Magic.Controls.TabPage
        Me.OthersGroup = New System.Windows.Forms.GroupBox
        Me.OCEFlbl = New System.Windows.Forms.Label
        Me.PanelTransportTxt = New DevExpress.XtraEditors.SpinEdit
        Me.InstallTxt = New DevExpress.XtraEditors.SpinEdit
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
        Me.RemarksTab = New Crownwood.Magic.Controls.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.Remarks_MemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.itemEntry_Panel = New System.Windows.Forms.Panel
        Me.BoxDescTxt_TextEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.ItemNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.itemEntry2_Panel = New System.Windows.Forms.Panel
        Me.UnitPrice_Txt = New DevExpress.XtraEditors.SpinEdit
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.UnitPrice_label = New System.Windows.Forms.Label
        Me.BoxCategoryCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Box_Label = New System.Windows.Forms.Label
        Me.Product_cmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Product_Label = New System.Windows.Forms.Label
        Me.QtyLbl = New System.Windows.Forms.Label
        Me.CompCost_Panel = New System.Windows.Forms.Panel
        Me.OthersTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.CompCostTxt = New DevExpress.XtraEditors.TextEdit
        Me.EnclosureTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.PanelCostTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavFirstBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavNextBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavLastBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.UpdateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavPrevBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.lblNavLocation = New DevExpress.XtraEditors.TextEdit
        Me.DelProdBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CopyButton = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.NotesMemo = New DevExpress.XtraEditors.MemoEdit
        Me.OtherNotesMemo = New DevExpress.XtraEditors.MemoEdit
        Me.PriceTillCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ServiceTypeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.SignByCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ClosingTxt = New DevExpress.XtraEditors.TextEdit
        Me.PayDetailsCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.DelTermsCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ValidityTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Payment_ExpandablePanel = New DevComponents.DotNetBar.ExpandablePanel
        Me.Quotation_ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuotationCopy_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuotationDelete_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.item_ContextMenu = New System.Windows.Forms.ContextMenu
        Me.Copy_MenuItem = New System.Windows.Forms.MenuItem
        Me.Paste_MenuItem = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.item_bottom_Panel = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GrandTotalTxt = New DevExpress.XtraEditors.TextEdit
        Me.GrandTotal_Label = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.XtraButton2 = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bottom_Panel.SuspendLayout()
        Me.Button_Panel.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.QuoNo_LookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Details_Panel.SuspendLayout()
        Me.Items_Panel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.itemedit_Panel.SuspendLayout()
        Me.item_Panel.SuspendLayout()
        CType(Me.Item_GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.item_controlpanel.SuspendLayout()
        Me.Box_Panel.SuspendLayout()
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.item_TabControl.SuspendLayout()
        Me.ItemTab.SuspendLayout()
        Me.BoxGroup.SuspendLayout()
        CType(Me.BoxDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompMarkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopyFmBxCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OverallMarkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnclosureTab.SuspendLayout()
        Me.EnclosureGroup.SuspendLayout()
        CType(Me.TypeEnclosureCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typetxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThicknessTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatCostTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerCoatTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OthersTab.SuspendLayout()
        Me.OthersGroup.SuspendLayout()
        CType(Me.PanelTransportTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomingTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCEFTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopperTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoryTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConcreteBaseTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WiringTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RemarksTab.SuspendLayout()
        CType(Me.Remarks_MemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.itemEntry_Panel.SuspendLayout()
        CType(Me.BoxDescTxt_TextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.itemEntry2_Panel.SuspendLayout()
        CType(Me.UnitPrice_Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxCategoryCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompCost_Panel.SuspendLayout()
        CType(Me.OthersTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompCostTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnclosureTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCostTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNavLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherNotesMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceTillCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceTypeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignByCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosingTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayDetailsCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelTermsCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Payment_ExpandablePanel.SuspendLayout()
        Me.Quotation_ContextMenuStrip.SuspendLayout()
        Me.item_bottom_Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrandTotalTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.Edit, Me.Delete})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Add ..."
        '
        'Edit
        '
        Me.Edit.Index = 1
        Me.Edit.Text = "Edit ..."
        '
        'Delete
        '
        Me.Delete.Index = 2
        Me.Delete.Text = "Delete"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cust_XtraButton)
        Me.GroupBox1.Controls.Add(Me.contact_XtraButton)
        Me.GroupBox1.Controls.Add(Me.consult_XtraButton)
        Me.GroupBox1.Controls.Add(Me.project_XtraButton)
        Me.GroupBox1.Controls.Add(Me.Addresstxt)
        Me.GroupBox1.Controls.Add(Me.ConsultantCmb)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.ProjectTitleCmb)
        Me.GroupBox1.Controls.Add(Me.StatusCmb)
        Me.GroupBox1.Controls.Add(Me.StatusLbl)
        Me.GroupBox1.Controls.Add(Me.QuoDate)
        Me.GroupBox1.Controls.Add(Me.ProjectCmb)
        Me.GroupBox1.Controls.Add(Me.ContLookup)
        Me.GroupBox1.Controls.Add(Me.CustLookup)
        Me.GroupBox1.Controls.Add(Me.CP5Chk)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.CP5Lbl)
        Me.GroupBox1.Controls.Add(Me.ProjectLbl)
        Me.GroupBox1.Controls.Add(Me.AddressLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateLbl)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1263, 114)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cust_XtraButton
        '
        Me.cust_XtraButton.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cust_XtraButton.Enabled = False
        Me.cust_XtraButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cust_XtraButton.Image = Nothing
        Me.cust_XtraButton.Location = New System.Drawing.Point(264, 19)
        Me.cust_XtraButton.Name = "cust_XtraButton"
        Me.cust_XtraButton.Size = New System.Drawing.Size(17, 19)
        Me.cust_XtraButton.TabIndex = 107
        Me.cust_XtraButton.Text = "+"
        '
        'contact_XtraButton
        '
        Me.contact_XtraButton.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.contact_XtraButton.Enabled = False
        Me.contact_XtraButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact_XtraButton.Image = Nothing
        Me.contact_XtraButton.Location = New System.Drawing.Point(525, 20)
        Me.contact_XtraButton.Name = "contact_XtraButton"
        Me.contact_XtraButton.Size = New System.Drawing.Size(17, 19)
        Me.contact_XtraButton.TabIndex = 106
        Me.contact_XtraButton.Text = "+"
        '
        'consult_XtraButton
        '
        Me.consult_XtraButton.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.consult_XtraButton.Enabled = False
        Me.consult_XtraButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consult_XtraButton.Image = Nothing
        Me.consult_XtraButton.Location = New System.Drawing.Point(584, 83)
        Me.consult_XtraButton.Name = "consult_XtraButton"
        Me.consult_XtraButton.Size = New System.Drawing.Size(17, 19)
        Me.consult_XtraButton.TabIndex = 105
        Me.consult_XtraButton.Text = "+"
        '
        'project_XtraButton
        '
        Me.project_XtraButton.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.project_XtraButton.Enabled = False
        Me.project_XtraButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.project_XtraButton.Image = Nothing
        Me.project_XtraButton.Location = New System.Drawing.Point(537, 52)
        Me.project_XtraButton.Name = "project_XtraButton"
        Me.project_XtraButton.Size = New System.Drawing.Size(17, 19)
        Me.project_XtraButton.TabIndex = 103
        Me.project_XtraButton.Text = "+"
        '
        'Addresstxt
        '
        Me.Addresstxt.Location = New System.Drawing.Point(618, 19)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Addresstxt.Properties.ReadOnly = True
        Me.Addresstxt.Properties.WordWrap = False
        Me.Addresstxt.Size = New System.Drawing.Size(397, 23)
        Me.Addresstxt.TabIndex = 102
        '
        'ConsultantCmb
        '
        Me.ConsultantCmb.Location = New System.Drawing.Point(364, 82)
        Me.ConsultantCmb.Name = "ConsultantCmb"
        Me.ConsultantCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ConsultantCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ConsultantCmb.Properties.NullString = ""
        Me.ConsultantCmb.Properties.PopupWidth = 218
        Me.ConsultantCmb.Size = New System.Drawing.Size(218, 23)
        Me.ConsultantCmb.TabIndex = 40
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(293, 86)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Consultant :"
        '
        'ProjectTitleCmb
        '
        Me.ProjectTitleCmb.Location = New System.Drawing.Point(187, 50)
        Me.ProjectTitleCmb.Name = "ProjectTitleCmb"
        Me.ProjectTitleCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectTitleCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectTitleCmb.Properties.NullString = ""
        Me.ProjectTitleCmb.Properties.PopupWidth = 376
        Me.ProjectTitleCmb.Size = New System.Drawing.Size(348, 23)
        Me.ProjectTitleCmb.TabIndex = 38
        '
        'StatusCmb
        '
        Me.StatusCmb.Location = New System.Drawing.Point(813, 49)
        Me.StatusCmb.Name = "StatusCmb"
        Me.StatusCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton("", False, DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, Nothing, 5, System.Windows.Forms.HorizontalAlignment.Center, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, DevExpress.XtraEditors.Controls.BorderStyles.[Default]))
        Me.StatusCmb.Properties.NullString = ""
        Me.StatusCmb.Properties.ReadOnly = True
        Me.StatusCmb.Size = New System.Drawing.Size(113, 23)
        Me.StatusCmb.TabIndex = 4
        '
        'StatusLbl
        '
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(760, 53)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(59, 16)
        Me.StatusLbl.TabIndex = 16
        Me.StatusLbl.Text = "* Status :"
        '
        'QuoDate
        '
        Me.QuoDate.DateTime = New Date(CType(0, Long))
        Me.QuoDate.Location = New System.Drawing.Point(645, 50)
        Me.QuoDate.Name = "QuoDate"
        Me.QuoDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuoDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.QuoDate.Properties.MaskData.EditMask = "99-99-0000"
        Me.QuoDate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.QuoDate.Size = New System.Drawing.Size(107, 23)
        Me.QuoDate.TabIndex = 34
        '
        'ProjectCmb
        '
        Me.ProjectCmb.Location = New System.Drawing.Point(71, 50)
        Me.ProjectCmb.Name = "ProjectCmb"
        Me.ProjectCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectCmb.Properties.NullString = ""
        Me.ProjectCmb.Size = New System.Drawing.Size(110, 23)
        Me.ProjectCmb.TabIndex = 7
        '
        'ContLookup
        '
        Me.ContLookup.Location = New System.Drawing.Point(391, 19)
        Me.ContLookup.Name = "ContLookup"
        Me.ContLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContLookup.Properties.NullString = ""
        Me.ContLookup.Properties.PopupWidth = 152
        Me.ContLookup.Size = New System.Drawing.Size(128, 23)
        Me.ContLookup.TabIndex = 5
        '
        'CustLookup
        '
        Me.CustLookup.Location = New System.Drawing.Point(74, 19)
        Me.CustLookup.Name = "CustLookup"
        Me.CustLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustLookup.Properties.NullString = ""
        Me.CustLookup.Properties.PopupWidth = 304
        Me.CustLookup.Size = New System.Drawing.Size(184, 23)
        Me.CustLookup.TabIndex = 3
        '
        'CP5Chk
        '
        Me.CP5Chk.Location = New System.Drawing.Point(264, 86)
        Me.CP5Chk.Name = "CP5Chk"
        Me.CP5Chk.Size = New System.Drawing.Size(16, 16)
        Me.CP5Chk.TabIndex = 9
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(228, 86)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(32, 16)
        Me.Label39.TabIndex = 32
        Me.Label39.Text = "CP5"
        '
        'CP5Lbl
        '
        Me.CP5Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP5Lbl.Location = New System.Drawing.Point(14, 85)
        Me.CP5Lbl.Name = "CP5Lbl"
        Me.CP5Lbl.Size = New System.Drawing.Size(216, 16)
        Me.CP5Lbl.TabIndex = 31
        Me.CP5Lbl.Text = "Statutory And Regulatory Requirement :"
        '
        'ProjectLbl
        '
        Me.ProjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectLbl.Location = New System.Drawing.Point(14, 52)
        Me.ProjectLbl.Name = "ProjectLbl"
        Me.ProjectLbl.Size = New System.Drawing.Size(56, 16)
        Me.ProjectLbl.TabIndex = 27
        Me.ProjectLbl.Text = "* Project :"
        Me.ProjectLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AddressLbl
        '
        Me.AddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLbl.Location = New System.Drawing.Point(562, 20)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(197, 16)
        Me.AddressLbl.TabIndex = 20
        Me.AddressLbl.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "* Contact Person :"
        '
        'DateLbl
        '
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(589, 52)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(51, 16)
        Me.DateLbl.TabIndex = 13
        Me.DateLbl.Text = "* Date :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(7, 21)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(95, 16)
        Me.CustNameLbl.TabIndex = 10
        Me.CustNameLbl.Text = "* Customer:"
        '
        'RefQuoNoTxt
        '
        Me.RefQuoNoTxt.Location = New System.Drawing.Point(407, -22)
        Me.RefQuoNoTxt.Name = "RefQuoNoTxt"
        Me.RefQuoNoTxt.Size = New System.Drawing.Size(144, 19)
        Me.RefQuoNoTxt.TabIndex = 37
        Me.RefQuoNoTxt.Visible = False
        '
        'QuoNoTxt
        '
        Me.QuoNoTxt.Location = New System.Drawing.Point(100, 10)
        Me.QuoNoTxt.Name = "QuoNoTxt"
        Me.QuoNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuoNoTxt.Size = New System.Drawing.Size(157, 19)
        Me.QuoNoTxt.TabIndex = 33
        '
        'QuoNoLbl
        '
        Me.QuoNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuoNoLbl.Location = New System.Drawing.Point(11, 11)
        Me.QuoNoLbl.Name = "QuoNoLbl"
        Me.QuoNoLbl.Size = New System.Drawing.Size(83, 16)
        Me.QuoNoLbl.TabIndex = 11
        Me.QuoNoLbl.Text = "Quotation No :"
        '
        'SaveQuoBtn
        '
        Me.SaveQuoBtn.Location = New System.Drawing.Point(16, 16)
        Me.SaveQuoBtn.Name = "SaveQuoBtn"
        Me.SaveQuoBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveQuoBtn.TabIndex = 20
        Me.SaveQuoBtn.Text = "&Save"
        '
        'DispatchBtn
        '
        Me.DispatchBtn.Location = New System.Drawing.Point(88, 16)
        Me.DispatchBtn.Name = "DispatchBtn"
        Me.DispatchBtn.Size = New System.Drawing.Size(64, 32)
        Me.DispatchBtn.TabIndex = 21
        Me.DispatchBtn.Text = "&Dispatch"
        '
        'SpecialBtn
        '
        Me.SpecialBtn.Location = New System.Drawing.Point(160, 16)
        Me.SpecialBtn.Name = "SpecialBtn"
        Me.SpecialBtn.Size = New System.Drawing.Size(64, 32)
        Me.SpecialBtn.TabIndex = 22
        Me.SpecialBtn.Text = "S&pecial"
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(15, 11)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'bottom_Panel
        '
        Me.bottom_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bottom_Panel.Controls.Add(Me.Button_Panel)
        Me.bottom_Panel.Controls.Add(Me.Panel8)
        Me.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom_Panel.Location = New System.Drawing.Point(0, 658)
        Me.bottom_Panel.Name = "bottom_Panel"
        Me.bottom_Panel.Size = New System.Drawing.Size(1291, 62)
        Me.bottom_Panel.TabIndex = 24
        '
        'Button_Panel
        '
        Me.Button_Panel.Controls.Add(Me.SaveQuoBtn)
        Me.Button_Panel.Controls.Add(Me.SpecialBtn)
        Me.Button_Panel.Controls.Add(Me.CreateOCBtn)
        Me.Button_Panel.Controls.Add(Me.DispatchBtn)
        Me.Button_Panel.Controls.Add(Me.Button1)
        Me.Button_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Button_Panel.Name = "Button_Panel"
        Me.Button_Panel.Size = New System.Drawing.Size(549, 58)
        Me.Button_Panel.TabIndex = 27
        '
        'CreateOCBtn
        '
        Me.CreateOCBtn.Enabled = False
        Me.CreateOCBtn.Location = New System.Drawing.Point(304, 16)
        Me.CreateOCBtn.Name = "CreateOCBtn"
        Me.CreateOCBtn.Size = New System.Drawing.Size(118, 32)
        Me.CreateOCBtn.TabIndex = 25
        Me.CreateOCBtn.Text = "Create OC"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 32)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Print"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.CloseBtn)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(1193, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(94, 58)
        Me.Panel8.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Option_Button)
        Me.Panel2.Controls.Add(Me.Revise_Button)
        Me.Panel2.Controls.Add(Me.New_Button)
        Me.Panel2.Controls.Add(Me.RefQuoNoTxt)
        Me.Panel2.Controls.Add(Me.QuoNoLbl)
        Me.Panel2.Controls.Add(Me.QuoNo_LookUpEdit)
        Me.Panel2.Controls.Add(Me.QuoNoTxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1291, 40)
        Me.Panel2.TabIndex = 25
        '
        'Option_Button
        '
        Me.Option_Button.Appearance = System.Windows.Forms.Appearance.Button
        Me.Option_Button.Location = New System.Drawing.Point(407, 8)
        Me.Option_Button.Name = "Option_Button"
        Me.Option_Button.Size = New System.Drawing.Size(65, 24)
        Me.Option_Button.TabIndex = 42
        Me.Option_Button.Text = "  Options  "
        Me.Option_Button.UseVisualStyleBackColor = True
        '
        'Revise_Button
        '
        Me.Revise_Button.Location = New System.Drawing.Point(332, 8)
        Me.Revise_Button.Name = "Revise_Button"
        Me.Revise_Button.Size = New System.Drawing.Size(67, 23)
        Me.Revise_Button.TabIndex = 40
        Me.Revise_Button.Text = "Revise"
        '
        'New_Button
        '
        Me.New_Button.Location = New System.Drawing.Point(269, 8)
        Me.New_Button.Name = "New_Button"
        Me.New_Button.Size = New System.Drawing.Size(52, 23)
        Me.New_Button.TabIndex = 39
        Me.New_Button.Text = "New"
        '
        'QuoNo_LookUpEdit
        '
        Me.QuoNo_LookUpEdit.Location = New System.Drawing.Point(101, 8)
        Me.QuoNo_LookUpEdit.Name = "QuoNo_LookUpEdit"
        Me.QuoNo_LookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuoNo_LookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.QuoNo_LookUpEdit.Properties.NullString = ""
        Me.QuoNo_LookUpEdit.Properties.PopupWidth = 304
        Me.QuoNo_LookUpEdit.Size = New System.Drawing.Size(157, 23)
        Me.QuoNo_LookUpEdit.TabIndex = 38
        '
        'Details_Panel
        '
        Me.Details_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me.Details_Panel.Controls.Add(Me.GroupBox1)
        Me.Details_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Details_Panel.ExpandButtonVisible = False
        Me.Details_Panel.Location = New System.Drawing.Point(0, 40)
        Me.Details_Panel.Name = "Details_Panel"
        Me.Details_Panel.ShowFocusRectangle = True
        Me.Details_Panel.Size = New System.Drawing.Size(1291, 146)
        Me.Details_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Details_Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Details_Panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Details_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.Details_Panel.Style.GradientAngle = 90
        Me.Details_Panel.TabIndex = 28
        Me.Details_Panel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Details_Panel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Details_Panel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Details_Panel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Details_Panel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Details_Panel.TitleStyle.GradientAngle = 90
        Me.Details_Panel.TitleStyle.MarginLeft = 10
        Me.Details_Panel.TitleText = "Details"
        '
        'Items_Panel
        '
        Me.Items_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me.Items_Panel.Controls.Add(Me.Panel5)
        Me.Items_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Items_Panel.Expanded = False
        Me.Items_Panel.ExpandedBounds = New System.Drawing.Rectangle(0, 228, 1049, 404)
        Me.Items_Panel.Location = New System.Drawing.Point(0, 186)
        Me.Items_Panel.Name = "Items_Panel"
        Me.Items_Panel.ShowFocusRectangle = True
        Me.Items_Panel.Size = New System.Drawing.Size(1291, 447)
        Me.Items_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Items_Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Items_Panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Items_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Items_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.Items_Panel.Style.GradientAngle = 90
        Me.Items_Panel.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.Items_Panel.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.Items_Panel.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.Items_Panel.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.Items_Panel.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText
        Me.Items_Panel.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.Items_Panel.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground
        Me.Items_Panel.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2
        Me.Items_Panel.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder
        Me.Items_Panel.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText
        Me.Items_Panel.TabIndex = 29
        Me.Items_Panel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Items_Panel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Items_Panel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Items_Panel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Items_Panel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Items_Panel.TitleStyle.GradientAngle = 90
        Me.Items_Panel.TitleStyle.MarginLeft = 10
        Me.Items_Panel.TitleText = "Items"
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.itemedit_Panel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 26)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1291, 421)
        Me.Panel5.TabIndex = 89
        '
        'itemedit_Panel
        '
        Me.itemedit_Panel.AutoScroll = True
        Me.itemedit_Panel.Controls.Add(Me.Box_Panel)
        Me.itemedit_Panel.Controls.Add(Me.Splitter2)
        Me.itemedit_Panel.Controls.Add(Me.item_Panel)
        Me.itemedit_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemedit_Panel.Location = New System.Drawing.Point(0, 0)
        Me.itemedit_Panel.Name = "itemedit_Panel"
        Me.itemedit_Panel.Size = New System.Drawing.Size(1291, 421)
        Me.itemedit_Panel.TabIndex = 87
        '
        'item_Panel
        '
        Me.item_Panel.Controls.Add(Me.item_bottom_Panel)
        Me.item_Panel.Controls.Add(Me.Item_GridControl)
        Me.item_Panel.Controls.Add(Me.item_controlpanel)
        Me.item_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.item_Panel.Location = New System.Drawing.Point(0, 0)
        Me.item_Panel.Name = "item_Panel"
        Me.item_Panel.Size = New System.Drawing.Size(673, 421)
        Me.item_Panel.TabIndex = 93
        '
        'Item_GridControl
        '
        Me.Item_GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Item_GridControl.EditorsRepository = Me.PersistentRepository1
        Me.Item_GridControl.Location = New System.Drawing.Point(0, 30)
        Me.Item_GridControl.MainView = Me.GridView2
        Me.Item_GridControl.Name = "Item_GridControl"
        Me.Item_GridControl.Size = New System.Drawing.Size(673, 391)
        Me.Item_GridControl.TabIndex = 91
        '
        'GridView2
        '
        Me.GridView2.BehaviorOptions = CType(((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.MultiSelect) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'item_controlpanel
        '
        Me.item_controlpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.item_controlpanel.Controls.Add(Me.Panel4)
        Me.item_controlpanel.Controls.Add(Me.UnitPrice_Txt)
        Me.item_controlpanel.Controls.Add(Me.item_movedown_Button)
        Me.item_controlpanel.Controls.Add(Me.QtyTxt)
        Me.item_controlpanel.Controls.Add(Me.UnitPrice_label)
        Me.item_controlpanel.Controls.Add(Me.AddBtn)
        Me.item_controlpanel.Controls.Add(Me.item_moveup_Button)
        Me.item_controlpanel.Controls.Add(Me.NavFirstBtn)
        Me.item_controlpanel.Controls.Add(Me.NavNextBtn)
        Me.item_controlpanel.Controls.Add(Me.CopyButton)
        Me.item_controlpanel.Controls.Add(Me.NavLastBtn)
        Me.item_controlpanel.Controls.Add(Me.QtyLbl)
        Me.item_controlpanel.Controls.Add(Me.UpdateBtn)
        Me.item_controlpanel.Controls.Add(Me.NavPrevBtn)
        Me.item_controlpanel.Controls.Add(Me.item_multiselect_CheckBox)
        Me.item_controlpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.item_controlpanel.Location = New System.Drawing.Point(0, 0)
        Me.item_controlpanel.Name = "item_controlpanel"
        Me.item_controlpanel.Size = New System.Drawing.Size(673, 30)
        Me.item_controlpanel.TabIndex = 92
        '
        'item_movedown_Button
        '
        Me.item_movedown_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.item_movedown_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_movedown_Button.Location = New System.Drawing.Point(284, 4)
        Me.item_movedown_Button.Name = "item_movedown_Button"
        Me.item_movedown_Button.Size = New System.Drawing.Size(20, 20)
        Me.item_movedown_Button.TabIndex = 2
        Me.item_movedown_Button.Text = "?"
        Me.item_movedown_Button.UseVisualStyleBackColor = True
        '
        'item_moveup_Button
        '
        Me.item_moveup_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.item_moveup_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_moveup_Button.Location = New System.Drawing.Point(258, 4)
        Me.item_moveup_Button.Name = "item_moveup_Button"
        Me.item_moveup_Button.Size = New System.Drawing.Size(20, 20)
        Me.item_moveup_Button.TabIndex = 1
        Me.item_moveup_Button.Text = "?"
        Me.item_moveup_Button.UseVisualStyleBackColor = True
        '
        'item_multiselect_CheckBox
        '
        Me.item_multiselect_CheckBox.AutoSize = True
        Me.item_multiselect_CheckBox.Location = New System.Drawing.Point(12, 7)
        Me.item_multiselect_CheckBox.Name = "item_multiselect_CheckBox"
        Me.item_multiselect_CheckBox.Size = New System.Drawing.Size(81, 17)
        Me.item_multiselect_CheckBox.TabIndex = 0
        Me.item_multiselect_CheckBox.Text = "Multi Select"
        Me.item_multiselect_CheckBox.UseVisualStyleBackColor = True
        Me.item_multiselect_CheckBox.Visible = False
        '
        'Splitter2
        '
        Me.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter2.Location = New System.Drawing.Point(673, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(10, 421)
        Me.Splitter2.TabIndex = 90
        Me.Splitter2.TabStop = False
        '
        'Box_Panel
        '
        Me.Box_Panel.Controls.Add(Me.CompCost_Panel)
        Me.Box_Panel.Controls.Add(Me.CompGrid1)
        Me.Box_Panel.Controls.Add(Me.Component_Splitter)
        Me.Box_Panel.Controls.Add(Me.item_TabControl)
        Me.Box_Panel.Controls.Add(Me.Panel6)
        Me.Box_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Box_Panel.Location = New System.Drawing.Point(683, 0)
        Me.Box_Panel.Name = "Box_Panel"
        Me.Box_Panel.Size = New System.Drawing.Size(608, 421)
        Me.Box_Panel.TabIndex = 89
        '
        'CompGrid1
        '
        Me.CompGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompGrid1.EditorsRepository = Me.PersistentRepository1
        Me.CompGrid1.Location = New System.Drawing.Point(0, 184)
        Me.CompGrid1.MainView = Me.GridView1
        Me.CompGrid1.Name = "CompGrid1"
        Me.CompGrid1.Size = New System.Drawing.Size(608, 237)
        Me.CompGrid1.TabIndex = 85
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
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
        'Component_Splitter
        '
        Me.Component_Splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Component_Splitter.Dock = System.Windows.Forms.DockStyle.Top
        Me.Component_Splitter.Location = New System.Drawing.Point(0, 174)
        Me.Component_Splitter.Name = "Component_Splitter"
        Me.Component_Splitter.Size = New System.Drawing.Size(608, 10)
        Me.Component_Splitter.TabIndex = 87
        Me.Component_Splitter.TabStop = False
        '
        'item_TabControl
        '
        Me.item_TabControl.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.item_TabControl.BoldSelectedPage = False
        Me.item_TabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.item_TabControl.IDEPixelArea = True
        Me.item_TabControl.IDEPixelBorder = False
        Me.item_TabControl.Location = New System.Drawing.Point(0, 36)
        Me.item_TabControl.Name = "item_TabControl"
        Me.item_TabControl.SelectedIndex = 0
        Me.item_TabControl.SelectedTab = Me.ItemTab
        Me.item_TabControl.ShowArrows = False
        Me.item_TabControl.ShowClose = False
        Me.item_TabControl.Size = New System.Drawing.Size(608, 138)
        Me.item_TabControl.TabIndex = 28
        Me.item_TabControl.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.ItemTab, Me.EnclosureTab, Me.OthersTab, Me.RemarksTab})
        '
        'ItemTab
        '
        Me.ItemTab.Controls.Add(Me.BoxGroup)
        Me.ItemTab.Location = New System.Drawing.Point(0, 25)
        Me.ItemTab.Name = "ItemTab"
        Me.ItemTab.Size = New System.Drawing.Size(608, 113)
        Me.ItemTab.TabIndex = 3
        Me.ItemTab.Title = "Box/Item"
        '
        'BoxGroup
        '
        Me.BoxGroup.Controls.Add(Me.Label37)
        Me.BoxGroup.Controls.Add(Me.BoxDescTxt)
        Me.BoxGroup.Controls.Add(Me.CompMarkTxt)
        Me.BoxGroup.Controls.Add(Me.Comp_Markup_Label)
        Me.BoxGroup.Controls.Add(Me.CopyFmBxCmb)
        Me.BoxGroup.Controls.Add(Me.Label17)
        Me.BoxGroup.Controls.Add(Me.OverallMarkTxt)
        Me.BoxGroup.Controls.Add(Me.Overall_Markup_Label)
        Me.BoxGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxGroup.Location = New System.Drawing.Point(0, 0)
        Me.BoxGroup.Name = "BoxGroup"
        Me.BoxGroup.Size = New System.Drawing.Size(608, 113)
        Me.BoxGroup.TabIndex = 0
        Me.BoxGroup.TabStop = False
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(6, 13)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 14)
        Me.Label37.TabIndex = 102
        Me.Label37.Text = "*Desc :"
        '
        'BoxDescTxt
        '
        Me.BoxDescTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BoxDescTxt.Location = New System.Drawing.Point(59, 14)
        Me.BoxDescTxt.Name = "BoxDescTxt"
        Me.BoxDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxDescTxt.Properties.WordWrap = False
        Me.BoxDescTxt.Size = New System.Drawing.Size(372, 83)
        Me.BoxDescTxt.TabIndex = 101
        '
        'CompMarkTxt
        '
        Me.CompMarkTxt.Location = New System.Drawing.Point(541, 60)
        Me.CompMarkTxt.Name = "CompMarkTxt"
        Me.CompMarkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompMarkTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CompMarkTxt.Size = New System.Drawing.Size(42, 19)
        Me.CompMarkTxt.TabIndex = 99
        Me.CompMarkTxt.Text = "0"
        '
        'Comp_Markup_Label
        '
        Me.Comp_Markup_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_Markup_Label.Location = New System.Drawing.Point(439, 63)
        Me.Comp_Markup_Label.Name = "Comp_Markup_Label"
        Me.Comp_Markup_Label.Size = New System.Drawing.Size(96, 16)
        Me.Comp_Markup_Label.TabIndex = 98
        Me.Comp_Markup_Label.Text = "Comp Markup % :"
        '
        'CopyFmBxCmb
        '
        Me.CopyFmBxCmb.Enabled = False
        Me.CopyFmBxCmb.Location = New System.Drawing.Point(658, 46)
        Me.CopyFmBxCmb.Name = "CopyFmBxCmb"
        Me.CopyFmBxCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CopyFmBxCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CopyFmBxCmb.Properties.Enabled = False
        Me.CopyFmBxCmb.Properties.NullString = ""
        Me.CopyFmBxCmb.Size = New System.Drawing.Size(96, 23)
        Me.CopyFmBxCmb.TabIndex = 97
        Me.CopyFmBxCmb.Visible = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(655, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "Copy from box :"
        Me.Label17.Visible = False
        '
        'OverallMarkTxt
        '
        Me.OverallMarkTxt.Location = New System.Drawing.Point(541, 24)
        Me.OverallMarkTxt.Name = "OverallMarkTxt"
        Me.OverallMarkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OverallMarkTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OverallMarkTxt.Size = New System.Drawing.Size(42, 19)
        Me.OverallMarkTxt.TabIndex = 85
        Me.OverallMarkTxt.Text = "1"
        '
        'Overall_Markup_Label
        '
        Me.Overall_Markup_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overall_Markup_Label.Location = New System.Drawing.Point(441, 26)
        Me.Overall_Markup_Label.Name = "Overall_Markup_Label"
        Me.Overall_Markup_Label.Size = New System.Drawing.Size(104, 16)
        Me.Overall_Markup_Label.TabIndex = 90
        Me.Overall_Markup_Label.Text = "Overall Markup  :"
        '
        'EnclosureTab
        '
        Me.EnclosureTab.Controls.Add(Me.EnclosureGroup)
        Me.EnclosureTab.Location = New System.Drawing.Point(0, 25)
        Me.EnclosureTab.Name = "EnclosureTab"
        Me.EnclosureTab.Selected = False
        Me.EnclosureTab.Size = New System.Drawing.Size(608, 113)
        Me.EnclosureTab.TabIndex = 4
        Me.EnclosureTab.Title = "Enclosure"
        Me.EnclosureTab.Visible = False
        '
        'EnclosureGroup
        '
        Me.EnclosureGroup.Controls.Add(Me.TypeEnclosureCmb)
        Me.EnclosureGroup.Controls.Add(Me.Label21)
        Me.EnclosureGroup.Controls.Add(Me.Typetxt)
        Me.EnclosureGroup.Controls.Add(Me.ThicknessTxt)
        Me.EnclosureGroup.Controls.Add(Me.Label20)
        Me.EnclosureGroup.Controls.Add(Me.Label19)
        Me.EnclosureGroup.Controls.Add(Me.Label7)
        Me.EnclosureGroup.Controls.Add(Me.MaterialCmb)
        Me.EnclosureGroup.Controls.Add(Me.MatCostTxt)
        Me.EnclosureGroup.Controls.Add(Me.PowerCoatTxt)
        Me.EnclosureGroup.Controls.Add(Me.DepthTxt)
        Me.EnclosureGroup.Controls.Add(Me.WidthTxt)
        Me.EnclosureGroup.Controls.Add(Me.HeightTxt)
        Me.EnclosureGroup.Controls.Add(Me.Label18)
        Me.EnclosureGroup.Controls.Add(Me.Label6)
        Me.EnclosureGroup.Controls.Add(Me.Label5)
        Me.EnclosureGroup.Controls.Add(Me.CostLbl)
        Me.EnclosureGroup.Controls.Add(Me.DepthLbl)
        Me.EnclosureGroup.Controls.Add(Me.WidthLbl)
        Me.EnclosureGroup.Enabled = False
        Me.EnclosureGroup.Location = New System.Drawing.Point(2, 1)
        Me.EnclosureGroup.Name = "EnclosureGroup"
        Me.EnclosureGroup.Size = New System.Drawing.Size(590, 111)
        Me.EnclosureGroup.TabIndex = 0
        Me.EnclosureGroup.TabStop = False
        '
        'TypeEnclosureCmb
        '
        Me.TypeEnclosureCmb.Location = New System.Drawing.Point(120, 78)
        Me.TypeEnclosureCmb.Name = "TypeEnclosureCmb"
        Me.TypeEnclosureCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TypeEnclosureCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TypeEnclosureCmb.Properties.NullString = ""
        Me.TypeEnclosureCmb.Size = New System.Drawing.Size(88, 23)
        Me.TypeEnclosureCmb.TabIndex = 154
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 78)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 14)
        Me.Label21.TabIndex = 153
        Me.Label21.Text = "* Type of Enclosure :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Typetxt
        '
        Me.Typetxt.Location = New System.Drawing.Point(120, 58)
        Me.Typetxt.Name = "Typetxt"
        Me.Typetxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Typetxt.Size = New System.Drawing.Size(72, 19)
        Me.Typetxt.TabIndex = 152
        '
        'ThicknessTxt
        '
        Me.ThicknessTxt.Location = New System.Drawing.Point(349, 59)
        Me.ThicknessTxt.Name = "ThicknessTxt"
        Me.ThicknessTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ThicknessTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ThicknessTxt.Size = New System.Drawing.Size(48, 19)
        Me.ThicknessTxt.TabIndex = 151
        Me.ThicknessTxt.Text = "0"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(216, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 14)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = "Thickness :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 14)
        Me.Label19.TabIndex = 149
        Me.Label19.Text = "Type :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(403, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 16)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "(eg. 1200mm x 2440mm)"
        '
        'MaterialCmb
        '
        Me.MaterialCmb.Location = New System.Drawing.Point(120, 38)
        Me.MaterialCmb.Name = "MaterialCmb"
        Me.MaterialCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MaterialCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialCmb.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(23))
        Me.MaterialCmb.Properties.NullString = ""
        Me.MaterialCmb.Size = New System.Drawing.Size(88, 23)
        Me.MaterialCmb.TabIndex = 137
        '
        'MatCostTxt
        '
        Me.MatCostTxt.Location = New System.Drawing.Point(517, 39)
        Me.MatCostTxt.Name = "MatCostTxt"
        Me.MatCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MatCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MatCostTxt.Size = New System.Drawing.Size(64, 19)
        Me.MatCostTxt.TabIndex = 139
        Me.MatCostTxt.Text = "0"
        '
        'PowerCoatTxt
        '
        Me.PowerCoatTxt.Location = New System.Drawing.Point(349, 39)
        Me.PowerCoatTxt.Name = "PowerCoatTxt"
        Me.PowerCoatTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PowerCoatTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PowerCoatTxt.Size = New System.Drawing.Size(48, 19)
        Me.PowerCoatTxt.TabIndex = 138
        Me.PowerCoatTxt.Text = "0"
        '
        'DepthTxt
        '
        Me.DepthTxt.Location = New System.Drawing.Point(517, 19)
        Me.DepthTxt.Name = "DepthTxt"
        Me.DepthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DepthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DepthTxt.Size = New System.Drawing.Size(64, 19)
        Me.DepthTxt.TabIndex = 136
        Me.DepthTxt.Text = "0"
        '
        'WidthTxt
        '
        Me.WidthTxt.Location = New System.Drawing.Point(349, 19)
        Me.WidthTxt.Name = "WidthTxt"
        Me.WidthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WidthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WidthTxt.Size = New System.Drawing.Size(48, 19)
        Me.WidthTxt.TabIndex = 135
        Me.WidthTxt.Text = "0"
        '
        'HeightTxt
        '
        Me.HeightTxt.Location = New System.Drawing.Point(120, 18)
        Me.HeightTxt.Name = "HeightTxt"
        Me.HeightTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.HeightTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HeightTxt.Size = New System.Drawing.Size(48, 19)
        Me.HeightTxt.TabIndex = 134
        Me.HeightTxt.Text = "0"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(413, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 147
        Me.Label18.Text = "* Material Cost ($) :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 14)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "Material :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 14)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "* Height (mm) :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CostLbl
        '
        Me.CostLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostLbl.Location = New System.Drawing.Point(226, 39)
        Me.CostLbl.Name = "CostLbl"
        Me.CostLbl.Size = New System.Drawing.Size(120, 14)
        Me.CostLbl.TabIndex = 143
        Me.CostLbl.Text = "*Powder Coat ($/m2) :"
        Me.CostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DepthLbl
        '
        Me.DepthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepthLbl.Location = New System.Drawing.Point(413, 21)
        Me.DepthLbl.Name = "DepthLbl"
        Me.DepthLbl.Size = New System.Drawing.Size(80, 14)
        Me.DepthLbl.TabIndex = 142
        Me.DepthLbl.Text = "* Depth (mm) :"
        '
        'WidthLbl
        '
        Me.WidthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthLbl.Location = New System.Drawing.Point(245, 21)
        Me.WidthLbl.Name = "WidthLbl"
        Me.WidthLbl.Size = New System.Drawing.Size(112, 14)
        Me.WidthLbl.TabIndex = 141
        Me.WidthLbl.Text = "* Length (mm) :"
        Me.WidthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OthersTab
        '
        Me.OthersTab.Controls.Add(Me.OthersGroup)
        Me.OthersTab.Location = New System.Drawing.Point(0, 25)
        Me.OthersTab.Name = "OthersTab"
        Me.OthersTab.Selected = False
        Me.OthersTab.Size = New System.Drawing.Size(608, 113)
        Me.OthersTab.TabIndex = 5
        Me.OthersTab.Title = "Others"
        Me.OthersTab.Visible = False
        '
        'OthersGroup
        '
        Me.OthersGroup.Controls.Add(Me.OCEFlbl)
        Me.OthersGroup.Controls.Add(Me.PanelTransportTxt)
        Me.OthersGroup.Controls.Add(Me.InstallTxt)
        Me.OthersGroup.Controls.Add(Me.IncomingTxt)
        Me.OthersGroup.Controls.Add(Me.OCEFTxt)
        Me.OthersGroup.Controls.Add(Me.Label4)
        Me.OthersGroup.Controls.Add(Me.Label2)
        Me.OthersGroup.Controls.Add(Me.Label1)
        Me.OthersGroup.Controls.Add(Me.CopperTxt)
        Me.OthersGroup.Controls.Add(Me.TransportTxt)
        Me.OthersGroup.Controls.Add(Me.AccessoryTxt)
        Me.OthersGroup.Controls.Add(Me.ConcreteBaseTxt)
        Me.OthersGroup.Controls.Add(Me.WiringTxt)
        Me.OthersGroup.Controls.Add(Me.Label24)
        Me.OthersGroup.Controls.Add(Me.Label23)
        Me.OthersGroup.Controls.Add(Me.Label16)
        Me.OthersGroup.Controls.Add(Me.Label15)
        Me.OthersGroup.Controls.Add(Me.Label14)
        Me.OthersGroup.Enabled = False
        Me.OthersGroup.Location = New System.Drawing.Point(2, 1)
        Me.OthersGroup.Name = "OthersGroup"
        Me.OthersGroup.Size = New System.Drawing.Size(576, 111)
        Me.OthersGroup.TabIndex = 0
        Me.OthersGroup.TabStop = False
        '
        'OCEFlbl
        '
        Me.OCEFlbl.Location = New System.Drawing.Point(12, 70)
        Me.OCEFlbl.Name = "OCEFlbl"
        Me.OCEFlbl.Size = New System.Drawing.Size(48, 16)
        Me.OCEFlbl.TabIndex = 78
        Me.OCEFlbl.Text = "OC/EF :"
        Me.OCEFlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelTransportTxt
        '
        Me.PanelTransportTxt.Location = New System.Drawing.Point(360, 69)
        Me.PanelTransportTxt.Name = "PanelTransportTxt"
        Me.PanelTransportTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelTransportTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelTransportTxt.Size = New System.Drawing.Size(64, 19)
        Me.PanelTransportTxt.TabIndex = 76
        Me.PanelTransportTxt.Text = "0"
        '
        'InstallTxt
        '
        Me.InstallTxt.Location = New System.Drawing.Point(504, 69)
        Me.InstallTxt.Name = "InstallTxt"
        Me.InstallTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstallTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.InstallTxt.Size = New System.Drawing.Size(64, 19)
        Me.InstallTxt.TabIndex = 77
        Me.InstallTxt.Text = "0"
        '
        'IncomingTxt
        '
        Me.IncomingTxt.Location = New System.Drawing.Point(200, 69)
        Me.IncomingTxt.Name = "IncomingTxt"
        Me.IncomingTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IncomingTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.IncomingTxt.Size = New System.Drawing.Size(64, 19)
        Me.IncomingTxt.TabIndex = 75
        Me.IncomingTxt.Text = "0"
        '
        'OCEFTxt
        '
        Me.OCEFTxt.Location = New System.Drawing.Point(64, 69)
        Me.OCEFTxt.Name = "OCEFTxt"
        Me.OCEFTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OCEFTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OCEFTxt.Size = New System.Drawing.Size(64, 19)
        Me.OCEFTxt.TabIndex = 74
        Me.OCEFTxt.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(440, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Installation :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(272, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Panel Transport :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(144, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Incoming :"
        '
        'CopperTxt
        '
        Me.CopperTxt.Location = New System.Drawing.Point(448, 17)
        Me.CopperTxt.Name = "CopperTxt"
        Me.CopperTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CopperTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CopperTxt.Size = New System.Drawing.Size(80, 19)
        Me.CopperTxt.TabIndex = 70
        Me.CopperTxt.Text = "0"
        '
        'TransportTxt
        '
        Me.TransportTxt.Location = New System.Drawing.Point(288, 37)
        Me.TransportTxt.Name = "TransportTxt"
        Me.TransportTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TransportTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TransportTxt.Size = New System.Drawing.Size(80, 19)
        Me.TransportTxt.TabIndex = 69
        Me.TransportTxt.Text = "0"
        '
        'AccessoryTxt
        '
        Me.AccessoryTxt.Location = New System.Drawing.Point(288, 17)
        Me.AccessoryTxt.Name = "AccessoryTxt"
        Me.AccessoryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AccessoryTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AccessoryTxt.Size = New System.Drawing.Size(80, 19)
        Me.AccessoryTxt.TabIndex = 67
        Me.AccessoryTxt.Text = "0"
        '
        'ConcreteBaseTxt
        '
        Me.ConcreteBaseTxt.Location = New System.Drawing.Point(112, 37)
        Me.ConcreteBaseTxt.Name = "ConcreteBaseTxt"
        Me.ConcreteBaseTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ConcreteBaseTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ConcreteBaseTxt.Size = New System.Drawing.Size(64, 19)
        Me.ConcreteBaseTxt.TabIndex = 68
        Me.ConcreteBaseTxt.Text = "0"
        '
        'WiringTxt
        '
        Me.WiringTxt.Location = New System.Drawing.Point(112, 17)
        Me.WiringTxt.Name = "WiringTxt"
        Me.WiringTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WiringTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WiringTxt.Size = New System.Drawing.Size(64, 19)
        Me.WiringTxt.TabIndex = 66
        Me.WiringTxt.Text = "0"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label24.Location = New System.Drawing.Point(216, 39)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Transport :"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 16)
        Me.Label23.TabIndex = 64
        Me.Label23.Text = "Concrete Base :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label16.Location = New System.Drawing.Point(392, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Copper :"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label15.Location = New System.Drawing.Point(216, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Accessory :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Wiring :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemarksTab
        '
        Me.RemarksTab.Controls.Add(Me.Label10)
        Me.RemarksTab.Controls.Add(Me.Remarks_MemoEdit)
        Me.RemarksTab.Location = New System.Drawing.Point(0, 25)
        Me.RemarksTab.Name = "RemarksTab"
        Me.RemarksTab.Selected = False
        Me.RemarksTab.Size = New System.Drawing.Size(608, 113)
        Me.RemarksTab.TabIndex = 6
        Me.RemarksTab.Title = "Remarks"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 14)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Remarks : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Remarks_MemoEdit
        '
        Me.Remarks_MemoEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Remarks_MemoEdit.Location = New System.Drawing.Point(76, 15)
        Me.Remarks_MemoEdit.Name = "Remarks_MemoEdit"
        Me.Remarks_MemoEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Remarks_MemoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Remarks_MemoEdit.Properties.WordWrap = False
        Me.Remarks_MemoEdit.Size = New System.Drawing.Size(506, 83)
        Me.Remarks_MemoEdit.TabIndex = 102
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.itemEntry_Panel)
        Me.Panel6.Controls.Add(Me.itemEntry2_Panel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(608, 36)
        Me.Panel6.TabIndex = 86
        '
        'itemEntry_Panel
        '
        Me.itemEntry_Panel.Controls.Add(Me.BoxDescTxt_TextEdit)
        Me.itemEntry_Panel.Controls.Add(Me.Label8)
        Me.itemEntry_Panel.Controls.Add(Me.ItemNoTxt)
        Me.itemEntry_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemEntry_Panel.Location = New System.Drawing.Point(0, 0)
        Me.itemEntry_Panel.Name = "itemEntry_Panel"
        Me.itemEntry_Panel.Size = New System.Drawing.Size(144, 32)
        Me.itemEntry_Panel.TabIndex = 108
        '
        'BoxDescTxt_TextEdit
        '
        Me.BoxDescTxt_TextEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxDescTxt_TextEdit.Location = New System.Drawing.Point(90, 7)
        Me.BoxDescTxt_TextEdit.MaximumSize = New System.Drawing.Size(1000, 19)
        Me.BoxDescTxt_TextEdit.Name = "BoxDescTxt_TextEdit"
        Me.BoxDescTxt_TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxDescTxt_TextEdit.Properties.ReadOnly = True
        Me.BoxDescTxt_TextEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BoxDescTxt_TextEdit.Properties.WordWrap = False
        Me.BoxDescTxt_TextEdit.Size = New System.Drawing.Size(51, 19)
        Me.BoxDescTxt_TextEdit.TabIndex = 106
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "*Desc :"
        '
        'ItemNoTxt
        '
        Me.ItemNoTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemNoTxt.Location = New System.Drawing.Point(7, 7)
        Me.ItemNoTxt.Name = "ItemNoTxt"
        Me.ItemNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ItemNoTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ItemNoTxt.Size = New System.Drawing.Size(35, 19)
        Me.ItemNoTxt.TabIndex = 93
        '
        'itemEntry2_Panel
        '
        Me.itemEntry2_Panel.Controls.Add(Me.Panel3)
        Me.itemEntry2_Panel.Controls.Add(Me.BoxCategoryCmb)
        Me.itemEntry2_Panel.Controls.Add(Me.Box_Label)
        Me.itemEntry2_Panel.Controls.Add(Me.Product_cmb)
        Me.itemEntry2_Panel.Controls.Add(Me.Product_Label)
        Me.itemEntry2_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.itemEntry2_Panel.Location = New System.Drawing.Point(144, 0)
        Me.itemEntry2_Panel.Name = "itemEntry2_Panel"
        Me.itemEntry2_Panel.Size = New System.Drawing.Size(460, 32)
        Me.itemEntry2_Panel.TabIndex = 107
        '
        'UnitPrice_Txt
        '
        Me.UnitPrice_Txt.Location = New System.Drawing.Point(445, 4)
        Me.UnitPrice_Txt.Name = "UnitPrice_Txt"
        Me.UnitPrice_Txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.UnitPrice_Txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UnitPrice_Txt.Size = New System.Drawing.Size(69, 19)
        Me.UnitPrice_Txt.TabIndex = 104
        Me.UnitPrice_Txt.Text = "0"
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(346, 4)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(35, 19)
        Me.QtyTxt.TabIndex = 86
        Me.QtyTxt.Text = "0"
        '
        'UnitPrice_label
        '
        Me.UnitPrice_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice_label.Location = New System.Drawing.Point(385, 7)
        Me.UnitPrice_label.Name = "UnitPrice_label"
        Me.UnitPrice_label.Size = New System.Drawing.Size(68, 16)
        Me.UnitPrice_label.TabIndex = 103
        Me.UnitPrice_label.Text = "*Unit Price :"
        '
        'BoxCategoryCmb
        '
        Me.BoxCategoryCmb.Location = New System.Drawing.Point(49, 5)
        Me.BoxCategoryCmb.Name = "BoxCategoryCmb"
        Me.BoxCategoryCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxCategoryCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.BoxCategoryCmb.Properties.NullString = ""
        Me.BoxCategoryCmb.Properties.PopupWidth = 242
        Me.BoxCategoryCmb.Size = New System.Drawing.Size(89, 23)
        Me.BoxCategoryCmb.TabIndex = 100
        '
        'Box_Label
        '
        Me.Box_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box_Label.Location = New System.Drawing.Point(6, 9)
        Me.Box_Label.Name = "Box_Label"
        Me.Box_Label.Size = New System.Drawing.Size(41, 19)
        Me.Box_Label.TabIndex = 105
        Me.Box_Label.Text = "*Box :"
        '
        'Product_cmb
        '
        Me.Product_cmb.Location = New System.Drawing.Point(62, 3)
        Me.Product_cmb.Name = "Product_cmb"
        Me.Product_cmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Product_cmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.Product_cmb.Properties.NullString = ""
        Me.Product_cmb.Properties.PopupWidth = 242
        Me.Product_cmb.Size = New System.Drawing.Size(114, 23)
        Me.Product_cmb.TabIndex = 106
        '
        'Product_Label
        '
        Me.Product_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Label.Location = New System.Drawing.Point(7, 7)
        Me.Product_Label.Name = "Product_Label"
        Me.Product_Label.Size = New System.Drawing.Size(59, 19)
        Me.Product_Label.TabIndex = 107
        Me.Product_Label.Text = "Product :"
        '
        'QtyLbl
        '
        Me.QtyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.Location = New System.Drawing.Point(310, 7)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(40, 16)
        Me.QtyLbl.TabIndex = 91
        Me.QtyLbl.Text = "* Qty :"
        '
        'CompCost_Panel
        '
        Me.CompCost_Panel.Controls.Add(Me.OthersTxt)
        Me.CompCost_Panel.Controls.Add(Me.Label29)
        Me.CompCost_Panel.Controls.Add(Me.CompCostTxt)
        Me.CompCost_Panel.Controls.Add(Me.EnclosureTxt)
        Me.CompCost_Panel.Controls.Add(Me.Label22)
        Me.CompCost_Panel.Controls.Add(Me.Label13)
        Me.CompCost_Panel.Controls.Add(Me.PanelCostTxt)
        Me.CompCost_Panel.Controls.Add(Me.Label9)
        Me.CompCost_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CompCost_Panel.Location = New System.Drawing.Point(0, 376)
        Me.CompCost_Panel.Name = "CompCost_Panel"
        Me.CompCost_Panel.Size = New System.Drawing.Size(608, 45)
        Me.CompCost_Panel.TabIndex = 88
        '
        'OthersTxt
        '
        Me.OthersTxt.Location = New System.Drawing.Point(375, 10)
        Me.OthersTxt.Name = "OthersTxt"
        Me.OthersTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OthersTxt.Properties.ReadOnly = True
        Me.OthersTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OthersTxt.Size = New System.Drawing.Size(64, 19)
        Me.OthersTxt.TabIndex = 145
        Me.OthersTxt.Text = "0"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(303, 13)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 16)
        Me.Label29.TabIndex = 146
        Me.Label29.Text = "Others Total :"
        '
        'CompCostTxt
        '
        Me.CompCostTxt.Location = New System.Drawing.Point(79, 10)
        Me.CompCostTxt.Name = "CompCostTxt"
        Me.CompCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompCostTxt.Properties.ReadOnly = True
        Me.CompCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CompCostTxt.Size = New System.Drawing.Size(64, 19)
        Me.CompCostTxt.TabIndex = 81
        Me.CompCostTxt.Text = "0"
        '
        'EnclosureTxt
        '
        Me.EnclosureTxt.Location = New System.Drawing.Point(233, 10)
        Me.EnclosureTxt.Name = "EnclosureTxt"
        Me.EnclosureTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnclosureTxt.Properties.ReadOnly = True
        Me.EnclosureTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnclosureTxt.Size = New System.Drawing.Size(64, 19)
        Me.EnclosureTxt.TabIndex = 140
        Me.EnclosureTxt.Text = "0"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(147, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 144
        Me.Label22.Text = "Enclosure Total :"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 29)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Comp. Cost : (After Markup)"
        '
        'PanelCostTxt
        '
        Me.PanelCostTxt.Location = New System.Drawing.Point(547, 10)
        Me.PanelCostTxt.Name = "PanelCostTxt"
        Me.PanelCostTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelCostTxt.Properties.ReadOnly = True
        Me.PanelCostTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelCostTxt.Size = New System.Drawing.Size(49, 19)
        Me.PanelCostTxt.TabIndex = 84
        Me.PanelCostTxt.Text = "0"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(446, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "* Total Panel Cost :"
        '
        'AddBtn
        '
        Me.AddBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Image = Nothing
        Me.AddBtn.Location = New System.Drawing.Point(10, 4)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(30, 19)
        Me.AddBtn.TabIndex = 34
        Me.AddBtn.Text = "&Add"
        '
        'NavFirstBtn
        '
        Me.NavFirstBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavFirstBtn.Image = Nothing
        Me.NavFirstBtn.Location = New System.Drawing.Point(105, 4)
        Me.NavFirstBtn.Name = "NavFirstBtn"
        Me.NavFirstBtn.Size = New System.Drawing.Size(26, 19)
        Me.NavFirstBtn.TabIndex = 39
        Me.NavFirstBtn.Text = " <<"
        '
        'NavNextBtn
        '
        Me.NavNextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavNextBtn.Image = Nothing
        Me.NavNextBtn.Location = New System.Drawing.Point(159, 4)
        Me.NavNextBtn.Name = "NavNextBtn"
        Me.NavNextBtn.Size = New System.Drawing.Size(20, 19)
        Me.NavNextBtn.TabIndex = 38
        Me.NavNextBtn.Text = " >"
        '
        'NavLastBtn
        '
        Me.NavLastBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavLastBtn.Image = Nothing
        Me.NavLastBtn.Location = New System.Drawing.Point(183, 4)
        Me.NavLastBtn.Name = "NavLastBtn"
        Me.NavLastBtn.Size = New System.Drawing.Size(26, 19)
        Me.NavLastBtn.TabIndex = 40
        Me.NavLastBtn.Text = " >>"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UpdateBtn.Enabled = False
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Image = Nothing
        Me.UpdateBtn.Location = New System.Drawing.Point(46, 4)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(47, 19)
        Me.UpdateBtn.TabIndex = 84
        Me.UpdateBtn.Text = "Update"
        '
        'NavPrevBtn
        '
        Me.NavPrevBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavPrevBtn.Image = Nothing
        Me.NavPrevBtn.Location = New System.Drawing.Point(135, 4)
        Me.NavPrevBtn.Name = "NavPrevBtn"
        Me.NavPrevBtn.Size = New System.Drawing.Size(20, 19)
        Me.NavPrevBtn.TabIndex = 37
        Me.NavPrevBtn.Text = " <"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.Enabled = False
        Me.lblNavLocation.Location = New System.Drawing.Point(14, 10)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.lblNavLocation.Size = New System.Drawing.Size(55, 19)
        Me.lblNavLocation.TabIndex = 41
        '
        'DelProdBtn
        '
        Me.DelProdBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelProdBtn.Enabled = False
        Me.DelProdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelProdBtn.Image = Nothing
        Me.DelProdBtn.Location = New System.Drawing.Point(8, 5)
        Me.DelProdBtn.Name = "DelProdBtn"
        Me.DelProdBtn.Size = New System.Drawing.Size(43, 19)
        Me.DelProdBtn.TabIndex = 35
        Me.DelProdBtn.Text = "&Delete"
        '
        'CopyButton
        '
        Me.CopyButton.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CopyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyButton.Image = Nothing
        Me.CopyButton.Location = New System.Drawing.Point(215, 4)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(37, 19)
        Me.CopyButton.TabIndex = 86
        Me.CopyButton.Text = "Copy"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(44, 80)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 16)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "* Delivery Terms :"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(44, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 24)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "* Payment Term :"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(73, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 16)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Validity :"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(493, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 16)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Price include till :"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(493, 48)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Service Type :"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(493, 72)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 16)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Signed by :"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(87, 112)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Notes :"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(82, 184)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 24)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Typical Notes 1 :"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(84, 160)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 16)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "Closing :"
        '
        'NotesMemo
        '
        Me.NotesMemo.Location = New System.Drawing.Point(152, 112)
        Me.NotesMemo.Name = "NotesMemo"
        Me.NotesMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesMemo.Size = New System.Drawing.Size(528, 40)
        Me.NotesMemo.TabIndex = 32
        '
        'OtherNotesMemo
        '
        Me.OtherNotesMemo.Location = New System.Drawing.Point(152, 184)
        Me.OtherNotesMemo.Name = "OtherNotesMemo"
        Me.OtherNotesMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OtherNotesMemo.Size = New System.Drawing.Size(528, 40)
        Me.OtherNotesMemo.TabIndex = 33
        '
        'PriceTillCmb
        '
        Me.PriceTillCmb.Location = New System.Drawing.Point(581, 24)
        Me.PriceTillCmb.Name = "PriceTillCmb"
        Me.PriceTillCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PriceTillCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PriceTillCmb.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(23))
        Me.PriceTillCmb.Properties.NullString = ""
        Me.PriceTillCmb.Size = New System.Drawing.Size(112, 23)
        Me.PriceTillCmb.TabIndex = 38
        '
        'ServiceTypeCmb
        '
        Me.ServiceTypeCmb.Location = New System.Drawing.Point(581, 48)
        Me.ServiceTypeCmb.Name = "ServiceTypeCmb"
        Me.ServiceTypeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ServiceTypeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ServiceTypeCmb.Properties.NullString = ""
        Me.ServiceTypeCmb.Size = New System.Drawing.Size(112, 23)
        Me.ServiceTypeCmb.TabIndex = 39
        '
        'SignByCmb
        '
        Me.SignByCmb.Location = New System.Drawing.Point(581, 72)
        Me.SignByCmb.Name = "SignByCmb"
        Me.SignByCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SignByCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SignByCmb.Properties.NullString = ""
        Me.SignByCmb.Size = New System.Drawing.Size(112, 23)
        Me.SignByCmb.TabIndex = 40
        '
        'ClosingTxt
        '
        Me.ClosingTxt.Location = New System.Drawing.Point(152, 160)
        Me.ClosingTxt.Name = "ClosingTxt"
        Me.ClosingTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ClosingTxt.Size = New System.Drawing.Size(528, 19)
        Me.ClosingTxt.TabIndex = 41
        '
        'PayDetailsCmb
        '
        Me.PayDetailsCmb.Location = New System.Drawing.Point(152, 48)
        Me.PayDetailsCmb.Name = "PayDetailsCmb"
        Me.PayDetailsCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PayDetailsCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PayDetailsCmb.Properties.NullString = ""
        Me.PayDetailsCmb.Properties.PopupWidth = 320
        Me.PayDetailsCmb.Size = New System.Drawing.Size(320, 23)
        Me.PayDetailsCmb.TabIndex = 42
        '
        'DelTermsCmb
        '
        Me.DelTermsCmb.Location = New System.Drawing.Point(152, 80)
        Me.DelTermsCmb.Name = "DelTermsCmb"
        Me.DelTermsCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DelTermsCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DelTermsCmb.Properties.NullString = ""
        Me.DelTermsCmb.Properties.PopupWidth = 320
        Me.DelTermsCmb.Size = New System.Drawing.Size(320, 23)
        Me.DelTermsCmb.TabIndex = 43
        '
        'ValidityTxt
        '
        Me.ValidityTxt.Location = New System.Drawing.Point(152, 24)
        Me.ValidityTxt.Name = "ValidityTxt"
        Me.ValidityTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ValidityTxt.Size = New System.Drawing.Size(96, 19)
        Me.ValidityTxt.TabIndex = 115
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ValidityTxt)
        Me.GroupBox4.Controls.Add(Me.DelTermsCmb)
        Me.GroupBox4.Controls.Add(Me.PayDetailsCmb)
        Me.GroupBox4.Controls.Add(Me.ClosingTxt)
        Me.GroupBox4.Controls.Add(Me.SignByCmb)
        Me.GroupBox4.Controls.Add(Me.ServiceTypeCmb)
        Me.GroupBox4.Controls.Add(Me.PriceTillCmb)
        Me.GroupBox4.Controls.Add(Me.OtherNotesMemo)
        Me.GroupBox4.Controls.Add(Me.NotesMemo)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(719, 239)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'Payment_ExpandablePanel
        '
        Me.Payment_ExpandablePanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.Payment_ExpandablePanel.Controls.Add(Me.GroupBox4)
        Me.Payment_ExpandablePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Payment_ExpandablePanel.Expanded = False
        Me.Payment_ExpandablePanel.ExpandedBounds = New System.Drawing.Rectangle(0, 367, 1049, 291)
        Me.Payment_ExpandablePanel.Location = New System.Drawing.Point(0, 633)
        Me.Payment_ExpandablePanel.Name = "Payment_ExpandablePanel"
        Me.Payment_ExpandablePanel.Size = New System.Drawing.Size(1291, 25)
        Me.Payment_ExpandablePanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Payment_ExpandablePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Payment_ExpandablePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Payment_ExpandablePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.Payment_ExpandablePanel.Style.GradientAngle = 90
        Me.Payment_ExpandablePanel.TabIndex = 30
        Me.Payment_ExpandablePanel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Payment_ExpandablePanel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Payment_ExpandablePanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Payment_ExpandablePanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Payment_ExpandablePanel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Payment_ExpandablePanel.TitleStyle.GradientAngle = 90
        Me.Payment_ExpandablePanel.TitleStyle.MarginLeft = 10
        Me.Payment_ExpandablePanel.TitleText = "Other Details"
        '
        'Quotation_ContextMenuStrip
        '
        Me.Quotation_ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuotationCopy_ToolStripMenuItem, Me.QuotationDelete_ToolStripMenuItem})
        Me.Quotation_ContextMenuStrip.Name = "Quotation_ContextMenuStrip"
        Me.Quotation_ContextMenuStrip.Size = New System.Drawing.Size(108, 48)
        '
        'QuotationCopy_ToolStripMenuItem
        '
        Me.QuotationCopy_ToolStripMenuItem.Enabled = False
        Me.QuotationCopy_ToolStripMenuItem.Name = "QuotationCopy_ToolStripMenuItem"
        Me.QuotationCopy_ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.QuotationCopy_ToolStripMenuItem.Text = "Copy"
        '
        'QuotationDelete_ToolStripMenuItem
        '
        Me.QuotationDelete_ToolStripMenuItem.Enabled = False
        Me.QuotationDelete_ToolStripMenuItem.Name = "QuotationDelete_ToolStripMenuItem"
        Me.QuotationDelete_ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.QuotationDelete_ToolStripMenuItem.Text = "Delete"
        '
        'item_ContextMenu
        '
        Me.item_ContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Copy_MenuItem, Me.Paste_MenuItem, Me.MenuItem6, Me.MenuItem2, Me.MenuItem4})
        '
        'Copy_MenuItem
        '
        Me.Copy_MenuItem.Index = 0
        Me.Copy_MenuItem.Text = "Copy"
        '
        'Paste_MenuItem
        '
        Me.Paste_MenuItem.Enabled = False
        Me.Paste_MenuItem.Index = 1
        Me.Paste_MenuItem.Text = "Paste"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "Add"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Delete"
        '
        'item_bottom_Panel
        '
        Me.item_bottom_Panel.Controls.Add(Me.Panel1)
        Me.item_bottom_Panel.Controls.Add(Me.lblNavLocation)
        Me.item_bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.item_bottom_Panel.Location = New System.Drawing.Point(0, 382)
        Me.item_bottom_Panel.Name = "item_bottom_Panel"
        Me.item_bottom_Panel.Size = New System.Drawing.Size(673, 39)
        Me.item_bottom_Panel.TabIndex = 93
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GrandTotalTxt)
        Me.Panel1.Controls.Add(Me.GrandTotal_Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(464, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 39)
        Me.Panel1.TabIndex = 95
        '
        'GrandTotalTxt
        '
        Me.GrandTotalTxt.Location = New System.Drawing.Point(97, 10)
        Me.GrandTotalTxt.Name = "GrandTotalTxt"
        Me.GrandTotalTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GrandTotalTxt.Properties.ReadOnly = True
        Me.GrandTotalTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrandTotalTxt.Size = New System.Drawing.Size(87, 19)
        Me.GrandTotalTxt.TabIndex = 82
        '
        'GrandTotal_Label
        '
        Me.GrandTotal_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotal_Label.Location = New System.Drawing.Point(16, 13)
        Me.GrandTotal_Label.Name = "GrandTotal_Label"
        Me.GrandTotal_Label.Size = New System.Drawing.Size(75, 16)
        Me.GrandTotal_Label.TabIndex = 93
        Me.GrandTotal_Label.Text = "Grand Total :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DelProdBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(616, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(55, 28)
        Me.Panel4.TabIndex = 105
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.XtraButton2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(401, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(59, 32)
        Me.Panel3.TabIndex = 109
        '
        'XtraButton2
        '
        Me.XtraButton2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton2.Image = Nothing
        Me.XtraButton2.Location = New System.Drawing.Point(12, 7)
        Me.XtraButton2.Name = "XtraButton2"
        Me.XtraButton2.Size = New System.Drawing.Size(30, 19)
        Me.XtraButton2.TabIndex = 35
        Me.XtraButton2.Text = "Add"
        '
        'QuotationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1291, 720)
        Me.Controls.Add(Me.Items_Panel)
        Me.Controls.Add(Me.Payment_ExpandablePanel)
        Me.Controls.Add(Me.bottom_Panel)
        Me.Controls.Add(Me.Details_Panel)
        Me.Controls.Add(Me.Panel2)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuotationForm"
        Me.Text = "New Quotation"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bottom_Panel.ResumeLayout(False)
        Me.Button_Panel.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.QuoNo_LookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Details_Panel.ResumeLayout(False)
        Me.Items_Panel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.itemedit_Panel.ResumeLayout(False)
        Me.item_Panel.ResumeLayout(False)
        CType(Me.Item_GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.item_controlpanel.ResumeLayout(False)
        Me.item_controlpanel.PerformLayout()
        Me.Box_Panel.ResumeLayout(False)
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.item_TabControl.ResumeLayout(False)
        Me.ItemTab.ResumeLayout(False)
        Me.BoxGroup.ResumeLayout(False)
        CType(Me.BoxDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompMarkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopyFmBxCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OverallMarkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnclosureTab.ResumeLayout(False)
        Me.EnclosureGroup.ResumeLayout(False)
        CType(Me.TypeEnclosureCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typetxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThicknessTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatCostTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerCoatTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OthersTab.ResumeLayout(False)
        Me.OthersGroup.ResumeLayout(False)
        CType(Me.PanelTransportTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomingTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCEFTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopperTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoryTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConcreteBaseTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WiringTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RemarksTab.ResumeLayout(False)
        CType(Me.Remarks_MemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.itemEntry_Panel.ResumeLayout(False)
        CType(Me.BoxDescTxt_TextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.itemEntry2_Panel.ResumeLayout(False)
        CType(Me.UnitPrice_Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxCategoryCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompCost_Panel.ResumeLayout(False)
        CType(Me.OthersTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompCostTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnclosureTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCostTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNavLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherNotesMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceTillCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceTypeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignByCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosingTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayDetailsCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelTermsCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Payment_ExpandablePanel.ResumeLayout(False)
        Me.Quotation_ContextMenuStrip.ResumeLayout(False)
        Me.item_bottom_Panel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrandTotalTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Form load"
    Private Sub QuotationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Top = (MainForm.ActiveForm.Height - Me.Height) / 3
        'Me.Left = (MainForm.ActiveForm.Width - Me.Width) / 2

        Me.Cursor = Cursors.WaitCursor

        InitForms()

        If OrderType = "1" Then 'May not be used anymore... 02052019
            BoxCategoryCmb.Enabled = False
        Else
            BoxCategoryCmb.Enabled = True
        End If

        SelectAction()

        If Quotation_ID <> 0 Then
            LoadQuotation(Quotation_ID)
            Panel2.Select()
            'Disable Save button until changes has been made
            SaveQuoBtn.Enabled = False
        End If

    End Sub

    Private Sub InitForms()
        LoadCustomerDetails()
        LoadEnclosureType()
        LoadProjectTitle()
        LoadMaterial()
        LoadConsultant()
        LoadPriceIncludeTill()
        LoadPaymentDetails()
        LoadDeliveryTerms()

        LoadCombo()
        SetTabColors()
        LoadCopyFromBox()
        LoadBoxCategory()
    End Sub

    Private Sub SelectAction()
        Select Case UCase(FormStatus)
            Case "LIST"
                LoadQuoNoCmb()
                FormType = "QUOTATION"
                PrepareQuotation_Form()
                DisableAllPanels()
            Case "NEW"
                FormType = "QUOTATION"
                ItemNo = 0
                LineNo = 0
                PrepareQuotation_Form()
                InitializeForm()
                DisableNavBtn()
                New_Button.Enabled = False
            Case "LIST_BQ"
                LoadBQNoCmb()
                FormType = "BQ"
                PrepareForm_BQ()
                DisableAllPanels()
            Case "NEW_BQ"
                FormType = "BQ"
                ItemNo = 0
                LineNo = 0
                PrepareForm_BQ()
                InitializeForm_BQ()
                DisableNavBtn()
                New_Button.Enabled = False
            Case "LIST_ENQUIRY"
                LoadEnNoCmb()
                FormType = "ENQUIRY"
                PrepareForm_Enquiry()
                DisableAllPanels()
            Case "NEW_ENQUIRY"
                FormType = "ENQUIRY"
                ItemNo = 0
                LineNo = 0
                PrepareForm_Enquiry()
                InitializeForm_Enquiry()
                DisableNavBtn()
                New_Button.Enabled = False
            Case "REJOIN"
                Me.Text = "Rejoin Quotation"
                'DuplicateExistingQuotation()
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
                'SaveQuoBtn.Enabled = True
                RefreshNavBtn()
                CurrentRow = 0

                SetEditableMode()

                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    EnableButtons()
                    Me.NavdsBox_PositionChanged()
                Else
                    CompGrid1.Enabled = False
                    DelProdBtn.Enabled = False
                    UpdateBtn.Enabled = False
                    item_TabControl.Enabled = False
                End If


            Case "VIEW"
                Me.Text = "View Quotation"
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetQuotationHeader(dsHeaderLoad, Quotation_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With

                RefreshNavBtn()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If

                SetViewMode()

            Case "REVISED"
                Me.Text = "Revise Quotation"
                'RevisedQuotationHeader()
                'RevisedQuotationLine()
                'SetOldQuotationStatus()
                RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
        End Select

        Me.Cursor = Cursors.Default

        If Quotation_ID <> 0 Then
            QuoNoTxt.Properties.ReadOnly = True
        Else
            QuoNoTxt.Properties.ReadOnly = False
        End If

        ExpandablePanel_Changing = False

    End Sub

    Private Sub PrepareQuotation_Form()
        If (item_TabControl.TabPages.Contains(EnclosureTab)) Then item_TabControl.TabPages.Remove(EnclosureTab)
        If (item_TabControl.TabPages.Contains(OthersTab)) Then item_TabControl.TabPages.Remove(OthersTab)

        Product_cmb.Visible = False
        Product_Label.Visible = False

    End Sub


    Private Sub InitializeForm()
        Dim ds As DataSet

        QuoNoTxt.Text = CreateQuotationNo()
        QuoNoTxt.Properties.ReadOnly = True

        'New Quotation hide combo
        QuoNo_LookUpEdit.Visible = False

        StatusCmb.Properties.LookUpData.KeyValue = "10" 'Preparing
        QuoDate.DateTime = Date.Today
        ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        SignByCmb.Properties.LookUpData.KeyValue = "Thomas Yeo"
        ServiceTypeCmb.Properties.LookUpData.KeyValue = "1"
        PriceTillCmb.Properties.LookUpData.KeyValue = "2"
        ItemNoTxt.Text = ItemNo.ToString
        QuotationNo = QuoNoTxt.Text     'to store quotation no

        ClosingTxt.Text = "We hope that our quotation is acceptable and looking forward to hear from you soon."
        OtherNotesMemo.Text = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."

        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_No = QuotationNo
            '27.10.2003 YG Start
            .Order_Type = OrderType
            '27.10.2003 YG End
            .UserID = UserID
            .Status = StatusCmb.Properties.LookUpData.KeyValue
            .ClosingNotes = "We hope that our quotation is acceptable and looking forward to hear from you soon."
            .OtherNotes = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."
            .PriceInclude_ID = Me.PriceTillCmb.Properties.LookUpData.KeyValue
            .Service_Type = ServiceTypeCmb.Properties.LookUpData.KeyValue
            .Sign_By = SignByCmb.Properties.LookUpData.KeyValue

            If .SaveQuotationNo() Then
                Quotation_ID = .Quotation_ID        'Store Quotation ID
            Else
                MessageBox.Show("Error creating Quotation", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Private Sub PrepareForm_Enquiry()

        QuoNoLbl.Text = "Enquiry No:"
        item_TabControl.TabPages.Remove(EnclosureTab)
        item_TabControl.TabPages.Remove(OthersTab)
        Component_Splitter.Visible = False
        CompGrid1.Visible = False
        item_TabControl.Dock = DockStyle.Fill
        CompCost_Panel.Visible = False
        QtyLbl.Left = QtyLbl.Left + 69
        QtyTxt.Left = QtyTxt.Left + 69
        Box_Label.Visible = False
        BoxCategoryCmb.Visible = False
        
        UnitPrice_label.Visible = False
        UnitPrice_Txt.Visible = False
        Overall_Markup_Label.Visible = False
        OverallMarkTxt.Visible = False
        Comp_Markup_Label.Visible = False
        CompMarkTxt.Visible = False
        GrandTotal_Label.Visible = False
        GrandTotalTxt.Visible = False

        LoadStdProduct()

        'EnclosureGroup.Visible = False
        'OthersGroup.Visible = False
    End Sub

    Private Sub InitializeForm_Enquiry()
        Dim ds As DataSet

        QuoNoTxt.Text = CreateEnquiryNo()
        QuoNoTxt.Properties.ReadOnly = True

        'New Quotation hide combo
        QuoNo_LookUpEdit.Visible = False

        StatusCmb.Properties.LookUpData.KeyValue = "10" 'Preparing
        QuoDate.DateTime = Date.Today
        ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        SignByCmb.Properties.LookUpData.KeyValue = "Thomas Yeo"
        ServiceTypeCmb.Properties.LookUpData.KeyValue = "1"
        PriceTillCmb.Properties.LookUpData.KeyValue = "2"
        ItemNoTxt.Text = ItemNo.ToString
        QuotationNo = QuoNoTxt.Text     'to store quotation no

        ClosingTxt.Text = "We hope that our quotation is acceptable and looking forward to hear from you soon."
        OtherNotesMemo.Text = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."

        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic

            .Enquiry_No = QuotationNo
            '27.10.2003 YG Start
            .Order_Type = OrderType
            '27.10.2003 YG End
            .UserID = UserID
            .Status = StatusCmb.Properties.LookUpData.KeyValue
            .ClosingNotes = "We hope that our quotation is acceptable and looking forward to hear from you soon."
            .OtherNotes = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."
            .PriceInclude_ID = Me.PriceTillCmb.Properties.LookUpData.KeyValue
            .Service_Type = ServiceTypeCmb.Properties.LookUpData.KeyValue
            .Sign_By = SignByCmb.Properties.LookUpData.KeyValue

            If .SaveEnquiryNo() Then
                Quotation_ID = .Enquiry_ID        'Store Quotation ID
            Else
                MessageBox.Show("Error creating Enquiry", "Enquiry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Private Sub PrepareForm_BQ()
        QuoNoLbl.Text = "BQ No:"
        Payment_ExpandablePanel.Visible = False
        Product_cmb.Visible = False
        Product_Label.Visible = False
    End Sub

    Private Sub InitializeForm_BQ()
        Dim ds As DataSet

        QuoNoTxt.Text = CreateBQNo()
        QuoNoTxt.Properties.ReadOnly = True

        'New Quotation hide combo
        QuoNo_LookUpEdit.Visible = False

        StatusCmb.Properties.LookUpData.KeyValue = "10" 'Preparing
        QuoDate.DateTime = Date.Today
        ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        SignByCmb.Properties.LookUpData.KeyValue = "Thomas Yeo"
        ServiceTypeCmb.Properties.LookUpData.KeyValue = "1"
        PriceTillCmb.Properties.LookUpData.KeyValue = "2"
        ItemNoTxt.Text = ItemNo.ToString
        QuotationNo = QuoNoTxt.Text     'to store quotation no

        ClosingTxt.Text = "We hope that our quotation is acceptable and looking forward to hear from you soon."
        OtherNotesMemo.Text = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."

        With New BusinessRules.BQBusRules.BQBusLogic

            .BQ_No = QuotationNo
            '27.10.2003 YG Start
            .Order_Type = OrderType
            '27.10.2003 YG End
            .UserID = UserID
            .Status = StatusCmb.Properties.LookUpData.KeyValue
            .ClosingNotes = "We hope that our quotation is acceptable and looking forward to hear from you soon."
            .OtherNotes = "We reserve our rights to offer components of equivalent brand prior to the confirmation of your esteem order."
            .PriceInclude_ID = Me.PriceTillCmb.Properties.LookUpData.KeyValue
            .Service_Type = ServiceTypeCmb.Properties.LookUpData.KeyValue
            .Sign_By = SignByCmb.Properties.LookUpData.KeyValue

            If .SaveBQNo() Then
                Quotation_ID = .BQ_ID        'Store Quotation ID
            Else
                MessageBox.Show("Error creating BQ", "BQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub


    Private Sub EnableButtons()
        DelProdBtn.Enabled = True
        item_TabControl.Enabled = True
        BoxGroup.Enabled = True

        If OrderType <> "1" Then
            EnclosureGroup.Enabled = True
            OthersGroup.Enabled = True
        Else
            EnclosureGroup.Enabled = False
            OthersGroup.Enabled = False
        End If
        'EditCompBtn.Enabled = True
        'DelCompBtn.Enabled = True
        UpdateBtn.Enabled = True
    End Sub

    Private Sub SetTabColors()
        '** Tab Control Appearance **
        'item_TabControl.BackColor = Color.DarkSlateBlue
        'item_TabControl.ForeColor = Color.White
        'item_TabControl.ButtonActiveColor = Color.White
        'item_TabControl.ButtonInactiveColor = Color.SlateBlue
        'item_TabControl.TextInactiveColor = Color.White
        'item_TabControl.HotTextColor = Color.Cyan
        '***
    End Sub

    Private Function CreateQuotationNo() As String
        Dim DocumentNo As String

        Dim AccessQuotNo As String

        'Get Quotation number from Sales Organiser
        If MainForm.AccessUpdate = "1" Then
            AccessQuotNo = GetAccessNextQuotationNo()
            If AccessQuotNo = "" Then
                MessageBox.Show("Fail to retrieve Sale Organiser new quotation number", "Create Quotation Failed")
                Return ""
            End If
        End If

        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            If MainForm.AccessUpdate = "1" Then
                DocumentNo = .GetDocumentNumber("QU", Year(Now), True, CInt(AccessQuotNo))
            Else
                DocumentNo = .GetDocumentNextNumber("QU", Year(Now), True)

            End If

        End With
        'CreateQuotationNo = "QU" & Year(Now) & DocumentNo
        CreateQuotationNo = DocumentNo

        'Update Quotation number from Sales Organiser
        If MainForm.AccessUpdate = "1" Then
            If AccessQuotNo <> "" And DocumentNo <> "" Then
                UpdateAccessNextQuotationNo(AccessQuotNo)
            End If
        End If

    End Function

    Private Function GetAccessNextQuotationNo() As String
        Dim Provider, UserID, Password, DatabaseName, Mode As String
        Dim dbAccess As GenericOLEDBClass
        Dim NextNo As String

        Provider = "Microsoft.Jet.OLEDB.4.0"
        UserID = "Admin"
        Password = ""
        Mode = "Share Deny None"
        DatabaseName = MainForm.AccessFolder + "\SALEORGZ\refrunno.MDB"

        dbAccess = New GenericOLEDBClass
        dbAccess.Open(Provider, UserID, Password, DatabaseName, Mode)

        If dbAccess.IsOpen = True Then
            dbAccess.SelectCommand = "select nextno from tblRefRunNo2 where TableName='tblQuotMas'"
            If dbAccess.ExecuteCommand() = True Then
                Dim val As OleDbDataReader
                val = dbAccess.GetReader
                If val.Read() Then
                    NextNo = val.GetValue(0).ToString()
                Else
                    NextNo = ""
                    MessageBox.Show(dbAccess.ErrorMessage, "Unable to retrieve SaleOrganizer Quotation number")
                End If

            Else
                NextNo = ""
                MessageBox.Show(dbAccess.ErrorMessage, "Unable to retrieve SaleOrganizer Quotation number")
            End If

        End If

        If (dbAccess IsNot Nothing) Then

            If (dbAccess.IsOpen = True) Then

                dbAccess.Close()

            End If

        End If

        Return NextNo

    End Function

    Private Sub UpdateAccessNextQuotationNo(ByVal pCurrentQuotNo As Integer)

        Dim Provider, UserID, Password, DatabaseName, Mode As String
        Dim dbAccess As GenericOLEDBClass
        Dim NextNumber As Integer
        Dim CurrentNumber As Integer

        CurrentNumber = CInt(pCurrentQuotNo)
        NextNumber = CInt(pCurrentQuotNo) + 1

        If True Then 'MainForm.AccessUpdate = "1" Then

            Provider = "Microsoft.Jet.OLEDB.4.0"
            UserID = "Admin"
            Password = ""
            Mode = "Share Deny None"
            DatabaseName = MainForm.AccessFolder + "\SALEORGZ\refrunno.MDB"

            dbAccess = New GenericOLEDBClass
            dbAccess.Open(Provider, UserID, Password, DatabaseName, Mode)

            If dbAccess.IsOpen = True Then
                Dim SQLStr As String = "Update tblRefRunNo2 set currentNo = " + CurrentNumber.ToString()
                SQLStr = SQLStr + " ,NextNo = " + NextNumber.ToString() + " where TableName='tblQuotMas'"
                dbAccess.UpdateCommand = SQLStr
                If dbAccess.ExecuteCommand() = True Then
                Else
                    MessageBox.Show(dbAccess.ErrorMessage, "Unable to update SaleOrganizer Quotation Number")
                End If

            End If

            If (dbAccess IsNot Nothing) Then

                If (dbAccess.IsOpen = True) Then

                    dbAccess.Close()

                End If

            End If

        End If
    End Sub


    Private Function CreateEnquiryNo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("EN", Year(Now))
        End With
        CreateEnquiryNo = "EN" & Year(Now) & DocumentNo
    End Function

    Private Function CreateBQNo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("BQ", Year(Now))
        End With
        CreateBQNo = "BQ" & Year(Now) & DocumentNo
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
        PayDetailsCmb.Properties.ReadOnly = True
        DelTermsCmb.Properties.ReadOnly = True
        NotesMemo.Properties.ReadOnly = True
        ClosingTxt.Properties.ReadOnly = True
        OtherNotesMemo.Properties.ReadOnly = True
        ServiceTypeCmb.Properties.ReadOnly = True
        SignByCmb.Properties.ReadOnly = True
        PriceTillCmb.Properties.ReadOnly = True
        RefQuoNoTxt.Visible = True
    End Sub

    Private Function CreateReviseQuotation(ByVal pQuotation_ID) As Integer
        Dim dsLoad As DataSet
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer
        Dim RejoinedNo As Integer

        Dim RevisedQuotation_ID As Integer

        RevisedQuotation_ID = 0

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeader(dsLoad, pQuotation_ID) Then
                'Check if its created from rejoined quotation or based quotation
                .Quotation_ID = pQuotation_ID
                If .IsRejoinedQuote(dsBasedQuotation) Then        'if its rejoined quotation, then load based Quotation no
                    BasedQuotationID = dsBasedQuotation.Tables(0).Rows(0)("Quotation_ID")
                    QuotationNo = dsBasedQuotation.Tables(0).Rows(0)("Quotation_NO")
                    'COUNT THE NO OF rejoined COPY
                    .RefQuotationID = BasedQuotationID
                    RejoinedNo = .CountNoOfRejoinedQuote()
                    '****
                    RefQuotationID = BasedQuotationID        'Reference to the based ID
                    RevRefQuotationID = pQuotation_ID
                Else
                    QuotationNo = dsLoad.Tables(0).Rows(0)("Quotation_NO")  'Get the Existing Quotation No.
                    'COUNT THE NO OF REVISED COPY
                    .RefQuotationID = pQuotation_ID
                    RejoinedNo = .CountNoOfRejoinedQuote()
                    '****
                    RefQuotationID = pQuotation_ID        'Reference
                    RevRefQuotationID = pQuotation_ID
                End If
                '****

                'CHECKING
                .Quotation_No = QuotationNo & "-R" & RejoinedNo          'Appending R...
                If .CheckExistingQuotationNo() Then         'Record exist
                    RejoinedNo = RejoinedNo + 1
                    .Quotation_No = QuotationNo & "-R" & RejoinedNo
                    While .CheckExistingQuotationNo
                        RejoinedNo = RejoinedNo + 1
                        .Quotation_No = QuotationNo & "-R" & RejoinedNo
                    End While
                End If
                '***

                .Status = "10"
                .UserID = UserID
                If .SaveQuotationNo() Then
                    RevisedQuotation_ID = .Quotation_ID

                    'After saving initial data, save the rest of the data.
                    .Quotation_ID = RevisedQuotation_ID
                    '.QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("QuotationDate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("QuotationDate"))) & Year(dsLoad.Tables(0).Rows(0)("QuotationDate"))
                    .QuotationDate = (Today.Day) & MonthName(Today.Month) & Today.Year
                    .Status = dsLoad.Tables(0).Rows(0)("Status")
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ProjectSub")) Then
                        .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Project")) Then
                        .Project = dsLoad.Tables(0).Rows(0)("Project")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
                        .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Contact_ID")) Then
                        .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
                        .Consultant_ID = dsLoad.Tables(0).Rows(0)("Consultant_ID")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
                        .Payment_Term = dsLoad.Tables(0).Rows(0)("Payment_Term")
                    End If
                    '.Payment_Term = dsLoad.Tables(0).Rows(0)("Payment_Term")

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Validity")) Then
                        .Validity = dsLoad.Tables(0).Rows(0)("Validity")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
                        .Delivery_Term = dsLoad.Tables(0).Rows(0)("Delivery_Term")
                    End If
                    '.Delivery_Term = dsLoad.Tables(0).Rows(0)("Delivery_Term")

                    If Len(dsLoad.Tables(0).Rows(0)("Service_Type")) > 0 Then
                        .Service_Type = dsLoad.Tables(0).Rows(0)("Service_Type")
                    End If
                    If Len(dsLoad.Tables(0).Rows(0)("Order_Type")) > 0 Then
                        .Order_Type = dsLoad.Tables(0).Rows(0)("Order_Type")
                    End If
                    .CP5_Flg = dsLoad.Tables(0).Rows(0)("CP5_Flg")
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Sign_By")) Then
                        .Sign_By = dsLoad.Tables(0).Rows(0)("Sign_By")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Total_Cost_Numeric")) Then
                        .Total_Cost_Numeric = Double.Parse(dsLoad.Tables(0).Rows(0)("Total_Cost_Numeric"))
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
                    .RefQuotationID = RefQuotationID
                    .RevRefQuotationID = RevRefQuotationID

                    If .UpdateQuotationHeader() Then
                        Dim dsNew As DataSet
                        If .GetQuotationHeader(dsNew, New_Quotation_ID) Then
                            'SetWindowValue(dsNew)
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With

        Return RevisedQuotation_ID

    End Function
#End Region

#Region " Codes for Revised Quotation" 'Obselete
    'Private Sub SetOldQuotationStatus()
    '   With New BusinessRules.SaleBusRules.SaleBusLogic
    '      .Quotation_ID = Old_Quotation_ID
    '     .Status = "40"
    '    If .UpdateQuotationHeaderStatus() Then
    '
    '       End If
    '  End With
    'End Sub

    Private Function RevisedQuotationHeader(ByVal pQuotation_ID As Integer) As Integer
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer

        RevisedQuotationHeader = 0

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeader(dsLoad, pQuotation_ID) Then
                'Check if its created from revised quotation or based quotation
                .Quotation_ID = pQuotation_ID
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
                    .RevRefQuotationID = pQuotation_ID
                    RevisedNo = .CountNoOfRevisedQuote()
                    '****
                    RevRefQuotationID = pQuotation_ID        'Reference
                End If
                '****

                'CHECKING
                .Quotation_No = QuotationNo & "-R" & RevisedNo          'Appending R...
                If .CheckExistingQuotationNo() Then         'Record exist
                    RevisedNo = RevisedNo + 1
                    .Quotation_No = QuotationNo & "-R" & RevisedNo
                    While .CheckExistingQuotationNo
                        RevisedNo = RevisedNo + 1
                        .Quotation_No = QuotationNo & "-R" & RevisedNo
                    End While
                End If
                '***

                .Status = "10"
                ' 29.10.2003 YG Start
                .Order_Type = OrderType
                '29.10.2003 YG End
                .UserID = UserID
                If .SaveQuotationNo() Then
                    New_Quotation_ID = .Quotation_ID    'Get the new quotation_ID
                    'saving
                    .Quotation_ID = New_Quotation_ID
                    .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("QuotationDate")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("QuotationDate"))) & Year(dsLoad.Tables(0).Rows(0)("QuotationDate"))
                    '.Status = dsLoad.Tables(0).Rows(0)("Status")
                    .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                    .Project = dsLoad.Tables(0).Rows(0)("Project")
                    .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")
                    .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
                        .Consultant_ID = dsLoad.Tables(0).Rows(0)("Consultant_ID")
                    End If

                    'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
                    '.Payment_Term = dsLoad.Tables(0).Rows(0)("Payment_Term")
                    'End If
                    .Payment_Term = dsLoad.Tables(0).Rows(0)("Payment_Term")

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Validity")) Then
                        .Validity = dsLoad.Tables(0).Rows(0)("Validity")
                    End If

                    'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
                    '.Delivery_Term = dsLoad.Tables(0).Rows(0)("Delivery_Term")
                    'End If
                    .Delivery_Term = dsLoad.Tables(0).Rows(0)("Delivery_Term")

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
                            'SetWindowValue(dsNew)
                            RevisedQuotationHeader = New_Quotation_ID
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With

        Return RevisedQuotationHeader

    End Function

    Private Sub RevisedQuotationLine(ByVal pQuotation_ID, ByVal pNewQuotation_ID)
        Dim dsLine As DataSet
        Dim Old_Quotation_Line_ID As Integer

        ItemNo = 0
        LineNo = 0
        With New BusinessRules.SaleBusRules.SaleBusLogic
            'Get the old quotation line item
            .Quotation_ID = pQuotation_ID
            If .GetQuotationLine(dsLine) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    'Save the itemno first
                    LineNo = LineNo + 1
                    ItemNo = LineNo.ToString

                    .ItemNo = ItemNo
                    .Quotation_ID = pNewQuotation_ID
                    .UserID = UserID
                    If .SaveQuotationLineFirstTime() Then
                        Quotation_Line_ID = .Quotation_Line_ID
                    End If
                    '***
                    Old_Quotation_Line_ID = dsLine.Tables(0).Rows(x)("Quotation_Line_ID")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Box")) Then
                        .Box = dsLine.Tables(0).Rows(x)("Box")
                    End If
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
                                .Quotation_ID = pNewQuotation_ID
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

    Private Sub CopyandPasteQuotationLine(ByVal pQuotation_line_ID)
        Dim dsLine As DataSet

        ItemNo = GridView2.RowCount()

        With New BusinessRules.SaleBusRules.SaleBusLogic
            'Get the quotation line item

            If .GetAllQuotationLine(dsLine, pQuotation_line_ID) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    'Save the itemno first
                    .ItemNo = ItemNo + 1
                    .Quotation_ID = Me.Quotation_ID
                    .UserID = UserID
                    If .SaveQuotationLineFirstTime() Then
                        Quotation_Line_ID = .Quotation_Line_ID
                    End If
                    '***

                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Box")) Then
                        .Box = dsLine.Tables(0).Rows(x)("Box")
                    End If
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
                        .Quotation_Line_ID = pQuotation_line_ID
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

                    ItemNo = ItemNo + 1
                Next
                dsLine.Dispose()
            End If
        End With
    End Sub
#End Region


#Region " Set window value"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)

        If FormType = "ENQUIRY" Then
            QuoNoTxt.Text = dsLoad.Tables(0).Rows(0)("Enquiry_NO")
            QuoDate.DateTime = dsLoad.Tables(0).Rows(0)("EnquiryDate")
            If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RevRefQuotationID")) Then
                RevRefQuotationID = dsLoad.Tables(0).Rows(0)("RevRefQuotationID")
                FormStatus = "REVISED"
            End If

            If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RefQuotationID")) Then
                RefQuotationID = dsLoad.Tables(0).Rows(0)("RefQuotationID")
            End If
            If Not RefQuotationID = 0 Then
                With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
                    Dim dsTmp As DataSet
                    If .GetEnquiryHeader(dsTmp, RefQuotationID) Then
                        RefQuoNoTxt.Text = dsTmp.Tables(0).Rows(0)("Enquiry_NO")
                    End If
                    dsTmp.Dispose()
                End With
            End If

        ElseIf FormType = "BQ" Then

        Else

            QuoNoTxt.Text = dsLoad.Tables(0).Rows(0)("Quotation_NO")
            QuoDate.DateTime = dsLoad.Tables(0).Rows(0)("QuotationDate")
            If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RevRefQuotationID")) Then
                RevRefQuotationID = dsLoad.Tables(0).Rows(0)("RevRefQuotationID")
                FormStatus = "REVISED"
            End If

            If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RefQuotationID")) Then
                RefQuotationID = dsLoad.Tables(0).Rows(0)("RefQuotationID")
            End If
            If Not RefQuotationID = 0 Then
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    Dim dsTmp As DataSet
                    If .GetQuotationHeader(dsTmp, RefQuotationID) Then
                        RefQuoNoTxt.Text = dsTmp.Tables(0).Rows(0)("Quotation_NO")
                    End If
                    dsTmp.Dispose()
                End With
            End If
        End If


        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
            CustLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Customer_ID")
            Customer_ID = CustLookup.Properties.LookUpData.KeyValue

            If Customer_ID <> 0 Then
                Dim dsAddress As DataSet
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    If .GetCustomerDetails(dsAddress, Customer_ID) Then
                        If Not dsAddress Is Nothing Then
                            Addresstxt.Text = dsAddress.Tables(0).Rows(0)("Address").ToString
                        End If
                    End If
                End With
            End If

        Else
            CustLookup.Properties.LookUpData.KeyValue = Nothing

        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Status")) Then
            StatusCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Status")
        Else
            StatusCmb.Properties.LookUpData.KeyValue = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ProjectSub")) Then
            ProjectCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("ProjectSub")
        Else
            ProjectCmb.Properties.LookUpData.KeyValue = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Project")) Then
            ProjectTitleCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Project")
        Else
            ProjectTitleCmb.Properties.LookUpData.KeyValue = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
            ConsultantCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Consultant_ID")
        Else
            ConsultantCmb.Properties.LookUpData.KeyValue = Nothing
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
            LoadContactPerson(dsLoad.Tables(0).Rows(0)("Customer_ID"))
        Else
            ContLookup.Properties.LookUpData.KeyValue = Nothing
            Addresstxt.Text = ""
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Contact_ID")) Then
            ContLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Contact_ID")
        Else
            ContLookup.Properties.LookUpData.KeyValue = Nothing
        End If
        If dsLoad.Tables(0).Rows(0)("CP5_Flg") = 0 Then
            CP5Chk.Checked = False
        Else
            CP5Chk.Checked = True
        End If
        'If dsLoad.Tables(0).Rows(0)("Validity") > 0 Then
        'ValidityTxt.Text = dsLoad.Tables(0).Rows(0)("Validity")
        'End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Validity")) Then
            ValidityTxt.Text = dsLoad.Tables(0).Rows(0)("Validity")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
            '            PayDetailsCmb.Text = dsLoad.Tables(0).Rows(0)("Payment_Term")
            PayDetailsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Payment_Term")
        Else
            PayDetailsCmb.Properties.LookUpData.KeyValue = Nothing
        End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PayDetails_ID")) Then
        'PayDetailsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("PayDetails_ID")
        'End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
            '            DelTermsCmb.Text = dsLoad.Tables(0).Rows(0)("Delivery_Term")
            DelTermsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Delivery_Term")
        Else
            DelTermsCmb.Properties.LookUpData.KeyValue = Nothing
        End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("DelTerms_ID")) Then
        'DelTermsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("DelTerms_ID")
        'End If

        If dsLoad.Tables(0).Rows(0)("Service_Type") > 0 Then
            ServiceTypeCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Service_Type").ToString
        Else
            ServiceTypeCmb.Properties.LookUpData.KeyValue = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Sign_By")) Then
            SignByCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Sign_By")
        Else
            SignByCmb.Properties.LookUpData.KeyValue = Nothing
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remarks")) Then
            NotesMemo.Text = dsLoad.Tables(0).Rows(0)("Remarks")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PriceInclude_ID")) Then
            PriceTillCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("PriceInclude_ID")
        Else
            PriceTillCmb.Properties.LookUpData.KeyValue = Nothing
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ClosingNotes")) Then
            ClosingTxt.Text = dsLoad.Tables(0).Rows(0)("ClosingNotes")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("OtherNotes")) Then
            OtherNotesMemo.Text = dsLoad.Tables(0).Rows(0)("OtherNotes")
        End If


    End Sub


    Private Sub SetWindowValue2(ByVal dsLoad As DataSet)
        'QuoNoTxt.Text = dsLoad.Tables(0).Rows(0)("Quotation_NO")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
            CustLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Customer_ID")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Status")) Then
            StatusCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Status")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ProjectSub")) Then
            ProjectCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("ProjectSub")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Project")) Then
            ProjectTitleCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Project")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Consultant_ID")) Then
            ConsultantCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Consultant_ID")
        End If
        QuoDate.DateTime = dsLoad.Tables(0).Rows(0)("QuotationDate")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
            LoadContactPerson(dsLoad.Tables(0).Rows(0)("Customer_ID"))
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Contact_ID")) Then
            ContLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Contact_ID")
        End If
        If dsLoad.Tables(0).Rows(0)("CP5_Flg") = 0 Then
            CP5Chk.Checked = False
        Else
            CP5Chk.Checked = True
        End If
        'If dsLoad.Tables(0).Rows(0)("Validity") > 0 Then
        'ValidityTxt.Text = dsLoad.Tables(0).Rows(0)("Validity")
        'End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Validity")) Then
            ValidityTxt.Text = dsLoad.Tables(0).Rows(0)("Validity")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Payment_Term")) Then
            '            PayDetailsCmb.Text = dsLoad.Tables(0).Rows(0)("Payment_Term")
            PayDetailsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Payment_Term")
        End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PayDetails_ID")) Then
        'PayDetailsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("PayDetails_ID")
        'End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Delivery_Term")) Then
            '            DelTermsCmb.Text = dsLoad.Tables(0).Rows(0)("Delivery_Term")
            DelTermsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Delivery_Term")
        End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("DelTerms_ID")) Then
        'DelTermsCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("DelTerms_ID")
        'End If

        If dsLoad.Tables(0).Rows(0)("Service_Type") > 0 Then
            ServiceTypeCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Service_Type").ToString
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Sign_By")) Then
            SignByCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Sign_By")
        End If
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

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RevRefQuotationID")) Then
            RevRefQuotationID = dsLoad.Tables(0).Rows(0)("RevRefQuotationID")
            FormStatus = "REVISED"
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RefQuotationID")) Then
            RefQuotationID = dsLoad.Tables(0).Rows(0)("RefQuotationID")
        End If
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
                        BoxCategoryCmb.Properties.LookUpData.ListFields.Clear()
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

    Private Sub LoadStdProduct()
        Dim ds As DataSet
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .LoadList_StdProduct(ds) Then
                If Not ds Is Nothing Then
                    Try
                        Product_cmb.Properties.LookUpData.ListFields.Clear()
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(Product_cmb, "Name", 400, 0, "c")
                        Product_cmb.Properties.LookUpData.KeyField = "Product_ID"
                        Product_cmb.Properties.LookUpData.DisplayField = "Name"

                        Product_cmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        Product_cmb.EditValue = "0"
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
                        PriceTillCmb.Properties.LookUpData.ListFields.Clear()
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
                        ConsultantCmb.Properties.LookUpData.ListFields.Clear()
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

    Private Sub LoadProjectTitle(Optional ByVal pProjectID As Integer = 0)
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.ProjectBusLogic
            If .GetProject(ds) Then
                If Not ds Is Nothing Then
                    Try
                        ProjectTitleCmb.Properties.LookUpData.ListFields.Clear()
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ProjectTitleCmb, "Project_Name", 400, 0, "c")
                        ProjectTitleCmb.Properties.LookUpData.KeyField = "Project_ID"
                        ProjectTitleCmb.Properties.LookUpData.DisplayField = "Project_Name"

                        ProjectTitleCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ProjectTitleCmb.EditValue = "0"
                        If pProjectID <> 0 Then
                            ProjectTitleCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {pProjectID, 0, 0, 0})
                        End If

                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    '#### ALAN
    Private Sub LoadMaterial()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.MaterialBusLogic
            If .GetMaterial(ds) Then
                If Not ds Is Nothing Then
                    Try
                        MaterialCmb.Properties.LookUpData.ListFields.Clear()
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(MaterialCmb, "MaterialDesc", 400, 0, "c")
                        MaterialCmb.Properties.LookUpData.KeyField = "Material_ID"
                        MaterialCmb.Properties.LookUpData.DisplayField = "MaterialDesc"

                        MaterialCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        MaterialCmb.EditValue = "0"
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
                        TypeEnclosureCmb.Properties.LookUpData.ListFields.Clear()
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(TypeEnclosureCmb, "Enclosure_Type", 400, 0, "c")
                        TypeEnclosureCmb.Properties.LookUpData.KeyField = "Enclosure_Id"
                        TypeEnclosureCmb.Properties.LookUpData.DisplayField = "Enclosure_Type"

                        TypeEnclosureCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        TypeEnclosureCmb.EditValue = "0"
                        TypeEnclosureCmb.Properties.LookUpData.KeyValue = Nothing

                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadCustomerDetails(Optional ByVal pCustomer_ID As Integer = 0)
        Dim ds As DataSet

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetCustomerDetails(ds) Then
                If Not ds Is Nothing Then
                    Try
                        CustLookup.Properties.LookUpData.ListFields.Clear()
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(CustLookup, "Name", 400, 0, "c")
                        CustLookup.Properties.LookUpData.KeyField = "Customer_ID"
                        CustLookup.Properties.LookUpData.DisplayField = "Name"

                        CustLookup.Properties.LookUpData.DataSource = ds.Tables(0)
                        CustLookup.EditValue = "0"
                        CustLookup.Properties.LookUpData.KeyValue = Nothing
                        If pCustomer_ID <> 0 Then
                            CustLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {pCustomer_ID, 0, 0, 0})
                        End If
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadContactPerson(ByVal pCustomer_ID As Integer, Optional ByVal pContact_ID As Integer = 0)
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
                    If pContact_ID <> 0 Then
                        ContLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {pContact_ID, 0, 0, 0})
                    End If
                End If
            End If

            'If .GetCustomerDetails(dsAddress, pCustomer_ID) Then
            'If Not dsAddress Is Nothing Then
            'Addresstxt.Text = dsAddress.Tables(0).Rows(0)("Address").ToString
            'End If
            'End If
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
    Private Sub LoadDeliveryTerms()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
            If .GetDeliveryTerms(ds) Then
                If Not ds Is Nothing Then
                    Try
                        DelTermsCmb.Properties.LookUpData.ListFields.Clear()
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(DelTermsCmb, "DeliveryTerms", 400, 0, "c")
                        DelTermsCmb.Properties.LookUpData.KeyField = "DelTerms_ID"
                        DelTermsCmb.Properties.LookUpData.DisplayField = "DeliveryTerms"

                        DelTermsCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        DelTermsCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadPaymentDetails()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.PaymentTermsBusLogic
            If .GetPaymentDetails(ds) Then
                If Not ds Is Nothing Then
                    Try
                        PayDetailsCmb.Properties.LookUpData.ListFields.Clear()
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(PayDetailsCmb, "PayDetails", 400, 0, "c")
                        PayDetailsCmb.Properties.LookUpData.KeyField = "PayDetails_ID"
                        PayDetailsCmb.Properties.LookUpData.DisplayField = "PayDetails"

                        PayDetailsCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        PayDetailsCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
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
        Dim StatusData As String() = New String() {"Incomplete", "Preparing", "Pending", "Confirmed", "Revised", "Cancel", "Lost", "Merged"}
        Dim StatusID As String() = New String() {"80", "10", "20", "30", "40", "50", "60", "70"}
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

        'Dim MaterialData As String() = New String() {"", "AL", "Steel"}
        'Dim MaterialID As String() = New String() {"", "AL", "Steel"}
        'SetComboValue(MaterialData, MaterialCmb, MaterialID)
    End Sub
#End Region

#Region " Code for combo box on close up"
    Private Sub CustLookup_CloseUp1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles CustLookup.CloseUp
        Dim dsContPerson As DataSet
        Dim dsAddress As DataSet

        Customer_ID = CustLookup.Properties.LookUpData.KeyValue

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

    Private Sub CopyFmBxCmb_CloseUp1(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
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
        'TotalAmtTxt.Text = Double.Parse(ds.Tables(0).Rows(0)("Total_Amount"))
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

        Dim TotalOthers As Double = CalculateOthers()
        OthersTxt.Text = TotalOthers

    End Sub
#End Region

#Region " Component Grid Function & Double Click Event & Mouse Right Click"
    Public Sub RefreshComponentGrid()
        Dim ds As DataSet

        If FormType = "ENQUIRY" Then
            Exit Sub
        ElseIf FormType = "BQ" Then
            With New BusinessRules.BQBusRules.BQBusLogic
                .BQ_Line_ID = Quotation_Line_ID
                If .GetBQLineCompOnLineID(ds) Then
                    'If ds.Tables(0).Rows.Count > 0 Then
                    InitGrid()
                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    'Dim CompTotal As Double
                    Dim TotalCost As Double
                    CompTotal = 0
                    'If ds.Tables(0).Rows.Count > 0 Then

                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1
                        TotalCost = oRow("UnitPrice") * oRow("Qty")
                        CompTotal = CompTotal + TotalCost
                        data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand_Name"), oRow("Description"), oRow("Lead_Time"), oRow("Qty"), oRow("UnitPrice"), TotalCost})
                    Next
                    Dim CompMarkupTotal = 0
                    If CompTotal > 0 Then
                        Dim tmp = (100 + Me.NavdsBox.Tables(0).Rows(CurrentRow)("Comp_Markup").ToString) / 100
                        CompMarkupTotal = Decimal.Round((CompTotal * tmp), 2)
                    End If
                    CompGrid1.DataSource = data
                    CompGrid1.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column
                    'CompCostTxt.Text = CompTotal
                    CompCostTxt.Text = CompMarkupTotal

                    'Summary at the footer of the grid
                    'GridView1.Columns("Total").SummaryItem.SummaryType = SummaryItemType.Sum
                    'GridView1.ViewOptions = GridView1.ViewOptions Or ViewOptionsFlags.ShowFooter

                    'End If
                End If
            End With
        Else 'Quotation
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
                    'If ds.Tables(0).Rows.Count > 0 Then

                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1
                        TotalCost = oRow("UnitPrice") * oRow("Qty")
                        CompTotal = CompTotal + TotalCost
                        data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand_Name"), oRow("Description"), oRow("Lead_Time"), oRow("Qty"), oRow("UnitPrice"), TotalCost})
                    Next
                    Dim CompMarkupTotal = 0
                    If CompTotal > 0 Then
                        Dim tmp = (100 + Me.NavdsBox.Tables(0).Rows(CurrentRow)("Comp_Markup").ToString) / 100
                        CompMarkupTotal = Decimal.Round((CompTotal * tmp), 2)
                    End If
                    CompGrid1.DataSource = data
                    CompGrid1.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column
                    'CompCostTxt.Text = CompTotal
                    CompCostTxt.Text = CompMarkupTotal

                    'Summary at the footer of the grid
                    'GridView1.Columns("Total").SummaryItem.SummaryType = SummaryItemType.Sum
                    'GridView1.ViewOptions = GridView1.ViewOptions Or ViewOptionsFlags.ShowFooter

                    'End If
                End If
            End With
        End If



    End Sub

    Public Sub RefreshComponentGrid_Enquiry()
        Dim ds As DataSet
        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
            .Enquiry_Line_ID = Quotation_Line_ID
        End With
    End Sub


    Public Function CheckDuplicateComponents(ByVal pProductId) As Boolean

        CheckDuplicateComponents = False
        Dim oRow As DataRow

        Dim ds As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_Line_ID = Quotation_Line_ID
            If .GetQuotationLineCompOnLineID(ds) Then
                For Each oRow In ds.Tables(0).Rows
                    If oRow("Product_ID") = pProductId Then
                        CheckDuplicateComponents = True
                        MessageBox.Show("Component already exist in this box!")
                        Exit For
                    End If
                Next
            End If
        End With


    End Function


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

            Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Component_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                DeleteLineComponent(Component_ID)
            End If
        End If
    End Sub

    Private Sub CompGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles XtraButton2.Click

        If FormStatus <> "VIEW" And Status <> "20" And Status <> "30" Then

            Dim NewForm As New SelectProductForm
            NewForm.Quotation_Line_ID = Quotation_Line_ID
            NewForm.Quotation_ID = Quotation_ID

            NewForm.Status = "ADD"


            'If (NewForm.ShowDialog(Me) = True) Then
            'RefreshComponentGrid()
            'MsgBoxFlag = False
            'UpdateBtn_Click(sender, e)
            'End If
            NewForm.FormType = Me.FormType
            NewForm.CurrentProductForm_TabIndex = CurrentProductForm_TabIndex
            NewForm.ShowDialog(Me)

        End If

    End Sub

    Private Sub CompGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CompGrid1.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        Dim eventString As String = Nothing
        Select Case e.Button
            Case MouseButtons.Left
                eventString = "L"
            Case MouseButtons.Right
                eventString = "R"
                If FormStatus <> "VIEW" Then
                    ComponentContextMenu.Show(sender, mouseDownLocation)
                End If
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click, CompGrid1.DoubleClick
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim Component_ID As Integer = dr(1)

                If Component_ID > 0 Then
                    Dim NewForm As New SelectProductForm
                    NewForm.FormType = FormType
                    NewForm.Component_ID = Component_ID
                    NewForm.Status = "EDIT"
                    NewForm.ShowDialog(Me)
                    RefreshComponentGrid()
                End If
            End If
        End If
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim Component_ID As Integer = dr(1)
                Dim Component_Name As String = dr(4)

                If Component_ID > 0 Then
                    Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Component_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                    If Result = DialogResult.Yes Then
                        DeleteLineComponent(Component_ID)
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region " Buttons - Component, Box "

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click, MenuItem2.Click

        OnLineLoading = True

        ResetQuotationLine()
        '1.11.2003 YG Start
        If OrderType = 1 Then
            BoxCategoryCmb.Enabled = False
        Else
            BoxCategoryCmb.Enabled = True
            BoxCategoryCmb.Properties.LookUpData.KeyValue = CType(1, Decimal) 'Default as Box W component
            BoxCategory_ID = BoxCategoryCmb.Properties.LookUpData.KeyValue
        End If

        '1.11.2003 YG End
        LineNo = LineNo + 1
        ItemNo = LineNo.ToString
        ItemNoTxt.Text = ItemNo
        If FormType = "ENQUIRY" Then
            AddEnquiryLine(sender)
        ElseIf FormType = "BQ" Then
            AddBQLine(sender)
        Else
            AddQuotationLine(sender)
        End If
        BoxDescTxt.Select()
        OnLineLoading = False

    End Sub

    Private Sub AddQuotationLine(ByVal sender As System.Object)
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Quotation_ID
            .ItemNo = ItemNo
            .UserID = UserID
            .Overall_Markup = 1
            .Qty = 1
            .BoxCategory_ID = BoxCategory_ID
            If .SaveQuotationLineFirstTime() Then
                Quotation_Line_ID = .Quotation_Line_ID
                CompGrid1.Enabled = True
                'SaveQuoBtn.Enabled = True
                RefreshNavBtn()
                EnableButtons()
                NavLastBtn_Click(sender, Nothing)
                Me.OverallMarkTxt.Text = 1
                'AddBtn.Enabled = False
                'NavFirstBtn.Enabled = False
                'NavNextBtn.Enabled = False
                'NavLastBtn.Enabled = False
                'NavPrevBtn.Enabled = False
                CopyFmBxCmb.Enabled = True
            End If
        End With
    End Sub

    Private Sub AddBQLine(ByVal sender As System.Object)
        With New BusinessRules.BQBusRules.BQBusLogic
            .BQ_ID = Quotation_ID
            .ItemNo = ItemNo
            .UserID = UserID
            .Overall_Markup = 1
            .BoxCategory_ID = BoxCategory_ID
            If .SaveBQLineFirstTime() Then
                Quotation_Line_ID = .BQ_Line_ID
                CompGrid1.Enabled = True
                'SaveQuoBtn.Enabled = True
                RefreshNavBtn_BQ()
                EnableButtons()
                NavLastBtn_Click(sender, Nothing)
                Me.OverallMarkTxt.Text = 1
                'AddBtn.Enabled = False
                'NavFirstBtn.Enabled = False
                'NavNextBtn.Enabled = False
                'NavLastBtn.Enabled = False
                'NavPrevBtn.Enabled = False
                CopyFmBxCmb.Enabled = True
            End If
        End With
    End Sub

    Private Sub AddEnquiryLine(ByVal sender As System.Object)
        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic

            .Enquiry_ID = Quotation_ID
            .ItemNo = ItemNo
            .UserID = UserID
            .Overall_Markup = 1
            .Qty = 1
            .BoxCategory_ID = BoxCategory_ID
            If .SaveEnquiryLineFirstTime() Then
                Quotation_Line_ID = .Enquiry_Line_ID
                CompGrid1.Enabled = True
                'SaveQuoBtn.Enabled = True
                RefreshNavBtn_Enquiry()
                EnableButtons()
                NavLastBtn_Click(sender, Nothing)
                Me.OverallMarkTxt.Text = 1
                'AddBtn.Enabled = False
                'NavFirstBtn.Enabled = False
                'NavNextBtn.Enabled = False
                'NavLastBtn.Enabled = False
                'NavPrevBtn.Enabled = False
                CopyFmBxCmb.Enabled = True
            End If
        End With
    End Sub

    Public Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        RetrieveFromLineForm()
        If FormType = "ENQUIRY" Then
            SaveEnquiryLineProcess()
            RefreshNavBtn_Enquiry()
        ElseIf FormType = "BQ" Then
            SaveBQLineProcess()
            RefreshNavBtn_BQ()
        Else
            SaveQuotationLineProcess()
            RefreshNavBtn()
        End If
        AddBtn.Enabled = True
        NavFirstBtn.Enabled = True
        NavNextBtn.Enabled = True
        NavLastBtn.Enabled = True
        NavPrevBtn.Enabled = True
        CopyFmBxCmb.Enabled = False
        EditFlag = False

        LineEdited = False
        UpdateBtn.Enabled = False
    End Sub

    Private Sub DelProdBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelProdBtn.Click, MenuItem4.Click
        If FormType = "ENQUIRY" Then
            DeleteEnquiryLine()
        ElseIf FormType = "BQ" Then
            DeleteBQLine()
        Else
            DeleteQuotationLine()
        End If
    End Sub

    Private Sub DeleteQuotationLine()

        Me.OnLineLoading = True

        If NavdsBox.Tables(0).Rows.Count > 0 Then
            'MessageBox.Show(Quotation_Line_ID)

            Dim Result As DialogResult = MessageBox.Show("Delete the selected item(s)? ", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                With New BusinessRules.SaleBusRules.SaleBusLogic

                    If GridView2.SelectedRowsCount > 1 Then
                        Dim SelectedRows As Int32() = GridView2.GetSelectedRows()
                        For Each item As Int32 In SelectedRows

                            .Quotation_Line_ID = GridView2.GetDataRow(item)("quotation_line_id")
                            If .DeleteQuotationLine(False) Then
                                'MessageBox.Show("Item Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                CurrentRow = 0
                            End If
                        Next

                        .Quotation_ID = Quotation_ID
                        .ReAdjustQuotationLineItemNo()

                    Else
                        .Quotation_Line_ID = Quotation_Line_ID
                        .ItemNo = Me.ItemNoTxt.Text
                        .Quotation_ID = Quotation_ID
                        If .DeleteQuotationLine() Then
                            'MessageBox.Show("Item Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If CurrentRow >= GridView2.RowCount - 1 Then
                                CurrentRow = CurrentRow - 1
                            End If
                        End If

                    End If

                End With
                

                RefreshNavBtn()

                If (GridView2.RowCount > 1) Then
                    If GridView2.FocusedRowHandle >= 0 And GridView2.FocusedRowHandle <= GridView2.RowCount Then

                        CurrentRow = GridView2.FocusedRowHandle

                    Else
                        GridView2.FocusedRowHandle = 0
                        CurrentRow = GridView2.FocusedRowHandle
                    End If

                    GridView2.UnselectRow(0)

                End If

                GridView2.SelectRow(CurrentRow)

                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                Else
                    ResetQuotationLine()
                End If
            End If
        End If

        OnLineLoading = False

    End Sub



    Private Sub DeleteEnquiryLine()
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            'MessageBox.Show(Quotation_Line_ID)
            Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
                    .Enquiry_Line_ID = Quotation_Line_ID
                    If .DeleteEnquiryLine() Then
                        'MessageBox.Show("Item Deleted.", "Enquiry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With

                RefreshNavBtn_Enquiry()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                Else
                    ResetQuotationLine()
                End If
            End If
        End If
    End Sub

    Private Sub DeleteBQLine()
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            'MessageBox.Show(Quotation_Line_ID)
            Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                With New BusinessRules.BQBusRules.BQBusLogic
                    .BQ_Line_ID = Quotation_Line_ID
                    If .DeleteBQLine() Then
                        'MessageBox.Show("Item Deleted.", "BQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With

                RefreshNavBtn_BQ()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                Else
                    ResetQuotationLine()
                End If
            End If
        End If
    End Sub

    Private Sub ResetQuotationLine()
        '** Box Tab **
        'ItemNo = ItemNo + 1
        'ItemNoTxt.Text = ItemNo
        BoxDescTxt.Text = ""
        PanelCostTxt.Text = ""
        OverallMarkTxt.Text = "1"
        CompMarkTxt.Text = ""
        QtyTxt.Text = "0"
        'TotalAmtTxt.Text = ""
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

        OnLineLoading = True

        '** Box Tab **
        ItemNo = ItemNoTxt.Text
        'Remove Space Padding in Box Description
        BoxDescTxt.Text = Trim(BoxDescTxt.Text)

        'Remove Carriage Return/new line at start and End
        'BoxDescTxt.Text.Substring(BoxDescTxt.Text.IndexOf(vbCrLf), Len(BoxDescTxt.Text))
        'BoxDescTxt.Text.Substring(0, BoxDescTxt.Text.LastIndexOf(vbCrLf))
        If BoxDescTxt.Text.Length >= 2 Then
            While BoxDescTxt.Text.Substring(0, 2) = vbCrLf
                BoxDescTxt.Text = BoxDescTxt.Text.Substring(2, Len(BoxDescTxt.Text) - 2)
            End While

        End If
        If BoxDescTxt.Text.Length >= 2 Then
            While BoxDescTxt.Text.Substring(Len(BoxDescTxt.Text) - 2, 2) = vbCrLf
                BoxDescTxt.Text = BoxDescTxt.Text.Substring(0, Len(BoxDescTxt.Text) - 2)
            End While
        End If

        Box = BoxDescTxt.Text
        LineRemarks = Remarks_MemoEdit.Text

        BoxCategory_ID = BoxCategoryCmb.Properties.LookUpData.KeyValue

        Product_ID = Product_cmb.Properties.LookUpData.KeyValue

        If OverallMarkTxt.Text <> Nothing Then
            If OverallMarkTxt.Text = 0 Then
                OverallMarkTxt.Text = 1
            End If
            Overall_Markup = OverallMarkTxt.Text
        End If
        If QtyTxt.Text <> Nothing Then
            Qty = QtyTxt.Text
        End If
        If CompMarkTxt.Text <> Nothing Then
            Comp_Markup = CompMarkTxt.Text
        End If
        If UnitPrice_Txt.Text <> Nothing Then
            UnitPrice = UnitPrice_Txt.Text
        End If
        '****

        '** Enclosure Tab **
        If HeightTxt.Text <> Nothing Then
            varHeight = HeightTxt.Text
        End If
        If WidthTxt.Text <> Nothing Then
            varWidth = WidthTxt.Text
        End If
        If DepthTxt.Text <> Nothing Then
            Depth = DepthTxt.Text
        End If
        Raw_Material = MaterialCmb.Properties.LookUpData.KeyValue
        If MatCostTxt.Text <> Nothing Then
            Material_Cost = MatCostTxt.Text
        End If
        Type = Typetxt.Text
        If ThicknessTxt.Text <> Nothing Then
            Thickness = ThicknessTxt.Text
        End If
        If PowerCoatTxt.Text <> Nothing Then
            Power_Coat = PowerCoatTxt.Text
        End If
        Type_Of_Enclosure = TypeEnclosureCmb.Properties.LookUpData.KeyValue
        '****

        'Constant
        Dim InLabCostRate As Double
        '** Get Markup Factor %
        With New BusinessRules.SystemBusRules.EnclosureBusLogic
            If .GetMarkupFactor(Type_Of_Enclosure) Then
                InLabCostRate = .Markup_Factor
            End If
        End With

        Dim IntCostRate As Double
        IntCostRate = 40.0 'Intermediate Cost Rate

        Dim HWCostRate As Double
        HWCostRate = 20.0 'Hardware fixtures cost rate

        Dim ProfitRate As Double
        ProfitRate = 20.0 ' Profit Rate

        Dim PacDelCostRate As Double
        PacDelCostRate = 10.0 'Packaging & delivery cost rate

        'NOT USED!! This value of 6.0 is used in Sales Organiser!
        Dim PCoatUCostRate As Double
        PCoatUCostRate = 6.0 'Powder coating unit cost per m2

        Dim PCoatMinCost As Double
        PCoatMinCost = 0.3

        '** Calculate M/M
        Dim MM As Double = Material_Cost / 2.9768 '(1220/1000) * (2440/1000)= 2.9768

        '** Convert mm to metre
        Dim Hm = varHeight / 1000
        Dim Wm = varWidth / 1000
        Dim Dm = Depth / 1000

        '** Calculate Surface Area
        Dim SA
        SA = ((Hm * Wm) + (Wm * Dm) + (Dm * Hm)) * 2.0

        'Total Surface Area
        Dim TSA
        TSA = SA + (SA * (IntCostRate / 100.0))

        '** Calculate Surface Area Material Cost
        Dim SAMC
        SAMC = MM * TSA

        '** Calculate Power Coat Cost
        Dim PC
        PC = Power_Coat * (2 * TSA)

        '** Calculate Labour Cost
        Dim LC
        LC = (SAMC + PC) * (InLabCostRate / 100)

        'Total Hardware cost
        Dim HC
        HC = (SAMC + PC + LC) * (HWCostRate / 100)

        'Profit Margin
        Dim PM
        PM = (SAMC + PC + LC + HC) * (ProfitRate / 100)

        'Delivery Cost
        Dim DC
        DC = (SAMC + PC + LC + HC + PM) * (PacDelCostRate / 100)

        '** Get All 4 cost Total
        Dim CCost
        CCost = SAMC + PC + LC + HC + PM + DC


        '** Calculate Total Markup 
        'Dim totalMarkupPercent = (100 + MUFactor) / 100
        'Enclosure = Decimal.Round((totalMarkupPercent * CCost), 2)
        Enclosure = Decimal.Round(CCost, 2)
        EnclosureTxt.Text = Enclosure
        '***

        'GrandTotal = GrandTotal + Enclosure

        '** Calculate Comp after Markup
        'Comp_Markup = CompMarkTxt.Text
        If Comp_Markup <> 0 And Comp_Markup <> Nothing Then
            Dim tmp = (100 + Comp_Markup) / 100
            Dim CompMarkupTotal = Decimal.Round((CompTotal * tmp), 2)

            '** Component Cost
            CompCostTxt.Text = CompMarkupTotal
        Else
            CompCostTxt.Text = CompTotal
        End If

        Dim TotalOthers As Double = 0
        TotalOthers = CalculateOthers()

        OthersTxt.Text = TotalOthers

        '** Calculate Overall Markup
        'Overall_Markup = OverallMarkTxt.Text

        If Overall_Markup <> 0 And Overall_Markup <> Nothing Then
            'Dim tmpTotal = (100 + Overall_Markup) / 100

            '** Calculate Total Panel Cost
            Cost = (CompCostTxt.Text + Enclosure + TotalOthers) / Overall_Markup

            'Total_Amount = Decimal.Round((Total_Amount * tmpTotal), 2)
        Else
            Cost = CompCostTxt.Text + Enclosure + TotalOthers

        End If

        '** Round up to the nearest ten....
        Dim SmallestDollar
        SmallestDollar = GetSmallestDollar(Cost)

        If SmallestDollar >= 0.5 Then
            Cost = (Cost - SmallestDollar) + 10
        Else
            Cost = (Cost - SmallestDollar)
        End If

        PanelCostTxt.Text = Decimal.Round((Cost), 2)

        '** Calculate Total Amount
        'Total_Amount = Qty * Cost

        If True Then 'BoxCategoryCmb.Text.ToUpper = "TRADING ITEM" Then
            Total_Amount = Qty * UnitPrice
        Else
            UnitPrice_Txt.Text = PanelCostTxt.Text
        End If

        '** After Markup value on total amt
        'TotalAmtTxt.Text = Decimal.Round((Total_Amount), 2)

        GrandTotal = Decimal.Round((GrandTotal + Total_Amount), 0)

        OnLineLoading = False


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
                .UnitPrice = UnitPrice
                .Concrete_Base = Concrete_Base
                .Transport = Transport
                .Enclosure = Enclosure
                .Qty = Qty
                .Cost = UnitPrice
                Cost = UnitPrice
                'If Me.BoxCategoryCmb.Text.ToUpper = "TRADING ITEM" Then
                '.Cost = UnitPrice
                'Cost = UnitPrice
                'Else
                '.Cost = Cost
                'End If
                '.Cost = Cost
                .Overall_Markup = Overall_Markup
                .Total_Amount = Total_Amount
                .OC_EF = OC_EF
                .Incoming = Incoming
                .Panel_Transport = Panel_Transport
                .Installation = Installation
                .Type_Of_Enclosure = Type_Of_Enclosure
                .BoxCategory_ID = BoxCategory_ID
                .LineRemarks = LineRemarks

                .UserID = UserID
                If .UpdateQuotationLine() Then
                    Quotation_Line_ID = .Quotation_Line_ID
                    If MsgBoxFlag = True Then
                        'MessageBox.Show("Data saved. ", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    If MsgBoxFlag = False Then
                    End If
                    MsgBoxFlag = True
                End If
            End If
        End With
    End Sub

    Private Sub SaveBQLineProcess()
        With New BusinessRules.BQBusRules.BQBusLogic()
            If ValidDataForLine() Then
                .BQ_Line_ID = Quotation_Line_ID
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
                .UnitPrice = UnitPrice
                .Concrete_Base = Concrete_Base
                .Transport = Transport
                .Enclosure = Enclosure
                .Qty = Qty
                If Me.BoxCategoryCmb.Text.ToUpper = "TRADING ITEM" Then
                    .Cost = UnitPrice
                    Cost = UnitPrice
                Else
                    .Cost = Cost
                End If
                '.Cost = Cost
                .Overall_Markup = Overall_Markup
                .Total_Amount = Total_Amount
                .OC_EF = OC_EF
                .Incoming = Incoming
                .Panel_Transport = Panel_Transport
                .Installation = Installation
                .Type_Of_Enclosure = Type_Of_Enclosure
                .BoxCategory_ID = BoxCategory_ID

                .UserID = UserID
                If .UpdateBQLine() Then
                    Quotation_Line_ID = .BQ_Line_ID
                    If MsgBoxFlag = True Then
                        MessageBox.Show("Data saved. ", "BQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    If MsgBoxFlag = False Then
                    End If
                    MsgBoxFlag = True
                End If
            End If
        End With
    End Sub

    Private Sub SaveEnquiryLineProcess()
        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
            If ValidDataForLine() Then
                .Enquiry_Line_ID = Quotation_Line_ID
                .ItemNo = ItemNo
                .Box = Box
                .Product_ID = Product_ID
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
                .UnitPrice = UnitPrice
                .Concrete_Base = Concrete_Base
                .Transport = Transport
                .Enclosure = Enclosure
                .Qty = Qty
                If Me.BoxCategoryCmb.Text.ToUpper = "TRADING ITEM" Then
                    .Cost = UnitPrice
                    Cost = UnitPrice
                Else
                    .Cost = Cost
                End If
                '.Cost = Cost
                .Overall_Markup = Overall_Markup
                .Total_Amount = Total_Amount
                .OC_EF = OC_EF
                .Incoming = Incoming
                .Panel_Transport = Panel_Transport
                .Installation = Installation
                .Type_Of_Enclosure = Type_Of_Enclosure
                .BoxCategory_ID = BoxCategory_ID
                .Product_ID = Product_ID

                .UserID = UserID
                If .UpdateEnquiryLine() Then
                    Quotation_Line_ID = .Enquiry_Line_ID
                    If MsgBoxFlag = True Then
                        MessageBox.Show("Data saved. ", "Enquiry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    If MsgBoxFlag = False Then
                    End If
                    MsgBoxFlag = True
                End If
            End If
        End With
    End Sub

    Private Function ValidDataForLine()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If FormType = "ENQUIRY" Then

        ElseIf FormType = "BQ" Then

        Else
            If Not Len(Box) > 0 Then
                DataOK_Flag = False
                FieldName = "Box" & Chr(13)
            End If

            '1.11.2003 YG Start
            If OrderType <> "1" Then ' do not validate for Service/Trading Quotation
                If Not Len(BoxCategory_ID) > 0 Or BoxCategory_ID = 0 Then
                    DataOK_Flag = False
                    FieldName = FieldName & "Box Category" & Chr(13)
                End If
            End If
            '1.11.2003 YG End
        End If



        ' 01.11.2003 YG 
        If Qty = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Qty" & Chr(13)
        End If

        ' 29.10.2003 YG Start
        If OrderType <> "1" Then ' do not validate for Service/Trading Quotation
            If False Then 'varHeight = 0 Then
                DataOK_Flag = False
                FieldName = FieldName & "Height" & Chr(13)
            End If

            If False Then 'varWidth = 0 Then
                DataOK_Flag = False
                FieldName = FieldName & "Length" & Chr(13)
            End If

            If False Then 'Depth = 0 Then
                DataOK_Flag = False
                FieldName = FieldName & "Depth" & Chr(13)
            End If

            If False Then 'Material_Cost = 0 Then
                DataOK_Flag = False
                FieldName = FieldName & "Material Cost" & Chr(13)
            End If

            If False Then 'Power_Coat = 0 Then
                DataOK_Flag = False
                FieldName = FieldName & "Power Coat" & Chr(13)
            End If

            If False Then 'Not Len(Type_Of_Enclosure) > 0 Or Type_Of_Enclosure = 0 Then
                DataOK_Flag = False
                FieldName = FieldName & "Type Of Enclosure" & Chr(13)
            End If
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidDataForLine = DataOK_Flag
    End Function

    Private Sub DeleteLineComponent(ByVal pComponent_ID As Integer)

        If FormType = "ENQUIRY" Then
            DeleteENQUIRYLineComponent(pComponent_ID)
        ElseIf FormType = "BQ" Then
            DeleteBQLineComponent(pComponent_ID)
        Else 'QUOTATION
            DeleteQUOTATIONLineComponent(pComponent_ID)
        End If

    End Sub

    Private Sub DeleteBQLineComponent(ByVal pComponent_ID As Integer)
        With New BusinessRules.BQBusRules.BQBusLogic
            .Component_ID = pComponent_ID
            If .DeleteBQLineComponent Then
                RefreshComponentGrid()
                'MessageBox.Show("Component Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub DeleteQUOTATIONLineComponent(ByVal pComponent_ID As Integer)
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Component_ID = pComponent_ID
            If .DeleteQuotationLineComponent Then
                RefreshComponentGrid()
                'MessageBox.Show("Component Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub DeleteENQUIRYLineComponent(ByVal pComponent_ID As Integer)
        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
            .Component_ID = pComponent_ID
            If .DeleteEnquiryLineComponent Then
                RefreshComponentGrid()
                'MessageBox.Show("Component Deleted.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub
#End Region

#Region " Main Quotation Saving Btn, Close, Save Function, Retrieve from form"


    Private Sub RetrieveFromMainForm()
        Customer_ID = CustLookup.Properties.LookUpData.KeyValue
        Contact_ID = ContLookup.Properties.LookUpData.KeyValue
        ' Start YG 6 Sep added
        QuotationNo = QuoNoTxt.Text
        ' End
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

        'If Len(PayDetailsCmb.Text) > 0 Then
        Payment_Term = PayDetailsCmb.Properties.LookUpData.KeyValue
        'Payment_Term = PayDetailsCmb.Text
        'End If

        'If Len(DelTermsCmb.Text) > 0 Then
        Delivery_Term = DelTermsCmb.Properties.LookUpData.KeyValue
        'Delivery_Term = DelTermsCmb.Text
        'End If
        Service_Type = ServiceTypeCmb.Properties.LookUpData.KeyValue
        Sign_By = SignByCmb.Properties.LookUpData.KeyValue
        If IsNumeric(GrandTotalTxt.Text) Then
            Total_Cost_Numeric = GrandTotalTxt.Text
        End If
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
        Dim Result As DialogResult
        Dim qlds As DataSet
        Dim qlcds As DataSet
        Dim pQuotation_Line_ID
        Dim nocomp As Boolean

        With New BusinessRules.SaleBusRules.SaleBusLogic

            If Not ValidDataHeader() Then
                Result = MessageBox.Show("You have incomplete entries. Proceed to save?", "Saving quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Status = "80"

                'ElseIf Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                '    Result = MessageBox.Show("You have no items(BOX) added. Proceed to save?", "Saving quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                '    Status = "80"
            Else
                If Status = "80" Then
                    Status = "10"
                    StatusCmb.Properties.LookUpData.KeyValue = "10"
                End If
                '.Quotation_ID = Quotation_ID
                'If .GetQuotationLine(qlds) Then
                'nocomp = True
                'For i As Integer = 0 To qlds.Tables(0).Rows.Count - 1
                '.Quotation_Line_ID = qlds.Tables(0).Rows(i)("Quotation_Line_ID")
                'If .GetQuotationLineCompOnLineID(qlcds) Then
                'If Not qlcds.Tables(0).Rows.Count = 0 Then
                'nocomp = False
                'End If
                'End If
                '   Next
                'If nocomp = True Then
                '   Status = "80"
                'End If
                'End If
            End If

            If Result = DialogResult.Yes Or Result = DialogResult.None Then 'ValidDataHeader() Then
                .Quotation_ID = Quotation_ID
                .Quotation_No = QuotationNo
                .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(QuotationDate) & "/" & Month(QuotationDate) & "/" & Year(QuotationDate)
                .Status = Status
                .ProjectSub = ProjectSub
                .Project = Project
                .Customer_ID = Customer_ID
                .Contact_ID = Contact_ID
                .Payment_Term = Payment_Term
                .Validity = Validity
                .Delivery_Term = Delivery_Term
                .Order_Type = OrderType
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
                .Total_Cost_Text = DollarToString(.Total_Cost_Numeric)
                If UCase(FormStatus) = "REVISED" Then
                    .RevRefQuotationID = RevRefQuotationID
                End If
                If .UpdateQuotationHeader() Then
                    'unnecessary prompt
                    'MessageBox.Show("Quotation Saved.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.SaveQuoBtn.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub SaveMainFormProcess_BQ()
        Dim Result As DialogResult
        Dim qlds As DataSet
        Dim qlcds As DataSet
        Dim pQuotation_Line_ID
        Dim nocomp As Boolean

        With New BusinessRules.BQBusRules.BQBusLogic

            If Not BQ_ValidDataHeader() Then
                Result = MessageBox.Show("You have incomplete entries. Proceed to save?", "Saving BQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Status = "80"

                'ElseIf Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                '    Result = MessageBox.Show("You have no items(BOX) added. Proceed to save?", "Saving quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                '    Status = "80"
            Else
                If Status = "80" Then
                    Status = "10"
                    StatusCmb.Properties.LookUpData.KeyValue = "10"
                End If
                '.Quotation_ID = Quotation_ID
                'If .GetQuotationLine(qlds) Then
                'nocomp = True
                'For i As Integer = 0 To qlds.Tables(0).Rows.Count - 1
                '.Quotation_Line_ID = qlds.Tables(0).Rows(i)("Quotation_Line_ID")
                'If .GetQuotationLineCompOnLineID(qlcds) Then
                'If Not qlcds.Tables(0).Rows.Count = 0 Then
                'nocomp = False
                'End If
                'End If
                '   Next
                'If nocomp = True Then
                '   Status = "80"
                'End If
                'End If
            End If

            If Result = DialogResult.Yes Or Result = DialogResult.None Then 'ValidDataHeader() Then
                .BQ_ID = Quotation_ID
                .BQ_No = QuotationNo

                If QuotationDate <> "" Then
                    .BQDate = Microsoft.VisualBasic.DateAndTime.Day(QuotationDate) & "/" & Month(QuotationDate) & "/" & Year(QuotationDate)
                End If

                .Status = Status
                .ProjectSub = ProjectSub
                .Project = Project
                .Customer_ID = Customer_ID
                .Contact_ID = Contact_ID
                .Payment_Term = Payment_Term
                .Validity = Validity
                .Delivery_Term = Delivery_Term
                .Order_Type = OrderType
                .Service_Type = Service_Type
                .CP5_Flg = CP5_Flg
                .Sign_By = Sign_By
                .Remarks = Remarks
                .ClosingNotes = ClosingNotes
                .OtherNotes = OtherNotes
                .Consultant_ID = Consultant_ID
                .UserID = UserID
                .RefBQID = RefQuotationID
                .PriceInclude_ID = PriceInclude_ID
                .Total_Cost_Numeric = Total_Cost_Numeric
                .Total_Cost_Text = DollarToString(.Total_Cost_Numeric)
                If UCase(FormStatus) = "REVISED" Then
                    .RevRefBQID = RevRefQuotationID
                End If
                If .UpdateBQHeader() Then
                    MessageBox.Show("BQ Saved.", "BQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub

    Private Sub SaveMainFormProcess_Enquiry()
        Dim Result As DialogResult
        Dim qlds As DataSet
        Dim qlcds As DataSet
        Dim pQuotation_Line_ID
        Dim nocomp As Boolean

        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic

            If Not Enquiry_ValidDataHeader() Then
                Result = MessageBox.Show("You have incomplete entries. Proceed to save?", "Saving Enquiry", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Status = "80"

                'ElseIf Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                '    Result = MessageBox.Show("You have no items(BOX) added. Proceed to save?", "Saving quotation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                '    Status = "80"
            Else
                If Status = "80" Then
                    Status = "10"
                    StatusCmb.Properties.LookUpData.KeyValue = "10"
                End If
                '.Quotation_ID = Quotation_ID
                'If .GetQuotationLine(qlds) Then
                'nocomp = True
                'For i As Integer = 0 To qlds.Tables(0).Rows.Count - 1
                '.Quotation_Line_ID = qlds.Tables(0).Rows(i)("Quotation_Line_ID")
                'If .GetQuotationLineCompOnLineID(qlcds) Then
                'If Not qlcds.Tables(0).Rows.Count = 0 Then
                'nocomp = False
                'End If
                'End If
                '   Next
                'If nocomp = True Then
                '   Status = "80"
                'End If
                'End If
            End If

            If Result = DialogResult.Yes Or Result = DialogResult.None Then 'ValidDataHeader() Then
                .Enquiry_ID = Quotation_ID
                .Enquiry_No = QuotationNo
                .EnquiryDate = Microsoft.VisualBasic.DateAndTime.Day(QuotationDate) & "/" & Month(QuotationDate) & "/" & Year(QuotationDate)
                .Status = Status
                .ProjectSub = ProjectSub
                .Project = Project
                .Customer_ID = Customer_ID
                .Contact_ID = Contact_ID
                .Payment_Term = Payment_Term
                .Validity = Validity
                .Delivery_Term = Delivery_Term
                .Order_Type = OrderType
                .Service_Type = Service_Type
                .CP5_Flg = CP5_Flg
                .Sign_By = Sign_By
                .Remarks = Remarks
                .ClosingNotes = ClosingNotes
                .OtherNotes = OtherNotes
                .Consultant_ID = Consultant_ID
                .UserID = UserID
                .RefEnquiryID = RefQuotationID
                .PriceInclude_ID = PriceInclude_ID
                .Total_Cost_Numeric = Total_Cost_Numeric
                .Total_Cost_Text = DollarToString(.Total_Cost_Numeric)
                If UCase(FormStatus) = "REVISED" Then
                    .RevRefEnquiryID = RevRefQuotationID
                End If
                If .UpdateEnquiryHeader() Then
                    MessageBox.Show("Enquiry Saved.", "Enquiry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub


    Private Function ValidDataHeader()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        ' 21.09.2003 YG Fix validation problem
        'Customer, Contact not checked

        If Not Len(QuotationNo) > 0 Then
            DataOK_Flag = False
            FieldName = "Quotation No" & Chr(13)
        End If

        If Not Len(QuotationDate) > 0 Then
            DataOK_Flag = False
            FieldName = "Date" & Chr(13)
        End If

        If Not Customer_ID > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Customer Name" & Chr(13)
        End If

        If Not Contact_ID > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Contact Person" & Chr(13)
        End If

        If Not Len(Project) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Project" & Chr(13)
        End If

        If Not Len(Payment_Term) > 0 Or Payment_Term = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Payment Term" & Chr(13)
        End If

        If Not Len(Delivery_Term) > 0 Or Delivery_Term = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Delivery Term" & Chr(13)
        End If

        'Request by Nanita to be optional
        'If Not PriceInclude_ID > 0 Then
        'DataOK_Flag = False
        'FieldName = FieldName & " Price Include Till" & Chr(13)
        'End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidDataHeader = DataOK_Flag
    End Function

    Private Function BQ_ValidDataHeader()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        ' 21.09.2003 YG Fix validation problem
        'Customer, Contact not checked

        If Not Len(QuotationNo) > 0 Then
            DataOK_Flag = False
            FieldName = "Quotation No" & Chr(13)
        End If

        If Not Len(QuotationDate) > 0 Then
            DataOK_Flag = False
            FieldName = "Date" & Chr(13)
        End If

        If Not Customer_ID > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Customer Name" & Chr(13)
        End If

        If Not Contact_ID > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Contact Person" & Chr(13)
        End If

        If Not Len(Project) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Project" & Chr(13)
        End If

        'Request by Nanita to be optional
        'If Not PriceInclude_ID > 0 Then
        'DataOK_Flag = False
        'FieldName = FieldName & " Price Include Till" & Chr(13)
        'End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        BQ_ValidDataHeader = DataOK_Flag
    End Function

    Private Function Enquiry_ValidDataHeader()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        ' 21.09.2003 YG Fix validation problem
        'Customer, Contact not checked

        If Not Len(QuotationNo) > 0 Then
            DataOK_Flag = False
            FieldName = "Enquiry No" & Chr(13)
        End If

        If Not Len(QuotationDate) > 0 Then
            DataOK_Flag = False
            FieldName = "Date" & Chr(13)
        End If

        If Not Customer_ID > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Customer Name" & Chr(13)
        End If

        If Not Contact_ID > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Contact Person" & Chr(13)
        End If

        If Not Len(Project) > 0 Then
            DataOK_Flag = False
            FieldName = FieldName & " Project" & Chr(13)
        End If

        'Request by Nanita to be optional
        'If Not PriceInclude_ID > 0 Then
        'DataOK_Flag = False
        'FieldName = FieldName & " Price Include Till" & Chr(13)
        'End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        Enquiry_ValidDataHeader = DataOK_Flag
    End Function
#End Region

#Region " Navigation "

    Private Sub DisableNavBtn()
        Me.NavFirstBtn.Enabled = False
        Me.NavLastBtn.Enabled = False
        Me.NavNextBtn.Enabled = False
        Me.NavPrevBtn.Enabled = False
        DelProdBtn.Enabled = False
        UpdateBtn.Enabled = False
        lblNavLocation.Text = ""
        ItemNoTxt.Text = ""
        BoxDescTxt_TextEdit.Text = ""
        item_TabControl.TabIndex = 1

        OverallMarkTxt.Text = "1"
        CompMarkTxt.Text = ""

        'itemedit_Panel.Enabled = False
        itemEntry_Panel.Enabled = False
        itemEntry2_Panel.Enabled = False
        item_TabControl.Enabled = False
        CompGrid1.Enabled = False


    End Sub

    Private Sub EnableNavBtn()
        Me.NavFirstBtn.Enabled = True
        Me.NavLastBtn.Enabled = True
        Me.NavNextBtn.Enabled = True
        Me.NavPrevBtn.Enabled = True
        DelProdBtn.Enabled = True
        'UpdateBtn.Enabled = True


        'itemedit_Panel.Enabled = True
        itemEntry_Panel.Enabled = True
        itemEntry2_Panel.Enabled = True
        item_TabControl.Enabled = True
        CompGrid1.Enabled = True


    End Sub

    Private Sub RefreshNavBtn()
        Dim oRow As DataRow
        Dim i As Integer = 0
        LineNo = 0
        InitItemGrid()

        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Quotation_ID

            If .GetQuotationLine(NavdsBox) Then
                If Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    DisableNavBtn()
                    ItemNo = ""
                Else
                    EnableNavBtn()
                    If CurrentRow = 0 Then
                        Me.lblNavLocation.Text = ("1 of " _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    Else
                        Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of ") _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    End If
                End If

                GrandTotal = 0

                For Each oRow In NavdsBox.Tables(0).Rows
                    i = i + 1
                    LineNo = LineNo + 1
                    'For i As Integer = 0 To NavdsBox.Tables(0).Rows.Count - 1
                    If Not IsDBNull(oRow("Total_Amount")) Then 'If Not IsDBNull(NavdsBox.Tables(0).Rows(i)("Total_Amount")) Then
                        'GrandTotal = GrandTotal + NavdsBox.Tables(0).Rows(i)("Total_Amount")
                        GrandTotal = GrandTotal + oRow("Total_Amount")
                    End If

                    itemdata.Rows.Add(New Object() {oRow("ItemNo"), oRow("Quotation_Line_ID"), oRow("Quotation_ID"), oRow("Box"), oRow("Qty"), oRow("UnitPrice"), oRow("Total_Amount")})

                Next

                PanelCostTxt.Text = Decimal.Round((Cost), 2)
                GrandTotalTxt.Text = Decimal.Round((GrandTotal), 2)
                Me.Total_Cost_Numeric = (GrandTotalTxt.Text)
                Total_Cost_Text = DollarToString(Total_Cost_Numeric)


                'For Each oRow In ds.Tables(0).Rows
                'data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand_Name"), oRow("Description"), oRow("Lead_Time"), oRow("Qty"), oRow("UnitPrice"), TotalCost})
                'Next


                Item_GridControl.DataSource = itemdata
                Item_GridControl.DefaultView.PopulateColumns()

                GridView2.BestFitColumns()
                GridView2.Columns.Item(1).VisibleIndex = -1
                GridView2.Columns.Item(2).VisibleIndex = -1
                
                GridView2.Columns.Item(0).Width = 26

                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                'Me.TotalAmtTxt.Text = Total_Cost_Text
            End If
        End With
    End Sub


    Private Sub InitItemGrid()

        If InititemGrid_flag = True Then
            'Exit Sub
        End If

        itemdata = New DataTable("ColumnsTable")
        itemdata.BeginInit()
        AddColumn(itemdata, "No", System.Type.GetType("System.String"), True)
        'AddColumn(itemdata, "No", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "Quotation_Line_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "Quotation_ID", System.Type.GetType("System.Int16"), True)

        AddColumn(itemdata, "Description", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Brand/Model", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        ' AddColumn(data, "Lead Time", System.Type.GetType("System.String"), True)
        AddColumn(itemdata, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "Unit Price", System.Type.GetType("System.Double"), True)
        AddColumn(itemdata, "Total", System.Type.GetType("System.Double"), True)
        itemdata.EndInit()

        InititemGrid_flag = True
    End Sub

    Private Sub RefreshNavBtn_BQ()
        Dim oRow As DataRow
        Dim i As Integer = 0
        LineNo = 0
        InitItemGrid_BQ()

        With New BusinessRules.BQBusRules.BQBusLogic
            .BQ_ID = Quotation_ID

            If .GetBQLine(NavdsBox) Then
                If Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    DisableNavBtn()
                    ItemNo = ""
                Else
                    EnableNavBtn()
                    If CurrentRow = 0 Then
                        Me.lblNavLocation.Text = ("1 of " _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    Else
                        Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of ") _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    End If
                End If

                GrandTotal = 0

                For Each oRow In NavdsBox.Tables(0).Rows
                    i = i + 1
                    'For i As Integer = 0 To NavdsBox.Tables(0).Rows.Count - 1
                    If Not IsDBNull(oRow("Total_Amount")) Then 'If Not IsDBNull(NavdsBox.Tables(0).Rows(i)("Total_Amount")) Then
                        'GrandTotal = GrandTotal + NavdsBox.Tables(0).Rows(i)("Total_Amount")
                        GrandTotal = GrandTotal + oRow("Total_Amount")
                    End If

                    itemdata.Rows.Add(New Object() {oRow("ItemNo"), oRow("BQ_Line_ID"), oRow("BQ_ID"), oRow("Box"), oRow("Qty"), oRow("UnitPrice"), oRow("Total_Amount")})

                Next

                PanelCostTxt.Text = Decimal.Round((Cost), 2)
                GrandTotalTxt.Text = Decimal.Round((GrandTotal), 2)
                Me.Total_Cost_Numeric = (GrandTotalTxt.Text)
                Total_Cost_Text = DollarToString(Total_Cost_Numeric)

                'For Each oRow In ds.Tables(0).Rows
                'data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand_Name"), oRow("Description"), oRow("Lead_Time"), oRow("Qty"), oRow("UnitPrice"), TotalCost})
                'Next


                Item_GridControl.DataSource = itemdata
                Item_GridControl.DefaultView.PopulateColumns()

                GridView2.BestFitColumns()
                GridView2.Columns.Item(1).VisibleIndex = -1
                GridView2.Columns.Item(2).VisibleIndex = -1
                'GridView2.Columns.Item(3).VisibleIndex = -1

                GridView2.Columns.Item(0).Width = 26

                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                'Me.TotalAmtTxt.Text = Total_Cost_Text
            End If
        End With
    End Sub



    Private Sub RefreshNavBtn_Enquiry()
        Dim oRow As DataRow
        Dim i As Integer = 0
        LineNo = 0
        InitItemGrid_Enquiry()

        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
            .Enquiry_ID = Quotation_ID

            If .GetEnquiryLine(NavdsBox) Then
                If Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    DisableNavBtn()
                    ItemNo = ""
                Else
                    EnableNavBtn()
                    If CurrentRow = 0 Then
                        Me.lblNavLocation.Text = ("1 of " _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    Else
                        Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of ") _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    End If
                End If

                GrandTotal = 0

                For Each oRow In NavdsBox.Tables(0).Rows
                    i = i + 1
                    LineNo = LineNo + 1
                    'For i As Integer = 0 To NavdsBox.Tables(0).Rows.Count - 1
                    If Not IsDBNull(oRow("Total_Amount")) Then 'If Not IsDBNull(NavdsBox.Tables(0).Rows(i)("Total_Amount")) Then
                        'GrandTotal = GrandTotal + NavdsBox.Tables(0).Rows(i)("Total_Amount")
                        GrandTotal = GrandTotal + oRow("Total_Amount")
                    End If

                    itemdata.Rows.Add(New Object() {oRow("ItemNo"), oRow("Enquiry_Line_ID"), oRow("Enquiry_ID"), oRow("Box"), oRow("Qty"), oRow("UnitPrice"), oRow("Total_Amount")})

                Next

                PanelCostTxt.Text = Decimal.Round((Cost), 2)
                GrandTotalTxt.Text = Decimal.Round((GrandTotal), 2)
                Me.Total_Cost_Numeric = (GrandTotalTxt.Text)
                Total_Cost_Text = DollarToString(Total_Cost_Numeric)

                'For Each oRow In ds.Tables(0).Rows
                'data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand_Name"), oRow("Description"), oRow("Lead_Time"), oRow("Qty"), oRow("UnitPrice"), TotalCost})
                'Next


                Item_GridControl.DataSource = itemdata
                Item_GridControl.DefaultView.PopulateColumns()

                GridView2.BestFitColumns()
                GridView2.Columns.Item(1).VisibleIndex = -1
                GridView2.Columns.Item(2).VisibleIndex = -1

                GridView2.Columns.Item(0).Width = 26

                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                'Me.TotalAmtTxt.Text = Total_Cost_Text
            End If
        End With
    End Sub

    Private Sub InitItemGrid_Enquiry()

        If InititemGrid_flag = True Then
            'Exit Sub
        End If

        itemdata = New DataTable("ColumnsTable")
        itemdata.BeginInit()
        AddColumn(itemdata, "No", System.Type.GetType("System.String"), True)
        'AddColumn(itemdata, "No", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "Enquiry_Line_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "Enquiry_ID", System.Type.GetType("System.Int16"), True)

        AddColumn(itemdata, "Description", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Brand/Model", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        ' AddColumn(data, "Lead Time", System.Type.GetType("System.String"), True)
        AddColumn(itemdata, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "Unit Price", System.Type.GetType("System.Double"), True)
        AddColumn(itemdata, "Total", System.Type.GetType("System.Double"), True)
        itemdata.EndInit()

        InititemGrid_flag = True
    End Sub

    Private Sub InitItemGrid_BQ()

        If InititemGrid_flag = True Then
            'Exit Sub
        End If

        itemdata = New DataTable("ColumnsTable")
        itemdata.BeginInit()
        AddColumn(itemdata, "No", System.Type.GetType("System.String"), True)
        'AddColumn(itemdata, "No", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "BQ_Line_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "BQ_ID", System.Type.GetType("System.Int16"), True)

        AddColumn(itemdata, "Description", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Brand/Model", System.Type.GetType("System.String"), True)
        'AddColumn(data, "Description", System.Type.GetType("System.String"), True)
        ' AddColumn(data, "Lead Time", System.Type.GetType("System.String"), True)
        AddColumn(itemdata, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(itemdata, "Unit Price", System.Type.GetType("System.Double"), True)
        AddColumn(itemdata, "Total", System.Type.GetType("System.Double"), True)
        itemdata.EndInit()

        InititemGrid_flag = True
    End Sub

    Private Sub NavdsBox_Init()
        Me.Product_cmb.Properties.LookUpData.KeyValue = Nothing
        Me.BoxCategoryCmb.Properties.LookUpData.KeyValue = Nothing
        Me.BoxCategoryCmb.Properties.LookUpData.KeyValue = Nothing
        Me.BoxDescTxt.Text = ""
        Me.ItemNoTxt.Text = ""
        Me.PanelCostTxt.Text = ""
        Me.OverallMarkTxt.Text = ""
        Me.QtyTxt.Text = ""
        'Me.TotalAmtTxt.Text = ""
        Me.CompMarkTxt.Text = ""
        Me.HeightTxt.Text = ""
        Me.WidthTxt.Text = ""
        Me.DepthTxt.Text = ""
        Me.MaterialCmb.Properties.LookUpData.KeyValue = Nothing
        Me.MatCostTxt.Text = ""
        Me.Typetxt.Text = ""
        Me.ThicknessTxt.Text = ""
        Me.PowerCoatTxt.Text = ""
        Me.WiringTxt.Text = ""
        Me.AccessoryTxt.Text = ""
        Me.CopperTxt.Text = ""
        Me.ConcreteBaseTxt.Text = ""
        Me.TransportTxt.Text = ""
        Me.EnclosureTxt.Text = ""
        Me.OCEFTxt.Text = ""
        Me.IncomingTxt.Text = ""
        Me.PanelTransportTxt.Text = ""
        Me.InstallTxt.Text = ""
        Me.TypeEnclosureCmb.Properties.LookUpData.KeyValue = Nothing
        Me.UnitPrice_Txt.Text = ""
        Me.Remarks_MemoEdit.Text = ""

        OthersTxt.Text = ""


    End Sub

    Private Sub NavdsBox_PositionChanged()

        OnLineLoading = True

        Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of ") _
                    + Me.NavdsBox.Tables(0).Rows.Count.ToString)

        If FormType = "ENQUIRY" Then
            Me.Quotation_Line_ID = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Enquiry_Line_ID")
            If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Product_ID")) Then
                Me.Product_cmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Product_ID")
            Else
                Me.Product_cmb.Properties.LookUpData.KeyValue = CType(0, Decimal)
            End If
        ElseIf FormType = "BQ" Then
            Me.Quotation_Line_ID = Me.NavdsBox.Tables(0).Rows(CurrentRow)("BQ_Line_ID")
            If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")) Then
                Me.BoxCategoryCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")
            End If
        Else
            Me.Quotation_Line_ID = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Quotation_Line_ID")
            If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")) Then
                Me.BoxCategoryCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("BoxCategory_ID")
            Else
                Me.BoxCategoryCmb.Properties.LookUpData.KeyValue = Nothing

            End If
        End If

        Me.BoxDescTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Box").ToString


        Me.ItemNoTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("ItemNo")
        Me.PanelCostTxt.Text = Decimal.Round(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Cost"), 2)
        Me.OverallMarkTxt.Text = (Me.NavdsBox.Tables(0).Rows(CurrentRow)("Overall_Markup"))
        Me.QtyTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty").ToString
        'Me.TotalAmtTxt.Text = Decimal.Round(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Total_Amount"), 2)
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
        Me.UnitPrice_Txt.Text = Double.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("UnitPrice"))

        Me.Remarks_MemoEdit.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Remarks").ToString

        Dim TotalOthers As Double = CalculateOthers()
        OthersTxt.Text = TotalOthers

        BoxCategoryChanged()
        RefreshComponentGrid()

        'GridView2.FocusedRowHandle = CurrentRow

        OnLineLoading = False

    End Sub

    Private Sub NavFirstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavFirstBtn.Click

        If LineEdited = True Then
            If LineNotUpdate() = True Then 'cancel change item
                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                Exit Sub
            End If
        End If

        UpdateBtn.Enabled = False
        LineEdited = False

        If NavdsBox.Tables(0).Rows.Count > 0 Then
            CurrentRow = 0
            Me.BindingContext(NavdsBox).Position = 0
            Me.BindingContext(itemdata).Position = 0
            Me.NavdsBox_PositionChanged()
        End If

        GridView2.ClearSelection()
        GridView2.SelectRow(CurrentRow)

    End Sub

    Private Sub NavPrevBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavPrevBtn.Click

        If LineEdited = True Then
            If LineNotUpdate() = True Then 'cancel change item
                GridView2.FocusedRowHandle = CurrentRow

                Exit Sub
            End If
        End If

        UpdateBtn.Enabled = False
        LineEdited = False

        If NavdsBox.Tables(0).Rows.Count > 0 Then
            If CurrentRow > 0 Then CurrentRow = CurrentRow - 1
            Me.BindingContext(NavdsBox).Position = (Me.BindingContext(NavdsBox).Position - 1)
            Me.BindingContext(itemdata).Position = Me.BindingContext(itemdata).Position - 1
            Me.NavdsBox_PositionChanged()
        End If

        GridView2.ClearSelection()
        GridView2.SelectRow(CurrentRow)

    End Sub

    Private Sub NavNextBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavNextBtn.Click

        If LineEdited = True Then
            If LineNotUpdate() = True Then 'cancel change item
                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                Exit Sub
            End If
        End If

        UpdateBtn.Enabled = False
        LineEdited = False

        If NavdsBox.Tables(0).Rows.Count > 0 Then
            If CurrentRow < Me.NavdsBox.Tables(0).Rows.Count - 1 Then
                CurrentRow = CurrentRow + 1
            End If
            Me.BindingContext(NavdsBox).Position = (Me.BindingContext(NavdsBox).Position + 1)
            Me.BindingContext(itemdata).Position = Me.BindingContext(itemdata).Position + 1
            Me.NavdsBox_PositionChanged()
        End If

        GridView2.ClearSelection()
        GridView2.SelectRow(CurrentRow)


    End Sub

    Private Sub NavLastBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavLastBtn.Click

        If LineEdited = True Then
            If LineNotUpdate() = True Then 'cancel change item
                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                Exit Sub
            End If
        End If

        UpdateBtn.Enabled = False
        LineEdited = False


        If NavdsBox.Tables(0).Rows.Count > 0 Then
            CurrentRow = (Me.NavdsBox.Tables(0).Rows.Count - 1)
            Me.BindingContext(NavdsBox).Position = CurrentRow
            Me.BindingContext(itemdata).Position = CurrentRow

            Me.NavdsBox_PositionChanged()
        End If

        GridView2.ClearSelection()
        GridView2.SelectRow(CurrentRow)

    End Sub


#End Region

#Region " Key Up Event "
    Private Sub BoxDescTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub QtyTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub OverallMarkTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub CompMarkTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub HeightTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub WidthTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub DepthTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub MaterialCmb_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub PowerCoatTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub MatCostTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub Typetxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub ThicknessTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub TypeEnclosureCmb_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub WiringTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub AccessoryTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub CopperTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub ConcreteBaseTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub TransportTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub OCEFTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub IncomingTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub PanelTransportTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EditFlag = True
    End Sub

    Private Sub InstallTxt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    End Sub

    Private Sub BoxCategoryCmb_CloseUp(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
        EditFlag = True
    End Sub
#End Region



    Private Sub CompCostTxt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompCostTxt.DoubleClick

    End Sub

    Private Sub QuotationForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing


    End Sub

    Private Sub QuotationForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveQuoBtn.Click


        RetrieveFromMainForm()
        If FormType = "ENQUIRY" Then
            SaveMainFormProcess_Enquiry()

        ElseIf FormType = "BQ" Then
            SaveMainFormProcess_BQ()

        Else
            SaveMainFormProcess()

            If FormStatus = "EDIT" Then
                LoadQuoNoCmb() 'load new Quotation into combo and select it
                QuoNoTxt.Visible = False
                QuoNo_LookUpEdit.Visible = True
            End If

        End If

        New_Button.Enabled = True
        Edited = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchBtn.Click
        RetrieveFromMainForm()

        If ValidDataHeader() Then
            With New BusinessRules.SaleBusRules.SaleBusLogic
                'insert by alan 21 sep to prevent empty quotation flow to approval
                Dim tmpds As DataSet
                'Added by YG to prevent empty quotation flow to approval
                .Quotation_ID = Quotation_ID
                If Status <> "20" Then
                    If .GetQuotationLine(tmpds) Then
                        If tmpds.Tables(0).Rows.Count > 0 Then
                            'end 21 sep
                            .Quotation_ID = Quotation_ID
                            .Status = "20"      'Pending status
                            If .UpdateQuotationHeaderStatus() Then
                                MessageBox.Show("Status updated.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                StatusCmb.Properties.LookUpData.KeyValue = "20"
                                DispatchBtn.Text = "Prepare"
                            End If
                            Dim b As MainForm = Me.ParentForm ' page.Control.Name()
                            For i As Integer = 0 To b.MainTabControl.TabPages.Count - 1
                                If b.MainTabControl.TabPages.Item(i).Control.Name() = "QuotationListForm" Then
                                    Dim c As QuotationListForm = b.MainTabControl.TabPages.Item(i).Control
                                    c.LoadQuotationList()
                                    Exit For
                                End If
                            Next
                        Else
                            MessageBox.Show("There is no component selected for this quotation.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                ElseIf Status = "20" Then
                    .Status = "10" 'Preparing
                    If .UpdateQuotationHeaderStatus() Then
                        MessageBox.Show("Status updated.", "Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        StatusCmb.Properties.LookUpData.KeyValue = "20"
                        DispatchBtn.Text = "Dispatch"
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialBtn.Click
        Dim NewForm As New SelectSpecialForm("QUO")
        NewForm.Quotation_ID = Quotation_ID
        NewForm.ShowDialog()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub TypeEnclosureCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles TypeEnclosureCmb.ButtonClick
        TypeEnclosureCmb.Properties.LookUpData.ListFields.Clear()
        LoadEnclosureType()
    End Sub

    Private Sub BoxCategoryCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles BoxCategoryCmb.ButtonClick
        BoxCategoryCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadBoxCategory()
    End Sub

    Private Sub ConsultantCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles ConsultantCmb.ButtonClick
        ConsultantCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadConsultant()
    End Sub

    Private Sub CopyFmBxCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles CopyFmBxCmb.ButtonClick
        CopyFmBxCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadCopyFromBox()
    End Sub

    Private Sub MaterialCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles MaterialCmb.ButtonClick
        MaterialCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadMaterial()
    End Sub

    Private Sub PayDetailsCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles PayDetailsCmb.ButtonClick
        PayDetailsCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadPaymentDetails()
    End Sub

    Private Sub PriceTillCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles PriceTillCmb.ButtonClick
        PriceTillCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadPriceIncludeTill()
    End Sub

    Private Sub ProjectTitleCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles ProjectTitleCmb.ButtonClick
        ProjectTitleCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadProjectTitle()
    End Sub

    Private Sub DelTermsCmb_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles DelTermsCmb.ButtonClick
        DelTermsCmb.Properties.LookUpData.ListFields.Clear()
        Me.LoadDeliveryTerms()
    End Sub

    Private Sub CustLookup_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles CustLookup.ButtonClick
        CustLookup.Properties.LookUpData.ListFields.Clear()
        Me.LoadCustomerDetails()
    End Sub

    Private Sub ContLookup_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonClickEventArgs) Handles ContLookup.ButtonClick
        ContLookup.Properties.LookUpData.ListFields.Clear()
        Customer_ID = CustLookup.Properties.LookUpData.KeyValue
        Me.LoadContactPerson(Customer_ID)
    End Sub

    Private Sub TabControl1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item_TabControl.SelectionChanged

    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click

        Dim tmpOld_Quotation_ID As Integer
        Dim tmpSelect As Integer

        Dim form As New SelectQuotationCopyForm
        form.ShowDialog(Me)
        tmpOld_Quotation_ID = form.Quotation_ID
        tmpSelect = form.SelectFlag
        CopyQuotation(tmpOld_Quotation_ID, tmpSelect)

    End Sub

    Sub CopyQuotation(ByVal pQuotationID As Integer, ByVal pSelectflag As Integer)
        Dim dsSubQuo As DataSet
        Dim dsHeader As DataSet
        Dim SubQuotation_Line_ID As Integer
        Dim c As DataRowView
        'Dim li As ListItem
        Me.Cursor = Cursors.WaitCursor
        With New BusinessRules.SaleBusRules.SaleBusLogic
            '''''If SubQuoList.SelectedItems.Count > 0 Then
            ''''''For Each c In SubQuoList.SelectedItems
            'Quotation_ID = SubQuoList.SelectedItems.Item(c)

            'Quotation_ID = pQuotationID ' SubQuoList.SelectedItems.Item(c).Value
            'Quotation_ID = dr("Quotation_ID")

            .Quotation_ID = Quotation_ID
            If .GetNextItemNo() Then
                ItemNo = .ItemNo

                'Get the sub quotation line item
                .Quotation_ID = pQuotationID
                If pSelectflag = 3 Or pSelectflag = 2 Then
                    If .GetQuotationHeader(dsHeader, pQuotationID) Then
                        SetWindowValue2(dsHeader)
                        RetrieveFromMainForm()
                        .Quotation_ID = Quotation_ID
                        .Quotation_No = QuotationNo
                        .QuotationDate = Microsoft.VisualBasic.DateAndTime.Day(QuotationDate) & "/" & Month(QuotationDate) & "/" & Year(QuotationDate)
                        .Status = Status
                        .ProjectSub = ProjectSub
                        .Project = Project
                        .Customer_ID = Customer_ID
                        .Contact_ID = Contact_ID
                        .Payment_Term = Payment_Term
                        .Validity = Validity
                        .Delivery_Term = Delivery_Term
                        .Order_Type = OrderType
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
                        If UCase(FormStatus) = "REVISED" Then
                            .RevRefQuotationID = RevRefQuotationID
                        End If
                        If .UpdateQuotationHeader() Then
                        End If
                    End If
                End If

                If pSelectflag = 3 Or pSelectflag = 1 Then
                    .Quotation_ID = pQuotationID
                    If .GetQuotationLine(dsSubQuo) Then
                        Dim x As Integer
                        For x = 0 To dsSubQuo.Tables(0).Rows.Count - 1
                            'Save the itemno first
                            ItemNo = x + 1
                            .ItemNo = ItemNo
                            .Quotation_ID = Quotation_ID
                            .UserID = UserID
                            If .SaveQuotationLineFirstTime() Then
                                Quotation_Line_ID = .Quotation_Line_ID
                            End If
                            '***
                            SubQuotation_Line_ID = dsSubQuo.Tables(0).Rows(x)("Quotation_Line_ID")
                            If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Box")) Then
                                .Box = dsSubQuo.Tables(0).Rows(x)("Box")
                            End If
                            .BoxCategory_ID = dsSubQuo.Tables(0).Rows(x)("BoxCategory_Id")
                            .varHeight = dsSubQuo.Tables(0).Rows(x)("Height")
                            .varWidth = dsSubQuo.Tables(0).Rows(x)("Width")
                            .Depth = dsSubQuo.Tables(0).Rows(x)("Depth")
                            If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Raw_Material")) Then
                                .Raw_Material = dsSubQuo.Tables(0).Rows(x)("Raw_Material")
                            End If

                            .Material_Cost = dsSubQuo.Tables(0).Rows(x)("Material_Cost")
                            If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Type")) Then
                                .Type = dsSubQuo.Tables(0).Rows(x)("Type")
                            End If

                            If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Thickness")) Then
                                .Thickness = dsSubQuo.Tables(0).Rows(x)("Thickness")
                            End If
                            .Power_Coat = dsSubQuo.Tables(0).Rows(x)("Power_Coat")
                            .Wiring = dsSubQuo.Tables(0).Rows(x)("Wiring")
                            .Accessory = dsSubQuo.Tables(0).Rows(x)("Accessory")
                            .Copper = dsSubQuo.Tables(0).Rows(x)("Copper")
                            .Comp_Markup = dsSubQuo.Tables(0).Rows(x)("Comp_Markup")
                            .Concrete_Base = dsSubQuo.Tables(0).Rows(x)("Concrete_Base")
                            .Transport = dsSubQuo.Tables(0).Rows(x)("Transport")
                            .Enclosure = dsSubQuo.Tables(0).Rows(x)("Enclosure")
                            .Qty = dsSubQuo.Tables(0).Rows(x)("Qty")
                            .UnitPrice = dsSubQuo.Tables(0).Rows(x)("UnitPrice")
                            .Cost = dsSubQuo.Tables(0).Rows(x)("Cost")
                            .Overall_Markup = dsSubQuo.Tables(0).Rows(x)("Overall_Markup")
                            .Total_Amount = dsSubQuo.Tables(0).Rows(x)("Total_Amount")
                            .OC_EF = dsSubQuo.Tables(0).Rows(x)("OC_EF")
                            .Incoming = dsSubQuo.Tables(0).Rows(x)("Incoming")
                            .Panel_Transport = dsSubQuo.Tables(0).Rows(x)("Panel_Transport")
                            .Installation = dsSubQuo.Tables(0).Rows(x)("Installation")
                            .Type_Of_Enclosure = dsSubQuo.Tables(0).Rows(x)("Type_Of_Enclosure")
                            .Quotation_Line_ID = Quotation_Line_ID
                            .UserID = UserID

                            If .UpdateQuotationLine() Then
                                Dim dsComp As DataSet
                                .Quotation_Line_ID = SubQuotation_Line_ID
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
                    End If 'GET QUOTATION LINE
                End If
            End If
            '.Quotation_ID = Quotation_ID
            '.UserID = UserID
            '.Status = 70 'Merged
            'If .UpdateQuotationHeaderStatus Then
            'End If
            ''''''''''''''''''''Next
            '''''''''''''''End If
            If Not dsSubQuo Is Nothing Then
                dsSubQuo.Dispose()

                Me.Text = "Edit Quotation"
                With New BusinessRules.SaleBusRules.SaleBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetQuotationHeader(dsHeaderLoad, Quotation_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                CompGrid1.Enabled = True
                'SaveQuoBtn.Enabled = True
                RefreshNavBtn()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    EnableButtons()
                    Me.NavdsBox_PositionChanged()
                Else
                    CompGrid1.Enabled = False
                    DelProdBtn.Enabled = False
                    UpdateBtn.Enabled = False
                    item_TabControl.Enabled = False
                End If

                'MessageBox.Show("Copy completed.")

            ElseIf dsHeader Is Nothing Then
                'MessageBox.Show("Nothing to copy.")
            End If
            'CloseBtn_Click(sender, e)
        End With

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DetailsTab_PropertyChanged(ByVal page As Crownwood.Magic.Controls.TabPage, ByVal prop As Crownwood.Magic.Controls.TabPage.Property, ByVal oldValue As System.Object)

    End Sub

    Private Sub TabControl3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BoxGroup_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxGroup.Enter

    End Sub

    Public Function DollarToString(ByVal nAmount As Decimal) As _
    String

        Dim nDollar As Decimal
        Dim nCent As Decimal

        nDollar = Int(nAmount)
        nCent = (Abs(nAmount) * 100) Mod 100

        If nDollar <> 0 Then
            DollarToString = NumToString(nDollar) & " Dollar"
        End If

        If Abs(nDollar) <> 1 And nDollar <> 0 Then
            DollarToString = DollarToString & "s"
        End If

        If nCent > 0 Then
            If nDollar > 0 Then
                DollarToString = DollarToString & " and"
            End If
            DollarToString = DollarToString & NumToString(nCent) & " Cent"
        End If

        If Abs(nCent) <> 1 And nCent <> 0 Then
            DollarToString = DollarToString & "s"
        End If

        DollarToString = DollarToString & " Only"
        'DollarToString = UCase(DollarToString)

    End Function

    Public Function NumToString(ByVal nNumber As Double) As String

        Dim bNegative As Boolean
        Dim bHundred As Boolean

        If nNumber < 0 Then
            bNegative = True
        End If

        nNumber = Abs(Int(nNumber))

        If nNumber < 1000 Then
            If nNumber \ 100 > 0 Then
                NumToString = NumToString & _
                     NumToString(nNumber \ 100) & " hundred"
                bHundred = True
            End If
            nNumber = nNumber - ((nNumber \ 100) * 100)
            Dim bNoFirstDigit As Boolean
            bNoFirstDigit = False
            Select Case nNumber \ 10
                Case 0
                    Select Case nNumber Mod 10
                        Case 0
                            If Not bHundred Then
                                NumToString = NumToString & " Zero"
                            End If
                        Case 1 : NumToString = NumToString & " One"
                        Case 2 : NumToString = NumToString & " Two"
                        Case 3 : NumToString = NumToString & " Three"
                        Case 4 : NumToString = NumToString & " Four"
                        Case 5 : NumToString = NumToString & " Five"
                        Case 6 : NumToString = NumToString & " Six"
                        Case 7 : NumToString = NumToString & " Seven"
                        Case 8 : NumToString = NumToString & " Eight"
                        Case 9 : NumToString = NumToString & " Nine"
                    End Select
                    bNoFirstDigit = True
                Case 1
                    Select Case nNumber Mod 10
                        Case 0 : NumToString = NumToString & " Ten"
                        Case 1 : NumToString = NumToString & " Eleven"
                        Case 2 : NumToString = NumToString & " Twelve"
                        Case 3 : NumToString = NumToString & " Thirteen"
                        Case 4 : NumToString = NumToString & " Fourteen"
                        Case 5 : NumToString = NumToString & " Fifteen"
                        Case 6 : NumToString = NumToString & " Sixteen"
                        Case 7 : NumToString = NumToString & " Seventeen"
                        Case 8 : NumToString = NumToString & " Eighteen"
                        Case 9 : NumToString = NumToString & " Nineteen"
                    End Select
                    bNoFirstDigit = True
                Case 2 : NumToString = NumToString & " Twenty"
                Case 3 : NumToString = NumToString & " Thirty"
                Case 4 : NumToString = NumToString & " Forty"
                Case 5 : NumToString = NumToString & " Fifty"
                Case 6 : NumToString = NumToString & " Sixty"
                Case 7 : NumToString = NumToString & " Seventy"
                Case 8 : NumToString = NumToString & " Eighty"
                Case 9 : NumToString = NumToString & " Ninety"
            End Select
            If Not bNoFirstDigit Then
                If nNumber Mod 10 <> 0 Then
                    NumToString = NumToString & "-" & _
                                  Mid(NumToString(nNumber Mod 10), 2)
                End If
            End If
        Else
            Dim nTemp As Decimal
            nTemp = 10 ^ 12 'trillion
            Do While nTemp >= 1
                If nNumber >= nTemp Then
                    NumToString = NumToString & _
                                  NumToString(Int(nNumber / nTemp))
                    Select Case Int(Log(nTemp) / Log(10) + 0.5)
                        Case 12 : NumToString = NumToString & " Trillion"
                        Case 9 : NumToString = NumToString & " Billion"
                        Case 6 : NumToString = NumToString & " Million"
                        Case 3 : NumToString = NumToString & " Thousand"
                    End Select

                    nNumber = nNumber - (Int(nNumber / nTemp) * nTemp)
                End If
                nTemp = nTemp / 1000
            Loop
        End If

        If bNegative Then
            NumToString = " Negative" & NumToString
        End If

    End Function

    Public Function GetSmallestDollar(ByVal nNumber As Double) As Double

        nNumber = nNumber - ((nNumber \ 10) * 10)
        GetSmallestDollar = nNumber

    End Function

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BoxCategoryCmb_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BoxCategoryCmb.EditValueChanged
        BoxCategoryChanged()
    End Sub

    Private Sub BoxCategoryChanged()
        If BoxCategoryCmb.Text.ToUpper = "TRADING ITEM" Then
            UnitPrice_Txt.Properties.Enabled = True
            'UnitPrice_Txt.Text = 0
            Me.OverallMarkTxt.Properties.Enabled = False
            'Me.OverallMarkTxt.Text = 0
            Me.CompMarkTxt.Properties.Enabled = False
            'Me.CompMarkTxt.Text = 0
            EnclosureGroup.Enabled = False
            OthersGroup.Enabled = False
        Else
            'UnitPrice_Txt.Properties.Enabled = False
            'UnitPrice_Txt.Text = PanelCostTxt.Text
            Me.OverallMarkTxt.Properties.Enabled = True
            'Me.OverallMarkTxt.Text = 0
            Me.CompMarkTxt.Properties.Enabled = True
            'Me.CompMarkTxt.Text = 0
            'UnitPrice_Txt.Text = 0
            EnclosureGroup.Enabled = True
            OthersGroup.Enabled = True
        End If

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub


    Private Sub Details_Panel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Details_Panel.DoubleClick

    End Sub

    Private Sub ExpandablePanel1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Payment_ExpandablePanel.MouseDoubleClick

    End Sub

    Private Function CheckIncomplete() As Boolean

        With New BusinessRules.SaleBusRules.SaleBusLogic
            Dim dsHeaderLoad As DataSet
            If .GetQuotationHeader(dsHeaderLoad, Quotation_ID) Then
                If dsHeaderLoad.Tables(0).Rows(0)("Status") = "80" Then
                    CheckIncomplete = True
                End If
            End If
        End With
    End Function

    Structure PrintOptions
        Public HideTotal As Boolean
        Public PrintGST As Boolean
        Public CustomLabel As String
    End Structure


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PO As BusinessRules.SaleBusRules.SaleBusLogic.PrintOptions

        If Quotation_ID <> 0 Then

            'PrintQuotation(1)
            'Exit Sub

            If True Then 'CheckIncomplete() = False Then
                Dim PrintQuotationDlg As PrintQuotationDialog = New PrintQuotationDialog
                PrintQuotationDlg.ShowDialog()
                PO.HideTotal = PrintQuotationDlg.HideTotal
                PO.PrintGST = PrintQuotationDlg.PrintGST
                PO.CustomLabel = PrintQuotationDlg.CustomLabel

                If PrintQuotationDlg.PrintQuotationSelection <> 0 Then
                    'PrintQuotation(PrintQuotationDlg.PrintQuotationSelection)

                    PrintQuotation(1, PO)
                End If

            Else
                MessageBox.Show("Quotation is incomplete for printing.", "Incomplete quotation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub PrintQuotation(ByVal pPrinttype As Integer, ByVal pPrintOptions As BusinessRules.SaleBusRules.SaleBusLogic.PrintOptions)

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        If pPrinttype = 1 Then
            controlToAdd = New QuotationReportForm(Quotation_ID, pPrintOptions)
            page = New Crownwood.Magic.Controls.TabPage("Print Quotation", controlToAdd, ImageList1, 0)
        ElseIf pPrinttype = 2 Then
            controlToAdd = New QuotationReportBriefForm(Quotation_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Quotation", controlToAdd, ImageList1, 0)
        ElseIf pPrinttype = 3 Then
            controlToAdd = New QuotationComponentDetailsReport(Quotation_ID)
            page = New Crownwood.Magic.Controls.TabPage("Print Quotation Component Details", controlToAdd, ImageList1, 0)
        Else
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        CompGrid1_DoubleClick(Nothing, Nothing)
    End Sub

    Private Sub Items_Panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Items_Panel.Click

    End Sub

    Private Sub Items_Panel_MarkupLinkClick(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.MarkupLinkClickEventArgs) Handles Items_Panel.MarkupLinkClick

    End Sub


    Private Sub Details_Panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Details_Panel.Click

    End Sub

    Private Sub Details_Panel_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Details_Panel.MouseDoubleClick

    End Sub

    Private Sub Items_Panel_ExpandedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles Items_Panel.ExpandedChanged

        Items_PanelChanging = False

    End Sub

    Private Sub Payment_ExpandablePanel_ExpandedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles Payment_ExpandablePanel.ExpandedChanged

        Payment_ExpandablePanelChanging = False

    End Sub

    Private Sub Details_Panel_ExpandedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles Details_Panel.ExpandedChanged

        Details_PanelChanging = False

    End Sub

    Private Sub Details_Panel_ExpandedChanging(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles Details_Panel.ExpandedChanging

        If ExpandablePanel_Changing = True Or Details_PanelChanging = True Then
            Exit Sub
        End If

        'If Details_Panel.Expanded = False Then

        'Items_PanelChanging = True
        'Items_Panel.Expanded = False

        'End If

    End Sub

    Private Sub Items_Panel_ExpandedChanging(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles Items_Panel.ExpandedChanging

        If ExpandablePanel_Changing = True Or Me.Items_PanelChanging = True Then
            Exit Sub
        End If

        If Items_Panel.Expanded = False Then

            Details_PanelChanging = True
            Details_Panel.Expanded = False

            Payment_ExpandablePanelChanging = True
            Payment_ExpandablePanel.Expanded = False
        Else

            Details_PanelChanging = True
            Details_Panel.Expanded = True

            Payment_ExpandablePanelChanging = True
            Payment_ExpandablePanel.Expanded = False

        End If

    End Sub


    Private Sub Payment_ExpandablePanel_ExpandedChanging(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles Payment_ExpandablePanel.ExpandedChanging

        If ExpandablePanel_Changing = True Or Payment_ExpandablePanelChanging = True Then
            Exit Sub
        End If

        'If Payment_ExpandablePanel.Expanded = False Then

        'Items_PanelChanging = True
        'Items_Panel.Expanded = False

        'End If
    End Sub


    Private Sub SpinEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersTxt.Click

    End Sub

    Private Function CalculateOthers() As Double
        '** Others Tab **
        Dim OthersTotal As Double = 0
        Dim TotalOthers As Double = 0

        If WiringTxt.Text <> Nothing Then
            Wiring = WiringTxt.Text
        End If
        OthersTotal = OthersTotal + Wiring

        If AccessoryTxt.Text <> Nothing Then
            Accessory = AccessoryTxt.Text
        End If
        OthersTotal = OthersTotal + Accessory

        If CopperTxt.Text <> Nothing Then
            Copper = CopperTxt.Text
        End If
        OthersTotal = OthersTotal + Copper

        If ConcreteBaseTxt.Text <> Nothing Then
            Concrete_Base = ConcreteBaseTxt.Text
        End If
        OthersTotal = OthersTotal + Concrete_Base

        If TransportTxt.Text <> Nothing Then
            Transport = TransportTxt.Text
        End If
        OthersTotal = OthersTotal + Transport

        If OCEFTxt.Text <> Nothing Then
            OC_EF = OCEFTxt.Text
        End If
        OthersTotal = OthersTotal + OC_EF

        If IncomingTxt.Text <> Nothing Then
            Incoming = IncomingTxt.Text
        End If
        OthersTotal = OthersTotal + Incoming

        If PanelTransportTxt.Text <> Nothing Then
            Panel_Transport = PanelTransportTxt.Text
        End If
        OthersTotal = OthersTotal + Panel_Transport

        If InstallTxt.Text <> Nothing Then
            Installation = InstallTxt.Text
        End If
        OthersTotal = OthersTotal + Installation
        '***

        TotalOthers = OthersTotal
        Return TotalOthers
        ' ***
    End Function

    Private Sub DisableAllPanels()
        Me.Details_Panel.Enabled = False
        Me.Items_Panel.Enabled = False
        Me.Payment_ExpandablePanel.Enabled = False
        Me.Button_Panel.Enabled = False

        Revise_Button.Enabled = False
        QuotationCopy_ToolStripMenuItem.Enabled = False
        QuotationDelete_ToolStripMenuItem.Enabled = False

    End Sub

    Private Sub EnableAllPanels()
        Me.Details_Panel.Enabled = True
        Me.Items_Panel.Enabled = True
        Me.Payment_ExpandablePanel.Enabled = True
        Me.Button_Panel.Enabled = True

        Revise_Button.Enabled = True
        QuotationCopy_ToolStripMenuItem.Enabled = True
        QuotationDelete_ToolStripMenuItem.Enabled = True

    End Sub

    Private Sub LoadQuoNoCmb()
        Dim ds As DataSet
        QuoNo_LookUpEdit.Properties.LookUpData.ListFields.Clear()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeader(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(Me.QuoNo_LookUpEdit, "Quotation_NO", 400, 0, "c")
                    QuoNo_LookUpEdit.Properties.LookUpData.KeyField = "Quotation_ID"
                    QuoNo_LookUpEdit.Properties.LookUpData.DisplayField = "Quotation_NO"
                    QuoNo_LookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    QuoNo_LookUpEdit.EditValue = "0"
                    'QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Quotation_ID, 0, 0, 0})
                End If
            End If
        End With

        If Quotation_ID <> 0 Then
            QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Quotation_ID, 0, 0, 0})
        End If

    End Sub

    Private Sub LoadEnNoCmb()
        Dim ds As DataSet
        QuoNo_LookUpEdit.Properties.LookUpData.ListFields.Clear()
        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
            If .GetEnquiryHeader(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(Me.QuoNo_LookUpEdit, "Enquiry_NO", 400, 0, "c")
                    QuoNo_LookUpEdit.Properties.LookUpData.KeyField = "Enquiry_ID"
                    QuoNo_LookUpEdit.Properties.LookUpData.DisplayField = "Enquiry_NO"
                    QuoNo_LookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    QuoNo_LookUpEdit.EditValue = "0"
                    'QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Quotation_ID, 0, 0, 0})
                End If
            End If
        End With
    End Sub

    Private Sub LoadBQNoCmb()
        Dim ds As DataSet
        QuoNo_LookUpEdit.Properties.LookUpData.ListFields.Clear()
        With New BusinessRules.BQBusRules.BQBusLogic
            If .GetBQHeader(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(Me.QuoNo_LookUpEdit, "BQ_NO", 400, 0, "c")
                    QuoNo_LookUpEdit.Properties.LookUpData.KeyField = "BQ_ID"
                    QuoNo_LookUpEdit.Properties.LookUpData.DisplayField = "BQ_NO"
                    QuoNo_LookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    QuoNo_LookUpEdit.EditValue = "0"
                    'QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Quotation_ID, 0, 0, 0})
                End If
            End If
        End With
    End Sub

    Private Sub Payment_ExpandablePanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub QuoNo_LookUpEdit_CloseUp(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles QuoNo_LookUpEdit.CloseUp

        Dim Result As DialogResult
        Dim WarningMsg As String

        WarningMsg = "You have made changes or have edited data without saving, Are you sure you load another "

        If FormType = "ENQUIRY" Then
            WarningMsg = WarningMsg & "Enquiry"
        ElseIf FormType = "BQ" Then
            WarningMsg = WarningMsg & "BQ"
        Else
            WarningMsg = WarningMsg & "Quotation"
        End If

        WarningMsg = WarningMsg & "?"

        If Edited = True Then

            Result = MessageBox.Show(WarningMsg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Quotation_ID, 0, 0, 0})
                Exit Sub
            End If
        End If


        If FormType = "ENQUIRY" Then
            LoadEnquiry()
        ElseIf FormType = "BQ" Then
            LoadBQ()
        Else
            LoadQuotation()
        End If

        Panel2.Select()

        'Disable Save button until changes has been made
        SaveQuoBtn.Enabled = False
        Edited = False

    End Sub

    Private Sub QuoNo_LookUpEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub QuoNo_LookUpEdit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QuoNo_LookUpEdit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            LoadQuotation()
        End If
    End Sub

    Private Sub LoadQuotation(Optional ByVal pQuotation_ID = 0)

        OnLoading = True
        OnLineLoading = True

        If (QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = Nothing) And pQuotation_ID = 0 Then
            Return
        End If

        If pQuotation_ID = 0 Then
            Quotation_ID = QuoNo_LookUpEdit.Properties.LookUpData.KeyValue
        Else
            Quotation_ID = pQuotation_ID
        End If

        EnableAllPanels()

        With New BusinessRules.SaleBusRules.SaleBusLogic
            Dim dsHeaderLoad As DataSet
            If .GetQuotationHeader(dsHeaderLoad, Quotation_ID) Then
                SetWindowValue(dsHeaderLoad)
            End If
        End With

        Status = StatusCmb.Properties.LookUpData.KeyValue

        'Default ========================
        DispatchBtn.Enabled = True
        'SaveQuoBtn.Enabled = True
        DispatchBtn.Text = "Dispatch"
        '=====================================

        'check if it is to be view mode or edit mode
        If Status = "30" Or Status = "20" Then
            FormStatus = "VIEW"
            RefreshNavBtn()
            CurrentRow = 0
            If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                Me.NavdsBox_PositionChanged()
            End If

            SetViewMode()
            If Status = "20" Then 'pending
                DispatchBtn.Text = "Prepare"
            End If

            If Status = "30" Then
                DispatchBtn.Enabled = False
                SaveQuoBtn.Enabled = False
            End If

        Else
            FormStatus = "EDIT"
            RefreshNavBtn()
            CurrentRow = 0
            If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                Me.NavdsBox_PositionChanged()
            Else ' initialize entry
                NavdsBox_Init()
            End If

            SetEditableMode()

        End If

        OnLoading = False
        OnLineLoading = False

    End Sub

    Private Sub LoadEnquiry()

        If (QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = Nothing) Then
            Return
        End If

        Quotation_ID = QuoNo_LookUpEdit.Properties.LookUpData.KeyValue

        If Quotation_ID = 0 Then
            Exit Sub
        End If

        EnableAllPanels()

        With New BusinessRules.EnquiryBusRules.EnquiryBusLogic
            Dim dsHeaderLoad As DataSet
            If .GetEnquiryHeader(dsHeaderLoad, Quotation_ID) Then
                SetWindowValue(dsHeaderLoad)
            End If
        End With

        Status = StatusCmb.Properties.LookUpData.KeyValue

        'Default ========================
        DispatchBtn.Enabled = True
        'SaveQuoBtn.Enabled = True
        DispatchBtn.Text = "Dispatch"
        '=====================================

        'check if it is to be view mode or edit mode
        If Status = "30" Or Status = "20" Then
            FormStatus = "VIEW"

            RefreshNavBtn_Enquiry()
            CurrentRow = 0

            If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                Me.NavdsBox_PositionChanged()
            End If

            SetViewMode()
            If Status = "20" Then 'pending
                DispatchBtn.Text = "Prepare"
            End If

            If Status = "30" Then
                DispatchBtn.Enabled = False
                SaveQuoBtn.Enabled = False
            End If

        Else
            FormStatus = "EDIT"
            CurrentRow = 0
            RefreshNavBtn_Enquiry()
            If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                Me.NavdsBox_PositionChanged()
            End If

            SetEditableMode()

        End If

    End Sub

    Private Sub LoadBQ()

        If (QuoNo_LookUpEdit.Properties.LookUpData.KeyValue = Nothing) Then
            Return
        End If

        Quotation_ID = QuoNo_LookUpEdit.Properties.LookUpData.KeyValue

        If Quotation_ID = 0 Then
            Exit Sub
        End If

        EnableAllPanels()

        With New BusinessRules.BQBusRules.BQBusLogic
            Dim dsHeaderLoad As DataSet
            If .GetBQHeader(dsHeaderLoad, Quotation_ID) Then
                SetWindowValue(dsHeaderLoad)
            End If
        End With

        Status = StatusCmb.Properties.LookUpData.KeyValue

        'Default ========================
        DispatchBtn.Enabled = True
        'SaveQuoBtn.Enabled = True
        DispatchBtn.Text = "Dispatch"
        '=====================================

        'check if it is to be view mode or edit mode
        If Status = "30" Or Status = "20" Then
            FormStatus = "VIEW"

            RefreshNavBtn_BQ()
            CurrentRow = 0

            If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                Me.NavdsBox_PositionChanged()
            End If

            SetViewMode()
            If Status = "20" Then 'pending
                DispatchBtn.Text = "Prepare"
            End If

            If Status = "30" Then
                DispatchBtn.Enabled = False
                SaveQuoBtn.Enabled = False
            End If

        Else
            FormStatus = "EDIT"
            RefreshNavBtn_BQ()
            CurrentRow = 0
            If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                Me.NavdsBox_PositionChanged()
            End If

            SetEditableMode()

        End If

    End Sub

    Private Sub SetViewMode()

        CustLookup.Properties.ReadOnly = True
        QuoDate.Properties.ReadOnly = True
        ContLookup.Properties.ReadOnly = True
        Addresstxt.Properties.ReadOnly = True
        ProjectCmb.Properties.ReadOnly = True
        ProjectTitleCmb.Properties.ReadOnly = True
        CP5Chk.Enabled = False
        ConsultantCmb.Properties.ReadOnly = True
        project_XtraButton.Enabled = False
        consult_XtraButton.Enabled = False
        contact_XtraButton.Enabled = False
        cust_XtraButton.Enabled = False

        '---------------------------------------------

        AddBtn.Enabled = False
        DelProdBtn.Enabled = False
        UpdateBtn.Enabled = False
        CopyButton.Enabled = False
        BoxCategoryCmb.Properties.ReadOnly = True
        QtyTxt.Properties.ReadOnly = True

        BoxDescTxt.Properties.ReadOnly = True
        BoxDescTxt_TextEdit.Properties.ReadOnly = True

        OverallMarkTxt.Properties.ReadOnly = True
        CompMarkTxt.Properties.ReadOnly = True

        HeightTxt.Properties.ReadOnly = True
        MaterialCmb.Properties.ReadOnly = True
        Typetxt.Properties.ReadOnly = True
        TypeEnclosureCmb.Properties.ReadOnly = True
        WidthTxt.Properties.ReadOnly = True
        PowerCoatTxt.Properties.ReadOnly = True
        ThicknessTxt.Properties.ReadOnly = True
        DepthTxt.Properties.ReadOnly = True
        MatCostTxt.Properties.ReadOnly = True

        WiringTxt.Properties.ReadOnly = True
        ConcreteBaseTxt.Properties.ReadOnly = True
        AccessoryTxt.Properties.ReadOnly = True
        TransportTxt.Properties.ReadOnly = True
        CopperTxt.Properties.ReadOnly = True
        OCEFTxt.Properties.ReadOnly = True
        IncomingTxt.Properties.ReadOnly = True
        PanelTransportTxt.Properties.ReadOnly = True
        InstallTxt.Properties.ReadOnly = True

        '-----------------------------------------------

        ValidityTxt.Properties.ReadOnly = True
        PayDetailsCmb.Properties.ReadOnly = True
        DelTermsCmb.Properties.ReadOnly = True
        NotesMemo.Properties.ReadOnly = True
        PriceTillCmb.Properties.ReadOnly = True
        ServiceTypeCmb.Properties.ReadOnly = True
        SignByCmb.Properties.ReadOnly = True
        ClosingTxt.Properties.ReadOnly = True
        OtherNotesMemo.Properties.ReadOnly = True

        '-----------------------------------------------


    End Sub


    Private Sub SetEditableMode()

        CustLookup.Properties.ReadOnly = False
        QuoDate.Properties.ReadOnly = False
        ContLookup.Properties.ReadOnly = False
        Addresstxt.Properties.ReadOnly = False
        ProjectCmb.Properties.ReadOnly = False
        ProjectTitleCmb.Properties.ReadOnly = False
        CP5Chk.Enabled = True
        ConsultantCmb.Properties.ReadOnly = False
        project_XtraButton.Enabled = True
        consult_XtraButton.Enabled = True
        contact_XtraButton.Enabled = True
        cust_XtraButton.Enabled = True

        '---------------------------------------------

        AddBtn.Enabled = True
        'DelProdBtn.Enabled = True
        'UpdateBtn.Enabled = True
        CopyButton.Enabled = True
        BoxCategoryCmb.Properties.ReadOnly = False
        QtyTxt.Properties.ReadOnly = False

        BoxDescTxt.Properties.ReadOnly = False
        BoxDescTxt_TextEdit.Properties.ReadOnly = False

        OverallMarkTxt.Properties.ReadOnly = False
        CompMarkTxt.Properties.ReadOnly = False

        HeightTxt.Properties.ReadOnly = False
        MaterialCmb.Properties.ReadOnly = False
        Typetxt.Properties.ReadOnly = False
        TypeEnclosureCmb.Properties.ReadOnly = False
        WidthTxt.Properties.ReadOnly = False
        PowerCoatTxt.Properties.ReadOnly = False
        ThicknessTxt.Properties.ReadOnly = False
        DepthTxt.Properties.ReadOnly = False
        MatCostTxt.Properties.ReadOnly = False

        WiringTxt.Properties.ReadOnly = False
        ConcreteBaseTxt.Properties.ReadOnly = False
        AccessoryTxt.Properties.ReadOnly = False
        TransportTxt.Properties.ReadOnly = False
        CopperTxt.Properties.ReadOnly = False
        OCEFTxt.Properties.ReadOnly = False
        IncomingTxt.Properties.ReadOnly = False
        PanelTransportTxt.Properties.ReadOnly = False
        InstallTxt.Properties.ReadOnly = False

        '-----------------------------------------------

        ValidityTxt.Properties.ReadOnly = False
        PayDetailsCmb.Properties.ReadOnly = False
        DelTermsCmb.Properties.ReadOnly = False
        NotesMemo.Properties.ReadOnly = False
        PriceTillCmb.Properties.ReadOnly = False
        ServiceTypeCmb.Properties.ReadOnly = False
        SignByCmb.Properties.ReadOnly = False
        ClosingTxt.Properties.ReadOnly = False
        OtherNotesMemo.Properties.ReadOnly = False

        '-----------------------------------------------


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateOCBtn.Click

    End Sub

    Private Sub BoxCategoryCmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxCategoryCmb.Click

    End Sub

    Private Sub BoxDescTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxDescTxt.ValueChanged
        BoxDescTxt_TextEdit.Text = BoxDescTxt.Text
        'If CountNewLine(BoxDescTxt.Text) > 4 Then
        'BoxDescTxt_TextEdit.Text = BoxDescTxt.Text
        'End If
        OnLineEdit()
    End Sub

    Private Function CountNewLine(ByVal pString As String)
        Dim n As Integer
        'val1 = 0
        For n = 1 To Len(pString)
            If Asc(Mid(pString, n, 1)) = 13 Then
                CountNewLine = CountNewLine + 1
            End If
        Next n
    End Function

    Private Sub BoxDescTxt_TextEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BoxDescTxt.Text = BoxDescTxt_TextEdit.Text
    End Sub

    Private Sub UnitPrice_Txt_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitPrice_Txt.VisibleChanged

    End Sub

    Private Sub UnitPrice_Txt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitPrice_Txt.ValueChanged
        Dim Qty As Integer = 0
        Dim UnitPrice As Decimal = 0.0

        If True Then 'BoxCategoryCmb.Text.ToUpper = "TRADING ITEM" Then

            If QtyTxt.Text <> Nothing Then
                Qty = QtyTxt.Text
            End If
            If UnitPrice_Txt.Text <> Nothing Then
                UnitPrice = UnitPrice_Txt.Text
            End If


            Total_Amount = Qty * UnitPrice

            'TotalAmtTxt.Text = Decimal.Round((Total_Amount), 2)
        End If

        OnLineEdit()

    End Sub

    Private Sub QtyTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QtyTxt.ValueChanged
        If True Then 'BoxCategoryCmb.Text.ToUpper = "TRADING ITEM" Then

            If QtyTxt.Text <> Nothing Then
                Qty = QtyTxt.Text
            End If
            If UnitPrice_Txt.Text <> Nothing Then
                UnitPrice = UnitPrice_Txt.Text
            End If


            Total_Amount = Qty * UnitPrice

            'TotalAmtTxt.Text = Decimal.Round((Total_Amount), 2)
        End If

        OnLineEdit()
    End Sub

    Private Sub Splitter2_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles Splitter2.SplitterMoved

    End Sub

    Private Sub Item_GridControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Item_GridControl.Click

        'GridView2.G()
        'GridView2.UnselectRow()
        'GridView2.FocusedRowHandle
        'GridView2.SelectRow(

        'If item_multiselect_CheckBox.Checked = True Then

        '    If PreviousFocusedHandle <> GridView2.FocusedRowHandle Then
        '        GridView2.SelectRow(PreviousFocusedHandle)
        '    Else

        '        Dim SelectedRows As Int32() = GridView2.GetSelectedRows()

        '        If SelectedRows.Contains(GridView2.FocusedRowHandle) Then

        '            If GridView2.SelectedRowsCount > 1 Then
        '                GridView2.UnselectRow(GridView2.FocusedRowHandle)
        '            End If

        '        End If

        '    End If
        'End If

        If GridView2.FocusedRowHandle = CurrentRow Then
            Exit Sub
        End If

        If LineEdited = True Then
            If LineNotUpdate() = True Then 'cancel change item
                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                Exit Sub
            End If
        End If

        UpdateBtn.Enabled = False
        LineEdited = False

        If GridView2.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        CurrentRow = GridView2.FocusedRowHandle
        Me.BindingContext(NavdsBox).Position = CurrentRow
        Me.NavdsBox_PositionChanged()

        PreviousFocusedHandle = GridView2.FocusedRowHandle



    End Sub

    Private Sub Item_GridControl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Item_GridControl.KeyDown

    End Sub

    Private Sub Item_GridControl_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Item_GridControl.KeyUp


        If GridView2.FocusedRowHandle = CurrentRow Then
            Exit Sub
        End If

        If LineEdited = True Then
            If LineNotUpdate() = True Then 'cancel change item
                GridView2.FocusedRowHandle = CurrentRow
                GridView2.ClearSelection()
                GridView2.SelectRow(CurrentRow)

                Exit Sub
            End If
        End If

        UpdateBtn.Enabled = False
        LineEdited = False

        If GridView2.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        CurrentRow = GridView2.FocusedRowHandle
        Me.BindingContext(NavdsBox).Position = CurrentRow
        Me.NavdsBox_PositionChanged()

        PreviousFocusedHandle = GridView2.FocusedRowHandle

    End Sub

    Private Sub Item_GridControl_ProcessGridKey(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Item_GridControl.ProcessGridKey

    End Sub

    Private Sub Payment_ExpandablePanel_ExpandedChanging(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Payment_ExpandablePanel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Payment_ExpandablePanel.DoubleClick
        If ExpandablePanel_Changing = True Or Payment_ExpandablePanelChanging = True Then
            Exit Sub
        End If
    End Sub

    Private Sub project_XtraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles project_XtraButton.Click
        Dim f As ManageProjectForm
        f = New ManageProjectForm(1)
        f.ShowDialog()
        ProjectTitleCmb.Properties.LookUpData.ListFields.Clear()
        LoadProjectTitle(f.Project_ID)
    End Sub

    Private Sub CompGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompGrid1.Click

    End Sub

    Private Sub Payment_ExpandablePanel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Payment_ExpandablePanel.Click
        Me.Payment_ExpandablePanel.Expanded = Not (Me.Payment_ExpandablePanel.Expanded)
    End Sub

    Private Sub BoxCategoryCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxCategoryCmb.ValueChanged
        BoxCategoryChanged()
        OnLineEdit()
    End Sub

    Private Sub contact_XtraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contact_XtraButton.Click
        If Customer_ID = 0 Then
            MessageBox.Show("Please select a Customer first", "Contact Person", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim f As CustomerContactForm
        f = New CustomerContactForm(1, Me.Customer_ID)
        f.ShowDialog()
        ContLookup.Properties.LookUpData.ListFields.Clear()
        LoadContactPerson(Customer_ID, f.Contact_ID)

    End Sub

    Private Sub cust_XtraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cust_XtraButton.Click
        Dim f As ManageCustomerForm
        f = New ManageCustomerForm(1)
        f.ShowDialog()
        CustLookup.Properties.LookUpData.ListFields.Clear()
        LoadCustomerDetails(f.Customer_ID)
    End Sub

    Function LineNotUpdate() As Boolean
        Dim Result As DialogResult
        Dim WarningMsg As String

        WarningMsg = "You have made changes or have edited line item without saving, Are you sure you discard changes to this item?"
        Result = MessageBox.Show(WarningMsg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If Result = DialogResult.No Then
            LineNotUpdate = True
            Exit Function
        End If

        LineNotUpdate = False

    End Function


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Button.Click

        Dim Result As DialogResult
        Dim WarningMsg As String

        WarningMsg = "You have made changes or have edited data without saving, Are you sure you want to exit and create a new"

        If FormType = "ENQUIRY" Then
            WarningMsg = WarningMsg & "Enquiry"
        ElseIf FormType = "BQ" Then
            WarningMsg = WarningMsg & "BQ"
        Else
            WarningMsg = WarningMsg & "Quotation"
        End If

        If Edited = True Then

            Result = MessageBox.Show(WarningMsg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                Exit Sub
            End If
        End If

        Edited = False

        QuoNoTxt.Visible = True
        QuoNo_LookUpEdit.Visible = False
        FormStatus = "NEW"
        InitForms()
        SelectAction()

        'PrepareQuotation_Form()

        'StatusCmb.Properties.LookUpData.KeyValue = "10" 'Preparing
        'QuoDate.DateTime = Date.Today
        'ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        'SignByCmb.Properties.LookUpData.KeyValue = "Thomas Yeo"
        'ServiceTypeCmb.Properties.LookUpData.KeyValue = "1"
        'PriceTillCmb.Properties.LookUpData.KeyValue = "2"
        'ItemNoTxt.Text = ItemNo.ToString


        'DisableNavBtn()

        'New_Button.Enabled = False
        LoadQuotation(Quotation_ID)
        EnableAllPanels()
        SetEditableMode()

    End Sub

    Private Sub CustLookup_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustLookup.ValueChanged
        OnEdit()
    End Sub

    Private Sub OnEdit()
        If OnLoading = False Then
            Edited = True
            SaveQuoBtn.Enabled = True
        End If
    End Sub

    Private Sub OnLineEdit()
        If OnLineLoading = False Then
            LineEdited = True
            UpdateBtn.Enabled = True
        End If
    End Sub

    Private Sub QuotationForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Result As DialogResult

        If Edited = True Then

            Result = MessageBox.Show("You have made changes or have edited data without saving, Are you sure you want to close? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                e.Cancel = True
            Else
                Dim a As MainForm = Me.ParentForm
                If (a.MainTabControl.TabPages.Count > 0) Then
                    If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                        a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                    End If
                End If
            End If
        Else
            Dim a As MainForm = Me.ParentForm
            If (a.MainTabControl.TabPages.Count > 0) Then
                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                End If
            End If
        End If
    End Sub

    Private Sub ContLookup_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContLookup.ValueChanged
        OnEdit()
    End Sub

    Private Sub ProjectCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub QuoDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuoDate.ValueChanged
        OnEdit()
    End Sub

    Private Sub StatusCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub ProjectTitleCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectTitleCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub ConsultantCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultantCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub CP5Chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP5Chk.CheckedChanged
        OnEdit()
    End Sub

    Private Sub QuotationForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub QuotationForm_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged

    End Sub

    Private Sub Remarks_MemoEdit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remarks_MemoEdit.ValueChanged
        OnLineEdit()
    End Sub

    Private Sub OverallMarkTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverallMarkTxt.ValueChanged
        OnLineEdit()
    End Sub

    Private Sub CompMarkTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompMarkTxt.ValueChanged
        OnLineEdit()
    End Sub

    Private Sub LineItem_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeightTxt.ValueChanged, DepthTxt.ValueChanged, AccessoryTxt.ValueChanged
        OnLineEdit()
    End Sub

    Private Sub Option_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btnSender As Button = sender
        Dim ptLowerLeft As Point = New Point(0, btnSender.Height)
        ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
        Quotation_ContextMenuStrip.Show(ptLowerLeft)

    End Sub

    Private Sub Option_Button_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Option_Button.CheckStateChanged

        If Option_Button.Checked = True Then
            Dim btnSender As CheckBox = sender
            Dim ptLowerLeft As Point = New Point(0, btnSender.Height)
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
            Quotation_ContextMenuStrip.Show(ptLowerLeft)
        End If


    End Sub

    Private Sub QuotationCopy_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotationCopy_ToolStripMenuItem.Click

        Option_Button.Checked = False

    End Sub

    Private Sub QuotationDelete_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotationDelete_ToolStripMenuItem.Click

        Option_Button.Checked = False


    End Sub

    Private Sub Option_Button_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Option_Button.Leave

        Option_Button.Checked = False

    End Sub

    Private Sub Quotation_ContextMenuStrip_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quotation_ContextMenuStrip.VisibleChanged

        If Quotation_ContextMenuStrip.Visible = False Then
            Option_Button.Checked = False
        End If

    End Sub

    Private Sub Revise_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Revise_Button.Click

        Dim Result As DialogResult
        Dim WarningMsg As String

        WarningMsg = "You have made changes or have edited data without saving, Are you sure you want proceed?"

        If FormType = "ENQUIRY" Then
            WarningMsg = WarningMsg & "Enquiry"
        ElseIf FormType = "BQ" Then
            WarningMsg = WarningMsg & "BQ"
        Else
            WarningMsg = WarningMsg & "Quotation"
        End If

        If Edited = True Then

            Result = MessageBox.Show(WarningMsg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                Exit Sub
            End If
        End If

        Edited = False

        Dim tmpOld_Quotation_ID As Integer
        Dim controlToAdd As Control = Nothing
        Dim RevisedQuotation_ID As Integer

        'tmpOld_Quotation_ID = Quotation_ID

        RevisedQuotation_ID = CreateReviseQuotation(Quotation_ID)
        RevisedQuotationLine(Quotation_ID, RevisedQuotation_ID)

        If Not RevisedQuotation_ID = 0 Then
            Me.Cursor = Cursors.WaitCursor
            controlToAdd = New QuotationForm("LIST", RevisedQuotation_ID)

            Dim page As Crownwood.Magic.Controls.TabPage

            ' Create a new page with the appropriate control for display, title text and image
            page = New Crownwood.Magic.Controls.TabPage("Quotation List", controlToAdd, ImageList1, 0)

            ' Make this page become selected when added
            page.Selected = True

            Dim mainform As MainForm
            mainform = Me.ParentForm

            mainform.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Quotation_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidityTxt.ValueChanged, PayDetailsCmb.ValueChanged, DelTermsCmb.ValueChanged, ClosingTxt.ValueChanged, NotesMemo.ValueChanged
        OnEdit()
    End Sub

    Private Sub Item_GridControl_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Item_GridControl.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        Dim eventString As String = Nothing
        Select Case e.Button
            Case MouseButtons.Left
                eventString = "L"
            Case MouseButtons.Right
                eventString = "R"
                If FormStatus <> "VIEW" Then
                    'Check if clipboard is empty
                    CheckClipboard()
                    item_ContextMenu.Show(sender, mouseDownLocation)
                End If
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub

    Private Sub Select_item_MenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item_multiselect_CheckBox.Click





    End Sub


    Private Sub Item_GridControl_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Item_GridControl.MouseHover

    End Sub



    Private Sub consult_XtraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consult_XtraButton.Click

    End Sub


    Private Sub Item_GridControl_CursorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Item_GridControl.CursorChanged

    End Sub

    Private Sub GridView2_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.SelectionChangedEventArgs) Handles GridView2.SelectionChanged

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_MenuItem.Click
        'Copy Quotation Line item to clipboard
        CopyQuotationLineClipboard()
    End Sub


    Private Sub CopyQuotationLineClipboard()
        Dim dsLine As DataSet
        Dim Old_Quotation_Line_ID As Integer
        Dim x As Int32

        ItemNo = 0
        LineNo = 0

        With New BusinessRules.SaleBusRules.SaleBusLogic

            .ClearClipboard_QuotationLine(UserID)
            For Each x In GridView2.GetSelectedRows()
                'GridView2.GetDataRow(x)("quotation_line_id")
                .CopyClipboard_QuotationLine(GridView2.GetDataRow(x)("quotation_line_id"), GridView2.GetDataRow(x)("no"), UserID)
            Next

        End With
    End Sub

    Private Sub item_multiselect_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item_multiselect_CheckBox.CheckedChanged
        'item_multiselect_CheckBox.Checked = Not item_multiselect_CheckBox.Checked
        Paste_MenuItem.Checked = item_multiselect_CheckBox.Checked
        If item_multiselect_CheckBox.Checked = True Then 'multi select mode
            GridView2.BehaviorOptions = GridView2.BehaviorOptions Or BehaviorOptionsFlags.MultiSelect
        Else
            GridView2.BehaviorOptions = GridView2.BehaviorOptions And (Not BehaviorOptionsFlags.MultiSelect)
        End If
    End Sub

    Sub Item_MultSelect(ByVal pStat As Boolean)
        Paste_MenuItem.Checked = pStat

        If Paste_MenuItem.Checked = True Then 'multi select mode
            GridView2.BehaviorOptions = GridView2.BehaviorOptions Or BehaviorOptionsFlags.MultiSelect
        Else
            GridView2.BehaviorOptions = GridView2.BehaviorOptions And (Not BehaviorOptionsFlags.MultiSelect)
        End If
    End Sub

    Sub CheckClipboard()
        With New BusinessRules.SaleBusRules.SaleBusLogic

            If .IsClipboard_QuotationLine_Empty(UserID) = True Then
                Me.Paste_MenuItem.Enabled = False
            Else
                Me.Paste_MenuItem.Enabled = True
            End If

        End With
    End Sub

    Private Sub Select_item_MenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste_MenuItem.Click
        'Paste
        Dim dsLine As DataSet

        If LineEdited = True Then
            If LineNotUpdate() = True Then 'cancel change item
                GridView2.FocusedRowHandle = CurrentRow
                Exit Sub
            End If
        End If

        UpdateBtn.Enabled = False
        LineEdited = False

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetClipboard_QuotationLine_Empty(dsLine, UserID) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    CopyandPasteQuotationLine(dsLine.Tables(0).Rows(x)("ID"))
                    RefreshNavBtn()
                Next
                .ClearClipboard_QuotationLine(UserID) 'empty clipboard after paste

                CurrentRow = GridView2.RowCount - 1
                RefreshNavBtn()
                GridView2.ClearSelection()
                GridView2.SelectRow(GridView2.RowCount - 1)
                GridView2.FocusedRowHandle = GridView2.RowCount - 1

                Me.BindingContext(NavdsBox).Position = CurrentRow
                Me.NavdsBox_PositionChanged()


            End If

        End With



    End Sub

    Private Sub Component_Splitter_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Component_Splitter.DoubleClick
        If Me.item_TabControl.Height > 80 Then
            item_TabControl.Height = 80
        Else
            item_TabControl.Height = 138
        End If
    End Sub

    Private Sub SignByCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignByCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub PriceTillCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceTillCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub ServiceTypeCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceTypeCmb.ValueChanged
        OnEdit()
    End Sub

    Private Sub OtherNotesMemo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherNotesMemo.ValueChanged
        OnEdit()
    End Sub
End Class



