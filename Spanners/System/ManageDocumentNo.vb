Public Class DocumentNoForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuoIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents QuoTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OCTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OCIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents WOTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WOIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DOTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DORTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DOIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DORIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DNTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DNIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PRTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PRIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents POTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents POIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WPTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WPIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TOCTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TOCIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SOCTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SOCIncValtxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DrawIncValTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DrawTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SOTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SOIncValtxt As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents SRVIncValtxt As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents SRVTxt As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents Label16 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.SOIncValtxt = New DevExpress.XtraEditors.SpinEdit
		Me.SOTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label15 = New System.Windows.Forms.Label
		Me.DrawIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.DrawTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label14 = New System.Windows.Forms.Label
		Me.SOCIncValtxt = New DevExpress.XtraEditors.SpinEdit
		Me.SOCTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label13 = New System.Windows.Forms.Label
		Me.TOCIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.TOCTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.WPIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.WPTxt = New DevExpress.XtraEditors.SpinEdit
		Me.POIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.POTxt = New DevExpress.XtraEditors.SpinEdit
		Me.PRIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.PRTxt = New DevExpress.XtraEditors.SpinEdit
		Me.DNIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.DNTxt = New DevExpress.XtraEditors.SpinEdit
		Me.DORIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.DOIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.DORTxt = New DevExpress.XtraEditors.SpinEdit
		Me.DOTxt = New DevExpress.XtraEditors.SpinEdit
		Me.WOIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.WOTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.OCIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.OCTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label2 = New System.Windows.Forms.Label
		Me.QuoIncValTxt = New DevExpress.XtraEditors.SpinEdit
		Me.QuoTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label1 = New System.Windows.Forms.Label
		Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
		Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
		Me.SRVIncValtxt = New DevExpress.XtraEditors.SpinEdit
		Me.SRVTxt = New DevExpress.XtraEditors.SpinEdit
		Me.Label16 = New System.Windows.Forms.Label
		Me.GroupBox1.SuspendLayout()
		CType(Me.SOIncValtxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DrawIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DrawTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SOCIncValtxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SOCTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TOCIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TOCTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WPIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WPTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.POIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.POTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PRIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PRTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DNIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DNTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DORIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DOIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DORTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WOIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WOTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OCIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OCTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QuoIncValTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QuoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SRVIncValtxt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SRVTxt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.SRVIncValtxt)
		Me.GroupBox1.Controls.Add(Me.SRVTxt)
		Me.GroupBox1.Controls.Add(Me.Label16)
		Me.GroupBox1.Controls.Add(Me.SOIncValtxt)
		Me.GroupBox1.Controls.Add(Me.SOTxt)
		Me.GroupBox1.Controls.Add(Me.Label15)
		Me.GroupBox1.Controls.Add(Me.DrawIncValTxt)
		Me.GroupBox1.Controls.Add(Me.DrawTxt)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.SOCIncValtxt)
		Me.GroupBox1.Controls.Add(Me.SOCTxt)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.TOCIncValTxt)
		Me.GroupBox1.Controls.Add(Me.TOCTxt)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.WPIncValTxt)
		Me.GroupBox1.Controls.Add(Me.WPTxt)
		Me.GroupBox1.Controls.Add(Me.POIncValTxt)
		Me.GroupBox1.Controls.Add(Me.POTxt)
		Me.GroupBox1.Controls.Add(Me.PRIncValTxt)
		Me.GroupBox1.Controls.Add(Me.PRTxt)
		Me.GroupBox1.Controls.Add(Me.DNIncValTxt)
		Me.GroupBox1.Controls.Add(Me.DNTxt)
		Me.GroupBox1.Controls.Add(Me.DORIncValTxt)
		Me.GroupBox1.Controls.Add(Me.DOIncValTxt)
		Me.GroupBox1.Controls.Add(Me.DORTxt)
		Me.GroupBox1.Controls.Add(Me.DOTxt)
		Me.GroupBox1.Controls.Add(Me.WOIncValTxt)
		Me.GroupBox1.Controls.Add(Me.WOTxt)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.OCIncValTxt)
		Me.GroupBox1.Controls.Add(Me.OCTxt)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.QuoIncValTxt)
		Me.GroupBox1.Controls.Add(Me.QuoTxt)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(392, 488)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		'
		'SOIncValtxt
		'
		Me.SOIncValtxt.Location = New System.Drawing.Point(288, 424)
		Me.SOIncValtxt.Name = "SOIncValtxt"
		Me.SOIncValtxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.SOIncValtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.SOIncValtxt.Size = New System.Drawing.Size(40, 19)
		Me.SOIncValtxt.TabIndex = 40
		Me.SOIncValtxt.Text = "0"
		'
		'SOTxt
		'
		Me.SOTxt.Location = New System.Drawing.Point(168, 424)
		Me.SOTxt.Name = "SOTxt"
		Me.SOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.SOTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.SOTxt.Size = New System.Drawing.Size(75, 19)
		Me.SOTxt.TabIndex = 39
		Me.SOTxt.Text = "0"
		'
		'Label15
		'
		Me.Label15.Location = New System.Drawing.Point(16, 424)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(100, 16)
		Me.Label15.TabIndex = 38
		Me.Label15.Text = "Service Order"
		'
		'DrawIncValTxt
		'
		Me.DrawIncValTxt.Location = New System.Drawing.Point(288, 392)
		Me.DrawIncValTxt.Name = "DrawIncValTxt"
		Me.DrawIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DrawIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DrawIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.DrawIncValTxt.TabIndex = 37
		Me.DrawIncValTxt.Text = "0"
		'
		'DrawTxt
		'
		Me.DrawTxt.Location = New System.Drawing.Point(168, 392)
		Me.DrawTxt.Name = "DrawTxt"
		Me.DrawTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DrawTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DrawTxt.Size = New System.Drawing.Size(75, 19)
		Me.DrawTxt.TabIndex = 36
		Me.DrawTxt.Text = "0"
		'
		'Label14
		'
		Me.Label14.Location = New System.Drawing.Point(16, 400)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(100, 16)
		Me.Label14.TabIndex = 35
		Me.Label14.Text = "Drawing"
		'
		'SOCIncValtxt
		'
		Me.SOCIncValtxt.Location = New System.Drawing.Point(288, 360)
		Me.SOCIncValtxt.Name = "SOCIncValtxt"
		Me.SOCIncValtxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.SOCIncValtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.SOCIncValtxt.Size = New System.Drawing.Size(40, 19)
		Me.SOCIncValtxt.TabIndex = 34
		Me.SOCIncValtxt.Text = "0"
		'
		'SOCTxt
		'
		Me.SOCTxt.Location = New System.Drawing.Point(168, 360)
		Me.SOCTxt.Name = "SOCTxt"
		Me.SOCTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.SOCTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.SOCTxt.Size = New System.Drawing.Size(75, 19)
		Me.SOCTxt.TabIndex = 33
		Me.SOCTxt.Text = "0"
		'
		'Label13
		'
		Me.Label13.Location = New System.Drawing.Point(16, 368)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(100, 16)
		Me.Label13.TabIndex = 32
		Me.Label13.Text = "Services OC"
		'
		'TOCIncValTxt
		'
		Me.TOCIncValTxt.Location = New System.Drawing.Point(288, 328)
		Me.TOCIncValTxt.Name = "TOCIncValTxt"
		Me.TOCIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.TOCIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TOCIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.TOCIncValTxt.TabIndex = 31
		Me.TOCIncValTxt.Text = "0"
		'
		'TOCTxt
		'
		Me.TOCTxt.Location = New System.Drawing.Point(168, 328)
		Me.TOCTxt.Name = "TOCTxt"
		Me.TOCTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.TOCTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TOCTxt.Size = New System.Drawing.Size(75, 19)
		Me.TOCTxt.TabIndex = 30
		Me.TOCTxt.Text = "0"
		'
		'Label12
		'
		Me.Label12.Location = New System.Drawing.Point(16, 336)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(100, 16)
		Me.Label12.TabIndex = 29
		Me.Label12.Text = "Trading OC"
		'
		'Label11
		'
		Me.Label11.Location = New System.Drawing.Point(272, 16)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(88, 16)
		Me.Label11.TabIndex = 28
		Me.Label11.Text = "Increment Value"
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(160, 16)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(104, 16)
		Me.Label10.TabIndex = 27
		Me.Label10.Text = "Document Number"
		'
		'WPIncValTxt
		'
		Me.WPIncValTxt.Location = New System.Drawing.Point(288, 296)
		Me.WPIncValTxt.Name = "WPIncValTxt"
		Me.WPIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.WPIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.WPIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.WPIncValTxt.TabIndex = 26
		Me.WPIncValTxt.Text = "0"
		'
		'WPTxt
		'
		Me.WPTxt.Location = New System.Drawing.Point(168, 296)
		Me.WPTxt.Name = "WPTxt"
		Me.WPTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.WPTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.WPTxt.Size = New System.Drawing.Size(75, 19)
		Me.WPTxt.TabIndex = 25
		Me.WPTxt.Text = "0"
		'
		'POIncValTxt
		'
		Me.POIncValTxt.Location = New System.Drawing.Point(288, 264)
		Me.POIncValTxt.Name = "POIncValTxt"
		Me.POIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.POIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.POIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.POIncValTxt.TabIndex = 24
		Me.POIncValTxt.Text = "0"
		'
		'POTxt
		'
		Me.POTxt.Location = New System.Drawing.Point(168, 264)
		Me.POTxt.Name = "POTxt"
		Me.POTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.POTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.POTxt.Size = New System.Drawing.Size(75, 19)
		Me.POTxt.TabIndex = 23
		Me.POTxt.Text = "0"
		'
		'PRIncValTxt
		'
		Me.PRIncValTxt.Location = New System.Drawing.Point(288, 232)
		Me.PRIncValTxt.Name = "PRIncValTxt"
		Me.PRIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.PRIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.PRIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.PRIncValTxt.TabIndex = 22
		Me.PRIncValTxt.Text = "0"
		'
		'PRTxt
		'
		Me.PRTxt.Location = New System.Drawing.Point(168, 232)
		Me.PRTxt.Name = "PRTxt"
		Me.PRTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.PRTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.PRTxt.Size = New System.Drawing.Size(75, 19)
		Me.PRTxt.TabIndex = 21
		Me.PRTxt.Text = "0"
		'
		'DNIncValTxt
		'
		Me.DNIncValTxt.Location = New System.Drawing.Point(288, 200)
		Me.DNIncValTxt.Name = "DNIncValTxt"
		Me.DNIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DNIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DNIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.DNIncValTxt.TabIndex = 20
		Me.DNIncValTxt.Text = "0"
		'
		'DNTxt
		'
		Me.DNTxt.Location = New System.Drawing.Point(168, 200)
		Me.DNTxt.Name = "DNTxt"
		Me.DNTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DNTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DNTxt.Size = New System.Drawing.Size(75, 19)
		Me.DNTxt.TabIndex = 19
		Me.DNTxt.Text = "0"
		'
		'DORIncValTxt
		'
		Me.DORIncValTxt.Location = New System.Drawing.Point(288, 168)
		Me.DORIncValTxt.Name = "DORIncValTxt"
		Me.DORIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DORIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DORIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.DORIncValTxt.TabIndex = 18
		Me.DORIncValTxt.Text = "0"
		'
		'DOIncValTxt
		'
		Me.DOIncValTxt.Location = New System.Drawing.Point(288, 136)
		Me.DOIncValTxt.Name = "DOIncValTxt"
		Me.DOIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DOIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DOIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.DOIncValTxt.TabIndex = 17
		Me.DOIncValTxt.Text = "0"
		'
		'DORTxt
		'
		Me.DORTxt.Location = New System.Drawing.Point(168, 168)
		Me.DORTxt.Name = "DORTxt"
		Me.DORTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DORTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DORTxt.Size = New System.Drawing.Size(75, 19)
		Me.DORTxt.TabIndex = 16
		Me.DORTxt.Text = "0"
		'
		'DOTxt
		'
		Me.DOTxt.Location = New System.Drawing.Point(168, 136)
		Me.DOTxt.Name = "DOTxt"
		Me.DOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.DOTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.DOTxt.Size = New System.Drawing.Size(75, 19)
		Me.DOTxt.TabIndex = 15
		Me.DOTxt.Text = "0"
		'
		'WOIncValTxt
		'
		Me.WOIncValTxt.Location = New System.Drawing.Point(288, 104)
		Me.WOIncValTxt.Name = "WOIncValTxt"
		Me.WOIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.WOIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.WOIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.WOIncValTxt.TabIndex = 14
		Me.WOIncValTxt.Text = "0"
		'
		'WOTxt
		'
		Me.WOTxt.Location = New System.Drawing.Point(168, 104)
		Me.WOTxt.Name = "WOTxt"
		Me.WOTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.WOTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.WOTxt.Size = New System.Drawing.Size(75, 19)
		Me.WOTxt.TabIndex = 13
		Me.WOTxt.Text = "0"
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(16, 304)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(100, 16)
		Me.Label9.TabIndex = 12
		Me.Label9.Text = "Work Plan"
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(16, 272)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(100, 16)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "Purchase Order"
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(16, 240)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(112, 16)
		Me.Label7.TabIndex = 10
		Me.Label7.Text = "Purchase Requisition"
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(16, 208)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(100, 16)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Delivery Note"
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(16, 176)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(136, 16)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Delivery Order Reference"
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(16, 144)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 16)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Delivery Order"
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(16, 112)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(80, 16)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Work Order"
		'
		'OCIncValTxt
		'
		Me.OCIncValTxt.Location = New System.Drawing.Point(288, 72)
		Me.OCIncValTxt.Name = "OCIncValTxt"
		Me.OCIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.OCIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.OCIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.OCIncValTxt.TabIndex = 5
		Me.OCIncValTxt.Text = "0"
		'
		'OCTxt
		'
		Me.OCTxt.Location = New System.Drawing.Point(168, 72)
		Me.OCTxt.Name = "OCTxt"
		Me.OCTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.OCTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.OCTxt.Size = New System.Drawing.Size(75, 19)
		Me.OCTxt.TabIndex = 4
		Me.OCTxt.Text = "0"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(16, 80)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(100, 16)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Order Confirmation"
		'
		'QuoIncValTxt
		'
		Me.QuoIncValTxt.Location = New System.Drawing.Point(288, 40)
		Me.QuoIncValTxt.Name = "QuoIncValTxt"
		Me.QuoIncValTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.QuoIncValTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.QuoIncValTxt.Size = New System.Drawing.Size(40, 19)
		Me.QuoIncValTxt.TabIndex = 2
		Me.QuoIncValTxt.Text = "0"
		'
		'QuoTxt
		'
		Me.QuoTxt.Location = New System.Drawing.Point(168, 40)
		Me.QuoTxt.Name = "QuoTxt"
		Me.QuoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.QuoTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.QuoTxt.Size = New System.Drawing.Size(75, 19)
		Me.QuoTxt.TabIndex = 1
		Me.QuoTxt.Text = "0"
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(16, 48)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(56, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Quotation"
		'
		'SaveBtn
		'
		Me.SaveBtn.AutoSize = False
		Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
		Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SaveBtn.Image = Nothing
		Me.SaveBtn.Location = New System.Drawing.Point(256, 512)
		Me.SaveBtn.Name = "SaveBtn"
		Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
		Me.SaveBtn.TabIndex = 1
		Me.SaveBtn.Text = "&Save"
		'
		'CancelBtn
		'
		Me.CancelBtn.AutoSize = False
		Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
		Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CancelBtn.Image = Nothing
		Me.CancelBtn.Location = New System.Drawing.Point(328, 512)
		Me.CancelBtn.Name = "CancelBtn"
		Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
		Me.CancelBtn.TabIndex = 2
		Me.CancelBtn.Text = "&Close"
		'
		'SRVIncValtxt
		'
		Me.SRVIncValtxt.Location = New System.Drawing.Point(288, 456)
		Me.SRVIncValtxt.Name = "SRVIncValtxt"
		Me.SRVIncValtxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.SRVIncValtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.SRVIncValtxt.Size = New System.Drawing.Size(40, 19)
		Me.SRVIncValtxt.TabIndex = 43
		Me.SRVIncValtxt.Text = "0"
		'
		'SRVTxt
		'
		Me.SRVTxt.Location = New System.Drawing.Point(168, 456)
		Me.SRVTxt.Name = "SRVTxt"
		Me.SRVTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
		Me.SRVTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.SRVTxt.Size = New System.Drawing.Size(75, 19)
		Me.SRVTxt.TabIndex = 42
		Me.SRVTxt.Text = "0"
		'
		'Label16
		'
		Me.Label16.Location = New System.Drawing.Point(16, 456)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(100, 16)
		Me.Label16.TabIndex = 41
		Me.Label16.Text = "SRV No."
		'
		'DocumentNoForm
		'
		Me.AutoScale = False
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(408, 549)
		Me.Controls.Add(Me.CancelBtn)
		Me.Controls.Add(Me.SaveBtn)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "DocumentNoForm"
		Me.Text = "Document Number"
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.SOIncValtxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SOTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DrawIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DrawTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SOCIncValtxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SOCTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TOCIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TOCTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WPIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WPTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.POIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.POTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PRIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PRTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DNIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DNTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DORIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DOIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DORTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DOTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WOIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WOTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OCIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OCTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QuoIncValTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QuoTxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SRVIncValtxt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SRVTxt, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region
    Public UserID As String = "1"
    Public QuoNextNumber As Integer
    Public QuoIncVal As Integer
    Public OCNextNumber As Integer
    Public OCIncVal As Integer
    Public WONextNumber As Integer
    Public WOIncVal As Integer
    Public DONextNumber As Integer
    Public DOIncVal As Integer
    Public DORNextNumber As Integer
    Public DORIncVal As Integer
    Public DNNextNumber As Integer
    Public DNIncVal As Integer
    Public PRNextNumber As Integer
    Public PRIncVal As Integer
    Public PONextNumber As Integer
    Public POIncVal As Integer
    Public WPNextNumber As Integer
    Public WPIncVal As Integer
    Public TOCNextNumber As Integer
    Public TOCIncVal As Integer
    Public SOCNextNumber As Integer
    Public SOCIncVal As Integer
    Public DrawNextNumber As Integer
    Public DrawIncVal As Integer
    Public SONextNumber As Integer
	Public SOIncVal As Integer
	Public SRVNextNumber As Integer
	Public SRVIncVal As Integer

    ' 06.01.2004 YG Start
    Dim FunctionName As String = "MyDocNo"
    ' 06.01.2004 YG End

    Private Sub DocumentNoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 06.01.2004 YG End

        LoadDocumentNo()
    End Sub

    Private Sub LoadDocumentNo()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.DocumentNumberBusLogic
            If .GetDocumentNumber(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    QuoTxt.Text = ds.Tables(0).Rows(0)("DocumentNextNumber")
                    QuoIncValTxt.Text = ds.Tables(0).Rows(0)("IncrementValue")
                    OCTxt.Text = ds.Tables(0).Rows(1)("DocumentNextNumber")
                    OCIncValTxt.Text = ds.Tables(0).Rows(1)("IncrementValue")
                    WOTxt.Text = ds.Tables(0).Rows(2)("DocumentNextNumber")
                    WOIncValTxt.Text = ds.Tables(0).Rows(2)("IncrementValue")
                    DOTxt.Text = ds.Tables(0).Rows(3)("DocumentNextNumber")
                    DOIncValTxt.Text = ds.Tables(0).Rows(3)("IncrementValue")
                    DORTxt.Text = ds.Tables(0).Rows(4)("DocumentNextNumber")
                    DORIncValTxt.Text = ds.Tables(0).Rows(4)("IncrementValue")
                    DNTxt.Text = ds.Tables(0).Rows(5)("DocumentNextNumber")
                    DNIncValTxt.Text = ds.Tables(0).Rows(5)("IncrementValue")
                    PRTxt.Text = ds.Tables(0).Rows(6)("DocumentNextNumber")
                    PRIncValTxt.Text = ds.Tables(0).Rows(6)("IncrementValue")
                    POTxt.Text = ds.Tables(0).Rows(7)("DocumentNextNumber")
                    POIncValTxt.Text = ds.Tables(0).Rows(7)("IncrementValue")
                    WPTxt.Text = ds.Tables(0).Rows(8)("DocumentNextNumber")
                    WPIncValTxt.Text = ds.Tables(0).Rows(8)("IncrementValue")
                    TOCTxt.Text = ds.Tables(0).Rows(9)("DocumentNextNumber")
                    TOCIncValTxt.Text = ds.Tables(0).Rows(9)("IncrementValue")
                    SOCTxt.Text = ds.Tables(0).Rows(10)("DocumentNextNumber")
                    SOCIncValtxt.Text = ds.Tables(0).Rows(10)("IncrementValue")
                    DrawTxt.Text = ds.Tables(0).Rows(11)("DocumentNextNumber")
                    DrawIncValTxt.Text = ds.Tables(0).Rows(11)("IncrementValue")
                    SOTxt.Text = ds.Tables(0).Rows(12)("DocumentNextNumber")
					SOIncValtxt.Text = ds.Tables(0).Rows(12)("IncrementValue")
					SRVTxt.Text = ds.Tables(0).Rows(13)("DocumentNextNumber")
					SRVIncValtxt.Text = ds.Tables(0).Rows(13)("IncrementValue")
                End If
            End If
        End With
        ds.Dispose()
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        RetrieveFromForm()
        If ValidData() Then
            With New BusinessRules.SystemBusRules.DocumentNumberBusLogic
                'UPDATE QUOTATION
                .DocumentCode = "QU"
                .DocumentNextNumber = QuoNextNumber
                .IncrementValue = QuoIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE ORDER CONFIRMATION
                .DocumentCode = "OC"
                .DocumentNextNumber = OCNextNumber
                .IncrementValue = OCIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE WORK ORDER
                .DocumentCode = "WO"
                .DocumentNextNumber = WONextNumber
                .IncrementValue = WOIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE DELIVERY ORDER
                .DocumentCode = "DO"
                .DocumentNextNumber = DONextNumber
                .IncrementValue = DOIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE DELIVERY ORDER REFERENCE
                .DocumentCode = "DOR"
                .DocumentNextNumber = DORNextNumber
                .IncrementValue = DORIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE DELIVERY NOTE
                .DocumentCode = "DN"
                .DocumentNextNumber = DNNextNumber
                .IncrementValue = DNIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE PR
                .DocumentCode = "PR"
                .DocumentNextNumber = PRNextNumber
                .IncrementValue = PRIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE PO
                .DocumentCode = "PO"
                .DocumentNextNumber = PONextNumber
                .IncrementValue = POIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE WORK PLAN
                .DocumentCode = "WP"
                .DocumentNextNumber = WPNextNumber
                .IncrementValue = WPIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE TRADING OC
                .DocumentCode = "TOC"
                .DocumentNextNumber = TOCNextNumber
                .IncrementValue = TOCIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE SERVICES OC
                .DocumentCode = "SOC"
                .DocumentNextNumber = SOCNextNumber
                .IncrementValue = SOCIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If

                '****
                'UPDATE DRAWING NUMBER
                .DocumentCode = "P"
                .DocumentNextNumber = DrawNextNumber
                .IncrementValue = DrawIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
                '****

                'UPDATE SERVICES ORDER
                .DocumentCode = "SO"
                .DocumentNextNumber = SONextNumber
                .IncrementValue = SOIncVal
                .UserID = UserID
                If .UpdateDocumentNumber() Then

                End If
				'****

				'UPDATE SRV No
				.DocumentCode = "SRV"
				.DocumentNextNumber = SRVNextNumber
				.IncrementValue = SRVIncVal
				.UserID = UserID
				If .UpdateDocumentNumber() Then

				End If
				'****


				MessageBox.Show("Data saved. ", "Document Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End With
        End If
    End Sub

    Private Sub RetrieveFromForm()
        If Len(QuoTxt.Text) > 0 Then
            QuoNextNumber = QuoTxt.Text
        End If
        If Len(QuoIncValTxt.Text) > 0 Then
            QuoIncVal = QuoIncValTxt.Text
        End If
        If Len(OCTxt.Text) > 0 Then
            OCNextNumber = OCTxt.Text
        End If
        If Len(OCIncValTxt.Text) > 0 Then
            OCIncVal = OCIncValTxt.Text
        End If
        If Len(WOTxt.Text) > 0 Then
            WONextNumber = WOTxt.Text
        End If
        If Len(WOIncValTxt.Text) > 0 Then
            WOIncVal = WOIncValTxt.Text
        End If
        If Len(DOTxt.Text) > 0 Then
            DONextNumber = DOTxt.Text
        End If
        If Len(DOIncValTxt.Text) > 0 Then
            DOIncVal = DOIncValTxt.Text
        End If
        If Len(DORTxt.Text) > 0 Then
            DORNextNumber = DORTxt.Text
        End If
        If Len(DORIncValTxt.Text) > 0 Then
            DORIncVal = DORIncValTxt.Text
        End If
        If Len(DNTxt.Text) > 0 Then
            DNNextNumber = DNTxt.Text
        End If
        If Len(DNIncValTxt.Text) > 0 Then
            DNIncVal = DNIncValTxt.Text
        End If
        If Len(PRTxt.Text) > 0 Then
            PRNextNumber = PRTxt.Text
        End If
        If Len(PRIncValTxt.Text) > 0 Then
            PRIncVal = PRIncValTxt.Text
        End If
        If Len(POTxt.Text) > 0 Then
            PONextNumber = POTxt.Text
        End If
        If Len(POIncValTxt.Text) > 0 Then
            POIncVal = POIncValTxt.Text
        End If
        If Len(WPTxt.Text) > 0 Then
            WPNextNumber = WPTxt.Text
        End If
        If Len(WPIncValTxt.Text) > 0 Then
            WPIncVal = WPIncValTxt.Text
        End If
        If Len(TOCTxt.Text) > 0 Then
            TOCNextNumber = TOCTxt.Text
        End If
        If Len(TOCIncValTxt.Text) > 0 Then
            TOCIncVal = TOCIncValTxt.Text
        End If
        If Len(SOCTxt.Text) > 0 Then
            SOCNextNumber = SOCTxt.Text
        End If
        If Len(SOCIncValtxt.Text) > 0 Then
            SOCIncVal = SOCIncValtxt.Text
        End If
        If Len(DrawTxt.Text) > 0 Then
            DrawNextNumber = DrawTxt.Text
        End If
        If Len(DrawIncValTxt.Text) > 0 Then
            DrawIncVal = DrawIncValTxt.Text
        End If
        If Len(SOTxt.Text) > 0 Then
            SONextNumber = SOTxt.Text
        End If
        If Len(SOIncValtxt.Text) > 0 Then
            SOIncVal = SOIncValtxt.Text
		End If

		If Len(SRVTxt.Text) > 0 Then
			SRVNextNumber = SRVTxt.Text
		End If
		If Len(SRVIncValtxt.Text) > 0 Then
			SRVIncVal = SRVIncValtxt.Text
		End If
    End Sub

    Private Function ValidData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(QuoNextNumber) > 0 Or QuoNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Quotation Next Number" & Chr(13)
        End If

        If Not Len(QuoIncVal) > 0 Or QuoIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Quotation Increment Value" & Chr(13)
        End If

        If Not Len(OCNextNumber) > 0 Or OCNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Order Confirmation Next Number" & Chr(13)
        End If

        If Not Len(OCIncVal) > 0 Or OCIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Order Confirmation Increment Value" & Chr(13)
        End If

        If Not Len(WONextNumber) > 0 Or WONextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Work Order Next Number" & Chr(13)
        End If

        If Not Len(WOIncVal) > 0 Or WOIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Work Order Increment Value" & Chr(13)
        End If

        If Not Len(DONextNumber) > 0 Or DONextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Delivery Order Next Number" & Chr(13)
        End If

        If Not Len(DOIncVal) > 0 Or DOIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Delivery Order Increment Value" & Chr(13)
        End If

        If Not Len(DORNextNumber) > 0 Or DORNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Delivery Order Reference Next Number" & Chr(13)
        End If

        If Not Len(DORIncVal) > 0 Or DORIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Delivery Order Reference Increment Value" & Chr(13)
        End If

        If Not Len(DNNextNumber) > 0 Or DNNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Delivery Note Next Number" & Chr(13)
        End If

        If Not Len(DNIncVal) > 0 Or DNIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Delivery Note Increment Value" & Chr(13)
        End If

        If Not Len(PRNextNumber) > 0 Or PRNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Purchase Requisition Next Number" & Chr(13)
        End If

        If Not Len(PRIncVal) > 0 Or PRIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Purchase Requisition Increment Value" & Chr(13)
        End If

        If Not Len(PONextNumber) > 0 Or PONextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Purchase Order Next Number" & Chr(13)
        End If

        If Not Len(POIncVal) > 0 Or POIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Purchase Order Increment Value" & Chr(13)
        End If

        If Not Len(WPNextNumber) > 0 Or WPNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Work Plan Next Number" & Chr(13)
        End If

        If Not Len(WPIncVal) > 0 Or WPIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Work Plan Increment Value" & Chr(13)
        End If

        If Not Len(TOCNextNumber) > 0 Or TOCNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Trading OC Next Number" & Chr(13)
        End If

        If Not Len(TOCIncVal) > 0 Or TOCIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Trading OC Increment Value" & Chr(13)
        End If

        If Not Len(SOCNextNumber) > 0 Or SOCNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Services OC Next Number" & Chr(13)
        End If

        If Not Len(SOCIncVal) > 0 Or SOCIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "SOC Increment Value" & Chr(13)
        End If

        If Not Len(DrawNextNumber) > 0 Or DrawNextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Drawing Number Next Number" & Chr(13)
        End If

        If Not Len(DrawIncVal) > 0 Or DrawIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "Drawing Number Increment Value" & Chr(13)
        End If

        If Not Len(SONextNumber) > 0 Or SONextNumber = 0 Then
            DataOK_Flag = False
            FieldName = "Survey Order Next Number" & Chr(13)
        End If

        If Not Len(SOIncVal) > 0 Or SOIncVal = 0 Then
            DataOK_Flag = False
            FieldName = "SO Increment Value" & Chr(13)
		End If

		If Not Len(SRVNextNumber) > 0 Or SRVNextNumber = 0 Then
			DataOK_Flag = False
			FieldName = "SRV Next Number" & Chr(13)
		End If

		If Not Len(SRVIncVal) > 0 Or SRVIncVal = 0 Then
			DataOK_Flag = False
			FieldName = "SRV Increment Value" & Chr(13)
		End If

		If Not DataOK_Flag Then
			With New Common.CommonError.ErrorMsg
				MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End With
		End If
		ValidData = DataOK_Flag
    End Function

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
    Private Sub DocumentNoForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
