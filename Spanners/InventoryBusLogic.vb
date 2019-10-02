' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer
Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace BusRules
    Public Class InventoryBusLogic

#Region " Variables Declaration"
        Private mvarPO_ID As Integer
        Private mvarPO_Line_ID As Integer
        Private mvarCategory_ID As Integer
        Private mvarProduct_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarWO_ID As Integer
        Private mvarWO_Component_ID As Integer
        Private mvarUOM_ID As Integer
        Private mvarStock_ID As Integer
        Private mvarDst_Stock_ID As Integer
        Private mvarReservedStock_ID As Integer
        Private mvarSrcWH_ID As Integer
        Private mvarSrcWHA_ID As Integer
        Private mvarSrcLocation_ID As Integer
        Private mvarWH_ID As Integer
        Private mvarWHA_ID As Integer
        Private mvarLocation_ID As Integer
        Private mvarCmbWH_ID As Integer
        Private mvarCmbWHA_ID As Integer
        Private mvarCmbLocation_ID As Integer
        Private mvarDst_WH_ID As Integer
        Private mvarDst_WHA_ID As Integer
        Private mvarDst_Location_ID As Integer

        Private mvarAllowedQty As Integer
        Private mvarBalanceQty As Integer
        Private mvarOrderQty As Integer
        Private mvarWOLCQty As Integer
        Private mvarConfirmQty As Integer
        Private mvarNewConfirmQty As Integer
        Private mvarStockInQty As Integer
        Private mvarStockOutQty As Integer
        Private mvarInStoreQty As Integer
        Private mvarReservedQty As Integer
        Private mvarRelocateQty As Integer
        Private mvarAdjustedQty As Integer

        Private mvarQtyDifference As Integer
        Private mvarPO_Line_Status As Integer
        Private mvarPO_Header_Status As Integer

        Private mvarTransaction_Type As String
        Private mvarStockInType As String
        Private mvarStockOutType As String
        Private mvarOrder_Type As String

        Private mvarOrder_NO As String
        Private mvarWO_No As String
        Private mvarDO_NO As String
        Private mvarPO_NO As String
        Private mvarConfirm_Quotation_No As String

        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
		Private mvarUserID As String
		Private mvarSRVNO As String
		Private mvarSRV_ID As Integer
		Private mvarRequestedBy As String
		Private mvarRemarks As String
#End Region

#Region " Get n Let Property"
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

        Public Property PO_Line_Status() As Integer
            Get
                Return mvarPO_Line_Status
            End Get
            Set(ByVal Value As Integer)
                mvarPO_Line_Status = Value
            End Set
        End Property

        Public Property PO_Header_Status() As Integer
            Get
                Return mvarPO_Header_Status
            End Get
            Set(ByVal Value As Integer)
                mvarPO_Header_Status = Value
            End Set
        End Property

        Public Property Stock_ID() As Integer
            Get
                Return mvarStock_ID
            End Get
            Set(ByVal Value As Integer)
                mvarStock_ID = Value
            End Set
        End Property

        Public Property Dst_Stock_ID() As Integer
            Get
                Return mvarDst_Stock_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDst_Stock_ID = Value
            End Set
        End Property

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

        Public Property Src_WH_ID() As Integer
            Get
                Return mvarSrcWH_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSrcWH_ID = Value
            End Set
        End Property

        Public Property Src_WHA_ID() As Integer
            Get
                Return mvarSrcWHA_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSrcWHA_ID = Value
            End Set
        End Property

        Public Property Src_Location_ID() As Integer
            Get
                Return mvarSrcLocation_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSrcLocation_ID = Value
            End Set
        End Property

        Public Property Dst_WH_ID() As Integer
            Get
                Return mvarDst_WH_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDst_WH_ID = Value
            End Set
        End Property

        Public Property Dst_WHA_ID() As Integer
            Get
                Return mvarDst_WHA_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDst_WHA_ID = Value
            End Set
        End Property

        Public Property Dst_Location_ID() As Integer
            Get
                Return mvarDst_Location_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDst_Location_ID = Value
            End Set
        End Property

        Public Property WO_ID() As Integer
            Get
                Return mvarWO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWO_ID = Value
            End Set
        End Property

        Public Property WO_Component_ID() As Integer
            Get
                Return mvarWO_Component_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWO_Component_ID = Value
            End Set
        End Property

        Public Property Transaction_Type() As String
            Get
                Return mvarTransaction_Type
            End Get
            Set(ByVal Value As String)
                mvarTransaction_Type = Value
            End Set
        End Property

        Public Property Stock_In_Type() As String
            Get
                Return mvarStockInType
            End Get
            Set(ByVal Value As String)
                mvarStockInType = Value
            End Set
        End Property

        Public Property Stock_Out_Type() As String
            Get
                Return mvarStockOutType
            End Get
            Set(ByVal Value As String)
                mvarStockOutType = Value
            End Set
        End Property

        Public Property AllowedQty() As Integer
            Get
                Return mvarAllowedQty
            End Get
            Set(ByVal Value As Integer)
                mvarAllowedQty = Value
            End Set
        End Property

        Public Property BalanceQty() As Integer
            Get
                Return mvarBalanceQty
            End Get
            Set(ByVal Value As Integer)
                mvarBalanceQty = Value
            End Set
        End Property

        Public Property OrderQty() As Integer
            Get
                Return mvarOrderQty
            End Get
            Set(ByVal Value As Integer)
                mvarOrderQty = Value
            End Set
        End Property

        Public Property WOLCQty() As Integer
            Get
                Return mvarWOLCQty
            End Get
            Set(ByVal Value As Integer)
                mvarWOLCQty = Value
            End Set
        End Property

        Public Property ConfirmQty() As Integer
            Get
                Return mvarConfirmQty
            End Get
            Set(ByVal Value As Integer)
                mvarConfirmQty = Value
            End Set
        End Property

        Public Property NewConfirmQty() As Integer
            Get
                Return mvarNewConfirmQty
            End Get
            Set(ByVal Value As Integer)
                mvarNewConfirmQty = Value
            End Set
        End Property

        Public Property StockInQty() As Integer
            Get
                Return mvarStockInQty
            End Get
            Set(ByVal Value As Integer)
                mvarStockInQty = Value
            End Set
        End Property

        Public Property StockOutQty() As Integer
            Get
                Return mvarStockInQty
            End Get
            Set(ByVal Value As Integer)
                mvarStockOutQty = Value
            End Set
        End Property

        Public Property ReservedQty() As Integer
            Get
                Return mvarReservedQty
            End Get
            Set(ByVal Value As Integer)
                mvarReservedQty = Value
            End Set
        End Property
        Public Property QtyDifference() As Integer
            Get
                Return mvarQtyDifference
            End Get
            Set(ByVal Value As Integer)
                mvarQtyDifference = Value
            End Set
        End Property

        Public Property In_Store_Qty() As Integer
            Get
                Return mvarInStoreQty
            End Get
            Set(ByVal Value As Integer)
                mvarInStoreQty = Value
            End Set
        End Property

        Public Property Relocate_Qty() As Integer
            Get
                Return mvarRelocateQty
            End Get
            Set(ByVal Value As Integer)
                mvarRelocateQty = Value
            End Set
        End Property

        Public Property Adjusted_Qty() As Integer
            Get
                Return mvarAdjustedQty
            End Get
            Set(ByVal Value As Integer)
                mvarAdjustedQty = Value
            End Set
        End Property

        Public Property UOM_ID() As Integer
            Get
                Return mvarUOM_ID
            End Get
            Set(ByVal Value As Integer)
                mvarUOM_ID = Value
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

		Public Property RequestedBy() As String
			Get
				Return mvarRequestedBy
			End Get
			Set(ByVal Value As String)
				mvarRequestedBy = Value
			End Set
		End Property

		Public Property SRVNO() As String
			Get
				Return mvarSRVNO
			End Get
			Set(ByVal Value As String)
				mvarSRVNO = Value
			End Set
		End Property

		Public Property SRV_ID() As String
			Get
				Return mvarSRV_ID
			End Get
			Set(ByVal Value As String)
				mvarSRV_ID = Value
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


		Public Property WH_ID() As Integer
			Get
				Return mvarWH_ID
			End Get
			Set(ByVal Value As Integer)
				mvarWH_ID = Value
			End Set
		End Property

		Public Property WHA_ID() As Integer
			Get
				Return mvarWHA_ID
			End Get
			Set(ByVal Value As Integer)
				mvarWHA_ID = Value
			End Set
		End Property

		Public Property Location_ID() As Integer
			Get
				Return mvarLocation_ID
			End Get
			Set(ByVal Value As Integer)
				mvarLocation_ID = Value
			End Set
		End Property

		Public Property CmbWH_ID() As Integer
			Get
				Return mvarCmbWH_ID
			End Get
			Set(ByVal Value As Integer)
				mvarCmbWH_ID = Value
			End Set
		End Property

		Public Property CmbWHA_ID() As Integer
			Get
				Return mvarCmbWHA_ID
			End Get
			Set(ByVal Value As Integer)
				mvarCmbWHA_ID = Value
			End Set
		End Property

		Public Property CmbLocation_ID() As Integer
			Get
				Return mvarCmbLocation_ID
			End Get
			Set(ByVal Value As Integer)
				mvarCmbLocation_ID = Value
			End Set
		End Property

		Public Property Order_Type() As String
			Get
				Return mvarOrder_Type
			End Get
			Set(ByVal Value As String)
				mvarOrder_Type = Value
			End Set
		End Property

		Public Property Order_NO() As String
			Get
				Return mvarOrder_NO
			End Get
			Set(ByVal Value As String)
				mvarOrder_NO = Value
			End Set
        End Property

        Public Property PO_NO() As String
            Get
                Return mvarPO_NO
            End Get
            Set(ByVal Value As String)
                mvarPO_NO = Value
            End Set
        End Property

        Public Property DO_NO() As String
            Get
                Return mvarDO_NO
            End Get
            Set(ByVal Value As String)
                mvarDO_NO = Value
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

        Public Property Confirm_Quotation_No() As String
            Get
                Return mvarConfirm_Quotation_No
            End Get
            Set(ByVal Value As String)
                mvarConfirm_Quotation_No = Value
            End Set
        End Property
