Imports System.Data
Imports Crownwood.Magic.Common
Imports Crownwood.Magic.Controls
Imports DevExpress.XtraEditors.Controls

Public Class NewWorkOrderForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pCustomer_ID As Integer = 0, _
                Optional ByVal pOld_Quotation_ID As Integer = 0, Optional ByVal pWO_ID As Integer = 0)
        MyBase.New()
        FormStatus = pStatus
        If Not pCustomer_ID = 0 Then
            Customer_ID = pCustomer_ID
        End If

        If Not pOld_Quotation_ID = 0 Then
            Old_Quotation_ID = pOld_Quotation_ID
        End If

        If Not pWO_ID = 0 Then
            WO_ID = pWO_ID
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
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OCNoLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents custPOTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OCNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Addresstxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents AddressLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents WONoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CompGrid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents UpdateBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents lblNavLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NavLastBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NavFirstBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NavNextBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NavPrevBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProjectCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProjectLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NotesTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents ItemTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents ComplTab As Crownwood.Magic.Controls.TabPage
    Friend WithEvents StatusCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CollectModeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents WODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Edit As System.Windows.Forms.MenuItem
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents AddBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DelProdBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProjectTitleCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UpdateAllBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AllWorkStatusChk As System.Windows.Forms.CheckBox
    Friend WithEvents grpComplDtl As System.Windows.Forms.GroupBox
    Friend WithEvents ComplDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ExComplDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents NoteTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents QtyBalTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents QtyComplTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
    Friend WithEvents WorkStatusChk As System.Windows.Forms.CheckBox
    Friend WithEvents DepthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WidthTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HeightTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DepthLbl As System.Windows.Forms.Label
    Friend WithEvents WidthLbl As System.Windows.Forms.Label
    Friend WithEvents DrawNoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MaterialCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ColorCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents KeyCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BoxDescTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents QtyLbl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents DispatchBtn As System.Windows.Forms.Button
    Friend WithEvents BtnSaveQuo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NewWorkOrderForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProjectTitleCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.CollectModeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.StatusCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ProjectCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ProjectLbl = New System.Windows.Forms.Label
        Me.WONoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Addresstxt = New DevExpress.XtraEditors.TextEdit
        Me.ContLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.CustLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.AddressLbl = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.WODate = New DevExpress.XtraEditors.DateEdit
        Me.OCNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.custPOTxt = New DevExpress.XtraEditors.TextEdit
        Me.PODate = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OCNoLbl = New System.Windows.Forms.Label
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UpdateAllBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AllWorkStatusChk = New System.Windows.Forms.CheckBox
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DelProdBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.TabControl1 = New Crownwood.Magic.Controls.TabControl
        Me.ItemTab = New Crownwood.Magic.Controls.TabPage
        Me.grpBox = New System.Windows.Forms.GroupBox
        Me.WorkStatusChk = New System.Windows.Forms.CheckBox
        Me.DepthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.WidthTxt = New DevExpress.XtraEditors.SpinEdit
        Me.HeightTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.DepthLbl = New System.Windows.Forms.Label
        Me.WidthLbl = New System.Windows.Forms.Label
        Me.DrawNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.MaterialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ColorCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.KeyCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BoxDescTxt = New DevExpress.XtraEditors.TextEdit
        Me.ItemNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.QtyLbl = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComplTab = New Crownwood.Magic.Controls.TabPage
        Me.grpComplDtl = New System.Windows.Forms.GroupBox
        Me.ComplDate = New DevExpress.XtraEditors.DateEdit
        Me.ExComplDate = New DevExpress.XtraEditors.DateEdit
        Me.NoteTxt = New DevExpress.XtraEditors.MemoEdit
        Me.QtyBalTxt = New DevExpress.XtraEditors.SpinEdit
        Me.QtyComplTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CompGrid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.UpdateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.lblNavLocation = New DevExpress.XtraEditors.TextEdit
        Me.NavLastBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavFirstBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavNextBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NavPrevBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.NotesTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Edit = New System.Windows.Forms.MenuItem
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New System.Windows.Forms.Button
        Me.DispatchBtn = New System.Windows.Forms.Button
        Me.BtnSaveQuo = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectModeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WONoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.custPOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ItemTab.SuspendLayout()
        Me.grpBox.SuspendLayout()
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComplTab.SuspendLayout()
        Me.grpComplDtl.SuspendLayout()
        CType(Me.ComplDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExComplDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoteTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyBalTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyComplTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNavLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProjectTitleCmb)
        Me.GroupBox1.Controls.Add(Me.CollectModeCmb)
        Me.GroupBox1.Controls.Add(Me.StatusCmb)
        Me.GroupBox1.Controls.Add(Me.ProjectCmb)
        Me.GroupBox1.Controls.Add(Me.ProjectLbl)
        Me.GroupBox1.Controls.Add(Me.WONoTxt)
        Me.GroupBox1.Controls.Add(Me.Addresstxt)
        Me.GroupBox1.Controls.Add(Me.ContLookup)
        Me.GroupBox1.Controls.Add(Me.CustLookup)
        Me.GroupBox1.Controls.Add(Me.AddressLbl)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Controls.Add(Me.WODate)
        Me.GroupBox1.Controls.Add(Me.OCNoTxt)
        Me.GroupBox1.Controls.Add(Me.custPOTxt)
        Me.GroupBox1.Controls.Add(Me.PODate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OCNoLbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 144)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'ProjectTitleCmb
        '
        Me.ProjectTitleCmb.Location = New System.Drawing.Point(208, 112)
        Me.ProjectTitleCmb.Name = "ProjectTitleCmb"
        Me.ProjectTitleCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectTitleCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectTitleCmb.Properties.NullString = ""
        Me.ProjectTitleCmb.Properties.PopupWidth = 456
        Me.ProjectTitleCmb.Size = New System.Drawing.Size(456, 19)
        Me.ProjectTitleCmb.TabIndex = 61
        '
        'CollectModeCmb
        '
        Me.CollectModeCmb.Location = New System.Drawing.Point(560, 40)
        Me.CollectModeCmb.Name = "CollectModeCmb"
        Me.CollectModeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CollectModeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CollectModeCmb.Properties.NullString = ""
        Me.CollectModeCmb.Size = New System.Drawing.Size(104, 19)
        Me.CollectModeCmb.TabIndex = 54
        '
        'StatusCmb
        '
        Me.StatusCmb.Location = New System.Drawing.Point(560, 64)
        Me.StatusCmb.Name = "StatusCmb"
        Me.StatusCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusCmb.Properties.NullString = ""
        Me.StatusCmb.Size = New System.Drawing.Size(104, 19)
        Me.StatusCmb.TabIndex = 53
        '
        'ProjectCmb
        '
        Me.ProjectCmb.Location = New System.Drawing.Point(120, 112)
        Me.ProjectCmb.Name = "ProjectCmb"
        Me.ProjectCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectCmb.Properties.NullString = ""
        Me.ProjectCmb.Size = New System.Drawing.Size(80, 19)
        Me.ProjectCmb.TabIndex = 50
        '
        'ProjectLbl
        '
        Me.ProjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectLbl.Location = New System.Drawing.Point(16, 120)
        Me.ProjectLbl.Name = "ProjectLbl"
        Me.ProjectLbl.Size = New System.Drawing.Size(56, 16)
        Me.ProjectLbl.TabIndex = 51
        Me.ProjectLbl.Text = "* Project :"
        '
        'WONoTxt
        '
        Me.WONoTxt.Location = New System.Drawing.Point(120, 16)
        Me.WONoTxt.Name = "WONoTxt"
        Me.WONoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WONoTxt.Size = New System.Drawing.Size(128, 19)
        Me.WONoTxt.TabIndex = 49
        '
        'Addresstxt
        '
        Me.Addresstxt.Location = New System.Drawing.Point(368, 88)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Addresstxt.Size = New System.Drawing.Size(296, 19)
        Me.Addresstxt.TabIndex = 48
        '
        'ContLookup
        '
        Me.ContLookup.Location = New System.Drawing.Point(120, 88)
        Me.ContLookup.Name = "ContLookup"
        Me.ContLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContLookup.Properties.NullString = ""
        Me.ContLookup.Properties.PopupWidth = 184
        Me.ContLookup.Size = New System.Drawing.Size(184, 19)
        Me.ContLookup.TabIndex = 44
        '
        'CustLookup
        '
        Me.CustLookup.Location = New System.Drawing.Point(120, 64)
        Me.CustLookup.Name = "CustLookup"
        Me.CustLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustLookup.Properties.NullString = ""
        Me.CustLookup.Properties.PopupWidth = 368
        Me.CustLookup.Size = New System.Drawing.Size(328, 19)
        Me.CustLookup.TabIndex = 43
        '
        'AddressLbl
        '
        Me.AddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLbl.Location = New System.Drawing.Point(312, 96)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(56, 16)
        Me.AddressLbl.TabIndex = 47
        Me.AddressLbl.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "* Contact Person :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(16, 72)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(104, 16)
        Me.CustNameLbl.TabIndex = 45
        Me.CustNameLbl.Text = "* Customer Name :"
        '
        'WODate
        '
        Me.WODate.DateTime = New Date(CType(0, Long))
        Me.WODate.Location = New System.Drawing.Point(560, 16)
        Me.WODate.Name = "WODate"
        Me.WODate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WODate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WODate.Size = New System.Drawing.Size(104, 19)
        Me.WODate.TabIndex = 42
        '
        'OCNoTxt
        '
        Me.OCNoTxt.Location = New System.Drawing.Point(328, 16)
        Me.OCNoTxt.Name = "OCNoTxt"
        Me.OCNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OCNoTxt.Properties.ReadOnly = True
        Me.OCNoTxt.Size = New System.Drawing.Size(120, 19)
        Me.OCNoTxt.TabIndex = 39
        '
        'custPOTxt
        '
        Me.custPOTxt.Location = New System.Drawing.Point(120, 40)
        Me.custPOTxt.Name = "custPOTxt"
        Me.custPOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.custPOTxt.Size = New System.Drawing.Size(128, 19)
        Me.custPOTxt.TabIndex = 38
        '
        'PODate
        '
        Me.PODate.DateTime = New Date(CType(0, Long))
        Me.PODate.Location = New System.Drawing.Point(328, 40)
        Me.PODate.Name = "PODate"
        Me.PODate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PODate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PODate.Size = New System.Drawing.Size(120, 19)
        Me.PODate.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "W. Order  No :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(472, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Collect Mode :"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(264, 46)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 16)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "PO Date :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cust PO :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Status :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(472, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "* Date :"
        '
        'OCNoLbl
        '
        Me.OCNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OCNoLbl.Location = New System.Drawing.Point(264, 24)
        Me.OCNoLbl.Name = "OCNoLbl"
        Me.OCNoLbl.Size = New System.Drawing.Size(64, 16)
        Me.OCNoLbl.TabIndex = 11
        Me.OCNoLbl.Text = "O. C.  No :"
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemTextEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemTextEdit1})
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.Properties.AllowFocused = False
        Me.RepositoryItemComboBox1.Properties.AutoHeight = False
        Me.RepositoryItemComboBox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemComboBox1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemComboBox1.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemComboBox1.Properties.UseCtrlScroll = True
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
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.Properties.AllowFocused = False
        Me.RepositoryItemComboBox3.Properties.AutoHeight = False
        Me.RepositoryItemComboBox3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemComboBox3.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemComboBox3.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemComboBox3.Properties.UseCtrlScroll = True
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit3.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.Properties.AllowFocused = False
        Me.RepositoryItemDateEdit1.Properties.AutoHeight = False
        Me.RepositoryItemDateEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemDateEdit1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RepositoryItemDateEdit1.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.Properties.AllowFocused = False
        Me.RepositoryItemMemoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.Properties.AllowFocused = False
        Me.RepositoryItemCheckEdit1.Properties.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemCheckEdit1.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.Properties.AllowFocused = False
        Me.RepositoryItemCheckEdit2.Properties.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemCheckEdit2.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UpdateAllBtn)
        Me.GroupBox2.Controls.Add(Me.AllWorkStatusChk)
        Me.GroupBox2.Controls.Add(Me.AddBtn)
        Me.GroupBox2.Controls.Add(Me.DelProdBtn)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.CompGrid1)
        Me.GroupBox2.Controls.Add(Me.UpdateBtn)
        Me.GroupBox2.Controls.Add(Me.lblNavLocation)
        Me.GroupBox2.Controls.Add(Me.NavLastBtn)
        Me.GroupBox2.Controls.Add(Me.NavFirstBtn)
        Me.GroupBox2.Controls.Add(Me.NavNextBtn)
        Me.GroupBox2.Controls.Add(Me.NavPrevBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 304)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'UpdateAllBtn
        '
        Me.UpdateAllBtn.AutoSize = False
        Me.UpdateAllBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UpdateAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAllBtn.Image = Nothing
        Me.UpdateAllBtn.Location = New System.Drawing.Point(424, 10)
        Me.UpdateAllBtn.Name = "UpdateAllBtn"
        Me.UpdateAllBtn.Size = New System.Drawing.Size(136, 24)
        Me.UpdateAllBtn.TabIndex = 92
        Me.UpdateAllBtn.Text = "Update All Work Status"
        Me.UpdateAllBtn.Visible = False
        '
        'AllWorkStatusChk
        '
        Me.AllWorkStatusChk.Location = New System.Drawing.Point(568, 16)
        Me.AllWorkStatusChk.Name = "AllWorkStatusChk"
        Me.AllWorkStatusChk.Size = New System.Drawing.Size(104, 16)
        Me.AllWorkStatusChk.TabIndex = 91
        Me.AllWorkStatusChk.Text = "All Work Done"
        Me.AllWorkStatusChk.Visible = False
        '
        'AddBtn
        '
        Me.AddBtn.AutoSize = False
        Me.AddBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBtn.Enabled = False
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Image = Nothing
        Me.AddBtn.Location = New System.Drawing.Point(8, 10)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(72, 24)
        Me.AddBtn.TabIndex = 89
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
        Me.DelProdBtn.TabIndex = 90
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
        Me.TabControl1.Size = New System.Drawing.Size(664, 136)
        Me.TabControl1.TabIndex = 86
        Me.TabControl1.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.ItemTab, Me.ComplTab})
        '
        'ItemTab
        '
        Me.ItemTab.Controls.Add(Me.grpBox)
        Me.ItemTab.Location = New System.Drawing.Point(0, 25)
        Me.ItemTab.Name = "ItemTab"
        Me.ItemTab.Size = New System.Drawing.Size(664, 111)
        Me.ItemTab.TabIndex = 3
        Me.ItemTab.Title = "Box"
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.WorkStatusChk)
        Me.grpBox.Controls.Add(Me.DepthTxt)
        Me.grpBox.Controls.Add(Me.WidthTxt)
        Me.grpBox.Controls.Add(Me.HeightTxt)
        Me.grpBox.Controls.Add(Me.Label16)
        Me.grpBox.Controls.Add(Me.DepthLbl)
        Me.grpBox.Controls.Add(Me.WidthLbl)
        Me.grpBox.Controls.Add(Me.DrawNoCmb)
        Me.grpBox.Controls.Add(Me.MaterialCmb)
        Me.grpBox.Controls.Add(Me.ColorCmb)
        Me.grpBox.Controls.Add(Me.KeyCmb)
        Me.grpBox.Controls.Add(Me.Label17)
        Me.grpBox.Controls.Add(Me.Label12)
        Me.grpBox.Controls.Add(Me.Label10)
        Me.grpBox.Controls.Add(Me.Label6)
        Me.grpBox.Controls.Add(Me.BoxDescTxt)
        Me.grpBox.Controls.Add(Me.ItemNoTxt)
        Me.grpBox.Controls.Add(Me.QtyTxt)
        Me.grpBox.Controls.Add(Me.QtyLbl)
        Me.grpBox.Controls.Add(Me.Label11)
        Me.grpBox.Controls.Add(Me.Label8)
        Me.grpBox.Location = New System.Drawing.Point(6, 2)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(652, 106)
        Me.grpBox.TabIndex = 0
        Me.grpBox.TabStop = False
        '
        'WorkStatusChk
        '
        Me.WorkStatusChk.Enabled = False
        Me.WorkStatusChk.Location = New System.Drawing.Point(294, 80)
        Me.WorkStatusChk.Name = "WorkStatusChk"
        Me.WorkStatusChk.TabIndex = 126
        Me.WorkStatusChk.Text = "Work Done"
        '
        'DepthTxt
        '
        Me.DepthTxt.Location = New System.Drawing.Point(510, 32)
        Me.DepthTxt.Name = "DepthTxt"
        Me.DepthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DepthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DepthTxt.Size = New System.Drawing.Size(72, 19)
        Me.DepthTxt.TabIndex = 122
        Me.DepthTxt.Text = "0"
        '
        'WidthTxt
        '
        Me.WidthTxt.Location = New System.Drawing.Point(294, 32)
        Me.WidthTxt.Name = "WidthTxt"
        Me.WidthTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WidthTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WidthTxt.Size = New System.Drawing.Size(72, 19)
        Me.WidthTxt.TabIndex = 121
        Me.WidthTxt.Text = "0"
        '
        'HeightTxt
        '
        Me.HeightTxt.Location = New System.Drawing.Point(86, 32)
        Me.HeightTxt.Name = "HeightTxt"
        Me.HeightTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.HeightTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HeightTxt.Size = New System.Drawing.Size(72, 19)
        Me.HeightTxt.TabIndex = 120
        Me.HeightTxt.Text = "0"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "* Height :"
        '
        'DepthLbl
        '
        Me.DepthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepthLbl.Location = New System.Drawing.Point(446, 36)
        Me.DepthLbl.Name = "DepthLbl"
        Me.DepthLbl.Size = New System.Drawing.Size(48, 16)
        Me.DepthLbl.TabIndex = 124
        Me.DepthLbl.Text = "* Depth :"
        '
        'WidthLbl
        '
        Me.WidthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthLbl.Location = New System.Drawing.Point(238, 36)
        Me.WidthLbl.Name = "WidthLbl"
        Me.WidthLbl.Size = New System.Drawing.Size(48, 16)
        Me.WidthLbl.TabIndex = 123
        Me.WidthLbl.Text = "* Width :"
        '
        'DrawNoCmb
        '
        Me.DrawNoCmb.Location = New System.Drawing.Point(86, 80)
        Me.DrawNoCmb.Name = "DrawNoCmb"
        Me.DrawNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DrawNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DrawNoCmb.Properties.NullString = ""
        Me.DrawNoCmb.Properties.PopupWidth = 152
        Me.DrawNoCmb.Size = New System.Drawing.Size(136, 19)
        Me.DrawNoCmb.TabIndex = 119
        '
        'MaterialCmb
        '
        Me.MaterialCmb.Location = New System.Drawing.Point(510, 56)
        Me.MaterialCmb.Name = "MaterialCmb"
        Me.MaterialCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MaterialCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialCmb.Properties.NullString = ""
        Me.MaterialCmb.Size = New System.Drawing.Size(136, 19)
        Me.MaterialCmb.TabIndex = 118
        '
        'ColorCmb
        '
        Me.ColorCmb.Location = New System.Drawing.Point(294, 56)
        Me.ColorCmb.Name = "ColorCmb"
        Me.ColorCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ColorCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ColorCmb.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(23))
        Me.ColorCmb.Properties.NullString = ""
        Me.ColorCmb.Size = New System.Drawing.Size(136, 19)
        Me.ColorCmb.TabIndex = 117
        '
        'KeyCmb
        '
        Me.KeyCmb.Location = New System.Drawing.Point(86, 56)
        Me.KeyCmb.Name = "KeyCmb"
        Me.KeyCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.KeyCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.KeyCmb.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(23))
        Me.KeyCmb.Properties.NullString = ""
        Me.KeyCmb.Size = New System.Drawing.Size(136, 19)
        Me.KeyCmb.TabIndex = 116
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 115
        Me.Label17.Text = "* Drawing No :"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(454, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Material :"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(246, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Color :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(14, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Key :"
        '
        'BoxDescTxt
        '
        Me.BoxDescTxt.Location = New System.Drawing.Point(182, 10)
        Me.BoxDescTxt.Name = "BoxDescTxt"
        Me.BoxDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxDescTxt.Size = New System.Drawing.Size(328, 19)
        Me.BoxDescTxt.TabIndex = 111
        '
        'ItemNoTxt
        '
        Me.ItemNoTxt.Location = New System.Drawing.Point(56, 10)
        Me.ItemNoTxt.Name = "ItemNoTxt"
        Me.ItemNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ItemNoTxt.Properties.ReadOnly = True
        Me.ItemNoTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ItemNoTxt.Size = New System.Drawing.Size(32, 19)
        Me.ItemNoTxt.TabIndex = 110
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(582, 10)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(40, 19)
        Me.QtyTxt.TabIndex = 106
        Me.QtyTxt.Text = "0"
        '
        'QtyLbl
        '
        Me.QtyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.Location = New System.Drawing.Point(542, 12)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(40, 16)
        Me.QtyLbl.TabIndex = 109
        Me.QtyLbl.Text = "* Qty :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Item No :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "* Box Desc :"
        '
        'ComplTab
        '
        Me.ComplTab.Controls.Add(Me.grpComplDtl)
        Me.ComplTab.Location = New System.Drawing.Point(0, 25)
        Me.ComplTab.Name = "ComplTab"
        Me.ComplTab.Selected = False
        Me.ComplTab.Size = New System.Drawing.Size(664, 111)
        Me.ComplTab.TabIndex = 4
        Me.ComplTab.Title = "Completion Details"
        Me.ComplTab.Visible = False
        '
        'grpComplDtl
        '
        Me.grpComplDtl.Controls.Add(Me.ComplDate)
        Me.grpComplDtl.Controls.Add(Me.ExComplDate)
        Me.grpComplDtl.Controls.Add(Me.NoteTxt)
        Me.grpComplDtl.Controls.Add(Me.QtyBalTxt)
        Me.grpComplDtl.Controls.Add(Me.QtyComplTxt)
        Me.grpComplDtl.Controls.Add(Me.Label18)
        Me.grpComplDtl.Controls.Add(Me.Label15)
        Me.grpComplDtl.Controls.Add(Me.Label14)
        Me.grpComplDtl.Controls.Add(Me.Label13)
        Me.grpComplDtl.Controls.Add(Me.Label7)
        Me.grpComplDtl.Location = New System.Drawing.Point(6, 2)
        Me.grpComplDtl.Name = "grpComplDtl"
        Me.grpComplDtl.Size = New System.Drawing.Size(652, 106)
        Me.grpComplDtl.TabIndex = 0
        Me.grpComplDtl.TabStop = False
        '
        'ComplDate
        '
        Me.ComplDate.DateTime = New Date(CType(0, Long))
        Me.ComplDate.Enabled = False
        Me.ComplDate.Location = New System.Drawing.Point(136, 56)
        Me.ComplDate.Name = "ComplDate"
        Me.ComplDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ComplDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ComplDate.Properties.Enabled = False
        Me.ComplDate.Size = New System.Drawing.Size(104, 19)
        Me.ComplDate.TabIndex = 21
        '
        'ExComplDate
        '
        Me.ExComplDate.DateTime = New Date(CType(0, Long))
        Me.ExComplDate.Location = New System.Drawing.Point(136, 24)
        Me.ExComplDate.Name = "ExComplDate"
        Me.ExComplDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExComplDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExComplDate.Size = New System.Drawing.Size(104, 19)
        Me.ExComplDate.TabIndex = 20
        '
        'NoteTxt
        '
        Me.NoteTxt.Location = New System.Drawing.Point(440, 24)
        Me.NoteTxt.Name = "NoteTxt"
        Me.NoteTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NoteTxt.Size = New System.Drawing.Size(200, 72)
        Me.NoteTxt.TabIndex = 19
        '
        'QtyBalTxt
        '
        Me.QtyBalTxt.Enabled = False
        Me.QtyBalTxt.Location = New System.Drawing.Point(336, 56)
        Me.QtyBalTxt.Name = "QtyBalTxt"
        Me.QtyBalTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyBalTxt.Properties.Enabled = False
        Me.QtyBalTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyBalTxt.Size = New System.Drawing.Size(56, 19)
        Me.QtyBalTxt.TabIndex = 18
        Me.QtyBalTxt.Text = "0"
        '
        'QtyComplTxt
        '
        Me.QtyComplTxt.Enabled = False
        Me.QtyComplTxt.Location = New System.Drawing.Point(336, 24)
        Me.QtyComplTxt.Name = "QtyComplTxt"
        Me.QtyComplTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyComplTxt.Properties.Enabled = False
        Me.QtyComplTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyComplTxt.Size = New System.Drawing.Size(56, 19)
        Me.QtyComplTxt.TabIndex = 17
        Me.QtyComplTxt.Text = "0"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(400, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Note :"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(248, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Qty Bal :"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Compl'n Date :"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(248, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Qty Completed :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Expected Compl'n Date :"
        '
        'CompGrid1
        '
        Me.CompGrid1.EditorsRepository = Me.PersistentRepository1
        Me.CompGrid1.Enabled = False
        Me.CompGrid1.Location = New System.Drawing.Point(8, 184)
        Me.CompGrid1.MainView = Me.GridView1
        Me.CompGrid1.Name = "CompGrid1"
        Me.CompGrid1.Size = New System.Drawing.Size(664, 112)
        Me.CompGrid1.TabIndex = 85
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
        Me.UpdateBtn.Size = New System.Drawing.Size(64, 24)
        Me.UpdateBtn.TabIndex = 84
        Me.UpdateBtn.Text = "Update"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.Enabled = False
        Me.lblNavLocation.Location = New System.Drawing.Point(352, 13)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.lblNavLocation.Size = New System.Drawing.Size(60, 19)
        Me.lblNavLocation.TabIndex = 41
        '
        'NavLastBtn
        '
        Me.NavLastBtn.AutoSize = False
        Me.NavLastBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavLastBtn.Image = Nothing
        Me.NavLastBtn.Location = New System.Drawing.Point(320, 10)
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
        Me.NavFirstBtn.Location = New System.Drawing.Point(240, 10)
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
        Me.NavNextBtn.Location = New System.Drawing.Point(296, 10)
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
        Me.NavPrevBtn.Location = New System.Drawing.Point(272, 10)
        Me.NavPrevBtn.Name = "NavPrevBtn"
        Me.NavPrevBtn.Size = New System.Drawing.Size(24, 24)
        Me.NavPrevBtn.TabIndex = 37
        Me.NavPrevBtn.Text = " <"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NotesTxt)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 448)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 72)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'NotesTxt
        '
        Me.NotesTxt.Location = New System.Drawing.Point(56, 8)
        Me.NotesTxt.Name = "NotesTxt"
        Me.NotesTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesTxt.Size = New System.Drawing.Size(416, 56)
        Me.NotesTxt.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 16)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Notes :"
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
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(152, 528)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 21
        Me.CloseBtn.Text = "&Close"
        '
        'DispatchBtn
        '
        Me.DispatchBtn.Location = New System.Drawing.Point(80, 528)
        Me.DispatchBtn.Name = "DispatchBtn"
        Me.DispatchBtn.Size = New System.Drawing.Size(64, 32)
        Me.DispatchBtn.TabIndex = 22
        Me.DispatchBtn.Text = "&Dispatch"
        '
        'BtnSaveQuo
        '
        Me.BtnSaveQuo.Location = New System.Drawing.Point(8, 528)
        Me.BtnSaveQuo.Name = "BtnSaveQuo"
        Me.BtnSaveQuo.Size = New System.Drawing.Size(64, 32)
        Me.BtnSaveQuo.TabIndex = 23
        Me.BtnSaveQuo.Text = "&Save"
        '
        'NewWorkOrderForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.BtnSaveQuo)
        Me.Controls.Add(Me.DispatchBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "NewWorkOrderForm"
        Me.Text = "New Work Order"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectModeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WONoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.custPOTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ItemTab.ResumeLayout(False)
        Me.grpBox.ResumeLayout(False)
        CType(Me.DepthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComplTab.ResumeLayout(False)
        Me.grpComplDtl.ResumeLayout(False)
        CType(Me.ComplDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExComplDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoteTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyBalTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyComplTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNavLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public WOfromOC As Boolean = False

#Region " Work Order Header Variable "
    Public WO_ID As Integer
    Public WO_NO As String
    Public Confirm_Quotation_No As String
    Public Status As String
    Public WO_Date As String
    Public Cust_PO As String
    Public PO_Date As String
    Public Collect_Mode As String
    Public Customer_ID As Integer
    Public Contact_ID As Integer
    Public ProjectSub As String
    Public Project As String
    Public Notes As String
    Public RevRefWOID As Integer

#End Region

#Region " Work Order Line Variable "
    Public WO_Line_ID As Integer
    Public WO_ItemNo As Integer
    Public Box As String
    Public varHeight As Integer
    Public varWidth As Integer
    Public Depth As Integer
    Public Key_Type As String
    Public Color As String
    Public Material As String
    Public Draw_No As String
    Public Qty As Integer
    Public Note As String
    Public Compl_Date As String
    Public Expected_Compl_Date As String
    Public Qty_Compl As Integer
    Public Qty_Bal As Integer
    Public WorkStatus As String
#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    Public NavdsBox As DataSet              'FOR NAV
    Dim CurrentRow As Integer               'FOR NAVIGATION
    Public FormStatus As String             'TO DIFFERENTIATE BETWEEN ADD,EDIT..
    Public Old_Quotation_ID As Integer
    Public Old_WO_ID As Integer

#Region " Form Load "
    Private Sub WorkOrderForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Top = (MainForm.ActiveForm.Height - Me.Height) / 3
        'Me.Left = (MainForm.ActiveForm.Width - Me.Width) / 2

        Me.Cursor = Cursors.WaitCursor

        LoadCustomerDetails()
        LoadProjectTitle()
        LoadCombo()
        LoadDrawingNo()
        SetTabColors()
        LoadKey()
        LoadColor()
        LoadMaterial()

        Select Case UCase(FormStatus)
            Case "NEW"
                WO_ItemNo = 0
                InitializeForm()
                DisableNavBtn()
                AddBtn.Enabled = True
                WorkStatusChk.Visible = False
            Case "FROMOC"
                DuplicateOCHeader()
                DuplicateWOLine()
                RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                WODate.DateTime = Date.Today
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
            Case "EDIT"
                Dim dsHeaderLoad As DataSet
                Me.Text = "Edit Work Order"
                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    If .GetWOHeader(dsHeaderLoad, WO_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                CompGrid1.Enabled = True
                BtnSaveQuo.Enabled = True
                GroupBox2.Enabled = True
                grpBox.Enabled = True
                grpComplDtl.Enabled = True
                AddBtn.Enabled = True
                DelProdBtn.Enabled = True
                UpdateBtn.Enabled = True
                RefreshNavBtn()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
                If IsDBNull(dsHeaderLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")) Then
                    WOfromOC = False
                Else
                    WOfromOC = True
                End If
                EnableButtons()
            Case "REVISED"
                Me.Text = "Revise Work Order"
                RevisedWOHeader()
                RevisedWOLine()
                SetOldWOStatus()
                RefreshNavBtn()
                EnableButtons()
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If

            Case "VIEW"
                Me.Text = "View Work Order"
                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    Dim dsHeaderLoad As DataSet
                    If .GetWOHeader(dsHeaderLoad, WO_ID) Then
                        SetWindowValue(dsHeaderLoad)
                    End If
                End With
                CompGrid1.Enabled = False
                BtnSaveQuo.Enabled = True
                RefreshNavBtn()
                TabControl1.Enabled = True
                GroupBox1.Enabled = False
                GroupBox2.Enabled = True
                grpBox.Enabled = False
                grpComplDtl.Enabled = False
                AddBtn.Enabled = False
                DelProdBtn.Enabled = False
                UpdateBtn.Enabled = False
                BtnSaveQuo.Enabled = False
                NavFirstBtn.Enabled = True
                NavLastBtn.Enabled = True
                NavNextBtn.Enabled = True
                NavPrevBtn.Enabled = True
                CurrentRow = 0
                If Not Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    Me.NavdsBox_PositionChanged()
                End If
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetTabColors()
        '** Tab Control Appearance **
        TabControl1.BackColor = BackColor.DarkSlateBlue
        TabControl1.ForeColor = ForeColor.White
        TabControl1.ButtonActiveColor = TabControl1.ButtonActiveColor.White
        TabControl1.ButtonInactiveColor = TabControl1.ButtonInactiveColor.SlateBlue
        TabControl1.TextInactiveColor = TabControl1.TextInactiveColor.White
        TabControl1.HotTextColor = TabControl1.HotTextColor.Cyan
        '***
    End Sub

    Private Sub EnableButtons()
        'DelProdBtn.Enabled = True
        TabControl1.Enabled = True
        'EditCompBtn.Enabled = True
        'DelCompBtn.Enabled = True
        UpdateBtn.Enabled = True
        If WOfromOC = True Then
            AddBtn.Enabled = False
            BoxDescTxt.Properties.ReadOnly = True
            QtyTxt.Properties.ReadOnly = True
        Else
            AddBtn.Enabled = True
            BoxDescTxt.Properties.ReadOnly = False
            QtyTxt.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

        StatusCmb.Properties.LookUpData.KeyValue = "10"
        ProjectCmb.Properties.LookUpData.KeyValue = "RE:"
        ItemNoTxt.Text = WO_ItemNo.ToString
        WODate.DateTime = Date.Today
        PODate.DateTime = Date.Today

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

            With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                WO_NO = GetWorkOrderNo(CustInitial)
                WONoTxt.Text = WO_NO

                .WO_No = WO_NO
                .UserID = UserID
                .Status = StatusCmb.Properties.LookUpData.KeyValue

                If .SaveWONo() Then
                    WO_ID = .WO_ID        'Store WO ID
                Else
                    MessageBox.Show("Error creating Work Order", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        End With
    End Sub
#End Region

#Region " Generate Work Order No "
    Private Function GetWorkOrderNo(ByVal pCustInitial As String) As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("WO")
        End With
        GetWorkOrderNo = pCustInitial & "/" & Year(Now) & "/" & DocumentNo
    End Function
#End Region

#Region " Duplicate Order Confirmation to Work Order "
    Private Sub DuplicateOCHeader()
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedQuotation As DataSet
        Dim BasedQuotationID As Integer
        Dim CustInitial As String

        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetOrderConfirmHeader(dsLoad, Old_Quotation_ID) Then

                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    .Confirm_Quotation_No = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_No")  'Get the Existing OC No.
                    .WO_No = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_No")   'WO has the same number as OC
                    .Status = "10"
                    .UserID = UserID
                    If .SaveWONo() Then
                        WO_ID = .WO_ID    'Get the new quotation_ID
                        'saving
                        .WO_ID = WO_ID
                        .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                        .Project = dsLoad.Tables(0).Rows(0)("Project")
                        .Cust_PO = dsLoad.Tables(0).Rows(0)("Customer_PO")
                        .PO_Date = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("PODate")) & "/" & Month(dsLoad.Tables(0).Rows(0)("PODate")) & "/" & Year(dsLoad.Tables(0).Rows(0)("PODate"))
                        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("CollectMode")) Then
                            .Collect_Mode = dsLoad.Tables(0).Rows(0)("CollectMode")
                        End If
                        .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")
                        .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")

                        If .UpdateWOHeader() Then
                            Dim dsNew As DataSet
                            If .GetWOHeader(dsNew, WO_ID) Then
                                SetWindowValue(dsNew)
                            End If
                            dsNew.Dispose()
                        End If
                        dsLoad.Dispose()
                    End If
                End With
            End If
        End With
    End Sub

    Private Sub DuplicateWOLine()
        Dim dsLine As DataSet
        Dim Old_Quotation_Line_ID As Integer

        WO_ItemNo = 0
        With New BusinessRules.SaleBusRules.SaleBusLogic
            'Get the old quotation line item
            .Quotation_ID = Old_Quotation_ID
            If .GetQuotationLine(dsLine) Then
                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    Dim x As Integer
                    For x = 0 To dsLine.Tables(0).Rows.Count - 1
                        'Save the itemno first
                        WO_ItemNo = WO_ItemNo + 1
                        .WO_ItemNo = WO_ItemNo
                        .WO_ID = WO_ID
                        .UserID = UserID
                        If .SaveWOLineFirstTime() Then
                            WO_Line_ID = .WO_Line_ID
                        End If
                        '***

                        Old_Quotation_Line_ID = dsLine.Tables(0).Rows(x)("Quotation_Line_ID")
                        .Box = dsLine.Tables(0).Rows(x)("Box")
                        .varHeight = dsLine.Tables(0).Rows(x)("Height")
                        .varWidth = dsLine.Tables(0).Rows(x)("Width")
                        .Depth = dsLine.Tables(0).Rows(x)("Depth")

                        .Qty = dsLine.Tables(0).Rows(x)("Qty")
                        .WO_Line_ID = WO_Line_ID
                        .UserID = UserID

                        If .UpdateWOLine() Then
                            Dim dsComp As DataSet
                            With New BusinessRules.SaleBusRules.SaleBusLogic
                                .Quotation_Line_ID = Old_Quotation_Line_ID
                                If .GetQuotationLineCompOnLineID(dsComp) Then

                                    With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                                        Dim i As Integer
                                        For i = 0 To dsComp.Tables(0).Rows.Count - 1
                                            .WO_ID = WO_ID
                                            .WO_Line_ID = WO_Line_ID
                                            .Category_ID = dsComp.Tables(0).Rows(i)("Category_ID")
                                            .Product_ID = dsComp.Tables(0).Rows(i)("Product_ID")
                                            .Supplier_ID = dsComp.Tables(0).Rows(i)("Supplier_ID")
                                            .UnitPrice = dsComp.Tables(0).Rows(i)("UnitPrice")
                                            .Lead_Time = dsComp.Tables(0).Rows(i)("Lead_Time")
                                            .CompQty = dsComp.Tables(0).Rows(i)("Qty")
                                            .BalanceQty = dsComp.Tables(0).Rows(i)("Qty")
                                            .UserID = UserID
                                            If .SaveWOLineComponent() Then

                                            End If
                                        Next
                                    End With
                                End If
                            End With
                            dsComp.Dispose()
                        End If
                    Next
                End With
                dsLine.Dispose()
            End If
        End With
    End Sub
#End Region

#Region " Revised Work Order "
    Private Sub RevisedWOHeader()
        Dim dsLoad As DataSet
        Dim RevisedNo As Integer
        Dim dsBasedWO As DataSet
        Dim BasedWOID As Integer

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If .GetWOHeader(dsLoad, Old_WO_ID) Then
                'Check if its created from revised WO or based WO
                .WO_ID = Old_WO_ID
                If .IsRevisedWO(dsBasedWO) Then        'if its revised quotation, then load based Quotation no
                    BasedWOID = dsBasedWO.Tables(0).Rows(0)("WO_ID")
                    WO_NO = dsBasedWO.Tables(0).Rows(0)("WO_NO")
                    'COUNT THE NO OF REVISED COPY
                    .RevRefWOID = BasedWOID
                    RevisedNo = .CountNoOfRevisedWO()
                    '****
                    RevRefWOID = BasedWOID        'Reference to the based ID
                Else
                    WO_NO = dsLoad.Tables(0).Rows(0)("WO_NO")  'Get the Existing Quotation No.
                    'COUNT THE NO OF REVISED COPY
                    .RevRefWOID = Old_WO_ID
                    RevisedNo = .CountNoOfRevisedWO()
                    '****
                    RevRefWOID = Old_WO_ID        'Reference
                End If
                '****

                'CHECKING
                .WO_No = WO_NO & "R" & RevisedNo          'Appending R...
                If .CheckExistingWONo() Then         'Record exist
                    RevisedNo = RevisedNo + 1
                    .WO_No = WO_NO & "R" & RevisedNo
                    While .CheckExistingWONo()
                        RevisedNo = RevisedNo + 1
                        .WO_No = WO_NO & "R" & RevisedNo
                    End While
                End If
                '***

                If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")) Then
                    .Confirm_Quotation_No = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")
                End If
                .Status = "10"
                .UserID = UserID
                If .SaveWONo() Then
                    WO_ID = .WO_ID    'Get the new WO_ID
                    'saving
                    .WO_ID = WO_ID
                    .WO_Date = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("WO_Date")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("WO_Date"))) & Year(dsLoad.Tables(0).Rows(0)("WO_Date"))
                    .ProjectSub = dsLoad.Tables(0).Rows(0)("ProjectSub")
                    .Project = dsLoad.Tables(0).Rows(0)("Project")
                    .Customer_ID = dsLoad.Tables(0).Rows(0)("Customer_ID")
                    .Contact_ID = dsLoad.Tables(0).Rows(0)("Contact_ID")

                    .Cust_PO = dsLoad.Tables(0).Rows(0)("Cust_PO")
                    .PO_Date = Microsoft.VisualBasic.DateAndTime.Day(dsLoad.Tables(0).Rows(0)("PO_Date")) & MonthName(Month(dsLoad.Tables(0).Rows(0)("PO_Date"))) & Year(dsLoad.Tables(0).Rows(0)("PO_Date"))
                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Collect_Mode")) Then
                        .Collect_Mode = dsLoad.Tables(0).Rows(0)("Collect_Mode")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Notes")) Then
                        .Notes = dsLoad.Tables(0).Rows(0)("Notes")
                    End If

                    If Not IsDBNull(dsLoad.Tables(0).Rows(0)("RevRefWOID")) Then
                        .RevRefWOID = RevRefWOID
                    End If

                    If .UpdateWOHeader() Then
                        Dim dsNew As DataSet
                        If .GetWOHeader(dsNew, WO_ID) Then
                            SetWindowValue(dsNew)
                        End If
                    End If
                    dsLoad.Dispose()
                End If
            End If
        End With
    End Sub

    Private Sub RevisedWOLine()
        Dim dsLine As DataSet
        Dim Old_WO_Line_ID As Integer

        WO_ItemNo = 0
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            'Get the old quotation line item
            .WO_ID = Old_WO_ID
            If .GetWOLine(dsLine) Then
                Dim x As Integer
                For x = 0 To dsLine.Tables(0).Rows.Count - 1
                    'Save the itemno first
                    WO_ItemNo = WO_ItemNo + 1
                    .WO_ItemNo = WO_ItemNo
                    .WO_ID = WO_ID
                    .UserID = UserID
                    If .SaveWOLineFirstTime() Then
                        WO_Line_ID = .WO_Line_ID
                    End If
                    '***
                    Old_WO_Line_ID = dsLine.Tables(0).Rows(x)("WO_Line_ID")
                    .Box = dsLine.Tables(0).Rows(x)("Box")
                    .varHeight = dsLine.Tables(0).Rows(x)("Height")
                    .varWidth = dsLine.Tables(0).Rows(x)("Width")
                    .Depth = dsLine.Tables(0).Rows(x)("Depth")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Key_Type")) Then
                        .Key_Type = dsLine.Tables(0).Rows(x)("Key_Type")
                    End If

                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Color")) Then
                        .Color = dsLine.Tables(0).Rows(x)("Color")
                    End If

                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Material")) Then
                        .Material = dsLine.Tables(0).Rows(x)("Material")
                    End If

                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Draw_No")) Then
                        .Draw_No = dsLine.Tables(0).Rows(x)("Draw_No")
                    End If

                    .Qty = dsLine.Tables(0).Rows(x)("Qty")
                    If Not IsDBNull(dsLine.Tables(0).Rows(x)("Note")) Then
                        .Note = dsLine.Tables(0).Rows(x)("Note")
                    End If

                    .WO_Line_ID = WO_Line_ID
                    .UserID = UserID

                    If .UpdateWOLine() Then
                        Dim dsComp As DataSet
                        .WO_Line_ID = Old_WO_Line_ID
                        If .GetWOLineCompOnLineID(dsComp) Then
                            Dim i As Integer
                            For i = 0 To dsComp.Tables(0).Rows.Count - 1
                                .WO_ID = WO_ID
                                .WO_Line_ID = WO_Line_ID
                                .Category_ID = dsComp.Tables(0).Rows(i)("Category_ID")
                                .Product_ID = dsComp.Tables(0).Rows(i)("Product_ID")
                                .Supplier_ID = dsComp.Tables(0).Rows(i)("Supplier_ID")
                                .UnitPrice = dsComp.Tables(0).Rows(i)("UnitPrice")
                                .Lead_Time = dsComp.Tables(0).Rows(i)("Lead_Time")
                                .CompQty = dsComp.Tables(0).Rows(i)("Qty")
                                .BalanceQty = dsComp.Tables(0).Rows(i)("Qty")
                                .UserID = UserID
                                If .SaveWOLineComponent() Then

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

    Private Sub SetOldWOStatus()
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .WO_ID = Old_WO_ID
            .Status = "40"
            If Old_WO_ID > 0 Then
                If .UpdateWOHeaderStatus() Then

                End If
            End If
        End With
    End Sub
#End Region

#Region " Set window value "
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        WONoTxt.Text = dsLoad.Tables(0).Rows(0)("WO_No")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")) Then
            OCNoTxt.Text = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")
        End If

        CustLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Customer_ID")
        StatusCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Status")
        ProjectCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("ProjectSub")
        ProjectTitleCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Project")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("WO_Date")) Then
            WODate.DateTime = dsLoad.Tables(0).Rows(0)("WO_Date")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PO_Date")) Then
            PODate.DateTime = dsLoad.Tables(0).Rows(0)("PO_Date")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Cust_PO")) Then
            custPOTxt.Text = dsLoad.Tables(0).Rows(0)("Cust_PO")
        End If

        LoadContactPerson(dsLoad.Tables(0).Rows(0)("Customer_ID"))
        ContLookup.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Contact_ID")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Notes")) Then
            NotesTxt.Text = dsLoad.Tables(0).Rows(0)("Notes")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Collect_Mode")) Then
            CollectModeCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Collect_Mode")
        End If
    End Sub
