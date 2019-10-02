Public Class LoginForm
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LoginBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents LoginNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LoginPWTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblerror As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.LoginNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.LoginPWTxt = New DevExpress.XtraEditors.TextEdit
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.LoginBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblerror = New System.Windows.Forms.Label
        CType(Me.LoginNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginPWTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Login ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoginNameTxt
        '
        Me.LoginNameTxt.Location = New System.Drawing.Point(128, 26)
        Me.LoginNameTxt.Name = "LoginNameTxt"
        Me.LoginNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LoginNameTxt.Size = New System.Drawing.Size(104, 21)
        Me.LoginNameTxt.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoginPWTxt
        '
        Me.LoginPWTxt.Location = New System.Drawing.Point(128, 64)
        Me.LoginPWTxt.Name = "LoginPWTxt"
        Me.LoginPWTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LoginPWTxt.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPWTxt.Size = New System.Drawing.Size(104, 21)
        Me.LoginPWTxt.TabIndex = 69
        '
        'CancelBtn
        '
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(160, 104)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 71
        Me.CancelBtn.Text = "&Cancel"
        '
        'LoginBtn
        '
        Me.LoginBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Image = Nothing
        Me.LoginBtn.Location = New System.Drawing.Point(88, 104)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(64, 24)
        Me.LoginBtn.TabIndex = 70
        Me.LoginBtn.Text = "&Login"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblerror)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LoginNameTxt)
        Me.GroupBox1.Controls.Add(Me.LoginPWTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 156)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'lblerror
        '
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(42, 132)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(212, 16)
        Me.lblerror.TabIndex = 69
        Me.lblerror.Text = "Invalid Login ID or Password.  Try Again!"
        Me.lblerror.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 167)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMS Login"
        CType(Me.LoginNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginPWTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            If LoginNameTxt.Text = "" Or LoginPWTxt.Text = "" Then
                lblerror.Text = "Either Login ID or Password is empty."
                lblerror.Visible = True
                LoginNameTxt.Focus()
                'MsgBox("Either Login ID or Password is empty.")
            Else
                If .RecordExists(LoginNameTxt.Text, LoginPWTxt.Text) Then
                    .Load(LoginNameTxt.Text)
                    Dim UserID = .UserID
                    Dim UserGroup = .UserGroup
                    With New Common.CommonConn.Config
                        .USERID = UserID
                        .UserGroup = UserGroup
                    End With
                    Me.Close()
                Else
                    LoginNameTxt.Text = Nothing
                    LoginPWTxt.Text = Nothing
                    lblerror.Text = "Invalid Login ID or password. Try Again!"
                    lblerror.Visible = True
                    LoginNameTxt.Focus()
                    'MsgBox("Invalid Login ID or password. Try Again!")
                End If
            End If

        End With
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Me.Close()
    End Sub

    Private Sub LoginNameTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LoginNameTxt.KeyUp
        If e.KeyValue = 13 Then
            e.Handled = True
            LoginBtn_Click(sender, e)
        End If
    End Sub

    Private Sub LoginPWTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LoginPWTxt.KeyUp
        If e.KeyValue = 13 Then
            e.Handled = True
            LoginBtn_Click(sender, e)
        End If
    End Sub

    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblerror.Visible = False
    End Sub
End Class
