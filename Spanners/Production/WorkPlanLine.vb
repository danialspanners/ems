Imports DevExpress.XtraEditors.Controls

Public Class WorkPlanLineForm
    Inherits System.Windows.Forms.Form

    Public Status As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, ByVal pWP_ID As Integer, Optional ByVal pWPLine_ID As Integer = 0)
        MyBase.New()

        Status = pStatus

        WP_ID = pWP_ID

        If Not pWPLine_ID = 0 Then
            WPLine_ID = pWPLine_ID
        End If

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
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CategoryTree As System.Windows.Forms.TreeView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductList As System.Windows.Forms.ListBox
    Friend WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MaterialCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ColorCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CuttingChk As System.Windows.Forms.CheckBox
    Friend WithEvents PunchingChk As System.Windows.Forms.CheckBox
    Friend WithEvents BendingChk As System.Windows.Forms.CheckBox
    Friend WithEvents PowerPressChk As System.Windows.Forms.CheckBox
    Friend WithEvents WeldingChk As System.Windows.Forms.CheckBox
    Friend WithEvents PCProcessChk As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ProductSearchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label28 = New System.Windows.Forms.Label
        Me.CategoryTree = New System.Windows.Forms.TreeView
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductList = New System.Windows.Forms.ListBox
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.MaterialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ColorCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CuttingChk = New System.Windows.Forms.CheckBox
        Me.PunchingChk = New System.Windows.Forms.CheckBox
        Me.BendingChk = New System.Windows.Forms.CheckBox
        Me.PowerPressChk = New System.Windows.Forms.CheckBox
        Me.WeldingChk = New System.Windows.Forms.CheckBox
        Me.PCProcessChk = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SearchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(8, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Category List"
        '
        'CategoryTree
        '
        Me.CategoryTree.ImageIndex = -1
        Me.CategoryTree.Location = New System.Drawing.Point(8, 24)
        Me.CategoryTree.Name = "CategoryTree"
        Me.CategoryTree.SelectedImageIndex = -1
        Me.CategoryTree.Size = New System.Drawing.Size(264, 392)
        Me.CategoryTree.TabIndex = 38
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(320, 104)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Product List"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(320, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Qty"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(280, 425)
        Me.Splitter1.TabIndex = 34
        Me.Splitter1.TabStop = False
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(512, 368)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(72, 32)
        Me.SelectBtn.TabIndex = 48
        Me.SelectBtn.Text = "Save"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(592, 368)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 50
        Me.CloseBtn.Text = "&Close"
        '
        'ProductList
        '
        Me.ProductList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductList.Location = New System.Drawing.Point(416, 104)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(248, 39)
        Me.ProductList.TabIndex = 56
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(416, 200)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(56, 19)
        Me.QtyTxt.TabIndex = 65
        Me.QtyTxt.Text = "0"
        '
        'MaterialCmb
        '
        Me.MaterialCmb.Location = New System.Drawing.Point(416, 152)
        Me.MaterialCmb.Name = "MaterialCmb"
        Me.MaterialCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MaterialCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MaterialCmb.Properties.NullString = ""
        Me.MaterialCmb.Properties.PopupWidth = 248
        Me.MaterialCmb.Size = New System.Drawing.Size(248, 19)
        Me.MaterialCmb.TabIndex = 158
        '
        'ColorCmb
        '
        Me.ColorCmb.Location = New System.Drawing.Point(416, 176)
        Me.ColorCmb.Name = "ColorCmb"
        Me.ColorCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ColorCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ColorCmb.Properties.NullString = ""
        Me.ColorCmb.Properties.PopupWidth = 248
        Me.ColorCmb.Size = New System.Drawing.Size(248, 19)
        Me.ColorCmb.TabIndex = 160
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Color"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Material"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Cutting"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Punching"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "Bending"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Power Press"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Welding"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 172
        Me.Label8.Text = "PC Process"
        '
        'CuttingChk
        '
        Me.CuttingChk.Location = New System.Drawing.Point(416, 224)
        Me.CuttingChk.Name = "CuttingChk"
        Me.CuttingChk.Size = New System.Drawing.Size(16, 16)
        Me.CuttingChk.TabIndex = 174
        '
        'PunchingChk
        '
        Me.PunchingChk.Location = New System.Drawing.Point(416, 248)
        Me.PunchingChk.Name = "PunchingChk"
        Me.PunchingChk.Size = New System.Drawing.Size(16, 16)
        Me.PunchingChk.TabIndex = 175
        '
        'BendingChk
        '
        Me.BendingChk.Location = New System.Drawing.Point(416, 272)
        Me.BendingChk.Name = "BendingChk"
        Me.BendingChk.Size = New System.Drawing.Size(16, 16)
        Me.BendingChk.TabIndex = 176
        '
        'PowerPressChk
        '
        Me.PowerPressChk.Location = New System.Drawing.Point(416, 296)
        Me.PowerPressChk.Name = "PowerPressChk"
        Me.PowerPressChk.Size = New System.Drawing.Size(16, 16)
        Me.PowerPressChk.TabIndex = 177
        '
        'WeldingChk
        '
        Me.WeldingChk.Location = New System.Drawing.Point(416, 320)
        Me.WeldingChk.Name = "WeldingChk"
        Me.WeldingChk.Size = New System.Drawing.Size(16, 16)
        Me.WeldingChk.TabIndex = 178
        '
        'PCProcessChk
        '
        Me.PCProcessChk.Location = New System.Drawing.Point(416, 344)
        Me.PCProcessChk.Name = "PCProcessChk"
        Me.PCProcessChk.Size = New System.Drawing.Size(16, 16)
        Me.PCProcessChk.TabIndex = 179
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SearchBtn)
        Me.GroupBox3.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(320, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 56)
        Me.GroupBox3.TabIndex = 180
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Search"
        '
        'SearchBtn
        '
        Me.SearchBtn.AutoSize = False
        Me.SearchBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Image = Nothing
        Me.SearchBtn.Location = New System.Drawing.Point(272, 16)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(64, 32)
        Me.SearchBtn.TabIndex = 73
        Me.SearchBtn.Text = "Search"
        '
        'ProductSearchTxt
        '
        Me.ProductSearchTxt.Location = New System.Drawing.Point(96, 28)
        Me.ProductSearchTxt.Name = "ProductSearchTxt"
        Me.ProductSearchTxt.Properties.BorderSides = DevExpress.XtraEditors.Controls.BorderSide.None
        Me.ProductSearchTxt.Size = New System.Drawing.Size(168, 17)
        Me.ProductSearchTxt.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(10, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 28)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Type Product ID/Code :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(304, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 400)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        '
        'WorkPlanLineForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(698, 425)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PCProcessChk)
        Me.Controls.Add(Me.WeldingChk)
        Me.Controls.Add(Me.PowerPressChk)
        Me.Controls.Add(Me.BendingChk)
        Me.Controls.Add(Me.PunchingChk)
        Me.Controls.Add(Me.CuttingChk)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ColorCmb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialCmb)
        Me.Controls.Add(Me.QtyTxt)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WorkPlanLineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Plan Line"
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable "
    Public WPLine_ID As Integer
    Public WP_ID As Integer
    Public Category_ID As Integer
    Public Product_ID As Integer
    Public Material_ID As Integer
    Public Color_ID As Integer
    Public Qty As Integer
    Public Cutting As String
    Public Punching As String
    Public Bending As String
    Public PowerPress As String
    Public Welding As String
    Public PCProcess As String
    Public UserID As String = Common.CommonConn.Config.USERID

