Public Class SelectLVBTOCpendingform
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
    Friend WithEvents ContractNoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Sortby_ComboBox As DevExpress.XtraEditors.ComboBox
    Friend WithEvents ShowTOC_Null_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SectionCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents installdateto As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Installdatefrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CableLug_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Box_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BoxLabel_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SeparateByOfficers_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ContractNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Sortby_ComboBox = New DevExpress.XtraEditors.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ShowTOC_Null_CheckBox = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PrintButton = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.SectionCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.BoxLabel_RadioButton = New System.Windows.Forms.RadioButton
        Me.CableLug_RadioButton = New System.Windows.Forms.RadioButton
        Me.Label_RadioButton = New System.Windows.Forms.RadioButton
        Me.Box_RadioButton = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.installdateto = New DevExpress.XtraEditors.DateEdit
        Me.Installdatefrom = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.ExportButton = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SeparateByOfficers_CheckBox = New System.Windows.Forms.CheckBox
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sortby_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.installdateto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Installdatefrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContractNoCmb
        '
        Me.ContractNoCmb.Location = New System.Drawing.Point(99, 20)
        Me.ContractNoCmb.Name = "ContractNoCmb"
        Me.ContractNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNoCmb.Properties.NullString = ""
        Me.ContractNoCmb.Properties.PopupWidth = 271
        Me.ContractNoCmb.Size = New System.Drawing.Size(270, 19)
        Me.ContractNoCmb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contract No :"
        '
        'Sortby_ComboBox
        '
        Me.Sortby_ComboBox.Location = New System.Drawing.Point(99, 45)
        Me.Sortby_ComboBox.Name = "Sortby_ComboBox"
        Me.Sortby_ComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Sortby_ComboBox.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ComboBoxItem("I/O No"))
        Me.Sortby_ComboBox.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ComboBoxItem("DWC Date"))
        Me.Sortby_ComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Sortby_ComboBox.Size = New System.Drawing.Size(270, 19)
        Me.Sortby_ComboBox.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sort by :"
        '
        'ShowTOC_Null_CheckBox
        '
        Me.ShowTOC_Null_CheckBox.AutoSize = True
        Me.ShowTOC_Null_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ShowTOC_Null_CheckBox.Location = New System.Drawing.Point(354, 134)
        Me.ShowTOC_Null_CheckBox.Name = "ShowTOC_Null_CheckBox"
        Me.ShowTOC_Null_CheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ShowTOC_Null_CheckBox.TabIndex = 14
        Me.ShowTOC_Null_CheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(142, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Print only if TOC Return Date is empty"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PrintButton
        '
        Me.PrintButton.Enabled = False
        Me.PrintButton.Location = New System.Drawing.Point(265, 6)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(78, 35)
        Me.PrintButton.TabIndex = 16
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(349, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 35)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(21, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Selected section only:"
        '
        'SectionCmb
        '
        Me.SectionCmb.Location = New System.Drawing.Point(136, 76)
        Me.SectionCmb.Name = "SectionCmb"
        Me.SectionCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SectionCmb.Properties.NullString = ""
        Me.SectionCmb.Properties.PopupWidth = 271
        Me.SectionCmb.Size = New System.Drawing.Size(233, 19)
        Me.SectionCmb.TabIndex = 19
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(429, 211)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SeparateByOfficers_CheckBox)
        Me.TabPage2.Controls.Add(Me.BoxLabel_RadioButton)
        Me.TabPage2.Controls.Add(Me.CableLug_RadioButton)
        Me.TabPage2.Controls.Add(Me.Label_RadioButton)
        Me.TabPage2.Controls.Add(Me.Box_RadioButton)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.SectionCmb)
        Me.TabPage2.Controls.Add(Me.ContractNoCmb)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Sortby_ComboBox)
        Me.TabPage2.Controls.Add(Me.ShowTOC_Null_CheckBox)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(421, 185)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BoxLabel_RadioButton
        '
        Me.BoxLabel_RadioButton.AutoSize = True
        Me.BoxLabel_RadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BoxLabel_RadioButton.Checked = True
        Me.BoxLabel_RadioButton.Location = New System.Drawing.Point(94, 107)
        Me.BoxLabel_RadioButton.Name = "BoxLabel_RadioButton"
        Me.BoxLabel_RadioButton.Size = New System.Drawing.Size(81, 17)
        Me.BoxLabel_RadioButton.TabIndex = 25
        Me.BoxLabel_RadioButton.TabStop = True
        Me.BoxLabel_RadioButton.Text = "Box && Label"
        Me.BoxLabel_RadioButton.UseVisualStyleBackColor = True
        '
        'CableLug_RadioButton
        '
        Me.CableLug_RadioButton.AutoSize = True
        Me.CableLug_RadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CableLug_RadioButton.Location = New System.Drawing.Point(296, 107)
        Me.CableLug_RadioButton.Name = "CableLug_RadioButton"
        Me.CableLug_RadioButton.Size = New System.Drawing.Size(73, 17)
        Me.CableLug_RadioButton.TabIndex = 24
        Me.CableLug_RadioButton.Text = "Cable Lug"
        Me.CableLug_RadioButton.UseVisualStyleBackColor = True
        '
        'Label_RadioButton
        '
        Me.Label_RadioButton.AutoSize = True
        Me.Label_RadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label_RadioButton.Location = New System.Drawing.Point(233, 107)
        Me.Label_RadioButton.Name = "Label_RadioButton"
        Me.Label_RadioButton.Size = New System.Drawing.Size(51, 17)
        Me.Label_RadioButton.TabIndex = 23
        Me.Label_RadioButton.Text = "Label"
        Me.Label_RadioButton.UseVisualStyleBackColor = True
        '
        'Box_RadioButton
        '
        Me.Box_RadioButton.AutoSize = True
        Me.Box_RadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Box_RadioButton.Location = New System.Drawing.Point(181, 107)
        Me.Box_RadioButton.Name = "Box_RadioButton"
        Me.Box_RadioButton.Size = New System.Drawing.Size(43, 17)
        Me.Box_RadioButton.TabIndex = 22
        Me.Box_RadioButton.Text = "Box"
        Me.Box_RadioButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Advance Options"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.installdateto)
        Me.GroupBox1.Controls.Add(Me.Installdatefrom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 0)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advance Options"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(224, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "To:"
        '
        'installdateto
        '
        Me.installdateto.DateTime = New Date(CType(0, Long))
        Me.installdateto.Location = New System.Drawing.Point(258, 35)
        Me.installdateto.Name = "installdateto"
        Me.installdateto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.installdateto.Properties.MaskData.EditMask = "##/##/####"
        Me.installdateto.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.installdateto.Size = New System.Drawing.Size(112, 19)
        Me.installdateto.TabIndex = 39
        '
        'Installdatefrom
        '
        Me.Installdatefrom.DateTime = New Date(CType(0, Long))
        Me.Installdatefrom.Location = New System.Drawing.Point(106, 35)
        Me.Installdatefrom.Name = "Installdatefrom"
        Me.Installdatefrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Installdatefrom.Properties.MaskData.EditMask = "##/##/####"
        Me.Installdatefrom.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Installdatefrom.Size = New System.Drawing.Size(112, 19)
        Me.Installdatefrom.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(35, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Install Date:"
        '
        'ExportButton
        '
        Me.ExportButton.Enabled = False
        Me.ExportButton.Location = New System.Drawing.Point(4, 6)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(73, 35)
        Me.ExportButton.TabIndex = 24
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ExportButton)
        Me.Panel1.Controls.Add(Me.PrintButton)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 45)
        Me.Panel1.TabIndex = 24
        '
        'SeparateByOfficers_CheckBox
        '
        Me.SeparateByOfficers_CheckBox.AutoSize = True
        Me.SeparateByOfficers_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SeparateByOfficers_CheckBox.Checked = True
        Me.SeparateByOfficers_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SeparateByOfficers_CheckBox.Location = New System.Drawing.Point(94, 161)
        Me.SeparateByOfficers_CheckBox.Name = "SeparateByOfficers_CheckBox"
        Me.SeparateByOfficers_CheckBox.Size = New System.Drawing.Size(155, 17)
        Me.SeparateByOfficers_CheckBox.TabIndex = 26
        Me.SeparateByOfficers_CheckBox.Text = "Separate Pages by Officers"
        Me.SeparateByOfficers_CheckBox.UseVisualStyleBackColor = True
        '
        'SelectLVBTOCpendingform
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(433, 260)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectLVBTOCpendingform"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Report"
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sortby_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.installdateto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Installdatefrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Contract_Id As Integer
    Public Section_Id As Integer
    Public StatusTxt As String
    Public Filename As String
    Public Filters As String

    Private Sub SelectLVBTOCpendingform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadContractNoCmb()
        LoadSectionCmb()

        Me.Sortby_ComboBox.SelectedIndex = 0
    End Sub

    Private Sub LoadContractNoCmb()
        Dim ds As DataSet
        With New BusinessRules.LVBBusRules.LVBContractBusLogic
            If .GetLVBContract(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(ContractNoCmb, "Contract_No", 400, 0, "c")
                    ContractNoCmb.Properties.LookUpData.KeyField = "Contract_Id"
                    ContractNoCmb.Properties.LookUpData.DisplayField = "Contract_No"

                    ContractNoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    ContractNoCmb.EditValue = "0"
                End If
            End If
        End With


    End Sub

    Private Sub LoadSectionCmb()
        Dim ds As DataSet
        With New BusinessRules.SystemBusRules.SectionBusLogic
            If .GetSection(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(SectionCmb, "Section_Code", 400, 0, "c")
                    SectionCmb.Properties.LookUpData.KeyField = "Section_Id"
                    SectionCmb.Properties.LookUpData.DisplayField = "Section_Code"

                    Me.SectionCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                    SectionCmb.EditValue = "0"
                End If
            End If
        End With

    End Sub

    Private Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
        With New BusinessRules.CommonBusRules.CommonLogic
            .AddListFieldInfoToLookUp(le, field, width, alignment, format)
        End With
    End Sub

    Private Sub SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Contract_Id = ContractNoCmb.Properties.LookUpData.KeyValue
        Section_Id = SectionCmb.Properties.LookUpData.KeyValue
        StatusTxt = ""

        Filters = " 1=1 " 'Add this for additional filters to allow and "and" at the start of the statement

        If Installdatefrom.DateTime <> Nothing And installdateto.DateTime <> Nothing Then
            Filters = " Installation_Date >= '" & Installdatefrom.DateTime.Day & "/" & Installdatefrom.DateTime.Month & "/" & Installdatefrom.DateTime.Year & "' and " & _
            "Installation_Date <= '" & installdateto.DateTime.Day & "/" & installdateto.DateTime.Month & "/" & installdateto.DateTime.Year & "'"
        End If

        If BoxLabel_RadioButton.Checked = True Then
            Filters = Filters & " and (g.serial_no Is NOT NULL and g.serial_no <>'') "
            Filters = Filters & " or ((g.cableLug1hole = 0 and g.cableLug2hole = 0 ) and (g.LTB_label > 0 or g.strip_label > 0)) "
        ElseIf Box_RadioButton.Checked = True Then
            Filters = Filters & " and (g.serial_no Is NOT NULL and g.serial_no <>'') "
        ElseIf Label_RadioButton.Checked = True Then
            Filters = Filters & " and (g.Serial_no = '' or g.Serial_no is null ) "
            Filters = Filters & " and ((g.cableLug1hole = 0 and g.cableLug2hole = 0 ) and (g.LTB_label > 0 or g.strip_label > 0)) "
        ElseIf CableLug_RadioButton.Checked = True Then
            Filters = Filters & " and (g.Serial_no = '' or g.Serial_no is null ) "
            Filters = Filters & " and ((g.cableLug1hole >0 or g.cableLug2hole >0 ) and (g.LTB_label = 0 and g.strip_label = 0)) "
        End If

        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Contract_Id = 0
        Me.Close()
    End Sub

    Private Sub ContractNoCmb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContractNoCmb.KeyUp
        If e.KeyValue = 13 Then
            e.Handled = True
            SelectBtn_Click(sender, e)
        End If
    End Sub

    Private Sub Sortby_ComboBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sortby_ComboBox.Click
        If Sortby_ComboBox.IsPopupOpen() = False Then
            Sortby_ComboBox.DoPopup()
        Else
            Sortby_ComboBox.DoCloseUp()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click

        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.Title = "Export to Excel"
        SaveFileDialog1.RestoreDirectory = True
        SaveFileDialog1.DefaultExt = "xls"
        SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        SaveFileDialog1.Filter = "Excel file (*.xls)|*.xls"

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Filename = SaveFileDialog1.FileName

            Contract_Id = ContractNoCmb.Properties.LookUpData.KeyValue
            Section_Id = SectionCmb.Properties.LookUpData.KeyValue
            StatusTxt = "SendExcelMail"
            Me.Close()
        End If

    End Sub

    Private Sub ContractNoCmb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContractNoCmb.ValueChanged
        If ContractNoCmb.Properties.LookUpData.KeyValue <> Nothing Then
            ExportButton.Enabled = True
            PrintButton.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Button1.Text = "Advance Options" Then
            Me.Height = 383
        Else
            Me.Height = 288
        End If


        If Button1.Text = "Advance Options" Then
            Button1.Text = "Basic Options"
        Else
            Button1.Text = "Advance Options"
        End If

    End Sub
End Class
