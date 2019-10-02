Public Class LVBDeclarationWorkCompletionForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pContract_ID As Integer)
        MyBase.New()

        Contract_ID = pContract_ID

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
    Friend WithEvents IOGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PrintChecklist_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LVBDeclarationWorkCompletionForm))
        Me.IOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PrintChecklist_ComboBox = New System.Windows.Forms.ComboBox
        CType(Me.IOGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IOGrid
        '
        Me.IOGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IOGrid.EditorsRepository = Me.PersistentRepository1
        Me.IOGrid.Location = New System.Drawing.Point(0, 0)
        Me.IOGrid.MainView = Me.GridView2
        Me.IOGrid.Name = "IOGrid"
        Me.IOGrid.Size = New System.Drawing.Size(956, 398)
        Me.IOGrid.TabIndex = 4
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView2.Name = "GridView2"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PrintChecklist_ComboBox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 398)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 57)
        Me.Panel1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(36, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 31)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(512, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 31)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Print DWC - Label"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 31)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Print DWC- LVB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(167, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 31)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Print Installation Checklist"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(810, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 57)
        Me.Panel2.TabIndex = 21
        '
        'PrintChecklist_ComboBox
        '
        Me.PrintChecklist_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrintChecklist_ComboBox.FormattingEnabled = True
        Me.PrintChecklist_ComboBox.Items.AddRange(New Object() {"New", "Re-used", "Old"})
        Me.PrintChecklist_ComboBox.Location = New System.Drawing.Point(30, 20)
        Me.PrintChecklist_ComboBox.Name = "PrintChecklist_ComboBox"
        Me.PrintChecklist_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PrintChecklist_ComboBox.TabIndex = 22
        '
        'LVBDeclarationWorkCompletionForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(956, 455)
        Me.Controls.Add(Me.IOGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "LVBDeclarationWorkCompletionForm"
        Me.Text = "Notification to Subcontractor"
        CType(Me.IOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Index_No As String
    Public Contract_ID As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

    Private Sub LVBDeclarationWorkCompletionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadIOList()

        PrintChecklist_ComboBox.SelectedItem = "New"

    End Sub

    Private Sub LoadIOList()
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBBusLogic
            .Contract_Id = Contract_ID
            If .GetIOWContractId2(ds) Then
                InitIOGrid()
                Dim oRow As DataRow
                Dim ParentIO As String


                IOGrid.DataSource = ds.Tables(0)
                IOGrid.DefaultView.PopulateColumns()
                InitEditors()
            End If
        End With
    End Sub

    Private Sub InitEditors()
        On Error Resume Next
        GridView2.BestFitColumns()
        GridView2.Columns.Item(0).VisibleIndex = -1
        GridView2.Columns.Item(1).VisibleIndex = -1 'hide 1st column
        'GridView2.BehaviorOptions = GridView2.BehaviorOptions Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.MultiSelect
    End Sub

    Private Function GetOfficerName(ByVal pOfficer_Id As Integer) As String
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
            Dim dstmp As DataSet
            If .GetOfficerInCharge(dstmp, pOfficer_Id) Then
                If dstmp.Tables(0).Rows.Count <> 0 Then
                    If Not IsDBNull(dstmp.Tables(0).Rows(0)("Officer_Name")) Then
                        GetOfficerName = dstmp.Tables(0).Rows(0)("Officer_Name")
                    Else
                        GetOfficerName = ""
                    End If
                End If
            End If
            dstmp.Dispose()
        End With
    End Function

    Private Sub InitIOGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "IO_Id", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Contract_Id", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Index No", System.Type.GetType("System.String"), True)
        AddColumn(data, "I/O No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Officer-in-Charge x", System.Type.GetType("System.String"), True)
        AddColumn(data, "Previous I/O", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim arr As Int32() = GridView2.GetSelectedRows
        Dim i As Integer
        Dim IO_ID As Integer

        If GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                IO_ID = dr(0)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New LVBDeclarationWorkCompletionRptForm(IO_ID)
                page = New Crownwood.Magic.Controls.TabPage("Print Declaration of Work Completion", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub PrintLabelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim arr As Int32() = GridView2.GetSelectedRows
        Dim i As Integer
        Dim IO_ID As Integer

        If GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                IO_ID = dr(0)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New LVBDeclarationWorkCompletionLabelRptForm(IO_ID)
                page = New Crownwood.Magic.Controls.TabPage("Print Declaration of Work Completion", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Function InsertZero(ByVal NextIndexNo As String) As String
        Dim Count As Integer = Len(NextIndexNo)
        Dim tmpStr As String
        For i As Integer = 0 To Count + 1
            NextIndexNo = "0" & NextIndexNo
        Next
        InsertZero = NextIndexNo
    End Function

    Private Sub LVBDeclarationWorkCompletionForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim arr As Int32() = GridView2.GetSelectedRows
        Dim i As Integer
        Dim IO_ID As Integer

        If GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                IO_ID = dr(0)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New LVBDeclarationWorkCompletionRptForm(IO_ID, 2)
                page = New Crownwood.Magic.Controls.TabPage("Print LVB Installation Checklist", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim arr As Int32() = GridView2.GetSelectedRows
        Dim i As Integer
        Dim IO_ID As Integer

        If GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                IO_ID = dr(0)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New LVBDeclarationWorkCompletionRptForm(IO_ID, 1)
                page = New Crownwood.Magic.Controls.TabPage("Print LVB Installation Checklist", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim Checklist_Type As Integer
        'Print Check List'
        If PrintChecklist_ComboBox.Text = "New" Then
            Checklist_Type = 1
        ElseIf PrintChecklist_ComboBox.Text = "Re-used" Then
            Checklist_Type = 3
        ElseIf PrintChecklist_ComboBox.Text = "Old" Then
            Checklist_Type = 2
        End If

        Dim arr As Int32() = GridView2.GetSelectedRows
        Dim i As Integer
        Dim IO_ID As Integer

        If GridView2.RowCount > 0 Then
            If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView2.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView2.GetDataRow(Row)
                IO_ID = dr(0)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New LVBDeclarationWorkCompletionRptForm(IO_ID, Checklist_Type)
                page = New Crownwood.Magic.Controls.TabPage("Print LVB Installation Checklist", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub
End Class
