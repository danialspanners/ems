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

        Private mvarSearchProductName As String
        Private mvarSearchAreaName As String
        Private mvarSearchByAreaId As Integer
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

        Public Property SearchProductName() As String
            Get
                Return Me.mvarSearchProductName
            End Get
            Set(ByVal Value As String)
                mvarSearchProductName = Value
            End Set
        End Property

        Public Property SearchAreaName() As String
            Get
                Return Me.mvarSearchAreaName
            End Get
            Set(ByVal Value As String)
                mvarSearchAreaName = Value
            End Set
        End Property

        Public Property SearchByAreaId() As Integer
            Get
                Return Me.mvarSearchByAreaId
            End Get
            Set(ByVal Value As Integer)
                mvarSearchByAreaId = Value
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
                SQLstr = SQLstr & " FROM Stock STK"
                SQLstr = SQLstr & " INNER Join Product PRD ON STK.Product_ID = PRD.Product_ID "
                SQLstr = SQLstr & " INNER Join Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID "
                SQLstr = SQLstr & " INNER Join WarehouseArea WA ON STK.Warehouse_Area_ID = WA.Warehouse_Area_ID "
                SQLstr = SQLstr & " LEFT OUTER JOIN Category CAT ON STK.Category_ID = CAT.Category_ID "
                SQLstr = SQLstr & " LEFT OUTER JOIN UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID "
                SQLstr = SQLstr & " LEFT OUTER JOIN Supplier SU ON STK.Supplier_ID = SU.Supplier_ID "
                SQLstr = SQLstr & " WHERE STK.Product_ID = " & pProduct_ID
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


        Public Function GetStockTransactionSA(ByRef ds As DataSet, ByVal SRV_ID As Integer) As Boolean
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

                SQLstr = "SELECT     ST.Transaction_ID,ST.Transaction_Type, ST.Transact_Date, UP.Name AS Requestor, ST.Order_NO, ST.Remarks, ST.Order_Type, STK.Stock_ID,"
                SQLstr = SQLstr & " STK.Stock_Id AS Stock_ID, WH.Warehouse, WA.Warehouse_Area, CAT.Name AS Category_Name, PRD.Name AS Product_Name, Qty= case ST.Transaction_type when 'Stock Out' then -(ST.Qty) else ST.Qty end,"
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
        Public Function GetStockTransferTransactionSRV(ByRef ds As DataSet, ByVal SRV_ID As Integer) As Boolean
            Dim SQLstr As String

            With New DataAccess.DAccess.Access

                SQLstr = "SELECT     ST.Transaction_ID, ST.Transact_Date, UP.Name AS Requestor, ST.Order_NO, ST.Remarks, ST.Order_Type, STK.Stock_ID,"
                SQLstr = SQLstr & " STK.Stock_Id AS Stock_ID, SWH.Warehouse as SRC_Warehouse, SWA.Warehouse_Area as SRC_Warehouse_Area,SWA.Warehouse_Area_id as SRC_Warehouse_Area_id,DWH.Warehouse as Dst_Warehouse, DWA.Warehouse_Area as Dst_Warehouse_area, DWA.Warehouse_Area_id as Dst_Warehouse_area_id, CAT.Name AS Category_Name, PRD.Product_ID,PRD.Name AS Product_Name, ST.Qty,"
                SQLstr = SQLstr & " UOM.Name AS UOM, 0 AS Reserved_Qty, SU.Supplier_Name AS Supplier, SU.Supplier_ID AS Supplier_ID"
                SQLstr = SQLstr & " FROM         Stock STK INNER JOIN"
                SQLstr = SQLstr & " StockTransaction ST ON STK.Stock_ID = ST.Stock_ID INNER JOIN"
                SQLstr = SQLstr & " Product PRD ON STK.Product_ID = PRD.Product_ID INNER JOIN"
                SQLstr = SQLstr & " Warehouse SWH ON ST.SRC_Warehouse_ID = SWH.Warehouse_ID INNER JOIN"
                SQLstr = SQLstr & " WarehouseArea SWA ON ST.SRC_Warehouse_Area_ID = SWA.Warehouse_Area_ID INNER JOIN"
                SQLstr = SQLstr & " Warehouse DWH ON ST.Dst_Warehouse_ID = DWH.Warehouse_ID INNER JOIN"
                SQLstr = SQLstr & " WarehouseArea DWA ON ST.Dst_Warehouse_Area_ID = DWA.Warehouse_Area_ID left outer JOIN"
                SQLstr = SQLstr & " Category CAT ON STK.Category_ID = CAT.Category_ID left outer JOIN"
                SQLstr = SQLstr & " UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID left outer JOIN"
                SQLstr = SQLstr & " Supplier SU ON STK.Supplier_ID = SU.Supplier_ID LEFT OUTER JOIN"
                SQLstr = SQLstr & " UserProfile UP ON ST.RequestedBy = UP.User_ID"
                SQLstr = SQLstr & " WHERE ST.SRV_ID = " & SRV_ID & " And Link_ID Is NULL"
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

        Public Function GetStockTransaction(ByRef ds As DataSet, ByVal pTransactionID As Integer) As Boolean
            Dim SQLstr As String

            With New DataAccess.DAccess.Access

                SQLstr = "SELECT ST.Transaction_ID, ST.Transact_Date, ST.Transaction_Type, UP.Name AS Requestor, ST.Order_NO, ST.Remarks, ST.Order_Type, STK.Stock_ID,"
                SQLstr = SQLstr & " STK.Stock_Id AS Stock_ID, WH.Warehouse, WA.Warehouse_Area, CAT.Name AS Category_Name, PRD.Name AS Product_Name, ST.Qty,"
                SQLstr = SQLstr & " UOM.Name AS UOM, 0 AS Reserved_Qty, SU.Supplier_Name AS Supplier, SU.Supplier_ID AS Supplier_ID,ST.Product_Id,ST.PO_NO,PRD.Description,STK.warehouse_id,STK.Warehouse_area_id"
                SQLstr = SQLstr & " FROM Stock STK INNER JOIN"
                SQLstr = SQLstr & " StockTransaction ST ON STK.Stock_ID = ST.Stock_ID INNER JOIN"
                SQLstr = SQLstr & " Product PRD ON STK.Product_ID = PRD.Product_ID INNER JOIN"
                SQLstr = SQLstr & " Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID INNER JOIN"
                SQLstr = SQLstr & " WarehouseArea WA ON STK.Warehouse_Area_ID = WA.Warehouse_Area_ID left outer JOIN"
                SQLstr = SQLstr & " Category CAT ON STK.Category_ID = CAT.Category_ID left outer JOIN"
                SQLstr = SQLstr & " UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID left outer JOIN"
                SQLstr = SQLstr & " Supplier SU ON STK.Supplier_ID = SU.Supplier_ID LEFT OUTER JOIN"
                SQLstr = SQLstr & " UserProfile UP ON ST.RequestedBy = UP.User_ID"
                SQLstr = SQLstr & " WHERE ST.Transaction_ID = " & pTransactionID
                SQLstr = SQLstr & " ORDER BY ST.Transact_Date DESC"

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
        End Function


        Public Function GetStockTransferTransaction(ByRef ds As DataSet, ByVal pTransactionID As Integer) As Boolean
            Dim SQLstr As String

            With New DataAccess.DAccess.Access

                SQLstr = "SELECT ST.Transaction_ID, ST.Transact_Date, ST.Transaction_Type, UP.Name AS Requestor, ST.Order_NO, ST.Remarks, ST.Order_Type, STK.Stock_ID,"
                SQLstr = SQLstr & " STK.Stock_Id AS Stock_ID, SWH.Warehouse as SRC_Warehouse, SWA.Warehouse_Area_id as SRC_Warehouse_Area_id,DWH.Warehouse as Dst_Warehouse, DWA.Warehouse_Area_id as Dst_Warehouse_area_id, CAT.Name AS Category_Name, PRD.Name AS Product_Name, ST.Qty,"
                SQLstr = SQLstr & " UOM.Name AS UOM, 0 AS Reserved_Qty, SU.Supplier_Name AS Supplier, SU.Supplier_ID AS Supplier_ID,ST.Product_Id,ST.PO_NO,PRD.Description,STK.warehouse_id,STK.Warehouse_area_id"
                SQLstr = SQLstr & " FROM Stock STK INNER JOIN"
                SQLstr = SQLstr & " StockTransaction ST ON STK.Stock_ID = ST.Stock_ID INNER JOIN"
                SQLstr = SQLstr & " Product PRD ON STK.Product_ID = PRD.Product_ID INNER JOIN"
                SQLstr = SQLstr & " Warehouse SWH ON ST.SRC_Warehouse_ID = SWH.Warehouse_ID INNER JOIN"
                SQLstr = SQLstr & " WarehouseArea SWA ON ST.SRC_Warehouse_Area_ID = SWA.Warehouse_Area_ID INNER JOIN"
                SQLstr = SQLstr & " Warehouse DWH ON ST.Dst_Warehouse_ID = DWH.Warehouse_ID INNER JOIN"
                SQLstr = SQLstr & " WarehouseArea DWA ON ST.Dst_Warehouse_Area_ID = DWA.Warehouse_Area_ID left outer JOIN"
                SQLstr = SQLstr & " Category CAT ON STK.Category_ID = CAT.Category_ID left outer JOIN"
                SQLstr = SQLstr & " UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID left outer JOIN"
                SQLstr = SQLstr & " Supplier SU ON STK.Supplier_ID = SU.Supplier_ID LEFT OUTER JOIN"
                SQLstr = SQLstr & " UserProfile UP ON ST.RequestedBy = UP.User_ID"
                SQLstr = SQLstr & " WHERE ST.Transaction_ID = " & pTransactionID
                SQLstr = SQLstr & " ORDER BY ST.Transact_Date DESC"

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
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

                SQLStr = SQLStr & " Order by WHA.Warehouse_Area asc "

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

                    SQLstr = "SELECT     STK.*, CAT.Category_ID AS Expr1, CAT.Name AS Category, PRD.Product_ID AS Expr2, PRD.Name AS Product, PRD.Description AS Description, PRD.Alt_Description as Alt_Description, "
                    SQLstr = SQLstr & " SUP.Supplier_Name AS Expr3, UOM.UOM_ID AS Expr4, UOM.Name AS UOM, WH.*, WHA.*"
                    SQLstr = SQLstr & " FROM         Stock STK INNER JOIN"
                    SQLstr = SQLstr & "  Product PRD ON STK.Product_ID = PRD.Product_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  Category CAT ON PRD.Category_ID = CAT.Category_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  Supplier SUP ON STK.Supplier_ID = SUP.Supplier_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & " WarehouseArea WHA ON STK.Warehouse_Area_ID = WHA.Warehouse_Area_ID INNER JOIN"
                    SQLstr = SQLstr & "  Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID"
                    SQLstr = SQLstr & " Where 1=1 "

                    If mvarProduct_ID <> 0 Then
                        SQLstr = SQLstr & " AND     (STK.Product_ID = " & mvarProduct_ID & " ) "
                    End If
                    If Len(mvarSearchProductName) > 0 Then
                        SQLstr = SQLstr & " AND (PRD.Name Like '" & mvarSearchProductName & "') "
                    End If

                    If mvarSearchByAreaId > 0 Then
                        SQLstr = SQLstr & " AND (STK.Warehouse_Area_ID=" & Me.mvarSearchByAreaId & ")"
                    End If

                    If Len(mvarSearchAreaName) > 0 Then
                        SQLstr = SQLstr & " and (WHA.Warehouse_Area Like '" & mvarSearchAreaName & "') "
                    End If

                    SQLstr = SQLstr & " AND (STK.Warehouse_Area_ID <> 0) "

                    'Ensure there's Area ID


                    'SQLstr = SQLstr & " AND (STK.Qty <> 0)"
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

        Public Function GetStockNonZero() As DataSet
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

                    SQLstr = "SELECT     STK.*, CAT.Category_ID AS Expr1, CAT.Name AS Category, PRD.Product_ID AS Expr2, PRD.Name AS Product, PRD.Description AS Description, PRD.Alt_Description as Alt_Description, "
                    SQLstr = SQLstr & " SUP.Supplier_Name AS Expr3, UOM.UOM_ID AS Expr4, UOM.Name AS UOM, WH.*, WHA.*"
                    SQLstr = SQLstr & " FROM         Stock STK INNER JOIN"
                    SQLstr = SQLstr & "  Product PRD ON STK.Product_ID = PRD.Product_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  Category CAT ON STK.Category_ID = CAT.Category_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  Supplier SUP ON STK.Supplier_ID = SUP.Supplier_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & "  UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID LEFT OUTER JOIN"
                    SQLstr = SQLstr & " WarehouseArea WHA ON STK.Warehouse_Area_ID = WHA.Warehouse_Area_ID INNER JOIN"
                    SQLstr = SQLstr & "  Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID"
                    
                    If mvarProduct_ID <> 0 Then
                        SQLstr = SQLstr & " AND     (STK.Product_ID = " & mvarProduct_ID & " ) "
                    End If

                    If Len(mvarSearchProductName) > 0 Then
                        SQLstr = SQLstr & " AND (PRD.Name Like '" & mvarSearchProductName & "') "
                    End If

                    If mvarSearchByAreaId > 0 Then
                        SQLstr = SQLstr & " AND (STK.Warehouse_Area_ID=" & Me.mvarSearchByAreaId & ")"
                    End If

                    If Len(mvarSearchAreaName) > 0 Then
                        SQLstr = SQLstr & " and (WHA.Warehouse_Area Like '" & mvarSearchAreaName & "') "
                    End If


                    SQLstr = SQLstr & " AND (STK.Qty <> 0)"
                    'SQLstr = SQLstr & " AND UOM.UOM_ID = STK.UOM_ID AND STK.Qty <> 0"
                    'If Not mvarTransaction_Type = "Adjustment" Then
                    'SQLstr = SQLstr & " AND STK.Qty <> 0"
                    'End If
                    'SQLstr = SQLstr & " AND WH.Warehouse_ID = STK.Warehouse_ID AND WHA.Warehouse_Area_ID = STK.Warehouse_Area_ID AND WHL.Location_ID = STK.Location_ID"
                    'SQLstr = SQLstr & " AND WHA.Warehouse_Area_ID = STK.Warehouse_Area_ID AND WH.Warehouse_ID = STK.Warehouse_ID"
                    If Transaction_Type = "Reporting" Then
                        SQLstr = SQLstr & " GROUP BY STK.Product_ID"
                        SQLstr = SQLstr & " ORDER BY PRD.Name ASC"
                    Else
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

        Public Function GetStockLocation() As DataSet
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
                    SQLstr = SQLstr & " WHERE     (STK.Product_ID = " & mvarProduct_ID & " ) "
                    SQLstr = SQLstr & " and (STK.warehouse_id=" & Me.mvarWH_ID & " and STK.warehouse_area_id=" & Me.mvarWHA_ID & ")"


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


        Public Function GetStockQty(ByVal pProduct_ID, ByVal pWH_ID, ByVal pWHA_ID) As Integer
            Dim ds As DataSet
            Dim dr As DataRow
            Dim SQLstr As String

            With New DataAccess.DAccess.Access

                SQLstr = "SELECT STK.*"
                SQLstr = SQLstr & " FROM Stock STK "
                SQLstr = SQLstr & " WHERE     (STK.Product_ID = " & pProduct_ID & " ) "
                SQLstr = SQLstr & " and (STK.warehouse_id=" & pWH_ID & " and STK.warehouse_area_id=" & pWHA_ID & ")"

                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Return dr("Qty")
                    Else
                        Return 0
                    End If
                End If
            End With
        End Function


        Public Function GetSRVTransactDate(ByVal pSRVID) As Date
            Dim ds As DataSet
            Dim dr As DataRow
            Dim SQLstr As String

            With New DataAccess.DAccess.Access

                SQLstr = "SELECT SRV.Transact_Date"
                SQLstr = SQLstr & " FROM SRV "
                SQLstr = SQLstr & " WHERE     (SRV.SRV_ID= " & pSRVID & " ) "
                
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Dim dt As Date
                        If IsDBNull(dr("Transact_date")) Then
                            dt = Nothing
                        Else
                            dt = dr("Transact_date")
                        End If
                        Return dt
                    Else
                        Return Nothing
                    End If
                End If
            End With
        End Function


        Public Function SetTransactionDateSRV(ByVal pSRVID As Integer, ByVal pTransactDate As DateTime) As Boolean

            Dim SQLstr As String

            With New DataAccess.DAccess.Access

                .BeginTransaction()

                SQLstr = "set dateformat dmy;Update SRV "
                SQLstr = SQLstr & " set transact_date = '" & pTransactDate.Day & "/" & pTransactDate.Month & "/" & pTransactDate.Year & "' "
                SQLstr = SQLstr & " where SRV_ID=" & pSRVID

                If .ExecuteQueryNonCommit(SQLstr) = False Then
                    .EndTransaction()
                    Return False
                End If

                SQLstr = "set dateformat dmy;Update StockTransaction "
                SQLstr = SQLstr & " set transact_date = '" & pTransactDate.Day & "/" & pTransactDate.Month & "/" & pTransactDate.Year & "' "
                SQLstr = SQLstr & " where SRV_ID=" & pSRVID

                If .ExecuteQueryNonCommit(SQLstr) = False Then
                    .EndTransaction()
                    Return False
                End If

                .CommitTransaction()
                .EndTransaction()

            End With


            Return True

        End Function


        Public Function GetStock(ByVal pTransactdate As DateTime, ByVal pGreaterThanZero As Boolean) As DataSet
            'ItemType - 0 All Item, 1 Active Item, 2 Dormant Item
            'Cat_ID - 0 All category
            Dim ds As DataSet

            Dim SQLStr As String

            'Clear rptStockInventory
            SQLStr = "Delete From RptStockInventory"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = True Then
                    'Return False
                End If
            End With
            'Clear rptStocktotalinout
            SQLStr = "Delete From RptStocktotalinout"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = True Then
                    'Return False
                End If
            End With

            'Get the total stock in/out in location per product
            SQLStr = "SET dateformat dmy;INSERT "
            SQLStr = SQLStr & "INTO rptstocktotalinout(Product_ID, warehouse_area_id, Transaction_Type, totalout, totalin)"
            SQLStr = SQLStr & " (SELECT MAX(stk.Product_Id) AS product_id, MAX(src_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, SUM(qty) AS totalout, 0 AS totalin FROM StockTransaction stk join product prd on stk.product_id=prd.product_id "
            SQLStr = SQLStr & " join warehousearea st on stk.src_warehouse_area_id = st.warehouse_area_id "
            SQLStr = SQLStr & " WHERE ((stk.transact_date > '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "') AND ((Transaction_Type LIKE '%out')or(Transaction_Type LIKE '%clear'))   )"

            If mvarProduct_ID <> 0 Then
                SQLStr = SQLStr & " AND     (STK.Product_ID = " & mvarProduct_ID & " ) "
            End If

            If Len(mvarSearchProductName) > 0 Then
                SQLStr = SQLStr & " AND (PRD.Name Like '" & mvarSearchProductName & "') "
            End If

            If mvarSearchByAreaId > 0 Then
                SQLStr = SQLStr & " AND (STK.Warehouse_Area_ID=" & Me.mvarSearchByAreaId & ")"
            End If

            If Len(mvarSearchAreaName) > 0 Then
                SQLStr = SQLStr & " and (st.Warehouse_Area Like '" & mvarSearchAreaName & "') "
            End If

            SQLStr = SQLStr & " GROUP BY stk.product_id, src_warehouse_area_id)"

            SQLStr = SQLStr & " UNION "

            SQLStr = SQLStr & " (SELECT MAX(stk.Product_Id) AS product_id, MAX(dst_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, 0 AS totalout, SUM(qty) AS totalin FROM StockTransaction stk join product prd on stk.product_id=prd.product_id"
            SQLStr = SQLStr & " join warehousearea st on stk.dst_warehouse_area_id = st.warehouse_area_id "
            SQLStr = SQLStr & " WHERE ((stk.transact_date > '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "') AND (Transaction_Type LIKE '%in'))"

            If mvarProduct_ID <> 0 Then
                SQLStr = SQLStr & " AND     (STK.Product_ID = " & mvarProduct_ID & " ) "
            End If
            If Len(mvarSearchProductName) > 0 Then
                SQLStr = SQLStr & " AND (PRD.Name Like '" & mvarSearchProductName & "') "
            End If

            If mvarSearchByAreaId > 0 Then
                SQLStr = SQLStr & " AND (STK.Warehouse_Area_ID=" & Me.mvarSearchByAreaId & ")"
            End If

            If Len(mvarSearchAreaName) > 0 Then
                SQLStr = SQLStr & " and (st.Warehouse_Area Like '" & mvarSearchAreaName & "') "
            End If

            SQLStr = SQLStr & " GROUP BY stk.product_id, dst_warehouse_area_id)"

            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    'Return Nothing
                End If
            End With

            'insert into rptstockinventory
            SQLStr = "set dateformat dmy;INSERT INTO RptStockInventory"
            SQLStr = SQLStr & "(Product_Name, Product_Description, Category, Area, Qty, Unit, product_id, warehouse_area_id, Category_id, lasttransact_date, Rptbalancedate, RptItemType,RptCategory)"
            SQLStr = SQLStr & " SELECT MAX(p.Name) AS product_name, MAX(p.Description) AS Product_description, MAX(c.Name) AS category, MAX(w.Warehouse_Area) AS area,"
            SQLStr = SQLStr & "qty = CASE WHEN MAX(r.totalin) IS NULL THEN MAX(st.Qty) ELSE (MAX(st.Qty) - SUM(r.totalin - r.totalout)) END, MAX(u.Name) AS Unit, MAX(p.product_id) AS product_id,"
            SQLStr = SQLStr & " MAX(w.warehouse_area_id) AS warehouse_area_id, MAX(c.Category_id),"
            SQLStr = SQLStr & " lasttransact_date =(SELECT MAX(stt.Transact_date) "
            SQLStr = SQLStr & " FROM stocktransaction stt"
            SQLStr = SQLStr & " WHERE(stt.product_id = p.product_id) GROUP BY stt.product_id)"
            SQLStr = SQLStr & ",'" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "','','' "

            SQLStr = SQLStr & " FROM Product p INNER JOIN"
            SQLStr = SQLStr & " Category c ON p.Category_ID = c.Category_ID INNER JOIN"
            SQLStr = SQLStr & " UnitMeasurement u ON p.UOM_ID = u.UOM_ID LEFT OUTER JOIN"
            SQLStr = SQLStr & " Stock st ON p.Product_ID = st.Product_ID LEFT OUTER JOIN"
            SQLStr = SQLStr & " WarehouseArea w ON st.Warehouse_Area_ID = w.Warehouse_Area_ID LEFT OUTER JOIN"
            SQLStr = SQLStr & " rptStockTotalinout r ON r.product_id = p.Product_ID AND r.warehouse_area_id = st.Warehouse_Area_ID"
            SQLStr = SQLStr & " where 1=1 "
            'If pCat_ID > 0 Then
            'SQLStr = SQLStr & " and p.category_id = " & pCat_ID & " "
            'End If
            'If pWithLocation = True Then
            If mvarProduct_ID <> 0 Then
                SQLStr = SQLStr & " AND     (st.Product_ID = " & mvarProduct_ID & " ) "
            End If
            If Len(mvarSearchProductName) > 0 Then
                SQLStr = SQLStr & " AND (p.Name Like '" & mvarSearchProductName & "') "
            End If

            If mvarSearchByAreaId > 0 Then
                SQLStr = SQLStr & " AND (st.Warehouse_Area_ID=" & Me.mvarSearchByAreaId & ")"
            End If

            If Len(mvarSearchAreaName) > 0 Then
                SQLStr = SQLStr & " and (w.Warehouse_Area Like '" & mvarSearchAreaName & "') "
            End If

            SQLStr = SQLStr & " and w.warehouse_area_Id Is Not Null"
            'End If

            SQLStr = SQLStr & " GROUP BY p.Product_ID, st.Warehouse_Area_ID"

            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    Return Nothing
                End If
            End With

            SQLStr = "SELECT 0 as stock_id,i.Product_name as product,i.product_description as description, category,'WH1' as warehouse,'1' as warehouse_id,i.area as warehouse_area,* "
            SQLStr = SQLStr & " FROM RptStockInventory i join product p on i.product_id =p.product_id "
            SQLStr = SQLStr & " where 1=1 "


            If pGreaterThanZero = True Then
                SQLStr = SQLStr & " and qty > 0"
            End If

            SQLStr = SQLStr & " order by i.product_name asc"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
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
            If mvarTransaction_Type = "Stock Transfer" Then
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
                    'SQLstr = SQLstr & " AND STK.Location_ID = " & mvarDst_Location_ID
                ElseIf mvarTransaction_Type = "Stock In" Or mvarTransaction_Type = "Stock Out" Then
                    'SQLstr = SQLstr & " AND STK.Supplier_ID = " & mvarSupplier_ID
                    'If mvarLocation_ID <> 0 Then
                    SQLstr = SQLstr & " AND STK.Warehouse_ID = " & mvarWH_ID
                    SQLstr = SQLstr & " AND STK.Warehouse_Area_ID = " & mvarWHA_ID
                    'SQLstr = SQLstr & " AND STK.Location_ID = " & mvarLocation_ID
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

        Public Function RecordExist(ByVal Product_ID, ByVal WH_ID, ByVal WHA_ID) As DataSet
            Dim dsExist As DataSet
            Dim SQLstr As String

            With New DataAccess.DAccess.Access
                SQLstr = "SELECT STK.*"
                SQLstr = SQLstr & " FROM Stock STK"
                SQLstr = SQLstr & " WHERE STK.Product_ID = " & Product_ID
                SQLstr = SQLstr & " AND STK.Warehouse_ID = " & WH_ID
                SQLstr = SQLstr & " AND STK.Warehouse_Area_ID = " & WHA_ID
                
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
                ElseIf mvarTransaction_Type = "Stock Out" Or mvarTransaction_Type = "Stock Clear" Then
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

        Public Function SaveStockTransferTransaction() As Boolean
            Dim dsStkTxn As DataSet
            Dim SQLstr As String
            Dim RetStat As Boolean
            Dim SRC_Transaction_ID As String


            RetStat = False


            With New DataAccess.DAccess.Access
                
                SQLstr = "SET DATEFORMAT dmy;INSERT INTO StockTransaction"
                'SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty,Order_Type, Order_NO, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
                'SQLstr = SQLstr & " VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & ","

                SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Dst_Warehouse_ID, Dst_Warehouse_Area_ID, Dst_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, Order_Type, Order_NO,PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
                SQLstr = SQLstr & " VALUES (" & mvarSrcWH_ID & "," & mvarSrcWHA_ID & "," & mvarSrcLocation_ID & ","
                SQLstr = SQLstr & mvarDst_WH_ID & "," & mvarDst_WHA_ID & "," & mvarDst_Location_ID & ","

                SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                SQLstr = SQLstr & "'" & "Trans Out" & "'," & Me.mvarRelocateQty & ","
                SQLstr = SQLstr & "'" & mvarOrder_Type & "','" & mvarOrder_NO & "','" & mvarPO_NO & "',"
                If mvarRequestedBy = "" Then
                    SQLstr = SQLstr & "GetDate(),'" & Me.mvarTransact_Date & "','" & mvarUserID & "','" & mvarSRV_ID & "',NULL,'" & mvarRemarks & "')"
                Else
                    SQLstr = SQLstr & "GetDate(),'" & Me.mvarTransact_Date & "','" & mvarUserID & "','" & mvarSRV_ID & "'," & mvarRequestedBy & ",'" & mvarRemarks & "')"
                End If
                SQLstr = SQLstr & ";Select @@Identity as Transaction_ID from StockTransaction"
                If .GetDataSet(dsStkTxn, SQLstr) Then
                    SRC_Transaction_ID = dsStkTxn.Tables(0).Rows(0)(0)
                    RetStat = True
                End If

                If RetStat = True Then
                    SQLstr = "SET DATEFORMAT dmy;INSERT INTO StockTransaction"
                    'SQLstr = SQLstr & " (Dst_Warehouse_ID, Dst_Warehouse_Area_ID, Dst_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, Order_Type, Order_NO, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
                    'SQLstr = SQLstr & " VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & ","

                    SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Dst_Warehouse_ID, Dst_Warehouse_Area_ID, Dst_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, Order_Type, Order_NO,PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks,Link_ID)"
                    SQLstr = SQLstr & " VALUES (" & mvarSrcWH_ID & "," & mvarSrcWHA_ID & "," & mvarSrcLocation_ID & ","
                    SQLstr = SQLstr & mvarDst_WH_ID & "," & mvarDst_WHA_ID & "," & mvarDst_Location_ID & ","

                    SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                    SQLstr = SQLstr & "'" & "Trans In" & "'," & Me.mvarRelocateQty & ","
                    SQLstr = SQLstr & "'" & mvarOrder_Type & "','" & mvarOrder_NO & "','" & mvarPO_NO & "',"
                    If mvarRequestedBy = "" Then
                        SQLstr = SQLstr & "GetDate(),'" & Me.mvarTransact_Date & "','" & mvarUserID & "','" & mvarSRV_ID & "',NULL,'" & mvarRemarks & "',"
                    Else
                        SQLstr = SQLstr & "GetDate(),'" & Me.mvarTransact_Date & "','" & mvarUserID & "','" & mvarSRV_ID & "'," & mvarRequestedBy & ",'" & mvarRemarks & "',"
                    End If
                    SQLstr = SQLstr & SRC_Transaction_ID & ")"
                    If .GetDataSet(dsStkTxn, SQLstr) Then
                        dsStkTxn.Dispose()
                        Return True
                    End If
                End If
                dsStkTxn.Dispose()
                Return False
            End With
        End Function

        Public Function UpdateStockTransaction(ByVal pTransactionId As Integer) As Boolean
            Dim dsStkTxn As DataSet
            Dim SQLstr As String

            With New DataAccess.DAccess.Access
                SQLstr = "SET DATEFORMAT dmy;Update StockTransaction set"
                If mvarTransaction_Type = "Relocate" Then
                    'SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Dst_Warehouse_ID, Dst_Warehouse_Area_ID, Dst_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
                    'SQLstr = SQLstr & " VALUES (" & mvarSrcWH_ID & "," & mvarSrcWHA_ID & "," & mvarSrcLocation_ID & ","
                    'SQLstr = SQLstr & mvarDst_WH_ID & "," & mvarDst_WHA_ID & "," & mvarDst_Location_ID & ","
                    'SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                    'SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarRelocateQty & ",'" & mvarPO_NO & "',"
                ElseIf mvarTransaction_Type = "Adjustment" Then
                    'SQLstr = SQLstr & " (Src_Warehouse_ID, Src_Warehouse_Area_ID, Src_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
                    'SQLstr = SQLstr & "VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & "," & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                    'SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarAdjustedQty & ",'" & mvarPO_NO & "',"
                ElseIf mvarTransaction_Type = "Stock In" Then
                    'SQLstr = SQLstr & " (Dst_Warehouse_ID, Dst_Warehouse_Area_ID, Dst_Location_ID, Category_ID, Stock_ID, Product_ID, Transaction_Type, Qty, Order_Type, Order_NO, PO_NO,Create_Date, Transact_Date, UserID, SRV_ID, RequestedBy, Remarks)"
                    'SQLstr = SQLstr & " VALUES (" & mvarWH_ID & "," & mvarWHA_ID & "," & mvarLocation_ID & ","
                    'SQLstr = SQLstr & mvarCategory_ID & "," & mvarStock_ID & "," & mvarProduct_ID & ","
                    'SQLstr = SQLstr & "'" & mvarTransaction_Type & "'," & mvarStockInQty & ","
                    'SQLstr = SQLstr & "'" & mvarOrder_Type & "','" & mvarOrder_NO & "','" & mvarPO_NO & "',"

                    SQLstr = SQLstr & " Dst_Warehouse_ID = " & mvarWH_ID & ", "
                    SQLstr = SQLstr & " Dst_Warehouse_Area_ID =" & mvarWHA_ID & ","
                    SQLstr = SQLstr & " Dst_Location_ID = " & mvarLocation_ID & ","
                    SQLstr = SQLstr & " Category_ID = " & mvarCategory_ID & ","
                    SQLstr = SQLstr & " Stock_ID = " & mvarStock_ID & ","
                    SQLstr = SQLstr & " Product_ID = " & mvarProduct_ID & ","
                    SQLstr = SQLstr & " Transaction_Type ='" & mvarTransaction_Type & "',"
                    SQLstr = SQLstr & " Qty = " & mvarStockInQty & ","
                    SQLstr = SQLstr & " Order_Type= '" & mvarOrder_Type & "',"
                    SQLstr = SQLstr & " Order_NO ='" & mvarOrder_NO & "',"
                    SQLstr = SQLstr & " PO_NO='" & mvarPO_NO & "',"
                    SQLstr = SQLstr & " Transact_Date='" & Me.mvarTransact_Date & "',"
                    SQLstr = SQLstr & " Create_Date =GetDate(),"
                    SQLstr = SQLstr & " UserID= " & Me.mvarUserID & ","
                    If mvarRequestedBy = "" Then
                        SQLstr = SQLstr & " RequestedBy = NULL,"
                    Else
                        SQLstr = SQLstr & " RequestedBy = " & mvarRequestedBy & ","
                    End If
                    SQLstr = SQLstr & " Remarks = '" & mvarRemarks & "'"

                ElseIf mvarTransaction_Type = "Stock Out" Then
                    SQLstr = SQLstr & " Src_Warehouse_ID = " & mvarWH_ID & ", "
                    SQLstr = SQLstr & " Src_Warehouse_Area_ID =" & mvarWHA_ID & ","
                    SQLstr = SQLstr & " Src_Location_ID = " & mvarLocation_ID & ","
                    SQLstr = SQLstr & " Category_ID = " & mvarCategory_ID & ","
                    SQLstr = SQLstr & " Stock_ID = " & mvarStock_ID & ","
                    SQLstr = SQLstr & " Product_ID = " & mvarProduct_ID & ","
                    SQLstr = SQLstr & " Transaction_Type ='" & mvarTransaction_Type & "',"
                    SQLstr = SQLstr & " Qty = " & mvarStockOutQty & ","
                    SQLstr = SQLstr & " Order_Type= '" & mvarOrder_Type & "',"
                    SQLstr = SQLstr & " Order_NO ='" & mvarOrder_NO & "',"
                    SQLstr = SQLstr & " PO_NO='" & mvarPO_NO & "',"
                    SQLstr = SQLstr & " Transact_Date='" & Me.mvarTransact_Date & "',"
                    SQLstr = SQLstr & " Create_Date =GetDate(),"
                    SQLstr = SQLstr & " UserID= " & Me.mvarUserID & ","
                    If mvarRequestedBy = "" Then
                        SQLstr = SQLstr & " RequestedBy = NULL,"
                    Else
                        SQLstr = SQLstr & " RequestedBy = " & mvarRequestedBy & ","
                    End If
                    SQLstr = SQLstr & " Remarks = '" & mvarRemarks & "'"
                End If

                SQLstr = SQLstr & " where Transaction_ID=" & pTransactionId

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
                SQLstr = "Delete from StockTransaction where Transaction_ID=" & Transaction_Id
                If .GetDataSet(dsStkTxn, SQLstr) Then
                    Return True
                End If
                dsStkTxn.Dispose()
            End With

        End Function

        Public Function DeleteStockTransferTransaction(ByVal Transaction_Id As Integer)
            Dim dsStkTxn As DataSet
            Dim SQLstr As String

            With New DataAccess.DAccess.Access
                SQLstr = "Delete from StockTransaction where Transaction_ID=" & Transaction_Id
                SQLstr = SQLstr & " OR Link_ID = " & Transaction_Id
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
                If mvarTransaction_Type = "Stock Transfer" Then
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

            SQLstr = "UPDATE Stock SET"
            If mvarTransaction_Type = "Stock Transfer" Then
                SQLstr = SQLstr & " Qty = Qty - " & mvarRelocateQty & ","
            ElseIf mvarTransaction_Type = "Adjustment" Then
                SQLstr = SQLstr & " Qty = " & mvarAdjustedQty & ","
            ElseIf mvarTransaction_Type = "Stock In" Then
                SQLstr = SQLstr & " Qty = Qty + " & mvarStockInQty & ","
            ElseIf mvarTransaction_Type = "Stock Out" Or mvarTransaction_Type = "Stock Clear" Then
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

        Public Function UpdateSelectedStockTransfer() As Boolean
            Dim dsSelected As DataSet
            Dim TempQty As Integer
            Dim SQLstr As String
            Dim RetStat As Boolean
            RetStat = False

            'If mvarTransaction_Type = "Stock Transfer" Then
            'TempQty = mvarInStoreQty + mvarRelocateQty
            'End If

            SQLstr = "UPDATE Stock SET"
            SQLstr = SQLstr & " Qty = Qty + " & mvarRelocateQty & ","
            SQLstr = SQLstr & " Transact_Date = GetDate(), UserID = " & mvarUserID
            SQLstr = SQLstr & " WHERE Product_ID = " & Me.mvarProduct_ID
            SQLstr = SQLstr & " AND Warehouse_area_ID = " & Me.mvarSrcWHA_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsSelected, SQLstr) Then
                    RetStat = True
                End If
            End With

            If RetStat = True Then
                SQLstr = "UPDATE Stock SET"
                SQLstr = SQLstr & " Qty = Qty - " & mvarRelocateQty & ","
                SQLstr = SQLstr & " Transact_Date = GetDate(), UserID = " & mvarUserID
                SQLstr = SQLstr & " WHERE Product_ID = " & Me.mvarProduct_ID
                SQLstr = SQLstr & " AND Warehouse_area_ID = " & Me.mvarDst_WHA_ID

                With New DataAccess.DAccess.Access
                    If .GetDataSet(dsSelected, SQLstr) Then
                        RetStat = True
                    End If
                End With
            End If

            dsSelected.Dispose()
            Return RetStat

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

            'Clear rptStockInventory
            SQLStr = "Delete From RptStockInventory"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    Return False
                End If
            End With
            'Clear rptStocktotalinout
            SQLStr = "Delete From RptStocktotalinout"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    Return False
                End If
            End With

            'Clear rptLatestPrice
            SQLStr = "Delete From RptLatestPrice"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    Return False
                End If
            End With


            'Get the total stock in/out in location per product
            SQLStr = "SET dateformat dmy;INSERT "
            SQLStr = SQLStr & "INTO rptstocktotalinout(Product_ID, warehouse_area_id, Transaction_Type, totalout, totalin))"
            SQLStr = SQLStr & " (SELECT MAX(Product_Id) AS product_id, MAX(src_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, SUM(qty) AS totalout, 0 AS totalin FROM StockTransaction"
            SQLStr = SQLStr & " WHERE ((transact_date > '30/7/2006') AND ((Transaction_Type LIKE '%out') or (Transaction_Type LIKE '%clear')))"
            SQLStr = SQLStr & " GROUP BY product_id, src_warehouse_area_id)"
            SQLStr = SQLStr & " UNION "
            SQLStr = SQLStr & " (SELECT MAX(Product_Id) AS product_id, MAX(dst_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, 0 AS totalout, SUM(qty) AS totalin FROM StockTransaction"
            SQLStr = SQLStr & " WHERE ((transact_date > '30/7/2006') AND (Transaction_Type LIKE '%in'))"
            SQLStr = SQLStr & " GROUP BY product_id, dst_warehouse_area_id)"

            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    Return False
                End If
            End With

            'insert into rptstockinventory
            SQLStr = "INSERT INTO RptStockInventory"
            SQLStr = "(Product_Name, Product_Description, Category, Area, Qty, Unit, product_id, warehouse_area_id)"
            SQLStr = " SELECT MAX(p.Name) AS product_name, MAX(p.Description) AS Product_description, MAX(c.Name) AS category, MAX(w.Warehouse_Area) AS area,"
            SQLStr = "qty = CASE WHEN MAX(r.totalin) IS NULL THEN 0 ELSE (MAX(st.Qty) - SUM(r.totalin - r.totalout)) END, MAX(u.Name) AS Unit, MAX(p.product_id) AS product_id,"
            SQLStr = " MAX(w.warehouse_area_id) AS warehouse_area_id"
            SQLStr = " FROM Product p INNER JOIN"
            SQLStr = " Category c ON p.Category_ID = c.Category_ID INNER JOIN"
            SQLStr = " UnitMeasurement u ON p.UOM_ID = u.UOM_ID LEFT OUTER JOIN"
            SQLStr = " Stock st ON p.Product_ID = st.Product_ID LEFT OUTER JOIN"
            SQLStr = " WarehouseArea w ON st.Warehouse_Area_ID = w.Warehouse_Area_ID LEFT OUTER JOIN"
            SQLStr = " rptStockTotalinout r ON r.product_id = p.Product_ID AND r.warehouse_area_id = st.Warehouse_Area_ID"
            SQLStr = " GROUP BY p.Product_ID, st.Warehouse_Area_ID"

            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    Return False
                End If
            End With


            SQLStr = "Select * from rptStockInventory"
            'SQLStr = "SELECT VW.Product_Name AS Product, VW.Product_Description AS Description, VW.Category, sum(VW.Qty) AS Total_Qty, VW.UOM"
            'SQLStr = SQLStr & " FROM vw_ungrouped_inventory VW"
            'SQLStr = SQLStr & " GROUP BY VW.Product_ID, VW.Product_Name, VW.Product_Description, VW.Category, VW.UOM"
            'SQLStr = SQLStr & " ORDER BY VW.Product_Name ASC"

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

        Public Function GetInventoryReport(ByVal pCat_ID As Integer, ByVal pItemType As Integer, ByVal pTransactdate As DateTime, ByVal pRecordDate As DateTime, ByVal pGreaterThanZero As Boolean, ByVal pWithLocation As Boolean, ByRef ds As DataSet, ByVal pExcludeZeroPrice As Boolean, ByVal pSGD As Boolean, Optional ByVal pFilter As String = "") As Boolean
            'ItemType - 0 All Item, 1 Active Item, 2 Dormant Item
            'Cat_ID - 0 All category


            Dim SQLStr As String

            ''Clear rptStockInventory
            'SQLStr = "Delete From RptStockInventory"
            'With New DataAccess.DAccess.Access
            '    If .ExecuteQuery(SQLStr) = True Then
            '        'Return False
            '    End If
            'End With
            ''Clear rptStocktotalinout
            'SQLStr = "Delete From RptStocktotalinout"
            'With New DataAccess.DAccess.Access
            '    If .ExecuteQuery(SQLStr) = True Then
            '        'Return False
            '    End If
            'End With

            ''Clear rptLatestPrice
            'SQLStr = "Delete From RptLatestPrice"
            'With New DataAccess.DAccess.Access
            '    If .ExecuteQuery(SQLStr) = True Then
            '        'Return False
            '    End If
            'End With

            SQLStr = "drop View rptstocktotalinout_view"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = True Then
                    'Return False
                End If
            End With

            SQLStr = "drop View RptStockInventory_view"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = True Then
                    'Return False
                End If
            End With

            SQLStr = "drop view RptLatestPrice_view"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = True Then
                    'Return False
                End If
            End With
            'Get the total stock in/out in location per product
            'SQLStr = "SET dateformat dmy;INSERT "
            'SQLStr = SQLStr & "INTO rptstocktotalinout(Product_ID, warehouse_area_id, Transaction_Type, totalout, totalin)"

            SQLStr = "Create View rptstocktotalinout_view as "

            SQLStr = SQLStr & " (SELECT MAX(Product_Id) AS product_id, MAX(src_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, SUM(qty) AS totalout, 0 AS totalin FROM StockTransaction"
            SQLStr = SQLStr & " WHERE ((transact_date > '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "') AND ((Transaction_Type LIKE '%out') or (Transaction_Type LIKE '%clear')))"
            SQLStr = SQLStr & " GROUP BY product_id, src_warehouse_area_id)"
            SQLStr = SQLStr & " UNION "
            SQLStr = SQLStr & " (SELECT MAX(Product_Id) AS product_id, MAX(dst_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, 0 AS totalout, SUM(qty) AS totalin FROM StockTransaction"
            SQLStr = SQLStr & " WHERE ((transact_date > '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "') AND (Transaction_Type LIKE '%in'))"
            SQLStr = SQLStr & " GROUP BY product_id, dst_warehouse_area_id)"

            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    'Return False
                End If
            End With

            'insert into rptstockinventory

            'SQLStr = "set dateformat dmy;INSERT INTO RptStockInventory"
            'SQLStr = SQLStr & "(Product_Name, Product_Description, Category, Area, Qty, Unit, product_id, warehouse_area_id, Category_id, lasttransact_date, Rptbalancedate,Rptrecorddate,RptItemType,RptCategory,ActiveItem)"

            SQLStr = "Create View RptStockInventory_view as "
            SQLStr = SQLStr & " SELECT MAX(p.Name) AS product_name, MAX(p.Description) AS Product_description, MAX(c.Name) AS category, MAX(w.Warehouse_Area) AS area,"
            SQLStr = SQLStr & "qty = CASE WHEN MAX(r.totalin) IS NULL THEN MAX(st.Qty) ELSE (MAX(st.Qty) - SUM(r.totalin - r.totalout)) END, MAX(u.Name) AS Unit, MAX(p.product_id) AS product_id,"
            SQLStr = SQLStr & " MAX(w.warehouse_area_id) AS warehouse_area_id, MAX(c.Category_id) As Category_id,"
            SQLStr = SQLStr & " lasttransact_date =(SELECT MAX(stt.Transact_date) "
            SQLStr = SQLStr & " FROM stocktransaction stt"
            SQLStr = SQLStr & " WHERE(stt.product_id = p.product_id) and (stt.transaction_type not like 'TRANS%') GROUP BY stt.product_id)"
            SQLStr = SQLStr & ",'" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "' As Rptbalancedate"
            SQLStr = SQLStr & ",'" & pRecordDate.Day & "/" & pRecordDate.Month & "/" & pRecordDate.Year & "' As Rptrecorddate,"

            'ItemType - 0 All Item, 1 Active Item, 2 Dormant Item
            If pItemType = 0 Then
                SQLStr = SQLStr & " 'All Items' as RptItemType "
            ElseIf pItemType = 1 Then
                SQLStr = SQLStr & " 'Active Items only' as RptItemType "
            ElseIf pItemType = 2 Then
                SQLStr = SQLStr & " 'Dormant Items only' as RptItemType "
            End If
            If pCat_ID = 0 Then
                SQLStr = SQLStr & ",'' as RptCategory "
            Else
                SQLStr = SQLStr & ", MAX(c.Name) as RptCategory "
            End If

            SQLStr = SQLStr & ", dbo.GetActiveStatus(Max(p.product_id),'" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "') As ActiveItem "
            SQLStr = SQLStr & " FROM Product p INNER JOIN"
            SQLStr = SQLStr & " Category c ON p.Category_ID = c.Category_ID INNER JOIN"
            SQLStr = SQLStr & " UnitMeasurement u ON p.UOM_ID = u.UOM_ID LEFT OUTER JOIN"
            SQLStr = SQLStr & " Stock st ON p.Product_ID = st.Product_ID LEFT OUTER JOIN"
            SQLStr = SQLStr & " WarehouseArea w ON st.Warehouse_Area_ID = w.Warehouse_Area_ID LEFT OUTER JOIN"
            SQLStr = SQLStr & " rptStockTotalinout_view r ON r.product_id = p.Product_ID AND r.warehouse_area_id = st.Warehouse_Area_ID"
            SQLStr = SQLStr & " where 1=1 "

            If pCat_ID > 0 Then
                SQLStr = SQLStr & " and p.category_id = " & pCat_ID & " "
            End If

            If pWithLocation = True Then
                SQLStr = SQLStr & " and w.warehouse_area_Id Is Not Null"
            End If

            SQLStr = SQLStr & " and p.HideReport=0 and w.Hidereport =0 "

            'If pGreaterThanZero = True Then
            'SQLStr = SQLStr & " and qty > 0"
            'End If

            If Len(pFilter) > 0 Then
                SQLStr = SQLStr & " " & pFilter
            End If

            'TEMP
            'SQLStr = SQLStr & " and p.product_id in (select product_id from product where product.category_id=29 and product.name like 'B%') "
            'SQLStr = SQLStr & " or p.product_id in (select product_id from product where product.category_id=30 and product.name like 'R%') "
            'SQLStr = SQLStr & " and p.name !='RAS-2.5/1300/2030' "
            'SQLStr = SQLStr & " and p.name !='RAS-2.5/4/8' "
            'SQLStr = SQLStr & " and p.name !='REG-3/4/8' "

            'SQLStr = SQLStr & " and p.name ='HF-S35/17/Z' "

            'SQLStr = SQLStr & " AND i.product_Name like 'B%' OR i.product_Name like 'R%' "



            SQLStr = SQLStr & " GROUP BY p.Product_ID, st.Warehouse_Area_ID"
            Try
                With New DataAccess.DAccess.Access
                    If .ExecuteQuery(SQLStr) = False Then
                        Return False
                    End If
                End With
            Catch Ex As Exception
                Console.Write(Ex.Message)
            End Try


            'SQLStr = "SET  dateformat dmy;INSERT INTO rptlatestprice (Product_ID,productsupplier_id)"
            'SQLStr = SQLStr & "select p.product_id,  dbo.getlastpriceproductsupplierid(p.product_id,'" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "') as productsupplierid from product p"
            'Try
            '    With New DataAccess.DAccess.Access
            '        If .ExecuteQuery(SQLStr) = False Then
            '            Return False
            '        End If
            '    End With
            'Catch Ex As Exception
            '    Console.Write(Ex.Message)
            'End Try
            SQLStr = "create view rptlatestprice_view as "
            SQLStr = SQLStr & "select ps2.ProductSupplier_ID, p.product_id, ps2.currency, ps2.enquiry_price, "
            If pSGD = True Then
                SQLStr = SQLStr & " CASE when (ps2.purchase_price * c.exchangerate_sgd) >= 0.01 then ROUND((ps2.purchase_price * c.exchangerate_sgd),2) else (ps2.purchase_price* c.exchangerate_sgd) end As purchase_price,"
            Else
                SQLStr = SQLStr & " CASE when (ps2.purchase_price) >= 0.01 then ROUND((ps2.purchase_price),2) else (ps2.purchase_price) end As purchase_price, "
            End If

            SQLStr = SQLStr & "ps2.Transact_Date from product p cross apply ("
            SQLStr = SQLStr & "select top 1 * from ProductSupplier ps "
            SQLStr = SQLStr & "where ps.transact_date <= '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "' AND "
            SQLStr = SQLStr & " ps.product_id = p.product_id and (ps.purchase_price <> 0) and ps.History_record = 0 order by ps.Transact_Date desc) ps2 left join Currency c on ps2.Currency=c.Currency_ID"

            'SQLStr = "SET  dateformat dmy;INSERT INTO rptlatestprice(productsupplier_id, Product_ID, currency, enquiry_price, purchase_price, Transact_Date)"
            'SQLStr = SQLStr & " SELECT     productsupplier_id, product_id, currency, "

            'If pSGD = True Then
            '    SQLStr = SQLStr & " CASE when (p.enquiry_Price *c.exchangerate_sgd) >= 0.01 then ROUND((p.enquiry_Price *c.exchangerate_sgd),2) else (p.enquiry_Price *c.exchangerate_sgd) end As enquiry_price,  "
            '    SQLStr = SQLStr & " CASE when (p.purchase_price* c.exchangerate_sgd) >= 0.01 then ROUND((p.purchase_price* c.exchangerate_sgd),2) else (p.purchase_price* c.exchangerate_sgd) end As purchase_price, "
            'Else
            '    SQLStr = SQLStr & " CASE when (p.enquiry_Price) >= 0.01 then ROUND((p.enquiry_Price),2) else (p.enquiry_Price) end As enquiry_price,  "
            '    SQLStr = SQLStr & " CASE when (p.purchase_price) >= 0.01 then ROUND((p.purchase_price),2) else (p.purchase_price) end As purchase_price, "
            'End If

            'SQLStr = SQLStr & " p.transact_date"
            'SQLStr = SQLStr & " FROM productSupplier p LEFT JOIN  currency c ON p.currency = c.currency_id WHERE history_record = 0 AND p.transact_date <= '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "' AND purchase_price != 0 AND "
            'SQLStr = SQLStr & " p.transact_date = (SELECT  TOP 1 transact_date FROM productSupplier WHERE product_id = p.product_id AND history_record = 0 "
            'SQLStr = SQLStr & " AND transact_date <= '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "' AND purchase_price != 0 ORDER BY transact_date DESC)"

            'SQLStr = SQLStr & " UNION"

            'SQLStr = SQLStr & " SELECT     productsupplier_id, product_id, currency, "

            'If pSGD = True Then
            '    SQLStr = SQLStr & " CASE when (p.enquiry_Price *c.exchangerate_sgd) >= 0.01 then ROUND((p.enquiry_Price *c.exchangerate_sgd),2) else (p.enquiry_Price *c.exchangerate_sgd) end As enquiry_price,  "
            '    SQLStr = SQLStr & " CASE when (p.purchase_price* c.exchangerate_sgd) >= 0.01 then ROUND((p.purchase_price* c.exchangerate_sgd),2) else (p.purchase_price* c.exchangerate_sgd) end As purchase_price, "
            'Else
            '    SQLStr = SQLStr & " CASE when (p.enquiry_Price) >= 0.01 then ROUND((p.enquiry_Price),2) else (p.enquiry_Price) end As enquiry_price,  "
            '    SQLStr = SQLStr & " CASE when (p.purchase_price) >= 0.01 then ROUND((p.purchase_price),2) else (p.purchase_price) end As purchase_price, "
            'End If

            'SQLStr = SQLStr & " p.transact_date"
            'SQLStr = SQLStr & " FROM productSupplier p LEFT JOIN  currency c ON p.currency = c.currency_id WHERE history_record = 0 AND p.transact_date <= '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "' AND enquiry_price != 0 AND "
            'SQLStr = SQLStr & " p.transact_date = (SELECT  TOP 1 transact_date FROM productSupplier WHERE product_id = p.product_id AND history_record = 0 "
            'SQLStr = SQLStr & " AND transact_date <= '" & pTransactdate.Day & "/" & pTransactdate.Month & "/" & pTransactdate.Year & "' AND enquiry_price != 0 ORDER BY transact_date DESC)"
            Try
                With New DataAccess.DAccess.Access
                    If .ExecuteQuery(SQLStr) = False Then
                        Return False
                    End If
                End With
            Catch Ex As Exception
                Console.Write(Ex.Message)
            End Try

            SQLStr = ""

            If pSGD = True Then
                'SQLStr = "SELECT price = CASE WHEN p.purchase_price <> 0 THEN (p.purchase_price) ELSE (p.enquiry_price * c.exchangerate_sgd) END,"
                'SQLStr = "set dateformat dmy;SELECT convert(DOUBLE PRECISION,p.price),"
                SQLStr = "set dateformat dmy;SELECT price = CASE WHEN p.purchase_price <> 0 THEN convert(DOUBLE PRECISION,p.purchase_price) ELSE convert(DOUBLE PRECISION,p.enquiry_price) END, "
                SQLStr = SQLStr & "'Singapore Dollar' as SGCurrencyName, 'S$' as CurrencySymbol,*"
                SQLStr = SQLStr & " FROM RptStockInventory_view i left JOIN"

                'SQLStr = SQLStr & " (select top 1 p.product_id,p.currency,c.CurrencySymbol,c.exchangerate_sgd, price=CASE WHEN p.purchase_price <> 0 THEN p.purchase_price ELSE p.enquiry_price end from ProductSupplier p"
                'SQLStr = SQLStr & " left join Currency c on p.Currency=c.Currency_ID )"

                SQLStr = SQLStr & " (SELECT  MAX(currency) AS currency_id, MAX(purchase_price) AS purchase_price, MAX(enquiry_price) AS enquiry_price, MAX(product_id) AS product_id"
                SQLStr = SQLStr & " FROM rptLatestPrice_view GROUP BY product_id) "
                SQLStr = SQLStr & " p ON i.product_id = p.product_id"
                SQLStr = SQLStr & "  LEFT JOIN  currency c ON p.currency_id = c.currency_id"
                SQLStr = SQLStr & " where 1=1 "
            Else
                SQLStr = "set dateformat dmy;SELECT price = CASE WHEN p.purchase_price <> 0 THEN convert(DOUBLE PRECISION,p.purchase_price) ELSE convert(DOUBLE PRECISION,p.enquiry_price) END, *"
                SQLStr = SQLStr & " FROM RptStockInventory_view i left JOIN"

                SQLStr = SQLStr & " (SELECT  MAX(currency) AS currency_id, MAX(purchase_price) AS purchase_price, MAX(enquiry_price) AS enquiry_price, MAX(product_id) AS product_id"
                SQLStr = SQLStr & " FROM rptLatestPrice_view GROUP BY product_id) p ON i.product_id = p.product_id"
                SQLStr = SQLStr & "  LEFT JOIN  currency c ON p.currency_id = c.currency_id"
                SQLStr = SQLStr & " where 1=1 "
            End If

            If pItemType = 1 Then 'active item
                'SQLStr = SQLStr & " and lasttransact_date>getdate()-356"
                SQLStr = SQLStr & " and activeitem=1"
            ElseIf pItemType = 2 Then 'dormant item
                'SQLStr = SQLStr & " and lasttransact_date<=getdate()-356"
                SQLStr = SQLStr & " and activeitem=0"
            End If

            If pGreaterThanZero = True Then
                SQLStr = SQLStr & " and qty > 0"
            End If

            'Temp.
            SQLStr = SQLStr & " and Area <> 'N/A' "

            If pExcludeZeroPrice = True Then
                'SQLStr = SQLStr & " and (price <> 0)"
                SQLStr = SQLStr & " and (p.purchase_price <> 0 or p.enquiry_price <> 0)"
            End If

            'TEMP Filter'
            'SQLStr = SQLStr & " AND i.category_id <> 31 "
            'SQLStr = SQLStr & " AND i.product_name <> 'LH-E145/25'"


            'SQLStr = SQLStr & " AND i.product_Name like 'B%' OR i.product_Name like 'R%' "
            'SQLStr = SQLStr & " AND i.category_id <> 29 "
            'SQLStr = SQLStr & " AND i.product_Name not in ('KY-A69','KY-A91','MC-MG26/10','MC-MG210/10','TB-EM6/8STP.RS') "
            'SQLStr = SQLStr & " AND i.warehouse_area_id in (select MAX(r.warehouse_area_id) from rptstockinventory r where r.category_id=29 and r.qty > 0 and r.activeitem=1 group by r.warehouse_area_id) "


            SQLStr = SQLStr & " order by i.product_name asc"


            'SQLStr = "SELECT VW.Product_Name AS Product, VW.Product_Description AS Description, VW.Category, sum(VW.Qty) AS Total_Qty, VW.UOM"
            'SQLStr = SQLStr & " FROM vw_ungrouped_inventory VW"
            'SQLStr = SQLStr & " GROUP BY VW.Product_ID, VW.Product_Name, VW.Product_Description, VW.Category, VW.UOM"
            'SQLStr = SQLStr & " ORDER BY VW.Product_Name ASC"

            'SQLStr = "SELECT PRD.Name As Product, PRD.Description As Description, CAT.Name As Category, sum(STK.Qty) As Total_Qty, UOM.Name As UOM"
            'SQLStr = SQLStr & " FROM Stock STK, Category CAT, Product PRD, UnitMeasurement UOM"
            'SQLStr = SQLStr & " WHERE PRD.Product_ID = STK.Product_ID"
            'SQLStr = SQLStr & " AND CAT.Category_ID = STK.Category_ID AND STK.UOM_ID = UOM.UOM_ID"
            'SQLStr = SQLStr & " AND STK.Qty <> 0"
            'SQLStr = SQLStr & " GROUP BY PRD.Name, CAT.Name, PRD.Description, UOM.Name"
            'SQLStr = SQLStr & " ORDER BY PRD.Name ASC"
            Try
                With New DataAccess.DAccess.Access
                    If .GetDataSet(ds, SQLStr) Then
                        Return True
                    End If
                End With
            Catch Ex As Exception
                Console.Write(Ex.Message)
            End Try


        End Function

        Public Function GetInventoryReportInstant(ByVal pCat_ID As Integer, ByVal pItemType As Integer, ByVal pTransactdate As DateTime, ByVal pRecordDate As DateTime, ByVal pGreaterThanZero As Boolean, ByVal pWithLocation As Boolean, ByRef ds As DataSet, ByVal pExcludeZeroPrice As Boolean, ByVal pSGD As Boolean, Optional ByVal pFilter As String = "")

            Dim SQLStr As String

            'ItemType - 0 All Item, 1 Active Item, 2 Dormant Item

            If pSGD = True Then
                SQLStr = "SELECT price = CASE WHEN p.purchase_price <> 0 THEN round((p.purchase_price*c.exchangerate_sgd),2) ELSE round((p.enquiry_price*c.exchangerate_sgd),2) END,"
                SQLStr = SQLStr & "'Singapore Dollar' as SGCurrencyName, 'S$' as CurrencySymbol,*"
                SQLStr = SQLStr & " FROM RptStockInventory i left JOIN"
                SQLStr = SQLStr & " (SELECT  MAX(currency) AS currency_id, MAX(purchase_price) AS purchase_price, MAX(enquiry_price) AS enquiry_price, MAX(product_id) AS product_id"
                SQLStr = SQLStr & " FROM rptLatestPrice GROUP BY product_id) p ON i.product_id = p.product_id"
                SQLStr = SQLStr & "  LEFT JOIN  currency c ON p.currency_id = c.currency_id"
                SQLStr = SQLStr & " where 1=1 "
            Else
                SQLStr = "SELECT price = CASE WHEN p.purchase_price <> 0 THEN p.purchase_price ELSE p.enquiry_price END, *"
                SQLStr = SQLStr & " FROM RptStockInventory i left JOIN"
                SQLStr = SQLStr & " (SELECT  MAX(currency) AS currency_id, MAX(purchase_price) AS purchase_price, MAX(enquiry_price) AS enquiry_price, MAX(product_id) AS product_id"
                SQLStr = SQLStr & " FROM rptLatestPrice GROUP BY product_id) p ON i.product_id = p.product_id"
                SQLStr = SQLStr & "  LEFT JOIN  currency c ON p.currency_id = c.currency_id"
                SQLStr = SQLStr & " where 1=1 "
            End If

            If pItemType = 1 Then 'active item
                'SQLStr = SQLStr & " and lasttransact_date>getdate()-356"
                SQLStr = SQLStr & " and activeitem=1"
            ElseIf pItemType = 2 Then 'dormant item
                'SQLStr = SQLStr & " and lasttransact_date<=getdate()-356"
                SQLStr = SQLStr & " and activeitem=0"
            End If

            If pGreaterThanZero = True Then
                SQLStr = SQLStr & " and qty > 0"
            End If

            'Temp.
            SQLStr = SQLStr & " and Area <> 'N/A' "

            If pExcludeZeroPrice = True Then
                SQLStr = SQLStr & " and (p.purchase_price <> 0 or p.enquiry_price <> 0)"
            End If


            'TEMP Filter'
            'SQLStr = SQLStr & " AND i.product_Name Not like 'B%' "
            'SQLStr = SQLStr & " AND i.category_id <> 29 "
            'SQLStr = SQLStr & " AND i.product_Name not in ('KY-A69','KY-A91','MC-MG26/10','MC-MG210/10','TB-EM6/8STP.RS') "
            'SQLStr = SQLStr & " AND i.warehouse_area_id in (select MAX(r.warehouse_area_id) from rptstockinventory r where r.category_id=29 and r.qty > 0 and r.activeitem='true' group by r.warehouse_area_id) "





            SQLStr = SQLStr & " order by i.product_name asc"

            Try
                With New DataAccess.DAccess.Access
                    If .GetDataSet(ds, SQLStr) Then
                        Return True
                    End If
                End With
            Catch Ex As Exception
                Console.Write(Ex.Message)
            End Try


        End Function


        Public Function GetInventoryReportx(ByVal pCat_ID As Integer, ByVal pItemType As Integer, ByVal pTransactdate As DateTime, ByVal pGreaterThanZero As Boolean, ByVal pWithLocation As Boolean, ByRef ds As DataSet)
            'ItemType - 0 All Item, 1 Active Item, 2 Dormant Item
            'Cat_ID - 0 All category


            Dim SQLStr As String

            SQLStr = "Select * from rptStockInventory "
            SQLStr = SQLStr & "where 1=1 "

            If pItemType = 1 Then 'active item
                SQLStr = SQLStr & " and lasttransact_date>now()-356"
            ElseIf pItemType = 2 Then 'dormant item
                SQLStr = SQLStr & " and lasttransact_date<=now()-356"
            End If

            If pGreaterThanZero = True Then
                SQLStr = SQLStr & " and qty > 0"
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With

            Return False

        End Function

        Public Function GetStockBalDetReport(ByVal pCat_ID As Integer, ByVal pStartDate As DateTime, ByVal pEndDate As DateTime, ByVal pGreaterThanZero As Boolean, ByVal pWithLocation As Boolean, ByRef ds As DataSet, Optional ByVal withPrice As Boolean = False)

            Dim SQLStr As String

            Dim StartBalanceDate As DateTime

            StartBalanceDate = pStartDate.Date.AddDays(-1)

            'Clear rptStocktotalinout
            SQLStr = "Delete From RptStocktotalinout"
            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = True Then
                    'Return False
                End If
            End With

            'Get the total stock in/out in location per product
            SQLStr = "SET dateformat dmy;INSERT "
            SQLStr = SQLStr & "INTO rptstocktotalinout(Product_ID, warehouse_area_id, Transaction_Type, totalout, totalin)"
            SQLStr = SQLStr & " (SELECT MAX(stk.Product_Id) AS product_id, MAX(src_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, SUM(qty) AS totalout, 0 AS totalin FROM StockTransaction stk join product prd on stk.product_id=prd.product_id "
            SQLStr = SQLStr & " WHERE ((stk.transact_date > '" & StartBalanceDate.Day & "/" & StartBalanceDate.Month & "/" & StartBalanceDate.Year & "') AND ((Transaction_Type LIKE '%out') or (Transaction_Type LIKE '%clear')))"

            If pCat_ID > 0 Then
                SQLStr = SQLStr & " and prd.category_id = " & pCat_ID & " "
            End If

            If Len(mvarSearchProductName) > 0 Then
                SQLStr = SQLStr & " and (prd.Name = '" & mvarSearchProductName & "') "
            End If
            SQLStr = SQLStr & " GROUP BY stk.product_id, src_warehouse_area_id)"

            SQLStr = SQLStr & " UNION "

            SQLStr = SQLStr & " (SELECT MAX(stk.Product_Id) AS product_id, MAX(dst_warehouse_area_id) AS warehouse_area_id, MAX(transaction_type) "
            SQLStr = SQLStr & " AS transaction_type, 0 AS totalout, SUM(qty) AS totalin FROM StockTransaction stk join product prd on stk.product_id=prd.product_id"
            SQLStr = SQLStr & " WHERE ((stk.transact_date > '" & StartBalanceDate.Day & "/" & StartBalanceDate.Month & "/" & StartBalanceDate.Year & "') AND (Transaction_Type LIKE '%in'))"

            If pCat_ID > 0 Then
                SQLStr = SQLStr & " and prd.category_id = " & pCat_ID & " "
            End If

            If Len(mvarSearchProductName) > 0 Then
                SQLStr = SQLStr & " and (prd.Name = '" & mvarSearchProductName & "') "
            End If

            SQLStr = SQLStr & " GROUP BY stk.product_id, dst_warehouse_area_id)"

            With New DataAccess.DAccess.Access
                If .ExecuteQuery(SQLStr) = False Then
                    'Return Nothing
                End If
            End With

            SQLStr = "set dateformat dmy;select dr.*,bf=s.qty - rpt.totalin + rpt.totalout from (SELECT st.product_id, prd.name, prd.description, s.SRVNO, st.Order_no, Loc = CASE WHEN right(st.Transaction_type, 2) "
            SQLStr = SQLStr & "= 'in' THEN wa_dst.warehouse_area ELSE wa_src.warehouse_area END, warehouse_area_id=CASE WHEN right(st.Transaction_type, 2)='in' THEN wa_dst.warehouse_area_id ELSE wa_src.warehouse_area_id END ,IN_qty = CASE WHEN right(st.Transaction_type, 2) "
            SQLStr = SQLStr & "= 'in' THEN qty ELSE 0 END, Out_qty = CASE WHEN right(st.Transaction_type, 2) = 'in' THEN 0 ELSE qty END, st.transact_date, st.transaction_ID"
            If withPrice = True Then
                SQLStr = SQLStr & ", dbo.GetPrice(st.product_id,st.transact_date) as price "
            End If
            SQLStr = SQLStr & " FROM StockTransaction st INNER JOIN"
            SQLStr = SQLStr & " SRV s ON st.SRV_ID = s.SRV_ID JOIN"
            SQLStr = SQLStr & " product prd ON st.product_id = prd.product_id LEFT JOIN"
            SQLStr = SQLStr & " warehousearea wa_src ON st.src_warehouse_area_id = wa_src.warehouse_area_id LEFT JOIN"
            SQLStr = SQLStr & " warehousearea wa_dst ON st.dst_warehouse_area_id = wa_dst.warehouse_area_id"
            SQLStr = SQLStr & " where 1=1 "

            If pCat_ID > 0 Then
                SQLStr = SQLStr & " and prd.category_id = " & pCat_ID & " "
            End If

            If Len(mvarSearchProductName) > 0 Then
                SQLStr = SQLStr & " and (prd.Name = '" & mvarSearchProductName & "') "
            End If

            SQLStr = SQLStr & " and st.transact_date >= '" & pStartDate.Day & "/" & pStartDate.Month & "/" & pStartDate.Year & "'"
            SQLStr = SQLStr & " and st.transact_date <= '" & pEndDate.Day & "/" & pEndDate.Month & "/" & pEndDate.Year & "'"
            SQLStr = SQLStr & ") dr JOIN (SELECT     MAX(product_id) AS product_id, MAX(warehouse_area_id) AS warehouse_area_id, SUM(totalout) AS totalout, SUM(totalin) AS totalin FROM rptStockTotalinout GROUP BY product_id, warehouse_area_id) rpt ON rpt.warehouse_area_id = dr.warehouse_area_id AND rpt.product_id = dr.product_id LEFT JOIN"
            SQLStr = SQLStr & " stock s ON rpt.warehouse_area_id = s.warehouse_area_id AND rpt.product_id = s.product_id"
            SQLStr = SQLStr & " ORDER BY dr.name,dr.loc,dr.transact_date,dr.transaction_ID ASC"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With

        End Function

        Public Function GetStockTransReport(ByVal title As String, ByVal SRV_ID As Integer, ByRef ds As DataSet)

            Dim SQLStr As String
            With New DataAccess.DAccess.Access

                SQLStr = "SELECT    SR.SRVNO, ST.Transaction_ID, ST.Transact_Date, ST.Order_no, UP.Name AS Requestor, ST.Order_NO, ST.Remarks, ST.Order_Type, STK.Stock_ID,"
                SQLStr = SQLStr & " STK.Stock_Id AS Stock_ID, WH.Warehouse, WA.Warehouse_Area, CAT.Name AS Category_Name, PRD.Name AS Product_Name,PRD.Description As Description, ST.Qty,"
                SQLStr = SQLStr & " UOM.Name AS UOM, 0 AS Reserved_Qty, SU.Supplier_Name AS Supplier, SU.Supplier_ID AS Supplier_ID"
                SQLStr = SQLStr & " FROM Stock STK INNER JOIN"
                SQLStr = SQLStr & " StockTransaction ST ON STK.Stock_ID = ST.Stock_ID INNER JOIN"
                SQLStr = SQLStr & " SRV SR on ST.SRV_ID = SR.SRV_ID INNER JOIN"
                SQLStr = SQLStr & " Product PRD ON STK.Product_ID = PRD.Product_ID INNER JOIN"
                SQLStr = SQLStr & " Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID INNER JOIN"
                SQLStr = SQLStr & " WarehouseArea WA ON STK.Warehouse_Area_ID = WA.Warehouse_Area_ID left outer JOIN"
                SQLStr = SQLStr & " Category CAT ON STK.Category_ID = CAT.Category_ID left outer JOIN"
                SQLStr = SQLStr & " UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID left outer JOIN"
                SQLStr = SQLStr & " Supplier SU ON STK.Supplier_ID = SU.Supplier_ID LEFT OUTER JOIN"
                SQLStr = SQLStr & " UserProfile UP ON ST.RequestedBy = UP.User_ID"
                SQLStr = SQLStr & " WHERE ST.SRV_ID = " & SRV_ID
                SQLStr = SQLStr & " ORDER BY ST.Transact_Date DESC"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With

        End Function


        Public Function GetStockTransReport_ByDate(ByVal pCat_ID As Integer, ByVal pProductName As String, ByVal pTransactionType As String, ByVal title As String, ByVal StartDate As String, ByVal EndDate As String, ByRef ds As DataSet)

            Dim SQLStr As String
            With New DataAccess.DAccess.Access

                SQLStr = "set dateformat dmy;SELECT '" & title & "' As SRVNO, PRD.Product_ID,  ST.Transact_Date,SUM(ST.Qty) as qty,PRD.Name As Product_Name,PRD.Description,WA.Warehouse_Area"
                SQLStr = SQLStr & " FROM Stock STK INNER JOIN"
                SQLStr = SQLStr & " StockTransaction ST ON STK.Stock_ID = ST.Stock_ID INNER JOIN"
                SQLStr = SQLStr & " SRV SR on ST.SRV_ID = SR.SRV_ID INNER JOIN"
                SQLStr = SQLStr & " Product PRD ON STK.Product_ID = PRD.Product_ID INNER JOIN"
                SQLStr = SQLStr & " Warehouse WH ON STK.Warehouse_ID = WH.Warehouse_ID INNER JOIN"
                SQLStr = SQLStr & " WarehouseArea WA ON STK.Warehouse_Area_ID = WA.Warehouse_Area_ID left outer JOIN"
                SQLStr = SQLStr & " Category CAT ON STK.Category_ID = CAT.Category_ID left outer JOIN"
                SQLStr = SQLStr & " UnitMeasurement UOM ON STK.UOM_ID = UOM.UOM_ID left outer JOIN"
                SQLStr = SQLStr & " Supplier SU ON STK.Supplier_ID = SU.Supplier_ID LEFT OUTER JOIN"
                SQLStr = SQLStr & " UserProfile UP ON ST.RequestedBy = UP.User_ID"
                SQLStr = SQLStr & " WHERE ST.transact_date >= '" & StartDate & "' and ST.transact_date <= '" & EndDate & "' "

                If pTransactionType <> "ALL" And pTransactionType <> "" Then
                    SQLStr = SQLStr & " and SR.Type='" & pTransactionType & "' "
                End If

                If pCat_ID > 0 Then
                    SQLStr = SQLStr & " and prd.category_id = " & pCat_ID & " "
                End If

                If Len(pProductName) > 0 Then
                    SQLStr = SQLStr & " and (prd.Name Like '" & pProductName & "') "
                End If
                SQLStr = SQLStr & " group by ST.Transact_Date,PRD.Product_ID,PRD.Name,PRD.Description,WA.Warehouse_Area_ID,WA.Warehouse_Area"
                SQLStr = SQLStr & " ORDER BY ST.Transact_Date DESC, PRD.Name ASC"


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
        Private mvarTransact_Date As Date


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

        Public Property Transact_Date() As Date
            Get
                Return mvarTransact_Date
            End Get
            Set(ByVal Value As Date)
                mvarTransact_Date = Value
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
            strSQL = strSQL & "SRVNO, type,ActStatus, Create_Date, Transact_Date, UserID "
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

            If mvarTransact_Date <> Nothing Then
                strSQL = strSQL & "'" & mvarTransact_Date.Day & "/" & mvarTransact_Date.Month & "/" & mvarTransact_Date.Year & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

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

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With


            strSQL = "Select * FROM StockTransaction"
            strSQL = strSQL & " WHERE SRV_ID=" & pSRV_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With

            Dim i As Integer
            Dim Transaction_Type As String
            Dim Qty As Integer

            With New BusinessRules.BusRules.InventoryBusLogic
                If ds.Tables(0).Rows.Count > 0 Then
                    For i = 0 To ds.Tables(0).Rows.Count - 1

                        Transaction_Type = ds.Tables(0).Rows(i)("transaction_type")
                        Qty = ds.Tables(0).Rows(i)("Qty")
                        .UserID = UserID

                        If Transaction_Type = "Stock Out" Or Transaction_Type = "Stock Clear" Then
                            .Transaction_Type = "Stock In"
                            .Stock_ID = ds.Tables(0).Rows(i)("Stock_id")
                            .StockInQty = Qty
                            If .UpdateSelectedStock() Then
                                .DeleteStockTransaction(ds.Tables(0).Rows(i)("transaction_id"))
                            End If
                        ElseIf Transaction_Type = "Stock In" Or Transaction_Type = "Rturn In" Then
                            .Transaction_Type = "Stock Out"
                            .Stock_ID = ds.Tables(0).Rows(i)("Stock_id")
                            .StockOutQty = Qty
                            If .UpdateSelectedStock() Then
                                .DeleteStockTransaction(ds.Tables(0).Rows(i)("transaction_id"))
                            End If
                        ElseIf Transaction_Type = "Trans In" Or Transaction_Type = "Trans Out" Then
                            .Src_WHA_ID = ds.Tables(0).Rows(i)("Src_Warehouse_Area_Id")
                            .Dst_WHA_ID = ds.Tables(0).Rows(i)("Dst_Warehouse_Area_Id")
                            .Product_ID = ds.Tables(0).Rows(i)("Product_id")
                            .Transaction_Type = "Stock Transfer"
                            .Relocate_Qty = Qty
                            If .UpdateSelectedStockTransfer() Then
                                .DeleteStockTransferTransaction(ds.Tables(0).Rows(i)("transaction_id"))
                            End If
                        Else
                            Return
                        End If
                    Next
                End If
            End With

            ds.Dispose()
        End Sub

        Public Function LoadListSRV(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='SRV'"
                SQLStr = SQLStr & " order by SRVNO"

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
                SQLStr = SQLStr & " order by SRVNO"

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
                SQLStr = SQLStr & " order by SRVNO"

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
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListST(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='ST'"
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListSA(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='SA'"
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListFGW(ByRef ds As DataSet, ByVal Sortby As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                If Sortby = "" Then
                    Sortby = "SRVNO"
                End If

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='FGW'"
                SQLStr = SQLStr & " order by " & Sortby 'SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListFGW(ByRef ds As DataSet, ByVal yr As String, ByVal Sortby As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                If Sortby = "" Then
                    Sortby = "SRVNO"
                End If

                SQLStr = "SELECT SRV.SRV_ID, SRV.SRVNO,  CONVERT(VARCHAR,SRV.Transact_Date,101) as Transact_Date"
                SQLStr = SQLStr & " FROM SRV "
                'SQLStr = SQLStr & " INNER JOIN  (SELECT MAX(transact_date) as tdate, MAX(Year(transact_date)) AS tyr, srv_id FROM stocktransaction stt"
                'SQLStr = SQLStr & " GROUP BY stt.srv_id) tt ON SRV.SRV_ID = tt.srv_id"
                SQLStr = SQLStr & " Where Type='FGW'"
                If yr.ToUpper() <> "ALL" Then
                    SQLStr = SQLStr & " and Year(SRV.Transact_Date)='" & yr & "'"
                End If
                SQLStr = SQLStr & " order by " & Sortby 'SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListQAR(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID, SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='QAR'"
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListQAR(ByRef ds As DataSet, ByVal yr As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV.SRV_ID, SRV.SRVNO,  CONVERT(VARCHAR,SRV.Transact_Date,101) as Transact_Date"
                SQLStr = SQLStr & " FROM SRV "
                'SQLStr = SQLStr & " INNER JOIN  (SELECT MAX(transact_date) as tdate,MAX(Year(transact_date)) AS tyr, srv_id FROM stocktransaction stt"
                'SQLStr = SQLStr & " GROUP BY stt.srv_id) tt ON SRV.SRV_ID = tt.srv_id"
                SQLStr = SQLStr & " Where Type='QAR'"
                If yr.ToUpper() <> "ALL" Then
                    SQLStr = SQLStr & " and Year(SRV.Transact_Date)='" & yr & "'"
                End If
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListINT(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV.SRV_ID, SRV.SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='INT'"
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadListINT(ByRef ds As DataSet, ByVal yr As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV.SRV_ID, SRV.SRVNO,  CONVERT(VARCHAR,SRV.Transact_Date,101) as Transact_Date"
                SQLStr = SQLStr & " FROM SRV "
                'SQLStr = SQLStr & " INNER JOIN  (SELECT MAX(transact_date) as tdate, MAX(Year(transact_date)) AS tyr, srv_id FROM stocktransaction stt"
                'SQLStr = SQLStr & " GROUP BY stt.srv_id) tt ON SRV.SRV_ID = tt.srv_id"
                SQLStr = SQLStr & " Where Type='INT'"
                If yr.ToUpper() <> "ALL" Then
                    SQLStr = SQLStr & " and Year(SRV.Transact_Date)='" & yr & "'"
                End If
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet, ByVal pType As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV.SRV_ID, SRV.SRVNO"
                SQLStr = SQLStr & " FROM SRV Where Type='" & pType & "'"
                SQLStr = SQLStr & " order by SRVNO"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet, ByVal pType As String, ByVal yr As String, ByVal Sortby As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV.SRV_ID, SRV.SRVNO,  CONVERT(VARCHAR,SRV.Transact_Date,101) as Transact_Date"
                SQLStr = SQLStr & " FROM SRV "
                'SQLStr = SQLStr & " INNER JOIN  (SELECT MAX(transact_date) as tdate, MAX(Year(transact_date)) AS tyr, srv_id FROM stocktransaction stt"
                'SQLStr = SQLStr & " GROUP BY stt.srv_id) tt ON SRV.SRV_ID = tt.srv_id"
                SQLStr = SQLStr & " Where Type='" & pType & "'"
                If yr.ToUpper() <> "ALL" Then
                    SQLStr = SQLStr & " and Year(SRV.Transact_Date)='" & yr & "'"
                End If
                'SQLStr = SQLStr & " order by SRVNO"
                SQLStr = SQLStr & " order by " & Sortby 'SRVNO"

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


        Public Function GetSRVID(ByVal DocNo As String) As Integer
            Dim ds As DataSet
            With New DataAccess.DAccess.Access

                Dim SQLStr As String

                SQLStr = "SELECT SRV_ID"
                SQLStr = SQLStr & " FROM SRV Where SRVNO='" & DocNo & "'"

                If .GetDataSet(ds, SQLStr) Then

                    If ds.Tables(0).Rows.Count > 0 Then
                        Return Convert.ToInt32(ds.Tables(0).Rows(0)("SRV_ID"))
                    End If

                End If

            End With

            Return True
        End Function

        Public Function FixPMR() As Boolean
            Dim ds As DataSet

            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "update SRV set Type='PMR' where SRVNO like 'PMR%'"

                If .ExecuteQuery(SQLStr) Then
                    FixPMR = True
                Else
                    FixPMR = False
                End If

            End With

        End Function



    End Class
#End Region
End Namespace
