' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer
Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace SaleBusRules
    
    Public Class SaleBusLogic
#Region "QuotationHeader Variable "
        '** QUOTATIONHEADER **
        Private mvarQuotation_ID As Integer
        Private mvarQuotation_No As String
        Private mvarDO_ID As Integer
        Private mvarDO_No As String
        Private mvarConfirm_Quotation_No As String
        Private mvarOld_Quotation_No As String
        Private mvarQuotationDate As String
        Private mvarStatus As String
        Private mvarProjectSub As String
        Private mvarProject As String
        Private mvarCustomer_ID As Integer
        Private mvarContact_ID As Integer
        Private mvarCustomer_PO As String
        Private mvarShipment_Date As String
        Private mvarDownpayment As Decimal
        Private mvarValidity As String
        Private mvarPayment_Term As String
        Private mvarDelivery_Term As String
        Private mvarService_Type As Integer
        Private mvarCP5_Flg As String
        Private mvarPercent_Discount As Double
        Private mvarCash_Discount As Decimal
        Private mvarSign_By As String
        Private mvarDiscount_Allowed As String
        Private mvarTotal_Cost_Numeric As Decimal
        Private mvarTotal_Cost_Text As String
        Private mvarPanelType As String
        Private mvarOC_EF As Decimal
        Private mvarIncoming As Decimal
        Private mvarPanel_Transport As Decimal
        Private mvarInstallation As Decimal
        Private mvarRemarks As String
        Private mvarClosingNotes As String
        Private mvarOtherNotes As String
        Private mvarRefQuotationID As Integer
        Private mvarRevRefQuotationID As Integer
        Private mvarPODate As String
        Private mvarCollectMode As String
        Private mvarConsultant_ID As Integer
        Private mvarPriceInclude_ID As Integer
        Private mvarVORefQuotationID As Integer
        Private mvarSpecial_ID As String
        Private mvarSection1 As String
        Private mvarSection2 As String
        Private mvarSection3 As String
        Private mvarSection4 As String
        Private mvarSection5 As String
        Private mvarSection6 As String
        Private mvarOrderType As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
        '****
#End Region

#Region "QuotationLine Variable "
        '** QUOTATIONLINE **
        Private mvarQuotation_Line_ID As Integer
        Private mvarItemNo As Integer
        Private mvarBox As String
        Private mvarHeight As Integer
        Private mvarWidth As Integer
        Private mvarDepth As Integer
        Private mvarRaw_Material As String
        Private mvarMaterial_Cost As Decimal
        Private mvarType As String
        Private mvarThickness As Integer
        Private mvarPower_Coat As Decimal
        Private mvarWiring As Decimal
        Private mvarAccessory As Decimal
        Private mvarCopper As Decimal
        Private mvarComp_Markup As Integer
        Private mvarConcrete_Base As Decimal
        Private mvarBox_Markup As Integer
        Private mvarTransport As Decimal
        Private mvarEnclosure As Decimal
        Private mvarQty As Integer
        Private mvarCost As Decimal
        Private mvarOverall_Markup As Decimal
        Private mvarDiscount_Flg As String
        Private mvarTotal_Amount As Decimal
        Private mvarLinePercent_Discount As Double
        Private mvarType_Of_Enclosure As Integer
        Private mvarBoxCategory_ID As Integer
        '****
#End Region

#Region "QuotationLineComponent Variable "
        '** QuotationLineComponent **
        Private mvarComponent_ID As Integer
        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarUnitPrice As Decimal
        Private mvarLead_Time As String
        Private mvarCompQty As Integer
        Private mvarAdhoc_Description As String
        Private mvarAdhoc_Supplier As String
        Private mvarAdhoc_item As Integer
        '****
#End Region


