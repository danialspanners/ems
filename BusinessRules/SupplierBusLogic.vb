
Namespace SupplierBusRules

    Public Class SupplierBusLogic

#Region "Variables Initialization"

        Private mvarSupplier_ID As Integer
        Private mvarSupplier_Name As String
        Private mvarAccount_NO As String
        Private mvarAddress As String
        Private mvarCountry As String
        Private mvarPostal As String
        Private mvarTel1 As String
        Private mvarTel2 As String
        Private mvarFax As String
        Private mvarContact_Person As String
        Private mvarGST As String
        Private mvarGST_Flg As String
        Private mvarOffer As String
        Private mvarPayment_Term As String
        Private mvarApproved As String
        Private mvarSupplier_Type As String
        Private mvarPayment_Mode As String
        Private mvarRemark As String
        Private mvarCurrency_ID As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

        Public Function LoadSupplierList(ByRef ds As DataSet, Optional ByVal pSupplier_Name_From As String = "" _
                                         , Optional ByVal pSupplier_Name_To As String = "" _
                                         , Optional ByVal pSupplier_Type As String = "" _
                                         , Optional ByVal pApproved As String = "") As Boolean
            Dim SQLStr As String
            If Len(pSupplier_Name_From) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Supplier "
                SQLStr = SQLStr & "WHERE Supplier_Name >='" & pSupplier_Name_From & "'"
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Supplier"
            End If

            If Len(pSupplier_Name_To) > 0 Then
                If Len(pSupplier_Name_From) > 0 Then
                    SQLStr = SQLStr & " and Supplier_Name <='" & pSupplier_Name_To & "'"
                Else
                    SQLStr = SQLStr & " Where Supplier_Name <='" & pSupplier_Name_To & "'"
                End If
            End If

            If Len(pSupplier_Type) > 0 Then
                If Len(pSupplier_Name_From) Or Len(pSupplier_Name_To) > 0 Then
                    SQLStr = SQLStr & " and Supplier_Type = '" & pSupplier_Type & "'"
                Else
                    SQLStr = SQLStr & " Where Supplier_Type = '" & pSupplier_Type & "'"
                End If
            End If

            If Len(pApproved) > 0 Then
                If Len(pSupplier_Name_From) Or Len(pSupplier_Name_To) > 0 Or Len(pSupplier_Type) > 0 Then
                    SQLStr = SQLStr & " and Approved = '" & pApproved & "'"
                Else
                    SQLStr = SQLStr & " Where Approved = '" & pApproved & "'"
                End If
            End If

            SQLStr = SQLStr & " Order by Supplier_Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetSupplierHeader(ByRef ds As DataSet, Optional ByVal pSupplier_ID As String = "") As Boolean
            Dim SQLStr As String
            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Supplier where 1=1 "
            If Len(pSupplier_ID) > 0 Then

                SQLStr = SQLStr & "and Supplier_ID =" & pSupplier_ID
            Else
                SQLStr = SQLStr & "and supplier_type <> -1"
            End If

            SQLStr = SQLStr & " Order by Supplier_Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetSupplier(ByRef ds As DataSet, ByVal pSupplier_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Supplier "
            SQLStr = SQLStr & "WHERE Supplier_ID =" & pSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Supplier where 1=1 and supplier_type <> -1 order by Supplier_Name asc"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With

        End Function

        Public Function LoadCompany(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Supplier where supplier_type=-1 order by Supplier_Name asc"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With

        End Function


        Public Function Load(Optional ByVal pSupplier_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM Supplier"

                If pSupplier_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Supplier_ID =" & pSupplier_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then

                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("Supplier_Name") Then
                            Supplier_Name = row("Supplier_Name").ToString()
                        Else
                            Supplier_Name = ""
                        End If
                        If Not row.IsNull("Account_NO") Then
                            Account_NO = row("Account_NO").ToString()
                        Else
                            Account_NO = ""
                        End If

                        If Not row.IsNull("Address") Then
                            Address = row("Address").ToString()
                        Else
                            Address = ""
                        End If

                        If Not row.IsNull("Country") Then
                            Country = row("Country").ToString()
                        Else
                            Country = ""
                        End If

                        'If Not row.IsNull("Postal") Then

                        If Not IsDBNull(row("Postal")) Then
                            Postal = row("Postal").ToString()
                        Else
                            Postal = ""
                        End If

                        If Not row.IsNull("Tel1") Then
                            Tel1 = row("Tel1").ToString()
                        Else
                            Tel1 = ""
                        End If

                        If Not row.IsNull("Tel2") Then
                            Tel2 = row("Tel2").ToString()
                        Else
                            Tel2 = ""
                        End If

                        If Not row.IsNull("Fax") Then
                            Fax = row("Fax").ToString()
                        Else
                            Fax = ""
                        End If

                        If Not row.IsNull("Contact_Person") Then
                            Contact_Person = row("Contact_Person").ToString()
                        Else
                            Contact_Person = ""
                        End If

                        If Not row.IsNull("GST") Then
                            GST = row("GST").ToString()
                        Else
                            GST = ""
                        End If

                        If Not row.IsNull("GST_Flg") Then
                            GST_Flg = row("GST_Flg").ToString()
                        Else
                            GST_Flg = ""
                        End If

                        If Not row.IsNull("Offer") Then
                            Offer = row("Offer").ToString()
                        Else
                            Offer = ""
                        End If

                        If Not row.IsNull("Payment_Term") Then
                            Payment_Term = row("Payment_Term").ToString()
                            'Payment_Term = Integer.Parse(row("Payment_Term").ToString())
                        Else
                            Payment_Term = ""
                        End If

                        If Not row.IsNull("Approved") Then
                            Approved = row("Approved").ToString()
                        Else
                            Approved = ""
                        End If

                        If Not row.IsNull("Supplier_Type") Then
                            Supplier_Type = row("Supplier_Type").ToString()
                        Else
                            Supplier_Type = -1
                        End If

                        If Not row.IsNull("Payment_Mode") Then
                            Payment_Mode = row("Payment_Mode").ToString()
                        Else
                            Payment_Mode = ""
                        End If

                        If Not row.IsNull("Remark") Then
                            Remark = row("Remark").ToString()
                        Else
                            Remark = ""
                        End If

                        If Not row.IsNull("Currency_ID") Then
                            Currency_ID = Integer.Parse(row("Currency_ID").ToString())
                        Else
                            Currency_ID = Nothing
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
                    End If

                End If
            End With
        End Function

        Public Function SaveSupplier() As Boolean
            Dim dsSupplier As DataSet
            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO Supplier (Supplier_Name"
            SQLstr = SQLstr & ", Account_No, Address, Country, Postal, Tel1, Tel2"
            SQLstr = SQLstr & ", Fax, Contact_Person, GST, GST_Flg, Offer, Payment_Term"
            SQLstr = SQLstr & ", Approved, Supplier_Type, Payment_Mode, Remark, Currency_ID"
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & Replace(mvarSupplier_Name, "'", "''") & "', '" & mvarAccount_NO & "',"
            SQLstr = SQLstr & "'" & mvarAddress & "', '" & mvarCountry & "',"
            SQLstr = SQLstr & "'" & mvarPostal & "', '" & mvarTel1 & "',"
            SQLstr = SQLstr & "'" & mvarTel2 & "', '" & mvarFax & "',"
            SQLstr = SQLstr & "'" & mvarContact_Person & "', '" & mvarGST & "',"
            SQLstr = SQLstr & "'" & mvarGST_Flg & "', '" & mvarOffer & "',"
            SQLstr = SQLstr & "'" & mvarPayment_Term & "', '" & mvarApproved & "',"
            SQLstr = SQLstr & "'" & mvarSupplier_Type & "', '" & mvarPayment_Mode & "',"
            SQLstr = SQLstr & "'" & mvarRemark & "', " & mvarCurrency_ID & ","
            'SQLstr = SQLstr & "'" & mvarRemark & "',"
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & mvarUserID & ")"
            ' 10.12.2003 YG Start
            SQLstr = SQLstr & ";SELECT @@identity as Supplier_ID FROM Supplier"
            ' 10.12.2003 YG End

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSupplier, SQLstr) Then
                    ' 10.12.2003 YG Start
                    If dsSupplier.Tables(0).Rows.Count > 0 Then
                        mvarSupplier_ID = dsSupplier.Tables(0).Rows(0)(0)
                    End If
                    ' 10.12.2003 YG End
                    Return True
                End If
            End With
            dsSupplier.Dispose()
        End Function

        Public Function UpdateSupplier(ByVal pSupplier_ID As String) As Boolean
            Dim dsSupplier As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Supplier SET "
            SQLStr = SQLStr & " Supplier_Name = '" & Replace(mvarSupplier_Name, "'", "''") & "',"
            SQLStr = SQLStr & " Account_No = '" & mvarAccount_NO & "',"
            SQLStr = SQLStr & " Address = '" & Replace(mvarAddress, "'", "''") & "',"
            SQLStr = SQLStr & " Country = '" & mvarCountry & "',"
            SQLStr = SQLStr & " Postal = '" & mvarPostal & "',"
            SQLStr = SQLStr & " Tel1 = '" & mvarTel1 & "',"
            SQLStr = SQLStr & " Tel2 = '" & mvarTel2 & "',"
            SQLStr = SQLStr & " Fax = '" & mvarFax & "',"
            SQLStr = SQLStr & " Contact_Person = '" & Replace(mvarContact_Person, "'", "''") & "',"
            SQLStr = SQLStr & " GST = '" & mvarGST & "',"
            SQLStr = SQLStr & " GST_Flg = '" & Replace(mvarGST_Flg, "'", "''") & "',"
            SQLStr = SQLStr & " Offer = '" & Replace(mvarOffer, "'", "''") & "',"
            SQLStr = SQLStr & " Payment_Term = '" & mvarPayment_Term & "',"
            SQLStr = SQLStr & " Approved = '" & mvarApproved & "',"
            SQLStr = SQLStr & " Supplier_Type = '" & mvarSupplier_Type & "',"
            SQLStr = SQLStr & " Payment_Mode = '" & Replace(mvarPayment_Mode, "'", "''") & "',"
            SQLStr = SQLStr & " Remark = '" & Replace(mvarRemark, "'", "''") & "',"
            SQLStr = SQLStr & " Currency_ID = " & mvarCurrency_ID & ","
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = " & mvarUserID & " WHERE "
            SQLStr = SQLStr & " Supplier_ID = " & pSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSupplier, SQLStr) Then
                    Return True
                End If
            End With
            dsSupplier.Dispose()
        End Function

        Public Function UpdateSupplierApproveDate(ByVal pSupplier_ID As String) As Boolean
            Dim dsSupplier As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Supplier SET "
            SQLStr = SQLStr & " Approve_Date = GetDate(), "
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = " & mvarUserID & " WHERE "
            SQLStr = SQLStr & " Supplier_ID = " & pSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSupplier, SQLStr) Then
                    Return True
                End If
            End With
            dsSupplier.Dispose()
        End Function
        Public Function UpdateSupplierApprovalStatus(ByVal pSupplier_ID As String) As Boolean
            Dim dsSupplier As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Supplier SET "
            SQLStr = SQLStr & " Approved = '" & mvarApproved & "', "
            If mvarApproved = "0" Then
                SQLStr = SQLStr & " Approve_Date = NULL, "
            Else
                SQLStr = SQLStr & " Approve_Date = GetDate(), "
            End If
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = " & mvarUserID & " WHERE "
            SQLStr = SQLStr & " Supplier_ID = " & pSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSupplier, SQLStr) Then
                    Return True
                End If
            End With
            dsSupplier.Dispose()
        End Function

        Public Function ClearSupplierApproveDate(ByVal pSupplier_ID As String) As Boolean
            Dim dsSupplier As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Supplier SET "
            SQLStr = SQLStr & " Approve_Date = NULL, "
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = " & mvarUserID & " WHERE "
            SQLStr = SQLStr & " Supplier_ID = " & pSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSupplier, SQLStr) Then
                    Return True
                End If
            End With
            dsSupplier.Dispose()
        End Function