#End Region

#Region " SELECT Statements"
        'Retrieve All Stock by Product_ID
        Public Function GetStockLine_Display(ByRef ds As DataSet, ByVal pProduct_ID As String) As Boolean
            Dim SQLstr As String

            With New DataAccess.DAccess.Access
                SQLstr = "SELECT STK.Stock_id, STK.Location_ID as Location_ID, WH.Warehouse, WA.Warehouse_Area, "
                SQLstr = SQLstr & "CAT.Name As Category_Name, PRD.Name As Product_Name, "
                SQLstr = SQLstr & "STK.Qty, UOM.Name As UOM, 0 as Reserved_Qty, SU.Supplier_Name as Supplier, SU.Supplier_ID as Supplier_ID "
                SQLstr = SQLstr & " FROM Stock STK, Warehouse WH, WarehouseArea WA, Category CAT, Product PRD, UnitMeasurement UOM, Supplier SU"
                SQLstr = SQLstr & " WHERE STK.Product_ID = " & pProduct_ID
                SQLstr = SQLstr & " AND STK.Product_ID = PRD.Product_ID"
                SQLstr = SQLstr & " AND STK.Warehouse_ID = WH.Warehouse_ID"
                SQLstr = SQLstr & " AND STK.Warehouse_Area_ID = WA.Warehouse_Area_ID"
                SQLstr = SQLstr & " AND STK.Category_ID = CAT.Category_ID"
                SQLstr = SQLstr & " AND STK.UOM_ID = UOM.UOM_ID"
                SQLstr = SQLstr & " AND STK.Supplier_ID = SU.Supplier_ID"
                SQLstr = SQLstr & " AND STK.Qty > 0 "
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

		Public Function GetStockTransactionSRV(ByRef ds As DataSet, ByVal SRV_ID As Integer) As Boolean
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				'SQLstr = "SELECT ST.Transaction_id, ST.Transact_Date, UP.Name as Requestor, ST.Order_no, ST.Remarks,ST.Order_type, STK.Stock_id, STK.Location_ID as Location_ID, WH.Warehouse, WA.Warehouse_Area, "
				'SQLstr = SQLstr & "CAT.Name As Category_Name, PRD.Name As Product_Name, "
				'SQLstr = SQLstr & "ST.Qty, UOM.Name As UOM, 0 as Reserved_Qty, SU.Supplier_Name as Supplier, SU.Supplier_ID as Supplier_ID "
				'SQLstr = SQLstr & " FROM Stock STK, StockTransaction ST, Warehouse WH, WarehouseArea WA, Category CAT, Product PRD, UnitMeasurement UOM, Supplier SU, UserProfile UP"
				'SQLstr = SQLstr & " WHERE ST.STOCK_ID= STK.STOCK_ID"
				'SQLstr = SQLstr & " AND STK.Product_ID = PRD.Product_ID"
				'SQLstr = SQLstr & " AND STK.Warehouse_ID = WH.Warehouse_ID"
				'SQLstr = SQLstr & " AND STK.Warehouse_Area_ID = WA.Warehouse_Area_ID"
				'SQLstr = SQLstr & " AND STK.Category_ID = CAT.Category_ID"
				'SQLstr = SQLstr & " AND STK.UOM_ID = UOM.UOM_ID"
				'SQLstr = SQLstr & " AND STK.Supplier_ID = SU.Supplier_ID"
				'SQLstr = SQLstr & " AND ST.RequestedBy  = UP.User_ID"
				'SQLstr = SQLstr & " AND ST.SRV_ID = " & SRV_ID
				'SQLstr = SQLstr & " Order BY ST.Transact_Date DESC"

				SQLstr = "SELECT     ST.Transaction_ID, ST.Transact_Date, UP.Name AS Requestor, ST.Order_NO, ST.Remarks, ST.Order_Type, STK.Stock_ID,"
				SQLstr = SQLstr & " STK.Stock_Id AS Stock_ID, WH.Warehouse, WA.Warehouse_Area, CAT.Name AS Category_Name, PRD.Name AS Product_Name, ST.Qty,"
				SQLstr = SQLstr & " UOM.Name AS UOM, 0 AS Reserved_Qty, SU.Supplier_Name AS Supplier, SU.Supplier_ID AS Supplier_ID"
				SQLstr = SQLstr & " FROM         Stock STK INNER JOIN"
				SQLstr = SQLstr & " StockTransaction ST ON STK.Stock_ID = ST.Stock_ID INNER JOIN"
				SQLstr = SQLstr & " Product PRD ON STK.Product_ID = PRD.Product_ID INNER JOIN"
				SQLstr = SQLstr & " Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID INNER JOIN"
                SQLstr = SQLstr & " WarehouseArea WA ON STK.Warehouse_Area_ID = WA.Warehouse_Area_ID left outer JOIN"
                SQLstr = SQLstr & " Category CAT ON STK.Category_ID = CAT.Category_ID left outer JOIN"
                SQLstr = SQLstr & " UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID left outer JOIN"
				SQLstr = SQLstr & " Supplier SU ON STK.Supplier_ID = SU.Supplier_ID LEFT OUTER JOIN"
				SQLstr = SQLstr & " UserProfile UP ON ST.RequestedBy = UP.User_ID"
				SQLstr = SQLstr & " WHERE ST.SRV_ID = " & SRV_ID
				SQLstr = SQLstr & " ORDER BY ST.Transact_Date DESC"

				If .GetDataSet(ds, SQLstr) Then
					'If ds.Tables(0).Rows.Count > 0 Then
					Return True
					'Else
					'	Return False
					'End If
				End If
			End With
		End Function


		'Select Statement for PO Header
		Public Function GetPOHeader(ByRef ds As DataSet, Optional ByVal pPO_ID As String = "") As Boolean
			Dim SQLStr As String

			SQLStr = "SET DATEFORMAT dmy;SELECT POH.* FROM POHeader POH"
			SQLStr = SQLStr & " WHERE POH.Status <> 90"
			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLStr) Then
					Return True
				End If
			End With
		End Function

		'Select Statement for PO Line
		Public Function GetPOLine() As DataSet
			Dim ds As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT POL.PO_Line_ID as POLID, POL.Category_ID as CatID, POL.Product_ID as ProdID, CAT.Name as Category, PRD.Name as Product, PRD.Description as Description, SUP.Supplier_ID, SUP.Supplier_Name, PRD.UOM_ID, UOM.Name as Unit, POL.Order_Qty as OrdQty, POL.Confirm_Qty as ConQty"
				SQLstr = SQLstr & " FROM POLine POL, POHeader POH, Category CAT, Product PRD, UnitMeasurement UOM, Supplier SUP"
				SQLstr = SQLstr & " WHERE POL.PO_ID = " & mvarPO_ID
				SQLstr = SQLstr & " AND POH.PO_ID = " & mvarPO_ID
				SQLstr = SQLstr & " AND CAT.Category_ID = POL.Category_ID"
				SQLstr = SQLstr & " AND PRD.Product_ID = POL.Product_ID"
				SQLstr = SQLstr & " AND POH.Supplier_ID = SUP.Supplier_ID"
				SQLstr = SQLstr & " AND UOM.UOM_ID = PRD.UOM_ID"
				SQLstr = SQLstr & " AND POL.Status <> 90"
				SQLstr = SQLstr & " ORDER BY PRD.Name ASC"

				If .GetDataSet(ds, SQLstr) Then
					If ds.Tables(0).Rows.Count > 0 Then
						Return ds
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'SELECT Statement to Obtain UOM Name
		Public Function GetUOM() As DataSet
			Dim ds As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT UOM.Name As Unit FROM UnitMeasurement UOM"
				SQLstr = SQLstr & " WHERE UOM_ID = " & mvarUOM_ID

				If .GetDataSet(ds, SQLstr) Then
					If ds.Tables(0).Rows.Count > 0 Then
						Return ds
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'Obtain Supplier Record With Given Supplier ID
		Public Function GetSupplier() As DataSet
			Dim ds As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT SUP.Supplier_ID, SUP.Supplier_Name"
				If mvarTransaction_Type = "Stock In" Then
					SQLstr = SQLstr & " FROM Supplier SUP, ProductSupplier PRDSUP"
					SQLstr = SQLstr & " WHERE PRDSUP.Product_ID = " & mvarProduct_ID
					SQLstr = SQLstr & " AND SUP.Supplier_ID = PRDSUP.Supplier_ID"
				Else
					SQLstr = SQLstr & " FROM Supplier SUP"
				End If
				If mvarTransaction_Type = "Stock Out" Or mvarTransaction_Type = "Relocate" Then
					SQLstr = SQLstr & " WHERE Supplier_ID = " & mvarSupplier_ID
				End If

				If .GetDataSet(ds, SQLstr) Then
					If ds.Tables(0).Rows.Count > 0 Then
						Return ds
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'Obtain All Warehouse Records
		Public Function GetWarehouse() As DataSet
			Dim dsWH As DataSet
			Dim SQLStr As String

			With New DataAccess.DAccess.Access
				If mvarTransaction_Type = "Stock Out" Then
					SQLStr = "SELECT DISTINCT WH.* FROM Stock STK, Warehouse WH"
					SQLStr = SQLStr & " WHERE STK.Product_ID = " & mvarProduct_ID
					SQLStr = SQLStr & " AND WH.Warehouse_ID = STK.Warehouse_ID"
					'SQLStr = SQLStr & " AND STK.Qty >= " & mvarWOLCQty
				Else
					SQLStr = "SELECT * FROM Warehouse"
				End If

				If .GetDataSet(dsWH, SQLStr) Then
					Return dsWH
				Else
					Return Nothing
				End If
			End With
		End Function

		'Obtain All Warehouse Area Records With Given Warehouse ID
		Public Function GetWarehouseArea() As DataSet
			Dim dsWHA As DataSet
			Dim SQLStr As String

			With New DataAccess.DAccess.Access
				If mvarTransaction_Type = "Stock Out" Then
					SQLStr = "SELECT DISTINCT WHA.* FROM Stock STK, WarehouseArea WHA"
					SQLStr = SQLStr & " WHERE STK.Product_ID = " & mvarProduct_ID
					SQLStr = SQLStr & " AND WHA.Warehouse_ID = " & mvarWH_ID
					SQLStr = SQLStr & " AND WHA.Warehouse_Area_ID = STK.Warehouse_Area_ID"
				Else
					SQLStr = "SELECT * FROM WarehouseArea "
					SQLStr = SQLStr & "WHERE Warehouse_ID = " & mvarWH_ID
				End If

				If .GetDataSet(dsWHA, SQLStr) Then
					Return dsWHA
				Else
					Return Nothing
				End If
			End With
		End Function

		'Obtain All Warehouse Location Records With Given Warehouse And Warehouse Area IDs
		Public Function GetWarehouseLocation() As DataSet
			Dim dsWHL As DataSet
			Dim SQLStr As String

			With New DataAccess.DAccess.Access
				SQLStr = "SELECT * FROM WarehouseLocation "
				SQLStr = SQLStr & "WHERE Warehouse_ID = " & mvarWH_ID
				SQLStr = SQLStr & " AND Warehouse_Area_ID = " & mvarWHA_ID

				If .GetDataSet(dsWHL, SQLStr) Then
					Return dsWHL
				Else
					Return Nothing
				End If
			End With
		End Function

		'Only Obtain The Row, Column And Height With Given Location ID
		Public Function GetRowColHeight() As DataSet
			Dim ds As DataSet
			Dim SQLStr As String

			With New DataAccess.DAccess.Access
				SQLStr = "SELECT * FROM WarehouseLocation "
				SQLStr = SQLStr & "WHERE Location_ID = " & mvarLocation_ID

				If .GetDataSet(ds, SQLStr) Then
					If ds.Tables(0).Rows.Count > 0 Then
						Return ds
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'Retrieve All Stock Records With Given Product ID
		Public Function GetStock() As DataSet
			Dim ds As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				If mvarTransaction_Type = "Stock Out" And mvarStockOutType = "By WO" Then
					SQLstr = "SELECT * FROM Stock"
					SQLstr = SQLstr & " WHERE Product_ID = " & mvarProduct_ID
					SQLstr = SQLstr & " AND Warehouse_ID = " & mvarCmbWH_ID
					SQLstr = SQLstr & " AND Warehouse_Area_ID = " & mvarCmbWHA_ID
                    'SQLstr = SQLstr & " AND Location_ID = " & mvarCmbLocation_ID
				Else
                    'SQLstr = "SELECT STK.*, CAT.Category_ID, CAT.Name As Category, PRD.Product_ID, PRD.Name As Product, PRD.Description As Description, SUP.Supplier_Name, UOM.UOM_ID, UOM.Name As UOM, WH.*, WHA.*"
                    'SQLstr = SQLstr & " FROM Stock STK, Category CAT, Product PRD, Supplier SUP, UnitMeasurement UOM, Warehouse WH, WarehouseArea WHA"
                    'SQLstr = SQLstr & " WHERE STK.Product_ID = " & mvarProduct_ID & " AND PRD.Product_ID = STK.Product_ID"
                    'SQLstr = SQLstr & " AND CAT.Category_ID = STK.Category_ID AND SUP.Supplier_ID = STK.Supplier_ID"

                    SQLstr = "SELECT     STK.*, CAT.Category_ID AS Expr1, CAT.Name AS Category, PRD.Product_ID AS Expr2, PRD.Name AS Product, PRD.Description AS Description,"
                    SQLstr = SQLstr & " SUP.Supplier_Name AS Expr3, UOM.UOM_ID AS Expr4, UOM.Name AS UOM, WH.*, WHA.*"
                    SQLstr = SQLstr & " FROM         Stock STK INNER JOIN"
                    SQLstr = SQLstr & "  Product PRD ON STK.Product_ID = PRD.Product_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  Category CAT ON STK.Category_ID = CAT.Category_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  Supplier SUP ON STK.Supplier_ID = SUP.Supplier_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & " WarehouseArea WHA ON STK.Warehouse_Area_ID = WHA.Warehouse_Area_ID INNER JOIN"
                    SQLstr = SQLstr & "  Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID"
                    SQLstr = SQLstr & " WHERE     (STK.Product_ID = " & mvarProduct_ID & " ) AND (STK.Qty <> 0)"


                    'SQLstr = SQLstr & " AND UOM.UOM_ID = STK.UOM_ID AND STK.Qty <> 0"
                    'If Not mvarTransaction_Type = "Adjustment" Then
                    'SQLstr = SQLstr & " AND STK.Qty <> 0"
                    'End If
                    'SQLstr = SQLstr & " AND WH.Warehouse_ID = STK.Warehouse_ID AND WHA.Warehouse_Area_ID = STK.Warehouse_Area_ID AND WHL.Location_ID = STK.Location_ID"
                    'SQLstr = SQLstr & " AND WHA.Warehouse_Area_ID = STK.Warehouse_Area_ID AND WH.Warehouse_ID = STK.Warehouse_ID"
                    If Transaction_Type = "Reporting" Then
                        SQLstr = SQLstr & " GROUP BY STK.Product_ID"
                        SQLstr = SQLstr & " ORDER BY PRD.Name ASC"
                    End If
                End If

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return ds
                    Else
                        Return Nothing
                    End If
                End If
            End With
		End Function

		'Retrieve All Stock Records With Quantity > 0
		Public Function GetInventoryList() As DataSet
			Dim ds As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT VW.Product_Name AS Product, VW.Product_Description AS Description, VW.Category, sum(VW.Qty) AS Total_Qty, VW.UOM"
				SQLstr = SQLstr & " FROM vw_ungrouped_inventory VW"
				SQLstr = SQLstr & " GROUP BY VW.Product_ID, VW.Product_Name, VW.Product_Description, VW.Category, VW.UOM"
				SQLstr = SQLstr & " ORDER BY VW.Product_Name ASC"
				'SQLstr = "SELECT PRD.Name As Product, PRD.Description As Description, CAT.Name As Category, sum(STK.Qty) As Total_Qty, UOM.Name As UOM"
				'SQLstr = SQLstr & " FROM Stock STK, Category CAT, Product PRD, UnitMeasurement UOM"
				'SQLstr = SQLstr & " WHERE PRD.Product_ID = STK.Product_ID"
				'SQLstr = SQLstr & " AND CAT.Category_ID = STK.Category_ID AND STK.UOM_ID = UOM.UOM_ID"
				'SQLstr = SQLstr & " AND STK.Qty <> 0"
				'SQLstr = SQLstr & " GROUP BY PRD.Name, CAT.Name, PRD.Description, UOM.Name"
				'SQLstr = SQLstr & " ORDER BY PRD.Name ASC"

				If .GetDataSet(ds, SQLstr) Then
					If ds.Tables(0).Rows.Count > 0 Then
						Return ds
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'Retrieve All Stock Records With Stock Level Less Than Or Equal To The Set Min. Stock Qty
		Public Function GetLowStock() As DataSet
			Dim dsLowStock As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT PRD.Name As Product, PRD.Description As Description, CAT.Name As Category, PRD.Low_Alert_Qty As Min_Qty, sum(STK.Qty) As Total_Qty, UOM.Name As UOM"
				SQLstr = SQLstr & " FROM Stock STK, Category CAT, Product PRD, UnitMeasurement UOM"
				SQLstr = SQLstr & " WHERE PRD.Product_ID = STK.Product_ID"
				SQLstr = SQLstr & " AND CAT.Category_ID = STK.Category_ID AND STK.UOM_ID = UOM.UOM_ID AND PRD.Low_Alert_Qty > 0"
				SQLstr = SQLstr & " GROUP BY PRD.Name, CAT.Name, PRD.Description, PRD.Low_Alert_Qty, UOM.Name"
				SQLstr = SQLstr & " HAVING SUM(STK.Qty) <= PRD.Low_Alert_Qty"

				If .GetDataSet(dsLowStock, SQLstr) Then
					If dsLowStock.Tables(0).Rows.Count > 0 Then
						Return dsLowStock
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'Retrieve All Stock Records With Stock Level Greater Than Or Equal To The Set Max. Stock Qty
		Public Function GetOverStock() As DataSet
			Dim dsOverStock As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT PRD.Name As Product, PRD.Description As Description, CAT.Name As Category, PRD.Over_Alert_Qty As Max_Qty, sum(STK.Qty) As Total_Qty, UOM.Name As UOM"
				SQLstr = SQLstr & " FROM Stock STK, Category CAT, Product PRD, UnitMeasurement UOM"
				SQLstr = SQLstr & " WHERE PRD.Product_ID = STK.Product_ID"
				SQLstr = SQLstr & " AND CAT.Category_ID = STK.Category_ID AND STK.UOM_ID = UOM.UOM_ID AND PRD.Over_Alert_Qty > 0"
				SQLstr = SQLstr & " GROUP BY PRD.Name, CAT.Name, PRD.Description, PRD.Over_Alert_Qty, UOM.Name"
				SQLstr = SQLstr & " HAVING SUM(STK.Qty) >= PRD.Over_Alert_Qty"

				If .GetDataSet(dsOverStock, SQLstr) Then
					If dsOverStock.Tables(0).Rows.Count > 0 Then
						Return dsOverStock
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'Retrieve All Work Order Header Records With Status Confirmed (=30) And Not Deleted (=0)
		Public Function GetWOHeader() As DataSet
			Dim dsWOH As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT WOH.WO_ID, WOH.WO_No, WOH.Confirm_Quotation_No"
				'SQLstr = "SELECT WOH.WO_ID, WOH.WO_No"
				SQLstr = SQLstr & " FROM WorkOrderHeader WOH"
				SQLstr = SQLstr & " WHERE WOH.Status = 30"
				SQLstr = SQLstr & " AND WOH.HistoryRecord IS Null OR WOH.HistoryRecord = '0'"

				If .GetDataSet(dsWOH, SQLstr) Then
					If dsWOH.Tables(0).Rows.Count > 0 Then
						Return dsWOH
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		'Retrieve All Work Order Line Component Records With Given Work Order ID
		Public Function GetWOC() As DataSet
			Dim dsWOC As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT WOC.*, PRD.UOM_ID, PRD.Name AS Product, PRD.Description AS Des, CAT.Name AS Category, SUP.Supplier_Name, UOM.Name AS Unit"
				SQLstr = SQLstr & " FROM WorkOrderLineComponent WOC, Product PRD, Category CAT, Supplier SUP, UnitMeasurement UOM"
				SQLstr = SQLstr & " WHERE WOC.WO_ID = " & mvarWO_ID
				SQLstr = SQLstr & " AND PRD.Product_ID = WOC.Product_ID"
				SQLstr = SQLstr & " AND CAT.Category_ID = WOC.Category_ID"
				SQLstr = SQLstr & " AND SUP.Supplier_ID = WOC.Supplier_ID"
				SQLstr = SQLstr & " AND UOM.UOM_ID = PRD.UOM_ID"
				SQLstr = SQLstr & " AND WOC.BalanceQty > 0"

				If .GetDataSet(dsWOC, SQLstr) Then
					If dsWOC.Tables(0).Rows.Count > 0 Then
						Return dsWOC
					Else
						Return Nothing
					End If
				End If
			End With
		End Function

		Public Function GetReservedStockLoc() As DataSet
			Dim ds As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SELECT RESTK.ReservedStock_ID, RESTK.Qty, WH.*, WHA.*, WHL.*"
				SQLstr = SQLstr & " FROM ReservedStock RESTK, Warehouse WH, WarehouseArea WHA, WarehouseLocation WHL"
				'SQLstr = SQLstr & " WHERE RESTK.Order_Confirmation_NO = '" & mvarWO_No & "'"
				SQLstr = SQLstr & " WHERE RESTK.Order_Confirmation_NO = '" & mvarConfirm_Quotation_No & "'"
				SQLstr = SQLstr & " AND RESTK.Product_ID = " & mvarProduct_ID
				SQLstr = SQLstr & " AND RESTK.Supplier_ID = " & mvarSupplier_ID
				SQLstr = SQLstr & " AND WHL.Location_ID = RESTK.Location_ID"
				SQLstr = SQLstr & " AND WHA.Warehouse_Area_ID = WHL.Warehouse_Area_ID"
				SQLstr = SQLstr & " AND WH.Warehouse_ID = WHL.Warehouse_ID"

				If .GetDataSet(ds, SQLstr) Then
					If ds.Tables(0).Rows.Count > 0 Then
						Return ds
					Else
						Return Nothing
					End If
				End If
			End With
		End Function
