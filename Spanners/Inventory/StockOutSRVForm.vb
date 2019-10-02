Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class StockOutSRVForm
    Inherits System.Windows.Forms.Form

    Private gsiSummary As GridSummaryItems

    Public UserID As String = Common.CommonConn.Config.USERID
    Public dataGrid As System.Data.DataTable
    Public Transaction_ID As Integer
    Public FormType As String

    Private AddButtonOldState As Boolean
    Private EditButtonOldState As Boolean
    Private DeleteButtonOldState As Boolean
    Private Button4OldState As Boolean
    Private GridControl1OldState As Boolean

    Private dslist As DataSet
    Private dt As Date
    Private Olddt As Date
    Private TransactDateChangeCheck As Boolean
    Private ReloadSRVComboOnCloseUp As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pFormType As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        AddButton.Enabled = False
        AddMenu.Enabled = False
        DeleteButton.Enabled = False
        DeleteMenu.Enabled = False
        EditButton.Enabled = False
        EditMenu.Enabled = False
        Me.Print2_Button.Enabled = False
        Button4.Enabled = False
        GridControl1.Enabled = False

        TransactDateChangeCheck = False
        ReloadSRVComboOnCloseUp = False

        SetYearCombo()
        Me.LookUpEdit_Year.Visible = True
        Panel1.Height = 42
        If pFormType = "SRV" Then
            Me.SetSRVForm()
            Me.LookUpEdit_Year.Visible = True
        ElseIf pFormType = "PMR" Then
            Me.SetPMRForm()
            Me.LookUpEdit_Year.Visible = True

        ElseIf pFormType = "RTN" Then
            Me.SetReturnInRTNForm()
        ElseIf pFormType = "DO" Then
            Me.SetStockInDOForm()
        ElseIf pFormType = "ST" Then
            Me.SetStockTransferForm()
        ElseIf pFormType = "SA" Then
            Me.SetStockAdjustmentForm()
        ElseIf pFormType = "FGW" Then
            Me.SetFGWForm()
            Me.LookUpEdit_Year.Visible = True
            Panel1.Height = 78
        ElseIf pFormType = "FGWDO" Then
            Me.SetFGWDOForm()
            Me.LookUpEdit_Year.Visible = True
            Panel1.Height = 78
        ElseIf pFormType = "FGWNOI" Then
            Me.SetFGWNOIForm()
            Me.LookUpEdit_Year.Visible = True
            Panel1.Height = 78

        ElseIf pFormType = "QAR" Then
            Me.SetQARForm()
            Me.LookUpEdit_Year.Visible = True
            Panel1.Height = 78

        ElseIf pFormType = "INT" Then
            Me.SetINTForm()
            Me.LookUpEdit_Year.Visible = True
            Panel1.Height = 78

        End If

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SRVNoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents AddMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents EditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents NewDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Print2_Button As System.Windows.Forms.Button
    Friend WithEvents LookUpEdit_Year As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Transactdate_combo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Transactdate_combo = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.LookUpEdit_Year = New DevExpress.XtraEditors.LookUpEdit
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.NewDoc = New DevExpress.XtraEditors.TextEdit
        Me.SRVNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.EditButton = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Print2_Button = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.AddMenu = New System.Windows.Forms.MenuItem
        Me.EditMenu = New System.Windows.Forms.MenuItem
        Me.DeleteMenu = New System.Windows.Forms.MenuItem
        Me.Panel1.SuspendLayout()
        CType(Me.Transactdate_combo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRVNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Transactdate_combo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LookUpEdit_Year)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.NewDoc)
        Me.Panel1.Controls.Add(Me.SRVNoCmb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 82)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(61, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SRV #:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Transactdate_combo
        '
        Me.Transactdate_combo.DateTime = New Date(CType(0, Long))
        Me.Transactdate_combo.Location = New System.Drawing.Point(108, 42)
        Me.Transactdate_combo.Name = "Transactdate_combo"
        Me.Transactdate_combo.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.Transactdate_combo.Properties.MaskData.EditMask = "##/##/####"
        Me.Transactdate_combo.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Transactdate_combo.Size = New System.Drawing.Size(162, 25)
        Me.Transactdate_combo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Transact date:"
        '
        'LookUpEdit_Year
        '
        Me.LookUpEdit_Year.Location = New System.Drawing.Point(446, 8)
        Me.LookUpEdit_Year.Name = "LookUpEdit_Year"
        Me.LookUpEdit_Year.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.LookUpEdit_Year.Size = New System.Drawing.Size(75, 25)
        Me.LookUpEdit_Year.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(364, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "New"
        '
        'NewDoc
        '
        Me.NewDoc.Location = New System.Drawing.Point(132, 9)
        Me.NewDoc.Name = "NewDoc"
        Me.NewDoc.Size = New System.Drawing.Size(140, 21)
        Me.NewDoc.TabIndex = 0
        Me.NewDoc.Visible = False
        '
        'SRVNoCmb
        '
        Me.SRVNoCmb.Location = New System.Drawing.Point(78, 8)
        Me.SRVNoCmb.Name = "SRVNoCmb"
        Me.SRVNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SRVNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SRVNoCmb.Properties.DropDownRows = 30
        Me.SRVNoCmb.Properties.NullString = ""
        Me.SRVNoCmb.Properties.PopupWidth = 210
        Me.SRVNoCmb.Size = New System.Drawing.Size(194, 23)
        Me.SRVNoCmb.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Controls.Add(Me.DeleteButton)
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 51)
        Me.Panel2.TabIndex = 1
        '
        'EditButton
        '
        Me.EditButton.Enabled = False
        Me.EditButton.Location = New System.Drawing.Point(102, 14)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Text = "Edit"
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(188, 14)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Delete"
        '
        'AddButton
        '
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(18, 14)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Print2_Button)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(340, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 51)
        Me.Panel3.TabIndex = 3
        '
        'Print2_Button
        '
        Me.Print2_Button.Location = New System.Drawing.Point(84, 16)
        Me.Print2_Button.Name = "Print2_Button"
        Me.Print2_Button.Size = New System.Drawing.Size(75, 23)
        Me.Print2_Button.TabIndex = 2
        Me.Print2_Button.Text = "Rec. Vou"
        Me.Print2_Button.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(248, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Close"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(166, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Print"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EditorsRepository = Me.PersistentRepository1
        Me.GridControl1.Location = New System.Drawing.Point(0, 82)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(676, 330)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.Text = "GridControl1"
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.[Default], Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.BorderStyle = DevExpress.XtraGrid.Views.Grid.ViewBorderStyle.Border3D
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AddMenu, Me.EditMenu, Me.DeleteMenu})
        '
        'AddMenu
        '
        Me.AddMenu.Index = 0
        Me.AddMenu.Text = "Add"
        '
        'EditMenu
        '
        Me.EditMenu.Index = 1
        Me.EditMenu.Text = "Edit"
        '
        'DeleteMenu
        '
        Me.DeleteMenu.Index = 2
        Me.DeleteMenu.Text = "Delete"
        '
        'StockOutSRVForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(676, 463)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StockOutSRVForm"
        Me.Text = "SRV Stock Out"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Transactdate_combo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRVNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub SetYearCombo()
        Dim i As Integer

        Dim dData(11) As String '= New String() {"All Items", "Active Items only", "Dormant Items only"}
        Dim dID(11) As String '= New String() {"0", "1", "2"}

        Dim currentYr As Integer
        currentYr = Today.Year
        Dim setyr As Integer
        setyr = currentYr + 1
        For i = 0 To 9

            dData(i) = setyr.ToString()
            dID(i) = setyr.ToString()
            setyr = setyr - 1

        Next

        dData(10) = "Show ALL"
        dID(10) = "ALL"

        SetComboValue(dData, Me.LookUpEdit_Year, dID)

        Me.LookUpEdit_Year.Properties.LookUpData.KeyValue = currentYr.ToString() 'default set to current year

    End Sub

    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())
        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Function CreateSRVNo() As String
        Dim NewNo As String
        Dim DocumentNo As String

        DocumentNo = NewDoc.Text

        If FormType = "SRV" Then
            CreateSRVNo = "SRV-" & AddYear() & DocumentNo
        ElseIf FormType = "RTN" Then
            CreateSRVNo = "RTN-" & AddYear() & DocumentNo
        ElseIf FormType = "DO" Then
            CreateSRVNo = "DO-" & DocumentNo
        ElseIf FormType = "PMR" Then
            CreateSRVNo = "PMR-" & AddYear() & DocumentNo
        ElseIf FormType = "ST" Then
            CreateSRVNo = "ST-" & AddYear() & DocumentNo
        ElseIf FormType = "FGW" Then
            CreateSRVNo = "FGW-" & AddYear() & DocumentNo
        ElseIf FormType = "QAR" Then
            CreateSRVNo = "QAR-" & AddYear() & DocumentNo
        ElseIf FormType = "INT" Then
            CreateSRVNo = "INT-" & AddYear() & DocumentNo
        ElseIf FormType = "SA" Then
            CreateSRVNo = "SA-" & AddYear() & DocumentNo
        ElseIf FormType = "FGWDO" Then
            CreateSRVNo = "" & DocumentNo
        ElseIf FormType = "FGWNOI" Then
            CreateSRVNo = "" & DocumentNo
        End If

        If IsNumeric(DocumentNo) Then
            If FormType <> "DO" And FormType <> "FGWDO" And FormType <> "FGWNOI" Then
                With New BusinessRules.CommonBusRules.CommonLogic
                    '.UserID = UserID
                    .UpdateDocumentNextNumber(Convert.ToInt32(DocumentNo) + 1, FormType, Me.LookUpEdit_Year.Text)
                End With
            End If
        End If

    End Function

    Public Function SetSRVForm()
        FormType = "SRV"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListSRV(dslist) Then
                If dslist.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "SRV #:"
    End Function

    Public Function SetPMRForm()
        FormType = "PMR"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListPMR(dslist) Then
                If dslist.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "PMR #:"
    End Function

    Public Function SetReturnInRTNForm()
        FormType = "RTN"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListRTN(dslist) Then
                If dslist.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "RTN #:"
    End Function

    Public Function SetStockInDOForm()
        FormType = "DO"
        Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListDO(dslist) Then
                If dslist.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "DO #:"
    End Function

    Public Function SetStockTransferForm()
        FormType = "ST"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListST(dslist) Then
                If dslist.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "ST #:"
    End Function

    Public Function SetStockAdjustmentForm()
        FormType = "SA"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListSA(dslist) Then
                If dslist.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "SA #:"
    End Function

    Public Function SetFGWForm()
        FormType = "FGW"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListFGW(dslist, Me.LookUpEdit_Year.Properties.LookUpData.KeyValue, "TRANSACT_DATE") Then
                If dslist.Tables(0).Rows.Count > 0 Then

                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", "FGW #", 400, 0, "c")
                    AddListFieldInfoToLookUp(SRVNoCmb, "Transact_Date", "Transact Date", 400, 0, "d")

                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "FGW #:"
    End Function

    Public Function SetFGWDOForm()
        FormType = "FGWDO"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic

            If .LoadList(dslist, FormType, Me.LookUpEdit_Year.Properties.LookUpData.KeyValue, "TRANSACT_DATE") Then
                If dslist.Tables(0).Rows.Count > 0 Then

                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", "DO #", 400, 0, "c")
                    AddListFieldInfoToLookUp(SRVNoCmb, "Transact_Date", "Transact Date", 400, 0, "d")

                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "DO #:"
    End Function

    Public Function SetFGWNOIForm()
        FormType = "FGWNOI"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadList(dslist, FormType, Me.LookUpEdit_Year.Properties.LookUpData.KeyValue, "TRANSACT_DATE") Then
                If dslist.Tables(0).Rows.Count > 0 Then

                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", "NOI #", 400, 0, "c")
                    AddListFieldInfoToLookUp(SRVNoCmb, "Transact_Date", "Transact Date", 400, 0, "d")

                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "NOI #:"
    End Function

    Public Function SetQARForm()
        FormType = "QAR"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListQAR(dslist, Me.LookUpEdit_Year.Properties.LookUpData.KeyValue) Then
                If dslist.Tables(0).Rows.Count > 0 Then

                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", "QAR #", 400, 0, "c")
                    AddListFieldInfoToLookUp(SRVNoCmb, "Transact_Date", "Transact Date", 400, 0, "d")

                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "QAR #:"
        Me.Print2_Button.Visible = True
    End Function

    Public Function SetINTForm()
        FormType = "INT"
        'Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing

        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListINT(dslist, Me.LookUpEdit_Year.Properties.LookUpData.KeyValue) Then
                If dslist.Tables(0).Rows.Count > 0 Then

                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", "INT #", 400, 0, "c")
                    AddListFieldInfoToLookUp(SRVNoCmb, "Transact_Date", "Transact Date", 400, 0, "d")

                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = dslist.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "INT #:"
    End Function

    Private Sub StockOutSRVForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'LoadStockTransSRV()
        'InitSRVList()
        'DefaultGridView()

        Me.SRVNoCmb.Focus()

    End Sub

    Private Sub DefaultGridView()

        GridView1.Columns("Transact Date").Width = 103
        GridView1.Columns("Product").Width = 116
        GridView1.Columns("Category").Width = 143
        GridView1.Columns("Product").Width = 113
        GridView1.Columns("Qty").Width = 83
        If FormType = "ST" Then
            GridView1.Columns("From").Width = 89
            GridView1.Columns("To").Width = 89
        Else
            GridView1.Columns("Warehouse").Width = 89
            GridView1.Columns("Area").Width = 89
        End If
        GridView1.Columns("Requestor").Width = 89

    End Sub

    Private Sub StoreGridView()
        GridView1.Columns("Transact Date").Width = 103
        GridView1.Columns("Product").Width = 116
        GridView1.Columns("Category").Width = 143
        GridView1.Columns("Product").Width = 113
        GridView1.Columns("Qty").Width = 83
        GridView1.Columns("Warehouse").Width = 89
        GridView1.Columns("Area").Width = 89
        GridView1.Columns("Requestor").Width = 89
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal caption As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, caption, width, alignment, format)
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "New" Then

            NewDoc.Text = ""
            Me.NewDoc.Visible = True
            Label3.Visible = True
            SRVNoCmb.Visible = False

            NewDoc.Focus()
            Button1.Text = "Ok"
            'Button4.Visible = True
            Button4.Text = "Cancel"


            Me.GridControl1OldState = GridControl1.Enabled
            Button4OldState = Button4.Enabled
            AddButtonOldState = AddButton.Enabled
            DeleteButtonOldState = DeleteButton.Enabled
            EditButtonOldState = EditButton.Enabled


            Button4.Enabled = True
            GridControl1.Enabled = False
            AddButton.Enabled = False
            DeleteButton.Enabled = False
            EditButton.Enabled = False
            Print2_Button.Enabled = False

            Me.TransactDateChangeCheck = False
            Olddt = Transactdate_combo.DateTime
            Transactdate_combo.DateTime = Now.Date
            Me.TransactDateChangeCheck = True

            SetPrefixLabel()

            Dim NewNo As String
            With New BusinessRules.CommonBusRules.CommonLogic
                '.UserID = UserID
                If FormType <> "DO" And FormType <> "FGWDO" And FormType <> "FGWNOI" Then 'And FormType <> "PMR" Then
                    NewDoc.Text = .GetDocumentNextNumber(FormType, Me.LookUpEdit_Year.Text, False)
                End If
            End With

            Me.TransactDateChangeCheck = False

        Else
            If Me.CreateNewDoc() = True Then
                NewDoc.Visible = False
                Label3.Visible = False
                SRVNoCmb.Visible = True
                Button1.Text = "New"
                'Button4.Visible = False
                Button4.Text = "Delete"
                GridControl1.Enabled = True
                AddButton.Enabled = True
                AddMenu.Enabled = True
                LoadStockTransSRV()
                AddMenu_Click(sender, e)
                Me.TransactDateChangeCheck = True
            End If
        End If

        'SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewSRV()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "SRV"
            .Transact_Date = Transactdate_combo.DateTime
            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListSRV(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO


    End Sub

    Private Sub NewRTN()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "RTN"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListRTN(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO


    End Sub

    Private Sub NewDO()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "DO"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListDO(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Properties.LookUpData.KeyValue = LastID
        'SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewPMR()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "PMR"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListPMR(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewST()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "ST"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListST(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewSA()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "SA"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListSA(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewFGW()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "FGW"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListFGW(ds, "TRANSACT_DATE") Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewFGWDO()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "FGWDO"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadList(ds, "FGWDO", Me.LookUpEdit_Year.Properties.LookUpData.KeyValue, "TRANSACT_DATE") Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub
    Private Sub NewFGWNOI()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "FGWNOI"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadList(ds, "FGWNOI", Me.LookUpEdit_Year.Properties.LookUpData.KeyValue, "TRANSACT_DATE") Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewQAR()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "QAR"
            .Transact_Date = Transactdate_combo.DateTime

            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListQAR(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub
    Private Sub NewINT()
        'NEW SRV
        Dim LastID As Integer
        Dim SRVNO As String
        With New BusinessRules.BusRules.SRVBusLogic
            SRVNO = CreateSRVNo()
            .SRVNO = SRVNO
            .UserID = UserID
            .Type = "INT"
            LastID = .Save()
        End With

        Dim ds As DataSet
        With New BusinessRules.BusRules.SRVBusLogic
            If .LoadListINT(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "SRVNO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "SRV_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "SRVNO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        SRVNoCmb.Text = SRVNO

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub StockOutSRVForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub SRVNoCmb_ValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles SRVNoCmb.ValueChanging

    End Sub

    Private Sub SRVNoCmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SRVNoCmb.ValueChanged

    End Sub


    Private Sub InitSRVList()

        dataGrid = New DataTable("ColumnsTable")
        dataGrid.BeginInit()

        AddColumn(dataGrid, "Transaction_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Stock_ID", System.Type.GetType("System.Int32"), True)
        If FormType = "ST" Then
            AddColumn(dataGrid, "Product_ID", System.Type.GetType("System.Int32"), True)
            AddColumn(dataGrid, "Src_Warehouse_area_ID", System.Type.GetType("System.Int32"), True)
            AddColumn(dataGrid, "Dst_Warehouse_area_id", System.Type.GetType("System.Int32"), True)
        End If
        AddColumn(dataGrid, "Transact Date", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Category", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Qty", System.Type.GetType("System.Int32"), True)
        If FormType = "ST" Then
            AddColumn(dataGrid, "From", System.Type.GetType("System.String"), True)
            AddColumn(dataGrid, "To", System.Type.GetType("System.String"), True)
        Else
            AddColumn(dataGrid, "Warehouse", System.Type.GetType("System.String"), True)
            AddColumn(dataGrid, "Area", System.Type.GetType("System.String"), True)
        End If
        AddColumn(dataGrid, "Requestor", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Remarks", System.Type.GetType("System.String"), True)

        dataGrid.EndInit()

    End Sub

    Private Sub AssignSummaryItemsTo(ByVal fromGsi As GridSummaryItems, ByVal toGsi As GridSummaryItems)
        If toGsi Is Nothing Or fromGsi Is Nothing Then Return
        toGsi.Clear()
        Dim si As GridSummaryItem
        Dim i As Integer
        For i = 0 To fromGsi.Count - 1
            si = fromGsi(i)
            toGsi.Add(si.SummaryType, si.FieldName, si.ShowInColumn)
            toGsi(i).DisplayFormat = si.DisplayFormat
        Next
    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data1.Columns.Add(col)
    End Sub

    Public Sub LoadStockTransSRV()
        Dim ds As DataSet
        Dim dsParent As DataSet

        InitSRVList()
        If Not SRVNoCmb.Properties.LookUpData.KeyValue Is Nothing Then

            With New BusinessRules.BusRules.InventoryBusLogic

                If FormType = "FGW" Or FormType = "QAR" Or FormType = "INT" Then
                    dt = .GetSRVTransactDate(SRVNoCmb.Properties.LookUpData.KeyValue)
                    TransactDateChangeCheck = False
                    Me.Transactdate_combo.DateTime = dt
                    TransactDateChangeCheck = True
                End If

                If FormType = "ST" Then
                    If .GetStockTransferTransactionSRV(ds, SRVNoCmb.Properties.LookUpData.KeyValue) Then

                        Dim oRow As DataRow
                        Dim i As Integer = 0
                        Dim Status As String

                        For Each oRow In ds.Tables(0).Rows
                            dataGrid.Rows.Add(New Object() { _
                            oRow("Transaction_ID"), _
                            oRow("Stock_ID"), _
                            oRow("Product_Id"), _
                            oRow("Src_warehouse_area_id"), _
                            oRow("Dst_warehouse_area_id"), _
                             ChangeDateFormat(oRow("Transact_Date")), _
                             oRow("Product_Name"), _
                             oRow("Category_Name"), _
                            oRow("Qty"), _
                            oRow("Src_Warehouse_Area"), _
                            oRow("Dst_Warehouse_Area"), _
                            oRow("Requestor"), _
                            oRow("Remarks")})
                        Next

                        GridControl1.DataSource = dataGrid
                        GridControl1.DefaultView.PopulateColumns()

                        'GridView1.BestFitColumns()
                        Me.DefaultGridView()
                        GridView1.Columns.Item(0).VisibleIndex = -1    'hide column
                        GridView1.Columns.Item(1).VisibleIndex = -1    'hide column
                        GridView1.Columns.Item(2).VisibleIndex = -1    'hide column
                        GridView1.Columns.Item(3).VisibleIndex = -1    'hide column
                        GridView1.Columns.Item(4).VisibleIndex = -1    'hide column

                    End If
                ElseIf FormType = "SA" Then
                    If .GetStockTransactionSA(ds, SRVNoCmb.Properties.LookUpData.KeyValue) Then

                        Dim oRow As DataRow
                        Dim i As Integer = 0
                        Dim Status As String

                        For Each oRow In ds.Tables(0).Rows
                            dataGrid.Rows.Add(New Object() { _
                            oRow("Transaction_ID"), _
                            oRow("Stock_ID"), _
                             ChangeDateFormat(oRow("Transact_Date")), _
                             oRow("Product_Name"), _
                             oRow("Category_Name"), _
                            oRow("Qty"), _
                            oRow("Warehouse"), _
                            oRow("Warehouse_Area"), _
                            oRow("Requestor"), _
                            oRow("Remarks")})
                        Next

                        GridControl1.DataSource = dataGrid
                        GridControl1.DefaultView.PopulateColumns()

                        'GridView1.BestFitColumns()
                        Me.DefaultGridView()
                        GridView1.Columns.Item(0).VisibleIndex = -1    'hide column
                        GridView1.Columns.Item(1).VisibleIndex = -1    'hide column

                    End If
                Else
                    If .GetStockTransactionSRV(ds, SRVNoCmb.Properties.LookUpData.KeyValue) Then

                        Dim oRow As DataRow
                        Dim i As Integer = 0
                        Dim Status As String

                        For Each oRow In ds.Tables(0).Rows
                            dataGrid.Rows.Add(New Object() { _
                            oRow("Transaction_ID"), _
                            oRow("Stock_ID"), _
                             ChangeDateFormat(oRow("Transact_Date")), _
                             oRow("Product_Name"), _
                             oRow("Category_Name"), _
                            oRow("Qty"), _
                            oRow("Warehouse"), _
                            oRow("Warehouse_Area"), _
                            oRow("Requestor"), _
                            oRow("Remarks")})
                        Next

                        GridControl1.DataSource = dataGrid
                        GridControl1.DefaultView.PopulateColumns()

                        'GridView1.BestFitColumns()
                        Me.DefaultGridView()
                        GridView1.Columns.Item(0).VisibleIndex = -1    'hide column
                        GridView1.Columns.Item(1).VisibleIndex = -1    'hide column

                    End If
                End If
            End With

            AddButton.Enabled = True
            AddMenu.Enabled = True
            GridControl1.Enabled = True
            Button4.Enabled = True


            GridView1.Columns("Transact Date").SummaryItem.SummaryType = SummaryItemType.Count

            GridView1.ViewOptions = GridView1.ViewOptions Or ViewOptionsFlags.ShowFooter


            If GridView1.RowCount() <> 0 Then
                GridView1.MoveFirst()
                GridClick()
                DeleteButton.Enabled = True
                EditButton.Enabled = True
                Print2_Button.Enabled = True
            Else
                EditButton.Enabled = False
                DeleteButton.Enabled = False
            End If
        Else
            'GridControl1.DataSource = Nothing
            'GridControl1.Refresh()
            GridControl1.DataSource = dataGrid
            GridControl1.DefaultView.PopulateColumns()
        End If



    End Sub

    Private Sub GridClick()
        If GridView1.SelectedRowsCount <> 0 Then

            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then
                Me.Cursor = Cursors.WaitCursor
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                Transaction_ID = items(0)

                Me.Cursor = Cursors.Default

            End If
        End If
    End Sub

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String
        'str = GridView1.Columns(0).Width & "," & _
        'GridView1.Columns(1).Width & "," & _
        'GridView1.Columns(2).Width & "," & _
        'GridView1.Columns(3).Width & "," & _
        'GridView1.Columns(4).Width & "," & _
        ' GridView1.Columns(5).Width & "," & _
        ' GridView1.Columns(6).Width & "," & _
        ' GridView1.Columns(7).Width

        'MessageBox.Show(str)

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        'Dim ExtProgressForm
        'ExtProgressForm = New TaskProgressForm
        'ExtProgressForm. = Me
        'ExtProgressForm.Show()
        'ExtProgressForm.Refresh()

        If FormType = "SRV" Then
        ElseIf FormType = "PMR" Then
        ElseIf FormType = "RTN" Then
        ElseIf FormType = "DO" Then
        ElseIf FormType = "ST" Then
        ElseIf FormType = "FGW" Then
        ElseIf FormType = "QAR" Then
        ElseIf FormType = "INT" Then
        End If

        str = SRVNoCmb.Text
        Me.Cursor = Cursors.WaitCursor
        Dim formx As StockTransReport
        formx = New StockTransReport(0, "", "", str, SRVNoCmb.Properties.LookUpData.KeyValue, "", "")
        formx.ShowDialog()
        Me.Cursor = Cursors.Arrow
        'ExtProgressForm.Close()

    End Sub

    Private Sub GridControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

        If SRVNoCmb.Properties.LookUpData.KeyValue Then
            Dim eventString As String = Nothing
            Select Case e.Button
                Case MouseButtons.Left
                    eventString = "L"
                Case MouseButtons.Right
                    eventString = "R"
                    ComponentContextMenu.Show(sender, mouseDownLocation)
                Case MouseButtons.None
                    eventString = Nothing
            End Select
        End If
    End Sub

    Private Sub AddMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddMenu.Click
        'Dim NewForm As New StockOutLooseForm

        If FormType = "SRV" Then
            Dim NewForm As New StockTransForm(FormType, Nothing)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.Transaction_Type = "Stock Out"
            NewForm.OrderType = "WO"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "PMR" Then
            Dim NewForm As New StockTransForm(FormType, Nothing)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.Transaction_Type = "Stock Out"
            NewForm.OrderType = "WO"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "RTN" Then
            Dim NewForm As New StockTransForm(FormType, Nothing)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.Transaction_Type = "Stock In"
            NewForm.OrderType = "WO"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "DO" Then
            Dim NewForm As New StockTransForm(FormType, Nothing)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "WO"
            NewForm.Transaction_Type = "Stock In"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "ST" Then
            Dim NewForm As New StockTransForm(FormType, Nothing)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "WO"
            NewForm.Transaction_Type = "Stock Transfer"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "SA" Then
            Dim NewForm As New StockTransForm(FormType, Nothing)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "WO"
            NewForm.Transaction_Type = "Stock Adjustment"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "FGW" Then
            Dim NewForm As New StockTransForm(FormType, Transactdate_combo.DateTime)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "SNO"
            NewForm.Transaction_Type = "Stock Out"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "FGWDO" Then
            Dim NewForm As New StockTransForm(FormType, Transactdate_combo.DateTime)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "SNO"
            NewForm.Transaction_Type = "Stock Out"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "FGWNOI" Then
            Dim NewForm As New StockTransForm(FormType, Transactdate_combo.DateTime)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "SNO"
            NewForm.Transaction_Type = "Stock Out"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "QAR" Then
            Dim NewForm As New StockTransForm(FormType, Transactdate_combo.DateTime)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "SNO"
            NewForm.Transaction_Type = "Stock In"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        ElseIf FormType = "INT" Then
            Dim NewForm As New StockTransForm(FormType, Transactdate_combo.DateTime)
            NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            NewForm.OrderType = "SNO"
            NewForm.Transaction_Type = "Stock Out"
            NewForm.FormType = FormType
            NewForm.ShowDialog(Me)
        End If
        'LoadStockTransSRV()
    End Sub

    Private Sub DeleteMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteMenu.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim TransactionID As Integer = dr(0)
                If TransactionID > 0 Then
                    Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Stock Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                    If Result = DialogResult.Yes Then
                        If FormType = "ST" Then
                            DeleteStockTransferTransaction(TransactionID, dr("Qty"), dr("product_id"), dr("src_Warehouse_area_id"), dr("dst_warehouse_area_id"))
                        Else
                            DeleteStockTransaction(TransactionID, dr("Qty"), dr("Stock_id"))
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DeleteStockTransferTransaction(ByVal TransactionID As Integer, ByVal Qty As Integer, ByVal Product_Id As Integer, ByVal Src_WHA_ID As Integer, ByVal Dst_WHA_ID As Integer)
        With New BusinessRules.BusRules.InventoryBusLogic
            .Src_WHA_ID = Src_WHA_ID
            .Dst_WHA_ID = Dst_WHA_ID
            .UserID = UserID
            .Product_ID = Product_Id
            '.Transaction_Type = 
            .Relocate_Qty = Qty
            If .UpdateSelectedStockTransfer() Then
                .DeleteStockTransferTransaction(TransactionID)
            End If
        End With
        LoadStockTransSRV()
    End Sub

    Private Sub DeleteStockTransaction(ByVal TransactionID As Integer, ByVal Qty As Integer, ByVal Stock_Id As Integer)
        With New BusinessRules.BusRules.InventoryBusLogic
            If FormType = "DO" Or FormType = "RTN" Or FormType = "QAR" Then
                .Transaction_Type = "Stock Out"
                .StockOutQty = Qty
            ElseIf FormType = "SRV" Or FormType = "PMR" Or FormType = "FGWDO" Or FormType = "FGWNOI" Or FormType = "INT" Then
                .Transaction_Type = "Stock In"
                .StockInQty = Qty
                'ElseIf FormType = "ST" Then
                '    .Transaction_Type = "Stock Transfer"
                '    .StockOutQty = Qty
            ElseIf FormType = "SA" Then
                If Qty > 0 Then
                    .Transaction_Type = "Stock Out"
                    .StockOutQty = Qty
                ElseIf Qty < 0 Then
                    .Transaction_Type = "Stock In"
                    .StockInQty = Math.Abs(Qty)
                End If
            Else
                Return
            End If
            .Stock_ID = Stock_Id
            .UserID = UserID
            If .UpdateSelectedStock() Then
                .DeleteStockTransaction(TransactionID)
            End If
        End With
        LoadStockTransSRV()
    End Sub


    Private Function CreateNewDoc() As Boolean
        Dim dr As DialogResult

        If ValidTransactDate() = False Then
            Return False
        End If

        While ValidDocNo() = False
            If FormType <> "DO" Then
                dr = MessageBox.Show("Do you want to try the next no?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                If dr = DialogResult.Yes Then
                    With New BusinessRules.CommonBusRules.CommonLogic
                        '.UserID = UserID
                        .UpdateDocumentNextNumber(Convert.ToInt32(NewDoc.Text) + 1, FormType, Convert.ToInt32(Me.LookUpEdit_Year.Text))
                        NewDoc.Text = .GetDocumentNextNumber(FormType, Me.LookUpEdit_Year.Text, False)
                    End With
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End While

        If True Then 'ValidDocNo() Then
            If FormType = "SRV" Then
                NewSRV()
                Return True
            ElseIf FormType = "RTN" Then
                NewRTN()
                Return True
            ElseIf FormType = "DO" Then
                NewDO()
                Return True
            ElseIf FormType = "PMR" Then
                NewPMR()
                Return True
            ElseIf FormType = "ST" Then
                NewST()
                Return True
            ElseIf FormType = "SA" Then
                NewSA()
                Return True
            ElseIf FormType = "FGW" Then
                NewFGW()
                Return True
            ElseIf FormType = "FGWDO" Then
                NewFGWDO()
                Return True
            ElseIf FormType = "FGWNOI" Then
                NewFGWNOI()
                Return True
            ElseIf FormType = "QAR" Then
                NewQAR()
                Return True
            ElseIf FormType = "INT" Then
                NewINT()
                Return True
            End If
        End If
        Return False
    End Function

    Function ValidDocNo() As Boolean
        ValidDocNo = True

        If NewDoc.Text.Length <= 0 Then
            ValidDocNo = False
            MessageBox.Show("Please enter a new Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewDoc.Focus()
            Exit Function
        End If

        If FormType = "SRV" Then
            If Duplicate("SRV-" & AddYear() & NewDoc.Text) = False Then

                'NewSRV()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If
        ElseIf FormType = "RTN" Then
            If Duplicate("RTN-" & AddYear() & NewDoc.Text) = False Then
                'NewRTN()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If
        ElseIf FormType = "DO" Then
            If Duplicate("DO-" & NewDoc.Text) = False Then
                'NewDO()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If
        ElseIf FormType = "PMR" Then
            If Duplicate("PMR-" & AddYear() & NewDoc.Text) = False Then
                'NewDO()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If
        ElseIf FormType = "ST" Then
            If Duplicate("ST-" & AddYear() & NewDoc.Text) = False Then
                'NewDO()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If
        ElseIf FormType = "SA" Then
            If Duplicate("SA-" & AddYear() & NewDoc.Text) = False Then
                'NewDO()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If

        ElseIf FormType = "FGW" Then
            If Duplicate("FGW-" & AddYear() & NewDoc.Text) = False Then
                'NewDO()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If


        ElseIf FormType = "QAR" Then
            If Duplicate("QAR-" & AddYear() & NewDoc.Text) = False Then
                'NewDO()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If


        ElseIf FormType = "INT" Then
            If Duplicate("INT-" & AddYear() & NewDoc.Text) = False Then
                'NewDO()
            Else
                MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewDoc.SelectAll()
                NewDoc.Focus()
                ValidDocNo = False
            End If


        End If


    End Function

    Function ValidTransactDate()
        ValidTransactDate = True

        If FormType = "FGW" Or FormType = "QAR" Or FormType = "INT" Then

            If Me.Transactdate_combo.DateTime.Year.ToString() <> Me.LookUpEdit_Year.Text() Then
                MessageBox.Show("You have enter a transaction date not in the Year " & LookUpEdit_Year.Text() & "! Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogResult.Yes Then
                    ValidTransactDate = True
                Else
                    ValidTransactDate = False
                End If
                ValidTransactDate = False
            End If

        End If

    End Function

    Function AddYear() As String
        AddYear = Me.LookUpEdit_Year.Text() & "/"
    End Function


    Function Duplicate(ByVal DocNo As String) As Boolean
        Duplicate = False
        With New BusinessRules.BusRules.SRVBusLogic
            If .CheckExist(DocNo) = True Then
                Return True
            End If
        End With
        Return False
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If Button4.Text = "Cancel" Then
            NewDoc.Visible = False
            Label3.Visible = False
            SRVNoCmb.Visible = True

            Button1.Text = "New"
            'Button4.Visible = False
            Button4.Text = "Delete"

            AddButton.Enabled = AddMenu.Enabled = AddButtonOldState
            DeleteButton.Enabled = DeleteMenu.Enabled = DeleteButtonOldState
            EditButton.Enabled = EditMenu.Enabled = EditButtonOldState
            GridControl1.Enabled = GridControl1OldState
            Print2_Button.Enabled = True

            Button4.Enabled = Button4OldState

            If Olddt <> Nothing Then
                Me.TransactDateChangeCheck = False
                Transactdate_combo.DateTime = Olddt
                Me.TransactDateChangeCheck = True
            End If

            Me.TransactDateChangeCheck = True

        Else
            DeleteSRV()
            LoadStockTransSRV()
            Me.SRVNoCmb.Focus()

            Button4.Enabled = True
            GridControl1.Enabled = False
            AddButton.Enabled = False
            DeleteButton.Enabled = False
            EditButton.Enabled = False
            Print2_Button.Enabled = False
        End If


    End Sub

    Private Sub DeleteSRV()

        Dim dr As DataRow
        Dim i As Integer
        Dim Result As DialogResult = MessageBox.Show("Confirm delete " & SRVNoCmb.Text & "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If Result = DialogResult.Yes Then

            If GridView1.RowCount > 0 Then
                For i = GridView1.RowCount - 1 To 0 Step -1
                    dr = GridView1.GetDataRow(i)
                    If Not dr Is Nothing Then
                        Dim TransactionID As Integer = dr(0)
                        If TransactionID > 0 Then
                            Try
                                DeleteStockTransaction(TransactionID, dr("Qty"), dr("Stock_id"))
                            Catch ex As Exception

                                MessageBox.Show("Error deleting transaction:" & ex.Message)
                                Exit Sub

                            End Try
                        End If
                    End If
                Next
            End If

            With New BusinessRules.BusRules.SRVBusLogic
                .Delete(SRVNoCmb.Properties.LookUpData.KeyValue)
            End With


            If FormType = "SRV" Then
                Me.SetSRVForm()
            ElseIf FormType = "PMR" Then
                Me.SetPMRForm()
            ElseIf FormType = "RTN" Then
                Me.SetReturnInRTNForm()
            ElseIf FormType = "DO" Then
                Me.SetStockInDOForm()
            ElseIf FormType = "ST" Then
                Me.SetStockTransferForm()
            ElseIf FormType = "FGW" Then
                Me.SetFGWForm()
            ElseIf FormType = "QAR" Then
                Me.SetQARForm()
            ElseIf FormType = "INT" Then
                Me.SetINTForm()
            End If

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        AddMenu_Click(sender, e)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        DeleteMenu_Click(sender, e)
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        EditMenu_Click(sender, e)
    End Sub

    Private Sub EditMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenu.Click
        If FormType = "ST" Then
            Exit Sub
        End If
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim TransactionID As Integer = dr(0)
                If TransactionID > 0 Then

                    If FormType = "SRV" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Nothing, "Stock Out")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.Transaction_Type = "Stock Out"
                        NewForm.OrderType = "WO"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)

                    ElseIf FormType = "PMR" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Nothing, "Stock Out")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.Transaction_Type = "Stock Out"
                        NewForm.OrderType = "WO"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "RTN" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Nothing, "Stock In")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.Transaction_Type = "Stock In"
                        NewForm.OrderType = "WO"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "DO" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Nothing, "Stock In")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock In"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "ST" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Nothing, "Stock Transfer")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock Transfer"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "SA" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Nothing, "Stock Adjustment")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock Adjustment"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "FGW" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Transactdate_combo.DateTime, "Stock Out")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock Out"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "FGWDO" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Transactdate_combo.DateTime, "Stock Out")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock Out"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "FGWNOI" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Transactdate_combo.DateTime, "Stock Out")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock Out"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "QAR" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Transactdate_combo.DateTime, "Stock In")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock In"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    ElseIf FormType = "INT" Then
                        Dim NewForm As New StockTransForm(FormType, TransactionID, Transactdate_combo.DateTime, "Stock Out")
                        NewForm.SRV_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                        NewForm.OrderType = "WO"
                        NewForm.Transaction_Type = "Stock Out"
                        NewForm.FormType = FormType
                        NewForm.ShowDialog(Me)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        If GridView1.RowCount > 0 Then
            EditMenu_Click(sender, e)
        Else
            AddMenu_Click(sender, e)
        End If
    End Sub


    Private Sub GridControl1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            If GridView1.RowCount > 0 Then
                EditMenu_Click(sender, e)
            Else
                AddMenu_Click(sender, e)
            End If
        End If
    End Sub


    Private Sub SRVNoCmb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SRVNoCmb.KeyDown
        If e.KeyCode = Keys.Down Then
            SRVNoCmb.DoPopup()
        End If
    End Sub

    Private Sub SRVNoCmb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SRVNoCmb.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            LoadStockTransSRV()
            GridControl1.Focus()
        End If
    End Sub

    Private Sub SRVNoCmb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SRVNoCmb.LostFocus
        SRVNoCmb.Properties.Style.BackColor = System.Drawing.SystemColors.Window
    End Sub

    Private Sub SRVNoCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles SRVNoCmb.CloseUp
        Dim id As Integer
        If ReloadSRVComboOnCloseUp = True Then
            id = SRVNoCmb.Properties.LookUpData.KeyValue()
            LoadSRVCombo()
            SRVNoCmb.Properties.LookUpData.KeyValue = id
            ReloadSRVComboOnCloseUp = False
        End If
        LoadStockTransSRV()
        GridControl1.Focus()
    End Sub

    Private Sub SRVNoCmb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SRVNoCmb.GotFocus
        'OnFocus(sender)
        SRVNoCmb.Properties.Style.BackColor = Color.LightYellow
    End Sub

    Private Sub OnFocus(ByRef sender As Object)
        Dim c As Control
        c = sender
        c.BackColor = Color.LightYellow
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SRVNoCmb.Focus()
    End Sub

    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus

    End Sub

    Private Sub NewDoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewDoc.GotFocus
        NewDoc.Properties.Style.BackColor = Color.LightYellow
    End Sub

    Private Sub NewDoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewDoc.LostFocus
        NewDoc.Properties.Style.BackColor = System.Drawing.SystemColors.Window
    End Sub


    Private Sub NewDoc_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NewDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print2_Button.Click
        Dim str As String
        'str = GridView1.Columns(0).Width & "," & _
        'GridView1.Columns(1).Width & "," & _
        'GridView1.Columns(2).Width & "," & _
        'GridView1.Columns(3).Width & "," & _
        'GridView1.Columns(4).Width & "," & _
        ' GridView1.Columns(5).Width & "," & _
        ' GridView1.Columns(6).Width & "," & _
        ' GridView1.Columns(7).Width

        'MessageBox.Show(str)

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        'Dim ExtProgressForm
        'ExtProgressForm = New TaskProgressForm
        'ExtProgressForm. = Me
        'ExtProgressForm.Show()
        'ExtProgressForm.Refresh()

        If FormType = "SRV" Then
        ElseIf FormType = "PMR" Then
        ElseIf FormType = "RTN" Then
        ElseIf FormType = "DO" Then
        ElseIf FormType = "ST" Then
        ElseIf FormType = "FGW" Then
        ElseIf FormType = "QAR" Then
        ElseIf FormType = "INT" Then
        End If

        str = SRVNoCmb.Text
        Me.Cursor = Cursors.WaitCursor
        Dim formx As StockTransReport
        formx = New StockTransReport(0, "", str, SRVNoCmb.Properties.LookUpData.KeyValue, "", "", "QAR")
        formx.ShowDialog()
        Me.Cursor = Cursors.Arrow
        'ExtProgressForm.Close()

    End Sub

    Private Sub LookUpEdit_Year_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookUpEdit_Year.ValueChanged

        LoadSRVCombo()
        LoadStockTransSRV()
        Me.TransactDateChangeCheck = False
        Me.Transactdate_combo.DateTime = Nothing
        Me.TransactDateChangeCheck = True

    End Sub

    Private Sub LoadSRVCombo()
        If FormType = "SRV" Then
            Me.SetSRVForm()
        ElseIf FormType = "PMR" Then
            Me.SetPMRForm()
            Me.LookUpEdit_Year.Visible = True

        ElseIf FormType = "RTN" Then
            Me.SetReturnInRTNForm()
        ElseIf FormType = "DO" Then
            Me.SetStockInDOForm()
        ElseIf FormType = "ST" Then
            Me.SetStockTransferForm()
        ElseIf FormType = "SA" Then
            Me.SetStockAdjustmentForm()
        ElseIf FormType = "FGW" Then
            Me.SetFGWForm()
            Me.LookUpEdit_Year.Visible = True

        ElseIf FormType = "QAR" Then
            Me.SetQARForm()
            Me.LookUpEdit_Year.Visible = True

        ElseIf FormType = "INT" Then
            Me.SetINTForm()
            Me.LookUpEdit_Year.Visible = True

        End If

        Me.SRVNoCmb.Properties.DropDownRows = 30
    End Sub

    Private Sub Transactdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transactdate_combo.ValueChanged

        If TransactDateChangeCheck = True Then
            Dim dr As System.Windows.Forms.DialogResult
            dr = MessageBox.Show("Are you sure want to change the Transaction date to " & Transactdate_combo.DateTime.ToLongDateString, "Transaction Date change?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If dr = DialogResult.OK Then
                With New BusinessRules.BusRules.InventoryBusLogic

                    Dim docdate As Date = .GetSRVTransactDate(SRVNoCmb.Properties.LookUpData.KeyValue)

                    If docdate.Year <> Transactdate_combo.DateTime.Year Then
                        MessageBox.Show("Transaction date not change! Transaction Year must be similar to the Document Year", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TransactDateChangeCheck = False
                        Transactdate_combo.DateTime = dt
                        TransactDateChangeCheck = True
                        Exit Sub
                    End If

                    If .SetTransactionDateSRV(SRVNoCmb.Properties.LookUpData.KeyValue, Transactdate_combo.DateTime) Then
                        dt = Transactdate_combo.DateTime
                        LoadStockTransSRV()
                        ReloadSRVComboOnCloseUp = True
                        SetPrefixLabel()
                    Else
                        'MessageBox.Show("Transaction date not change! Transaction Year must be similar to the Document Year", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TransactDateChangeCheck = False
                        Transactdate_combo.DateTime = dt
                        TransactDateChangeCheck = True

                    End If
                End With

            Else
                TransactDateChangeCheck = False
                Transactdate_combo.DateTime = Me.dt
                TransactDateChangeCheck = True
            End If
        End If
    End Sub

    Private Sub SetPrefixLabel()
        If FormType <> "DO" And FormType <> "FGWDO" And FormType <> "FGWNOI" Then 'And FormType <> "PMR" Then
            'Me.Label3.Text = FormType & "-" & Me.Transactdate_combo.DateTime.Year & "/"

            Me.Label3.Text = FormType & "-" & Me.LookUpEdit_Year.Text() & "/"

            'Me.LookUpEdit_Year.Text()
        ElseIf FormType = "FGWDO" Or FormType = "FGWNOI" Then
            Me.Label3.Text = ""
        Else
            Me.Label3.Text = FormType & "-"
        End If
    End Sub

End Class


