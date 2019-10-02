Public Class ManageDrawingNoForm
    Inherits System.Windows.Forms.Form

#Region "Drawing Form Variables Initialization"
    Public Drawing_ID As Integer
    Public FormStatus As String
    Public Drawing_No As String
    'Public Drawing_Type As Integer
    Public Drawing_Type As String
    Public Drawn_By As Integer
    Public Issue_To As Integer
    Public Issue_Date As String
    Public Customer_ID As Integer
    Private UserID As Integer = Common.CommonConn.Config.USERID

#End Region

    ' 05.01.2004 YG Start
    Dim FunctionName As String = "DrawingProfile"
    ' 05.01.2004 YG End


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, Optional ByVal pDrawing_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus
        If Not pDrawing_ID = 0 Then
            Drawing_ID = pDrawing_ID
        End If

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
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DrawnByCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DrawingTypeCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrawingNoLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DrawingNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IssueToCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustomerCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IssueDateCmb As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.IssueToCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.DrawnByCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.DrawingTypeCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.CustomerCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DrawingNoLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DrawingNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IssueDateCmb = New DevExpress.XtraEditors.DateEdit
        CType(Me.IssueToCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawnByCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingTypeCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IssueDateCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(168, 232)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 100
        Me.CancelBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(96, 232)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 99
        Me.SaveBtn.Text = "&Save"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Issue Date :"
        '
        'IssueToCmb
        '
        Me.IssueToCmb.Location = New System.Drawing.Point(88, 112)
        Me.IssueToCmb.Name = "IssueToCmb"
        Me.IssueToCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IssueToCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.IssueToCmb.Properties.NullString = ""
        Me.IssueToCmb.Size = New System.Drawing.Size(136, 19)
        Me.IssueToCmb.TabIndex = 141
        '
        'DrawnByCmb
        '
        Me.DrawnByCmb.Location = New System.Drawing.Point(88, 80)
        Me.DrawnByCmb.Name = "DrawnByCmb"
        Me.DrawnByCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DrawnByCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DrawnByCmb.Properties.NullString = ""
        Me.DrawnByCmb.Properties.PopupWidth = 160
        Me.DrawnByCmb.Size = New System.Drawing.Size(136, 19)
        Me.DrawnByCmb.TabIndex = 140
        '
        'DrawingTypeCmb
        '
        Me.DrawingTypeCmb.Location = New System.Drawing.Point(88, 48)
        Me.DrawingTypeCmb.Name = "DrawingTypeCmb"
        Me.DrawingTypeCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DrawingTypeCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DrawingTypeCmb.Properties.NullString = ""
        Me.DrawingTypeCmb.Size = New System.Drawing.Size(80, 19)
        Me.DrawingTypeCmb.TabIndex = 139
        '
        'CustomerCmb
        '
        Me.CustomerCmb.Location = New System.Drawing.Point(88, 176)
        Me.CustomerCmb.Name = "CustomerCmb"
        Me.CustomerCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustomerCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustomerCmb.Properties.NullString = ""
        Me.CustomerCmb.Properties.PopupWidth = 280
        Me.CustomerCmb.Size = New System.Drawing.Size(136, 19)
        Me.CustomerCmb.TabIndex = 138
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 16)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Customer:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Drawing Type :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Drawn By:"
        '
        'DrawingNoLbl
        '
        Me.DrawingNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrawingNoLbl.Location = New System.Drawing.Point(8, 16)
        Me.DrawingNoLbl.Name = "DrawingNoLbl"
        Me.DrawingNoLbl.Size = New System.Drawing.Size(72, 16)
        Me.DrawingNoLbl.TabIndex = 77
        Me.DrawingNoLbl.Text = "Drawing No :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Issue To :"
        '
        'DrawingNoTxt
        '
        Me.DrawingNoTxt.Enabled = False
        Me.DrawingNoTxt.Location = New System.Drawing.Point(88, 16)
        Me.DrawingNoTxt.Name = "DrawingNoTxt"
        Me.DrawingNoTxt.Properties.Enabled = False
        Me.DrawingNoTxt.Size = New System.Drawing.Size(80, 21)
        Me.DrawingNoTxt.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.IssueDateCmb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.IssueToCmb)
        Me.GroupBox1.Controls.Add(Me.DrawnByCmb)
        Me.GroupBox1.Controls.Add(Me.DrawingTypeCmb)
        Me.GroupBox1.Controls.Add(Me.CustomerCmb)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DrawingNoLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DrawingNoTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 264)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'IssueDateCmb
        '
        Me.IssueDateCmb.DateTime = New Date(CType(0, Long))
        Me.IssueDateCmb.Location = New System.Drawing.Point(88, 144)
        Me.IssueDateCmb.Name = "IssueDateCmb"
        Me.IssueDateCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IssueDateCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.IssueDateCmb.Size = New System.Drawing.Size(136, 19)
        Me.IssueDateCmb.TabIndex = 144
        '
        'ManageDrawingNoForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 277)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageDrawingNoForm"
        Me.Text = "Manage Drawing No."
        CType(Me.IssueToCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawnByCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingTypeCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.IssueDateCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Load "
    Private Sub ManageDrawing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 05.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 05.01.2004 YG End

        Me.Cursor = Cursors.WaitCursor
        LoadDrawingType()
        LoadDrawnBy()
        LoadIssueTo()
        LoadCustomerDetails()

        Select Case UCase(FormStatus)
            Case "NEW"
                InitializeForm()

            Case "EDIT"
                Me.Text = "Edit Drawing"
                With New BusinessRules.DrawingBusRules.DrawingBusLogic
                    Dim dsDrawing As DataSet
                    If .GetDrawing(dsDrawing, Drawing_ID) Then
                        SetWindowValue(dsDrawing)
                    End If
                End With
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InitializeForm()
        Dim ds As DataSet

        'DrawingNoTxt.Text = CreateDrawingNo()
        DrawingNoTxt.Enabled = True

        With New BusinessRules.SaleBusRules.SaleBusLogic
            'GET CUSTOMER INITIAL
            Dim dstmp As DataSet
            Dim CustInitial
            '      If .GetCustomerDetails(dstmp, Customer_ID) Then
            '     If dstmp.Tables(0).Rows.Count > 0 Then
            '    CustInitial = dstmp.Tables(0).Rows(0)("Initial")
            '   CustLookup.Properties.LookUpData.KeyValue = dstmp.Tables(0).Rows(0)("Customer_ID")
            '  End If
            ' End If
            'dstmp.Dispose()
            'LoadContactPerson(Customer_ID)
            'CustLookup.Properties.ReadOnly = True

            'With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            'WO_NO = GetWorkOrderNo(CustInitial)
            'WONoTxt.Text = WO_NO

            '.WO_No = WO_NO
            '.UserID = UserID
            '.Status = StatusCmb.Properties.LookUpData.KeyValue

            'If .SaveWONo() Then
            'WO_ID = .WO_ID        'Store WO ID
            'Else
            '    MessageBox.Show("Error creating Work Order", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'End With
        End With
    End Sub

    Private Function CreateDrawingNo() As String
        Dim DrawingNo As Integer
        With New BusinessRules.CommonBusRules.CommonLogic
            .UserID = UserID
            DrawingNo = .GetDocumentNextNumber("P")
        End With
        CreateDrawingNo = "P" & DrawingNo
    End Function
#End Region

#Region "Load ComboBox"

    Private Sub LoadDrawingType()
        Dim DrawingTypeData As String() = New String() {"", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim idData As String() = New String() {"", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

        SetComboValue(DrawingTypeData, DrawingTypeCmb, idData)
    End Sub

    Private Sub LoadDrawnBy()
        Dim ds As DataSet
        With New BusinessRules.DrawingBusRules.DrawingBusLogic
            If .GetUserProfile(ds) Then
                If Not ds Is Nothing Then
                    Try
                        ''SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(DrawnByCmb, "Name", 400, 0, "c")
                        DrawnByCmb.Properties.LookUpData.KeyField = "User_ID"
                        DrawnByCmb.Properties.LookUpData.DisplayField = "Name"

                        DrawnByCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        DrawnByCmb.EditValue = "0"
                        ''SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadIssueTo()
        Dim ds As DataSet
        With New BusinessRules.DrawingBusRules.DrawingBusLogic
            If .GetUserProfile(ds) Then
                If Not ds Is Nothing Then
                    Try
                        ''SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(IssueToCmb, "Name", 400, 0, "c")
                        IssueToCmb.Properties.LookUpData.KeyField = "User_ID"
                        IssueToCmb.Properties.LookUpData.DisplayField = "Name"

                        IssueToCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        IssueToCmb.EditValue = "0"
                        ''SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub LoadCustomerDetails()
        Dim ds As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetCustomerDetails(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(CustomerCmb, "Name", 400, 0, "c")
                        CustomerCmb.Properties.LookUpData.KeyField = "Customer_ID"
                        CustomerCmb.Properties.LookUpData.DisplayField = "Name"

                        CustomerCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        CustomerCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub
    Private Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())

        With New BusinessRules.CommonBusRules.CommonLogic
            .SetComboValue(data, comboBox, id)
        End With
    End Sub
    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

#Region "Button Event"
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        SaveDrawing()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

#End Region

#Region "Database Management"
    Private Sub SaveDrawing()

        GetWindowsValue()

        If ValidData() Then
            With New BusinessRules.DrawingBusRules.DrawingBusLogic

                .Drawing_No = Drawing_No
                .Drawing_Type = Drawing_Type
                .Drawn_By = Drawn_By
                .Issue_To = Issue_To
                .Issue_Date = Issue_Date
                .Customer_ID = Customer_ID
                .UserID = UserID

                If Drawing_ID = Nothing Or Drawing_ID = 0 Then
                    Drawing_ID = .SaveDrawing()
                    MessageBox.Show("Drawing Saved!", "Manage Drawing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .UpdateDrawing(Drawing_ID)
                    MessageBox.Show("Drawing Updated!", "Manage Drawing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        End If
    End Sub

#End Region

#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)
        DrawingNoTxt.Text = dsLoad.Tables(0).Rows(0)("Drawing_No")
        DrawingTypeCmb.Text = dsLoad.Tables(0).Rows(0)("Drawing_Type")
        DrawnByCmb.Text = dsLoad.Tables(0).Rows(0)("DrawnBy")
        IssueToCmb.Text = dsLoad.Tables(0).Rows(0)("IssueTo")
        'IssueDateCmb.Text = dsLoad.Tables(0).Rows(0)("Issue_Date")
        CustomerCmb.Text = dsLoad.Tables(0).Rows(0)("Customer")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Drawing_No")) Then
            DrawingNoTxt.Text = dsLoad.Tables(0).Rows(0)("Drawing_No")
        Else
            DrawingNoTxt.Text = Nothing
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Drawing_Type")) Then
            DrawingTypeCmb.Text = dsLoad.Tables(0).Rows(0)("Drawing_Type")
        Else
            DrawingTypeCmb.Text = Nothing
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("DrawnBy")) Then
            DrawnByCmb.Text = dsLoad.Tables(0).Rows(0)("DrawnBy")
        Else
            DrawnByCmb.Text = Nothing
        End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Drawn_By")) Then
        'DrawnByCmb.Text = dsLoad.Tables(0).Rows(0)("Drawn_By")
        'Else
        '    DrawnByCmb.Text = Nothing
        'End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("IssueTo")) Then
            IssueToCmb.Text = dsLoad.Tables(0).Rows(0)("IssueTo")
        Else
            IssueToCmb.Text = Nothing
        End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Issue_To")) Then
        'IssueToCmb.Text = dsLoad.Tables(0).Rows(0)("Issue_To")
        'Else
        '    IssueToCmb.Text = Nothing
        'End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Issue_Date")) Then
        'IssueDateCmb.Text = dsLoad.Tables(0).Rows(0)("Issue_Date")
        'Else
        '    IssueDateCmb.Text = Nothing
        'End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer")) Then
            CustomerCmb.Text = dsLoad.Tables(0).Rows(0)("Customer")
        Else
            CustomerCmb.Text = Nothing
        End If

        'If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Customer_ID")) Then
        'CustomerCmb.Text = dsLoad.Tables(0).Rows(0)("Customer_ID")
        'Else
        '    CustomerCmb.Text = Nothing
        'End If

    End Sub

    Private Sub GetWindowsValue()

        Drawing_No = DrawingNoTxt.Text
        Drawing_Type = DrawingTypeCmb.Text
        Drawn_By = DrawnByCmb.Properties.LookUpData.KeyValue
        Issue_To = IssueToCmb.Properties.LookUpData.KeyValue
        'Issue_Date = IssueDateCmb.Text
        Customer_ID = CustomerCmb.Properties.LookUpData.KeyValue

    End Sub

#End Region

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String
        DataOK_flag = True

        If Drawing_No = "" Then
            ErrorMessage = ErrorMessage & " Drawing No" & Chr(13)
            DataOK_flag = False
        End If

        If Drawing_Type = "" Then
            ErrorMessage = ErrorMessage & " Drawing_Type" & Chr(13)
            DataOK_flag = False
        End If

        If Drawn_By = 0 Then
            ErrorMessage = ErrorMessage & " Drawn_By" & Chr(13)
            DataOK_flag = False
        End If

        If Issue_To = 0 Then
            ErrorMessage = ErrorMessage & " Issue_To" & Chr(13)
            DataOK_flag = False
        End If

        If Len(Issue_Date) > 0 Then
            ErrorMessage = ErrorMessage & " Issue_Date" & Chr(13)
            DataOK_flag = False
        End If

        If Customer_ID = 0 Then
            ErrorMessage = ErrorMessage & " Customer_ID" & Chr(13)
            DataOK_flag = False
        End If

        'With New Common.CommonError.ErrorMsg
        If DataOK_flag = False Then
            MessageBox.Show(ErrorMessage, "Error - Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'Else
        With New BusinessRules.DrawingBusRules.DrawingBusLogic
            If Drawing_ID <> Nothing And Drawing_ID <> 0 Then
                If .RecordExists(Drawing_No, Drawing_ID) Then
                    MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    DataOK_flag = False
                End If
            Else
                If .RecordExists(Drawing_No, Nothing) Then
                    MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    DataOK_flag = False
                End If
            End If

        End With
        'End If

        Return DataOK_flag

    End Function
#End Region


    Private Sub ManageDrawingNoForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Manage Drawing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Dim a As MainForm = Me.ParentForm
            If (a.MainTabControl.TabPages.Count > 0) Then
                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
                End If
            End If
        Else
            e.Cancel = True
        End If

    End Sub
End Class
