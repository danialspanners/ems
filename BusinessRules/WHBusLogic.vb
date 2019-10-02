Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace WHBusRules
    Public Class WHBusLogic
        '** Warehouse **
        Private mvarWarehouse_ID As Integer
        Private mvarWarehouse As String
        Private mvarDescription As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#Region "Warehouse SQL Statement"

        Public Function GetWarehouse(ByRef dsWarehouse As DataSet, Optional ByVal pWarehouse_ID As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String
                If pWarehouse_ID = 0 Then
                    SQLStr = "SELECT * FROM Warehouse"
                Else
                    SQLStr = "SELECT * FROM Warehouse WHERE Warehouse_ID = " & pWarehouse_ID
                End If

                If .GetDataSet(dsWarehouse, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveWarehouse() As Boolean
            Dim dsWarehouse As DataSet
            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO Warehouse (Warehouse"
            SQLstr = SQLstr & ", Description, Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarWarehouse & "', '" & mvarDescription & "',"
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouse, SQLstr) Then
                    Return True
                End If
            End With
            dsWarehouse.Dispose()
        End Function

        Public Function UpdateWarehouse(ByVal pWarehouse_ID As String) As Boolean
            Dim dsWarehouse As DataSet
            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Warehouse SET "
            SQLStr = SQLStr & " Warehouse = '" & mvarWarehouse & "',"
            SQLStr = SQLStr & " Description = '" & mvarDescription & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " Warehouse_ID = " & pWarehouse_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouse, SQLStr) Then
                    Return True
                End If
            End With
            dsWarehouse.Dispose()
        End Function

        Public Function DeleteWarehouse(ByVal pWarehouse_ID As String) As Boolean
            Dim dsWarehouse As DataSet
            Dim ErrorMessage As String

            Dim SQLStr As String = "DELETE FROM Warehouse WHERE Warehouse_ID = " & pWarehouse_ID

            With New DataAccess.DAccess.Access
                If WarehouseAreaExist(pWarehouse_ID) Then
                    ' MessageBox.Show("There are warehouse area belonging to this warehouse!", "Delete Warehouse", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    ' Show Error message - Warehouse Area exist Cannot delete Warehouse
                    ' ErrorMessage = ErrorMessage & " Warehouse Area" & Chr(13)
                    ' MessageBox.Show(Common.CommonError.ErrorMsg.DUPLICATE_REC_MSG & "Name", "Error - Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                Else
                    If .GetDataSet(dsWarehouse, SQLStr) Then
                        Return True
                    End If
                End If
            End With
            dsWarehouse.Dispose()
        End Function

        Public Function CheckDuplicateWarehouse() As Boolean
            Dim dsWarehouse As DataSet
            Dim SQLStr As String = "Select * from Warehouse WHERE Warehouse = '" & mvarWarehouse & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouse, SQLStr) Then
                    If dsWarehouse.Tables(0).Rows.Count = 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
            dsWarehouse.Dispose()
        End Function

        Public Function WarehouseAreaExist(ByVal pWarehouse_ID As String) As Boolean
            Dim dsWarehouseArea As DataSet
            Dim SQLStr As String = "Select * from WarehouseArea WHERE Warehouse_ID = " & pWarehouse_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWarehouseArea, SQLStr) Then
                    If dsWarehouseArea.Tables(0).Rows.Count = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                End If
            End With
            dsWarehouseArea.Dispose()
        End Function

#End Region

#Region "Database management"
        Public Function Load(ByVal pWarehouse_ID As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM Warehouse"

                SQLStr = SQLStr & " WHERE Warehouse_ID =" & pWarehouse_ID

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Warehouse") Then
                        Warehouse = row("Warehouse").ToString()
                    Else
                        Warehouse = ""
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

        Public Function LoadList2(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                'Dim ds As DataSet
                Dim SQLStr As String = "SELECT Warehouse_ID, Description, Warehouse + ' - ' + Description As Warehouse FROM Warehouse"

                'SQLStr = SQLStr & " WHERE Warehouse_ID =" & pWarehouse_ID

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Warehouse") Then
                        Warehouse = row("Warehouse").ToString()
                    Else
                        Warehouse = ""
                    End If

                    If Not row.IsNull("Description") Then
                        Description = row("Description").ToString()
                    Else
                        Description = ""
                    End If

                    Return True
                    Else
                        Return False
                    End If
                End If
            End With
        End Function

        Public Function RecordExists(ByVal pWarehouse As String, Optional ByVal pWarehouse_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT Warehouse_ID FROM Warehouse"
            SQLStr = SQLStr & " WHERE Warehouse='" & pWarehouse & "'"

            If pWarehouse_ID <> Nothing And pWarehouse_ID <> 0 Then
                SQLStr = SQLStr & " AND Warehouse_ID<>" & pWarehouse_ID
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

#Region "Warehouse's Get n Let Property"
        Public Property Warehouse_ID() As Integer
            Get
                Return mvarWarehouse_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWarehouse_ID = Value
            End Set
        End Property

        Public Property Warehouse() As String
            Get
                Return mvarWarehouse
            End Get
            Set(ByVal Value As String)
                mvarWarehouse = Value
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
