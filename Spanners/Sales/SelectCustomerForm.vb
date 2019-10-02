Public Class SelectCustomerForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.CustomerCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.CustomerCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name :"
        '
        'CustomerCmb
        '
        Me.CustomerCmb.Location = New System.Drawing.Point(104, 40)
        Me.CustomerCmb.Name = "CustomerCmb"
        Me.CustomerCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CustomerCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.CustomerCmb.Properties.NullString = ""
        Me.CustomerCmb.Properties.PopupWidth = 192
        Me.CustomerCmb.Size = New System.Drawing.Size(192, 19)
        Me.CustomerCmb.TabIndex = 1
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(160, 80)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(64, 32)
        Me.SelectBtn.TabIndex = 2
        Me.SelectBtn.Text = "Select"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(232, 80)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        '
        'SelectCustomerForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 181)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.CustomerCmb)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectCustomerForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Customer"
        CType(Me.CustomerCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Customer_ID As Integer

    Private Sub SelectCustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCustomerDetails()
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

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        Customer_ID = CustomerCmb.Properties.LookUpData.KeyValue
        'Dim form As New OrderConfirmationForm("NEW")
        'form.Customer_ID = Customer_ID
        'form.ShowDialog()
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Customer_ID = 0
        Me.Close()
    End Sub
End Class
