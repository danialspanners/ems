Public Class SelectOGBContractToPrintForm
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShowTOC_Null_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SectionCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents installdateto As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Installdatefrom As DevExpress.XtraEditors.DateEdit
    Public WithEvents Advance_Panel As System.Windows.Forms.Panel
    Friend WithEvents LabelOnly_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Sortby_ComboBox As DevExpress.XtraEditors.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ContractNoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Sortby_ComboBox = New DevExpress.XtraEditors.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ShowTOC_Null_CheckBox = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.SectionCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Advance_Panel = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.installdateto = New DevExpress.XtraEditors.DateEdit
        Me.Installdatefrom = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ExportButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelOnly_CheckBox = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sortby_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Advance_Panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.installdateto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Installdatefrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContractNoCmb
        '
        Me.ContractNoCmb.Location = New System.Drawing.Point(103, 22)
        Me.ContractNoCmb.Name = "ContractNoCmb"
        Me.ContractNoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ContractNoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.ContractNoCmb.Properties.NullString = ""
        Me.ContractNoCmb.Properties.PopupWidth = 287
        Me.ContractNoCmb.Size = New System.Drawing.Size(269, 23)
        Me.ContractNoCmb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contract No :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sort by :"
        '
        'Sortby_ComboBox
        '
        Me.Sortby_ComboBox.Location = New System.Drawing.Point(103, 47)
        Me.Sortby_ComboBox.Name = "Sortby_ComboBox"
        Me.Sortby_ComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Sortby_ComboBox.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down))
        Me.Sortby_ComboBox.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ComboBoxItem("I/O No"))
        Me.Sortby_ComboBox.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ComboBoxItem("DWC Date"))
        Me.Sortby_ComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Sortby_ComboBox.Size = New System.Drawing.Size(270, 19)
        Me.Sortby_ComboBox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(135, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Print only if TOC Return Date is empty"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ShowTOC_Null_CheckBox
        '
        Me.ShowTOC_Null_CheckBox.AutoSize = True
        Me.ShowTOC_Null_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ShowTOC_Null_CheckBox.Location = New System.Drawing.Point(349, 40)
        Me.ShowTOC_Null_CheckBox.Name = "ShowTOC_Null_CheckBox"
        Me.ShowTOC_Null_CheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ShowTOC_Null_CheckBox.TabIndex = 16
        Me.ShowTOC_Null_CheckBox.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 35)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Enabled = False
        Me.PrintButton.Location = New System.Drawing.Point(266, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(78, 35)
        Me.PrintButton.TabIndex = 18
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Selected section only:"
        '
        'SectionCmb
        '
        Me.SectionCmb.Location = New System.Drawing.Point(127, 8)
        Me.SectionCmb.Name = "SectionCmb"
        Me.SectionCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SectionCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.SectionCmb.Properties.LookUpData.ListFields.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(23))
        Me.SectionCmb.Properties.NullString = ""
        Me.SectionCmb.Properties.PopupWidth = 287
        Me.SectionCmb.Size = New System.Drawing.Size(238, 23)
        Me.SectionCmb.TabIndex = 21
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(435, 217)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Advance_Panel)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.ContractNoCmb)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Sortby_ComboBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(427, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Advance_Panel
        '
        Me.Advance_Panel.Controls.Add(Me.Label7)
        Me.Advance_Panel.Controls.Add(Me.LabelOnly_CheckBox)
        Me.Advance_Panel.Controls.Add(Me.Button1)
        Me.Advance_Panel.Controls.Add(Me.Label3)
        Me.Advance_Panel.Controls.Add(Me.ShowTOC_Null_CheckBox)
        Me.Advance_Panel.Controls.Add(Me.SectionCmb)
        Me.Advance_Panel.Controls.Add(Me.Label4)
        Me.Advance_Panel.Location = New System.Drawing.Point(6, 72)
        Me.Advance_Panel.Name = "Advance_Panel"
        Me.Advance_Panel.Size = New System.Drawing.Size(379, 116)
        Me.Advance_Panel.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 22
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 1)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advance Options"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(214, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "To:"
        '
        'installdateto
        '
        Me.installdateto.DateTime = New Date(CType(0, Long))
        Me.installdateto.Location = New System.Drawing.Point(248, 37)
        Me.installdateto.Name = "installdateto"
        Me.installdateto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.installdateto.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.installdateto.Properties.MaskData.EditMask = "##/##/####"
        Me.installdateto.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.installdateto.Size = New System.Drawing.Size(112, 23)
        Me.installdateto.TabIndex = 35
        '
        'Installdatefrom
        '
        Me.Installdatefrom.DateTime = New Date(CType(0, Long))
        Me.Installdatefrom.Location = New System.Drawing.Point(96, 37)
        Me.Installdatefrom.Name = "Installdatefrom"
        Me.Installdatefrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Installdatefrom.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.Installdatefrom.Properties.MaskData.EditMask = "##/##/####"
        Me.Installdatefrom.Properties.MaskData.MaskType = DevExpress.XtraEditors.Controls.MaskType.Simple
        Me.Installdatefrom.Size = New System.Drawing.Size(112, 23)
        Me.Installdatefrom.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(25, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Install Date:"
        '
        'ExportButton
        '
        Me.ExportButton.Enabled = False
        Me.ExportButton.Location = New System.Drawing.Point(4, 5)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(73, 35)
        Me.ExportButton.TabIndex = 25
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ExportButton)
        Me.Panel1.Controls.Add(Me.PrintButton)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 44)
        Me.Panel1.TabIndex = 23
        '
        'LabelOnly_CheckBox
        '
        Me.LabelOnly_CheckBox.AutoSize = True
        Me.LabelOnly_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelOnly_CheckBox.Location = New System.Drawing.Point(349, 63)
        Me.LabelOnly_CheckBox.Name = "LabelOnly_CheckBox"
        Me.LabelOnly_CheckBox.Size = New System.Drawing.Size(15, 14)
        Me.LabelOnly_CheckBox.TabIndex = 23
        Me.LabelOnly_CheckBox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(135, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Label Only"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SelectOGBContractToPrintForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(438, 264)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectOGBContractToPrintForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Report"
        CType(Me.ContractNoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sortby_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Advance_Panel.ResumeLayout(False)
        Me.Advance_Panel.PerformLayout()
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

    Private Sub SelectOGBContractToPrintForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadContractCmb()
        LoadSectionCmb()

        Me.Sortby_ComboBox.SelectedIndex = 0
    End Sub

    Private Sub LoadContractCmb()
        Dim ds As DataSet
        With New BusinessRules.OGBBusRules.OGBContractBusLogic
            If .GetOGBContract(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    AddListFieldInfoToLookUp(ContractNoCmb, "OGB_Contract_No", 400, 0, "c")
                    ContractNoCmb.Properties.LookUpData.KeyField = "OGB_Contract_Id"
                    ContractNoCmb.Properties.LookUpData.DisplayField = "OGB_Contract_No"

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

        Filters = " 1=1 "
        If Installdatefrom.DateTime <> Nothing And installdateto.DateTime <> Nothing Then
            Filters = " (Installation_Date >= '" & Installdatefrom.DateTime.Day & "/" & Installdatefrom.DateTime.Month & "/" & Installdatefrom.DateTime.Year & "' and " & _
            "Installation_Date <= '" & installdateto.DateTime.Day & "/" & installdateto.DateTime.Month & "/" & installdateto.DateTime.Year & "')"
        End If

        If LabelOnly_CheckBox.Checked = True Then
            Filters = Filters & " and (a.Serial_no = '' or a.Serial_no is null ) "
        Else
            Filters = Filters & " and (a.serial_no Is NOT NULL  and  a.serial_no <>'') "
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub


    Private Sub Sortby_ComboBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sortby_ComboBox.Click
        If Sortby_ComboBox.IsPopupOpen() = False Then
            Sortby_ComboBox.DoPopup()
        Else
            Sortby_ComboBox.DoCloseUp()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Contract_Id = ContractNoCmb.Properties.LookUpData.KeyValue
        Section_Id = SectionCmb.Properties.LookUpData.KeyValue
        StatusTxt = "SendExcelMail"
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.Title = "Export to Excel"
        SaveFileDialog1.RestoreDirectory = True
        SaveFileDialog1.DefaultExt = "xls"
        SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        SaveFileDialog1.Filter = "Excel file (*.xls)|*.xls"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

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

    Private Sub ShowTOC_Null_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowTOC_Null_CheckBox.CheckedChanged

    End Sub
End Class
