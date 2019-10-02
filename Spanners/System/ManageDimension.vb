Public Class ManageDimension
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
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MatlListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddDimensionTxt As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.AddDimensionTxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.MatlListBox = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddDimensionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.AddDimensionTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MatlListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 346)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimension"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(128, 312)
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
        Me.CancelBtn.Location = New System.Drawing.Point(200, 312)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 116
        Me.CancelBtn.Text = "&Cancel"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(56, 312)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 115
        Me.SaveBtn.Text = "&Save"
        '
        'AddDimensionTxt
        '
        Me.AddDimensionTxt.Location = New System.Drawing.Point(104, 272)
        Me.AddDimensionTxt.Name = "AddDimensionTxt"
        Me.AddDimensionTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.AddDimensionTxt.Size = New System.Drawing.Size(160, 21)
        Me.AddDimensionTxt.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Add New Dimension :"
        '
        'MatlListBox
        '
        Me.MatlListBox.Items.AddRange(New Object() {"aaa"})
        Me.MatlListBox.Location = New System.Drawing.Point(8, 24)
        Me.MatlListBox.Name = "MatlListBox"
        Me.MatlListBox.Size = New System.Drawing.Size(256, 238)
        Me.MatlListBox.TabIndex = 112
        '
        'ManageDimension
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageDimension"
        Me.Text = "ManageDimension"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AddDimensionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class