#End Region

#Region " Data Validation Functions"
        Public Function ValidData() As Boolean
            If mvarStockInQty = 0 Or mvarStockInQty < 0 Or mvarStockInQty > mvarQtyDifference Then
                'If mvarQty <= mvarQtyDifference Then
                Return False
                'End If
            Else
                Return True
            End If
        End Function

        'Check Validity of Qty Entered
        Public Function ValidQty() As Boolean
            If mvarTransaction_Type = "Relocate" Then
                If mvarRelocateQty = 0 Or mvarRelocateQty < 0 Or mvarRelocateQty > mvarInStoreQty Then
                    Return False
                Else
                    Return True
                End If
            ElseIf mvarTransaction_Type = "Adjustment" Then
                If mvarAdjustedQty < 0 Then
                    Return False
                Else
                    Return True
                End If
            ElseIf mvarTransaction_Type = "Stock In" And mvarStockInType = "Loose Item" Then
                If mvarStockInQty = 0 Or mvarStockInQty < 0 Then
                    Return False
                Else
                    Return True
                End If
            ElseIf mvarTransaction_Type = "Stock In" And mvarStockInType = "By PO" Then
                If mvarStockInQty = 0 Or mvarStockInQty < 0 Or mvarStockInQty > mvarQtyDifference Then
                    Return False
                Else
                    Return True
                End If
            ElseIf mvarTransaction_Type = "Stock Out" And mvarStockOutType = "Loose Item" Then
                If mvarStockOutQty = 0 Or mvarStockOutQty < 0 Or mvarStockOutQty > mvarInStoreQty Then
                    Return False
                Else
                    Return True
                End If
            ElseIf mvarTransaction_Type = "Stock Out" And mvarStockOutType = "By WO" Then
                If mvarStockOutQty = 0 Or mvarStockOutQty < 0 Or mvarStockOutQty > mvarAllowedQty Then
                    Return False
                Else
                    Return True
                End If
            End If
        End Function

        'Check If Work Order is Selected
        Public Function EmptyWorkOrder() As Boolean
            If mvarWO_ID = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'Check If Supplier is Selected
        Public Function EmptySupplier() As Boolean
            If mvarSupplier_ID = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'Check If Warehouse is Selected
        Public Function EmptyWarehouse() As Boolean
            If mvarWH_ID = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'Check If Area is Selected
        Public Function EmptyArea() As Boolean
            If mvarWHA_ID = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'Check If Location is Selected
        'Public Function EmptyLocation() As Boolean
        '    If mvarLocation_ID = 0 Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End Function

        'Check If Destination Location is Selected
        Public Function EmptyLocation() As Boolean
            If mvarTransaction_Type = "Relocate" Then
                If mvarDst_WH_ID = 0 And mvarDst_WHA_ID = 0 Then
                    Return True
                Else
                    Return False
                End If
            ElseIf mvarTransaction_Type = "Stock In" Then
                If mvarWH_ID = 0 And mvarWHA_ID = 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Function

        'Check If Destination Location is Same as Current Location
        Public Function SameLocation() As Boolean
            If mvarDst_WH_ID = mvarSrcWH_ID And mvarDst_WHA_ID = mvarSrcWHA_ID Then
                Return True
            Else
                Return False
            End If
        End Function

        'Check If Record Exist in Stock Table for Selected Product at Destination Location
        Public Function RecordExist() As DataSet
            Dim dsExist As DataSet
            Dim SQLstr As String

            With New DataAccess.DAccess.Access
                SQLstr = "SELECT STK.*"
                SQLstr = SQLstr & " FROM Stock STK"
                SQLstr = SQLstr & " WHERE STK.Product_ID = " & mvarProduct_ID
                If mvarTransaction_Type = "Relocate" Then
                    SQLstr = SQLstr & " AND STK.Warehouse_ID = " & mvarDst_WH_ID
                    SQLstr = SQLstr & " AND STK.Warehouse_Area_ID = " & mvarDst_WHA_ID
                    SQLstr = SQLstr & " AND STK.Location_ID = " & mvarDst_Location_ID
                ElseIf mvarTransaction_Type = "Stock In" Then
                    SQLstr = SQLstr & " AND STK.Supplier_ID = " & mvarSupplier_ID
                    'If mvarLocation_ID <> 0 Then
                    SQLstr = SQLstr & " AND STK.Warehouse_ID = " & mvarWH_ID
                    SQLstr = SQLstr & " AND STK.Warehouse_Area_ID = " & mvarWHA_ID
                    SQLstr = SQLstr & " AND STK.Location_ID = " & mvarLocation_ID
                    'End If
                End If

                If .GetDataSet(dsExist, SQLstr) Then
                    If dsExist.Tables(0).Rows.Count > 0 Then
                        Return dsExist
                    Else
                        Return Nothing
                    End If
                End If
            End With
        End Function
