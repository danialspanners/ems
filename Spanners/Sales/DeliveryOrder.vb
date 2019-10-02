Imports System.Data
Imports Crownwood.Magic.Common
Imports Crownwood.Magic.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Persistent
Imports DevExpress.XtraEditors.Controls

Public Class DeliveryOrderForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(Optional ByVal pOld_WO_ID As Integer = 0)
        MyBase.New()
        If Not pOld_WO_ID = 0 Then
            Old_WO_ID = pOld_WO_ID
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
    Friend WithEvents StatusCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProjectCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProjectLbl As System.Windows.Forms.Label
    Friend WithEvents DONoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Addresstxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents AddressLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents WODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OCNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents custPOTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OCNoLbl As System.Windows.Forms.Label
    Friend WithEvents Lbl3 As System.Windows.Forms.Label
    Friend WithEvents WONotxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TypeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GSTChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotalAmtTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RdBtn4 As System.Windows.Forms.RadioButton
    Friend WithEvents CashOfftxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Rdbtn3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Rdbtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdBtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents PercentOffTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CompGrid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CollectModeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents ValidityTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NotesMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PayDetailsMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProjectTitleCmb As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DeliveryOrderForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProjectTitleCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.RdBtn4 = New System.Windows.Forms.RadioButton
        Me.CashOfftxt = New DevExpress.XtraEditors.SpinEdit
        Me.Rdbtn3 = New System.Windows.Forms.RadioButton
        Me.Label43 = New System.Windows.Forms.Label
        Me.Rdbtn2 = New System.Windows.Forms.RadioButton
        Me.RdBtn1 = New System.Windows.Forms.RadioButton
        Me.PercentOffTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.TotalAmtTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.GSTChk = New System.Windows.Forms.CheckBox
        Me.TypeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.WONotxt = New DevExpress.XtraEditors.TextEdit
        Me.Lbl3 = New System.Windows.Forms.Label
        Me.StatusCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ProjectCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ProjectLbl = New System.Windows.Forms.Label
        Me.DONoTxt = New DevExpress.XtraEditors.TextEdit
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
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OCNoLbl = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.CompGrid1 = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CollectModeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.ValidityTxt = New DevExpress.XtraEditors.TextEdit
        Me.NotesMemo = New DevExpress.XtraEditors.MemoEdit
        Me.PayDetailsMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.PrintBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashOfftxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentOffTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WONotxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DONoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.custPOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CollectModeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayDetailsMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProjectTitleCmb)
        Me.GroupBox1.Controls.Add(Me.RdBtn4)
        Me.GroupBox1.Controls.Add(Me.CashOfftxt)
        Me.GroupBox1.Controls.Add(Me.Rdbtn3)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Rdbtn2)
        Me.GroupBox1.Controls.Add(Me.RdBtn1)
        Me.GroupBox1.Controls.Add(Me.PercentOffTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TotalAmtTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GSTChk)
        Me.GroupBox1.Controls.Add(Me.TypeCmb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.WONotxt)
        Me.GroupBox1.Controls.Add(Me.Lbl3)
        Me.GroupBox1.Controls.Add(Me.StatusCmb)
        Me.GroupBox1.Controls.Add(Me.ProjectCmb)
        Me.GroupBox1.Controls.Add(Me.ProjectLbl)
        Me.GroupBox1.Controls.Add(Me.DONoTxt)
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
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OCNoLbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 160)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'ProjectTitleCmb
        '
        Me.ProjectTitleCmb.Location = New System.Drawing.Point(208, 96)
        Me.ProjectTitleCmb.Name = "ProjectTitleCmb"
        Me.ProjectTitleCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectTitleCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectTitleCmb.Properties.NullString = ""
        Me.ProjectTitleCmb.Properties.PopupWidth = 456
        Me.ProjectTitleCmb.Size = New System.Drawing.Size(328, 19)
        Me.ProjectTitleCmb.TabIndex = 69
        '
        'RdBtn4
        '
        Me.RdBtn4.Checked = True
        Me.RdBtn4.Location = New System.Drawing.Point(552, 138)
        Me.RdBtn4.Name = "RdBtn4"
        Me.RdBtn4.Size = New System.Drawing.Size(104, 16)
        Me.RdBtn4.TabIndex = 68
        Me.RdBtn4.TabStop = True
        Me.RdBtn4.Text = "No Discount"
        '
        'CashOfftxt
        '
        Me.CashOfftxt.Location = New System.Drawing.Point(608, 100)
        Me.CashOfftxt.Name = "CashOfftxt"
        Me.CashOfftxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CashOfftxt.Properties.ReadOnly = True
        Me.CashOfftxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CashOfftxt.Size = New System.Drawing.Size(40, 19)
        Me.CashOfftxt.TabIndex = 67
        Me.CashOfftxt.Text = "0"
        '
        'Rdbtn3
        '
        Me.Rdbtn3.Location = New System.Drawing.Point(552, 120)
        Me.Rdbtn3.Name = "Rdbtn3"
        Me.Rdbtn3.Size = New System.Drawing.Size(96, 16)
        Me.Rdbtn3.TabIndex = 66
        Me.Rdbtn3.Text = "% off @ line"
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(568, 100)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(40, 16)
        Me.Label43.TabIndex = 65
        Me.Label43.Text = "$ off :"
        '
        'Rdbtn2
        '
        Me.Rdbtn2.Location = New System.Drawing.Point(552, 102)
        Me.Rdbtn2.Name = "Rdbtn2"
        Me.Rdbtn2.Size = New System.Drawing.Size(16, 16)
        Me.Rdbtn2.TabIndex = 64
        '
        'RdBtn1
        '
        Me.RdBtn1.Location = New System.Drawing.Point(552, 84)
        Me.RdBtn1.Name = "RdBtn1"
        Me.RdBtn1.Size = New System.Drawing.Size(16, 16)
        Me.RdBtn1.TabIndex = 63
        '
        'PercentOffTxt
        '
        Me.PercentOffTxt.Location = New System.Drawing.Point(608, 80)
        Me.PercentOffTxt.Name = "PercentOffTxt"
        Me.PercentOffTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PercentOffTxt.Properties.ReadOnly = True
        Me.PercentOffTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PercentOffTxt.Size = New System.Drawing.Size(40, 19)
        Me.PercentOffTxt.TabIndex = 62
        Me.PercentOffTxt.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(568, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "% off :"
        '
        'TotalAmtTxt
        '
        Me.TotalAmtTxt.Location = New System.Drawing.Point(120, 116)
        Me.TotalAmtTxt.Name = "TotalAmtTxt"
        Me.TotalAmtTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TotalAmtTxt.Size = New System.Drawing.Size(416, 19)
        Me.TotalAmtTxt.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Total Amount :"
        '
        'GSTChk
        '
        Me.GSTChk.Location = New System.Drawing.Point(120, 140)
        Me.GSTChk.Name = "GSTChk"
        Me.GSTChk.Size = New System.Drawing.Size(72, 16)
        Me.GSTChk.TabIndex = 58
        Me.GSTChk.Text = "G.S.T."
        '
        'TypeCmb
        '
        Me.TypeCmb.Location = New System.Drawing.Point(328, 56)
        Me.TypeCmb.Name = "TypeCmb"
        Me.TypeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TypeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TypeCmb.Properties.NullString = ""
        Me.TypeCmb.Size = New System.Drawing.Size(128, 19)
        Me.TypeCmb.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(264, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Type :"
        '
        'WONotxt
        '
        Me.WONotxt.Location = New System.Drawing.Point(120, 36)
        Me.WONotxt.Name = "WONotxt"
        Me.WONotxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WONotxt.Size = New System.Drawing.Size(128, 19)
        Me.WONotxt.TabIndex = 55
        '
        'Lbl3
        '
        Me.Lbl3.Location = New System.Drawing.Point(16, 38)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(80, 16)
        Me.Lbl3.TabIndex = 54
        Me.Lbl3.Text = "W. Order No :"
        '
        'StatusCmb
        '
        Me.StatusCmb.Location = New System.Drawing.Point(536, 56)
        Me.StatusCmb.Name = "StatusCmb"
        Me.StatusCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.StatusCmb.Properties.NullString = ""
        Me.StatusCmb.Size = New System.Drawing.Size(120, 19)
        Me.StatusCmb.TabIndex = 53
        '
        'ProjectCmb
        '
        Me.ProjectCmb.Location = New System.Drawing.Point(120, 96)
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
        Me.ProjectLbl.Location = New System.Drawing.Point(16, 98)
        Me.ProjectLbl.Name = "ProjectLbl"
        Me.ProjectLbl.Size = New System.Drawing.Size(56, 16)
        Me.ProjectLbl.TabIndex = 51
        Me.ProjectLbl.Text = "* Project :"
        '
        'DONoTxt
        '
        Me.DONoTxt.Location = New System.Drawing.Point(120, 16)
        Me.DONoTxt.Name = "DONoTxt"
        Me.DONoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DONoTxt.Size = New System.Drawing.Size(128, 19)
        Me.DONoTxt.TabIndex = 49
        '
        'Addresstxt
        '
        Me.Addresstxt.Location = New System.Drawing.Point(328, 76)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Addresstxt.Size = New System.Drawing.Size(128, 19)
        Me.Addresstxt.TabIndex = 48
        '
        'ContLookup
        '
        Me.ContLookup.Location = New System.Drawing.Point(120, 76)
        Me.ContLookup.Name = "ContLookup"
        Me.ContLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContLookup.Properties.NullString = ""
        Me.ContLookup.Properties.PopupWidth = 184
        Me.ContLookup.Size = New System.Drawing.Size(128, 19)
        Me.ContLookup.TabIndex = 44
        '
        'CustLookup
        '
        Me.CustLookup.Location = New System.Drawing.Point(120, 56)
        Me.CustLookup.Name = "CustLookup"
        Me.CustLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustLookup.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(23))
        Me.CustLookup.Properties.NullString = ""
        Me.CustLookup.Properties.PopupWidth = 368
        Me.CustLookup.Size = New System.Drawing.Size(128, 19)
        Me.CustLookup.TabIndex = 43
        '
        'AddressLbl
        '
        Me.AddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLbl.Location = New System.Drawing.Point(264, 78)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(56, 16)
        Me.AddressLbl.TabIndex = 47
        Me.AddressLbl.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "* Contact Person :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(16, 58)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(104, 16)
        Me.CustNameLbl.TabIndex = 45
        Me.CustNameLbl.Text = "* Customer Name :"
        '
        'WODate
        '
        Me.WODate.DateTime = New Date(CType(0, Long))
        Me.WODate.Location = New System.Drawing.Point(536, 16)
        Me.WODate.Name = "WODate"
        Me.WODate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WODate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WODate.Size = New System.Drawing.Size(120, 19)
        Me.WODate.TabIndex = 42
        '
        'OCNoTxt
        '
        Me.OCNoTxt.Location = New System.Drawing.Point(328, 16)
        Me.OCNoTxt.Name = "OCNoTxt"
        Me.OCNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OCNoTxt.Properties.ReadOnly = True
        Me.OCNoTxt.Size = New System.Drawing.Size(128, 19)
        Me.OCNoTxt.TabIndex = 39
        '
        'custPOTxt
        '
        Me.custPOTxt.Location = New System.Drawing.Point(328, 36)
        Me.custPOTxt.Name = "custPOTxt"
        Me.custPOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.custPOTxt.Size = New System.Drawing.Size(128, 19)
        Me.custPOTxt.TabIndex = 38
        '
        'PODate
        '
        Me.PODate.DateTime = New Date(CType(0, Long))
        Me.PODate.Location = New System.Drawing.Point(536, 36)
        Me.PODate.Name = "PODate"
        Me.PODate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PODate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.PODate.Size = New System.Drawing.Size(120, 19)
        Me.PODate.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Delivery No :"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(472, 38)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 16)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "PO Date :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cust PO :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Status :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(472, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date :"
        '
        'OCNoLbl
        '
        Me.OCNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OCNoLbl.Location = New System.Drawing.Point(264, 20)
        Me.OCNoLbl.Name = "OCNoLbl"
        Me.OCNoLbl.Size = New System.Drawing.Size(64, 16)
        Me.OCNoLbl.TabIndex = 11
        Me.OCNoLbl.Text = "O. C.  No :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.GridControl1)
        Me.GroupBox2.Controls.Add(Me.CompGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 264)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Component"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Box"
        '
        'GridControl1
        '
        Me.GridControl1.EditorsRepository = Me.PersistentRepository2
        Me.GridControl1.Location = New System.Drawing.Point(8, 24)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(648, 104)
        Me.GridControl1.TabIndex = 86
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.Properties.AllowFocused = False
        Me.RepositoryItemCheckEdit2.Properties.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemCheckEdit2.Properties.CheckAlign = DevExpress.XtraEditors.Controls.CheckAlignStyles.NoText
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        Me.GridView2.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'CompGrid1
        '
        Me.CompGrid1.EditorsRepository = Me.PersistentRepository1
        Me.CompGrid1.Enabled = False
        Me.CompGrid1.Location = New System.Drawing.Point(8, 152)
        Me.CompGrid1.MainView = Me.GridView1
        Me.CompGrid1.Name = "CompGrid1"
        Me.CompGrid1.Size = New System.Drawing.Size(648, 104)
        Me.CompGrid1.TabIndex = 85
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewOptions = CType(((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CollectModeCmb)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.ValidityTxt)
        Me.GroupBox4.Controls.Add(Me.NotesMemo)
        Me.GroupBox4.Controls.Add(Me.PayDetailsMemo)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 424)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(512, 112)
        Me.GroupBox4.TabIndex = 22
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
        Me.Label42.Location = New System.Drawing.Point(176, 18)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(80, 16)
        Me.Label42.TabIndex = 42
        Me.Label42.Text = "Collect Mode :"
        '
        'ValidityTxt
        '
        Me.ValidityTxt.Location = New System.Drawing.Point(64, 16)
        Me.ValidityTxt.Name = "ValidityTxt"
        Me.ValidityTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ValidityTxt.Size = New System.Drawing.Size(48, 19)
        Me.ValidityTxt.TabIndex = 35
        '
        'NotesMemo
        '
        Me.NotesMemo.Location = New System.Drawing.Point(64, 64)
        Me.NotesMemo.Name = "NotesMemo"
        Me.NotesMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesMemo.Size = New System.Drawing.Size(336, 40)
        Me.NotesMemo.TabIndex = 32
        '
        'PayDetailsMemo
        '
        Me.PayDetailsMemo.Location = New System.Drawing.Point(64, 38)
        Me.PayDetailsMemo.Name = "PayDetailsMemo"
        Me.PayDetailsMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PayDetailsMemo.Size = New System.Drawing.Size(336, 24)
        Me.PayDetailsMemo.TabIndex = 30
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 72)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Notes :"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 16)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = "Validity :"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(8, 40)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 32)
        Me.Label39.TabIndex = 5
        Me.Label39.Text = "Payment Term :"
        '
        'PrintBtn
        '
        Me.PrintBtn.AutoSize = False
        Me.PrintBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Image = Nothing
        Me.PrintBtn.Location = New System.Drawing.Point(528, 502)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(64, 32)
        Me.PrintBtn.TabIndex = 23
        Me.PrintBtn.Text = "Print"
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
        Me.CloseBtn.Location = New System.Drawing.Point(600, 502)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 24
        Me.CloseBtn.Text = "&Close"
        '
        'DeliveryOrderForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(672, 541)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "DeliveryOrderForm"
        Me.Text = "Delivery Order"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ProjectTitleCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashOfftxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentOffTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WONotxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DONoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Addresstxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.custPOTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.CollectModeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayDetailsMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

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
    Public DO_No As String
#End Region

#Region " QuotationLine's variable"
    '** QuotationLine **
    Public Quotation_Line_ID As Integer
    Public ItemNo As Integer
    Public Raw_Material As String
    Public Length As Integer
    Public Breadth As Integer
    Public Thickness As Integer
    Public Unit_Cost As Decimal
    Public Wiring As Decimal
    Public Accessory As Decimal
    Public Copper As Decimal
    Public Comp_Markup As Integer
    Public Concrete_Base As Decimal
    Public Box_Markup As Integer
    Public Transport As Decimal
    Public Enclosure As Decimal
    Public Enclosure_Markup As Integer
    Public Cost As Decimal             'Total Panel Cost
    Public Overall_Markup As Decimal
    Public Total_Amount As Decimal

    Public LinePercent_Discount As Integer
    Public DiscPrice As Decimal
    '****
#End Region

    Public Percent_Discount As Integer
    Public Cash_Discount As Double
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable
    Public FormStatus As String             'TO DIFFERENTIATE BETWEEN ADD,EDIT..

    Public Old_Quotation_ID As Integer
    Public Old_WO_ID As Integer

    Private Sub DeliveryOrderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor

        LoadCustomerDetails()
        LoadProjectTitle()
        LoadCombo()

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            Dim dsHeaderLoad As DataSet
            If .GetWOHeader(dsHeaderLoad, Old_WO_ID) Then
                SetWindowValue(dsHeaderLoad)
            End If
        End With
        CompGrid1.Enabled = True
        ' SaveQuoBtn.Enabled = True
        RefreshBoxGrid()

        Me.Cursor = Cursors.Default
    End Sub

#Region " Generate Delivery Order No"
    Private Function GetDONo() As String
        Dim DocumentNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DocumentNo = .GetDocumentNextNumber("DO")
        End With
        GetDONo = "DO" & DocumentNo
    End Function
#End Region

#Region " Set window value "
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)

        WONotxt.Text = dsLoad.Tables(0).Rows(0)("WO_NO")
        WO_ID = dsLoad.Tables(0).Rows(0)("WO_ID")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")) Then
            OCNoTxt.Text = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")
            Confirm_Quotation_No = dsLoad.Tables(0).Rows(0)("Confirm_Quotation_NO")
        End If

        DONoTxt.Text = GetDONo()

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

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Collect_Mode")) Then
            CollectModeCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Collect_Mode")
        End If
    End Sub
