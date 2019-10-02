Imports DevExpress.XtraEditors.Controls

Public Class SelectQuotationCopyForm
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
    Friend WithEvents QuotationNoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Header_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents COM_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ALL_RadioButton As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.QuotationNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Header_RadioButton = New System.Windows.Forms.RadioButton
        Me.COM_RadioButton = New System.Windows.Forms.RadioButton
        Me.ALL_RadioButton = New System.Windows.Forms.RadioButton
        CType(Me.QuotationNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuotationNoCmb
        '
        Me.QuotationNoCmb.Location = New System.Drawing.Point(96, 32)
        Me.QuotationNoCmb.Name = "QuotationNoCmb"
        Me.QuotationNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.QuotationNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.QuotationNoCmb.Properties.NullString = ""
        Me.QuotationNoCmb.Properties.PopupWidth = 200
        Me.QuotationNoCmb.Size = New System.Drawing.Size(200, 19)
        Me.QuotationNoCmb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quotation No :"
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(152, 168)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(68, 32)
        Me.SelectBtn.TabIndex = 2
        Me.SelectBtn.Text = "Select"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(232, 168)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "&Cancel"
        '
        'Header_RadioButton
        '
        Me.Header_RadioButton.Location = New System.Drawing.Point(96, 96)
        Me.Header_RadioButton.Name = "Header_RadioButton"
        Me.Header_RadioButton.TabIndex = 4
        Me.Header_RadioButton.Text = "Headers only"
        '
        'COM_RadioButton
        '
        Me.COM_RadioButton.Checked = True
        Me.COM_RadioButton.Location = New System.Drawing.Point(96, 72)
        Me.COM_RadioButton.Name = "COM_RadioButton"
        Me.COM_RadioButton.Size = New System.Drawing.Size(144, 24)
        Me.COM_RadioButton.TabIndex = 5
        Me.COM_RadioButton.TabStop = True
        Me.COM_RadioButton.Text = "Components only"
        '
        'ALL_RadioButton
        '
        Me.ALL_RadioButton.Location = New System.Drawing.Point(96, 120)
        Me.ALL_RadioButton.Name = "ALL_RadioButton"
        Me.ALL_RadioButton.TabIndex = 6
        Me.ALL_RadioButton.Text = "All"
        '
        'SelectQuotationCopyForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(322, 215)
        Me.Controls.Add(Me.ALL_RadioButton)
        Me.Controls.Add(Me.COM_RadioButton)
        Me.Controls.Add(Me.Header_RadioButton)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuotationNoCmb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectQuotationCopyForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quotation No"
        CType(Me.QuotationNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Quotation_ID As Integer
    Public SelectFlag As Integer

    Private Sub SelectQuotationCopyForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsQuotation As DataSet
        Quotation_ID = 0
        With New BusinessRules.SaleBusRules.SaleBusLogic
            'If .GetQuotationHeaderWORevisedQuo(dsQuotation) Then
            If .GetQuotationHeader(dsQuotation) Then
                If dsQuotation.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(QuotationNoCmb, "Quotation_NO", 400, 0, "c")
                    QuotationNoCmb.Properties.LookUpData.KeyField = "Quotation_ID"
                    QuotationNoCmb.Properties.LookUpData.DisplayField = "Quotation_NO"

                    QuotationNoCmb.Properties.LookUpData.DataSource = dsQuotation.Tables(0)
                    QuotationNoCmb.EditValue = "0"
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
        Quotation_ID = QuotationNoCmb.Properties.LookUpData.KeyValue
        If (Quotation_ID <> 0) Then
            If (Me.COM_RadioButton.Checked = True) Then
                SelectFlag = 1
            ElseIf (Me.Header_RadioButton.Checked = True) Then
                SelectFlag = 2
            Else
                SelectFlag = 3
            End If
            Me.Close()
        Else
            MessageBox.Show("Please select a Quotation to copy from.")
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Quotation_ID = 0
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Header_RadioButton.CheckedChanged

    End Sub
End Class
