Imports System
Imports System.IO
Imports System.Collections

Public Class DeliveryNoteReportForm
    Inherits System.Windows.Forms.Form

    Public Confirm_Quotation_No As String
    Public DN_ID As String
    Public StrQuotationLineID As String
    Public Customer_ID As Integer
    Public Contact_ID As Integer
    Public DeliveryNo As String
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Public Payment As Integer

#Region " Windows Form Designer generated code "

    'Public Sub New(Optional ByVal pDN_ID As Integer = 0, Optional ByVal pStrQuotationLineID As String = "", _
    '               Optional ByVal pCustomer_ID As Integer = 0, Optional ByVal pContact_ID As Integer = 0, _
    '               Optional ByVal pDeliveryNo As String = "", Optional ByVal pConfirm_Quotation_No As String = "", _
    '               Optional ByVal pPayment As String = "")
    Public Sub New(ByVal pDN_ID As String)
        MyBase.New()
        If Not pDN_ID = 0 Then
            DN_ID = pDN_ID
        End If

        'If Len(pStrQuotationLineID) > 0 Then
        '    StrQuotationLineID = pStrQuotationLineID
        'End If

        'If Not pCustomer_ID = 0 Then
        '    Customer_ID = pCustomer_ID
        'End If

        'If Not pContact_ID = 0 Then
        '    Contact_ID = pContact_ID
        'End If

        'If Len(pDeliveryNo) > 0 Then
        '    DeliveryNo = pDeliveryNo
        'End If

        'If Len(pConfirm_Quotation_No) > 0 Then
        '    Confirm_Quotation_No = pConfirm_Quotation_No
        'End If

        'If Not Len(pPayment) = 0 Then
        '    Payment = pPayment
        'End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreview1.NavigationBar.Visible = False


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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliveryNoteReportForm))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.C1Report1 = New C1.C1Report.C1Report
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 311)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 66)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(534, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(138, 66)
        Me.Panel4.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'C1PrintPreviewControl1
        '
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
        Me.C1PrintPreviewControl1.PreviewPane.Document = Me.C1Report1
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 238)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(672, 311)
        Me.C1PrintPreviewControl1.TabIndex = 4
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
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
        'DeliveryNoteReportForm
        '
        Me.ClientSize = New System.Drawing.Size(672, 377)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "DeliveryNoteReportForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DeliveryNoteReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsHeaderLoad As DataSet

        With New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic

            Dim ds As DataSet
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            'If .GetDeliveryNoteRpt(ds, StrQuotationLineID, Customer_ID, Contact_ID, DeliveryNo, Confirm_Quotation_No, Payment) Then
            If .GetDeliveryNoteRpt(ds, DN_ID) Then
                Try
                    'Directory.SetCurrentDirectory("..\Reports\")
                    C1Report1.Load(path & "DeliveryNote.xml", "Delivery Note")
                    C1Report1.DataSource.Recordset = ds.Tables(0)
                    C1PrintPreviewControl1.Document.Document = C1Report1.Document
                Catch ex As Exception
                    MsgBox("Failed to Change Current Directory")
                Finally
                    'Directory.SetCurrentDirectory(tmpCurDir)
                End Try
            End If

        End With
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
