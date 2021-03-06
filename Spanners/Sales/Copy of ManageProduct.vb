Imports DevExpress.XtraEditors.Controls
Imports System.Collections

Public Class ManageProductForm
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
    Friend WithEvents TabPage1 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage2 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PowerCoatChk As System.Windows.Forms.CheckBox
    Friend WithEvents StdChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents KeepStkRd2 As System.Windows.Forms.RadioButton
    Friend WithEvents KeepStkRd1 As System.Windows.Forms.RadioButton
    Friend WithEvents UOMCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TemplateCtr As Crownwood.Magic.Controls.TabControl
    Friend WithEvents BrandCmb2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BrandCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MechTechCmb2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ShuntTripCmb2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PhyTypeCmb2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PolesCmb2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CodeTempCmb2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents SupplierGrp As System.Windows.Forms.GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RemoveSupBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents AddSupplierBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AddBut As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents UOMCmb2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AltDescTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DimTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AltDimTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ModelTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GradeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LeadTimeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NameTxt2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ModelTxt2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescTxt2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents FrameSizeTxt2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TrippingRatingTxt2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RapturingCapacityTxt2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents MaterialCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ColorCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MaxAlertQtyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MinAlertQtyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents RawMaterialChk As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BrandSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents SearchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents CategoryTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents ModelSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescSearch2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents CatCmb As DevExpress.XtraEditors.LookUpEdit

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TemplateCtr = New Crownwood.Magic.Controls.TabControl
        Me.TabPage1 = New Crownwood.Magic.Controls.TabPage
        Me.CatCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label37 = New System.Windows.Forms.Label
        Me.RawMaterialChk = New System.Windows.Forms.CheckBox
        Me.MaxAlertQtyTxt = New DevExpress.XtraEditors.TextEdit
        Me.MinAlertQtyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.ColorCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.MaterialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.LeadTimeTxt = New DevExpress.XtraEditors.TextEdit
        Me.GradeTxt = New DevExpress.XtraEditors.TextEdit
        Me.ModelTxt = New DevExpress.XtraEditors.TextEdit
        Me.AltDimTxt = New DevExpress.XtraEditors.TextEdit
        Me.DimTxt = New DevExpress.XtraEditors.TextEdit
        Me.AltDescTxt = New DevExpress.XtraEditors.MemoEdit
        Me.DescTxt = New DevExpress.XtraEditors.MemoEdit
        Me.NameTxt = New DevExpress.XtraEditors.TextEdit
        Me.BrandCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.UOMCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.PowerCoatChk = New System.Windows.Forms.CheckBox
        Me.StdChk = New System.Windows.Forms.CheckBox
        Me.KeepStkRd2 = New System.Windows.Forms.RadioButton
        Me.KeepStkRd1 = New System.Windows.Forms.RadioButton
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage2 = New Crownwood.Magic.Controls.TabPage
        Me.RapturingCapacityTxt2 = New DevExpress.XtraEditors.SpinEdit
        Me.TrippingRatingTxt2 = New DevExpress.XtraEditors.SpinEdit
        Me.FrameSizeTxt2 = New DevExpress.XtraEditors.SpinEdit
        Me.DescTxt2 = New DevExpress.XtraEditors.MemoEdit
        Me.ModelTxt2 = New DevExpress.XtraEditors.TextEdit
        Me.NameTxt2 = New DevExpress.XtraEditors.TextEdit
        Me.UOMCmb2 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.CodeTempCmb2 = New DevExpress.XtraEditors.LookUpEdit
        Me.PolesCmb2 = New DevExpress.XtraEditors.LookUpEdit
        Me.PhyTypeCmb2 = New DevExpress.XtraEditors.LookUpEdit
        Me.ShuntTripCmb2 = New DevExpress.XtraEditors.LookUpEdit
        Me.MechTechCmb2 = New DevExpress.XtraEditors.LookUpEdit
        Me.BrandCmb2 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.CategoryTree = New System.Windows.Forms.TreeView
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.SupplierGrp = New System.Windows.Forms.GroupBox
        Me.RemoveSupBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AddSupplierBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddBut = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ModelSearch = New DevExpress.XtraEditors.TextEdit
        Me.Label36 = New System.Windows.Forms.Label
        Me.DescSearch2 = New DevExpress.XtraEditors.TextEdit
        Me.Label35 = New System.Windows.Forms.Label
        Me.DescSearch = New DevExpress.XtraEditors.TextEdit
        Me.Label34 = New System.Windows.Forms.Label
        Me.BrandSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.SearchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label33 = New System.Windows.Forms.Label
        Me.CategoryTxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TemplateCtr.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CatCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxAlertQtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinAlertQtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeadTimeTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltDimTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DimTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOMCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.RapturingCapacityTxt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrippingRatingTxt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameSizeTxt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescTxt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTxt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTxt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOMCmb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTempCmb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PolesCmb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhyTypeCmb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShuntTripCmb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MechTechCmb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandCmb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierGrp.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemplateCtr
        '
        Me.TemplateCtr.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.TemplateCtr.AutoScroll = True
        Me.TemplateCtr.IDEPixelArea = True
        Me.TemplateCtr.IDEPixelBorder = False
        Me.TemplateCtr.Location = New System.Drawing.Point(216, 72)
        Me.TemplateCtr.Name = "TemplateCtr"
        Me.TemplateCtr.SelectedIndex = 0
        Me.TemplateCtr.SelectedTab = Me.TabPage1
        Me.TemplateCtr.ShowArrows = False
        Me.TemplateCtr.ShowClose = False
        Me.TemplateCtr.Size = New System.Drawing.Size(536, 328)
        Me.TemplateCtr.TabIndex = 4
        Me.TemplateCtr.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.TabPage1, Me.TabPage2})
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CatCmb)
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.RawMaterialChk)
        Me.TabPage1.Controls.Add(Me.MaxAlertQtyTxt)
        Me.TabPage1.Controls.Add(Me.MinAlertQtyTxt)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.ColorCmb)
        Me.TabPage1.Controls.Add(Me.MaterialCmb)
        Me.TabPage1.Controls.Add(Me.LeadTimeTxt)
        Me.TabPage1.Controls.Add(Me.GradeTxt)
        Me.TabPage1.Controls.Add(Me.ModelTxt)
        Me.TabPage1.Controls.Add(Me.AltDimTxt)
        Me.TabPage1.Controls.Add(Me.DimTxt)
        Me.TabPage1.Controls.Add(Me.AltDescTxt)
        Me.TabPage1.Controls.Add(Me.DescTxt)
        Me.TabPage1.Controls.Add(Me.NameTxt)
        Me.TabPage1.Controls.Add(Me.BrandCmb)
        Me.TabPage1.Controls.Add(Me.UOMCmb)
        Me.TabPage1.Controls.Add(Me.PowerCoatChk)
        Me.TabPage1.Controls.Add(Me.StdChk)
        Me.TabPage1.Controls.Add(Me.KeepStkRd2)
        Me.TabPage1.Controls.Add(Me.KeepStkRd1)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.TabPage1.Location = New System.Drawing.Point(0, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(536, 303)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Title = "Template 1"
        '
        'CatCmb
        '
        Me.CatCmb.Location = New System.Drawing.Point(372, 16)
        Me.CatCmb.Name = "CatCmb"
        Me.CatCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CatCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CatCmb.Properties.NullString = ""
        Me.CatCmb.Properties.PopupWidth = 164
        Me.CatCmb.Size = New System.Drawing.Size(144, 19)
        Me.CatCmb.TabIndex = 54
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label37.Location = New System.Drawing.Point(312, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 24)
        Me.Label37.TabIndex = 53
        Me.Label37.Text = "Category :"
        '
        'RawMaterialChk
        '
        Me.RawMaterialChk.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.RawMaterialChk.Location = New System.Drawing.Point(432, 280)
        Me.RawMaterialChk.Name = "RawMaterialChk"
        Me.RawMaterialChk.Size = New System.Drawing.Size(96, 16)
        Me.RawMaterialChk.TabIndex = 52
        Me.RawMaterialChk.Text = "Raw Material"
        '
        'MaxAlertQtyTxt
        '
        Me.MaxAlertQtyTxt.Location = New System.Drawing.Point(352, 256)
        Me.MaxAlertQtyTxt.Name = "MaxAlertQtyTxt"
        Me.MaxAlertQtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MaxAlertQtyTxt.Properties.MaxLength = 50
        Me.MaxAlertQtyTxt.Size = New System.Drawing.Size(160, 19)
        Me.MaxAlertQtyTxt.TabIndex = 51
        '
        'MinAlertQtyTxt
        '
        Me.MinAlertQtyTxt.Location = New System.Drawing.Point(104, 256)
        Me.MinAlertQtyTxt.Name = "MinAlertQtyTxt"
        Me.MinAlertQtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MinAlertQtyTxt.Properties.MaxLength = 50
        Me.MinAlertQtyTxt.Size = New System.Drawing.Size(160, 19)
        Me.MinAlertQtyTxt.TabIndex = 50
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label30.Location = New System.Drawing.Point(268, 256)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 24)
        Me.Label30.TabIndex = 49
        Me.Label30.Text = "Max. Alert Qty :"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label31.Location = New System.Drawing.Point(16, 256)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 24)
        Me.Label31.TabIndex = 48
        Me.Label31.Text = "Min. Alert Qty :"
        '
        'ColorCmb
        '
        Me.ColorCmb.Location = New System.Drawing.Point(352, 208)
        Me.ColorCmb.Name = "ColorCmb"
        Me.ColorCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ColorCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ColorCmb.Properties.LookUpData.KeyValue = ""
        Me.ColorCmb.Properties.NullString = """"""
        Me.ColorCmb.Properties.PopupWidth = 160
        Me.ColorCmb.Size = New System.Drawing.Size(160, 19)
        Me.ColorCmb.TabIndex = 47
        '
        'MaterialCmb
        '
        Me.MaterialCmb.Location = New System.Drawing.Point(104, 208)
        Me.MaterialCmb.Name = "MaterialCmb"
        Me.MaterialCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MaterialCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialCmb.Properties.LookUpData.KeyValue = ""
        Me.MaterialCmb.Properties.NullString = """"""
        Me.MaterialCmb.Properties.PopupWidth = 160
        Me.MaterialCmb.Size = New System.Drawing.Size(160, 19)
        Me.MaterialCmb.TabIndex = 46
        '
        'LeadTimeTxt
        '
        Me.LeadTimeTxt.Location = New System.Drawing.Point(104, 184)
        Me.LeadTimeTxt.Name = "LeadTimeTxt"
        Me.LeadTimeTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LeadTimeTxt.Properties.MaxLength = 50
        Me.LeadTimeTxt.Size = New System.Drawing.Size(160, 19)
        Me.LeadTimeTxt.TabIndex = 45
        '
        'GradeTxt
        '
        Me.GradeTxt.Location = New System.Drawing.Point(352, 184)
        Me.GradeTxt.Name = "GradeTxt"
        Me.GradeTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GradeTxt.Properties.MaxLength = 50
        Me.GradeTxt.Size = New System.Drawing.Size(160, 19)
        Me.GradeTxt.TabIndex = 44
        '
        'ModelTxt
        '
        Me.ModelTxt.Location = New System.Drawing.Point(352, 136)
        Me.ModelTxt.Name = "ModelTxt"
        Me.ModelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ModelTxt.Properties.MaxLength = 50
        Me.ModelTxt.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.ModelTxt.Size = New System.Drawing.Size(160, 19)
        Me.ModelTxt.TabIndex = 43
        '
        'AltDimTxt
        '
        Me.AltDimTxt.Location = New System.Drawing.Point(352, 232)
        Me.AltDimTxt.Name = "AltDimTxt"
        Me.AltDimTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AltDimTxt.Properties.MaxLength = 50
        Me.AltDimTxt.Size = New System.Drawing.Size(160, 19)
        Me.AltDimTxt.TabIndex = 42
        '
        'DimTxt
        '
        Me.DimTxt.Location = New System.Drawing.Point(104, 232)
        Me.DimTxt.Name = "DimTxt"
        Me.DimTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DimTxt.Properties.MaxLength = 50
        Me.DimTxt.Size = New System.Drawing.Size(160, 19)
        Me.DimTxt.TabIndex = 40
        '
        'AltDescTxt
        '
        Me.AltDescTxt.Location = New System.Drawing.Point(104, 88)
        Me.AltDescTxt.Name = "AltDescTxt"
        Me.AltDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AltDescTxt.Properties.MaxLength = 250
        Me.AltDescTxt.Size = New System.Drawing.Size(412, 40)
        Me.AltDescTxt.TabIndex = 38
        '
        'DescTxt
        '
        Me.DescTxt.Location = New System.Drawing.Point(104, 40)
        Me.DescTxt.Name = "DescTxt"
        Me.DescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescTxt.Properties.MaxLength = 250
        Me.DescTxt.Size = New System.Drawing.Size(412, 40)
        Me.DescTxt.TabIndex = 37
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(104, 16)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NameTxt.Properties.MaxLength = 100
        Me.NameTxt.Size = New System.Drawing.Size(200, 19)
        Me.NameTxt.TabIndex = 36
        '
        'BrandCmb
        '
        Me.BrandCmb.Location = New System.Drawing.Point(104, 136)
        Me.BrandCmb.Name = "BrandCmb"
        Me.BrandCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BrandCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.BrandCmb.Properties.NullString = ""
        Me.BrandCmb.Properties.PopupWidth = 160
        Me.BrandCmb.Size = New System.Drawing.Size(160, 19)
        Me.BrandCmb.TabIndex = 35
        '
        'UOMCmb
        '
        Me.UOMCmb.Location = New System.Drawing.Point(104, 160)
        Me.UOMCmb.Name = "UOMCmb"
        Me.UOMCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.UOMCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.UOMCmb.Properties.LookUpData.KeyValue = ""
        Me.UOMCmb.Properties.NullString = """"""
        Me.UOMCmb.Properties.PopupWidth = 160
        Me.UOMCmb.Size = New System.Drawing.Size(160, 19)
        Me.UOMCmb.TabIndex = 33
        '
        'PowerCoatChk
        '
        Me.PowerCoatChk.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.PowerCoatChk.Location = New System.Drawing.Point(320, 280)
        Me.PowerCoatChk.Name = "PowerCoatChk"
        Me.PowerCoatChk.Size = New System.Drawing.Size(104, 16)
        Me.PowerCoatChk.TabIndex = 28
        Me.PowerCoatChk.Text = "To Power Coat"
        '
        'StdChk
        '
        Me.StdChk.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.StdChk.Location = New System.Drawing.Point(224, 280)
        Me.StdChk.Name = "StdChk"
        Me.StdChk.Size = New System.Drawing.Size(80, 16)
        Me.StdChk.TabIndex = 27
        Me.StdChk.Text = "Std Part"
        '
        'KeepStkRd2
        '
        Me.KeepStkRd2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.KeepStkRd2.Location = New System.Drawing.Point(152, 280)
        Me.KeepStkRd2.Name = "KeepStkRd2"
        Me.KeepStkRd2.Size = New System.Drawing.Size(40, 16)
        Me.KeepStkRd2.TabIndex = 26
        Me.KeepStkRd2.Text = "No"
        '
        'KeepStkRd1
        '
        Me.KeepStkRd1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.KeepStkRd1.Location = New System.Drawing.Point(104, 280)
        Me.KeepStkRd1.Name = "KeepStkRd1"
        Me.KeepStkRd1.Size = New System.Drawing.Size(56, 16)
        Me.KeepStkRd1.TabIndex = 25
        Me.KeepStkRd1.Text = "Yes"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label14.Location = New System.Drawing.Point(24, 280)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 24)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Keep Stock :"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label13.Location = New System.Drawing.Point(16, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 24)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "* Unit Measure :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label12.Location = New System.Drawing.Point(280, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Grade :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label11.Location = New System.Drawing.Point(16, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Lead Time :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label10.Location = New System.Drawing.Point(280, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Model :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label9.Location = New System.Drawing.Point(16, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Brand :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label8.Location = New System.Drawing.Point(280, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Alt Dimension :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label7.Location = New System.Drawing.Point(16, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Dimension :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label6.Location = New System.Drawing.Point(280, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Color :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label5.Location = New System.Drawing.Point(16, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Material :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alternate Description :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "* Description :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "* Part No. :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RapturingCapacityTxt2)
        Me.TabPage2.Controls.Add(Me.TrippingRatingTxt2)
        Me.TabPage2.Controls.Add(Me.FrameSizeTxt2)
        Me.TabPage2.Controls.Add(Me.DescTxt2)
        Me.TabPage2.Controls.Add(Me.ModelTxt2)
        Me.TabPage2.Controls.Add(Me.NameTxt2)
        Me.TabPage2.Controls.Add(Me.UOMCmb2)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.CodeTempCmb2)
        Me.TabPage2.Controls.Add(Me.PolesCmb2)
        Me.TabPage2.Controls.Add(Me.PhyTypeCmb2)
        Me.TabPage2.Controls.Add(Me.ShuntTripCmb2)
        Me.TabPage2.Controls.Add(Me.MechTechCmb2)
        Me.TabPage2.Controls.Add(Me.BrandCmb2)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(0, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Selected = False
        Me.TabPage2.Size = New System.Drawing.Size(536, 303)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Title = "Template 2"
        '
        'RapturingCapacityTxt2
        '
        Me.RapturingCapacityTxt2.Location = New System.Drawing.Point(416, 272)
        Me.RapturingCapacityTxt2.Name = "RapturingCapacityTxt2"
        Me.RapturingCapacityTxt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RapturingCapacityTxt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RapturingCapacityTxt2.Size = New System.Drawing.Size(104, 19)
        Me.RapturingCapacityTxt2.TabIndex = 54
        Me.RapturingCapacityTxt2.Text = "0"
        '
        'TrippingRatingTxt2
        '
        Me.TrippingRatingTxt2.Location = New System.Drawing.Point(136, 272)
        Me.TrippingRatingTxt2.Name = "TrippingRatingTxt2"
        Me.TrippingRatingTxt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TrippingRatingTxt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TrippingRatingTxt2.Size = New System.Drawing.Size(104, 19)
        Me.TrippingRatingTxt2.TabIndex = 53
        Me.TrippingRatingTxt2.Text = "0"
        '
        'FrameSizeTxt2
        '
        Me.FrameSizeTxt2.Location = New System.Drawing.Point(136, 248)
        Me.FrameSizeTxt2.Name = "FrameSizeTxt2"
        Me.FrameSizeTxt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.FrameSizeTxt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FrameSizeTxt2.Size = New System.Drawing.Size(104, 19)
        Me.FrameSizeTxt2.TabIndex = 52
        Me.FrameSizeTxt2.Text = "0"
        '
        'DescTxt2
        '
        Me.DescTxt2.Location = New System.Drawing.Point(136, 56)
        Me.DescTxt2.Name = "DescTxt2"
        Me.DescTxt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescTxt2.Properties.MaxLength = 250
        Me.DescTxt2.Size = New System.Drawing.Size(312, 40)
        Me.DescTxt2.TabIndex = 51
        '
        'ModelTxt2
        '
        Me.ModelTxt2.Location = New System.Drawing.Point(136, 32)
        Me.ModelTxt2.Name = "ModelTxt2"
        Me.ModelTxt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ModelTxt2.Properties.MaxLength = 50
        Me.ModelTxt2.Size = New System.Drawing.Size(160, 19)
        Me.ModelTxt2.TabIndex = 50
        '
        'NameTxt2
        '
        Me.NameTxt2.Location = New System.Drawing.Point(136, 8)
        Me.NameTxt2.Name = "NameTxt2"
        Me.NameTxt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NameTxt2.Properties.MaxLength = 100
        Me.NameTxt2.Size = New System.Drawing.Size(200, 19)
        Me.NameTxt2.TabIndex = 49
        '
        'UOMCmb2
        '
        Me.UOMCmb2.Location = New System.Drawing.Point(136, 128)
        Me.UOMCmb2.Name = "UOMCmb2"
        Me.UOMCmb2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.UOMCmb2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.UOMCmb2.Properties.LookUpData.KeyValue = ""
        Me.UOMCmb2.Properties.NullString = """"""
        Me.UOMCmb2.Properties.PopupWidth = 160
        Me.UOMCmb2.Size = New System.Drawing.Size(136, 19)
        Me.UOMCmb2.TabIndex = 48
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label29.Location = New System.Drawing.Point(24, 128)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(88, 24)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "* Unit Measure :"
        '
        'CodeTempCmb2
        '
        Me.CodeTempCmb2.Location = New System.Drawing.Point(136, 152)
        Me.CodeTempCmb2.Name = "CodeTempCmb2"
        Me.CodeTempCmb2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CodeTempCmb2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CodeTempCmb2.Properties.NullString = ""
        Me.CodeTempCmb2.Size = New System.Drawing.Size(136, 19)
        Me.CodeTempCmb2.TabIndex = 46
        '
        'PolesCmb2
        '
        Me.PolesCmb2.Location = New System.Drawing.Point(136, 176)
        Me.PolesCmb2.Name = "PolesCmb2"
        Me.PolesCmb2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PolesCmb2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PolesCmb2.Properties.NullString = ""
        Me.PolesCmb2.Properties.PopupWidth = 160
        Me.PolesCmb2.Size = New System.Drawing.Size(136, 19)
        Me.PolesCmb2.TabIndex = 45
        '
        'PhyTypeCmb2
        '
        Me.PhyTypeCmb2.Location = New System.Drawing.Point(392, 224)
        Me.PhyTypeCmb2.Name = "PhyTypeCmb2"
        Me.PhyTypeCmb2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PhyTypeCmb2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PhyTypeCmb2.Properties.NullString = ""
        Me.PhyTypeCmb2.Size = New System.Drawing.Size(128, 19)
        Me.PhyTypeCmb2.TabIndex = 44
        '
        'ShuntTripCmb2
        '
        Me.ShuntTripCmb2.Location = New System.Drawing.Point(136, 200)
        Me.ShuntTripCmb2.Name = "ShuntTripCmb2"
        Me.ShuntTripCmb2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ShuntTripCmb2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ShuntTripCmb2.Properties.NullString = ""
        Me.ShuntTripCmb2.Properties.PopupWidth = 160
        Me.ShuntTripCmb2.Size = New System.Drawing.Size(136, 19)
        Me.ShuntTripCmb2.TabIndex = 43
        '
        'MechTechCmb2
        '
        Me.MechTechCmb2.Location = New System.Drawing.Point(136, 224)
        Me.MechTechCmb2.Name = "MechTechCmb2"
        Me.MechTechCmb2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MechTechCmb2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MechTechCmb2.Properties.NullString = ""
        Me.MechTechCmb2.Properties.PopupWidth = 160
        Me.MechTechCmb2.Size = New System.Drawing.Size(136, 19)
        Me.MechTechCmb2.TabIndex = 42
        '
        'BrandCmb2
        '
        Me.BrandCmb2.Location = New System.Drawing.Point(136, 104)
        Me.BrandCmb2.Name = "BrandCmb2"
        Me.BrandCmb2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BrandCmb2.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.BrandCmb2.Properties.NullString = ""
        Me.BrandCmb2.Properties.PopupWidth = 160
        Me.BrandCmb2.Size = New System.Drawing.Size(136, 19)
        Me.BrandCmb2.TabIndex = 41
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(304, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 23)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "Physical Type :"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(24, 224)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 24)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Mechanism Type :"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(24, 200)
        Me.Label24.Name = "Label24"
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Shunt Trip :"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(24, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "* Brand :"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(304, 272)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 23)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Rapturing Capacity :"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(24, 272)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 16)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Tripping Rating :"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(24, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 24)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Frame Size :"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(24, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 24)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "No Of Poles :"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(24, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Code Template :"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(24, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Description :"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(24, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "* Part No. :"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(24, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "* Model :"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(200, 661)
        Me.Splitter1.TabIndex = 33
        Me.Splitter1.TabStop = False
        '
        'CategoryTree
        '
        Me.CategoryTree.ImageIndex = -1
        Me.CategoryTree.Location = New System.Drawing.Point(16, 40)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.SelectedImageIndex = -1
        Me.CategoryTree.Size = New System.Drawing.Size(160, 172)
        Me.CategoryTree.TabIndex = 34
        '
        'ProductList
        '
        Me.ProductList.HorizontalScrollbar = True
        Me.ProductList.Location = New System.Drawing.Point(16, 236)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(160, 160)
        Me.ProductList.TabIndex = 35
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(16, 220)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(152, 16)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "Parts / Products List"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(16, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "Category List"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(304, 608)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(80, 24)
        Me.SaveBtn.TabIndex = 39
        Me.SaveBtn.Text = "Save"
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
        '
        'SupplierGrp
        '
        Me.SupplierGrp.Controls.Add(Me.RemoveSupBtn)
        Me.SupplierGrp.Controls.Add(Me.GridControl)
        Me.SupplierGrp.Controls.Add(Me.AddSupplierBtn)
        Me.SupplierGrp.Location = New System.Drawing.Point(216, 408)
        Me.SupplierGrp.Name = "SupplierGrp"
        Me.SupplierGrp.Size = New System.Drawing.Size(536, 192)
        Me.SupplierGrp.TabIndex = 43
        Me.SupplierGrp.TabStop = False
        Me.SupplierGrp.Text = "Supplier List"
        '
        'RemoveSupBtn
        '
        Me.RemoveSupBtn.AutoSize = False
        Me.RemoveSupBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RemoveSupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSupBtn.Image = Nothing
        Me.RemoveSupBtn.Location = New System.Drawing.Point(120, 160)
        Me.RemoveSupBtn.Name = "RemoveSupBtn"
        Me.RemoveSupBtn.Size = New System.Drawing.Size(88, 24)
        Me.RemoveSupBtn.TabIndex = 45
        Me.RemoveSupBtn.Text = "Delete"
        '
        'GridControl
        '
        Me.GridControl.EditorsRepository = Me.PersistentRepository1
        Me.GridControl.Location = New System.Drawing.Point(8, 24)
        Me.GridControl.MainView = Me.GridView1
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(520, 128)
        Me.GridControl.TabIndex = 44
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        '
        'AddSupplierBtn
        '
        Me.AddSupplierBtn.AutoSize = False
        Me.AddSupplierBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddSupplierBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSupplierBtn.Image = Nothing
        Me.AddSupplierBtn.Location = New System.Drawing.Point(16, 160)
        Me.AddSupplierBtn.Name = "AddSupplierBtn"
        Me.AddSupplierBtn.Size = New System.Drawing.Size(96, 24)
        Me.AddSupplierBtn.TabIndex = 43
        Me.AddSupplierBtn.Text = "Add Supplier"
        '
        'AddBut
        '
        Me.AddBut.AutoSize = False
        Me.AddBut.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBut.Image = Nothing
        Me.AddBut.Location = New System.Drawing.Point(216, 608)
        Me.AddBut.Name = "AddBut"
        Me.AddBut.Size = New System.Drawing.Size(80, 24)
        Me.AddBut.TabIndex = 44
        Me.AddBut.Text = "New Product"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(400, 608)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 24)
        Me.CloseBtn.TabIndex = 45
        Me.CloseBtn.Text = "&Close"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ModelSearch)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.DescSearch2)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.DescSearch)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.BrandSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.SearchBtn)
        Me.GroupBox3.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 64)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Search"
        '
        'ModelSearch
        '
        Me.ModelSearch.Location = New System.Drawing.Point(296, 40)
        Me.ModelSearch.Name = "ModelSearch"
        Me.ModelSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ModelSearch.Size = New System.Drawing.Size(176, 19)
        Me.ModelSearch.TabIndex = 81
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(248, 40)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 80
        Me.Label36.Text = "Model:"
        '
        'DescSearch2
        '
        Me.DescSearch2.Location = New System.Drawing.Point(400, 16)
        Me.DescSearch2.Name = "DescSearch2"
        Me.DescSearch2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch2.Size = New System.Drawing.Size(72, 19)
        Me.DescSearch2.TabIndex = 79
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(360, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 16)
        Me.Label35.TabIndex = 78
        Me.Label35.Text = "and"
        '
        'DescSearch
        '
        Me.DescSearch.Location = New System.Drawing.Point(288, 16)
        Me.DescSearch.Name = "DescSearch"
        Me.DescSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescSearch.Size = New System.Drawing.Size(72, 19)
        Me.DescSearch.TabIndex = 77
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(248, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 76
        Me.Label34.Text = "Desc:"
        '
        'BrandSearchTxt
        '
        Me.BrandSearchTxt.Location = New System.Drawing.Point(136, 40)
        Me.BrandSearchTxt.Name = "BrandSearchTxt"
        Me.BrandSearchTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BrandSearchTxt.Size = New System.Drawing.Size(104, 19)
        Me.BrandSearchTxt.TabIndex = 75
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(10, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(112, 16)
        Me.Label32.TabIndex = 74
        Me.Label32.Text = "Brand :"
        '
        'SearchBtn
        '
        Me.SearchBtn.AutoSize = False
        Me.SearchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Image = Nothing
        Me.SearchBtn.Location = New System.Drawing.Point(480, 16)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(48, 32)
        Me.SearchBtn.TabIndex = 73
        Me.SearchBtn.Text = "Search"
        '
        'ProductSearchTxt
        '
        Me.ProductSearchTxt.Location = New System.Drawing.Point(136, 18)
        Me.ProductSearchTxt.Name = "ProductSearchTxt"
        Me.ProductSearchTxt.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.ProductSearchTxt.Size = New System.Drawing.Size(104, 17)
        Me.ProductSearchTxt.TabIndex = 72
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(10, 20)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(134, 20)
        Me.Label33.TabIndex = 71
        Me.Label33.Text = "Type Product ID/Code :"
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(56, 12)
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.ReadOnly = True
        Me.CategoryTxt.Size = New System.Drawing.Size(120, 20)
        Me.CategoryTxt.TabIndex = 79
        Me.CategoryTxt.Text = "Category Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Category :"
        '
        'ManageProductForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(808, 661)
        Me.Controls.Add(Me.CategoryTxt)
        Me.Controls.Add(Me.TemplateCtr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.AddBut)
        Me.Controls.Add(Me.SupplierGrp)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.Splitter1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "ManageProductForm"
        Me.Text = "Manage Parts / Products"
        Me.TemplateCtr.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.CatCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxAlertQtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinAlertQtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeadTimeTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltDimTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DimTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOMCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.RapturingCapacityTxt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrippingRatingTxt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameSizeTxt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescTxt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTxt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTxt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOMCmb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTempCmb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PolesCmb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhyTypeCmb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShuntTripCmb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MechTechCmb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandCmb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierGrp.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ModelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    'Dim Supplier_ID As Integer
    'Dim Catalog_Price As Integer
    'Dim Enquiry_Price As Integer
    'Dim Purchase_Price As Integer

    Public Product_ID As Integer
    Public varName As String
    Public Description As String
    Public Alt_Description As String
    Public Material As Integer 'was Public Material As String
    Public Color As Integer 'was Public Color As String
    Public Dimension As String
    Public Alt_Dimension As String
    Public Brand As Integer 'was Public Brand As String
    Public Category As Integer
    Public Model As String
    Public Lead_Time As String
    Public Grade As String
    Public UOM_ID As Integer
    Public Length As Integer
    Public Breadth As Integer
    Public Thickness As Integer

    Public Category_ID As Integer
    Public Keep_Stock As String
    Public Std_Part As String
    Public Powder_Coat As String
    Public Code_Template As String
    Public Pole As Integer
    Public Frame_Size As Integer
    Public Tripping_Rating As Integer
    Public Rapturing_Capacity As Integer
    Public Shunt_Trip As String
    Public Mech_Type As String
    Public Physical_Type As String
    Public Status As String
    Public Low_Alert_Qty As Integer
    Public Over_Alert_Qty As Integer
    Public Raw_Material As String
    Public Create_Date As String
    Public Transact_Date As DateTime
    Public UserID As String = Common.CommonConn.Config.USERID

    Dim data = New DataTable("ColumnsTable")

#End Region

    ' 11.01.2004 YG Start
    Dim FunctionName As String = "MyParts"
    Dim NextScreen As String = "PartSupplier"
    ' 11.01.2004 YG End

#Region " Code - Loading"

    Private Sub ManageProductForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserID = Common.CommonConn.Config.USERID

        ' 11.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm '(Me.ParentForm)

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            AddBut.Enabled = True
        Else
            AddBut.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If a.com.CheckUserProfileInsert(a.com, NextScreen) Then
            AddSupplierBtn.Enabled = True
        Else
            AddSupplierBtn.Enabled = False
        End If

        If a.com.CheckUserProfileDelete(a.com, NextScreen) Then
            RemoveSupBtn.Enabled = True
        Else
            RemoveSupBtn.Enabled = False
        End If

        ' 11.01.2004 YG End

        Me.Cursor = Cursors.WaitCursor

        LoadCategoryList()

        InitSupplierList()

        TemplateCtr.Enabled = False

        'Load all combo
        LoadUMO()
        LoadBrand()
        LoadCategory()
        LoadMaterial()
        LoadColor()

        'Template 2
        LoadMechType()
        LoadShuntTrip()
        LoadPhysicalType()
        LoadCodeTemplate()
        LoadNoPoles()

        TemplateCtr.IDEPixelBorder = True
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub LoadUMO()
        Dim ds As DataSet

        'Load unit of measurement details.
        With New BusinessRules.ManProdBusRules.ManProdBusLogic

            If .GetUnitMeasurement(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'Template 1
                        UOMCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(UOMCmb, "Name", 200, 0, "")

                        UOMCmb.Properties.LookUpData.KeyField = "UOM_ID"
                        UOMCmb.Properties.LookUpData.DisplayField = "Name"
                        UOMCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                        'Template 2
                        UOMCmb2.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(UOMCmb2, "Name", 200, 0, "")

                        UOMCmb2.Properties.LookUpData.KeyField = "UOM_ID"
                        UOMCmb2.Properties.LookUpData.DisplayField = "Name"
                        UOMCmb2.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load unit of measurement details
    End Sub

    'add by alan
    Private Sub LoadBrand()
        Dim ds As DataSet

        'Load Brand details.
        With New BusinessRules.ManProdBusRules.ManProdBusLogic

            If .GetBrand(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'Template 1
                        BrandCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(BrandCmb, "Brand_Name", 200, 0, "")
                        '## Edited by Andrew
                        BrandCmb.Properties.LookUpData.KeyField = "Brand_ID"
                        '## End
                        BrandCmb.Properties.LookUpData.DisplayField = "Brand_Name"
                        BrandCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                        'Template 2
                        BrandCmb2.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(BrandCmb2, "Brand_Name", 200, 0, "")
                        '## Edited by Andrew
                        BrandCmb2.Properties.LookUpData.KeyField = "Brand_ID"
                        '## End
                        BrandCmb2.Properties.LookUpData.DisplayField = "Brand_Name"
                        BrandCmb2.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadCategory()
        Dim ds As DataSet

        'Load Brand details.
        With New BusinessRules.CategoryBusRules.CategoryBusLogic
            If .GetCategory(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'Template 1
                        CatCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(CatCmb, "Name", 200, 0, "")
                        '## Edited by Andrew
                        CatCmb.Properties.LookUpData.KeyField = "Category_ID"
                        '## End
                        CatCmb.Properties.LookUpData.DisplayField = "Name"
                        CatCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadMaterial()
        Dim ds As DataSet

        With New BusinessRules.ManProdBusRules.ManProdBusLogic

            If .GetMaterial(ds) Then
                If Not ds Is Nothing Then
                    Try

                        MaterialCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(MaterialCmb, "Material_Name", 200, 0, "")
                        '## Edited by Andrew
                        MaterialCmb.Properties.LookUpData.KeyField = "Material_ID"
                        '## End
                        MaterialCmb.Properties.LookUpData.DisplayField = "Material_Name"
                        MaterialCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadColor()
        Dim ds As DataSet

        With New BusinessRules.ManProdBusRules.ManProdBusLogic

            If .GetColor(ds) Then
                If Not ds Is Nothing Then
                    Try

                        ColorCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(ColorCmb, "Color_Name", 200, 0, "")
                        '## Edited by Andrew
                        ColorCmb.Properties.LookUpData.KeyField = "Color_ID"
                        '## End
                        ColorCmb.Properties.LookUpData.DisplayField = "Color_Name"
                        ColorCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub LoadMechType()
        Dim mechData As String() = New String() {"", "Mortorized", "Manual"}

        SetComboValue(mechData, MechTechCmb2, Nothing)
    End Sub

    Private Sub LoadShuntTrip()
        Dim shuntTripData As String() = New String() {"", "With", "Without"}

        SetComboValue(shuntTripData, ShuntTripCmb2, Nothing)
    End Sub

    Private Sub LoadPhysicalType()
        Dim typeData As String() = New String() {"", "Normal", "Compact"}

        SetComboValue(typeData, PhyTypeCmb2, Nothing)

    End Sub

    Private Sub LoadCodeTemplate()
        Dim codeData As String() = New String() {"", "ACB - AC", "MCB - MC", "MCCB - MCC", "Concrete base - CB"}

        SetComboValue(codeData, CodeTempCmb2, Nothing)
    End Sub

    Private Sub LoadNoPoles()
        Dim polesData As String() = New String() {"", "2", "3", "4"}
        Dim idData As String() = New String() {"", "2", "3", "4"}

        SetComboValue(polesData, PolesCmb2, idData)
    End Sub

    Private Sub ClearAll()

        'For template 1
        NameTxt.Text = ""
        ModelTxt.Text = ""
        DescTxt.Text = ""
        AltDescTxt.Text = ""

        BrandCmb.Properties.LookUpData.KeyValue = ""
        UOMCmb.Properties.LookUpData.KeyValue = ""
        MaterialCmb.Properties.LookUpData.KeyValue = ""
        ColorCmb.Properties.LookUpData.KeyValue = ""
        DimTxt.Text = ""
        AltDimTxt.Text = ""
        LeadTimeTxt.Text = ""
        GradeTxt.Text = ""
        '## Added by Andrew
        MinAlertQtyTxt.Text = ""
        MaxAlertQtyTxt.Text = ""
        '## End

        KeepStkRd1.Checked = False
        KeepStkRd2.Checked = False

        StdChk.Checked = False
        StdChk.Checked = False

        PowerCoatChk.Checked = False
        PowerCoatChk.Checked = False

        RawMaterialChk.Checked = False

        'For Template 2
        NameTxt2.Text = ""
        ModelTxt2.Text = ""
        DescTxt2.Text = ""
        CodeTempCmb2.Properties.LookUpData.KeyValue = ""
        PolesCmb2.Properties.LookUpData.KeyValue = ""

        FrameSizeTxt2.Text = ""
        TrippingRatingTxt2.Text = ""
        RapturingCapacityTxt2.Text = ""
        ShuntTripCmb2.Properties.LookUpData.KeyValue = ""
        MechTechCmb2.Properties.LookUpData.KeyValue = ""
        PhyTypeCmb2.Properties.LookUpData.KeyValue = ""
        UOMCmb2.Properties.LookUpData.KeyValue = ""
        BrandCmb2.Properties.LookUpData.KeyValue = ""

        varName = ""
        Description = ""
        Alt_Description = ""
        Material = -1
        Color = -1
        Dimension = ""
        Alt_Dimension = ""
        Brand = -1
        Model = ""
        Lead_Time = ""
        Grade = ""
        UOM_ID = -1
        Keep_Stock = ""
        Std_Part = ""
        Powder_Coat = ""
        Raw_Material = ""

        ClearGrid(GridView1)
    End Sub

    Private Sub ClearComboBox(ByVal ComboBoxName As DevExpress.XtraEditors.LookUpEdit)
        Dim EmptyData As String() = New String() {""}

        SetComboValue(EmptyData, ComboBoxName, Nothing)
    End Sub

#End Region

#Region " Code - Category tree list"
    'For Category Portion

    Private Sub LoadCategoryList()
        Dim node As TreeNode
        Dim Root As TreeNode = New TreeNode("Category")

        Root.Nodes.Clear()
        CategoryTree.Nodes.Clear()
        CategoryTree.Nodes.Add(Root)
        With New BusinessRules.CategoryBusRules.CategoryBusLogic
            Dim dsCategory As DataSet
            If .GetCategory(dsCategory) Then
                If (dsCategory.Tables(0).Rows.Count > 0) Then
                    Dim pk, fk As DataColumn
                    pk = dsCategory.Tables(0).Columns(0)
                    fk = dsCategory.Tables(0).Columns(2)

                    dsCategory.Relations.Add(New DataRelation("ParentCategoryRelation", pk, fk, False))
                    Dim dr As DataRow = dsCategory.Tables(0).Rows(0)

                    Dim oRow2 As DataRow
                    For Each oRow2 In dsCategory.Tables(0).Rows
                        If oRow2("Thread_Level") = 1 Then
                            doCatePopulate(node, oRow2, dsCategory.Relations(0))
                            Root.Nodes.Add(node)
                        End If
                    Next
                End If
            End If
        End With
        CategoryTree.CollapseAll()
        CategoryTree.SelectedNode = Root
        'CategoryTree.ExpandAll()
    End Sub

    Private Sub doCatePopulate(ByRef Node As TreeNode, ByVal dr As DataRow, ByVal rel As DataRelation)
        'dr(4) - column 4 is Category Name
        Node = New TreeNode(dr(4).ToString(), 0, 0)
        Node.Tag = dr(0)

        Dim Row As DataRow
        For Each Row In dr.GetChildRows(rel)
            Dim newNode As TreeNode = New TreeNode
            doCatePopulate(newNode, Row, rel)
            Node.Nodes.Add(newNode)
        Next
    End Sub

#End Region

#Region " Code - Database Management"

    'After category click, load product list
    Private Sub RefreshProductList(ByVal pCategoryID As Integer)
        Dim ds As DataSet
        'Load product list
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .LoadList(ds, pCategoryID) Then
                If Not ds Is Nothing Then
                    Try
                        ProductList.DisplayMember = "Name"
                        ProductList.ValueMember = "Product_ID"

                        ProductList.DataSource = ds.Tables(0)

                        'Check if there is list of product
                        If ds.Tables(0).Rows.Count > 0 Then
                            TemplateCtr.Enabled = True
                            SupplierGrp.Enabled = True
                            Dim a As MainForm = Me.ParentForm

                            If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
                                AddBut.Enabled = True
                            Else
                                AddBut.Enabled = False
                            End If

                            '            SaveBtn.Enabled = True

                            If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
                                SaveBtn.Enabled = True
                            Else
                                SaveBtn.Enabled = False
                            End If
                            ' 11.01.2004 YG End
                            ModifyProduct()
                        Else
                            ClearAll()

                            TemplateCtr.Enabled = False
                            SupplierGrp.Enabled = False
                            If Category_ID = 0 Then
                                AddBut.Enabled = False
                            End If
                            SaveBtn.Enabled = False

                            End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load product list
    End Sub

    Private Sub LoadProductInfo(ByVal pProductID As String)

        Dim ds As DataSet
        'Load products details
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .Load(pProductID) Then
                
                varName = .Name
                Description = .Description
                Alt_Description = .Alt_Description
                Material = .Material
                Color = .Color
                Dimension = .Dimension
                Alt_Dimension = .Alt_Dimension
                Category = .Category_ID
                Brand = .Brand
                Model = .Model
                Lead_Time = .Lead_Time
                Grade = .Grade
                UOM_ID = .UOM_ID
                Length = .Length
                Breadth = .Breadth
                Thickness = .Thickness
                'Catalog_Price = .Catalog_Price
                'Enquiry_Price = .Enquiry_Price
                'Purchase_Price = .Purchase_Price
                Category_ID = .Category_ID
                'Supplier_ID = .Supplier_ID
                Keep_Stock = .Keep_Stock
                Std_Part = .Std_Part
                Powder_Coat = .Powder_Coat
                Code_Template = .Code_Template
                Pole = .Pole
                Frame_Size = .Frame_Size
                Tripping_Rating = .Tripping_Rating
                Rapturing_Capacity = .Rapturing_Capacity
                Shunt_Trip = .Shunt_Trip
                Mech_Type = .Mech_Type
                Physical_Type = .Physical_Type
                Status = .Status

                If Status = "2" Then
                    Me.TemplateCtr.SelectedIndex = 1
                Else
                    Me.TemplateCtr.SelectedIndex = 0
                End If

                '## Added by Andrew
                Low_Alert_Qty = .Low_Alert_Qty
                Over_Alert_Qty = .Over_Alert_Qty
                Raw_Material = .Raw_Material
                '## End
                UserID = .UserID
            End If
        End With
        'End load product details

        LoadProdSupplier(Product_ID)

    End Sub

    'Call after product list click
    Private Sub ModifyProduct()
        SaveBtn.Text = "Update"
       
        If ProductList.Items.Count > 0 Then
            Product_ID = ProductList.SelectedValue.ToString
            LoadProductInfo(Product_ID)
            SetWindowsValue()
        End If
    End Sub

    'Call from save button
    Private Sub SaveProduct()

        GetWindowsValue()

        If ValidData() Then

            With New BusinessRules.ManProdBusRules.ManProdBusLogic

                .Name = varName
                .Status = Status
                .Description = Description
                .Category_ID = Category_ID
                '.Brand = Brand
                .Model = Model

                .Length = Nothing
                .Breadth = Nothing
                .Thickness = Nothing

                'To be confirm later
                '.Catalog_Price = Nothing
                '.Enquiry_Price = Nothing
                '.Purchase_Price = Nothing
                '.Supplier_ID = Nothing

                '## Added by Andrew
                If MinAlertQtyTxt.Text = "" Then
                    Low_Alert_Qty = 0
                Else
                    Low_Alert_Qty = CInt(MinAlertQtyTxt.Text)
                End If

                If MaxAlertQtyTxt.Text = "" Then
                    Over_Alert_Qty = 0
                Else
                    Over_Alert_Qty = CInt(MaxAlertQtyTxt.Text)
                End If

                .Low_Alert_Qty = Low_Alert_Qty
                .Over_Alert_Qty = Over_Alert_Qty
                '## End
                .Raw_Material = Raw_Material

                .UserID = UserID
                'Hard coded

                If Status = "1" Then
                    .Alt_Description = Alt_Description
                    .Material = Material
                    .Dimension = Dimension
                    .Alt_Dimension = Alt_Dimension
                    .Category_ID = Category
                    .Color = Color
                    .Brand = Brand
                    .Lead_Time = Lead_Time
                    .Grade = Grade
                    .UOM_ID = UOM_ID
                    .Keep_Stock = Keep_Stock
                    .Std_Part = Std_Part
                    .Powder_Coat = Powder_Coat
                    .Code_Template = ""
                    .Pole = Pole
                    .Frame_Size = 0
                    .Tripping_Rating = 0
                    .Rapturing_Capacity = 0
                    .Shunt_Trip = ""
                    .Mech_Type = ""
                    .Physical_Type = ""
                Else
                    .Alt_Description = ""
                    .Material = Material
                    .Dimension = ""
                    .Alt_Dimension = ""
                    .Color = Color
                    .Brand = Brand
                    .Category_ID = Category
                    .Lead_Time = ""
                    .Grade = ""
                    .UOM_ID = UOM_ID
                    .Keep_Stock = ""
                    .Std_Part = ""
                    .Powder_Coat = ""

                    .Code_Template = Code_Template
                    .Pole = Pole
                    .Frame_Size = Frame_Size
                    .Tripping_Rating = Tripping_Rating
                    .Rapturing_Capacity = Rapturing_Capacity
                    .Shunt_Trip = Shunt_Trip
                    .Mech_Type = Mech_Type
                    .Physical_Type = Physical_Type

                End If

                'A modified record will have product id
                If Product_ID = Nothing Then
                    'New Record
                    'If .RecordExists(varName) = False Then
                    Product_ID = .Save()

                    GetRecordFromGrid(Product_ID)

                    MessageBox.Show("Part/Product had been successfully created")
                    Dim OldCursor = Cursor.Current
                    Me.Cursor = Cursors.WaitCursor
                    RefreshProductList(Category_ID)
                    Me.Cursor = OldCursor
                    'Else
                    'MessageBox.Show("The Part code/Product name already existed!")
                    'End If
                Else
                    'Modify Current Record
                    .Update(Product_ID)

                    GetRecordFromGrid(Product_ID)

                    MessageBox.Show("Record had been updated")
                    Dim OldCursor = Cursor.Current
                    Me.Cursor = Cursors.WaitCursor
                    'RefreshProductList(Category_ID)
                    Me.Cursor = OldCursor
                End If

            End With
        End If

    End Sub

#End Region

#Region " Code - Windows Events"

    'Event for Category List
    Private Sub CategoryTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles CategoryTree.AfterSelect
        Dim CurrentTag
        Dim CurrentText

        CurrentTag = CategoryTree.SelectedNode.Tag
        CurrentText = CategoryTree.SelectedNode.Text()

        If CurrentTag <> Nothing Then

            'TemplateCtr.Enabled = True
            'SupplierGrp.Enabled = True
            ' 11.01.2004 YG Start
            '            AddBut.Enabled = True

            CategoryTxt.Text = CurrentText
            Category_ID = CurrentTag
            Dim OldCursor = Cursor.Current
            Me.Cursor = Cursors.WaitCursor
            RefreshProductList(Category_ID)
            Cursor = OldCursor
        Else

            Category_ID = 0
            CategoryTxt.Text = ""
            Dim OldCursor = Cursor.Current
            Me.Cursor = Cursors.WaitCursor
            RefreshProductList(Category_ID)
            Cursor = OldCursor
            'TemplateCtr.Enabled = False
            'SupplierGrp.Enabled = False
            'AddBut.Enabled = False
            'SaveBtn.Enabled = False

        End If
    End Sub

    'Product list click
    Private Sub ProductList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor

        ClearAll()
        ModifyProduct()

        SaveBtn.Visible = True
        Me.Cursor = Cursors.Default

    End Sub

    'Event for Tab Control
    Private Sub TemplateCtr_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplateCtr.SelectionChanged
        If TemplateCtr.SelectedIndex = 1 Then
            Status = "2"
        Else
            Status = "1"
        End If
    End Sub

    'New Product click
    Private Sub AddBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBut.Click
        If Category_ID = Nothing Or Category_ID = 0 Then
            MessageBox.Show("Please select a Category before proceeding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            SaveBtn.Text = "Save"
            SaveBtn.Enabled = True

            'Set default template to 1
            TemplateCtr.SelectedIndex = 0
            Product_ID = Nothing
            Status = "1"

            'Clear all values on form
            ClearComboBox(BrandCmb)
            ClearComboBox(UOMCmb)
            ClearComboBox(BrandCmb2)
            ClearComboBox(UOMCmb2)
            ClearComboBox(MaterialCmb)
            ClearComboBox(ColorCmb)
            ClearAll()
            LoadUMO()
            LoadBrand()
            LoadCategory()
            LoadMaterial()
            LoadColor()

            TemplateCtr.Enabled = True

            NameTxt.Focus()

        End If
    End Sub

    'Event for Save Button
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim OldCursor = Cursor.Current
        Me.Cursor = Cursors.WaitCursor

        SaveProduct()

        Me.Cursor = OldCursor
    End Sub

#End Region

#Region " Product Supplier Code"


#Region " Events "

    'Add Product Supplier
    Private Sub AddSupplierBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSupplierBtn.Click
        Dim Supplier_ID As Integer
        Dim Catalog_Price As Decimal
        Dim Enquiry_Price As Decimal
        Dim Purchase_Price As Decimal
        Dim Supplier_Name As String

        Dim form As New ManageProdSupForm(Me.ParentForm)

        form.Product_ID = Product_ID

        form.ShowDialog()

        If form.NewItem Then
            Supplier_ID = form.Supplier_ID
            Catalog_Price = form.Catalog_Price
            Enquiry_Price = form.Enquiry_Price
            Purchase_Price = form.Purchase_Price
            Supplier_Name = form.Supplier_Name
            Transact_Date = form.Transact_Date
            Transact_Date = Me.ChangeDateFormat(Transact_Date)

            'add rows
            data.Rows.Add(New Object() {0, Supplier_ID, Supplier_Name, Catalog_Price, Enquiry_Price, Purchase_Price, Transact_Date})

            GridControl.DataSource = data
            GridControl.MainView.PopulateColumns()
            GridView1.BestFitColumns()
            GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column
            GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column

            GridView1.FocusedRowHandle = 0
        End If

    End Sub

    'Remove Product Supplier
    Private Sub RemoveSupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSupBtn.Click
        If GridView1.SelectedRowsCount > 0 Then
            DeleteProdSup()
        End If
    End Sub

    'Delete Key entered
    Private Sub GridControl_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl.KeyUp
        If e.KeyCode = Keys.Delete Then
            DeleteProdSup()
        End If
    End Sub

    'Delete Product Supplier
    Private Sub DeleteProdSup()
        Dim selectedIndex As Integer
        selectedIndex = GridView1.GetSelectedRows(0)

        Dim i
        Dim dr As DataRow
        Dim items As Object()
        Dim ProductSupplier_ID

        dr = GridView1.GetDataRow(selectedIndex)
        items = dr.ItemArray

        ProductSupplier_ID = items(0)

        If ProductSupplier_ID <> 0 And ProductSupplier_ID <> Nothing Then
            'Update current value's HistoryRecord
            Dim ds As DataSet
            With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
                .UpdateHistoryRec(ProductSupplier_ID)
            End With
        End If

        GridView1.DeleteRow(selectedIndex)
    End Sub

#End Region

    Private Sub InitSupplierList()
        data.BeginInit()
        AddColumn(data, "ProductSupplier_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(data, "Supplier_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(data, "Supplier Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Catalog Price", System.Type.GetType("System.Double"), True)
        AddColumn(data, "Enquiry Price", System.Type.GetType("System.Double"), True)
        AddColumn(data, "Purchase Price", System.Type.GetType("System.Double"), True)
        AddColumn(data, "Date", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub LoadProdSupplier(ByVal pProductID As String)
        ClearGrid(GridView1)

        Dim ds As DataSet
        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            If .LoadList(ds, pProductID, "0") Then
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim tmpDate As String

                For Each oRow In ds.Tables(0).Rows

                    'If Not IsDBNull(oRow("Transact_Date")) Then
                    'tmpDate = Microsoft.VisualBasic.DateAndTime.Day(oRow("Transact_Date")) & "/" & Month(oRow("Transact_Date")) & "/" & Year(oRow("Transact_Date"))
                    'End If
                    'data.Rows.Add(New Object() {oRow("ProductSupplier_ID"), oRow("Supplier_ID"), oRow("Supplier_Name"), oRow("Catalog_Price"), oRow("Enquiry_Price"), oRow("Purchase_Price"), tmpDate})
                    data.Rows.Add(New Object() {oRow("ProductSupplier_ID"), oRow("Supplier_ID"), oRow("Supplier_Name"), oRow("Catalog_Price"), oRow("Enquiry_Price"), oRow("Purchase_Price"), ChangeDateFormat(oRow("Transact_Date"))})

                Next
            End If


            GridControl.DataSource = data
            GridControl.DefaultView.PopulateColumns()

            GridView1.BestFitColumns()
            GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column
            GridView1.Columns.Item(1).VisibleIndex = -1 'hide 1st column
        End With

    End Sub

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

    Private Sub GetRecordFromGrid(ByVal pProductID As String)
        Dim ProductSupplier_ID As Integer
        Dim Supplier_ID As Integer
        Dim Catalog_Price As Decimal
        Dim Enquiry_Price As Decimal
        Dim Purchase_Price As Decimal
        Dim Transact_Date As Date

        Dim i
        Dim dr As DataRow
        Dim items As Object()

        For i = 0 To GridView1.RowCount - 1
            dr = GridView1.GetDataRow(i)
            items = dr.ItemArray
            ProductSupplier_ID = items(0)
            Supplier_ID = items(1)
            Catalog_Price = items(3)
            Enquiry_Price = items(4)
            Purchase_Price = items(5)
            Transact_Date = items(6)

            With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
                'Update current value's HistoryRecord
                .Product_ID = pProductID
                .Supplier_ID = Supplier_ID
                .Catalog_Price = Catalog_Price
                .Enquiry_Price = Enquiry_Price
                .Purchase_Price = Purchase_Price
                .Transact_Date = Transact_Date
                .UserID = UserID

                If ProductSupplier_ID = 0 And ProductSupplier_ID = Nothing Then
                    ProductSupplier_ID = .RecordExists(pProductID, Supplier_ID, Transact_Date)
                    If ProductSupplier_ID <> Nothing And ProductSupplier_ID <> 0 Then
                        .Update(ProductSupplier_ID)
                    Else
                        .Save()
                    End If
                End If

            End With
        Next
    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If Category_ID = Nothing Then
            DataOK_flag = False
            MessageBox.Show("Please select a Category before proceeding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If varName = "" Then
                ErrorMessage = ErrorMessage & " Id" & Chr(13)
                DataOK_flag = False
            End If

            If Description = "" Then
                ErrorMessage = ErrorMessage & " Description" & Chr(13)
                DataOK_flag = False
            End If

            'If Brand = "" Then
            '           If Brand = -1 Then
            '                ErrorMessage = ErrorMessage & " Brand" & Chr(13)
            '                DataOK_flag = False
            '            End If

            ' YG 21.09.2003 Model not mandatory
            'If Model = "" Then
            '    ErrorMessage = ErrorMessage & " Model" & Chr(13)
            '    DataOK_flag = False
            'End If

            If UOM_ID = -1 Then
                ErrorMessage = ErrorMessage & " Unit Measure" & Chr(13)
                DataOK_flag = False
            End If

            If DataOK_flag = False Then

                With New Common.CommonError.ErrorMsg
                    MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End With
            Else

                With New BusinessRules.ManProdBusRules.ManProdBusLogic
                    If Product_ID <> Nothing And Product_ID <> 0 Then
                        If .RecordExists(varName, Product_ID) Then
                            MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Id", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            DataOK_flag = False
                        End If
                    Else
                        If .RecordExists(varName, Nothing) Then
                            MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Id", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            DataOK_flag = False
                        End If
                    End If

                End With

            End If
        End If

        Return DataOK_flag

    End Function

#End Region

#Region " Code - Set/Get Window Values"

    'For getting or setting windows values
    Private Sub SetWindowsValue()

        NameTxt.Text = varName
        ModelTxt.Text = Model
        DescTxt.Text = Description
        'remove by alan 11 sep 
        'If Brand <> "" Then
        'BrandCmb.Properties.LookUpData.KeyValue = Brand
        'End If

        NameTxt2.Text = varName
        ModelTxt2.Text = Model
        DescTxt2.Text = Description
        'remove by alan 11 sep 
        'If Brand <> "" Then
        'BrandCmb2.Properties.LookUpData.KeyValue = Brand
        'End If

        If Status = "1" Then
            AltDescTxt.Text = Alt_Description
            'MaterialTxt.Text = Material
            'ColorTxt.Text = Color
            DimTxt.Text = Dimension
            AltDimTxt.Text = Alt_Dimension
            LeadTimeTxt.Text = Lead_Time
            GradeTxt.Text = Grade
            '## Added by Andrew
            MinAlertQtyTxt.Text = Low_Alert_Qty
            MaxAlertQtyTxt.Text = Over_Alert_Qty
            '## End

            If Keep_Stock = "1" Then
                KeepStkRd1.Checked = True
            ElseIf Keep_Stock = "0" Then
                KeepStkRd2.Checked = True
            End If

            If Std_Part = "1" Then
                StdChk.Checked = True
            ElseIf Std_Part = "0" Then
                StdChk.Checked = False
            End If

            If Raw_Material = "1" Then
                RawMaterialChk.Checked = True
            ElseIf Std_Part = "0" Then
                RawMaterialChk.Checked = False
            End If

            If Powder_Coat = "1" Then
                PowerCoatChk.Checked = True
            ElseIf Powder_Coat = "0" Then
                PowerCoatChk.Checked = False
            End If

            TemplateCtr.SelectedIndex = 0
            If Category <> Nothing And Category <> 0 Then
                CatCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Category, 0, 0, 0})
            End If
            'add by alan
            If Brand <> Nothing And Brand <> 0 Then
                BrandCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Brand, 0, 0, 0})
            End If
            'end by alan
            If UOM_ID <> Nothing And UOM_ID <> 0 Then
                UOMCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {UOM_ID, 0, 0, 0}) 'UOM_ID
            End If
            If Material <> Nothing And Material <> 0 Then
                MaterialCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Material, 0, 0, 0})
            End If
            If Color <> Nothing And Color <> 0 Then
                ColorCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Color, 0, 0, 0})
            End If
        Else
            If Code_Template <> "" Then
                'CodeTempCmb2.SelectedIndex = Integer.Parse(Code_Template)
                CodeTempCmb2.Properties.LookUpData.KeyValue = Code_Template
            End If

            If Pole <> Nothing Then
                'PolesCmb2.SelectedIndex = Integer.Parse(Pole)
                PolesCmb2.Text = Pole
            End If

            FrameSizeTxt2.Text = Frame_Size
            TrippingRatingTxt2.Text = Tripping_Rating
            RapturingCapacityTxt2.Text = Rapturing_Capacity

            If Shunt_Trip <> "" Then
                ShuntTripCmb2.Properties.LookUpData.KeyValue = Shunt_Trip
            End If

            If Mech_Type <> "" Then
                MechTechCmb2.Properties.LookUpData.KeyValue = Mech_Type
            End If

            If Physical_Type <> "" Then
                'PhyTypeCmb2.SelectedIndex = Integer.Parse(Physical_Type)
                PhyTypeCmb2.Properties.LookUpData.KeyValue = Physical_Type
            End If

            'TemplateCtr.SelectedIndex = 1

            If UOM_ID <> Nothing And UOM_ID <> 0 Then
                UOMCmb2.Properties.LookUpData.KeyValue = New Decimal(New Integer() {UOM_ID, 0, 0, 0})
            End If

            If Category <> Nothing And Category <> 0 Then
                CatCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Category, 0, 0, 0})
            End If

            If Brand <> Nothing And Brand <> 0 Then
                BrandCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Brand, 0, 0, 0})
            End If

            If Material <> Nothing And Material <> 0 Then
                MaterialCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Material, 0, 0, 0})
            End If

            If Color <> Nothing And Color <> 0 Then
                ColorCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Color, 0, 0, 0})
            End If
        End If
    End Sub

    Private Sub GetWindowsValue()

        If CatCmb.Text <> "" Then
            Category = Integer.Parse(CatCmb.Properties.LookUpData.KeyValue().ToString())
        Else
            Category = -1
        End If

        If Status = "1" Then
            varName = NameTxt.Text

            Description = DescTxt.Text
            Alt_Description = AltDescTxt.Text

            'Material = MaterialTxt.Text
            'Color = ColorTxt.Text

            Dimension = DimTxt.Text
            Alt_Dimension = AltDimTxt.Text
            '## Added by Andrew
            If MinAlertQtyTxt.Text <> Nothing Then
                Low_Alert_Qty = CInt(MinAlertQtyTxt.Text)
            Else
                Low_Alert_Qty = 0
            End If
            If MaxAlertQtyTxt.Text <> Nothing Then
                Over_Alert_Qty = CInt(MaxAlertQtyTxt.Text)
            Else
                Over_Alert_Qty = 0
            End If
            '## End

            'remove by alan 11 sep 
            'If BrandCmb.Properties.LookUpData.KeyValue() <> "" Then
            'Brand = BrandCmb.Properties.LookUpData.KeyValue().ToString()
            'Else
            'Brand = ""
            'End If

            'added by alan
            If BrandCmb.Text <> "" Then
                Brand = Integer.Parse(BrandCmb.Properties.LookUpData.KeyValue().ToString())
            Else
                Brand = -1
            End If
            'end

            Model = ModelTxt.Text

            Lead_Time = LeadTimeTxt.Text
            Grade = GradeTxt.Text

            'If UOMCmb.Properties.LookUpData.KeyValue().ToString() <> "" Then
            If UOMCmb.Text <> "" Then
                UOM_ID = Integer.Parse(UOMCmb.Properties.LookUpData.KeyValue().ToString())
            Else
                UOM_ID = -1
            End If

            If MaterialCmb.Text <> "" Then
                Material = Integer.Parse(MaterialCmb.Properties.LookUpData.KeyValue().ToString())
            Else
                Material = -1
            End If

            If ColorCmb.Text <> "" Then
                Color = Integer.Parse(ColorCmb.Properties.LookUpData.KeyValue().ToString())
            Else
                Color = -1
            End If

            If KeepStkRd1.Checked = True Then
                Keep_Stock = "1"
            ElseIf KeepStkRd2.Checked = True Then
                Keep_Stock = "0"
            End If

            If StdChk.Checked = True Then
                Std_Part = "1"
            ElseIf StdChk.Checked = False Then
                Std_Part = "0"
            End If

            If RawMaterialChk.Checked = True Then
                Raw_Material = "1"
            ElseIf RawMaterialChk.Checked = False Then
                Raw_Material = "0"
            End If

            If PowerCoatChk.Checked = True Then
                Powder_Coat = "1"
            ElseIf PowerCoatChk.Checked = False Then
                Powder_Coat = "0"
            End If

        Else
            varName = NameTxt2.Text
            Model = ModelTxt2.Text
            Description = DescTxt2.Text

            If CodeTempCmb2.Text <> "" Then
                Code_Template = CodeTempCmb2.Properties.LookUpData.KeyValue().ToString()
            Else
                Code_Template = ""
            End If

            If PolesCmb2.Text <> "" Then
                Pole = Integer.Parse(PolesCmb2.Properties.LookUpData.KeyValue().ToString())
            Else
                Pole = -1
            End If

            If FrameSizeTxt2.Text <> "" Then
                Frame_Size = FrameSizeTxt2.Text
            End If

            'remove by alan
            'If BrandCmb2.Text <> "" Then
            'Brand = BrandCmb2.Properties.LookUpData.KeyValue().ToString()
            'Else
            'Brand = ""
            'End If

            'add by alan
            If BrandCmb2.Text <> "" Then
                Brand = Integer.Parse(BrandCmb2.Properties.LookUpData.KeyValue().ToString())
            Else
                Brand = -1
            End If
            'end

            If TrippingRatingTxt2.Text <> "" Then
                Tripping_Rating = TrippingRatingTxt2.Text
            End If

            If RapturingCapacityTxt2.Text <> "" Then
                Rapturing_Capacity = RapturingCapacityTxt2.Text
            End If

            If ShuntTripCmb2.Text <> "" Then
                Shunt_Trip = ShuntTripCmb2.Properties.LookUpData.KeyValue().ToString()
            Else
                Shunt_Trip = ""
            End If

            If MechTechCmb2.Text <> "" Then
                Mech_Type = MechTechCmb2.Properties.LookUpData.KeyValue().ToString()
            Else
                Mech_Type = ""
            End If

            'If PhyTypeCmb2.SelectedIndex <> -1 Then
            'Physical_Type = PhyTypeCmb2.SelectedIndex
            'End If
            If PhyTypeCmb2.Text <> "" Then
                Physical_Type = PhyTypeCmb2.Properties.LookUpData.KeyValue().ToString()
            Else
                Physical_Type = ""
            End If

            If UOMCmb2.Text <> "" Then
                UOM_ID = Integer.Parse(UOMCmb2.Properties.LookUpData.KeyValue().ToString())
            Else
                UOM_ID = -1
            End If
        End If
    End Sub

