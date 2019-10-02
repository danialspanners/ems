' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer


Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace ManUserProfileBusRules

    'Public Structure UserProfileStruct
    'Public modulename As String()
    'Public accessflag As String()
    'End Structure

    Public Class ManUserProfileLogic

#Region "User Profile Variables Initialization"

        Private mvarLoginID As String
        Private mvarLoginPassword As String
        Private mvarUserName As String
        Private mvarUserGroup As Integer
        Private mvarDepartment As Integer
        Private mvarUserID As Long
        Private mvarEmail As String
        'Private mvarUserProfile As UserProfileStruct

#End Region

#Region "User Group & Functions Variables Initialization"
        Private mvarGroup_ID As Long
        Private mvarUserGroup_Name As String
        Private mvarUserGroup_Description As String

        Private mvarFunc_ID As Long
        Private mvarAccess_Flg As String
        Private mvarApproval_Flg As String
        Private mvarDelete_Flg As String
        Private mvarInsert_Flg As String
        Private mvarUpdate_Flg As String
#End Region

#Region "User Profile database processes"

        Public Function Save(ByVal UserID As String) As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO UserProfile ("
            strSQL = strSQL & "Name, Login_ID, Login_Password, email, Group_ID, Department_ID, Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarUserName) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarUserName, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarLoginID) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarLoginID, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarLoginPassword) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarLoginPassword, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarEmail) > 0 Then
                strSQL = strSQL & "'" & Replace(mvarEmail, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarUserGroup > 0 Then
                strSQL = strSQL & mvarUserGroup & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If mvarDepartment > 0 Then
                strSQL = strSQL & mvarDepartment & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            strSQL = strSQL & " GetDate(), GetDate(), " & UserID

            strSQL = strSQL & ")"

            strSQL = strSQL & "(SELECT @@IDENTITY AS Login_ID from UserProfile)"

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
            'ds.Dispose()

        End Function

        Public Sub Delete(ByVal pLogin_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM UserProfile"
            strSQL = strSQL & " WHERE Login_ID='" & pLogin_ID & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub UpdatePassword(ByVal Login_ID As String)
            Dim strSQL As String
            Dim ds As DataSet
            strSQL = "Set dateformat dmy; Update UserProfile set "
            strSQL = strSQL & " Login_Password='" & Replace(mvarLoginPassword, "'", "''") & "',"
            strSQL = strSQL & " Transact_Date=GetDate()"
            strSQL = strSQL & " WHERE Login_ID = '" & Login_ID & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pLogin_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update UserProfile set "
            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarUserName) > 0 Then
                strSQL = strSQL & " Name= '" & Replace(mvarUserName, "'", "''") & "',"
            Else
                strSQL = strSQL & " Name= NULL,"
            End If

            If Len(mvarLoginPassword) > 0 Then
                strSQL = strSQL & " Login_Password= '" & Replace(mvarLoginPassword, "'", "''") & "',"
                'Else
                'strSQL = strSQL & " Login_Password= NULL,"
            End If

            If Len(mvarEmail) > 0 Then
                strSQL = strSQL & " Email= '" & Replace(mvarEmail, "'", "''") & "',"
                'Else
                'strSQL = strSQL & " Login_Password= NULL,"
            End If

            If mvarUserGroup > 0 Then
                strSQL = strSQL & " Group_ID= " & mvarUserGroup & ","
            Else
                strSQL = strSQL & " Group_ID= NULL,"
            End If

            If mvarUserID > 0 Then
                strSQL = strSQL & " UserID='" & mvarUserID & "',"
            Else
                strSQL = strSQL & " UserID = NULL"
            End If

            If mvarDepartment > 0 Then
                strSQL = strSQL & " Department_ID='" & mvarDepartment & "'"
            Else
                strSQL = strSQL & " Department_ID = NULL"
            End If

            strSQL = strSQL & " WHERE Login_ID = '" & pLogin_ID & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM UserProfile "


                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadList2(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT Login_ID, Login_ID + ' - ' + Name As Name, Group_ID, Department_ID FROM UserProfile "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(ByVal pLoginID As String) As Boolean
            Dim result As Boolean = False
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM UserProfile"

                SQLStr = SQLStr & " WHERE Login_ID ='" & pLoginID & "'"

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Name") Then
                        mvarUserName = row("Name").ToString()
                    Else
                        mvarUserName = ""
                    End If

                    If Not row.IsNull("Login_ID") Then
                        mvarLoginID = row("Login_ID").ToString()
                    Else
                        mvarLoginID = ""
                    End If

                    If Not row.IsNull("Email") Then
                        mvarEmail = row("Email").ToString()
                    Else
                        mvarEmail = ""
                    End If

                    If Not row.IsNull("Group_ID") Then
                        mvarUserGroup = row("Group_ID")
                    Else
                        mvarUserGroup = 0
                    End If

                    If Not row.IsNull("Department_ID") Then
                        mvarDepartment = row("Department_ID")
                    Else
                        mvarDepartment = 0
                    End If
                    result = True
                End If
                ds.Dispose()
            End With
            Return result
        End Function

        Public Function RecordExists(ByVal pLogin_ID As String, ByVal pPwd As String, Optional ByVal pName As String = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            Dim result As Boolean = False

            SQLStr = "SELECT Login_ID, User_ID FROM UserProfile"
            SQLStr = SQLStr & " WHERE Login_ID='" & pLogin_ID & "'"
            If pPwd <> "" Then
                SQLStr = SQLStr & " and Login_Password='" & pPwd & "'"
            End If
            'Debug.Write(SQLStr)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        result = False
                    Else
                        mvarUserID = ds.Tables(0).Rows(0)("User_ID")
                        result = True
                        'Load(pLogin_ID)
                    End If
                Else
                    Return result
                End If
                ds.Dispose()
            End With


            Return result
        End Function

        Public Function GetUser(ByRef ds As DataSet, Optional ByVal pUserID As String = "") As Boolean
            Dim strSQL As String

            strSQL = "Set dateformat dmy;Select *  FROM UserProfile"
            If Len(pUserID) > 0 Then
                strSQL = strSQL & " WHERE User_ID=" & pUserID
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

#End Region

#Region "User Group database processes"

        Public Function CreateUserGroup(ByVal UserID As String) As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO UserGroup ("
            strSQL = strSQL & "Name, Description, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarUserGroup_Name) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarUserGroup_Name, "'", "''") & "',"

            Else
                strSQL = strSQL & "'',"
            End If

            If Len(mvarUserGroup_Description) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarUserGroup_Description, "'", "''") & "',"
            Else
                strSQL = strSQL & "'',"
            End If

            If Len(UserID) > 0 Then
                strSQL = strSQL & UserID
            Else
                strSQL = strSQL & "Null"
            End If

            strSQL = strSQL & ")"

            strSQL = strSQL & "(SELECT @@IDENTITY AS UserID from UserGroup)"

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
        Public Function CreateUserGroupFunction(ByVal FuncDS As DataSet, ByVal UserID As String) As Integer
            Dim strSQL As String
            Dim ds As DataSet
            'Dim FuncDS As DataSet
            Dim i As Integer

            'Need to load all available functions
            'If LoadFunctions(FuncDS) Then

            For i = 0 To (FuncDS.Tables(0).Rows.Count - 1)
                If Not UserGroupFuncRecordExists(mvarGroup_ID, FuncDS.Tables(0).Rows(i)("Func_ID")) Then
                    strSQL = "Set dateformat dmy;INSERT INTO UserGroupFunction ("
                    strSQL = strSQL & "Group_ID, Func_ID, UserID "
                    strSQL = strSQL & ") VALUES("

                    If mvarGroup_ID > 0 Then
                        strSQL = strSQL & mvarGroup_ID & ", "
                    End If

                    If FuncDS.Tables(0).Rows(i)("Func_ID") > 0 Then
                        strSQL = strSQL & FuncDS.Tables(0).Rows(i)("Func_ID") & ", "
                    End If

                    strSQL = strSQL & UserID
                    strSQL = strSQL & ")"

                    With New DataAccess.DAccess.Access
                        Try
                            .GetDataSet(ds, strSQL)
                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                            Return 0
                        End Try
                    End With
                Else

                End If
            Next
            ds.Dispose()
            Return 1

        End Function

        Public Function LoadFunctions(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "SELECT * FROM Functions"

                If .GetDataSet(ds, SQLStr) And ds.Tables(0).Rows.Count > 0 Then
                    Return True
                End If
            End With
        End Function

        Public Function DeleteUserGroup(ByVal UserID As String)
            Dim strSQL As String
            Dim ds As DataSet

            'Delete User Group Function b4 delete UserGroup
            DeleteUserGroupFunction(UserID)

            strSQL = "Set dateformat dmy;DELETE FROM UserGroup"
            strSQL = strSQL & " WHERE Group_ID=" & mvarGroup_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Function

        Public Function DeleteUserGroupFunction(ByVal UserID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM UserGroupFunction"
            strSQL = strSQL & " WHERE Group_ID=" & mvarGroup_ID

            With New DataAccess.DAccess.Access
                .GetDataSet(ds, strSQL)
            End With
            ds.Dispose()
        End Function

        Public Sub UpdateUserGroup(ByVal UserID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update UserGroup set "
            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarUserGroup_Name) > 0 Then
                strSQL = strSQL & " Name= '" & Replace(mvarUserGroup_Name, "'", "''") & "',"
            Else
                strSQL = strSQL & " Name= '',"
            End If

            If Len(mvarUserGroup_Description) > 0 Then
                strSQL = strSQL & " Description= '" & Replace(mvarUserGroup_Description, "'", "''") & "',"
            Else
                strSQL = strSQL & " Description= '',"
            End If
            strSQL = strSQL & " UserID= " & UserID
            strSQL = strSQL & " WHERE Group_ID= " & mvarGroup_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function UpdateUserGroupFunction(ByVal FuncDS As DataSet, ByVal UserID As String)
            Dim strSQL As String
            Dim ds As DataSet
            Dim i As Integer

            For i = 0 To (FuncDS.Tables(0).Rows.Count - 1)
                If UserGroupFuncRecordExists(mvarGroup_ID, FuncDS.Tables(0).Rows(i)("Func_ID")) Then
                    strSQL = "Set dateformat dmy; Update UserGroupFunction set "
                    strSQL = strSQL & " Transact_Date=GetDate(),"
                    strSQL = strSQL & " Access_Flg= '" & mvarAccess_Flg & "',"
                    strSQL = strSQL & " Approval_Flg= '" & mvarApproval_Flg & "',"
                    strSQL = strSQL & " Delete_Flg= '" & mvarDelete_Flg & "',"
                    strSQL = strSQL & " Insert_Flg= '" & mvarInsert_Flg & "',"
                    strSQL = strSQL & " Update_Flg= '" & mvarUpdate_Flg & "'"
                    strSQL = strSQL & " WHERE Group_ID = " & mvarGroup_ID & " and Func_ID= " & mvarFunc_ID

                    With New DataAccess.DAccess.Access
                        If .ExecuteQuery(strSQL) Then
                        End If
                        'If .GetDataSet(ds, strSQL) Then
                        'End If
                    End With
                Else
                    'Create the UserGroup Functions
                    strSQL = "Set dateformat dmy;INSERT INTO UserGroupFunction ("
                    strSQL = strSQL & "Group_ID, Func_ID, UserID "
                    strSQL = strSQL & ") VALUES("
                    strSQL = strSQL & mvarGroup_ID & ", "
                    strSQL = strSQL & FuncDS.Tables(0).Rows(i)("Func_ID") & ", "
                    strSQL = strSQL & UserID
                    strSQL = strSQL & ")"

                    With New DataAccess.DAccess.Access
                        Try
                            .GetDataSet(ds, strSQL)
                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try
                    End With
                End If
            Next
            If Not ds Is Nothing Then
                ds.Dispose()
            End If
        End Function

        Public Function LoadGroupAccess(ByRef ds As DataSet, ByVal GroupID As Long) As Boolean
            Dim result As Boolean = False

            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "SELECT * FROM GroupAccess "
                SQLStr = SQLStr & " WHERE (Group_ID =" & GroupID
                SQLStr = SQLStr & ")"

                If .GetDataSet(ds, SQLStr) Then
                    result = True
                Else : result = False
                End If
            End With
            Return result
        End Function

        
        Public Function CheckGroupAccess(ByRef GroupID As Long, ByVal ModuleName As String, Optional ByVal Rights As String = "access") As Boolean
            Dim result As Boolean = False
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "SELECT * FROM GroupAccess "
                SQLStr = SQLStr & " WHERE (Group_ID =" & GroupID
                SQLStr = SQLStr & " and ModuleName = '" & ModuleName & "'"
                SQLStr = SQLStr & " and Rights = '" & Rights & "'"
                SQLStr = SQLStr & ")"

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        result = False
                    Else
                        result = True
                    End If
                Else : result = False
                End If
            End With
            Return result

        End Function

        Public Function UpdateGroupAccess(ByRef GroupID As Long, ByVal ModuleName As String, ByVal Access As Boolean, Optional ByVal Rights As String = "access") As Boolean
            Dim strSQL As String
            Dim result As Boolean = False
            Dim exist As Boolean = False

            exist = CheckGroupAccess(GroupID, ModuleName, Rights)

            If Access = True Then
                If exist = False Then
                    Dim ds As DataSet
                    strSQL = "Set dateformat dmy;INSERT INTO GroupAccess ("
                    strSQL = strSQL & "Group_ID, ModuleName, Rights"
                    strSQL = strSQL & ") VALUES("
                    strSQL = strSQL & GroupID & ", "
                    strSQL = strSQL & "'" & ModuleName & "', "
                    strSQL = strSQL & "'" & Rights & "'"
                    strSQL = strSQL & ")"

                    With New DataAccess.DAccess.Access
                        Try
                            .GetDataSet(ds, strSQL)
                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End With
                End If
            Else
                If exist = True Then
                    Dim ds As DataSet
                    strSQL = "Set dateformat dmy;Delete From GroupAccess "
                    strSQL = strSQL & "where "
                    strSQL = strSQL & "Group_ID = " & GroupID & " and "
                    strSQL = strSQL & "ModuleName ='" & ModuleName & "' and "
                    strSQL = strSQL & "Rights ='" & Rights & "'"
                    
                    With New DataAccess.DAccess.Access
                        Try
                            .GetDataSet(ds, strSQL)
                        Catch exLoad As System.Exception
                            System.Windows.Forms.MessageBox.Show(exLoad.Message)
                        End Try

                    End With
                End If

            End If

        End Function




        Public Function LoadUserGroup(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM UserGroup "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With

        End Function

        Public Function LoadUserGroupFunctions(ByRef ds As DataSet, ByVal GroupID As Long) As Boolean
            Dim result As Boolean = False
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "SELECT * FROM UserGroupFunction u INNER JOIN Functions f ON u.Func_ID = f.Func_ID"
                SQLStr = SQLStr & " WHERE (u.Group_ID =" & GroupID
                SQLStr = SQLStr & ")"

                If .GetDataSet(ds, SQLStr) Then
                    result = True
                Else : result = False
                End If
            End With
            Return result
        End Function

        Public Function LoadUserGroupList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT Group_ID, Name + ' - ' + Description As Name FROM UserGroup order by Name"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadUserGroup(ByVal GroupID As String) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM UserGroup"

                SQLStr = SQLStr & " WHERE Group_ID ='" & GroupID & "'"

                If .GetDataSet(ds, SQLStr) And ds.Tables(0).Rows.Count > 0 Then

                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Name") Then
                        mvarUserGroup_Name = row("Name").ToString()
                    Else
                        mvarUserGroup_Name = ""
                    End If

                    If Not row.IsNull("Description") Then
                        mvarUserGroup_Description = row("Description").ToString()
                    Else
                        mvarUserGroup_Description = ""
                    End If

                    Return True
                End If
            End With
        End Function

        Public Function UserGroupRecordExists(ByVal GroupID As Long, Optional ByVal pName As String = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT * FROM UserGroup"
            SQLStr = SQLStr & " WHERE Group_ID=" & GroupID

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

        Public Function UserGroupFuncRecordExists(ByVal GroupID As Long, ByVal FuncID As Long, Optional ByVal pName As String = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT * FROM UserGroupFunction"
            SQLStr = SQLStr & " WHERE Group_ID=" & GroupID & " and Func_ID=" & FuncID

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

#Region "User Profile Get and Let Property"

        Public Property UserID() As Long
            Get
                Return mvarUserID
            End Get
            Set(ByVal Value As Long)
                mvarUserID = Value
            End Set
        End Property

        Public Property LoginID() As String
            Get
                Return mvarLoginID
            End Get
            Set(ByVal Value As String)
                mvarLoginID = Value
            End Set
        End Property

        Public Property LoginPassword() As String
            Get
                Return mvarLoginPassword
            End Get
            Set(ByVal Value As String)
                mvarLoginPassword = Value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return mvarEmail
            End Get
            Set(ByVal Value As String)
                mvarEmail = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return mvarUserName
            End Get
            Set(ByVal Value As String)
                mvarUserName = Value
            End Set
        End Property

        Public Property UserGroup() As Long
            Get
                Return mvarUserGroup
            End Get
            Set(ByVal Value As Long)
                mvarUserGroup = Value
            End Set
        End Property

        Public Property Department() As Long
            Get
                Return mvarDepartment
            End Get
            Set(ByVal Value As Long)
                mvarDepartment = Value
            End Set
        End Property

#End Region

#Region "User Group n User Group Functions Get and Let Property"

        Public Property UserGroup_ID() As Long
            Get
                Return mvarGroup_ID
            End Get
            Set(ByVal Value As Long)
                mvarGroup_ID = Value
            End Set
        End Property

        Public Property UserGroup_Name() As String
            Get
                Return mvarUserGroup_Name
            End Get
            Set(ByVal Value As String)
                mvarUserGroup_Name = Value
            End Set
        End Property

        Public Property UserGroup_Description() As String
            Get
                Return mvarUserGroup_Description
            End Get
            Set(ByVal Value As String)
                mvarUserGroup_Description = Value
            End Set
        End Property

        Public Property Func_ID() As String
            Get
                Return mvarFunc_ID
            End Get
            Set(ByVal Value As String)
                mvarFunc_ID = Value
            End Set
        End Property

        Public Property Access_Flg() As String
            Get
                Return mvarAccess_Flg
            End Get
            Set(ByVal Value As String)
                mvarAccess_Flg = Value
            End Set
        End Property


        Public Property Approval_Flg() As String
            Get
                Return mvarApproval_Flg
            End Get
            Set(ByVal Value As String)
                mvarApproval_Flg = Value
            End Set
        End Property

        Public Property Delete_Flg() As String
            Get
                Return mvarDelete_Flg
            End Get
            Set(ByVal Value As String)
                mvarDelete_Flg = Value
            End Set
        End Property

        Public Property Insert_Flg() As String
            Get
                Return mvarInsert_Flg
            End Get
            Set(ByVal Value As String)
                mvarInsert_Flg = Value
            End Set
        End Property

        Public Property Update_Flg() As String
            Get
                Return mvarUpdate_Flg
            End Get
            Set(ByVal Value As String)
                mvarUpdate_Flg = Value
            End Set
        End Property

#End Region

    End Class

End Namespace
