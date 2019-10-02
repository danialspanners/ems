Public Class WorkPlanForm
    Inherits System.Windows.Forms.Form

#Region " WorkPlanHeader's variable"
    Public WP_ID As Integer
    Public WP_No As String
    Public WO_ID As Integer
    Public Status As Integer
    Public Box As String
    Public Key_Type As String
    Public Height As String
    Public Width As String
    Public Depth As String
    Public Draw_No As String
    Public Qty As String
    Public Remark As String
    Public ET_PowderCoat As String
    Public ET_MetalProcess As String
    Public ET_Assembly As String
    Public ET_Inspection As String
    Public ET_Completion As String
    Public Act_PowderCoat As String
    Public Act_MetalProcess As String
    Public Act_Assembly As String
    Public Act_Inspection As String
    Public Act_Completion As String
    Public RevRefWPID As Integer
    Public Create_Date As String
    Public Transact_Date As String
    'Public UserID As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
#End Region

#Region " WorkPlanLine's variable"
    Public WPLine_ID As Integer
    Public LnWP_ID As Integer
    Public LnCategory_ID As Integer
    Public LnProduct_ID As Integer
    Public LnMaterial_ID As Integer
    Public LnColor_ID As Integer
    Public LnQty As String
    Public LnCutting As String
    Public LnPunching As String
    Public LnBending As String
    Public LnPowerPress As String
    Public LnWelding As String
    Public LnPCProcess As String
    Public LnRemark As String
    Public LnCreate_Date As String
    Public LnTransact_Date As String
    Public LnUserID As Integer
