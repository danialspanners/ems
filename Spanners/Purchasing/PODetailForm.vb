Public Class PODetailForm
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SupplierTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CurrencyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaymentTermsTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RemarksTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NotesTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DiscountTypeLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DiscountSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GSTCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents GeneratePOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ShipmentDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeliverToTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents POTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PaymentTermsTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CurrencyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.SupplierTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.GSTCheck = New DevExpress.XtraEditors.CheckEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.POTitle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.DeliverToTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.ShipmentDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.DiscountSpin = New DevExpress.XtraEditors.SpinEdit
        Me.DiscountTypeLookup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.NotesTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.RemarksTxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GeneratePOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.PaymentTermsTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSTCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.POTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverToTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountTypeLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PaymentTermsTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CurrencyTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.SupplierTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Info"
        '
        'PaymentTermsTxt
        '
        Me.PaymentTermsTxt.Location = New System.Drawing.Point(104, 72)
        Me.PaymentTermsTxt.Name = "PaymentTermsTxt"
        Me.PaymentTermsTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PaymentTermsTxt.Properties.Enabled = False
        Me.PaymentTermsTxt.Properties.ReadOnly = True
        Me.PaymentTermsTxt.Size = New System.Drawing.Size(176, 19)
        Me.PaymentTermsTxt.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Payment Terms :"
        '
        'CurrencyTxt
        '
        Me.CurrencyTxt.Location = New System.Drawing.Point(104, 48)
        Me.CurrencyTxt.Name = "CurrencyTxt"
        Me.CurrencyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrencyTxt.Properties.Enabled = False
        Me.CurrencyTxt.Properties.ReadOnly = True
        Me.CurrencyTxt.Size = New System.Drawing.Size(176, 19)
        Me.CurrencyTxt.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Currency :"
        '
        'SupplierTxt
        '
        Me.SupplierTxt.Location = New System.Drawing.Point(104, 24)
        Me.SupplierTxt.Name = "SupplierTxt"
        Me.SupplierTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SupplierTxt.Properties.Enabled = False
        Me.SupplierTxt.Properties.ReadOnly = True
        Me.SupplierTxt.Size = New System.Drawing.Size(360, 19)
        Me.SupplierTxt.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier :"
        '
        'GSTCheck
        '
        Me.GSTCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GSTCheck.Location = New System.Drawing.Point(228, 48)
        Me.GSTCheck.Name = "GSTCheck"
        Me.GSTCheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GSTCheck.Properties.Caption = "GST"
        Me.GSTCheck.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.InactiveBorder, System.Drawing.SystemColors.WindowText)
        Me.GSTCheck.Size = New System.Drawing.Size(48, 15)
        Me.GSTCheck.TabIndex = 81
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.POTitle)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DeliverToTxt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ShipmentDateEdit)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DiscountSpin)
        Me.GroupBox2.Controls.Add(Me.DiscountTypeLookup)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.NotesTxt)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.RemarksTxt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GSTCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 240)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purchase Order Info"
        '
        'POTitle
        '
        Me.POTitle.Location = New System.Drawing.Point(104, 20)
        Me.POTitle.Name = "POTitle"
        Me.POTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.POTitle.Size = New System.Drawing.Size(312, 21)
        Me.POTitle.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Title:"
        '
        'DeliverToTxt
        '
        Me.DeliverToTxt.Location = New System.Drawing.Point(104, 72)
        Me.DeliverToTxt.Name = "DeliverToTxt"
        Me.DeliverToTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DeliverToTxt.Properties.MaxLength = 200
        Me.DeliverToTxt.Size = New System.Drawing.Size(312, 40)
        Me.DeliverToTxt.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 40)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Deliver To :"
        '
        'ShipmentDateEdit
        '
        Me.ShipmentDateEdit.DateTime = New Date(CType(0, Long))
        Me.ShipmentDateEdit.Location = New System.Drawing.Point(104, 48)
        Me.ShipmentDateEdit.Name = "ShipmentDateEdit"
        Me.ShipmentDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ShipmentDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ShipmentDateEdit.Properties.Format = Nothing
        Me.ShipmentDateEdit.Properties.FormatString = "dd/MM/yyyy"
        Me.ShipmentDateEdit.Properties.MaskData.EditMask = "##/##/####"
        Me.ShipmentDateEdit.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.ShipmentDateEdit.Size = New System.Drawing.Size(112, 19)
        Me.ShipmentDateEdit.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Delivery Date :"
        '
        'DiscountSpin
        '
        Me.DiscountSpin.Location = New System.Drawing.Point(272, 120)
        Me.DiscountSpin.Name = "DiscountSpin"
        Me.DiscountSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DiscountSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DiscountSpin.Size = New System.Drawing.Size(72, 19)
        Me.DiscountSpin.TabIndex = 4
        Me.DiscountSpin.Text = "0"
        '
        'DiscountTypeLookup
        '
        Me.DiscountTypeLookup.Location = New System.Drawing.Point(104, 120)
        Me.DiscountTypeLookup.Name = "DiscountTypeLookup"
        Me.DiscountTypeLookup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DiscountTypeLookup.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DiscountTypeLookup.Properties.NullString = ""
        Me.DiscountTypeLookup.Properties.PopupWidth = 168
        Me.DiscountTypeLookup.Size = New System.Drawing.Size(160, 19)
        Me.DiscountTypeLookup.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Discount :"
        '
        'NotesTxt
        '
        Me.NotesTxt.Location = New System.Drawing.Point(104, 192)
        Me.NotesTxt.Name = "NotesTxt"
        Me.NotesTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NotesTxt.Properties.MaxLength = 200
        Me.NotesTxt.Size = New System.Drawing.Size(312, 40)
        Me.NotesTxt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label5.Location = New System.Drawing.Point(8, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 40)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Notes - as an internal memo :"
        '
        'RemarksTxt
        '
        Me.RemarksTxt.Location = New System.Drawing.Point(104, 144)
        Me.RemarksTxt.Name = "RemarksTxt"
        Me.RemarksTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.RemarksTxt.Properties.MaxLength = 5000
        Me.RemarksTxt.Size = New System.Drawing.Size(312, 40)
        Me.RemarksTxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 40)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Remarks - To appear on document :"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(80, 368)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 1
        Me.CloseBtn.Text = "&Close"
        '
        'GeneratePOBtn
        '
        Me.GeneratePOBtn.AutoSize = False
        Me.GeneratePOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.GeneratePOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratePOBtn.Image = Nothing
        Me.GeneratePOBtn.Location = New System.Drawing.Point(8, 368)
        Me.GeneratePOBtn.Name = "GeneratePOBtn"
        Me.GeneratePOBtn.Size = New System.Drawing.Size(64, 32)
        Me.GeneratePOBtn.TabIndex = 0
        Me.GeneratePOBtn.Text = "Save"
        '
        'PODetailForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(488, 413)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.GeneratePOBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PODetailForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Details"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PaymentTermsTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSTCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.POTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverToTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountTypeLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    'Supplier Info
    Public Supplier_ID As Integer
    Public Supplier_Name As String
    Public Currency As String
    Public Payment_Term As String
    Public GST_Flg As String

    Public DeliveryDate As String
    Public DeliverTo As String
    Public DiscountType As String
    Public Discount As Double
    Public Remarks As String
    Public Notes As String
    Public Title As String

    Public SaveItem As Boolean
    Public records As BusinessRules.POBusRules.PORecord

