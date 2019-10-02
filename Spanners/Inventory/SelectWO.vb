Public Class SelectWOForm
    Inherits System.Windows.Forms.Form

#Region " Declare Public Variables"
    Public WO_ID As Integer
    Public WO_No As String
    Public Confirm_Quotation_No As String
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
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents lblWONo As System.Windows.Forms.Label
    Friend WithEvents lookupWOH As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.lblWONo = New System.Windows.Forms.Label
        Me.lookupWOH = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.lookupWOH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(208, 80)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 11
        Me.CancelBtn.Text = "&Cancel"
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(128, 80)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(68, 32)
        Me.SelectBtn.TabIndex = 10
        Me.SelectBtn.Text = "Select"
        '
        'lblWONo
        '
        Me.lblWONo.Location = New System.Drawing.Point(16, 24)
        Me.lblWONo.Name = "lblWONo"
        Me.lblWONo.Size = New System.Drawing.Size(48, 16)
        Me.lblWONo.TabIndex = 9
        Me.lblWONo.Text = "WO No :"
        '
        'lookupWOH
        '
        Me.lookupWOH.Location = New System.Drawing.Point(72, 24)
        Me.lookupWOH.Name = "lookupWOH"
        Me.lookupWOH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.lookupWOH.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.lookupWOH.Properties.NullString = ""
        Me.lookupWOH.Properties.PopupWidth = 200
        Me.lookupWOH.Size = New System.Drawing.Size(200, 19)
        Me.lookupWOH.TabIndex = 8
        '
        'SelectWOForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(288, 126)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.lblWONo)
        Me.Controls.Add(Me.lookupWOH)
        Me.Name = "SelectWOForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Work Order"
        CType(Me.lookupWOH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load Form"
    Private Sub SelectWOForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsWOH As DataSet

        With New BusinessRules.BusRules.InventoryBusLogic
            dsWOH = .GetWOHeader
            If Not dsWOH Is Nothing Then
                Try
                    lookupWOH.Properties.LookUpData.ListFields.Clear()
                    AddListFieldInfoToLookUp(lookupWOH, "WO_No", 200, 0, "")
                    lookupWOH.Properties.LookUpData.KeyField = "WO_ID"
                    lookupWOH.Properties.LookUpData.DisplayField = "WO_No"
					'lookupWOH.Properties.LookUpData.DisplayField = "Confirm_Quotation_No"
                    lookupWOH.Properties.LookUpData.DataSource = dsWOH.Tables(0)
                Catch exLoad As System.Exception
                    System.Windows.Forms.MessageBox.Show(exLoad.Message)
                End Try
            End If
        End With

        'Dim dsWOH As DataSet
        'With New BusinessRules.BusRules.InventoryBusLogic
        'If .GetWOHeader(dsWOH) Then
        'If dsWOH.Tables(0).Rows.Count > 0 Then
        'AddListFieldInfoToLookUp(cmbWONo, "WO_NO", 200, 0, "c")
        'cmbWONo.Properties.LookUpData.KeyField = "WO_ID"
        'cmbWONo.Properties.LookUpData.DisplayField = "WO_NO"
        'cmbWONo.Properties.LookUpData.DataSource = dsWOH.Tables(0)
        'cmbWONo.EditValue = "0"
        'End If
        'End If
        'End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub
#End Region

#Region " Button actions"
    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        WO_ID = lookupWOH.Properties.LookUpData.KeyValue
        WO_No = lookupWOH.Text
        Confirm_Quotation_No = lookupWOH.Text

        If WO_ID = 0 Or WO_No = "" Or Confirm_Quotation_No = "" Then
            Dim Result As DialogResult = MessageBox.Show("You did not select a WO !", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
        End If

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
#End Region

End Class
