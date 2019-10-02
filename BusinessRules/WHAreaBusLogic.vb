Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace WHAreaBusRules
    Public Class WHAreaClss
        '** Warehouse Area **
        Private mvarWarehouse_Area_ID As Integer
        Private mvarWarehouse_Area As String
        Private mvarDescription As String
        Private mvarWarehouse_ID As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#Region "WarehouseArea SQL Statement"
        Public Function GetWarehouseArea(ByRef dsWarehouseArea As DataSet, Optional ByVal pWarehouse_ID As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String
                If pWarehouse_ID = 0 Then
                    SQLStr = "SELECT * FROM WarehouseArea"
                Else
                    SQLStr = "SELECT * FROM WarehouseArea WHERE Warehouse_ID = " & pWarehouse_ID
                End If

                If .GetDataSet(dsWarehouseArea, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveWarehouseArea(ByVal pWarehouse_ID As String) As Boolean
            Dim dsWarehouseArea As DataSet
            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO WarehouseArea (Warehouse_Area"
            SQLstr = SQLstr & ", Description, Warehouse_ID, Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarWarehouse_Area & "', '" & mvarDescription & "',"
            SQLstr = SQLstr & pWarehouse_ID & ", GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"
            SQLstr = SQLstr & ";SELECT @@identity as Warehouse_Area_ID FROM WarehouseArea"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouseArea, SQLstr) Then
                    If dsWarehouseArea.Tables(0).Rows.Count > 0 Then
                        mvarWarehouse_Area_ID = dsWarehouseArea.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
            End With
            dsWarehouseArea.Dispose()
        End Function

        Public Function UpdateWarehouseArea(ByVal pWHArea_ID As String) As Boolean
            Dim dsWarehouseArea As DataSet
            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE WarehouseArea SET "
            SQLStr = SQLStr & " Warehouse_Area = '" & mvarWarehouse_Area & "',"
            SQLStr = SQLStr & " Description = '" & mvarDescription & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " Warehouse_Area_ID = " & pWHArea_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouseArea, SQLStr) Then
                    Return True
                End If
            End With
            dsWarehouseArea.Dispose()
        End Function

        Public Function DeleteWarehouseArea(ByVal pWHArea_ID As String) As Boolean
            Dim dsWarehouseArea As DataSet
            Dim SQLStr As String = "DELETE FROM WarehouseArea WHERE Warehouse_Area_ID = " & pWHArea_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouseArea, SQLStr) Then
                    Return True
                End If
            End With
            dsWarehouseArea.Dispose()
        End Function

        Public Function CheckDuplicateWarehouseArea() As Boolean
            Dim dsWarehouseArea As DataSet
            Dim SQLStr As String = "Select * from WarehouseArea WHERE Warehouse_Area = '" & mvarWarehouse_Area & "'"
            SQLStr = SQLStr & " and Warehouse_ID = '" & mvarWarehouse_ID & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouseArea, SQLStr) Then
                    If dsWarehouseArea.Tables(0).Rows.Count = 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
            dsWarehouseArea.Dispose()
        End Function

        Public Function CheckWarehouseLocation() As Boolean
            Dim dsWarehouseLocation As DataSet
            Dim SQLStr As String = "Select * from WarehouseLocation WHERE Warehouse_Area_ID = " & mvarWarehouse_Area_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouseLocation, SQLStr) Then
                    If dsWarehouseLocation.Tables(0).Rows.Count = 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
            dsWarehouseLocation.Dispose()
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM WarehouseArea "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadList2(ByRef ds As DataSet, ByVal pWarehouse_ID As String) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT Warehouse_Area_ID, Warehouse_Area + ' - ' + Description As Warehouse_Area FROM WarehouseArea "
                If (pWarehouse_ID.Length > 0) Then
                    SQLStr = SQLStr & " where Warehouse_ID = " & pWarehouse_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(ByVal pWHArea_ID As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM WarehouseArea"

                SQLStr = SQLStr & " WHERE Warehouse_Area_ID =" & pWHArea_ID

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Warehouse_Area") Then
                        Warehouse_Area = row("Warehouse_Area").ToString()
                    Else
                        Warehouse_Area = ""
                    End If

                    If Not row.IsNull("Description") Then
                        Description = row("Description").ToString()
                    Else
                        Description = ""
                    End If

                    Return True
                End If
            End With
        End Function

        Public Function RecordExists(ByVal pName As String, Optional ByVal pWH_ID As Integer = Nothing, Optional ByVal pWHArea_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT * FROM WarehouseArea"
            SQLStr = SQLStr & " WHERE Warehouse_Area='" & pName & "'"

            If pWH_ID <> Nothing And pWH_ID <> 0 Then
                SQLStr = SQLStr & " AND Warehouse_ID=" & pWH_ID
            End If

            If pWHArea_ID <> Nothing And pWHArea_ID <> 0 Then
                SQLStr = SQLStr & " AND Warehouse_Area_ID<>" & pWHArea_ID
            End If

            Debug.Write(SQLStr)

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


#End Region

#Region "WarehouseArea's Get n Let Property"
        Public Property Warehouse_Area_ID() As Integer
            Get
                Return mvarWarehouse_Area_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWarehouse_Area_ID = Value
            End Set
        End Property

        Public Property Warehouse_Area() As String
            Get
                Return mvarWarehouse_Area
            End Get
            Set(ByVal Value As String)
                mvarWarehouse_Area = Value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return mvarDescription
            End Get
            Set(ByVal Value As String)
                mvarDescription = Value
            End Set
        End Property

        Public Property Warehouse_ID() As Integer
            Get
                Return mvarWarehouse_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWarehouse_ID = Value
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
