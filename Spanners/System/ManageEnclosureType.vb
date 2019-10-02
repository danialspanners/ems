Public Class ManageEnclosureForm
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
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MarkupFactorTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EnclosureList As System.Windows.Forms.ListBox
    Friend WithEvents EnclosureTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NewEnclosureBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewEnclosureBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.MarkupFactorTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EnclosureTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.EnclosureList = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.MarkupFactorTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnclosureTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewEnclosureBtn)
        Me.GroupBox1.Controls.Add(Me.MarkupFactorTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.EnclosureTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EnclosureList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 344)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enclosure"
        '
        'NewEnclosureBtn
        '
        Me.NewEnclosureBtn.AutoSize = False
        Me.NewEnclosureBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewEnclosureBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewEnclosureBtn.Image = Nothing
        Me.NewEnclosureBtn.Location = New System.Drawing.Point(184, 224)
        Me.NewEnclosureBtn.Name = "NewEnclosureBtn"
        Me.NewEnclosureBtn.Size = New System.Drawing.Size(104, 24)
        Me.NewEnclosureBtn.TabIndex = 120
        Me.NewEnclosureBtn.Text = "New Enclosure"
        '
        'MarkupFactorTxt
        '
        Me.MarkupFactorTxt.Location = New System.Drawing.Point(120, 280)
        Me.MarkupFactorTxt.Name = "MarkupFactorTxt"
        Me.MarkupFactorTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MarkupFactorTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MarkupFactorTxt.Size = New System.Drawing.Size(48, 19)
        Me.MarkupFactorTxt.TabIndex = 119
        Me.MarkupFactorTxt.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Markup Factor % :"
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
        'EnclosureTxt
        '
        Me.EnclosureTxt.Location = New System.Drawing.Point(120, 256)
        Me.EnclosureTxt.Name = "EnclosureTxt"
        Me.EnclosureTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnclosureTxt.Size = New System.Drawing.Size(136, 19)
        Me.EnclosureTxt.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Enclosure Type :"
        '
        'EnclosureList
        '
        Me.EnclosureList.Location = New System.Drawing.Point(8, 24)
        Me.EnclosureList.Name = "EnclosureList"
        Me.EnclosureList.Size = New System.Drawing.Size(280, 186)
        Me.EnclosureList.TabIndex = 112
        '
        'ManageEnclosureForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageEnclosureForm"
        Me.Text = "Type of Enclosure"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MarkupFactorTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnclosureTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enclosure_Id As Integer
    Public Enclosure_Type As String
    Public Markup_Factor As Double
    Public UserID As String = Common.CommonConn.Config.USERID
    ' 06.01.2004 YG Start
    Dim FunctionName As String = "MyEnclosureType"
    ' 06.01.2004 YG End

    Private Sub ManageEnclosureForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewEnclosureBtn.Enabled = True
        Else
            NewEnclosureBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 06.01.2004 YG End

        LoadEnclosureType()
        DeleteBtn.Enabled = False
    End Sub

    Private Sub ResetForm()
        EnclosureTxt.Text = ""
        MarkupFactorTxt.Text = ""
    End Sub

    Private Sub LoadEnclosureType()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.EnclosureBusLogic
            If .GetEnclosureType(ds) Then
                If Not ds Is Nothing Then
                    Try
                        EnclosureList.DisplayMember = "Enclosure_Type"
                        EnclosureList.ValueMember = "Enclosure_Id"

                        EnclosureList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If ValidData() Then

            With New BusinessRules.SystemBusRules.EnclosureBusLogic
                If SaveBtn.Text = "Update" Then
                    .Enclosure_Type = Enclosure_Type
                    .Markup_Factor = Markup_Factor
                    .UserID = UserID
                    .UpdateEnclosure(Enclosure_Id)
                    MessageBox.Show("Enclosure Type updated. ", "Enclosure Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadEnclosureType()
                    ResetForm()
                Else
                    If Not EnclosureTypeNameExist() Then
                        .Enclosure_Type = Enclosure_Type
                        .Markup_Factor = Markup_Factor
                        .UserID = UserID
                        If Enclosure_Id = 0 Or Enclosure_Id = Nothing Then
                            If .SaveEnclosureType() Then
                                MessageBox.Show("Enclosure Type saved. ", "Enclosure Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            .UpdateEnclosure(Enclosure_Id)
                            MessageBox.Show("Enclosure Type updated. ", "Enclosure Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        LoadEnclosureType()
                        ResetForm()

                    Else
                        MessageBox.Show("Enclosure Type already exist !", "Manage Enclosure Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                End If

            End With
        End If

    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        Enclosure_Type = EnclosureTxt.Text
        Markup_Factor = MarkupFactorTxt.Text

        If Not Len(Enclosure_Type) > 0 Then
            DataOK_Flag = False
            FieldName = "Enclosure Type" & Chr(13)
        End If

        If Markup_Factor = 0 Then
            DataOK_Flag = False
            FieldName = "Markup Factor" & Chr(13)
        End If


        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function
    '## Added by Alan
    Private Function EnclosureTypeNameExist() As Boolean
        Dim NameExist_Flag As Boolean = False
        Dim dsEnclosureType As DataSet
        Dim dsMarkupFactor As DataSet
        Dim rowCount As Integer
        Dim i As Integer

        With New BusinessRules.SystemBusRules.EnclosureBusLogic
            If .GetEnclosureType(dsEnclosureType) Then
                rowCount = dsEnclosureType.Tables(0).Rows.Count()
                For i = 0 To (rowCount - 1)
                    If UCase(Enclosure_Type) = UCase(dsEnclosureType.Tables(0).Rows(i).Item("Enclosure_Type")) Then
                        NameExist_Flag = True
                        'EnclosureTypeNameExist = NameExist_Flag
                        Exit For
                    Else
                        NameExist_Flag = False
                    End If
                Next i
            End If
        End With
        EnclosureTypeNameExist = NameExist_Flag
    End Function
    '## End
    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Enclosure Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Enclosure_Id = EnclosureList.SelectedValue.ToString
            With New BusinessRules.SystemBusRules.EnclosureBusLogic
                .Enclosure_Id = Enclosure_Id
                If .DeleteEnclosureType() Then
                    MessageBox.Show("Enclosure Type deleted. ", "Enclosure Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadEnclosureType()
                End If
            End With
        End If
    End Sub

    Private Sub EnclosureList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnclosureList.SelectedIndexChanged
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DeleteBtn.Enabled = True
        Else
            DeleteBtn.Enabled = False
        End If

        '        DeleteBtn.Enabled = True
        ' 06.01.2004 YG End

        Enclosure_Id = EnclosureList.SelectedValue.ToString
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.EnclosureBusLogic
            If .GetEnclosureType(ds, Enclosure_Id) Then
                EnclosureTxt.Text = ds.Tables(0).Rows(0)("Enclosure_Type")
                MarkupFactorTxt.Text = ds.Tables(0).Rows(0)("Markup_Factor")
            End If
        End With
        SaveBtn.Text = "Update"
    End Sub

    Private Sub NewEnclosureBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEnclosureBtn.Click
        SaveBtn.Text = "Save"

        EnclosureTxt.Text = ""
        MarkupFactorTxt.Text = ""
        Enclosure_Id = Nothing
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ManageEnclosureForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
