Public Class OGBReportsPendingTOCForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pContract_ID As Integer, ByVal pSortBy As Integer)
        MyBase.New()

        Contract_ID = pContract_ID
        SortBy = pSortBy

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.IOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.IOGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IOGrid
        '
        Me.IOGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IOGrid.EditorsRepository = Me.PersistentRepository1
        Me.IOGrid.Location = New System.Drawing.Point(0, 0)
        Me.IOGrid.MainView = Me.GridView2
        Me.IOGrid.Name = "IOGrid"
        Me.IOGrid.Size = New System.Drawing.Size(904, 446)
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
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 389)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 57)
        Me.Panel1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OGBReportsPendingTOCForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(904, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IOGrid)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "OGBReportsPendingTOCForm"
        Me.Text = "OGB Installed But Not Surveyed"
        CType(Me.IOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Index_No As String
    Public Contract_ID As Integer
    Public SortBy As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

    Private Sub OGBDeclarationWorkCompletionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadIOList()
    End Sub

    Private Sub LoadIOList()
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBBusLogic
            .Contract_Id = Contract_ID
            If .GetIOWContractIdRptPendingTOC(ds) Then
                InitIOGrid()
                Dim oRow As DataRow
                Dim ParentIO As String
                Dim Index_No As Integer = 0
                Dim OfficerName As String
                Dim SectionCode As String

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each oRow In ds.Tables(0).Rows
                        Index_No = Index_No + 1
                        If Not IsDBNull(oRow("Officer_In_Charge_Id")) Then
                            OfficerName = GetOfficerName(oRow("Officer_In_Charge_Id"))
                        Else
                            OfficerName = ""
                        End If

                        If Not IsDBNull(oRow("OGB_Section")) Then
                            SectionCode = GetSectionCode(oRow("OGB_Section"))
                        Else
                            SectionCode = ""
                        End If

                        data.Rows.Add(New Object() {oRow("OGB_IO_Id"), oRow("Contract_Id"), Index_No, OfficerName, SectionCode, oRow("IO_No"), oRow("OGB_Location"), oRow("Serial_No"), ChangeDateFormat(oRow("Commence_Date")), ChangeDateFormat(oRow("Completion_Date")), ChangeDateFormat(oRow("Installation_Date"))})
                    Next
                End If

                IOGrid.DataSource = data
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
                'GetOfficerName = dstmp.Tables(0).Rows(0)("Officer_Name")
                If dstmp.Tables(0).Rows.Count > 0 Then
                    GetOfficerName = dstmp.Tables(0).Rows(0)("Officer_Name")
                Else
                    GetOfficerName = ""
                End If
            End If
            dstmp.Dispose()
        End With
    End Function

    Private Function GetSectionCode(ByVal pSection_Id As Integer) As String
        With New BusinessRules.SystemBusRules.SectionBusLogic
            Dim dstmp As DataSet
            If .GetSection(dstmp, pSection_Id) Then
                GetSectionCode = dstmp.Tables(0).Rows(0)("Section_Code")
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
        AddColumn(data, "Officer-in-Charge", System.Type.GetType("System.String"), True)
        AddColumn(data, "Section", System.Type.GetType("System.String"), True)
        AddColumn(data, "I/O No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Location", System.Type.GetType("System.String"), True)
        AddColumn(data, "S/No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Comm Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "Exp Compl Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "Install Date", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim arr As Int32() = GridView2.GetSelectedRows
        Dim i As Integer
        Dim IO_ID As Integer

        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView2.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView2.GetDataRow(Row)
            IO_ID = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            'controlToAdd = New OGBReportsPendingTOCRptForm(IO_ID, Me.SortBy)
            page = New Crownwood.Magic.Controls.TabPage("Print Pending TOC With Officer", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then
            pDate = Date.Parse(pInputDate)
            tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
        End If

        Return tempsDate
    End Function

    Private Sub OGBReportsPendingTOCForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
