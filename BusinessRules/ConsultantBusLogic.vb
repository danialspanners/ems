
Namespace ConsultantBusRules

    Public Class ConsultantBusLogic

#Region "Variables Initialization"

        Private mvarConsultant_ID As Integer
        Private mvarConsultant_Name As String
        Private mvarAccount_No As String
        Private mvarAddress As String
        Private mvarCountry As String
        Private mvarTel As String
        Private mvarFax As String
        Private mvarRemark As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

        Public Function GetConsultantHeader(ByRef ds As DataSet, Optional ByVal pConsultant_ID As String = "") As Boolean
            Dim SQLStr As String
            If Len(pConsultant_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Consultant "
                SQLStr = SQLStr & "WHERE Consultant_ID =" & pConsultant_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Consultant"
            End If

            SQLStr = SQLStr & " Order by Consultant_Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetConsultant(ByRef ds As DataSet, ByVal pConsultant_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Consultant "
            SQLStr = SQLStr & "WHERE Consultant_ID =" & pConsultant_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Consultant"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pConsultant_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM Consultant"

                If pConsultant_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Consultant_ID =" & pConsultant_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Consultant_Name") Then
                        Consultant_Name = row("Consultant_Name").ToString()
                    Else
                        Consultant_Name = ""
                    End If

                    If Not row.IsNull("Account_No") Then
                        Account_No = row("Account_No").ToString()
                    Else
                        Account_No = ""
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

                    If Not row.IsNull("Tel") Then
                        Tel = row("Tel").ToString()
                    Else
                        Tel = ""
                    End If

                    If Not row.IsNull("Fax") Then
                        Fax = row("Fax").ToString()
                    Else
                        Fax = ""
                    End If

                    If Not row.IsNull("Remark") Then
                        Remark = row("Remark").ToString()
                    Else
                        Remark = ""
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

        Public Function SaveConsultant() As Boolean
            Dim dsConsultant As DataSet

            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO Consultant (Consultant_Name"
            SQLstr = SQLstr & ", Account_No, Address, Country, Tel"
            SQLstr = SQLstr & ", Fax, Remark"
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarConsultant_Name & "', '" & mvarAccount_No & "', "
            SQLstr = SQLstr & "'" & mvarAddress & "', '" & mvarCountry & "',"
            SQLstr = SQLstr & "'" & mvarTel & "', '" & mvarFax & "',"
            SQLstr = SQLstr & "'" & mvarRemark & "',"
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsConsultant, SQLstr) Then
                    Return True
                End If
            End With
            dsConsultant.Dispose()
        End Function

        Public Function UpdateConsultant(ByVal pConsultant_ID As String) As Boolean
            Dim dsConsultant As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Consultant SET "
            SQLStr = SQLStr & " Consultant_Name = '" & mvarConsultant_Name & "',"
            SQLStr = SQLStr & " Account_No = '" & mvarAccount_No & "',"
            SQLStr = SQLStr & " Address = '" & mvarAddress & "',"
            SQLStr = SQLStr & " Country = '" & mvarCountry & "',"
            SQLStr = SQLStr & " Tel = '" & mvarTel & "',"
            SQLStr = SQLStr & " Fax = '" & mvarFax & "',"
            SQLStr = SQLStr & " Remark = '" & mvarRemark & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " Consultant_ID = " & pConsultant_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsConsultant, SQLStr) Then
                    Return True
                End If
            End With
            dsConsultant.Dispose()
        End Function

#Region " DELETE Consultant "
        Public Function DeleteConsultant(ByVal pConsultant_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM Consultant WHERE Consultant_ID = " & pConsultant_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pConsultant_Name As String, Optional ByVal pConsultant_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT Consultant_ID FROM Consultant"
            SQLStr = SQLStr & " WHERE Consultant_Name='" & pConsultant_Name & "'"

            If pConsultant_ID <> Nothing And pConsultant_ID <> 0 Then
                SQLStr = SQLStr & " AND Consultant_ID<>" & pConsultant_ID
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

        Public Property Consultant_ID() As Integer
            Get
                Return mvarConsultant_ID
            End Get
            Set(ByVal Value As Integer)
                mvarConsultant_ID = Value
            End Set
        End Property

        Public Property Consultant_Name() As String
            Get
                Return mvarConsultant_Name
            End Get
            Set(ByVal Value As String)
                mvarConsultant_Name = Value
            End Set
        End Property

        Public Property Account_No() As String
            Get
                Return mvarAccount_No
            End Get
            Set(ByVal Value As String)
                mvarAccount_No = Value
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

        Public Property Tel() As String
            Get
                Return mvarTel
            End Get
            Set(ByVal Value As String)
                mvarTel = Value
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

        Public Property Remark() As String
            Get
                Return mvarRemark
            End Get
            Set(ByVal Value As String)
                mvarRemark = Value
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

#Region " Consultant Report "

        Public Function GetConsultantReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SELECT * FROM Consultant" '(select column)
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region
    End Class

End Namespace
