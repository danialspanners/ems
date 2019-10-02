Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace WorkOrderBusRules

    Public Class WorkLogicBusLogic

        Private mvarQuotation_Line_ID As Integer

#Region " Work Order Header Variable "
        Private mvarWO_ID As Integer
        Private mvarWO_NO As String
        Private mvarConfirm_Quotation_NO As String
        Private mvarStatus As String
        Private mvarWO_Date As String
        Private mvarCust_PO As String
        Private mvarPO_Date As String
        Private mvarCollect_Mode As String
        Private mvarCustomer_ID As Integer
        Private mvarContact_ID As Integer
        Private mvarProjectSub As String
        Private mvarProject As String
        Private mvarNotes As String
        Private mvarRevRefWOID As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Work Order Line Variable"
        Private mvarWO_Line_ID As Integer
        Private mvarWO_ItemNo As Integer
        Private mvarBox As String
        Private mvarHeight As Integer
        Private mvarWidth As Integer
        Private mvarDepth As Integer
        Private mvarKey_Type As String
        Private mvarColor As String
        Private mvarMaterial As String
        Private mvarDraw_No As String
        Private mvarQty As Integer
        Private mvarNote As String
        Private mvarCompl_Date As String
        Private mvarExpected_Compl_Date As String
        Private mvarQty_Compl As Integer
        Private mvarQty_Bal As Integer
        Private mvarWorkStatus As String
        Private mvarQAStatus As String
        Private mvarDOStatus As String
        Private mvarDO_No As String
#End Region

#Region " Work Order Line Drawing No Variable"
        Private mvarDrawingNoWO_Line_ID As Integer
        Private mvarDrawingNoDraw_No_ID As Integer
        Private mvarDrawingNoDraw_ID As Integer
        Private mvarDrawNoWO_ID As Integer
#End Region

#Region " Work Order Line Expected Completion Date Variable"
        Private mvarExpComplDateWO_Line_ID As Integer
        Private mvarExpComplDate_ID As Integer
        Private mvarExpComplDate_Compl_Date As String
        Private mvarExpComplDate_Compl_Qty As Integer
        Private mvarExpComplDate_Compl_Qty_Bal As Integer
        Private mvarExpComplDate_Compl_Note As String
        Private mvarExpComplDate_Compl_Status As String
        Private mvarExpComplDate_Exp_Compl_Date As String
#End Region

#Region "Work Order Line Component Variable"
        Private mvarWO_Component_ID As Integer
        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarUnitPrice As Decimal
        Private mvarLead_Time As String
        Private mvarCompQty As Integer
        Private mvarBalance_Qty As Integer
#End Region



#Region " Function for Revised WO"
        Public Function IsRevisedWO(ByRef dsSub As DataSet) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT RevRefWOID FROM WorkOrderHeader "
            If mvarWO_ID > 0 Then
                SQLstr = SQLstr & " WHERE WO_ID = " & mvarWO_ID
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If Not IsDBNull(ds.Tables(0).Rows(0)("RevRefWOID")) Then
                        If ds.Tables(0).Rows(0)("RevRefWOID") = 0 Then
                            Return False
                        Else
                            Dim SubSQLStr As String = "SELECT WO_ID,WO_NO FROM WorkOrderHeader "
                            SubSQLStr = SubSQLStr & " WHERE WO_ID = " & ds.Tables(0).Rows(0)("RevRefWOID")

                            If .GetDataSet(dsSub, SubSQLStr) Then
                                Return True
                            End If

                        End If
                    Else
                        Return False
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function CountNoOfRevisedWO() As Integer
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT COUNT(*) FROM WorkOrderHeader "
            SQLstr = SQLstr & " WHERE RevRefWOID = " & mvarRevRefWOID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        'If ds.Tables(0).Rows(0)(0) = 0 Then
                        'CountNoOfRevisedWO = 1
                        'Else
                        CountNoOfRevisedWO = ds.Tables(0).Rows(0)(0) + 1
                        'End If
                    Else
                        CountNoOfRevisedWO = 1
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function CheckExistingWONo() As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT WO_NO FROM WorkOrderHeader "
            SQLstr = SQLstr & " WHERE WO_NO = '" & mvarWO_NO & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True            'return false if quotation exist
                    Else
                        Return False
                    End If
                End If
            End With
        End Function
#End Region

#Region " Work Order Header SELECT Statement "
        Public Function GetWOHeader(ByRef ds As DataSet, Optional ByVal pWO_ID As Long = 0, Optional ByVal pStatus As String = "") As Boolean
            Dim SQLStr As String
            If pWO_ID > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT WO.*, C.Name as CustomerName, c.Initial ,UP.Login_ID FROM WorkOrderHeader WO LEFT JOIN Customer C "
                SQLStr = SQLStr & " ON (WO.Customer_ID = C.Customer_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (WO.UserId=UP.User_Id)"
                SQLStr = SQLStr & " WHERE WO_ID = " & pWO_ID
                SQLStr = SQLStr & " AND (HistoryRecord IS NULL OR HistoryRecord = '0')  "
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT WO.*, C.Name as CustomerName, c.Initial,UP.Login_ID FROM WorkOrderHeader WO LEFT JOIN Customer C "
                SQLStr = SQLStr & " ON (WO.Customer_ID = C.Customer_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (WO.UserId=UP.User_Id)"
                SQLStr = SQLStr & " WHERE (HistoryRecord IS NULL OR HistoryRecord = '0') "
            End If

            If Len(pStatus) > 0 Then
                SQLStr = SQLStr & " AND WO.Status = '" & pStatus & "'"
            End If

            SQLStr = SQLStr & " Order by WO_Date Desc"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                Else : Return False
                End If
            End With
        End Function

        Public Function IsRevisedWorkOrder(ByRef dsSub As DataSet) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT RevRefWOID FROM WorkOrderHeader "
            SQLstr = SQLstr & " WHERE WO_ID = " & mvarWO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If Not IsDBNull(ds.Tables(0).Rows(0)("RevRefWOID")) Then
                        If ds.Tables(0).Rows(0)("RevRefWOID") = 0 Then
                            Return False
                        Else
                            Dim SubSQLStr As String = "SELECT WO_ID,WO_No FROM WorkOrderHeader "
                            SubSQLStr = SubSQLStr & " WHERE WO_ID = " & ds.Tables(0).Rows(0)("RevRefWOID")

                            If .GetDataSet(dsSub, SubSQLStr) Then
                                Return True
                            End If

                        End If
                    Else
                        Return False
                    End If
                End If
            End With
            ds.Dispose()
        End Function
        '09.11.2003 YG Start
        Public Function IsWorkOrderCreated(ByVal pConfirm_Quotation_No As String) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT * FROM WorkOrderHeader "
            SQLstr = SQLstr & " WHERE Confirm_Quotation_No = '" & pConfirm_Quotation_No & "' and historyrecord is null"
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
        '09.11.2003 YG End
