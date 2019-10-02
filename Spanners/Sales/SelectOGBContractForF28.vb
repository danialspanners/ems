Public Class SelectOGBContractForF28Form
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
    Friend WithEvents ContractNoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IOCmb As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.ContractNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.IOCmb = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IOCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contract No :"
        '
        'ContractNoCmb
        '
        Me.ContractNoCmb.Location = New System.Drawing.Point(104, 16)
        Me.ContractNoCmb.Name = "ContractNoCmb"
        Me.ContractNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContractNoCmb.Properties.NullString = ""
        Me.ContractNoCmb.Properties.PopupWidth = 184
        Me.ContractNoCmb.Size = New System.Drawing.Size(184, 19)
        Me.ContractNoCmb.TabIndex = 1
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(216, 128)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 5
        Me.CancelBtn.Text = "&Cancel"
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(136, 128)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(68, 32)
        Me.SelectBtn.TabIndex = 4
        Me.SelectBtn.Text = "Select"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "I/O No :"
        '
        'IOCmb
        '
        Me.IOCmb.Location = New System.Drawing.Point(104, 56)
        Me.IOCmb.Name = "IOCmb"
        Me.IOCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.IOCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.IOCmb.Properties.NullString = ""
        Me.IOCmb.Properties.PopupWidth = 184
        Me.IOCmb.Size = New System.Drawing.Size(184, 19)
        Me.IOCmb.TabIndex = 7
        '
        'SelectOGBContractForF28Form
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 173)
        Me.Controls.Add(Me.IOCmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.ContractNoCmb)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectOGBContractForF28Form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contract No"
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IOCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Contract_Id As Integer
    Public IO_Id As Integer

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Contract_Id = 0
        Me.Close()
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        'Contract_Id = ContractNoCmb.Properties.LookUpData.KeyValue
        IO_Id = IOCmb.Properties.LookUpData.KeyValue
        Me.Close()
    End Sub

    Private Sub SelectOGBContractForF28Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            If .GetOGBContract(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(ContractNoCmb, "OGB_Contract_No", 400, 0, "c")
                    ContractNoCmb.Properties.LookUpData.KeyField = "OGB_Contract_Id"
                    ContractNoCmb.Properties.LookUpData.DisplayField = "OGB_Contract_No"

                    ContractNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    ContractNoCmb.EditValue = "0"
                End If
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub ContractNoCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles ContractNoCmb.CloseUp
        Dim ds As DataSet

        With New BusinessRules.OGBBusRules.OGBBusLogic
            If Len(e.Value) > 0 Then
                .Contract_Id = e.Value
                If .GetIOWContractId(ds) Then
                    If Not ds Is Nothing Then
                        IOCmb.Properties.LookUpData.ListFields.Clear()
                        AddListFieldInfoToLookUp(IOCmb, "IO_No", 400, 0, "c")
                        IOCmb.Properties.LookUpData.KeyField = "OGB_IO_Id"
                        IOCmb.Properties.LookUpData.DisplayField = "IO_No"

                        IOCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        IOCmb.EditValue = "0"
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub ContractNoCmb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContractNoCmb.KeyUp
        If e.KeyValue = 13 Then
            e.Handled = True
            SelectBtn_Click(sender, e)
        End If
    End Sub

    Private Sub IOCmb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IOCmb.KeyUp
        If e.KeyValue = 13 Then
            e.Handled = True
            SelectBtn_Click(sender, e)
        End If
    End Sub
End Class
