Public Class LVBListingForm
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
    Friend WithEvents ContractGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IOGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents EditBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LVBListingForm))
        Me.ContractGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.IOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.EditBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.ContractGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IOGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContractGrid
        '
        Me.ContractGrid.EditorsRepository = Me.PersistentRepository1
        Me.ContractGrid.Location = New System.Drawing.Point(8, 24)
        Me.ContractGrid.MainView = Me.GridView1
        Me.ContractGrid.Name = "ContractGrid"
        Me.ContractGrid.Size = New System.Drawing.Size(776, 184)
        Me.ContractGrid.TabIndex = 1
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
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contract Listing"
        '
        'IOGrid
        '
        Me.IOGrid.EditorsRepository = Me.PersistentRepository2
        Me.IOGrid.Location = New System.Drawing.Point(8, 240)
        Me.IOGrid.MainView = Me.GridView2
        Me.IOGrid.Name = "IOGrid"
        Me.IOGrid.Size = New System.Drawing.Size(776, 184)
        Me.IOGrid.TabIndex = 3
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView2
        '
        Me.GridView2.DefaultEdit = Me.RepositoryItemTextEdit2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.VertScrollTipFieldName = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "I/O Listing"
        '
        'EditBtn
        '
        Me.EditBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Image = Nothing
        Me.EditBtn.Location = New System.Drawing.Point(576, 432)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(64, 32)
        Me.EditBtn.TabIndex = 5
        Me.EditBtn.Text = "Edit"
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(720, 432)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "Close"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'DelBtn
        '
        Me.DelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.Image = Nothing
        Me.DelBtn.Location = New System.Drawing.Point(648, 432)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(64, 32)
        Me.DelBtn.TabIndex = 7
        Me.DelBtn.Text = "&Delete"
        '
        'btnRefresh
        '
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(496, 432)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "Refresh"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "&Edit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "&Delete"
        '
        'LVBListingForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 477)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IOGrid)
        Me.Controls.Add(Me.ContractGrid)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "LVBListingForm"
        Me.Text = "LVB Listing"
        CType(Me.ContractGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Contract_Id As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

    Private Sub LVBListingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '## Added by Andrew
        SetButtonsControl(False)
        '## End
        LoadContractList()
    End Sub

    Private Sub LoadContractList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            If .GetLVBContract(ds) Then
                InitGrid()
                Dim oRow As DataRow

                For Each oRow In ds.Tables(0).Rows
                    data.Rows.Add(New Object() {oRow("Contract_Id"), oRow("Contract_No")})
                Next
                ContractGrid.DataSource = data
                ContractGrid.DefaultView.PopulateColumns()
                GridView1.BestFitColumns()
                GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "Contract_Id", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Contract No", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Sub ContractGrid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ContractGrid.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        If e.Button = MouseButtons.Left Then
            If Not GridView1.SelectedRowsCount > 1 Then
                Dim arr As Int32() = GridView1.GetSelectedRows
                Dim i As Integer
                If Not (arr Is Nothing) Then
                    For Each i In arr
                        Dim Row As Integer = i.ToString
                        Dim dr As DataRow
                        dr = GridView1.GetDataRow(Row)
                        Contract_Id = dr(0)
                        If Len(Contract_Id) > 0 Then
                            RefreshIOGrid()
                        End If
                    Next
                End If
            End If
        ElseIf e.Button = MouseButtons.Left Then
            ContextMenu1.Show(sender, mouseDownLocation)
        End If
    End Sub

    Public Sub RefreshIOGrid()
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBBusLogic
            .Contract_Id = Contract_Id
            If .GetIOWContractIdNSNO(ds) Then
                InitIOGrid()
                Dim oRow As DataRow
                Dim ParentIO As String

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each oRow In ds.Tables(0).Rows
                        Dim OfficerName
                        'If Not IsDBNull(oRow("Officer_In_Charge_Id")) Then
                        'OfficerName = GetOfficerName(oRow("Officer_In_Charge_Id"))
                        'Else
                        '    OfficerName = ""
                        'End If

                        'If Not oRow("Parent_IO_ID") = 0 Then
                        If Not IsDBNull(oRow("Parent_IO_ID")) Then
                            If oRow("Parent_IO_ID") <> 0 Then
                                If .GetIO(ds, oRow("Parent_IO_Id")) Then
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        ParentIO = ds.Tables(0).Rows(0)("IO_NO")
                                    End If
                                End If
                            Else
                                ParentIO = ""
                            End If
                        Else
                            ParentIO = ""
                        End If
                        ' 21 Septem 03
                        '                        data.Rows.Add(New Object() {oRow("IO_Id"), oRow("Contract_Id"), oRow("IO_No"), ChangeDateFormat(oRow("IO_Recv_Date")), OfficerName, ParentIO, oRow("Serial_No"), oRow("MRC_No")})
                        data.Rows.Add(New Object() {oRow("IO_Id"), oRow("Contract_Id"), oRow("IO_No"), (oRow("Installation_Date")), ParentIO, (oRow("Serial_no")), oRow("MRC_No")})
                    Next
                    IOGrid.DataSource = data
                    IOGrid.DefaultView.PopulateColumns()
                    InitEditors()
                    SetButtonsControl(True)
                Else
                    GridView2.Columns.Clear()
                    SetButtonsControl(False)
                End If
            End If
        End With
    End Sub

    Private Sub SetButtonsControl(ByVal State As Boolean)
        EditBtn.Enabled = State
        DelBtn.Enabled = State
    End Sub

    Private Sub InitEditors()
        On Error Resume Next
        GridView2.BestFitColumns()
        GridView2.Columns.Item(0).VisibleIndex = -1 'hide 1st column
        GridView2.Columns.Item(1).VisibleIndex = -1
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
        AddColumn(data, "I/O No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Installation Date", System.Type.GetType("System.DateTime"), True)
        ' AddColumn(data, "Officer-in-Charge", System.Type.GetType("System.String"), True)
        AddColumn(data, "Previous I/O", System.Type.GetType("System.String"), True)
        AddColumn(data, "Serial No", System.Type.GetType("System.String"), True)
        AddColumn(data, "MRC No", System.Type.GetType("System.String"), True)
        data.EndInit()

    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)
            Dim IO_ID As Integer = dr(0)
            Dim Contract_Id As Integer = dr(1)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            controlToAdd = New LVBFilerForm(Contract_Id, "EDIT", IO_ID)
            page = New Crownwood.Magic.Controls.TabPage("Edit I/O", controlToAdd, ImageList1, 0)
            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)
            Dim IO_Id As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this I/O?", "I/O", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.LVBBusRules.LVBBusLogic
                    .IO_Id = IO_Id
                    If .DeleteOneIO() Then
                        MessageBox.Show("I/O Deleted.", "I/O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            Me.RefreshIOGrid()
        End If
    End Sub

    Private Sub LVBListingForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then
            LoadContractList()
        End If
    End Sub

#Region " Other Code "
    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then
            pDate = Date.Parse(pInputDate)
            tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
        End If

        Return tempsDate

    End Function
#End Region

    Private Sub ContractGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContractGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadContractList()
        End If
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadContractList()
        RefreshIOGrid()
        'comment the below function to prevent system crash when ckicln on refresh button
        'ContractGrid_MouseUp(sender, e)
    End Sub

    Private Sub LVBListingForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub ContractGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContractGrid.Click

    End Sub

    Private Sub ContextMenu1_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub
End Class
