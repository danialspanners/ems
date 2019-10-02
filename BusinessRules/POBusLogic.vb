Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace POBusRules

#Region "POHeader"

    Public Class POHeaderBusLogic

#Region "Variables Initialization"

        Private mvarPO_ID As Integer
        Private mvarPO_NO As String
        Private mvarPO_Title As String
        Private mvarShipment_Date As String
        Private mvarSupplier_ID As Integer
        Private mvarStatus As String
        Private mvarGrp As String
        Private mvarDiscountType As String
        Private mvarDiscount As Double
        Private mvarRemarks As String
        Private mvarNotes As String
        Private mvarDeliverTo As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer
        Private mvarGST_Flg As Integer
        Private mvarRevNo As Integer

        Private mvarSupplierName As String
        Private mvarSupplierCurrency As String
        Private mvarSupplierPaymentTerms As String


#End Region

#Region "Code"

        Public Function Save() As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO POHeader("
            strSQL = strSQL & "PO_NO, PO_Title, GST_Flg,Shipment_Date, Supplier_ID, Status "
            strSQL = strSQL & ", Grp ,DiscountType, Discount, RevNo,Remarks, Notes, DeliverTo "
            strSQL = strSQL & ",Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarPO_NO) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarPO_NO, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPO_Title) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarPO_Title, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarGST_Flg) > 0 Then
                strSQL = strSQL & mvarGST_Flg & ","
            Else
                strSQL = strSQL & " 0,"
            End If

            If Len(mvarShipment_Date) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarShipment_Date, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarSupplier_ID <> 0 And mvarSupplier_ID <> Nothing Then
                strSQL = strSQL & mvarSupplier_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarStatus) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarStatus, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarGrp) > 0 Then
                strSQL = strSQL & "'" & mvarGrp & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarDiscountType) > 0 Then
                strSQL = strSQL & "'" & mvarDiscountType & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarDiscount) > 0 Then
                strSQL = strSQL & mvarDiscount & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRevNo) > 0 Then
                strSQL = strSQL & mvarRevNo & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRemarks) > 0 Then
                strSQL = strSQL & "'" & mvarRemarks & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarNotes) > 0 Then
                strSQL = strSQL & "'" & mvarNotes & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarDeliverTo) > 0 Then
                strSQL = strSQL & "'" & mvarDeliverTo & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            strSQL = strSQL & " GetDate(),"

            strSQL = strSQL & " GetDate(),"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & mvarUserID
            Else
                strSQL = strSQL & " NULL"
            End If

            strSQL = strSQL & ")"

            strSQL = strSQL & "(SELECT @@IDENTITY AS PO_ID from POHeader)"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return Integer.Parse(ds.Tables(0).Rows(0).Item(0).ToString)
                    End If
                Else
                    Return Nothing
                End If
            End With
            ds.Dispose()

        End Function

        Public Sub Delete(ByVal pPO_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM POHeader"
            strSQL = strSQL & " WHERE PO_ID=" & pPO_ID

            strSQL = strSQL & ";DELETE FROM POLine"
            strSQL = strSQL & " WHERE PO_ID=" & pPO_ID

            strSQL = strSQL & ";update PRLine "
            strSQL = strSQL & " set PO_ID=0, "
            strSQL = strSQL & " PO_Line_ID=0"
            strSQL = strSQL & " where PO_ID=" & pPO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pPO_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update POHeader set "

            If Len(mvarPO_NO) > 0 Then
                strSQL = strSQL & " PO_NO='" & Replace(mvarPO_NO, "'", "''") & "',"
            Else
                strSQL = strSQL & " PO_NO=NULL,"
            End If

            If Len(mvarPO_Title) > 0 Then
                strSQL = strSQL & " PO_Title='" & Replace(mvarPO_Title, "'", "''") & "',"
            Else
                strSQL = strSQL & " PO_Title=NULL,"
            End If

            If Len(mvarGST_Flg) > 0 Then
                strSQL = strSQL & " GST_Flg=" & mvarGST_Flg & ","
            End If

            If Len(mvarShipment_Date) > 0 Then
                strSQL = strSQL & " Shipment_Date='" & Replace(mvarShipment_Date, "'", "''") & "',"
            Else
                strSQL = strSQL & " Shipment_Date=NULL,"
            End If

            If mvarSupplier_ID <> 0 And mvarSupplier_ID <> Nothing Then
                strSQL = strSQL & " Supplier_ID=" & mvarSupplier_ID & ","
            Else
                strSQL = strSQL & " Supplier_ID=NULL,"
            End If

            If Len(mvarStatus) > 0 Then
                strSQL = strSQL & " Status='" & mvarStatus & "',"
            End If

            If Len(mvarGrp) > 0 Then
                strSQL = strSQL & " Grp='" & mvarGrp & "',"
            End If

            If Len(mvarDiscountType) > 0 Then
                strSQL = strSQL & " DiscountType='" & mvarDiscountType & "',"
            End If

            If Len(mvarDiscount) > 0 Then
                strSQL = strSQL & " Discount=" & mvarDiscount & ","
            End If

            If Len(mvarRevNo) > 0 Then
                strSQL = strSQL & " RevNo=" & mvarRevNo & ","
            End If

            If Len(mvarRemarks) > 0 Then
                strSQL = strSQL & " Remarks='" & mvarRemarks & "',"
            End If

            If Len(mvarNotes) > 0 Then
                strSQL = strSQL & " Notes='" & mvarNotes & "',"
            End If

            If Len(mvarDeliverTo) > 0 Then
                strSQL = strSQL & " DeliverTo='" & mvarDeliverTo & "',"
            End If

            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID
            Else
                strSQL = strSQL & " UserID=NULL"
            End If

            strSQL = strSQL & " WHERE PO_ID = " & pPO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Function LoadList(ByRef ds As DataSet, Optional ByVal pSupplierID As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT PO.*"
                SQLStr = SQLStr & " , SU.Supplier_Name As Supplier_Name "
                SQLStr = SQLStr & " FROM POHeader PO "
                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PO.Supplier_ID = SU.Supplier_ID) "
                
                SQLStr = SQLStr & " Where 1=1"

                If pSupplierID <> 0 Then
                    SQLStr = SQLStr & "AND SU.Supplier_ID =" & pSupplierID
                End If

                SQLStr = SQLStr & " Order by PO.PO_NO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadOutstandingPOReportList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT PO.*"
                SQLStr = SQLStr & " , SU.Supplier_Name As Supplier_Name "
                SQLStr = SQLStr & " FROM POHeader PO "
                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PO.Supplier_ID = SU.Supplier_ID) "
                'When stock are stock-in completely, status will change to 90
                'so outstanding PO are those not equal to 90
                SQLStr = SQLStr & " where PO.status <> 90 "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadPOList(ByRef ds As DataSet, ByVal Supplier_ID As Integer, _
                                   Optional ByVal date_from As String = "", _
                                   Optional ByVal date_to As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT PO.*"
                SQLStr = SQLStr & " FROM POHeader PO "
                SQLStr = SQLStr & " where PO.status = 90 "
                SQLStr = SQLStr & " and PO.supplier_id = " & Supplier_ID

                If Len(date_from) > 0 Then
                    SQLStr = SQLStr & " and Create_date >= '" & date_from & "'"
                End If

                If Len(date_to) > 0 Then
                    SQLStr = SQLStr & " and Create_date <= '" & date_to & "'"
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(Optional ByVal pPO_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT s.supplier_name as suppliername, c.currencyname as suppliercurrency, s.payment_term as supplierpaymentterms, * FROM POHeader po"

                SQLStr = SQLStr & " join Supplier s on s.supplier_id = po.supplier_id"
                SQLStr = SQLStr & " join Currency c on s.currency_id = c.currency_id"

                If pPO_ID <> "" Then
                    SQLStr = SQLStr & " WHERE po.PO_ID =" & pPO_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count <> 0 Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        Me.PO_ID = Integer.Parse(row("PO_ID").ToString())

                        If Not row.IsNull("PO_NO") Then
                            PO_NO = row("PO_NO").ToString()
                        Else
                            PO_NO = ""
                        End If

                        If Not row.IsNull("suppliername") Then
                            SupplierName = row("suppliername").ToString()
                        Else
                            SupplierName = ""
                        End If

                        If Not row.IsNull("SupplierCurrency") Then
                            SupplierCurrency = row("SupplierCurrency").ToString()
                        Else
                            SupplierCurrency = ""
                        End If

                        If Not row.IsNull("SupplierPaymentTerms") Then
                            SupplierPaymentTerms = row("SupplierPaymentTerms").ToString()
                        Else
                            SupplierPaymentTerms = ""
                        End If




                        If Not row.IsNull("Shipment_Date") Then
                            Shipment_Date = row("Shipment_Date").ToString()
                        Else
                            Shipment_Date = ""
                        End If

                        If Not row.IsNull("Supplier_ID") Then
                            Supplier_ID = Integer.Parse(row("Supplier_ID").ToString())
                        Else
                            Supplier_ID = Nothing
                        End If

                        If Not row.IsNull("Status") Then
                            Status = row("Status").ToString()
                        Else
                            Status = ""
                        End If

                        If Not row.IsNull("Grp") Then
                            Grp = row("Grp").ToString()
                        Else
                            Grp = ""
                        End If

                        If Not row.IsNull("DiscountType") Then
                            DiscountType = row("DiscountType").ToString()
                        Else
                            DiscountType = ""
                        End If


                        If Not row.IsNull("GST_Flg") Then
                            Me.GST_Flg = row("GST_Flg").ToString()
                        Else
                            GST_Flg = 0
                        End If


                        If Not row.IsNull("Discount") Then
                            Discount = Double.Parse(row("Discount").ToString())
                        Else
                            Discount = 0
                        End If

                        If Not row.IsNull("PO_Title") Then
                            Me.Title = row("PO_Title").ToString()
                        Else
                            Title = ""
                        End If

                        If Not row.IsNull("Remarks") Then
                            Remarks = row("Remarks").ToString()
                        Else
                            Remarks = ""
                        End If

                        If Not row.IsNull("Notes") Then
                            Notes = row("Notes").ToString()
                        Else
                            Notes = ""
                        End If

                        If Not row.IsNull("DeliverTo") Then
                            DeliverTo = row("DeliverTo").ToString()
                        Else
                            DeliverTo = ""
                        End If

                        If Not row.IsNull("Create_Date") Then
                            Create_Date = row("Create_Date").ToString()
                        Else
                            Create_Date = ""
                        End If

                        If Not row.IsNull("Transact_Date") Then
                            Transact_Date = row("Transact_Date").ToString()
                        Else
                            Transact_Date = ""
                        End If

                        If Not row.IsNull("UserID") Then
                            UserID = Integer.Parse(row("UserID").ToString())
                        Else
                            UserID = Nothing
                        End If

                        Return True
                    Else
                        Return False
                    End If



                End If
            End With
        End Function

        'Check for unique PO No
        Public Function RecordExists(ByVal pPO_NO As String, Optional ByVal pPO_ID As Integer = Nothing) As Boolean

            Dim SQLStr As String
            Dim ds As DataSet

            SQLStr = "SELECT * FROM POHeader"
            SQLStr = SQLStr & " WHERE PO_NO='" & Replace(pPO_NO, "'", "''") & "'"

            If pPO_ID <> Nothing Then
                SQLStr = SQLStr & " AND PO_ID<>" & pPO_ID
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                Else
                    Return False
                End If

            End With

        End Function

        Public Function GetPOLastRevNo(ByVal pPO_NO As String) As Integer
            GetPOLastRevNo = 0
        End Function

#End Region


#Region "Get and Let Property"

        Public Property PO_ID() As Integer
            Get
                Return mvarPO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPO_ID = Value
            End Set
        End Property

        Public Property PO_NO() As String
            Get
                Return mvarPO_NO
            End Get
            Set(ByVal Value As String)
                mvarPO_NO = Value
            End Set
        End Property

        Public Property SupplierName() As String
            Get
                Return mvarSupplierName
            End Get
            Set(ByVal Value As String)
                mvarSupplierName = Value
            End Set
        End Property

        Public Property SupplierCurrency() As String
            Get
                Return mvarSupplierCurrency
            End Get
            Set(ByVal Value As String)
                mvarSupplierCurrency = Value
            End Set
        End Property

        Public Property SupplierPaymentTerms() As String
            Get
                Return mvarSupplierPaymentTerms
            End Get
            Set(ByVal Value As String)
                mvarSupplierPaymentTerms = Value
            End Set
        End Property

        Public Property PO_Title() As String
            Get
                Return mvarPO_Title
            End Get
            Set(ByVal Value As String)
                mvarPO_Title = Value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return mvarPO_Title
            End Get
            Set(ByVal Value As String)
                mvarPO_Title = Value
            End Set
        End Property


        Public Property GST_Flg() As Integer
            Get
                Return mvarGST_Flg
            End Get
            Set(ByVal Value As Integer)
                mvarGST_Flg = Value
            End Set
        End Property

        Public Property Shipment_Date() As String
            Get
                Return mvarShipment_Date
            End Get
            Set(ByVal Value As String)
                mvarShipment_Date = Value
            End Set
        End Property

        Public Property Supplier_ID() As Integer
            Get
                Return mvarSupplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplier_ID = Value
            End Set
        End Property

        Public Property Status() As Integer
            Get
                Return mvarStatus
            End Get
            Set(ByVal Value As Integer)
                mvarStatus = Value
            End Set
        End Property

        Public Property Grp() As String
            Get
                Return mvarGrp
            End Get
            Set(ByVal Value As String)
                mvarGrp = Value
            End Set
        End Property

        Public Property DiscountType() As String
            Get
                Return mvarDiscountType
            End Get
            Set(ByVal Value As String)
                mvarDiscountType = Value
            End Set
        End Property

        Public Property Discount() As Double
            Get
                Return mvarDiscount
            End Get
            Set(ByVal Value As Double)
                mvarDiscount = Value
            End Set
        End Property

        Public Property RevNo() As Integer
            Get
                Return mvarRevNo
            End Get
            Set(ByVal Value As Integer)
                RevNo = Value
            End Set
        End Property

        Public Property Remarks() As String
            Get
                Return mvarRemarks
            End Get
            Set(ByVal Value As String)
                mvarRemarks = Value
            End Set
        End Property

        Public Property Notes() As String
            Get
                Return mvarNotes
            End Get
            Set(ByVal Value As String)
                mvarNotes = Value
            End Set
        End Property

        Public Property DeliverTo() As String
            Get
                Return mvarDeliverTo
            End Get
            Set(ByVal Value As String)
                mvarDeliverTo = Value
            End Set
        End Property

        Public Property Create_Date() As String
            Get
                Return mvarCreate_Date
            End Get
            Set(ByVal Value As String)
                mvarCreate_Date = Value
            End Set
        End Property

        Public Property Transact_Date() As String
            Get
                Return mvarTransact_Date
            End Get
            Set(ByVal Value As String)
                mvarTransact_Date = Value
            End Set
        End Property

        Public Property UserID() As Integer
            Get
                Return mvarUserID
            End Get
            Set(ByVal Value As Integer)
                mvarUserID = Value
            End Set
        End Property

#End Region

#Region " Outstanding PO Report "

        Public Function GetOutstandingPOReport(ByRef ds As DataSet)

            Dim SQLStr As String
            SQLStr = "SELECT PO.*"
            SQLStr = SQLStr & " , SU.Supplier_Name As Supplier_Name "
            SQLStr = SQLStr & " FROM POHeader PO "
            SQLStr = SQLStr & " LEFT JOIN Supplier SU "
            SQLStr = SQLStr & " ON (PO.Supplier_ID = SU.Supplier_ID) "
            'When stock are stock-in completely, status will change to 90
            'so outstanding PO are those not equal to 90
            SQLStr = SQLStr & " where PO.status <> 90 "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

        Public Sub New()

        End Sub
    End Class

#End Region

#Region "POLine"

    Public Class POLineBusLogic

#Region "Variables Initialization"

        Private mvarPO_Line_ID As Integer
        Private mvarPO_ID As Integer
        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarAdhocItemDesc As String
        Private mvarOrder_Qty As Decimal
        Private mvarConfirm_Qty As Decimal
        Private mvarPR_ID As Integer
        Private mvarPR_Line As Integer
        Private mvarStatus As String
        Private mvarUnit_Price As Decimal
        Private mvarWO_No As String
        Private mvarDelivery_Date As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

#Region "Code"

        Public Function Save() As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO  POLine("
            strSQL = strSQL & "PO_ID, Category_ID, Product_ID, AdHocItemDesc, Order_Qty, Confirm_Qty "
            strSQL = strSQL & ",PR_ID, PR_Line, Status "
            strSQL = strSQL & ",Unit_Price, WO_No, Delivery_Date "
            strSQL = strSQL & ",Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If mvarPO_ID <> 0 And mvarPO_ID <> Nothing Then

                strSQL = strSQL & mvarPO_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarCategory_ID <> 0 And mvarCategory_ID <> Nothing Then
                strSQL = strSQL & mvarCategory_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarProduct_ID <> 0 And mvarProduct_ID <> Nothing Then
                strSQL = strSQL & mvarProduct_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarAdHocItemDesc) <> 0 And mvarAdHocItemDesc <> Nothing Then
                strSQL = strSQL & "'" & mvarAdHocItemDesc & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarOrder_Qty) > 0 Then
                strSQL = strSQL & mvarOrder_Qty & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarConfirm_Qty) > 0 Then
                strSQL = strSQL & mvarConfirm_Qty & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarPR_ID <> 0 And mvarPR_ID <> Nothing Then
                strSQL = strSQL & mvarPR_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarPR_Line <> 0 And mvarPR_Line <> Nothing Then
                strSQL = strSQL & mvarPR_Line & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarStatus) > 0 Then
                strSQL = strSQL & "'" & mvarStatus & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarUnit_Price <> Nothing Then
                strSQL = strSQL & mvarUnit_Price & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarWO_No) > 0 Then
                strSQL = strSQL & "'" & mvarWO_No & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarDelivery_Date) > 0 Then
                strSQL = strSQL & "'" & mvarDelivery_Date & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            strSQL = strSQL & " GetDate(),"

            strSQL = strSQL & " GetDate(),"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & mvarUserID
            Else
                strSQL = strSQL & " NULL"
            End If

            strSQL = strSQL & ")"

            strSQL = strSQL & "(SELECT @@IDENTITY AS PO_Line_ID from POLine)"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return Integer.Parse(ds.Tables(0).Rows(0).Item(0).ToString)
                    End If
                Else
                    Return Nothing
                End If
            End With
            ds.Dispose()

        End Function

        Public Sub Delete(ByVal pPO_Line_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM POLine"
            strSQL = strSQL & " WHERE PO_Line_ID=" & pPO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub DeleteAll(ByVal pPO_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM POLine"
            strSQL = strSQL & " WHERE PO_ID=" & pPO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pPO_Line_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update POLine set "

            If mvarPO_ID <> 0 And mvarPO_ID <> Nothing Then
                strSQL = strSQL & " PO_ID=" & mvarPO_ID & ","
            End If


            If mvarCategory_ID <> 0 And mvarCategory_ID <> Nothing Then
                strSQL = strSQL & " Category_ID=" & mvarCategory_ID & ","
            End If

            If mvarProduct_ID <> 0 And mvarProduct_ID <> Nothing Then
                strSQL = strSQL & " Product_ID=" & mvarProduct_ID & ","
            End If

            If Len(mvarAdhocItemDesc) <> 0 And mvarAdhocItemDesc <> Nothing Then
                strSQL = strSQL & " AdhocItemDesc='" & mvarAdhocItemDesc & "',"
            End If

            If Len(mvarOrder_Qty) > 0 Then
                strSQL = strSQL & " Order_Qty=" & mvarOrder_Qty & ","
            End If

            If Len(mvarConfirm_Qty) > 0 Then
                strSQL = strSQL & " Confirm_Qty=" & mvarConfirm_Qty & ","
            End If

            If mvarPR_ID <> 0 And mvarPR_ID <> Nothing Then
                strSQL = strSQL & " PR_ID=" & mvarPR_ID & ","
            End If

            If mvarPR_Line <> 0 And mvarPR_Line <> Nothing Then
                strSQL = strSQL & " PR_Line=" & mvarPR_Line & ","
            End If

            If Len(mvarStatus) > 0 Then
                strSQL = strSQL & " Status='" & mvarStatus & "',"
            End If

            If mvarUnit_Price <> Nothing Then
                strSQL = strSQL & " Unit_Price=" & mvarUnit_Price & ","
            End If

            If Len(mvarWO_No) > 0 Then
                strSQL = strSQL & " WO_No='" & mvarWO_No & "',"
            End If

            If Len(mvarDelivery_Date) > 0 Then
                strSQL = strSQL & " Delivery_Date='" & mvarDelivery_Date & "',"
            End If

            If mvarUserID <> 0 And mvarUserID <> Nothing Then
                strSQL = strSQL & " UserID=" & mvarUserID & ","
            End If

            strSQL = strSQL & " Transact_Date=GetDate()"


            strSQL = strSQL & " WHERE PO_Line_ID = " & pPO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Function LoadPOItemList(ByRef ds As DataSet, Optional ByVal pPO_ID As String = "0") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = ""


                SQLStr = SQLStr & " SELECT ProductName "
                SQLStr = SQLStr & " , Price, UOM, WO_No, Status, Delivery_Date, Order_Qty=SUM(Order_Qty)  FROM ("

                SQLStr = SQLStr & "SELECT "

                SQLStr = SQLStr & " ProductName = PD.Name"
                SQLStr = SQLStr & " , PO.Unit_Price As Price "
                SQLStr = SQLStr & " , UOM.Name As UOM "
                SQLStr = SQLStr & " , PO.WO_No As WO_No"
                SQLStr = SQLStr & " , PO.Status As Status "

                SQLStr = SQLStr & " , Delivery_Date = CASE"
                SQLStr = SQLStr & "         WHEN PO.Delivery_Date IS NULL THEN 'To be advised' "
                SQLStr = SQLStr & "         WHEN PO.Delivery_Date = '' THEN 'To be advised' "
                SQLStr = SQLStr & "         ELSE CONVERT(char(12), PO.Delivery_Date, 6) "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , PO.Order_Qty As Order_Qty "

                SQLStr = SQLStr & " FROM POLine PO "

                SQLStr = SQLStr & " LEFT JOIN Product PD "
                SQLStr = SQLStr & " ON (PO.Product_ID = PD.Product_ID) "

                SQLStr = SQLStr & " LEFT JOIN UnitMeasurement UOM "
                SQLStr = SQLStr & " ON (UOM.UOM_ID = PD.UOM_ID) "

                If pPO_ID <> "0" Then
                    SQLStr = SQLStr & " WHERE PO.PO_ID =" & pPO_ID
                End If

                SQLStr = SQLStr & "  ) AS T GROUP BY ProductName, Price, UOM, WO_No, Status, Delivery_Date"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet, Optional ByVal pPO_ID As String = "0") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT  p.Name AS productname,  description = CASE WHEN adhocitemdesc IS NULL THEN p.description ELSE adhocitemdesc END, u.Name AS Unitname, PO.*"
                SQLStr = SQLStr & " FROM POLine PO "
                SQLStr = SQLStr & " left outer JOIN Product p ON po.Product_ID = p.Product_ID"
                SQLStr = SQLStr & " left outer JOIN UnitMeasurement u ON p.UOM_ID = u.UOM_ID"

                If pPO_ID <> "0" Then
                    SQLStr = SQLStr & " WHERE PO.PO_ID =" & pPO_ID
                End If

                'Debug.Write(SQLStr)

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(Optional ByVal pPO_Line_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet

                Dim SQLStr As String = "SELECT PO.*"
                SQLStr = SQLStr & " FROM POLine PO "

                If pPO_Line_ID <> "" Then
                    SQLStr = SQLStr & " WHERE PO.PO_Line_ID =" & pPO_Line_ID
                End If

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count > 0 Then

                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("PO_ID") Then
                            PO_ID = Integer.Parse(row("PO_ID").ToString())
                        Else
                            PO_ID = Nothing
                        End If

                        If Not row.IsNull("Category_ID") Then
                            Category_ID = Integer.Parse(row("Category_ID").ToString())
                        Else
                            Category_ID = Nothing
                        End If

                        If Not row.IsNull("Product_ID") Then
                            Product_ID = Integer.Parse(row("Product_ID").ToString())
                        Else
                            Product_ID = Nothing
                        End If

                        If Not row.IsNull("Order_Qty") Then
                            Order_Qty = Integer.Parse(row("Order_Qty").ToString())
                        Else
                            Order_Qty = ""
                        End If

                        If Not row.IsNull("Confirm_Qty") Then
                            Confirm_Qty = Integer.Parse(row("Confirm_Qty").ToString())
                        Else
                            Confirm_Qty = ""
                        End If

                        If Not row.IsNull("PR_ID") Then
                            PR_ID = Integer.Parse(row("PR_ID").ToString())
                        Else
                            PR_ID = ""
                        End If

                        If Not row.IsNull("PR_Line") Then
                            PR_Line = Integer.Parse(row("PR_Line").ToString())
                        Else
                            PR_Line = ""
                        End If

                        If Not row.IsNull("Status") Then
                            Status = row("Status").ToString()
                        Else
                            Status = ""
                        End If

                        If Not row.IsNull("Unit_Price") Then
                            Unit_Price = Decimal.Parse(row("Unit_Price").ToString())
                        Else
                            Unit_Price = ""
                        End If

                        If Not row.IsNull("WO_No") Then
                            WO_No = row("WO_No").ToString()
                        Else
                            WO_No = ""
                        End If

                        If Not row.IsNull("Delivery_Date") Then
                            Delivery_Date = row("Delivery_Date").ToString()
                        Else
                            Delivery_Date = ""
                        End If

                        If Not row.IsNull("Create_Date") Then
                            Create_Date = row("Create_Date").ToString()
                        Else
                            Create_Date = ""
                        End If

                        If Not row.IsNull("Transact_Date") Then
                            Transact_Date = row("Transact_Date").ToString()
                        Else
                            Transact_Date = ""
                        End If

                        If Not row.IsNull("UserID") Then
                            UserID = Integer.Parse(row("UserID").ToString())
                        Else
                            UserID = Nothing
                        End If
                        Return True

                    Else
                        Return False
                    End If

                End If
            End With
        End Function

        Public Function LoadOutstandingPOItemReportList(ByRef ds As DataSet, Optional ByVal pDate_From As String = "", Optional ByVal pDate_To As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "select '" & pDate_From & "' as Start_Date, '"
                SQLStr = SQLStr & pDate_To & "' as End_Date, "
                SQLStr = SQLStr & "PH.PO_No as PO_No, PH.Create_Date as Create_Date, PR.PR_No as PR_No, SU.Supplier_Name as Supplier_Name, "
                SQLStr = SQLStr & "Prod.Name as Name, Prod.description as Description, PL.Delivery_Date as Delivery_Date, PL.Order_Qty as Order_Qty, "
                SQLStr = SQLStr & "PL.Confirm_Qty as Confirm_Qty, PL.WO_No as WO_No "
                SQLStr = SQLStr & "from POLine PL, POHeader PH, PRHeader PR, Supplier SU, Product Prod "
                SQLStr = SQLStr & "where PL.PO_ID = PH.PO_ID and "
                SQLStr = SQLStr & "PL.Order_Qty > PL.Confirm_Qty and "
                SQLStr = SQLStr & "PH.Supplier_ID = SU.Supplier_ID and "
                SQLStr = SQLStr & "PL.PR_ID = PR.PR_ID and "
                SQLStr = SQLStr & "PL.Product_ID = Prod.Product_ID "
                If pDate_From <> "" Then
                    SQLStr = SQLStr & "and delivery_Date > '" & pDate_From & "' "
                End If
                If pDate_To <> "" Then
                    SQLStr = SQLStr & "and delivery_Date < '" & pDate_To & "'"
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadWorkOrderPOReportList(ByRef ds As DataSet, ByVal pWO_No As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "Select PH.PO_No as PO_No, PH.Create_Date as Create_Date, "
                SQLStr = SQLStr & "Prod.Name as Name, Prod.description as Description, PL.Order_Qty as Order_Qty, "
                SQLStr = SQLStr & "PL.Unit_Price as Unit_Price, PL.WO_No as WO_No, SU.Supplier_Name as Supplier_Name "
                SQLStr = SQLStr & "from POLine PL, POHeader PH, Product Prod, Supplier SU "
                SQLStr = SQLStr & "where PL.PO_ID = PH.PO_ID and "
                SQLStr = SQLStr & "PH.Supplier_ID = SU.Supplier_ID and "
                SQLStr = SQLStr & "PL.Product_ID = Prod.Product_ID and "
                SQLStr = SQLStr & "PL.WO_No = '" & pWO_No & "'"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadSupplierPOReportList(ByRef ds As DataSet _
                                                 , Optional ByVal pSupplier_From As String = "" _
                                                 , Optional ByVal pSupplier_To As String = "" _
                                                 , Optional ByVal pSupplier_Type As String = "" _
                                                 , Optional ByVal pSupplier_Status As String = "" _
                                                 , Optional ByVal pDate_From As String = "" _
                                                 , Optional ByVal pDate_To As String = "") As Boolean

            Dim Condition As String

            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "Select '" & pSupplier_From & "' as Supplier_From, '"
                SQLStr = SQLStr & pSupplier_To & "' as Supplier_To, '"
                SQLStr = SQLStr & pSupplier_Type & "' as Supplier_Type, '"
                SQLStr = SQLStr & pSupplier_Status & "' as Supplier_Status, '"
                SQLStr = SQLStr & pDate_From & "' as Date_From, '"
                SQLStr = SQLStr & pDate_To & "' as Date_To, "
                SQLStr = SQLStr & "PH.Create_Date as Create_Date, SU.Supplier_Name as Supplier_Name, "
                SQLStr = SQLStr & "SU.Offer as Offer "
                SQLStr = SQLStr & "from Supplier SU LEFT JOIN POHeader PH ON "
                SQLStr = SQLStr & "(SU.Supplier_ID = PH.Supplier_ID) "
                If pSupplier_From <> "" Then
                    Condition = " Where SU.Supplier_Name >='" & pSupplier_From & "'"
                End If
                If pSupplier_To <> "" Then
                    If Condition = "" Then
                        Condition = Condition & " Where SU.Supplier_Name <='" & pSupplier_To & "'"
                    Else
                        Condition = Condition & " and SU.Supplier_Name <='" & pSupplier_To & "'"
                    End If
                End If
                If pSupplier_Type <> "" Then
                    If Condition = "" Then
                        Condition = Condition & " Where SU.Supplier_Type <='" & pSupplier_Type & "'"
                    Else
                        Condition = Condition & " and SU.Supplier_Type <='" & pSupplier_Type & "'"
                    End If
                End If
                If pSupplier_Status <> "" Then
                    If Condition = "" Then
                        Condition = Condition & " Where SU.Approved <='" & pSupplier_Status & "'"
                    Else
                        Condition = Condition & " and SU.Approved <='" & pSupplier_Status & "'"
                    End If
                End If
                If pDate_From <> "" Then
                    If Condition = "" Then
                        Condition = Condition & " Where PH.Create_Date >= '" & pDate_From & "' "
                    Else
                        Condition = Condition & " and PH.Create_Date >= '" & pDate_From & "' "
                    End If
                End If
                If pDate_To <> "" Then
                    If Condition = "" Then
                        Condition = Condition & " Where PH.Create_Date <= '" & pDate_To & "'"
                    Else
                        Condition = Condition & " and PH.Create_Date <= '" & pDate_To & "'"
                    End If
                End If

                SQLStr = SQLStr & Condition

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

#End Region

#Region "Get and Let Property"

        Public Property PO_Line_ID() As Integer
            Get
                Return mvarPO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPO_Line_ID = Value
            End Set
        End Property

        Public Property PO_ID() As Integer
            Get
                Return mvarPO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPO_ID = Value
            End Set
        End Property

        Public Property Category_ID() As Integer
            Get
                Return mvarCategory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCategory_ID = Value
            End Set
        End Property

        Public Property Product_ID() As Integer
            Get
                Return mvarProduct_ID
            End Get
            Set(ByVal Value As Integer)
                mvarProduct_ID = Value
            End Set
        End Property

        Public Property Order_Qty() As Decimal
            Get
                Return mvarOrder_Qty
            End Get
            Set(ByVal Value As Decimal)
                mvarOrder_Qty = Value
            End Set
        End Property

        Public Property Confirm_Qty() As Decimal
            Get
                Return mvarConfirm_Qty
            End Get
            Set(ByVal Value As Decimal)
                mvarConfirm_Qty = Value
            End Set
        End Property

        Public Property PR_ID() As Integer
            Get
                Return mvarPR_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPR_ID = Value
            End Set
        End Property

        Public Property PR_Line() As Integer
            Get
                Return mvarPR_Line
            End Get
            Set(ByVal Value As Integer)
                mvarPR_Line = Value
            End Set
        End Property

        Public Property Status() As String
            Get
                Return mvarStatus
            End Get
            Set(ByVal Value As String)
                mvarStatus = Value
            End Set
        End Property

        Public Property Unit_Price() As Decimal
            Get
                Return mvarUnit_Price
            End Get
            Set(ByVal Value As Decimal)
                mvarUnit_Price = Value
            End Set
        End Property

        Public Property WO_No() As String
            Get
                Return mvarWO_No
            End Get
            Set(ByVal Value As String)
                mvarWO_No = Value
            End Set
        End Property

        Public Property Delivery_Date() As String
            Get
                Return mvarDelivery_Date
            End Get
            Set(ByVal Value As String)
                mvarDelivery_Date = Value
            End Set
        End Property

        Public Property AdhocItemDesc() As String
            Get
                Return mvarAdhocItemDesc
            End Get
            Set(ByVal Value As String)
                mvarAdhocItemDesc = Value
            End Set
        End Property

        Public Property Create_Date() As String
            Get
                Return mvarCreate_Date
            End Get
            Set(ByVal Value As String)
                mvarCreate_Date = Value
            End Set
        End Property

        Public Property Transact_Date() As String
            Get
                Return mvarTransact_Date
            End Get
            Set(ByVal Value As String)
                mvarTransact_Date = Value
            End Set
        End Property

        Public Property UserID() As Integer
            Get
                Return mvarUserID
            End Get
            Set(ByVal Value As Integer)
                mvarUserID = Value
            End Set
        End Property

#End Region

    End Class

#End Region

#Region "Basic PO Logic"

    Public Class POBusLogic

        Public Const APPROVED_STATUS = "40"

        Public Function LoadConfirmedPR(ByRef ds As DataSet, Optional ByVal pEmptyPO_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT PRH.*, PRL.* "
                SQLStr = SQLStr & " FROM PRHeader PRH "
                SQLStr = SQLStr & " LEFT JOIN PRLine PRL ON (PRH.PR_ID = PRL.PR_ID)"

                SQLStr = SQLStr & " WHERE PRH.Status = '" & APPROVED_STATUS & "'"

                If pEmptyPO_ID = "1" Then
                    SQLStr = SQLStr & " AND (PRL.PO_ID = 0 OR PRL.PO_ID IS NULL)"
                    SQLStr = SQLStr & " AND (PRL.PO_Line_ID =0 OR PRL.PO_Line_ID IS NULL)"
                ElseIf pEmptyPO_ID = "0" Then
                    SQLStr = SQLStr & " AND (PRL.PO_ID <> 0 AND PRL.PO_ID NOT IS NULL) AND (PRL.PO_Line_ID <> 0 AND PRL.PO_Line_ID NOT IS NULL)"
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        'Load list of PR which requires to generate PO
        Public Function LoadPRList(ByRef ds As DataSet, Optional ByVal pSupplier_ID As String = "0", Optional ByVal pStatus As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT PH.* "
                SQLStr = SQLStr & " FROM PRHeader PH "

                SQLStr = SQLStr & " WHERE PH.PR_ID in "

                SQLStr = SQLStr & " ( "

                SQLStr = SQLStr & " SELECT PR_ID FROM PRLINE  "

                If pSupplier_ID <> "0" Then
                    SQLStr = SQLStr & " WHERE Supplier_ID ='" & pSupplier_ID & "'"
                    SQLStr = SQLStr & " AND (PO_ID =0 OR PO_ID IS NULL)"
                    SQLStr = SQLStr & " AND (PO_Line_ID =0 OR PO_Line_ID IS NULL)"
                    SQLStr = SQLStr & " AND Order_Qty > 0"
                Else
                    SQLStr = SQLStr & " WHERE (PO_ID =0 OR PO_ID IS NULL)"
                    SQLStr = SQLStr & " AND (PO_Line_ID =0 OR PO_Line_ID IS NULL)"
                    SQLStr = SQLStr & " AND Order_Qty > 0"
                End If

                SQLStr = SQLStr & " ) "

                SQLStr = SQLStr & " AND PH.Status = '" & pStatus & "' "

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                End If

            End With
        End Function

        Public Function LoadPRSupplierList(ByRef ds As DataSet, Optional ByVal pStatus As String = "", Optional ByVal pPR_ID As String = "", Optional ByVal pCheckApproval As Boolean = False) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String
                'SQLStr = = "SELECT  "
                'SQLStr = SQLStr & " SU.Supplier_Name As Supplier_Name "
                'SQLStr = SQLStr & " , SU.Supplier_ID As Supplier_ID "
                'SQLStr = SQLStr & " , SU.Tel As Tel "
                'SQLStr = SQLStr & " , SU.Contact_Person As Contact_Person "
                'SQLStr = SQLStr & " FROM PRHeader PH "

                'SQLStr = SQLStr & " LEFT JOIN PRLine PR "
                'SQLStr = SQLStr & " ON (PH.PR_ID = PR.PR_ID) "

                'SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                'SQLStr = SQLStr & " ON (PR.Supplier_ID = SU.Supplier_ID) "

                'SQLStr = SQLStr & " WHERE (PR.PO_ID =0 OR PR.PO_ID IS NULL)"
                'SQLStr = SQLStr & " AND (PR.PO_Line_ID =0 OR PR.PO_Line_ID IS NULL)"
                'SQLStr = SQLStr & " AND PR.Order_Qty > 0"

                'SQLStr = SQLStr & " AND PH.Status = '" & pStatus & "' "

                'If pPR_ID <> "" Then
                ''    SQLStr = SQLStr & pPR_ID
                'End If

                'SQLStr = SQLStr & " group by SU.Supplier_Name "
                'SQLStr = SQLStr & ", SU.Supplier_ID "
                'SQLStr = SQLStr & ", SU.Tel "
                'SQLStr = SQLStr & ", SU.Contact_Person "

                SQLStr = SQLStr & " SELECT "
                SQLStr = SQLStr & " Supplier_Name, Supplier_ID, GST_Flg "
                SQLStr = SQLStr & " FROM ("
                SQLStr = SQLStr & " SELECT  "

                SQLStr = SQLStr & "  GST_Flg = SU.GST_Flg,"

                SQLStr = SQLStr & "  Supplier_Name = CASE"
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID IS NULL THEN SU.Supplier_Name "
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID = 0 THEN SU.Supplier_Name "
                SQLStr = SQLStr & "         ELSE SU2.Supplier_Name "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & "  ,Supplier_ID = CASE"
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID IS NULL THEN SU.Supplier_ID "
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID = 0 THEN SU.Supplier_ID "
                SQLStr = SQLStr & "         ELSE SU2.Supplier_ID "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " FROM PRHeader PH "

                SQLStr = SQLStr & " LEFT JOIN PRLine PR "
                SQLStr = SQLStr & " ON (PH.PR_ID = PR.PR_ID) "

                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PR.Supplier_ID = SU.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Supplier SU2 "
                SQLStr = SQLStr & " ON (PR.Actual_Supplier_ID = SU2.Supplier_ID) "

                SQLStr = SQLStr & " WHERE (PR.PO_ID =0 OR PR.PO_ID IS NULL)"
                SQLStr = SQLStr & " AND (PR.PO_Line_ID =0 OR PR.PO_Line_ID IS NULL)"
                SQLStr = SQLStr & " AND PR.Order_Qty > 0"

                SQLStr = SQLStr & " AND PH.Status = '" & pStatus & "' "

                If pPR_ID <> "" Then
                    SQLStr = SQLStr & pPR_ID
                End If

                If pCheckApproval Then
                    SQLStr = SQLStr & " AND("
                    SQLStr = SQLStr & "     (PR.Actual_Supplier_ID IS NOT NULL AND SU2.Approved=1)"
                    SQLStr = SQLStr & "     OR (PR.Actual_Supplier_ID IS NULL AND SU.Approved=1)"
                    SQLStr = SQLStr & "     OR (PR.Actual_Supplier_ID = 0 AND SU.Approved = 1)"
                    SQLStr = SQLStr & "     OR (PR.Actual_Supplier_ID <> 0 AND SU2.Approved = 1)"
                    SQLStr = SQLStr & " )"
                End If

                SQLStr = SQLStr & "  )  AS T WHERE  Supplier_ID > 0 GROUP BY "
                SQLStr = SQLStr & " GST_Flg ,Supplier_Name, Supplier_ID"

                'Debug.WriteLine(SQLStr)

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                End If

            End With
        End Function

        Public Function LoadPRLineList(ByRef ds As DataSet, Optional ByVal pPR_ID As String = "0", Optional ByVal pSupplier_ID As String = "0", Optional ByVal pCheckApproval As Boolean = False) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = ""

                SQLStr = " SELECT "

                SQLStr = SQLStr & " PR.PR_Line As PR_Line"

                SQLStr = SQLStr & " , Supplier_ID = CASE"
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID IS NULL THEN SU.Supplier_ID "
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID = 0 THEN SU.Supplier_ID "
                SQLStr = SQLStr & "         ELSE SU2.Supplier_ID "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , PR.Product_ID As Product_ID"
                SQLStr = SQLStr & " , PR.Category_ID As Category_ID"

                SQLStr = SQLStr & " , Supplier_Name = CASE"
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID IS NULL THEN SU.Supplier_Name "
                SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID = 0 THEN SU.Supplier_Name "
                SQLStr = SQLStr & "         ELSE SU2.Supplier_Name "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , PD.Name As ProductName "
                SQLStr = SQLStr & " , PR.Order_Qty As Order_Qty "

                SQLStr = SQLStr & " , UOM.Name As UOM "

                SQLStr = SQLStr & "  ,Price = CASE"
                SQLStr = SQLStr & "         WHEN PR.Actual_Price = 0 THEN PR.Enquiry_Price "
                'SQLStr = SQLStr & "         WHEN PR.Actual_Supplier_ID = 0 THEN PR.Enquiry_Price "
                SQLStr = SQLStr & "         ELSE PR.Actual_Price "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & ", PR.WO_No As WO_No "

                SQLStr = SQLStr & " , Delivery_Date = PR.Delivery_Date "

                SQLStr = SQLStr & " FROM PRLine PR "

                SQLStr = SQLStr & " LEFT JOIN Product PD "
                SQLStr = SQLStr & " ON (PR.Product_ID = PD.Product_ID) "

                SQLStr = SQLStr & " LEFT JOIN UnitMeasurement UOM "
                SQLStr = SQLStr & " ON (UOM.UOM_ID = PD.UOM_ID) "

                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PR.Supplier_ID = SU.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Supplier SU2 "
                SQLStr = SQLStr & " ON (PR.Actual_Supplier_ID = SU2.Supplier_ID) "
                SQLStr = SQLStr & " where 1=1 "
                If pPR_ID <> "0" Then
                    SQLStr = SQLStr & " and PR.PR_ID =" & pPR_ID

                    If pSupplier_ID <> "0" Then
                        SQLStr = SQLStr & " AND PR.Supplier_ID =" & pSupplier_ID
                    End If
                Else
                    If pSupplier_ID <> "0" Then
                        SQLStr = SQLStr & " and PR.Supplier_ID =" & pSupplier_ID
                    End If
                End If

                If pSupplier_ID = "0" Then
                    SQLStr = SQLStr & " and PR.Supplier_ID > 0  "
                End If

                SQLStr = SQLStr & " AND (PR.PO_ID =0 OR PR.PO_ID IS NULL)"
                SQLStr = SQLStr & " AND (PR.PO_Line_ID =0 OR PR.PO_Line_ID IS NULL)"
                SQLStr = SQLStr & " AND PR.Order_Qty > 0"

                If pCheckApproval Then
                    SQLStr = SQLStr & " AND("
                    SQLStr = SQLStr & "     (PR.Actual_Supplier_ID IS NOT NULL AND SU2.Approved=1)"
                    SQLStr = SQLStr & "     OR (PR.Actual_Supplier_ID IS NULL AND SU.Approved=1)"
                    SQLStr = SQLStr & "     OR (PR.Actual_Supplier_ID = 0 AND SU.Approved = 1)"
                    SQLStr = SQLStr & "     OR (PR.Actual_Supplier_ID <> 0 AND SU2.Approved = 1)"
                    SQLStr = SQLStr & " )"
                End If

                SQLStr = SQLStr & " Order by PR.Create_Date ASC "

                'Debug.WriteLine(SQLStr)

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                End If

            End With
        End Function

        Public Function GetPORpt(ByRef ds As DataSet, Optional ByVal pPO_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = ""


                SQLStr = SQLStr & " Set dateformat dmy; SELECT "
                SQLStr = SQLStr & " PO_Title,ProductName = case when product_id = 0 or product_id is null then adhocitemdesc else ProductDesc + ModelParts end,Unit=case when product_id=0 then 'Unit' else Unit end , "
                SQLStr = SQLStr & " cast(Unit_Price as money) as Unit_Price"
                SQLStr = SQLStr & " , Qty=SUM(Order_Qty), Amount =  SUM(Order_Qty) * Unit_Price  "
                SQLStr = SQLStr & " , PO_NO, Remarks , Upper(Shipment_Date) as Shipment_date "
                SQLStr = SQLStr & " , GST, SupplierName, SupplierAddress, ContactPerson, PaymentTerm, Fax, Tel1,Tel2, GST  "
                SQLStr = SQLStr & " , DiscountType, DiscountAmt, DiscountPercent, DeliverTo, Delivery_Date, PO_Date, CurrencySymbol, CurrencyName "
                SQLStr = SQLStr & " FROM ("

                SQLStr = SQLStr & "SELECT "

                SQLStr = SQLStr & " PH.PO_Title as PO_Title, PH.Remarks as Remarks, PH.DiscountType as DiscountType, ProductDesc = PD.Description , Product_id=PO.Product_id, Unit=UM.Name "

                SQLStr = SQLStr & " ,create_date = PO.create_date,adhocitemdesc = PO.adhocitemdesc, Unit_Price = PO.Unit_Price"

                SQLStr = SQLStr & " , Delivery_Date = CASE"
                SQLStr = SQLStr & "         WHEN PO.Delivery_Date IS NULL THEN 'To be advised' "
                SQLStr = SQLStr & "         WHEN PO.Delivery_Date = '' THEN 'To be advised' "
                SQLStr = SQLStr & "         ELSE CONVERT(char(12), PO.Delivery_Date, 6) "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , Order_Qty = PO.Order_Qty "

                SQLStr = SQLStr & " , PO_NO = PH.PO_NO "

                SQLStr = SQLStr & " , PO_Date = CONVERT(char(12), PH.Create_Date, 6) "

                SQLStr = SQLStr & " , Shipment_Date = CASE"
                SQLStr = SQLStr & "         WHEN PH.Shipment_Date IS NULL THEN 'As Stated Below' "
                SQLStr = SQLStr & "         WHEN PH.Shipment_Date = '' THEN 'As Stated Below' "
                SQLStr = SQLStr & "         ELSE CAST(DAY(PH.Shipment_Date) AS VARCHAR(2)) + ' ' + DATENAME(MM, PH.Shipment_Date) + ' ' + RIGHT(CAST(YEAR(PH.Shipment_Date) AS VARCHAR(4)), 4) "

                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , DeliverTo = PH.DeliverTo "

                SQLStr = SQLStr & " , GST = CASE PH.GST_Flg"
                SQLStr = SQLStr & "         WHEN 0 THEN 0 "
                SQLStr = SQLStr & "         ELSE 7"
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , ModelParts = CASE "
                SQLStr = SQLStr & "         WHEN PD.Model ='' THEN '' "
                SQLStr = SQLStr & "         WHEN PD.Model IS NULL THEN '' "
                SQLStr = SQLStr & "         ELSE '(MODEL/PART: ' + PD.Model + ')' "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , DiscountAmt = CASE PH.DiscountType"
                SQLStr = SQLStr & "         WHEN '1' THEN Discount " 'Discount by amt
                SQLStr = SQLStr & "         WHEN '3' THEN Discount " 'Add by amt
                SQLStr = SQLStr & "         ELSE 0"
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , DiscountPercent = CASE PH.DiscountType"
                SQLStr = SQLStr & "         WHEN '2' THEN Discount " 'Discount by percent
                SQLStr = SQLStr & "         WHEN '4' THEN Discount " 'Add by percent
                SQLStr = SQLStr & "         ELSE 0"
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , SupplierName = SU.Supplier_Name "
                SQLStr = SQLStr & " , SupplierAddress = SU.Address + ' ' + SU.Country + ' ' + SU.Postal"
                SQLStr = SQLStr & " , ContactPerson = SU.Contact_Person "
                SQLStr = SQLStr & " , PaymentTerm = SU.Payment_Term "
                SQLStr = SQLStr & " , Fax = SU.Fax "
                SQLStr = SQLStr & " , Tel1 = SU.Tel1 "
                SQLStr = SQLStr & " , Tel2 = SU.Tel2 "
                SQLStr = SQLStr & " , CurrencySymbol = CU.CurrencySymbol "
                SQLStr = SQLStr & " , CurrencyName = CU.CurrencyName "

                SQLStr = SQLStr & " FROM POLine PO "

                SQLStr = SQLStr & " LEFT JOIN Product PD "
                SQLStr = SQLStr & " ON (PO.Product_ID = PD.Product_ID) "

                SQLStr = SQLStr & " LEFT JOIN UnitMeasurement UM "
                SQLStr = SQLStr & " ON (UM.UOM_ID = PD.UOM_ID) "

                SQLStr = SQLStr & " LEFT JOIN PRLine PR "
                SQLStr = SQLStr & " ON (PO.PR_Line = PR.PR_Line) "

                SQLStr = SQLStr & " LEFT JOIN POHeader PH "
                SQLStr = SQLStr & " ON (PO.PO_ID = PH.PO_ID) "

                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PH.Supplier_ID = SU.Supplier_ID) "

                SQLStr = SQLStr & " LEFT JOIN Currency CU "
                SQLStr = SQLStr & " ON (CU.Currency_ID = SU.Currency_ID) "


                If pPO_ID <> "0" Then
                    SQLStr = SQLStr & " WHERE PO.PO_ID =" & pPO_ID
                End If

                SQLStr = SQLStr & "  )  AS T GROUP BY "
                SQLStr = SQLStr & " ProductDesc,product_id,adhocitemdesc,ModelParts, Unit_Price, PO_NO, PO_Title, Remarks, Shipment_Date "
                SQLStr = SQLStr & " , SupplierName, SupplierAddress, ContactPerson, PaymentTerm, Fax, Tel1,Tel2,GST "
                SQLStr = SQLStr & " , DiscountType, DiscountAmt, DiscountPercent, DeliverTo, Delivery_Date, PO_Date, CurrencySymbol, CurrencyName, Unit, create_date "
                SQLStr = SQLStr & " order by create_date"
                Debug.WriteLine(SQLStr)
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadPR(ByRef ds As DataSet, ByVal pPOID As Integer) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT MAX(pr.PR_ID) as pr_id ,MAX(pr.PR_NO) as pr_no"
                SQLStr = SQLStr & " FROM POLine po "
                SQLStr = SQLStr & " LEFT JOIN PRHeader pr ON (po.PR_ID= pr.PR_ID)"
                SQLStr = SQLStr & " where po.po_id=" & pPOID
                SQLStr = SQLStr & " Group by pr.PR_ID order by pr.pr_no asc"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Sub New()

        End Sub
    End Class

#End Region

#Region "PO Record"

    Public Class PORecord
        Private mvarSupplierID As Integer
        Private mvarDeliveryDate As String
        Private mvarDeliverTo As String
        Private mvarDiscountType As String
        Private mvarDiscount As Double
        Private mvarRemarks As String
        Private mvarTitle As String
        Private mvarNotes As String
        Private mvarGST As Integer
        Private mvarRevNo As Integer

        Dim poItem As New ArrayList

        Public Sub New(ByVal pSupplierID As Integer, _
                        ByVal pGST As Integer, _
                        ByVal pDeliveryDate As String, _
                        ByVal pDeliverTo As String, _
                        ByVal pDiscountType As String, _
                        ByVal pDiscount As Integer, _
                        ByVal pRemarks As String, _
                        ByVal pTitle As String, _
                        ByVal pNotes As String)
            Me.mvarSupplierID = pSupplierID
            Me.mvarGST = pGST
            Me.mvarDeliveryDate = pDeliveryDate
            Me.mvarDeliverTo = pDeliverTo
            Me.mvarDiscountType = pDiscountType
            Me.mvarDiscount = pDiscount
            Me.mvarRemarks = pRemarks
            Me.mvarTitle = pTitle
            Me.mvarNotes = pNotes

        End Sub

        Public Property SupplierID() As Integer
            Get
                Return mvarSupplierID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplierID = Value
            End Set
        End Property
        Public Property GST() As Integer
            Get
                Return mvarGST
            End Get
            Set(ByVal Value As Integer)
                mvarGST = Value
            End Set
        End Property
        Public Property DeliveryDate() As String
            Get
                Return mvarDeliveryDate
            End Get
            Set(ByVal Value As String)
                mvarDeliveryDate = Value
            End Set
        End Property

        Public Property DeliverTo() As String
            Get
                Return mvarDeliverTo
            End Get
            Set(ByVal Value As String)
                mvarDeliverTo = Value
            End Set
        End Property

        Public Property DiscountType() As String
            Get
                Return mvarDiscountType
            End Get
            Set(ByVal Value As String)
                mvarDiscountType = Value
            End Set
        End Property

        Public Property Discount() As Double
            Get
                Return mvarDiscount
            End Get
            Set(ByVal Value As Double)
                mvarDiscount = Value
            End Set
        End Property

        Public Property Remarks() As String
            Get
                Return mvarRemarks
            End Get
            Set(ByVal Value As String)
                mvarRemarks = Value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return mvarTitle
            End Get
            Set(ByVal Value As String)
                mvarTitle = Value
            End Set
        End Property


        Public Property Notes() As String
            Get
                Return mvarNotes
            End Get
            Set(ByVal Value As String)
                mvarNotes = Value
            End Set
        End Property
    End Class

    Public Class POItemRecord
        Private mvarPO_Line_ID As Integer
        Private mvarPO_ID As Integer

        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer

        Private mvarOrder_Qty As Integer
        Private mvarConfirm_Qty As Integer

        Private mvarPR_ID As Integer
        Private mvarPR_Line As Integer

        Private mvarStatus As String
        Private mvarUnit_Price As Decimal

        Private mvarProductName As String
        Private mvarPR_No As String
        Private mvarUOM As String
        Private mvarWO_No As String

        Public Sub New(ByVal pPO_Line_ID As Integer, _
                        ByVal pPO_ID As Integer, _
                        ByVal pCategory_ID As Integer, _
                        ByVal pProduct_ID As Integer, _
                        ByVal pOrder_Qty As Integer, _
                        ByVal pConfirm_Qty As Integer, _
                        ByVal pPR_ID As Integer, _
                        ByVal pPR_Line As Integer, _
                        ByVal pStatus As String, _
                        ByVal pUnit_Price As Decimal, _
                        ByVal pProductName As String, _
                        ByVal pPR_No As String, _
                        ByVal pUOM As String, _
                        ByVal pWO_No As String)

            Me.mvarPO_Line_ID = pPO_Line_ID
            Me.mvarPO_ID = pPO_ID

            Me.mvarCategory_ID = pCategory_ID
            Me.mvarConfirm_Qty = pProduct_ID

            Me.mvarOrder_Qty = pOrder_Qty
            Me.mvarConfirm_Qty = pConfirm_Qty

            Me.mvarPR_ID = pPR_ID
            Me.mvarPR_Line = pPR_Line

            Me.mvarStatus = pStatus
            Me.mvarUnit_Price = pUnit_Price

            Me.mvarProductName = pProductName
            Me.mvarPR_No = pPR_No
            Me.mvarUOM = pUOM
            Me.mvarWO_No = pWO_No

        End Sub

        Public Property PO_Line_ID() As Integer
            Get
                Return mvarPO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPO_Line_ID = Value
            End Set
        End Property

        Public Property PO_ID() As Integer
            Get
                Return mvarPO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPO_ID = Value
            End Set
        End Property

        Public Property Category_ID() As Integer
            Get
                Return mvarCategory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCategory_ID = Value
            End Set
        End Property

        Public Property Product_ID() As Integer
            Get
                Return mvarProduct_ID
            End Get
            Set(ByVal Value As Integer)
                mvarProduct_ID = Value
            End Set
        End Property

        Public Property Order_Qty() As Integer
            Get
                Return mvarOrder_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarOrder_Qty = Value
            End Set
        End Property

        Public Property Confirm_Qty() As Integer
            Get
                Return mvarConfirm_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarConfirm_Qty = Value
            End Set
        End Property


        Public Property PR_ID() As Integer
            Get
                Return mvarPR_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPR_ID = Value
            End Set
        End Property

        Public Property PR_Line() As Integer
            Get
                Return mvarPR_Line
            End Get
            Set(ByVal Value As Integer)
                mvarPR_Line = Value
            End Set
        End Property

        Public Property Status() As String
            Get
                Return mvarStatus
            End Get
            Set(ByVal Value As String)
                mvarStatus = Value
            End Set
        End Property

        Public Property Unit_Price() As Decimal
            Get
                Return mvarUnit_Price
            End Get
            Set(ByVal Value As Decimal)
                mvarUnit_Price = Value
            End Set
        End Property

        Public Property ProductName() As String
            Get
                Return mvarProductName
            End Get
            Set(ByVal Value As String)
                mvarProductName = Value
            End Set
        End Property

        Public Property PR_No() As String
            Get
                Return mvarPR_No
            End Get
            Set(ByVal Value As String)
                mvarPR_No = Value
            End Set
        End Property

        Public Property UOM() As String
            Get
                Return mvarUOM
            End Get
            Set(ByVal Value As String)
                mvarUOM = Value
            End Set
        End Property

        Public Property WO_No() As String
            Get
                Return mvarWO_No
            End Get
            Set(ByVal Value As String)
                mvarWO_No = Value
            End Set
        End Property

    End Class
#End Region

End Namespace


