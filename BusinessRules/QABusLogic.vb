Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace QABusRules

    Public Class QABusLogic

#Region " QA Variable"
        Private mvarQA_ID As Long
        Private mvarQA_Line_ID As Long
        Private mvarWO_Line_ID As Integer
        Private mvarQty As Integer
        Private mvarInspected As Integer
        Private mvarInspectedQty As Integer
        Private mvarQtyBal As Integer
        Private mvarExpComplDateWO_Line_ID As Integer
        Private mvarRemarks As String
        Private mvarUserID As String

#End Region

#Region " QA Statement"
        Public Function GetQAInspectionReport(ByRef ds As DataSet, Optional ByVal pDate_From As String = "", Optional ByVal pDate_To As String = "")
            Dim SQLStr As String
            SQLStr = "select w1.wo_no, q1.wo_line_id, sum(q1.qty) as totalqty, sum(q2.inspectedqty) as inspectedqty, "
            SQLStr = SQLStr & "(sum(q1.qty) - sum(q2.inspectedqty)) as outstandinginspectedqty, w2.box, w2.compl_date, "
            SQLStr = SQLStr & "w2.expected_compl_date "
            SQLStr = SQLStr & "from qa q1, qaline q2, workorderheader w1, workorderline w2 where q1.qa_id= q2.qa_id and q1.wo_line_id=w2.wo_line_id "
            SQLStr = SQLStr & "and w1.wo_id = w2.wo_id "
            If pDate_From <> "" And pDate_To <> "" Then
                SQLStr = SQLStr & "and q1.create_Date between '" & pDate_From & "' and '" & pDate_To & "'"
            ElseIf pDate_From <> "" And pDate_To = "" Then
                SQLStr = SQLStr & "and q1.create_Date > '" & pDate_From & "' "
            ElseIf pDate_From = "" And pDate_To <> "" Then
                SQLStr = SQLStr & "and q1.create_Date < '" & pDate_To & "' "
            End If
            SQLStr = SQLStr & "group by w1.wo_no, q1.wo_line_id, w2.box, w2.compl_date, w2.expected_compl_date "



            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With

        End Function

        Public Function GetQABalQty() As Long
            Dim ds As DataSet
            Dim BalQty
            Dim SQLStr As String = "SELECT Q.QA_ID, Q.Qty, (Q.Qty-(select sum(inspectedqty) from QALine where qa_id=Q.qa_id)) as BalQty FROM QA Q "
            'SQLStr = SQLStr & "INNER JOIN WorkOrderLine W ON Q.WO_Line_ID = W.WO_Line_ID"

            SQLStr = SQLStr & " WHERE Q.QA_ID = " & mvarQA_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If IsDBNull(ds.Tables(0).Rows(0)("BalQty")) Then
                        ds.Dispose()
                        Return 0
                    Else
                        BalQty = ds.Tables(0).Rows(0)("BalQty")
                        ds.Dispose()
                        Return BalQty
                    End If
                Else
                    Return 0
                End If
            End With
        End Function

        Public Function GetQA(ByRef ds As DataSet)
            Dim SQLStr As String
            SQLStr = "SELECT Q.Qty-(select sum(QALine.inspectedqty) from QALine where qa_id=Q.qa_id) as BalQty, QALine.QA_Line_ID, QALine.InspectedQty, "
            'SQLStr = "SELECT *, QALine.BalQty "
            SQLStr = SQLStr & " Q.QA_ID, Q.WO_Line_ID, Q.Qty, Q.Inspected, Q.Remarks, Q.UserID, Q.Compl_Date, UserProfile.User_ID, UserProfile.Name, W.Box "
            SQLStr = SQLStr & " FROM QA Q "
            SQLStr = SQLStr & " INNER JOIN WorkOrderLine W ON Q.WO_Line_ID = W.WO_Line_ID"
            SQLStr = SQLStr & " INNER JOIN QALine on Q.QA_ID=QALine.QA_ID "
            SQLStr = SQLStr & "  INNER JOIN UserProfile ON Q.UserID = UserProfile.User_ID"
            If mvarWO_Line_ID > 0 Then
                SQLStr = SQLStr & " WHERE Q.WO_LINE_ID = " & mvarWO_Line_ID
            End If
            If mvarExpComplDateWO_Line_ID > 0 Then
                SQLStr = SQLStr & " and WOLineComplDateID = " & mvarExpComplDateWO_Line_ID
            End If
            SQLStr = SQLStr & " and Q.qty <>0 "
            SQLStr = SQLStr & " GROUP BY Q.QA_ID, Q.WO_Line_ID, Q.Qty, Q.Inspected, Q.Remarks, Q.UserID, Q.Compl_Date, UserProfile.User_ID, UserProfile.Name, QALine.QA_Line_ID, QALine.InspectedQty, W.Box"
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
        Public Function GetQA(ByRef ds As DataSet, ByVal InspectionStatus As Integer)
            Dim SQLStr As String = "SELECT * FROM QA Q "
            SQLStr = SQLStr & "INNER JOIN WorkOrderLine W ON Q.WO_Line_ID = W.WO_Line_ID"

            If mvarWO_Line_ID > 0 Then
                SQLStr = SQLStr & " WHERE Q.WO_LINE_ID = " & mvarWO_Line_ID
            End If
            If mvarExpComplDateWO_Line_ID > 0 Then
                SQLStr = SQLStr & " and WOLineComplDateID = " & mvarExpComplDateWO_Line_ID
            End If
            SQLStr = SQLStr & " and Q.qty <>0"
            If InspectionStatus = 1 Then
                SQLStr = SQLStr & " and Q.Inspected=1"
            Else : SQLStr = SQLStr & " and Q.Inspected=0"
            End If
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetQAQty() As Long
            Dim ds As DataSet
            Dim SQlStr As String = "SELECT sum(Qty) FROM QA "
            If mvarWO_Line_ID > 0 Then
                SQlStr = SQlStr & "WHERE WO_LINE_ID = " & mvarWO_Line_ID
            End If
            If mvarExpComplDateWO_Line_ID > 0 Then
                SQlStr = SQlStr & " and WOLineComplDateID = " & mvarExpComplDateWO_Line_ID
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    'If ds.Tables(0).Rows.Count > 0 Then
                    If IsDBNull(ds.Tables(0).Rows(0)(0)) Then
                        Return 0
                    Else
                        Return ds.Tables(0).Rows(0)(0)
                    End If
                Else
                    Return 0
                End If
            End With
        End Function

        Public Function CreateQALine()
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO QALine "
            SQLStr = SQLStr & "(QA_ID, InspectedQty, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarQA_ID & "," & mvarInspected & ", '" & mvarUserID & "')"
            'SQLStr = SQLStr & ";SELECT @@identity as QA_ID FROM QA"

            With New DataAccess.DAccess.Access
                .ExecuteQuery(SQLStr)
            End With
        End Function

        Public Function CreateQA() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO QA "
            SQLStr = SQLStr & "(WO_Line_ID, Qty, WOLineComplDateID, Compl_Date, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarWO_Line_ID & "," & mvarQty & "," & mvarExpComplDateWO_Line_ID & ", GETDATE(), '" & mvarUserID & "')"
            SQLStr = SQLStr & ";SELECT @@identity as QA_ID FROM QA"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarQA_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateQAQty()
            Dim SQLStr As String = "Update QA SET "

            SQLStr = SQLStr & " qty = " & mvarQty & ", "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "', "
            SQLStr = SQLStr & " Transact_Date = GETDATE(), "
            SQLStr = SQLStr & " Compl_Date = GETDATE() "
            SQLStr = SQLStr & " WHERE WO_Line_ID = " & mvarWO_Line_ID

            With New DataAccess.DAccess.Access
                .ExecuteQuery(SQLStr)
            End With
        End Function

        Public Function UpdateQA()
            Dim SQLStr As String = "Update QA SET "

            'SQLStr = SQLStr & " inspectedqty = " & mvarInspected & ", "
            SQLStr = SQLStr & " Remarks = '" & Replace(mvarRemarks, "'", "''") & "', "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "', "
            SQLStr = SQLStr & " Transact_Date = GETDATE(), "
            SQLStr = SQLStr & " Compl_Date = GETDATE() "
            SQLStr = SQLStr & " WHERE WO_Line_ID = " & mvarWO_Line_ID
            SQLStr = SQLStr & " AND QA_ID = " & mvarQA_ID

            With New DataAccess.DAccess.Access
                .ExecuteQuery(SQLStr)
            End With
        End Function

        Public Function UpdateQALine()
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;Update QALine Set "
            SQLStr = SQLStr & " InspectedQty= " & mvarInspectedQty & ", "
            'SQLStr = SQLStr & " BalQty= " & mvarQtyBal & ", "
            SQLStr = SQLStr & " UserID= " & mvarUserID
            SQLStr = SQLStr & " WHERE QA_ID=" & mvarQA_ID
            With New DataAccess.DAccess.Access
                .ExecuteQuery(SQLStr)
            End With
        End Function
