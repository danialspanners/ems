Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Console
Imports DataAccess.DAccess

Namespace CommonConn

    Public Class Config
        Public Structure UserProfileStruct
            Public modulename As String()
            Public accessflag As String()
            Public approvalflag As String()
            Public insertflag As String()
            Public deleteflag As String()
            Public updateflag As String()
        End Structure

        Public Shared USERID
        Public Shared UserGroup
        Public Shared UserProfileDS As DataSet
        Public Shared UserProfile As UserProfileStruct
        Public Shared DBName As String
        Public Shared DBServer As String
        Public Shared UpdateFolder As String
        Public Shared Version As String
        Public Shared ConnString As String
        Public Shared SQLConnection As SQLConnection
        Public Shared SQLConnectionString As String
        Public Shared SQLDataAdapter As SqlDataAdapter
        Private mvarLoginID As String
        'Public mstrConnectionString As String

        Private Shared DBPassword As String = "vaio3930"

        Private Shared mstrConnectionString As String = "server=localhost;User ID=sa;Password=" & DBPassword & ";database=EMS"
        'Private Shared mstrConnectionString As String = "server=localhost;database=D2NJV91S\EMS;Trusted_Connection=yes"

        Dim config As Configuration.ConfigurationSettings


        ' Private mstrConnectionString = "server=" & config.AppSettings("server") & ";database=" & config.AppSettings("database") & ";Trusted_Connection=yes"

        Public Property ConnectionString() As String
            Set(ByVal Value As String)
                mstrConnectionString = Value
            End Set
            Get
                If DBName = "" Or DBServer = "" Then
                    'mstrConnectionString = "server=" & DBServer & ";database=" & DBName & ";Trusted_Connection=yes"
                    ConnectionString = mstrConnectionString
                    SQLConnectionString = ConnectionString
                Else
                    mstrConnectionString = "Provider=SQLOLEDB;Password=" & DBPassword & ";Persist Security Info=True;User ID=sa;Connect timeout=120;Initial Catalog=" & DBName & ";Data Source=" & DBServer
                    SQLConnectionString = "Password=" & DBPassword & ";Persist Security Info=True;User ID=sa;Initial Catalog=" & DBName & ";Connect timeout=0;Data Source=" & DBServer
                    'mstrConnectionString = "Server=" & DBServer & ";Database=" & DBName & ";User ID=sa;Password=vaio3930" ';Trusted_Connection=yes"
                    ConnectionString = mstrConnectionString
                End If
            End Get
        End Property

        Public Function CheckGroupAccess(ByVal com As Common.CommonConn.Config, ByVal pModuleName As String, Optional ByVal pAccessType As String = "access")
            Dim ModuleName = pModuleName.ToLower()
            Dim ds As DataSet
            Dim SQLStr As String
            Dim result As Boolean = False

            If com.UserGroup = 1 Then 'Administrator Grp
                Return True
            End If

            SQLStr = "SELECT * FROM GroupAccess"
            SQLStr = SQLStr & " WHERE Group_ID =" & com.UserGroup & " and ModuleName ='" & ModuleName & "' and Rights='" & pAccessType & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        result = False
                    Else
                        result = True
                    End If
                Else
                    Return result
                End If
                ds.Dispose()
            End With

            Return result

        End Function





        Public Function CheckUserProfileAccess(ByVal com As Common.CommonConn.Config, ByVal ModuleName As String) As Boolean
            CheckUserProfileAccess = False
            Dim i
            For i = 0 To (com.UserProfileDS.Tables(0).Rows.Count - 1)
                If com.UserProfile.modulename(i) = ModuleName And com.UserProfile.accessflag(i) = "1" Then
                    CheckUserProfileAccess = True
                    Exit For
                Else
                    CheckUserProfileAccess = False
                End If
            Next
        End Function

        Public Function CheckUserProfileApproval(ByVal com As Common.CommonConn.Config, ByVal ModuleName As String) As Boolean
            CheckUserProfileApproval = False
            Dim i
            For i = 0 To (com.UserProfileDS.Tables(0).Rows.Count - 1)
                If com.UserProfile.modulename(i) = ModuleName And com.UserProfile.approvalflag(i) = "1" Then
                    CheckUserProfileApproval = True
                    Exit For
                Else
                    CheckUserProfileApproval = False
                End If
            Next
        End Function

        Public Function CheckUserProfileInsert(ByVal com As Common.CommonConn.Config, ByVal ModuleName As String) As Boolean
            CheckUserProfileInsert = False
            Dim i
            For i = 0 To (com.UserProfileDS.Tables(0).Rows.Count - 1)
                If com.UserProfile.modulename(i) = ModuleName And com.UserProfile.insertflag(i) = "1" Then
                    CheckUserProfileInsert = True
                    Exit For
                Else
                    CheckUserProfileInsert = False
                End If
            Next
        End Function

        Public Function CheckUserProfileDelete(ByVal com As Common.CommonConn.Config, ByVal ModuleName As String) As Boolean
            CheckUserProfileDelete = False
            Dim i
            For i = 0 To (com.UserProfileDS.Tables(0).Rows.Count - 1)
                If com.UserProfile.modulename(i) = ModuleName And com.UserProfile.deleteflag(i) = "1" Then
                    CheckUserProfileDelete = True
                    Exit For
                Else
                    CheckUserProfileDelete = False
                End If
            Next
        End Function

        Public Function CheckUserProfileUpdate(ByVal com As Common.CommonConn.Config, ByVal ModuleName As String) As Boolean
            CheckUserProfileUpdate = False
            Dim i
            For i = 0 To (com.UserProfileDS.Tables(0).Rows.Count - 1)
                If com.UserProfile.modulename(i) = ModuleName And com.UserProfile.updateflag(i) = "1" Then
                    CheckUserProfileUpdate = True
                    Exit For
                Else
                    CheckUserProfileUpdate = False
                End If
            Next
        End Function
    End Class

End Namespace
