Public Class LVBRequestF28Form
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pFormType As String)
        MyBase.New()

        FormType = pFormType

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
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AttnTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EditDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents F28Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrintF28Btn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintNoticeBtn As DevExpress.XtraEditors.Controls.XtraButton
	Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
	Friend WithEvents ComponentContextMenu As System.Windows.Forms.ContextMenu
	Friend WithEvents Delete As System.Windows.Forms.MenuItem
	Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	Friend WithEvents IONOLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents ContractLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LVBRequestF28Form))
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PrintF28Btn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.IONOLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ContractLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.AttnTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.EditDate = New DevExpress.XtraEditors.DateEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.F28Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.PrintNoticeBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.Delete = New System.Windows.Forms.MenuItem
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IONOLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttnTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F28Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintF28Btn
        '
        Me.PrintF28Btn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintF28Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintF28Btn.Image = Nothing
        Me.PrintF28Btn.Location = New System.Drawing.Point(576, 384)
        Me.PrintF28Btn.Name = "PrintF28Btn"
        Me.PrintF28Btn.Size = New System.Drawing.Size(112, 32)
        Me.PrintF28Btn.TabIndex = 53
        Me.PrintF28Btn.Text = "Print LV Form"
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(696, 384)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(88, 32)
        Me.CloseBtn.TabIndex = 54
        Me.CloseBtn.Text = "Close"
        '
        'PersistentRepository2
        '
        Me.PersistentRepository2.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.IONOLookUpEdit, Me.ContractLookUpEdit})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit2.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'IONOLookUpEdit
        '
        Me.IONOLookUpEdit.Name = "IONOLookUpEdit"
        Me.IONOLookUpEdit.Properties.AllowFocused = False
        Me.IONOLookUpEdit.Properties.AutoHeight = False
        Me.IONOLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.IONOLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.IONOLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.IONOLookUpEdit.Properties.NullString = ""
        '
        'ContractLookUpEdit
        '
        Me.ContractLookUpEdit.Name = "ContractLookUpEdit"
        Me.ContractLookUpEdit.Properties.AllowFocused = False
        Me.ContractLookUpEdit.Properties.AutoHeight = False
        Me.ContractLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ContractLookUpEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContractLookUpEdit.Properties.ButtonsBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ContractLookUpEdit.Properties.NullString = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Attn :"
        '
        'AttnTxt
        '
        Me.AttnTxt.Location = New System.Drawing.Point(56, 40)
        Me.AttnTxt.Name = "AttnTxt"
        Me.AttnTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.AttnTxt.Size = New System.Drawing.Size(160, 19)
        Me.AttnTxt.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Date :"
        '
        'EditDate
        '
        Me.EditDate.DateTime = New Date(CType(0, Long))
        Me.EditDate.Location = New System.Drawing.Point(56, 16)
        Me.EditDate.Name = "EditDate"
        Me.EditDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EditDate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.EditDate.Size = New System.Drawing.Size(128, 23)
        Me.EditDate.TabIndex = 59
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'F28Grid
        '
        Me.F28Grid.EditorsRepository = Me.PersistentRepository2
        Me.F28Grid.Location = New System.Drawing.Point(8, 80)
        Me.F28Grid.MainView = Me.GridView1
        Me.F28Grid.Name = "F28Grid"
        Me.F28Grid.Size = New System.Drawing.Size(776, 296)
        Me.F28Grid.TabIndex = 86
        '
        'GridView1
        '
        Me.GridView1.BehaviorOptions = CType(((((((((((DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowFilter Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowZoomDetail) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.Editable) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableDetailToolTip) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.EnableMasterViewMode) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartDetailHeight) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.SmartVertScrollBar) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.UseTabKey) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowSort) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AllowGroup) _
                    Or DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags.AutoUpdateTotalSummary), DevExpress.XtraGrid.Views.Grid.BehaviorOptionsFlags)
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 16)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "* Pls double-click on gird to add IO"
        '
        'PrintNoticeBtn
        '
        Me.PrintNoticeBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintNoticeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintNoticeBtn.Image = Nothing
        Me.PrintNoticeBtn.Location = New System.Drawing.Point(576, 384)
        Me.PrintNoticeBtn.Name = "PrintNoticeBtn"
        Me.PrintNoticeBtn.Size = New System.Drawing.Size(112, 32)
        Me.PrintNoticeBtn.TabIndex = 88
        Me.PrintNoticeBtn.Text = "Print Notification"
        '
        'XtraButton1
        '
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(456, 384)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(112, 32)
        Me.XtraButton1.TabIndex = 89
        Me.XtraButton1.Text = "Save Notification"
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Delete})
        '
        'Delete
        '
        Me.Delete.Index = 0
        Me.Delete.Text = "Delete"
        '
        'LVBRequestF28Form
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 421)
        Me.Controls.Add(Me.XtraButton1)
        Me.Controls.Add(Me.PrintNoticeBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.F28Grid)
        Me.Controls.Add(Me.EditDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AttnTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.PrintF28Btn)
        Me.Name = "LVBRequestF28Form"
        Me.Text = "Request For LV Form"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IONOLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttnTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F28Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
	Dim dataGrid As DataTable=New DataTable("ColumnsTable")
    Public IO_Id As Integer
    Public Contract_Id As Integer
	Dim Attention_Name As String
    Dim Edit_Date As String
	Public FormType As String
	Private LVBds As DataSet

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub LVBRequestF28Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FormType = "F28" Then
            PrintF28Btn.Visible = True
            PrintF28Btn.Enabled = True
            PrintNoticeBtn.Visible = False
            PrintNoticeBtn.Enabled = False
            XtraButton1.Text = "Save LV Form"
        Else
			PrintF28Btn.Visible = False
            PrintF28Btn.Enabled = False
            PrintNoticeBtn.Visible = True
            PrintNoticeBtn.Enabled = True
            XtraButton1.Text = "Save Notification"
        End If

        EditDate.DateTime = Date.Today
		InitList()
		If EditDate.Text <> "" Then
			'LoadContract()
			LoadLVBPrintNotificationList(EditDate.DateTime)
			'LoadIONo(0, 10)
		End If
    End Sub

    Private Sub F28Grid_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles F28Grid.DoubleClick
		Dim NewForm As New SelectContractForF28Form
		NewForm.ShowDialog(Me)
		IO_Id = NewForm.IO_Id
		InitGrid()
	End Sub

	Private Sub InitList()
		dataGrid.BeginInit()
		AddColumn(dataGrid, "IO_Id", System.Type.GetType("System.Int32"), True)
		AddColumn(dataGrid, "Contract_Id", System.Type.GetType("System.Int32"), True)
		AddColumn(dataGrid, "Contract No", System.Type.GetType("System.String"), True)
		AddColumn(dataGrid, "IO No", System.Type.GetType("System.String"), True)
		F28Grid.DataSource = dataGrid
		F28Grid.MainView.PopulateColumns()
		GridView1.Columns.Item(0).VisibleIndex = -1
		GridView1.Columns.Item(1).VisibleIndex = -1
		GridView1.BestFitColumns()
	End Sub

	Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
		Dim col As New DataColumn(name, type)
		col.Caption = name
		col.ReadOnly = ro

		data1.Columns.Add(col)
	End Sub

	Private Sub InitGrid()
		If IO_Id <> Nothing And IO_Id <> 0 Then
			Dim ds As DataSet
			With New BusinessRules.LVBBusRules.LVBBusLogic
				If .GetIO(ds, IO_Id) Then
					If Not ds Is Nothing Then
						Try
							Dim oRow As DataRow
							Dim i As Integer = 0
							For Each oRow In ds.Tables(0).Rows
								dataGrid.Rows.Add(New Object() {oRow("IO_Id"), oRow("Contract_Id"), _
							oRow("Contract_No"), oRow("IO_No")})
							Next
							
							F28Grid.DataSource = dataGrid
							F28Grid.DefaultView.PopulateColumns()
							'GridView1.BestFitColumns()

						Catch exLoad As System.Exception
							System.Windows.Forms.MessageBox.Show(exLoad.Message)
						End Try
					End If
				End If
			End With
		End If

		GridView1.Columns.Item(0).VisibleIndex = -1
		GridView1.Columns.Item(1).VisibleIndex = -1
	End Sub

	Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintF28Btn.Click
		Dim i As Integer
		Dim StrIO_ID
		Dim dr As DataRow
		Dim items As Object()

		RetrieveFromForm()
        If ValidData() Then

            Dim FieldName As String
            'Check for pending TOC
            If CheckPendingToc() = True Then
                FieldName = "Printing of Notification is not allowed:" & Chr(13)
                FieldName = FieldName & "There are one or more Pending TOC(s) by one or more Officer(s) " & Chr(13)
                MessageBox.Show(FieldName, "Printing disallowed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            GridView1.UpdateCurrentRow()
            GridView1.CloseEditor()

            If GridView1.RowCount > 0 Then
                For i = 0 To dataGrid.Rows.Count - 1
                    dr = GridView1.GetDataRow(i)
                    items = dr.ItemArray

                    StrIO_ID = StrIO_ID & items(0) & ","
                Next
                Dim slen
                slen = Len(StrIO_ID)
                StrIO_ID = Microsoft.VisualBasic.Left(StrIO_ID, slen - 1)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New LVBF28ReportForm(StrIO_ID, Attention_Name, Edit_Date)
                page = New Crownwood.Magic.Controls.TabPage("Print Request LV Form", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    'Returns true if there are Pending TOC 
    Function CheckPendingToc() As Boolean

        With New BusinessRules.LVBBusRules.LVBBusLogic
            If .CheckPendingTOC(Nothing, Contract_Id, EditDate.Text) = True Then
                Return True
            End If
        End With

        Return False

    End Function


	Private Sub PrintNoticeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNoticeBtn.Click
		Dim i As Integer
		Dim StrIO_ID
		Dim dr As DataRow
		Dim items As Object()

        If FormType = "F28" Then
            SaveF28()
        Else
            SaveNotification()
        End If

        RetrieveFromForm()
        If ValidData() Then
            GridView1.UpdateCurrentRow()
            GridView1.CloseEditor()

            If GridView1.RowCount > 0 Then
                For i = 0 To dataGrid.Rows.Count - 1
                    dr = GridView1.GetDataRow(i)
                    items = dr.ItemArray

                    StrIO_ID = StrIO_ID & items(0) & ","
                Next
                Dim slen
                slen = Len(StrIO_ID)
                StrIO_ID = Microsoft.VisualBasic.Left(StrIO_ID, slen - 1)

                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                controlToAdd = New NotificationLVBInstallRptForm(StrIO_ID, Edit_Date)
                page = New Crownwood.Magic.Controls.TabPage("Print Notification", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub RetrieveFromForm()
        Attention_Name = AttnTxt.Text
        Edit_Date = EditDate.Text
    End Sub

    Private Function ValidData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(Attention_Name) > 0 Then
            DataOK_Flag = False
            FieldName = "Attention Name" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function

    Private Sub LVBRequestF28Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton1.Click
        If FormType = "F28" Then
            SaveF28()
        Else
            SaveNotification()
        End If
    End Sub


    Private Function SaveNotification() As Boolean
        Dim savestatus As Boolean = False
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()

        If GridView1.RowCount > 0 Then
            With New BusinessRules.LVBBusRules.LVBBusLogic

                .Transact_Date = EditDate.Text
                .DeleteLVBNotification()

                'Dim dt As DataTable = GridView1.DataSource()
                For i As Integer = 0 To dataGrid.Rows.Count - 1
                    Dim dtsavestatus As Boolean = False
                    If dataGrid.Rows(i).RowState() = DataRowState.Deleted Then
                        'MessageBox.Show("Helo")
                    Else
                        If Not IsDBNull(dataGrid.Rows(i)("IO_Id")) Then
                            .IO_Id = dataGrid.Rows(i)("IO_Id")
                            dtsavestatus = True
                        End If

                        If Not IsDBNull(dataGrid.Rows(i)("Contract_Id")) Then
                            .Contract_Id = dataGrid.Rows(i)("Contract_Id")
                            dtsavestatus = True
                        End If

                    End If
                    'If Not IsDBNull(LVBds.Tables(0).Rows(i)("Contractor_ID")) Then
                    '.Contractor_Id = LVBds.Tables(0).Rows(i)("Contractor_ID")
                    '.Contractor_Id = Contract_Id
                    'dtsavestatus = True
                    'End If

                    .Transact_Date = EditDate.Text
                    .UserID = Common.CommonConn.Config.USERID
                    If dtsavestatus = True Then
                        If .SaveLVBNotification() Then
                            'MessageBox.Show("Notification saved", "LVB Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Error saving notification", "LVB Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next

            End With
        End If

        Return savestatus

    End Function

    Private Function SaveF28() As Boolean
        Dim savestatus As Boolean = False
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()

        If GridView1.RowCount > 0 Then
            With New BusinessRules.LVBBusRules.LVBBusLogic

                .Transact_Date = EditDate.Text
                .DeleteLVBF28()

                'Dim dt As DataTable = GridView1.DataSource()
                For i As Integer = 0 To dataGrid.Rows.Count - 1
                    Dim dtsavestatus As Boolean = False
                    If dataGrid.Rows(i).RowState() = DataRowState.Deleted Then
                        'MessageBox.Show("Helo")
                    Else
                        If Not IsDBNull(dataGrid.Rows(i)("IO_Id")) Then
                            .IO_Id = dataGrid.Rows(i)("IO_Id")
                            dtsavestatus = True
                        End If

                        If Not IsDBNull(dataGrid.Rows(i)("Contract_Id")) Then
                            .Contract_Id = dataGrid.Rows(i)("Contract_Id")
                            dtsavestatus = True
                        End If

                    End If
                    'If Not IsDBNull(LVBds.Tables(0).Rows(i)("Contractor_ID")) Then
                    '.Contractor_Id = LVBds.Tables(0).Rows(i)("Contractor_ID")
                    '.Contractor_Id = Contract_Id
                    'dtsavestatus = True
                    'End If

                    .Transact_Date = EditDate.Text
                    .UserID = Common.CommonConn.Config.USERID
                    If dtsavestatus = True Then
                        If .SaveLVBF28() Then
                            'MessageBox.Show("Notification saved", "LVB Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Error saving notification", "LVB Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next

            End With
        End If

        Return savestatus

    End Function

    Private Sub LoadLVBPrintNotificationList(ByVal pTransactDate As Date)
        With New BusinessRules.LVBBusRules.LVBBusLogic

            dataGrid.Rows.Clear()
            If FormType = "F28" Then
                If .GetLVBF28(LVBds, pTransactDate) Then
                    Dim dv As DataView
                    dv = LVBds.Tables(0).DefaultView

                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    For Each oRow In LVBds.Tables(0).Rows
                        dataGrid.Rows.Add(New Object() {oRow("IO_Id"), oRow("Contract_Id"), _
                          oRow("Contract_No"), oRow("IO_No")})
                    Next

                    F28Grid.DataSource = dataGrid
                    F28Grid.DefaultView.PopulateColumns()
                    'GridView1.BestFitColumns()

                    GridView1.Columns.Item(0).VisibleIndex = -1
                    GridView1.Columns.Item(1).VisibleIndex = -1

                    'dv.Table.Columns.Add("LVB_Location", System.Type.GetType("System.String"))
                    'dv.Table.Columns.Add("MRC_No", System.Type.GetType("System.String"))
                    'dv.Table.Columns.Add("Officer_Name", System.Type.GetType("System.String"))
                    'dv.Table.Columns.Add("Section_Code", System.Type.GetType("System.String"))
                    'F28Grid.DataSource = dv

                End If
            Else
                If .GetLVBNotification(LVBds, pTransactDate) Then
                    Dim dv As DataView
                    dv = LVBds.Tables(0).DefaultView

                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    For Each oRow In LVBds.Tables(0).Rows
                        dataGrid.Rows.Add(New Object() {oRow("IO_Id"), oRow("Contract_Id"), _
                          oRow("Contract_No"), oRow("IO_No")})
                    Next

                    F28Grid.DataSource = dataGrid
                    F28Grid.DefaultView.PopulateColumns()
                    'GridView1.BestFitColumns()

                    GridView1.Columns.Item(0).VisibleIndex = -1
                    GridView1.Columns.Item(1).VisibleIndex = -1

                    'dv.Table.Columns.Add("LVB_Location", System.Type.GetType("System.String"))
                    'dv.Table.Columns.Add("MRC_No", System.Type.GetType("System.String"))
                    'dv.Table.Columns.Add("Officer_Name", System.Type.GetType("System.String"))
                    'dv.Table.Columns.Add("Section_Code", System.Type.GetType("System.String"))
                    'F28Grid.DataSource = dv

                End If

            End If

        End With
    End Sub

    Private Sub F28Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles F28Grid.MouseUp
        Dim mouseDownLocation As New Point(e.X, e.Y)

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
    End Sub

    Private Sub Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim Row As Integer = GridView1.GetSelectedRows(0)
        GridView1.DeleteRow(Row)
    End Sub

    Private Sub EditDate_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles EditDate.CloseUp
        If EditDate.Text <> "" Then
            LoadContract()
            F28Grid.Enabled = True
            LoadLVBPrintNotificationList(e.Value)
        Else
            F28Grid.Enabled = False
        End If
        'LoadIONo(1, Contract_Id)
    End Sub

    Private Sub LoadIONo(ByVal addflag As Integer, ByVal pContract_Id As Integer)
        Dim ds As DataSet

        With New BusinessRules.LVBBusRules.LVBBusLogic
            If Len(pContract_Id) > 0 Then
                .Contract_Id = pContract_Id
                If .GetIOWContractId(ds) Then
                    If Not ds Is Nothing Then
                        'IONOLookUpEdit.Properties.BeginUpdate()
                        IONOLookUpEdit.Properties.LookUpData.ListFields.Clear()
                        AddListFieldInfoToRepositoryLookUp(IONOLookUpEdit, "IO_No", 400, 0, "c")
                        IONOLookUpEdit.Properties.LookUpData.KeyField = "IO_Id"
                        IONOLookUpEdit.Properties.LookUpData.DisplayField = "IO_No"
                        IONOLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                        'IONOLookUpEdit.Properties.EndUpdate()
                        'GridView1.UpdateColumnsCustomization()
                    End If
                End If
            End If
        End With
    End Sub
    Private Sub LoadContract()
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            If .GetLVBContract(ds) Then
                If Not ds Is Nothing Then
                    ContractLookUpEdit.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToRepositoryLookUp(ContractLookUpEdit, "Contract_No", 400, 0, "c")
                    ContractLookUpEdit.Properties.LookUpData.KeyField = "Contract_Id"
                    ContractLookUpEdit.Properties.LookUpData.DisplayField = "Contract_No"
                    ContractLookUpEdit.Properties.LookUpData.DataSource = ds.Tables(0)
                End If
            End If

        End With
    End Sub

    Private Sub AddListFieldInfoToRepositoryLookUp(ByVal le As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToRepositoryLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub IONOLookUpEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles IONOLookUpEdit.Click

    End Sub

    Private Sub ContractLookUpEdit_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles ContractLookUpEdit.CloseUp

    End Sub

    Private Sub ContractLookUpEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContractLookUpEdit.ValueChanged

    End Sub

    Private Sub ContractLookUpEdit_ValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles ContractLookUpEdit.ValueChanging

    End Sub

    Private Sub IONOLookUpEdit_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles IONOLookUpEdit.Enter

        'Dim i
        'i = GridView1.GetSelectedRows(0)
        'LoadIONo(0, LVBds.Tables(0).Rows(i)("Contract_Id"))
    End Sub

    Private Sub ContractLookUpEdit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContractLookUpEdit.Leave

    End Sub
End Class
