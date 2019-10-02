
Namespace CustomerBusRules

    Public Class CustomerBusLogic

#Region "Variables Initialization"

        Private mvarCustomer_ID As Integer
        Private mvarName As String
        Private mvarAddress As String
        Private mvarCountry As String
        Private mvarPostal_Code As String
        Private mvarTel1 As String
        Private mvarTel2 As String
        Private mvarFax As String
        Private mvarStatus As String
        Private mvarCredit_Limit As String
        Private mvarPayment_Term As Integer
        Private mvarPayment_Detail As String
        Private mvarActive_Flg As String
        Private mvarInitial As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

        'Customer Contact
        Private mvarContact_ID As Integer
        Private mvarTitle As String
        Private mvarContact_Name As String
        Private mvarTel As String
        Private mvarExt As String
        Private mvarPager As String
        Private mvarHandPhone As String
        Private mvarEmail As String
#End Region

        Public Function GetCustomerHeader(ByRef ds As DataSet, Optional ByVal pCustomer_ID As String = "") As Boolean
            Dim SQLStr As String
            If Len(pCustomer_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Customer "
                SQLStr = SQLStr & "WHERE Customer_ID =" & pCustomer_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Customer"
            End If

            SQLStr = SQLStr & " Order by Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetCustomerHeaderFilter(ByRef ds As DataSet, Optional ByVal pFilter As String = "") As Boolean
            Dim SQLStr As String
            If Len(pFilter) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Customer "
                SQLStr = SQLStr & "WHERE 1=1 " & pFilter
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Customer"
            End If

            SQLStr = SQLStr & " Order by Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetCustomer(ByRef ds As DataSet, ByVal pCustomer_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Customer "
            SQLStr = SQLStr & "WHERE Customer_ID =" & pCustomer_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Customer"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pCustomer_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM Customer"

                If pCustomer_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Customer_ID =" & pCustomer_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Name") Then
                        Name = row("Name").ToString()
                    Else
                        Name = ""
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

                    If Not row.IsNull("Postal_Code") Then
                        Postal_Code = row("Postal_Code").ToString()
                    Else
                        Postal_Code = ""
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

                    If Not row.IsNull("Status") Then
                        Status = row("Status").ToString()
                    Else
                        Status = ""
                    End If

                    If Not row.IsNull("Credit_Limit") Then
                        Credit_Limit = row("Credit_Limit").ToString()
                    Else
                        Credit_Limit = ""
                    End If

                    If Not row.IsNull("Payment_Term") Then
                        Payment_Term = row("Payment_Term").ToString()
                    Else
                        Payment_Term = ""
                    End If

                    If Not row.IsNull("Payment_Detail") Then
                        Payment_Detail = row("Payment_Detail").ToString()
                    Else
                        Payment_Detail = ""
                    End If

                    If Not row.IsNull("Active_Flg") Then
                        Active_Flg = row("Active_Flg").ToString()
                    Else
                        Active_Flg = ""
                    End If

                    If Not row.IsNull("Initial") Then
                        Initial = row("Initial").ToString()
                    Else
                        Initial = ""
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
            End With
        End Function

        Public Function SaveCustomer() As Integer
            Dim dsCustomer As DataSet

            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO Customer (Name"
            SQLstr = SQLstr & ", Address, Country, Postal_Code, Tel1, Tel2"
            SQLstr = SQLstr & ", Fax, Status, Credit_Limit, Payment_Term"
            SQLstr = SQLstr & ", Payment_Detail, Active_Flg, Initial"
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarName & "', "
            SQLstr = SQLstr & "'" & mvarAddress & "', '" & mvarCountry & "',"
            SQLstr = SQLstr & "'" & mvarPostal_Code & "', '" & mvarTel1 & "',"
            SQLstr = SQLstr & "'" & mvarTel2 & "', '" & mvarFax & "',"
            SQLstr = SQLstr & "'" & mvarStatus & "', " & mvarCredit_Limit & ", "
            SQLstr = SQLstr & mvarPayment_Term & ", '" & mvarPayment_Detail & "', '"
            SQLstr = SQLstr & mvarActive_Flg & "', '" & mvarInitial & "',"
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"
            SQLstr = SQLstr & ";(select @@IDENTITY as Customer_ID from customer)"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsCustomer, SQLstr) Then
                    If dsCustomer.Tables(0).Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return Integer.Parse(dsCustomer.Tables(0).Rows(0).Item(0).ToString)
                    End If
                Else
                    Return Nothing
                End If
            End With
            dsCustomer.Dispose()
        End Function

        Public Function UpdateCustomer(ByVal pCustomer_ID As String) As Boolean
            Dim dsCustomer As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Customer SET "
            SQLStr = SQLStr & " Name = '" & mvarName & "',"
            SQLStr = SQLStr & " Address = '" & mvarAddress & "',"
            SQLStr = SQLStr & " Country = '" & mvarCountry & "',"
            SQLStr = SQLStr & " Postal_Code = '" & mvarPostal_Code & "',"
            SQLStr = SQLStr & " Tel1 = '" & mvarTel1 & "',"
            SQLStr = SQLStr & " Tel2 = '" & mvarTel2 & "',"
            SQLStr = SQLStr & " Fax = '" & mvarFax & "',"
            SQLStr = SQLStr & " Status = '" & mvarStatus & "',"
            SQLStr = SQLStr & " Credit_Limit = " & mvarCredit_Limit & ","
            SQLStr = SQLStr & " Payment_Term = " & mvarPayment_Term & ","
            SQLStr = SQLStr & " Payment_Detail = '" & mvarPayment_Detail & "',"
            SQLStr = SQLStr & " Active_Flg = '" & mvarActive_Flg & "',"
            SQLStr = SQLStr & " Initial = '" & mvarInitial & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " Customer_ID = " & pCustomer_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsCustomer, SQLStr) Then
                    Return True
                End If
            End With
            dsCustomer.Dispose()
        End Function

