Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace OGBBusRules
    Public Class OGBBusLogic
#Region " Variable "
        Private mvarOGB_IO_Id As Integer
        Private mvarContract_Id As Integer
        Private mvarContractor_Id As Long
        Private mvarIO_No As String
        Private mvarParentIO As String
        Private mvarOfficer_In_Charge_Id As Integer
        Private mvarCounter_Sign_Officer_Id As Integer
        Private mvarOGB_Section As Integer
        Private mvarOGB_Location As String
        Private mvarOGB_Substation As String
        Private mvarIO_Recv_Date As String
        Private mvarCommence_Date As String
        Private mvarCompletion_Date As String
        Private mvarExtend_Commence_Date As String
        Private mvarExtend_Completion_Date As String
        Private mvarInstallation_Date As String
        Private mvarWorkVerification_Date As String
        Private mvarPaymentClaim_Date As String
        Private mvarSerial_No As String
        Private mvarOGB_Plus_Minus As String
        Private mvarTested_Passed_Date As String
        Private mvarOGB_Installed As Integer
        Private mvarOGB_Surveyed As Integer
        Private mvarOGB_OT As Integer
        Private mvarOGB_630ADin As Integer
        Private mvarOGB_Labelled As Integer
        Private mvarFeederLabelled As Integer
        Private mvarMRC_No As String
        Private mvarRedo_Flg As String
        Private mvarRedo_Text As String
        Private mvarOGB1_X As String
        Private mvarOGB2_X As String
        Private mvarOGB1_Y As String
        Private mvarOGB2_Y As String
        Private mvarInvoice_No As String
        Private mvarInvoice_Date As String
        Private mvarLD_Amount As Decimal
        Private mvarNotification_Index As String
        Private mvarDWC_Sent_Date As String
        Private mvarTOC_Return_Date As String
        Private mvarF0028_Recv_Date As String
        Private mvarCollect_Doc_Date As String
        Private mvarRemarks As String
        Private mvarOriginal_IO As String
        Private mvarLegend_Invoice_No As String
        Private mvarDelay_Reason As String
        Private mvarA4_Qty As Integer
        Private mvarMRC_Qty As Integer
        Private mvarLU_Qty As Integer
        Private mvarDate_Completed As String
        Private mvarIndex_No As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
        Private mvarOfficer_Name As String
        Private mvarSection_Code As String
        Private mvarIssues_Flag As Integer
        Private mvarIssues_Detail As String
#End Region