#End Region

    Public FormStatus As String
    Public Old_WP_ID As Integer
    Public WPds As DataSet
    Public data As System.Data.DataTable

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pWP_ID As Integer = 0, Optional ByVal pOld_WP_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus

        If Not pWP_ID = 0 Then
            WP_ID = pWP_ID
        End If

        If Not pOld_WP_ID = 0 Then
            Old_WP_ID = pOld_WP_ID
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RemarkTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents WOCmd As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WorkPlanNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DrawNoCmd As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ActPowderCoatDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstPowderCoatDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ActMetalProcessDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstMetalProcessDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ActAssemblyDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstAssemblyDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ActInspectionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstInspectionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ActCompletionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstCompletionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KeyTypeCmd As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EditWPLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DelWPLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NewWPLineBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents StatusCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HeightTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WidthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DepthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BoxTypeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DispatchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WPLineGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents CuttingCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PunchingCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BendingCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents WeldingCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LineIDTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MaterialComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PartCodeTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PartCodeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PartCodeLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MaterialLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WidthTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LengthTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotAreaTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PCPriceTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColorLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescriptionMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents PCProessCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PCProcessCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WeldingItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BendingItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PunchingItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CuttingItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PpressCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PowerPressItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents btnPricing As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ThickCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WorkPlanForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BoxTypeTxt = New DevExpress.XtraEditors.TextEdit
        Me.DepthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WidthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.HeightTxt = New DevExpress.XtraEditors.SpinEdit
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.StatusCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.KeyTypeCmd = New DevExpress.XtraEditors.LookUpEdit
        Me.ActInspectionDate = New DevExpress.XtraEditors.DateEdit
        Me.EstInspectionDate = New DevExpress.XtraEditors.DateEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ActAssemblyDate = New DevExpress.XtraEditors.DateEdit
        Me.EstAssemblyDate = New DevExpress.XtraEditors.DateEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ActMetalProcessDate = New DevExpress.XtraEditors.DateEdit
        Me.EstMetalProcessDate = New DevExpress.XtraEditors.DateEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ActPowderCoatDate = New DevExpress.XtraEditors.DateEdit
        Me.EstPowderCoatDate = New DevExpress.XtraEditors.DateEdit
        Me.DrawNoCmd = New DevExpress.XtraEditors.LookUpEdit
        Me.WorkPlanNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.RemarkTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.WOCmd = New DevExpress.XtraEditors.LookUpEdit
        Me.ActCompletionDate = New DevExpress.XtraEditors.DateEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.EstCompletionDate = New DevExpress.XtraEditors.DateEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EditWPLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewWPLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DelWPLineBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DispatchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.WPLineGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.CuttingCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PunchingCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.BendingCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.WeldingCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PCProessCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.LineIDTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.MaterialComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PartCodeTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PartCodeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PartCodeLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.MaterialLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.WidthTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.LengthTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.TotAreaTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PCPriceTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ColorLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DescriptionMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.PCProcessCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.WeldingItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.BendingItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PunchingItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.CuttingItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PpressCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PowerPressItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ThickCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.btnPricing = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.BoxTypeTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyTypeCmd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActAssemblyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstAssemblyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActMetalProcessDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstMetalProcessDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActPowderCoatDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstPowderCoatDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawNoCmd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPlanNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WOCmd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActCompletionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstCompletionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WPLineGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PunchingCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BendingCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeldingCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCProessCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineIDTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LengthTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotAreaTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCPriceTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCProcessCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeldingItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BendingItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PunchingItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PpressCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerPressItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThickCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BoxTypeTxt)
        Me.GroupBox1.Controls.Add(Me.DepthTxt)
        Me.GroupBox1.Controls.Add(Me.WidthTxt)
        Me.GroupBox1.Controls.Add(Me.HeightTxt)
        Me.GroupBox1.Controls.Add(Me.QtyTxt)
        Me.GroupBox1.Controls.Add(Me.StatusCmb)
        Me.GroupBox1.Controls.Add(Me.KeyTypeCmd)
        Me.GroupBox1.Controls.Add(Me.ActInspectionDate)
        Me.GroupBox1.Controls.Add(Me.EstInspectionDate)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ActAssemblyDate)
        Me.GroupBox1.Controls.Add(Me.EstAssemblyDate)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ActMetalProcessDate)
        Me.GroupBox1.Controls.Add(Me.EstMetalProcessDate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ActPowderCoatDate)
        Me.GroupBox1.Controls.Add(Me.EstPowderCoatDate)
        Me.GroupBox1.Controls.Add(Me.DrawNoCmd)
        Me.GroupBox1.Controls.Add(Me.WorkPlanNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RemarkTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Controls.Add(Me.WOCmd)
        Me.GroupBox1.Controls.Add(Me.ActCompletionDate)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.EstCompletionDate)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 288)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'BoxTypeTxt
        '
        Me.BoxTypeTxt.Location = New System.Drawing.Point(368, 72)
        Me.BoxTypeTxt.Name = "BoxTypeTxt"
        Me.BoxTypeTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxTypeTxt.Size = New System.Drawing.Size(152, 19)
        Me.BoxTypeTxt.TabIndex = 183
        '
        'DepthTxt
        '
        Me.DepthTxt.Location = New System.Drawing.Point(592, 72)
        Me.DepthTxt.Name = "DepthTxt"
        Me.DepthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DepthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DepthTxt.Size = New System.Drawing.Size(72, 19)
        Me.DepthTxt.TabIndex = 182
        Me.DepthTxt.Text = "0"
        '
        'WidthTxt
        '
        Me.WidthTxt.Location = New System.Drawing.Point(592, 48)
        Me.WidthTxt.Name = "WidthTxt"
        Me.WidthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WidthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WidthTxt.Size = New System.Drawing.Size(72, 19)
        Me.WidthTxt.TabIndex = 181
        Me.WidthTxt.Text = "0"
        '
        'HeightTxt
        '
        Me.HeightTxt.Location = New System.Drawing.Point(592, 24)
        Me.HeightTxt.Name = "HeightTxt"
        Me.HeightTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.HeightTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HeightTxt.Size = New System.Drawing.Size(72, 19)
        Me.HeightTxt.TabIndex = 180
        Me.HeightTxt.Text = "0"
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(368, 24)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(64, 19)
        Me.QtyTxt.TabIndex = 179
        Me.QtyTxt.Text = "0"
        '
        'StatusCmb
        '
        Me.StatusCmb.Location = New System.Drawing.Point(120, 96)
        Me.StatusCmb.Name = "StatusCmb"
        Me.StatusCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusCmb.Properties.NullString = ""
        Me.StatusCmb.Properties.PopupWidth = 152
        Me.StatusCmb.Size = New System.Drawing.Size(152, 19)
        Me.StatusCmb.TabIndex = 178
        '
        'KeyTypeCmd
        '
        Me.KeyTypeCmd.Location = New System.Drawing.Point(368, 48)
        Me.KeyTypeCmd.Name = "KeyTypeCmd"
        Me.KeyTypeCmd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.KeyTypeCmd.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.KeyTypeCmd.Properties.NullString = ""
        Me.KeyTypeCmd.Properties.PopupWidth = 208
        Me.KeyTypeCmd.Size = New System.Drawing.Size(72, 19)
        Me.KeyTypeCmd.TabIndex = 176
        '
        'ActInspectionDate
        '
        Me.ActInspectionDate.DateTime = New Date(CType(0, Long))
        Me.ActInspectionDate.Location = New System.Drawing.Point(440, 232)
        Me.ActInspectionDate.Name = "ActInspectionDate"
        Me.ActInspectionDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActInspectionDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ActInspectionDate.Size = New System.Drawing.Size(104, 19)
        Me.ActInspectionDate.TabIndex = 175
        '
        'EstInspectionDate
        '
        Me.EstInspectionDate.DateTime = New Date(CType(0, Long))
        Me.EstInspectionDate.Location = New System.Drawing.Point(152, 232)
        Me.EstInspectionDate.Name = "EstInspectionDate"
        Me.EstInspectionDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EstInspectionDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EstInspectionDate.Size = New System.Drawing.Size(104, 19)
        Me.EstInspectionDate.TabIndex = 174
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(288, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 16)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Act. Inspection Date :"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "Est. Inspection Date:"
        '
        'ActAssemblyDate
        '
        Me.ActAssemblyDate.DateTime = New Date(CType(0, Long))
        Me.ActAssemblyDate.Location = New System.Drawing.Point(440, 208)
        Me.ActAssemblyDate.Name = "ActAssemblyDate"
        Me.ActAssemblyDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActAssemblyDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ActAssemblyDate.Size = New System.Drawing.Size(104, 19)
        Me.ActAssemblyDate.TabIndex = 171
        '
        'EstAssemblyDate
        '
        Me.EstAssemblyDate.DateTime = New Date(CType(0, Long))
        Me.EstAssemblyDate.Location = New System.Drawing.Point(152, 208)
        Me.EstAssemblyDate.Name = "EstAssemblyDate"
        Me.EstAssemblyDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EstAssemblyDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EstAssemblyDate.Size = New System.Drawing.Size(104, 19)
        Me.EstAssemblyDate.TabIndex = 170
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(288, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 16)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "Act. Assembly Date :"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "Est.  Assembly Date:"
        '
        'ActMetalProcessDate
        '
        Me.ActMetalProcessDate.DateTime = New Date(CType(0, Long))
        Me.ActMetalProcessDate.Location = New System.Drawing.Point(440, 184)
        Me.ActMetalProcessDate.Name = "ActMetalProcessDate"
        Me.ActMetalProcessDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActMetalProcessDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ActMetalProcessDate.Size = New System.Drawing.Size(104, 19)
        Me.ActMetalProcessDate.TabIndex = 167
        '
        'EstMetalProcessDate
        '
        Me.EstMetalProcessDate.DateTime = New Date(CType(0, Long))
        Me.EstMetalProcessDate.Location = New System.Drawing.Point(152, 184)
        Me.EstMetalProcessDate.Name = "EstMetalProcessDate"
        Me.EstMetalProcessDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EstMetalProcessDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EstMetalProcessDate.Size = New System.Drawing.Size(104, 19)
        Me.EstMetalProcessDate.TabIndex = 166
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Act.Metal Process Date :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 16)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Est.  Metal Process Date:"
        '
        'ActPowderCoatDate
        '
        Me.ActPowderCoatDate.DateTime = New Date(CType(0, Long))
        Me.ActPowderCoatDate.Location = New System.Drawing.Point(440, 160)
        Me.ActPowderCoatDate.Name = "ActPowderCoatDate"
        Me.ActPowderCoatDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActPowderCoatDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ActPowderCoatDate.Size = New System.Drawing.Size(104, 19)
        Me.ActPowderCoatDate.TabIndex = 163
        '
        'EstPowderCoatDate
        '
        Me.EstPowderCoatDate.DateTime = New Date(CType(0, Long))
        Me.EstPowderCoatDate.Location = New System.Drawing.Point(152, 160)
        Me.EstPowderCoatDate.Name = "EstPowderCoatDate"
        Me.EstPowderCoatDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EstPowderCoatDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EstPowderCoatDate.Size = New System.Drawing.Size(104, 19)
        Me.EstPowderCoatDate.TabIndex = 162
        '
        'DrawNoCmd
        '
        Me.DrawNoCmd.Location = New System.Drawing.Point(120, 72)
        Me.DrawNoCmd.Name = "DrawNoCmd"
        Me.DrawNoCmd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DrawNoCmd.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DrawNoCmd.Properties.NullString = ""
        Me.DrawNoCmd.Properties.PopupWidth = 208
        Me.DrawNoCmd.Size = New System.Drawing.Size(152, 19)
        Me.DrawNoCmd.TabIndex = 157
        '
        'WorkPlanNoTxt
        '
        Me.WorkPlanNoTxt.Location = New System.Drawing.Point(120, 24)
        Me.WorkPlanNoTxt.Name = "WorkPlanNoTxt"
        Me.WorkPlanNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WorkPlanNoTxt.Properties.ReadOnly = True
        Me.WorkPlanNoTxt.Size = New System.Drawing.Size(152, 19)
        Me.WorkPlanNoTxt.TabIndex = 153
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Work Plan Number :"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(544, 72)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 16)
        Me.Label39.TabIndex = 146
        Me.Label39.Text = "Depth :"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(544, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 16)
        Me.Label38.TabIndex = 145
        Me.Label38.Text = "Width :"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(544, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 16)
        Me.Label37.TabIndex = 144
        Me.Label37.Text = "Height :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Key Code :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Drawing No. Ref :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Type of Box :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Quantity :"
        '
        'RemarkTxt
        '
        Me.RemarkTxt.Location = New System.Drawing.Point(368, 96)
        Me.RemarkTxt.Name = "RemarkTxt"
        Me.RemarkTxt.Size = New System.Drawing.Size(296, 48)
        Me.RemarkTxt.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Remarks :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Act. Powder Coat Date :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Est.  Powder Coat Date:"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(8, 48)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(112, 16)
        Me.CustNameLbl.TabIndex = 26
        Me.CustNameLbl.Text = "Work Order Number :"
        '
        'WOCmd
        '
        Me.WOCmd.Location = New System.Drawing.Point(120, 48)
        Me.WOCmd.Name = "WOCmd"
        Me.WOCmd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WOCmd.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WOCmd.Properties.NullString = ""
        Me.WOCmd.Properties.PopupWidth = 208
        Me.WOCmd.Size = New System.Drawing.Size(152, 19)
        Me.WOCmd.TabIndex = 41
        '
        'ActCompletionDate
        '
        Me.ActCompletionDate.DateTime = New Date(CType(0, Long))
        Me.ActCompletionDate.Location = New System.Drawing.Point(440, 256)
        Me.ActCompletionDate.Name = "ActCompletionDate"
        Me.ActCompletionDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ActCompletionDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ActCompletionDate.Size = New System.Drawing.Size(104, 19)
        Me.ActCompletionDate.TabIndex = 167
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 16)
        Me.Label17.TabIndex = 164
        Me.Label17.Text = "Est. Completion Date:"
        '
        'EstCompletionDate
        '
        Me.EstCompletionDate.DateTime = New Date(CType(0, Long))
        Me.EstCompletionDate.Location = New System.Drawing.Point(152, 256)
        Me.EstCompletionDate.Name = "EstCompletionDate"
        Me.EstCompletionDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EstCompletionDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EstCompletionDate.Size = New System.Drawing.Size(104, 19)
        Me.EstCompletionDate.TabIndex = 166
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(288, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 165
        Me.Label16.Text = "Act. Completion Date :"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 177
        Me.Label18.Text = "Status :"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(624, 504)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 19
        Me.CancelBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(552, 504)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 18
        Me.SaveBtn.Text = "Save"
        '
        'EditWPLineBtn
        '
        Me.EditWPLineBtn.AutoSize = False
        Me.EditWPLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditWPLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditWPLineBtn.Image = Nothing
        Me.EditWPLineBtn.Location = New System.Drawing.Point(80, 504)
        Me.EditWPLineBtn.Name = "EditWPLineBtn"
        Me.EditWPLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.EditWPLineBtn.TabIndex = 21
        Me.EditWPLineBtn.Text = "Edit"
        Me.EditWPLineBtn.Visible = False
        '
        'NewWPLineBtn
        '
        Me.NewWPLineBtn.AutoSize = False
        Me.NewWPLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewWPLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewWPLineBtn.Image = Nothing
        Me.NewWPLineBtn.Location = New System.Drawing.Point(8, 504)
        Me.NewWPLineBtn.Name = "NewWPLineBtn"
        Me.NewWPLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.NewWPLineBtn.TabIndex = 20
        Me.NewWPLineBtn.Text = "Add"
        Me.NewWPLineBtn.Visible = False
        '
        'DelWPLineBtn
        '
        Me.DelWPLineBtn.AutoSize = False
        Me.DelWPLineBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelWPLineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelWPLineBtn.Image = Nothing
        Me.DelWPLineBtn.Location = New System.Drawing.Point(408, 504)
        Me.DelWPLineBtn.Name = "DelWPLineBtn"
        Me.DelWPLineBtn.Size = New System.Drawing.Size(64, 32)
        Me.DelWPLineBtn.TabIndex = 23
        Me.DelWPLineBtn.Text = "Delete"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DispatchBtn
        '
        Me.DispatchBtn.AutoSize = False
        Me.DispatchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DispatchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DispatchBtn.Image = Nothing
        Me.DispatchBtn.Location = New System.Drawing.Point(480, 504)
        Me.DispatchBtn.Name = "DispatchBtn"
        Me.DispatchBtn.Size = New System.Drawing.Size(64, 32)
        Me.DispatchBtn.TabIndex = 24
        Me.DispatchBtn.Text = "Dispatch"
        '
        'WPLineGrid
        '
        Me.WPLineGrid.EditorsRepository = Me.PersistentRepository2
        Me.WPLineGrid.Location = New System.Drawing.Point(8, 304)
        Me.WPLineGrid.MainView = Me.GridView2
        Me.WPLineGrid.Name = "WPLineGrid"
        Me.WPLineGrid.Size = New System.Drawing.Size(680, 192)
        Me.WPLineGrid.TabIndex = 132
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CuttingCheckEdit, Me.PunchingCheckEdit, Me.BendingCheckEdit, Me.WeldingCheckEdit, Me.PCProessCheckEdit, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.LineIDTextEdit, Me.MaterialComboBox, Me.RepositoryItemComboBox2, Me.PartCodeTextEdit, Me.PartCodeComboBox, Me.PartCodeLookUpEdit, Me.MaterialLookUpEdit, Me.WidthTextEdit, Me.LengthTextEdit, Me.TotAreaTextEdit, Me.PCPriceTextEdit, Me.ColorLookUpEdit, Me.DescriptionMemoExEdit, Me.PCProcessCheckEdit, Me.WeldingItemCheckEdit, Me.BendingItemCheckEdit, Me.PunchingItemCheckEdit, Me.CuttingItemCheckEdit, Me.PpressCheckEdit, Me.PowerPressItemCheckEdit, Me.ThickCalcEdit})
        '
        'CuttingCheckEdit
        '
        Me.CuttingCheckEdit.Name = "CuttingCheckEdit"
        Me.CuttingCheckEdit.Properties.AllowFocused = False
        Me.CuttingCheckEdit.Properties.AutoHeight = False
        Me.CuttingCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CuttingCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.CuttingCheckEdit.Properties.ReadOnly = True
        Me.CuttingCheckEdit.Properties.ValueChecked = "1"
        Me.CuttingCheckEdit.Properties.ValueUnchecked = "0"
        '
        'PunchingCheckEdit
        '
        Me.PunchingCheckEdit.Name = "PunchingCheckEdit"
        Me.PunchingCheckEdit.Properties.AllowFocused = False
        Me.PunchingCheckEdit.Properties.AutoHeight = False
        Me.PunchingCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PunchingCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.PunchingCheckEdit.Properties.ReadOnly = True
        Me.PunchingCheckEdit.Properties.ValueChecked = "1"
        Me.PunchingCheckEdit.Properties.ValueUnchecked = "0"
        '
        'BendingCheckEdit
        '
        Me.BendingCheckEdit.Name = "BendingCheckEdit"
        Me.BendingCheckEdit.Properties.AllowFocused = False
        Me.BendingCheckEdit.Properties.AutoHeight = False
        Me.BendingCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BendingCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.BendingCheckEdit.Properties.ReadOnly = True
        Me.BendingCheckEdit.Properties.ValueChecked = "1"
        Me.BendingCheckEdit.Properties.ValueUnchecked = "0"
        '
        'WeldingCheckEdit
        '
        Me.WeldingCheckEdit.Name = "WeldingCheckEdit"
        Me.WeldingCheckEdit.Properties.AllowFocused = False
        Me.WeldingCheckEdit.Properties.AutoHeight = False
        Me.WeldingCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WeldingCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.WeldingCheckEdit.Properties.ReadOnly = True
        Me.WeldingCheckEdit.Properties.ValueChecked = "1"
        Me.WeldingCheckEdit.Properties.ValueUnchecked = "0"
        '
        'PCProessCheckEdit
        '
        Me.PCProessCheckEdit.Name = "PCProessCheckEdit"
        Me.PCProessCheckEdit.Properties.AllowFocused = False
        Me.PCProessCheckEdit.Properties.AutoHeight = False
        Me.PCProessCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PCProessCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.PCProessCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PCProessCheckEdit.Properties.ReadOnly = True
        Me.PCProessCheckEdit.Properties.ValueChecked = "1"
        Me.PCProessCheckEdit.Properties.ValueUnchecked = "0"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'LineIDTextEdit
        '
        Me.LineIDTextEdit.Name = "LineIDTextEdit"
        Me.LineIDTextEdit.Properties.AllowFocused = False
        Me.LineIDTextEdit.Properties.AutoHeight = False
        Me.LineIDTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LineIDTextEdit.Properties.MaxLength = 1
        '
        'MaterialComboBox
        '
        Me.MaterialComboBox.Name = "MaterialComboBox"
        Me.MaterialComboBox.Properties.AllowFocused = False
        Me.MaterialComboBox.Properties.AutoHeight = False
        Me.MaterialComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.MaterialComboBox.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialComboBox.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MaterialComboBox.Properties.UseCtrlScroll = True
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.Properties.AllowFocused = False
        Me.RepositoryItemComboBox2.Properties.AutoHeight = False
        Me.RepositoryItemComboBox2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemComboBox2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemComboBox2.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemComboBox2.Properties.UseCtrlScroll = True
        '
        'PartCodeTextEdit
        '
        Me.PartCodeTextEdit.Name = "PartCodeTextEdit"
        Me.PartCodeTextEdit.Properties.AllowFocused = False
        Me.PartCodeTextEdit.Properties.AutoHeight = False
        Me.PartCodeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'PartCodeComboBox
        '
        Me.PartCodeComboBox.Name = "PartCodeComboBox"
        Me.PartCodeComboBox.Properties.AllowFocused = False
        Me.PartCodeComboBox.Properties.AutoHeight = False
        Me.PartCodeComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PartCodeComboBox.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PartCodeComboBox.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PartCodeComboBox.Properties.UseCtrlScroll = True
        '
        'PartCodeLookUpEdit
        '
        Me.PartCodeLookUpEdit.Name = "PartCodeLookUpEdit"
        Me.PartCodeLookUpEdit.Properties.AllowFocused = False
        Me.PartCodeLookUpEdit.Properties.AutoHeight = False
        Me.PartCodeLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PartCodeLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PartCodeLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PartCodeLookUpEdit.Properties.NullString = ""
        '
        'MaterialLookUpEdit
        '
        Me.MaterialLookUpEdit.Name = "MaterialLookUpEdit"
        Me.MaterialLookUpEdit.Properties.AllowFocused = False
        Me.MaterialLookUpEdit.Properties.AutoHeight = False
        Me.MaterialLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.MaterialLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MaterialLookUpEdit.Properties.NullString = ""
        '
        'WidthTextEdit
        '
        Me.WidthTextEdit.Name = "WidthTextEdit"
        Me.WidthTextEdit.Properties.AllowFocused = False
        Me.WidthTextEdit.Properties.AutoHeight = False
        Me.WidthTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WidthTextEdit.Properties.Format = CType(resources.GetObject("WidthTextEdit.Properties.Format"), System.IFormatProvider)
        '
        'LengthTextEdit
        '
        Me.LengthTextEdit.Name = "LengthTextEdit"
        Me.LengthTextEdit.Properties.AllowFocused = False
        Me.LengthTextEdit.Properties.AutoHeight = False
        Me.LengthTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LengthTextEdit.Properties.Format = CType(resources.GetObject("LengthTextEdit.Properties.Format"), System.IFormatProvider)
        '
        'TotAreaTextEdit
        '
        Me.TotAreaTextEdit.Name = "TotAreaTextEdit"
        Me.TotAreaTextEdit.Properties.AllowFocused = False
        Me.TotAreaTextEdit.Properties.AutoHeight = False
        Me.TotAreaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TotAreaTextEdit.Properties.Enabled = False
        Me.TotAreaTextEdit.Properties.Format = CType(resources.GetObject("TotAreaTextEdit.Properties.Format"), System.IFormatProvider)
        '
        'PCPriceTextEdit
        '
        Me.PCPriceTextEdit.Name = "PCPriceTextEdit"
        Me.PCPriceTextEdit.Properties.AllowFocused = False
        Me.PCPriceTextEdit.Properties.AutoHeight = False
        Me.PCPriceTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PCPriceTextEdit.Properties.Enabled = False
        Me.PCPriceTextEdit.Properties.Format = CType(resources.GetObject("PCPriceTextEdit.Properties.Format"), System.IFormatProvider)
        '
        'ColorLookUpEdit
        '
        Me.ColorLookUpEdit.Name = "ColorLookUpEdit"
        Me.ColorLookUpEdit.Properties.AllowFocused = False
        Me.ColorLookUpEdit.Properties.AutoHeight = False
        Me.ColorLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ColorLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ColorLookUpEdit.Properties.NullString = ""
        '
        'DescriptionMemoExEdit
        '
        Me.DescriptionMemoExEdit.Name = "DescriptionMemoExEdit"
        Me.DescriptionMemoExEdit.Properties.AllowFocused = False
        Me.DescriptionMemoExEdit.Properties.AutoHeight = False
        Me.DescriptionMemoExEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DescriptionMemoExEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DescriptionMemoExEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        '
        'PCProcessCheckEdit
        '
        Me.PCProcessCheckEdit.Name = "PCProcessCheckEdit"
        Me.PCProcessCheckEdit.Properties.AllowFocused = False
        Me.PCProcessCheckEdit.Properties.AutoHeight = False
        Me.PCProcessCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PCProcessCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.PCProcessCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PCProcessCheckEdit.Properties.ValueChecked = "1"
        Me.PCProcessCheckEdit.Properties.ValueUnchecked = "0"
        '
        'WeldingItemCheckEdit
        '
        Me.WeldingItemCheckEdit.Name = "WeldingItemCheckEdit"
        Me.WeldingItemCheckEdit.Properties.AllowFocused = False
        Me.WeldingItemCheckEdit.Properties.AutoHeight = False
        Me.WeldingItemCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WeldingItemCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.WeldingItemCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.WeldingItemCheckEdit.Properties.ValueChecked = "1"
        Me.WeldingItemCheckEdit.Properties.ValueUnchecked = "0"
        '
        'BendingItemCheckEdit
        '
        Me.BendingItemCheckEdit.Name = "BendingItemCheckEdit"
        Me.BendingItemCheckEdit.Properties.AllowFocused = False
        Me.BendingItemCheckEdit.Properties.AutoHeight = False
        Me.BendingItemCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BendingItemCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.BendingItemCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.BendingItemCheckEdit.Properties.ValueChecked = "1"
        Me.BendingItemCheckEdit.Properties.ValueUnchecked = "0"
        '
        'PunchingItemCheckEdit
        '
        Me.PunchingItemCheckEdit.Name = "PunchingItemCheckEdit"
        Me.PunchingItemCheckEdit.Properties.AllowFocused = False
        Me.PunchingItemCheckEdit.Properties.AutoHeight = False
        Me.PunchingItemCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PunchingItemCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.PunchingItemCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PunchingItemCheckEdit.Properties.ValueChecked = "1"
        Me.PunchingItemCheckEdit.Properties.ValueUnchecked = "0"
        '
        'CuttingItemCheckEdit
        '
        Me.CuttingItemCheckEdit.Name = "CuttingItemCheckEdit"
        Me.CuttingItemCheckEdit.Properties.AllowFocused = False
        Me.CuttingItemCheckEdit.Properties.AutoHeight = False
        Me.CuttingItemCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CuttingItemCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.CuttingItemCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CuttingItemCheckEdit.Properties.ValueChecked = "1"
        Me.CuttingItemCheckEdit.Properties.ValueUnchecked = "0"
        '
        'PpressCheckEdit
        '
        Me.PpressCheckEdit.Name = "PpressCheckEdit"
        Me.PpressCheckEdit.Properties.AllowFocused = False
        Me.PpressCheckEdit.Properties.AutoHeight = False
        Me.PpressCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PpressCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.PpressCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PpressCheckEdit.Properties.ValueChecked = "1"
        Me.PpressCheckEdit.Properties.ValueUnchecked = "0"
        '
        'PowerPressItemCheckEdit
        '
        Me.PowerPressItemCheckEdit.Name = "PowerPressItemCheckEdit"
        Me.PowerPressItemCheckEdit.Properties.AllowFocused = False
        Me.PowerPressItemCheckEdit.Properties.AutoHeight = False
        Me.PowerPressItemCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PowerPressItemCheckEdit.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        Me.PowerPressItemCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PowerPressItemCheckEdit.Properties.ValueChecked = "1"
        Me.PowerPressItemCheckEdit.Properties.ValueUnchecked = "0"
        '
        'ThickCalcEdit
        '
        Me.ThickCalcEdit.Name = "ThickCalcEdit"
        Me.ThickCalcEdit.Properties.AllowFocused = False
        Me.ThickCalcEdit.Properties.AutoHeight = False
        Me.ThickCalcEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ThickCalcEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ThickCalcEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        '
        'GridView2
        '
        Me.GridView2.BehaviorOptions = CType(((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn4, Me.GridColumn8, Me.GridColumn16, Me.GridColumn9, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn6, Me.GridColumn3, Me.GridColumn2, Me.GridColumn1, Me.GridColumn5, Me.GridColumn17, Me.GridColumn10})
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        Me.GridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Part code"
        Me.GridColumn7.ColumnEdit = Me.PartCodeLookUpEdit
        Me.GridColumn7.FieldName = "PartCode_ID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Material"
        Me.GridColumn4.ColumnEdit = Me.MaterialLookUpEdit
        Me.GridColumn4.FieldName = "Material_ID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 70
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Qty"
        Me.GridColumn8.FieldName = "Qty"
        Me.GridColumn8.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 45
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Description"
        Me.GridColumn16.ColumnEdit = Me.DescriptionMemoExEdit
        Me.GridColumn16.FieldName = "Description"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.VisibleIndex = 3
        Me.GridColumn16.Width = 100
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Thick"
        Me.GridColumn9.ColumnEdit = Me.ThickCalcEdit
        Me.GridColumn9.FieldName = "Thick"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 60
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Width"
        Me.GridColumn11.ColumnEdit = Me.WidthTextEdit
        Me.GridColumn11.FieldName = "Width"
        Me.GridColumn11.FormatType = DevExpress.XtraGrid.Columns.FormatTypeEnum.Numeric
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.VisibleIndex = 5
        Me.GridColumn11.Width = 60
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Length"
        Me.GridColumn12.ColumnEdit = Me.LengthTextEdit
        Me.GridColumn12.FieldName = "Length"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.VisibleIndex = 6
        Me.GridColumn12.Width = 60
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Tot. Area (m2)"
        Me.GridColumn13.ColumnEdit = Me.TotAreaTextEdit
        Me.GridColumn13.FieldName = "TotalArea"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.VisibleIndex = 7
        Me.GridColumn13.Width = 100
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "P.C.Price"
        Me.GridColumn14.ColumnEdit = Me.PCPriceTextEdit
        Me.GridColumn14.FieldName = "PCPrice"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.VisibleIndex = 8
        Me.GridColumn14.Width = 80
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Color"
        Me.GridColumn15.ColumnEdit = Me.ColorLookUpEdit
        Me.GridColumn15.FieldName = "Color_ID"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.VisibleIndex = 9
        Me.GridColumn15.Width = 100
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Cutting"
        Me.GridColumn6.ColumnEdit = Me.CuttingItemCheckEdit
        Me.GridColumn6.FieldName = "Cutting"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 10
        Me.GridColumn6.Width = 60
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Punching"
        Me.GridColumn3.ColumnEdit = Me.PunchingItemCheckEdit
        Me.GridColumn3.FieldName = "Punching"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 11
        Me.GridColumn3.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Bending"
        Me.GridColumn2.ColumnEdit = Me.BendingItemCheckEdit
        Me.GridColumn2.FieldName = "Bending"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 12
        Me.GridColumn2.Width = 80
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Power Press"
        Me.GridColumn1.ColumnEdit = Me.PowerPressItemCheckEdit
        Me.GridColumn1.FieldName = "PowerPress"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 13
        Me.GridColumn1.Width = 90
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Welding"
        Me.GridColumn5.ColumnEdit = Me.WeldingItemCheckEdit
        Me.GridColumn5.FieldName = "Welding"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.VisibleIndex = 14
        Me.GridColumn5.Width = 80
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "P.C. Process"
        Me.GridColumn17.ColumnEdit = Me.PCProcessCheckEdit
        Me.GridColumn17.FieldName = "PCProcess"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.VisibleIndex = 15
        Me.GridColumn17.Width = 90
        '
        'GridColumn10
        '
        Me.GridColumn10.ColumnEdit = Me.LineIDTextEdit
        Me.GridColumn10.FieldName = "WPLine_ID"
        Me.GridColumn10.MinWidth = 10
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn10.Width = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(328, 504)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 133
        Me.btnRefresh.Text = "Refresh"
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Delete})
        '
        'Delete
        '
        Me.Delete.Index = 0
        Me.Delete.Text = "Delete"
        '
        'btnPricing
        '
        Me.btnPricing.AutoSize = False
        Me.btnPricing.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPricing.Image = Nothing
        Me.btnPricing.Location = New System.Drawing.Point(248, 504)
        Me.btnPricing.Name = "btnPricing"
        Me.btnPricing.Size = New System.Drawing.Size(72, 32)
        Me.btnPricing.TabIndex = 134
        Me.btnPricing.Text = "Print Pricing"
        '
        'WorkPlanForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(696, 541)
        Me.Controls.Add(Me.btnPricing)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.WPLineGrid)
        Me.Controls.Add(Me.DispatchBtn)
        Me.Controls.Add(Me.DelWPLineBtn)
        Me.Controls.Add(Me.EditWPLineBtn)
        Me.Controls.Add(Me.NewWPLineBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "WorkPlanForm"
        Me.Text = "Work Plan"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BoxTypeTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyTypeCmd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActAssemblyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstAssemblyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActMetalProcessDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstMetalProcessDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActPowderCoatDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstPowderCoatDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawNoCmd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPlanNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WOCmd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActCompletionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstCompletionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WPLineGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PunchingCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BendingCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeldingCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCProessCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineIDTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LengthTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotAreaTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCPriceTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCProcessCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeldingItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BendingItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PunchingItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PpressCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerPressItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThickCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Codes for Form load"
    Private Sub WorkPlanForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        LoadWorkOrderNo()
        LoadDrawingNo()
        LoadKeyType()
        LoadCombo()

        LoadPartCode(1)
        LoadMaterial(1)
        LoadColor(1)

        Select Case UCase(FormStatus)
            Case "NEW"
                Me.Text = "New Work Plan"
                InitializeForm()
                SaveBtn.Enabled = True
                NewWPLineBtn.Enabled = True
                EditWPLineBtn.Enabled = True
                DelWPLineBtn.Enabled = True
                DispatchBtn.Enabled = False
            Case "EDIT"
                Me.Text = "Edit Work Plan"
                With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetWorkPlanHeader(dsHeaderLoad, WP_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                SaveBtn.Enabled = True
                NewWPLineBtn.Enabled = True
                'EditWPLineBtn.Enabled = True
                DelWPLineBtn.Enabled = True
                DispatchBtn.Enabled = True
                LoadWorkPlanLineList(WP_ID)
            Case "VIEW"
                LoadWorkPlanLineList(WP_ID)
                Me.Text = "View Work Plan"
                With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetWorkPlanHeader(dsHeaderLoad, WP_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                NewWPLineBtn.Enabled = False
                EditWPLineBtn.Enabled = True
                EditWPLineBtn.Text = "View"
                DelWPLineBtn.Enabled = False
                SaveBtn.Enabled = False
                DispatchBtn.Enabled = False
                GridView2.ReadOnly = True

            Case "REVISED"
                Me.Text = "Revise Quotation"
                RevisedWorkPlanHeader()
                RevisedWorkPlanLine()
                SetOldWPStatus()
                DispatchBtn.Enabled = True
                SaveBtn.Enabled = True
                NewWPLineBtn.Enabled = True
                EditWPLineBtn.Enabled = True
                DelWPLineBtn.Enabled = True
                DispatchBtn.Enabled = True
                'RefreshNavBtn()
                'EnableButtons()
                'CurrentRow = 0
                'If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                'Me.NavdsBox_PositionChanged()
                'End If

                'LoadWorkPlanLineList(WP_ID)
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

        StatusCmb.Properties.LookUpData.KeyValue = "10"
        WorkPlanNoTxt.Text = CreateWorkPlanNo()
        RemarkTxt.Text = ""
        EstPowderCoatDate.DateTime = Date.Today
        EstMetalProcessDate.DateTime = Date.Today
        EstAssemblyDate.DateTime = Date.Today
        EstInspectionDate.DateTime = Date.Today
        EstCompletionDate.DateTime = Date.Today
        ActPowderCoatDate.DateTime = Date.Today
        ActMetalProcessDate.DateTime = Date.Today
        ActAssemblyDate.DateTime = Date.Today
        ActInspectionDate.DateTime = Date.Today
        ActCompletionDate.DateTime = Date.Today

    End Sub

    Private Function CreateWorkPlanNo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("WP")
        End With
        CreateWorkPlanNo = "WP" & Year(Now) & DocumentNo
    End Function


    Private Sub LoadWorkPlanLineList(ByVal pWP_ID As String)
        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
            .WP_ID = WP_ID
            If .GetWPLine_Display(WPds, WP_ID) Then
                WPLineGrid.DataSource = WPds.Tables(0).DefaultView
                If WPds.Tables(0).Rows.Count() = 0 Then
                    DelWPLineBtn.Enabled = False
                    EditWPLineBtn.Enabled = False
                End If
                If WPds.Tables(0).Rows.Count() > 0 Then
                    DelWPLineBtn.Enabled = True
                    EditWPLineBtn.Enabled = True
                End If
            End If
        End With

    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "WPLineID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Product", System.Type.GetType("System.String"), True)
        AddColumn(data, "Material", System.Type.GetType("System.String"), True)
        AddColumn(data, "Color", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

#End Region

#Region " Codes for Other Events"
    Private Sub WPLineGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                '                Dim Status As Integer = dr(4)

                '                Select Case (Status)
                '                   Case "10"
                '              RevisedBtn.Enabled = False
                '             EditBtn.Text = "Edit"
                '                Case "50"
                '           RevisedBtn.Enabled = True
                '          EditBtn.Text = "View"
                '         End Select
            End If
        End If

    End Sub
#End Region

#Region "Save"
    Private Function SaveWorkPlan(Optional ByVal bktype As Integer = 0) As Boolean
        Dim bkFlag As Boolean = False

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic

                .WP_No = WP_No
                .WO_ID = WO_ID
                .Status = Status
                .Box = Box
                .Key_Type = Key_Type
                .Height = Height
                .Width = Width
                .Depth = Depth
                .Draw_No = Draw_No
                .Qty = Qty
                .Remark = Remark
                .UserID = UserID
                .ET_PowderCoat = ET_PowderCoat
                .ET_MetalProcess = ET_MetalProcess
                .ET_Assembly = ET_Assembly
                .ET_Inspection = ET_Inspection
                .ET_Completion = ET_Completion
                .Act_PowderCoat = Act_PowderCoat
                .Act_MetalProcess = Act_MetalProcess
                .Act_Assembly = Act_Assembly
                .Act_Inspection = Act_Inspection
                .Act_Completion = Act_Completion
                If UCase(FormStatus) = "REVISED" Then
                    .RevRefWPID = RevRefWPID
                End If

                If WP_ID = Nothing Or WP_ID = 0 Then
                    WP_ID = .SaveWorkPlanHeader()
                    WP_ID = .WP_ID
                    If bktype <> 1 Then
                        MessageBox.Show("Work Plan saved!", "Save Work Plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bkFlag = True
                Else
                    .UpdateWorkPlanHeader(WP_ID)
                    If bktype <> 1 Then
                        MessageBox.Show("Work Plan updated!", "Updates Work Plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bkFlag = True
                End If
            End With
        End If
        Return bkFlag
    End Function
#End Region

#Region " Codes for Revised WorkPlan"
    Private Sub SetOldWPStatus()
        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
            .WP_ID = Old_WP_ID
            .Status = "40"
            If .UpdateWorkPlanHeaderStatus() Then

            End If
        End With
    End Sub

    Private Sub RevisedWorkPlanHeader()
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedWorkPlan As DataSet
        Dim BasedWP_ID As Integer

        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
            If .GetWorkPlanHeader(dsLoad, Old_WP_ID) Then
                'Check if its created from revised quotation or based quotation
                .WP_ID = Old_WP_ID
                If .IsRevisedWP(dsBasedWorkPlan) Then        'if its revised quotation, then load based Quotation no
                    BasedWP_ID = dsBasedWorkPlan.Tables(0).Rows(0)("WP_ID")
                    WP_No = dsBasedWorkPlan.Tables(0).Rows(0)("WP_NO")
                    'COUNT THE NO OF REVISED COPY
                    .RevRefWPID = BasedWP_ID
                    RevisedNo = .CountNoOfRevisedWP()
                    '****
                    RevRefWPID = BasedWP_ID        'Reference to the based ID
                Else
                    WP_No = dsLoad.Tables(0).Rows(0)("WP_NO")  'Get the Existing Quotation No.
                    'COUNT THE NO OF REVISED COPY
                    .RevRefWPID = Old_WP_ID
                    RevisedNo = .CountNoOfRevisedWP()
                    '****
                    RevRefWPID = Old_WP_ID        'Reference
                End If
                '****

                'CHECKING
                .WP_No = WP_No & "R" & RevisedNo          'Appending R...
                If .CheckExistingWPNo() Then         'Record exist
                    RevisedNo = RevisedNo + 1
                    .WP_No = WP_No & "R" & RevisedNo
                    While .CheckExistingWPNo
                        RevisedNo = RevisedNo + 1
                        .WP_No = WP_No & "R" & RevisedNo
                    End While
                End If
                '***

                .Status = "10"
                .UserID = UserID
                If .SaveWPNo() Then
                    WP_ID = .WP_ID    'Get the new quotation_ID
                    'saving
                    .WP_ID = WP_ID
                    .WP_No = dsLoad.Tables(0).Rows(0)("WP_No")
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Box")) Then
                        .Box = dsLoad.Tables(0).Rows(0)("Box")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Key_Type")) Then
                        .Key_Type = dsLoad.Tables(0).Rows(0)("Key_Type")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Height")) Then
                        .Height = dsLoad.Tables(0).Rows(0)("Height")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Width")) Then
                        .Width = dsLoad.Tables(0).Rows(0)("Width")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Depth")) Then
                        .Depth = dsLoad.Tables(0).Rows(0)("Depth")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Draw_No")) Then
                        .Draw_No = dsLoad.Tables(0).Rows(0)("Draw_No")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Qty")) Then
                        .Qty = dsLoad.Tables(0).Rows(0)("Qty")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remark")) Then
                        .Remark = dsLoad.Tables(0).Rows(0)("Remark")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_PowderCoat")) Then
                        .ET_PowderCoat = dsLoad.Tables(0).Rows(0)("ET_PowderCoat")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_MetalProcess")) Then
                        .ET_MetalProcess = dsLoad.Tables(0).Rows(0)("ET_MetalProcess")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_Assembly")) Then
                        .ET_Assembly = dsLoad.Tables(0).Rows(0)("ET_Assembly")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_Inspection")) Then
                        .ET_Inspection = dsLoad.Tables(0).Rows(0)("ET_Inspection")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_Completion")) Then
                        .ET_Completion = dsLoad.Tables(0).Rows(0)("ET_Completion")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_PowderCoat")) Then
                        .Act_PowderCoat = dsLoad.Tables(0).Rows(0)("Act_PowderCoat")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_MetalProcess")) Then
                        .Act_MetalProcess = dsLoad.Tables(0).Rows(0)("Act_MetalProcess")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_Assembly")) Then
                        .Act_Assembly = dsLoad.Tables(0).Rows(0)("Act_Assembly")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_Inspection")) Then
                        .Act_Inspection = dsLoad.Tables(0).Rows(0)("Act_Inspection")
                    End If
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_Completion")) Then
                        .Act_Completion = dsLoad.Tables(0).Rows(0)("Act_Completion")
                    End If


                    If .UpdateWorkPlanHeader(WP_ID) Then
                        Dim dsNew As DataSet
                        If .GetWorkPlanHeader(dsNew, WP_ID) Then
                            SetWindowValue(dsNew)
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With
    End Sub

    Private Sub RevisedWorkPlanLine()
        Dim dsLine As DataSet
        Dim Old_WPLine_ID As Integer

        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
            'Get the old quotation line item
            .WP_ID = Old_WP_ID
            If .GetWPLine(dsLine) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    .WP_ID = WP_ID
                    .UserID = UserID
                    If .SaveWPLineFirstTime() Then
                        WPLine_ID = .WPLine_ID
                    End If
                    '***
                    Old_WPLine_ID = dsLine.Tables(0).Rows(x)("WPLine_ID")
                    .LnWP_ID = dsLine.Tables(0).Rows(x)("WP_ID")
                    .LnCategory_ID = dsLine.Tables(0).Rows(x)("Category_ID")
                    .LnProduct_ID = dsLine.Tables(0).Rows(x)("Product_ID")
                    .LnMaterial_ID = dsLine.Tables(0).Rows(x)("Material_ID")
                    .LnColor_ID = dsLine.Tables(0).Rows(x)("Color_ID")
                    .LnQty = dsLine.Tables(0).Rows(x)("LnQty")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Cutting")) Then
                        .LnCutting = dsLine.Tables(0).Rows(x)("Cutting")
                    End If
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Punching")) Then
                        .LnPunching = dsLine.Tables(0).Rows(x)("Punching")
                    End If
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Bending")) Then
                        .LnBending = dsLine.Tables(0).Rows(x)("Bending")
                    End If
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("PowerPress")) Then
                        .LnPowerPress = dsLine.Tables(0).Rows(x)("PowerPress")
                    End If
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Welding")) Then
                        .LnWelding = dsLine.Tables(0).Rows(x)("Welding")
                    End If
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("PCProcess")) Then
                        .LnPCProcess = dsLine.Tables(0).Rows(x)("PCProcess")
                    End If
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Remark")) Then
                        .LnRemark = dsLine.Tables(0).Rows(x)("Remark")
                    End If
                    .UserID = UserID

                    .UpdateWPLine()
                Next
                dsLine.Dispose()
            End If
        End With
    End Sub

#End Region

#Region "Hard Coded Combo Box"

    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())
        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub LoadCombo()
        Dim StatusData As String() = New String() {"Preparing", "Revised", "Confirmed"}
        Dim StatusID As String() = New String() {"10", "40", "50"}
        SetComboValue(StatusData, StatusCmb, StatusID)
    End Sub

#End Region

#Region "Load Combo Box"
    Private Sub AddListFieldInfoToRepositoryLookUp(ByVal le As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToRepositoryLookUp(le, field, width, alignment, format)
        End With
    End Sub
    Private Sub LoadPartCode(ByVal addflag As Integer)
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.PartCodeBusLogic
            If .GetPartCode(ds) Then
                If Not ds Is Nothing Then
                    Try
                        If addflag = 1 Then
                            AddListFieldInfoToRepositoryLookUp(PartCodeLookUpEdit, "PartCodeName", 400, 0, "c")
                        End If
                        PartCodeLookUpEdit.Properties.LookUpData.KeyField = "PartCode_ID"
                        PartCodeLookUpEdit.Properties.LookUpData.DisplayField = "PartCodeName"
                        PartCodeLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadColor(ByVal addflag As Integer)
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(ds) Then
                If Not ds Is Nothing Then
                    Try
                        If addflag = 1 Then
                            AddListFieldInfoToRepositoryLookUp(ColorLookUpEdit, "Color_Name", 400, 0, "c")
                        End If
                        ColorLookUpEdit.Properties.LookUpData.KeyField = "Color_ID"
                        ColorLookUpEdit.Properties.LookUpData.DisplayField = "Color_Name"
                        ColorLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadMaterial(ByVal addflag As Integer)
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.MaterialBusLogic
            If .GetMaterial(ds) Then
                If Not ds Is Nothing Then
                    Try
                        If addflag = 1 Then
                            AddListFieldInfoToRepositoryLookUp(MaterialLookUpEdit, "Material_Name", 400, 0, "c")
                        End If
                        MaterialLookUpEdit.Properties.LookUpData.KeyField = "Material_ID"
                        MaterialLookUpEdit.Properties.LookUpData.DisplayField = "Material_Name"
                        MaterialLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadWorkOrderNo(Optional ByVal pWO_ID As Integer = 0)
        Dim ds As DataSet
        If GetWOHeader(ds, pWO_ID) Then
            If Not ds Is Nothing Then
                Try
                    'SimpleBinding LookUp adjustment start
                    AddListFieldInfoToLookUp(WOCmd, "WO_No", 400, 0, "c")
                    WOCmd.Properties.LookUpData.KeyField = "WO_ID"
                    WOCmd.Properties.LookUpData.DisplayField = "WO_No"

                    WOCmd.Properties.LookUpData.DataSource = ds.Tables(0)
                    WOCmd.EditValue = "0"
                    'SimpleBinding LookUp adjustment end
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub LoadDrawingNo(Optional ByVal pDrawing_ID As String = "")
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.DrawingNoBusLogic
            If .GetDrawingNo_Type(ds, pDrawing_ID) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(DrawNoCmd, "Drawing_No", 400, 0, "c")
                        DrawNoCmd.Properties.LookUpData.KeyField = "Drawing_ID"
                        DrawNoCmd.Properties.LookUpData.DisplayField = "Drawing_No"

                        DrawNoCmd.Properties.LookUpData.DataSource = ds.Tables(0)
                        DrawNoCmd.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadKeyType(Optional ByVal pKey_ID As String = "")
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.KeyBusLogic
            If .GetKey(ds, pKey_ID) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(KeyTypeCmd, "Key_Name", 400, 0, "c")
                        KeyTypeCmd.Properties.LookUpData.KeyField = "Key_ID"
                        KeyTypeCmd.Properties.LookUpData.DisplayField = "Key_Name"

                        KeyTypeCmd.Properties.LookUpData.DataSource = ds.Tables(0)
                        KeyTypeCmd.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub


#End Region

#Region "Button Events"

    Private Sub NewWPLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWPLineBtn.Click
        'If checkBox1.Checked Then
        'GridView2.ViewOptions = GridView2.ViewOptions Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow
        'Else
        '    GridView2.ViewOptions = gridView2.ViewOptions And (Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow)
        'End If

        'If SaveWorkPlan(1) Then
        'Dim a As MainForm = Me.ParentForm
        'Dim controlToAdd As Control = Nothing
        'Me.Cursor = Cursors.WaitCursor

        'Dim page As Crownwood.Magic.Controls.TabPage
        'controlToAdd = New WorkPlanLineForm("NEW", WP_ID, )
        'page = New Crownwood.Magic.Controls.TabPage("New Work Plan", controlToAdd, ImageList1, 0)

        'page.Selected = True
        'a.MainTabControl.TabPages.Add(page)
        'Me.Cursor = Cursors.Default
        'End If
    End Sub

    Private Sub EditWPLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditWPLineBtn.Click
        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)
            Dim WPLine_ID As Integer = dr("WPLine_ID")

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            If UCase(FormStatus) = "VIEW" Then       'Confirmed. View only
                controlToAdd = New WorkPlanLineForm("VIEW", WP_ID, WPLine_ID)
                page = New Crownwood.Magic.Controls.TabPage("View Work Plan Line", controlToAdd, ImageList1, 0)
            Else
                controlToAdd = New WorkPlanLineForm("EDIT", WP_ID, WPLine_ID)
                page = New Crownwood.Magic.Controls.TabPage("Edit Work Plan Line", controlToAdd, ImageList1, 0)
            End If

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DelWPLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelWPLineBtn.Click
        'If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
        'Dim Row As Integer = GridView2.GetSelectedRows(0)
        'Dim dr As DataRow
        'dr = GridView2.GetDataRow(Row)
        'Dim WPLine_ID As Integer = dr(0)
        'Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this Work Plan Line?", "Work Plan Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If Result = DialogResult.Yes Then
        'With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
        'If .DeleteWorkPlanLine(WPLine_ID) Then
        'MessageBox.Show("Work Plan Line Deleted.", "Work Plan Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        'End With
        'End If
        'LoadWorkPlanLineList(WP_ID)
        'End If
        Delete_Click(sender, e)

    End Sub

    Private Sub DispatchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchBtn.Click
        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
            .WP_ID = WP_ID
            .Status = "50"      'Confirm status
            If .UpdateWorkPlanHeaderStatus() Then
                MessageBox.Show("Status updated.", "Work Plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                StatusCmb.Properties.LookUpData.KeyValue = "50"
            End If
            Dim b As MainForm = Me.ParentForm ' page.Control.Name()
            For i As Integer = 0 To b.MainTabControl.TabPages.Count - 1
                If b.MainTabControl.TabPages.Item(i).Control.Name() = "WorkPlanListForm" Then
                    Dim c As WorkPlanListForm = b.MainTabControl.TabPages.Item(i).Control
                    c.LoadWorkPlanList()
                    Exit For
                End If
            Next
        End With
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveWorkPlan()
        SaveWorkPlanLine()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadPartCode(0)
        LoadMaterial(0)
        LoadColor(0)

        LoadWorkPlanLineList(WP_ID)
    End Sub


#End Region

#Region "Get/Set Window Value"

    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        WorkPlanNoTxt.Text = dsLoad.Tables(0).Rows(0)("WP_NO")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Draw_No")) Then
            DrawNoCmd.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Draw_No")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("WO_ID")) Then
            WOCmd.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("WO_ID")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Key_Type")) Then
            KeyTypeCmd.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Key_Type")
        End If
        StatusCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Status")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Box")) Then
            BoxTypeTxt.Text = dsLoad.Tables(0).Rows(0)("Box")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Qty")) Then
            QtyTxt.Text = dsLoad.Tables(0).Rows(0)("Qty")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Height")) Then
            HeightTxt.Text = dsLoad.Tables(0).Rows(0)("Height")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Width")) Then
            WidthTxt.Text = dsLoad.Tables(0).Rows(0)("Width")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Depth")) Then
            DepthTxt.Text = dsLoad.Tables(0).Rows(0)("Depth")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remark")) Then
            RemarkTxt.Text = dsLoad.Tables(0).Rows(0)("Remark")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_PowderCoat")) Then
            EstPowderCoatDate.DateTime = dsLoad.Tables(0).Rows(0)("ET_PowderCoat")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_MetalProcess")) Then
            EstMetalProcessDate.DateTime = dsLoad.Tables(0).Rows(0)("ET_MetalProcess")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_Assembly")) Then
            EstAssemblyDate.DateTime = dsLoad.Tables(0).Rows(0)("ET_Assembly")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_Inspection")) Then
            EstInspectionDate.DateTime = dsLoad.Tables(0).Rows(0)("ET_Inspection")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("ET_Completion")) Then
            EstCompletionDate.DateTime = dsLoad.Tables(0).Rows(0)("ET_Completion")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_PowderCoat")) Then
            ActPowderCoatDate.DateTime = dsLoad.Tables(0).Rows(0)("Act_PowderCoat")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_MetalProcess")) Then
            ActMetalProcessDate.DateTime = dsLoad.Tables(0).Rows(0)("Act_MetalProcess")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_Assembly")) Then
            ActAssemblyDate.DateTime = dsLoad.Tables(0).Rows(0)("Act_Assembly")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_Inspection")) Then
            ActInspectionDate.DateTime = dsLoad.Tables(0).Rows(0)("Act_Inspection")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Act_Completion")) Then
            ActCompletionDate.DateTime = dsLoad.Tables(0).Rows(0)("Act_Completion")
        End If

    End Sub

    Private Sub GetWindowsValue()

        WP_No = WorkPlanNoTxt.Text
        WO_ID = WOCmd.Properties.LookUpData.KeyValue
        Status = StatusCmb.Properties.LookUpData.KeyValue
        Box = BoxTypeTxt.Text
        Key_Type = KeyTypeCmd.Properties.LookUpData.KeyValue
        Height = HeightTxt.Text
        Width = WidthTxt.Text
        Depth = DepthTxt.Text
        Draw_No = DrawNoCmd.Properties.LookUpData.KeyValue
        Qty = QtyTxt.Text
        Remark = RemarkTxt.Text
        ET_PowderCoat = EstPowderCoatDate.Text
        ET_MetalProcess = EstMetalProcessDate.Text
        ET_Assembly = EstAssemblyDate.Text
        ET_Inspection = EstInspectionDate.Text
        ET_Completion = EstCompletionDate.Text
        Act_PowderCoat = ActPowderCoatDate.Text
        Act_MetalProcess = ActMetalProcessDate.Text
        Act_Assembly = ActAssemblyDate.Text
        Act_Inspection = ActInspectionDate.Text
        Act_Completion = ActCompletionDate.Text

    End Sub


    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