#Region " Quotation SELECT Contact Details Statement "
        Public Function GetCustomerDetails(ByRef ds As DataSet, Optional ByVal pCustomer_ID As String = "0") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If pCustomer_ID = "0" Then
                    SQLStr = "SELECT * FROM Customer"
                Else
                    SQLStr = "SELECT * FROM Customer where Customer_ID = " & Integer.Parse(pCustomer_ID)
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetContactPerson(ByRef dsContPerson As DataSet, ByVal pCustomer_ID As String) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "SELECT * FROM CustomerContact WHERE Customer_ID = " & Integer.Parse(pCustomer_ID)

                If .GetDataSet(dsContPerson, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region


#Region " Quotation Header SELECT Statement "
        Public Function GetQuotationHeader(ByRef ds As DataSet, Optional ByVal pQuotation_ID As String = "", Optional ByVal pStatus As String = "") As Boolean
            Dim SQLStr As String
            If Len(pQuotation_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT QH.*, C.Name as CustomerName, C.Initial,UP.Login_ID FROM QuotationHeader QH LEFT JOIN Customer C "
                SQLStr = SQLStr & " ON (QH.Customer_ID = C.Customer_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (QH.UserId=UP.User_Id)"
                SQLStr = SQLStr & " WHERE Quotation_ID = " & pQuotation_ID
                SQLStr = SQLStr & " AND (Confirm_Quotation_NO is null  OR Confirm_Quotation_NO = '') "
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT QH.*, C.Name as CustomerName,C.Initial,UP.Login_ID FROM QuotationHeader QH LEFT JOIN Customer C "
                SQLStr = SQLStr & " ON (QH.Customer_ID = C.Customer_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (QH.UserId=UP.User_Id)"
                SQLStr = SQLStr & " WHERE (Confirm_Quotation_NO is null  OR Confirm_Quotation_NO = '')"
                SQLStr = SQLStr & " AND (Quotation_NO is not null OR Quotation_NO <> '')"
            End If

            If Len(pStatus) > 0 Then
                SQLStr = SQLStr & " AND QH.Status = '" & pStatus & "'"
            End If

            SQLStr = SQLStr & " AND (HistoryRecord IS NULL OR HistoryRecord = '0') "
            SQLStr = SQLStr & " ORDER BY QH.QuotationDate Desc"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetQuotationHeaderWORevisedQuo(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String = "SET DATEFORMAT dmy;SELECT QH.*, C.Name as CustomerName FROM QuotationHeader QH LEFT JOIN Customer C "
            SQLStr = SQLStr & " ON (QH.Customer_ID = C.Customer_ID) WHERE (RefQuotationID is null or RefQuotationID = 0) "
            SQLStr = SQLStr & " AND Confirm_Quotation_NO is null AND QH.Status = '10' AND Order_Type <> '1' "
            SQLStr = SQLStr & " AND (HistoryRecord IS NULL OR HistoryRecord = '0')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function CountNoOfRevisedQuote() As Integer
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT COUNT(*) FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE RevRefQuotationID = " & mvarRevRefQuotationID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        CountNoOfRevisedQuote = ds.Tables(0).Rows(0)(0) + 1
                    Else
                        CountNoOfRevisedQuote = 1
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function CountNoOfVOQuote() As Integer
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT COUNT(*) FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE VORefQuotationID = " & mvarVORefQuotationID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        CountNoOfVOQuote = ds.Tables(0).Rows(0)(0) + 1
                    Else
                        CountNoOfVOQuote = 1
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetSubQuotationHeader(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String
            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM QuotationHeader WHERE RefQuotationID =" & mvarRefQuotationID
            SQLStr = SQLStr & " AND Order_Type <> '1' "
            SQLStr = SQLStr & " AND (HistoryRecord IS NULL OR HistoryRecord = '0') "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetNextItemNo() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SET DATEFORMAT dmy;SELECT Max(ItemNo) as ItemNo FROM QuotationLine "
            SQLStr = SQLStr & " WHERE Quotation_ID = " & mvarQuotation_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If Not IsDBNull(ds.Tables(0).Rows(0)("ItemNo")) Then
                            mvarItemNo = Integer.Parse(ds.Tables(0).Rows(0)("ItemNo"))
                        Else
                            mvarItemNo = 0
                        End If
                    Else
                            mvarItemNo = 0
                    End If
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function IsRevisedQuote(ByRef dsSub As DataSet) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT RevRefQuotationID FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE Quotation_ID = " & mvarQuotation_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If Not IsDBNull(ds.Tables(0).Rows(0)("RevRefQuotationID")) Then
                        If ds.Tables(0).Rows(0)("RevRefQuotationID") = 0 Then
                            Return False
                        Else
                            Dim SubSQLStr As String = "SELECT Quotation_ID,Quotation_NO FROM QuotationHeader "
                            SubSQLStr = SubSQLStr & " WHERE Quotation_ID = " & ds.Tables(0).Rows(0)("RevRefQuotationID")

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

        Public Function IsVOQuote(ByRef dsSub As DataSet) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT VORefQuotationID FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE Quotation_ID = " & mvarQuotation_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If Not IsDBNull(ds.Tables(0).Rows(0)("VORefQuotationID")) Then
                        If ds.Tables(0).Rows(0)("VORefQuotationID") = 0 Then
                            Return False
                        Else
                            Dim SubSQLStr As String = "SELECT Quotation_ID,Confirm_Quotation_No FROM QuotationHeader "
                            SubSQLStr = SubSQLStr & " WHERE Quotation_ID = " & ds.Tables(0).Rows(0)("VORefQuotationID")

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

        Public Function CheckExistingQuotationNo() As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT Quotation_NO FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE Quotation_NO = '" & mvarQuotation_No & "'"

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

        Public Function CheckExistingNewDeliveryOrderNo() As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT DO_NO FROM newDeliveryOrderHeader "
            SQLstr = SQLstr & " WHERE DO_NO = '" & mvarQuotation_No & "'"

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

        Public Function IsRejoinedQuote(ByRef dsSub As DataSet) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT RefQuotationID FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE Quotation_ID = " & mvarQuotation_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If Not IsDBNull(ds.Tables(0).Rows(0)("RefQuotationID")) Then
                        If ds.Tables(0).Rows(0)("RefQuotationID") = 0 Then
                            Return False
                        Else
                            Dim SubSQLStr As String = "SELECT Quotation_ID,Quotation_NO FROM QuotationHeader "
                            SubSQLStr = SubSQLStr & " WHERE Quotation_ID = " & ds.Tables(0).Rows(0)("RefQuotationID")

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

        Public Function CountNoOfRejoinedQuote() As Integer
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT COUNT(*) FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE RefQuotationID = " & mvarRefQuotationID
            SQLstr = SQLstr & " AND HistoryRecord <> '1' "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        CountNoOfRejoinedQuote = ds.Tables(0).Rows(0)(0) + 1
                    Else
                        CountNoOfRejoinedQuote = 1
                    End If
                End If
            End With
            ds.Dispose()
        End Function
        '09.11.2003 YG Start
        Public Function IsOrderConfirmationCreated(ByVal pQuotation_No As String) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT * FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE Quotation_No = '" & pQuotation_No
            SQLstr = SQLstr & "' and Confirm_Quotation_No is not Null and historyrecord is NULL"
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

#Region " Quotation Header SAVE Statement "
        'Initial saving. To get the Quotation_ID
        Public Function SaveQuotationNo() As Boolean
            Dim dsQuotation As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO QuotationHeader "
                SQLstr = SQLstr & "(Quotation_No, closingnotes, othernotes, Status, Special_ID , Order_Type, Create_Date,Transact_Date,UserID) "
                SQLstr = SQLstr & " VALUES ('" & mvarQuotation_No & "','" & mvarClosingNotes & "','" & mvarOtherNotes & "','" & mvarStatus & "',"
                SQLstr = SQLstr & "1, '" & mvarOrderType & "', Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as Quotation_ID FROM QuotationHeader"

                If .GetDataSet(dsQuotation, SQLstr) Then
                    If dsQuotation.Tables(0).Rows.Count > 0 Then
                        mvarQuotation_ID = dsQuotation.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                dsQuotation.Dispose()
            End With
        End Function
#End Region

#Region " Quotation Header UPDATE Statement "
        'Final saving.
        Public Function UpdateQuotationHeader() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;UPDATE QuotationHeader SET "

                If Len(mvarQuotation_No) > 0 Then
                    SQLstr = SQLstr & " Quotation_NO = '" & mvarQuotation_No & "', "
                Else : SQLstr = SQLstr & " Quotation_NO = 'NA', "
                End If

                If Len(mvarConfirm_Quotation_No) > 0 Then
                    SQLstr = SQLstr & " Confirm_Quotation_NO = '" & mvarConfirm_Quotation_No & "',"
                End If

                SQLstr = SQLstr & " QuotationDate = '" & mvarQuotationDate & "',"
                SQLstr = SQLstr & " Status = '" & mvarStatus & "',"
                SQLstr = SQLstr & " ProjectSub = '" & mvarProjectSub & "',"
                If Not IsNothing(mvarProject) Then
                    SQLstr = SQLstr & " Project =" & mvarProject & ","
                End If
                SQLstr = SQLstr & " Customer_ID = " & mvarCustomer_ID & ","
                SQLstr = SQLstr & " Contact_ID = " & mvarContact_ID & ","

                If Len(mvarCustomer_PO) > 0 Then
                    SQLstr = SQLstr & " Customer_PO = '" & mvarCustomer_PO & "',"
                Else
                    SQLstr = SQLstr & " Customer_PO = '',"
                End If

                If Len(mvarPercent_Discount) > 0 Then
                    SQLstr = SQLstr & " Percent_Discount = " & mvarPercent_Discount & ","
                Else
                    SQLstr = SQLstr & " Percent_Discount = NULL,"
                End If

                If Len(mvarCash_Discount) > 0 Then
                    SQLstr = SQLstr & " Cash_Discount = " & mvarCash_Discount & ","
                Else
                    SQLstr = SQLstr & " Cash_Discount = NULL,"
                End If

                'SQLstr = SQLstr & " Validity = " & mvarValidity & ","
                If Len(mvarValidity) > 0 Then
                    SQLstr = SQLstr & " Validity = '" & mvarValidity & "',"
                Else
                    SQLstr = SQLstr & " Validity = NULL,"
                End If

                If Len(mvarPayment_Term) > 0 Then
                    'SQLstr = SQLstr & " Payment_Term = '" & mvarPayment_Term & "',"
                    SQLstr = SQLstr & " Payment_Term = " & mvarPayment_Term & ","
                Else
                    SQLstr = SQLstr & " Payment_Term = 0,"
                End If

                If Len(mvarDelivery_Term) > 0 Then
                    '    SQLstr = SQLstr & " Delivery_Term = '" & mvarDelivery_Term & "',"
                    SQLstr = SQLstr & " Delivery_Term = " & mvarDelivery_Term & ","
                Else
                    SQLstr = SQLstr & " Delivery_Term = 0,"
                End If

                If Len(mvarService_Type) Then
                    SQLstr = SQLstr & " Service_Type = " & mvarService_Type & ","
                End If

                If Len(mvarOrderType) > 0 Then
                    SQLstr = SQLstr & " Order_Type = " & mvarOrderType & ","
                End If

                SQLstr = SQLstr & " CP5_Flg = '" & mvarCP5_Flg & "',"
                SQLstr = SQLstr & " Sign_By = '" & mvarSign_By & "',"
                SQLstr = SQLstr & " Total_Cost_Numeric = " & mvarTotal_Cost_Numeric & ","

                If Len(mvarTotal_Cost_Text) > 0 Then
                    SQLstr = SQLstr & " Total_Cost_Text = '" & mvarTotal_Cost_Text & "',"
                End If

                If Len(mvarRefQuotationID) > 0 Then
                    SQLstr = SQLstr & " RefQuotationID = " & mvarRefQuotationID & ","
                End If

                If Len(mvarRemarks) > 0 Then
                    SQLstr = SQLstr & " Remarks = '" & Replace(mvarRemarks, "'", "''") & "',"
                Else
                    SQLstr = SQLstr & " Remarks = NULL,"
                End If

                If Len(mvarClosingNotes) > 0 Then
                    SQLstr = SQLstr & " ClosingNotes = '" & Replace(mvarClosingNotes, "'", "''") & "',"
                Else
                    SQLstr = SQLstr & " ClosingNotes = NULL,"
                End If

                If Len(mvarOtherNotes) > 0 Then
                    SQLstr = SQLstr & " OtherNotes = '" & Replace(mvarOtherNotes, "'", "''") & "',"
                Else
                    SQLstr = SQLstr & " OtherNotes = NULL,"
                End If

                If Len(mvarRevRefQuotationID) > 0 Then
                    SQLstr = SQLstr & " RevRefQuotationID = " & mvarRevRefQuotationID & ","
                End If

                If Len(mvarPODate) > 0 Then
                    SQLstr = SQLstr & " PODate = '" & mvarPODate & "',"
                Else
                    SQLstr = SQLstr & " PODate = GetDate(),"
                End If

                If Len(mvarCollectMode) > 0 Then
                    SQLstr = SQLstr & " CollectMode = '" & mvarCollectMode & "',"
                Else
                    SQLstr = SQLstr & " CollectMode = NULL,"
                End If

                If Len(mvarConsultant_ID) > 0 Then
                    SQLstr = SQLstr & " Consultant_ID = " & mvarConsultant_ID & ","
                Else
                    SQLstr = SQLstr & " Consultant_ID = NULL,"
                End If

                If Len(mvarPriceInclude_ID) > 0 Then
                    SQLstr = SQLstr & " PriceInclude_ID = " & mvarPriceInclude_ID & ","
                Else
                    SQLstr = SQLstr & " PriceInclude_ID = NULL, "
                End If

                If Len(mvarVORefQuotationID) > 0 Then
                    SQLstr = SQLstr & " VORefQuotationID = " & mvarVORefQuotationID & ","
                End If

                SQLstr = SQLstr & " Transact_Date = GetDate () ,"
                SQLstr = SQLstr & " UserID = " & UserID & " WHERE "
                SQLstr = SQLstr & "Quotation_ID = " & mvarQuotation_ID


                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateQuotationHeaderStatus() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "UPDATE QuotationHeader SET "
            SQLStr = SQLStr & " Status = " & mvarStatus & " WHERE Quotation_ID = " & mvarQuotation_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function UpdateSpecialSection() As Boolean
            Dim ds As DataSet
            Dim strSQL As String = "UPDATE QuotationHeader SET "
            strSQL = strSQL & " Special_ID = '" & mvarSpecial_ID & "',"
            If Len(mvarSection1) > 0 Then
                strSQL = strSQL & " Section1= '" & Replace(mvarSection1, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section1 = NULL, "
            End If

            If Len(mvarSection2) > 0 Then
                strSQL = strSQL & " Section2= '" & Replace(mvarSection2, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section2 = NULL, "
            End If

            If Len(mvarSection3) > 0 Then
                strSQL = strSQL & " Section3= '" & Replace(mvarSection3, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section3 = NULL, "
            End If

            If Len(mvarSection4) > 0 Then
                strSQL = strSQL & " Section4= '" & Replace(mvarSection4, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section4 = NULL, "
            End If

            If Len(mvarSection5) > 0 Then
                strSQL = strSQL & " Section5= '" & Replace(mvarSection5, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section5 = NULL, "
            End If

            If Len(mvarSection6) > 0 Then
                strSQL = strSQL & " Section6= '" & Replace(mvarSection6, "'", "''") & "' "
            Else
                strSQL = strSQL & " Section6 = NULL "
            End If
            strSQL = strSQL & " WHERE Quotation_ID = " & mvarQuotation_ID

            'Debug.WriteLine(strSQL)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region


#Region " Quotation Line SELECT Statement "
        Public Function GetQuotationLine(ByRef ds As DataSet)
            Dim SQlStr As String

            SQlStr = "SELECT * FROM QuotationLine WHERE  "
            SQlStr = SQlStr & " Quotation_ID = " & mvarQuotation_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetAllQuotationLine(ByRef ds As DataSet, Optional ByVal pQuotation_Line_Id As Integer = 0)
            Dim SQlStr As String

            If pQuotation_Line_Id = 0 Then
                SQlStr = "SELECT * FROM QuotationLine"
            Else
                SQlStr = "SELECT * FROM QuotationLine WHERE Quotation_Line_Id = " & pQuotation_Line_Id
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQlStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Quotation Line SAVE Statement "
        Public Function SaveQuotationLineFirstTime() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO QuotationLine "
            SQLStr = SQLStr & "(Quotation_ID,ItemNo, Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarQuotation_ID & "," & mvarItemNo & ","
            SQLStr = SQLStr & " GetDate(),GetDate()," & mvarUserID & ")"
            SQLStr = SQLStr & ";SELECT @@identity as Quotation_Line_ID FROM QuotationLine"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarQuotation_Line_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Quotation Line UPDATE SQL Statement "
        Public Function UpdateQuotationLine()
            Dim ds As DataSet
            Dim SQLStr As String = "Update QuotationLine SET "
            SQLStr = SQLStr & " Box = '" & mvarBox & "',"
            SQLStr = SQLStr & " Height = " & mvarHeight & ","
            SQLStr = SQLStr & " Width = " & mvarWidth & ","
            SQLStr = SQLStr & " Depth = " & mvarDepth & ","

            If Len(mvarItemNo) > 0 Then
                SQLStr = SQLStr & " ItemNo ='" & mvarItemNo & "',"
            End If

            If Len(mvarRaw_Material) > 0 Then
                SQLStr = SQLStr & " Raw_Material ='" & mvarRaw_Material & "',"
            Else
                SQLStr = SQLStr & " Raw_Material = NULL,"
            End If

            If Len(mvarMaterial_Cost) > 0 Then
                SQLStr = SQLStr & " Material_Cost = " & mvarMaterial_Cost & ","
            End If

            If Len(mvarType) > 0 Then
                SQLStr = SQLStr & " Type = '" & mvarType & "',"
            Else
                SQLStr = SQLStr & " Type = NULL,"
            End If

            If Len(mvarThickness) > 0 Then
                SQLStr = SQLStr & " Thickness = " & mvarThickness & ","
            End If

            If Len(mvarPower_Coat) > 0 Then
                SQLStr = SQLStr & " Power_Coat = " & mvarPower_Coat & ","
            End If

            If Len(mvarWiring) > 0 Then
                SQLStr = SQLStr & " Wiring = " & mvarWiring & ","
            End If

            If Len(mvarAccessory) > 0 Then
                SQLStr = SQLStr & " Accessory = " & mvarAccessory & ","
            End If

            If Len(mvarCopper) > 0 Then
                SQLStr = SQLStr & " Copper = " & mvarCopper & ","
            End If

            If Len(mvarComp_Markup) > 0 Then
                SQLStr = SQLStr & " Comp_Markup = " & mvarComp_Markup & ","
            End If

            If Len(mvarConcrete_Base) > 0 Then
                SQLStr = SQLStr & " Concrete_Base = " & mvarConcrete_Base & ","
            End If

            If Len(mvarTransport) > 0 Then
                SQLStr = SQLStr & " Transport = " & mvarTransport & ","
            End If

            If Len(mvarEnclosure) > 0 Then
                SQLStr = SQLStr & " Enclosure = " & mvarEnclosure & ","
            End If

            SQLStr = SQLStr & " Qty = " & mvarQty & ","
            SQLStr = SQLStr & " Cost = " & mvarCost & ","

            If Len(mvarOverall_Markup) > 0 Then
                SQLStr = SQLStr & " Overall_Markup = " & mvarOverall_Markup & ","
            End If

            If Len(mvarUnitPrice) > 0 Then
                SQLStr = SQLStr & " UnitPrice = " & mvarUnitPrice & ","
            End If

            SQLStr = SQLStr & " Total_Amount = " & mvarTotal_Amount & ","
            If Len(mvarPanelType) > 0 Then
                SQLStr = SQLStr & " PanelType = '" & mvarPanelType & "',"
            End If

            If Len(mvarOC_EF) > 0 Then
                SQLStr = SQLStr & " OC_EF = " & mvarOC_EF & ","
            End If

            If Len(mvarIncoming) > 0 Then
                SQLStr = SQLStr & " Incoming = " & mvarIncoming & ","
            End If

            If Len(mvarPanel_Transport) > 0 Then
                SQLStr = SQLStr & " Panel_Transport = " & mvarPanel_Transport & ","
            End If

            If Len(mvarInstallation) > 0 Then
                SQLStr = SQLStr & " Installation = " & mvarInstallation & ","
            End If

            If Len(mvarLinePercent_Discount) > 0 Then
                SQLStr = SQLStr & " LinePercent_Discount = " & mvarLinePercent_Discount & ","
            End If

            If Len(mvarType_Of_Enclosure) > 0 Then
                SQLStr = SQLStr & " Type_Of_Enclosure = " & mvarType_Of_Enclosure & ","
            End If

            If Len(mvarBoxCategory_ID) > 0 Then
                SQLStr = SQLStr & " BoxCategory_ID = " & mvarBoxCategory_ID & ","
            End If

            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = " & mvarUserID & "  "
            SQLStr = SQLStr & " WHERE Quotation_Line_ID = " & mvarQuotation_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function UpdateDiscountValue()
            Dim ds As DataSet
            Dim SQLStr As String = "Update QuotationLine SET "

            If Len(mvarLinePercent_Discount) > 0 Then
                SQLStr = SQLStr & " LinePercent_Discount = " & mvarLinePercent_Discount & ","
            End If

            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = " & mvarUserID & "  "
            SQLStr = SQLStr & " WHERE Quotation_Line_ID = " & mvarQuotation_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

#End Region


#Region " Quotation Line Component SELECT Statement "
        Public Function GetQuotationLineCompOnLineID(ByRef ds As DataSet) As Boolean
            'Dim SQLStr As String = "SELECT QLC.*, P.Name,P.Brand,P.Description "
            'SQLStr = SQLStr & " FROM QuotationLineComponent QLC JOIN "
            'SQLStr = SQLStr & " Product P ON (QLC.Product_ID = P.Product_ID) "
            'SQLStr = SQLStr & " WHERE QL   C.Quotation_Line_ID = " & mvarQuotation_Line_ID

            Dim SQLStr As String = "SELECT QLC.*, P.Name , B.Brand_Name ,"
            SQLStr = SQLStr & " Description= "
            SQLStr = SQLStr & " case adhoc_Description"
            SQLStr = SQLStr & " When NULL then P.Description"
            SQLStr = SQLStr & " When '' then P.Description"
            SQLStr = SQLStr & " else adhoc_Description"
            SQLStr = SQLStr & " End"

            SQLStr = SQLStr & " FROM QuotationLineComponent QLC "
            SQLStr = SQLStr & " left join Product P ON (QLC.Product_ID = P.Product_ID) "
            SQLStr = SQLStr & " left join Brand B ON (P.Brand=B.Brand_ID) "

            'SQLStr = SQLStr & " WHERE QLC.Product_ID = P.Product_ID and "
            'SQLStr = SQLStr & " P.Brand = B.Brand_ID and "
            SQLStr = SQLStr & " where QLC.Quotation_Line_ID = " & mvarQuotation_Line_ID
            SQLStr = SQLStr & " Order by QLC.Create_Date"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetQuotationLineComp(ByRef ds As DataSet) As Boolean
            Dim SQLStr As String = "SELECT QLC.*, C.Name as CategoryName, "
            SQLStr = SQLStr & " P.Name as ProductName "
            SQLStr = SQLStr & " FROM QuotationLineComponent QLC JOIN "
            SQLStr = SQLStr & " Category C ON (QLC.Category_ID = C.Category_ID) JOIN "
            SQLStr = SQLStr & " Product P ON (QLC.Product_ID = P.Product_ID)  "
            SQLStr = SQLStr & " WHERE Component_ID = " & mvarComponent_ID

            Debug.WriteLine(SQLStr)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Quotation Line Component SAVE Statement "
        Public Function SaveQuotationLineComponent() As Boolean
            Dim dsQuoLineCom As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO QuotationLineComponent "
                SQLstr = SQLstr & "(Quotation_ID, Quotation_Line_ID, Category_ID, Product_ID, "
                SQLstr = SQLstr & "Supplier_ID, UnitPrice, Qty, Lead_Time, "
                SQLstr = SQLstr & "Adhoc_Description,Adhoc_Supplier,Adhoc_item, "
                SQLstr = SQLstr & "Create_Date,Transact_Date, UserID) VALUES "
                SQLstr = SQLstr & "(" & mvarQuotation_ID & "," & mvarQuotation_Line_ID & ","
                SQLstr = SQLstr & mvarCategory_ID & "," & mvarProduct_ID & "," & mvarSupplier_ID & ","
                SQLstr = SQLstr & mvarUnitPrice & "," & mvarCompQty & ",'" & mvarLead_Time & "',"
                SQLstr = SQLstr & "'" & mvarAdhoc_Description & "','" & mvarAdhoc_Supplier & "'," & mvarAdhoc_item & ","
                SQLstr = SQLstr & "GetDate(),GetDate(), " & mvarUserID & ")"

                If .GetDataSet(dsQuoLineCom, SQLstr) Then
                    Return True
                End If
                dsQuoLineCom.Dispose()
            End With
        End Function
#End Region

#Region " Quotation Line Component UPDATE Statement "
        Public Function UpdateQuotationLineComponent()
            Dim ds As DataSet
            Dim SQLstr As String = "UPDATE QuotationLineComponent SET "
            SQLstr = SQLstr & "UnitPrice = " & mvarUnitPrice & ","
            SQLstr = SQLstr & "Qty = " & mvarCompQty & ","
            SQLstr = SQLstr & "Transact_Date = GetDate(),"
            SQLstr = SQLstr & "UserID = " & mvarUserID & " WHERE Component_ID = " & mvarComponent_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function
#End Region


#Region " Quotation Delete Statement "
        Public Function DeleteQuotationLineComponent() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM QuotationLineComponent "
                SQLStr = SQLStr & " WHERE Component_ID = " & mvarComponent_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteOneQuotation() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                'Dim SQLstr As String = "DELETE FROM QuotationLineComponent WHERE Quotation_ID = " & mvarQuotation_ID
                'SQLstr = SQLstr & ";DELETE FROM QuotationLine WHERE Quotation_ID = " & mvarQuotation_ID
                'SQLstr = SQLstr & ";DELETE FROM QuotationHeader WHERE Quotation_ID = " & mvarQuotation_ID
                Dim SQLStr As String = "UPDATE QuotationLineComponent SET "
                SQLStr = SQLStr & " HistoryRecord = '1', Transact_Date = GetDate(), UserID = " & mvarUserID
                SQLStr = SQLStr & " WHERE Quotation_ID = " & mvarQuotation_ID
                SQLStr = SQLStr & ";UPDATE QuotationLine SET "
                SQLStr = SQLStr & " HistoryRecord = '1', Transact_Date = GetDate(), UserID = " & mvarUserID
                SQLStr = SQLStr & " WHERE Quotation_ID = " & mvarQuotation_ID
                SQLStr = SQLStr & ";UPDATE QuotationHeader SET "
                SQLStr = SQLStr & " HistoryRecord = '1', Transact_Date = GetDate(), UserID = " & mvarUserID
                SQLStr = SQLStr & " WHERE Quotation_ID = " & mvarQuotation_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function DeleteQuotationLine() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "DELETE FROM QuotationLine WHERE Quotation_Line_ID = " & mvarQuotation_Line_ID

                If .GetDataSet(ds, SQLstr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateHistoryRecord() As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "UPDATE QuotationHeader SET "
                SQLStr = SQLStr & "HistoryRecord = '1',"
                SQLStr = SQLStr & "Transact_Date = GetDate(),"
                SQLStr = SQLStr & "UserID = " & mvarUserID & " WHERE Quotation_ID = " & mvarQuotation_ID

                SQLStr = SQLStr & ";UPDATE QuotationLine SET "
                SQLStr = SQLStr & "HistoryRecord = '1',"
                SQLStr = SQLStr & "Transact_Date = GetDate(),"
                SQLStr = SQLStr & "UserID = " & mvarUserID & " WHERE Quotation_ID = " & mvarQuotation_ID

                SQLStr = SQLStr & ";UPDATE QuotationLineComponent SET "
                SQLStr = SQLStr & "HistoryRecord = '1',"
                SQLStr = SQLStr & "Transact_Date = GetDate(),"
                SQLStr = SQLStr & "UserID = " & mvarUserID & " WHERE Quotation_ID = " & mvarQuotation_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Quotation Report "
        Public Function GetQuotationRpt(ByRef ds As DataSet, ByVal pQuotation_ID As String, _
                                        ByVal pQuotationTitle As String)
            Dim SQLStr As String

            Dim qlds As DataSet
            Dim qlcds As DataSet
            Dim nocomp As Boolean
            Dim noLine As Boolean
            Dim dsTmp As DataSet
            Dim noPriceinclude As Boolean

            Quotation_ID = pQuotation_ID
            noLine = False
            noPriceinclude = False
            If GetQuotationLine(qlds) Then
                If qlds.Tables(0).Rows.Count > 0 Then
                    nocomp = True
                    For i As Integer = 0 To qlds.Tables(0).Rows.Count - 1
                        Quotation_Line_ID = qlds.Tables(0).Rows(i)("Quotation_Line_ID")
                        If GetQuotationLineCompOnLineID(qlcds) Then
                            If Not qlcds.Tables(0).Rows.Count = 0 Then
                                nocomp = False
                            End If
                        End If
                    Next
                Else
                    noLine = True
                    nocomp = True
                End If
            End If

            If GetQuotationHeader(dsTmp, Quotation_ID) Then
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    If Not IsDBNull(dsTmp.Tables(0).Rows(0)("PriceInclude_ID")) Then
                        noPriceinclude = False
                    Else
                        noPriceinclude = True
                    End If
                End If
            End If

            SQLStr = "SELECT d.tel1 as custtel,d.name as name,*,e.Name as ContactPerson, h.Project_Name, i.PayDetails  as PaymentTerm,  j.DeliveryTerms as DeliveryTerm "
            If nocomp = False Then
                SQLStr = SQLStr & ",c.qty as qlinecompqty"
            Else
                SQLStr = SQLStr & ",'' as Description, '' as qlinecompqty"
            End If

            If noPriceinclude = False Then
                SQLStr = SQLStr & ",g.PriceInclude_Name"
            End If

            SQLStr = SQLStr & ",'" & pQuotationTitle & "' as QuotationTitle FROM QuotationHeader a "

            If noLine = False Then
                SQLStr = SQLStr & " INNER JOIN (SELECT SUM(Expr4) AS Totamt, Quotation_id AS Quotation_id FROM "
                SQLStr = SQLStr & " (SELECT b.Qty * CEILING(b.Cost) AS Expr4, a.Quotation_id "
                SQLStr = SQLStr & " FROM QuotationHeader a INNER JOIN "
                SQLStr = SQLStr & " QuotationLine b ON a.Quotation_ID = b.Quotation_ID "
                SQLStr = SQLStr & " WHERE (a.Quotation_ID = " & pQuotation_ID & ")) DERIVEDTBL GROUP BY Quotation_id)  QS ON a.Quotation_ID = QS.Quotation_id "
            End If

            If noLine = False Then
                SQLStr = SQLStr & " left join QuotationLine b "
            End If
            If nocomp = False Then
                SQLStr = SQLStr & " ,QuotationLineComponent c, Product f "
            End If
            If noPriceinclude = False Then
                SQLStr = SQLStr & " , PriceInclude g"
            End If

            SQLStr = SQLStr & " ,Customer d,customerContact e, Project h, "
            SQLStr = SQLStr & " PaymentDetails i, DeliveryTerms j "

            SQLStr = SQLStr & " where "

            If noLine = False Then
                SQLStr = SQLStr & " a.Quotation_ID = b.Quotation_ID And "
            End If

            SQLStr = SQLStr & " a.customer_id = d.customer_id and "
            SQLStr = SQLStr & " a.contact_id = e.contact_id and "
            If noPriceinclude = False Then
                SQLStr = SQLStr & " a.PriceInclude_ID = g.PriceInclude_ID and "
            End If
            SQLStr = SQLStr & " a.Project = h.Project_ID and "
            SQLStr = SQLStr & " a.Payment_Term = i.PayDetails_ID and "
            SQLStr = SQLStr & " a.Delivery_Term = j.DelTerms_ID and "
            SQLStr = SQLStr & " a.Quotation_ID = " & pQuotation_ID

            If noLine = False And nocomp = False Then
                SQLStr = SQLStr & " and b.Quotation_Line_ID = c.Quotation_Line_ID "
            End If
            If nocomp = False Then
                SQLStr = SQLStr & " and c.product_id = f.product_id "
            End If
            If noLine = False Then
                SQLStr = SQLStr & " order by b.box"
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region


        '*** Order Confirmation ***
#Region " Order Confirmation Header SELECT Statement "
        Public Function GetOrderConfirmHeader(ByRef ds As DataSet, Optional ByVal pQuotation_ID As String = "", Optional ByVal pStatus As String = "") As Boolean
            Dim SQLStr As String
            If Len(pQuotation_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT QH.*, C.Name as CustomerName, c.Initial,UP.Login_Id FROM QuotationHeader QH LEFT JOIN Customer C "
                SQLStr = SQLStr & " ON (QH.Customer_ID = C.Customer_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (QH.UserId=UP.User_Id)"
                SQLStr = SQLStr & " WHERE Quotation_ID = " & pQuotation_ID
                SQLStr = SQLStr & " AND (Confirm_Quotation_NO is not null  OR Confirm_Quotation_NO <>'')"
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT QH.*, P.Project_Name as ProjectName, C.Name as CustomerName, c.Initial,UP.Login_Id FROM QuotationHeader QH LEFT JOIN Project P"
                SQLStr = SQLStr & " ON (QH.Project = P.Project_ID)"
                SQLStr = SQLStr & " LEFT JOIN Customer C "
                SQLStr = SQLStr & " ON (QH.Customer_ID = C.Customer_ID) "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (QH.UserId=UP.User_Id)"
                SQLStr = SQLStr & " WHERE (Confirm_Quotation_NO is not null  OR Confirm_Quotation_NO <> '')"
                SQLStr = SQLStr & " AND (HistoryRecord<>'1' OR HistoryRecord is null )"
            End If

            If Len(pStatus) > 0 Then
                SQLStr = SQLStr & " AND QH.Status = '" & pStatus & "'"
            End If

            SQLStr = SQLStr & " Order by QH.QuotationDate Desc"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function CheckExistingOrderConfirmationNo() As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT Confirm_Quotation_NO FROM QuotationHeader "
            SQLstr = SQLstr & " WHERE Confirm_Quotation_NO = '" & mvarConfirm_Quotation_No & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True            'return false if order confirmation no exist
                    Else
                        Return False
                    End If
                End If
            End With
        End Function
#End Region

#Region " Order Confirmation Header SAVE Statement "
        'Initial saving. To get the Quotation_ID
        Public Function SaveOrderConfirmationNo() As Boolean
            Dim dsQuotation As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO QuotationHeader "
                SQLstr = SQLstr & "(Confirm_Quotation_No, "

                If Len(mvarQuotation_No) > 0 Then
                    SQLstr = SQLstr & " Quotation_NO, "
                End If

                SQLstr = SQLstr & " Status, Order_Type, Create_Date,Transact_Date,UserID) "
                SQLstr = SQLstr & " VALUES ('" & mvarConfirm_Quotation_No & "',"

                If Len(mvarQuotation_No) > 0 Then
                    SQLstr = SQLstr & "'" & mvarQuotation_No & "',"
                End If
                SQLstr = SQLstr & "'" & mvarStatus & "', '" & mvarOrderType & "', "
                SQLstr = SQLstr & " Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as Quotation_ID FROM QuotationHeader"

                If .GetDataSet(dsQuotation, SQLstr) Then
                    If dsQuotation.Tables(0).Rows.Count > 0 Then
                        mvarQuotation_ID = dsQuotation.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                dsQuotation.Dispose()
            End With
        End Function
#End Region

#Region " Order Confirmation Report "
        Public Function GetOrderConfirmationRpt(ByRef ds As DataSet, ByVal pQuotation_ID As String, _
            ByVal pQuotationTitle As String, ByVal pUserID As Integer)
            'ByVal pQuotationTitle As String)
            Dim SQLStr As String
            'remove by alan 20 oct
            Dim User_Name As String

            Dim noEnclose As Boolean
            Dim qlds As DataSet

            Quotation_ID = pQuotation_ID
            noEnclose = False
            If GetQuotationLine(qlds) Then
                If qlds.Tables(0).Rows.Count > 0 Then
                    For i As Integer = 0 To qlds.Tables(0).Rows.Count - 1
                        If IsDBNull(qlds.Tables(0).Rows(i)("Enclosure")) Then
                            noEnclose = True
                        ElseIf qlds.Tables(0).Rows(i)("Enclosure") = 0 Then
                            noEnclose = True
                        End If
                    Next
                End If
            End If

            SQLStr = "SELECT Name as User_Name FROM UserProfile WHERE User_ID = " & pUserID
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    User_Name = ds.Tables(0).Rows(0)("User_Name")
                End If
            End With
            'end by alan 20 Oct

            SQLStr = "SELECT *, "
            If noEnclose = False Then
                SQLStr = SQLStr & " en.Enclosure_Type as Panel_Type, "
            End If
            SQLStr = SQLStr & " c.qty as qlinecompqty, e.Name as ContactPerson, g.PriceInclude_Name, h.Project_Name, i.PayDetails  as PaymentTerm,  j.DeliveryTerms as DeliveryTerm, f.name as componentname, s.Account_No as Account_No, x.name as materialname, "
            'SQLStr = SQLStr & "'" & pOrderConfirmationTitle & "' as OrderConfirmationTitle, '" & User_Name & "' as User_Name "
            SQLStr = SQLStr & "'" & pQuotationTitle & "' as QuotationTitle, '" & User_Name & "' as User_Name FROM QuotationHeader a "
            'SQLStr = SQLStr & "'" & pQuotationTitle & "' as QuotationTitle FROM QuotationHeader a, "

            SQLStr = SQLStr & " INNER JOIN (SELECT SUM(Expr4) AS Totamt, Quotation_id AS Quotation_id FROM "
            SQLStr = SQLStr & " (SELECT b.Qty * CEILING(b.Cost-(b.Cost * (b.LinePercent_Discount/100))) AS Expr4, a.Quotation_id "
            SQLStr = SQLStr & " FROM QuotationHeader a INNER JOIN "
            SQLStr = SQLStr & " QuotationLine b ON a.Quotation_ID = b.Quotation_ID "
            SQLStr = SQLStr & " WHERE (a.Quotation_ID = " & pQuotation_ID & ")) DERIVEDTBL GROUP BY Quotation_id)  QS ON a.Quotation_ID = QS.Quotation_id "

            SQLStr = SQLStr & " inner join QuotationLine b on b.Quotation_ID = a.Quotation_ID "
            SQLStr = SQLStr & " Left outer join Product x on b.raw_material=x.Product_id "

            SQLStr = SQLStr & " , QuotationLineComponent c, Customer d, "
            SQLStr = SQLStr & " customerContact e, Product f, PriceInclude g, Project h, "
            SQLStr = SQLStr & " PaymentDetails i, DeliveryTerms j, supplier s"
            

            If noEnclose = False Then
                SQLStr = SQLStr & ", EnclosureType en "
            End If

            SQLStr = SQLStr & " where "
            SQLStr = SQLStr & " a.customer_id = d.customer_id and "
            SQLStr = SQLStr & " a.contact_id = e.contact_id and "
            SQLStr = SQLStr & " a.PriceInclude_ID = g.PriceInclude_ID and "
            SQLStr = SQLStr & " a.Project = h.Project_ID and "
            SQLStr = SQLStr & " a.Payment_Term = i.PayDetails_ID and "
            SQLStr = SQLStr & " a.Delivery_Term = j.DelTerms_ID and "
            SQLStr = SQLStr & " a.Quotation_ID = " & pQuotation_ID & " and "
            SQLStr = SQLStr & " b.Quotation_Line_ID = c.Quotation_Line_ID and "
            SQLStr = SQLStr & " s.Supplier_Id = c.supplier_Id and "
            'SQLStr = SQLStr & " b.raw_material=x.product_id and "

            If noEnclose = False Then
                SQLStr = SQLStr & " b.Type_of_Enclosure=en.Enclosure_Id and "
            End If

            SQLStr = SQLStr & " c.product_id = f.product_id order by b.box"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region
        '***

#Region " QuotationHeader's Get n Let Property "
        Public Property Quotation_ID() As Integer
            Get
                Return mvarQuotation_ID
            End Get
            Set(ByVal Value As Integer)
                mvarQuotation_ID = Value
            End Set
        End Property

        Public Property Confirm_Quotation_No() As String
            Get
                Return mvarConfirm_Quotation_No
            End Get
            Set(ByVal Value As String)
                mvarConfirm_Quotation_No = Value
            End Set
        End Property

        Public Property Quotation_No() As String
            Get
                Return mvarQuotation_No
            End Get
            Set(ByVal Value As String)
                mvarQuotation_No = Value
            End Set
        End Property

        Public Property Old_Quotation_No() As String
            Get
                Return mvarOld_Quotation_No
            End Get
            Set(ByVal Value As String)
                mvarOld_Quotation_No = Value
            End Set
        End Property

        Public Property QuotationDate() As String
            Get
                Return mvarQuotationDate
            End Get
            Set(ByVal Value As String)
                mvarQuotationDate = Value
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

        Public Property Customer_PO() As String
            Get
                Return mvarCustomer_PO
            End Get
            Set(ByVal Value As String)
                mvarCustomer_PO = Value
            End Set
        End Property

        Public Property Shipment_Date() As String
            Get
                Return mvarShipment_Date
            End Get
            Set(ByVal Value As String)
                mvarShipment_Date = Value
            End Set
        End Property

        Public Property Downpayment() As String
            Get
                Return mvarDownpayment
            End Get
            Set(ByVal Value As String)
                mvarDownpayment = Value
            End Set
        End Property

        Public Property Validity() As String
            Get
                Return mvarValidity
            End Get
            Set(ByVal Value As String)
                mvarValidity = Value
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

        Public Property Delivery_Term() As String
            Get
                Return mvarDelivery_Term
            End Get
            Set(ByVal Value As String)
                mvarDelivery_Term = Value
            End Set
        End Property

        Public Property Service_Type() As Integer
            Get
                Return mvarService_Type
            End Get
            Set(ByVal Value As Integer)
                mvarService_Type = Value
            End Set
        End Property

        Public Property CP5_Flg() As String
            Get
                Return mvarCP5_Flg
            End Get
            Set(ByVal Value As String)
                mvarCP5_Flg = Value
            End Set
        End Property

        Public Property Percent_Discount() As Double
            Get
                Return mvarPercent_Discount
            End Get
            Set(ByVal Value As Double)
                mvarPercent_Discount = Value
            End Set
        End Property

        Public Property Cash_Discount() As Decimal
            Get
                Return mvarCash_Discount
            End Get
            Set(ByVal Value As Decimal)
                mvarCash_Discount = Value
            End Set
        End Property

        Public Property Sign_By() As String
            Get
                Return mvarSign_By
            End Get
            Set(ByVal Value As String)
                mvarSign_By = Value
            End Set
        End Property

        Public Property Discount_Allowed() As String
            Get
                Return mvarDiscount_Allowed
            End Get
            Set(ByVal Value As String)
                mvarDiscount_Allowed = Value
            End Set
        End Property

        Public Property Total_Cost_Numeric() As Decimal
            Get
                Return mvarTotal_Cost_Numeric
            End Get
            Set(ByVal Value As Decimal)
                mvarTotal_Cost_Numeric = Value
            End Set
        End Property

        Public Property Total_Cost_Text() As String
            Get
                Return mvarTotal_Cost_Text
            End Get
            Set(ByVal Value As String)
                mvarTotal_Cost_Text = Value
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

        Public Property PanelType() As String
            Get
                Return mvarPanelType
            End Get
            Set(ByVal Value As String)
                mvarPanelType = Value
            End Set
        End Property

        Public Property OC_EF() As Decimal
            Get
                Return mvarOC_EF
            End Get
            Set(ByVal Value As Decimal)
                mvarOC_EF = Value
            End Set
        End Property

        Public Property Incoming() As Decimal
            Get
                Return mvarIncoming
            End Get
            Set(ByVal Value As Decimal)
                mvarIncoming = Value
            End Set
        End Property

        Public Property Panel_Transport() As Decimal
            Get
                Return mvarPanel_Transport
            End Get
            Set(ByVal Value As Decimal)
                mvarPanel_Transport = Value
            End Set
        End Property

        Public Property Installation() As Decimal
            Get
                Return mvarInstallation
            End Get
            Set(ByVal Value As Decimal)
                mvarInstallation = Value
            End Set
        End Property

        Public Property RefQuotationID() As Integer
            Get
                Return mvarRefQuotationID
            End Get
            Set(ByVal Value As Integer)
                mvarRefQuotationID = Value
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

        Public Property ClosingNotes() As String
            Get
                Return mvarClosingNotes
            End Get
            Set(ByVal Value As String)
                mvarClosingNotes = Value
                mvarClosingNotes = Replace(mvarClosingNotes, "'", "''")
            End Set
        End Property

        Public Property OtherNotes() As String
            Get
                Return mvarOtherNotes
            End Get
            Set(ByVal Value As String)
                mvarOtherNotes = Value
                mvarOtherNotes = Replace(mvarOtherNotes, "'", "''")
            End Set
        End Property

        Public Property RevRefQuotationID() As String
            Get
                Return mvarRevRefQuotationID
            End Get
            Set(ByVal Value As String)
                mvarRevRefQuotationID = Value
            End Set
        End Property

        Public Property PODate() As String
            Get
                Return mvarPODate
            End Get
            Set(ByVal Value As String)
                mvarPODate = Value
            End Set
        End Property

        Public Property CollectMode() As String
            Get
                Return mvarCollectMode
            End Get
            Set(ByVal Value As String)
                mvarCollectMode = Value
            End Set
        End Property

        Public Property Consultant_ID() As Integer
            Get
                Return mvarConsultant_ID
            End Get
            Set(ByVal Value As Integer)
                mvarConsultant_ID = Value
            End Set
        End Property

        Public Property PriceInclude_ID() As Integer
            Get
                Return mvarPriceInclude_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPriceInclude_ID = Value
            End Set
        End Property

        Public Property VORefQuotationID() As Integer
            Get
                Return mvarVORefQuotationID
            End Get
            Set(ByVal Value As Integer)
                mvarVORefQuotationID = Value
            End Set
        End Property

        Public Property Special_ID() As String
            Get
                Return mvarSpecial_ID
            End Get
            Set(ByVal Value As String)
                mvarSpecial_ID = Value
            End Set
        End Property

        Public Property Section1() As String
            Get
                Return mvarSection1
            End Get
            Set(ByVal Value As String)
                mvarSection1 = Value
            End Set
        End Property

        Public Property Section2() As String
            Get
                Return mvarSection2
            End Get
            Set(ByVal Value As String)
                mvarSection2 = Value
            End Set
        End Property

        Public Property Section3() As String
            Get
                Return mvarSection3
            End Get
            Set(ByVal Value As String)
                mvarSection3 = Value
            End Set
        End Property

        Public Property Section4() As String
            Get
                Return mvarSection4
            End Get
            Set(ByVal Value As String)
                mvarSection4 = Value
            End Set
        End Property

        Public Property Section5() As String
            Get
                Return mvarSection5
            End Get
            Set(ByVal Value As String)
                mvarSection5 = Value
            End Set
        End Property

        Public Property Section6() As String
            Get
                Return mvarSection6
            End Get
            Set(ByVal Value As String)
                mvarSection6 = Value
            End Set
        End Property
        Public Property Order_Type() As String
            Get
                Return mvarOrderType
            End Get
            Set(ByVal Value As String)
                mvarOrderType = Value
            End Set
        End Property
#End Region

#Region " QuotationLine's Get n Let Property "

        Public Property Quotation_Line_ID() As Integer
            Get
                Return mvarQuotation_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarQuotation_Line_ID = Value
            End Set
        End Property

        Public Property ItemNo() As Integer
            Get
                Return mvarItemNo
            End Get
            Set(ByVal Value As Integer)
                mvarItemNo = Value
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

        Public Property Raw_Material() As String
            Get
                Return mvarRaw_Material
            End Get
            Set(ByVal Value As String)
                mvarRaw_Material = Value
            End Set
        End Property

        Public Property Material_Cost() As Decimal
            Get
                Return mvarMaterial_Cost
            End Get
            Set(ByVal Value As Decimal)
                mvarMaterial_Cost = Value
            End Set
        End Property

        Public Property Type() As String
            Get
                Return mvarType
            End Get
            Set(ByVal Value As String)
                mvarType = Value
            End Set
        End Property

        Public Property Thickness() As Integer
            Get
                Return mvarThickness
            End Get
            Set(ByVal Value As Integer)
                mvarThickness = Value
            End Set
        End Property

        Public Property Power_Coat() As Decimal
            Get
                Return mvarPower_Coat
            End Get
            Set(ByVal Value As Decimal)
                mvarPower_Coat = Value
            End Set
        End Property

        Public Property Wiring() As Decimal
            Get
                Return mvarWiring
            End Get
            Set(ByVal Value As Decimal)
                mvarWiring = Value
            End Set
        End Property

        Public Property Accessory() As Decimal
            Get
                Return mvarAccessory
            End Get
            Set(ByVal Value As Decimal)
                mvarAccessory = Value
            End Set
        End Property

        Public Property Copper() As Decimal
            Get
                Return mvarCopper
            End Get
            Set(ByVal Value As Decimal)
                mvarCopper = Value
            End Set
        End Property

        Public Property Comp_Markup() As Integer
            Get
                Return mvarComp_Markup
            End Get
            Set(ByVal Value As Integer)
                mvarComp_Markup = Value
            End Set
        End Property

        Public Property Concrete_Base() As Decimal
            Get
                Return mvarConcrete_Base
            End Get
            Set(ByVal Value As Decimal)
                mvarConcrete_Base = Value
            End Set
        End Property

        Public Property Box_Markup() As Integer
            Get
                Return mvarBox_Markup
            End Get
            Set(ByVal Value As Integer)
                mvarBox_Markup = Value
            End Set
        End Property

        Public Property Transport() As Decimal
            Get
                Return mvarTransport
            End Get
            Set(ByVal Value As Decimal)
                mvarTransport = Value
            End Set
        End Property

        Public Property Enclosure() As Decimal
            Get
                Return mvarEnclosure
            End Get
            Set(ByVal Value As Decimal)
                mvarEnclosure = Value
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

        Public Property Cost() As Decimal
            Get
                Return mvarCost
            End Get
            Set(ByVal Value As Decimal)
                mvarCost = Value
            End Set
        End Property

        Public Property Overall_Markup() As Decimal
            Get
                Return mvarOverall_Markup
            End Get
            Set(ByVal Value As Decimal)
                mvarOverall_Markup = Value
            End Set
        End Property

        Public Property Discount_Flg() As String
            Get
                Return mvarDiscount_Flg
            End Get
            Set(ByVal Value As String)
                mvarDiscount_Flg = Value
            End Set
        End Property

        Public Property Total_Amount() As Decimal
            Get
                Return mvarTotal_Amount
            End Get
            Set(ByVal Value As Decimal)
                mvarTotal_Amount = Value
            End Set
        End Property

        Public Property LinePercent_Discount() As Double
            Get
                Return mvarLinePercent_Discount
            End Get
            Set(ByVal Value As Double)
                mvarLinePercent_Discount = Value
            End Set
        End Property

        Public Property Type_Of_Enclosure() As Integer
            Get
                Return mvarType_Of_Enclosure
            End Get
            Set(ByVal Value As Integer)
                mvarType_Of_Enclosure = Value
            End Set
        End Property

        Public Property BoxCategory_ID() As Integer
            Get
                Return mvarBoxCategory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarBoxCategory_ID = Value
            End Set
        End Property
#End Region

#Region " QuotationLineComponent's Get n Let Property "

        Public Property Component_ID() As Integer
            Get
                Return mvarComponent_ID
            End Get
            Set(ByVal Value As Integer)
                mvarComponent_ID = Value
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

        Public Property Adhoc_Description() As String
            Get
                Return mvarAdhoc_Description
            End Get
            Set(ByVal Value As String)
                mvarAdhoc_Description = Value
            End Set
        End Property

        Public Property Adhoc_Supplier() As String
            Get
                Return mvarAdhoc_Supplier
            End Get
            Set(ByVal Value As String)
                mvarAdhoc_Supplier = Value
            End Set
        End Property

        Public Property Adhoc_item() As Integer
            Get
                Return mvarAdhoc_item
            End Get
            Set(ByVal Value As Integer)
                mvarAdhoc_item = Value
            End Set
        End Property


#End Region




#Region " new delivery order Header SAVE Statement "
        'Initial saving. To get the Quotation_ID
        Public Function SaveNewDeliveryOrderNo() As Boolean
            Dim dsQuotation As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO newDeliveryOrderHeader "
                SQLstr = SQLstr & "(Quotation_No, closingnotes, othernotes, Status, Special_ID , Order_Type, Create_Date,Transact_Date,UserID) "
                SQLstr = SQLstr & " VALUES ('" & mvarQuotation_No & "','" & mvarClosingNotes & "','" & mvarOtherNotes & "','" & mvarStatus & "',"
                SQLstr = SQLstr & "1, '" & mvarOrderType & "', Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as DO_ID FROM newDeliveryOrderHeader"

                If .GetDataSet(dsQuotation, SQLstr) Then
                    If dsQuotation.Tables(0).Rows.Count > 0 Then
                        mvarQuotation_ID = dsQuotation.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                dsQuotation.Dispose()
            End With
        End Function
#End Region

    End Class
End Namespace
