Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace CategoryBusRules
    Public Class CategoryBusLogic
        '** CATEGORY **
        Private mvarCategory_ID As Integer
        Private mvarThread_ID As Integer
        Private mvarThread_Parent As Integer
        Private mvarThread_Level As Integer
        Private mvarName As String
        Private mvarDescription As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
        '****
#Region "Category SQL Statement"
        Public Function GetCategory(ByRef dsCategory As DataSet, Optional ByVal pCategory_ID As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String
                If pCategory_ID = 0 Then
                    SQLStr = "SELECT * FROM Category order by name asc"
                Else
                    SQLStr = "SELECT * FROM Category WHERE Category_ID = " & pCategory_ID
                End If

                If .GetDataSet(dsCategory, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveCategory() As Boolean
            Dim dscategory As DataSet
            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO Category (Thread_Parent,Thread_Level"
            SQLstr = SQLstr & ", Name, Description,Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "( " & Thread_Parent & "," & Thread_Level & ","
            SQLstr = SQLstr & "'" & mvarName & "','" & Description & "',GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dscategory, SQLstr) Then
                    Return True
                End If
            End With
            dscategory.Dispose()
        End Function

        Public Function UpdateCategory() As Boolean
            Dim dsCategory As DataSet
            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE Category SET "
            'SQLStr = SQLStr & " Thread_Parent= " & mvarThread_Parent & ","
            'SQLStr = SQLStr & " Thread_Level=" & mvarThread_Level & ","
            SQLStr = SQLStr & " Name = '" & mvarName & "',"
            SQLStr = SQLStr & " Description = '" & mvarDescription & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            '## Edited by Andrew
            SQLStr = SQLStr & " Category_ID = '" & mvarCategory_ID & "'"
            '## End

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsCategory, SQLStr) Then
                    Return True
                End If
            End With
            dsCategory.Dispose()
        End Function

        Public Function DeleteCategory() As Boolean
            Dim dsCategory As DataSet
            Dim SQLStr As String = "DELETE FROM Category WHERE Category_ID = " & mvarCategory_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsCategory, SQLStr) Then
                    Return True
                End If
            End With
            dsCategory.Dispose()
        End Function

        Public Function CheckDuplicateCategory() As Boolean
            Dim dsCategory As DataSet
            Dim SQLStr As String = "Select * from Category WHERE Name = '" & mvarName & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsCategory, SQLStr) Then
                    If dsCategory.Tables(0).Rows.Count = 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End With
            dsCategory.Dispose()
        End Function

        Public Function CheckRelatedTable(ByRef ds As DataSet) As Boolean
            Dim dsCategory As DataSet
            Dim SQLStr As String

            With New DataAccess.DAccess.Access
                'CHECK BUNDLE TABLE
                SQLStr = "SELECT * FROM Bundle WHERE Category_ID = " & mvarCategory_ID
                If .GetDataSet(dsCategory, SQLStr) Then
                    If Not dsCategory Is Nothing Then
                        Return True
                        dsCategory.Clear()
                        Exit Function
                    End If
                End If
                dsCategory.Clear()

                'CHECK BUNDLEPART TABLE
                SQLStr = "SELECT * FROM BundlePart WHERE Category_ID = " & mvarCategory_ID
                If .GetDataSet(dsCategory, SQLStr) Then
                    If Not dsCategory Is Nothing Then
                        Return True
                        dsCategory.Clear()
                        Exit Function
                    End If
                End If
                dsCategory.Clear()

                'CHECK POLINE TABLE
                SQLStr = "SELECT * FROM POLine WHERE Category_ID = " & mvarCategory_ID
                If .GetDataSet(dsCategory, SQLStr) Then
                    If Not dsCategory Is Nothing Then
                        Return True
                        dsCategory.Clear()
                        Exit Function
                    End If
                End If
                dsCategory.Clear()

                'CHECK PRLINE TABLE
                SQLStr = "SELECT * FROM PRLine WHERE category_ID = " & mvarCategory_ID
                If .GetDataSet(dsCategory, SQLStr) Then
                    If Not dsCategory Is Nothing Then
                        Return True
                        dsCategory.Clear()
                        Exit Function
                    End If
                End If
                dsCategory.Clear()

                'CHECK PRODUCT TABLE
                SQLStr = "SELECT * FROM Product WHERE Category_ID = " & mvarCategory_ID
                If .GetDataSet(dsCategory, SQLStr) Then
                    If Not dsCategory Is Nothing Then
                        Return True
                        dsCategory.Clear()
                        Exit Function
                    End If
                End If
                dsCategory.Clear()

                'CHECK QUOTATIONLINECOMPONENT
                SQLStr = "SELECT * FROM QuotationLineComponent WHERE Category_ID = " & mvarCategory_ID
                If .GetDataSet(dsCategory, SQLStr) Then
                    If Not dsCategory Is Nothing Then
                        Return True
                        dsCategory.Clear()
                        Exit Function
                    End If
                End If
                dsCategory.Clear()

                'CHECK CATEGORY TABLE
                SQLStr = "SELECT * FROM Category WHERE Thread_Parent = " & mvarCategory_ID
                If .GetDataSet(dsCategory, SQLStr) Then
                    If Not dsCategory Is Nothing Then
                        Return True
                        dsCategory.Clear()
                        Exit Function
                    End If
                End If
                dsCategory.Clear()
            End With
        End Function
#End Region

#Region "Category's Get n Let Property"
        Public Property Category_ID() As Integer
            Get
                Return mvarCategory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCategory_ID = Value
            End Set
        End Property

        Public Property Thread_ID() As Integer
            Get
                Return mvarThread_ID
            End Get
            Set(ByVal Value As Integer)
                mvarThread_ID = Value
            End Set
        End Property

        Public Property Thread_Parent() As Integer
            Get
                Return mvarThread_Parent
            End Get
            Set(ByVal Value As Integer)
                mvarThread_Parent = Value
            End Set
        End Property

        Public Property Thread_Level() As Integer
            Get
                Return mvarThread_Level
            End Get
            Set(ByVal Value As Integer)
                mvarThread_Level = Value
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

