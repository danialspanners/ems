Public Class QAInspectionReport
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

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
    Friend WithEvents POListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents QAListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.POListGrp = New System.Windows.Forms.GroupBox
        Me.ToDate = New DevExpress.XtraEditors.DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.FromDate = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.QAListGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.POListGrp.SuspendLayout()
        CType(Me.ToDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POListGrp
        '
        Me.POListGrp.Controls.Add(Me.ToDate)
        Me.POListGrp.Controls.Add(Me.Label1)
        Me.POListGrp.Controls.Add(Me.FromDate)
        Me.POListGrp.Controls.Add(Me.Label3)
        Me.POListGrp.Controls.Add(Me.btnRefresh)
        Me.POListGrp.Controls.Add(Me.PrintPOBtn)
        Me.POListGrp.Controls.Add(Me.CloseBtn)
        Me.POListGrp.Controls.Add(Me.QAListGrid)
        Me.POListGrp.Location = New System.Drawing.Point(8, 8)
        Me.POListGrp.Name = "POListGrp"
        Me.POListGrp.Size = New System.Drawing.Size(648, 408)
        Me.POListGrp.TabIndex = 4
        Me.POListGrp.TabStop = False
        Me.POListGrp.Text = "Item List"
        '
        'ToDate
        '
        Me.ToDate.DateTime = New Date(CType(0, Long))
        Me.ToDate.Location = New System.Drawing.Point(320, 16)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ToDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ToDate.Size = New System.Drawing.Size(104, 19)
        Me.ToDate.TabIndex = 166
        Me.ToDate.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "To :"
        Me.Label1.Visible = False
        '
        'FromDate
        '
        Me.FromDate.DateTime = New Date(CType(0, Long))
        Me.FromDate.Location = New System.Drawing.Point(88, 16)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.FromDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.FromDate.Size = New System.Drawing.Size(104, 19)
        Me.FromDate.TabIndex = 164
        Me.FromDate.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "From :"
        Me.Label3.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(424, 368)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Refresh"
        '
        'PrintPOBtn
        '
        Me.PrintPOBtn.AutoSize = False
        Me.PrintPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPOBtn.Image = Nothing
        Me.PrintPOBtn.Location = New System.Drawing.Point(504, 368)
        Me.PrintPOBtn.Name = "PrintPOBtn"
        Me.PrintPOBtn.Size = New System.Drawing.Size(64, 32)
        Me.PrintPOBtn.TabIndex = 24
        Me.PrintPOBtn.Text = "Print"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(576, 368)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'QAListGrid
        '
        Me.QAListGrid.Location = New System.Drawing.Point(8, 40)
        Me.QAListGrid.MainView = Me.GridView1
        Me.QAListGrid.Name = "QAListGrid"
        Me.QAListGrid.Size = New System.Drawing.Size(632, 320)
        Me.QAListGrid.TabIndex = 2
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Work Order No"
        Me.GridColumn1.FieldName = "wo_no"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Total Qty"
        Me.GridColumn2.FieldName = "totalqty"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Inspected Qty"
        Me.GridColumn3.FieldName = "inspectedqty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 90
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Out'g Ins. Qty"
        Me.GridColumn4.FieldName = "OutstandingInspectedqty"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Box"
        Me.GridColumn5.FieldName = "Box"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 100
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Compl. Date"
        Me.GridColumn6.FieldName = "Compl_Date"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Exp. Compl. Date"
        Me.GridColumn7.FieldName = "expected_compl_date"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 95
        '
        'QAInspectionReport
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(664, 421)
        Me.Controls.Add(Me.POListGrp)
        Me.Name = "QAInspectionReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QA Inspection Report"
        Me.POListGrp.ResumeLayout(False)
        CType(Me.ToDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim ds As DataSet
        With New BusinessRules.QABusRules.QABusLogic
            If .GetQAInspectionReport(ds) Then
                'If .GetQAInspectionReport(ds, ChangeDateFormat(FromDate.Text), ChangeDateFormat(ToDate.Text)) Then
                QAListGrid.DataSource = ds.Tables(0).DefaultView
                QAListGrid.DefaultView.PopulateColumns()

                GridView1.BestFitColumns()
            End If
        End With

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
        End If
    End Sub

    'Change date format
    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then

            If pInputDate.ToString <> "" Then
                pDate = Date.Parse(pInputDate)
                tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
            End If

        End If

        Return tempsDate

    End Function

    Private Sub PrintPOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPOBtn.Click

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New OutstandingQAInspectionReportForm
        page = New Crownwood.Magic.Controls.TabPage("Print QA Inspected Report", controlToAdd, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub QAInspectionReport_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