#Region "Utilities"
    ' May be should put the following functions in the common
    Private Function GetWOHeader(ByRef ds As DataSet, Optional ByVal pWO_ID As Integer = 0) As Boolean
        With New DataAccess.DAccess.Access
            Dim SQLStr As String

            If pWO_ID > 0 Then
                SQLStr = "SELECT * FROM WorkOrderHeader where WO_ID = " & Integer.Parse(pWO_ID)
            Else
                SQLStr = "SELECT * FROM WorkOrderHeader "
            End If

            If .GetDataSet(ds, SQLStr) Then
                Return True
            End If
        End With
    End Function


    Private Function GetMaterial(ByVal pMaterial_ID As String) As String
        Dim ds As DataSet
        Dim SQLstr As String = "SELECT * FROM Material WHERE Material_ID = " & pMaterial_ID

        With New DataAccess.DAccess.Access
            If .GetDataSet(ds, SQLstr) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    GetMaterial = ds.Tables(0).Rows(0)("Material_Name")
                End If
            End If
        End With
        ds.Dispose()
    End Function

    Private Function GetColor(ByVal pColor_ID As String) As String
        Dim ds As DataSet
        Dim SQLstr As String = "SELECT * FROM Color WHERE Color_ID = " & pColor_ID

        With New DataAccess.DAccess.Access
            If .GetDataSet(ds, SQLstr) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    GetColor = ds.Tables(0).Rows(0)("Color_Name")
                End If
            End If
        End With
        ds.Dispose()
    End Function

    Private Function GetProduct(ByVal pProduct_ID As String) As String
        Dim ds As DataSet
        Dim SQLstr As String = "SELECT * FROM Product WHERE Product_ID = " & pProduct_ID

        With New DataAccess.DAccess.Access
            If .GetDataSet(ds, SQLstr) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    GetProduct = ds.Tables(0).Rows(0)("Name")
                End If
            End If
        End With
        ds.Dispose()
    End Function