#End Region

#Region " Code - Common Bus Logic"

    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())

        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)

        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

#End Region

#Region " Grid Code"

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = True

        data.Columns.Add(col)
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

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub ManageProductForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        Dim OldCursor = Cursor.Current
        Me.Cursor = Cursors.WaitCursor
        RefreshProductListByProductID(ProductSearchTxt.Text, BrandSearchTxt.Text, DescSearch.Text, DescSearch2.Text, ModelSearch.Text)
        Me.Cursor = OldCursor
        'RefreshProductInfo()
    End Sub

    Private Sub RefreshProductListByProductID(ByVal ProductID As String, ByVal BrandText As String, ByVal Desc As String, ByVal Desc2 As String, ByVal Model As String)
        Dim ds As DataSet
        'Load product list


        Category_ID = CategoryTree.SelectedNode.Tag

        ' 11.01.2004 YG End

        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .Load(ds, ProductID, BrandText, Desc, Desc2, Model, Category_ID) Then
                If Not ds Is Nothing Then
                    Try
                        ProductList.DisplayMember = "Name"
                        ProductList.ValueMember = "Product_ID"

                        ProductList.DataSource = ds.Tables(0)

                        If ds.Tables(0).Rows.Count > 0 Then
                            TemplateCtr.Enabled = True
                            Me.SupplierGrp.Enabled = True
                            Dim a As MainForm = Me.ParentForm

                            If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
                                AddBut.Enabled = True
                            Else
                                AddBut.Enabled = False
                            End If

                            '            SaveBtn.Enabled = True

                            If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
                                SaveBtn.Enabled = True
                            Else
                                SaveBtn.Enabled = False
                            End If
                            ' 11.01.2004 YG End
                            ModifyProduct()
                        Else
                            ClearAll()

                            TemplateCtr.Enabled = False
                            SupplierGrp.Enabled = False
                            If Category_ID = 0 Then
                                AddBut.Enabled = False
                            End If
                            SaveBtn.Enabled = False

                            End If
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub



    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class

