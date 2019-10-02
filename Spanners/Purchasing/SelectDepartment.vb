Imports DevExpress.XtraEditors.Controls

Public Class SelectDepartmentForm
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
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DepartmentCmb As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DepartmentCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.DepartmentCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentCmb
        '
        Me.DepartmentCmb.Location = New System.Drawing.Point(96, 32)
        Me.DepartmentCmb.Name = "DepartmentCmb"
        Me.DepartmentCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.DepartmentCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.DepartmentCmb.Properties.NullString = ""
        Me.DepartmentCmb.Properties.PopupWidth = 200
        Me.DepartmentCmb.Size = New System.Drawing.Size(200, 19)
        Me.DepartmentCmb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Department :"
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(144, 88)
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
        Me.CancelBtn.Location = New System.Drawing.Point(224, 88)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 32)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "&Cancel"
        '
        'SelectDepartmentForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 173)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DepartmentCmb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectDepartmentForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        CType(Me.DepartmentCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Department_ID As Integer
    Public UserID As String = Common.CommonConn.Config.USERID

    Private Sub SelectDepartmentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsDepartment As DataSet
        With New BusinessRules.SystemBusRules.Department
            If .GetDepartment(dsDepartment) Then
                If dsDepartment.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(DepartmentCmb, "Name", 400, 0, "c")
                    DepartmentCmb.Properties.LookUpData.KeyField = "Department_ID"
                    DepartmentCmb.Properties.LookUpData.DisplayField = "Name"

                    DepartmentCmb.Properties.LookUpData.DataSource = dsDepartment.Tables(0)
                    DepartmentCmb.EditValue = "0"
                End If
            End If
        End With

        Dim ds As DataSet
        With New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
            If .GetUser(ds, UserID) Then
                If Not ds Is Nothing Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not ds Is Nothing Then
                        If Not row.IsNull("Department_ID") Then
                            DepartmentCmb.Properties.LookUpData.KeyValue = row("Department_ID")
                        Else
                            DepartmentCmb.Properties.LookUpData.KeyValue = 0
                        End If
                    End If
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
        Department_ID = DepartmentCmb.Properties.LookUpData.KeyValue
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Department_ID = 0
        Me.Close()
    End Sub
End Class