#End Region


#Region " Database Management "

    Private Sub LoadSupplier()

        Dim Currency_ID As Integer
        'Load supplier
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .Load(Supplier_ID) Then
                Supplier_Name = .Supplier_Name
                GST_Flg = .GST_Flg
                Payment_Term = .Payment_Term

                If .Currency_ID <> 0 And .Currency_ID <> Nothing Then
                    Currency_ID = .Currency_ID
                    With New BusinessRules.CurrencyBusRules.CurrencyBusLogic
                        If .Load(Currency_ID) Then
                            Currency = .CurrencyName
                        End If
                    End With
                End If

            End If
        End With

    End Sub

    Private Sub LoadInfo()

        DeliveryDate = records.DeliveryDate
        DeliverTo = records.DeliverTo
        DiscountType = records.DiscountType
        Discount = records.Discount
        Remarks = records.Remarks
        Title = records.Title
        Notes = records.Notes

        If records.GST = 1 Then
            Me.GSTCheck.CheckState = CheckState.Checked
        Else
            Me.GSTCheck.CheckState = CheckState.Unchecked
        End If

    End Sub

    Private Sub LoadDiscountType()
        Dim discountTypeData As String() = New String() {"No Discount", "Discount by Amt", "Discount by Percentage"}
        Dim idData As String() = New String() {"0", "1", "2"}

        SetComboValue(discountTypeData, DiscountTypeLookup, idData)
    End Sub