#End Region

#Region " Update and Insert Stock Statements"
        'Insert Record Into StockTransaction Table
        Public Function SaveStockTransaction() As Boolean
            Dim dsStkTxn As DataSet
            Dim SQLstr As String

            With New DataAccess.DAccess.Access
                SQLstr = "SET DATEFORMAT dmy;INSERT INTO StockTransaction"
                If mvarTransaction_Type = "Relocate" Then
                    SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Dst_Warehouse_ID, Dst_Warehouse_Area_ID, Dst_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
					SQLstr = SQLstr & " VALUES (" & mvarSrcWH_ID & "," & mvarSrcWHA_ID & "," & mvarSrcLocation_ID & ","
					SQLstr = SQLstr & mvarDst_WH_ID & "," & mvarDst_WHA_ID & "," & mvarDst_Location_ID & ","
					SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                    SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarRelocateQty & ",'" & mvarPO_NO & "',"
				ElseIf mvarTransaction_Type = "Adjustment" Then
                    SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
					SQLstr = SQLstr & "VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & "," & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                    SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarAdjustedQty & ",'" & mvarPO_NO & "',"
				ElseIf mvarTransaction_Type = "Stock In" Then
                    SQLstr = SQLstr & " (Dst_Warehouse_ID, Dst_Warehouse_Area_ID, Dst_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, Order_Type, Order_NO, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
					SQLstr = SQLstr & " VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & ","
					SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                    SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarStockInQty & ","
                    SQLstr = SQLstr & "'" & mvarOrder_Type & "','" & mvarOrder_NO & "','" & mvarPO_NO & "',"
				ElseIf mvarTransaction_Type = "Stock Out" Then
					If mvarWO_ID <> 0 Then
                        SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, Order_Type, Order_NO, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
						SQLstr = SQLstr & " VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & ","
						SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
						SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarStockOutQty & ","
                        SQLstr = SQLstr & "'" & mvarOrder_Type & "','" & mvarOrder_NO & "','" & mvarPO_NO & "',"
					Else
                        SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty,Order_Type, Order_NO, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
						SQLstr = SQLstr & " VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & ","
						SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                        SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarStockOutQty & ","
                        SQLstr = SQLstr & "'" & mvarOrder_Type & "','" & mvarOrder_NO & "','" & mvarPO_NO & "',"
					End If
				End If
				If mvarRequestedBy = "" Then
                    SQLstr = SQLstr & "GetDate(),'" & Me.mvarTransact_Date & "','" & mvarUserID & "','" & mvarSRV_ID & "',NULL,'" & mvarRemarks & "')"
				Else
                    SQLstr = SQLstr & "GetDate(),'" & Me.mvarTransact_Date & "','" & mvarUserID & "','" & mvarSRV_ID & "'," & mvarRequestedBy & ",'" & mvarRemarks & "')"
				End If
				If .GetDataSet(dsStkTxn, SQLstr) Then
					Return True
				End If
				dsStkTxn.Dispose()
			End With
		End Function

		Public Function DeleteStockTransaction(ByVal Transaction_Id As Integer)
			Dim dsStkTxn As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "Delete from StockTransaction where Transaction_ID=" & Transaction_ID
				If .GetDataSet(dsStkTxn, SQLstr) Then
					Return True
				End If
				dsStkTxn.Dispose()
			End With

		End Function

		'Insert Record Into Stock If Non-Existence
		Public Function SaveNewStock() As Boolean
			Dim dsStk As DataSet
			Dim SQLstr As String

			With New DataAccess.DAccess.Access
				SQLstr = "SET DATEFORMAT dmy;INSERT INTO Stock"
				SQLstr = SQLstr & " (Category_ID, Product_ID, Supplier_ID, Qty, QACode_ID, Warehouse_ID, Warehouse_Area_ID, Location_ID, UOM_ID, Create_Date, Transact_Date, UserID)"
				If mvarTransaction_Type = "Relocate" Then
					SQLstr = SQLstr & " VALUES (" & mvarCategory_ID & "," & mvarProduct_ID & "," & mvarSupplier_ID & "," & mvarRelocateQty & ",1," & mvarDst_WH_ID & "," & mvarDst_WHA_ID & "," & mvarDst_Location_ID & "," & mvarUOM_ID & ","
				ElseIf mvarTransaction_Type = "Stock In" Then
					SQLstr = SQLstr & " VALUES (" & mvarCategory_ID & "," & mvarProduct_ID & "," & mvarSupplier_ID & "," & mvarStockInQty & ",1," & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & "," & mvarUOM_ID & ","
				End If
				SQLstr = SQLstr & "GetDate(),GetDate(),'" & mvarUserID & "')"
				SQLstr = SQLstr & ";SELECT @@identity as Stock_ID FROM Stock"

				If .GetDataSet(dsStk, SQLstr) Then
					If dsStk.Tables(0).Rows.Count > 0 Then
						mvarStock_ID = dsStk.Tables(0).Rows(0)(0)
					End If
					Return True
				End If
				dsStk.Dispose()
			End With
		End Function

		Public Function UpdatePOHeader() As Boolean
			Dim ds As DataSet
			Dim SQLstr As String

			SQLstr = "UPDATE POHeader SET"
			SQLstr = SQLstr & " Status = " & mvarPO_Header_Status
			SQLstr = SQLstr & " , Transact_Date = GetDate(), UserID = " & mvarUserID
			SQLstr = SQLstr & " WHERE PO_ID = " & mvarPO_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLstr) Then
					Return True
				End If
			End With
			ds.Dispose()
		End Function

		Public Function UpdatePOLine()
			Dim ds As DataSet
			Dim SQLstr As String

			SQLstr = "UPDATE POLine SET"
			SQLstr = SQLstr & " Confirm_Qty = " & mvarNewConfirmQty
			If mvarPO_Line_Status = 90 Then
				SQLstr = SQLstr & " , Status = " & mvarPO_Line_Status
			End If
			SQLstr = SQLstr & " , Transact_Date = GetDate(), UserID = " & mvarUserID
			SQLstr = SQLstr & " WHERE PO_Line_ID = " & mvarPO_Line_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLstr) Then
					Return True
				End If
			End With
			ds.Dispose()
		End Function

		'Update Stock Table for the Selected Record
		Public Function UpdateSelectedStock() As Boolean
			Dim dsSelected As DataSet
			Dim TempQty As Integer
			Dim SQLstr As String

			If mvarTransaction_Type = "Relocate" Then
				TempQty = mvarInStoreQty - mvarRelocateQty
			End If

			SQLstr = "UPDATE Stock SET"
			If mvarTransaction_Type = "Relocate" Then
				SQLstr = SQLstr & " Qty = " & TempQty & ","
			ElseIf mvarTransaction_Type = "Adjustment" Then
				SQLstr = SQLstr & " Qty = " & mvarAdjustedQty & ","
			ElseIf mvarTransaction_Type = "Stock In" Then
				SQLstr = SQLstr & " Qty = Qty + " & mvarStockInQty & ","
			ElseIf mvarTransaction_Type = "Stock Out" Then
				SQLstr = SQLstr & " Qty = Qty - " & mvarStockOutQty & ","
			End If
			SQLstr = SQLstr & " Transact_Date = GetDate(), UserID = " & mvarUserID
			SQLstr = SQLstr & " WHERE Stock_ID = " & mvarStock_ID
			'SQLstr = SQLstr & " AND Location_ID = " & mvarLocation_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(dsSelected, SQLstr) Then
					Return True
				End If
			End With
			dsSelected.Dispose()
		End Function

		'Update Stock Table for the Stock at the Destination Location If Record Exists
		Public Function UpdateDestinationStock() As Boolean
			Dim dsDst As DataSet
			Dim SQLstr As String

			SQLstr = "UPDATE Stock SET"
			SQLstr = SQLstr & " Qty = Qty + " & mvarRelocateQty & ","
			SQLstr = SQLstr & " Transact_Date = GetDate(), UserID = " & mvarUserID
			SQLstr = SQLstr & " WHERE Stock_ID = " & mvarDst_Stock_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(dsDst, SQLstr) Then
					Return True
				End If
			End With
			dsDst.Dispose()
		End Function

		'Update Balance Qty in WorkOrderLineComponent Table
		Public Function UpdateWOLC() As Boolean
			Dim ds As DataSet
			Dim SQLstr As String

			SQLstr = "UPDATE WorkOrderLineComponent SET"
			SQLstr = SQLstr & " BalanceQty = " & (mvarBalanceQty - mvarStockOutQty) & ","
			SQLstr = SQLstr & " Transact_Date = GetDate(), UserID = " & mvarUserID
			SQLstr = SQLstr & " WHERE WO_Component_ID = " & mvarWO_Component_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLstr) Then
					Return True
				End If
			End With
			ds.Dispose()
		End Function

		'Update Qty in Reserved Stock Table
		Public Function UpdateReservedStock() As Boolean
			Dim ds As DataSet
			Dim SQLstr As String

			SQLstr = "UPDATE ReservedStock SET"
			SQLstr = SQLstr & " Qty = " & mvarQtyDifference & ","
			SQLstr = SQLstr & " Transact_Date = GetDate(), UserID = " & mvarUserID
			SQLstr = SQLstr & " WHERE ReservedStock_ID = " & mvarReservedStock_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(ds, SQLstr) Then
					Return True
				End If
			End With
			ds.Dispose()
		End Function

		'Delete Stock from Reserved Table After Stocking Out
		Public Function DeleteReservedStock() As Boolean
			Dim dsResStock As DataSet
			Dim SQLstr As String

			SQLstr = "DELETE FROM ReservedStock"
			SQLstr = SQLstr & " WHERE ReservedStock_ID = " & mvarReservedStock_ID

			With New DataAccess.DAccess.Access
				If .GetDataSet(dsResStock, SQLstr) Then
					Return True
				End If
			End With
			dsResStock.Dispose()
		End Function
