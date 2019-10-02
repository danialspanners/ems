Imports System
Imports System.Math
Imports System.IO
Imports System.Collections
Imports Common.CommonConn.Util

Public Class POReportForm
    Inherits System.Windows.Forms.Form

    Private PrintBasic As Boolean
    Private PrintTitle As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pPO_ID As String, ByVal pPrintTitle As Boolean, Optional ByVal pPrintBasic As Boolean = False)
        MyBase.New()

        PO_ID = pPO_ID
        PrintBasic = pPrintBasic
        PrintTitle = pPrintTitle
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents C1PrintPreviewControl2 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POReportForm))
        Me.C1PrintPreviewControl2 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.C1Report2 = New C1.C1Report.C1Report
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.C1PrintPreviewControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl2.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl2.SuspendLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.C1PrintPreviewControl2.PreviewPane.Document = Me.C1Report2
        Me.C1PrintPreviewControl2.PreviewPane.IntegrateExternalTools = True
        '
        '
        '
        Me.C1PrintPreviewControl2.PreviewPane.PrintOptions.CenterPage = False
        Me.C1PrintPreviewControl2.PreviewPane.PrintOptions.PageScaling = C1.C1Preview.PageScalingEnum.None
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
        Me.C1PrintPreviewControl2.PreviewThumbnailView.Size = New System.Drawing.Size(165, 278)
        Me.C1PrintPreviewControl2.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl2.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl2.Size = New System.Drawing.Size(735, 351)
        Me.C1PrintPreviewControl2.TabIndex = 0
        Me.C1PrintPreviewControl2.Text = "C1PrintPreviewControl2"
        '
        'C1Report2
        '
        Me.C1Report2.ReportDefinition = resources.GetString("C1Report2.ReportDefinition")
        Me.C1Report2.ReportName = "C1Report2"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 351)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(735, 66)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(597, 0)
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
        'POReportForm
        '
        Me.ClientSize = New System.Drawing.Size(735, 417)
        Me.Controls.Add(Me.C1PrintPreviewControl2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "POReportForm"
        CType(Me.C1PrintPreviewControl2.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl2.ResumeLayout(False)
        Me.C1PrintPreviewControl2.PerformLayout()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public PO_ID As Integer
    Public PRNos As String


#End Region

    Private Sub POReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'C1PrintPreview1.Width = Me.Width - 150
        'C1PrintPreview1.Height = Me.Height - 150
        'C1PrintPreview1.NavigationBar.Visible = False
        'C1PrintPreview1.ToolBar.Buttons.RemoveAt(0)
        'C1PrintPreview1.ToolBar.Buttons.RemoveAt(0)

        Dim TotalAmt As Decimal
        Dim TotalAmtintxt As String
        Dim CurrencyName As String
        Dim DiscountAmt As Decimal
        Dim GST_Amt As Decimal
        Dim x As Integer
        Dim PO_Title As String

        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .Load(PO_ID) Then
                DiscountAmt = .Discount
                GST_Amt = .GST_Flg
            End If
        End With

        With New BusinessRules.POBusRules.POBusLogic

            'get PR Nos associated with this PO
            Dim ds2 As DataSet
            .LoadPR(ds2, PO_ID)
            If ds2.Tables(0).Rows.Count > 0 Then
                For x = 0 To ds2.Tables(0).Rows.Count - 1

                    PRNos = PRNos & ds2.Tables(0).Rows(x)("pr_no") & " "

                Next
            End If

            Dim ds As DataSet
            Dim ReportName As String
            Dim tmpCurDir = Directory.GetCurrentDirectory()
            Dim path As String = Application.StartupPath
            Dim i As Integer = path.IndexOf("\bin")
            If i > -1 Then path = path.Substring(0, i)
            path = path & "\Reports\"

            If .GetPORpt(ds, PO_ID) Then
                Try
                    Directory.SetCurrentDirectory("..\Reports\")
                    If PrintBasic = True Then
                        C1Report2.Load(path & "PO_Basic.xml", "Purchase Order")
                    Else
                        If PrintTitle = True Then

                            ReportName = "PO.xml"

                        Else

                            ReportName = "PO_notitle.xml"

                        End If

                        'Temp
                        'ReportName = "PO_notitle_specialnoor.xml"

                        C1Report2.Load(path & ReportName, "Purchase Order")

                    End If

                    If DiscountAmt > 0 And GST_Amt > 0 Then

                        C1Report2.Groups("GSTDISCOUNT").SectionFooter.Visible = True
                        C1Report2.Groups("GST").SectionFooter.Visible = False
                        C1Report2.Groups("DISCOUNT").SectionFooter.Visible = False
                        C1Report2.Groups("NOGSTDISCOUNT").SectionFooter.Visible = False

                    ElseIf DiscountAmt > 0 Then

                        C1Report2.Groups("GSTDISCOUNT").SectionFooter.Visible = False
                        C1Report2.Groups("GST").SectionFooter.Visible = False
                        C1Report2.Groups("DISCOUNT").SectionFooter.Visible = True
                        C1Report2.Groups("NOGSTDISCOUNT").SectionFooter.Visible = False

                    ElseIf GST_Amt > 0 Then

                        C1Report2.Groups("GSTDISCOUNT").SectionFooter.Visible = False
                        C1Report2.Groups("GST").SectionFooter.Visible = True
                        C1Report2.Groups("DISCOUNT").SectionFooter.Visible = False
                        C1Report2.Groups("NOGSTDISCOUNT").SectionFooter.Visible = False

                    Else

                        C1Report2.Groups("GSTDISCOUNT").SectionFooter.Visible = False
                        C1Report2.Groups("GST").SectionFooter.Visible = False
                        C1Report2.Groups("DISCOUNT").SectionFooter.Visible = False
                        C1Report2.Groups("NOGSTDISCOUNT").SectionFooter.Visible = True

                    End If
                    'C1Report2.C1Document.MeasurementDevice = C1.C1Preview.MeasurementDeviceEnum.Screen
                    'C1Report2.C1Document.CreationDpi = 96
                    C1Report2.DataSource.Recordset = ds.Tables(0)

                    TotalAmt = Convert.ToDecimal(C1Report2.Fields("TotalAmt").Value())
                    CurrencyName = Convert.ToString(C1Report2.Fields("CurrencyName").Value())
                    DiscountAmt = Convert.ToDecimal(C1Report2.Fields("Discount").Value())
                    GST_Amt = Convert.ToDecimal(C1Report2.Fields("GST_Amt").Value())

                    TotalAmtintxt = Me.DollarToString(TotalAmt)
                    TotalAmtintxt = TotalAmtintxt.ToUpper()

                    CurrencyName = CurrencyName.ToUpper()

                    C1Report2.Fields("Totalamtintxt").Text = CurrencyName.ToString() & TotalAmtintxt.ToString()
                    C1Report2.Fields("PRNos").Text = PRNos

                    Dim str2 As String
                    str2 = Convert.ToString(C1Report2.Fields("DiscountPercent").Value())

                    Dim a As Common.CommonConn.Util = New Common.CommonConn.Util
                    str2 = a.DoubleToString(str2, 0)
                    C1Report2.Fields("DiscountPercent_txt").Text = str2


                    'Dim c As Int32 = C1PrintPreviewControl1..PageSettings.PaperSize.Height
                    'Dim d As Int32 = C1PrintPreviewControl1.PageSettings.PaperSize.Width

                    'C1Report1.Document.DefaultPageSettings.PaperSize.Height = 15840
                    'C1Report1.Document.DefaultPageSettings.PaperSize.Width = 12182

                    C1PrintPreviewControl2.Document = C1Report2.Document


                    'C1PrintPreview1.PageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Custom", 8270, 11690)

                    'Dim a As Int32 = C1PrintPreview1.PageSettings.PaperSize.Height
                    'Dim b As Int32 = C1PrintPreview1.PageSettings.PaperSize.Width
                    'C1PrintPreview1.PageSettings.PaperSize. = System.Drawing.Printing.PaperKind.Custom
                    'C1PrintPreview1.PageSettings.PaperSize.Height = 15840
                    'C1PrintPreview1.PageSettings.PaperSize.Width = 12182

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    'Directory.SetCurrentDirectory(tmpCurDir)
                End Try
            End If

        End With

    End Sub
    Public Function DollarToString(ByVal nAmount As Decimal) As _
        String

        Dim nDollar As Decimal
        Dim nCent As Decimal

        nDollar = Int(nAmount)
        nCent = (Abs(nAmount) * 100) Mod 100

        If Abs(nDollar) <> 1 And nDollar <> 0 Then
            DollarToString = DollarToString & "s "
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

    Private Sub C1PrintPreview1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CloseBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click, Button1.Click
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub


    Function IsMoreThan3Dec(ByVal pVal As Decimal) As Boolean
        IsMoreThan3Dec = False

        pVal = pVal * 100
        pVal = pVal - Convert.ToDecimal(Int(pVal))

        If pVal > 0 Then
            IsMoreThan3Dec = True
        End If

    End Function

    Private Sub C1Report2_PrintSection(ByVal sender As System.Object, ByVal e As C1.C1Report.ReportEventArgs) Handles C1Report2.PrintSection
        Dim str As String
        Dim up As Decimal


        up = Convert.ToDecimal(C1Report2.Fields("Unit_Price").Value())

        Dim a As Common.CommonConn.Util = New Common.CommonConn.Util
        str = a.DoubleToString(up.ToString(), 2)
        C1Report2.Fields("D_UnitPrice").Text = Convert.ToString(C1Report2.Fields("CurrencySymbol").Value()) & str

        'check if up is more than 3 decimal place
        If IsMoreThan3Dec(up) = True Then

            str = Convert.ToString(C1Report2.Fields("Unit_Price").Value())
            str = Convert.ToString(CDec(Format(CDec(str), "#.########")))

            C1Report2.Fields("D_UnitPrice").Text = Convert.ToString(C1Report2.Fields("CurrencySymbol").Value()) & str
        Else
            C1Report2.Fields("D_UnitPrice").Text = "[CurrencySymbol] &  FormatNumber(Unit_Price,2)"
        End If

        C1Report2.Fields("PRNos").Text = PRNos

    End Sub
End Class
