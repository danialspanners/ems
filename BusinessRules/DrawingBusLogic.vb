
Namespace DrawingBusRules

    Public Class DrawingBusLogic

#Region "Variables Initialization"

        Private mvarDrawing_ID As Integer
        Private mvarDrawing_No As String
        'Private mvarDrawing_Type As Integer
        Private mvarDrawing_Type As String
        Private mvarDrawn_By As Integer
        Private mvarIssue_To As Integer
        Private mvarIssue_Date As String
        Private mvarCustomer_ID As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

        Public Function GetDrawingHeader(ByRef ds As DataSet, Optional ByVal pDrawing_ID As String = "") As Boolean
            Dim SQLStr As String
            If Len(pDrawing_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Drawing "
                SQLStr = SQLStr & "WHERE Drawing_ID =" & pDrawing_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM Drawing"
            End If

            SQLStr = SQLStr & " Order by Drawing_No"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDrawing(ByRef ds As DataSet, Optional ByVal pDrawing_ID As String = "") As Boolean
            Dim SQLStr As String

            'insert by alan
            If Len(pDrawing_ID) > 0 Then
                '##
                SQLStr = "SET DATEFORMAT dmy;SELECT DRW.*, CUST.Name AS Customer, USP.Name AS DrawnBy, USP2.Name AS IssueTo"
                SQLStr = SQLStr & " FROM DrawingNo DRW, Customer CUST, UserProfile USP, UserProfile USP2"
                SQLStr = SQLStr & " WHERE Drawing_ID =" & pDrawing_ID
                SQLStr = SQLStr & " AND USP.User_ID = DRW.Drawn_By AND USP2.User_ID = DRW.Issue_To"
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT DRW.*, CUST.Name AS Customer, USP.Login_ID AS DrawnBy, USP2.Login_ID AS IssueTo"
                SQLStr = SQLStr & " FROM DrawingNo DRW, Customer CUST, UserProfile USP, UserProfile USP2"
                SQLStr = SQLStr & " WHERE CUST.Customer_ID = DRW.Customer_ID"
                SQLStr = SQLStr & " AND USP.User_ID = DRW.Drawn_By"
                SQLStr = SQLStr & " AND USP2.User_ID = DRW.Issue_To"
            End If

            SQLStr = SQLStr & " Order by Drawing_No"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetUserProfile(ByRef ds As DataSet, Optional ByVal pUser_ID As String = "0") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If pUser_ID = "0" Then
                    SQLStr = "SELECT * FROM UserProfile"
                Else
                    SQLStr = "SELECT * FROM UserProfile where User_ID = " & Integer.Parse(pUser_ID)
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM DrawingNo"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pDrawing_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM DrawingNo"

                If pDrawing_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Drawing_ID =" & pDrawing_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Drawing_No") Then
                        Drawing_No = row("Drawing_No").ToString()
                    Else
                        Drawing_No = ""
                    End If

                    If Not row.IsNull("Drawing_Type") Then
                        Drawing_Type = row("Drawing_Type").ToString()
                    Else
                        Drawing_Type = Nothing
                    End If

                    If Not row.IsNull("Drawn_By") Then
                        Drawn_By = Integer.Parse(row("Drawn_By").ToString())
                    Else
                        Drawn_By = Nothing
                    End If

                    If Not row.IsNull("Issue_To") Then
                        Issue_To = Integer.Parse(row("Issue_To").ToString())
                    Else
                        Issue_To = Nothing
                    End If

                    If Not row.IsNull("Issue_Date") Then
                        Issue_Date = row("Issue_Date").ToString()
                    Else
                        Issue_Date = Nothing
                    End If

                    If Not row.IsNull("Customer") Then
                        Customer_ID = Integer.Parse(row("Customer").ToString())
                    Else
                        Customer_ID = Nothing
                    End If

                    Return True
                End If
            End With
        End Function

        Public Function SaveDrawing() As Boolean
            Dim dsDrawing As DataSet
            'Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO Drawing (Drawing_No"
            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO DrawingNo (Drawing_No"
            SQLstr = SQLstr & ", Drawing_Type, Drawn_By, Issue_To, Issue_Date, Customer_ID"
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarDrawing_No & "', '" & mvarDrawing_Type & "',"
            'SQLstr = SQLstr & "'" & mvarDrawn_By & "', '" & mvarIssue_To & "',"
            SQLstr = SQLstr & "" & mvarDrawn_By & ", " & mvarIssue_To & ","
            'SQLstr = SQLstr & "'" & mvarIssue_Date & "', '" & mvarCustomer_ID & "',"
            SQLstr = SQLstr & "'" & mvarIssue_Date & "', " & mvarCustomer_ID & ","
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsDrawing, SQLstr) Then
                    Return True
                End If
            End With
            dsDrawing.Dispose()
        End Function

        Public Function UpdateDrawing(ByVal pDrawing_ID As String) As Boolean
            Dim dsDrawing As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Drawing SET "
            SQLStr = SQLStr & " Drawing_No = '" & mvarDrawing_No & "',"
            SQLStr = SQLStr & " Drawing_Type = '" & mvarDrawing_Type & "',"
            'SQLStr = SQLStr & " Drawn_By = '" & mvarDrawn_By & "',"
            SQLStr = SQLStr & " Drawn_By = " & mvarDrawn_By & ","
            'SQLStr = SQLStr & " Issue_To = '" & mvarIssue_To & "',"
            SQLStr = SQLStr & " Issue_To = " & mvarIssue_To & ","
            SQLStr = SQLStr & " Issue_Date = '" & mvarIssue_Date & "',"
            'SQLStr = SQLStr & " Customer_ID = '" & mvarCustomer_ID & "',"
            SQLStr = SQLStr & " Customer_ID = " & mvarCustomer_ID & ","
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = " & mvarUserID & " WHERE "
            SQLStr = SQLStr & " Drawing_ID = " & pDrawing_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsDrawing, SQLStr) Then
                    Return True
                End If
            End With
            dsDrawing.Dispose()
        End Function