#End Region

#Region "Inventory Report "
        Public Function GetInventoryReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SELECT VW.Product_Name AS Product, VW.Product_Description AS Description, VW.Category, sum(VW.Qty) AS Total_Qty, VW.UOM"
            SQLStr = SQLStr & " FROM vw_ungrouped_inventory VW"
            SQLStr = SQLStr & " GROUP BY VW.Product_ID, VW.Product_Name, VW.Product_Description, VW.Category, VW.UOM"
            SQLStr = SQLStr & " ORDER BY VW.Product_Name ASC"

            'SQLStr = "SELECT PRD.Name As Product, PRD.Description As Description, CAT.Name As Category, sum(STK.Qty) As Total_Qty, UOM.Name As UOM"
            'SQLStr = SQLStr & " FROM Stock STK, Category CAT, Product PRD, UnitMeasurement UOM"
            'SQLStr = SQLStr & " WHERE PRD.Product_ID = STK.Product_ID"
            'SQLStr = SQLStr & " AND CAT.Category_ID = STK.Category_ID AND STK.UOM_ID = UOM.UOM_ID"
            'SQLStr = SQLStr & " AND STK.Qty <> 0"
            'SQLStr = SQLStr & " GROUP BY PRD.Name, CAT.Name, PRD.Description, UOM.Name"
            'SQLStr = SQLStr & " ORDER BY PRD.Name ASC"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Over Stock Alert Report "
        Public Function GetMaxInventoryReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SELECT PRD.Name As Product, PRD.Description As Description, CAT.Name As Category, PRD.Over_Alert_Qty As Max_Qty, sum(STK.Qty) As Total_Qty, UOM.Name As UOM"
            SQLStr = SQLStr & " FROM Stock STK, Category CAT, Product PRD, UnitMeasurement UOM"
            SQLStr = SQLStr & " WHERE PRD.Product_ID = STK.Product_ID"
            SQLStr = SQLStr & " AND CAT.Category_ID = STK.Category_ID AND STK.UOM_ID = UOM.UOM_ID AND PRD.Over_Alert_Qty > 0"
            SQLStr = SQLStr & " GROUP BY PRD.Name, CAT.Name, PRD.Description, PRD.Over_Alert_Qty, UOM.Name"
            SQLStr = SQLStr & " HAVING SUM(STK.Qty) >= PRD.Over_Alert_Qty"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Low Stock Alert Report "
        Public Function GetMinInventoryReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SELECT PRD.Name As Product, PRD.Description As Description, CAT.Name As Category, PRD.Low_Alert_Qty As Min_Qty, sum(STK.Qty) As Total_Qty, UOM.Name As UOM"
            SQLStr = SQLStr & " FROM Stock STK, Category CAT, Product PRD, UnitMeasurement UOM"
            SQLStr = SQLStr & " WHERE PRD.Product_ID = STK.Product_ID"
            SQLStr = SQLStr & " AND CAT.Category_ID = STK.Category_ID AND STK.UOM_ID = UOM.UOM_ID AND PRD.Low_Alert_Qty > 0"
            SQLStr = SQLStr & " GROUP BY PRD.Name, CAT.Name, PRD.Description, PRD.Low_Alert_Qty, UOM.Name"
            SQLStr = SQLStr & " HAVING SUM(STK.Qty) <= PRD.Low_Alert_Qty"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region
	End Class