#End Region

#Region " Code - Form load , Category tree list"
    'For Category Portion

    Private Sub WorkPlanLineForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCategoryList()
        LoadMaterial()
        LoadColor()

        Select Case UCase(Status)
            Case "ADD"
                ProductList.Enabled = False
                CategoryTree.Enabled = False
                SelectBtn.Enabled = False

            Case "VIEW"
                Dim ds As DataSet
                With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
                    .WPLine_ID = WPLine_ID
                    If .GetWPLine_ByLineID(ds, WPLine_ID) Then
                        CategoryTree.SelectedNode.Tag = ds.Tables(0).Rows(0)("Category_ID").ToString
                        RefreshProductList(ds.Tables(0).Rows(0)("Category_ID"))
                        SetWindowValue(ds)
                        ProductList.Enabled = False
                        CategoryTree.Enabled = False
                        SelectBtn.Enabled = False
                    End If
                End With

            Case "EDIT"
                Dim ds As DataSet
                With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
                    .WPLine_ID = WPLine_ID

                    If .GetWPLine_ByLineID(ds, WPLine_ID) Then
                        CategoryTree.SelectedNode.Tag = ds.Tables(0).Rows(0)("Category_ID").ToString
                        RefreshProductList(ds.Tables(0).Rows(0)("Category_ID"))
                        SetWindowValue(ds)
                        SelectBtn.Text = "Update"
                        ProductList.Enabled = True
                        CategoryTree.Enabled = True
                    End If
                End With
        End Select
    End Sub

    Private Sub LoadCategoryList()
        Dim node As TreeNode
        Dim Root As TreeNode = New TreeNode("Category")

        Root.Nodes.Clear()
        CategoryTree.Nodes.Clear()
        CategoryTree.Nodes.Add(Root)
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
                            doCatePopulate(node, oRow2, dsCategory.Relations(0))
                            Root.Nodes.Add(node)
                        End If
                    Next
                End If
            End If
        End With
        CategoryTree.CollapseAll()
        CategoryTree.SelectedNode = Root
        'CategoryTree.ExpandAll()
    End Sub

    Private Sub doCatePopulate(ByRef Node As TreeNode, ByVal dr As DataRow, ByVal rel As DataRelation)
        'dr(4) - column 4 is Category Name
        Node = New TreeNode(dr(4).ToString(), 0, 0)
        Node.Tag = dr(0)

        Dim Row As DataRow
        For Each Row In dr.GetChildRows(rel)
            Dim newNode As TreeNode = New TreeNode
            doCatePopulate(newNode, Row, rel)
            Node.Nodes.Add(newNode)
        Next
    End Sub

