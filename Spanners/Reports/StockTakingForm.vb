Imports System
Imports System.IO
Imports System.Collections

Public Class StockTakingForm
    Inherits System.Windows.Forms.Form

    Public strStock_ID As String
    Public Product_Name As String
    Public Edit_Date As String

    Private ds As DataSet
    Private Cat_ID As Integer
    Private ItemType As Integer
    Private TransactDate As DateTime
    Private RecordDate As DateTime
    Private GreaterThanZero As Boolean
    Private WithLocation As Boolean
    Private Cache As Boolean
    Private WHArea As Decimal
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl

    Private WithEvents ExtProgressForm As TaskProgressForm

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pCat_ID As Integer, ByVal pItemType As Integer, ByVal pTransactdate As DateTime, ByVal pRecordDate As DateTime, ByVal pArea As Decimal, ByVal pGreaterThanZero As Boolean, ByVal pWithLocation As Boolean, ByVal pPrintPrices As Boolean, Optional ByVal pCache As Boolean = False)
        ' ByVal pEdit_Date As String)

        MyBase.New()

        Dim Filter As String

        Me.Cursor = Cursors.WaitCursor

        'ExtProgressForm.Show()
        'ExtProgressForm.Refresh()

        Cat_ID = pCat_ID
        ItemType = pItemType
        TransactDate = pTransactdate
        RecordDate = pRecordDate
        GreaterThanZero = pGreaterThanZero
        WithLocation = pWithLocation
        Cache = pCache
        WHArea = pArea
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreview1.NavigationBar.Visible = False

        Dim dsHeaderLoad As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic

            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            If WHArea <> 0 Then
                Filter = " AND w.warehouse_area_id=" & WHArea
            Else
                Filter = ""
            End If

            'TEMP Filter'
            'Filter = " AND p.Name not in ('KY-A69','KY-A91','MC-MG26/01','MC-MG210/01','TB-EM6/8STP.RS') "

            If Cache = False Then

                'Me.ExtProgressForm.ShowDialog()
                BackgroundWorker1.RunWorkerAsync()

            Else

                If .GetInventoryReportInstant(Cat_ID, ItemType, TransactDate, RecordDate, GreaterThanZero, WithLocation, ds, False, False, Filter) Then
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        C1Report2.Load(path & "stocktakingform.xml", "stock taking form")


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


    Public Sub New(ByVal pCat_ID As Integer, ByVal pItemType As Integer, ByVal pTransactdate As DateTime, ByVal pRecordDate As DateTime, ByVal pArea As Decimal, ByVal pGreaterThanZero As Boolean, ByVal pWithLocation As Boolean, ByVal pPrintPrices As Boolean, ByRef pProgressForm As TaskProgressForm, Optional ByVal pCache As Boolean = False)
        ' ByVal pEdit_Date As String)

        MyBase.New()

        Dim Filter As String

        Me.Cursor = Cursors.WaitCursor
        'ExtProgressForm = New TaskProgressForm
        'ExtProgressForm.Show()
        'ExtProgressForm.Refresh()
        ExtProgressForm = pProgressForm
        Cat_ID = pCat_ID
        ItemType = pItemType
        TransactDate = pTransactdate
        RecordDate = pRecordDate
        GreaterThanZero = pGreaterThanZero
        WithLocation = pWithLocation
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreview1.NavigationBar.Visible = False

        Dim dsHeaderLoad As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic

            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            If pArea <> 0 Then
                Filter = " AND w.warehouse_area_id=" & pArea
            Else
                Filter = ""
            End If

            'TEMP Filter'
            'Filter = " AND p.Name not in ('KY-A69','KY-A91','MC-MG26/01','MC-MG210/01','TB-EM6/8STP.RS') "

            If pCache = False Then

                If .GetInventoryReport(Cat_ID, ItemType, TransactDate, RecordDate, GreaterThanZero, WithLocation, ds, False, False, Filter) Then
                    Try
                        Me.Cursor = Cursors.Default
                        'Directory.SetCurrentDirectory("..\Reports\")
                        C1Report2.Load(path & "stocktakingform.xml", "stock taking form")


                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        'C1PrintPreview1.Document = C1Report1.Document
                        C1PrintPreviewControl1.Document = C1Report2.Document

                    Catch ex As Exception
                        Me.ExtProgressForm.Close()
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try
                End If

            Else

                If .GetInventoryReportInstant(Cat_ID, ItemType, TransactDate, RecordDate, GreaterThanZero, WithLocation, ds, False, False, Filter) Then
                    Try
                        Me.Cursor = Cursors.Default
                        'Directory.SetCurrentDirectory("..\Reports\")
                        C1Report2.Load(path & "stocktakingform.xml", "stock taking form")


                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        'C1PrintPreview1.Document = C1Report1.Document
                        C1PrintPreviewControl1.Document = C1Report2.Document

                    Catch ex As Exception
                        Me.ExtProgressForm.Close()
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try
                End If

            End If

        End With

        Me.Cursor = Cursors.Default

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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockTakingForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
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
        Me.Panel1.Location = New System.Drawing.Point(0, 493)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 48)
        Me.Panel1.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(608, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 48)
        Me.Panel2.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 34)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 420)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(808, 493)
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
        'StockTakingForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(808, 541)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StockTakingForm"
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
    Public Sub CancelPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtProgressForm.CancelButtonPressed
        Me.ExtProgressForm.Close()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StockTakingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.Close()
        'Dim a As MainForm = Me.ParentForm
        'If (a.MainTabControl.TabPages.Count > 0) Then
        'If Not (a.MainTabControl.SelectedTab Is Nothing) Then
        ' a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
        'End If
        'End If
        Me.Close()
    End Sub

    Private Sub StockTakingForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub StockTakingForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As System.ComponentModel.BackgroundWorker = Me.BackgroundWorker1
        e.Result = GenerateReport(worker, e)
    End Sub

    Function GenerateReport(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long

        Dim Filter As String


        With New BusinessRules.BusRules.InventoryBusLogic

            If WHArea <> 0 Then
                Filter = " AND w.warehouse_area_id=" & WHArea
            Else
                Filter = ""
            End If


            If .GetInventoryReport(Cat_ID, ItemType, TransactDate, RecordDate, GreaterThanZero, WithLocation, ds, False, False, Filter) Then
                Try
                    'Directory.SetCurrentDirectory("..\Reports\")


                Catch ex As Exception
                    Me.ExtProgressForm.Close()
                    MsgBox(ex.Message)
                Finally
                    'Directory.SetCurrentDirectory(tmpCurDir)
                End Try
            End If
        End With


    End Function

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted


        Dim tmpCurDir = Directory.GetCurrentDirectory()
        Dim path As String = Application.StartupPath
        Dim i As Integer = path.IndexOf("\bin")
        If i > -1 Then path = path.Substring(0, i)
        path = path & "\Reports\"

        C1Report2.Load(path & "stocktakingform.xml", "stock taking form")

        C1Report2.DataSource.Recordset = ds.Tables(0)
        'C1PrintPreview1.Document = C1Report1.Document
        C1PrintPreviewControl1.Document = C1Report2.Document

        Me.Cursor = Cursors.Default



    End Sub
End Class
