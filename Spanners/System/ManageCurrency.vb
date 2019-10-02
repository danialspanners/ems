Public Class ManageCurrency
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewCurrencyBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CurrencyTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CurrencyList As System.Windows.Forms.ListBox
    Friend WithEvents CurrencySymbolTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExchangeRate_SGD As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ManageCurrency))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CurrencySymbolTxt = New DevExpress.XtraEditors.TextEdit
        Me.NewCurrencyBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CurrencyTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.CurrencyList = New System.Windows.Forms.ListBox
        Me.ExchangeRate_SGD = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.CurrencySymbolTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExchangeRate_SGD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExchangeRate_SGD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CurrencySymbolTxt)
        Me.GroupBox1.Controls.Add(Me.NewCurrencyBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.CurrencyTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CurrencyList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 386)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Currency"
        '
        'CurrencySymbolTxt
        '
        Me.CurrencySymbolTxt.Location = New System.Drawing.Point(136, 280)
        Me.CurrencySymbolTxt.Name = "CurrencySymbolTxt"
        Me.CurrencySymbolTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrencySymbolTxt.Size = New System.Drawing.Size(48, 19)
        Me.CurrencySymbolTxt.TabIndex = 121
        '
        'NewCurrencyBtn
        '
        Me.NewCurrencyBtn.AutoSize = False
        Me.NewCurrencyBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewCurrencyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCurrencyBtn.Image = Nothing
        Me.NewCurrencyBtn.Location = New System.Drawing.Point(184, 216)
        Me.NewCurrencyBtn.Name = "NewCurrencyBtn"
        Me.NewCurrencyBtn.Size = New System.Drawing.Size(104, 24)
        Me.NewCurrencyBtn.TabIndex = 120
        Me.NewCurrencyBtn.Text = "New Currency"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Currency Symbol:"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(152, 352)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(64, 24)
        Me.DeleteBtn.TabIndex = 117
        Me.DeleteBtn.Text = "&Delete"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(224, 352)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 116
        Me.CancelBtn.Text = "&Close"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(80, 352)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 115
        Me.SaveBtn.Text = "&Save"
        '
        'CurrencyTxt
        '
        Me.CurrencyTxt.Location = New System.Drawing.Point(136, 248)
        Me.CurrencyTxt.Name = "CurrencyTxt"
        Me.CurrencyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CurrencyTxt.Size = New System.Drawing.Size(152, 19)
        Me.CurrencyTxt.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Currency :"
        '
        'CurrencyList
        '
        Me.CurrencyList.Location = New System.Drawing.Point(8, 24)
        Me.CurrencyList.Name = "CurrencyList"
        Me.CurrencyList.Size = New System.Drawing.Size(280, 186)
        Me.CurrencyList.TabIndex = 112
        '
        'ExchangeRate_SGD
        '
        Me.ExchangeRate_SGD.Location = New System.Drawing.Point(136, 312)
        Me.ExchangeRate_SGD.Name = "ExchangeRate_SGD"
        Me.ExchangeRate_SGD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ExchangeRate_SGD.Properties.Format = CType(resources.GetObject("resource.Format"), System.IFormatProvider)
        Me.ExchangeRate_SGD.Size = New System.Drawing.Size(72, 19)
        Me.ExchangeRate_SGD.TabIndex = 123
        Me.ExchangeRate_SGD.Text = "-1.0"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Exchange rate to SGD:"
        '
        'ManageCurrency
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 405)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageCurrency"
        Me.ShowInTaskbar = False
        Me.Text = "Manage Currency"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CurrencySymbolTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExchangeRate_SGD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Currency_Id As Integer
    Public CurrencyName As String
    Public CurrencySymbol As String
    Public ExchangeRateSGD As Decimal
    'Public UserID As String = "1"
    Private UserID As Integer = Common.CommonConn.Config.USERID

    ' 06.01.2004 YG Start
    Dim FunctionName As String = "MyCurrency"
    ' 06.01.2004 YG End

    Private Sub ManageCurrencyForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewCurrencyBtn.Enabled = True
        Else
            NewCurrencyBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 06.01.2004 YG End

        LoadCurrency()
        DeleteBtn.Enabled = False
    End Sub

    Private Sub ResetForm()
        CurrencyTxt.Text = ""
        CurrencySymbolTxt.Text = ""
        ExchangeRate_SGD.Text = "-1.0"
    End Sub

    Private Sub LoadCurrency()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.CurrencyBusLogic
            If .GetCurrency(ds) Then
                If Not ds Is Nothing Then
                    Try
                        CurrencyList.DisplayMember = "CurrencyName"
                        CurrencyList.ValueMember = "Currency_Id"

                        CurrencyList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With

        If CurrencyList.Items.Count > 0 Then
            CurrencyList_SelectedIndexChanged(Nothing, Nothing)
        End If

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If ValidData() Then
            If Not CurrencyNameExist() Then
                With New BusinessRules.SystemBusRules.CurrencyBusLogic
                    .CurrencyName = CurrencyName
                    .CurrencySymbol = CurrencySymbol
                    .ExchangeRate_SGD = ExchangeRateSGD
                    .UserID = UserID
                    If Currency_Id = 0 Or Currency_Id = Nothing Then
                        If .SaveCurrency() Then
                            MessageBox.Show("Currency saved. ", "Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        LoadCurrency()
                        ResetForm()
                    Else
                        .UpdateCurrency(Currency_Id)
                        MessageBox.Show("Currency updated. ", "Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    'LoadCurrency()
                    'ResetForm()
                End With
            Else
                MessageBox.Show("Currency already exist !", "Manage Currency", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        CurrencyName = CurrencyTxt.Text
        CurrencySymbol = CurrencySymbolTxt.Text
        ExchangeRateSGD = ExchangeRate_SGD.Text

        If Not Len(CurrencyName) > 0 Then
            DataOK_Flag = False
            FieldName = "Currency" & Chr(13)
        End If

        If Not Len(CurrencySymbol) > 0 Then
            DataOK_Flag = False
            FieldName = "Currency Symbol" & Chr(13)
        End If

        If Not Len(ExchangeRate_SGD.Text) > 0 Then
            DataOK_Flag = False
            FieldName = "Exchange Rate" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function
    '## Added by Alan
    Private Function CurrencyNameExist() As Boolean
        Dim NameExist_Flag As Boolean = False
        Dim dsCurrency As DataSet
        Dim dsCurrencySymbol As DataSet
        Dim rowCount As Integer
        Dim i As Integer

        With New BusinessRules.SystemBusRules.CurrencyBusLogic
            If .GetCurrency(dsCurrency) Then
                rowCount = dsCurrency.Tables(0).Rows.Count()
                For i = 0 To (rowCount - 1)
                    If UCase(CurrencyName) = UCase(dsCurrency.Tables(0).Rows(i).Item("CurrencyName")) And dsCurrency.Tables(0).Rows(i).Item("Currency_Id") <> Currency_Id Then
                        NameExist_Flag = True
                        'CurrencyNameExist = NameExist_Flag
                        Exit For
                    Else
                        NameExist_Flag = False
                    End If
                Next i
            End If
        End With
        CurrencyNameExist = NameExist_Flag
    End Function
    '## End
    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Currency", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Currency_Id = CurrencyList.SelectedValue.ToString
            With New BusinessRules.SystemBusRules.CurrencyBusLogic
                .Currency_Id = Currency_Id
                If .DeleteCurrency() Then
                    MessageBox.Show("Currency deleted. ", "Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadCurrency()
                End If
            End With
        End If
    End Sub

    Private Sub CurrencyList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrencyList.SelectedIndexChanged
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DeleteBtn.Enabled = True
        Else
            DeleteBtn.Enabled = False
        End If

        '        DeleteBtn.Enabled = True
        ' 06.01.2004 YG End

        Currency_Id = CurrencyList.SelectedValue.ToString
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.CurrencyBusLogic
            If .GetCurrency(ds, Currency_Id) Then
                CurrencyTxt.Text = ds.Tables(0).Rows(0)("CurrencyName")
                CurrencySymbolTxt.Text = ds.Tables(0).Rows(0)("CurrencySymbol")
                ExchangeRate_SGD.Text = ds.Tables(0).Rows(0)("ExchangeRate_SGD")
            End If
        End With
        SaveBtn.Text = "Update"
        CurrencyTxt.Enabled = False
    End Sub

    Private Sub NewCurrencyBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCurrencyBtn.Click
        SaveBtn.Text = "Save"
        CurrencyTxt.Enabled = True
        CurrencyTxt.Text = ""
        CurrencySymbolTxt.Text = ""
        ExchangeRate_SGD.Text = "-1.0"
        Currency_Id = Nothing
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ManageCurrency_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class

