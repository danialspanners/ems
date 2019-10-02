Public Class PrintOrderConfirmationDialog
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
    Friend WithEvents btnOk As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents rdbPrintWOBQ As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPrintWBQ As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbPrintWOBQ = New System.Windows.Forms.RadioButton
        Me.rdbPrintWBQ = New System.Windows.Forms.RadioButton
        Me.btnOk = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnCancel = New DevExpress.XtraEditors.Controls.XtraButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbPrintWOBQ)
        Me.GroupBox1.Controls.Add(Me.rdbPrintWBQ)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 88)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select One :"
        '
        'rdbPrintWOBQ
        '
        Me.rdbPrintWOBQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrintWOBQ.Location = New System.Drawing.Point(32, 56)
        Me.rdbPrintWOBQ.Name = "rdbPrintWOBQ"
        Me.rdbPrintWOBQ.Size = New System.Drawing.Size(228, 24)
        Me.rdbPrintWOBQ.TabIndex = 3
        Me.rdbPrintWOBQ.Text = "Print Without Bill of Quotation"
        '
        'rdbPrintWBQ
        '
        Me.rdbPrintWBQ.Checked = True
        Me.rdbPrintWBQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrintWBQ.Location = New System.Drawing.Point(32, 24)
        Me.rdbPrintWBQ.Name = "rdbPrintWBQ"
        Me.rdbPrintWBQ.Size = New System.Drawing.Size(200, 24)
        Me.rdbPrintWBQ.TabIndex = 2
        Me.rdbPrintWBQ.TabStop = True
        Me.rdbPrintWBQ.Text = "Print With Bill of Quotation"
        '
        'btnOk
        '
        Me.btnOk.AutoSize = False
        Me.btnOk.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Image = Nothing
        Me.btnOk.Location = New System.Drawing.Point(56, 104)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 32)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "Ok"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = False
        Me.btnCancel.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(160, 104)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'PrintOrderConfirmationDialog
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(306, 143)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintOrderConfirmationDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print ..."
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public PrintOrderConfirmationSelection As Integer = 0

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If rdbPrintWBQ.Checked = True Then
            PrintOrderConfirmationSelection = 1
        ElseIf rdbPrintWOBQ.Checked = True Then
            PrintOrderConfirmationSelection = 2
        End If
        Me.Close()
    End Sub
End Class