#End Region

#Region "Validation"
    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If WP_No = "" Then
            ErrorMessage = ErrorMessage & " Work Plan No" & Chr(13)
            DataOK_flag = False
        End If

        If WO_ID = 0 Then
            ErrorMessage = ErrorMessage & " Work Order Number" & Chr(13)
            DataOK_flag = False
        End If

        If Qty = "" Then
            ErrorMessage = ErrorMessage & " Qty" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        Else
            With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
                If WP_ID <> Nothing And WP_ID <> 0 Then
                    If .RecordExists(WP_No, WP_ID) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                Else
                    If .RecordExists(WP_No, Nothing) Then
                        MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataOK_flag = False
                    End If
                End If

            End With
        End If

        Return DataOK_flag

    End Function
#End Region

    Private Sub SaveWorkPlanLine()

        'If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then

        GridView2.CloseEditor()
        GridView2.UpdateCurrentRow()
        If Not WPds Is Nothing Then
            If WPds.Tables(0).Rows.Count > 0 Then
                With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
                    For i As Integer = 0 To WPds.Tables(0).Rows.Count - 1
                        'Dim Row As Integer = GridView2.GetSelectedRows(0)
                        'Dim dr As DataRow
                        'dr = GridView2.GetDataRow(Row)

                        'Dim tmpWPLine_ID As String = WPds.Tables(0).Rows(e.FocusedRowHandle)("WPLine_ID").ToString
                        'If tmpWPLine_ID Is Nothing Or tmpWPLine_ID = "" Then

                        .WP_ID = WP_ID
                        If Not IsDBNull(WPds.Tables(0).Rows(i)("WPLine_ID")) Then
                            .WPLine_ID = WPds.Tables(0).Rows(i)("WPLine_ID")
                        End If
                        .LnCategory_ID = 0
                        .LnProduct_ID = 0
                        If IsDBNull(WPds.Tables(0).Rows(i)("Description")) Then
                            .LnDescription = "PLATE"
                        Else
                            .LnDescription = Replace(WPds.Tables(0).Rows(i)("Description").ToString(), "'", "''")
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Material_ID")) Then
                            .LnMaterial_ID = 0
                        Else
                            .LnMaterial_ID = WPds.Tables(0).Rows(i)("Material_ID").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("PartCode_ID")) Then
                            .LnPartCode_ID = 0
                        Else
                            .LnPartCode_ID = WPds.Tables(0).Rows(i)("PartCode_ID").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Color_ID")) Then
                            .LnColor_ID = 0
                        Else
                            .LnColor_ID = WPds.Tables(0).Rows(i)("Color_ID").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Qty")) Then
                            .LnQty = 0
                        Else
                            .LnQty = WPds.Tables(0).Rows(i)("Qty").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Bending")) Then
                            .LnBending = 0
                        Else
                            .LnBending = WPds.Tables(0).Rows(i)("Bending").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Cutting")) Then
                            .LnCutting = 0
                        Else
                            .LnCutting = WPds.Tables(0).Rows(i)("Cutting").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Welding")) Then
                            .LnWelding = 0
                        Else
                            .LnWelding = WPds.Tables(0).Rows(i)("Welding").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("PowerPress")) Then
                            .LnPowerPress = 0
                        Else
                            .LnPowerPress = WPds.Tables(0).Rows(i)("PowerPress").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("PCProcess")) Then
                            .LnPCProcess = 0
                        Else
                            .LnPCProcess = WPds.Tables(0).Rows(i)("PCProcess").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Punching")) Then
                            .LnPunching = 0
                        Else
                            .LnPunching = WPds.Tables(0).Rows(i)("Punching").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Width")) Then
                            .LnWidth = 0
                        Else
                            .LnWidth = WPds.Tables(0).Rows(i)("Width").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Length")) Then
                            .LnLength = 0
                        Else
                            .LnLength = WPds.Tables(0).Rows(i)("Length").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("Thick")) Then
                            .LnThick = 0
                        Else
                            .LnThick = WPds.Tables(0).Rows(i)("Thick").ToString()
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("PCPrice")) Then
                            .LnPCPrice = 0
                        Else
                            .LnPCPrice = Decimal.Parse(WPds.Tables(0).Rows(i)("PCPrice"))
                        End If
                        If IsDBNull(WPds.Tables(0).Rows(i)("TotalArea")) Then
                            .LnTotArea = 0
                        Else
                            .LnTotArea = Decimal.Parse(WPds.Tables(0).Rows(i)("TotalArea"))
                        End If
                        .UserID = Common.CommonConn.Config.USERID

                        If IsDBNull(WPds.Tables(0).Rows(i)("WPLine_ID")) Then
                            .SaveWPLine()
                            'MessageBox.Show("Work Plan Line saved!", "Updates Work Plan Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            .UpdateWPLine()
                        End If
                        'LoadWorkPlanLineList(WP_ID)
                        'Else
                        'WPLine_ID = Convert.ToInt32(WPds.Tables(0).Rows(e.FocusedRowHandle)("WPLine_ID"))
                        'LoadWorkPlanLineList(WP_ID)
                    Next
                    LoadPartCode(0)
                    LoadMaterial(0)
                    LoadColor(0)

                    'LoadWorkPlanLineList(WP_ID)
                    'MessageBox.Show("Work Plan Line saved!", "Save/Updates Work Plan Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With
            End If
        End If
        LoadWorkPlanLineList(WP_ID)
        'End If

    End Sub

    Private Sub ColorLookUpEdit_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles ColorLookUpEdit.CloseUp
        Dim dt As DataTable
        Dim pricerate As Double = 0.0
        'dt = ColorLookUpEdit.Properties.LookUpData.DataSource()
        'MessageBox.Show(dt.Rows(e.Value)("pricerate"))
        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then

            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.GetSelectedRows(0))

            'Calculate totalarea
            If IsDBNull(dr("Width")) Then
                dr("Width") = 0.0
            End If
            If IsDBNull(dr("Length")) Then
                dr("Length") = 0.0
            End If
            dr("TotalArea") = (dr("Width") / 1000) * (dr("Length") / 1000)

            'Get the color pricerate
            With New BusinessRules.SystemBusRules.ColorBusLogic
                pricerate = .GetColorPriceRate(e.Value)
            End With

            'PCPrice = TotalArea * Color Price Rate
            dr("PCPrice") = dr("TotalArea") * pricerate
        End If

    End Sub

    Private Sub CalculatePCPrice()
        'PCPrice = TotalArea * Color Price Rate
        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            Dim dr As DataRow
            Dim pricerate As Double = 0.0

            dr = GridView2.GetDataRow(GridView2.GetSelectedRows(0))
            If Not IsNothing(dr) Then
                If Not IsDBNull(dr("Color_ID")) Then 'And dr("Color_ID") <> 0 Then
                    'Get color price rate
                    With New BusinessRules.SystemBusRules.ColorBusLogic
                        pricerate = .GetColorPriceRate(dr("Color_ID"))
                    End With
                End If
                If IsDBNull(dr("TotalArea")) Then
                    dr("TotalArea") = 0.0
                End If

                'Calculate PC Price
                dr("PCPrice") = dr("TotalArea") * pricerate
            End If
        End If
    End Sub

    Private Sub WidthTextEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WidthTextEdit.ValueChanged
        CalculateTotalArea()
        CalculatePCPrice()
    End Sub

    Private Sub LengthTextEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LengthTextEdit.ValueChanged
        CalculateTotalArea()
        CalculatePCPrice()
    End Sub

    Private Sub CalculateTotalArea()
        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            Dim dr As DataRow

            dr = GridView2.GetDataRow(GridView2.GetSelectedRows(0))
            If Not IsNothing(dr) Then
                If IsDBNull(dr("Width")) Then
                    dr("Width") = 0.0
                End If
                If IsDBNull(dr("Length")) Then
                    dr("Length") = 0.0
                End If
                dr("TotalArea") = (dr("Width") / 1000) * (dr("Length") / 1000)
            End If
        End If
    End Sub

    Private Sub WPLineGrid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles WPLineGrid.MouseUp
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

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If GridView2.RowCount > 0 Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            Dim PartCodeName As String

            dr = GridView2.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim WPLine_ID As Integer = dr("WPLine_ID")
                Dim PartCode As String = dr("PartCode_ID")

                If WPLine_ID > 0 Then
                    With New BusinessRules.SystemBusRules.PartCodeBusLogic
                        Dim ds As DataSet
                        .GetPartCode(ds, PartCode)
                        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                            PartCodeName = ds.Tables(0).Rows(0)("PartCodeName").ToString()
                        Else : PartCodeName = PartCode
                        End If
                    End With
                    Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & PartCodeName, "Delete Part Code", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If Result = DialogResult.Yes Then
                        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
                            .DeleteWorkPlanLine(WPLine_ID.ToString())
                            btnRefresh_Click(sender, e)
                        End With
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub WorkPlanForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Work Plan?", "Work Plan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
    End Sub

    Private Sub btnPricing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPricing.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New WorkPlanPowderCoatPrice(WP_ID)
        page = New Crownwood.Magic.Controls.TabPage("Print Work Plan Powder Coating Price", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

End Class
