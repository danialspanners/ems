Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class PRList
    Inherits System.Windows.Forms.Form

    Private gsiSummary As GridSummaryItems

    Public UserID As String = Common.CommonConn.Config.USERID
    Public com As New Common.CommonConn.Config

    Public dataGrid As System.Data.DataTable
    Public Transaction_ID As Integer
    Public FormType As String
    Private DocNo As String
    Private Edited As Boolean
    Private LoadPRID As Integer

    Private AddButtonOldState As Boolean
    Private EditButtonOldState As Boolean
    Private DeleteButtonOldState As Boolean
    Private ImportMenuOldState As Boolean
    Private Button4OldState As Boolean
    Private GridControl1OldState As Boolean

    Private WO_TextEdit_Old As String
    Private WO_RadioButton_Old As Boolean
    Private OC_RadioButton_Old As Boolean
    Private FT_RadioButton_Old As Boolean
    Private ST_RadioButton_Old As Boolean
    Private StatusLookup_Old As Object
    Private MemoEdit_Old As String
    Private ApprovedByLookUp_Old As Object
    Private PRApprovedByLookUp_Old As Object
    Private ReqByLookup_Old As Object

    Private OnLoading As Boolean
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository3 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository4 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository5 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents ImportMenu As System.Windows.Forms.MenuItem
    Friend WithEvents PersistentRepository6 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Import_Button As System.Windows.Forms.Button
    Friend WithEvents PersistentRepository7 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository8 As DevExpress.XtraEditors.Repository.PersistentRepository
    Private FromApprovalForm As Boolean


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        LoadPRID = 0

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pFormType As String)
        MyBase.New()

        LoadPRID = 0

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        DisableEntry()

        Edited = False
        OnLoading = False

        Me.InitalUserCombo()

        InitStatusLookUp()

        If pFormType = "SALES" Then
            Me.SetSalesForm()
        ElseIf pFormType = "FT" Then
            Me.SetFactoryForm()
        ElseIf pFormType = "PROJ" Then
            Me.SetProjectForm()
        ElseIf pFormType = "STORE" Then
            Me.SetStoreForm()
        End If


    End Sub

    Public Sub New(ByVal PR_ID As Integer, Optional ByVal pFromApprovalForm As Boolean = False)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        DisableEntry()

        Edited = False
        OnLoading = False
        FromApprovalForm = pFromApprovalForm

        Me.InitalUserCombo()

        InitStatusLookUp()
        LoadPRID = PR_ID
        LoadPR(LoadPRID)

        Button1.Visible = False 'hide new
        Button4.Visible = False 'hide delete

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents WO_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Remarks_MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents StatusLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ReqByLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ApprovedByLookUp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Store_Button As System.Windows.Forms.Button
    Friend WithEvents WO_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OC_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FT_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ST_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LastUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Print_Button As System.Windows.Forms.Button
    Friend WithEvents Reserve_Button As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PRApprovedByLookUp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Button5 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRList))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button7 = New System.Windows.Forms.Button
        Me.PRApprovedByLookUp = New DevExpress.XtraEditors.LookUpEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.StatusLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.LastUpdate = New System.Windows.Forms.TextBox
        Me.FT_RadioButton = New System.Windows.Forms.RadioButton
        Me.OC_RadioButton = New System.Windows.Forms.RadioButton
        Me.WO_RadioButton = New System.Windows.Forms.RadioButton
        Me.ApprovedByLookUp = New DevExpress.XtraEditors.LookUpEdit
        Me.ReqByLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Remarks_MemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Store_Button = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.WO_TextEdit = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.ST_RadioButton = New System.Windows.Forms.RadioButton
        Me.NewDoc = New DevExpress.XtraEditors.TextEdit
        Me.SRVNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Submit_Button = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Import_Button = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.EditButton = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Print_Button = New System.Windows.Forms.Button
        Me.Print2_Button = New System.Windows.Forms.Button
        Me.Reserve_Button = New System.Windows.Forms.Button
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository7 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PersistentRepository8 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository6 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository5 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository4 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository3 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ComponentContextMenu = New System.Windows.Forms.ContextMenu
        Me.AddMenu = New System.Windows.Forms.MenuItem
        Me.EditMenu = New System.Windows.Forms.MenuItem
        Me.DeleteMenu = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.ImportMenu = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PRApprovedByLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedByLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remarks_MemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.WO_TextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRVNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.PRApprovedByLookUp)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.StatusLookup)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LastUpdate)
        Me.Panel1.Controls.Add(Me.FT_RadioButton)
        Me.Panel1.Controls.Add(Me.OC_RadioButton)
        Me.Panel1.Controls.Add(Me.WO_RadioButton)
        Me.Panel1.Controls.Add(Me.ApprovedByLookUp)
        Me.Panel1.Controls.Add(Me.ReqByLookup)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Remarks_MemoEdit)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.WO_TextEdit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ST_RadioButton)
        Me.Panel1.Controls.Add(Me.NewDoc)
        Me.Panel1.Controls.Add(Me.SRVNoCmb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 194)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(247, 7)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(59, 23)
        Me.Button7.TabIndex = 45
        Me.Button7.Text = "Search"
        '
        'PRApprovedByLookUp
        '
        Me.PRApprovedByLookUp.Location = New System.Drawing.Point(458, 118)
        Me.PRApprovedByLookUp.Name = "PRApprovedByLookUp"
        Me.PRApprovedByLookUp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PRApprovedByLookUp.Properties.NullString = ""
        Me.PRApprovedByLookUp.Size = New System.Drawing.Size(112, 19)
        Me.PRApprovedByLookUp.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(458, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Dept Approved By"
        '
        'StatusLookup
        '
        Me.StatusLookup.Location = New System.Drawing.Point(336, 70)
        Me.StatusLookup.Name = "StatusLookup"
        Me.StatusLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StatusLookup.Properties.NullString = ""
        Me.StatusLookup.Properties.PopupWidth = 168
        Me.StatusLookup.Properties.ReadOnly = True
        Me.StatusLookup.Size = New System.Drawing.Size(102, 19)
        Me.StatusLookup.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(298, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 23)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Status"
        '
        'LastUpdate
        '
        Me.LastUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastUpdate.Enabled = False
        Me.LastUpdate.Location = New System.Drawing.Point(458, 28)
        Me.LastUpdate.Name = "LastUpdate"
        Me.LastUpdate.Size = New System.Drawing.Size(100, 20)
        Me.LastUpdate.TabIndex = 41
        '
        'FT_RadioButton
        '
        Me.FT_RadioButton.Location = New System.Drawing.Point(240, 38)
        Me.FT_RadioButton.Name = "FT_RadioButton"
        Me.FT_RadioButton.Size = New System.Drawing.Size(88, 24)
        Me.FT_RadioButton.TabIndex = 39
        Me.FT_RadioButton.Text = "Factory used"
        '
        'OC_RadioButton
        '
        Me.OC_RadioButton.Location = New System.Drawing.Point(124, 38)
        Me.OC_RadioButton.Name = "OC_RadioButton"
        Me.OC_RadioButton.Size = New System.Drawing.Size(50, 24)
        Me.OC_RadioButton.TabIndex = 38
        Me.OC_RadioButton.Text = "OC"
        '
        'WO_RadioButton
        '
        Me.WO_RadioButton.Location = New System.Drawing.Point(70, 38)
        Me.WO_RadioButton.Name = "WO_RadioButton"
        Me.WO_RadioButton.Size = New System.Drawing.Size(50, 24)
        Me.WO_RadioButton.TabIndex = 37
        Me.WO_RadioButton.Text = "WO"
        '
        'ApprovedByLookUp
        '
        Me.ApprovedByLookUp.Location = New System.Drawing.Point(458, 158)
        Me.ApprovedByLookUp.Name = "ApprovedByLookUp"
        Me.ApprovedByLookUp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ApprovedByLookUp.Properties.NullString = ""
        Me.ApprovedByLookUp.Size = New System.Drawing.Size(112, 19)
        Me.ApprovedByLookUp.TabIndex = 36
        '
        'ReqByLookup
        '
        Me.ReqByLookup.Location = New System.Drawing.Point(458, 78)
        Me.ReqByLookup.Name = "ReqByLookup"
        Me.ReqByLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ReqByLookup.Properties.NullString = ""
        Me.ReqByLookup.Properties.ReadOnly = True
        Me.ReqByLookup.Size = New System.Drawing.Size(112, 19)
        Me.ReqByLookup.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(458, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "PD Approving person"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(458, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Requested By"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(458, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Last updated"
        '
        'Remarks_MemoEdit
        '
        Me.Remarks_MemoEdit.Location = New System.Drawing.Point(64, 100)
        Me.Remarks_MemoEdit.Name = "Remarks_MemoEdit"
        Me.Remarks_MemoEdit.Size = New System.Drawing.Size(374, 80)
        Me.Remarks_MemoEdit.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Store_Button)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(576, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 194)
        Me.Panel4.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(14, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 46)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Set Delivery Date"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Reload"
        '
        'Store_Button
        '
        Me.Store_Button.Enabled = False
        Me.Store_Button.Location = New System.Drawing.Point(16, 122)
        Me.Store_Button.Name = "Store_Button"
        Me.Store_Button.Size = New System.Drawing.Size(75, 23)
        Me.Store_Button.TabIndex = 6
        Me.Store_Button.Text = "Check Store"
        Me.Store_Button.Visible = False
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(382, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "New"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PR #:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Remarks :"
        '
        'WO_TextEdit
        '
        Me.WO_TextEdit.Location = New System.Drawing.Point(66, 68)
        Me.WO_TextEdit.Name = "WO_TextEdit"
        Me.WO_TextEdit.Size = New System.Drawing.Size(220, 21)
        Me.WO_TextEdit.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "WO/OC #:"
        '
        'ST_RadioButton
        '
        Me.ST_RadioButton.Location = New System.Drawing.Point(180, 38)
        Me.ST_RadioButton.Name = "ST_RadioButton"
        Me.ST_RadioButton.Size = New System.Drawing.Size(88, 24)
        Me.ST_RadioButton.TabIndex = 40
        Me.ST_RadioButton.Text = "Stock"
        '
        'NewDoc
        '
        Me.NewDoc.Location = New System.Drawing.Point(62, 8)
        Me.NewDoc.Name = "NewDoc"
        Me.NewDoc.Size = New System.Drawing.Size(179, 21)
        Me.NewDoc.TabIndex = 0
        Me.NewDoc.Visible = False
        '
        'SRVNoCmb
        '
        Me.SRVNoCmb.Location = New System.Drawing.Point(64, 8)
        Me.SRVNoCmb.Name = "SRVNoCmb"
        Me.SRVNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SRVNoCmb.Properties.DropDownRows = 50
        Me.SRVNoCmb.Properties.NullString = ""
        Me.SRVNoCmb.Properties.PopupWidth = 210
        Me.SRVNoCmb.Size = New System.Drawing.Size(177, 19)
        Me.SRVNoCmb.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Status :"
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(10, 14)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(80, 23)
        Me.Submit_Button.TabIndex = 5
        Me.Submit_Button.Text = "Submit"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Import_Button)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Controls.Add(Me.DeleteButton)
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Print2_Button)
        Me.Panel2.Controls.Add(Me.Reserve_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 51)
        Me.Panel2.TabIndex = 1
        '
        'Import_Button
        '
        Me.Import_Button.Enabled = False
        Me.Import_Button.Location = New System.Drawing.Point(363, 14)
        Me.Import_Button.Name = "Import_Button"
        Me.Import_Button.Size = New System.Drawing.Size(75, 23)
        Me.Import_Button.TabIndex = 6
        Me.Import_Button.Text = "Import..."
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(312, 36)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Unreserve"
        Me.Button6.Visible = False
        '
        'EditButton
        '
        Me.EditButton.Enabled = False
        Me.EditButton.Location = New System.Drawing.Point(270, 14)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Text = "Edit Price"
        Me.EditButton.Visible = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(100, 14)
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
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Print_Button)
        Me.Panel3.Controls.Add(Me.Submit_Button)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(454, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 51)
        Me.Panel3.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(156, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Close"
        '
        'Print_Button
        '
        Me.Print_Button.Enabled = False
        Me.Print_Button.Location = New System.Drawing.Point(96, 14)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(52, 23)
        Me.Print_Button.TabIndex = 0
        Me.Print_Button.Text = "Print"
        '
        'Print2_Button
        '
        Me.Print2_Button.Location = New System.Drawing.Point(394, 34)
        Me.Print2_Button.Name = "Print2_Button"
        Me.Print2_Button.Size = New System.Drawing.Size(75, 23)
        Me.Print2_Button.TabIndex = 2
        Me.Print2_Button.Text = "Rec. Vou"
        Me.Print2_Button.Visible = False
        '
        'Reserve_Button
        '
        Me.Reserve_Button.Location = New System.Drawing.Point(186, 14)
        Me.Reserve_Button.Name = "Reserve_Button"
        Me.Reserve_Button.Size = New System.Drawing.Size(75, 23)
        Me.Reserve_Button.TabIndex = 4
        Me.Reserve_Button.Text = "Reserve"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EditorsRepository = Me.PersistentRepository8
        Me.GridControl1.Location = New System.Drawing.Point(0, 194)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(676, 218)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.Text = "GridControl1"
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
        Me.GridView1.VertScrollTipFieldName = Nothing
        Me.GridView1.ViewOptions = CType((((((((DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.AutoWidth Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowColumns) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFilterPanel) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowHorzLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowIndicator) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowVertLines) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowDetailButtons) _
                    Or DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.SingleFocusStyle), DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'ComponentContextMenu
        '
        Me.ComponentContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AddMenu, Me.EditMenu, Me.DeleteMenu, Me.MenuItem1, Me.ImportMenu})
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
        Me.EditMenu.Visible = False
        '
        'DeleteMenu
        '
        Me.DeleteMenu.Index = 2
        Me.DeleteMenu.Text = "Delete"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "-"
        '
        'ImportMenu
        '
        Me.ImportMenu.Index = 4
        Me.ImportMenu.Text = "Import items..."
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'PRList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(676, 463)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "PRList"
        Me.Text = "PR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PRApprovedByLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedByLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReqByLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remarks_MemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.WO_TextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRVNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Function CreateDocNo() As String
        Dim DocumentNo As String

        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            'DocumentNo = NewDoc.Text
            If FormType = "SALES" Then
                DocumentNo = .GetDocumentNextNumber("PRS", Year(Now), 0, "S")
                'CreateSRVNo = "S" & DocumentNo
            ElseIf FormType = "FT" Then
                DocumentNo = .GetDocumentNextNumber("PRF", Year(Now), 0, "F")
                'CreateSRVNo = "F" & DocumentNo
            ElseIf FormType = "PROJ" Then
                DocumentNo = .GetDocumentNextNumber("PRP", Year(Now), 0, "P")
                'CreateSRVNo = "P" & DocumentNo
            ElseIf FormType = "STORE" Then
                DocumentNo = .GetDocumentNextNumber("PRI", Year(Now), 0, "I")
                'CreateSRVNo = "I" & DocumentNo
            End If

            CreateDocNo = DocumentNo

        End With


    End Function

    Public Function SetSalesForm()
        FormType = "SALES"
        Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing
        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, FormType) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "PR_NO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "PR_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "PR_NO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "PR #:"
    End Function
    Public Function SetProjectForm()
        FormType = "PROJ"
        Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing
        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, FormType) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "PR_NO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "PR_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "PR_NO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "PR #:"
    End Function
    Public Function SetFactoryForm()
        FormType = "FT"
        Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing
        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, FormType) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "PR_NO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "PR_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "PR_NO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "PR #:"
    End Function
    Public Function SetStoreForm()
        FormType = "STORE"
        Dim ds As DataSet
        SRVNoCmb.Properties.LookUpData.ListFields.Clear()
        SRVNoCmb.Properties.LookUpData.DataSource = Nothing
        SRVNoCmb.Properties.LookUpData.KeyValue = Nothing
        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, FormType) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SRVNoCmb, "PR_NO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "PR_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "PR_NO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With
        Label1.Text = "PR #:"
    End Function

    Private Sub StockOutSRVForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'LoadPR(LoadPRID)
        'InitItemList()
        'DefaultGridView()

        Me.SRVNoCmb.Focus()

    End Sub

    Private Sub DefaultGridView()

        GridView1.Columns("Product").Width = 150
        GridView1.Columns("Description").Width = 143
        GridView1.Columns("Unit").Width = 50
        GridView1.Columns("Qty Req.").Width = 50
        GridView1.Columns("Stock Res.").Width = 50
        GridView1.Columns("Qty Ord.").Width = 50
        GridView1.Columns("Del. Date").Width = 113
        GridView1.Columns("Supplier").Width = 83
        GridView1.Columns("PO no.").Width = 83
        GridView1.Columns("Enq. Price").Width = 50
        GridView1.Columns("Act. Price").Width = 50

    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Stat As Boolean

        Stat = False

        If Button1.Text = "New" Then

            InitStatusLookUp()

            DocNo = CreateDocNo()
            NewDoc.Properties.ReadOnly = True
            NewDoc.Text = DocNo
            Me.NewDoc.Visible = True
            Me.SRVNoCmb.Visible = False
            NewDoc.Focus()
            Button1.Text = "Ok"
            Button4.Text = "Cancel"

            Me.WO_TextEdit.Text = ""
            Me.Remarks_MemoEdit.Text = ""
            Me.StatusLookup.Properties.LookUpData.KeyValue = "10"
            Me.ReqByLookup.Properties.LookUpData.KeyValue = Me.UserID
            Me.ApprovedByLookUp.Properties.LookUpData.KeyValue = Nothing
            Me.PRApprovedByLookUp.Properties.LookUpData.KeyValue = Nothing

            Me.GridControl1OldState = GridControl1.Enabled
            Button4OldState = Button4.Enabled
            AddButtonOldState = AddButton.Enabled
            DeleteButtonOldState = DeleteButton.Enabled
            EditButtonOldState = EditButton.Enabled

            Button4.Enabled = True
            GridControl1.Enabled = False
            AddButton.Enabled = False
            Submit_Button.Enabled = False
            DeleteButton.Enabled = False
            Reserve_Button.Enabled = False
            EditButton.Enabled = False
            Print2_Button.Enabled = False

            'Me.WO_TextEdit.Enabled = True
            'Me.Remarks_MemoEdit.Enabled = True
            'Me.ReqByLookup.Enabled = True
            'Me.WO_RadioButton.Enabled = True
            'Me.OC_RadioButton.Enabled = True
            'Me.FT_RadioButton.Enabled = True
            'Me.ST_RadioButton.Enabled = True

            Me.WriteEntry()

            If FormType = "SALES" Then
                Me.OC_RadioButton.Checked = True
            ElseIf FormType = "FT" Then
                Me.FT_RadioButton.Checked = True
            ElseIf FormType = "PROJ" Then
                Me.WO_RadioButton.Checked = True
            ElseIf FormType = "STORE" Then
                Me.ST_RadioButton.Checked = True
            End If

        Else
            If Button1.Text = "Update" Then
                Stat = UpdatePR()

                Edited = False

                Button1.Text = "New"
                'Button4.Visible = False
                Button4.Text = "Delete"
                GridControl1.Enabled = True
                AddButton.Enabled = True
                Submit_Button.Enabled = True
                AddMenu.Enabled = True

                Me.NewDoc.Visible = False
                Me.NewDoc.Properties.ReadOnly = False
                Me.NewDoc.Text = ""
                Me.SRVNoCmb.Visible = True

            Else
                Stat = Me.CreateNewDoc()
                If Stat = True Then
                    LoadPR(LoadPRID)
                    NewDoc.Visible = False
                    Me.SRVNoCmb.Visible = True
                    Button1.Text = "New"
                    'Button4.Visible = False
                    Button4.Text = "Delete"
                    GridControl1.Enabled = True
                    Print_Button.Enabled = True
                    AddButton.Enabled = True
                    Submit_Button.Enabled = True
                    AddMenu.Enabled = True
                    AddMenu_Click(sender, e)
                End If
            End If
        End If

        'SRVNoCmb.Text = SRVNO

    End Sub

    Private Sub NewPR()
        'NEW SRV
        Dim LastID As Integer
        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            .PR_No = DocNo
            .UserID = UserID
            .Grp = FormType

            .Refno = Me.WO_TextEdit.Text
            If Me.WO_RadioButton.Checked = True Then
                .RefType = "WO"
            ElseIf Me.OC_RadioButton.Checked = True Then
                .RefType = "OC"
            ElseIf Me.FT_RadioButton.Checked = True Then
                .RefType = "FT"
            ElseIf Me.ST_RadioButton.Checked = True Then
                .RefType = "ST"
            End If

            .Status = Me.StatusLookup.Properties.LookUpData.KeyValue
            .Remarks = Me.Remarks_MemoEdit.Text
            .Requester = Me.ReqByLookup.Properties.LookUpData.KeyValue
            .PRApprover = Me.PRApprovedByLookUp.Properties.LookUpData.KeyValue
            .Approver = Me.ApprovedByLookUp.Properties.LookUpData.KeyValue
            .UserID = UserID

            LastID = .Save()

            With New BusinessRules.CommonBusRules.CommonLogic
                If FormType = "SALES" Then
                    .UpdateDocumentNextNumber("PRS", Year(Now))
                ElseIf FormType = "FT" Then
                    .UpdateDocumentNextNumber("PRF", Year(Now))
                ElseIf FormType = "PROJ" Then
                    .UpdateDocumentNextNumber("PRP", Year(Now))
                ElseIf FormType = "STORE" Then
                    .UpdateDocumentNextNumber("PRI", Year(Now))
                End If
            End With


        End With

        Dim ds As DataSet
        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, FormType) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    SRVNoCmb.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(SRVNoCmb, "PR_NO", 400, 0, "c")
                    SRVNoCmb.Properties.LookUpData.KeyField = "PR_ID"
                    SRVNoCmb.Properties.LookUpData.DisplayField = "PR_NO"

                    SRVNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SRVNoCmb.EditValue = "0"
                End If
            End If
        End With

        'SRVNoCmb.Text = SRVNO
        SRVNoCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {LastID, 0, 0, 0})


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


    Private Sub InitItemList()

        dataGrid = New DataTable("ColumnsTable")
        dataGrid.BeginInit()

        AddColumn(dataGrid, "PR_Line", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Product_ID", System.Type.GetType("System.Int32"), True)
        AddColumn(dataGrid, "Product", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Description", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Unit", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Qty Req.", System.Type.GetType("System.Double"), True)
        AddColumn(dataGrid, "Stock Res.", System.Type.GetType("System.Double"), True)
        AddColumn(dataGrid, "Qty Ord.", System.Type.GetType("System.Double"), True)
        AddColumn(dataGrid, "Del. Date", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Supplier", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "PO no.", System.Type.GetType("System.String"), True)
        AddColumn(dataGrid, "Enq. Price", System.Type.GetType("System.Double"), True)
        AddColumn(dataGrid, "Act. Price", System.Type.GetType("System.Double"), True)


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
    Public Sub LoadPRItem()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim oRow As DataRow
        Dim i As Integer = 0
        Dim Status As String

        InitItemList()
        If Not SRVNoCmb.Properties.LookUpData.KeyValue Is Nothing Or LoadPRID <> 0 Then
            Dim prline As New BusinessRules.PRBusRules.PRLineBusLogic

            If LoadPRID <> 0 Then
                prline.LoadList(ds, LoadPRID)
            Else
                prline.LoadList(ds, SRVNoCmb.Properties.LookUpData.KeyValue)

            End If

            For Each oRow In ds.Tables(0).Rows
                dataGrid.Rows.Add(New Object() { _
                oRow("PR_Line"), _
                oRow("Product_ID"), _
                oRow("ProductName"), _
                oRow("Description"), _
                oRow("UnitName"), _
                oRow("Request_Qty"), _
                oRow("Stock_Reserved"), _
                oRow("Order_Qty"), _
                oRow("Delivery_Date"), _
                oRow("SupplierName"), _
                oRow("PO_NO"), _
                oRow("Enquiry_Price"), _
                oRow("Actual_Price")})
            Next

            GridControl1.DataSource = dataGrid
            GridControl1.DefaultView.PopulateColumns()

            'GridView1.BestFitColumns()
            Me.DefaultGridView()
            GridView1.Columns.Item(0).VisibleIndex = -1    'hide column
            GridView1.Columns.Item(1).VisibleIndex = -1    'hide column

        End If

        AddButton.Enabled = True
        Submit_Button.Enabled = True
        AddMenu.Enabled = True
        GridControl1.Enabled = True
        Button4.Enabled = True
        Me.Print_Button.Enabled = True

        Me.WO_TextEdit.Enabled = True
        Me.Remarks_MemoEdit.Enabled = True
        Me.ReqByLookup.Enabled = True
        Me.PRApprovedByLookUp.Enabled = True
        Me.ApprovedByLookUp.Enabled = True
        Me.WO_RadioButton.Enabled = True
        Me.OC_RadioButton.Enabled = True
        Me.FT_RadioButton.Enabled = True
        Me.ST_RadioButton.Enabled = True


        GridView1.Columns("Product").SummaryItem.SummaryType = SummaryItemType.Count

        GridView1.ViewOptions = GridView1.ViewOptions Or ViewOptionsFlags.ShowFooter


        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            GridClick()
            DeleteButton.Enabled = True
            Reserve_Button.Enabled = True
            Me.DeleteMenu.Enabled = True
            Me.ImportMenu.Enabled = True
            Me.Import_Button.Enabled = True
            EditButton.Enabled = True
            Me.EditMenu.Enabled = True
            Print2_Button.Enabled = True
        Else
            EditButton.Enabled = False
            Me.EditMenu.Enabled = False
            DeleteButton.Enabled = False
            Reserve_Button.Enabled = False
            Me.DeleteMenu.Enabled = False
            Me.ImportMenu.Enabled = False
            Me.Import_Button.Enabled = False
        End If

    End Sub

    Public Sub UpdateDate()
        With New BusinessRules.PRBusRules.PRHeaderBusLogic

            If .Load(SRVNoCmb.Properties.LookUpData.KeyValue) Then
                Me.LastUpdate.Text = ChangeDateFormat(.Transact_Date)
            End If
        End With

    End Sub

    Public Sub LoadPR(Optional ByVal PR_ID As Integer = 0)
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim LoadPRIDs As String

        OnLoading = True

        InitItemList()

        If (Not SRVNoCmb.Properties.LookUpData.KeyValue Is Nothing) Or PR_ID <> 0 Then

            'If .GetStockTransactionSRV(ds, ) Then
            With New BusinessRules.PRBusRules.PRHeaderBusLogic
                If PR_ID <> 0 Then
                    LoadPRIDs = PR_ID
                Else
                    LoadPRIDs = SRVNoCmb.Properties.LookUpData.KeyValue
                End If
                If .Load(LoadPRIDs) Then

                    If PR_ID <> 0 Then
                        NewDoc.Text = .PR_No
                        Me.NewDoc.Visible = True
                        Me.SRVNoCmb.Visible = False
                        Me.NewDoc.Properties.ReadOnly = True
                    End If

                    Me.WO_TextEdit.Text = .Refno

                    If .RefType = "WO" Then
                        Me.WO_RadioButton.Checked = True
                    ElseIf .RefType = "OC" Then
                        Me.OC_RadioButton.Checked = True
                    ElseIf .RefType = "FT" Then
                        Me.FT_RadioButton.Checked = True
                    ElseIf .RefType = "ST" Then
                        Me.ST_RadioButton.Checked = True
                    End If

                    Me.LastUpdate.Text = Me.ChangeDateFormat(.Transact_Date)

                    Me.StatusLookup.Properties.LookUpData.KeyValue = .Status


                    Me.Remarks_MemoEdit.Text = .Remarks

                    Me.ApprovedByLookUp.Properties.LookUpData.KeyValue = New Decimal(New Integer() {.Approver, 0, 0, 0})
                    Me.PRApprovedByLookUp.Properties.LookUpData.KeyValue = New Decimal(New Integer() {.PRApprover, 0, 0, 0})

                    Me.ReqByLookup.Properties.LookUpData.KeyValue = New Decimal(New Integer() {.Requester, 0, 0, 0})

                    Dim oRow As DataRow
                    Dim i As Integer = 0
                    Dim Status As String

                    'Dim prline As New BusinessRules.PRBusRules.PRLineBusLogic

                    'If PR_ID <> 0 Then
                    'prline.LoadList(ds, PR_ID)
                    'Else
                    '   prline.LoadList(ds, .PR_ID)
                    'End If

                    'For Each oRow In ds.Tables(0).Rows
                    'dataGrid.Rows.Add(New Object() { _
                    'oRow("PR_Line"), _
                    'oRow("Product_ID"), _
                    'oRow("ProductName"), _
                    'oRow("Description"), _
                    'oRow("UnitName"), _
                    'oRow("Request_Qty"), _
                    'oRow("Stock_Reserved"), _
                    'oRow("Order_Qty"), _
                    'oRow("Delivery_Date"), _
                    'oRow("SupplierName"), _
                    'oRow("PO_NO"), _
                    'oRow("Enquiry_Price"), _
                    'oRow("Actual_Price")})
                    'Next

                    'GridControl1.DataSource = dataGrid
                    'GridControl1.DefaultView.PopulateColumns()

                    'GridView1.BestFitColumns()
                    'Me.DefaultGridView()
                    'GridView1.Columns.Item(0).VisibleIndex = -1    'hide column
                    'GridView1.Columns.Item(1).VisibleIndex = -1    'hide column

                End If

            End With


            'AddButton.Enabled = True
            'Submit_Button.Enabled = True
            'AddMenu.Enabled = True
            'GridControl1.Enabled = True
            'Button4.Enabled = True
            'Me.Print_Button.Enabled = True

            'Me.WO_TextEdit.Enabled = True
            'Me.Remarks_MemoEdit.Enabled = True
            'Me.ReqByLookup.Enabled = True
            'Me.WO_RadioButton.Enabled = True
            'Me.OC_RadioButton.Enabled = True
            'Me.FT_RadioButton.Enabled = True
            'Me.ST_RadioButton.Enabled = True


            'GridView1.Columns("Product").SummaryItem.SummaryType = SummaryItemType.Count

            'GridView1.ViewOptions = GridView1.ViewOptions Or ViewOptionsFlags.ShowFooter


            'If GridView1.RowCount() <> 0 Then
            'GridView1.MoveFirst()
            'GridClick()
            'DeleteButton.Enabled = True
            'Reserve_Button.Enabled = True
            'Me.DeleteMenu.Enabled = True
            'EditButton.Enabled = True
            'Me.EditMenu.Enabled = True
            'Print2_Button.Enabled = True
            'Else
            'EditButton.Enabled = False
            'Me.EditMenu.Enabled = False
            'DeleteButton.Enabled = False
            'Reserve_Button.Enabled = False
            'Me.DeleteMenu.Enabled = False
            'End If

            Me.LoadPRItem()

            If (Me.StatusLookup.Properties.LookUpData.KeyValue = "10") Then
                Submit_Button.Text = "Submit"
                Submit_Button.Visible = True
                Me.WriteEntry()
                AddButton.Enabled = True
                Me.AddMenu.Enabled = True
                DeleteButton.Enabled = True
                Me.DeleteMenu.Enabled = True
                Me.ImportMenu.Enabled = True
                Me.Import_Button.Enabled = True
                Reserve_Button.Enabled = True
                Button4.Enabled = True
            ElseIf (Me.StatusLookup.Properties.LookUpData.KeyValue = "30") Then 'Pending
                If CheckApprovalAccess() = True And FromApprovalForm = True Then
                    Submit_Button.Text = "Approve"
                Else
                    Submit_Button.Text = "Pending"
                End If
                Submit_Button.Visible = True
                Me.ReadOnlyEntry()
                AddButton.Enabled = False
                Me.AddMenu.Enabled = False
                DeleteButton.Enabled = False
                Me.DeleteMenu.Enabled = False
                Me.ImportMenu.Enabled = False
                Me.Import_Button.Enabled = False
                Reserve_Button.Enabled = False
                Button4.Enabled = False
            ElseIf (Me.StatusLookup.Properties.LookUpData.KeyValue = "40") Then 'Approved Tmp

                Submit_Button.Visible = False

                If Me.CheckApprovalAccess() And Me.ApprovedByLookUp.Properties.LookUpData.KeyValue = UserID Then
                    Submit_Button.Text = "Cancel Approval"
                    Submit_Button.Visible = True
                End If

                Me.ReadOnlyEntry()
                AddButton.Enabled = False
                Me.AddMenu.Enabled = False
                DeleteButton.Enabled = False
                Me.DeleteMenu.Enabled = False
                Me.ImportMenu.Enabled = False
                Me.Import_Button.Enabled = False
                Reserve_Button.Enabled = False
                Button4.Enabled = False
            End If

        Else
            DisableEntry()
        End If

        OnLoading = False
        StoreOld()

    End Sub

    Private Function CheckApprovalAccess() As Boolean
        Return com.CheckUserProfileAccess(com, "PRPendingApproval")
        'Return True
    End Function

    Private Sub DisableEntry()
        AddButton.Enabled = False
        Submit_Button.Enabled = False
        AddMenu.Enabled = False
        DeleteButton.Enabled = False
        Reserve_Button.Enabled = False
        DeleteMenu.Enabled = False
        Me.ImportMenu.Enabled = False
        Me.Import_Button.Enabled = False
        EditButton.Enabled = False
        EditMenu.Enabled = False
        Me.Print2_Button.Enabled = False
        Button4.Enabled = False
        GridControl1.Enabled = False

        Me.WO_TextEdit.Enabled = False
        Me.StatusLookup.Enabled = False
        Me.Remarks_MemoEdit.Enabled = False
        Me.ApprovedByLookUp.Enabled = False
        Me.PRApprovedByLookUp.Enabled = False

        Me.ReqByLookup.Enabled = False
        Me.Submit_Button.Enabled = False
        Me.Store_Button.Enabled = False
        Me.WO_RadioButton.Enabled = False
        Me.OC_RadioButton.Enabled = False
        Me.FT_RadioButton.Enabled = False
        Me.ST_RadioButton.Enabled = False

    End Sub

    Private Sub ReadOnlyEntry()

        Me.WO_TextEdit.Properties.ReadOnly = True
        Me.StatusLookup.Properties.ReadOnly = True
        Me.Remarks_MemoEdit.Properties.ReadOnly = True
        Me.ApprovedByLookUp.Properties.ReadOnly = True
        Me.PRApprovedByLookUp.Properties.ReadOnly = True
        Me.ReqByLookup.Properties.ReadOnly = True
        Me.WO_RadioButton.Enabled = False
        Me.OC_RadioButton.Enabled = False
        Me.FT_RadioButton.Enabled = False
        Me.ST_RadioButton.Enabled = False


    End Sub

    Private Sub WriteEntry()

        Me.WO_TextEdit.Properties.ReadOnly = False
        Me.StatusLookup.Properties.ReadOnly = False
        Me.Remarks_MemoEdit.Properties.ReadOnly = False
        Me.ApprovedByLookUp.Properties.ReadOnly = False
        Me.PRApprovedByLookUp.Properties.ReadOnly = False
        Me.ReqByLookup.Properties.ReadOnly = False
        Me.WO_RadioButton.Enabled = True
        Me.OC_RadioButton.Enabled = True
        Me.FT_RadioButton.Enabled = True
        Me.ST_RadioButton.Enabled = True



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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_Button.Click
        Dim str As String

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        'Dim ExtProgressForm
        'ExtProgressForm = New TaskProgressForm
        'ExtProgressForm. = Me
        'ExtProgressForm.Show()
        'ExtProgressForm.Refresh()

        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        If LoadPRID <> 0 Then
            controlToAdd = New PRReportForm(LoadPRID)

        Else
            controlToAdd = New PRReportForm(SRVNoCmb.Properties.LookUpData.KeyValue)

        End If
        page = New Crownwood.Magic.Controls.TabPage("PR Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)

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

        If True Then

            Dim form As New PrItem3
            'form.Quotation_ID = SRVNoCmb.Properties.LookUpData.KeyValue
            If SRVNoCmb.Properties.LookUpData.KeyValue <> Nothing Then
                form.PR_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                form.ShowDialog(Me)
            ElseIf Me.LoadPRID <> 0 Then
                form.PR_ID = LoadPRID
                form.ShowDialog(Me)
            End If

        End If
        'LoadPR(LoadPRID)
    End Sub

    Private Sub DeleteMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteMenu.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim PRLine As Integer = dr(0)
                If PRLine > 0 Then
                    Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete PR Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                    If Result = DialogResult.Yes Then
                        DeletePRLine(PRLine)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub DeletePRLine(ByVal PRLine As Integer)
        Dim p As New BusinessRules.PRBusRules.PRLineBusLogic
        p.Delete(PRLine)
        LoadPR(LoadPRID)
    End Sub

    Private Function CreateNewDoc() As Boolean
        If ValidDocNo() Then
            NewPR()
            Return True
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

        If Duplicate(NewDoc.Text) = False Then
            'NewSRV()
        Else
            MessageBox.Show("Duplicate Ref no!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewDoc.SelectAll()
            NewDoc.Focus()
            ValidDocNo = False
        End If

    End Function


    Function Duplicate(ByVal DocNo As String) As Boolean
        Duplicate = False
        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .CheckExist(DocNo) = True Then
                Return True
            End If
        End With
        Return False
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim CurrStatus As String
        Dim PRID As String

        If Button4.Text = "Cancel" Then

            If Button1.Text = "Update" Then
                Restore()
            End If

            NewDoc.Visible = False
            Me.SRVNoCmb.Visible = True
            Button1.Text = "New"
            'Button4.Visible = False
            Button4.Text = "Delete"

            Submit_Button.Enabled = AddButton.Enabled = AddMenu.Enabled = AddButtonOldState
            Reserve_Button.Enabled = DeleteButton.Enabled = DeleteMenu.Enabled = DeleteButtonOldState
            Me.ImportMenu.Enabled = ImportMenuOldState
            Me.Import_Button.Enabled = ImportMenuOldState
            EditButton.Enabled = EditMenu.Enabled = EditButtonOldState
            GridControl1.Enabled = GridControl1OldState
            Print2_Button.Enabled = True

            Button4.Enabled = Button4OldState

            Me.NewDoc.Visible = False
            Me.SRVNoCmb.Visible = True
            Me.NewDoc.Properties.ReadOnly = False
            Me.NewDoc.Text = ""

            Me.LoadPR(LoadPRID)

        Else
            With New BusinessRules.PRBusRules.PRHeaderBusLogic
                If LoadPRID <> 0 Then
                    PRID = LoadPRID
                Else
                    PRID = SRVNoCmb.Properties.LookUpData.KeyValue
                End If
                .Load(PRID)
                CurrStatus = .Status
            End With

            If CurrStatus = "30" Then
                MessageBox.Show("This PR has already been submitted for approval. This form will automatically refresh to show the latest data.", "Delete Disallowed")
                LoadPR(LoadPRID)
                Exit Sub
            ElseIf CurrStatus = "40" Then
                MessageBox.Show("This PR has been approved. This form will automatically refresh to show the latest data.", "Delete Disallowed")
                LoadPR(LoadPRID)
                Exit Sub
            End If

            If Me.StatusLookup.Properties.LookUpData.KeyValue = "40" Then 'Approved
                MessageBox.Show("PR has been Approved. Delete denied!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If

            Dim Result As DialogResult = MessageBox.Show("Confirm delete " & SRVNoCmb.Text & "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                Me.OnLoading = True
                DeletePR()
                LoadPR(LoadPRID)
                Me.SRVNoCmb.Focus()

                Me.OnLoading = True

                Button4.Enabled = False
                GridControl1.Enabled = False
                AddButton.Enabled = False
                Submit_Button.Enabled = False
                DeleteButton.Enabled = False
                Reserve_Button.Enabled = False
                EditButton.Enabled = False
                Print2_Button.Enabled = False
                Print_Button.Enabled = False

                Me.WO_TextEdit.Text = ""
                Me.Remarks_MemoEdit.Text = ""
                Me.LastUpdate.Text = ""

                Me.InitStatusLookUp()

                Me.WO_TextEdit.Enabled = False
                Me.Remarks_MemoEdit.Enabled = False
                Me.ReqByLookup.Enabled = False
                Me.WO_RadioButton.Enabled = False
                Me.OC_RadioButton.Enabled = False
                Me.FT_RadioButton.Enabled = False
                Me.ST_RadioButton.Enabled = False

                Me.WO_RadioButton.Checked = False
                Me.OC_RadioButton.Checked = False
                Me.FT_RadioButton.Checked = False
                Me.ST_RadioButton.Checked = False

                OnLoading = False

            End If


        End If

    End Sub

    Private Sub DeletePR()

        Dim dr As DataRow
        Dim i As Integer
        'Dim Result As DialogResult = MessageBox.Show("Confirm delete " & SRVNoCmb.Text & "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'If Result = DialogResult.Yes Then

        If GridView1.RowCount > 0 Then
            For i = GridView1.RowCount - 1 To 0 Step -1
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Dim TransactionID As Integer = dr(0)
                    If TransactionID > 0 Then
                        Try
                            Me.DeletePRLine(TransactionID)
                        Catch ex As Exception

                            MessageBox.Show("Error deleting transaction:" & ex.Message)
                            Exit Sub

                        End Try
                    End If
                End If
            Next
        End If

        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            .Delete(SRVNoCmb.Properties.LookUpData.KeyValue)
        End With

        If FormType = "SALES" Then
            Me.SetSalesForm()
        ElseIf FormType = "STORE" Then
            Me.SetStoreForm()
        ElseIf FormType = "FT" Then
            Me.SetFactoryForm()
        ElseIf FormType = "PROJ" Then
            Me.SetProjectForm()
        End If

        'End If
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

        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim ID As Integer = dr(0)

                Dim form As New PrItem3(ID)
                'form.Quotation_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                form.PR_ID = SRVNoCmb.Properties.LookUpData.KeyValue
                form.ShowDialog(Me)

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
            LoadPR(LoadPRID)
            GridControl1.Focus()
        End If
    End Sub

    Private Sub SRVNoCmb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SRVNoCmb.LostFocus
        SRVNoCmb.Properties.Style.BackColor = System.Drawing.SystemColors.Window
    End Sub

    Private Sub SRVNoCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles SRVNoCmb.CloseUp
        LoadPR(LoadPRID)
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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Remarks_MemoEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Remarks_MemoEdit.ValueChanged
        OnEdit()
    End Sub

    Private Sub OnEdit()
        If Me.OnLoading = False Then
            If Button1.Text = "New" Then
                Button1.Text = "Update"
                Button4.Text = "Cancel"

                Me.NewDoc.Text = Me.SRVNoCmb.Text
                Me.NewDoc.Visible = True
                Me.SRVNoCmb.Visible = False
                Me.NewDoc.Properties.ReadOnly = True

                Me.GridControl1OldState = GridControl1.Enabled
                Button4OldState = Button4.Enabled
                AddButtonOldState = AddButton.Enabled
                DeleteButtonOldState = DeleteButton.Enabled
                EditButtonOldState = EditButton.Enabled

                Edited = True
            End If
        End If
    End Sub

    Private Sub WO_TextEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WO_TextEdit.ValueChanged
        OnEdit()
    End Sub

    Private Function UpdatePR() As Boolean
        Dim Stat As Boolean

        Stat = True
        'GetWindowsValue()
        Dim PRID As String

        If LoadPRID <> 0 Then
            PRID = LoadPRID
        Else
            PRID = SRVNoCmb.Properties.LookUpData.KeyValue
        End If

        If True Then 'ValidData() Then

            With New BusinessRules.PRBusRules.PRHeaderBusLogic


                .Load(PRID)

                .Refno = Me.WO_TextEdit.Text
                If Me.WO_RadioButton.Checked = True Then
                    .RefType = "WO"
                ElseIf Me.OC_RadioButton.Checked = True Then
                    .RefType = "OC"
                ElseIf Me.FT_RadioButton.Checked = True Then
                    .RefType = "FT"
                ElseIf Me.ST_RadioButton.Checked = True Then
                    .RefType = "ST"
                End If

                .Status = Me.StatusLookup.Properties.LookUpData.KeyValue
                If Me.StatusLookup.Properties.LookUpData.KeyValue = "30" Then 'Submitted Pending
                    .Submit_Date = Now()
                    .Approve_Date = Nothing
                    .Approver = Nothing
                ElseIf Me.StatusLookup.Properties.LookUpData.KeyValue = "10" Then  'Preparing
                    .Submit_Date = Nothing
                    .Approve_Date = Nothing
                    .Approver = Nothing
                ElseIf Me.StatusLookup.Properties.LookUpData.KeyValue = "40" Then 'Approved
                    .Approve_Date = Now()
                    .Approver = Me.UserID
                End If

                .Remarks = Me.Remarks_MemoEdit.Text
                .Requester = Me.ReqByLookup.Properties.LookUpData.KeyValue
                .PRApprover = Me.PRApprovedByLookUp.Properties.LookUpData.KeyValue
                .Approver = Me.ApprovedByLookUp.Properties.LookUpData.KeyValue
                .UserID = UserID

                '.PR_No = PR_No
                '.Requester = Requester
                '.Approver = Approver
                '.Status = Status
                '.UserID = UserID

                'A modified record will have product id
                'Modify Current Record
                .Update(PRID)
                StoreOld()

                'MessageBox.Show("PR had been successfully updated", "Modify PR", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'DisbledAll()
            End With

        End If

        UpdatePR = Stat

    End Function



    Private Sub InitalUserCombo()
        Dim ds As DataSet

        With New BusinessRules.PRBusRules.PRBusLogic
            If .GetUser(ds) Then
                If Not ds Is Nothing Then
                    ReqByLookup.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(ReqByLookup, "Name", 400, 0, "c")
                    ReqByLookup.Properties.LookUpData.KeyField = "User_ID"
                    ReqByLookup.Properties.LookUpData.DisplayField = "Name"

                    ReqByLookup.Properties.LookUpData.DataSource = ds.Tables(0)

                    ApprovedByLookUp.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(ApprovedByLookUp, "Name", 400, 0, "c")
                    ApprovedByLookUp.Properties.LookUpData.KeyField = "User_ID"
                    ApprovedByLookUp.Properties.LookUpData.DisplayField = "Name"

                    ApprovedByLookUp.Properties.LookUpData.DataSource = ds.Tables(0)

                    PRApprovedByLookUp.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(PRApprovedByLookUp, "Name", 400, 0, "c")
                    PRApprovedByLookUp.Properties.LookUpData.KeyField = "User_ID"
                    PRApprovedByLookUp.Properties.LookUpData.DisplayField = "Name"

                    PRApprovedByLookUp.Properties.LookUpData.DataSource = ds.Tables(0)

                End If
            End If

        End With
    End Sub

    Private Sub InitalStatusCombo()
        Dim ds As DataSet

        With New BusinessRules.PRBusRules.PRBusLogic
            If .GetUser(ds) Then
                If Not ds Is Nothing Then
                    ReqByLookup.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(ReqByLookup, "Name", 400, 0, "c")
                    ReqByLookup.Properties.LookUpData.KeyField = "User_ID"
                    ReqByLookup.Properties.LookUpData.DisplayField = "Name"

                    ReqByLookup.Properties.LookUpData.DataSource = ds.Tables(0)

                    ApprovedByLookUp.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(ApprovedByLookUp, "Name", 400, 0, "c")
                    ApprovedByLookUp.Properties.LookUpData.KeyField = "User_ID"
                    ApprovedByLookUp.Properties.LookUpData.DisplayField = "Name"

                    ApprovedByLookUp.Properties.LookUpData.DataSource = ds.Tables(0)

                End If
            End If

        End With
    End Sub

    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())

        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub ReqByLookup_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReqByLookup.ValueChanged
        OnEdit()
    End Sub
    'Change date format

    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then

            If pInputDate.ToString <> "" Then
                pDate = Date.Parse(pInputDate)
                tempsDate = pDate.Day & "/" & pDate.Month & "/" & pDate.Year
            End If

        End If

        Return tempsDate

    End Function

    Private Sub Button5_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reserve_Button.Click

        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim PRLine As Integer = dr(0)
                If PRLine > 0 Then
                    Dim form As New ReserveStock

                    form.PR_Line = PRLine
                    'form.Quotation_NO = Quotation_NO
                    form.ShowDialog()

                    If form.SaveRecord Then
                        Me.LoadPRItem()
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then
                Dim PRLine As Integer = dr(0)
                If PRLine > 0 Then
                    Dim form As New UnReserveStock

                    form.PR_Line = PRLine
                    'form.Quotation_NO = Quotation_NO
                    form.ShowDialog()

                    If form.SaveRecord Then
                        Me.LoadPRItem()
                    End If
                End If
            End If
        End If
    End Sub

    Sub InitStatusLookUp()

        StatusLookup.Properties.LookUpData.ListFields.Clear()

        '10 - Preparing, 20 - Revised, 30 - Pending approval, 31-Pending stock, 40 - Approved
        Dim statusData As String() = New String() {"", "Preparing", "Revised", "Pending", "(S)Pending", "(D)Pending", "Approved", "Dept Approved", "Stock Reserved"}
        Dim statusID As String() = New String() {"0", "10", "20", "30", "31", "32", "40", "41", "42"}
        SetComboValue(statusData, StatusLookup, statusID)

    End Sub

    Sub StoreOld()

        Me.WO_TextEdit_Old = Me.WO_TextEdit.Text
        Me.WO_RadioButton_Old = Me.WO_RadioButton.Checked
        Me.OC_RadioButton_Old = Me.OC_RadioButton.Checked
        Me.FT_RadioButton_Old = Me.FT_RadioButton.Checked
        Me.ST_RadioButton_Old = Me.ST_RadioButton.Checked
        'Me.StatusLookup_Old = Me.StatusLookup.Properties.LookUpData.KeyValue
        Me.MemoEdit_Old = Me.Remarks_MemoEdit.Text
        PRApprovedByLookUp_Old = Me.PRApprovedByLookUp.Properties.LookUpData.KeyValue
        ApprovedByLookUp_Old = Me.ApprovedByLookUp.Properties.LookUpData.KeyValue
        ReqByLookup_Old = Me.ReqByLookup.Properties.LookUpData.KeyValue

    End Sub

    Sub Restore()
        Me.WO_TextEdit.Text = Me.WO_TextEdit_Old
        Me.WO_RadioButton.Checked = Me.WO_RadioButton_Old
        Me.OC_RadioButton.Checked = Me.OC_RadioButton_Old
        Me.FT_RadioButton.Checked = Me.FT_RadioButton_Old
        Me.ST_RadioButton.Checked = Me.ST_RadioButton_Old
        'Me.StatusLookup.Properties.LookUpData.KeyValue = StatusLookup_Old
        Me.Remarks_MemoEdit.Text = MemoEdit_Old
        PRApprovedByLookUp.Properties.LookUpData.KeyValue = PRApprovedByLookUp_Old
        ApprovedByLookUp.Properties.LookUpData.KeyValue = ApprovedByLookUp_Old
        ReqByLookup.Properties.LookUpData.KeyValue = ReqByLookup_Old
    End Sub

    Private Sub WO_RadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WO_RadioButton.CheckedChanged
        Me.OnEdit()
    End Sub

    Private Sub ST_RadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ST_RadioButton.CheckedChanged
        Me.OnEdit()
    End Sub

    Private Sub OC_RadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OC_RadioButton.CheckedChanged
        Me.OnEdit()
    End Sub

    Private Sub FT_RadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FT_RadioButton.CheckedChanged
        Me.OnEdit()
    End Sub

    Private Sub Submit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_Button.Click
        Dim Result As DialogResult
        Dim PRID As String
        Dim CurrStatus As String

        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If LoadPRID <> 0 Then
                PRID = LoadPRID
            Else
                PRID = SRVNoCmb.Properties.LookUpData.KeyValue
            End If
            .Load(PRID)
            CurrStatus = .Status
        End With

        If Submit_Button.Text = "Submit" Then

            If CurrStatus = "30" Then 'Approved

                MessageBox.Show("This PR has already been submitted for approval. This form will automatically refresh to show the latest data.")
                LoadPR(LoadPRID)
                Exit Sub


            ElseIf CurrStatus = "10" Then 'Preparing

                Result = MessageBox.Show("Are you sure you want to submit for approval? ", "Dept Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                If Result = DialogResult.Yes Then
                    Me.StatusLookup.Properties.LookUpData.KeyValue = "30"
                    Submit_Button.Text = "Pending"
                    UpdatePR()
                    Me.ReadOnlyEntry()
                    AddButton.Enabled = False
                    Me.AddMenu.Enabled = False
                    DeleteButton.Enabled = False
                    Me.DeleteMenu.Enabled = False
                    Me.ImportMenu.Enabled = False
                    Me.Import_Button.Enabled = False
                    Reserve_Button.Enabled = False
                    Button4.Enabled = True
                    'Me.Close()
                End If

            End If

        ElseIf Submit_Button.Text = "Approve" Then


            If CurrStatus = "40" Then

                MessageBox.Show("This PR has already been approved. This form will automatically refresh to show the latest data.")
                LoadPR(LoadPRID)
                Exit Sub

            End If


            Dim Result2 As DialogResult = MessageBox.Show("Are you sure you want approve this PR?", "PR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result2 = DialogResult.No Then
                Exit Sub
            End If

            Me.StatusLookup.Properties.LookUpData.KeyValue = "40"
            Submit_Button.Text = "Cancel Approve"
            UpdatePR()
            AddButton.Enabled = False
            Me.AddMenu.Enabled = False
            DeleteButton.Enabled = False
            Me.DeleteMenu.Enabled = False
            Me.ImportMenu.Enabled = False
            Me.Import_Button.Enabled = False
            Reserve_Button.Enabled = False
            Button4.Enabled = True
            MessageBox.Show(Me.NewDoc.Text & " has been approved", "PR Approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        ElseIf Submit_Button.Text = "Cancel Approval" Then

            If CurrStatus = "30" Then

                MessageBox.Show("This PR is now Pending for approval. This form will automatically refresh to show the latest data.")
                LoadPR(LoadPRID)
                Exit Sub

            End If

            Result = MessageBox.Show("Are you sure you want to cancel the approval? ", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                Me.StatusLookup.Properties.LookUpData.KeyValue = "30"
                Submit_Button.Text = "Pending"
                UpdatePR()
                Me.ReadOnlyEntry()
                AddButton.Enabled = False
                Me.AddMenu.Enabled = False
                DeleteButton.Enabled = False
                Me.DeleteMenu.Enabled = False
                Me.ImportMenu.Enabled = False
                Me.Import_Button.Enabled = False
                Reserve_Button.Enabled = False
                Button4.Enabled = True
            End If
        Else

            If CurrStatus = "10" Then

                MessageBox.Show("This PR submission has already been cancelled. This form will automatically refresh to show the latest data.")
                LoadPR(LoadPRID)
                Exit Sub

            End If

            Result = MessageBox.Show("Are you sure you want to cancel submission for approval? ", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                Me.StatusLookup.Properties.LookUpData.KeyValue = "10"
                Submit_Button.Text = "Submit"
                UpdatePR()
                Me.WriteEntry()
                AddButton.Enabled = True
                Me.AddMenu.Enabled = True
                DeleteButton.Enabled = True
                Me.DeleteMenu.Enabled = True
                Me.ImportMenu.Enabled = True
                Me.Import_Button.Enabled = True
                Reserve_Button.Enabled = True
                Button4.Enabled = True
            End If
        End If
    End Sub

    Private Sub Store_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Store_Button.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Result As DialogResult

        If Button1.Text = "Update" Then
            Result = MessageBox.Show("Reload data will cancel any changes made, Are you sure? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.Yes Then
                LoadPR(LoadPRID)
            End If
        Else
            LoadPR(LoadPRID)
        End If

    End Sub

    Private Sub PRApprovedByLookUp_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PRApprovedByLookUp.ValueChanged
        OnEdit()
    End Sub

    Private Sub Button5_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim f As SetPurchasingDeliveryDate
        f = New SetPurchasingDeliveryDate
        f.ShowDialog()

        If f.DeliveryDate <> Nothing Then
            With New BusinessRules.PRBusRules.PRBusLogic

                If LoadPRID <> 0 Then
                    .UpdateDeliveryDate(LoadPRID, f.DeliveryDate)
                Else
                    .UpdateDeliveryDate(SRVNoCmb.Properties.LookUpData.KeyValue, f.DeliveryDate)
                End If
            End With
        End If

        Me.LoadPRItem()

    End Sub

    Private Sub PRList_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Result As DialogResult

        If Edited = True Then

            Result = MessageBox.Show("You have made changes or have edited data without saving, Are you sure you want to close? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then
                e.Cancel = True
            End If

        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim searchform As PRListing
        Dim PR_ID

        searchform = New PRListing(FormType)
        searchform.Title("Search for PR")
        searchform.ShowDialog()
        If searchform.DialogResult = DialogResult.OK Then
            PR_ID = searchform.PR_ID
            SRVNoCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {PR_ID, 0, 0, 0})
            LoadPR(LoadPRID)
        End If
        GridControl1.Focus()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportMenu.Click
        Dim searchform As PRListing
        Dim PR_ID
        Dim SourcePRID As String

        searchform = New PRListing(FormType)
        searchform.Title("Select a PR to import from")
        searchform.ShowDialog()
        If searchform.DialogResult = DialogResult.OK Then
            PR_ID = searchform.PR_ID
        End If

        If LoadPRID <> 0 Then
            SourcePRID = LoadPRID
        Else
            SourcePRID = SRVNoCmb.Properties.LookUpData.KeyValue
        End If

        With New BusinessRules.PRBusRules.PRBusLogic
            .CopyPRLine(PR_ID, SourcePRID)
        End With

        LoadPR(SourcePRID)


    End Sub

    Private Sub Import_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Import_Button.Click
        MenuItem2_Click(sender, e)
    End Sub

    Private Sub ApprovedByLookUp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApprovedByLookUp.ValueChanged
        OnEdit()
    End Sub
End Class
