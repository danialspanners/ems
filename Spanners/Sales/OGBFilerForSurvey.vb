Public Class OGBFilerForSurveyForm
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
    Friend WithEvents LocMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OfficerCmb As DevExpress.XtraEditors.ComboBox
    Friend WithEvents CustNameCmb As DevExpress.XtraEditors.ComboBox
    Friend WithEvents SectionTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustNameLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ExtCompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ExtCommenceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CommenceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InstallDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TOCSentDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TOCRecvDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents F28RecvDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToExtSurveyDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FmExtSurveyDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ExtSurveyInvDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ExtSurveyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents JobIssueTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SurveyByTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents FirstSurveyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents FirstModemTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents RejectDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents RejectMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SecondModemTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SecondSurveyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents SecSurveyByTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents MRCTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents OGB2YTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGB1YTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGB2XTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OGB1XTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ContractTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label42 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ContractTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.LocMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OfficerCmb = New DevExpress.XtraEditors.ComboBox
        Me.CustNameCmb = New DevExpress.XtraEditors.ComboBox
        Me.SectionTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CustNameLbl = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.F28RecvDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.TOCSentDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.TOCRecvDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.InstallDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.ExtCompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.ExtCommenceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.CompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CommenceDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ExtSurveyInvDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.FmExtSurveyDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToExtSurveyDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ExtSurveyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.OGB2YTxt = New DevExpress.XtraEditors.TextEdit
        Me.OGB1YTxt = New DevExpress.XtraEditors.TextEdit
        Me.OGB2XTxt = New DevExpress.XtraEditors.TextEdit
        Me.OGB1XTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.MRCTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.SecondModemTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.SecondSurveyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.SecSurveyByTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.RejectMemo = New DevExpress.XtraEditors.MemoEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.RejectDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.FirstModemTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.FirstSurveyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.SurveyByTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.JobIssueTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.ContractTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustNameCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.F28RecvDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOCSentDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOCRecvDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtCompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtCommenceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommenceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ExtSurveyInvDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FmExtSurveyDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToExtSurveyDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtSurveyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.OGB2YTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGB1YTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGB2XTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGB1XTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRCTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondModemTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondSurveyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecSurveyByTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejectMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejectDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstModemTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstSurveyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurveyByTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobIssueTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ContractTxt)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.LocMemo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OfficerCmb)
        Me.GroupBox1.Controls.Add(Me.CustNameCmb)
        Me.GroupBox1.Controls.Add(Me.SectionTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CustNameLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ContractTxt
        '
        Me.ContractTxt.Location = New System.Drawing.Point(408, 16)
        Me.ContractTxt.Name = "ContractTxt"
        Me.ContractTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractTxt.Size = New System.Drawing.Size(80, 19)
        Me.ContractTxt.TabIndex = 79
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(344, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 16)
        Me.Label42.TabIndex = 78
        Me.Label42.Text = "Contract :"
        '
        'LocMemo
        '
        Me.LocMemo.Location = New System.Drawing.Point(112, 80)
        Me.LocMemo.Name = "LocMemo"
        Me.LocMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LocMemo.Size = New System.Drawing.Size(376, 32)
        Me.LocMemo.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Location :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Section :"
        '
        'OfficerCmb
        '
        Me.OfficerCmb.Location = New System.Drawing.Point(112, 48)
        Me.OfficerCmb.Name = "OfficerCmb"
        Me.OfficerCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OfficerCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.OfficerCmb.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OfficerCmb.Size = New System.Drawing.Size(224, 19)
        Me.OfficerCmb.TabIndex = 67
        '
        'CustNameCmb
        '
        Me.CustNameCmb.Location = New System.Drawing.Point(112, 16)
        Me.CustNameCmb.Name = "CustNameCmb"
        Me.CustNameCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustNameCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustNameCmb.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustNameCmb.Size = New System.Drawing.Size(224, 19)
        Me.CustNameCmb.TabIndex = 66
        '
        'SectionTxt
        '
        Me.SectionTxt.Location = New System.Drawing.Point(408, 48)
        Me.SectionTxt.Name = "SectionTxt"
        Me.SectionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SectionTxt.Size = New System.Drawing.Size(80, 19)
        Me.SectionTxt.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "* Officer in Charge :"
        '
        'CustNameLbl
        '
        Me.CustNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameLbl.Location = New System.Drawing.Point(8, 20)
        Me.CustNameLbl.Name = "CustNameLbl"
        Me.CustNameLbl.Size = New System.Drawing.Size(104, 16)
        Me.CustNameLbl.TabIndex = 26
        Me.CustNameLbl.Text = "* Customer Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.F28RecvDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.TOCSentDateEdit)
        Me.GroupBox2.Controls.Add(Me.TOCRecvDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.InstallDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ExtCompleteDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ExtCommenceDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CompleteDateEdit)
        Me.GroupBox2.Controls.Add(Me.CommenceDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 144)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        '
        'F28RecvDateEdit
        '
        Me.F28RecvDateEdit.DateTime = New Date(CType(0, Long))
        Me.F28RecvDateEdit.Location = New System.Drawing.Point(136, 112)
        Me.F28RecvDateEdit.Name = "F28RecvDateEdit"
        Me.F28RecvDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.F28RecvDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.F28RecvDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.F28RecvDateEdit.TabIndex = 127
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 114)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 16)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "F0028 Receive Date :"
        '
        'TOCSentDateEdit
        '
        Me.TOCSentDateEdit.DateTime = New Date(CType(0, Long))
        Me.TOCSentDateEdit.Location = New System.Drawing.Point(392, 80)
        Me.TOCSentDateEdit.Name = "TOCSentDateEdit"
        Me.TOCSentDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TOCSentDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TOCSentDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.TOCSentDateEdit.TabIndex = 125
        '
        'TOCRecvDateEdit
        '
        Me.TOCRecvDateEdit.DateTime = New Date(CType(0, Long))
        Me.TOCRecvDateEdit.Location = New System.Drawing.Point(392, 112)
        Me.TOCRecvDateEdit.Name = "TOCRecvDateEdit"
        Me.TOCRecvDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TOCRecvDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TOCRecvDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.TOCRecvDateEdit.TabIndex = 124
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(280, 114)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 16)
        Me.Label29.TabIndex = 123
        Me.Label29.Text = "TOC Return Date :"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(280, 86)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 16)
        Me.Label28.TabIndex = 122
        Me.Label28.Text = "TOC Sent Date :"
        '
        'InstallDateEdit
        '
        Me.InstallDateEdit.DateTime = New Date(CType(0, Long))
        Me.InstallDateEdit.Location = New System.Drawing.Point(136, 80)
        Me.InstallDateEdit.Name = "InstallDateEdit"
        Me.InstallDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstallDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.InstallDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.InstallDateEdit.TabIndex = 101
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Installation Date :"
        '
        'ExtCompleteDateEdit
        '
        Me.ExtCompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExtCompleteDateEdit.Location = New System.Drawing.Point(392, 48)
        Me.ExtCompleteDateEdit.Name = "ExtCompleteDateEdit"
        Me.ExtCompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtCompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExtCompleteDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.ExtCompleteDateEdit.TabIndex = 91
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Extend Completion Date :"
        '
        'ExtCommenceDateEdit
        '
        Me.ExtCommenceDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExtCommenceDateEdit.Location = New System.Drawing.Point(392, 16)
        Me.ExtCommenceDateEdit.Name = "ExtCommenceDateEdit"
        Me.ExtCommenceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtCommenceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExtCommenceDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.ExtCommenceDateEdit.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(280, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Extend / Revised Commence Date :"
        '
        'CompleteDateEdit
        '
        Me.CompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.CompleteDateEdit.Location = New System.Drawing.Point(136, 48)
        Me.CompleteDateEdit.Name = "CompleteDateEdit"
        Me.CompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CompleteDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.CompleteDateEdit.TabIndex = 87
        '
        'CommenceDateEdit
        '
        Me.CommenceDateEdit.DateTime = New Date(CType(0, Long))
        Me.CommenceDateEdit.Location = New System.Drawing.Point(136, 16)
        Me.CommenceDateEdit.Name = "CommenceDateEdit"
        Me.CommenceDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CommenceDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CommenceDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.CommenceDateEdit.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Completion Date :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Commence Date :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ExtSurveyInvDateEdit)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.FmExtSurveyDateEdit)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DateEdit1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ToExtSurveyDateEdit)
        Me.GroupBox3.Controls.Add(Me.ExtSurveyTxt)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 112)
        Me.GroupBox3.TabIndex = 82
        Me.GroupBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "Ext Survey Rem :"
        '
        'ExtSurveyInvDateEdit
        '
        Me.ExtSurveyInvDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExtSurveyInvDateEdit.Location = New System.Drawing.Point(392, 48)
        Me.ExtSurveyInvDateEdit.Name = "ExtSurveyInvDateEdit"
        Me.ExtSurveyInvDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtSurveyInvDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExtSurveyInvDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.ExtSurveyInvDateEdit.TabIndex = 135
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(280, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Ext Survey Inv Date :"
        '
        'FmExtSurveyDateEdit
        '
        Me.FmExtSurveyDateEdit.DateTime = New Date(CType(0, Long))
        Me.FmExtSurveyDateEdit.Location = New System.Drawing.Point(136, 48)
        Me.FmExtSurveyDateEdit.Name = "FmExtSurveyDateEdit"
        Me.FmExtSurveyDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.FmExtSurveyDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.FmExtSurveyDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.FmExtSurveyDateEdit.TabIndex = 133
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Fm Ext Survey Date :"
        '
        'DateEdit1
        '
        Me.DateEdit1.DateTime = New Date(CType(0, Long))
        Me.DateEdit1.Location = New System.Drawing.Point(392, 16)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DateEdit1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DateEdit1.Size = New System.Drawing.Size(96, 19)
        Me.DateEdit1.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 32)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Ext Survey Exp Comp Date :"
        '
        'ToExtSurveyDateEdit
        '
        Me.ToExtSurveyDateEdit.DateTime = New Date(CType(0, Long))
        Me.ToExtSurveyDateEdit.Location = New System.Drawing.Point(136, 16)
        Me.ToExtSurveyDateEdit.Name = "ToExtSurveyDateEdit"
        Me.ToExtSurveyDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ToExtSurveyDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ToExtSurveyDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.ToExtSurveyDateEdit.TabIndex = 129
        '
        'ExtSurveyTxt
        '
        Me.ExtSurveyTxt.Location = New System.Drawing.Point(136, 80)
        Me.ExtSurveyTxt.Name = "ExtSurveyTxt"
        Me.ExtSurveyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExtSurveyTxt.Size = New System.Drawing.Size(352, 19)
        Me.ExtSurveyTxt.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 22)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "To Ext Survey Date :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 402)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Job Issue to Survey :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OGB2YTxt)
        Me.GroupBox4.Controls.Add(Me.OGB1YTxt)
        Me.GroupBox4.Controls.Add(Me.OGB2XTxt)
        Me.GroupBox4.Controls.Add(Me.OGB1XTxt)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.MRCTxt)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.SecondModemTxt)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.SecondSurveyTxt)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.SecSurveyByTxt)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.RejectMemo)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.RejectDateEdit)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.FirstModemTxt)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.FirstSurveyTxt)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.SurveyByTxt)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.JobIssueTxt)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 384)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(504, 320)
        Me.GroupBox4.TabIndex = 138
        Me.GroupBox4.TabStop = False
        '
        'OGB2YTxt
        '
        Me.OGB2YTxt.Location = New System.Drawing.Point(400, 288)
        Me.OGB2YTxt.Name = "OGB2YTxt"
        Me.OGB2YTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB2YTxt.Size = New System.Drawing.Size(96, 19)
        Me.OGB2YTxt.TabIndex = 163
        '
        'OGB1YTxt
        '
        Me.OGB1YTxt.Location = New System.Drawing.Point(400, 256)
        Me.OGB1YTxt.Name = "OGB1YTxt"
        Me.OGB1YTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB1YTxt.Size = New System.Drawing.Size(96, 19)
        Me.OGB1YTxt.TabIndex = 162
        '
        'OGB2XTxt
        '
        Me.OGB2XTxt.Location = New System.Drawing.Point(136, 288)
        Me.OGB2XTxt.Name = "OGB2XTxt"
        Me.OGB2XTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB2XTxt.Size = New System.Drawing.Size(96, 19)
        Me.OGB2XTxt.TabIndex = 161
        '
        'OGB1XTxt
        '
        Me.OGB1XTxt.Location = New System.Drawing.Point(136, 256)
        Me.OGB1XTxt.Name = "OGB1XTxt"
        Me.OGB1XTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGB1XTxt.Size = New System.Drawing.Size(96, 19)
        Me.OGB1XTxt.TabIndex = 160
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(280, 288)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 16)
        Me.Label24.TabIndex = 159
        Me.Label24.Text = "OGB2 Y Coordinates :"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(280, 256)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 16)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "OGB1 Y Coordinates :"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 288)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 16)
        Me.Label26.TabIndex = 157
        Me.Label26.Text = "OGB2 X Coordinates :"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 256)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 156
        Me.Label27.Text = "OGB1 X Coordinates :"
        '
        'MRCTxt
        '
        Me.MRCTxt.Location = New System.Drawing.Point(136, 224)
        Me.MRCTxt.Name = "MRCTxt"
        Me.MRCTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MRCTxt.Size = New System.Drawing.Size(96, 19)
        Me.MRCTxt.TabIndex = 155
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 16)
        Me.Label23.TabIndex = 154
        Me.Label23.Text = "MRC No :"
        '
        'SecondModemTxt
        '
        Me.SecondModemTxt.Location = New System.Drawing.Point(400, 192)
        Me.SecondModemTxt.Name = "SecondModemTxt"
        Me.SecondModemTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SecondModemTxt.Size = New System.Drawing.Size(96, 19)
        Me.SecondModemTxt.TabIndex = 153
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(296, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 16)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "2nd Modem Send :"
        '
        'SecondSurveyTxt
        '
        Me.SecondSurveyTxt.Location = New System.Drawing.Point(136, 192)
        Me.SecondSurveyTxt.Name = "SecondSurveyTxt"
        Me.SecondSurveyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SecondSurveyTxt.Size = New System.Drawing.Size(96, 19)
        Me.SecondSurveyTxt.TabIndex = 151
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 192)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 150
        Me.Label21.Text = "2nd Survey :"
        '
        'SecSurveyByTxt
        '
        Me.SecSurveyByTxt.Location = New System.Drawing.Point(136, 160)
        Me.SecSurveyByTxt.Name = "SecSurveyByTxt"
        Me.SecSurveyByTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SecSurveyByTxt.Size = New System.Drawing.Size(152, 19)
        Me.SecSurveyByTxt.TabIndex = 149
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 162)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 148
        Me.Label22.Text = "2nd Survey By :"
        '
        'RejectMemo
        '
        Me.RejectMemo.Location = New System.Drawing.Point(136, 112)
        Me.RejectMemo.Name = "RejectMemo"
        Me.RejectMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RejectMemo.Size = New System.Drawing.Size(360, 40)
        Me.RejectMemo.TabIndex = 147
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 32)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "Reason for Rejection :"
        '
        'RejectDateEdit
        '
        Me.RejectDateEdit.DateTime = New Date(CType(0, Long))
        Me.RejectDateEdit.Location = New System.Drawing.Point(400, 80)
        Me.RejectDateEdit.Name = "RejectDateEdit"
        Me.RejectDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RejectDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.RejectDateEdit.Size = New System.Drawing.Size(96, 19)
        Me.RejectDateEdit.TabIndex = 145
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(296, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 32)
        Me.Label18.TabIndex = 144
        Me.Label18.Text = "1st Survey Rejected On :"
        '
        'FirstModemTxt
        '
        Me.FirstModemTxt.Location = New System.Drawing.Point(400, 48)
        Me.FirstModemTxt.Name = "FirstModemTxt"
        Me.FirstModemTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.FirstModemTxt.Size = New System.Drawing.Size(96, 19)
        Me.FirstModemTxt.TabIndex = 143
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(296, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 142
        Me.Label17.Text = "1st Modem Send :"
        '
        'FirstSurveyTxt
        '
        Me.FirstSurveyTxt.Location = New System.Drawing.Point(136, 80)
        Me.FirstSurveyTxt.Name = "FirstSurveyTxt"
        Me.FirstSurveyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.FirstSurveyTxt.Size = New System.Drawing.Size(96, 19)
        Me.FirstSurveyTxt.TabIndex = 141
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 140
        Me.Label16.Text = "1st Survey :"
        '
        'SurveyByTxt
        '
        Me.SurveyByTxt.Location = New System.Drawing.Point(136, 48)
        Me.SurveyByTxt.Name = "SurveyByTxt"
        Me.SurveyByTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SurveyByTxt.Size = New System.Drawing.Size(152, 19)
        Me.SurveyByTxt.TabIndex = 139
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "1st Survey By :"
        '
        'JobIssueTxt
        '
        Me.JobIssueTxt.Location = New System.Drawing.Point(136, 16)
        Me.JobIssueTxt.Name = "JobIssueTxt"
        Me.JobIssueTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.JobIssueTxt.Size = New System.Drawing.Size(96, 19)
        Me.JobIssueTxt.TabIndex = 129
        '
        'OGBFilerForSurveyForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 746)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "OGBFilerForSurveyForm"
        Me.Text = "OGB Filer For Survey"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ContractTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustNameCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.F28RecvDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOCSentDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOCRecvDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtCompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtCommenceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommenceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ExtSurveyInvDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FmExtSurveyDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToExtSurveyDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtSurveyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.OGB2YTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGB1YTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGB2XTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGB1XTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRCTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondModemTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondSurveyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecSurveyByTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejectMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejectDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstModemTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstSurveyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurveyByTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobIssueTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
