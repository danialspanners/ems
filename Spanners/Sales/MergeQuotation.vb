Public Class MergeQuotationForm
    Inherits System.Windows.Forms.Form

    Public MasterQuotation_ID As Integer
    Public Quotation_ID As Integer
    Public SubQuotation_Line_ID As Integer
    Public Quotation_Line_ID As Integer
    Public ItemNo As Integer
    Public UserID As String = Common.CommonConn.Config.USERID
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MastQuoCmb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SubQuoList As System.Windows.Forms.ListBox
    Friend WithEvents MergeBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MastQuoCmb = New DevExpress.XtraEditors.LookUpEdit
        Me.SubQuoList = New System.Windows.Forms.ListBox
        Me.MergeBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.MastQuoCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Quotation :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sub Quotation :"
        '
        'MastQuoCmb
        '
        Me.MastQuoCmb.Location = New System.Drawing.Point(104, 32)
        Me.MastQuoCmb.Name = "MastQuoCmb"
        Me.MastQuoCmb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.MastQuoCmb.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo))
        Me.MastQuoCmb.Properties.NullString = ""
        Me.MastQuoCmb.Properties.PopupWidth = 208
        Me.MastQuoCmb.Size = New System.Drawing.Size(208, 19)
        Me.MastQuoCmb.TabIndex = 2
        '
        'SubQuoList
        '
        Me.SubQuoList.Location = New System.Drawing.Point(16, 88)
        Me.SubQuoList.Name = "SubQuoList"
        Me.SubQuoList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.SubQuoList.Size = New System.Drawing.Size(296, 212)
        Me.SubQuoList.TabIndex = 3
        '
        'MergeBtn
        '
        Me.MergeBtn.AutoSize = False
        Me.MergeBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.MergeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeBtn.Image = Nothing
        Me.MergeBtn.Location = New System.Drawing.Point(16, 312)
        Me.MergeBtn.Name = "MergeBtn"
        Me.MergeBtn.Size = New System.Drawing.Size(64, 32)
        Me.MergeBtn.TabIndex = 4
        Me.MergeBtn.Text = "Merge"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(88, 312)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 17
        Me.CloseBtn.Text = "&Close"
        '
        'MergeQuotationForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(320, 357)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.MergeBtn)
        Me.Controls.Add(Me.SubQuoList)
        Me.Controls.Add(Me.MastQuoCmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "MergeQuotationForm"
        Me.Text = "Merge Quotation"
        CType(Me.MastQuoCmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MergeQuotationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadMasterQuotation()
    End Sub

    Private Sub LoadMasterQuotation()
        Dim ds As DataSet
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If .GetQuotationHeaderWORevisedQuo(ds) Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Try
                        AddListFieldInfoToLookUp(MastQuoCmb, "Quotation_NO", 400, 0, "c")
                        MastQuoCmb.Properties.LookUpData.KeyField = "Quotation_ID"
                        MastQuoCmb.Properties.LookUpData.DisplayField = "Quotation_NO"

                        MastQuoCmb.Properties.LookUpData.DataSource = ds.Tables(0)
                        MastQuoCmb.EditValue = "0"
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

    Private Sub MastQuoCmb_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles MastQuoCmb.CloseUp
        Dim dsSubQuo As DataSet

        'If SubQuoList.Items.Count > 0 Then
        'Dim i As Integer
        'For i = 0 To SubQuoList.Items.Count - 1
        'SubQuoList.Items.RemoveAt(i)
        'Next
        'SubQuoList.Items.Clear()
        'End If
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If Len(MastQuoCmb.Properties.LookUpData.KeyValue) > 0 Then
                MasterQuotation_ID = Integer.Parse(MastQuoCmb.Properties.LookUpData.KeyValue.ToString)
                .RefQuotationID = MastQuoCmb.Properties.LookUpData.KeyValue.ToString
                If .GetSubQuotationHeader(dsSubQuo) Then
                    If dsSubQuo.Tables(0).Rows.Count > 0 Then

                        SubQuoList.DisplayMember = "Quotation_NO"
                        SubQuoList.ValueMember = "Quotation_ID"
                        SubQuoList.DataSource = dsSubQuo.Tables(0)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub MergeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MergeBtn.Click
        Dim dsSubQuo As DataSet
        Dim c As DataRowView
        'Dim li As ListItem
        Me.Cursor = Cursors.WaitCursor
        With New BusinessRules.SaleBusRules.SaleBusLogic
            If SubQuoList.SelectedItems.Count > 0 Then
                For Each c In SubQuoList.SelectedItems
                    'Quotation_ID = SubQuoList.SelectedItems.Item(c)

                    Quotation_ID = c.Item("Quotation_ID") ' SubQuoList.SelectedItems.Item(c).Value
                    'Quotation_ID = dr("Quotation_ID")


                    .Quotation_ID = MasterQuotation_ID
                    If .GetNextItemNo() Then
                        ItemNo = .ItemNo

                        'Get the sub quotation line item
                        .Quotation_ID = Quotation_ID
                        If .GetQuotationLine(dsSubQuo) Then
                            Dim x As Integer
                            For x = 0 To dsSubQuo.Tables(0).Rows.Count - 1
                                'Save the itemno first
                                ItemNo = ItemNo + 1
                                .ItemNo = ItemNo
                                .Quotation_ID = MasterQuotation_ID
                                .UserID = UserID
                                If .SaveQuotationLineFirstTime() Then
                                    Quotation_Line_ID = .Quotation_Line_ID
                                End If
                                '***
                                SubQuotation_Line_ID = dsSubQuo.Tables(0).Rows(x)("Quotation_Line_ID")
                                If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Box")) Then
                                    .Box = dsSubQuo.Tables(0).Rows(x)("Box")
                                End If
                                .BoxCategory_ID = dsSubQuo.Tables(0).Rows(x)("BoxCategory_Id")
                                .varHeight = dsSubQuo.Tables(0).Rows(x)("Height")
                                .varWidth = dsSubQuo.Tables(0).Rows(x)("Width")
                                .Depth = dsSubQuo.Tables(0).Rows(x)("Depth")
                                If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Raw_Material")) Then
                                    .Raw_Material = dsSubQuo.Tables(0).Rows(x)("Raw_Material")
                                End If

                                .Material_Cost = dsSubQuo.Tables(0).Rows(x)("Material_Cost")
                                If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Type")) Then
                                    .Type = dsSubQuo.Tables(0).Rows(x)("Type")
                                End If

                                If Not IsDBNull(dsSubQuo.Tables(0).Rows(x)("Thickness")) Then
                                    .Thickness = dsSubQuo.Tables(0).Rows(x)("Thickness")
                                End If
                                .Power_Coat = dsSubQuo.Tables(0).Rows(x)("Power_Coat")
                                .Wiring = dsSubQuo.Tables(0).Rows(x)("Wiring")
                                .Accessory = dsSubQuo.Tables(0).Rows(x)("Accessory")
                                .Copper = dsSubQuo.Tables(0).Rows(x)("Copper")
                                .Comp_Markup = dsSubQuo.Tables(0).Rows(x)("Comp_Markup")
                                .Concrete_Base = dsSubQuo.Tables(0).Rows(x)("Concrete_Base")
                                .Transport = dsSubQuo.Tables(0).Rows(x)("Transport")
                                .Enclosure = dsSubQuo.Tables(0).Rows(x)("Enclosure")
                                .Qty = dsSubQuo.Tables(0).Rows(x)("Qty")
                                .Cost = dsSubQuo.Tables(0).Rows(x)("Cost")
                                .Overall_Markup = dsSubQuo.Tables(0).Rows(x)("Overall_Markup")
                                .Total_Amount = dsSubQuo.Tables(0).Rows(x)("Total_Amount")
                                .OC_EF = dsSubQuo.Tables(0).Rows(x)("OC_EF")
                                .Incoming = dsSubQuo.Tables(0).Rows(x)("Incoming")
                                .Panel_Transport = dsSubQuo.Tables(0).Rows(x)("Panel_Transport")
                                .Installation = dsSubQuo.Tables(0).Rows(x)("Installation")
                                .Type_Of_Enclosure = dsSubQuo.Tables(0).Rows(x)("Type_Of_Enclosure")
                                .Quotation_Line_ID = Quotation_Line_ID
                                .UserID = UserID

                                If .UpdateQuotationLine() Then
                                    Dim dsComp As DataSet
                                    .Quotation_Line_ID = SubQuotation_Line_ID
                                    If .GetQuotationLineCompOnLineID(dsComp) Then
                                        Dim i As Integer
                                        For i = 0 To dsComp.Tables(0).Rows.Count - 1
                                            .Quotation_ID = MasterQuotation_ID
                                            .Quotation_Line_ID = Quotation_Line_ID
                                            .Category_ID = dsComp.Tables(0).Rows(i)("Category_ID")
                                            .Product_ID = dsComp.Tables(0).Rows(i)("Product_ID")
                                            .Supplier_ID = dsComp.Tables(0).Rows(i)("Supplier_ID")
                                            .UnitPrice = dsComp.Tables(0).Rows(i)("UnitPrice")
                                            .Lead_Time = dsComp.Tables(0).Rows(i)("Lead_Time")
                                            .CompQty = dsComp.Tables(0).Rows(i)("Qty")
                                            .UserID = UserID
                                            If .SaveQuotationLineComponent() Then

                                            End If
                                        Next
                                    End If
                                    dsComp.Dispose()
                                End If
                            Next
                        End If 'GET QUOTATION LINE
                    End If
                    .Quotation_ID = Quotation_ID
                    .UserID = UserID
                    .Status = 70 'Merged
                    If .UpdateQuotationHeaderStatus Then
                    End If
                Next
            End If
            If Not dsSubQuo Is Nothing Then
                dsSubQuo.Dispose()
                MessageBox.Show("Merging Completed.")
            Else
                MessageBox.Show("Nothing to Merge.")
            End If
            CloseBtn_Click(sender, e)
        End With

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub MergeQuotationForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub
End Class
