Public Class PrintQuotationDialog
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
    Friend WithEvents PrintType_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rdbPrintWOBQ As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPrintWBQ As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents GST_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HideTotal_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Customlabel_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents rdbPrintCompDetails As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PrintType_GroupBox = New System.Windows.Forms.GroupBox
        Me.rdbPrintCompDetails = New System.Windows.Forms.RadioButton
        Me.rdbPrintWOBQ = New System.Windows.Forms.RadioButton
        Me.rdbPrintWBQ = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CancelButton = New System.Windows.Forms.Button
        Me.OKButton = New System.Windows.Forms.Button
        Me.GST_CheckBox = New System.Windows.Forms.CheckBox
        Me.HideTotal_CheckBox = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Customlabel_TextBox = New System.Windows.Forms.TextBox
        Me.PrintType_GroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintType_GroupBox
        '
        Me.PrintType_GroupBox.Controls.Add(Me.rdbPrintCompDetails)
        Me.PrintType_GroupBox.Controls.Add(Me.rdbPrintWOBQ)
        Me.PrintType_GroupBox.Controls.Add(Me.rdbPrintWBQ)
        Me.PrintType_GroupBox.Location = New System.Drawing.Point(185, 12)
        Me.PrintType_GroupBox.Name = "PrintType_GroupBox"
        Me.PrintType_GroupBox.Size = New System.Drawing.Size(254, 136)
        Me.PrintType_GroupBox.TabIndex = 2
        Me.PrintType_GroupBox.TabStop = False
        Me.PrintType_GroupBox.Text = "Select One :"
        Me.PrintType_GroupBox.Visible = False
        '
        'rdbPrintCompDetails
        '
        Me.rdbPrintCompDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrintCompDetails.Location = New System.Drawing.Point(24, 98)
        Me.rdbPrintCompDetails.Name = "rdbPrintCompDetails"
        Me.rdbPrintCompDetails.Size = New System.Drawing.Size(240, 24)
        Me.rdbPrintCompDetails.TabIndex = 5
        Me.rdbPrintCompDetails.Text = "Print Quotation Component Details"
        '
        'rdbPrintWOBQ
        '
        Me.rdbPrintWOBQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrintWOBQ.Location = New System.Drawing.Point(24, 58)
        Me.rdbPrintWOBQ.Name = "rdbPrintWOBQ"
        Me.rdbPrintWOBQ.Size = New System.Drawing.Size(228, 24)
        Me.rdbPrintWOBQ.TabIndex = 3
        Me.rdbPrintWOBQ.Text = "Print Without Bill of Quotation"
        '
        'rdbPrintWBQ
        '
        Me.rdbPrintWBQ.Checked = True
        Me.rdbPrintWBQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrintWBQ.Location = New System.Drawing.Point(24, 24)
        Me.rdbPrintWBQ.Name = "rdbPrintWBQ"
        Me.rdbPrintWBQ.Size = New System.Drawing.Size(240, 24)
        Me.rdbPrintWBQ.TabIndex = 2
        Me.rdbPrintWBQ.TabStop = True
        Me.rdbPrintWBQ.Text = "Print With Bill of Quotation"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 53)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Controls.Add(Me.OKButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(232, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 53)
        Me.Panel2.TabIndex = 0
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(117, 15)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(24, 15)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "Ok"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'GST_CheckBox
        '
        Me.GST_CheckBox.AutoSize = True
        Me.GST_CheckBox.Checked = True
        Me.GST_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GST_CheckBox.Location = New System.Drawing.Point(23, 23)
        Me.GST_CheckBox.Name = "GST_CheckBox"
        Me.GST_CheckBox.Size = New System.Drawing.Size(48, 17)
        Me.GST_CheckBox.TabIndex = 14
        Me.GST_CheckBox.Text = "GST"
        Me.GST_CheckBox.UseVisualStyleBackColor = True
        '
        'HideTotal_CheckBox
        '
        Me.HideTotal_CheckBox.AutoSize = True
        Me.HideTotal_CheckBox.Location = New System.Drawing.Point(23, 46)
        Me.HideTotal_CheckBox.Name = "HideTotal_CheckBox"
        Me.HideTotal_CheckBox.Size = New System.Drawing.Size(114, 17)
        Me.HideTotal_CheckBox.TabIndex = 15
        Me.HideTotal_CheckBox.Text = "Hide Total Amount"
        Me.HideTotal_CheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item Label"
        '
        'Customlabel_TextBox
        '
        Me.Customlabel_TextBox.Location = New System.Drawing.Point(82, 67)
        Me.Customlabel_TextBox.Name = "Customlabel_TextBox"
        Me.Customlabel_TextBox.Size = New System.Drawing.Size(88, 20)
        Me.Customlabel_TextBox.TabIndex = 17
        Me.Customlabel_TextBox.Text = "Item"
        '
        'PrintQuotationDialog
        '
        Me.ClientSize = New System.Drawing.Size(451, 213)
        Me.Controls.Add(Me.Customlabel_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HideTotal_CheckBox)
        Me.Controls.Add(Me.GST_CheckBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PrintType_GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintQuotationDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print ..."
        Me.PrintType_GroupBox.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public PrintQuotationSelection As Integer = 0
    Public PrintGST As Boolean = True
    Public HideTotal As Boolean = False
    Public CustomLabel As String = "Item"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If rdbPrintWBQ.Checked = True Then
            PrintQuotationSelection = 1
        ElseIf rdbPrintWOBQ.Checked = True Then
            PrintQuotationSelection = 2
        ElseIf rdbPrintCompDetails.Checked = True Then
            PrintQuotationSelection = 3
        End If

        PrintGST = GST_CheckBox.Checked
        HideTotal = HideTotal_CheckBox.Checked
        CustomLabel = Customlabel_TextBox.Text

        Me.Close()
    End Sub
End Class
