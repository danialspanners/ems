' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer
Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace ReservedStockRules

    Public Class ReservedStockLogic


#Region " Variables Initialization "
        Private mvarReservedStock_ID As Integer
        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarQty As Integer
        Private mvarReserveDate As String
        Private mvarQACode_ID As Integer
        Private mvarLocation_ID As Integer

        Private mvarQuotation_ID As Integer
        Private mvarOrder_Confirmation_NO As String
        Private mvarQuotation_Line_ID As Integer
        Private mvarComponent_ID As Integer
        Private mvarPR_Line As Integer

        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer
        Private tmpWarehouse_ID As Integer
        Private tmpWarehouse_Area_ID As Integer
        Private tmpUOM_ID As Integer
#End Region

#Region "Code"
        'Retrieve All Stock by Product_ID
        Public Function GetReservedStockLine_Display(ByRef ds As DataSet, ByVal pProduct_ID As String) As Boolean
            Dim SQLstr As String

            With New DataAccess.DAccess.Access
                SQLstr = "SELECT STK.ReservedStock_ID, STK.Location_ID as Location_ID, WH.Warehouse, WA.Warehouse_Area, "
                SQLstr = SQLstr & "CAT.Name As Category_Name, PRD.Name As Product_Name, "
                SQLstr = SQLstr & "STK.Qty, UOM.Name As UOM, 0 as UnReserved_Qty, SU.Supplier_Name as Supplier, SU.Supplier_ID as Supplier_ID "
                SQLstr = SQLstr & " FROM ReservedStock STK, WarehouseLocation LOC, Warehouse WH, WarehouseArea WA, Category CAT, Product PRD, UnitMeasurement UOM, Supplier SU"
                SQLstr = SQLstr & " WHERE STK.Product_ID = " & pProduct_ID
                SQLstr = SQLstr & " AND STK.Category_ID = CAT.Category_ID"
                SQLstr = SQLstr & " AND STK.Product_ID = PRD.Product_ID"
                SQLstr = SQLstr & " AND STK.Location_ID = LOC.Location_ID"
                SQLstr = SQLstr & " AND LOC.Warehouse_ID = WH.Warehouse_ID"
                SQLstr = SQLstr & " AND LOC.Warehouse_Area_ID = WA.Warehouse_Area_ID"
                SQLstr = SQLstr & " AND PRD.UOM_ID = UOM.UOM_ID"
                SQLstr = SQLstr & " AND STK.Supplier_ID = SU.Supplier_ID"
                SQLstr = SQLstr & " AND STK.Qty > 0"
                SQLstr = SQLstr & " Order BY WH.Warehouse, WA.Warehouse_Area, SU.Supplier_Name"

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
        End Function

        Public Function Save() As Integer

            With New StockRules.StockLogic
                If .Load("", mvarCategory_ID, mvarProduct_ID, mvarSupplier_ID) Then
                    mvarQACode_ID = .QACode_ID
                    mvarLocation_ID = .Location_ID
                End If

            End With

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO ReservedStock("
            strSQL = strSQL & "Category_ID, Product_ID, Supplier_ID, Qty, ReserveDate "
            strSQL = strSQL & ",QACode_ID, Location_ID "
            '2003.10.16 YG
            '            strSQL = strSQL & ", Quotation_ID, Quotation_Line_ID, Component_ID, PR_Line "
            strSQL = strSQL & ", Order_Confirmation_No, Quotation_Line_ID, Component_ID, PR_Line "
            '2003.10.16
            strSQL = strSQL & ",Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If mvarCategory_ID <> 0 Then
                strSQL = strSQL & mvarCategory_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarProduct_ID <> 0 Then
                strSQL = strSQL & mvarProduct_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarSupplier_ID <> 0 Then
                strSQL = strSQL & mvarSupplier_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarQty) > 0 Then
                strSQL = strSQL & mvarQty & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarReserveDate) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarReserveDate, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarQACode_ID <> 0 Then
                strSQL = strSQL & mvarQACode_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarLocation_ID <> 0 Then
                strSQL = strSQL & mvarLocation_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            '           If mvarQuotation_ID <> 0 Then
            '                strSQL = strSQL & mvarQuotation_ID & ","
            '            Else
            '                strSQL = strSQL & " NULL,"
            '            End If

            If Len(mvarOrder_Confirmation_NO) > 0 Then
                strSQL = strSQL & "'" & mvarOrder_Confirmation_NO & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarQuotation_Line_ID <> 0 Then
                strSQL = strSQL & mvarQuotation_Line_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarComponent_ID <> 0 Then
                strSQL = strSQL & mvarComponent_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPR_Line) > 0 Then
                strSQL = strSQL & mvarPR_Line & ","
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

            strSQL = strSQL & "(SELECT @@IDENTITY AS ReservedStock_ID from ReservedStock)"

            'Update Stock
            Dim strSQL2 As String

            strSQL2 = "Set dateformat dmy; Update Stock set "

            strSQL2 = strSQL2 & " Qty=Qty - " & mvarQty & ""

            strSQL2 = strSQL2 & " ,Transact_Date=GetDate()"

            If mvarProduct_ID <> 0 And mvarProduct_ID <> Nothing Then
                strSQL2 = strSQL2 & " WHERE Product_ID =" & mvarProduct_ID
            End If

            If mvarCategory_ID <> 0 And mvarCategory_ID <> Nothing Then
                strSQL2 = strSQL2 & " AND Category_ID =" & mvarCategory_ID
            End If

            If mvarSupplier_ID <> 0 And mvarSupplier_ID <> Nothing Then
                strSQL2 = strSQL2 & " AND Supplier_ID =" & mvarSupplier_ID
            End If

            strSQL = strSQL & strSQL2

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


        Public Function ReservedStockExist(ByVal pCategory_ID As String, _
                                           ByVal pProduct_ID As String, _
                                           ByVal pSupplier_ID As String, _
                                           ByVal pPR_Line As String, _
                                           ByRef pReservedStock_ID As String, _
                                           Optional ByVal pQACode_ID As String = "", _
                                           Optional ByVal pLocation_ID As String = "") As Boolean
            Dim SQLStr As String
            Dim ds As DataSet

            With New DataAccess.DAccess.Access
                SQLStr = "SELECT ReservedStock_ID"
                SQLStr = SQLStr & " FROM ReservedStock "
                SQLStr = SQLStr & " Where Category_ID = " & pCategory_ID
                SQLStr = SQLStr & "   and Product_ID = " & pProduct_ID
                SQLStr = SQLStr & "   and Supplier_ID = " & pSupplier_ID
                If Len(pQACode_ID) > 0 Then
                SQLStr = SQLStr & "   and QACode_ID = " & pQACode_ID
                End If
                If Len(pLocation_ID) > 0 Then
                SQLStr = SQLStr & "   and Location_ID = " & pLocation_ID
                End If
                SQLStr = SQLStr & "   and PR_Line = " & pPR_Line

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("ReservedStock_ID") Then
                            pReservedStock_ID = row("ReservedStock_ID")
                        Else
                            pReservedStock_ID = ""
                        End If
                        Return True
                    Else
                        Return False
                    End If
                End If

            End With
        End Function


        Public Function SaveReservedStock() As Boolean

            With New StockRules.StockLogic
                If .Load("", mvarCategory_ID, mvarProduct_ID, mvarSupplier_ID) Then
                    mvarQACode_ID = .QACode_ID
                    mvarLocation_ID = .Location_ID
                End If

            End With

            Dim strSQL As String
            Dim ds As DataSet
            Dim tmpReservedStock_ID As String

            If ReservedStockExist(mvarCategory_ID, mvarProduct_ID, mvarSupplier_ID, mvarPR_Line, tmpReservedStock_ID, mvarQACode_ID, mvarLocation_ID) Then
                Update(tmpReservedStock_ID)
            Else
                strSQL = "Set dateformat dmy;INSERT INTO ReservedStock("
                strSQL = strSQL & "Category_ID, Product_ID, Supplier_ID, Qty, ReserveDate "
                strSQL = strSQL & ",QACode_ID, Location_ID "
                strSQL = strSQL & ", Order_Confirmation_No, Quotation_Line_ID, Component_ID, PR_Line "
                strSQL = strSQL & ",Create_Date, Transact_Date, UserID "
                strSQL = strSQL & ") VALUES("

                If mvarCategory_ID <> 0 Then
                    strSQL = strSQL & mvarCategory_ID & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If mvarProduct_ID <> 0 Then
                    strSQL = strSQL & mvarProduct_ID & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If mvarSupplier_ID <> 0 Then
                    strSQL = strSQL & mvarSupplier_ID & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If Len(mvarQty) > 0 Then
                    strSQL = strSQL & mvarQty & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If Len(mvarReserveDate) > 0 Then
                    strSQL = strSQL & "'" & Replace(mvarReserveDate, "'", "''") & "',"
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If mvarQACode_ID <> 0 Then
                    strSQL = strSQL & mvarQACode_ID & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If mvarLocation_ID <> 0 Then
                    strSQL = strSQL & mvarLocation_ID & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If Len(mvarOrder_Confirmation_NO) > 0 Then
                    strSQL = strSQL & "'" & mvarOrder_Confirmation_NO & "',"
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If mvarQuotation_Line_ID <> 0 Then
                    strSQL = strSQL & mvarQuotation_Line_ID & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If mvarComponent_ID <> 0 Then
                    strSQL = strSQL & mvarComponent_ID & ","
                Else
                    strSQL = strSQL & " NULL,"
                End If

                If Len(mvarPR_Line) > 0 Then
                    strSQL = strSQL & mvarPR_Line & ","
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

                With New DataAccess.DAccess.Access
                    If .GetDataSet(ds, strSQL) Then
                        Return True
                    Else
                        Return False
                    End If
                End With
                ds.Dispose()
            End If

        End Function

        Public Function SaveUnReservedStock() As Boolean
            Dim strSQL As String
            Dim ds As DataSet
            Dim tmpReservedStock_ID As String
            Dim tmpStock_ID As String

            With New ReservedStockRules.ReservedStockLogic
                If .ReservedStockExist(mvarCategory_ID, mvarProduct_ID, mvarSupplier_ID, mvarPR_Line, tmpReservedStock_ID) Then
                    If .Load(tmpReservedStock_ID) Then
                        mvarQACode_ID = .QACode_ID
                        mvarLocation_ID = .Location_ID
                    End If
                End If
            End With

            With New StockRules.StockLogic
                If .StockExist(mvarCategory_ID, mvarProduct_ID, mvarSupplier_ID, mvarQACode_ID, mvarLocation_ID, tmpStock_ID) Then
                    .AddStock(tmpStock_ID, mvarQty)
                Else
                    strSQL = "INSERT INTO Stock("
                    strSQL = strSQL & " Category_ID, Product_ID, Supplier_ID, Qty "
                    strSQL = strSQL & ", QACode_ID, Warehouse_ID, Warehouse_Area_ID "
                    strSQL = strSQL & ", Location_ID, UOM_ID "
                    strSQL = strSQL & ", Create_Date, Transact_Date, UserID "
                    strSQL = strSQL & ") VALUES("

                    If mvarCategory_ID <> 0 Then
                        strSQL = strSQL & mvarCategory_ID & ","
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If mvarProduct_ID <> 0 Then
                        strSQL = strSQL & mvarProduct_ID & ","

                        ' Get UOM_ID
                        With New ManProdBusRules.ManProdBusLogic
                            If .Load(mvarProduct_ID) Then
                                tmpUOM_ID = .UOM_ID
                            End If
                        End With
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If mvarSupplier_ID <> 0 Then
                        strSQL = strSQL & mvarSupplier_ID & ","
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If Len(mvarQty) > 0 Then
                        strSQL = strSQL & mvarQty & ","
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If mvarQACode_ID <> 0 Then
                        strSQL = strSQL & mvarQACode_ID & ","
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If mvarLocation_ID <> 0 Then
                        With New WHLocationBusRules.WHLocationClss
                            Dim dsLOC As DataSet
                            If .GetWarehouseLocation(dsLOC, mvarLocation_ID) Then
                                If dsLOC.Tables(0).Rows.Count > 0 Then
                                    Dim rowLOC As DataRow = dsLOC.Tables(0).Rows(0)

                                    If Not rowLOC.IsNull("Warehouse_ID") Then
                                        tmpWarehouse_ID = rowLOC("Warehouse_ID")
                                    Else
                                        tmpWarehouse_ID = ""
                                    End If
                                    If Not rowLOC.IsNull("Warehouse_Area_ID") Then
                                        tmpWarehouse_Area_ID = rowLOC("Warehouse_Area_ID")
                                    Else
                                        tmpWarehouse_Area_ID = ""
                                    End If

                                End If
                            End If
                            dsLOC.Dispose()
                        End With
                    End If

                    If tmpWarehouse_ID <> 0 Then
                        strSQL = strSQL & tmpWarehouse_ID & ","
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If tmpWarehouse_Area_ID <> 0 Then
                        strSQL = strSQL & tmpWarehouse_Area_ID & ","
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If mvarLocation_ID <> 0 Then
                        strSQL = strSQL & mvarLocation_ID & ","
                    Else
                        strSQL = strSQL & " NULL,"
                    End If

                    If tmpUOM_ID <> 0 Then
                        strSQL = strSQL & tmpUOM_ID & ","
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

                    With New DataAccess.DAccess.Access
                        If .GetDataSet(ds, strSQL) Then
                            Return True
                        Else
                            Return False
                        End If
                    End With
                    ds.Dispose()
                End If
            End With

        End Function

        Public Sub Delete(ByVal pReservedStock_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "DELETE FROM ReservedStock"
            strSQL = strSQL & " WHERE ReservedStock_ID=" & pReservedStock_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub DeletePRLine(ByVal pPR_Line As String)
            Dim strSQL As String
            Dim ds As DataSet

            Load(, pPR_Line)

            Dim strSQL2 As String
            strSQL2 = ""

            If Qty <> 0 And Qty <> Nothing Then
                strSQL2 = "Set dateformat dmy; Update Stock set "

                strSQL2 = strSQL2 & " Qty=Qty + " & Qty

                strSQL2 = strSQL2 & " ,Transact_Date=GetDate()"

                If Product_ID <> 0 And Product_ID <> Nothing Then
                    strSQL2 = strSQL2 & " WHERE Product_ID =" & Product_ID
                End If

                If Category_ID <> 0 And Category_ID <> Nothing Then
                    strSQL2 = strSQL2 & " AND Category_ID =" & Category_ID
                End If

                If Supplier_ID <> 0 And Supplier_ID <> Nothing Then
                    strSQL2 = strSQL2 & " AND Supplier_ID =" & Supplier_ID
                End If
                strSQL2 = strSQL2 & ";"
            End If

            strSQL = strSQL2 & "DELETE FROM ReservedStock"
            strSQL = strSQL & " WHERE PR_Line=" & pPR_Line

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pReservedStock_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update ReservedStock set "

            If Len(mvarCategory_ID) > 0 Then
                strSQL = strSQL & " Category_ID=" & mvarCategory_ID & ","
            Else
                strSQL = strSQL & " Category_ID=NULL,"
            End If

            If Len(mvarProduct_ID) > 0 Then
                strSQL = strSQL & " Product_ID=" & mvarProduct_ID & ","
            Else
                strSQL = strSQL & " Product_ID=NULL,"
            End If

            If Len(mvarSupplier_ID) > 0 Then
                strSQL = strSQL & " Supplier_ID=" & mvarSupplier_ID & ","
            Else
                strSQL = strSQL & " Supplier_ID=NULL,"
            End If

            If Len(mvarQty) > 0 Then
                strSQL = strSQL & " Qty = Qty + " & mvarQty & ","
            Else
                strSQL = strSQL & " Qty=NULL,"
            End If

            If Len(mvarReserveDate) > 0 Then
                strSQL = strSQL & " ReserveDate='" & Replace(mvarReserveDate, "'", "''") & "',"
            End If


            If Len(mvarQACode_ID) > 0 Then
                strSQL = strSQL & " QACode_ID=" & mvarQACode_ID & ","
            Else
                strSQL = strSQL & " QACode_ID=NULL,"
            End If

            If Len(mvarLocation_ID) > 0 Then
                strSQL = strSQL & " Location_ID=" & mvarLocation_ID & ","
            Else
                strSQL = strSQL & " Location_ID=NULL,"
            End If

            '            If Len(mvarQuotation_ID) > 0 Then
            '                strSQL = strSQL & " Quotation_ID=" & mvarQuotation_ID & ","
            '            Else
            '                strSQL = strSQL & " Quotation_ID=NULL,"
            '            End If

            If Len(mvarQuotation_Line_ID) > 0 Then
                strSQL = strSQL & " Quotation_Line_ID=" & mvarQuotation_Line_ID & ","
            Else
                strSQL = strSQL & " Quotation_Line_ID=NULL,"
            End If

            If Len(mvarComponent_ID) > 0 Then
                strSQL = strSQL & " Component_ID=" & mvarComponent_ID & ","
            Else
                strSQL = strSQL & " Component_ID=NULL,"
            End If

            If Len(mvarPR_Line) > 0 Then
                strSQL = strSQL & " PR_Line=" & mvarPR_Line & ","
            Else
                strSQL = strSQL & " PR_Line=NULL,"
            End If

            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID
            Else
                strSQL = strSQL & " UserID=NULL"
            End If

            strSQL = strSQL & " WHERE ReservedStock_ID = " & pReservedStock_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then

                End If
            End With
            ds.Dispose()

        End Sub

        Public Function UpdateReservedStockQty(ByVal pQty As String) As Boolean

            'Update Stock
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update ReservedStock set "

            strSQL = strSQL & " Qty=Qty - " & pQty & ""
            strSQL = strSQL & " ,Transact_Date=GetDate()"
            strSQL = strSQL & " WHERE ReservedStock_ID =" & mvarReservedStock_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Return True
                Else
                    Return False
                End If
            End With
            ds.Dispose()

        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT *"
                SQLStr = SQLStr & " FROM ReservedStock "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(Optional ByVal pReservedStock_ID As String = "", Optional ByVal pPR_Line As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM ReservedStock"

                If pReservedStock_ID <> "" Then
                    SQLStr = SQLStr & " WHERE ReservedStock_ID =" & pReservedStock_ID


                    If pPR_Line <> "" Then
                        SQLStr = SQLStr & " AND PR_Line =" & pPR_Line
                    End If
                Else

                    If pPR_Line <> "" Then
                        SQLStr = SQLStr & " WHERE PR_Line =" & pPR_Line
                    End If

                End If


                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count <> 0 Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("Category_ID") Then
                            Category_ID = row("Category_ID")
                        Else
                            Category_ID = ""
                        End If

                        If Not row.IsNull("Product_ID") Then
                            Product_ID = row("Product_ID")
                        Else
                            Product_ID = Nothing
                        End If

                        If Not row.IsNull("Supplier_ID") Then
                            Supplier_ID = row("Supplier_ID")
                        Else
                            Supplier_ID = Nothing
                        End If

                        If Not row.IsNull("Qty") Then
                            Qty = row("Qty")
                        Else
                            Qty = ""
                        End If

                        If Not row.IsNull("ReserveDate") Then
                            ReserveDate = row("ReserveDate").ToString()
                        Else
                            ReserveDate = ""
                        End If

                        If Not row.IsNull("QACode_ID") Then
                            QACode_ID = row("QACode_ID")
                        Else
                            QACode_ID = Nothing
                        End If

                        If Not row.IsNull("Location_ID") Then
                            Location_ID = row("Location_ID")
                        Else
                            Location_ID = Nothing
                        End If

                        If Not row.IsNull("Quotation_Line_ID") Then
                            Quotation_Line_ID = row("Quotation_Line_ID")
                        Else
                            Quotation_Line_ID = Nothing
                        End If

                        If Not row.IsNull("Component_ID") Then
                            Component_ID = row("Component_ID")
                        Else
                            Component_ID = Nothing
                        End If

                        If Not row.IsNull("PR_Line") Then
                            PR_Line = row("PR_Line")
                        Else
                            PR_Line = Nothing
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
                            UserID = row("UserID").ToString()
                        Else
                            UserID = ""
                        End If

                        Return True
                    Else
                        Return False
                    End If



                End If
            End With
        End Function

        Public Function GetStockReservedQty(ByVal pCategory_ID As String, ByVal pProduct_ID As String, ByVal pSupplier_ID As String) As Integer

            Dim qty As Integer = 0

            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT Sum(Qty) As Qty FROM ReservedStock"

                SQLStr = SQLStr & " WHERE Category_ID =" & pCategory_ID
                SQLStr = SQLStr & " AND Product_ID =" & pProduct_ID
                SQLStr = SQLStr & " AND Supplier_ID =" & pSupplier_ID

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count <> 0 Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("Qty") Then
                            qty = Integer.Parse(row("Qty").ToString)
                        End If
                    End If

                End If
            End With


            Return qty

        End Function

        Public Function ComputeAvailStock(ByVal pCategory_ID As String, ByVal pProduct_ID As String, Optional ByVal pSupplier_ID As String = "") As Integer
            Dim currentReservedQty As Integer
            Dim currentStockQty As Integer
            Dim availStock As Integer = -1

            'Compute the no of reserved stock
            'currentReservedQty = GetStockReservedQty(pCategory_ID, pProduct_ID, pSupplier_ID)

            'Compute the total stock in warehouse
            With New StockRules.StockLogic
                If Len(pSupplier_ID) > 0 Then
                    currentStockQty = .GetStockQty(pCategory_ID, pProduct_ID, pSupplier_ID)
                Else
                    currentStockQty = .GetStockQty(pCategory_ID, pProduct_ID)
                End If
            End With

            If currentReservedQty <= currentStockQty Then
                availStock = currentStockQty '- currentReservedQty
            End If

            Return availStock

        End Function

#End Region

#Region " Get and Let Property"

            Public Property ReservedStock_ID() As Integer
            Get
                Return mvarReservedStock_ID
            End Get
            Set(ByVal Value As Integer)
                mvarReservedStock_ID = Value
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


        Public Property Supplier_ID() As Integer
            Get
                Return mvarSupplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplier_ID = Value
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

        Public Property QACode_ID() As String
            Get
                Return mvarQACode_ID
            End Get
            Set(ByVal Value As String)
                mvarQACode_ID = Value
            End Set
        End Property

        Public Property Location_ID() As String
            Get
                Return mvarLocation_ID
            End Get
            Set(ByVal Value As String)
                mvarLocation_ID = Value
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

        Public Property Quotation_Line_ID() As Integer
            Get
                Return mvarQuotation_Line_ID
            End Get
            Set(ByVal Value As Integer)
                mvarQuotation_Line_ID = Value
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

        Public Property Order_Confirmation_NO() As String
            Get
                Return mvarOrder_Confirmation_NO
            End Get
            Set(ByVal Value As String)
                mvarOrder_Confirmation_NO = Value
            End Set
        End Property

        Public Property PR_Line() As Integer
            Get
                Return mvarPR_Line
            End Get
            Set(ByVal Value As Integer)
                mvarPR_Line = Value
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

End Namespace


Namespace StockRules

    Public Class StockLogic

#Region " Variables Initialization "
        Private mvarStock_ID As Integer
        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarQty As Integer
        Private mvarQACode_ID As Integer
        Private mvarLocation_ID As Integer
        Private mvarWarehouse_ID As Integer
        Private mvarWarehouse_Area_ID As Integer
        Private mvarUOM_ID As Integer

        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer
#End Region

#Region " Code "

        Public Function GetStockQty(ByVal pCategory_ID As String, ByVal pProduct_ID As String, Optional ByVal pSupplier_ID As String = "") As Integer

            Dim qty As Integer = 0

            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT sum(Qty) as Qty FROM Stock"

                SQLStr = SQLStr & " WHERE Category_ID =" & pCategory_ID
                SQLStr = SQLStr & " AND Product_ID =" & pProduct_ID

                If Len(pSupplier_ID) > 0 Then
                    SQLStr = SQLStr & " AND Supplier_ID =" & pSupplier_ID
                End If

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count <> 0 Then

                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("Qty") Then
                            qty = Integer.Parse(row("Qty").ToString)
                        End If

                    End If

                End If
            End With


            Return qty

        End Function

        Public Function Load(Optional ByVal pStock_ID As String = "", Optional ByVal pCategory_ID As String = "", Optional ByVal pProduct_ID As String = "", Optional ByVal pSupplier_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM Stock"

                If pStock_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Stock_ID =" & pStock_ID
                Else
                    SQLStr = SQLStr & " WHERE 1=1 "
                    'SQLStr = SQLStr & " WHERE Category_ID =" & pCategory_ID
                    SQLStr = SQLStr & " AND Product_ID =" & pProduct_ID
                    'SQLStr = SQLStr & " AND Supplier_ID =" & pSupplier_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If ds.Tables(0).Rows.Count <> 0 Then

                        If Not row.IsNull("Stock_ID") Then
                            Stock_ID = row("Stock_ID")
                        Else
                            Stock_ID = ""
                        End If

                        If Not row.IsNull("Category_ID") Then
                            Category_ID = row("Category_ID")
                        Else
                            Category_ID = ""
                        End If

                        If Not row.IsNull("Product_ID") Then
                            Product_ID = row("Product_ID")
                        Else
                            Product_ID = ""
                        End If

                        If Not row.IsNull("Supplier_ID") Then
                            Supplier_ID = row("Supplier_ID")
                        Else
                            Supplier_ID = ""
                        End If

                        If Not row.IsNull("Qty") Then
                            Qty = row("Qty")
                        Else
                            Qty = ""
                        End If

                        If Not row.IsNull("QACode_ID") Then
                            QACode_ID = row("QACode_ID")
                        Else
                            QACode_ID = ""
                        End If

                        If Not row.IsNull("Location_ID") Then
                            Location_ID = row("Location_ID")
                        Else
                            Location_ID = ""
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
                            UserID = row("UserID").ToString()
                        Else
                            UserID = ""
                        End If

                        Return True
                    Else
                        Return False
                    End If

                End If
            End With
        End Function

        ' 17.11.2003 YG Start
        '        Public Function UpdateStock(ByVal pStock_ID As String) As Boolean
        Public Function UpdateStock(ByVal pQty As String) As Boolean

            'Update Stock
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Stock set "

            ' 17.11.2003 YG Start
            '            strSQL = strSQL & " Qty=Qty - " & mvarQty & ""
            strSQL = strSQL & " Qty=Qty - " & pQty & ""

            strSQL = strSQL & " ,Transact_Date=GetDate()"

            If mvarStock_ID <> 0 And mvarStock_ID <> Nothing Then
                strSQL = strSQL & " WHERE Stock_ID =" & mvarStock_ID
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Return True
                Else
                    Return False
                End If
            End With
            ds.Dispose()

        End Function
        Public Function AddStock(ByVal pStock_ID As String, ByVal pQty As String) As Boolean

            'Update Stock
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Stock set "

            strSQL = strSQL & " Qty=Qty + " & pQty & ""
            strSQL = strSQL & " ,Transact_Date=GetDate()"
            strSQL = strSQL & " WHERE Stock_ID =" & pStock_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Return True
                Else
                    Return False
                End If
            End With
            ds.Dispose()

        End Function


        Public Function StockExist(ByVal pCategory_ID As String, _
                                   ByVal pProduct_ID As String, _
                                   ByVal pSupplier_ID As String, _
                                   ByVal pQACode_ID As String, _
                                   ByVal pLocation_ID As String, _
                                   ByRef pStock_ID As String) As Boolean
            Dim SQLStr As String
            Dim ds As DataSet

            With New DataAccess.DAccess.Access
                SQLStr = "SELECT Stock_ID"
                SQLStr = SQLStr & " FROM Stock "
                SQLStr = SQLStr & " Where Category_ID = " & pCategory_ID
                SQLStr = SQLStr & "   and Product_ID = " & pProduct_ID
                SQLStr = SQLStr & "   and Supplier_ID = " & pSupplier_ID
                SQLStr = SQLStr & "   and QACode_ID = " & pQACode_ID
                SQLStr = SQLStr & "   and Location_ID = " & pLocation_ID

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("Stock_ID") Then
                            pStock_ID = row("Stock_ID")
                        Else
                            pStock_ID = ""
                        End If
                        Return True
                    Else
                        Return False
                    End If
                End If

            End With
        End Function

#End Region

#Region " Get and Let Property"

        Public Property Stock_ID() As Integer
            Get
                Return mvarStock_ID
            End Get
            Set(ByVal Value As Integer)
                mvarStock_ID = Value
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


        Public Property Supplier_ID() As Integer
            Get
                Return mvarSupplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplier_ID = Value
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

        Public Property QACode_ID() As String
            Get
                Return mvarQACode_ID
            End Get
            Set(ByVal Value As String)
                mvarQACode_ID = Value
            End Set
        End Property

        Public Property Location_ID() As String
            Get
                Return mvarLocation_ID
            End Get
            Set(ByVal Value As String)
                mvarLocation_ID = Value
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

End Namespace

