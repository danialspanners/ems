Imports System
Imports System.IO
Imports System.Collections

Public Class OGBDeclarationWorkCompletionRptForm
    Inherits System.Windows.Forms.Form

    Public ReportType As Integer
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pIO_ID As Integer)
        MyBase.New()
        ReportType = 0
        If Len(pIO_ID) > 0 Then
            IO_ID = pIO_ID
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreview1.NavigationBar.Visible = False
    End Sub

    Public Sub New(ByVal pIO_ID As Integer, ByVal pType As Integer)
        MyBase.New()
        ReportType = pType
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
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OGBDeclarationWorkCompletionRptForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.C1Report2 = New C1.C1Report.C1Report
        Me.Panel1.SuspendLayout()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 524)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 55)
        Me.Panel1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 11)
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 451)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(797, 524)
        Me.C1PrintPreviewControl1.TabIndex = 50
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
        'OGBDeclarationWorkCompletionRptForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(797, 579)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OGBDeclarationWorkCompletionRptForm"
        Me.Text = "Notification Of LV Board Installations"
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public IO_ID As Integer

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub LVBDeclarationWorkCompletionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub

    Private Sub OGBDeclarationWorkCompletionRptForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated



    End Sub

    Private Sub LoadReport()
        Dim dsHeaderLoad As DataSet
        Dim NewFieldName As String
        Dim ItemIndex As Integer
        Dim FieldDesc As String
        Dim FieldQty As Integer
        Dim FieldSerialNo As String

        With New BusinessRules.OGBBusRules.OGBBusLogic
            Dim ds As DataSet
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            NewFieldName = ""
            ItemIndex = 0
            FieldDesc = ""
            FieldQty = 0
            FieldSerialNo = ""

            If .GetDWCReport(ds, IO_ID) Then
                If ReportType = 0 Then
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        'C1Report1.Load(path & "OGBDeclarationWorkCompletionReport.xml", "OGB Declaration of Work Completion")
                        If False Then 'ds.Tables(0).Rows(0)("OGB_Installed") = 0 And ds.Tables(0).Rows(0)("OGB_OT") > 0 Then
                            'C1Report2.Load(path & "OGBDeclarationWorkCompletionReport_OT.xml", "OGB Declaration of Work Completion")
                            'NewFieldName = AddDetailsLineItem(NewFieldName, 3, "ZZZ", "10")
                            'NewFieldName = AddDetailsLineItem(NewFieldName, 4, "A", "20")
                            'NewFieldName = AddDetailsLineItem(NewFieldName, 5, "B", "30")

                            C1Report2.Load(path & "OGBDeclarationWorkCompletionReport_OT.xml", "OGB Declaration of Work Completion")

                            'C1Report2.Sections("Group 0 Header").Visible = False


                            FieldDesc = "AAAA"
                            FieldQty = "10"
                            FieldSerialNo = ""
                            ItemIndex = ItemIndex + 1
                            NewFieldName = AddDetailsLineItem(NewFieldName, ItemIndex, FieldDesc, FieldQty, FieldSerialNo)

                            FieldDesc = "bbb"
                            FieldQty = "10"
                            FieldSerialNo = ""
                            ItemIndex = ItemIndex + 1
                            NewFieldName = AddDetailsLineItem(NewFieldName, ItemIndex, FieldDesc, FieldQty, FieldSerialNo)

                        Else
                            C1Report2.Load(path & "OGBDeclarationWorkCompletionReport.xml", "OGB Declaration of Work Completion")

                            'C1Report2.Sections("Group 0 Header").Visible = False
                            NewFieldName = ""

                           
                            If ds.Tables(0).Rows(0)("OGB_Installed") > 0 Then
                                'OVERGROUND BOX
                                FieldDesc = "OVERGROUND BOX, " & ds.Tables(0).Rows(0)("Redo_Text")
                                If ds.Tables(0).Rows(0)("OGB_Surveyed") > 0 Then
                                    FieldDesc = FieldDesc & " INCLUDE SURVEY"
                                End If

                                FieldQty = ds.Tables(0).Rows(0)("OGB_Installed")
                                If IsDBNull(ds.Tables(0).Rows(0)("Serial_No")) = False Then
                                    FieldSerialNo = ds.Tables(0).Rows(0)("Serial_No")
                                Else
                                    FieldSerialNo = " "
                                End If

                                ItemIndex = ItemIndex + 1
                                NewFieldName = AddDetailsLineItem(NewFieldName, ItemIndex, FieldDesc, FieldQty, FieldSerialNo)

                            End If

                            If ds.Tables(0).Rows(0)("OGB_OT") > 0 Then
                                'C1Report2.Fields("OT1").Visible = True
                                'C1Report2.Fields("OT2").Visible = True
                                'C1Report2.Fields("OT3").Visible = True

                                FieldDesc = "OVERGROUND BOX, 5 WAY OVERTIME WORK"
                                FieldQty = ds.Tables(0).Rows(0)("OGB_OT")
                                ItemIndex = ItemIndex + 1
                                NewFieldName = AddDetailsLineItem(NewFieldName, ItemIndex, FieldDesc, FieldQty)


                                'Dim PreviousFieldName As String = "OT2"
                                'Dim FieldGapHeight As Integer = 200
                                'Dim AddedFieldIndex As Integer = 1
                                'Dim AddedFieldName As String = "OGBReportF" & AddedFieldIndex
                                'Dim NextFieldTop As Integer = C1Report2.Fields(PreviousFieldName).Top + C1Report2.Fields(PreviousFieldName).Height + FieldGapHeight

                                'C1Report2.Sections("Detail").Fields.Add(AddedFieldName, "", 735, _
                                '                                        NextFieldTop, 4155, _
                                '                                        C1Report2.Fields(PreviousFieldName).Height)


                                'C1Report2.Fields(AddedFieldName).CanGrow = True
                                'C1Report2.Fields(AddedFieldName).Value = "ZZZZZZ"
                                'C1Report2.Fields("Line33").Height = C1Report2.Fields("Line33").Height + C1Report2.Fields(AddedFieldName).Height + FieldGapHeight
                                'C1Report2.Fields("Line34").Height = C1Report2.Fields("Line34").Height + C1Report2.Fields(AddedFieldName).Height + FieldGapHeight
                                'C1Report2.Fields("Line35").Height = C1Report2.Fields("Line35").Height + C1Report2.Fields(AddedFieldName).Height + FieldGapHeight
                                'C1Report2.Fields("Line21").Height = C1Report2.Fields("Line21").Height + C1Report2.Fields(AddedFieldName).Height + FieldGapHeight
                                'C1Report2.Fields("Line16").Height = C1Report2.Fields("Line16").Height + C1Report2.Fields(AddedFieldName).Height + FieldGapHeight
                                'C1Report2.Fields("Line39").Top = C1Report2.Fields("Line16").Height


                            End If

                            If ds.Tables(0).Rows(0)("OGB_630ADin") > 0 Then
                                'C1Report2.Fields("OT1").Visible = True
                                'C1Report2.Fields("OT2").Visible = True
                                'C1Report2.Fields("OT3").Visible = True

                                FieldDesc = "REPLACEMENT OF 630A DIN UNIT (OGB)"
                                FieldQty = ds.Tables(0).Rows(0)("OGB_630ADin")
                                ItemIndex = ItemIndex + 1
                                NewFieldName = AddDetailsLineItem(NewFieldName, ItemIndex, FieldDesc, FieldQty)
                            End If
                        End If

                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        C1Report2.Fields("Field14").Subreport.DataSource.Recordset = ds.Tables(0)
                        C1PrintPreviewControl1.Document = C1Report2.Document
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try
                ElseIf ReportType = 1 Then
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        'C1Report1.Load(path & "OGBDeclarationWorkCompletionReport.xml", "OGB Declaration of Work Completion")
                        C1Report2.Load(path & "OGBInstallationchecklist.xml", "OGB Installation Checklist")
                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        C1PrintPreviewControl1.Document = C1Report2.Document
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try

                End If
            End If
        End With
    End Sub

    Function AddDetailsLineItem(ByVal PreviousFieldName As String, ByVal IndexNo As Integer, ByVal Description As String, ByVal Qty As String, Optional ByVal SerialNo As String = " ") As String

        'Dim PreviousFieldName As String = "OT2"


        Dim PreviousFieldHeight As Integer = 0
        Dim PreviousFieldTop As Integer = 0
        Dim AddedFieldName As String

        If PreviousFieldName <> "" And PreviousFieldName <> Nothing Then
            PreviousFieldTop = C1Report2.Fields(PreviousFieldName).Top
            PreviousFieldHeight = C1Report2.Fields(PreviousFieldName).Height
        End If


        Dim FieldGapHeight As Integer = 180
        Dim AddedFieldIndex As Integer = IndexNo

        Dim NextFieldTop As Integer = PreviousFieldTop + PreviousFieldHeight + FieldGapHeight

        'Index no.
        AddedFieldName = "IndexNo" & AddedFieldIndex
        C1Report2.Sections("Detail").Fields.Add(AddedFieldName, "", 150, _
                                                NextFieldTop, 435, _
                                                PreviousFieldHeight)
        C1Report2.Fields(AddedFieldName).CanGrow = True
        C1Report2.Fields(AddedFieldName).Align = C1.C1Report.FieldAlignEnum.CenterTop
        C1Report2.Fields(AddedFieldName).Value = IndexNo.ToString


        'Qty
        AddedFieldName = "Qty" & AddedFieldIndex
        C1Report2.Sections("Detail").Fields.Add(AddedFieldName, "", 5155, _
                                                NextFieldTop, 960, _
                                                PreviousFieldHeight)
        C1Report2.Fields(AddedFieldName).CanGrow = True
        C1Report2.Fields(AddedFieldName).Align = C1.C1Report.FieldAlignEnum.CenterTop
        C1Report2.Fields(AddedFieldName).Value = Qty

        'Serial no
        AddedFieldName = "SerialNo" & AddedFieldIndex
        C1Report2.Sections("Detail").Fields.Add(AddedFieldName, "", 6225, _
                                                NextFieldTop, 1185, _
                                                PreviousFieldHeight)
        C1Report2.Fields(AddedFieldName).CanGrow = True
        C1Report2.Fields(AddedFieldName).Align = C1.C1Report.FieldAlignEnum.CenterTop
        C1Report2.Fields(AddedFieldName).Value = SerialNo

        'Description
        AddedFieldName = "Desc" & AddedFieldIndex
        C1Report2.Sections("Detail").Fields.Add(AddedFieldName, "", 735, _
                                                NextFieldTop, 4155, _
                                                PreviousFieldHeight)
        C1Report2.Fields(AddedFieldName).CanGrow = True
        C1Report2.Fields(AddedFieldName).Align = C1.C1Report.FieldAlignEnum.LeftTop

        C1Report2.Fields(AddedFieldName).Value = Description

        'C1Report2.Render()

        
        C1Report2.Fields("Line33").Height = C1Report2.Fields("Line33").Height + PreviousFieldHeight + FieldGapHeight + FieldGapHeight
        C1Report2.Fields("Line34").Height = C1Report2.Fields("Line34").Height + PreviousFieldHeight + FieldGapHeight + FieldGapHeight
        C1Report2.Fields("Line35").Height = C1Report2.Fields("Line35").Height + PreviousFieldHeight + FieldGapHeight + FieldGapHeight
        C1Report2.Fields("Line21").Height = C1Report2.Fields("Line21").Height + PreviousFieldHeight + FieldGapHeight + FieldGapHeight
        C1Report2.Fields("Line16").Height = C1Report2.Fields("Line16").Height + PreviousFieldHeight + FieldGapHeight + FieldGapHeight
        C1Report2.Fields("Line39").Top = C1Report2.Fields("Line16").Height

        'C1Report2.Render()

        Return AddedFieldName

    End Function

End Class