#End Region

#Region " Work Order Header SAVE Statement "
        'Initial saving. To get the WO_ID
        Public Function SaveWONo() As Boolean
            Dim dsWO As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO WorkOrderHeader "
                SQLstr = SQLstr & "(WO_No, "

                If Len(mvarConfirm_Quotation_NO) > 0 Then
                    SQLstr = SQLstr & " Confirm_Quotation_No, "
                End If

                SQLstr = SQLstr & " Status, Create_Date,Transact_Date,UserID) "

                SQLstr = SQLstr & " VALUES ('" & mvarWO_NO & "',"

                If Len(mvarConfirm_Quotation_NO) > 0 Then
                    SQLstr = SQLstr & "'" & mvarConfirm_Quotation_NO & "', "
                End If

                SQLstr = SQLstr & "'" & mvarStatus & "',"
                SQLstr = SQLstr & " Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as Quotation_ID FROM QuotationHeader"

                If .GetDataSet(dsWO, SQLstr) Then
                    If dsWO.Tables(0).Rows.Count > 0 Then
                        mvarWO_ID = dsWO.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                dsWO.Dispose()
            End With
        End Function
#End Region

#Region " Work Order Header UPDATE Statement "
        'Final saving.
        Public Function UpdateWOHeader() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;UPDATE WorkOrderHeader SET "

                If Len(mvarConfirm_Quotation_NO) > 0 Then
                    SQLstr = SQLstr & " Confirm_Quotation_NO = '" & mvarConfirm_Quotation_NO & "',"
                End If

                SQLstr = SQLstr & " Status = '" & mvarStatus & "',"

                If Len(mvarWO_Date) > 0 Then
                    SQLstr = SQLstr & " WO_Date = '" & mvarWO_Date & "',"
                End If

                SQLstr = SQLstr & " Cust_PO = '" & mvarCust_PO & "',"
                SQLstr = SQLstr & " PO_Date = '" & mvarPO_Date & "',"

                If Len(mvarCollect_Mode) > 0 Then
                    SQLstr = SQLstr & " Collect_Mode = '" & mvarCollect_Mode & "',"
                Else
                    SQLstr = SQLstr & " Collect_Mode = NULL,"
                End If

                If Len(mvarCustomer_ID) > 0 Then
                    SQLstr = SQLstr & " Customer_ID = " & mvarCustomer_ID & ","
                End If
                If Len(mvarContact_ID) > 0 Then
                    SQLstr = SQLstr & " Contact_ID = " & mvarContact_ID & ","
                End If
                If Len(mvarProjectSub) > 0 Then
                    SQLstr = SQLstr & " ProjectSub = '" & mvarProjectSub & "',"
                End If
                If Len(mvarProject) > 0 Then
                    SQLstr = SQLstr & " Project = '" & Replace(mvarProject, "'", "''") & "',"
                End If

                If Len(mvarNotes) > 0 Then
                    SQLstr = SQLstr & " Notes = '" & mvarNotes & "',"
                Else
                    SQLstr = SQLstr & " Notes = NULL,"
                End If

                If Len(mvarRevRefWOID) > 0 Then
                    SQLstr = SQLstr & " RevRefWOID = " & mvarRevRefWOID & ","
                End If

                SQLstr = SQLstr & " Transact_Date = GetDate () ,"
                SQLstr = SQLstr & " UserID = " & UserID & " WHERE "
                SQLstr = SQLstr & "WO_ID = " & mvarWO_ID

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateWOHeaderStatus() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "UPDATE WorkOrderHeader SET "
            SQLStr = SQLStr & " Status = " & mvarStatus
            SQLStr = SQLStr & " ,UserID = " & mvarUserID
            SQLStr = SQLStr & " ,Transact_Date = GetDate() "
            SQLStr = SQLStr & " WHERE WO_ID = " & mvarWO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region


#Region " Work Order Line SQL SELECT Statement"
        Public Function GetWOLine(ByRef ds As DataSet)
            Dim SQlStr As String = "SELECT * FROM WorkOrderLine WHERE"
            'If mvarWO_ID > 0 Then
            SQlStr = SQlStr & " WO_ID = " & mvarWO_ID
            'End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWOLine_ByWOLineID(ByRef ds As DataSet)
            Dim SQlStr As String = "SELECT * FROM WorkOrderLine "
            SQlStr = SQlStr & " where WO_Line_ID = " & mvarWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWOLineWithWorkDone(ByRef ds As DataSet)
            Dim SQlStr As String = "SELECT * FROM WorkOrderLine WHERE  "
            SQlStr = SQlStr & " WO_ID = " & mvarWO_ID & " AND WorkStatus = '1' "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWOLineCompletionDate(ByRef ds As DataSet)
            Dim SQLStr As String = "SELECT w1.Box AS Box, w1.Qty AS Qty, w1.Qty_Bal AS Qty_Bal, w1.Qty_Compl AS Qty_Compl, "
            SQLStr = SQLStr & " w1.workstatus, w1.Qty, w1.Expected_Compl_Date, w1.Note, w2.*"
            'SQLStr = SQLStr & " w1.* "
            SQLStr = SQLStr & " FROM WorkOrderLine w1 INNER JOIN"
            SQLStr = SQLStr & " WorkOrderLineCompletionDate w2 ON w1.WO_Line_ID = w2.WO_Line_ID"
            SQLStr = SQLStr & " WHERE (w1.WO_ID = " & mvarWO_ID & ")"  '& " and w2.Compl_Status<>'1' )"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWOLineComplDateHeader(ByRef ds As DataSet, Optional ByVal pWO_ID As Long = 0, Optional ByVal pStatus As String = "") As Boolean
            Dim SQLStr As String
            If pWO_ID > 0 Then
                SQLStr = SQLStr & "SET DATEFORMAT dmy;SELECT WO.*, WOLine.WorkStatus AS ws "
                SQLStr = SQLStr & "FROM WorkOrderHeader WO INNER JOIN "
                SQLStr = SQLStr & "WorkOrderLine WOLine ON WO.WO_ID = WOLine.WO_ID WHERE (WO.HistoryRecord IS NULL OR "
                SQLStr = SQLStr & "WO.HistoryRecord = '0') AND (WOLine.WorkStatus IS NULL OR WOLine.WorkStatus = '0') And WO.WO_ID=" & pWO_ID
            Else
                SQLStr = SQLStr & "SET DATEFORMAT dmy;SELECT WO.*, WOLine.WorkStatus AS ws "
                SQLStr = SQLStr & "FROM WorkOrderHeader WO INNER JOIN "
                SQLStr = SQLStr & "WorkOrderLine WOLine ON WO.WO_ID = WOLine.WO_ID WHERE (WO.HistoryRecord IS NULL OR "
                SQLStr = SQLStr & "WO.HistoryRecord = '0') AND (WOLine.WorkStatus IS NULL OR WOLine.WorkStatus = '0') "
            End If

            If Len(pStatus) > 0 Then
                SQLStr = SQLStr & " AND WO.Status = '" & pStatus & "'"
            End If

            SQLStr = SQLStr & " Order by WO_Date Desc"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                Else : Return False
                End If
            End With
        End Function
