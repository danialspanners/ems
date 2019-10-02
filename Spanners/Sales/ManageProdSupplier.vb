Public Class ManageProdSupForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Parent As MainForm)
        MyBase.New()

        ParentObject = Parent

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Transactdate.DateTime = DateTime.Today
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SupplierCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaveBut As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CatalogSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EnquirySpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PurchaseSpin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Transactdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CurrencyCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label39 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.SupplierCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.CatalogSpin = New DevExpress.XtraEditors.SpinEdit
        Me.EnquirySpin = New DevExpress.XtraEditors.SpinEdit
        Me.PurchaseSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SaveBut = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Transactdate = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.CurrencyCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label39 = New System.Windows.Forms.Label
        CType(Me.SupplierCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalogSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquirySpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier :"
        '
        'SupplierCmb
        '
        Me.SupplierCmb.Location = New System.Drawing.Point(76, 16)
        Me.SupplierCmb.Name = "SupplierCmb"
        Me.SupplierCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SupplierCmb.Properties.NullString = ""
        Me.SupplierCmb.Properties.PopupWidth = 380
        Me.SupplierCmb.Size = New System.Drawing.Size(376, 21)
        Me.SupplierCmb.TabIndex = 1
        '
        'CatalogSpin
        '
        Me.CatalogSpin.Location = New System.Drawing.Point(116, 112)
        Me.CatalogSpin.Name = "CatalogSpin"
        Me.CatalogSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CatalogSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CatalogSpin.Size = New System.Drawing.Size(104, 19)
        Me.CatalogSpin.TabIndex = 2
        Me.CatalogSpin.Text = "0"
        Me.CatalogSpin.Visible = False
        '
        'EnquirySpin
        '
        Me.EnquirySpin.Location = New System.Drawing.Point(332, 80)
        Me.EnquirySpin.Name = "EnquirySpin"
        Me.EnquirySpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.EnquirySpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnquirySpin.Size = New System.Drawing.Size(104, 19)
        Me.EnquirySpin.TabIndex = 3
        Me.EnquirySpin.Text = "0"
        Me.EnquirySpin.Visible = False
        '
        'PurchaseSpin
        '
        Me.PurchaseSpin.Location = New System.Drawing.Point(112, 80)
        Me.PurchaseSpin.Name = "PurchaseSpin"
        Me.PurchaseSpin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PurchaseSpin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PurchaseSpin.Size = New System.Drawing.Size(104, 19)
        Me.PurchaseSpin.TabIndex = 4
        Me.PurchaseSpin.Text = "0"
        Me.PurchaseSpin.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Catalog Price :"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(236, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enquiry Price :"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Purchase Price :"
        Me.Label4.Visible = False
        '
        'SaveBut
        '
        Me.SaveBut.AutoSize = False
        Me.SaveBut.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBut.Image = Nothing
        Me.SaveBut.Location = New System.Drawing.Point(308, 108)
        Me.SaveBut.Name = "SaveBut"
        Me.SaveBut.Size = New System.Drawing.Size(72, 32)
        Me.SaveBut.TabIndex = 8
        Me.SaveBut.Text = "Save"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(388, 108)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "&Cancel"
        '
        'Transactdate
        '
        Me.Transactdate.DateTime = New Date(CType(0, Long))
        Me.Transactdate.Location = New System.Drawing.Point(276, 48)
        Me.Transactdate.Name = "Transactdate"
        Me.Transactdate.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.Transactdate.Properties.MaskData.EditMask = "##/##/####"
        Me.Transactdate.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Transactdate.Size = New System.Drawing.Size(176, 21)
        Me.Transactdate.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(232, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 23)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Date:"
        '
        'CurrencyCmb
        '
        Me.CurrencyCmb.Location = New System.Drawing.Point(76, 48)
        Me.CurrencyCmb.Name = "CurrencyCmb"
        Me.CurrencyCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CurrencyCmb.Properties.NullString = ""
        Me.CurrencyCmb.Properties.PopupWidth = 380
        Me.CurrencyCmb.Size = New System.Drawing.Size(146, 21)
        Me.CurrencyCmb.TabIndex = 111
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(20, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(68, 23)
        Me.Label39.TabIndex = 110
        Me.Label39.Text = "Currency:"
        '
        'ManageProdSupForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(474, 159)
        Me.Controls.Add(Me.CurrencyCmb)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Transactdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PurchaseSpin)
        Me.Controls.Add(Me.EnquirySpin)
        Me.Controls.Add(Me.CatalogSpin)
        Me.Controls.Add(Me.SupplierCmb)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageProdSupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Product's Supplier"
        CType(Me.SupplierCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalogSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquirySpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ProductSupplier_ID As Integer
    Public Product_ID As Integer
    Public Supplier_ID As Integer
    Public Currency As Integer
    Public Catalog_Price As Decimal
    Public Enquiry_Price As Decimal
    Public Purchase_Price As Decimal
    Public History_Record As String
    Public Create_Date As String
    Public Transact_Date As DateTime
    Public UserID As Integer

    Public Supplier_Name As String

    Public NewItem As Boolean

    Public FromPR As Boolean

    Public ParentObject

    ' 11.01.2004 YG Start
    Dim FunctionName As String = "PartSupplier"
    ' 11.04.2004 YG End

#Region " Other Code"


    'Load list of supplier to combo
    Private Sub LoadSupplier()
        Dim ds As DataSet
        'Load supplier list
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            If .LoadList(ds) Then
                If Not ds Is Nothing Then
                    Try
                        SupplierCmb.Properties.LookUpData.ListFields.Clear()

                        AddListFieldInfoToLookUp(SupplierCmb, "Supplier_Name", 200, 0, "")

                        SupplierCmb.Properties.LookUpData.KeyField = "Supplier_ID"
                        SupplierCmb.Properties.LookUpData.DisplayField = "Supplier_Name"
                        SupplierCmb.Properties.LookUpData.DataSource = ds.Tables(0)

                        If Supplier_ID <> Nothing Then
                            SupplierCmb.Properties.LookUpData.KeyValue = New Decimal(New Integer() {Supplier_ID, 0, 0, 0})
                        End If

                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
        'End load supplier list
    End Sub

    Private Sub LoadCurrency()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.CurrencyBusLogic
            If .GetCurrency(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(CurrencyCmb, "CurrencyName", 200, 0, "c")
                        AddListFieldInfoToLookUp(CurrencyCmb, "CurrencySymbol", "20", 0, "c")
                        CurrencyCmb.Properties.LookUpData.KeyField = "Currency_ID"
                        CurrencyCmb.Properties.LookUpData.DisplayField = "CurrencyName"
                        CurrencyCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        CurrencyCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
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

#Region " Code - Windows Events"

    Private Sub ManageProdSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 11.01.2004 YG Start
        Dim a As MainForm = ParentObject 'Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            SaveBut.Enabled = True
        Else
            SaveBut.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBut.Enabled = True
        Else
            SaveBut.Enabled = False
        End If
        ' 11.01.2004 YG End

        LoadSupplier()
        LoadCurrency()
        NewItem = False

        If FromPR Then
            'EnquirySpin.Text = Enquiry_Price
            PurchaseSpin.Text = Purchase_Price
            EnquirySpin.Enabled = False
            SupplierCmb.Enabled = False
        End If

    End Sub

    Private Sub SaveBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBut.Click

        Supplier_Name = SupplierCmb.Text

        Supplier_ID = SupplierCmb.Properties.LookUpData.KeyValue().ToString()
        Currency = CInt(CurrencyCmb.Properties.LookUpData.KeyValue())
        Purchase_Price = Decimal.Parse(PurchaseSpin.Text)
        Enquiry_Price = Decimal.Parse(EnquirySpin.Text)
        Catalog_Price = Decimal.Parse(CatalogSpin.Text)
        Transact_Date = Transactdate.DateTime

        NewItem = True
        Close()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

#End Region

    Private Sub SupplierCmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SupplierCmb.ValueChanged
        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            Dim dsSupplier As DataSet
            If .GetSupplier(dsSupplier, Me.SupplierCmb.Properties.LookUpData.KeyValue) Then
                Me.CurrencyCmb.Properties.LookUpData.KeyValue = dsSupplier.Tables(0).Rows(0)("Currency_ID")
            End If
        End With
    End Sub
End Class
