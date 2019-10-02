' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer
Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace PRBusRules

#Region " PRHeader"

    Public Class PRHeaderBusLogic

#Region " Variables Initialization "

        Private mvarPR_ID As Integer
        Private mvarPR_No As String
        Private mvarRequester As Integer
        Private mvarApprover As Integer
        Private mvarPRApprover As Integer
        Private mvarQuotation_ID As Integer
        Private mvarCategory As String
        Private mvarStatus As String
        Private mvarGrp As String
        Private mvarSubmit_Date As String
        Private mvarApprove_Date As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer
        Private mvarRefno As String
        Private mvarRefType As String
        Private mvarRemarks As String

        Public Const PENDING_STATUS = "30"
        Public Const APPROVED_STATUS = "40"
#End Region

#Region "Code"

        Public Function Save() As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO PRHeader("
            strSQL = strSQL & "PR_No, Requester, Approver, PRApprover "
            strSQL = strSQL & ",Quotation_ID, Category, Status, Grp, Submit_Date, Approve_Date "
            strSQL = strSQL & ",Create_Date, Transact_Date "
            strSQL = strSQL & ",refno,reftype,remarks, UserID"
            strSQL = strSQL & ") VALUES("

            If Len(mvarPR_No) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarPR_No, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRequester) > 0 Then
                strSQL = strSQL & mvarRequester & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarApprover) > 0 Then
                strSQL = strSQL & mvarApprover & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPRApprover) > 0 Then
                strSQL = strSQL & mvarPRApprover & ","
            Else
                strSQL = strSQL & " NULL,"
            End If


            If Len(mvarQuotation_ID) > 0 Then
                strSQL = strSQL & mvarQuotation_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarCategory) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarCategory, "'", "''") & "',"
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

            If Len(mvarSubmit_Date) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarSubmit_Date, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarApprove_Date) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarApprove_Date, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            strSQL = strSQL & " GetDate(),"

            strSQL = strSQL & " GetDate(),"

            If Len(mvarRefno) > 0 Then
                strSQL = strSQL & "'" & mvarRefno & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRefType) > 0 Then
                strSQL = strSQL & "'" & mvarRefType & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRemarks) > 0 Then
                strSQL = strSQL & "'" & mvarRemarks & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If
            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & mvarUserID
            Else
                strSQL = strSQL & " NULL"
            End If

            strSQL = strSQL & ")"

            strSQL = strSQL & "(SELECT @@IDENTITY AS PR_ID from PRHeader)"

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

        Public Function CheckExist(ByVal DocNo As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT *"
                SQLStr = SQLStr & " FROM PRHeader Where PR_NO='" & DocNo & "'"

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count = 0 Then
                        Return False
                    End If

                End If

            End With

            Return True
        End Function

        Public Sub Delete(ByVal pPR_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM PRHeader"
            strSQL = strSQL & " WHERE PR_ID=" & pPR_ID

            strSQL = strSQL & ";DELETE FROM PRLine"
            strSQL = strSQL & " WHERE PR_ID=" & pPR_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub DeleteAll(ByVal pQuotation_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM PRHeader"
            strSQL = strSQL & " WHERE Quotation_ID=" & pQuotation_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pPR_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PRHeader set "

            If Len(mvarPR_No) > 0 Then
                strSQL = strSQL & " PR_No='" & Replace(mvarPR_No, "'", "''") & "',"
            Else
                strSQL = strSQL & " PR_No=NULL,"
            End If

            If Len(mvarRequester) > 0 Then
                strSQL = strSQL & " Requester=" & mvarRequester & ","
            Else
                strSQL = strSQL & " Requester=NULL,"
            End If

            If Len(mvarApprover) > 0 Then
                strSQL = strSQL & " Approver=" & mvarApprover & ","
            Else
                strSQL = strSQL & " Approver=NULL,"
            End If

            If Len(mvarPRApprover) > 0 Then
                strSQL = strSQL & " PRApprover=" & mvarPRApprover & ","
            Else
                strSQL = strSQL & " PRApprover=NULL,"
            End If

            If Len(mvarQuotation_ID) > 0 Then
                strSQL = strSQL & " Quotation_ID=" & mvarQuotation_ID & ","
            Else
                strSQL = strSQL & " Quotation_ID=NULL,"
            End If

            If Len(mvarCategory) > 0 Then
                strSQL = strSQL & " Category='" & mvarCategory & "',"
            Else
                strSQL = strSQL & " Category=NULL,"
            End If

            If Len(mvarStatus) > 0 Then
                strSQL = strSQL & " Status='" & mvarStatus & "',"
            Else
                strSQL = strSQL & " Status=NULL,"
            End If

            If Len(mvarGrp) > 0 Then
                strSQL = strSQL & " Grp='" & mvarGrp & "',"
            Else
                strSQL = strSQL & " Grp=NULL,"
            End If

            If Len(mvarSubmit_Date) > 0 Then
                strSQL = strSQL & " Submit_Date='" & mvarSubmit_Date & "',"
            Else
                strSQL = strSQL & " Submit_Date=NULL,"
            End If

            If Len(mvarApprove_Date) > 0 Then
                strSQL = strSQL & " Approve_Date='" & mvarApprove_Date & "',"
            Else
                strSQL = strSQL & " Approve_Date=NULL,"
            End If

            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarRefno) > 0 Then
                strSQL = strSQL & " Refno='" & mvarRefno & "',"
            Else
                strSQL = strSQL & " Refno=NULL,"
            End If

            If Len(mvarRefType) > 0 Then
                strSQL = strSQL & " RefType='" & mvarRefType & "',"
            Else
                strSQL = strSQL & " RefType=NULL,"
            End If

            If Len(mvarRemarks) > 0 Then
                strSQL = strSQL & " Remarks='" & mvarRemarks & "',"
            Else
                strSQL = strSQL & " Remarks=NULL,"
            End If

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID
            Else
                strSQL = strSQL & " UserID=NULL"
            End If

            strSQL = strSQL & " WHERE PR_ID = " & pPR_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Function LoadList(ByRef ds As DataSet, Optional ByVal pPRGrp As String = "", Optional ByVal pFilter As String = "", Optional ByVal pQuotation_ID As String = "", Optional ByVal pStatus As String = "", Optional ByVal pEmptyQuotation As Boolean = False) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT PR_ID,PR_NO,PR.*"

                SQLStr = SQLStr & " , User1.Name As RequesterName, User2.Name As ApproverName, User3.Name as PRApproverName "

                SQLStr = SQLStr & " , CategoryName = CASE PR.Category"
                SQLStr = SQLStr & "         WHEN '0' THEN 'Samples'"
                SQLStr = SQLStr & "         WHEN '1' THEN 'Admin Use'"
                SQLStr = SQLStr & "         WHEN '2' THEN 'Factory Use'"
                SQLStr = SQLStr & "         WHEN '3' THEN 'Store Use'"
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , StatusName = CASE PR.Status"
                SQLStr = SQLStr & "         WHEN '10' THEN 'Preparing'"
                SQLStr = SQLStr & "         WHEN '20' THEN 'Revised'"
                SQLStr = SQLStr & "         WHEN '30' THEN 'Pending'"
                SQLStr = SQLStr & "         WHEN '40' THEN 'Confirmed'"
                SQLStr = SQLStr & "  END"


                'SQLStr = SQLStr & " , GrpName = UGrp.Name" 'CASE PH.Grp"

                'SQLStr = SQLStr & " , GrpName = CASE PR.Grp"
                'SQLStr = SQLStr & "         WHEN '0' THEN 'Admin'"
                'SQLStr = SQLStr & "         WHEN '1' THEN 'Sales'"
                'SQLStr = SQLStr & "         WHEN '2' THEN 'Factory'"
                'SQLStr = SQLStr & "         WHEN '3' THEN 'Store'"
                'SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " FROM PRHeader PR "
                SQLStr = SQLStr & " LEFT JOIN QuotationHeader QU "
                SQLStr = SQLStr & " ON (PR.Quotation_ID = QU.Quotation_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile User1 "
                SQLStr = SQLStr & " ON (PR.Requester = User1.User_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile User2 "
                SQLStr = SQLStr & " ON (PR.Approver = User2.User_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile User3 "
                SQLStr = SQLStr & " ON (PR.PRApprover = User3.User_ID) "

                'SQLStr = SQLStr & " LEFT JOIN Department UGrp "
                'SQLStr = SQLStr & " ON (UGrp.Department_ID = PR.Grp) "
                SQLStr = SQLStr & " where 1=1"

                If pFilter <> "" Then
                    SQLStr = SQLStr & " AND " & pFilter
                End If

                If pPRGrp <> "" Then
                    SQLStr = SQLStr & " AND PR.GRP ='" & pPRGrp & "'"

                    If pQuotation_ID <> "" Then
                        SQLStr = SQLStr & " AND PR.Quotation_ID =" & pQuotation_ID
                    End If

                    If pStatus <> "" Then
                        SQLStr = SQLStr & " AND PR.Status ='" & pStatus & "'"
                    End If

                    If pEmptyQuotation = True Then
                        SQLStr = SQLStr & " AND (PR.Quotation_ID =0 OR PR.Quotation_ID IS NULL)"
                    End If
                Else
                    If pQuotation_ID <> "" Then
                        SQLStr = SQLStr & " AND PR.Quotation_ID =" & pQuotation_ID

                        If pStatus <> "" Then
                            SQLStr = SQLStr & " AND PR.Status ='" & pStatus & "'"
                        End If


                        If pEmptyQuotation = True Then
                            SQLStr = SQLStr & " AND (PR.Quotation_ID =0 OR PR.Quotation_ID IS NULL)"
                        End If
                    Else
                        If pStatus <> "" Then
                            SQLStr = SQLStr & " AND PR.Status ='" & pStatus & "'"


                            If pEmptyQuotation = True Then
                                SQLStr = SQLStr & " AND (PR.Quotation_ID =0 OR PR.Quotation_ID IS NULL)"
                            End If
                        Else

                            If pEmptyQuotation = True Then
                                SQLStr = SQLStr & " AND (PR.Quotation_ID =0 OR PR.Quotation_ID IS NULL)"
                            End If
                        End If
                    End If
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(Optional ByVal pPR_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM PRHeader"

                If pPR_ID <> "" Then
                    SQLStr = SQLStr & " WHERE PR_ID =" & pPR_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        Return False
                    End If
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("PR_No") Then
                        PR_No = row("PR_No").ToString()
                    Else
                        PR_No = ""
                    End If

                    If Not row.IsNull("Requester") Then
                        Requester = Integer.Parse(row("Requester").ToString())
                    Else
                        Requester = Nothing
                    End If

                    If Not row.IsNull("Approver") Then
                        Approver = Integer.Parse(row("Approver").ToString())
                    Else
                        Approver = Nothing
                    End If

                    If Not row.IsNull("PRApprover") Then
                        PRApprover = Integer.Parse(row("PRApprover").ToString())
                    Else
                        PRApprover = Nothing
                    End If

                    If Not row.IsNull("Quotation_ID") Then
                        Quotation_ID = Integer.Parse(row("Quotation_ID").ToString())
                    Else
                        Quotation_ID = Nothing
                    End If

                    If Not row.IsNull("Category") Then
                        Category = row("Category").ToString()
                    Else
                        Category = ""
                    End If

                    If Not row.IsNull("Status") Then
                        Status = row("Status").ToString()
                    Else
                        Status = ""
                    End If

                    If Not row.IsNull("Grp") Then
                        Grp = row("Grp").ToString()
                    Else
                        Grp = Nothing
                    End If

                    If Not row.IsNull("Submit_Date") Then
                        Submit_Date = row("Submit_Date").ToString()
                    Else
                        Submit_Date = ""
                    End If

                    If Not row.IsNull("Approve_Date") Then
                        Approve_Date = row("Approve_Date").ToString()
                    Else
                        Approve_Date = ""
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

                    If Not row.IsNull("Refno") Then
                        Me.Refno = row("Refno").ToString()
                    Else
                        Me.Refno = ""
                    End If

                    If Not row.IsNull("RefType") Then
                        Me.RefType = row("RefType").ToString()
                    Else
                        Me.RefType = ""
                    End If

                    If Not row.IsNull("Remarks") Then
                        Me.Remarks = row("Remarks").ToString()
                    Else
                        Me.Remarks = ""
                    End If

                    Return True
                End If
            End With
        End Function

        Public Sub SendPRForApproval(ByVal pPR_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PRHeader set "
            strSQL = strSQL & " Status='" & PENDING_STATUS & "',"

            strSQL = strSQL & " Transact_Date=GetDate(), "
            strSQL = strSQL & " Submit_Date=GetDate()"

            strSQL = strSQL & " WHERE PR_ID = " & pPR_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Sub ApprovePR(ByVal pPR_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PRHeader set "
            strSQL = strSQL & " Status='" & APPROVED_STATUS & "',"

            If Len(mvarApprover) > 0 Then
                strSQL = strSQL & " Approver=" & mvarApprover & ","
            Else
                strSQL = strSQL & " Approver=NULL,"
            End If

            strSQL = strSQL & " Transact_Date=GetDate(), "
            strSQL = strSQL & " Submit_Date=GetDate()"

            strSQL = strSQL & " WHERE PR_ID = " & pPR_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        'Check for unique PR No
        Public Function RecordExists(ByVal pPR_No As String, Optional ByVal pPR_ID As Integer = Nothing) As Boolean

            Dim SQLStr As String
            Dim ds As DataSet

            SQLStr = "SELECT * FROM PRHeader"
            SQLStr = SQLStr & " WHERE PR_No='" & Replace(pPR_No, "'", "''") & "'"

            If pPR_ID <> Nothing Then
                SQLStr = SQLStr & " AND PR_ID<>" & pPR_ID
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

        Public Function GetPRHeader(ByRef ds As DataSet, Optional ByVal pPR_ID As String = "", Optional ByVal pStatus As String = "") As Boolean
            Dim SQLStr As String
            If Len(pPR_ID) > 0 Then
                'SQLStr = "SELECT PR.*, US1.Name as Requester_Name, US2.Name as Approver_Name, QU.Confirm_Quotation_NO as Confirm_Quotation_No "
                'SQLStr = SQLStr & " FROM PRHeader PR, QuotationHeader QU, UserProfile US1, UserProfile US2 "
                'SQLStr = SQLStr & " WHERE PR.Quotation_ID = QU.Quotation_ID and "
                'SQLStr = SQLStr & " (QU.HistoryRecord <> '1' OR QU.HistoryRecord is null )"
                'SQLStr = SQLStr & " PR.Requester = US1.User_ID and "
                'SQLStr = SQLStr & " PR.Approver = US2.User_ID and "
                SQLStr = SQLStr & "SELECT PR.*, US1.Name AS Requester_Name, US2.Name AS Approver_Name, US3.Name as PRApprover_Name,QU.Confirm_Quotation_NO AS Confirm_Quotation_No "
                SQLStr = SQLStr & "FROM PRHeader PR LEFT OUTER JOIN "
                SQLStr = SQLStr & "QuotationHeader QU ON PR.Quotation_ID = QU.Quotation_ID LEFT OUTER JOIN "
                SQLStr = SQLStr & "UserProfile US1 ON PR.Requester = US1.User_ID LEFT OUTER JOIN "
                SQLStr = SQLStr & "UserProfile US2 ON PR.Approver = US2.User_ID "
                SQLStr = SQLStr & "UserProfile US3 ON PR.PRApprover = US3.User_ID "
                SQLStr = SQLStr & "WHERE (QU.HistoryRecord <> '1' OR QU.HistoryRecord IS NULL) AND "
                SQLStr = SQLStr & " PR.PR_ID = " & pPR_ID
                If Len(pStatus) > 0 Then
                    SQLStr = SQLStr & " AND PR.Status = '" & pStatus & "'"
                End If
                'SQLStr = SQLStr & " UNION "
                'SQLStr = SQLStr & " SELECT PR.*, US1.Name as Requester_Name, US2.Name as Approver_Name, 'NA' as Confirm_Quotation_No "
                'SQLStr = SQLStr & " FROM PRHeader PR, UserProfile US1, UserProfile US2 "
                'SQLStr = SQLStr & " WHERE PR.Quotation_ID = 0 and "
                'SQLStr = SQLStr & " PR.Requester = US1.User_ID and "
                'SQLStr = SQLStr & " PR.Approver = US2.User_ID and "
                'SQLStr = SQLStr & " PR.PR_ID = " & pPR_ID
            Else
                'SQLStr = "SELECT PR.*, US1.Name as Requester_Name, US2.Name as Approver_Name, QU.Confirm_Quotation_NO as Confirm_Quotation_No "
                'SQLStr = SQLStr & " FROM PRHeader PR, QuotationHeader QU, UserProfile US1, UserProfile US2 "
                'SQLStr = SQLStr & " WHERE PR.Quotation_ID = QU.Quotation_ID and "
                'SQLStr = SQLStr & " (QU.HistoryRecord <> '1' OR QU.HistoryRecord is null ) and "
                'SQLStr = SQLStr & " PR.Requester = US1.User_ID and "
                'SQLStr = SQLStr & " PR.Approver = US2.User_ID "

                SQLStr = SQLStr & "SELECT PR.*, US1.Name AS Requester_Name, US2.Name AS Approver_Name, US3.Name As PRApprover_Name, QU.Confirm_Quotation_NO AS Confirm_Quotation_No "
                SQLStr = SQLStr & "FROM PRHeader PR LEFT OUTER JOIN "
                SQLStr = SQLStr & "QuotationHeader QU ON PR.Quotation_ID = QU.Quotation_ID LEFT OUTER JOIN "
                SQLStr = SQLStr & "UserProfile US1 ON PR.Requester = US1.User_ID LEFT OUTER JOIN "
                SQLStr = SQLStr & "UserProfile US2 ON PR.Approver = US2.User_ID LEFT OUTER JOIN "
                SQLStr = SQLStr & "UserProfile US3 ON PR.PRApprover = US3.User_ID "
                SQLStr = SQLStr & "WHERE (QU.HistoryRecord <> '1' OR QU.HistoryRecord IS NULL) "
                If Len(pStatus) > 0 Then
                    SQLStr = SQLStr & " AND PR.Status = '" & pStatus & "'"
                End If

                'SQLStr = SQLStr & " UNION "
                'SQLStr = SQLStr & " SELECT PR.*, US1.Name as Requester_Name, US2.Name as Approver_Name, 'NA' as Confirm_Quotation_No "
                'SQLStr = SQLStr & " FROM PRHeader PR, UserProfile US1, UserProfile US2 "
                'SQLStr = SQLStr & " WHERE PR.Quotation_ID = 0 and "
                'SQLStr = SQLStr & " PR.Requester = US1.User_ID and "
                'SQLStr = SQLStr & " PR.Approver = US2.User_ID "
            End If

            If Len(pStatus) > 0 Then
                SQLStr = SQLStr & " AND PR.Status = '" & pStatus & "'"
            End If

            SQLStr = SQLStr & " Order by PR.Submit_Date Desc"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetPRHeaderPendingPurchase(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String

            SQLStr = SQLStr & "SELECT PR.*, US1.Name AS Requester_Name, US2.Name AS Approver_Name, US3.Name As PRApprover_Name, QU.Confirm_Quotation_NO AS Confirm_Quotation_No "
            SQLStr = SQLStr & "FROM PRHeader PR LEFT OUTER JOIN "
            SQLStr = SQLStr & "QuotationHeader QU ON PR.Quotation_ID = QU.Quotation_ID LEFT OUTER JOIN "
            SQLStr = SQLStr & "UserProfile US1 ON PR.Requester = US1.User_ID LEFT OUTER JOIN "
            SQLStr = SQLStr & "UserProfile US2 ON PR.Approver = US2.User_ID LEFT OUTER JOIN "
            SQLStr = SQLStr & "UserProfile US3 ON PR.PRApprover = US3.User_ID "
            SQLStr = SQLStr & "WHERE (QU.HistoryRecord <> '1' OR QU.HistoryRecord IS NULL) "

            SQLStr = SQLStr & " and PR.Status <> 10 "

            SQLStr = SQLStr & " and PR.PR_ID in "

            SQLStr = SQLStr & " ( "

            SQLStr = SQLStr & " SELECT PR_ID FROM PRLINE  "
            
                SQLStr = SQLStr & " WHERE (PO_ID =0 OR PO_ID IS NULL)"
                SQLStr = SQLStr & " AND (PO_Line_ID =0 OR PO_Line_ID IS NULL)"
            'SQLStr = SQLStr & " AND Order_Qty > 0"
            
            SQLStr = SQLStr & " ) "


            SQLStr = SQLStr & " Order by PR.Submit_Date Desc"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function UpdatePRHeaderStatus() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "UPDATE PRHeader SET "
            SQLStr = SQLStr & " Status = " & mvarStatus & " WHERE PR_ID = " & mvarPR_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

#End Region

#Region " Get and Let Property"

        Public Property PR_ID() As Integer
            Get
                Return mvarPR_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPR_ID = Value
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

        Public Property Requester() As Integer
            Get
                Return mvarRequester
            End Get
            Set(ByVal Value As Integer)
                mvarRequester = Value
            End Set
        End Property

        Public Property Approver() As Integer
            Get
                Return mvarApprover
            End Get
            Set(ByVal Value As Integer)
                mvarApprover = Value
            End Set
        End Property

        Public Property PRApprover() As Integer
            Get
                Return mvarPRApprover
            End Get
            Set(ByVal Value As Integer)
                mvarPRApprover = Value
            End Set
        End Property

        Public Property Quotation_ID() As Integer
            Get
                Return mvarQuotation_ID
            End Get
            Set(ByVal Value As Integer)
                mvarQuotation_ID = Value
            End Set
        End Property

        Public Property Category() As String
            Get
                Return mvarCategory
            End Get
            Set(ByVal Value As String)
                mvarCategory = Value
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

        Public Property Grp() As String
            Get
                Return mvarGrp
            End Get
            Set(ByVal Value As String)
                mvarGrp = Value
            End Set
        End Property

        Public Property Refno() As String
            Get
                Return mvarRefno
            End Get
            Set(ByVal Value As String)
                mvarRefno = Value
            End Set
        End Property

        Public Property RefType() As String
            Get
                Return mvarRefType
            End Get
            Set(ByVal Value As String)
                mvarRefType = Value
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

        Public Property Submit_Date() As String
            Get
                Return mvarSubmit_Date
            End Get
            Set(ByVal Value As String)
                mvarSubmit_Date = Value
            End Set
        End Property

        Public Property Approve_Date() As String
            Get
                Return mvarApprove_Date
            End Get
            Set(ByVal Value As String)
                mvarApprove_Date = Value
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

#Region " PRLine"

    Public Class PRLineBusLogic

#Region " Variables Initialization "

        Private mvarPR_Line As Integer
        Private mvarPR_ID As Integer
        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarRequest_Qty As Decimal
        Private mvarStock_Reserved As Decimal
        Private mvarOrder_Qty As Decimal
        Private mvarDelivery_Date As String
        Private mvarReserveDate As String
        Private mvarSupplier_ID As Integer
        Private mvarPO_ID As Integer
        Private mvarPO_Line_ID As Integer
        Private mvarEnquiry_Price As Decimal
        Private mvarActual_Price As Decimal
        Private mvarComponent_ID As Integer
        Private mvarActual_Supplier_ID As Integer
        Private mvarWO_No As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer
        Private mvarCurrency As Integer
        Private mvarActualPriceCurrency As Integer
        Private mvarCategory_Name As String
        Private mvarProduct_Name As String
        Private mvarSupplier_Name As String
#End Region

#Region "Code"

        Public Function Save() As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO PRLine("
            strSQL = strSQL & "PR_ID, Category_ID, Product_ID, Request_Qty "
            strSQL = strSQL & ",Stock_Reserved, Order_Qty, Delivery_Date, ReserveDate, Supplier_ID "
            strSQL = strSQL & ",PO_ID, PO_Line_ID, Currency,Enquiry_Price, ActualPriceCurrency,Actual_Price, Component_ID "
            strSQL = strSQL & ",Actual_Supplier_ID, WO_No "
            strSQL = strSQL & ",Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarPR_ID) > 0 Then
                strSQL = strSQL & mvarPR_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarCategory_ID) > 0 Then
                strSQL = strSQL & mvarCategory_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarProduct_ID) > 0 Then
                strSQL = strSQL & mvarProduct_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRequest_Qty) > 0 Then
                strSQL = strSQL & mvarRequest_Qty & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarStock_Reserved) > 0 Then
                strSQL = strSQL & mvarStock_Reserved & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarOrder_Qty) > 0 Then
                strSQL = strSQL & mvarOrder_Qty & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarDelivery_Date) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarDelivery_Date, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarReserveDate) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarReserveDate, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarSupplier_ID) > 0 Then
                strSQL = strSQL & mvarSupplier_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPO_ID) > 0 Then
                strSQL = strSQL & mvarPO_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If


            If Len(mvarPO_Line_ID) > 0 Then
                strSQL = strSQL & mvarPO_Line_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarCurrency) > 0 Then
                strSQL = strSQL & mvarCurrency & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarEnquiry_Price) > 0 Then
                strSQL = strSQL & mvarEnquiry_Price & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarActualPriceCurrency) > 0 Then
                strSQL = strSQL & mvarActualPriceCurrency & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarActual_Price) > 0 Then
                strSQL = strSQL & mvarActual_Price & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarComponent_ID) > 0 Then
                strSQL = strSQL & mvarComponent_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarActual_Supplier_ID) > 0 Then
                strSQL = strSQL & mvarActual_Supplier_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarWO_No) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarWO_No, "'", "''") & "',"
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

            strSQL = strSQL & "(SELECT @@IDENTITY AS PR_Line from PRLine)"

            Debug.WriteLine(strSQL)

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

        Public Sub Delete(ByVal pPR_Line As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM PRLine"
            strSQL = strSQL & " WHERE PR_Line=" & pPR_Line

            With New BusinessRules.ReservedStockRules.ReservedStockLogic
                .DeletePRLine(pPR_Line)
            End With

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub DeleteAll(ByVal pPR_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM PRLine"
            strSQL = strSQL & " WHERE PR_ID=" & pPR_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pPR_Line As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PRLine set "

            If mvarPR_ID <> 0 Then
                strSQL = strSQL & " PR_ID=" & mvarPR_ID & ","
            End If

            If mvarCategory_ID <> 0 Then
                strSQL = strSQL & " Category_ID=" & mvarCategory_ID & ","
            End If

            If mvarProduct_ID <> 0 Then
                strSQL = strSQL & " Product_ID=" & mvarProduct_ID & ","
            End If

            If Len(mvarRequest_Qty) > 0 Then
                strSQL = strSQL & " Request_Qty=" & mvarRequest_Qty & ","
            End If

            If Len(mvarStock_Reserved) > 0 Then
                strSQL = strSQL & " Stock_Reserved=" & mvarStock_Reserved & ","
            End If

            If Len(mvarOrder_Qty) > 0 Then
                strSQL = strSQL & " Order_Qty=" & mvarOrder_Qty & ","
            End If

            If Len(mvarDelivery_Date) > 0 Then
                strSQL = strSQL & " Delivery_Date='" & Replace(mvarDelivery_Date, "'", "''") & "',"
            End If

            If Len(mvarReserveDate) > 0 Then
                strSQL = strSQL & " ReserveDate='" & Replace(mvarReserveDate, "'", "''") & "',"
            End If


            If mvarSupplier_ID <> 0 Then
                strSQL = strSQL & " Supplier_ID=" & mvarSupplier_ID & ","
            End If

            If mvarPO_ID <> 0 Then
                strSQL = strSQL & " PO_ID=" & mvarPO_ID & ","
            End If

            If Len(mvarCurrency) <> 0 Then
                strSQL = strSQL & " Currency=" & mvarCurrency & ","
            End If

            If Len(mvarActualPriceCurrency) <> 0 Then
                strSQL = strSQL & " ActualPriceCurrency=" & mvarActualPriceCurrency & ","
            End If

            If mvarPO_Line_ID <> 0 Then
                strSQL = strSQL & " PO_Line_ID=" & mvarPO_Line_ID & ","
            End If

            If Len(mvarEnquiry_Price) > 0 Then
                strSQL = strSQL & " Enquiry_Price=" & mvarEnquiry_Price & ","
            End If

            If Len(mvarActual_Price) > 0 Then
                strSQL = strSQL & " Actual_Price=" & mvarActual_Price & ","
            End If

            If mvarComponent_ID <> 0 Then
                strSQL = strSQL & " Component_ID=" & mvarComponent_ID & ","
            End If

            If mvarActual_Supplier_ID <> 0 Then
                strSQL = strSQL & " Actual_Supplier_ID=" & mvarActual_Supplier_ID & ","
            End If

            If Len(mvarWO_No) > 0 Then
                strSQL = strSQL & " WO_No=" & mvarWO_No & ","
            End If

            If mvarUserID <> 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID & ","
            End If

            strSQL = strSQL & " Transact_Date=GetDate()"


            strSQL = strSQL & " WHERE PR_Line = " & pPR_Line

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Sub UpdatePOID(ByVal pPR_Line As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PRLine set "


            If mvarPO_ID <> 0 Then
                strSQL = strSQL & " PO_ID=" & mvarPO_ID & ","
            End If

            If mvarPO_Line_ID <> 0 Then
                strSQL = strSQL & " PO_Line_ID=" & mvarPO_Line_ID & ","
            End If

            If mvarUserID <> 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID & ","
            End If

            strSQL = strSQL & " Transact_Date=GetDate()"


            strSQL = strSQL & " WHERE PR_Line = " & pPR_Line


            Debug.WriteLine(strSQL)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Sub UpdateReserveStock(ByVal pPR_Line As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PRLine set "

            'If Len(mvarStock_Reserved) > 0 Then
            'strSQL = strSQL & " Stock_Reserved = Stock_Reserved + " & mvarStock_Reserved & ","
            'End If
            'If Len(mvarOrder_Qty) > 0 Then
            'strSQL = strSQL & " Order_Qty = Order_Qty - " & mvarStock_Reserved & ","
            'End If

            If Len(mvarStock_Reserved) > 0 Then
                strSQL = strSQL & " Stock_Reserved = " & mvarStock_Reserved & ","
            End If

            If Len(mvarReserveDate) > 0 Then
                strSQL = strSQL & " ReserveDate='" & Replace(mvarReserveDate, "'", "''") & "',"
            End If

            If Len(mvarOrder_Qty) > 0 Then
                strSQL = strSQL & " Order_Qty = " & mvarOrder_Qty & ","
            End If

            If mvarUserID <> 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID & ","
            End If

            strSQL = strSQL & " Transact_Date=GetDate()"


            strSQL = strSQL & " WHERE PR_Line = " & pPR_Line

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Sub UpdateUnReserveStock(ByVal pPR_Line As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PRLine set "

            If Len(mvarStock_Reserved) > 0 Then
                strSQL = strSQL & " Stock_Reserved = Stock_Reserved - " & mvarStock_Reserved & ","
            End If

            If Len(mvarOrder_Qty) > 0 Then
                strSQL = strSQL & " Order_Qty = Order_Qty + " & mvarStock_Reserved & ","
            End If

            If mvarUserID <> 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID & ","
            End If

            strSQL = strSQL & " Transact_Date=GetDate()"


            strSQL = strSQL & " WHERE PR_Line = " & pPR_Line

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub
        Public Function LoadList(ByRef ds As DataSet, Optional ByVal pPR_ID As String = "", Optional ByVal pPR_Line As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String
                SQLStr = SQLStr & " SELECT PR.* "
                SQLStr = SQLStr & " ,PD.Name As ProductName "
                SQLStr = SQLStr & " ,PD.Description As Description"
                SQLStr = SQLStr & " ,POH.PO_NO As PO_NO"
                SQLStr = SQLStr & " ,UM.Name As UOM "
                SQLStr = SQLStr & " ,UM.Description As UnitName"

                SQLStr = SQLStr & " , SU.Supplier_Name As SupplierName "
                SQLStr = SQLStr & " , SU2.Supplier_Name As Actual_Supplier_Name "

                'SQLStr = SQLStr & " , Currency = CASE SU2.Supplier_Name"
                'SQLStr = SQLStr & "         WHEN '' THEN CU.CurrencySymbol"
                'SQLStr = SQLStr & "         ELSE CU2.CurrencySymbol"
                'SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " ,Currency = "
                SQLStr = SQLStr & " CASE"
                SQLStr = SQLStr & "     WHEN CU2.CurrencySymbol IS NULL THEN CU.CurrencySymbol "
                SQLStr = SQLStr & "     ELSE CU2.CurrencySymbol "
                SQLStr = SQLStr & " END"

                SQLStr = SQLStr & " FROM PRLine PR "

                SQLStr = SQLStr & " LEFT JOIN Product PD "
                SQLStr = SQLStr & " ON (PR.Product_ID = PD.Product_ID) "
                SQLStr = SQLStr & " LEFT JOIN UnitMeasurement UM "
                SQLStr = SQLStr & " ON (UM.UOM_ID = PD.UOM_ID) "

                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PR.Supplier_ID = SU.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Currency CU "
                SQLStr = SQLStr & " ON (SU.Currency_ID = CU.Currency_ID) "

                SQLStr = SQLStr & " LEFT JOIN Supplier SU2 "
                SQLStr = SQLStr & " ON (PR.Actual_Supplier_ID = SU2.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Currency CU2 "
                SQLStr = SQLStr & " ON (SU2.Currency_ID = CU2.Currency_ID) "
                SQLStr = SQLStr & " LEFT JOIN POHeader POH ON (POH.PO_ID = PR.PO_ID)"

                If pPR_Line <> "" Then
                    SQLStr = SQLStr & " WHERE PR_Line =" & pPR_Line

                    If pPR_ID <> "" Then
                        SQLStr = SQLStr & " AND PR_ID =" & pPR_ID
                    End If

                Else

                    If pPR_ID <> "" Then
                        SQLStr = SQLStr & " WHERE PR_ID =" & pPR_ID
                    End If

                End If

                SQLStr = SQLStr & " order by PR.Create_Date, PR_Line"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(Optional ByVal pPR_Line As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet

                Dim SQLStr As String = "SELECT PR.*, CA.Name As Category_Name, PD.Name As Product_Name, SU.Supplier_Name As Supplier_Name"
                SQLStr = SQLStr & " FROM PRLine PR "
                SQLStr = SQLStr & " LEFT JOIN Category CA "
                SQLStr = SQLStr & " ON (PR.Category_ID = CA.Category_ID) "
                SQLStr = SQLStr & " LEFT JOIN Product PD "
                SQLStr = SQLStr & " ON (PR.Product_ID = PD.Product_ID) "
                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PR.Supplier_ID = SU.Supplier_ID) "

                If pPR_Line <> "" Then
                    SQLStr = SQLStr & " WHERE PR.PR_Line =" & pPR_Line
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)


                    If Not row.IsNull("PR_ID") Then
                        PR_ID = Integer.Parse(row("PR_ID").ToString())
                    Else
                        PR_ID = Nothing
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

                    If Not row.IsNull("Request_Qty") Then
                        Request_Qty = Integer.Parse(row("Request_Qty").ToString())
                    Else
                        Request_Qty = ""
                    End If

                    If Not row.IsNull("Stock_Reserved") Then
                        Stock_Reserved = Integer.Parse(row("Stock_Reserved").ToString())
                    Else
                        Stock_Reserved = ""
                    End If

                    If Not row.IsNull("Order_Qty") Then
                        Order_Qty = Integer.Parse(row("Order_Qty").ToString())
                    Else
                        Order_Qty = ""
                    End If

                    If Not row.IsNull("Delivery_Date") Then
                        Delivery_Date = row("Delivery_Date").ToString()
                    Else
                        Delivery_Date = ""
                    End If

                    If Not row.IsNull("ReserveDate") Then
                        ReserveDate = row("ReserveDate").ToString()
                    Else
                        ReserveDate = ""
                    End If

                    If Not row.IsNull("Supplier_ID") Then
                        Supplier_ID = Integer.Parse(row("Supplier_ID").ToString())
                    Else
                        Supplier_ID = Nothing
                    End If

                    If Not row.IsNull("PO_ID") Then
                        PO_ID = Integer.Parse(row("PO_ID").ToString())
                    Else
                        PO_ID = Nothing
                    End If

                    If Not row.IsNull("PO_Line_ID") Then
                        PO_Line_ID = Integer.Parse(row("PO_Line_ID").ToString())
                    Else
                        PO_Line_ID = Nothing
                    End If

                    If Not row.IsNull("Currency") Then
                        Currency = Integer.Parse(row("Currency").ToString())
                    Else
                        Currency = Nothing
                    End If

                    If Not row.IsNull("ActualPriceCurrency") Then
                        ActualPriceCurrency = Integer.Parse(row("ActualPriceCurrency").ToString())
                    Else
                        ActualPriceCurrency = Nothing
                    End If

                    If Not row.IsNull("Enquiry_Price") Then
                        Enquiry_Price = Decimal.Parse(row("Enquiry_Price").ToString())
                    Else
                        Enquiry_Price = ""
                    End If

                    If Not row.IsNull("Actual_Price") Then
                        Actual_Price = Decimal.Parse(row("Actual_Price").ToString())
                    Else
                        Actual_Price = ""
                    End If

                    If Not row.IsNull("Component_ID") Then
                        Component_ID = Integer.Parse(row("Component_ID").ToString())
                    Else
                        Component_ID = ""
                    End If

                    If Not row.IsNull("Actual_Supplier_ID") Then
                        Actual_Supplier_ID = Integer.Parse(row("Actual_Supplier_ID").ToString())
                    Else
                        Actual_Supplier_ID = Nothing
                    End If

                    If Not row.IsNull("WO_No") Then
                        WO_No = row("WO_No").ToString()
                    Else
                        WO_No = ""
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

                    If Not row.IsNull("Product_Name") Then
                        Product_Name = row("Product_Name").ToString()
                    Else
                        Product_Name = ""
                    End If

                    If Not row.IsNull("Category_Name") Then
                        Category_Name = row("Category_Name").ToString()
                    Else
                        Category_Name = ""
                    End If

                    If Not row.IsNull("Supplier_Name") Then
                        Supplier_Name = row("Supplier_Name").ToString()
                    Else
                        Supplier_Name = ""
                    End If

                    Return True
                End If
            End With
        End Function

        '16.11.2003 YG Start
        Public Function IsPOCreated(ByVal pPR_ID As String) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT * FROM POLine "
            SQLstr = SQLstr & " WHERE PR_ID = " & pPR_ID
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
            ds.Dispose()
        End Function
        '16.11.2003 YG End
#End Region

#Region " Get and Let Property"

        Public Property PR_Line() As Integer
            Get
                Return mvarPR_Line
            End Get
            Set(ByVal Value As Integer)
                mvarPR_Line = Value
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

        Public Property Request_Qty() As Decimal
            Get
                Return mvarRequest_Qty
            End Get
            Set(ByVal Value As Decimal)
                mvarRequest_Qty = Value
            End Set
        End Property

        Public Property Stock_Reserved() As Decimal
            Get
                Return mvarStock_Reserved
            End Get
            Set(ByVal Value As Decimal)
                mvarStock_Reserved = Value
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

        Public Property Delivery_Date() As String
            Get
                Return mvarDelivery_Date
            End Get
            Set(ByVal Value As String)
                mvarDelivery_Date = Value
            End Set
        End Property

        Public Property ReserveDate() As String
            Get
                Return mvarReserveDate
            End Get
            Set(ByVal Value As String)
                mvarReserveDate = Value
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

        Public Property PO_ID() As Integer
            Get
                Return mvarPO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPO_ID = Value
            End Set
        End Property

        Public Property PO_Line_ID() As Integer
            Get
                Return mvarPO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPO_Line_ID = Value
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

        Public Property ActualPriceCurrency() As Integer
            Get
                Return mvarActualPriceCurrency
            End Get
            Set(ByVal Value As Integer)
                mvarActualPriceCurrency = Value
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

        Public Property Actual_Price() As Decimal
            Get
                Return mvarActual_Price
            End Get
            Set(ByVal Value As Decimal)
                mvarActual_Price = Value
            End Set
        End Property

        Public Property Component_ID() As Integer
            Get
                Return mvarComponent_ID
            End Get
            Set(ByVal Value As Integer)
                mvarComponent_ID = Value
            End Set
        End Property

        Public Property Actual_Supplier_ID() As Integer
            Get
                Return mvarActual_Supplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarActual_Supplier_ID = Value
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

        Public Property Category_Name() As String
            Get
                Return mvarCategory_Name
            End Get
            Set(ByVal Value As String)
                mvarCategory_Name = Value
            End Set
        End Property

        Public Property Product_Name() As String
            Get
                Return mvarProduct_Name
            End Get
            Set(ByVal Value As String)
                mvarProduct_Name = Value
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

        Public Sub New()

        End Sub
    End Class

#End Region


#Region " Basic PR Logic"

    Public Class PRBusLogic

        Public Function LoadUserGrpList(ByRef ds As DataSet, Optional ByVal pDepartment_ID As String = "0") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT * from Department"

                If pDepartment_ID <> "0" Then
                    SQLStr = SQLStr & " WHERE Department_ID = " & pDepartment_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        ' YG Redo function LoadQuotationComponent on 21.10.2003
        '       Public Function LoadQuotationComponent(ByRef ds As DataSet, ByVal pQuotation_ID As String) As Boolean
            '           With New DataAccess.DAccess.Access

            '                Dim SQLStr As String
            '                SQLStr = "SELECT QC.* "
            '                SQLStr = SQLStr & " , PD.Name As ProductName "
            '                SQLStr = SQLStr & " , PD.Description As ProductDesc "
            '                SQLStr = SQLStr & " , SU.Supplier_Name As SupplierName "
            '                SQLStr = SQLStr & " , CU.CurrencySymbol As Currency "
            '                SQLStr = SQLStr & " , UOM.Name As UOM "
            '                SQLStr = SQLStr & " , PS.Create_Date As PriceDate "
            '                'SQLStr = SQLStr & " FROM QuotationLineComponent QC "
            '                'SQLStr = SQLStr & " LEFT JOIN Product PD ON (QC.Product_ID = PD.Product_ID)"
            '                'SQLStr = SQLStr & " LEFT JOIN Supplier SU ON (QC.Supplier_ID = SU.Supplier_ID) "
            '                'SQLStr = SQLStr & " LEFT JOIN Currency CU ON (CU.Currency_ID = SU.Currency_ID)"
            '                'SQLStr = SQLStr & " LEFT JOIN UnitMeasurement UOM ON (PD.UOM_ID = UOM.UOM_ID)"
            '                'SQLStr = SQLStr & " LEFT JOIN ProductSupplier PS ON (PS.Product_ID = PD.Product_ID)"
            '                SQLStr = SQLStr & " From ProductSupplier PS INNER JOIN "
            '                SQLStr = SQLStr & " Supplier SU ON PS.Supplier_ID = SU.Supplier_ID RIGHT OUTER JOIN "
            '                SQLStr = SQLStr & " QuotationLineComponent QC LEFT OUTER JOIN "
            '                SQLStr = SQLStr & " Product PD ON QC.Product_ID = PD.Product_ID ON SU.Supplier_ID = QC.Supplier_ID AND PS.Product_ID = PD.Product_ID LEFT OUTER JOIN "
            '                SQLStr = SQLStr & " Currency CU ON CU.Currency_ID = SU.Currency_ID LEFT OUTER JOIN "
            '                SQLStr = SQLStr & " UnitMeasurement UOM ON PD.UOM_ID = UOM.UOM_ID "
            '                SQLStr = SQLStr & " where QC.Quotation_ID=" & pQuotation_ID
            '
            '                'SQLStr = SQLStr & " WHERE (PS.Supplier_ID = SU.Supplier_ID)"
            '                'If pQuotation_ID <> "" Then
            '                'SQLStr = SQLStr & " AND Quotation_ID = " & pQuotation_ID
            '                'End If
            '
            '                'SQLStr = SQLStr & " AND PS.History_Record = '0'"
            '
            '                If .GetDataSet(ds, SQLStr) Then
            '                Return True
            '                End If
            '            End With
            '        End Function

        Public Function LoadQuotationComponent(ByRef ds As DataSet, ByVal pQuotation_ID As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String
                SQLStr = "select QC.*, "
                SQLStr = SQLStr & "       QC.Qty * QL.Qty as OrderQty, "
                SQLStr = SQLStr & "       PD.Name As ProductName, "
                SQLStr = SQLStr & "       PD.Description As ProductDesc, "
                SQLStr = SQLStr & "       SU.Supplier_Name As SupplierName, "
                SQLStr = SQLStr & "       CU.CurrencySymbol As Currency, "
                SQLStr = SQLStr & "       UOM.Name As UOM, "
                SQLStr = SQLStr & "       PS.Create_Date As PriceDate "
                SQLStr = SQLStr & "            from QuotationLineComponent QC, QuotationLine QL, Product PD, Supplier SU, Currency CU, UnitMeasurement UOM, ProductSupplier PS "
                SQLStr = SQLStr & "            where QC.Quotation_Line_ID = QL.Quotation_Line_ID and "
                SQLStr = SQLStr & "                  QC.Product_ID = PD.Product_ID and "
                SQLStr = SQLStr & "                  QC.Supplier_ID = SU.Supplier_ID and "
                SQLStr = SQLStr & "                  QC.Product_ID = PS.Product_ID and "
                SQLStr = SQLStr & "                  QC.Supplier_ID = PS.Supplier_ID and "
                SQLStr = SQLStr & "                  PS.History_Record <> 1 and "  ' 1 is History Record
                SQLStr = SQLStr & "                  SU.Currency_ID = CU.Currency_ID and "
                SQLStr = SQLStr & "                  PD.UOM_ID = UOM.UOM_ID and "
                SQLStr = SQLStr & "                  QC.Quotation_ID = " & pQuotation_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadProduct(ByRef ds As DataSet, ByVal pCategory_ID As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT PD.*, PD.Name As ProductName, SU.Supplier_Name As SupplierName"
                SQLStr = SQLStr & " FROM QuotationLineComponent QC "
                SQLStr = SQLStr & " LEFT JOIN Product PD ON (QC.Product_ID = PD.Product_ID)"
                SQLStr = SQLStr & " LEFT JOIN Supplier SU ON (QC.Supplier_ID = SU.Supplier_ID) "

                If pCategory_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Category_ID = " & pCategory_ID
                End If
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function


        Public Function GetUser(ByRef ds As DataSet, Optional ByVal pUser_ID As String = "0") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM UserProfile"

                If pUser_ID <> "0" Then
                    SQLStr = SQLStr & " WHERE User_ID =" & pUser_ID
                End If
                SQLStr = SQLStr & " Order by Name"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetUserInitials(ByVal pUser_ID) As String
            With New DataAccess.DAccess.Access

                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM UserProfile"

                If pUser_ID <> "0" Then
                    SQLStr = SQLStr & " WHERE User_ID =" & pUser_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)
                    GetUserInitials = row("Initial").ToString()
                Else
                    GetUserInitials = ""
                End If

            End With

        End Function

        'Count the total PR order quantity base on component id
        Public Function CountTotalOrderQty(ByVal pComponentID As String) As Integer
            Dim ds As DataSet
            Dim count As Integer = 0

            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT Sum(Order_Qty) As Order_Qty"

                SQLStr = SQLStr & " FROM PRLine "
                SQLStr = SQLStr & " WHERE Component_ID = " & pComponentID

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row("Order_Qty") Is System.DBNull.Value Then
                        count = row("Order_Qty")
                    End If
                End If

            End With

            Return count
        End Function

        'Use by PRItem and PRForm, check order quantity from db and grid(newly created item, PRLine)
        Public Function CountOrderedQty(ByVal pComponent_ID As Integer, ByVal ItemGrid As DevExpress.XtraGrid.Views.Grid.GridView) As Integer

            Dim countDB As Integer = 0
            Dim countGrid As Integer = 0
            Dim totalQtyOrdered As Integer = 0

            countDB = CountTotalOrderQty(pComponent_ID)

            Dim i
            Dim dr As DataRow
            Dim items As Object()

            For i = 0 To ItemGrid.RowCount - 1
                dr = ItemGrid.GetDataRow(i)
                items = dr.ItemArray
                If items(5) = pComponent_ID Then
                    If items(0) = Nothing Or items(0) = 0 Then
                        countGrid = countGrid + items(7)
                    End If

                End If
            Next

            totalQtyOrdered = countDB + countGrid

            Return totalQtyOrdered
        End Function

        ' 22.10.2003 YG Start
        '        Public Function GetQty(ByVal pComponentID As String) As Integer
        '            Dim ds As DataSet
        '            Dim count As Integer = 0
        '
        '            With New DataAccess.DAccess.Access
        '
        '                Dim SQLStr As String = "SELECT Qty"
        '
        '                SQLStr = SQLStr & " FROM QuotationLineComponent "
        '                SQLStr = SQLStr & " WHERE Component_ID = " & pComponentID
        '
        '                If .GetDataSet(ds, SQLStr) Then
        '                    Dim row As DataRow = ds.Tables(0).Rows(0)
        '
        '                    If Not row("Qty") Is System.DBNull.Value Then
        '                        count = row("Qty")
        '                    End If
        '                End If
        '
        '            End With
        '
        '            Return count
        '        End Function

        Public Function GetQty(ByVal pComponentID As String) As Integer
            Dim ds As DataSet
            Dim count As Integer = 0

            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT QL.Qty * QC.Qty as Qty"
                SQLStr = SQLStr & " FROM QuotationLine QL, QuotationLineComponent QC "
                SQLStr = SQLStr & " WHERE QL.Quotation_Line_ID = QC.Quotation_Line_ID and "
                SQLStr = SQLStr & " QC.Component_ID = " & pComponentID

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row("Qty") Is System.DBNull.Value Then
                        count = row("Qty")
                    End If
                End If

            End With

            Return count
        End Function
        ' 22.10.2003 YG End

        Public Function GetPRRpt(ByRef ds As DataSet, Optional ByVal pPR_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT "

                SQLStr = SQLStr & " PH.refno as refno,PO.PO_NO As PO_NO "
                SQLStr = SQLStr & " , PH.PR_No As PR_No "
                SQLStr = SQLStr & " , QU.Confirm_Quotation_No As Confirm_Quotation_No "
                'SQLStr = SQLStr & " , PH.Cust_Delivery_Date As Cust_Delivery_Date "

                SQLStr = SQLStr & " , PR.Request_Qty AS Request_Qty"
                SQLStr = SQLStr & " , PR.Stock_Reserved As Stock_Reserved "
                SQLStr = SQLStr & " , PR.Order_Qty As Order_Qty "
                SQLStr = SQLStr & " , PH.Remarks As Remarks "

                'SQLStr = SQLStr & " , CAST( Round(PR.Enquiry_Price, 2) AS decimal(10,2)) As Enquiry_Price, CAST( Round(PR.Actual_Price, 2) AS decimal(10,2)) As Actual_Price "
                SQLStr = SQLStr & " , PR.Enquiry_Price As Enquiry_Price, PR.Actual_Price As Actual_Price "

                SQLStr = SQLStr & " , PD.Description As ProductDesc, PD.Name As ProductName "
                SQLStr = SQLStr & " , U.Name As Unit "
                SQLStr = SQLStr & " , CONVERT(varchar(50),PR.Request_Qty) + ' ' + U.Name As Request_QtyUnit"
                SQLStr = SQLStr & " , CONVERT(varchar(50),PR.Order_Qty) + ' ' + U.Name As Order_QtyUnit"
                SQLStr = SQLStr & " , CONVERT(varchar(50),PR.Stock_Reserved) + ' ' + U.Name As Stock_ReservedUnit"

                SQLStr = SQLStr & " , SU.Supplier_Name As SupplierName "
                SQLStr = SQLStr & " , SU2.Supplier_Name As ActualSupplierName "
                SQLStr = SQLStr & " , User1.Name As RequesterName, User2.Name As ApproverName, User4.Name As PRApproverName "

                SQLStr = SQLStr & " , CategoryName = CASE PH.Category"
                SQLStr = SQLStr & "         WHEN '0' THEN 'Samples'"
                SQLStr = SQLStr & "         WHEN '1' THEN 'Admin Use'"
                SQLStr = SQLStr & "         WHEN '2' THEN 'Factory Use'"
                SQLStr = SQLStr & "         WHEN '3' THEN 'Store Use'"
                SQLStr = SQLStr & "  END"


                SQLStr = SQLStr & " , ModelParts = CASE "
                SQLStr = SQLStr & "         WHEN PD.Model ='' THEN '' "
                SQLStr = SQLStr & "         WHEN PD.Model IS NULL THEN '' "
                SQLStr = SQLStr & "         ELSE '(MODEL/PART: ' + PD.Model + ')' "
                SQLStr = SQLStr & "  END"

                'SQLStr = SQLStr & " , GrpName = UGrp.Name" 'CASE PH.Grp"
                'SQLStr = SQLStr & "         WHEN '0' THEN 'Admin'"
                'SQLStr = SQLStr & "         WHEN '1' THEN 'Sales'"
                'SQLStr = SQLStr & "         WHEN '2' THEN 'Factory'"
                'SQLStr = SQLStr & "         WHEN '3' THEN 'Store'"
                'SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , Delivery_Date = CASE"
                SQLStr = SQLStr & "         WHEN PR.Delivery_Date IS NULL THEN '' "
                SQLStr = SQLStr & "         WHEN PR.Delivery_Date = '' THEN '' "
                SQLStr = SQLStr & "         ELSE CONVERT(char(12), PR.Delivery_Date, 6) "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , Stock_Reserved_Date = CASE"
                SQLStr = SQLStr & "         WHEN PR.ReserveDate IS NULL THEN '' "
                SQLStr = SQLStr & "         WHEN PR.ReserveDate = '' THEN '' "
                SQLStr = SQLStr & "         ELSE CONVERT(char(12), PR.ReserveDate, 6) "
                SQLStr = SQLStr & "  END"

                SQLStr = SQLStr & " , CU.CurrencySymbol AS Currency"
                SQLStr = SQLStr & " , CU2.CurrencySymbol AS Currency2"

                'SQLStr = SQLStr & " ,Currency2 = "
                'SQLStr = SQLStr & " CASE"
                'SQLStr = SQLStr & "     WHEN CU2.CurrencySymbol IS NULL THEN '' "
                'SQLStr = SQLStr & "     ELSE CU2.CurrencySymbol "
                'SQLStr = SQLStr & " END"

                SQLStr = SQLStr & " FROM PRLine PR "
                SQLStr = SQLStr & " LEFT JOIN Product PD "
                SQLStr = SQLStr & " ON (PR.Product_ID = PD.Product_ID) "
                SQLStr = SQLStr & " LEFT JOIN UnitMeasurement U "
                SQLStr = SQLStr & " ON (PD.UOM_ID = U.UOM_ID) "

                SQLStr = SQLStr & " LEFT JOIN PRHeader PH "
                SQLStr = SQLStr & " ON (PR.PR_ID = PH.PR_ID) "

                SQLStr = SQLStr & " LEFT JOIN QuotationHeader QU "
                SQLStr = SQLStr & " ON (PH.Quotation_ID = QU.Quotation_ID) "

                SQLStr = SQLStr & " LEFT JOIN UserProfile User1 "
                SQLStr = SQLStr & " ON (PH.Requester = User1.User_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile User2 "
                SQLStr = SQLStr & " ON (PH.Approver = User2.User_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile User3 "
                SQLStr = SQLStr & " ON (PH.UserID = User3.User_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile User4 "
                SQLStr = SQLStr & " ON (PH.PRApprover = User4.User_ID) "
                SQLStr = SQLStr & " LEFT JOIN POHeader PO "
                SQLStr = SQLStr & " ON (PO.PO_ID = PR.PO_ID) "

                SQLStr = SQLStr & " LEFT JOIN Supplier SU "
                SQLStr = SQLStr & " ON (PR.Supplier_ID = SU.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Currency CU ON (PR.Currency = CU.Currency_ID)"

                SQLStr = SQLStr & " LEFT JOIN Supplier SU2 "
                SQLStr = SQLStr & " ON (PR.Actual_Supplier_ID = SU2.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Currency CU2 ON (PR.ActualPriceCurrency = CU2.Currency_ID)"

                'SQLStr = SQLStr & " LEFT JOIN Department UGrp "
                'SQLStr = SQLStr & " ON (UGrp.Department_ID = PH.Grp) "

                If pPR_ID <> "" Then
                    SQLStr = SQLStr & " WHERE PR.PR_ID =" & pPR_ID
                End If

                SQLStr = SQLStr & " order by PR.Create_Date, PR_Line"

                Debug.WriteLine(SQLStr)

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function


        Public Function ProdSupLoadList(ByRef ds As DataSet, Optional ByVal pProduct_ID As String = "", Optional ByVal pHistory_Record As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT CU.CurrencySymbol As CurrencySymbol ,PS.*, S.Supplier_Name As Supplier, Prod.Description As Product, UOM.Name As UOM"
                SQLStr = SQLStr & ", price = CASE WHEN ps.purchase_price <> 0 THEN ps.purchase_price ELSE ps.enquiry_price END "
                SQLStr = SQLStr & " FROM ProductSupplier PS "
                SQLStr = SQLStr & " LEFT JOIN Supplier S "
                SQLStr = SQLStr & " ON (PS.Supplier_ID = S.Supplier_ID) "
                SQLStr = SQLStr & " LEFT JOIN Currency CU "
                SQLStr = SQLStr & " ON (CU.Currency_ID = PS.Currency) "
                SQLStr = SQLStr & " LEFT JOIN Product Prod "
                SQLStr = SQLStr & " ON (Prod.Product_ID = PS.Product_ID) "
                SQLStr = SQLStr & " LEFT JOIN UnitMeasurement UOM "
                SQLStr = SQLStr & " ON (Prod.UOM_ID = UOM.UOM_ID) "

                If pProduct_ID <> "" Then
                    SQLStr = SQLStr & " WHERE PS.Product_ID =" & pProduct_ID
                    'SQLStr = SQLStr & " and s.Approved='1' "
                End If

                If pProduct_ID <> "" And pHistory_Record <> "" Then
                    SQLStr = SQLStr & " AND PS.History_Record =" & pHistory_Record
                    'SQLStr = SQLStr & " and s.Approved='1' "
                Else
                    If pHistory_Record <> "" Then
                        SQLStr = SQLStr & " WHERE PS.History_Record =" & pHistory_Record
                        'SQLStr = SQLStr & " and s.Approved='1' "
                    End If
                End If

                SQLStr = SQLStr & " Order by PS.Transact_Date DESC"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function GetWONo(Optional ByVal pConfirm_Quotation_No As String = "") As String
            Dim SQLStr As String
            Dim ds As DataSet
            Dim WO_No As String = ""

            SQLStr = "SELECT WO_No FROM WorkOrderHeader "
            SQLStr = SQLStr & " WHERE Confirm_Quotation_No ='" & pConfirm_Quotation_No & "'"

            Debug.WriteLine(SQLStr)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("WO_No") Then
                            WO_No = row("WO_No").ToString()
                        End If

                    End If
                End If
            End With

            Return WO_No

        End Function

        Public Sub UpdateDeliveryDate(ByVal pPRID As Integer, ByVal pDeliveryDate As Date)

            Dim SQLStr As String

            SQLStr = "set dateformat dmy;Update PRLINE set "
            SQLStr = SQLStr & " Delivery_Date = '" & pDeliveryDate.Day & "/" & pDeliveryDate.Month & "/" & pDeliveryDate.Year & "'"
            SQLStr = SQLStr & " WHERE PR_ID =" & pPRID

            With New DataAccess.DAccess.Access
                .ExecuteQuery(SQLStr)
            End With

        End Sub

        Public Sub CopyPRLine(ByVal pPRID As Integer, ByVal pPRID_target As Integer)

            Dim SQLStr As String

            SQLStr = "insert into PRLine "
            SQLStr = SQLStr & " ("
            SQLStr = SQLStr & "PR_ID,"
            SQLStr = SQLStr & "Category_ID,"
            SQLStr = SQLStr & "Product_ID,"
            SQLStr = SQLStr & "Request_Qty,"
            SQLStr = SQLStr & "Stock_Reserved,"
            SQLStr = SQLStr & "ReserveDate,"
            'SQLStr = SQLStr & "Order_Qty,"
            SQLStr = SQLStr & "Delivery_Date,"
            SQLStr = SQLStr & "Supplier_ID,"
            'SQLStr = SQLStr & "PO_ID,"
            'SQLStr = SQLStr & "PO_Line_ID,"
            SQLStr = SQLStr & "Currency,"
            SQLStr = SQLStr & "Enquiry_Price,"
            SQLStr = SQLStr & "ActualPriceCurrency,"
            SQLStr = SQLStr & "Actual_Price,"
            SQLStr = SQLStr & "Component_ID,"
            SQLStr = SQLStr & "Actual_Supplier_ID,"
            SQLStr = SQLStr & "WO_No,"
            SQLStr = SQLStr & "Create_Date,"
            SQLStr = SQLStr & "Transact_Date,"
            SQLStr = SQLStr & "UserID"
            SQLStr = SQLStr & ") "
            SQLStr = SQLStr & "Select "
            SQLStr = SQLStr & pPRID_target & ","
            SQLStr = SQLStr & "Category_ID,"
            SQLStr = SQLStr & "Product_ID,"
            SQLStr = SQLStr & "Request_Qty,"
            SQLStr = SQLStr & "Stock_Reserved,"
            SQLStr = SQLStr & "ReserveDate,"
            'SQLStr = SQLStr & "Order_Qty,"
            SQLStr = SQLStr & "Delivery_Date,"
            SQLStr = SQLStr & "Supplier_ID,"
            'SQLStr = SQLStr & "PO_ID,"
            'SQLStr = SQLStr & "PO_Line_ID,"
            SQLStr = SQLStr & "Currency,"
            SQLStr = SQLStr & "Enquiry_Price,"
            SQLStr = SQLStr & "ActualPriceCurrency,"
            SQLStr = SQLStr & "Actual_Price,"
            SQLStr = SQLStr & "Component_ID,"
            SQLStr = SQLStr & "Actual_Supplier_ID,"
            SQLStr = SQLStr & "WO_No,"
            SQLStr = SQLStr & "GetDate(),"
            SQLStr = SQLStr & "GetDate(),"
            SQLStr = SQLStr & "UserID "
            SQLStr = SQLStr & "From PRLine where PR_ID =" & pPRID

            With New DataAccess.DAccess.Access
                .ExecuteQuery(SQLStr)
            End With

        End Sub

    End Class



#End Region



End Namespace
