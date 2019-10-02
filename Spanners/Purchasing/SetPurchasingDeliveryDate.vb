Public Class SetPurchasingDeliveryDate
    Inherits System.Windows.Forms.Form

    Public DeliveryDate As Date

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
    Friend WithEvents DeliveryDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DeliveryDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeliveryDateEdit
        '
        Me.DeliveryDateEdit.DateTime = New Date(CType(0, Long))
        Me.DeliveryDateEdit.Location = New System.Drawing.Point(30, 24)
        Me.DeliveryDateEdit.Name = "DeliveryDateEdit"
        Me.DeliveryDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DeliveryDateEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DeliveryDateEdit.Properties.MaskData.EditMask = "##/##/####"
        Me.DeliveryDateEdit.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.DeliveryDateEdit.Size = New System.Drawing.Size(168, 21)
        Me.DeliveryDateEdit.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Ok"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(118, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Cancel"
        '
        'SetPurchasingDeliveryDate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(226, 113)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DeliveryDateEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "SetPurchasingDeliveryDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Delivery Date"
        CType(Me.DeliveryDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DeliveryDate = Me.DeliveryDateEdit.DateTime
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DeliveryDate = Nothing
        Me.Close()
    End Sub
End Class
