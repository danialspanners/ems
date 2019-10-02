Imports System
Imports System.IO
Imports System.Collections

Public Class InventoryReportForm
    Inherits System.Windows.Forms.Form

    Public strStock_ID As String
    Public Product_Name As String
    Public Edit_Date As String

    Private Cat_ID As Integer
    Private ItemType As Integer
    Private TransactDate As DateTime
    Private GreaterThanZero As Boolean
    Private WithLocation As Boolean
    Private ExcludeZeroPrice As Boolean
    Private InSGD As Boolean
    Private ExtProgressForm As TaskProgressForm
    Private Filter As String
    Private ds As DataSet
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl

    Public UserID As String = Common.CommonConn.Config.USERID


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pCat_ID As Integer, ByVal pItemType As Integer, ByVal pTransactdate As DateTime, ByVal pGreaterThanZero As Boolean, ByVal pExcludeZeroPrice As Boolean, ByVal pSGD As Boolean, ByVal pWithLocation As Boolean, ByVal pPrintPrices As Boolean, ByRef pProgressForm As TaskProgressForm, ByRef pFilter As String, Optional ByVal pCache As Boolean = False)
        ' ByVal pEdit_Date As String)
        MyBase.New()
        Me.Cursor = Cursors.WaitCursor
        'ExtProgressForm = New TaskProgressForm
        'ExtProgressForm.Show()
        'ExtProgressForm.Refresh()
        ExtProgressForm = pProgressForm
        Cat_ID = pCat_ID
        ItemType = pItemType
        TransactDate = pTransactdate
        GreaterThanZero = pGreaterThanZero
        WithLocation = pWithLocation
        ExcludeZeroPrice = pExcludeZeroPrice
        InSGD = pSGD
        Filter = pFilter
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1.NavigationBar.Visible = False

        Dim dsHeaderLoad As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic

            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            'All Items", "Active Items only", "Dormant Items only - 0,1,2
            If pCache = False Then
                If .GetInventoryReport(Cat_ID, ItemType, TransactDate, Now(), GreaterThanZero, WithLocation, ds, ExcludeZeroPrice, InSGD, Filter) Then
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        If (pPrintPrices = True) Then
                            C1Report2.Load(path & "InventoryReportsg.xml", "Inventory Report")
                        Else
                            C1Report2.Load(path & "InventoryReportnoprice.xml", "Inventory Report")
                        End If

                        C1Report2.DataSource.Recordset = ds.Tables(0)

                        'C1PrintPreview1.Document = C1Report1.Document
                        C1PrintPreviewControl1.Document = C1Report2.Document

                    Catch ex As Exception
                        ExtProgressForm.Close()
                        MsgBox(ex.Message)
                        'MsgBox("Failed to Change Current Directory")
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try
                End If
            Else
                If .GetInventoryReportInstant(Cat_ID, ItemType, TransactDate, Now(), GreaterThanZero, WithLocation, ds, ExcludeZeroPrice, InSGD) Then
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        If (pPrintPrices = True) Then
                            C1Report2.Load(path & "InventoryReportsg.xml", "Inventory Report")
                        Else
                            C1Report2.Load(path & "InventoryReportnoprice.xml", "Inventory Report")
                        End If

                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        'C1PrintPreview1.Document = C1Report1.Document
                        C1PrintPreviewControl1.Document = C1Report2.Document

                    Catch ex As Exception
                        ExtProgressForm.Close()
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try
                End If
            End If
        End With

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryReportForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.C1Report2 = New C1.C1Report.C1Report
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 522)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 64)
        Me.Panel1.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CloseBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(678, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 64)
        Me.Panel2.TabIndex = 47
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(24, 16)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(37, 17)
        Me.CloseBtn.TabIndex = 46
        Me.CloseBtn.Text = "&Close"
        '
        'C1Report2
        '
        Me.C1Report2.ReportDefinition = resources.GetString("C1Report2.ReportDefinition")
        Me.C1Report2.ReportName = "C1Report2"
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.AvailablePreviewActions = CType(((((((((((((((((((((((C1.Win.C1Preview.C1PreviewActionFlags.FileSave Or C1.Win.C1Preview.C1PreviewActionFlags.PageSetup) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.Print) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.Reflow) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.PageSingle) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.PageContinuous) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.PageFacing) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.PageFacingContinuous) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.GoFirst) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.GoPrev) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.GoNext) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.GoLast) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.GoPage) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryNext) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryPrev) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomIn) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOut) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomFactor) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomInTool) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOutTool) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.HandTool) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.SelectTextTool) _
                    Or C1.Win.C1Preview.C1PreviewActionFlags.Find), C1.Win.C1Preview.C1PreviewActionFlags)
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.OutlineView
        '
        Me.C1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView"
        Me.C1PrintPreviewControl1.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        Me.C1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.Document = Me.C1Report2
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        '
        'C1PrintPreviewControl1.PreviewTextSearchPanel
        '
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Location = New System.Drawing.Point(530, 0)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(200, 240)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Size = New System.Drawing.Size(200, 453)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False
        '
        'C1PrintPreviewControl1.ThumbnailView
        '
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView"
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 449)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(814, 522)
        Me.C1PrintPreviewControl1.TabIndex = 49
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Visible = False
        '
        'InventoryReportForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(814, 586)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InventoryReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Inventory Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InventoryReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ExtProgressForm.Hide()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    

    Private Sub InventoryReportForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'All Items", "Active Items only", "Dormant Items only - 0,1,2

        If Not ds Is Nothing Then
            If ItemType = 2 And ds.Tables(0).Rows.Count > 0 Then 'Dormant Only
                Dim Result As DialogResult = MessageBox.Show("You have print a dormant items report, Do you want to clear these items?", "Clear Stock?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                If Result = DialogResult.Yes Then
                    Result = MessageBox.Show("Are you sure you want to clear these dormant items?", "Clear Stock?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    If Result = DialogResult.Yes Then
                        ClearDormant()
                    End If
                End If

            End If
        End If


        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If

    End Sub

    Private Sub ClearDormant()
        Dim i As Integer

        Dim SRVID As Integer
        Dim SRVNO As String
        Dim CatName As String

        With New BusinessRules.CategoryBusRules.CategoryBusLogic
            Dim catds As DataSet
            .GetCategory(catds, Me.Cat_ID)
            If Not catds Is Nothing Then
                If catds.Tables(0).Rows.Count > 0 Then
                    CatName = catds.Tables(0).Rows(0)("name")
                End If
            End If
        End With

        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = "CLR-" & CatName.ToUpper() & ds.Tables(0).Rows(i)("RptBalanceDate")

            SRVID = .GetSRVID(SRVNO)
            If SRVID <> -1 Then
                .Delete(SRVID)
            End If

            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "CLR"
            SRVID = .Save()
        End With

        With New BusinessRules.BusRules.InventoryBusLogic

            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1

                    .Transaction_Type = "Stock Clear"
                    .Stock_Out_Type = "Loose Item"
                    .Stock_In_Type = "Loose Item"
                    '.In_Store_Qty = InStoreQty
                    .StockOutQty = Convert.ToInt32(ds.Tables(0).Rows(i)("Qty"))

                    '.WO_ID = WO_ID
                    .UserID = UserID
                    '.Stock_ID = Stock_ID
                    '.Category_ID = Category_ID
                    .Product_ID = ds.Tables(0).Rows(i)("product_id")

                    .WH_ID = 1
                    .Src_WH_ID = 1
                    .Dst_WH_ID = 1
                    .WHA_ID = ds.Tables(0).Rows(i)("warehouse_area_id")

                    'Order_NO = refno_TextBox.Text
                    '.PO_NO = PO_NOtxt.Text
                    '.WO_ID = 1
                    '.Order_Type = Order_Type
                    '.Order_NO = Order_NO
                    '.RequestedBy = ReqByLookup.Properties.LookUpData.KeyValue


                    .SRV_ID = SRVID
                    .Remarks = "Stock clear dormant (From Report Module)"
                    .Transact_Date = ds.Tables(0).Rows(i)("RptBalanceDate")

                    Dim dsExist As DataSet
                    Dim RetStat As Boolean

                    dsExist = .RecordExist(.Product_ID, .WH_ID, .WHA_ID) 'stock exist?

                    If Not dsExist Is Nothing Then
                        .Stock_ID = dsExist.Tables(0).Rows(0).Item("Stock_ID")
                        RetStat = .UpdateSelectedStock()
                        If RetStat Then

                            RetStat = .SaveStockTransaction()

                        End If
                    End If


                Next
            End If

        End With


    End Sub
End Class
