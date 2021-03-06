Public Class ManagePartCode
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
    Friend WithEvents NewPartCodeBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PartCodeList As System.Windows.Forms.ListBox
    Friend WithEvents PartCodeDescTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PartCodeTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PartCodeDescTxt = New DevExpress.XtraEditors.TextEdit
        Me.NewPartCodeBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PartCodeTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PartCodeList = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PartCodeDescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PartCodeDescTxt)
        Me.GroupBox1.Controls.Add(Me.NewPartCodeBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.PartCodeTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PartCodeList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 344)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Part Code List"
        '
        'PartCodeDescTxt
        '
        Me.PartCodeDescTxt.Location = New System.Drawing.Point(120, 280)
        Me.PartCodeDescTxt.Name = "PartCodeDescTxt"
        Me.PartCodeDescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PartCodeDescTxt.Size = New System.Drawing.Size(168, 19)
        Me.PartCodeDescTxt.TabIndex = 121
        '
        'NewPartCodeBtn
        '
        Me.NewPartCodeBtn.AutoSize = False
        Me.NewPartCodeBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewPartCodeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPartCodeBtn.Image = Nothing
        Me.NewPartCodeBtn.Location = New System.Drawing.Point(184, 216)
        Me.NewPartCodeBtn.Name = "NewPartCodeBtn"
        Me.NewPartCodeBtn.Size = New System.Drawing.Size(104, 24)
        Me.NewPartCodeBtn.TabIndex = 120
        Me.NewPartCodeBtn.Text = "New Part Code"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 32)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Part Code Description:"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(152, 312)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(64, 24)
        Me.DeleteBtn.TabIndex = 117
        Me.DeleteBtn.Text = "&Delete"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(224, 312)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 116
        Me.CancelBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(80, 312)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 115
        Me.SaveBtn.Text = "&Save"
        '
        'PartCodeTxt
        '
        Me.PartCodeTxt.Location = New System.Drawing.Point(120, 248)
        Me.PartCodeTxt.Name = "PartCodeTxt"
        Me.PartCodeTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PartCodeTxt.Size = New System.Drawing.Size(168, 19)
        Me.PartCodeTxt.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Part Code :"
        '
        'PartCodeList
        '
        Me.PartCodeList.Location = New System.Drawing.Point(8, 24)
        Me.PartCodeList.Name = "PartCodeList"
        Me.PartCodeList.Size = New System.Drawing.Size(280, 186)
        Me.PartCodeList.TabIndex = 112
        '
        'ManagePartCode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 365)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagePartCode"
        Me.ShowInTaskbar = False
        Me.Text = "Manage PartCode"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PartCodeDescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public PartCode_Id As Integer
    Public PartCodeName As String
    Public PartCodeDesc As String
    Private UserID As Integer = Common.CommonConn.Config.USERID

    Dim FunctionName As String = "MyCurrency"

    Private Sub NewPartCodeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPartCodeBtn.Click
        SaveBtn.Text = "Save"

        PartCodeTxt.Text = ""
        PartCodeDescTxt.Text = ""
        PartCode_Id = Nothing
    End Sub

    Private Sub ManagePartCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewPartCodeBtn.Enabled = True
        Else
            NewPartCodeBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        LoadPartCode()
        DeleteBtn.Enabled = False
    End Sub

    Private Sub ResetForm()
        PartCodeTxt.Text = ""
        PartCodeDescTxt.Text = ""
    End Sub

    Private Sub LoadPartCode()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.PartCodeBusLogic
            If .GetPartCode(ds) Then
                If Not ds Is Nothing Then
                    Try
                        PartCodeList.DisplayMember = "PartCodeName"
                        PartCodeList.ValueMember = "PartCode_Id"

                        PartCodeList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        PartCodeName = PartCodeTxt.Text
        PartCodeDesc = PartCodeDescTxt.Text

        If Not Len(PartCodeName) > 0 Then
            DataOK_Flag = False
            FieldName = "PartCode" & Chr(13)
        End If

        If Not Len(PartCodeDesc) > 0 Then
            DataOK_Flag = False
            FieldName = "PartCode" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function

    Private Function PartCodeExist() As Boolean
        Dim NameExist_Flag As Boolean = False
        Dim dsPartCode As DataSet
        Dim rowCount As Integer
        Dim i As Integer

        With New BusinessRules.SystemBusRules.PartCodeBusLogic
            If .GetPartCode(dsPartCode) Then
                rowCount = dsPartCode.Tables(0).Rows.Count()
                For i = 0 To (rowCount - 1)
                    If UCase(PartCodeName) = UCase(dsPartCode.Tables(0).Rows(i).Item("PartCodeName")) Then
                        NameExist_Flag = True
                        Exit For
                    Else
                        NameExist_Flag = False
                    End If
                Next i
            End If
        End With
        PartCodeExist = NameExist_Flag
    End Function

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If ValidData() Then
            If Not PartCodeExist() Then
                With New BusinessRules.SystemBusRules.PartCodeBusLogic
                    .PartCode_Name = PartCodeName
                    .PartCode_Desc = PartCodeDesc
                    .UserID = UserID
                    If PartCode_Id = 0 Or PartCode_Id = Nothing Then
                        If .SavePartCode() Then
                            MessageBox.Show("PartCode saved. ", "PartCode", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        .UpdatePartCode(PartCode_Id.ToString())
                        MessageBox.Show("PartCode updated. ", "PartCode", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    LoadPartCode()
                    'ResetForm()
                End With
            Else
                With New BusinessRules.SystemBusRules.PartCodeBusLogic
                    .PartCode_Name = PartCodeName
                    .PartCode_Desc = PartCodeDesc
                    .UserID = UserID
                    If PartCode_Id = 0 Or PartCode_Id = Nothing Then
                        If .SavePartCode() Then
                            MessageBox.Show("PartCode saved. ", "PartCode", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        .UpdatePartCode(PartCode_Id.ToString())
                        MessageBox.Show("PartCode updated. ", "PartCode", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    LoadPartCode()
                    'ResetForm()
                End With
                'MessageBox.Show("PartCode already exist !", "Manage PartCode", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete PartCode", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            PartCode_Id = PartCodeList.SelectedValue.ToString
            With New BusinessRules.SystemBusRules.PartCodeBusLogic
                .PartCode_ID = PartCode_Id
                If .DeletePartCode() Then
                    MessageBox.Show("PartCode deleted. ", "PartCode", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPartCode()
                End If
            End With
        End If
    End Sub

    Private Sub PartCodeList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PartCodeList.SelectedIndexChanged
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DeleteBtn.Enabled = True
        Else
            DeleteBtn.Enabled = False
        End If

        PartCode_Id = PartCodeList.SelectedValue.ToString
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.PartCodeBusLogic
            If .GetPartCode(ds, PartCode_Id) Then
                PartCodeTxt.Text = ds.Tables(0).Rows(0)("PartCodeName")
                PartCodeDescTxt.Text = ds.Tables(0).Rows(0)("PartCodeDesc")
            End If
        End With
        SaveBtn.Text = "Update"
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ManagePartCode_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
