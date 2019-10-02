Public Class LVBContractForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContractNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents LTLQtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LTLOffshoreTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Outlink500txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Outlink100txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BusSectionTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents StripLabelTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LTBLabeltxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LT24Offshoretxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LT24Qtytxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LT16Offshoretxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LT16Qtytxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LT24FBQtytxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SynConnTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CableLug1Hole_edit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CableLug2Hole_edit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SUPINSOUTLINK1000_txt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.ContractNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CableLug2Hole_edit = New DevExpress.XtraEditors.SpinEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.CableLug1Hole_edit = New DevExpress.XtraEditors.SpinEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.SynConnTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.LT24FBQtytxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.Outlink500txt = New DevExpress.XtraEditors.SpinEdit
        Me.Outlink100txt = New DevExpress.XtraEditors.SpinEdit
        Me.BusSectionTxt = New DevExpress.XtraEditors.SpinEdit
        Me.StripLabelTxt = New DevExpress.XtraEditors.SpinEdit
        Me.LTBLabeltxt = New DevExpress.XtraEditors.SpinEdit
        Me.LT24Offshoretxt = New DevExpress.XtraEditors.SpinEdit
        Me.LT24Qtytxt = New DevExpress.XtraEditors.SpinEdit
        Me.LT16Offshoretxt = New DevExpress.XtraEditors.SpinEdit
        Me.LT16Qtytxt = New DevExpress.XtraEditors.SpinEdit
        Me.LTLOffshoreTxt = New DevExpress.XtraEditors.SpinEdit
        Me.LTLQtyTxt = New DevExpress.XtraEditors.SpinEdit
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
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SUPINSOUTLINK1000_txt = New DevExpress.XtraEditors.SpinEdit
        Me.Label17 = New System.Windows.Forms.Label
        CType(Me.ContractNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CableLug2Hole_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CableLug1Hole_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SynConnTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LT24FBQtytxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Outlink500txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Outlink100txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusSectionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StripLabelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTBLabeltxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LT24Offshoretxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LT24Qtytxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LT16Offshoretxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LT16Qtytxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTLOffshoreTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTLQtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPINSOUTLINK1000_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Contract No :"
        '
        'ContractNoTxt
        '
        Me.ContractNoTxt.Location = New System.Drawing.Point(96, 8)
        Me.ContractNoTxt.Name = "ContractNoTxt"
        Me.ContractNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNoTxt.Size = New System.Drawing.Size(112, 19)
        Me.ContractNoTxt.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SUPINSOUTLINK1000_txt)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.CableLug2Hole_edit)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CableLug1Hole_edit)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.SynConnTxt)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.LT24FBQtytxt)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Outlink500txt)
        Me.GroupBox1.Controls.Add(Me.Outlink100txt)
        Me.GroupBox1.Controls.Add(Me.BusSectionTxt)
        Me.GroupBox1.Controls.Add(Me.StripLabelTxt)
        Me.GroupBox1.Controls.Add(Me.LTBLabeltxt)
        Me.GroupBox1.Controls.Add(Me.LT24Offshoretxt)
        Me.GroupBox1.Controls.Add(Me.LT24Qtytxt)
        Me.GroupBox1.Controls.Add(Me.LT16Offshoretxt)
        Me.GroupBox1.Controls.Add(Me.LT16Qtytxt)
        Me.GroupBox1.Controls.Add(Me.LTLOffshoreTxt)
        Me.GroupBox1.Controls.Add(Me.LTLQtyTxt)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 344)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'CableLug2Hole_edit
        '
        Me.CableLug2Hole_edit.Location = New System.Drawing.Point(324, 44)
        Me.CableLug2Hole_edit.Name = "CableLug2Hole_edit"
        Me.CableLug2Hole_edit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CableLug2Hole_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CableLug2Hole_edit.Size = New System.Drawing.Size(75, 19)
        Me.CableLug2Hole_edit.TabIndex = 33
        Me.CableLug2Hole_edit.Text = "0"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(212, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Cable Lug 2-Holes"
        '
        'CableLug1Hole_edit
        '
        Me.CableLug1Hole_edit.Location = New System.Drawing.Point(324, 16)
        Me.CableLug1Hole_edit.Name = "CableLug1Hole_edit"
        Me.CableLug1Hole_edit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CableLug1Hole_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CableLug1Hole_edit.Size = New System.Drawing.Size(75, 19)
        Me.CableLug1Hole_edit.TabIndex = 31
        Me.CableLug1Hole_edit.Text = "0"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(212, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Cable Lug 1-Hole"
        '
        'SynConnTxt
        '
        Me.SynConnTxt.Location = New System.Drawing.Point(120, 304)
        Me.SynConnTxt.Name = "SynConnTxt"
        Me.SynConnTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SynConnTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SynConnTxt.Size = New System.Drawing.Size(75, 19)
        Me.SynConnTxt.TabIndex = 29
        Me.SynConnTxt.Text = "0"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 304)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 32)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Synchronising Connector :"
        '
        'LT24FBQtytxt
        '
        Me.LT24FBQtytxt.Location = New System.Drawing.Point(120, 160)
        Me.LT24FBQtytxt.Name = "LT24FBQtytxt"
        Me.LT24FBQtytxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LT24FBQtytxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LT24FBQtytxt.Size = New System.Drawing.Size(75, 19)
        Me.LT24FBQtytxt.TabIndex = 27
        Me.LT24FBQtytxt.Text = "0"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "LT-24 w/o FB :"
        '
        'Outlink500txt
        '
        Me.Outlink500txt.Location = New System.Drawing.Point(120, 280)
        Me.Outlink500txt.Name = "Outlink500txt"
        Me.Outlink500txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Outlink500txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Outlink500txt.Size = New System.Drawing.Size(75, 19)
        Me.Outlink500txt.TabIndex = 25
        Me.Outlink500txt.Text = "0"
        '
        'Outlink100txt
        '
        Me.Outlink100txt.Location = New System.Drawing.Point(120, 256)
        Me.Outlink100txt.Name = "Outlink100txt"
        Me.Outlink100txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Outlink100txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Outlink100txt.Size = New System.Drawing.Size(75, 19)
        Me.Outlink100txt.TabIndex = 24
        Me.Outlink100txt.Text = "0"
        '
        'BusSectionTxt
        '
        Me.BusSectionTxt.Location = New System.Drawing.Point(120, 232)
        Me.BusSectionTxt.Name = "BusSectionTxt"
        Me.BusSectionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BusSectionTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BusSectionTxt.Size = New System.Drawing.Size(75, 19)
        Me.BusSectionTxt.TabIndex = 23
        Me.BusSectionTxt.Text = "0"
        '
        'StripLabelTxt
        '
        Me.StripLabelTxt.Location = New System.Drawing.Point(120, 208)
        Me.StripLabelTxt.Name = "StripLabelTxt"
        Me.StripLabelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StripLabelTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StripLabelTxt.Size = New System.Drawing.Size(75, 19)
        Me.StripLabelTxt.TabIndex = 22
        Me.StripLabelTxt.Text = "0"
        '
        'LTBLabeltxt
        '
        Me.LTBLabeltxt.Location = New System.Drawing.Point(120, 184)
        Me.LTBLabeltxt.Name = "LTBLabeltxt"
        Me.LTBLabeltxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LTBLabeltxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LTBLabeltxt.Size = New System.Drawing.Size(75, 19)
        Me.LTBLabeltxt.TabIndex = 21
        Me.LTBLabeltxt.Text = "0"
        '
        'LT24Offshoretxt
        '
        Me.LT24Offshoretxt.Location = New System.Drawing.Point(120, 136)
        Me.LT24Offshoretxt.Name = "LT24Offshoretxt"
        Me.LT24Offshoretxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LT24Offshoretxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LT24Offshoretxt.Size = New System.Drawing.Size(75, 19)
        Me.LT24Offshoretxt.TabIndex = 20
        Me.LT24Offshoretxt.Text = "0"
        '
        'LT24Qtytxt
        '
        Me.LT24Qtytxt.Location = New System.Drawing.Point(120, 112)
        Me.LT24Qtytxt.Name = "LT24Qtytxt"
        Me.LT24Qtytxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LT24Qtytxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LT24Qtytxt.Size = New System.Drawing.Size(75, 19)
        Me.LT24Qtytxt.TabIndex = 19
        Me.LT24Qtytxt.Text = "0"
        '
        'LT16Offshoretxt
        '
        Me.LT16Offshoretxt.Location = New System.Drawing.Point(120, 88)
        Me.LT16Offshoretxt.Name = "LT16Offshoretxt"
        Me.LT16Offshoretxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LT16Offshoretxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LT16Offshoretxt.Size = New System.Drawing.Size(75, 19)
        Me.LT16Offshoretxt.TabIndex = 18
        Me.LT16Offshoretxt.Text = "0"
        '
        'LT16Qtytxt
        '
        Me.LT16Qtytxt.Location = New System.Drawing.Point(120, 64)
        Me.LT16Qtytxt.Name = "LT16Qtytxt"
        Me.LT16Qtytxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LT16Qtytxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LT16Qtytxt.Size = New System.Drawing.Size(75, 19)
        Me.LT16Qtytxt.TabIndex = 17
        Me.LT16Qtytxt.Text = "0"
        '
        'LTLOffshoreTxt
        '
        Me.LTLOffshoreTxt.Location = New System.Drawing.Point(120, 40)
        Me.LTLOffshoreTxt.Name = "LTLOffshoreTxt"
        Me.LTLOffshoreTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LTLOffshoreTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LTLOffshoreTxt.Size = New System.Drawing.Size(75, 19)
        Me.LTLOffshoreTxt.TabIndex = 16
        Me.LTLOffshoreTxt.Text = "0"
        '
        'LTLQtyTxt
        '
        Me.LTLQtyTxt.Location = New System.Drawing.Point(120, 16)
        Me.LTLQtyTxt.Name = "LTLQtyTxt"
        Me.LTLQtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LTLQtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LTLQtyTxt.Size = New System.Drawing.Size(75, 19)
        Me.LTLQtyTxt.TabIndex = 15
        Me.LTLQtyTxt.Text = "0"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Out Link 500mm :"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Out Link 1000mm :"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Bus Section :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Strip Label :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "LTB Label :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "LT-24 Offshore :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "LT-24 :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "LT-16 Offshore :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LT-16 :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LT-Large Offshore :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "LT-Large :"
        '
        'SaveBtn
        '
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(264, 396)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(34, 17)
        Me.SaveBtn.TabIndex = 5
        Me.SaveBtn.Text = "Save"
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(336, 396)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(37, 17)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "Close"
        '
        'SUPINSOUTLINK1000_txt
        '
        Me.SUPINSOUTLINK1000_txt.Location = New System.Drawing.Point(324, 76)
        Me.SUPINSOUTLINK1000_txt.Name = "SUPINSOUTLINK1000_txt"
        Me.SUPINSOUTLINK1000_txt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SUPINSOUTLINK1000_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SUPINSOUTLINK1000_txt.Size = New System.Drawing.Size(75, 19)
        Me.SUPINSOUTLINK1000_txt.TabIndex = 35
        Me.SUPINSOUTLINK1000_txt.Text = "0"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(212, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "SUP && INS Outlink"
        '
        'LVBContractForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(428, 437)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ContractNoTxt)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "LVBContractForm"
        Me.Text = "New LVB Contract"
        CType(Me.ContractNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CableLug2Hole_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CableLug1Hole_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SynConnTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LT24FBQtytxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Outlink500txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Outlink100txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusSectionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StripLabelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTBLabeltxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LT24Offshoretxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LT24Qtytxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LT16Offshoretxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LT16Qtytxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTLOffshoreTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTLQtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPINSOUTLINK1000_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " variable "
    Public Contract_Id As Integer
    Public Contract_No As String
    Public LTL_Qty As Integer
    Public LTL_Offshore_Qty As Integer
    Public LT16_Qty As Integer
    Public LT16_Offshore_Qty As Integer
    Public LT24_Qty As Integer
    Public LT24_Offshore_Qty As Integer
    Public LT24FB_Qty As Integer
    Public LTB_Label As Integer
    Public Strip_Label As Integer
    Public Bus_Section As Integer
    Public OutLink500 As Integer
    Public OutLink100 As Integer
    Public SupInsOutLink1000 As Integer
    Public SynConn As Integer
    Public CableLug1Hole As Integer
    Public CableLug2Hole As Integer
    Public Create_Date As String
    Public Transact_Date As String
    Public UserID As String = Common.CommonConn.Config.USERID
#End Region

    Private Sub LVBContractForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        RetrieveFromForm()
        If ValidData() Then
            With New BusinessRules.LVBBusRules.LVBContractBusLogic
                .Contract_No = Contract_No
                If .CheckDuplicateContract()= True then
                .LTL_Qty = LTL_Qty
                .LTL_Offshore_Qty = LTL_Offshore_Qty
                .LT16_Qty = LT16_Qty
                .LT16_Offshore_Qty = LT16_Offshore_Qty
                .LT24_Qty = LT24_Qty
                .LT24_Offshore_Qty = LT24_Offshore_Qty
                .LT24FB_Qty = LT24FB_Qty
                .LTB_Label = LTB_Label
                .Strip_Label = Strip_Label
                .Bus_Section = Bus_Section
                .OutLink100 = OutLink100
                    .OutLink500 = OutLink500
                    .SupInsOutLink1000 = SupInsOutLink1000
                    .SynConn = SynConn
                    .CableLug1Hole = CableLug1Hole
                    .CableLug2Hole = CableLug2Hole
                .UserID = UserID
                If .SaveLVBContract() Then
                    MessageBox.Show("Contract saved. ", "LVB Contract", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Else
                    MessageBox.Show("Duplicated Contract Number! Please re-enter Contract No.", "LVB Contract", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        End If
    End Sub

    Private Sub RetrieveFromForm()
        Contract_No = Me.ContractNoTxt.Text
        LTL_Qty = Me.LTLQtyTxt.Text
        LTL_Offshore_Qty = Me.LTLOffshoreTxt.Text
        LT16_Qty = Me.LT16Qtytxt.Text
        LT16_Offshore_Qty = Me.LT16Offshoretxt.Text
        LT24_Qty = Me.LT24Qtytxt.Text
        LT24_Offshore_Qty = Me.LT24Offshoretxt.Text
        LT24FB_Qty = Me.LT24FBQtytxt.Text
        LTB_Label = Me.LTBLabeltxt.Text
        Strip_Label = Me.StripLabelTxt.Text
        Bus_Section = Me.BusSectionTxt.Text
        OutLink100 = Me.Outlink100txt.Text
        OutLink500 = Me.Outlink500txt.Text
        SupInsOutLink1000 = Me.SUPINSOUTLINK1000_txt.Text
        SynConn = Me.SynConnTxt.Text
        CableLug1Hole = Me.CableLug1Hole_edit.Text
        CableLug2Hole = Me.CableLug2Hole_edit.Text
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(Contract_No) > 0 Then
            DataOK_Flag = False
            FieldName = "Contract No" & Chr(13)
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

    Private Sub LVBContractForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Contract?", "LVB Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
