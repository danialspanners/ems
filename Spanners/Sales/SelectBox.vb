Public Class SelectBoxForm
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Offshoretxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InstallTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BoxTypeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OutLink5txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OutLink1Txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OTTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BusSectionTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents StripLabelTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LTBLabelTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OutLinkRefDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeliveryDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SchDeliverDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SerialNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SynConnTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CableLug1Hole_edit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CableLug2Hole_edit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents RepoOutLinkTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SUPINSOUTLINK1000txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SupIns630Unit_txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents UsedInstall_txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OTTxt2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Insulation_cover_txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Issues_Detail_MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Issues_Flag_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Insulation_cover_txt = New DevExpress.XtraEditors.SpinEdit
        Me.OTTxt2 = New DevExpress.XtraEditors.SpinEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.UsedInstall_txt = New DevExpress.XtraEditors.SpinEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.SupIns630Unit_txt = New DevExpress.XtraEditors.SpinEdit
        Me.SUPINSOUTLINK1000txt = New DevExpress.XtraEditors.SpinEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.RepoOutLinkTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.CableLug2Hole_edit = New DevExpress.XtraEditors.SpinEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.CableLug1Hole_edit = New DevExpress.XtraEditors.SpinEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.SynConnTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.SerialNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.OutLinkRefDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.DeliveryDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.SchDeliverDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.OutLink5txt = New DevExpress.XtraEditors.SpinEdit
        Me.OutLink1Txt = New DevExpress.XtraEditors.SpinEdit
        Me.OTTxt = New DevExpress.XtraEditors.SpinEdit
        Me.BusSectionTxt = New DevExpress.XtraEditors.SpinEdit
        Me.StripLabelTxt = New DevExpress.XtraEditors.SpinEdit
        Me.LTBLabelTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Offshoretxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.InstallTxt = New DevExpress.XtraEditors.SpinEdit
        Me.BoxTypeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Issues_Detail_MemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Issues_Flag_CheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.Insulation_cover_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTTxt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsedInstall_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupIns630Unit_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPINSOUTLINK1000txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoOutLinkTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CableLug2Hole_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CableLug1Hole_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SynConnTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutLinkRefDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchDeliverDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutLink5txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutLink1Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusSectionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StripLabelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTBLabelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Offshoretxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxTypeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Issues_Detail_MemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Insulation_cover_txt)
        Me.GroupBox1.Controls.Add(Me.OTTxt2)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.UsedInstall_txt)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.SupIns630Unit_txt)
        Me.GroupBox1.Controls.Add(Me.SUPINSOUTLINK1000txt)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.RepoOutLinkTxt)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.CableLug2Hole_edit)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CableLug1Hole_edit)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.SynConnTxt)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.SerialNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.OutLinkRefDateEdit)
        Me.GroupBox1.Controls.Add(Me.DeliveryDateEdit)
        Me.GroupBox1.Controls.Add(Me.SchDeliverDateEdit)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.OutLink5txt)
        Me.GroupBox1.Controls.Add(Me.OutLink1Txt)
        Me.GroupBox1.Controls.Add(Me.OTTxt)
        Me.GroupBox1.Controls.Add(Me.BusSectionTxt)
        Me.GroupBox1.Controls.Add(Me.StripLabelTxt)
        Me.GroupBox1.Controls.Add(Me.LTBLabelTxt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Offshoretxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.InstallTxt)
        Me.GroupBox1.Controls.Add(Me.BoxTypeCmb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 437)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(393, 151)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(119, 26)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "Insulation cover"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Insulation_cover_txt
        '
        Me.Insulation_cover_txt.Location = New System.Drawing.Point(518, 149)
        Me.Insulation_cover_txt.Name = "Insulation_cover_txt"
        Me.Insulation_cover_txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Insulation_cover_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Insulation_cover_txt.Size = New System.Drawing.Size(40, 19)
        Me.Insulation_cover_txt.TabIndex = 57
        Me.Insulation_cover_txt.Text = "0"
        '
        'OTTxt2
        '
        Me.OTTxt2.Location = New System.Drawing.Point(320, 137)
        Me.OTTxt2.Name = "OTTxt2"
        Me.OTTxt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OTTxt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OTTxt2.Size = New System.Drawing.Size(40, 19)
        Me.OTTxt2.TabIndex = 56
        Me.OTTxt2.Text = "0"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(224, 141)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 16)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "O.T. (Variation 1):"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(393, 126)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 26)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Used LTB  Installation:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UsedInstall_txt
        '
        Me.UsedInstall_txt.Location = New System.Drawing.Point(518, 124)
        Me.UsedInstall_txt.Name = "UsedInstall_txt"
        Me.UsedInstall_txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.UsedInstall_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UsedInstall_txt.Size = New System.Drawing.Size(40, 19)
        Me.UsedInstall_txt.TabIndex = 53
        Me.UsedInstall_txt.Text = "0"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(393, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 26)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "SUP && INS 630A DIN DIST UNIT :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SupIns630Unit_txt
        '
        Me.SupIns630Unit_txt.Location = New System.Drawing.Point(518, 96)
        Me.SupIns630Unit_txt.Name = "SupIns630Unit_txt"
        Me.SupIns630Unit_txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupIns630Unit_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SupIns630Unit_txt.Size = New System.Drawing.Size(40, 19)
        Me.SupIns630Unit_txt.TabIndex = 51
        Me.SupIns630Unit_txt.Text = "0"
        '
        'SUPINSOUTLINK1000txt
        '
        Me.SUPINSOUTLINK1000txt.Location = New System.Drawing.Point(518, 64)
        Me.SUPINSOUTLINK1000txt.Name = "SUPINSOUTLINK1000txt"
        Me.SUPINSOUTLINK1000txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SUPINSOUTLINK1000txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SUPINSOUTLINK1000txt.Size = New System.Drawing.Size(40, 19)
        Me.SUPINSOUTLINK1000txt.TabIndex = 50
        Me.SUPINSOUTLINK1000txt.Text = "0"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(414, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 26)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "SUP && INS Out Link 1000mm :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RepoOutLinkTxt
        '
        Me.RepoOutLinkTxt.Location = New System.Drawing.Point(120, 164)
        Me.RepoOutLinkTxt.Name = "RepoOutLinkTxt"
        Me.RepoOutLinkTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RepoOutLinkTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RepoOutLinkTxt.Size = New System.Drawing.Size(40, 19)
        Me.RepoOutLinkTxt.TabIndex = 48
        Me.RepoOutLinkTxt.Text = "0"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(16, 164)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 32)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Reposition of Outgoing link Unit:"
        '
        'CableLug2Hole_edit
        '
        Me.CableLug2Hole_edit.Location = New System.Drawing.Point(320, 208)
        Me.CableLug2Hole_edit.Name = "CableLug2Hole_edit"
        Me.CableLug2Hole_edit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CableLug2Hole_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CableLug2Hole_edit.Size = New System.Drawing.Size(40, 19)
        Me.CableLug2Hole_edit.TabIndex = 46
        Me.CableLug2Hole_edit.Text = "0"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(224, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Cable Lug 2-Holes"
        '
        'CableLug1Hole_edit
        '
        Me.CableLug1Hole_edit.Location = New System.Drawing.Point(320, 184)
        Me.CableLug1Hole_edit.Name = "CableLug1Hole_edit"
        Me.CableLug1Hole_edit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CableLug1Hole_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CableLug1Hole_edit.Size = New System.Drawing.Size(40, 19)
        Me.CableLug1Hole_edit.TabIndex = 44
        Me.CableLug1Hole_edit.Text = "0"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(224, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Cable Lug 1-Hole"
        '
        'SynConnTxt
        '
        Me.SynConnTxt.Location = New System.Drawing.Point(120, 196)
        Me.SynConnTxt.Name = "SynConnTxt"
        Me.SynConnTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SynConnTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SynConnTxt.Size = New System.Drawing.Size(40, 19)
        Me.SynConnTxt.TabIndex = 42
        Me.SynConnTxt.Text = "0"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 32)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Synchronising Connector :"
        '
        'SerialNoTxt
        '
        Me.SerialNoTxt.Location = New System.Drawing.Point(120, 40)
        Me.SerialNoTxt.Name = "SerialNoTxt"
        Me.SerialNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SerialNoTxt.Size = New System.Drawing.Size(120, 19)
        Me.SerialNoTxt.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Serial No :"
        '
        'OutLinkRefDateEdit
        '
        Me.OutLinkRefDateEdit.DateTime = New Date(CType(0, Long))
        Me.OutLinkRefDateEdit.Location = New System.Drawing.Point(116, 276)
        Me.OutLinkRefDateEdit.Name = "OutLinkRefDateEdit"
        Me.OutLinkRefDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OutLinkRefDateEdit.Size = New System.Drawing.Size(88, 19)
        Me.OutLinkRefDateEdit.TabIndex = 38
        '
        'DeliveryDateEdit
        '
        Me.DeliveryDateEdit.DateTime = New Date(CType(0, Long))
        Me.DeliveryDateEdit.Location = New System.Drawing.Point(316, 276)
        Me.DeliveryDateEdit.Name = "DeliveryDateEdit"
        Me.DeliveryDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliveryDateEdit.Size = New System.Drawing.Size(88, 19)
        Me.DeliveryDateEdit.TabIndex = 37
        '
        'SchDeliverDateEdit
        '
        Me.SchDeliverDateEdit.DateTime = New Date(CType(0, Long))
        Me.SchDeliverDateEdit.Location = New System.Drawing.Point(116, 252)
        Me.SchDeliverDateEdit.Name = "SchDeliverDateEdit"
        Me.SchDeliverDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SchDeliverDateEdit.Size = New System.Drawing.Size(88, 19)
        Me.SchDeliverDateEdit.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Out Link Ref Date  :"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(220, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Delivery Date :"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Schedule Deliver :"
        '
        'OutLink5txt
        '
        Me.OutLink5txt.Location = New System.Drawing.Point(320, 160)
        Me.OutLink5txt.Name = "OutLink5txt"
        Me.OutLink5txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OutLink5txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OutLink5txt.Size = New System.Drawing.Size(40, 19)
        Me.OutLink5txt.TabIndex = 32
        Me.OutLink5txt.Text = "0"
        '
        'OutLink1Txt
        '
        Me.OutLink1Txt.Location = New System.Drawing.Point(120, 136)
        Me.OutLink1Txt.Name = "OutLink1Txt"
        Me.OutLink1Txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OutLink1Txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OutLink1Txt.Size = New System.Drawing.Size(40, 19)
        Me.OutLink1Txt.TabIndex = 31
        Me.OutLink1Txt.Text = "0"
        '
        'OTTxt
        '
        Me.OTTxt.Location = New System.Drawing.Point(320, 112)
        Me.OTTxt.Name = "OTTxt"
        Me.OTTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OTTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OTTxt.Size = New System.Drawing.Size(40, 19)
        Me.OTTxt.TabIndex = 30
        Me.OTTxt.Text = "0"
        '
        'BusSectionTxt
        '
        Me.BusSectionTxt.Location = New System.Drawing.Point(120, 112)
        Me.BusSectionTxt.Name = "BusSectionTxt"
        Me.BusSectionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BusSectionTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BusSectionTxt.Size = New System.Drawing.Size(40, 19)
        Me.BusSectionTxt.TabIndex = 29
        Me.BusSectionTxt.Text = "0"
        '
        'StripLabelTxt
        '
        Me.StripLabelTxt.Location = New System.Drawing.Point(320, 88)
        Me.StripLabelTxt.Name = "StripLabelTxt"
        Me.StripLabelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StripLabelTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StripLabelTxt.Size = New System.Drawing.Size(40, 19)
        Me.StripLabelTxt.TabIndex = 28
        Me.StripLabelTxt.Text = "0"
        '
        'LTBLabelTxt
        '
        Me.LTBLabelTxt.Location = New System.Drawing.Point(120, 88)
        Me.LTBLabelTxt.Name = "LTBLabelTxt"
        Me.LTBLabelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LTBLabelTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LTBLabelTxt.Size = New System.Drawing.Size(40, 19)
        Me.LTBLabelTxt.TabIndex = 27
        Me.LTBLabelTxt.Text = "0"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(224, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Out Link 500mm :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Out Link 1000mm :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(224, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "O.T. :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Bus Section :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(224, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Strip Label :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "LTB Label :"
        '
        'Offshoretxt
        '
        Me.Offshoretxt.Location = New System.Drawing.Point(320, 64)
        Me.Offshoretxt.Name = "Offshoretxt"
        Me.Offshoretxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Offshoretxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Offshoretxt.Size = New System.Drawing.Size(40, 19)
        Me.Offshoretxt.TabIndex = 20
        Me.Offshoretxt.Text = "0"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(224, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Offshore :"
        '
        'InstallTxt
        '
        Me.InstallTxt.Location = New System.Drawing.Point(120, 64)
        Me.InstallTxt.Name = "InstallTxt"
        Me.InstallTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstallTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.InstallTxt.Size = New System.Drawing.Size(40, 19)
        Me.InstallTxt.TabIndex = 18
        Me.InstallTxt.Text = "0"
        '
        'BoxTypeCmb
        '
        Me.BoxTypeCmb.Location = New System.Drawing.Point(120, 16)
        Me.BoxTypeCmb.Name = "BoxTypeCmb"
        Me.BoxTypeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BoxTypeCmb.Properties.NullString = ""
        Me.BoxTypeCmb.Properties.PopupWidth = 152
        Me.BoxTypeCmb.Size = New System.Drawing.Size(128, 19)
        Me.BoxTypeCmb.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Install :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Box Type :"
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(23, 19)
        Me.SaveBtn.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(36, 19)
        Me.SaveBtn.TabIndex = 25
        Me.SaveBtn.Text = "Save"
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(81, 19)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(39, 19)
        Me.CloseBtn.TabIndex = 26
        Me.CloseBtn.Text = "Close"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 60)
        Me.Panel1.TabIndex = 27
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(582, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(400, 437)
        Me.TabControl2.TabIndex = 116
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.Label51)
        Me.TabPage4.Controls.Add(Me.Label50)
        Me.TabPage4.Controls.Add(Me.Issues_Detail_MemoEdit)
        Me.TabPage4.Controls.Add(Me.Issues_Flag_CheckBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(392, 411)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Issues"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(12, 26)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(116, 16)
        Me.Label51.TabIndex = 158
        Me.Label51.Text = "Issues Encountered ?"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(12, 51)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 16)
        Me.Label50.TabIndex = 157
        Me.Label50.Text = "Issue Details"
        '
        'Issues_Detail_MemoEdit
        '
        Me.Issues_Detail_MemoEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Issues_Detail_MemoEdit.Location = New System.Drawing.Point(15, 75)
        Me.Issues_Detail_MemoEdit.Name = "Issues_Detail_MemoEdit"
        Me.Issues_Detail_MemoEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Issues_Detail_MemoEdit.Size = New System.Drawing.Size(359, 316)
        Me.Issues_Detail_MemoEdit.TabIndex = 156
        '
        'Issues_Flag_CheckBox
        '
        Me.Issues_Flag_CheckBox.Location = New System.Drawing.Point(134, 21)
        Me.Issues_Flag_CheckBox.Name = "Issues_Flag_CheckBox"
        Me.Issues_Flag_CheckBox.Size = New System.Drawing.Size(16, 24)
        Me.Issues_Flag_CheckBox.TabIndex = 155
        '
        'SelectBoxForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(982, 497)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectBoxForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Box"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Insulation_cover_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTTxt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsedInstall_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupIns630Unit_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPINSOUTLINK1000txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoOutLinkTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CableLug2Hole_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CableLug1Hole_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SynConnTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutLinkRefDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchDeliverDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutLink5txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutLink1Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusSectionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StripLabelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTBLabelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Offshoretxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxTypeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Issues_Detail_MemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable "
    Public LVB_Line_Id As Integer
    Public IO_Id As Integer
    Public Serial_No As String
    Public Box_Type_Id As Integer
    Public Install As Integer
    Public Offshore As Integer
    Public LTB_Label As Integer
    Public Strip_Label As Integer
    Public Bus_Section As Integer
    Public OT As Integer
    Public OT2 As Integer
    Public OutLink500 As Integer
    Public OutLink100 As Integer
    Public SupInsOutLink1000 As Integer
    Public SupIns630Unit As Integer
    Public UsedInstall As Integer
    Public Insulation_Cover As Integer
    Public RepoOutLink As Integer
    Public SynConn As Integer
    Public Schedule_Deliver As String
    Public Delivery_Date As String
    Public OutLink_Ref_Date As String
    Public CableLug1Hole As Integer
    Public CableLug2Hole As Integer
    Public Issues_Flag As Integer
    Public Issues_Detail As String

#End Region

    Public Status As String
    Public UserID As String = Common.CommonConn.Config.USERID

    Private Sub SelectBoxForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBoxCmb()
        Select Case (Status)
            Case "EDIT"
                Dim ds As DataSet
                With New BusinessRules.LVBBusRules.LVBLineBusLogic
                    If .GetLVBLine(ds, LVB_Line_Id) Then
                        BoxTypeCmb.Properties.LookUpData.KeyValue = ds.Tables(0).Rows(0)("Box_Type_Id")
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Serial_No")) Then
                            SerialNoTxt.Text = ds.Tables(0).Rows(0)("Serial_No")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Install")) Then
                            InstallTxt.Text = ds.Tables(0).Rows(0)("Install")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Offshore")) Then
                            Offshoretxt.Text = ds.Tables(0).Rows(0)("Offshore")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("LTB_Label")) Then
                            LTBLabelTxt.Text = ds.Tables(0).Rows(0)("LTB_Label")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Strip_Label")) Then
                            StripLabelTxt.Text = ds.Tables(0).Rows(0)("Strip_Label")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Bus_Section")) Then
                            BusSectionTxt.Text = ds.Tables(0).Rows(0)("Bus_Section")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("OT")) Then
                            OTTxt.Text = ds.Tables(0).Rows(0)("OT")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("OT2")) Then
                            OTTxt2.Text = ds.Tables(0).Rows(0)("OT2")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("OutLink100")) Then
                            OutLink1Txt.Text = ds.Tables(0).Rows(0)("OutLink100")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("SupInsOutLink1000")) Then
                            Me.SUPINSOUTLINK1000txt.Text = ds.Tables(0).Rows(0)("SupInsOutLink1000")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("SupIns630Unit")) Then
                            Me.SupIns630Unit_txt.Text = ds.Tables(0).Rows(0)("SupIns630Unit")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("UsedInstall")) Then
                            Me.UsedInstall_txt.Text = ds.Tables(0).Rows(0)("UsedInstall")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Insulation_Cover")) Then
                            Me.Insulation_cover_txt.Text = ds.Tables(0).Rows(0)("Insulation_Cover")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("OutLink500")) Then
                            OutLink5txt.Text = ds.Tables(0).Rows(0)("OutLink500")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("RepoOutlink")) Then
                            Me.RepoOutLinkTxt.Text = ds.Tables(0).Rows(0)("RepoOutLink")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("SynConn")) Then
                            SynConnTxt.Text = ds.Tables(0).Rows(0)("SynConn")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("CableLug1Hole")) Then
                            CableLug1Hole_edit.Text = ds.Tables(0).Rows(0)("CableLug1Hole")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("CableLug2Hole")) Then
                            CableLug2Hole_edit.Text = ds.Tables(0).Rows(0)("CableLug2Hole")
                        End If

                        If Not IsDBNull(ds.Tables(0).Rows(0)("Issues_Flag")) Then
                            If ds.Tables(0).Rows(0)("Issues_Flag") = "1" Then
                                Me.Issues_Flag_CheckBox.Checked = True
                            Else
                                Me.Issues_Flag_CheckBox.Checked = False
                            End If
                        Else
                            Me.Issues_Flag_CheckBox.Checked = False
                        End If

                        If Not IsDBNull(ds.Tables(0).Rows(0)("Issues_Detail")) Then
                            Issues_Detail_MemoEdit.Text = ds.Tables(0).Rows(0)("Issues_Detail")
                        End If

                        If Not IsDBNull(ds.Tables(0).Rows(0)("Schedule_Deliver")) Then
                            SchDeliverDateEdit.DateTime = ds.Tables(0).Rows(0)("Schedule_Deliver")
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Delivery_Date")) Then
                            DeliveryDateEdit.DateTime = ds.Tables(0).Rows(0)("Delivery_Date")
                        End If

                        If Not IsDBNull(ds.Tables(0).Rows(0)("OutLink_Ref_Date")) Then
                            OutLinkRefDateEdit.DateTime = ds.Tables(0).Rows(0)("OutLink_Ref_Date")
                        End If

                    End If
                End With
        End Select
    End Sub

    Private Sub LoadBoxCmb()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.LVBBoxBusLogic
            If .GetLVBBox(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(BoxTypeCmb, "Box_Name", 400, 0, "c")
                        BoxTypeCmb.Properties.LookUpData.KeyField = "Box_Type_Id"
                        BoxTypeCmb.Properties.LookUpData.DisplayField = "Box_Name"

                        BoxTypeCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        BoxTypeCmb.EditValue = "0"
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

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        RetrieveFromForm()
        Select Case (Status)
            Case "ADD"
                SaveBox()
            Case "EDIT"
                UpdateBox()
        End Select
    End Sub

    Private Sub SaveBox()
        If ValidData() Then
            With New BusinessRules.LVBBusRules.LVBLineBusLogic
                .IO_Id = IO_Id
                .Box_Type_Id = Box_Type_Id
                .Serial_No = Serial_No
                .Install = Install
                .Offshore = Offshore
                .LTB_Label = LTB_Label
                .Strip_Label = Strip_Label
                .Bus_Section = Bus_Section
                .OT = OT
                .OT2 = OT2
                .OutLink100 = OutLink100
                .OutLink500 = OutLink500
                .SupInsOutLink1000 = SupInsOutLink1000
                .SupIns630Unit = SupIns630Unit
                .UsedInstall = UsedInstall
                .Insulation_Cover = Insulation_Cover
                .RepoOutlink = RepoOutLink
                .SynConn = SynConn
                .CableLug1Hole = CableLug1Hole
                .CableLug2Hole = CableLug2Hole
                .Issues_Flag = Issues_Flag
                .Issues_Detail = Issues_Detail

                If Len(Schedule_Deliver) > 0 Then
                    .Schedule_Deliver = Microsoft.VisualBasic.DateAndTime.Day(Schedule_Deliver) & "/" & MonthName(Month(Schedule_Deliver)) & "/" & Year(Schedule_Deliver)
                End If
                If Len(Delivery_Date) > 0 Then
                    .Delivery_Date = Microsoft.VisualBasic.DateAndTime.Day(Delivery_Date) & "/" & MonthName(Month(Delivery_Date)) & "/" & Year(Delivery_Date)
                End If
                If Len(OutLink_Ref_Date) > 0 Then
                    .OutLink_Ref_Date = Microsoft.VisualBasic.DateAndTime.Day(OutLink_Ref_Date) & "/" & MonthName(Month(OutLink_Ref_Date)) & "/" & Year(OutLink_Ref_Date)
                End If
                .UserID = UserID
                If .SaveLVBLine() Then
                    Me.Close()
                End If
            End With
        End If
    End Sub

    Private Sub UpdateBox()
        If ValidData() Then
            With New BusinessRules.LVBBusRules.LVBLineBusLogic
                .LVB_Line_Id = LVB_Line_Id
                .Box_Type_Id = Box_Type_Id
                .Serial_No = Serial_No
                .Install = Install
                .Offshore = Offshore
                .LTB_Label = LTB_Label
                .Strip_Label = Strip_Label
                .Bus_Section = Bus_Section
                .OT = OT
                .OT2 = OT2
                .OutLink100 = OutLink100
                .OutLink500 = OutLink500
                .SupInsOutLink1000 = SupInsOutLink1000
                .SupIns630Unit = SupIns630Unit
                .UsedInstall = UsedInstall
                .Insulation_Cover = Insulation_Cover
                .RepoOutlink = RepoOutLink
                .SynConn = SynConn
                .CableLug1Hole = CableLug1Hole
                .CableLug2Hole = CableLug2Hole
                .Schedule_Deliver = Schedule_Deliver
                .Delivery_Date = Delivery_Date
                .OutLink_Ref_Date = OutLink_Ref_Date
                .Issues_Flag = Issues_Flag
                .Issues_Detail = Issues_Detail
                .UserID = UserID
                If .UpdateLVBLine() Then
                    Me.Close()
                End If
            End With
        End If
    End Sub

    Private Sub RetrieveFromForm()
        Box_Type_Id = Me.BoxTypeCmb.Properties.LookUpData.KeyValue
        Serial_No = Me.SerialNoTxt.Text
        Install = Me.InstallTxt.Text
        Offshore = Me.Offshoretxt.Text
        LTB_Label = Me.LTBLabelTxt.Text
        Strip_Label = Me.StripLabelTxt.Text
        Bus_Section = Me.BusSectionTxt.Text
        OT = Me.OTTxt.Text
        OT2 = Me.OTTxt2.Text
        OutLink500 = Me.OutLink5txt.Text
        OutLink100 = Me.OutLink1Txt.Text
        SupInsOutLink1000 = Me.SUPINSOUTLINK1000txt.Text
        SupIns630Unit = Me.SupIns630Unit_txt.Text
        UsedInstall = Me.UsedInstall_txt.Text
        Insulation_Cover = Me.Insulation_cover_txt.Text
        RepoOutLink = Me.RepoOutLinkTxt.Text
        SynConn = Me.SynConnTxt.Text
        CableLug1Hole = Me.CableLug1Hole_edit.Text
        CableLug2Hole = Me.CableLug2Hole_edit.Text
        If SchDeliverDateEdit.Text = "" Then
            Schedule_Deliver = Nothing
        Else
            Schedule_Deliver = Me.SchDeliverDateEdit.DateTime.ToString("dd MMM yyyy")
        End If
        If DeliveryDateEdit.Text <> "" Then
            Delivery_Date = Me.DeliveryDateEdit.DateTime.ToString("dd MMM yyyy")
        Else
            Delivery_Date = Nothing
        End If
        If OutLinkRefDateEdit.Text <> "" Then
            OutLink_Ref_Date = Me.OutLinkRefDateEdit.DateTime.ToString("dd MMM yyyy")
        Else
            OutLink_Ref_Date = Nothing
        End If

        If Me.Issues_Flag_CheckBox.Checked Then
            Issues_Flag = "1"
        Else
            Issues_Flag = "0"
        End If
        Issues_Detail = Me.Issues_Detail_MemoEdit.Text


    End Sub

    Private Function ValidData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Box_Type_Id = 0 Then
            DataOK_Flag = False
            FieldName = FieldName & "Box Type" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub Issues_Flag_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Issues_Detail_MemoEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
