Public Class ManageDeliveryTermsForm
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
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeliveryTermsList As System.Windows.Forms.ListBox
    Friend WithEvents DeliveryTermsTxt As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.DeliveryTermsList = New System.Windows.Forms.ListBox
        Me.DeliveryTermsTxt = New DevExpress.XtraEditors.MemoEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.DeliveryTermsTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeliveryTermsTxt)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.NewBtn)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DeliveryTermsList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 354)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DeliveryTerms"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(344, 312)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 122
        Me.CancelBtn.Text = "&Close"
        '
        'NewBtn
        '
        Me.NewBtn.AutoSize = False
        Me.NewBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBtn.Image = Nothing
        Me.NewBtn.Location = New System.Drawing.Point(88, 312)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(104, 24)
        Me.NewBtn.TabIndex = 121
        Me.NewBtn.Text = "New DeliveryTerms"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(272, 312)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(64, 24)
        Me.DeleteBtn.TabIndex = 117
        Me.DeleteBtn.Text = "&Delete"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(200, 312)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 115
        Me.SaveBtn.Text = "&Save"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "DeliveryTerms :"
        '
        'DeliveryTermsList
        '
        Me.DeliveryTermsList.Location = New System.Drawing.Point(8, 24)
        Me.DeliveryTermsList.Name = "DeliveryTermsList"
        Me.DeliveryTermsList.Size = New System.Drawing.Size(592, 212)
        Me.DeliveryTermsList.TabIndex = 112
        '
        'DeliveryTermsTxt
        '
        Me.DeliveryTermsTxt.Location = New System.Drawing.Point(88, 256)
        Me.DeliveryTermsTxt.Name = "DeliveryTermsTxt"
        Me.DeliveryTermsTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliveryTermsTxt.Size = New System.Drawing.Size(512, 40)
        Me.DeliveryTermsTxt.TabIndex = 123
        '
        'ManageDeliveryTermsForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageDeliveryTermsForm"
        Me.Text = "DeliveryTerms"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DeliveryTermsTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public DelTerms_ID As Integer
    Public DeliveryTerms As String
    Public UserID As String = Common.CommonConn.Config.USERID
    ' 06.01.2004 YG Start
    Dim FunctionName As String = "MyDeliveryTerms"
    ' 06.01.2004 YG End

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ManageDeliveryTermsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewBtn.Enabled = True
        Else
            NewBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 06.01.2004 YG End

        LoadDeliveryTerms()
        DeleteBtn.Enabled = False
    End Sub

    Private Sub ResetForm()
        DeliveryTermstxt.Text = ""
    End Sub

    Private Sub LoadDeliveryTerms()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
            If .GetDeliveryTerms(ds) Then
                If Not ds Is Nothing Then
                    Try
                        DeliveryTermsList.DisplayMember = "DeliveryTerms"
                        DeliveryTermsList.ValueMember = "DelTerms_ID"

                        DeliveryTermsList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If ValidData() Then
            If Not DeliveryTermsExist() Then
                With New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
                    .DeliveryTerms = DeliveryTerms
                    .UserID = UserID
                    If DelTerms_ID = 0 Or DelTerms_ID = Nothing Then
                        If .SaveDeliveryTerms() Then
                            MessageBox.Show("Delivery Terms saved. ", "Delivery Terms", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        .UpdateDeliveryTerms(DelTerms_ID)
                        MessageBox.Show("Delivery Terms updated. ", "Delivery Terms", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Me.LoadDeliveryTerms()
                    ResetForm()
                End With
            Else
                MessageBox.Show("Delivery Terms already exist !", "Manage Delivery Terms", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        DeliveryTerms = DeliveryTermsTxt.Text

        If Not Len(DeliveryTerms) > 0 Then
            DataOK_Flag = False
            FieldName = "DeliveryTerms" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function
    '## Added by Alan
    Private Function DeliveryTermsExist() As Boolean
        Dim NameExist_Flag As Boolean = False
        Dim dsDeliveryTerms As DataSet
        Dim rowCount As Integer
        Dim i As Integer

        With New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
            If .GetDeliveryTerms(dsDeliveryTerms) Then
                rowCount = dsDeliveryTerms.Tables(0).Rows.Count()
                For i = 0 To (rowCount - 1)
                    If UCase(DeliveryTerms) = UCase(dsDeliveryTerms.Tables(0).Rows(i).Item("DeliveryTerms")) Then
                        NameExist_Flag = True
                        'DeliveryTermsNameExist = NameExist_Flag
                        Exit For
                    Else
                        NameExist_Flag = False
                    End If
                Next i
            End If
        End With
        DeliveryTermsExist = NameExist_Flag
    End Function
    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete DeliveryTerms", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            DelTerms_ID = DeliveryTermsList.SelectedValue.ToString
            With New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
                .DelTerms_ID = DelTerms_ID
                If .DeleteDeliveryTerms() Then
                    MessageBox.Show("Delivery Terms deleted. ", "Delivery Terms", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadDeliveryTerms()
                End If
            End With
        End If
    End Sub

    Private Sub NewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click
        SaveBtn.Text = "Save"

        DeliveryTermsTxt.Text = ""
        DelTerms_ID = Nothing
    End Sub

    Private Sub DeliveryTermsList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryTermsList.SelectedIndexChanged
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DeleteBtn.Enabled = True
        Else
            DeleteBtn.Enabled = False
        End If

        '        DeleteBtn.Enabled = True
        ' 06.01.2004 YG End

        DelTerms_ID = DeliveryTermsList.SelectedValue.ToString
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
            If .GetDeliveryTerms(ds, DelTerms_ID) Then
                DeliveryTermsTxt.Text = ds.Tables(0).Rows(0)("DeliveryTerms")
            End If
        End With
        SaveBtn.Text = "Update"
    End Sub
    Private Sub ManageDeliveryTermsForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
