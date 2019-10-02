Public Class MyCompanyForm
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents MyCompanyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MyCountryTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MyAddMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MyPostalTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MyTelTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MyFaxTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents URLTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.MyCompanyTxt = New DevExpress.XtraEditors.TextEdit
        Me.MyCountryTxt = New DevExpress.XtraEditors.TextEdit
        Me.MyAddMemo = New DevExpress.XtraEditors.MemoEdit
        Me.MyPostalTxt = New DevExpress.XtraEditors.TextEdit
        Me.MyTelTxt = New DevExpress.XtraEditors.TextEdit
        Me.MyFaxTxt = New DevExpress.XtraEditors.TextEdit
        Me.URLTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.MyCompanyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyCountryTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyAddMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyPostalTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyTelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyFaxTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.URLTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Address :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Company Name :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Country :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Postal :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Tel No. :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(224, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Fax No. :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "URL :"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(224, 216)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 45
        Me.SaveBtn.Text = "&Save"
        '
        'XtraButton1
        '
        Me.XtraButton1.AutoSize = False
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(296, 216)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(64, 24)
        Me.XtraButton1.TabIndex = 46
        Me.XtraButton1.Text = "&Cancel"
        '
        'MyCompanyTxt
        '
        Me.MyCompanyTxt.Location = New System.Drawing.Point(104, 24)
        Me.MyCompanyTxt.Name = "MyCompanyTxt"
        Me.MyCompanyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MyCompanyTxt.Size = New System.Drawing.Size(256, 21)
        Me.MyCompanyTxt.TabIndex = 47
        '
        'MyCountryTxt
        '
        Me.MyCountryTxt.Location = New System.Drawing.Point(104, 112)
        Me.MyCountryTxt.Name = "MyCountryTxt"
        Me.MyCountryTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MyCountryTxt.Size = New System.Drawing.Size(112, 21)
        Me.MyCountryTxt.TabIndex = 48
        '
        'MyAddMemo
        '
        Me.MyAddMemo.Location = New System.Drawing.Point(104, 56)
        Me.MyAddMemo.Name = "MyAddMemo"
        Me.MyAddMemo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MyAddMemo.Size = New System.Drawing.Size(256, 48)
        Me.MyAddMemo.TabIndex = 49
        '
        'MyPostalTxt
        '
        Me.MyPostalTxt.Location = New System.Drawing.Point(280, 112)
        Me.MyPostalTxt.Name = "MyPostalTxt"
        Me.MyPostalTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MyPostalTxt.Size = New System.Drawing.Size(80, 21)
        Me.MyPostalTxt.TabIndex = 50
        '
        'MyTelTxt
        '
        Me.MyTelTxt.Location = New System.Drawing.Point(104, 144)
        Me.MyTelTxt.Name = "MyTelTxt"
        Me.MyTelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MyTelTxt.Size = New System.Drawing.Size(112, 21)
        Me.MyTelTxt.TabIndex = 51
        '
        'MyFaxTxt
        '
        Me.MyFaxTxt.Location = New System.Drawing.Point(280, 144)
        Me.MyFaxTxt.Name = "MyFaxTxt"
        Me.MyFaxTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MyFaxTxt.Size = New System.Drawing.Size(80, 21)
        Me.MyFaxTxt.TabIndex = 52
        '
        'URLTxt
        '
        Me.URLTxt.Location = New System.Drawing.Point(104, 176)
        Me.URLTxt.Name = "URLTxt"
        Me.URLTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.URLTxt.Size = New System.Drawing.Size(256, 21)
        Me.URLTxt.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 240)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'MyCompanyForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 253)
        Me.Controls.Add(Me.URLTxt)
        Me.Controls.Add(Me.MyFaxTxt)
        Me.Controls.Add(Me.MyTelTxt)
        Me.Controls.Add(Me.MyPostalTxt)
        Me.Controls.Add(Me.MyAddMemo)
        Me.Controls.Add(Me.MyCountryTxt)
        Me.Controls.Add(Me.MyCompanyTxt)
        Me.Controls.Add(Me.XtraButton1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MyCompanyForm"
        Me.Text = "My Company Profile"
        CType(Me.MyCompanyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyCountryTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyAddMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyPostalTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyTelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyFaxTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.URLTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click

    End Sub
End Class