#End Region

#Region " Work Order Line SAVE Statement"
        Public Function SaveWOLineFirstTime() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO WorkOrderLine "
            SQLStr = SQLStr & "(WO_ID, WO_ItemNo, Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarWO_ID & "," & mvarWO_ItemNo & ","
            SQLStr = SQLStr & " GetDate(),GetDate()," & mvarUserID & ")"
            SQLStr = SQLStr & ";SELECT @@identity as WO_Line_ID FROM WorkOrderLine"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarWO_Line_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " WOrk Order Line UPDATE Statement"
        Public Function UpdateWOLine()
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT dmy;Update WorkOrderLine SET "
            SQLStr = SQLStr & " Box = '" & mvarBox & "',"
            SQLStr = SQLStr & " Height = " & mvarHeight & ","
            SQLStr = SQLStr & " Width = " & mvarWidth & ","
            SQLStr = SQLStr & " Depth = " & mvarDepth & ","

            If Len(mvarKey_Type) > 0 Then
                SQLStr = SQLStr & " Key_Type ='" & mvarKey_Type & "',"
            End If

            If Len(mvarColor) > 0 Then
                SQLStr = SQLStr & " Color ='" & mvarColor & "',"
            End If

            If Len(mvarMaterial) > 0 Then
                SQLStr = SQLStr & " Material ='" & mvarMaterial & "',"
            End If

            If Len(mvarDraw_No) > 0 Then
                SQLStr = SQLStr & " Draw_No ='" & mvarDraw_No & "',"
            End If

            If Len(mvarWorkStatus) > 0 Then
                SQLStr = SQLStr & " WorkStatus ='" & mvarWorkStatus & "',"
            Else
                SQLStr = SQLStr & " WorkStatus =NULL,"
            End If

            SQLStr = SQLStr & " Qty = " & mvarQty & ","

            If Len(mvarNote) > 0 Then
                SQLStr = SQLStr & " Note ='" & Replace(mvarNote, "'", "''") & "',"
            End If

            If Len(mvarCompl_Date) > 0 Then
                SQLStr = SQLStr & " Compl_Date ='" & mvarCompl_Date & "',"
            Else
                SQLStr = SQLStr & " Compl_Date = NULL,"
            End If

            If Len(mvarExpected_Compl_Date) > 0 Then
                SQLStr = SQLStr & " Expected_Compl_Date ='" & mvarExpected_Compl_Date & "',"
            Else
                SQLStr = SQLStr & " Expected_Compl_Date = NULL,"
            End If

            If Len(mvarQty_Compl) > 0 Then
                SQLStr = SQLStr & " Qty_Compl = " & mvarQty_Compl & ","
            End If

            If Len(mvarQty_Bal) > 0 Then
                SQLStr = SQLStr & " Qty_Bal ='" & mvarQty_Bal & "',"
            End If

            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
            SQLStr = SQLStr & " WHERE WO_Line_ID = " & mvarWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function UpdateWorkStatus()
            Dim ds As DataSet
            Dim SQLStr As String = "Update WorkOrderLine SET "
            If Len(mvarWorkStatus) > 0 Then
                SQLStr = SQLStr & " WorkStatus = '" & mvarWorkStatus & "',"
            Else
                SQLStr = SQLStr & " WorkStatus = NULL,"
            End If

            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = " & mvarUserID & "  "
            SQLStr = SQLStr & " WHERE WO_Line_ID = " & mvarWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function UpdateQAStatus()
            Dim ds As DataSet
            Dim SQLStr As String = "Update WorkOrderLine SET "

            If Len(mvarQAStatus) > 0 Then
                SQLStr = SQLStr & " QAStatus = '" & mvarQAStatus & "',"
            Else
                SQLStr = SQLStr & " QAStatus = NULL,"
            End If

            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = " & mvarUserID & "  "
            SQLStr = SQLStr & " WHERE WO_Line_ID = " & mvarWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region

#Region " Work Order Line DELETE Statement"
        Public Function DeleteWOLine() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "DELETE FROM WorkOrderLine WHERE WO_Line_ID = " & mvarWO_Line_ID

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " WOrk Order Line Completion Date UPDATE Statement"
        Public Function UpdateWOLineComplDate()
            Dim ds As DataSet
            Dim SQLStr As String = "Update WorkOrderLineCompletionDate SET "
            If Len(mvarCompl_Date) > 0 Then
                'SQLStr = SQLStr & " Compl_Date ='" & Replace(mvarExpComplDate_Compl_Date, "'", "''") & "',"
                'Else
                SQLStr = SQLStr & " Compl_Date = GetDate(),"
            End If
            SQLStr = SQLStr & " Compl_Qty_Bal =" & mvarExpComplDate_Compl_Qty_Bal & ","
            SQLStr = SQLStr & " Compl_Status = '" & mvarExpComplDate_Compl_Status & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
            SQLStr = SQLStr & " WHERE WOLineComplDateID = " & mvarExpComplDateWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region

