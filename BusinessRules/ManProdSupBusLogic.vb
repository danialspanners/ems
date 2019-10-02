' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer


Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace ManProdSupBusRules
    Public Class ManProdSupBusLogic

#Region "Variables Initialization"

        Private mvarProductSupplier_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarCurrency As Integer
        Private mvarCatalog_Price As Decimal
        Private mvarEnquiry_Price As Decimal
        Private mvarPurchase_Price As Decimal
        Private mvarSGDPrice As Decimal
        Private mvarRemarks As String
        Private mvarHistory_Record As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As Date
        Private mvarUserID As Integer

        Private mvarSupplier_Name As String

#End Region

#Region "Product database processes"

        Public Function Save() As Boolean
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO ProductSupplier("
            strSQL = strSQL & "Product_ID, Supplier_ID, Currency,Catalog_Price, Enquiry_Price "
            strSQL = strSQL & ",Purchase_Price, SGDPrice, Remarks, History_Record, Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarProduct_ID) > 0 Then
                strSQL = strSQL & mvarProduct_ID & ","
            Else
                strSQL = strSQL & " ,"
            End If

            If Len(mvarSupplier_ID) > 0 Then
                strSQL = strSQL & mvarSupplier_ID & ","
            Else
                strSQL = strSQL & " ,"
            End If

            If Len(mvarCurrency) > 0 Then
                strSQL = strSQL & mvarCurrency & ","
            Else
                strSQL = strSQL & " ,"
            End If

            If Len(mvarCatalog_Price) > 0 Then
                strSQL = strSQL & mvarCatalog_Price & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarEnquiry_Price) > 0 Then
                strSQL = strSQL & mvarEnquiry_Price & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPurchase_Price) > 0 Then
                strSQL = strSQL & mvarPurchase_Price & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarSGDPrice) > 0 Then
                strSQL = strSQL & mvarSGDPrice & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRemarks) > 0 Then
                strSQL = strSQL & "'" & mvarRemarks & "',"
            Else
                strSQL = strSQL & "'',"
            End If


            strSQL = strSQL & " '0',"

            strSQL = strSQL & " GetDate(),"

            strSQL = strSQL & "'" & mvarTransact_Date.Day & "/" & mvarTransact_Date.Month & "/" & mvarTransact_Date.Year & "',"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & mvarUserID
            Else
                strSQL = strSQL & " NULL"
            End If

            strSQL = strSQL & ")"

            Debug.WriteLine(strSQL)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                    Return True
                End If
            End With
            ds.Dispose()

        End Function

        Public Sub Delete(ByVal pProductSupplier_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM ProductSupplier"
            strSQL = strSQL & " WHERE ProductSupplier_ID=" & pProductSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Save()
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub DeleteAll(ByVal pProduct_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM ProductSupplier"
            strSQL = strSQL & " WHERE Product_ID=" & pProduct_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Save()
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub UpdateHistoryRec(ByVal pProductSupplier_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update ProductSupplier set "

            strSQL = strSQL & " History_Record='1'"

            strSQL = strSQL & " WHERE ProductSupplier_ID = " & pProductSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Sub Update(ByVal pProductSupplier_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update ProductSupplier set "

            strSQL = strSQL & " History_Record='1'"

            strSQL = strSQL & " WHERE ProductSupplier_ID = " & pProductSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Save()
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function LoadList(ByRef ds As DataSet, Optional ByVal pProduct_ID As String = "", Optional ByVal pHistory_Record As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM ProductSupplier PS LEFT JOIN Supplier S "
                SQLStr = SQLStr & " ON (PS.Supplier_ID = S.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Currency c on (PS.currency = c.Currency_id) "
                SQLStr = SQLStr & " where 1=1 " 'and S.Approved = '1' "

                If pProduct_ID <> "" Then
                    SQLStr = SQLStr & " AND Product_ID =" & pProduct_ID
                End If

                If pProduct_ID <> "" And pHistory_Record <> "" Then
                    SQLStr = SQLStr & " AND History_Record =" & pHistory_Record
                Else
                    If pHistory_Record <> "" Then
                        SQLStr = SQLStr & " AND History_Record =" & pHistory_Record
                    End If
                End If

                SQLStr = SQLStr & " Order by PS.Transact_date DESC"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(Optional ByVal pProductSupplier_ID As String = "", Optional ByVal pProduct_ID As String = "0", Optional ByVal pSupplier_ID As String = "0", Optional ByVal pHistory_Record As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet

                'Dim SQLStr As String = "SELECT * FROM ProductSupplier"
                Dim SQLStr As String = "SELECT * FROM ProductSupplier PS LEFT JOIN Supplier S "
                SQLStr = SQLStr & " ON (PS.Supplier_ID = S.Supplier_ID) Where S.Approved = '1' "

                If pProductSupplier_ID <> "" Then
                    SQLStr = SQLStr & " AND ProductSupplier_ID =" & pProductSupplier_ID
                Else
                    If pProduct_ID <> "0" Then
                        SQLStr = SQLStr & " AND Product_ID =" & pProduct_ID

                        If pSupplier_ID <> "0" Then
                            SQLStr = SQLStr & " AND Supplier_ID =" & pSupplier_ID
                        End If

                        If pHistory_Record <> "" Then
                            SQLStr = SQLStr & " AND History_Record =" & pHistory_Record
                        End If

                    End If
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Catalog_Price") Then
                        Catalog_Price = Decimal.Parse(row("Catalog_Price").ToString())
                    Else
                        Catalog_Price = Nothing
                    End If
                    If Not row.IsNull("Enquiry_Price") Then
                        Enquiry_Price = Decimal.Parse(row("Enquiry_Price").ToString())
                    Else
                        Enquiry_Price = Nothing
                    End If
                    If Not row.IsNull("Purchase_Price") Then
                        Purchase_Price = Decimal.Parse(row("Purchase_Price").ToString())
                    Else
                        Purchase_Price = Nothing
                    End If
                    If Not row.IsNull("Supplier_ID") Then
                        Supplier_ID = [Integer].Parse(row("Supplier_ID").ToString())
                    Else
                        Supplier_ID = Nothing
                    End If

                    Return True
                End If
            End With
        End Function

        Public Function RecordExists(ByVal pProduct_ID As String, Optional ByVal pSupplier_ID As String = "0") As Integer

            Dim SQLStr As String
            Dim ds As DataSet

            SQLStr = "SELECT ProductSupplier_ID FROM ProductSupplier"
            SQLStr = SQLStr & " WHERE Product_ID=" & pProduct_ID

            If pSupplier_ID <> "0" Then
                SQLStr = SQLStr & " AND Supplier_ID=" & pSupplier_ID
            End If

            SQLStr = SQLStr & " AND History_Record='0'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return Integer.Parse(ds.Tables(0).Rows(0).Item(0).ToString)
                    End If
                Else
                    Return False
                End If

            End With

        End Function

        Public Function RecordExists(ByVal pProduct_ID As String, ByVal pSupplier_ID As String, ByVal pTransact_Date As Date) As Integer

            Dim SQLStr As String
            Dim ds As DataSet

            SQLStr = "set dateformat dmy;SELECT ProductSupplier_ID FROM ProductSupplier"
            SQLStr = SQLStr & " WHERE Product_ID=" & pProduct_ID

            SQLStr = SQLStr & " AND Supplier_ID=" & pSupplier_ID
            SQLStr = SQLStr & " AND Transact_Date = '" & pTransact_Date.Day & "/" & pTransact_Date.Month & "/" & pTransact_Date.Year & "'"

            SQLStr = SQLStr & " AND History_Record='0'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return Integer.Parse(ds.Tables(0).Rows(0).Item(0).ToString)
                    End If
                Else
                    Return False
                End If

            End With

        End Function

        Public Function GetSupplierPrice(Optional ByVal pProductSupplier_ID As String = "") As Boolean
            Dim dsSupplier As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pProductSupplier_ID) > 0 Then
                    SQLStr = "SELECT PS.*,S.Supplier_Name as Supplier_Name FROM ProductSupplier PS LEFT JOIN Supplier S"
                    SQLStr = SQLStr & " ON (PS.Supplier_ID = S.Supplier_ID) "
                    SQLStr = SQLStr & " WHERE ProductSupplier_ID = " & pProductSupplier_ID
                    SQLStr = SQLStr & " and S.Approved = '1'"
                Else
                    SQLStr = "SELECT PS.*,S.Supplier_Name as Supplier_Name FROM ProductSupplier PS LEFT JOIN Supplier S"
                    SQLStr = SQLStr & " ON (PS.Supplier_ID = S.Supplier_ID) "
                    SQLStr = SQLStr & " WHERE Product_ID = " & mvarProduct_ID
                    SQLStr = SQLStr & " and S.Approved = '1'"
                    SQLStr = SQLStr & " AND (Enquiry_Price <> 0 AND Enquiry_Price IS NOT NULL) "
                    SQLStr = SQLStr & " ORDER BY Enquiry_Price"
                    'SQLStr = SQLStr & " ORDER BY Transact_date desc"
                End If

                Debug.WriteLine(SQLStr)

                If .GetDataSet(dsSupplier, SQLStr) Then
                    If dsSupplier.Tables(0).Rows.Count > 0 Then
                        Dim oRow As DataRow = dsSupplier.Tables(0).Rows(0)

                        mvarEnquiry_Price = oRow("Enquiry_Price")
                        mvarSupplier_ID = oRow("Supplier_ID")
                        mvarCatalog_Price = oRow("Catalog_Price")
                        mvarPurchase_Price = oRow("Purchase_Price")
                        mvarSGDPrice = oRow("SGDPrice")
                        mvarTransact_Date = oRow("Transact_Date")
                        If Not oRow.IsNull("Supplier_Name") Then
                            mvarSupplier_Name = oRow("Supplier_Name")
                        Else
                            mvarSupplier_Name = ""
                        End If
                        Return True
                    Else
                        Return False
                    End If
                End If

                dsSupplier.Dispose()
            End With
        End Function
#End Region

#Region "Get and Let Property"

        Public Property ProductSupplier_ID() As Integer
            Get
                Return mvarProductSupplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarProductSupplier_ID = Value
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

        Public Property Supplier_ID() As Integer
            Get
                Return mvarSupplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplier_ID = Value
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

        Public Property Currency() As Integer
            Get
                Return mvarCurrency
            End Get
            Set(ByVal Value As Integer)
                mvarCurrency = Value
            End Set
        End Property
        Public Property Catalog_Price() As Decimal
            Get
                Return mvarCatalog_Price
            End Get
            Set(ByVal Value As Decimal)
                mvarCatalog_Price = Value
            End Set
        End Property

        Public Property Enquiry_Price() As Decimal
            Get
                Return mvarEnquiry_Price
            End Get
            Set(ByVal Value As Decimal)
                mvarEnquiry_Price = Value
            End Set
        End Property

        Public Property Purchase_Price() As Decimal
            Get
                Return mvarPurchase_Price
            End Get
            Set(ByVal Value As Decimal)
                mvarPurchase_Price = Value
            End Set
        End Property

        Public Property SGDPrice() As Decimal
            Get
                Return mvarSGDPrice
            End Get
            Set(ByVal Value As Decimal)
                mvarSGDPrice = Value
            End Set
        End Property

        Public Property History_Record() As String
            Get
                Return mvarHistory_Record
            End Get
            Set(ByVal Value As String)
                mvarHistory_Record = Value
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

        Public Property Transact_Date() As Date
            Get
                Return mvarTransact_Date
            End Get
            Set(ByVal Value As Date)
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

        Public Property Supplier_Name() As String
            Get
                Return mvarSupplier_Name
            End Get
            Set(ByVal Value As String)
                mvarSupplier_Name = Value
            End Set
        End Property
#End Region

    End Class


End Namespace
