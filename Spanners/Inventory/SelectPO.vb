Imports DevExpress.XtraEditors.Controls

Public Class SelectPOForm
    Inherits System.Windows.Forms.Form

#Region " Declare Public Variables"
    Public PO_ID As Integer
    Public PO_No As String
#End Region

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
    Friend WithEvents lblPONo As System.Windows.Forms.Label
    Friend WithEvents cmbPONo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.lblPONo = New System.Windows.Forms.Label
        Me.cmbPONo = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.cmbPONo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(216, 80)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 7
        Me.CancelBtn.Text = "&Cancel"
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(136, 80)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(68, 32)
        Me.SelectBtn.TabIndex = 6
        Me.SelectBtn.Text = "Select"
        '
        'lblPONo
        '
        Me.lblPONo.Location = New System.Drawing.Point(24, 24)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(48, 16)
        Me.lblPONo.TabIndex = 5
        Me.lblPONo.Text = "PO No :"
        '
        'cmbPONo
        '
        Me.cmbPONo.Location = New System.Drawing.Point(80, 24)
        Me.cmbPONo.Name = "cmbPONo"
        Me.cmbPONo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmbPONo.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.cmbPONo.Properties.NullString = ""
        Me.cmbPONo.Properties.PopupWidth = 200
        Me.cmbPONo.Size = New System.Drawing.Size(200, 19)
        Me.cmbPONo.TabIndex = 4
        '
        'SelectPOForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(304, 134)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.lblPONo)
        Me.Controls.Add(Me.cmbPONo)
        Me.Name = "SelectPOForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Purchase Order"
        CType(Me.cmbPONo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load Form"
    Private Sub SelectPOForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsPO As DataSet
        With New BusinessRules.BusRules.InventoryBusLogic
            If .GetPOHeader(dsPO) Then
                If dsPO.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(cmbPONo, "PO_NO", 200, 0, "c")
                    cmbPONo.Properties.LookUpData.KeyField = "PO_ID"
                    cmbPONo.Properties.LookUpData.DisplayField = "PO_NO"
                    cmbPONo.Properties.LookUpData.DataSource = dsPO.Tables(0)
                    cmbPONo.EditValue = "0"
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

#Region " Button actions"
    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        PO_ID = cmbPONo.Properties.LookUpData.KeyValue
        PO_No = cmbPONo.Text
        If PO_ID = 0 Or PO_No = "" Then
            Dim Result As DialogResult = MessageBox.Show("You did not select a PO !", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
        End If

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
#End Region

End Class
