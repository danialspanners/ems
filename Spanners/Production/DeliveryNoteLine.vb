Imports DevExpress.XtraEditors.Controls

Public Class DeliveryNoteLineForm
    Inherits System.Windows.Forms.Form

    Public Status As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, ByVal pDN_ID As Integer, Optional ByVal pDNLine_ID As Integer = 0)
        MyBase.New()

        Status = pStatus

        DN_ID = pDN_ID

        If Not pDNLine_ID = 0 Then
            DN_Line_ID = pDNLine_ID
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
    Friend WithEvents ColorCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents WIPChk As System.Windows.Forms.CheckBox
    Friend WithEvents DimensionTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents InstructionTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProjectCmb As DevExpress.XtraEditors.LookUpEdit
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
        Me.ColorCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.WIPChk = New System.Windows.Forms.CheckBox
        Me.DimensionTxt = New DevExpress.XtraEditors.MemoEdit
        Me.InstructionTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ProjectCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SearchBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ProductSearchTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DimensionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label27.Location = New System.Drawing.Point(304, 120)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Product List"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(304, 216)
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
        Me.SelectBtn.Location = New System.Drawing.Point(312, 344)
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
        Me.CloseBtn.Location = New System.Drawing.Point(400, 344)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 50
        Me.CloseBtn.Text = "&Close"
        '
        'ProductList
        '
        Me.ProductList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductList.Location = New System.Drawing.Point(400, 120)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(360, 39)
        Me.ProductList.TabIndex = 56
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(400, 216)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(56, 19)
        Me.QtyTxt.TabIndex = 65
        Me.QtyTxt.Text = "0"
        '
        'ColorCmb
        '
        Me.ColorCmb.Location = New System.Drawing.Point(400, 192)
        Me.ColorCmb.Name = "ColorCmb"
        Me.ColorCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ColorCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ColorCmb.Properties.NullString = ""
        Me.ColorCmb.Properties.PopupWidth = 248
        Me.ColorCmb.Size = New System.Drawing.Size(232, 19)
        Me.ColorCmb.TabIndex = 160
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Color"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Project"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(304, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "WIP"
        '
        'WIPChk
        '
        Me.WIPChk.Location = New System.Drawing.Point(400, 240)
        Me.WIPChk.Name = "WIPChk"
        Me.WIPChk.Size = New System.Drawing.Size(16, 16)
        Me.WIPChk.TabIndex = 174
        '
        'DimensionTxt
        '
        Me.DimensionTxt.Location = New System.Drawing.Point(400, 264)
        Me.DimensionTxt.Name = "DimensionTxt"
        Me.DimensionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DimensionTxt.Size = New System.Drawing.Size(232, 32)
        Me.DimensionTxt.TabIndex = 175
        '
        'InstructionTxt
        '
        Me.InstructionTxt.Location = New System.Drawing.Point(400, 304)
        Me.InstructionTxt.Name = "InstructionTxt"
        Me.InstructionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.InstructionTxt.Size = New System.Drawing.Size(232, 32)
        Me.InstructionTxt.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Dimension :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "Instruction :"
        '
        'ProjectCmb
        '
        Me.ProjectCmb.Location = New System.Drawing.Point(400, 168)
        Me.ProjectCmb.Name = "ProjectCmb"
        Me.ProjectCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ProjectCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ProjectCmb.Properties.NullString = ""
        Me.ProjectCmb.Properties.PopupWidth = 360
        Me.ProjectCmb.Size = New System.Drawing.Size(360, 19)
        Me.ProjectCmb.TabIndex = 179
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SearchBtn)
        Me.GroupBox3.Controls.Add(Me.ProductSearchTxt)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 56)
        Me.GroupBox3.TabIndex = 181
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
        Me.GroupBox1.Controls.Add(Me.CloseBtn)
        Me.GroupBox1.Controls.Add(Me.SelectBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 400)
        Me.GroupBox1.TabIndex = 182
        Me.GroupBox1.TabStop = False
        '
        'DeliveryNoteLineForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(794, 425)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ProjectCmb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InstructionTxt)
        Me.Controls.Add(Me.DimensionTxt)
        Me.Controls.Add(Me.WIPChk)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ColorCmb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QtyTxt)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.CategoryTree)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeliveryNoteLineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Note Line"
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DimensionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ProductSearchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable "
    Public DN_Line_ID As Integer
    Public DN_ID As Integer
    Public PartCode_ID As Integer
    Public Qty As String
    Public Category_ID As Integer
    Public Product_ID As Integer
    Public WIP As String
    Public Instruction As String
    Public Color_ID As Integer
    Public Dimension As String
    Public Create_Date As String
    Public Transact_Date As String
    Public UserID As String = Common.CommonConn.Config.USERID