#Region " Work Order Line Drawing No SQL SELECT Statement"
        Public Function GetWOLineDrawingNo(ByRef ds As DataSet)
            Dim SQlStr As String = "SELECT w.*, d.drawing_no + d.drawing_type as drawing_no "
            SQlStr = SQlStr & "FROM WorkOrderLineDrawingNo w Inner Join drawingNo d "
            SQlStr = SQlStr & "ON w.Draw_No_ID = d.Drawing_ID "
            'If mvarDrawingNoWO_Line_ID > 0 Then
            SQlStr = SQlStr & "and w.WO_Line_ID = " & mvarDrawingNoWO_Line_ID
            'End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWOLineDrawingNo(ByRef ds As DataSet, ByVal WOId As String)
            Dim SQlStr As String = "SELECT * FROM WorkOrderLineDrawingNo WHERE"

            SQlStr = SQlStr & " WO_ID = " & WOId

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function

#End Region
#Region " Work Order Line Drawing No SAVE/Update/Delete Statement"
        Public Function SaveWOLineDrawingNo() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO WorkOrderLineDrawingNo "
            SQLStr = SQLStr & "(WO_Line_ID, Draw_No_ID, WO_ID, Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarDrawingNoWO_Line_ID & "," & mvarDrawingNoDraw_No_ID & "," & mvarDrawNoWO_ID & ","
            SQLStr = SQLStr & " GetDate(),GetDate(), '" & mvarUserID & "')"
            SQLStr = SQLStr & ";SELECT @@identity as WOLineDrawID FROM WorkOrderLineDrawingNo"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarDrawingNoDraw_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteWOLineDrawingNO() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM WorkOrderLineDrawingNo "
            SQLStr = SQLStr & " where WO_Line_ID=" & mvarDrawingNoWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                Else
                    Return False
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteWOLineDrawingNo(ByVal drawid As Integer) As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM WorkOrderLineDrawingNo "
            SQLStr = SQLStr & " where WOLineDrawID=" & drawid

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                Else
                    Return False
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateWOLineDrawingNO()
            Dim ds As DataSet
            Dim SQLStr As String = "Update WorkOrderLineDrawingNo SET "
            SQLStr = SQLStr & " Draw_No_ID = " & mvarDrawingNoDraw_No_ID & ","
            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
            SQLStr = SQLStr & " WHERE WOLineDrawID = " & mvarDrawingNoDraw_ID
            SQLStr = SQLStr & " and WO_ID=" & mvarDrawNoWO_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region

#Region " Work Order Line Expected Completion Date SQL SELECT Statement"
        Public Function GetWOLineExpComplDate(ByRef ds As DataSet)
            Dim SQlStr As String = "SELECT * FROM WorkOrderLineCompletionDate WHERE"

            SQlStr = SQlStr & " WO_Line_ID = " & mvarExpComplDateWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Work Order Line Exp Completion Date SAVE/Update/Delete Statement"
        Public Function SaveWOLineExpComplDate() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT dmy;INSERT INTO WorkOrderLineCompletionDate "
            SQLStr = SQLStr & "(WO_Line_ID, Exp_Compl_Date, Compl_Qty, Compl_Qty_Bal, Compl_Note, Compl_Status, Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarExpComplDateWO_Line_ID & ",'" & Replace(mvarExpComplDate_Exp_Compl_Date, "'", "''") & "'," & mvarExpComplDate_Compl_Qty & ","
            SQLStr = SQLStr & mvarExpComplDate_Compl_Qty_Bal & ",'" & mvarExpComplDate_Compl_Note & "','" & mvarExpComplDate_Compl_Status & "',"
            SQLStr = SQLStr & " GetDate(),GetDate(), '" & mvarUserID & "')"
            SQLStr = SQLStr & ";SELECT @@identity as WOLineComplDateID FROM WorkOrderLineCompletionDate"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarExpComplDate_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteWOLineExpComplDate() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM WorkOrderLineCompletionDate "
            SQLStr = SQLStr & " where WO_Line_ID=" & mvarExpComplDateWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                Else
                    Return False
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteWOLineExpComplDate(ByVal drawid As Integer) As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM WorkOrderLineCompletionDate "
            SQLStr = SQLStr & " where WOLineComplDateID=" & drawid

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                Else
                    Return False
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateWOLineExpComplDate()
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT dmy;Update WorkOrderLineCompletionDate SET "
            SQLStr = SQLStr & " Exp_Compl_Date = '" & mvarExpComplDate_Exp_Compl_Date & "',"
            SQLStr = SQLStr & " Compl_Qty =" & mvarExpComplDate_Compl_Qty & ","
            SQLStr = SQLStr & " Compl_Qty_Bal =" & mvarExpComplDate_Compl_Qty_Bal & ","
            SQLStr = SQLStr & " Compl_Note ='" & mvarExpComplDate_Compl_Note & "',"
            SQLStr = SQLStr & " Compl_Status ='" & mvarExpComplDate_Compl_Status & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
            SQLStr = SQLStr & " WHERE WOLineComplDateID = " & mvarExpComplDate_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region

