Public Class ManageColorForm
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
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents NewBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents DeleteBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorList As System.Windows.Forms.ListBox
    Friend WithEvents Colortxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PriceRate_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SpecialPriceRate_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SpecialPriceRate_TextEdit = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.PriceRate_TextEdit = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.NewBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.DeleteBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.SaveBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Colortxt = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ColorList = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.SpecialPriceRate_TextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceRate_TextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colortxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SpecialPriceRate_TextEdit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PriceRate_TextEdit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.NewBtn)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.Colortxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ColorList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 434)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color"
        '
        'SpecialPriceRate_TextEdit
        '
        Me.SpecialPriceRate_TextEdit.Location = New System.Drawing.Point(112, 344)
        Me.SpecialPriceRate_TextEdit.Name = "SpecialPriceRate_TextEdit"
        Me.SpecialPriceRate_TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SpecialPriceRate_TextEdit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.SpecialPriceRate_TextEdit.Size = New System.Drawing.Size(88, 19)
        Me.SpecialPriceRate_TextEdit.TabIndex = 126
        Me.SpecialPriceRate_TextEdit.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Special Price Rate :"
        '
        'PriceRate_TextEdit
        '
        Me.PriceRate_TextEdit.Location = New System.Drawing.Point(112, 312)
        Me.PriceRate_TextEdit.Name = "PriceRate_TextEdit"
        Me.PriceRate_TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PriceRate_TextEdit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.PriceRate_TextEdit.Size = New System.Drawing.Size(88, 19)
        Me.PriceRate_TextEdit.TabIndex = 124
        Me.PriceRate_TextEdit.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Price Rate :"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(224, 392)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(64, 24)
        Me.CancelBtn.TabIndex = 122
        Me.CancelBtn.Text = "&Close"
        '
        'NewBtn
        '
        Me.NewBtn.AutoSize = False
        Me.NewBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.NewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBtn.Image = Nothing
        Me.NewBtn.Location = New System.Drawing.Point(184, 248)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(104, 24)
        Me.NewBtn.TabIndex = 121
        Me.NewBtn.Text = "New Color"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = False
        Me.DeleteBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Image = Nothing
        Me.DeleteBtn.Location = New System.Drawing.Point(152, 392)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(64, 24)
        Me.DeleteBtn.TabIndex = 117
        Me.DeleteBtn.Text = "&Delete"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = False
        Me.SaveBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Image = Nothing
        Me.SaveBtn.Location = New System.Drawing.Point(80, 392)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(64, 24)
        Me.SaveBtn.TabIndex = 115
        Me.SaveBtn.Text = "&Save"
        '
        'Colortxt
        '
        Me.Colortxt.Location = New System.Drawing.Point(112, 280)
        Me.Colortxt.Name = "Colortxt"
        Me.Colortxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Colortxt.Size = New System.Drawing.Size(176, 19)
        Me.Colortxt.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Color :"
        '
        'ColorList
        '
        Me.ColorList.Location = New System.Drawing.Point(8, 24)
        Me.ColorList.Name = "ColorList"
        Me.ColorList.Size = New System.Drawing.Size(280, 212)
        Me.ColorList.TabIndex = 112
        '
        'ManageColorForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 453)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageColorForm"
        Me.Text = "Color"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SpecialPriceRate_TextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceRate_TextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colortxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Color_ID As Integer
    Public Color_Name As String
    Public OldColor As String
    Public UserID As String = Common.CommonConn.Config.USERID
    ' 06.01.2004 YG Start
    Dim FunctionName As String = "MyColor"
    ' 06.01.2004 YG End

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ManageColorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileInsert(a.com, FunctionName) Then
            NewBtn.Enabled = True
        Else
            NewBtn.Enabled = False
        End If

        If a.com.CheckUserProfileUpdate(a.com, FunctionName) Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If
        ' 06.01.2004 YG End

        LoadColor()
        DeleteBtn.Enabled = False
    End Sub

    Private Sub ResetForm()
        Colortxt.Text = ""
        Me.PriceRate_TextEdit.Text = "0.00"
        Me.SpecialPriceRate_TextEdit.Text = "0.00"
    End Sub

    Private Sub LoadColor()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(ds) Then
                If Not ds Is Nothing Then
                    Try
                        ColorList.DisplayMember = "Color_Name"
                        ColorList.ValueMember = "Color_ID"

                        ColorList.DataSource = ds.Tables(0)
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If ValidData() Then

            With New BusinessRules.SystemBusRules.ColorBusLogic
                .Color_Name = Color_Name
                .UserID = UserID
                .PriceRate = FormatNumber(Me.PriceRate_TextEdit.Text, 2)
                .SpecialPriceRate = FormatNumber(Me.SpecialPriceRate_TextEdit.Text, 2)
                If Color_ID = 0 Or Color_ID = Nothing Then
                    If Not ColorNameExist() Then
                        If .SaveColor() Then
                            MessageBox.Show("Color saved. ", "Color", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Color already exist !", "Manage Color", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    If (ColorNameExist() And OldColor = Colortxt.Text) Or Not ColorNameExist() Then

                        .UpdateColor(Color_ID)
                        MessageBox.Show("Color updated. ", "Color", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Color already exist !", "Manage Color", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                Me.LoadColor()
                'ResetForm()
                'NewBtn_Click(Me, Nothing)
            End With


        End If
    End Sub

    Private Function ValidData() As Boolean
        Dim DataOK_Flag As Boolean = True
        Dim Errmsg As String

        Color_Name = Colortxt.Text

        If Not Len(Color_Name) > 0 Then
            DataOK_Flag = False
            With New Common.CommonError.ErrorMsg
                Errmsg = .EMPTY_FIELD_MSG & "Color" & Chr(13)
            End With
        End If

        If Not Len(Me.PriceRate_TextEdit.Text) > 0 Then
            Me.PriceRate_TextEdit.Text = 0
        End If

        If Not Len(Me.SpecialPriceRate_TextEdit.Text) > 0 Then
            Me.SpecialPriceRate_TextEdit.Text = 0
        End If

        If Not IsNumeric(Me.PriceRate_TextEdit.Text) Then
            DataOK_Flag = False
            With New Common.CommonError.ErrorMsg
                Errmsg = Errmsg & .NON_NUMERIC_ERROR & "Price Rate" & Chr(13)
            End With
        End If

        If Not IsNumeric(Me.SpecialPriceRate_TextEdit.Text) Then
            With New Common.CommonError.ErrorMsg
                Errmsg = Errmsg & .NON_NUMERIC_ERROR & "Special Price Rate" & Chr(13)
            End With
            DataOK_Flag = False
        End If

        If Not DataOK_Flag Then

            MessageBox.Show(Errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        ValidData = DataOK_Flag
    End Function
    '## Added by Alan
    Private Function ColorNameExist() As Boolean
        Dim NameExist_Flag As Boolean = False
        Dim dsColor As DataSet
        Dim rowCount As Integer
        Dim i As Integer

        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(dsColor) Then
                rowCount = dsColor.Tables(0).Rows.Count()
                For i = 0 To (rowCount - 1)
                    If UCase(Color_Name) = UCase(dsColor.Tables(0).Rows(i).Item("Color_Name")) Then
                        NameExist_Flag = True
                        Exit For
                    Else
                        NameExist_Flag = False
                    End If
                Next i
            End If
        End With
        ColorNameExist = NameExist_Flag
    End Function
    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim Result As DialogResult = MessageBox.Show("Confirm delete? ", "Delete Color", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Color_ID = ColorList.SelectedValue.ToString
            With New BusinessRules.SystemBusRules.ColorBusLogic
                .Color_ID = Color_ID
                If .DeleteColor() Then
                    MessageBox.Show("Color deleted. ", "Color", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadColor()
                End If
            End With
        End If
    End Sub

    Private Sub NewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click
        SaveBtn.Text = "Save"

        Colortxt.Text = ""
        Me.PriceRate_TextEdit.Text = "0.00"
        Me.SpecialPriceRate_TextEdit.Text = "0.00"
        Colortxt.Focus()
        Color_ID = Nothing

    End Sub

    Private Sub ColorList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorList.SelectedIndexChanged
        ' 06.01.2004 YG Start
        Dim a As MainForm = Me.ParentForm

        If a.com.CheckUserProfileDelete(a.com, FunctionName) Then
            DeleteBtn.Enabled = True
        Else
            DeleteBtn.Enabled = False
        End If

        '        DeleteBtn.Enabled = True
        ' 06.01.2004 YG End

        Color_ID = ColorList.SelectedValue.ToString
        Dim ds As DataSet

        With New BusinessRules.SystemBusRules.ColorBusLogic
            If .GetColor(ds, Color_ID) Then
                Colortxt.Text = ds.Tables(0).Rows(0)("Color_Name")
                OldColor = Colortxt.Text
                Me.PriceRate_TextEdit.Text = FormatNumber(ds.Tables(0).Rows(0)("PriceRate"), 2)
                Me.SpecialPriceRate_TextEdit.Text = FormatNumber(ds.Tables(0).Rows(0)("SpecialPriceRate"), 2)
            End If
        End With
        SaveBtn.Text = "Update"
    End Sub

    Private Sub ColorList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorList.Click

    End Sub

    Private Sub ManageColorForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class