#End Region

#Region " Code - Form load , Category tree list"
    'For Category Portion

    Private Sub DeiveryNoteLineForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCategoryList()
        LoadProject()
        LoadColor()

        Select Case UCase(Status)
            Case "ADD"
                ProductList.Enabled = False
                CategoryTree.Enabled = False
                SelectBtn.Enabled = False

            Case "VIEW"
                Dim ds As DataSet
                With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                    .DN_Line_ID = DN_Line_ID
                    If .GetDNLine_ByLineID(ds, DN_Line_ID) Then
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
                With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
                    If .GetDNLine_ByLineID(ds, DN_Line_ID) Then
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

    Private Sub LoadProject()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ProjectBusLogic
            If .GetProject(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(ProjectCmb, "PartCodeName", 400, 0, "c")
                        ProjectCmb.Properties.LookUpData.KeyField = "PartCode_ID"
                        ProjectCmb.Properties.LookUpData.DisplayField = "PartCodeName"

                        ProjectCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        ProjectCmb.EditValue = "0"
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
                    SaveDeliveryNoteLine()
                Case "EDIT"
                    UpdateDeliveryNoteLine()
            End Select
        End If
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        RefreshProductListByProductID(ProductSearchTxt.Text)
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
    Private Sub SaveDeliveryNoteLine()
        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
            If ValidData() Then
                .DN_ID = DN_ID
                .LnCategory_ID = Category_ID
                .LnProduct_ID = Product_ID
                .LnPartCode_ID = PartCode_ID
                .LnColor_ID = Color_ID
                .LnQty = Qty
                .LnWIP = WIP
                .LnDimension = Dimension
                .LnInstruction = Instruction
                .UserID = UserID

                .SaveDNLine()
                MessageBox.Show("Delivery Note saved!", "Save Delivery Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub UpdateDeliveryNoteLine()
        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
            If ValidData() Then
                .DN_ID = DN_ID
                .LnCategory_ID = Category_ID
                .LnProduct_ID = Product_ID
                .LnPartCode_ID = PartCode_ID
                .LnColor_ID = Color_ID
                .LnQty = Qty
                .LnWIP = WIP
                .LnDimension = Dimension
                .LnInstruction = Instruction
                .UserID = UserID

                .UpdateDNLine(DN_Line_ID)
                MessageBox.Show("Delivery Note updated!", "Updates Delivery Note ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If PartCode_ID = 0 Then
            FieldName = FieldName & " Project" & Chr(13)
            DataOK_Flag = False
        End If

        If Color_ID = 0 Then
            FieldName = FieldName & " Color" & Chr(13)
            DataOK_Flag = False
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

        Category_ID = CategoryTree.SelectedNode.Tag
        If ProductList.SelectedValue Then
            Product_ID = ProductList.SelectedValue.ToString
            PartCode_ID = ProjectCmb.Properties.LookUpData.KeyValue
            Color_ID = ColorCmb.Properties.LookUpData.KeyValue
            Qty = QtyTxt.Text
            If WIPChk.Checked = True Then
                WIP = 1
            Else
                WIP = 0
            End If
            Instruction = InstructionTxt.Text
            Dimension = DimensionTxt.Text
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
        Dim varWIP

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("PartCode_ID")) Then
            ProjectCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("PartCode_ID")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Color_ID")) Then
            ColorCmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("Color_ID")
        End If
        QtyTxt.Text = dsLoad.Tables(0).Rows(0)("Qty")
        varWIP = dsLoad.Tables(0).Rows(0)("WIP")
        If varWIP = 1 Then
            WIPChk.Checked = True
        Else
            WIPChk.Checked = False
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Instruction")) Then
            InstructionTxt.Text = dsLoad.Tables(0).Rows(0)("Instruction")
        End If
        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Dimension")) Then
            DimensionTxt.Text = dsLoad.Tables(0).Rows(0)("Dimension")
        End If

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DeliveryNoteLineForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Work Plan?", "Work Plan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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


