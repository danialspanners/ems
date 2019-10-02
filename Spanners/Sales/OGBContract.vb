Public Class OGBContractForm
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
    Friend WithEvents ContractNoTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents OGBBoxQtyTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents StripLabeltxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BOXLabelTxt As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.ContractNoTxt = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.StripLabeltxt = New DevExpress.XtraEditors.SpinEdit
        Me.BOXLabelTxt = New DevExpress.XtraEditors.SpinEdit
        Me.OGBBoxQtyTxt = New DevExpress.XtraEditors.SpinEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.ContractNoTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StripLabeltxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOXLabelTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OGBBoxQtyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* Contract No :"
        '
        'ContractNoTxt
        '
        Me.ContractNoTxt.Location = New System.Drawing.Point(92, 14)
        Me.ContractNoTxt.Name = "ContractNoTxt"
        Me.ContractNoTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNoTxt.Size = New System.Drawing.Size(140, 19)
        Me.ContractNoTxt.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StripLabeltxt)
        Me.GroupBox1.Controls.Add(Me.BOXLabelTxt)
        Me.GroupBox1.Controls.Add(Me.OGBBoxQtyTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 96)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'StripLabeltxt
        '
        Me.StripLabeltxt.Location = New System.Drawing.Point(120, 64)
        Me.StripLabeltxt.Name = "StripLabeltxt"
        Me.StripLabeltxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.StripLabeltxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StripLabeltxt.Size = New System.Drawing.Size(75, 19)
        Me.StripLabeltxt.TabIndex = 17
        Me.StripLabeltxt.Text = "0"
        '
        'BOXLabelTxt
        '
        Me.BOXLabelTxt.Location = New System.Drawing.Point(120, 40)
        Me.BOXLabelTxt.Name = "BOXLabelTxt"
        Me.BOXLabelTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BOXLabelTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BOXLabelTxt.Size = New System.Drawing.Size(75, 19)
        Me.BOXLabelTxt.TabIndex = 16
        Me.BOXLabelTxt.Text = "0"
        '
        'OGBBoxQtyTxt
        '
        Me.OGBBoxQtyTxt.Location = New System.Drawing.Point(120, 16)
        Me.OGBBoxQtyTxt.Name = "OGBBoxQtyTxt"
        Me.OGBBoxQtyTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.OGBBoxQtyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OGBBoxQtyTxt.Size = New System.Drawing.Size(75, 19)
        Me.OGBBoxQtyTxt.TabIndex = 15
        Me.OGBBoxQtyTxt.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Strip Label :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Box Label :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OGB Box"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(112, 152)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 32)
        Me.SaveBtn.TabIndex = 5
        Me.SaveBtn.Text = "Save"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(184, 152)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "Close"
        '
        'OGBContractForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 189)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ContractNoTxt)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "OGBContractForm"
        Me.Text = "New OGB Contract"
        CType(Me.ContractNoTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.StripLabeltxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOXLabelTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OGBBoxQtyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " variable "
    Public OGB_Contract_Id As Integer
    Public OGB_Contract_No As String
    Public OGB_Box_Qty As Integer
    Public Box_Label As Integer
    Public Strip_Label As Integer
    Public Create_Date As String
    Public Transact_Date As String
    Public UserID As String = Common.CommonConn.Config.USERID
#End Region

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        RetrieveFromForm()
        If ValidData() Then
            With New BusinessRules.OGBBusRules.OGBContractBusLogic
                '.OGB_Contract_Id = OGB_Contract_Id
                .OGB_Contract_No = OGB_Contract_No
                If .CheckDuplicateContract() = True Then
                .OGB_Box_Qty = OGB_Box_Qty
                .Box_Label = Box_Label
                .Strip_Label = Strip_Label
                .UserID = UserID
                If .SaveOGBContract() Then
                    MessageBox.Show("Contract saved. ", "OGB Contract", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Duplicated Contract Number! Please re-enter Contract No.", "LVB Contract", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        End If
    End Sub

    Private Sub RetrieveFromForm()
        OGB_Contract_No = Me.ContractNoTxt.Text
        OGB_Box_Qty = Me.OGBBoxQtyTxt.Text
        Box_Label = Me.BOXLabelTxt.Text
        Strip_Label = Me.StripLabeltxt.Text
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim FieldName As String

        If Not Len(OGB_Contract_No) > 0 Then
            DataOK_Flag = False
            FieldName = "Contract No" & Chr(13)
        End If

        If Not DataOK_Flag Then
            With New Common.CommonError.ErrorMsg
                MessageBox.Show(.EMPTY_FIELD_MSG & Chr(13) & FieldName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End With
        End If
        ValidData = DataOK_Flag
    End Function

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub OGBContractForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this Contract?", "LVB Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