#End Region

#Region " Code - Windows Events (Supplier Lookup, Product ListBox, Category Tree"
    'Event for Category List
    Private Sub CategoryTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles CategoryTree.AfterSelect
        Dim CurrentTag
        Dim CurrentText

        CurrentTag = CategoryTree.SelectedNode.Tag
        CurrentText = CategoryTree.SelectedNode.Text()

        If CurrentTag <> Nothing Then
            Category_ID = CurrentTag
            RefreshProductList(Category_ID)
        Else

        End If
    End Sub

    Private Sub RefreshProductList(ByVal pCategoryID As Integer)
        Dim ds As DataSet
        'Load product list
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .LoadList(ds, pCategoryID) Then
                If Not ds Is Nothing Then
                    Try
                        ProductList.DisplayMember = "Name"
                        ProductList.ValueMember = "Product_ID"

                        ProductList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadMaterial()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.MaterialBusLogic
            If .GetMaterial(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(MaterialCmb, "Material_Name", 400, 0, "c")
                        MaterialCmb.Properties.LookUpData.KeyField = "Material_ID"
                        MaterialCmb.Properties.LookUpData.DisplayField = "Material_Name"

                        MaterialCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        MaterialCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadColor()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ColorCmb, "Color_Name", 400, 0, "c")
                        ColorCmb.Properties.LookUpData.KeyField = "Color_ID"
                        ColorCmb.Properties.LookUpData.DisplayField = "Color_Name"

                        ColorCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ColorCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        Dim luColumnInfo = New LookUpColumnInfo(field, width)
        If format = "c" Then
            luColumnInfo.FormatType = LookUpFormatType.Numeric
            luColumnInfo.FormatString = format
        End If
        luColumnInfo.Alignment = CType(alignment, StringAlignment)
        le.Properties.LookUpData.ListFields.Add(luColumnInfo)
    End Sub

    Private Sub ProductList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductList.SelectedIndexChanged
        Dim text As String
        With New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
            If ProductList.Items.Count > 0 Then
                Product_ID = ProductList.SelectedValue.ToString
                .Product_ID = Product_ID
            End If
        End With
    End Sub

#End Region

#Region " Btn event "
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        If RetrieveFromForm() Then
            Select Case UCase(Status)
                Case "NEW"
                    SaveWorkPlanLine()
                Case "EDIT"
                    UpdateWorkPlanLine()
            End Select
        End If
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        RefreshProductListByProductID(ProductSearchTxt.Text)
        'RefreshProductInfo()
    End Sub

    Private Sub RefreshProductListByProductID(ByVal ProductID As String)
        Dim ds As DataSet
        'Load product list
        With New BusinessRules.ManProdBusRules.ManProdBusLogic
            If .Load(ds, ProductID) Then
                If Not ds Is Nothing Then
                    Try
                        ProductList.DisplayMember = "Name"
                        ProductList.ValueMember = "Product_ID"

                        ProductList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
#End Region