#Region " DELETE Supplier "
        Public Function DeleteSupplier(ByVal pSupplier_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM Supplier WHERE Supplier_ID = " & pSupplier_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pSupplier_Name As String, Optional ByVal pSupplier_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT Supplier_ID FROM Supplier"
            SQLStr = SQLStr & " WHERE Supplier_Name='" & Replace(pSupplier_Name, "'", "''") & "'"

            If pSupplier_ID <> Nothing And pSupplier_ID <> 0 Then
                SQLStr = SQLStr & " AND Supplier_ID<>" & pSupplier_ID
            End If
            Debug.Write(SQLStr)

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
#End Region

#Region "Get and Let Property"

        Public Property Supplier_ID() As Integer
            Get
                Return mvarSupplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplier_ID = Value
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

        Public Property Account_NO() As String
            Get
                Return mvarAccount_NO
            End Get
            Set(ByVal Value As String)
                mvarAccount_NO = Value
            End Set
        End Property

        Public Property Address() As String
            Get
                Return mvarAddress
            End Get
            Set(ByVal Value As String)
                mvarAddress = Value
            End Set
        End Property

        Public Property Country() As String
            Get
                Return mvarCountry
            End Get
            Set(ByVal Value As String)
                mvarCountry = Value
            End Set
        End Property

        Public Property Postal() As String
            Get
                Return mvarPostal
            End Get
            Set(ByVal Value As String)
                mvarPostal = Value
            End Set
        End Property

        Public Property Tel1() As String
            Get
                Return mvarTel1
            End Get
            Set(ByVal Value As String)
                mvarTel1 = Value
            End Set
        End Property

        Public Property Tel2() As String
            Get
                Return mvarTel2
            End Get
            Set(ByVal Value As String)
                mvarTel2 = Value
            End Set
        End Property

        Public Property Fax() As String
            Get
                Return mvarFax
            End Get
            Set(ByVal Value As String)
                mvarFax = Value
            End Set
        End Property

        Public Property Contact_Person() As String
            Get
                Return mvarContact_Person
            End Get
            Set(ByVal Value As String)
                mvarContact_Person = Value
            End Set
        End Property

        Public Property GST() As String
            Get
                Return mvarGST
            End Get
            Set(ByVal Value As String)
                mvarGST = Value
            End Set
        End Property

        Public Property GST_Flg() As String
            Get
                Return mvarGST_Flg
            End Get
            Set(ByVal Value As String)
                mvarGST_Flg = Value
            End Set
        End Property

        Public Property Offer() As String
            Get
                Return mvarOffer
            End Get
            Set(ByVal Value As String)
                mvarOffer = Value
            End Set
        End Property

        Public Property Payment_Term() As String
            Get
                Return mvarPayment_Term
            End Get
            Set(ByVal Value As String)
                mvarPayment_Term = Value
            End Set
        End Property

        Public Property Approved() As String
            Get
                Return mvarApproved
            End Get
            Set(ByVal Value As String)
                mvarApproved = Value
            End Set
        End Property

        Public Property Supplier_Type() As String
            Get
                Return mvarSupplier_Type
            End Get
            Set(ByVal Value As String)
                mvarSupplier_Type = Value
            End Set
        End Property

        Public Property Payment_Mode() As String
            Get
                Return mvarPayment_Mode
            End Get
            Set(ByVal Value As String)
                mvarPayment_Mode = Value
            End Set
        End Property

        Public Property Remark() As String
            Get
                Return mvarRemark
            End Get
            Set(ByVal Value As String)
                mvarRemark = Value
            End Set
        End Property

        Public Property Currency_ID() As Integer
            Get
                Return mvarCurrency_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCurrency_ID = Value
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

#Region " Supplier Report "
        Public Function GetSupplierReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SELECT * FROM Supplier" '(select column)
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Supplier On Time Report "
        Public Function GetSupplierOnTimeReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;select supplier_name, PO_No, shipment_date, max(transact_date) as delivered_date "
            SQLStr = SQLStr & " from v_supplier_ontime "
            SQLStr = SQLStr & " group by Supplier_Name, PO_NO, shipment_date"
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

    End Class

    Public Class SupplierHistoryBusLogic

#Region "Variables Initialization"

        Private mvarSupplierApprovalHistory_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarVendorEvent As String
        Private mvarRequester_ID As Integer
        Private mvarRequester_Date As String
        Private mvarApprover_ID As Integer
        Private mvarApprover_Date As String
        Private mvarStatus As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pSupplierApprovalHistory_ID As Integer) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT * FROM SupplierApprovalHistory"
            SQLStr = SQLStr & " WHERE SupplierApprovalHistory_ID=" & pSupplierApprovalHistory_ID

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

