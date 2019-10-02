Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace WHLocationBusRules
    Public Class WHLocationClss
        '** Warehouse Area **
        Private mvarWarehouse_ID As Integer
        Private mvarWarehouse_Area_ID As Integer
        Private mvarRow As Integer
        Private mvarCol As Integer
        Private mvarHeight As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String

#Region "WarehouseLocation SQL Statement"
        Public Function GetWarehouseLocation(ByRef dsWarehouseLocation As DataSet, Optional ByVal pWarehouse_Location_ID As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String
                If pWarehouse_Location_ID = 0 Then
                    SQLStr = "SELECT * FROM WarehouseLocation"
                Else
                    SQLStr = "SELECT * FROM WarehouseLocation WHERE Location_ID = " & pWarehouse_Location_ID
                End If

                If .GetDataSet(dsWarehouseLocation, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveWarehouseLocation(ByVal pWarehouse_ID As String, ByVal pWarehouse_Area_ID As String) As Boolean
            Dim dsWarehouseLocation As DataSet

            mvarRow = 1
            mvarCol = 1
            mvarHeight = 1

            Dim SQLstr As String = "INSERT INTO WarehouseLocation (Warehouse_ID"
            SQLstr = SQLstr & ", Warehouse_Area_ID, Row, Col, Height, Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "(" & pWarehouse_ID & ", " & pWarehouse_Area_ID & ","
            SQLstr = SQLstr & mvarRow & ", " & mvarCol & ", " & mvarHeight & ", GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouseLocation, SQLstr) Then
                    Return True
                End If
            End With
            dsWarehouseLocation.Dispose()
        End Function

#End Region

#Region "WarehouseLocation 's Get n Let Property"

        Public Property Warehouse_ID() As Integer
            Get
                Return mvarWarehouse_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWarehouse_ID = Value
            End Set
        End Property

        Public Property Warehouse_Area_ID() As Integer
            Get
                Return mvarWarehouse_Area_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWarehouse_Area_ID = Value
            End Set
        End Property

        Public Property Row() As Integer
            Get
                Return mvarRow
            End Get
            Set(ByVal Value As Integer)
                mvarRow = Value
            End Set
        End Property


        Public Property Col() As Integer
            Get
                Return mvarCol
            End Get
            Set(ByVal Value As Integer)
                mvarCol = Value
            End Set
        End Property

        Public Property Height() As Integer
            Get
                Return mvarHeight
            End Get
            Set(ByVal Value As Integer)
                mvarHeight = Value
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