#Region " Database Mgmt "
    Private Sub SaveWorkPlanLine()
        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
            If ValidData() Then
                .WPLine_ID = WPLine_ID
                .WP_ID = WP_ID
                .LnCategory_ID = Category_ID
                .LnProduct_ID = Product_ID
                .LnMaterial_ID = Material_ID
                .LnColor_ID = Color_ID
                .LnQty = Qty
                .LnBending = Bending
                .LnCutting = Cutting
                .LnWelding = Welding
                .LnPowerPress = PowerPress
                .LnPCProcess = PCProcess
                .LnPunching = Punching
                .UserID = UserID

                .SaveWPLine()
                MessageBox.Show("Work Plan saved!", "Save Work Plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub UpdateWorkPlanLine()
        With New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
            If ValidData() Then
                .WP_ID = WP_ID
                .WPLine_ID = WPLine_ID
                .LnCategory_ID = Category_ID
                .LnProduct_ID = Product_ID
                .LnMaterial_ID = Material_ID
                .LnColor_ID = Color_ID
                .LnQty = Qty
                .LnBending = Bending
                .LnCutting = Cutting
                .LnWelding = Welding
                .LnPowerPress = PowerPress
                .LnPCProcess = PCProcess
                .LnPunching = Punching
                .UserID = UserID

                .UpdateWPLine()
                MessageBox.Show("Work Plan updated!", "Updates Work Plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub


    Private Function ValidData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        Qty = QtyTxt.Text

        If Qty = 0 Then
            DataOK_Flag = False
            FieldName = "Qty" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If

        ValidData = DataOK_Flag
    End Function

    Private Function RetrieveFromForm() As Boolean
        Dim OKFlag = True

        'If UCase(Status) = "ADD" Or UCase(Status) = "ADDFROMWO" Then
        Category_ID = CategoryTree.SelectedNode.Tag
        If ProductList.SelectedValue Then
            Product_ID = ProductList.SelectedValue.ToString
            Material_ID = MaterialCmb.Properties.LookUpData.KeyValue
            Color_ID = ColorCmb.Properties.LookUpData.KeyValue
            Qty = QtyTxt.Text
            If CuttingChk.Checked = True Then
                Cutting = 1
            Else
                Cutting = 0
            End If
            If PunchingChk.Checked = True Then
                Punching = 1
            Else
                Punching = 0
            End If
            If BendingChk.Checked = True Then
                Bending = 1
            Else
                Bending = 0
            End If
            If WeldingChk.Checked = True Then
                Welding = 1
            Else
                Welding = 0
            End If
            If PowerPressChk.Checked = True Then
                PowerPress = 1
            Else
                PowerPress = 0
            End If
            If PCProcessChk.Checked = True Then
                PCProcess = 1
            Else
                PCProcess = 0
            End If
        Else
            OKFlag = False
            MessageBox.Show("Pls select a Category/Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'End If

        RetrieveFromForm = OKFlag
    End Function
#End Region


#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        Dim varCutting
        Dim varPunching
        Dim varBending
        Dim varPowerPress
        Dim varWelding
        Dim varPCProcess

        QtyTxt.Text = dsLoad.Tables(0).Rows(0)("Qty")
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Material_ID")) Then
            MaterialCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Material_ID")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Color_ID")) Then
            ColorCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Color_ID")
        End If

        varCutting = dsLoad.Tables(0).Rows(0)("Cutting")
        If varCutting = 1 Then
            CuttingChk.Checked = True
        Else
            CuttingChk.Checked = False
        End If

        varPunching = dsLoad.Tables(0).Rows(0)("Punching")
        If varPunching = 1 Then
            PunchingChk.Checked = True
        Else
            PunchingChk.Checked = False
        End If

        varBending = dsLoad.Tables(0).Rows(0)("Bending")
        If varBending = 1 Then
            BendingChk.Checked = True
        Else
            BendingChk.Checked = False
        End If

        varPowerPress = dsLoad.Tables(0).Rows(0)("PowerPress")
        If varPowerPress = 1 Then
            PowerPressChk.Checked = True
        Else
            PowerPressChk.Checked = False
        End If

        varWelding = dsLoad.Tables(0).Rows(0)("Welding")
        If varWelding = 1 Then
            WeldingChk.Checked = True
        Else
            WeldingChk.Checked = False
        End If

        varPCProcess = dsLoad.Tables(0).Rows(0)("PCProcess")
        If varPCProcess = 1 Then
            PCProcessChk.Checked = True
        Else
            PCProcessChk.Checked = False
        End If

    End Sub

#End Region

    Private Sub WorkPlanLineForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Work Plan Line?", "Work Plan Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Dim a As MainForm = Me.ParentForm
            If (a.MainTabControl.TabPages.Count > 0) Then
                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub
End Class


