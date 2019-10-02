Imports DevExpress.XtraEditors.Controls
Public Class SurveyOrderLineForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pStatus As String, ByVal pSO_ID As Integer, Optional ByVal pSOLine_ID As Integer = 0, Optional ByVal pContract_ID As Integer = 0)
        MyBase.New()

        FormStatus = pStatus

        SO_ID = pSO_ID

        If Not pSOLine_ID = 0 Then
            SOLine_ID = pSOLine_ID
        End If

        If Not pContract_ID = 0 Then
            Contract_ID = pContract_ID
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents QtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents CompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LocationTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ExpectedCompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ItemNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemarksTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IOCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DescriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.QtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.LocationTxt = New DevExpress.XtraEditors.MemoEdit
        Me.RemarksTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DescriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.IOCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.ItemNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ExpectedCompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.CompleteDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DescriptionMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IOCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedCompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Qty :"
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(224, 200)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(72, 32)
        Me.SelectBtn.TabIndex = 48
        Me.SelectBtn.Text = "Save"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(304, 200)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 50
        Me.CloseBtn.Text = "&Close"
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(88, 88)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QtyTxt.Size = New System.Drawing.Size(56, 19)
        Me.QtyTxt.TabIndex = 65
        Me.QtyTxt.Text = "1"
        '
        'LocationTxt
        '
        Me.LocationTxt.Enabled = False
        Me.LocationTxt.Location = New System.Drawing.Point(80, 40)
        Me.LocationTxt.Name = "LocationTxt"
        Me.LocationTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.LocationTxt.Size = New System.Drawing.Size(272, 32)
        Me.LocationTxt.TabIndex = 175
        '
        'RemarksTxt
        '
        Me.RemarksTxt.Location = New System.Drawing.Point(80, 152)
        Me.RemarksTxt.Name = "RemarksTxt"
        Me.RemarksTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RemarksTxt.Size = New System.Drawing.Size(272, 32)
        Me.RemarksTxt.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Location :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "Remarks :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DescriptionMemoEdit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.IOCmb)
        Me.GroupBox1.Controls.Add(Me.ItemNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ExpectedCompleteDateEdit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CompleteDateEdit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.LocationTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RemarksTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 192)
        Me.GroupBox1.TabIndex = 182
        Me.GroupBox1.TabStop = False
        '
        'DescriptionMemoEdit
        '
        Me.DescriptionMemoEdit.Location = New System.Drawing.Point(80, 76)
        Me.DescriptionMemoEdit.Name = "DescriptionMemoEdit"
        Me.DescriptionMemoEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DescriptionMemoEdit.Size = New System.Drawing.Size(272, 12)
        Me.DescriptionMemoEdit.TabIndex = 187
        Me.DescriptionMemoEdit.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Description :"
        Me.Label3.Visible = False
        '
        'IOCmb
        '
        Me.IOCmb.Location = New System.Drawing.Point(80, 16)
        Me.IOCmb.Name = "IOCmb"
        Me.IOCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IOCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.IOCmb.Properties.NullString = ""
        Me.IOCmb.Size = New System.Drawing.Size(128, 19)
        Me.IOCmb.TabIndex = 185
        '
        'ItemNoTxt
        '
        Me.ItemNoTxt.Enabled = False
        Me.ItemNoTxt.Location = New System.Drawing.Point(296, 16)
        Me.ItemNoTxt.Name = "ItemNoTxt"
        Me.ItemNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ItemNoTxt.Size = New System.Drawing.Size(56, 19)
        Me.ItemNoTxt.TabIndex = 184
        Me.ItemNoTxt.Visible = False
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(224, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Item No :"
        Me.Label1.Visible = False
        '
        'ExpectedCompleteDateEdit
        '
        Me.ExpectedCompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.ExpectedCompleteDateEdit.Location = New System.Drawing.Point(80, 128)
        Me.ExpectedCompleteDateEdit.Name = "ExpectedCompleteDateEdit"
        Me.ExpectedCompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExpectedCompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ExpectedCompleteDateEdit.Size = New System.Drawing.Size(108, 19)
        Me.ExpectedCompleteDateEdit.TabIndex = 181
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(80, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 14)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "Expected Completion Date :"
        '
        'CompleteDateEdit
        '
        Me.CompleteDateEdit.DateTime = New Date(CType(0, Long))
        Me.CompleteDateEdit.Location = New System.Drawing.Point(240, 128)
        Me.CompleteDateEdit.Name = "CompleteDateEdit"
        Me.CompleteDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CompleteDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CompleteDateEdit.Size = New System.Drawing.Size(108, 19)
        Me.CompleteDateEdit.TabIndex = 179
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(240, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Completion Date :"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(8, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 18)
        Me.Label44.TabIndex = 140
        Me.Label44.Text = "IO :"
        '
        'SurveyOrderLineForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(386, 239)
        Me.Controls.Add(Me.QtyTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SurveyOrderLineForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Survey Order Line"
        CType(Me.QtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DescriptionMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IOCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedCompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable "
    Public FormStatus As String

    Public SOLine_ID As Integer
    Public SO_ID As Integer
    Public Item_No As Integer
    Public Contract_ID As Integer
    Public OGB_IO_ID As Integer
    Public Description As String
    Public Qty As Integer
    Public Expected_Completion_Date As String
    Public Completion_Date As String
    Public Remarks As String
    Public Create_Date As String
    Public Transact_Date As String
    Public UserID As String = Common.CommonConn.Config.USERID

#End Region

#Region " Code - Form load"
    Private Sub DeiveryNoteLineForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case UCase(FormStatus)
            Case "NEW"
                InitializeForm()
                LoadIO(FormStatus)

            Case "EDIT"
                LoadIO(FormStatus)
                Dim ds As DataSet
                With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
                    If .GetSOLine_ByLineID(ds, SOLine_ID) Then
                        SetWindowValue(ds)
                    End If
                End With
        End Select
    End Sub

    Private Sub InitializeForm()
        ExpectedCompleteDateEdit.DateTime = Date.Today
    End Sub

#End Region

#Region "Load IO Listbox"

    Private Sub LoadIO(ByVal pStatus As String)
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBBusLogic
            .Contract_Id = Contract_ID

            If pStatus = "NEW" Then
                .GetIOWContractIdSONotCreated(ds)
            Else
                .GetIOWContractId(ds)
            End If

            If Not ds Is Nothing Then
                Try
                    'SimpleBinding LookUp adjustment start
                    AddListFieldInfoToLookUp(IOcmb, "IO_No", 400, 0, "c")
                    IOCmb.Properties.LookUpData.KeyField = "OGB_IO_Id"
                    IOcmb.Properties.LookUpData.DisplayField = "IO_No"

                    IOcmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    IOcmb.EditValue = "0"
                    'SimpleBinding LookUp adjustment end
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub IOCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles IOCmb.CloseUp
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBBusLogic
            .OGB_IO_Id = IOCmb.Properties.LookUpData.KeyValue
            .Contract_Id = Contract_ID
            If UCase(FormStatus) = "NEW" Then
                .GetIOWContractIdSONotCreated(ds)
            Else
                .GetIOWContractId(ds)
            End If
        End With

        If Not ds Is Nothing Then
            If ds.Tables(0).Rows.Count > 0 Then
                If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Location")) Then
                    LocationTxt.Text = ds.Tables(0).Rows(0)("OGB_Location")
                End If
            End If
        End If
        ds.Dispose()
    End Sub


#End Region

#Region " Btn event "
    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        Me.SelectBtn.Focus()
        If RetrieveFromForm() Then
            Select Case UCase(FormStatus)
                Case "NEW"
                    SaveSurveyOrderLine()
                Case "EDIT"
                    UpdateSurveyOrderLine()
            End Select
        End If
    End Sub

#End Region

#Region " Database Mgmt "
    Private Sub SaveSurveyOrderLine()
        With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
            If ValidData() Then
                .SO_ID = SO_ID
                .Item_No = Item_No
                .OGB_IO_ID = OGB_IO_ID
                .Qty = Qty
                .Description = Description
                .Expected_Completion_Date = Expected_Completion_Date
                .Completion_Date = Completion_Date
                .Remarks = Remarks
                .UserID = UserID

                .SaveSOLine()
                MessageBox.Show("Survey Order saved!", "Save Survey Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub UpdateSurveyOrderLine()
        With New BusinessRules.SurveyOrderBusRules.SurveyOrderBusLogic
            Me.SelectBtn.Focus()
            If ValidData() Then
                .SO_ID = SO_ID
                .Item_No = Item_No
                .OGB_IO_ID = OGB_IO_ID
                .Qty = Qty
                .Description = Description
                .Expected_Completion_Date = Expected_Completion_Date
                .Completion_Date = Completion_Date
                .Remarks = Remarks
                .UserID = UserID

                .UpdateSOLine(SOLine_ID)
                MessageBox.Show("Survey Order updated!", "Updates Survey Order ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Function ValidData()
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        Qty = QtyTxt.Text

        If Qty = 0 Then
            DataOK_Flag = False
            FieldName = "Qty" & Chr(13)
        End If

        If OGB_IO_ID = 0 Then
            FieldName = FieldName & "IO" & Chr(13)
            DataOK_Flag = False
        End If

        If Expected_Completion_Date = "" Then
            FieldName = FieldName & "Expected Completion Date" & Chr(13)
            DataOK_Flag = False
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If

        ValidData = DataOK_Flag
    End Function

    Private Function RetrieveFromForm() As Boolean

        'Item_No = ItemNoTxt.Text
        OGB_IO_ID = IOcmb.Properties.LookUpData.KeyValue
        Qty = Integer.Parse(QtyTxt.Text)
        Description = DescriptionMemoEdit.Text
        Expected_Completion_Date = Me.ExpectedCompleteDateEdit.Text
        Completion_Date = Me.CompleteDateEdit.Text
        Remarks = RemarksTxt.Text

        Return True
    End Function
#End Region

#Region " Code - Set/Get Window Values"
    Private Sub SetWindowValue(ByVal dsLoad As DataSet)

        ItemNoTxt.Text = dsLoad.Tables(0).Rows(0)("Item_No")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("OGB_IO_ID")) Then
            If dsLoad.Tables(0).Rows(0)("OGB_IO_ID") > 0 Then
                Me.IOcmb.Properties.LookUpData.KeyValue = dsLoad.Tables(0).Rows(0)("OGB_IO_ID")

                Dim ds As DataSet
                With New BusinessRules.OGBBusRules.OGBBusLogic
                    If .GetIO(ds, dsLoad.Tables(0).Rows(0)("OGB_IO_ID")) Then
                        If ds.Tables(0).Rows.Count > 0 Then
                            If Not IsDBNull(ds.Tables(0).Rows(0)("OGB_Location")) Then
                                LocationTxt.Text = ds.Tables(0).Rows(0)("OGB_Location")
                            End If
                        End If
                    End If
                End With
                ds.Dispose()
            End If
        End If

        QtyTxt.Text = dsLoad.Tables(0).Rows(0)("Qty")

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Expected_Complete_Date")) Then
            Me.ExpectedCompleteDateEdit.DateTime = dsLoad.Tables(0).Rows(0)("Expected_Complete_Date")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Completion_Date")) Then
            Me.CompleteDateEdit.DateTime = dsLoad.Tables(0).Rows(0)("Completion_Date")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Description")) Then
            DescriptionMemoEdit.Text = dsLoad.Tables(0).Rows(0)("Description")
        End If

        If Not IsDBNull(dsLoad.Tables(0).Rows(0)("Remarks")) Then
            RemarksTxt.Text = dsLoad.Tables(0).Rows(0)("Remarks")
        End If
    End Sub

#End Region

    Private Sub SurveyOrderLineForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Survey Order Line?", "Work Plan Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Me.Close()
            '            Dim a As MainForm = Me.ParentForm
            '            If (a.MainTabControl.TabPages.Count > 0) Then
            '                If Not (a.MainTabControl.SelectedTab Is Nothing) Then
            '                    a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            '                End If
            '        End If
        Else
            e.Cancel = True
        End If
    End Sub
End Class
