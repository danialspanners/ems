Imports System
Imports System.Math
Imports System.IO
Imports System.Collections

Public Class QuotationReportForm
    Inherits System.Windows.Forms.Form

    Public Quotation_ID As Integer
    Public PrintGST As Boolean
    Public HideTotal As Boolean
    Public CustomItemLabel As String
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Public QuotationTitle As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pQuotation_ID As Integer, Optional ByVal pPrintGST As Boolean = True)
        MyBase.New()

        Quotation_ID = pQuotation_ID
        PrintGST = pPrintGST

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'C1PrintPreview1.NavigationBar.Visible = False

    End Sub

    Public Sub New(ByVal pQuotation_ID As Integer, ByVal pPrintOptions As BusinessRules.SaleBusRules.SaleBusLogic.PrintOptions)
        MyBase.New()

        HideTotal = False
        PrintGST = True

        Quotation_ID = pQuotation_ID
        PrintGST = pPrintOptions.PrintGST
        HideTotal = pPrintOptions.HideTotal
        CustomItemLabel = pPrintOptions.CustomLabel

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuotationReportForm))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.C1Report1 = New C1.C1Report.C1Report
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 261)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(684, 66)
        Me.Panel3.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(546, 0)
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
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 188)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(684, 261)
        Me.C1PrintPreviewControl1.TabIndex = 6
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
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'QuotationReportForm
        '
        Me.ClientSize = New System.Drawing.Size(684, 327)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "QuotationReportForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub QuotationReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With New BusinessRules.SaleBusRules.SaleBusLogic
            Dim dsTmp As DataSet
            Dim Special_ID As Integer
            Dim TotalAmt As Decimal
            Dim TotalAmtintxt As String

            .Quotation_ID = Quotation_ID
            If .IsRevisedQuote(dsTmp) Then
                QuotationTitle = " REVISED QUOTATION "
            Else
                QuotationTitle = " QUOTATION "
            End If

            If .GetQuotationHeader(dsTmp, Quotation_ID) Then
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    If Not IsDBNull(dsTmp.Tables(0).Rows(0)("Special_ID")) Then
                        Special_ID = dsTmp.Tables(0).Rows(0)("Special_ID")
                    Else
                        Special_ID = 1
                    End If
                End If
            End If

            Dim ds As DataSet
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            Dim qlds As DataSet
            Dim noLine As Boolean
            Dim ConcreteBase As Boolean

            noLine = False
            ConcreteBase = False
            If .GetQuotationLine(qlds) Then
                If qlds.Tables(0).Rows.Count = 0 Then
                    noLine = True
                End If
            End If

            If .GetQuotationRpt(ds, Quotation_ID, QuotationTitle) Then
                Try
                    Dim a As MainForm = Me.ParentForm
                    a.StatusBarPanel1.Text = Directory.GetCurrentDirectory()
                    'Directory.SetCurrentDirectory("..\Reports\")
                    Select Case (Special_ID)
                        Case 1
                            'MsgBox("Quotation.xml")
                            If (dsTmp.Tables(0).Rows(0)("Service_Type") = 2) Then
                                C1Report1.Load(path & "QuotationInstall.xml", "Quotation")
                            Else
                                C1Report1.Load(path & "Quotation.xml", "Quotation")
                            End If
                        Case 2
                            'MsgBox("Quotationforboxsurvey.xml")
                            C1Report1.Load(path & "QuotationForBoxSurvey.xml", "Quotation For Box Survey")
                        Case 3
                            'MsgBox("Quotationforcablesurvey.xml")
                            C1Report1.Load(path & "QuotationForCableSurvey.xml", "Quotation For Cable Survey")
                        Case 4
                            'MsgBox("Quotationforswitchboard.xml")
                            C1Report1.Load(path & "QuotationForSwitchboard.xml", "Quotation For Switchboard")
                    End Select
                    C1Report1.DataSource.Recordset = ds.Tables(0)
                    'C1Report1.Fields("DescriptionCtl7").Text = "XXX"
                    'If (dsTmp.Tables(0).Rows(0)("Service_Type") = 2) Then
                    ' C1Report1.Fields("installtxt1").Visible = True
                    ' C1Report1.Fields("installtxt2").Visible = True
                    ' C1Report1.Fields("installtxt3").Visible = True
                    ' C1Report1.Fields("installtxt4").Visible = True
                    ' C1Report1.Fields("installtxt5").Visible = True
                    ' C1Report1.Fields("installtxt6").Visible = True
                    'End If
                    If noLine = True Then
                        C1Report1.Fields("FItem").Visible = False
                        C1Report1.Fields("Linenumber").Visible = False
                        C1Report1.Fields("FBox").Visible = False
                        C1Report1.Fields("FQty").Visible = False
                        C1Report1.Fields("FUnitPrice").Text = " "
                        C1Report1.Fields("FAmount").Visible = False
                        C1Report1.Fields("FTotalAmt").Visible = False
                        C1Report1.Fields("FTotalAmtDesc").Visible = False
                    End If


                    TotalAmt = Convert.ToDecimal(C1Report1.Fields("Totalamt").Value())
                    
                    TotalAmtintxt = Me.DollarToString(TotalAmt)
                    'TotalAmtintxt = TotalAmtintxt.ToUpper()

                    If HideTotal = True Then
                        C1Report1.Fields("FTotalAmtDesc").Visible = False
                        C1Report1.Fields("FTotalAmt").Visible = False
                        C1Report1.Fields("Total_Cost_Text").Visible = False
                    End If


                    If PrintGST = False Then
                        C1Report1.Fields("SubjectToGST").Visible = False
                    End If

                    If CustomItemLabel <> "" Then
                        C1Report1.Fields("FItem").Text = CustomItemLabel
                    End If

                    C1Report1.Fields("Total_Cost_Text").Text = "" & TotalAmtintxt.ToString()

                    C1PrintPreviewControl1.Document = C1Report1.Document
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    'Directory.SetCurrentDirectory(tmpCurDir)
                End Try
            End If

        End With
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub QuotationReportForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim a As MainForm = Me.ParentForm
        a.StatusBarPanel1.Text = ""
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Function DollarToString(ByVal nAmount As Decimal) As _
        String

        Dim nDollar As Decimal
        Dim nCent As Decimal

        nDollar = Int(nAmount)
        nCent = (Abs(nAmount) * 100) Mod 100

        If Abs(nDollar) <> 1 And nDollar <> 0 Then
            'DollarToString = DollarToString & "s "
        End If

        If nDollar <> 0 Then
            DollarToString = DollarToString & NumToString(nDollar)
        End If


        If nCent > 0 Then
            If nDollar > 0 Then
                DollarToString = DollarToString & " and Cent"
            End If

            If Abs(nCent) <> 1 And nCent <> 0 Then
                DollarToString = DollarToString & "s"
            End If

            DollarToString = DollarToString & NumToString(nCent)
        End If


        DollarToString = DollarToString & " Only"
        'DollarToString = UCase(DollarToString)

    End Function

    Public Function NumToString(ByVal nNumber As Double) As String

        Dim bNegative As Boolean
        Dim bHundred As Boolean

        If nNumber < 0 Then
            bNegative = True
        End If

        nNumber = Abs(Int(nNumber))

        If nNumber < 1000 Then
            If nNumber \ 100 > 0 Then
                NumToString = NumToString & _
                     NumToString(nNumber \ 100) & " hundred"
                bHundred = True
            End If
            nNumber = nNumber - ((nNumber \ 100) * 100)
            Dim bNoFirstDigit As Boolean
            bNoFirstDigit = False
            Select Case nNumber \ 10
                Case 0
                    Select Case nNumber Mod 10
                        Case 0
                            If Not bHundred Then
                                NumToString = NumToString & " Zero"
                            End If
                        Case 1 : NumToString = NumToString & " One"
                        Case 2 : NumToString = NumToString & " Two"
                        Case 3 : NumToString = NumToString & " Three"
                        Case 4 : NumToString = NumToString & " Four"
                        Case 5 : NumToString = NumToString & " Five"
                        Case 6 : NumToString = NumToString & " Six"
                        Case 7 : NumToString = NumToString & " Seven"
                        Case 8 : NumToString = NumToString & " Eight"
                        Case 9 : NumToString = NumToString & " Nine"
                    End Select
                    bNoFirstDigit = True
                Case 1
                    Select Case nNumber Mod 10
                        Case 0 : NumToString = NumToString & " Ten"
                        Case 1 : NumToString = NumToString & " Eleven"
                        Case 2 : NumToString = NumToString & " Twelve"
                        Case 3 : NumToString = NumToString & " Thirteen"
                        Case 4 : NumToString = NumToString & " Fourteen"
                        Case 5 : NumToString = NumToString & " Fifteen"
                        Case 6 : NumToString = NumToString & " Sixteen"
                        Case 7 : NumToString = NumToString & " Seventeen"
                        Case 8 : NumToString = NumToString & " Eighteen"
                        Case 9 : NumToString = NumToString & " Nineteen"
                    End Select
                    bNoFirstDigit = True
                Case 2 : NumToString = NumToString & " Twenty"
                Case 3 : NumToString = NumToString & " Thirty"
                Case 4 : NumToString = NumToString & " Forty"
                Case 5 : NumToString = NumToString & " Fifty"
                Case 6 : NumToString = NumToString & " Sixty"
                Case 7 : NumToString = NumToString & " Seventy"
                Case 8 : NumToString = NumToString & " Eighty"
                Case 9 : NumToString = NumToString & " Ninety"
            End Select
            If Not bNoFirstDigit Then
                If nNumber Mod 10 <> 0 Then
                    NumToString = NumToString & " " & _
                                  Mid(NumToString(nNumber Mod 10), 2)
                End If
            End If
        Else
            Dim nTemp As Decimal
            nTemp = 10 ^ 12 'trillion
            Do While nTemp >= 1
                If nNumber >= nTemp Then
                    NumToString = NumToString & _
                                  NumToString(Int(nNumber / nTemp))
                    Select Case Int(Log(nTemp) / Log(10) + 0.5)
                        Case 12 : NumToString = NumToString & " Trillion"
                        Case 9 : NumToString = NumToString & " Billion"
                        Case 6 : NumToString = NumToString & " Million"
                        Case 3 : NumToString = NumToString & " Thousand"
                    End Select

                    nNumber = nNumber - (Int(nNumber / nTemp) * nTemp)
                End If
                nTemp = nTemp / 1000
            Loop
        End If

        If bNegative Then
            NumToString = " Negative" & NumToString
        End If

    End Function
End Class
