Public Class SelectSpecialForm
    Inherits System.Windows.Forms.Form

    Public FromForm As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pFromForm As String)
        MyBase.New()
        FromForm = pFromForm

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
    Friend WithEvents SpecialCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TabControl1 As Crownwood.Magic.Controls.TabControl
    Friend WithEvents TabPage1 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage2 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage3 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage4 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage5 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents TabPage6 As Crownwood.Magic.Controls.TabPage
    Friend WithEvents Section1Txt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Section2txt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Section3txt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Section5Txt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Section6Txt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Section4Txt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SelectBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CancelBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SpecialCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New Crownwood.Magic.Controls.TabControl
        Me.TabPage1 = New Crownwood.Magic.Controls.TabPage
        Me.Section1Txt = New DevExpress.XtraEditors.MemoEdit
        Me.TabPage2 = New Crownwood.Magic.Controls.TabPage
        Me.Section2txt = New DevExpress.XtraEditors.MemoEdit
        Me.TabPage3 = New Crownwood.Magic.Controls.TabPage
        Me.Section3txt = New DevExpress.XtraEditors.MemoEdit
        Me.TabPage4 = New Crownwood.Magic.Controls.TabPage
        Me.Section4Txt = New DevExpress.XtraEditors.MemoEdit
        Me.TabPage5 = New Crownwood.Magic.Controls.TabPage
        Me.Section5Txt = New DevExpress.XtraEditors.MemoEdit
        Me.TabPage6 = New Crownwood.Magic.Controls.TabPage
        Me.Section6Txt = New DevExpress.XtraEditors.MemoEdit
        Me.SelectBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CancelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.SpecialCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Section1Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Section2txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Section3txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Section4Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Section5Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.Section6Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpecialCmb
        '
        Me.SpecialCmb.Location = New System.Drawing.Point(64, 16)
        Me.SpecialCmb.Name = "SpecialCmb"
        Me.SpecialCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SpecialCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SpecialCmb.Properties.NullString = ""
        Me.SpecialCmb.Properties.PopupWidth = 184
        Me.SpecialCmb.Size = New System.Drawing.Size(184, 19)
        Me.SpecialCmb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Format :"
        '
        'TabControl1
        '
        Me.TabControl1.BoldSelectedPage = True
        Me.TabControl1.IDEPixelArea = True
        Me.TabControl1.IDEPixelBorder = True
        Me.TabControl1.Location = New System.Drawing.Point(8, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SelectedTab = Me.TabPage1
        Me.TabControl1.Size = New System.Drawing.Size(560, 152)
        Me.TabControl1.TabIndex = 7
        Me.TabControl1.TabPages.AddRange(New Crownwood.Magic.Controls.TabPage() {Me.TabPage1, Me.TabPage2, Me.TabPage3, Me.TabPage4, Me.TabPage5, Me.TabPage6})
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Section1Txt)
        Me.TabPage1.Location = New System.Drawing.Point(2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(556, 125)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Title = "Section 1"
        '
        'Section1Txt
        '
        Me.Section1Txt.Location = New System.Drawing.Point(8, 8)
        Me.Section1Txt.Name = "Section1Txt"
        Me.Section1Txt.Size = New System.Drawing.Size(544, 112)
        Me.Section1Txt.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Section2txt)
        Me.TabPage2.Location = New System.Drawing.Point(2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Selected = False
        Me.TabPage2.Size = New System.Drawing.Size(556, 125)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Title = "Section 2"
        '
        'Section2txt
        '
        Me.Section2txt.Location = New System.Drawing.Point(8, 8)
        Me.Section2txt.Name = "Section2txt"
        Me.Section2txt.Size = New System.Drawing.Size(544, 112)
        Me.Section2txt.TabIndex = 8
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Section3txt)
        Me.TabPage3.Location = New System.Drawing.Point(2, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Selected = False
        Me.TabPage3.Size = New System.Drawing.Size(556, 125)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Title = "Section 3"
        '
        'Section3txt
        '
        Me.Section3txt.Location = New System.Drawing.Point(8, 8)
        Me.Section3txt.Name = "Section3txt"
        Me.Section3txt.Size = New System.Drawing.Size(544, 112)
        Me.Section3txt.TabIndex = 10
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Section4Txt)
        Me.TabPage4.Location = New System.Drawing.Point(2, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Selected = False
        Me.TabPage4.Size = New System.Drawing.Size(556, 125)
        Me.TabPage4.TabIndex = 6
        Me.TabPage4.Title = "Section 4"
        '
        'Section4Txt
        '
        Me.Section4Txt.Location = New System.Drawing.Point(8, 8)
        Me.Section4Txt.Name = "Section4Txt"
        Me.Section4Txt.Size = New System.Drawing.Size(544, 112)
        Me.Section4Txt.TabIndex = 15
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Section5Txt)
        Me.TabPage5.Location = New System.Drawing.Point(2, 2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Selected = False
        Me.TabPage5.Size = New System.Drawing.Size(556, 125)
        Me.TabPage5.TabIndex = 7
        Me.TabPage5.Title = "Section 5"
        '
        'Section5Txt
        '
        Me.Section5Txt.Location = New System.Drawing.Point(8, 8)
        Me.Section5Txt.Name = "Section5Txt"
        Me.Section5Txt.Size = New System.Drawing.Size(544, 112)
        Me.Section5Txt.TabIndex = 16
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Section6Txt)
        Me.TabPage6.Location = New System.Drawing.Point(2, 2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Selected = False
        Me.TabPage6.Size = New System.Drawing.Size(556, 125)
        Me.TabPage6.TabIndex = 8
        Me.TabPage6.Title = "Section 6"
        '
        'Section6Txt
        '
        Me.Section6Txt.Location = New System.Drawing.Point(8, 8)
        Me.Section6Txt.Name = "Section6Txt"
        Me.Section6Txt.Size = New System.Drawing.Size(544, 112)
        Me.Section6Txt.TabIndex = 16
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSize = False
        Me.SelectBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Image = Nothing
        Me.SelectBtn.Location = New System.Drawing.Point(416, 208)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(72, 32)
        Me.SelectBtn.TabIndex = 8
        Me.SelectBtn.Text = "Select"
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = False
        Me.CancelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Image = Nothing
        Me.CancelBtn.Location = New System.Drawing.Point(496, 208)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(72, 32)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "Cancel"
        '
        'SelectSpecialForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 253)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SpecialCmb)
        Me.Name = "SelectSpecialForm"
        Me.ShowInTaskbar = False
        Me.Text = "Special Format"
        CType(Me.SpecialCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Section1Txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Section2txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Section3txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Section4Txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.Section5Txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.Section6Txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Quotation_ID As Integer
    Public Special_ID As Integer
    Public Section1 As String
    Public Section2 As String
    Public Section3 As String
    Public Section4 As String
    Public Section5 As String
    Public Section6 As String
    Public SavedID As Integer

    Private Sub SelectSpecialForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSpecialFormat()
        TabControl1.IDEPixelBorder = True
        GetSavedFormat()
    End Sub

    Private Sub GetSavedFormat()
        'Dim Section1Sav, Section2Sav, Section3Sav, Section4Sav, Section5Sav, Section6Sav As String
        If UCase(FromForm) = "QUO" Then
            GetQuotation()
        Else
            GetOrderConfirmation()
        End If
       
    End Sub

    Private Sub GetQuotation()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            Dim ds1 As DataSet
            If .GetQuotationHeader(ds1, Quotation_ID) Then
                SpecialCmb.Properties.LookUpData.KeyValue = ds1.Tables(0).Rows(0)("Special_ID")
                SavedID = ds1.Tables(0).Rows(0)("Special_ID")
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section1")) Then
                    Section1Txt.Text = ds1.Tables(0).Rows(0)("Section1")
                Else
                    Section1Txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section2")) Then
                    Section2txt.Text = ds1.Tables(0).Rows(0)("Section2")
                Else
                    Section2txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section3")) Then
                    Section3txt.Text = ds1.Tables(0).Rows(0)("Section3")
                Else
                    Section3txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section4")) Then
                    Section4Txt.Text = ds1.Tables(0).Rows(0)("Section4")
                Else
                    Section4Txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section5")) Then
                    Section5Txt.Text = ds1.Tables(0).Rows(0)("Section5")
                Else
                    Section5Txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section6")) Then
                    Section6Txt.Text = ds1.Tables(0).Rows(0)("Section6")
                Else
                    Section6Txt.Text = ""
                End If
            End If
        End With
    End Sub

    Private Sub GetOrderConfirmation()
        With New BusinessRules.SaleBusRules.SaleBusLogic
            Dim ds1 As DataSet
            If .GetOrderConfirmHeader(ds1, Quotation_ID) Then
                SpecialCmb.Properties.LookUpData.KeyValue = ds1.Tables(0).Rows(0)("Special_ID")
                SavedID = ds1.Tables(0).Rows(0)("Special_ID")
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section1")) Then
                    Section1Txt.Text = ds1.Tables(0).Rows(0)("Section1")
                Else
                    Section1Txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section2")) Then
                    Section2txt.Text = ds1.Tables(0).Rows(0)("Section2")
                Else
                    Section2txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section3")) Then
                    Section3txt.Text = ds1.Tables(0).Rows(0)("Section3")
                Else
                    Section3txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section4")) Then
                    Section4Txt.Text = ds1.Tables(0).Rows(0)("Section4")
                Else
                    Section4Txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section5")) Then
                    Section5Txt.Text = ds1.Tables(0).Rows(0)("Section5")
                Else
                    Section5Txt.Text = ""
                End If
                If Not IsDBNull(ds1.Tables(0).Rows(0)("Section6")) Then
                    Section6Txt.Text = ds1.Tables(0).Rows(0)("Section6")
                Else
                    Section6Txt.Text = ""
                End If
            End If
        End With
    End Sub

    Private Sub LoadSpecialFormat()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.SpecialBusLogic
            If .GetSpecialFormat(ds) Then
                If Not ds Is Nothing Then
                    Try
                        'SimpleBinding LookUp adjustment start
                        AddListFieldInfoToLookUp(SpecialCmb, "Special_Name", 400, 0, "c")
                        SpecialCmb.Properties.LookUpData.KeyField = "Special_ID"
                        SpecialCmb.Properties.LookUpData.DisplayField = "Special_Name"

                        SpecialCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        SpecialCmb.EditValue = "0"
                        'SimpleBinding LookUp adjustment end
                    Catch exLoad As System.Exception
                        System.Windows.Forms.MessageBox.Show(exLoad.Message)
                    End Try
                End If
            End If
        End With
    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub SpecialCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles SpecialCmb.CloseUp
        Dim ds As DataSet

        Special_ID = e.Value
        If SavedID = Special_ID Then
            GetSavedFormat()
        Else
            With New BusinessRules.SystemBusRules.SpecialBusLogic
                If .GetSpecialFormat(ds, Special_ID) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section1")) Then
                            Section1Txt.Text = ds.Tables(0).Rows(0)("Section1")
                        Else
                            Section1Txt.Text = ""
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section2")) Then
                            Section2txt.Text = ds.Tables(0).Rows(0)("Section2")
                        Else
                            Section2txt.Text = ""
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section3")) Then
                            Section3txt.Text = ds.Tables(0).Rows(0)("Section3")
                        Else
                            Section3txt.Text = ""
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section4")) Then
                            Section4Txt.Text = ds.Tables(0).Rows(0)("Section4")
                        Else
                            Section4Txt.Text = ""
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section5")) Then
                            Section5Txt.Text = ds.Tables(0).Rows(0)("Section5")
                        Else
                            Section5Txt.Text = ""
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Section6")) Then
                            Section6Txt.Text = ds.Tables(0).Rows(0)("Section6")
                        Else
                            Section6Txt.Text = ""
                        End If
                    End If
                End If
            End With
        End If

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        With New BusinessRules.SaleBusRules.SaleBusLogic
            .Quotation_ID = Quotation_ID
            .Special_ID = SpecialCmb.Properties.LookUpData.KeyValue
            .Section1 = Section1Txt.Text
            .Section2 = Section2txt.Text
            'MessageBox.Show(Section2txt.Text)
            .Section3 = Section3txt.Text
            .Section4 = Section4Txt.Text
            .Section5 = Section5Txt.Text
            .Section6 = Section6Txt.Text
            If .UpdateSpecialSection() Then
                Me.Close()
            End If
        End With
    End Sub
End Class