#Region " Work Order Line Component SELECT Statement "
        Public Function GetWOLineCompOnLineID(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String = "SELECT WO.*, P.Name,P.Brand,P.Description "
            SQLStr = SQLStr & " FROM WorkOrderLineComponent WO JOIN "
            SQLStr = SQLStr & " Product P ON (WO.Product_ID = P.Product_ID) "
            SQLStr = SQLStr & " WHERE WO.WO_Line_ID = " & mvarWO_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Work Order Line Component SAVE Statement"
        Public Function SaveWOLineComponent() As Boolean
            Dim dsWOLineCom As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO WorkOrderLineComponent "
                SQLstr = SQLstr & "(WO_ID, WO_Line_ID, Category_ID, Product_ID, "
                SQLstr = SQLstr & "Supplier_ID, UnitPrice, Qty, BalanceQty, Lead_Time, Create_Date, "
                SQLstr = SQLstr & "Transact_Date, UserID) VALUES "
                SQLstr = SQLstr & "(" & mvarWO_ID & "," & mvarWO_Line_ID & ","
                SQLstr = SQLstr & mvarCategory_ID & "," & mvarProduct_ID & "," & mvarSupplier_ID & ","
                SQLstr = SQLstr & mvarUnitPrice & "," & mvarCompQty & "," & mvarBalance_Qty & ",'" & mvarLead_Time & "',"
                SQLstr = SQLstr & "GetDate(),GetDate(), " & mvarUserID & ")"

                If .GetDataSet(dsWOLineCom, SQLstr) Then
                    Return True
                End If
                dsWOLineCom.Dispose()
            End With
        End Function
#End Region

#Region " Work Order Line Component UPDATE Statement"
        Public Function UpdateWOComponent()
            Dim ds As DataSet
            Dim SQLstr As String = "UPDATE WorkOrderLineComponent SET "
            SQLstr = SQLstr & "UnitPrice = " & mvarUnitPrice & ","
            SQLstr = SQLstr & "Qty = " & mvarCompQty & ","
            SQLstr = SQLstr & "Transact_Date = GetDate(),"
            SQLstr = SQLstr & "UserID = " & mvarUserID & " WHERE WO_Component_ID = " & mvarWO_Component_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region

#Region " Work Order Line Component DELETE Statement "
        Public Function DeleteWOLineComponent() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM WorkOrderLineComponent "
                SQLStr = SQLStr & " WHERE WO_Component_ID = " & mvarWO_Component_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region


        '*** WO Report ***
#Region " Work Order Report "
        Public Function GetWorkOrderRpt(ByRef ds As DataSet, ByVal pWO_ID As String, _
                                        ByVal pWOTitle As String)
            Dim SQLStr As String

			SQLStr = "SELECT *, d.Name as CustName, KeyTypes.Key_Name as KeyCode,Color.Color_Name as Colorname, e.Tel as Tel, materials.Materialdesc as MaterialName, e.Name as ContactPerson, h.Project_Name, "
            SQLStr = SQLStr & "'" & pWOTitle & "' as WOTitle, i.Drawing_No "
            SQLStr = SQLStr & " FROM WorkOrderHeader a INNER JOIN "
            SQLStr = SQLStr & " WorkOrderLine b ON a.WO_ID = b.WO_ID "
            'SQLStr = SQLStr & " LEFT JOIN WorkOrderLineComponent c ON b.WO_Line_ID = c.WO_Line_ID "
            SQLStr = SQLStr & " LEFT JOIN Customer d on (a.customer_id = d.customer_id) "
            SQLStr = SQLStr & " LEFT JOIN customerContact e on (a.contact_id = e.contact_id) "
            'SQLStr = SQLStr & " LEFT JOIN Product f on (c.product_id = f.product_id) "
            SQLStr = SQLStr & " LEFT JOIN Project h on (a.Project = h.Project_ID) "
            SQLStr = SQLStr & " LEFT JOIN DrawingNo i on (b.Draw_No = i.Drawing_ID) "
			SQLStr = SQLStr & " LEFT JOIN Color on (b.Color = Color.Color_ID) "
			SQLStr = SQLStr & " LEFT JOIN KeyTypes on (b.Key_Type = KeyTypes.Key_ID) "
			SQLStr = SQLStr & " LEFT JOIN Materials on (b.Material = Materials.Material_ID) "
            SQLStr = SQLStr & " WHERE(a.WO_ID = " & pWO_ID & ")"

			With New DataAccess.DAccess.Access
                Try
                    If .GetDataSet(ds, SQLStr) Then
                        Return True
                    End If
                Catch ex As System.Exception

                End Try
            End With
        End Function
#End Region
        '*******

#Region " Work Order On Time Delivery Report "
        Public Function GetWOOnTimeReport(ByRef ds As DataSet)
            Dim SQLStr As String

            '            SQLStr = "SET DATEFORMAT dmy;select supplier_name, PO_No, shipment_date, max(transact_date) as delivered_date "
            '            SQLStr = SQLStr & " from v_supplier_ontime "
            '            SQLStr = SQLStr & " group by Supplier_Name, PO_NO, shipment_date"
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region


#Region " DELETE Work Order "
        Public Function DeleteOneWorkOrder() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                'Dim SQLstr As String = "DELETE FROM WorkOrderLineComponent WHERE WO_ID = " & mvarWO_ID
                'SQLstr = SQLstr & ";DELETE FROM WorkOrderLine WHERE WO_ID = " & mvarWO_ID
                'SQLstr = SQLstr & ";DELETE FROM WorkOrderHeader WHERE WO_ID = " & mvarWO_ID
                Dim SQLStr As String = "UPDATE WorkOrderLineComponent SET "
                SQLStr = SQLStr & " HistoryRecord = '1', Transact_Date = GetDate(), UserID = " & mvarUserID
                SQLStr = SQLStr & " WHERE WO_ID = " & mvarWO_ID
                SQLStr = SQLStr & ";UPDATE WorkOrderLine SET "
                SQLStr = SQLStr & " HistoryRecord = '1', Transact_Date = GetDate(), UserID = " & mvarUserID
                SQLStr = SQLStr & " WHERE WO_ID = " & mvarWO_ID
                SQLStr = SQLStr & ";UPDATE WorkOrderHeader SET "
                SQLStr = SQLStr & " HistoryRecord = '1', Transact_Date = GetDate(), UserID = " & mvarUserID
                SQLStr = SQLStr & " WHERE WO_ID = " & mvarWO_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region


#Region " QA SELECT Statement "
        Public Function GetQAHeader(ByRef ds As DataSet, Optional ByVal pWO_ID As String = "") As Boolean
            Dim SQLStr As String

            SQLStr = "SELECT a.WO_ID, a.WO_No, a.WO_Date, a.Status,a.ProjectSub, a.Project, c.Name as CustomerName, c.Initial, b.wo_line_id "
            SQLStr = SQLStr & "FROM WorkOrderHeader a LEFT OUTER JOIN "
            SQLStr = SQLStr & "WorkOrderLine b ON a.WO_ID = b.WO_ID LEFT OUTER JOIN "
            SQLStr = SQLStr & "Customer c ON c.Customer_ID = a.Customer_ID "
            SQLStr = SQLStr & "WHERE " '(b.WorkStatus = '1')"
            SQLStr = SQLStr & "EXISTS (SELECT * FROM qa q WHERE q.wo_line_id = b.wo_line_id)"

            If Len(pWO_ID) > 0 Then
                SQLStr = SQLStr & " AND WO_ID =" & pWO_ID
            End If

            SQLStr = SQLStr & " GROUP BY a.WO_ID, a.WO_No, a.WO_Date, a.Status, a.ProjectSub, a.Project, c.Name, c.Initial, b.wo_line_id "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

#Region " DO SELECT Statement"
        Public Function GetDOListing(ByRef ds As DataSet, Optional ByVal pWO_ID As String = "") As Boolean
            Dim SQLStr As String

            SQLStr = "SELECT a.WO_ID, a.WO_No, a.WO_Date, a.Status, a.ProjectSub, a.Project, c.Name as CustomerName, c.Initial, QA.WO_Line_ID, QA.Inspected, QA.Qty "
            SQLStr = SQLStr & "FROM QA Inner Join WorkOrderLine b ON QA.WO_Line_ID = b.WO_Line_ID RIGHT OUTER JOIN "
            SQLStr = SQLStr & "WorkOrderHeader a ON b.WO_ID = a.WO_ID LEFT OUTER JOIN "
            SQLStr = SQLStr & "Customer c ON c.Customer_ID = a.Customer_ID "
            SQLStr = SQLStr & "WHERE (a.HistoryRecord IS NULL OR a.HistoryRecord = '0') AND (QA.Inspected = '1') " ' AND (b.QAStatus = '1')"

            If Len(pWO_ID) > 0 Then
                SQLStr = SQLStr & " AND WO_ID =" & pWO_ID
            End If

            SQLStr = SQLStr & " GROUP BY a.WO_ID, a.WO_No, a.WO_Date, a.Status, a.ProjectSub, a.Project, c.Name, c.Initial, QA.WO_Line_ID, QA.Inspected, QA.Qty "
            SQLStr = SQLStr & " Order by a.WO_Date DESC"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDOLine(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String

            'SQLStr = "SELECT b.* FROM QuotationHeader a Left Join QuotationLine b ON "
            'SQLStr = SQLStr & " (a.Quotation_ID = b.Quotation_ID) WHERE "
            'SQLStr = SQLStr & " Confirm_Quotation_NO = '" & mvarConfirm_Quotation_NO & "'"

            SQLStr = SQLStr & "SELECT b.*, c.WO_ITEMNO as WO_ITEMNO, d.*, d.qty as qaqty FROM QA d Inner Join workorderline c on d.wo_line_id=c.wo_line_id cross join QuotationHeader a Left outer JOIN QuotationLine b ON "
            SQLStr = SQLStr & " (a.Quotation_ID = b.Quotation_ID) WHERE "
            SQLStr = SQLStr & " (a.Confirm_Quotation_NO = '" & mvarConfirm_Quotation_NO & "') "
            SQLStr = SQLStr & " AND d.inspected=1 AND c.WO_ID=" & mvarWO_ID
            'SQLStr = SQLStr & " AND (b.ItemNo IN "
            'SQLStr = SQLStr & " (SELECT WO_ItemNo FROM WorkOrderLine "
            'SQLStr = SQLStr & " WHERE (WO_ID = " & mvarWO_ID & ")))"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDOComponent(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String

            SQLStr = "SELECT b.*,c.Name, c.Brand, c.Description FROM QuotationHeader a "
            SQLStr = SQLStr & " Left Join QuotationLineComponent b ON "
            SQLStr = SQLStr & " (a.Quotation_ID = b.Quotation_ID) LEFT JOIN "
            SQLStr = SQLStr & " Product c ON (b.Product_ID = c.Product_ID) WHERE "
            SQLStr = SQLStr & " b.Quotation_Line_ID = " & mvarQuotation_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDOStatus() As Boolean
            Dim SQLStr As String
            Dim ds As DataSet

            SQLStr = "SELECT DOStatus FROM WorkOrderLine "
            SQLStr = SQLStr & " WHERE WO_ID = " & mvarWO_ID & " AND WO_ItemNo = " & mvarWO_ItemNo

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If Not ds.Tables(0).Rows.Count = 0 Then
                        If Not IsDBNull(ds.Tables(0).Rows(0)("DOStatus")) Then
                            If ds.Tables(0).Rows(0)("DOStatus") = "1" Then
                                Return True
                            Else
                                Return False
                            End If
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetDONo() As String
            Dim SQLStr As String
            Dim ds As DataSet

            SQLStr = "SELECT DO_No FROM WorkOrderLine "
            SQLStr = SQLStr & " WHERE WO_ID = " & mvarWO_ID & " AND WO_ItemNo = " & mvarWO_ItemNo

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If Not ds.Tables(0).Rows.Count = 0 Then
                        If Not IsDBNull(ds.Tables(0).Rows(0)("DO_No")) Then
                            Return ds.Tables(0).Rows(0)("DO_No")
                        Else
                            Return ""
                        End If
                    Else
                        Return ""
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetDOLineFromWO(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String

            SQLStr = SQLStr & " SELECT * FROM WorkOrderLine "
            SQLStr = SQLStr & " WHERE (WO_ID = " & mvarWO_ID & ") AND (QAStatus = '1')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Delivery Order Report n Update DO Status "
        Public Function GetDeliveryOrderRpt(ByRef ds As DataSet, ByVal pStrQuotationLineID As String, _
                                            ByVal pCustomer_ID As Integer, ByVal pContact_ID As Integer, _
                                            ByVal pDeliveryNo As String, ByVal pConfirm_Quotation_No As String, _
                                            ByVal pPayment As Integer) As Boolean
            Dim SQLStr As String
            Dim Contact_Name As String
            Dim Customer_Name As String
            Dim Address As String

            'SQLStr = "SELECT b.*, c.*, d.Name AS productName FROM QuotationHeader a LEFT OUTER JOIN"
            'SQLStr = SQLStr & " QuotationLine b ON a.Quotation_ID = b.Quotation_ID LEFT OUTER JOIN"
            'SQLStr = SQLStr & " QuotationLineComponent c ON b.Quotation_Line_ID = c.Quotation_Line_ID LEFT OUTER JOIN "
            'SQLStr = SQLStr & " Product d ON c.Product_ID = d.Product_ID "
            'SQLStr = SQLStr & " WHERE (a.Confirm_Quotation_NO = 'ST/2003/215-R1') AND (b.ItemNo IN "
            'SQLStr = SQLStr & " (SELECT WO_ItemNo FROM WorkOrderLine "
            'SQLStr = SQLStr & " WHERE WO_ID = 32 AND QAStatus = '1')) "

            SQLStr = "SELECT Name, Address FROM Customer WHERE "
            SQLStr = SQLStr & " Customer_ID = " & pCustomer_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Customer_Name = ds.Tables(0).Rows(0)("Name")
                        Address = ds.Tables(0).Rows(0)("Address")
                    End If
                End If
                ds.Dispose()
            End With

            SQLStr = "SELECT Name FROM CustomerContact WHERE "
            SQLStr = SQLStr & " Contact_ID = " & pContact_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Contact_Name = ds.Tables(0).Rows(0)("Name")
                    End If
                End If
                ds.Dispose()
            End With

            SQLStr = "SELECT a.*, b.*, c.Name AS productName,'" & Customer_Name & "' as CustomerName ,'" & Address & "' as Address,'" & Contact_Name & "' as ContactPerson "
            SQLStr = SQLStr & ",'" & pDeliveryNo & "' as DeliveryNo,'" & pConfirm_Quotation_No & "' as Confirm_Quotation_No, '" & pPayment & "' as Payment "
            SQLStr = SQLStr & " FROM QuotationLine a "
            SQLStr = SQLStr & " LEFT JOIN QuotationLineComponent b ON (a.Quotation_Line_ID = b.Quotation_Line_ID) "
            SQLStr = SQLStr & " LEFT JOIN Product c ON (b.Product_ID = c.Product_ID) "
            SQLStr = SQLStr & " WHERE (a.Quotation_Line_ID IN (" & pStrQuotationLineID & "))"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function UpdateDOStatus()
            Dim ds As DataSet
            Dim SQLStr As String = "Update WorkOrderLine SET "

            If Len(mvarDOStatus) > 0 Then
                SQLStr = SQLStr & " DOStatus = '" & mvarDOStatus & "',"
            Else
                SQLStr = SQLStr & " DOStatus = NULL,"
            End If

            SQLStr = SQLStr & " DO_No = '" & mvarDO_No & "',"

            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = " & mvarUserID & "  "
            SQLStr = SQLStr & " WHERE WO_ID = " & mvarWO_ID & " AND WO_ItemNo = " & mvarWO_ItemNo

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region


#Region " Work Order Header Get and Let Property"
        Public Property WO_ID() As Integer
            Get
                Return mvarWO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWO_ID = Value
            End Set
        End Property

        Public Property WO_No() As String
            Get
                Return mvarWO_NO
            End Get
            Set(ByVal Value As String)
                mvarWO_NO = Value
            End Set
        End Property

        Public Property Confirm_Quotation_No() As String
            Get
                Return mvarConfirm_Quotation_NO
            End Get
            Set(ByVal Value As String)
                mvarConfirm_Quotation_NO = Value
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

        Public Property WO_Date() As String
            Get
                Return mvarWO_Date
            End Get
            Set(ByVal Value As String)
                mvarWO_Date = Value
            End Set
        End Property

        Public Property Cust_PO() As String
            Get
                Return mvarCust_PO
            End Get
            Set(ByVal Value As String)
                mvarCust_PO = Value
            End Set
        End Property

        Public Property PO_Date() As String
            Get
                Return mvarPO_Date
            End Get
            Set(ByVal Value As String)
                mvarPO_Date = Value
            End Set
        End Property

        Public Property Collect_Mode() As String
            Get
                Return mvarCollect_Mode
            End Get
            Set(ByVal Value As String)
                mvarCollect_Mode = Value
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

        Public Property Contact_ID() As Integer
            Get
                Return mvarContact_ID
            End Get
            Set(ByVal Value As Integer)
                mvarContact_ID = Value
            End Set
        End Property

        Public Property ProjectSub() As String
            Get
                Return mvarProjectSub
            End Get
            Set(ByVal Value As String)
                mvarProjectSub = Value
            End Set
        End Property

        Public Property Project() As String
            Get
                Return mvarProject
            End Get
            Set(ByVal Value As String)
                mvarProject = Value
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

        Public Property RevRefWOID() As String
            Get
                Return mvarRevRefWOID
            End Get
            Set(ByVal Value As String)
                mvarRevRefWOID = Value
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

#Region " Work Order Line Get and Let Property"

        Public Property WO_Line_ID() As Integer
            Get
                Return mvarWO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWO_Line_ID = Value
            End Set
        End Property

        Public Property WO_ItemNo() As Integer
            Get
                Return mvarWO_ItemNo
            End Get
            Set(ByVal Value As Integer)
                mvarWO_ItemNo = Value
            End Set
        End Property

        Public Property Box() As String
            Get
                Return mvarBox
            End Get
            Set(ByVal Value As String)
                mvarBox = Value
            End Set
        End Property

        Public Property varHeight() As Integer
            Get
                Return mvarHeight
            End Get
            Set(ByVal Value As Integer)
                mvarHeight = Value
            End Set
        End Property

        Public Property varWidth() As Integer
            Get
                Return mvarWidth
            End Get
            Set(ByVal Value As Integer)
                mvarWidth = Value
            End Set
        End Property

        Public Property Depth() As Integer
            Get
                Return mvarDepth
            End Get
            Set(ByVal Value As Integer)
                mvarDepth = Value
            End Set
        End Property

        Public Property Key_Type() As String
            Get
                Return mvarKey_Type
            End Get
            Set(ByVal Value As String)
                mvarKey_Type = Value
            End Set
        End Property

        Public Property Color() As String
            Get
                Return mvarColor
            End Get
            Set(ByVal Value As String)
                mvarColor = Value
            End Set
        End Property

        Public Property Material() As String
            Get
                Return mvarMaterial
            End Get
            Set(ByVal Value As String)
                mvarMaterial = Value
            End Set
        End Property

        Public Property Draw_No() As String
            Get
                Return mvarDraw_No
            End Get
            Set(ByVal Value As String)
                mvarDraw_No = Value
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

        Public Property Note() As String
            Get
                Return mvarNote
            End Get
            Set(ByVal Value As String)
                mvarNote = Value
            End Set
        End Property

        Public Property Compl_Date() As String
            Get
                Return mvarCompl_Date
            End Get
            Set(ByVal Value As String)
                mvarCompl_Date = Value
            End Set
        End Property

        Public Property Expected_Compl_Date() As String
            Get
                Return mvarExpected_Compl_Date
            End Get
            Set(ByVal Value As String)
                mvarExpected_Compl_Date = Value
            End Set
        End Property

        Public Property Qty_Compl() As Integer
            Get
                Return mvarQty_Compl
            End Get
            Set(ByVal Value As Integer)
                mvarQty_Compl = Value
            End Set
        End Property

        Public Property Qty_Bal() As Integer
            Get
                Return mvarQty_Bal
            End Get
            Set(ByVal Value As Integer)
                mvarQty_Bal = Value
            End Set
        End Property

        Public Property WorkStatus() As String
            Get
                Return mvarWorkStatus
            End Get
            Set(ByVal Value As String)
                mvarWorkStatus = Value
            End Set
        End Property

        Public Property QAStatus() As String
            Get
                Return mvarQAStatus
            End Get
            Set(ByVal Value As String)
                mvarQAStatus = Value
            End Set
        End Property

        Public Property DOStatus() As String
            Get
                Return mvarDOStatus
            End Get
            Set(ByVal Value As String)
                mvarDOStatus = Value
            End Set
        End Property

        Public Property DO_No() As String
            Get
                Return mvarDO_No
            End Get
            Set(ByVal Value As String)
                mvarDO_No = Value
            End Set
        End Property
#End Region

#Region " Work Order Line Drawing No Get and Let Property"
        Public Property DrawingNo_WO_ID() As Integer
            Get
                Return mvarDrawNoWO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDrawNoWO_ID = Value
            End Set
        End Property

        Public Property DrawingNo_Draw_ID() As Integer
            Get
                Return mvarDrawingNoDraw_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDrawingNoDraw_ID = Value
            End Set
        End Property

        Public Property DrawingNo_WO_Line_ID() As Integer
            Get
                Return mvarDrawingNoWO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDrawingNoWO_Line_ID = Value
            End Set
        End Property

        Public Property DrawingNo_Draw_No_ID() As Integer
            Get
                Return mvarDrawingNoDraw_No_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDrawingNoDraw_No_ID = Value
            End Set
        End Property

#End Region

#Region " Work Order Line Expected Completion Date Get and Let Property"

        Public Property ExpComplDate_WO_Line_ID() As Integer
            Get
                Return mvarExpComplDateWO_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarExpComplDateWO_Line_ID = Value
            End Set
        End Property

        Public Property ExpComplDate_ID() As Integer
            Get
                Return mvarExpComplDate_ID
            End Get
            Set(ByVal Value As Integer)
                mvarExpComplDate_ID = Value
            End Set
        End Property
        Public Property ExpComplDate_Exp_Compl_Date() As String
            Get
                Return mvarExpComplDate_Exp_Compl_Date
            End Get
            Set(ByVal Value As String)
                mvarExpComplDate_Exp_Compl_Date = Value
            End Set
        End Property

        Public Property ExpComplDate_Compl_Date() As String
            Get
                Return mvarExpComplDate_Compl_Date
            End Get
            Set(ByVal Value As String)
                mvarExpComplDate_Compl_Date = Value
            End Set
        End Property

        Public Property ExpComplDate_Compl_Qty() As Integer
            Get
                Return mvarExpComplDate_Compl_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarExpComplDate_Compl_Qty = Value
            End Set
        End Property

        Public Property ExpComplDate_Compl_Qty_Bal() As Integer
            Get
                Return mvarExpComplDate_Compl_Qty_Bal
            End Get
            Set(ByVal Value As Integer)
                mvarExpComplDate_Compl_Qty_Bal = Value
            End Set
        End Property

        Public Property ExpComplDate_Compl_Note() As String
            Get
                Return mvarExpComplDate_Compl_Note
            End Get
            Set(ByVal Value As String)
                mvarExpComplDate_Compl_Note = Value
            End Set
        End Property

        Public Property ExpComplDate_Compl_Status() As String
            Get
                Return mvarExpComplDate_Compl_Status
            End Get
            Set(ByVal Value As String)
                mvarExpComplDate_Compl_Status = Value
            End Set
        End Property

#End Region

#Region " Work Order Line Component's Get n Let Property"

        Public Property WO_Component_ID() As Integer
            Get
                Return mvarWO_Component_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWO_Component_ID = Value
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

        Public Property Category_ID() As String
            Get
                Return mvarCategory_ID
            End Get
            Set(ByVal Value As String)
                mvarCategory_ID = Value
            End Set
        End Property

        Public Property Product_ID() As String
            Get
                Return mvarProduct_ID
            End Get
            Set(ByVal Value As String)
                mvarProduct_ID = Value
            End Set
        End Property

        Public Property UnitPrice() As String
            Get
                Return mvarUnitPrice
            End Get
            Set(ByVal Value As String)
                mvarUnitPrice = Value
            End Set
        End Property

        Public Property CompQty() As String
            Get
                Return mvarCompQty
            End Get
            Set(ByVal Value As String)
                mvarCompQty = Value
            End Set
        End Property

        Public Property Lead_Time() As String
            Get
                Return mvarLead_Time
            End Get
            Set(ByVal Value As String)
                mvarLead_Time = Value
            End Set
        End Property

        Public Property BalanceQty() As String
            Get
                Return mvarBalance_Qty
            End Get
            Set(ByVal Value As String)
                mvarBalance_Qty = Value
            End Set
        End Property

#End Region

        Public Property Quotation_Line_ID() As Integer
            Get
                Return mvarQuotation_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarQuotation_Line_ID = Value
            End Set
        End Property

    End Class
End Namespace
