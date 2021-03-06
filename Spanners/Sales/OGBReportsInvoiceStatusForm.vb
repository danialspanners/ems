Imports System
Imports System.IO
Imports System.Collections

Public Class OGBReportsInvoiceStatusForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pContract_ID As Integer, ByVal pSection_ID As Integer, ByVal pSortby As Integer, Optional ByVal pShowNull_TOC As Boolean = False, Optional ByVal pFilters As String = "", Optional ByVal pOptionTxt As String = "")
        MyBase.New()

        Contract_ID = pContract_ID
        Section_ID = pSection_ID
        Sortby = pSortby
        ShowNull_TOC = pShowNull_TOC
        OptionTxt = pOptionTxt
        Filters = pFilters

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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OGBReportsInvoiceStatusForm))
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.C1Report2 = New C1.C1Report.C1Report
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 386)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 57)
        Me.Panel1.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 313)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(925, 386)
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
        'OGBReportsInvoiceStatusForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(925, 443)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "OGBReportsInvoiceStatusForm"
        Me.Text = "OGB Installed But Not Surveyed"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Index_No As String
    Public Contract_ID As Integer
    Public Section_ID As Integer
    Public ShowNull_TOC As Boolean
    Public OptionTxt As String
    Public Filters As String
    Public Sortby As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

    Private Sub OGBDeclarationWorkCompletionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadIOList()

        Dim dsHeaderLoad As DataSet

        With New BusinessRules.OGBBusRules.OGBBusLogic
            Dim ds As DataSet
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            'Dim path As String = Application.StartupPath
            'Dim i As Integer = path.IndexOf("\bin")
            'If i > -1 Then path = path.Substring(0, i)
            'path = path & "\Reports\"

            If .GetOGBInvoiceStatusReport(ds, Contract_ID, Section_ID, Me.Sortby, Me.ShowNull_TOC, Filters) Then
                Try
                    Directory.SetCurrentDirectory("..\Reports\")
                    'C1Report1.Load("path & OGBReportsInvoicing.xml", "OGB Invoicing Status")
                    C1Report2.Load("OGBReportsInvoicing.xml", "OGB Invoicing Status")
                    C1Report2.DataSource.Recordset = ds.Tables(0)
                    C1PrintPreviewControl1.Document = C1Report2.Document
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Directory.SetCurrentDirectory(tmpCurDir)
                End Try
            End If
        End With
    End Sub


    Private Function GetOfficerName(ByVal pOfficer_Id As Integer) As String
        With New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
            Dim dstmp As DataSet
            If .GetOfficerInCharge(dstmp, pOfficer_Id) Then
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
        AddColumn(data, "Compl Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "DWC Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "TOC Recv", System.Type.GetType("System.String"), True)
        AddColumn(data, "Invoice No", System.Type.GetType("System.String"), True)
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


    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then
            pDate = Date.Parse(pInputDate)
            tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
        End If

        Return tempsDate
    End Function

    Private Sub OGBReportsInvoiceStatusForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub C1PrintPreview2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