#End Region

#Region " Box Grid "
    Public Sub RefreshBoxGrid()
        Dim ds As DataSet
        Dim TmpDO_No As String

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If Len(Confirm_Quotation_No) > 0 Then
                .Confirm_Quotation_No = Confirm_Quotation_No
                .WO_ID = WO_ID
                If .GetDOLine(ds) Then
                    InitBoxGrid()
                    Dim oRow As DataRow
                    'Quotation_Line_ID = ds.Tables(0).Rows(0)("Quotation_Line_ID")

                    For Each oRow In ds.Tables(0).Rows
                        .WO_ItemNo = oRow("ItemNo")
                        .WO_ID = WO_ID
                        TmpDO_No = .GetDONo
                        
                        data.Rows.Add(New Object() {oRow("ItemNo"), oRow("Quotation_Line_ID"), oRow("Box"), oRow("QAQty"), oRow("Total_Amount"), TmpDO_No})
                    Next
                    GridControl1.DataSource = data
                    GridControl1.DefaultView.PopulateColumns()
                    InitEditors()
                    Quotation_Line_ID = ds.Tables(0).Rows(0)("Quotation_Line_ID")
                    RefreshComponentGrid()
                    ds.Dispose()
                End If
            Else
                .WO_ID = WO_ID
                If .GetDOLineFromWO(ds) Then
                    InitBoxGrid()
                    Dim oRow As DataRow
                    WO_Line_ID = ds.Tables(0).Rows(0)("WO_Line_ID")
                    Dim Amt = Nothing

                    For Each oRow In ds.Tables(0).Rows
                        .WO_ItemNo = oRow("ItemNo")
                        .WO_ID = WO_ID
                        TmpDO_No = .GetDONo
                        data.Rows.Add(New Object() {oRow("WO_ItemNo"), oRow("WO_Line_ID"), oRow("Box"), oRow("Qty"), Amt, TmpDO_No})
                    Next
                    GridControl1.DataSource = data
                    GridControl1.DefaultView.PopulateColumns()
                    InitEditors()
                End If
            End If
        End With
    End Sub

    Private Sub InitBoxGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        'AddColumn(data, " ", System.Type.GetType("System.Object"), False)
        AddColumn(data, "Item No", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "QLID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Box", System.Type.GetType("System.String"), True)
        AddColumn(data, "Qty", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Total Amount", System.Type.GetType("System.Double"), True)
        AddColumn(data, "DO No", System.Type.GetType("System.String"), True)

        data.EndInit()
    End Sub

    Private Sub InitEditors()
        On Error Resume Next
        GridView2.BestFitColumns()
        GridView2.Columns.Item(1).VisibleIndex = -1 'hide 1st column
        GridView2.BehaviorOptions = GridView2.BehaviorOptions Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.MultiSelect
    End Sub

#End Region

#Region " Component Grid Function & Double Click Event "
    Public Sub RefreshComponentGrid()
        Dim ds As DataSet
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            .Quotation_Line_ID = Quotation_Line_ID
            If .GetDOComponent(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim TotalCost As Double

                For Each oRow In ds.Tables(0).Rows
                    i = i + 1
                    TotalCost = oRow("UnitPrice") * oRow("Qty")
                    data.Rows.Add(New Object() {i, oRow("Component_ID"), oRow("Name"), oRow("Brand"), oRow("Description"), oRow("Lead_Time"), oRow("Qty")})
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


#End Region

#Region " Combo box - Loading  Project n Customer n Contact Person Cmb "
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

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        Dim arr As Int32() = GridView2.GetSelectedRows
        Dim i As Integer
        Dim StrQuotationLineID

        'Get Customer Name 
        Customer_ID = CustLookup.Properties.LookUpData.KeyValue
        Contact_ID = ContLookup.Properties.LookUpData.KeyValue
        DO_No = DONoTxt.Text
        Confirm_Quotation_No = OCNoTxt.Text
        Dim Payment As String = ValidityTxt.Text

        'If Not (arr Is Nothing) Then
        For Each i In arr
            Dim Row As Integer = i.ToString
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)
            StrQuotationLineID = StrQuotationLineID & dr(1) & ","

            With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                .WO_ID = WO_ID
                .WO_ItemNo = dr(0)
                .DOStatus = "1"
                .UserID = UserID
                .DO_No = DO_No
                If .UpdateDOStatus() Then

                End If
            End With
        Next
        Dim slen
        slen = Len(StrQuotationLineID)
        StrQuotationLineID = Microsoft.VisualBasic.Left(StrQuotationLineID, slen - 1)


        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New DeliveryOrderReportForm(WO_ID, StrQuotationLineID, Customer_ID, Contact_ID, DO_No, Confirm_Quotation_No, Payment)
        page = New Crownwood.Magic.Controls.TabPage("Print Delivery Order", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
        'Else
        'MessageBox.Show("Pls select product to print.", "Delivery Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Click
        If Not GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                If dr(1).ToString() <> "" Then
                    'WOQAds = Nothing
                    Quotation_Line_ID = dr(1)
                    RefreshComponentGrid()
                End If
            End If
            'Dim arr As Int32() = GridView2.GetSelectedRows
            'Dim i As Integer
            'If Not (arr Is Nothing) Then
            'Dim Row As Integer = GridView2.GetSelectedRows(0)
            'For Each i In arr
            'Dim Row As Integer = i.ToString
            'Dim dr As DataRow
            'dr = GridView2.GetDataRow(Row)
            'Quotation_Line_ID = dr(1)
            'RefreshComponentGrid()
            'Next
            'End If
        End If
    End Sub

    Private Sub DeliveryOrderForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Delivery Order?", "Delivery Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
End Class
