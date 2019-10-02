Public Class ManageProjectForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(Optional ByVal pFormType As Integer = 0)
        MyBase.New()

        FormType = pFormType

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
    Friend WithEvents ProjectList As System.Windows.Forms.ListBox
    Friend WithEvents ProjectTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProjectTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProjectList = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProjectTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.NewBtn)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.ProjectTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ProjectList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 346)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(232, 312)
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
        Me.NewBtn.Location = New System.Drawing.Point(192, 248)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(104, 24)
        Me.NewBtn.TabIndex = 121
        Me.NewBtn.Text = "New Project"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(160, 312)
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
        Me.SaveBtn.Location = New System.Drawing.Point(88, 312)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 115
        Me.SaveBtn.Text = "&Save"
        '
        'ProjectTxt
        '
        Me.ProjectTxt.Location = New System.Drawing.Point(64, 280)
        Me.ProjectTxt.Name = "ProjectTxt"
        Me.ProjectTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectTxt.Size = New System.Drawing.Size(232, 19)
        Me.ProjectTxt.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Project :"
        '
        'ProjectList
        '
        Me.ProjectList.Location = New System.Drawing.Point(8, 24)
        Me.ProjectList.Name = "ProjectList"
        Me.ProjectList.Size = New System.Drawing.Size(288, 212)
        Me.ProjectList.TabIndex = 112
        '
        'ManageProjectForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageProjectForm"
        Me.Text = "Manage Project"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ProjectTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Project_ID As Integer
    Public Project_Name As String
    Public FormType As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
    ' 08.01.2004 YG Start
    Dim FunctionName As String = "MyProject"
    ' 08.01.2004 YG End

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
    Private Sub ManageProjectForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 08.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If True Then 'a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewBtn.Enabled = True
        Else
            NewBtn.Enabled = False
        End If

        If True Then  'a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 08.01.2004 YG End

        LoadProject()
        DeleteBtn.Enabled = False

        If FormType = 1 Then
            NewBtn_Click(sender, e)
        End If
    End Sub

    Private Sub ResetForm()
        ProjectTxt.Text = ""
    End Sub

    Private Sub LoadProject()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ProjectBusLogic
            If .GetProject(ds) Then
                If Not ds Is Nothing Then
                    Try
                        ProjectList.DisplayMember = "Project_Name"
                        ProjectList.ValueMember = "Project_Id"

                        ProjectList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim tempID As Integer
        If ValidData() Then
            '## Added by Andrew
            If Not ProjectNameExist() Then
                '## End
                With New BusinessRules.SystemBusRules.ProjectBusLogic
                    .Project_Name = Project_Name
                    .UserID = UserID
                    If Project_ID = 0 Or Project_ID = Nothing Then
                        tempID = .SaveProject()
                        If tempID <> Nothing Then
                            If FormType = 1 Then
                                Project_ID = tempID
                                Close()
                                Exit Sub
                            End If
                            MessageBox.Show("Project Name saved. ", "Project", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    Else
                        .UpdateProject(Project_ID)
                        MessageBox.Show("Project Name updated. ", "Project", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Me.LoadProject()
                    ResetForm()

                End With
                '## Added by Andrew
            Else
                MessageBox.Show("Project Name already exist !", "Manage Project", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '## End
        End If
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        Project_Name = ProjectTxt.Text

        If Not Len(Project_Name) > 0 Then
            DataOK_Flag = False
            FieldName = "Project" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function
    '## Added by Andrew
    Private Function ProjectNameExist() As Boolean
        Dim NameExist_Flag As Boolean = False
        Dim dsProject As DataSet
        Dim rowCount As Integer
        Dim i As Integer

        With New BusinessRules.SystemBusRules.ProjectBusLogic
            If .GetProject(dsProject) Then
                'If Not dsProject Is Nothing Then
                rowCount = dsProject.Tables(0).Rows.Count()
                For i = 0 To (rowCount - 1)
                    If UCase(Project_Name) = UCase(dsProject.Tables(0).Rows(i).Item("Project_Name")) Then
                        NameExist_Flag = True
                        'ProjectNameExist = NameExist_Flag
                        Exit For
                    Else
                        NameExist_Flag = False
                    End If
                    'i = i + 1
                Next i
                'Try
                'ProjectList.DisplayMember = "Project_Name"
                'ProjectList.ValueMember = "Project_Id"

                'ProjectList.DataSource = dsProject.Tables(0)
                'Catch exLoad As System.Exception
                'System.Windows.Forms.MessageBox.Show(exLoad.Message)
                'End Try
            End If
            'End If
        End With
        ProjectNameExist = NameExist_Flag
    End Function
    '## End

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Project_ID = ProjectList.SelectedValue.ToString
            With New BusinessRules.SystemBusRules.ProjectBusLogic
                If .IsProjectNameInUsed(Project_ID) Then
                    MessageBox.Show("Project in used. Cannot be deleted.", "Project", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    .Project_ID = Project_ID
                    If .DeleteProject() Then
                        MessageBox.Show("Project Name deleted. ", "Project", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadProject()
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub NewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click
        SaveBtn.Text = "Save"

        ProjectTxt.Text = ""
        ProjectTxt.Select()
        Project_ID = Nothing
    End Sub

    Private Sub ProjectList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectList.SelectedIndexChanged
        ' 08.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If True Then 'a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DeleteBtn.Enabled = True
        Else
            DeleteBtn.Enabled = False
        End If

        '        DeleteBtn.Enabled = True
        ' 08.01.2004 YG 


        Project_ID = ProjectList.SelectedValue.ToString
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.ProjectBusLogic
            If .GetProject(ds, Project_ID) Then
                ProjectTxt.Text = ds.Tables(0).Rows(0)("Project_Name")
            End If
        End With
        SaveBtn.Text = "Update"
    End Sub

    Private Sub ManageProjectForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.Modal = False Then
            Dim a As MainForm = Me.ParentForm
            If (a.MainTabControl.TabPages.Count > 0) Then
                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                End If
            End If
        End If
    End Sub
End Class
