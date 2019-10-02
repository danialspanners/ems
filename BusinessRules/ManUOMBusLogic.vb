' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer


Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace ManUOMBusRules
    Public Class ManUOMBusLogic

#Region "Variables Initialization"

        Private mvarUOM_ID As Integer
        Private mvarName As String
        Private mvarDescription As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

#Region "Product database processes"

        Public Function Save() As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO UnitMeasurement("
            strSQL = strSQL & "Name, Description, Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarName) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarName, "'", "''") & "',"

            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarDescription) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarDescription, "'", "''") & "',"

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

            strSQL = strSQL & "(SELECT @@IDENTITY AS UOM_ID from UnitMeasurement)"

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

        Public Sub Delete(ByVal pUOM_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM UnitMeasurement"
            strSQL = strSQL & " WHERE UOM_ID=" & pUOM_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pUOM_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update UnitMeasurement set "
            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarName) > 0 Then
                strSQL = strSQL & " Name= '" & Replace(mvarName, "'", "''") & "',"
            Else
                strSQL = strSQL & " Name= NULL,"
            End If

            If Len(mvarDescription) > 0 Then
                strSQL = strSQL & " Description= '" & Replace(mvarDescription, "'", "''") & "'"
            Else
                strSQL = strSQL & " Description= NULL"
            End If

            strSQL = strSQL & " WHERE UOM_ID = " & pUOM_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM UnitMeasurement "


                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadList2(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT UOM_ID, Name + ' - ' + Description As Name FROM UnitMeasurement "


                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(ByVal pUOM_ID As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM UnitMeasurement"

                SQLStr = SQLStr & " WHERE UOM_ID =" & pUOM_ID

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Name") Then
                        Name = row("Name").ToString()
                    Else
                        Name = ""
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

        Public Function RecordExists(ByVal pName As String, Optional ByVal pUOM_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT UOM_ID FROM UnitMeasurement"
            SQLStr = SQLStr & " WHERE Name='" & pName & "'"

            If pUOM_ID <> Nothing And pUOM_ID <> 0 Then
                SQLStr = SQLStr & " AND UOM_ID<>" & pUOM_ID
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

#Region "Get and Let Property"

        Public Property UOM_ID() As Integer
            Get
                Return mvarUOM_ID
            End Get
            Set(ByVal Value As Integer)
                mvarUOM_ID = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return mvarName
            End Get
            Set(ByVal Value As String)
                mvarName = Value
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
