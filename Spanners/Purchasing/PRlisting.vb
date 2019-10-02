Public Class PRListing
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pFormType As String)

        MyBase.New()
        FormType = pFormType
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Filter_ComboBox.SelectedIndex = 0 'Set to first item

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
    Friend WithEvents PRListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents CreateBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PRListingGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ViewPRBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintPRBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository2 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository3 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository4 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository5 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents PersistentRepository6 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Filter_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Filter_Button As System.Windows.Forms.Button
    Friend WithEvents Filter_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PersistentRepository7 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository8 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents ExactFilter_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PersistentRepository9 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository10 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository11 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents PersistentRepository12 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PRListGrp = New System.Windows.Forms.GroupBox
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPRBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.ViewPRBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PRListingGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository11 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PersistentRepository12 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository10 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository9 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository8 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository7 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository6 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository5 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository4 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository3 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository2 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.ExactFilter_CheckBox = New System.Windows.Forms.CheckBox
        Me.Filter_TextBox = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Filter_Button = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Filter_ComboBox = New System.Windows.Forms.ComboBox
        Me.PRListGrp.SuspendLayout()
        CType(Me.PRListingGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PRListGrp
        '
        Me.PRListGrp.Controls.Add(Me.XtraButton1)
        Me.PRListGrp.Controls.Add(Me.btnRefresh)
        Me.PRListGrp.Controls.Add(Me.PrintPRBtn)
        Me.PRListGrp.Controls.Add(Me.CloseBtn)
        Me.PRListGrp.Controls.Add(Me.RefreshBtn)
        Me.PRListGrp.Controls.Add(Me.ViewPRBtn)
        Me.PRListGrp.Controls.Add(Me.CreateBtn)
        Me.PRListGrp.Location = New System.Drawing.Point(72, 98)
        Me.PRListGrp.Name = "PRListGrp"
        Me.PRListGrp.Size = New System.Drawing.Size(120, 10)
        Me.PRListGrp.TabIndex = 3
        Me.PRListGrp.TabStop = False
        Me.PRListGrp.Text = "PR List"
        '
        'XtraButton1
        '
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(264, 368)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(83, 19)
        Me.XtraButton1.TabIndex = 26
        Me.XtraButton1.Text = "Print PR Basic"
        '
        'btnRefresh
        '
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(624, 368)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 19)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Refresh"
        '
        'PrintPRBtn
        '
        Me.PrintPRBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPRBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPRBtn.Image = Nothing
        Me.PrintPRBtn.Location = New System.Drawing.Point(184, 368)
        Me.PrintPRBtn.Name = "PrintPRBtn"
        Me.PrintPRBtn.Size = New System.Drawing.Size(52, 19)
        Me.PrintPRBtn.TabIndex = 24
        Me.PrintPRBtn.Text = "Print PR"
        '
        'CloseBtn
        '
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(704, 368)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(39, 19)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Checked = True
        Me.RefreshBtn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 368)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(104, 24)
        Me.RefreshBtn.TabIndex = 6
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'ViewPRBtn
        '
        Me.ViewPRBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ViewPRBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPRBtn.Image = Nothing
        Me.ViewPRBtn.Location = New System.Drawing.Point(112, 368)
        Me.ViewPRBtn.Name = "ViewPRBtn"
        Me.ViewPRBtn.Size = New System.Drawing.Size(54, 19)
        Me.ViewPRBtn.TabIndex = 5
        Me.ViewPRBtn.Text = "View PR"
        '
        'CreateBtn
        '
        Me.CreateBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateBtn.Image = Nothing
        Me.CreateBtn.Location = New System.Drawing.Point(512, 368)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(102, 19)
        Me.CreateBtn.TabIndex = 4
        Me.CreateBtn.Text = "Generate New PR"
        Me.CreateBtn.Visible = False
        '
        'PRListingGrid
        '
        Me.PRListingGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PRListingGrid.EditorsRepository = Me.PersistentRepository12
        Me.PRListingGrid.Location = New System.Drawing.Point(0, 47)
        Me.PRListingGrid.MainView = Me.GridView1
        Me.PRListingGrid.Name = "PRListingGrid"
        Me.PRListingGrid.Size = New System.Drawing.Size(686, 240)
        Me.PRListingGrid.TabIndex = 2
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
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
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 47)
        Me.Panel1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(599, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SaveButton.Location = New System.Drawing.Point(513, 12)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "OK"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 47)
        Me.Panel2.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ExactFilter_CheckBox)
        Me.Panel5.Controls.Add(Me.Filter_TextBox)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(192, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(388, 47)
        Me.Panel5.TabIndex = 2
        '
        'ExactFilter_CheckBox
        '
        Me.ExactFilter_CheckBox.AutoSize = True
        Me.ExactFilter_CheckBox.Checked = True
        Me.ExactFilter_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExactFilter_CheckBox.Location = New System.Drawing.Point(327, 14)
        Me.ExactFilter_CheckBox.Name = "ExactFilter_CheckBox"
        Me.ExactFilter_CheckBox.Size = New System.Drawing.Size(53, 17)
        Me.ExactFilter_CheckBox.TabIndex = 1
        Me.ExactFilter_CheckBox.Text = "Exact"
        Me.ExactFilter_CheckBox.UseVisualStyleBackColor = True
        '
        'Filter_TextBox
        '
        Me.Filter_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Filter_TextBox.Location = New System.Drawing.Point(6, 12)
        Me.Filter_TextBox.Name = "Filter_TextBox"
        Me.Filter_TextBox.Size = New System.Drawing.Size(309, 20)
        Me.Filter_TextBox.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Filter_Button)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(580, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(106, 47)
        Me.Panel4.TabIndex = 1
        '
        'Filter_Button
        '
        Me.Filter_Button.Location = New System.Drawing.Point(18, 10)
        Me.Filter_Button.Name = "Filter_Button"
        Me.Filter_Button.Size = New System.Drawing.Size(75, 23)
        Me.Filter_Button.TabIndex = 0
        Me.Filter_Button.Text = "Filter"
        Me.Filter_Button.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Filter_ComboBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(192, 47)
        Me.Panel3.TabIndex = 0
        '
        'Filter_ComboBox
        '
        Me.Filter_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Filter_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Filter_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Filter_ComboBox.FormattingEnabled = True
        Me.Filter_ComboBox.Items.AddRange(New Object() {"PR No", "Work Order No", "Remarks"})
        Me.Filter_ComboBox.Location = New System.Drawing.Point(12, 12)
        Me.Filter_ComboBox.Name = "Filter_ComboBox"
        Me.Filter_ComboBox.Size = New System.Drawing.Size(164, 21)
        Me.Filter_ComboBox.TabIndex = 0
        '
        'PRListing
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(686, 334)
        Me.Controls.Add(Me.PRListingGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PRListGrp)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "PRListing"
        Me.Text = "PR Listing"
        Me.PRListGrp.ResumeLayout(False)
        CType(Me.PRListingGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public PR_ID As Integer
    Public Filter As String
    Public FormType As String
    Public dataPRGrid As System.Data.DataTable

#End Region

#Region " Event "

    Private Sub PRListing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        LoadPRFrmDB(FormType)

        CheckExistingPR()

        'Timer1.Interval = 60000
        'Timer1.Start()
    End Sub

    Private Sub PRListingGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PRListingGrid.Click
        PRClick()
    End Sub

    Private Sub CreateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateBtn.Click

        'Dim a As MainForm = Me.ParentForm
        'Dim controlToAdd As Control = Nothing
        'Me.Cursor = Cursors.WaitCursor
        'Dim page As Crownwood.Magic.Controls.TabPage

        'controlToAdd = New PRForm
        'page = New Crownwood.Magic.Controls.TabPage("Generate PR", controlToAdd, ImageList1, 0)

        'page.Selected = True

        'a.MainTabControl.TabPages.Add(page)

        'Me.Cursor = Cursors.Default

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Dim form As New PRForm("NEW")

        'form.PR_ID = PR_ID

        'form.ShowDialog()
        'form.Dispose()

        'Reload PR list
        'ClearGrid(GridView1)
        'LoadPRFrmDB()

        'CheckExistingPR()

    End Sub

    Private Sub ViewPRBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPRBtn.Click

        If PR_ID <> Nothing And PR_ID <> 0 Then


            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor



            'Dim page As Crownwood.Magic.Controls.TabPage

            'controlToAdd = New PRViewForm("VIEW", PR_ID)
            'page = New Crownwood.Magic.Controls.TabPage("View PR", controlToAdd, ImageList1, 0)

            'page.Selected = True

            'a.MainTabControl.TabPages.Add(page)

            Me.Cursor = Cursors.Default

            'Dim form As New PRForm("VIEW")

            'form.PR_ID = PR_ID

            'form.ShowDialog()
            'form.Dispose()

        End If

    End Sub

    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        If RefreshBtn.Checked = True Then
            'Timer1.Interval = 60000
            'Timer1.Start()
        Else
            'Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'ClearGrid(GridView1)
        LoadPRFrmDB()

        CheckExistingPR()

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        'Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PR?", "PR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If Result = DialogResult.Yes Then
        'Me.Close()
        Me.Close()
        'End If
    End Sub

    Private Sub PrintPRBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPRBtn.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New PRReportForm(PR_ID)
        page = New Crownwood.Magic.Controls.TabPage("PR Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region " Grid Code "

    'Call once form load, Initalize PR Columns
    Private Sub InitPRListing()

        dataPRGrid = New DataTable("ColumnsTable")
        dataPRGrid.BeginInit()

        AddColumn(dataPRGrid, "PR_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(dataPRGrid, "Grp", System.Type.GetType("System.String"), True)

        AddColumn(dataPRGrid, "PR NO", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Work Order No", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Submit Date", System.Type.GetType("System.String"), True)
        AddColumn(dataPRGrid, "Remarks", System.Type.GetType("System.String"), True)

        dataPRGrid.EndInit()

    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub

    Private Sub ClearGrid(ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim i

        If GridView.RowCount() <> 0 Then
            GridView.FocusedRowHandle = 0
            For i = 0 To GridView.RowCount() - 1
                If GridView1.IsGroupRow(i) = False Then

                    GridView.DeleteRow(GridView.GetSelectedRows(0))
                    If GridView.RowCount() <> 0 Then
                        GridView.FocusedRowHandle = 0
                    End If

                End If
            Next
        End If
    End Sub

#End Region

#Region " Other Codes "

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

    Private Sub LoadPRFrmDB(Optional ByVal pFormType As String = "", Optional ByVal pFilter As String = "")
        Dim ds As DataSet
        Dim dsParent As DataSet

        With New BusinessRules.PRBusRules.PRHeaderBusLogic
            If .LoadList(ds, pFormType, pFilter) Then

                InitPRListing()

                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentQuotationNo As String

                For Each oRow In ds.Tables(0).Rows
                    dataPRGrid.Rows.Add(New Object() {oRow("PR_ID"), _
                                                      oRow("Grp"), _
                                                        oRow("PR_NO"), _
                                                        oRow("Refno"), _
                                                        ChangeDateFormat(oRow("Submit_Date")), _
                                                        oRow("Remarks")})
                Next


                PRListingGrid.DataSource = dataPRGrid
                PRListingGrid.DefaultView.PopulateColumns()

                'GridView1.BestFitColumns()
                Me.DefaultGridView()
                GridView1.Columns.Item(0).VisibleIndex = -1 'hide column
                GridView1.Columns.Item(1).VisibleIndex = -1 'hide column
            End If
        End With

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            PRClick()
        End If
    End Sub

    Private Sub DefaultGridView()

        GridView1.Columns("PR NO").Width = 150
        GridView1.Columns("Submit Date").Width = 113
        'GridView1.Columns("Remarks").Width 
       
    End Sub

    'Check if there is existing PR to add to PR, show Generate New PR button
    Private Sub CheckExistingPR()

        'Dim ds As DataSet

        'With New BusinessRules.PRBusRules.PRBusLogic
        'If Not .LoadPRList(ds, "0", "40") Then
        'CreateBtn.Visible = False
        'Else
        'CreateBtn.Visible = True
        'End If
        'End With

    End Sub

    Private Sub PRClick()
        If GridView1.SelectedRowsCount <> 0 Then

            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then
                Me.Cursor = Cursors.WaitCursor
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                PR_ID = items(0)

                Me.Cursor = Cursors.Default

            End If
        End If
    End Sub

#End Region

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadPRFrmDB()
    End Sub

    Private Sub PRListing_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim a As MainForm = Me.ParentForm
        'If (a.MainTabControl.TabPages.Count > 0) Then
        'If Not (a.MainTabControl.SelectedTab Is Nothing) Then
        'a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
        'End If
        'End If
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton1.Click
        'Dim a As MainForm = Me.ParentForm
        'Dim controlToAdd As Control = Nothing
        'Me.Cursor = Cursors.WaitCursor

        'Dim page As Crownwood.Magic.Controls.TabPage
        'controlToAdd = New PRReportForm(PR_ID, True)
        'page = New Crownwood.Magic.Controls.TabPage("PR Report", controlToAdd, ImageList1, 0)

        'page.Selected = True
        'a.MainTabControl.TabPages.Add(page)
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub PRListingGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PRListingGrid.DoubleClick
        SaveButton_Click(sender, e)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If GridView1.RowCount > 0 Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            If Not dr Is Nothing Then

                PR_ID = CInt(dr("PR_ID"))
                
            End If
        End If
    End Sub

    Private Sub Filter_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filter_Button.Click

        Dim Selected = Me.Filter_ComboBox.SelectedItem.ToString()
        'PR No ,Work Order No,Remarks
        If Selected = "PR No" Then
            Filter = " PR_No like '" & Me.Filter_TextBox.Text
        ElseIf Selected = "Work Order No" Then
            Filter = " Refno like '" & Me.Filter_TextBox.Text
        ElseIf Selected = "Remarks" Then
            Filter = " Remarks like '" & Me.Filter_TextBox.Text
        End If

        If Me.ExactFilter_CheckBox.Checked = False Then
            Filter = Filter & "%'"
        Else
            Filter = Filter & "'"
        End If

        Me.LoadPRFrmDB(FormType, Filter)


    End Sub

    Public Sub Title(ByVal pTitle As String)
        Me.Text = pTitle
    End Sub
End Class
