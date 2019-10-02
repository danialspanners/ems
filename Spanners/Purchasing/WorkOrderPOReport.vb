Public Class WorkOrderPOList
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
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents POListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents TypeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TypeLbl As System.Windows.Forms.Label
    Friend WithEvents WorkOrderCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.POListGrp = New System.Windows.Forms.GroupBox
        Me.WorkOrderCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.TypeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.TypeLbl = New System.Windows.Forms.Label
        Me.PrintPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.POListGrp.SuspendLayout()
        CType(Me.WorkOrderCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POListGrp
        '
        Me.POListGrp.Controls.Add(Me.WorkOrderCmb)
        Me.POListGrp.Controls.Add(Me.Label25)
        Me.POListGrp.Controls.Add(Me.TypeCmb)
        Me.POListGrp.Controls.Add(Me.TypeLbl)
        Me.POListGrp.Controls.Add(Me.PrintPOBtn)
        Me.POListGrp.Controls.Add(Me.CloseBtn)
        Me.POListGrp.Location = New System.Drawing.Point(8, 8)
        Me.POListGrp.Name = "POListGrp"
        Me.POListGrp.Size = New System.Drawing.Size(248, 128)
        Me.POListGrp.TabIndex = 3
        Me.POListGrp.TabStop = False
        '
        'WorkOrderCmb
        '
        Me.WorkOrderCmb.Location = New System.Drawing.Point(96, 48)
        Me.WorkOrderCmb.Name = "WorkOrderCmb"
        Me.WorkOrderCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.WorkOrderCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.WorkOrderCmb.Properties.NullString = ""
        Me.WorkOrderCmb.Properties.PopupWidth = 208
        Me.WorkOrderCmb.Size = New System.Drawing.Size(136, 19)
        Me.WorkOrderCmb.TabIndex = 42
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "* Work Order :"
        '
        'TypeCmb
        '
        Me.TypeCmb.Enabled = False
        Me.TypeCmb.Location = New System.Drawing.Point(96, 24)
        Me.TypeCmb.Name = "TypeCmb"
        Me.TypeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TypeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.TypeCmb.Properties.Enabled = False
        Me.TypeCmb.Properties.NullString = ""
        Me.TypeCmb.Properties.PopupWidth = 152
        Me.TypeCmb.Size = New System.Drawing.Size(136, 19)
        Me.TypeCmb.TabIndex = 26
        '
        'TypeLbl
        '
        Me.TypeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLbl.Location = New System.Drawing.Point(8, 24)
        Me.TypeLbl.Name = "TypeLbl"
        Me.TypeLbl.Size = New System.Drawing.Size(56, 16)
        Me.TypeLbl.TabIndex = 27
        Me.TypeLbl.Text = "* Type :"
        '
        'PrintPOBtn
        '
        Me.PrintPOBtn.AutoSize = False
        Me.PrintPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPOBtn.Image = Nothing
        Me.PrintPOBtn.Location = New System.Drawing.Point(96, 80)
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
        Me.CloseBtn.Location = New System.Drawing.Point(168, 80)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'WorkOrderPOList
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(264, 149)
        Me.Controls.Add(Me.POListGrp)
        Me.Name = "WorkOrderPOList"
        Me.Text = "Outstanding PO Item Report"
        Me.POListGrp.ResumeLayout(False)
        CType(Me.WorkOrderCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public Type As String
    Public WO_ID As Integer
    Public WO_No As String

#End Region

#Region " Event "

    Private Sub POList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WO_ID = 0
        LoadWorkOrder()
        LoadCombo()
        TypeCmb.Properties.LookUpData.KeyValue = "1"

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click

        'Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PO?", "PO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If Result = DialogResult.Yes Then
        'Me.Close()
        Me.Close()
        'End If
        '        End If
    End Sub

    Private Sub PrintPOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPOBtn.Click
        GetWindowsValue()
        If ValidData() Then
            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                Dim ds As DataSet
                If .GetWOHeader(ds, WO_ID) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        WO_No = ds.Tables(0).Rows(0)("WO_No")
                    End If
                End If
                ds.Dispose()
            End With

            controlToAdd = New WorkOrderPOReportForm(Type, WO_No)
            page = New Crownwood.Magic.Controls.TabPage("Print Work Order PO Report", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region " Hardcoded Combo Box , Type"
    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())
        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub

    Private Sub LoadCombo()
        Dim TypeData As String() = New String() {"PO", "Powder Coating"}
        Dim TypeID As String() = New String() {"1", "2"}
        SetComboValue(TypeData, TypeCmb, TypeID)
    End Sub
#End Region

#Region "Combo Box"
    Private Sub LoadWorkOrder()
        Dim ds As DataSet
        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If .GetWOHeader(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(WorkOrderCmb, "WO_No", 400, 0, "c")
                        WorkOrderCmb.Properties.LookUpData.KeyField = "WO_ID"
                        WorkOrderCmb.Properties.LookUpData.DisplayField = "WO_No"

                        WorkOrderCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        WorkOrderCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
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

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If Type = "" Then
            ErrorMessage = ErrorMessage & " Type" & Chr(13)
            DataOK_flag = False
        End If

        If WO_ID = 0 Then
            ErrorMessage = ErrorMessage & " Work Order" & Chr(13)
            DataOK_flag = False
        End If

        If DataOK_flag = False Then

            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End With
        End If

        Return DataOK_flag

    End Function

#End Region

#Region " Code - Get Window Values"

    Private Sub GetWindowsValue()
        Type = TypeCmb.Properties.LookUpData.KeyValue
        WO_ID = WorkOrderCmb.Properties.LookUpData.KeyValue
    End Sub

#End Region

    Private Sub POListGrp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POListGrp.Enter

    End Sub

    Private Sub WorkOrderPOList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
