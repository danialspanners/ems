Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace LVBBusRules
    Public Class LVBBusLogic
#Region " Variable "
        Private mvarIO_Id As Integer
        Private mvarContract_Id As Integer
        Private mvarIO_No As String
        Private mvarParent_IO_Id As Integer
        Private mvarOfficer_In_Charge_Id As Integer
        Private mvarLVB_Section As Integer
        Private mvarLVB_Location As String
        Private mvarLVB_Substation As String
        Private mvarMRC_No As String
        Private mvarDistrict As String
        Private mvarIO_Recv_Date As String
        Private mvarCommence_Date As String
        Private mvarCompletion_Date As String
        Private mvarExtend_Commence_Date As String
        Private mvarExtend_Completion_Date As String
        Private mvarInstallation_Date As String
        Private mvarWorkVerification_Date As String
        Private mvarPaymentClaim_Date As String
        Private mvarDWC_Sent_Date As String
        Private mvarTOC_Return_Date As String
        Private mvarInspection_Date As String
        Private mvarInvoice_No As String
        Private mvarInvoice_Date As String
        Private mvarSubcont_Invoice_No As String
        Private mvarSubcont_Invoice_Date As String
        Private mvarOverTime_Charge As Decimal
        Private mvarRemarks As String
        Private mvarIndex_No As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String

        Private mvarAttnLVB28 As String
#End Region