#End Region

#Region " Event"

    Private Sub PODetailForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Supplier_ID <> 0 And Supplier_ID <> Nothing Then
            SaveItem = False

            LoadDiscountType()

            LoadSupplier()
            LoadInfo()


            SetWindowsValue()
        End If
    End Sub

    Private Sub GeneratePOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePOBtn.Click

        Me.GeneratePOBtn.Focus()

        GetWindowsValue()

        'If ValidData() Then
        records.Title = Me.Title
        records.DeliveryDate = DeliveryDate
        records.DeliverTo = DeliverTo
        records.DiscountType = DiscountType
        records.Discount = Discount
        records.Remarks = Remarks
        records.Notes = Notes

        If GSTCheck.CheckState = CheckState.Checked Then
            records.GST = 1
        Else
            records.GST = 0
        End If

        SaveItem = True
        Close()
        'End If

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

#End Region

#Region " Code - Set/Get Window Values"

    'Set windows values
    Private Sub SetWindowsValue()

        'Supplier Info
        SupplierTxt.Text = Supplier_Name
        CurrencyTxt.Text = Currency

        GSTCheck.CheckState = CheckState.Indeterminate

        If GST_Flg = "1" Then
            GSTCheck.CheckState = CheckState.Checked
        ElseIf GST_Flg = "0" Then
            GSTCheck.CheckState = CheckState.Unchecked
        End If
        PaymentTermsTxt.Text = Payment_Term

        'PO Info
        If DeliveryDate <> "" Then
            ShipmentDateEdit.DateTime = Date.Parse(DeliveryDate).Date
        End If



        DeliverToTxt.Text = DeliverTo

        If DiscountType <> "" Then
            DiscountTypeLookup.Properties.LookUpData.KeyValue = DiscountType
        Else
            DiscountTypeLookup.Properties.LookUpData.KeyValue = "0" 'New Decimal(New Integer() {0, 0, 0, 0})
        End If

        DiscountSpin.Text = Discount

        RemarksTxt.Text = Remarks

        POTitle.Text = Title

        NotesTxt.Text = Notes
    End Sub

    'Get Window Values
    Private Sub GetWindowsValue()

        If ShipmentDateEdit.Text <> "" Then
            DeliveryDate = ShipmentDateEdit.DateTime.Day & " " & MonthName(ShipmentDateEdit.DateTime.Month) & " " & ShipmentDateEdit.DateTime.Year
        Else
            DeliveryDate = ""
        End If

        DeliverTo = DeliverToTxt.Text

        If DiscountTypeLookup.Properties.LookUpData.KeyValue() <> Nothing Then
            DiscountType = DiscountTypeLookup.Properties.LookUpData.KeyValue().ToString()
        Else
            DiscountType = ""
        End If

        Discount = DiscountSpin.Text

        Remarks = RemarksTxt.Text

        Title = POTitle.Text

        Notes = NotesTxt.Text
    End Sub

#End Region

#Region " Code - Common Bus Logic"

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

#Region " Code - Checking for valid data"

    Private Function ValidData() As Boolean
        Dim DataOK_flag As Boolean
        Dim ErrorMessage As String

        DataOK_flag = True

        If DeliveryDate = "" Then
            ErrorMessage = ErrorMessage & " Delivery Date" & Chr(13)
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

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
