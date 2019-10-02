Public Class PWUpdateForm
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
    Friend WithEvents LoginPWTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoginNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NewPWTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents UpdateBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.UpdateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.LoginPWTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LoginNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.NewPWTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.lblError = New System.Windows.Forms.Label
        CType(Me.LoginPWTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewPWTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(96, 148)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 77
        Me.CancelBtn.Text = "&Cancel"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.AutoSize = False
        Me.UpdateBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Image = Nothing
        Me.UpdateBtn.Location = New System.Drawing.Point(24, 148)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(64, 24)
        Me.UpdateBtn.TabIndex = 76
        Me.UpdateBtn.Text = "&Update"
        '
        'LoginPWTxt
        '
        Me.LoginPWTxt.Location = New System.Drawing.Point(136, 64)
        Me.LoginPWTxt.Name = "LoginPWTxt"
        Me.LoginPWTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LoginPWTxt.Properties.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.LoginPWTxt.Size = New System.Drawing.Size(104, 21)
        Me.LoginPWTxt.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Login Name :"
        '
        'LoginNameTxt
        '
        Me.LoginNameTxt.Enabled = False
        Me.LoginNameTxt.Location = New System.Drawing.Point(136, 32)
        Me.LoginNameTxt.Name = "LoginNameTxt"
        Me.LoginNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LoginNameTxt.Size = New System.Drawing.Size(104, 21)
        Me.LoginNameTxt.TabIndex = 73
        '
        'NewPWTxt
        '
        Me.NewPWTxt.Location = New System.Drawing.Point(136, 96)
        Me.NewPWTxt.Name = "NewPWTxt"
        Me.NewPWTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewPWTxt.Properties.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.NewPWTxt.Size = New System.Drawing.Size(104, 21)
        Me.NewPWTxt.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Confirm Password :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblError)
        Me.GroupBox1.Controls.Add(Me.CloseBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 176)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "My Password"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(160, 140)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 24)
        Me.CloseBtn.TabIndex = 78
        Me.CloseBtn.Text = "C&lose"
        '
        'lblError
        '
        Me.lblError.Location = New System.Drawing.Point(24, 118)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(200, 16)
        Me.lblError.TabIndex = 79
        '
        'PWUpdateForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 189)
        Me.Controls.Add(Me.NewPWTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.LoginPWTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginNameTxt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PWUpdateForm"
        Me.Text = "Password Update"
        CType(Me.LoginPWTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewPWTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PWUpdateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginNameTxt.Text = ""
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            Dim ds As DataSet
            .GetUser(ds, Common.CommonConn.Config.USERID)
            If Not ds Is Nothing Then
                LoginNameTxt.Text = ds.Tables(0).Rows(0)("Login_Id").ToString()
            End If
        End With
        LoginPWTxt.Focus()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        lblError.Text = ""
        If LoginPWTxt.Text = NewPWTxt.Text Then
            With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
                .LoginPassword = LoginPWTxt.Text
                .UpdatePassword(LoginNameTxt.Text)
                '.Update(Common.CommonConn.Config.USERID)
            End With
        Else
            'MessageBox.Show("Re-Enter password!")
            lblError.Text = "Re-Enter password!"
        End If

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        lblError.Text = ""
        LoginPWTxt.Text = ""
        NewPWTxt.Text = ""
        LoginPWTxt.Focus()
    End Sub
End Class
