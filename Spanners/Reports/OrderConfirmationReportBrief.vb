Imports System
Imports System.IO
Imports System.Collections

Public Class OrderConfirmationReportBriefForm
    Inherits System.Windows.Forms.Form

    Public Quotation_ID As Integer
    Public QuotationTitle As String
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Public UserID As String = Common.CommonConn.Config.USERID

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pQuotation_ID As Integer)
        MyBase.New()
        Quotation_ID = pQuotation_ID

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreviewControl1.NavigationBar.Visible = False

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderConfirmationReportBriefForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 530)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 60)
        Me.Panel1.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(540, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 60)
        Me.Panel2.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 457)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(672, 530)
        Me.C1PrintPreviewControl1.TabIndex = 53
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
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 20)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.ToolTipText = "Find Text"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 20)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool"
        '
        'C1Report2
        '
        Me.C1Report2.ReportDefinition = resources.GetString("C1Report2.ReportDefinition")
        Me.C1Report2.ReportName = "C1Report2"
        '
        'OrderConfirmationReportBriefForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(672, 590)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OrderConfirmationReportBriefForm"
        Me.Text = "Quotation Report"
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

    Private Sub OrderConfirmationReportBriefForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With New BusinessRules.SaleBusRules.SaleBusLogic
            Dim dsTmp As DataSet
            Dim Special_ID As Integer
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            .Quotation_ID = Quotation_ID
            If .IsRevisedQuote(dsTmp) Then
                QuotationTitle = " Revised Order Confirmation "
            Else
                QuotationTitle = " Order Confirmation "
            End If
            'dsTmp.Dispose()

            If .GetOrderConfirmHeader(dsTmp, Quotation_ID) Then
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    If Not IsDBNull(dsTmp.Tables(0).Rows(0)("Special_ID")) Then
                        Special_ID = dsTmp.Tables(0).Rows(0)("Special_ID")
                    Else
                        Special_ID = 1
                    End If
                End If
            End If

            If .GetOrderConfirmHeader(dsTmp, Quotation_ID) Then
                Dim ds As DataSet

                If dsTmp.Tables(0).Rows.Count > 0 Then
                    If Not IsDBNull(dsTmp.Tables(0).Rows(0)("Customer_PO")) Then
                        Try
                            'Directory.SetCurrentDirectory("..\Reports\")
                            Select Case (Special_ID)
                                Case 1
                                    If Len(dsTmp.Tables(0).Rows(0)("Customer_PO")) > 0 Then
                                        '** IF THERE'S PO NO, CHOOSE THE REPORT W/O SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            C1Report2.Load(path & "OrderConfirmationwoSignBrief.xml", "Order Confirmation")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    Else
                                        '** REPORT WITH SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            C1Report2.Load(path & "OrderConfirmationBrief.xml", "Order Confirmation")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    End If

                                Case 2
                                    If Len(dsTmp.Tables(0).Rows(0)("Customer_PO")) > 0 Then
                                        '** IF THERE'S PO NO, CHOOSE THE REPORT W/O SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            C1Report2.Load(path & "OrderConfirmationForBoxSurveywoSignBrief.xml", "Order Confirmation For Box Survey")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    Else
                                        '** REPORT WITH SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            C1Report2.Load(path & "OrderConfirmationForBoxSurveyBrief.xml", "Order Confirmation For Box Survey")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    End If

                                Case 3
                                    If Len(dsTmp.Tables(0).Rows(0)("Customer_PO")) > 0 Then
                                        '** IF THERE'S PO NO, CHOOSE THE REPORT W/O SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            C1Report2.Load(path & "OrderConfirmationForCableSurveywoSignBrief.xml", "Order Confirmation For Cable Survey")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    Else
                                        '** REPORT WITH SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            C1Report2.Load(path & "OrderConfirmationForCableSurveyBrief.xml", "Order Confirmation For Cable Survey")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    End If

                                Case 4
                                    If Len(dsTmp.Tables(0).Rows(0)("Customer_PO")) > 0 Then
                                        '** IF THERE'S PO NO, CHOOSE THE REPORT W/O SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            C1Report2.Load(path & "OrderConfirmationForSwitchboardwoSignBrief.xml", "Order Confirmation For Switchboard")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    Else
                                        '** REPORT WITH SIGNATURE **
                                        If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                            'C1Report2.Load("../Reports/OrderConfirmationForSwitchboardSurvey.xml", "Order Confirmation For Switchboard")
                                            C1Report2.Load(path & "OrderConfirmationForSwitchboardBrief.xml", "Order Confirmation For Switchboard")
                                            C1Report2.DataSource.Recordset = ds.Tables(0)
                                            C1PrintPreviewControl1.Document = C1Report2.Document
                                        End If
                                    End If


                            End Select
                        Catch ex As Exception
                            MsgBox("Failed to Change Current Directory")
                        Finally
                            Directory.SetCurrentDirectory(tmpCurDir)
                        End Try
                    Else
                        Try
                            'Directory.SetCurrentDirectory("..\Reports\")
                            Select Case (Special_ID)
                                Case 1
                                    '** REPORT WITH SIGNATURE **
                                    If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                        C1Report2.Load(path & "OrderConfirmationBrief.xml", "Order Confirmation")
                                        C1Report2.DataSource.Recordset = ds.Tables(0)
                                        C1PrintPreviewControl1.Document = C1Report2.Document
                                    End If

                                Case 2
                                    '** REPORT WITH SIGNATURE **
                                    If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                        C1Report2.Load(path & "OrderConfirmationForBoxSurveyBrief.xml", "Order Confirmation For Box Survey")
                                        C1Report2.DataSource.Recordset = ds.Tables(0)
                                        C1PrintPreviewControl1.Document = C1Report2.Document
                                    End If

                                Case 3
                                    '** REPORT WITH SIGNATURE **
                                    If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                        C1Report2.Load(path & "OrderConfirmationForCableSurveyBrief.xml", "Order Confirmation For Cable Survey")
                                        C1Report2.DataSource.Recordset = ds.Tables(0)
                                        C1PrintPreviewControl1.Document = C1Report2.Document
                                    End If

                                Case 4
                                    '** REPORT WITH SIGNATURE **
                                    If .GetOrderConfirmationRpt(ds, Quotation_ID, QuotationTitle, UserID) Then
                                        C1Report2.Load(path & "OrderConfirmationForSwitchboardSurveyBrief.xml", "Order Confirmation For Switchboard")
                                        C1Report2.DataSource.Recordset = ds.Tables(0)
                                        C1PrintPreviewControl1.Document = C1Report2.Document
                                    End If
                            End Select
                        Catch ex As Exception
                            MsgBox("Failed to Change Current Directory")
                        Finally
                            'Directory.SetCurrentDirectory(tmpCurDir)
                        End Try
                    End If
                End If
            End If
            dsTmp.Dispose()
        End With
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
