Option Explicit On 
Option Strict On

'Import the Libraries for Data Access used in this Class
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports Common.CommonConn

Namespace DAccess
    Public Class Access

        Public Function ExecuteQuery(ByVal SQLStr As String) As Boolean
            Dim rowCount As Integer = 0
            Dim Conn As SqlConnection
            If Common.CommonConn.Config.SQLConnection Is Nothing Then
                Conn = New SqlConnection(Common.CommonConn.Config.ConnString)
            Else
                Conn = Common.CommonConn.Config.SQLConnection
            End If

            Dim ExecuteCommand As New SqlClient.SqlCommand(SQLStr, Conn)
            Try
                Conn.Open()
                ExecuteCommand.CommandTimeout = 0
                rowCount = ExecuteCommand.ExecuteNonQuery()
            Catch ex As Exception
                Console.Write(ex.Message)
            Finally
                Conn.Close()
                If rowCount = 0 Then
                    ExecuteQuery = False
                Else
                    ExecuteQuery = True
                End If
            End Try

        End Function



        Private _Conn As SqlConnection
        Private _Trans As SqlTransaction

        Public Sub BeginTransaction()

            If Common.CommonConn.Config.SQLConnection Is Nothing Then
                _Conn = New SqlConnection(Common.CommonConn.Config.ConnString)
            Else
                _Conn = Common.CommonConn.Config.SQLConnection
            End If

            _Conn.Open()
            _Trans = _Conn.BeginTransaction

        End Sub

        Public Sub CommitTransaction()
            _Trans.Commit()
        End Sub

        Public Sub EndTransaction()

            _Conn.Close()

            _Trans.Dispose()
            _Trans = Nothing
            '_Conn.Dispose()
            '_Conn = Nothing

        End Sub

        Public Function ExecuteQueryNonCommit(ByVal SQLStr As String) As Boolean
            Dim rowCount As Integer = 0
            Dim ExecuteCommand As New SqlClient.SqlCommand(SQLStr, _Conn)
            Try
                ExecuteCommand.Transaction = _Trans
                ExecuteCommand.CommandTimeout = 0
                rowCount = ExecuteCommand.ExecuteNonQuery()
            Catch ex As Exception
                '"Failed to execute command"
                ExecuteQueryNonCommit = False
            Finally
                If rowCount = 0 Then
                    ExecuteQueryNonCommit = True
                Else
                    ExecuteQueryNonCommit = True
                End If
            End Try

        End Function

        Public Function GetDataSet(ByRef ds As DataSet, ByVal SQLStr As String, Optional ByVal IgnoreExpection As Boolean = False) As Boolean

            'With New Common.CommonConn.Config

            GetDataSet = False

            Dim dsData As DataSet = New DataSet

            'Set the Connection of the Command
            Dim Conn As SqlConnection '= New SqlConnection(Common.CommonConn.Config.ConnString)
            If Common.CommonConn.Config.SQLConnection Is Nothing Then
                Conn = New SqlConnection(Common.CommonConn.Config.ConnString)
            Else
                Conn = Common.CommonConn.Config.SQLConnection

            End If

            Try
                Dim daData As SqlDataAdapter '= New SqlDataAdapter(SQLStr, Conn)
                If Common.CommonConn.Config.SQLDataAdapter Is Nothing Then
                    daData = New SqlDataAdapter(SQLStr, Conn)
                Else
                    'Common.CommonConn.Config.SQLDataAdapter.SelectCommand.Connection = Conn
                    Common.CommonConn.Config.SQLDataAdapter.SelectCommand.CommandText = SQLStr
                    'daData = Common.CommonConn.Config.SQLDataAdapter
                    daData = New SqlDataAdapter(SQLStr, Conn)
                End If
                daData.SelectCommand.CommandTimeout = 0
                dsData.Clear()
                daData.Fill(dsData)

                ds = dsData
                GetDataSet = True
            Catch ex As Exception
                If IgnoreExpection = False Then
                    MsgBox(ex.Message)
                End If
            Finally
                Conn.Close()
            End Try
            'End With
        End Function

    End Class
End Namespace