#Region "SRV"

	Public Class SRVBusLogic

#Region "Variables Initialization"

		Private mvarSRV_ID As Integer
		Private mvarSRVNO As String
		Private mvarCreate_Date As String
		Private mvarUserID As Integer
        Private mvarActStatus As Integer
        Private mvarType As String


#End Region

		Public ReadOnly Property SRV_ID() As Integer
			Get
				Return mvarSRV_ID
			End Get
		End Property

		Public Property SRVNO() As String
			Get
				Return mvarSRVNO
			End Get
			Set(ByVal Value As String)
				mvarSRVNO = Value
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

        Public ReadOnly Property Create_Date() As String
            Get
                Return mvarCreate_Date
            End Get
        End Property

        Public Property ActStatus() As Integer
            Get
                Return mvarActStatus
            End Get
            Set(ByVal Value As Integer)
                mvarActStatus = Value
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


        Public Function Save() As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO SRV("
            strSQL = strSQL & "SRVNO, type,ActStatus, Create_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarSRVNO) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarSRVNO, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarType) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarType, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarActStatus) > 0 Then
                strSQL = strSQL & mvarActStatus & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            strSQL = strSQL & " GetDate(),"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & mvarUserID
            Else
                strSQL = strSQL & " NULL"
            End If

            strSQL = strSQL & ")"



            strSQL = strSQL & ";(SELECT @@IDENTITY AS SRV_ID from SRV)"

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

        Public Sub Delete(ByVal pSRV_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM SRV"
            strSQL = strSQL & " WHERE SRV_ID=" & pSRV_ID

            strSQL = strSQL & ";DELETE FROM StockTransaction"
            strSQL = strSQL & " WHERE SRV_ID=" & pSRV_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Function LoadListSRV(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='SRV'"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListPMR(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='PMR'"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListDO(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='DO'"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListRTN(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='RTN'"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function CheckExist(ByVal DocNo As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT *"
                SQLStr = SQLStr & " FROM SRV Where SRVNO='" & DocNo & "'"

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count = 0 Then
                        Return False
                    End If

                End If

            End With

            Return True
        End Function


    End Class
#End Region
End Namespace
