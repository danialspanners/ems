Public Class LVBNotificationSubcontForm
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LVBNotificationSubcontForm))
        Me.IOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
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
        Me.IOGrid.Size = New System.Drawing.Size(912, 446)
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
        Me.GridView2.VertScrollTipFieldName = Nothing
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 389)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(912, 57)
        Me.Panel1.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LVBNotificationSubcontForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(912, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IOGrid)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "LVBNotificationSubcontForm"
        Me.Text = "Notification to Subcontractor"
        CType(Me.IOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Index_No As String
    Public Contract_ID As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

    Private Sub LVBNotificationSubcontForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadIOList()
    End Sub

    Private Sub LoadIOList()
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBBusLogic
            .Contract_Id = Contract_ID
            If .GetIOWContractId(ds) Then
                InitIOGrid()
                Dim oRow As DataRow
                Dim ParentIO As String

                For Each oRow In ds.Tables(0).Rows
                    Dim OfficerName
                    Dim Index_No

                    If Not IsDBNull(oRow("Officer_In_Charge_Id")) Then
                        OfficerName = GetOfficerName(oRow("Officer_In_Charge_Id"))
                    Else
                        OfficerName = ""
                    End If

                    If Not oRow("Parent_IO_ID") = 0 Then
                        If .GetIO(ds, oRow("Parent_IO_Id")) Then
                            If ds.Tables(0).Rows.Count > 0 Then
                                ParentIO = ds.Tables(0).Rows(0)("IO_NO")
                            End If
                        End If
                    Else
                        ParentIO = ""
                    End If

                    If Not IsDBNull(oRow("Index_No")) Then
                        Index_No = oRow("Index_No")
                    Else
                        Index_No = ""
                    End If

                    data.Rows.Add(New Object() {oRow("IO_Id"), oRow("Contract_Id"), Index_No, oRow("IO_No"), OfficerName, ParentIO})
                Next
                IOGrid.DataSource = data
                IOGrid.DefaultView.PopulateColumns()
                'GridView2.BestFitColumns()
                'GridView2.Columns.Item(0).VisibleIndex = -1 'hide 1st column
                'GridView2.Columns.Item(1).VisibleIndex = -1
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
                GetOfficerName = dstmp.Tables(0).Rows(0)("Officer_Name")
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
        AddColumn(data, "Officer-in-Charge", System.Type.GetType("System.String"), True)
        AddColumn(data, "Previous I/O", System.Type.GetType("System.String"), True)
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
        Dim StrIO_ID
        Dim NextIndexNo As Integer
        Dim CurrentIndexNo As String

        If Not GridView2.IsGroupRow(GridView2.GetSelectedRows(0)) Then
            With New BusinessRules.LVBBusRules.LVBBusLogic
                CurrentIndexNo = .GetMaxIndexNo
                NextIndexNo = Integer.Parse(CurrentIndexNo) + 1
                Index_No = InsertZero(NextIndexNo)
            End With

            If Not (arr Is Nothing) Then
                For Each i In arr
                    Dim Row As Integer = i.ToString
                    Dim dr As DataRow
                    Dim IndexNo As String

                    dr = GridView2.GetDataRow(Row)
                    StrIO_ID = StrIO_ID & dr(0) & ","
                    IndexNo = dr(2)

                    If Not Len(Trim(IndexNo)) > 0 Then
                        With New BusinessRules.LVBBusRules.LVBBusLogic
                            .Index_No = Index_No
                            .UserID = UserID
                            .IO_Id = dr(0)
                            .UpdateIndexNo()
                        End With
                    End If
                Next
                Dim slen
                slen = Len(StrIO_ID)
                StrIO_ID = Microsoft.VisualBasic.Left(StrIO_ID, slen - 1)

                Dim Row1 As Integer = GridView2.GetSelectedRows(0)
                Dim dr1 As DataRow
                dr1 = GridView2.GetDataRow(Row1)
                Dim Quotation_ID As Integer = dr1(0)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New NotificationLVBInstallRptForm(StrIO_ID)
                page = New Crownwood.Magic.Controls.TabPage("Print Notification", controlToAdd, ImageList1, 0)

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
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadIOList()
    End Sub

    Private Sub LVBNotificationSubcontForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
