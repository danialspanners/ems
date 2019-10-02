Imports System.Object
Imports System.DBNull
Imports Crownwood.Magic.Menus

Public Class ManageCategoryForm
    Inherits System.Windows.Forms.Form

    Dim ParentTag As String
    Dim CurrentTag As String
    Dim Thread_Level As Integer
    Dim CatName As String
    Dim Description As String
    Dim UserID As String = Common.CommonConn.Config.USERID
    ' 11.01.2004 YG Start
    Dim FunctionName As String = "MyPartsCategory"
    ' 11.01.2004 YG End

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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents AddBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CategoryGrp As System.Windows.Forms.GroupBox
    Friend WithEvents NodeParTxt As System.Windows.Forms.Label
    Friend WithEvents Statustxt As System.Windows.Forms.Label
    Friend WithEvents DelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CatNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents AddM As System.Windows.Forms.MenuItem
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.CategoryGrp = New System.Windows.Forms.GroupBox
        Me.DescTxt = New DevExpress.XtraEditors.TextEdit
        Me.CatNameTxt = New DevExpress.XtraEditors.TextEdit
        Me.Statustxt = New System.Windows.Forms.Label
        Me.NodeParTxt = New System.Windows.Forms.Label
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AddBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.AddM = New System.Windows.Forms.MenuItem
        Me.Delete = New System.Windows.Forms.MenuItem
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.CategoryGrp.SuspendLayout()
        CType(Me.DescTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatNameTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(288, 421)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'TreeView1
        '
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Location = New System.Drawing.Point(8, 8)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(272, 368)
        Me.TreeView1.TabIndex = 1
        '
        'CategoryGrp
        '
        Me.CategoryGrp.Controls.Add(Me.DescTxt)
        Me.CategoryGrp.Controls.Add(Me.CatNameTxt)
        Me.CategoryGrp.Controls.Add(Me.Statustxt)
        Me.CategoryGrp.Controls.Add(Me.NodeParTxt)
        Me.CategoryGrp.Controls.Add(Me.SaveBtn)
        Me.CategoryGrp.Controls.Add(Me.Label2)
        Me.CategoryGrp.Controls.Add(Me.Label1)
        Me.CategoryGrp.Location = New System.Drawing.Point(296, 8)
        Me.CategoryGrp.Name = "CategoryGrp"
        Me.CategoryGrp.Size = New System.Drawing.Size(336, 368)
        Me.CategoryGrp.TabIndex = 2
        Me.CategoryGrp.TabStop = False
        '
        'DescTxt
        '
        Me.DescTxt.Location = New System.Drawing.Point(112, 72)
        Me.DescTxt.Name = "DescTxt"
        Me.DescTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescTxt.Size = New System.Drawing.Size(216, 19)
        Me.DescTxt.TabIndex = 8
        '
        'CatNameTxt
        '
        Me.CatNameTxt.Location = New System.Drawing.Point(112, 48)
        Me.CatNameTxt.Name = "CatNameTxt"
        Me.CatNameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CatNameTxt.Size = New System.Drawing.Size(216, 19)
        Me.CatNameTxt.TabIndex = 7
        '
        'Statustxt
        '
        Me.Statustxt.Location = New System.Drawing.Point(16, 336)
        Me.Statustxt.Name = "Statustxt"
        Me.Statustxt.Size = New System.Drawing.Size(56, 16)
        Me.Statustxt.TabIndex = 6
        Me.Statustxt.Visible = False
        '
        'NodeParTxt
        '
        Me.NodeParTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NodeParTxt.Location = New System.Drawing.Point(8, 24)
        Me.NodeParTxt.Name = "NodeParTxt"
        Me.NodeParTxt.Size = New System.Drawing.Size(320, 16)
        Me.NodeParTxt.TabIndex = 5
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(264, 112)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 3
        Me.SaveBtn.Text = "&Save"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* Category Name :"
        '
        'AddBtn
        '
        Me.AddBtn.AutoSize = False
        Me.AddBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Image = Nothing
        Me.AddBtn.Location = New System.Drawing.Point(296, 392)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(56, 24)
        Me.AddBtn.TabIndex = 3
        Me.AddBtn.Text = "&Add"
        Me.AddBtn.Visible = False
        '
        'DelBtn
        '
        Me.DelBtn.AutoSize = False
        Me.DelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.Image = Nothing
        Me.DelBtn.Location = New System.Drawing.Point(360, 392)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(56, 24)
        Me.DelBtn.TabIndex = 5
        Me.DelBtn.Text = "&Delete"
        Me.DelBtn.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AddM, Me.Delete})
        '
        'AddM
        '
        Me.AddM.Index = 0
        Me.AddM.Text = "Add"
        '
        'Delete
        '
        Me.Delete.Index = 1
        Me.Delete.Text = "Delete"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(568, 384)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 24
        Me.CloseBtn.Text = "&Close"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "To add/delete category, select the parent category and right click, chose 'Add' o" & _
        "r ""Delete"""
        '
        'ManageCategoryForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(640, 421)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.CategoryGrp)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Splitter1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "ManageCategoryForm"
        Me.Text = "Manage Category"
        Me.CategoryGrp.ResumeLayout(False)
        CType(Me.DescTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatNameTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Load"
    Private Sub ManageCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim node As TreeNode
        Dim Root As TreeNode = New TreeNode("Category")

        '## Added by Andrew
        DisableFields()
        '## End

        Root.Nodes.Clear()
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(Root)
        With New BusinessRules.CategoryBusRules.CategoryBusLogic
            Dim dsCategory As DataSet
            If .GetCategory(dsCategory) Then
                If (dsCategory.Tables(0).Rows.Count > 0) Then
                    Dim pk, fk As DataColumn
                    pk = dsCategory.Tables(0).Columns(0)
                    fk = dsCategory.Tables(0).Columns(2)

                    dsCategory.Relations.Add(New DataRelation("ParentCategoryRelation", pk, fk, False))
                    Dim dr As DataRow = dsCategory.Tables(0).Rows(0)

                    Dim oRow2 As DataRow
                    For Each oRow2 In dsCategory.Tables(0).Rows
                        If oRow2("Thread_Level") = 1 Then
                            doPopulate(node, oRow2, dsCategory.Relations(0))
                            Root.Nodes.Add(node)
                        End If
                    Next
                End If
            End If
        End With
        TreeView1.CollapseAll()
        'TreeView1.ExpandAll()
        TreeView1.SelectedNode = Root
        '## Added by Andrew
        TreeView1.Select()
        '## End
    End Sub

    Private Sub doPopulate(ByRef Node As TreeNode, ByVal dr As DataRow, ByVal rel As DataRelation)
        'dr(4) - column 4 is Category Name
        Node = New TreeNode(dr(4).ToString(), 0, 0)
        Node.Tag = dr(0)

        Dim Row As DataRow
        For Each Row In dr.GetChildRows(rel)
            Dim newNode As TreeNode = New TreeNode
            doPopulate(newNode, Row, rel)
            Node.Nodes.Add(newNode)
        Next
    End Sub
#End Region

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim ParentText As String
        Dim MainText As String

        Dim CurrentText As String = TreeView1.SelectedNode.Text
        CurrentTag = TreeView1.SelectedNode.Tag

        If Not Len(CurrentTag) = 0 Then
            ParentText = TreeView1.SelectedNode.Parent.Text
            ParentTag = TreeView1.SelectedNode.Parent.Tag

            Dim ds As DataSet
            With New BusinessRules.CategoryBusRules.CategoryBusLogic
                If .GetCategory(ds, CurrentTag) Then
                    If Not ds Is Nothing Then
                        Dim TotLevel As Integer = Integer.Parse(ds.Tables(0).Rows(0)(3))
                        Thread_Level = Integer.Parse(TotLevel + 1)
                    End If
                End If
            End With
            MainText = ParentText & " > " & CurrentText
        Else
            MainText = "Category "
            Thread_Level = 1
        End If

        CategoryGrp.Visible = True
        NodeParTxt.Text = MainText
        CategoryGrp.Text = "Add New Category "
        CatNameTxt.Text = ""
        DescTxt.Text = ""
        SaveBtn.Focus()

        Statustxt.Text = "ADD"  'to track the status of the form
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim Status As String = Statustxt.Text

        If ValidData() Then
            Select Case (Status.ToUpper)
                Case "ADD"
                    Dim CurrentText As String = TreeView1.SelectedNode.Text
                    CurrentTag = TreeView1.SelectedNode.Tag
                    With New BusinessRules.CategoryBusRules.CategoryBusLogic
                        .Name = CatName
                        If .CheckDuplicateCategory() Then
                            SaveProcess()
                            ManageCategory_Load(sender, e)
                        Else
                            MessageBox.Show("This Category Exists!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End With
                Case "EDIT"
                    UpdateProcess()
                    ManageCategory_Load(sender, e)
            End Select
        End If
    End Sub

    'Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
    '    CurrentTag = TreeView1.SelectedNode.Tag
    '    ParentTag = TreeView1.SelectedNode.Parent.Tag

    '    With New BusinessRules.CategoryBusRules.CategoryBusLogic
    '        Dim ds As DataSet
    '
    '        If .GetCategory(ds, CurrentTag) Then
    '            CatNameTxt.Text = ds.Tables(0).Rows(0)(4)
    '            DescTxt.Text = ds.Tables(0).Rows(0)(5)
    '        End If
    '    End With
    '    CategoryGrp.Text = "Edit Category"
    '    CategoryGrp.Show()

    '    Statustxt.Text = "EDIT" 'to keep track of the form status
    'End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        Dim ds As DataSet
        CurrentTag = TreeView1.SelectedNode.Tag

        If CurrentTag = Nothing Then
            MessageBox.Show("Pls highlight on the category to delete.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.CategoryBusRules.CategoryBusLogic
                    .Category_ID = CurrentTag
                    'If .CheckRelatedTable(ds) Then     'NOT DONE. CHECKING RELATED TABLE
                    'If Not ds Is Nothing Then
                    'MessageBox.Show("Cannot delete this cateogry." & Chr(13) & "This category is currently been used.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Else
                    If .DeleteCategory() Then
                        MessageBox.Show("Category deleted.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ManageCategory_Load(sender, e)
                    End If
                    'End If
                    'End If
                End With
            End If
        End If
    End Sub

#Region "ValidData() Function"
    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        CatName = CatNameTxt.Text
        Description = DescTxt.Text

        If Not Len(CatName) > 0 Then
            DataOK_Flag = False
            FieldName = "Category Name" & Chr(13)
        End If

        'remove by alan 18 Oct
        'If Not Len(Description) > 0 Then
        'DataOK_Flag = False
        'FieldName = FieldName & "Description" & Chr(13)
        'End If

        If Not DataOK_Flag Then
            MessageBox.Show("Please do not leave the following field(s) empty : " & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ValidData = DataOK_Flag
    End Function
#End Region

#Region "Process (Add, Edit)"
    Private Sub SaveProcess()
        With New BusinessRules.CategoryBusRules.CategoryBusLogic
            .Thread_Parent = CurrentTag
            .Thread_Level = Thread_Level
            .Name = CatName
            .Description = Description
            .UserID = UserID
            Try
                If .SaveCategory Then
                    MessageBox.Show("Category saved!", "Save Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CatNameTxt.Text = ""
                    DescTxt.Text = ""
                End If
            Catch exSave As System.Exception
                System.Windows.Forms.MessageBox.Show("Save : " & exSave.Message)
            End Try

        End With
    End Sub

    Private Sub UpdateProcess()
        With New BusinessRules.CategoryBusRules.CategoryBusLogic
            CurrentTag = TreeView1.SelectedNode.Tag
            ParentTag = TreeView1.SelectedNode.Parent.Tag

            '## Edited by Andrew
            .Category_ID = CurrentTag
            '## End
            '.Thread_Parent = ParentTag
            .Name = CatName
            .Description = Description
            .UserID = UserID

            Try
                If .UpdateCategory Then
                    MessageBox.Show("Category updated!", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CatNameTxt.Text = ""
                    DescTxt.Text = ""
                Else

                End If
            Catch exSave As System.Exception
                System.Windows.Forms.MessageBox.Show("Update: " & exSave.Message)
            End Try
        End With
    End Sub
#End Region


    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        CurrentTag = TreeView1.SelectedNode.Tag
        '## Edited by Andrew
        NodeParTxt.Text = ""

        If Not CurrentTag Is Nothing Or CurrentTag = "Category" Then
        '## End
            ParentTag = TreeView1.SelectedNode.Parent.Tag

            With New BusinessRules.CategoryBusRules.CategoryBusLogic
                Dim ds As DataSet

                If .GetCategory(ds, CurrentTag) Then
                    CatNameTxt.Text = ds.Tables(0).Rows(0)(4)
                    'DescTxt.Text = ds.Tables(0).Rows(0)(5)

                    '## Added by Andrew
                    EnableFields()
                    '## End
                End If
            End With
            CategoryGrp.Text = "Edit Category"
            CategoryGrp.Show()

            Statustxt.Text = "EDIT" 'to keep track of the form status
        '## Added by Andrew
        Else
            CategoryGrp.Text = ""
            DisableFields()
            CatNameTxt.Text = ""
            DescTxt.Text = ""
            Statustxt.Text = ""
            '## End
        End If
    End Sub

    Private Sub AddM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddM.Click
        '## Added By Andrew
        EnableFields()
        '## End
        AddBtn_Click(sender, e)
    End Sub

    Private Sub Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Delete.Click
        DelBtn_Click(sender, e)
    End Sub

    Private Sub TreeView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        Dim eventString As String = Nothing
        Select Case e.Button
            Case MouseButtons.Left
                eventString = "L"
            Case MouseButtons.Right
                eventString = "R"
                ContextMenu1.Show(sender, mouseDownLocation)
            Case MouseButtons.None
                eventString = Nothing
        End Select
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    '## Added by Andrew
#Region " Fields Control"
    Private Sub DisableFields()
        CatNameTxt.Enabled = False
        DescTxt.Enabled = False
        SaveBtn.Enabled = False
    End Sub

    Private Sub EnableFields()
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm
        ' 06.01.2004 YG End

        CatNameTxt.Enabled = True
        DescTxt.Enabled = True

        ' 06.01.2004 YG Start
        'SaveBtn.Enabled = True
        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 06.01.2004 YG End

    End Sub
#End Region
    '## End

    Private Sub ManageCategoryForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