#End Region

#Region " Combo Box - Drawing No n Loading Customer n Contact Person Cmb "
    Private Sub LoadDrawingNo()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.DrawingNoBusLogic
            If .GetDrawingNo(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(DrawNoCmb, "Drawing_No", 400, 0, "c")
                        DrawNoCmb.Properties.LookUpData.KeyField = "Drawing_ID"
                        DrawNoCmb.Properties.LookUpData.DisplayField = "Drawing_No"

                        DrawNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        DrawNoCmb.EditValue = "0"
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
    Private Sub LoadKey()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.KeyBusLogic
            If .GetKey(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(KeyCmb, "Key_Name", 400, 0, "c")
                        KeyCmb.Properties.LookUpData.KeyField = "Key_ID"
                        KeyCmb.Properties.LookUpData.DisplayField = "Key_Name"

                        KeyCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        KeyCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadColor()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ColorCmb, "Color_Name", 400, 0, "c")
                        ColorCmb.Properties.LookUpData.KeyField = "Color_ID"
                        ColorCmb.Properties.LookUpData.DisplayField = "Color_Name"

                        ColorCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ColorCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadMaterial()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.MaterialBusLogic
            If .GetMaterial(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(MaterialCmb, "Material_Name", 400, 0, "c")
                        MaterialCmb.Properties.LookUpData.KeyField = "Material_ID"
                        MaterialCmb.Properties.LookUpData.DisplayField = "Material_Name"

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


    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

#Region " Hardcoded Combo Box , Status, ProjectSub"
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

        Dim CollectModeData As String() = New String() {"", "Deliver", "Self-Collect"}
        Dim CollectModeID As String() = New String() {"", "Deliver", "Self-Collect"}
        SetComboValue(CollectModeData, CollectModeCmb, CollectModeID)
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
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .WO_ID = WO_ID
            If .GetWOLine(NavdsBox) Then
                If Me.NavdsBox.Tables(0).Rows.Count = 0 Then
                    DisableNavBtn()
                    WO_ItemNo = 0
                Else
                    EnableNavBtn()
                    If CurrentRow = 0 Then
                        Me.lblNavLocation.Text = ("1 of " _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        WO_ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    Else
                        Me.lblNavLocation.Text = (((CurrentRow).ToString + " of ") _
                        + Me.NavdsBox.Tables(0).Rows.Count.ToString)
                        WO_ItemNo = Me.NavdsBox.Tables(0).Rows.Count
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub NavdsBox_PositionChanged()
        Me.lblNavLocation.Text = (((CurrentRow + 1).ToString + " of  ") _
                    + Me.NavdsBox.Tables(0).Rows.Count.ToString)
        WO_Line_ID = Me.NavdsBox.Tables(0).Rows(CurrentRow)("WO_Line_ID")
        Me.BoxDescTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Box").ToString
        Me.ItemNoTxt.Text = CurrentRow + 1
        Me.QtyTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty").ToString

        Me.HeightTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Height"))
        Me.WidthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Width"))
        Me.DepthTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Depth"))

        Me.KeyCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Key_Type")
        Me.ColorCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Color")
        Me.MaterialCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Material")
        Me.DrawNoCmb.Properties.LookUpData.KeyValue = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Draw_No")

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("WorkStatus")) Then
            If Me.NavdsBox.Tables(0).Rows(CurrentRow)("WorkStatus") = "1" Then
                Me.WorkStatusChk.Checked = True
            Else
                Me.WorkStatusChk.Checked = False
            End If
        Else
            Me.WorkStatusChk.Checked = False
        End If

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Compl_Date")) Then
            Me.ComplDate.DateTime = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Compl_Date")
        Else
            Me.ComplDate.DateTime = Nothing
        End If

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Expected_Compl_Date")) Then
            Me.ExComplDate.DateTime = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Expected_Compl_Date")
        Else
            Me.ExComplDate.DateTime = Nothing
        End If

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Compl")) Then
            Me.QtyComplTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Compl"))
        End If

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Bal")) Then
            Me.QtyBalTxt.Text = Integer.Parse(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Qty_Bal"))
        End If

        If Not IsDBNull(Me.NavdsBox.Tables(0).Rows(CurrentRow)("Note")) Then
            Me.NoteTxt.Text = Me.NavdsBox.Tables(0).Rows(CurrentRow)("Note")
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

#Region " Event - Component Grid Function "
    Public Sub RefreshComponentGrid()
        Dim ds As DataSet
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .WO_Line_ID = WO_Line_ID
            If .GetWOLineCompOnLineID(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    data.Rows.Add(New Object() {i, oRow("WO_Component_ID"), oRow("Name"), oRow("Brand"), oRow("Description"), oRow("Qty")})
                Next
                CompGrid1.DataSource = data
                CompGrid1.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "WOID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Id", System.Type.GetType("System.String"), True)
        AddColumn(data, "Brand/Model", System.Type.GetType("System.String"), True)
        AddColumn(data, "Description", System.Type.GetType("System.String"), True)
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

    Private Sub CompGrid1_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_Component_ID As Integer = dr(1)
            Dim Component_Name As String = dr(2)

            Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Component_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                DeleteWOLineComponent(WO_Component_ID)
            End If
        End If
    End Sub

    Private Sub DeleteWOLineComponent(ByVal pComponent_ID As Integer)
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .WO_Component_ID = pComponent_ID
            If .DeleteWOLineComponent Then
                RefreshComponentGrid()
                MessageBox.Show("Component Deleted.", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub CompGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompGrid1.DoubleClick
        'Not allow to edit /modify when in View WO mode.
        If FormStatus.ToUpper <> "VIEW" Then
            Dim NewForm As New SelectProductForm
            NewForm.WO_Line_ID = WO_Line_ID
            NewForm.WO_ID = WO_ID
            NewForm.Status = "ADDFROMWO"
            NewForm.ShowDialog(Me)
            RefreshComponentGrid()
        End If
    End Sub
#End Region

#Region " Event - Buttons - Component, Box "
    Private Sub AddBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ResetQuotationLine()
        WO_ItemNo = WO_ItemNo + 1
        ItemNoTxt.Text = WO_ItemNo
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .WO_ID = WO_ID
            .WO_ItemNo = WO_ItemNo
            .UserID = UserID
            If .SaveWOLineFirstTime() Then
                WO_Line_ID = .WO_Line_ID
                CompGrid1.Enabled = True
                BtnSaveQuo.Enabled = True
                RefreshNavBtn()
                EnableButtons()
                AddBtn.Enabled = False
                NavFirstBtn.Enabled = False
                NavNextBtn.Enabled = False
                NavLastBtn.Enabled = False
                NavPrevBtn.Enabled = False
            End If
        End With
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        RetrieveFromLineForm()
        SaveWOLineProcess()
        RefreshNavBtn()
        If WOfromOC = True Then
            AddBtn.Enabled = False
        Else
            AddBtn.Enabled = True
        End If
        NavFirstBtn.Enabled = True
        NavNextBtn.Enabled = True
        NavLastBtn.Enabled = True
        NavPrevBtn.Enabled = True
    End Sub

    Private Sub DelProdBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelProdBtn.Click
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    .WO_Line_ID = WO_Line_ID
                    If .DeleteWOLine() Then
                        MessageBox.Show("Box Deleted.", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            RefreshNavBtn()
            CurrentRow = 0
            Me.NavdsBox_PositionChanged()
        End If
    End Sub

    Private Sub ResetQuotationLine()
        '** Box Tab **
        BoxDescTxt.Text = ""
        QtyTxt.Text = ""
        KeyCmb.Properties.LookUpData.KeyValue = Nothing
        ColorCmb.Properties.LookUpData.KeyValue = Nothing
        MaterialCmb.Properties.LookUpData.KeyValue = Nothing
        HeightTxt.Text = ""
        WidthTxt.Text = ""
        DepthTxt.Text = ""
        DrawNoCmb.Properties.LookUpData.KeyValue = Nothing
        WorkStatusChk = Nothing
        '****

        '** Compl Tab **
        ExComplDate.DateTime = Nothing
        ComplDate.DateTime = Nothing
        QtyComplTxt.Text = 0
        QtyBalTxt.Text = 0
        NoteTxt.Text = ""
        '****

        WO_Line_ID = 0
        RefreshComponentGrid()
    End Sub
#End Region

#Region " Save, RetrieveFromForm function for WO Line."
    Private Sub RetrieveFromLineForm()
        '** Box Tab **
        Box = BoxDescTxt.Text
        Qty = QtyTxt.Text
        varHeight = HeightTxt.Text
        varWidth = WidthTxt.Text
        Depth = DepthTxt.Text

        If Not IsDBNull(KeyCmb.Properties.LookUpData.KeyValue) Then
            Key_Type = KeyCmb.Properties.LookUpData.KeyValue
        End If

        If Not IsDBNull(ColorCmb.Properties.LookUpData.KeyValue) Then
            Color = ColorCmb.Properties.LookUpData.KeyValue
        End If

        If Not IsDBNull(MaterialCmb.Properties.LookUpData.KeyValue) Then
            Material = MaterialCmb.Properties.LookUpData.KeyValue
        End If

        If Not IsDBNull(DrawNoCmb.Properties.LookUpData.KeyValue) Then
            Draw_No = DrawNoCmb.Properties.LookUpData.KeyValue
        End If

        If Not WorkStatusChk Is Nothing Then
            If WorkStatusChk.Checked Then
                WorkStatus = "1"
            Else
                WorkStatus = ""
            End If
        End If
        '****

        '** Compl Tab **
        Expected_Compl_Date = ExComplDate.Text
        Compl_Date = ComplDate.Text
        Qty_Compl = QtyComplTxt.Text
        Qty_Bal = QtyBalTxt.Text
        Note = NoteTxt.Text
        '****
    End Sub

    Private Sub SaveWOLineProcess()
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If ValidDataForLine() Then
                .WO_Line_ID = WO_Line_ID
                .Box = Box
                .varHeight = varHeight
                .varWidth = varWidth
                .Depth = Depth
                .Qty = Qty
                .Key_Type = Key_Type
                .Color = Color
                .Material = Material
                .Draw_No = Draw_No
                .WorkStatus = WorkStatus
                .Expected_Compl_Date = Expected_Compl_Date
                .Compl_Date = Compl_Date
                .Qty_Compl = Qty_Compl
                .Qty_Bal = Qty_Bal

                .UserID = UserID
                If .UpdateWOLine() Then
                    WO_Line_ID = .WO_Line_ID
                    MessageBox.Show("Data saved. ", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidDataForLine = DataOK_Flag
    End Function
#End Region

#Region " Main Form Function"

    Private Sub RetrieveFromMainForm()
        Customer_ID = CustLookup.Properties.LookUpData.KeyValue
        Contact_ID = ContLookup.Properties.LookUpData.KeyValue
        Status = StatusCmb.Properties.LookUpData.KeyValue
        Project = ProjectTitleCmb.Properties.LookUpData.KeyValue
        ProjectSub = ProjectCmb.Properties.LookUpData.KeyValue
        Cust_PO = custPOTxt.Text
        PO_Date = PODate.Text
        WO_Date = WODate.Text
        Collect_Mode = CollectModeCmb.Properties.LookUpData.KeyValue
        If Len(NotesTxt.Text) > 0 Then
            Notes = NotesTxt.Text
        End If
    End Sub

    Private Sub SaveMainFormProcess()
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If ValidDataHeader() Then
                .WO_ID = WO_ID
                .Status = Status
                .ProjectSub = ProjectSub
                .Project = Project
                .Customer_ID = Customer_ID
                .Contact_ID = Contact_ID
                .Cust_PO = Cust_PO
                .WO_Date = Microsoft.VisualBasic.DateAndTime.Day(WO_Date) & "/" & Month(WO_Date) & "/" & Year(WO_Date)
                .PO_Date = Microsoft.VisualBasic.DateAndTime.Day(PO_Date) & "/" & Month(PO_Date) & "/" & Year(PO_Date)
                .Collect_Mode = Collect_Mode
                .Notes = Notes
                .UserID = UserID
                If .UpdateWOHeader() Then
                    MessageBox.Show("Work Order Saved.", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub

    Private Function ValidDataHeader()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(WO_Date) > 0 Then
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

        If Not Len(Draw_No) > 0 Then
            DataOK_Flag = False
            FieldName = "Drawing No" & Chr(13)

        End If
        'If Not Len(PO_Date) > 0 Then
        'DataOK_Flag = False
        'FieldName = "PO Date" & Chr(13)
        'End If

        'If Not Len(Cust_PO) > 0 Then
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
#End Region

    Private Sub AllWorkStatusChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If AllWorkStatusChk.Checked Then
            WorkStatusChk.Enabled = False
            WorkStatusChk.Checked = True
        Else
            WorkStatusChk.Enabled = True
            WorkStatusChk.Checked = False
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
                ComponentContextMenu.Show(sender, mouseDownLocation)
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub

#Region " Button Click "
    Private Sub UpdateAllBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NavdsBox.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To NavdsBox.Tables(0).Rows.Count - 1
                WO_Line_ID = NavdsBox.Tables(0).Rows(i)("WO_Line_ID")

                If AllWorkStatusChk.Checked Then
                    WorkStatus = "1"
                Else
                    WorkStatus = ""
                End If

                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    .WorkStatus = WorkStatus
                    .WO_Line_ID = WO_Line_ID
                    .UserID = UserID
                    If .UpdateWorkStatus() Then

                    End If
                End With
            Next
            MessageBox.Show("All Work Status updated", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.RefreshNavBtn()
        End If
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow

            dr = GridView1.GetDataRow(Row)
            Dim WO_Component_ID As Integer = dr(1)

            Dim NewForm As New SelectProductForm
            NewForm.WO_Component_ID = WO_Component_ID
            NewForm.Status = "EDITFROMWO"
            NewForm.ShowDialog(Me)
            RefreshComponentGrid()
        End If
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow

            dr = GridView1.GetDataRow(Row)
            Dim WO_Component_ID As Integer = dr(1)
            Dim Component_Name As String = dr(2)

            Dim Result As DialogResult = MessageBox.Show("Confirm delete? " & Chr(13) & Component_Name, "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                DeleteWOLineComponent(WO_Component_ID)
            End If
        End If
    End Sub
#End Region

    Private Sub btnDispatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NewWorkOrderForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Work Order?", "Work Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

    Private Sub CloseBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub DispatchBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DispatchBtn.Click
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .WO_ID = WO_ID
            .UserID = UserID
            .Status = "20"
            If .UpdateWOHeaderStatus() Then
                MessageBox.Show("Status updated.", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                StatusCmb.Properties.LookUpData.KeyValue = "20"
            End If
        End With
    End Sub

    Private Sub BtnSaveQuo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveQuo.Click
        RetrieveFromMainForm()
        SaveMainFormProcess()
    End Sub
End Class
