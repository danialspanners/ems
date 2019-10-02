Namespace SurveyOrderBusRules

    Public Class SurveyOrderBusLogic

#Region "Variables Initialization"
        ' Header
        Private mvarSO_ID As Integer
        Private mvarSO_No As String
        Private mvarPrevSO_ID As String
        Private mvarProject_ID As String
        Private mvarSO_Date As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String

        ' Line
        Private mvarSOLine_ID As Integer
        Private mvarLnSO_ID As Integer
        Private mvarItem_No As Integer
        Private mvarContract_ID As Integer
        Private mvarOGB_IO_ID As Integer
        Private mvarDescription As String
        Private mvarQty As Integer
        Private mvarExpected_Completion_Date As String
        Private mvarCompletion_Date As String
        Private mvarRemarks As String
        Private mvarLnCreate_Date As String
        Private mvarLnTransact_Date As String
        Private mvarLnUserID As Integer

#End Region

#Region "Survey Order Header"

        Public Function GetSOHeader(ByRef ds As DataSet, Optional ByVal pSO_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pSO_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM SurveyOrderHeader "
                SQLStr = SQLStr & "WHERE SO_ID =" & pSO_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM SurveyOrderHeader"
            End If

            SQLStr = SQLStr & " Order by SO_No"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetSurveyOrderHeader(ByRef ds As DataSet, ByVal pSO_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM SurveyOrderHeader "
            SQLStr = SQLStr & "WHERE SO_ID =" & pSO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM SurveyOrderHeader"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pSO_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM SurveyOrderHeader"

                If pSO_ID <> "" Then
                    SQLStr = SQLStr & " WHERE SO_ID =" & pSO_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("SO_No") Then
                        SO_No = row("SO_No").ToString()
                    Else
                        SO_No = ""
                    End If

                    ' 30.12.2003 YG Start
                    '                    If Not row.IsNull("PrevSO_ID") Then
                    '                        PrevSO_ID = Integer.Parse(row("PrevSO_ID").ToString())
                    '                    Else
                    '                        PrevSO_ID = ""
                    '                    End If

                    '                    If Not row.IsNull("Project_ID") Then
                    '                        Project_ID = Integer.Parse(row("Project_ID").ToString())
                    '                    Else
                    '                        Project_ID = ""
                    '                    End If

                    If Not row.IsNull("PrevSO") Then
                        PrevSO_ID = row("PrevSO").ToString()
                    Else
                        PrevSO_ID = ""
                    End If

                    If Not row.IsNull("Project") Then
                        Project_ID = row("Project").ToString()
                    Else
                        Project_ID = ""
                    End If
                    ' 30.12.2003 YG End

                    If Not row.IsNull("SO_Date") Then
                        SO_Date = row("SO_Date").ToString()
                    Else
                        SO_Date = ""
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

        Public Function SaveSurveyOrderHeader() As Boolean
            Dim dsSurveyOrderHeader As DataSet
            Dim SQLstr As String

            SQLstr = "SET DATEFORMAT dmy;INSERT INTO SurveyOrderHeader (SO_No"
            ' 30.12.2003 YG Start
            '            SQLstr = SQLstr & ", PrevSO_ID, Project_ID, SO_Date, Contract_ID"
            SQLstr = SQLstr & ", PrevSO, Project, SO_Date, Contract_ID"
            ' 30.12.2003 YG End
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            ' 30.12.2003 YG Start
            '            SQLstr = SQLstr & "('" & mvarSO_No & "','" & mvarPrevSO_ID & "', " & mvarProject_ID & ", '"
            SQLstr = SQLstr & "('" & mvarSO_No & "','" & mvarPrevSO_ID & "', '" & mvarProject_ID & "', '"
            ' 30.12.2003 YG End
            SQLstr = SQLstr & mvarSO_Date & "', " & mvarContract_ID & ", Getdate(), GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"
            SQLstr = SQLstr & ";SELECT @@identity as SO_ID FROM SurveyOrderHeader"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSurveyOrderHeader, SQLstr) Then
                    If dsSurveyOrderHeader.Tables(0).Rows.Count > 0 Then
                        mvarSO_ID = dsSurveyOrderHeader.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
            End With
            dsSurveyOrderHeader.Dispose()
        End Function

        Public Function UpdateSurveyOrderHeader(ByVal pSO_ID As String) As Boolean
            Dim dsSurveyOrderHeader As DataSet
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;UPDATE SurveyOrderHeader SET "
            SQLStr = SQLStr & " SO_No = '" & mvarSO_No & "',"
            ' 30.12.2003 YG Start
            '            SQLStr = SQLStr & " PrevSO_ID = " & mvarPrevSO_ID & ","
            '            SQLStr = SQLStr & " Project_ID = " & mvarProject_ID & ","
            SQLStr = SQLStr & " PrevSO = '" & mvarPrevSO_ID & "',"
            SQLStr = SQLStr & " Project = '" & mvarProject_ID & "',"
            ' 30.12.2003 YG End
            SQLStr = SQLStr & " SO_Date = '" & mvarSO_Date & "',"
            SQLStr = SQLStr & " Contract_ID = '" & mvarContract_ID & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " SO_ID = " & pSO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSurveyOrderHeader, SQLStr) Then
                    Return True
                End If
            End With
            dsSurveyOrderHeader.Dispose()
        End Function

        Public Function CheckExistingSONo() As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT SO_NO FROM SuveyOrderHeader "
            SQLstr = SQLstr & " WHERE SO_NO = '" & mvarSO_No & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True            'return false if SO exist
                    Else
                        Return False
                    End If
                End If
            End With
        End Function

        'Initial saving. To get the SO_ID
        Public Function SaveSONo() As Boolean
            Dim dsSO As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO SurveyOrderHeader "
                SQLstr = SQLstr & "(SO_No, Create_Date,Transact_Date,UserID) "
                SQLstr = SQLstr & " VALUES ('" & mvarSO_No & "',"
                SQLstr = SQLstr & " Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as SO_ID FROM SurveyOrderHeader"

                If .GetDataSet(dsSO, SQLstr) Then
                    If dsSO.Tables(0).Rows.Count > 0 Then
                        mvarSO_ID = dsSO.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                dsSO.Dispose()
            End With
        End Function