#End Region


        Public Function GetSupplierApprovalHistory(ByRef ds As DataSet, ByVal pSupplier_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT SAH.SupplierApprovalHistory_ID, SAH.VendorEvent, "
            SQLStr = SQLStr & "US1.Name as Requester, SAH.Request_Date, "
            SQLStr = SQLStr & "US2.Name as Approver, SAH.Approve_Date, "
            SQLStr = SQLStr & "SAH.Status "
            SQLStr = SQLStr & "FROM SupplierApprovalHistory SAH LEFT JOIN UserProfile US1 ON (SAH.Requester_ID = US1.User_ID) "
            SQLStr = SQLStr & "LEFT JOIN UserProfile US2 on (SAH.Approver_ID = US2.User_ID) "
            SQLStr = SQLStr & "WHERE SAH.Supplier_ID = " & pSupplier_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetLastSupplierApprovalRecord(ByRef ds As DataSet, ByVal pSupplierApprovalHistory_ID As Integer) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT SAH.SupplierApprovalHistory_ID, SAH.VendorEvent, "
            SQLStr = SQLStr & "US1.Name as Requester, SAH.Request_Date, "
            SQLStr = SQLStr & "SAH.Status "
            SQLStr = SQLStr & "FROM SupplierApprovalHistory SAH, UserProfile US1 "
            SQLStr = SQLStr & "WHERE SAH.SupplierApprovalHistory_ID = " & pSupplierApprovalHistory_ID
            SQLStr = SQLStr & " AND SAH.Requester_ID = US1.User_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function UpdateSupplierApprovalRecord(ByVal pSupplierApprovalHistory_ID As Integer) As Boolean
            Dim dsSupplier As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE SupplierApprovalHistory SET "
            If mvarApprover_ID > 0 Then
                SQLStr = SQLStr & " Approver_ID = " & mvarApprover_ID
                SQLStr = SQLStr & ", Approve_Date = GetDate(), "
            End If
            SQLStr = SQLStr & " Status = '" & mvarStatus & "', "
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " SupplierApprovalHistory_ID = " & pSupplierApprovalHistory_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSupplier, SQLStr) Then
                    Return True
                End If
            End With
            dsSupplier.Dispose()
        End Function


        Public Function SaveSupplierApprovalRecord() As Boolean
            Dim dsSupplierApprovalRecord As DataSet
            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO SupplierApprovalHistory (Supplier_ID"
            SQLstr = SQLstr & ", VendorEvent, Requester_ID, Request_Date "
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "(" & mvarSupplier_ID & ", '" & mvarVendorEvent & "',"
            SQLstr = SQLstr & mvarRequester_ID & ", GetDate(),"
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & mvarUserID & ")"
            SQLstr = SQLstr & ";SELECT @@identity as SupplierApprovalHistory_ID FROM SupplierApprovalHistory"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSupplierApprovalRecord, SQLstr) Then
                    If dsSupplierApprovalRecord.Tables(0).Rows.Count > 0 Then
                        mvarSupplierApprovalHistory_ID = dsSupplierApprovalRecord.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
            End With
            dsSupplierApprovalRecord.Dispose()
        End Function



#Region "Get and Let Property"

        Public Property SupplierApprovalHistory_ID() As Integer
            Get
                Return mvarSupplierApprovalHistory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplierApprovalHistory_ID = Value
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

        Public Property VendorEvent() As String
            Get
                Return mvarVendorEvent
            End Get
            Set(ByVal Value As String)
                mvarVendorEvent = Value
            End Set
        End Property

        Public Property Requester_ID() As Integer
            Get
                Return mvarRequester_ID
            End Get
            Set(ByVal Value As Integer)
                mvarRequester_ID = Value
            End Set
        End Property

        Public Property Requester_Date() As String
            Get
                Return mvarRequester_Date
            End Get
            Set(ByVal Value As String)
                mvarRequester_Date = Value
            End Set
        End Property

        Public Property Approver_ID() As Integer
            Get
                Return mvarApprover_ID
            End Get
            Set(ByVal Value As Integer)
                mvarApprover_ID = Value
            End Set
        End Property

        Public Property Approver_Date() As String
            Get
                Return mvarApprover_Date
            End Get
            Set(ByVal Value As String)
                mvarApprover_Date = Value
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

End Namespace