#End Region

#Region " QA Get and Let Property"
        Public Property QA_ID() As Integer
            Get
                Return mvarQA_ID
            End Get
            Set(ByVal Value As Integer)
                mvarQA_ID = Value
            End Set
        End Property

        Public Property QA_Line_ID() As Integer
            Get
                Return mvarQA_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarQA_Line_ID = Value
            End Set
        End Property

        Public Property WO_Line_ID() As Integer
            Get
                Return mvarWO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWO_Line_ID = Value
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

        Public Property BalQty() As Integer
            Get
                Return mvarQtyBal
            End Get
            Set(ByVal Value As Integer)
                mvarQtyBal = Value
            End Set
        End Property

        Public Property ExpComplDateWO_Line_ID() As Integer
            Get
                Return mvarExpComplDateWO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarExpComplDateWO_Line_ID = Value
            End Set
        End Property

        Public Property Inspected() As Integer
            Get
                Return mvarInspected
            End Get
            Set(ByVal Value As Integer)
                mvarInspected = Value
            End Set
        End Property

        Public Property InspectedQty() As Integer
            Get
                Return mvarInspectedQty
            End Get
            Set(ByVal Value As Integer)
                mvarInspectedQty = Value
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

        Public Property UserID() As String
            Get
                Return mvarUserID
            End Get
            Set(ByVal Value As String)
                mvarUserID = Value
            End Set
        End Property
#End Region

    End Class


End Namespace