#Region " Function "

		Public Function GetLVBNotification(ByRef ds As DataSet, ByVal pTransactDate As Date) As Boolean
			With New DataAccess.DAccess.Access
				Dim SQLStr As String

				SQLStr = "set dateformat dmy;SELECT * "
				SQLStr = SQLStr & " FROM LVBPrintNotification a "
				SQLStr = SQLStr & " inner join LVBFiler b ON a.IO_Id = b.IO_Id"
                SQLStr = SQLStr & " inner join LVBContract c ON a.Contractor_Id = c.Contract_Id"
				SQLStr = SQLStr & " WHERE a.Transact_Date='" & pTransactDate & "'"
				'Else
				'SQLStr = "SELECT * FROM OGBFiler where contract_id =" & pContract_Id
	
				If .GetDataSet(ds, SQLStr) Then
					Return True
				End If
			End With
        End Function

        Public Function GetLVBNotificationDate(ByRef ds As DataSet, ByVal pContract_ID As Integer, ByVal pTransactDate As Date) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "set dateformat dmy;SELECT a.IO_ID, a.Contractor_ID ,a.Transact_Date"
                SQLStr = SQLStr & " FROM LVBPrintNotification a "
                SQLStr = SQLStr & " inner join LVBFiler b ON a.IO_Id = b.IO_Id"
                SQLStr = SQLStr & " inner join LVBContract c ON a.Contractor_Id = c.Contract_Id"
                SQLStr = SQLStr & " WHERE a.Transact_Date='" & pTransactDate & "' and a.Contractor_Id=" & pContract_ID
                'Else
                'SQLStr = "SELECT * FROM OGBFiler where contract_id =" & pContract_Id

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetLVBF28(ByRef ds As DataSet, ByVal pTransactDate As Date) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "set dateformat dmy;SELECT * "
                SQLStr = SQLStr & " FROM LVBF28 a "
                SQLStr = SQLStr & " inner join LVBFiler b ON a.IO_Id = b.IO_Id"
                SQLStr = SQLStr & " inner join LVBContract c ON a.Contractor_Id = c.Contract_Id"
                SQLStr = SQLStr & " WHERE a.Transact_Date='" & pTransactDate & "'"
                'Else
                'SQLStr = "SELECT * FROM OGBFiler where contract_id =" & pContract_Id

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetLVBF28Date(ByRef ds As DataSet, ByVal pContract_ID As Integer, ByVal pTransactDate As Date) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "set dateformat dmy;SELECT a.IO_ID, a.Contractor_ID"
                SQLStr = SQLStr & " FROM LVBF28 a "
                SQLStr = SQLStr & " inner join LVBFiler b ON a.IO_Id = b.IO_Id"
                SQLStr = SQLStr & " inner join LVBContract c ON a.Contractor_Id = c.Contract_Id"
                SQLStr = SQLStr & " WHERE a.Transact_Date='" & pTransactDate & "' and a.Contractor_Id=" & pContract_ID
                'Else
                'SQLStr = "SELECT * FROM OGBFiler where contract_id =" & pContract_Id

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveLVBNotification() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO LVBPrintNotification (IO_Id, Contractor_Id, "
                SQLstr = SQLstr & " Create_Date,Transact_Date,UserID ) "
                SQLstr = SQLstr & " VALUES (" & mvarIO_Id & "," & mvarContract_Id & ", GetDate(),'" & mvarTransact_Date & "'," & mvarUserID & ")"

                If .GetDataSet(ds, SQLstr) Then
                    savestatus = True
                Else : savestatus = False
                End If


                ds.Dispose()

            End With
            Return savestatus

        End Function


        Public Function DeleteLVBNotification() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim Delstr As String = "set Dateformat dmy;Delete From LVBPrintNotification where Transact_Date='" & mvarTransact_Date & "' and Contractor_ID=" & Me.mvarContract_Id
                If .GetDataSet(ds, Delstr) Then
                    delsuccess = True
                End If

                ds.Dispose()

            End With
            Return delsuccess

        End Function

        Public Function SaveLVBF28() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO LVBF28 (IO_Id, Contractor_Id, "
                SQLstr = SQLstr & " AttnLVBF28, Create_Date,Transact_Date,UserID ) "
                SQLstr = SQLstr & " VALUES (" & mvarIO_Id & "," & mvarContract_Id & ",'" & mvarAttnLVB28 & "', GetDate(),'" & mvarTransact_Date & "'," & mvarUserID & ")"

                If .GetDataSet(ds, SQLstr) Then
                    savestatus = True
                Else : savestatus = False
                End If


                ds.Dispose()

            End With
            Return savestatus

        End Function


        Public Function DeleteLVBF28() As Boolean
            Dim ds As DataSet
            Dim savestatus As Boolean = False
            Dim delsuccess As Boolean = False

            With New DataAccess.DAccess.Access

                Dim Delstr As String = "set Dateformat dmy;Delete From LVBF28 where Transact_Date='" & mvarTransact_Date & "' and Contractor_ID=" & Me.mvarContract_Id
                If .GetDataSet(ds, Delstr) Then
                    delsuccess = True
                End If

                ds.Dispose()

            End With
            Return delsuccess

        End Function


        Public Function GetIO(ByRef ds As DataSet, Optional ByVal pIO_Id As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Not pIO_Id = 0 Then
                    SQLStr = "SELECT * FROM LVBFiler a LEFT JOIN LVBContract b ON (b.Contract_Id = a.Contract_Id) "

                    SQLStr = SQLStr & " Left Join OfficerInCharge oc on (a.Officer_In_Charge_Id=oc.Officer_In_Charge_Id) "
                    SQLStr = SQLStr & " Left Join Section s on (oc.Section_Id=s.Section_Id) "
                    SQLStr = SQLStr & " where IO_Id = " & Integer.Parse(pIO_Id)
                Else
                    SQLStr = "SELECT * FROM LVBFiler a LEFT JOIN LVBContract b ON (b.Contract_Id = a.Contract_Id) "
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

                SQLStr = "SELECT * FROM LVBFiler where Contract_Id = " & mvarContract_Id

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function


        Public Function GetIOWContractId2(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT a.IO_id, a.Contract_Id, a.IO_no as IO_no, oc.Officer_Name as 'Officer-in-Charge', b.IO_No as 'Previous I/O' "
                SQLStr = SQLStr & " FROM LVBFiler a  "
                SQLStr = SQLStr & " Left Join OfficerInCharge oc on (a.Officer_In_Charge_Id=oc.Officer_In_Charge_Id)"
                SQLStr = SQLStr & " Left join LVBFiler b on (a.Parent_IO_id = b.IO_id)"

                SQLStr = SQLStr & " where a.Contract_Id = " & mvarContract_Id

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetIOWContractIdNSNO(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT Max(a.IO_Id) as Io_Id"
                SQLStr = SQLStr & ",Max(a.Contract_Id) as Contract_Id "
                SQLStr = SQLStr & ", Max(a.IO_no) as IO_No "
                SQLStr = SQLStr & ", Max(a.Installation_Date) as Installation_Date "
                SQLStr = SQLStr & ", Max(a.MRC_No) as MRC_No "
                SQLStr = SQLStr & ", Max(a.Parent_Io_id) as Parent_Io_id"
                SQLStr = SQLStr & ", Max(b.Serial_no) as Serial_no "
                SQLStr = SQLStr & " FROM LVBFiler a left outer join LVBLine b"
                SQLStr = SQLStr & " on a.Io_ID=b.IO_Id"
                SQLStr = SQLStr & " where(a.Contract_Id = " & mvarContract_Id & ")"
                SQLStr = SQLStr & " group by a.IO_Id"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetIOWContractIdRptPendingTOC(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM LVBFiler where Contract_Id = " & mvarContract_Id
                SQLStr = SQLStr & " and TOC_Return_Date is NULL"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetParentIO(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM LVBFiler where (Parent_IO_Id is null OR Parent_IO_Id = 0)"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetParentIOByContract(ByRef ds As DataSet, ByVal pContract_ID As String) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String
                SQLStr = "SELECT * FROM LVBFiler where Contract_ID = " & pContract_ID
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

                SQLStr = "SELECT * FROM LVBFiler where IO_No = '" & pIO_No & "' AND "
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
                    SQLStr = "set dateformat dmy;select * from lvbfiler lvb1 where lvb1.Officer_In_Charge_Id in (SELECT lvb.Officer_In_Charge_Id from LVBPrintNotification lvn "
                    SQLStr = SQLStr & "join LVBFiler lvb on lvb.IO_Id=lvn.IO_ID "
                    SQLStr = SQLStr & "left join OfficerInCharge oc on lvb.Officer_In_Charge_Id = oc.Officer_In_Charge_Id "
                    SQLStr = SQLStr & " where lvn.Contractor_ID = " & Long.Parse(pContract_id) & " And lvn.Transact_Date='" & pTransactDate & "')"
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

                SQLStr = "SELECT MAX(Index_No) as Index_No FROM LVBFiler "

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

        Public Function SaveIOForFirstTime() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO LVBFiler "
                SQLstr = SQLstr & "(Contract_Id,Create_Date,Transact_Date,UserID) "
                SQLstr = SQLstr & " VALUES (" & mvarContract_Id & ",Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as IO_Id FROM LVBFiler"

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarIO_Id = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateIndexNo()
            Dim ds As DataSet
            Dim SQLStr As String = "UPDATE LVBFiler SET "
            SQLStr = SQLStr & " Index_No = '" & mvarIndex_No & "'"
            SQLStr = SQLStr & " ,UserID = " & mvarUserID
            SQLStr = SQLStr & " ,Transact_Date = GetDate() "
            SQLStr = SQLStr & " WHERE IO_Id = " & mvarIO_Id

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Function UpdateLVBIO() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;UPDATE LVBFiler SET "

                SQLstr = SQLstr & " IO_No = '" & mvarIO_No & "',"
                If Len(mvarParent_IO_Id) > 0 Then
                    SQLstr = SQLstr & " Parent_IO_Id = " & mvarParent_IO_Id & ","
                End If

                SQLstr = SQLstr & " Officer_In_Charge_Id = " & mvarOfficer_In_Charge_Id & ","

                'If Len(mvarLVB_Section) > 0 Then
                'SQLstr = SQLstr & " LVB_Section = " & mvarLVB_Section & ","
                'End If
                'SQLstr = SQLstr & " LVB_Location = '" & mvarLVB_Location & "',"
                If Len(mvarLVB_Location) > 0 Then
                    SQLstr = SQLstr & " LVB_Location = '" & Replace(mvarLVB_Location, "'", "''") & "',"
                End If
                If Len(mvarLVB_Substation) > 0 Then
                    SQLstr = SQLstr & " LVB_Substation = '" & Replace(mvarLVB_Substation, "'", "''") & "',"
                End If
                If Len(mvarMRC_No) > 0 Then
                    SQLstr = SQLstr & " MRC_No = '" & mvarMRC_No & "',"
                End If

                If Len(mvarDistrict) > 0 Then
                    SQLstr = SQLstr & " District = '" & mvarDistrict & "',"
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

                If Len(mvarInspection_Date) > 0 Then
                    SQLstr = SQLstr & " Inspection_Date = '" & mvarInspection_Date & "',"
                Else
                    SQLstr = SQLstr & " Inspection_Date = NULL,"
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

                If Len(mvarSubcont_Invoice_No) > 0 Then
                    SQLstr = SQLstr & " Subcont_Invoice_No = '" & mvarSubcont_Invoice_No & "',"
                Else
                    SQLstr = SQLstr & " Subcont_Invoice_No = Null,"
                End If

                If Len(mvarSubcont_Invoice_Date) > 0 Then
                    SQLstr = SQLstr & " Subcont_Invoice_Date = '" & mvarSubcont_Invoice_Date & "',"
                Else
                    SQLstr = SQLstr & " Subcont_Invoice_Date = Null,"
                End If

                If Len(mvarOverTime_Charge) > 0 Then
                    SQLstr = SQLstr & " OverTime_Charge = " & mvarOverTime_Charge & ","
                Else
                    SQLstr = SQLstr & " OverTime_Charge = Null,"
                End If

                If Len(mvarRemarks) > 0 Then
                    SQLstr = SQLstr & " Remarks = '" & mvarRemarks & "',"
                Else
                    SQLstr = SQLstr & " Remarks = Null,"
                End If

               
                SQLstr = SQLstr & " Transact_Date = GetDate () ,"
                SQLstr = SQLstr & " UserID = " & mvarUserID & " WHERE "
                SQLstr = SQLstr & "IO_ID = " & mvarIO_Id

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveIO(ByRef IOID As Integer) As Boolean
            Dim ds As DataSet
            IOID = Nothing
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO LVBFiler "

                SQLstr = SQLstr & "(Contract_Id, IO_No, "
                If Len(mvarParent_IO_Id) > 0 Then
                    SQLstr = SQLstr & "Parent_IO_Id, "
                End If
                SQLstr = SQLstr & "Officer_In_Charge_Id, "
                'If Len(mvarLVB_Section) > 0 Then
                'SQLstr = SQLstr & "LVB_Section, "
                'End If
                If Len(mvarLVB_Location) > 0 Then
                    SQLstr = SQLstr & "LVB_Location, "
                End If
                If Len(mvarLVB_Substation) > 0 Then
                    SQLstr = SQLstr & "LVB_Substation, "
                End If
                If Len(mvarMRC_No) > 0 Then
                    SQLstr = SQLstr & "MRC_No, "
                End If
                If Len(mvarDistrict) > 0 Then
                    SQLstr = SQLstr & "District, "
                End If
                SQLstr = SQLstr & "IO_Recv_Date, "
                SQLstr = SQLstr & "Commence_Date, "
                SQLstr = SQLstr & "Completion_Date, "
                If Len(mvarExtend_Commence_Date) > 0 Then
                    SQLstr = SQLstr & "Extend_Commence_Date, "
                End If
                If Len(mvarExtend_Completion_Date) > 0 Then
                    SQLstr = SQLstr & "Extend_Completion_Date, "
                End If
                If Len(mvarInstallation_Date) > 0 Then
                    SQLstr = SQLstr & "Installation_Date, "
                End If
                If Len(mvarWorkVerification_Date) > 0 Then
                    SQLstr = SQLstr & " WorkVerification_Date, "
                End If
                If Len(mvarPaymentClaim_Date) > 0 Then
                    SQLstr = SQLstr & " PaymentClaim_Date, "
                End If
                If Len(mvarDWC_Sent_Date) > 0 Then
                    SQLstr = SQLstr & "DWC_Sent_Date, "
                End If
                If Len(mvarTOC_Return_Date) > 0 Then
                    SQLstr = SQLstr & "TOC_Return_Date, "
                End If
                If Len(mvarInspection_Date) > 0 Then
                    SQLstr = SQLstr & "Inspection_Date, "
                End If
                If Len(mvarInvoice_No) > 0 Then
                    SQLstr = SQLstr & "Invoice_No, "
                End If
                If Len(mvarInvoice_Date) > 0 Then
                    SQLstr = SQLstr & "Invoice_Date, "
                End If
                If Len(mvarSubcont_Invoice_No) > 0 Then
                    SQLstr = SQLstr & "Subcont_Invoice_No, "
                End If
                If Len(mvarSubcont_Invoice_Date) > 0 Then
                    SQLstr = SQLstr & "Subcont_Invoice_Date, "
                End If
                If Len(mvarOverTime_Charge) > 0 Then
                    SQLstr = SQLstr & "OverTime_Charge, "
                End If
                If Len(mvarRemarks) > 0 Then
                    SQLstr = SQLstr & "Remarks, "       ' = 
                End If
                SQLstr = SQLstr & "Create_Date, Transact_Date,UserID)"

                SQLstr = SQLstr & " VALUES (" & mvarContract_Id & ",'" & mvarIO_No & "',"
                If Len(mvarParent_IO_Id) > 0 Then
                    SQLstr = SQLstr & mvarParent_IO_Id & ","
                End If
                SQLstr = SQLstr & mvarOfficer_In_Charge_Id & ","
                'If Len(mvarLVB_Section) > 0 Then
                'SQLstr = SQLstr & mvarLVB_Section & ","
                'End If
                If Len(mvarLVB_Location) > 0 Then
                    SQLstr = SQLstr & "'" & Replace(mvarLVB_Location, "'", "''") & "',"
                End If
                If Len(mvarLVB_Substation) > 0 Then
                    SQLstr = SQLstr & "'" & Replace(mvarLVB_Substation, "'", "''") & "',"
                End If
                If Len(mvarMRC_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarMRC_No & "',"
                End If
                If Len(mvarDistrict) > 0 Then
                    SQLstr = SQLstr & "'" & mvarDistrict & "',"
                End If
                SQLstr = SQLstr & "'" & mvarIO_Recv_Date & "','" & mvarCommence_Date & "','" & mvarCompletion_Date & "',"
                If Len(mvarExtend_Commence_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarExtend_Commence_Date & "',"
                End If
                If Len(mvarExtend_Completion_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarExtend_Completion_Date & "',"
                End If
                If Len(mvarInstallation_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarInstallation_Date & "',"
                End If
                If Len(mvarWorkVerification_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarWorkVerification_Date & "', "
                End If
                If Len(mvarPaymentClaim_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarPaymentClaim_Date & "', "
                End If
                If Len(mvarDWC_Sent_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarDWC_Sent_Date & "',"
                End If
                If Len(mvarTOC_Return_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarTOC_Return_Date & "',"
                End If
                If Len(mvarInspection_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarInspection_Date & "',"
                End If
                If Len(mvarInvoice_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarInvoice_No & "',"
                End If
                If Len(mvarInvoice_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarInvoice_Date & "',"
                End If
                If Len(mvarSubcont_Invoice_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarSubcont_Invoice_No & "',"
                End If
                If Len(mvarSubcont_Invoice_Date) > 0 Then
                    SQLstr = SQLstr & "'" & mvarSubcont_Invoice_Date & "',"
                End If
                If Len(mvarOverTime_Charge) > 0 Then
                    SQLstr = SQLstr & mvarOverTime_Charge & ","
                End If
                If Len(mvarRemarks) > 0 Then
                    SQLstr = SQLstr & "'" & mvarRemarks & "',"
                End If
                SQLstr = SQLstr & "GetDate(),GetDate(),'" & mvarUserID & "')"
                SQLstr = SQLstr & "(SELECT @@IDENTITY AS IO_ID from LVBFiler)"

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        IOID = Integer.Parse(ds.Tables(0).Rows(0).Item(0).ToString)
                    End If
                    Return True
                Else
                    Return False
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteOneIO() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "DELETE FROM LVBLine WHERE IO_ID = " & mvarIO_Id
                SQLstr = SQLstr & ";DELETE FROM LVBFiler WHERE IO_ID = " & mvarIO_Id

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " LVB Notification Installation Report "
		Public Function GetDistinctLVBLocation(ByRef ds As DataSet)
			Dim SQLStr As String
			SQLStr = "select distinct LVB_Location, IO_NO from LVBFiler"
			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLStr) Then
					Return True
				End If
			End With
		End Function

        Public Function GetNotificationLVBInstallReport(ByRef ds As DataSet, ByVal pEdit_Date As Date, ByVal pstrIO_ID As String)
            Dim SQLStr As String

            SQLStr = "SELECT '" & pEdit_Date & "' as Edit_Date,a.contract_id, f.Contract_No, a.Index_No, a.IO_No, e.Box_Name AS Box_Name, d.Bus_Section AS Bus_Section, d.OutLink100 AS OutLink100, d.SupInsOutLink1000 as SupInsOutLink1000,"
            'SupIns630Unit
            SQLStr = SQLStr & " d.SupIns630Unit as SupIns630Unit,"
            SQLStr = SQLStr & " d.UsedInstall as UsedInstall,"
            SQLStr = SQLStr & " d.Insulation_Cover as Insulation_Cover,"
            SQLStr = SQLStr & " d.OT2 as OT2,"
            SQLStr = SQLStr & " d.OutLink500 AS OutLink500, d.RepoOutLink as RepoOutLink, d.SynConn as SynConn, d.CableLug1Hole, d.CableLug2Hole, d.Serial_No, d.install,a.LVB_Location,a.LVB_Substation, a.Remarks, b.Officer_Name, c.Section_Code AS Section_Code "
            SQLStr = SQLStr & " FROM LVBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBLine d ON a.IO_Id = d.IO_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBBox e ON d.Box_Type_Id = e.Box_Type_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBContract f ON a.Contract_Id = f.Contract_Id "
            SQLStr = SQLStr & " WHERE (a.IO_Id IN (" & pstrIO_ID & ")) "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

#Region " LVB Request F28 Report "
		Public Function GetForm28Report(ByRef ds As DataSet, ByVal pstrIO_ID As String, _
										ByVal pAttention_Name As String, ByVal pEdit_Date As String)
			Dim SQLStr As String

			SQLStr = "SELECT f.Contract_No, a.IO_No, a.MRC_No, '" & pAttention_Name & "' as Attention_Name, "
			'2004.3.21 YG Start'
			'SQLStr = SQLStr & " b.Contact_Location as LVB_Location, b.Officer_Name, c.Section_Code, '" & pEdit_Date & "' as Edit_Date "
            SQLStr = SQLStr & " a.LVB_Location,a.LVB_Substation, b.Officer_Name, c.Section_Code, '" & pEdit_Date & "' as Edit_Date "
			'2004.3.21 YG End'
			SQLStr = SQLStr & " FROM LVBFiler a LEFT OUTER JOIN "
			SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "
			SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
			SQLStr = SQLStr & " LVBContract f ON a.Contract_Id = f.Contract_Id "
			SQLStr = SQLStr & " WHERE (a.IO_Id IN (" & pstrIO_ID & ")) "

			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLStr) Then
					Return True
				End If
			End With
		End Function

#End Region

#Region " LVB Declaration Work Completion "
		Public Function GetDWCReport(ByRef ds As DataSet, ByVal pIO_ID As Integer)
			Dim SQLStr As String
			Dim Bus_section As Integer = 0
			Dim LTB_Label As Integer = 0
			Dim Strip_Label As Integer = 0
			Dim OT As Integer = 0
			Dim OutLink500 As Integer = 0
            Dim OutLink100 As Integer = 0
            Dim SupInsOutLink1000 As Integer = 0
            Dim SupIns630Unit As Integer = 0
            Dim UsedInstall As Integer = 0
            Dim Insulation_Cover As Integer = 0
            Dim OT2 As Integer = 0
            Dim RepoOutLink As Integer = 0

			SQLStr = "SELECT SUM(Bus_Section) as Bus_Section, SUM(LTB_Label) as LTB_Label, "
			SQLStr = SQLStr & " SUM(Strip_Label) as Strip_Label, SUM(OT) as OT, "
            SQLStr = SQLStr & " SUM(SupInsOutLink1000) as SupInsOutLink1000, "
            SQLStr = SQLStr & " SUM(SupIns630Unit) as SupIns630Unit, "
            SQLStr = SQLStr & " SUM(UsedInstall) as UsedInstall, "
            SQLStr = SQLStr & " SUM(Insulation_Cover) as Insulation_Cover, "
            SQLStr = SQLStr & " SUM(OT2) as OT2, "
            SQLStr = SQLStr & " SUM(OutLink500) as OutLink500, SUM(RepoOutLink) as RepoOutLink, SUM(OutLink100) as OutLink100 "
			SQLStr = SQLStr & " FROM LVBLine WHERE IO_Id = " & pIO_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLStr) Then
					If ds.Tables(0).Rows(0)("Bus_Section") > 0 Then
						Bus_section = ds.Tables(0).Rows(0)("Bus_Section")
					End If

                    If ds.Tables(0).Rows(0)("LTB_Label") > 0 Then
                        LTB_Label = ds.Tables(0).Rows(0)("LTB_Label")
                    End If

					If ds.Tables(0).Rows(0)("Strip_Label") > 0 Then
						Strip_Label = ds.Tables(0).Rows(0)("Strip_Label")
					End If

                    If ds.Tables(0).Rows(0)("OT") > 0 Then              'To check OverTimed Work
                        OT = ds.Tables(0).Rows(0)("OT")
                    End If

					If ds.Tables(0).Rows(0)("OutLink500") > 0 Then
						OutLink500 = ds.Tables(0).Rows(0)("OutLink500")
					End If

					If ds.Tables(0).Rows(0)("OutLink100") > 0 Then
						OutLink100 = ds.Tables(0).Rows(0)("OutLink100")
                    End If

                    If ds.Tables(0).Rows(0)("SupInsOutLink1000") > 0 Then
                        SupInsOutLink1000 = ds.Tables(0).Rows(0)("SupInsOutLink1000")
                    End If
                    'SupIns630Unit
                    If ds.Tables(0).Rows(0)("SupIns630Unit") > 0 Then
                        SupIns630Unit = ds.Tables(0).Rows(0)("SupIns630Unit")
                    End If

                    If ds.Tables(0).Rows(0)("UsedInstall") > 0 Then
                        UsedInstall = ds.Tables(0).Rows(0)("UsedInstall")
                    End If

                    If ds.Tables(0).Rows(0)("Insulation_Cover") > 0 Then
                        Insulation_Cover = ds.Tables(0).Rows(0)("Insulation_Cover")
                    End If

                    If ds.Tables(0).Rows(0)("OT2") > 0 Then
                        OT2 = ds.Tables(0).Rows(0)("OT2")
                    End If

                    If ds.Tables(0).Rows(0)("RepoOutLink") > 0 Then
                        RepoOutLink = ds.Tables(0).Rows(0)("RepoOutLink")
                    End If
                End If
            End With

			'SQLStr = "SELECT c.Box_Name, COUNT(b.Box_Type_Id) AS Qty, d.Contract_No, "
            SQLStr = "SELECT  d.Contract_No, "
			'2004.3.21 YG Start'
            SQLStr = SQLStr & " a.IO_No, a.LVB_Location,a.LVB_Substation, e.Officer_Name, "
			'SQLStr = SQLStr & " a.IO_No, e.Contact_Location as LVB_Location, b.Serial_No, e.Officer_Name, "
			'2004.3.21 YG End'
            SQLStr = SQLStr & " a.DWC_Sent_Date,a.Completion_Date, a.Extend_Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Inspection_Date, a.Remarks "
			SQLStr = SQLStr & " ,f.Section_Code "
			If Bus_section > 0 Then
				SQLStr = SQLStr & ",'" & Bus_section & "' as Bus_Section "
				SQLStr = SQLStr & ",'Bus-Section Unit' as Bus_Section_Label "
			End If

			If LTB_Label > 0 Then
				SQLStr = SQLStr & ",'" & LTB_Label & "' as LTB_Label "
				SQLStr = SQLStr & ",'LTB' as LTB_Label_Label "
			End If

			If Strip_Label > 0 Then
				SQLStr = SQLStr & ",'" & Strip_Label & "' as Strip_Label "
				SQLStr = SQLStr & ",'Strip' as Strip_Label_Label "
			End If

			If OT > 0 Then
				SQLStr = SQLStr & ",'" & OT & "' as OT "
				SQLStr = SQLStr & ",'OT' as OT_Label "
			End If

			If OutLink500 > 0 Then
				SQLStr = SQLStr & ",'" & OutLink500 & "' as OutLink500 "
				SQLStr = SQLStr & ",'OutLink 500' as OutLink500_Label "
			End If

			If OutLink100 > 0 Then
				SQLStr = SQLStr & ",'" & OutLink100 & "' as OutLink100 "
				SQLStr = SQLStr & ",'OutLink 1000' as OutLink100_Label "
            End If
            'SupInsOutLink1000
            If SupInsOutLink1000 > 0 Then
                SQLStr = SQLStr & ",'" & SupInsOutLink1000 & "' as SupInsOutLink1000"
                SQLStr = SQLStr & ",'SUP & INS OUTGOING LINK @ SITE' as SupInsOutLink1000_Label "
            End If
            'SupIns630Unit
            If SupIns630Unit > 0 Then
                SQLStr = SQLStr & ",'" & SupIns630Unit & "' as SupIns630Unit"
                SQLStr = SQLStr & ",'SUP & INS 630A DIN DIST UNIT @ SITE' as SupIns630Unit_Label "
            End If

            If UsedInstall > 0 Then
                SQLStr = SQLStr & ",'" & UsedInstall & "' as UsedInstall"
                SQLStr = SQLStr & ",'Used LTB Installation' as UsedInstall_Label "
            End If

            If Insulation_Cover > 0 Then
                SQLStr = SQLStr & ",'" & Insulation_Cover & "' as Insulation_Cover"
                SQLStr = SQLStr & ",'INSULATION COVER, FOR OUTGOING LINK' as Insulation_Cover_Label "
            End If

            If OT2 > 0 Then
                SQLStr = SQLStr & ",'" & OT2 & "' as OT2"
                SQLStr = SQLStr & ",'OT Variation 1' as OT2_Label "
            End If

            If RepoOutLink > 0 Then
                SQLStr = SQLStr & ",'" & RepoOutLink & "' as RepoOutLink "
                SQLStr = SQLStr & ",'Reposition of outgoing link unit' as RepoOutLink_Label "
            End If



            SQLStr = SQLStr & " FROM LVBFiler a LEFT OUTER JOIN "
            'SQLStr = SQLStr & " LVBLine b ON a.IO_Id = b.IO_Id LEFT OUTER JOIN "
            'SQLStr = SQLStr & " LVBBox c ON b.Box_Type_Id = c.Box_Type_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBContract d ON a.Contract_Id = d.Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            SQLStr = SQLStr & " WHERE a.IO_Id = " & pIO_ID & " GROUP BY "
            '2004.03.21 YG Start'
            'SQLStr = SQLStr & " c.Box_Name, d.Contract_No, a.IO_No, e.Contact_Location, b.Serial_No, "
            'SQLStr = SQLStr & " c.Description, d.Contract_No, a.IO_No, a.LVB_Location, b.Serial_No, "
            SQLStr = SQLStr & " d.Contract_No, a.IO_No, a.LVB_Location,a.LVB_Substation, "
            'SQLStr = SQLStr & " c.Description, d.Contract_No, a.IO_No, e.Contact_Location, b.Serial_No, "
            '2004.03.21 YG End'
            SQLStr = SQLStr & " e.Officer_Name, a.DWC_Sent_date,a.Completion_Date, a.Extend_Completion_Date, a.Installation_Date,a.WorkVerification_Date, a.PaymentClaim_Date, a.Inspection_Date, a.Remarks "
            SQLStr = SQLStr & " ,f.Section_Code "
            'MsgBox(SQLStr)
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
		End Function

		Public Function GetDWCLabelReport(ByRef ds As DataSet, ByVal pIO_ID As Integer)
			Dim SQLStr As String
			Dim Bus_section As Integer = 0
			Dim LTB_Label As Integer = 0
			Dim Strip_Label As Integer = 0
			Dim OT As Integer = 0
			Dim OutLink500 As Integer = 0
            Dim OutLink100 As Integer = 0
            Dim SupInsOutLink1000 As Integer = 0
            Dim SupIns630Unit As Integer = 0
            Dim UsedInstall As Integer = 0
            Dim Insulation_Cover As Integer = 0
            Dim OT2 As Integer = 0
            Dim RepoOutLink As Integer = 0

			SQLStr = "SELECT SUM(Bus_Section) as Bus_Section, SUM(LTB_Label) as LTB_Label, "
			SQLStr = SQLStr & " SUM(Strip_Label) as Strip_Label, SUM(OT) as OT, "
            SQLStr = SQLStr & " SUM(OutLink500) as OutLink500, SUM(OutLink100) as OutLink100, SUM(SupInsOutLink1000) as SupInsOutLink1000, "
            SQLStr = SQLStr & " SUM(SupIns630Unit) as SupIns630Unit, "
            SQLStr = SQLStr & " SUM(UsedInstall) as UsedInstall, "
            SQLStr = SQLStr & " SUM(Insulation_Cover) as Insulation_Cover, "
            SQLStr = SQLStr & " SUM(OT2) as OT2, "
            SQLStr = SQLStr & " SUM(RepoOutLink) as RepoOutLink "
			SQLStr = SQLStr & " FROM LVBLine WHERE IO_Id = " & pIO_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLStr) Then
					If ds.Tables(0).Rows(0)("Bus_Section") > 0 Then
						Bus_section = ds.Tables(0).Rows(0)("Bus_Section")
					End If

					If ds.Tables(0).Rows(0)("LTB_Label") > 0 Then
						LTB_Label = ds.Tables(0).Rows(0)("LTB_Label")
					End If

					If ds.Tables(0).Rows(0)("Strip_Label") > 0 Then
						Strip_Label = ds.Tables(0).Rows(0)("Strip_Label")
					End If

					If ds.Tables(0).Rows(0)("OT") > 0 Then
						OT = ds.Tables(0).Rows(0)("OT")
					End If

					If ds.Tables(0).Rows(0)("OutLink500") > 0 Then
						OutLink500 = ds.Tables(0).Rows(0)("OutLink500")
					End If

					If ds.Tables(0).Rows(0)("OutLink100") > 0 Then
						OutLink100 = ds.Tables(0).Rows(0)("OutLink100")
                    End If
                    'SupInsOutLink1000
                    If ds.Tables(0).Rows(0)("SupInsOutLink1000") > 0 Then
                        SupInsOutLink1000 = ds.Tables(0).Rows(0)("SupInsOutLink1000")
                    End If
                    'SupIns630Unit
                    If ds.Tables(0).Rows(0)("SupIns630Unit") > 0 Then
                        SupIns630Unit = ds.Tables(0).Rows(0)("SupIns630Unit")
                    End If

                    If ds.Tables(0).Rows(0)("UsedInstall") > 0 Then
                        UsedInstall = ds.Tables(0).Rows(0)("UsedInstall")
                    End If

                    If ds.Tables(0).Rows(0)("Insulation_Cover") > 0 Then
                        Insulation_Cover = ds.Tables(0).Rows(0)("Insulation_Cover")
                    End If

                    If ds.Tables(0).Rows(0)("OT2") > 0 Then
                        OT2 = ds.Tables(0).Rows(0)("OT2")
                    End If

                    If ds.Tables(0).Rows(0)("RepoOutLink") > 0 Then
                        RepoOutLink = ds.Tables(0).Rows(0)("RepoOutLink")
                    End If
                End If
            End With

			'SQLStr = "SELECT c.Box_Name, COUNT(b.Box_Type_Id) AS Qty, d.Contract_No, "
            SQLStr = "SELECT count(b.Install) as Install, c.Description, COUNT(b.Box_Type_Id) AS Qty, d.Contract_No, "
			' 2004.03.21 YG Start '
            SQLStr = SQLStr & " a.IO_No, a.LVB_Location,a.LVB_Substation, b.Serial_No, e.Officer_Name, "
			'SQLStr = SQLStr & " a.IO_No, e.Contact_Location as LVB_Location, b.Serial_No, e.Officer_Name, "
			' 2004.03.21 YG End '
            SQLStr = SQLStr & " a.DWC_Sent_date,a.MRC_No,a.Completion_Date,a.Extend_Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Inspection_Date, a.Remarks "
			SQLStr = SQLStr & " ,f.Section_Code "
			If Bus_section > 0 Then
				SQLStr = SQLStr & ",'" & Bus_section & "' as Bus_Section "
				SQLStr = SQLStr & ",'Bus-Section Unit' as Bus_Section_Label "
			End If

            'If LTB_Label > 0 Then
            SQLStr = SQLStr & ",'" & LTB_Label & "' as LTB_Label "
            SQLStr = SQLStr & ",'LTB' as LTB_Label_Label "
            'End If

            'If Strip_Label > 0 Then
            SQLStr = SQLStr & ",'" & Strip_Label & "' as Strip_Label "
            SQLStr = SQLStr & ",'Strip' as Strip_Label_Label "
            'End If

			If OT > 0 Then
				SQLStr = SQLStr & ",'" & OT & "' as OT "
				SQLStr = SQLStr & ",'OT' as OT_Label "
			End If

			If OutLink500 > 0 Then
				SQLStr = SQLStr & ",'" & OutLink500 & "' as OutLink500 "
				SQLStr = SQLStr & ",'OutLink 500' as OutLink500_Label "
			End If

			If OutLink100 > 0 Then
				SQLStr = SQLStr & ",'" & OutLink100 & "' as OutLink100 "
				SQLStr = SQLStr & ",'OutLink 100' as OutLink100_Label "
            End If

            'SupInsOutLink1000
            If SupInsOutLink1000 > 0 Then
                SQLStr = SQLStr & ",'" & SupInsOutLink1000 & "' as SupInsOutLink1000 "
                SQLStr = SQLStr & ",'SUP & INS OUTGOING LINK @ SITE' as SupInsOutLink1000_Label "
            End If
            'SupIns630Unit
            If SupIns630Unit > 0 Then
                SQLStr = SQLStr & ",'" & SupIns630Unit & "' as SupIns630Unit "
                SQLStr = SQLStr & ",'SUP & INS 630A DIN DIST UNIT @ SITE' as SupIns630Unit_Label "
            End If

            If UsedInstall > 0 Then
                SQLStr = SQLStr & ",'" & UsedInstall & "' as UsedInstall "
                SQLStr = SQLStr & ",'Used LTB Installation' as UsedInstall_Label "
            End If

            If Insulation_Cover > 0 Then
                SQLStr = SQLStr & ",'" & Insulation_Cover & "' as Insulation_Cover "
                SQLStr = SQLStr & ",'INSULATION COVER, FOR OUTGOING LINK' as Insulation_Cover_Label "
            End If

            If OT2 > 0 Then
                SQLStr = SQLStr & ",'" & OT2 & "' as OT2 "
                SQLStr = SQLStr & ",'OT Variation 1' as OT2_Label "
            End If

            If RepoOutLink > 0 Then
                SQLStr = SQLStr & ",'" & RepoOutLink & "' as RepoOutLink "
                SQLStr = SQLStr & ",'Reposition of outgoing link unit' as RepoOutLink_Label "
            End If

            SQLStr = SQLStr & " FROM LVBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBLine b ON a.IO_Id = b.IO_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBBox c ON b.Box_Type_Id = c.Box_Type_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBContract d ON a.Contract_Id = d.Contract_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge e ON a.Officer_In_Charge_Id = e.Officer_In_Charge_Id "
            SQLStr = SQLStr & " LEFT OUTER JOIN Section f ON e.Section_ID = f.Section_Id "
            SQLStr = SQLStr & " WHERE a.IO_Id = " & pIO_ID & " GROUP BY b.Box_Type_Id, "
            ' 2004.03.21 YG Start '
            'SQLStr = SQLStr & " c.Box_Name, d.Contract_No, a.IO_No, e.Contact_Location, b.Serial_No, "
            SQLStr = SQLStr & " c.Description, d.Contract_No, a.IO_No, a.LVB_Location,a.LVB_Substation, b.Serial_No, "
            'SQLStr = SQLStr & " c.Description, d.Contract_No, a.IO_No, e.Contact_Location, b.Serial_No, "
            ' 2004.03.21 YG End '
            SQLStr = SQLStr & " e.Officer_Name,a.DWC_Sent_date,a.MRC_No,a.Completion_Date, a.Extend_Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Inspection_Date, a.Remarks "
            SQLStr = SQLStr & " ,f.Section_Code "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
		End Function
#End Region

#Region " LVB Reports: LVB Invoicing Status"
        Public Function GetLVBInvoiceStatusReport(ByRef ds As DataSet, ByVal pstrIO_ID As String, ByVal pSection_ID As Integer, ByVal pSortby As Integer, ByVal pShowTOC_Null As Boolean, ByVal pFilters As String)
            Dim SQLStr As String

            SQLStr = "set dateformat dmy;SELECT f.Contract_No, b.Officer_Name, c.Section_Code, a.IO_No, "
            ' 2004.03.21 YG Start'
            SQLStr = SQLStr & " a.LVB_Location,a.LVB_Substation, g.serial_no as serial_no, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Inspection_Date,a.DWC_Sent_Date, a.TOC_Return_date, a.Inspection_Date,a.Invoice_No, a.Invoice_Date "
            ' 2004.03.21 YG End'
            SQLStr = SQLStr & " FROM LVBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBContract f ON a.Contract_Id = f.Contract_Id left outer join "
            SQLStr = SQLStr & " LVBLine g on a.IO_ID = g.IO_ID "
            'SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL "
            'If Len(pstrIO_ID) > 0 Then
            'SQLStr = SQLStr & " WHERE (a.IO_Id IN (" & pstrIO_ID & ")) "
            'End If
            SQLStr = SQLStr & "Where a.Contract_ID = " & pstrIO_ID & " "
            If pSection_ID <> 0 Then
                SQLStr = SQLStr & " and c.Section_Id = " & pSection_ID & " "
            End If
            If pShowTOC_Null = True Then
                SQLStr = SQLStr & " and a.TOC_Return_Date is NULL "
            End If

            If Len(pFilters) > 0 Then
                SQLStr = SQLStr & " and (" & pFilters & ")"
            End If


            SQLStr = SQLStr & " Order by RIGHT('0000000000' + g.Serial_No, 10)"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

        Public Function GetLVBInstallFeedbackReport(ByRef ds As DataSet, ByVal pstrIO_ID As String, ByVal pSection_ID As Integer, ByVal pSortby As Integer, ByVal pShowTOC_Null As Boolean, ByVal pFilters As String)
            Dim SQLStr As String

            SQLStr = "set dateformat dmy;SELECT f.Contract_No, b.Officer_Name, c.Section_Code, a.IO_No, "
            ' 2004.03.21 YG Start'
            SQLStr = SQLStr & " a.LVB_Location,a.LVB_Substation, g.serial_no as serial_no, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Inspection_Date,a.DWC_Sent_Date, a.TOC_Return_date, a.Inspection_Date,a.Invoice_No, a.Invoice_Date "
            SQLStr = SQLStr & ", g.Issues_Flag, g.Issues_Detail "
            ' 2004.03.21 YG End'
            SQLStr = SQLStr & " FROM LVBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBContract f ON a.Contract_Id = f.Contract_Id left outer join "
            SQLStr = SQLStr & " LVBLine g on a.IO_ID = g.IO_ID "
            'SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL "
            'If Len(pstrIO_ID) > 0 Then
            'SQLStr = SQLStr & " WHERE (a.IO_Id IN (" & pstrIO_ID & ")) "
            'End If
            SQLStr = SQLStr & "Where a.Contract_ID = " & pstrIO_ID & " "
            If pSection_ID <> 0 Then
                SQLStr = SQLStr & " and c.Section_Id = " & pSection_ID & " "
            End If
            If pShowTOC_Null = True Then
                SQLStr = SQLStr & " and a.TOC_Return_Date is NULL "
            End If

            If Len(pFilters) > 0 Then
                SQLStr = SQLStr & " and (" & pFilters & ")"
            End If


            SQLStr = SQLStr & " Order by RIGHT('0000000000' + g.Serial_No, 10)"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#Region " LVB Reports: LVB Pending TOC"
        Public Function GetLVBPendingTOCReportSub(ByRef ds As DataSet, ByVal pIO_ID As Integer, ByVal pSortby As Integer)
            Dim SQLStr As String

            SQLStr = "SELECT a.Officer_In_Charge_Id, f.Contract_No, a.IO_No, a.DWC_Sent_Date, a.TOC_Return_date, a.Inspection_Date,a.Remarks,"
            ' 2004.03.21 YG Start '
            SQLStr = SQLStr & " a.LVB_Location,a.LVB_Substation, a.Commence_Date, a.Completion_Date, a.Installation_Date, a.WorkVerification_Date, a.PaymentClaim_Date, a.Inspection_Date,b.Officer_Name, c.Section_Code , g.serial_no as serial_no, "
            'SQLStr = SQLStr & " b.Contact_Location as LVB_Location, a.Commence_Date, a.Completion_Date, a.Installation_Date, b.Officer_Name, c.Section_Code "
            ' 2004.03.21 YG Start '
            SQLStr = SQLStr & "i_install + CASE WHEN i_install <> '' AND i_ltb_label <> '' THEN ', ' ELSE '' END + i_ltb_label"
            SQLStr = SQLStr & "+ CASE WHEN i_offshore <> '' and (i_install <> '' or i_ltb_label <> '') then ', ' else '' end + i_strip_label"
            SQLStr = SQLStr & "+ CASE WHEN i_bus_section <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '') then ', ' else '' end + i_bus_section"
            SQLStr = SQLStr & "+ CASE WHEN i_OT <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '') then ', ' else '' end + i_OT"
            SQLStr = SQLStr & "+ CASE WHEN i_outlink500 <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '') then ', ' else '' end + i_outlink500"

            SQLStr = SQLStr & "+ CASE WHEN i_outlink1000 <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '') then ', ' else '' end + i_outlink1000"

            SQLStr = SQLStr & "+ CASE WHEN i_synconn <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'') then ', ' else '' end + i_synconn"
            SQLStr = SQLStr & "+ CASE WHEN i_cablelug1hole <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '') then ', ' else '' end + i_cablelug1hole"
            SQLStr = SQLStr & "+ CASE WHEN i_cablelug2hole <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '' or i_cablelug1hole <> '') then ', ' else '' end + i_cablelug2hole"

            SQLStr = SQLStr & "+ CASE WHEN i_repooutlink <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '' or i_cablelug1hole <> '' or i_cablelug2hole <>'') then ', ' else '' end + i_repooutlink "
            'SupInsOutLink1000
            SQLStr = SQLStr & "+ CASE WHEN i_SupInsOutLink1000 <> '' and (i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '' or i_cablelug1hole <> '' or i_cablelug2hole <>'' or i_repooutlink <> '') then ', ' else '' end + i_SupInsOutLink1000 "
            'SupIns630Unit
            SQLStr = SQLStr & "+ CASE WHEN i_SupIns630Unit <> '' and (i_SupInsOutLink1000 <> '' or i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '' or i_cablelug1hole <> '' or i_cablelug2hole <>'' or i_repooutlink <> '') then ', ' else '' end + i_SupIns630Unit "
            'UsedInstall
            SQLStr = SQLStr & "+ CASE WHEN i_UsedInstall <> '' and (i_SupIns630Unit <> '' or i_SupInsOutLink1000 <> '' or i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '' or i_cablelug1hole <> '' or i_cablelug2hole <>'' or i_repooutlink <> '') then ', ' else '' end + i_UsedInstall "
            'Insulation_Cover
            SQLStr = SQLStr & "+ CASE WHEN i_Insulation_Cover <> '' and (i_UsedInstall <> '' or i_SupIns630Unit <> '' or i_SupInsOutLink1000 <> '' or i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '' or i_cablelug1hole <> '' or i_cablelug2hole <>'' or i_repooutlink <> '') then ', ' else '' end + i_Insulation_Cover "
            'OT2
            SQLStr = SQLStr & "+ CASE WHEN i_OT2 <> '' and (i_Insulation_Cover <> '' or i_UsedInstall <> '' or i_SupIns630Unit <> '' or i_SupInsOutLink1000 <> '' or i_install <> '' or i_ltb_label <> '' or i_strip_label <> '' or i_bus_section <> '' or i_OT <> '' or i_outlink500 <> '' or i_outlink1000<>'' or i_synconn <> '' or i_cablelug1hole <> '' or i_cablelug2hole <>'' or i_repooutlink <> '') then ', ' else '' end + i_OT2 as items"


            SQLStr = SQLStr & " FROM LVBFiler a INNER JOIN "
            SQLStr = SQLStr & "(SELECT io_id, Serial_No, CASE WHEN ltb_label = 1 THEN 'ltb label =1' ELSE '' END AS i_ltb_label, "
            SQLStr = SQLStr & "CASE WHEN install = 1 THEN 'Install =1' ELSE '' END AS i_install,"
            SQLStr = SQLStr & "CASE WHEN offshore = 1 THEN 'Offshore =1' ELSE '' END AS i_offshore,"
            SQLStr = SQLStr & "CASE WHEN strip_label = 1 THEN 'Strip Label =1' ELSE '' END AS i_strip_label,"
            SQLStr = SQLStr & "CASE WHEN bus_section = 1 THEN 'Bus Section =1' ELSE '' END AS i_bus_section,"
            SQLStr = SQLStr & "CASE WHEN OT = 1 THEN 'OT =1' ELSE '' END AS i_OT,"
            SQLStr = SQLStr & "CASE WHEN outlink500 = 1 THEN 'Outlink 500mm =1' ELSE '' END AS i_outlink500,"
            SQLStr = SQLStr & "CASE WHEN outlink100 = 1 THEN 'Outlink 1000mm =1' ELSE '' END AS i_outlink1000,"
            'SupInsOutLink1000
            SQLStr = SQLStr & "CASE WHEN SupInsOutLink1000 = 1 THEN 'SUP INS Outlink =1' ELSE '' END AS i_SupInsOutLink1000,"
            'SupIns630Unit
            SQLStr = SQLStr & "CASE WHEN SupIns630Unit = 1 THEN 'SUP INS 630A Unit =1' ELSE '' END AS i_SupIns630Unit,"
            SQLStr = SQLStr & "CASE WHEN UsedInstall = 1 THEN 'Used LTB Installation =1' ELSE '' END AS i_UsedInstall,"
            SQLStr = SQLStr & "CASE WHEN Insulation_Cover = 1 THEN 'INSULATION COVER =1' ELSE '' END AS i_Insulation_Cover,"
            SQLStr = SQLStr & "CASE WHEN OT2 = 1 THEN 'OT Variation 1 =1' ELSE '' END AS i_OT2,"

            SQLStr = SQLStr & "CASE WHEN repooutlink = 1 THEN 'Reposition Outlink =1' ELSE '' END as i_repooutlink,"
            SQLStr = SQLStr & "CASE WHEN SynConn = 1 THEN 'Synchronising Connector =1' ELSE '' END AS i_SynConn,"
            SQLStr = SQLStr & "CASE WHEN Cablelug1hole = 1 THEN 'Cable Lug 1-Hole =1' ELSE '' END AS i_Cablelug1hole,"
            SQLStr = SQLStr & "CASE WHEN Cablelug2hole = 1 THEN 'Cable Lug 2-Hole =1' ELSE '' END AS i_Cablelug2hole"
            SQLStr = SQLStr & " FROM lvbline) g ON a.IO_Id = g.io_id LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBContract f ON a.Contract_Id = f.Contract_Id "
            SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL and a.DWC_Sent_Date IS NOT NULL  "
            'If Len(pstrIO_ID) > 0 Then
            'SQLStr = SQLStr & " WHERE (a.IO_Id IN (" & pstrIO_ID & ")) "
            'End If

            SQLStr = SQLStr & " and f.Contract_Id = " & pIO_ID & " "
            If pSortby = 0 Then
                SQLStr = SQLStr & "order by a.IO_No ASC"
            ElseIf pSortby = 1 Then
                SQLStr = SQLStr & "order by a.DWC_Sent_Date ASC"
            End If

            Return SQLStr
            'With New DataAccess.DAccess.Access
            'If .GetDataSet(ds, SQLStr) Then
            'Return True
            'End If
            'End With
        End Function


        Public Function GetLVBPendingTOCReport(ByRef ds As DataSet, ByVal pIO_ID As Integer, ByVal pSortby As Integer)
            Dim SQLStr As String

            SQLStr = "SELECT DISTINCT a.Officer_In_Charge_Id, f.Contract_No, b.Officer_Name From LVBFiler a LEFT OUTER JOIN "
            SQLStr = SQLStr & " OfficerInCharge b ON a.Officer_In_Charge_Id = b.Officer_In_Charge_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " Section c ON b.Section_ID = c.Section_Id LEFT OUTER JOIN "
            SQLStr = SQLStr & " LVBContract f ON a.Contract_Id = f.Contract_Id "
            SQLStr = SQLStr & " Where a.TOC_Return_Date is NULL and a.DWC_Sent_Date IS NOT NULL "
            'If Len(pstrIO_ID) > 0 Then
            'SQLStr = SQLStr & " WHERE (a.IO_Id IN (" & pstrIO_ID & ")) "
            'End If

            SQLStr = SQLStr & " and f.Contract_Id = " & pIO_ID & " "
            SQLStr = SQLStr & "order by b.Officer_Name ASC"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Get n Set "
		Public Property IO_Id() As Integer
			Get
				Return mvarIO_Id
			End Get
			Set(ByVal Value As Integer)
				mvarIO_Id = Value
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

		Public Property IO_No() As String
			Get
				Return mvarIO_No
			End Get
			Set(ByVal Value As String)
				mvarIO_No = Value
			End Set
		End Property

		Public Property Parent_IO_Id() As Integer
			Get
				Return mvarParent_IO_Id
			End Get
			Set(ByVal Value As Integer)
				mvarParent_IO_Id = Value
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

		'Public Property LVB_Section() As Integer
		'   Get
		'       Return mvarLVB_Section
		'   End Get
		'   Set(ByVal Value As Integer)
		'       mvarLVB_Section = Value
		'   End Set
		'End Property

		Public Property LVB_Location() As String
			Get
				Return mvarLVB_Location
			End Get
			Set(ByVal Value As String)
				mvarLVB_Location = Value
			End Set
        End Property

        Public Property LVB_Substation() As String
            Get
                Return mvarLVB_Substation
            End Get
            Set(ByVal Value As String)
                mvarLVB_Substation = Value
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

        Public Property District() As String
            Get
                Return mvarDistrict
            End Get
            Set(ByVal Value As String)
                mvarDistrict = Value
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

        Public Property Inspection_Date() As String
            Get
                Return mvarInspection_Date
            End Get
            Set(ByVal Value As String)
                mvarInspection_Date = Value
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

        Public Property Subcont_Invoice_No() As String
            Get
                Return mvarSubcont_Invoice_No
            End Get
            Set(ByVal Value As String)
                mvarSubcont_Invoice_No = Value
            End Set
        End Property

        Public Property Subcont_Invoice_Date() As String
            Get
                Return mvarSubcont_Invoice_Date
            End Get
            Set(ByVal Value As String)
                mvarSubcont_Invoice_Date = Value
            End Set
        End Property

        Public Property OverTime_Charge() As String
            Get
                Return mvarOverTime_Charge
            End Get
            Set(ByVal Value As String)
                mvarOverTime_Charge = Value
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

        Public Property AttnLVBF28() As String
            Get
                Return mvarAttnLVB28
            End Get
            Set(ByVal Value As String)
                mvarAttnLVB28 = Value
            End Set
        End Property

#End Region
	End Class

    Public Class LVBLineBusLogic
#Region " Variable "
        Private mvarLVB_Line_Id As Integer
        Private mvarIO_Id As Integer
        Private mvarSerial_No As String
        Private mvarBox_Type_Id As Integer
        Private mvarInstall As Integer
        Private mvarOffshore As Integer
        Private mvarLTB_Label As Integer
        Private mvarStrip_Label As Integer
        Private mvarBus_Section As Integer
        Private mvarOT As Integer
        Private mvarOutLink500 As Integer
        Private mvarOutLink100 As Integer
        Private mvarSupInsOutLink1000 As Integer
        Private mvarSupIns630Unit As Integer
        Private mvarUsedInstall As Integer
        Private mvarInsulation_Cover As Integer
        Private mvarOT2 As Integer
        Private mvarRepoOutlink As Integer
        Private mvarSchedule_Deliver As String
        Private mvarDelivery_Date As String
        Private mvarOutLink_Ref_Date As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarSynConn As Integer
        Private mvarCableLug1Hole As Integer
        Private mvarCableLug2Hole As Integer
        Private mvarUserID As String
        Private mvarIssues_Flag As Integer
        Private mvarIssues_Detail As String
#End Region

#Region " Function "
        Public Function GetLVBLine(ByRef ds As DataSet, Optional ByVal pLVB_Line_Id As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Not pLVB_Line_Id = 0 Then
                    SQLStr = "SELECT * FROM LVBLine where LVB_Line_Id = " & Integer.Parse(pLVB_Line_Id)
                Else
                    SQLStr = "SELECT * FROM LVBLine "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetLVBLineOnIO(ByRef ds As DataSet, ByVal pIO_Id As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM LVBLine where IO_Id = " & Integer.Parse(pIO_Id)

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveLVBLine() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO LVBLine "
            SQLStr = SQLStr & "(IO_Id,Serial_No,Box_Type_Id,Install,Offshore,"
            SQLStr = SQLStr & "LTB_Label,Strip_Label,Bus_Section,OT,OutLink500,OutLink100,SupInsOutLink1000,RepoOutlink,SynConn,CableLug1Hole,CableLug2Hole,"
            'SupIns630Unit
            SQLStr = SQLStr & " SupIns630Unit,"
            SQLStr = SQLStr & " UsedInstall,"
            SQLStr = SQLStr & " Insulation_Cover,"
            SQLStr = SQLStr & " OT2,"
            SQLStr = SQLStr & " Issues_Flag,"
            SQLStr = SQLStr & " Issues_Detail,"
            SQLStr = SQLStr & "Schedule_Deliver, Delivery_Date, OutLink_Ref_Date,Create_Date,Transact_Date,UserID)"

            SQLStr = SQLStr & " VALUES (" & mvarIO_Id & ","

            If Len(mvarSerial_No) > 0 Then
                SQLStr = SQLStr & "'" & mvarSerial_No & "',"
            Else
                SQLStr = SQLStr & "NULL,"
            End If

            SQLStr = SQLStr & mvarBox_Type_Id & "," & mvarInstall & "," & mvarOffshore & ","
            SQLStr = SQLStr & mvarLTB_Label & "," & mvarStrip_Label & "," & mvarBus_Section & ","
            SQLStr = SQLStr & mvarOT & "," & mvarOutLink500 & "," & mvarOutLink100 & "," & mvarSupInsOutLink1000 & "," & mvarRepoOutlink & "," & mvarSynConn & "," & mvarCableLug1Hole & "," & mvarCableLug2Hole & ","
            'SupIns630Unit
            SQLStr = SQLStr & mvarSupIns630Unit & ","
            SQLStr = SQLStr & mvarUsedInstall & ","
            SQLStr = SQLStr & mvarInsulation_Cover & ","
            SQLStr = SQLStr & mvarOT2 & ","
            SQLStr = SQLStr & mvarIssues_Flag & ","
            'SQLStr = SQLStr & mvarIssues_Detail & ","
            If Len(mvarIssues_Detail) > 0 Then
                SQLStr = SQLStr & "'" & mvarIssues_Detail & "',"
            Else
                SQLStr = SQLStr & "NULL,"
            End If

            If Len(mvarSchedule_Deliver) > 0 Then
                SQLStr = SQLStr & "'" & mvarSchedule_Deliver & "',"
            Else
                SQLStr = SQLStr & "NULL,"
            End If

            If Len(mvarDelivery_Date) > 0 Then
                SQLStr = SQLStr & "'" & mvarDelivery_Date & "',"
            Else
                SQLStr = SQLStr & "NULL,"
            End If

            If Len(mvarOutLink_Ref_Date) > 0 Then
                SQLStr = SQLStr & "'" & mvarOutLink_Ref_Date & "',"
            Else
                SQLStr = SQLStr & "NULL,"
            End If

            SQLStr = SQLStr & "GetDate(),GetDate()," & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateLVBLine() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;UPDATE LVBLine SET "

                SQLstr = SQLstr & " Serial_No = '" & mvarSerial_No & "',"
                SQLstr = SQLstr & " Box_Type_Id = " & mvarBox_Type_Id & ","
                SQLstr = SQLstr & " Install = " & mvarInstall & ","
                SQLstr = SQLstr & " Offshore = " & mvarOffshore & ","
                SQLstr = SQLstr & " LTB_Label = " & mvarLTB_Label & ","
                SQLstr = SQLstr & " Strip_Label = " & mvarStrip_Label & ","
                SQLstr = SQLstr & " Bus_Section = " & mvarBus_Section & ","
                SQLstr = SQLstr & " OT = " & mvarOT & ","
                SQLstr = SQLstr & " OutLink500 = " & mvarOutLink500 & ","
                SQLstr = SQLstr & " OutLink100 = " & mvarOutLink100 & ","
                'SupInsOutLink1000
                SQLstr = SQLstr & " SupInsOutLink1000 = " & mvarSupInsOutLink1000 & ","
                'SupIns630Unit
                SQLstr = SQLstr & " SupIns630Unit = " & mvarSupIns630Unit & ","
                SQLstr = SQLstr & " UsedInstall = " & mvarUsedInstall & ","
                SQLstr = SQLstr & " Insulation_Cover = " & mvarInsulation_Cover & ","

                SQLstr = SQLstr & " OT2 = " & mvarOT2 & ","
                SQLstr = SQLstr & " RepoOutlink = " & mvarRepoOutlink & ","
                SQLstr = SQLstr & " SynConn = " & mvarSynConn & ","
                SQLstr = SQLstr & " CableLug1Hole = " & mvarCableLug1Hole & ","
                SQLstr = SQLstr & " CableLug2Hole = " & mvarCableLug2Hole & ","
                SQLstr = SQLstr & " Issues_Flag = " & mvarIssues_Flag & ","
                SQLstr = SQLstr & " Issues_Detail = '" & mvarIssues_Detail & "',"

                If Len(mvarSchedule_Deliver) > 0 Then
                    SQLstr = SQLstr & " Schedule_Deliver = '" & mvarSchedule_Deliver & "',"
                Else
                    SQLstr = SQLstr & " Schedule_Deliver = NULL,"
                End If

                If Len(mvarDelivery_Date) > 0 Then
                    SQLstr = SQLstr & " Delivery_Date = '" & mvarDelivery_Date & "',"
                Else
                    SQLstr = SQLstr & " Delivery_Date = NULL,"
                End If

                If Len(mvarOutLink_Ref_Date) > 0 Then
                    SQLstr = SQLstr & " OutLink_Ref_Date = '" & mvarOutLink_Ref_Date & "',"
                Else
                    SQLstr = SQLstr & " OutLink_Ref_Date = NULL,"
                End If

                SQLstr = SQLstr & " Transact_Date = GetDate () ,"
                SQLstr = SQLstr & " UserID = " & UserID & " WHERE "
                SQLstr = SQLstr & "LVB_Line_ID = " & mvarLVB_Line_Id

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteLVBLine() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM LVBLine WHERE LVB_Line_Id = " & mvarLVB_Line_Id

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Get n Set "
        Public Property LVB_Line_Id() As Integer
            Get
                Return mvarLVB_Line_Id
            End Get
            Set(ByVal Value As Integer)
                mvarLVB_Line_Id = Value
            End Set
        End Property

        Public Property IO_Id() As Integer
            Get
                Return mvarIO_Id
            End Get
            Set(ByVal Value As Integer)
                mvarIO_Id = Value
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

        Public Property Box_Type_Id() As Integer
            Get
                Return mvarBox_Type_Id
            End Get
            Set(ByVal Value As Integer)
                mvarBox_Type_Id = Value
            End Set
        End Property

        Public Property Install() As Integer
            Get
                Return mvarInstall
            End Get
            Set(ByVal Value As Integer)
                mvarInstall = Value
            End Set
        End Property

        Public Property Offshore() As Integer
            Get
                Return mvarOffshore
            End Get
            Set(ByVal Value As Integer)
                mvarOffshore = Value
            End Set
        End Property

        Public Property LTB_Label() As Integer
            Get
                Return mvarLTB_Label
            End Get
            Set(ByVal Value As Integer)
                mvarLTB_Label = Value
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

        Public Property Bus_Section() As Integer
            Get
                Return mvarBus_Section
            End Get
            Set(ByVal Value As Integer)
                mvarBus_Section = Value
            End Set
        End Property

        Public Property OT() As Integer
            Get
                Return mvarOT
            End Get
            Set(ByVal Value As Integer)
                mvarOT = Value
            End Set
        End Property

        Public Property OutLink500() As Integer
            Get
                Return mvarOutLink500
            End Get
            Set(ByVal Value As Integer)
                mvarOutLink500 = Value
            End Set
        End Property

        Public Property OutLink100() As Integer
            Get
                Return mvarOutLink100
            End Get
            Set(ByVal Value As Integer)
                mvarOutLink100 = Value
            End Set
        End Property
        'SupInsOutLink1000
        Public Property SupInsOutLink1000() As Integer
            Get
                Return mvarSupInsOutLink1000
            End Get
            Set(ByVal Value As Integer)
                mvarSupInsOutLink1000 = Value
            End Set
        End Property
        'SupIns630Unit
        Public Property SupIns630Unit() As Integer
            Get
                Return mvarSupIns630Unit
            End Get
            Set(ByVal Value As Integer)
                mvarSupIns630Unit = Value
            End Set
        End Property
        Public Property UsedInstall() As Integer
            Get
                Return mvarUsedInstall
            End Get
            Set(ByVal Value As Integer)
                mvarUsedInstall = Value
            End Set
        End Property
        Public Property Insulation_Cover() As Integer
            Get
                Return mvarInsulation_Cover
            End Get
            Set(ByVal Value As Integer)
                mvarInsulation_Cover = Value
            End Set
        End Property
        Public Property OT2() As Integer
            Get
                Return mvarOT2
            End Get
            Set(ByVal Value As Integer)
                mvarOT2 = Value
            End Set
        End Property
        Public Property RepoOutlink() As Integer
            Get
                Return mvarRepoOutlink
            End Get
            Set(ByVal Value As Integer)
                mvarRepoOutlink = Value
            End Set
        End Property
        Public Property SynConn() As Integer
            Get
                Return mvarSynConn
            End Get
            Set(ByVal Value As Integer)
                mvarSynConn = Value
            End Set
        End Property

        Public Property CableLug1Hole() As Integer
            Get
                Return mvarCableLug1Hole
            End Get
            Set(ByVal Value As Integer)
                mvarCableLug1Hole = Value
            End Set
        End Property
        Public Property CableLug2Hole() As Integer
            Get
                Return mvarCableLug2Hole
            End Get
            Set(ByVal Value As Integer)
                mvarCableLug2Hole = Value
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

        Public Property Schedule_Deliver() As String
            Get
                Return mvarSchedule_Deliver
            End Get
            Set(ByVal Value As String)
                mvarSchedule_Deliver = Value
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

        Public Property OutLink_Ref_Date() As String
            Get
                Return mvarOutLink_Ref_Date
            End Get
            Set(ByVal Value As String)
                mvarOutLink_Ref_Date = Value
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

    Public Class LVBContractBusLogic
#Region " Variable "
        Private mvarContract_Id As Integer
        Private mvarContract_No As String
        Private mvarLTL_Qty As Integer
        Private mvarLTL_Offshore_Qty As Integer
        Private mvarLT16_Qty As Integer
        Private mvarLT16_Offshore_Qty As Integer
        Private mvarLT24_Qty As Integer
        Private mvarLT24_Offshore_Qty As Integer
        Private mvarLT24FB_Qty As Integer
        Private mvarLTB_Label As Integer
        Private mvarStrip_Label As Integer
        Private mvarBus_Section As Integer
        Private mvarOutLink500 As Integer
        Private mvarOutLink100 As Integer
        Private mvarSupInsOutLink1000 As Integer
        Private mvarSupIns630Unit As Integer
        Private mvarUsedInstall As Integer
        Private mvarInsulation_Cover As Integer
        Private mvarOT2 As Integer
        Private mvarRepoOutlink As Integer
        Private mvarSynConn As Integer
        Private mvarCableLug1Hole As Integer
        Private mvarCableLug2Hole As Integer

        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " LVB Contract Function"
        Public Function GetLVBContract(ByRef ds As DataSet, Optional ByVal pContract_Id As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pContract_Id) > 0 Then
                    SQLStr = "SELECT * FROM LVBContract where Contract_Id = " & Integer.Parse(pContract_Id)
                Else
                    SQLStr = "SELECT * FROM LVBContract where inactive=0 or inactive is null"
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveLVBContract() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO LVBContract "
            SQLStr = SQLStr & "(Contract_No,LTL_Qty,LTL_Offshore_Qty,LT16_Qty,LT16_Offshore_Qty,"
            SQLStr = SQLStr & "LT24_Qty,LT24_Offshore_Qty,LT24FB_Qty,LTB_Label,Strip_Label,"
            'SupIns630Unit
            SQLStr = SQLStr & "SupIns630Unit,"
            SQLStr = SQLStr & "UsedInstall,"
            SQLStr = SQLStr & "Insulation_Cover,"
            SQLStr = SQLStr & "OT2,"

            SQLStr = SQLStr & "Bus_Section,OutLink500,OutLink100,SupInsOutLink1000,RepoOutlink,SynConn,CableLug1Hole,CableLug2Hole,Create_Date,Transact_Date,UserID)"

            SQLStr = SQLStr & " VALUES ('" & mvarContract_No & "'," & mvarLTL_Qty & "," & mvarLTL_Offshore_Qty
            SQLStr = SQLStr & "," & mvarLT16_Qty & "," & mvarLT16_Offshore_Qty & "," & mvarLT24_Qty
            SQLStr = SQLStr & "," & mvarLT24_Offshore_Qty & "," & mvarLT24FB_Qty & "," & mvarLTB_Label & "," & mvarStrip_Label
            SQLStr = SQLStr & "," & mvarSupIns630Unit
            SQLStr = SQLStr & "," & mvarUsedInstall
            SQLStr = SQLStr & "," & mvarInsulation_Cover
            SQLStr = SQLStr & "," & mvarOT2
            SQLStr = SQLStr & "," & mvarBus_Section & "," & mvarOutLink500 & "," & mvarOutLink100 & "," & mvarSupInsOutLink1000 & "," & mvarRepoOutlink & "," & mvarSynConn
            SQLStr = SQLStr & "," & mvarCableLug1Hole & "," & mvarCableLug2Hole & ", GetDate(),GetDate()," & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function CheckDuplicateContract() As Boolean
            Dim dsContract_No As DataSet
            Dim SQLStr As String = "Select * from LVBContract WHERE Contract_No = '" & mvarContract_No & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsContract_No, SQLStr) Then
                    If dsContract_No.Tables(0).Rows.Count = 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
            dsContract_No.Dispose()
        End Function
#End Region

#Region " LVB Get n Set Statement"
        Public Property Contract_Id() As Integer
            Get
                Return mvarContract_Id
            End Get
            Set(ByVal Value As Integer)
                mvarContract_Id = Value
            End Set
        End Property

        Public Property Contract_No() As String
            Get
                Return mvarContract_No
            End Get
            Set(ByVal Value As String)
                mvarContract_No = Value
            End Set
        End Property

        Public Property LTL_Qty() As Integer
            Get
                Return mvarLTL_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLTL_Qty = Value
            End Set
        End Property

        Public Property LTL_Offshore_Qty() As Integer
            Get
                Return mvarLTL_Offshore_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLTL_Offshore_Qty = Value
            End Set
        End Property

        Public Property LT16_Qty() As Integer
            Get
                Return mvarLT16_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLT16_Qty = Value
            End Set
        End Property

        Public Property LT16_Offshore_Qty() As Integer
            Get
                Return mvarLT16_Offshore_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLT16_Offshore_Qty = Value
            End Set
        End Property

        Public Property LT24_Qty() As Integer
            Get
                Return mvarLT24_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLT24_Qty = Value
            End Set
        End Property

        Public Property LT24_Offshore_Qty() As Integer
            Get
                Return mvarLT24_Offshore_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLT24_Offshore_Qty = Value
            End Set
        End Property

        Public Property LT24FB_Qty() As Integer
            Get
                Return mvarLT24FB_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLT24FB_Qty = Value
            End Set
        End Property

        Public Property LTB_Label() As Integer
            Get
                Return mvarLTB_Label
            End Get
            Set(ByVal Value As Integer)
                mvarLTB_Label = Value
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

        Public Property Bus_Section() As Integer
            Get
                Return mvarBus_Section
            End Get
            Set(ByVal Value As Integer)
                mvarBus_Section = Value
            End Set
        End Property

        Public Property OutLink500() As Integer
            Get
                Return mvarOutLink500
            End Get
            Set(ByVal Value As Integer)
                mvarOutLink500 = Value
            End Set
        End Property

        Public Property OutLink100() As Integer
            Get
                Return mvarOutLink100
            End Get
            Set(ByVal Value As Integer)
                mvarOutLink100 = Value
            End Set
        End Property
        'SupInsOutLink1000
        Public Property SupInsOutLink1000() As Integer
            Get
                Return mvarSupInsOutLink1000
            End Get
            Set(ByVal Value As Integer)
                mvarSupInsOutLink1000 = Value
            End Set
        End Property
        'SupIns630Unit
        Public Property SupIns630Unit() As Integer
            Get
                Return mvarSupIns630Unit
            End Get
            Set(ByVal Value As Integer)
                mvarSupIns630Unit = Value
            End Set
        End Property

        Public Property UsedInstall() As Integer
            Get
                Return mvarUsedInstall
            End Get
            Set(ByVal Value As Integer)
                mvarUsedInstall = Value
            End Set
        End Property
        Public Property Insulation_Cover() As Integer
            Get
                Return mvarInsulation_Cover
            End Get
            Set(ByVal Value As Integer)
                mvarInsulation_Cover = Value
            End Set
        End Property

        Public Property OT2() As Integer
            Get
                Return mvarOT2
            End Get
            Set(ByVal Value As Integer)
                mvarOT2 = Value
            End Set
        End Property
        Public Property RepoOutlink() As Integer
            Get
                Return mvarRepoOutlink
            End Get
            Set(ByVal Value As Integer)
                mvarRepoOutlink = Value
            End Set
        End Property

        Public Property SynConn() As Integer
            Get
                Return mvarSynConn
            End Get
            Set(ByVal Value As Integer)
                mvarSynConn = Value
            End Set
        End Property
        Public Property CableLug1Hole() As Integer
            Get
                Return mvarCableLug1Hole
            End Get
            Set(ByVal Value As Integer)
                mvarCableLug1Hole = Value
            End Set
        End Property
        Public Property CableLug2Hole() As Integer
            Get
                Return mvarCableLug2Hole
            End Get
            Set(ByVal Value As Integer)
                mvarCableLug2Hole = Value
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