#Region " DELETE Customer "
        Public Function DeleteCustomer(ByVal pCustomer_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM Customer WHERE Customer_ID = " & pCustomer_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pCustomer_Name As String, Optional ByVal pCustomer_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT Customer_ID FROM Customer"
            SQLStr = SQLStr & " WHERE Name='" & pCustomer_Name & "'"

            If pCustomer_ID <> Nothing And pCustomer_ID <> 0 Then
                SQLStr = SQLStr & " AND Customer_ID=" & pCustomer_ID
            End If
            'Debug.Write(SQLStr)

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

        Public Function ContactRecordExists(ByVal pContact_Name As String, ByVal pCustomer_ID As Integer, Optional ByVal pContact_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT Contact_ID FROM CustomerContact"
            SQLStr = SQLStr & " WHERE Name='" & pContact_Name & "' and customer_id =" & pCustomer_ID

            If pContact_ID <> Nothing And pContact_ID <> 0 Then
                SQLStr = SQLStr & " AND Contact_ID<>" & pContact_ID
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

#Region "Get and Let Property for Customer Contact"
        Public Property Contact_ID() As Integer
            Get
                Return mvarContact_ID
            End Get
            Set(ByVal Value As Integer)
                mvarContact_ID = Value
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

        Public Property Contact_Name() As String
            Get
                Return mvarContact_Name
            End Get
            Set(ByVal Value As String)
                mvarContact_Name = Value
            End Set
        End Property

        Public Property Tel() As String
            Get
                Return mvarTel
            End Get
            Set(ByVal Value As String)
                mvarTel = Value
            End Set
        End Property

        Public Property Ext() As String
            Get
                Return mvarExt
            End Get
            Set(ByVal Value As String)
                mvarExt = Value
            End Set
        End Property

        Public Property Pager() As String
            Get
                Return mvarPager
            End Get
            Set(ByVal Value As String)
                mvarPager = Value
            End Set
        End Property

        Public Property HandPhone() As String
            Get
                Return mvarHandPhone
            End Get
            Set(ByVal Value As String)
                mvarHandPhone = Value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return mvarEmail
            End Get
            Set(ByVal Value As String)
                mvarEmail = Value
            End Set
        End Property

#End Region

#Region "Get and Let Property for Customer"

        Public Property Customer_ID() As Integer
            Get
                Return mvarCustomer_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCustomer_ID = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return mvarName
            End Get
            Set(ByVal Value As String)
                mvarName = Value
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

        Public Property Postal_Code() As String
            Get
                Return mvarPostal_Code
            End Get
            Set(ByVal Value As String)
                mvarPostal_Code = Value
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

        Public Property Status() As String
            Get
                Return mvarStatus
            End Get
            Set(ByVal Value As String)
                mvarStatus = Value
            End Set
        End Property

        Public Property Credit_Limit() As String
            Get
                Return mvarCredit_Limit
            End Get
            Set(ByVal Value As String)
                mvarCredit_Limit = Value
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

        Public Property Payment_Detail() As String
            Get
                Return mvarPayment_Detail
            End Get
            Set(ByVal Value As String)
                mvarPayment_Detail = Value
            End Set
        End Property


        Public Property Active_Flg() As String
            Get
                Return mvarActive_Flg
            End Get
            Set(ByVal Value As String)
                mvarActive_Flg = Value
            End Set
        End Property

        Public Property Initial() As String
            Get
                Return mvarInitial
            End Get
            Set(ByVal Value As String)
                mvarInitial = Value
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

        Public Property UserID() As String
            Get
                Return mvarUserID
            End Get
            Set(ByVal Value As String)
                mvarUserID = Value
            End Set
        End Property

#End Region

#Region " Customer Contact"

        Public Function GetCustomerContact_Display(ByRef ds As DataSet, Optional ByVal pCustomer_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pCustomer_ID) > 0 Then
                SQLStr = "SELECT * "
                SQLStr = SQLStr & " FROM CustomerContact "
                SQLStr = SQLStr & " WHERE Customer_ID = " & pCustomer_ID
            Else
                SQLStr = "SELECT * "
                SQLStr = SQLStr & " FROM CustomerContact "
            End If

            SQLStr = SQLStr & " Order by Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetCustomerContact(ByRef ds As DataSet, Optional ByVal pContact_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pContact_ID) > 0 Then
                SQLStr = "SELECT * "
                SQLStr = SQLStr & " FROM CustomerContact "
                SQLStr = SQLStr & " WHERE Contact_ID = " & pContact_ID
            Else
                SQLStr = "SELECT * "
                SQLStr = SQLStr & " FROM CustomerContact "
            End If

            SQLStr = SQLStr & " Order by Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function DeleteCustomerContact(ByVal pContact_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM CustomerContact WHERE Contact_ID = " & pContact_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveCustomerContact() As Integer
            Dim ds As DataSet

            Dim SQLstr As String = "INSERT INTO CustomerContact (Title"
            SQLstr = SQLstr & ", Name, Tel, Ext, Pager, HandPhone"
            SQLstr = SQLstr & ", ContactEmail, Customer_ID"
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarTitle & "', "
            SQLstr = SQLstr & "'" & mvarContact_Name & "', '" & mvarTel & "',"
            SQLstr = SQLstr & "'" & mvarExt & "', '" & mvarPager & "',"
            SQLstr = SQLstr & "'" & mvarHandPhone & "', '" & mvarEmail & "',"
            SQLstr = SQLstr & mvarCustomer_ID & ","
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"
            SQLstr = SQLstr & ";(select @@IDENTITY as Contact_ID from Project)"


            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
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

        Public Function UpdateCustomerContact(ByVal pContact_ID As String) As Boolean
            Dim dsCustomer As DataSet

            Dim SQLStr As String = "UPDATE CustomerContact SET "
            SQLStr = SQLStr & " Title = '" & mvarTitle & "',"
            SQLStr = SQLStr & " Name = '" & mvarContact_Name & "',"
            SQLStr = SQLStr & " Tel = '" & mvarTel & "',"
            SQLStr = SQLStr & " Ext = '" & mvarExt & "',"
            SQLStr = SQLStr & " Pager = '" & mvarPager & "',"
            SQLStr = SQLStr & " HandPhone = '" & mvarHandPhone & "',"
            SQLStr = SQLStr & " ContactEmail = '" & mvarEmail & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " Contact_ID = " & pContact_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsCustomer, SQLStr) Then
                    Return True
                End If
            End With
            dsCustomer.Dispose()
        End Function


#End Region

#Region " Customer Report "
        Public Function GetCustomerReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SELECT * FROM Customer" '(select column)
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region
    End Class

End Namespace