#End Region

#Region "Survey Order Line"
        Public Function GetSOLine_ByLineID(ByRef ds As DataSet, ByVal pSO_Line_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM SurveyOrderLine "
            SQLStr = SQLStr & "WHERE SOLine_ID =" & pSO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetSOLine(ByRef ds As DataSet, Optional ByVal pSO_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pSO_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM SurveyOrderLine "
                SQLStr = SQLStr & "WHERE SO_ID =" & pSO_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM SurveyOrderLine"
            End If

            SQLStr = SQLStr & " Order by SOLine_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetSOLine_Display(ByRef ds As DataSet, Optional ByVal pSO_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pSO_ID) > 0 Then
                SQLStr = "SELECT OGBFiler.IO_No as IO_No, SOLine.* "
                SQLStr = SQLStr & " FROM SurveyOrderLine SOLine, OGBFiler "
                SQLStr = SQLStr & "WHERE SOLine.OGB_IO_ID = OGBFiler.OGB_IO_ID and "
                SQLStr = SQLStr & " SOLine.SO_ID = " & pSO_ID
            Else
                SQLStr = "SELECT OGBFiler.IO_No as IO_No, SOLine.* "
                SQLStr = SQLStr & " FROM SurveyOrderLine SOLine, OGBContract, OGBFiler "
                SQLStr = SQLStr & "WHERE SOLine.OGB_IO_ID = OGBFiler.OGB_IO_ID "
            End If

            SQLStr = SQLStr & " Order by SOLine.SOLine_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveSOLineFirstTime() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO SurveyOrderLine "
            SQLStr = SQLStr & "(SO_ID, Create_Date, Transact_Date, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarSO_ID & ","
            SQLStr = SQLStr & " GetDate(),GetDate()," & mvarUserID & ")"
            SQLStr = SQLStr & ";SELECT @@identity as SOLine_ID FROM SurveyOrderLine"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarSOLine_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveSOLine() As Boolean
            Dim ds As DataSet
            GetNextItemNo()

            Dim SQLStr As String = "SET DATEFORMAT dmy;INSERT INTO SurveyOrderLine "
            SQLStr = SQLStr & "(SO_ID, Item_No, "
            SQLStr = SQLStr & "OGB_IO_ID, "
            SQLStr = SQLStr & "Qty, Expected_Complete_Date, "
            If mvarCompletion_Date <> Nothing Then
                SQLStr = SQLStr & "Completion_Date, "
            End If
            SQLStr = SQLStr & "Description, "
            SQLStr = SQLStr & "Remarks, "
            SQLStr = SQLStr & "Create_Date, Transact_Date, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarSO_ID & ", " & mvarItem_No + 1 & ", "
            SQLStr = SQLStr & mvarOGB_IO_ID & ", "
            SQLStr = SQLStr & mvarQty & ", '"
            SQLStr = SQLStr & mvarExpected_Completion_Date & "', '"
            If mvarCompletion_Date <> Nothing Then
                SQLStr = SQLStr & mvarCompletion_Date & "', '"
            End If
            SQLStr = SQLStr & mvarDescription & "', '"
            SQLStr = SQLStr & mvarRemarks & "', "
            SQLStr = SQLStr & " GetDate(),GetDate(), '" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    SQLStr = "Update OGBFiler set SO_Created = '1',"
                    SQLStr = SQLStr & " Transact_Date = GetDate() ,"
                    SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
                    SQLStr = SQLStr & " where OGB_IO_ID = " & mvarOGB_IO_ID
                    With New DataAccess.DAccess.Access
                        If .GetDataSet(ds, SQLStr) Then
                            Return True
                        End If
                    End With
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateSOLine(ByVal pSO_Line_ID As String)
            Dim ds As DataSet


            Dim SQLStr As String = "SET DATEFORMAT dmy;Update SurveyOrderLine SET "
            SQLStr = SQLStr & " SO_ID = " & mvarSO_ID & ","
            SQLStr = SQLStr & " OGB_IO_ID = " & mvarOGB_IO_ID & ","
            SQLStr = SQLStr & " Qty = " & mvarQty & ","
            SQLStr = SQLStr & " Expected_Complete_Date = '" & mvarExpected_Completion_Date & "',"
            If Len(mvarCompletion_Date) > 0 Then
                SQLStr = SQLStr & " Completion_Date = '" & mvarCompletion_Date & "',"
            Else
                SQLStr = SQLStr & " Completion_Date = NULL,"
            End If
            SQLStr = SQLStr & " Description = '" & mvarDescription & "',"
            SQLStr = SQLStr & " Remarks = '" & mvarRemarks & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
            SQLStr = SQLStr & " WHERE SOLine_ID = " & pSO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetNextItemNo() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SET DATEFORMAT dmy;SELECT Max(Item_No) as Item_No FROM SurveyOrderLine "
            SQLStr = SQLStr & " WHERE SO_ID = " & mvarSO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Item_No")) Then
                            mvarItem_No = Integer.Parse(ds.Tables(0).Rows(0)("Item_No"))
                        Else
                            mvarItem_No = 0
                        End If
                    Else
                        mvarItem_No = 0
                    End If
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

#End Region

#Region " DELETE Survey Order "
        Public Function DeleteSurveyOrder(ByVal pSO_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM SurveyOrderHeader WHERE SO_ID = " & pSO_ID

                If .GetDataSet(ds, SQLStr) Then
                    SQLStr = "DELETE FROM SurveyOrderLine WHERE SO_ID = " & pSO_ID
                    If .GetDataSet(ds, SQLStr) Then
                        Return True
                    End If
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " DELETE Survey Order Line"
        Public Function DeleteSurveyOrderLine(ByVal pSO_Line_ID As String, ByVal pOGB_IO_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM SurveyOrderLine WHERE SOLine_ID = " & pSO_Line_ID

                If .GetDataSet(ds, SQLStr) Then
                    SQLStr = "Update OGBFiler set SO_Created = '0',"
                    SQLStr = SQLStr & " Transact_Date = GetDate() ,"
                    SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
                    SQLStr = SQLStr & " where OGB_IO_ID = " & pOGB_IO_ID
                    With New DataAccess.DAccess.Access
                        If .GetDataSet(ds, SQLStr) Then
                            Return True
                        End If
                    End With
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pSO_No As String, Optional ByVal pSO_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT SO_ID FROM SurveyOrderHeader"
            SQLStr = SQLStr & " WHERE SO_No='" & pSO_No & "'"

            If pSO_ID <> Nothing And pSO_ID <> 0 Then
                SQLStr = SQLStr & " AND SO_ID<>" & pSO_ID
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

#Region "Get and Let Property for Header"

        Public Property SO_ID() As Integer
            Get
                Return mvarSO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSO_ID = Value
            End Set
        End Property

        Public Property SO_No() As String
            Get
                Return mvarSO_No
            End Get
            Set(ByVal Value As String)
                mvarSO_No = Value
            End Set
        End Property

        Public Property PrevSO_ID() As String
            Get
                Return mvarPrevSO_ID
            End Get
            Set(ByVal Value As String)
                mvarPrevSO_ID = Value
            End Set
        End Property

        Public Property Project_ID() As String
            Get
                Return mvarProject_ID
            End Get
            Set(ByVal Value As String)
                mvarProject_ID = Value
            End Set
        End Property

        Public Property SO_Date() As String
            Get
                Return mvarSO_Date
            End Get
            Set(ByVal Value As String)
                mvarSO_Date = Value
            End Set
        End Property

        Public Property Contract_ID() As Integer
            Get
                Return mvarContract_ID
            End Get
            Set(ByVal Value As Integer)
                mvarContract_ID = Value
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

#Region "Get and Let Property for Line"
        Public Property SOLine_ID() As Integer
            Get
                Return SOLine_ID
            End Get
            Set(ByVal Value As Integer)
                SOLine_ID = Value
            End Set
        End Property

        Public Property LnSO_ID() As Integer
            Get
                Return mvarLnSO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnSO_ID = Value
            End Set
        End Property

        Public Property Item_No() As Integer
            Get
                Return mvarItem_No
            End Get
            Set(ByVal Value As Integer)
                mvarItem_No = Value
            End Set
        End Property

        Public Property OGB_IO_ID() As Integer
            Get
                Return mvarOGB_IO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_IO_ID = Value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return mvarDescription
            End Get
            Set(ByVal Value As String)
                mvarDescription = Value
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

        Public Property Qty() As Integer
            Get
                Return mvarQty
            End Get
            Set(ByVal Value As Integer)
                mvarQty = Value
            End Set
        End Property

        Public Property Expected_Completion_Date() As String
            Get
                Return mvarExpected_Completion_Date
            End Get
            Set(ByVal Value As String)
                mvarExpected_Completion_Date = Value
            End Set
        End Property

        Public Property Completion_Date() As String
            Get
                Return mvarCompletion_Date
            End Get
            Set(ByVal Value As String)
                mvarCompletion_Date = Value
            End Set
        End Property

        Public Property LnCreate_Date() As String
            Get
                Return mvarLnCreate_Date
            End Get
            Set(ByVal Value As String)
                mvarLnCreate_Date = Value
            End Set
        End Property

        Public Property LnTransact_Date() As String
            Get
                Return mvarLnTransact_Date
            End Get
            Set(ByVal Value As String)
                mvarLnTransact_Date = Value
            End Set
        End Property

        Public Property LnUserID() As Integer
            Get
                Return mvarLnUserID
            End Get
            Set(ByVal Value As Integer)
                mvarLnUserID = Value
            End Set
        End Property

#End Region

#Region " Survey Order Report "
        Public Function GetSurveyOrderRpt(ByRef ds As DataSet, ByVal pSO_ID As String)
            Dim SQLStr As String

            ' 30.12.2003 YG Start
            '            SQLStr = SQLStr & "select  soh1.*, soh2.SO_No as PrevSO_No, sol.*, o.IO_No, o.OGB_Location "
            '            SQLStr = SQLStr & "FROM SurveyOrderHeader soh1 "
            '            SQLStr = SQLStr & "left join SurveyOrderHeader soh2 on (soh1.PrevSO_ID = soh2.SO_ID) "
            '            SQLStr = SQLStr & "left join SurveyOrderLine sol on (soh1.SO_ID = sol.SO_ID) "
            '            SQLStr = SQLStr & "left join OGBFiler o on (sol.OGB_IO_ID = o.OGB_IO_ID) "
            '            SQLStr = SQLStr & "where soh1.SO_ID = " & pSO_ID

            SQLStr = SQLStr & "select  soh.*, soh.PrevSO as PrevSO_No, sol.*, o.IO_No, o.OGB_Location "
            SQLStr = SQLStr & "FROM SurveyOrderHeader soh "
            '            SQLStr = SQLStr & "left join SurveyOrderHeader soh2 on (soh1.PrevSO_ID = soh2.SO_ID) "
            SQLStr = SQLStr & "left join SurveyOrderLine sol on (soh.SO_ID = sol.SO_ID) "
            SQLStr = SQLStr & "left join OGBFiler o on (sol.OGB_IO_ID = o.OGB_IO_ID) "
            SQLStr = SQLStr & "where soh.SO_ID = " & pSO_ID
            ' 30.12.2003 YG End

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

    End Class

End Namespace