#Region " DELETE Drawing "
        Public Function DeleteDrawing(ByVal pDrawing_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                'Dim SQLStr As String = "DELETE FROM Drawing WHERE Drawing_ID = " & pDrawing_ID
                Dim SQLStr As String = "DELETE FROM DrawingNo WHERE Drawing_ID = " & pDrawing_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pDrawing_No As String, Optional ByVal pDrawing_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            'SQLStr = "SELECT Drawing_ID FROM Drawing"
            SQLStr = "SELECT Drawing_ID FROM DrawingNo"
            SQLStr = SQLStr & " WHERE Drawing_No='" & pDrawing_No & "'"

            'If pDrawing_ID <> Nothing And pDrawing_ID <> 0 Then
            'SQLStr = SQLStr & " AND Drawing_ID<>" & pDrawing_ID
            'End If
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
#End Region

#Region "Get and Let Property"

        Public Property Drawing_ID() As Integer
            Get
                Return mvarDrawing_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDrawing_ID = Value
            End Set
        End Property

        Public Property Drawing_No() As String
            Get
                Return mvarDrawing_No
            End Get
            Set(ByVal Value As String)
                mvarDrawing_No = Value
            End Set
        End Property

        Public Property Drawing_Type() As String
            Get
                Return mvarDrawing_Type
            End Get
            Set(ByVal Value As String)
                mvarDrawing_Type = Value
            End Set
        End Property
        Public Property Drawn_By() As Integer
            Get
                Return mvarDrawn_By
            End Get
            Set(ByVal Value As Integer)
                mvarDrawn_By = Value
            End Set
        End Property
        Public Property Issue_To() As Integer
            Get
                Return mvarIssue_To
            End Get
            Set(ByVal Value As Integer)
                mvarIssue_To = Value
            End Set
        End Property
        Public Property Issue_Date() As String
            Get
                Return mvarIssue_Date
            End Get
            Set(ByVal Value As String)
                mvarIssue_Date = Value
            End Set
        End Property
        Public Property Customer_ID() As Integer
            Get
                Return mvarCustomer_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCustomer_ID = Value
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

#Region " Drawing No Report "

        Public Function GetDrawingNoReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "Select d.*, a.Name as User_Name, b.Name as Issue_Name, Customer.Initial from DrawingNo d, UserProfile a, UserProfile b, Customer "
            SQLStr = SQLStr & " where d.Drawn_By = a.User_ID and "
            SQLStr = SQLStr & " d.Issue_To = b.User_ID and "
            SQLStr = SQLStr & " d.Customer_ID = Customer.Customer_ID "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region
    End Class

End Namespace
