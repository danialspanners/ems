Imports System
Imports System.IO
Imports System.Collections

Public Class StockTransReport
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pCat_ID As Integer, ByVal pProductName As String, ByVal pTransactionType As String, ByVal title As String, ByVal SRVID As Integer, ByVal StartDate As String, ByVal EndDate As String, Optional ByVal Type As String = "")
        ' ByVal pEdit_Date As String)
        MyBase.New()
        Me.Cursor = Cursors.WaitCursor
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreview1.NavigationBar.Visible = False

        Dim dsHeaderLoad As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            Dim ds As DataSet
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            If Type = "TRANSACTIONBYDATE" Then
                If .GetStockTransReport_ByDate(pCat_ID, pProductName, pTransactionType, title, StartDate, EndDate, ds) Then
                    Try

                        C1Report2.Load(path & "StocktransactionReport_bydate.xml", "Transaction Report")
                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        Me.Cursor = Cursors.Arrow
                        C1PrintPreviewControl1.Document = C1Report2.Document


                    Catch ex As Exception
                        'ExtProgressForm.Close()
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                        Me.Cursor = Cursors.Arrow
                    End Try
                End If
            Else
                If .GetStockTransReport(title, SRVID, ds) Then
                    Try

                        'Directory.SetCurrentDirectory("..\Reports\")
                        If Type = "QAR" Then
                            C1Report2.Load(path & "recvoucherfinished.xml", "Transaction Report")
                        Else
                            C1Report2.Load(path & "StocktransactionReport.xml", "Transaction Report")
                        End If
                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        Me.Cursor = Cursors.Arrow
                        C1PrintPreviewControl1.Document = C1Report2.Document


                    Catch ex As Exception
                        'ExtProgressForm.Close()
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                        Me.Cursor = Cursors.Arrow
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
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockTransReport))
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.C1Report2 = New C1.C1Report.C1Report
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(26, 16)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 46
        Me.CloseBtn.Text = "&Close"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 487)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 54)
        Me.Panel1.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CloseBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(580, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(116, 54)
        Me.Panel2.TabIndex = 47
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 414)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(696, 487)
        Me.C1PrintPreviewControl1.TabIndex = 51
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
        'C1Report2
        '
        Me.C1Report2.ReportDefinition = resources.GetString("C1Report2.ReportDefinition")
        Me.C1Report2.ReportName = "C1Report2"
        '
        'StockTransReport
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(696, 541)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StockTransReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    

    Private Sub StockBalDetReportForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ExtProgressForm.Owner = Me
        'ExtProgressForm.Hide()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub StockBalDetReportForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim x
        x = 1
    End Sub

    Private Sub StockBalDetReportForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim x
        x = 1
    End Sub
End Class