#Region " SELECT "
        Public Function GetOGBNotification(ByRef ds As DataSet, ByVal pContract_Id As Long) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Not pContract_Id = 0 Then
                    SQLStr = "SELECT OGB_IO_ID, Contractor_ID "
                    SQLStr = SQLStr & " FROM OGBPrintNotification "
                    'SQLStr = SQLStr & " inner join OGBFiler b ON a.OGB_IO_ID = b.OGB_IO_Id"
                    SQLStr = SQLStr & " WHERE Contractor_Id = " & Long.Parse(pContract_Id)
                    'Else
                    'SQLStr = "SELECT * FROM OGBFiler where contract_id =" & pContract_Id
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
		End Function

		Public Function GetOGBNotificationDate(ByRef ds As DataSet, ByVal pContract_Id As Long, ByVal pTransactDate As Date) As Boolean
			With New DataAccess.DAccess.Access
				Dim SQLStr As String

				If Not pContract_Id = 0 Then
					SQLStr = "set dateformat dmy;SELECT OGB_IO_ID, Contractor_ID "
					SQLStr = SQLStr & " FROM OGBPrintNotification "
					'SQLStr = SQLStr & " inner join OGBFiler b ON a.OGB_IO_ID = b.OGB_IO_Id"
					SQLStr = SQLStr & " WHERE Contractor_Id = " & Long.Parse(pContract_Id) & " And Transact_Date='" & pTransactDate & "'"
					'Else
					'SQLStr = "SELECT * FROM OGBFiler where contract_id =" & pContract_Id
				End If

				If .GetDataSet(ds, SQLStr) Then
					Return True
				End If
			End With
        End Function

        Public Function GetOGBF28Date(ByRef ds As DataSet, ByVal pContract_Id As Long, ByVal pTransactDate As Date) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Not pContract_Id = 0 Then
                    SQLStr = "set dateformat dmy;SELECT OGB_IO_ID, Contractor_ID "
                    SQLStr = SQLStr & " FROM OGBF28 "
                    'SQLStr = SQLStr & " inner join OGBFiler b ON a.OGB_IO_ID = b.OGB_IO_Id"
                    SQLStr = SQLStr & " WHERE Contractor_Id = " & Long.Parse(pContract_Id) & " And Transact_Date='" & pTransactDate & "'"
                    'Else
                    'SQLStr = "SELECT * FROM OGBFiler where contract_id =" & pContract_Id
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function


        Public Function GetIO(ByRef ds As DataSet, Optional ByVal pOGB_IO_Id As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Not pOGB_IO_Id = 0 Then
                    SQLStr = "SELECT * FROM OGBFiler a LEFT JOIN OGBContract b ON (b.OGB_Contract_Id = a.Contract_Id) "
                    SQLStr = SQLStr & " Left Join OfficerInCharge oc on (a.Officer_In_Charge_Id=oc.Officer_In_Charge_Id) "
                    SQLStr = SQLStr & " Left Join Section s on (oc.Section_Id=s.Section_Id) "
                    SQLStr = SQLStr & " where OGB_IO_Id = " & Integer.Parse(pOGB_IO_Id)
                Else
                    SQLStr = "SELECT * FROM OGBFiler a LEFT JOIN OGBContract b ON (b.OGB_Contract_Id = a.Contract_Id) "
                End If

                SQLStr = SQLStr & " ORDER BY IO_Recv_Date Desc "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetIOWContractId(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM OGBFiler where "
                If mvarOGB_IO_Id <> 0 Then
                    SQLStr = SQLStr & " OGB_IO_ID = " & mvarOGB_IO_Id
                Else
                    SQLStr = SQLStr & " Contract_Id = " & mvarContract_Id
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function


        Public Function GetIOWContractId2(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT a.OGB_IO_id, a.Contract_Id, a.IO_no as IO_no, oc.Officer_Name as 'Officer-in-Charge', b.IO_No as 'Previous I/O' "
                SQLStr = SQLStr & " FROM OGBFiler a  "
                SQLStr = SQLStr & " Left Join OfficerInCharge oc on (a.Officer_In_Charge_Id=oc.Officer_In_Charge_Id)"
                SQLStr = SQLStr & " Left join OGBFiler b on (a.Parent_IO_id = b.OGB_IO_id)"

                SQLStr = SQLStr & " where a.Contract_Id = " & mvarContract_Id

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetIOWContractIdSONotCreated(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM OGBFiler where "
                If mvarOGB_IO_Id <> 0 Then
                    SQLStr = SQLStr & " OGB_IO_ID = " & mvarOGB_IO_Id
                Else
                    SQLStr = SQLStr & " Contract_Id = " & mvarContract_Id
                End If
                SQLStr = SQLStr & " and SO_Created = '0'"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetIOWContractIdRptPendingTOC(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM OGBFiler where Contract_Id = " & mvarContract_Id
                SQLStr = SQLStr & " and TOC_Return_Date is NULL"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetIOWContractIdRptNotSvy(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM OGBFiler where Contract_Id = " & mvarContract_Id
                SQLStr = SQLStr & " and MRC_no is NULL"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function


        Public Function GetParentIO(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM OGBFiler where (Parent_IO_Id is null OR Parent_IO_Id = 0)"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetParentIOByContract(ByRef ds As DataSet, ByVal pContract_ID As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT * FROM OGBFiler where Contract_ID = " & pContract_ID
                '                SQLStr = "SELECT * FROM OGBFiler where (Parent_IO_Id is null OR Parent_IO_Id = 0) "
                '                SQLStr = SQLStr & " and Contract_ID = " & pContract_ID
                SQLStr = SQLStr & " Order by IO_NO ASC"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function IONoExist(ByRef pIO_No As String, ByVal pContract_Id As Integer) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM OGBFiler where IO_No = '" & pIO_No & "' AND "
                SQLStr = SQLStr & " Contract_Id = " & pContract_Id

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return False
                    Else
                        Return True
                    End If
                End If
            End With
        End Function
        'Return true if there are IOs with pending TOC more than 30 days
        Public Function CheckPendingTOC(ByRef ds As DataSet, ByVal pContract_id As Long, ByVal pTransactDate As Date) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Not pContract_id = 0 Then
                    SQLStr = "set dateformat dmy;select * from ogbfiler ogb1 where ogb1.Officer_In_Charge_Id in (SELECT ogb.Officer_In_Charge_Id from OGBPrintNotification ogn "
                    SQLStr = SQLStr & "join OGBFiler ogb on ogb.OGB_IO_Id=ogn.OGB_IO_ID "
                    SQLStr = SQLStr & "left join OfficerInCharge oc on ogb.Officer_In_Charge_Id = oc.Officer_In_Charge_Id "
                    SQLStr = SQLStr & " where ogn.Contractor_ID = " & Long.Parse(pContract_id) & " And ogn.Transact_Date='" & pTransactDate & "')"
                    SQLStr = SQLStr & "and TOC_Return_Date is NULL and DATEDIFF(day,DWC_Sent_Date,getdate()) >= 30"
                End If

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If

            End With


        End Function

        Public Function GetMaxIndexNo() As String
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT MAX(Index_No) as Index_No FROM OGBFiler "

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If Not IsDBNull(ds.Tables(0).Rows(0)("Index_No")) Then
                            Return ds.Tables(0).Rows(0)("Index_No")
                        Else
                            Return 0
                        End If
                    Else
                        Return 0
                    End If
                End If
            End With
        End Function

#End Region

#Region " SAVE "
        Public Function SaveOGBNotification() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO OGBPrintNotification (OGB_IO_ID, Contractor_ID, "
                SQLstr = SQLstr & " Create_Date,Transact_Date,UserID ) "
                SQLstr = SQLstr & " VALUES (" & mvarOGB_IO_Id & "," & mvarContractor_Id & ", GetDate(),'" & mvarTransact_Date & "'," & mvarUserID & ")"

                If .GetDataSet(ds, SQLstr) Then
                    savestatus = True
                Else : savestatus = False
                End If


                ds.Dispose()

            End With
            Return savestatus

        End Function
        Public Function DeleteOGBNotification() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim Delstr As String = "set Dateformat dmy;Delete From OGBPrintNotification where Transact_Date='" & mvarTransact_Date & "' and Contractor_ID=" & mvarContractor_Id
                If .GetDataSet(ds, Delstr) Then
                    delsuccess = True
                End If

                ds.Dispose()

            End With
            Return delsuccess

        End Function

        Public Function SaveOGBF28() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO OGBF28 (OGB_IO_ID, Contractor_ID, "
                SQLstr = SQLstr & " Create_Date,Transact_Date,UserID ) "
                SQLstr = SQLstr & " VALUES (" & mvarOGB_IO_Id & "," & mvarContractor_Id & ", GetDate(),'" & mvarTransact_Date & "'," & mvarUserID & ")"

                If .GetDataSet(ds, SQLstr) Then
                    savestatus = True
                Else : savestatus = False
                End If


                ds.Dispose()

            End With
            Return savestatus

        End Function
        Public Function DeleteOGBF28() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim Delstr As String = "set Dateformat dmy;Delete From OGBF28 where Transact_Date='" & mvarTransact_Date & "' and Contractor_ID=" & mvarContractor_Id
                If .GetDataSet(ds, Delstr) Then
                    delsuccess = True
                End If

                ds.Dispose()

            End With
            Return delsuccess

        End Function

        Public Function SaveIO(ByRef IOID As Integer) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO OGBFiler "
                SQLstr = SQLstr & "(Contract_Id, IO_No, "

                If Len(mvarParentIO) > 0 Then
                    SQLstr = SQLstr & " Parent_IO_Id, "
                End If

                SQLstr = SQLstr & " Officer_In_Charge_Id, "
                SQLstr = SQLstr & " Counter_Sign_Officer_Id, "

                '               If Len(mvarOGB_Section) > 0 Then
                '                    SQLstr = SQLstr & " OGB_Section, "
                '                End If

                SQLstr = SQLstr & " OGB_Location,OGB_Substation, IO_Recv_Date, Commence_Date, "
                'SQLstr = SQLstr & " IO_Recv_Date, Commence_Date, "
                SQLstr = SQLstr & " Completion_Date, "

                If Len(mvarExtend_Commence_Date) > 0 Then
                    SQLstr = SQLstr & " Extend_Commence_Date, "
                End If

                If Len(mvarExtend_Completion_Date) > 0 Then
                    SQLstr = SQLstr & " Extend_Completion_Date, "
                End If

                If Len(mvarInstallation_Date) > 0 Then
                    SQLstr = SQLstr & " Installation_Date, "
                End If

                If Len(mvarWorkVerification_Date) > 0 Then
                    SQLstr = SQLstr & " WorkVerification_Date, "
                End If

                If Len(mvarPaymentClaim_Date) > 0 Then
                    SQLstr = SQLstr & " PaymentClaim_Date, "
                End If

                If Len(mvarSerial_No) > 0 Then
                    SQLstr = SQLstr & " Serial_No, "
                End If

                If Len(mvarOGB_Plus_Minus) > 0 Then
                    SQLstr = SQLstr & " OGB_Plus_Minus, "
                End If

                If Len(mvarTested_Passed_Date) > 0 Then
                    SQLstr = SQLstr & " Tested_Passed_Date, "
                End If

                If Len(mvarOGB_Installed) > 0 Then
                    SQLstr = SQLstr & " OGB_Installed, "
                End If

                If Len(mvarOGB_Surveyed) > 0 Then
                    SQLstr = SQLstr & " OGB_Surveyed, "
                End If

                If Len(mvarOGB_OT) > 0 Then
                    SQLstr = SQLstr & " OGB_OT, "
                End If

                If Len(mvarOGB_630ADin) > 0 Then
                    SQLstr = SQLstr & " OGB_630ADin, "
                End If


                If Len(mvarOGB_Labelled) > 0 Then
                    SQLstr = SQLstr & " OGB_Labelled, "
                End If

                If Len(mvarFeederLabelled) > 0 Then
                    SQLstr = SQLstr & " FeederLabelled, "
                End If

                If Len(mvarMRC_No) > 0 Then
                    SQLstr = SQLstr & " MRC_No, "
                End If

                If Len(mvarRedo_Flg) > 0 Then
                    SQLstr = SQLstr & " Redo_Flg, "
                End If

                If Len(mvarRedo_Text) > 0 Then
                    SQLstr = SQLstr & " Redo_Text, "
                End If

                If Len(mvarOGB1_X) > 0 Then
                    SQLstr = SQLstr & " OGB1_X, "
                End If
                If Len(mvarOGB2_X) > 0 Then
                    SQLstr = SQLstr & " OGB2_X, "
                End If
                If Len(mvarOGB1_Y) > 0 Then
                    SQLstr = SQLstr & " OGB1_Y, "
                End If
                If Len(mvarOGB2_Y) > 0 Then
                    SQLstr = SQLstr & " OGB2_Y, "
                End If
                If Len(mvarInvoice_No) > 0 Then
                    SQLstr = SQLstr & " Invoice_No, "
                End If
                If Len(mvarInvoice_Date) > 0 Then
                    SQLstr = SQLstr & " Invoice_Date, "
                End If
                If Len(mvarLD_Amount) > 0 Then
                    SQLstr = SQLstr & " LD_Amount, "
                End If
                If Len(mvarNotification_Index) > 0 Then
                    SQLstr = SQLstr & " Notification_Index, "
                End If

                If Len(mvarDWC_Sent_Date) > 0 Then
                    SQLstr = SQLstr & " DWC_Sent_Date, "
                End If
                If Len(mvarTOC_Return_Date) > 0 Then
                    SQLstr = SQLstr & " TOC_Return_Date, "
                End If
                If Len(mvarF0028_Recv_Date) > 0 Then
                    SQLstr = SQLstr & " F0028_Recv_Date, "
                End If
                If Len(mvarCollect_Doc_Date) > 0 Then
                    SQLstr = SQLstr & " Collect_Doc_Date, "
                End If
                If Len(mvarRemarks) > 0 Then
                    SQLstr = SQLstr & " Remarks, "
                End If
                If Len(mvarOriginal_IO) > 0 Then
                    SQLstr = SQLstr & " Original_IO, "
                End If
                If Len(mvarLegend_Invoice_No) > 0 Then
                    SQLstr = SQLstr & " Legend_Invoice_No, "
                End If
                If Len(mvarDelay_Reason) > 0 Then
                    SQLstr = SQLstr & " Delay_Reason, "
                End If
                If Len(mvarA4_Qty) > 0 Then
                    SQLstr = SQLstr & " A4_Qty, "
                End If
                If Len(mvarMRC_Qty) > 0 Then
                    SQLstr = SQLstr & " MRC_Qty, "
                End If
                If Len(mvarLU_Qty) > 0 Then
                    SQLstr = SQLstr & " LU_Qty, "
                End If
                If Len(mvarIssues_Flag) > 0 Then
                    SQLstr = SQLstr & " Issues_Flag, "
                End If
                If Len(mvarIssues_Detail) > 0 Then
                    SQLstr = SQLstr & " Issues_Detail, "
                End If

                If Len(mvarDate_Completed) > 0 Then
                    SQLstr = SQLstr & " Date_Completed, "
                End If
                SQLstr = SQLstr & " Create_Date,Transact_Date,UserID ) "
                SQLstr = SQLstr & " VALUES (" & mvarContract_Id & ",'" & mvarIO_No & "', "

                If Len(mvarParentIO) > 0 Then
                    SQLstr = SQLstr & mvarParentIO & ", "
                End If

                SQLstr = SQLstr & mvarOfficer_In_Charge_Id & ", "
                SQLstr = SQLstr & mvarCounter_Sign_Officer_Id & ", "

                '                If Len(mvarOGB_Section) > 0 Then
                '                SQLstr = SQLstr & mvarOGB_Section & ", "
                '                End If

                SQLstr = SQLstr & "'" & Replace(mvarOGB_Location, "'", "''") & "', "
                SQLstr = SQLstr & "'" & Replace(mvarOGB_Substation, "'", "''") & "', "
                SQLstr = SQLstr & "'" & mvarIO_Recv_Date & "', "
                SQLstr = SQLstr & "'" & mvarCommence_Date & "', "
                SQLstr = SQLstr & "'" & mvarCompletion_Date & "', "

                If Len(mvarExtend_Commence_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarExtend_Commence_Date & "', "
                End If
                If Len(mvarExtend_Completion_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarExtend_Completion_Date & "', "
                End If
                If Len(mvarInstallation_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarInstallation_Date & "', "
                End If
                If Len(mvarWorkVerification_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarWorkVerification_Date & "', "
                End If
                If Len(mvarPaymentClaim_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarPaymentClaim_Date & "', "
                End If
                If Len(mvarSerial_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarSerial_No & "', "
                End If
                If Len(mvarOGB_Plus_Minus) > 0 Then
                    SQLstr = SQLstr & "'" & mvarOGB_Plus_Minus & "', "
                End If
                If Len(mvarTested_Passed_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarTested_Passed_Date & "', "
                End If
                If Len(mvarOGB_Installed) > 0 Then
                    SQLstr = SQLstr & mvarOGB_Installed & ", "
                End If
                If Len(mvarOGB_Surveyed) > 0 Then
                    SQLstr = SQLstr & mvarOGB_Surveyed & ", "
                End If

                If Len(mvarOGB_OT) > 0 Then
                    SQLstr = SQLstr & mvarOGB_OT & ", "
                End If

                If Len(mvarOGB_630ADin) > 0 Then
                    SQLstr = SQLstr & mvarOGB_630ADin & ", "
                End If

                If Len(mvarOGB_Labelled) > 0 Then
                    SQLstr = SQLstr & mvarOGB_Labelled & ", "
                End If
                If Len(mvarFeederLabelled) > 0 Then
                    SQLstr = SQLstr & mvarFeederLabelled & ", "
                End If
                If Len(mvarMRC_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarMRC_No & "', "
                End If
                If Len(mvarRedo_Flg) > 0 Then
                    SQLstr = SQLstr & "'" & mvarRedo_Flg & "', "
                End If
                If Len(mvarRedo_Text) > 0 Then
                    SQLstr = SQLstr & "'" & mvarRedo_Text & "', "
                End If
                If Len(mvarOGB1_X) > 0 Then
                    SQLstr = SQLstr & "'" & mvarOGB1_X & "', "
                End If
                If Len(mvarOGB2_X) > 0 Then
                    SQLstr = SQLstr & "'" & mvarOGB2_X & "', "
                End If
                If Len(mvarOGB1_Y) > 0 Then
                    SQLstr = SQLstr & "'" & mvarOGB1_Y & "', "
                End If
                If Len(mvarOGB2_Y) > 0 Then
                    SQLstr = SQLstr & "'" & mvarOGB2_Y & "', "
                End If
                
                If Len(mvarInvoice_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarInvoice_No & "', "
                End If

                If Len(mvarInvoice_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarInvoice_Date & "', "
                End If

                If Len(mvarLD_Amount) > 0 Then
                    SQLstr = SQLstr & mvarLD_Amount & ", "
                End If

                If Len(mvarNotification_Index) > 0 Then
                    SQLstr = SQLstr & "'" & mvarNotification_Index & "', "
                End If

                If Len(mvarDWC_Sent_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarDWC_Sent_Date & "', "
                End If

                If Len(mvarTOC_Return_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarTOC_Return_Date & "', "
                End If

                If Len(mvarF0028_Recv_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarF0028_Recv_Date & "', "
                End If

                If Len(mvarCollect_Doc_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarCollect_Doc_Date & "', "
                End If

                If Len(mvarRemarks) > 0 Then
                    SQLstr = SQLstr & "'" & mvarRemarks & "', "
                End If

                If Len(mvarOriginal_IO) > 0 Then
                    SQLstr = SQLstr & "'" & mvarOriginal_IO & "', "
                End If

                If Len(mvarLegend_Invoice_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarLegend_Invoice_No & "', "
                End If

                If Len(mvarDelay_Reason) > 0 Then
                    SQLstr = SQLstr & "'" & mvarDelay_Reason & "', "
                End If

                If Len(mvarA4_Qty) > 0 Then
                    SQLstr = SQLstr & mvarA4_Qty & ", "
                End If

                If Len(mvarMRC_Qty) > 0 Then
                    SQLstr = SQLstr & mvarMRC_Qty & ", "
                End If

                If Len(mvarLU_Qty) > 0 Then
                    SQLstr = SQLstr & mvarLU_Qty & ", "
                End If

                If Len(mvarIssues_Flag) > 0 Then
                    SQLstr = SQLstr & "'" & mvarIssues_Flag & "', "
                End If
                If Len(mvarIssues_Detail) > 0 Then
                    SQLstr = SQLstr & "'" & mvarIssues_Detail & "', "
                End If

                If Len(mvarDate_Completed) > 0 Then
                    SQLstr = SQLstr & "'" & mvarDate_Completed & "', "
                End If

                SQLstr = SQLstr & " Getdate(), GetDate(), "
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & "(SELECT @@IDENTITY AS OGB_IO_ID from OGBFiler)"

                Debug.WriteLine(SQLstr)

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        IOID = Integer.Parse(ds.Tables(0).Rows(0).Item(0).ToString)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " UPDATE "
        Public Function UpdateOGBIO() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;UPDATE OGBFiler SET "

                SQLstr = SQLstr & " IO_No = '" & mvarIO_No & "',"

                If Len(mvarParentIO) > 0 Then
                    SQLstr = SQLstr & " Parent_IO_ID = " & mvarParentIO & ","
                End If

                SQLstr = SQLstr & " Officer_In_Charge_Id = " & mvarOfficer_In_Charge_Id & ","

                If Len(mvarCounter_Sign_Officer_Id) > 0 Then
                    SQLstr = SQLstr & " Counter_Sign_Officer_Id = " & mvarCounter_Sign_Officer_Id & ","
                End If

                '                If Len(mvarOGB_Section) > 0 Then
                '                SQLstr = SQLstr & " OGB_Section = " & mvarOGB_Section & ","
                '                End If

                If Len(mvarOGB_Location) > 0 Then
                    SQLstr = SQLstr & " OGB_Location = '" & Replace(mvarOGB_Location, "'", "''") & "',"
                End If
                If Len(mvarOGB_Substation) > 0 Then
                    SQLstr = SQLstr & " OGB_Substation = '" & Replace(mvarOGB_Substation, "'", "''") & "',"
                End If

                SQLstr = SQLstr & " IO_Recv_Date = '" & mvarIO_Recv_Date & "',"
                SQLstr = SQLstr & " Commence_Date = '" & mvarCommence_Date & "',"
                SQLstr = SQLstr & " Completion_Date = '" & mvarCompletion_Date & "',"

                If Len(mvarExtend_Commence_Date) > 0 Then
                    SQLstr = SQLstr & " Extend_Commence_Date = '" & mvarExtend_Commence_Date & "',"
                Else
                    SQLstr = SQLstr & " Extend_Commence_Date = NULL,"
                End If

                If Len(mvarExtend_Completion_Date) > 0 Then
                    SQLstr = SQLstr & " Extend_Completion_Date = '" & mvarExtend_Completion_Date & "',"
                Else
                    SQLstr = SQLstr & " Extend_Completion_Date = NULL,"
                End If

                If Len(mvarInstallation_Date) > 0 Then
                    SQLstr = SQLstr & " Installation_Date = '" & mvarInstallation_Date & "',"
                Else
                    SQLstr = SQLstr & " Installation_Date = NULL,"
                End If

                If Len(mvarWorkVerification_Date) > 0 Then
                    SQLstr = SQLstr & " WorkVerification_Date = '" & mvarWorkVerification_Date & "',"
                Else
                    SQLstr = SQLstr & " WorkVerification_Date = NULL,"
                End If

                If Len(mvarPaymentClaim_Date) > 0 Then
                    SQLstr = SQLstr & " PaymentClaim_Date = '" & mvarPaymentClaim_Date & "',"
                Else
                    SQLstr = SQLstr & " PaymentClaim_Date = NULL,"
                End If

                If Len(mvarSerial_No) > 0 Then
                    SQLstr = SQLstr & " Serial_No = '" & mvarSerial_No & "', "
                Else
                    SQLstr = SQLstr & " Serial_No = NULL, "
                End If

                If Len(mvarOGB_Plus_Minus) > 0 Then
                    SQLstr = SQLstr & " OGB_Plus_Minus = '" & mvarOGB_Plus_Minus & "', "
                Else
                    SQLstr = SQLstr & " OGB_Plus_Minus = NULL, "
                End If

                If Len(mvarTested_Passed_Date) > 0 Then
                    SQLstr = SQLstr & " Tested_Passed_Date = '" & mvarTested_Passed_Date & "', "
                Else
                    SQLstr = SQLstr & " Tested_Passed_Date = NULL, "
                End If

                If Len(mvarOGB_Installed) > 0 Then
                    SQLstr = SQLstr & " OGB_Installed = " & mvarOGB_Installed & ", "
                Else
                    SQLstr = SQLstr & " OGB_Installed = NULL, "
                End If

                If Len(mvarOGB_Surveyed) > 0 Then
                    SQLstr = SQLstr & " OGB_Surveyed = " & mvarOGB_Surveyed & ", "
                Else
                    SQLstr = SQLstr & " OGB_Surveyed = NULL, "
                End If

                If Len(mvarOGB_OT) > 0 Then
                    SQLstr = SQLstr & " OGB_OT = " & mvarOGB_OT & ", "
                Else
                    SQLstr = SQLstr & " OGB_OT = NULL, "
                End If

                If Len(mvarOGB_630ADin) > 0 Then
                    SQLstr = SQLstr & " OGB_630ADin = " & mvarOGB_630ADin & ", "
                Else
                    SQLstr = SQLstr & " OGB_630ADin = NULL, "
                End If


                If Len(mvarOGB_Labelled) > 0 Then
                    SQLstr = SQLstr & " OGB_Labelled = " & mvarOGB_Labelled & ", "
                Else
                    SQLstr = SQLstr & " OGB_Labelled = NULL, "
                End If

                If Len(mvarFeederLabelled) > 0 Then
                    SQLstr = SQLstr & " FeederLabelled = " & mvarFeederLabelled & ", "
                Else
                    SQLstr = SQLstr & " FeederLabelled = NULL, "
                End If

                If Len(mvarMRC_No) > 0 Then
                    SQLstr = SQLstr & " MRC_No = '" & mvarMRC_No & "',"
                Else
                    SQLstr = SQLstr & " MRC_No = NULL, "
                End If

                If Len(mvarRedo_Flg) > 0 Then
                    SQLstr = SQLstr & " Redo_Flg = '" & mvarRedo_Flg & "', "
                Else
                    SQLstr = SQLstr & " Redo_Flg = NULL, "
                End If

                If Len(mvarRedo_Text) > 0 Then
                    SQLstr = SQLstr & " Redo_Text = '" & mvarRedo_Text & "', "
                Else
                    SQLstr = SQLstr & " Redo_Text = NULL, "
                End If

                If Len(mvarOGB1_X) > 0 Then
                    SQLstr = SQLstr & " OGB1_X = '" & mvarOGB1_X & "', "
                Else
                    SQLstr = SQLstr & " OGB1_X = NULL, "
                End If

                If Len(mvarOGB2_X) > 0 Then
                    SQLstr = SQLstr & " OGB2_X = '" & mvarOGB2_X & "', "
                Else
                    SQLstr = SQLstr & " OGB2_X = NULL, "
                End If

                If Len(mvarOGB1_Y) > 0 Then
                    SQLstr = SQLstr & " OGB1_Y = '" & mvarOGB1_Y & "', "
                Else
                    SQLstr = SQLstr & " OGB1_Y = NULL, "
                End If

                If Len(mvarOGB2_Y) > 0 Then
                    SQLstr = SQLstr & " OGB2_Y = '" & mvarOGB2_Y & "', "
                Else
                    SQLstr = SQLstr & " OGB2_Y = NULL, "
                End If

                If Len(mvarInvoice_No) > 0 Then
                    SQLstr = SQLstr & " Invoice_No = '" & mvarInvoice_No & "',"
                Else
                    SQLstr = SQLstr & " Invoice_No = NULL,"
                End If

                If Len(mvarInvoice_Date) > 0 Then
                    SQLstr = SQLstr & " Invoice_Date = '" & mvarInvoice_Date & "',"
                Else
                    SQLstr = SQLstr & " Invoice_Date = NULL,"
                End If

                If Len(mvarLD_Amount) > 0 Then
                    SQLstr = SQLstr & " LD_Amount = " & mvarLD_Amount & ", "
                Else
                    SQLstr = SQLstr & " LD_Amount = NULL, "
                End If

                If Len(mvarNotification_Index) > 0 Then
                    SQLstr = SQLstr & " Notification_Index = '" & mvarNotification_Index & "', "
                Else
                    SQLstr = SQLstr & " Notification_Index = NULL, "
                End If

                If Len(mvarDWC_Sent_Date) > 0 Then
                    SQLstr = SQLstr & " DWC_Sent_Date = '" & mvarDWC_Sent_Date & "',"
                Else
                    SQLstr = SQLstr & " DWC_Sent_Date = NULL,"
                End If

                If Len(mvarTOC_Return_Date) > 0 Then
                    SQLstr = SQLstr & " TOC_Return_Date = '" & mvarTOC_Return_Date & "',"
                Else
                    SQLstr = SQLstr & " TOC_Return_Date = NULL,"
                End If

                If Len(mvarF0028_Recv_Date) > 0 Then
                    SQLstr = SQLstr & " F0028_Recv_Date = '" & mvarF0028_Recv_Date & "', "
                Else
                    SQLstr = SQLstr & " F0028_Recv_Date = NULL, "
                End If

                If Len(mvarCollect_Doc_Date) > 0 Then
                    SQLstr = SQLstr & " Collect_Doc_Date = '" & mvarCollect_Doc_Date & "', "
                Else
                    SQLstr = SQLstr & " Collect_Doc_Date = NULL, "
                End If

                If Len(mvarRemarks) > 0 Then
                    SQLstr = SQLstr & " Remarks = '" & mvarRemarks & "', "
                Else
                    SQLstr = SQLstr & " Remarks = NULL, "
                End If

                If Len(mvarOriginal_IO) > 0 Then
                    SQLstr = SQLstr & " Original_IO = '" & mvarOriginal_IO & "', "
                Else
                    SQLstr = SQLstr & " Original_IO = NULL, "
                End If

                If Len(mvarLegend_Invoice_No) > 0 Then
                    SQLstr = SQLstr & " Legend_Invoice_No = '" & mvarLegend_Invoice_No & "', "
                Else
                    SQLstr = SQLstr & " Legend_Invoice_No = NULL, "
                End If

                If Len(mvarDelay_Reason) > 0 Then
                    SQLstr = SQLstr & " Delay_Reason = '" & mvarDelay_Reason & "', "
                Else
                    SQLstr = SQLstr & " Delay_Reason = NULL, "
                End If

                If Len(mvarA4_Qty) > 0 Then
                    SQLstr = SQLstr & " A4_Qty = " & mvarA4_Qty & ", "
                Else
                    SQLstr = SQLstr & " A4_Qty = NULL, "
                End If

                If Len(mvarMRC_Qty) > 0 Then
                    SQLstr = SQLstr & " MRC_Qty = " & mvarMRC_Qty & ", "
                Else
                    SQLstr = SQLstr & " MRC_Qty = NULL, "
                End If

                If Len(mvarLU_Qty) > 0 Then
                    SQLstr = SQLstr & " LU_Qty = " & mvarLU_Qty & ", "
                Else
                    SQLstr = SQLstr & " LU_Qty = NULL, "
                End If

                If Len(mvarIssues_Flag) > 0 Then
                    SQLstr = SQLstr & " Issues_Flag = " & mvarIssues_Flag & ", "
                Else
                    SQLstr = SQLstr & " Issues_Flag = NULL, "
                End If

                If Len(mvarIssues_Detail) > 0 Then
                    SQLstr = SQLstr & " Issues_Detail = '" & mvarIssues_Detail & "', "
                Else
                    SQLstr = SQLstr & " Issues_Detail = NULL, "
                End If

                If Len(mvarDate_Completed) > 0 Then
                    SQLstr = SQLstr & " Date_Completed = '" & mvarDate_Completed & "', "
                Else
                    SQLstr = SQLstr & " Date_Completed = NULL, "
                End If

                SQLstr = SQLstr & " Transact_Date = GetDate () ,"
                SQLstr = SQLstr & " UserID = " & mvarUserID & " WHERE "
                SQLstr = SQLstr & "OGB_IO_ID = " & mvarOGB_IO_Id

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateIndexNo()
            Dim ds As DataSet
            Dim SQLStr As String = "UPDATE OGBFiler SET "
            SQLStr = SQLStr & " Index_No = '" & mvarIndex_No & "'"
            SQLStr = SQLStr & " ,UserID = " & mvarUserID
            SQLStr = SQLStr & " ,Transact_Date = GetDate() "
            SQLStr = SQLStr & " WHERE OGB_IO_Id = " & mvarOGB_IO_Id

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                End If
            End With
            ds.Dispose()
        End Sub
#End Region

#Region " DELETE "
        Public Function DeleteOneIO() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "DELETE FROM OGBFiler WHERE OGB_IO_ID = " & mvarOGB_IO_Id

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " OGB Notification Installation Report "
        Public Function GetNotificationOGBInstallReport(ByRef ds As DataSet, ByVal pEdit_Date As Date, ByVal pstrIO_ID As String, ByVal pCustomerName As String, Optional ByVal pAttention_Name As String = "")
            Dim SQLStr As String

            SQLStr = "SELECT '" & pEdit_Date & "' as Edit_Date, f.OGB_Contract_No, a.Index_No, a.IO_No, '" & pAttention_Name & "' as Attention_Name, '" & pCustomerName & "' as CustomerName, "
            SQLStr = SQLStr & " a.OGB_Location,a.OGB_Substation, b.Officer_Name, c.Section_Code, "
            SQLStr = SQLStr & " a.Completion_Date, a.Commence_Date, '1' as OGB_Qty, "
            SQLStr = SQLStr & " a.Serial_No as Serial_No, a.Installation_Date as Installation_Date , a.WorkVerification_Date as WorkVerification_Date, a.PaymentClaim_Date as PaymentClaim_Date, "
            SQLStr = SQLStr & " a.Remarks as Remarks FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "

            'SQLStr = SQLStr & " Customer cu ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "

            SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract f ON a.Contract_Id = f.OGB_Contract_Id "
            SQLStr = SQLStr & " WHERE (a.OGB_IO_Id IN (" & pstrIO_ID & ")) "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region


#Region " OGB Request F28 Report "
        Public Function GetForm28Report(ByRef ds As DataSet, ByVal pstrIO_ID As String, _
                                        ByVal pAttention_Name As String, ByVal pEdit_Date As String)
            Dim SQLStr As String

            SQLStr = "SELECT f.OGB_Contract_No, a.IO_No, a.MRC_No, '" & pAttention_Name & "' as Attention_Name, "
            SQLStr = SQLStr & " a.OGB_Location,a.OGB_Substation, b.Officer_Name, c.Section_Code, '" & pEdit_Date & "' as Edit_Date "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract f ON a.Contract_Id = f.OGB_Contract_Id "
            SQLStr = SQLStr & " WHERE (a.OGB_IO_Id IN (" & pstrIO_ID & ")) "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

#Region " OGB Declaration Work Completion "
        Public Function GetDWCReport(ByRef ds As DataSet, ByVal pIO_ID As Integer)
            Dim SQLStr As String

            SQLStr = "SELECT 'OVERGROUND BOX' AS OGB_Box, d.OGB_Contract_No, "
            SQLStr = SQLStr & " a.IO_No, a.OGB_Location,a.OGB_Substation, a.Serial_No, e.Officer_Name, "
            'remove by alan SQLStr = SQLStr & " a.Extend_Completion_Date, a.Installation_Date, a.Remarks "
            SQLStr = SQLStr & " a.Completion_Date, a.Extend_Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Remarks, a.Tested_Passed_Date, a.MRC_Qty "
            SQLStr = SQLStr & " ,a.DWC_Sent_Date,f.Section_Code, a.MRC_No, a.Redo_Text, OGB_Installed , OGB_Surveyed ,OGB_OT, OGB_630ADin "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract d ON a.Contract_Id = d.OGB_Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            SQLStr = SQLStr & " WHERE a.OGB_IO_Id = " & pIO_ID & " "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDWCLabelReport(ByRef ds As DataSet, ByVal pIO_ID As Integer)
            Dim SQLStr As String

            SQLStr = "SELECT 'OVERGROUND BOX' AS OGB_Box, d.OGB_Contract_No, "
            SQLStr = SQLStr & " a.IO_No, a.OGB_Location,a.OGB_Substation, a.Serial_No, e.Officer_Name, "
            'remove by alan SQLStr = SQLStr & " a.Extend_Completion_Date, a.Installation_Date, a.Remarks "
            SQLStr = SQLStr & " a.Completion_Date, a.Extend_Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Remarks, a.Tested_Passed_Date, a.OGB_Labelled, a.FeederLabelled "
            SQLStr = SQLStr & " ,a.DWC_Sent_Date,f.Section_Code, a.MRC_No, a.Redo_Text "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract d ON a.Contract_Id = d.OGB_Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            SQLStr = SQLStr & " WHERE a.OGB_IO_Id = " & pIO_ID & " "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " OGB Reports :Installed But Not Surveyed "
        Public Function GetNotSurveyedReport(ByRef ds As DataSet, Optional ByVal pIO_ID As String = "") As Boolean
            Dim SQLStr As String

            SQLStr = "SELECT d.OGB_Contract_No, a.LU_Qty, a.OGB_Installed, a.OGB_Surveyed, a.OGB_Labelled, a.FeederLabelled, "
            SQLStr = SQLStr & " a.IO_No, a.OGB_Location,a.OGB_Substation, a.Serial_No, e.Officer_Name, "
            SQLStr = SQLStr & " a.Commence_Date, a.Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, "
            SQLStr = SQLStr & " f.Section_Code, a.MRC_No, a.Redo_Text "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract d ON a.Contract_Id = d.OGB_Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            SQLStr = SQLStr & " Where a.MRC_No is NULL "
            If Len(pIO_ID) > 0 Then
                SQLStr = SQLStr & " and a.OGB_IO_Id = " & pIO_ID & " "
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

#Region " OGB Reports :OGB Invoice Status "
        Public Function GetOGBInvoiceStatusReport(ByRef ds As DataSet, ByVal pContract_id As String, ByVal pSection_id As Integer, ByVal pSortby As Integer, ByVal pShowTOC_Null As Boolean, ByVal pFilters As String)
            Dim SQLStr As String

            SQLStr = "set dateformat dmy;SELECT d.OGB_Contract_No, e.Officer_Name, f.Section_Code, "
            SQLStr = SQLStr & " a.IO_No, a.OGB_Location,a.OGB_Substation, a.Serial_No,  "
            SQLStr = SQLStr & " a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.DWC_Sent_Date, a.TOC_Return_Date, a.Invoice_No, a.Invoice_Date,"
            SQLStr = SQLStr & " a.Redo_Text "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract d ON a.Contract_Id = d.OGB_Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            'SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL "
            SQLStr = SQLStr & " where 1=1 "
            'If Len(pContract_id) > 0 Then
            'SQLStr = SQLStr & " and a.OGB_IO_Id = " & pIO_ID & " "
            SQLStr = SQLStr & " and a.Contract_Id = " & Long.Parse(pContract_id) & " "
            If pSection_id <> 0 Then
                SQLStr = SQLStr & " and e.Section_Id = " & pSection_id & " "
            End If
            If pShowTOC_Null = True Then
                SQLStr = SQLStr & " and a.TOC_Return_Date is NULL "
            End If

            If Len(pFilters) > 0 Then
                SQLStr = SQLStr & " and (" & pFilters & ")"
            End If

            SQLStr = SQLStr & " Order by RIGHT('0000000000' + a.Serial_No, 10)"

            'End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

        Public Function GetOGBInstallFeedbackReport(ByRef ds As DataSet, ByVal pContract_id As String, ByVal pSection_id As Integer, ByVal pSortby As Integer, ByVal pShowTOC_Null As Boolean, ByVal pFilters As String)
            Dim SQLStr As String

            SQLStr = "set dateformat dmy;SELECT d.OGB_Contract_No, e.Officer_Name, f.Section_Code, "
            SQLStr = SQLStr & " a.IO_No, a.OGB_Location,a.OGB_Substation, a.Serial_No,  "
            SQLStr = SQLStr & " a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.DWC_Sent_Date, a.TOC_Return_Date, a.Invoice_No, a.Invoice_Date,"
            SQLStr = SQLStr & " a.Redo_Text, a.Issues_Flag, a.Issues_Detail "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract d ON a.Contract_Id = d.OGB_Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            'SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL "
            SQLStr = SQLStr & " where 1=1 "
            'If Len(pContract_id) > 0 Then
            'SQLStr = SQLStr & " and a.OGB_IO_Id = " & pIO_ID & " "
            SQLStr = SQLStr & " and a.Contract_Id = " & Long.Parse(pContract_id) & " "
            If pSection_id <> 0 Then
                SQLStr = SQLStr & " and e.Section_Id = " & pSection_id & " "
            End If
            If pShowTOC_Null = True Then
                SQLStr = SQLStr & " and a.TOC_Return_Date is NULL "
            End If

            If Len(pFilters) > 0 Then
                SQLStr = SQLStr & " and (" & pFilters & ")"
            End If

            SQLStr = SQLStr & " Order by RIGHT('0000000000' + a.Serial_No, 10)"

            'End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#Region " OGB Reports :TOC Pending With Officer "
        Public Function GetPendingTOCReportSub(ByRef ds As DataSet, ByVal pIO_ID As Integer, ByVal pSortby As Integer, ByVal pFilters As String)
            Dim SQLStr As String

            SQLStr = "SELECT a.Officer_in_Charge_Id, d.OGB_Contract_No, a.OGB_Installed, a.OGB_Surveyed, a.DWC_Sent_Date, a.TOC_Return_Date, a.Remarks,"
            SQLStr = SQLStr & " a.IO_No, a.OGB_Location,a.OGB_Substation, a.Serial_No, e.Officer_Name, "
            SQLStr = SQLStr & " a.Commence_Date, a.Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, "
            SQLStr = SQLStr & " f.Section_Code, a.Redo_Text "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract d ON a.Contract_Id = d.OGB_Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL and a.DWC_Sent_Date is not NULL "
            SQLStr = SQLStr & " and (" & pFilters & ")"
            'If Len(pIO_ID) > 0 Then
            SQLStr = SQLStr & " and d.OGB_Contract_Id = " & pIO_ID & " "

            If pSortby <> -1 Then
                SQLStr = SQLStr & "order by "
                If pSortby = 0 Then 'by Officer
                    SQLStr = SQLStr & " e.Officer_Name ASC"
                ElseIf pSortby = 1 Then 'by IO number
                    SQLStr = SQLStr & " a.IO_NO ASC"
                ElseIf pSortby = 2 Then 'DWC date
                    SQLStr = SQLStr & " a.DWC_Sent_date ASC"
                End If

            Else
                SQLStr = SQLStr & "order by e.Officer_Name ASC"
            End If

            Return SQLStr

            'End If

            'With New DataAccess.DAccess.Access
            'If .GetDataSet(ds, SQLStr) Then
            'Return True
            'End If
            'End With
        End Function

        Public Function GetPendingTOCReport(ByRef ds As DataSet, ByVal pIO_ID As Integer, ByVal pSortby As Integer, ByVal pFilters As String)
            Dim SQLStr As String

            SQLStr = "SELECT Distinct a.Officer_in_Charge_Id,d.OGB_Contract_No,"
            SQLStr = SQLStr & "  e.Officer_Name "
            SQLStr = SQLStr & " FROM OGBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OGBContract d ON a.Contract_Id = d.OGB_Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL and a.DWC_Sent_Date is not NULL "
            'SQLStr = SQLStr & " and " & pFilters
            'If Len(pIO_ID) > 0 Then
            SQLStr = SQLStr & " and d.OGB_Contract_Id = " & pIO_ID & " "

            pSortby = -1 'force

            If pSortby <> -1 Then
                SQLStr = SQLStr & "order by "
                If pSortby = 0 Then 'by Officer
                    SQLStr = SQLStr & " e.Officer_Name ASC"
                ElseIf pSortby = 1 Then 'by IO number
                    SQLStr = SQLStr & " a.IO_NO ASC"
                ElseIf pSortby = 2 Then 'DWC date
                    SQLStr = SQLStr & " a.DWC_Sent_date ASC"
                End If

            Else
                SQLStr = SQLStr & "order by e.Officer_Name ASC"
            End If

            'End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

#Region " Get n Set "
        Public Property OGB_IO_Id() As Integer
            Get
                Return mvarOGB_IO_Id
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_IO_Id = Value
            End Set
        End Property

        Public Property Contract_Id() As Integer
            Get
                Return mvarContract_Id
            End Get
            Set(ByVal Value As Integer)
                mvarContract_Id = Value
            End Set
        End Property
        Public Property Contractor_Id() As Integer
            Get
                Return mvarContractor_Id
            End Get
            Set(ByVal Value As Integer)
                mvarContractor_Id = Value
            End Set
        End Property

        Public Property IO_No() As String
            Get
                Return mvarIO_No
            End Get
            Set(ByVal Value As String)
                mvarIO_No = Value
            End Set
        End Property

        Public Property ParentIO() As Integer
            Get
                Return mvarParentIO
            End Get
            Set(ByVal Value As Integer)
                mvarParentIO = Value
            End Set
        End Property

        Public Property Officer_In_Charge_Id() As Integer
            Get
                Return mvarOfficer_In_Charge_Id
            End Get
            Set(ByVal Value As Integer)
                mvarOfficer_In_Charge_Id = Value
            End Set
        End Property

        Public Property Counter_Sign_Officer_Id() As Integer
            Get
                Return mvarCounter_Sign_Officer_Id
            End Get
            Set(ByVal Value As Integer)
                mvarCounter_Sign_Officer_Id = Value
            End Set
        End Property

        '       Public Property OGB_Section() As Integer
        '           Get
        '                Return mvarOGB_Section
        '            End Get
        '            Set(ByVal Value As Integer)
        '                mvarOGB_Section = Value
        '            End Set
        '        End Property

        Public Property OGB_Location() As String
            Get
                Return mvarOGB_Location
            End Get
            Set(ByVal Value As String)
                mvarOGB_Location = Value
            End Set
        End Property
        Public Property OGB_Substation() As String
            Get
                Return mvarOGB_Substation
            End Get
            Set(ByVal Value As String)
                mvarOGB_Substation = Value
            End Set
        End Property
        Public Property IO_Recv_Date() As String
            Get
                Return mvarIO_Recv_Date
            End Get
            Set(ByVal Value As String)
                mvarIO_Recv_Date = Value
            End Set
        End Property

        Public Property Commence_Date() As String
            Get
                Return mvarCommence_Date
            End Get
            Set(ByVal Value As String)
                mvarCommence_Date = Value
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

        Public Property Extend_Commence_Date() As String
            Get
                Return mvarExtend_Commence_Date
            End Get
            Set(ByVal Value As String)
                mvarExtend_Commence_Date = Value
            End Set
        End Property

        Public Property Extend_Completion_Date() As String
            Get
                Return mvarExtend_Completion_Date
            End Get
            Set(ByVal Value As String)
                mvarExtend_Completion_Date = Value
            End Set
        End Property

        Public Property Installation_Date() As String
            Get
                Return mvarInstallation_Date
            End Get
            Set(ByVal Value As String)
                mvarInstallation_Date = Value
            End Set
        End Property
        Public Property WorkVerification_Date() As String
            Get
                Return mvarWorkVerification_Date
            End Get
            Set(ByVal Value As String)
                mvarWorkVerification_Date = Value
            End Set
        End Property
        Public Property PaymentClaim_Date() As String
            Get
                Return mvarPaymentClaim_Date
            End Get
            Set(ByVal Value As String)
                mvarPaymentClaim_Date = Value
            End Set
        End Property

        Public Property Serial_No() As String
            Get
                Return mvarSerial_No
            End Get
            Set(ByVal Value As String)
                mvarSerial_No = Value
            End Set
        End Property

        Public Property OGB_Plus_Minus() As String
            Get
                Return mvarOGB_Plus_Minus
            End Get
            Set(ByVal Value As String)
                mvarOGB_Plus_Minus = Value
            End Set
        End Property

        Public Property Tested_Passed_Date() As String
            Get
                Return mvarTested_Passed_Date
            End Get
            Set(ByVal Value As String)
                mvarTested_Passed_Date = Value
            End Set
        End Property

        Public Property OGB_Installed() As Integer
            Get
                Return mvarOGB_Installed
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_Installed = Value
            End Set
        End Property

        Public Property OGB_Surveyed() As Integer
            Get
                Return mvarOGB_Surveyed
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_Surveyed = Value
            End Set
        End Property

        Public Property OGB_OT() As Integer
            Get
                Return mvarOGB_OT
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_OT = Value
            End Set
        End Property

        Public Property OGB_630ADin() As Integer
            Get
                Return mvarOGB_630ADin
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_630ADin = Value
            End Set
        End Property


        Public Property OGB_Labelled() As Integer
            Get
                Return mvarOGB_Labelled
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_Labelled = Value
            End Set
        End Property

        Public Property FeederLabelled() As Integer
            Get
                Return mvarFeederLabelled
            End Get
            Set(ByVal Value As Integer)
                mvarFeederLabelled = Value
            End Set
        End Property

        Public Property MRC_No() As String
            Get
                Return mvarMRC_No
            End Get
            Set(ByVal Value As String)
                mvarMRC_No = Value
            End Set
        End Property

        Public Property Redo_Flg() As String
            Get
                Return mvarRedo_Flg
            End Get
            Set(ByVal Value As String)
                mvarRedo_Flg = Value
            End Set
        End Property

        Public Property Redo_Text() As String
            Get
                Return mvarRedo_Text
            End Get
            Set(ByVal Value As String)
                mvarRedo_Text = Value
            End Set
        End Property

        Public Property OGB1_X() As String
            Get
                Return mvarOGB1_X
            End Get
            Set(ByVal Value As String)
                mvarOGB1_X = Value
            End Set
        End Property

        Public Property OGB2_X() As String
            Get
                Return mvarOGB2_X
            End Get
            Set(ByVal Value As String)
                mvarOGB2_X = Value
            End Set
        End Property

        Public Property OGB1_Y() As String
            Get
                Return mvarOGB1_Y
            End Get
            Set(ByVal Value As String)
                mvarOGB1_Y = Value
            End Set
        End Property

        Public Property OGB2_Y() As String
            Get
                Return mvarOGB2_Y
            End Get
            Set(ByVal Value As String)
                mvarOGB2_Y = Value
            End Set
        End Property

        Public Property Invoice_No() As String
            Get
                Return mvarInvoice_No
            End Get
            Set(ByVal Value As String)
                mvarInvoice_No = Value
            End Set
        End Property

        Public Property Invoice_Date() As String
            Get
                Return mvarInvoice_Date
            End Get
            Set(ByVal Value As String)
                mvarInvoice_Date = Value
            End Set
        End Property

        Public Property LD_Amount() As Decimal
            Get
                Return mvarLD_Amount
            End Get
            Set(ByVal Value As Decimal)
                mvarLD_Amount = Value
            End Set
        End Property

        Public Property Notification_Index() As String
            Get
                Return mvarNotification_Index
            End Get
            Set(ByVal Value As String)
                mvarNotification_Index = Value
            End Set
        End Property

        Public Property DWC_Sent_Date() As String
            Get
                Return mvarDWC_Sent_Date
            End Get
            Set(ByVal Value As String)
                mvarDWC_Sent_Date = Value
            End Set
        End Property

        Public Property TOC_Return_Date() As String
            Get
                Return mvarTOC_Return_Date
            End Get
            Set(ByVal Value As String)
                mvarTOC_Return_Date = Value
            End Set
        End Property

        Public Property F0028_Recv_Date() As String
            Get
                Return mvarF0028_Recv_Date
            End Get
            Set(ByVal Value As String)
                mvarF0028_Recv_Date = Value
            End Set
        End Property

        Public Property Collect_Doc_Date() As String
            Get
                Return mvarCollect_Doc_Date
            End Get
            Set(ByVal Value As String)
                mvarCollect_Doc_Date = Value
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

        Public Property Original_IO() As String
            Get
                Return mvarOriginal_IO
            End Get
            Set(ByVal Value As String)
                mvarOriginal_IO = Value
            End Set
        End Property

        Public Property Legend_Invoice_No() As String
            Get
                Return mvarLegend_Invoice_No
            End Get
            Set(ByVal Value As String)
                mvarLegend_Invoice_No = Value
            End Set
        End Property

        Public Property Delay_Reason() As String
            Get
                Return mvarDelay_Reason
            End Get
            Set(ByVal Value As String)
                mvarDelay_Reason = Value
            End Set
        End Property

        Public Property A4_Qty() As Integer
            Get
                Return mvarA4_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarA4_Qty = Value
            End Set
        End Property

        Public Property MRC_Qty() As Integer
            Get
                Return mvarMRC_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarMRC_Qty = Value
            End Set
        End Property
        Public Property Issues_Flag() As Integer
            Get
                Return mvarIssues_Flag
            End Get
            Set(ByVal value As Integer)
                mvarIssues_Flag = value
            End Set
        End Property
        Public Property Issues_Detail() As String
            Get
                Return mvarIssues_Detail
            End Get
            Set(ByVal value As String)
                mvarIssues_Detail = value
            End Set
        End Property
        Public Property LU_Qty() As Integer
            Get
                Return mvarLU_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLU_Qty = Value
            End Set
        End Property

        Public Property Date_Completed() As String
            Get
                Return mvarDate_Completed
            End Get
            Set(ByVal Value As String)
                mvarDate_Completed = Value
            End Set
        End Property

        Public Property Index_No() As String
            Get
                Return mvarIndex_No
            End Get
            Set(ByVal Value As String)
                mvarIndex_No = Value
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
    End Class


    Public Class OGBContractBusLogic
#Region " Variable "
        Private mvarOGB_Contract_Id As Integer
        Private mvarOGB_Contract_No As String
        Private mvarOGB_Box_Qty As Integer
        Private mvarBox_Label As Integer
        Private mvarStrip_Label As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " OGB Contract Function"
        Public Function GetOGBContract(ByRef ds As DataSet, Optional ByVal pOGB_Contract_Id As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pOGB_Contract_Id) > 0 Then
                    SQLStr = "SELECT * FROM OGBContract where OGB_Contract_Id = " & Integer.Parse(pOGB_Contract_Id)
                Else
                    SQLStr = "SELECT * FROM OGBContract where inactive=0 or inactive is null order by create_date DESC"
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveOGBContract() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO OGBContract "
            SQLStr = SQLStr & "(OGB_Contract_No,OGB_Box_Qty,Box_Label,Strip_Label,"
            SQLStr = SQLStr & " Create_Date,Transact_Date,UserID )"

            SQLStr = SQLStr & " VALUES ('" & mvarOGB_Contract_No & "'," & mvarOGB_Box_Qty & "," & mvarBox_Label
            SQLStr = SQLStr & "," & mvarStrip_Label & ", GetDate(),GetDate()," & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function CheckDuplicateContract() As Boolean
            Dim dsOGB_Contract_No As DataSet
            Dim SQLStr As String = "Select * from OGBContract WHERE OGB_Contract_No = '" & mvarOGB_Contract_No & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsOGB_Contract_No, SQLStr) Then
                    If dsOGB_Contract_No.Tables(0).Rows.Count = 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
            dsOGB_Contract_No.Dispose()
        End Function
#End Region

#Region " OGB Get n Set Statement"
        Public Property OGB_Contract_Id() As Integer
            Get
                Return mvarOGB_Contract_Id
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_Contract_Id = Value
            End Set
        End Property

        Public Property OGB_Contract_No() As String
            Get
                Return mvarOGB_Contract_No
            End Get
            Set(ByVal Value As String)
                mvarOGB_Contract_No = Value
            End Set
        End Property

        Public Property OGB_Box_Qty() As Integer
            Get
                Return mvarOGB_Box_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarOGB_Box_Qty = Value
            End Set
        End Property

        Public Property Box_Label() As Integer
            Get
                Return mvarBox_Label
            End Get
            Set(ByVal Value As Integer)
                mvarBox_Label = Value
            End Set
        End Property

        Public Property Strip_Label() As Integer
            Get
                Return mvarStrip_Label
            End Get
            Set(ByVal Value As Integer)
                mvarStrip_Label = Value
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
    End Class

End Namespace
