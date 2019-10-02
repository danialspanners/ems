Imports System
Imports System.IO
Imports System.Collections

Public Class LVBDeclarationWorkCompletionLabelRptForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pIO_ID As Integer)
        MyBase.New()

        If Len(pIO_ID) > 0 Then
            IO_ID = pIO_ID
        End If

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1PrintPreviewControl2 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LVBDeclarationWorkCompletionLabelRptForm))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.C1PrintPreviewControl2 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.C1Report1 = New C1.C1Report.C1Report
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.C1PrintPreviewControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl2.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl2.SuspendLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 279)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(625, 66)
        Me.Panel3.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(487, 0)
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
        'C1PrintPreviewControl2
        '
        Me.C1PrintPreviewControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl2.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl2.Name = "C1PrintPreviewControl2"
        '
        'C1PrintPreviewControl2.OutlineView
        '
        Me.C1PrintPreviewControl2.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl2.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl2.PreviewOutlineView.Name = "OutlineView"
        Me.C1PrintPreviewControl2.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        Me.C1PrintPreviewControl2.PreviewOutlineView.TabIndex = 0
        '
        'C1PrintPreviewControl2.PreviewPane
        '
        Me.C1PrintPreviewControl2.PreviewPane.Document = Me.C1Report1
        Me.C1PrintPreviewControl2.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl2.PreviewPane.TabIndex = 0
        '
        'C1PrintPreviewControl2.PreviewTextSearchPanel
        '
        Me.C1PrintPreviewControl2.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1PrintPreviewControl2.PreviewTextSearchPanel.Location = New System.Drawing.Point(530, 0)
        Me.C1PrintPreviewControl2.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(200, 240)
        Me.C1PrintPreviewControl2.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.C1PrintPreviewControl2.PreviewTextSearchPanel.Size = New System.Drawing.Size(200, 453)
        Me.C1PrintPreviewControl2.PreviewTextSearchPanel.TabIndex = 0
        Me.C1PrintPreviewControl2.PreviewTextSearchPanel.Visible = False
        '
        'C1PrintPreviewControl2.ThumbnailView
        '
        Me.C1PrintPreviewControl2.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl2.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl2.PreviewThumbnailView.Name = "ThumbnailView"
        Me.C1PrintPreviewControl2.PreviewThumbnailView.Size = New System.Drawing.Size(165, 206)
        Me.C1PrintPreviewControl2.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl2.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl2.Size = New System.Drawing.Size(625, 279)
        Me.C1PrintPreviewControl2.TabIndex = 8
        Me.C1PrintPreviewControl2.Text = "C1PrintPreviewControl2"
        '
        '
        '
        Me.C1PrintPreviewControl2.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("C1PrintPreviewControl2.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl2.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl2.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.C1PrintPreviewControl2.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl2.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.C1PrintPreviewControl2.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        Me.C1PrintPreviewControl2.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.Checked = True
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.Image = CType(resources.GetObject("C1PrintPreviewControl2.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.C1PrintPreviewControl2.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        '
        '
        '
        Me.C1PrintPreviewControl2.ToolBars.Page.Facing.Image = CType(resources.GetObject("C1PrintPreviewControl2.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl2.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl2.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.C1PrintPreviewControl2.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl2.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.C1PrintPreviewControl2.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.C1PrintPreviewControl2.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("C1PrintPreviewControl2.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl2.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl2.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.C1PrintPreviewControl2.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl2.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.C1PrintPreviewControl2.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        '
        '
        '
        Me.C1PrintPreviewControl2.ToolBars.Text.Find.Image = CType(resources.GetObject("C1PrintPreviewControl2.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl2.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl2.ToolBars.Text.Find.Name = "btnFind"
        Me.C1PrintPreviewControl2.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 20)
        Me.C1PrintPreviewControl2.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        Me.C1PrintPreviewControl2.ToolBars.Text.Find.ToolTipText = "Find Text"
        '
        '
        '
        Me.C1PrintPreviewControl2.ToolBars.Text.SelectText.Image = CType(resources.GetObject("C1PrintPreviewControl2.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl2.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl2.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.C1PrintPreviewControl2.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 20)
        Me.C1PrintPreviewControl2.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.C1PrintPreviewControl2.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool"
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'LVBDeclarationWorkCompletionLabelRptForm
        '
        Me.ClientSize = New System.Drawing.Size(625, 345)
        Me.Controls.Add(Me.C1PrintPreviewControl2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "LVBDeclarationWorkCompletionLabelRptForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl2.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl2.ResumeLayout(False)
        Me.C1PrintPreviewControl2.PerformLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public IO_ID As Integer

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button1.Click
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub LVBDeclarationWorkCompletionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsHeaderLoad As DataSet

        With New BusinessRules.LVBBusRules.LVBBusLogic
            Dim ds As DataSet
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            If .GetDWCLabelReport(ds, IO_ID) Then
                Try
                    'Directory.SetCurrentDirectory("..\Reports\")
                    C1Report1.Load(path & "LVBDeclarationWorkCompletionLabelReport.xml", "LVB Declaration of Work Completion")
                    'C1Report1.Load("LVBDeclarationWorkCompletionLabelReport.xml", "LVB Declaration of Work Completion")
                    C1Report1.DataSource.Recordset = ds.Tables(0)
                    C1PrintPreviewControl2.Document = C1Report1.Document
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Directory.SetCurrentDirectory(tmpCurDir)
                End Try
            End If
        End With
    End Sub



End Class

