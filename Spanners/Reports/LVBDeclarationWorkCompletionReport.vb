Imports System
Imports System.IO
Imports System.Collections

Public Class LVBDeclarationWorkCompletionRptForm
    Inherits System.Windows.Forms.Form

    Public ReportType As Integer

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pIO_ID As Integer)
        MyBase.New()

        If Len(pIO_ID) > 0 Then
            IO_ID = pIO_ID
        End If

        ReportType = 0

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreview1.NavigationBar.Visible = False
    End Sub

    Public Sub New(ByVal pIO_ID As Integer, ByVal pType As Integer)
        MyBase.New()

        If Len(pIO_ID) > 0 Then
            IO_ID = pIO_ID
        End If

        ReportType = pType

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LVBDeclarationWorkCompletionRptForm))
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.C1Report2 = New C1.C1Report.C1Report
        Me.Panel1.SuspendLayout()
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
        Me.CloseBtn.Location = New System.Drawing.Point(12, 7)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(37, 17)
        Me.CloseBtn.TabIndex = 48
        Me.CloseBtn.Text = "&Close"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 496)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 45)
        Me.Panel1.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(576, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 45)
        Me.Panel2.TabIndex = 0
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 423)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(776, 496)
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
        'LVBDeclarationWorkCompletionRptForm
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(776, 541)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LVBDeclarationWorkCompletionRptForm"
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

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
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
            Dim ds2 As DataSet
            Dim ds3 As DataSet
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            Dim sSub As String = "Field3"
            Dim SQLStr, SQLStrT
            Dim LVBDWCCreated
            If .GetDWCReport(ds, IO_ID) Then

                Dim ConnectionString

                With New Common.CommonConn.Config
                    ConnectionString = .ConnectionString
                End With


                Try
                    'Drop Tmp Table if any before create..
                    SQLStrT = "Drop table LVBDWC"
                    With New DataAccess.DAccess.Access
                        If .GetDataSet(ds2, SQLStrT, True) Then
                        End If
                    End With
                    LVBDWCCreated = False
                Catch ex As Exception

                Finally
                End Try

                If Me.ReportType = 0 Then

                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")

                        C1Report2.Load(path & "LVBDeclarationWorkCompletionReport.xml", "LVB Declaration of Work Completion")

                        C1Report2.Fields(sSub).Subreport.DataSource.ConnectionString = ConnectionString

                        'Create Tmp Table
                        LVBDWCCreated = False
                        SQLStrT = "Create Table LVBDWC([indexno][numeric],[Description][varchar](100),[Description2][varchar](100),[Qty][numeric],[Serial][varchar](50));"
                        With New DataAccess.DAccess.Access
                            If .GetDataSet(ds2, SQLStrT) Then
                                LVBDWCCreated = True
                            End If
                        End With

                        SQLStr = "SELECT sum(b.Install) as Install,c.Description, COUNT(b.Box_Type_Id) AS Qty, d.Contract_No, "
                        SQLStr = SQLStr & " a.IO_No, a.LVB_Location, b.Serial_No, e.Officer_Name, "
                        SQLStr = SQLStr & " a.Completion_Date, a.Extend_Completion_Date, a.Installation_Date, a.Inspection_Date, a.Remarks "
                        SQLStr = SQLStr & " ,f.Section_Code "
                        SQLStr = SQLStr & " FROM LVBFiler a LEFT OUTER JOIN "
                        SQLStr = SQLStr & " LVBLine b ON a.IO_Id = b.IO_Id LEFT OUTER JOIN "
                        SQLStr = SQLStr & " LVBBox c ON b.Box_Type_Id = c.Box_Type_Id LEFT OUTER JOIN "
                        SQLStr = SQLStr & " LVBContract d ON a.Contract_Id = d.Contract_Id LEFT OUTER JOIN "
                        SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
                        SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
                        SQLStr = SQLStr & " WHERE a.IO_Id = " & IO_ID & "GROUP BY b.Box_Type_Id, "
                        SQLStr = SQLStr & " c.Description, d.Contract_No, a.IO_No, a.LVB_Location, b.Serial_No, "
                        SQLStr = SQLStr & " e.Officer_Name, a.Completion_Date, a.Extend_Completion_Date, a.Installation_Date, a.Inspection_Date,a.Remarks "
                        SQLStr = SQLStr & " ,f.Section_Code "

                        Dim rw As DataRow

                        With New DataAccess.DAccess.Access
                            If .GetDataSet(ds2, SQLStr) Then
                                For Each rw In ds2.Tables(0).Rows
                                    If rw("Install") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,qty,serial)"
                                        SQLStrT = SQLStrT & "values (1,'" & Replace(rw("Description"), ",", ",") & "'," & rw("Install") & ",'" & rw("Serial_No") & "');"
                                        If .GetDataSet(ds3, SQLStrT) Then

                                        End If
                                    End If
                                Next
                            End If
                        End With

                        SQLStr = "SELECT   MAX(LVBLine.Box_Type_Id) AS ID, MAX(LVBBox.Description) as Description2 ,SUM(Bus_Section) as Bus_Section, SUM(LTB_Label) as LTB_Label, "
                        SQLStr = SQLStr & " SUM(Offshore) as Offshore, SUM(Strip_Label) as Strip_Label, SUM(OT) as OT, SUM(SynConn) as SynConn, "
                        SQLStr = SQLStr & " SUM(OT2) as OT2, SUM(UsedInstall) as UsedInstall, "
                        SQLStr = SQLStr & " SUM(Insulation_Cover) as Insulation_Cover, "
                        SQLStr = SQLStr & " SUM(OutLink500) as OutLink500, SUM(OutLink100) as OutLink100, SUM(SupInsOutLink1000) as SupInsOutLink1000, SUM(SupIns630Unit) as SupIns630Unit, SUM(RepoOutlink) as RepoOutlink, SUM(CableLug1Hole) as CableLug1Hole, SUM(CableLug2Hole) as CableLug2Hole "
                        SQLStr = SQLStr & " FROM LVBLine "
                        SQLStr = SQLStr & " INNER JOIN LVBBox ON LVBLine.Box_Type_Id = LVBBox.Box_Type_Id"
                        SQLStr = SQLStr & " WHERE IO_Id = " & IO_ID & " Group by  LVBLine.Box_Type_Id"

                        Dim indexno As Integer
                        indexno = 1
                        Dim LTBName As String
                        LTBName = ""

                        With New DataAccess.DAccess.Access
                            If .GetDataSet(ds2, SQLStr) Then

                                For i = 0 To ds2.Tables(0).Rows.Count - 1

                                    If ds2.Tables(0).Rows(i)("ID") = 1 Then
                                        LTBName = ", L1600A"
                                    ElseIf ds2.Tables(0).Rows(i)("ID") = 2 Then
                                        LTBName = ", 1600A"
                                    ElseIf ds2.Tables(0).Rows(i)("ID") = 3 Then
                                        LTBName = ", 2400A"
                                    End If

                                    If ds2.Tables(0).Rows(i)("Bus_Section") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'Bus Section" & LTBName & "'," & ds2.Tables(0).Rows(i)("Bus_Section") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("LTB_Label") > 0 Then
                                        'LTB_Label = ds.Tables(0).Rows(i)("LTB_Label")
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'LABELLING FOR LTB','" & LTBName & "'," & ds2.Tables(0).Rows(i)("LTB_Label") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("Strip_Label") > 0 Then
                                        '    Strip_Label = ds.Tables(0).Rows(i)("Strip_Label")
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'STRIP LABEL REMOTE TO','LTB" & LTBName & "'," & ds2.Tables(0).Rows(i)("Strip_Label") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("OT") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'OT" & LTBName & "'," & ds2.Tables(0).Rows(i)("OT") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("OT2") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'OT (Variation)'," & ds2.Tables(0).Rows(i)("OT2") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("Offshore") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'OFFSHORE" & LTBName & "'," & ds2.Tables(0).Rows(i)("Offshore") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("OutLink500") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'OUTGOING LINK UNIT','(FOR 500MM2 CABLE)" & LTBName & "'," & ds2.Tables(0).Rows(i)("OutLink500") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                            indexno = indexno + 1
                                        End If
                                    End If

                                    If ds2.Tables(0).Rows(i)("OutLink100") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'OUTGOING LINK UNIT','(FOR 1000MM2 CABLE)" & LTBName & "'," & ds2.Tables(0).Rows(i)("OutLink100") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                            indexno = indexno + 1
                                        End If
                                    End If

                                    'SupInsOutLink1000
                                    If ds2.Tables(0).Rows(i)("SupInsOutLink1000") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'SUP & INS OUTGOING','LINK @ SITE" & LTBName & "'," & ds2.Tables(0).Rows(i)("SupInsOutLink1000") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                            indexno = indexno + 1
                                        End If
                                    End If

                                    'SupIns630Unit
                                    If ds2.Tables(0).Rows(i)("SupIns630Unit") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'SUP & INS 630A DIN','DIST UNIT" & LTBName & "'," & ds2.Tables(0).Rows(i)("SupIns630Unit") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                            indexno = indexno + 1
                                        End If
                                    End If

                                    'Used LTB installation
                                    If ds2.Tables(0).Rows(i)("UsedInstall") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'Used LTB Instllation','" & LTBName & "'," & ds2.Tables(0).Rows(i)("UsedInstall") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                            indexno = indexno + 1
                                        End If
                                    End If

                                    'Insulation Cover
                                    If ds2.Tables(0).Rows(i)("Insulation_Cover") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'INSULATION COVER, FOR OUTGOING LINK','" & LTBName & "'," & ds2.Tables(0).Rows(i)("Insulation_Cover") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                            indexno = indexno + 1
                                        End If
                                    End If

                                    If ds2.Tables(0).Rows(i)("RepoOutlink") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'REPOSITION OF OUTGOING','LINK UNIT" & LTBName & "'," & ds2.Tables(0).Rows(i)("RepoOutlink") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                            indexno = indexno + 1
                                        End If
                                    End If

                                    If ds2.Tables(0).Rows(i)("SynConn") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'SYNCHRONISING','CONNECTOR" & LTBName & "'," & ds2.Tables(0).Rows(i)("SynConn") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("CableLug1Hole") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'CABLE LUG 1-HOLE','" & LTBName & "'," & ds2.Tables(0).Rows(i)("CableLug1Hole") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                    If ds2.Tables(0).Rows(i)("CableLug2Hole") > 0 Then
                                        SQLStrT = "Insert into LVBDWC (indexno,description,description2,qty,serial)"
                                        SQLStrT = SQLStrT & "values (" & indexno & ",'CABLE LUG 2-HOLES','" & LTBName & "'," & ds2.Tables(0).Rows(i)("CableLug2Hole") & ",'');"
                                        If .GetDataSet(ds3, SQLStrT) Then
                                        End If
                                        indexno = indexno + 1
                                    End If

                                Next

                            End If

                        End With

                        SQLStrT = "Select * from LVBDWC"
                        C1Report2.Fields(sSub).Subreport.DataSource.RecordSource = SQLStrT

                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        C1PrintPreviewControl1.Document = C1Report2.Document
                        SQLStrT = "Drop table LVBDWC"
                        LVBDWCCreated = False
                        With New DataAccess.DAccess.Access
                            If .GetDataSet(ds2, SQLStrT, True) Then

                            End If
                        End With

                    Catch ex As Exception
                        If LVBDWCCreated = True Then
                            SQLStrT = "Drop table LVBDWC"
                            LVBDWCCreated = False

                            With New DataAccess.DAccess.Access
                                If .GetDataSet(ds2, SQLStrT, True) Then
                                End If
                            End With
                        End If

                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)

                    End Try

                ElseIf ReportType = 1 Then 'New
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        'C1Report1.Load(path & "OGBDeclarationWorkCompletionReport.xml", "OGB Declaration of Work Completion")
                        C1Report2.Load(path & "LVBInstallationchecklist_new.xml", "LVB Installation Checklist")
                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        C1PrintPreviewControl1.Document = C1Report2.Document
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try
                ElseIf ReportType = 2 Then 'old
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        'C1Report1.Load(path & "OGBDeclarationWorkCompletionReport.xml", "OGB Declaration of Work Completion")
                        C1Report2.Load(path & "LVBInstallationchecklist.xml", "LVB Installation Checklist")
                        C1Report2.DataSource.Recordset = ds.Tables(0)
                        C1PrintPreviewControl1.Document = C1Report2.Document
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        'Directory.SetCurrentDirectory(tmpCurDir)
                    End Try
                ElseIf ReportType = 3 Then 'Re-used
                    Try
                        'Directory.SetCurrentDirectory("..\Reports\")
                        'C1Report1.Load(path & "OGBDeclarationWorkCompletionReport.xml", "OGB Declaration of Work Completion")
                        C1Report2.Load(path & "reused_LVBinstallationchecklist.xml", "LVB Installation Checklist")
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
End Class
